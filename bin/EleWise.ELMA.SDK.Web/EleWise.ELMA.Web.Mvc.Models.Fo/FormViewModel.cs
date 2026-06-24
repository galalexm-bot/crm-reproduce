namespace EleWise.ELMA.Web.Mvc.Models.Forms;

public class FormViewModel
{
	public string Id { get; set; }

	public string PostAction { get; set; }

	public string PostController { get; set; }

	public string PostArea { get; set; }

	public string RedirectUrl { get; set; }

	public string Callback { get; set; }

	public object HtmlAttributes { get; set; }

	public bool IsAjax { get; set; }
}
