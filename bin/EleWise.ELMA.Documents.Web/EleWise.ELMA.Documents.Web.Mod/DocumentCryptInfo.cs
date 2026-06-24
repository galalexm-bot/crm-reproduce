using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Documents.Web.Models;

public class DocumentCryptInfo : EntityModel<IDocument>
{
	public string Password { get; set; }

	public string PasswordConfirm { get; set; }

	public string OldPassword { get; set; }

	public string PostAction { get; set; }

	public string PostController { get; set; }

	public string PostArea { get; set; }

	public bool AjaxPost { get; set; }

	public string Callback { get; set; }

	public DocumentCryptInfo()
	{
		PostAction = "EncryptLogOn";
		PostController = "Document";
		PostArea = "EleWise.ELMA.Documents.Web";
	}
}
