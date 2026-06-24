using Nemerle.Builtins;

namespace Nemerle.Utility;

public static class Pair
{
	public static _0027a First<_0027a, _0027b>(_0027a x, _0027b _N_wildcard_2846)
	{
		return x;
	}

	public static _0027b Second<_0027a, _0027b>(_0027a _N_wildcard_2847, _0027b x)
	{
		return x;
	}

	public static Tuple<_0027b, _0027a> Swap<_0027a, _0027b>(_0027a a, _0027b b)
	{
		return new Tuple<_0027b, _0027a>(b, a);
	}
}
