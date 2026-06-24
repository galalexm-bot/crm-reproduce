using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Diagrams.Toolbox;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Mappings;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.SubProcess;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Toolbox;
using EleWise.ELMA.Workflow.Diagrams;
using EleWise.ELMA.Workflow.Diagrams.Elements;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Properties;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.SubProcess;

[Serializable]
[HintShape(typeof(ExternalSubprocessHintShape))]
[WebDiagrammerShape(typeof(WebDiagrammerExternalSubprocessShape))]
[SupportedMarker(TaskMarker.MultiInstance)]
[Shape(typeof(ExternalSubprocessShape))]
public class ExternalSubprocessElement : SubProcessElement, IExceptionFlowSupported, IReplaceContextVar, IElementWithPropertyMap
{
	[Component(Order = 100)]
	public class ToolboxItem : IBPMNToolboxItem, IToolboxItem, IContainingElementIcon
	{
		internal static ToolboxItem hQKKhCvPRfONBMIx4er2;

		public string Name => SR.T((string)jug4BnvP3e0XGOj0goDV(0x5DB28AD2 ^ 0x5DB056E2));

		public Guid GroupUid => BPMNGroups.Subprocesses.UID;

		public Image Image => (Image)yckbFgvPTeb5c6dcbZeU();

		public Type ElementType => typeof(ExternalSubprocessElement);

		public string ElementIcon => SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DB28AD2 ^ 0x5DB0568A);

