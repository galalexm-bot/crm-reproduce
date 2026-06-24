using System;

namespace EleWise.ELMA.Diagrams;

[AttributeUsage(AttributeTargets.Class)]
public class HintShapeAttribute : Attribute
{
	private Type shapeType;

	public Type ShapeType => shapeType;

	public HintShapeAttribute(Type shapeType)
	{
		this.shapeType = shapeType;
	}
}
