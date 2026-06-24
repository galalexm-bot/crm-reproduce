using System.Drawing;
using System.Drawing.Drawing2D;
using EleWise.ELMA.Workflow.Diagrams.Shapes;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.GraphicsCore;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Decorators;

public class BoundaryInterruptingDecorator : BaseDecorator
{
	internal class Circle : NCustomPath
	{
		private static Circle Sb0kBRvm51NHIAmHxPZN;

		private Color StartColor => Color.White;

		private Color EndColor => hqWYATvmfPr2Fl84o2PO(235, 235, 235);

		public Circle(float x, float y, float w, float h)
		{
			//Discarded unreachable code: IL_0030
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Expected O, but got Unknown
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0097: Expected O, but got Unknown
			//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
			yLuuFEvmc70VK2js2Shm();
			((NCustomPath)this)._002Ector((GraphicsPath)rbFXkavmPhJm3wl7V5tS(), (PathType)1);
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 4:
					((NTransformableElement)this).Translate(x, y);
					num = 5;
					break;
				case 1:
					gX7wQlvmHXSfKIy60qjb(a2WkBkvmusNB5M1b8K6Y(this), (object)new NColorFillStyle(HjVTLWvmnr9aAkfvxXIU()));
					num = 3;
					break;
				case 5:
				{
					D9fKiRvmd3bL6XNBGpou(this, (object)new NStyle());
					int num2 = 2;
					num = num2;
					break;
				}
				case 3:
					return;
				case 2:
					((NStyle)a2WkBkvmusNB5M1b8K6Y(this)).set_StrokeStyle((NStrokeStyle)nW65hJvmDmNu8IYTtWG9());
					num = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 == 0)
					{
						num = 0;
					}
					break;
				default:
					IKkLTDvmX3lgoNvOjAVb(this, w / 32f, h / 32f, new NPointF(0f, 0f));
					num = 4;
					break;
				}
			}
		}

		private static GraphicsPath CreatePath()
		{
			GraphicsPath graphicsPath = new GraphicsPath();
			Xc5C0avmL0S7NYuUnwcs(graphicsPath, 0f, 0f, 32f, 32f);
			return graphicsPath;
		}

		internal static void yLuuFEvmc70VK2js2Shm()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}

		internal static object rbFXkavmPhJm3wl7V5tS()
		{
			return CreatePath();
		}

		internal static void IKkLTDvmX3lgoNvOjAVb(object P_0, float P_1, float P_2, NPointF P_3)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			((NModel)P_0).ScaleModel(P_1, P_2, P_3);
		}

		internal static void D9fKiRvmd3bL6XNBGpou(object P_0, object P_1)
		{
			((NStyleableElement)P_0).set_Style((NStyle)P_1);
		}

		internal static object a2WkBkvmusNB5M1b8K6Y(object P_0)
		{
			return ((NStyleableElement)P_0).get_Style();
		}

		internal static object nW65hJvmDmNu8IYTtWG9()
		{
			return ShapeHelper.DefaultStrokeStyle;
		}

		internal static Color HjVTLWvmnr9aAkfvxXIU()
		{
			return Color.White;
		}

		internal static void gX7wQlvmHXSfKIy60qjb(object P_0, object P_1)
		{
			((NStyle)P_0).set_FillStyle((NFillStyle)P_1);
		}

		internal static bool wAkcOxvmgxECD5pXFFaT()
		{
			return Sb0kBRvm51NHIAmHxPZN == null;
		}

		internal static Circle OZcQHDvmBcGiVOZxYDCo()
		{
			return Sb0kBRvm51NHIAmHxPZN;
		}

		internal static void Xc5C0avmL0S7NYuUnwcs(object P_0, float P_1, float P_2, float P_3, float P_4)
		{
			((GraphicsPath)P_0).AddEllipse(P_1, P_2, P_3, P_4);
		}

		internal static Color hqWYATvmfPr2Fl84o2PO(int P_0, int P_1, int P_2)
		{
			return Color.FromArgb(P_0, P_1, P_2);
		}
	}

	internal class SmallCircle : NCustomPath
	{
		internal static SmallCircle f9MejQvm9nTc6BTc1K5C;

		public SmallCircle(float x, float y, float w, float h)
		{
			//Discarded unreachable code: IL_0030, IL_0035
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected O, but got Unknown
			//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
			jXfaQPvmRfbdDUYcKt2Y();
			((NCustomPath)this)._002Ector((GraphicsPath)vhR92rvm6BLhDfB8Uf15(), (PathType)0);
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 != 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 0:
					return;
				case 3:
					EvVGe0vmTTkLNxpeGp6M(this, (object)new NStyle());
					num = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 == 0)
					{
						num = 4;
					}
					break;
				case 2:
					cHV07Jvm3gQkZpY45pge(this, x, y);
					num = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b == 0)
					{
						num = 3;
					}
					break;
				case 4:
					tji47evmC5thU6GSr1rK(P8NroqvmQEviVNrg8ePQ(this), pZOXHQvmp0W4yHghDrXg());
					num = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d == 0)
					{
						num = 0;
					}
					break;
				case 1:
					xlVRlQvmqpLwCjDLpWdi(this, w / 32f, h / 32f, new NPointF(0f, 0f));
					num = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 == 0)
					{
						num = 1;
					}
					break;
				}
			}
		}

		private static GraphicsPath CreatePath()
		{
			GraphicsPath graphicsPath = new GraphicsPath();
			qBZFKKvmMXMT1Wc6xQTu(graphicsPath, 3.2f, 3.2f, 25.6f, 25.6f);
			return graphicsPath;
		}

		internal static void jXfaQPvmRfbdDUYcKt2Y()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}

		internal static object vhR92rvm6BLhDfB8Uf15()
		{
			return CreatePath();
		}

		internal static void xlVRlQvmqpLwCjDLpWdi(object P_0, float P_1, float P_2, NPointF P_3)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			((NModel)P_0).ScaleModel(P_1, P_2, P_3);
		}

		internal static void cHV07Jvm3gQkZpY45pge(object P_0, float P_1, float P_2)
		{
			((NTransformableElement)P_0).Translate(P_1, P_2);
		}

		internal static void EvVGe0vmTTkLNxpeGp6M(object P_0, object P_1)
		{
			((NStyleableElement)P_0).set_Style((NStyle)P_1);
		}

		internal static object P8NroqvmQEviVNrg8ePQ(object P_0)
		{
			return ((NStyleableElement)P_0).get_Style();
		}

		internal static object pZOXHQvmp0W4yHghDrXg()
		{
			return ShapeHelper.DefaultStrokeStyle;
		}

		internal static void tji47evmC5thU6GSr1rK(object P_0, object P_1)
		{
			((NStyle)P_0).set_StrokeStyle((NStrokeStyle)P_1);
		}

		internal static bool HpbLOYvmWekxVpm57LgS()
		{
			return f9MejQvm9nTc6BTc1K5C == null;
		}

		internal static SmallCircle kkYqhyvmjXDsqdhmSi89()
		{
			return f9MejQvm9nTc6BTc1K5C;
		}

		internal static void qBZFKKvmMXMT1Wc6xQTu(object P_0, float P_1, float P_2, float P_3, float P_4)
		{
			((GraphicsPath)P_0).AddEllipse(P_1, P_2, P_3, P_4);
		}
	}

	internal static BoundaryInterruptingDecorator Q52q9MOwmcTMhYNNnP9D;

	public BoundaryInterruptingDecorator()
	{
		//Discarded unreachable code: IL_001a, IL_001f
		nAs5mhOw5Q7Ie3Kgdnhe();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				zWxCdTOwgS0vJmMBwEga(this, 32f);
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1a2d7634479d44fb8d3718c31b05f73c != 0)
				{
					num = 1;
				}
				break;
			case 1:
				WIXSIAOwBdKENunHahjn(this, 32f);
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
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
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				AddPath((NPathPrimitive)(object)new Circle(bounds.X, bounds.Y, bounds.Width, bounds.Height));
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				AddPath((NPathPrimitive)(object)new SmallCircle(bounds.X, bounds.Y, bounds.Width, bounds.Height));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void nAs5mhOw5Q7Ie3Kgdnhe()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static void zWxCdTOwgS0vJmMBwEga(object P_0, float value)
	{
		((BaseDecorator)P_0).Width = value;
	}

	internal static void WIXSIAOwBdKENunHahjn(object P_0, float value)
	{
		((BaseDecorator)P_0).Height = value;
	}

	internal static bool OrAxByOwtXSssV5WN2SD()
	{
		return Q52q9MOwmcTMhYNNnP9D == null;
	}

	internal static BoundaryInterruptingDecorator D9F9REOwbVB1cHHrchMw()
	{
		return Q52q9MOwmcTMhYNNnP9D;
	}
}
