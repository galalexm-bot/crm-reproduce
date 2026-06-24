using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Collections;
using Nemerle.Compiler;
using Nemerle.Compiler.Typedtree;
using Nemerle.Core;

public class UseSet : Hashtable<TExpr, Set<int>>, ISupportRelocation
{
	private sealed class _N_closureOf_Insert_94697
	{
		internal int _N_i_94704;

		internal UseSet _N__N_closurised_this_ptr_94702;

		internal _N_closureOf_Insert_94697()
		{
		}
	}

	private sealed class _N_addd__94706 : Function<TExpr, TExpr>
	{
		[SpecialName]
		private _N_closureOf_Insert_94697 _N_Insert_closure_94710;

		public _N_addd__94706(_N_closureOf_Insert_94697 _N_Insert_closure_94710)
		{
			this._N_Insert_closure_94710 = _N_Insert_closure_94710;
		}

		[SpecialName]
		public sealed override TExpr apply(TExpr expr)
		{
			object result;
			if (expr is TExpr.LocalRef)
			{
				if (_N_Insert_closure_94710._N__N_closurised_this_ptr_94702.Contains(expr))
				{
					if (!_N_Insert_closure_94710._N__N_closurised_this_ptr_94702[expr].Contains(_N_Insert_closure_94710._N_i_94704))
					{
						_N_Insert_closure_94710._N__N_closurised_this_ptr_94702[expr] = _N_Insert_closure_94710._N__N_closurised_this_ptr_94702[expr].Add(_N_Insert_closure_94710._N_i_94704);
					}
				}
				else
				{
					_N_Insert_closure_94710._N__N_closurised_this_ptr_94702[expr] = new Set<int>().Add(_N_Insert_closure_94710._N_i_94704);
				}
				result = expr;
			}
			else
			{
				if (expr is TExpr.Use)
				{
					throw new AssertionException("ncc\\optimization\\UseSet.n", 72, "", "");
				}
				result = null;
			}
			return (TExpr)result;
		}
	}

	private Set<int> used;

	public UseSet()
		: base((IEqualityComparer<TExpr>)new UseSetComparer())
	{
		used = null;
	}

	public void Insert(TExpr e, int i)
	{
		_N_closureOf_Insert_94697 n_closureOf_Insert_ = new _N_closureOf_Insert_94697();
		n_closureOf_Insert_._N_i_94704 = i;
		n_closureOf_Insert_._N__N_closurised_this_ptr_94702 = this;
		Function<TExpr, TExpr> f = new _N_addd__94706(n_closureOf_Insert_);
		TExpr tExpr = e.Walk(f);
	}

	public new Set<int> Get(TExpr e)
	{
		if (e is TExpr.LocalRef)
		{
			Set<int> result;
			if (Contains(e))
			{
				result = this[e];
			}
			else
			{
				Set<int> set2 = (this[e] = new Set<int>());
				result = set2;
			}
			return result;
		}
		throw new AssertionException("ncc\\optimization\\UseSet.n", 88, "", "");
	}

	public Set<int> GetAllUsed()
	{
		int num = 0;
		if (used == null)
		{
			used = new Set<int>();
			Tuple<TExpr, Set<int>>[] keyValuePairs = KeyValuePairs;
			for (num = 0; num < keyValuePairs.Length; num = checked(num + 1))
			{
				Tuple<TExpr, Set<int>> tuple = keyValuePairs[num];
				Set<int> field = tuple.Field1;
				used = used.Sum(new Set<int>(field));
			}
		}
		return used;
	}

	public override string ToString()
	{
		int num = 0;
		string text = null;
		text = "{ ";
		Tuple<TExpr, Set<int>>[] keyValuePairs = KeyValuePairs;
		for (num = 0; num < keyValuePairs.Length; num = checked(num + 1))
		{
			Tuple<TExpr, Set<int>> tuple = keyValuePairs[num];
			TExpr field = tuple.Field0;
			Set<int> field2 = tuple.Field1;
			text = string.Concat(string.Concat(string.Concat(text + field.ToString(), ":"), field2.ToString()), " ");
		}
		return text + "}";
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
