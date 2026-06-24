using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc;

namespace EleWise.ELMA.BPM.Web.Tasks.Extensions;

[Component]
public class EntityTypeFilterPropertyEditor : IFilterPropertyEditorExtension
{
	public bool Resolve(FilterMetadataProperty property, FilterModel filterModel)
	{
		if (filterModel.Filter is IWorkLogActivityFilter && filterModel.Entity != null)
		{
			return property.PropertyUid == InterfaceActivator.PropertyUid((IWorkLogActivityFilter p) => p.EntityTypeUid);
		}
		return false;
	}

	public MvcHtmlString PropertyEditor(HtmlHelper<object> html, FilterMetadataProperty property, FilterModel filterModel)
	{
		return null;
	}

	public void PropertyAction(HtmlHelper<object> html, FilterMetadataProperty property, FilterModel filterModel, WebViewAttributes a)
	{
		a.TemplateName = "WorkLogObjectTypeSelector";
	}
}
