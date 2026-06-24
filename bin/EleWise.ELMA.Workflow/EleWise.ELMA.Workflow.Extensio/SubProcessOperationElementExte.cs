using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Artifacts;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Connectors;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.SubProcess;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;
using EleWise.ELMA.Workflow.DTO.Managers;
using EleWise.ELMA.Workflow.DTO.Models;
using EleWise.ELMA.Workflow.ExtensionPoints;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Models.Regulation;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Extensions;

[Component]
internal class SubProcessOperationElementExtension : IWorkflowRegulationOperationExtension
{
	private readonly IProcessHeaderDTOManager processHeaderDTOManager;

	private readonly IWorkflowProcessDTOManager workflowProcessDTOManager;

	private static SubProcessOperationElementExtension NHAVk1owQMs1QMT5AlQ;

	public SubProcessOperationElementExtension(IProcessHeaderDTOManager processHeaderDTOManager, IWorkflowProcessDTOManager workflowProcessDTOManager)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		XubaTXFKmIkCIWmQH4g();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				this.workflowProcessDTOManager = workflowProcessDTOManager;
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b == 0)
				{
					num = 1;
				}
				break;
			case 2:
				this.processHeaderDTOManager = processHeaderDTOManager;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 == 0)
				{
					num = 0;
				}
				break;
			case 1:
				return;
			}
		}
	}

	public bool CheckTypeElement(object obj)
	{
		return rlAr5YFZqbVQBfkdBgB(obj.GetType().BaseType, ndsOXEFOBQ5s1d7WN5s(typeof(SubProcessElement).TypeHandle));
	}

	public void GetRegulationOperationFromElement(object obj, WorkflowProcessDTO process, ref Dictionary<Guid, string> numberElemArtDict, ref RegulationOperation regulationOperation)
	{
		//Discarded unreachable code: IL_00f3, IL_0102, IL_010d, IL_0163, IL_0172, IL_01a8, IL_01b7, IL_0241, IL_0254, IL_0276, IL_0384, IL_0393, IL_04da, IL_0512, IL_0521, IL_0532, IL_0541, IL_054c, IL_060d, IL_0643, IL_0656, IL_0665, IL_06c9, IL_06d3, IL_076b, IL_077a, IL_0806, IL_0819, IL_0828, IL_0904, IL_0913, IL_091e, IL_09b3, IL_0a65, IL_0a78, IL_0a87, IL_0a97, IL_0af0
		int num = 7;
		ProcessHeaderDTO processHeaderDTO = default(ProcessHeaderDTO);
		WorkflowProcessDTO workflowProcessDTO = default(WorkflowProcessDTO);
		List<RegulationInputOutput>.Enumerator enumerator4 = default(List<RegulationInputOutput>.Enumerator);
		List<Element>.Enumerator enumerator3 = default(List<Element>.Enumerator);
		Element current2 = default(Element);
		ProcessRegulation processRegulation = default(ProcessRegulation);
		IEnumerator<ArtifactGroupElement> enumerator2 = default(IEnumerator<ArtifactGroupElement>);
		ArtifactGroupElement current = default(ArtifactGroupElement);
		PointF pointF = default(PointF);
		SubProcessElement subProcessElement = default(SubProcessElement);
		SizeF sizeF = default(SizeF);
		List<Connector>.Enumerator enumerator = default(List<Connector>.Enumerator);
		Connector current5 = default(Connector);
		RegulationInputOutput current4 = default(RegulationInputOutput);
		RegulationInputOutput current3 = default(RegulationInputOutput);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 22:
					if (processHeaderDTO != null)
					{
						num2 = 12;
						continue;
					}
					goto case 20;
				case 14:
					P5kXraFlSohh2Qmg78i(regulationOperation, ujCIl7FJBgSAAdsBMKq(workflowProcessDTO));
					num2 = 10;
					continue;
				case 1:
					enumerator4 = ((ProcessRegulation)P7vQa0FyshSMDAux3PZ(workflowProcessDTO)).Outputs.GetEnumerator();
					num2 = 9;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 != 0)
					{
						num2 = 9;
					}
					continue;
				case 11:
					workflowProcessDTO = new WorkflowProcessDTO();
					num2 = 22;
					continue;
				case 4:
					return;
				case 5:
					try
					{
						while (true)
						{
							IL_017d:
							int num8;
							if (!enumerator3.MoveNext())
							{
								num8 = 4;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d == 0)
								{
									num8 = 6;
								}
								goto IL_0111;
							}
							goto IL_013b;
							IL_013b:
							current2 = enumerator3.Current;
							num8 = 5;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b != 0)
							{
								num8 = 5;
							}
							goto IL_0111;
							IL_0111:
							while (true)
							{
								switch (num8)
								{
								case 6:
									return;
								case 3:
									break;
								case 2:
								case 4:
								case 7:
									goto IL_017d;
								default:
									if (!numberElemArtDict.ContainsKey(iNUrS1FtbEjQ9vUxXkB(current2)))
									{
										num8 = 7;
										continue;
									}
									goto case 1;
								case 5:
									if (numberElemArtDict == null)
									{
										num8 = 4;
										continue;
									}
									goto default;
								case 1:
									regulationOperation.NumbersOfArtifact.Add(numberElemArtDict[iNUrS1FtbEjQ9vUxXkB(current2)]);
									num8 = 2;
									continue;
								}
								break;
							}
							goto IL_013b;
						}
					}
					finally
					{
						((IDisposable)enumerator3).Dispose();
						int num9 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 == 0)
						{
							num9 = 0;
						}
						switch (num9)
						{
						case 0:
							break;
						}
					}
				case 15:
				case 19:
					processRegulation = (ProcessRegulation)P7vQa0FyshSMDAux3PZ(process);
					num2 = 25;
					continue;
				case 23:
					try
					{
						while (true)
						{
							IL_0359:
							int num3;
							if (!n1P0KZFXWjnOZwulDN6(enumerator2))
							{
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 != 0)
								{
									num3 = 0;
								}
								goto IL_0284;
							}
							goto IL_0426;
							IL_0426:
							current = enumerator2.Current;
							num3 = 13;
							goto IL_0284;
							IL_0284:
							while (true)
							{
								switch (num3)
								{
								case 10:
								{
									float y = pointF.Y;
									pointF = WIGogXFBsCKHtbX1inZ(subProcessElement);
									if (y <= pointF.Y)
									{
										num3 = 12;
										continue;
									}
									goto IL_0359;
								}
								case 13:
									if (current == null)
									{
										num3 = 2;
										continue;
									}
									goto case 1;
								case 4:
								{
									float x = pointF.X;
									pointF = WIGogXFBsCKHtbX1inZ(subProcessElement);
									if (x <= pointF.X)
									{
										num3 = 9;
										continue;
									}
									goto IL_0359;
								}
								case 11:
									sizeF = current.Size;
									num3 = 5;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
									{
										num3 = 7;
									}
									continue;
								case 9:
									pointF = current.Location;
									num3 = 10;
									continue;
								case 2:
								case 5:
									goto IL_0359;
								case 12:
								{
									sizeF = EZSjpSFcp995n4geaxp(current);
									int num6 = 3;
									num3 = num6;
									continue;
								}
								case 7:
								{
									float width = sizeF.Width;
									pointF = WIGogXFBsCKHtbX1inZ(current);
									float num5 = width + pointF.X;
									sizeF = EZSjpSFcp995n4geaxp(subProcessElement);
									float width2 = sizeF.Width;
									pointF = subProcessElement.Location;
									if (num5 >= width2 + pointF.X)
									{
										num3 = 6;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af != 0)
										{
											num3 = 5;
										}
										continue;
									}
									goto IL_0359;
								}
								case 6:
									oQCcNSFPEJbxihKOJwM(regulationOperation, bRU9DaF093OO6GQe06o(current));
									num3 = 5;
									continue;
								case 8:
									goto IL_0426;
								case 3:
								{
									float height = sizeF.Height;
									pointF = WIGogXFBsCKHtbX1inZ(current);
									float num4 = height + pointF.Y;
									sizeF = EZSjpSFcp995n4geaxp(subProcessElement);
									float height2 = sizeF.Height;
									pointF = subProcessElement.Location;
									if (num4 >= height2 + pointF.Y)
									{
										num3 = 11;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 == 0)
										{
											num3 = 10;
										}
										continue;
									}
									goto IL_0359;
								}
								case 1:
									pointF = WIGogXFBsCKHtbX1inZ(current);
									num3 = 4;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 == 0)
									{
										num3 = 4;
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
						if (enumerator2 != null)
						{
							int num7 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 != 0)
							{
								num7 = 0;
							}
							while (true)
							{
								switch (num7)
								{
								default:
									enumerator2.Dispose();
									num7 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c == 0)
									{
										num7 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					goto case 2;
				case 16:
					try
					{
						while (true)
						{
							IL_05b3:
							int num14;
							if (!enumerator.MoveNext())
							{
								num14 = 5;
								goto IL_0550;
							}
							goto IL_05a0;
							IL_0550:
							while (true)
							{
								switch (num14)
								{
								case 3:
									regulationOperation.Artifacts.Add(current5.EndElement);
									num14 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a == 0)
									{
										num14 = 0;
									}
									continue;
								case 4:
									break;
								default:
									goto IL_05b3;
								case 2:
									if (!rlAr5YFZqbVQBfkdBgB(current5.EndElement.GetType().BaseType, ndsOXEFOBQ5s1d7WN5s(typeof(ArtefactTaskElement).TypeHandle)))
									{
										num14 = 1;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae == 0)
										{
											num14 = 1;
										}
										continue;
									}
									goto case 3;
								case 5:
									goto end_IL_05b3;
								}
								break;
							}
							goto IL_05a0;
							IL_05a0:
							current5 = enumerator.Current;
							num14 = 2;
							goto IL_0550;
							continue;
							end_IL_05b3:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num15 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 != 0)
						{
							num15 = 0;
						}
						switch (num15)
						{
						case 0:
							break;
						}
					}
					goto case 24;
				case 2:
					enumerator = subProcessElement.OutputConnectors.GetEnumerator();
					num2 = 16;
					continue;
				case 3:
					enumerator2 = ((IEnumerable)YdGajMFgPQqsNxBxM9H(processRegulation.Diagram)).OfType<ArtifactGroupElement>().GetEnumerator();
					num2 = 23;
					continue;
				case 20:
					P5kXraFlSohh2Qmg78i(regulationOperation, bRU9DaF093OO6GQe06o(subProcessElement));
					num2 = 17;
					continue;
				case 21:
					try
					{
						while (true)
						{
							IL_0785:
							int num12;
							if (!enumerator4.MoveNext())
							{
								num12 = 7;
								goto IL_06d7;
							}
							goto IL_071a;
							IL_06d7:
							while (true)
							{
								switch (num12)
								{
								case 1:
								case 6:
									regulationOperation.Inputs.Add(current4);
									num12 = 2;
									continue;
								case 5:
									break;
								case 4:
									regulationOperation.InternalInputs.Add(current4);
									num12 = 6;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a == 0)
									{
										num12 = 2;
									}
									continue;
								case 2:
									goto IL_0785;
								default:
									if (QLP8aeFmduixHcGwHUm(current4))
									{
										num12 = 3;
										continue;
									}
									goto case 4;
								case 3:
									regulationOperation.ExternalInputs.Add(current4);
									num12 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e == 0)
									{
										num12 = 1;
									}
									continue;
								case 7:
									goto end_IL_0785;
								}
								break;
							}
							goto IL_071a;
							IL_071a:
							current4 = enumerator4.Current;
							num12 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e == 0)
							{
								num12 = 0;
							}
							goto IL_06d7;
							continue;
							end_IL_0785:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator4).Dispose();
						int num13 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 == 0)
						{
							num13 = 0;
						}
						switch (num13)
						{
						case 0:
							break;
						}
					}
					goto case 1;
				case 10:
				case 17:
					if (P7vQa0FyshSMDAux3PZ(workflowProcessDTO) == null)
					{
						num2 = 15;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 != 0)
						{
							num2 = 8;
						}
						continue;
					}
					goto case 13;
				case 7:
					subProcessElement = obj as SubProcessElement;
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede != 0)
					{
						num2 = 6;
					}
					continue;
				case 13:
					enumerator4 = ((ProcessRegulation)P7vQa0FyshSMDAux3PZ(workflowProcessDTO)).Inputs.GetEnumerator();
					num2 = 21;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e != 0)
					{
						num2 = 20;
					}
					continue;
				case 0:
					return;
				case 8:
					x4Fs5sF5OteDBcltAJD(regulationOperation, d6rAKbFbUcCwpCqCXIT(subProcessElement));
					num2 = 18;
					continue;
				case 12:
					workflowProcessDTO = (WorkflowProcessDTO)iqMj9TFsAruYuZnfQu3(workflowProcessDTOManager, jvCWMXF8funKdXScifC(processHeaderDTO));
					num2 = 14;
					continue;
				case 9:
					try
					{
						while (true)
						{
							int num10;
							if (!enumerator4.MoveNext())
							{
								num10 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
								{
									num10 = 1;
								}
								goto IL_0922;
							}
							goto IL_098b;
							IL_098b:
							current3 = enumerator4.Current;
							num10 = 3;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 == 0)
							{
								num10 = 2;
							}
							goto IL_0922;
							IL_0922:
							while (true)
							{
								switch (num10)
								{
								default:
									regulationOperation.ExternalOutputs.Add(current3);
									num10 = 6;
									continue;
								case 7:
									break;
								case 4:
									goto IL_098b;
								case 5:
									regulationOperation.InternalOutputs.Add(current3);
									num10 = 2;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 != 0)
									{
										num10 = 2;
									}
									continue;
								case 3:
									if (QLP8aeFmduixHcGwHUm(current3))
									{
										num10 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 == 0)
										{
											num10 = 0;
										}
										continue;
									}
									goto case 5;
								case 2:
								case 6:
									regulationOperation.Outputs.Add(current3);
									num10 = 7;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 == 0)
									{
										num10 = 0;
									}
									continue;
								case 1:
									goto end_IL_0965;
								}
								break;
							}
							continue;
							end_IL_0965:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator4).Dispose();
						int num11 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 == 0)
						{
							num11 = 0;
						}
						switch (num11)
						{
						case 0:
							break;
						}
					}
					goto case 15;
				case 25:
					break;
				case 6:
					if (subProcessElement != null)
					{
						processHeaderDTO = (ProcessHeaderDTO)DmuhQ3FYXpRqJrN875i(processHeaderDTOManager, pd5BR1Fv3VwvNoqd9eq(subProcessElement));
						num2 = 11;
						continue;
					}
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc == 0)
					{
						num2 = 0;
					}
					continue;
				case 24:
					enumerator3 = regulationOperation.Artifacts.GetEnumerator();
					num2 = 5;
					continue;
				case 18:
					regulationOperation.Connectors = subProcessElement.OutputConnectors.Where((Connector a) => _003C_003Ec.Rjo2FLZIxlVbKkeYyo7q(a.GetType(), _003C_003Ec.OsuqkQZINol6nH4FYUy1(typeof(FlowConnectorElement).TypeHandle))).ToList();
					num2 = 3;
					continue;
				}
				break;
			}
			regulationOperation.Number = processRegulation.ElementNumberDict[iNUrS1FtbEjQ9vUxXkB(subProcessElement)];
			num = 8;
		}
	}

	internal static void XubaTXFKmIkCIWmQH4g()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool UDlTllo4MaRvoDKK8Y5()
	{
		return NHAVk1owQMs1QMT5AlQ == null;
	}

	internal static SubProcessOperationElementExtension q8hsjZozTL0FPNMhZQm()
	{
		return NHAVk1owQMs1QMT5AlQ;
	}

	internal static Type ndsOXEFOBQ5s1d7WN5s(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool rlAr5YFZqbVQBfkdBgB(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static long pd5BR1Fv3VwvNoqd9eq(object P_0)
	{
		return ((SubProcessElement)P_0).ProcessHeaderId;
	}

	internal static object DmuhQ3FYXpRqJrN875i(object P_0, long id)
	{
		return ((IProcessHeaderDTOManager)P_0).LoadOrNull(id);
	}

	internal static long jvCWMXF8funKdXScifC(object P_0)
	{
		return ((ProcessHeaderDTO)P_0).CurrentId;
	}

	internal static object iqMj9TFsAruYuZnfQu3(object P_0, long id)
	{
		return ((IWorkflowProcessDTOManager)P_0).LoadOrNull(id);
	}

	internal static object ujCIl7FJBgSAAdsBMKq(object P_0)
	{
		return ((WorkflowProcessDTO)P_0).Name;
	}

	internal static void P5kXraFlSohh2Qmg78i(object P_0, object P_1)
	{
		((RegulationOperation)P_0).Name = (string)P_1;
	}

	internal static object bRU9DaF093OO6GQe06o(object P_0)
	{
		return ((Element)P_0).Name;
	}

	internal static object P7vQa0FyshSMDAux3PZ(object P_0)
	{
		return ((WorkflowProcessDTO)P_0).Regulation;
	}

	internal static bool QLP8aeFmduixHcGwHUm(object P_0)
	{
		return ((RegulationInputOutput)P_0).IsExternal;
	}

	internal static Guid iNUrS1FtbEjQ9vUxXkB(object P_0)
	{
		return ((Element)P_0).Uid;
	}

	internal static object d6rAKbFbUcCwpCqCXIT(object P_0)
	{
		return ((Element)P_0).Description;
	}

	internal static void x4Fs5sF5OteDBcltAJD(object P_0, object P_1)
	{
		((RegulationOperation)P_0).Description = (string)P_1;
	}

	internal static object YdGajMFgPQqsNxBxM9H(object P_0)
	{
		return ((Diagram)P_0).Elements;
	}

	internal static PointF WIGogXFBsCKHtbX1inZ(object P_0)
	{
		return ((Element2D)P_0).Location;
	}

	internal static SizeF EZSjpSFcp995n4geaxp(object P_0)
	{
		return ((Element2D)P_0).Size;
	}

	internal static void oQCcNSFPEJbxihKOJwM(object P_0, object P_1)
	{
		((RegulationOperation)P_0).GroupName = (string)P_1;
	}

	internal static bool n1P0KZFXWjnOZwulDN6(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}
}
