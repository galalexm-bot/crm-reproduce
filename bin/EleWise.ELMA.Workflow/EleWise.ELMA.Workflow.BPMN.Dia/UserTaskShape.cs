using System;
using System.Drawing;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Decorators;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Tasks;

[Serializable]
public class UserTaskShape : TaskShape
{
	internal static UserTaskShape UBARWOZK2p9U5YDxb6iY;

	protected override Color StrokeColor => WoXdQNZKIWMn3sytK9T0(156, 164, 175);

	protected override Color StartColor => WoXdQNZKIWMn3sytK9T0(244, 244, 244);

	protected override Color EndColor => WoXdQNZKIWMn3sytK9T0(244, 244, 244);

	protected override FontStyle fontStyle => FontStyle.Bold;

	protected override Color colorFont => WoXdQNZKIWMn3sytK9T0(40, 84, 165);

	public override void UpdateDecorators(Element element)
	{
		//Discarded unreachable code: IL_00de, IL_00ed
		int num = 6;
		int num2 = num;
		UserTaskElement userTaskElement = default(UserTaskElement);
		while (true)
		{
			switch (num2)
			{
			case 6:
				base.UpdateDecorators(element);
				num2 = 5;
				continue;
			case 2:
				AddDecorator<UserTaskDecorator>(DecoratorPosition.TopLeft);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d == 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
				if (!BYoEVsZKiRX88bjplKBh(userTaskElement))
				{
					num2 = 4;
					continue;
				}
				goto case 3;
			case 3:
				AddDecorator<TimeLimitDecorator>(DecoratorPosition.BottomCenter);
				num2 = 7;
				continue;
			case 5:
				userTaskElement = element as UserTaskElement;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b == 0)
				{
					num2 = 2;
				}
				continue;
			case 4:
				return;
			case 7:
				return;
			}
			if (userTaskElement != null)
			{
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d == 0)
				{
					num2 = 1;
				}
				continue;
			}
			return;
		}
	}

	public UserTaskShape()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		HtytLNZKanM9YRj5dpXL();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool BYoEVsZKiRX88bjplKBh(object P_0)
	{
		return ((UserTaskElement)P_0).LimitByTime;
	}

	internal static bool BkEOZsZKoQedGls4aFSh()
	{
		return UBARWOZK2p9U5YDxb6iY == null;
	}

	internal static UserTaskShape kNmXodZKF1FkVkEnQTFj()
	{
		return UBARWOZK2p9U5YDxb6iY;
	}

	internal static Color WoXdQNZKIWMn3sytK9T0(int P_0, int P_1, int P_2)
	{
		return Color.FromArgb(P_0, P_1, P_2);
	}

	internal static void HtytLNZKanM9YRj5dpXL()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
