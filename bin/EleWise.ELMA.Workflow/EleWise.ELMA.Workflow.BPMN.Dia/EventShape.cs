using System;
using System.Drawing;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Decorators;
using EleWise.ELMA.Workflow.Diagrams.Shapes;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.Dom;
using Nevron.GraphicsCore;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Events;

[Serializable]
public abstract class EventShape : BPMNShape
{
	internal static EventShape Uf7khXOSZ2LIettd3eRK;

	public virtual bool shapeok => false;

	protected virtual Color StrokeColor => ShapeHelper.DefaultStrokeColor;

	protected virtual float StrokeWidth => 0.75f;

	protected virtual Color StartColor => Color.White;

	protected virtual Color EndColor => zZ5tPTOSHrEXDaXXhMOG();

	protected virtual float DefaultWidth => 32f;

	protected virtual float DefaultHeight => 32f;

	public EventShape()
	{
		//Discarded unreachable code: IL_002a
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected O, but got Unknown
		UXunpgOS8pt6Di9AMljm();
		base._002Ector();
		int num = 7;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 == 0)
		{
			num = 5;
		}
		NAbilities val2 = default(NAbilities);
		NEllipsePath val = default(NEllipsePath);
		while (true)
		{
			switch (num)
			{
			case 2:
				InfIAXOSXQKibBkOrZRf(((NShape)this).get_Labels());
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede != 0)
				{
					num = 12;
				}
				break;
			case 11:
				val2 = OdchGdOSBSlTP4Ysf4IY(this);
				num = 6;
				break;
			case 9:
				GK02x6OScVjVJy2eOckI(this, val2);
				num = 10;
				break;
			case 5:
				i6yAaBOSy99bxZvKaBHu(OCIMljOS0IKtqPmqNoXP(this), val);
				num = 4;
				break;
			case 3:
				txOXTVOSgKGoFaG8MgGc(DubPHxOSmeSXGZH5K3GV(this), (object)new NStrokeStyle(StrokeWidth, StrokeColor));
				num = 11;
				break;
			case 10:
				b1479MOSPtqIbelfdfhX(this);
				num = 2;
				break;
			case 6:
				((NAbilities)(ref val2)).set_ResizeX(true);
				num = 8;
				break;
			case 4:
				zLFOXpOS5wkL76DiJumZ(DubPHxOSmeSXGZH5K3GV(this), (object)new NGradientFillStyle((GradientStyle)0, (GradientVariant)0, kSHeFrOStEd80wOadXGJ(this), uMMPs8OSbuhZGGHptTsD(this)));
				num = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 == 0)
				{
					num = 1;
				}
				break;
			case 7:
				IxhJyEOSsJ2rgbAyMPYP(this);
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 == 0)
				{
					num = 0;
				}
				break;
			case 8:
				((NAbilities)(ref val2)).set_ResizeY(true);
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d == 0)
				{
					num = 0;
				}
				break;
			default:
			{
				((NAbilities)(ref val2)).set_InplaceEdit(true);
				int num2 = 9;
				num = num2;
				break;
			}
			case 13:
				return;
			case 12:
				d4epEuOSdE1Qt67pQ1J4(this);
				num = 13;
				break;
			case 1:
				val = new NEllipsePath(0f, 0f, P6yLO6OSJ5JK6GEQtx1N(this), Sm0wGYOSlFJtyIdpqjMd(this));
				num = 5;
				break;
			}
		}
	}

	public virtual void elipseBig()
	{
	}

	public override NModel GetBorderDecoratorModel(NRectangleF bounds)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		return (NModel)new NEllipsePath(bounds.X, bounds.Y, bounds.Width, bounds.Height);
	}

	public override void UpdateDecorators(Element element)
	{
		//Discarded unreachable code: IL_0041
		int num = 1;
		int num2 = num;
		Type type = default(Type);
		EventElement eventElement = default(EventElement);
		while (true)
		{
			switch (num2)
			{
			case 5:
				return;
			case 2:
				if (!(type != null))
				{
					num2 = 5;
					continue;
				}
				break;
			case 1:
				base.UpdateDecorators(element);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 == 0)
				{
					num2 = 0;
				}
				continue;
			case 4:
				if (eventElement != null)
				{
					num2 = 3;
					continue;
				}
				return;
			default:
				eventElement = element as EventElement;
				num2 = 4;
				continue;
			case 3:
				type = n0dQcbOSDDQrM0vXUXFL(PnwUxGOSuKnShXR9ynmi(eventElement));
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 == 0)
				{
					num2 = 1;
				}
				continue;
			case 6:
				return;
			case 7:
				break;
			}
			AddDecorator(type);
			num2 = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea == 0)
			{
				num2 = 6;
			}
		}
	}

	public static Type GetTriggerDecoratorType(EventTrigger trigger)
	{
		//Discarded unreachable code: IL_00be, IL_00cd
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				switch (trigger)
				{
				case EventTrigger.MessageReceive:
					goto IL_006a;
				case EventTrigger.MessageSend:
					return typeof(MessageSendDecorator);
				case EventTrigger.Timer:
					return typeof(TimerDecorator);
				case EventTrigger.Script:
					return Dwt6eEOSn2066awq6ovq(typeof(ScriptTaskDecorator).TypeHandle);
				case EventTrigger.ErrorCatch:
					return Dwt6eEOSn2066awq6ovq(typeof(ErrorCatchDecorator).TypeHandle);
				case EventTrigger.ErrorThrow:
					return typeof(ErrorThrowDecorator);
				case EventTrigger.Event:
					return Dwt6eEOSn2066awq6ovq(typeof(EventDecorator).TypeHandle);
				case EventTrigger.Metric:
					goto end_IL_0012;
				}
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				goto IL_006a;
				IL_006a:
				return Dwt6eEOSn2066awq6ovq(typeof(MessageReceiveDecorator).TypeHandle);
				end_IL_0012:
				break;
			}
			break;
		}
		return null;
	}

	protected virtual void AddPorts()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				UT7paROSLPoh9NJ6eDHj(this, false);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void UXunpgOS8pt6Di9AMljm()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static void IxhJyEOSsJ2rgbAyMPYP(object P_0)
	{
		((EventShape)P_0).elipseBig();
	}

	internal static float P6yLO6OSJ5JK6GEQtx1N(object P_0)
	{
		return ((EventShape)P_0).DefaultWidth;
	}

	internal static float Sm0wGYOSlFJtyIdpqjMd(object P_0)
	{
		return ((EventShape)P_0).DefaultHeight;
	}

	internal static object OCIMljOS0IKtqPmqNoXP(object P_0)
	{
		return ((NCompositeShape)P_0).get_Primitives();
	}

	internal static void i6yAaBOSy99bxZvKaBHu(object P_0, object P_1)
	{
		((NDiagramElementCollection)P_0).AddChild((INNode)P_1);
	}

	internal static object DubPHxOSmeSXGZH5K3GV(object P_0)
	{
		return ((NStyleableElement)P_0).get_Style();
	}

	internal static Color kSHeFrOStEd80wOadXGJ(object P_0)
	{
		return ((EventShape)P_0).StartColor;
	}

	internal static Color uMMPs8OSbuhZGGHptTsD(object P_0)
	{
		return ((EventShape)P_0).EndColor;
	}

	internal static void zLFOXpOS5wkL76DiJumZ(object P_0, object P_1)
	{
		((NStyle)P_0).set_FillStyle((NFillStyle)P_1);
	}

	internal static void txOXTVOSgKGoFaG8MgGc(object P_0, object P_1)
	{
		((NStyle)P_0).set_StrokeStyle((NStrokeStyle)P_1);
	}

	internal static NAbilities OdchGdOSBSlTP4Ysf4IY(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NDiagramElement)P_0).get_Protection();
	}

	internal static void GK02x6OScVjVJy2eOckI(object P_0, NAbilities P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NDiagramElement)P_0).set_Protection(P_1);
	}

	internal static void b1479MOSPtqIbelfdfhX(object P_0)
	{
		((EventShape)P_0).AddPorts();
	}

	internal static void InfIAXOSXQKibBkOrZRf(object P_0)
	{
		((NDiagramElementCollection)P_0).RemoveAllChildren();
	}

	internal static bool d4epEuOSdE1Qt67pQ1J4(object P_0)
	{
		return ((NAggregateModel)P_0).UpdateModelBounds();
	}

	internal static bool Dht3wCOSvXSB1KOsTUxi()
	{
		return Uf7khXOSZ2LIettd3eRK == null;
	}

	internal static EventShape PRjYy7OSYJb9TrfhfISi()
	{
		return Uf7khXOSZ2LIettd3eRK;
	}

	internal static EventTrigger PnwUxGOSuKnShXR9ynmi(object P_0)
	{
		return ((EventElement)P_0).Trigger;
	}

	internal static Type n0dQcbOSDDQrM0vXUXFL(EventTrigger trigger)
	{
		return GetTriggerDecoratorType(trigger);
	}

	internal static Type Dwt6eEOSn2066awq6ovq(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static Color zZ5tPTOSHrEXDaXXhMOG()
	{
		return Color.White;
	}

	internal static void UT7paROSLPoh9NJ6eDHj(object P_0, bool addIntermediate)
	{
		ShapeHelper.AddPorts((NShape)P_0, addIntermediate);
	}
}
