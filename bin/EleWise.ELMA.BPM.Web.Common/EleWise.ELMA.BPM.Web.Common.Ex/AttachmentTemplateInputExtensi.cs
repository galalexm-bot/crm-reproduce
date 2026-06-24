using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.BPM.Web.Common.Extensions;

[Component]
public class AttachmentTemplateInputExtension : IAttachmentTemplateInputExtension
{
	public static string HtmlAttributeString = "attachmentId";

	public string HtmlAttribute => HtmlAttributeString;

	public void AddAttachment(ICommentActionModel commentModel, long attachmentId)
	{
		IAttachment attachment = AttachmentManager.Instance.LoadOrNull(attachmentId);
		if (attachment != null)
		{
			if (commentModel.Attachments == null)
			{
				commentModel.Attachments = new List<IAttachment>();
			}
			if (commentModel.Attachments.All((IAttachment a) => a.Id != attachmentId))
			{
				commentModel.Attachments.Add(attachment);
			}
		}
	}
}
