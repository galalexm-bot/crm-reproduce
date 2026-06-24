using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Connectors;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Swimlanes;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Decorators;
using EleWise.ELMA.Workflow.Diagrams;
using EleWise.ELMA.Workflow.Diagrams.Elements;
using EleWise.ELMA.Workflow.DTO.Models;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Validation;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.Diagram.Extensions;
using Nevron.Dom;
using Nevron.GraphicsCore;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements;

[Serializable]
public abstract class BPMNFlowElement : FlowElement, IDocumentable, IReplaceContextVar, IElementWithExceptionFlows, IWorkflowElement, IReplaceScriptMethodSignature
{
	private static BPMNFlowElement Kaj9VKZOigGIbvS0SaY7;

	public override string DefaultName => (string)yOUmVcZOrRy3odvCNd9S(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-947937941 ^ -948048215));

	[XmlAttribute("ParentUid")]
	public Guid ParentUid
	{
		[CompilerGenerated]
		get
		{
			return _003CParentUid_003Ek__BackingField;
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
					_003CParentUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlIgnore]
	public List<FlowConnectorElement> StandardOutputFlows => (from c in base.OutputConnectors.OfType<FlowConnectorElement>()
		where _003C_003Ec.LmfNo8vcX5yHHdCspoU4(c) == EventTrigger.None
		select c).ToList();

	[XmlIgnore]
	public List<FlowConnectorElement> ExceptionOutputFlows => (from c in base.OutputConnectors.OfType<FlowConnectorElement>()
		where _003C_003Ec.LmfNo8vcX5yHHdCspoU4(c) != EventTrigger.None
		select c).ToList();

	public List<Guid> ListButtonLocations { get; set; }

	public virtual bool ExceptionOutputIsStandart => false;

	protected virtual int MinOutputFlowsCount => 1;

	protected virtual int MaxOutputFlowsCount => 1;

	protected virtual bool ValidateOutputFlows => true;

	protected virtual SwimlaneType[] SupportedSwimlaneTypes => null;

	protected virtual bool QueueExecutionTimeoutSupported => false;

	public abstract string ChapterName { get; }

	bool IElementWithExceptionFlows.QueueExecutionTimeoutSupported => rgennnZZQAm39eVsgevg(this);

	public SwimlaneElement GetSwimlane(Diagram diagram)
	{
		//Discarded unreachable code: IL_007a, IL_00ad, IL_00c0
		int num = 7;
		Element element = default(Element);
		BPMNFlowElement bPMNFlowElement = default(BPMNFlowElement);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 2:
					goto end_IL_0012;
				case 7:
					element = diagram.Elements[ParentUid];
					num2 = 6;
					continue;
				default:
					obj = null;
					break;
				case 1:
				case 8:
					return element as SwimlaneElement;
				case 5:
					if (bPMNFlowElement == null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af == 0)
						{
							num2 = 0;
						}
						continue;
					}
					obj = RvMM3aZONyNwPG8aQBa3(diagram.Elements, jZRPg4ZOekgCph6S7kY1(bPMNFlowElement));
					break;
				case 3:
					if (element is SwimlaneElement)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto end_IL_0012;
				case 4:
				case 6:
					if (element == null)
					{
						num2 = 8;
						continue;
					}
					goto case 3;
				}
				element = (Element)obj;
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 != 0)
				{
					num2 = 4;
				}
				continue;
				end_IL_0012:
				break;
			}
			bPMNFlowElement = element as BPMNFlowElement;
			num = 5;
		}
	}

	public virtual IEnumerable<Guid> GetVisiblePropertyUids()
	{
		return new Guid[0];
	}

	public virtual void ReplaceContextVar(Dictionary<Guid, Guid> replaceContextVar)
	{
	}

	public virtual void ReplaceSignature(Dictionary<string, string> replaceNames)
	{
	}

	protected override void OnShapeChanged(NShape oldShape, NShape newShape)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				hQew03ZOxNGjYXsLpNNO(this, oldShape, newShape);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				qC8wfRZOSWKTmRSR0m41(this);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			}
		}
	}

	protected virtual void UpdateDecorators()
	{
		//Discarded unreachable code: IL_00a4, IL_00b3, IL_0145, IL_01c3, IL_01f8, IL_0281
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Invalid comparison between Unknown and I4
		int num = 1;
		int num2 = num;
		IDecoratableShape decoratableShape = default(IDecoratableShape);
		ServiceStatus? val = default(ServiceStatus?);
		while (true)
		{
			switch (num2)
			{
			case 8:
				return;
			default:
				if (decoratableShape == null)
				{
					return;
				}
				num2 = 6;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c == 0)
				{
					num2 = 3;
				}
				break;
			case 1:
				decoratableShape = Vmamp6ZO1mEfIx9sQXWc(this) as IDecoratableShape;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 != 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				val = null;
				num2 = 3;
				break;
			case 9:
				val = ((NService)((NDocument)AAA3O1ZOh78axHbItUeO(Vmamp6ZO1mEfIx9sQXWc(this))).get_HistoryService()).get_Status();
				num2 = 7;
				break;
			case 2:
				if (vhVhTGZOEBiwRdQ5tlqi(AAA3O1ZOh78axHbItUeO(Vmamp6ZO1mEfIx9sQXWc(this))) != null)
				{
					num2 = 9;
					break;
				}
				goto case 5;
			case 5:
			case 7:
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 == 0)
				{
					num2 = 4;
				}
				break;
			case 4:
				try
				{
					int num3;
					if (val.HasValue)
					{
						num3 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d != 0)
						{
							num3 = 1;
						}
						goto IL_0149;
					}
					goto IL_0167;
					IL_0167:
					QnJZ7gZO4TmpgR4VWojH(decoratableShape, this);
					num3 = 2;
					goto IL_0149;
					IL_0149:
					while (true)
					{
						switch (num3)
						{
						case 2:
							return;
						case 4:
							G0LF6pZOwmtPrSRuAnZr(vhVhTGZOEBiwRdQ5tlqi(AAA3O1ZOh78axHbItUeO(Vmamp6ZO1mEfIx9sQXWc(this))));
							num3 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 == 0)
							{
								num3 = 0;
							}
							continue;
						case 1:
							if ((int)val.Value != 0)
							{
								num3 = 3;
								continue;
							}
							goto case 4;
						}
						break;
					}
					goto IL_0167;
				}
				finally
				{
					if (val.HasValue)
					{
						int num4 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b != 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								if ((int)val.Value == 0)
								{
									num4 = 3;
									continue;
								}
								break;
							case 3:
								if ((int)((NService)((NDocument)AAA3O1ZOh78axHbItUeO(Vmamp6ZO1mEfIx9sQXWc(this))).get_HistoryService()).get_Status() == 1)
								{
									num4 = 2;
									continue;
								}
								break;
							case 2:
								KAaunvZOzHkSQAdMtuo6(vhVhTGZOEBiwRdQ5tlqi(AAA3O1ZOh78axHbItUeO(Vmamp6ZO1mEfIx9sQXWc(this))));
								num4 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede == 0)
								{
									num4 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
			case 3:
				if (((NDiagramElement)Vmamp6ZO1mEfIx9sQXWc(this)).get_Document() == null)
				{
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	protected string CopyReplace(string scriptSignature, Dictionary<string, string> replaceNames)
	{
		string text = scriptSignature;
		if (!string.IsNullOrEmpty(text) && replaceNames != null)
		{
			foreach (KeyValuePair<string, string> replaceName in replaceNames)
			{
				text = Regex.Replace(text, string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105863102 ^ -105718890), replaceName.Key), replaceName.Value);
			}
			return text;
		}
		return text;
	}

	protected virtual bool CanHandleExceptionByEscalation(Exception exception)
	{
		return false;
	}

	public override void Validate(WorkflowProcessValidator validator)
	{
		//Discarded unreachable code: IL_0130, IL_017c, IL_01c5, IL_01d4, IL_01e4, IL_02ce, IL_0301, IL_0310, IL_031f, IL_0372, IL_0427, IL_0436, IL_0478, IL_0487, IL_0492, IL_053f, IL_05c1, IL_05f9, IL_068c, IL_069b, IL_0853, IL_08c4, IL_08d3, IL_08e4, IL_0986, IL_0999, IL_09fb
		int num = 12;
		SwimlaneElement swimlane = default(SwimlaneElement);
		List<FlowConnectorElement> list = default(List<FlowConnectorElement>);
		IExceptionFlowSupported exceptionFlowSupported = default(IExceptionFlowSupported);
		IEnumerator<EventTrigger> enumerator = default(IEnumerator<EventTrigger>);
		EventTrigger current = default(EventTrigger);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				List<FlowConnectorElement> list2;
				switch (num2)
				{
				case 19:
				case 25:
				case 54:
					swimlane = GetSwimlane((Diagram)J6HVicZZ5p1aaEGtuLok(mu03vJZZbsYkUZM96cte(validator)));
					num2 = 24;
					continue;
				case 5:
					if (jcLvnJZZZVkpnC7nmH6q(this) > 0)
					{
						num2 = 34;
						continue;
					}
					goto case 26;
				case 15:
					if (list.Count != MinOutputFlowsCount)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 29;
				case 16:
					if (exceptionFlowSupported != null)
					{
						num2 = 14;
						continue;
					}
					goto case 53;
				case 21:
					if (!((IEnumerable<SwimlaneType>)r0ddFkZZgQTyyFHK5SJx(this)).Contains(xM6JkoZZBdD6ZeqbiF0c(swimlane)))
					{
						num2 = 39;
						continue;
					}
					goto case 13;
				case 13:
				case 17:
				case 32:
					if (swimlane != null)
					{
						num = 2;
						break;
					}
					goto case 46;
				case 49:
					validator.Messages.Add((ProcessValidationMessage)gZwLH3ZZYqmEOeoT81KH(base.ValidationHelper, rBBIWtZZ0Hab2qOSun0V(yOUmVcZOrRy3odvCNd9S(xNVkcGZZsx9OlmVwASkq(0x75BAD659 ^ 0x75B8A08B)), Name, jcLvnJZZZVkpnC7nmH6q(this))));
					num2 = 7;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 == 0)
					{
						num2 = 3;
					}
					continue;
				case 14:
					if (tjULZwZZyxYfGUaEZrl2(exceptionFlowSupported) != null)
					{
						num2 = 10;
						continue;
					}
					goto case 53;
				case 34:
				case 37:
				case 43:
					if (B71fUtZZ88S6tHkMRYqf(this) == jcLvnJZZZVkpnC7nmH6q(this))
					{
						num = 23;
						break;
					}
					goto case 38;
				case 38:
					if (B71fUtZZ88S6tHkMRYqf(this) == jcLvnJZZZVkpnC7nmH6q(this))
					{
						num2 = 15;
						continue;
					}
					goto case 29;
				case 33:
					if (MinOutputFlowsCount == 1)
					{
						num2 = 27;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f == 0)
						{
							num2 = 10;
						}
						continue;
					}
					goto case 45;
				case 2:
					return;
				case 29:
					if (list.Count < MinOutputFlowsCount)
					{
						num = 33;
						break;
					}
					goto case 45;
				case 53:
					validator.Messages.Add((ProcessValidationMessage)gZwLH3ZZYqmEOeoT81KH(base.ValidationHelper, nua97QZZl3wrWQVTWro3(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x37F755F5 ^ 0x37F522BD), new object[1] { UwB33OZZJ9o6S4AVBOSZ(this) })));
					num2 = 19;
					continue;
				case 9:
					validator.Messages.Add((ProcessValidationMessage)gZwLH3ZZYqmEOeoT81KH(base.ValidationHelper, rBBIWtZZ0Hab2qOSun0V(SR.T((string)xNVkcGZZsx9OlmVwASkq(-1001967776 ^ -1002088160)), UwB33OZZJ9o6S4AVBOSZ(this), MaxOutputFlowsCount)));
					num2 = 18;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede == 0)
					{
						num2 = 1;
					}
					continue;
				case 46:
					validator.Messages.Add((ProcessValidationMessage)gZwLH3ZZYqmEOeoT81KH(base.ValidationHelper, nua97QZZl3wrWQVTWro3(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x747FFBE0 ^ 0x747D8336), new object[1] { UwB33OZZJ9o6S4AVBOSZ(this) })));
					num2 = 3;
					continue;
				case 24:
					if (swimlane == null)
					{
						num2 = 32;
						continue;
					}
					goto case 47;
				case 12:
					base.Validate(validator);
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a == 0)
					{
						num2 = 11;
					}
					continue;
				case 4:
					try
					{
						while (true)
						{
							IL_0514:
							int num3;
							if (!vMXqS2ZZtf7PhHwBONGb(enumerator))
							{
								num3 = 6;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e == 0)
								{
									num3 = 6;
								}
								goto IL_0496;
							}
							goto IL_04bc;
							IL_04bc:
							current = enumerator.Current;
							num3 = 5;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 == 0)
							{
								num3 = 3;
							}
							goto IL_0496;
							IL_0496:
							while (true)
							{
								switch (num3)
								{
								case 1:
									break;
								case 5:
									if (exceptionFlowSupported.SupportedTriggers.Contains(current))
									{
										num3 = 4;
										continue;
									}
									goto case 3;
								case 3:
									text = (string)L8PV6uZZmWLvPg4NHxoW(current);
									num3 = 2;
									continue;
								default:
									goto IL_0514;
								case 2:
									validator.Messages.Add(base.ValidationHelper.CreateValidationError((string)rBBIWtZZ0Hab2qOSun0V(yOUmVcZOrRy3odvCNd9S(xNVkcGZZsx9OlmVwASkq(0x5F534A5C ^ 0x5F513D9E)), Name, text)));
									num3 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 == 0)
									{
										num3 = 0;
									}
									continue;
								case 6:
									goto end_IL_0514;
								}
								break;
							}
							goto IL_04bc;
							continue;
							end_IL_0514:
							break;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num4 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede == 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									enumerator.Dispose();
									num4 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 == 0)
									{
										num4 = 0;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					goto case 19;
				default:
					validator.Messages.Add((ProcessValidationMessage)gZwLH3ZZYqmEOeoT81KH(base.ValidationHelper, string.Format(SR.T((string)xNVkcGZZsx9OlmVwASkq(0x1EA50FCC ^ 0x1EA77B7C)), UwB33OZZJ9o6S4AVBOSZ(this), B71fUtZZ88S6tHkMRYqf(this))));
					num2 = 41;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 == 0)
					{
						num2 = 52;
					}
					continue;
				case 47:
					if (r0ddFkZZgQTyyFHK5SJx(this) == null)
					{
						num2 = 3;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc == 0)
						{
							num2 = 17;
						}
						continue;
					}
					goto case 21;
				case 20:
					if (P16owBZZv2SbD3VH5kUF(ExceptionOutputFlows) <= 0)
					{
						num2 = 54;
						continue;
					}
					goto case 16;
				case 51:
					if (ny7rXCZZOl7BuJH8ZkY0(this))
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 36;
				case 30:
					validator.Messages.Add((ProcessValidationMessage)gZwLH3ZZYqmEOeoT81KH(base.ValidationHelper, SR.T((string)xNVkcGZZsx9OlmVwASkq(0x6C7F14 ^ 0x6E0B44), UwB33OZZJ9o6S4AVBOSZ(this))));
					num2 = 40;
					continue;
				case 27:
					validator.Messages.Add(base.ValidationHelper.CreateValidationError((string)nua97QZZl3wrWQVTWro3(xNVkcGZZsx9OlmVwASkq(0x595C500A ^ 0x595E254A), new object[1] { UwB33OZZJ9o6S4AVBOSZ(this) })));
					num2 = 22;
					continue;
				case 7:
				case 18:
				case 22:
				case 35:
				case 40:
				case 41:
				case 50:
				case 52:
					exceptionFlowSupported = this as IExceptionFlowSupported;
					num2 = 20;
					continue;
				case 48:
					validator.Messages.Add((ProcessValidationMessage)gZwLH3ZZYqmEOeoT81KH(base.ValidationHelper, SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6CC04061 ^ 0x6CC2338B), Name)));
					num2 = 50;
					continue;
				case 11:
					if (syL01TZZKQBpLY7u5cT1(this))
					{
						num2 = 51;
						continue;
					}
					goto case 7;
				case 26:
					if (P16owBZZv2SbD3VH5kUF(list) <= 0)
					{
						num2 = 43;
						continue;
					}
					goto case 48;
				case 42:
					if (list.Count != B71fUtZZ88S6tHkMRYqf(this))
					{
						num2 = 8;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1a2d7634479d44fb8d3718c31b05f73c != 0)
						{
							num2 = 30;
						}
						continue;
					}
					goto case 38;
				case 23:
					if (B71fUtZZ88S6tHkMRYqf(this) == 1)
					{
						num2 = 26;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f == 0)
						{
							num2 = 42;
						}
						continue;
					}
					goto case 38;
				case 8:
					validator.Messages.Add((ProcessValidationMessage)gZwLH3ZZYqmEOeoT81KH(base.ValidationHelper, nua97QZZl3wrWQVTWro3(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-135674354 ^ -135547970), new object[2]
					{
						UwB33OZZJ9o6S4AVBOSZ(this),
						B71fUtZZ88S6tHkMRYqf(this)
					})));
					num2 = 41;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 == 0)
					{
						num2 = 26;
					}
					continue;
				case 3:
					return;
				case 39:
					validator.Messages.Add((ProcessValidationMessage)gZwLH3ZZYqmEOeoT81KH(base.ValidationHelper, rBBIWtZZ0Hab2qOSun0V(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1303601216 ^ -1303451770)), Name, L8PV6uZZmWLvPg4NHxoW(xM6JkoZZBdD6ZeqbiF0c(swimlane)))));
					num2 = 10;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 != 0)
					{
						num2 = 13;
					}
					continue;
				case 28:
					if (P16owBZZv2SbD3VH5kUF(list) <= jcLvnJZZZVkpnC7nmH6q(this))
					{
						num2 = 23;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e == 0)
						{
							num2 = 44;
						}
						continue;
					}
					goto case 9;
				case 45:
					if (P16owBZZv2SbD3VH5kUF(list) < B71fUtZZ88S6tHkMRYqf(this))
					{
						num2 = 8;
						continue;
					}
					goto case 28;
				case 36:
					list2 = (from c in base.OutputConnectors.OfType<FlowConnectorElement>()
						where _003C_003Ec.LmfNo8vcX5yHHdCspoU4(c) == EventTrigger.None
						select c).ToList();
					goto IL_0a10;
				case 1:
					list2 = base.OutputConnectors.OfType<FlowConnectorElement>().ToList();
					goto IL_0a10;
				case 31:
				case 44:
					if (ExceptionOutputFlows.Where((FlowConnectorElement e) => _003C_003Ec.LmfNo8vcX5yHHdCspoU4(e) == EventTrigger.ErrorCatch).Count() <= 1)
					{
						num2 = 35;
						continue;
					}
					goto case 49;
				case 6:
				case 10:
					{
						enumerator = ExceptionOutputFlows.Select((FlowConnectorElement f) => _003C_003Ec.LmfNo8vcX5yHHdCspoU4(f)).Distinct().GetEnumerator();
						num2 = 4;
						continue;
					}
					IL_0a10:
					list = list2;
					num2 = 5;
					continue;
				}
				break;
			}
		}
	}

	public abstract string HtmlHeader(ProcessContext context, int orgStructVersion, bool subFolders, WorkflowDiagram diagram, GenerationSettings gs = null);

	public abstract string HtmlBody(Element element, List<ProcessContext> contexts, int orgStructVersion, bool subFolders, WorkflowDiagram diagram, IWorkflowProcess wp = null, GenerationSettings gs = null);

	public abstract string HtmlFooter();

	public virtual Bitmap GetBitmap(WorkflowDiagram diagram, NShape shape)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00bf: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		int num2 = num;
		float y = default(float);
		float x = default(float);
		while (true)
		{
			switch (num2)
			{
			case 1:
				y = XydLuGZZcvJPGhsBept0(shape).Y;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a != 0)
				{
					num2 = 0;
				}
				break;
			default:
			{
				float num3 = XydLuGZZcvJPGhsBept0(shape).X + ((NModel)shape).get_Bounds().Width;
				Bitmap obj = new Bitmap(height: za8ymkZZPvMWQbpJ6KLO(XydLuGZZcvJPGhsBept0(shape).Y + ((NModel)shape).get_Bounds().Height - y), width: za8ymkZZPvMWQbpJ6KLO(num3 - x));
				Graphics graphics = (Graphics)HL4HuMZZXN0mESObH5aL(obj);
				NCanvas val = new NCanvas(diagram.Document);
				FZYfP2ZZdqEJAhGQE3UH((object)val, new NPointF(x, y));
				DiKiO9ZZuHAMmWmKanjh((object)val, graphics);
				return obj;
			}
			case 2:
				x = ((NModel)shape).get_Bounds().X;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public static string ConvertGuid(Guid guid)
	{
		//Discarded unreachable code: IL_0035, IL_0044
		int num = 3;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 3:
				text = guid.ToString();
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f != 0)
				{
					num2 = 2;
				}
				break;
			case 4:
				return text;
			case 1:
				text = text.Remove(ChgD3eZZDQ23Zx2iyIOc(text, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x51EF0063 ^ 0x51ED3061)), 1);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (ChgD3eZZDQ23Zx2iyIOc(text, xNVkcGZZsx9OlmVwASkq(0xD305CC2 ^ 0xD326CC0)) < 0)
				{
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 1;
			}
		}
	}

	public virtual string GetConnectorsLink()
	{
		//Discarded unreachable code: IL_00c4, IL_00d4, IL_00e3, IL_00ee, IL_0195, IL_01a4, IL_01b4, IL_01d3, IL_020d, IL_021c, IL_029d, IL_0377, IL_03c4, IL_03d3, IL_0432, IL_0445, IL_0454, IL_054d, IL_05b6, IL_05c5, IL_064b, IL_0679, IL_0688, IL_0736, IL_07c0, IL_07cf, IL_07de, IL_07fa, IL_0853, IL_0866, IL_0875
		int num = 2;
		StringBuilder stringBuilder = default(StringBuilder);
		List<Connector>.Enumerator enumerator = default(List<Connector>.Enumerator);
		Connector current = default(Connector);
		string text = default(string);
		Connector current2 = default(Connector);
		string text2 = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					Ng9D7CZZHvIqgq0SY9Lg(stringBuilder, xNVkcGZZsx9OlmVwASkq(-720457373 ^ -720600177));
					num2 = 9;
					continue;
				case 3:
					Ng9D7CZZHvIqgq0SY9Lg(stringBuilder, xNVkcGZZsx9OlmVwASkq(0xA7339EE ^ 0xA714006));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 != 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
				case 10:
					enumerator = base.InputFlows.GetEnumerator();
					num = 6;
					break;
				case 11:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 != 0)
								{
									num3 = 1;
								}
								goto IL_00f2;
							}
							goto IL_02a7;
							IL_02a7:
							current = enumerator.Current;
							num3 = 4;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 == 0)
							{
								num3 = 0;
							}
							goto IL_00f2;
							IL_00f2:
							while (true)
							{
								object obj;
								switch (num3)
								{
								case 7:
									break;
								case 3:
								case 14:
									text = (string)yOUmVcZOrRy3odvCNd9S(xNVkcGZZsx9OlmVwASkq(-1539486135 ^ -1539371481));
									num3 = 10;
									continue;
								case 2:
									obj = UwB33OZZJ9o6S4AVBOSZ(ie13kBZZqrFVTBJvbt3E(current));
									goto IL_03ea;
								case 6:
									if (vqEt0NZZWiF9nGj4RNUc(((Element)ie13kBZZqrFVTBJvbt3E(current)).Name))
									{
										num3 = 4;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd != 0)
										{
											num3 = 17;
										}
										continue;
									}
									goto case 2;
								case 10:
								case 12:
								case 15:
									Ng9D7CZZHvIqgq0SY9Lg(stringBuilder, nX3pGDZZ3XrGYpFfBvBi(new string[5]
									{
										SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-801808857 ^ -801700501),
										ConvertGuid(MSWouhZZRwB9CB37yo9W(current)),
										SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-865213812 ^ -865101012),
										text,
										(string)xNVkcGZZsx9OlmVwASkq(0x1134D2C0 ^ 0x1136AB6C)
									}));
									num3 = 7;
									continue;
								default:
									goto IL_02a7;
								case 18:
									if (!KSNbXuZZfQ0qlXC2kxdr(text, ""))
									{
										num3 = 8;
										continue;
									}
									goto case 16;
								case 11:
									text = (string)yOUmVcZOrRy3odvCNd9S(xNVkcGZZsx9OlmVwASkq(0x2269BD32 ^ 0x226BFD52));
									num3 = 8;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b == 0)
									{
										num3 = 12;
									}
									continue;
								case 16:
									if (!(current.EndElement is EndEventElement))
									{
										num3 = 5;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 != 0)
										{
											num3 = 9;
										}
										continue;
									}
									goto case 11;
								case 8:
								case 9:
								case 13:
									if (KSNbXuZZfQ0qlXC2kxdr(text, ""))
									{
										num3 = 4;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 != 0)
										{
											num3 = 5;
										}
										continue;
									}
									goto case 10;
								case 4:
									text = (string)yJkoCWZZLxbS7o1JhqEL(current.Name);
									num3 = 18;
									continue;
								case 5:
									if (ie13kBZZqrFVTBJvbt3E(current) == null)
									{
										num3 = 3;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 != 0)
										{
											num3 = 2;
										}
										continue;
									}
									goto case 6;
								case 17:
									obj = OqHCGBZZjMSCGtt6YuNn(ie13kBZZqrFVTBJvbt3E(current));
									goto IL_03ea;
								case 1:
									goto end_IL_0148;
									IL_03ea:
									text = (string)obj;
									num3 = 15;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e != 0)
									{
										num3 = 8;
									}
									continue;
								}
								break;
							}
							continue;
							end_IL_0148:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num4 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					goto case 7;
				case 9:
					enumerator = base.OutputFlows.GetEnumerator();
					num2 = 11;
					continue;
				case 2:
					stringBuilder = new StringBuilder();
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 == 0)
					{
						num2 = 1;
					}
					continue;
				default:
					Ng9D7CZZHvIqgq0SY9Lg(stringBuilder, SR.T((string)xNVkcGZZsx9OlmVwASkq(-1393899982 ^ -1394032696)));
					num = 8;
					break;
				case 7:
					return stringBuilder.ToString();
				case 4:
					if (YEM5SkZZnrtw5Xy0Hv0n(base.OutputFlows) > 0)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 != 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 9;
				case 12:
					Ng9D7CZZHvIqgq0SY9Lg(stringBuilder, string.Format((string)xNVkcGZZsx9OlmVwASkq(-1965291699 ^ -1965130213), yOUmVcZOrRy3odvCNd9S(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105863102 ^ -105721544))));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 == 0)
					{
						num2 = 10;
					}
					continue;
				case 6:
					try
					{
						while (true)
						{
							IL_070b:
							int num5;
							if (!enumerator.MoveNext())
							{
								num5 = 2;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea != 0)
								{
									num5 = 2;
								}
								goto IL_055b;
							}
							goto IL_05d0;
							IL_05d0:
							current2 = enumerator.Current;
							num5 = 18;
							goto IL_055b;
							IL_055b:
							while (true)
							{
								object obj2;
								switch (num5)
								{
								case 16:
									break;
								case 5:
								case 10:
								case 14:
									if (!KSNbXuZZfQ0qlXC2kxdr(text2, ""))
									{
										num5 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c != 0)
										{
											num5 = 1;
										}
										continue;
									}
									goto case 4;
								case 18:
									text2 = (string)yJkoCWZZLxbS7o1JhqEL(UwB33OZZJ9o6S4AVBOSZ(current2));
									num5 = 17;
									continue;
								case 8:
									if (vqEt0NZZWiF9nGj4RNUc(UwB33OZZJ9o6S4AVBOSZ(pWOOvpZZ9W45eEPqbugi(current2))))
									{
										num5 = 11;
										continue;
									}
									goto case 6;
								case 17:
									if (!KSNbXuZZfQ0qlXC2kxdr(text2, ""))
									{
										num5 = 14;
										continue;
									}
									goto case 15;
								case 4:
									if (pWOOvpZZ9W45eEPqbugi(current2) != null)
									{
										int num6 = 8;
										num5 = num6;
										continue;
									}
									goto default;
								case 13:
									text2 = SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x213F6477 ^ 0x213D246D));
									num5 = 3;
									continue;
								case 15:
									if (!(pWOOvpZZ9W45eEPqbugi(current2) is StartEventElement))
									{
										num5 = 5;
										continue;
									}
									goto case 13;
								default:
									text2 = (string)yOUmVcZOrRy3odvCNd9S(xNVkcGZZsx9OlmVwASkq(--1418337216 ^ 0x54885BFA));
									num5 = 12;
									continue;
								case 9:
									goto IL_070b;
								case 1:
								case 3:
								case 7:
								case 12:
									stringBuilder.Append((string)xNVkcGZZsx9OlmVwASkq(0x5DB28AD2 ^ 0x5DB0D19E) + (string)RPR7P2ZZ6Xqk30FuIs0F(MSWouhZZRwB9CB37yo9W(current2)) + (string)xNVkcGZZsx9OlmVwASkq(0x213F6477 ^ 0x213D1DD7) + text2 + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x738ABA6E ^ 0x7388C3C2));
									num5 = 9;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 != 0)
									{
										num5 = 4;
									}
									continue;
								case 6:
									obj2 = current2.StartElement.Name;
									goto IL_080b;
								case 11:
									obj2 = OqHCGBZZjMSCGtt6YuNn(current2.StartElement);
									goto IL_080b;
								case 2:
									goto end_IL_070b;
									IL_080b:
									text2 = (string)obj2;
									num5 = 3;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 != 0)
									{
										num5 = 7;
									}
									continue;
								}
								break;
							}
							goto IL_05d0;
							continue;
							end_IL_070b:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num7 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 == 0)
						{
							num7 = 0;
						}
						switch (num7)
						{
						case 0:
							break;
						}
					}
					goto case 4;
				case 1:
					if (YEM5SkZZnrtw5Xy0Hv0n(base.InputFlows) <= 0)
					{
						num2 = 5;
						continue;
					}
					goto case 12;
				}
				break;
			}
		}
	}

	bool IElementWithExceptionFlows.CanHandleException(Exception exception)
	{
		return dMF4uJZZTYYjRKRciscX(this, exception);
	}

	TimeSpan? IElementWithExceptionFlows.GetQueueExecutionTimeout(IWorkflowInstance instance)
	{
		FlowConnectorElement flowConnectorElement = ExceptionOutputFlows.FirstOrDefault((FlowConnectorElement c) => c.Trigger == EventTrigger.Timer);
		if (flowConnectorElement != null)
		{
			DateTime? dateTime = ((flowConnectorElement.TimerSettings != null) ? flowConnectorElement.TimerSettings.GetNextTimerExpiration(instance) : null);
			if (dateTime.HasValue)
			{
				TimeSpan timeSpan = dateTime.Value - DateTime.Now;
				if (timeSpan > TimeSpan.Zero)
				{
					return timeSpan;
				}
			}
			else
			{
				Logger.Log.ErrorFormat(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-667465279 ^ -667601945), flowConnectorElement.Name, Name, instance.Id);
			}
		}
		return null;
	}

	protected BPMNFlowElement()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	[SpecialName]
	Guid IWorkflowElement.get_Uid()
	{
		return PqXiQbZZp3ySJ3eoQBWL(this);
	}

	internal static object yOUmVcZOrRy3odvCNd9S(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool y2QGJZZOId9so6bOkFCG()
	{
		return Kaj9VKZOigGIbvS0SaY7 == null;
	}

	internal static BPMNFlowElement CLNmINZOaIsqY2wsmQdg()
	{
		return Kaj9VKZOigGIbvS0SaY7;
	}

	internal static Guid jZRPg4ZOekgCph6S7kY1(object P_0)
	{
		return ((BPMNFlowElement)P_0).ParentUid;
	}

	internal static object RvMM3aZONyNwPG8aQBa3(object P_0, Guid P_1)
	{
		return ((ElementList)P_0)[P_1];
	}

	internal static void hQew03ZOxNGjYXsLpNNO(object P_0, object P_1, object P_2)
	{
		((Element)P_0).OnShapeChanged((NShape)P_1, (NShape)P_2);
	}

	internal static void qC8wfRZOSWKTmRSR0m41(object P_0)
	{
		((BPMNFlowElement)P_0).UpdateDecorators();
	}

	internal static object Vmamp6ZO1mEfIx9sQXWc(object P_0)
	{
		return ((Element)P_0).Shape;
	}

	internal static object AAA3O1ZOh78axHbItUeO(object P_0)
	{
		return ((NDiagramElement)P_0).get_Document();
	}

	internal static object vhVhTGZOEBiwRdQ5tlqi(object P_0)
	{
		return ((NDocument)P_0).get_HistoryService();
	}

	internal static void G0LF6pZOwmtPrSRuAnZr(object P_0)
	{
		((NService)P_0).Pause();
	}

	internal static void QnJZ7gZO4TmpgR4VWojH(object P_0, object P_1)
	{
		((IDecoratableShape)P_0).UpdateDecorators((Element)P_1);
	}

	internal static void KAaunvZOzHkSQAdMtuo6(object P_0)
	{
		((NService)P_0).Resume();
	}

	internal static bool syL01TZZKQBpLY7u5cT1(object P_0)
	{
		return ((BPMNFlowElement)P_0).ValidateOutputFlows;
	}

	internal static bool ny7rXCZZOl7BuJH8ZkY0(object P_0)
	{
		return ((BPMNFlowElement)P_0).ExceptionOutputIsStandart;
	}

	internal static int jcLvnJZZZVkpnC7nmH6q(object P_0)
	{
		return ((BPMNFlowElement)P_0).MaxOutputFlowsCount;
	}

	internal static int P16owBZZv2SbD3VH5kUF(object P_0)
	{
		return ((List<FlowConnectorElement>)P_0).Count;
	}

	internal static object gZwLH3ZZYqmEOeoT81KH(object P_0, object P_1)
	{
		return ((ElementValidationHelper)P_0).CreateValidationError((string)P_1);
	}

	internal static int B71fUtZZ88S6tHkMRYqf(object P_0)
	{
		return ((BPMNFlowElement)P_0).MinOutputFlowsCount;
	}

	internal static object xNVkcGZZsx9OlmVwASkq(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object UwB33OZZJ9o6S4AVBOSZ(object P_0)
	{
		return ((Element)P_0).Name;
	}

	internal static object nua97QZZl3wrWQVTWro3(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static object rBBIWtZZ0Hab2qOSun0V(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object tjULZwZZyxYfGUaEZrl2(object P_0)
	{
		return ((IExceptionFlowSupported)P_0).SupportedTriggers;
	}

	internal static object L8PV6uZZmWLvPg4NHxoW(object P_0)
	{
		return ModelHelper.GetEnumDisplayName(P_0);
	}

	internal static bool vMXqS2ZZtf7PhHwBONGb(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static object mu03vJZZbsYkUZM96cte(object P_0)
	{
		return ((WorkflowProcessValidator)P_0).Process;
	}

	internal static object J6HVicZZ5p1aaEGtuLok(object P_0)
	{
		return ((WorkflowProcessDTO)P_0).Diagram;
	}

	internal static object r0ddFkZZgQTyyFHK5SJx(object P_0)
	{
		return ((BPMNFlowElement)P_0).SupportedSwimlaneTypes;
	}

	internal static SwimlaneType xM6JkoZZBdD6ZeqbiF0c(object P_0)
	{
		return ((SwimlaneElement)P_0).SwimlaneType;
	}

	internal static NRectangleF XydLuGZZcvJPGhsBept0(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NModel)P_0).get_Bounds();
	}

	internal static int za8ymkZZPvMWQbpJ6KLO(float P_0)
	{
		return Convert.ToInt32(P_0);
	}

	internal static object HL4HuMZZXN0mESObH5aL(object P_0)
	{
		return Graphics.FromImage((Image)P_0);
	}

	internal static void FZYfP2ZZdqEJAhGQE3UH(object P_0, NPointF P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NCanvas)P_0).set_ViewportOrigin(P_1);
	}

	internal static void DiKiO9ZZuHAMmWmKanjh(object P_0, object P_1)
	{
		((NCanvas)P_0).RenderToGraphics((Graphics)P_1);
	}

	internal static int ChgD3eZZDQ23Zx2iyIOc(object P_0, object P_1)
	{
		return ((string)P_0).IndexOf((string)P_1);
	}

	internal static int YEM5SkZZnrtw5Xy0Hv0n(object P_0)
	{
		return ((List<Connector>)P_0).Count;
	}

	internal static object Ng9D7CZZHvIqgq0SY9Lg(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).Append((string)P_1);
	}

	internal static object yJkoCWZZLxbS7o1JhqEL(object P_0)
	{
		return ((string)P_0).Trim();
	}

	internal static bool KSNbXuZZfQ0qlXC2kxdr(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object pWOOvpZZ9W45eEPqbugi(object P_0)
	{
		return ((Connector)P_0).StartElement;
	}

	internal static bool vqEt0NZZWiF9nGj4RNUc(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object OqHCGBZZjMSCGtt6YuNn(object P_0)
	{
		return ((Element)P_0).DefaultName;
	}

	internal static Guid MSWouhZZRwB9CB37yo9W(object P_0)
	{
		return ((Element)P_0).Uid;
	}

	internal static object RPR7P2ZZ6Xqk30FuIs0F(Guid guid)
	{
		return ConvertGuid(guid);
	}

	internal static object ie13kBZZqrFVTBJvbt3E(object P_0)
	{
		return ((Connector)P_0).EndElement;
	}

	internal static object nX3pGDZZ3XrGYpFfBvBi(object P_0)
	{
		return string.Concat((string[])P_0);
	}

	internal static bool dMF4uJZZTYYjRKRciscX(object P_0, object P_1)
	{
		return ((BPMNFlowElement)P_0).CanHandleExceptionByEscalation((Exception)P_1);
	}

	internal static bool rgennnZZQAm39eVsgevg(object P_0)
	{
		return ((BPMNFlowElement)P_0).QueueExecutionTimeoutSupported;
	}

	internal static Guid PqXiQbZZp3ySJ3eoQBWL(object P_0)
	{
		return ((Element)P_0).Uid;
	}
}
