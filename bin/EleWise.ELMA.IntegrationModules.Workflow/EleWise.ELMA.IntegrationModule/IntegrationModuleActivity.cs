using System;
using System.Activities;
using System.Collections.Generic;
using System.Security.Authentication;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.IntegrationModules.Constants;
using EleWise.ELMA.IntegrationModules.Managers;
using EleWise.ELMA.IntegrationModules.Metadata;
using EleWise.ELMA.IntegrationModules.Models;
using EleWise.ELMA.IntegrationModules.Services;
using EleWise.ELMA.IntegrationModules.Workflow.BPMN.Diagrams.Elements;
using EleWise.ELMA.IntegrationModules.Workflow.Models;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Mappings;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Context;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Scheduling.Models;
using EleWise.ELMA.Threading;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Activities.Tasks;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Connectors;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;
using EleWise.ELMA.Workflow.Diagrams.Activities;
using EleWise.ELMA.Workflow.Helpers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Scheduling;

namespace EleWise.ELMA.IntegrationModules.Workflow.BPMN.Diagrams.Activities;

internal class IntegrationModuleActivity : TaskActivity<IntegrationModuleElement>
{
	[Component]
	private class Info : IWorkflowActivityInfo
	{
		public Type ActivityType => typeof(IntegrationModuleActivity);

		public Type DiagramElementType => typeof(IntegrationModuleElement);
	}

	private static readonly ILogger IntegrationLogger = Logger.GetLogger("IntegrationModules");

	private const string SaveTaskName = "SaveTaskDescription";

	private const string SaveTaskDescription = "IWorkflowIntegrationBookmark";

	private IIntegrationModuleScriptingService integrationModuleScriptingService;

	private MetadataItemHeaderManager metadataItemHeaderManager;

	private WorkflowIntegrationBookmarkManager workflowIntegrationBookmarkManager;

	private IntegrationModuleManager integrationModuleManager;

	private IMetadataRuntimeService metadataRuntimeService;

	private IPropertyMapService propertyMapService;

	protected override bool CanInduceIdle => true;

	public IntegrationModuleActivity(MetadataItemHeaderManager metadataItemHeaderManager, IIntegrationModuleScriptingService integrationModuleScriptingService, WorkflowIntegrationBookmarkManager workflowIntegrationBookmarkManager, IntegrationModuleManager integrationModuleManager, IMetadataRuntimeService metadataRuntimeService, IPropertyMapService propertyMapService)
	{
		this.metadataItemHeaderManager = metadataItemHeaderManager;
		this.integrationModuleScriptingService = integrationModuleScriptingService;
		this.workflowIntegrationBookmarkManager = workflowIntegrationBookmarkManager;
		this.integrationModuleManager = integrationModuleManager;
		this.metadataRuntimeService = metadataRuntimeService;
		this.propertyMapService = propertyMapService;
	}

