using System;

namespace EleWise.ELMA.Diagrams;

[AttributeUsage(AttributeTargets.Class)]
public class ShapeAttribute : Attribute
{
	private Type shapeType;

	public Type ShapeType => shapeType;

	public ShapeAttribute(Type shapeType)
	{
		this.shapeType = shapeType;
	}
}
