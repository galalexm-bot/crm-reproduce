using System;
using System.Linq.Expressions;
using EleWise.ELMA.Extensions;
using NHibernate.Persister.Entity;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.NH;

public static class PersisterExtensions
{
	private static PersisterExtensions DP160VW6G6p2qVkHkRJk;

	public static RT Get<ET, RT>(this IEntityPersister persister, object[] state, Expression<Func<ET, RT>> expression)
	{
		if (state == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6DC147B0 ^ 0x6DC3648A));
		}
		if (expression == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70037984 ^ -70040796));
		}
		string name = ((expression.Body as MemberExpression) ?? throw new ArgumentException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218619162))).Member.Name;
		return persister.Get<RT>(state, name);
	}

	public static RT Get<RT>(this IEntityPersister persister, object[] state, string memberName)
	{
		int num = Array.IndexOf(persister.get_PropertyNames(), memberName);
		if (num < 0)
		{
			throw new InvalidOperationException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x26FFCB59 ^ 0x26FDE8D9) + memberName);
		}
		return (RT)state[num];
	}

	public static void Set<ET, RT>(this IEntityPersister persister, object[] state, ET entity, Expression<Func<ET, RT>> expression)
	{
		if (state == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-583745292 ^ -583605298));
		}
		if (expression == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-234299632 ^ -234302956));
		}
		RT val = expression.Compile()(entity);
		string memberName = LinqUtils.NameOf(expression);
		persister.Set(state, memberName, val);
	}

	public static void Set<ET, RT>(this IEntityPersister persister, object[] state, Expression<Func<ET, RT>> expression, RT value)
	{
		if (state == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A81B9B4 ^ 0x6A839A8E));
		}
		if (expression == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4DC2B14D ^ 0x4DC2BC49));
		}
		string memberName = LinqUtils.NameOf(expression);
		persister.Set(state, memberName, value);
	}

	public static void Set(this IEntityPersister persister, object[] state, string memberName, object value)
	{
		int num = 1;
		int num2 = num;
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 1:
				num3 = Array.IndexOf((string[])sjXmyaW6QgP4kdPP0Mtj(persister), memberName);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				throw new InvalidOperationException((string)yTXHtaW6CQK1fgjBr207(-2138160520 ^ -2138283528) + memberName);
			case 2:
				return;
			}
			if (num3 < 0)
			{
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
				{
					num2 = 3;
				}
				continue;
			}
			state[num3] = value;
			num2 = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
			{
				num2 = 1;
			}
		}
	}

	internal static object sjXmyaW6QgP4kdPP0Mtj(object P_0)
	{
		return ((IEntityPersister)P_0).get_PropertyNames();
	}

	internal static object yTXHtaW6CQK1fgjBr207(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool JoHZjEW6EaVevqeHDCoD()
	{
		return DP160VW6G6p2qVkHkRJk == null;
	}

	internal static PersisterExtensions hWJieiW6fBpHEpguiX6x()
	{
		return DP160VW6G6p2qVkHkRJk;
	}
}
