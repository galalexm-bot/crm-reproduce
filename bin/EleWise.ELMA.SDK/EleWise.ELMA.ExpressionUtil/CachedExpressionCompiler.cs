using System;
using System.Linq.Expressions;
using j3AmrhgkCleVTGdEwA;
using Microsoft.Web.Mvc.ExpressionUtil;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.ExpressionUtil;

public static class CachedExpressionCompiler
{
	private static readonly ParameterExpression _unusedParameterExpr;

	internal static CachedExpressionCompiler Sm8UfcGrDJiQCUvGSoVt;

	public static Func<TModel, TValue> Compile<TModel, TValue>(this Expression<Func<TModel, TValue>> lambdaExpression)
	{
		if (lambdaExpression == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CB464B ^ 0x53CF54D7));
		}
		return Microsoft.Web.Mvc.ExpressionUtil.CachedExpressionCompiler.Process(lambdaExpression);
	}

	public static object Evaluate(Expression arg)
	{
		//Discarded unreachable code: IL_0070, IL_007f
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (arg != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x35C0467B ^ 0x35C2E3F7));
			default:
				return Wrap(arg)(null);
			}
		}
	}

	private static Func<object, object> Wrap(object arg)
	{
		return Microsoft.Web.Mvc.ExpressionUtil.CachedExpressionCompiler.Process(Expression.Lambda<Func<object, object>>(Expression.Convert((Expression)arg, typeof(object)), new ParameterExpression[1] { _unusedParameterExpr }));
	}

	static CachedExpressionCompiler()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				_unusedParameterExpr = Expression.Parameter(zJKRJjGr6ZvoyGceoDK6(typeof(object).TypeHandle), (string)beVtt6GrH3gTQCWeBtDL(0x6A81B9B4 ^ 0x6A85AB74));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			case 1:
				lP2hNiGr4XCpK57mFk8O();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool mk2o76GrtdYmLdNC9ULE()
	{
		return Sm8UfcGrDJiQCUvGSoVt == null;
	}

	internal static CachedExpressionCompiler wXKuJoGrwS4wIJEipXUM()
	{
		return Sm8UfcGrDJiQCUvGSoVt;
	}

	internal static void lP2hNiGr4XCpK57mFk8O()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static Type zJKRJjGr6ZvoyGceoDK6(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object beVtt6GrH3gTQCWeBtDL(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
