using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Scripts.DTO.Models;
using EleWise.ELMA.Workflow.BPMN.Diagrams;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Connectors;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Gateways;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Swimlanes;
using EleWise.ELMA.Workflow.BPMN.DTO.Models;
using EleWise.ELMA.Workflow.Diagrams.Elements;
using EleWise.ELMA.Workflow.Diagrams.Elements.Gateways;
using EleWise.ELMA.Workflow.DTO.Models;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Validation;
using ICSharpCode.NRefactory.CSharp;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Validation;

public class BPMNProcessValidator : WorkflowProcessValidator
{
	public class ExecutionGate
	{
		internal static ExecutionGate c59sVsvJzOsl3j3R2ns3;

		public Guid GatewayId
		{
			[CompilerGenerated]
			get
			{
				return _003CGatewayId_003Ek__BackingField;
			}
			[CompilerGenerated]
			private set
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
						_003CGatewayId_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public int GateNum
		{
			[CompilerGenerated]
			get
			{
				return _003CGateNum_003Ek__BackingField;
			}
			[CompilerGenerated]
			private set
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
						_003CGateNum_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public ExecutionGate(Guid GatewayId, int GateNum)
		{
			//Discarded unreachable code: IL_001e
			lKJdKavlZNYec41wfugk();
			base._002Ector();
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					return;
				default:
					this.GateNum = GateNum;
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					this.GatewayId = GatewayId;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		public override bool Equals(object obj)
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (obj is ExecutionGate)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				case 1:
					if (((ExecutionGate)obj).GatewayId == GatewayId)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					return ((ExecutionGate)obj).GateNum == GateNum;
				}
				break;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return 397 * GatewayId.GetHashCode() + GateNum.GetHashCode();
		}

		internal static bool XJXwnCvlKipEKUKrcdMs()
		{
			return c59sVsvJzOsl3j3R2ns3 == null;
		}

		internal static ExecutionGate zebsaivlOhcvr6wMKUcM()
		{
			return c59sVsvJzOsl3j3R2ns3;
		}

		internal static void lKJdKavlZNYec41wfugk()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	private Dictionary<string, string> metods;

	private Dictionary<Element, ExecutionGate> activityGates;

	private List<GatewayElement> unresolvedGateways;

	private Dictionary<GatewayElement, List<ExecutionGate>> gatewaysExecutionGates;

	private List<Element> validatedElements;

	private Dictionary<Guid, Guid> errorEndElement;

	private static BPMNProcessValidator WXWfw1OAj1SCp8n05CWu;

	public new BPMNProcessDTO Process => (BPMNProcessDTO)base.Process;

	public Dictionary<Element, ExecutionGate> ActivityGates => activityGates;

	protected BPMNDiagram Diagram => (BPMNDiagram)BujSMZOA3ENHolFtZ0WN(base.Process);

	public BPMNProcessValidator(BPMNProcessDTO process)
	{
		//Discarded unreachable code: IL_006b, IL_0070
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		activityGates = new Dictionary<Element, ExecutionGate>();
		unresolvedGateways = new List<GatewayElement>();
		gatewaysExecutionGates = new Dictionary<GatewayElement, List<ExecutionGate>>();
		validatedElements = new List<Element>();
		base._002Ector(process);
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			Contract.ArgumentNotNull(process, (string)Ux9GqBOAqjDqX7ILRgNd(-63028171 ^ -63024057));
			num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 != 0)
			{
				num = 1;
			}
		}
	}

