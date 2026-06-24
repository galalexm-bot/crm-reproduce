using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Compiler.Typedtree;
using Nemerle.Core;

namespace Nemerle.Compiler;

public class Decorator : ISupportRelocation
{
	private sealed class _N_static_proxy_93408 : Function<TExpr, bool>
	{
		[SpecialName]
		public static readonly _N_static_proxy_93408 single_instance = new _N_static_proxy_93408();

		[SpecialName]
		public sealed override bool apply(TExpr _N_sp_parm_93415)
		{
			return Propagatable(_N_sp_parm_93415);
		}

		private _N_static_proxy_93408()
		{
		}
	}

	private sealed class _N_closureOf_SetDefOf_93428
	{
		internal TExpr.Def _N_def_of_93433;

		internal _N_closureOf_SetDefOf_93428()
		{
		}
	}

	private sealed class _N_Inject__93435 : Function<TExpr, TExpr>
	{
		[SpecialName]
		private _N_closureOf_SetDefOf_93428 _N_SetDefOf_closure_93439;

		public _N_Inject__93435(_N_closureOf_SetDefOf_93428 _N_SetDefOf_closure_93439)
		{
			this._N_SetDefOf_closure_93439 = _N_SetDefOf_closure_93439;
		}

		[SpecialName]
		public sealed override TExpr apply(TExpr expr)
		{
			object result;
			if (expr is TExpr.Use)
			{
				TExpr.Use use = (TExpr.Use)expr;
				use.def_of = _N_SetDefOf_closure_93439._N_def_of_93433;
				result = use;
			}
			else
			{
				result = null;
			}
			return (TExpr)result;
		}
	}

	private sealed class _N_closureOf_MultipleAssignResolver_93466
	{
		internal _N_closureOf_MultipleAssignResolver_93466()
		{
		}
	}

	private sealed class _N__N_lambda__93458__93485 : Function<LocalValue, TExpr, Tuple<LocalValue, TExpr>>
	{
		[SpecialName]
		public static readonly _N__N_lambda__93458__93485 Instance = new _N__N_lambda__93458__93485();

		[SpecialName]
		public sealed override Tuple<LocalValue, TExpr> apply(LocalValue l, TExpr e)
		{
			return new Tuple<LocalValue, TExpr>(l, e.Walk(_N_static_proxy_93499.single_instance));
		}
	}

	private sealed class _N_static_proxy_93499 : Function<TExpr, TExpr>
	{
		[SpecialName]
		public static readonly _N_static_proxy_93499 single_instance = new _N_static_proxy_93499();

		[SpecialName]
		public sealed override TExpr apply(TExpr _N_sp_parm_93506)
		{
			return decorate(_N_sp_parm_93506);
		}

		private _N_static_proxy_93499()
		{
		}
	}

	private sealed class _N_static_proxy_93530 : Function<TExpr, TExpr>
	{
		[SpecialName]
		public static readonly _N_static_proxy_93530 single_instance = new _N_static_proxy_93530();

		[SpecialName]
		public sealed override TExpr apply(TExpr _N_sp_parm_93537)
		{
			return decorate(_N_sp_parm_93537);
		}

		private _N_static_proxy_93530()
		{
		}
	}

	private sealed class _N_static_proxy_93549 : Function<TExpr, TExpr>
	{
		[SpecialName]
		public static readonly _N_static_proxy_93549 single_instance = new _N_static_proxy_93549();

		[SpecialName]
		public sealed override TExpr apply(TExpr _N_sp_parm_93556)
		{
			return decorate(_N_sp_parm_93556);
		}

		private _N_static_proxy_93549()
		{
		}
	}

	private sealed class _N_closureOf_Undecorate_93577
	{
		internal Function<TExpr, TExpr> _N_undecorate_93582;

		internal _N_closureOf_Undecorate_93577()
		{
		}
	}

	private sealed class _N_undecorate__93584 : Function<TExpr, TExpr>
	{
		[SpecialName]
		private _N_closureOf_Undecorate_93577 _N_Undecorate_closure_93588;

		public _N_undecorate__93584(_N_closureOf_Undecorate_93577 _N_Undecorate_closure_93588)
		{
			this._N_Undecorate_closure_93588 = _N_Undecorate_closure_93588;
		}

