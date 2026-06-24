using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Publication;

namespace EleWise.ELMA.ExtensionPoints.Publication;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IPublishGroupHandler
{
	PublishDataResult Publish(ReferenceOnEntity[] data, string comment);
}
