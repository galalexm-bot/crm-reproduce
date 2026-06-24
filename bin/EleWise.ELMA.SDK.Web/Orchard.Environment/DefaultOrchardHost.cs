using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Web;
using EleWise.ELMA;
using EleWise.ELMA.Events;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime;
using Orchard.Caching;
using Orchard.Environment.Configuration;
using Orchard.Environment.Descriptor;
using Orchard.Environment.Descriptor.Models;
using Orchard.Environment.Extensions;
using Orchard.Environment.ShellBuilders;
using Orchard.Environment.State;
using Orchard.Localization;
using Orchard.Logging;
using Orchard.Mvc;
using Orchard.Mvc.Extensions;
using Orchard.Utility;
using Orchard.Utility.Extensions;

namespace Orchard.Environment;

public class DefaultOrchardHost : IOrchardHost, IShellSettingsManagerEventHandler, IEventHandler, IShellDescriptorManagerEventHandler
{
	private class StandaloneEnvironmentWorkContextScopeWrapper : IWorkContextScope, IDisposable
	{
		private readonly ShellContext _shellContext;

		private readonly IWorkContextScope _workContextScope;

		public WorkContext WorkContext => _workContextScope.WorkContext;

		public StandaloneEnvironmentWorkContextScopeWrapper(IWorkContextScope workContextScope, ShellContext shellContext)
		{
			_workContextScope = workContextScope;
			_shellContext = shellContext;
		}

		public TService Resolve<TService>()
		{
			return _workContextScope.Resolve<TService>();
		}

		public bool TryResolve<TService>(out TService service)
		{
			return _workContextScope.TryResolve<TService>(out service);
		}

		public void Dispose()
		{
			_workContextScope.Dispose();
			_shellContext.Dispose();
		}
	}

	private readonly IHostLocalRestart _hostLocalRestart;

	private readonly IShellSettingsManager _shellSettingsManager;

	private readonly IShellContextFactory _shellContextFactory;

	private readonly IRunningShellTable _runningShellTable;

	private readonly IExtensionLoaderCoordinator _extensionLoaderCoordinator;

	private readonly IExtensionMonitoringCoordinator _extensionMonitoringCoordinator;

	private readonly ICacheManager _cacheManager;

	private readonly IHttpContextAccessor _httpContextAccessor;

	private static readonly object _syncLock = new object();

	private static readonly object _shellContextsWriteLock = new object();

	private readonly NamedReaderWriterLock _shellActivationLock = new NamedReaderWriterLock();

	private IEnumerable<ShellContext> _shellContexts;

	private readonly ContextState<IList<ShellSettings>> _tenantsToRestart;

	public int Retries { get; set; }

	public bool DelayRetries { get; set; }

	public Localizer T { get; set; }

	public ILogger Logger { get; set; }

	public IList<ShellContext> Current => BuildCurrent().ToReadOnlyCollection();

	public DefaultOrchardHost(IShellSettingsManager shellSettingsManager, IShellContextFactory shellContextFactory, IRunningShellTable runningShellTable, IExtensionLoaderCoordinator extensionLoaderCoordinator, IExtensionMonitoringCoordinator extensionMonitoringCoordinator, ICacheManager cacheManager, IHostLocalRestart hostLocalRestart, IHttpContextAccessor httpContextAccessor)
	{
		_shellSettingsManager = shellSettingsManager;
		_shellContextFactory = shellContextFactory;
		_runningShellTable = runningShellTable;
		_extensionLoaderCoordinator = extensionLoaderCoordinator;
		_extensionMonitoringCoordinator = extensionMonitoringCoordinator;
		_cacheManager = cacheManager;
		_hostLocalRestart = hostLocalRestart;
		_httpContextAccessor = httpContextAccessor;
		_tenantsToRestart = new ContextState<IList<ShellSettings>>("DefaultOrchardHost.TenantsToRestart", () => new List<ShellSettings>());
		T = NullLocalizer.Instance;
		Logger = NullLogger.Instance;
	}

	public ShellContext GetShellContext(ShellSettings shellSettings)
	{
		return BuildCurrent().SingleOrDefault((ShellContext shellContext) => shellContext.Settings.Name.Equals(shellSettings.Name));
	}

	void IOrchardHost.Initialize()
	{
		Logger.Information("Initializing");
		BuildCurrent();
		Logger.Information("Initialized");
	}

	void IOrchardHost.ReloadExtensions()
	{
		DisposeShellContext();
	}

