using System;
using System.Drawing;
using Aspose.Words;
using Aspose.Words.Drawing;
using EleWise.TemplateGenerator.Formats;

namespace EleWise.TemplateGenerator.Words.Internal;

internal class ShapeWrapper : CompositeNodeWrapper
{
	public ShapeWrapper(Image image, Document document, NodeWrapper parent, DrawingFormat format)
		: base((CompositeNode)(object)CreateShape(image, document, format), parent)
	{
	}

	public ShapeWrapper(Shape shape, NodeWrapper parent)
		: base((CompositeNode)(object)shape, parent)
	{
	}

	private static Shape CreateShape(Image image, Document document, DrawingFormat format)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		if (format == null)
		{
			format = new DrawingFormat();
		}
		Shape val = new Shape((DocumentBase)(object)document, (ShapeType)75);
		val.get_ImageData().SetImage(image);
		((ShapeBase)val).set_Width(val.get_ImageData().get_ImageSize().get_WidthPoints() * format.Scale / 100.0);
		((ShapeBase)val).set_Height(val.get_ImageData().get_ImageSize().get_HeightPoints() * format.Scale / 100.0);
		WrapType result = (WrapType)0;
		if (!string.IsNullOrEmpty(format.WrapType) && !Enum.TryParse<WrapType>(format.WrapType, out result))
		{
			result = (WrapType)0;
		}
		((ShapeBase)val).set_WrapType(result);
		return val;
	}
}
