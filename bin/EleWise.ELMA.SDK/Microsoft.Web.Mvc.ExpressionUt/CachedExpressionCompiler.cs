using System;
using System.Collections.Concurrent;
using System.Linq.Expressions;
using System.Reflection;
using j3AmrhgkCleVTGdEwA;

namespace Microsoft.Web.Mvc.ExpressionUtil;

internal static class CachedExpressionCompiler
{
	private static class Compiler<TIn, TOut>
	{
		private static readonly ConcurrentDictionary<MemberInfo, Func<TIn, TOut>> _simpleMemberAccessDict;

		private static readonly ConcurrentDictionary<MemberInfo, Func<object, TOut>> _constMemberAccessDict;

		private static readonly ConcurrentDictionary<ExpressionFingerprintChain, Hoisted<TIn, TOut>> _fingerprintedCache;

		private static Func<TIn, TOut> _identityFunc;

		private static object b7jaSkf4m89bwDS9nJb4;

		public static Func<TIn, TOut> Compile(Expression<Func<TIn, TOut>> expr)
		{
			return CompileFromIdentityFunc(expr) ?? CompileFromConstLookup(expr) ?? CompileFromMemberAccess(expr) ?? CompileFromFingerprint(expr) ?? CompileSlow(expr);
		}

		private static Func<TIn, TOut> CompileFromConstLookup(Expression<Func<TIn, TOut>> expr)
		{
			_003C_003Ec__DisplayClass5_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass5_0();
			if (!(expr.Body is ConstantExpression constantExpression))
			{
				return null;
			}
			CS_0024_003C_003E8__locals0.constantValue = (TOut)constantExpression.Value;
			return (TIn _) => CS_0024_003C_003E8__locals0.constantValue;
		}

		private static Func<TIn, TOut> CompileFromIdentityFunc(Expression<Func<TIn, TOut>> expr)
		{
			if (expr.Body != expr.Parameters[0])
			{
				return null;
			}
			if (_identityFunc == null)
			{
				_identityFunc = expr.Compile();
			}
			return _identityFunc;
		}

		private static Func<TIn, TOut> CompileFromFingerprint(Expression<Func<TIn, TOut>> expr)
		{
			_003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass7_0();
			CS_0024_003C_003E8__locals0.expr = expr;
			ExpressionFingerprintChain fingerprintChain = FingerprintingExpressionVisitor.GetFingerprintChain(CS_0024_003C_003E8__locals0.expr, out CS_0024_003C_003E8__locals0.capturedConstants);
			if (fingerprintChain == null)
			{
				return null;
			}
			CS_0024_003C_003E8__locals0.del = _fingerprintedCache.GetOrAdd(fingerprintChain, (ExpressionFingerprintChain _) => HoistingExpressionVisitor<TIn, TOut>.Hoist(CS_0024_003C_003E8__locals0.expr).Compile());
			return (TIn model) => CS_0024_003C_003E8__locals0.del(model, CS_0024_003C_003E8__locals0.capturedConstants);
		}

		private static Func<TIn, TOut> CompileFromMemberAccess(Expression<Func<TIn, TOut>> expr)
		{
			_003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass8_0();
			CS_0024_003C_003E8__locals0.expr = expr;
			CS_0024_003C_003E8__locals0.memberExpr = CS_0024_003C_003E8__locals0.expr.Body as MemberExpression;
			if (CS_0024_003C_003E8__locals0.memberExpr != null)
			{
				if (CS_0024_003C_003E8__locals0.memberExpr.Expression == CS_0024_003C_003E8__locals0.expr.Parameters[0] || CS_0024_003C_003E8__locals0.memberExpr.Expression == null)
				{
					return _simpleMemberAccessDict.GetOrAdd(CS_0024_003C_003E8__locals0.memberExpr.Member, (MemberInfo _) => CS_0024_003C_003E8__locals0.expr.Compile());
				}
				if (CS_0024_003C_003E8__locals0.memberExpr.Expression is ConstantExpression constantExpression)
				{
					_003C_003Ec__DisplayClass8_1 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass8_1();
					CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1 = CS_0024_003C_003E8__locals0;
					CS_0024_003C_003E8__locals1.parameterExpression = null;
					CS_0024_003C_003E8__locals1.del = _constMemberAccessDict.GetOrAdd(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.memberExpr.Member, (MemberInfo _) => Expression.Lambda<Func<object, TOut>>(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.memberExpr.Update(Expression.Convert(CS_0024_003C_003E8__locals1.parameterExpression, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.memberExpr.Member.DeclaringType)), new ParameterExpression[1] { CS_0024_003C_003E8__locals1.parameterExpression }).Compile());
					CS_0024_003C_003E8__locals1.capturedLocal = constantExpression.Value;
					return (TIn _) => CS_0024_003C_003E8__locals1.del(CS_0024_003C_003E8__locals1.capturedLocal);
				}
			}
			return null;
		}

		private static Func<TIn, TOut> CompileSlow(Expression<Func<TIn, TOut>> expr)
		{
			return expr.Compile();
		}

		static Compiler()
		{
			int num = 2;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						_constMemberAccessDict = new ConcurrentDictionary<MemberInfo, Func<object, TOut>>();
						num2 = 4;
						continue;
					case 1:
						_simpleMemberAccessDict = new ConcurrentDictionary<MemberInfo, Func<TIn, TOut>>();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
						{
							num2 = 0;
						}
						continue;
					case 2:
						SingletonReader.JJCZtPuTvSt();
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
						{
							num2 = 1;
						}
						continue;
					case 4:
						break;
					case 3:
						return;
					}
					break;
				}
				_fingerprintedCache = new ConcurrentDictionary<ExpressionFingerprintChain, Hoisted<TIn, TOut>>();
				num = 3;
			}
		}

		internal static bool O5F3oZf4yuhXrqaRF22h()
		{
			return b7jaSkf4m89bwDS9nJb4 == null;
		}

		internal static object EGkHngf4MPXyWCS0Wcya()
		{
			return b7jaSkf4m89bwDS9nJb4;
		}
	}

	public static Func<TModel, TValue> Process<TModel, TValue>(Expression<Func<TModel, TValue>> lambdaExpression)
	{
		return Compiler<TModel, TValue>.Compile(lambdaExpression);
	}
}
