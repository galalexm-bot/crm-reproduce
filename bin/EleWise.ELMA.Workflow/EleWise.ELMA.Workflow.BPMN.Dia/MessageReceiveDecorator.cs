using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using EleWise.ELMA.Workflow.Diagrams.Shapes;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.GraphicsCore;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Decorators;

[Serializable]
public class MessageReceiveDecorator : BaseDecorator
{
	private class Border : NCustomPath
	{
		internal static object JawsChvbX33UMPuedjZ5;

		public Border(float x, float y, float w, float h)
		{
			//Discarded unreachable code: IL_0030
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Expected O, but got Unknown
			//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f9: Expected O, but got Unknown
			lwtjVVvbDAEJR8bHGKyM();
			((NCustomPath)this)._002Ector(CreatePath(), (PathType)0);
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a != 0)
			{
				num = 4;
			}
			while (true)
			{
				switch (num)
				{
				default:
					((NStyleableElement)this).set_Style(new NStyle());
					num = 5;
					break;
				case 2:
					IwpHHgvbHgv5CSdCiuKf(this, x, y);
					num = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a != 0)
					{
						num = 0;
					}
					break;
				case 4:
				{
					ySwG6Nvbnbbr5L58J45F(this, w / 32f, h / 32f, new NPointF(0f, 0f));
					int num2 = 2;
					num = num2;
					break;
				}
				case 5:
					BvwuuIvb99NBn9LLRiQW(xtTZmHvbL3RGSJ6ox8sw(this), HdWEFxvbfQ76hbvnkCaO());
					num = 3;
					break;
				case 1:
					return;
				case 3:
					((NStyle)xtTZmHvbL3RGSJ6ox8sw(this)).set_StrokeStyle(new NStrokeStyle(kmjqxWvbWDwWeUbhs4PR(), B404bEvbjZyQVraIgKY9()));
					num = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 != 0)
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
			QIArdBvbRmaXjbseCw3V(graphicsPath, new RectangleF(0f, 4f, 31f, 23f));
			return graphicsPath;
		}

