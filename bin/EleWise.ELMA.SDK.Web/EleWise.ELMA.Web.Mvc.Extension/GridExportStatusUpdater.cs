using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Util;

namespace EleWise.ELMA.Web.Mvc.Extensions;

[Component]
public class GridExportStatusUpdater : IPingDataExtension
{
	public string ClientFunction => "$.telerik.grid.exportExcelUpdateStatus";

	public string GetData()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		UrlHelper ulrHelper = new UrlHelper(HttpContextAccessor.CurrentContext.Request.RequestContext);
		return Json.Encode((object)(from s in GridExportExcelUtility.GetExportExcelStatuses(HttpContext.Current.Session.SessionID, AuthenticationService.GetCurrentUser().GetId())
			where s.Ready
			select s).Select(delegate(GridExportExcelUtility.ExportExcelStatus s)
		{
			string fileHref = ulrHelper.Action("Download", "BinaryFiles", (object)new
			{
				area = "EleWise.ELMA.SDK.Web",
				id = s.FileGuid
			});
			return new
			{
				GridId = s.GridId,
				fileHref = fileHref,
				ready = true,
				error = s.Error
			};
		}).ToList());
	}
}
