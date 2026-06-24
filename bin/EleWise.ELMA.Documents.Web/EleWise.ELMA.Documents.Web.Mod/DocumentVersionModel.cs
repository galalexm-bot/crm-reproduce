using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Web.Mvc.Models.Forms;

namespace EleWise.ELMA.Documents.Web.Models;

public class DocumentVersionModel : FormViewModel
{
	public string FormId { get; set; }

	public IDocument Document { get; set; }

	[RequiredField]
	[Required(true)]
	public IDocumentVersion Version { get; set; }

	public bool IsCurrent { get; set; }

	public bool NeedSign { get; set; }

	public bool ForceNeedSign { get; set; }

	public string PopupId { get; set; }

	public IDocumentMetadataProfile Profile { get; set; }

	public bool UseFile { get; set; }

	public string AttributesDigitalSignature { get; set; }

	public string ContentDigitalSignature { get; set; }

	public bool UseAttributesDigitalSignature { get; set; }

	public bool UseContentDigitalSignature { get; set; }

	public long? CreatedVersionId { get; set; }

	public bool NotAjax { get; set; }

	public bool ReadOnly { get; set; }

	public DocumentVersionModel()
	{
		base.PostAction = "Create";
		base.PostController = "DocumentVersion";
		base.PostArea = "EleWise.ELMA.Documents.Web";
		PopupId = "DocumentVersionEditDiv";
		UseFile = true;
	}
}
