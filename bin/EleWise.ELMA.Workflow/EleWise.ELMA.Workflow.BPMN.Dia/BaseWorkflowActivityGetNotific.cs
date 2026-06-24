using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.DTO.Models;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Activities;
using EleWise.ELMA.Workflow.BPMN.Models;
using EleWise.ELMA.Workflow.Diagrams.Elements;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Security;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.ExtensionPoints.ActivityNotificationRecipients.Implementations;

[Component(Order = int.MaxValue)]
internal sealed class BaseWorkflowActivityGetNotificationRecipientsImpl : BaseWorkflowActivityGetNotificationRecipientsComponent<IActivityNotificationRecipients>
{
	internal static BaseWorkflowActivityGetNotificationRecipientsImpl FOLpKYZOTpvr8Tjm2iNA;

	public BaseWorkflowActivityGetNotificationRecipientsImpl()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		bYsAPYZOCnRtaur70l6B();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void bYsAPYZOCnRtaur70l6B()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool wqXLfnZOQPRElHkaUwwS()
	{
		return FOLpKYZOTpvr8Tjm2iNA == null;
	}

	internal static BaseWorkflowActivityGetNotificationRecipientsImpl Ndoti6ZOpBGeunv1YcFZ()
	{
		return FOLpKYZOTpvr8Tjm2iNA;
	}
}
internal abstract class BaseWorkflowActivityGetNotificationRecipientsComponent<TActivity> : IWorkflowActivityGetNotificationRecipients where TActivity : IActivityNotificationRecipients
{
	private static object rynQe5ZOMDTRrNnQh37f;

	public virtual Type ActivityType => typeof(TActivity);

	public virtual IEnumerable<IUser> GetRecipients(GetRecipientsParameters parameters)
	{
		IElementWithNotification elementWithNotification = parameters.ElementWithNotification;
		if (elementWithNotification == null)
		{
			return Enumerable.Empty<IUser>();
		}
		List<Recipient> recipients2 = elementWithNotification.Recipients;
		if (recipients2 == null || recipients2.Count == 0)
		{
			return Enumerable.Empty<IUser>();
		}
		List<IUser> list = new List<IUser>();
		HashSet<long> userIdSet = new HashSet<long>();
		Dictionary<Guid, IEnumerable<Recipient>> dictionary = recipients2.GroupBy((Recipient recType) => recType.TypeUid, (Recipient recipient) => recipient, (Guid recTypeUid, IEnumerable<Recipient> recipients) => new Pair<Guid, IEnumerable<Recipient>>(recTypeUid, recipients)).ToDictionary((Pair<Guid, IEnumerable<Recipient>> x) => x.First, (Pair<Guid, IEnumerable<Recipient>> x) => x.Second);
		if (dictionary.TryGetValue(WorkflowRoleTypes.Initiator.UID, out var value))
		{
			foreach (IUser item in GetRecipientsByInitiator(parameters, value))
			{
				AddUser(userIdSet, item, list);
			}
		}
		if (dictionary.TryGetValue(WorkflowRoleTypes.ProcessOwner.UID, out value))
		{
			foreach (IUser item2 in GetRecipientsByProcessOwner(parameters, value))
			{
				AddUser(userIdSet, item2, list);
			}
		}
		if (dictionary.TryGetValue(WorkflowRoleTypes.ResponsibleForInstance.UID, out value))
		{
			foreach (IUser item3 in GetRecipientsByResponsibleForProcess(parameters, value))
			{
				AddUser(userIdSet, item3, list);
			}
		}
		if (dictionary.TryGetValue(OrganizationItemDTO.MetadataUid, out value))
		{
			foreach (IUser item4 in GetRecipientsByOrganizationItem(parameters, value))
			{
				AddUser(userIdSet, item4, list);
			}
			return list;
		}
		return list;
	}

