using System;
using EleWise.ELMA.BPM.Web.Common.Components;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models.Folders;

namespace EleWise.ELMA.Documents.Web.Components.Filter;

[Component(Order = 5)]
public class DocumentFilterPropertiesZoneTab : BaseFilterPropertiesZone
{
	public static Guid UID = new Guid("{EB241BC7-877E-41BB-9C3D-8C4282292313}");

	public override Guid ZoneUid => UID;

	public override ZoneType ZoneType => ZoneType.Tab;

	public override string DisplayName => SR.T("Фильтр");

	public override bool CheckType(FilterModel model)
	{
		if (model != null && model.Entity != null)
		{
			return model.Entity is IFilterDocumentFolder;
		}
		return false;
	}

	public override bool IsPropertyInZone(FilterModel model, FilterMetadataProperty property)
	{
		return false;
	}
}
