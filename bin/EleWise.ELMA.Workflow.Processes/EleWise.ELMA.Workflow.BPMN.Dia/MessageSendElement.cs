using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Diagrams.Toolbox;
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
[WebDiagrammerShape(typeof(WebDiagrammerMessageSendShape))]
[HintShape(typeof(MessageSendHintShape))]
[Shape(typeof(MessageSendShape))]
[TaskType(50, "MessageSend")]
public class MessageSendElement : MessageElement, IExceptionFlowSupported, IReplaceContextVar
{
	[Component(Order = 500)]
	public class ToolboxItem : IBPMNToolboxItem, IToolboxItem, IContainingElementIcon
	{
		private static ToolboxItem F7NBanHT7SNnm80OByi;

		public string Name => SR.T((string)KUphr1HdjpjowG7Mkd1(0x5A5DBA54 ^ 0x5A5D222A));

		public Guid GroupUid => BPMNGroups.Operations.UID;

		public Image Image => (Image)zegrhhHjkOI2O3Ad9pY();

		public Type ElementType => pSN5CKHSh4wqdn3tAnw(typeof(MessageSendElement).TypeHandle);

		public string ElementIcon => (string)KUphr1HdjpjowG7Mkd1(-1587393812 ^ -1587378294);

		public ToolboxItem()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7b098b7bc47e4d38a5b2691cab1a4e36 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object KUphr1HdjpjowG7Mkd1(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static bool juLfXZHcH8flS7H57nC()
		{
			return F7NBanHT7SNnm80OByi == null;
		}

		internal static ToolboxItem gyViZFHNkIFCGKrGbPB()
		{
			return F7NBanHT7SNnm80OByi;
		}

		internal static object zegrhhHjkOI2O3Ad9pY()
		{
			return Resources.symb_task_send;
		}

		internal static Type pSN5CKHSh4wqdn3tAnw(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}
	}

	internal static MessageSendElement G9dAPDUUnituis6oYEI;

	public override string DefaultName => SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1979431200 ^ -1979392354));

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
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e6a95a03603e49dfb9bfc60af0009767 == 0)
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

	public Guid UIDVariableInstance
	{
		[CompilerGenerated]
		get
		{
			return _003CUIDVariableInstance_003Ek__BackingField;
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
					_003CUIDVariableInstance_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_c41b9b25e0a04be1b1ded81427c555dd != 0)
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

	public virtual EventTrigger[] SupportedTriggers => new EventTrigger[2]
	{
		EventTrigger.Timer,
		EventTrigger.Script
	};

	public MessageSendElement()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		fJtuWQUpVtr7DkomtiI();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3cf4c0e592254156b9e651c03075f59e != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				MessageParamMapping = new List<MessageParamMap>();
				num = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_71034f51e0444c3592d323fffec09e96 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override void ReplaceContextVar(Dictionary<Guid, Guid> ReplaceContextVar)
	{
		Guid value = Guid.Empty;
		if (ReplaceContextVar.TryGetValue(UIDVariableInstance, out value))
		{
			UIDVariableInstance = value;
		}
	}

	public override string HtmlBody(Element element, List<ProcessContext> contexts, int orgStructVersion, bool subFolders, WorkflowDiagram diagram, IWorkflowProcess wp = null, GenerationSettings gs = null)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x33BD2188 ^ 0x33BDB2C6) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-79921577 ^ -79894987)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1535001335 ^ -1535037483) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x138E9AEB ^ 0x138E0295)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-5433396 ^ -5406318));
		stringBuilder.Append(base.HtmlBody(element, contexts, orgStructVersion, subFolders, diagram, (IWorkflowProcess)null, (GenerationSettings)null));
		return stringBuilder.ToString();
	}

	public override bool HasMessageType(Guid msgTypeUid)
	{
		return UIDMessage == msgTypeUid;
	}

	internal static void fJtuWQUpVtr7DkomtiI()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}

	internal static bool jnpOa4UmTUmhZx0tXvI()
	{
		return G9dAPDUUnituis6oYEI == null;
	}

	internal static MessageSendElement b3I7eaUAsMyUrUnFErg()
	{
		return G9dAPDUUnituis6oYEI;
	}
}
