using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Artifacts;
using EleWise.ELMA.Workflow.Diagrams.Shapes;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.Dom;
using Nevron.GraphicsCore;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes;

[Serializable]
public class AnnotationElementShape : ArtifactTaskShape
{
	internal static AnnotationElementShape ppLSbcO2IfHsvIpOIlYh;

	protected virtual Color StartColor => Color.White;

	protected virtual Color EndColor => Color.White;

	protected virtual Color StrokeColor => lt5x25OoJKcZmEsoU7Fp(178, 184, 192);

	protected virtual float StrokeWidth => 0.5f;

	protected virtual int ColorAlpha => 255;

	protected virtual float DefaultWidth => 96f;

	protected virtual float DefaultHeight => 64f;

	public AnnotationElementShape()
	{
		//Discarded unreachable code: IL_001a
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected O, but got Unknown
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected O, but got Unknown
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected O, but got Unknown
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected O, but got Unknown
		bj3tMNO2e4Q22e1syk8l();
		base._002Ector();
		int num = 15;
		NCustomPath val2 = default(NCustomPath);
		NStyle val = default(NStyle);
		NStyle val3 = default(NStyle);
		NCustomPath val4 = default(NCustomPath);
		NAbilities val5 = default(NAbilities);
		while (true)
		{
			int num2;
			switch (num)
			{
			case 12:
				XEiNW9O2Eo9l3eYWhRVd(val2, val);
				num = 6;
				break;
			case 14:
				IhyPvnO21twYqveNvnkK(val3, (object)new NStrokeStyle(AE9tXRO2SOcL8QmYjyPi()));
				num = 18;
				break;
			case 3:
				AddPorts(0f, 0f, fgTAuDOo8i60ju8hsGGj(this));
				num = 17;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d != 0)
				{
					num = 5;
				}
				break;
			case 2:
				dIPbqnO24kQxuTw2jCyD(IqdEQkO2wY7MqWjZcBZ3(this), val4);
				num = 13;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a == 0)
				{
					num = 9;
				}
				break;
			case 13:
				val2 = new NCustomPath((GraphicsPath)oiVTlNO2zjrPyQ7tuoVP(0f, 0f, DefaultWidth, DefaultHeight), (PathType)1);
				num = 9;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 == 0)
				{
					num = 8;
				}
				break;
			case 16:
				return;
			case 8:
				uRH6vpOoYI4ymALn4oUy(this, val5);
				num = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d == 0)
				{
					num = 3;
				}
				break;
			case 4:
				val3 = new NStyle();
				num = 9;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b != 0)
				{
					num = 14;
				}
				break;
			case 15:
				val4 = new NCustomPath((GraphicsPath)HcqEp1O2x5Z9gTyvLv59(0f, 0f, DefaultWidth, b9ciX8O2NBg3FuJpMCf9(this)), (PathType)1);
				num2 = 4;
				goto IL_001f;
			case 7:
				Duq5iKOoZDtWniOgQkgt(this);
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 == 0)
				{
					num = 0;
				}
				break;
			default:
				val5 = TxZg3jOov0AGjVMG96bm(this);
				num = 11;
				break;
			case 11:
				((NAbilities)(ref val5)).set_InplaceEdit(true);
				num2 = 8;
				goto IL_001f;
			case 17:
				wkWucnOosOldbZxCCVy3(this, (ShapeElementsMask)8);
				num = 16;
				break;
			case 5:
				XEiNW9O2Eo9l3eYWhRVd(val4, val3);
				num = 2;
				break;
			case 9:
				val = new NStyle();
				num = 10;
				break;
			case 6:
				dIPbqnO24kQxuTw2jCyD(IqdEQkO2wY7MqWjZcBZ3(this), val2);
				num = 7;
				break;
			case 18:
				yPe2iqO2hu214CY8ynqg(val3, (object)new NColorFillStyle(AE9tXRO2SOcL8QmYjyPi()));
				num = 5;
				break;
			case 1:
				IhyPvnO21twYqveNvnkK(val, (object)new NStrokeStyle(Df3TCKOoKdV5rIFmqVGC(this), QOfSbPOoOKDGFmblmKKG(this)));
				num = 10;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 == 0)
				{
					num = 12;
				}
				break;
			case 10:
				{
					yPe2iqO2hu214CY8ynqg(val, (object)new NColorFillStyle(AE9tXRO2SOcL8QmYjyPi()));
					num = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a != 0)
					{
						num = 1;
					}
					break;
				}
				IL_001f:
				num = num2;
				break;
			}
		}
	}

	protected virtual void AddPorts(float x, float y, float w)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				us7CoOOoyDXX1K41WZVT(this, x - GVD0lSOol8gIilFarHYL(this) / 2f, y, Euw2UpOo0k10Ol3answL(0x42311138 ^ 0x42304B38));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private static GraphicsPath CreatePath(float x, float y, float w, float h)
	{
		int num = 2;
		int num2 = num;
		float num3 = default(float);
		float num4 = default(float);
		while (true)
		{
			switch (num2)
			{
			case 2:
				num3 = x + w / 3f;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				num4 = y + h;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 != 0)
				{
					num2 = 0;
				}
				break;
			default:
			{
				GraphicsPath graphicsPath = new GraphicsPath();
				graphicsPath.AddLine(num3, y, x, y);
				apVnuyOom7ncIabKKlLb(graphicsPath, x, num4, num3, num4);
				return graphicsPath;
			}
			}
		}
	}

	private static GraphicsPath CreatePathBase(float x, float y, float w, float h)
	{
		int num = 2;
		int num2 = num;
		float num4 = default(float);
		float num3 = default(float);
		while (true)
		{
			switch (num2)
			{
			case 1:
				num4 = y + h;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 != 0)
				{
					num2 = 0;
				}
				break;
			default:
			{
				GraphicsPath graphicsPath = new GraphicsPath();
				apVnuyOom7ncIabKKlLb(graphicsPath, num3, y, x, y);
				graphicsPath.AddLine(x, num4, num3, num4);
				YXd5SoOot44I5dSpAnMc(graphicsPath);
				return graphicsPath;
			}
			case 2:
				num3 = x + w;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void bj3tMNO2e4Q22e1syk8l()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static float b9ciX8O2NBg3FuJpMCf9(object P_0)
	{
		return ((AnnotationElementShape)P_0).DefaultHeight;
	}

	internal static object HcqEp1O2x5Z9gTyvLv59(float x, float y, float w, float h)
	{
		return CreatePathBase(x, y, w, h);
	}

	internal static Color AE9tXRO2SOcL8QmYjyPi()
	{
		return Color.Transparent;
	}

	internal static void IhyPvnO21twYqveNvnkK(object P_0, object P_1)
	{
		((NStyle)P_0).set_StrokeStyle((NStrokeStyle)P_1);
	}

	internal static void yPe2iqO2hu214CY8ynqg(object P_0, object P_1)
	{
		((NStyle)P_0).set_FillStyle((NFillStyle)P_1);
	}

	internal static void XEiNW9O2Eo9l3eYWhRVd(object P_0, object P_1)
	{
		((NStyleableElement)P_0).set_Style((NStyle)P_1);
	}

	internal static object IqdEQkO2wY7MqWjZcBZ3(object P_0)
	{
		return ((NCompositeShape)P_0).get_Primitives();
	}

	internal static void dIPbqnO24kQxuTw2jCyD(object P_0, object P_1)
	{
		((NDiagramElementCollection)P_0).AddChild((INNode)P_1);
	}

	internal static object oiVTlNO2zjrPyQ7tuoVP(float x, float y, float w, float h)
	{
		return CreatePath(x, y, w, h);
	}

	internal static float Df3TCKOoKdV5rIFmqVGC(object P_0)
	{
		return ((AnnotationElementShape)P_0).StrokeWidth;
	}

	internal static Color QOfSbPOoOKDGFmblmKKG(object P_0)
	{
		return ((AnnotationElementShape)P_0).StrokeColor;
	}

	internal static bool Duq5iKOoZDtWniOgQkgt(object P_0)
	{
		return ((NAggregateModel)P_0).UpdateModelBounds();
	}

	internal static NAbilities TxZg3jOov0AGjVMG96bm(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NDiagramElement)P_0).get_Protection();
	}

	internal static void uRH6vpOoYI4ymALn4oUy(object P_0, NAbilities P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NDiagramElement)P_0).set_Protection(P_1);
	}

	internal static float fgTAuDOo8i60ju8hsGGj(object P_0)
	{
		return ((AnnotationElementShape)P_0).DefaultWidth;
	}

	internal static bool wkWucnOosOldbZxCCVy3(object P_0, ShapeElementsMask P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NShape)P_0).CreateShapeElements(P_1);
	}

	internal static bool IuLRdyO2aagIb6IRB2JM()
	{
		return ppLSbcO2IfHsvIpOIlYh == null;
	}

	internal static AnnotationElementShape O4O8t3O2rTT17NmlGJSh()
	{
		return ppLSbcO2IfHsvIpOIlYh;
	}

	internal static Color lt5x25OoJKcZmEsoU7Fp(int P_0, int P_1, int P_2)
	{
		return Color.FromArgb(P_0, P_1, P_2);
	}

	internal static float GVD0lSOol8gIilFarHYL(object P_0)
	{
		return ((NModel)P_0).get_Width();
	}

	internal static object Euw2UpOo0k10Ol3answL(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void us7CoOOoyDXX1K41WZVT(object P_0, float percX, float percY, object P_3)
	{
		ShapeHelper.AddPort((NShape)P_0, percX, percY, (string)P_3);
	}

	internal static void apVnuyOom7ncIabKKlLb(object P_0, float P_1, float P_2, float P_3, float P_4)
	{
		((GraphicsPath)P_0).AddLine(P_1, P_2, P_3, P_4);
	}

	internal static void YXd5SoOot44I5dSpAnMc(object P_0)
	{
		((GraphicsPath)P_0).CloseAllFigures();
	}
}
