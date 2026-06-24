using System.Collections.Generic;
using System.Linq.Expressions;
using SG9KiyIbtdgGDf12qr;

namespace System.Linq.Dynamic;

public static class DynamicQueryable
{
	private static DynamicQueryable CwOQCebVnodNfUdryps;

	public static IQueryable<T> Where<T>(this IQueryable<T> source, string predicate, params object[] values)
	{
		return (IQueryable<T>)((IQueryable)source).Where(predicate, values);
	}

	public static IQueryable Where(this IQueryable source, string predicate, params object[] values)
	{
		//Discarded unreachable code: IL_011e
		int num = 1;
		int num2 = num;
		LambdaExpression lambdaExpression = default(LambdaExpression);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (source != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 4;
			case 2:
				throw new ArgumentNullException((string)mD8o2IbR0SLp5fF8SOn(-2099751081 ^ -2099749407));
			case 4:
				throw new ArgumentNullException((string)mD8o2IbR0SLp5fF8SOn(0x34A6D230 ^ 0x34A6D896));
			case 3:
				return ((IQueryProvider)afnIjgbKCRWX6LpMnuK(source)).CreateQuery((Expression)gmSNWRbnpbgcZHkZWiE(typeof(Queryable), mD8o2IbR0SLp5fF8SOn(-16752921 ^ -16755669), new Type[1] { Q5HRCNbXCGCTIXAShjr(source) }, new Expression[2]
				{
					(Expression)sX2xITbT9yKef8gry4i(source),
					(Expression)Fi1NaPbkLbBckojrqwM(lambdaExpression)
				}));
			}
			if (predicate != null)
			{
				lambdaExpression = DynamicExpression.ParseLambda(source.ElementType, JfQ4jGbqS2VZ0AfGXkW(typeof(bool).TypeHandle), predicate, values);
				num2 = 3;
				continue;
			}
			num2 = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
			{
				num2 = 2;
			}
		}
	}

	public static IQueryable Select(this IQueryable source, string selector, params object[] values)
	{
		int num = 1;
		int num2 = num;
		LambdaExpression lambdaExpression = default(LambdaExpression);
		while (true)
		{
			switch (num2)
			{
			case 3:
				throw new ArgumentNullException((string)mD8o2IbR0SLp5fF8SOn(-812025778 ^ -812027244));
			case 1:
				if (source == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 0;
					}
				}
				else if (selector != null)
				{
					lambdaExpression = DynamicExpression.ParseLambda(Q5HRCNbXCGCTIXAShjr(source), null, selector, values);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
					{
						num2 = 1;
					}
				}
				else
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
					{
						num2 = 3;
					}
				}
				break;
			case 2:
				return (IQueryable)gykoixbe1VsXdQxOM6C(afnIjgbKCRWX6LpMnuK(source), gmSNWRbnpbgcZHkZWiE(JfQ4jGbqS2VZ0AfGXkW(typeof(Queryable).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-289714582 ^ -289717116), new Type[2]
				{
					source.ElementType,
					UP975Fb2jtUgeSYBZxN(UQZmdebOWnCWP9qKq0q(lambdaExpression))
				}, new Expression[2]
				{
					(Expression)sX2xITbT9yKef8gry4i(source),
					(Expression)Fi1NaPbkLbBckojrqwM(lambdaExpression)
				}));
			default:
				throw new ArgumentNullException((string)mD8o2IbR0SLp5fF8SOn(--1867379187 ^ 0x6F4DFB55));
			}
		}
	}

	public static IQueryable<T> OrderBy<T>(this IQueryable<T> source, string ordering, params object[] values)
	{
		return (IQueryable<T>)((IQueryable)source).OrderBy(ordering, values);
	}

	public static IQueryable OrderBy(this IQueryable source, string ordering, params object[] values)
	{
		//Discarded unreachable code: IL_009d, IL_00a7, IL_020f, IL_022e, IL_023d, IL_025a, IL_02a9
		int num = 1;
		int num2 = num;
		Expression expression = default(Expression);
		ParameterExpression[] parameters = default(ParameterExpression[]);
		string text = default(string);
		string text2 = default(string);
		IEnumerator<DynamicOrdering> enumerator = default(IEnumerator<DynamicOrdering>);
		DynamicOrdering current = default(DynamicOrdering);
		while (true)
		{
			switch (num2)
			{
			case 6:
				return (IQueryable)gykoixbe1VsXdQxOM6C(afnIjgbKCRWX6LpMnuK(source), expression);
			case 2:
			{
				IEnumerable<DynamicOrdering> enumerable = new ExpressionParser(parameters, ordering, values).ParseOrdering();
				expression = source.Expression;
				text = (string)mD8o2IbR0SLp5fF8SOn(-1939377524 ^ -1939375714);
				text2 = (string)mD8o2IbR0SLp5fF8SOn(0x76DD48E ^ 0x76DDFAA);
				enumerator = enumerable.GetEnumerator();
				num2 = 5;
				continue;
			}
			case 5:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
							{
								num3 = 0;
							}
							goto IL_00ab;
						}
						goto IL_0142;
						IL_0142:
						current = enumerator.Current;
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
						{
							num3 = 0;
						}
						goto IL_00ab;
						IL_00ab:
						while (true)
						{
							switch (num3)
							{
							case 5:
								break;
							default:
								text = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998537616);
								num3 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
								{
									num3 = 4;
								}
								continue;
							case 4:
								text2 = (string)mD8o2IbR0SLp5fF8SOn(0xA592A41 ^ 0xA59211B);
								num3 = 5;
								continue;
							case 3:
								goto IL_0142;
							case 1:
								expression = (Expression)gmSNWRbnpbgcZHkZWiE(typeof(Queryable), current.Ascending ? text : text2, new Type[2]
								{
									Q5HRCNbXCGCTIXAShjr(source),
									UP975Fb2jtUgeSYBZxN(current.Selector)
								}, new Expression[2]
								{
									expression,
									Expression.Quote(Expression.Lambda(current.Selector, parameters))
								});
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
								{
									num3 = 0;
								}
								continue;
							case 2:
								goto end_IL_00cd;
							}
							break;
						}
						continue;
						end_IL_00cd:
						break;
					}
				}
				finally
				{
					int num4;
					if (enumerator == null)
					{
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
						{
							num4 = 0;
						}
						goto IL_0213;
					}
					goto IL_0248;
					IL_0248:
					AGxUuGb1H35xpl6kQ7I(enumerator);
					num4 = 2;
					goto IL_0213;
					IL_0213:
					switch (num4)
					{
					default:
						goto end_IL_01ee;
					case 0:
						goto end_IL_01ee;
					case 1:
						break;
					case 2:
						goto end_IL_01ee;
					}
					goto IL_0248;
					end_IL_01ee:;
				}
				goto case 6;
			case 4:
				throw new ArgumentNullException((string)mD8o2IbR0SLp5fF8SOn(0x1DE3DD89 ^ 0x1DE3D72F));
			case 1:
				if (source != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 4;
			case 3:
				throw new ArgumentNullException((string)mD8o2IbR0SLp5fF8SOn(0x2A7797B7 ^ 0x2A779D49));
			}
			if (ordering == null)
			{
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
				{
					num2 = 3;
				}
				continue;
			}
			parameters = new ParameterExpression[1] { (ParameterExpression)Ux5WyjbPBOH1bcOjoI6(Q5HRCNbXCGCTIXAShjr(source), "") };
			num2 = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
			{
				num2 = 2;
			}
		}
	}

	public static IQueryable Take(this IQueryable source, int count)
	{
		//Discarded unreachable code: IL_004d, IL_005c
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (source != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				throw new ArgumentNullException((string)mD8o2IbR0SLp5fF8SOn(--1867379187 ^ 0x6F4DFB55));
			default:
				return (IQueryable)gykoixbe1VsXdQxOM6C(afnIjgbKCRWX6LpMnuK(source), gmSNWRbnpbgcZHkZWiE(JfQ4jGbqS2VZ0AfGXkW(typeof(Queryable).TypeHandle), mD8o2IbR0SLp5fF8SOn(-1921202237 ^ -1921200963), new Type[1] { Q5HRCNbXCGCTIXAShjr(source) }, new Expression[2]
				{
					(Expression)sX2xITbT9yKef8gry4i(source),
					(Expression)dTobGdbNkqLvxKejHeH(count)
				}));
			}
		}
	}

	public static IQueryable Skip(this IQueryable source, int count)
	{
		//Discarded unreachable code: IL_009a, IL_00a9
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317792138));
			case 1:
				return (IQueryable)gykoixbe1VsXdQxOM6C(afnIjgbKCRWX6LpMnuK(source), gmSNWRbnpbgcZHkZWiE(JfQ4jGbqS2VZ0AfGXkW(typeof(Queryable).TypeHandle), mD8o2IbR0SLp5fF8SOn(0x34185E55 ^ 0x341855DF), new Type[1] { Q5HRCNbXCGCTIXAShjr(source) }, new Expression[2]
				{
					(Expression)sX2xITbT9yKef8gry4i(source),
					(Expression)dTobGdbNkqLvxKejHeH(count)
				}));
			case 2:
				if (source != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	public static IQueryable GroupBy(this IQueryable source, string keySelector, string elementSelector, params object[] values)
	{
		//Discarded unreachable code: IL_0081, IL_0090, IL_0172, IL_0181
		int num = 6;
		int num2 = num;
		LambdaExpression lambdaExpression = default(LambdaExpression);
		LambdaExpression lambdaExpression2 = default(LambdaExpression);
		while (true)
		{
			switch (num2)
			{
			default:
				throw new ArgumentNullException((string)mD8o2IbR0SLp5fF8SOn(0x3CE17B75 ^ 0x3CE170C5));
			case 3:
				lambdaExpression = DynamicExpression.ParseLambda(Q5HRCNbXCGCTIXAShjr(source), null, keySelector, values);
				num2 = 7;
				break;
			case 6:
				if (source != null)
				{
					num2 = 5;
					break;
				}
				goto case 4;
			case 1:
				throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 0x5115098B));
			case 7:
				lambdaExpression2 = DynamicExpression.ParseLambda(Q5HRCNbXCGCTIXAShjr(source), null, elementSelector, values);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return (IQueryable)gykoixbe1VsXdQxOM6C(source.Provider, Expression.Call(typeof(Queryable), (string)mD8o2IbR0SLp5fF8SOn(0x92F12D5 ^ 0x92F1907), new Type[3]
				{
					Q5HRCNbXCGCTIXAShjr(source),
					UP975Fb2jtUgeSYBZxN(UQZmdebOWnCWP9qKq0q(lambdaExpression)),
					((Expression)UQZmdebOWnCWP9qKq0q(lambdaExpression2)).Type
				}, (Expression)sX2xITbT9yKef8gry4i(source), Expression.Quote(lambdaExpression), (Expression)Fi1NaPbkLbBckojrqwM(lambdaExpression2)));
			case 4:
				throw new ArgumentNullException((string)mD8o2IbR0SLp5fF8SOn(0x3A6135BE ^ 0x3A613F18));
			case 5:
				if (keySelector != null)
				{
					if (elementSelector != null)
					{
						num2 = 3;
						break;
					}
					goto default;
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public static bool Any(this IQueryable source)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				throw new ArgumentNullException((string)mD8o2IbR0SLp5fF8SOn(0x4D1C1EE4 ^ 0x4D1C1442));
			case 1:
				if (source != null)
				{
					return (bool)ygICXXb31xre3IIQOO9(afnIjgbKCRWX6LpMnuK(source), gmSNWRbnpbgcZHkZWiE(JfQ4jGbqS2VZ0AfGXkW(typeof(Queryable).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7247028A ^ 0x7247096E), new Type[1] { Q5HRCNbXCGCTIXAShjr(source) }, new Expression[1] { (Expression)sX2xITbT9yKef8gry4i(source) }));
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static int Count(this IQueryable source)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (source == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num2 = 0;
					}
					break;
				}
				return (int)((IQueryProvider)afnIjgbKCRWX6LpMnuK(source)).Execute((Expression)Expression.Call(JfQ4jGbqS2VZ0AfGXkW(typeof(Queryable).TypeHandle), (string)mD8o2IbR0SLp5fF8SOn(-309639236 ^ -309638062), new Type[1] { source.ElementType }, (Expression)sX2xITbT9yKef8gry4i(source)));
			default:
				throw new ArgumentNullException((string)mD8o2IbR0SLp5fF8SOn(0x61EC0CB8 ^ 0x61EC061E));
			}
		}
	}

	internal static object mD8o2IbR0SLp5fF8SOn(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Type JfQ4jGbqS2VZ0AfGXkW(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object afnIjgbKCRWX6LpMnuK(object P_0)
	{
		return ((IQueryable)P_0).Provider;
	}

	internal static Type Q5HRCNbXCGCTIXAShjr(object P_0)
	{
		return ((IQueryable)P_0).ElementType;
	}

	internal static object sX2xITbT9yKef8gry4i(object P_0)
	{
		return ((IQueryable)P_0).Expression;
	}

	internal static object Fi1NaPbkLbBckojrqwM(object P_0)
	{
		return Expression.Quote((Expression)P_0);
	}

	internal static object gmSNWRbnpbgcZHkZWiE(Type P_0, object P_1, object P_2, object P_3)
	{
		return Expression.Call(P_0, (string)P_1, (Type[])P_2, (Expression[])P_3);
	}

	internal static bool ERipGcbSkjNPMWNxOaI()
	{
		return CwOQCebVnodNfUdryps == null;
	}

	internal static DynamicQueryable ClqGoabimHVtWg5Uwuu()
	{
		return CwOQCebVnodNfUdryps;
	}

	internal static object UQZmdebOWnCWP9qKq0q(object P_0)
	{
		return ((LambdaExpression)P_0).Body;
	}

	internal static Type UP975Fb2jtUgeSYBZxN(object P_0)
	{
		return ((Expression)P_0).Type;
	}

	internal static object gykoixbe1VsXdQxOM6C(object P_0, object P_1)
	{
		return ((IQueryProvider)P_0).CreateQuery((Expression)P_1);
	}

	internal static object Ux5WyjbPBOH1bcOjoI6(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static void AGxUuGb1H35xpl6kQ7I(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object dTobGdbNkqLvxKejHeH(object P_0)
	{
		return Expression.Constant(P_0);
	}

	internal static object ygICXXb31xre3IIQOO9(object P_0, object P_1)
	{
		return ((IQueryProvider)P_0).Execute((Expression)P_1);
	}
}
