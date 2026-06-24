using System.Web.Mvc;

namespace EleWise.ELMA.CRM.Import.Web;

public class CrmImportAreaRegistration : AreaRegistration
{
	public const string AREA_NAME = "EleWise.ELMA.CRM.Import.Web";

	public override string AreaName => "EleWise.ELMA.CRM.Import.Web";

	public override void RegisterArea(AreaRegistrationContext context)
	{
		context.MapRoute("CrmImport_default", "CrmImport/{controller}/{action}/{id}", (object)new
		{
			controller = "Import",
			action = "Index",
			id = UrlParameter.Optional
		});
	}
}
