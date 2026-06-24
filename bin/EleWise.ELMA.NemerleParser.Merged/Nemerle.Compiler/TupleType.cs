using System;
using System.Runtime.CompilerServices;
using Nemerle.Core;

namespace Nemerle.Compiler;

public class TupleType : ISupportRelocation
{
	internal readonly TypeInfo tycon;

	internal readonly IField[] fields;

	internal readonly IMethod ctor;

	private static readonly list<string> name;

	public IMethod Ctor => ctor;

	public TypeInfo TyCon => tycon;

	static TupleType()
	{
		name = new list<string>.Cons("Nemerle", new list<string>.Cons("Builtins", new list<string>.Cons("Tuple", list<string>.Nil._N_constant_object)));
	}

	public IField GetField(int pos)
	{
		return fields[pos];
	}

	public static FixedType.Class Make(TypeVar ty)
	{
		FixedType fixedType = ty.Fix();
		if (fixedType is FixedType.Tuple)
		{
			list<TypeVar> list = ((FixedType.Tuple)fixedType).args;
			TupleType tupleType = ty.Manager.InternalType.GetTupleType(list.Length);
			return new FixedType.Class(tupleType.tycon, list);
		}
		if (!Message.SeenError)
		{
			string text = "(see backtrace)".ToString();
			Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
		}
		throw new AssertionException("ncc\\external\\InternalTypes.n", 270, "", "(see backtrace)");
	}

	private IField get_field(int pos)
	{
		list<IMember> list = tycon.LookupMember("Field" + checked(pos - 1));
		if (list is list<IMember>.Cons && (object)((list<IMember>.Cons)list).tl == list<IMember>.Nil._N_constant_object)
		{
			IMember hd = ((list<IMember>.Cons)list).hd;
			return (IField)hd;
		}
		throw new AssertionException("ncc\\external\\InternalTypes.n", 278, "", "");
	}

	public static bool IsTupleMember(IMember ty)
	{
		TypeInfo declaringType = ty.DeclaringType;
		int typarmsCount = declaringType.TyparmsCount;
		return typarmsCount > 1 && declaringType.Equals(declaringType.Manager.InternalType.GetTupleType(typarmsCount).tycon);
	}

	internal TupleType(ManagerClass m, int size)
	{
		int num = 0;
		base._002Ector();
		tycon = m.NameTree.LookupInternalType(name, size);
		checked
		{
			fields = new IField[size + 1];
			for (num = 1; num <= size; num++)
			{
				fields[num] = get_field(num);
			}
			ctor = (IMethod)tycon.LookupMember(".ctor").Head;
		}
	}

	[CompilerGenerated]
	internal override void RelocateImplInternal(RelocationInfo _info)
	{
		if (!_info.VisitedObjects.ContainsKey(this))
		{
			_info.VisitedObjects[this] = 0;
			IMethod method = ctor;
			if (method != null)
			{
				((ISupportRelocation)method).RelocateImpl(_info);
			}
		}
	}

	void ISupportRelocation.RelocateImpl(RelocationInfo _info)
	{
		//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
		this.RelocateImplInternal(_info);
	}
}
