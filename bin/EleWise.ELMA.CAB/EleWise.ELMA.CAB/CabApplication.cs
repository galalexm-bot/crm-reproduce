using System;
using System.Configuration;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Security.Permissions;
using EleWise.ELMA.CAB.BuilderStrategies;
using EleWise.ELMA.CAB.Commands;
using EleWise.ELMA.CAB.Configuration;
using EleWise.ELMA.CAB.Instrumentation;
using EleWise.ELMA.CAB.Properties;
using EleWise.ELMA.CAB.Services;
using EleWise.ELMA.CAB.UIElements;
using EleWise.ELMA.CAB.Utility;
using EleWise.ELMA.CAB.Visualizer;
using Microsoft.Practices.ObjectBuilder;

namespace EleWise.ELMA.CAB;

public abstract class CabApplication<TWorkItem> : IDisposable where TWorkItem : WorkItem, new()
{
	private SettingsSection configuration;

	private TWorkItem rootWorkItem;

	private Type visualizerType;

	private IVisualizer visualizer;

	protected Type VisualizerType
	{
		get
		{
			return visualizerType;
		}
		set
		{
			if (value != null)
			{
				Guard.TypeIsAssignableFromType(value, typeof(IVisualizer), "VisualizerType");
			}
			visualizerType = value;
		}
	}

	protected virtual SettingsSection Configuration => configuration ?? (configuration = LoadConfiguration());

	public TWorkItem RootWorkItem => rootWorkItem;

	public void Run()
	{
		RegisterUnhandledExceptionHandler();
		Builder val = CreateBuilder();
		AddBuilderStrategies(val);
		CreateRootWorkItem(val);
		visualizer = CreateVisualizer();
		if (visualizer != null)
		{
			visualizer.Initialize(rootWorkItem, val);
		}
		AddRequiredServices();
		AddConfiguredServices();
		AddServices();
		AuthenticateUser();
		ProcessShellAssembly();
		rootWorkItem.BuildUp();
		LoadModules();
		rootWorkItem.FinishInitialization();
		rootWorkItem.Run();
		Start();
	}

	protected virtual void Stop()
	{
		rootWorkItem.Dispose();
		if (visualizer != null)
		{
			visualizer.Dispose();
		}
	}

	protected virtual void AddServices()
	{
	}

	protected IVisualizer CreateVisualizer()
	{
		if (visualizerType == null || Configuration.Visualizer.Count == 0)
		{
			return null;
		}
		return (IVisualizer)Activator.CreateInstance(visualizerType);
	}

	private void LoadModules()
	{
		IModuleLoaderService moduleLoaderService = rootWorkItem.Services.Get<IModuleLoaderService>(ensureExists: true);
		IModuleEnumerator moduleEnumerator = rootWorkItem.Services.Get<IModuleEnumerator>(ensureExists: true);
		if (moduleEnumerator != null)
		{
			moduleLoaderService.Load(rootWorkItem, moduleEnumerator.EnumerateModules());
		}
	}

	private void ProcessShellAssembly()
	{
		IModuleLoaderService moduleLoaderService = rootWorkItem.Services.Get<IModuleLoaderService>(ensureExists: true);
		Assembly entryAssembly = Assembly.GetEntryAssembly();
		if (entryAssembly != null)
		{
			moduleLoaderService.Load(rootWorkItem, entryAssembly);
		}
	}

	private void AuthenticateUser()
	{
		IAuthenticationService authenticationService = rootWorkItem.Services.Get<IAuthenticationService>(ensureExists: true);
		authenticationService.Authenticate();
	}

	private void AddConfiguredServices()
	{
		foreach (ServiceElement service in Configuration.Services)
		{
			Type type = service.ServiceType ?? service.InstanceType;
			if (rootWorkItem.Services.Get(type) != null)
			{
				rootWorkItem.Services.Remove(type);
			}
			object obj = rootWorkItem.Services.AddNew(service.InstanceType, type);
			if (obj is IConfigurable configurable)
			{
				configurable.Configure(service.Parameters);
			}
		}
	}

