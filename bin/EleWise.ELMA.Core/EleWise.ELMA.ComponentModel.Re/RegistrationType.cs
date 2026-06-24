using Bridge;

namespace EleWise.ELMA.ComponentModel.Registration;

[Enum(/*Could not decode attribute arguments.*/)]
[ObjectLiteral]
internal enum RegistrationType
{
	Register,
	RegisterSingleInstance,
	RegisterInstance,
	RegisterAsEnumerableResolver,
	RegisterAsServiceContractResolver,
	RegisterTypes
}
