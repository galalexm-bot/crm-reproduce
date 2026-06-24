using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Controllers;
using EleWise.ELMA.Core.Logging;
using EleWise.ELMA.Core.Services;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.ViewModel;

namespace EleWise.ELMA.Dispatcher;

[Component]
internal sealed class ComponentControllerTypeHandler : AbstractAsyncCommandHandler
{
	[StructLayout(3)]
	private struct _003CHandleAsync_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ActionCommand command;

		public ComponentControllerTypeHandler _003C_003E4__this;

		private IViewModel _003CviewModel_003E5__2;

		private string _003CactionId_003E5__3;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f4: Expected O, but got Unknown
			//IL_0261: Unknown result type (might be due to invalid IL or missing references)
			//IL_0268: Expected O, but got Unknown
			int num = _003C_003E1__state;
			ComponentControllerTypeHandler componentControllerTypeHandler = _003C_003E4__this;
			try
			{
				if ((uint)num <= 1u)
				{
					goto IL_017a;
				}
				IViewModel viewModel = default(IViewModel);
				IController controller = default(IController);
				DataStack dataStack = default(DataStack);
				if (!(command.ActionTypeId != "ComponentControllerTypeCommand") && command.Args.Length != 0)
				{
					_003CviewModel_003E5__2 = command.Args[0] as IViewModel;
					viewModel = _003CviewModel_003E5__2?.RenderOwner;
					if (viewModel != null)
					{
						controller = viewModel.Controller;
						if (controller != null)
						{
							dataStack = _003CviewModel_003E5__2.InputModel.GetPlainPropertyValue<DataStack>("DataStack").Clone() as DataStack;
							if (dataStack != null && command.Args[1] != null)
							{
								if (command.Args[1] is System.Array array)
								{
									System.Collections.IEnumerator enumerator = array.GetEnumerator();
									try
									{
										while (enumerator.MoveNext())
										{
											object current = enumerator.get_Current();
											((HashSet<DataStackItem>)dataStack).Add(new DataStackItem(new Data<object>
											{
												Item = current
											}));
										}
									}
									finally
									{
										if (num < 0 && enumerator is System.IDisposable disposable)
										{
											disposable.Dispose();
										}
									}
								}
								else
								{
									((HashSet<DataStackItem>)dataStack).Add(new DataStackItem(new Data<object>
									{
										Item = command.Args[1]
									}));
								}
							}
							GlobalScopeHelper.Push(_003CviewModel_003E5__2.RenderOwner);
							ViewModelHelper.SetData(_003CviewModel_003E5__2);
							_003CactionId_003E5__3 = command.ActionId;
							goto IL_017a;
						}
					}
				}
				goto end_IL_000e;
				IL_017a:
				try
				{
					TaskAwaiter val;
					if (num == 0)
					{
						val = (TaskAwaiter)_003C_003Eu__1;
						_003C_003Eu__1 = null;
						num = (_003C_003E1__state = -1);
						goto IL_0204;
					}
					if (num == 1)
					{
						val = (TaskAwaiter)_003C_003Eu__1;
						_003C_003Eu__1 = null;
						num = (_003C_003E1__state = -1);
						goto IL_0278;
					}
					if (viewModel is IFormViewModel formViewModel)
					{
						if (ViewModelHelper.CallControllerMethod(formViewModel.Controllers, _003CactionId_003E5__3, dataStack) is System.Threading.Tasks.Task task)
						{
							val = task.GetAwaiter();
							if (!val.get_IsCompleted())
							{
								num = (_003C_003E1__state = 0);
								_003C_003Eu__1 = val;
								((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter, _003CHandleAsync_003Ed__3>(ref val, ref this);
								return;
							}
							goto IL_0204;
						}
					}
					else if (ViewModelHelper.CallControllerMethod(controller, _003CactionId_003E5__3, dataStack) is System.Threading.Tasks.Task task2)
					{
						val = task2.GetAwaiter();
						if (!val.get_IsCompleted())
						{
							num = (_003C_003E1__state = 1);
							_003C_003Eu__1 = val;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter, _003CHandleAsync_003Ed__3>(ref val, ref this);
							return;
						}
						goto IL_0278;
					}
					goto end_IL_017b;
					IL_0278:
					val.GetResult();
					goto end_IL_017b;
					IL_0204:
					val.GetResult();
					end_IL_017b:;
				}
				catch (System.Exception ex)
				{
					ScriptMethodInfo scriptMethodInfo = ScriptMethodInfoHelper.Deserialize(_003CactionId_003E5__3);
					string text = SR.T("Ошибка выполнения метода {0} контроллера", scriptMethodInfo.Name);
					componentControllerTypeHandler.logger.Error($"Exception: {text} {Environment.get_NewLine()} {ex.get_InnerException() ?? ex}");
					componentControllerTypeHandler.notificationService.Error(SR.T("Ошибка"), text);
					throw;
				}
				finally
				{
					if (num < 0)
					{
						ViewModelHelper.RestoreData(_003CviewModel_003E5__2);
						GlobalScopeHelper.Pop(_003CviewModel_003E5__2.RenderOwner);
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

	private readonly ILogger logger;

	private readonly INotificationService notificationService;

	public ComponentControllerTypeHandler(ILogger logger, INotificationService notificationService)
	{
		this.logger = logger;
		this.notificationService = notificationService;
	}

	public override System.Threading.Tasks.Task HandleAsync(ActionCommand command)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CHandleAsync_003Ed__3 _003CHandleAsync_003Ed__ = default(_003CHandleAsync_003Ed__3);
		_003CHandleAsync_003Ed__._003C_003E4__this = this;
		_003CHandleAsync_003Ed__.command = command;
		_003CHandleAsync_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CHandleAsync_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = _003CHandleAsync_003Ed__._003C_003Et__builder;
		((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003CHandleAsync_003Ed__3>(ref _003CHandleAsync_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CHandleAsync_003Ed__._003C_003Et__builder)).get_Task();
	}
}
