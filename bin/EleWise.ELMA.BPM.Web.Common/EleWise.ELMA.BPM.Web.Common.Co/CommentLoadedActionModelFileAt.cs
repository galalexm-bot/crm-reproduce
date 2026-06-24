using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.BPM.Web.Common.Components;

[Component(Order = 10)]
internal class CommentLoadedActionModelFileAttachment : CommentLoadedFileAttachmentBase
{
	public override string Prefix => "ActionModel.Attachments";

	public override string Suffix => "File";

	public override string ZoneId => "ActionModel";
}
