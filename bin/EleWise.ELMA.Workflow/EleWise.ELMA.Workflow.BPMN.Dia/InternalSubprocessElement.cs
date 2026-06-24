using System;
using System.Drawing;
using System.Text;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Diagrams.Toolbox;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.SubProcess;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Toolbox;
using EleWise.ELMA.Workflow.Diagrams;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Properties;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.SubProcess;

[Serializable]
[WebDiagrammerShape(typeof(WebDiagrammerInternalSubprocessShape))]
[Shape(typeof(InternalSubprocessShape))]
[HintShape(typeof(InternalSubprocessHintShape))]
public class InternalSubprocessElement : SubProcessElement, IExceptionFlowSupported
{
	[Component(Order = 200)]
	public class ToolboxItem : IBPMNToolboxItem, IToolboxItem, IContainingElementIcon
	{
		private static ToolboxItem fiRxbvvPpFdMEKxGgo4s;

		public string Name => (string)rccWWkvPUfsH596aCToW(C8OwKUvPktZfsI05Qdhh(-862330810 ^ -862241596));

		public Guid GroupUid => BPMNGroups.Subprocesses.UID;

		public Image Image => (Image)mcTZAvvPV110myjlfVp6();

		public Type ElementType => SsUwHevPA583benxHbjq(typeof(InternalSubprocessElement).TypeHandle);

		public string ElementIcon => (string)C8OwKUvPktZfsI05Qdhh(0x6F6D7B44 ^ 0x6F6FA7F4);

