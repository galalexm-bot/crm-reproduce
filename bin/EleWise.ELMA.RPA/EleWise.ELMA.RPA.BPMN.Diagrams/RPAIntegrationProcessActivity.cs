using System;
using System.Activities;
using System.Globalization;
using System.Linq;
using System.Text;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.RPA.BPMN.Diagrams.Elements.RPAIntegration;
using EleWise.ELMA.RPA.DTO.Managers;
using EleWise.ELMA.RPA.DTO.Models;
using EleWise.ELMA.RPA.Models;
using EleWise.ELMA.RPA.Models.Mappings;
using EleWise.ELMA.RPA.Scheduler;
using EleWise.ELMA.RPA.Services;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Scheduling.Managers;
using EleWise.ELMA.Scheduling.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Activities;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Connectors;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;
using EleWise.ELMA.Workflow.Diagrams.Activities;
using EleWise.ELMA.Workflow.Helpers;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.RPA.BPMN.Diagrams.Activities.RPAIntegrationProcess;

internal sealed class RPAIntegrationProcessActivity : BPMNActivity<RPAIntegrationElement>
{
	[Component]
	private class Info : IWorkflowActivityInfo
	{
		public Type ActivityType => typeof(RPAIntegrationProcessActivity);

		public Type DiagramElementType => typeof(RPAIntegrationElement);
	}

	private RPAClientSettingsModule settingsModule;

	private readonly IRPAProcessDTOManager rpaProcessManager;

	private readonly SchedulerTaskManager schedulerTaskManager;

	private readonly IRPAPropertyMapService rpaPropertyMapService;

	private RPAClientSettingsModule SettingsModule
	{
		get
		{
			if (settingsModule == null)
			{
				settingsModule = Locator.GetServiceNotNull<RPAClientSettingsModule>();
			}
			return settingsModule;
		}
	}

	protected override bool CanInduceIdle => true;

	public RPAIntegrationProcessActivity(IRPAProcessDTOManager rpaProcessManager, SchedulerTaskManager schedulerTaskManager, IRPAPropertyMapService rpaPropertyMapService)
	{
		this.rpaProcessManager = rpaProcessManager;
		this.schedulerTaskManager = schedulerTaskManager;
		this.rpaPropertyMapService = rpaPropertyMapService;
	}

	protected override void Execute(NativeActivityContext context)
	{
		IWorkflowInstance instance = GetInstance(context);
		try
		{
			ExecuteRPAProcess(context, instance);
		}
		catch (Exception ex)
		{
			FlowConnectorElement flowConnectorElement = base.Element.ExceptionOutputFlows.FirstOrDefault((FlowConnectorElement ef) => ef.Trigger == EventTrigger.ErrorCatch);
			Logger.Log.Error(ex.Message, ex);
			if (flowConnectorElement != null)
			{
				instance.Context.SetPropertyValue(flowConnectorElement.ContextExceptionVar, new ExceptionData(0, ex.Message, ex));
				instance.Save();
				ContinueOnConnector(context, flowConnectorElement.Uid);
			}
			else
			{
				instance.Save();
				ContinueOnDefaultConnector(context);
			}
		}
	}

	private void ExecuteRPAProcess(NativeActivityContext context, IWorkflowInstance instance)
	{
		RPAProcessDTO rPAProcess = base.Element.RPAProcess;
		if (rPAProcess == null)
		{
			throw new Exception(SR.T("Процесс не установлен"));
		}
		TaskDTO task = OnSubInstanceRunning(context, instance, rPAProcess);
		TaskDTO taskDTO = rpaProcessManager.CreateTask(task);
		if (taskDTO == null)
		{
			throw new Exception(SR.T("Ошибка запуска процесса \"{0}\"", rPAProcess.Name));
		}
		IWorkflowBookmark workflowBookmark = CreateBookmark(instance);
		context.CreateBookmark(workflowBookmark.Uid.ToString(), CheckTaskStatusCompleted);
		CreateSchedulerTask(instance, workflowBookmark, taskDTO.Id);
	}

