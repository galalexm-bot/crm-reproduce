using System;

namespace EleWise.ELMA.Core.ComponentModel;

[AttributeUsage(/*Could not decode attribute arguments.*/)]
public class ExtensionPointAttribute : System.Attribute
{
	private readonly bool _003CCreateInstance_003Ek__BackingField;

	public bool CreateInstance => _003CCreateInstance_003Ek__BackingField;

	public ExtensionPointAttribute()
		: this(createInstance: true)
	{
	}

	public ExtensionPointAttribute(bool createInstance)
	{
		_003CCreateInstance_003Ek__BackingField = createInstance;
	}
}
