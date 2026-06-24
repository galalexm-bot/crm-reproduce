using System;
using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Collections;
using Nemerle.Compiler.Typedtree;
using Nemerle.Core;

namespace Nemerle.Compiler;

internal class Preparer : ISupportRelocation
{
	private sealed class _N_closureOf_AddDefs_93799
	{
		internal Hashtable<LocalValue, int> _N_defined_93804;

		internal _N_closureOf_AddDefs_93799()
		{
		}
	}

	private sealed class _N_CountLocals__93806 : Function<TExpr, TExpr>
	{
		[SpecialName]
		private _N_closureOf_AddDefs_93799 _N_AddDefs_closure_93810;

		public _N_CountLocals__93806(_N_closureOf_AddDefs_93799 _N_AddDefs_closure_93810)
		{
			this._N_AddDefs_closure_93810 = _N_AddDefs_closure_93810;
		}

		[SpecialName]
		public sealed override TExpr apply(TExpr e)
		{
			object result;
			if (e is TExpr.DefValIn)
			{
				LocalValue name = ((TExpr.DefValIn)e).name;
				TExpr val = ((TExpr.DefValIn)e).val;
				TExpr body = ((TExpr.DefValIn)e).body;
				if (!name.IsCache || !name.Type.Fix().IsValueType)
				{
					goto IL_0062;
				}
				result = new TExpr.DefValIn(name, val, body);
			}
			else
			{
				if (!(e is TExpr.LocalRef))
				{
					goto IL_0062;
				}
				LocalValue name = ((TExpr.LocalRef)e).decl;
				Hashtable<LocalValue, int> n_defined_ = _N_AddDefs_closure_93810._N_defined_93804;
				LocalValue key = name;
				int value;
				if (_N_AddDefs_closure_93810._N_defined_93804.Contains(name))
				{
					value = checked(_N_AddDefs_closure_93810._N_defined_93804[name] + 1);
				}
				else
				{
					name.EverUsed = true;
					value = 1;
				}
				n_defined_[key] = value;
				result = e;
			}
			goto IL_00ce;
			IL_0062:
			result = null;
			goto IL_00ce;
			IL_00ce:
			return (TExpr)result;
		}
	}

	private sealed class _N__N_lambda__93781__93831 : Function<Nemerle.Builtins.Tuple<LocalValue, int>, Nemerle.Builtins.Tuple<LocalValue, int>, int>
	{
		[SpecialName]
		public static readonly _N__N_lambda__93781__93831 Instance = new _N__N_lambda__93781__93831();

		[SpecialName]
		public sealed override int apply(Nemerle.Builtins.Tuple<LocalValue, int> lv1, Nemerle.Builtins.Tuple<LocalValue, int> lv2)
		{
			return checked(lv1.Field1 - lv2.Field1);
		}
	}

	private sealed class _N_Remove__93860 : Function<TExpr, TExpr>
	{
		[SpecialName]
		public static readonly _N_Remove__93860 Instance = new _N_Remove__93860();

		[SpecialName]
		public sealed override TExpr apply(TExpr e)
		{
			object result;
			if (e is TExpr.DefValIn)
			{
				if (((TExpr.DefValIn)e).val is TExpr.DefaultValue)
				{
					TExpr body = ((TExpr.DefValIn)e).body;
					result = RemoveDefs(body);
				}
				else
				{
					LocalValue name = ((TExpr.DefValIn)e).name;
					TExpr body = ((TExpr.DefValIn)e).val;
					TExpr body2 = ((TExpr.DefValIn)e).body;
					if (name.IsCache && name.Type.Fix().IsValueType)
					{
						goto IL_00a8;
					}
					result = new TExpr.Sequence(new TExpr.Assign(new TExpr.LocalRef(name.Type, name), RemoveDefs(body)), RemoveDefs(body2));
				}
				goto IL_00b0;
			}
			goto IL_00a8;
			IL_00a8:
			result = null;
			goto IL_00b0;
			IL_00b0:
			return (TExpr)result;
		}
	}

