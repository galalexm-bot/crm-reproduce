using System;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Tasks.Components;
using EleWise.ELMA.Tasks.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class WorkLogObjectInfoModel
{
	public IEntity Entity { get; set; }

	public Guid ExtensionUid { get; set; }

	public long DayIndex { get; set; }

	public long IndexItem { get; set; }

	public IUser Harmonizator { get; set; }

	public Guid ObjectUid { get; set; }

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
		if (!(InterfaceActivator.LoadMetadata((Entity == null) ? ModelHelper.GetEntityType(ObjectUid) : Entity.GetType()) is ClassMetadata classMetadata))
		{
			return "";
		}
		return classMetadata.DisplayName;
	}
}
