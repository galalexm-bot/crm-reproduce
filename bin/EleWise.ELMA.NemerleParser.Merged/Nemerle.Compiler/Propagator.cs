using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CFG;
using Nemerle.Builtins;
using Nemerle.Collections;
using Nemerle.Compiler.Typedtree;

namespace Nemerle.Compiler;

internal class Propagator : ISupportRelocation
{
	private sealed class _N_closureOf_Worthy_94099
	{
		internal int _N_v_94106;

		internal Function<TExpr, TExpr> _N_ExprSize_94104;

		internal _N_closureOf_Worthy_94099()
		{
		}
	}

	private sealed class _N_ExprSize__94111 : Function<TExpr, TExpr>
	{
		[SpecialName]
		private _N_closureOf_Worthy_94099 _N_Worthy_closure_94115;

		public _N_ExprSize__94111(_N_closureOf_Worthy_94099 _N_Worthy_closure_94115)
		{
			this._N_Worthy_closure_94115 = _N_Worthy_closure_94115;
		}

		[SpecialName]
		public sealed override TExpr apply(TExpr e)
		{
			object result;
			if (e is TExpr.Use)
			{
				TExpr expr = ((TExpr.Use)e).expr;
				result = expr.Walk(_N_Worthy_closure_94115._N_ExprSize_94104);
			}
			else
			{
				_N_Worthy_closure_94115._N_v_94106 = checked(_N_Worthy_closure_94115._N_v_94106 + 1);
				result = null;
			}
			return (TExpr)result;
		}
	}

	private sealed class _N_closureOf_Propagate_94148
	{
		internal global::CFG.Array _N_cfg_94159;

		internal CFG.GenKillInOut[] _N_e_ExprAvail_94157;

		internal CFG.DefUseInOut[] _N_e_ExprUsed_94155;

		internal bool _N_propagated_94153;

		internal _N_closureOf_Propagate_94148()
		{
		}
	}

	private sealed class _N_Propagator__94161 : Function<int, Node, bool>
	{
		[SpecialName]
		private _N_closureOf_Propagate_94148 _N_Propagate_closure_94165;

		public _N_Propagator__94161(_N_closureOf_Propagate_94148 _N_Propagate_closure_94165)
		{
			this._N_Propagate_closure_94165 = _N_Propagate_closure_94165;
		}

		[SpecialName]
		public sealed override bool apply(int k, Node v)
		{
			_N_closureOf_Propagator_94170 n_closureOf_Propagator_ = new _N_closureOf_Propagator_94170();
			n_closureOf_Propagator_._N_k_94177 = k;
			TExpr expr = v.expr;
			if (expr is TExpr.Def)
			{
				TExpr.Def def = (TExpr.Def)expr;
				n_closureOf_Propagator_._N_into_94175 = ((TExpr.Def)expr).into;
				if (n_closureOf_Propagator_._N_into_94175 != null)
				{
					Set<int> set = _N_Propagate_closure_94165._N_e_ExprUsed_94155[n_closureOf_Propagator_._N_k_94177].Out.Intersect(_N_Propagate_closure_94165._N_e_ExprUsed_94155[n_closureOf_Propagator_._N_k_94177].Def);
					Function<int, bool> fn = new _N_CanPropagate__94184(n_closureOf_Propagator_, _N_Propagate_closure_94165);
					if (set.ForAll(fn) && Worthy(set.Count, n_closureOf_Propagator_._N_into_94175))
					{
						_N_Propagate_closure_94165._N_propagated_94153 = true;
						IEnumerator<int> enumerator = set.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								int current = enumerator.Current;
								int i = current;
								TExpr.Use use = _N_Propagate_closure_94165._N_cfg_94159.GetUse(i);
								use.expr = n_closureOf_Propagator_._N_into_94175;
								if (use.def_of != null)
								{
									use.def_of.into = null;
								}
							}
						}
						finally
						{
							((IDisposable)enumerator).Dispose();
						}
						def.expr = null;
					}
				}
			}
			return true;
		}
	}

	private sealed class _N_closureOf_Propagator_94170
	{
		internal int _N_k_94177;

		internal TExpr _N_into_94175;

		internal _N_closureOf_Propagator_94170()
		{
		}
	}

	private sealed class _N_CanPropagate__94184 : Function<int, bool>
	{
		[SpecialName]
		private _N_closureOf_Propagate_94148 _N_Propagate_closure_94190;

		[SpecialName]
		private _N_closureOf_Propagator_94170 _N_Propagator_closure_94188;

		public _N_CanPropagate__94184(_N_closureOf_Propagator_94170 _N_Propagator_closure_94188, _N_closureOf_Propagate_94148 _N_Propagate_closure_94190)
		{
			this._N_Propagator_closure_94188 = _N_Propagator_closure_94188;
			this._N_Propagate_closure_94190 = _N_Propagate_closure_94190;
		}

		[SpecialName]
		public sealed override bool apply(int t)
		{
			return _N_Propagate_closure_94190._N_e_ExprAvail_94157[t].In.Contains(_N_Propagator_closure_94188._N_k_94177) && _N_Propagator_closure_94188._N_into_94175.ty.Equals(_N_Propagate_closure_94190._N_cfg_94159.GetUse(t).ty);
		}
	}

	public static bool Worthy(int count, TExpr expr)
	{
		_N_closureOf_Worthy_94099 n_closureOf_Worthy_ = new _N_closureOf_Worthy_94099();
		int result;
		if (count <= 1)
		{
			result = 1;
		}
		else
		{
			n_closureOf_Worthy_._N_v_94106 = 0;
			n_closureOf_Worthy_._N_ExprSize_94104 = new _N_ExprSize__94111(n_closureOf_Worthy_);
			TExpr tExpr = expr.Walk(n_closureOf_Worthy_._N_ExprSize_94104);
			result = ((n_closureOf_Worthy_._N_v_94106 < 2) ? 1 : 0);
		}
		return (byte)result != 0;
	}

	public static bool Propagate(global::CFG.Array cfg, CFG.GenKillInOut[] e_ExprAvail, CFG.DefUseInOut[] e_ExprUsed)
	{
		_N_closureOf_Propagate_94148 n_closureOf_Propagate_ = new _N_closureOf_Propagate_94148();
		n_closureOf_Propagate_._N_cfg_94159 = cfg;
		n_closureOf_Propagate_._N_e_ExprAvail_94157 = e_ExprAvail;
		n_closureOf_Propagate_._N_e_ExprUsed_94155 = e_ExprUsed;
		n_closureOf_Propagate_._N_propagated_94153 = false;
		Function<int, Node, bool> f = new _N_Propagator__94161(n_closureOf_Propagate_);
		n_closureOf_Propagate_._N_cfg_94159.Iterate(f);
		return n_closureOf_Propagate_._N_propagated_94153;
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
