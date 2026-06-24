using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Diagrams.Toolbox;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Scheduling.DTO.Models;
using EleWise.ELMA.Scheduling.Models;
using EleWise.ELMA.Security.DTO.Managers;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Gateways;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Swimlanes;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Events;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Toolbox;
using EleWise.ELMA.Workflow.Diagrams;
using EleWise.ELMA.Workflow.DTO.Models;
using EleWise.ELMA.Workflow.ExtensionPoints;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Properties;
using EleWise.ELMA.Workflow.Validation;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;

[Serializable]
[HintShape(typeof(StartEventHintShape))]
[Shape(typeof(StartEventShape))]
public class StartEventElement : EventElement, IHintDrawElement, IFormDependency, IElementWithView, IElementWithFormConstructorView
{
	[Component(Order = 100)]
	public class ToolboxItem : IBPMNToolboxItem, IToolboxItem, IContainingElementIcon
	{
		internal static ToolboxItem tt98ZKvuIUemha2YfW8h;

		public string Name => (string)lsJIysvuNNcAJ2s5RjJi(M8HFlUvuesT5u8Ly2YOP(-980570076 ^ -980472176));

		public Guid GroupUid => BPMNGroups.Events.UID;

		public Image Image => Resources.symb_event_start;

		public Type ElementType => NIL9m9vuxCCSKK0wueU7(typeof(StartEventElement).TypeHandle);

		public string ElementIcon => (string)M8HFlUvuesT5u8Ly2YOP(0x34EA50D4 ^ 0x34E88E8A);

