using System;
using Bridge;
using Bridge.Html5;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Serialization;

[Component(Order = -2147483647)]
internal sealed class ObjectDeserialization : IDeserialization
{
	public bool Check(System.Type type)
	{
		if (type != typeof(object))
		{
			return type == typeof(object[]);
		}
		return true;
	}

	public object Deserialize(System.Type type, string json)
	{
		return Parse(json);
	}

	internal static object Parse(string value)
	{
		try
		{
			return JSON.Parse(value);
		}
		catch (System.Exception)
		{
			try
			{
				return Script.Eval<object>(value);
			}
			catch (System.Exception)
			{
				throw;
			}
		}
	}
}