	void IOrchardHost.BeginRequest()
	{
		Logger.Debug("BeginRequest");
		BeginRequest();
	}

	void IOrchardHost.EndRequest()
	{
		Logger.Debug("EndRequest");
		EndRequest();
	}

	IWorkContextScope IOrchardHost.CreateStandaloneEnvironment(ShellSettings shellSettings)
	{
		Logger.Debug("Creating standalone environment for tenant {0}", shellSettings.Name);
		MonitorExtensions();
		BuildCurrent();
		ShellContext shellContext = CreateShellContext(shellSettings);
		return new StandaloneEnvironmentWorkContextScopeWrapper(shellContext.LifetimeScope.CreateWorkContextScope(), shellContext);
	}

	private IEnumerable<ShellContext> BuildCurrent()
	{
		if (_shellContexts == null)
		{
			lock (_syncLock)
			{
				if (_shellContexts == null)
				{
					SetupExtensions();
					MonitorExtensions();
					CreateAndActivateShells();
				}
			}
		}
		return _shellContexts;
	}

	private void StartUpdatedShells()
	{
		while (_tenantsToRestart.GetState().Any())
		{
			ShellSettings shellSettings = _tenantsToRestart.GetState().First();
			_tenantsToRestart.GetState().Remove(shellSettings);
			Logger.Debug("Updating shell: " + shellSettings.Name);
			lock (_syncLock)
			{
				ActivateShell(shellSettings);
			}
		}
	}

	private void CreateAndActivateShells()
	{
		Logger.Information("Start creation of shells");
		ShellSettings[] array = (from settings in _shellSettingsManager.LoadSettings()
			where settings.State == TenantState.Running || settings.State == TenantState.Uninitialized || settings.State == TenantState.Initializing
			select settings).ToArray();
		if (array.Any())
		{
			Array.ForEach(array, delegate(ShellSettings settings)
			{
				ShellContext context2 = null;
				for (int i = 0; i <= Retries; i++)
				{
					if (DelayRetries && i > 0)
					{
						Thread.Sleep(TimeSpan.FromSeconds(Math.Pow(i, 2.0)));
					}
					try
					{
						using (StartInformation.Operation(30.0, SR.M("Создание контекста оболочки")))
						{
							context2 = CreateShellContext(settings);
						}
						using (StartInformation.Operation(63.0, SR.M("Активация контекста оболочки")))
						{
							ActivateShell(context2);
							break;
						}
					}
					catch (Exception ex)
					{
						if (ex.InnerException is ReflectionTypeLoadException ex2)
						{
							string text = string.Join("\n\r", ex2.LoaderExceptions.Select((Exception e) => e.ToString()).ToArray());
							EleWise.ELMA.Logging.Logger.Log.Fatal(ex, "A tenant could not be started: {0}. {1}", settings.Name, text);
							throw;
						}
						if (i == Retries)
						{
							EleWise.ELMA.Logging.Logger.Log.Fatal(ex, "A tenant could not be started: {0} after {1} retries.", settings.Name, Retries);
							throw;
						}
						EleWise.ELMA.Logging.Logger.Log.Error(ex, "A tenant could not be started: " + settings.Name + " Attempt number: " + i);
					}
				}
			});
		}
		else
		{
			ShellContext context = CreateSetupContext();
			ActivateShell(context);
		}
		Logger.Information("Done creating shells");
	}

	private void ActivateShell(ShellContext context)
	{
		Logger.Debug("Activating context for tenant {0}", context.Settings.Name);
		context.Shell.Activate();
		lock (_shellContextsWriteLock)
		{
			_shellContexts = (_shellContexts ?? Enumerable.Empty<ShellContext>()).Where((ShellContext c) => c.Settings.Name != context.Settings.Name).Concat(new ShellContext[1] { context }).ToArray();
		}
		_runningShellTable.Add(context.Settings);
	}

	private ShellContext CreateSetupContext()
	{
		Logger.Debug("Creating shell context for root setup.");
		return _shellContextFactory.CreateSetupContext(new ShellSettings
		{
			Name = "Default"
		});
	}

	private ShellContext CreateShellContext(ShellSettings settings)
	{
		if (settings.State == TenantState.Uninitialized || settings.State == TenantState.Invalid)
		{
			Logger.Debug("Creating shell context for tenant {0} setup.", settings.Name);
			return _shellContextFactory.CreateSetupContext(settings);
		}
		Logger.Debug("Creating shell context for tenant {0}.", settings.Name);
		return _shellContextFactory.CreateShellContext(settings);
	}

