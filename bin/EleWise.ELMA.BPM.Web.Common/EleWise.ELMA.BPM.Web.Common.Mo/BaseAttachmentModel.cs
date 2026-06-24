using System;
using System.Web.Mvc;
using EleWise.ELMA.Web.Mvc.Models.ActionItems;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class BaseAttachmentModel
{
	public MvcHtmlString Name { get; set; }

	public bool FullView { get; set; }

	public string Href { get; set; }

	public string Action { get; set; }

	public long CreationAuthorId { get; set; }

	public string CreationAuthorShortName { get; set; }

	public DateTime? CreationDate { get; set; }

	public ActionButton Icon { get; set; }
}
