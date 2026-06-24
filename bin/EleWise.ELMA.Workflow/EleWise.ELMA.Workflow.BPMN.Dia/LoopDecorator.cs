using System.Drawing;
using System.Drawing.Drawing2D;
using EleWise.ELMA.Workflow.Diagrams.Shapes;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.GraphicsCore;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Decorators;

public class LoopDecorator : BaseDecorator
{
	private class Arc : NCustomPath
	{
		internal static object YwR7aWvtFJPyb8S9iIqp;

		public Arc(float x, float y, float w, float h)
		{
			//Discarded unreachable code: IL_0030, IL_0035
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dd: Expected O, but got Unknown
			xMFI0ZvtaFuoP9yKp167();
			((NCustomPath)this)._002Ector(CreatePath(), (PathType)0);
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 != 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				default:
					Mg9TDBvtrp6NDUiqb61W(this, w / 32f, h / 32f, new NPointF(0f, 0f));
					num = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 == 0)
					{
						num = 3;
					}
					break;
				case 2:
					return;
				case 3:
					W0AwiKvteFB9o31aQ8Yv(this, x, y);
					num = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 == 0)
					{
						num = 1;
					}
					break;
				case 4:
					zaVARNvtSqgSfEwB8Wsf(qoVYBOvtNdZyFpMKpPJa(this), oXYqfsvtxHSdJ0UZrgMr());
					num = 2;
					break;
				case 1:
					((NStyleableElement)this).set_Style(new NStyle());
					num = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
					{
						num = 4;
					}
					break;
				}
			}
		}

		private static GraphicsPath CreatePath()
		{
			GraphicsPath graphicsPath = new GraphicsPath();
			Qdm0SEvt1sRoDnqD2bRg(graphicsPath, 0, 0, 32, 32, 120f, 300f);
			return graphicsPath;
		}

		internal static void xMFI0ZvtaFuoP9yKp167()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}

		internal static void Mg9TDBvtrp6NDUiqb61W(object P_0, float P_1, float P_2, NPointF P_3)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			((NModel)P_0).ScaleModel(P_1, P_2, P_3);
		}

		internal static void W0AwiKvteFB9o31aQ8Yv(object P_0, float P_1, float P_2)
		{
			((NTransformableElement)P_0).Translate(P_1, P_2);
		}

		internal static object qoVYBOvtNdZyFpMKpPJa(object P_0)
		{
			return ((NStyleableElement)P_0).get_Style();
		}

		internal static object oXYqfsvtxHSdJ0UZrgMr()
		{
			return ShapeHelper.DefaultThickStrokeStyle;
		}

		internal static void zaVARNvtSqgSfEwB8Wsf(object P_0, object P_1)
		{
			((NStyle)P_0).set_StrokeStyle((NStrokeStyle)P_1);
		}

		internal static bool F89o2ivtiPPDCpAt0aVa()
		{
			return YwR7aWvtFJPyb8S9iIqp == null;
		}

		internal static Arc DBg3eIvtIcoN74YoyVq0()
		{
			return (Arc)YwR7aWvtFJPyb8S9iIqp;
		}

		internal static void Qdm0SEvt1sRoDnqD2bRg(object P_0, int P_1, int P_2, int P_3, int P_4, float P_5, float P_6)
		{
			((GraphicsPath)P_0).AddArc(P_1, P_2, P_3, P_4, P_5, P_6);
		}
	}

	private class Arrow : NCustomPath
	{
		internal static object B3QIVIvthXZmOXsqeeF6;

		public Arrow(float x, float y, float w, float h)
		{
			//Discarded unreachable code: IL_0020, IL_0025
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Expected O, but got Unknown
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Expected O, but got Unknown
			//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
			P3rfbRvt4TSVXK9w6DuN();
			((NCustomPath)this)._002Ector((GraphicsPath)jn1StovtzMwuqlZbcW1w(), (PathType)1);
			int num = 5;
			float num3 = default(float);
			float num2 = default(float);
			while (true)
			{
				switch (num)
				{
				case 1:
					num3 = h / 32f;
					num = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f == 0)
					{
						num = 0;
					}
					break;
				case 3:
					UkBgNpvbZ8anEw478TCs(this, (object)new NStyle());
					num = 2;
					break;
				case 6:
					BOGbOcvb85YSJKThZUq5(yIk5U7vbve5IPQcND9qt(this), (object)new NColorFillStyle(ShapeHelper.DefaultStrokeColor));
					num = 4;
					break;
				default:
					YwWaZ1vbKVg0bDFeLY7M(this, num2, num3, new NPointF(0f, 0f));
					num = 7;
					break;
				case 2:
					((NStyle)yIk5U7vbve5IPQcND9qt(this)).set_StrokeStyle((NStrokeStyle)Y2udxGvbYK1bK0yk0qQr());
					num = 6;
					break;
				case 7:
					eJR41wvbOsgherZ6p4vj(this, x, y);
					num = 3;
					break;
				case 5:
					num2 = w / 32f;
					num = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 == 0)
					{
						num = 1;
					}
					break;
				case 4:
					return;
				}
			}
		}

		private static GraphicsPath CreatePath()
		{
			int num = 2;
			int num2 = num;
			float num3 = default(float);
			GraphicsPath graphicsPath = default(GraphicsPath);
			PointF pointF = default(PointF);
			while (true)
			{
				switch (num2)
				{
				case 1:
					num3 = 10.14f;
					num2 = 5;
					break;
				default:
					graphicsPath.CloseAllFigures();
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 == 0)
					{
						num2 = 4;
					}
					break;
				case 4:
					return graphicsPath;
				case 5:
					pointF = new PointF(num3, 32f);
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b != 0)
					{
						num2 = 3;
					}
					break;
				case 3:
					uky9HjvbsF3tSeK2koUe(graphicsPath, new PointF[3]
					{
						new PointF(pointF.X, pointF.Y - num3),
						new PointF(pointF.X, pointF.Y),
						new PointF(pointF.X - num3, pointF.Y)
					});
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					graphicsPath = new GraphicsPath();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}

		internal static void P3rfbRvt4TSVXK9w6DuN()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}

		internal static object jn1StovtzMwuqlZbcW1w()
		{
			return CreatePath();
		}

		internal static void YwWaZ1vbKVg0bDFeLY7M(object P_0, float P_1, float P_2, NPointF P_3)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			((NModel)P_0).ScaleModel(P_1, P_2, P_3);
		}

		internal static void eJR41wvbOsgherZ6p4vj(object P_0, float P_1, float P_2)
		{
			((NTransformableElement)P_0).Translate(P_1, P_2);
		}

		internal static void UkBgNpvbZ8anEw478TCs(object P_0, object P_1)
		{
			((NStyleableElement)P_0).set_Style((NStyle)P_1);
		}

		internal static object yIk5U7vbve5IPQcND9qt(object P_0)
		{
			return ((NStyleableElement)P_0).get_Style();
		}

		internal static object Y2udxGvbYK1bK0yk0qQr()
		{
			return ShapeHelper.DefaultThinStrokeStyle;
		}

		internal static void BOGbOcvb85YSJKThZUq5(object P_0, object P_1)
		{
			((NStyle)P_0).set_FillStyle((NFillStyle)P_1);
		}

		internal static bool ej6hYjvtEaGejFhDTiwJ()
		{
			return B3QIVIvthXZmOXsqeeF6 == null;
		}

		internal static Arrow Wmb5USvtwX6T5fRjSYsr()
		{
			return (Arrow)B3QIVIvthXZmOXsqeeF6;
		}

		internal static void uky9HjvbsF3tSeK2koUe(object P_0, object P_1)
		{
			((GraphicsPath)P_0).AddLines((PointF[])P_1);
		}
	}

	internal static LoopDecorator jP9vGnO4t0ZtGOAmp3aR;

	public LoopDecorator()
	{
		//Discarded unreachable code: IL_001a, IL_001f
		yrLPXOO4gDaQMHsd950Q();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 2:
				jCb7HNO4BsCbibQMqxd5(this, 12f);
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 == 0)
				{
					num = 0;
				}
				break;
			case 1:
				return;
			default:
				KQhCdKO4cgVC2F7YHEso(this, 12f);
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	protected override void CreatePaths(NRectangleF bounds)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				AddPath((NPathPrimitive)(object)new Arc(bounds.X, bounds.Y, bounds.Width, bounds.Height));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				AddPath((NPathPrimitive)(object)new Arrow(bounds.X, bounds.Y, bounds.Width, bounds.Height));
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static void yrLPXOO4gDaQMHsd950Q()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static void jCb7HNO4BsCbibQMqxd5(object P_0, float value)
	{
		((BaseDecorator)P_0).Width = value;
	}

	internal static void KQhCdKO4cgVC2F7YHEso(object P_0, float value)
	{
		((BaseDecorator)P_0).Height = value;
	}

	internal static bool CngJZaO4b557C4iguPtW()
	{
		return jP9vGnO4t0ZtGOAmp3aR == null;
	}

	internal static LoopDecorator A46lY9O45Cig4DE5lZkK()
	{
		return jP9vGnO4t0ZtGOAmp3aR;
	}
}
