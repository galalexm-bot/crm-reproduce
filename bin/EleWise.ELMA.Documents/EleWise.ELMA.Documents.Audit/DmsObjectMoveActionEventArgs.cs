using System;
using System.Collections.Generic;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Security;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.Audit;

[Uid("43386819-A4FB-41DB-B297-9ED0B163DCF2")]
public class DmsObjectMoveActionEventArgs : EntityActionEventArgs
{
	private byte[] additionalData;

	private DmsObjectMoveInfo info;

	private IFolder oldFolder;

	private IFolder newFolder;

	public DmsObjectMoveInfo Info
	{
		get
		{
			if (info == null)
			{
				GetAdditionalData();
			}
			return info;
		}
	}

	public IFolder OldFolder
	{
		get
		{
			if (Info != null && oldFolder == null)
			{
				Locator.GetService<ISecurityService>()?.RunWithElevatedPrivilegies(delegate
				{
					oldFolder = FolderManager.Instance.LoadOrNull(Info.OldFolderId);
				});
			}
			return oldFolder;
		}
	}

	public IFolder NewFolder
	{
		get
		{
			if (Info != null && newFolder == null)
			{
				Locator.GetService<ISecurityService>()?.RunWithElevatedPrivilegies(delegate
				{
					newFolder = FolderManager.Instance.LoadOrNull(Info.NewFolderId);
				});
			}
			return newFolder;
		}
	}

	public override IDictionary<string, object> ExtendedProperties
	{
		get
		{
			IDictionary<string, object> extendedProperties = base.ExtendedProperties;
			extendedProperties["OldFolderId"] = Info.OldFolderId;
			extendedProperties["NewFolderId"] = Info.NewFolderId;
			return extendedProperties;
		}
	}

	protected DmsObjectMoveActionEventArgs(IEntity entity, Guid objectUid, Guid actionUid)
		: base(entity, objectUid, actionUid)
	{
	}

	public DmsObjectMoveActionEventArgs(IEntity old, IEntity @new, Guid actionUid, DmsObjectMoveInfo info)
		: base(old, @new, actionUid)
	{
		this.info = info;
	}

	public override byte[] GetAdditionalData()
	{
		if (additionalData != null)
		{
			return additionalData;
		}
		return additionalData = ClassSerializationHelper.SerializeObject(info);
	}

	public override void SetAdditionalData(byte[] data)
	{
		if (data != null)
		{
			additionalData = data;
			info = (DmsObjectMoveInfo)ClassSerializationHelper.DeserializeObject(data);
		}
	}
}
