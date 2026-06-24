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

internal class ProcessInstanceMetricsContainerMap : JoinedSubclassMapping<ProcessInstanceMetricsContainer>
{
	private static ProcessInstanceMetricsContainerMap HeNcg8Y0PUHwQrPK6XZ;

	public ProcessInstanceMetricsContainerMap()
	{
		//Discarded unreachable code: IL_001a
		yGyoicYtU2ZhCBpSNmG();
		base._002Ector();
		int num = 5;
		while (true)
		{
			ParameterExpression parameterExpression;
			switch (num)
			{
			case 5:
			{
				mXXVZ6Y5mdMythVeEJ5(this, NpsmQqYbUMTwrn4iZ0P(-1050383744 ^ -1050379586));
				int num2 = 4;
				num = num2;
				continue;
			}
			case 2:
				return;
			case 1:
				KhkGl4YguYXkpVb2Idj(this, true);
				num = 3;
				continue;
			case 4:
				((JoinedSubclassCustomizer<ProcessInstanceMetricsContainer>)(object)this).Key((Action<IKeyMapper<ProcessInstanceMetricsContainer>>)delegate(IKeyMapper<ProcessInstanceMetricsContainer> k)
				{
					((IColumnsMapper)k).Column(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-684210684 ^ -684228478));
				});
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 == 0)
				{
					num = 1;
				}
				continue;
			case 3:
				parameterExpression = (ParameterExpression)FDyDAMYckKkRNjUrXEK(OJBSBOYBtM5Vr9wCZMq(typeof(ProcessInstanceMetricsContainer).TypeHandle), NpsmQqYbUMTwrn4iZ0P(-148495695 ^ -148493045));
				((PropertyContainerCustomizer<ProcessInstanceMetricsContainer>)(object)this).Property<string>(Expression.Lambda<Func<ProcessInstanceMetricsContainer, string>>(Expression.Property(parameterExpression, (MethodInfo)mX2UdgYPL6qLAFGMkPl((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IPropertyMapper>)delegate(IPropertyMapper p)
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
							p.Length(int.MaxValue);
							num6 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f == 0)
							{
								num6 = 0;
							}
							break;
						case 0:
							return;
						}
					}
				});
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd != 0)
				{
					num = 0;
				}
				continue;
			}
			parameterExpression = (ParameterExpression)FDyDAMYckKkRNjUrXEK(OJBSBOYBtM5Vr9wCZMq(typeof(ProcessInstanceMetricsContainer).TypeHandle), NpsmQqYbUMTwrn4iZ0P(0x1EA50FCC ^ 0x1EA50076));
			((PropertyContainerCustomizer<ProcessInstanceMetricsContainer>)(object)this).Property<byte[]>(Expression.Lambda<Func<ProcessInstanceMetricsContainer, byte[]>>((Expression)i42rkKYXuHxfVQkNvcb(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IPropertyMapper>)delegate(IPropertyMapper p)
			{
				int num3 = 1;
				int num4 = num3;
				while (true)
				{
					switch (num4)
					{
					default:
						p.Type<FixedBinaryUserType>();
						num4 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 != 0)
						{
							num4 = 2;
						}
						break;
					case 2:
						return;
					case 1:
						_003C_003Ec.hYjnojZL2ex3GS6jiPVp(p, int.MaxValue);
						num4 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 == 0)
						{
							num4 = 0;
						}
						break;
					}
				}
			});
			num = 2;
		}
	}

	internal static void yGyoicYtU2ZhCBpSNmG()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static object NpsmQqYbUMTwrn4iZ0P(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void mXXVZ6Y5mdMythVeEJ5(object P_0, object P_1)
	{
		((JoinedSubclassCustomizer<ProcessInstanceMetricsContainer>)P_0).Table((string)P_1);
	}

	internal static void KhkGl4YguYXkpVb2Idj(object P_0, bool P_1)
	{
		((JoinedSubclassCustomizer<ProcessInstanceMetricsContainer>)P_0).Lazy(P_1);
	}

	internal static Type OJBSBOYBtM5Vr9wCZMq(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object FDyDAMYckKkRNjUrXEK(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object mX2UdgYPL6qLAFGMkPl(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object i42rkKYXuHxfVQkNvcb(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static bool NsB2KJYyy9gVX64WxPc()
	{
		return HeNcg8Y0PUHwQrPK6XZ == null;
	}

	internal static ProcessInstanceMetricsContainerMap FdjxVMYmgoc3GdohUWU()
	{
		return HeNcg8Y0PUHwQrPK6XZ;
	}
}
