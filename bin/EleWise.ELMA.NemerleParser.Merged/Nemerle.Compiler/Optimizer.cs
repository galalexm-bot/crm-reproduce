using System;
using System.Runtime.CompilerServices;
using CFG;
using Nemerle.Builtins;
using Nemerle.Compiler.Typedtree;
using Nemerle.Core;

namespace Nemerle.Compiler;

public class Optimizer : ISupportRelocation
{
	private sealed class _N_closureOf_StrippedOptimization_93664
	{
		internal bool _N_compile_93669;

		internal _N_closureOf_StrippedOptimization_93664()
		{
		}
	}

	private sealed class _N_CheckFun__93671 : Function<TExpr, TExpr>
	{
		[SpecialName]
		private _N_closureOf_StrippedOptimization_93664 _N_StrippedOptimization_closure_93675;

		public _N_CheckFun__93671(_N_closureOf_StrippedOptimization_93664 _N_StrippedOptimization_closure_93675)
		{
			this._N_StrippedOptimization_closure_93675 = _N_StrippedOptimization_closure_93675;
		}

		[SpecialName]
		public sealed override TExpr apply(TExpr e)
		{
			object result;
			if (e is TExpr.Call)
			{
				list<Parm> list = ((TExpr.Call)e).parms;
				list = list;
				while (list is list<Parm>.Cons)
				{
					Parm hd = ((list<Parm>.Cons)list).hd;
					list = ((list<Parm>.Cons)list).tl;
					hd = hd;
					if (hd.kind == ParmKind.Ref || hd.kind == ParmKind.Out)
					{
						_N_StrippedOptimization_closure_93675._N_compile_93669 = false;
					}
					list = list;
				}
				result = null;
			}
			else if (e is TExpr.TryFinally || e is TExpr.Try)
			{
				_N_StrippedOptimization_closure_93675._N_compile_93669 = false;
				result = null;
			}
			else
			{
				result = null;
			}
			return (TExpr)result;
		}
	}

	private TExpr e;

	private readonly MethodBuilder the_method;

	private static int OptCounter;

	public static bool ignoreOptRange;

	public static int opt;

	static Optimizer()
	{
		OptCounter = 0;
		ignoreOptRange = false;
		opt = -1;
	}

	public Optimizer(MethodBuilder the_method_0027)
	{
		the_method = the_method_0027;
		FunBody body = the_method.Header.body;
		if (body is FunBody.Typed)
		{
			TExpr expr = ((FunBody.Typed)body).expr;
			TExpr tExpr = (e = expr);
			return;
		}
		throw new AssertionException("ncc\\optimization\\Optimizer.n", 55, "", "");
	}

	public static bool StrippedOptimization(TExpr e, list<TParameter> parms)
	{
		_N_closureOf_StrippedOptimization_93664 n_closureOf_StrippedOptimization_ = new _N_closureOf_StrippedOptimization_93664();
		n_closureOf_StrippedOptimization_._N_compile_93669 = true;
		Function<TExpr, TExpr> f = new _N_CheckFun__93671(n_closureOf_StrippedOptimization_);
		TExpr tExpr = e.Walk(f);
		list<TParameter> list = parms;
		while (list is list<TParameter>.Cons)
		{
			TParameter hd = ((list<TParameter>.Cons)list).hd;
			list = ((list<TParameter>.Cons)list).tl;
			hd = hd;
			if (hd.kind == ParmKind.Out || hd.kind == ParmKind.Ref)
			{
				n_closureOf_StrippedOptimization_._N_compile_93669 = false;
			}
			list = list;
		}
		return n_closureOf_StrippedOptimization_._N_compile_93669;
	}

	public void Run()
	{
		bool flag = false;
		checked
		{
			OptCounter++;
			if (!StrippedOptimization(e, the_method.Header.Parameters))
			{
				return;
			}
			e = Preparer.Strip(e);
			if (ManagerClass.Instance.Options.Optimize["tuple"] == 1)
			{
				e = Preparer.TupleDismounter(e);
			}
			e = Preparer.RemoveDefs(e);
			if (ManagerClass.Instance.Options.Optimize["propagate"] == 1)
			{
				flag = true;
				while (flag)
				{
					e = Decorator.Decorate(e);
					global::CFG.Array cfg = CFG.BuildCFG(e);
					flag = Propagator.Propagate(cfg, CFG.BuildExprAvail(cfg), CFG.BuildExprUsed(cfg));
					e = Decorator.Undecorate(e);
				}
			}
			if (ManagerClass.Instance.Options.Optimize["unify"] == 1)
			{
				e = Decorator.Decorate(e);
				global::CFG.Array cfg = CFG.BuildCFG(e);
				e = Unification.Apply(e, Unification.Calculate(cfg, CFG.BuildExprUsed(cfg), the_method.Header.Parameters));
				e = Decorator.Undecorate(e);
			}
			e = Preparer.AddDefs(e, the_method.Header.Parameters);
			if (ManagerClass.Instance.Options.Optimize["print"] == 1)
			{
				Console.Write(Environment.NewLine + Convert.ToString(e) + Environment.NewLine);
			}
			the_method.Header.body = new FunBody.Typed(e);
		}
	}

	[CompilerGenerated]
	internal override void RelocateImplInternal(RelocationInfo _info)
	{
		if (!_info.VisitedObjects.ContainsKey(this))
		{
			_info.VisitedObjects[this] = 0;
			the_method?.RelocateImplInternal(_info);
			e?.RelocateImplInternal(_info);
		}
	}

	void ISupportRelocation.RelocateImpl(RelocationInfo _info)
	{
		//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
		this.RelocateImplInternal(_info);
	}
}
