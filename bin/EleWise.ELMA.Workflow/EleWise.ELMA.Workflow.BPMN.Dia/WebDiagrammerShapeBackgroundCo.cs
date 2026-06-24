using System.Drawing;
using EleWise.ELMA.Workflow.Models.Enums;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes;

public static class WebDiagrammerShapeBackgroundColorPresets
{
	private static WebDiagrammerShapeBackgroundColorPresets yZ4gKrOabX0uXX6J4sMi;

	public static Color GetColor(WebDiagrammerElementColor color)
	{
		//Discarded unreachable code: IL_0187, IL_0196
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				switch (color)
				{
				default:
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b == 0)
					{
						num2 = 0;
					}
					goto end_IL_0012;
				case WebDiagrammerElementColor.Blue:
					break;
				case WebDiagrammerElementColor.Cyan:
					return RQoJ2wOaBfS2mcc35mA9(255, 201, 241, 254);
				case WebDiagrammerElementColor.Gray:
					return RQoJ2wOaBfS2mcc35mA9(255, 247, 247, 247);
				case WebDiagrammerElementColor.Green:
					return RQoJ2wOaBfS2mcc35mA9(255, 225, 241, 228);
				case WebDiagrammerElementColor.Orange:
					return RQoJ2wOaBfS2mcc35mA9(255, 254, 207, 165);
				case WebDiagrammerElementColor.Purple:
					return Color.FromArgb(255, 228, 207, 231);
				case WebDiagrammerElementColor.Red:
					return Color.FromArgb(255, 238, 198, 198);
				case WebDiagrammerElementColor.White:
					return RQoJ2wOaBfS2mcc35mA9(255, 255, 255, 255);
				case WebDiagrammerElementColor.Yellow:
					return RQoJ2wOaBfS2mcc35mA9(255, 254, 246, 206);
				case WebDiagrammerElementColor.Brown:
					return Color.FromArgb(255, 221, 212, 206);
				}
				goto case 2;
			case 2:
				return RQoJ2wOaBfS2mcc35mA9(255, 213, 228, 240);
			default:
				{
					return Color.FromArgb(255, 0, 0, 0);
				}
				end_IL_0012:
				break;
			}
		}
	}

	internal static Color RQoJ2wOaBfS2mcc35mA9(int P_0, int P_1, int P_2, int P_3)
	{
		return Color.FromArgb(P_0, P_1, P_2, P_3);
	}

	internal static bool VCDmKWOa5b5Sbpvdm8IO()
	{
		return yZ4gKrOabX0uXX6J4sMi == null;
	}

	internal static WebDiagrammerShapeBackgroundColorPresets kkCIDIOagZyHDlrUjcAm()
	{
		return yZ4gKrOabX0uXX6J4sMi;
	}
}
