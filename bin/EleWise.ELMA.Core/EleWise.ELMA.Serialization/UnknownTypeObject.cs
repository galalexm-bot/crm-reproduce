using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Bridge;
using EleWise.ELMA.Extensions;

namespace EleWise.ELMA.Serialization;

[Rules(/*Could not decode attribute arguments.*/)]
[Obsolete("Не использовать")]
[EditorBrowsable(/*Could not decode attribute arguments.*/)]
internal class UnknownTypeObject : IUnknownSerializableType
{
	private object serializedValue;

	private string typeName;

	public string GetTypeName()
	{
		return typeName;
	}

	[OnSerialized]
	public void OnSerializedMethod(UnknownObjectWrapper raw)
	{
		raw.Value = serializedValue;
		raw.Value.SetAndCreatePlainPropertyValue("$type", typeName);
	}

	[OnDeserialized]
	public void OnDeserializedMethod(object raw)
	{
		typeName = raw.GetPlainPropertyValue<string>("$type");
		serializedValue = raw;
	}
}
