using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Connectors;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Gateways;
using EleWise.ELMA.Workflow.Diagrams.Activities;
using EleWise.ELMA.Workflow.Diagrams.Activities.Gateways;
using EleWise.ELMA.Workflow.Diagrams.Activities.Helpers;
using EleWise.ELMA.Workflow.Diagrams.Elements.Gateways;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Activities.Gateways;

public class GatewayActivity : BPMNActivity<GatewayElement>, IGatewayActivity
{
	[Component]
	private class Info : IWorkflowActivityInfo
	{
		private static object ur1MfAvLrCGGEk51BS5G;

		public Type ActivityType => Bm8MpavLx68k6tfsawvO(typeof(GatewayActivity).TypeHandle);

		public Type DiagramElementType => typeof(GatewayElement);

		public Info()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			tWMOglvLSNyhr3paH7IB();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static Type Bm8MpavLx68k6tfsawvO(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static void tWMOglvLSNyhr3paH7IB()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}

		internal static bool wbxXn9vLeKs5sgHgHf2u()
		{
			return ur1MfAvLrCGGEk51BS5G == null;
		}

		internal static Info eoTHLbvLN0Gf4N1jJ9qJ()
		{
			return (Info)ur1MfAvLrCGGEk51BS5G;
		}
	}

	internal static GatewayActivity D0DTJMZPPnHwFrEigGgT;

	public GatewayStartType GatewayStartType => fjQsI3ZPuuxLVaOWVnIl(base.Element);

