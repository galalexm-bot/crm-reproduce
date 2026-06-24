using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Bridge.Html5;
using Bridge.React;
using EleWise.ELMA.Core.React.Models;
using EleWise.ELMA.Model.ViewModel;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Core.React.Components;

public abstract class BaseInputComponent<TM, TContext, TController> : BaseReactComponent<BaseInputs<TM>, TContext, TController>, IInputComponent where TContext : IBaseInputs, IBaseContext where TController : IBaseInputController
{
	[StructLayout(3)]
	private struct _003CComponentDidMount_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public BaseInputComponent<TM, TContext, TController> _003C_003E4__this;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Expected O, but got Unknown
			int num = _003C_003E1__state;
			BaseInputComponent<TM, TContext, TController> CS_0024_003C_003E8__locals0 = _003C_003E4__this;
			try
			{
				TaskAwaiter val;
				if (num != 0)
				{
					val = CS_0024_003C_003E8__locals0._003C_003En__0().GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter, _003CComponentDidMount_003Ed__2>(ref val, ref this);
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
				CS_0024_003C_003E8__locals0.Dispatcher.Dispatch((Action<TController>)(object)(Action<_003F>)delegate
				{
					CS_0024_003C_003E8__locals0.FocusingInput(firstShow: true);
				});
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

	[StructLayout(3)]
	private struct _003CComponentDidUpdate_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public BaseInputComponent<TM, TContext, TController> _003C_003E4__this;

		public BaseReactProps<IReactInputModel<BaseInputs<TM>>> previousProps;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Expected O, but got Unknown
			int num = _003C_003E1__state;
			BaseInputComponent<TM, TContext, TController> CS_0024_003C_003E8__locals0 = _003C_003E4__this;
			try
			{
				TaskAwaiter val;
				if (num != 0)
				{
					val = CS_0024_003C_003E8__locals0._003C_003En__1(previousProps).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter, _003CComponentDidUpdate_003Ed__3>(ref val, ref this);
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
				CS_0024_003C_003E8__locals0.Dispatcher.Dispatch((Action<TController>)(object)(Action<_003F>)delegate
				{
					CS_0024_003C_003E8__locals0.FocusingInput(firstShow: false);
				});
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

	private bool isFocused;

	protected HTMLElement InputElement;

	protected override System.Type TypeViewModel => typeof(BaseInputViewModel);

	protected BaseInputComponent(IReactInputModel<BaseInputs<TM>> model)
		: base(model)
	{
	}

	protected override System.Threading.Tasks.Task ComponentDidMount()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		_003CComponentDidMount_003Ed__2 _003CComponentDidMount_003Ed__ = default(_003CComponentDidMount_003Ed__2);
		_003CComponentDidMount_003Ed__._003C_003E4__this = this;
		_003CComponentDidMount_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CComponentDidMount_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = _003CComponentDidMount_003Ed__._003C_003Et__builder;
		((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003CComponentDidMount_003Ed__2>(ref _003CComponentDidMount_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CComponentDidMount_003Ed__._003C_003Et__builder)).get_Task();
	}

	protected override System.Threading.Tasks.Task ComponentDidUpdate(BaseReactProps<IReactInputModel<BaseInputs<TM>>> previousProps)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CComponentDidUpdate_003Ed__3 _003CComponentDidUpdate_003Ed__ = default(_003CComponentDidUpdate_003Ed__3);
		_003CComponentDidUpdate_003Ed__._003C_003E4__this = this;
		_003CComponentDidUpdate_003Ed__.previousProps = previousProps;
		_003CComponentDidUpdate_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CComponentDidUpdate_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = _003CComponentDidUpdate_003Ed__._003C_003Et__builder;
		((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003CComponentDidUpdate_003Ed__3>(ref _003CComponentDidUpdate_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CComponentDidUpdate_003Ed__._003C_003Et__builder)).get_Task();
	}

	private void FocusingInput(bool firstShow)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		if (InputElement == null || Context.FocusableType == null)
		{
			return;
		}
		switch (Context.FocusableType.Invoke(firstShow))
		{
		case FocusableType.None:
			return;
		case FocusableType.Default:
			if (isFocused)
			{
				return;
			}
			isFocused = true;
			Window.SetTimeout((Action)delegate
			{
				HTMLElement inputElement2 = InputElement;
				if (inputElement2 != null)
				{
					inputElement2.Focus();
				}
			}, 100);
			return;
		}
		Window.SetTimeout((Action)delegate
		{
			HTMLElement inputElement = InputElement;
			if (inputElement != null)
			{
				inputElement.Focus();
			}
		}, 100);
	}

	internal sealed override ReactElement RenderInternal()
	{
		Context.FocusableType.Invoke(false);
		return base.RenderInternal();
	}

	protected void SetInputRef(HTMLElement element)
	{
		InputElement = element;
	}

	private void _003CComponentDidMount_003Eb__2_0(TController c)
	{
		FocusingInput(firstShow: true);
	}

	[DebuggerHidden]
	private System.Threading.Tasks.Task _003C_003En__0()
	{
		return base.ComponentDidMount();
	}

	private void _003CComponentDidUpdate_003Eb__3_0(TController c)
	{
		FocusingInput(firstShow: false);
	}

	[DebuggerHidden]
	private System.Threading.Tasks.Task _003C_003En__1(BaseReactProps<IReactInputModel<BaseInputs<TM>>> previousProps)
	{
		return base.ComponentDidUpdate(previousProps);
	}

	private void _003CFocusingInput_003Eb__4_0()
	{
		HTMLElement inputElement = InputElement;
		if (inputElement != null)
		{
			inputElement.Focus();
		}
	}

	private void _003CFocusingInput_003Eb__4_1()
	{
		HTMLElement inputElement = InputElement;
		if (inputElement != null)
		{
			inputElement.Focus();
		}
	}
}
public abstract class BaseInputComponent<TM, TController> : BaseInputComponent<TM, BaseContext<TM>, TController> where TController : BaseInputController<TM>
{
	protected BaseInputComponent(IReactInputModel<BaseInputs<TM>> model)
		: base(model)
	{
	}
}
public abstract class BaseInputComponent<TM> : BaseInputComponent<TM, BaseContext<TM>, BaseInputController>
{
	protected BaseInputComponent(IReactInputModel<BaseInputs<TM>> model)
		: base(model)
	{
	}
}
