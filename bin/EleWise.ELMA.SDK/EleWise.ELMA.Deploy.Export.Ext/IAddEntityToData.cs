using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Deploy.Export.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IAddEntityToData
{
	List<IEntity> AddEntities(ClassMetadata metadata, IEntity entity);
}
