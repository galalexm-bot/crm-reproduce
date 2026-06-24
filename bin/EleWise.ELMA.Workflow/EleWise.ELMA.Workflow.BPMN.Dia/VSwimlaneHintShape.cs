using System.Drawing;
using EleWise.ELMA.Workflow.Diagrams.Shapes;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.Dom;
using Nevron.GraphicsCore;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Swimlanes;

public class VSwimlaneHintShape : NCompositeShape
{
	public const float DEFAULT_WIDTH = 24f;

	public const float DEFAULT_HEIGHT = 24f;

	public const float DEFAULT_HEADER_HEIGHT = 6f;

	private static readonly Color startColor;

	internal static VSwimlaneHintShape gCP0y6OrTUQsTxbXORvU;

	protected virtual Color StartColor => startColor;

	protected virtual Color EndColor => jnpu11OrIBAubtOoktPK();

	public VSwimlaneHintShape()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected O, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		//IL_01b4: Expected O, but got Unknown
		LbYhM0OrCo6uognkuRlp();
		((NCompositeShape)this)._002Ector();
		int num = 4;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 == 0)
		{
			num = 6;
		}
		NRectanglePath val2 = default(NRectanglePath);
		while (true)
		{
			switch (num)
			{
			case 5:
				e4qA8COrU1CLEgaFV24N(val2, (object)new NStyle());
				num = 7;
				break;
			case 2:
				pIK5ZgOr273FnAoJfXeh(PiSSsROr79NYHPgWcMIA(this), val2);
				num = 3;
				break;
			case 7:
				CAf4MaOrGk68sew76pC1(uXpg6lOrVS3l4n5ELyMx(val2), (object)new NGradientFillStyle((GradientStyle)0, (GradientVariant)0, E1uvexOrAFFVcIawVkun(this), EndColor));
				num = 2;
				break;
			case 8:
				GIeJkfOrkPCgcISnrcrV(val2, new NPointF(12f, 0f));
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b != 0)
				{
					num = 5;
				}
				break;
			case 4:
				return;
			default:
				YKEfTwOro8BBxFgPwK47(this);
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 == 0)
				{
					num = 0;
				}
				break;
			case 3:
				pIK5ZgOr273FnAoJfXeh(PiSSsROr79NYHPgWcMIA(this), (object)new NPolylinePath((NPointF[])(object)new NPointF[4]
				{
					new NPointF(0f, 0f),
					new NPointF(0f, 24f),
					new NPointF(24f, 24f),
					new NPointF(24f, 0f)
				}));
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 == 0)
				{
					num = 0;
				}
				break;
			case 6:
			{
				NRectanglePath val = new NRectanglePath(0f, 0f, 24f, 6f);
				Ty3eiWOrM2umErrIVRWW((object)val, (ResizeInAggregate)16);
				val2 = val;
				num = 8;
				break;
			}
			case 1:
				MnL3vVOriggqDInckZsY(uXpg6lOrVS3l4n5ELyMx(this), XbYGpLOrF2EUok5MAeep());
				num = 4;
				break;
			}
		}
	}

	static VSwimlaneHintShape()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				startColor = EpBDEaOra5VFYSoLlSNI(176, 186, 198);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static void LbYhM0OrCo6uognkuRlp()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static void Ty3eiWOrM2umErrIVRWW(object P_0, ResizeInAggregate P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NModel)P_0).set_ResizeInAggregate(P_1);
	}

	internal static void GIeJkfOrkPCgcISnrcrV(object P_0, NPointF P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NModel)P_0).set_PinPoint(P_1);
	}

	internal static void e4qA8COrU1CLEgaFV24N(object P_0, object P_1)
	{
		((NStyleableElement)P_0).set_Style((NStyle)P_1);
	}

	internal static object uXpg6lOrVS3l4n5ELyMx(object P_0)
	{
		return ((NStyleableElement)P_0).get_Style();
	}

	internal static Color E1uvexOrAFFVcIawVkun(object P_0)
	{
		return ((VSwimlaneHintShape)P_0).StartColor;
	}

	internal static void CAf4MaOrGk68sew76pC1(object P_0, object P_1)
	{
		((NStyle)P_0).set_FillStyle((NFillStyle)P_1);
	}

	internal static object PiSSsROr79NYHPgWcMIA(object P_0)
	{
		return ((NCompositeShape)P_0).get_Primitives();
	}

	internal static void pIK5ZgOr273FnAoJfXeh(object P_0, object P_1)
	{
		((NDiagramElementCollection)P_0).AddChild((INNode)P_1);
	}

	internal static bool YKEfTwOro8BBxFgPwK47(object P_0)
	{
		return ((NAggregateModel)P_0).UpdateModelBounds();
	}

	internal static object XbYGpLOrF2EUok5MAeep()
	{
		return ShapeHelper.DefaultStrokeStyle;
	}

	internal static void MnL3vVOriggqDInckZsY(object P_0, object P_1)
	{
		((NStyle)P_0).set_StrokeStyle((NStrokeStyle)P_1);
	}

	internal static bool dpwvpXOrQ9rUIZ4GT5wa()
	{
		return gCP0y6OrTUQsTxbXORvU == null;
	}

	internal static VSwimlaneHintShape FODvTGOrpli5B5mOlTHZ()
	{
		return gCP0y6OrTUQsTxbXORvU;
	}

	internal static Color jnpu11OrIBAubtOoktPK()
	{
		return Color.White;
	}

	internal static Color EpBDEaOra5VFYSoLlSNI(int P_0, int P_1, int P_2)
	{
		return Color.FromArgb(P_0, P_1, P_2);
	}
}
