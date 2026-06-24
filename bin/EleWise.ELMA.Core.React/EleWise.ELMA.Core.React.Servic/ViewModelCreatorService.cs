using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Bridge;
using EleWise.ELMA.Core.Abstractions.Metadata.Models;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Api;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Controllers;
using EleWise.ELMA.DTO;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Ioc.Abstract;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.ViewModel;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Scripts;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Core.React.Services;

[Service]
internal sealed class ViewModelCreatorService : IViewModelCreatorService
{
	[StructLayout(3)]
	private struct _003CInitClientController_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ViewModelCreatorService _003C_003E4__this;

		public IController controller;

		public IViewModel viewModel;

		public string controllerFullName;

		public string onLoadScriptName;

		public string defaultOnLoadScriptName;

		public ModelInfo modelInfo;

		public AdditionalModel[] additionalModels;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Expected O, but got Unknown
			//IL_0125: Unknown result type (might be due to invalid IL or missing references)
			//IL_012b: Expected O, but got Unknown
			//IL_0199: Unknown result type (might be due to invalid IL or missing references)
			//IL_019f: Expected O, but got Unknown
			int num = _003C_003E1__state;
			ViewModelCreatorService viewModelCreatorService = _003C_003E4__this;
			try
			{
				TaskAwaiter val;
				switch (num)
				{
				default:
					viewModelCreatorService.ExecuteOnInit(controller, viewModel);
					if (!string.IsNullOrEmpty(controllerFullName) && !string.IsNullOrEmpty(onLoadScriptName))
					{
						val = viewModelCreatorService.ExecuteServerOnLoad(controller, controllerFullName, onLoadScriptName, viewModel).GetAwaiter();
						if (!val.get_IsCompleted())
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = val;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter, _003CInitClientController_003Ed__19>(ref val, ref this);
							return;
						}
						goto IL_00ba;
					}
					if (defaultOnLoadScriptName != null)
					{
						val = viewModelCreatorService.ExecuteEql(controller, defaultOnLoadScriptName, viewModel, modelInfo, additionalModels).GetAwaiter();
						if (!val.get_IsCompleted())
						{
							num = (_003C_003E1__state = 1);
							_003C_003Eu__1 = val;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter, _003CInitClientController_003Ed__19>(ref val, ref this);
							return;
						}
						goto IL_013b;
					}
					goto IL_0141;
				case 0:
					val = (TaskAwaiter)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_00ba;
				case 1:
					val = (TaskAwaiter)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_013b;
				case 2:
					{
						val = (TaskAwaiter)_003C_003Eu__1;
						_003C_003Eu__1 = null;
						num = (_003C_003E1__state = -1);
						break;
					}
					IL_00ba:
					val.GetResult();
					goto IL_0141;
					IL_013b:
					val.GetResult();
					goto IL_0141;
					IL_0141:
					viewModelCreatorService.ExecuteOnLoad(controller, viewModel);
					val = viewModelCreatorService.ExecuteOnLoadAsync(controller, viewModel).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 2);
						_003C_003Eu__1 = val;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter, _003CInitClientController_003Ed__19>(ref val, ref this);
						return;
					}
					break;
				}
				val.GetResult();
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

	private sealed class _003C_003Ec__DisplayClass20_0
	{
		public IOnInit onInitController;

		internal void _003CExecuteOnInit_003Eb__0()
		{
			onInitController.OnInit();
		}
	}

	private sealed class _003C_003Ec__DisplayClass23_0
	{
		public IOnLoad onLoadController;

		internal void _003CExecuteOnLoad_003Eb__0()
		{
			onLoadController.OnLoad();
		}
	}

	private sealed class _003C_003Ec__DisplayClass24_0
	{
		public IOnLoadAsync onLoadAsyncController;

		internal System.Threading.Tasks.Task _003CExecuteOnLoadAsync_003Eb__0()
		{
			return onLoadAsyncController.OnLoadAsync();
		}
	}

	private sealed class _003C_003Ec__DisplayClass27_0
	{
		public ReactiveProxy model;

		public ReactiveProxy item;

		public bool updateModel;

		public IViewModel viewModel;

		public ViewModelCreatorService _003C_003E4__this;

		public ModelInfo modelInfo;
	}

	private sealed class _003C_003Ec__DisplayClass27_1
	{
		public MethodInfo method;

		public _003C_003Ec__DisplayClass27_0 CS_0024_003C_003E8__locals1;

		internal bool _003CCreateProxyServerController_003Eb__0(SerializedModelParam p)
		{
			if (!(p.MethodName == ((MemberInfo)method).get_Name()))
			{
				return p.MethodName == "$AllMethodName";
			}
			return true;
		}
	}

	private sealed class _003C_003Ec__DisplayClass27_2
	{
		public string methodName;

		public AdditionalModel[] modelsForMethod;

		public _003C_003Ec__DisplayClass27_1 CS_0024_003C_003E8__locals2;

		internal System.Threading.Tasks.Task _003CCreateProxyServerController_003Eb__2(IViewModel currentViewModel)
		{
			if (currentViewModel is IMetadataViewModel metadataViewModel)
			{
				ModelMetadata modelMetadata = metadataViewModel.ModelMetadata;
				if (modelMetadata.Metadata is TablePartMetadata)
				{
					ModelMetadata modelMetadata2 = modelMetadata.Root();
					if (modelMetadata2 != null)
					{
						CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.model = modelMetadata2.Model as ReactiveProxy;
						CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.item = ObjectExtensions.As<ReactiveProxy>(modelMetadata.GetModelFunc.Invoke());
						CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.updateModel = false;
						CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.viewModel = currentViewModel;
					}
				}
			}
			return CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1._003C_003E4__this.ScriptService.ExecuteScript(new ScriptExecutionParams(CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.model, CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.modelInfo, CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.viewModel, methodName, CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.item, CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.updateModel, modelsForMethod));
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<SerializedModelParam, AdditionalModel> _003C_003E9__27_1;

		internal AdditionalModel _003CCreateProxyServerController_003Eb__27_1(SerializedModelParam p)
		{
			return p.Model;
		}
	}

	private readonly ILifetimeScope currentScope;

	private const string ServerKey = "IServer";

	private IScriptService scriptService;

	private IReactiveModelFactory reactiveModelFactory;

	private IControllerFactory controllerFactory;

	private IProxyGeneratorService proxyGeneratorService;

	private IScriptService ScriptService => scriptService ?? (scriptService = ((IScopeContext)currentScope).Resolve<IScriptService>());

	private IReactiveModelFactory ReactiveModelFactory => reactiveModelFactory ?? (reactiveModelFactory = ((IScopeContext)currentScope).Resolve<IReactiveModelFactory>());

	private IControllerFactory ControllerFactory => controllerFactory ?? (controllerFactory = ((IScopeContext)currentScope).Resolve<IControllerFactory>());

	private IProxyGeneratorService ProxyGeneratorService => proxyGeneratorService ?? (proxyGeneratorService = ((IScopeContext)currentScope).Resolve<IProxyGeneratorService>());

	public ViewModelCreatorService(ILifetimeScope currentScope)
	{
		this.currentScope = currentScope;
	}

	public IController ControllerCreator(System.Type controllerType, IContext context, IViewModel viewModel, IViewItem viewItem = null)
	{
		IController controller;
		using (new ProxyGeneratorServiceContext(proxyGeneratorService))
		{
			controller = (IController)ControllerFactory.CreateController(controllerType);
		}
		controller.SetAndCreatePlainPropertyValue("Context", context);
		controller.SetAndCreatePlainPropertyValue("Component", viewModel.Component);
		controller.SetAndCreatePlainPropertyValue("$proxyGenerator", ProxyGeneratorService);
		if (controller is IRequireViewItemController requireViewItemController)
		{
			requireViewItemController.SetViewItem(viewItem);
		}
		if (controller is IRequireOwnerController requireOwnerController)
		{
			requireOwnerController.SetOwner(viewModel.RenderOwner);
		}
		return controller;
	}

	public T CreateModel<T>()
	{
		return (T)CreateModel(typeof(T));
	}

	public object CreateModel(System.Type type)
	{
		IViewModel obj = (IViewModel)ReactiveModelFactory.CreateModel(type);
		((object)obj).set_Item("$currentScope", (object)currentScope);
		return obj;
	}

	public string InitServerControllerProxy(IController controller, System.Type @namespace, string assemblyName, ModelInfo modelInfo, IViewModel viewModel, params SerializedModelParam[] additionalModels)
	{
		string serverControllerFullName = "";
		if (controller is IClientController clientController)
		{
			clientController.SetAndCreatePlainPropertyValue("Server", CreateProxyServerController(clientController.Context, @namespace, assemblyName, modelInfo, viewModel, out serverControllerFullName, additionalModels));
		}
		return serverControllerFullName;
	}

	public System.Threading.Tasks.Task InitClientController(IController controller, string controllerFullName, string onLoadScriptName, IDataStack dataStack, ModelInfo modelInfo, IViewModel viewModel, string defaultOnLoadScriptName, params AdditionalModel[] additionalModels)
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		_003CInitClientController_003Ed__19 _003CInitClientController_003Ed__ = default(_003CInitClientController_003Ed__19);
		_003CInitClientController_003Ed__._003C_003E4__this = this;
		_003CInitClientController_003Ed__.controller = controller;
		_003CInitClientController_003Ed__.controllerFullName = controllerFullName;
		_003CInitClientController_003Ed__.onLoadScriptName = onLoadScriptName;
		_003CInitClientController_003Ed__.modelInfo = modelInfo;
		_003CInitClientController_003Ed__.viewModel = viewModel;
		_003CInitClientController_003Ed__.defaultOnLoadScriptName = defaultOnLoadScriptName;
		_003CInitClientController_003Ed__.additionalModels = additionalModels;
		_003CInitClientController_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CInitClientController_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = _003CInitClientController_003Ed__._003C_003Et__builder;
		((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003CInitClientController_003Ed__19>(ref _003CInitClientController_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CInitClientController_003Ed__._003C_003Et__builder)).get_Task();
	}

	public void ExecuteOnInit(IController controller, IViewModel viewModel)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		_003C_003Ec__DisplayClass20_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass20_0();
		CS_0024_003C_003E8__locals0.onInitController = controller as IOnInit;
		if (CS_0024_003C_003E8__locals0.onInitController != null)
		{
			viewModel.ComponentDispatcher.Dispatch((Action)delegate
			{
				CS_0024_003C_003E8__locals0.onInitController.OnInit();
			});
		}
	}

	public System.Threading.Tasks.Task ExecuteServerOnLoad(IController controller, string controllerFullName, string onLoadScriptName, IViewModel viewModel)
	{
		if (!(controller is IClientController clientController))
		{
			return System.Threading.Tasks.Task.get_CompletedTask();
		}
		if (string.IsNullOrEmpty(controllerFullName) || string.IsNullOrEmpty(onLoadScriptName))
		{
			return System.Threading.Tasks.Task.get_CompletedTask();
		}
		int num = onLoadScriptName.IndexOf("(", (StringComparison)4);
		if (num != -1)
		{
			onLoadScriptName = onLoadScriptName.Substring(0, num);
		}
		string propertyName = controllerFullName + "$" + onLoadScriptName;
		Func<IViewModel, System.Threading.Tasks.Task> plainPropertyValue = clientController.Server.GetPlainPropertyValue<Func<IViewModel, System.Threading.Tasks.Task>>(propertyName);
		if (plainPropertyValue != null)
		{
			return plainPropertyValue.Invoke(viewModel);
		}
		if (viewModel is IFormViewModel formViewModel)
		{
			ModelInfo modelInfo = formViewModel.ModelMetadata.ModelInfo;
			return ScriptService.ExecuteScript(new ScriptExecutionParams(ObjectExtensions.As<ReactiveProxy>((object)clientController.Context), modelInfo, viewModel, onLoadScriptName));
		}
		return System.Threading.Tasks.Task.get_CompletedTask();
	}

	public System.Threading.Tasks.Task ExecuteEql(IController controller, string defaultOnLoadScriptName, IViewModel viewModel, ModelInfo modelInfo, params AdditionalModel[] additionalModels)
	{
		if (!(controller is IClientController clientController) || defaultOnLoadScriptName == null)
		{
			return System.Threading.Tasks.Task.get_CompletedTask();
		}
		return ScriptService.ExecuteScript(new ScriptExecutionParams(ObjectExtensions.As<ReactiveProxy>((object)clientController.Context), modelInfo, viewModel, defaultOnLoadScriptName, additionalModels));
	}

	public void ExecuteOnLoad(IController controller, IViewModel viewModel)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		_003C_003Ec__DisplayClass23_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass23_0();
		CS_0024_003C_003E8__locals0.onLoadController = controller as IOnLoad;
		if (CS_0024_003C_003E8__locals0.onLoadController != null)
		{
			viewModel.ComponentDispatcher.Dispatch((Action)delegate
			{
				CS_0024_003C_003E8__locals0.onLoadController.OnLoad();
			});
		}
	}

	public System.Threading.Tasks.Task ExecuteOnLoadAsync(IController controller, IViewModel viewModel)
	{
		_003C_003Ec__DisplayClass24_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass24_0();
		CS_0024_003C_003E8__locals0.onLoadAsyncController = controller as IOnLoadAsync;
		if (CS_0024_003C_003E8__locals0.onLoadAsyncController == null)
		{
			return System.Threading.Tasks.Task.get_CompletedTask();
		}
		return viewModel.ComponentDispatcher.Dispatch((Func<System.Threading.Tasks.Task>)(() => CS_0024_003C_003E8__locals0.onLoadAsyncController.OnLoadAsync()));
	}

	public System.Type GetServerControllerType(System.Type @namespace)
	{
		System.Type type = Script.Write<System.Type>("$namespace[{0}]", new object[1] { "IServer" });
		if (type == null)
		{
			return null;
		}
		return type;
	}

	public string GetServerControllerFullName(System.Type serverControllerInterfaceType, string assemblyName)
	{
		return assemblyName.Replace('.', '_') + "$" + serverControllerInterfaceType.get_FullName().Replace('.', '$').Replace('+', '$');
	}

	private IServerController CreateProxyServerController(IContext context, System.Type @namespace, string moduleName, ModelInfo modelInfo, IViewModel viewModel, out string serverControllerFullName, params SerializedModelParam[] additionalModels)
	{
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass27_0 _003C_003Ec__DisplayClass27_ = new _003C_003Ec__DisplayClass27_0();
		_003C_003Ec__DisplayClass27_.viewModel = viewModel;
		_003C_003Ec__DisplayClass27_._003C_003E4__this = this;
		_003C_003Ec__DisplayClass27_.modelInfo = modelInfo;
		serverControllerFullName = "";
		System.Type serverControllerType = GetServerControllerType(@namespace);
		serverControllerFullName = GetServerControllerFullName(serverControllerType, moduleName);
		ServerComponentControllerProxy serverComponentControllerProxy = new ServerComponentControllerProxy(serverControllerType);
		MethodInfo[] methods = serverControllerType.GetMethods();
		if (methods.Length == 0)
		{
			return serverComponentControllerProxy;
		}
		_003C_003Ec__DisplayClass27_.updateModel = true;
		_003C_003Ec__DisplayClass27_.model = null;
		_003C_003Ec__DisplayClass27_.item = null;
		if (_003C_003Ec__DisplayClass27_.viewModel is IMetadataViewModel metadataViewModel)
		{
			ModelMetadata modelMetadata = metadataViewModel.ModelMetadata;
			if (modelMetadata.Metadata is TablePartMetadata)
			{
				ModelMetadata modelMetadata2 = modelMetadata.Root();
				if (modelMetadata2 != null)
				{
					_003C_003Ec__DisplayClass27_.model = modelMetadata2.Model as ReactiveProxy;
					_003C_003Ec__DisplayClass27_.item = ObjectExtensions.As<ReactiveProxy>(modelMetadata.GetModelFunc.Invoke());
					_003C_003Ec__DisplayClass27_.updateModel = false;
				}
			}
		}
		if (_003C_003Ec__DisplayClass27_.model == null)
		{
			_003C_003Ec__DisplayClass27_.model = ObjectExtensions.As<ReactiveProxy>((object)context);
		}
		MethodInfo[] array = methods;
		for (int i = 0; i < array.Length; i++)
		{
			_003C_003Ec__DisplayClass27_1 _003C_003Ec__DisplayClass27_2 = new _003C_003Ec__DisplayClass27_1();
			_003C_003Ec__DisplayClass27_2.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass27_;
			_003C_003Ec__DisplayClass27_2.method = array[i];
			_003C_003Ec__DisplayClass27_2 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass27_2();
			CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2 = _003C_003Ec__DisplayClass27_2;
			CS_0024_003C_003E8__locals0.methodName = ((MemberInfo)CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2.method).get_Name();
			if (!ApiProvider.IsTask(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2.method.get_ReturnType()))
			{
				throw new ArgumentException(SR.T("Метод \"{0}\" должен иметь тип возвращаемого значения {1}", CS_0024_003C_003E8__locals0.methodName, typeof(System.Threading.Tasks.Task<>).get_FullName()));
			}
			CS_0024_003C_003E8__locals0.modelsForMethod = Enumerable.Where<SerializedModelParam>((System.Collections.Generic.IEnumerable<SerializedModelParam>)additionalModels, (Func<SerializedModelParam, bool>)((SerializedModelParam p) => p.MethodName == ((MemberInfo)CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2.method).get_Name() || p.MethodName == "$AllMethodName")).Select<AdditionalModel>((Func<SerializedModelParam, AdditionalModel>)((SerializedModelParam p) => p.Model)).ToArray();
			Func<IViewModel, System.Threading.Tasks.Task> value = delegate(IViewModel currentViewModel)
			{
				if (currentViewModel is IMetadataViewModel metadataViewModel2)
				{
					ModelMetadata modelMetadata3 = metadataViewModel2.ModelMetadata;
					if (modelMetadata3.Metadata is TablePartMetadata)
					{
						ModelMetadata modelMetadata4 = modelMetadata3.Root();
						if (modelMetadata4 != null)
						{
							CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.model = modelMetadata4.Model as ReactiveProxy;
							CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.item = ObjectExtensions.As<ReactiveProxy>(modelMetadata3.GetModelFunc.Invoke());
							CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.updateModel = false;
							CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.viewModel = currentViewModel;
						}
					}
				}
				return CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1._003C_003E4__this.ScriptService.ExecuteScript(new ScriptExecutionParams(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.model, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.modelInfo, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.viewModel, CS_0024_003C_003E8__locals0.methodName, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.item, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.updateModel, CS_0024_003C_003E8__locals0.modelsForMethod));
			};
			serverComponentControllerProxy.SetAndCreatePlainPropertyValue(serverControllerFullName + "$" + CS_0024_003C_003E8__locals0.methodName, value);
		}
		return serverComponentControllerProxy;
	}

	[Template("{0}")]
	private static extern Func<T> Lambda<T>(Func<T> x);
}
