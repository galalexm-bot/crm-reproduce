using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Diagrams.Toolbox;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Gateways;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Swimlanes;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Plugins;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Toolbox;
using EleWise.ELMA.Workflow.Diagrams;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Properties;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Plugins;

[Serializable]
[Shape(typeof(WorkflowInstanceStatusShape))]
[HintShape(typeof(WorkflowInstanceStatusHintShape))]
[WebDiagrammerShape(typeof(WebDiagrammerWorkflowInstanceStatusShape))]
public class WorkflowInstanceStatusElement : BPMNFlowElement, IHintDrawElement
{
	[Component(Order = 90)]
	public class ToolboxItem : IBPMNToolboxItem, IToolboxItem, IContainingElementIcon
	{
		private static ToolboxItem GMjw3jvXhZf8nr8eo7Zk;

		public string Name => (string)bl3qh6vXzTogyo0oiqsU(lMRjgKvX4ji0QZqy0gBX(0x361628FF ^ 0x3614F5C9));

		public Guid GroupUid => WorkflowInstanceStatusGroup.UID;

		public Image Image => (Image)BgSxDvvdKHwJRHhSZaJZ();

		public Type ElementType => UsF2lmvdOstUmX42QPdD(typeof(WorkflowInstanceStatusElement).TypeHandle);

		public string ElementIcon => SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x438A0E43 ^ 0x4388D33F);

