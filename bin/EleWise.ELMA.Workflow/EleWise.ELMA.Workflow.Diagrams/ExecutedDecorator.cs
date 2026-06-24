using System.Drawing;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Connectors;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.GraphicsCore;

namespace EleWise.ELMA.Workflow.Diagrams.Shapes.Decorators;

public class ExecutedDecorator : Decorator, IExecutionDecorator
{
	private NRectangleF lastShapeBounds;

	private NModel lastPath;

	internal static ExecutedDecorator dGOfay17UbPZsp162Z3;

	public override void PaintForeground(NPaintContext context)
	{
		//Discarded unreachable code: IL_01de, IL_01ed, IL_01fd, IL_025b
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected O, but got Unknown
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Expected O, but got Unknown
		int num = 6;
		IBorderDecoratable borderDecoratable = default(IBorderDecoratable);
		FlowConnectorShape flowConnectorShape = default(FlowConnectorShape);
		NShape val3 = default(NShape);
		NModel val2 = default(NModel);
		FlowConnectorShape flowConnectorShape2 = default(FlowConnectorShape);
		NRectangleF val = default(NRectangleF);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 18:
					if (borderDecoratable != null)
					{
						num2 = 2;
						break;
					}
					goto case 24;
				case 19:
					flowConnectorShape = lastPath as FlowConnectorShape;
					num2 = 15;
					break;
				case 6:
					val3 = (NShape)wCfByZ1F5j53a4XAoFK(this);
					num2 = 5;
					break;
				case 15:
					MZtKhi1riCTIKr3f5sA(lastPath, (object)new NStyle());
					num2 = 26;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 != 0)
					{
						num2 = 1;
					}
					break;
				case 8:
					if (lastPath == null)
					{
						num2 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a == 0)
						{
							num2 = 10;
						}
						break;
					}
					goto case 11;
				case 16:
					val2 = flowConnectorShape2.GetBorderDecoratorModelTriger(val, lastPath);
					num2 = 20;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 == 0)
					{
						num2 = 12;
					}
					break;
				case 7:
					rkWfsn1N24nkFfYaHrL(hh3Vhj1eRVMbA0NIO1O(val2), (object)new NStrokeStyle(2f, TVf2Vr116SXAmQOTv5Z(128, epwCLA1SwgMn7F2Y0aQ())));
					num2 = 27;
					break;
				case 20:
					if (val2 == null)
					{
						num2 = 8;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 == 0)
						{
							num2 = 12;
						}
						break;
					}
					goto case 9;
				case 21:
					PaintPath(context, val2, highlighted: false, selected: false);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 != 0)
					{
						num2 = 0;
					}
					break;
				case 13:
					flowConnectorShape2 = borderDecoratable as FlowConnectorShape;
					num2 = 17;
					break;
				case 14:
					if (val2 == null)
					{
						num2 = 22;
						break;
					}
					goto case 21;
				case 4:
					PaintPath(context, lastPath, highlighted: false, selected: false);
					num2 = 14;
					break;
				case 25:
					if (lastPath != null)
					{
						goto end_IL_0012;
					}
					goto case 14;
				case 3:
					val2 = null;
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 == 0)
					{
						num2 = 8;
					}
					break;
				case 22:
					return;
				case 11:
					if (XuXXQ11IFlp3qgyjlFm(lastShapeBounds, val))
					{
						num2 = 23;
						break;
					}
					goto case 25;
				case 12:
				case 27:
					lastShapeBounds = val;
					num2 = 25;
					break;
				case 1:
					I4l1Hg1xGMUOKKmESTu(244, 244, 244);
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 == 0)
					{
						num2 = 13;
					}
					break;
				case 5:
					val = qmt8311iTbuJiCSOyxq(val3);
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f != 0)
					{
						num2 = 2;
					}
					break;
				case 17:
					if (flowConnectorShape2 != null)
					{
						num2 = 16;
						break;
					}
					goto case 12;
				case 9:
					MZtKhi1riCTIKr3f5sA(val2, (object)new NStyle());
					num2 = 7;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a != 0)
					{
						num2 = 6;
					}
					break;
				case 10:
				case 23:
					borderDecoratable = val3 as IBorderDecoratable;
					num2 = 18;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b == 0)
					{
						num2 = 10;
					}
					break;
				case 2:
					lastPath = (NModel)UaA1pi1aKxKq50l9wnJ(borderDecoratable, val);
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 == 0)
					{
						num2 = 24;
					}
					break;
				case 0:
					return;
				case 24:
					if (lastPath != null)
					{
						num2 = 19;
						break;
					}
					goto case 13;
				case 26:
					rkWfsn1N24nkFfYaHrL(hh3Vhj1eRVMbA0NIO1O(lastPath), (object)new NStrokeStyle((flowConnectorShape == null) ? 4f : 2f, Color.FromArgb(255, Color.FromArgb(0, 55, 179))));
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a == 0)
					{
						num2 = 1;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	public ExecutedDecorator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		yeK9Bi1hiDtFnkimUNS();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object wCfByZ1F5j53a4XAoFK(object P_0)
	{
		return ((NDecorator)P_0).get_Shape();
	}

	internal static NRectangleF qmt8311iTbuJiCSOyxq(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NModel)P_0).get_Bounds();
	}

	internal static bool XuXXQ11IFlp3qgyjlFm(NRectangleF P_0, NRectangleF P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		return P_0 != P_1;
	}

	internal static object UaA1pi1aKxKq50l9wnJ(object P_0, NRectangleF bounds)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((IBorderDecoratable)P_0).GetBorderDecoratorModel(bounds);
	}

	internal static void MZtKhi1riCTIKr3f5sA(object P_0, object P_1)
	{
		((NStyleableElement)P_0).set_Style((NStyle)P_1);
	}

	internal static object hh3Vhj1eRVMbA0NIO1O(object P_0)
	{
		return ((NStyleableElement)P_0).get_Style();
	}

	internal static void rkWfsn1N24nkFfYaHrL(object P_0, object P_1)
	{
		((NStyle)P_0).set_StrokeStyle((NStrokeStyle)P_1);
	}

	internal static Color I4l1Hg1xGMUOKKmESTu(int P_0, int P_1, int P_2)
	{
		return Color.FromArgb(P_0, P_1, P_2);
	}

	internal static Color epwCLA1SwgMn7F2Y0aQ()
	{
		return Color.Blue;
	}

	internal static Color TVf2Vr116SXAmQOTv5Z(int P_0, Color P_1)
	{
		return Color.FromArgb(P_0, P_1);
	}

	internal static bool daQJ3E123u5kgFQx96B()
	{
		return dGOfay17UbPZsp162Z3 == null;
	}

	internal static ExecutedDecorator EE95N41oXRAlbZp65vZ()
	{
		return dGOfay17UbPZsp162Z3;
	}

	internal static void yeK9Bi1hiDtFnkimUNS()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
