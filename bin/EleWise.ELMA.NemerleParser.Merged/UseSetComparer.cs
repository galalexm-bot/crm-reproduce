using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Nemerle.Compiler;
using Nemerle.Compiler.Typedtree;
using Nemerle.Core;

public class UseSetComparer : IEqualityComparer<TExpr>, ISupportRelocation
{
	public int GetHashCode(TExpr x)
	{
		if (x is TExpr.LocalRef)
		{
			LocalValue decl = ((TExpr.LocalRef)x).decl;
			return decl.GetHashCode();
		}
		throw new AssertionException("ncc\\optimization\\UseSet.n", 43, "", "");
	}

	public static bool equals(TExpr x, TExpr y)
	{
		if (x is TExpr.LocalRef && y is TExpr.LocalRef)
		{
			LocalValue decl = ((TExpr.LocalRef)x).decl;
			LocalValue decl2 = ((TExpr.LocalRef)y).decl;
			return decl.Equals(decl2);
		}
		throw new AssertionException("ncc\\optimization\\UseSet.n", 49, "", "");
	}

	public bool Equals(TExpr x, TExpr y)
	{
		return equals(x, y);
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
