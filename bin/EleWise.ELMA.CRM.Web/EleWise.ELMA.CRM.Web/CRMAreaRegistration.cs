using System.Web.Mvc;

namespace EleWise.ELMA.CRM.Web;

public class CRMAreaRegistration : AreaRegistration
{
	public const string AREA_NAME = "EleWise.ELMA.CRM.Web";

	public override string AreaName => "EleWise.ELMA.CRM.Web";

	public override void RegisterArea(AreaRegistrationContext context)
	{
		context.MapRoute("CRM_default", "CRM/{controller}/{action}/{id}", (object)new
		{
			controller = "Contractor",
			action = "Index",
			id = UrlParameter.Optional
		});
	}
}