	private sealed class _N_closureOf_TupleDismounter_93929
	{
		internal Hashtable<LocalValue, bool> _N_tuple2strip_93938;

		internal Hashtable<LocalValue, LocalValue[]> _N_tuple2locals_93936;

		internal Function<TExpr, TExpr> _N_SplitTrivialTuple_93934;

		internal _N_closureOf_TupleDismounter_93929()
		{
		}
	}

	private sealed class _N_GatherTrivialTuple__93940 : Function<TExpr, TExpr>
	{
		[SpecialName]
		private _N_closureOf_TupleDismounter_93929 _N_TupleDismounter_closure_93944;

		public _N_GatherTrivialTuple__93940(_N_closureOf_TupleDismounter_93929 _N_TupleDismounter_closure_93944)
		{
			this._N_TupleDismounter_closure_93944 = _N_TupleDismounter_closure_93944;
		}

		[SpecialName]
		public sealed override TExpr apply(TExpr e)
		{
			object result;
			if (e is TExpr.LocalRef)
			{
				LocalValue decl = ((TExpr.LocalRef)e).decl;
				if (!_N_TupleDismounter_closure_93944._N_tuple2strip_93938.Contains(decl))
				{
					goto IL_0154;
				}
				_N_TupleDismounter_closure_93944._N_tuple2strip_93938.Remove(decl);
				result = e;
			}
			else if (e is TExpr.DefValIn)
			{
				if (!(((TExpr.DefValIn)e).val is TExpr.Tuple))
				{
					goto IL_0154;
				}
				LocalValue decl = ((TExpr.DefValIn)e).name;
				_N_TupleDismounter_closure_93944._N_tuple2strip_93938[decl] = true;
				result = null;
			}
			else if (e is TExpr.TupleIndexer)
			{
				if (!(((TExpr.TupleIndexer)e).obj is TExpr.LocalRef))
				{
					goto IL_0154;
				}
				result = e;
			}
			else
			{
				if (!(e is TExpr.MultipleAssign))
				{
					goto IL_0154;
				}
				list<Nemerle.Builtins.Tuple<LocalValue, TExpr>> list = ((TExpr.MultipleAssign)e).assigns;
				list = list;
				while (list is list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>.Cons)
				{
					Nemerle.Builtins.Tuple<LocalValue, TExpr> hd = ((list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>.Cons)list).hd;
					list = ((list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>.Cons)list).tl;
					LocalValue decl = hd.Field0;
					if (_N_TupleDismounter_closure_93944._N_tuple2strip_93938.Contains(decl))
					{
						_N_TupleDismounter_closure_93944._N_tuple2strip_93938.Remove(decl);
					}
					list = list;
				}
				result = null;
			}
			goto IL_0155;
			IL_0155:
			return (TExpr)result;
			IL_0154:
			result = null;
			goto IL_0155;
		}
	}

	private sealed class _N_SplitTrivialTuple__93966 : Function<TExpr, TExpr>
	{
		[SpecialName]
		private _N_closureOf_TupleDismounter_93929 _N_TupleDismounter_closure_93970;

		public _N_SplitTrivialTuple__93966(_N_closureOf_TupleDismounter_93929 _N_TupleDismounter_closure_93970)
		{
			this._N_TupleDismounter_closure_93970 = _N_TupleDismounter_closure_93970;
		}

