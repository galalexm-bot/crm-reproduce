using System;
using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Models;

public class DownloadButtonModel
{
	public bool OnlyScripts { get; set; }

	public bool NeedHide { get; set; }

	public string Text { get; set; }

	[Obsolete("Свойство устарело. Используйте ImageUrl")]
	public MvcHtmlString Image { get; set; }

	public string ImageUrl { get; set; }

	public string Action { get; set; }

	public string Id { get; set; }

	public string TypeUid { get; set; }

	public long ItemId { get; set; }
}
