using System;
using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.BPM.Web.Common.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
public interface ICommentLoadedAttachment
{
	string Prefix { get; }

	string Suffix { get; }

	string ZoneId { get; }

	Guid AttachmentTypeUid { get; }

	ICollection<LoadedAttachmentModel> GetLoadedAttachments(ICommentActionModel actionModel);

	ICollection<object> PrepareMenuItems(HtmlHelper html, CommentAttachmentButtonModel comment);
}
