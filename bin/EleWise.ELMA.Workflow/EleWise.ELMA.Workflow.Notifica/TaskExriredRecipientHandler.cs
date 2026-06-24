using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Notifications;
using EleWise.ELMA.Security.DTO.Models;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;
using EleWise.ELMA.Workflow.BPMN.Models;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Security;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Notifications;

[Component]
public class TaskExriredRecipientHandler : INotificationRecipientTypeHandler
{
	internal static TaskExriredRecipientHandler LV8Zn05RcnVnAw7I7xH;

	public string Name => SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4940763B ^ 0x49403F67);

	public IEnumerable<object> GetRecipients(object value)
	{
		_003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass2_0();
		List<IUser> list = new List<IUser>();
		if (value == null)
		{
			return list;
		}
		CS_0024_003C_003E8__locals0.workflowTask = value as IWorkflowTaskBase;
		if (CS_0024_003C_003E8__locals0.workflowTask == null)
		{
			return list;
		}
		if (!(CS_0024_003C_003E8__locals0.workflowTask.WorkflowBookmark.Instance.Process.Diagram.Elements.FirstOrDefault(delegate(Element e)
		{
			int num3 = 3;
			int num4 = num3;
			Guid? elementUid = default(Guid?);
			Guid guid = default(Guid);
			while (true)
			{
				switch (num4)
				{
				default:
					if (elementUid.HasValue)
					{
						return _003C_003Ec__DisplayClass2_0.yFrA1gZRZFeohPd8MYSr(guid, elementUid.GetValueOrDefault());
					}
					num4 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 == 0)
					{
						num4 = 1;
					}
					break;
				case 1:
					return false;
				case 2:
					elementUid = ((IWorkflowBookmark)_003C_003Ec__DisplayClass2_0.VtCDDvZROWgJZolV3adi(CS_0024_003C_003E8__locals0.workflowTask)).ElementUid;
					num4 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 == 0)
					{
						num4 = 0;
					}
					break;
				case 3:
					guid = _003C_003Ec__DisplayClass2_0.wDpDkGZRKNh215A6uwZF(e);
					num4 = 2;
					break;
				}
			}
		}) is UserTaskElement userTaskElement) || !userTaskElement.LimitByTime)
		{
			return list;
		}
		foreach (Recipient recipient in userTaskElement.TimeOfExecution.Recipients)
		{
			if (recipient.TypeUid == BaseWorkflowConstants.RecipientExecutorChiefUid)
			{
				IUser executor = CS_0024_003C_003E8__locals0.workflowTask.Executor;
				if (executor == null)
				{
					continue;
				}
				HierarchyChiefDisplayModel userChiefsHierarchy = UserManager.Instance.GetUserChiefsHierarchy(executor);
				if (userChiefsHierarchy == null || userChiefsHierarchy.Items == null || !userChiefsHierarchy.Items.Any())
				{
					continue;
				}
				List<IUser> list2 = new List<IUser>();
				foreach (IEnumerable<HierarchyChiefDisplayModel.HierarchyChiefModel> value2 in userChiefsHierarchy.Items.Values)
				{
					if (value2 == null)
					{
						continue;
					}
					HierarchyChiefDisplayModel.HierarchyChiefModel hierarchyChiefModel = value2.FirstOrDefault(delegate(HierarchyChiefDisplayModel.HierarchyChiefModel m)
					{
						//Discarded unreachable code: IL_0059, IL_0068
						int num = 1;
						int num2 = num;
						while (true)
						{
							switch (num2)
							{
							case 2:
								return _003C_003Ec.OnPaxxZRJH3J0Q2oXfod(m) != null;
							default:
								return false;
							case 1:
								if (m == null)
								{
									num2 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 != 0)
									{
										num2 = 0;
									}
									break;
								}
								goto case 2;
							}
						}
					});
					if (hierarchyChiefModel.User != executor && !list2.Contains(hierarchyChiefModel.User))
					{
						list2.Add(hierarchyChiefModel.User);
						if (hierarchyChiefModel.User.ReplacementUser != null && hierarchyChiefModel.User.DuplicateMessage == true && hierarchyChiefModel.User.ReplacementUser != executor && !list2.Contains(hierarchyChiefModel.User.ReplacementUser))
						{
							list2.Add(hierarchyChiefModel.User.ReplacementUser);
						}
					}
				}
				list.AddRange(list2);
			}
			else if (recipient.TypeUid == BaseWorkflowConstants.RecipientPropertyUid)
			{
				try
				{
					List<IUser> usersFromVariable = RecipientInfoForNotificationHelper.GetUsersFromVariable(CS_0024_003C_003E8__locals0.workflowTask.WorkflowBookmark.Instance, recipient.PropertyUid);
					if (usersFromVariable != null)
					{
						list.AddRange(usersFromVariable);
					}
				}
				catch (Exception message)
				{
					Logger.Log.Error(message);
				}
			}
			else if (recipient.TypeUid == WorkflowRoleTypes.Initiator.UID)
			{
				list.Add(CS_0024_003C_003E8__locals0.workflowTask.WorkflowBookmark.Instance.Initiator);
			}
			else if (recipient.TypeUid == WorkflowRoleTypes.ResponsibleForInstance.UID)
			{
				list.Add(CS_0024_003C_003E8__locals0.workflowTask.WorkflowBookmark.Instance.Responsible);
			}
			else if (recipient.TypeUid == WorkflowRoleTypes.ProcessOwner.UID)
			{
				if (CS_0024_003C_003E8__locals0.workflowTask.WorkflowBookmark.Instance.Process.CastAsRealType() is IBPMNProcess iBPMNProcess)
				{
					IResponsibilityMatrixItem responsibilityMatrixItem = ((IEnumerable<IResponsibilityMatrixItem>)iBPMNProcess.ResponsibilityMatrix).FirstOrDefault((IResponsibilityMatrixItem r) => _003C_003Ec.ws7tQpZRlSiOEhZNBEGS(r) == ResponsibilityLevel.Owner);
					if (responsibilityMatrixItem != null && responsibilityMatrixItem.WorkerType == OrganizationItemDTO.MetadataUid && responsibilityMatrixItem.WorkerId.HasValue)
					{
						AddOrganizationItem(list, OrganizationItemManager.Instance.Load(responsibilityMatrixItem.WorkerId.Value));
					}
				}
			}
			else if (recipient.TypeUid == OrganizationItemDTO.MetadataUid)
			{
				AddOrganizationItem(list, OrganizationItemManager.Instance.Load(recipient.RecipientId));
			}
		}
		return list;
	}

	private void AddOrganizationItem(List<IUser> recipients, IOrganizationItem orgItem)
	{
		if (orgItem != null)
		{
			if (orgItem.ItemType == OrganizationItemType.Position && orgItem.User != null)
			{
				recipients.Add(orgItem.User);
			}
			if (orgItem.ItemType == OrganizationItemType.EmployeeGroup && orgItem.Users != null)
			{
				recipients.AddRange((IEnumerable<IUser>)orgItem.Users);
			}
		}
	}

	public TaskExriredRecipientHandler()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		tsVdcL53RqJgTieyevQ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool S3NvrN564BZ9nrMJtDd()
	{
		return LV8Zn05RcnVnAw7I7xH == null;
	}

	internal static TaskExriredRecipientHandler EtktSX5qKaUrMbEybPO()
	{
		return LV8Zn05RcnVnAw7I7xH;
	}

	internal static void tsVdcL53RqJgTieyevQ()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
