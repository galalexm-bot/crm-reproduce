using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Nemerle.Builtins;
using Nemerle.Collections;
using Nemerle.Compiler.Parsetree;
using Nemerle.Compiler.Typedtree;
using Nemerle.Core;
using Nemerle.Internal;
using Nemerle.Utility;

namespace Nemerle.Compiler;

public class LibraryReference : ISupportRelocation
{
	public abstract class ExternalMemberInfo : MemberInfo, IEquatable<ExternalMemberInfo>
	{
		private sealed class _N__N_lambda__56363__56375 : Function<PExpr, list<PExpr>, PExpr>
		{
			[SpecialName]
			public static readonly _N__N_lambda__56363__56375 Instance = new _N__N_lambda__56363__56375();

			[SpecialName]
			public sealed override PExpr apply(PExpr name, list<PExpr> args)
			{
				return new PExpr.Call(Macros.QuotationChoose(name), Macros.QuotationChoose(args));
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[IgnoreField]
		[IgnoreField]
		private bool _N_is_cached_18499;

		[IgnoreField]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[IgnoreField]
		private AttributesAndModifiers _N_cached_value_18498;

		protected readonly LibraryReference library;

		protected readonly int id;

		public override Location NameLocation => Location;

		protected InternalTypeClass InternalType => library.Manager.InternalType;

		protected SystemTypeClass SystemTypeCache => library.Manager.SystemTypeCache;

		public Location Location => library._location;

		public override GlobalEnv GlobalEnv => library.Manager.CoreEnv;

		public LibraryReference Library
		{
			[DebuggerStepThrough]
			[CompilerGenerated]
			get
			{
				return library;
			}
		}

		public ExternalMemberInfo(LibraryReference lib)
		{
			library = lib;
			id = lib.Manager.GetNewId();
			if (InternalType.Obsolete_tc != null)
			{
				is_obsolete = HasAttribute(InternalType.Obsolete_tc);
			}
		}

		internal override Nemerle.Builtins.Tuple<string, bool> GetObsoletionDetails()
		{
			Attribute customAttribute = Attribute.GetCustomAttribute(GetHandle(), InternalType.Obsolete_tc.SystemType, inherit: false);
			if (customAttribute == null)
			{
				throw new AssertionException("ncc\\external\\ExternalMemberInfo\\ExternalMemberInfo.n", 74, "attr != null", "");
			}
			return new Nemerle.Builtins.Tuple<string, bool>((string)customAttribute.GetType().InvokeMember("Message", System.Reflection.BindingFlags.GetField | System.Reflection.BindingFlags.GetProperty, null, customAttribute, null, null, null, null), (bool)customAttribute.GetType().InvokeMember("IsError", System.Reflection.BindingFlags.GetField | System.Reflection.BindingFlags.GetProperty, null, customAttribute, null, null, null, null));
		}

		public bool HasAttribute(TypeInfo attribute)
		{
			Type systemType = attribute.SystemType;
			return GetHandle().IsDefined(systemType, inherit: false);
		}

		public abstract override System.Reflection.MemberInfo GetHandle();

		public override AttributesAndModifiers GetModifiers()
		{
			if (!_N_is_cached_18499)
			{
				IList<CustomAttributeData> customAttributes = CustomAttributeData.GetCustomAttributes(GetHandle());
				list<Nemerle.Builtins.Tuple<PExpr, list<PExpr>>> list = ConvertCustomAttributesData(customAttributes, library);
				Function<PExpr, list<PExpr>, PExpr> instance = _N__N_lambda__56363__56375.Instance;
				_N_cached_value_18498 = new AttributesAndModifiers(custom_attrs: list.Map(instance), mods: Attributes);
				_N_is_cached_18499 = true;
			}
			return _N_cached_value_18498;
		}

		public override bool IsCustomAttributeDefined(string attributeFullName)
		{
			return GetHandle().IsDefined(library.Manager.LookupSystemType(attributeFullName), inherit: false);
		}

		public bool Equals(ExternalMemberInfo o)
		{
			if (o == null)
			{
				string text = "Assertion: o != null\nAt: ncc\\external\\ExternalMemberInfo\\ExternalMemberInfo.n failed.";
			}
			System.Reflection.MemberInfo handle = GetHandle();
			System.Reflection.MemberInfo handle2 = o.GetHandle();
			try
			{
				return id == o.id || handle2.Equals(handle);
			}
			catch (Exception)
			{
				try
				{
					return handle.Equals(handle2);
				}
				catch (Exception)
				{
					return false;
				}
			}
		}

		public override int GetHashCode()
		{
			return id;
		}

		public override bool Equals(object other)
		{
			return other == this || (other is ExternalMemberInfo && Equals((ExternalMemberInfo)other));
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				library?.RelocateImplInternal(_info);
			}
		}
	}

	public class ExternalEventInfo : ExternalMemberInfo, IMember, IEvent
	{
		protected readonly EventInfo handle;

		protected readonly ExternalMethodInfo adder;

		protected readonly ExternalMethodInfo remover;

		protected readonly FixedType mem_type;

		public TypeInfo DeclaringType => library.TypeInfoOfType(handle.DeclaringType);

		public string Name => handle.Name;

		public MemberTypes MemberKind => MemberTypes.Event;

		public EventInfo Handle
		{
			[DebuggerStepThrough]
			[CompilerGenerated]
			get
			{
				return handle;
			}
		}

		[SpecialName]
		public override bool IsCustomAttributeDefined(string attributeFullName)
		{
			return base.IsCustomAttributeDefined(attributeFullName);
		}

		[SpecialName]
		public override AttributesAndModifiers GetModifiers()
		{
			return base.GetModifiers();
		}

		[SpecialName]
		public virtual NemerleModifiers get_Attributes()
		{
			return base.Attributes;
		}

		[SpecialName]
		public override list<string> GetConditions()
		{
			return base.GetConditions();
		}

		[SpecialName]
		public override bool get_IsConditional()
		{
			return base.IsConditional;
		}

		[SpecialName]
		public override void set_HasBeenUsed(bool value)
		{
			base.HasBeenUsed = value;
		}

		[SpecialName]
		public override bool get_HasBeenUsed()
		{
			return base.HasBeenUsed;
		}

		[SpecialName]
		public override bool get_IsStatic()
		{
			return base.IsStatic;
		}

		[SpecialName]
		public override Location get_NameLocation()
		{
			return base.NameLocation;
		}

		[SpecialName]
		public virtual bool get_IsPrivate()
		{
			return base.IsPrivate;
		}

		[SpecialName]
		public virtual bool get_IsObsolete()
		{
			return base.IsObsolete;
		}

		[SpecialName]
		public new virtual bool CanAccess(TypeInfo memberTypeInfo, TypeInfo currentTypeInfo, bool isThisAccess)
		{
			return base.CanAccess(memberTypeInfo, currentTypeInfo, isThisAccess);
		}

		[SpecialName]
		public virtual Location get_Location()
		{
			return base.Location;
		}

		[SpecialName]
		public override bool get_IsConstructor()
		{
			return base.IsConstructor;
		}

		public ExternalEventInfo(LibraryReference lib, EventInfo h)
		{
			handle = h;
			base._002Ector(lib);
			MethodInfo addMethod = handle.GetAddMethod(nonPublic: true);
			MethodInfo removeMethod = handle.GetRemoveMethod(nonPublic: true);
			Map<string, StaticTypeVar> tenv = ((ExternalTypeInfo)DeclaringType).tenv;
			adder = library.MethodOfMethodInfo(tenv, addMethod);
			remover = library.MethodOfMethodInfo(tenv, removeMethod);
			if (adder == null)
			{
				throw new AssertionException("ncc\\external\\ExternalMemberInfo\\ExternalEventInfo.n", 67, "adder != null", "");
			}
			if (remover == null)
			{
				throw new AssertionException("ncc\\external\\ExternalMemberInfo\\ExternalEventInfo.n", 68, "remover != null", "");
			}
			FixedType.Fun memType = adder.GetMemType();
			TypeVar from = memType.from;
			mem_type = from.FixedValue;
			attributes = adder.Attributes;
		}

		public IMethod GetAdder()
		{
			return adder;
		}

		public IMethod GetRemover()
		{
			return remover;
		}

		public EventInfo GetEventInfo()
		{
			return handle;
		}

		public FixedType GetMemType()
		{
			return mem_type;
		}

		public bool CanAccess(TypeInfo _source)
		{
			return true;
		}

		public override System.Reflection.MemberInfo GetHandle()
		{
			return handle;
		}

		public override string ToString()
		{
			return MemberBuilder.DescribeMember(this);
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				remover?.RelocateImplInternal(_info);
				adder?.RelocateImplInternal(_info);
			}
		}
	}

	public class ExternalFieldInfo : ExternalMemberInfo, IMember, IField
	{
		protected readonly FieldInfo handle;

		protected readonly FixedType tt_type;

		public TypeInfo DeclaringType => library.TypeInfoOfType(handle.DeclaringType);

		public string Name => handle.Name;

		public MemberTypes MemberKind => MemberTypes.Field;

		public bool HasBeenAssigned
		{
			get
			{
				return true;
			}
			set
			{
				base.HasBeenUsed = value;
			}
		}

		public bool IsLiteral => handle.IsLiteral;

		public bool IsMutable => !handle.IsInitOnly && !handle.IsLiteral && !handle.IsDefined(typeof(ImmutableAttribute), inherit: false);

		public bool IsVolatile => handle.IsDefined(typeof(IsVolatile), inherit: false) || handle.IsDefined(typeof(VolatileModifier), inherit: false);

		public FieldInfo Handle
		{
			[DebuggerStepThrough]
			[CompilerGenerated]
			get
			{
				return handle;
			}
		}

		[SpecialName]
		public override bool IsCustomAttributeDefined(string attributeFullName)
		{
			return base.IsCustomAttributeDefined(attributeFullName);
		}

		[SpecialName]
		public override AttributesAndModifiers GetModifiers()
		{
			return base.GetModifiers();
		}

		[SpecialName]
		public virtual NemerleModifiers get_Attributes()
		{
			return base.Attributes;
		}

		[SpecialName]
		public override list<string> GetConditions()
		{
			return base.GetConditions();
		}

		[SpecialName]
		public override bool get_IsConditional()
		{
			return base.IsConditional;
		}

		[SpecialName]
		public override void set_HasBeenUsed(bool value)
		{
			base.HasBeenUsed = value;
		}

		[SpecialName]
		public override bool get_HasBeenUsed()
		{
			return base.HasBeenUsed;
		}

		[SpecialName]
		public override bool get_IsStatic()
		{
			return base.IsStatic;
		}

		[SpecialName]
		public override Location get_NameLocation()
		{
			return base.NameLocation;
		}

		[SpecialName]
		public virtual bool get_IsPrivate()
		{
			return base.IsPrivate;
		}

		[SpecialName]
		public virtual bool get_IsObsolete()
		{
			return base.IsObsolete;
		}

		[SpecialName]
		public new virtual bool CanAccess(TypeInfo memberTypeInfo, TypeInfo currentTypeInfo, bool isThisAccess)
		{
			return base.CanAccess(memberTypeInfo, currentTypeInfo, isThisAccess);
		}

		[SpecialName]
		public virtual Location get_Location()
		{
			return base.Location;
		}

		[SpecialName]
		public override bool get_IsConstructor()
		{
			return base.IsConstructor;
		}

		public ExternalFieldInfo(Map<string, StaticTypeVar> tenv, LibraryReference lib, FieldInfo h)
		{
			handle = h;
			base._002Ector(lib);
			tt_type = library.TypeOfType(tenv, handle.FieldType);
			set_attributes();
		}

		private void set_attributes()
		{
			attributes = NemerleModifiers.None;
			if (!handle.IsInitOnly && !handle.IsLiteral)
			{
				attributes |= NemerleModifiers.Mutable;
			}
			if (handle.IsStatic)
			{
				attributes |= NemerleModifiers.Static;
			}
			if (handle.IsSpecialName)
			{
				attributes |= NemerleModifiers.SpecialName;
			}
			if (handle.IsPrivate)
			{
				attributes |= NemerleModifiers.Private;
			}
			if (handle.IsPublic)
			{
				attributes |= NemerleModifiers.Public;
			}
			if (handle.IsFamily)
			{
				attributes |= NemerleModifiers.Protected;
			}
			if (handle.IsAssembly)
			{
				attributes |= NemerleModifiers.Internal;
			}
			if (handle.IsFamilyAndAssembly)
			{
				attributes |= NemerleModifiers.Protected | NemerleModifiers.Internal;
			}
			if (!handle.IsInitOnly && !handle.IsLiteral && handle.IsDefined(typeof(ImmutableAttribute), inherit: false))
			{
				attributes |= NemerleModifiers.CompilerMutable;
			}
		}

		public override string ToString()
		{
			return MemberBuilder.DescribeMember(this);
		}

		public FieldInfo GetFieldInfo()
		{
			return handle;
		}

		public override System.Reflection.MemberInfo GetHandle()
		{
			return handle;
		}

		public FixedType GetMemType()
		{
			return tt_type;
		}

