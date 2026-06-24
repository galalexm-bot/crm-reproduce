using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Model.Types.Helpers;

[ExtensionPoint(ServiceScope.Application, ComponentType.All)]
public interface IConvertTypeWrapper
{
	Type OriginalType { get; }

	Type ConvertType { get; }

	bool RelativeConvertNeeded(Type type);

	object ConvertWrapper(object obj);
}
