using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.History.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IEntityActionEventMapping
{
	EntitySerializationSettings GetEntitySerializationSettings(Type entityType);
}