		public Literal GetValue()
		{
			if (!IsLiteral)
			{
				throw new AssertionException("ncc\\external\\ExternalMemberInfo\\ExternalFieldInfo.n", 107, "IsLiteral", "");
			}
			object value = handle.GetValue(null);
			object obj;
			if (value is ulong)
			{
				obj = new Literal.Integer((ulong)value, is_negative: false, null).WithProperType();
			}
			else if (value is double)
			{
				obj = new Literal.Double((double)value);
			}
			else if (value is float)
			{
				obj = new Literal.Float((float)value);
			}
			else if (value is string)
			{
				obj = new Literal.String((string)value);
			}
			else if (value is char)
			{
				obj = new Literal.Char((char)value);
			}
			else if (value is bool)
			{
				obj = new Literal.Bool((bool)value);
			}
			else
			{
				long num = Convert.ToInt64(value);
				obj = ((num != long.MinValue) ? new Literal.Integer(checked((ulong)Math.Abs(num)), num < 0L, null).WithProperType() : new Literal.Integer(9223372036854775808uL, is_negative: true, InternalType.Int64));
			}
			Literal literal = (Literal)obj;
			object result;
			if (handle.FieldType.IsEnum)
			{
				FixedType.Class treat_as = Enum.GetUnderlyingType(handle.FieldType).FullName switch
				{
					"System.Int32" => InternalType.Int32, 
					"System.UInt32" => InternalType.UInt32, 
					"System.Int64" => InternalType.Int64, 
					"System.UInt64" => InternalType.UInt64, 
					"System.Int16" => InternalType.Int16, 
					"System.UInt16" => InternalType.UInt16, 
					"System.Byte" => InternalType.Byte, 
					"System.SByte" => InternalType.SByte, 
					_ => InternalType.Int64, 
				};
				Literal.Integer integer = (Literal.Integer)literal;
				integer = new Literal.Integer(integer.val, integer.is_negative, treat_as);
				result = new Literal.Enum(integer, library.TypeInfoOfType(handle.DeclaringType), this);
			}
			else
			{
				result = literal;
			}
			return (Literal)result;
		}

		public bool CanAccess(TypeInfo source)
		{
			return handle.IsPublic || (source.IsDerivedFrom(DeclaringType) && (handle.IsFamily || handle.IsFamilyOrAssembly)) || (library.IsFriend && (handle.IsAssembly || handle.IsFamilyOrAssembly));
		}
	}

	public class ExternalMethodInfo : ExternalMemberInfo, IMember, IMethod
	{
		private sealed class _N__N_lambda__57094__57187 : Function<PExpr, list<PExpr>, PExpr>
		{
			[SpecialName]
			public static readonly _N__N_lambda__57094__57187 Instance = new _N__N_lambda__57094__57187();

			[SpecialName]
			public sealed override PExpr apply(PExpr name, list<PExpr> args)
			{
				return new PExpr.Call(Macros.QuotationChoose(name), Macros.QuotationChoose(args));
			}
		}

		private sealed class _N__N_lambda__57304__57316 : Function<Attribute, string>
		{
			[SpecialName]
			public static readonly _N__N_lambda__57304__57316 Instance = new _N__N_lambda__57304__57316();

			[SpecialName]
			public sealed override string apply(Attribute attr)
			{
				return (string)attr.GetType().InvokeMember("ConditionString", System.Reflection.BindingFlags.GetField | System.Reflection.BindingFlags.GetProperty, null, attr, null, null, null, null);
			}
		}

		[IgnoreField]
		[IgnoreField]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _N_is_cached_18548;

		[IgnoreField]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[IgnoreField]
		private list<string> _N_cached_value_18547;

		protected readonly MethodBase handle;

		protected readonly TFunHeader fun_header;

		protected readonly bool is_var_args;

		private readonly bool _isConditional;

		public TypeInfo DeclaringType => library.TypeInfoOfType(handle.DeclaringType);

		public string Name => handle.Name;

		public bool IsFinal => handle.IsFinal;

		public MemberTypes MemberKind => handle.MemberType;

		public bool IsVarArgs => is_var_args;

		public bool IsExtension { get; internal set; }

		public override bool IsConditional => _isConditional;

		public override bool IsConstructor => handle.IsConstructor;

		public BuiltinMethodKind BuiltinKind => BuiltinMethodKind.NotBuiltin._N_constant_object;

		public TypeVar ReturnType => fun_header.ReturnType;

		public MethodBase Handle
		{
			[CompilerGenerated]
			[DebuggerStepThrough]
			get
			{
				return handle;
			}
		}

		public TFunHeader Header
		{
			[DebuggerStepThrough]
			[CompilerGenerated]
			get
			{
				return fun_header;
			}
		}

		[SpecialName]
		public virtual bool get_IsAbstract()
		{
			return base.IsAbstract;
		}

		[SpecialName]
		public override bool IsCustomAttributeDefined(string attributeFullName)
		{
			return base.IsCustomAttributeDefined(attributeFullName);
		}

		[SpecialName]
		public override AttributesAndModifiers GetModifiers()
		{
			return base.GetModifiers();
		}

		[SpecialName]
		public virtual NemerleModifiers get_Attributes()
		{
			return base.Attributes;
		}

		[SpecialName]
		public override void set_HasBeenUsed(bool value)
		{
			base.HasBeenUsed = value;
		}

		[SpecialName]
		public override bool get_HasBeenUsed()
		{
			return base.HasBeenUsed;
		}

		[SpecialName]
		public override bool get_IsStatic()
		{
			return base.IsStatic;
		}

		[SpecialName]
		public override Location get_NameLocation()
		{
			return base.NameLocation;
		}

		[SpecialName]
		public virtual bool get_IsPrivate()
		{
			return base.IsPrivate;
		}

		[SpecialName]
		public virtual bool get_IsObsolete()
		{
			return base.IsObsolete;
		}

		[SpecialName]
		public new virtual bool CanAccess(TypeInfo memberTypeInfo, TypeInfo currentTypeInfo, bool isThisAccess)
		{
			return base.CanAccess(memberTypeInfo, currentTypeInfo, isThisAccess);
		}

		[SpecialName]
		public virtual Location get_Location()
		{
			return base.Location;
		}

		public ExternalMethodInfo(Map<string, StaticTypeVar> tenv, LibraryReference lib, MethodBase h)
		{
			int num = 0;
			list<TParameter> list = null;
			handle = h;
			base._002Ector(lib);
			Nemerle.Builtins.Tuple<list<StaticTypeVar>, Map<string, StaticTypeVar>> tuple = TyCodec.ReflectTyparms(lib, tenv, h);
			list<StaticTypeVar> typarms = tuple.Field0;
			Map<string, StaticTypeVar> tenv2 = tuple.Field1;
			MethodBase methodBase = handle;
			FixedType ret_type = ((!(methodBase is MethodInfo)) ? InternalType.Void : library.TypeOfType(tenv2, ((MethodInfo)methodBase).ReturnType));
			ParameterInfo[] parameters = handle.GetParameters();
			checked
			{
				if (parameters.Length > 0)
				{
					is_var_args = parameters[parameters.Length - 1].IsDefined(SystemTypeCache.ParamArrayAttribute, inherit: false);
				}
				list = list<TParameter>.Nil._N_constant_object;
				for (num = parameters.Length - 1; num >= 0; num--)
				{
					ParameterInfo parameterInfo = parameters[num];
					Nemerle.Builtins.Tuple<ParmKind, FixedType> obj;
					FixedType t;
					if (parameterInfo.ParameterType.IsByRef)
					{
						t = library.TypeOfType(tenv2, parameterInfo.ParameterType.GetElementType());
						obj = ((!parameterInfo.IsOut) ? new Nemerle.Builtins.Tuple<ParmKind, FixedType>(ParmKind.Ref, new FixedType.Ref(t)) : new Nemerle.Builtins.Tuple<ParmKind, FixedType>(ParmKind.Out, new FixedType.Out(t)));
					}
					else
					{
						obj = new Nemerle.Builtins.Tuple<ParmKind, FixedType>(ParmKind.Normal, library.TypeOfType(tenv2, parameterInfo.ParameterType));
					}
					Nemerle.Builtins.Tuple<ParmKind, FixedType> tuple2 = obj;
					ParmKind field = tuple2.Field0;
					t = tuple2.Field1;
					TParameter tParameter = new TParameter(lib._location, parameterInfo.Name, Location.Default, 0, t, lib._location, _N_getCustomAttribute_57182(parameterInfo, lib), field);
					object defaultValue = parameterInfo.DefaultValue;
					if (defaultValue != DBNull.Value)
					{
						object default_value;
						if (defaultValue == Missing.Value)
						{
							default_value = ((!InternalType.Object.Equals(t)) ? new option<TExpr>.Some(new TExpr.DefaultValue(t)) : new option<TExpr>.Some(new TExpr.StaticRef(t, InternalType.Reflection_Missing, InternalType.Reflection_Missing.tycon.LookupMember("Value").Head, list<TypeVar>.Nil._N_constant_object)));
						}
						else
						{
							Literal val = Literal.FromObject(defaultValue);
							default_value = new option<TExpr>.Some(new TExpr.Literal(t, val));
						}
						tParameter.default_value = (option<TExpr>)default_value;
					}
					list = new list<TParameter>.Cons(tParameter, list);
				}
				fun_header = new TFunHeader(library._location, Name, ret_type, library._location, list, typarms, null);
				attributes = NemerleModifiers.None;
				if (handle.IsAbstract)
				{
					attributes |= NemerleModifiers.Abstract;
				}
				if (handle.IsVirtual)
				{
					attributes |= NemerleModifiers.Virtual;
				}
				if (handle.IsFinal)
				{
					attributes |= NemerleModifiers.Sealed;
				}
				if (handle.IsStatic)
				{
					attributes |= NemerleModifiers.Static;
				}
				if (handle.IsSpecialName)
				{
					attributes |= NemerleModifiers.SpecialName;
				}
				if (handle.IsPrivate)
				{
					attributes |= NemerleModifiers.Private;
				}
				if (handle.IsPublic)
				{
					attributes |= NemerleModifiers.Public;
				}
				if (handle.IsAssembly || (handle.IsFamilyOrAssembly && lib.IsFriend))
				{
					attributes |= NemerleModifiers.Internal;
				}
				if (handle.IsFamily || handle.IsFamilyOrAssembly)
				{
					attributes |= NemerleModifiers.Protected;
				}
				if (InternalType.Conditional_tc != null)
				{
					_isConditional = HasAttribute(InternalType.Conditional_tc);
				}
			}
		}

		public FixedType.Fun GetMemType()
		{
			return FixedType.ConstructFunctionType(GetHeader());
		}

		public Nemerle.Builtins.Tuple<FixedType, list<TypeVar>> GetFreshType()
		{
			Nemerle.Builtins.Tuple<FixedType, list<TypeVar>> result;
			if (fun_header.TypeParameters.IsEmpty)
			{
				result = new Nemerle.Builtins.Tuple<FixedType, list<TypeVar>>(GetMemType(), list<TypeVar>.Nil._N_constant_object);
			}
			else
			{
				Nemerle.Builtins.Tuple<Subst, list<TypeVar>> tuple = Subst.Fresh(fun_header.TypeParameters);
				Subst field = tuple.Field0;
				list<TypeVar> field2 = tuple.Field1;
				result = new Nemerle.Builtins.Tuple<FixedType, list<TypeVar>>(field.MonoApply(GetMemType()), field2);
			}
			return result;
		}

		public override list<string> GetConditions()
		{
			if (!_N_is_cached_18548)
			{
				Attribute[] customAttributes = Attribute.GetCustomAttributes(GetHandle(), InternalType.Conditional_tc.SystemType, inherit: true);
				Function<Attribute, string> instance = _N__N_lambda__57304__57316.Instance;
				_N_cached_value_18547 = NList.MapFromArray(customAttributes, instance);
				_N_is_cached_18548 = true;
			}
			return _N_cached_value_18547;
		}

		public MethodBase GetMethodBase()
		{
			return handle;
		}

		public override string ToString()
		{
			return MemberBuilder.DescribeMember(this);
		}

		public override System.Reflection.MemberInfo GetHandle()
		{
			return handle;
		}

		public ConstructorInfo GetConstructorInfo()
		{
			if (!IsConstructor)
			{
				throw new AssertionException("ncc\\external\\ExternalMemberInfo\\ExternalMethodInfo.n", 203, "IsConstructor", "");
			}
			return (ConstructorInfo)handle;
		}

		public MethodInfo GetMethodInfo()
		{
			if (IsConstructor)
			{
				throw new AssertionException("ncc\\external\\ExternalMemberInfo\\ExternalMethodInfo.n", 209, "!IsConstructor", "");
			}
			return (MethodInfo)handle;
		}

		public TFunHeader GetHeader()
		{
			return fun_header;
		}

		public list<TParameter> GetParameters()
		{
			return fun_header.Parameters;
		}

		public bool CanAccess(TypeInfo source)
		{
			return handle.IsPublic || (source.IsDerivedFrom(DeclaringType) && (handle.IsFamily || handle.IsFamilyOrAssembly)) || (library.IsFriend && (handle.IsFamilyOrAssembly || handle.IsAssembly));
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				fun_header?.RelocateImplInternal(_info);
			}
		}

		private static AttributesAndModifiers _N_getCustomAttribute_57182(ParameterInfo parameter, LibraryReference library)
		{
			IList<CustomAttributeData> customAttributes = CustomAttributeData.GetCustomAttributes(parameter);
			list<Nemerle.Builtins.Tuple<PExpr, list<PExpr>>> list = ConvertCustomAttributesData(customAttributes, library);
			Function<PExpr, list<PExpr>, PExpr> instance = _N__N_lambda__57094__57187.Instance;
			list<PExpr> custom_attrs = list.Map(instance);
			return new AttributesAndModifiers(NemerleModifiers.None, custom_attrs);
		}

