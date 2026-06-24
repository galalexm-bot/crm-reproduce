using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Bridge;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Dispatcher;

[Service]
internal class Dispatcher : IDispatcher
{
	[StructLayout(3)]
	private struct _003CDispatchInAction_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Dispatcher _003C_003E4__this;

		public ActionCommand command;

		private System.Collections.Generic.IEnumerator<IAsyncCommandHandler> _003C_003E7__wrap1;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Expected O, but got Unknown
			int num = _003C_003E1__state;
			Dispatcher dispatcher = _003C_003E4__this;
			try
			{
				if (num != 0)
				{
					_003C_003E7__wrap1 = dispatcher.asyncCommandHandlers.GetEnumerator();
				}
				try
				{
					if (num != 0)
					{
						goto IL_008e;
					}
					TaskAwaiter val = (TaskAwaiter)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_0088;
					IL_008e:
					if (((System.Collections.IEnumerator)_003C_003E7__wrap1).MoveNext())
					{
						val = _003C_003E7__wrap1.get_Current().HandleAsync(command).GetAwaiter();
						if (!val.get_IsCompleted())
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = val;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter, _003CDispatchInAction_003Ed__3>(ref val, ref this);
							return;
						}
						goto IL_0088;
					}
					goto end_IL_0023;
					IL_0088:
					val.GetResult();
					goto IL_008e;
					end_IL_0023:;
				}
				finally
				{
					if (num < 0 && _003C_003E7__wrap1 != null)
					{
						((System.IDisposable)_003C_003E7__wrap1).Dispose();
					}
				}
				_003C_003E7__wrap1 = null;
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

	private readonly System.Collections.Generic.IEnumerable<IAsyncCommandHandler> asyncCommandHandlers;

	public Dispatcher(System.Collections.Generic.IEnumerable<IAsyncCommandHandler> asyncCommandHandlers)
	{
		this.asyncCommandHandlers = asyncCommandHandlers;
	}

	public System.Threading.Tasks.Task Dispatch(ActionCommand command)
	{
		return CreateAction<Func<ActionCommand, System.Threading.Tasks.Task>>(DispatchInAction).Invoke(command);
	}

	private System.Threading.Tasks.Task DispatchInAction(ActionCommand command)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CDispatchInAction_003Ed__3 _003CDispatchInAction_003Ed__ = default(_003CDispatchInAction_003Ed__3);
		_003CDispatchInAction_003Ed__._003C_003E4__this = this;
		_003CDispatchInAction_003Ed__.command = command;
		_003CDispatchInAction_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CDispatchInAction_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = _003CDispatchInAction_003Ed__._003C_003Et__builder;
		((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003CDispatchInAction_003Ed__3>(ref _003CDispatchInAction_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CDispatchInAction_003Ed__._003C_003Et__builder)).get_Task();
	}

	[Obsolete("В дальнейшем переделать", false)]
	private TAction CreateAction<TAction>(TAction method)
	{
		return Script.Write<TAction>("method.isMobxAction ? method : mobx.action(method)", new object[0]);
	}
}
