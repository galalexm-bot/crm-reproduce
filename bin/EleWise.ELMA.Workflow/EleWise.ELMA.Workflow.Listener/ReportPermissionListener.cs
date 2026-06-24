using System;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Listeners;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Event;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Listeners;

[Component]
internal class ReportPermissionListener : UserGroupListener
{
	internal static ReportPermissionListener oTDZMVpWrfBdVCU5OkJ;

	public override void DeletePermissions(PreDeleteEvent @event)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
			{
				ParameterExpression parameterExpression = (ParameterExpression)YMVFKapqtoqI36K8ckl(typeof(IProcessHeaderAccess), OhSPXrp6xYGAG3mbNXx(-45832783 ^ -45868189));
				DeletePermission(@event, Expression.Lambda<Func<IProcessHeaderAccess, object>>((Expression)vacwEypTXAFGloGIyG1(parameterExpression, (MethodInfo)VBlfMpp3vkBKFA6fae2((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 == 0)
				{
					num2 = 1;
				}
				break;
			}
			case 1:
			{
				ParameterExpression parameterExpression = Expression.Parameter(e1as93pQgOiINatGr3b(typeof(IProcessHeaderPermission).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--296112178 ^ 0x11A6EEE0));
				DeletePermission(@event, Expression.Lambda<Func<IProcessHeaderPermission, object>>((Expression)vacwEypTXAFGloGIyG1(parameterExpression, (MethodInfo)VBlfMpp3vkBKFA6fae2((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 == 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	public ReportPermissionListener()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		FmSFYeppah5rUuJiv9j();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object OhSPXrp6xYGAG3mbNXx(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object YMVFKapqtoqI36K8ckl(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object VBlfMpp3vkBKFA6fae2(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object vacwEypTXAFGloGIyG1(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static Type e1as93pQgOiINatGr3b(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool Tv55qQpjsA7NuFV4jVx()
	{
		return oTDZMVpWrfBdVCU5OkJ == null;
	}

	internal static ReportPermissionListener kd9PPXpRRUMHPUTCRJ3()
	{
		return oTDZMVpWrfBdVCU5OkJ;
	}

	internal static void FmSFYeppah5rUuJiv9j()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
