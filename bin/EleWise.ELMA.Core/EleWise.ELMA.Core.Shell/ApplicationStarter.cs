using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using EleWise.ELMA.Cache;
using EleWise.ELMA.Core.Api;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Composite;
using EleWise.ELMA.Core.Ioc.Handlers;
using EleWise.ELMA.Core.Logging;
using EleWise.ELMA.Core.Services;
using EleWise.ELMA.Core.Storages;
using EleWise.ELMA.DTO;
using EleWise.ELMA.DynamicProxy.Handlers;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Initialization;
using EleWise.ELMA.Ioc.Abstract;
using EleWise.ELMA.Ioc.Abstract.Handlers;
using EleWise.ELMA.Ioc.Models;
using EleWise.ELMA.Ioc.Resolvers;
using EleWise.ELMA.Model;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Core.Shell;

public class ApplicationStarter<TApplication> : IApplicationStarter where TApplication : class, IApplication
{
	[StructLayout(3)]
	private struct _003CStart_003Ed__1 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ApplicationStarter<TApplication> _003C_003E4__this;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected O, but got Unknown
			//IL_0104: Unknown result type (might be due to invalid IL or missing references)
			//IL_010a: Expected O, but got Unknown
			//IL_0164: Unknown result type (might be due to invalid IL or missing references)
			//IL_016a: Expected O, but got Unknown
			int num = _003C_003E1__state;
			ApplicationStarter<TApplication> applicationStarter = _003C_003E4__this;
			try
			{
				TaskAwaiter val;
				if (num != 0)
				{
					if (num == 1)
					{
						val = (TaskAwaiter)_003C_003Eu__1;
						_003C_003Eu__1 = null;
						num = (_003C_003E1__state = -1);
						goto IL_017a;
					}
					SR.InitCulture();
					applicationStarter.iocContainer = (IContainer)new Container();
					((IScopeContext)applicationStarter.iocContainer).get_Registry().RegisterHandler((IHandler)(object)new TransientCreationHandler());
					((IScopeContext)applicationStarter.iocContainer).get_Registry().RegisterModule((IRegistryModule)(object)new LazyResolverModule());
					((IScopeContext)applicationStarter.iocContainer).get_Registry().RegisterModule((IRegistryModule)(object)new LoggerResolverModule());
					applicationStarter.BeforeInit(applicationStarter.iocContainer);
					ComponentManager componentManager = new ComponentManager(applicationStarter.iocContainer, ((IScopeContext)applicationStarter.iocContainer).Resolve<ILogger>());
					((IScopeContext)applicationStarter.iocContainer).get_Registry().RegisterInstance<IComponentManager>((IComponentManager)componentManager);
					((IScopeContext)applicationStarter.iocContainer).get_Registry().RegisterSingleInstance<IApplication, TApplication>();
					applicationStarter.OnInitializing(componentManager);
					applicationStarter.OnInitialized(applicationStarter.iocContainer);
					val = applicationStarter.OnInitializedAsync(applicationStarter.iocContainer).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter, _003CStart_003Ed__1>(ref val, ref this);
						return;
					}
				}
				else
				{
					val = (TaskAwaiter)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
				}
				val.GetResult();
				val = ((IScopeContext)applicationStarter.iocContainer).Resolve<IInitService>().Init().GetAwaiter();
				if (!val.get_IsCompleted())
				{
					num = (_003C_003E1__state = 1);
					_003C_003Eu__1 = val;
					((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter, _003CStart_003Ed__1>(ref val, ref this);
					return;
				}
				goto IL_017a;
				IL_017a:
				val.GetResult();
				((IScopeContext)applicationStarter.iocContainer).Resolve<IApplication>().Run();
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetResult();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetStateMachine(stateMachine);
		}
	}

	private IContainer iocContainer;

	public System.Threading.Tasks.Task Start()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		_003CStart_003Ed__1 _003CStart_003Ed__ = default(_003CStart_003Ed__1);
		_003CStart_003Ed__._003C_003E4__this = this;
		_003CStart_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CStart_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = _003CStart_003Ed__._003C_003Et__builder;
		((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003CStart_003Ed__1>(ref _003CStart_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CStart_003Ed__._003C_003Et__builder)).get_Task();
	}

	public System.Threading.Tasks.Task Restart()
	{
		((System.IDisposable)iocContainer).Dispose();
		return Start();
	}

	public System.Threading.Tasks.Task Update()
	{
		((IScopeContext)iocContainer).Resolve<IApplication>().Run();
		return System.Threading.Tasks.Task.get_CompletedTask();
	}

	protected virtual void BeforeInit(IContainer container)
	{
	}

	protected virtual void OnInitializing(IComponentManager componentManager)
	{
		componentManager.Init(AppDomain.get_CurrentDomain().GetAssemblies());
	}

	protected virtual void OnInitialized(IContainer container)
	{
		IRequestService requestService = ((IScopeContext)container).Resolve<IRequestService>();
		IApplication application = ((IScopeContext)container).Resolve<IApplication>();
		IApplicationData applicationData = ((IScopeContext)container).Resolve<IApplicationData>();
		application.Use(new RequestHandler(requestService, applicationData));
		System.Collections.Generic.IEnumerable<IServerActionExecutionHandler> actionExecutionHandlers = ((IScopeContext)container).Resolve<System.Collections.Generic.IEnumerable<IServerActionExecutionHandler>>();
		IDescriptorService descriptorService = ((IScopeContext)container).Resolve<IDescriptorService>();
		ISystemProxyMetadataReferencesStorage systemMetadataReferencesStorage = ((IScopeContext)container).Resolve<ISystemProxyMetadataReferencesStorage>();
		application.Use(new GlobalFunctionHandler(actionExecutionHandlers, descriptorService, systemMetadataReferencesStorage));
		System.Collections.Generic.IEnumerable<IDeserialization> deserializations = ((IScopeContext)container).Resolve<System.Collections.Generic.IEnumerable<IDeserialization>>();
		application.Use(new DeserializeHandler(deserializations));
	}

	protected virtual System.Threading.Tasks.Task OnInitializedAsync(IContainer container)
	{
		IApplicationData applicationData = ((IScopeContext)container).Resolve<IApplicationData>();
		ILocalStorage localStorage = ((IScopeContext)container).Resolve<ILocalStorage>();
		if (applicationData.Version != localStorage.GetItem<string>("Version") || applicationData.UIVersion != localStorage.GetItem<string>("UIVersion") || applicationData.RuntimeModelHash != localStorage.GetItem<string>("RuntimeModelHash") || SR.CurrentCulture.get_Name() != localStorage.GetItem<string>("Culture"))
		{
			System.Collections.Generic.IEnumerator<ICacheService> enumerator = ((IScopeContext)container).Resolve<System.Collections.Generic.IEnumerable<ICacheService>>().GetEnumerator();
			try
			{
				while (((System.Collections.IEnumerator)enumerator).MoveNext())
				{
					enumerator.get_Current().Clear();
				}
			}
			finally
			{
				((System.IDisposable)enumerator)?.Dispose();
			}
			localStorage.SetItem("Version", applicationData.Version);
			localStorage.SetItem("UIVersion", applicationData.UIVersion);
			localStorage.SetItem("RuntimeModelHash", applicationData.RuntimeModelHash);
			localStorage.SetItem("Culture", SR.CurrentCulture.get_Name());
		}
		return ((IScopeContext)container).Resolve<IServerStatusService>().CheckServerStatus();
	}
}
