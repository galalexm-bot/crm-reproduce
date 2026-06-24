using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Deploy.Import;

[Component]
public class ClearBeforeDelProcessContext : IClearBeforeDelEntityMetadata
{
	internal static ClearBeforeDelProcessContext sTGatd4zwqHN9COWkdV;

	public void Clear(object oldobjectMd)
	{
		//Discarded unreachable code: IL_01e9, IL_01f8
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = default(_003C_003Ec__DisplayClass0_0);
		List<IWorkflowProcess> list = default(List<IWorkflowProcess>);
		List<IProcessHeader> list2 = default(List<IProcessHeader>);
		while (true)
		{
			switch (num2)
			{
			case 8:
				return;
			case 3:
				return;
			case 7:
				return;
			case 4:
				if (_003C_003Ec__DisplayClass0_.context != null)
				{
					object obj2 = UQHjO1zZLIlB1loRT2r();
					ParameterExpression parameterExpression = (ParameterExpression)TSvD1fz8XXGA8lxnlIi(nmSp0dzvEDFS8NLxBxJ(typeof(IWorkflowProcess).TypeHandle), mNwDhVzYucWWZZOpD2i(0x13F63440 ^ 0x13F63BFA));
					list = ((AbstractNHEntityManager<IWorkflowProcess, long>)obj2).Find(Expression.Lambda<Func<IWorkflowProcess, bool>>(Expression.Equal((Expression)SqZ7eNzJeAtfLdrofL7(parameterExpression, (MethodInfo)d8Lqe8zsa7F8tSpqfnb((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)HUhAG9z0RjnFLjK6aYs(Expression.Constant(_003C_003Ec__DisplayClass0_, nmSp0dzvEDFS8NLxBxJ(typeof(_003C_003Ec__DisplayClass0_0).TypeHandle)), xK81wHzlOPelJfSbkVX((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression })).ToList();
					num2 = 10;
				}
				else
				{
					num2 = 8;
				}
				continue;
			case 6:
			{
				object obj = SWuVbgzyo92NadEvFij();
				ParameterExpression parameterExpression = (ParameterExpression)TSvD1fz8XXGA8lxnlIi(nmSp0dzvEDFS8NLxBxJ(typeof(IProcessHeader).TypeHandle), mNwDhVzYucWWZZOpD2i(0x6C7F14 ^ 0x6C70AE));
				list2 = ((AbstractNHEntityManager<IProcessHeader, long>)obj).Find(Expression.Lambda<Func<IProcessHeader, bool>>(Expression.Equal((Expression)SqZ7eNzJeAtfLdrofL7(parameterExpression, (MethodInfo)d8Lqe8zsa7F8tSpqfnb((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)HUhAG9z0RjnFLjK6aYs(OmiLUmzmiLUjW03OewW(_003C_003Ec__DisplayClass0_, nmSp0dzvEDFS8NLxBxJ(typeof(_003C_003Ec__DisplayClass0_0).TypeHandle)), xK81wHzlOPelJfSbkVX((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression })).ToList();
				num2 = 5;
				continue;
			}
			case 5:
				if (list2 == null)
				{
					num2 = 7;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae != 0)
					{
						num2 = 6;
					}
					continue;
				}
				break;
			default:
				_003C_003Ec__DisplayClass0_.context = oldobjectMd as ProcessContext;
				num2 = 4;
				continue;
			case 1:
				_003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 == 0)
				{
					num2 = 0;
				}
				continue;
			case 10:
				if (list != null)
				{
					num2 = 9;
					continue;
				}
				goto case 6;
			case 9:
				list.ForEach(delegate(IWorkflowProcess p)
				{
					int num5 = 1;
					int num6 = num5;
					while (true)
					{
						switch (num6)
						{
						default:
							return;
						case 1:
							_003C_003Ec.vuYgsTZSnpof9mCfgJYa(p, null);
							num6 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f == 0)
							{
								num6 = 0;
							}
							break;
						case 0:
							return;
						}
					}
				});
				num2 = 6;
				continue;
			case 2:
				break;
			}
			list2.ForEach(delegate(IProcessHeader p)
			{
				int num3 = 1;
				int num4 = num3;
				while (true)
				{
					switch (num4)
					{
					default:
						return;
					case 1:
						_003C_003Ec.IKMDvBZSHa54jmUvr4R4(p, null);
						num4 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 != 0)
						{
							num4 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			});
			num2 = 3;
		}
	}

	public ClearBeforeDelProcessContext()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		LdPt0kztAieHbho4wSZ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object UQHjO1zZLIlB1loRT2r()
	{
		return WorkflowProcessManager.Instance;
	}

	internal static Type nmSp0dzvEDFS8NLxBxJ(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object mNwDhVzYucWWZZOpD2i(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object TSvD1fz8XXGA8lxnlIi(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object d8Lqe8zsa7F8tSpqfnb(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object SqZ7eNzJeAtfLdrofL7(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static object xK81wHzlOPelJfSbkVX(RuntimeFieldHandle P_0)
	{
		return FieldInfo.GetFieldFromHandle(P_0);
	}

	internal static object HUhAG9z0RjnFLjK6aYs(object P_0, object P_1)
	{
		return Expression.Field((Expression)P_0, (FieldInfo)P_1);
	}

	internal static object SWuVbgzyo92NadEvFij()
	{
		return ProcessHeaderManager.Instance;
	}

	internal static object OmiLUmzmiLUjW03OewW(object P_0, Type P_1)
	{
		return Expression.Constant(P_0, P_1);
	}

	internal static bool LIc3mazKXvkQkLWuj5F()
	{
		return sTGatd4zwqHN9COWkdV == null;
	}

	internal static ClearBeforeDelProcessContext IDmQmpzOMdFmk6uyP3B()
	{
		return sTGatd4zwqHN9COWkdV;
	}

	internal static void LdPt0kztAieHbho4wSZ()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