		[SpecialName]
		public sealed override TExpr apply(TExpr e)
		{
			_N_closureOf_SplitTrivialTuple_93975 n_closureOf_SplitTrivialTuple_ = new _N_closureOf_SplitTrivialTuple_93975();
			object result;
			if (e is TExpr.DefValIn)
			{
				if (((TExpr.DefValIn)e).val is TExpr.Tuple)
				{
					n_closureOf_SplitTrivialTuple_._N_name_93982 = ((TExpr.DefValIn)e).name;
					list<TExpr> args = ((TExpr.Tuple)((TExpr.DefValIn)e).val).args;
					TExpr body = ((TExpr.DefValIn)e).body;
					if (_N_TupleDismounter_closure_93970._N_tuple2strip_93938.Contains(n_closureOf_SplitTrivialTuple_._N_name_93982))
					{
						n_closureOf_SplitTrivialTuple_._N_nameprefix_93980 = Util.tmpname(n_closureOf_SplitTrivialTuple_._N_name_93982.Name);
						list<LocalValue> list = _N_CreateLocalValues_93989(n_closureOf_SplitTrivialTuple_, 0, args);
						_N_TupleDismounter_closure_93970._N_tuple2locals_93936[n_closureOf_SplitTrivialTuple_._N_name_93982] = list.ToArray();
						result = _N_LayDefs_94005(n_closureOf_SplitTrivialTuple_, list, args, body.Walk(_N_TupleDismounter_closure_93970._N_SplitTrivialTuple_93934));
						goto IL_0176;
					}
				}
			}
			else if (e is TExpr.TupleIndexer && ((TExpr.TupleIndexer)e).obj is TExpr.LocalRef)
			{
				LocalValue decl = ((TExpr.LocalRef)((TExpr.TupleIndexer)e).obj).decl;
				int pos = ((TExpr.TupleIndexer)e).pos;
				if (_N_TupleDismounter_closure_93970._N_tuple2locals_93936.Contains(decl))
				{
					result = new TExpr.LocalRef(_N_TupleDismounter_closure_93970._N_tuple2locals_93936[decl][pos]);
					goto IL_0176;
				}
			}
			result = null;
			goto IL_0176;
			IL_0176:
			return (TExpr)result;
		}
	}

	private sealed class _N_closureOf_SplitTrivialTuple_93975
	{
		internal LocalValue _N_name_93982;

		internal string _N_nameprefix_93980;

		internal _N_closureOf_SplitTrivialTuple_93975()
		{
		}
	}

	private sealed class _N_closureOf_Strip_94039
	{
		internal Hashtable<int, bool> _N_usedlabels_94048;

		internal Function<TExpr, TExpr> _N_WalkerGatherUsedLabels_94046;

		internal Function<TExpr, TExpr> _N_WalkerStripLabels_94044;

		internal _N_closureOf_Strip_94039()
		{
		}
	}

	private sealed class _N_WalkerGatherUsedLabels__94050 : Function<TExpr, TExpr>
	{
		[SpecialName]
		private _N_closureOf_Strip_94039 _N_Strip_closure_94054;

		public _N_WalkerGatherUsedLabels__94050(_N_closureOf_Strip_94039 _N_Strip_closure_94054)
		{
			this._N_Strip_closure_94054 = _N_Strip_closure_94054;
		}

		[SpecialName]
		public sealed override TExpr apply(TExpr x)
		{
			object result;
			if (x is TExpr.Call)
			{
				if (!(((TExpr.Call)x).func is TExpr.OpCode) || !(((TExpr.OpCode)((TExpr.Call)x).func).name == "=="))
				{
					goto IL_01cd;
				}
				list<Parm> list = ((TExpr.Call)x).parms;
				TExpr expr = list.Tail.Head.expr;
				result = ((!(expr is TExpr.Literal) || !(((TExpr.Literal)expr).val is Literal.Bool) || !((Literal.Bool)((TExpr.Literal)expr).val).val) ? null : list.Head.expr.Walk(_N_Strip_closure_94054._N_WalkerGatherUsedLabels_94046));
			}
			else if (x is TExpr.MultipleAssign)
			{
				if (!(((TExpr.MultipleAssign)x).assigns is list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>.Cons) || (object)((list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>.Cons)((TExpr.MultipleAssign)x).assigns).tl != list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>.Nil._N_constant_object)
				{
					goto IL_01cd;
				}
				LocalValue field = ((list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>.Cons)((TExpr.MultipleAssign)x).assigns).hd.Field0;
				TExpr expr = ((list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>.Cons)((TExpr.MultipleAssign)x).assigns).hd.Field1;
				result = new TExpr.Assign(x.Type, new TExpr.LocalRef(field.Type, field), expr.Walk(_N_Strip_closure_94054._N_WalkerGatherUsedLabels_94046));
			}
			else
			{
				if (!(x is TExpr.Goto))
				{
					goto IL_01cd;
				}
				int target = ((TExpr.Goto)x).target;
				_N_Strip_closure_94054._N_usedlabels_94048[target] = true;
				result = null;
			}
			goto IL_01ce;
			IL_01ce:
			return (TExpr)result;
			IL_01cd:
			result = null;
			goto IL_01ce;
		}
	}

