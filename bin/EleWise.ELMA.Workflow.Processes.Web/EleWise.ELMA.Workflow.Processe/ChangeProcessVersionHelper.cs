using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Types.Settings;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.BPMN;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Swimlanes;
using EleWise.ELMA.Workflow.BPMN.Models;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Models.ChangeProcessVersion;
using EleWise.ELMA.Workflow.Processes.Web.Models;
using Telerik.Web.Mvc.UI;

namespace EleWise.ELMA.Workflow.Processes.Web.Helpers;

public static class ChangeProcessVersionHelper
{
	private static Dictionary<WorkerDetectionType, string> workerDetectionDescription = new Dictionary<WorkerDetectionType, string>
	{
		{
			WorkerDetectionType.UseSelector,
			SR.T("Предварительный выбор")
		},
		{
			WorkerDetectionType.WhoFirst,
			SR.T("Кто первый")
		}
	};

	private static Dictionary<OrganizationItemType, string> positionKindDescription = new Dictionary<OrganizationItemType, string>
	{
		{
			OrganizationItemType.Department,
			SR.T("Отдел")
		},
		{
			OrganizationItemType.Position,
			SR.T("Должность")
		},
		{
			OrganizationItemType.EmployeeGroup,
			SR.T("Группа сотрудников")
		},
		{
			OrganizationItemType.NestedStructure,
			SR.T("Вложенная структура")
		}
	};

	private static Dictionary<ChangeActionTypes, string> ActionText = new Dictionary<ChangeActionTypes, string>
	{
		{
			ChangeActionTypes.KeepCurrentExecutor,
			SR.T("Оставить текущего исполнителя")
		},
		{
			ChangeActionTypes.SetNewExecutor,
			SR.T("Указать исполнителя вручную")
		},
		{
			ChangeActionTypes.GetExecutorFromSwimlane,
			SR.T("Назначить из зоны ответственности")
		},
		{
			ChangeActionTypes.KeepAssignedTasks,
			SR.T("Оставить назначенные задачи как есть")
		}
	};

	private static IChangeProcessVersionAction CreateChangeAction(IWorkflowInstance instance, ExecutorActionRow rowInfo)
	{
		Contract.ArgumentNotNull(instance, "instance");
		if (rowInfo == null)
		{
			return new ChangeProcessVersionNoAction();
		}
		IChangeProcessVersionAction changeProcessVersionAction = null;
		return rowInfo.ActionId switch
		{
			ChangeActionTypes.GetExecutorFromSwimlane => new ChangeProcessVersionRemoveSwimlaneBindingAction(instance, rowInfo.SwimlaneUid), 
			ChangeActionTypes.SetNewExecutor => new ChangeProcessVersionUpdateSwimlaneBindingAction(instance, rowInfo.SwimlaneUid, rowInfo.Executor), 
			_ => new ChangeProcessVersionNoAction(), 
		};
	}

	private static IUser GetCurrentSwimlaneExecutor(IWorkflowInstance instance, SwimlaneElement swimlane)
	{
		Contract.ArgumentNotNull(instance, "instance");
		if (swimlane == null)
		{
			return null;
		}
		IUser user = null;
		if (swimlane.ExecuterProperty != Guid.Empty)
		{
			user = instance.Context.GetPropertyValue<IUser>(swimlane.ExecuterProperty);
		}
		return user ?? (from wse in ((IEnumerable<IWorkflowSwimlaneExecutor>)instance.SwimlaneExecutors).Where(delegate(IWorkflowSwimlaneExecutor wse)
			{
				Guid? swimlaneUid = wse.SwimlaneUid;
				Guid uid = swimlane.Uid;
				if (!swimlaneUid.HasValue)
				{
					return false;
				}
				return !swimlaneUid.HasValue || swimlaneUid.GetValueOrDefault() == uid;
			})
			select wse.User).FirstOrDefault();
	}