		[SpecialName]
		public sealed override TExpr apply(TExpr exp)
		{
			object result;
			TExpr.MultipleAssign multipleAssign;
			list<Tuple<LocalValue, TExpr>> list;
			if (exp is TExpr.Assign)
			{
				if (!(((TExpr.Assign)exp).target is TExpr.Def) || (object)((TExpr.Def)((TExpr.Assign)exp).target).expr != null)
				{
					goto IL_01dd;
				}
				result = new TExpr.Literal(new Literal.Void());
			}
			else
			{
				if (exp is TExpr.Sequence)
				{
					if (((TExpr.Sequence)exp).e1 is TExpr.MultipleAssign)
					{
						multipleAssign = (TExpr.MultipleAssign)((TExpr.Sequence)exp).e1;
						if (((TExpr.Sequence)exp).e2 is TExpr.Sequence)
						{
							list = ((TExpr.MultipleAssign)((TExpr.Sequence)exp).e1).assigns;
							if (((TExpr.Sequence)((TExpr.Sequence)exp).e2).e1 is TExpr.Def)
							{
								goto IL_00e3;
							}
						}
						else if (((TExpr.Sequence)exp).e2 is TExpr.Def)
						{
							multipleAssign = (TExpr.MultipleAssign)((TExpr.Sequence)exp).e1;
							list = ((TExpr.MultipleAssign)((TExpr.Sequence)exp).e1).assigns;
							goto IL_00e3;
						}
					}
					goto IL_01dd;
				}
				TExpr expr;
				if (exp is TExpr.Def)
				{
					if ((object)((TExpr.Def)exp).expr == null)
					{
						throw new AssertionException("ncc\\optimization\\Decorator.n", 107, "", "");
					}
					expr = ((TExpr.Def)exp).expr;
				}
				else
				{
					if (!(exp is TExpr.Use))
					{
						goto IL_01dd;
					}
					expr = ((TExpr.Use)exp).expr;
				}
				result = expr.Walk(_N_Undecorate_closure_93588._N_undecorate_93582);
			}
			goto IL_01de;
			IL_01de:
			return (TExpr)result;
			IL_00e3:
			TypeVar type = multipleAssign.Type;
			list<Tuple<LocalValue, TExpr>> list2 = list;
			Function<LocalValue, TExpr, Tuple<LocalValue, TExpr>> convert = new _N__N_lambda__93568__93602(_N_Undecorate_closure_93588);
			result = new TExpr.MultipleAssign(type, list2.Map(convert));
			goto IL_01de;
			IL_01dd:
			result = null;
			goto IL_01de;
		}
	}

	private sealed class _N__N_lambda__93568__93602 : Function<LocalValue, TExpr, Tuple<LocalValue, TExpr>>
	{
		[SpecialName]
		private _N_closureOf_Undecorate_93577 _N_Undecorate_closure_93606;

		public _N__N_lambda__93568__93602(_N_closureOf_Undecorate_93577 _N_Undecorate_closure_93606)
		{
			this._N_Undecorate_closure_93606 = _N_Undecorate_closure_93606;
		}

		[SpecialName]
		public sealed override Tuple<LocalValue, TExpr> apply(LocalValue l, TExpr e)
		{
			return new Tuple<LocalValue, TExpr>(l, e.Walk(_N_Undecorate_closure_93606._N_undecorate_93582));
		}
	}

	private static bool Propagatable(TExpr expr)
	{
		int result;
		while (true)
		{
			if (!(expr is TExpr.LocalRef))
			{
				if (expr is TExpr.FieldMember)
				{
					TExpr obj = ((TExpr.FieldMember)expr).obj;
					result = ((Propagatable(obj) && obj.Type.ToString().StartsWith("list.Cons")) ? 1 : 0);
					break;
				}
				if (expr is TExpr.Call)
				{
					if (((TExpr.Call)expr).func is TExpr.OpCode && ((TExpr.Call)expr).parms is list<Parm>.Cons && ((list<Parm>.Cons)((TExpr.Call)expr).parms).tl is list<Parm>.Cons)
					{
						Parm hd = ((list<Parm>.Cons)((TExpr.Call)expr).parms).hd;
						if ((object)((list<Parm>.Cons)((list<Parm>.Cons)((TExpr.Call)expr).parms).tl).tl == list<Parm>.Nil._N_constant_object)
						{
							Parm hd2 = ((list<Parm>.Cons)((list<Parm>.Cons)((TExpr.Call)expr).parms).tl).hd;
							if (Propagatable(hd.expr))
							{
								expr = hd2.expr;
								continue;
							}
							result = 0;
							break;
						}
					}
					goto IL_01bc;
				}
				if (!(expr is TExpr.Literal))
				{
					if (expr is TExpr.TypeConversion)
					{
						TExpr obj = ((TExpr.TypeConversion)expr).expr;
						expr = obj;
						continue;
					}
					if (expr is TExpr.Tuple)
					{
						list<TExpr> list = ((TExpr.Tuple)expr).args;
						result = (list.ForAll(_N_static_proxy_93408.single_instance) ? 1 : 0);
						break;
					}
					if (!(expr is TExpr.Use))
					{
						goto IL_01bc;
					}
				}
			}
			result = 1;
			break;
			IL_01bc:
			result = 0;
			break;
		}
		return (byte)result != 0;
	}

