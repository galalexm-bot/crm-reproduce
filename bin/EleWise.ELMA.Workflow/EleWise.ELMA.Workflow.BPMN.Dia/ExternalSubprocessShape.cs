using System;
using System.Drawing;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.SubProcess;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Decorators;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Tasks;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.SubProcess;

[Serializable]
public class ExternalSubprocessShape : SubProcessShape
{
	private static ExternalSubprocessShape Gij8KFOe7peXIhKgD3Ft;

	protected override Color StrokeColor => yGPRdGOeajxU4kYk4EiQ(100, 210, 162);

	protected override Color StartColor => Color.FromArgb(184, 240, 208);

	protected override Color EndColor => Color.FromArgb(184, 240, 208);

	public override void UpdateDecorators(Element element)
	{
		//Discarded unreachable code: IL_0096, IL_00a5, IL_0123, IL_0132
		int num = 8;
		int num2 = num;
		Type type = default(Type);
		SubProcessElement subProcessElement = default(SubProcessElement);
		while (true)
		{
			switch (num2)
			{
			case 8:
				base.UpdateDecorators(element);
				num2 = 7;
				continue;
			case 5:
				return;
			default:
				type = zgR1MUOeIL52QZXAQmvY(bWeOuGOei8ilX82PagdF(subProcessElement));
				num2 = 9;
				continue;
			case 2:
				return;
			case 4:
				return;
			case 1:
				subProcessElement = element as SubProcessElement;
				num2 = 6;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 != 0)
				{
					num2 = 6;
				}
				continue;
			case 6:
				if (subProcessElement == null)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
				{
					num2 = 0;
				}
				continue;
			case 7:
				AddDecorator<SubProcessDecorator>(sLkjpVOeFZ6wXDFAKh4R(this));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 != 0)
				{
					num2 = 1;
				}
				continue;
			case 9:
				if (!(type != null))
				{
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			case 3:
				break;
			}
			AddDecorator(type, DecoratorPosition.BottomCenter);
			num2 = 4;
		}
	}

	public ExternalSubprocessShape()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		EeDoIjOer6q12VfvVHbA();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static DecoratorPosition sLkjpVOeFZ6wXDFAKh4R(object P_0)
	{
		return ((SubProcessShape)P_0).SubProcessDecoratorPosition;
	}

	internal static TaskMarker bWeOuGOei8ilX82PagdF(object P_0)
	{
		return ((SubProcessElement)P_0).Marker;
	}

	internal static Type zgR1MUOeIL52QZXAQmvY(TaskMarker marker)
	{
		return TaskShape.GetMarkerDecoratorType(marker);
	}

	internal static bool pyqw4YOe2pPy2P6aNtiB()
	{
		return Gij8KFOe7peXIhKgD3Ft == null;
	}

	internal static ExternalSubprocessShape GHbb5lOeouR4GSJZ5ey6()
	{
		return Gij8KFOe7peXIhKgD3Ft;
	}

	internal static Color yGPRdGOeajxU4kYk4EiQ(int P_0, int P_1, int P_2)
	{
		return Color.FromArgb(P_0, P_1, P_2);
	}

	internal static void EeDoIjOer6q12VfvVHbA()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
