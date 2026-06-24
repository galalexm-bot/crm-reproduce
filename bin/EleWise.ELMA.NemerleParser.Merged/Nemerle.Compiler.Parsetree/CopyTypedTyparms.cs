using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Core;

namespace Nemerle.Compiler.Parsetree;

public class CopyTypedTyparms : SubstitutingTyparms
{
	private readonly list<StaticTypeVar> fresh_vars;

	public override bool IsCopyOfExisting => true;

	public override list<StaticTypeVar> ExistingTyvars => fresh_vars;

	public CopyTypedTyparms(list<StaticTypeVar> template_tyvars)
		: this(template_tyvars, null)
	{
	}

	public CopyTypedTyparms(list<StaticTypeVar> template_tyvars, Subst subst)
	{
		Tuple<Subst, list<StaticTypeVar>> tuple = StaticTypeVar.CopyList(template_tyvars);
		Subst field = tuple.Field0;
		list<StaticTypeVar> list = tuple.Field1;
		if (subst != null)
		{
			field.AddSubst(subst);
		}
		base._002Ector(field);
		fresh_vars = list;
	}

	[CompilerGenerated]
	internal override void RelocateImplInternal(RelocationInfo _info)
	{
		if (_info.VisitedObjects.ContainsKey(this))
		{
			return;
		}
		base.RelocateImplInternal(_info);
		_info.VisitedObjects[this] = 0;
		list<StaticTypeVar> list = fresh_vars;
		if (list != null)
		{
			list = list;
			while (list is list<StaticTypeVar>.Cons)
			{
				StaticTypeVar hd = ((list<StaticTypeVar>.Cons)list).hd;
				list = ((list<StaticTypeVar>.Cons)list).tl;
				((ISupportRelocation)hd).RelocateImpl(_info);
				list = list;
			}
		}
	}
}
