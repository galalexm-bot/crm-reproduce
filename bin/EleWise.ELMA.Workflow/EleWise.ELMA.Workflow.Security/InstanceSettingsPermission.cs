using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Security;

[Component]
public class InstanceSettingsPermission : InstanceSettingsPermissionBase<IProcessHeader, IProcessHeaderAccess>
{
	private static InstanceSettingsPermission rF86T8lixmcTENV8NkJ;

	public override bool Filtering => false;

	public InstanceSettingsPermission()
	{
		//Discarded unreachable code: IL_0077, IL_007c
		rKMkHKlrZcksDW2vT1g();
		ParameterExpression parameterExpression = (ParameterExpression)UA8d6qlNeN1KdFaC6WU(diu682lem0PHx4dpckg(typeof(IProcessHeaderAccess).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1712492721 ^ -1712501371));
		base._002Ector(Expression.Lambda<Func<IProcessHeaderAccess, IProcessHeader>>(Expression.Property(parameterExpression, (MethodInfo)gk3qQQlx0iuOZMIN47x((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected override ICollection<IProcessHeaderAccess> GetPermissionHolderCollection(IProcessHeader target)
	{
		return (ICollection<IProcessHeaderAccess>)target.AccessSettings;
	}

	public override bool CanGrandPermissions(IUser user, object target)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return Ucdv4rl11jENQcBCIhI(dZGfIFlSXlMBPTPWiFJ(this), user, WorkflowGlobalPermissionProvider.AccessManagmentPermission);
			case 1:
				if (((ISecurityService)dZGfIFlSXlMBPTPWiFJ(this)).HasPermission(user, PermissionProvider.AccessManagmentPermission))
				{
					return true;
				}
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void rKMkHKlrZcksDW2vT1g()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static Type diu682lem0PHx4dpckg(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object UA8d6qlNeN1KdFaC6WU(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object gk3qQQlx0iuOZMIN47x(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static bool V6U6nAlI8EIpNu6SSk5()
	{
		return rF86T8lixmcTENV8NkJ == null;
	}

	internal static InstanceSettingsPermission Amg1twlaS0v1sfq5kjZ()
	{
		return rF86T8lixmcTENV8NkJ;
	}

	internal static object dZGfIFlSXlMBPTPWiFJ(object P_0)
	{
		return ((InstanceSettingsPermissionBase<IProcessHeader, IProcessHeaderAccess>)P_0).SecurityService;
	}

	internal static bool Ucdv4rl11jENQcBCIhI(object P_0, object P_1, object P_2)
	{
		return ((ISecurityService)P_0).HasPermission((IUser)P_1, (Permission)P_2);
	}
}