		public ToolboxItem()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			Ud69XpvuS6Dr2AYfCQcm();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object M8HFlUvuesT5u8Ly2YOP(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object lsJIysvuNNcAJ2s5RjJi(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool BbFtVqvuahTWKvg6Al4U()
		{
			return tt98ZKvuIUemha2YfW8h == null;
		}

		internal static ToolboxItem zsf9GlvureRwHqgBN0nl()
		{
			return tt98ZKvuIUemha2YfW8h;
		}

		internal static Type NIL9m9vuxCCSKK0wueU7(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static void Ud69XpvuS6Dr2AYfCQcm()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	[Component(Order = 100)]
	private class UserTaskHintExtension : HintDrawElementExtension<StartEventElement>
	{
		internal static object Dvt1eIvu1k5VlglQE3tH;

		public override Type[] TargetElementTypes => new Type[1] { qhsoCLvuwEugOSBVboNI(typeof(UserTaskElement).TypeHandle) };

		public UserTaskHintExtension()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			pjvi0Avu4bPb237Fago8();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static Type qhsoCLvuwEugOSBVboNI(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static bool a9k41gvuhogoVnVUOx6m()
		{
			return Dvt1eIvu1k5VlglQE3tH == null;
		}

		internal static UserTaskHintExtension B1mdn3vuEJ4B8vKtX1hh()
		{
			return (UserTaskHintExtension)Dvt1eIvu1k5VlglQE3tH;
		}

		internal static void pjvi0Avu4bPb237Fago8()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	[Component(Order = 300)]
	private class ExclusiveGatewayHintExtension : HintDrawElementExtension<StartEventElement>
	{
		private static object O0teh2vuzbnWyOkQ8t9s;

		public override Type[] TargetElementTypes => new Type[1] { typeof(ExclusiveGatewayElement) };

		public ExclusiveGatewayHintExtension()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			ETJRyHvDZWWlh6sQwHgq();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool Mao9vvvDK1vhRJUj3xfZ()
		{
			return O0teh2vuzbnWyOkQ8t9s == null;
		}

		internal static ExclusiveGatewayHintExtension oXthOmvDOyovr1P99r4A()
		{
			return (ExclusiveGatewayHintExtension)O0teh2vuzbnWyOkQ8t9s;
		}

		internal static void ETJRyHvDZWWlh6sQwHgq()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	[Component(Order = 400)]
	private class IntermediateEventHintExtension : HintDrawElementExtension<StartEventElement>
	{
		internal static object S9FL3CvDvx5RoDMxDcdx;

		public override Type[] TargetElementTypes => new Type[1] { W62ovfvDs3R6nNdgX04F(typeof(IntermediateEventElement).TypeHandle) };

		public IntermediateEventHintExtension()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static Type W62ovfvDs3R6nNdgX04F(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static bool sa0fkfvDY0BCsZesUBoA()
		{
			return S9FL3CvDvx5RoDMxDcdx == null;
		}

		internal static IntermediateEventHintExtension LMEGhcvD8iACJeysNik4()
		{
			return (IntermediateEventHintExtension)S9FL3CvDvx5RoDMxDcdx;
		}
	}

	internal static StartEventElement EEgsbtZ02NSXfirTImSN;

	public StartEventTriggerSettings EventSettings
	{
		[CompilerGenerated]
		get
		{
			return _003CEventSettings_003Ek__BackingField;
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
					_003CEventSettings_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 == 0)
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

	public StartTimerSettings TimerSettings
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
				case 1:
					_003CTimerSettings_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be != 0)
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

	public FormView View
	{
		[CompilerGenerated]
		get
		{
			return _003CView_003Ek__BackingField;
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
					_003CView_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Guid FormUid
	{
		[CompilerGenerated]
		get
		{
			return _003CFormUid_003Ek__BackingField;
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
					_003CFormUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 != 0)
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

	string IFormDependency.Name => (string)c7GOqnZ04ZmvHdtNyoeH(this);

	IList<Guid> IFormDependency.FormUids
	{
		get
		{
			List<Guid> list = new List<Guid>();
			if (FormUid != Guid.Empty)
			{
				list.Add(FormUid);
			}
			return list;
		}
	}

	public bool DefaultDependency
	{
		[CompilerGenerated]
		get
		{
			return _003CDefaultDependency_003Ek__BackingField;
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
					_003CDefaultDependency_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a == 0)
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
		//Discarded unreachable code: IL_011a, IL_0164, IL_01fd, IL_0226, IL_0235, IL_026a, IL_0279, IL_02cb, IL_02da
		int num = 13;
		SwimlaneElement swimlane = default(SwimlaneElement);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 13:
					swimlane = GetSwimlane((Diagram)KD5yXOZ0I3lBiUDZQWsS(WqOXjeZ0iZsC51mAiCbC(validator)));
					num2 = 12;
					continue;
				case 9:
					validator.Messages.Add((ProcessValidationMessage)WegSanZ0aZojDL1r9ZWM(base.ValidationHelper, SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1214182792 ^ -1214244884))));
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d != 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
					validator.Messages.Add((ProcessValidationMessage)WegSanZ0aZojDL1r9ZWM(base.ValidationHelper, aDhb79Z0evtYLtUfyRU3(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1895853023 ^ -1895921115))));
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b != 0)
					{
						num2 = 3;
					}
					continue;
				case 15:
					validator.Messages.Add((ProcessValidationMessage)WegSanZ0aZojDL1r9ZWM(base.ValidationHelper, aDhb79Z0evtYLtUfyRU3(O8ieglZ0SdxmA7dGvsm1(-10408775 ^ -10472755))));
					num2 = 5;
					continue;
				case 8:
					return;
				case 17:
					break;
				case 7:
					if (Q8bShRZ01yBohJA1sLbk(TimerSettings) != null)
					{
						if (mZlqpUZ0h3OH23SB0Mq7(Q8bShRZ01yBohJA1sLbk(TimerSettings)) != SchedulerTaskStatus.Disabled)
						{
							return;
						}
						num2 = 17;
					}
					else
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 != 0)
						{
							num2 = 11;
						}
					}
					continue;
				case 4:
				case 14:
					if (qoUKHMZ0r6s0mkgeLeZZ(swimlane) == SwimlaneType.Static)
					{
						num2 = 18;
						continue;
					}
					goto case 2;
				case 1:
				case 3:
				case 5:
				case 16:
					if (TimerSettings == null)
					{
						num2 = 10;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 != 0)
						{
							num2 = 10;
						}
						continue;
					}
					goto case 7;
				default:
					if (ouNay0Z0x7q7fro5g3JP(Locator.GetService<IOrganizationItemDTOManager>(), p8lfOPZ0NT3P4mooNjcc(swimlane)) != null)
					{
						num2 = 11;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b == 0)
						{
							num2 = 16;
						}
						continue;
					}
					goto case 15;
				case 6:
					return;
				case 12:
					if (swimlane != null)
					{
						num2 = 14;
						continue;
					}
					goto case 9;
				case 10:
				case 11:
					validator.Messages.Add((ProcessValidationMessage)WegSanZ0aZojDL1r9ZWM(base.ValidationHelper, aDhb79Z0evtYLtUfyRU3(O8ieglZ0SdxmA7dGvsm1(-1574607501 ^ -1574437989))));
					num2 = 8;
					continue;
				}
				break;
			}
			validator.Messages.Add((ProcessValidationMessage)jFnmxoZ0E9bZThZosc0I(base.ValidationHelper, aDhb79Z0evtYLtUfyRU3(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-39189604 ^ -39280466))));
			num = 6;
		}
	}

	protected virtual void ValidateEvent(WorkflowProcessValidator validator)
	{
		//Discarded unreachable code: IL_017e, IL_018d, IL_01bb, IL_01ca, IL_01d9, IL_02b5, IL_02c4, IL_02d4, IL_02e3, IL_038d, IL_049c, IL_04ab, IL_04ba
		int num = 12;
		IEnumerable<IEventTrigger> extensionPoints = default(IEnumerable<IEventTrigger>);
		IEventTrigger eventTrigger = default(IEventTrigger);
		List<string> warnings = default(List<string>);
		List<string> errors = default(List<string>);
		SwimlaneElement swimlane = default(SwimlaneElement);
		_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = default(_003C_003Ec__DisplayClass10_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
				case 18:
				case 22:
				case 26:
					if (EventSettings != null)
					{
						num2 = 8;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 != 0)
						{
							num2 = 4;
						}
						break;
					}
					goto case 16;
				case 21:
					return;
				case 25:
					extensionPoints = ((ComponentManager)Y3YHk7Z0wv6NktvM97V3()).GetExtensionPoints<IEventTrigger>();
					num2 = 17;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 == 0)
					{
						num2 = 13;
					}
					break;
				case 10:
					return;
				case 23:
					return;
				case 9:
					if (eventTrigger == null)
					{
						num2 = 3;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 == 0)
						{
							num2 = 7;
						}
						break;
					}
					eventTrigger.ValidateSettings(EventSettings, out warnings, out errors);
					num2 = 13;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 != 0)
					{
						num2 = 11;
					}
					break;
				default:
					if (ouNay0Z0x7q7fro5g3JP(Locator.GetService<IOrganizationItemDTOManager>(), swimlane.DepartmentId) != null)
					{
						num2 = 5;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c == 0)
						{
							num2 = 5;
						}
						break;
					}
					goto case 29;
				case 27:
					_003C_003Ec__DisplayClass10_.validator.Messages.Add((ProcessValidationMessage)WegSanZ0aZojDL1r9ZWM(base.ValidationHelper, aDhb79Z0evtYLtUfyRU3(O8ieglZ0SdxmA7dGvsm1(-1028861977 ^ -1028795933))));
					num2 = 26;
					break;
				case 6:
					warnings.ForEach(_003C_003Ec__DisplayClass10_._003CValidateEvent_003Eb__1);
					num2 = 19;
					break;
				case 1:
					return;
				case 8:
					if (!(EventSettings.EventTriggerUid == Guid.Empty))
					{
						num2 = 25;
						break;
					}
					goto case 16;
				case 13:
					if (!warnings.Any())
					{
						num2 = 28;
						break;
					}
					goto case 6;
				case 4:
				case 20:
					if (swimlane.SwimlaneType == SwimlaneType.Static)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 27;
				case 16:
					_003C_003Ec__DisplayClass10_.validator.Messages.Add((ProcessValidationMessage)WegSanZ0aZojDL1r9ZWM(base.ValidationHelper, aDhb79Z0evtYLtUfyRU3(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-135674354 ^ -135567878))));
					num2 = 21;
					break;
				case 15:
					if (swimlane != null)
					{
						goto end_IL_0012;
					}
					goto case 14;
				case 31:
					errors.ForEach(_003C_003Ec__DisplayClass10_._003CValidateEvent_003Eb__2);
					num2 = 23;
					break;
				case 14:
					_003C_003Ec__DisplayClass10_.validator.Messages.Add((ProcessValidationMessage)WegSanZ0aZojDL1r9ZWM(base.ValidationHelper, aDhb79Z0evtYLtUfyRU3(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1600060848 ^ -1600118844))));
					num2 = 22;
					break;
				case 19:
				case 28:
					if (!errors.Any())
					{
						num2 = 10;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 31;
				case 3:
					return;
				case 29:
					_003C_003Ec__DisplayClass10_.validator.Messages.Add((ProcessValidationMessage)WegSanZ0aZojDL1r9ZWM(base.ValidationHelper, aDhb79Z0evtYLtUfyRU3(O8ieglZ0SdxmA7dGvsm1(0x246EEF98 ^ 0x246FF1EC))));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 != 0)
					{
						num2 = 18;
					}
					break;
				case 17:
					if (extensionPoints.Any())
					{
						eventTrigger = extensionPoints.FirstOrDefault(_003C_003Ec__DisplayClass10_._003CValidateEvent_003Eb__0);
						num2 = 9;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 != 0)
						{
							num2 = 1;
						}
					}
					else
					{
						num2 = 5;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 == 0)
						{
							num2 = 24;
						}
					}
					break;
				case 7:
					_003C_003Ec__DisplayClass10_.validator.Messages.Add((ProcessValidationMessage)WegSanZ0aZojDL1r9ZWM(base.ValidationHelper, aDhb79Z0evtYLtUfyRU3(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6871CA ^ 0x6AD23E))));
					num2 = 3;
					break;
				case 11:
					_003C_003Ec__DisplayClass10_._003C_003E4__this = this;
					num2 = 28;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd == 0)
					{
						num2 = 32;
					}
					break;
				case 30:
					swimlane = GetSwimlane((Diagram)KD5yXOZ0I3lBiUDZQWsS(WqOXjeZ0iZsC51mAiCbC(_003C_003Ec__DisplayClass10_.validator)));
					num2 = 15;
					break;
				case 32:
					_003C_003Ec__DisplayClass10_.validator = validator;
					num2 = 30;
					break;
				case 24:
					_003C_003Ec__DisplayClass10_.validator.Messages.Add(base.ValidationHelper.CreateValidationError((string)aDhb79Z0evtYLtUfyRU3(O8ieglZ0SdxmA7dGvsm1(0x8D5763A ^ 0x8D7D276))));
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e == 0)
					{
						num2 = 1;
					}
					break;
				case 12:
					_003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
					num2 = 11;
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	public override void Validate(WorkflowProcessValidator validator)
	{
		//Discarded unreachable code: IL_00f4, IL_0103
		int num = 10;
		EventTrigger eventTrigger = default(EventTrigger);
		SwimlaneElement swimlane = default(SwimlaneElement);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 5:
					if (eventTrigger != EventTrigger.Timer)
					{
						num2 = 3;
						continue;
					}
					ntWaP5Z0ztH3oWA8rJyB(this, validator);
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					if (qoUKHMZ0r6s0mkgeLeZZ(swimlane) == SwimlaneType.DynamicScript)
					{
						num = 8;
						break;
					}
					goto case 2;
				case 9:
					swimlane = GetSwimlane((Diagram)KD5yXOZ0I3lBiUDZQWsS(WqOXjeZ0iZsC51mAiCbC(validator)));
					num2 = 7;
					continue;
				case 3:
					if (eventTrigger != EventTrigger.Event)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af != 0)
						{
							num2 = 0;
						}
					}
					else
					{
						BAONRtZyKhHSfHV60Ac2(this, validator);
						num2 = 11;
					}
					continue;
				case 0:
					return;
				case 7:
					if (swimlane == null)
					{
						num = 6;
						break;
					}
					goto case 1;
				case 8:
					validator.Messages.Add((ProcessValidationMessage)WegSanZ0aZojDL1r9ZWM(base.ValidationHelper, SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6F6D7B44 ^ 0x6F6FDFD2), c7GOqnZ04ZmvHdtNyoeH(swimlane))));
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 == 0)
					{
						num2 = 2;
					}
					continue;
				case 10:
					base.Validate(validator);
					num2 = 9;
					continue;
				case 2:
				case 6:
					eventTrigger = base.Trigger;
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 == 0)
					{
						num2 = 5;
					}
					continue;
				case 4:
					return;
				case 11:
					return;
				}
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
		stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-862330810 ^ -862203228) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x213F6477 ^ 0x213DF841)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-17847711 ^ -17967605) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1542190822 ^ -1542023250)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-801808857 ^ -801673979));
		stringBuilder.Append(base.HtmlBody(element, contexts, orgStructVersion, subFolders, diagram, (IWorkflowProcess)null, (GenerationSettings)null));
		EventTrigger eventTrigger = base.Trigger;
		if (eventTrigger == EventTrigger.Timer)
		{
			stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x246EEF98 ^ 0x246CDD7A) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--727842433 ^ 0x2B63617F)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-642713667 ^ -642610217) + base.Trigger.GetDisplayName() + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1542190822 ^ -1542047176));
			if (TimerSettings != null)
			{
				stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-10408775 ^ -10281381) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398691253 ^ -398535589)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x101D10F ^ 0x1035335));
				stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1843E01F ^ 0x18417107));
				if (TimerSettings.SchedulerTask != null && TimerSettings.SchedulerTask.Settings != null)
				{
					stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-14356676 ^ -14230050) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F534A5C ^ 0x5F51EF38)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1843E01F ^ 0x18414565));
					NthIncludedDaySettings settings = TimerSettings.SchedulerTask.Settings;
					string value = SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DB28AD2 ^ 0x5DB02F48)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x75872B6 ^ 0x759263C) + settings.StartDate.ToString(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DB28AD2 ^ 0x5DB02F78)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-452127399 ^ -451991941);
					switch (settings.ScheduleType)
					{
					case ScheduleType.Daily:
						stringBuilder.Append(value);
						stringBuilder.Append(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-360662087 ^ -360571283)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-720457373 ^ -720378391) + settings.DailySettings.EveryDay + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x74AB4717 ^ 0x74A9E2EF)) + (settings.DailySettings.OnlyWorkDays ? (SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-22348816 ^ -22504678) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x74AB4717 ^ 0x74A9E115)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F534A5C ^ 0x5F531D2E)) : string.Empty));
						break;
					case ScheduleType.Monthly:
						stringBuilder.Append(value);
						stringBuilder.Append(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1776305410 ^ -1776476976)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105863102 ^ -105771512) + settings.MonthlySettings.MonthDay + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x74AB4717 ^ 0x74A97FC5) + ((settings.MonthlySettings.DaySelectionType == MonthlySettings.MonthDaySelectionType.MonthWorkDay) ? (SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-11799394 ^ -11955084) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x438A0E43 ^ 0x4388A819)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1895853023 ^ -1895840941)) : string.Empty));
						if (settings.MonthlySettings.Months == null || settings.MonthlySettings.Months.Count <= 0)
						{
							break;
						}
						if (settings.MonthlySettings.Months.Count == 12)
						{
							stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1574607501 ^ -1574452475) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x70EBB9F3 ^ 0x70E91F79)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-935313063 ^ -935139333));
							break;
						}
						stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x46EA3D1 ^ 0x46C32C9));
						foreach (int month in settings.MonthlySettings.Months)
						{
							stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7381F16B ^ 0x7383C263) + GetMonthName(month) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-11799394 ^ -11942006));
						}
						stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1050383744 ^ -1050216208));
						break;
					case ScheduleType.Once:
						stringBuilder.Append(value);
						break;
					case ScheduleType.Weekly:
						stringBuilder.Append(value);
						stringBuilder.Append(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C7F6FED ^ 0x1C7DC957)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x141C968 ^ 0x143F1BA) + settings.WeeklySettings.EveryTime + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x69063C81 ^ 0x69040453) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1712492721 ^ -1712338543)));
						if (settings.WeeklySettings.DaysFoWeek == null || settings.WeeklySettings.DaysFoWeek.Count <= 0)
						{
							break;
						}
						if (settings.WeeklySettings.DaysFoWeek.Count == 7)
						{
							stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1134D2C0 ^ 0x1136EA12) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xB7793C9 ^ 0xB753527)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-763667953 ^ -763796771));
							stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1716458555 ^ -1716367949) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-790221436 ^ -790328462)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x213F6477 ^ 0x213DC2D5));
							break;
						}
						stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x747FFBE0 ^ 0x747DC332) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420003255 ^ -420092761)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-801808857 ^ -801675531));
						stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1050383744 ^ -1050215528));
						foreach (DayOfWeek item in settings.WeeklySettings.DaysFoWeek)
						{
							stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-17847711 ^ -17983127) + GetDayOfWeekName(item) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1001967776 ^ -1002103692));
						}
						stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-495296780 ^ -495399804));
						break;
					}
					if (settings.RepeatSettings != null)
					{
						StringBuilder stringBuilder2 = new StringBuilder();
						if (settings.RepeatSettings.RepeatEvery != TimeSpan.Zero)
						{
							stringBuilder2.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-708128192 ^ -708295848));
							string text = ((settings.RepeatSettings.RepeatEvery.Minutes != 0) ? (settings.RepeatSettings.RepeatEvery.Minutes.ToString(CultureInfo.InvariantCulture) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-885093259 ^ -885199713) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-495296780 ^ -495388192)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1050383744 ^ -1050395150)) : (settings.RepeatSettings.RepeatEvery.Hours.ToString(CultureInfo.InvariantCulture) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1386448964 ^ -1386342570) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x651FE29D ^ 0x651D4595)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2057730233 ^ -2057711563)));
							stringBuilder2.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-642713667 ^ -642595659) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-720457373 ^ -720628153)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-763667953 ^ -763796771) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-148495695 ^ -148601349)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x157D5AF4 ^ 0x157F6226) + text + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6C7F14 ^ 0x6CE516));
							stringBuilder2.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--601115071 ^ 0x23D6716D) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-14356676 ^ -14268314)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x595C500A ^ 0x595E68D8) + settings.RepeatSettings.RepeatTo.Hours + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6F6D7B44 ^ 0x6F6F3AD2) + settings.RepeatSettings.RepeatTo.Minutes + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x37E97159 ^ 0x37EB424D));
						}
						if (settings.EndAt.HasValue && settings.EndAt.Value != DateTime.MinValue)
						{
							if (stringBuilder2.Length == 0)
							{
								stringBuilder2.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-949717965 ^ -949557973));
							}
							stringBuilder2.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x17F0C5A2 ^ 0x17F2F6AA) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-25709590 ^ -25881444)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x738ABA6E ^ 0x738BEEE4) + settings.EndAt.Value.ToString(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-720457373 ^ -720628535)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1050383744 ^ -1050257004));
						}
						if (stringBuilder2.Length != 0 || TimerSettings.SchedulerTask.Status == SchedulerTaskStatus.Enabled)
						{
							string text2 = TimerSettings.SchedulerTask.Status switch
							{
								SchedulerTaskStatus.Enabled => SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x738ABA6E ^ 0x73881DE2)), 
								SchedulerTaskStatus.Disabled => SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1212129906 ^ 0x483D05EC)), 
								SchedulerTaskStatus.Closed => SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1716629332 ^ -1716717794)), 
								_ => SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-935313063 ^ -935251585) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x595C500A ^ 0x595ECC0C)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1716458555 ^ -1716478963), 
							};
							if (stringBuilder2.Length == 0)
							{
								stringBuilder2.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x246EEF98 ^ 0x246C7E80));
							}
							stringBuilder2.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6C7F14 ^ 0x6E4C1C) + text2 + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x141C968 ^ 0x143FA7C));
							stringBuilder2.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-148495695 ^ -148590399));
							stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6C7F14 ^ 0x6E4DF6) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-452127399 ^ -451956069)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x213F6477 ^ 0x213DC629));
							stringBuilder.Append(stringBuilder2);
						}
					}
				}
				stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-947937941 ^ -948105445));
			}
		}
		return stringBuilder.ToString();
	}

	public override void ReplaceSignature(Dictionary<string, string> replaceNames)
	{
		if (View != null)
		{
			View.OnLoadScriptName = CopyReplace(View.OnLoadScriptName, replaceNames);
			ReplaceSignatureRecursive(View.Items, replaceNames);
		}
	}

	private void ReplaceSignatureRecursive(ListViewItem items, Dictionary<string, string> replaceNames)
	{
		foreach (PropertyViewItem item in items.OfType<PropertyViewItem>())
		{
			if (item.Attributes != null)
			{
				item.Attributes.OnViewLoadScriptName = CopyReplace(item.Attributes.OnViewLoadScriptName, replaceNames);
				item.Attributes.OnChangeScriptName = CopyReplace(item.Attributes.OnChangeScriptName, replaceNames);
				if (item.Items.Any())
				{
					ReplaceSignatureRecursive(item.Items, replaceNames);
				}
			}
		}
	}

	public StartEventElement()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		HCqunCZyOEun6t8KV9Wo();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool EAxQN8Z0oy7PT1D0p7Wm()
	{
		return EEgsbtZ02NSXfirTImSN == null;
	}

	internal static StartEventElement IwCgn0Z0Fui7WXwulxmd()
	{
		return EEgsbtZ02NSXfirTImSN;
	}

	internal static object WqOXjeZ0iZsC51mAiCbC(object P_0)
	{
		return ((WorkflowProcessValidator)P_0).Process;
	}

	internal static object KD5yXOZ0I3lBiUDZQWsS(object P_0)
	{
		return ((WorkflowProcessDTO)P_0).Diagram;
	}

	internal static object WegSanZ0aZojDL1r9ZWM(object P_0, object P_1)
	{
		return ((ElementValidationHelper)P_0).CreateValidationError((string)P_1);
	}

	internal static SwimlaneType qoUKHMZ0r6s0mkgeLeZZ(object P_0)
	{
		return ((SwimlaneElement)P_0).SwimlaneType;
	}

	internal static object aDhb79Z0evtYLtUfyRU3(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static long p8lfOPZ0NT3P4mooNjcc(object P_0)
	{
		return ((SwimlaneElement)P_0).DepartmentId;
	}

	internal static object ouNay0Z0x7q7fro5g3JP(object P_0, long P_1)
	{
		return ((IOrganizationItemDTOManager)P_0).LoadOrNull(P_1);
	}

	internal static object O8ieglZ0SdxmA7dGvsm1(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object Q8bShRZ01yBohJA1sLbk(object P_0)
	{
		return ((StartTimerSettings)P_0).SchedulerTask;
	}

	internal static SchedulerTaskStatus mZlqpUZ0h3OH23SB0Mq7(object P_0)
	{
		return ((SchedulerTaskDTO)P_0).Status;
	}

	internal static object jFnmxoZ0E9bZThZosc0I(object P_0, object P_1)
	{
		return ((ElementValidationHelper)P_0).CreateValidationWarning((string)P_1);
	}

	internal static object Y3YHk7Z0wv6NktvM97V3()
	{
		return ComponentManager.Current;
	}

	internal static object c7GOqnZ04ZmvHdtNyoeH(object P_0)
	{
		return ((Element)P_0).Name;
	}

	internal static void ntWaP5Z0ztH3oWA8rJyB(object P_0, object P_1)
	{
		((StartEventElement)P_0).ValidateTimer((WorkflowProcessValidator)P_1);
	}

	internal static void BAONRtZyKhHSfHV60Ac2(object P_0, object P_1)
	{
		((StartEventElement)P_0).ValidateEvent((WorkflowProcessValidator)P_1);
	}

	internal static void HCqunCZyOEun6t8KV9Wo()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
