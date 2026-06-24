using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using System.Web.Routing;
using Autofac;
using Autofac.Builder;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using Orchard.Caching;
using Orchard.Data;
using Orchard.Environment;
using Orchard.Environment.Configuration;
using Orchard.Exceptions;
using Orchard.FileSystems.VirtualPath;
using Orchard.Localization;
using Orchard.Tasks;

namespace Orchard.Commands;

public class CommandHostAgent
{
	private class CommandHostShellContainerRegistrations : IShellContainerRegistrations
	{
		public Action<ContainerBuilder> Registrations { get; set; }
	}

	private IContainer _hostContainer;

	public Localizer T { get; set; }

	public ILogger Logger { get; set; }

	public CommandHostAgent()
	{
		T = NullLocalizer.Instance;
		Logger = NullLogger.Instance;
	}

	public CommandReturnCodes RunSingleCommand(TextReader input, TextWriter output, string tenant, string[] args, Dictionary<string, string> switches)
	{
		CommandReturnCodes commandReturnCodes = StartHost(input, output);
		if (commandReturnCodes != 0)
		{
			return commandReturnCodes;
		}
		commandReturnCodes = RunCommand(input, output, tenant, args, switches);
		if (commandReturnCodes != 0)
		{
			return commandReturnCodes;
		}
		return StopHost(input, output);
	}

	public CommandReturnCodes RunCommand(TextReader input, TextWriter output, string tenant, string[] args, Dictionary<string, string> switches)
	{
		try
		{
			tenant = tenant ?? "Default";
			using (IWorkContextScope workContextScope = CreateStandaloneEnvironment(tenant))
			{
				ICommandManager commandManager = workContextScope.Resolve<ICommandManager>();
				if (!workContextScope.TryResolve<ITransactionManager>(out var service))
				{
					service = null;
				}
				CommandParameters parameters = new CommandParameters
				{
					Arguments = args,
					Switches = switches,
					Input = input,
					Output = output
				};
				try
				{
					commandManager.Execute(parameters);
				}
				catch
				{
					service?.Cancel();
					throw;
				}
			}
			return CommandReturnCodes.Ok;
		}
		catch (OrchardCommandHostRetryException ex)
		{
			output.WriteLine(T("{0} (Retrying...)", ex.Message));
			return CommandReturnCodes.Retry;
		}
		catch (Exception innerException)
		{
			if (innerException.IsFatal())
			{
				throw;
			}
			if (innerException is TargetInvocationException && innerException.InnerException != null)
			{
				innerException = innerException.InnerException;
			}
			OutputException(output, T("Error executing command \"{0}\"", string.Join(" ", args)), innerException);
			return CommandReturnCodes.Fail;
		}
	}

	public CommandReturnCodes StartHost(TextReader input, TextWriter output)
	{
		try
		{
			_hostContainer = CreateHostContainer();
			return CommandReturnCodes.Ok;
		}
		catch (OrchardCommandHostRetryException ex)
		{
			output.WriteLine(T("{0} (Retrying...)", ex.Message));
			return CommandReturnCodes.Retry;
		}
		catch (Exception ex2)
		{
			if (ex2.IsFatal())
			{
				throw;
			}
			OutputException(output, T("Error starting up Orchard command line host"), ex2);
			return CommandReturnCodes.Fail;
		}
	}

	public CommandReturnCodes StopHost(TextReader input, TextWriter output)
	{
		try
		{
			if (_hostContainer != null)
			{
				((IDisposable)_hostContainer).Dispose();
				_hostContainer = null;
			}
			return CommandReturnCodes.Ok;
		}
		catch (Exception ex)
		{
			if (ex.IsFatal())
			{
				throw;
			}
			OutputException(output, T("Error shutting down Orchard command line host"), ex);
			return CommandReturnCodes.Fail;
		}
	}

