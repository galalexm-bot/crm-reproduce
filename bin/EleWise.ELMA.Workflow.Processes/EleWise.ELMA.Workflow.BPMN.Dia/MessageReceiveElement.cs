using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Diagrams.Toolbox;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Tasks;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Toolbox;
using EleWise.ELMA.Workflow.Diagrams;
using EleWise.ELMA.Workflow.Diagrams.Elements;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Properties;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;

[Serializable]
[Shape(typeof(MessageReceiveShape))]
[WebDiagrammerShape(typeof(WebDiagrammerMessageReceiveShape))]
[HintShape(typeof(MessageReceiveHintShape))]
[TaskType(60, "MessageReceive")]
public class MessageReceiveElement : MessageElement, IExceptionFlowSupported, IReplaceContextVar
{
	[Component(Order = 600)]
	public class ToolboxItem : IBPMNToolboxItem, IToolboxItem, IContainingElementIcon
	{
		internal static ToolboxItem jF1HHtHMexOIIqnb7YH;

		public string Name => SR.T((string)B5qW5FHvPmBXwjCfJJF(0x3D87FABF ^ 0x3D876285));

		public Guid GroupUid => BPMNGroups.Operations.UID;

		public Image Image => (Image)hhYTEVHPgCs96JdExc4();

		public Type ElementType => DTvduWH43ROSAZmgx7i(typeof(MessageReceiveElement).TypeHandle);

		public string ElementIcon => (string)B5qW5FHvPmBXwjCfJJF(0xFA4957C ^ 0xFA45838);

		public ToolboxItem()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			AGTrI2H90FHJMmDqvMP();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e496a9998cf542ff98d1a5e001d6c664 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object B5qW5FHvPmBXwjCfJJF(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static bool uWbHjyHaNIFgfkcYfsY()
		{
			return jF1HHtHMexOIIqnb7YH == null;
		}

		internal static ToolboxItem U5WqM3HYpE7nxe3vKc3()
		{
			return jF1HHtHMexOIIqnb7YH;
		}

		internal static object hhYTEVHPgCs96JdExc4()
		{
			return Resources.symb_task_receive;
		}

		internal static Type DTvduWH43ROSAZmgx7i(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static void AGTrI2H90FHJMmDqvMP()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
		}
	}

	internal static MessageReceiveElement GrWwJEU9CR1yuThKZgP;

	public override string DefaultName => (string)RpVKSmUSGZC2Va0xf74(KOdcMXUjLTbM1O5oHTr(-1587393812 ^ -1587359018));

	public Guid UIDMessage
	{
		[CompilerGenerated]
		get
		{
			return _003CUIDMessage_003Ek__BackingField;
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
					_003CUIDMessage_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3ccbd21470394457949c11be6f557154 != 0)
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

	[XmlArray]
	public List<MessageParamMap> MessageParamMapping { get; set; }

	public Guid ControlParamVarUid
	{
		[CompilerGenerated]
		get
		{
			return _003CControlParamVarUid_003Ek__BackingField;
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
					_003CControlParamVarUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_76260b548c684c6c95eb679c837b8945 != 0)
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

	public Condition MessageProcessCondition
	{
		[CompilerGenerated]
		get
		{
			return _003CMessageProcessCondition_003Ek__BackingField;
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
					_003CMessageProcessCondition_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3600d9e606e544d2b67d1fc1ad9becc3 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string MessageProcessScriptName
	{
		[CompilerGenerated]
		get
		{
			return _003CMessageProcessScriptName_003Ek__BackingField;
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
					_003CMessageProcessScriptName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7b098b7bc47e4d38a5b2691cab1a4e36 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual EventTrigger[] SupportedTriggers
	{
		get
		{
			EventTrigger[] array = new EventTrigger[3];
			HVtkOjUkYWg5Fv5bcp6(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			return array;
		}
	}

	public MessageReceiveElement()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		LvQBqZUNfqfl2rfgtE5();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_515bc4036cf74f5eac12dac987ad5bea != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				MessageParamMapping = new List<MessageParamMap>();
				num = 2;
				break;
			case 2:
			{
				Condition condition = new Condition();
				gkfHdBUdXLBkPFvZVtg(condition, ConditionType.Script);
				MessageProcessCondition = condition;
				num = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_b813a6ed0be8497dbd700b40350f9732 == 0)
				{
					num = 0;
				}
				break;
			}
			case 1:
				return;
			}
		}
	}

	public override void ReplaceContextVar(Dictionary<Guid, Guid> replaceContextVar)
	{
		if (replaceContextVar.TryGetValue(ControlParamVarUid, out var value))
		{
			ControlParamVarUid = value;
		}
	}

	public override void ReplaceSignature(Dictionary<string, string> replaceNames)
	{
		MessageProcessScriptName = CopyReplace(MessageProcessScriptName, replaceNames);
		if (base.Condition != null)
		{
			base.Condition.ScriptName = CopyReplace(base.Condition.ScriptName, replaceNames);
		}
	}

	public override string HtmlBody(Element element, List<ProcessContext> contexts, int orgStructVersion, bool subFolders, WorkflowDiagram diagram, IWorkflowProcess wp = null, GenerationSettings gs = null)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x47356CA4 ^ 0x4735FFEA) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x78FAF0B5 ^ 0x78FA68D7)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DD795B3 ^ 0x5DD7076F) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x82E000E ^ 0x82E9834)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C21F94 ^ 0x1C289CA));
		stringBuilder.Append(base.HtmlBody(element, contexts, orgStructVersion, subFolders, diagram, (IWorkflowProcess)null, (GenerationSettings)null));
		return stringBuilder.ToString();
	}

	public override bool HasMessageType(Guid msgTypeUid)
	{
		return BJAweHUb5cmfxLboV6s(UIDMessage, msgTypeUid);
	}

	internal static void LvQBqZUNfqfl2rfgtE5()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}

	internal static void gkfHdBUdXLBkPFvZVtg(object P_0, ConditionType P_1)
	{
		((Condition)P_0).Type = P_1;
	}

	internal static bool EMMIBgUTbJ4OMh9Ainb()
	{
		return GrWwJEU9CR1yuThKZgP == null;
	}

	internal static MessageReceiveElement X6TWSHUcxZ1jrb4Dyp2()
	{
		return GrWwJEU9CR1yuThKZgP;
	}

	internal static object KOdcMXUjLTbM1O5oHTr(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object RpVKSmUSGZC2Va0xf74(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void HVtkOjUkYWg5Fv5bcp6(object P_0, RuntimeFieldHandle P_1)
	{
		RuntimeHelpers.InitializeArray((Array)P_0, P_1);
	}

	internal static bool BJAweHUb5cmfxLboV6s(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}
}
