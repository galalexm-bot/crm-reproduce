using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using EleWise.ELMA.Workflow.Diagrams.Shapes;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.GraphicsCore;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Decorators;

[Serializable]
public class ScriptTaskDecorator : BaseDecorator
{
	private class Border : NCustomPath
	{
		private static object mueQG3vgl0QTX2xj1L6L;

		public Border(float x, float y, float w, float h)
		{
			//Discarded unreachable code: IL_0020, IL_0025
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Expected O, but got Unknown
			//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0105: Expected O, but got Unknown
			JyaS86vgmd6USRsMI1e7();
			((NCustomPath)this)._002Ector(CreatePath(), (PathType)0);
			int num = 4;
			while (true)
			{
				switch (num)
				{
				case 4:
					Ocad05vgt9GnEBGvg9Uk(this, w / 24f, h / 32f, new NPointF(0f, 0f));
					num = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f == 0)
					{
						num = 3;
					}
					break;
				case 2:
					return;
				case 3:
					e98f4LvgbZ0BdM7VNRX3(this, x, y);
					num = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 == 0)
					{
						num = 1;
					}
					break;
				case 5:
					ljkMVyvgBOx057li0Ctn(((NStyleableElement)this).get_Style(), (object)new NStrokeStyle(StrokeWidth, StrokeColor));
					num = 2;
					break;
				default:
					ljkMVyvgBOx057li0Ctn(((NStyleableElement)this).get_Style(), g2a6xRvggEKugjWpXEiL());
					num = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 != 0)
					{
						num = 0;
					}
					break;
				case 1:
					lbj908vg5UfmZMiFySZ7(this, (object)new NStyle());
					num = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 == 0)
					{
						num = 0;
					}
					break;
				}
			}
		}

		private static GraphicsPath CreatePath()
		{
			GraphicsPath graphicsPath = new GraphicsPath();
			xrvXwuvgcDINKBoUS2Dl(graphicsPath, -28f, 8f, 32f, 32f, 30f, -60f);
			xrvXwuvgcDINKBoUS2Dl(graphicsPath, 0f, -8f, 32f, 32f, 150f, 60f);
			xrvXwuvgcDINKBoUS2Dl(graphicsPath, 16f, -8f, 32f, 32f, 210f, -60f);
			graphicsPath.AddArc(-12f, 8f, 32f, 32f, -30f, 60f);
			xgcvjLvgPIQSoioQCsTu(graphicsPath);
			return graphicsPath;
		}

		internal static void JyaS86vgmd6USRsMI1e7()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}

		internal static void Ocad05vgt9GnEBGvg9Uk(object P_0, float P_1, float P_2, NPointF P_3)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			((NModel)P_0).ScaleModel(P_1, P_2, P_3);
		}

		internal static void e98f4LvgbZ0BdM7VNRX3(object P_0, float P_1, float P_2)
		{
			((NTransformableElement)P_0).Translate(P_1, P_2);
		}

		internal static void lbj908vg5UfmZMiFySZ7(object P_0, object P_1)
		{
			((NStyleableElement)P_0).set_Style((NStyle)P_1);
		}

		internal static object g2a6xRvggEKugjWpXEiL()
		{
			return ShapeHelper.DefaultThinStrokeStyle;
		}

		internal static void ljkMVyvgBOx057li0Ctn(object P_0, object P_1)
		{
			((NStyle)P_0).set_StrokeStyle((NStrokeStyle)P_1);
		}

		internal static bool x3FRrlvg0Hwo2Nfwlnyb()
		{
			return mueQG3vgl0QTX2xj1L6L == null;
		}

		internal static Border jw7d2Vvgyicjh96aYC7E()
		{
			return (Border)mueQG3vgl0QTX2xj1L6L;
		}

		internal static void xrvXwuvgcDINKBoUS2Dl(object P_0, float P_1, float P_2, float P_3, float P_4, float P_5, float P_6)
		{
			((GraphicsPath)P_0).AddArc(P_1, P_2, P_3, P_4, P_5, P_6);
		}

		internal static void xgcvjLvgPIQSoioQCsTu(object P_0)
		{
			((GraphicsPath)P_0).CloseAllFigures();
		}
	}

	private class Line : NCustomPath
	{
		internal static object aAXoyovgXg2oengQi7rT;

		public Line(float dx, float dy, float x, float y, float w, float h)
		{
			//Discarded unreachable code: IL_0022, IL_0027
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d4: Expected O, but got Unknown
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f9: Expected O, but got Unknown
			AspAdivgDRBP60DqyYpu();
			((NCustomPath)this)._002Ector((GraphicsPath)qRGNxsvgnDnyordM4qKa(dx, dy), (PathType)0);
			int num = 3;
			while (true)
			{
				switch (num)
				{
				case 2:
					tqoWP0vgLW78YcVfSOUO(this, x, y);
					num = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 == 0)
					{
						num = 0;
					}
					break;
				case 3:
					NfmFNbvgHlWs7Q3CYpOk(this, w / 24f, h / 32f, new NPointF(0f, 0f));
					num = 2;
					break;
				default:
					keIkPvvgjQ2RTbQVEbCn(LyLC7Ivg9tSheyJJaxmc(this), QqgAQPvgWyyGknZ9wLlq());
					num = 4;
					break;
				case 5:
					return;
				case 4:
					keIkPvvgjQ2RTbQVEbCn(((NStyleableElement)this).get_Style(), (object)new NStrokeStyle(hlnNbivgRhLZsbX9TIfO(), F3hEHVvg6G8LQ3SrW6HK()));
					num = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 == 0)
					{
						num = 3;
					}
					break;
				case 1:
					uTT8EMvgf7n0U57ZEuRk(this, (object)new NStyle());
					num = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 == 0)
					{
						num = 0;
					}
					break;
				}
			}
		}

		private static GraphicsPath CreatePath(float dx, float dy)
		{
			GraphicsPath graphicsPath = new GraphicsPath();
			U3yi4gvgqWVHNG1dj2UT(graphicsPath, dx - 2f, dy, dx + 10f, dy);
			return graphicsPath;
		}

		internal static void AspAdivgDRBP60DqyYpu()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}

		internal static object qRGNxsvgnDnyordM4qKa(float dx, float dy)
		{
			return CreatePath(dx, dy);
		}

		internal static void NfmFNbvgHlWs7Q3CYpOk(object P_0, float P_1, float P_2, NPointF P_3)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			((NModel)P_0).ScaleModel(P_1, P_2, P_3);
		}

		internal static void tqoWP0vgLW78YcVfSOUO(object P_0, float P_1, float P_2)
		{
			((NTransformableElement)P_0).Translate(P_1, P_2);
		}

		internal static void uTT8EMvgf7n0U57ZEuRk(object P_0, object P_1)
		{
			((NStyleableElement)P_0).set_Style((NStyle)P_1);
		}

		internal static object LyLC7Ivg9tSheyJJaxmc(object P_0)
		{
			return ((NStyleableElement)P_0).get_Style();
		}

		internal static object QqgAQPvgWyyGknZ9wLlq()
		{
			return ShapeHelper.DefaultThinStrokeStyle;
		}

		internal static void keIkPvvgjQ2RTbQVEbCn(object P_0, object P_1)
		{
			((NStyle)P_0).set_StrokeStyle((NStrokeStyle)P_1);
		}

		internal static float hlnNbivgRhLZsbX9TIfO()
		{
			return StrokeWidth;
		}

		internal static Color F3hEHVvg6G8LQ3SrW6HK()
		{
			return StrokeColor;
		}

		internal static bool DlmlfnvgdjxdSD04SFRI()
		{
			return aAXoyovgXg2oengQi7rT == null;
		}

		internal static Line JIygORvguaalwTRilpF6()
		{
			return (Line)aAXoyovgXg2oengQi7rT;
		}

		internal static void U3yi4gvgqWVHNG1dj2UT(object P_0, float P_1, float P_2, float P_3, float P_4)
		{
			((GraphicsPath)P_0).AddLine(P_1, P_2, P_3, P_4);
		}
	}

	internal static ScriptTaskDecorator hyVaulO41wDbfwKJeQct;

	protected static Color StrokeColor => RNjCxNO4zqW5gwDbUslH(182, 170, 113);

	protected static float StrokeWidth => 2f;

	public ScriptTaskDecorator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				OLx7WDO44hPdjpkmUUhR(this, 16f);
				num = 2;
				break;
			case 1:
				pofsEnO4wMuW9N0UPwBM(this, 19f);
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 != 0)
				{
					num = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	protected override void CreatePaths(NRectangleF bounds)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				AddPath((NPathPrimitive)(object)new Line(6f, 16f, bounds.X, bounds.Y, bounds.Width, bounds.Height));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				AddPath((NPathPrimitive)(object)new Line(4f, 8f, bounds.X, bounds.Y, bounds.Width, bounds.Height));
				num2 = 4;
				break;
			case 1:
				return;
			case 3:
				AddPath((NPathPrimitive)(object)new Border(bounds.X, bounds.Y, bounds.Width, bounds.Height));
				num2 = 2;
				break;
			default:
				AddPath((NPathPrimitive)(object)new Line(8f, 24f, bounds.X, bounds.Y, bounds.Width, bounds.Height));
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static void pofsEnO4wMuW9N0UPwBM(object P_0, float value)
	{
		((BaseDecorator)P_0).Width = value;
	}

	internal static void OLx7WDO44hPdjpkmUUhR(object P_0, float value)
	{
		((BaseDecorator)P_0).Height = value;
	}

	internal static bool iMPnFeO4h80dZ0FSZLXh()
	{
		return hyVaulO41wDbfwKJeQct == null;
	}

	internal static ScriptTaskDecorator JZEoXtO4EwXv0UfP6jhp()
	{
		return hyVaulO41wDbfwKJeQct;
	}

	internal static Color RNjCxNO4zqW5gwDbUslH(int P_0, int P_1, int P_2)
	{
		return Color.FromArgb(P_0, P_1, P_2);
	}
}
