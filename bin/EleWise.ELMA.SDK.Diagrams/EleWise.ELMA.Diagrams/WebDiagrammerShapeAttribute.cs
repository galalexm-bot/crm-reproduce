using System;

namespace EleWise.ELMA.Diagrams;

[AttributeUsage(AttributeTargets.Class)]
public sealed class WebDiagrammerShapeAttribute : Attribute
{
	public Type ShapeType { get; }

	public WebDiagrammerShapeAttribute(Type shapeType)
	{
		ShapeType = shapeType;
	}
}
