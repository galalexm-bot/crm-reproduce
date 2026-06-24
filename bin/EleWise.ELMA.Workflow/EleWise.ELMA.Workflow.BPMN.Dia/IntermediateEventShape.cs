using System;
using System.Drawing;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.Dom;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Events;

[Serializable]
public class IntermediateEventShape : EventShape
{
	private static IntermediateEventShape xdcbYgOSRwbg2BEblEc5;

	protected override Color EndColor => nF28oUOSCcUHl7ukIVr8(235, 235, 235);

	public IntermediateEventShape()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		Q4buK4OS3NIIOjN0bYrM();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 == 0)
		{
			num = 1;
		}
		NEllipsePath val = default(NEllipsePath);
		float num3 = default(float);
		float num2 = default(float);
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 3:
				val = new NEllipsePath(num3, num2, DS2S81OSTngKJraPEhZJ(this) - num3 * 2f, DefaultHeight - num2 * 2f);
				num = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b != 0)
				{
					num = 2;
				}
				break;
			case 1:
				num3 = DefaultWidth / 10f;
				num = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f == 0)
				{
					num = 4;
				}
				break;
			case 2:
				zDRkynOSpBMNO8la2rN5(jp1KWKOSQpxrjsm3jJ4g(this), val);
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 == 0)
				{
					num = 0;
				}
				break;
			case 4:
				num2 = DefaultHeight / 10f;
				num = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static void Q4buK4OS3NIIOjN0bYrM()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static float DS2S81OSTngKJraPEhZJ(object P_0)
	{
		return ((EventShape)P_0).DefaultWidth;
	}

	internal static object jp1KWKOSQpxrjsm3jJ4g(object P_0)
	{
		return ((NCompositeShape)P_0).get_Primitives();
	}

	internal static void zDRkynOSpBMNO8la2rN5(object P_0, object P_1)
	{
		((NDiagramElementCollection)P_0).AddChild((INNode)P_1);
	}

	internal static bool LxpDCrOS6R50CC306PjL()
	{
		return xdcbYgOSRwbg2BEblEc5 == null;
	}

	internal static IntermediateEventShape LfADk7OSqGHfJVR42Bku()
	{
		return xdcbYgOSRwbg2BEblEc5;
	}

	internal static Color nF28oUOSCcUHl7ukIVr8(int P_0, int P_1, int P_2)
	{
		return Color.FromArgb(P_0, P_1, P_2);
	}
}