		public ToolboxItem()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object lMRjgKvX4ji0QZqy0gBX(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object bl3qh6vXzTogyo0oiqsU(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool nfTQEMvXESgaXoSSxsik()
		{
			return GMjw3jvXhZf8nr8eo7Zk == null;
		}

		internal static ToolboxItem K5ppj5vXwOXQDH99U7Kt()
		{
			return GMjw3jvXhZf8nr8eo7Zk;
		}

		internal static object BgSxDvvdKHwJRHhSZaJZ()
		{
			return Resources.changeInstanceStatus;
		}

		internal static Type UsF2lmvdOstUmX42QPdD(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}
	}

	[Component(Order = 100)]
	private class UserTaskHintExtension : HintDrawElementExtension<WorkflowInstanceStatusElement>
	{
		internal static object Y5RndcvdZlSDES5LWQjV;

		public override Type[] TargetElementTypes => new Type[1] { t2Nu04vd8lpQKrccA5eD(typeof(UserTaskElement).TypeHandle) };

		public UserTaskHintExtension()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			kDggQqvdsAYEffj8ERvc();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static Type t2Nu04vd8lpQKrccA5eD(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static bool i3TwwIvdvfCpeA2GmkBH()
		{
			return Y5RndcvdZlSDES5LWQjV == null;
		}

		internal static UserTaskHintExtension mOS8EhvdYOMRiOTVmEPX()
		{
			return (UserTaskHintExtension)Y5RndcvdZlSDES5LWQjV;
		}

		internal static void kDggQqvdsAYEffj8ERvc()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	[Component(Order = 300)]
	private class ExclusiveGatewayHintExtension : HintDrawElementExtension<WorkflowInstanceStatusElement>
	{
		private static object bd64JhvdJf6rTnBZbpbB;

		public override Type[] TargetElementTypes => new Type[1] { typeof(ExclusiveGatewayElement) };

		public ExclusiveGatewayHintExtension()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			JlaTGyvdy0UDC9eniCCs();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool AgQFJkvdlNnfpPhJmNoD()
		{
			return bd64JhvdJf6rTnBZbpbB == null;
		}

		internal static ExclusiveGatewayHintExtension GtWny7vd0yA0kpKvvmOh()
		{
			return (ExclusiveGatewayHintExtension)bd64JhvdJf6rTnBZbpbB;
		}

		internal static void JlaTGyvdy0UDC9eniCCs()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	[Component(Order = 400)]
	private class IntermediateEventHintExtension : HintDrawElementExtension<WorkflowInstanceStatusElement>
	{
		internal static object ljWTbEvdm6BeLKlES3lk;

		public override Type[] TargetElementTypes => new Type[1] { bLDOvwvd5Pp2ytd7e87e(typeof(IntermediateEventElement).TypeHandle) };

		public IntermediateEventHintExtension()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static Type bLDOvwvd5Pp2ytd7e87e(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static bool BQWrlPvdt6U2bhHB5DxG()
		{
			return ljWTbEvdm6BeLKlES3lk == null;
		}

		internal static IntermediateEventHintExtension OAgHLFvdbpP66ZIkVFli()
		{
			return (IntermediateEventHintExtension)ljWTbEvdm6BeLKlES3lk;
		}
	}

	[Component(Order = 500)]
	private class EndEventHintExtension : HintDrawElementExtension<WorkflowInstanceStatusElement>
	{
		private static object lVOC0lvdgJOW4RJMOfqq;

		public override Type[] TargetElementTypes => new Type[1] { typeof(EndEventElement) };

		public EndEventHintExtension()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			JJTi0tvdPM3d6G0eVWoH();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool Rw2xsbvdBhHPrbGsxr4H()
		{
			return lVOC0lvdgJOW4RJMOfqq == null;
		}

		internal static EndEventHintExtension RnP6YIvdcqZK90W6UOrF()
		{
			return (EndEventHintExtension)lVOC0lvdgJOW4RJMOfqq;
		}

		internal static void JJTi0tvdPM3d6G0eVWoH()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	[Component(Order = 600)]
	private class AnnotationElementExtension : HintDrawElementExtension<WorkflowInstanceStatusElement>
	{
		private static object Xt7g66vdXlQqdIiE7IkC;

		public override Type[] TargetElementTypes => new Type[1] { C0HTKGvdD4oXxHsAuSyf(typeof(AnnotationElement).TypeHandle) };

		public AnnotationElementExtension()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			n4Xli5vdniJXul1cEI3o();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static Type C0HTKGvdD4oXxHsAuSyf(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static bool yvFXk6vddcjRmxRl3QSv()
		{
			return Xt7g66vdXlQqdIiE7IkC == null;
		}

		internal static AnnotationElementExtension ckgThbvdu6cIaPDBbmKI()
		{
			return (AnnotationElementExtension)Xt7g66vdXlQqdIiE7IkC;
		}

		internal static void n4Xli5vdniJXul1cEI3o()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	private static WorkflowInstanceStatusElement t4w9jZZJrej9PNXehQfo;

	public override string DefaultName => (string)y1bDtFZJS1cDeuLFHiUu(vNmDVkZJxJdU9v9F943g(0x69063C81 ^ 0x6904AB6F));

	public DropDownItem Status
	{
		[CompilerGenerated]
		get
		{
			return _003CStatus_003Ek__BackingField;
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
					_003CStatus_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 == 0)
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

	public override string ChapterName => SR.T((string)vNmDVkZJxJdU9v9F943g(0x614274E3 ^ 0x6140ECA5));

	public virtual Type[] GetAvaiableOutputElementTypes()
	{
		return HintDrawElementHelper.GetAvaiableOutputElementTypes<WorkflowInstanceStatusElement>();
	}

	public override string HtmlHeader(ProcessContext context, int orgStructVersion, bool subFolders, WorkflowDiagram diagram, GenerationSettings gs = null)
	{
		int num = 3;
		int num2 = num;
		StringBuilder stringBuilder = default(StringBuilder);
		while (true)
		{
			switch (num2)
			{
			case 3:
				stringBuilder = new StringBuilder();
				num2 = 2;
				break;
			case 5:
				stringBuilder.Append((string)vNmDVkZJxJdU9v9F943g(0x1C663DA1 ^ 0x1C679EFD));
				num2 = 6;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return stringBuilder.ToString();
			case 1:
				stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2002063381 ^ -2002217771));
				num2 = 4;
				break;
			case 6:
				stringBuilder.Append((string)vNmDVkZJxJdU9v9F943g(-683713632 ^ -683857988));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				de5LT0ZJzFI2mg1jd5WI(stringBuilder, string.Concat(vNmDVkZJxJdU9v9F943g(-708128192 ^ -708253460), RBoQalZJ1t0Q6QMkHbUZ(this), vNmDVkZJxJdU9v9F943g(-961162596 ^ -961066356), u9UadmZJwsreras8Kvet(l15BTnZJEClybrBtxmWr(vAtnCnZJhF77WXeocTeZ(this)), "") ? BtpCFZZJ4Ccdhxu8wmKd(this) : vAtnCnZJhF77WXeocTeZ(this), vNmDVkZJxJdU9v9F943g(0x2F44D93A ^ 0x2F46411A)));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 != 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				de5LT0ZJzFI2mg1jd5WI(stringBuilder, Kxm9UoZlZQlQfXGrXpjF(uR78bgZlOH3pIX99vU75(vNmDVkZJxJdU9v9F943g(-360662087 ^ -360529883), katQouZlKZHOtsFC7LKi(RBoQalZJ1t0Q6QMkHbUZ(this).ToString()), vNmDVkZJxJdU9v9F943g(0x63D6C913 ^ 0x63D4B2E3)), subFolders ? "" : context.Uid.ToString().Replace((string)vNmDVkZJxJdU9v9F943g(0x3C1FFB55 ^ 0x3C1DCB57), "")));
				num2 = 5;
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
			string arg = HTMLUtility.InsertHyperLink(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-11799394 ^ -11949826), swimlane.Uid.ToString().Replace(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-22348816 ^ -22492174), "")), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-539998957 ^ -539879057), swimlane.Name);
			stringBuilder.Append(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1393899982 ^ -1394063364), SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1843E01F ^ 0x184161E7)), arg));
		}
		if (!string.IsNullOrEmpty(element.Description))
		{
			stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638225214 ^ -1638345942) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1895853023 ^ -1895977959)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x70EBB9F3 ^ 0x70E9C599) + element.Description + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x438A0E43 ^ 0x43883D61));
		}
		if (Status != null)
		{
			stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-17847711 ^ -17968247) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-642713667 ^ -642617461)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x37E97159 ^ 0x37EB0D33) + Status.GetLocalizedValue() + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x75872B6 ^ 0x75A4194));
		}
		return stringBuilder.ToString();
	}

	public override string HtmlFooter()
	{
		StringBuilder stringBuilder = new StringBuilder();
		de5LT0ZJzFI2mg1jd5WI(stringBuilder, (string)vNmDVkZJxJdU9v9F943g(0x56A753C9 ^ 0x56A52EA5) + GetConnectorsLink());
		stringBuilder.Append((string)vNmDVkZJxJdU9v9F943g(0x37F755F5 ^ 0x37F52875));
		return stringBuilder.ToString();
	}

	public WorkflowInstanceStatusElement()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		JkH8fbZlv3qfb7kel8if();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object vNmDVkZJxJdU9v9F943g(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object y1bDtFZJS1cDeuLFHiUu(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool B67TWBZJel4yeDObxKMn()
	{
		return t4w9jZZJrej9PNXehQfo == null;
	}

	internal static WorkflowInstanceStatusElement oJWJHKZJNvuaCc6VQFrQ()
	{
		return t4w9jZZJrej9PNXehQfo;
	}

	internal static Guid RBoQalZJ1t0Q6QMkHbUZ(object P_0)
	{
		return ((Element)P_0).Uid;
	}

	internal static object vAtnCnZJhF77WXeocTeZ(object P_0)
	{
		return ((Element)P_0).Name;
	}

	internal static object l15BTnZJEClybrBtxmWr(object P_0)
	{
		return ((string)P_0).Trim();
	}

	internal static bool u9UadmZJwsreras8Kvet(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object BtpCFZZJ4Ccdhxu8wmKd(object P_0)
	{
		return ((Element)P_0).DefaultName;
	}

	internal static object de5LT0ZJzFI2mg1jd5WI(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).Append((string)P_1);
	}

	internal static object katQouZlKZHOtsFC7LKi(object P_0)
	{
		return HTMLUtility.MakeValidFileName((string)P_0);
	}

	internal static object uR78bgZlOH3pIX99vU75(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object Kxm9UoZlZQlQfXGrXpjF(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static void JkH8fbZlv3qfb7kel8if()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
