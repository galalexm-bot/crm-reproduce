using System;
using System.ComponentModel;
using Bridge;

namespace EleWise.ELMA.Serialization;

[ObjectLiteral]
[EditorBrowsable(/*Could not decode attribute arguments.*/)]
[Obsolete("Не использовать")]
public sealed class UnknownObjectWrapper
{
	private object _003CValue_003Ek__BackingField;

	[Name("v")]
	public object Value
	{
		get
		{
			return _003CValue_003Ek__BackingField;
		}
		set
		{
			_003CValue_003Ek__BackingField = value;
		}
	}
}
