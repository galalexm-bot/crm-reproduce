using System.Diagnostics;

namespace Nemerle.Builtins;

[DebuggerNonUserCode]
public abstract class FunctionVoid : Function<object>
{
	public abstract override void apply_void();

	public override object apply()
	{
		apply_void();
		return null;
	}
}
[DebuggerNonUserCode]
public abstract class FunctionVoid<_0027p1> : Function<_0027p1, object>
{
	public abstract override void apply_void(_0027p1 _N_wildcard_2422);

	public override object apply(_0027p1 p1)
	{
		apply_void(p1);
		return null;
	}
}
[DebuggerNonUserCode]
public abstract class FunctionVoid<_0027p1, _0027p2> : FunctionVoid<Tuple<_0027p1, _0027p2>>
{
	public abstract override void apply_void(_0027p1 _N_wildcard_2425, _0027p2 _N_wildcard_2426);

	public override void apply_void(Tuple<_0027p1, _0027p2> o)
	{
		apply_void(o.Field0, o.Field1);
	}
}
[DebuggerNonUserCode]
public abstract class FunctionVoid<_0027p1, _0027p2, _0027p3> : FunctionVoid<Tuple<_0027p1, _0027p2, _0027p3>>
{
	public abstract override void apply_void(_0027p1 _N_wildcard_2430, _0027p2 _N_wildcard_2431, _0027p3 _N_wildcard_2432);

	public override void apply_void(Tuple<_0027p1, _0027p2, _0027p3> o)
	{
		apply_void(o.Field0, o.Field1, o.Field2);
	}
}
[DebuggerNonUserCode]
public abstract class FunctionVoid<_0027p1, _0027p2, _0027p3, _0027p4> : FunctionVoid<Tuple<_0027p1, _0027p2, _0027p3, _0027p4>>
{
	public abstract override void apply_void(_0027p1 _N_wildcard_2437, _0027p2 _N_wildcard_2438, _0027p3 _N_wildcard_2439, _0027p4 _N_wildcard_2440);

	public override void apply_void(Tuple<_0027p1, _0027p2, _0027p3, _0027p4> o)
	{
		apply_void(o.Field0, o.Field1, o.Field2, o.Field3);
	}
}
[DebuggerNonUserCode]
public abstract class FunctionVoid<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5> : FunctionVoid<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5>>
{
	public abstract override void apply_void(_0027p1 _N_wildcard_2446, _0027p2 _N_wildcard_2447, _0027p3 _N_wildcard_2448, _0027p4 _N_wildcard_2449, _0027p5 _N_wildcard_2450);

	public override void apply_void(Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5> o)
	{
		apply_void(o.Field0, o.Field1, o.Field2, o.Field3, o.Field4);
	}
}
[DebuggerNonUserCode]
public abstract class FunctionVoid<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6> : FunctionVoid<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6>>
{
	public abstract override void apply_void(_0027p1 _N_wildcard_2457, _0027p2 _N_wildcard_2458, _0027p3 _N_wildcard_2459, _0027p4 _N_wildcard_2460, _0027p5 _N_wildcard_2461, _0027p6 _N_wildcard_2462);

	public override void apply_void(Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6> o)
	{
		apply_void(o.Field0, o.Field1, o.Field2, o.Field3, o.Field4, o.Field5);
	}
}
[DebuggerNonUserCode]
public abstract class FunctionVoid<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7> : FunctionVoid<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7>>
{
	public abstract override void apply_void(_0027p1 _N_wildcard_2470, _0027p2 _N_wildcard_2471, _0027p3 _N_wildcard_2472, _0027p4 _N_wildcard_2473, _0027p5 _N_wildcard_2474, _0027p6 _N_wildcard_2475, _0027p7 _N_wildcard_2476);

	public override void apply_void(Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7> o)
	{
		apply_void(o.Field0, o.Field1, o.Field2, o.Field3, o.Field4, o.Field5, o.Field6);
	}
}
[DebuggerNonUserCode]
public abstract class FunctionVoid<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8> : FunctionVoid<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8>>
{
	public abstract override void apply_void(_0027p1 _N_wildcard_2485, _0027p2 _N_wildcard_2486, _0027p3 _N_wildcard_2487, _0027p4 _N_wildcard_2488, _0027p5 _N_wildcard_2489, _0027p6 _N_wildcard_2490, _0027p7 _N_wildcard_2491, _0027p8 _N_wildcard_2492);

