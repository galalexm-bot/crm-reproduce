using System.Runtime.CompilerServices;
using CFG;
using Nemerle.Builtins;
using Nemerle.Collections;
using Nemerle.Compiler.Typedtree;
using Nemerle.Core;

namespace Nemerle.Compiler;

internal class CFG : ISupportRelocation
{
	public class DefUseInOut : ISupportRelocation
	{
		public Set<int> Def;

		public Set<int> Use;

		public Set<int> In;

		public Set<int> Out;

		public DefUseInOut(Set<int> d, Set<int> u, Set<int> i, Set<int> o)
		{
			Def = d;
			Use = u;
			In = i;
			Out = o;
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
	}

	public class GenKillInOut : ISupportRelocation
	{
		public Set<int> Gen;

		public Set<int> Kill;

		public Set<int> In;

		public Set<int> Out;

		public GenKillInOut(Set<int> g, Set<int> k, Set<int> i, Set<int> o)
		{
			Gen = g;
			Kill = k;
			In = i;
			Out = o;
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
	}

	private sealed class _N_closureOf_BuildCFG_92914
	{
		internal Array _N_cfg_92923;

		internal list<Tuple<int, int>> _N_gotolist_92921;

		internal Hashtable<int, int> _N_labels_92919;

		internal _N_closureOf_BuildCFG_92914()
		{
		}
	}

	private sealed class _N_closureOf_BuildCFG_92932
	{
		internal int _N_node_92939;

		internal Function<TExpr, TExpr> _N_NodesAdd_92937;

		internal _N_closureOf_BuildCFG_92932()
		{
		}
	}

	private sealed class _N_NodesAdd__92941 : Function<TExpr, TExpr>
	{
		[SpecialName]
		private _N_closureOf_BuildCFG_92914 _N_BuildCFG_closure_92947;

		[SpecialName]
		private _N_closureOf_BuildCFG_92932 _N_BuildCFG_closure_92945;

		public _N_NodesAdd__92941(_N_closureOf_BuildCFG_92932 _N_BuildCFG_closure_92945, _N_closureOf_BuildCFG_92914 _N_BuildCFG_closure_92947)
		{
			this._N_BuildCFG_closure_92945 = _N_BuildCFG_closure_92945;
			this._N_BuildCFG_closure_92947 = _N_BuildCFG_closure_92947;
		}

