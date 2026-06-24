using System;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Decorators;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Tasks;

[Serializable]
public abstract class TaskShape : BPMNRectangleShape
{
	internal static TaskShape tBonlDZKTNdVGfuSAxhM;

	public override void UpdateDecorators(Element element)
	{
		//Discarded unreachable code: IL_0071, IL_0080
		int num = 4;
		TaskElement taskElement = default(TaskElement);
		Type type = default(Type);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					return;
				case 1:
					return;
				case 3:
					taskElement = element as TaskElement;
					num2 = 5;
					continue;
				case 5:
					if (taskElement == null)
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d == 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					if (!shFwLGZKMktqxAmYnwHN(type, null))
					{
						return;
					}
					num2 = 2;
					continue;
				case 2:
					AddDecorator(type, DecoratorPosition.BottomCenter);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 == 0)
					{
						num2 = 7;
					}
					continue;
				case 4:
					base.UpdateDecorators(element);
					num2 = 3;
					continue;
				}
				break;
			}
			type = wwDeMQZKCuuklGcW79EN(taskElement.Marker);
			num = 6;
		}
	}

	public static Type GetMarkerDecoratorType(TaskMarker marker)
	{
		//Discarded unreachable code: IL_005b, IL_006a
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				switch (marker)
				{
				default:
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 == 0)
					{
						num2 = 0;
					}
					goto end_IL_0012;
				case TaskMarker.Loop:
					break;
				case TaskMarker.Condition:
					return typeof(ConditionDecorator);
				case TaskMarker.MultiInstance:
					return HTqM9jZKkgKIIW9fEwxA(typeof(MultiInstanceDecorator).TypeHandle);
				}
				goto case 2;
			case 2:
				return HTqM9jZKkgKIIW9fEwxA(typeof(LoopDecorator).TypeHandle);
			default:
				{
					return null;
				}
				end_IL_0012:
				break;
			}
		}
	}

	protected TaskShape()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		afefdrZKUuc3tCGA82kj();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type wwDeMQZKCuuklGcW79EN(TaskMarker marker)
	{
		return GetMarkerDecoratorType(marker);
	}

	internal static bool shFwLGZKMktqxAmYnwHN(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static bool AnN2xgZKQK1I09QiOy7S()
	{
		return tBonlDZKTNdVGfuSAxhM == null;
	}

	internal static TaskShape TWxEdPZKpKv1uSgaVhPQ()
	{
		return tBonlDZKTNdVGfuSAxhM;
	}

	internal static Type HTqM9jZKkgKIIW9fEwxA(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static void afefdrZKUuc3tCGA82kj()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
