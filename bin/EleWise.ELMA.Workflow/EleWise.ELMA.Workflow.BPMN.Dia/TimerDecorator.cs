using System;
using System.Drawing.Drawing2D;
using EleWise.ELMA.Workflow.Diagrams.Shapes;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.GraphicsCore;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Decorators;

public class TimerDecorator : BaseDecorator
{
	private class Circle : NCustomPath
	{
		internal static object Gawr9YvBLxuY6evEUpb8;

		public Circle(float x, float y, float w, float h)
		{
			//Discarded unreachable code: IL_0030, IL_0035
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Expected O, but got Unknown
			//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
			((NCustomPath)this)._002Ector((GraphicsPath)BUSg4JvBWtcmPZBGcvuG(), (PathType)0);
			int num = 4;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 == 0)
			{
				num = 4;
			}
			while (true)
			{
				switch (num)
				{
				case 3:
					return;
				default:
					DKgC1gvBqvtj2i5mKmnk(((NStyleableElement)this).get_Style(), RGfaW1vB6lxlj2IZM55C());
					num = 3;
					break;
				case 2:
					((NTransformableElement)this).Translate(x, y);
					num = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 != 0)
					{
						num = 0;
					}
					break;
				case 1:
					S0LBsjvBRkxluZV0m4CM(this, (object)new NStyle());
					num = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a == 0)
					{
						num = 0;
					}
					break;
				case 4:
					KvvRlGvBjrC2gngGYqPB(this, w / 32f, h / 32f, new NPointF(0f, 0f));
					num = 2;
					break;
				}
			}
		}

		private static GraphicsPath CreatePath()
		{
			GraphicsPath graphicsPath = new GraphicsPath();
			bDPAo3vB3llMs2tauaP5(graphicsPath, 0f, 0f, 32f, 32f);
			return graphicsPath;
		}

		internal static object BUSg4JvBWtcmPZBGcvuG()
		{
			return CreatePath();
		}

		internal static void KvvRlGvBjrC2gngGYqPB(object P_0, float P_1, float P_2, NPointF P_3)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			((NModel)P_0).ScaleModel(P_1, P_2, P_3);
		}

		internal static void S0LBsjvBRkxluZV0m4CM(object P_0, object P_1)
		{
			((NStyleableElement)P_0).set_Style((NStyle)P_1);
		}

		internal static object RGfaW1vB6lxlj2IZM55C()
		{
			return ShapeHelper.DefaultThinStrokeStyle;
		}

		internal static void DKgC1gvBqvtj2i5mKmnk(object P_0, object P_1)
		{
			((NStyle)P_0).set_StrokeStyle((NStrokeStyle)P_1);
		}

		internal static bool BKEjd9vBfZXhNi3YfopD()
		{
			return Gawr9YvBLxuY6evEUpb8 == null;
		}

		internal static Circle BpiwjOvB9ssKQjRednbA()
		{
			return (Circle)Gawr9YvBLxuY6evEUpb8;
		}

		internal static void bDPAo3vB3llMs2tauaP5(object P_0, float P_1, float P_2, float P_3, float P_4)
		{
			((GraphicsPath)P_0).AddEllipse(P_1, P_2, P_3, P_4);
		}
	}

	private class HourMark : NCustomPath
	{
		internal static object eOj5M7vBTKwjBaIguknv;

		public HourMark(int i, float x, float y, float w, float h)
		{
			//Discarded unreachable code: IL_0031, IL_0036
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected O, but got Unknown
			fP8Bu6vBCxsEerlrBtCW();
			((NCustomPath)this)._002Ector(CreatePath(i), (PathType)0);
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 != 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					return;
				case 3:
					oQ509IvBMWSIdiMx4F4h(this, x, y);
					num = 2;
					break;
				default:
					((NModel)this).ScaleModel(w / 32f, h / 32f, new NPointF(0f, 0f));
					num = 3;
					break;
				case 4:
					NNUXGgvBAnr29EnqQvsl(WJ5lnsvBUSbb94ZFdXe9(this), zPZBJYvBVTe4Vhbi3xgD());
					num = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d != 0)
					{
						num = 0;
					}
					break;
				case 2:
					Y1dbNbvBkSi5aq4U9WUk(this, (object)new NStyle());
					num = 4;
					break;
				}
			}
		}

		private static GraphicsPath CreatePath(int i)
		{
			GraphicsPath graphicsPath = new GraphicsPath();
			double num = -Math.PI / 2.0 + Math.PI * (double)i / 6.0;
			float num2 = (float)Math.Cos(num);
			float num3 = (float)eiNNxOvBGnBYuvvvEI1R(num);
			float num4 = 16f + 16f * num2;
			float num5 = 16f + 16f * num3;
			float num6 = 16f + 10f * num2;
			float num7 = 16f + 10f * num3;
			ipxQiXvB7AexEFCJGOyR(graphicsPath, num4, num5, num6, num7);
			return graphicsPath;
		}

		internal static void fP8Bu6vBCxsEerlrBtCW()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}

		internal static void oQ509IvBMWSIdiMx4F4h(object P_0, float P_1, float P_2)
		{
			((NTransformableElement)P_0).Translate(P_1, P_2);
		}

		internal static void Y1dbNbvBkSi5aq4U9WUk(object P_0, object P_1)
		{
			((NStyleableElement)P_0).set_Style((NStyle)P_1);
		}

		internal static object WJ5lnsvBUSbb94ZFdXe9(object P_0)
		{
			return ((NStyleableElement)P_0).get_Style();
		}

		internal static object zPZBJYvBVTe4Vhbi3xgD()
		{
			return ShapeHelper.DefaultThinStrokeStyle;
		}

		internal static void NNUXGgvBAnr29EnqQvsl(object P_0, object P_1)
		{
			((NStyle)P_0).set_StrokeStyle((NStrokeStyle)P_1);
		}

		internal static bool PYmJ5avBQSLVUX98MPZg()
		{
			return eOj5M7vBTKwjBaIguknv == null;
		}

		internal static HourMark cvrC6LvBpHiL8RNfVLAb()
		{
			return (HourMark)eOj5M7vBTKwjBaIguknv;
		}

		internal static double eiNNxOvBGnBYuvvvEI1R(double P_0)
		{
			return Math.Sin(P_0);
		}

		internal static void ipxQiXvB7AexEFCJGOyR(object P_0, float P_1, float P_2, float P_3, float P_4)
		{
			((GraphicsPath)P_0).AddLine(P_1, P_2, P_3, P_4);
		}
	}

	private class Arrows : NCustomPath
	{
		private static object tNPMA8vB2KFP9WoK81Dk;

		public Arrows(float hours, float x, float y, float w, float h)
		{
			//Discarded unreachable code: IL_0031, IL_0036
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected O, but got Unknown
			//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
			DmJuHtvBiTXFNmYVFyHx();
			((NCustomPath)this)._002Ector((GraphicsPath)Il3w3nvBIsLVDpaZhcQ1(hours), (PathType)0);
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 == 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 4:
					pIJqUevBrJ2frPP3sZae(this, (object)new NStyle());
					num = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
					{
						num = 1;
					}
					break;
				case 3:
					vYFLJhvBaUo4KYQkg2MX(this, x, y);
					num = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d == 0)
					{
						num = 4;
					}
					break;
				case 0:
					return;
				case 1:
					((NModel)this).ScaleModel(w / 32f, h / 32f, new NPointF(0f, 0f));
					num = 3;
					break;
				case 2:
					MHTa59vBNhQnKg0mbihs(((NStyleableElement)this).get_Style(), IF7cCMvBe3stj6Qco19X());
					num = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f == 0)
					{
						num = 0;
					}
					break;
				}
			}
		}

		private static GraphicsPath CreatePath(float hours)
		{
			GraphicsPath graphicsPath = new GraphicsPath();
			double num = -Math.PI / 2.0 + Math.PI * (double)hours / 6.0;
			float num2 = (float)S067k1vBxYX0XblaZU22(num);
			float num3 = (float)Math.Sin(num);
			float num4 = 16f + 8f * num2;
			float num5 = 16f + 8f * num3;
			float num6 = 16f;
			float num7 = 16f;
			float num8 = hours - (float)(int)hours;
			double num9 = -Math.PI / 2.0 + Math.PI * (double)num8 * 2.0;
			float num10 = (float)S067k1vBxYX0XblaZU22(num9);
			float num11 = (float)vgj5dkvBSjYYgKB4Qk3a(num9);
			float num12 = 16f + 12f * num10;
			float num13 = 16f + 12f * num11;
			fiZUnDvB1s1U6TtPv6mQ(graphicsPath, num4, num5, num6, num7);
			fiZUnDvB1s1U6TtPv6mQ(graphicsPath, num6, num7, num12, num13);
			return graphicsPath;
		}

		internal static void DmJuHtvBiTXFNmYVFyHx()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}

		internal static object Il3w3nvBIsLVDpaZhcQ1(float hours)
		{
			return CreatePath(hours);
		}

		internal static void vYFLJhvBaUo4KYQkg2MX(object P_0, float P_1, float P_2)
		{
			((NTransformableElement)P_0).Translate(P_1, P_2);
		}

		internal static void pIJqUevBrJ2frPP3sZae(object P_0, object P_1)
		{
			((NStyleableElement)P_0).set_Style((NStyle)P_1);
		}

		internal static object IF7cCMvBe3stj6Qco19X()
		{
			return ShapeHelper.DefaultStrokeStyle;
		}

		internal static void MHTa59vBNhQnKg0mbihs(object P_0, object P_1)
		{
			((NStyle)P_0).set_StrokeStyle((NStrokeStyle)P_1);
		}

		internal static bool yg3B9evBoQdHceWtGDsv()
		{
			return tNPMA8vB2KFP9WoK81Dk == null;
		}

		internal static Arrows f18e0FvBFgOdCxX0MSF8()
		{
			return (Arrows)tNPMA8vB2KFP9WoK81Dk;
		}

		internal static double S067k1vBxYX0XblaZU22(double P_0)
		{
			return Math.Cos(P_0);
		}

		internal static double vgj5dkvBSjYYgKB4Qk3a(double P_0)
		{
			return Math.Sin(P_0);
		}

		internal static void fiZUnDvB1s1U6TtPv6mQ(object P_0, float P_1, float P_2, float P_3, float P_4)
		{
			((GraphicsPath)P_0).AddLine(P_1, P_2, P_3, P_4);
		}
	}

	internal static TimerDecorator u0yOujOzUumaq8bNTWRT;

	public TimerDecorator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		TjiwA3OzG8bfWkQG5cD9();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				Height = 16f;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			case 1:
				H3JKFYOz7wDB0ScQu3vh(this, 16f);
				num = 2;
				break;
			}
		}
	}

	protected override void CreatePaths(NRectangleF bounds)
	{
		//Discarded unreachable code: IL_0041, IL_0050
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		int num = 7;
		int num2 = num;
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 1:
				AddPath((NPathPrimitive)(object)new HourMark(num3, bounds.X, bounds.Y, bounds.Width, bounds.Height));
				num2 = 5;
				break;
			case 4:
				return;
			case 7:
				AddPath((NPathPrimitive)(object)new Circle(bounds.X, bounds.Y, bounds.Width, bounds.Height));
				num2 = 6;
				break;
			case 5:
				num3++;
				num2 = 2;
				break;
			default:
				if (num3 >= 12)
				{
					num2 = 3;
					break;
				}
				goto case 1;
			case 3:
				AddPath((NPathPrimitive)(object)new Arrows(3.05f, bounds.X, bounds.Y, bounds.Width, bounds.Height));
				num2 = 4;
				break;
			case 6:
				num3 = 0;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void TjiwA3OzG8bfWkQG5cD9()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static void H3JKFYOz7wDB0ScQu3vh(object P_0, float value)
	{
		((BaseDecorator)P_0).Width = value;
	}

	internal static bool cP8GPgOzV6HGqtWO6QMK()
	{
		return u0yOujOzUumaq8bNTWRT == null;
	}

	internal static TimerDecorator PeHcAQOzAD30g9p1E7wV()
	{
		return u0yOujOzUumaq8bNTWRT;
	}
}
