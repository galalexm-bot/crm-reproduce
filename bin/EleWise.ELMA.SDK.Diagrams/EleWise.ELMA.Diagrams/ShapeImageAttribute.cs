using System;
using System.Drawing;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Diagrams;

[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class ShapeImageAttribute : Attribute, IImageAttribute
{
	private Type shapeType;

	private int size = 16;

	private bool isDefault;

	public Type ShapeType => shapeType;

	public int Size
	{
		get
		{
			return size;
		}
		set
		{
			size = value;
		}
	}

	public bool IsDefault
	{
		get
		{
			return isDefault;
		}
		set
		{
			isDefault = value;
		}
	}

	public string Format { get; set; }

	public ShapeImageAttribute(Type shapeType, int size)
	{
		this.shapeType = shapeType;
		this.size = size;
	}

	public Image CreateImage()
	{
		return DiagramImageHelper.GenerateImage(shapeType, new Size(size, size));
	}
}
