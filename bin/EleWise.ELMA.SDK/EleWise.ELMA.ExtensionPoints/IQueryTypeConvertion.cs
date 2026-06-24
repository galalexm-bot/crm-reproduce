using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IQueryTypeConvertion
{
	bool AvailableConvert(EntityMetadata metadata, string propName, Type valueType);

	object ConvertValue(EntityMetadata metadata, string propName, object value);
}