		[SpecialName]
		public sealed override TExpr apply(TExpr expr)
		{
			object result;
			switch (TExpr._N_GetVariantCodeSafe(expr))
			{
			default:
				if (!(expr is TExpr.ArrayIndexer) && !(expr is TExpr.PointerIndexer) && !(expr is TExpr.TupleIndexer))
				{
					if (expr is TExpr.OpCode)
					{
						goto case 0;
					}
					if (expr is TExpr.MacroEnvelope || expr is TExpr.MethodAddress)
					{
						goto case 2;
					}
					if (!(expr is TExpr.MultipleAssign))
					{
						if (expr is TExpr.Label)
						{
							int id = ((TExpr.Label)expr).id;
							_N_BuildCFG_closure_92945._N_node_92939 = _N_BuildCFG_closure_92947._N_cfg_92923.AddEdge(_N_BuildCFG_closure_92945._N_node_92939, _N_BuildCFG_closure_92947._N_cfg_92923.AddNode(null));
							_N_BuildCFG_closure_92947._N_labels_92919[id] = _N_BuildCFG_closure_92945._N_node_92939;
							result = null;
							break;
						}
						if (expr is TExpr.Goto)
						{
							int id = ((TExpr.Goto)expr).target;
							_N_BuildCFG_closure_92947._N_gotolist_92921 = new list<Tuple<int, int>>.Cons(new Tuple<int, int>(_N_BuildCFG_closure_92945._N_node_92939, id), _N_BuildCFG_closure_92947._N_gotolist_92921);
							_N_BuildCFG_closure_92945._N_node_92939 = _N_BuildCFG_closure_92947._N_cfg_92923.AddNode(null);
							result = expr;
							break;
						}
						if (expr is TExpr.DefaultValue)
						{
							goto case 0;
						}
						if (expr is TExpr.If)
						{
							TExpr source = ((TExpr.If)expr).cond;
							TExpr e_then = ((TExpr.If)expr).e_then;
							TExpr target = ((TExpr.If)expr).e_else;
							_N_BuildCFG_closure_92945._N_node_92939 = _N_BuildCFG_92926(_N_BuildCFG_closure_92947, _N_BuildCFG_closure_92945._N_node_92939, source);
							int i = _N_BuildCFG_92926(_N_BuildCFG_closure_92947, _N_BuildCFG_closure_92945._N_node_92939, e_then);
							int i2 = _N_BuildCFG_92926(_N_BuildCFG_closure_92947, _N_BuildCFG_closure_92945._N_node_92939, target);
							int id = _N_BuildCFG_closure_92947._N_cfg_92923.AddNode(null);
							i = _N_BuildCFG_closure_92947._N_cfg_92923.AddEdge(i, id);
							_N_BuildCFG_closure_92945._N_node_92939 = _N_BuildCFG_closure_92947._N_cfg_92923.AddEdge(i2, id);
							result = expr;
							break;
						}
						if (!(expr is TExpr.HasType))
						{
							if (expr is TExpr.Switch)
							{
								TExpr target = ((TExpr.Switch)expr).indexing_expr;
								option<TExpr> option = ((TExpr.Switch)expr).@default;
								list<Tuple<int, TExpr>> list = ((TExpr.Switch)expr).cases;
								int i2 = _N_BuildCFG_92926(_N_BuildCFG_closure_92947, _N_BuildCFG_closure_92945._N_node_92939, target);
								int id = _N_BuildCFG_closure_92947._N_cfg_92923.AddNode(null);
								list = list;
								while (list is list<Tuple<int, TExpr>>.Cons)
								{
									Tuple<int, TExpr> hd = ((list<Tuple<int, TExpr>>.Cons)list).hd;
									list = ((list<Tuple<int, TExpr>>.Cons)list).tl;
									target = hd.Field1;
									int i = _N_BuildCFG_92926(_N_BuildCFG_closure_92947, i2, target);
									_N_BuildCFG_closure_92945._N_node_92939 = _N_BuildCFG_closure_92947._N_cfg_92923.AddEdge(i, id);
									list = list;
								}
								if (option is option<TExpr>.Some)
								{
									target = ((option<TExpr>.Some)option).val;
									i2 = _N_BuildCFG_92926(_N_BuildCFG_closure_92947, i2, target);
									_N_BuildCFG_closure_92945._N_node_92939 = _N_BuildCFG_closure_92947._N_cfg_92923.AddEdge(i2, id);
								}
								result = expr;
							}
							else if (expr is TExpr.DebugInfo)
							{
								result = null;
							}
							else if (expr is TExpr.Def || expr is TExpr.Use)
							{
								_N_BuildCFG_closure_92945._N_node_92939 = _N_BuildCFG_closure_92947._N_cfg_92923.AddEdge(_N_BuildCFG_closure_92945._N_node_92939, _N_BuildCFG_closure_92947._N_cfg_92923.AddNode(expr));
								result = expr;
							}
							else
							{
								result = null;
							}
							break;
						}
					}
				}
				goto case 8;
			case 2:
				result = null;
				break;
			case 0:
			case 3:
			case 4:
			case 5:
			case 11:
			case 12:
			case 14:
				result = null;
				break;
			case 8:
			case 13:
			case 15:
			case 16:
			case 18:
				result = null;
				break;
			case 6:
			{
				TExpr target = ((TExpr.Assign)expr).target;
				TExpr source = ((TExpr.Assign)expr).source;
				source = source.Walk(_N_BuildCFG_closure_92945._N_NodesAdd_92937);
				target = target.Walk(_N_BuildCFG_closure_92945._N_NodesAdd_92937);
				result = expr;
				break;
			}
			case 17:
			{
				list<TExpr> exprs = ((TExpr.Array)expr).args;
				list<TExpr> exprs2 = ((TExpr.Array)expr).dimensions;
				_N_NodesAddFromList_92954(_N_BuildCFG_closure_92945, _N_BuildCFG_closure_92947, exprs2);
				_N_NodesAddFromList_92954(_N_BuildCFG_closure_92945, _N_BuildCFG_closure_92947, exprs);
				result = expr;
				break;
			}
			}
			return (TExpr)result;
		}
	}

