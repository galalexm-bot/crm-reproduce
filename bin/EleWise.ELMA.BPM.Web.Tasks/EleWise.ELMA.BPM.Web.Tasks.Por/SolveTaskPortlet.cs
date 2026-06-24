using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Tasks;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.BPM.Web.Tasks.Portlets;

[Component]
public class SolveTaskPortlet : Portlet<SolveTaskPortletPersonalization>
{
	public static string UID_S = "{2D29E4E4-1E9E-4719-8596-EA6A8B43D16D}";

	public static Guid UID = new Guid(UID_S);

	private readonly PortletProfile _profile;

	public override Guid Uid => UID;

	public override string Name => SR.T("Решение задач");

	public override string Description => SR.T("Портлет для быстрой работы с задачами");

	public override IPortletProfile Profile => _profile;

	public SolveTaskPortlet()
	{
		_profile = (base.Profile as PortletProfile) ?? PortletProfile.Default;
		_profile.ImageUrl = "#task_complete.svg";
		_profile.Customizable = true;
	}

	protected override Permission PortletPermission()
	{
		return EleWise.ELMA.Tasks.PermissionProvider.SolveTasksAccessPermission;
	}

	public override MvcHtmlString Content(HtmlHelper html, SolveTaskPortletPersonalization data)
	{
		return RenderContentAction(html, "SolveTaskPortlet", "AllTasks", "EleWise.ELMA.BPM.Web.Tasks", data);
	}

	public override MvcHtmlString Settings(HtmlHelper html, SolveTaskPortletPersonalization data, string path)
	{
		data.InitCompleteTaskOptions();
		return RenderSettingsPartialView(html, "SolvePortlet/SolveSettings", data);
	}
}
