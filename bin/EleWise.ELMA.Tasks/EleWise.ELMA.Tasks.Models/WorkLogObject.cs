using System;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Tasks.Components;
using EleWise.ELMA.Tasks.ExtensionPoints;

namespace EleWise.ELMA.Tasks.Models;

public class WorkLogObject
{
	public Guid ExtensionUid { get; set; }

	public long ObjectId { get; set; }

	public Guid ObjectUid { get; set; }

	public IUser Harmonizator { get; set; }

	public IEntity Entity
	{
		get
		{
			if (!(ObjectUid == Guid.Empty))
			{
				return WorkLogExtensionHelper.LoadObject(ObjectId, ObjectUid);
			}
			return null;
		}
	}

	public string EntityDisplayName
	{
		get
		{
			if (Entity == null)
			{
				return "";
			}
			return (MetadataLoader.LoadMetadata(Entity.GetType()) as EntityMetadata).DisplayName;
		}
	}

	public WorkLogObject()
	{
		ExtensionUid = Guid.Empty;
		ObjectUid = Guid.Empty;
	}

	public static WorkLogObject Create(IWorkLogItem item)
	{
		return new WorkLogObject
		{
			ObjectId = item.ObjectId,
			ObjectUid = item.ObjectUID,
			Harmonizator = item.Harmonizator,
			ExtensionUid = WorkLogExtensionHelper.FindExtensionByObjectUid(item.ObjectUID).Uid
		};
	}

	public IWorkLogExtension Extension()
	{
		if (!(ExtensionUid != Guid.Empty))
		{
			return null;
		}
		return WorkLogExtensionHelper.FindExtensionByUid(ExtensionUid);
	}

	public string TypeName()
	{
		if (ObjectUid == Guid.Empty)
		{
			return "";
		}
		if (!(InterfaceActivator.LoadMetadata(ModelHelper.GetEntityType(ObjectUid)) is ClassMetadata classMetadata))
		{
			return "";
		}
		return classMetadata.DisplayName;
	}
}
