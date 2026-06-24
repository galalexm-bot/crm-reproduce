using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Audit;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.CRM.Audit;

[Uid("94ED068D-540F-4E75-AD23-7715ED48C7E5")]
public class ContractorChangeAccessActionEventArgs : EntityActionEventArgs
{
	private byte[] _additionalData;

	private CrmPermissionsInfo _info;

	public CrmPermissionsInfo Info
	{
		get
		{
			if (_info == null)
			{
				GetAdditionalData();
			}
			return _info;
		}
	}

	protected ContractorChangeAccessActionEventArgs(IEntity entity, Guid objectUid, Guid actionUid)
		: base(entity, objectUid, actionUid)
	{
	}

	public ContractorChangeAccessActionEventArgs(IEntity old, IEntity @new, Guid actionUid, CrmPermissionsInfo info)
		: base(old, @new, actionUid)
	{
		_info = info;
	}

	public ContractorChangeAccessActionEventArgs(IEntity old, IEntity @new, Guid actionUid)
		: base(old, @new, actionUid)
	{
	}

	public void FillInfo(List<IContractorPersonPermission> oldPermissions, List<IContractorPersonPermission> newPermissions)
	{
		_info = new CrmPermissionsInfo();
		_info.OldPermissionInfos = CreatePermissionInfo(oldPermissions);
		_info.NewPermissionInfos = CreatePermissionInfo(newPermissions);
	}

	protected virtual List<HistoryPermissionInfo> CreatePermissionInfo(List<IContractorPersonPermission> permissions)
	{
		List<HistoryPermissionInfo> list = new List<HistoryPermissionInfo>();
		foreach (IGrouping<Guid, IContractorPersonPermission> item in from c in permissions
			where c.TypeRoleId == CommonRoleTypes.ParticipantWork.Id || c.TypeRoleId == CommonRoleTypes.Informs.Id || c.TypeRoleId == CommonRoleTypes.Responsible.Id
			select c into p
			group p by p.TypeRoleId)
		{
			List<IContractorPersonPermission> source = item.ToList();
			IContractorPersonPermission contractorPersonPermission = source.FirstOrDefault((IContractorPersonPermission p) => p.PermissionId == CRMPermissionProvider.CRMContractorFullAccessPermission.Id);
			if (contractorPersonPermission == null)
			{
				contractorPersonPermission = source.FirstOrDefault((IContractorPersonPermission p) => p.PermissionId == CRMPermissionProvider.EditContractorPermission.Id);
			}
			if (contractorPersonPermission == null)
			{
				contractorPersonPermission = source.FirstOrDefault((IContractorPersonPermission p) => p.PermissionId == CRMPermissionProvider.ViewContractorPermission.Id);
			}
			bool manageAccess = source.Any((IContractorPersonPermission p) => p.PermissionId == CRMPermissionProvider.CRMContractorFullAccessPermission.Id) || source.Any((IContractorPersonPermission p) => p.PermissionId == CRMPermissionProvider.CRMContractorIssuanceElementPermission.Id);
			bool flag = source.Any((IContractorPersonPermission p) => p.PermissionId == CRMPermissionProvider.CRMContractorFullAccessPermission.Id);
			if (contractorPersonPermission != null)
			{
				list.Add(new HistoryPermissionInfo
				{
					ObjectId = 0L,
					PermissionId = contractorPersonPermission.PermissionId,
					RoleTypeUid = item.Key,
					ManageAccess = manageAccess
				});
			}
			contractorPersonPermission = source.FirstOrDefault((IContractorPersonPermission p) => p.PermissionId == CRMPermissionProvider.CRMContractorCreateElementPermission.Id);
			if (contractorPersonPermission != null && !flag)
			{
				list.Add(new HistoryPermissionInfo
				{
					ObjectId = 0L,
					PermissionId = contractorPersonPermission.PermissionId,
					RoleTypeUid = item.Key,
					ManageAccess = false
				});
			}
		}
		foreach (IGrouping<IEntity, IContractorPersonPermission> item2 in from c in permissions
			where !(c.TypeRoleId == CommonRoleTypes.ParticipantWork.Id) && !(c.TypeRoleId == CommonRoleTypes.Informs.Id) && !(c.TypeRoleId == CommonRoleTypes.Responsible.Id)
			select c into p
			group p by p.Assigned)
		{
			if (item2.Key == null)
			{
				continue;
			}
			List<IContractorPersonPermission> list2 = item2.ToList();
			Guid objectType = GetObjectType(item2.Key);
			if (objectType == Guid.Empty)
			{
				continue;
			}
			if (list2.Count == 1)
			{
				list.Add(new HistoryPermissionInfo
				{
					ObjectId = Convert.ToInt64(item2.Key.GetId()),
					ObjectTypeUid = objectType,
					PermissionId = list2[0].PermissionId
				});
			}
			else
			{
				if (list2.Count <= 1)
				{
					continue;
				}
				IContractorPersonPermission contractorPersonPermission2 = list2.FirstOrDefault((IContractorPersonPermission p) => p.PermissionId == CRMPermissionProvider.CRMContractorFullAccessPermission.Id);
				if (contractorPersonPermission2 == null)
				{
					contractorPersonPermission2 = list2.FirstOrDefault((IContractorPersonPermission p) => p.PermissionId == CRMPermissionProvider.EditContractorPermission.Id);
				}
				if (contractorPersonPermission2 == null)
				{
					contractorPersonPermission2 = list2.FirstOrDefault((IContractorPersonPermission p) => p.PermissionId == CRMPermissionProvider.ViewContractorPermission.Id);
				}
				bool manageAccess2 = list2.Any((IContractorPersonPermission p) => p.PermissionId == CRMPermissionProvider.CRMContractorFullAccessPermission.Id) || list2.Any((IContractorPersonPermission p) => p.PermissionId == CRMPermissionProvider.CRMContractorIssuanceElementPermission.Id);
				bool flag2 = list2.Any((IContractorPersonPermission p) => p.PermissionId == CRMPermissionProvider.CRMContractorFullAccessPermission.Id);
				if (contractorPersonPermission2 != null)
				{
					list.Add(new HistoryPermissionInfo
					{
						ObjectId = Convert.ToInt64(item2.Key.GetId()),
						ObjectTypeUid = objectType,
						PermissionId = contractorPersonPermission2.PermissionId,
						ManageAccess = manageAccess2
					});
				}
				contractorPersonPermission2 = list2.FirstOrDefault((IContractorPersonPermission p) => p.PermissionId == CRMPermissionProvider.CRMContractorCreateElementPermission.Id);
				if (contractorPersonPermission2 != null && !flag2)
				{
					list.Add(new HistoryPermissionInfo
					{
						ObjectId = Convert.ToInt64(item2.Key.GetId()),
						ObjectTypeUid = objectType,
						PermissionId = contractorPersonPermission2.PermissionId,
						ManageAccess = false
					});
				}
			}
		}
		return list;
	}

	protected virtual Guid GetObjectType(IEntity assigned)
	{
		if (assigned == null)
		{
			return Guid.Empty;
		}
		return InterfaceActivator.UID(assigned.GetType());
	}

	public override byte[] GetAdditionalData()
	{
		if (_additionalData != null)
		{
			return _additionalData;
		}
		return _additionalData = ClassSerializationHelper.SerializeObject(_info);
	}

	public override void SetAdditionalData(byte[] data)
	{
		if (data != null)
		{
			_additionalData = data;
			_info = (CrmPermissionsInfo)ClassSerializationHelper.DeserializeObject(data);
		}
	}
}
