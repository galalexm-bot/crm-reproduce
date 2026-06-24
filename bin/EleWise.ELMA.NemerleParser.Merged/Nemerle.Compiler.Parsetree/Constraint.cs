using System.Runtime.CompilerServices;

namespace Nemerle.Compiler.Parsetree;

public class Constraint : ISupportRelocation
{
	public readonly Splicable tyvar;

	public readonly PExpr ty;

	public bool IsSpecial { get; }

	public Splicable TypeParameterName => tyvar;

	public PExpr Expression => ty;

	public Constraint(Splicable tyvar, PExpr ty, bool isSpecial = true)
	{
		this.tyvar = tyvar;
		this.ty = ty;
		_N_IsSpecial_7764 = isSpecial;
	}

	[CompilerGenerated]
	internal override void RelocateImplInternal(RelocationInfo _info)
	{
		if (!_info.VisitedObjects.ContainsKey(this))
		{
			_info.VisitedObjects[this] = 0;
			ty?.RelocateImplInternal(_info);
			tyvar?.RelocateImplInternal(_info);
		}
	}

	void ISupportRelocation.RelocateImpl(RelocationInfo _info)
	{
		//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
		this.RelocateImplInternal(_info);
	}
}
