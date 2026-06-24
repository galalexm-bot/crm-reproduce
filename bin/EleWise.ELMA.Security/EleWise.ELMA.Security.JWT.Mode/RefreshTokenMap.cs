using System;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.Runtime.NH.CustomTypes;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode.Impl.CustomizersImpl;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.JWT.Models;

internal sealed class RefreshTokenMap : ClassMapping<RefreshToken>
{
	internal static RefreshTokenMap OpmeCcgfJ2N9ItWXvCH;

	public RefreshTokenMap()
	{
		//Discarded unreachable code: IL_001a, IL_001f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		int num = 4;
		while (true)
		{
			ParameterExpression parameterExpression;
			switch (num)
			{
			case 4:
				Y9rvVh8kdRm1R5n3tdg(this, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x46347DA6 ^ 0x4634955E));
				num = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b081c717aa3147caa220888eaef123d9 == 0)
				{
					num = 0;
				}
				continue;
			case 2:
				return;
			case 5:
				parameterExpression = (ParameterExpression)RdmVXk85ywpLFOQrtdo(typeof(RefreshToken), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4A799728 ^ 0x4A79BC84));
				((PropertyContainerCustomizer<RefreshToken>)(object)this).Property<string>(Expression.Lambda<Func<RefreshToken, string>>((Expression)jTutjf8W6XrURkKFPIW(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
				num = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_07d1789322864bd7a6f8c5e113ce5c9a == 0)
				{
					num = 0;
				}
				continue;
			case 3:
				parameterExpression = (ParameterExpression)RdmVXk85ywpLFOQrtdo(GvSlSH8XpuxsuVcYc6C(typeof(RefreshToken).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x71CDF2F ^ 0x71CF483));
				((PropertyContainerCustomizer<RefreshToken>)(object)this).Property<long>(Expression.Lambda<Func<RefreshToken, long>>((Expression)jTutjf8W6XrURkKFPIW(parameterExpression, (MethodInfo)RbK7fg8AsvKr0KHNaH6((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
				num = 5;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1e79fb186de547eaaa37d66745fc7b90 == 0)
				{
					num = 4;
				}
				continue;
			case 1:
				parameterExpression = (ParameterExpression)RdmVXk85ywpLFOQrtdo(GvSlSH8XpuxsuVcYc6C(typeof(RefreshToken).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x46F7DF98 ^ 0x46F7F434));
				((PropertyContainerCustomizer<RefreshToken>)(object)this).Property<DateTime>(Expression.Lambda<Func<RefreshToken, DateTime>>((Expression)jTutjf8W6XrURkKFPIW(parameterExpression, (MethodInfo)RbK7fg8AsvKr0KHNaH6((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IPropertyMapper>)delegate(IPropertyMapper p)
				{
					p.Type<DateTimeNHType>();
				});
				num = 2;
				continue;
			}
			parameterExpression = (ParameterExpression)RdmVXk85ywpLFOQrtdo(typeof(RefreshToken), CMSBPR8pHU58q909CPo(0x417D81DE ^ 0x417DAA72));
			((ClassCustomizer<RefreshToken>)(object)this).Id<Guid>(Expression.Lambda<Func<RefreshToken, Guid>>((Expression)jTutjf8W6XrURkKFPIW(parameterExpression, (MethodInfo)RbK7fg8AsvKr0KHNaH6((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IIdMapper>)delegate(IIdMapper i)
			{
				int num2 = 1;
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					default:
						return;
					case 1:
						i.Generator((IGeneratorDef)_003C_003Ec.qyqGXLpCHn1TKAEOJqLJ());
						num3 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8ec57fd3f43f4cf7983bc996ab09feb4 != 0)
						{
							num3 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			});
			num = 3;
		}
	}

	internal static void Y9rvVh8kdRm1R5n3tdg(object P_0, object P_1)
	{
		((ClassCustomizer<RefreshToken>)P_0).Table((string)P_1);
	}

	internal static object CMSBPR8pHU58q909CPo(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object RdmVXk85ywpLFOQrtdo(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object RbK7fg8AsvKr0KHNaH6(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object jTutjf8W6XrURkKFPIW(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static Type GvSlSH8XpuxsuVcYc6C(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool yo6CsXg1Rg4UmwDqWw4()
	{
		return OpmeCcgfJ2N9ItWXvCH == null;
	}

	internal static RefreshTokenMap Aj2FkTgzdZRiOxw9ZwD()
	{
		return OpmeCcgfJ2N9ItWXvCH;
	}
}
