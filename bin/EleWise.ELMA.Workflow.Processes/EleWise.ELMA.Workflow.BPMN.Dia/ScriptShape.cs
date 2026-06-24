using System;
using System.Drawing;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Decorators;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Tasks;

[Serializable]
public class ScriptShape : TaskShape
{
	internal static ScriptShape ATrd7wb9xph94VYDQtg;

	protected override Color StrokeColor => Color.FromArgb(202, 188, 124);

	protected override Color StartColor => EFPnDLbNtToftle9pkP(230, 219, 170);

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
			case 2:
				base.UpdateDecorators(element);
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_a9f4f79195cf4308a30b686c5cb386e5 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				AddDecorator<ScriptTaskDecorator>(DecoratorPosition.TopLeft);
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_98890646a18d4a91b352a4ea5d1be319 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public ScriptShape()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		OSZpncbdeW7NewQXuUQ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_58d62f4202494b18a0cc2631d85b3ead == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool qFX3r5bTvLk6NJ5jNL0()
	{
		return ATrd7wb9xph94VYDQtg == null;
	}

	internal static ScriptShape pcRSeebcn4kHfvW09it()
	{
		return ATrd7wb9xph94VYDQtg;
	}

	internal static Color EFPnDLbNtToftle9pkP(int P_0, int P_1, int P_2)
	{
		return Color.FromArgb(P_0, P_1, P_2);
	}

	internal static void OSZpncbdeW7NewQXuUQ()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}
}
