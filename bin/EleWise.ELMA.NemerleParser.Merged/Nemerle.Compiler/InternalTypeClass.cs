using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Compiler.Typedtree;
using Nemerle.Core;

namespace Nemerle.Compiler;

public class InternalTypeClass : ISupportRelocation
{
	private sealed class _N_closureOf_InitSystemTypes_53529
	{
		internal InternalTypeClass _N__N_closurised_this_ptr_53536;

		internal Function<IMember, bool> _N_is_right_53534;

		internal _N_closureOf_InitSystemTypes_53529()
		{
		}
	}

	private sealed class _N_is_right__53538 : Function<IMember, bool>
	{
		[SpecialName]
		private _N_closureOf_InitSystemTypes_53529 _N_InitSystemTypes_closure_53542;

		public _N_is_right__53538(_N_closureOf_InitSystemTypes_53529 _N_InitSystemTypes_closure_53542)
		{
			this._N_InitSystemTypes_closure_53542 = _N_InitSystemTypes_closure_53542;
		}

		[SpecialName]
		public sealed override bool apply(IMember mem)
		{
			int result;
			if (mem is IMethod)
			{
				IMethod method = (IMethod)mem;
				list<TParameter> parameters = method.GetParameters();
				result = ((method.IsStatic && parameters.Length == 2 && !parameters.Head.ty.Equals(_N_InitSystemTypes_closure_53542._N__N_closurised_this_ptr_53536.Object)) ? 1 : 0);
			}
			else
			{
				result = 0;
			}
			return (byte)result != 0;
		}
	}

	public TypeInfo Void_tc;

	public TypeInfo Array_tc;

	public TypeInfo Attribute_tc;

	public TypeInfo Boolean_tc;

	public TypeInfo Byte_tc;

	public TypeInfo Char_tc;

	public TypeInfo Decimal_tc;

	public TypeInfo Delegate_tc;

	public TypeInfo MulticastDelegate_tc;

	public TypeInfo Double_tc;

	public TypeInfo Enum_tc;

	public TypeInfo Exception_tc;

	public TypeInfo Int16_tc;

	public TypeInfo Int32_tc;

	public TypeInfo Int64_tc;

	public TypeInfo IntPtr_tc;

	public TypeInfo Object_tc;

	public TypeInfo SByte_tc;

	public TypeInfo Single_tc;

	public TypeInfo String_tc;

	public TypeInfo Type_tc;

	public TypeInfo MethodInfo_tc;

	public TypeInfo ConstructorInfo_tc;

	public TypeInfo FieldInfo_tc;

	public TypeInfo PropertyInfo_tc;

	public TypeInfo UInt16_tc;

	public TypeInfo UInt32_tc;

	public TypeInfo UInt64_tc;

	public TypeInfo ValueType_tc;

	public TypeInfo MatchFailureException_tc;

	public TypeInfo NullMatchException_tc;

	public TypeInfo ContainsMacroAttribute_tc;

	public TypeInfo VariantAttribute_tc;

	public TypeInfo ImmutableAttribute_tc;

	public TypeInfo ExtensionAttribute_tc;

	public TypeInfo TypeAliasAttribute_tc;

	public TypeInfo VariantOptionAttribute_tc;

	public TypeInfo VolatileModifier_tc;

	public TypeInfo ConstantVariantOptionAttribute_tc;

	public TypeInfo ExtensionPatternEncodingAttribute_tc;

	public TypeInfo FlagsAttribute_tc;

	public TypeInfo ParamArrayAttribute_tc;

	public TypeInfo AssemblyVersionAttribute_tc;

	public TypeInfo AssemblyKeyFileAttribute_tc;

	public TypeInfo AssemblyCompanyAttribute_tc;

	public TypeInfo AssemblyProductAttribute_tc;

	public TypeInfo AssemblyTitleAttribute_tc;

	public TypeInfo AssemblyDescriptionAttribute_tc;

	public TypeInfo AssemblyCopyrightAttribute_tc;

	public TypeInfo AssemblyCultureAttribute_tc;

	public TypeInfo AssemblyFileVersionAttribute_tc;

	public TypeInfo Nemerle_list_tc;

	public TypeInfo Nemerle_option_tc;

	public TypeInfo IList_tc;

	public TypeInfo ICollection_tc;

	public TypeInfo IEnumerable_tc;

