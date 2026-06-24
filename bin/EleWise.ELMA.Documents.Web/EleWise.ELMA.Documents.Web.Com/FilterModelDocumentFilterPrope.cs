using System;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.Documents.Web.Components.Filter;

[Component(Order = 20)]
public class FilterModelDocumentFilterPropertiesZonePanel : DocumentFilterPropertiesZonePanel
{
	public new static Guid UID = new Guid("{05E20510-D679-4058-8816-4E107B1DD98B}");

	public override Guid ZoneUid => UID;

	public override ZoneMode ZoneMode => ZoneMode.FilterSerach;

	public override Guid? ParentZone => null;

	public override string DisplayName => SR.T("Атрибуты документа");

	public override bool CheckType(FilterModel model)
	{
		if (base.CheckType(model))
		{
			return model.Entity.IsNew();
		}
		return false;
	}

	public override bool IsPropertyInZone(FilterModel model, FilterMetadataProperty property)
	{
		bool flag = base.IsPropertyInZone(model, property);
		bool flag2 = property.PropertyUid != InterfaceActivator.PropertyUid((IDmsObjectFilter p) => p.Folder);
		return flag && flag2;
	}
}
