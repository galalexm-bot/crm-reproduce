using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.GraphicsCore;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Decorators;

[Serializable]
public class ArtifactDataObjectDecorator : BaseDecorator
{
	private static ArtifactDataObjectDecorator UqdCNTOEJrPG0pH37oim;

	protected static Color StrokeColor => TFoWBOOEDK47P8hh9vrc(178, 184, 192);

	protected static float StrokeWidth => 0.3f;

	protected virtual Color StartColor => PsHeoxOEnFUWbsOIkoiE(255, 245, 245, 245);

	public ArtifactDataObjectDecorator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Y6ukfNOEyp4OvB177nWd();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				Height = 120f;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca == 0)
				{
					num = 1;
				}
				break;
			default:
				qq6hZuOEmJvu9fmPUFtM(this, 90f);
				num = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 == 0)
				{
					num = 2;
				}
				break;
			case 1:
				return;
			}
		}
	}

	protected override void CreatePaths(NRectangleF bounds)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected O, but got Unknown
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected O, but got Unknown
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected O, but got Unknown
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected O, but got Unknown
		int num = 11;
		NStyle val2 = default(NStyle);
		NCustomPath val3 = default(NCustomPath);
		NStyle val = default(NStyle);
		NCustomPath val4 = default(NCustomPath);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					w565oxOEc2FKYfPbw3pG(val2, (object)new NStrokeStyle(StrokeWidth, StrokeColor));
					num2 = 3;
					continue;
				case 12:
					DSxdTJOEPihW4Ui5CZw2(val3, val);
					num2 = 9;
					continue;
				case 8:
					AddPath((NPathPrimitive)(object)val4);
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 != 0)
					{
						num2 = 2;
					}
					continue;
				case 4:
					rY3nSoOE5UqcBFN6J6nf(val, (object)new NGradientFillStyle((GradientStyle)0, (GradientVariant)0, nGmL2AOEbHxZe2qdk4Z0(this), nGmL2AOEbHxZe2qdk4Z0(this)));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					w565oxOEc2FKYfPbw3pG(val, (object)new NStrokeStyle(TscYoHOEgvo0KKk05WA6(), jVskb2OEB4JlSrKn5edN()));
					num2 = 12;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e == 0)
					{
						num2 = 4;
					}
					continue;
				case 9:
					AddPath((NPathPrimitive)(object)val3);
					num2 = 7;
					continue;
				case 11:
					val3 = new NCustomPath((GraphicsPath)b2Bj4aOEtcThNRFQxJ6G(bounds.X, bounds.Y, bounds.Width, bounds.Height), (PathType)1);
					num2 = 10;
					continue;
				case 6:
					val2 = new NStyle();
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae == 0)
					{
						num2 = 5;
					}
					continue;
				case 3:
					DSxdTJOEPihW4Ui5CZw2(val4, val2);
					num2 = 8;
					continue;
				case 7:
					break;
				case 5:
					val2.set_FillStyle((NFillStyle)new NGradientFillStyle((GradientStyle)0, (GradientVariant)0, nGmL2AOEbHxZe2qdk4Z0(this), nGmL2AOEbHxZe2qdk4Z0(this)));
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d != 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
					return;
				case 10:
					val = new NStyle();
					num2 = 4;
					continue;
				}
				break;
			}
			val4 = new NCustomPath((GraphicsPath)RNKMBVOEXBYf7Ndi4UcH(bounds.X, bounds.Y, bounds.Width, bounds.Height), (PathType)1);
			num = 6;
		}
	}

	private static GraphicsPath CreatePath(float x, float y, float w, float h)
	{
		int num = 1;
		int num2 = num;
		float num5 = default(float);
		float num3 = default(float);
		float num4 = default(float);
		while (true)
		{
			switch (num2)
			{
			case 3:
				num5 = y + h / 3f;
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
			{
				GraphicsPath graphicsPath = new GraphicsPath();
				graphicsPath.AddLine(num3 - num4, y, x, y);
				Syl7alOEdgBDD6G55uoL(graphicsPath, x, num5, num3, num5);
				Syl7alOEdgBDD6G55uoL(graphicsPath, num3, y + num4, num3 - num4, y);
				rJPLXiOEuDjsKr65XRvO(graphicsPath);
				return graphicsPath;
			}
			case 1:
				num4 = 7f;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				num3 = x + w / 3f;
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private static GraphicsPath CreatePathZak(float x, float y, float w, float h)
	{
		int num = 3;
		int num2 = num;
		float num4 = default(float);
		float num3 = default(float);
		while (true)
		{
			switch (num2)
			{
			case 3:
				num4 = 7f;
				num2 = 2;
				break;
			case 2:
				num3 = x + w / 3f;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e == 0)
				{
					num2 = 0;
				}
				break;
			default:
				_ = h / 3f;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
			{
				GraphicsPath graphicsPath = new GraphicsPath();
				Syl7alOEdgBDD6G55uoL(graphicsPath, num3 - num4, y, num3 - num4, y + num4);
				graphicsPath.AddLine(num3 - num4, y + num4, num3, y + num4);
				return graphicsPath;
			}
			}
		}
	}

	internal static void Y6ukfNOEyp4OvB177nWd()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static void qq6hZuOEmJvu9fmPUFtM(object P_0, float value)
	{
		((BaseDecorator)P_0).Width = value;
	}

	internal static bool eHR2yyOEl9hr8cO7cBZl()
	{
		return UqdCNTOEJrPG0pH37oim == null;
	}

	internal static ArtifactDataObjectDecorator NIE38XOE0AgKmY69eSxS()
	{
		return UqdCNTOEJrPG0pH37oim;
	}

	internal static object b2Bj4aOEtcThNRFQxJ6G(float x, float y, float w, float h)
	{
		return CreatePath(x, y, w, h);
	}

	internal static Color nGmL2AOEbHxZe2qdk4Z0(object P_0)
	{
		return ((ArtifactDataObjectDecorator)P_0).StartColor;
	}

	internal static void rY3nSoOE5UqcBFN6J6nf(object P_0, object P_1)
	{
		((NStyle)P_0).set_FillStyle((NFillStyle)P_1);
	}

	internal static float TscYoHOEgvo0KKk05WA6()
	{
		return StrokeWidth;
	}

	internal static Color jVskb2OEB4JlSrKn5edN()
	{
		return StrokeColor;
	}

	internal static void w565oxOEc2FKYfPbw3pG(object P_0, object P_1)
	{
		((NStyle)P_0).set_StrokeStyle((NStrokeStyle)P_1);
	}

	internal static void DSxdTJOEPihW4Ui5CZw2(object P_0, object P_1)
	{
		((NStyleableElement)P_0).set_Style((NStyle)P_1);
	}

	internal static object RNKMBVOEXBYf7Ndi4UcH(float x, float y, float w, float h)
	{
		return CreatePathZak(x, y, w, h);
	}

	internal static void Syl7alOEdgBDD6G55uoL(object P_0, float P_1, float P_2, float P_3, float P_4)
	{
		((GraphicsPath)P_0).AddLine(P_1, P_2, P_3, P_4);
	}

	internal static void rJPLXiOEuDjsKr65XRvO(object P_0)
	{
		((GraphicsPath)P_0).CloseAllFigures();
	}

	internal static Color TFoWBOOEDK47P8hh9vrc(int P_0, int P_1, int P_2)
	{
		return Color.FromArgb(P_0, P_1, P_2);
	}

	internal static Color PsHeoxOEnFUWbsOIkoiE(int P_0, int P_1, int P_2, int P_3)
	{
		return Color.FromArgb(P_0, P_1, P_2, P_3);
	}
}
