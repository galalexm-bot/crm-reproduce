using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace EleWise.ELMA.Web.Mvc.Models.Forms;

public class EntityFormInfo
{
	public string PostAction { get; set; }

	public string PostController { get; set; }

	public string Action { get; set; }

	public string Controller { get; set; }

	public string ParameterName { get; set; }

	public RouteValueDictionary PostRoute { get; set; }

	public RouteValueDictionary Route { get; set; }

	public string PopupId { get; set; }

	public string CreatorPrefix { get; set; }

	public string EntityId { get; set; }

	public bool ReadOnly { get; set; }

	public Func<HtmlHelper, string, string> OnSubmitScript { get; set; }

	public bool IsLocal { get; set; }

	public Guid TypeUid { get; set; }

	public string FormId { get; set; }

	public string ParentFormId { get; set; }
}
