using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Extensions;

public static class LinqUtils
{
	internal static LinqUtils l6XGApG6t9722F8bdHrS;

	public static string NameOf<T>(Expression<Func<T, object>> f)
	{
		return GetMemberInfo(f).Name;
	}

	public static string NameOf<T, RT>(Expression<Func<T, RT>> f)
	{
		return GetMemberInfo(f).Name;
	}

	public static MemberInfo MemberOf<T>(Expression<Func<T, object>> f)
	{
		return GetMemberInfo(f);
	}

	public static MemberInfo MemberOf<T, RT>(Expression<Func<T, RT>> f)
	{
		return GetMemberInfo(f);
	}

	public static MemberInfo MemberOf<T>(Expression<Action<T>> f)
	{
		return GetMemberInfo(f);
	}

	private static MemberInfo GetMemberInfo(object method)
	{
		//Discarded unreachable code: IL_0069, IL_0078, IL_0099, IL_00e2, IL_0242, IL_0251
		int num = 2;
		int num2 = num;
		MemberExpression memberExpression = default(MemberExpression);
		MemberInfo memberInfo = default(MemberInfo);
		LambdaExpression lambdaExpression = default(LambdaExpression);
		MethodCallExpression methodCallExpression = default(MethodCallExpression);
		while (true)
		{
			switch (num2)
			{
			case 11:
				if (memberExpression != null)
				{
					num2 = 17;
					break;
				}
				goto case 8;
			case 7:
			case 12:
			case 14:
			case 16:
				if (memberInfo == null)
				{
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
					{
						num2 = 0;
					}
					break;
				}
				return memberInfo;
			case 17:
				memberInfo = (MemberInfo)FsKFNaG6AHB4kT4ehweY(memberExpression);
				num2 = 14;
				break;
			case 1:
				if (lambdaExpression != null)
				{
					num2 = 6;
					break;
				}
				goto case 15;
			default:
				if (methodCallExpression == null)
				{
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 5;
			case 2:
				lambdaExpression = method as LambdaExpression;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				memberInfo = methodCallExpression.Method;
				num2 = 16;
				break;
			case 13:
				methodCallExpression = f9ujHBG6m98wfZCdH3vn((UnaryExpression)T32SXkG6xiCEEZkxqWao(lambdaExpression)) as MethodCallExpression;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
				{
					num2 = 0;
				}
				break;
			case 8:
				if (stwYXZG67gCWvx0U5aNY(lambdaExpression.Body) == ExpressionType.Call)
				{
					num2 = 4;
					break;
				}
				goto case 3;
			case 10:
				throw new ArgumentException((string)XRQikAG66X35QdD14WUw(-867826612 ^ -867755686));
			case 3:
				if (stwYXZG67gCWvx0U5aNY(T32SXkG6xiCEEZkxqWao(lambdaExpression)) == ExpressionType.Convert)
				{
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
					{
						num2 = 13;
					}
					break;
				}
				goto case 7;
			case 9:
				memberExpression = (MemberExpression)A5D1KeG6HpaJMNRrHvQR(lambdaExpression);
				num2 = 11;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
				{
					num2 = 9;
				}
				break;
			case 15:
				throw new ArgumentNullException((string)XRQikAG66X35QdD14WUw(0x2ACE37D ^ 0x2ADFE6B));
			case 6:
				memberInfo = null;
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				memberInfo = (MemberInfo)oukiABG60IXN96ksgeIV((MethodCallExpression)T32SXkG6xiCEEZkxqWao(lambdaExpression));
				num2 = 12;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public static MemberExpression GetMemberExpression(LambdaExpression lambda)
	{
		//Discarded unreachable code: IL_009d, IL_00ac
		int num = 5;
		int num2 = num;
		MemberExpression result = default(MemberExpression);
		while (true)
		{
			switch (num2)
			{
			case 3:
				result = T32SXkG6xiCEEZkxqWao(lambda) as MemberExpression;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				if (stwYXZG67gCWvx0U5aNY(T32SXkG6xiCEEZkxqWao(lambda)) == ExpressionType.Convert)
				{
					num2 = 6;
					break;
				}
				goto case 2;
			case 5:
				result = null;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
				{
					num2 = 4;
				}
				break;
			default:
				return result;
			case 2:
				if (stwYXZG67gCWvx0U5aNY(T32SXkG6xiCEEZkxqWao(lambda)) == ExpressionType.MemberAccess)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
					{
						num2 = 3;
					}
					break;
				}
				goto default;
			case 6:
				result = f9ujHBG6m98wfZCdH3vn((UnaryExpression)T32SXkG6xiCEEZkxqWao(lambda)) as MemberExpression;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static string FullNameOf<T>(Expression<Func<T, object>> f)
	{
		return string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3CE17B75 ^ 0x3CE161B1), FillNamesOfMemberExpression(f.Body));
	}

	public static string FullNameOf<T, RT>(Expression<Func<T, RT>> f)
	{
		return string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138154820), FillNamesOfMemberExpression(f.Body));
	}

	private static IEnumerable<string> FillNamesOfMemberExpression(object expression)
	{
		switch (((Expression)expression).NodeType)
		{
		case ExpressionType.Convert:
		{
			MemberExpression memberExpression = (expression as UnaryExpression).Operand as MemberExpression;
			return FillNamesOfMemberExpression(memberExpression.Expression).Union(new string[1] { memberExpression.Member.Name });
		}
		case ExpressionType.MemberAccess:
		{
			MemberExpression memberExpression = expression as MemberExpression;
			return FillNamesOfMemberExpression(memberExpression.Expression).Union(new string[1] { memberExpression.Member.Name });
		}
		default:
			return new string[0];
		}
	}

	internal static object XRQikAG66X35QdD14WUw(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object A5D1KeG6HpaJMNRrHvQR(object P_0)
	{
		return GetMemberExpression((LambdaExpression)P_0);
	}

	internal static object FsKFNaG6AHB4kT4ehweY(object P_0)
	{
		return ((MemberExpression)P_0).Member;
	}

	internal static ExpressionType stwYXZG67gCWvx0U5aNY(object P_0)
	{
		return ((Expression)P_0).NodeType;
	}

	internal static object T32SXkG6xiCEEZkxqWao(object P_0)
	{
		return ((LambdaExpression)P_0).Body;
	}

	internal static object oukiABG60IXN96ksgeIV(object P_0)
	{
		return ((MethodCallExpression)P_0).Method;
	}

	internal static object f9ujHBG6m98wfZCdH3vn(object P_0)
	{
		return ((UnaryExpression)P_0).Operand;
	}

	internal static bool cJiEJvG6wvY0RTYkPEWB()
	{
		return l6XGApG6t9722F8bdHrS == null;
	}

	internal static LinqUtils LuMThQG64PXS1wQaR3O5()
	{
		return l6XGApG6t9722F8bdHrS;
	}
}
