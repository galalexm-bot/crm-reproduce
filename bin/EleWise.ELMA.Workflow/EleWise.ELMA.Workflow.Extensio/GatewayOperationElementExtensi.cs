using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Connectors;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Gateways;
using EleWise.ELMA.Workflow.DTO.Managers;
using EleWise.ELMA.Workflow.DTO.Models;
using EleWise.ELMA.Workflow.ExtensionPoints;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Models.Regulation;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Extensions;

[Component]
internal class GatewayOperationElementExtension : IWorkflowRegulationOperationExtension
{
	private readonly ILogger logger;

	private readonly IWorkflowProcessDTOManager workflowProcessDTOManager;

	internal static GatewayOperationElementExtension zRwKdtoH0JbLg0guK3S;

	public GatewayOperationElementExtension(IWorkflowProcessDTOManager workflowProcessDTOManager, ILogger logger)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		gQsrhxo9pt2HpyQqcsJ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			case 1:
				this.logger = logger;
				num = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 == 0)
				{
					num = 2;
				}
				break;
			default:
				this.workflowProcessDTOManager = workflowProcessDTOManager;
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public bool CheckTypeElement(object obj)
	{
		return obj.GetType().BaseType == AcpSCroWNiZZF27yOb7(typeof(GatewayElement).TypeHandle);
	}

	public void GetRegulationOperationFromElement(object obj, WorkflowProcessDTO process, ref Dictionary<Guid, string> numberElemArtDict, ref RegulationOperation regulationOperation)
	{
		//Discarded unreachable code: IL_010d, IL_019e, IL_01ad, IL_01ef, IL_01fe, IL_0258, IL_0267, IL_0277, IL_0286, IL_02c5, IL_032a, IL_0339, IL_0419, IL_044c, IL_04b5, IL_0644, IL_0653, IL_067b, IL_06c6, IL_06d9, IL_06e9, IL_06f8, IL_0703, IL_078b, IL_079e, IL_07ad, IL_080c, IL_081b, IL_08c1, IL_08d0, IL_08e0, IL_08f3, IL_0902, IL_0912, IL_09d9, IL_09e8, IL_0aac
		int num = 3;
		Type type = default(Type);
		string text = default(string);
		GatewayElement gatewayElement = default(GatewayElement);
		List<Connector>.Enumerator enumerator = default(List<Connector>.Enumerator);
		Connector current2 = default(Connector);
		string text2 = default(string);
		Condition condition = default(Condition);
		ProcessRegulation regulation = default(ProcessRegulation);
		int num7 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 22:
					if (x07H4Boju6Z29E72aL8(type, AcpSCroWNiZZF27yOb7(typeof(ExclusiveGatewayElement).TypeHandle)))
					{
						num2 = 19;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b != 0)
						{
							num2 = 19;
						}
						continue;
					}
					goto case 24;
				case 4:
					text = null;
					num2 = 14;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 == 0)
					{
						num2 = 20;
					}
					continue;
				case 26:
					regulationOperation.Connectors = gatewayElement.OutputFlows.ToList();
					num = 5;
					break;
				case 12:
					try
					{
						while (true)
						{
							IL_02df:
							int num5;
							if (!enumerator.MoveNext())
							{
								num5 = 3;
								goto IL_011b;
							}
							goto IL_01d3;
							IL_0317:
							int num6 = 11;
							goto IL_0117;
							IL_01d3:
							current2 = enumerator.Current;
							num6 = 21;
							goto IL_0117;
							IL_0117:
							num5 = num6;
							goto IL_011b;
							IL_011b:
							while (true)
							{
								switch (num5)
								{
								case 14:
									text2 = (string)JnnTxIo6dxiwOxBdF0k(0x51EF0063 ^ 0x51EE244F);
									num5 = 6;
									continue;
								case 17:
									break;
								default:
									if (Tx9UcroGHWdNqknV1So(((ConditionTable)bRFELpoA60viaxyRTXr(condition)).Items) <= 0)
									{
										num5 = 23;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 == 0)
										{
											num5 = 8;
										}
										continue;
									}
									goto case 13;
								case 22:
									regulationOperation.FlowsConnectors.Add(text2);
									num5 = 26;
									continue;
								case 5:
								case 25:
									regulationOperation.NumbersOfEndElement.Add(regulation.ElementNumberDict[((Element)kqhMhuoe0l8ZKFHUg5S(current2)).Uid]);
									num5 = 19;
									continue;
								case 16:
									num7++;
									num5 = 20;
									continue;
								case 15:
								case 19:
									goto IL_02df;
								case 10:
								case 20:
									if (num7 < Tx9UcroGHWdNqknV1So(((ConditionTable)bRFELpoA60viaxyRTXr(lt6gu8oV3ieyR2ZMU4I((FlowConnectorElement)current2))).Items))
									{
										goto IL_0317;
									}
									goto case 27;
								case 4:
									try
									{
										text2 = (string)QdGO2PoaJIVZdlYqF41(text2, Chs6tdoIRPlhVgHLZNb(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x738ABA6E ^ 0x738B9E58), new object[4]
										{
											NumberRelation(num7, (string)ESWqSgo2bJCmLAtwCfX(iDbseio7lJiwSEmqNOb(((ConditionTable)bRFELpoA60viaxyRTXr(condition)).Items[num7]))),
											OperandName(process, (ConditionTable.Operand)d7OBhsooly0YRb8ulYy(((ConditionTable)bRFELpoA60viaxyRTXr(condition)).Items[num7])),
											ESWqSgo2bJCmLAtwCfX(IBkIf3oF5MxPnyPupRo(((ConditionTable)bRFELpoA60viaxyRTXr(condition)).Items[num7])),
											OperandName(process, (ConditionTable.Operand)ytt99JoiWyhs2Ix5mEq(((ConditionTable)bRFELpoA60viaxyRTXr(condition)).Items[num7]))
										}));
										int num8 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd == 0)
										{
											num8 = 0;
										}
										switch (num8)
										{
										case 0:
											break;
										}
									}
									catch (Exception message)
									{
										int num9 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 == 0)
										{
											num9 = 0;
										}
										while (true)
										{
											switch (num9)
											{
											default:
												logger.Error(message);
												num9 = 2;
												continue;
											case 2:
												text2 += SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2077784392 ^ -2077842720);
												num9 = 1;
												if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 != 0)
												{
													num9 = 0;
												}
												continue;
											case 1:
												break;
											}
											break;
										}
									}
									goto case 16;
								case 6:
									num7 = 0;
									num5 = 10;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 == 0)
									{
										num5 = 1;
									}
									continue;
								case 9:
								case 11:
									num5 = 4;
									continue;
								case 8:
								case 23:
								case 28:
									regulationOperation.FlowsConnectors.Add((string)X3QqTmo3A8eaETZFrY6(JnnTxIo6dxiwOxBdF0k(0x46EA3D1 ^ 0x46F87B5), e0jml5oR1BChu4cQJaf(JnnTxIo6dxiwOxBdF0k(-768800937 ^ -768859197)), FlowIsDefault(((FlowConnectorElement)current2).IsDefault)));
									num5 = 14;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 == 0)
									{
										num5 = 24;
									}
									continue;
								case 13:
									if (condition.Type != 0)
									{
										num5 = 12;
										continue;
									}
									goto case 14;
								case 27:
									text2 += FlowIsDefault(((FlowConnectorElement)current2).IsDefault);
									num5 = 22;
									continue;
								case 18:
								case 24:
								case 26:
									goto IL_058b;
								case 21:
									if (!YXQJxboULyFu96lb53H(obj.GetType(), AcpSCroWNiZZF27yOb7(typeof(ParallelGatewayElement).TypeHandle)))
									{
										num5 = 5;
										continue;
									}
									goto case 1;
								case 2:
								case 12:
									goto IL_05e2;
								case 1:
									condition = (Condition)lt6gu8oV3ieyR2ZMU4I((FlowConnectorElement)current2);
									num5 = 7;
									continue;
								case 7:
									if (condition == null)
									{
										num5 = 28;
										continue;
									}
									goto default;
								case 3:
									return;
								}
								break;
							}
							goto IL_01d3;
							IL_05e2:
							regulationOperation.FlowsConnectors.Add((string)X3QqTmo3A8eaETZFrY6(JnnTxIo6dxiwOxBdF0k(0x1134D2C0 ^ 0x1135F6A4), e0jml5oR1BChu4cQJaf(JnnTxIo6dxiwOxBdF0k(-2057730233 ^ -2057788611)), FlowIsDefault(AJwk4forrZmHw8LCnDK((FlowConnectorElement)current2))));
							num6 = 18;
							goto IL_0117;
							IL_058b:
							regulationOperation.NumbersOfEndElement.Add(regulation.ElementNumberDict[aAFwrloCjcM9Pp2seFH(current2.EndElement)]);
							num6 = 15;
							goto IL_0117;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num10 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f == 0)
						{
							num10 = 0;
						}
						switch (num10)
						{
						case 0:
							break;
						}
					}
				case 14:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
								{
									num3 = 0;
								}
								goto IL_0707;
							}
							goto IL_071d;
							IL_071d:
							Connector current = enumerator.Current;
							NDcn6BopR0ith3mVU81(current, h1W29aoQsCCNY1WTKVW(current));
							num3 = 2;
							goto IL_0707;
							IL_0707:
							switch (num3)
							{
							case 1:
								goto IL_071d;
							case 2:
								continue;
							case 0:
								break;
							}
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num4 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					goto case 9;
				case 7:
					if (regulation.ElementNumberDict == null)
					{
						num2 = 16;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 == 0)
						{
							num2 = 17;
						}
						continue;
					}
					goto case 10;
				case 5:
					enumerator = regulationOperation.Connectors.GetEnumerator();
					num2 = 14;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede == 0)
					{
						num2 = 10;
					}
					continue;
				case 29:
					return;
				case 15:
					text = string.Empty;
					num2 = 9;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 != 0)
					{
						num2 = 13;
					}
					continue;
				case 20:
				case 21:
				case 23:
				case 27:
					pLKYmjoTgwZ5Ps5IHZk(regulationOperation, X3QqTmo3A8eaETZFrY6(JnnTxIo6dxiwOxBdF0k(-45832783 ^ -45776473), PFTlWMoq4EUUbrIwYfy(gatewayElement), text));
					num2 = 8;
					continue;
				case 2:
					if (gatewayElement == null)
					{
						return;
					}
					num2 = 15;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 == 0)
					{
						num2 = 6;
					}
					continue;
				case 3:
					gatewayElement = obj as GatewayElement;
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 != 0)
					{
						num2 = 2;
					}
					continue;
				case 11:
					return;
				case 19:
					text = SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-763667953 ^ -763725413));
					num2 = 23;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 != 0)
					{
						num2 = 13;
					}
					continue;
				case 8:
					regulationOperation.Description = (string)h1W29aoQsCCNY1WTKVW(gatewayElement);
					num2 = 26;
					continue;
				case 13:
					type = obj.GetType();
					num2 = 22;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 == 0)
					{
						num2 = 2;
					}
					continue;
				case 28:
					text = (string)e0jml5oR1BChu4cQJaf(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x65B7F624 ^ 0x65B6D5E4));
					num2 = 27;
					continue;
				case 6:
				case 17:
				case 18:
					P2YJ6bokdoIAgfomuTN(regulationOperation.NumbersOfEndElement);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b == 0)
					{
						num2 = 1;
					}
					continue;
				case 9:
					regulation = process.Regulation;
					num = 7;
					break;
				case 10:
					if (!regulation.ElementNumberDict.ContainsKey(gatewayElement.Uid))
					{
						num2 = 6;
						continue;
					}
					goto default;
				default:
					WCru2moMx0VVKP2fw5q(regulationOperation, regulation.ElementNumberDict[aAFwrloCjcM9Pp2seFH(gatewayElement)]);
					num2 = 18;
					continue;
				case 30:
					text = (string)e0jml5oR1BChu4cQJaf(JnnTxIo6dxiwOxBdF0k(0x1AF6F1F2 ^ 0x1AF7D202));
					num2 = 21;
					continue;
				case 16:
				case 25:
					if (x07H4Boju6Z29E72aL8(type, AcpSCroWNiZZF27yOb7(typeof(ParallelGatewayElement).TypeHandle)))
					{
						num2 = 30;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea != 0)
						{
							num2 = 17;
						}
						continue;
					}
					goto case 4;
				case 1:
					enumerator = gatewayElement.OutputFlows.GetEnumerator();
					num2 = 12;
					continue;
				case 24:
					if (!x07H4Boju6Z29E72aL8(type, AcpSCroWNiZZF27yOb7(typeof(InclusiveGatewayElement).TypeHandle)))
					{
						num = 25;
						break;
					}
					goto case 28;
				}
				break;
			}
		}
	}

	private string FlowIsDefault(bool isDefault)
	{
		//Discarded unreachable code: IL_004b, IL_005a
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return null;
			case 1:
				return (string)e0jml5oR1BChu4cQJaf(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1108877388 ^ -1108935910));
			case 2:
				if (isDefault)
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			}
		}
	}

	private string NumberRelation(int number, string text)
	{
		//Discarded unreachable code: IL_004d, IL_005c
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (number == 0)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return (string)jg1p8uoNZbi7Shgp6dx(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x8D5763A ^ 0x8D452EA), text);
			default:
				return "";
			}
		}
	}

	private string OperandName(WorkflowProcessDTO process, ConditionTable.Operand operand)
	{
		//Discarded unreachable code: IL_0073, IL_0082, IL_0091, IL_00d3, IL_00e2, IL_013e
		int num = 5;
		ConditionTable.OperandType type = default(ConditionTable.OperandType);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 1:
					if (type != ConditionTable.OperandType.Value)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 2;
				case 5:
					goto end_IL_0012;
				case 11:
					text = (string)e0jml5oR1BChu4cQJaf(JnnTxIo6dxiwOxBdF0k(0x4FD00585 ^ 0x4FD1215B));
					num2 = 7;
					continue;
				case 2:
					if (operand.Value == null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					obj = BCq1maoxrr9JEgC8y61(operand).ToString();
					break;
				case 4:
					type = operand.Type;
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					obj = "";
					break;
				case 7:
				case 8:
				case 10:
					return text;
				case 3:
					if (type != ConditionTable.OperandType.CustomType)
					{
						num2 = 9;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 11;
				case 6:
				case 9:
					AddPublishedProperties(process, operand, ref text);
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f == 0)
					{
						num2 = 8;
					}
					continue;
				}
				text = (string)obj;
				num2 = 10;
				continue;
				end_IL_0012:
				break;
			}
			text = null;
			num = 4;
		}
	}

	private void AddPublishedProperties(WorkflowProcessDTO process, ConditionTable.Operand operand, ref string text)
	{
		//Discarded unreachable code: IL_00d8, IL_0167
		int num = 3;
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = default(_003C_003Ec__DisplayClass8_0);
		WorkflowProcessDTO workflowProcessDTO = default(WorkflowProcessDTO);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					propertyMetadata = ((ClassMetadata)A7qOqKoSge8b4SxoXBM(process)).Properties.FirstOrDefault(_003C_003Ec__DisplayClass8_._003CAddPublishedProperties_003Eb__0);
					num2 = 9;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 == 0)
					{
						num2 = 4;
					}
					break;
				case 9:
					if (propertyMetadata != null)
					{
						num2 = 3;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 != 0)
						{
							num2 = 8;
						}
						break;
					}
					goto case 7;
				case 10:
					workflowProcessDTO = (WorkflowProcessDTO)f8NOx1ohcNB2muXlXlf(workflowProcessDTOManager, SUjSQ7o19QVPrMY5Pas(process));
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 == 0)
					{
						num2 = 4;
					}
					break;
				case 3:
					_003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e == 0)
					{
						num2 = 2;
					}
					break;
				case 6:
					return;
				case 8:
					text = (string)UcrLYMoEibJNWTE4QeB(propertyMetadata);
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd == 0)
					{
						num2 = 5;
					}
					break;
				case 11:
					AddPublishedProperties(workflowProcessDTO, _003C_003Ec__DisplayClass8_.operand, ref text);
					num2 = 6;
					break;
				case 4:
					if (workflowProcessDTO == null)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 11;
				case 1:
					return;
				case 5:
					return;
				case 2:
					_003C_003Ec__DisplayClass8_.operand = operand;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 == 0)
					{
						num2 = 0;
					}
					break;
				case 7:
					if (SUjSQ7o19QVPrMY5Pas(process) > 0)
					{
						goto end_IL_0012;
					}
					goto case 8;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 10;
		}
	}

	internal static void gQsrhxo9pt2HpyQqcsJ()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool s53GsSoLPdkaRBLyaQu()
	{
		return zRwKdtoH0JbLg0guK3S == null;
	}

	internal static GatewayOperationElementExtension DrfZ04of3Gi1l3ETZip()
	{
		return zRwKdtoH0JbLg0guK3S;
	}

	internal static Type AcpSCroWNiZZF27yOb7(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool x07H4Boju6Z29E72aL8(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object e0jml5oR1BChu4cQJaf(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object JnnTxIo6dxiwOxBdF0k(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object PFTlWMoq4EUUbrIwYfy(object P_0)
	{
		return ((Element)P_0).Name;
	}

	internal static object X3QqTmo3A8eaETZFrY6(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static void pLKYmjoTgwZ5Ps5IHZk(object P_0, object P_1)
	{
		((RegulationOperation)P_0).Name = (string)P_1;
	}

	internal static object h1W29aoQsCCNY1WTKVW(object P_0)
	{
		return ((Element)P_0).Description;
	}

	internal static void NDcn6BopR0ith3mVU81(object P_0, object P_1)
	{
		((Element)P_0).Description = (string)P_1;
	}

	internal static Guid aAFwrloCjcM9Pp2seFH(object P_0)
	{
		return ((Element)P_0).Uid;
	}

	internal static void WCru2moMx0VVKP2fw5q(object P_0, long value)
	{
		((RegulationOperation)P_0).Number = value;
	}

	internal static void P2YJ6bokdoIAgfomuTN(object P_0)
	{
		((List<long>)P_0).Clear();
	}

	internal static bool YXQJxboULyFu96lb53H(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static object lt6gu8oV3ieyR2ZMU4I(object P_0)
	{
		return ((FlowConnectorElement)P_0).Condition;
	}

	internal static object bRFELpoA60viaxyRTXr(object P_0)
	{
		return ((Condition)P_0).Table;
	}

	internal static int Tx9UcroGHWdNqknV1So(object P_0)
	{
		return ((List<ConditionTable.Item>)P_0).Count;
	}

	internal static ConditionTable.Relation iDbseio7lJiwSEmqNOb(object P_0)
	{
		return ((ConditionTable.Item)P_0).Relation;
	}

	internal static object ESWqSgo2bJCmLAtwCfX(Enum P_0)
	{
		return P_0.GetDisplayName();
	}

	internal static object d7OBhsooly0YRb8ulYy(object P_0)
	{
		return ((ConditionTable.Item)P_0).Operand1;
	}

	internal static ConditionTable.Operation IBkIf3oF5MxPnyPupRo(object P_0)
	{
		return ((ConditionTable.Item)P_0).Operation;
	}

	internal static object ytt99JoiWyhs2Ix5mEq(object P_0)
	{
		return ((ConditionTable.Item)P_0).Operand2;
	}

	internal static object Chs6tdoIRPlhVgHLZNb(object P_0, object P_1)
	{
		return string.Format((string)P_0, (object[])P_1);
	}

	internal static object QdGO2PoaJIVZdlYqF41(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static bool AJwk4forrZmHw8LCnDK(object P_0)
	{
		return ((FlowConnectorElement)P_0).IsDefault;
	}

	internal static object kqhMhuoe0l8ZKFHUg5S(object P_0)
	{
		return ((Connector)P_0).EndElement;
	}

	internal static object jg1p8uoNZbi7Shgp6dx(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object BCq1maoxrr9JEgC8y61(object P_0)
	{
		return ((ConditionTable.Operand)P_0).Value;
	}

	internal static object A7qOqKoSge8b4SxoXBM(object P_0)
	{
		return ((WorkflowProcessDTO)P_0).Context;
	}

	internal static long SUjSQ7o19QVPrMY5Pas(object P_0)
	{
		return ((WorkflowProcessDTO)P_0).ParentId;
	}

	internal static object f8NOx1ohcNB2muXlXlf(object P_0, long id)
	{
		return ((IWorkflowProcessDTOManager)P_0).LoadOrNull(id);
	}

	internal static object UcrLYMoEibJNWTE4QeB(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}
}
