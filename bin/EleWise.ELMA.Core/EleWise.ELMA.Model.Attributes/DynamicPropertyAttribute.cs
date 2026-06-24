using System;

namespace EleWise.ELMA.Model.Attributes;

[AttributeUsage(/*Could not decode attribute arguments.*/)]
public class DynamicPropertyAttribute : System.Attribute
{
	private readonly bool _003CIsDynamicItem_003Ek__BackingField;

	public bool IsDynamicItem => _003CIsDynamicItem_003Ek__BackingField;

	public DynamicPropertyAttribute(bool isDynamicItem = false)
	{
		_003CIsDynamicItem_003Ek__BackingField = isDynamicItem;
	}
}
