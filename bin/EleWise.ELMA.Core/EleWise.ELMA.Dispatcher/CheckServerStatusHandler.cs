using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using EleWise.ELMA.Api.Services;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Ioc;
using EleWise.ELMA.Runtime;

namespace EleWise.ELMA.Dispatcher;

[Component]
internal sealed class CheckServerStatusHandler : AbstractAsyncCommandHandler
{
	[StructLayout(3)]
	private struct _003CHandleAsync_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ActionCommand command;

		public CheckServerStatusHandler _003C_003E4__this;

		private StartInformation _003Cinfo_003E5__2;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			CheckServerStatusHandler checkServerStatusHandler = _003C_003E4__this;
			try
			{
				TaskAwaiter<string> val;
				if (num == 0)
				{
					val = (TaskAwaiter<string>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_00b2;
				}
				if (!(command.ActionTypeId != "CheckServerStatusCommand"))
				{
					_003Cinfo_003E5__2 = command.Args[0] as StartInformation;
					if (_003Cinfo_003E5__2 != null)
					{
						val = checkServerStatusHandler.webServerStatusService.GetServerStatus("type=StartInfo").GetAwaiter();
						if (!val.get_IsCompleted())
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = val;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter<string>, _003CHandleAsync_003Ed__4>(ref val, ref this);
							return;
						}
						goto IL_00b2;
					}
				}
				goto end_IL_000e;
				IL_00b2:
				string[] array = val.GetResult().Split(new char[1] { ';' });
				_003Cinfo_003E5__2.Status = (StartStatus)System.Enum.Parse(typeof(StartStatus), array[0]);
				_003Cinfo_003E5__2.Percent = double.Parse(array[1]);
				_003Cinfo_003E5__2.HasErrors = array[2] != "0";
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

	private readonly ILazy<IWebServerStatusService> webServerStatusServiceLazy;

	private IWebServerStatusService webServerStatusService => webServerStatusServiceLazy.Value();

	public CheckServerStatusHandler(ILazy<IWebServerStatusService> webServerStatusServiceLazy)
	{
		this.webServerStatusServiceLazy = webServerStatusServiceLazy;
	}

	public override System.Threading.Tasks.Task HandleAsync(ActionCommand command)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CHandleAsync_003Ed__4 _003CHandleAsync_003Ed__ = default(_003CHandleAsync_003Ed__4);
		_003CHandleAsync_003Ed__._003C_003E4__this = this;
		_003CHandleAsync_003Ed__.command = command;
		_003CHandleAsync_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CHandleAsync_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = _003CHandleAsync_003Ed__._003C_003Et__builder;
		((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003CHandleAsync_003Ed__4>(ref _003CHandleAsync_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CHandleAsync_003Ed__._003C_003Et__builder)).get_Task();
	}
}
