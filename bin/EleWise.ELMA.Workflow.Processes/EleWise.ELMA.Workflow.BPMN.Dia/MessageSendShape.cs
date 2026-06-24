using System;
using System.Drawing;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Decorators;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Tasks;

[Serializable]
public class MessageSendShape : TaskShape
{
	internal static MessageSendShape aCNpdbbQq124pTFE6ga;

	protected override Color StrokeColor => OpjR75bM1gjNKZbl62K(202, 188, 124);

	protected override Color StartColor => OpjR75bM1gjNKZbl62K(230, 219, 170);

	protected override Color EndColor => Color.FromArgb(230, 219, 170);

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
			case 1:
				AddDecorator<MessageSendDecorator>(DecoratorPosition.TopLeft);
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_908b32727d48459090dc901d67456a14 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				KZd0jJbK4YDi2FLRfg4(this, element);
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_22be8589196e4573a0c71199212852ff == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public MessageSendShape()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		wAPnA6baBjh4OcUrBnT();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1bd128a8000b4a92bbfa94dfdfc79104 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void KZd0jJbK4YDi2FLRfg4(object P_0, object P_1)
	{
		((TaskShape)P_0).UpdateDecorators((Element)P_1);
	}

	internal static bool DYQWkSbVcjs9ZSFjq50()
	{
		return aCNpdbbQq124pTFE6ga == null;
	}

	internal static MessageSendShape kOXwmabDH9KVsWB8xsi()
	{
		return aCNpdbbQq124pTFE6ga;
	}

	internal static Color OpjR75bM1gjNKZbl62K(int P_0, int P_1, int P_2)
	{
		return Color.FromArgb(P_0, P_1, P_2);
	}

	internal static void wAPnA6baBjh4OcUrBnT()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}
}
