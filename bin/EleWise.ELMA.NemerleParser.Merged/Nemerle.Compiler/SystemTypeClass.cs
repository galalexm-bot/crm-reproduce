using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Collections;
using Nemerle.Core;

namespace Nemerle.Compiler;

public class SystemTypeClass : ISupportRelocation
{
	private sealed class _N__N_lambda__53099__53212 : Function<ParameterInfo, string>
	{
		[SpecialName]
		public static readonly _N__N_lambda__53099__53212 Instance = new _N__N_lambda__53099__53212();

		[SpecialName]
		public sealed override string apply(ParameterInfo p)
		{
			return p.ParameterType.Name;
		}
	}

	public Type Array;

	public Type Boolean;

	public Type Byte;

	public Type Char;

	public Type Decimal;

	public Type Double;

	public Type Enum;

	public Type FlagsAttribute;

	public Type Int16;

	public Type Int32;

	public Type Int64;

	public Type IntPtr;

	public Type Delegate;

	public Type MulticastDelegate;

	public Type Object;

	public Type Reflection_AssemblyConfigurationAttribute;

	public Type Reflection_FieldInfo;

	public Type Reflection_PropertyInfo;

	public Type Reflection_DefaultMemberAttribute;

	public Type Runtime_CompilerServices_IsVolatile;

	public Type DebuggableAttribute;

	public Type DebuggableAttribute_DebuggingModes;

	public Type CompilationRelaxationsAttribute;

	public Type SByte;

	public Type Single;

	public Type String;

	public Type Type;

	public Type UInt16;

	public Type UInt32;

	public Type UInt64;

	public Type Void;

	public Type ParamArrayAttribute;

	public Type ExtensionAttribute;

	public string ExtensionAttributeAssembly;

	public Type SQ_ExtensionAttribute;

	public string SQ_ExtensionAttributeAssembly;

	public MethodInfo RuntimeHelpers_get_OffsetToStringData;

	public Hashtable<string, ConstructorInfo> Decimal_ctors;

	public MethodInfo Type_GetTypeFromHandle;

	public MethodInfo MethodBase_GetMethodFromHandle;

	public MethodInfo MethodBase_GetMethodFromHandle2;

	public MethodInfo FieldInfo_GetFieldFromHandle;

	public MethodInfo FieldInfo_GetFieldFromHandle2;

	public MethodInfo AssemblyBuilder_EmbedResourceFile;

	public MethodInfo String_opEquality;

	public MethodInfo String_opInequality;

	public MethodInfo Decimal_opEquality;

	public MethodInfo String_Concat;

	public ConstructorInfo ObjectCtor;

	public MethodInfo Delegate_Combine;

	public MethodInfo Delegate_Remove;

	private Type _N_field_nemerle_attribute_embeded_in_NemerleAttribute_3332;

	public readonly ManagerClass Manager;

	public Type NemerleAttribute
	{
		get
		{
			if (_N_field_nemerle_attribute_embeded_in_NemerleAttribute_3332 == null)
			{
				InternalType.InitNemerleTypes();
			}
			return _N_field_nemerle_attribute_embeded_in_NemerleAttribute_3332;
		}
		internal set
		{
			_N_field_nemerle_attribute_embeded_in_NemerleAttribute_3332 = value;
		}
	}

	public Type NullMatchException => InternalType.NullMatchException_tc.SystemType;

	public Type ContainsMacroAttribute => InternalType.ContainsMacroAttribute_tc.SystemType;

	public Type VariantAttribute => InternalType.VariantAttribute_tc.SystemType;

	public Type VariantOptionAttribute => InternalType.VariantOptionAttribute_tc.SystemType;

	public Type VolatileModifier => InternalType.VolatileModifier_tc.SystemType;

	public Type ImmutableAttribute => InternalType.ImmutableAttribute_tc.SystemType;

	public Type ConstantVariantOptionAttribute => InternalType.ConstantVariantOptionAttribute_tc.SystemType;

	public Type TypeAliasAttribute => InternalType.TypeAliasAttribute_tc.SystemType;

	public Type ExtensionPatternEncodingAttribute => InternalType.ExtensionPatternEncodingAttribute_tc.SystemType;

	public InternalTypeClass InternalType => Manager.InternalType;

	public SystemTypeClass SystemTypeCache => Manager.SystemTypeCache;

	public Type Reflect(string type_name)
	{
		option<Type> option = Manager.NameTree.LookupSystemType(type_name);
		if (option is option<Type>.Some)
		{
			return ((option<Type>.Some)option).val;
		}
		if (!Message.SeenError)
		{
			string text = string.Concat("cannot reflect `" + type_name, "'").ToString();
			Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
		}
		throw new AssertionException("ncc\\external\\InternalTypes.n", 164, "", string.Concat("cannot reflect `" + type_name, "'").ToString());
	}