	protected override void ExecuteTask(NativeActivityContext context)
	{
		Contract.ArgumentNotNull(context, "context");
		Contract.ServiceNotNull(base.WorkflowRuntimeService, "WorkflowRuntimeService");
		if (!(base.Element.IntegrationModuleHeaderMetadataUid == Guid.Empty))
		{
			_ = base.Element.ActivityUid;
			IWorkflowInstance instance = GetInstance(context);
			IWorkflowIntegrationBookmark workflowIntegrationBookmark = workflowIntegrationBookmarkManager.GetIntegrationBookmark(base.Element, instance);
			IIntegrationModule integrationModule = null;
			if (workflowIntegrationBookmark != null && workflowIntegrationBookmark.Integration != null)
			{
				integrationModule = workflowIntegrationBookmark.Integration.CastAsRealType();
				IIntegrationModule integrationModule2 = ((!base.Element.IntegrationModuleUid.HasValue) ? (instance.Context.GetPropertyValue(base.Element.IntegrationPropertyUid) as IIntegrationModule) : integrationModuleManager.LoadOrNull(base.Element.IntegrationModuleUid.Value));
				if (integrationModule2 != null)
				{
					integrationModuleManager.CopyFromTemplate(integrationModule2, integrationModule);
				}
			}
			else
			{
				_ = base.Element.IntegrationPropertyUid;
				if (base.Element.IntegrationPropertyUid != Guid.Empty)
				{
					integrationModule = instance.Context.GetPropertyValue(base.Element.IntegrationPropertyUid) as IIntegrationModule;
				}
				else if (base.Element.IntegrationModuleUid.HasValue && base.Element.IntegrationModuleUid != Guid.Empty)
				{
					integrationModule = integrationModuleScriptingService.CreateInstanceParameters(base.Element.IntegrationModuleUid.Value, base.Element.IntegrationModuleHeaderMetadataUid);
				}
			}
			IMetadataItemHeader metadataItemHeader = metadataItemHeaderManager.LoadOrNull(base.Element.IntegrationModuleHeaderMetadataUid);
			if (metadataItemHeader == null || metadataItemHeader.Published == null)
			{
				ContinueOnDefaultConnector(context);
			}
			IntegrationModuleMetadata integrationModuleMetadata = metadataItemHeader.Published.Metadata as IntegrationModuleMetadata;
			IntegrationModuleActivityMetadata integrationModuleActivityMetadata = MetadataLoader.LoadMetadata(base.Element.ActivityUid) as IntegrationModuleActivityMetadata;
			if (integrationModule == null && integrationModuleMetadata != null && integrationModuleMetadata.AuthenticationTypeUid == IntegrationsConstants.DisabledIntegrationModuleAuthenticationUid)
			{
				integrationModule = Activator.CreateInstance(metadataRuntimeService.GetTypeByUid(integrationModuleMetadata.Uid)) as IIntegrationModule;
				integrationModule.Name = integrationModuleMetadata.DisplayName;
			}
			if (integrationModule == null || integrationModuleActivityMetadata == null || integrationModuleMetadata == null)
			{
				if (integrationModule == null)
				{
					IntegrationLogger.ErrorFormat(SR.T("Не удалось найти экземпляр интеграции по идентификатору '{0}' (Элемент '{1}' идентификатор процесса #{2})"), base.Element.IntegrationModuleUid, base.Element.Name, instance.Id);
				}
				if (integrationModuleActivityMetadata == null)
				{
					IntegrationLogger.ErrorFormat(SR.T("Не удалось найти экземпляр активити по идентификатору '{0} (Элемент '{1}' идентификатор процесса #{2})"), base.Element.ActivityUid, base.Element.Name, instance.Id);
				}
				if (integrationModuleMetadata == null)
				{
					IntegrationLogger.ErrorFormat(SR.T("Не удалось найти метаданные интеграции по идентификатору'{0} (Элемент '{1}' идентификатор процесса #{2})"), base.Element.IntegrationModuleHeaderMetadataUid, base.Element.Name, instance.Id);
				}
				ContinueOnDefaultConnector(context);
				return;
			}
			IIntegrationModuleActivity integrationModuleActivity2 = (integrationModule.Activity = ((workflowIntegrationBookmark != null && workflowIntegrationBookmark.Integration != null && workflowIntegrationBookmark.Integration.Activity != null) ? workflowIntegrationBookmark.Integration.Activity.CastAsRealType() : integrationModuleScriptingService.CreateActivityParameters(base.Element.ActivityUid, base.Element.IntegrationModuleHeaderMetadataUid)));
			((IIntegrationModuleWorkflow)integrationModule).WorkflowInstance = instance;
			if (base.Element.InputPropertyMap != null)
			{
				propertyMapService.Map(instance.Context, integrationModule.Activity, base.Element.InputPropertyMap.Reverse());
			}
			if (integrationModuleActivityMetadata.OnEnter)
			{
				if (!string.IsNullOrWhiteSpace(integrationModuleActivityMetadata.OnEnterScript))
				{
					ExecuteScript(integrationModule, integrationModuleMetadata, instance, workflowIntegrationBookmark, integrationModuleActivityMetadata.OnEnterScript, null, withAuth: true);
				}
				else
				{
					integrationModule.Error += SR.T("{0}{1} Не указано имя сценария активити", string.IsNullOrWhiteSpace(integrationModule.Error) ? "" : Environment.NewLine, DateTime.Now.ToString("g"));
					IntegrationLogger.ErrorFormat(SR.T("При попытке выполнения активити \"{0}\" интеграции \"{1}\" обнаружена ошибка: не указано имя сценария", integrationModuleActivityMetadata.DisplayName, integrationModuleMetadata.DisplayName));
				}
			}
			if (integrationModuleActivityMetadata.OnComplete)
			{
				((IIntegrationModuleWorkflow)integrationModule).Status = IntegrationModuleActivityStatus.Expectation;
				IWorkflowBookmark workflowBookmark = CreateBookmark(instance);
				if (workflowIntegrationBookmark == null)
				{
					workflowIntegrationBookmark = InterfaceActivator.Create<IWorkflowIntegrationBookmark>();
					workflowIntegrationBookmark.Integration = integrationModule;
				}
				CreateIntegrationBookmark(base.Element, instance, integrationModule, workflowIntegrationBookmark, workflowBookmark, inNewSession: false);
				CreateActivityBookmark(context, workflowBookmark.Uid.ToString(), OnTaskCompleted);
				CreateSheduleTask(workflowIntegrationBookmark, instance);
				return;
			}
			if (base.Element.OutputPropertyMap != null && integrationModule.Activity != null)
			{
				propertyMapService.Map(integrationModule.Activity, instance.Context, base.Element.OutputPropertyMap);
			}
			if (integrationModuleMetadata.Logging)
			{
				((IIntegrationModuleWorkflow)integrationModule).Status = IntegrationModuleActivityStatus.Complete;
				integrationModule.Save();
				integrationModule.Activity.Save();
			}
			else
			{
				integrationModule.Activity.Delete();
				integrationModule.Delete();
			}
			workflowIntegrationBookmark?.Delete();
			ContinueOnDefaultConnector(context);
		}
		else
		{
			ContinueOnDefaultConnector(context);
		}
	}

