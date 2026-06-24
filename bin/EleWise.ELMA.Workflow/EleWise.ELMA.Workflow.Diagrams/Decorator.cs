using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.Dom;

namespace EleWise.ELMA.Workflow.Diagrams.Shapes.Decorators;

public abstract class Decorator : NDecorator
{
	private static Decorator mhEBiV1UOfD4bm5ZeNl;

	protected void PaintPath(NPaintContext context, NModel primitive, bool highlighted, bool selected)
	{
		//Discarded unreachable code: IL_0090, IL_016b, IL_017a
		int num = 8;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 8:
				if (highlighted)
				{
					num2 = 7;
					break;
				}
				goto default;
			case 5:
				context.SelectedNodes.Add((INNode)(object)primitive, null);
				num2 = 11;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 != 0)
				{
					num2 = 7;
				}
				break;
			case 9:
			case 11:
			case 13:
				I5371F1GdESqt4O4E2N(context, true);
				num2 = 4;
				break;
			case 12:
				context.SelectedNodes.Remove((INNode)(object)primitive);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				context.HighlightedNodes.Remove((INNode)(object)primitive);
				num2 = 10;
				break;
			case 7:
				context.HighlightedNodes.Add((INNode)(object)primitive, null);
				num2 = 13;
				break;
			default:
				if (!selected)
				{
					num2 = 9;
					break;
				}
				goto case 5;
			case 4:
				primitive.Paint(context);
				num2 = 3;
				break;
			case 3:
				I5371F1GdESqt4O4E2N(context, false);
				num2 = 6;
				break;
			case 2:
				return;
			case 10:
				return;
			case 6:
				if (!highlighted)
				{
					if (!selected)
					{
						return;
					}
					num2 = 12;
				}
				else
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c == 0)
					{
						num2 = 0;
					}
				}
				break;
			}
		}
	}

	protected Decorator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		((NDecorator)this)._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void I5371F1GdESqt4O4E2N(object P_0, bool P_1)
	{
		((NPaintContext)P_0).set_LockDecorationsPaint(P_1);
	}

	internal static bool FKEbn11VkoyYvTje3tw()
	{
		return mhEBiV1UOfD4bm5ZeNl == null;
	}

	internal static Decorator ri5C9i1Anbo8vfTTgoE()
	{
		return mhEBiV1UOfD4bm5ZeNl;
	}
}
