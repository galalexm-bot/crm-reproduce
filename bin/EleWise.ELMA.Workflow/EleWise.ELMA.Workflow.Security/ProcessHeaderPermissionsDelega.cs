using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Security;

[Component]
public class ProcessHeaderPermissionsDelegate : IPermissionsDelegate
{
	private readonly ProcessHeaderManager processHeaderManager;

	private readonly List<Guid> supportedPermissions;

	internal static ProcessHeaderPermissionsDelegate XrfaQn0AOhdqvgWHyxd;

	public ProcessHeaderPermissionsDelegate(ProcessHeaderManager processHeaderManager)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		UIoCap02eJWxIedqg8O();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 == 0)
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
				this.processHeaderManager = processHeaderManager;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 == 0)
				{
					num = 0;
				}
				break;
			default:
				supportedPermissions = WorkflowPermissionProvider.GetPermissionUids();
				num = 2;
				break;
			}
		}
	}

	public bool CanCheckPermissions(Type type, Permission permission)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return supportedPermissions.Contains(o9od680FYio7Splqd3q(permission));
			case 1:
				if (permission != null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto IL_003a;
			default:
				{
					if (BRrbsW0ojXmGZjdIpdf(typeof(IProcessHeader).TypeHandle).IsAssignableFrom(type))
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 != 0)
						{
							num2 = 2;
						}
						break;
					}
					goto IL_003a;
				}
				IL_003a:
				return false;
			}
		}
	}

	public bool HasPermission(EleWise.ELMA.Security.IUser user, Permission permission, object target, bool skipAdmin = false)
	{
		int num = 1;
		int num2 = num;
		IProcessHeader processHeader = default(IProcessHeader);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return false;
			case 1:
				processHeader = target as IProcessHeader;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				if (!zCAMRT0ilouSTSP4XF5(permission, null))
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 3;
			case 2:
				if (supportedPermissions.Contains(o9od680FYio7Splqd3q(permission)))
				{
					return processHeaderManager.HasPermission(processHeader, permission, (EleWise.ELMA.Security.Models.IUser)user);
				}
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f != 0)
				{
					num2 = 3;
				}
				break;
			default:
				if (processHeader != null)
				{
					num2 = 4;
					break;
				}
				goto case 3;
			}
		}
	}

	internal static void UIoCap02eJWxIedqg8O()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool wo9HvF0G4uyQeMInsB4()
	{
		return XrfaQn0AOhdqvgWHyxd == null;
	}

	internal static ProcessHeaderPermissionsDelegate ML4IUf078nniDf2spen()
	{
		return XrfaQn0AOhdqvgWHyxd;
	}

	internal static Type BRrbsW0ojXmGZjdIpdf(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static Guid o9od680FYio7Splqd3q(object P_0)
	{
		return ((Permission)P_0).Id;
	}

	internal static bool zCAMRT0ilouSTSP4XF5(object P_0, object P_1)
	{
		return (Permission)P_0 == (Permission)P_1;
	}
}
