using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Connectors;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Swimlanes;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;
using EleWise.ELMA.Workflow.Diagrams;
using EleWise.ELMA.Workflow.Diagrams.Elements.Gateways;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Gateways;

[Serializable]
public abstract class GatewayElement : BPMNFlowElement, IHintDrawElement
{
	[Component(Order = 100)]
	private class UserTaskHintExtension : HintDrawElementExtension<GatewayElement>
	{
		internal static object yeaLDBvdTDMlX4yA2IMd;

		public override Type[] TargetElementTypes => new Type[1] { HDwOxSvdCb4nqZ4QJfrx(typeof(UserTaskElement).TypeHandle) };

		public UserTaskHintExtension()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			TR0I9evdMZTKvRb3quxh();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static Type HDwOxSvdCb4nqZ4QJfrx(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static bool MiH3b1vdQkBsafElMNmB()
		{
			return yeaLDBvdTDMlX4yA2IMd == null;
		}

		internal static UserTaskHintExtension wbbfvwvdpnmt3FbuUS6y()
		{
			return (UserTaskHintExtension)yeaLDBvdTDMlX4yA2IMd;
		}

		internal static void TR0I9evdMZTKvRb3quxh()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	[Component(Order = 300)]
	private class IntermediateEventHintExtension : HintDrawElementExtension<GatewayElement>
	{
		private static object QeDVfSvdk8AmU7EAEjhC;

		public override Type[] TargetElementTypes => new Type[1] { wlN1AovdA7TEfwn4KTgh(typeof(IntermediateEventElement).TypeHandle) };

		public IntermediateEventHintExtension()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			UwjWx7vdGPiMPQ5lkuI8();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static Type wlN1AovdA7TEfwn4KTgh(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static bool JGgLZuvdU5gnDjLnHHXd()
		{
			return QeDVfSvdk8AmU7EAEjhC == null;
		}

		internal static IntermediateEventHintExtension kLJQmvvdVkr0Kf3Y7DnE()
		{
			return (IntermediateEventHintExtension)QeDVfSvdk8AmU7EAEjhC;
		}

		internal static void UwjWx7vdGPiMPQ5lkuI8()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	[Component(Order = 400)]
	private class EndEventHintExtension : HintDrawElementExtension<GatewayElement>
	{
		internal static object mUtFw7vd7vvfYLRC5iEU;

		public override Type[] TargetElementTypes => new Type[1] { typeof(EndEventElement) };

		public EndEventHintExtension()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			JfYE9WvdFvx48siVq3sZ();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool ty0Zlnvd2MIN5AQwLYov()
		{
			return mUtFw7vd7vvfYLRC5iEU == null;
		}

		internal static EndEventHintExtension hEOC4jvdoJJqbVCM9y06()
		{
			return (EndEventHintExtension)mUtFw7vd7vvfYLRC5iEU;
		}

		internal static void JfYE9WvdFvx48siVq3sZ()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	private static GatewayElement RjS7VyZlbjYc2dHb4fyb;

	public override string DefaultName => (string)XE8PTeZlPyIxfWCbUG5T(ri4Hu2ZlccY9ZeGFe5m6(-1895853023 ^ -1896018501));

	public GatewayStartType GatewayStartType
	{
		[CompilerGenerated]
		get
		{
			return _003CGatewayStartType_003Ek__BackingField;
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
					_003CGatewayStartType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Guid PairGatewayUid
	{
		[CompilerGenerated]
		get
		{
			return _003CPairGatewayUid_003Ek__BackingField;
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
					_003CPairGatewayUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool UseGatewayVar
	{
		[CompilerGenerated]
		get
		{
			return _003CUseGatewayVar_003Ek__BackingField;
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
					_003CUseGatewayVar_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Guid GatewayVarTypeUid
	{
		[CompilerGenerated]
		get
		{
			return _003CGatewayVarTypeUid_003Ek__BackingField;
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
					_003CGatewayVarTypeUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
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

	public Guid GatewayVarSubTypeUid
	{
		[CompilerGenerated]
		get
		{
			return _003CGatewayVarSubTypeUid_003Ek__BackingField;
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
					_003CGatewayVarSubTypeUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 != 0)
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

	public string GatewayScriptName
	{
		[CompilerGenerated]
		get
		{
			return _003CGatewayScriptName_003Ek__BackingField;
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
					_003CGatewayScriptName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public List<Guid> FlowsOrder { get; set; }

	protected override int MaxOutputFlowsCount => int.MaxValue;

	public override string ChapterName => SR.T((string)ri4Hu2ZlccY9ZeGFe5m6(-25709590 ^ -25876186));

	public GatewayElement()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		ockDAdZlBOSlPT3YDmcK();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				FlowsOrder = new List<Guid>();
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f8a84e2cb374827a50ba2cbcf11cf48 != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public virtual Type[] GetAvaiableOutputElementTypes()
	{
		return HintDrawElementHelper.GetAvaiableOutputElementTypes<IntermediateEventElement>();
	}

	public override string HtmlHeader(ProcessContext context, int orgStructVersion, bool subFolders, WorkflowDiagram diagram, GenerationSettings gs = null)
	{
		int num = 5;
		int num2 = num;
		StringBuilder stringBuilder = default(StringBuilder);
		while (true)
		{
			switch (num2)
			{
			case 3:
				stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-25709590 ^ -25835308));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 == 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				return stringBuilder.ToString();
			case 5:
				stringBuilder = new StringBuilder();
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 == 0)
				{
					num2 = 4;
				}
				break;
			case 2:
				Cf3C9KZlLhLbI08v6ddk(stringBuilder, ri4Hu2ZlccY9ZeGFe5m6(-29981480 ^ -30082876));
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd != 0)
				{
					num2 = 6;
				}
				break;
			case 1:
				Cf3C9KZlLhLbI08v6ddk(stringBuilder, ri4Hu2ZlccY9ZeGFe5m6(-11799394 ^ -11905086));
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				Cf3C9KZlLhLbI08v6ddk(stringBuilder, fkd69CZlH3wvr9YMrG35(new object[5]
				{
					ri4Hu2ZlccY9ZeGFe5m6(0x6CC04061 ^ 0x6CC23B79),
					tOW6DVZluQQHOJ87lCfp(u7feUhZldGW9siTAQQea(YaQ1X9ZlXu6GVSDTIkpF(this)), "") ? eGttI0ZlDGJBhSkKQWBK(this) : YaQ1X9ZlXu6GVSDTIkpF(this),
					ri4Hu2ZlccY9ZeGFe5m6(-1895853023 ^ -1895977331),
					J9ZGr3ZlnUdWVOaHtyQA(this),
					ri4Hu2ZlccY9ZeGFe5m6(-14356676 ^ -14248936)
				}));
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a == 0)
				{
					num2 = 1;
				}
				break;
			default:
				stringBuilder.Append((string)vfHd9JZlRyGwExcYm4JB(YC7XUdZl932Fa7aouOiS(ri4Hu2ZlccY9ZeGFe5m6(0x651FE29D ^ 0x651D9901), vodIqUZlfWqbTSZv5hWL(J9ZGr3ZlnUdWVOaHtyQA(this).ToString()), ri4Hu2ZlccY9ZeGFe5m6(0x37E97159 ^ 0x37EB0AA9)), subFolders ? "" : cNH8uWZljUtVsg4So2k9(hktbVcZlWZ77KLC6j7Zi(context).ToString(), ri4Hu2ZlccY9ZeGFe5m6(0x4943E3E4 ^ 0x4941D3E6), "")));
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public override string HtmlBody(Element element, List<ProcessContext> contexts, int orgStructVersion, bool subFolders, WorkflowDiagram diagram, IWorkflowProcess wp = null, GenerationSettings gs = null)
	{
		StringBuilder stringBuilder = new StringBuilder();
		SwimlaneElement swimlane = GetSwimlane(diagram);
		if (swimlane != null && !string.IsNullOrEmpty(swimlane.Name))
		{
			string arg = HTMLUtility.InsertHyperLink(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638225214 ^ -1638361810), swimlane.Uid.ToString().Replace(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1212129906 ^ 0x483D9270), "")), swimlane.Name);
			stringBuilder.Append(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29981480 ^ -30145258), SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2122743969 ^ -2122580313)), arg));
		}
		if (!string.IsNullOrEmpty(element.Description))
		{
			stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x350C0E8 ^ 0x352F20A) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29981480 ^ -30098208)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x13F63440 ^ 0x13F4482A) + element.Description);
		}
		if (!string.IsNullOrEmpty(element.Description))
		{
			stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-25709590 ^ -25835006) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398691253 ^ -398570381)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1647793954 ^ -1647651660) + element.Description);
		}
		if (UseGatewayVar && GetType() != typeof(ParallelGatewayElement))
		{
			stringBuilder.Append(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1712492721 ^ -1712385137), SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-667465279 ^ -667561881))));
			string arg2 = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-43932417 ^ -43806105), SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6F6D7B44 ^ 0x6F6C85BC)));
			try
			{
				ITypeDescriptor typeDescriptor = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeDescriptor(GatewayVarTypeUid, GatewayVarSubTypeUid);
				if (typeDescriptor != null && !string.IsNullOrEmpty(typeDescriptor.Name))
				{
					arg2 = typeDescriptor.Name;
				}
			}
			catch (Exception)
			{
			}
			string arg3 = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1716458555 ^ -1716413469) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x51EF0063 ^ 0x51ED99B1)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2057730233 ^ -2057703281);
			if (!string.IsNullOrEmpty(GatewayScriptName))
			{
				arg3 = HTMLUtility.InsertHyperLink(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1927DA93 ^ 0x1925E57F), GatewayScriptName), GatewayScriptName);
			}
			stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x51EF0063 ^ 0x51ED917B));
			stringBuilder.Append(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1001967776 ^ -1002064248), SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1001967776 ^ -1002064572)), arg2));
			stringBuilder.Append(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-980570076 ^ -980473396), SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x42311138 ^ 0x42338B60)), arg3));
			stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1EA50FCC ^ 0x1EA79DBC));
		}
		stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x438A0E43 ^ 0x43883D61) + GetConnectorsLink());
		if (base.StandardOutputFlows != null && base.StandardOutputFlows.Any((FlowConnectorElement p) => p.Condition != null))
		{
			stringBuilder.Append(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1843E01F ^ 0x18417A73), SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1050383744 ^ -1050218456))));
			stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2122743969 ^ -2122584505));
			foreach (FlowConnectorElement standardOutputFlow in base.StandardOutputFlows)
			{
				FlowConnectorConnectorsTable(standardOutputFlow, contexts, stringBuilder);
			}
			stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-63028171 ^ -63121851));
		}
		return stringBuilder.ToString();
	}

	public override string HtmlFooter()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append((string)ri4Hu2ZlccY9ZeGFe5m6(-642713667 ^ -642594055));
		return stringBuilder.ToString();
	}

	private void FlowConnectorConnectorsTable(FlowConnectorElement flow, List<ProcessContext> contexts, StringBuilder descString)
	{
		if (flow.Condition == null)
		{
			return;
		}
		switch (flow.Condition.Type)
		{
		case ConditionType.Table:
			descString.Append(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1647793954 ^ -1647693308), (flow.Name.Trim() != "") ? flow.Name : flow.DefaultName, flow.IsDefault ? (SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1AF6F1F2 ^ 0x1AF49118) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1361036319 ^ -1360879373)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1EA50FCC ^ 0x1EA558BE)) : "", SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2ACCDD87 ^ 0x2ACE46AB))));
			descString.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2125897096 ^ -2125728928));
			descString.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2077784392 ^ -2077942394) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x614CF569 ^ 0x614E6E39)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-495296780 ^ -495401570) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1386448964 ^ -1386288066)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4FD00585 ^ 0x4FD23691));
			descString.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-949717965 ^ -949557693));
			descString.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1756698829 ^ 0x68B72EA5));
			descString.Append(HTMLUtility.InsertRowToTable(new string[4]
			{
				SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-980570076 ^ -980472900)),
				SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1927DA93 ^ 0x1925413B)),
				SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-790221436 ^ -790317510)),
				SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-684210684 ^ -684368426))
			}, isBold: true, null));
			foreach (ConditionTable.Item item in flow.Condition.Table.Items)
			{
				string text2 = OperandValue(item.Operand1, contexts);
				string text3 = OperandValue(item.Operand2, contexts);
				descString.Append(HTMLUtility.InsertRowToTable(new string[4]
				{
					item.Relation.GetDisplayName(),
					text2,
					item.Operation.GetDisplayName(),
					text3
				}, isBold: false, new string[5]
				{
					SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105863102 ^ -105734512),
					"",
					SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C7F6FED ^ 0x1C7D593F),
					"",
					SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x157D5AF4 ^ 0x157F6C26)
				}));
			}
			descString.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-801808857 ^ -801651249));
			break;
		case ConditionType.Script:
		{
			string text = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x350C0E8 ^ 0x351B0CE) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-862330810 ^ -862226028)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1965291699 ^ -1965264763);
			if (!string.IsNullOrEmpty(flow.Condition.ScriptName))
			{
				text = HTMLUtility.InsertHyperLink(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xDF4D1F8 ^ 0xDF6EE14), flow.Condition.ScriptName), flow.Condition.ScriptName);
			}
			descString.Append(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x74AB4717 ^ 0x74A9DDCD), (flow.Name.Trim() != "") ? flow.Name : flow.DefaultName, flow.IsDefault ? (SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1AF6F1F2 ^ 0x1AF49118) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7AC609FE ^ 0x7AC492EC)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1542190822 ^ -1542168984)) : "", SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-45832783 ^ -45728099))));
			descString.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x213F6477 ^ 0x213DF56F));
			descString.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1600060848 ^ -1599891090) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-862330810 ^ -862225642)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6C7F14 ^ 0x6EE47E) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-539998957 ^ -539828405)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-539998957 ^ -539855353));
			descString.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1574607501 ^ -1574437299) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1756698829 ^ 0x68B78295)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x37E97159 ^ 0x37EBEA33) + text + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2111219045 ^ -2111084145));
			descString.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-801808857 ^ -801649577));
			break;
		}
		}
	}

	private string OperandValue(ConditionTable.Operand operand, List<ProcessContext> contexts)
	{
		_003C_003Ec__DisplayClass43_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass43_0();
		CS_0024_003C_003E8__locals0.operand = operand;
		switch (CS_0024_003C_003E8__locals0.operand.Type)
		{
		case ConditionTable.OperandType.Property:
			foreach (ProcessContext context in contexts)
			{
				EntityPropertyMetadata entityPropertyMetadata = ((IEnumerable<EntityPropertyMetadata>)context.EntityProperties).FirstOrDefault((EntityPropertyMetadata p) => _003C_003Ec__DisplayClass43_0.NnhkhSvdh58VETh4Wcsb(p.Uid, _003C_003Ec__DisplayClass43_0.gHIHMQvd1Y7ibCPUXLrs(CS_0024_003C_003E8__locals0.operand)));
				if (entityPropertyMetadata != null)
				{
					return string.IsNullOrWhiteSpace(entityPropertyMetadata.DisplayName) ? entityPropertyMetadata.Name : HTMLUtility.InsertHyperLink(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x738ABA6E ^ 0x73888582), entityPropertyMetadata.Uid.ToString().Replace(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xA7339EE ^ 0xA7109EC), "")), entityPropertyMetadata.DisplayName);
				}
			}
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420003255 ^ -420072849) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1712492721 ^ -1712327863)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x46EA3D1 ^ 0x46ED419);
		case ConditionTable.OperandType.Value:
			return CS_0024_003C_003E8__locals0.operand.Value.ToString();
		case ConditionTable.OperandType.GatewayVar:
			return SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7AC609FE ^ 0x7AC72D20));
		case ConditionTable.OperandType.CustomType:
			return SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-684210684 ^ -684268838));
		default:
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4FD00585 ^ 0x4FD175A3) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C663DA1 ^ 0x1C64A1A7)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-452127399 ^ -452107631);
		}
	}

	internal static void ockDAdZlBOSlPT3YDmcK()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool F66HLSZl51S9ckGpWYSQ()
	{
		return RjS7VyZlbjYc2dHb4fyb == null;
	}

	internal static GatewayElement mr92E4ZlgHuDFDAiTOuv()
	{
		return RjS7VyZlbjYc2dHb4fyb;
	}

	internal static object ri4Hu2ZlccY9ZeGFe5m6(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object XE8PTeZlPyIxfWCbUG5T(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object YaQ1X9ZlXu6GVSDTIkpF(object P_0)
	{
		return ((Element)P_0).Name;
	}

	internal static object u7feUhZldGW9siTAQQea(object P_0)
	{
		return ((string)P_0).Trim();
	}

	internal static bool tOW6DVZluQQHOJ87lCfp(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object eGttI0ZlDGJBhSkKQWBK(object P_0)
	{
		return ((Element)P_0).DefaultName;
	}

	internal static Guid J9ZGr3ZlnUdWVOaHtyQA(object P_0)
	{
		return ((Element)P_0).Uid;
	}

	internal static object fkd69CZlH3wvr9YMrG35(object P_0)
	{
		return string.Concat((object[])P_0);
	}

	internal static object Cf3C9KZlLhLbI08v6ddk(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).Append((string)P_1);
	}

	internal static object vodIqUZlfWqbTSZv5hWL(object P_0)
	{
		return HTMLUtility.MakeValidFileName((string)P_0);
	}

	internal static object YC7XUdZl932Fa7aouOiS(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static Guid hktbVcZlWZ77KLC6j7Zi(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object cNH8uWZljUtVsg4So2k9(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static object vfHd9JZlRyGwExcYm4JB(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}
}
