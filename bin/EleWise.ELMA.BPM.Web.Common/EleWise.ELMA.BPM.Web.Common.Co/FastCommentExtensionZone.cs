using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Common.Models;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.BPM.Web.Common.Components;

[Component(Order = 100)]
public class FastCommentExtensionZone : IExtensionZone
{
	private const string ZoneId = "EleWise.ELMA.Security.FastComment";

	public bool CanRenderInZone(string zoneId, HtmlHelper html)
	{
		return "EleWise.ELMA.Security.FastComment" == zoneId;
	}

	public void RenderZone(string zoneId, HtmlHelper html)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_006c: Expected O, but got Unknown
		FastCommentSettingsModel fastCommentSettingsModel = ((html.get_ViewData().get_Model() is EditUserModel editUserModel && editUserModel.User != null) ? PersonalizationAdministration.LoadState<FastCommentSettingsModel>(editUserModel.User.UserName, "FastCommentSettingsModel") : null);
		if (fastCommentSettingsModel == null)
		{
			fastCommentSettingsModel = new FastCommentSettingsModel
			{
				PostCommentEnterKey = true
			};
		}
		FastCommentSettingsModel fastCommentSettingsModel2 = fastCommentSettingsModel;
		ViewDataDictionary val = new ViewDataDictionary();
		TemplateInfo val2 = new TemplateInfo();
		val2.set_HtmlFieldPrefix("Settings.Comment");
		val.set_TemplateInfo(val2);
		RenderPartialExtensions.RenderPartial(html, "Security/FastCommentSettingsEditor", (object)fastCommentSettingsModel2, val);
	}
}