	private void CreateSchedulerTask(IWorkflowInstance instance, IWorkflowBookmark bookmark, long rpaTaskId)
	{
		NthIncludedDaySettings settings = new NthIncludedDaySettings
		{
			ScheduleType = ScheduleType.Once,
			RepeatSettings = new RepeatSettings
			{
				Enabled = true,
				RepeatEvery = TimeSpan.FromMinutes(SettingsModule.Settings.PollingTimer)
			}
		};
		ISchedulerTask schedulerTask = InterfaceActivator.Create<ISchedulerTask>();
		schedulerTask.Type = SchedulerTaskType.Periodic;
		schedulerTask.Name = SR.T("Проверка статуса исполнения RPA-процесса \"{0}\" в экземпляре \"{1}\" процесса \"{2}\"", base.Element.Name, instance.InstanceName(), SR.T(instance.Process.Name));
		schedulerTask.OwnerUid = RPAIntegrationSchedulerTaskOwner.UID;
		schedulerTask.Settings = settings;
		IExecutingRPAProcessSchedulerJob executingRPAProcessSchedulerJob = InterfaceActivator.Create<IExecutingRPAProcessSchedulerJob>();
		executingRPAProcessSchedulerJob.Task = schedulerTask;
		executingRPAProcessSchedulerJob.Name = schedulerTask.Name;
		executingRPAProcessSchedulerJob.WorkflowBookmark = bookmark;
		executingRPAProcessSchedulerJob.SchedulerTaskUid = schedulerTask.Uid;
		executingRPAProcessSchedulerJob.RPATaskId = rpaTaskId;
		schedulerTask.Jobs.Add((ISchedulerTaskJob)executingRPAProcessSchedulerJob);
		schedulerTask.Status = SchedulerTaskStatus.Enabled;
		schedulerTask.Save();
	}

	private void CheckTaskStatusCompleted(NativeActivityContext context, Bookmark bookmark, object state)
	{
		if (!(state is ExecutingRPAProcessData executingRPAProcessData))
		{
			return;
		}
		ISchedulerTask schedulerTask = schedulerTaskManager.LoadOrNull(executingRPAProcessData.SchedulerTaskUid);
		if (schedulerTask != null)
		{
			schedulerTask.Status = SchedulerTaskStatus.Closed;
			schedulerTask.Save();
		}
		IWorkflowInstance instance = GetInstance(context);
		if (executingRPAProcessData.Task.Status != TaskStatus.DONE)
		{
			FlowConnectorElement flowConnectorElement = base.Element.ExceptionOutputFlows.FirstOrDefault((FlowConnectorElement e) => e.Trigger == EventTrigger.ErrorCatch);
			if (flowConnectorElement != null)
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.AppendLine(SR.T("Ошибка выполнения процесса RPA")).AppendLine(SR.T("Лог исполнения процесса RPA:")).Append(executingRPAProcessData.Task.Log);
				Exception ex = new Exception(stringBuilder.ToString());
				instance.Context.SetPropertyValue(flowConnectorElement.ContextExceptionVar, new ExceptionData(0, ex.Message, ex));
				instance.Save();
				ContinueOnConnector(context, flowConnectorElement.Uid);
				return;
			}
			ContinueOnDefaultConnector(context);
		}
		OnSubInstanceCompleted(context, instance, executingRPAProcessData.Task.OutputContext);
	}

	private TaskDTO OnSubInstanceRunning(NativeActivityContext context, IWorkflowInstance instance, RPAProcessDTO rpaProcess)
	{
		string context2 = "";
		if (base.Element.InputContextMap != null)
		{
			WorkflowInstanceContext context3 = instance.Context;
			ClassMetadata rPAProcessClassMetadata = base.Element.RPAProcessClassMetadata;
			if (context3 != null && rPAProcessClassMetadata != null)
			{
				context2 = rpaPropertyMapService.MapToRPA(context3, rPAProcessClassMetadata, base.Element.InputContextMap.Reverse());
			}
		}
		return new TaskDTO
		{
			Process = rpaProcess.ProcessToken,
			Version = 0,
			Context = context2
		};
	}

	private void OnSubInstanceCompleted(NativeActivityContext context, IWorkflowInstance instance, string rpaOutContext)
	{
		if (base.Element.OutputContextMap == null)
		{
			return;
		}
		WorkflowInstanceContext parentContext = instance.Context;
		ClassMetadata rpaContext = base.Element.RPAProcessClassMetadata;
		if (parentContext == null || rpaContext == null)
		{
			return;
		}
		try
		{
			SR.RunWithCulture(CultureInfo.InvariantCulture, delegate
			{
				rpaPropertyMapService.MapFromRPA(rpaContext, parentContext, base.Element.OutputContextMap, rpaOutContext);
			});
		}
		catch (Exception ex)
		{
			FlowConnectorElement flowConnectorElement = base.Element.ExceptionOutputFlows.FirstOrDefault((FlowConnectorElement e) => e.Trigger == EventTrigger.ErrorCatch);
			if (flowConnectorElement != null)
			{
				instance.Context.SetPropertyValue(flowConnectorElement.ContextExceptionVar, new ExceptionData(0, ex.Message, ex));
				instance.Save();
				ContinueOnConnector(context, flowConnectorElement.Uid);
			}
			return;
		}
		ContinueOnDefaultConnector(context);
	}
}
