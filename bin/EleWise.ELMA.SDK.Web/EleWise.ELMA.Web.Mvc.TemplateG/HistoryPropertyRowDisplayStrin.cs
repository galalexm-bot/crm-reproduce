using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Models;

namespace EleWise.ELMA.Web.Mvc.TemplateGenerators;

[Component]
public class HistoryPropertyRowDisplayString : IHistoryPropertyRowDisplay
{
	public bool CanDisplay(ModelMetadata oldMetadata, ModelMetadata newMetadata)
	{
		if (oldMetadata == null || newMetadata == null)
		{
			return false;
		}
		if (oldMetadata.GetPropertyMetadata() is PropertyMetadata propertyMetadata && propertyMetadata.Settings is StringSettings stringSettings && stringSettings.MultiLine)
		{
			return true;
		}
		return false;
	}

	public MvcHtmlString DisplayChanges(HtmlHelper html, ModelMetadata oldMetadata, ModelMetadata newMetadata, PropertyChangesRow rowData)
	{
		if (rowData == null)
		{
			return MvcHtmlString.Empty;
		}
		return PartialExtensions.Partial(html, "Templates/StringPropertyChangesRow", (object)rowData);
	}
}