		public ToolboxItem()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			BOda1xvPGVQpideqrwC2();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object C8OwKUvPktZfsI05Qdhh(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object rccWWkvPUfsH596aCToW(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool yY962LvPCGOsPvK1r9YW()
		{
			return fiRxbvvPpFdMEKxGgo4s == null;
		}

		internal static ToolboxItem HU13E7vPMwQsJPmFKFho()
		{
			return fiRxbvvPpFdMEKxGgo4s;
		}

		internal static object mcTZAvvPV110myjlfVp6()
		{
			return Resources.symb_internal_process;
		}

		internal static Type SsUwHevPA583benxHbjq(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static void BOda1xvPGVQpideqrwC2()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	internal static InternalSubprocessElement tTQM6oZ8RL9n76wYUUj2;

	public virtual EventTrigger[] SupportedTriggers => new EventTrigger[2]
	{
		EventTrigger.Timer,
		EventTrigger.Script
	};

	public override string ChapterName => (string)a72Av6Z8ilTOY0Wob5RK(ah3GcwZ83p4m1PHTTiqP(0x51EF0063 ^ 0x51ED8E47));

	public override string HtmlHeader(ProcessContext context, int orgStructVersion, bool subFolders, WorkflowDiagram diagram, GenerationSettings gs = null)
	{
		//Discarded unreachable code: IL_0134, IL_016c, IL_01a1, IL_01b0
		int num = 12;
		StringBuilder stringBuilder = default(StringBuilder);
		string text = default(string);
		Guid guid = default(Guid);
		string text2 = default(string);
		IProcessHeader processHeader = default(IProcessHeader);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					Cjt61XZ8UQBlRCiQ0ZJT(stringBuilder, ah3GcwZ83p4m1PHTTiqP(-43932417 ^ -43788061));
					num2 = 6;
					continue;
				case 16:
					Cjt61XZ8UQBlRCiQ0ZJT(stringBuilder, text);
					num2 = 11;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b == 0)
					{
						num2 = 20;
					}
					continue;
				case 4:
				{
					string text3 = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1756698829 ^ 0x68B79599);
					guid = KMkDyjZ8M8KXrEZHrIUq(this);
					text = (string)BLQQTRZ8o9ntnl32AuiG(text3, lX0omvZ8VJp2KCgwD4ZP(guid.ToString()), ah3GcwZ83p4m1PHTTiqP(0xD305CC2 ^ 0xD32D1BC));
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 == 0)
					{
						num2 = 4;
					}
					continue;
				}
				case 21:
					text2 = guid.ToString();
					num2 = 3;
					continue;
				case 3:
					if (gs == null)
					{
						num2 = 10;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 == 0)
						{
							num2 = 10;
						}
						continue;
					}
					goto case 18;
				case 6:
					return stringBuilder.ToString();
				case 1:
					Cjt61XZ8UQBlRCiQ0ZJT(stringBuilder, ah3GcwZ83p4m1PHTTiqP(0xB7793C9 ^ 0xB75E8F7));
					num = 14;
					break;
				case 2:
					guid = AlCN6LZ82cV5LLVtjnJ0(processHeader);
					num2 = 21;
					continue;
				case 7:
				case 10:
				case 13:
				{
					object obj2 = ah3GcwZ83p4m1PHTTiqP(-763667953 ^ -763766949);
					guid = base.Uid;
					text = (string)BLQQTRZ8o9ntnl32AuiG(obj2, HTMLUtility.MakeValidFileName(guid.ToString()), ah3GcwZ83p4m1PHTTiqP(-495296780 ^ -495442684));
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 == 0)
					{
						num2 = 8;
					}
					continue;
				}
				case 18:
					if (!gs.SubProcessOk)
					{
						num2 = 13;
						continue;
					}
					goto case 4;
				case 12:
					stringBuilder = new StringBuilder();
					num = 11;
					break;
				case 19:
				case 20:
					Cjt61XZ8UQBlRCiQ0ZJT(stringBuilder, ah3GcwZ83p4m1PHTTiqP(-539998957 ^ -539892145));
					num2 = 9;
					continue;
				case 14:
					stringBuilder.Append((string)ah3GcwZ83p4m1PHTTiqP(0xF400DF8 ^ 0xF42877A));
					num2 = 15;
					continue;
				case 5:
				case 8:
					Cjt61XZ8UQBlRCiQ0ZJT(stringBuilder, kUpXT6Z8F3JyAisuDKVQ(new string[5]
					{
						(string)ah3GcwZ83p4m1PHTTiqP(-667465279 ^ -667565023),
						text2,
						SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1600060848 ^ -1599914940),
						text,
						SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-980570076 ^ -980675584)
					}));
					num2 = 19;
					continue;
				case 17:
					processHeader = ((AbstractNHEntityManager<IProcessHeader, long>)I7mN8hZ8GyV21vcSaHSC()).LoadOrNull(AdZE4OZ87aN0tAQG519s(this));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					if (processHeader != null)
					{
						num2 = 2;
						continue;
					}
					goto case 16;
				case 11:
					Cjt61XZ8UQBlRCiQ0ZJT(stringBuilder, qW127DZ8kqPMwhSQ85Sf(new object[5]
					{
						ah3GcwZ83p4m1PHTTiqP(0xB7793C9 ^ 0xB75E8D1),
						imLNtPZ8psE2tlvlEpKD(uYsLUVZ8QJD8j00svZwx(QPf49bZ8TNPQYKwn5Zpt(this)), "") ? TbKPHAZ8C8E3aWJZXJ6N(this) : QPf49bZ8TNPQYKwn5Zpt(this),
						ah3GcwZ83p4m1PHTTiqP(0x1C7F6FED ^ 0x1C7D5541),
						KMkDyjZ8M8KXrEZHrIUq(this),
						SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1600060848 ^ -1599899276)
					}));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede != 0)
					{
						num2 = 1;
					}
					continue;
				case 15:
				{
					object obj = ah3GcwZ83p4m1PHTTiqP(0x75BAD659 ^ 0x75B8F993);
					guid = KMkDyjZ8M8KXrEZHrIUq(this);
					string format = (string)obj + (string)lX0omvZ8VJp2KCgwD4ZP(guid.ToString()) + (string)ah3GcwZ83p4m1PHTTiqP(0x141C968 ^ 0x143B298);
					object arg;
					if (!subFolders)
					{
						guid = context.Uid;
						arg = N1yyUtZ8AtB4HYlF6jsM(guid.ToString(), ah3GcwZ83p4m1PHTTiqP(-1776305410 ^ -1776448772), "");
					}
					else
					{
						arg = "";
					}
					text = string.Format(format, arg);
					num2 = 17;
					continue;
				}
				}
				break;
			}
		}
	}

	public InternalSubprocessElement()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		fX8JS7Z8I35jbAeYvyYb();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool b6YhHJZ86hIT5F6FcdUd()
	{
		return tTQM6oZ8RL9n76wYUUj2 == null;
	}

	internal static InternalSubprocessElement YgTFhUZ8q7TjPG7ZNdjR()
	{
		return tTQM6oZ8RL9n76wYUUj2;
	}

	internal static object ah3GcwZ83p4m1PHTTiqP(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object QPf49bZ8TNPQYKwn5Zpt(object P_0)
	{
		return ((Element)P_0).Name;
	}

	internal static object uYsLUVZ8QJD8j00svZwx(object P_0)
	{
		return ((string)P_0).Trim();
	}

	internal static bool imLNtPZ8psE2tlvlEpKD(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object TbKPHAZ8C8E3aWJZXJ6N(object P_0)
	{
		return ((Element)P_0).DefaultName;
	}

	internal static Guid KMkDyjZ8M8KXrEZHrIUq(object P_0)
	{
		return ((Element)P_0).Uid;
	}

	internal static object qW127DZ8kqPMwhSQ85Sf(object P_0)
	{
		return string.Concat((object[])P_0);
	}

	internal static object Cjt61XZ8UQBlRCiQ0ZJT(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).Append((string)P_1);
	}

	internal static object lX0omvZ8VJp2KCgwD4ZP(object P_0)
	{
		return HTMLUtility.MakeValidFileName((string)P_0);
	}

	internal static object N1yyUtZ8AtB4HYlF6jsM(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static object I7mN8hZ8GyV21vcSaHSC()
	{
		return ProcessHeaderManager.Instance;
	}

	internal static long AdZE4OZ87aN0tAQG519s(object P_0)
	{
		return ((SubProcessElement)P_0).ProcessHeaderId;
	}

	internal static Guid AlCN6LZ82cV5LLVtjnJ0(object P_0)
	{
		return ((IProcessHeader)P_0).Uid;
	}

	internal static object BLQQTRZ8o9ntnl32AuiG(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object kUpXT6Z8F3JyAisuDKVQ(object P_0)
	{
		return string.Concat((string[])P_0);
	}

	internal static object a72Av6Z8ilTOY0Wob5RK(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void fX8JS7Z8I35jbAeYvyYb()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