	private void CreateIntegrationBookmark(IntegrationModuleElement element, IWorkflowInstance instance, IIntegrationModule module, IWorkflowIntegrationBookmark bookmark, IWorkflowBookmark wfBookmark, bool inNewSession)
	{
		if (inNewSession)
		{
			using (ELMAContext.CreateIsolated())
			{
				using (CallContextSessionOwner.Create())
				{
					new BackgroundTask(delegate
					{
						workflowIntegrationBookmarkManager.SaveInSeparateSession(instance.Id, element.Uid, module, bookmark);
					}, typeof(IWorkflowIntegrationBookmark), "SaveTaskDescription", "IWorkflowIntegrationBookmark", useCallSessionOwner: false).Execute();
					return;
				}
			}
		}
		if (bookmark == null)
		{
			bookmark = InterfaceActivator.Create<IWorkflowIntegrationBookmark>();
			bookmark.Integration = module;
		}
		bookmark.WorkflowBookmark = wfBookmark;
		if (instance != null)
		{
			bookmark.WorkflowInstanceId = instance.Id;
		}
		bookmark.ElementUid = element.Uid;
		if (bookmark.Integration != null)
		{
			bookmark.Integration.Save();
			bookmark.Integration.Activity.Save();
		}
		bookmark.Save();
	}

	protected void OnTaskCompleted(NativeActivityContext context, Bookmark bookmark, object state)
	{
		Contract.ArgumentNotNull(state, "state");
		if (state is IntegrationExecuteData integrationExecuteData)
		{
			IWorkflowInstance instance = GetInstance(context);
			IIntegrationModule integrationModule = integrationExecuteData.IntegrationBookmark?.Integration;
			if (integrationModule == null || integrationModule.Activity == null)
			{
				ContinueOnConnector(context, integrationExecuteData.ConnectorUid);
				RemoveAllActivityBookmarks(context);
			}
			IMetadataItemHeader metadataItemHeader = metadataItemHeaderManager.LoadOrNull(base.Element.IntegrationModuleHeaderMetadataUid);
			if (metadataItemHeader == null || metadataItemHeader.Published == null)
			{
				ContinueOnDefaultConnector(context);
			}
			IntegrationModuleMetadata integrationModuleMetadata = metadataItemHeader.Published.Metadata as IntegrationModuleMetadata;
			if (MetadataLoader.LoadMetadata(base.Element.ActivityUid) is IntegrationModuleActivityMetadata integrationModuleActivityMetadata && integrationModuleActivityMetadata.OnComplete)
			{
				Dictionary<string, object> parameters = new Dictionary<string, object> { 
				{
					IntegrationsConstants.DataParamName,
					integrationExecuteData.WebData
				} };
				if (!string.IsNullOrWhiteSpace(integrationModuleActivityMetadata.OnCompleteScript))
				{
					ExecuteScript(integrationModule, integrationModuleMetadata, instance, integrationExecuteData.IntegrationBookmark, integrationModuleActivityMetadata.OnCompleteScript, parameters, withAuth: false);
				}
				else
				{
					integrationModule.Error += SR.T("{0}{1} Не указано имя сценария ожидания внешнего сообщения", string.IsNullOrWhiteSpace(integrationModule.Error) ? "" : Environment.NewLine, DateTime.Now.ToString("g"));
					IntegrationLogger.ErrorFormat(SR.T("При попытке выполнения активити \"{0}\" интеграции \"{1}\" обнаружена ошибка: не указано имя сценария ожидания внешнего сообщения", integrationModuleActivityMetadata.DisplayName, integrationModuleMetadata.DisplayName));
				}
			}
			if (base.Element.OutputPropertyMap != null && integrationModule.Activity != null)
			{
				propertyMapService.Map(integrationModule.Activity, instance.Context, base.Element.OutputPropertyMap);
			}
			integrationModule.Status = IntegrationModuleActivityStatus.Complete;
			integrationModule.Save();
			ContinueOnConnector(context, integrationExecuteData.ConnectorUid);
			RemoveAllActivityBookmarks(context);
			return;
		}
		throw new InvalidOperationException(SR.T("Неверное состояние объекта для продолжения активити интеграции ({0})", state.GetType().FullName));
	}