	public TypeInfo IEnumerator_tc;

	public TypeInfo Generic_IEnumerable_tc;

	public TypeInfo Generic_IEnumerator_tc;

	public TypeInfo Generic_IList_tc;

	public TypeInfo Generic_ICollection_tc;

	public TypeInfo Generic_Nullable_tc;

	public TypeInfo DllImport_tc;

	public TypeInfo Serializable_tc;

	public TypeInfo Obsolete_tc;

	public TypeInfo Conditional_tc;

	public TypeInfo IgnoreFieldAttribute_tc;

	public TypeInfo IgnoreConstructorAttribute_tc;

	public TypeInfo IdentityFunction_tc;

	private FunctionType[] function_types;

	private TupleType[] tuple_types;

	private TypeInfo[] array_types;

	public FixedType.Void Void;

	public FixedType.Class Array;

	public FixedType.Class Attribute;

	public FixedType.Class Boolean;

	public FixedType.Class Byte;

	public FixedType.Class Char;

	public FixedType.Class Decimal;

	public FixedType.Class Delegate;

	public FixedType.Class Double;

	public FixedType.Class Enum;

	public FixedType.Class Exception;

	public FixedType.Class Int16;

	public FixedType.Class Int32;

	public FixedType.Class Int64;

	public FixedType.Class IntPtr;

	public FixedType.Class Object;

	public FixedType.Class SByte;

	public FixedType.Class Single;

	public FixedType.Class String;

	public FixedType.Class Type;

	public FixedType.Class MethodInfo;

	public FixedType.Class ConstructorInfo;

	public FixedType.Class FieldInfo;

	public FixedType.Class PropertyInfo;

	public FixedType.Class UInt16;

	public FixedType.Class UInt32;

	public FixedType.Class UInt64;

	public FixedType.Class ValueType;

	public FixedType.Class MatchFailureException;

	public FixedType.Class IObjectReference;

	public FixedType.Class Reflection_Missing;

	public IMethod Delegate_Combine;

	public IMethod Delegate_Remove;

	public IMethod String_Concat;

	public readonly ManagerClass Manager;

	public FixedType.Class[] IntegralTypes => new FixedType.Class[8] { InternalType.Int32, InternalType.SByte, InternalType.Byte, InternalType.Int16, InternalType.UInt16, InternalType.UInt32, InternalType.Int64, InternalType.UInt64 };

	public IMethod NewMatchFailureException_ctor => get_single_method(MatchFailureException_tc, ".ctor");

	public ConstructorInfo MatchFailureException_ctor => NewMatchFailureException_ctor.GetConstructorInfo();

	public IMethod String_opEquality => get_single_method(String_tc, "op_Equality");

	public IMethod Decimal_opEquality => get_single_method(Decimal_tc, "op_Equality");

	public InternalTypeClass InternalType => Manager.InternalType;

	public SystemTypeClass SystemTypeCache => Manager.SystemTypeCache;

	private static IMethod get_single_method(TypeInfo tc, string name)
	{
		list<IMember> list = tc.LookupMember(name);
		if (list is list<IMember>.Cons && (object)((list<IMember>.Cons)list).tl == list<IMember>.Nil._N_constant_object)
		{
			IMember hd = ((list<IMember>.Cons)list).hd;
			return (IMethod)hd;
		}
		if (!Message.SeenError)
		{
			string text = "(see backtrace)".ToString();
			Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
		}
		throw new AssertionException("ncc\\external\\InternalTypes.n", 557, "", "(see backtrace)");
	}

	public FunctionType GetFunctionType(int len)
	{
		if (function_types.Length <= len)
		{
			Message.Error(Location.Default, string.Concat("function types only up to " + Convert.ToString(checked(function_types.Length - 1)) + " ", "parameters are supported, sorry (got " + Convert.ToString(len) + ")"));
			throw new Recovery();
		}
		if (function_types[len] == null)
		{
			function_types[len] = new FunctionType(Manager, len);
		}
		return function_types[len];
	}

	public TupleType GetTupleType(int len)
	{
		if (tuple_types.Length <= len)
		{
			Message.Error(Location.Default, string.Concat("tuple types only up to " + Convert.ToString(checked(tuple_types.Length - 1)) + " ", "parameters are supported, sorry (got " + Convert.ToString(len) + ")"));
			throw new Recovery();
		}
		if (tuple_types[len] == null)
		{
			tuple_types[len] = new TupleType(Manager, len);
		}
		return tuple_types[len];
	}

