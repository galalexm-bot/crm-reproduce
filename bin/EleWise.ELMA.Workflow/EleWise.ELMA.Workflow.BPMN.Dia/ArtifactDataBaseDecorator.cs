using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.GraphicsCore;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Decorators;

[Serializable]
public class ArtifactDataBaseDecorator : BaseDecorator
{
	internal static ArtifactDataBaseDecorator hQ5wTGOhaeOhivZHuTRd;

	protected static Color StrokeColor => Color.FromArgb(178, 184, 192);

	protected static float StrokeWidth => 1f;

	protected virtual Color StartColor => bX5irkOEsOntc991TAA1(255, 245, 245, 245);

	public ArtifactDataBaseDecorator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		cC2PcFOhNJQhsi25Refu();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 == 0)
		{
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				b2nNrEOhxgEkr3lCHohv(this, 90f);
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 != 0)
				{
					num = 1;
				}
				break;
			case 1:
				oEtx8fOhScQnSqQQw1Nl(this, 120f);
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	protected override void CreatePaths(NRectangleF bounds)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected O, but got Unknown
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected O, but got Unknown
		int num = 2;
		int num2 = num;
		NStyle val = default(NStyle);
		NCustomPath val8 = default(NCustomPath);
		while (true)
		{
			switch (num2)
			{
			default:
				val.set_StrokeStyle(new NStrokeStyle(StrokeWidth, StrokeColor));
				num2 = 5;
				break;
			case 6:
				return;
			case 2:
			{
				float x = bounds.X;
				float y = bounds.Y;
				NCustomPath val2 = new NCustomPath((GraphicsPath)xSfJxfOh1lWQ3yhy9KkN(x, y, bounds.Width, bounds.Height), (PathType)1);
				NStyle val3 = new NStyle();
				AgklZxOhE7W0aYiYsyP8(val3, (object)new NGradientFillStyle((GradientStyle)0, (GradientVariant)0, StartColor, NHPbFSOhhSi0wN1Ewk0p(this)));
				val3.set_StrokeStyle(new NStrokeStyle(GjocxkOhwG5NLgsSZXgd(), StrokeColor));
				rk4aImOh4pcClihm9Xta(val2, val3);
				AddPath((NPathPrimitive)(object)val2);
				NCustomPath val4 = new NCustomPath((GraphicsPath)XcFeVXOhzi83xke4ZjmI(x, y, bounds.Width, bounds.Height, 8.6f), (PathType)1);
				NStyle val5 = new NStyle();
				AgklZxOhE7W0aYiYsyP8(val5, (object)new NGradientFillStyle((GradientStyle)0, (GradientVariant)0, StartColor, NHPbFSOhhSi0wN1Ewk0p(this)));
				dIEY3WOEOjMFnXqwYtoG(val5, (object)new NStrokeStyle(StrokeWidth, zgSpPMOEKNU7ZXSWo6w6()));
				rk4aImOh4pcClihm9Xta(val4, val5);
				AddPath((NPathPrimitive)(object)val4);
				NCustomPath val6 = new NCustomPath((GraphicsPath)XcFeVXOhzi83xke4ZjmI(x, y, bounds.Width, bounds.Height, 5.1f), (PathType)1);
				NStyle val7 = new NStyle();
				val7.set_FillStyle((NFillStyle)new NGradientFillStyle((GradientStyle)0, (GradientVariant)0, NHPbFSOhhSi0wN1Ewk0p(this), NHPbFSOhhSi0wN1Ewk0p(this)));
				dIEY3WOEOjMFnXqwYtoG(val7, (object)new NStrokeStyle(GjocxkOhwG5NLgsSZXgd(), zgSpPMOEKNU7ZXSWo6w6()));
				rk4aImOh4pcClihm9Xta(val6, val7);
				AddPath((NPathPrimitive)(object)val6);
				val8 = new NCustomPath((GraphicsPath)C2oPtVOEZKw4CJkEC2Pt(x, y, bounds.Width, bounds.Height, 1.6f), (PathType)1);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 != 0)
				{
					num2 = 1;
				}
				break;
			}
			case 3:
				val.set_FillStyle((NFillStyle)new NGradientFillStyle((GradientStyle)0, (GradientVariant)0, NHPbFSOhhSi0wN1Ewk0p(this), NHPbFSOhhSi0wN1Ewk0p(this)));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				AddPath((NPathPrimitive)(object)val8);
				num2 = 6;
				break;
			case 5:
				rk4aImOh4pcClihm9Xta(val8, val);
				num2 = 4;
				break;
			case 1:
				val = new NStyle();
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 != 0)
				{
					num2 = 3;
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
			default:
			{
				GraphicsPath graphicsPath = new GraphicsPath();
				Iq5Uh8OEvaZp4eWhfgrO(graphicsPath, x, num3, num4 - x, 7f, 0f, 180f);
				hTjcGZOEYbxYjMrue992(graphicsPath, x, num3, x, y + 3.5f);
				hTjcGZOEYbxYjMrue992(graphicsPath, num4, y + 3.5f, num4, num3);
				dLEdDHOE8vtGFXXPjsu1(graphicsPath);
				return graphicsPath;
			}
			case 2:
				num4 = x + w / 2.5f;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				num3 = y + h / 3f;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private static GraphicsPath CreatePathArc(float x, float y, float w, float h, float ug)
	{
		int num = 1;
		int num2 = num;
		float num3 = default(float);
		while (true)
		{
			switch (num2)
			{
			case 1:
				num3 = x + w / 2.5f;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 != 0)
				{
					num2 = 0;
				}
				break;
			default:
			{
				GraphicsPath graphicsPath = new GraphicsPath();
				Iq5Uh8OEvaZp4eWhfgrO(graphicsPath, x, y + ug, num3 - x, 7f, 0f, 180f);
				return graphicsPath;
			}
			}
		}
	}

	private static GraphicsPath CreatePathArcAll(float x, float y, float w, float h, float ug)
	{
		int num = 2;
		int num2 = num;
		float num3 = default(float);
		while (true)
		{
			switch (num2)
			{
			default:
			{
				GraphicsPath graphicsPath = new GraphicsPath();
				graphicsPath.AddArc(x, y + ug, num3 - x, 7f, 0f, 360f);
				dLEdDHOE8vtGFXXPjsu1(graphicsPath);
				return graphicsPath;
			}
			case 2:
				num3 = x + w / 2.5f;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				_ = h / 3f;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void cC2PcFOhNJQhsi25Refu()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static void b2nNrEOhxgEkr3lCHohv(object P_0, float value)
	{
		((BaseDecorator)P_0).Width = value;
	}

	internal static void oEtx8fOhScQnSqQQw1Nl(object P_0, float value)
	{
		((BaseDecorator)P_0).Height = value;
	}

	internal static bool gCQkr4OhrwmB0lovVghW()
	{
		return hQ5wTGOhaeOhivZHuTRd == null;
	}

	internal static ArtifactDataBaseDecorator jHpo0COhe4YH0IsldpTT()
	{
		return hQ5wTGOhaeOhivZHuTRd;
	}

	internal static object xSfJxfOh1lWQ3yhy9KkN(float x, float y, float w, float h)
	{
		return CreatePath(x, y, w, h);
	}

	internal static Color NHPbFSOhhSi0wN1Ewk0p(object P_0)
	{
		return ((ArtifactDataBaseDecorator)P_0).StartColor;
	}

	internal static void AgklZxOhE7W0aYiYsyP8(object P_0, object P_1)
	{
		((NStyle)P_0).set_FillStyle((NFillStyle)P_1);
	}

	internal static float GjocxkOhwG5NLgsSZXgd()
	{
		return StrokeWidth;
	}

	internal static void rk4aImOh4pcClihm9Xta(object P_0, object P_1)
	{
		((NStyleableElement)P_0).set_Style((NStyle)P_1);
	}

	internal static object XcFeVXOhzi83xke4ZjmI(float x, float y, float w, float h, float ug)
	{
		return CreatePathArc(x, y, w, h, ug);
	}

	internal static Color zgSpPMOEKNU7ZXSWo6w6()
	{
		return StrokeColor;
	}

	internal static void dIEY3WOEOjMFnXqwYtoG(object P_0, object P_1)
	{
		((NStyle)P_0).set_StrokeStyle((NStrokeStyle)P_1);
	}

	internal static object C2oPtVOEZKw4CJkEC2Pt(float x, float y, float w, float h, float ug)
	{
		return CreatePathArcAll(x, y, w, h, ug);
	}

	internal static void Iq5Uh8OEvaZp4eWhfgrO(object P_0, float P_1, float P_2, float P_3, float P_4, float P_5, float P_6)
	{
		((GraphicsPath)P_0).AddArc(P_1, P_2, P_3, P_4, P_5, P_6);
	}

	internal static void hTjcGZOEYbxYjMrue992(object P_0, float P_1, float P_2, float P_3, float P_4)
	{
		((GraphicsPath)P_0).AddLine(P_1, P_2, P_3, P_4);
	}

	internal static void dLEdDHOE8vtGFXXPjsu1(object P_0)
	{
		((GraphicsPath)P_0).CloseAllFigures();
	}

	internal static Color bX5irkOEsOntc991TAA1(int P_0, int P_1, int P_2, int P_3)
	{
		return Color.FromArgb(P_0, P_1, P_2, P_3);
	}
}