	protected override void ValidateAll()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				base.ValidateAll();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				TGI9BCOATmLABGaLSQqa(this);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	protected override void ValidateDiagram()
	{
		//Discarded unreachable code: IL_01a9, IL_023a, IL_0249, IL_0373, IL_0382, IL_0541, IL_057a, IL_0589, IL_05e0, IL_06cc, IL_0704, IL_0713, IL_0722, IL_082d, IL_0867, IL_0877, IL_0886, IL_0891, IL_0969, IL_097c
		int num = 6;
		Element element = default(Element);
		List<Element> list = default(List<Element>);
		List<GatewayElement>.Enumerator enumerator = default(List<GatewayElement>.Enumerator);
		IEnumerator<Element> enumerator2 = default(IEnumerator<Element>);
		FlowConnectorElement flowConnectorElement = default(FlowConnectorElement);
		string methods = default(string);
		GatewayElement current = default(GatewayElement);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					if (Diagram != null)
					{
						num2 = 13;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
						{
							num2 = 15;
						}
						break;
					}
					return;
				case 21:
					CWfDTvOAQtliK8YO5Ued(unresolvedGateways);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a == 0)
					{
						num2 = 0;
					}
					break;
				case 12:
					CheckDiagramElement(element, new ExecutionGate(Guid.Empty, 0));
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 == 0)
					{
						num2 = 23;
					}
					break;
				case 8:
					return;
				case 15:
					activityGates.Clear();
					num2 = 21;
					break;
				default:
					GPLWPyOApj0CNCCmhH3K(gatewaysExecutionGates);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					KjBgaaOACgWWRFIGqAxP(validatedElements);
					num2 = 15;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 != 0)
					{
						num2 = 17;
					}
					break;
				case 7:
					return;
				case 4:
					if (NjLiwIOAVvIQMGoYIPxT(list) > 1)
					{
						num2 = 22;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d != 0)
						{
							num2 = 8;
						}
					}
					else
					{
						element = list[0];
						num2 = 11;
					}
					break;
				case 9:
					enumerator = unresolvedGateways.GetEnumerator();
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 == 0)
					{
						num2 = 13;
					}
					break;
				case 2:
					try
					{
						while (true)
						{
							IL_0690:
							int num5;
							if (!a9JbG8OA4DQ7MVPd1Oyk(enumerator2))
							{
								num5 = 18;
								goto IL_01b7;
							}
							goto IL_03f9;
							IL_01b7:
							while (true)
							{
								int num6;
								switch (num5)
								{
								case 24:
									ValidateTemplate(flowConnectorElement, flowConnectorElement.Description, (string)G7rtw9OArqjN4xCpbBtK(Ux9GqBOAqjDqX7ILRgNd(-43932417 ^ -43779279), new object[1] { Hm53iGOASnQvqnvysbfd(flowConnectorElement) }));
									num5 = 27;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b == 0)
									{
										num5 = 23;
									}
									continue;
								case 5:
								{
									ICollection<ProcessValidationMessage> collection4 = base.Messages;
									ProcessValidationMessage processValidationMessage4 = new ProcessValidationMessage();
									LQsGILOAUMbJ9T9476Lk(processValidationMessage4, G7rtw9OArqjN4xCpbBtK(Ux9GqBOAqjDqX7ILRgNd(0x12F686A ^ 0x12D35E4), new object[1] { pj79wJOAacQPUOm6eKTT(eB5dEvOA7RiGvtf421yL(flowConnectorElement)) }));
									voNUR4OAkY2skHGSxkW8(processValidationMessage4, ProcessValidationMessageType.Error);
									processValidationMessage4.Object = flowConnectorElement;
									collection4.Add(processValidationMessage4);
									num6 = 15;
									goto IL_01b3;
								}
								case 12:
									ValidateTemplate(flowConnectorElement, (string)CBr9eGOAwJlwVpDk92EB(flowConnectorElement), (string)G7rtw9OArqjN4xCpbBtK(Ux9GqBOAqjDqX7ILRgNd(-2077784392 ^ -2077890840), new object[1] { flowConnectorElement.Name }));
									num5 = 11;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 != 0)
									{
										num5 = 4;
									}
									continue;
								case 1:
									if (methods == null)
									{
										num6 = 5;
										goto IL_01b3;
									}
									goto case 13;
								case 26:
									if (!B7IfwROA1P7QKXc11hVl(flowConnectorElement))
									{
										num6 = 16;
										goto IL_01b3;
									}
									goto case 24;
								case 9:
									if (flowConnectorElement.StartElement is InclusiveGatewayElement)
									{
										num5 = 28;
										continue;
									}
									goto case 2;
								case 28:
									if (p6prVyOAF6WoQKDrJ8OK(((Element)viZDgfOAoybn5GoP7sJ6(flowConnectorElement)).OutputConnectors) < 2)
									{
										num5 = 3;
										continue;
									}
									goto case 8;
								case 16:
								case 27:
									if (wEZFYcOAhhnQaOse5cxF(flowConnectorElement))
									{
										num5 = 20;
										continue;
									}
									goto IL_0690;
								case 17:
									break;
								case 8:
									methods = GetMethods((string)kZUqB9OAIhCAILktCuEh(N6FitVOAiRdbp5XJTpYZ(Process)), (string)pj79wJOAacQPUOm6eKTT(eB5dEvOA7RiGvtf421yL(flowConnectorElement)));
									num5 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f != 0)
									{
										num5 = 0;
									}
									continue;
								case 22:
								{
									ICollection<ProcessValidationMessage> collection5 = base.Messages;
									ProcessValidationMessage processValidationMessage4 = new ProcessValidationMessage();
									LQsGILOAUMbJ9T9476Lk(processValidationMessage4, SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2ACCDD87 ^ 0x2ACE83F1), ((Condition)eB5dEvOA7RiGvtf421yL(flowConnectorElement)).ScriptName));
									voNUR4OAkY2skHGSxkW8(processValidationMessage4, ProcessValidationMessageType.Error);
									processValidationMessage4.Object = flowConnectorElement;
									collection5.Add(processValidationMessage4);
									num5 = 2;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea == 0)
									{
										num5 = 1;
									}
									continue;
								}
								case 23:
									if (!(viZDgfOAoybn5GoP7sJ6(flowConnectorElement) is ExclusiveGatewayElement))
									{
										num5 = 9;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af == 0)
										{
											num5 = 9;
										}
										continue;
									}
									goto case 28;
								case 7:
									if (flowConnectorElement.Condition != null)
									{
										num5 = 2;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 != 0)
										{
											num5 = 25;
										}
										continue;
									}
									goto case 2;
								case 20:
									if (!KmcWb1OAE0Z4ixWktcDI(flowConnectorElement))
									{
										num5 = 21;
										continue;
									}
									goto case 12;
								case 13:
									if (!htLP75OAenfsOU450R3k(methods, Ux9GqBOAqjDqX7ILRgNd(0x4FD00585 ^ 0x4FD03AA1)))
									{
										num5 = 4;
										continue;
									}
									goto IL_0690;
								case 2:
								case 3:
								case 15:
									if (FtJamnOAN9QQ3e4vEqXF(flowConnectorElement))
									{
										num5 = 6;
										continue;
									}
									goto case 26;
								default:
									if (flowConnectorElement != null)
									{
										num5 = 7;
										continue;
									}
									goto IL_0690;
								case 25:
									if (zS2WsSOA24Rgyd7Dq9qA(eB5dEvOA7RiGvtf421yL(flowConnectorElement)) == ConditionType.Script)
									{
										num6 = 23;
										goto IL_01b3;
									}
									goto case 2;
								case 10:
									if (methods == (string)Ux9GqBOAqjDqX7ILRgNd(0x56F860D7 ^ 0x56FA3E81))
									{
										num5 = 16;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 != 0)
										{
											num5 = 19;
										}
										continue;
									}
									goto case 22;
								case 6:
									ValidateTemplate(flowConnectorElement, (string)wHPGfJOAxIGYi5BMOhAe(flowConnectorElement), SR.T((string)Ux9GqBOAqjDqX7ILRgNd(-1050383744 ^ -1050266158), Hm53iGOASnQvqnvysbfd(flowConnectorElement)));
									num5 = 26;
									continue;
								case 4:
									if (htLP75OAenfsOU450R3k(methods, Ux9GqBOAqjDqX7ILRgNd(-135674354 ^ -135554998)))
									{
										num5 = 14;
										continue;
									}
									goto case 10;
								case 11:
								case 14:
								case 19:
								case 21:
									goto IL_0690;
								case 18:
									return;
									IL_01b3:
									num5 = num6;
									continue;
								}
								break;
							}
							goto IL_03f9;
							IL_03f9:
							flowConnectorElement = enumerator2.Current as FlowConnectorElement;
							num5 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 != 0)
							{
								num5 = 0;
							}
							goto IL_01b7;
						}
					}
					finally
					{
						if (enumerator2 != null)
						{
							int num7 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 == 0)
							{
								num7 = 0;
							}
							while (true)
							{
								switch (num7)
								{
								case 1:
									GLGtStOAz0kXZyb35GUm(enumerator2);
									num7 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b == 0)
									{
										num7 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
					}
				case 16:
					return;
				case 11:
					((IEnumerable)ODEDglOAMj9AfOAQ9PEN(Diagram)).OfType<SwimlaneElement>().ForEach(delegate(SwimlaneElement s)
					{
						int num8 = 1;
						int num9 = num8;
						while (true)
						{
							switch (num9)
							{
							default:
								return;
							case 0:
								return;
							case 1:
								QkNe9UOGybNDHBmT3MtA(this, s);
								num9 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 != 0)
								{
									num9 = 0;
								}
								break;
							}
						}
					});
					num2 = 12;
					break;
				case 19:
				{
					ICollection<ProcessValidationMessage> collection3 = base.Messages;
					ProcessValidationMessage processValidationMessage3 = new ProcessValidationMessage();
					voNUR4OAkY2skHGSxkW8(processValidationMessage3, ProcessValidationMessageType.Error);
					LQsGILOAUMbJ9T9476Lk(processValidationMessage3, SR.T((string)Ux9GqBOAqjDqX7ILRgNd(0x614274E3 ^ 0x614369CB)));
					collection3.Add(processValidationMessage3);
					num2 = 7;
					break;
				}
				case 23:
					if (unresolvedGateways.Count <= 0)
					{
						goto end_IL_0012;
					}
					goto case 9;
				case 22:
				{
					ICollection<ProcessValidationMessage> collection2 = base.Messages;
					ProcessValidationMessage processValidationMessage2 = new ProcessValidationMessage();
					voNUR4OAkY2skHGSxkW8(processValidationMessage2, ProcessValidationMessageType.Error);
					LQsGILOAUMbJ9T9476Lk(processValidationMessage2, VJ332AOAA6xx1H2KbeN4(Ux9GqBOAqjDqX7ILRgNd(0x42311138 ^ 0x42334C3C)));
					processValidationMessage2.Object = list[0];
					collection2.Add(processValidationMessage2);
					num2 = 16;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 == 0)
					{
						num2 = 15;
					}
					break;
				}
				case 14:
					if (list.Count != 0)
					{
						num2 = 4;
						break;
					}
					goto case 19;
				case 18:
					return;
				case 6:
					base.ValidateDiagram();
					num2 = 5;
					break;
				case 13:
					try
					{
						while (true)
						{
							IL_08af:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 == 0)
								{
									num3 = 0;
								}
								goto IL_0895;
							}
							goto IL_091a;
							IL_091a:
							current = enumerator.Current;
							num3 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c == 0)
							{
								num3 = 0;
							}
							goto IL_0895;
							IL_0895:
							while (true)
							{
								switch (num3)
								{
								case 2:
									goto IL_08af;
								case 1:
								{
									ICollection<ProcessValidationMessage> collection = base.Messages;
									ProcessValidationMessage processValidationMessage = new ProcessValidationMessage();
									LQsGILOAUMbJ9T9476Lk(processValidationMessage, Ux9GqBOAqjDqX7ILRgNd(-1303601216 ^ -1303461226));
									processValidationMessage.Type = ProcessValidationMessageType.Error;
									OKkA6EOAGLdOUGLPa1hS(processValidationMessage, current);
									collection.Add(processValidationMessage);
									num3 = 2;
									continue;
								}
								case 3:
									goto IL_091a;
								case 0:
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
						int num4 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					goto case 3;
				case 17:
					errorEndElement = new Dictionary<Guid, Guid>();
					num2 = 10;
					break;
				case 3:
				case 20:
					enumerator2 = Diagram.Elements.GetEnumerator();
					num2 = 2;
					break;
				case 10:
					list = ((IEnumerable<Element>)ODEDglOAMj9AfOAQ9PEN(Diagram)).Where((Element e) => e is StartEventElement).ToList();
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d == 0)
					{
						num2 = 14;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	private string GetMethods(string sourceCode, string methodName)
	{
		//Discarded unreachable code: IL_0076, IL_0085, IL_0090, IL_00bf, IL_00ce, IL_0203, IL_0216, IL_0225, IL_02cd, IL_02dc, IL_02ee, IL_039d, IL_03a7, IL_0467, IL_047a, IL_0489, IL_04a9
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected O, but got Unknown
		int num = 2;
		List<EntityDeclaration>.Enumerator enumerator = default(List<EntityDeclaration>.Enumerator);
		EntityDeclaration current2 = default(EntityDeclaration);
		string text2 = default(string);
		string text = default(string);
		SyntaxTree val = default(SyntaxTree);
		TypeDeclaration val3 = default(TypeDeclaration);
		string value = default(string);
		List<EntityDeclaration> list = default(List<EntityDeclaration>);
		string key = default(string);
		EntityDeclaration current = default(EntityDeclaration);
		AstNode val2 = default(AstNode);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 4:
					try
					{
						while (true)
						{
							IL_015d:
							int num5;
							if (!enumerator.MoveNext())
							{
								num5 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 == 0)
								{
									num5 = 1;
								}
								goto IL_0094;
							}
							goto IL_013a;
							IL_013a:
							current2 = enumerator.Current;
							num5 = 4;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 == 0)
							{
								num5 = 2;
							}
							goto IL_0094;
							IL_0094:
							while (true)
							{
								switch (num5)
								{
								case 6:
									break;
								case 2:
									if (!iPxYYlOGs31vlOWL0W14(I3Lgw3OG89m5GO2vQF2p(Ux9GqBOAqjDqX7ILRgNd(0x51EF0063 ^ 0x51ED6093), Dookd1OGYqoAXI08jlMn(current2), text2), text))
									{
										num5 = 3;
										continue;
									}
									goto IL_015d;
								case 3:
									metods.Add(current2.get_NameToken().get_Name(), J1mDZOOGJ9sf4qe9yCoI(current2).ToString());
									num5 = 6;
									continue;
								case 5:
									goto IL_013a;
								default:
									goto IL_015d;
								case 4:
									text2 = string.Join((string)Ux9GqBOAqjDqX7ILRgNd(0xD305CC2 ^ 0xD301448), ((IEnumerable<ParameterDeclaration>)((MethodDeclaration)current2).get_Parameters()).Select(delegate(ParameterDeclaration q)
									{
										int num9 = 2;
										int num10 = num9;
										string text3 = default(string);
										while (true)
										{
											switch (num10)
											{
											case 3:
												return (string)_003C_003Ec.ITacSOvl5EWCIPjHXkxO(_003C_003Ec.D1be7VvlyAVQeT154auS(-11799394 ^ -11981576), text3, q.get_Name());
											case 1:
												if (_003C_003Ec.J2E0W1vlm4Sj73jTYpgb(text3, _003C_003Ec.D1be7VvlyAVQeT154auS(0x614274E3 ^ 0x61423C19)))
												{
													num10 = 0;
													if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b != 0)
													{
														num10 = 0;
													}
													break;
												}
												goto case 3;
											case 2:
												text3 = _003C_003Ec.Ikc0cFvl0e3vSYVYFwsj(q).ToString();
												num10 = 1;
												if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 == 0)
												{
													num10 = 1;
												}
												break;
											default:
												text3 = (string)_003C_003Ec.zVuEkVvlbtjx7xrKcOlO(text3, _003C_003Ec.lGBYbDvltLLEsserC852(text3, '.') + 1);
												num10 = 3;
												break;
											}
										}
									}));
									num5 = 2;
									continue;
								case 1:
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
						int num6 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d != 0)
						{
							num6 = 0;
						}
						switch (num6)
						{
						case 0:
							break;
						}
					}
					goto case 11;
				case 5:
					if (val != null)
					{
						num2 = 13;
						continue;
					}
					goto case 11;
				case 19:
					val = (SyntaxTree)NRwC1NOGv9sdDaLcUwfx((object)new CSharpParser(), sourceCode, "");
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b == 0)
					{
						num2 = 0;
					}
					continue;
				case 20:
					if (val3 == null)
					{
						num2 = 12;
						continue;
					}
					break;
				case 10:
					return value;
				case 15:
					return null;
				case 18:
					enumerator = list.GetEnumerator();
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d == 0)
					{
						num2 = 4;
					}
					continue;
				case 11:
				case 12:
				case 16:
					if (!metods.TryGetValue(key, out value))
					{
						goto end_IL_0012;
					}
					goto case 10;
				case 9:
					obj = text;
					goto IL_050c;
				case 1:
					if (!DIGiKiOGOhevdlZtJBQx(text, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1574607501 ^ -1574500967)))
					{
						num2 = 9;
						continue;
					}
					obj = fPeNXgOGZWKa7niHWr8g(text, 0, text.IndexOf('('));
					goto IL_050c;
				case 3:
					if (DIGiKiOGOhevdlZtJBQx(text, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x63D6C913 ^ 0x63D4A9F9)))
					{
						num2 = 7;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 == 0)
						{
							num2 = 18;
						}
						continue;
					}
					goto case 7;
				case 2:
					text = ((IEnumerable<string>)uWoIS1OGKT4XtyGIbIoC(methodName, new string[1] { (string)Ux9GqBOAqjDqX7ILRgNd(-351369538 ^ -351296038) }, StringSplitOptions.None)).Last();
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					try
					{
						while (true)
						{
							IL_03c5:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 == 0)
								{
									num3 = 0;
								}
								goto IL_03ab;
							}
							goto IL_03eb;
							IL_03eb:
							current = enumerator.Current;
							num3 = 2;
							goto IL_03ab;
							IL_03ab:
							while (true)
							{
								switch (num3)
								{
								case 1:
									goto IL_03c5;
								case 3:
									goto IL_03eb;
								case 2:
									metods.AddIfNotContainsKey((string)nUWmaSOG0DI4PvO4tiV3(CXr140OGlfyaJQtSJQxb(current)), J1mDZOOGJ9sf4qe9yCoI(current).ToString());
									num3 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f != 0)
									{
										num3 = 1;
									}
									continue;
								case 0:
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
						int num4 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 != 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					goto case 11;
				case 8:
					if (val2 == null)
					{
						num2 = 16;
						continue;
					}
					goto case 14;
				case 7:
					enumerator = list.GetEnumerator();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be == 0)
					{
						num2 = 0;
					}
					continue;
				case 17:
					metods = new Dictionary<string, string>();
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a != 0)
					{
						num2 = 19;
					}
					continue;
				case 13:
					val2 = val.get_Members().FirstOrNullObject((Func<AstNode, bool>)((AstNode a) => a is NamespaceDeclaration));
					num2 = 8;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 == 0)
					{
						num2 = 1;
					}
					continue;
				case 14:
				{
					AstNode obj2 = val2.get_Children().FirstOrDefault((AstNode a) => (int)_003C_003Ec.kq9fdgvlJd3qCwVCIpc0(a) == 2);
					val3 = (TypeDeclaration)(object)((obj2 is TypeDeclaration) ? obj2 : null);
					num2 = 20;
					continue;
				}
				case 6:
					break;
					IL_050c:
					key = (string)obj;
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 != 0)
					{
						num2 = 17;
					}
					continue;
				}
				list = ((IEnumerable<EntityDeclaration>)val3.get_Members()).Where(delegate(EntityDeclaration a)
				{
					//IL_0025: Unknown result type (might be due to invalid IL or missing references)
					//IL_002b: Invalid comparison between Unknown and I4
					//IL_004b: Unknown result type (might be due to invalid IL or missing references)
					//IL_0051: Unknown result type (might be due to invalid IL or missing references)
					//IL_0053: Invalid comparison between Unknown and I4
					int num7 = 1;
					int num8 = num7;
					while (true)
					{
						switch (num8)
						{
						case 1:
							if ((int)_003C_003Ec.h2MH9Yvll6gaMGw4S8Jy(a) != 6)
							{
								return false;
							}
							num8 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea != 0)
							{
								num8 = 0;
							}
							break;
						default:
							return (a.get_Modifiers() & 8) == 8;
						}
					}
				}).ToList();
				num2 = 3;
				continue;
				end_IL_0012:
				break;
			}
			num = 15;
		}
	}

	protected virtual bool CheckDiagramElement(Element element, ExecutionGate gate)
	{
		//Discarded unreachable code: IL_0196, IL_01c9, IL_01d8, IL_0367, IL_0371, IL_0380, IL_0390, IL_03a0, IL_04c7, IL_04da, IL_04e9, IL_054a, IL_055d, IL_056c
		int num = 29;
		FlowElement flowElement = default(FlowElement);
		bool flag2 = default(bool);
		List<Connector>.Enumerator enumerator = default(List<Connector>.Enumerator);
		bool flag = default(bool);
		Connector current = default(Connector);
		Element element2 = default(Element);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				Guid value;
				int num3;
				switch (num2)
				{
				case 8:
					return true;
				default:
					if (!activityGates.ContainsKey(element))
					{
						num2 = 21;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 == 0)
						{
							num2 = 12;
						}
						continue;
					}
					goto case 13;
				case 20:
				{
					ICollection<ProcessValidationMessage> collection5 = base.Messages;
					ProcessValidationMessage processValidationMessage2 = new ProcessValidationMessage();
					LQsGILOAUMbJ9T9476Lk(processValidationMessage2, G7rtw9OArqjN4xCpbBtK(Ux9GqBOAqjDqX7ILRgNd(-539998957 ^ -539875547), new object[1] { Hm53iGOASnQvqnvysbfd(element) }));
					processValidationMessage2.Type = ProcessValidationMessageType.Error;
					OKkA6EOAGLdOUGLPa1hS(processValidationMessage2, element);
					collection5.Add(processValidationMessage2);
					num2 = 5;
					continue;
				}
				case 3:
					value = Guid.Empty;
					num2 = 16;
					continue;
				case 11:
					errorEndElement.Add(element.Uid, lyrBJIOGb8W94P07WBbK(element));
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 == 0)
					{
						num2 = 8;
					}
					continue;
				case 17:
					if (element == null)
					{
						num2 = 25;
						continue;
					}
					flowElement = element as FlowElement;
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 != 0)
					{
						num2 = 7;
					}
					continue;
				case 9:
				{
					List<Connector> outputFlows = flowElement.OutputFlows;
					flag2 = false;
					enumerator = outputFlows.GetEnumerator();
					num2 = 23;
					continue;
				}
				case 30:
					return true;
				case 6:
					if (H1UfSkOGtLbKE0lQpZr0(elm8jqOGmt5yx3everDj(gate), Guid.Empty))
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 == 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto default;
				case 16:
					if (!errorEndElement.TryGetValue(lyrBJIOGb8W94P07WBbK(element), out value))
					{
						num2 = 2;
						continue;
					}
					goto case 22;
				case 29:
					if (element is InclusiveGatewayElement)
					{
						num2 = 28;
						continue;
					}
					goto case 27;
				case 12:
					if (gate != null)
					{
						num2 = 6;
						continue;
					}
					goto default;
				case 7:
					if (flowElement == null)
					{
						num2 = 4;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 != 0)
						{
							num2 = 4;
						}
						continue;
					}
					if (!flag)
					{
						num2 = 18;
						continue;
					}
					goto end_IL_0012;
				case 22:
					return true;
				case 2:
				{
					ICollection<ProcessValidationMessage> collection4 = base.Messages;
					ProcessValidationMessage processValidationMessage2 = new ProcessValidationMessage();
					LQsGILOAUMbJ9T9476Lk(processValidationMessage2, G7rtw9OArqjN4xCpbBtK(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x213F6477 ^ 0x213D05D1), new object[1] { element.Name }));
					processValidationMessage2.Type = ProcessValidationMessageType.Error;
					processValidationMessage2.Object = element;
					collection4.Add(processValidationMessage2);
					num2 = 11;
					continue;
				}
				case 4:
				{
					ICollection<ProcessValidationMessage> collection3 = base.Messages;
					ProcessValidationMessage processValidationMessage2 = new ProcessValidationMessage();
					LQsGILOAUMbJ9T9476Lk(processValidationMessage2, SR.T((string)Ux9GqBOAqjDqX7ILRgNd(-1001967776 ^ -1002090930), Hm53iGOASnQvqnvysbfd(element)));
					voNUR4OAkY2skHGSxkW8(processValidationMessage2, ProcessValidationMessageType.Error);
					processValidationMessage2.Object = element;
					collection3.Add(processValidationMessage2);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e != 0)
					{
						num2 = 1;
					}
					continue;
				}
				case 5:
					return true;
				case 21:
					activityGates.Add(element, gate);
					num2 = 9;
					continue;
				case 27:
					num3 = ((element is ParallelGatewayElement) ? 1 : 0);
					break;
				case 23:
					try
					{
						while (true)
						{
							IL_0401:
							int num4;
							if (!enumerator.MoveNext())
							{
								num4 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 != 0)
								{
									num4 = 0;
								}
								goto IL_03ae;
							}
							goto IL_04f4;
							IL_04f4:
							current = enumerator.Current;
							num4 = 9;
							goto IL_03ae;
							IL_03ae:
							while (true)
							{
								switch (num4)
								{
								case 5:
									flag2 = true;
									num4 = 2;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 != 0)
									{
										num4 = 0;
									}
									continue;
								case 2:
								case 6:
									goto IL_0401;
								case 3:
								{
									ICollection<ProcessValidationMessage> collection2 = base.Messages;
									ProcessValidationMessage processValidationMessage2 = new ProcessValidationMessage();
									LQsGILOAUMbJ9T9476Lk(processValidationMessage2, G7rtw9OArqjN4xCpbBtK(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x595C500A ^ 0x595E329C), new object[1] { Hm53iGOASnQvqnvysbfd(current) }));
									voNUR4OAkY2skHGSxkW8(processValidationMessage2, ProcessValidationMessageType.Error);
									OKkA6EOAGLdOUGLPa1hS(processValidationMessage2, current);
									collection2.Add(processValidationMessage2);
									num4 = 5;
									continue;
								}
								case 8:
									if (PwrT3nOG5CYrUQoHkwZg(current) != null)
									{
										num4 = 7;
										continue;
									}
									goto case 3;
								case 1:
								case 7:
									flag2 |= PuNLDcOGgXnCvg0GovkO(this, element2, gate);
									num4 = 6;
									continue;
								case 9:
									QkNe9UOGybNDHBmT3MtA(this, current);
									num4 = 10;
									continue;
								case 4:
									goto IL_04f4;
								case 10:
								{
									element2 = (Element)PwrT3nOG5CYrUQoHkwZg(current);
									int num5 = 8;
									num4 = num5;
									continue;
								}
								case 0:
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
						int num6 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 != 0)
						{
							num6 = 0;
						}
						switch (num6)
						{
						case 0:
							break;
						}
					}
					goto case 19;
				case 14:
					if (!flag)
					{
						num2 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 == 0)
						{
							num2 = 10;
						}
						continue;
					}
					goto case 17;
				case 25:
				{
					ICollection<ProcessValidationMessage> collection = base.Messages;
					ProcessValidationMessage processValidationMessage = new ProcessValidationMessage();
					LQsGILOAUMbJ9T9476Lk(processValidationMessage, SR.T((string)Ux9GqBOAqjDqX7ILRgNd(0x37F755F5 ^ 0x37F534F1)));
					voNUR4OAkY2skHGSxkW8(processValidationMessage, ProcessValidationMessageType.Error);
					collection.Add(processValidationMessage);
					num2 = 30;
					continue;
				}
				case 24:
					return true;
				case 18:
					if (!(element is EndEventElement))
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 12;
				case 26:
					goto end_IL_0012;
				case 13:
					if (activityGates[element].Equals(gate))
					{
						return false;
					}
					num2 = 20;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b == 0)
					{
						num2 = 4;
					}
					continue;
				case 10:
					QkNe9UOGybNDHBmT3MtA(this, element);
					num2 = 11;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 == 0)
					{
						num2 = 17;
					}
					continue;
				case 19:
					_ = element is EndEventElement;
					num2 = 8;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 != 0)
					{
						num2 = 15;
					}
					continue;
				case 1:
					return true;
				case 15:
					return true;
				case 28:
					num3 = 1;
					break;
				}
				flag = (byte)num3 != 0;
				num2 = 14;
				continue;
				end_IL_0012:
				break;
			}
			CheckGateway((GatewayElement)element, gate);
			num = 24;
		}
	}

	protected void CheckGateway(GatewayElement element, ExecutionGate gate)
	{
		//Discarded unreachable code: IL_02bc, IL_02cb, IL_044e, IL_0461, IL_0470, IL_061f, IL_062e, IL_07c5, IL_0864, IL_086e, IL_0985, IL_0998, IL_0a43, IL_0a52, IL_0b0b, IL_0b1a, IL_0b29, IL_0b8a
		int num = 19;
		List<ExecutionGate> list = default(List<ExecutionGate>);
		Element element2 = default(Element);
		ExecutionGate executionGate = default(ExecutionGate);
		GatewayElement gatewayElement = default(GatewayElement);
		_003C_003Ec__DisplayClass13_0 _003C_003Ec__DisplayClass13_ = default(_003C_003Ec__DisplayClass13_0);
		int num4 = default(int);
		List<Connector>.Enumerator enumerator2 = default(List<Connector>.Enumerator);
		List<ExecutionGate>.Enumerator enumerator = default(List<ExecutionGate>.Enumerator);
		ExecutionGate current2 = default(ExecutionGate);
		List<ExecutionGate> list2 = default(List<ExecutionGate>);
		bool flag = default(bool);
		Element element3 = default(Element);
		ExecutionGate executionGate2 = default(ExecutionGate);
		Connector current = default(Connector);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 54:
					gatewaysExecutionGates.Add(element, list);
					num2 = 10;
					continue;
				case 18:
				case 29:
					list = gatewaysExecutionGates[element];
					num2 = 23;
					continue;
				case 47:
					CheckDiagramElement(element2, executionGate);
					num2 = 55;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 != 0)
					{
						num2 = 12;
					}
					continue;
				case 20:
				{
					ICollection<ProcessValidationMessage> collection = base.Messages;
					ProcessValidationMessage processValidationMessage = new ProcessValidationMessage();
					LQsGILOAUMbJ9T9476Lk(processValidationMessage, G7rtw9OArqjN4xCpbBtK(Ux9GqBOAqjDqX7ILRgNd(-2111219045 ^ -2111096483), new object[1] { gatewayElement.Name }));
					voNUR4OAkY2skHGSxkW8(processValidationMessage, ProcessValidationMessageType.Error);
					processValidationMessage.Object = gatewayElement;
					collection.Add(processValidationMessage);
					num2 = 45;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b != 0)
					{
						num2 = 6;
					}
					continue;
				}
				case 49:
					_003C_003Ec__DisplayClass13_.startGate = list[0];
					num2 = 16;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 == 0)
					{
						num2 = 28;
					}
					continue;
				case 50:
					unresolvedGateways.Remove(gatewayElement);
					num2 = 5;
					continue;
				case 19:
					if (gatewaysExecutionGates.ContainsKey(element))
					{
						num2 = 18;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f != 0)
						{
							num2 = 12;
						}
						continue;
					}
					goto case 13;
				case 17:
					qrRAYJOGcbkcAOgVGUUu(element, gatewayElement.Uid);
					num2 = 35;
					continue;
				case 33:
					element.GatewayStartType = GatewayStartType.End;
					num2 = 17;
					continue;
				case 42:
					if (!activityGates[element].Equals(gate))
					{
						num2 = 32;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b == 0)
						{
							num2 = 26;
						}
						continue;
					}
					goto case 21;
				case 35:
					qrRAYJOGcbkcAOgVGUUu(gatewayElement, element.Uid);
					num2 = 7;
					continue;
				case 4:
				{
					List<Connector> outputFlows = element.OutputFlows;
					num4 = 0;
					enumerator2 = outputFlows.GetEnumerator();
					num2 = 30;
					continue;
				}
				case 43:
					try
					{
						while (true)
						{
							int num6;
							if (!enumerator.MoveNext())
							{
								num6 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b == 0)
								{
									num6 = 0;
								}
								goto IL_02da;
							}
							goto IL_03b1;
							IL_03b1:
							current2 = enumerator.Current;
							num6 = 3;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c != 0)
							{
								num6 = 1;
							}
							goto IL_02da;
							IL_02da:
							while (true)
							{
								int num7;
								switch (num6)
								{
								default:
									if (list2.Contains(current2))
									{
										break;
									}
									num7 = 4;
									goto IL_02d6;
								case 6:
								{
									ICollection<ProcessValidationMessage> collection5 = base.Messages;
									ProcessValidationMessage processValidationMessage = new ProcessValidationMessage();
									LQsGILOAUMbJ9T9476Lk(processValidationMessage, G7rtw9OArqjN4xCpbBtK(Ux9GqBOAqjDqX7ILRgNd(-17847711 ^ -17970841), new object[1] { Hm53iGOASnQvqnvysbfd(element) }));
									voNUR4OAkY2skHGSxkW8(processValidationMessage, ProcessValidationMessageType.Error);
									OKkA6EOAGLdOUGLPa1hS(processValidationMessage, element);
									collection5.Add(processValidationMessage);
									num6 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 == 0)
									{
										num6 = 0;
									}
									continue;
								}
								case 5:
									break;
								case 2:
									goto IL_03b1;
								case 3:
									if (H1UfSkOGtLbKE0lQpZr0(elm8jqOGmt5yx3everDj(current2), _003C_003Ec__DisplayClass13_.startGate.GatewayId))
									{
										num6 = 6;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 == 0)
										{
											num6 = 3;
										}
										continue;
									}
									goto default;
								case 4:
									list2.Add(current2);
									num7 = 5;
									goto IL_02d6;
								case 1:
									goto end_IL_038b;
									IL_02d6:
									num6 = num7;
									continue;
								}
								break;
							}
							continue;
							end_IL_038b:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num8 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 != 0)
						{
							num8 = 0;
						}
						switch (num8)
						{
						case 0:
							break;
						}
					}
					goto case 1;
				case 48:
					element2 = (Element)PwrT3nOG5CYrUQoHkwZg(element.OutputFlows[0]);
					num = 47;
					break;
				case 15:
					gatewayElement = ((IEnumerable<Element>)ODEDglOAMj9AfOAQ9PEN(Diagram)).FirstOrDefault(_003C_003Ec__DisplayClass13_._003CCheckGateway_003Eb__0) as GatewayElement;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e == 0)
					{
						num2 = 14;
					}
					continue;
				case 11:
				case 51:
					activityGates.Add(element, executionGate);
					num2 = 9;
					continue;
				case 38:
				{
					ICollection<ProcessValidationMessage> collection3 = base.Messages;
					ProcessValidationMessage processValidationMessage = new ProcessValidationMessage();
					LQsGILOAUMbJ9T9476Lk(processValidationMessage, SR.T((string)Ux9GqBOAqjDqX7ILRgNd(0xF400DF8 ^ 0xF426EA0), element.Name));
					voNUR4OAkY2skHGSxkW8(processValidationMessage, ProcessValidationMessageType.Error);
					processValidationMessage.Object = element;
					collection3.Add(processValidationMessage);
					num2 = 25;
					continue;
				}
				case 14:
					if (gatewayElement != null)
					{
						num2 = 40;
						continue;
					}
					goto case 39;
				case 25:
					return;
				case 32:
				{
					ICollection<ProcessValidationMessage> collection6 = base.Messages;
					ProcessValidationMessage processValidationMessage = new ProcessValidationMessage
					{
						Message = (string)G7rtw9OArqjN4xCpbBtK(Ux9GqBOAqjDqX7ILRgNd(0x246EEF98 ^ 0x246C8BEE), new object[1] { Hm53iGOASnQvqnvysbfd(element) })
					};
					voNUR4OAkY2skHGSxkW8(processValidationMessage, ProcessValidationMessageType.Error);
					OKkA6EOAGLdOUGLPa1hS(processValidationMessage, element);
					collection6.Add(processValidationMessage);
					num2 = 29;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 != 0)
					{
						num2 = 34;
					}
					continue;
				}
				case 53:
					if (!activityGates[element].Equals(executionGate))
					{
						num2 = 31;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 != 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 3;
				case 55:
					return;
				case 36:
					QkNe9UOGybNDHBmT3MtA(this, element);
					num2 = 46;
					continue;
				case 8:
					unresolvedGateways.Remove(element);
					num2 = 24;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 == 0)
					{
						num2 = 2;
					}
					continue;
				case 7:
					QkNe9UOGybNDHBmT3MtA(this, element);
					num2 = 27;
					continue;
				case 46:
					if (activityGates.ContainsKey(element))
					{
						num2 = 42;
						continue;
					}
					goto case 2;
				case 2:
					activityGates.Add(element, gate);
					num = 21;
					break;
				case 41:
					if (unresolvedGateways.Contains(element))
					{
						num2 = 14;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd != 0)
						{
							num2 = 56;
						}
						continue;
					}
					goto case 16;
				case 1:
					flag = false;
					num2 = 15;
					continue;
				case 5:
					if (unresolvedGateways.Contains(element))
					{
						num2 = 8;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b == 0)
						{
							num2 = 8;
						}
						continue;
					}
					goto case 24;
				case 40:
					if (gatewayElement.OutputFlows.Count == hEO7ACOGBM62iLPhyuk4(list2))
					{
						num2 = 44;
						continue;
					}
					goto case 39;
				default:
				{
					ICollection<ProcessValidationMessage> collection4 = base.Messages;
					ProcessValidationMessage processValidationMessage = new ProcessValidationMessage();
					LQsGILOAUMbJ9T9476Lk(processValidationMessage, G7rtw9OArqjN4xCpbBtK(Ux9GqBOAqjDqX7ILRgNd(-1600060848 ^ -1599904156), new object[1] { Hm53iGOASnQvqnvysbfd(gatewayElement) }));
					voNUR4OAkY2skHGSxkW8(processValidationMessage, ProcessValidationMessageType.Error);
					OKkA6EOAGLdOUGLPa1hS(processValidationMessage, gatewayElement);
					collection4.Add(processValidationMessage);
					num2 = 52;
					continue;
				}
				case 16:
					unresolvedGateways.Add(element);
					num2 = 12;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c == 0)
					{
						num2 = 10;
					}
					continue;
				case 44:
					flag = true;
					num2 = 39;
					continue;
				case 24:
					if (!activityGates.ContainsKey(element))
					{
						num2 = 11;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 != 0)
						{
							num2 = 11;
						}
						continue;
					}
					goto case 53;
				case 26:
					if (list.Count == p6prVyOAF6WoQKDrJ8OK(element.InputFlows))
					{
						num2 = 35;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 == 0)
						{
							num2 = 37;
						}
						continue;
					}
					goto case 41;
				case 30:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator2.MoveNext())
							{
								num3 = 6;
								goto IL_0872;
							}
							goto IL_0946;
							IL_0872:
							while (true)
							{
								switch (num3)
								{
								case 4:
									PuNLDcOGgXnCvg0GovkO(this, element3, executionGate2);
									num3 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 != 0)
									{
										num3 = 1;
									}
									continue;
								case 1:
									break;
								case 2:
									element3 = (Element)PwrT3nOG5CYrUQoHkwZg(current);
									num3 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 != 0)
									{
										num3 = 0;
									}
									continue;
								default:
									QkNe9UOGybNDHBmT3MtA(this, current);
									num3 = 4;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 == 0)
									{
										num3 = 4;
									}
									continue;
								case 5:
									executionGate2 = new ExecutionGate(lyrBJIOGb8W94P07WBbK(element), num4++);
									num3 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a != 0)
									{
										num3 = 2;
									}
									continue;
								case 3:
									goto IL_0946;
								case 6:
									return;
								}
								break;
							}
							continue;
							IL_0946:
							current = enumerator2.Current;
							num3 = 5;
							goto IL_0872;
						}
					}
					finally
					{
						((IDisposable)enumerator2).Dispose();
						int num5 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 != 0)
						{
							num5 = 0;
						}
						switch (num5)
						{
						case 0:
							break;
						}
					}
				case 6:
					enumerator = list.GetEnumerator();
					num2 = 43;
					continue;
				case 37:
					_003C_003Ec__DisplayClass13_ = new _003C_003Ec__DisplayClass13_0();
					num2 = 49;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 == 0)
					{
						num2 = 31;
					}
					continue;
				case 13:
					list = new List<ExecutionGate>();
					num2 = 54;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a == 0)
					{
						num2 = 29;
					}
					continue;
				case 10:
				case 23:
					list.Add(gate);
					num = 26;
					break;
				case 45:
					if (activityGates.ContainsKey(gatewayElement))
					{
						num2 = 22;
						continue;
					}
					goto default;
				case 39:
					if (!flag)
					{
						lg4B5IOGPmvLt7MqfUMJ(element, GatewayStartType.Start);
						num2 = 20;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f != 0)
						{
							num2 = 36;
						}
						continue;
					}
					num = 33;
					break;
				case 12:
					return;
				case 56:
					return;
				case 28:
					list2 = new List<ExecutionGate>();
					num = 6;
					break;
				case 31:
				{
					ICollection<ProcessValidationMessage> collection2 = base.Messages;
					ProcessValidationMessage processValidationMessage = new ProcessValidationMessage();
					LQsGILOAUMbJ9T9476Lk(processValidationMessage, G7rtw9OArqjN4xCpbBtK(Ux9GqBOAqjDqX7ILRgNd(-684210684 ^ -684350414), new object[1] { Hm53iGOASnQvqnvysbfd(element) }));
					voNUR4OAkY2skHGSxkW8(processValidationMessage, ProcessValidationMessageType.Error);
					OKkA6EOAGLdOUGLPa1hS(processValidationMessage, element);
					collection2.Add(processValidationMessage);
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be == 0)
					{
						num2 = 0;
					}
					continue;
				}
				case 52:
					return;
				case 22:
					executionGate = activityGates[gatewayElement];
					num2 = 39;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e != 0)
					{
						num2 = 50;
					}
					continue;
				case 21:
				case 34:
					unresolvedGateways.Add(element);
					num = 4;
					break;
				case 3:
				case 9:
					QkNe9UOGybNDHBmT3MtA(this, element.OutputFlows[0]);
					num2 = 48;
					continue;
				case 27:
					if (p6prVyOAF6WoQKDrJ8OK(element.OutputFlows) == 1)
					{
						if (!unresolvedGateways.Contains(gatewayElement))
						{
							num2 = 20;
							continue;
						}
						goto case 45;
					}
					num2 = 38;
					continue;
				}
				break;
			}
		}
	}

	protected virtual void ValidateElement(Element element)
	{
		//Discarded unreachable code: IL_00a2
		int num = 6;
		int num2 = num;
		IValidatable validatable = default(IValidatable);
		while (true)
		{
			switch (num2)
			{
			case 3:
				validatedElements.Add(element);
				num2 = 2;
				continue;
			case 6:
				if (validatedElements.Contains(element))
				{
					num2 = 5;
					continue;
				}
				break;
			case 2:
				return;
			case 5:
				return;
			default:
				if (validatable != null)
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto case 3;
			case 1:
				ntbxwiOGXEPpopbMF0LW(validatable, this);
				num2 = 3;
				continue;
			case 4:
				break;
			}
			validatable = element as IValidatable;
			num2 = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
			{
				num2 = 0;
			}
		}
	}

	protected virtual void UpdateContextViewScheme()
	{
		//Discarded unreachable code: IL_006b, IL_007a, IL_01ea, IL_0222, IL_0231
		int num = 5;
		int num2 = num;
		IEnumerator<SwimlaneElement> enumerator = default(IEnumerator<SwimlaneElement>);
		_003C_003Ec__DisplayClass15_0 _003C_003Ec__DisplayClass15_ = default(_003C_003Ec__DisplayClass15_0);
		_003C_003Ec__DisplayClass15_1 _003C_003Ec__DisplayClass15_2 = default(_003C_003Ec__DisplayClass15_1);
		SwimlaneContextViewScheme swimlaneContextViewScheme = default(SwimlaneContextViewScheme);
		while (true)
		{
			switch (num2)
			{
			case 6:
				enumerator = _003C_003Ec__DisplayClass15_.swimlanes.GetEnumerator();
				num2 = 3;
				break;
			case 5:
				_003C_003Ec__DisplayClass15_ = new _003C_003Ec__DisplayClass15_0();
				num2 = 4;
				break;
			case 3:
				try
				{
					while (true)
					{
						IL_00e0:
						int num3;
						if (!a9JbG8OA4DQ7MVPd1Oyk(enumerator))
						{
							num3 = 3;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b != 0)
							{
								num3 = 3;
							}
							goto IL_0089;
						}
						goto IL_00cf;
						IL_00cf:
						_003C_003Ec__DisplayClass15_2 = new _003C_003Ec__DisplayClass15_1();
						num3 = 7;
						goto IL_0089;
						IL_0089:
						while (true)
						{
							switch (num3)
							{
							case 7:
								_003C_003Ec__DisplayClass15_2.swim = enumerator.Current;
								num3 = 8;
								continue;
							case 1:
								break;
							case 6:
								goto IL_00e0;
							case 2:
								((ProcessContextViewScheme)NjXQRyOGuak4LkZQ8k3q(Process)).Swimlanes.Add(swimlaneContextViewScheme);
								num3 = 4;
								continue;
							case 8:
								swimlaneContextViewScheme = ((ProcessContextViewScheme)NjXQRyOGuak4LkZQ8k3q(Process)).Swimlanes.FirstOrDefault(_003C_003Ec__DisplayClass15_2._003CUpdateContextViewScheme_003Eb__1);
								num3 = 5;
								continue;
							case 4:
								swimlaneContextViewScheme.RefreshItemsFromTasks(Diagram);
								num3 = 6;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 != 0)
								{
									num3 = 6;
								}
								continue;
							default:
							{
								SwimlaneContextViewScheme swimlaneContextViewScheme2 = new SwimlaneContextViewScheme();
								iinj8ZOGDlGByh3gpkN4(swimlaneContextViewScheme2, lyrBJIOGb8W94P07WBbK(_003C_003Ec__DisplayClass15_2.swim));
								swimlaneContextViewScheme = swimlaneContextViewScheme2;
								int num4 = 2;
								num3 = num4;
								continue;
							}
							case 5:
								if (swimlaneContextViewScheme == null)
								{
									num3 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd == 0)
									{
										num3 = 0;
									}
									continue;
								}
								goto case 4;
							case 3:
								goto end_IL_00e0;
							}
							break;
						}
						goto IL_00cf;
						continue;
						end_IL_00e0:
						break;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num5 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b == 0)
						{
							num5 = 0;
						}
						while (true)
						{
							switch (num5)
							{
							default:
								GLGtStOAz0kXZyb35GUm(enumerator);
								num5 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 == 0)
								{
									num5 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
				goto default;
			case 2:
				return;
			default:
				((ProcessContextViewScheme)NjXQRyOGuak4LkZQ8k3q(Process)).Swimlanes.RemoveAll(_003C_003Ec__DisplayClass15_._003CUpdateContextViewScheme_003Eb__0);
				num2 = 2;
				break;
			case 7:
				_003C_003Ec__DisplayClass15_.swimlanes = ((IEnumerable)ODEDglOAMj9AfOAQ9PEN(Diagram)).OfType<SwimlaneElement>();
				num2 = 6;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 != 0)
				{
					num2 = 5;
				}
				break;
			case 1:
				H5lWGQOGd3EKpfFqDBnI(Process, new ProcessContextViewScheme());
				num2 = 7;
				break;
			case 4:
				if (Process.ContextViewScheme == null)
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 7;
			}
		}
	}

	internal static object Ux9GqBOAqjDqX7ILRgNd(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool UbrFZjOARwUtOMUeag3y()
	{
		return WXWfw1OAj1SCp8n05CWu == null;
	}

	internal static BPMNProcessValidator qonbNgOA6m1CUcL2O7rI()
	{
		return WXWfw1OAj1SCp8n05CWu;
	}

	internal static object BujSMZOA3ENHolFtZ0WN(object P_0)
	{
		return ((WorkflowProcessDTO)P_0).Diagram;
	}

	internal static void TGI9BCOATmLABGaLSQqa(object P_0)
	{
		((BPMNProcessValidator)P_0).UpdateContextViewScheme();
	}

	internal static void CWfDTvOAQtliK8YO5Ued(object P_0)
	{
		((List<GatewayElement>)P_0).Clear();
	}

	internal static void GPLWPyOApj0CNCCmhH3K(object P_0)
	{
		((Dictionary<GatewayElement, List<ExecutionGate>>)P_0).Clear();
	}

	internal static void KjBgaaOACgWWRFIGqAxP(object P_0)
	{
		((List<Element>)P_0).Clear();
	}

	internal static object ODEDglOAMj9AfOAQ9PEN(object P_0)
	{
		return ((Diagram)P_0).Elements;
	}

	internal static void voNUR4OAkY2skHGSxkW8(object P_0, ProcessValidationMessageType value)
	{
		((ProcessValidationMessage)P_0).Type = value;
	}

	internal static void LQsGILOAUMbJ9T9476Lk(object P_0, object P_1)
	{
		((ProcessValidationMessage)P_0).Message = (string)P_1;
	}

	internal static int NjLiwIOAVvIQMGoYIPxT(object P_0)
	{
		return ((List<Element>)P_0).Count;
	}

	internal static object VJ332AOAA6xx1H2KbeN4(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void OKkA6EOAGLdOUGLPa1hS(object P_0, object P_1)
	{
		((ProcessValidationMessage)P_0).Object = P_1;
	}

	internal static object eB5dEvOA7RiGvtf421yL(object P_0)
	{
		return ((FlowConnectorElement)P_0).Condition;
	}

	internal static ConditionType zS2WsSOA24Rgyd7Dq9qA(object P_0)
	{
		return ((Condition)P_0).Type;
	}

	internal static object viZDgfOAoybn5GoP7sJ6(object P_0)
	{
		return ((Connector)P_0).StartElement;
	}

	internal static int p6prVyOAF6WoQKDrJ8OK(object P_0)
	{
		return ((List<Connector>)P_0).Count;
	}

	internal static object N6FitVOAiRdbp5XJTpYZ(object P_0)
	{
		return ((WorkflowProcessDTO)P_0).ScriptModule;
	}

	internal static object kZUqB9OAIhCAILktCuEh(object P_0)
	{
		return ((ScriptModuleDTO)P_0).SourceCode;
	}

	internal static object pj79wJOAacQPUOm6eKTT(object P_0)
	{
		return ((Condition)P_0).ScriptName;
	}

	internal static object G7rtw9OArqjN4xCpbBtK(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static bool htLP75OAenfsOU450R3k(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static bool FtJamnOAN9QQ3e4vEqXF(object P_0)
	{
		return ((FlowConnectorElement)P_0).FormingTemplateName;
	}

	internal static object wHPGfJOAxIGYi5BMOhAe(object P_0)
	{
		return ((FlowConnectorElement)P_0).TemplateName;
	}

	internal static object Hm53iGOASnQvqnvysbfd(object P_0)
	{
		return ((Element)P_0).Name;
	}

	internal static bool B7IfwROA1P7QKXc11hVl(object P_0)
	{
		return ((FlowConnectorElement)P_0).FormingTemplateDescription;
	}

	internal static bool wEZFYcOAhhnQaOse5cxF(object P_0)
	{
		return ((FlowConnectorElement)P_0).UseConfirmConnector;
	}

	internal static bool KmcWb1OAE0Z4ixWktcDI(object P_0)
	{
		return ((FlowConnectorElement)P_0).FormingConfirmConnector;
	}

	internal static object CBr9eGOAwJlwVpDk92EB(object P_0)
	{
		return ((FlowConnectorElement)P_0).ConfirmConnectorText;
	}

	internal static bool a9JbG8OA4DQ7MVPd1Oyk(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void GLGtStOAz0kXZyb35GUm(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object uWoIS1OGKT4XtyGIbIoC(object P_0, object P_1, StringSplitOptions P_2)
	{
		return ((string)P_0).Split((string[])P_1, P_2);
	}

	internal static bool DIGiKiOGOhevdlZtJBQx(object P_0, object P_1)
	{
		return ((string)P_0).Contains((string)P_1);
	}

	internal static object fPeNXgOGZWKa7niHWr8g(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}

	internal static object NRwC1NOGv9sdDaLcUwfx(object P_0, object P_1, object P_2)
	{
		return ((CSharpParser)P_0).Parse((string)P_1, (string)P_2);
	}

	internal static object Dookd1OGYqoAXI08jlMn(object P_0)
	{
		return ((EntityDeclaration)P_0).get_Name();
	}

	internal static object I3Lgw3OG89m5GO2vQF2p(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static bool iPxYYlOGs31vlOWL0W14(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static object J1mDZOOGJ9sf4qe9yCoI(object P_0)
	{
		return ((EntityDeclaration)P_0).get_ReturnType();
	}

	internal static object CXr140OGlfyaJQtSJQxb(object P_0)
	{
		return ((EntityDeclaration)P_0).get_NameToken();
	}

	internal static object nUWmaSOG0DI4PvO4tiV3(object P_0)
	{
		return ((Identifier)P_0).get_Name();
	}

	internal static void QkNe9UOGybNDHBmT3MtA(object P_0, object P_1)
	{
		((BPMNProcessValidator)P_0).ValidateElement((Element)P_1);
	}

	internal static Guid elm8jqOGmt5yx3everDj(object P_0)
	{
		return ((ExecutionGate)P_0).GatewayId;
	}

	internal static bool H1UfSkOGtLbKE0lQpZr0(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static Guid lyrBJIOGb8W94P07WBbK(object P_0)
	{
		return ((Element)P_0).Uid;
	}

	internal static object PwrT3nOG5CYrUQoHkwZg(object P_0)
	{
		return ((Connector)P_0).EndElement;
	}

	internal static bool PuNLDcOGgXnCvg0GovkO(object P_0, object P_1, object P_2)
	{
		return ((BPMNProcessValidator)P_0).CheckDiagramElement((Element)P_1, (ExecutionGate)P_2);
	}

	internal static int hEO7ACOGBM62iLPhyuk4(object P_0)
	{
		return ((List<ExecutionGate>)P_0).Count;
	}

	internal static void qrRAYJOGcbkcAOgVGUUu(object P_0, Guid value)
	{
		((GatewayElement)P_0).PairGatewayUid = value;
	}

	internal static void lg4B5IOGPmvLt7MqfUMJ(object P_0, GatewayStartType value)
	{
		((GatewayElement)P_0).GatewayStartType = value;
	}

	internal static void ntbxwiOGXEPpopbMF0LW(object P_0, object P_1)
	{
		((IValidatable)P_0).Validate((WorkflowProcessValidator)P_1);
	}

	internal static void H5lWGQOGd3EKpfFqDBnI(object P_0, object P_1)
	{
		((WorkflowProcessDTO)P_0).ContextViewScheme = (ProcessContextViewScheme)P_1;
	}

	internal static object NjXQRyOGuak4LkZQ8k3q(object P_0)
	{
		return ((WorkflowProcessDTO)P_0).ContextViewScheme;
	}

	internal static void iinj8ZOGDlGByh3gpkN4(object P_0, Guid value)
	{
		((SwimlaneContextViewScheme)P_0).SwimlaneUid = value;
	}
}
