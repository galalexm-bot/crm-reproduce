using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using Nevron.Diagram;
using Nevron.GraphicsCore;

namespace EleWise.ELMA.Diagrams;

public static class DiagramImageHelper
{
	private static Dictionary<Type, Dictionary<Size, Image>> generatedImages = new Dictionary<Type, Dictionary<Size, Image>>();

	public static Image GenerateImage<TShape>(int widthAndHeight) where TShape : NShape
	{
		return GenerateImage<TShape>(widthAndHeight, widthAndHeight);
	}

	public static Image GenerateImage<TShape>(int width, int height) where TShape : NShape
	{
		return GenerateImage<TShape>(new Size(width, height));
	}

	public static Image GenerateImage<TShape>(Size imageSize) where TShape : NShape
	{
		return GenerateImage(typeof(TShape), imageSize);
	}

	public static Image GenerateImage(Type shapeType, Size imageSize, Action<NShape> afterCreateShape = null, bool ignoreCache = false)
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		Contract.ArgumentNotNull(shapeType, "shapeType");
		Contract.CheckArgument(typeof(NShape).IsAssignableFrom(shapeType), "typeof(NShape).IsAssignableFrom(shapeType)");
		lock (generatedImages)
		{
			if (!generatedImages.TryGetValue(shapeType, out var value))
			{
				value = new Dictionary<Size, Image>();
				if (!ignoreCache)
				{
					generatedImages.Add(shapeType, value);
				}
			}
			Image value2;
			bool flag = value.TryGetValue(imageSize, out value2);
			if (ignoreCache || !flag)
			{
				NShape val = (NShape)Activator.CreateInstance(shapeType);
				afterCreateShape?.Invoke(val);
				Bitmap bitmap = new Bitmap(imageSize.Width, imageSize.Height);
				Graphics graphics = Graphics.FromImage(bitmap);
				graphics.SmoothingMode = SmoothingMode.HighQuality;
				N2DDeviceGDI val2 = new N2DDeviceGDI(graphics, NResolution.get_ScreenResolution());
				NPaintContext val3 = new NPaintContext((l1ll1l11I)val2);
				((l1I11ll1)val2).TranslateTransform(2f, 2f, MatrixOrder.Append);
				float num = (float)(imageSize.Width - 4) / ((NModel)val).get_Width();
				float num2 = (float)(imageSize.Height - 4) / ((NModel)val).get_Height();
				((l1I11ll1)val2).ScaleTransform(num, num2, MatrixOrder.Append);
				val3.StartWorldPaint();
				((NModel)val).Paint(val3);
				val3.EndWorldPaint();
				value2 = bitmap;
				value.Add(imageSize, value2);
			}
			return value2;
		}
	}
}
