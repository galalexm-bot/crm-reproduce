using System.Web.Mvc;

namespace EleWise.ELMA.KPI.Common.Web;

public class KpiCommonAreaRegistration : AreaRegistration
{
	public const string AREA_NAME = "EleWise.ELMA.KPI.Common.Web";

	public override string AreaName => "EleWise.ELMA.KPI.Common.Web";

	public override void RegisterArea(AreaRegistrationContext context)
	{
		context.MapRoute("Kpi_default", "KPI_Common/{controller}/{action}/{id}", (object)new
		{
			controller = "Home",
			action = "Index",
			id = UrlParameter.Optional
		});
	}
}
