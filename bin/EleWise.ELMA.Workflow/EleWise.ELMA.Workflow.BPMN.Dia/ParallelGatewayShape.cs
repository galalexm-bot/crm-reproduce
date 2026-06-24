using System;
using System.Drawing;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.Dom;
using Nevron.GraphicsCore;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Gateways;

[Serializable]
public class ParallelGatewayShape : GatewayShape
{
	private static readonly Color typePathColor1;

	private static readonly Color typePathColor2;

	internal static ParallelGatewayShape hsXex0OxQ4urAU8hkNr1;

	protected virtual float Thickness => 6f;

	public ParallelGatewayShape()
	{
		//Discarded unreachable code: IL_001e
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected O, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected O, but got Unknown
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected O, but got Unknown
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 2;
		NPolygonPath val = default(NPolygonPath);
		float num6 = default(float);
		float num7 = default(float);
		float num5 = default(float);
		float num4 = default(float);
		float num3 = default(float);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					((NStyleableElement)val).set_Style(new NStyle());
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 == 0)
					{
						num2 = 11;
					}
					continue;
				default:
					num6 = t09xe3OxkXtVnMNJu4Tv(this) / 2f;
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b != 0)
					{
						num2 = 10;
					}
					continue;
				case 5:
					((NAggregateModel)this).UpdateModelBounds();
					num2 = 9;
					continue;
				case 4:
					Cuw991Ox7cfRcMuDR9V7(Kqwwx9OxGHRdaQ1iNu43(this), val);
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 != 0)
					{
						num2 = 5;
					}
					continue;
				case 7:
					num7 = DefaultHeight / 4f;
					num2 = 3;
					continue;
				case 8:
					QchH0yOxA6FdLNJ8CX6E(qG3xC8OxU4FalZ9lJDAT(val), (object)new NStrokeStyle(0f, uuM2TMOxVdV8HrmUgrXW()));
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 == 0)
					{
						num2 = 4;
					}
					continue;
				case 6:
					num5 = pjtlPgOxMfxi6kEodvXC(this) / 4f;
					num2 = 7;
					continue;
				case 3:
					val = new NPolygonPath((NPointF[])(object)new NPointF[12]
					{
						new NPointF(num4 - num5, num6 - num3),
						new NPointF(num4 - num3, num6 - num3),
						new NPointF(num4 - num3, num6 - num7),
						new NPointF(num4 + num3, num6 - num7),
						new NPointF(num4 + num3, num6 - num3),
						new NPointF(num4 + num5, num6 - num3),
						new NPointF(num4 + num5, num6 + num3),
						new NPointF(num4 + num3, num6 + num3),
						new NPointF(num4 + num3, num6 + num7),
						new NPointF(num4 - num3, num6 + num7),
						new NPointF(num4 - num3, num6 + num3),
						new NPointF(num4 - num5, num6 + num3)
					});
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 == 0)
					{
						num2 = 1;
					}
					continue;
				case 11:
					break;
				case 2:
					num4 = pjtlPgOxMfxi6kEodvXC(this) / 2f;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d == 0)
					{
						num2 = 0;
					}
					continue;
				case 10:
					num3 = Thickness / 2f;
					num2 = 6;
					continue;
				case 9:
					return;
				}
				break;
			}
			((NStyle)qG3xC8OxU4FalZ9lJDAT(val)).set_FillStyle((NFillStyle)new NGradientFillStyle((GradientStyle)0, (GradientVariant)0, typePathColor1, typePathColor2));
			num = 8;
		}
	}

	static ParallelGatewayShape()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				ttW6OWOx2rXQhlOGhljE();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				typePathColor1 = InT4hQOxo5XTCGnMU082(32, 173, 254);
				num2 = 3;
				break;
			case 3:
				typePathColor2 = InT4hQOxo5XTCGnMU082(32, 173, 254);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static float pjtlPgOxMfxi6kEodvXC(object P_0)
	{
		return ((GatewayShape)P_0).DefaultWidth;
	}

	internal static float t09xe3OxkXtVnMNJu4Tv(object P_0)
	{
		return ((GatewayShape)P_0).DefaultHeight;
	}

	internal static object qG3xC8OxU4FalZ9lJDAT(object P_0)
	{
		return ((NStyleableElement)P_0).get_Style();
	}

	internal static Color uuM2TMOxVdV8HrmUgrXW()
	{
		return Color.Transparent;
	}

	internal static void QchH0yOxA6FdLNJ8CX6E(object P_0, object P_1)
	{
		((NStyle)P_0).set_StrokeStyle((NStrokeStyle)P_1);
	}

	internal static object Kqwwx9OxGHRdaQ1iNu43(object P_0)
	{
		return ((NCompositeShape)P_0).get_Primitives();
	}

	internal static void Cuw991Ox7cfRcMuDR9V7(object P_0, object P_1)
	{
		((NDiagramElementCollection)P_0).AddChild((INNode)P_1);
	}

	internal static bool VCcgfdOxpX7ekWILbAsZ()
	{
		return hsXex0OxQ4urAU8hkNr1 == null;
	}

	internal static ParallelGatewayShape zHbsAyOxCR7pKxirjNfM()
	{
		return hsXex0OxQ4urAU8hkNr1;
	}

	internal static void ttW6OWOx2rXQhlOGhljE()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static Color InT4hQOxo5XTCGnMU082(int P_0, int P_1, int P_2)
	{
		return Color.FromArgb(P_0, P_1, P_2);
	}
}
