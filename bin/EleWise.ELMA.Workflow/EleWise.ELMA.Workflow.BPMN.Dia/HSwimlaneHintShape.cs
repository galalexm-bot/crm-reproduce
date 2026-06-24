using System.Drawing;
using EleWise.ELMA.Workflow.Diagrams.Shapes;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.Dom;
using Nevron.GraphicsCore;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Swimlanes;

public class HSwimlaneHintShape : NCompositeShape
{
	public const float DEFAULT_WIDTH = 24f;

	public const float DEFAULT_HEIGHT = 24f;

	public const float DEFAULT_HEADER_WIDTH = 6f;

	private static readonly Color startColor;

	internal static HSwimlaneHintShape CucxWjOaqOis1rAa9H8n;

	protected virtual Color StartColor => startColor;

	protected virtual Color EndColor => Color.White;

	public HSwimlaneHintShape()
	{
		//Discarded unreachable code: IL_002a
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00c0: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected O, but got Unknown
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		urcBo3OaQmXQfhf3Km3n();
		((NCompositeShape)this)._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 != 0)
		{
			num = 1;
		}
		NRectanglePath val = default(NRectanglePath);
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 4:
				((NStyleableElement)this).get_Style().set_StrokeStyle((NStrokeStyle)YdbpsoOaG9VGOVr4dQjL());
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			case 2:
				kLv2auOaAlhRrVIQWElV(this);
				num = 4;
				break;
			case 1:
			{
				NRectanglePath val2 = new NRectanglePath(0f, 0f, 6f, 24f);
				KE5tM2OapnTT0ixJCLiW((object)val2, (ResizeInAggregate)13);
				val = val2;
				int num2 = 6;
				num = num2;
				break;
			}
			case 3:
				RxMt4LOaVQ4STOqu5ThB(((NCompositeShape)this).get_Primitives(), (object)new NPolylinePath((NPointF[])(object)new NPointF[4]
				{
					new NPointF(0f, 0f),
					new NPointF(24f, 0f),
					new NPointF(24f, 24f),
					new NPointF(0f, 24f)
				}));
				num = 2;
				break;
			case 8:
				((NStyleableElement)val).get_Style().set_FillStyle((NFillStyle)new NGradientFillStyle((GradientStyle)1, (GradientVariant)0, b6d137OakK8Jey9uuV9t(this), WUmu5iOaUWuslTfLO6I4(this)));
				num = 7;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 == 0)
				{
					num = 2;
				}
				break;
			case 5:
				Yi1B5POaMAy8lsj85Qk9(val, (object)new NStyle());
				num = 8;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 == 0)
				{
					num = 6;
				}
				break;
			case 6:
				TKOVhDOaCpnLKQay6XrL(val, new NPointF(0f, 12f));
				num = 5;
				break;
			case 7:
				RxMt4LOaVQ4STOqu5ThB(((NCompositeShape)this).get_Primitives(), val);
				num = 3;
				break;
			}
		}
	}

	static HSwimlaneHintShape()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				startColor = HmskbXOa7TsTiuZfcA2u(176, 186, 198);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				urcBo3OaQmXQfhf3Km3n();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static void urcBo3OaQmXQfhf3Km3n()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static void KE5tM2OapnTT0ixJCLiW(object P_0, ResizeInAggregate P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NModel)P_0).set_ResizeInAggregate(P_1);
	}

	internal static void TKOVhDOaCpnLKQay6XrL(object P_0, NPointF P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NModel)P_0).set_PinPoint(P_1);
	}

	internal static void Yi1B5POaMAy8lsj85Qk9(object P_0, object P_1)
	{
		((NStyleableElement)P_0).set_Style((NStyle)P_1);
	}

	internal static Color b6d137OakK8Jey9uuV9t(object P_0)
	{
		return ((HSwimlaneHintShape)P_0).StartColor;
	}

	internal static Color WUmu5iOaUWuslTfLO6I4(object P_0)
	{
		return ((HSwimlaneHintShape)P_0).EndColor;
	}

	internal static void RxMt4LOaVQ4STOqu5ThB(object P_0, object P_1)
	{
		((NDiagramElementCollection)P_0).AddChild((INNode)P_1);
	}

	internal static bool kLv2auOaAlhRrVIQWElV(object P_0)
	{
		return ((NAggregateModel)P_0).UpdateModelBounds();
	}

	internal static object YdbpsoOaG9VGOVr4dQjL()
	{
		return ShapeHelper.DefaultStrokeStyle;
	}

	internal static bool WnZes6Oa3wj0sc8MpXjt()
	{
		return CucxWjOaqOis1rAa9H8n == null;
	}

	internal static HSwimlaneHintShape WkfJoJOaTKmHmaeXOl58()
	{
		return CucxWjOaqOis1rAa9H8n;
	}

	internal static Color HmskbXOa7TsTiuZfcA2u(int P_0, int P_1, int P_2)
	{
		return Color.FromArgb(P_0, P_1, P_2);
	}
}
