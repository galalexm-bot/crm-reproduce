using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Files;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.BPM.Web.Common.Components;

internal abstract class CommentLoadedFileAttachmentBase : ICommentLoadedAttachment
{
	public Guid AttachmentTypeUid => new Guid("692f9f96-dd18-4477-a632-e145c53291e5");

	public abstract string Prefix { get; }

	public abstract string Suffix { get; }

	public abstract string ZoneId { get; }

	public ICollection<LoadedAttachmentModel> GetLoadedAttachments(ICommentActionModel actionModel)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		List<LoadedAttachmentModel> list = new List<LoadedAttachmentModel>();
		if (actionModel.Attachments != null && actionModel.Attachments.Any())
		{
			foreach (IAttachment attachment in actionModel.Attachments)
			{
				BinaryFile file = attachment.File;
				if (file != null)
				{
					list.Add(new LoadedAttachmentModel
					{
						Name = new MvcHtmlString(HttpUtility.HtmlEncode(file.Name)),
						FullView = false,
						Href = "/SDK.Action/BinaryFiles/Download/" + file.Id,
						CreationAuthorId = attachment.CreationAuthor.Id,
						CreationAuthorShortName = attachment.CreationAuthor.GetShortName(),
						CreationDate = attachment.CreationDate,
						ContainerClassName = "loaded-files",
						Id = (file.Id ?? file.Uid.ToString()),
						Prefix = Prefix,
						Suffix = Suffix,
						TypeUid = AttachmentTypeUid,
						Icon = UIExtensions.BinaryFileActionButton(file.Id ?? file.Uid.ToString())
					});
				}
			}
			return list;
		}
		return list;
	}

	public ICollection<object> PrepareMenuItems(HtmlHelper html, CommentAttachmentButtonModel comment)
	{
		return new List<object>
		{
			new
			{
				id = "btnAddFileAttachment",
				caption = SR.T("Прикрепить файл"),
				visible = true,
				disabled = false,
				execute = $"$('#file_loader{comment.HtmlPrefix}').click()"
			}
		};
	}
}
