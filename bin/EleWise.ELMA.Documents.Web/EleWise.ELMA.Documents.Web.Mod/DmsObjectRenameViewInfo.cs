namespace EleWise.ELMA.Documents.Web.Models;

public class DmsObjectRenameViewInfo
{
	public long DmsObjectId { get; set; }

	public string PopupId { get; set; }

	public string OldName { get; set; }

	public string NewName { get; set; }

	public string RedirectUrl { get; set; }

	public string Password { get; set; }

	public bool Encrypted { get; set; }
}
