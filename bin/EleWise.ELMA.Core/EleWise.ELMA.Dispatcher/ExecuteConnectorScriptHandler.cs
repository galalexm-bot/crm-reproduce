using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Bridge;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Logging;
using EleWise.ELMA.Core.Services;
using EleWise.ELMA.DTO;
using EleWise.ELMA.Model.ViewModel;
using EleWise.ELMA.Scripts;
using EleWise.ELMA.Scripts.Models;

namespace EleWise.ELMA.Dispatcher;

[Component]
internal sealed class ExecuteConnectorScriptHandler : AbstractAsyncCommandHandler
{
	[StructLayout(3)]
	private struct _003CHandleAsyncLogic_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ActionCommand command;

		public ExecuteConnectorScriptHandler _003C_003E4__this;

		private IFormViewModel _003CviewModel_003E5__2;

		private object _003Cform_003E5__3;

		private bool _003CoutputCancel_003E5__4;

		private Action _003CuserFunc_003E5__5;

		private bool _003ChideBlocker_003E5__6;

		private bool _003CboolResult_003E5__7;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ExecuteConnectorScriptHandler executeConnectorScriptHandler = _003C_003E4__this;
			try
			{
				if (num == 0)
				{
					goto IL_00f0;
				}
				ModelMetadata modelMetadata = default(ModelMetadata);
				ReactiveProxy reactiveProxy = default(ReactiveProxy);
				if (!(command.ActionTypeId != "ExecuteConnectorScriptCommand"))
				{
					object[] args = command.Args;
					if (args.Length > 3)
					{
						_003CviewModel_003E5__2 = args[0] as IFormViewModel;
						if (_003CviewModel_003E5__2 != null)
						{
							_003Cform_003E5__3 = args[1];
							bool? flag = args[2] as bool?;
							if (_003Cform_003E5__3 != null && flag.get_HasValue())
							{
								modelMetadata = _003CviewModel_003E5__2.ModelMetadata;
								reactiveProxy = ObjectExtensions.As<ReactiveProxy>(modelMetadata.Model);
								if (reactiveProxy != null)
								{
									_003CoutputCancel_003E5__4 = flag.get_Value();
									ref Action reference = ref _003CuserFunc_003E5__5;
									object obj = args[3];
									reference = (Action)((obj is Action) ? obj : null);
									_003ChideBlocker_003E5__6 = true;
									executeConnectorScriptHandler.loaderService.Show("ExecuteConnectorScriptLoaderKey", SR.T("Обработка изменений"));
									goto IL_00f0;
								}
							}
						}
					}
				}
				goto end_IL_000e;
				IL_00f0:
				try
				{
					TaskAwaiter<object> val;
					if (num != 0)
					{
						val = executeConnectorScriptHandler.scriptService.ExecuteScriptWithResult(new ScriptExecutionParams(reactiveProxy, modelMetadata.ModelInfo, _003CviewModel_003E5__2, command.ActionId, null, true)).GetAwaiter();
						if (!val.get_IsCompleted())
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = val;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter<object>, _003CHandleAsyncLogic_003Ed__7>(ref val, ref this);
							return;
						}
					}
					else
					{
						val = (TaskAwaiter<object>)_003C_003Eu__1;
						_003C_003Eu__1 = null;
						num = (_003C_003E1__state = -1);
					}
					object result = val.GetResult();
					object obj2;
					if ((obj2 = result) is bool)
					{
						_003CboolResult_003E5__7 = (bool)obj2;
						_003ChideBlocker_003E5__6 = !_003CboolResult_003E5__7;
					}
					else if (result is string text && bool.TryParse(text, ref _003CboolResult_003E5__7))
					{
						_003ChideBlocker_003E5__6 = !_003CboolResult_003E5__7;
					}
					if (!_003ChideBlocker_003E5__6)
					{
						if (_003CuserFunc_003E5__5 != null)
						{
							_003CuserFunc_003E5__5.Invoke();
						}
						else
						{
							CheckAndSubmit(_003Cform_003E5__3, _003CoutputCancel_003E5__4);
						}
					}
					else if (_003CoutputCancel_003E5__4)
					{
						ClearValidationErrorMessages(_003Cform_003E5__3);
					}
				}
				catch (System.Exception ex)
				{
					executeConnectorScriptHandler.logger.Error(SR.T("Ошибка при выполнении серверного метода: {0}. Exception: {1}", command.ActionId, ex.get_Message()));
					executeConnectorScriptHandler.notificationService.Error(SR.T("Ошибка"), SR.T("Ошибка при выполнении серверного метода '{0}' в компоненте '{1}'", command.ActionId, _003CviewModel_003E5__2.Component.Name));
				}
				finally
				{
					if (num < 0)
					{
						executeConnectorScriptHandler.loaderService.Hide("ExecuteConnectorScriptLoaderKey");
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

	private readonly IScriptService scriptService;

	private readonly INotificationService notificationService;

	private readonly ILoaderService loaderService;

	private const string LoaderKey = "ExecuteConnectorScriptLoaderKey";

	public ExecuteConnectorScriptHandler(ILogger logger, IScriptService scriptService, INotificationService notificationService, ILoaderService loaderService)
	{
		this.logger = logger;
		this.scriptService = scriptService;
		this.notificationService = notificationService;
		this.loaderService = loaderService;
	}

	public override System.Threading.Tasks.Task HandleAsync(ActionCommand command)
	{
		return HandleAsyncLogic(command);
	}

	private System.Threading.Tasks.Task HandleAsyncLogic(ActionCommand command)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CHandleAsyncLogic_003Ed__7 _003CHandleAsyncLogic_003Ed__ = default(_003CHandleAsyncLogic_003Ed__7);
		_003CHandleAsyncLogic_003Ed__._003C_003E4__this = this;
		_003CHandleAsyncLogic_003Ed__.command = command;
		_003CHandleAsyncLogic_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CHandleAsyncLogic_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = _003CHandleAsyncLogic_003Ed__._003C_003Et__builder;
		((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003CHandleAsyncLogic_003Ed__7>(ref _003CHandleAsyncLogic_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CHandleAsyncLogic_003Ed__._003C_003Et__builder)).get_Task();
	}

	[Template("checkAndSubmit({form}, {outputCancel})")]
	[Obsolete("Не использовать")]
	private static extern void CheckAndSubmit(object form, bool outputCancel);

	[Template("elma.ValidationRulesManager.clearValidationErrorMessages({form})")]
	[Obsolete("Не использовать")]
	private static extern void ClearValidationErrorMessages(object form);
}
