using System;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Serialization;

namespace EleWise.ELMA.Serialization;

[Component(Order = 2147483647)]
internal class DefaultDeserialization : IDeserialization
{
	public virtual bool Check(System.Type type)
	{
		return true;
	}

	public virtual object Deserialize(System.Type type, string json)
	{
		return SerializationHelper.DeserializeObjectFromJson(json, type);
	}
}
