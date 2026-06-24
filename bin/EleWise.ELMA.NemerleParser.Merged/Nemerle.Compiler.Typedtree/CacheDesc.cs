using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Nemerle.Compiler.Parsetree;
using Nemerle.Core;

namespace Nemerle.Compiler.Typedtree;

public class CacheDesc : ISupportRelocation
{
	private sealed class _N_closureOf_Finalize_108933
	{
		internal TFunHeader _N_fun_header_108942;

		internal TExpr _N_body_108940;

		internal CacheDesc _N__N_closurised_this_ptr_108938;

		internal _N_closureOf_Finalize_108933()
		{
		}
	}

	private readonly PExpr p_indices;

	private readonly PExpr p_expr;

	private TExpr t_indices;

	private TExpr t_expr;

	private TExpr ref_is;

	public TypeVar Type => t_expr.Type;

	public PExpr PExpr
	{
		[DebuggerStepThrough]
		[CompilerGenerated]
		get
		{
			return p_expr;
		}
	}

	public TExpr TExpr
	{
		[CompilerGenerated]
		[DebuggerStepThrough]
		get
		{
			return t_expr;
		}
	}

	public TExpr RefIs
	{
		[CompilerGenerated]
		[DebuggerStepThrough]
		get
		{
			return ref_is;
		}
	}

	public void Resolve(Typer par)
	{
		if (t_expr == null)
		{
			if (p_indices != null)
			{
				t_indices = par.TypeExpr(p_indices, par.Solver.FreshTypeVar(), is_toplevel_in_seq: true);
			}
			t_expr = par.TypeExpr(p_expr);
		}
	}

	public TExpr Finalize(TFunHeader fun_header, TExpr body)
	{
		_N_closureOf_Finalize_108933 n_closureOf_Finalize_ = new _N_closureOf_Finalize_108933();
		n_closureOf_Finalize_._N_fun_header_108942 = fun_header;
		n_closureOf_Finalize_._N_body_108940 = body;
		n_closureOf_Finalize_._N__N_closurised_this_ptr_108938 = this;
		if (ref_is != null)
		{
			throw new AssertionException("ncc\\typing\\TypedTree.n", 656, "ref_is == null", "");
		}
		TExpr tExpr;
		if (t_indices != null)
		{
			tExpr = t_indices;
			if (tExpr is TExpr.DefValIn)
			{
				TExpr.DefValIn defValIn = (TExpr.DefValIn)tExpr;
				if (defValIn.body != null)
				{
					throw new AssertionException("ncc\\typing\\TypedTree.n", 668, "d.body == null", "");
				}
				defValIn.body = n_closureOf_Finalize_._N_body_108940;
			}
			else
			{
				if (!(tExpr is TExpr.Match) || !(((TExpr.Match)tExpr).cases is list<Match_case>.Cons) || (object)((list<Match_case>.Cons)((TExpr.Match)tExpr).cases).tl != list<Match_case>.Nil._N_constant_object)
				{
					if (!Message.SeenError)
					{
						string text = "(see backtrace)".ToString();
						Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
					}
					throw new AssertionException("ncc\\typing\\TypedTree.n", 673, "", "(see backtrace)");
				}
				Match_case hd = ((list<Match_case>.Cons)((TExpr.Match)tExpr).cases).hd;
				if (hd.body != null)
				{
					throw new AssertionException("ncc\\typing\\TypedTree.n", 671, "case.body == null", "");
				}
				hd.body = n_closureOf_Finalize_._N_body_108940;
			}
			n_closureOf_Finalize_._N_body_108940 = t_indices;
		}
		tExpr = _N_unfold_108947(t_expr);
		ref_is = _N_get_ref_108991(n_closureOf_Finalize_, tExpr);
		ref_is.Location = t_expr.Location;
		ref_is.ty = t_expr.ty;
		return n_closureOf_Finalize_._N_body_108940;
	}

	public CacheDesc(PExpr e, PExpr i)
	{
		p_expr = e;
		p_indices = i;
	}

	[CompilerGenerated]
	internal override void RelocateImplInternal(RelocationInfo _info)
	{
		if (!_info.VisitedObjects.ContainsKey(this))
		{
			_info.VisitedObjects[this] = 0;
			ref_is?.RelocateImplInternal(_info);
			t_expr?.RelocateImplInternal(_info);
			t_indices?.RelocateImplInternal(_info);
			p_expr?.RelocateImplInternal(_info);
			p_indices?.RelocateImplInternal(_info);
		}
	}

	void ISupportRelocation.RelocateImpl(RelocationInfo _info)
	{
		//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
		this.RelocateImplInternal(_info);
	}

	private static TExpr _N_unfold_108947(TExpr e)
	{
		while (e is TExpr.Delayed)
		{
			if (((TExpr.Delayed)e).susp.DtKind is Typer.DelayedTyping.Kind.Resolved)
			{
				TExpr expr = ((Typer.DelayedTyping.Kind.Resolved)((TExpr.Delayed)e).susp.DtKind).expr;
				e = expr;
				continue;
			}
			if (!Message.SeenError)
			{
				string text = "(see backtrace)".ToString();
				Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
			}
			throw new AssertionException("ncc\\typing\\TypedTree.n", 661, "", "(see backtrace)");
		}
		return e;
	}