	private static SwimlaneViewModel GetSwimlaneViewModel(SwimlaneElement swimlane, IWorkflowProcess process)
	{
		if (swimlane == null)
		{
			return null;
		}
		SwimlaneViewModel swimlaneViewModel = new SwimlaneViewModel();
		PropertyMetadata propertyMetadata = ((EntityMetadata)MetadataLoader.LoadMetadata(Locator.GetServiceNotNull<WorkflowInstanceContextService>().GetInstanceContextType(process))).Properties.FirstOrDefault((PropertyMetadata m) => m.Uid == swimlane.ExecuterProperty);
		EntityUserSettings entityUserSettings = ((propertyMetadata != null) ? (propertyMetadata.Settings as EntityUserSettings) : null);
		swimlaneViewModel.Name = $"\"{swimlane.Name}\"";
		switch (swimlane.SwimlaneType)
		{
		case SwimlaneType.Static:
		{
			IOrganizationItem organizationItem = OrganizationItemManager.Instance.LoadOrNull(swimlane.DepartmentId);
			string positionKindName = (positionKindDescription.Keys.Contains(organizationItem.ItemType) ? positionKindDescription[organizationItem.ItemType] : SR.T("Неизвестная организационная единица"));
			swimlaneViewModel.Type = SR.T("Статическая");
			swimlaneViewModel.Static = new SwimlaneViewModel.StaticParameters
			{
				PositionKindName = positionKindName,
				OrgItem = organizationItem
			};
			break;
		}
		case SwimlaneType.Dynamic:
		{
			string workerDetectionName = (workerDetectionDescription.Keys.Contains(swimlane.WorkerDetectionType) ? workerDetectionDescription[swimlane.WorkerDetectionType] : SR.T("Неизвестный механизм"));
			swimlaneViewModel.Type = SR.T("Динамическая (выбор из списка)");
			swimlaneViewModel.Dynamic = new SwimlaneViewModel.DynamicParameters
			{
				PropertyName = ((propertyMetadata != null) ? propertyMetadata.Name : SR.T("<новая контекстная переменная>")),
				WorkerDetectionName = workerDetectionName
			};
			List<Worker> source = ((entityUserSettings != null) ? entityUserSettings.Workers : new List<Worker>());
			swimlaneViewModel.Dynamic.WorkerModels = new List<WorkerViewModel>();
			swimlaneViewModel.Dynamic.WorkerModels.AddSequense(source.Select((Worker w) => new WorkerViewModel(w, process)));
			break;
		}
		case SwimlaneType.DynamicScript:
			swimlaneViewModel.Type = SR.T("Динамическая (определяется сценарием)");
			swimlaneViewModel.DynamicScript = new SwimlaneViewModel.DynamicScriptParameters
			{
				PropertyName = propertyMetadata.Name,
				ScriptName = swimlane.ScriptName.Split('-')[1].Trim()
			};
			break;
		case SwimlaneType.BusinessRole:
		{
			IBusinessRoleType businessRoleType = ComponentManager.Current.GetExtensionPoints<IBusinessRoleType>().First((IBusinessRoleType br) => br.Uid == (Guid)swimlane.ExtendedSettings[SwimlaneElement.BusinessRoleType]);
			swimlaneViewModel.Type = SR.T("Бизнес-роль");
			swimlaneViewModel.BusinessRole = new SwimlaneViewModel.BusinessRoleParameters
			{
				TypeName = businessRoleType.DisplayName
			};
			break;
		}
		default:
			swimlaneViewModel.Type = SR.T("Неизвестный тип");
			break;
		}
		return swimlaneViewModel;
	}