	private static void SetDefOf(TExpr expr, TExpr.Def def_of)
	{
		_N_closureOf_SetDefOf_93428 n_closureOf_SetDefOf_ = new _N_closureOf_SetDefOf_93428();
		n_closureOf_SetDefOf_._N_def_of_93433 = def_of;
		Function<TExpr, TExpr> f = new _N_Inject__93435(n_closureOf_SetDefOf_);
		TExpr tExpr = expr.Walk(f);
	}

	private static TExpr MultipleAssignResolver(TExpr.MultipleAssign expr)
	{
		_N_closureOf_MultipleAssignResolver_93466 n_MultipleAssignResolver_cp_ = new _N_closureOf_MultipleAssignResolver_93466();
		list<Tuple<LocalValue, TExpr>> list = expr.assigns;
		TypeVar type = expr.Type;
		Function<LocalValue, TExpr, Tuple<LocalValue, TExpr>> instance = _N__N_lambda__93458__93485.Instance;
		return new TExpr.Sequence(new TExpr.MultipleAssign(type, list.Map(instance)), _N_LayDefs_93474(n_MultipleAssignResolver_cp_, list));
	}

	private static TExpr decorate(TExpr expr)
	{
		object result;
		if (expr is TExpr.LocalRef)
		{
			result = new TExpr.Use((TExpr.LocalRef)expr, null);
		}
		else if (expr is TExpr.Assign)
		{
			if (!(((TExpr.Assign)expr).target is TExpr.LocalRef))
			{
				goto IL_00e9;
			}
			TExpr.LocalRef expr2 = (TExpr.LocalRef)((TExpr.Assign)expr).target;
			LocalValue decl = ((TExpr.LocalRef)((TExpr.Assign)expr).target).decl;
			TExpr source = ((TExpr.Assign)expr).source;
			source = source.Walk(_N_static_proxy_93530.single_instance);
			if (decl.CanInline && Propagatable(source))
			{
				TExpr.Def def = new TExpr.Def(expr2, source);
				SetDefOf(source, def);
				result = new TExpr.Assign(def, source);
			}
			else
			{
				result = new TExpr.Assign(new TExpr.Def(expr2, null), source);
			}
		}
		else
		{
			if (!(expr is TExpr.MultipleAssign))
			{
				goto IL_00e9;
			}
			result = MultipleAssignResolver((TExpr.MultipleAssign)expr);
		}
		goto IL_00ea;
		IL_00ea:
		return (TExpr)result;
		IL_00e9:
		result = null;
		goto IL_00ea;
	}

	public static TExpr Decorate(TExpr expr)
	{
		return expr.Walk(_N_static_proxy_93549.single_instance);
	}

	public static TExpr Undecorate(TExpr expr)
	{
		_N_closureOf_Undecorate_93577 n_closureOf_Undecorate_ = new _N_closureOf_Undecorate_93577();
		n_closureOf_Undecorate_._N_undecorate_93582 = new _N_undecorate__93584(n_closureOf_Undecorate_);
		return expr.Walk(n_closureOf_Undecorate_._N_undecorate_93582);
	}

	[CompilerGenerated]
	internal override void RelocateImplInternal(RelocationInfo _info)
	{
	}

	void ISupportRelocation.RelocateImpl(RelocationInfo _info)
	{
		//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
		this.RelocateImplInternal(_info);
	}

	private static TExpr _N_LayDefs_93474(_N_closureOf_MultipleAssignResolver_93466 _N_MultipleAssignResolver_cp_93473, list<Tuple<LocalValue, TExpr>> assigns)
	{
		if (assigns is list<Tuple<LocalValue, TExpr>>.Cons)
		{
			object result;
			if ((object)((list<Tuple<LocalValue, TExpr>>.Cons)assigns).tl == list<Tuple<LocalValue, TExpr>>.Nil._N_constant_object)
			{
				LocalValue field = ((list<Tuple<LocalValue, TExpr>>.Cons)assigns).hd.Field0;
				result = new TExpr.Def(new TExpr.LocalRef(field), null);
			}
			else
			{
				LocalValue field = ((list<Tuple<LocalValue, TExpr>>.Cons)assigns).hd.Field0;
				list<Tuple<LocalValue, TExpr>> assigns2 = ((list<Tuple<LocalValue, TExpr>>.Cons)assigns).tl;
				result = new TExpr.Sequence(new TExpr.Def(new TExpr.LocalRef(field), null), _N_LayDefs_93474(_N_MultipleAssignResolver_cp_93473, assigns2));
			}
			return (TExpr)result;
		}
		throw new AssertionException("ncc\\optimization\\Decorator.n", 75, "", "");
	}
}