	public override void apply_void(Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8> o)
	{
		apply_void(o.Field0, o.Field1, o.Field2, o.Field3, o.Field4, o.Field5, o.Field6, o.Field7);
	}
}
[DebuggerNonUserCode]
public abstract class FunctionVoid<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9> : FunctionVoid<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9>>
{
	public abstract override void apply_void(_0027p1 _N_wildcard_2502, _0027p2 _N_wildcard_2503, _0027p3 _N_wildcard_2504, _0027p4 _N_wildcard_2505, _0027p5 _N_wildcard_2506, _0027p6 _N_wildcard_2507, _0027p7 _N_wildcard_2508, _0027p8 _N_wildcard_2509, _0027p9 _N_wildcard_2510);

	public override void apply_void(Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9> o)
	{
		apply_void(o.Field0, o.Field1, o.Field2, o.Field3, o.Field4, o.Field5, o.Field6, o.Field7, o.Field8);
	}
}
[DebuggerNonUserCode]
public abstract class FunctionVoid<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10> : FunctionVoid<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10>>
{
	public abstract override void apply_void(_0027p1 _N_wildcard_2521, _0027p2 _N_wildcard_2522, _0027p3 _N_wildcard_2523, _0027p4 _N_wildcard_2524, _0027p5 _N_wildcard_2525, _0027p6 _N_wildcard_2526, _0027p7 _N_wildcard_2527, _0027p8 _N_wildcard_2528, _0027p9 _N_wildcard_2529, _0027p10 _N_wildcard_2530);

	public override void apply_void(Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10> o)
	{
		apply_void(o.Field0, o.Field1, o.Field2, o.Field3, o.Field4, o.Field5, o.Field6, o.Field7, o.Field8, o.Field9);
	}
}
[DebuggerNonUserCode]
public abstract class FunctionVoid<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11> : FunctionVoid<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11>>
{
	public abstract override void apply_void(_0027p1 _N_wildcard_2542, _0027p2 _N_wildcard_2543, _0027p3 _N_wildcard_2544, _0027p4 _N_wildcard_2545, _0027p5 _N_wildcard_2546, _0027p6 _N_wildcard_2547, _0027p7 _N_wildcard_2548, _0027p8 _N_wildcard_2549, _0027p9 _N_wildcard_2550, _0027p10 _N_wildcard_2551, _0027p11 _N_wildcard_2552);

	public override void apply_void(Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11> o)
	{
		apply_void(o.Field0, o.Field1, o.Field2, o.Field3, o.Field4, o.Field5, o.Field6, o.Field7, o.Field8, o.Field9, o.Field10);
	}
}
[DebuggerNonUserCode]
public abstract class FunctionVoid<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12> : FunctionVoid<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12>>
{
	public abstract override void apply_void(_0027p1 _N_wildcard_2565, _0027p2 _N_wildcard_2566, _0027p3 _N_wildcard_2567, _0027p4 _N_wildcard_2568, _0027p5 _N_wildcard_2569, _0027p6 _N_wildcard_2570, _0027p7 _N_wildcard_2571, _0027p8 _N_wildcard_2572, _0027p9 _N_wildcard_2573, _0027p10 _N_wildcard_2574, _0027p11 _N_wildcard_2575, _0027p12 _N_wildcard_2576);

	public override void apply_void(Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12> o)
	{
		apply_void(o.Field0, o.Field1, o.Field2, o.Field3, o.Field4, o.Field5, o.Field6, o.Field7, o.Field8, o.Field9, o.Field10, o.Field11);
	}
}
[DebuggerNonUserCode]
public abstract class FunctionVoid<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13> : FunctionVoid<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13>>
{
	public abstract override void apply_void(_0027p1 _N_wildcard_2590, _0027p2 _N_wildcard_2591, _0027p3 _N_wildcard_2592, _0027p4 _N_wildcard_2593, _0027p5 _N_wildcard_2594, _0027p6 _N_wildcard_2595, _0027p7 _N_wildcard_2596, _0027p8 _N_wildcard_2597, _0027p9 _N_wildcard_2598, _0027p10 _N_wildcard_2599, _0027p11 _N_wildcard_2600, _0027p12 _N_wildcard_2601, _0027p13 _N_wildcard_2602);

