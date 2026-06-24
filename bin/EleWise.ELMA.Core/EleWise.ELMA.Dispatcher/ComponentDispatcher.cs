using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using EleWise.ELMA.Core.Controllers;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.ViewModel;

namespace EleWise.ELMA.Dispatcher;

internal class ComponentDispatcher<TController> : IComponentDispatcher<TController>, IComponentDispatcher where TController : IController
{
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public Action method;

		internal void _003CDispatch_003Eb__0(TController c)
		{
			method.Invoke();
		}
	}

	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public Func<System.Threading.Tasks.Task> method;

		internal System.Threading.Tasks.Task _003CDispatch_003Eb__0()
		{
			return method.Invoke();
		}
	}

	[StructLayout(3)]
	private struct _003CDispatch_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Func<System.Threading.Tasks.Task> method;

		public ComponentDispatcher<TController> _003C_003E4__this;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c1: Expected O, but got Unknown
			int num = _003C_003E1__state;
			ComponentDispatcher<TController> componentDispatcher = _003C_003E4__this;
			try
			{
				if (num == 0)
				{
					goto IL_0046;
				}
				_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
				_003C_003Ec__DisplayClass6_.method = method;
				if (_003C_003Ec__DisplayClass6_.method != null)
				{
					GlobalScopeHelper.Push(componentDispatcher.viewModel);
					ViewModelHelper.SetData(componentDispatcher.viewModel);
					goto IL_0046;
				}
				goto end_IL_000e;
				IL_0046:
				try
				{
					TaskAwaiter val;
					if (num != 0)
					{
						val = componentDispatcher.dispatcher.Dispatch(new ActionCommand("ControllerCommand", "", componentDispatcher.controller, new Func<System.Threading.Tasks.Task>(_003C_003Ec__DisplayClass6_._003CDispatch_003Eb__0))).GetAwaiter();
						if (!val.get_IsCompleted())
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = val;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter, _003CDispatch_003Ed__6>(ref val, ref this);
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
				}
				finally
				{
					if (num < 0)
					{
						ViewModelHelper.RestoreData(componentDispatcher.viewModel);
						GlobalScopeHelper.Pop(componentDispatcher.viewModel);
					}
				}
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

	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public Action<TController> method;

		internal System.Threading.Tasks.Task _003CDispatch_003Eb__0(TController c)
		{
			method.Invoke(c);
			return System.Threading.Tasks.Task.get_CompletedTask();
		}
	}

	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public Func<TController, System.Threading.Tasks.Task> method;

		public ComponentDispatcher<TController> _003C_003E4__this;

		internal System.Threading.Tasks.Task _003CDispatch_003Eb__0()
		{
			return method.Invoke(_003C_003E4__this.controller);
		}
	}

	[StructLayout(3)]
	private struct _003CDispatchActionInternal_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ComponentDispatcher<TController> _003C_003E4__this;

		public string actionTypeProviderId;

		public string actionId;

		public object[] args;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_0096: Expected O, but got Unknown
			int num = _003C_003E1__state;
			ComponentDispatcher<TController> componentDispatcher = _003C_003E4__this;
			try
			{
				if (num != 0)
				{
					GlobalScopeHelper.Push(componentDispatcher.viewModel?.RenderOwner);
					ViewModelHelper.SetData(componentDispatcher.viewModel);
				}
				try
				{
					TaskAwaiter val;
					if (num != 0)
					{
						val = componentDispatcher.dispatcher.Dispatch(new ActionCommand(actionTypeProviderId, actionId, args)).GetAwaiter();
						if (!val.get_IsCompleted())
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = val;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter, _003CDispatchActionInternal_003Ed__10>(ref val, ref this);
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
				}
				finally
				{
					if (num < 0)
					{
						ViewModelHelper.RestoreData(componentDispatcher.viewModel);
						GlobalScopeHelper.Pop(componentDispatcher.viewModel?.RenderOwner);
						if (componentDispatcher.viewModel is IViewModelHandler viewModelHandler)
						{
							viewModelHandler.AfterAction();
						}
					}
				}
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

	private readonly IDispatcher dispatcher;

	private readonly IViewModel viewModel;

	private TController controller => (TController)viewModel.Controller;

	public ComponentDispatcher(IDispatcher dispatcher, IViewModel viewModel)
	{
		this.dispatcher = dispatcher;
		this.viewModel = viewModel;
	}

	public void Dispatch(Action method)
	{
		_003C_003Ec__DisplayClass5_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass5_0();
		CS_0024_003C_003E8__locals0.method = method;
		Dispatch((Action<TController>)delegate
		{
			CS_0024_003C_003E8__locals0.method.Invoke();
		});
	}

	public System.Threading.Tasks.Task Dispatch(Func<System.Threading.Tasks.Task> method)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CDispatch_003Ed__6 _003CDispatch_003Ed__ = default(_003CDispatch_003Ed__6);
		_003CDispatch_003Ed__._003C_003E4__this = this;
		_003CDispatch_003Ed__.method = method;
		_003CDispatch_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CDispatch_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = _003CDispatch_003Ed__._003C_003Et__builder;
		((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003CDispatch_003Ed__6>(ref _003CDispatch_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CDispatch_003Ed__._003C_003Et__builder)).get_Task();
	}

	public void Dispatch(Action<TController> method)
	{
		_003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass7_0();
		CS_0024_003C_003E8__locals0.method = method;
		Dispatch((Func<TController, System.Threading.Tasks.Task>)delegate(TController c)
		{
			CS_0024_003C_003E8__locals0.method.Invoke(c);
			return System.Threading.Tasks.Task.get_CompletedTask();
		});
	}

	public System.Threading.Tasks.Task Dispatch(Func<TController, System.Threading.Tasks.Task> method)
	{
		_003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass8_0();
		CS_0024_003C_003E8__locals0.method = method;
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		if (CS_0024_003C_003E8__locals0.method == null)
		{
			return System.Threading.Tasks.Task.get_CompletedTask();
		}
		return DispatchActionInternal("ControllerCommand", "", controller, (Func<System.Threading.Tasks.Task>)(() => CS_0024_003C_003E8__locals0.method.Invoke(CS_0024_003C_003E8__locals0._003C_003E4__this.controller)));
	}

	public System.Threading.Tasks.Task DispatchAction(string actionTypeProviderId, string actionId, params object[] args)
	{
		return DispatchActionInternal(actionTypeProviderId, actionId, viewModel, args);
	}

	private System.Threading.Tasks.Task DispatchActionInternal(string actionTypeProviderId, string actionId, params object[] args)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		_003CDispatchActionInternal_003Ed__10 _003CDispatchActionInternal_003Ed__ = default(_003CDispatchActionInternal_003Ed__10);
		_003CDispatchActionInternal_003Ed__._003C_003E4__this = this;
		_003CDispatchActionInternal_003Ed__.actionTypeProviderId = actionTypeProviderId;
		_003CDispatchActionInternal_003Ed__.actionId = actionId;
		_003CDispatchActionInternal_003Ed__.args = args;
		_003CDispatchActionInternal_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CDispatchActionInternal_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = _003CDispatchActionInternal_003Ed__._003C_003Et__builder;
		((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003CDispatchActionInternal_003Ed__10>(ref _003CDispatchActionInternal_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CDispatchActionInternal_003Ed__._003C_003Et__builder)).get_Task();
	}
}