	public TypeInfo GetArrayType(int dims)
	{
		if (array_types[dims] == null)
		{
			array_types[dims] = lookup("Nemerle.Builtins.Array" + Convert.ToString(dims));
		}
		return array_types[dims];
	}

	private TypeInfo lookup(string type_name)
	{
		return Manager.Lookup(type_name);
	}

	private TypeInfo lookup(string type_name, int args_count)
	{
		return Manager.Lookup(type_name, args_count);
	}

	internal void InitSystemTypes()
	{
		_N_closureOf_InitSystemTypes_53529 n_closureOf_InitSystemTypes_ = new _N_closureOf_InitSystemTypes_53529();
		n_closureOf_InitSystemTypes_._N__N_closurised_this_ptr_53536 = this;
		Boolean_tc = lookup("System.Boolean");
		Boolean = new FixedType.Class(Boolean_tc, list<TypeVar>.Nil._N_constant_object);
		Int32_tc = lookup("System.Int32");
		Int32 = new FixedType.Class(Int32_tc, list<TypeVar>.Nil._N_constant_object);
		Manager.LibrariesManager.add_buildins = true;
		((LibraryReference.ExternalTypeInfo)Boolean_tc).AddBuiltins();
		((LibraryReference.ExternalTypeInfo)Int32_tc).AddBuiltins();
		Object_tc = lookup("System.Object");
		Object = new FixedType.Class(Object_tc, list<TypeVar>.Nil._N_constant_object);
		IntPtr_tc = lookup("System.IntPtr");
		IntPtr = new FixedType.Class(IntPtr_tc, list<TypeVar>.Nil._N_constant_object);
		((LibraryReference.ExternalTypeInfo)Object_tc).AddBuiltins();
		Void_tc = lookup("System.Void");
		Void = new FixedType.Void();
		Array_tc = lookup("System.Array");
		Array = new FixedType.Class(Array_tc, list<TypeVar>.Nil._N_constant_object);
		Attribute_tc = lookup("System.Attribute");
		Attribute = new FixedType.Class(Attribute_tc, list<TypeVar>.Nil._N_constant_object);
		Byte_tc = lookup("System.Byte");
		Byte = new FixedType.Class(Byte_tc, list<TypeVar>.Nil._N_constant_object);
		Char_tc = lookup("System.Char");
		Char = new FixedType.Class(Char_tc, list<TypeVar>.Nil._N_constant_object);
		Decimal_tc = lookup("System.Decimal");
		Decimal = new FixedType.Class(Decimal_tc, list<TypeVar>.Nil._N_constant_object);
		Delegate_tc = lookup("System.Delegate");
		Delegate = new FixedType.Class(Delegate_tc, list<TypeVar>.Nil._N_constant_object);
		MulticastDelegate_tc = lookup("System.MulticastDelegate");
		Double_tc = lookup("System.Double");
		Double = new FixedType.Class(Double_tc, list<TypeVar>.Nil._N_constant_object);
		Enum_tc = lookup("System.Enum");
		Enum = new FixedType.Class(Enum_tc, list<TypeVar>.Nil._N_constant_object);
		Exception_tc = lookup("System.Exception");
		Exception = new FixedType.Class(Exception_tc, list<TypeVar>.Nil._N_constant_object);
		Int16_tc = lookup("System.Int16");
		Int16 = new FixedType.Class(Int16_tc, list<TypeVar>.Nil._N_constant_object);
		Int64_tc = lookup("System.Int64");
		Int64 = new FixedType.Class(Int64_tc, list<TypeVar>.Nil._N_constant_object);
		SByte_tc = lookup("System.SByte");
		SByte = new FixedType.Class(SByte_tc, list<TypeVar>.Nil._N_constant_object);
		Single_tc = lookup("System.Single");
		Single = new FixedType.Class(Single_tc, list<TypeVar>.Nil._N_constant_object);
		String_tc = lookup("System.String");
		String = new FixedType.Class(String_tc, list<TypeVar>.Nil._N_constant_object);
		Type_tc = lookup("System.Type");
		InternalType.Type = new FixedType.Class(Type_tc, list<TypeVar>.Nil._N_constant_object);
		MethodInfo_tc = lookup("System.Reflection.MethodInfo");
		InternalType.MethodInfo = new FixedType.Class(MethodInfo_tc, list<TypeVar>.Nil._N_constant_object);
		ConstructorInfo_tc = lookup("System.Reflection.ConstructorInfo");
		InternalType.ConstructorInfo = new FixedType.Class(ConstructorInfo_tc, list<TypeVar>.Nil._N_constant_object);
		FieldInfo_tc = lookup("System.Reflection.FieldInfo");
		InternalType.FieldInfo = new FixedType.Class(FieldInfo_tc, list<TypeVar>.Nil._N_constant_object);
		PropertyInfo_tc = lookup("System.Reflection.PropertyInfo");
		InternalType.PropertyInfo = new FixedType.Class(PropertyInfo_tc, list<TypeVar>.Nil._N_constant_object);
		UInt16_tc = lookup("System.UInt16");
		UInt16 = new FixedType.Class(UInt16_tc, list<TypeVar>.Nil._N_constant_object);
		UInt32_tc = lookup("System.UInt32");
		UInt32 = new FixedType.Class(UInt32_tc, list<TypeVar>.Nil._N_constant_object);
		UInt64_tc = lookup("System.UInt64");
		UInt64 = new FixedType.Class(UInt64_tc, list<TypeVar>.Nil._N_constant_object);
		ValueType_tc = lookup("System.ValueType");
		ValueType = new FixedType.Class(ValueType_tc, list<TypeVar>.Nil._N_constant_object);
		IEnumerable_tc = lookup("System.Collections.IEnumerable");
		IEnumerator_tc = lookup("System.Collections.IEnumerator");
		IList_tc = lookup("System.Collections.IList");
		ICollection_tc = lookup("System.Collections.ICollection");
		Generic_IEnumerable_tc = lookup("System.Collections.Generic.IEnumerable");
		Generic_IEnumerator_tc = lookup("System.Collections.Generic.IEnumerator");
		Generic_IList_tc = lookup("System.Collections.Generic.IList");
		Generic_ICollection_tc = lookup("System.Collections.Generic.ICollection");
		Generic_Nullable_tc = lookup("System.Nullable", 1);
		DllImport_tc = lookup("System.Runtime.InteropServices.DllImportAttribute");
		Serializable_tc = lookup("System.SerializableAttribute");
		Obsolete_tc = lookup("System.ObsoleteAttribute");
		Conditional_tc = lookup("System.Diagnostics.ConditionalAttribute");
		IObjectReference = new FixedType.Class(lookup("System.Runtime.Serialization.IObjectReference"), list<TypeVar>.Nil._N_constant_object);
		Reflection_Missing = new FixedType.Class(lookup("System.Reflection.Missing"), list<TypeVar>.Nil._N_constant_object);
		ParamArrayAttribute_tc = lookup("System.ParamArrayAttribute");
		FlagsAttribute_tc = lookup("System.FlagsAttribute");
		AssemblyVersionAttribute_tc = lookup("System.Reflection.AssemblyVersionAttribute");
		AssemblyKeyFileAttribute_tc = lookup("System.Reflection.AssemblyKeyFileAttribute");
		AssemblyCultureAttribute_tc = lookup("System.Reflection.AssemblyCultureAttribute");
		AssemblyCompanyAttribute_tc = lookup("System.Reflection.AssemblyCompanyAttribute");
		AssemblyCopyrightAttribute_tc = lookup("System.Reflection.AssemblyCopyrightAttribute");
		AssemblyDescriptionAttribute_tc = lookup("System.Reflection.AssemblyDescriptionAttribute");
		AssemblyFileVersionAttribute_tc = lookup("System.Reflection.AssemblyFileVersionAttribute");
		AssemblyTitleAttribute_tc = lookup("System.Reflection.AssemblyTitleAttribute");
		AssemblyProductAttribute_tc = lookup("System.Reflection.AssemblyProductAttribute");
		n_closureOf_InitSystemTypes_._N_is_right_53534 = new _N_is_right__53538(n_closureOf_InitSystemTypes_);
		Delegate_Combine = _N_single_53557(n_closureOf_InitSystemTypes_, Delegate_tc, "Combine");
		Delegate_Remove = _N_single_53557(n_closureOf_InitSystemTypes_, Delegate_tc, "Remove");
		String_Concat = _N_single_53557(n_closureOf_InitSystemTypes_, String_tc, "Concat");
		function_types = new FunctionType[21];
		tuple_types = new TupleType[21];
		array_types = new TypeInfo[20];
		InternalType.MatchFailureException_tc = null;
	}

