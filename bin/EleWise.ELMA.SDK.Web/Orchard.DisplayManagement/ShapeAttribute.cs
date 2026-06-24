using System;

namespace Orchard.DisplayManagement;

public class ShapeAttribute : Attribute
{
	public string ShapeType { get; private set; }

	public ShapeAttribute()
	{
	}

	public ShapeAttribute(string shapeType)
	{
		ShapeType = shapeType;
	}
}
