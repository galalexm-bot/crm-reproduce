using System;
using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Models;

public sealed class PageApplicationViewModel
{
	public Guid? ApplicationId { get; set; }

	public string JwtAuthToken { get; set; }

	public string RefreshToken { get; set; }

	public Guid PageUid { get; set; }

	public MvcHtmlString InputModelStr { get; set; }

	public string ContentUrl { get; set; }

	public string CssUrl { get; set; }

	public bool Single { get; set; }

	public bool CacheAppScripts => true;
}
