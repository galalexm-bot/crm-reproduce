using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Common.ExtensionPoints;

public interface IObjectAttachmentSpecified
{
	bool IsAnyAttachmentsSpecified(IEntity entity);
}
