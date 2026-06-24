using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Audit;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Documents.Audit;

[Uid("9B5C8449-610C-46B2-BF44-2E2009E65B07")]
public class DmsObjectChangeAccessActionEventArgs : EntityActionEventArgs
{
	private byte[] _additionalData;

	private DmsObjectPermissionsInfo _info;

	public DmsObjectPermissionsInfo Info
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

	protected DmsObjectChangeAccessActionEventArgs(IEntity entity, Guid objectUid, Guid actionUid)
		: base(entity, objectUid, actionUid)
	{
	}

	public DmsObjectChangeAccessActionEventArgs(IEntity old, IEntity @new, Guid actionUid, DmsObjectPermissionsInfo info)
		: base(old, @new, actionUid)
	{
		_info = info;
	}

	public DmsObjectChangeAccessActionEventArgs(IEntity old, IEntity @new, Guid actionUid)
		: base(old, @new, actionUid)
	{
	}

	public void FillInfo(List<IDmsObjectPermission> oldPermissions, List<IDmsObjectPermission> newPermissions)
	{
		_info = new DmsObjectPermissionsInfo();
		_info.OldPermissionInfos = CreatePermissionInfo(oldPermissions);
		_info.NewPermissionInfos = CreatePermissionInfo(newPermissions);
	}

	protected virtual List<HistoryPermissionInfo> CreatePermissionInfo(List<IDmsObjectPermission> permissions)
	{
		List<HistoryPermissionInfo> list = new List<HistoryPermissionInfo>();
		foreach (IGrouping<IEntity, IDmsObjectPermission> item in from p in permissions
			group p by p.Assigned)
		{
			if (item.Key == null)
			{
				continue;
			}
			List<IDmsObjectPermission> list2 = item.ToList();
			Guid objectType = GetObjectType(item.Key);
			if (objectType == Guid.Empty)
			{
				continue;
			}
			if (list2.Count == 1)
			{
				list.Add(new HistoryPermissionInfo
				{
					ObjectId = Convert.ToInt64(item.Key.GetId()),
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
				IDmsObjectPermission dmsObjectPermission = list2.FirstOrDefault((IDmsObjectPermission p) => p.PermissionId == PermissionProvider.DocumentFullAccessPermission.Id);
				if (dmsObjectPermission == null)
				{
					dmsObjectPermission = list2.FirstOrDefault((IDmsObjectPermission p) => p.PermissionId == PermissionProvider.DocumentEditPermission.Id);
				}
				if (dmsObjectPermission == null)
				{
					dmsObjectPermission = list2.FirstOrDefault((IDmsObjectPermission p) => p.PermissionId == PermissionProvider.DocumentLoadPermission.Id);
				}
				if (dmsObjectPermission == null)
				{
					dmsObjectPermission = list2.FirstOrDefault((IDmsObjectPermission p) => p.PermissionId == PermissionProvider.DocumentViewPermission.Id);
				}
				bool manageAccess = list2.Any((IDmsObjectPermission p) => p.PermissionId == PermissionProvider.DocumentFullAccessPermission.Id) || list2.Any((IDmsObjectPermission p) => p.PermissionId == PermissionProvider.DocumentManagerAccessPermission.Id);
				if (dmsObjectPermission != null)
				{
					list.Add(new HistoryPermissionInfo
					{
						ObjectId = Convert.ToInt64(item.Key.GetId()),
						ObjectTypeUid = objectType,
						PermissionId = dmsObjectPermission.PermissionId,
						ManageAccess = manageAccess
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
			_info = (DmsObjectPermissionsInfo)ClassSerializationHelper.DeserializeObject(data);
		}
	}
}
