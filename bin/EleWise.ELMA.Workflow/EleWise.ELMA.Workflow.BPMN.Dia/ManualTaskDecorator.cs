using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using EleWise.ELMA.Workflow.Diagrams.Shapes;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.GraphicsCore;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Decorators;

[Serializable]
public class ManualTaskDecorator : BaseDecorator
{
	private class Border : NCustomPath
	{
		private static object GqnPYNvbJZ8OSJy2KB7Y;

		public Border(float x, float y, float w, float h)
		{
			//Discarded unreachable code: IL_0030, IL_0035
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d2: Expected O, but got Unknown
			//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e7: Expected O, but got Unknown
			//IL_011e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0128: Expected O, but got Unknown
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
			((NCustomPath)this)._002Ector(CreatePath(), (PathType)1);
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 != 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				case 5:
					return;
				case 6:
					cmHKvSvb51WP4y6PLUrd(zLBMbHvbtLdsgf6GMJXG(this), XkLQiNvbblxKdcw4pnY7());
					num = 4;
					break;
				case 1:
					((NModel)this).ScaleModel(w / 32f, h / 32f, new NPointF(0f, 0f));
					num = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 == 0)
					{
						num = 1;
					}
					break;
				default:
					cmHKvSvb51WP4y6PLUrd(zLBMbHvbtLdsgf6GMJXG(this), (object)new NStrokeStyle(ATJZNbvbchC7V7H2oN92(), rAfHr7vbg87bd7usrcbV()));
					num = 5;
					break;
				case 3:
					dAIUkIvbmcCDKUBI0TYW(this, (object)new NStyle());
					num = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 == 0)
					{
						num = 6;
					}
					break;
				case 2:
					HxFxm6vbyy5gQHaes9P0(this, x, y);
					num = 3;
					break;
				case 4:
					owMZ5kvbB0CVqNKR76DA(zLBMbHvbtLdsgf6GMJXG(this), (object)new NColorFillStyle(rAfHr7vbg87bd7usrcbV()));
					num = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 != 0)
					{
						num = 0;
					}
					break;
				}
			}
		}

		private static GraphicsPath CreatePath()
		{
			int num = 2;
			int num2 = num;
			GraphicsPath graphicsPath = default(GraphicsPath);
			while (true)
			{
				switch (num2)
				{
				case 1:
					l1FsZXvbPqhbNSBiFYTY(graphicsPath, new PointF[24]
					{
						new PointF(0f, 11f),
						new PointF(6f, 6f),
						new PointF(17f, 4f),
						new PointF(19f, 6f),
						new PointF(15f, 10f),
						new PointF(9f, 10f),
						new PointF(9f, 12f),
						new PointF(27f, 12f),
						new PointF(28f, 14f),
						new PointF(14f, 14f),
						new PointF(14f, 16f),
						new PointF(31f, 16f),
						new PointF(31f, 18f),
						new PointF(15f, 18f),
						new PointF(15f, 20f),
						new PointF(29f, 20f),
						new PointF(28f, 22f),
						new PointF(14f, 22f),
						new PointF(14f, 24f),
						new PointF(24f, 24f),
						new PointF(23f, 26f),
						new PointF(3f, 26f),
						new PointF(0f, 23f),
						new PointF(0f, 11f)
					});
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					graphicsPath = new GraphicsPath();
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a != 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					return graphicsPath;
				default:
					graphicsPath.CloseAllFigures();
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 == 0)
					{
						num2 = 3;
					}
					break;
				}
			}
		}

		internal static void HxFxm6vbyy5gQHaes9P0(object P_0, float P_1, float P_2)
		{
			((NTransformableElement)P_0).Translate(P_1, P_2);
		}

		internal static void dAIUkIvbmcCDKUBI0TYW(object P_0, object P_1)
		{
			((NStyleableElement)P_0).set_Style((NStyle)P_1);
		}

		internal static object zLBMbHvbtLdsgf6GMJXG(object P_0)
		{
			return ((NStyleableElement)P_0).get_Style();
		}

		internal static object XkLQiNvbblxKdcw4pnY7()
		{
			return ShapeHelper.DefaultThinStrokeStyle;
		}

		internal static void cmHKvSvb51WP4y6PLUrd(object P_0, object P_1)
		{
			((NStyle)P_0).set_StrokeStyle((NStrokeStyle)P_1);
		}

		internal static Color rAfHr7vbg87bd7usrcbV()
		{
			return StrokeColor;
		}

		internal static void owMZ5kvbB0CVqNKR76DA(object P_0, object P_1)
		{
			((NStyle)P_0).set_FillStyle((NFillStyle)P_1);
		}

		internal static float ATJZNbvbchC7V7H2oN92()
		{
			return StrokeWidth;
		}

		internal static bool O1CecDvblZsscjsIcAtg()
		{
			return GqnPYNvbJZ8OSJy2KB7Y == null;
		}

		internal static Border g485Fkvb08H1EKtRAIHY()
		{
			return (Border)GqnPYNvbJZ8OSJy2KB7Y;
		}

		internal static void l1FsZXvbPqhbNSBiFYTY(object P_0, object P_1)
		{
			((GraphicsPath)P_0).AddLines((PointF[])P_1);
		}
	}

	private static ManualTaskDecorator GeO6gwO4Ptj44q33SdAG;

	protected static Color StrokeColor => Color.FromArgb(178, 184, 192);

	protected static float StrokeWidth => 0.1f;

	public ManualTaskDecorator()
	{
		//Discarded unreachable code: IL_001a, IL_001f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 2:
				wTYifYO4unB6D1jMW5N2(this, 16f);
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 != 0)
				{
					num = 0;
				}
				break;
			default:
				Height = 16f;
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b == 0)
				{
					num = 1;
				}
				break;
			case 1:
				return;
			}
		}
	}

	protected override void CreatePaths(NRectangleF bounds)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
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
				AddPath((NPathPrimitive)(object)new Border(bounds.X, bounds.Y, bounds.Width, bounds.Height));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void wTYifYO4unB6D1jMW5N2(object P_0, float value)
	{
		((BaseDecorator)P_0).Width = value;
	}

	internal static bool NbT2aJO4XXIDJr6NFwwq()
	{
		return GeO6gwO4Ptj44q33SdAG == null;
	}

	internal static ManualTaskDecorator QXKUg7O4d6y6oA4MpT4I()
	{
		return GeO6gwO4Ptj44q33SdAG;
	}
}
