using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.BPM.Web.Common.Components;

[Component(Order = 15)]
internal class CommentLoadedFeedFileAttachment : CommentLoadedFileAttachmentBase
{
	public override string Prefix => "messageAttachments";

	public override string Suffix => "";

	public override string ZoneId => "Feed";
}
