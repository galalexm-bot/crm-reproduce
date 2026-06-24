using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Web.Mvc.Models.Boxes;

namespace EleWise.ELMA.Documents.Web.Components;

public class DocumentAttachmentAutocompleteItem : AutocompleteItem
{
	public long Id { get; private set; }

	public long Index { get; private set; }

	public DocumentAttachmentAutocompleteItem(IDocumentAttachment attachment, long index)
	{
		Id = attachment.Id;
		Index = index;
		base.Text = attachment.Document.ToString();
		base.Value = attachment.Document.Id.ToString();
	}
}
