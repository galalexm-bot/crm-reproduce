using System;
using EleWise.ELMA.BPM.Web.Common.Components;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models.Folders;

namespace EleWise.ELMA.Documents.Web.Components.Filter;

[Component(Order = 10)]
public class DocumentsTypeEQLZonePanel : BaseFilterPropertiesZone
{
	public static Guid UID = new Guid("{9953C9DB-CBE0-470C-9DA0-D071C9D81DC0}");

	public override Guid ZoneUid => UID;

	public override ZoneType ZoneType => ZoneType.StaticPanel;

	public override string DisplayName => null;

	public override Guid? ParentZone => DocumentFilterPropertiesZoneTab.UID;

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
