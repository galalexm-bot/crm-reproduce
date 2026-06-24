using System.Drawing;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes;

public abstract class WebDiagrammerBaseRectangleElementShape : IWebDiagrammerElementShape
{
	private Color strokeColor;

	private Color backgroundColor;

	private static WebDiagrammerBaseRectangleElementShape YYw2p5OIUxVG4vcx8AhA;

	public virtual int Width => 96;

	public virtual int Height => 64;

	public virtual int StrokeWidth => 1;

	public virtual Color StrokeColor => strokeColor;

	public virtual Color BackgroundColor => backgroundColor;

	public WebDiagrammerBaseRectangleElementShape(Color backgroundColor, Color strokeColor)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				this.backgroundColor = backgroundColor;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e == 0)
				{
					num = 0;
				}
				break;
			case 1:
				this.strokeColor = strokeColor;
				num = 2;
				break;
			}
		}
	}

	internal static bool JgiSqWOIV9EtDB5NmjUB()
	{
		return YYw2p5OIUxVG4vcx8AhA == null;
	}

	internal static WebDiagrammerBaseRectangleElementShape nim7qHOIAANZnASyslcg()
	{
		return YYw2p5OIUxVG4vcx8AhA;
	}
}