	private void CreateSheduleTask(IWorkflowIntegrationBookmark bookmark, IWorkflowInstance instance)
	{
		foreach (FlowConnectorElement exceptionOutputFlow in base.Element.ExceptionOutputFlows)
		{
			switch (exceptionOutputFlow.Trigger)
			{
			case EventTrigger.Timer:
			{
				DateTime? dateTime = ((exceptionOutputFlow.TimerSettings != null) ? exceptionOutputFlow.TimerSettings.GetNextTimerExpiration(instance) : null);
				if (dateTime.HasValue)
				{
					ISchedulerTask schedulerTask2 = InterfaceActivator.Create<ISchedulerTask>();
					schedulerTask2.Name = SR.T("Таймер на исполнение интеграции \"{0}\" в экземпляре \"{1}\" процесса \"{2}\"", base.Element.Name, instance.InstanceName(), instance.Process.Name);
					schedulerTask2.OnceExecuteTime = dateTime.Value;
					schedulerTask2.OwnerUid = WorkflowSchedulerTaskOwner.UID;
					IIntegrationModuleSchedulerTaskJob integrationModuleSchedulerTaskJob2 = InterfaceActivator.Create<IIntegrationModuleSchedulerTaskJob>();
					integrationModuleSchedulerTaskJob2.IntegrationModuleBookmark = bookmark;
					integrationModuleSchedulerTaskJob2.IntegrationConnectorUid = exceptionOutputFlow.Uid;
					integrationModuleSchedulerTaskJob2.Task = schedulerTask2;
					integrationModuleSchedulerTaskJob2.Name = schedulerTask2.Name;
					schedulerTask2.Jobs.Add((ISchedulerTaskJob)integrationModuleSchedulerTaskJob2);
					schedulerTask2.Save();
				}
				break;
			}
			case EventTrigger.Script:
			{
				DateTime? dateTime = ((exceptionOutputFlow.TimerScriptEscalation != null) ? exceptionOutputFlow.TimerScriptEscalation.GetNextTimerExpiration(instance) : null);
				if (dateTime.HasValue && dateTime.Value > DateTime.Now)
				{
					ISchedulerTask schedulerTask = InterfaceActivator.Create<ISchedulerTask>();
					schedulerTask.Name = SR.T("Таймер на исполнение интеграции \"{0}\" в экземпляре \"{1}\" процесса \"{2}\"", base.Element.Name, instance.InstanceName(), instance.Process.Name);
					schedulerTask.OnceExecuteTime = dateTime.Value;
					schedulerTask.OwnerUid = WorkflowSchedulerTaskOwner.UID;
					IIntegrationModuleSchedulerTaskJob integrationModuleSchedulerTaskJob = InterfaceActivator.Create<IIntegrationModuleSchedulerTaskJob>();
					integrationModuleSchedulerTaskJob.IntegrationModuleBookmark = bookmark;
					integrationModuleSchedulerTaskJob.IntegrationConnectorUid = exceptionOutputFlow.Uid;
					integrationModuleSchedulerTaskJob.Task = schedulerTask;
					integrationModuleSchedulerTaskJob.Name = schedulerTask.Name;
					schedulerTask.Jobs.Add((ISchedulerTaskJob)integrationModuleSchedulerTaskJob);
					schedulerTask.Save();
				}
				break;
			}
			}
		}
	}

	private void ExecuteScript(IIntegrationModule integration, IntegrationModuleMetadata integrationMetadata, IWorkflowInstance instance, IWorkflowIntegrationBookmark integrationBookmark, string scriptName, Dictionary<string, object> parameters, bool withAuth)
	{
		try
		{
			integrationModuleScriptingService.ExecuteScript(integration, integration.Activity, scriptName, parameters, withAuth);
		}
		catch (AuthenticationException ex)
		{
			if (integrationMetadata.Logging)
			{
				((IIntegrationModuleWorkflow)integration).Status = IntegrationModuleActivityStatus.Error;
				CreateIntegrationBookmark(base.Element, instance, integration, integrationBookmark, null, inNewSession: true);
			}
			throw ex;
		}
		catch (ScriptExecuteException ex2)
		{
			if (integrationMetadata.Logging)
			{
				((IIntegrationModuleWorkflow)integration).Status = IntegrationModuleActivityStatus.Error;
				CreateIntegrationBookmark(base.Element, instance, integration, integrationBookmark, null, inNewSession: true);
			}
			throw ex2;
		}
	}
}
