using EleWise.ELMA.Workflow.Diagrams.Shapes.Decorators;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.Dom;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Decorators;

public abstract class PaintableDecorator : Decorator, INPaintable, INNode
{
	internal static PaintableDecorator aMMVCwO4GVWtGAGd5LwW;

	public override void PaintForeground(NPaintContext context)
	{
		//Discarded unreachable code: IL_0078, IL_0087, IL_00a9, IL_00b8
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (LwIPLrO4oojnv8r87nUH(this) is INPaintable)
				{
					num2 = 5;
					continue;
				}
				break;
			case 4:
				if (LwIPLrO4oojnv8r87nUH(this) == null)
				{
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 1;
			case 5:
				return;
			case 2:
				return;
			case 3:
				return;
			}
			Paint(context);
			num2 = 2;
		}
	}

	public abstract void Paint(NPaintContext context);

	protected PaintableDecorator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object LwIPLrO4oojnv8r87nUH(object P_0)
	{
		return ((NDiagramNode)P_0).get_ParentNode();
	}

	internal static bool BKMRAPO47HPKvC1XCpTE()
	{
		return aMMVCwO4GVWtGAGd5LwW == null;
	}

	internal static PaintableDecorator Io3y4KO422yu6NSFG4m3()
	{
		return aMMVCwO4GVWtGAGd5LwW;
	}
}
