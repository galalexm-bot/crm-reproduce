using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Swimlanes;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.SubProcess;
using EleWise.ELMA.Workflow.Diagrams;
using EleWise.ELMA.Workflow.Diagrams.Elements;
using EleWise.ELMA.Workflow.DTO.Managers;
using EleWise.ELMA.Workflow.DTO.Models;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Validation;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.SubProcess;

[Serializable]
[SupportedMarker(TaskMarker.Condition)]
[SupportedMarker(TaskMarker.Loop)]
[WebDiagrammerShape(typeof(WebDiagrammerInternalSubprocessShape))]
public abstract class SubProcessElement : BPMNFlowElement, IHintDrawElement, IReplaceContextVar
{
	private TaskMarker marker;

	private bool terminateParentProcess;

	private bool terminateChildProcesses;

	internal static SubProcessElement JLUO6UZ8axKgPl4XgeNh;

	public override string DefaultName => (string)Js9ytwZ8xohGVr0b3FrZ(Ctk9tCZ8NXxKPxyKF2Fs(-684210684 ^ -684373212));

	public virtual long ProcessHeaderId
	{
		[CompilerGenerated]
		get
		{
			return _003CProcessHeaderId_003Ek__BackingField;
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
					_003CProcessHeaderId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public TaskMarker Marker
	{
		get
		{
			return marker;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					L9EAcrZ8Sx2qsKDo3cxj(this);
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 == 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					marker = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return;
				}
			}
		}
	}

