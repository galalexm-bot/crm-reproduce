using System.Drawing;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.GraphicsCore;

namespace EleWise.ELMA.Workflow.Diagrams.Shapes.Decorators;

public class ActiveDecorator : Decorator, IExecutionDecorator
{
	private NRectangleF lastShapeBounds;

	private NModel lastPath;

	private static ActiveDecorator vX9xgM1jLJuSYrPyh5W;

	public ActiveDecoratorStyle Style
	{
		[CompilerGenerated]
		get
		{
			return _003CStyle_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CStyle_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public override void PaintForeground(NPaintContext context)
	{
		//Discarded unreachable code: IL_00ba, IL_00c9, IL_017e, IL_01af, IL_01be
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		int num = 7;
		int num2 = num;
		IBorderDecoratable borderDecoratable = default(IBorderDecoratable);
		NRectangleF bounds = default(NRectangleF);
		NShape val = default(NShape);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				PaintPath(context, lastPath, highlighted: false, selected: false);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 != 0)
				{
					num2 = 0;
				}
				break;
			case 11:
				lastPath = (NModel)CcsPae13VaSIE81iB69(borderDecoratable, bounds);
				num2 = 2;
				break;
			case 6:
				bounds = ((NModel)val).get_Bounds();
				num2 = 9;
				break;
			case 15:
				if (lastPath != null)
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 != 0)
					{
						num2 = 1;
					}
					break;
				}
				return;
			case 2:
			case 14:
				if (lastPath == null)
				{
					num2 = 10;
					break;
				}
				goto case 5;
			case 9:
				if (lastPath == null)
				{
					num2 = 8;
					break;
				}
				goto case 16;
			case 3:
			case 10:
				lastShapeBounds = bounds;
				num2 = 15;
				break;
			case 4:
				OHMjrc1pQ2w04boOnss(PxxHqt1QGpyNI0Cd0xP(lastPath), (object)new NStrokeStyle(8f, GetStrokeColor()));
				num2 = 3;
				break;
			case 5:
				YgH36E1THMm70YNQPHG(lastPath, (object)new NStyle());
				num2 = 4;
				break;
			case 7:
				val = (NShape)PgqlYy1qKVWnZQmd7RX(this);
				num2 = 6;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 16:
				if (lastShapeBounds != bounds)
				{
					num2 = 13;
					break;
				}
				goto case 15;
			case 8:
			case 13:
				borderDecoratable = val as IBorderDecoratable;
				num2 = 12;
				break;
			case 12:
				if (borderDecoratable == null)
				{
					num2 = 8;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 == 0)
					{
						num2 = 14;
					}
					break;
				}
				goto case 11;
			}
		}
	}

	private Color GetStrokeColor()
	{
		//Discarded unreachable code: IL_00ba, IL_00c9
		int num = 1;
		int num2 = num;
		ActiveDecoratorStyle style = default(ActiveDecoratorStyle);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return duCpAK1MYI2ZXTn2aRD(255, iEHM8w1CynpKxicAX1B(90, 144, 255));
			case 3:
				return duCpAK1MYI2ZXTn2aRD(255, iEHM8w1CynpKxicAX1B(103, 184, 48));
			case 1:
				style = Style;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				{
					switch (style)
					{
					case ActiveDecoratorStyle.Queued:
						break;
					case ActiveDecoratorStyle.QueuedWarn:
						return duCpAK1MYI2ZXTn2aRD(255, Color.FromArgb(238, 140, 0));
					case ActiveDecoratorStyle.QueuedError:
						return duCpAK1MYI2ZXTn2aRD(255, iEHM8w1CynpKxicAX1B(238, 0, 0));
					default:
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea == 0)
						{
							num2 = 3;
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

	public ActiveDecorator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		d2VhMQ1ksSF1nbDuRNu();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool IuTLZ61RlRJQMTuH8HL()
	{
		return vX9xgM1jLJuSYrPyh5W == null;
	}

	internal static ActiveDecorator rUw4kZ16RBE56EqyNwJ()
	{
		return vX9xgM1jLJuSYrPyh5W;
	}

	internal static object PgqlYy1qKVWnZQmd7RX(object P_0)
	{
		return ((NDecorator)P_0).get_Shape();
	}

	internal static object CcsPae13VaSIE81iB69(object P_0, NRectangleF bounds)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((IBorderDecoratable)P_0).GetBorderDecoratorModel(bounds);
	}

	internal static void YgH36E1THMm70YNQPHG(object P_0, object P_1)
	{
		((NStyleableElement)P_0).set_Style((NStyle)P_1);
	}

	internal static object PxxHqt1QGpyNI0Cd0xP(object P_0)
	{
		return ((NStyleableElement)P_0).get_Style();
	}

	internal static void OHMjrc1pQ2w04boOnss(object P_0, object P_1)
	{
		((NStyle)P_0).set_StrokeStyle((NStrokeStyle)P_1);
	}

	internal static Color iEHM8w1CynpKxicAX1B(int P_0, int P_1, int P_2)
	{
		return Color.FromArgb(P_0, P_1, P_2);
	}

	internal static Color duCpAK1MYI2ZXTn2aRD(int P_0, Color P_1)
	{
		return Color.FromArgb(P_0, P_1);
	}

	internal static void d2VhMQ1ksSF1nbDuRNu()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