	private sealed class _N_WalkerStripLabels__94071 : Function<TExpr, TExpr>
	{
		[SpecialName]
		private _N_closureOf_Strip_94039 _N_Strip_closure_94075;

		public _N_WalkerStripLabels__94071(_N_closureOf_Strip_94039 _N_Strip_closure_94075)
		{
			this._N_Strip_closure_94075 = _N_Strip_closure_94075;
		}

		[SpecialName]
		public sealed override TExpr apply(TExpr expr)
		{
			object result;
			if (expr is TExpr.Label)
			{
				int id = ((TExpr.Label)expr).id;
				TExpr body = ((TExpr.Label)expr).body;
				if (!_N_Strip_closure_94075._N_usedlabels_94048.ContainsKey(id))
				{
					result = body.Walk(_N_Strip_closure_94075._N_WalkerStripLabels_94044);
					goto IL_0057;
				}
			}
			result = null;
			goto IL_0057;
			IL_0057:
			return (TExpr)result;
		}
	}

	public static TExpr AddDefs(TExpr e, list<TParameter> parms)
	{
		int num = 0;
		TExpr tExpr = null;
		_N_closureOf_AddDefs_93799 n_closureOf_AddDefs_ = new _N_closureOf_AddDefs_93799();
		n_closureOf_AddDefs_._N_defined_93804 = new Hashtable<LocalValue, int>();
		Function<TExpr, TExpr> f = new _N_CountLocals__93806(n_closureOf_AddDefs_);
		tExpr = e.Walk(f);
		list<TParameter> list = parms;
		while (list is list<TParameter>.Cons)
		{
			TParameter hd = ((list<TParameter>.Cons)list).hd;
			list = ((list<TParameter>.Cons)list).tl;
			n_closureOf_AddDefs_._N_defined_93804.Remove(hd.decl);
			list = list;
		}
		Nemerle.Builtins.Tuple<LocalValue, int>[] keyValuePairs = n_closureOf_AddDefs_._N_defined_93804.KeyValuePairs;
		Function<Nemerle.Builtins.Tuple<LocalValue, int>, Nemerle.Builtins.Tuple<LocalValue, int>, int> instance = _N__N_lambda__93781__93831.Instance;
		Array.Sort(keyValuePairs, instance.apply);
		for (num = 0; num < keyValuePairs.Length; num = checked(num + 1))
		{
			Nemerle.Builtins.Tuple<LocalValue, int> tuple = keyValuePairs[num];
			LocalValue field = tuple.Field0;
			tExpr = new TExpr.DefValIn(tExpr.Type, field, new TExpr.DefaultValue(field.Type), tExpr);
		}
		return tExpr;
	}

	public static TExpr RemoveDefs(TExpr e)
	{
		Function<TExpr, TExpr> instance = _N_Remove__93860.Instance;
		return e.Walk(instance);
	}

