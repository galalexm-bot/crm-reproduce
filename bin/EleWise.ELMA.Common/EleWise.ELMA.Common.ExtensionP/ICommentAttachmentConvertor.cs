using System;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Common.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
public interface ICommentAttachmentConvertor
{
	Guid ObjectAttachmentTypeUid { get; }

	Guid AttachmentTypeUid { get; }

	bool Supported(Guid typeUid);

	void AddAttachmentToActionModel(ICommentActionModel actionModel, string id, Guid typeUid);

	void AddAttachmentToActionModel(ICommentActionModel actionModel, IEntity entity);

	IEntity ConvertToAttachment(string id, Guid typeUid);
}
