using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CFG;
using Nemerle.Builtins;
using Nemerle.Collections;
using Nemerle.Compiler.Typedtree;
using Nemerle.Core;

namespace Nemerle.Compiler;

internal class Unification : ISupportRelocation
{
	private class Graph : ISupportRelocation
	{
		public class NodeData : ISupportRelocation
		{
			public int use_count;

			public Set<LocalValue> neighbours;

			public NodeData()
			{
				use_count = 1;
				neighbours = new Set<LocalValue>();
			}

			[CompilerGenerated]
			internal override void RelocateImplInternal(RelocationInfo _info)
			{
				if (_info.VisitedObjects.ContainsKey(this))
				{
					return;
				}
				_info.VisitedObjects[this] = 0;
				Set<LocalValue> set = neighbours;
				if (set == null)
				{
					return;
				}
				IEnumerator<LocalValue> enumerator = set.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						LocalValue current = enumerator.Current;
						LocalValue localValue = current;
						((ISupportRelocation)localValue).RelocateImpl(_info);
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
				}
			}

			void ISupportRelocation.RelocateImpl(RelocationInfo _info)
			{
				//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
				this.RelocateImplInternal(_info);
			}
		}

		private sealed class _N_closureOf_AddEdge_94468
		{
			internal Graph _N__N_closurised_this_ptr_94473;

			internal _N_closureOf_AddEdge_94468()
			{
			}
		}

		private sealed class _N_closureOf_GreedyColor_94550
		{
			internal Hashtable<LocalValue, LocalValue> _N_union_94559;

			internal Function<NodeData, NodeData, int> _N_cmp_94557;

			internal Graph _N__N_closurised_this_ptr_94555;

			internal _N_closureOf_GreedyColor_94550()
			{
			}
		}

		private sealed class _N_closureOf_IsDep_94568
		{
			internal LocalValue _N_c_94573;

			internal _N_closureOf_IsDep_94568()
			{
			}
		}

		private sealed class _N__N_lambda__94524__94580 : Function<LocalValue, bool>
		{
			[SpecialName]
			private _N_closureOf_GreedyColor_94550 _N_GreedyColor_closure_94586;

			[SpecialName]
			private _N_closureOf_IsDep_94568 _N_IsDep_closure_94584;

			public _N__N_lambda__94524__94580(_N_closureOf_IsDep_94568 _N_IsDep_closure_94584, _N_closureOf_GreedyColor_94550 _N_GreedyColor_closure_94586)
			{
				this._N_IsDep_closure_94584 = _N_IsDep_closure_94584;
				this._N_GreedyColor_closure_94586 = _N_GreedyColor_closure_94586;
			}

			[SpecialName]
			public sealed override bool apply(LocalValue x)
			{
				return _N_GreedyColor_closure_94586._N_union_94559.Contains(x) && _N_GreedyColor_closure_94586._N_union_94559[x].Equals(_N_IsDep_closure_94584._N_c_94573);
			}
		}

		private sealed class _N__N_lambda__94530__94594 : Function<LocalValue, LocalValue, int>
		{
			[SpecialName]
			private _N_closureOf_GreedyColor_94550 _N_GreedyColor_closure_94598;

			public _N__N_lambda__94530__94594(_N_closureOf_GreedyColor_94550 _N_GreedyColor_closure_94598)
			{
				this._N_GreedyColor_closure_94598 = _N_GreedyColor_closure_94598;
			}

			[SpecialName]
			public sealed override int apply(LocalValue k1, LocalValue k2)
			{
				return _N_GreedyColor_closure_94598._N_cmp_94557.apply(_N_GreedyColor_closure_94598._N__N_closurised_this_ptr_94555.h[k1], _N_GreedyColor_closure_94598._N__N_closurised_this_ptr_94555.h[k2]);
			}
		}

		private readonly Hashtable<LocalValue, NodeData> h;

		public Graph()
		{
			h = new Hashtable<LocalValue, NodeData>();
		}

		public void AddNode(LocalValue l)
		{
			checked
			{
				if (h.Contains(l))
				{
					NodeData nodeData = h[l];
					nodeData.use_count++;
				}
				else
				{
					h[l] = new NodeData();
				}
			}
		}

		public void AddEdge(LocalValue l1, LocalValue l2)
		{
			_N_closureOf_AddEdge_94468 n_closureOf_AddEdge_ = new _N_closureOf_AddEdge_94468();
			n_closureOf_AddEdge_._N__N_closurised_this_ptr_94473 = this;
			_N_AddOneEdge_94476(n_closureOf_AddEdge_, l1, l2);
			_N_AddOneEdge_94476(n_closureOf_AddEdge_, l2, l1);
		}

