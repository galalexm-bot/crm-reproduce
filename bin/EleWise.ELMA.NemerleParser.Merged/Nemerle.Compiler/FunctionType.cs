using System;
using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Core;

namespace Nemerle.Compiler;

public class FunctionType : ISupportRelocation
{
	internal readonly TypeInfo tycon;

	internal readonly TypeInfo void_tycon;

	internal readonly IMethod apply;

	internal readonly IMethod apply_void;

	internal readonly IMethod apply_tupled;

	internal readonly IMethod apply_tupled_void;

	public readonly TypeInfo FromTupleTyCon;

	public readonly TypeInfo FromTupleVoidTyCon;

	public readonly IMethod FromTupleCtor;

	public readonly IMethod FromTupleVoidCtor;

	private static readonly list<string> function_name;

	private static readonly list<string> function_void_name;

	private static readonly list<string> function_from_tuple_name;

	private static readonly list<string> function_void_from_tuple_name;

	public IMethod ApplyMethod => apply;

	public IMethod ApplyVoidMethod => apply_void;

	public TypeInfo TyCon => tycon;

	public TypeInfo VoidTyCon => void_tycon;

	static FunctionType()
	{
		function_name = new list<string>.Cons("Nemerle", new list<string>.Cons("Builtins", new list<string>.Cons("Function", list<string>.Nil._N_constant_object)));
		function_void_name = new list<string>.Cons("Nemerle", new list<string>.Cons("Builtins", new list<string>.Cons("FunctionVoid", list<string>.Nil._N_constant_object)));
		function_from_tuple_name = new list<string>.Cons("Nemerle", new list<string>.Cons("Builtins", new list<string>.Cons("FunctionFromTuple", list<string>.Nil._N_constant_object)));
		function_void_from_tuple_name = new list<string>.Cons("Nemerle", new list<string>.Cons("Builtins", new list<string>.Cons("FunctionVoidFromTuple", list<string>.Nil._N_constant_object)));
	}

	public IMethod GetMethodWithReturnType(TypeVar ret_type)
	{
		FixedType fixedType = ret_type.Fix();
		return (!(fixedType is FixedType.Void)) ? apply : apply_void;
	}

	public IMethod GetTupledMethodWithReturnType(TypeVar ret_type)
	{
		FixedType fixedType = ret_type.Fix();
		return (!(fixedType is FixedType.Void)) ? apply_tupled : apply_tupled_void;
	}

	public static FixedType.Class Make(TypeVar ty)
	{
		option<Nemerle.Builtins.Tuple<list<TypeVar>, TypeVar>> option = ty.Fix().FunReturnTypeAndParms();
		if (option is option<Nemerle.Builtins.Tuple<list<TypeVar>, TypeVar>>.Some)
		{
			list<TypeVar> list = ((option<Nemerle.Builtins.Tuple<list<TypeVar>, TypeVar>>.Some)option).val.Field0;
			TypeVar field = ((option<Nemerle.Builtins.Tuple<list<TypeVar>, TypeVar>>.Some)option).val.Field1;
			FunctionType functionType = ty.Manager.InternalType.GetFunctionType(list.Length);
			FixedType fixedType = field.Fix();
			return (!(fixedType is FixedType.Void)) ? new FixedType.Class(functionType.TyCon, list + new list<TypeVar>.Cons(field, list<TypeVar>.Nil._N_constant_object)) : new FixedType.Class(functionType.VoidTyCon, list);
		}
		if (option == option<Nemerle.Builtins.Tuple<list<TypeVar>, TypeVar>>.None._N_constant_object)
		{
			if (!Message.SeenError)
			{
				string text = "(see backtrace)".ToString();
				Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
			}
			throw new AssertionException("ncc\\external\\InternalTypes.n", 359, "", "(see backtrace)");
		}
		throw new MatchFailureException();
	}

	internal FunctionType(ManagerClass m, int size)
	{
		checked
		{
			tycon = m.NameTree.LookupInternalType(function_name, size + 1);
			list<IMember> list = tycon.LookupMember("apply");
			while (list is list<IMember>.Cons)
			{
				IMember hd = ((list<IMember>.Cons)list).hd;
				list = ((list<IMember>.Cons)list).tl;
				IMethod method = (IMethod)hd;
				if (method.GetParameters().Length == size)
				{
					if (apply != null)
					{
						throw new AssertionException("ncc\\external\\InternalTypes.n", 375, "apply == null", "");
					}
					apply = method;
				}
				else
				{
					if (apply_tupled != null)
					{
						throw new AssertionException("ncc\\external\\InternalTypes.n", 380, "apply_tupled == null", "");
					}
					apply_tupled = method;
				}
				list = list;
			}
			if (apply == null)
			{
				throw new AssertionException("ncc\\external\\InternalTypes.n", 384, "apply != null", "");
			}
			if (size > 1 && apply_tupled == null)
			{
				throw new AssertionException("ncc\\external\\InternalTypes.n", 385, "size <= 1 || apply_tupled != null", "");
			}
			void_tycon = m.NameTree.LookupInternalType(function_void_name, size);
			apply_void = (IMethod)void_tycon.LookupMember("apply_void").Head;
			apply_tupled_void = ((size <= 1) ? null : ((IMethod)void_tycon.LookupMember("apply_void").Tail.Head));
			if (size > 1)
			{
				FromTupleTyCon = m.NameTree.LookupInternalType(function_from_tuple_name, size + 1);
				FromTupleVoidTyCon = m.NameTree.LookupInternalType(function_void_from_tuple_name, size);
				FromTupleCtor = (IMethod)FromTupleTyCon.LookupMember(".ctor").Head;
				FromTupleVoidCtor = (IMethod)FromTupleVoidTyCon.LookupMember(".ctor").Head;
			}
		}
	}

	[CompilerGenerated]
	internal override void RelocateImplInternal(RelocationInfo _info)
	{
		if (!_info.VisitedObjects.ContainsKey(this))
		{
			_info.VisitedObjects[this] = 0;
			IMethod fromTupleVoidCtor = FromTupleVoidCtor;
			if (fromTupleVoidCtor != null)
			{
				((ISupportRelocation)fromTupleVoidCtor).RelocateImpl(_info);
			}
			fromTupleVoidCtor = FromTupleCtor;
			if (fromTupleVoidCtor != null)
			{
				((ISupportRelocation)fromTupleVoidCtor).RelocateImpl(_info);
			}
			fromTupleVoidCtor = apply_tupled_void;
			if (fromTupleVoidCtor != null)
			{
				((ISupportRelocation)fromTupleVoidCtor).RelocateImpl(_info);
			}
			fromTupleVoidCtor = apply_tupled;
			if (fromTupleVoidCtor != null)
			{
				((ISupportRelocation)fromTupleVoidCtor).RelocateImpl(_info);
			}
			fromTupleVoidCtor = apply_void;
			if (fromTupleVoidCtor != null)
			{
				((ISupportRelocation)fromTupleVoidCtor).RelocateImpl(_info);
			}
			fromTupleVoidCtor = apply;
			if (fromTupleVoidCtor != null)
			{
				((ISupportRelocation)fromTupleVoidCtor).RelocateImpl(_info);
			}
		}
	}

	void ISupportRelocation.RelocateImpl(RelocationInfo _info)
	{
		//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
		this.RelocateImplInternal(_info);
	}
}