	private sealed class _N__N_lambda__92864__92961 : Function<TExpr, TExpr>
	{
		[SpecialName]
		private _N_closureOf_BuildCFG_92914 _N_BuildCFG_closure_92967;

		[SpecialName]
		private _N_closureOf_BuildCFG_92932 _N_BuildCFG_closure_92965;

		public _N__N_lambda__92864__92961(_N_closureOf_BuildCFG_92932 _N_BuildCFG_closure_92965, _N_closureOf_BuildCFG_92914 _N_BuildCFG_closure_92967)
		{
			this._N_BuildCFG_closure_92965 = _N_BuildCFG_closure_92965;
			this._N_BuildCFG_closure_92967 = _N_BuildCFG_closure_92967;
		}

		[SpecialName]
		public sealed override TExpr apply(TExpr e)
		{
			return e.Walk(_N_BuildCFG_closure_92965._N_NodesAdd_92937);
		}
	}

	private sealed class _N_closureOf_BuildExprAvail_93049
	{
		internal UseSet _N_use_93056;

		internal GenKillInOut[] _N_e_ExprAvail_93054;

		internal _N_closureOf_BuildExprAvail_93049()
		{
		}
	}

	private sealed class _N_DefGather__93058 : Function<int, Node, bool>
	{
		[SpecialName]
		private _N_closureOf_BuildExprAvail_93049 _N_BuildExprAvail_closure_93062;

		public _N_DefGather__93058(_N_closureOf_BuildExprAvail_93049 _N_BuildExprAvail_closure_93062)
		{
			this._N_BuildExprAvail_closure_93062 = _N_BuildExprAvail_closure_93062;
		}

		[SpecialName]
		public sealed override bool apply(int i, Node n)
		{
			_N_closureOf_DefGather_93067 n_closureOf_DefGather_ = new _N_closureOf_DefGather_93067();
			TExpr expr = n.expr;
			if (expr is TExpr.Def)
			{
				TExpr expr2 = ((TExpr.Def)expr).expr;
				expr = ((TExpr.Def)expr).into;
				_N_BuildExprAvail_closure_93062._N_use_93056.Insert(expr2, i);
				if (expr != null)
				{
					n_closureOf_DefGather_._N_StripUse_93072 = new _N_StripUse__93082(n_closureOf_DefGather_);
					_N_BuildExprAvail_closure_93062._N_use_93056.Insert(expr.Walk(n_closureOf_DefGather_._N_StripUse_93072), i);
				}
			}
			return true;
		}
	}

	private sealed class _N_closureOf_DefGather_93067
	{
		internal Function<TExpr, TExpr> _N_StripUse_93072;

		internal _N_closureOf_DefGather_93067()
		{
		}
	}

	private sealed class _N_StripUse__93082 : Function<TExpr, TExpr>
	{
		[SpecialName]
		private _N_closureOf_DefGather_93067 _N_DefGather_closure_93086;

		public _N_StripUse__93082(_N_closureOf_DefGather_93067 _N_DefGather_closure_93086)
		{
			this._N_DefGather_closure_93086 = _N_DefGather_closure_93086;
		}

		[SpecialName]
		public sealed override TExpr apply(TExpr _N_wildcard_3406)
		{
			object result;
			if (_N_wildcard_3406 is TExpr.Use)
			{
				TExpr expr = ((TExpr.Use)_N_wildcard_3406).expr;
				result = expr.Walk(_N_DefGather_closure_93086._N_StripUse_93072);
			}
			else
			{
				result = null;
			}
			return (TExpr)result;
		}
	}

	private sealed class _N_ExprAvailInit__93094 : Function<int, Node, bool>
	{
		[SpecialName]
		private _N_closureOf_BuildExprAvail_93049 _N_BuildExprAvail_closure_93098;

		public _N_ExprAvailInit__93094(_N_closureOf_BuildExprAvail_93049 _N_BuildExprAvail_closure_93098)
		{
			this._N_BuildExprAvail_closure_93098 = _N_BuildExprAvail_closure_93098;
		}

