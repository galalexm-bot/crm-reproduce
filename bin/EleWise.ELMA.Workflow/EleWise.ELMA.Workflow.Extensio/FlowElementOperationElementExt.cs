using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Artifacts;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Connectors;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Gateways;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.SubProcess;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;
using EleWise.ELMA.Workflow.Diagrams.Elements;
using EleWise.ELMA.Workflow.DTO.Models;
using EleWise.ELMA.Workflow.ExtensionPoints;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Models.Regulation;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Extensions;

[Component(Order = 1)]
internal class FlowElementOperationElementExtension : IWorkflowRegulationOperationExtension
{
	internal static FlowElementOperationElementExtension RhW55mo8Sg5nfZGEU5P;

	public bool CheckTypeElement(object obj)
	{
		//Discarded unreachable code: IL_00ac, IL_00bb, IL_00cb, IL_00da
		int num = 2;
		int num2 = num;
		Type type = default(Type);
		while (true)
		{
			switch (num2)
			{
			default:
				if (!TynrhEo0QANKJIvMW4y(type.BaseType, eoJ87uoldlPdXFwYjqZ(typeof(GatewayElement).TypeHandle)))
				{
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a != 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 3;
			case 1:
				if (!(obj is FlowElement))
				{
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f != 0)
					{
						num2 = 4;
					}
					break;
				}
				goto default;
			case 3:
				return type.BaseType != typeof(SubProcessElement);
			case 4:
			case 5:
				return false;
			case 2:
				type = obj.GetType();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public void GetRegulationOperationFromElement(object obj, WorkflowProcessDTO process, ref Dictionary<Guid, string> numberElemArtDict, ref RegulationOperation regulationOperation)
	{
		//Discarded unreachable code: IL_00cd, IL_00dc, IL_01bf, IL_01d2, IL_01e1, IL_025c, IL_0293, IL_02f4, IL_02fe, IL_03d9, IL_040f, IL_0422, IL_0431, IL_04f2, IL_0501, IL_050c, IL_05ce, IL_05e1, IL_05f0, IL_061b, IL_0853, IL_0893, IL_08a2, IL_08ae
		int num = 3;
		List<Element>.Enumerator enumerator3 = default(List<Element>.Enumerator);
		IEnumerator<ArtifactGroupElement> enumerator = default(IEnumerator<ArtifactGroupElement>);
		ProcessRegulation regulation = default(ProcessRegulation);
		List<Connector>.Enumerator enumerator2 = default(List<Connector>.Enumerator);
		Connector current3 = default(Connector);
		BPMNFlowElement bPMNFlowElement = default(BPMNFlowElement);
		Element current4 = default(Element);
		Connector current2 = default(Connector);
		SizeF sizeF = default(SizeF);
		ArtifactGroupElement current = default(ArtifactGroupElement);
		PointF pointF = default(PointF);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					enumerator3 = regulationOperation.Artifacts.GetEnumerator();
					num2 = 20;
					continue;
				case 17:
					enumerator = ((IEnumerable)LVe15boPYefyBSjW9Qt(regulation.Diagram)).OfType<ArtifactGroupElement>().GetEnumerator();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 == 0)
					{
						num2 = 13;
					}
					continue;
				case 12:
					try
					{
						while (true)
						{
							int num11;
							if (!enumerator2.MoveNext())
							{
								int num10 = 4;
								num11 = num10;
								goto IL_00eb;
							}
							goto IL_0141;
							IL_00eb:
							while (true)
							{
								switch (num11)
								{
								case 3:
									break;
								default:
									regulationOperation.Artifacts.Add((Element)UQQ8Kwocyh3dXw7xkmO(current3));
									num11 = 3;
									continue;
								case 1:
									goto IL_0141;
								case 2:
									if (current3.EndElement.GetType().BaseType == eoJ87uoldlPdXFwYjqZ(typeof(ArtefactTaskElement).TypeHandle))
									{
										num11 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e == 0)
										{
											num11 = 0;
										}
										continue;
									}
									break;
								case 4:
									goto end_IL_0109;
								}
								break;
							}
							continue;
							IL_0141:
							current3 = enumerator2.Current;
							num11 = 2;
							goto IL_00eb;
							continue;
							end_IL_0109:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator2).Dispose();
						int num12 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 == 0)
						{
							num12 = 0;
						}
						switch (num12)
						{
						case 0:
							break;
						}
					}
					goto default;
				case 15:
					if (!regulation.ElementNumberDict.ContainsKey(XjY3C4ognvpHx9kq6Rn(bPMNFlowElement)))
					{
						num2 = 19;
						continue;
					}
					goto case 21;
				case 16:
					return;
				case 23:
					MkSC9coyl3PlCmdp1xZ(regulationOperation, bPMNFlowElement.Name);
					num2 = 10;
					continue;
				case 8:
					regulationOperation.Outputs.AddRange(regulationOperation.InternalOutputs);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be == 0)
					{
						num2 = 1;
					}
					continue;
				case 14:
					break;
				case 22:
					regulationOperation.Outputs.AddRange(regulationOperation.ExternalOutputs);
					num2 = 8;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd == 0)
					{
						num2 = 8;
					}
					continue;
				case 9:
					regulation = process.Regulation;
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 == 0)
					{
						num2 = 4;
					}
					continue;
				case 20:
					try
					{
						while (true)
						{
							IL_03ae:
							int num13;
							if (!enumerator3.MoveNext())
							{
								num13 = 2;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 != 0)
								{
									num13 = 4;
								}
								goto IL_0302;
							}
							goto IL_038b;
							IL_038b:
							current4 = enumerator3.Current;
							num13 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c != 0)
							{
								num13 = 0;
							}
							goto IL_0302;
							IL_0302:
							while (true)
							{
								switch (num13)
								{
								default:
									if (numberElemArtDict != null)
									{
										num13 = 2;
										continue;
									}
									goto IL_03ae;
								case 3:
									regulationOperation.NumbersOfArtifact.Add(numberElemArtDict[XjY3C4ognvpHx9kq6Rn(current4)]);
									num13 = 6;
									continue;
								case 2:
									if (!numberElemArtDict.ContainsKey(XjY3C4ognvpHx9kq6Rn(current4)))
									{
										num13 = 1;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 != 0)
										{
											num13 = 1;
										}
										continue;
									}
									goto case 3;
								case 5:
									break;
								case 1:
								case 6:
									goto IL_03ae;
								case 4:
									goto end_IL_03ae;
								}
								break;
							}
							goto IL_038b;
							continue;
							end_IL_03ae:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator3).Dispose();
						int num14 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b == 0)
						{
							num14 = 0;
						}
						switch (num14)
						{
						case 0:
							break;
						}
					}
					goto case 5;
				case 2:
					if (bPMNFlowElement == null)
					{
						return;
					}
					num2 = 9;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 != 0)
					{
						num2 = 23;
					}
					continue;
				case 6:
				case 19:
					enumerator2 = bPMNFlowElement.OutputConnectors.GetEnumerator();
					num2 = 12;
					continue;
				case 18:
					regulationOperation.Inputs.AddRange(regulationOperation.InternalInputs);
					num2 = 21;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 == 0)
					{
						num2 = 22;
					}
					continue;
				case 3:
					bPMNFlowElement = obj as BPMNFlowElement;
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 != 0)
					{
						num2 = 2;
					}
					continue;
				case 4:
					if (regulation.ElementNumberDict != null)
					{
						num2 = 13;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb != 0)
						{
							num2 = 15;
						}
						continue;
					}
					goto case 6;
				case 11:
					try
					{
						while (true)
						{
							int num8;
							if (!enumerator2.MoveNext())
							{
								num8 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b == 0)
								{
									num8 = 0;
								}
								goto IL_0510;
							}
							goto IL_058f;
							IL_058f:
							current2 = enumerator2.Current;
							num8 = 2;
							goto IL_0510;
							IL_0510:
							while (true)
							{
								switch (num8)
								{
								case 2:
									regulationOperation.NumbersOfEndElement.Add(regulation.ElementNumberDict[((Element)UQQ8Kwocyh3dXw7xkmO(current2)).Uid]);
									num8 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e == 0)
									{
										num8 = 0;
									}
									continue;
								case 3:
									goto IL_058f;
								case 1:
									goto end_IL_052a;
								}
								break;
							}
							continue;
							end_IL_052a:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator2).Dispose();
						int num9 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 != 0)
						{
							num9 = 0;
						}
						switch (num9)
						{
						case 0:
							break;
						}
					}
					goto case 17;
				case 7:
					return;
				case 5:
					enumerator2 = regulationOperation.Connectors.GetEnumerator();
					num2 = 11;
					continue;
				case 13:
					try
					{
						while (true)
						{
							IL_07f4:
							int num3;
							if (!LfF3pWoDLrSp2FIyx89(enumerator))
							{
								num3 = 6;
								goto IL_062d;
							}
							goto IL_0748;
							IL_062d:
							while (true)
							{
								int num4;
								switch (num3)
								{
								case 6:
									return;
								default:
								{
									float num6 = sizeF.Width + FwVFfDoXd85qSjW83Lu(current).X;
									sizeF = l0orv6odKSCuK4xLawG(bPMNFlowElement);
									float width = sizeF.Width;
									pointF = FwVFfDoXd85qSjW83Lu(bPMNFlowElement);
									if (num6 >= width + pointF.X)
									{
										num3 = 5;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 == 0)
										{
											num3 = 4;
										}
										continue;
									}
									goto IL_07f4;
								}
								case 9:
									pointF = current.Location;
									num3 = 7;
									continue;
								case 4:
									sizeF = l0orv6odKSCuK4xLawG(current);
									num3 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 == 0)
									{
										num3 = 0;
									}
									continue;
								case 5:
									NEKlXGouJ8MQaMbNlZx(regulationOperation, Y3ue91obG8V9VrwDav6(current));
									num3 = 2;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 == 0)
									{
										num3 = 2;
									}
									continue;
								case 10:
								{
									float x = pointF.X;
									pointF = FwVFfDoXd85qSjW83Lu(bPMNFlowElement);
									if (!(x <= pointF.X))
									{
										goto IL_07f4;
									}
									num4 = 9;
									goto IL_0629;
								}
								case 11:
									break;
								case 3:
									pointF = FwVFfDoXd85qSjW83Lu(current);
									num4 = 10;
									goto IL_0629;
								case 1:
								{
									float num5 = sizeF.Height + FwVFfDoXd85qSjW83Lu(current).Y;
									sizeF = l0orv6odKSCuK4xLawG(bPMNFlowElement);
									float height = sizeF.Height;
									pointF = FwVFfDoXd85qSjW83Lu(bPMNFlowElement);
									if (num5 >= height + pointF.Y)
									{
										num3 = 8;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 != 0)
										{
											num3 = 2;
										}
										continue;
									}
									goto IL_07f4;
								}
								case 7:
								{
									float y = pointF.Y;
									pointF = FwVFfDoXd85qSjW83Lu(bPMNFlowElement);
									if (!(y <= pointF.Y))
									{
										goto IL_07f4;
									}
									num4 = 4;
									goto IL_0629;
								}
								case 2:
									goto IL_07f4;
								case 8:
									{
										sizeF = current.Size;
										num3 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 == 0)
										{
											num3 = 0;
										}
										continue;
									}
									IL_0629:
									num3 = num4;
									continue;
								}
								break;
							}
							goto IL_0748;
							IL_0748:
							current = enumerator.Current;
							num3 = 3;
							goto IL_062d;
						}
					}
					finally
					{
						int num7;
						if (enumerator == null)
						{
							num7 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a != 0)
							{
								num7 = 0;
							}
							goto IL_0857;
						}
						goto IL_086d;
						IL_086d:
						enumerator.Dispose();
						num7 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b == 0)
						{
							num7 = 1;
						}
						goto IL_0857;
						IL_0857:
						switch (num7)
						{
						default:
							goto end_IL_0832;
						case 2:
							break;
						case 0:
							goto end_IL_0832;
						case 1:
							goto end_IL_0832;
						}
						goto IL_086d;
						end_IL_0832:;
					}
				case 21:
					cXt3XPoBtyHJ7bWF5Hx(regulationOperation, regulation.ElementNumberDict[XjY3C4ognvpHx9kq6Rn(bPMNFlowElement)]);
					num2 = 6;
					continue;
				case 10:
					regulationOperation.Inputs.AddRange(regulationOperation.ExternalInputs);
					num2 = 18;
					continue;
				case 1:
					regulationOperation.Connectors = bPMNFlowElement.OutputConnectors.Where((Connector a) => _003C_003Ec.vZY73gZIA0NjKBmKpruS(a.GetType(), _003C_003Ec.VZWORHZIVna0ZF40WIDu(typeof(FlowConnectorElement).TypeHandle))).ToList();
					num2 = 14;
					continue;
				}
				break;
			}
			kKudato5b38yja8PyoG(regulationOperation, Y3ue91obG8V9VrwDav6(PY7yAdotceUFyW0NaWB(bPMNFlowElement, bby2hDomXgNRxEohAQ1(process))));
			num = 9;
		}
	}

	public FlowElementOperationElementExtension()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		KTbFkdonvnb2lpbWB9C();
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

	internal static Type eoJ87uoldlPdXFwYjqZ(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool TynrhEo0QANKJIvMW4y(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static bool kiY4nbosf4u5gRpuRZV()
	{
		return RhW55mo8Sg5nfZGEU5P == null;
	}

	internal static FlowElementOperationElementExtension HRk9i1oJiMkLjfxSft1()
	{
		return RhW55mo8Sg5nfZGEU5P;
	}

	internal static void MkSC9coyl3PlCmdp1xZ(object P_0, object P_1)
	{
		((RegulationOperation)P_0).Name = (string)P_1;
	}

	internal static object bby2hDomXgNRxEohAQ1(object P_0)
	{
		return ((WorkflowProcessDTO)P_0).Diagram;
	}

	internal static object PY7yAdotceUFyW0NaWB(object P_0, object P_1)
	{
		return ((BPMNFlowElement)P_0).GetSwimlane((Diagram)P_1);
	}

	internal static object Y3ue91obG8V9VrwDav6(object P_0)
	{
		return ((Element)P_0).Name;
	}

	internal static void kKudato5b38yja8PyoG(object P_0, object P_1)
	{
		((RegulationOperation)P_0).Executor = (string)P_1;
	}

	internal static Guid XjY3C4ognvpHx9kq6Rn(object P_0)
	{
		return ((Element)P_0).Uid;
	}

	internal static void cXt3XPoBtyHJ7bWF5Hx(object P_0, long value)
	{
		((RegulationOperation)P_0).Number = value;
	}

	internal static object UQQ8Kwocyh3dXw7xkmO(object P_0)
	{
		return ((Connector)P_0).EndElement;
	}

	internal static object LVe15boPYefyBSjW9Qt(object P_0)
	{
		return ((Diagram)P_0).Elements;
	}

	internal static PointF FwVFfDoXd85qSjW83Lu(object P_0)
	{
		return ((Element2D)P_0).Location;
	}

	internal static SizeF l0orv6odKSCuK4xLawG(object P_0)
	{
		return ((Element2D)P_0).Size;
	}

	internal static void NEKlXGouJ8MQaMbNlZx(object P_0, object P_1)
	{
		((RegulationOperation)P_0).GroupName = (string)P_1;
	}

	internal static bool LfF3pWoDLrSp2FIyx89(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void KTbFkdonvnb2lpbWB9C()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
