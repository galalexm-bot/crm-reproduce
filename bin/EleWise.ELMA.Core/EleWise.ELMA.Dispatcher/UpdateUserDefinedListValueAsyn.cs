using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using EleWise.ELMA.Api.Services;
using EleWise.ELMA.Core.Abstractions.Metadata.Models;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.UI.Metadata;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.DTO;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Dispatcher;

public static class UpdateUserDefinedListValueAsyncConstants
{
	public const string CommandName = "UpdateUserDefinedListValue";
}
[Component]
internal sealed class UpdateUserDefinedListValueAsyncHandler : AbstractAsyncCommandHandler
{
	[StructLayout(3)]
	private struct _003CHandleAsync_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ActionCommand command;

		public UpdateUserDefinedListValueAsyncHandler _003C_003E4__this;

		private ReactiveProxy _003Ccontext_003E5__2;

		private UserDefinedListInfo _003Cudl_003E5__3;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_015c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0161: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			UpdateUserDefinedListValueAsyncHandler updateUserDefinedListValueAsyncHandler = _003C_003E4__this;
			try
			{
				TaskAwaiter<Entity[]> val;
				if (num == 0)
				{
					val = (TaskAwaiter<Entity[]>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_0147;
				}
				Guid uid;
				if (!(command.ActionTypeId != "UpdateUserDefinedListValue") && command.Args.Length > 1 && command.Args[1] is object[] array && array.Length > 2)
				{
					_003Ccontext_003E5__2 = array[0] as ReactiveProxy;
					if (_003Ccontext_003E5__2 != null)
					{
						ref UserDefinedListInfo reference = ref _003Cudl_003E5__3;
						object obj = array[1];
						reference = (UserDefinedListInfo)((obj is UserDefinedListInfo) ? obj : null);
						if (_003Cudl_003E5__3 != null)
						{
							object obj2 = array[2];
							ModelInfo val2 = (ModelInfo)((obj2 is ModelInfo) ? obj2 : null);
							if (val2 != null)
							{
								ReactiveProxy target = _003Ccontext_003E5__2;
								uid = _003Cudl_003E5__3.get_Uid();
								if (target.GetPlainPropertyValue(((object)(Guid)(ref uid)).ToString()) != null)
								{
									val = updateUserDefinedListValueAsyncHandler.entityService.UserDefinedListQuery(_003Cudl_003E5__3.get_Uid(), val2.get_SubTypeUid()).GetAwaiter();
									if (!val.get_IsCompleted())
									{
										num = (_003C_003E1__state = 0);
										_003C_003Eu__1 = val;
										((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter<Entity[]>, _003CHandleAsync_003Ed__2>(ref val, ref this);
										return;
									}
									goto IL_0147;
								}
							}
						}
					}
				}
				goto end_IL_000e;
				IL_0147:
				Entity[] result = val.GetResult();
				ReactiveProxy target2 = _003Ccontext_003E5__2;
				uid = _003Cudl_003E5__3.get_Uid();
				target2.SetPlainPropertyValue(((object)(Guid)(ref uid)).ToString(), result);
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

	private readonly IEntityService entityService;

	public UpdateUserDefinedListValueAsyncHandler(IEntityService entityService)
	{
		this.entityService = entityService;
	}

	public override System.Threading.Tasks.Task HandleAsync(ActionCommand command)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CHandleAsync_003Ed__2 _003CHandleAsync_003Ed__ = default(_003CHandleAsync_003Ed__2);
		_003CHandleAsync_003Ed__._003C_003E4__this = this;
		_003CHandleAsync_003Ed__.command = command;
		_003CHandleAsync_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CHandleAsync_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = _003CHandleAsync_003Ed__._003C_003Et__builder;
		((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003CHandleAsync_003Ed__2>(ref _003CHandleAsync_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CHandleAsync_003Ed__._003C_003Et__builder)).get_Task();
	}
}
