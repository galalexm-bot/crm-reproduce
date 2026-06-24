using System;
using System.Collections.Concurrent;
using System.Threading;

namespace EleWise.ELMA.Extensions;

public static class FuncExtensions
{
	public static Func<A, R> Memoize<A, R>(this Func<A, R> f)
	{
		_003C_003Ec__DisplayClass0_0<A, R> _003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0<A, R>();
		_003C_003Ec__DisplayClass0_.f = f;
		_003C_003Ec__DisplayClass0_.map = new ConcurrentDictionary<A, Lazy<R>>();
		return delegate(A a)
		{
			_003C_003Ec__DisplayClass0_1<A, R> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass0_1<A, R>();
			CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass0_;
			CS_0024_003C_003E8__locals0.a = a;
			Lazy<R> lazy = new Lazy<R>(() => CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.f(CS_0024_003C_003E8__locals0.a), LazyThreadSafetyMode.ExecutionAndPublication);
			return (!_003C_003Ec__DisplayClass0_.map.TryAdd(CS_0024_003C_003E8__locals0.a, lazy)) ? _003C_003Ec__DisplayClass0_.map[CS_0024_003C_003E8__locals0.a].Value : lazy.Value;
		};
	}
}