	internal void Init()
	{
		int num = 0;
		Array = Reflect("System.Array");
		Boolean = Reflect("System.Boolean");
		Byte = Reflect("System.Byte");
		Char = Reflect("System.Char");
		Decimal = Reflect("System.Decimal");
		Double = Reflect("System.Double");
		Enum = Reflect("System.Enum");
		FlagsAttribute = Reflect("System.FlagsAttribute");
		Int16 = Reflect("System.Int16");
		Int32 = Reflect("System.Int32");
		Int64 = Reflect("System.Int64");
		IntPtr = Reflect("System.IntPtr");
		Delegate = Reflect("System.Delegate");
		MulticastDelegate = Reflect("System.MulticastDelegate");
		Object = Reflect("System.Object");
		Reflection_FieldInfo = Reflect("System.Reflection.FieldInfo");
		Reflection_PropertyInfo = Reflect("System.Reflection.PropertyInfo");
		Reflection_AssemblyConfigurationAttribute = Reflect("System.Reflection.AssemblyConfigurationAttribute");
		Runtime_CompilerServices_IsVolatile = Reflect("System.Runtime.CompilerServices.IsVolatile");
		DebuggableAttribute = Reflect("System.Diagnostics.DebuggableAttribute");
		DebuggableAttribute_DebuggingModes = Reflect("System.Diagnostics.DebuggableAttribute.DebuggingModes");
		CompilationRelaxationsAttribute = Reflect("System.Runtime.CompilerServices.CompilationRelaxationsAttribute");
		SByte = Reflect("System.SByte");
		Single = Reflect("System.Single");
		String = Reflect("System.String");
		SystemTypeCache.Type = Reflect("System.Type");
		UInt16 = Reflect("System.UInt16");
		UInt32 = Reflect("System.UInt32");
		UInt64 = Reflect("System.UInt64");
		Void = Reflect("System.Void");
		ParamArrayAttribute = Reflect("System.ParamArrayAttribute");
		Reflection_DefaultMemberAttribute = Reflect("System.Reflection.DefaultMemberAttribute");
		Decimal_ctors = new Hashtable<string, ConstructorInfo>();
		ConstructorInfo[] constructors = SystemTypeCache.Decimal.GetConstructors();
		for (num = 0; num < constructors.Length; num = checked(num + 1))
		{
			ConstructorInfo constructorInfo = constructors[num];
			constructorInfo = constructorInfo;
			list<ParameterInfo> list = constructorInfo.GetParameters().NToList();
			string[] array = new string[1];
			IEnumerable<ParameterInfo> source = list;
			Function<ParameterInfo, string> instance = _N__N_lambda__53099__53212.Instance;
			array[0] = string.Join(", ", source.MapToArray(instance));
			string key = string.Concat(array);
			Decimal_ctors[key] = constructorInfo;
		}
		if (Decimal_ctors.Count < 7)
		{
			throw new AssertionException("ncc\\external\\InternalTypes.n", 213, "Decimal_ctors.Count >= 7", "");
		}
		RuntimeHelpers_get_OffsetToStringData = typeof(RuntimeHelpers).GetMethod("get_OffsetToStringData");
		Type_GetTypeFromHandle = SystemTypeCache.Type.GetMethod("GetTypeFromHandle");
		MethodBase_GetMethodFromHandle = typeof(MethodBase).GetMethod("GetMethodFromHandle", new Type[1] { typeof(RuntimeMethodHandle) });
		MethodBase_GetMethodFromHandle2 = typeof(MethodBase).GetMethod("GetMethodFromHandle", new Type[2]
		{
			typeof(RuntimeMethodHandle),
			typeof(RuntimeTypeHandle)
		});
		FieldInfo_GetFieldFromHandle = typeof(FieldInfo).GetMethod("GetFieldFromHandle", new Type[1] { typeof(RuntimeFieldHandle) });
		FieldInfo_GetFieldFromHandle2 = typeof(FieldInfo).GetMethod("GetFieldFromHandle", new Type[2]
		{
			typeof(RuntimeFieldHandle),
			typeof(RuntimeTypeHandle)
		});
		AssemblyBuilder_EmbedResourceFile = Reflect("System.Reflection.Emit.AssemblyBuilder").GetMethod("EmbedResourceFile", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic, null, CallingConventions.Any, new Type[2] { String, String }, null);
		String_opEquality = SystemTypeCache.String.GetMethod("op_Equality");
		String_opInequality = SystemTypeCache.String.GetMethod("op_Inequality");
		String_Concat = String.GetMethod("Concat", new Type[2] { String, String });
		Decimal_opEquality = SystemTypeCache.Decimal.GetMethod("op_Equality");
		ObjectCtor = Object.GetConstructor(Type.EmptyTypes);
		if (!(ObjectCtor != null))
		{
			throw new AssertionException("ncc\\external\\InternalTypes.n", 231, "ObjectCtor != null", "");
		}
		Delegate_Combine = Delegate.GetMethod("Combine", new Type[2] { Delegate, Delegate });
		Delegate_Remove = Delegate.GetMethod("Remove", new Type[2] { Delegate, Delegate });
	}

	internal SystemTypeClass(ManagerClass man)
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
	}

	void ISupportRelocation.RelocateImpl(RelocationInfo _info)
	{
		//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
		this.RelocateImplInternal(_info);
	}
}
