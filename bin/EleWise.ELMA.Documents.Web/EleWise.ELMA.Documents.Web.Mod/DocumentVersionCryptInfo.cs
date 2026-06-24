using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Documents.Web.Models;

public sealed class DocumentVersionCryptInfo : EntityModel<IDocumentVersion>
{
	public string Password { get; set; }

	public string PostAction { get; set; }

	public string PostController { get; set; }

	public string PostArea { get; set; }

	public bool AjaxPost { get; set; }

	public string Callback { get; set; }

	public string ReturnUrl { get; set; }

	public string DownloadUrl { get; set; }

	public string PopupContentUrl { get; set; }

	public string PopupId { get; set; }

	public DocumentVersionCryptInfo()
	{
		PostAction = "EncryptLogOn";
		PostController = "DocumentVersion";
		PostArea = "EleWise.ELMA.Documents.Web";
	}
}
