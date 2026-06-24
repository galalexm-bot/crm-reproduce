using System;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Documents.Web.Components.Filter;

[Component(Order = 23)]
public class FilterModelDocumentFilterAllPropertiesZonePanel : DocumentFilterPropertiesZonePanel
{
	public new static Guid UID = new Guid("{D59ABDF5-C910-4F04-B419-9EDC9D5A2533}");

	public override Guid ZoneUid => UID;

	public override ZoneMode ZoneMode => ZoneMode.FilterSerach;

	public override Guid? ParentZone => null;

	public override bool ShowHeader => false;

	public override bool UseSaveState => true;

	public override bool IsPropertyInZone(FilterModel model, FilterMetadataProperty property)
	{
		return true;
	}

	public override bool CheckType(FilterModel model)
	{
		if (base.CheckType(model))
		{
			return !model.Entity.IsNew();
		}
		return false;
	}
}