		[SpecialName]
		FixedType IMember.GetMemType()
		{
			return GetMemType();
		}
	}

	public class ExternalPropertyInfo : ExternalMemberInfo, IMember, IProperty
	{
		protected readonly PropertyInfo handle;

		protected readonly ExternalMethodInfo getter;

		protected readonly ExternalMethodInfo setter;

		protected readonly ExternalMethodInfo any_method;

		protected readonly FixedType mem_type;

		public TypeInfo DeclaringType => library.TypeInfoOfType(handle.DeclaringType);

		public string Name => handle.Name;

		public MemberTypes MemberKind => MemberTypes.Property;

		public bool IsMutable => handle.CanWrite;

		public bool IsIndexer
		{
			get
			{
				ParameterInfo[] indexParameters = handle.GetIndexParameters();
				return indexParameters.Length > 0;
			}
		}

		public PropertyInfo Handle
		{
			[DebuggerStepThrough]
			[CompilerGenerated]
			get
			{
				return handle;
			}
		}

		public ExternalMethodInfo Getter
		{
			[CompilerGenerated]
			[DebuggerStepThrough]
			get
			{
				return getter;
			}
		}

		public ExternalMethodInfo Setter
		{
			[DebuggerStepThrough]
			[CompilerGenerated]
			get
			{
				return setter;
			}
		}

		[SpecialName]
		public override bool IsCustomAttributeDefined(string attributeFullName)
		{
			return base.IsCustomAttributeDefined(attributeFullName);
		}

		[SpecialName]
		public override AttributesAndModifiers GetModifiers()
		{
			return base.GetModifiers();
		}

		[SpecialName]
		public virtual NemerleModifiers get_Attributes()
		{
			return base.Attributes;
		}

		[SpecialName]
		public override list<string> GetConditions()
		{
			return base.GetConditions();
		}

		[SpecialName]
		public override bool get_IsConditional()
		{
			return base.IsConditional;
		}

		[SpecialName]
		public override void set_HasBeenUsed(bool value)
		{
			base.HasBeenUsed = value;
		}

		[SpecialName]
		public override bool get_HasBeenUsed()
		{
			return base.HasBeenUsed;
		}

		[SpecialName]
		public override bool get_IsStatic()
		{
			return base.IsStatic;
		}

		[SpecialName]
		public override Location get_NameLocation()
		{
			return base.NameLocation;
		}

		[SpecialName]
		public virtual bool get_IsPrivate()
		{
			return base.IsPrivate;
		}

		[SpecialName]
		public virtual bool get_IsObsolete()
		{
			return base.IsObsolete;
		}

		[SpecialName]
		public new virtual bool CanAccess(TypeInfo memberTypeInfo, TypeInfo currentTypeInfo, bool isThisAccess)
		{
			return base.CanAccess(memberTypeInfo, currentTypeInfo, isThisAccess);
		}

		[SpecialName]
		public virtual Location get_Location()
		{
			return base.Location;
		}

		[SpecialName]
		public override bool get_IsConstructor()
		{
			return base.IsConstructor;
		}

		public ExternalPropertyInfo(Map<string, StaticTypeVar> tenv, LibraryReference lib, PropertyInfo h)
		{
			handle = h;
			base._002Ector(lib);
			MethodInfo getMethod = handle.GetGetMethod(nonPublic: true);
			MethodInfo setMethod = handle.GetSetMethod(nonPublic: true);
			getter = library.MethodOfMethodInfo(tenv, getMethod);
			setter = library.MethodOfMethodInfo(tenv, setMethod);
			if (getter == null)
			{
				any_method = setter;
			}
			else
			{
				any_method = getter;
			}
			if (any_method == null)
			{
				throw new AssertionException("ncc\\external\\ExternalMemberInfo\\ExternalPropertyInfo.n", 75, "any_method != null", "");
			}
			FixedType field = library.TypeOfType(tenv, handle.PropertyType);
			Nemerle.Builtins.Tuple<list<FixedType>, FixedType> tuple;
			Nemerle.Builtins.Tuple<list<FixedType>, FixedType> tuple2;
			list<FixedType> field2;
			if (getter != null)
			{
				FixedType.Fun memType = getter.GetMemType();
				TypeVar from = memType.from;
				TypeVar to = memType.to;
				tuple = new Nemerle.Builtins.Tuple<list<FixedType>, FixedType>(from.FixedValue.GetFunctionArguments(), to.FixedValue);
			}
			else if (setter != null)
			{
				FixedType.Fun memType = setter.GetMemType();
				TypeVar from = memType.from;
				tuple2 = NList.DivideLast(from.FixedValue.GetFunctionArguments());
				field2 = tuple2.Field0;
				field = tuple2.Field1;
				tuple = new Nemerle.Builtins.Tuple<list<FixedType>, FixedType>(field2, field);
			}
			else
			{
				tuple = new Nemerle.Builtins.Tuple<list<FixedType>, FixedType>(list<FixedType>.Nil._N_constant_object, field);
			}
			tuple2 = tuple;
			field2 = tuple2.Field0;
			field = tuple2.Field1;
			if (field2.IsEmpty)
			{
				mem_type = field;
			}
			else
			{
				mem_type = FixedType.ConstructFunctionType(field2, field);
			}
			attributes = any_method.Attributes;
		}

		public IMethod GetGetter()
		{
			return getter;
		}

		public IMethod GetSetter()
		{
			return setter;
		}

		public PropertyInfo GetPropertyInfo()
		{
			return handle;
		}

		public FixedType GetMemType()
		{
			return mem_type;
		}

		public bool CanAccess(TypeInfo source)
		{
			return any_method.CanAccess(source);
		}

		public override System.Reflection.MemberInfo GetHandle()
		{
			return handle;
		}

		public override string ToString()
		{
			return MemberBuilder.DescribeMember(this);
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				any_method?.RelocateImplInternal(_info);
				setter?.RelocateImplInternal(_info);
				getter?.RelocateImplInternal(_info);
			}
		}
	}

	public class ExternalTypeInfo : TypeInfo
	{
		private sealed class _N__N_lambda__58809__58855 : Function<StaticTypeVar, TypeVar>
		{
			[SpecialName]
			public static readonly _N__N_lambda__58809__58855 Instance = new _N__N_lambda__58809__58855();

			[SpecialName]
			public sealed override TypeVar apply(StaticTypeVar _N__58808)
			{
				return new FixedType.StaticTypeVarRef(_N__58808);
			}
		}

		private sealed class _N__N_lambda__59125__59137 : Function<PExpr, list<PExpr>, PExpr>
		{
			[SpecialName]
			public static readonly _N__N_lambda__59125__59137 Instance = new _N__N_lambda__59125__59137();

			[SpecialName]
			public sealed override PExpr apply(PExpr name, list<PExpr> args)
			{
				return new PExpr.Call(Macros.QuotationChoose(name), Macros.QuotationChoose(args));
			}
		}

		private sealed class _N_closureOf_GetMembers_59306
		{
			internal System.Reflection.BindingFlags _N_bindingAttr_59313;

			internal ExternalTypeInfo _N__N_closurised_this_ptr_59311;

			internal _N_closureOf_GetMembers_59306()
			{
			}
		}

		private sealed class _N_check__59315 : Function<IMember, bool>
		{
			[SpecialName]
			private _N_closureOf_GetMembers_59306 _N_GetMembers_closure_59319;

			public _N_check__59315(_N_closureOf_GetMembers_59306 _N_GetMembers_closure_59319)
			{
				this._N_GetMembers_closure_59319 = _N_GetMembers_closure_59319;
			}

			[SpecialName]
			public sealed override bool apply(IMember x)
			{
				return ((_N_GetMembers_closure_59319._N_bindingAttr_59313 & System.Reflection.BindingFlags.DeclaredOnly) == 0) ? TypeInfo.constrain_member(x, _N_GetMembers_closure_59319._N_bindingAttr_59313) : (_N_GetMembers_closure_59319._N__N_closurised_this_ptr_59311.Equals(x.DeclaringType) && TypeInfo.constrain_member(x, _N_GetMembers_closure_59319._N_bindingAttr_59313));
			}
		}

		private sealed class _N_closureOf_constrain_with_membertype_59339<MT> where MT : IMember
		{
			internal MemberTypes _N_memType_59344;

			internal _N_closureOf_constrain_with_membertype_59339()
			{
			}
		}

		private sealed class _N__N_lambda__59332__59346<MT> : Function<IMember, list<MT>, list<MT>> where MT : IMember
		{
			[SpecialName]
			private _N_closureOf_constrain_with_membertype_59339<MT> _N_constrain_with_membertype_closure_59350;

			public _N__N_lambda__59332__59346(_N_closureOf_constrain_with_membertype_59339<MT> _N_constrain_with_membertype_closure_59350)
			{
				this._N_constrain_with_membertype_closure_59350 = _N_constrain_with_membertype_closure_59350;
			}

			[SpecialName]
			public sealed override list<MT> apply(IMember x, list<MT> acc)
			{
				return (x.MemberKind != _N_constrain_with_membertype_closure_59350._N_memType_59344) ? acc : new list<MT>.Cons((MT)x, acc);
			}
		}

		private sealed class _N__N_lambda__59373__59407 : Function<MethodInfo, MethodInfo, MethodInfo>
		{
			[SpecialName]
			public static readonly _N__N_lambda__59373__59407 Instance = new _N__N_lambda__59373__59407();

			[SpecialName]
			public sealed override MethodInfo apply(MethodInfo x, MethodInfo acc)
			{
				return (!(x == null) && !x.IsPrivate && !x.IsAssembly && !x.IsFamilyAndAssembly) ? x : acc;
			}
		}

		private sealed class _N__N_lambda__59476__59506 : Function<FixedType.Class, list<IMember>>
		{
			[SpecialName]
			public static readonly _N__N_lambda__59476__59506 Instance = new _N__N_lambda__59476__59506();

			[SpecialName]
			public sealed override list<IMember> apply(FixedType.Class t)
			{
				return t.tycon.GetMembers();
			}
		}

		private sealed class _N__N_lambda__59628__59640 : Function<Attribute, string>
		{
			[SpecialName]
			public static readonly _N__N_lambda__59628__59640 Instance = new _N__N_lambda__59628__59640();

			[SpecialName]
			public sealed override string apply(Attribute attr)
			{
				return (string)attr.GetType().InvokeMember("ConditionString", System.Reflection.BindingFlags.GetField | System.Reflection.BindingFlags.GetProperty, null, attr, null, null, null, null);
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[IgnoreField]
		[IgnoreField]
		private bool _N_is_cached_18568;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[IgnoreField]
		[IgnoreField]
		private list<string> _N_cached_value_18567;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[IgnoreField]
		[IgnoreField]
		private bool _N_is_cached_18563;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[IgnoreField]
		[IgnoreField]
		private AttributesAndModifiers _N_cached_value_18562;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[IgnoreField]
		[IgnoreField]
		private bool _N_is_cached_18558;

		[IgnoreField]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[IgnoreField]
		private option<TypeInfo> _N_cached_value_18557;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[IgnoreField]
		[IgnoreField]
		private bool _N_is_cached_18553;

		[IgnoreField]
		[IgnoreField]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _N_cached_value_18552;

		protected readonly LibraryReference library;

		internal readonly Map<string, StaticTypeVar> tenv = new Map<string, StaticTypeVar>();

		protected list<FixedType.Class> direct_supertypes;

		private bool _isDirectSupertypesNormalized;

		internal static readonly Hashtable<string, NumericKind> numeric_types;

		private readonly int _declaredTypeParametersCount;

		private readonly bool _isConditional;

		public override bool IsPointer
		{
			get
			{
				bool n_cached_value_ = false;
				if (!_N_is_cached_18553)
				{
					Type systemType = SystemType;
					if (systemType != null)
					{
						n_cached_value_ = systemType.IsPointer;
					}
					_N_cached_value_18552 = n_cached_value_;
					_N_is_cached_18553 = true;
				}
				return _N_cached_value_18552;
			}
		}

		public override int TyparmsCount { get; }

		public override int DeclaredTypeParametersCount => _declaredTypeParametersCount;

		public override bool IsValueType => system_type.IsValueType;

		public override bool IsInterface => system_type.IsInterface;

		public override string Name => Util.StripGenericMark(system_type.Name);

		public override bool IsDelegate => system_type.IsSubclassOf(SystemTypeCache.MulticastDelegate);

		public override TypeInfo DeclaringType => (!(system_type.DeclaringType == null)) ? library.TypeInfoOfType(system_type.DeclaringType) : null;

		public override Location Location => library._location;

		public override AttributeTargets AttributeTargets
		{
			get
			{
				object[] customAttributes = system_type.GetCustomAttributes(typeof(AttributeUsageAttribute), inherit: false);
				int result;
				if (customAttributes.Length > 0)
				{
					if (customAttributes.Length != 1)
					{
						throw new AssertionException("ncc\\external\\ExternalTypeInfo\\ExternalTypeInfo.n", 501, "usage.Length == 1", "");
					}
					result = (int)((AttributeUsageAttribute)customAttributes[0]).ValidOn;
				}
				else
				{
					result = 32767;
				}
				return (AttributeTargets)result;
			}
		}

		public override Accessibility Accessibility
		{
			get
			{
				int result;
				switch (system_type.Attributes & TypeAttributes.VisibilityMask)
				{
				default:
					if (!Message.SeenError)
					{
						string text = "system type returned invalid attributes".ToString();
						Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
					}
					throw new AssertionException("ncc\\external\\ExternalTypeInfo\\ExternalTypeInfo.n", 528, "", "system type returned invalid attributes");
				case TypeAttributes.Public:
				case TypeAttributes.NestedPublic:
					result = 0;
					break;
				case TypeAttributes.NotPublic:
				case TypeAttributes.NestedPrivate:
					result = 1;
					break;
				case TypeAttributes.NestedFamily:
					result = 4;
					break;
				case TypeAttributes.NestedAssembly:
					result = 1;
					break;
				case TypeAttributes.NestedFamANDAssem:
					result = 3;
					break;
				case TypeAttributes.VisibilityMask:
					result = 2;
					break;
				}
				return (Accessibility)result;
			}
		}

		public override bool IsExternallyAccessible => true;

		public override TypeInfo BaseType => (!(system_type.BaseType == null)) ? library.TypeInfoOfType(system_type.BaseType) : null;

		public override TypeInfo UnderlyingType
		{
			get
			{
				if (!system_type.IsEnum)
				{
					throw new AssertionException("ncc\\external\\ExternalTypeInfo\\ExternalTypeInfo.n", 763, "system_type.IsEnum", "");
				}
				return library.TypeInfoOfType(system_type.GetField("value__").FieldType);
			}
		}

		public override GlobalEnv GlobalEnv => library.Manager.CoreEnv;

		public override bool IsConditional => _isConditional;

		public ExternalTypeInfo(LibraryReference lib, Type h, NamespaceTree.Node ns_node)
			: base(ns_node, lib.Manager, Util.StripGenericMark(h.TypeFullName().Replace('+', '.').TrimStart('.')))
		{
			_N_TyparmsCount_11202 = h.GetGenericArguments().Length;
			LibraryReferenceManager.CacheTypeInfo(h, this, ns_node);
			library = lib;
			system_type = h;
			if (system_type.IsGenericType && !system_type.IsGenericTypeDefinition)
			{
				system_type = system_type.GetGenericTypeDefinition();
			}
			if (system_type.DeclaringType != null)
			{
				tenv = ((ExternalTypeInfo)lib.TypeInfoOfType(system_type.DeclaringType)).tenv;
			}
			Nemerle.Builtins.Tuple<list<StaticTypeVar>, Map<string, StaticTypeVar>, list<FixedType.Class>, list<FixedType.Class>> tuple = TyCodec.ReflectTypeBuilder(library, tenv, system_type);
			list<StaticTypeVar> list = tuple.Field0;
			Map<string, StaticTypeVar> map = tuple.Field1;
			list<FixedType.Class> list2 = tuple.Field2;
			list<FixedType.Class> superTypes = tuple.Field3;
			typarms = list;
			tenv = map;
			direct_supertypes = list2;
			_superTypes = superTypes;
			if (h.Namespace == "Nemerle.Builtins" && h.Name.StartsWith("Array"))
			{
				direct_supertypes = new list<FixedType.Class>.Cons(InternalType.Array, list<FixedType.Class>.Nil._N_constant_object);
				_superTypes = new list<FixedType.Class>.Cons(InternalType.Array, _superTypes);
			}
			superTypes = _superTypes;
			while (superTypes is list<FixedType.Class>.Cons)
			{
				FixedType.Class hd = ((list<FixedType.Class>.Cons)superTypes).hd;
				superTypes = ((list<FixedType.Class>.Cons)superTypes).tl;
				hd = hd;
				_superTypesLookup.Add(hd, 0);
				if (_superTypeInfosLookup.Contains(hd.tycon))
				{
					_superTypeInfosLookup[hd.tycon] = new list<FixedType.Class>.Cons(hd, _superTypeInfosLookup[hd.tycon]);
				}
				else
				{
					_superTypeInfosLookup[hd.tycon] = new list<FixedType.Class>.Cons(hd, list<FixedType.Class>.Nil._N_constant_object);
				}
				superTypes = superTypes;
			}
			list<StaticTypeVar> list3 = typarms;
			Function<StaticTypeVar, TypeVar> instance = _N__N_lambda__58809__58855.Instance;
			list<TypeVar> args = list3.Map(instance);
			self_type = new FixedType.Class(this, args);
			_superTypeInfosLookup[this] = new list<FixedType.Class>.Cons(GetMemType(), list<FixedType.Class>.Nil._N_constant_object);
			_superTypesCalculated = true;
			TyCodec.ReflectConstraints(library, tenv, system_type, self_type, typarms);
			attributes = NemerleModifiers.None;
			if (system_type.IsAbstract)
			{
				attributes |= NemerleModifiers.Abstract;
			}
			if (system_type.IsSealed)
			{
				attributes |= NemerleModifiers.Sealed;
			}
			if (system_type.IsValueType)
			{
				attributes |= NemerleModifiers.Struct;
			}
			if (system_type.IsSpecialName)
			{
				attributes |= NemerleModifiers.SpecialName;
			}
			if (system_type.DeclaringType == null)
			{
				if (system_type.IsPublic)
				{
					attributes |= NemerleModifiers.Public;
				}
				else
				{
					attributes |= NemerleModifiers.Internal;
				}
			}
			else
			{
				if (system_type.IsNestedPrivate)
				{
					attributes |= NemerleModifiers.Private;
				}
				if (system_type.IsNestedPublic)
				{
					attributes |= NemerleModifiers.Public;
				}
				if (system_type.IsNestedFamily)
				{
					attributes |= NemerleModifiers.Protected;
				}
				if (system_type.IsNestedAssembly)
				{
					attributes |= NemerleModifiers.Internal;
				}
			}
			object[] customAttributes = system_type.GetCustomAttributes(SystemTypeCache.Reflection_DefaultMemberAttribute, inherit: true);
			object obj;
			if (customAttributes.Length > 0)
			{
				DefaultMemberAttribute defaultMemberAttribute = (DefaultMemberAttribute)customAttributes[0];
				obj = defaultMemberAttribute.MemberName;
			}
			else
			{
				obj = null;
			}
			default_indexer = (string)obj;
			if (lib.LibRefManager.add_buildins)
			{
				AddBuiltins();
			}
			decode_extension_methods(lib.LibRefManager);
			if (InternalType.Obsolete_tc != null)
			{
				is_obsolete = HasAttribute(InternalType.Obsolete_tc);
			}
			_declaredTypeParametersCount = system_type.GetGenericArguments().Length;
			if (InternalType.Conditional_tc != null)
			{
				_isConditional = HasAttribute(InternalType.Conditional_tc);
			}
		}

		public override option<TypeInfo> GetElementTypeInfo()
		{
			if (!_N_is_cached_18558)
			{
				_N_cached_value_18557 = ((!IsPointer) ? ((option<TypeInfo>)option<TypeInfo>.None._N_constant_object) : ((option<TypeInfo>)new option<TypeInfo>.Some(library.TypeInfoOfType(SystemType.GetElementType()))));
				_N_is_cached_18558 = true;
			}
			return _N_cached_value_18557;
		}

		static ExternalTypeInfo()
		{
			numeric_types = new Hashtable<string, NumericKind>();
			numeric_types.Add("SByte", NumericKind.Signed);
			numeric_types.Add("Int16", NumericKind.Signed);
			numeric_types.Add("Int32", NumericKind.Signed);
			numeric_types.Add("Int64", NumericKind.Signed);
			numeric_types.Add("Byte", NumericKind.Unsigned);
			numeric_types.Add("UInt16", NumericKind.Unsigned);
			numeric_types.Add("UInt32", NumericKind.Unsigned);
			numeric_types.Add("UInt64", NumericKind.Unsigned);
			numeric_types.Add("Single", NumericKind.Float);
			numeric_types.Add("Double", NumericKind.Float);
			numeric_types.Add("Char", NumericKind.Char);
		}

		private void FixupEquality(string name)
		{
			FixupCompare(name);
		}

		private void FixupShift(string name)
		{
			list<IMember> list = special_members[name];
			if (list is list<IMember>.Cons && ((list<IMember>.Cons)list).hd is IMethod)
			{
				IMethod method = (IMethod)((list<IMember>.Cons)list).hd;
				if ((object)((list<IMember>.Cons)list).tl == list<IMember>.Nil._N_constant_object)
				{
					list<TParameter> parameters = method.GetParameters();
					if (parameters is list<TParameter>.Cons && ((list<TParameter>.Cons)parameters).tl is list<TParameter>.Cons && (object)((list<TParameter>.Cons)((list<TParameter>.Cons)parameters).tl).tl == list<TParameter>.Nil._N_constant_object)
					{
						TParameter hd = ((list<TParameter>.Cons)((list<TParameter>.Cons)parameters).tl).hd;
						if (InternalType.Int32 == null)
						{
							throw new AssertionException("ncc\\external\\ExternalTypeInfo\\ExternalTypeInfo.n", 224, "InternalType.Int32 != null", "");
						}
						hd.ty = InternalType.Int32;
						return;
					}
					throw new AssertionException("ncc\\external\\ExternalTypeInfo\\ExternalTypeInfo.n", 227, "", "");
				}
			}
			throw new AssertionException("ncc\\external\\ExternalTypeInfo\\ExternalTypeInfo.n", 230, "", "");
		}

		internal void AddBuiltins()
		{
			InitBuiltinMembers();
			if (system_type.IsPointer)
			{
				AddConversion("op_Implicit", InternalType.IntPtr_tc);
				AddConversion("op_Explicit", InternalType.IntPtr_tc, reverse: true);
				AddBuiltin("op_Addition", GetMemType(), InternalType.Int32, GetMemType(), "+.p");
				AddBuiltin("op_Subtraction", GetMemType(), InternalType.Int32, GetMemType(), "-.p");
				AddBuiltin("op_Subtraction", GetMemType(), GetMemType(), InternalType.Int32, "-.p");
				AddBuiltin("op_Increment", "++.p");
				MakeSingleParm("op_Increment");
				AddBuiltin("op_Decrement", "--.p");
				MakeSingleParm("op_Decrement");
			}
			if (system_type.Name == "Nullable`1")
			{
				FixedType.Class boolean = library.InternalType.Boolean;
				AddBuiltin("op_Equality", boolean, "==");
				AddBuiltin("op_Inequality", boolean, "!=");
				AddBuiltin("op_LessThan", boolean, "<");
				AddBuiltin("op_LessThanOrEqual", boolean, "<=");
				AddBuiltin("op_GreaterThan", boolean, ">");
				AddBuiltin("op_GreaterThanOrEqual", boolean, ">=");
			}
			if (!system_type.IsPrimitive && !system_type.Equals(SystemTypeCache.Object) && !system_type.Equals(SystemTypeCache.String))
			{
				return;
			}
			string name = system_type.Name;
			switch (name)
			{
			case "Boolean":
				AddBuiltin("op_LogicalNot", "bool.!");
				MakeSingleParm("op_LogicalNot");
				AddBuiltin("op_Equality", "==");
				AddBuiltin("op_Inequality", "!=");
				AddBuiltin("op_BitwiseAnd", "&");
				AddBuiltin("op_BitwiseOr", "|");
				AddBuiltin("op_ExclusiveOr", "^");
				return;
			case "Object":
				AddBuiltin("op_Equality", "==.ref");
				AddBuiltin("op_Inequality", "!=.ref");
				FixupEquality("op_Equality");
				FixupEquality("op_Inequality");
				return;
			}
			if (!numeric_types.Contains(name))
			{
				return;
			}
			NumericKind numericKind = numeric_types[name];
			object obj;
			switch (numericKind)
			{
			default:
				throw new MatchFailureException();
			case NumericKind.Unsigned:
				obj = ".u";
				break;
			case NumericKind.Float:
				obj = ".f";
				break;
			case NumericKind.Signed:
			case NumericKind.Char:
				obj = ".s";
				break;
			}
			string text = (string)obj;
			bool flag = name == "SByte" || name == "Byte" || name == "Int16" || name == "UInt16";
			if (numericKind != NumericKind.Char)
			{
				AddBuiltin("op_Addition", "+" + text, "+.f");
				AddBuiltin("op_Subtraction", "-" + text, "-.f");
				AddBuiltin("op_Multiply", "*" + text, "*.f");
				AddBuiltin("op_Division", "/" + text);
				AddBuiltin("op_Modulus", "%" + text);
				AddBuiltin("op_UnaryPlus", "unary.+" + text);
				MakeSingleParm("op_UnaryPlus");
				if (flag)
				{
					TypeInfo.ForceIntType("op_Addition");
					TypeInfo.ForceIntType("op_Subtraction");
					TypeInfo.ForceIntType("op_Multiply");
					TypeInfo.ForceIntType("op_Division");
					TypeInfo.ForceIntType("op_Modulus");
					TypeInfo.ForceIntType("op_UnaryPlus");
				}
			}
			object obj2;
			switch (name)
			{
			case "Int64":
			case "UInt64":
				obj2 = "i8";
				break;
			case "Float":
				obj2 = "r4";
				break;
			case "Double":
				obj2 = "r8";
				break;
			default:
				obj2 = "i4";
				break;
			}
			string text2 = (string)obj2;
			name = name switch
			{
				"Byte" => ".u.i1", 
				"SByte" => ".s.i1", 
				"Int16" => ".s.i2", 
				"UInt16" => ".u.i2", 
				_ => text, 
			};
			AddBuiltin("op_Increment", string.Concat("++." + text2, name), string.Concat("++." + text2, ".f"));
			AddBuiltin("op_Decrement", string.Concat("--." + text2, name), string.Concat("--." + text2, ".f"));
			MakeSingleParm("op_Increment");
			MakeSingleParm("op_Decrement");
			if (numericKind == NumericKind.Signed || numericKind == NumericKind.Unsigned)
			{
				AddBuiltin("op_BitwiseAnd", "&" + text);
				AddBuiltin("op_BitwiseOr", "|" + text);
				AddBuiltin("op_ExclusiveOr", "^" + text);
				AddBuiltin("op_LeftShift", "<<" + text);
				AddBuiltin("op_RightShift", ">>" + text);
				if (Name != "Int32")
				{
					FixupShift("op_LeftShift");
					FixupShift("op_RightShift");
				}
				if (flag)
				{
					TypeInfo.ForceIntType("op_LeftShift");
					TypeInfo.ForceIntType("op_RightShift");
					TypeInfo.ForceIntType("op_BitwiseAnd");
					TypeInfo.ForceIntType("op_BitwiseOr");
					TypeInfo.ForceIntType("op_ExclusiveOr");
				}
				AddBuiltin("op_OnesComplement", "unary.~" + text);
				MakeSingleParm("op_OnesComplement");
				if (flag)
				{
					TypeInfo.ForceIntType("op_OnesComplement");
				}
			}
			if (numericKind != NumericKind.Unsigned && numericKind != NumericKind.Char)
			{
				AddBuiltin("op_UnaryNegation", "unary.-" + text, "unary.-.f");
				MakeSingleParm("op_UnaryNegation");
				if (flag)
				{
					TypeInfo.ForceIntType("op_UnaryNegation");
				}
			}
			AddBuiltin("op_Equality", "==");
			AddBuiltin("op_Inequality", "!=");
			AddBuiltin("op_LessThan", "<" + text);
			AddBuiltin("op_LessThanOrEqual", "<=" + text);
			AddBuiltin("op_GreaterThan", ">" + text);
			AddBuiltin("op_GreaterThanOrEqual", ">=" + text);
			FixupCompare("op_Equality");
			FixupCompare("op_Inequality");
			FixupCompare("op_LessThan");
			FixupCompare("op_LessThanOrEqual");
			FixupCompare("op_GreaterThan");
			FixupCompare("op_GreaterThanOrEqual");
		}

		internal override LibraryReference GetLibraryReference()
		{
			return library;
		}

		public override IField GetConstantObject()
		{
			return null;
		}

		public override AttributesAndModifiers GetModifiers()
		{
			if (!_N_is_cached_18563)
			{
				IList<CustomAttributeData> customAttributes = CustomAttributeData.GetCustomAttributes(system_type);
				list<Nemerle.Builtins.Tuple<PExpr, list<PExpr>>> list = ConvertCustomAttributesData(customAttributes, library);
				Function<PExpr, list<PExpr>, PExpr> instance = _N__N_lambda__59125__59137.Instance;
				_N_cached_value_18562 = new AttributesAndModifiers(custom_attrs: list.Map(instance), mods: Attributes);
				_N_is_cached_18563 = true;
			}
			return _N_cached_value_18562;
		}

		public override bool IsCustomAttributeDefined(string attributeFullName)
		{
			return GetHandle().IsDefined(library.Manager.LookupSystemType(attributeFullName), inherit: false);
		}

		public override bool HasAttribute(TypeInfo attribute)
		{
			Type systemType = attribute.SystemType;
			return system_type.IsDefined(systemType, inherit: false);
		}

		public override TypeDeclaration GetTydecl()
		{
			return system_type.IsInterface ? TypeDeclaration.Interface._N_constant_object : ((!system_type.IsEnum) ? ((TypeDeclaration)TypeDeclaration.Class._N_constant_object) : ((TypeDeclaration)TypeDeclaration.Enum._N_constant_object));
		}

		public override list<FixedType.Class> GetDirectSuperTypes()
		{
			list<FixedType.Class> result;
			if (_isDirectSupertypesNormalized)
			{
				result = direct_supertypes;
			}
			else
			{
				list<FixedType.Class> list = direct_supertypes;
				if (list is list<FixedType.Class>.Cons && ((list<FixedType.Class>.Cons)list).tl is list<FixedType.Class>.Cons)
				{
					direct_supertypes = TypeInfo.NormalizeSupertypes(direct_supertypes);
				}
				_isDirectSupertypesNormalized = true;
				result = direct_supertypes;
			}
			return result;
		}

		public override option<TypeInfo> SuperClass()
		{
			list<FixedType.Class> list = direct_supertypes;
			object result;
			if (list is list<FixedType.Class>.Cons)
			{
				TypeInfo tycon = ((list<FixedType.Class>.Cons)list).hd.tycon;
				result = new option<TypeInfo>.Some(tycon);
			}
			else
			{
				if ((object)list != list<FixedType.Class>.Nil._N_constant_object)
				{
					if (!Message.SeenError)
					{
						string text = "(see backtrace)".ToString();
						Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
					}
					throw new AssertionException("ncc\\external\\ExternalTypeInfo\\ExternalTypeInfo.n", 575, "", "(see backtrace)");
				}
				result = option<TypeInfo>.None._N_constant_object;
			}
			return (option<TypeInfo>)result;
		}

		public override list<IMember> GetMembers()
		{
			return LookupMemberImpl("");
		}

		public override list<IMember> GetMembers(System.Reflection.BindingFlags bindingAttr)
		{
			_N_closureOf_GetMembers_59306 n_closureOf_GetMembers_ = new _N_closureOf_GetMembers_59306();
			n_closureOf_GetMembers_._N_bindingAttr_59313 = bindingAttr;
			n_closureOf_GetMembers_._N__N_closurised_this_ptr_59311 = this;
			Function<IMember, bool> f = new _N_check__59315(n_closureOf_GetMembers_);
			return GetMembers().RevFilter(f);
		}

		private static Function<IMember, list<MT>, list<MT>> constrain_with_membertype<MT>(MemberTypes memType) where MT : IMember
		{
			_N_closureOf_constrain_with_membertype_59339<MT> n_closureOf_constrain_with_membertype_ = new _N_closureOf_constrain_with_membertype_59339<MT>();
			n_closureOf_constrain_with_membertype_._N_memType_59344 = memType;
			return new _N__N_lambda__59332__59346<MT>(n_closureOf_constrain_with_membertype_);
		}

		public override list<IField> GetFields(System.Reflection.BindingFlags bindingAttr)
		{
			return GetMembers(bindingAttr).FoldLeft(list<IField>.Nil._N_constant_object, constrain_with_membertype<IField>(MemberTypes.Field));
		}

		public override list<IMethod> GetConstructors(System.Reflection.BindingFlags bindingAttr)
		{
			return GetMembers(bindingAttr).FoldLeft(list<IMethod>.Nil._N_constant_object, constrain_with_membertype<IMethod>(MemberTypes.Constructor));
		}

		private static bool is_internal(System.Reflection.MemberInfo m)
		{
			MemberTypes memberType = m.MemberType;
			int result;
			if (((uint)memberType & ((true ? 1u : 0u) | 8u)) != 0)
			{
				MethodBase methodBase = (MethodBase)m;
				result = ((methodBase.IsPrivate || methodBase.IsAssembly || methodBase.IsFamilyAndAssembly || methodBase.CallingConvention == CallingConventions.VarArgs) ? 1 : 0);
			}
			else if ((memberType & MemberTypes.Field) != 0)
			{
				FieldInfo fieldInfo = (FieldInfo)m;
				result = ((fieldInfo.IsPrivate || fieldInfo.IsAssembly || fieldInfo.IsFamilyAndAssembly) ? 1 : 0);
			}
			else if ((memberType & MemberTypes.Property) != 0)
			{
				MethodInfo[] accessors = ((PropertyInfo)m).GetAccessors(nonPublic: true);
				Function<MethodInfo, MethodInfo, MethodInfo> instance = _N__N_lambda__59373__59407.Instance;
				MethodInfo methodInfo = accessors.Fold(null, instance);
				result = ((methodInfo == null) ? 1 : 0);
			}
			else if ((memberType & MemberTypes.NestedType) != 0)
			{
				Type type = (Type)m;
				result = ((type.IsNestedAssembly || type.IsNestedPrivate || type.IsNestedFamANDAssem) ? 1 : 0);
			}
			else if ((memberType & MemberTypes.Event) != 0)
			{
				MethodInfo methodInfo = ((EventInfo)m).GetAddMethod(nonPublic: true);
				result = ((methodInfo == null || methodInfo.IsPrivate || methodInfo.IsAssembly || methodInfo.IsFamilyAndAssembly) ? 1 : 0);
			}
			else
			{
				result = 1;
			}
			return (byte)result != 0;
		}

		protected IMember imember_of_memberinfo(System.Reflection.MemberInfo m)
		{
			object result;
			switch (m.MemberType)
			{
			case MemberTypes.Constructor:
			case MemberTypes.Method:
				result = (IMember)new ExternalMethodInfo(tenv, library, (MethodBase)m);
				break;
			case MemberTypes.Property:
				result = (IMember)new ExternalPropertyInfo(tenv, library, (PropertyInfo)m);
				break;
			case MemberTypes.NestedType:
				result = (IMember)library.TypeInfoOfType((Type)m);
				break;
			default:
				result = null;
				break;
			case MemberTypes.Event:
				result = (IMember)new ExternalEventInfo(library, (EventInfo)m);
				break;
			case MemberTypes.Field:
				result = (IMember)new ExternalFieldInfo(tenv, library, (FieldInfo)m);
				break;
			}
			return (IMember)result;
		}

		private void collect_members()
		{
			list<IMember> list = null;
			int num = 0;
			member_map = new Hashtable<string, list<IMember>>();
			System.Reflection.MemberInfo[] members = system_type.GetMembers(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.DeclaredOnly);
			list = list<IMember>.Nil._N_constant_object;
			checked
			{
				for (num = members.Length - 1; num >= 0; num--)
				{
					System.Reflection.MemberInfo m = members[num];
					if (!is_internal(m) || library.IsFriend)
					{
						IMember member = imember_of_memberinfo(m);
						if ((object)member != null)
						{
							member = member;
							list = new list<IMember>.Cons(member, list);
							add_member_by_name(member);
						}
					}
				}
				object obj2;
				if (IsInterface)
				{
					list<FixedType.Class> directSuperTypes = GetDirectSuperTypes();
					object obj;
					if (directSuperTypes.IsEmpty)
					{
						obj = new list<list<IMember>>.Cons(InternalType.Object_tc.GetMembers(), list<list<IMember>>.Nil._N_constant_object);
					}
					else
					{
						Function<FixedType.Class, list<IMember>> instance = _N__N_lambda__59476__59506.Instance;
						obj = directSuperTypes.Map(instance);
					}
					obj2 = (list<list<IMember>>)obj + new list<list<IMember>>.Cons(list, list<list<IMember>>.Nil._N_constant_object);
				}
				else
				{
					option<TypeInfo> option = SuperClass();
					if (option is option<TypeInfo>.Some)
					{
						TypeInfo val = ((option<TypeInfo>.Some)option).val;
						obj2 = new list<list<IMember>>.Cons(val.GetMembers(), new list<list<IMember>>.Cons(list, list<list<IMember>>.Nil._N_constant_object));
					}
					else
					{
						if (option != option<TypeInfo>.None._N_constant_object)
						{
							throw new MatchFailureException();
						}
						obj2 = new list<list<IMember>>.Cons(list, list<list<IMember>>.Nil._N_constant_object);
					}
				}
				list<list<IMember>> members2 = (list<list<IMember>>)obj2;
				list = RemoveHiddenMembers(members2);
				member_map[""] = list;
			}
		}

		public override list<IMember> LookupMemberImpl(string name)
		{
			object result;
			if (Equals(InternalType.String_tc) && name == "op_Addition")
			{
				if (InternalType.String_Concat == null)
				{
					throw new AssertionException("ncc\\external\\ExternalTypeInfo\\ExternalTypeInfo.n", 728, "InternalType.String_Concat != null", "");
				}
				AddBuiltin("op_Addition", InternalType.String_Concat);
				result = LookupMember(name);
			}
			else
			{
				if (member_map == null)
				{
					collect_members();
				}
				if (member_map.Contains(name))
				{
					result = member_map[name];
				}
				else
				{
					member_map[name] = list<IMember>.Nil._N_constant_object;
					result = list<IMember>.Nil._N_constant_object;
				}
			}
			return (list<IMember>)result;
		}

		public override bool CanAccess(TypeInfo source)
		{
			return system_type.IsPublic || system_type.IsNestedPublic || (system_type.DeclaringType != null && source.IsDerivedFrom(DeclaringType) && (system_type.IsNestedFamily || system_type.IsNestedFamORAssem)) || (library.IsFriend && (system_type.IsNotPublic || system_type.IsNestedAssembly || system_type.IsNestedPublic || system_type.IsNestedFamORAssem));
		}

		private void decode_extension_methods(LibraryReferenceManager mgr)
		{
			if (!mgr.IsExtension(system_type))
			{
				return;
			}
			list<IMember> list = GetMembers();
			while (list is list<IMember>.Cons)
			{
				IMember hd = ((list<IMember>.Cons)list).hd;
				list = ((list<IMember>.Cons)list).tl;
				if (hd is IMethod)
				{
					IMethod method = (IMethod)hd;
					if (method.IsStatic && mgr.IsExtension(method.GetHandle()))
					{
						mgr.AddExtensionMethod(method);
					}
				}
				list = list;
			}
		}

		internal override Nemerle.Builtins.Tuple<string, bool> GetObsoletionDetails()
		{
			Attribute customAttribute = Attribute.GetCustomAttribute(system_type, library.Manager.InternalType.Obsolete_tc.SystemType, inherit: false);
			if (customAttribute == null)
			{
				throw new AssertionException("ncc\\external\\ExternalTypeInfo\\ExternalTypeInfo.n", 782, "attr != null", "");
			}
			return new Nemerle.Builtins.Tuple<string, bool>((string)customAttribute.GetType().InvokeMember("Message", System.Reflection.BindingFlags.GetField | System.Reflection.BindingFlags.GetProperty, null, customAttribute, null, null, null, null), (bool)customAttribute.GetType().InvokeMember("IsError", System.Reflection.BindingFlags.GetField | System.Reflection.BindingFlags.GetProperty, null, customAttribute, null, null, null, null));
		}

		public override list<string> GetConditions()
		{
			if (!_N_is_cached_18568)
			{
				Attribute[] customAttributes = Attribute.GetCustomAttributes(system_type, InternalType.Conditional_tc.SystemType, inherit: true);
				Function<Attribute, string> instance = _N__N_lambda__59628__59640.Instance;
				_N_cached_value_18567 = NList.MapFromArray(customAttributes, instance);
				_N_is_cached_18568 = true;
			}
			return _N_cached_value_18567;
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
			list<FixedType.Class> list = direct_supertypes;
			if (list != null)
			{
				list = list;
				while (list is list<FixedType.Class>.Cons)
				{
					FixedType.Class hd = ((list<FixedType.Class>.Cons)list).hd;
					list = ((list<FixedType.Class>.Cons)list).tl;
					((ISupportRelocation)hd).RelocateImpl(_info);
					list = list;
				}
			}
			library?.RelocateImplInternal(_info);
		}
	}

	private class ExternalNemerleTypeInfo : ExternalTypeInfo
	{
		private sealed class _N_closureOf__ctor_59714
		{
			internal LibraryReference _N_lib_59721;

			internal ExternalNemerleTypeInfo _N__N_closurised_this_ptr_59719;

			internal _N_closureOf__ctor_59714()
			{
			}
		}

		private readonly TypeDeclaration tydecl;

		private readonly IField constant_object;

		public ExternalNemerleTypeInfo(LibraryReference lib, Type h, NamespaceTree.Node ns_node)
		{
			list<TypeInfo> list = null;
			int num = 0;
			_N_closureOf__ctor_59714 n_closureOf__ctor_ = new _N_closureOf__ctor_59714
			{
				_N_lib_59721 = lib
			};
			base._002Ector(n_closureOf__ctor_._N_lib_59721, h, ns_node);
			n_closureOf__ctor_._N__N_closurised_this_ptr_59719 = this;
			if (system_type.IsDefined(SystemTypeCache.VariantAttribute, inherit: false))
			{
				object obj = system_type.GetCustomAttributes(SystemTypeCache.VariantAttribute, inherit: false)[0];
				list<string> list2 = NString.Split((string)obj.GetType().InvokeMember("VariantOptions", System.Reflection.BindingFlags.GetField | System.Reflection.BindingFlags.GetProperty, null, obj, null, null, null, null), ',');
				list = list<TypeInfo>.Nil._N_constant_object;
				num = 0;
				list2 = list2;
				while (list2 is list<string>.Cons)
				{
					string hd = ((list<string>.Cons)list2).hd;
					list2 = ((list<string>.Cons)list2).tl;
					list = new list<TypeInfo>.Cons(_N_get_opt_59727(n_closureOf__ctor_, hd, num), list);
					num = checked(num + 1);
					list2 = list2;
				}
				tydecl = new TypeDeclaration.Variant(list.Rev());
			}
			else if (system_type.IsDefined(SystemTypeCache.VariantOptionAttribute, inherit: false))
			{
				tydecl = TypeDeclaration.VariantOption._N_constant_object;
			}
			else if (system_type.IsDefined(SystemTypeCache.ConstantVariantOptionAttribute, inherit: false))
			{
				tydecl = TypeDeclaration.VariantOption._N_constant_object;
				list<IMember> list3 = LookupMember("_N_constant_object");
				if (!(list3 is list<IMember>.Cons) || (object)((list<IMember>.Cons)list3).tl != list<IMember>.Nil._N_constant_object)
				{
					if (!Message.SeenError)
					{
						string hd = "cannot find _N_constant_object".ToString();
						Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(hd) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
					}
					throw new AssertionException("ncc\\external\\ExternalTypeInfo\\ExternalNemerleTypeInfo.n", 107, "", "cannot find _N_constant_object");
				}
				IMember hd2 = ((list<IMember>.Cons)list3).hd;
				constant_object = (IField)hd2;
			}
			else if (system_type.IsDefined(SystemTypeCache.TypeAliasAttribute, inherit: false))
			{
				object obj = system_type.GetCustomAttributes(SystemTypeCache.TypeAliasAttribute, inherit: false)[0];
				string hd = (string)obj.GetType().InvokeMember("AliasedType", System.Reflection.BindingFlags.GetField | System.Reflection.BindingFlags.GetProperty, null, obj, null, null, null, null);
				tydecl = new TypeDeclaration.Alias(TyCodec.DecodeType(n_closureOf__ctor_._N_lib_59721, tenv, hd));
			}
			else if (system_type.IsInterface)
			{
				tydecl = TypeDeclaration.Interface._N_constant_object;
			}
			else if (system_type.IsEnum)
			{
				tydecl = TypeDeclaration.Enum._N_constant_object;
			}
			else
			{
				tydecl = TypeDeclaration.Class._N_constant_object;
			}
			decode_extension_patterns();
		}

		public override TypeDeclaration GetTydecl()
		{
			return tydecl;
		}

		public override IField GetConstantObject()
		{
			return constant_object;
		}

		private void decode_extension_patterns()
		{
			int num = 0;
			Type extensionPatternEncodingAttribute = SystemTypeCache.ExtensionPatternEncodingAttribute;
			object[] customAttributes = system_type.GetCustomAttributes(extensionPatternEncodingAttribute, inherit: false);
			if (customAttributes.Length > 0)
			{
				MethodInfo method = extensionPatternEncodingAttribute.GetMethod("get_Identifiers");
				MethodInfo method2 = extensionPatternEncodingAttribute.GetMethod("get_Pattern");
				MethodInfo method3 = extensionPatternEncodingAttribute.GetMethod("get_Name");
				for (num = 0; num < customAttributes.Length; num = checked(num + 1))
				{
					object obj = customAttributes[num];
					obj = obj;
					string str = (string)method.Invoke(obj, null);
					string expr = (string)method2.Invoke(obj, null);
					string name = (string)method3.Invoke(obj, null);
					ExtensionPattern e = new ExtensionPattern(this, name, NString.Split(str, new list<char>.Cons(',', list<char>.Nil._N_constant_object)), MainParser.ParseExpr(Manager.CoreEnv, expr), temporary: false);
					AddExtensionPattern(e);
				}
			}
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				IField field = constant_object;
				if (field != null)
				{
					((ISupportRelocation)field).RelocateImpl(_info);
				}
				tydecl?.RelocateImplInternal(_info);
			}
		}

		private ExternalNemerleTypeInfo _N_get_opt_59727(_N_closureOf__ctor_59714 _N__ctor_cp_59726, string name, int index)
		{
			while (true)
			{
				option<TypeInfo> option = _N__ctor_cp_59726._N_lib_59721.LibRefManager.NameTree.LookupExactType(NString.Split(name, '.', '+'));
				if (option is option<TypeInfo>.Some)
				{
					if (((option<TypeInfo>.Some)option).val is ExternalNemerleTypeInfo)
					{
						ExternalNemerleTypeInfo externalNemerleTypeInfo = (ExternalNemerleTypeInfo)((option<TypeInfo>.Some)option).val;
						externalNemerleTypeInfo.VariantOptionCode = index;
						return externalNemerleTypeInfo;
					}
					throw new AssertionException("ncc\\external\\ExternalTypeInfo\\ExternalNemerleTypeInfo.n", 71, "", "");
				}
				if (option != option<TypeInfo>.None._N_constant_object)
				{
					break;
				}
				if (_N__ctor_cp_59726._N_lib_59721.LibRefManager.IsAssemblyLoaded(system_type.Assembly.FullName))
				{
					if (!Message.SeenError)
					{
						string text = ("cannot find variant option named " + Convert.ToString(name)).ToString();
						Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
					}
					throw new AssertionException("ncc\\external\\ExternalTypeInfo\\ExternalNemerleTypeInfo.n", 77, "", ("cannot find variant option named " + Convert.ToString(name)).ToString());
				}
				_N__ctor_cp_59726._N_lib_59721.LibRefManager.AddAssembly(system_type.Assembly, isUserReference: false);
				_N__ctor_cp_59726._N_lib_59721.LibRefManager.LoadLibrariesContents();
				string text2 = name;
				index = index;
				name = text2;
			}
			throw new MatchFailureException();
		}
	}

	protected internal class ExternalPrimitiveTypeInfo : ExternalTypeInfo
	{
		private list<TypeInfo> implicit_conversion;

		private readonly bool is_longsize;

		private readonly bool is_floating;

		private readonly bool is_numeric;

		private readonly int size;

		private readonly bool unsigned;

		public override bool IsPrimitive => true;

		public override bool IsFloating
		{
			[DebuggerStepThrough]
			[CompilerGenerated]
			get
			{
				return is_floating;
			}
		}

		public override bool IsNumeric
		{
			[CompilerGenerated]
			[DebuggerStepThrough]
			get
			{
				return is_numeric;
			}
		}

		public override int Size
		{
			[DebuggerStepThrough]
			[CompilerGenerated]
			get
			{
				return size;
			}
		}

		public override bool Unsigned
		{
			[DebuggerStepThrough]
			[CompilerGenerated]
			get
			{
				return unsigned;
			}
		}

		public ExternalPrimitiveTypeInfo(LibraryReference lib, Type h, NamespaceTree.Node ns_node)
			: base(lib, h, ns_node)
		{
			is_longsize = false;
			is_numeric = true;
			switch (Name)
			{
			case "SByte":
				size = 8;
				unsigned = false;
				break;
			case "Int16":
				size = 16;
				unsigned = false;
				break;
			case "Int32":
				size = 32;
				unsigned = false;
				break;
			case "Int64":
				size = 64;
				unsigned = false;
				is_longsize = true;
				break;
			case "Byte":
				size = 8;
				unsigned = true;
				break;
			case "UInt16":
				size = 16;
				unsigned = true;
				break;
			case "UInt32":
				size = 31;
				unsigned = true;
				break;
			case "UInt64":
				size = 64;
				unsigned = true;
				is_longsize = true;
				break;
			case "Single":
				size = 32;
				unsigned = false;
				is_floating = true;
				break;
			case "Double":
				size = 64;
				unsigned = false;
				is_floating = true;
				break;
			case "Char":
				size = 16;
				unsigned = true;
				is_numeric = false;
				break;
			default:
				is_numeric = false;
				break;
			}
		}

		public override TypeInfo MakePointerTypeInfo()
		{
			return library.TypeInfoOfType(system_type.MakePointerType());
		}

		public override list<IMember> LookupMemberImpl(string name)
		{
			list<IMember> result;
			if (implicit_conversion == null)
			{
				AddConversions();
				result = LookupMember(name);
			}
			else
			{
				result = base.LookupMemberImpl(name);
			}
			return result;
		}

		public bool CanOmmitConversionTo(ExternalPrimitiveTypeInfo target)
		{
			int result;
			if (target.Equals(this))
			{
				result = 1;
			}
			else if (is_longsize != target.is_longsize || is_floating != target.is_floating)
			{
				result = 0;
			}
			else
			{
				if (implicit_conversion == null)
				{
					AddConversions();
				}
				result = ((implicit_conversion.Contains(target) || (Equals(InternalType.Char_tc) && ((ExternalPrimitiveTypeInfo)InternalType.UInt16_tc).CanOmmitConversionTo(target))) ? 1 : 0);
			}
			return (byte)result != 0;
		}

		protected void AddConversions()
		{
			bool flag = true;
			object obj;
			switch (system_type.Name)
			{
			case "SByte":
				obj = new list<TypeInfo>.Cons(InternalType.Int16_tc, new list<TypeInfo>.Cons(InternalType.Int32_tc, new list<TypeInfo>.Cons(InternalType.Int64_tc, new list<TypeInfo>.Cons(InternalType.Single_tc, new list<TypeInfo>.Cons(InternalType.Double_tc, list<TypeInfo>.Nil._N_constant_object)))));
				break;
			case "Int16":
				obj = new list<TypeInfo>.Cons(InternalType.Int32_tc, new list<TypeInfo>.Cons(InternalType.Int64_tc, new list<TypeInfo>.Cons(InternalType.Single_tc, new list<TypeInfo>.Cons(InternalType.Double_tc, list<TypeInfo>.Nil._N_constant_object))));
				break;
			case "Int32":
				obj = new list<TypeInfo>.Cons(InternalType.Int64_tc, new list<TypeInfo>.Cons(InternalType.Single_tc, new list<TypeInfo>.Cons(InternalType.Double_tc, list<TypeInfo>.Nil._N_constant_object)));
				break;
			case "Int64":
				obj = new list<TypeInfo>.Cons(InternalType.Single_tc, new list<TypeInfo>.Cons(InternalType.Double_tc, list<TypeInfo>.Nil._N_constant_object));
				break;
			case "Byte":
				obj = new list<TypeInfo>.Cons(InternalType.Int16_tc, new list<TypeInfo>.Cons(InternalType.Int32_tc, new list<TypeInfo>.Cons(InternalType.Int64_tc, new list<TypeInfo>.Cons(InternalType.UInt16_tc, new list<TypeInfo>.Cons(InternalType.UInt32_tc, new list<TypeInfo>.Cons(InternalType.UInt64_tc, new list<TypeInfo>.Cons(InternalType.Single_tc, new list<TypeInfo>.Cons(InternalType.Double_tc, list<TypeInfo>.Nil._N_constant_object))))))));
				break;
			case "UInt16":
				obj = new list<TypeInfo>.Cons(InternalType.Int32_tc, new list<TypeInfo>.Cons(InternalType.Int64_tc, new list<TypeInfo>.Cons(InternalType.UInt32_tc, new list<TypeInfo>.Cons(InternalType.UInt64_tc, new list<TypeInfo>.Cons(InternalType.Single_tc, new list<TypeInfo>.Cons(InternalType.Double_tc, list<TypeInfo>.Nil._N_constant_object))))));
				break;
			case "UInt32":
				obj = new list<TypeInfo>.Cons(InternalType.Int64_tc, new list<TypeInfo>.Cons(InternalType.UInt64_tc, new list<TypeInfo>.Cons(InternalType.Single_tc, new list<TypeInfo>.Cons(InternalType.Double_tc, list<TypeInfo>.Nil._N_constant_object))));
				break;
			case "UInt64":
				obj = new list<TypeInfo>.Cons(InternalType.Single_tc, new list<TypeInfo>.Cons(InternalType.Double_tc, list<TypeInfo>.Nil._N_constant_object));
				break;
			case "Char":
				obj = new list<TypeInfo>.Cons(InternalType.UInt16_tc, new list<TypeInfo>.Cons(InternalType.Int32_tc, new list<TypeInfo>.Cons(InternalType.UInt32_tc, new list<TypeInfo>.Cons(InternalType.Int64_tc, new list<TypeInfo>.Cons(InternalType.UInt64_tc, new list<TypeInfo>.Cons(InternalType.Single_tc, new list<TypeInfo>.Cons(InternalType.Double_tc, list<TypeInfo>.Nil._N_constant_object)))))));
				break;
			case "Single":
				obj = new list<TypeInfo>.Cons(InternalType.Double_tc, list<TypeInfo>.Nil._N_constant_object);
				break;
			case "Double":
				obj = list<TypeInfo>.Nil._N_constant_object;
				break;
			default:
				flag = false;
				obj = list<TypeInfo>.Nil._N_constant_object;
				break;
			}
			list<TypeInfo> list = (implicit_conversion = (list<TypeInfo>)obj);
			if (!flag)
			{
				return;
			}
			list<TypeInfo> list2 = implicit_conversion;
			while (list2 is list<TypeInfo>.Cons)
			{
				TypeInfo hd = ((list<TypeInfo>.Cons)list2).hd;
				list<TypeInfo> list3 = ((list<TypeInfo>.Cons)list2).tl;
				TypeInfo target = hd;
				AddConversion("op_Implicit", target);
				list2 = list3;
			}
			foreach (string key in ExternalTypeInfo.numeric_types.Keys)
			{
				string hd2 = key;
				TypeInfo typeInfo = library.LibRefManager.NameTree.LookupInternalType(new list<string>.Cons("System", new list<string>.Cons(hd2, list<string>.Nil._N_constant_object)));
				if (!Equals(typeInfo) && !implicit_conversion.Contains(typeInfo))
				{
					AddConversion("op_Explicit", typeInfo);
				}
			}
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
			list<TypeInfo> list = implicit_conversion;
			if (list != null)
			{
				list = list;
				while (list is list<TypeInfo>.Cons)
				{
					TypeInfo hd = ((list<TypeInfo>.Cons)list).hd;
					list = ((list<TypeInfo>.Cons)list).tl;
					((ISupportRelocation)hd).RelocateImpl(_info);
					list = list;
				}
			}
		}
	}

	private sealed class _N_closureOf_GetIsFriend_53872
	{
		internal string _N_currentAssemblyName_53879;

		internal LibraryReference _N__N_closurised_this_ptr_53877;

		internal _N_closureOf_GetIsFriend_53872()
		{
		}
	}

	private sealed class _N__N_lambda__53865__53923 : Function<object, bool>
	{
		[SpecialName]
		private _N_closureOf_GetIsFriend_53872 _N_GetIsFriend_closure_53927;

		public _N__N_lambda__53865__53923(_N_closureOf_GetIsFriend_53872 _N_GetIsFriend_closure_53927)
		{
			this._N_GetIsFriend_closure_53927 = _N_GetIsFriend_closure_53927;
		}

		[SpecialName]
		public sealed override bool apply(object a)
		{
			return _N_GetIsFriend_closure_53927._N__N_closurised_this_ptr_53877._N_checkFriend_53903(_N_GetIsFriend_closure_53927, (InternalsVisibleToAttribute)a);
		}
	}

	private sealed class _N_closureOf_TypeOfType_53965
	{
		internal Map<string, StaticTypeVar> _N__tenv_53972;

		internal LibraryReference _N__N_closurised_this_ptr_53970;

		internal _N_closureOf_TypeOfType_53965()
		{
		}
	}

	private sealed class _N__N_lambda__53950__53997 : Function<Type, TypeVar>
	{
		[SpecialName]
		private _N_closureOf_TypeOfType_53965 _N_TypeOfType_closure_54001;

		public _N__N_lambda__53950__53997(_N_closureOf_TypeOfType_53965 _N_TypeOfType_closure_54001)
		{
			this._N_TypeOfType_closure_54001 = _N_TypeOfType_closure_54001;
		}

		[SpecialName]
		public sealed override TypeVar apply(Type t)
		{
			return _N_TypeOfType_closure_54001._N__N_closurised_this_ptr_53970.TypeOfType(_N_TypeOfType_closure_54001._N__tenv_53972, t);
		}
	}

	private sealed class _N_closureOf_ConvertCustomAttributesData_54421
	{
		internal LibraryReference _N_library_54426;

		internal _N_closureOf_ConvertCustomAttributesData_54421()
		{
		}
	}

	private sealed class _N_makeArg__54436 : Function<CustomAttributeTypedArgument, PExpr>
	{
		[SpecialName]
		private _N_closureOf_ConvertCustomAttributesData_54421 _N_ConvertCustomAttributesData_closure_54440;

		public _N_makeArg__54436(_N_closureOf_ConvertCustomAttributesData_54421 _N_ConvertCustomAttributesData_closure_54440)
		{
			this._N_ConvertCustomAttributesData_closure_54440 = _N_ConvertCustomAttributesData_closure_54440;
		}

		[SpecialName]
		public sealed override PExpr apply(CustomAttributeTypedArgument a)
		{
			_N_closureOf_makeArg_54445 n_makeArg_cp_ = new _N_closureOf_makeArg_54445();
			return _N_lift_54452(n_makeArg_cp_, _N_ConvertCustomAttributesData_closure_54440, a.Value);
		}
	}

	private sealed class _N_closureOf_makeArg_54445
	{
		internal _N_closureOf_makeArg_54445()
		{
		}
	}

	private sealed class _N__N_lambda__54364__54495 : Function<CustomAttributeTypedArgument, PExpr>
	{
		[SpecialName]
		private _N_closureOf_ConvertCustomAttributesData_54421 _N_ConvertCustomAttributesData_closure_54501;

		[SpecialName]
		private _N_closureOf_makeArg_54445 _N_makeArg_closure_54499;

		public _N__N_lambda__54364__54495(_N_closureOf_makeArg_54445 _N_makeArg_closure_54499, _N_closureOf_ConvertCustomAttributesData_54421 _N_ConvertCustomAttributesData_closure_54501)
		{
			this._N_makeArg_closure_54499 = _N_makeArg_closure_54499;
			this._N_ConvertCustomAttributesData_closure_54501 = _N_ConvertCustomAttributesData_closure_54501;
		}

		[SpecialName]
		public sealed override PExpr apply(CustomAttributeTypedArgument e)
		{
			return _N_lift_54452(_N_makeArg_closure_54499, _N_ConvertCustomAttributesData_closure_54501, e.Value);
		}
	}

	private readonly Assembly _library;

	private Location _location;

	private readonly bool _isFriend;

	private readonly bool _is_generated_by_nemerle;

	public readonly LibraryReferenceManager LibRefManager;

	private bool doEnsureCached = false;

	public readonly ManagerClass Manager;

	public bool IsUserReference { get; }

	public InternalTypeClass InternalType => Manager.InternalType;

	public SystemTypeClass SystemTypeCache => Manager.SystemTypeCache;

	public Assembly Assembly
	{
		[CompilerGenerated]
		[DebuggerStepThrough]
		get
		{
			return _library;
		}
	}

	public bool IsFriend
	{
		[DebuggerStepThrough]
		[CompilerGenerated]
		get
		{
			return _isFriend;
		}
	}

	private static void load_attr_from(Assembly assembly, string attr_name, ref Type attr, ref string attr_loc)
	{
		Type type = assembly.GetType(attr_name);
		if (type != null && attr != null && attr.FullName != "System.Runtime.CompilerServices.ExtensionAttribute")
		{
			Message.Warning(Convert.ToString(attr_name) + " attribute from " + Convert.ToString(assembly) + " is ignored");
			Message.HintOnce(Convert.ToString(attr_name) + " is first defined in " + Convert.ToString(attr_loc));
		}
		string text = assembly.ToString();
		if (type != null && (attr == null || attr_loc == text))
		{
			attr = type;
			attr_loc = text;
		}
	}

	internal LibraryReference(LibraryReferenceManager mgr, Assembly assembly, bool isUserReference)
	{
		LibRefManager = mgr;
		Manager = mgr.Manager;
		_library = assembly;
		_N_IsUserReference_10392 = isUserReference;
		_location = new Location(Location.GetFileIndex(mgr.getAssemblyLocation(assembly)), 0, 0);
		_location.MarkAsGenerated();
		object[] customAttributes = _library.GetCustomAttributes(typeof(AssemblyConfigurationAttribute), inherit: false);
		object[] array = customAttributes;
		for (int i = 0; i < array.Length; i = checked(i + 1))
		{
			AssemblyConfigurationAttribute assemblyConfigurationAttribute = (AssemblyConfigurationAttribute)array[i];
			AssemblyConfigurationAttribute assemblyConfigurationAttribute2 = assemblyConfigurationAttribute;
			bool flag = (_is_generated_by_nemerle = _is_generated_by_nemerle || assemblyConfigurationAttribute2.Configuration == "ContainsNemerleTypes");
		}
		load_attr_from(assembly, "Nemerle.Internal.ExtensionAttribute", ref SystemTypeCache.ExtensionAttribute, ref SystemTypeCache.ExtensionAttributeAssembly);
		load_attr_from(assembly, "System.Runtime.CompilerServices.ExtensionAttribute", ref SystemTypeCache.SQ_ExtensionAttribute, ref SystemTypeCache.SQ_ExtensionAttributeAssembly);
		_isFriend = GetIsFriend();
	}

	private bool GetIsFriend()
	{
		_N_closureOf_GetIsFriend_53872 n_closureOf_GetIsFriend_ = new _N_closureOf_GetIsFriend_53872();
		n_closureOf_GetIsFriend_._N__N_closurised_this_ptr_53877 = this;
		n_closureOf_GetIsFriend_._N_currentAssemblyName_53879 = Path.GetFileNameWithoutExtension(Manager.Options.OutputFileName);
		object[] customAttributes = _library.GetCustomAttributes(typeof(InternalsVisibleToAttribute), inherit: false);
		Function<object, bool> f = new _N__N_lambda__53865__53923(n_closureOf_GetIsFriend_);
		return customAttributes.Exists(f);
	}

	internal void LoadContents()
	{
		LibRefManager.LoadTypesFrom(this);
		LibRefManager.LoadMacrosFrom(_library);
	}

	public override string ToString()
	{
		return (_location == Location.Default) ? Assembly.ToString() : ((!(Assembly != null)) ? base.ToString() : _location.ToString());
	}

	internal FixedType TypeOfType(Map<string, StaticTypeVar> _tenv, Type framework_type)
	{
		object result;
		while (true)
		{
			_N_closureOf_TypeOfType_53965 n_closureOf_TypeOfType_ = new _N_closureOf_TypeOfType_53965();
			n_closureOf_TypeOfType_._N__tenv_53972 = _tenv;
			n_closureOf_TypeOfType_._N__N_closurised_this_ptr_53970 = this;
			if (framework_type.Equals(SystemTypeCache.Void))
			{
				result = InternalType.Void;
				break;
			}
			if (framework_type.IsArray)
			{
				result = new FixedType.Array(TypeOfType(n_closureOf_TypeOfType_._N__tenv_53972, framework_type.GetElementType()), framework_type.GetArrayRank());
				break;
			}
			if (framework_type.IsByRef)
			{
				Message.Error("ref type referenced " + Convert.ToString(framework_type));
				Map<string, StaticTypeVar> obj = n_closureOf_TypeOfType_._N__tenv_53972;
				framework_type = framework_type.GetElementType();
				_tenv = obj;
				continue;
			}
			if (framework_type.IsGenericParameter)
			{
				option<StaticTypeVar> option = n_closureOf_TypeOfType_._N__tenv_53972.Find(framework_type.Name);
				if (option is option<StaticTypeVar>.Some)
				{
					StaticTypeVar val = ((option<StaticTypeVar>.Some)option).val;
					result = new FixedType.StaticTypeVarRef(val);
					break;
				}
				if (option == option<StaticTypeVar>.None._N_constant_object)
				{
					if (!Message.SeenError)
					{
						string text = (Convert.ToString(framework_type) + " from " + Convert.ToString(framework_type.DeclaringType)).ToString();
						Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
					}
					throw new AssertionException("ncc\\external\\LibraryReference.n", 198, "", (Convert.ToString(framework_type) + " from " + Convert.ToString(framework_type.DeclaringType)).ToString());
				}
				throw new MatchFailureException();
			}
			TypeInfo typeInfo = TypeInfoOfType(framework_type);
			object obj2;
			if (framework_type.IsGenericType)
			{
				Type[] genericArguments = framework_type.GetGenericArguments();
				Function<Type, TypeVar> convert = new _N__N_lambda__53950__53997(n_closureOf_TypeOfType_);
				obj2 = genericArguments.MapToList(convert);
			}
			else
			{
				obj2 = list<TypeVar>.Nil._N_constant_object;
			}
			list<TypeVar> list = (list<TypeVar>)obj2;
			if (framework_type.Namespace == "Nemerle.Builtins")
			{
				if (typeInfo.Name == "Tuple")
				{
					result = new FixedType.Tuple(list);
					break;
				}
				if (typeInfo.Name == "FunctionVoid")
				{
					result = new FixedType.Fun(_N_make_tupl_54010(n_closureOf_TypeOfType_, list), list.Length, InternalType.Void);
					break;
				}
				Nemerle.Builtins.Tuple<list<TypeVar>, TypeVar> tuple = list.DivideLast();
				list = tuple.Field0;
				TypeVar field = tuple.Field1;
				result = new FixedType.Fun(_N_make_tupl_54010(n_closureOf_TypeOfType_, list), list.Length, field);
			}
			else
			{
				result = new FixedType.Class(typeInfo, list);
			}
			break;
		}
		return (FixedType)result;
	}

	internal TypeInfo TypeInfoOfType(Type framework_type)
	{
		int length = framework_type.GetGenericArguments().Length;
		Nemerle.Builtins.Tuple<NamespaceTree.Node, list<string>> tuple = LibRefManager.framework_nesting(framework_type);
		NamespaceTree.Node field = tuple.Field0;
		list<string> field2 = tuple.Field1;
		field = field.Path(field2);
		if (doEnsureCached)
		{
			field.EnsureCached();
		}
		option<TypeInfo> option = field.LookupType(list<string>.Nil._N_constant_object, length);
		TypeInfo result;
		if (option is option<TypeInfo>.Some)
		{
			TypeInfo val = ((option<TypeInfo>.Some)option).val;
			result = val;
		}
		else
		{
			if (option != option<TypeInfo>.None._N_constant_object)
			{
				throw new MatchFailureException();
			}
			result = LibraryReferenceManager.GetInternalType(this, framework_type, field);
		}
		return result;
	}

	internal TypeInfo ConstructTypeInfo(Type reflected_type, NamespaceTree.Node ns_node)
	{
		return (_is_generated_by_nemerle && reflected_type.IsDefined(SystemTypeCache.NemerleAttribute, inherit: false)) ? new ExternalNemerleTypeInfo(this, reflected_type, ns_node) : ((!reflected_type.IsPrimitive) ? new ExternalTypeInfo(this, reflected_type, ns_node) : new ExternalPrimitiveTypeInfo(this, reflected_type, ns_node));
	}

	internal option<TypeInfo> LookupInternalType(string name)
	{
		Type type = _library.GetType(name);
		object result;
		if (type == null)
		{
			result = option<TypeInfo>.None._N_constant_object;
		}
		else
		{
			Nemerle.Builtins.Tuple<NamespaceTree.Node, list<string>> tuple = LibRefManager.framework_nesting(type);
			NamespaceTree.Node field = tuple.Field0;
			list<string> field2 = tuple.Field1;
			field = field.Path(field2);
			result = new option<TypeInfo>.Some(LibraryReferenceManager.GetInternalType(this, type, field));
		}
		return (option<TypeInfo>)result;
	}

	private ExternalMethodInfo MethodOfMethodInfo(Map<string, StaticTypeVar> tenv, MethodInfo meth)
	{
		return (!(meth == null)) ? new ExternalMethodInfo(tenv, this, meth) : null;
	}

	public list<Nemerle.Builtins.Tuple<PExpr, list<PExpr>>> GetCustomAttributes()
	{
		return ConvertCustomAttributesData(CustomAttributeData.GetCustomAttributes(Assembly), this);
	}

	internal static list<Nemerle.Builtins.Tuple<PExpr, list<PExpr>>> ConvertCustomAttributesData(IList<CustomAttributeData> attrData, LibraryReference library)
	{
		_N_closureOf_ConvertCustomAttributesData_54421 n_closureOf_ConvertCustomAttributesData_ = new _N_closureOf_ConvertCustomAttributesData_54421();
		n_closureOf_ConvertCustomAttributesData_._N_library_54426 = library;
		ManagerClass manager = n_closureOf_ConvertCustomAttributesData_._N_library_54426.Manager;
		List<Nemerle.Builtins.Tuple<PExpr, list<PExpr>>> list = new List<Nemerle.Builtins.Tuple<PExpr, list<PExpr>>>();
		IEnumerator<CustomAttributeData> enumerator = attrData.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				CustomAttributeData current = enumerator.Current;
				CustomAttributeData customAttributeData = current;
				PExpr field = PExpr.FromQualifiedIdentifier(manager, customAttributeData.Constructor.DeclaringType.FullName);
				Function<CustomAttributeTypedArgument, PExpr> convert = new _N_makeArg__54436(n_closureOf_ConvertCustomAttributesData_);
				list<PExpr> field2 = customAttributeData.ConstructorArguments.MapToList(convert);
				list.Add(new Nemerle.Builtins.Tuple<PExpr, list<PExpr>>(field, field2));
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		return list.NToList();
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
			LibRefManager?.RelocateImplInternal(_info);
			_location = Completion.Relocate(_location, _info);
		}
	}

	void ISupportRelocation.RelocateImpl(RelocationInfo _info)
	{
		//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
		this.RelocateImplInternal(_info);
	}

	private StrongNameKeyPair _N_snKey_53882(_N_closureOf_GetIsFriend_53872 _N_GetIsFriend_cp_53881)
	{
		FileStream fileStream = File.Open(Manager.Options.StrongAssemblyKeyName, FileMode.Open, FileAccess.Read);
		try
		{
			return new StrongNameKeyPair(fileStream);
		}
		finally
		{
			((IDisposable)fileStream)?.Dispose();
		}
	}

	private static string _N_toHexString_53892(byte[] bytes)
	{
		string text = BitConverter.ToString(bytes);
		return text.Replace("-", "");
	}

	private static byte[] _N_generatePublicKeyToken_53897(byte[] publicKey)
	{
		byte[] array = null;
		SHA1Managed sHA1Managed = new SHA1Managed();
		byte[] array2 = sHA1Managed.ComputeHash(publicKey);
		array = new byte[8];
		Array.Copy(array2, checked(array2.Length - 8), array, 0, 8);
		Array.Reverse(array, 0, 8);
		return array;
	}

	private bool _N_checkFriend_53903(_N_closureOf_GetIsFriend_53872 _N_GetIsFriend_cp_53902, InternalsVisibleToAttribute att)
	{
		string assemblyName = att.AssemblyName;
		list<string> list = assemblyName.Replace(" ", "").SplitToList(',');
		int result;
		if (list is list<string>.Cons)
		{
			if ((object)((list<string>.Cons)list).tl == list<string>.Nil._N_constant_object)
			{
				assemblyName = ((list<string>.Cons)list).hd;
				if (_N_GetIsFriend_cp_53902._N_currentAssemblyName_53879 == assemblyName)
				{
					result = 1;
					goto IL_02a8;
				}
			}
			else if (((list<string>.Cons)list).tl is list<string>.Cons)
			{
				assemblyName = ((list<string>.Cons)list).hd;
				if ((object)((list<string>.Cons)((list<string>.Cons)list).tl).tl == list<string>.Nil._N_constant_object)
				{
					string hd = ((list<string>.Cons)((list<string>.Cons)list).tl).hd;
					if (string.IsNullOrEmpty(Manager.Options.StrongAssemblyKeyName) && _N_GetIsFriend_cp_53902._N_currentAssemblyName_53879 == assemblyName)
					{
						list = hd.ToLower().SplitToList(',');
						if (list is list<string>.Cons)
						{
							if (((list<string>.Cons)list).hd == "publickey")
							{
								if (((list<string>.Cons)list).tl is list<string>.Cons && (object)((list<string>.Cons)((list<string>.Cons)list).tl).tl == list<string>.Nil._N_constant_object)
								{
									assemblyName = ((list<string>.Cons)((list<string>.Cons)list).tl).hd;
									if (_N_toHexString_53892(_N_snKey_53882(_N_GetIsFriend_cp_53902).PublicKey).ToLower() == assemblyName.ToLower())
									{
										result = 1;
										goto IL_02a8;
									}
								}
							}
							else if (((list<string>.Cons)list).hd == "publickeytoken" && ((list<string>.Cons)list).tl is list<string>.Cons && (object)((list<string>.Cons)((list<string>.Cons)list).tl).tl == list<string>.Nil._N_constant_object)
							{
								assemblyName = ((list<string>.Cons)((list<string>.Cons)list).tl).hd;
								if (_N_toHexString_53892(_N_generatePublicKeyToken_53897(_N_snKey_53882(_N_GetIsFriend_cp_53902).PublicKey)).ToLower() == assemblyName.ToLower())
								{
									result = 1;
									goto IL_02a8;
								}
							}
						}
						result = 0;
						goto IL_02a8;
					}
				}
			}
		}
		result = 0;
		goto IL_02a8;
		IL_02a8:
		return (byte)result != 0;
	}

	private TypeVar _N_make_tupl_54010(_N_closureOf_TypeOfType_53965 _N_TypeOfType_cp_54009, list<TypeVar> l)
	{
		object result;
		if (l is list<TypeVar>.Cons)
		{
			if ((object)((list<TypeVar>.Cons)l).tl != list<TypeVar>.Nil._N_constant_object)
			{
				goto IL_0032;
			}
			TypeVar hd = ((list<TypeVar>.Cons)l).hd;
			result = hd;
		}
		else
		{
			if ((object)l != list<TypeVar>.Nil._N_constant_object)
			{
				goto IL_0032;
			}
			result = InternalType.Void;
		}
		goto IL_005a;
		IL_005a:
		return (TypeVar)result;
		IL_0032:
		result = new FixedType.Tuple(l);
		goto IL_005a;
	}

	private static PExpr _N_lift_54452(_N_closureOf_makeArg_54445 _N_makeArg_cp_54450, _N_closureOf_ConvertCustomAttributesData_54421 _N_ConvertCustomAttributesData_cp_54451, object value)
	{
		object result;
		if (value is bool)
		{
			result = new PExpr.Literal(new Literal.Bool((bool)value));
		}
		else if (value is string)
		{
			result = new PExpr.Literal(new Literal.String((string)value));
		}
		else if (value is double)
		{
			result = new PExpr.Literal(new Literal.Double((double)value));
		}
		else if (value is float)
		{
			result = new PExpr.Literal(new Literal.Float((float)value));
		}
		else if (value is decimal)
		{
			result = new PExpr.Literal(new Literal.Decimal((decimal)value));
		}
		else if (value is int)
		{
			result = new PExpr.Literal(Literal.FromInt((int)value));
		}
		else if (value is uint)
		{
			result = new PExpr.Literal(Literal.FromUInt((uint)value));
		}
		else if (value is long)
		{
			result = new PExpr.Literal(Literal.FromLong((long)value));
		}
		else if (value is ulong)
		{
			result = new PExpr.Literal(Literal.FromULong((ulong)value));
		}
		else if (value is short)
		{
			result = new PExpr.Literal(Literal.FromShort((short)value));
		}
		else if (value is ushort)
		{
			result = new PExpr.Literal(Literal.FromUShort((ushort)value));
		}
		else if (value is byte)
		{
			result = new PExpr.Literal(Literal.FromByte((byte)value));
		}
		else if (value is sbyte)
		{
			result = new PExpr.Literal(Literal.FromSByte((sbyte)value));
		}
		else if (value is char)
		{
			result = new PExpr.Literal(new Literal.Char((char)value));
		}
		else if (value is Guid)
		{
			result = new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("System", _N_MacroContexts.Get(4, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Guid", _N_MacroContexts.Get(4, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Literal(new Literal.String(((Guid)value).ToString())), list<PExpr>.Nil._N_constant_object));
		}
		else if (value is Type)
		{
			result = new PExpr.Typeof(Macros.TypedChoose(_N_ConvertCustomAttributesData_cp_54451._N_library_54426.TypeOfType(null, (Type)value)));
		}
		else
		{
			if (!(value is ReadOnlyCollection<CustomAttributeTypedArgument>))
			{
				Message.Error(Location.Default, "Custom atribute value (" + Convert.ToString(value) + ") of type " + Convert.ToString(value.GetType()) + " not suported yet.");
				throw new Recovery();
			}
			PExpr.Literal rank = new PExpr.Literal(new Literal.Integer(1uL, is_negative: false, null).WithProperType());
			ReadOnlyCollection<CustomAttributeTypedArgument> source = (ReadOnlyCollection<CustomAttributeTypedArgument>)value;
			Function<CustomAttributeTypedArgument, PExpr> convert = new _N__N_lambda__54364__54495(_N_makeArg_cp_54450, _N_ConvertCustomAttributesData_cp_54451);
			result = new PExpr.Array(rank, new PExpr.ListLiteral(Macros.QuotationChoose(source.MapToList(convert))));
		}
		return (PExpr)result;
	}
}