	private void SetupExtensions()
	{
		_extensionLoaderCoordinator.SetupExtensions();
	}

	private void MonitorExtensions()
	{
	}

	private void DisposeShellContext()
	{
		Logger.Information("Disposing active shell contexts");
		if (_shellContexts == null)
		{
			return;
		}
		lock (_syncLock)
		{
			if (_shellContexts != null)
			{
				foreach (ShellContext shellContext in _shellContexts)
				{
					shellContext.Shell.Terminate();
					shellContext.Dispose();
				}
			}
		}
		_shellContexts = null;
	}

	protected virtual void BeginRequest()
	{
		BlockRequestsDuringSetup();
		Action ensureInitialized = delegate
		{
			MonitorExtensions();
			BuildCurrent();
		};
		ShellSettings shellSettings = null;
		HttpContextBase httpContextBase = _httpContextAccessor.Current();
		if (httpContextBase != null)
		{
			shellSettings = _runningShellTable.Match(httpContextBase);
		}
		if (shellSettings == null)
		{
			ensureInitialized();
		}
		else
		{
			_shellActivationLock.RunWithReadLock(shellSettings.Name, delegate
			{
				ensureInitialized();
			});
		}
		StartUpdatedShells();
	}

	protected virtual void EndRequest()
	{
		StartUpdatedShells();
	}

	void IShellSettingsManagerEventHandler.Saved(ShellSettings settings)
	{
		Logger.Debug("Shell saved: " + settings.Name);
		if (settings.State != TenantState.Invalid && !_tenantsToRestart.GetState().Any((ShellSettings t) => t.Name.Equals(settings.Name)))
		{
			Logger.Debug("Adding tenant to restart: " + settings.Name + " " + settings.State);
			_tenantsToRestart.GetState().Add(settings);
		}
	}

	public void ActivateShell(ShellSettings settings)
	{
		Logger.Debug("Activating shell: " + settings.Name);
		ShellContext shellContext = _shellContexts.FirstOrDefault((ShellContext c) => c.Settings.Name == settings.Name);
		if (shellContext == null && settings.State == TenantState.Disabled)
		{
			return;
		}
		if (shellContext == null || settings.State == TenantState.Uninitialized)
		{
			ShellContext context = CreateShellContext(settings);
			ActivateShell(context);
			return;
		}
		if (settings.State == TenantState.Disabled)
		{
			shellContext.Shell.Terminate();
			_runningShellTable.Remove(settings);
			_shellContexts = _shellContexts.Where((ShellContext shell) => shell.Settings.Name != settings.Name).ToArray();
			shellContext.Dispose();
			return;
		}
		_shellActivationLock.RunWithWriteLock(settings.Name, delegate
		{
			shellContext.Shell.Terminate();
			ShellContext shellContext2 = _shellContextFactory.CreateShellContext(settings);
			_shellContexts = _shellContexts.Where((ShellContext shell) => shell.Settings.Name != settings.Name).Union(new ShellContext[1] { shellContext2 }).ToArray();
			shellContext.Dispose();
			shellContext2.Shell.Activate();
			_runningShellTable.Update(settings);
		});
	}

	void IShellDescriptorManagerEventHandler.Changed(ShellDescriptor descriptor, string tenant)
	{
		if (_shellContexts != null)
		{
			Logger.Debug("Shell changed: " + tenant);
			ShellContext shellContext = _shellContexts.FirstOrDefault((ShellContext x) => x.Settings.Name == tenant);
			if (shellContext != null && shellContext.Settings.State == TenantState.Running && !_tenantsToRestart.GetState().Any((ShellSettings x) => x.Name == tenant))
			{
				Logger.Debug("Adding tenant to restart: " + tenant);
				_tenantsToRestart.GetState().Add(shellContext.Settings);
			}
		}
	}

	private void BlockRequestsDuringSetup()
	{
		HttpContextBase httpContextBase = _httpContextAccessor.Current();
		if (!httpContextBase.IsBackgroundContext())
		{
			ShellSettings shellSettings = _runningShellTable.Match(httpContextBase);
			if (shellSettings != null && shellSettings.State == TenantState.Initializing)
			{
				HttpResponseBase response = httpContextBase.Response;
				response.StatusCode = 503;
				response.StatusDescription = "This tenant is currently initializing. Please try again later.";
				response.Write("This tenant is currently initializing. Please try again later.");
			}
		}
	}
}
