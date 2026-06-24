using System.Diagnostics;

namespace Nemerle.Builtins;

[DebuggerNonUserCode]
public class FunctionFromTuple<_0027p1, _0027p2, _0027r> : Function<_0027p1, _0027p2, _0027r>
{
	private readonly Function<Tuple<_0027p1, _0027p2>, _0027r> fn;

	public FunctionFromTuple(Function<Tuple<_0027p1, _0027p2>, _0027r> f)
	{
		fn = f;
	}

	public override _0027r apply(_0027p1 a1, _0027p2 a2)
	{
		return fn.apply(new Tuple<_0027p1, _0027p2>(a1, a2));
	}
}
[DebuggerNonUserCode]
public class FunctionFromTuple<_0027p1, _0027p2, _0027p3, _0027r> : Function<_0027p1, _0027p2, _0027p3, _0027r>
{
	private readonly Function<Tuple<_0027p1, _0027p2, _0027p3>, _0027r> fn;

	public FunctionFromTuple(Function<Tuple<_0027p1, _0027p2, _0027p3>, _0027r> f)
	{
		fn = f;
	}

	public override _0027r apply(_0027p1 a1, _0027p2 a2, _0027p3 a3)
	{
		return fn.apply(new Tuple<_0027p1, _0027p2, _0027p3>(a1, a2, a3));
	}
}
[DebuggerNonUserCode]
public class FunctionFromTuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027r> : Function<_0027p1, _0027p2, _0027p3, _0027p4, _0027r>
{
	private readonly Function<Tuple<_0027p1, _0027p2, _0027p3, _0027p4>, _0027r> fn;

	public FunctionFromTuple(Function<Tuple<_0027p1, _0027p2, _0027p3, _0027p4>, _0027r> f)
	{
		fn = f;
	}

	public override _0027r apply(_0027p1 a1, _0027p2 a2, _0027p3 a3, _0027p4 a4)
	{
		return fn.apply(new Tuple<_0027p1, _0027p2, _0027p3, _0027p4>(a1, a2, a3, a4));
	}
}
[DebuggerNonUserCode]
public class FunctionFromTuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027r> : Function<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027r>
{
	private readonly Function<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5>, _0027r> fn;

	public FunctionFromTuple(Function<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5>, _0027r> f)
	{
		fn = f;
	}

	public override _0027r apply(_0027p1 a1, _0027p2 a2, _0027p3 a3, _0027p4 a4, _0027p5 a5)
	{
		return fn.apply(new Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5>(a1, a2, a3, a4, a5));
	}
}
[DebuggerNonUserCode]
public class FunctionFromTuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027r> : Function<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027r>
{
	private readonly Function<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6>, _0027r> fn;

	public FunctionFromTuple(Function<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6>, _0027r> f)
	{
		fn = f;
	}

	public override _0027r apply(_0027p1 a1, _0027p2 a2, _0027p3 a3, _0027p4 a4, _0027p5 a5, _0027p6 a6)
	{
		return fn.apply(new Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6>(a1, a2, a3, a4, a5, a6));
	}
}
[DebuggerNonUserCode]
public class FunctionFromTuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027r> : Function<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027r>
{
	private readonly Function<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7>, _0027r> fn;

	public FunctionFromTuple(Function<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7>, _0027r> f)
	{
		fn = f;
	}

	public override _0027r apply(_0027p1 a1, _0027p2 a2, _0027p3 a3, _0027p4 a4, _0027p5 a5, _0027p6 a6, _0027p7 a7)
	{
		return fn.apply(new Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7>(a1, a2, a3, a4, a5, a6, a7));
	}
}
[DebuggerNonUserCode]
public class FunctionFromTuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027r> : Function<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027r>
{
	private readonly Function<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8>, _0027r> fn;

	public FunctionFromTuple(Function<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8>, _0027r> f)
	{
		fn = f;
	}

	public override _0027r apply(_0027p1 a1, _0027p2 a2, _0027p3 a3, _0027p4 a4, _0027p5 a5, _0027p6 a6, _0027p7 a7, _0027p8 a8)
	{
		return fn.apply(new Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8>(a1, a2, a3, a4, a5, a6, a7, a8));
	}
}
[DebuggerNonUserCode]
public class FunctionFromTuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027r> : Function<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027r>
{
	private readonly Function<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9>, _0027r> fn;

