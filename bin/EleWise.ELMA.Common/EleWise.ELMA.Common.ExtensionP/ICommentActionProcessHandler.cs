using EleWise.ELMA.Common.Models;

namespace EleWise.ELMA.Common.ExtensionPoints;

public interface ICommentActionProcessHandler
{
	void Process(object target, ICommentActionModel commentModel, bool addAttachmentToTarget);
}
