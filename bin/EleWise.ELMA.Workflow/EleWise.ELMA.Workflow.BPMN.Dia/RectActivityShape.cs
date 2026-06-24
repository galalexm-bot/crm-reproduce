using System;
using System.Drawing;
using EleWise.ELMA.Workflow.Diagrams.Shapes;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.Dom;
using Nevron.GraphicsCore;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes;

[Serializable]
public abstract class RectActivityShape : BPMNRectangleShape
{
	private static RectActivityShape gLskmQOILGKVwW3kCUU7;

	protected override Color StartColor => FBcDcsOIMMAoIsEhirFY();

	protected override Color EndColor => FBcDcsOIMMAoIsEhirFY();

	public RectActivityShape(Bitmap img, float scale, float width, float height)
	{
		//Discarded unreachable code: IL_0034, IL_0039
		aGLpu8OIW3v4UMKUKaZ9();
		this._002Ector(img, scale, width, height, 16f);
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public RectActivityShape(Bitmap img, float scale, float width, float height, float radius)
	{
		//Discarded unreachable code: IL_002a
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected O, but got Unknown
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 7;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 == 0)
		{
			num = 7;
		}
		NAbilities protection = default(NAbilities);
		RectanglePathWithImage rectanglePathWithImage = default(RectanglePathWithImage);
		while (true)
		{
			int num2;
			switch (num)
			{
			case 6:
				((NAbilities)(ref protection)).set_InplaceEdit(true);
				num2 = 2;
				goto IL_002f;
			case 7:
				rectanglePathWithImage = new RectanglePathWithImage(img, scale, 0f, 0f, width, height, radius);
				num = 4;
				break;
			case 8:
				AddPorts();
				num = 9;
				break;
			case 2:
				VxoQj4OIq9hoaT5bybrI(this, protection);
				num = 5;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a == 0)
				{
					num = 5;
				}
				break;
			default:
				xofTlpOICmD4jsR4mw8U(rPYpWcOI3sQTUk23a584(this), rD00B7OIpeIUcMHhOxei());
				num = 8;
				break;
			case 3:
				protection = ((NDiagramElement)this).get_Protection();
				num = 6;
				break;
			case 9:
				return;
			case 4:
				ll6hDCOIRsLOZeS87iKW(l6PxgKOIjItZ9laOAH3W(this), rectanglePathWithImage);
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
				{
					num = 1;
				}
				break;
			case 1:
				W7CbZSOI68uxxEx5ktyD(this);
				num2 = 3;
				goto IL_002f;
			case 5:
				{
					((NStyle)rPYpWcOI3sQTUk23a584(this)).set_FillStyle((NFillStyle)new NGradientFillStyle((GradientStyle)0, (GradientVariant)0, bLomu2OITa3eqqoG1mcm(this), KD9MrtOIQVjs0rW93QoN(this)));
					num = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 != 0)
					{
						num = 0;
					}
					break;
				}
				IL_002f:
				num = num2;
				break;
			}
		}
	}

	public RectActivityShape(Bitmap img, float scale)
	{
		//Discarded unreachable code: IL_0036, IL_003b
		aGLpu8OIW3v4UMKUKaZ9();
		this._002Ector(img, scale, 96f, 64f);
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected override void AddPorts()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				CNykgoOIkPm63g0dKptG(this, true);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void aGLpu8OIW3v4UMKUKaZ9()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool T714flOIf4RBimWQvpHo()
	{
		return gLskmQOILGKVwW3kCUU7 == null;
	}

	internal static RectActivityShape AGZ51bOI9HoaUoeJRxKI()
	{
		return gLskmQOILGKVwW3kCUU7;
	}

	internal static object l6PxgKOIjItZ9laOAH3W(object P_0)
	{
		return ((NCompositeShape)P_0).get_Primitives();
	}

	internal static void ll6hDCOIRsLOZeS87iKW(object P_0, object P_1)
	{
		((NDiagramElementCollection)P_0).AddChild((INNode)P_1);
	}

	internal static bool W7CbZSOI68uxxEx5ktyD(object P_0)
	{
		return ((NAggregateModel)P_0).UpdateModelBounds();
	}

	internal static void VxoQj4OIq9hoaT5bybrI(object P_0, NAbilities P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NDiagramElement)P_0).set_Protection(P_1);
	}

	internal static object rPYpWcOI3sQTUk23a584(object P_0)
	{
		return ((NStyleableElement)P_0).get_Style();
	}

	internal static Color bLomu2OITa3eqqoG1mcm(object P_0)
	{
		return ((BPMNRectangleShape)P_0).StartColor;
	}

	internal static Color KD9MrtOIQVjs0rW93QoN(object P_0)
	{
		return ((BPMNRectangleShape)P_0).EndColor;
	}

	internal static object rD00B7OIpeIUcMHhOxei()
	{
		return ShapeHelper.DefaultStrokeStyle;
	}

	internal static void xofTlpOICmD4jsR4mw8U(object P_0, object P_1)
	{
		((NStyle)P_0).set_StrokeStyle((NStrokeStyle)P_1);
	}

	internal static Color FBcDcsOIMMAoIsEhirFY()
	{
		return Color.White;
	}

	internal static void CNykgoOIkPm63g0dKptG(object P_0, bool addIntermediate)
	{
		ShapeHelper.AddPorts((NShape)P_0, addIntermediate);
	}
}
