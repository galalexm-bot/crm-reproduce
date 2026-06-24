using System.Web.Mvc;
using EleWise.ELMA.Content.Models;

namespace EleWise.ELMA.BPM.Web.Content.Models;

public class MoveToFolderModel
{
	public IPortalObject Entity { get; set; }

	public string PopupId { get; set; }

	public bool Error { get; set; }

	public MvcHtmlString ErrorMessage { get; set; }

	public string PostAction { get; set; }

	public string PostController { get; set; }

	public string PostCallback { get; set; }
}
