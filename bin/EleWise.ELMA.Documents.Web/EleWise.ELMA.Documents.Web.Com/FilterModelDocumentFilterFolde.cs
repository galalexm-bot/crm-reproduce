using System;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.Components;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Models.Folders;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.Documents.Web.Components.Filter;

[Component(Order = 7)]
public class FilterModelDocumentFilterFolderZonePanel : BaseFilterPropertiesZone
{
	public static Guid UID = new Guid("{6480F1D8-84E3-43E1-BB62-A7AF493F197A}");

	public override Guid ZoneUid => UID;

	public override bool ShowHeader => false;

	public override ZoneType ZoneType => ZoneType.StaticPanel;

	public override ZoneMode ZoneMode => ZoneMode.FilterSerach;

	public override string DisplayName => string.Empty;

	public override bool IsPropertyInZone(FilterModel model, FilterMetadataProperty property)
	{
		return property.PropertyUid == InterfaceActivator.PropertyUid((IDmsObjectFilter p) => p.Folder);
	}

	public override bool CheckType(FilterModel model)
	{
		if (model != null && model.Entity != null && model.Entity is IFilterDocumentFolder)
		{
			return model.Entity.IsNew();
		}
		return false;
	}

	public override MvcHtmlString AdditionalContent(HtmlHelper html, FilterModel model)
	{
		return MvcHtmlString.Empty;
	}
}