	private static SettingsSection LoadConfiguration()
	{
		object section = ConfigurationManager.GetSection("CompositeUI");
		SettingsSection settingsSection = section as SettingsSection;
		if (section != null && settingsSection == null)
		{
			throw new ConfigurationErrorsException(string.Format(CultureInfo.CurrentCulture, Resources.InvalidConfigurationSectionType, new object[2]
			{
				"CompositeUI",
				typeof(SettingsSection)
			}));
		}
		return settingsSection ?? new SettingsSection();
	}

	private void AddRequiredServices()
	{
		rootWorkItem.Services.AddNew<TraceSourceCatalogService, ITraceSourceCatalogService>();
		rootWorkItem.Services.AddNew<WorkItemExtensionService, IWorkItemExtensionService>();
		rootWorkItem.Services.AddNew<WorkItemTypeCatalogService, IWorkItemTypeCatalogService>();
		rootWorkItem.Services.AddNew<SimpleWorkItemActivationService, IWorkItemActivationService>();
		rootWorkItem.Services.AddNew<WindowsPrincipalAuthenticationService, IAuthenticationService>();
		rootWorkItem.Services.AddNew<ModuleLoaderService, IModuleLoaderService>();
		rootWorkItem.Services.AddNew<FileCatalogModuleEnumerator, IModuleEnumerator>();
		rootWorkItem.Services.AddOnDemand<DataProtectionCryptographyService, ICryptographyService>();
		rootWorkItem.Services.AddNew<CommandAdapterMapService, ICommandAdapterMapService>();
		rootWorkItem.Services.AddNew<UIElementAdapterFactoryCatalog, IUIElementAdapterFactoryCatalog>();
	}

	private void CreateRootWorkItem(Builder builder)
	{
		rootWorkItem = new TWorkItem();
		rootWorkItem.InitializeRootWorkItem(builder);
	}

	[SecurityPermission(SecurityAction.Demand, ControlAppDomain = true)]
	private void RegisterUnhandledExceptionHandler()
	{
		if (!Debugger.IsAttached && IsOnUnhandledExceptionOverridden())
		{
			AppDomain.CurrentDomain.UnhandledException += OnUnhandledException;
		}
	}

	private bool IsOnUnhandledExceptionOverridden()
	{
		return GetType().GetMethod("OnUnhandledException").DeclaringType != typeof(CabApplication<TWorkItem>);
	}

	private Builder CreateBuilder()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		Builder val = new Builder();
		((BuilderBase<BuilderStage>)(object)val).get_Strategies().AddNew<EventBrokerStrategy>((BuilderStage)2);
		((BuilderBase<BuilderStage>)(object)val).get_Strategies().AddNew<CommandStrategy>((BuilderStage)2);
		((BuilderBase<BuilderStage>)(object)val).get_Strategies().Add((IBuilderStrategy)(object)new RootWorkItemInitializationStrategy(OnRootWorkItemInitialized), (BuilderStage)2);
		((BuilderBase<BuilderStage>)(object)val).get_Strategies().AddNew<ObjectBuiltNotificationStrategy>((BuilderStage)3);
		((BuilderBase<BuilderStage>)(object)val).get_Policies().SetDefault<ISingletonPolicy>((ISingletonPolicy)new SingletonPolicy(true));
		((BuilderBase<BuilderStage>)(object)val).get_Policies().SetDefault<IBuilderTracePolicy>((IBuilderTracePolicy)new BuilderTraceSourcePolicy(new TraceSource("Microsoft.Practices.ObjectBuilder")));
		((BuilderBase<BuilderStage>)(object)val).get_Policies().SetDefault<ObjectBuiltNotificationPolicy>(new ObjectBuiltNotificationPolicy());
		return val;
	}

	protected virtual void OnRootWorkItemInitialized()
	{
	}

	protected virtual void AddBuilderStrategies(Builder builder)
	{
	}

	protected abstract void Start();

	public virtual void OnUnhandledException(object sender, UnhandledExceptionEventArgs e)
	{
	}

	public void Dispose()
	{
		Stop();
	}
}
