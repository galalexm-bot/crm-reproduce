using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.BPM.Web.Common.Extensions;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IAttachmentTemplateInputExtension
{
	string HtmlAttribute { get; }

	void AddAttachment(ICommentActionModel commentModel, long attachmentId);
}
