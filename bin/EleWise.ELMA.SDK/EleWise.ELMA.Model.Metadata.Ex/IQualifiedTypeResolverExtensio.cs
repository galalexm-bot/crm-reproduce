using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Model.Metadata.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IQualifiedTypeResolverExtension
{
	Guid Uid { get; }

	bool CheckType(Type type);

	IEnumerable<byte> GetQualifiedTypeData(Type type);

	Type GetType(IEnumerable<byte> data);
}
