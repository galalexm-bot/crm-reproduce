using System;
using System.Drawing;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.Dom;
using Nevron.GraphicsCore;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Gateways;

[Serializable]
public class InclusiveGatewayShape : GatewayShape
{
	private static readonly Color typePathColor1;

	private static readonly Color typePathColor2;

	private static readonly Color typeBGColor1;

	private static readonly Color typeBGColor2;

	private static InclusiveGatewayShape KHWy4dOxglb0pDb62lSe;

	protected virtual float Thickness => 6f;

	public InclusiveGatewayShape()
	{
		//Discarded unreachable code: IL_002a
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected O, but got Unknown
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected O, but got Unknown
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected O, but got Unknown
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 3;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 != 0)
		{
			num = 3;
		}
		NEllipsePath val = default(NEllipsePath);
		NEllipsePath val2 = default(NEllipsePath);
		while (true)
		{
			switch (num)
			{
			case 9:
				val = new NEllipsePath(PkdsJnOxPXDabsCPiMrW(this) / 4f + c3nu0oOxf0BVxBhqv2Py(this), DefaultHeight / 4f + c3nu0oOxf0BVxBhqv2Py(this), PkdsJnOxPXDabsCPiMrW(this) / 2f - c3nu0oOxf0BVxBhqv2Py(this) * 2f, QnbFg8OxXxTX0OVbeq1Y(this) / 2f - c3nu0oOxf0BVxBhqv2Py(this) * 2f);
				num = 5;
				break;
			case 6:
			{
				W8MJJ8OxHf6gJaA0SGAC(PcKWBOOxD4L7Hp6kSMat(val2), (object)new NStrokeStyle(0f, QWaKbIOxnMbr86fb3yJG()));
				int num2 = 8;
				num = num2;
				break;
			}
			case 11:
				CWbhnlOxWNGo0D92QT2R(this);
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 == 0)
				{
					num = 2;
				}
				break;
			default:
				b0oGuLOxuqIwRtcY5nu0(((NStyleableElement)val2).get_Style(), (object)new NGradientFillStyle((GradientStyle)0, (GradientVariant)0, typePathColor1, typePathColor2));
				num = 6;
				break;
			case 5:
				NuxX7dOxdBlBq5PeOwwU(val, (object)new NStyle());
				num = 7;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 != 0)
				{
					num = 1;
				}
				break;
			case 7:
				((NStyle)PcKWBOOxD4L7Hp6kSMat(val)).set_FillStyle((NFillStyle)new NGradientFillStyle((GradientStyle)0, (GradientVariant)0, typeBGColor1, typeBGColor2));
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 != 0)
				{
					num = 1;
				}
				break;
			case 2:
				return;
			case 4:
				LALrsSOx9Fclg8G9fSSN(pGh5TWOxLjdFwbKHqSEu(this), val);
				num = 11;
				break;
			case 8:
				((NDiagramElementCollection)pGh5TWOxLjdFwbKHqSEu(this)).AddChild((INNode)(object)val2);
				num = 9;
				break;
			case 3:
				val2 = new NEllipsePath(PkdsJnOxPXDabsCPiMrW(this) / 4f, DefaultHeight / 4f, PkdsJnOxPXDabsCPiMrW(this) / 2f, QnbFg8OxXxTX0OVbeq1Y(this) / 2f);
				num = 10;
				break;
			case 10:
				NuxX7dOxdBlBq5PeOwwU(val2, (object)new NStyle());
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c != 0)
				{
					num = 0;
				}
				break;
			case 1:
				W8MJJ8OxHf6gJaA0SGAC(PcKWBOOxD4L7Hp6kSMat(val), (object)new NStrokeStyle(0f, QWaKbIOxnMbr86fb3yJG()));
				num = 4;
				break;
			}
		}
	}

	static InclusiveGatewayShape()
	{
		int num = 4;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					typePathColor1 = CUwayoOxRrtFbhehawuZ(32, 173, 254);
					num2 = 2;
					continue;
				case 2:
					typePathColor2 = CUwayoOxRrtFbhehawuZ(32, 173, 254);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd != 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					break;
				default:
					typeBGColor2 = CUwayoOxRrtFbhehawuZ(244, 244, 244);
					num2 = 5;
					continue;
				case 1:
					typeBGColor1 = CUwayoOxRrtFbhehawuZ(244, 244, 244);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					return;
				}
				break;
			}
			M2xkK3OxjxUjyXMyfZBC();
			num = 3;
		}
	}

	internal static float PkdsJnOxPXDabsCPiMrW(object P_0)
	{
		return ((GatewayShape)P_0).DefaultWidth;
	}

	internal static float QnbFg8OxXxTX0OVbeq1Y(object P_0)
	{
		return ((GatewayShape)P_0).DefaultHeight;
	}

	internal static void NuxX7dOxdBlBq5PeOwwU(object P_0, object P_1)
	{
		((NStyleableElement)P_0).set_Style((NStyle)P_1);
	}

	internal static void b0oGuLOxuqIwRtcY5nu0(object P_0, object P_1)
	{
		((NStyle)P_0).set_FillStyle((NFillStyle)P_1);
	}

	internal static object PcKWBOOxD4L7Hp6kSMat(object P_0)
	{
		return ((NStyleableElement)P_0).get_Style();
	}

	internal static Color QWaKbIOxnMbr86fb3yJG()
	{
		return Color.Transparent;
	}

	internal static void W8MJJ8OxHf6gJaA0SGAC(object P_0, object P_1)
	{
		((NStyle)P_0).set_StrokeStyle((NStrokeStyle)P_1);
	}

	internal static object pGh5TWOxLjdFwbKHqSEu(object P_0)
	{
		return ((NCompositeShape)P_0).get_Primitives();
	}

	internal static float c3nu0oOxf0BVxBhqv2Py(object P_0)
	{
		return ((InclusiveGatewayShape)P_0).Thickness;
	}

	internal static void LALrsSOx9Fclg8G9fSSN(object P_0, object P_1)
	{
		((NDiagramElementCollection)P_0).AddChild((INNode)P_1);
	}

	internal static bool CWbhnlOxWNGo0D92QT2R(object P_0)
	{
		return ((NAggregateModel)P_0).UpdateModelBounds();
	}

	internal static bool dukjVxOxBUtlSgH6wLix()
	{
		return KHWy4dOxglb0pDb62lSe == null;
	}

	internal static InclusiveGatewayShape Tk08ZFOxcYhDt81c1vDG()
	{
		return KHWy4dOxglb0pDb62lSe;
	}

	internal static void M2xkK3OxjxUjyXMyfZBC()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static Color CUwayoOxRrtFbhehawuZ(int P_0, int P_1, int P_2)
	{
		return Color.FromArgb(P_0, P_1, P_2);
	}
}
