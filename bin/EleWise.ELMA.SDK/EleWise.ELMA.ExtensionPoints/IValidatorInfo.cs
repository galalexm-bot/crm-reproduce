using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint(ComponentType.Web)]
public interface IValidatorInfo
{
	Type AttributeType { get; }

	Type ValidatorType { get; }
}