	public override void apply_void(Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13> o)
	{
		apply_void(o.Field0, o.Field1, o.Field2, o.Field3, o.Field4, o.Field5, o.Field6, o.Field7, o.Field8, o.Field9, o.Field10, o.Field11, o.Field12);
	}
}
[DebuggerNonUserCode]
public abstract class FunctionVoid<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14> : FunctionVoid<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14>>
{
	public abstract override void apply_void(_0027p1 _N_wildcard_2617, _0027p2 _N_wildcard_2618, _0027p3 _N_wildcard_2619, _0027p4 _N_wildcard_2620, _0027p5 _N_wildcard_2621, _0027p6 _N_wildcard_2622, _0027p7 _N_wildcard_2623, _0027p8 _N_wildcard_2624, _0027p9 _N_wildcard_2625, _0027p10 _N_wildcard_2626, _0027p11 _N_wildcard_2627, _0027p12 _N_wildcard_2628, _0027p13 _N_wildcard_2629, _0027p14 _N_wildcard_2630);

	public override void apply_void(Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14> o)
	{
		apply_void(o.Field0, o.Field1, o.Field2, o.Field3, o.Field4, o.Field5, o.Field6, o.Field7, o.Field8, o.Field9, o.Field10, o.Field11, o.Field12, o.Field13);
	}
}
[DebuggerNonUserCode]
public abstract class FunctionVoid<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15> : FunctionVoid<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15>>
{
	public abstract override void apply_void(_0027p1 _N_wildcard_2646, _0027p2 _N_wildcard_2647, _0027p3 _N_wildcard_2648, _0027p4 _N_wildcard_2649, _0027p5 _N_wildcard_2650, _0027p6 _N_wildcard_2651, _0027p7 _N_wildcard_2652, _0027p8 _N_wildcard_2653, _0027p9 _N_wildcard_2654, _0027p10 _N_wildcard_2655, _0027p11 _N_wildcard_2656, _0027p12 _N_wildcard_2657, _0027p13 _N_wildcard_2658, _0027p14 _N_wildcard_2659, _0027p15 _N_wildcard_2660);

	public override void apply_void(Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15> o)
	{
		apply_void(o.Field0, o.Field1, o.Field2, o.Field3, o.Field4, o.Field5, o.Field6, o.Field7, o.Field8, o.Field9, o.Field10, o.Field11, o.Field12, o.Field13, o.Field14);
	}
}
[DebuggerNonUserCode]
public abstract class FunctionVoid<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16> : FunctionVoid<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16>>
{
	public abstract override void apply_void(_0027p1 _N_wildcard_2677, _0027p2 _N_wildcard_2678, _0027p3 _N_wildcard_2679, _0027p4 _N_wildcard_2680, _0027p5 _N_wildcard_2681, _0027p6 _N_wildcard_2682, _0027p7 _N_wildcard_2683, _0027p8 _N_wildcard_2684, _0027p9 _N_wildcard_2685, _0027p10 _N_wildcard_2686, _0027p11 _N_wildcard_2687, _0027p12 _N_wildcard_2688, _0027p13 _N_wildcard_2689, _0027p14 _N_wildcard_2690, _0027p15 _N_wildcard_2691, _0027p16 _N_wildcard_2692);

	public override void apply_void(Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16> o)
	{
		apply_void(o.Field0, o.Field1, o.Field2, o.Field3, o.Field4, o.Field5, o.Field6, o.Field7, o.Field8, o.Field9, o.Field10, o.Field11, o.Field12, o.Field13, o.Field14, o.Field15);
	}
}
[DebuggerNonUserCode]
public abstract class FunctionVoid<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17> : FunctionVoid<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17>>
{
	public abstract override void apply_void(_0027p1 _N_wildcard_2710, _0027p2 _N_wildcard_2711, _0027p3 _N_wildcard_2712, _0027p4 _N_wildcard_2713, _0027p5 _N_wildcard_2714, _0027p6 _N_wildcard_2715, _0027p7 _N_wildcard_2716, _0027p8 _N_wildcard_2717, _0027p9 _N_wildcard_2718, _0027p10 _N_wildcard_2719, _0027p11 _N_wildcard_2720, _0027p12 _N_wildcard_2721, _0027p13 _N_wildcard_2722, _0027p14 _N_wildcard_2723, _0027p15 _N_wildcard_2724, _0027p16 _N_wildcard_2725, _0027p17 _N_wildcard_2726);

