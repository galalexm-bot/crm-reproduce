namespace EleWise.ELMA.Web.Content;

public class DialogContentAttribute : ContentItemAttribute
{
	public string Action { get; set; }

	public string Controller { get; set; }

	public string Area { get; set; }

	public string PopupId { get; set; }
}
