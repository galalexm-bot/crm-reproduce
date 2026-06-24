using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Models;

namespace EleWise.ELMA.BPM.Web.Common.Components;

[Component]
public sealed class CollectionHistoryPropertyRowDisplay : IHistoryPropertyRowDisplay
{
	public bool CanDisplay(ModelMetadata oldMetadata, ModelMetadata newMetadata)
	{
		if (oldMetadata == null || newMetadata == null)
		{
			return false;
		}
		if ((oldMetadata.GetPropertyMetadata() as PropertyMetadata).Settings is EntitySettings entitySettings)
		{
			return entitySettings.RelationType != RelationType.OneToOne;
		}
		return false;
	}

	public MvcHtmlString DisplayChanges(HtmlHelper html, ModelMetadata oldMetadata, ModelMetadata newMetadata, PropertyChangesRow rowData)
	{
		if (rowData == null)
		{
			return MvcHtmlString.Empty;
		}
		return PartialExtensions.Partial(html, "Templates/CollectionPropertyChangesRow", (object)new CollectionPropertyChangesRow(rowData));
	}
}