		[SpecialName]
		public sealed override bool apply(int i, Node n)
		{
			_N_closureOf_ExprAvailInit_93103 n_closureOf_ExprAvailInit_ = new _N_closureOf_ExprAvailInit_93103();
			n_closureOf_ExprAvailInit_._N_i_93108 = i;
			GenKillInOut[] n_e_ExprAvail_ = _N_BuildExprAvail_closure_93098._N_e_ExprAvail_93054;
			int n_i_ = n_closureOf_ExprAvailInit_._N_i_93108;
			TExpr expr = n.expr;
			GenKillInOut genKillInOut;
			if (expr is TExpr.Def)
			{
				expr = ((TExpr.Def)expr).expr;
				Set<int> g = new Set<int>().Add(n_closureOf_ExprAvailInit_._N_i_93108);
				Set<int> set = _N_BuildExprAvail_closure_93098._N_use_93056.Get(expr);
				Function<int, bool> fn = new _N__N_lambda__93025__93115(n_closureOf_ExprAvailInit_);
				genKillInOut = new GenKillInOut(g, set.Filter(fn), new Set<int>(), _N_BuildExprAvail_closure_93098._N_use_93056.GetAllUsed().Remove(n_closureOf_ExprAvailInit_._N_i_93108));
			}
			else
			{
				genKillInOut = new GenKillInOut(new Set<int>(), new Set<int>(), new Set<int>(), new Set<int>());
			}
			n_e_ExprAvail_[n_i_] = genKillInOut;
			return true;
		}
	}

	private sealed class _N_closureOf_ExprAvailInit_93103
	{
		internal int _N_i_93108;

		internal _N_closureOf_ExprAvailInit_93103()
		{
		}
	}

	private sealed class _N__N_lambda__93025__93115 : Function<int, bool>
	{
		[SpecialName]
		private _N_closureOf_ExprAvailInit_93103 _N_ExprAvailInit_closure_93119;

		public _N__N_lambda__93025__93115(_N_closureOf_ExprAvailInit_93103 _N_ExprAvailInit_closure_93119)
		{
			this._N_ExprAvailInit_closure_93119 = _N_ExprAvailInit_closure_93119;
		}

		[SpecialName]
		public sealed override bool apply(int x)
		{
			return x != _N_ExprAvailInit_closure_93119._N_i_93108;
		}
	}

	private sealed class _N_ExprAvailPropagate__93124 : Function<int, Node, bool>
	{
		[SpecialName]
		private _N_closureOf_BuildExprAvail_93049 _N_BuildExprAvail_closure_93128;

		public _N_ExprAvailPropagate__93124(_N_closureOf_BuildExprAvail_93049 _N_BuildExprAvail_closure_93128)
		{
			this._N_BuildExprAvail_closure_93128 = _N_BuildExprAvail_closure_93128;
		}

		[SpecialName]
		public sealed override bool apply(int i, Node n)
		{
			Set<int> set = null;
			GenKillInOut genKillInOut = _N_BuildExprAvail_closure_93128._N_e_ExprAvail_93054[i];
			GenKillInOut genKillInOut2 = genKillInOut;
			list<int> prev = n.prev;
			Set<int> @in;
			if ((object)prev == list<int>.Nil._N_constant_object)
			{
				@in = new Set<int>();
			}
			else
			{
				if (!(prev is list<int>.Cons))
				{
					throw new MatchFailureException();
				}
				int hd = ((list<int>.Cons)prev).hd;
				prev = ((list<int>.Cons)prev).tl;
				set = _N_BuildExprAvail_closure_93128._N_e_ExprAvail_93054[hd].Out;
				prev = prev;
				while (prev is list<int>.Cons)
				{
					hd = ((list<int>.Cons)prev).hd;
					prev = ((list<int>.Cons)prev).tl;
					set = set.Intersect(_N_BuildExprAvail_closure_93128._N_e_ExprAvail_93054[hd].Out);
					prev = prev;
				}
				@in = set;
			}
			Set<int> set2 = (genKillInOut2.In = @in);
			set = genKillInOut.Out;
			genKillInOut.Out = genKillInOut.Gen.Sum(genKillInOut.In.Subtract(genKillInOut.Kill));
			return genKillInOut.Out.Count == set.Count;
		}
	}

