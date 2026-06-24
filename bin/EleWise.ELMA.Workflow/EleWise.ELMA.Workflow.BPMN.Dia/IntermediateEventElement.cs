using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Diagrams.Toolbox;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Gateways;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Events;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Toolbox;
using EleWise.ELMA.Workflow.Diagrams;
using EleWise.ELMA.Workflow.Diagrams.Elements;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Properties;
using EleWise.ELMA.Workflow.Validation;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;

[Serializable]
[HintShape(typeof(IntermediateEventHintShape))]
[Shape(typeof(IntermediateEventShape))]
public class IntermediateEventElement : EventElement, IHintDrawElement, IReplaceContextVar
{
	[Component(Order = 200)]
	public class ToolboxItem : IBPMNToolboxItem, IToolboxItem, IContainingElementIcon
	{
		internal static ToolboxItem UxZGcevunGG6aEaqsn3q;

		public string Name => (string)lw3lLBvu94SnA2uCTaiW(wSXeSDvufsc75G5exxwb(-539998957 ^ -539829287));

		public Guid GroupUid => BPMNGroups.Events.UID;

		public Image Image => (Image)DxOLayvuWEsCOlHkSl5o();

		public Type ElementType => pF5cInvujRDlkKgHmCAS(typeof(IntermediateEventElement).TypeHandle);

		public string ElementIcon => SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7AC609FE ^ 0x7AC4D7C8);

