using System;
using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.Extensions;

namespace EleWise.ELMA.BPM.Web.Common.Extensions;

public static class AttachmentExtension
{
	public static MvcHtmlString AddAttachmentButton(this HtmlHelper html, CommentAttachmentButtonModel model)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_007d: Expected O, but got Unknown
		if (model.CommentLoadedAttachmentPoints == null)
		{
			model.CommentLoadedAttachmentPoints = (from p in ComponentManager.Current.GetExtensionPoints<ICommentLoadedAttachment>()
				where p.ZoneId == model.ZoneId
				select p).ToList();
		}
		CommentAttachmentButtonModel commentAttachmentButtonModel = model;
		ViewDataDictionary val = new ViewDataDictionary(html.get_ViewData());
		TemplateInfo val2 = new TemplateInfo();
		val2.set_HtmlFieldPrefix(model.HtmlPrefix);
		val.set_TemplateInfo(val2);
		return PartialExtensions.Partial(html, "Attachment/AttachmentButton", (object)commentAttachmentButtonModel, val);
	}

	public static MvcHtmlString AddAttachmentButtonDynamic(this HtmlHelper html, string key, string attachmentContainerId)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0052: Expected O, but got Unknown
		CommentAttachmentButtonModel commentAttachmentButtonModel = new CommentAttachmentButtonModel
		{
			HtmlPrefix = Guid.NewGuid().ToStringId(),
			ContainerId = attachmentContainerId,
			ZoneId = key
		};
		ViewDataDictionary val = new ViewDataDictionary(html.get_ViewData());
		TemplateInfo val2 = new TemplateInfo();
		val2.set_HtmlFieldPrefix(commentAttachmentButtonModel.HtmlPrefix);
		val.set_TemplateInfo(val2);
		return PartialExtensions.Partial(html, "Attachment/AttachmentButtonDynamic", (object)commentAttachmentButtonModel, val);
	}
}