	internal void InitNemerleTypes()
	{
		if (InternalType.MatchFailureException_tc == null)
		{
			SystemTypeCache.NemerleAttribute = SystemTypeCache.Reflect("Nemerle.Internal.NemerleAttribute");
			InternalType.MatchFailureException_tc = lookup("Nemerle.Core.MatchFailureException");
			InternalType.MatchFailureException = new FixedType.Class(InternalType.MatchFailureException_tc, list<TypeVar>.Nil._N_constant_object);
			InternalType.NullMatchException_tc = lookup("Nemerle.Core.NullMatchException");
			InternalType.ContainsMacroAttribute_tc = lookup("Nemerle.Internal.ContainsMacroAttribute");
			InternalType.VariantAttribute_tc = lookup("Nemerle.Internal.VariantAttribute");
			InternalType.TypeAliasAttribute_tc = lookup("Nemerle.Internal.TypeAliasAttribute");
			InternalType.VariantOptionAttribute_tc = lookup("Nemerle.Internal.VariantOptionAttribute");
			InternalType.VolatileModifier_tc = lookup("Nemerle.Internal.VolatileModifier");
			InternalType.ImmutableAttribute_tc = lookup("Nemerle.Internal.ImmutableAttribute");
			InternalType.ExtensionAttribute_tc = lookup("Nemerle.Internal.ExtensionAttribute");
			InternalType.ConstantVariantOptionAttribute_tc = lookup("Nemerle.Internal.ConstantVariantOptionAttribute");
			InternalType.ExtensionPatternEncodingAttribute_tc = lookup("Nemerle.Internal.ExtensionPatternEncodingAttribute");
			InternalType.Nemerle_list_tc = lookup("Nemerle.Core.list", 1);
			InternalType.Nemerle_option_tc = lookup("Nemerle.Core.option");
			InternalType.IgnoreFieldAttribute_tc = lookup("Nemerle.Internal.IgnoreFieldAttribute");
			InternalType.IgnoreConstructorAttribute_tc = lookup("Nemerle.Internal.IgnoreConstructorAttribute");
			InternalType.IdentityFunction_tc = lookup("Nemerle.Utility.Identity");
		}
	}

