using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Bridge;
using Bridge.Html5;
using Bridge.React;
using EleWise.ELMA.Core.Controllers;
using EleWise.ELMA.Core.React.ExtensionPoints;
using EleWise.ELMA.Core.React.Helpers;
using EleWise.ELMA.Core.React.Models;
using EleWise.ELMA.Core.React.Services;
using EleWise.ELMA.Core.UI.Model;
using EleWise.ELMA.Dispatcher;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Ioc.Abstract;
using EleWise.ELMA.Model.ViewModel;

namespace EleWise.ELMA.Core.React.Components;

public abstract class BaseReactComponent<TInputs, TContext, TController> : PureComponent<BaseReactProps<IReactInputModel<TInputs>>>, IReactComponent, IRenderContent where TInputs : IInputs where TContext : IContext where TController : IController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<System.Type, bool> _003C_003E9__3_0;

		public static Action<TController> _003C_003E9__4_1;

		public static Action<TController> _003C_003E9__5_0;

		public static Func<TController, System.Threading.Tasks.Task> _003C_003E9__5_1;

		public static Action<TController> _003C_003E9__9_0;

		public static Func<TController, System.Threading.Tasks.Task> _003C_003E9__9_1;

		internal bool _003C_002Ector_003Eb__3_0(System.Type i)
		{
			return i == typeof(IRef);
		}

		internal void _003CInitializeViewModel_003Eb__4_1(TController c)
		{
			((IOnInit)(object)c).OnInit();
		}

		internal void _003CComponentDidMount_003Eb__5_0(TController c)
		{
			((IOnLoad)(object)c).OnLoad();
		}

		internal System.Threading.Tasks.Task _003CComponentDidMount_003Eb__5_1(TController c)
		{
			return ((IOnLoadAsync)(object)c).OnLoadAsync();
		}

		internal void _003CComponentWillUnmount_003Eb__9_0(TController c)
		{
			((IOnDestroy)(object)c).OnDestroy();
		}

		internal System.Threading.Tasks.Task _003CComponentWillUnmount_003Eb__9_1(TController c)
		{
			return ((IOnDestroyAsync)(object)c).OnDestroyAsync();
		}
	}

	[StructLayout(3)]
	private struct _003CComponentDidMount_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public BaseReactComponent<TInputs, TContext, TController> _003C_003E4__this;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			//IL_011d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0123: Expected O, but got Unknown
			int num = _003C_003E1__state;
			BaseReactComponent<TInputs, TContext, TController> baseReactComponent = _003C_003E4__this;
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
						goto IL_0133;
					}
					val = baseReactComponent._003C_003En__0().GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter, _003CComponentDidMount_003Ed__5>(ref val, ref this);
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
				if (baseReactComponent.Controller is IOnLoad)
				{
					baseReactComponent.Dispatcher.Dispatch((Action<TController>)(object)(Action<_003F>)delegate(TController c)
					{
						((IOnLoad)(object)c).OnLoad();
					});
				}
				if (baseReactComponent.Controller is IOnLoadAsync)
				{
					val = baseReactComponent.Dispatcher.Dispatch((Func<TController, System.Threading.Tasks.Task>)(object)(Func<_003F, System.Threading.Tasks.Task>)((TController c) => ((IOnLoadAsync)(object)c).OnLoadAsync())).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 1);
						_003C_003Eu__1 = val;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter, _003CComponentDidMount_003Ed__5>(ref val, ref this);
						return;
					}
					goto IL_0133;
				}
				goto end_IL_000e;
				IL_0133:
				val.GetResult();
				end_IL_000e:;
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

	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public BaseReactComponent<TInputs, TContext, TController> _003C_003E4__this;

		public System.Exception error;

		public ErrorStackModel info;

		internal void _003CComponentDidCatch_003Eb__0(TController c)
		{
			_003C_003E4__this.ViewModel.Error = true;
			_003C_003E4__this.ViewModel.ErrorMessage = ((object)error).ToString();
			_003C_003E4__this.ViewModel.ErrorInfo = info;
		}
	}

	private sealed class _003C_003Ec__DisplayClass13_0
	{
		public int i;

		internal ReactElement _003CComponentNotReadyView_003Eb__1(string e)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Expected O, but got Unknown
			//IL_0036: Expected O, but got Unknown
			Attributes val = new Attributes();
			((ReactDomElementAttributes<HTMLElement>)val).set_Key(Union<string, int>.op_Implicit(string.Concat((object)"error_", (object)i++)));
			return DOM.Div(val, e);
		}
	}

	private static System.Type scopedComponentType = typeof(IScopedComponent);

	protected internal ViewModel Model;

	public ReactElement ReactElement => PureComponent<BaseReactProps<IReactInputModel<BaseReactProps<IReactInputModel<TInputs>>>>>.op_Implicit((PureComponent<BaseReactProps<IReactInputModel<BaseReactProps<IReactInputModel<TInputs>>>>>)(object)this);

	public ViewModel ViewModel => Model;

	protected TController Controller
	{
		get
		{
			IController controller = ViewModel.Controller;
			if (controller == null)
			{
				return default(TController);
			}
			return (TController)controller;
		}
	}

	protected virtual System.Type TypeViewModel => typeof(ViewModel);

	protected virtual TContext Context
	{
		get
		{
			if (ViewModel.Context == null)
			{
				return default(TContext);
			}
			return (TContext)ViewModel.Context;
		}
	}

	protected virtual IComponentContainer Component => ViewModel.Component;

	protected IReactInputModel<TInputs> InputModel => ((PureComponent<BaseReactProps<IReactInputModel<BaseReactProps<IReactInputModel<TInputs>>>>>)(object)this).get_props().Model;

	protected virtual IComponentDispatcher<TController> Dispatcher => (IComponentDispatcher<TController>)ViewModel.ComponentDispatcher;

	protected BaseReactComponent(IReactInputModel<TInputs> model)
	{
		BaseReactProps<IReactInputModel<TInputs>> obj = new BaseReactProps<IReactInputModel<TInputs>>
		{
			Model = model
		};
		((BaseProps)obj).set_Key(Union<int, string>.op_Implicit(model.Key));
		((BasePropsWithChildren)obj).set_Children(((object)model.Inputs)?.get_Item("Children"));
		((BaseProps)obj).set_Ref(Enumerable.Any<System.Type>((System.Collections.Generic.IEnumerable<System.Type>)typeof(TInputs).GetInterfaces(), (Func<System.Type, bool>)((System.Type i) => i == typeof(IRef))) ? ((IRef)(object)model.Inputs).Ref : ((Action<HTMLElement>)Script.Undefined));
		((PureComponent<BaseReactProps<IReactInputModel<BaseReactProps<IReactInputModel<TInputs>>>>>)(object)this)._002Ector((BaseReactProps<IReactInputModel<BaseReactProps<IReactInputModel<TInputs>>>>)(object)obj, new Union<ReactElement, string>[0]);
	}

	protected sealed override void InitializeViewModel()
	{
		ILifetimeScope val = InputModel.RootScope;
		if (scopedComponentType.IsAssignableFrom(((object)this).GetType()))
		{
			val = val.BeginLifetimeScope(((object)this).GetType().get_Name());
		}
		Model = (ViewModel)((IScopeContext)val).Resolve<IViewModelCreatorService>().CreateModel(TypeViewModel);
		ViewModel.FillViewModel(() => InputModel, typeof(TContext), typeof(TController), this);
		if (Controller is IOnInit)
		{
			Dispatcher.Dispatch((Action<TController>)(object)(Action<_003F>)delegate(TController c)
			{
				((IOnInit)(object)c).OnInit();
			});
		}
	}

	protected override System.Threading.Tasks.Task ComponentDidMount()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		_003CComponentDidMount_003Ed__5 _003CComponentDidMount_003Ed__ = default(_003CComponentDidMount_003Ed__5);
		_003CComponentDidMount_003Ed__._003C_003E4__this = this;
		_003CComponentDidMount_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CComponentDidMount_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = _003CComponentDidMount_003Ed__._003C_003Et__builder;
		((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003CComponentDidMount_003Ed__5>(ref _003CComponentDidMount_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CComponentDidMount_003Ed__._003C_003Et__builder)).get_Task();
	}

	protected override System.Threading.Tasks.Task ComponentDidUpdate(BaseReactProps<IReactInputModel<TInputs>> previousProps)
	{
		return ((PureComponent<BaseReactProps<IReactInputModel<BaseReactProps<IReactInputModel<TInputs>>>>>)(object)this).ComponentDidUpdate((BaseReactProps<IReactInputModel<BaseReactProps<IReactInputModel<TInputs>>>>)(object)previousProps);
	}

	protected override void ComponentWillReact()
	{
		((PureComponent<BaseReactProps<IReactInputModel<BaseReactProps<IReactInputModel<TInputs>>>>>)(object)this).ComponentWillReact();
	}

	protected override void ComponentDidCatch(System.Exception error, ErrorStackModel info)
	{
		_003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass8_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.error = error;
		CS_0024_003C_003E8__locals0.info = info;
		Dispatcher.Dispatch((Action<TController>)(object)(Action<_003F>)delegate
		{
			CS_0024_003C_003E8__locals0._003C_003E4__this.ViewModel.Error = true;
			CS_0024_003C_003E8__locals0._003C_003E4__this.ViewModel.ErrorMessage = ((object)CS_0024_003C_003E8__locals0.error).ToString();
			CS_0024_003C_003E8__locals0._003C_003E4__this.ViewModel.ErrorInfo = CS_0024_003C_003E8__locals0.info;
		});
	}

	protected override System.Threading.Tasks.Task ComponentWillUnmount()
	{
		if (Controller is IOnDestroy)
		{
			Dispatcher.Dispatch((Action<TController>)(object)(Action<_003F>)delegate(TController c)
			{
				((IOnDestroy)(object)c).OnDestroy();
			});
		}
		if (Controller is IOnDestroyAsync)
		{
			Dispatcher.Dispatch((Func<TController, System.Threading.Tasks.Task>)(object)(Func<_003F, System.Threading.Tasks.Task>)((TController c) => ((IOnDestroyAsync)(object)c).OnDestroyAsync()));
		}
		Dispatcher.Dispatch((Action<TController>)(object)(Action<_003F>)delegate
		{
			ViewModel.DestroyValidation();
		});
		if (scopedComponentType.IsAssignableFrom(((object)this).GetType()) && ViewModel.HasProperty("$currentScope"))
		{
			((System.IDisposable)ObjectExtensions.As<ILifetimeScope>(((object)ViewModel).get_Item("$currentScope"))).Dispose();
		}
		Model.Destroy();
		return ((PureComponent<BaseReactProps<IReactInputModel<BaseReactProps<IReactInputModel<TInputs>>>>>)(object)this).ComponentWillUnmount();
	}

	public sealed override ReactElement Render()
	{
		GlobalScopeHelper.Push(ViewModel?.RenderOwner);
		ViewModelHelper.SetData(ViewModel);
		ReactElement result;
		try
		{
			result = ((!ViewModel.Ready) ? ComponentNotReadyView() : RenderInternal());
		}
		finally
		{
			ViewModelHelper.RestoreData(ViewModel);
			GlobalScopeHelper.Pop(ViewModel?.RenderOwner);
		}
		if (Model is IViewModelHandler viewModelHandler)
		{
			viewModelHandler.AfterView();
		}
		return result;
	}

	internal virtual ReactElement RenderInternal()
	{
		return View();
	}

	public abstract ReactElement View();

	protected virtual ReactElement ComponentNotReadyView()
	{
		if (ViewModel.Error)
		{
			_003C_003Ec__DisplayClass13_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass13_0();
			CS_0024_003C_003E8__locals0.i = 0;
			return ViewModel.ReactComponentCreatorService.Error(new BaseErrorInputs
			{
				Message = () => ViewModel.ErrorMessage,
				Children = Enumerable.Select<string, ReactElement>((System.Collections.Generic.IEnumerable<string>)ViewModel.ErrorInfo.get_Stack().Split(new char[1] { '\n' }), (Func<string, ReactElement>)delegate(string e)
				{
					//IL_0000: Unknown result type (might be due to invalid IL or missing references)
					//IL_0005: Unknown result type (might be due to invalid IL or missing references)
					//IL_0030: Expected O, but got Unknown
					//IL_0036: Expected O, but got Unknown
					Attributes val = new Attributes();
					((ReactDomElementAttributes<HTMLElement>)val).set_Key(Union<string, int>.op_Implicit(string.Concat((object)"error_", (object)CS_0024_003C_003E8__locals0.i++)));
					return DOM.Div(val, e);
				}).ToArray()
			}, ViewModel).ToReactElement();
		}
		return null;
	}

	private IInputModel _003CInitializeViewModel_003Eb__4_0()
	{
		return InputModel;
	}

	[DebuggerHidden]
	private System.Threading.Tasks.Task _003C_003En__0()
	{
		return ((PureComponent<BaseReactProps<IReactInputModel<BaseReactProps<IReactInputModel<TInputs>>>>>)(object)this).ComponentDidMount();
	}

	private void _003CComponentWillUnmount_003Eb__9_2(TController c)
	{
		ViewModel.DestroyValidation();
	}

	private string _003CComponentNotReadyView_003Eb__13_0()
	{
		return ViewModel.ErrorMessage;
	}
}
public abstract class BaseReactComponent<TInputs, TContext> : BaseReactComponent<TInputs, TContext, BaseReactController> where TInputs : IInputs where TContext : IContext
{
	protected BaseReactComponent(IReactInputModel<TInputs> model)
		: base(model)
	{
	}
}
public abstract class BaseReactComponent<TController> : BaseReactComponent<Inputs, Context, TController> where TController : IController
{
	protected BaseReactComponent(IReactInputModel<Inputs> model)
		: base(model)
	{
	}
}
public abstract class BaseReactComponent : BaseReactComponent<Inputs, Context>
{
	protected BaseReactComponent(IReactInputModel<Inputs> model)
		: base(model)
	{
	}
}
