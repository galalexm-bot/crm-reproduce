namespace EleWise.ELMA.Web.Mvc.Models;

public class DynamicContent
{
	public string ContainerId { get; set; }

	public string PartialViewName { get; set; }

	public object Model { get; set; }
}
