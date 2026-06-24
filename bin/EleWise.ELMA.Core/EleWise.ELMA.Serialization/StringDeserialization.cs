using System;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Serialization;

[Component(Order = -2147483648)]
internal sealed class StringDeserialization : IDeserialization
{
	public bool Check(System.Type type)
	{
		return type == typeof(string);
	}

	public object Deserialize(System.Type type, string json)
	{
		return json.TrimStart(new char[1] { '"' }).TrimEnd(new char[1] { '"' });
	}
}
