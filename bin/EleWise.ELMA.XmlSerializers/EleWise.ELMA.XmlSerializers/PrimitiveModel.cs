using System;

namespace EleWise.ELMA.XmlSerializers;

internal class PrimitiveModel : TypeModel
{
	internal PrimitiveModel(Type type, TypeDesc typeDesc, ModelScope scope)
		: base(type, typeDesc, scope)
	{
	}
}