	public override void apply_void(Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17> o)
	{
		apply_void(o.Field0, o.Field1, o.Field2, o.Field3, o.Field4, o.Field5, o.Field6, o.Field7, o.Field8, o.Field9, o.Field10, o.Field11, o.Field12, o.Field13, o.Field14, o.Field15, o.Field16);
	}
}
[DebuggerNonUserCode]
public abstract class FunctionVoid<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17, _0027p18> : FunctionVoid<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17, _0027p18>>
{
	public abstract override void apply_void(_0027p1 _N_wildcard_2745, _0027p2 _N_wildcard_2746, _0027p3 _N_wildcard_2747, _0027p4 _N_wildcard_2748, _0027p5 _N_wildcard_2749, _0027p6 _N_wildcard_2750, _0027p7 _N_wildcard_2751, _0027p8 _N_wildcard_2752, _0027p9 _N_wildcard_2753, _0027p10 _N_wildcard_2754, _0027p11 _N_wildcard_2755, _0027p12 _N_wildcard_2756, _0027p13 _N_wildcard_2757, _0027p14 _N_wildcard_2758, _0027p15 _N_wildcard_2759, _0027p16 _N_wildcard_2760, _0027p17 _N_wildcard_2761, _0027p18 _N_wildcard_2762);

	public override void apply_void(Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17, _0027p18> o)
	{
		apply_void(o.Field0, o.Field1, o.Field2, o.Field3, o.Field4, o.Field5, o.Field6, o.Field7, o.Field8, o.Field9, o.Field10, o.Field11, o.Field12, o.Field13, o.Field14, o.Field15, o.Field16, o.Field17);
	}
}
[DebuggerNonUserCode]
public abstract class FunctionVoid<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17, _0027p18, _0027p19> : FunctionVoid<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17, _0027p18, _0027p19>>
{
	public abstract override void apply_void(_0027p1 _N_wildcard_2782, _0027p2 _N_wildcard_2783, _0027p3 _N_wildcard_2784, _0027p4 _N_wildcard_2785, _0027p5 _N_wildcard_2786, _0027p6 _N_wildcard_2787, _0027p7 _N_wildcard_2788, _0027p8 _N_wildcard_2789, _0027p9 _N_wildcard_2790, _0027p10 _N_wildcard_2791, _0027p11 _N_wildcard_2792, _0027p12 _N_wildcard_2793, _0027p13 _N_wildcard_2794, _0027p14 _N_wildcard_2795, _0027p15 _N_wildcard_2796, _0027p16 _N_wildcard_2797, _0027p17 _N_wildcard_2798, _0027p18 _N_wildcard_2799, _0027p19 _N_wildcard_2800);

	public override void apply_void(Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17, _0027p18, _0027p19> o)
	{
		apply_void(o.Field0, o.Field1, o.Field2, o.Field3, o.Field4, o.Field5, o.Field6, o.Field7, o.Field8, o.Field9, o.Field10, o.Field11, o.Field12, o.Field13, o.Field14, o.Field15, o.Field16, o.Field17, o.Field18);
	}
}
[DebuggerNonUserCode]
public abstract class FunctionVoid<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17, _0027p18, _0027p19, _0027p20> : FunctionVoid<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17, _0027p18, _0027p19, _0027p20>>
{
	public abstract override void apply_void(_0027p1 _N_wildcard_2821, _0027p2 _N_wildcard_2822, _0027p3 _N_wildcard_2823, _0027p4 _N_wildcard_2824, _0027p5 _N_wildcard_2825, _0027p6 _N_wildcard_2826, _0027p7 _N_wildcard_2827, _0027p8 _N_wildcard_2828, _0027p9 _N_wildcard_2829, _0027p10 _N_wildcard_2830, _0027p11 _N_wildcard_2831, _0027p12 _N_wildcard_2832, _0027p13 _N_wildcard_2833, _0027p14 _N_wildcard_2834, _0027p15 _N_wildcard_2835, _0027p16 _N_wildcard_2836, _0027p17 _N_wildcard_2837, _0027p18 _N_wildcard_2838, _0027p19 _N_wildcard_2839, _0027p20 _N_wildcard_2840);

	public override void apply_void(Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17, _0027p18, _0027p19, _0027p20> o)
	{
		apply_void(o.Field0, o.Field1, o.Field2, o.Field3, o.Field4, o.Field5, o.Field6, o.Field7, o.Field8, o.Field9, o.Field10, o.Field11, o.Field12, o.Field13, o.Field14, o.Field15, o.Field16, o.Field17, o.Field18, o.Field19);
	}
}
