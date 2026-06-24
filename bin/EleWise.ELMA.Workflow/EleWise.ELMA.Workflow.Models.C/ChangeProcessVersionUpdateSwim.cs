using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Swimlanes;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Models.ChangeProcessVersion;

public class ChangeProcessVersionUpdateSwimlaneBindingAction : IChangeProcessVersionAction
{
	private IWorkflowInstance instance;

	private Guid swimlaneUid;

	private IUser newExecutor;

	internal static ChangeProcessVersionUpdateSwimlaneBindingAction dYhLKNOC87GhiaVu9yat;

	public ChangeProcessVersionUpdateSwimlaneBindingAction(IWorkflowInstance instance, Guid swimlaneUid, IUser newExecutor)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		slusaIOCl1LhV60C2k07();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				this.instance = instance;
				num = 3;
				break;
			case 1:
				return;
			case 2:
				this.newExecutor = newExecutor;
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b != 0)
				{
					num = 1;
				}
				break;
			case 3:
				this.swimlaneUid = swimlaneUid;
				num = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 == 0)
				{
					num = 2;
				}
				break;
			}
		}
	}

	public void Execute()
	{
		//Discarded unreachable code: IL_00a9
		int num = 6;
		int num2 = num;
		SwimlaneElement swimlaneElement = default(SwimlaneElement);
		IWorkflowSwimlaneExecutor workflowSwimlaneExecutor = default(IWorkflowSwimlaneExecutor);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 7:
				hma08QOCgQ9YccwHdiTQ(EUD0KVOC5rRbdx0esxVa(instance), swimlaneElement.ExecuterProperty, null);
				num2 = 4;
				break;
			case 3:
				if (swimlaneElement != null)
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			case 5:
				if (workflowSwimlaneExecutor == null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 8;
			case 0:
				return;
			case 1:
				if (y2Qf4KOCblgV9KNGqt31(QWj7FpOCtXpTjTuQOPQd(swimlaneElement), Guid.Empty))
				{
					num2 = 7;
					break;
				}
				return;
			case 6:
				workflowSwimlaneExecutor = ((IEnumerable<IWorkflowSwimlaneExecutor>)instance.SwimlaneExecutors).Where(delegate(IWorkflowSwimlaneExecutor se)
				{
					//Discarded unreachable code: IL_00cc
					int num3 = 2;
					int num4 = num3;
					Guid? guid2 = default(Guid?);
					Guid guid = default(Guid);
					while (true)
					{
						switch (num4)
						{
						case 2:
							guid2 = se.SwimlaneUid;
							num4 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
							{
								num4 = 1;
							}
							break;
						case 5:
							if (!guid2.HasValue)
							{
								num4 = 3;
								break;
							}
							if (guid2.HasValue)
							{
								num4 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e == 0)
								{
									num4 = 0;
								}
								break;
							}
							goto case 4;
						case 3:
							return false;
						case 4:
							return true;
						default:
							return bEueLPOCB7nhmtLDbTig(guid2.GetValueOrDefault(), guid);
						case 1:
							guid = swimlaneUid;
							num4 = 5;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb == 0)
							{
								num4 = 0;
							}
							break;
						}
					}
				}).FirstOrDefault();
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
				{
					num2 = 5;
				}
				break;
			case 4:
				return;
			case 8:
				M9biOkOC02Zxa5wEP114(workflowSwimlaneExecutor, newExecutor);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				swimlaneElement = ((Diagram)OaBfO2OCmppXAmjbk7Ip(tm9pBZOCySM4ImRKjDSg(instance))).Elements.FirstOrDefault((Element e) => UdFradOCc4WMFTRFcMkN(e) == swimlaneUid) as SwimlaneElement;
				num2 = 3;
				break;
			}
		}
	}

	internal static void slusaIOCl1LhV60C2k07()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool NX7j1hOCsYrEmGq43R2i()
	{
		return dYhLKNOC87GhiaVu9yat == null;
	}

	internal static ChangeProcessVersionUpdateSwimlaneBindingAction aITenTOCJEadTT1uuxCZ()
	{
		return dYhLKNOC87GhiaVu9yat;
	}

	internal static void M9biOkOC02Zxa5wEP114(object P_0, object P_1)
	{
		((IWorkflowSwimlaneExecutor)P_0).User = (IUser)P_1;
	}

	internal static object tm9pBZOCySM4ImRKjDSg(object P_0)
	{
		return ((IWorkflowInstance)P_0).Process;
	}

	internal static object OaBfO2OCmppXAmjbk7Ip(object P_0)
	{
		return ((IWorkflowProcess)P_0).Diagram;
	}

	internal static Guid QWj7FpOCtXpTjTuQOPQd(object P_0)
	{
		return ((SwimlaneElement)P_0).ExecuterProperty;
	}

	internal static bool y2Qf4KOCblgV9KNGqt31(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object EUD0KVOC5rRbdx0esxVa(object P_0)
	{
		return ((IWorkflowInstance)P_0).Context;
	}

	internal static void hma08QOCgQ9YccwHdiTQ(object P_0, Guid P_1, object P_2)
	{
		((Entity<long>)P_0).SetPropertyValue(P_1, P_2);
	}

	internal static bool bEueLPOCB7nhmtLDbTig(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static Guid UdFradOCc4WMFTRFcMkN(object P_0)
	{
		return ((Element)P_0).Uid;
	}
}
