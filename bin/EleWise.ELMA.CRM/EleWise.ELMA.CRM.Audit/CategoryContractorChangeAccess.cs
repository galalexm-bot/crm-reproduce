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

[Uid("A4CF7644-6ADF-443D-9A91-295C3DEDB9F9")]
public class CategoryContractorChangeAccessActionEventArgs : EntityActionEventArgs
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

	protected CategoryContractorChangeAccessActionEventArgs(IEntity entity, Guid objectUid, Guid actionUid)
		: base(entity, objectUid, actionUid)
	{
	}

	public CategoryContractorChangeAccessActionEventArgs(IEntity old, IEntity @new, Guid actionUid, CrmPermissionsInfo info)
		: base(old, @new, actionUid)
	{
		_info = info;
	}

	public CategoryContractorChangeAccessActionEventArgs(IEntity old, IEntity @new, Guid actionUid)
		: base(old, @new, actionUid)
	{
	}

	public void FillInfo(List<ITemplateContractorPermission> oldPermissions, List<ITemplateContractorPermission> newPermissions)
	{
		_info = new CrmPermissionsInfo();
		_info.OldPermissionInfos = CreatePermissionInfo(oldPermissions);
		_info.NewPermissionInfos = CreatePermissionInfo(newPermissions);
	}

	public void FillInfoOld(List<ITemplateContractorPermission> oldPermissions)
	{
		if (_info == null)
		{
			_info = new CrmPermissionsInfo();
		}
		_info.OldPermissionInfos = CreatePermissionInfo(oldPermissions);
	}

	public void AddCategory(long categoryId)
	{
		if (_info == null)
		{
			_info = new CrmPermissionsInfo();
		}
		_info.CategoryId = categoryId;
	}

	public void FillInfoNew(List<ITemplateContractorPermission> newPermissions)
	{
		if (_info == null)
		{
			_info = new CrmPermissionsInfo();
		}
		_info.NewPermissionInfos = CreatePermissionInfo(newPermissions);
	}

	protected virtual List<HistoryPermissionInfo> CreatePermissionInfo(List<ITemplateContractorPermission> permissions)
	{
		List<HistoryPermissionInfo> list = new List<HistoryPermissionInfo>();
		foreach (IGrouping<Guid, ITemplateContractorPermission> item in from c in permissions
			where c.TypeRoleId == CommonRoleTypes.ParticipantWork.Id || c.TypeRoleId == CommonRoleTypes.Informs.Id || c.TypeRoleId == CommonRoleTypes.Responsible.Id || c.TypeRoleId == CommonRoleTypes.Author.Id
			select c into p
			group p by p.TypeRoleId)
		{
			List<ITemplateContractorPermission> source = item.ToList();
			ITemplateContractorPermission templateContractorPermission = source.FirstOrDefault((ITemplateContractorPermission p) => p.PermissionId == CRMPermissionProvider.CRMContractorFullAccessPermission.Id);
			if (templateContractorPermission == null)
			{
				templateContractorPermission = source.FirstOrDefault((ITemplateContractorPermission p) => p.PermissionId == CRMPermissionProvider.EditContractorPermission.Id);
			}
			if (templateContractorPermission == null)
			{
				templateContractorPermission = source.FirstOrDefault((ITemplateContractorPermission p) => p.PermissionId == CRMPermissionProvider.ViewContractorPermission.Id);
			}
			bool manageAccess = source.Any((ITemplateContractorPermission p) => p.PermissionId == CRMPermissionProvider.CRMContractorFullAccessPermission.Id) || source.Any((ITemplateContractorPermission p) => p.PermissionId == CRMPermissionProvider.CRMContractorIssuanceElementPermission.Id);
			bool flag = source.Any((ITemplateContractorPermission p) => p.PermissionId == CRMPermissionProvider.CRMContractorFullAccessPermission.Id);
			if (templateContractorPermission != null)
			{
				list.Add(new HistoryPermissionInfo
				{
					ObjectId = 0L,
					PermissionId = templateContractorPermission.PermissionId,
					RoleTypeUid = item.Key,
					ManageAccess = manageAccess
				});
			}
			templateContractorPermission = source.FirstOrDefault((ITemplateContractorPermission p) => p.PermissionId == CRMPermissionProvider.CRMContractorCreateElementPermission.Id);
			if (templateContractorPermission != null && !flag)
			{
				list.Add(new HistoryPermissionInfo
				{
					ObjectId = 0L,
					PermissionId = templateContractorPermission.PermissionId,
					RoleTypeUid = item.Key,
					ManageAccess = false
				});
			}
		}
		foreach (IGrouping<IEntity, ITemplateContractorPermission> item2 in from c in permissions
			where !(c.TypeRoleId == CommonRoleTypes.ParticipantWork.Id) && !(c.TypeRoleId == CommonRoleTypes.Informs.Id) && !(c.TypeRoleId == CommonRoleTypes.Responsible.Id) && !(c.TypeRoleId == CommonRoleTypes.Author.Id)
			select c into p
			group p by p.Assigned)
		{
			if (item2.Key == null)
			{
				continue;
			}
			List<ITemplateContractorPermission> list2 = item2.ToList();
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
				ITemplateContractorPermission templateContractorPermission2 = list2.FirstOrDefault((ITemplateContractorPermission p) => p.PermissionId == CRMPermissionProvider.CRMContractorFullAccessPermission.Id);
				if (templateContractorPermission2 == null)
				{
					templateContractorPermission2 = list2.FirstOrDefault((ITemplateContractorPermission p) => p.PermissionId == CRMPermissionProvider.EditContractorPermission.Id);
				}
				if (templateContractorPermission2 == null)
				{
					templateContractorPermission2 = list2.FirstOrDefault((ITemplateContractorPermission p) => p.PermissionId == CRMPermissionProvider.ViewContractorPermission.Id);
				}
				bool manageAccess2 = list2.Any((ITemplateContractorPermission p) => p.PermissionId == CRMPermissionProvider.CRMContractorFullAccessPermission.Id) || list2.Any((ITemplateContractorPermission p) => p.PermissionId == CRMPermissionProvider.CRMContractorIssuanceElementPermission.Id);
				bool flag2 = list2.Any((ITemplateContractorPermission p) => p.PermissionId == CRMPermissionProvider.CRMContractorFullAccessPermission.Id);
				if (templateContractorPermission2 != null)
				{
					list.Add(new HistoryPermissionInfo
					{
						ObjectId = Convert.ToInt64(item2.Key.GetId()),
						ObjectTypeUid = objectType,
						PermissionId = templateContractorPermission2.PermissionId,
						ManageAccess = manageAccess2
					});
				}
				templateContractorPermission2 = list2.FirstOrDefault((ITemplateContractorPermission p) => p.PermissionId == CRMPermissionProvider.CRMContractorCreateElementPermission.Id);
				if (templateContractorPermission2 != null && !flag2)
				{
					list.Add(new HistoryPermissionInfo
					{
						ObjectId = Convert.ToInt64(item2.Key.GetId()),
						ObjectTypeUid = objectType,
						PermissionId = templateContractorPermission2.PermissionId,
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
