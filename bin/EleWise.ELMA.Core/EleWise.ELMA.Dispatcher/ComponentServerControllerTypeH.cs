using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Logging;
using EleWise.ELMA.Core.Services;
using EleWise.ELMA.DTO;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.ViewModel;
using EleWise.ELMA.Scripts;
using EleWise.ELMA.Scripts.Models;

namespace EleWise.ELMA.Dispatcher;

[Component]
internal sealed class ComponentServerControllerTypeHandler : AbstractAsyncCommandHandler
{
	[StructLayout(3)]
	private struct _003CHandleAsync_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ActionCommand command;

		public ComponentServerControllerTypeHandler _003C_003E4__this;

		private IMetadataViewModel _003Cowner_003E5__2;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_018a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0191: Expected O, but got Unknown
			int num = _003C_003E1__state;
			ComponentServerControllerTypeHandler componentServerControllerTypeHandler = _003C_003E4__this;
			try
			{
				if (num == 0)
				{
					goto IL_011d;
				}
				AdditionalModel[] array = default(AdditionalModel[]);
				ReactiveProxy item = default(ReactiveProxy);
				ModelMetadata modelMetadata = default(ModelMetadata);
				ReactiveProxy reactiveProxy = default(ReactiveProxy);
				if (!(command.ActionTypeId != "ComponentServerControllerTypeCommand"))
				{
					object[] args = command.Args;
					if (args.Length != 0 && args[0] is IViewModel viewModel && (_003Cowner_003E5__2 = viewModel.RenderOwner as IMetadataViewModel) != null)
					{
						array = new AdditionalModel[0];
						if (_003Cowner_003E5__2 is IComponentViewItemViewModel componentViewItemViewModel)
						{
							AdditionalModel[] additionalModels = componentViewItemViewModel.AdditionalModels;
							foreach (AdditionalModel additionalModel in additionalModels)
							{
								ArrayExtensions.Push<AdditionalModel>(array, new AdditionalModel[1] { additionalModel });
							}
						}
						item = null;
						modelMetadata = _003Cowner_003E5__2.ModelMetadata;
						if (modelMetadata.Metadata is TablePartMetadata)
						{
							reactiveProxy = ObjectExtensions.As<ReactiveProxy>(modelMetadata.Root().Model);
							item = ObjectExtensions.As<ReactiveProxy>(modelMetadata.GetModelFunc.Invoke());
						}
						else
						{
							reactiveProxy = ObjectExtensions.As<ReactiveProxy>(modelMetadata.Model);
						}
						if (reactiveProxy != null)
						{
							goto IL_011d;
						}
					}
				}
				goto end_IL_000e;
				IL_011d:
				try
				{
					TaskAwaiter val;
					if (num != 0)
					{
						val = componentServerControllerTypeHandler.scriptService.ExecuteScript(new ScriptExecutionParams(reactiveProxy, modelMetadata.ModelInfo, _003Cowner_003E5__2, command.ActionId, item, updateModel: true, array)).GetAwaiter();
						if (!val.get_IsCompleted())
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = val;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter, _003CHandleAsync_003Ed__4>(ref val, ref this);
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
				catch (System.Exception ex)
				{
					ScriptMethodInfo scriptMethodInfo = ScriptMethodInfoHelper.Deserialize(command.ActionId);
					componentServerControllerTypeHandler.logger.Error(SR.T("Ошибка при выполнении серверного метода: {0}. Exception: {1}", scriptMethodInfo.Name, ex.get_Message()));
					componentServerControllerTypeHandler.notificationService.Error(SR.T("Ошибка"), SR.T("Ошибка при выполнении серверного метода '{0}' в компоненте '{1}'", scriptMethodInfo.Name, _003Cowner_003E5__2.Component.Name));
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

	public ComponentServerControllerTypeHandler(ILogger logger, IScriptService scriptService, INotificationService notificationService)
	{
		this.logger = logger;
		this.scriptService = scriptService;
		this.notificationService = notificationService;
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
