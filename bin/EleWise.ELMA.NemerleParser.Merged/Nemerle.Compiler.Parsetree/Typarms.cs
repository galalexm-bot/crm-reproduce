using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Collections;
using Nemerle.Core;
using Nemerle.Internal;

namespace Nemerle.Compiler.Parsetree;

public class Typarms : ISupportRelocation
{
	private sealed class _N__N_lambda__41739__41749 : Function<Splicable, string>
	{
		[SpecialName]
		public static readonly _N__N_lambda__41739__41749 Instance = new _N__N_lambda__41739__41749();

		[SpecialName]
		public sealed override string apply(Splicable x)
		{
			return Convert.ToString(x);
		}
	}

	public readonly list<Splicable> tyvars;

	public readonly list<Constraint> constraints;

	public static readonly Typarms Empty;

	public override bool IsCopyOfExisting => false;

	public override list<StaticTypeVar> ExistingTyvars => null;

	static Typarms()
	{
		Empty = new Typarms(list<Splicable>.Nil._N_constant_object, list<Constraint>.Nil._N_constant_object);
	}

	public override string ToString()
	{
		object result;
		if (tyvars.IsEmpty)
		{
			result = "";
		}
		else
		{
			IEnumerable<Splicable> source = tyvars;
			Function<Splicable, string> instance = _N__N_lambda__41739__41749.Instance;
			result = "[" + string.Join(", ", source.MapToArray(instance)) + "]";
		}
		return (string)result;
	}

	public override TypeVar Substitute(FixedType ty)
	{
		return ty;
	}

	[RecordCtor]
	public Typarms([MappedMember("tyvars")] list<Splicable> tyvars, [MappedMember("constraints")] list<Constraint> constraints)
	{
		this.tyvars = tyvars;
		this.constraints = constraints;
	}

	[CompilerGenerated]
	internal override void RelocateImplInternal(RelocationInfo _info)
	{
		if (_info.VisitedObjects.ContainsKey(this))
		{
			return;
		}
		_info.VisitedObjects[this] = 0;
		list<Constraint> list = constraints;
		if (list != null)
		{
			list = list;
			while (list is list<Constraint>.Cons)
			{
				Constraint hd = ((list<Constraint>.Cons)list).hd;
				list = ((list<Constraint>.Cons)list).tl;
				((ISupportRelocation)hd).RelocateImpl(_info);
				list = list;
			}
		}
		list<Splicable> list2 = tyvars;
		if (list2 != null)
		{
			list2 = list2;
			while (list2 is list<Splicable>.Cons)
			{
				Splicable hd2 = ((list<Splicable>.Cons)list2).hd;
				list2 = ((list<Splicable>.Cons)list2).tl;
				((ISupportRelocation)hd2).RelocateImpl(_info);
				list2 = list2;
			}
		}
	}

	void ISupportRelocation.RelocateImpl(RelocationInfo _info)
	{
		//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
		this.RelocateImplInternal(_info);
	}
}
