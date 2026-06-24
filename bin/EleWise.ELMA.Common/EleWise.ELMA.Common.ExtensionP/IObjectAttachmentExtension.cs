using System;
using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Common.ExtensionPoints;

[ExtensionPoint(ServiceScope.Application, ComponentType.All)]
public interface IObjectAttachmentExtension
{
	bool EntityType(Guid TypeUid);

	bool IsAnyAttachments(IEntity entity);

	void Copy(IEntity fromEntity, IEntity toEntity);

	IEnumerable<AttachmentFileModel> GetAttachments(IEntity entity);
}