	private static DropDownItem NewActionItem(ChangeActionTypes type)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		int num = (int)type;
		string text = (ActionText.Keys.Contains(type) ? ActionText[type] : SR.T("Неизвестное действие"));
		DropDownItem val = new DropDownItem();
		val.set_DropDownText(text);
		val.set_Text(text);
		val.set_Value(num.ToString());
		return val;
	}

	private static ExecutorActionRow CreateExecutorActionRow(SwimlaneChangeInfo changeInfo, IWorkflowInstance instance)
	{
		Contract.ArgumentNotNull(instance, "instance");
		Contract.ArgumentNotNull(changeInfo, "changeInfo");
		ExecutorActionRow executorActionRow = new ExecutorActionRow();
		executorActionRow.SwimlaneUid = changeInfo.NewSwimlane.Uid;
		executorActionRow.CurrentExecutor = GetCurrentSwimlaneExecutor(instance, changeInfo.OldSwimlane);
		if (changeInfo.ActiveElementUids.Length == 0)
		{
			if (executorActionRow.CurrentExecutor != null)
			{
				executorActionRow.ActionItems.Add(NewActionItem(ChangeActionTypes.KeepCurrentExecutor));
				if (changeInfo.NewSwimlane.SwimlaneType != SwimlaneType.BusinessRole)
				{
					executorActionRow.ActionItems.Add(NewActionItem(ChangeActionTypes.SetNewExecutor));
				}
			}
			executorActionRow.ActionItems.Add(NewActionItem(ChangeActionTypes.GetExecutorFromSwimlane));
		}
		else if (executorActionRow.CurrentExecutor != null)
		{
			executorActionRow.ActionItems.Add(NewActionItem(ChangeActionTypes.KeepCurrentExecutor));
		}
		else
		{
			executorActionRow.ActionItems.Add(NewActionItem(ChangeActionTypes.KeepAssignedTasks));
		}
		executorActionRow.ActionItems.First().set_Selected(true);
		return executorActionRow;
	}

	public static ChangeProcessVersionActionData GetActionData(ChangeProcessVersionResponseModel response, IWorkflowInstance instance, IWorkflowProcess newVersionProcess, IUser currentUser)
	{
		Contract.ArgumentNotNull(instance, "instance");
		Contract.ArgumentNotNull(response, "response");
		ChangeProcessVersionActionData changeProcessVersionActionData = new ChangeProcessVersionActionData();
		changeProcessVersionActionData.Reason = response.CommentText;
		changeProcessVersionActionData.Instance = instance;
		changeProcessVersionActionData.NewProcess = newVersionProcess;
		changeProcessVersionActionData.User = currentUser;
		IWorkflowProcess newProcess = newVersionProcess ?? instance.Process.Header.Published;
		changeProcessVersionActionData.Actions.Add(new ChangeTypeSettingsInstanceStore(instance, newProcess));
		changeProcessVersionActionData.Actions.Add(new ChangeProcessVersionUpdateInstanceStateAction(instance, newProcess));
		foreach (ExecutorActionRow executorAction in response.ExecutorActions)
		{
			changeProcessVersionActionData.Actions.Add(CreateChangeAction(instance, executorAction));
		}
		return changeProcessVersionActionData;
	}

	public static ChangeProcessVersionActionData GetActionDataWithSubProcesses(ChangeProcessVersionResponseModel response, IWorkflowInstance instance, IWorkflowProcess newVersionProcess, IUser currentUser, Dictionary<IWorkflowInstance, IWorkflowProcess> updateInfo)
	{
		ChangeProcessVersionActionData actionData = GetActionData(response, instance, newVersionProcess, currentUser);
		updateInfo.Remove(instance);
		foreach (KeyValuePair<IWorkflowInstance, IWorkflowProcess> item in updateInfo)
		{
			actionData.Actions.Add(new ChangeTypeSettingsInstanceStore(item.Key, item.Value));
			actionData.Actions.Add(new ChangeProcessVersionUpdateInstanceStateAction(item.Key, item.Value));
		}
		return actionData;
	}

	public static ChangeProcessVersionActionData GetActionDataForCanCheck(IWorkflowInstance instance, IWorkflowProcess newVersionProcess)
	{
		Contract.ArgumentNotNull(instance, "instance");
		return new ChangeProcessVersionActionData
		{
			Instance = instance,
			NewProcess = newVersionProcess
		};
	}

	public static ChangeProcessVersionViewModel BuildChangeVersionProcessViewModel(WorkflowInstanceViewModel workflowModel, IWorkflowInstance instance, IWorkflowProcess oldProcess, IWorkflowProcess newProcess)
	{
		ChangeProcessVersionViewModel changeProcessVersionViewModel = new ChangeProcessVersionViewModel();
		ChangeProcessVersionValidationResult changeProcessVersionValidationResult = Locator.GetServiceNotNull<WorkflowInstanceManager>().ValidateChangeProcessVersion(instance, newProcess);
		IEnumerable<ChangedPropertyViewModel> source = changeProcessVersionValidationResult.AddedProperties.Select((PropertyMetadata p) => new ChangedPropertyViewModel
		{
			DisplayName = p.DisplayName,
			Name = p.Name,
			TypeName = ProcessDocumentationHelper.GetPropertyType(p)
		});
		IEnumerable<ChangedPropertyViewModel> source2 = changeProcessVersionValidationResult.RemovedProperties.Select((PropertyMetadata p) => new ChangedPropertyViewModel
		{
			DisplayName = p.DisplayName,
			Name = p.Name,
			TypeName = ProcessDocumentationHelper.GetPropertyType(p)
		});
		ChangeProcessVersionSummaryViewModel summaryTable = new ChangeProcessVersionSummaryViewModel
		{
			CurrentProcess = oldProcess,
			NewProcess = newProcess,
			AddedProperties = source.ToArray(),
			RemovedProperties = source2.ToArray()
		};
		changeProcessVersionViewModel.ChangeRemarks = changeProcessVersionValidationResult.Messages;
		changeProcessVersionViewModel.SummaryTable = summaryTable;
		changeProcessVersionViewModel.WorkflowModel = workflowModel;
		changeProcessVersionViewModel.SwimlaneChanges.AddSequense(changeProcessVersionValidationResult.ChangedSwimlanes.Select((SwimlaneChangeInfo ch) => new SwimlaneChangesViewModel
		{
			SwimlaneUid = ch.NewSwimlane.Uid,
			SwimlaneStatus = ((ch.OldSwimlane == null) ? SR.T("Новая") : SR.T("Есть изменения")),
			HasActiveElementInside = (ch.ActiveElementUids.Length != 0),
			OldSwimlane = GetSwimlaneViewModel(ch.OldSwimlane, oldProcess),
			NewSwimlane = GetSwimlaneViewModel(ch.NewSwimlane, newProcess)
		}));
		changeProcessVersionViewModel.ResponseModel.ExecutorActions.AddSequense(changeProcessVersionValidationResult.ChangedSwimlanes.Select((SwimlaneChangeInfo ch) => CreateExecutorActionRow(ch, instance)));
		return changeProcessVersionViewModel;
	}
}