		public void AddCliqueEdges(list<LocalValue> locals)
		{
			list<LocalValue> list = locals;
			while (list is list<LocalValue>.Cons)
			{
				LocalValue hd = ((list<LocalValue>.Cons)list).hd;
				list<LocalValue> list2 = ((list<LocalValue>.Cons)list).tl;
				list = list2;
				while (list is list<LocalValue>.Cons)
				{
					LocalValue hd2 = ((list<LocalValue>.Cons)list).hd;
					list = ((list<LocalValue>.Cons)list).tl;
					AddEdge(hd, hd2);
					list = list;
				}
				list = list2;
			}
		}

		public list<LocalValue> GetNodes()
		{
			return h.Keys.NToList();
		}

		public void GreedyColor(Hashtable<LocalValue, LocalValue> union, Function<NodeData, NodeData, int> cmp)
		{
			int num = 0;
			LocalValue[] array = null;
			int num2 = 0;
			_N_closureOf_GreedyColor_94550 n_closureOf_GreedyColor_ = new _N_closureOf_GreedyColor_94550();
			n_closureOf_GreedyColor_._N_union_94559 = union;
			n_closureOf_GreedyColor_._N_cmp_94557 = cmp;
			n_closureOf_GreedyColor_._N__N_closurised_this_ptr_94555 = this;
			array = h.Keys.NToArray();
			LocalValue[] array2 = array;
			Function<LocalValue, LocalValue, int> function = new _N__N_lambda__94530__94594(n_closureOf_GreedyColor_);
			System.Array.Sort(array2, function.apply);
			checked
			{
				for (num = 0; num < array.Length; num++)
				{
					LocalValue localValue = array[num];
					if (n_closureOf_GreedyColor_._N_union_94559.Contains(localValue))
					{
						continue;
					}
					for (num2 = num; num2 < array.Length; num2++)
					{
						LocalValue localValue2 = array[num2];
						if (!n_closureOf_GreedyColor_._N_union_94559.Contains(localValue2) && !_N_IsDep_94562(n_closureOf_GreedyColor_, localValue2, localValue))
						{
							n_closureOf_GreedyColor_._N_union_94559[localValue2] = localValue;
						}
					}
				}
			}
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

		private void _N_AddOneEdge_94476(_N_closureOf_AddEdge_94468 _N_AddEdge_cp_94475, LocalValue x1, LocalValue x2)
		{
			if (!h[x1].neighbours.Contains(x2))
			{
				h[x1].neighbours = h[x1].neighbours.Add(x2);
			}
		}

		private bool _N_IsDep_94562(_N_closureOf_GreedyColor_94550 _N_GreedyColor_cp_94561, LocalValue w, LocalValue c)
		{
			_N_closureOf_IsDep_94568 n_closureOf_IsDep_ = new _N_closureOf_IsDep_94568();
			n_closureOf_IsDep_._N_c_94573 = c;
			Set<LocalValue> neighbours = h[w].neighbours;
			Function<LocalValue, bool> predicate = new _N__N_lambda__94524__94580(n_closureOf_IsDep_, _N_GreedyColor_cp_94561);
			option<LocalValue> option = neighbours.Find(predicate);
			int result;
			if (option is option<LocalValue>.Some)
			{
				result = 1;
			}
			else
			{
				if (option != option<LocalValue>.None._N_constant_object)
				{
					throw new MatchFailureException();
				}
				result = 0;
			}
			return (byte)result != 0;
		}
	}

	private sealed class _N_closureOf_Calculate_94278
	{
		internal global::CFG.Array _N_cfg_94287;

		internal CFG.DefUseInOut[] _N_e_ExprUsed_94285;

		internal Graph _N_col_94283;

		internal _N_closureOf_Calculate_94278()
		{
		}
	}

	private sealed class _N_CountLocalRefs__94289 : Function<int, Node, bool>
	{
		[SpecialName]
		private _N_closureOf_Calculate_94278 _N_Calculate_closure_94293;

		public _N_CountLocalRefs__94289(_N_closureOf_Calculate_94278 _N_Calculate_closure_94293)
		{
			this._N_Calculate_closure_94293 = _N_Calculate_closure_94293;
		}

