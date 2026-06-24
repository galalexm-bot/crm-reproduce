using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Tasks.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Security;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Tasks.Integration.Views;

[Component(EnableInterceptiors = false, InjectProerties = false, Order = 10)]
public class CopiedAttachmentsZone : IExtensionZone
{
	public const string ZONE_ID = "EleWise.ELMA.BPM.Web.Tasks.TaskComment-CopiedControls";

	private readonly ISecurityService securityService;

	public CopiedAttachmentsZone(ISecurityService securityService)
	{
		this.securityService = securityService;
	}

	public bool CanRenderInZone(string zoneId, HtmlHelper html)
	{
		return zoneId == "EleWise.ELMA.BPM.Web.Tasks.TaskComment-CopiedControls";
	}

	public void RenderZone(string zoneId, HtmlHelper html)
	{
		if (zoneId == "EleWise.ELMA.BPM.Web.Tasks.TaskComment-CopiedControls" && html.get_ViewData().get_Model() is TaskCommentModel taskCommentModel && taskCommentModel.Object.CastAsRealType() is ITask && (!(taskCommentModel.HtmlPrefix != "DoCompleted") || !(taskCommentModel.HtmlPrefix != "DoInCompleted")))
		{
			RenderPartialExtensions.RenderPartial(html, "Task/AttachmentsForCopiedPanel");
		}
	}
}