	private sealed class _N_closureOf_BuildExprUsed_93177
	{
		internal UseSet _N_use_93184;

		internal DefUseInOut[] _N_e_ExprUsed_93182;

		internal _N_closureOf_BuildExprUsed_93177()
		{
		}
	}

	private sealed class _N_UseGather__93186 : Function<int, Node, bool>
	{
		[SpecialName]
		private _N_closureOf_BuildExprUsed_93177 _N_BuildExprUsed_closure_93190;

		public _N_UseGather__93186(_N_closureOf_BuildExprUsed_93177 _N_BuildExprUsed_closure_93190)
		{
			this._N_BuildExprUsed_closure_93190 = _N_BuildExprUsed_closure_93190;
		}

		[SpecialName]
		public sealed override bool apply(int i, Node n)
		{
			TExpr expr = n.expr;
			if (expr is TExpr.Use)
			{
				expr = ((TExpr.Use)expr).expr;
				_N_BuildExprUsed_closure_93190._N_use_93184.Insert(expr, i);
			}
			return true;
		}
	}

	private sealed class _N_ExprUsedInit__93200 : Function<int, Node, bool>
	{
		[SpecialName]
		private _N_closureOf_BuildExprUsed_93177 _N_BuildExprUsed_closure_93204;

		public _N_ExprUsedInit__93200(_N_closureOf_BuildExprUsed_93177 _N_BuildExprUsed_closure_93204)
		{
			this._N_BuildExprUsed_closure_93204 = _N_BuildExprUsed_closure_93204;
		}

		[SpecialName]
		public sealed override bool apply(int i, Node n)
		{
			DefUseInOut[] n_e_ExprUsed_ = _N_BuildExprUsed_closure_93204._N_e_ExprUsed_93182;
			TExpr expr = n.expr;
			object obj;
			if (!(expr is TExpr.Def))
			{
				obj = ((!(expr is TExpr.Use)) ? new DefUseInOut(new Set<int>(), new Set<int>(), new Set<int>(), new Set<int>()) : new DefUseInOut(new Set<int>(), new Set<int>().Add(i), new Set<int>(), new Set<int>()));
			}
			else
			{
				expr = ((TExpr.Def)expr).expr;
				obj = new DefUseInOut(_N_BuildExprUsed_closure_93204._N_use_93184.Get(expr), new Set<int>(), new Set<int>(), new Set<int>());
			}
			n_e_ExprUsed_[i] = (DefUseInOut)obj;
			return true;
		}
	}

	private sealed class _N_ExprUsedPropagate__93215 : Function<int, Node, bool>
	{
		[SpecialName]
		private _N_closureOf_BuildExprUsed_93177 _N_BuildExprUsed_closure_93219;

		public _N_ExprUsedPropagate__93215(_N_closureOf_BuildExprUsed_93177 _N_BuildExprUsed_closure_93219)
		{
			this._N_BuildExprUsed_closure_93219 = _N_BuildExprUsed_closure_93219;
		}

		[SpecialName]
		public sealed override bool apply(int i, Node n)
		{
			Set<int> set = null;
			DefUseInOut defUseInOut = _N_BuildExprUsed_closure_93219._N_e_ExprUsed_93182[i];
			set = new Set<int>();
			list<int> list = n.next;
			while (list is list<int>.Cons)
			{
				int hd = ((list<int>.Cons)list).hd;
				list = ((list<int>.Cons)list).tl;
				set = set.Sum(_N_BuildExprUsed_closure_93219._N_e_ExprUsed_93182[hd].In);
				list = list;
			}
			defUseInOut.Out = set;
			Set<int> @in = defUseInOut.In;
			defUseInOut.In = defUseInOut.Use.Sum(set.Subtract(defUseInOut.Def));
			return defUseInOut.In.Count == @in.Count;
		}
	}