	public LoopCondition LoopCondition
	{
		[CompilerGenerated]
		get
		{
			return _003CLoopCondition_003Ek__BackingField;
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
					_003CLoopCondition_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 == 0)
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

	public Condition Condition
	{
		[CompilerGenerated]
		get
		{
			return _003CCondition_003Ek__BackingField;
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
					_003CCondition_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public MultiInstanceSettings MultiInstanceSettings
	{
		[CompilerGenerated]
		get
		{
			return _003CMultiInstanceSettings_003Ek__BackingField;
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
					_003CMultiInstanceSettings_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 == 0)
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

	public bool TerminateParentProcess
	{
		get
		{
			return terminateParentProcess;
		}
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
					terminateParentProcess = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool TerminateChildProcesses
	{
		get
		{
			return terminateChildProcesses;
		}
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
					terminateChildProcesses = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 != 0)
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

	public bool CanAddMembers
	{
		[CompilerGenerated]
		get
		{
			return _003CCanAddMembers_003Ek__BackingField;
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
					_003CCanAddMembers_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public List<Worker> Members { get; set; }

	public override string ChapterName => (string)Js9ytwZ8xohGVr0b3FrZ(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-45832783 ^ -45732971));

	public override void ReplaceContextVar(Dictionary<Guid, Guid> ReplaceContextVar)
	{
		base.ReplaceContextVar(ReplaceContextVar);
		Guid value = Guid.Empty;
		if (Condition != null && Condition.Table != null && Condition.Table.Items != null)
		{
			foreach (ConditionTable.Item item in Condition.Table.Items)
			{
				if (ReplaceContextVar.TryGetValue(item.Operand1.PropertyUid, out value))
				{
					item.Operand1.PropertyUid = value;
				}
				if (ReplaceContextVar.TryGetValue(item.Operand2.PropertyUid, out value))
				{
					item.Operand2.PropertyUid = value;
				}
			}
		}
		if (LoopCondition == null || LoopCondition.Condition.Table == null || LoopCondition.Condition.Table.Items == null)
		{
			return;
		}
		foreach (ConditionTable.Item item2 in LoopCondition.Condition.Table.Items)
		{
			if (ReplaceContextVar.TryGetValue(item2.Operand1.PropertyUid, out value))
			{
				item2.Operand1.PropertyUid = value;
			}
			if (ReplaceContextVar.TryGetValue(item2.Operand2.PropertyUid, out value))
			{
				item2.Operand2.PropertyUid = value;
			}
		}
	}

	public override void Validate(WorkflowProcessValidator validator)
	{
		//Discarded unreachable code: IL_026d, IL_027c, IL_029c, IL_02ab
		int num = 14;
		int num2 = num;
		ProcessHeaderDTO processHeaderDTO = default(ProcessHeaderDTO);
		TaskMarker taskMarker = default(TaskMarker);
		while (true)
		{
			switch (num2)
			{
			case 9:
			case 11:
				validator.Messages.Add((ProcessValidationMessage)UGGkVNZ84GicO9H066jn(base.ValidationHelper, SR.T((string)Ctk9tCZ8NXxKPxyKF2Fs(-947937941 ^ -948104245), TZRbq0Z8w4e8MQHaTQog(this))));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				validator.Messages.Add(base.ValidationHelper.CreateValidationWarning(SR.T((string)Ctk9tCZ8NXxKPxyKF2Fs(0x1EA50FCC ^ 0x1EA78198), Name)));
				num2 = 12;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 == 0)
				{
					num2 = 9;
				}
				break;
			case 4:
			case 16:
				processHeaderDTO = (ProcessHeaderDTO)qT5rR2Z8hiwZuIg9UWeX(Locator.GetServiceNotNull<IProcessHeaderDTOManager>(), uqA2kXZ81efdYphmxSbt(this));
				num2 = 5;
				break;
			case 8:
				if (taskMarker == TaskMarker.MultiInstance)
				{
					num2 = 6;
					break;
				}
				return;
			case 17:
				return;
			case 15:
				fvkgapZsZ9OoujQL1c7q(base.ValidationHelper, validator, eZGiyDZsOqe2pTUd9Ai3(MultiInstanceSettings), Js9ytwZ8xohGVr0b3FrZ(Ctk9tCZ8NXxKPxyKF2Fs(-772614310 ^ -772777788)), true);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f != 0)
				{
					num2 = 0;
				}
				break;
			case 13:
				if (ProcessHeaderId > 0)
				{
					num2 = 4;
					break;
				}
				goto case 3;
			case 2:
				validator.Messages.Add((ProcessValidationMessage)YIDG8ZZsKUguREDpH8PE(base.ValidationHelper, LhYJ93Z8z6y3S2mnUWmI(Ctk9tCZ8NXxKPxyKF2Fs(0xA7339EE ^ 0xA71B6DA), new object[1] { Name })));
				num2 = 17;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 == 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				if (processHeaderDTO == null)
				{
					num2 = 9;
					break;
				}
				goto case 10;
			case 7:
				return;
			case 6:
				if (MultiInstanceSettings != null)
				{
					if (MultiInstanceSettings.InstanceCountType != MultiInstanceSettings.ValueType.Property)
					{
						return;
					}
					num2 = 15;
				}
				else
				{
					num2 = 2;
				}
				break;
			default:
				taskMarker = Marker;
				num2 = 8;
				break;
			case 10:
				if (XCB9e8Z8EZotpqkUe38I(processHeaderDTO) == WorkflowProcessStatus.Deleted)
				{
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a != 0)
					{
						num2 = 11;
					}
					break;
				}
				goto default;
			case 14:
				base.Validate(validator);
				num2 = 13;
				break;
			case 1:
				base.ValidationHelper.ValidateProperty(validator, eZGiyDZsOqe2pTUd9Ai3(MultiInstanceSettings), delegate(IPropertyMetadata p)
				{
					//Discarded unreachable code: IL_00a2
					int num3 = 1;
					int num4 = num3;
					while (true)
					{
						switch (num4)
						{
						case 3:
							return _003C_003Ec.t5PsjbvPiBWCx0r89N1S(p) == Int64Descriptor.UID;
						case 2:
							return true;
						default:
							if (_003C_003Ec.KR5xJLvPItg42hODPsWE(_003C_003Ec.t5PsjbvPiBWCx0r89N1S(p), Int32Descriptor.UID))
							{
								num4 = 2;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 != 0)
								{
									num4 = 1;
								}
								break;
							}
							goto case 3;
						case 1:
							if (!(_003C_003Ec.t5PsjbvPiBWCx0r89N1S(p) == Int16Descriptor.UID))
							{
								num4 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 == 0)
								{
									num4 = 0;
								}
								break;
							}
							goto case 2;
						}
					}
				}, (string)Js9ytwZ8xohGVr0b3FrZ(Ctk9tCZ8NXxKPxyKF2Fs(-1895853023 ^ -1896020933)));
				num2 = 7;
				break;
			}
		}
	}

	public virtual Type[] GetAvaiableOutputElementTypes()
	{
		return HintDrawElementHelper.GetAvaiableOutputElementTypes<TaskElement>();
	}

	public override string HtmlHeader(ProcessContext context, int orgStructVersion, bool subFolders, WorkflowDiagram diagram, GenerationSettings gs = null)
	{
		return string.Empty;
	}

	public override string HtmlBody(Element element, List<ProcessContext> contexts, int orgStructVersion, bool subFolders, WorkflowDiagram diagram, IWorkflowProcess wp = null, GenerationSettings gs = null)
	{
		StringBuilder stringBuilder = new StringBuilder();
		SwimlaneElement swimlane = GetSwimlane(diagram);
		if (swimlane != null && !string.IsNullOrEmpty(swimlane.Name))
		{
			string arg = HTMLUtility.InsertHyperLink(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-980570076 ^ -980447288), swimlane.Uid.ToString().Replace(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x75872B6 ^ 0x75A42B4), "")), swimlane.Name);
			stringBuilder.Append(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1843E01F ^ 0x184161D1), SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-45832783 ^ -45734839)), arg));
		}
		if (!string.IsNullOrEmpty(element.Description))
		{
			stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x46EA3D1 ^ 0x46C9133) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x51EF0063 ^ 0x51ED385B)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-11799394 ^ -11958028) + element.Description);
		}
		if (TerminateChildProcesses || TerminateParentProcess)
		{
			stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1514166050 ^ -1514300868) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-862330810 ^ -862228236)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1542190822 ^ -1542046730));
			stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6871CA ^ 0x6AE0D2));
			if (TerminateChildProcesses)
			{
				stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-351369538 ^ -351488586) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1539486135 ^ -1539317907)));
			}
			if (TerminateParentProcess)
			{
				stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-495296780 ^ -495424004) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-432000546 ^ -431841254)));
			}
			stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1542190822 ^ -1542022294));
		}
		return stringBuilder.ToString();
	}

	public override string HtmlFooter()
	{
		StringBuilder stringBuilder = new StringBuilder();
		gI0hhtZsYg1aDTMkKAuX(stringBuilder, yoMvEXZsvRdMXdFnyi9P(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-935313063 ^ -935183307), GetConnectorsLink()));
		gI0hhtZsYg1aDTMkKAuX(stringBuilder, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DB28AD2 ^ 0x5DB0F752));
		return stringBuilder.ToString();
	}

	protected SubProcessElement()
	{
		//Discarded unreachable code: IL_0036, IL_003b
		gTD5OPZs8RK1I4XVpDwJ();
		terminateChildProcesses = true;
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object Ctk9tCZ8NXxKPxyKF2Fs(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object Js9ytwZ8xohGVr0b3FrZ(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool GA98g0Z8r8bjnC48EKgR()
	{
		return JLUO6UZ8axKgPl4XgeNh == null;
	}

	internal static SubProcessElement xWZXUwZ8ebkcoAecj7ux()
	{
		return JLUO6UZ8axKgPl4XgeNh;
	}

	internal static void L9EAcrZ8Sx2qsKDo3cxj(object P_0)
	{
		((BPMNFlowElement)P_0).UpdateDecorators();
	}

	internal static long uqA2kXZ81efdYphmxSbt(object P_0)
	{
		return ((SubProcessElement)P_0).ProcessHeaderId;
	}

	internal static object qT5rR2Z8hiwZuIg9UWeX(object P_0, long id)
	{
		return ((IProcessHeaderDTOManager)P_0).LoadOrNull(id);
	}

	internal static WorkflowProcessStatus XCB9e8Z8EZotpqkUe38I(object P_0)
	{
		return ((ProcessHeaderDTO)P_0).Status;
	}

	internal static object TZRbq0Z8w4e8MQHaTQog(object P_0)
	{
		return ((Element)P_0).Name;
	}

	internal static object UGGkVNZ84GicO9H066jn(object P_0, object P_1)
	{
		return ((ElementValidationHelper)P_0).CreateValidationWarning((string)P_1);
	}

	internal static object LhYJ93Z8z6y3S2mnUWmI(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static object YIDG8ZZsKUguREDpH8PE(object P_0, object P_1)
	{
		return ((ElementValidationHelper)P_0).CreateValidationError((string)P_1);
	}

	internal static Guid eZGiyDZsOqe2pTUd9Ai3(object P_0)
	{
		return ((MultiInstanceSettings)P_0).InstanceCountPropertyUid;
	}

	internal static void fvkgapZsZ9OoujQL1c7q(object P_0, object P_1, Guid propertyUid, object P_3, bool errorOnEmptyUid)
	{
		((ElementValidationHelper)P_0).ValidatePropertyExists((WorkflowProcessValidator)P_1, propertyUid, (string)P_3, errorOnEmptyUid);
	}

	internal static object yoMvEXZsvRdMXdFnyi9P(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object gI0hhtZsYg1aDTMkKAuX(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).Append((string)P_1);
	}

	internal static void gTD5OPZs8RK1I4XVpDwJ()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