		internal static void lwtjVVvbDAEJR8bHGKyM()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}

		internal static void ySwG6Nvbnbbr5L58J45F(object P_0, float P_1, float P_2, NPointF P_3)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			((NModel)P_0).ScaleModel(P_1, P_2, P_3);
		}

		internal static void IwpHHgvbHgv5CSdCiuKf(object P_0, float P_1, float P_2)
		{
			((NTransformableElement)P_0).Translate(P_1, P_2);
		}

		internal static object xtTZmHvbL3RGSJ6ox8sw(object P_0)
		{
			return ((NStyleableElement)P_0).get_Style();
		}

		internal static object HdWEFxvbfQ76hbvnkCaO()
		{
			return ShapeHelper.DefaultThinStrokeStyle;
		}

		internal static void BvwuuIvb99NBn9LLRiQW(object P_0, object P_1)
		{
			((NStyle)P_0).set_StrokeStyle((NStrokeStyle)P_1);
		}

		internal static float kmjqxWvbWDwWeUbhs4PR()
		{
			return StrokeWidth;
		}

		internal static Color B404bEvbjZyQVraIgKY9()
		{
			return StrokeColor;
		}

		internal static bool m2ZwkrvbdDZ6Auu6vicy()
		{
			return JawsChvbX33UMPuedjZ5 == null;
		}

		internal static Border FBxqfwvbubiPGnunhttM()
		{
			return (Border)JawsChvbX33UMPuedjZ5;
		}

		internal static void QIArdBvbRmaXjbseCw3V(object P_0, RectangleF P_1)
		{
			((GraphicsPath)P_0).AddRectangle(P_1);
		}
	}

	private class Line : NCustomPath
	{
		private static object eymxTOvb6HQHirjBVhDp;

		public Line(float x, float y, float w, float h)
		{
			//Discarded unreachable code: IL_0020, IL_0025
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Expected O, but got Unknown
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			aXQr4TvbTBJaFE2rOq6Z();
			((NCustomPath)this)._002Ector((GraphicsPath)XFoG1IvbQTN2Jg9MChmZ(), (PathType)0);
			int num = 3;
			while (true)
			{
				switch (num)
				{
				case 1:
					((NStyle)SdnPeCvbMOVGAm5ib8ge(this)).set_StrokeStyle(new NStrokeStyle(bqJV0bvbVUlknoBVoW2l(), fZXl5CvbAi0RD6E4NMK0()));
					num = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
					{
						num = 2;
					}
					break;
				default:
					YG5UChvbpaLuRBikred2(this, x, y);
					num = 2;
					break;
				case 5:
					return;
				case 2:
					kEGRbwvbCmLL4PCDBOjy(this, (object)new NStyle());
					num = 4;
					break;
				case 3:
					((NModel)this).ScaleModel(w / 32f, h / 32f, new NPointF(0f, 0f));
					num = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 == 0)
					{
						num = 0;
					}
					break;
				case 4:
					i3pA3nvbUJ6XB0McTqoj(SdnPeCvbMOVGAm5ib8ge(this), wHtoXSvbkGDx7pKj6eYT());
					num = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 != 0)
					{
						num = 1;
					}
					break;
				}
			}
		}

		private static GraphicsPath CreatePath()
		{
			int num = 1;
			int num2 = num;
			GraphicsPath graphicsPath = default(GraphicsPath);
			while (true)
			{
				switch (num2)
				{
				case 1:
					graphicsPath = new GraphicsPath();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					return graphicsPath;
				}
				SIoDRivbGCeK2qvAcucy(graphicsPath, new PointF[4]
				{
					new PointF(0f, 4f),
					new PointF(15f, 15f),
					new PointF(16f, 15f),
					new PointF(31f, 4f)
				});
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a == 0)
				{
					num2 = 2;
				}
			}
		}

		internal static void aXQr4TvbTBJaFE2rOq6Z()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}

		internal static object XFoG1IvbQTN2Jg9MChmZ()
		{
			return CreatePath();
		}

		internal static void YG5UChvbpaLuRBikred2(object P_0, float P_1, float P_2)
		{
			((NTransformableElement)P_0).Translate(P_1, P_2);
		}

		internal static void kEGRbwvbCmLL4PCDBOjy(object P_0, object P_1)
		{
			((NStyleableElement)P_0).set_Style((NStyle)P_1);
		}

		internal static object SdnPeCvbMOVGAm5ib8ge(object P_0)
		{
			return ((NStyleableElement)P_0).get_Style();
		}

		internal static object wHtoXSvbkGDx7pKj6eYT()
		{
			return ShapeHelper.DefaultThinStrokeStyle;
		}

		internal static void i3pA3nvbUJ6XB0McTqoj(object P_0, object P_1)
		{
			((NStyle)P_0).set_StrokeStyle((NStrokeStyle)P_1);
		}

		internal static float bqJV0bvbVUlknoBVoW2l()
		{
			return StrokeWidth;
		}

		internal static Color fZXl5CvbAi0RD6E4NMK0()
		{
			return StrokeColor;
		}

		internal static bool bjA075vbqCu50RLhRJqw()
		{
			return eymxTOvb6HQHirjBVhDp == null;
		}

		internal static Line RjtjOPvb3AiiiosugeA7()
		{
			return (Line)eymxTOvb6HQHirjBVhDp;
		}

		internal static void SIoDRivbGCeK2qvAcucy(object P_0, object P_1)
		{
			((GraphicsPath)P_0).AddLines((PointF[])P_1);
		}
	}

	internal static MessageReceiveDecorator pkQuw3O4DMleow6iWZng;

	protected static Color StrokeColor => Color.FromArgb(182, 170, 113);

	protected static float StrokeWidth => 1f;

	public MessageReceiveDecorator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		kMRU4wO4LAp5ex1CtvSb();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				Height = 16f;
				num = 2;
				break;
			case 2:
				return;
			case 1:
				Width = 16f;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	protected override void CreatePaths(NRectangleF bounds)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				AddPath((NPathPrimitive)(object)new Border(bounds.X, bounds.Y, bounds.Width, bounds.Height));
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				AddPath((NPathPrimitive)(object)new Line(bounds.X, bounds.Y, bounds.Width, bounds.Height));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void kMRU4wO4LAp5ex1CtvSb()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool eGfO7ZO4nAu4crxc1Ft1()
	{
		return pkQuw3O4DMleow6iWZng == null;
	}

	internal static MessageReceiveDecorator FV6J2KO4HAmXROlDvksw()
	{
		return pkQuw3O4DMleow6iWZng;
	}
}
