using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace Microsoft.Web.Mvc.ExpressionUtil;

internal sealed class HoistingExpressionVisitor<TIn, TOut> : ExpressionVisitor
{
	private static readonly ParameterExpression _hoistedConstantsParamExpr;

	private int _numConstantsProcessed;

	private static object j1YFhGoC35H8ETTao8p;

	private HoistingExpressionVisitor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public static Expression<Hoisted<TIn, TOut>> Hoist(Expression<Func<TIn, TOut>> expr)
	{
		return Expression.Lambda<Hoisted<TIn, TOut>>(new HoistingExpressionVisitor<TIn, TOut>().Visit(expr.Body), new ParameterExpression[2]
		{
			expr.Parameters[0],
			_hoistedConstantsParamExpr
		});
	}

	protected override Expression VisitConstant(ConstantExpression node)
	{
		return Expression.Convert(Expression.Property(_hoistedConstantsParamExpr, z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 0x548BA7E4), Expression.Constant(_numConstantsProcessed++)), node.Type);
	}

	static HoistingExpressionVisitor()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				_hoistedConstantsParamExpr = Expression.Parameter(typeof(List<object>), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-957824448 ^ -957822150));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static bool fbtnQNovIINKpVKEyOn()
	{
		return j1YFhGoC35H8ETTao8p == null;
	}

	internal static object ib3eVMo8NFYusEpmFQV()
	{
		return j1YFhGoC35H8ETTao8p;
	}
}
