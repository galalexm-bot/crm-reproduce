using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Common.ExtensionPoints;

[ExtensionPoint(ServiceScope.Application, ComponentType.All)]
public interface IObjectAttachmentWithPropertyExtension : IObjectAttachmentExtension
{
	IEnumerable<AttachmentFileModel> GetAttachments(IEntity entity, string propertyUid);
}