		[SpecialName]
		public sealed override bool apply(int _N_wildcard_3408, Node v)
		{
			TExpr expr = v.expr;
			LocalValue decl;
			if (expr is TExpr.Use)
			{
				if (((TExpr.Use)expr).expr is TExpr.LocalRef)
				{
					decl = ((TExpr.LocalRef)((TExpr.Use)expr).expr).decl;
					goto IL_003d;
				}
			}
			else if (expr is TExpr.Def && ((TExpr.Def)expr).expr is TExpr.LocalRef)
			{
				decl = ((TExpr.LocalRef)((TExpr.Def)expr).expr).decl;
				goto IL_003d;
			}
			goto IL_0094;
			IL_003d:
			_N_Calculate_closure_94293._N_col_94283.AddNode(decl);
			goto IL_0094;
			IL_0094:
			return true;
		}
	}

	private sealed class _N_AddEdges__94318 : Function<int, Node, bool>
	{
		[SpecialName]
		private _N_closureOf_Calculate_94278 _N_Calculate_closure_94322;

		public _N_AddEdges__94318(_N_closureOf_Calculate_94278 _N_Calculate_closure_94322)
		{
			this._N_Calculate_closure_94322 = _N_Calculate_closure_94322;
		}

		[SpecialName]
		public sealed override bool apply(int k, Node v)
		{
			TExpr expr = v.expr;
			object obj;
			if (expr is TExpr.Def && ((TExpr.Def)expr).expr is TExpr.LocalRef)
			{
				LocalValue decl = ((TExpr.LocalRef)((TExpr.Def)expr).expr).decl;
				obj = new list<LocalValue>.Cons(decl, list<LocalValue>.Nil._N_constant_object);
			}
			else
			{
				obj = list<LocalValue>.Nil._N_constant_object;
			}
			list<LocalValue> list = (list<LocalValue>)obj;
			IEnumerator<int> enumerator = _N_Calculate_closure_94322._N_e_ExprUsed_94285[k].In.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					int current = enumerator.Current;
					int i = current;
					TExpr expr2 = _N_Calculate_closure_94322._N_cfg_94287.GetUse(i).expr;
					if (expr2 is TExpr.LocalRef)
					{
						LocalValue decl2 = ((TExpr.LocalRef)expr2).decl;
						list = new list<LocalValue>.Cons(decl2, list);
						continue;
					}
					throw new AssertionException("ncc\\optimization\\Unification.n", 137, "", "");
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			_N_Calculate_closure_94322._N_col_94283.AddCliqueEdges(list);
			return true;
		}
	}

	private sealed class _N_sc__94346 : Function<Graph.NodeData, Graph.NodeData, int>
	{
		[SpecialName]
		public static readonly _N_sc__94346 Instance = new _N_sc__94346();

		[SpecialName]
		public sealed override int apply(Graph.NodeData l1, Graph.NodeData l2)
		{
			checked
			{
				int num = l2.use_count - l1.use_count;
				return (num != 0) ? num : (l2.neighbours.Count - l1.neighbours.Count);
			}
		}
	}

	private sealed class _N_closureOf_Apply_94394
	{
		internal Hashtable<LocalValue, LocalValue> _N_m_94401;

		internal Function<TExpr, TExpr> _N_Replace_94399;

		internal _N_closureOf_Apply_94394()
		{
		}
	}

	private sealed class _N_Replace__94410 : Function<TExpr, TExpr>
	{
		[SpecialName]
		private _N_closureOf_Apply_94394 _N_Apply_closure_94414;

		public _N_Replace__94410(_N_closureOf_Apply_94394 _N_Apply_closure_94414)
		{
			this._N_Apply_closure_94414 = _N_Apply_closure_94414;
		}

		[SpecialName]
		public sealed override TExpr apply(TExpr _N_wildcard_3409)
		{
			object result;
			if (_N_wildcard_3409 is TExpr.LocalRef)
			{
				LocalValue decl = ((TExpr.LocalRef)_N_wildcard_3409).decl;
				result = new TExpr.LocalRef(decl.Type, _N_GetUnited_94404(_N_Apply_closure_94414, decl));
			}
			else if (_N_wildcard_3409 is TExpr.MultipleAssign)
			{
				list<Nemerle.Builtins.Tuple<LocalValue, TExpr>> list = ((TExpr.MultipleAssign)_N_wildcard_3409).assigns;
				TypeVar type = ((TExpr.MultipleAssign)_N_wildcard_3409).Type;
				Function<LocalValue, TExpr, Nemerle.Builtins.Tuple<LocalValue, TExpr>> convert = new _N__N_lambda__94386__94427(_N_Apply_closure_94414);
				result = new TExpr.MultipleAssign(type, list.Map(convert));
			}
			else if (_N_wildcard_3409 is TExpr.Def)
			{
				TExpr expr = ((TExpr.Def)_N_wildcard_3409).expr;
				TExpr into = ((TExpr.Def)_N_wildcard_3409).into;
				result = new TExpr.Def(expr.Walk(_N_Apply_closure_94414._N_Replace_94399), into);
			}
			else if (_N_wildcard_3409 is TExpr.Use)
			{
				TExpr expr = ((TExpr.Use)_N_wildcard_3409).expr;
				TExpr.Def def_of = ((TExpr.Use)_N_wildcard_3409).def_of;
				result = new TExpr.Use(expr.Walk(_N_Apply_closure_94414._N_Replace_94399), def_of);
			}
			else
			{
				result = null;
			}
			return (TExpr)result;
		}
	}

