using System.Drawing;
using System.Drawing.Drawing2D;
using EleWise.ELMA.Workflow.Diagrams.Shapes;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.GraphicsCore;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Decorators;

public class ConditionDecorator : BaseDecorator
{
	private class Diamond : NCustomPath
	{
		internal static object EwPWpJvmkapdsKEtrUuv;

		public Diamond(float x, float y, float w, float h)
		{
			//Discarded unreachable code: IL_0029
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Expected O, but got Unknown
			//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Expected O, but got Unknown
			fvWABNvmAvIbEbnvhpHV();
			((NCustomPath)this)._002Ector((GraphicsPath)RBcmFPvmGW1xIRhdBlIk(x, y, w, h), (PathType)1);
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					((NStyle)piTQydvm2oTu1FUYaOOM(this)).set_StrokeStyle((NStrokeStyle)O3D0BrvmoHaDbURPNgt8());
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 == 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					zYgK1IvmiTe0IT01d1ER(((NStyleableElement)this).get_Style(), (object)new NColorFillStyle(DpXoduvmFogR41afELnF()));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				case 3:
					bhs3tLvm7dZATHlGjCeb(this, (object)new NStyle());
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d != 0)
					{
						num2 = 2;
					}
					break;
				}
			}
		}

		private static GraphicsPath CreatePath(float x, float y, float w, float h)
		{
			int num = 3;
			int num2 = num;
			GraphicsPath graphicsPath = default(GraphicsPath);
			while (true)
			{
				switch (num2)
				{
				case 2:
					TCPgG5vmIbtGMXOFqRJv(graphicsPath, new PointF[4]
					{
						new PointF(x, y + h / 2f),
						new PointF(x + w / 2f, y),
						new PointF(x + w, y + h / 2f),
						new PointF(x + w / 2f, y + h)
					});
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 != 0)
					{
						num2 = 0;
					}
					break;
				default:
					graphicsPath.CloseAllFigures();
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					graphicsPath = new GraphicsPath();
					num2 = 2;
					break;
				case 1:
					return graphicsPath;
				}
			}
		}

		internal static void fvWABNvmAvIbEbnvhpHV()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}

		internal static object RBcmFPvmGW1xIRhdBlIk(float x, float y, float w, float h)
		{
			return CreatePath(x, y, w, h);
		}

		internal static void bhs3tLvm7dZATHlGjCeb(object P_0, object P_1)
		{
			((NStyleableElement)P_0).set_Style((NStyle)P_1);
		}

		internal static object piTQydvm2oTu1FUYaOOM(object P_0)
		{
			return ((NStyleableElement)P_0).get_Style();
		}

		internal static object O3D0BrvmoHaDbURPNgt8()
		{
			return ShapeHelper.DefaultThickStrokeStyle;
		}

		internal static Color DpXoduvmFogR41afELnF()
		{
			return Color.White;
		}

		internal static void zYgK1IvmiTe0IT01d1ER(object P_0, object P_1)
		{
			((NStyle)P_0).set_FillStyle((NFillStyle)P_1);
		}

		internal static bool bSyaOjvmUIJuGerxGmea()
		{
			return EwPWpJvmkapdsKEtrUuv == null;
		}

		internal static Diamond hEd4V2vmV6mJ2nYMwwk8()
		{
			return (Diamond)EwPWpJvmkapdsKEtrUuv;
		}

		internal static void TCPgG5vmIbtGMXOFqRJv(object P_0, object P_1)
		{
			((GraphicsPath)P_0).AddLines((PointF[])P_1);
		}
	}

	private static ConditionDecorator ARjICGOwfdOUwbupT7B3;

	public ConditionDecorator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		I65SY2OwjOr8KYbENZyF();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			default:
				Width = 12f;
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 != 0)
				{
					num = 1;
				}
				break;
			case 1:
				hKsoxROwR4WKi5TamZ4c(this, 12f);
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 == 0)
				{
					num = 2;
				}
				break;
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
				AddPath((NPathPrimitive)(object)new Diamond(bounds.X, bounds.Y, bounds.Width, bounds.Height));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void I65SY2OwjOr8KYbENZyF()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static void hKsoxROwR4WKi5TamZ4c(object P_0, float value)
	{
		((BaseDecorator)P_0).Height = value;
	}

	internal static bool GNRDdJOw92v4dyfvxwWi()
	{
		return ARjICGOwfdOUwbupT7B3 == null;
	}

	internal static ConditionDecorator EoPvSMOwWkRXEwugGxdc()
	{
		return ARjICGOwfdOUwbupT7B3;
	}
}