	protected virtual IEnumerable<IUser> GetRecipientsByInitiator(GetRecipientsParameters parameters, IEnumerable<Recipient> recipients)
	{
		if (!recipients.Any() || parameters.Instance == null)
		{
			return Enumerable.Empty<IUser>();
		}
		return new IUser[1] { parameters.Instance.Initiator };
	}

	protected virtual IEnumerable<IUser> GetRecipientsByProcessOwner(GetRecipientsParameters parameters, IEnumerable<Recipient> recipients)
	{
		if (parameters.Instance?.Process.CastAsRealType() is IBPMNProcess iBPMNProcess && recipients.Any())
		{
			IResponsibilityMatrixItem responsibilityMatrixItem = ((IEnumerable<IResponsibilityMatrixItem>)iBPMNProcess.ResponsibilityMatrix).FirstOrDefault((IResponsibilityMatrixItem r) => r.ResponsibilityLevel == ResponsibilityLevel.Owner);
			if (responsibilityMatrixItem != null && responsibilityMatrixItem.WorkerId.HasValue && responsibilityMatrixItem.WorkerType == OrganizationItemDTO.MetadataUid)
			{
				IOrganizationItem organizationItem = OrganizationItemManager.Instance.LoadOrNull(responsibilityMatrixItem.WorkerId.Value);
				if (organizationItem == null)
				{
					return Enumerable.Empty<IUser>();
				}
				IUserFilter userFilter = InterfaceActivator.Create<IUserFilter>();
				userFilter.OrganizationItem = organizationItem;
				return UserManager.Instance.Find(userFilter, null);
			}
		}
		return Enumerable.Empty<IUser>();
	}

	protected virtual IEnumerable<IUser> GetRecipientsByResponsibleForProcess(GetRecipientsParameters parameters, IEnumerable<Recipient> recipients)
	{
		if (parameters.Instance == null || !recipients.Any())
		{
			return Enumerable.Empty<IUser>();
		}
		return new IUser[1] { parameters.Instance.Responsible };
	}

	protected virtual IEnumerable<IUser> GetRecipientsByOrganizationItem(GetRecipientsParameters parameters, IEnumerable<Recipient> recipients)
	{
		List<IUser> list = new List<IUser>();
		long[] array = recipients.Select((Recipient x) => x.RecipientId).ToArray();
		if (array.Length == 0)
		{
			return Enumerable.Empty<IUser>();
		}
		foreach (var item in OrganizationItemManager.Instance.FindByIdArray(array).GroupBy((IOrganizationItem orgItem) => orgItem.ItemType, (IOrganizationItem orgItem) => orgItem, (OrganizationItemType itemType, IEnumerable<IOrganizationItem> orgItems) => new
		{
			ItemType = itemType,
			OrgItems = orgItems
		}))
		{
			if (item.ItemType == OrganizationItemType.EmployeeGroup)
			{
				foreach (IUser item2 in item.OrgItems.SelectMany((IOrganizationItem oi) => (IEnumerable<IUser>)oi.Users))
				{
					list.Add(item2);
				}
			}
			if (item.ItemType != OrganizationItemType.Position)
			{
				continue;
			}
			IUserFilter userFilter = InterfaceActivator.Create<IUserFilter>();
			userFilter.OrganizationItemIds = item.OrgItems.Select((IOrganizationItem oi) => oi.Id).ToList();
			foreach (IUser item3 in UserManager.Instance.Find(userFilter, null))
			{
				list.Add(item3);
			}
		}
		return list;
	}

	private static void AddUser(HashSet<long> userIdSet, IUser user, List<IUser> userList)
	{
		if (userIdSet.Add(user.Id))
		{
			userList.Add(user);
		}
	}

	protected BaseWorkflowActivityGetNotificationRecipientsComponent()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool rU57gWZOkQ3WgbVFfAnS()
	{
		return rynQe5ZOMDTRrNnQh37f == null;
	}

	internal static object RQQkDBZOUuMN5kPAUSg2()
	{
		return rynQe5ZOMDTRrNnQh37f;
	}
}
