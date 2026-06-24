using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.Dom;
using Nevron.GraphicsCore;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Events;

[Serializable]
public class EndEventHintShape : EndEventShape
{
	private static EndEventHintShape vshqGHOxFKUALZXKgPjm;

	protected override float DefaultWidth => 24f;

	protected override float DefaultHeight => 24f;

	public override void elipseBig()
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected O, but got Unknown
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected O, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected O, but got Unknown
		int num = 4;
		int num2 = num;
		NCustomPath val = default(NCustomPath);
		NStyle val4 = default(NStyle);
		NCustomPath val3 = default(NCustomPath);
		NStyle val2 = default(NStyle);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				gpULwhOx1x7hOTrfJAcI(((NCompositeShape)this).get_Primitives(), val);
				num2 = 5;
				break;
			case 6:
				val4 = new NStyle();
				num2 = 11;
				break;
			case 9:
				gpULwhOx1x7hOTrfJAcI(aQZdAiOxhbZUVm04fQlM(this), val3);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 != 0)
				{
					num2 = 0;
				}
				break;
			case 11:
				zI7ZBHOxxPFVdJLYCWpU(val4, (object)new NGradientFillStyle((GradientStyle)0, (GradientVariant)0, lK9ZqPOxNLhK2tKo5VKa(), lK9ZqPOxNLhK2tKo5VKa()));
				num2 = 5;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 == 0)
				{
					num2 = 10;
				}
				break;
			case 10:
				val4.set_StrokeStyle(new NStrokeStyle(0.01f, lK9ZqPOxNLhK2tKo5VKa()));
				num2 = 12;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1a2d7634479d44fb8d3718c31b05f73c == 0)
				{
					num2 = 5;
				}
				break;
			case 3:
				val2 = new NStyle();
				num2 = 7;
				break;
			case 5:
				val3 = new NCustomPath((GraphicsPath)tVAcKqOxeekq3Ky2WIIM(kYE5AyOxaiZIRuX8OcFl(this) / 2f, hoVdJeOxrJpcd1cp1OYF(this) + 2f, 0.01f, 0.01f), (PathType)1);
				num2 = 6;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 != 0)
				{
					num2 = 2;
				}
				break;
			case 7:
				zI7ZBHOxxPFVdJLYCWpU(val2, (object)new NGradientFillStyle((GradientStyle)0, (GradientVariant)0, lK9ZqPOxNLhK2tKo5VKa(), Color.White));
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 == 0)
				{
					num2 = 1;
				}
				break;
			case 8:
				MJHEiAOxSsOqK8lLWOrb(val, val2);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 == 0)
				{
					num2 = 1;
				}
				break;
			case 12:
				MJHEiAOxSsOqK8lLWOrb(val3, val4);
				num2 = 9;
				break;
			case 2:
				val2.set_StrokeStyle(new NStrokeStyle(0.01f, lK9ZqPOxNLhK2tKo5VKa()));
				num2 = 5;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f8a84e2cb374827a50ba2cbcf11cf48 == 0)
				{
					num2 = 8;
				}
				break;
			case 0:
				return;
			case 4:
				val = new NCustomPath((GraphicsPath)tVAcKqOxeekq3Ky2WIIM(kYE5AyOxaiZIRuX8OcFl(this) + 2f, hoVdJeOxrJpcd1cp1OYF(this) / 2f, 0.01f, 0.01f), (PathType)1);
				num2 = 3;
				break;
			}
		}
	}

	private static GraphicsPath CreatePathBase(float x, float y, float w, float h)
	{
		GraphicsPath graphicsPath = new GraphicsPath();
		BgMuMZOxEellbe4cqgFO(graphicsPath, x, y, w, h);
		Q8i48ZOxwm9UNxMLMc17(graphicsPath);
		return graphicsPath;
	}

	public EndEventHintShape()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		ymRvXmOx4h2xrCea3f9c();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static float kYE5AyOxaiZIRuX8OcFl(object P_0)
	{
		return ((EventShape)P_0).DefaultWidth;
	}

	internal static float hoVdJeOxrJpcd1cp1OYF(object P_0)
	{
		return ((EventShape)P_0).DefaultHeight;
	}

	internal static object tVAcKqOxeekq3Ky2WIIM(float x, float y, float w, float h)
	{
		return CreatePathBase(x, y, w, h);
	}

	internal static Color lK9ZqPOxNLhK2tKo5VKa()
	{
		return Color.White;
	}

	internal static void zI7ZBHOxxPFVdJLYCWpU(object P_0, object P_1)
	{
		((NStyle)P_0).set_FillStyle((NFillStyle)P_1);
	}

	internal static void MJHEiAOxSsOqK8lLWOrb(object P_0, object P_1)
	{
		((NStyleableElement)P_0).set_Style((NStyle)P_1);
	}

	internal static void gpULwhOx1x7hOTrfJAcI(object P_0, object P_1)
	{
		((NDiagramElementCollection)P_0).AddChild((INNode)P_1);
	}

	internal static object aQZdAiOxhbZUVm04fQlM(object P_0)
	{
		return ((NCompositeShape)P_0).get_Primitives();
	}

	internal static bool RIbytWOxiyB99UpsVt6m()
	{
		return vshqGHOxFKUALZXKgPjm == null;
	}

	internal static EndEventHintShape j9MBWZOxIt6HkdbZ1YFj()
	{
		return vshqGHOxFKUALZXKgPjm;
	}

	internal static void BgMuMZOxEellbe4cqgFO(object P_0, float P_1, float P_2, float P_3, float P_4)
	{
		((GraphicsPath)P_0).AddLine(P_1, P_2, P_3, P_4);
	}

	internal static void Q8i48ZOxwm9UNxMLMc17(object P_0)
	{
		((GraphicsPath)P_0).CloseAllFigures();
	}

	internal static void ymRvXmOx4h2xrCea3f9c()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
