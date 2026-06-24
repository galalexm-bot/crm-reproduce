using System;
using System.Drawing;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Decorators;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Tasks;

[Serializable]
public class NotificationShape : TaskShape
{
	private static NotificationShape a2eDaaZKjkuoLMJkmQkY;

	protected override Color StrokeColor => Color.FromArgb(245, 225, 0);

	protected override Color StartColor => oJSggvZKq92iJWi6oPiS(255, 255, 134);

	protected override Color EndColor => oJSggvZKq92iJWi6oPiS(255, 255, 134);

	public override void UpdateDecorators(Element element)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				AddDecorator<NotificationDecorator>(DecoratorPosition.TopLeft);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				base.UpdateDecorators(element);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	public NotificationShape()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		E14fvAZK3QSPIDPWRd5k();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool bofLDyZKRSCOt455s3DD()
	{
		return a2eDaaZKjkuoLMJkmQkY == null;
	}

	internal static NotificationShape qnvNEAZK6P4ceCRD5KpV()
	{
		return a2eDaaZKjkuoLMJkmQkY;
	}

	internal static Color oJSggvZKq92iJWi6oPiS(int P_0, int P_1, int P_2)
	{
		return Color.FromArgb(P_0, P_1, P_2);
	}

	internal static void E14fvAZK3QSPIDPWRd5k()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