	private sealed class _N__N_lambda__94386__94427 : Function<LocalValue, TExpr, Nemerle.Builtins.Tuple<LocalValue, TExpr>>
	{
		[SpecialName]
		private _N_closureOf_Apply_94394 _N_Apply_closure_94431;

		public _N__N_lambda__94386__94427(_N_closureOf_Apply_94394 _N_Apply_closure_94431)
		{
			this._N_Apply_closure_94431 = _N_Apply_closure_94431;
		}

		[SpecialName]
		public sealed override Nemerle.Builtins.Tuple<LocalValue, TExpr> apply(LocalValue l, TExpr e)
		{
			return new Nemerle.Builtins.Tuple<LocalValue, TExpr>(_N_GetUnited_94404(_N_Apply_closure_94431, l), e.Walk(_N_Apply_closure_94431._N_Replace_94399));
		}
	}

	public static Hashtable<LocalValue, LocalValue> Calculate(global::CFG.Array cfg, CFG.DefUseInOut[] e_ExprUsed, list<TParameter> fp)
	{
		_N_closureOf_Calculate_94278 n_closureOf_Calculate_ = new _N_closureOf_Calculate_94278();
		n_closureOf_Calculate_._N_cfg_94287 = cfg;
		n_closureOf_Calculate_._N_e_ExprUsed_94285 = e_ExprUsed;
		n_closureOf_Calculate_._N_col_94283 = new Graph();
		Function<int, Node, bool> f = new _N_CountLocalRefs__94289(n_closureOf_Calculate_);
		n_closureOf_Calculate_._N_cfg_94287.Iterate(f);
		list<LocalValue> list = n_closureOf_Calculate_._N_col_94283.GetNodes();
		while (list is list<LocalValue>.Cons)
		{
			LocalValue hd = ((list<LocalValue>.Cons)list).hd;
			list<LocalValue> list2 = ((list<LocalValue>.Cons)list).tl;
			hd = hd;
			list = n_closureOf_Calculate_._N_col_94283.GetNodes();
			while (list is list<LocalValue>.Cons)
			{
				LocalValue hd2 = ((list<LocalValue>.Cons)list).hd;
				list = ((list<LocalValue>.Cons)list).tl;
				hd2 = hd2;
				if (!hd.Type.Equals(hd2.Type))
				{
					n_closureOf_Calculate_._N_col_94283.AddEdge(hd, hd2);
				}
				list = list;
			}
			list = list2;
		}
		f = new _N_AddEdges__94318(n_closureOf_Calculate_);
		n_closureOf_Calculate_._N_cfg_94287.Iterate(f);
		Function<Graph.NodeData, Graph.NodeData, int> instance = _N_sc__94346.Instance;
		Hashtable<LocalValue, LocalValue> hashtable = new Hashtable<LocalValue, LocalValue>();
		list<TParameter> list3 = fp;
		while (list3 is list<TParameter>.Cons)
		{
			TParameter hd3 = ((list<TParameter>.Cons)list3).hd;
			list3 = ((list<TParameter>.Cons)list3).tl;
			hd3 = hd3;
			hashtable[hd3.decl] = hd3.decl;
			list3 = list3;
		}
		n_closureOf_Calculate_._N_col_94283.GreedyColor(hashtable, instance);
		return hashtable;
	}

	public static TExpr Apply(TExpr e, Hashtable<LocalValue, LocalValue> m)
	{
		_N_closureOf_Apply_94394 n_closureOf_Apply_ = new _N_closureOf_Apply_94394();
		n_closureOf_Apply_._N_m_94401 = m;
		n_closureOf_Apply_._N_Replace_94399 = new _N_Replace__94410(n_closureOf_Apply_);
		return e.Walk(n_closureOf_Apply_._N_Replace_94399);
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

	private static LocalValue _N_GetUnited_94404(_N_closureOf_Apply_94394 _N_Apply_cp_94403, LocalValue e)
	{
		return _N_Apply_cp_94403._N_m_94401[e];
	}
}
