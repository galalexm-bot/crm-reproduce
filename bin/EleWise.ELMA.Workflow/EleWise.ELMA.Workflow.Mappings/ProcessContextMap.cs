using System;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.Runtime.NH.CustomTypes;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode.Impl.CustomizersImpl;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Mappings;

internal class ProcessContextMap : JoinedSubclassMapping<ProcessContext>
{
	private static ProcessContextMap e5qcRTv6W4b2BpOkIlt;

	public ProcessContextMap()
	{
		//Discarded unreachable code: IL_001a, IL_001f
		xNe91HvT3jcOQjGBUqr();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				ylrlQRvQmjQwie5R7vB(this, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x438A0E43 ^ 0x438A01D9));
				num = 4;
				break;
			case 3:
				WLTj5Evp21e8v4mWEXD(this, true);
				num = 6;
				break;
			case 4:
				((JoinedSubclassCustomizer<ProcessContext>)(object)this).Key((Action<IKeyMapper<ProcessContext>>)delegate(IKeyMapper<ProcessContext> k)
				{
					((IColumnsMapper)k).Column(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-148495695 ^ -148478921));
				});
				num = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
				{
					num = 2;
				}
				break;
			case 6:
			{
				ParameterExpression parameterExpression = (ParameterExpression)R4OkEtvMtXZnJyE1c25(typeof(ProcessContext), awg68lvCxhDb1D2VdQJ(0x63D6C913 ^ 0x63D6C6A9));
				((PropertyContainerCustomizer<ProcessContext>)(object)this).Property<string>(Expression.Lambda<Func<ProcessContext, string>>((Expression)oLcyCRvU1gn5DoYlNOW(parameterExpression, (MethodInfo)yR1LOhvkPI5d53BV6xk((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IPropertyMapper>)delegate(IPropertyMapper p)
				{
					int num4 = 1;
					int num5 = num4;
					while (true)
					{
						switch (num5)
						{
						default:
							return;
						case 1:
							_003C_003Ec.jlcHC2ZLufMGxCNZ6yid(p, int.MaxValue);
							num5 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 != 0)
							{
								num5 = 0;
							}
							break;
						case 0:
							return;
						}
					}
				});
				num = 5;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b == 0)
				{
					num = 1;
				}
				break;
			}
			case 5:
			{
				ParameterExpression parameterExpression = (ParameterExpression)R4OkEtvMtXZnJyE1c25(ccdcwIvVqaOCVblJ9nP(typeof(ProcessContext).TypeHandle), awg68lvCxhDb1D2VdQJ(-1214182792 ^ -1214183998));
				((PropertyContainerCustomizer<ProcessContext>)(object)this).Property<byte[]>(Expression.Lambda<Func<ProcessContext, byte[]>>((Expression)oLcyCRvU1gn5DoYlNOW(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IPropertyMapper>)delegate(IPropertyMapper p)
				{
					int num2 = 1;
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						case 1:
							p.Length(int.MaxValue);
							num3 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede == 0)
							{
								num3 = 0;
							}
							break;
						default:
							p.Type<FixedBinaryUserType>();
							num3 = 2;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 == 0)
							{
								num3 = 0;
							}
							break;
						case 2:
							return;
						}
					}
				});
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede != 0)
				{
					num = 1;
				}
				break;
			}
			case 1:
			{
				ParameterExpression parameterExpression = Expression.Parameter(ccdcwIvVqaOCVblJ9nP(typeof(ProcessContext).TypeHandle), (string)awg68lvCxhDb1D2VdQJ(-106528299 ^ -106525073));
				((PropertyContainerCustomizer<ProcessContext>)(object)this).Property<byte[]>(Expression.Lambda<Func<ProcessContext, byte[]>>((Expression)oLcyCRvU1gn5DoYlNOW(parameterExpression, (MethodInfo)yR1LOhvkPI5d53BV6xk((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IPropertyMapper>)delegate(IPropertyMapper p)
				{
					int num6 = 1;
					int num7 = num6;
					while (true)
					{
						switch (num7)
						{
						default:
							p.Type<FixedBinaryUserType>();
							num7 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 != 0)
							{
								num7 = 2;
							}
							break;
						case 1:
							p.Length(int.MaxValue);
							num7 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 == 0)
							{
								num7 = 0;
							}
							break;
						case 2:
							return;
						}
					}
				});
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f == 0)
				{
					num = 0;
				}
				break;
			}
			}
		}
	}

	internal static void xNe91HvT3jcOQjGBUqr()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static void ylrlQRvQmjQwie5R7vB(object P_0, object P_1)
	{
		((JoinedSubclassCustomizer<ProcessContext>)P_0).Table((string)P_1);
	}

	internal static void WLTj5Evp21e8v4mWEXD(object P_0, bool P_1)
	{
		((JoinedSubclassCustomizer<ProcessContext>)P_0).Lazy(P_1);
	}

	internal static object awg68lvCxhDb1D2VdQJ(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object R4OkEtvMtXZnJyE1c25(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object yR1LOhvkPI5d53BV6xk(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object oLcyCRvU1gn5DoYlNOW(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static Type ccdcwIvVqaOCVblJ9nP(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool BGImSsvqmuKSY1SiUat()
	{
		return e5qcRTv6W4b2BpOkIlt == null;
	}

	internal static ProcessContextMap YA7pVrv3GccqV2m2xXE()
	{
		return e5qcRTv6W4b2BpOkIlt;
	}
}
