using EleWise.ELMA.Common.Models;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class CommentAttachmentLoader
{
	public string AttachmentContainerId { get; set; }

	public string ZoneId { get; set; }

	public ICommentActionModel ActionModel { get; set; }
}