		public ToolboxItem()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			KJruNHvPQgumJ0SWdps1();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object jug4BnvP3e0XGOj0goDV(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static bool q33qXCvP65GumqZtMIGT()
		{
			return hQKKhCvPRfONBMIx4er2 == null;
		}

		internal static ToolboxItem yy59cDvPqGiuc6jOULHT()
		{
			return hQKKhCvPRfONBMIx4er2;
		}

		internal static object yckbFgvPTeb5c6dcbZeU()
		{
			return Resources.symb_external_process;
		}

		internal static void KJruNHvPQgumJ0SWdps1()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	internal static ExternalSubprocessElement N1hL3eZ8KCohGUqMdLdF;

	public PropertyMap InputContextMap
	{
		[CompilerGenerated]
		get
		{
			return _003CInputContextMap_003Ek__BackingField;
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
					_003CInputContextMap_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public PropertyMap OutputContextMap
	{
		[CompilerGenerated]
		get
		{
			return _003COutputContextMap_003Ek__BackingField;
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
					_003COutputContextMap_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public PropertyMap[] UsingPropertyMap => new PropertyMap[2] { InputContextMap, OutputContextMap };

	public virtual EventTrigger[] SupportedTriggers => new EventTrigger[2]
	{
		EventTrigger.Timer,
		EventTrigger.Script
	};

	public override string ChapterName => SR.T((string)KCEJJLZ8sFKwS7Lf3aQ1(-1393899982 ^ -1394061830));

	public override string HtmlHeader(ProcessContext context, int orgStructVersion, bool subFolders, WorkflowDiagram diagram, GenerationSettings gs = null)
	{
		//Discarded unreachable code: IL_00bc, IL_00cb
		int num = 8;
		int num2 = num;
		string text = default(string);
		StringBuilder stringBuilder = default(StringBuilder);
		string text2 = default(string);
		while (true)
		{
			switch (num2)
			{
			case 11:
				text = (string)glEXwZZ8PBLYRdlS4l4S(KCEJJLZ8sFKwS7Lf3aQ1(-1498811449 ^ -1498711699), xBrGXsZ8cNVd4bdC9Os1(KCEJJLZ8sFKwS7Lf3aQ1(-1050383744 ^ -1050222510)), Hoa6LhZ8v3cwo0fLqa13(this), KCEJJLZ8sFKwS7Lf3aQ1(-2111219045 ^ -2111057443));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				stringBuilder.Append(text2);
				num2 = 5;
				break;
			case 8:
				stringBuilder = new StringBuilder();
				num2 = 7;
				break;
			case 1:
				if (((AbstractNHEntityManager<IProcessHeader, long>)pd45pMZ8gyOjDa9iGLIk()).LoadOrNull(q1OgNhZ8BCk1IxIDtDar(this)) != null)
				{
					num2 = 11;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 == 0)
					{
						num2 = 11;
					}
					break;
				}
				goto case 4;
			case 9:
				stringBuilder.Append((string)KCEJJLZ8sFKwS7Lf3aQ1(-708128192 ^ -708290366));
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d == 0)
				{
					num2 = 1;
				}
				break;
			case 5:
			case 13:
				VPu1tGZ80D2meyYJ3LZI(stringBuilder, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1393899982 ^ -1393859218));
				num2 = 10;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d != 0)
				{
					num2 = 4;
				}
				break;
			case 6:
				return stringBuilder.ToString();
			case 12:
				VPu1tGZ80D2meyYJ3LZI(stringBuilder, KCEJJLZ8sFKwS7Lf3aQ1(-1214182792 ^ -1214025402));
				num2 = 8;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b == 0)
				{
					num2 = 9;
				}
				break;
			case 10:
				VPu1tGZ80D2meyYJ3LZI(stringBuilder, KCEJJLZ8sFKwS7Lf3aQ1(0x56A753C9 ^ 0x56A52FD5));
				num2 = 6;
				break;
			case 3:
				VPu1tGZ80D2meyYJ3LZI(stringBuilder, text2);
				num2 = 13;
				break;
			case 7:
				VPu1tGZ80D2meyYJ3LZI(stringBuilder, BO7AWpZ8lwM88XMXgxLE(new object[5]
				{
					SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6871CA ^ 0x6A0AD2),
					((string)CPnnZVZ8Yu3t6glsCM7E(Hoa6LhZ8v3cwo0fLqa13(this)) == "") ? WqJAwtZ88Naq9gr1uQmF(this) : Name,
					KCEJJLZ8sFKwS7Lf3aQ1(-1393899982 ^ -1394017122),
					RAMMgGZ8JydlhiMkWtgK(this),
					KCEJJLZ8sFKwS7Lf3aQ1(0x157D5AF4 ^ 0x157F21D0)
				}));
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 != 0)
				{
					num2 = 12;
				}
				break;
			case 2:
				text2 = (string)F6qXryZ852Qq7AFEYaXu(p5bBixZ8mAuh8Cp1NJag(KCEJJLZ8sFKwS7Lf3aQ1(0x75872B6 ^ 0x75A5D7C), lrcXnqZ8yQUZGZmUGlQ3(RAMMgGZ8JydlhiMkWtgK(this).ToString()), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-63028171 ^ -63160379)), subFolders ? "" : Hm49rgZ8bGcDeiwoIVHr(dqELA3Z8tifAPTS16Y8E(context).ToString(), KCEJJLZ8sFKwS7Lf3aQ1(-1028861977 ^ -1028718619), ""));
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca == 0)
				{
					num2 = 1;
				}
				break;
			default:
				text2 = (string)CqYW2GZ8XGTnbld8bAyV((string)KCEJJLZ8sFKwS7Lf3aQ1(-1050383744 ^ -1050262198) + HTMLUtility.MakeValidFileName(RAMMgGZ8JydlhiMkWtgK(this).ToString()) + (string)KCEJJLZ8sFKwS7Lf3aQ1(0x6F6D7B44 ^ 0x6F6FF00A), subFolders ? "" : Hm49rgZ8bGcDeiwoIVHr(context.Uid.ToString(), KCEJJLZ8sFKwS7Lf3aQ1(--1756698829 ^ 0x68B728CF), ""), text);
				num2 = 3;
				break;
			}
		}
	}

	public override string HtmlBody(Element element, List<ProcessContext> contexts, int orgStructVersion, bool subFolders, WorkflowDiagram diagram, IWorkflowProcess wp = null, GenerationSettings gs = null)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(base.HtmlBody(element, contexts, orgStructVersion, subFolders, diagram, wp, gs));
		GetInputOutputAttributesTable(stringBuilder, wp);
		return stringBuilder.ToString();
	}

	private void GetLeftRightContext(ref ProcessContext leftCon, ref ProcessContext rightCon, PropertyMap map)
	{
		//Discarded unreachable code: IL_0041, IL_0074, IL_0083, IL_011d, IL_012c, IL_0157, IL_016e, IL_017d
		switch (1)
		{
		case 1:
			try
			{
				ProcessContext processContext = ProcessContextManager.Instance.Load(dg4RoeZ8d6nM0q6hg9HT(map));
				int num = 5;
				ProcessContext processContext2 = default(ProcessContext);
				while (true)
				{
					switch (num)
					{
					case 3:
						return;
					case 5:
						processContext2 = ((AbstractNHEntityManager<ProcessContext, long>)EdfUO7Z8uoe3DBTNQ2mt()).Load(tstBsSZ8DN0hpMmEsvFC(map));
						num = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 == 0)
						{
							num = 1;
						}
						break;
					case 2:
						rightCon = processContext2;
						num = 4;
						break;
					default:
						leftCon = processContext;
						num = 6;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af != 0)
						{
							num = 4;
						}
						break;
					case 1:
						if (processContext == null)
						{
							num = 7;
							break;
						}
						goto default;
					case 6:
					case 7:
						if (processContext2 == null)
						{
							num = 3;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 != 0)
							{
								num = 2;
							}
							break;
						}
						goto case 2;
					case 4:
						return;
					}
				}
			}
			catch (Exception)
			{
				int num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 != 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				case 0:
					break;
				}
				break;
			}
		case 0:
			break;
		}
	}

	private void GetInputOutputAttributesTable(StringBuilder sb, IWorkflowProcess wp)
	{
		//Discarded unreachable code: IL_00e0, IL_00f0, IL_00ff, IL_010a, IL_01c5, IL_01d8, IL_01e7, IL_01f7, IL_0285, IL_02a2, IL_03bb, IL_0432, IL_0441, IL_0451, IL_0535, IL_0544, IL_05ee, IL_0601
		int num = 13;
		List<PropertyMapItem>.Enumerator enumerator = default(List<PropertyMapItem>.Enumerator);
		PropertyMapItem current2 = default(PropertyMapItem);
		ProcessContext leftCon2 = default(ProcessContext);
		ProcessContext rightCon2 = default(ProcessContext);
		ProcessContext rightCon = default(ProcessContext);
		ProcessContext leftCon = default(ProcessContext);
		bool flag2 = default(bool);
		bool flag = default(bool);
		PropertyMapItem current = default(PropertyMapItem);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num6;
				int num7;
				switch (num2)
				{
				case 22:
					InputTable((string)xBrGXsZ8cNVd4bdC9Os1(KCEJJLZ8sFKwS7Lf3aQ1(-684210684 ^ -684373398)), sb);
					num2 = 17;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 == 0)
					{
						num2 = 16;
					}
					continue;
				case 21:
					try
					{
						while (true)
						{
							int num8;
							if (!enumerator.MoveNext())
							{
								num8 = 2;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 != 0)
								{
									num8 = 3;
								}
								goto IL_010e;
							}
							goto IL_0176;
							IL_0176:
							current2 = enumerator.Current;
							num8 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 != 0)
							{
								num8 = 1;
							}
							goto IL_010e;
							IL_010e:
							while (true)
							{
								switch (num8)
								{
								case 2:
									break;
								case 1:
									Append(leftCon2, rightCon2, current2, wp, sb);
									num8 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 == 0)
									{
										num8 = 2;
									}
									continue;
								default:
									goto IL_0176;
								case 3:
									goto end_IL_0128;
								}
								break;
							}
							continue;
							end_IL_0128:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num9 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d != 0)
						{
							num9 = 0;
						}
						switch (num9)
						{
						case 0:
							break;
						}
					}
					goto case 20;
				case 9:
					rightCon = new ProcessContext();
					num2 = 5;
					continue;
				case 4:
					enumerator = InputContextMap.Items.GetEnumerator();
					num2 = 21;
					continue;
				case 18:
					GetLeftRightContext(ref leftCon, ref rightCon, OutputContextMap);
					num2 = 24;
					continue;
				case 13:
					if (InputContextMap != null)
					{
						num2 = 3;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea == 0)
						{
							num2 = 12;
						}
						continue;
					}
					num6 = 0;
					goto IL_0636;
				case 28:
					num7 = ((l0nvPQZ8nKPdRTRKFXYE(OutputContextMap.Items) > 0) ? 1 : 0);
					goto IL_0643;
				case 12:
					num6 = ((l0nvPQZ8nKPdRTRKFXYE(InputContextMap.Items) > 0) ? 1 : 0);
					goto IL_0636;
				case 29:
					VPu1tGZ80D2meyYJ3LZI(sb, KCEJJLZ8sFKwS7Lf3aQ1(0x37E97159 ^ 0x37EBFD77));
					num2 = 22;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 != 0)
					{
						num2 = 3;
					}
					continue;
				case 1:
				case 8:
					VPu1tGZ80D2meyYJ3LZI(sb, KCEJJLZ8sFKwS7Lf3aQ1(0x595C500A ^ 0x595E6D4E));
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 != 0)
					{
						num2 = 14;
					}
					continue;
				case 23:
					GetLeftRightContext(ref leftCon2, ref rightCon2, InputContextMap);
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 != 0)
					{
						num2 = 4;
					}
					continue;
				case 32:
					if (flag2)
					{
						num2 = 15;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 == 0)
						{
							num2 = 10;
						}
						continue;
					}
					return;
				case 14:
					return;
				case 7:
					return;
				case 15:
				case 31:
					sb.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-22348816 ^ -22515710));
					num2 = 10;
					continue;
				case 30:
					rightCon2 = new ProcessContext();
					num2 = 19;
					continue;
				default:
					VPu1tGZ80D2meyYJ3LZI(sb, KCEJJLZ8sFKwS7Lf3aQ1(-261315199 ^ -261215825));
					num2 = 25;
					continue;
				case 5:
					if (InputContextMap != null)
					{
						num2 = 18;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d != 0)
						{
							num2 = 13;
						}
						continue;
					}
					goto case 11;
				case 17:
					leftCon2 = new ProcessContext();
					num2 = 30;
					continue;
				case 11:
					VPu1tGZ80D2meyYJ3LZI(sb, KCEJJLZ8sFKwS7Lf3aQ1(0x63D6C913 ^ 0x63D445CD));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 != 0)
					{
						num2 = 1;
					}
					continue;
				case 27:
					if (OutputContextMap != null)
					{
						num2 = 28;
						continue;
					}
					num7 = 0;
					goto IL_0643;
				case 19:
					if (InputContextMap == null)
					{
						num2 = 20;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 == 0)
						{
							num2 = 12;
						}
						continue;
					}
					goto case 23;
				case 10:
					if (!flag)
					{
						num2 = 16;
						continue;
					}
					goto case 29;
				case 24:
					enumerator = OutputContextMap.Items.GetEnumerator();
					num = 6;
					break;
				case 2:
				case 16:
					if (!flag2)
					{
						num2 = 8;
						continue;
					}
					goto default;
				case 26:
					if (flag)
					{
						num = 31;
						break;
					}
					goto case 32;
				case 3:
					leftCon = new ProcessContext();
					num2 = 9;
					continue;
				case 20:
				case 33:
					VPu1tGZ80D2meyYJ3LZI(sb, KCEJJLZ8sFKwS7Lf3aQ1(0x5DB28AD2 ^ 0x5DB00644));
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 != 0)
					{
						num2 = 2;
					}
					continue;
				case 6:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 == 0)
								{
									num3 = 1;
								}
								goto IL_0553;
							}
							goto IL_0593;
							IL_0593:
							current = enumerator.Current;
							int num4 = 3;
							num3 = num4;
							goto IL_0553;
							IL_0553:
							while (true)
							{
								switch (num3)
								{
								case 2:
									break;
								default:
									goto IL_0593;
								case 3:
									Append(leftCon, rightCon, current, wp, sb);
									num3 = 2;
									continue;
								case 1:
									goto end_IL_056d;
								}
								break;
							}
							continue;
							end_IL_056d:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num5 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb == 0)
						{
							num5 = 0;
						}
						switch (num5)
						{
						case 0:
							break;
						}
					}
					goto case 11;
				case 25:
					{
						InputTable((string)xBrGXsZ8cNVd4bdC9Os1(KCEJJLZ8sFKwS7Lf3aQ1(0x8D5763A ^ 0x8D7FA8E)), sb);
						num2 = 3;
						continue;
					}
					IL_0643:
					flag2 = (byte)num7 != 0;
					num = 26;
					break;
					IL_0636:
					flag = (byte)num6 != 0;
					num2 = 27;
					continue;
				}
				break;
			}
		}
	}

	private void InputTable(string name, StringBuilder sb)
	{
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					sb.Append((string)F6qXryZ852Qq7AFEYaXu(KCEJJLZ8sFKwS7Lf3aQ1(0x34EA50D4 ^ 0x34E8DC28), name));
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d == 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
					VPu1tGZ80D2meyYJ3LZI(sb, EmDP5AZ8HhZJ7awhlFj7(new string[3]
					{
						SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C663DA1 ^ 0x1C64B081)),
						(string)xBrGXsZ8cNVd4bdC9Os1(KCEJJLZ8sFKwS7Lf3aQ1(-452127399 ^ -451975109)),
						(string)xBrGXsZ8cNVd4bdC9Os1(KCEJJLZ8sFKwS7Lf3aQ1(-420003255 ^ -420098191))
					}, true, null));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					break;
				case 0:
					return;
				}
				break;
			}
			VPu1tGZ80D2meyYJ3LZI(sb, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-949717965 ^ -949599653));
			num = 3;
		}
	}

	private void Append(ProcessContext leftContext, ProcessContext rightContext, PropertyMapItem item, IWorkflowProcess wp, StringBuilder sb)
	{
		//Discarded unreachable code: IL_0101, IL_0111, IL_0146, IL_0206, IL_0219, IL_0249
		int num = 2;
		List<ProcessContext>.Enumerator enumerator = default(List<ProcessContext>.Enumerator);
		List<ProcessContext> list = default(List<ProcessContext>);
		int padding2 = default(int);
		int padding = default(int);
		object obj3 = default(object);
		ProcessContext current = default(ProcessContext);
		object obj = default(object);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj4;
				object obj2;
				switch (num2)
				{
				default:
					return;
				case 10:
					enumerator = list.GetEnumerator();
					num = 6;
					break;
				case 2:
					padding2 = 0;
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					padding = 0;
					num2 = 13;
					continue;
				case 0:
					return;
				case 4:
					return;
				case 16:
					if (obj3 == null)
					{
						num = 7;
						break;
					}
					goto case 5;
				case 15:
					ProcessDocumentationHelper.GetParentsContext(wp, list, thisContext: false);
					num2 = 10;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 != 0)
					{
						num2 = 10;
					}
					continue;
				case 7:
					list = new List<ProcessContext>();
					num2 = 15;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 == 0)
					{
						num2 = 7;
					}
					continue;
				case 6:
					try
					{
						while (true)
						{
							IL_0171:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 3;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af == 0)
								{
									num3 = 5;
								}
								goto IL_011f;
							}
							goto IL_0197;
							IL_0197:
							current = enumerator.Current;
							int num4 = 3;
							num3 = num4;
							goto IL_011f;
							IL_011f:
							while (true)
							{
								switch (num3)
								{
								case 0:
									break;
								case 1:
									if (obj3 != null)
									{
										num3 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b == 0)
										{
											num3 = 0;
										}
										continue;
									}
									goto IL_0171;
								case 4:
									goto IL_0171;
								case 2:
									goto IL_0197;
								case 3:
									obj3 = GetProperty(current, stUI5KZ89RSBryQHXg61(item), ref padding);
									num3 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 != 0)
									{
										num3 = 1;
									}
									continue;
								case 5:
									break;
								}
								break;
							}
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num5 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 == 0)
						{
							num5 = 0;
						}
						switch (num5)
						{
						case 0:
							break;
						}
					}
					goto case 5;
				case 12:
					if (obj3 == null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 3;
				case 3:
				case 8:
					AppendPropertyRow(obj, obj3, sb, padding2, padding);
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 == 0)
					{
						num2 = 3;
					}
					continue;
				case 5:
					if (obj != null)
					{
						num2 = 3;
						continue;
					}
					goto case 12;
				case 13:
					obj4 = eUqO6PZ8L98HPcOhcSl3(item);
					if (obj4 != null)
					{
						goto IL_02c1;
					}
					num = 11;
					break;
				case 11:
					obj4 = GetProperty(leftContext, item.LeftPropertyUid, ref padding2);
					goto IL_02c1;
				case 14:
					obj2 = KyvpVvZ8fX4yaSA1qoF7(item);
					if (obj2 != null)
					{
						goto IL_030a;
					}
					num2 = 9;
					continue;
				case 9:
					{
						obj2 = GetProperty(rightContext, obj, item.RightPropertyUid, ref padding);
						goto IL_030a;
					}
					IL_030a:
					obj3 = obj2;
					num2 = 16;
					continue;
					IL_02c1:
					obj = obj4;
					num2 = 14;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d != 0)
					{
						num2 = 12;
					}
					continue;
				}
				break;
			}
		}
	}

	private NamedMetadata GetProperty(ProcessContext leftContext, Guid propertyUid, ref int padding)
	{
		int num = 1;
		int num2 = num;
		object obj;
		while (true)
		{
			switch (num2)
			{
			case 1:
				obj = ProcessDocumentationHelper.GetEntityProperty((IEnumerable<EntityPropertyMetadata>)leftContext.EntityProperties, (IEnumerable<TablePartMetadata>)leftContext.EntityTableParts, propertyUid, ref padding);
				if (obj != null)
				{
					break;
				}
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 == 0)
				{
					num2 = 0;
				}
				continue;
			default:
				obj = ProcessDocumentationHelper.GetTablePart((IEnumerable<TablePartMetadata>)leftContext.EntityTableParts, propertyUid, ref padding);
				break;
			}
			break;
		}
		return (NamedMetadata)obj;
	}

	private NamedMetadata GetProperty(ProcessContext rightContext, object leftProperty, Guid propertyUid, ref int padding)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!(leftProperty is EntityPropertyMetadata))
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return ProcessDocumentationHelper.GetEntityProperty((IEnumerable<EntityPropertyMetadata>)rightContext.EntityProperties, (IEnumerable<TablePartMetadata>)rightContext.EntityTableParts, propertyUid, ref padding);
			default:
				return ProcessDocumentationHelper.GetTablePart((IEnumerable<TablePartMetadata>)rightContext.EntityTableParts, propertyUid, ref padding);
			}
		}
	}

	private void AppendPropertyRow(object leftProperty, object rightProperty, StringBuilder sb, int leftPadding, int rightPadding)
	{
		int num = 1;
		int num2 = num;
		string typeName = default(string);
		string left = default(string);
		string right = default(string);
		object link = default(object);
		while (true)
		{
			switch (num2)
			{
			case 1:
				ProcessDocumentationHelper.GetParameters(leftProperty, rightProperty, out typeName, out left, out right, out link);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return;
			}
			VPu1tGZ80D2meyYJ3LZI(sb, HTMLUtility.InsertRowToTable(new string[3]
			{
				left,
				typeName,
				(string)((link == null) ? right : ((link is Guid) ? XpxYxqZ8WRWLORJ0vjlm(F6qXryZ852Qq7AFEYaXu(KCEJJLZ8sFKwS7Lf3aQ1(-1647793954 ^ -1647667406), link.ToString().Replace(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2122743969 ^ -2122625187), "")), right) : XpxYxqZ8WRWLORJ0vjlm(link.ToString(), right)))
			}, isBold: false, new string[3]
			{
				(leftPadding > 0) ? string.Format((string)KCEJJLZ8sFKwS7Lf3aQ1(-772614310 ^ -772764708), leftPadding) : "",
				string.Empty,
				string.Empty
			}));
			num2 = 2;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 != 0)
			{
				num2 = 1;
			}
		}
	}

	public override void ReplaceContextVar(Dictionary<Guid, Guid> replaceContextVar)
	{
		base.ReplaceContextVar(replaceContextVar);
		OutputContextMap?.ReplaceContextVars(replaceContextVar);
		InputContextMap?.ReplaceContextVars(replaceContextVar);
	}

	public ExternalSubprocessElement()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		cTfJhrZ8jhTsNkEVLMlr();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool MK4j6AZ8OJjOHbUQLrZq()
	{
		return N1hL3eZ8KCohGUqMdLdF == null;
	}

	internal static ExternalSubprocessElement kKD4iPZ8ZvSGj6ZvL9M2()
	{
		return N1hL3eZ8KCohGUqMdLdF;
	}

	internal static object Hoa6LhZ8v3cwo0fLqa13(object P_0)
	{
		return ((Element)P_0).Name;
	}

	internal static object CPnnZVZ8Yu3t6glsCM7E(object P_0)
	{
		return ((string)P_0).Trim();
	}

	internal static object WqJAwtZ88Naq9gr1uQmF(object P_0)
	{
		return ((Element)P_0).DefaultName;
	}

	internal static object KCEJJLZ8sFKwS7Lf3aQ1(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Guid RAMMgGZ8JydlhiMkWtgK(object P_0)
	{
		return ((Element)P_0).Uid;
	}

	internal static object BO7AWpZ8lwM88XMXgxLE(object P_0)
	{
		return string.Concat((object[])P_0);
	}

	internal static object VPu1tGZ80D2meyYJ3LZI(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).Append((string)P_1);
	}

	internal static object lrcXnqZ8yQUZGZmUGlQ3(object P_0)
	{
		return HTMLUtility.MakeValidFileName((string)P_0);
	}

	internal static object p5bBixZ8mAuh8Cp1NJag(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static Guid dqELA3Z8tifAPTS16Y8E(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object Hm49rgZ8bGcDeiwoIVHr(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static object F6qXryZ852Qq7AFEYaXu(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object pd45pMZ8gyOjDa9iGLIk()
	{
		return ProcessHeaderManager.Instance;
	}

	internal static long q1OgNhZ8BCk1IxIDtDar(object P_0)
	{
		return ((SubProcessElement)P_0).ProcessHeaderId;
	}

	internal static object xBrGXsZ8cNVd4bdC9Os1(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object glEXwZZ8PBLYRdlS4l4S(object P_0, object P_1, object P_2, object P_3)
	{
		return (string)P_0 + (string)P_1 + (string)P_2 + (string)P_3;
	}

	internal static object CqYW2GZ8XGTnbld8bAyV(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static Guid dg4RoeZ8d6nM0q6hg9HT(object P_0)
	{
		return ((PropertyMap)P_0).LeftClassUid;
	}

	internal static object EdfUO7Z8uoe3DBTNQ2mt()
	{
		return ProcessContextManager.Instance;
	}

	internal static Guid tstBsSZ8DN0hpMmEsvFC(object P_0)
	{
		return ((PropertyMap)P_0).RightClassUid;
	}

	internal static int l0nvPQZ8nKPdRTRKFXYE(object P_0)
	{
		return ((List<PropertyMapItem>)P_0).Count;
	}

	internal static object EmDP5AZ8HhZJ7awhlFj7(object P_0, bool isBold, object P_2)
	{
		return HTMLUtility.InsertRowToTable((string[])P_0, isBold, (string[])P_2);
	}

	internal static object eUqO6PZ8L98HPcOhcSl3(object P_0)
	{
		return ((PropertyMapItem)P_0).LeftValue;
	}

	internal static object KyvpVvZ8fX4yaSA1qoF7(object P_0)
	{
		return ((PropertyMapItem)P_0).RightValue;
	}

	internal static Guid stUI5KZ89RSBryQHXg61(object P_0)
	{
		return ((PropertyMapItem)P_0).RightPropertyUid;
	}

	internal static object XpxYxqZ8WRWLORJ0vjlm(object P_0, object P_1)
	{
		return HTMLUtility.InsertHyperLink((string)P_0, (string)P_1);
	}

	internal static void cTfJhrZ8jhTsNkEVLMlr()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
