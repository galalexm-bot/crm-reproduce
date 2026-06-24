using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Documents.Web.Components;

[Component(Order = 25)]
internal class CommentLoadedActionModelDocumentAttachment : CommentLoadedDocumentAttachmentBase
{
	public override string Prefix => "ActionModel.DocumentAttachments";

	public override string Suffix => "Document";

	public override string ZoneId => "ActionModel";
}