	public GatewayType GatewayType
	{
		get
		{
			//Discarded unreachable code: IL_0035, IL_0044, IL_0053
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (base.Element is InclusiveGatewayElement)
					{
						num2 = 3;
						break;
					}
					goto case 4;
				case 4:
					return GatewayType.And;
				case 3:
					return GatewayType.Or;
				default:
					return GatewayType.Xor;
				case 1:
					if (base.Element is ExclusiveGatewayElement)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				}
			}
		}
	}

	public Guid PairGatewayUid => JlV6oPZPDE9ZC1CnPLB0(base.Element);

	protected override void Execute(NativeActivityContext context)
	{
		//Discarded unreachable code: IL_00ad, IL_00bc, IL_00cb, IL_0196, IL_01a4, IL_027b, IL_028e, IL_029d, IL_02c4, IL_02d3, IL_02de, IL_03ef, IL_0425, IL_0438, IL_04a4, IL_053e, IL_054d, IL_0584, IL_0593, IL_05c6, IL_05d5
		int num = 7;
		int num2 = num;
		List<Guid> list = default(List<Guid>);
		FlowConnectorElement flowConnectorElement2 = default(FlowConnectorElement);
		List<FlowConnectorElement> orderedFlows = default(List<FlowConnectorElement>);
		List<Connector>.Enumerator enumerator = default(List<Connector>.Enumerator);
		List<Connector> outputFlows = default(List<Connector>);
		Connector current2 = default(Connector);
		List<FlowConnectorElement>.Enumerator enumerator2 = default(List<FlowConnectorElement>.Enumerator);
		FlowConnectorElement current = default(FlowConnectorElement);
		IWorkflowInstance workflowInstance = default(IWorkflowInstance);
		object gatewayVar = default(object);
		FlowConnectorElement flowConnectorElement = default(FlowConnectorElement);
		while (true)
		{
			switch (num2)
			{
			case 16:
				list.Add(((Element)n9LsJZZPHUBqUIFhFXnN(flowConnectorElement2)).Uid);
				num2 = 24;
				break;
			case 17:
				if (DwFp38ZPjFFlhOIHcHnv(orderedFlows) != 0)
				{
					num2 = 12;
					break;
				}
				goto case 28;
			case 2:
				if (!(base.Element is ParallelGatewayElement))
				{
					num2 = 4;
					break;
				}
				goto case 11;
			case 31:
				throw new InvalidOperationException(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xA7339EE ^ 0xA71852E), aQwyRVZP9sEDDlVBVRsd(base.Element)));
			case 14:
				enumerator = outputFlows.GetEnumerator();
				num2 = 8;
				break;
			case 32:
				if (!(base.Element is ExclusiveGatewayElement))
				{
					num2 = 33;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f != 0)
					{
						num2 = 13;
					}
					break;
				}
				goto case 5;
			case 3:
				return;
			case 8:
				try
				{
					while (true)
					{
						IL_0239:
						int num5;
						if (!enumerator.MoveNext())
						{
							num5 = 3;
							goto IL_01a8;
						}
						goto IL_01f3;
						IL_01a8:
						while (true)
						{
							switch (num5)
							{
							default:
								list.Add(EHvrAHZPWJyht1eKXPD4(current2.EndElement));
								num5 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
								{
									num5 = 1;
								}
								continue;
							case 2:
								break;
							case 4:
								mKInZVZPnww39p2MjoYM(this, context, current2);
								num5 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 == 0)
								{
									num5 = 0;
								}
								continue;
							case 1:
								goto IL_0239;
							case 3:
								goto end_IL_0239;
							}
							break;
						}
						goto IL_01f3;
						IL_01f3:
						current2 = enumerator.Current;
						num5 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b != 0)
						{
							num5 = 4;
						}
						goto IL_01a8;
						continue;
						end_IL_0239:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num6 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 != 0)
					{
						num6 = 0;
					}
					switch (num6)
					{
					case 0:
						break;
					}
				}
				goto case 21;
			case 1:
				if (jDJF7iZPfYm6svbt96U9(outputFlows) != 0)
				{
					num2 = 14;
					break;
				}
				goto case 31;
			case 30:
				try
				{
					while (true)
					{
						IL_0397:
						int num3;
						if (!enumerator2.MoveNext())
						{
							num3 = 3;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c == 0)
							{
								num3 = 2;
							}
							goto IL_02e2;
						}
						goto IL_030c;
						IL_030c:
						current = enumerator2.Current;
						num3 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 == 0)
						{
							num3 = 4;
						}
						goto IL_02e2;
						IL_02e2:
						while (true)
						{
							switch (num3)
							{
							case 1:
								break;
							case 4:
								if (CheckFlowCondition(current, workflowInstance, gatewayVar))
								{
									num3 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 != 0)
									{
										num3 = 0;
									}
									continue;
								}
								goto IL_0397;
							default:
								TrackConnector(context, current);
								num3 = 2;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e != 0)
								{
									num3 = 2;
								}
								continue;
							case 6:
								if (base.Element is ExclusiveGatewayElement)
								{
									num3 = 7;
									continue;
								}
								goto IL_0397;
							case 5:
								goto IL_0397;
							case 2:
								list.Add(((Element)n9LsJZZPHUBqUIFhFXnN(current)).Uid);
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f8a84e2cb374827a50ba2cbcf11cf48 == 0)
								{
									num3 = 6;
								}
								continue;
							case 7:
								goto end_IL_0397;
							case 3:
								goto end_IL_0397;
							}
							break;
						}
						goto IL_030c;
						continue;
						end_IL_0397:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator2).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto case 29;
			case 29:
				if (list.Count != 0)
				{
					num2 = 23;
					break;
				}
				goto case 32;
			case 33:
				if (base.Element is InclusiveGatewayElement)
				{
					num2 = 5;
					break;
				}
				goto case 21;
			case 26:
				list.Add(((Element)n9LsJZZPHUBqUIFhFXnN(flowConnectorElement)).Uid);
				num2 = 21;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b == 0)
				{
					num2 = 10;
				}
				break;
			case 28:
				throw new InvalidOperationException((string)Dpq9W7ZP6SgWsn5t9pnb(wsYnxUZPRprJeHkrDIoH(-105863102 ^ -105769854), new object[1] { aQwyRVZP9sEDDlVBVRsd(base.Element) }));
			case 12:
				gatewayVar = bZYQiYZPqb9AQtRBRPuS(this, workflowInstance);
				num2 = 13;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 != 0)
				{
					num2 = 10;
				}
				break;
			default:
				mKInZVZPnww39p2MjoYM(this, context, flowConnectorElement);
				num2 = 26;
				break;
			case 7:
				if (base.Element == null)
				{
					return;
				}
				num2 = 6;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea != 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				if (DwFp38ZPjFFlhOIHcHnv(orderedFlows) > 0)
				{
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a != 0)
					{
						num2 = 9;
					}
					break;
				}
				goto case 21;
			case 13:
				enumerator2 = orderedFlows.GetEnumerator();
				num2 = 23;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd == 0)
				{
					num2 = 30;
				}
				break;
			case 25:
				flowConnectorElement2 = (FlowConnectorElement)base.Element.OutputFlows[0];
				num2 = 27;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 != 0)
				{
					num2 = 15;
				}
				break;
			case 27:
				mKInZVZPnww39p2MjoYM(this, context, flowConnectorElement2);
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f == 0)
				{
					num2 = 16;
				}
				break;
			case 15:
				list = new List<Guid>();
				num2 = 22;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 != 0)
				{
					num2 = 11;
				}
				break;
			case 21:
			case 23:
			case 24:
				base.Result.Set(context, new ActivityExecuteResult((Guid[])CwO3ErZP3Pi6ZV8i7BIf(list)));
				num2 = 3;
				break;
			case 11:
				outputFlows = base.Element.OutputFlows;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
			case 20:
				orderedFlows = GetOrderedFlows();
				num2 = 17;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd == 0)
				{
					num2 = 4;
				}
				break;
			case 34:
				flowConnectorElement = (FlowConnectorElement)base.Element.OutputFlows[0];
				num2 = 19;
				break;
			case 10:
				if (flowConnectorElement != null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 34;
			case 6:
				if (base.Element.OutputConnectors == null)
				{
					return;
				}
				num2 = 15;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 == 0)
				{
					num2 = 10;
				}
				break;
			case 18:
				workflowInstance = (IWorkflowInstance)aw0jECZPL1f2P6HlnG7l(this, context);
				num2 = 2;
				break;
			case 22:
				if (fjQsI3ZPuuxLVaOWVnIl(base.Element) == GatewayStartType.End)
				{
					num2 = 25;
					break;
				}
				goto case 18;
			case 9:
				flowConnectorElement = orderedFlows.FirstOrDefault((FlowConnectorElement f) => _003C_003Ec.KZVeyCvL4KKaFWZx4uCM(f));
				num2 = 10;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 == 0)
				{
					num2 = 4;
				}
				break;
			}
		}
	}

	protected virtual List<FlowConnectorElement> GetOrderedFlows()
	{
		List<FlowConnectorElement> list = new List<FlowConnectorElement>();
		if (base.Element.FlowsOrder != null)
		{
			using List<Guid>.Enumerator enumerator = base.Element.FlowsOrder.GetEnumerator();
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass8_0();
				CS_0024_003C_003E8__locals0.uid = enumerator.Current;
				FlowConnectorElement flowConnectorElement = (FlowConnectorElement)base.Element.OutputFlows.FirstOrDefault((Connector f) => _003C_003Ec__DisplayClass8_0.cBm40jvfYSvASX5U3XNm(_003C_003Ec__DisplayClass8_0.w970MsvfvTKBjXhvt9KG(f), CS_0024_003C_003E8__locals0.uid));
				if (flowConnectorElement != null)
				{
					list.Add(flowConnectorElement);
				}
			}
		}
		foreach (FlowConnectorElement outputFlow in base.Element.OutputFlows)
		{
			if (!list.Contains(outputFlow))
			{
				list.Add(outputFlow);
			}
		}
		return list;
	}

	protected virtual object EvalGatewayVar(IWorkflowInstance instance)
	{
		//Discarded unreachable code: IL_004a, IL_0059
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (base.WorkflowScriptingService == null)
				{
					num2 = 3;
					break;
				}
				Locator.GetServiceNotNull<IWorkflowRuntimeService>();
				num2 = 4;
				break;
			default:
				return null;
			case 1:
				if (!dIBl0yZPTK39Zpgxkmtq(base.Element))
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 4:
				return ((IWorkflowScriptingService)hgcpZDZPQaKytwtSj5vX(this)).ExecuteScript(instance, (string)mGSVgXZPpyiglv4H71Xg(base.Element), (Dictionary<string, object>)null, (Func<string, Type, object>)null);
			}
		}
	}

	protected virtual bool CheckFlowCondition(FlowConnectorElement flow, IWorkflowInstance instance, object gatewayVar)
	{
		return ConditionHelper.Evaluate((Condition)TAMlYSZPCo86Cl6rYaoL(flow), instance, new Dictionary<string, object> { 
		{
			(string)wsYnxUZPRprJeHkrDIoH(0x5DB28AD2 ^ 0x5DB2BE04),
			gatewayVar
		} });
	}

	public GatewayActivity()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		xbgPBgZPMy8RVKJkW87G();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static GatewayStartType fjQsI3ZPuuxLVaOWVnIl(object P_0)
	{
		return ((GatewayElement)P_0).GatewayStartType;
	}

	internal static bool Q9paxAZPX7wW8ZYtOY68()
	{
		return D0DTJMZPPnHwFrEigGgT == null;
	}

	internal static GatewayActivity AjxuoNZPdYgHZVptaWVU()
	{
		return D0DTJMZPPnHwFrEigGgT;
	}

	internal static Guid JlV6oPZPDE9ZC1CnPLB0(object P_0)
	{
		return ((GatewayElement)P_0).PairGatewayUid;
	}

	internal static void mKInZVZPnww39p2MjoYM(object P_0, object P_1, object P_2)
	{
		((WorkflowActivity)P_0).TrackConnector((NativeActivityContext)P_1, (Connector)P_2);
	}

	internal static object n9LsJZZPHUBqUIFhFXnN(object P_0)
	{
		return ((Connector)P_0).EndElement;
	}

	internal static object aw0jECZPL1f2P6HlnG7l(object P_0, object P_1)
	{
		return ((WorkflowActivity)P_0).GetInstance((NativeActivityContext)P_1);
	}

	internal static int jDJF7iZPfYm6svbt96U9(object P_0)
	{
		return ((List<Connector>)P_0).Count;
	}

	internal static object aQwyRVZP9sEDDlVBVRsd(object P_0)
	{
		return ((Element)P_0).Name;
	}

	internal static Guid EHvrAHZPWJyht1eKXPD4(object P_0)
	{
		return ((Element)P_0).Uid;
	}

	internal static int DwFp38ZPjFFlhOIHcHnv(object P_0)
	{
		return ((List<FlowConnectorElement>)P_0).Count;
	}

	internal static object wsYnxUZPRprJeHkrDIoH(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object Dpq9W7ZP6SgWsn5t9pnb(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static object bZYQiYZPqb9AQtRBRPuS(object P_0, object P_1)
	{
		return ((GatewayActivity)P_0).EvalGatewayVar((IWorkflowInstance)P_1);
	}

	internal static object CwO3ErZP3Pi6ZV8i7BIf(object P_0)
	{
		return ((List<Guid>)P_0).ToArray();
	}

	internal static bool dIBl0yZPTK39Zpgxkmtq(object P_0)
	{
		return ((GatewayElement)P_0).UseGatewayVar;
	}

	internal static object hgcpZDZPQaKytwtSj5vX(object P_0)
	{
		return ((BPMNActivity<GatewayElement>)P_0).WorkflowScriptingService;
	}

	internal static object mGSVgXZPpyiglv4H71Xg(object P_0)
	{
		return ((GatewayElement)P_0).GatewayScriptName;
	}

	internal static object TAMlYSZPCo86Cl6rYaoL(object P_0)
	{
		return ((FlowConnectorElement)P_0).Condition;
	}

	internal static void xbgPBgZPMy8RVKJkW87G()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
