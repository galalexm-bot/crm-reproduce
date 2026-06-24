using System;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Serialization;
using EleWise.ELMA.Extensions;

namespace EleWise.ELMA.Serialization;

[Component(Order = -2147483645)]
internal sealed class SimpleTypesDeserialization : DefaultDeserialization
{
	public override bool Check(System.Type type)
	{
		if (!type.IsSimpleType())
		{
			if (type.IsNullableType())
			{
				return type.GetGenericArguments()[0].IsSimpleType();
			}
			return false;
		}
		return true;
	}

	public override object Deserialize(System.Type type, string json)
	{
		if (!json.StartsWith("\""))
		{
			return base.Deserialize(type, json);
		}
		string json2 = json.Trim(new char[1] { '"' });
		return SerializationHelper.TryDeserializeSimpleType(type, json2);
	}
}