	public static TExpr TupleDismounter(TExpr e)
	{
		_N_closureOf_TupleDismounter_93929 n_closureOf_TupleDismounter_ = new _N_closureOf_TupleDismounter_93929();
		n_closureOf_TupleDismounter_._N_tuple2strip_93938 = new Hashtable<LocalValue, bool>();
		Function<TExpr, TExpr> f = new _N_GatherTrivialTuple__93940(n_closureOf_TupleDismounter_);
		n_closureOf_TupleDismounter_._N_tuple2locals_93936 = new Hashtable<LocalValue, LocalValue[]>();
		n_closureOf_TupleDismounter_._N_SplitTrivialTuple_93934 = new _N_SplitTrivialTuple__93966(n_closureOf_TupleDismounter_);
		return e.Walk(f).Walk(n_closureOf_TupleDismounter_._N_SplitTrivialTuple_93934);
	}

	public static TExpr Strip(TExpr e)
	{
		_N_closureOf_Strip_94039 n_closureOf_Strip_ = new _N_closureOf_Strip_94039();
		n_closureOf_Strip_._N_usedlabels_94048 = new Hashtable<int, bool>();
		n_closureOf_Strip_._N_WalkerGatherUsedLabels_94046 = new _N_WalkerGatherUsedLabels__94050(n_closureOf_Strip_);
		n_closureOf_Strip_._N_WalkerStripLabels_94044 = new _N_WalkerStripLabels__94071(n_closureOf_Strip_);
		return e.Walk(n_closureOf_Strip_._N_WalkerGatherUsedLabels_94046).Walk(n_closureOf_Strip_._N_WalkerStripLabels_94044);
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

	private static list<LocalValue> _N_CreateLocalValues_93989(_N_closureOf_SplitTrivialTuple_93975 _N_SplitTrivialTuple_cp_93988, int i, list<TExpr> args)
	{
		object result;
		if ((object)args == list<TExpr>.Nil._N_constant_object)
		{
			result = list<LocalValue>.Nil._N_constant_object;
		}
		else
		{
			if (!(args is list<TExpr>.Cons))
			{
				throw new MatchFailureException();
			}
			TExpr hd = ((list<TExpr>.Cons)args).hd;
			list<TExpr> args2 = ((list<TExpr>.Cons)args).tl;
			LocalValue localValue = new LocalValue(_N_SplitTrivialTuple_cp_93988._N_name_93982.DefinedIn, Convert.ToString(_N_SplitTrivialTuple_cp_93988._N_nameprefix_93980) + "_" + Convert.ToString(i), hd.Type, LocalValue.Kind.Plain._N_constant_object, is_mutable: true);
			localValue.UseFrom(_N_SplitTrivialTuple_cp_93988._N_name_93982.DefinedIn);
			result = new list<LocalValue>.Cons(localValue, _N_CreateLocalValues_93989(_N_SplitTrivialTuple_cp_93988, checked(i + 1), args2));
		}
		return (list<LocalValue>)result;
	}

	private static TExpr _N_LayDefs_94005(_N_closureOf_SplitTrivialTuple_93975 _N_SplitTrivialTuple_cp_94004, list<LocalValue> lvs, list<TExpr> args, TExpr b)
	{
		object result;
		if ((object)lvs == list<LocalValue>.Nil._N_constant_object)
		{
			if ((object)args != list<TExpr>.Nil._N_constant_object)
			{
				goto IL_001c;
			}
			result = b;
		}
		else
		{
			if (!(lvs is list<LocalValue>.Cons) || !(args is list<TExpr>.Cons))
			{
				goto IL_001c;
			}
			LocalValue hd = ((list<LocalValue>.Cons)lvs).hd;
			list<LocalValue> lvs2 = ((list<LocalValue>.Cons)lvs).tl;
			TExpr hd2 = ((list<TExpr>.Cons)args).hd;
			list<TExpr> args2 = ((list<TExpr>.Cons)args).tl;
			result = new TExpr.DefValIn(hd, hd2, _N_LayDefs_94005(_N_SplitTrivialTuple_cp_94004, lvs2, args2, b));
		}
		return (TExpr)result;
		IL_001c:
		throw new AssertionException("ncc\\optimization\\Preparer.n", 124, "", "");
	}
}