	public FunctionFromTuple(Function<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9>, _0027r> f)
	{
		fn = f;
	}

	public override _0027r apply(_0027p1 a1, _0027p2 a2, _0027p3 a3, _0027p4 a4, _0027p5 a5, _0027p6 a6, _0027p7 a7, _0027p8 a8, _0027p9 a9)
	{
		return fn.apply(new Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9>(a1, a2, a3, a4, a5, a6, a7, a8, a9));
	}
}
[DebuggerNonUserCode]
public class FunctionFromTuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027r> : Function<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027r>
{
	private readonly Function<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10>, _0027r> fn;

	public FunctionFromTuple(Function<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10>, _0027r> f)
	{
		fn = f;
	}

	public override _0027r apply(_0027p1 a1, _0027p2 a2, _0027p3 a3, _0027p4 a4, _0027p5 a5, _0027p6 a6, _0027p7 a7, _0027p8 a8, _0027p9 a9, _0027p10 a10)
	{
		return fn.apply(new Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10>(a1, a2, a3, a4, a5, a6, a7, a8, a9, a10));
	}
}
[DebuggerNonUserCode]
public class FunctionFromTuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027r> : Function<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027r>
{
	private readonly Function<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11>, _0027r> fn;

	public FunctionFromTuple(Function<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11>, _0027r> f)
	{
		fn = f;
	}

	public override _0027r apply(_0027p1 a1, _0027p2 a2, _0027p3 a3, _0027p4 a4, _0027p5 a5, _0027p6 a6, _0027p7 a7, _0027p8 a8, _0027p9 a9, _0027p10 a10, _0027p11 a11)
	{
		return fn.apply(new Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11>(a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11));
	}
}
[DebuggerNonUserCode]
public class FunctionFromTuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027r> : Function<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027r>
{
	private readonly Function<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12>, _0027r> fn;

	public FunctionFromTuple(Function<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12>, _0027r> f)
	{
		fn = f;
	}

	public override _0027r apply(_0027p1 a1, _0027p2 a2, _0027p3 a3, _0027p4 a4, _0027p5 a5, _0027p6 a6, _0027p7 a7, _0027p8 a8, _0027p9 a9, _0027p10 a10, _0027p11 a11, _0027p12 a12)
	{
		return fn.apply(new Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12>(a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12));
	}
}
[DebuggerNonUserCode]
public class FunctionFromTuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027r> : Function<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027r>
{
	private readonly Function<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13>, _0027r> fn;

	public FunctionFromTuple(Function<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13>, _0027r> f)
	{
		fn = f;
	}

	public override _0027r apply(_0027p1 a1, _0027p2 a2, _0027p3 a3, _0027p4 a4, _0027p5 a5, _0027p6 a6, _0027p7 a7, _0027p8 a8, _0027p9 a9, _0027p10 a10, _0027p11 a11, _0027p12 a12, _0027p13 a13)
	{
		return fn.apply(new Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13>(a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13));
	}
}
[DebuggerNonUserCode]
public class FunctionFromTuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027r> : Function<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027r>
{
	private readonly Function<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14>, _0027r> fn;

	public FunctionFromTuple(Function<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14>, _0027r> f)
	{
		fn = f;
	}

	public override _0027r apply(_0027p1 a1, _0027p2 a2, _0027p3 a3, _0027p4 a4, _0027p5 a5, _0027p6 a6, _0027p7 a7, _0027p8 a8, _0027p9 a9, _0027p10 a10, _0027p11 a11, _0027p12 a12, _0027p13 a13, _0027p14 a14)
	{
		return fn.apply(new Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14>(a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14));
	}
}
[DebuggerNonUserCode]
public class FunctionFromTuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027r> : Function<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027r>
{
	private readonly Function<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15>, _0027r> fn;

	public FunctionFromTuple(Function<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15>, _0027r> f)
	{
		fn = f;
	}

	public override _0027r apply(_0027p1 a1, _0027p2 a2, _0027p3 a3, _0027p4 a4, _0027p5 a5, _0027p6 a6, _0027p7 a7, _0027p8 a8, _0027p9 a9, _0027p10 a10, _0027p11 a11, _0027p12 a12, _0027p13 a13, _0027p14 a14, _0027p15 a15)
	{
		return fn.apply(new Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15>(a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15));
	}
}
[DebuggerNonUserCode]
public class FunctionFromTuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027r> : Function<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027r>
{
	private readonly Function<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16>, _0027r> fn;