	internal InternalTypeClass(ManagerClass man)
	{
		Manager = man;
	}

	private void __fake()
	{
		__fake();
		SystemTypeClass systemTypeCache = SystemTypeCache;
		InternalTypeClass internalType = InternalType;
	}

	[CompilerGenerated]
	internal override void RelocateImplInternal(RelocationInfo _info)
	{
		if (!_info.VisitedObjects.ContainsKey(this))
		{
			_info.VisitedObjects[this] = 0;
			IMethod string_Concat = String_Concat;
			if (string_Concat != null)
			{
				((ISupportRelocation)string_Concat).RelocateImpl(_info);
			}
			string_Concat = Delegate_Remove;
			if (string_Concat != null)
			{
				((ISupportRelocation)string_Concat).RelocateImpl(_info);
			}
			string_Concat = Delegate_Combine;
			if (string_Concat != null)
			{
				((ISupportRelocation)string_Concat).RelocateImpl(_info);
			}
		}
	}

	void ISupportRelocation.RelocateImpl(RelocationInfo _info)
	{
		//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
		this.RelocateImplInternal(_info);
	}

	private IMethod _N_single_53557(_N_closureOf_InitSystemTypes_53529 _N_InitSystemTypes_cp_53556, TypeInfo tc, string name)
	{
		list<IMember> list = tc.LookupMember(name).Filter(_N_InitSystemTypes_cp_53556._N_is_right_53534);
		if (list is list<IMember>.Cons && (object)((list<IMember>.Cons)list).tl == list<IMember>.Nil._N_constant_object)
		{
			IMember hd = ((list<IMember>.Cons)list).hd;
			return (IMethod)hd;
		}
		throw new AssertionException("ncc\\external\\InternalTypes.n", 684, "", "");
	}
}
