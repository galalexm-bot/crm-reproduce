using System;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.Runtime.NH.CustomTypes;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode.Impl.CustomizersImpl;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Models;

internal class AuthTokenMap : ClassMapping<AuthToken>
{
	private static AuthTokenMap aD4CjgKoqyfTqOPTDh1;

	public AuthTokenMap()
	{
		//Discarded unreachable code: IL_001a, IL_001f
		gdFuf8KtAH2rDVcaHPt();
		base._002Ector();
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			case 1:
			{
				ParameterExpression parameterExpression = (ParameterExpression)NX4iqKKqqy6mLnrnGbN(OFctNbKOHqaG57oexgp(typeof(AuthToken).TypeHandle), Vjhi54KhsJkd2rSBVHv(-1084772212 ^ -1084777696));
				((PropertyContainerCustomizer<AuthToken>)(object)this).Property<long>(Expression.Lambda<Func<AuthToken, long>>(Expression.Property(parameterExpression, (MethodInfo)pGdRSjKcQdKGBQJC8oW((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
				num = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4ca2baab70e44d2ca8271afba4c9a72d != 0)
				{
					num = 0;
				}
				break;
			}
			case 3:
				((ClassCustomizer<AuthToken>)(object)this).Table((string)Vjhi54KhsJkd2rSBVHv(-1889123947 ^ -1889125713));
				num = 4;
				break;
			case 4:
			{
				ParameterExpression parameterExpression = (ParameterExpression)NX4iqKKqqy6mLnrnGbN(OFctNbKOHqaG57oexgp(typeof(AuthToken).TypeHandle), Vjhi54KhsJkd2rSBVHv(-76932334 ^ -76926786));
				((ClassCustomizer<AuthToken>)(object)this).Id<Guid>(Expression.Lambda<Func<AuthToken, Guid>>(Expression.Property(parameterExpression, (MethodInfo)pGdRSjKcQdKGBQJC8oW((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IIdMapper>)delegate(IIdMapper i)
				{
					int num2 = 1;
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						default:
							return;
						case 0:
							return;
						case 1:
							_003C_003Ec.FcCZ4SpLfQfsvlNCOYQe(i, _003C_003Ec.dSNRaFpL98cGsm4mkFAq());
							num3 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3e35bb8d9f5b4a1d9826edea4d9dca96 != 0)
							{
								num3 = 0;
							}
							break;
						}
					}
				});
				num = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c843c5b509d748f086ceb6be01690351 == 0)
				{
					num = 1;
				}
				break;
			}
			default:
			{
				ParameterExpression parameterExpression = Expression.Parameter(typeof(AuthToken), (string)Vjhi54KhsJkd2rSBVHv(0x38328F00 ^ 0x3832A4AC));
				((PropertyContainerCustomizer<AuthToken>)(object)this).Property<DateTime>(Expression.Lambda<Func<AuthToken, DateTime>>((Expression)riDir5KG7tpm8Pjr0jf(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IPropertyMapper>)delegate(IPropertyMapper p)
				{
					p.Type<DateTimeNHType>();
				});
				num = 2;
				break;
			}
			}
		}
	}

	internal static void gdFuf8KtAH2rDVcaHPt()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static object Vjhi54KhsJkd2rSBVHv(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Type OFctNbKOHqaG57oexgp(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object NX4iqKKqqy6mLnrnGbN(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object pGdRSjKcQdKGBQJC8oW(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object riDir5KG7tpm8Pjr0jf(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static bool nj2EBjKJjJFRS5aP9ky()
	{
		return aD4CjgKoqyfTqOPTDh1 == null;
	}

	internal static AuthTokenMap Q50yMFKKgdWSgVFZux1()
	{
		return aD4CjgKoqyfTqOPTDh1;
	}
}
