using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Web.Extensions;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.Documents.Web.Components;

[Component(Order = 20)]
internal class CommentLoadedDocumentAttachment : CommentLoadedDocumentAttachmentBase
{
	public override string Prefix => "messageAttachments";

	public override string Suffix => "";

	public override string ZoneId => "Feed";
}
internal abstract class CommentLoadedDocumentAttachmentBase : ICommentLoadedAttachment
{
	public Guid AttachmentTypeUid => InterfaceActivator.UID<IDocument>();

	public abstract string Prefix { get; }

	public abstract string Suffix { get; }

	public abstract string ZoneId { get; }

	public ICollection<LoadedAttachmentModel> GetLoadedAttachments(ICommentActionModel actionModel)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		ICommentWithDocumentsActionModel obj = actionModel as ICommentWithDocumentsActionModel;
		List<LoadedAttachmentModel> list = new List<LoadedAttachmentModel>();
		foreach (IDocumentAttachment documentAttachment in obj.DocumentAttachments)
		{
			IDocument document = documentAttachment.Document;
			if (document != null)
			{
				list.Add(new LoadedAttachmentModel
				{
					Name = new MvcHtmlString(HttpUtility.HtmlEncode(document.Name)),
					FullView = false,
					Href = "/Documents/Document/View/" + document.Id,
					CreationAuthorId = document.CreationAuthor.Id,
					CreationAuthorShortName = document.CreationAuthor.GetShortName(),
					CreationDate = document.CreationDate,
					ContainerClassName = "loaded-document-attachments",
					Id = document.Id,
					Prefix = Prefix,
					Suffix = Suffix,
					TypeUid = AttachmentTypeUid,
					Icon = DocumentExtension.DocumentActionButton(document, $"/SDK.Action/Images/Object/{document.TypeUid}?useParent=True")
				});
			}
		}
		return list;
	}

	public ICollection<object> PrepareMenuItems(HtmlHelper html, CommentAttachmentButtonModel model)
	{
		return new List<object>
		{
			new
			{
				id = "btnAddDocumentAttachment",
				caption = SR.T("Прикрепить документ"),
				visible = true,
				disabled = false,
				execute = string.Format("refreshPopup('AttachmentLoader_{0}', '{1}');", model.HtmlPrefix, html.Url().Action("OpenAttachmentLoaderPopup", "Document", (object)new
				{
					area = "EleWise.ELMA.Documents.Web",
					typeUid = AttachmentTypeUid,
					attachmentContainerId = model.ContainerId,
					zoneId = model.ZoneId
				}))
			}
		};
	}
}
