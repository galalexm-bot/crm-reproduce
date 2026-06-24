using System;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.BPM.Web.Common.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IFilterPropertiesZone
{
	Guid ZoneUid { get; }

	Guid? ParentZone { get; }

	ZoneType ZoneType { get; }

	string DisplayName { get; }

	bool ShowHeader { get; }

	string HeaderCss { get; }

	ZoneMode ZoneMode { get; }

	bool UseSaveState { get; }

	bool CheckType(FilterModel model);

	bool IsPropertyInZone(FilterModel model, FilterMetadataProperty property);

	MvcHtmlString AdditionalContent(HtmlHelper html, FilterModel model);

	bool IsVisible(FilterModel model);

	IEntityFilter GetFilter(FilterModel model);

	string PreUpdateJS(FilterModel model);
}
