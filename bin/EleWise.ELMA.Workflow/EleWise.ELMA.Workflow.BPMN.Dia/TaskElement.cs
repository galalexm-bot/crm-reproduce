using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Gateways;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Swimlanes;
using EleWise.ELMA.Workflow.Diagrams;
using EleWise.ELMA.Workflow.Diagrams.Elements;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Models.Regulation;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;

[Serializable]
public abstract class TaskElement : BPMNFlowElement, IHintDrawElement, IReplaceContextVar
{
	[Component(Order = 100)]
	private class UserTaskHintExtension : HintDrawElementExtension<TaskElement>
	{
		private static object kUCpiCvnDtnYKlnSvaBq;

		public override Type[] TargetElementTypes => new Type[1] { jZDyidvnLcKnOAj0ksNU(typeof(UserTaskElement).TypeHandle) };

		public UserTaskHintExtension()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			xffvaqvnfUN3OU0Gi3Tw();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static Type jZDyidvnLcKnOAj0ksNU(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static bool lLbgWOvnnKjMQiI7iWdc()
		{
			return kUCpiCvnDtnYKlnSvaBq == null;
		}

		internal static UserTaskHintExtension nEqCS9vnHO0HFqnoIAsU()
		{
			return (UserTaskHintExtension)kUCpiCvnDtnYKlnSvaBq;
		}

		internal static void xffvaqvnfUN3OU0Gi3Tw()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	[Component(Order = 300)]
	private class ExclusiveGatewayHintExtension : HintDrawElementExtension<TaskElement>
	{
		internal static object EHsbCtvn9hHOeXrgmaxy;

		public override Type[] TargetElementTypes => new Type[1] { S9RrhEvnRWT6YrgfX25U(typeof(ExclusiveGatewayElement).TypeHandle) };

		public ExclusiveGatewayHintExtension()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			TAmUiYvn6wS05hw6vnnE();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static Type S9RrhEvnRWT6YrgfX25U(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static bool sOAnVIvnWC70oMdcQGuj()
		{
			return EHsbCtvn9hHOeXrgmaxy == null;
		}

		internal static ExclusiveGatewayHintExtension xNWYVavnjbBKcTJNKO6x()
		{
			return (ExclusiveGatewayHintExtension)EHsbCtvn9hHOeXrgmaxy;
		}

		internal static void TAmUiYvn6wS05hw6vnnE()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	[Component(Order = 400)]
	private class IntermediateEventHintExtension : HintDrawElementExtension<TaskElement>
	{
		internal static object rM1FsovnqR91lJqBjpJ5;

		public override Type[] TargetElementTypes => new Type[1] { EmsClGvnQ3Eqd5suJVoH(typeof(IntermediateEventElement).TypeHandle) };

		public IntermediateEventHintExtension()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static Type EmsClGvnQ3Eqd5suJVoH(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static bool BE1d4hvn3ZlYgVnNIp0m()
		{
			return rM1FsovnqR91lJqBjpJ5 == null;
		}

		internal static IntermediateEventHintExtension SEkVJhvnT4LPkPo7xR8a()
		{
			return (IntermediateEventHintExtension)rM1FsovnqR91lJqBjpJ5;
		}
	}

	[Component(Order = 500)]
	private class EndEventHintExtension : HintDrawElementExtension<TaskElement>
	{
		private static object VLOu8evnpPn1yvDsflYH;

		public override Type[] TargetElementTypes => new Type[1] { eJLsKqvnkIwKG57jEvgN(typeof(EndEventElement).TypeHandle) };

		public EndEventHintExtension()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			jvYBFHvnUmEQZbFpAAov();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static Type eJLsKqvnkIwKG57jEvgN(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static bool rmjbjLvnCOydyeG93n7L()
		{
			return VLOu8evnpPn1yvDsflYH == null;
		}

		internal static EndEventHintExtension z0WvHlvnMDNCWKlnQeL0()
		{
			return (EndEventHintExtension)VLOu8evnpPn1yvDsflYH;
		}

		internal static void jvYBFHvnUmEQZbFpAAov()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	[Component(Order = 600)]
	private class AnnotationElementExtension : HintDrawElementExtension<TaskElement>
	{
		private static object fV4sqHvnVktXxu5ktBRp;

		public override Type[] TargetElementTypes => new Type[1] { g6NVmXvn7bqp642jRfBw(typeof(AnnotationElement).TypeHandle) };

		public AnnotationElementExtension()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static Type g6NVmXvn7bqp642jRfBw(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static bool z4dWawvnApDs7OyYJnVN()
		{
			return fV4sqHvnVktXxu5ktBRp == null;
		}

		internal static AnnotationElementExtension COLDqvvnGMOyRgtcrxCb()
		{
			return (AnnotationElementExtension)fV4sqHvnVktXxu5ktBRp;
		}
	}

	private TaskMarker marker;

	internal static TaskElement AjIk1MZb30YmZiugNnjT;

	public override string DefaultName => SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7381F16B ^ 0x7383EDF5));

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
				case 1:
					marker = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return;
				default:
					JPeeNQZbpvJOJSmbJyWB(this);
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 != 0)
					{
						num2 = 2;
					}
					break;
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
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e == 0)
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
				case 1:
					_003CCondition_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b != 0)
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

	public RegulationForTaskElement Regulation
	{
		[CompilerGenerated]
		get
		{
			return _003CRegulation_003Ek__BackingField;
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
					_003CRegulation_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public override string ChapterName => (string)QCNdFSZbij91FM24hH4n(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-261315199 ^ -261210681));

	public virtual Type[] GetAvaiableOutputElementTypes()
	{
		return HintDrawElementHelper.GetAvaiableOutputElementTypes<TaskElement>();
	}

	public override void ReplaceContextVar(Dictionary<Guid, Guid> ReplaceContextVar)
	{
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

	public override string HtmlHeader(ProcessContext context, int orgStructVersion, bool subFolders, WorkflowDiagram diagram, GenerationSettings gs = null)
	{
		int num = 3;
		StringBuilder stringBuilder = default(StringBuilder);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					U2jtLZZbVK96TygO0nIM(stringBuilder, r9yQa6ZbC9sMZHdrSSNB(0x3C1FFB55 ^ 0x3C1D8749));
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 == 0)
					{
						num2 = 1;
					}
					continue;
				default:
					U2jtLZZbVK96TygO0nIM(stringBuilder, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x614CF569 ^ 0x614E8E57));
					num = 6;
					break;
				case 1:
					U2jtLZZbVK96TygO0nIM(stringBuilder, r9yQa6ZbC9sMZHdrSSNB(-2077784392 ^ -2077874716));
					num2 = 5;
					continue;
				case 4:
					return stringBuilder.ToString();
				case 3:
					stringBuilder = new StringBuilder();
					num = 2;
					break;
				case 2:
					U2jtLZZbVK96TygO0nIM(stringBuilder, string.Concat(r9yQa6ZbC9sMZHdrSSNB(0x595C500A ^ 0x595E2B12), ((string)KyRQJ4ZbkoBw1Zn9wfag(bW3IuUZbMcOIovJjrqda(this)) == "") ? DefaultName : bW3IuUZbMcOIovJjrqda(this), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1657582555 ^ -1657702775), SobmT6ZbUvE7JU42axf7(this), r9yQa6ZbC9sMZHdrSSNB(0x4FD00585 ^ 0x4FD27EA1)));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d != 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					U2jtLZZbVK96TygO0nIM(stringBuilder, FjAVj2Zb2Wkh18wPGX8j(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-772614310 ^ -772756282) + (string)DNeUQhZbAUtZ5MJgQBuR(base.Uid.ToString()) + (string)r9yQa6ZbC9sMZHdrSSNB(0x738ABA6E ^ 0x7388C19E), subFolders ? "" : Hx1b0nZb7cn0XddBVSUc(a1QjomZbGM537rkvxO8d(context).ToString(), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6871CA ^ 0x6A41C8), "")));
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f == 0)
					{
						num2 = 1;
					}
					continue;
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
			string arg = HTMLUtility.InsertHyperLink(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x75BAD659 ^ 0x75B8E9B5), swimlane.Uid.ToString().Replace(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xB7793C9 ^ 0xB75A3CB), "")), swimlane.Name);
			stringBuilder.Append(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x37F755F5 ^ 0x37F5D43B), SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1436248540 ^ 0x5599E824)), arg));
		}
		if (!string.IsNullOrEmpty(element.Description))
		{
			stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x46EA3D1 ^ 0x46CDA39) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-360662087 ^ -360545407)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-22348816 ^ -22509670) + element.Description + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x213F6477 ^ 0x213D5755));
		}
		return stringBuilder.ToString();
	}

	public override string HtmlFooter()
	{
		StringBuilder stringBuilder = new StringBuilder();
		U2jtLZZbVK96TygO0nIM(stringBuilder, SvcrWZZbF1uP67ZfZ6B9(r9yQa6ZbC9sMZHdrSSNB(0x614CF569 ^ 0x614E8805), Y3axZZZboZvTIlSeytU9(this)));
		U2jtLZZbVK96TygO0nIM(stringBuilder, r9yQa6ZbC9sMZHdrSSNB(0x1927DA93 ^ 0x1925A713));
		return stringBuilder.ToString();
	}

	protected Tuple<string, string> GetOnlyFunctionName(string functionFullName)
	{
		if (!functionFullName.Contains(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-11799394 ^ -11955084)))
		{
			return Tuple.Create(functionFullName, functionFullName);
		}
		int length = functionFullName.IndexOf('(');
		string text = functionFullName.Substring(0, length);
		int startIndex = functionFullName.LastIndexOf(text + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420003255 ^ -420142429));
		string text2 = functionFullName.Substring(startIndex);
		string item = text2.Substring(0, text2.IndexOf('(')).Trim();
		return Tuple.Create(text2, item);
	}

	protected TaskElement()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		bsbOs8ZbIGkhAYdn1saK();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool wZIk7TZbTsVJD4JtuPT9()
	{
		return AjIk1MZb30YmZiugNnjT == null;
	}

	internal static TaskElement n0BJ6YZbQN7cgjKi9AmO()
	{
		return AjIk1MZb30YmZiugNnjT;
	}

	internal static void JPeeNQZbpvJOJSmbJyWB(object P_0)
	{
		((BPMNFlowElement)P_0).UpdateDecorators();
	}

	internal static object r9yQa6ZbC9sMZHdrSSNB(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object bW3IuUZbMcOIovJjrqda(object P_0)
	{
		return ((Element)P_0).Name;
	}

	internal static object KyRQJ4ZbkoBw1Zn9wfag(object P_0)
	{
		return ((string)P_0).Trim();
	}

	internal static Guid SobmT6ZbUvE7JU42axf7(object P_0)
	{
		return ((Element)P_0).Uid;
	}

	internal static object U2jtLZZbVK96TygO0nIM(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).Append((string)P_1);
	}

	internal static object DNeUQhZbAUtZ5MJgQBuR(object P_0)
	{
		return HTMLUtility.MakeValidFileName((string)P_0);
	}

	internal static Guid a1QjomZbGM537rkvxO8d(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object Hx1b0nZb7cn0XddBVSUc(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static object FjAVj2Zb2Wkh18wPGX8j(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object Y3axZZZboZvTIlSeytU9(object P_0)
	{
		return ((BPMNFlowElement)P_0).GetConnectorsLink();
	}

	internal static object SvcrWZZbF1uP67ZfZ6B9(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object QCNdFSZbij91FM24hH4n(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void bsbOs8ZbIGkhAYdn1saK()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
