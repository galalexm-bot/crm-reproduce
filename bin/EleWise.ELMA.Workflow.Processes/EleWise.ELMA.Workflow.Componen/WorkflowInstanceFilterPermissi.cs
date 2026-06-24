using System;
using EleWise.ELMA.Common.Extensions;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Security;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Components;

[Component]
public class WorkflowInstanceFilterPermissionResolver : IFilterPermissionResolver
{
	private static WorkflowInstanceFilterPermissionResolver Yey9Z9d9kLA2vBPTOQD;

	public FilterType FilterType => FilterType.SharedFilter;

	public bool SupportedType(IFilterFolder filter)
	{
		return JRG78wdjmixn6GaqjnY(WQV1cOddbRBEbGrqAxb(z1g7swdNgSRI93ukPbH(filter)), InterfaceActivator.UID<IWorkflowInstance>());
	}

	public bool HasPermission(IFilterFolder filter)
	{
		//Discarded unreachable code: IL_0075, IL_01bc, IL_01cb, IL_0234, IL_027f, IL_028e
		int num = 2;
		Guid? code = default(Guid?);
		ISecurityService serviceNotNull = default(ISecurityService);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 14:
					if (JRG78wdjmixn6GaqjnY(code.Value, WorkflowConstants.MonitorFilterCode))
					{
						num2 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_908b32727d48459090dc901d67456a14 == 0)
						{
							num2 = 5;
						}
						continue;
					}
					break;
				case 7:
				case 15:
					code = filter.Code;
					num2 = 18;
					continue;
				case 6:
					code = filter.Code;
					num2 = 17;
					continue;
				case 18:
					if (!code.HasValue)
					{
						num2 = 3;
						continue;
					}
					goto case 8;
				case 5:
					if (serviceNotNull.HasPermission(WorkflowProcessesPermissionProvider.MonitorAdminPermission))
					{
						num2 = 13;
						continue;
					}
					break;
				case 16:
					if (!wp6HOFdSRYrPLXDZOhp(serviceNotNull, WorkflowProcessesPermissionProvider.MyProcessAdminPermission))
					{
						num2 = 8;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d352efd9477f4d458f3173b66f7e626f == 0)
						{
							num2 = 15;
						}
						continue;
					}
					goto case 13;
				case 8:
					code = filter.Code;
					num2 = 2;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7ff589a2577e4ae68ceb125a419ed974 != 0)
					{
						num2 = 14;
					}
					continue;
				case 10:
					if (!JRG78wdjmixn6GaqjnY(code.Value, WorkflowConstants.MyProcessesFilterCode))
					{
						num2 = 7;
						continue;
					}
					goto case 16;
				default:
					if (code.HasValue)
					{
						num2 = 19;
						continue;
					}
					goto case 7;
				case 17:
					if (JRG78wdjmixn6GaqjnY(code.Value, WorkflowConstants.ImprovementFilterCode))
					{
						num2 = 2;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_4db1e829bcb046ad87c01fa1925cdfce == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 20;
				case 2:
					serviceNotNull = Locator.GetServiceNotNull<ISecurityService>();
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_feeb07d467ad474ea937eb4a7eec98da != 0)
					{
						num2 = 0;
					}
					continue;
				case 12:
					if (!code.HasValue)
					{
						num2 = 20;
						continue;
					}
					goto case 6;
				case 9:
					code = filter.Code;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9451b1fac1ed452e82e1cbd5a96b41fd == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					if (SupportedType(filter))
					{
						num2 = 9;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_37eee1d96f2f408eb3b01bde6c7d25e0 == 0)
						{
							num2 = 8;
						}
						continue;
					}
					return false;
				case 19:
					goto end_IL_0012;
				case 4:
					return serviceNotNull.HasPermission(WorkflowProcessesPermissionProvider.ImprovementAdminPermission);
				case 20:
					return false;
				case 13:
					return true;
				case 3:
				case 11:
					break;
				}
				code = filter.Code;
				num2 = 12;
				continue;
				end_IL_0012:
				break;
			}
			code = filter.Code;
			num = 10;
		}
	}

	public WorkflowInstanceFilterPermissionResolver()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		qoSQ8udkbOipwTC8aZG();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_b9495424a4ef4f809c30bcc362ac3faa == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object z1g7swdNgSRI93ukPbH(object P_0)
	{
		return ((IFilterFolder)P_0).ObjectsType;
	}

	internal static Guid WQV1cOddbRBEbGrqAxb(object P_0)
	{
		return ((ReferenceOnEntityType)P_0).TypeUid;
	}

	internal static bool JRG78wdjmixn6GaqjnY(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static bool GrSkLNdTJT6w0sfDdZa()
	{
		return Yey9Z9d9kLA2vBPTOQD == null;
	}

	internal static WorkflowInstanceFilterPermissionResolver XOjJvtdc5KHyS0rHTHy()
	{
		return Yey9Z9d9kLA2vBPTOQD;
	}

	internal static bool wp6HOFdSRYrPLXDZOhp(object P_0, object P_1)
	{
		return ((ISecurityService)P_0).HasPermission((Permission)P_1);
	}

	internal static void qoSQ8udkbOipwTC8aZG()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}
}
