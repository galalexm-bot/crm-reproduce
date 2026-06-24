using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Extensions;

public static class ExpressionExtensions
{
	internal static ExpressionExtensions hBgJUNG6hRyaPtDdvXxo;

	public static void InvokeGenericMethod<T>(this T target, Expression<Action<T>> expression, Type genericParametr) where T : class
	{
		GetInvokeMethodInfo(expression, out var _, out var methodInfo, out var arguments);
		if (!methodInfo.IsGenericMethod)
		{
			throw new ArgumentException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886650229), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x35C0467B ^ 0x35C44619));
		}
		MethodInfo methodInfo2 = methodInfo.GetGenericMethodDefinition().MakeGenericMethod(genericParametr);
		if (methodInfo.IsStatic)
		{
			if (arguments.Length != 0)
			{
				arguments[0] = target;
			}
			target = null;
		}
		methodInfo2.Invoke(target, arguments);
	}

	public static object InvokeGenericFunction<T>(this T target, Expression<Func<T, object>> expression, Type genericParametr) where T : class
	{
		GetInvokeMethodInfo(expression, out var _, out var methodInfo, out var arguments);
		if (!methodInfo.IsGenericMethod)
		{
			throw new ArgumentException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 0x51150F19), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1108654032 ^ -1108391854));
		}
		MethodInfo methodInfo2 = methodInfo.GetGenericMethodDefinition().MakeGenericMethod(genericParametr);
		if (methodInfo.IsStatic)
		{
			if (arguments.Length != 0)
			{
				arguments[0] = target;
			}
			target = null;
		}
		return methodInfo2.Invoke(target, arguments);
	}

	public static MethodInfo GetGenericMethod<T>(this T target, Expression<Action<T>> expression, Type genericParametr) where T : class
	{
		GetInvokeMethodInfo(expression, out var _, out var methodInfo, out var _);
		if (!methodInfo.IsGenericMethod)
		{
			throw new ArgumentException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-978351861 ^ -978353137), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398925506));
		}
		return methodInfo.GetGenericMethodDefinition().MakeGenericMethod(genericParametr);
	}

	public static object GetValue(this Expression expression, bool causeError)
	{
		//Discarded unreachable code: IL_0074
		int num = 5;
		int num2 = num;
		ConstantExpression constantExpression = default(ConstantExpression);
		MemberExpression memberExpression = default(MemberExpression);
		while (true)
		{
			switch (num2)
			{
			default:
				throw new ArgumentException((string)nUVtq0G6Qb1uiPIc3to9(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xA592A41 ^ 0xA5D2AF1), expression.GetType()));
			case 2:
				return G29n4JG6fPrjp0PE4SE7(constantExpression);
			case 1:
				memberExpression = expression as MemberExpression;
				num2 = 3;
				break;
			case 3:
				if (memberExpression != null)
				{
					return SKo2hJG6vojs2KWI4aOK(fNYETkG6C4ZXOGZlsWaV(memberExpression), causeError);
				}
				num2 = 6;
				break;
			case 4:
				if (constantExpression == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 6:
				if (!causeError)
				{
					return null;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				constantExpression = expression as ConstantExpression;
				num2 = 4;
				break;
			}
		}
	}

	public static void GetInvokeMethodInfo(LambdaExpression expression, out object target, out MethodInfo methodInfo, out object[] arguments)
	{
		//Discarded unreachable code: IL_007d
		int num = 2;
		MethodCallExpression methodCallExpression = default(MethodCallExpression);
		object[] array = default(object[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					methodCallExpression = expression.Body as MethodCallExpression;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					if (methodCallExpression != null)
					{
						goto end_IL_0012;
					}
					goto case 7;
				case 3:
					arguments = array;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				case 4:
					methodInfo = methodCallExpression.Method;
					num2 = 5;
					break;
				case 7:
					throw new ArgumentException((string)DJ6HUQG68ndUg1JeTkCn(0x57A5235E ^ 0x57A123B6), (string)DJ6HUQG68ndUg1JeTkCn(-1867198571 ^ -1867201903));
				case 6:
					target = methodCallExpression.Object;
					num2 = 4;
					break;
				case 5:
					array = methodCallExpression.Arguments.Select((Expression ae) => _003C_003Ec.SJSW5q8hIkyGB02iDEYQ(ae, false)).ToArray();
					num2 = 3;
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 6;
		}
	}

	internal static object G29n4JG6fPrjp0PE4SE7(object P_0)
	{
		return ((ConstantExpression)P_0).Value;
	}

	internal static object nUVtq0G6Qb1uiPIc3to9(object P_0, object P_1)
	{
		return string.Concat(P_0, P_1);
	}

	internal static object fNYETkG6C4ZXOGZlsWaV(object P_0)
	{
		return ((MemberExpression)P_0).Expression;
	}

	internal static object SKo2hJG6vojs2KWI4aOK(object P_0, bool causeError)
	{
		return ((Expression)P_0).GetValue(causeError);
	}

	internal static bool nBXA8VG6G9LHScKGpN7H()
	{
		return hBgJUNG6hRyaPtDdvXxo == null;
	}

	internal static ExpressionExtensions dxGVSBG6EgfRaXPTnne9()
	{
		return hBgJUNG6hRyaPtDdvXxo;
	}

	internal static object DJ6HUQG68ndUg1JeTkCn(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
