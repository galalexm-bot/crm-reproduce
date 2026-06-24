using System.Drawing;
using EleWise.ELMA.Workflow.Models.Enums;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes;

public static class WebDiagrammerShapeStrokeColorPresets
{
	private static WebDiagrammerShapeStrokeColorPresets cbLqLZOa0JrYFwR7wcSm;

	public static Color GetColor(WebDiagrammerElementColor color)
	{
		//Discarded unreachable code: IL_0181, IL_0190
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return myqKZHOatsaAPXC8T5Pc(255, 128, 173, 209);
			default:
				return myqKZHOatsaAPXC8T5Pc(255, 0, 0, 0);
			case 1:
				{
					switch (color)
					{
					case WebDiagrammerElementColor.Blue:
						break;
					case WebDiagrammerElementColor.Cyan:
						return myqKZHOatsaAPXC8T5Pc(255, 128, 173, 209);
					case WebDiagrammerElementColor.Gray:
						return myqKZHOatsaAPXC8T5Pc(255, 233, 233, 233);
					case WebDiagrammerElementColor.Green:
						return myqKZHOatsaAPXC8T5Pc(255, 164, 214, 174);
					case WebDiagrammerElementColor.Orange:
						return myqKZHOatsaAPXC8T5Pc(255, 241, 144, 73);
					case WebDiagrammerElementColor.Purple:
						return myqKZHOatsaAPXC8T5Pc(255, 164, 130, 163);
					case WebDiagrammerElementColor.Red:
						return myqKZHOatsaAPXC8T5Pc(255, 216, 134, 136);
					case WebDiagrammerElementColor.White:
						return myqKZHOatsaAPXC8T5Pc(255, 255, 255, 255);
					case WebDiagrammerElementColor.Yellow:
						return myqKZHOatsaAPXC8T5Pc(255, 253, 227, 107);
					case WebDiagrammerElementColor.Brown:
						return myqKZHOatsaAPXC8T5Pc(255, 148, 139, 134);
					default:
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 != 0)
						{
							num2 = 0;
						}
						goto end_IL_0012;
					}
					goto case 2;
				}
				end_IL_0012:
				break;
			}
		}
	}

	internal static Color myqKZHOatsaAPXC8T5Pc(int P_0, int P_1, int P_2, int P_3)
	{
		return Color.FromArgb(P_0, P_1, P_2, P_3);
	}

	internal static bool O11l1VOay0DsxRjaFqLv()
	{
		return cbLqLZOa0JrYFwR7wcSm == null;
	}

	internal static WebDiagrammerShapeStrokeColorPresets jN0YRZOam5oeEItsdvLB()
	{
		return cbLqLZOa0JrYFwR7wcSm;
	}
}