	public FunctionFromTuple(Function<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16>, _0027r> f)
	{
		fn = f;
	}

	public override _0027r apply(_0027p1 a1, _0027p2 a2, _0027p3 a3, _0027p4 a4, _0027p5 a5, _0027p6 a6, _0027p7 a7, _0027p8 a8, _0027p9 a9, _0027p10 a10, _0027p11 a11, _0027p12 a12, _0027p13 a13, _0027p14 a14, _0027p15 a15, _0027p16 a16)
	{
		return fn.apply(new Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16>(a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16));
	}
}
[DebuggerNonUserCode]
public class FunctionFromTuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17, _0027r> : Function<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17, _0027r>
{
	private readonly Function<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17>, _0027r> fn;

	public FunctionFromTuple(Function<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17>, _0027r> f)
	{
		fn = f;
	}

	public override _0027r apply(_0027p1 a1, _0027p2 a2, _0027p3 a3, _0027p4 a4, _0027p5 a5, _0027p6 a6, _0027p7 a7, _0027p8 a8, _0027p9 a9, _0027p10 a10, _0027p11 a11, _0027p12 a12, _0027p13 a13, _0027p14 a14, _0027p15 a15, _0027p16 a16, _0027p17 a17)
	{
		return fn.apply(new Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17>(a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17));
	}
}
[DebuggerNonUserCode]
public class FunctionFromTuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17, _0027p18, _0027r> : Function<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17, _0027p18, _0027r>
{
	private readonly Function<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17, _0027p18>, _0027r> fn;

	public FunctionFromTuple(Function<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17, _0027p18>, _0027r> f)
	{
		fn = f;
	}

	public override _0027r apply(_0027p1 a1, _0027p2 a2, _0027p3 a3, _0027p4 a4, _0027p5 a5, _0027p6 a6, _0027p7 a7, _0027p8 a8, _0027p9 a9, _0027p10 a10, _0027p11 a11, _0027p12 a12, _0027p13 a13, _0027p14 a14, _0027p15 a15, _0027p16 a16, _0027p17 a17, _0027p18 a18)
	{
		return fn.apply(new Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17, _0027p18>(a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18));
	}
}
[DebuggerNonUserCode]
public class FunctionFromTuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17, _0027p18, _0027p19, _0027r> : Function<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17, _0027p18, _0027p19, _0027r>
{
	private readonly Function<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17, _0027p18, _0027p19>, _0027r> fn;

	public FunctionFromTuple(Function<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17, _0027p18, _0027p19>, _0027r> f)
	{
		fn = f;
	}

	public override _0027r apply(_0027p1 a1, _0027p2 a2, _0027p3 a3, _0027p4 a4, _0027p5 a5, _0027p6 a6, _0027p7 a7, _0027p8 a8, _0027p9 a9, _0027p10 a10, _0027p11 a11, _0027p12 a12, _0027p13 a13, _0027p14 a14, _0027p15 a15, _0027p16 a16, _0027p17 a17, _0027p18 a18, _0027p19 a19)
	{
		return fn.apply(new Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17, _0027p18, _0027p19>(a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19));
	}
}
[DebuggerNonUserCode]
public class FunctionFromTuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17, _0027p18, _0027p19, _0027p20, _0027r> : Function<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17, _0027p18, _0027p19, _0027p20, _0027r>
{
	private readonly Function<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17, _0027p18, _0027p19, _0027p20>, _0027r> fn;

	public FunctionFromTuple(Function<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17, _0027p18, _0027p19, _0027p20>, _0027r> f)
	{
		fn = f;
	}

	public override _0027r apply(_0027p1 a1, _0027p2 a2, _0027p3 a3, _0027p4 a4, _0027p5 a5, _0027p6 a6, _0027p7 a7, _0027p8 a8, _0027p9 a9, _0027p10 a10, _0027p11 a11, _0027p12 a12, _0027p13 a13, _0027p14 a14, _0027p15 a15, _0027p16 a16, _0027p17 a17, _0027p18 a18, _0027p19 a19, _0027p20 a20)
	{
		return fn.apply(new Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17, _0027p18, _0027p19, _0027p20>(a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20));
	}
}
