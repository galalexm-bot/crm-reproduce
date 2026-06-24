using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Metadata;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Model.Views.Builders;

namespace EleWise.ELMA.Documents.Web.Components;

[Component]
public class DocumentExtensionZoneFormViewItemTransformate : IFormViewItemTransformate
{
	public FormViewItem Transformate(FormViewItem formViewItem, object model)
	{
		if ((formViewItem.MetadataUid.HasValue ? (MetadataLoader.LoadMetadataOrNull(formViewItem.MetadataUid.Value) as DocumentMetadata) : null) == null)
		{
			return formViewItem;
		}
		return formViewItem.Transformate(delegate(FormViewItemTransformationBuilder<IDocument> t)
		{
			(from z in formViewItem.GetAllItems().OfType<ExtensionZoneViewItem>()
				where z.ZoneId == "EleWise.ELMA.Documents.Web.Document.EditForm.MiddleForm"
				select z).Each(delegate(ExtensionZoneViewItem p)
			{
				t.ForItem<ExtensionZoneViewItem>(p.Uid).SetPropertyValue((ExtensionZoneViewItem i) => i.SupportInColumnRender, value: true);
			});
		});
	}
}