		public ToolboxItem()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			tvHpNRvuRVKgDMLsrta6();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object wSXeSDvufsc75G5exxwb(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object lw3lLBvu94SnA2uCTaiW(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool JCRw1svuH326110id9KR()
		{
			return UxZGcevunGG6aEaqsn3q == null;
		}

		internal static ToolboxItem K4ldYFvuLBpbRn5HUoQM()
		{
			return UxZGcevunGG6aEaqsn3q;
		}

		internal static object DxOLayvuWEsCOlHkSl5o()
		{
			return Resources.symb_event_intermediate;
		}

		internal static Type pF5cInvujRDlkKgHmCAS(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static void tvHpNRvuRVKgDMLsrta6()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	[Component(Order = 100)]
	private class UserTaskHintExtension : HintDrawElementExtension<IntermediateEventElement>
	{
		private static object MErAbdvu6T9gTvIqE6hQ;

		public override Type[] TargetElementTypes => new Type[1] { TS2pAgvuTLN7OpedNQjD(typeof(UserTaskElement).TypeHandle) };

		public UserTaskHintExtension()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static Type TS2pAgvuTLN7OpedNQjD(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static bool kGcLtmvuqbFOQxvgOROe()
		{
			return MErAbdvu6T9gTvIqE6hQ == null;
		}

		internal static UserTaskHintExtension QW78rRvu3LNQFt44gyNx()
		{
			return (UserTaskHintExtension)MErAbdvu6T9gTvIqE6hQ;
		}
	}

	[Component(Order = 300)]
	private class ExclusiveGatewayHintExtension : HintDrawElementExtension<IntermediateEventElement>
	{
		internal static object ebhjkPvuQDJoWryhYSjt;

		public override Type[] TargetElementTypes => new Type[1] { typeof(ExclusiveGatewayElement) };

		public ExclusiveGatewayHintExtension()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			tNOihNvuMEXrot5MEty9();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool bbZT9TvupDNZZ6v1JXpi()
		{
			return ebhjkPvuQDJoWryhYSjt == null;
		}

		internal static ExclusiveGatewayHintExtension lA8cIEvuCVGIZFFIjBcI()
		{
			return (ExclusiveGatewayHintExtension)ebhjkPvuQDJoWryhYSjt;
		}

		internal static void tNOihNvuMEXrot5MEty9()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	[Component(Order = 400)]
	private class EndEventHintExtension : HintDrawElementExtension<IntermediateEventElement>
	{
		internal static object SkDV7qvukK6w6RBimyMl;

		public override Type[] TargetElementTypes => new Type[1] { q3IiQAvuAcy8D9rgjlFe(typeof(EndEventElement).TypeHandle) };

		public EndEventHintExtension()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			u5g9iuvuGCPAvNRx6eUd();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static Type q3IiQAvuAcy8D9rgjlFe(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static bool T2vK7VvuU7ossce4J6Gk()
		{
			return SkDV7qvukK6w6RBimyMl == null;
		}

		internal static EndEventHintExtension T3dt9JvuVVdMhMZugIsq()
		{
			return (EndEventHintExtension)SkDV7qvukK6w6RBimyMl;
		}

		internal static void u5g9iuvuGCPAvNRx6eUd()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	internal static IntermediateEventElement PjYBIOZ0Hv7IrT3qET1d;

	public IntermediateTimerSettings TimerSettings
	{
		[CompilerGenerated]
		get
		{
			return _003CTimerSettings_003Ek__BackingField;
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
				case 0:
					return;
				case 1:
					_003CTimerSettings_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	protected virtual void ValidateTimer(WorkflowProcessValidator validator)
	{
		//Discarded unreachable code: IL_011e, IL_012d
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = default(_003C_003Ec__DisplayClass5_0);
		while (true)
		{
			switch (num2)
			{
			case 9:
				return;
			case 3:
				if (TimerSettings != null)
				{
					num2 = 2;
					break;
				}
				goto case 6;
			case 6:
				validator.Messages.Add(base.ValidationHelper.CreateValidationError((string)QpUEb1Z0Wik4skYvgIbs(V9n9gAZ09lKaUbwPVM6b(--296112178 ^ 0x11A4CEDA))));
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 == 0)
				{
					num2 = 0;
				}
				break;
			case 7:
				if (mlZ1yBZ0RZly6JZ7SyWe(TimerSettings) != TimeSetType.ContextVar)
				{
					return;
				}
				num2 = 10;
				break;
			case 10:
				_003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
				num2 = 5;
				break;
			case 4:
				base.ValidationHelper.ValidateProperty(validator, MEnq6YZ0qIyqhuI9g96D(TimerSettings), _003C_003Ec__DisplayClass5_._003CValidateTimer_003Eb__0, (string)QpUEb1Z0Wik4skYvgIbs(V9n9gAZ09lKaUbwPVM6b(0x2ACCDD87 ^ 0x2ACE421B)));
				num2 = 9;
				break;
			default:
				aTu1diZ06CQRrPBhZSvF(base.ValidationHelper, validator, TimerSettings.PropertyUid, QpUEb1Z0Wik4skYvgIbs(V9n9gAZ09lKaUbwPVM6b(-398691253 ^ -398529781)), true);
				num2 = 4;
				break;
			case 8:
				if (FFUdW0Z0jR7JH9oMym1C(TimerSettings) != StartTimerType.RelativeTime)
				{
					return;
				}
				num2 = 7;
				break;
			case 1:
				return;
			case 2:
				if (FFUdW0Z0jR7JH9oMym1C(TimerSettings) != 0)
				{
					num2 = 8;
					break;
				}
				goto case 7;
			case 5:
				_003C_003Ec__DisplayClass5_.propType = ((FFUdW0Z0jR7JH9oMym1C(TimerSettings) == StartTimerType.ExactTime) ? DateTimeDescriptor.UID : TimeSpanDescriptor.UID);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override void Validate(WorkflowProcessValidator validator)
	{
		int num = 3;
		int num2 = num;
		EventTrigger eventTrigger = default(EventTrigger);
		while (true)
		{
			switch (num2)
			{
			case 4:
				E13VSvZ03wLsqaBKBYVb(this, validator);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				base.Validate(validator);
				num2 = 2;
				break;
			case 2:
				eventTrigger = base.Trigger;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return;
			default:
				if (eventTrigger != EventTrigger.Timer)
				{
					return;
				}
				num2 = 4;
				break;
			}
		}
	}

	public virtual Type[] GetAvaiableOutputElementTypes()
	{
		return HintDrawElementHelper.GetAvaiableOutputElementTypes<IntermediateEventElement>();
	}

	public override string HtmlBody(Element element, List<ProcessContext> contexts, int orgStructVersion, bool subFolders, WorkflowDiagram diagram, IWorkflowProcess wp = null, GenerationSettings gs = null)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1028861977 ^ -1028719355) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1542190822 ^ -1542023892)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105863102 ^ -105720792) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1001967776 ^ -1002065494)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1657582555 ^ -1657700601));
		stringBuilder.Append(base.HtmlBody(element, contexts, orgStructVersion, subFolders, diagram, (IWorkflowProcess)null, (GenerationSettings)null));
		EventTrigger eventTrigger = base.Trigger;
		if (eventTrigger == EventTrigger.Timer)
		{
			stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2F44D93A ^ 0x2F46A0D2) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A69C5CD ^ 0x6A6B5A33)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x350C0E8 ^ 0x352BC82) + base.Trigger.GetDisplayName() + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C663DA1 ^ 0x1C640E83));
			if (TimerSettings != null)
			{
				stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-862330810 ^ -862203228) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DB28AD2 ^ 0x5DB02AC2)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2057730233 ^ -2057623695));
				stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1712492721 ^ -1712325033));
				if (TimerSettings.StartTimerType != StartTimerType.СycleStart)
				{
					string text = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4943E3E4 ^ 0x4941D106) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105863102 ^ -105773036)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418337216 ^ 0x5488BB40) + TimerSettings.StartTimerType.GetDisplayName();
					stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-667465279 ^ -667555495) + text + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x438A0E43 ^ 0x43883D57));
					string text2 = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1927DA93 ^ 0x1925E871) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x63D6C913 ^ 0x63D469D3)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1028861977 ^ -1028755609) + TimerSettings.TimeSetType.GetDisplayName();
					stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7381F16B ^ 0x738351F3) + text2 + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-862330810 ^ -862203054));
					switch (TimerSettings.TimeSetType)
					{
					case TimeSetType.ExactValue:
						if (TimerSettings.StartTimerType == StartTimerType.ExactTime && TimerSettings.ExactTimeValue != DateTime.MinValue)
						{
							stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-22348816 ^ -22492910) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x438A0E43 ^ 0x4388AEA9)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-683713632 ^ -683803872) + TimerSettings.ExactTimeValue.ToString(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6C7F14 ^ 0x6EDE1A)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--601115071 ^ 0x23D67A9D));
						}
						if (TimerSettings.StartTimerType == StartTimerType.RelativeTime && TimerSettings.RelativeTimeValue != TimeSpan.Zero)
						{
							TimeSpan relativeTimeValue = TimerSettings.RelativeTimeValue;
							stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1657582555 ^ -1657672425) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29981480 ^ -30137294)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-720457373 ^ -720629277) + string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-885093259 ^ -885248747), SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x46EA3D1 ^ 0x46C02A9)), relativeTimeValue.Days) + string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4FD00585 ^ 0x4FD2A407), SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1776305410 ^ -1776477342)), relativeTimeValue.Hours) + string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1AF6F1F2 ^ 0x1AF45070), SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x738ABA6E ^ 0x73881BC6)), relativeTimeValue.Minutes) + string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x65B7F624 ^ 0x65B5579C), SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1647793954 ^ -1647703794)), relativeTimeValue.Seconds) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1927DA93 ^ 0x1925E987));
						}
						break;
					case TimeSetType.ContextVar:
					{
						string text3 = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4943E3E4 ^ 0x494293C2) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2077784392 ^ -2077939878)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1436248540 ^ 0x559B1E14);
						if (TimerSettings.PropertyUid != Guid.Empty)
						{
							foreach (ProcessContext context in contexts)
							{
								EntityPropertyMetadata entityPropertyMetadata = ((IEnumerable<EntityPropertyMetadata>)context.EntityProperties).FirstOrDefault((EntityPropertyMetadata p) => l2xYvgZ0ps1BKPEFth91(voZLvdZ0QsXx1EISxlFl(p), TimerSettings.PropertyUid));
								if (entityPropertyMetadata != null)
								{
									text3 = (string.IsNullOrWhiteSpace(entityPropertyMetadata.DisplayName) ? entityPropertyMetadata.Name : HTMLUtility.InsertHyperLink(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-360662087 ^ -360519719), entityPropertyMetadata.Uid.ToString().Replace(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-684210684 ^ -684329466), "")), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1716629332 ^ -1716777776), entityPropertyMetadata.DisplayName));
									break;
								}
							}
						}
						stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-25709590 ^ -25881896) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638225214 ^ -1638357550)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-862330810 ^ -862240570) + text3 + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xDF4D1F8 ^ 0xDF6E2EC));
						break;
					}
					}
				}
				else
				{
					string text4 = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x37E97159 ^ 0x37EB43BB) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xA7339EE ^ 0xA7199B8)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-642713667 ^ -642623683) + TimerSettings.StartTimerType.GetDisplayName();
					stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-935313063 ^ -935140927) + text4 + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2077784392 ^ -2077903444));
					string text5 = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x101D10F ^ 0x103E3ED) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1436248540 ^ 0x5599CBDC)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F534A5C ^ 0x5F51EADC) + TimerSettings.CycleInterval.GetDisplayName();
					stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-130098986 ^ -130254770) + text5 + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4940763B ^ 0x4942452F));
					stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1EA50FCC ^ 0x1EA7AEFE) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x51EF0063 ^ 0x51EDA275)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x65B7F624 ^ 0x65B5541C));
					StringBuilder stringBuilder2 = new StringBuilder();
					stringBuilder2.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-495296780 ^ -495424490) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-667465279 ^ -667554927)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1108877388 ^ -1109033494));
					foreach (TimeSpan time in TimerSettings.CycleTable.Times)
					{
						stringBuilder2.Append(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1108877388 ^ -1109033536), time.ToString(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-682910880 ^ -683066890)), time.ToString(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1965291699 ^ -1965120045)), time.ToString(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-865213812 ^ -865124310))));
					}
					stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6871CA ^ 0x6AD364));
					switch (TimerSettings.CycleInterval)
					{
					case EventCycleInterval.Day:
						stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x70EBB9F3 ^ 0x70E98B55));
						stringBuilder.Append(stringBuilder2);
						stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-14356676 ^ -14332072));
						break;
					case EventCycleInterval.Week:
						stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-865213812 ^ -865087446));
						stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xB7793C9 ^ 0xB75A12B) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x46EA3D1 ^ 0x46C013F)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C663DA1 ^ 0x1C649FFF));
						foreach (int item in TimerSettings.CycleTable.DaysOfWeek)
						{
							stringBuilder.Append(GetDayOfWeekName(item) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x75872B6 ^ 0x75A4194));
						}
						stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-790221436 ^ -790131232));
						stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1436248540 ^ 0x55995B7A));
						stringBuilder.Append(stringBuilder2);
						stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1145BED7 ^ 0x11441EB3));
						break;
					case EventCycleInterval.Month:
					{
						stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1436248540 ^ 0x55995B7A));
						stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-667465279 ^ -667583709) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-947937941 ^ -948093331)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-197778752 ^ -197885794));
						for (int i = 0; i < TimerSettings.CycleTable.DaysOfMonth.Count; i++)
						{
							int num = TimerSettings.CycleTable.DaysOfMonth[i];
							stringBuilder.Append((i == 0) ? string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1514166050 ^ -1514183986), num) : string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1134D2C0 ^ 0x113692CC), num));
						}
						stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-683713632 ^ -683841274));
						stringBuilder.Append(stringBuilder2);
						stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F800F5B ^ 0x5F81AF3F));
						break;
					}
					}
					stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-452127399 ^ -451955123));
				}
				stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-935313063 ^ -935144663));
			}
		}
		return stringBuilder.ToString();
	}

	public new void ReplaceContextVar(Dictionary<Guid, Guid> ReplaceContextVar)
	{
		if (TimerSettings != null)
		{
			Guid value = Guid.Empty;
			if (ReplaceContextVar.TryGetValue(TimerSettings.PropertyUid, out value))
			{
				TimerSettings.PropertyUid = value;
			}
		}
	}

	public IntermediateEventElement()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Q23IycZ0T0nuCPxKJSND();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool iKIVWgZ0LyBWj1o6oLlJ()
	{
		return PjYBIOZ0Hv7IrT3qET1d == null;
	}

	internal static IntermediateEventElement C5wdu9Z0f12Q0nKqcp2D()
	{
		return PjYBIOZ0Hv7IrT3qET1d;
	}

	internal static object V9n9gAZ09lKaUbwPVM6b(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object QpUEb1Z0Wik4skYvgIbs(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static StartTimerType FFUdW0Z0jR7JH9oMym1C(object P_0)
	{
		return ((IntermediateTimerSettings)P_0).StartTimerType;
	}

	internal static TimeSetType mlZ1yBZ0RZly6JZ7SyWe(object P_0)
	{
		return ((IntermediateTimerSettings)P_0).TimeSetType;
	}

	internal static void aTu1diZ06CQRrPBhZSvF(object P_0, object P_1, Guid propertyUid, object P_3, bool errorOnEmptyUid)
	{
		((ElementValidationHelper)P_0).ValidatePropertyExists((WorkflowProcessValidator)P_1, propertyUid, (string)P_3, errorOnEmptyUid);
	}

	internal static Guid MEnq6YZ0qIyqhuI9g96D(object P_0)
	{
		return ((IntermediateTimerSettings)P_0).PropertyUid;
	}

	internal static void E13VSvZ03wLsqaBKBYVb(object P_0, object P_1)
	{
		((IntermediateEventElement)P_0).ValidateTimer((WorkflowProcessValidator)P_1);
	}

	internal static void Q23IycZ0T0nuCPxKJSND()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static Guid voZLvdZ0QsXx1EISxlFl(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static bool l2xYvgZ0ps1BKPEFth91(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}
}
