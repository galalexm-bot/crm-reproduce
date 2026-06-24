using System;
using System.Drawing;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Decorators;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Tasks;

[Serializable]
public class ManualTaskShape : TaskShape
{
	private static ManualTaskShape BI3cvDZKJDdTqwGREwaP;

	protected override Color StrokeColor => Color.FromArgb(156, 164, 175);

	protected override Color StartColor => Color.FromArgb(222, 227, 231);

	protected override Color EndColor => Color.FromArgb(222, 227, 231);

	public override void UpdateDecorators(Element element)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				base.UpdateDecorators(element);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				AddDecorator<ManualTaskDecorator>(DecoratorPosition.TopLeft);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public ManualTaskShape()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		WhFrPJZKybqT9TkWr9BD();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool K8lNkGZKlYo9dKjNWPcA()
	{
		return BI3cvDZKJDdTqwGREwaP == null;
	}

	internal static ManualTaskShape qWFStUZK0FikZpLx5iUE()
	{
		return BI3cvDZKJDdTqwGREwaP;
	}

	internal static void WhFrPJZKybqT9TkWr9BD()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
