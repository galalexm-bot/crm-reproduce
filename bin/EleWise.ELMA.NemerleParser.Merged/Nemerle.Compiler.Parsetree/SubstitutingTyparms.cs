using System.Runtime.CompilerServices;
using Nemerle.Core;

namespace Nemerle.Compiler.Parsetree;

public class SubstitutingTyparms : Typarms
{
	private readonly Subst subst;

	public SubstitutingTyparms(Subst subst)
		: base(list<Splicable>.Nil._N_constant_object, list<Constraint>.Nil._N_constant_object)
	{
		this.subst = subst;
	}

	public override TypeVar Substitute(FixedType ty)
	{
		return subst.Apply(ty);
	}

	[CompilerGenerated]
	internal override void RelocateImplInternal(RelocationInfo _info)
	{
		if (!_info.VisitedObjects.ContainsKey(this))
		{
			base.RelocateImplInternal(_info);
			_info.VisitedObjects[this] = 0;
			subst?.RelocateImplInternal(_info);
		}
	}
}
