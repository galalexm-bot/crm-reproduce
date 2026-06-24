using System.Drawing;
using System.Drawing.Drawing2D;
using EleWise.ELMA.Workflow.Diagrams.Shapes;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.GraphicsCore;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Decorators;

public class IndicatorDecorator : BaseDecorator
{
	private class IndicatorPath : NCustomPath
	{
		private static object hcGHqMvmzMOKlFDW7x2d;

		public IndicatorPath(float x, float y, float w, float h)
		{
			//Discarded unreachable code: IL_0030, IL_0035
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Expected O, but got Unknown
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
			((NCustomPath)this)._002Ector((GraphicsPath)EfrMTKvtZTLMqApxrQeA(), (PathType)0);
			int num = 1;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 != 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				case 4:
					i0aDYvvt8yLYQAPLKIoR(this, (object)new NStyle());
					num = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e != 0)
					{
						num = 0;
					}
					break;
				case 2:
					DVFMsivtYhy3O50C8Zlu(this, x, y);
					num = 4;
					break;
				case 3:
					return;
				case 1:
					qs8mJIvtv43Yapy4SjcD(this, w / 32f, h / 32f, new NPointF(0f, 0f));
					num = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 == 0)
					{
						num = 2;
					}
					break;
				default:
					Qc58rcvtJt1DBKAXtFqf(YM99iDvtsrNLe4s2hgjn(this), ShapeHelper.DefaultThinStrokeStyle);
					num = 3;
					break;
				}
			}
		}

		private static GraphicsPath CreatePath()
		{
			GraphicsPath graphicsPath = new GraphicsPath(FillMode.Winding);
			FontFamily family = new FontFamily((string)EuC4JNvtlLCoQk43O4Cb(0x5F800F5B ^ 0x5F827F6D));
			int style = 1;
			int num = 20;
			graphicsPath.AddString(origin: new Point(-5, 6), format: StringFormat.GenericDefault, s: SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x65B7F624 ^ 0x65B52D9E), family: family, style: style, emSize: num);
			return graphicsPath;
		}

		internal static object EfrMTKvtZTLMqApxrQeA()
		{
			return CreatePath();
		}

		internal static void qs8mJIvtv43Yapy4SjcD(object P_0, float P_1, float P_2, NPointF P_3)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			((NModel)P_0).ScaleModel(P_1, P_2, P_3);
		}

		internal static void DVFMsivtYhy3O50C8Zlu(object P_0, float P_1, float P_2)
		{
			((NTransformableElement)P_0).Translate(P_1, P_2);
		}

		internal static void i0aDYvvt8yLYQAPLKIoR(object P_0, object P_1)
		{
			((NStyleableElement)P_0).set_Style((NStyle)P_1);
		}

		internal static object YM99iDvtsrNLe4s2hgjn(object P_0)
		{
			return ((NStyleableElement)P_0).get_Style();
		}

		internal static void Qc58rcvtJt1DBKAXtFqf(object P_0, object P_1)
		{
			((NStyle)P_0).set_StrokeStyle((NStrokeStyle)P_1);
		}

		internal static bool alYVoyvtKjvBYUFwajIF()
		{
			return hcGHqMvmzMOKlFDW7x2d == null;
		}

		internal static IndicatorPath x4ilXivtOHuoaNVoPPW1()
		{
			return (IndicatorPath)hcGHqMvmzMOKlFDW7x2d;
		}

		internal static object EuC4JNvtlLCoQk43O4Cb(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}
	}

	private static IndicatorDecorator SKuPqEO4KNFpnpwqEfwi;

	public IndicatorDecorator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		osjlBxO4vPyfrvvevEH8();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				fVRxChO48xK5ueLZR38e(this, 16f);
				num = 2;
				continue;
			case 2:
				return;
			}
			gV45LGO4Y3I2karWPAKh(this, 16f);
			num = 1;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 == 0)
			{
				num = 0;
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
				AddPath((NPathPrimitive)(object)new IndicatorPath(bounds.X, bounds.Y, bounds.Width, bounds.Height));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void osjlBxO4vPyfrvvevEH8()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static void gV45LGO4Y3I2karWPAKh(object P_0, float value)
	{
		((BaseDecorator)P_0).Width = value;
	}

	internal static void fVRxChO48xK5ueLZR38e(object P_0, float value)
	{
		((BaseDecorator)P_0).Height = value;
	}

	internal static bool tupI41O4OsZSVydlbW9n()
	{
		return SKuPqEO4KNFpnpwqEfwi == null;
	}

	internal static IndicatorDecorator KWN9AfO4ZHwc7jv7UDd7()
	{
		return SKuPqEO4KNFpnpwqEfwi;
	}
}