	private void OutputException(TextWriter output, LocalizedString title, Exception exception)
	{
		output.WriteLine();
		output.WriteLine(T("{0}", title));
		Stack<Exception> stack = new Stack<Exception>();
		for (Exception ex = exception; ex != null; ex = ex.InnerException)
		{
			stack.Push(ex);
		}
		exception = stack.Peek();
		output.WriteLine(T("--------------------------------------------------------------------------------"));
		output.WriteLine();
		output.WriteLine(T("{0}", exception.Message));
		output.WriteLine();
		if ((!(exception is OrchardException) && !(exception is OrchardCoreException)) || exception.InnerException != null)
		{
			output.WriteLine(T("Exception Details: {0}: {1}", exception.GetType().FullName, exception.Message));
			output.WriteLine();
			output.WriteLine(T("Stack Trace:"));
			output.WriteLine();
			foreach (Exception item in stack)
			{
				output.WriteLine(T("[{0}: {1}]", item.GetType().Name, item.Message));
				output.WriteLine(T("{0}", item.StackTrace));
				output.WriteLine();
			}
		}
		output.WriteLine("--------------------------------------------------------------------------------");
		output.WriteLine();
	}

	private IContainer CreateHostContainer()
	{
		IContainer obj = OrchardStarter.CreateHostContainer(ContainerRegistrations);
		ResolutionExtensions.Resolve<IOrchardHost>((IComponentContext)(object)obj).Initialize();
		return obj;
	}

	private IWorkContextScope CreateStandaloneEnvironment(string tenant)
	{
		IOrchardHost orchardHost = ResolutionExtensions.Resolve<IOrchardHost>((IComponentContext)(object)_hostContainer);
		IEnumerable<ShellSettings> source = ResolutionExtensions.Resolve<IShellSettingsManager>((IComponentContext)(object)_hostContainer).LoadSettings();
		if (source.Any())
		{
			ShellSettings shellSettings = source.SingleOrDefault((ShellSettings s) => string.Equals(s.Name, tenant, StringComparison.OrdinalIgnoreCase));
			if (shellSettings == null)
			{
				throw new OrchardCoreException(T("Tenant {0} does not exist", tenant));
			}
			return orchardHost.CreateStandaloneEnvironment(shellSettings);
		}
		ShellSettings shellSettings2 = new ShellSettings
		{
			Name = "Default",
			State = TenantState.Uninitialized
		};
		return orchardHost.CreateStandaloneEnvironment(shellSettings2);
	}

	protected void ContainerRegistrations(ContainerBuilder builder)
	{
		MvcSingletons(builder);
		RegistrationExtensions.RegisterType<CommandHostEnvironment>(builder).As<IHostEnvironment>().SingleInstance();
		RegistrationExtensions.RegisterType<CommandHostVirtualPathMonitor>(builder).As<IVirtualPathMonitor>().As<IVolatileProvider>()
			.SingleInstance();
		RegistrationExtensions.RegisterInstance<CommandHostShellContainerRegistrations>(builder, CreateShellRegistrations()).As<IShellContainerRegistrations>();
	}

	private CommandHostShellContainerRegistrations CreateShellRegistrations()
	{
		return new CommandHostShellContainerRegistrations
		{
			Registrations = delegate(ContainerBuilder shellBuilder)
			{
				RegistrationExtensions.RegisterType<CommandHostVirtualPathMonitor>(shellBuilder).As<IVirtualPathMonitor>().As<IVolatileProvider>()
					.SetScope<CommandHostVirtualPathMonitor, ConcreteReflectionActivatorData, SingleRegistrationStyle>(ServiceScope.Shell);
				RegistrationExtensions.RegisterType<CommandBackgroundService>(shellBuilder).As<IBackgroundService>().InstancePerLifetimeScope();
			}
		};
	}

	private static void MvcSingletons(ContainerBuilder builder)
	{
		RegistrationExtensions.Register<RouteCollection>(builder, (Func<IComponentContext, RouteCollection>)((IComponentContext ctx) => RouteTable.Routes)).SingleInstance();
		RegistrationExtensions.Register<ModelBinderDictionary>(builder, (Func<IComponentContext, ModelBinderDictionary>)((IComponentContext ctx) => ModelBinders.get_Binders())).SingleInstance();
		RegistrationExtensions.Register<ViewEngineCollection>(builder, (Func<IComponentContext, ViewEngineCollection>)((IComponentContext ctx) => ViewEngines.get_Engines())).SingleInstance();
	}
}
