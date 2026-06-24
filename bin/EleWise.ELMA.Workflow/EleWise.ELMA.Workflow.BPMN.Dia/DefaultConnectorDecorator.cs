using System.Drawing;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Connectors;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.GraphicsCore;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Decorators;

public class DefaultConnectorDecorator : BaseDecorator
{
	internal static DefaultConnectorDecorator D8vX1aOwT6SfWvNkRAdT;

	public DefaultConnectorDecorator()
	{
		//Discarded unreachable code: IL_002a
		YvKOG6OwCNBq4LryYeno();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				bIiVmROwMAOXYPfFsHis(this, 10f);
				num = 3;
				break;
			case 2:
				return;
			case 3:
				xF3j5tOwkBGh1EvXoXd1(this, 10f);
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e != 0)
				{
					num = 0;
				}
				break;
			default:
			{
				base.Position = DecoratorPosition.Custom;
				int num2 = 2;
				num = num2;
				break;
			}
			}
		}
	}

	protected override void CreatePaths(NRectangleF bounds)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		int num = 3;
		int num2 = num;
		NLinePath val = default(NLinePath);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			case 3:
				val = new NLinePath(bounds.X, bounds.Y, bounds.X + bounds.Width, bounds.Y + bounds.Height);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 != 0)
				{
					num2 = 2;
				}
				break;
			case 4:
				AddPath((NPathPrimitive)(object)val);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				QldYS7OwG5TEDkH8khCI(zykIN6OwVw2ybKojUxg6(val), (object)new NStrokeStyle(1.2f, DarpLCOwA4PbLghr5Lt7()));
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 != 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				Lrd7oGOwUuC0Kd5G2uUO(val, (object)new NStyle());
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected override NRectangleF GetModelBounds()
	{
		//Discarded unreachable code: IL_008b, IL_010f, IL_011e
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		int num = 8;
		NPointF center = default(NPointF);
		NLineSegmentF value = default(NLineSegmentF);
		NMatrix2DF val2 = default(NMatrix2DF);
		FlowConnectorShape flowConnectorShape = default(FlowConnectorShape);
		NLineSegmentF? longestSegment = default(NLineSegmentF?);
		NPointF val = default(NPointF);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					center = ((NLineSegmentF)(ref value)).get_Center();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 == 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					val2 = FZi9XIOwonZ3GsijLA5n(flowConnectorShape);
					num = 11;
					break;
				case 5:
					if (!longestSegment.HasValue)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 4;
				case 11:
					val = ((NMatrix2DF)(ref val2)).TransformPoint(val);
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 == 0)
					{
						num2 = 0;
					}
					continue;
				case 9:
					longestSegment = flowConnectorShape.GetLongestSegment();
					num2 = 5;
					continue;
				case 8:
					flowConnectorShape = Ux9w7FOw72SVYwl7009m(this) as FlowConnectorShape;
					num2 = 7;
					continue;
				case 7:
					if (flowConnectorShape == null)
					{
						num = 10;
						break;
					}
					goto case 9;
				default:
					((NPointF)(ref val))._002Ector(center.X - GwuyILOw2xR1kGLvVPSM(this) / 2f, center.Y - Height / 2f);
					num2 = 6;
					continue;
				case 3:
					return new NRectangleF(val.X, val.Y, GwuyILOw2xR1kGLvVPSM(this), fpJ6vXOwFwpIj4bMeklh(this));
				case 1:
				case 10:
					return NRectangleF.Empty;
				case 4:
					value = longestSegment.Value;
					num = 2;
					break;
				}
				break;
			}
		}
	}

	internal static void YvKOG6OwCNBq4LryYeno()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static void bIiVmROwMAOXYPfFsHis(object P_0, float value)
	{
		((BaseDecorator)P_0).Width = value;
	}

	internal static void xF3j5tOwkBGh1EvXoXd1(object P_0, float value)
	{
		((BaseDecorator)P_0).Height = value;
	}

	internal static bool hcMvjiOwQ11WFQalv8Dj()
	{
		return D8vX1aOwT6SfWvNkRAdT == null;
	}

	internal static DefaultConnectorDecorator QQlWi2OwpLCWVUKij2An()
	{
		return D8vX1aOwT6SfWvNkRAdT;
	}

	internal static void Lrd7oGOwUuC0Kd5G2uUO(object P_0, object P_1)
	{
		((NStyleableElement)P_0).set_Style((NStyle)P_1);
	}

	internal static object zykIN6OwVw2ybKojUxg6(object P_0)
	{
		return ((NStyleableElement)P_0).get_Style();
	}

	internal static Color DarpLCOwA4PbLghr5Lt7()
	{
		return Color.Black;
	}

	internal static void QldYS7OwG5TEDkH8khCI(object P_0, object P_1)
	{
		((NStyle)P_0).set_StrokeStyle((NStrokeStyle)P_1);
	}

	internal static object Ux9w7FOw72SVYwl7009m(object P_0)
	{
		return ((NDecorator)P_0).get_Shape();
	}

	internal static float GwuyILOw2xR1kGLvVPSM(object P_0)
	{
		return ((BaseDecorator)P_0).Width;
	}

	internal static NMatrix2DF FZi9XIOwonZ3GsijLA5n(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NTransformableElement)P_0).get_SceneTransform();
	}

	internal static float fpJ6vXOwFwpIj4bMeklh(object P_0)
	{
		return ((BaseDecorator)P_0).Height;
	}
}
