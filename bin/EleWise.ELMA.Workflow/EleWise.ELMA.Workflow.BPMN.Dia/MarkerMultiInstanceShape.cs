using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Decorators;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Tasks;

public class MarkerMultiInstanceShape : MarkerShape
{
	private static MarkerMultiInstanceShape bVot4GZKP6lS1kIia6wh;

	public override void UpdateDecorators(Element element)
	{
		int num = 2;
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
				AddDecorator<MultiInstanceDecorator>();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				base.UpdateDecorators(element);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public MarkerMultiInstanceShape()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		vSQGmqZKuKL5xZCTb5Hl();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool QkQ8y7ZKXPKmpEiuKA5s()
	{
		return bVot4GZKP6lS1kIia6wh == null;
	}

	internal static MarkerMultiInstanceShape l9MJaUZKdO6jG2mjyvyK()
	{
		return bVot4GZKP6lS1kIia6wh;
	}

	internal static void vSQGmqZKuKL5xZCTb5Hl()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
