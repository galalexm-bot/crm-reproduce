using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.Dom;
using Nevron.GraphicsCore;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Events;

[Serializable]
public class StartEventHintShape : StartEventShape
{
	private static StartEventHintShape G8PeKFOSMx5nkGnrPB9V;

	protected override float DefaultWidth => 24f;

	protected override float DefaultHeight => 24f;

	public override void elipseBig()
	{
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected O, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected O, but got Unknown
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected O, but got Unknown
		int num = 6;
		NCustomPath val2 = default(NCustomPath);
		NStyle val3 = default(NStyle);
		NCustomPath val4 = default(NCustomPath);
		NStyle val = default(NStyle);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					vMnhpMOSFVmTwRWXhWsh(val2, val3);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 == 0)
					{
						num2 = 1;
					}
					continue;
				case 6:
					val2 = new NCustomPath((GraphicsPath)GBVVO8OSGxapopYdqWJq(Q6hS7gOSVRWaQl9Q3ijq(this) + 2f, oITVOdOSAtH386fNPjY6(this) / 2f, 0.01f, 0.01f), (PathType)1);
					num2 = 5;
					continue;
				case 7:
					val4 = new NCustomPath(CreatePathBase(DefaultWidth / 2f, DefaultHeight + 2f, 0.01f, 0.01f), (PathType)1);
					num2 = 8;
					continue;
				case 11:
					break;
				case 4:
					((NStyleableElement)val4).set_Style(val);
					num2 = 11;
					continue;
				case 5:
					val3 = new NStyle();
					num2 = 12;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c == 0)
					{
						num2 = 4;
					}
					continue;
				case 3:
					val.set_StrokeStyle(new NStrokeStyle(0.01f, OXd1G7OS70WlGxbWbOuf()));
					num2 = 4;
					continue;
				case 2:
					I5ecY8OSoX7IIhA7yTvO(val3, (object)new NStrokeStyle(0.01f, OXd1G7OS70WlGxbWbOuf()));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 != 0)
					{
						num2 = 0;
					}
					continue;
				case 9:
					return;
				case 10:
					opw9qbOS2tIamo3enNxp(val, (object)new NGradientFillStyle((GradientStyle)0, (GradientVariant)0, OXd1G7OS70WlGxbWbOuf(), OXd1G7OS70WlGxbWbOuf()));
					num2 = 3;
					continue;
				case 1:
					sYPfhjOSIIUrCSslF39K(aGZoiqOSiVX7wgisUYPj(this), val2);
					num2 = 7;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d != 0)
					{
						num2 = 3;
					}
					continue;
				case 12:
					opw9qbOS2tIamo3enNxp(val3, (object)new NGradientFillStyle((GradientStyle)0, (GradientVariant)0, OXd1G7OS70WlGxbWbOuf(), OXd1G7OS70WlGxbWbOuf()));
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d == 0)
					{
						num2 = 2;
					}
					continue;
				case 8:
					val = new NStyle();
					num2 = 10;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c == 0)
					{
						num2 = 6;
					}
					continue;
				}
				break;
			}
			sYPfhjOSIIUrCSslF39K(aGZoiqOSiVX7wgisUYPj(this), val4);
			num = 9;
		}
	}

	private static GraphicsPath CreatePathBase(float x, float y, float w, float h)
	{
		GraphicsPath graphicsPath = new GraphicsPath();
		graphicsPath.AddLine(x, y, w, h);
		gGDHSeOSanc5STxJMoUI(graphicsPath);
		return graphicsPath;
	}

	public StartEventHintShape()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		XMuBiNOSrEdJNojc0b3I();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static float Q6hS7gOSVRWaQl9Q3ijq(object P_0)
	{
		return ((EventShape)P_0).DefaultWidth;
	}

	internal static float oITVOdOSAtH386fNPjY6(object P_0)
	{
		return ((EventShape)P_0).DefaultHeight;
	}

	internal static object GBVVO8OSGxapopYdqWJq(float x, float y, float w, float h)
	{
		return CreatePathBase(x, y, w, h);
	}

	internal static Color OXd1G7OS70WlGxbWbOuf()
	{
		return Color.White;
	}

	internal static void opw9qbOS2tIamo3enNxp(object P_0, object P_1)
	{
		((NStyle)P_0).set_FillStyle((NFillStyle)P_1);
	}

	internal static void I5ecY8OSoX7IIhA7yTvO(object P_0, object P_1)
	{
		((NStyle)P_0).set_StrokeStyle((NStrokeStyle)P_1);
	}

	internal static void vMnhpMOSFVmTwRWXhWsh(object P_0, object P_1)
	{
		((NStyleableElement)P_0).set_Style((NStyle)P_1);
	}

	internal static object aGZoiqOSiVX7wgisUYPj(object P_0)
	{
		return ((NCompositeShape)P_0).get_Primitives();
	}

	internal static void sYPfhjOSIIUrCSslF39K(object P_0, object P_1)
	{
		((NDiagramElementCollection)P_0).AddChild((INNode)P_1);
	}

	internal static bool jmfEASOSkcQRNuAylk1f()
	{
		return G8PeKFOSMx5nkGnrPB9V == null;
	}

	internal static StartEventHintShape OGDHZKOSUa3AiZ7WQmlR()
	{
		return G8PeKFOSMx5nkGnrPB9V;
	}

	internal static void gGDHSeOSanc5STxJMoUI(object P_0)
	{
		((GraphicsPath)P_0).CloseAllFigures();
	}

	internal static void XMuBiNOSrEdJNojc0b3I()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
