using System;
using System.Drawing;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Decorators;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Tasks;

[Serializable]
public class MessageReceiveShape : TaskShape
{
	internal static MessageReceiveShape YSBnmwb3ZR7p182NkDC;

	protected override Color StrokeColor => Color.FromArgb(202, 188, 124);

	protected override Color StartColor => Color.FromArgb(230, 219, 170);

	protected override Color EndColor => CYR6dRb86pm38qdbHoS(230, 219, 170);

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
				AddDecorator<MessageReceiveDecorator>(DecoratorPosition.TopLeft);
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_a9f4f79195cf4308a30b686c5cb386e5 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				OBHwgIbFPvScvQZKsuu(this, element);
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3600d9e606e544d2b67d1fc1ad9becc3 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public MessageReceiveShape()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		ibW8ePbwN8Y99EMlaDZ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3059bb5cee2f4eb68ccea048bb8e848c != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void OBHwgIbFPvScvQZKsuu(object P_0, object P_1)
	{
		((TaskShape)P_0).UpdateDecorators((Element)P_1);
	}

	internal static bool EEKPFGbhJBFssdRMDlb()
	{
		return YSBnmwb3ZR7p182NkDC == null;
	}

	internal static MessageReceiveShape pCJ2wubx9gnkO9v3WAn()
	{
		return YSBnmwb3ZR7p182NkDC;
	}

	internal static Color CYR6dRb86pm38qdbHoS(int P_0, int P_1, int P_2)
	{
		return Color.FromArgb(P_0, P_1, P_2);
	}

	internal static void ibW8ePbwN8Y99EMlaDZ()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}
}
