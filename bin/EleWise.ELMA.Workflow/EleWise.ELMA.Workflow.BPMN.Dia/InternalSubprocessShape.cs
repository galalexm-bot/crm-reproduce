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
public class InternalSubprocessShape : SubProcessShape
{
	internal static InternalSubprocessShape mqpLqcOe1bRljkFxrK3a;

	protected override Color StrokeColor => Color.FromArgb(126, 159, 234);

	protected override Color StartColor => mN7qn8ONK3yaeamwBniI(200, 213, 255);

	protected override Color EndColor => mN7qn8ONK3yaeamwBniI(200, 213, 255);

	public override void UpdateDecorators(Element element)
	{
		int num = 3;
		SubProcessElement subProcessElement = default(SubProcessElement);
		Type markerDecoratorType = default(Type);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					AddDecorator<InternalSubProcessDecorator>(TMOhH5Oew4EQ3fCpHh9F(this));
					num2 = 4;
					continue;
				case 3:
					break;
				case 5:
					if (subProcessElement == null)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f == 0)
						{
							num2 = 1;
						}
					}
					else
					{
						markerDecoratorType = TaskShape.GetMarkerDecoratorType(AhxLrdOe4glNNyfIxWle(subProcessElement));
						num2 = 6;
					}
					continue;
				case 7:
					AddDecorator(markerDecoratorType, DecoratorPosition.BottomCenter);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 == 0)
					{
						num2 = 0;
					}
					continue;
				case 0:
					return;
				case 4:
					subProcessElement = element as SubProcessElement;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 == 0)
					{
						num2 = 5;
					}
					continue;
				case 6:
					if (!E1RMP3OezXmnHSTrEtOd(markerDecoratorType, null))
					{
						return;
					}
					num2 = 7;
					continue;
				case 1:
					return;
				}
				break;
			}
			base.UpdateDecorators(element);
			num = 2;
		}
	}

	public InternalSubprocessShape()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		nq98C5ONO3NDb1aqxVwl();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static DecoratorPosition TMOhH5Oew4EQ3fCpHh9F(object P_0)
	{
		return ((SubProcessShape)P_0).SubProcessDecoratorPosition;
	}

	internal static TaskMarker AhxLrdOe4glNNyfIxWle(object P_0)
	{
		return ((SubProcessElement)P_0).Marker;
	}

	internal static bool E1RMP3OezXmnHSTrEtOd(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static bool Qnwt4QOehX36rTjJ5qjm()
	{
		return mqpLqcOe1bRljkFxrK3a == null;
	}

	internal static InternalSubprocessShape rQTMouOeEcssORSEtEWe()
	{
		return mqpLqcOe1bRljkFxrK3a;
	}

	internal static Color mN7qn8ONK3yaeamwBniI(int P_0, int P_1, int P_2)
	{
		return Color.FromArgb(P_0, P_1, P_2);
	}

	internal static void nq98C5ONO3NDb1aqxVwl()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
