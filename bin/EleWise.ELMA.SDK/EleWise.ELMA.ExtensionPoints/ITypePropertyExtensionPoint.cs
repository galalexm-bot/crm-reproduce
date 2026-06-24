using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface ITypePropertyExtensionPoint
{
	bool Can(Type type);

	object DefaultValue(Type type, Type idType, bool forIdentifier);

	bool IsDefaultId(Type type, Type idType, object idValue);

	long ConvertToNewId(Type type, Type idType, object idValue);

	object ConvertId(Type type, Type idType, object id);
}