	private TExpr _N_cache_obj_108979(_N_closureOf_Finalize_108933 _N_Finalize_cp_108978, TExpr obj)
	{
		TExpr tExpr = _N_unfold_108947(obj);
		object result;
		if (tExpr is TExpr.LocalRef || tExpr is TExpr.This)
		{
			result = obj;
		}
		else
		{
			tExpr = tExpr;
			LocalValue localValue = new LocalValue(_N_Finalize_cp_108978._N_fun_header_108942, Util.tmpname("cached_obj"), tExpr.Type, LocalValue.Kind.Plain._N_constant_object, is_mutable: false);
			localValue.IsCache = true;
			_N_Finalize_cp_108978._N_body_108940 = new TExpr.DefValIn(_N_Finalize_cp_108978._N_body_108940.Location, _N_Finalize_cp_108978._N_body_108940.Type, localValue, tExpr, _N_Finalize_cp_108978._N_body_108940);
			result = new TExpr.LocalRef(tExpr.Location, tExpr.Type, localValue);
		}
		return (TExpr)result;
	}

	private TExpr _N_get_ref_108991(_N_closureOf_Finalize_108933 _N_Finalize_cp_108990, TExpr expr)
	{
		if (expr is TExpr.StaticRef || expr is TExpr.LocalRef)
		{
			goto IL_025c;
		}
		object result;
		if (expr is TExpr.FieldMember)
		{
			TExpr obj = ((TExpr.FieldMember)expr).obj;
			IField fld = ((TExpr.FieldMember)expr).fld;
			result = new TExpr.FieldMember(_N_cache_obj_108979(_N_Finalize_cp_108990, obj), fld);
		}
		else if (expr is TExpr.Call)
		{
			TExpr obj = ((TExpr.Call)expr).func;
			list<Parm> parms = ((TExpr.Call)expr).parms;
			bool is_tail = ((TExpr.Call)expr).is_tail;
			obj = _N_unfold_108947(obj);
			if (!(obj is TExpr.PropertyMember))
			{
				if (!Message.SeenError)
				{
					string text = "(see backtrace)".ToString();
					Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
				}
				throw new AssertionException("ncc\\typing\\TypedTree.n", 715, "", "(see backtrace)");
			}
			TExpr.PropertyMember propertyMember = (TExpr.PropertyMember)obj;
			TExpr obj2 = ((TExpr.PropertyMember)obj).obj;
			IProperty prop = ((TExpr.PropertyMember)obj).prop;
			propertyMember = new TExpr.PropertyMember(propertyMember.Location, propertyMember.Type, _N_cache_obj_108979(_N_Finalize_cp_108990, obj2), prop);
			result = new TExpr.Call(propertyMember, parms, is_tail);
		}
		else
		{
			if (expr is TExpr.This)
			{
				goto IL_025c;
			}
			if (expr is TExpr.ArrayIndexer)
			{
				TExpr obj = ((TExpr.ArrayIndexer)expr).obj;
				list<TExpr> args = ((TExpr.ArrayIndexer)expr).args;
				result = new TExpr.ArrayIndexer(_N_cache_obj_108979(_N_Finalize_cp_108990, obj), args);
			}
			else if (expr is TExpr.PointerIndexer)
			{
				TExpr obj = ((TExpr.PointerIndexer)expr).obj;
				TExpr obj2 = ((TExpr.PointerIndexer)expr).index;
				result = new TExpr.PointerIndexer(_N_cache_obj_108979(_N_Finalize_cp_108990, obj), obj2);
			}
			else if (expr is TExpr.PropertyMember)
			{
				TExpr obj = ((TExpr.PropertyMember)expr).obj;
				IProperty prop = ((TExpr.PropertyMember)expr).prop;
				result = new TExpr.PropertyMember(_N_cache_obj_108979(_N_Finalize_cp_108990, obj), prop);
			}
			else
			{
				if (expr is TExpr.StaticPropertyRef)
				{
					goto IL_025c;
				}
				if (expr is TExpr.EventMember)
				{
					TExpr obj = ((TExpr.EventMember)expr).obj;
					IEvent ev = ((TExpr.EventMember)expr).ev;
					result = new TExpr.EventMember(_N_cache_obj_108979(_N_Finalize_cp_108990, obj), ev);
				}
				else
				{
					if (expr is TExpr.StaticEventRef)
					{
						goto IL_025c;
					}
					if (!(expr is TExpr.DebugInfo))
					{
						if (!Message.SeenError)
						{
							string text = ("invalid cached expr: " + Convert.ToString(expr)).ToString();
							Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
						}
						throw new AssertionException("ncc\\typing\\TypedTree.n", 723, "", ("invalid cached expr: " + Convert.ToString(expr)).ToString());
					}
					TExpr obj = ((TExpr.DebugInfo)expr).expr;
					PExpr pexpr = ((TExpr.DebugInfo)expr).pexpr;
					obj = _N_get_ref_108991(_N_Finalize_cp_108990, _N_unfold_108947(obj));
					obj.ty = t_expr.ty;
					result = new TExpr.DebugInfo(expr.Location, obj, pexpr);
				}
			}
		}
		goto IL_032e;
		IL_032e:
		return (TExpr)result;
		IL_025c:
		result = expr;
		goto IL_032e;
	}
}
