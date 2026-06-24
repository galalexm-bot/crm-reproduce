using System.Collections.Generic;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class CommentAttachmentButtonModel
{
	public string HtmlPrefix { get; set; }

	public string ContainerId { get; set; }

	public bool MenuIsOpened { get; set; }

	public string ZoneId { get; set; }

	public IEnumerable<ICommentLoadedAttachment> CommentLoadedAttachmentPoints { get; set; }
}