	public static Array BuildCFG(TExpr expr)
	{
		_N_closureOf_BuildCFG_92914 n_closureOf_BuildCFG_ = new _N_closureOf_BuildCFG_92914();
		n_closureOf_BuildCFG_._N_cfg_92923 = new Array();
		n_closureOf_BuildCFG_._N_gotolist_92921 = list<Tuple<int, int>>.Nil._N_constant_object;
		n_closureOf_BuildCFG_._N_labels_92919 = new Hashtable<int, int>();
		int num = _N_BuildCFG_92926(n_closureOf_BuildCFG_, n_closureOf_BuildCFG_._N_cfg_92923.AddNode(null), expr);
		list<Tuple<int, int>> list = n_closureOf_BuildCFG_._N_gotolist_92921;
		while (list is list<Tuple<int, int>>.Cons)
		{
			Tuple<int, int> hd = ((list<Tuple<int, int>>.Cons)list).hd;
			list = ((list<Tuple<int, int>>.Cons)list).tl;
			num = hd.Field0;
			int field = hd.Field1;
			num = n_closureOf_BuildCFG_._N_cfg_92923.AddEdge(num, n_closureOf_BuildCFG_._N_labels_92919[field]);
			list = list;
		}
		return n_closureOf_BuildCFG_._N_cfg_92923;
	}

	public static GenKillInOut[] BuildExprAvail(Array cfg)
	{
		_N_closureOf_BuildExprAvail_93049 n_closureOf_BuildExprAvail_ = new _N_closureOf_BuildExprAvail_93049();
		n_closureOf_BuildExprAvail_._N_use_93056 = new UseSet();
		Function<int, Node, bool> f = new _N_DefGather__93058(n_closureOf_BuildExprAvail_);
		cfg.Iterate(f);
		n_closureOf_BuildExprAvail_._N_e_ExprAvail_93054 = new GenKillInOut[cfg.Count()];
		f = new _N_ExprAvailInit__93094(n_closureOf_BuildExprAvail_);
		cfg.Iterate(f);
		n_closureOf_BuildExprAvail_._N_e_ExprAvail_93054[0] = new GenKillInOut(new Set<int>(), new Set<int>(), new Set<int>(), new Set<int>());
		f = new _N_ExprAvailPropagate__93124(n_closureOf_BuildExprAvail_);
		cfg.Iterate(f);
		return n_closureOf_BuildExprAvail_._N_e_ExprAvail_93054;
	}

	public static DefUseInOut[] BuildExprUsed(Array cfg)
	{
		_N_closureOf_BuildExprUsed_93177 n_closureOf_BuildExprUsed_ = new _N_closureOf_BuildExprUsed_93177();
		n_closureOf_BuildExprUsed_._N_use_93184 = new UseSet();
		Function<int, Node, bool> f = new _N_UseGather__93186(n_closureOf_BuildExprUsed_);
		cfg.Iterate(f);
		n_closureOf_BuildExprUsed_._N_e_ExprUsed_93182 = new DefUseInOut[cfg.Count()];
		f = new _N_ExprUsedInit__93200(n_closureOf_BuildExprUsed_);
		cfg.Iterate(f);
		f = new _N_ExprUsedPropagate__93215(n_closureOf_BuildExprUsed_);
		cfg.ReverseIterate(f);
		return n_closureOf_BuildExprUsed_._N_e_ExprUsed_93182;
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

	private static int _N_BuildCFG_92926(_N_closureOf_BuildCFG_92914 _N_BuildCFG_cp_92925, int node, TExpr expr)
	{
		_N_closureOf_BuildCFG_92932 n_closureOf_BuildCFG_ = new _N_closureOf_BuildCFG_92932();
		n_closureOf_BuildCFG_._N_node_92939 = node;
		n_closureOf_BuildCFG_._N_NodesAdd_92937 = new _N_NodesAdd__92941(n_closureOf_BuildCFG_, _N_BuildCFG_cp_92925);
		TExpr tExpr = expr.Walk(n_closureOf_BuildCFG_._N_NodesAdd_92937);
		return n_closureOf_BuildCFG_._N_node_92939;
	}

	private static void _N_NodesAddFromList_92954(_N_closureOf_BuildCFG_92932 _N_BuildCFG_cp_92952, _N_closureOf_BuildCFG_92914 _N_BuildCFG_cp_92953, list<TExpr> exprs)
	{
		Function<TExpr, TExpr> convert = new _N__N_lambda__92864__92961(_N_BuildCFG_cp_92952, _N_BuildCFG_cp_92953);
		list<TExpr> list = exprs.Map(convert);
	}
}
