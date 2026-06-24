namespace EleWise.ELMA.KPI.Common.Web.Models;

public class SavePopupProperties
{
	public object RouteValues { get; set; }

	public string Controller { get; set; }

	public string Action { get; set; }

	public string JavascriptCallback { get; set; }

	public SavePopupProperties()
	{
	}

	public SavePopupProperties(object routeValues, string controller, string action, string callback = "")
	{
		RouteValues = routeValues;
		Controller = controller;
		Action = action;
		JavascriptCallback = callback;
	}
}
