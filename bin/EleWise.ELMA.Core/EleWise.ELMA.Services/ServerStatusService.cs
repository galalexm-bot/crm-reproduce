using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Dispatcher;
using EleWise.ELMA.Runtime;

namespace EleWise.ELMA.Services;

[Service]
internal sealed class ServerStatusService : IServerStatusService
{
	[StructLayout(3)]
	private struct _003CCheckServerStatus_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ServerStatusService _003C_003E4__this;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Expected O, but got Unknown
			//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fe: Expected O, but got Unknown
			//IL_014e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0154: Expected O, but got Unknown
			int num = _003C_003E1__state;
			ServerStatusService serverStatusService = _003C_003E4__this;
			try
			{
				TaskAwaiter val;
				switch (num)
				{
				default:
					val = serverStatusService.dispatcher.Dispatch(new ActionCommand("CheckServerStatusCommand", "", serverStatusService.GetCurrentStartInformation)).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter, _003CCheckServerStatus_003Ed__6>(ref val, ref this);
						return;
					}
					goto IL_0096;
				case 0:
					val = (TaskAwaiter)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_0096;
				case 1:
					val = (TaskAwaiter)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_010e;
				case 2:
					{
						val = (TaskAwaiter)_003C_003Eu__1;
						_003C_003Eu__1 = null;
						num = (_003C_003E1__state = -1);
						break;
					}
					IL_010e:
					val.GetResult();
					val = serverStatusService.CheckServerStatus().GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 2);
						_003C_003Eu__1 = val;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter, _003CCheckServerStatus_003Ed__6>(ref val, ref this);
						return;
					}
					break;
					IL_0096:
					val.GetResult();
					switch (serverStatusService.GetCurrentStartInformation.Status)
					{
					default:
						goto end_IL_000e;
					case StartStatus.Running:
						val = System.Threading.Tasks.Task.Delay(2000).GetAwaiter();
						if (!val.get_IsCompleted())
						{
							num = (_003C_003E1__state = 1);
							_003C_003Eu__1 = val;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter, _003CCheckServerStatus_003Ed__6>(ref val, ref this);
							return;
						}
						break;
					}
					goto IL_010e;
				}
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

	private readonly IBoundVariableService boundVariableService;

	private readonly IDispatcher dispatcher;

	private const string ServerStatusVariable = "StartInformation";

	public StartInformation GetCurrentStartInformation => boundVariableService.Get<StartInformation>("StartInformation");

	public ServerStatusService(IBoundVariableService boundVariableService, IReactiveModelFactory reactiveModelFactory, IDispatcher dispatcher)
	{
		this.boundVariableService = boundVariableService;
		this.dispatcher = dispatcher;
		StartInformation startInformation = reactiveModelFactory.CreateModel<StartInformation>();
		startInformation.Percent = 0.0;
		startInformation.HasErrors = false;
		startInformation.Status = StartStatus.Running;
		boundVariableService.Set("StartInformation", startInformation);
	}

	public System.Threading.Tasks.Task CheckServerStatus()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		_003CCheckServerStatus_003Ed__6 _003CCheckServerStatus_003Ed__ = default(_003CCheckServerStatus_003Ed__6);
		_003CCheckServerStatus_003Ed__._003C_003E4__this = this;
		_003CCheckServerStatus_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CCheckServerStatus_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = _003CCheckServerStatus_003Ed__._003C_003Et__builder;
		((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003CCheckServerStatus_003Ed__6>(ref _003CCheckServerStatus_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CCheckServerStatus_003Ed__._003C_003Et__builder)).get_Task();
	}
}
