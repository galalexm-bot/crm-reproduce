using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Collections;
using Nemerle.Compiler.Typedtree;
using Nemerle.Core;

namespace Nemerle.Compiler;

public abstract class TypeInfo : MemberInfo, IMember, IComparable<TypeInfo>, IEquatable<IMember>, IEquatable<TypeInfo>
{
	private sealed class _N__N_lambda__58027__58038 : Function<StaticTypeVar, string>
	{
		[SpecialName]
		public static readonly _N__N_lambda__58027__58038 Instance = new _N__N_lambda__58027__58038();

		[SpecialName]
		public sealed override string apply(StaticTypeVar x)
		{
			return Convert.ToString(x);
		}
	}

	private sealed class _N_closureOf_foreach_loop_58213
	{
		internal Nemerle.Builtins.Tuple<IMember, option<FixedType>> _N_elem_58218;

		internal _N_closureOf_foreach_loop_58213()
		{
		}
	}

	private sealed class _N__N_lambda__58197__58233 : Function<IMember, option<FixedType>, bool>
	{
		[SpecialName]
		private _N_closureOf_foreach_loop_58213 _N_foreach_loop_closure_58237;

		public _N__N_lambda__58197__58233(_N_closureOf_foreach_loop_58213 _N_foreach_loop_closure_58237)
		{
			this._N_foreach_loop_closure_58237 = _N_foreach_loop_closure_58237;
		}

		[SpecialName]
		public sealed override bool apply(IMember _N__58231, option<FixedType> _N__58232)
		{
			return Hides(_N_foreach_loop_closure_58237._N_elem_58218, new Nemerle.Builtins.Tuple<IMember, option<FixedType>>(_N__58231, _N__58232));
		}
	}

	private sealed class _N_closureOf_LookupMember_58271
	{
		internal string _N_name_58276;

		internal _N_closureOf_LookupMember_58271()
		{
		}
	}

	private sealed class _N__N_lambda__58247__58284 : Function<IMember, bool>
	{
		[SpecialName]
		private _N_closureOf_LookupMember_58271 _N_LookupMember_closure_58288;

		public _N__N_lambda__58247__58284(_N_closureOf_LookupMember_58271 _N_LookupMember_closure_58288)
		{
			this._N_LookupMember_closure_58288 = _N_LookupMember_closure_58288;
		}

		[SpecialName]
		public sealed override bool apply(IMember mem)
		{
			return Completion.MatchName(mem.Name, _N_LookupMember_closure_58288._N_name_58276);
		}
	}

	private sealed class _N__N_lambda__58260__58318 : Function<FixedType.Class, list<IMember>>
	{
		[SpecialName]
		private _N_closureOf_LookupMember_58271 _N_LookupMember_closure_58322;

		public _N__N_lambda__58260__58318(_N_closureOf_LookupMember_58271 _N_LookupMember_closure_58322)
		{
			this._N_LookupMember_closure_58322 = _N_LookupMember_closure_58322;
		}

		[SpecialName]
		public sealed override list<IMember> apply(FixedType.Class c)
		{
			return c.tycon.LookupMember(_N_LookupMember_closure_58322._N_name_58276);
		}
	}

	private sealed class _N_closureOf_ConstructSubst_58358
	{
		internal TypeInfo _N_tc_58369;

		internal TypeInfo _N__N_closurised_this_ptr_58367;

		internal Subst _N_res_58365;

		internal Messenger _N_messenger_58363;

		internal _N_closureOf_ConstructSubst_58358()
		{
		}
	}

	private sealed class _N__N_lambda__58341__58386 : FunctionVoid<StaticTypeVar, TypeVar>
	{
		[SpecialName]
		private _N_closureOf_ConstructSubst_58358 _N_ConstructSubst_closure_58390;

		public _N__N_lambda__58341__58386(_N_closureOf_ConstructSubst_58358 _N_ConstructSubst_closure_58390)
		{
			this._N_ConstructSubst_closure_58390 = _N_ConstructSubst_closure_58390;
		}

		[SpecialName]
		public sealed override void apply_void(StaticTypeVar tp, TypeVar val)
		{
			_N_ConstructSubst_closure_58390._N_res_58365.Add(tp, val);
		}
	}

	private sealed class _N__N_lambda__58347__58398 : FunctionVoid<StaticTypeVar, TypeVar>
	{
		[SpecialName]
		private _N_closureOf_ConstructSubst_58358 _N_ConstructSubst_closure_58402;

		public _N__N_lambda__58347__58398(_N_closureOf_ConstructSubst_58358 _N_ConstructSubst_closure_58402)
		{
			this._N_ConstructSubst_closure_58402 = _N_ConstructSubst_closure_58402;
		}

		[SpecialName]
		public sealed override void apply_void(StaticTypeVar tp, TypeVar val)
		{
			if (_N_ConstructSubst_closure_58402._N__N_closurised_this_ptr_58367.InternalType.Void == null)
			{
			}
			if (val.Equals(_N_ConstructSubst_closure_58402._N__N_closurised_this_ptr_58367.InternalType.Void))
			{
				if (_N_ConstructSubst_closure_58402._N_messenger_58363.NeedMessage)
				{
					_N_ConstructSubst_closure_58402._N_messenger_58363.Error("cannot use `void' as a generic parameter of " + Convert.ToString(_N_ConstructSubst_closure_58402._N_tc_58369));
				}
				else
				{
					_N_ConstructSubst_closure_58402._N_messenger_58363.MarkError();
				}
			}
			if (!val.Require(_N_ConstructSubst_closure_58402._N_res_58365.Apply(tp.LowerBound)))
			{
				if (_N_ConstructSubst_closure_58402._N_messenger_58363.NeedMessage)
				{
					_N_ConstructSubst_closure_58402._N_messenger_58363.Error("typing constraint on " + Convert.ToString(tp.Name) + " not satisfied, upon instantiation of " + Convert.ToString(_N_ConstructSubst_closure_58402._N_tc_58369));
				}
				else
				{
					_N_ConstructSubst_closure_58402._N_messenger_58363.MarkError();
				}
			}
		}
	}

	private sealed class _N__N_lambda__58509__58534 : Function<FixedType.Class, string>
	{
		[SpecialName]
		public static readonly _N__N_lambda__58509__58534 Instance = new _N__N_lambda__58509__58534();

		[SpecialName]
		public sealed override string apply(FixedType.Class x)
		{
			return Convert.ToString(x);
		}
	}

	private sealed class _N__N_lambda__58514__58544 : Function<FixedType.Class, string>
	{
		[SpecialName]
		public static readonly _N__N_lambda__58514__58544 Instance = new _N__N_lambda__58514__58544();

		[SpecialName]
		public sealed override string apply(FixedType.Class x)
		{
			return Convert.ToString(x);
		}
	}

	private sealed class _N_closureOf_loop_58602
	{
		internal Subst _N__N_obj_cache_58607;

		internal _N_closureOf_loop_58602()
		{
		}
	}

	private sealed class _N__N_method_lambda__58611 : FunctionVoid<StaticTypeVar, TypeVar>
	{
		[SpecialName]
		private _N_closureOf_loop_58602 _N_loop_closure_58615;

		public _N__N_method_lambda__58611(_N_closureOf_loop_58602 _N_loop_closure_58615)
		{
			this._N_loop_closure_58615 = _N_loop_closure_58615;
		}

		[SpecialName]
		public sealed override void apply_void(StaticTypeVar _N__58609, TypeVar _N__58610)
		{
			_N_loop_closure_58615._N__N_obj_cache_58607.Add(_N__58609, _N__58610);
		}
	}

	private sealed class _N_closureOf_foreach_loop_58691
	{
		internal FixedType.Class _N_t_58696;

		internal _N_closureOf_foreach_loop_58691()
		{
		}
	}

	private sealed class _N__N_lambda__58684__58706 : Function<FixedType.Class, bool>
	{
		[SpecialName]
		private _N_closureOf_foreach_loop_58691 _N_foreach_loop_closure_58710;

		public _N__N_lambda__58684__58706(_N_closureOf_foreach_loop_58691 _N_foreach_loop_closure_58710)
		{
			this._N_foreach_loop_closure_58710 = _N_foreach_loop_closure_58710;
		}

		[SpecialName]
		public sealed override bool apply(FixedType.Class other)
		{
			return !_N_foreach_loop_closure_58710._N_t_58696.Equals(other) && other.TypeInfo.IsDerivedFrom(_N_foreach_loop_closure_58710._N_t_58696);
		}
	}

	protected Type system_type;

	private readonly int id;

	protected string default_indexer;

	protected internal list<StaticTypeVar> typarms = list<StaticTypeVar>.Nil._N_constant_object;

	protected FixedType.Class self_type;

	protected readonly string fullname;

	protected Hashtable<string, list<IMember>> member_map;

	protected readonly Hashtable<string, ExtensionPattern> extension_patterns = new Hashtable<string, ExtensionPattern>();

	protected readonly NamespaceTree.Node namespace_nd;

	protected list<FixedType.Class> _superTypes = list<FixedType.Class>.Nil._N_constant_object;

	protected Hashtable<FixedType.Class, byte> _superTypesLookup = new Hashtable<FixedType.Class, byte>();

	protected Hashtable<TypeInfo, list<FixedType.Class>> _superTypeInfosLookup = new Hashtable<TypeInfo, list<FixedType.Class>>();

	protected bool _superTypesCalculated;

	private int _N_field_code_embeded_in_VariantOptionCode_3400 = -1;

	protected Hashtable<string, list<IMember>> special_members;

	private int _recursionLevel;

	public readonly ManagerClass Manager;

	public override bool IsFloating => false;

	public override bool IsPrimitive => false;

	public override bool IsNumeric => false;

	public override int Size => -1;

	public override bool Unsigned => false;

	public override bool IsPointer => false;

	public int VariantOptionCode
	{
		get
		{
			return _N_field_code_embeded_in_VariantOptionCode_3400;
		}
		protected set
		{
			_N_field_code_embeded_in_VariantOptionCode_3400 = value;
		}
	}

	public NamespaceTree.Node NamespaceNode => namespace_nd;

	public abstract override AttributeTargets AttributeTargets { get; }

	public override bool IsStatic => true;

	public bool IsModule => (attributes & NemerleModifiers.Static) != 0;

	public bool IsSealed => (attributes & NemerleModifiers.Sealed) != 0;

	public abstract override bool IsInterface { get; }

	public string DefaultIndexerName
	{
		get
		{
			if (default_indexer == null)
			{
				if (IsInterface)
				{
					list<FixedType.Class> list = GetDirectSuperTypes();
					while (list is list<FixedType.Class>.Cons)
					{
						FixedType.Class hd = ((list<FixedType.Class>.Cons)list).hd;
						list = ((list<FixedType.Class>.Cons)list).tl;
						default_indexer = hd.tycon.DefaultIndexerName;
						if (default_indexer != null)
						{
							break;
						}
						list = list;
					}
				}
				else
				{
					option<TypeInfo> option = SuperClass();
					if (option is option<TypeInfo>.Some)
					{
						TypeInfo val = ((option<TypeInfo>.Some)option).val;
						default_indexer = val.DefaultIndexerName;
					}
				}
			}
			return default_indexer;
		}
	}

	public string FullName => fullname;

	public string FrameworkTypeName
	{
		get
		{
			TypeInfo declaringType = DeclaringType;
			return (declaringType != null) ? string.Concat(declaringType.FrameworkTypeName + "+", Name) : FullName;
		}
	}

	public override bool LookupMemberAvailable => true;

	public abstract override TypeInfo BaseType { get; }

	public abstract override bool IsDelegate { get; }

	public override bool IsEnum
	{
		get
		{
			if (InternalType.Enum_tc == null)
			{
				throw new AssertionException("ncc\\hierarchy\\TypeInfo.n", 1055, "InternalType.Enum_tc != null", "");
			}
			int result;
			if (IsValueType)
			{
				option<TypeInfo> option = SuperClass();
				if (option is option<TypeInfo>.Some)
				{
					TypeInfo val = ((option<TypeInfo>.Some)option).val;
					result = (val.Equals(InternalType.Enum_tc) ? 1 : 0);
				}
				else
				{
					if (option != option<TypeInfo>.None._N_constant_object)
					{
						throw new MatchFailureException();
					}
					result = 0;
				}
			}
			else
			{
				result = 0;
			}
			return (byte)result != 0;
		}
	}

	public abstract override Accessibility Accessibility { get; }

	public abstract override bool IsExternallyAccessible { get; }

	public abstract override bool IsValueType { get; }

	public override int DeclaredTypeParametersCount => TyparmsCount;

	public override int TyparmsCount => typarms.Length;

	public override int SourceTyparmsCount => (DeclaringType != null) ? checked(TyparmsCount - DeclaringType.TyparmsCount) : TyparmsCount;

	public override list<StaticTypeVar> Typarms => typarms;

	public abstract override Location Location { get; }

	public override Location NameLocation => Location;

	public abstract override TypeInfo DeclaringType { get; }

	public abstract override string Name { get; }

	public override MemberTypes MemberKind => (DeclaringType == null) ? MemberTypes.TypeInfo : MemberTypes.NestedType;

	public abstract override TypeInfo UnderlyingType { get; }

	public InternalTypeClass InternalType => Manager.InternalType;

	public SystemTypeClass SystemTypeCache => Manager.SystemTypeCache;

	public Type SystemType
	{
		[DebuggerStepThrough]
		[CompilerGenerated]
		get
		{
			return system_type;
		}
	}

	[SpecialName]
	public override bool IsCustomAttributeDefined(string attributeFullName)
	{
		return ((TypeInfo)null).IsCustomAttributeDefined(attributeFullName);
	}

	[SpecialName]
	public override AttributesAndModifiers GetModifiers()
	{
		return ((TypeInfo)null).GetModifiers();
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
	public override bool get_IsConstructor()
	{
		return base.IsConstructor;
	}

	public TypeInfo(NamespaceTree.Node ns_node, ManagerClass manager, string fullname)
	{
		Manager = manager;
		id = manager.GetNewId();
		namespace_nd = ns_node;
		this.fullname = fullname;
	}

	public override option<TypeInfo> GetElementTypeInfo()
	{
		return option<TypeInfo>.None._N_constant_object;
	}

	internal void CleanUp()
	{
		int num = 0;
		Nemerle.Builtins.Tuple<string, ExtensionPattern>[] keyValuePairs = extension_patterns.KeyValuePairs;
		for (num = 0; num < keyValuePairs.Length; num = checked(num + 1))
		{
			Nemerle.Builtins.Tuple<string, ExtensionPattern> tuple = keyValuePairs[num];
			string field = tuple.Field0;
			ExtensionPattern field2 = tuple.Field1;
			if (field2.Temporary)
			{
				extension_patterns.Remove(field);
			}
		}
	}

	public override TypeInfo MakePointerTypeInfo()
	{
		return null;
	}

	protected void add_member_by_name(IMember m)
	{
		string name = m.Name;
		member_map[name] = ((!member_map.Contains(name)) ? new list<IMember>.Cons(m, list<IMember>.Nil._N_constant_object) : new list<IMember>.Cons(m, member_map[name]));
	}

	public void AddExtensionPattern(ExtensionPattern e)
	{
		if (GetExtensionPattern(e.Name).IsSome)
		{
			Message.Error("the extension pattern `" + Convert.ToString(e.Name) + "' is already defined on " + Convert.ToString(this) + " (or its supertype)");
		}
		else
		{
			extension_patterns[e.Name] = e;
		}
	}

	public option<ExtensionPattern> GetExtensionPattern(string name)
	{
		option<ExtensionPattern> option = extension_patterns.Get(name);
		object result;
		if (option == option<ExtensionPattern>.None._N_constant_object)
		{
			option<TypeInfo> option2 = SuperClass();
			if (option2 is option<TypeInfo>.Some)
			{
				TypeInfo val = ((option<TypeInfo>.Some)option2).val;
				result = val.GetExtensionPattern(name);
			}
			else
			{
				if (option2 != option<TypeInfo>.None._N_constant_object)
				{
					throw new MatchFailureException();
				}
				result = option<ExtensionPattern>.None._N_constant_object;
			}
		}
		else
		{
			result = option;
		}
		return (option<ExtensionPattern>)result;
	}

	public list<TypeInfo> GetNestedTypes(System.Reflection.BindingFlags bindingAttr)
	{
		System.Reflection.BindingFlags flags = bindingAttr | System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Instance;
		List<TypeInfo> list = new List<TypeInfo>();
		if (NamespaceNode.Children != null)
		{
			foreach (NamespaceTree.Node value in NamespaceNode.Children.Values)
			{
				NamespaceTree.Node node = value;
				option<TypeInfo> option = node.LookupValue();
				if (option is option<TypeInfo>.Some)
				{
					TypeInfo val = ((option<TypeInfo>.Some)option).val;
					if (constrain_member(val, flags))
					{
						list.Add(val);
					}
				}
			}
		}
		return list.NToList();
	}

	public list<TypeInfo> GetNestedTypes()
	{
		return GetNestedTypes(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic);
	}

	internal static bool constrain_member(IMember m, System.Reflection.BindingFlags flags)
	{
		bool flag = (m.Attributes & NemerleModifiers.Public) != 0;
		return (flags == System.Reflection.BindingFlags.Public && flag) || (flags == System.Reflection.BindingFlags.NonPublic && !flag) || ((!m.IsStatic || (flags & System.Reflection.BindingFlags.Static) != 0) && (m.IsStatic || (flags & System.Reflection.BindingFlags.Instance) != 0) && (!flag || (flags & System.Reflection.BindingFlags.Public) != 0) && (flag || (flags & System.Reflection.BindingFlags.NonPublic) != 0));
	}

	protected void MakeSingleParm(string name)
	{
		list<IMember> list = special_members[name];
		if (list is list<IMember>.Cons && ((list<IMember>.Cons)list).hd is IMethod)
		{
			IMethod method = (IMethod)((list<IMember>.Cons)list).hd;
			if ((object)((list<IMember>.Cons)list).tl == list<IMember>.Nil._N_constant_object)
			{
				TFunHeader header = method.GetHeader();
				header.Parameters = header.Parameters.Tail;
				return;
			}
		}
		throw new AssertionException("ncc\\hierarchy\\TypeInfo.n", 417, "", "");
	}

	protected void FixupCompare(string name)
	{
		list<IMember> list = special_members[name];
		if (list is list<IMember>.Cons && ((list<IMember>.Cons)list).hd is IMethod)
		{
			IMethod method = (IMethod)((list<IMember>.Cons)list).hd;
			if ((object)((list<IMember>.Cons)list).tl == list<IMember>.Nil._N_constant_object)
			{
				TFunHeader header = method.GetHeader();
				if (InternalType.Boolean == null)
				{
					throw new AssertionException("ncc\\hierarchy\\TypeInfo.n", 426, "InternalType.Boolean != null", "");
				}
				header.ReturnType = InternalType.Boolean;
				return;
			}
		}
		throw new AssertionException("ncc\\hierarchy\\TypeInfo.n", 428, "", "");
	}

	protected static void ForceIntType(string name)
	{
	}

	protected void AddConversion(string name, TypeInfo target)
	{
		AddConversion(name, target, reverse: false);
	}

	protected void AddConversion(string name, TypeInfo target, bool reverse)
	{
		BuiltinMethod builtinMethod = new BuiltinMethod(this, name, GetMemType(), BuiltinMethodKind.ValueTypeConversion._N_constant_object);
		special_members[name] = ((!special_members.Contains(name)) ? new list<IMember>.Cons(builtinMethod, list<IMember>.Nil._N_constant_object) : new list<IMember>.Cons(builtinMethod, special_members[name]));
		TFunHeader header = builtinMethod.GetHeader();
		header.Parameters = header.Parameters.Tail;
		if (reverse)
		{
			header.Parameters.Head.ty = new FixedType.Class(target, list<TypeVar>.Nil._N_constant_object);
			header.ReturnType = self_type;
		}
		else
		{
			header.ReturnType = new FixedType.Class(target, list<TypeVar>.Nil._N_constant_object);
		}
	}

	protected void AddBuiltin(string name, TypeVar left_param_type, TypeVar right_param_type, TypeVar ret_type, string opcode)
	{
		BuiltinMethod builtinMethod = new BuiltinMethod(this, name, left_param_type, right_param_type, ret_type, new BuiltinMethodKind.OpCode(opcode, opcode));
		special_members[name] = new list<IMember>.Cons(builtinMethod, list<IMember>.Nil._N_constant_object);
	}

	protected void AddBuiltin(string name, string opcode)
	{
		BuiltinMethod builtinMethod = new BuiltinMethod(this, name, GetMemType(), new BuiltinMethodKind.OpCode(opcode, opcode));
		special_members[name] = new list<IMember>.Cons(builtinMethod, list<IMember>.Nil._N_constant_object);
	}

	protected void AddBuiltin(string name, TypeVar ret_type, string opcode)
	{
		BuiltinMethod builtinMethod = new BuiltinMethod(this, name, GetMemType(), ret_type, new BuiltinMethodKind.OpCode(opcode, opcode));
		special_members[name] = new list<IMember>.Cons(builtinMethod, list<IMember>.Nil._N_constant_object);
	}

	protected void AddBuiltin(string name, string checkedOpcode, string uncheckedOpcode)
	{
		BuiltinMethod builtinMethod = new BuiltinMethod(this, name, GetMemType(), new BuiltinMethodKind.OpCode(checkedOpcode, uncheckedOpcode));
		special_members[name] = new list<IMember>.Cons(builtinMethod, list<IMember>.Nil._N_constant_object);
	}

	protected void AddBuiltin(string name, IMethod meth)
	{
		BuiltinMethod builtinMethod = new BuiltinMethod(this, name, GetMemType(), new BuiltinMethodKind.CallWithCast(meth));
		special_members[name] = new list<IMember>.Cons(builtinMethod, list<IMember>.Nil._N_constant_object);
	}

	protected void InitBuiltinMembers()
	{
		if (special_members != null)
		{
			return;
		}
		special_members = new Hashtable<string, list<IMember>>();
		if (IsValueType)
		{
			option<TypeInfo> option = SuperClass();
			if (!(option is option<TypeInfo>.Some))
			{
				return;
			}
			TypeInfo val = ((option<TypeInfo>.Some)option).val;
			if ((InternalType.Enum_tc != null && val.Equals(InternalType.Enum_tc)) || val.FullName == "System.Enum")
			{
				AddBuiltin("op_BitwiseOr", "|.u");
				AddBuiltin("op_BitwiseAnd", "&.u");
				AddBuiltin("op_ExclusiveOr", "^.u");
				AddBuiltin("op_OnesComplement", "unary.~.u");
				MakeSingleParm("op_OnesComplement");
				AddBuiltin("op_Equality", "==");
				AddBuiltin("op_Inequality", "!=");
				FixupCompare("op_Equality");
				FixupCompare("op_Inequality");
				list<string>.Cons cons = new list<string>.Cons("SByte", new list<string>.Cons("Int16", new list<string>.Cons("Int32", new list<string>.Cons("Int64", new list<string>.Cons("Byte", new list<string>.Cons("UInt16", new list<string>.Cons("UInt32", new list<string>.Cons("UInt64", list<string>.Nil._N_constant_object))))))));
				list<string> list = cons;
				while (list is list<string>.Cons)
				{
					string hd = ((list<string>.Cons)list).hd;
					list = ((list<string>.Cons)list).tl;
					val = Manager.NameTree.LookupInternalType(new list<string>.Cons("System", new list<string>.Cons(hd, list<string>.Nil._N_constant_object)));
					AddConversion("op_Explicit", val, reverse: true);
					AddConversion("op_Explicit", val, reverse: false);
					list = list;
				}
			}
		}
		else if (IsDelegate)
		{
			if (InternalType.Delegate_Combine == null)
			{
				throw new AssertionException("ncc\\hierarchy\\TypeInfo.n", 547, "InternalType.Delegate_Combine != null", "");
			}
			if (InternalType.Delegate_Remove == null)
			{
				throw new AssertionException("ncc\\hierarchy\\TypeInfo.n", 548, "InternalType.Delegate_Remove != null", "");
			}
			AddBuiltin("op_Addition", InternalType.Delegate_Combine);
			AddBuiltin("op_Subtraction", InternalType.Delegate_Remove);
		}
	}

	public System.Reflection.MemberInfo GetHandle()
	{
		return system_type;
	}

	public override int GetHashCode()
	{
		return id;
	}

	public bool Equals(TypeInfo the_other)
	{
		return the_other != null && id == the_other.id;
	}

	public bool Equals(IMember t)
	{
		return null != t && id == t.GetHashCode();
	}

	public int CompareTo(TypeInfo other)
	{
		return checked(id - other.id);
	}

	public override string ToString()
	{
		object obj;
		if (Typarms.IsEmpty)
		{
			obj = null;
		}
		else
		{
			IEnumerable<StaticTypeVar> source = Typarms;
			Function<StaticTypeVar, string> instance = _N__N_lambda__58027__58038.Instance;
			obj = ".[" + string.Join(", ", source.MapToArray(instance)) + "]";
		}
		string text = (string)obj;
		return Convert.ToString(FullName) + Convert.ToString(text);
	}

	internal override LibraryReference GetLibraryReference()
	{
		return null;
	}

	public abstract override list<IMember> LookupMemberImpl(string name);

	private option<FixedType> GetSignature(IMember mem)
	{
		MemberTypes memberKind = mem.MemberKind;
		object result;
		if (memberKind == MemberTypes.Constructor || memberKind == MemberTypes.Method || (memberKind == MemberTypes.Property && ((IProperty)mem).IsIndexer))
		{
			FixedType fixedType = GetMemType().TypeOfMember(mem).Fix();
			if (fixedType is FixedType.Fun)
			{
				TypeVar from = ((FixedType.Fun)fixedType).from;
				result = new option<FixedType>.Some(from.Fix());
			}
			else
			{
				result = option<FixedType>.None._N_constant_object;
			}
		}
		else
		{
			result = option<FixedType>.None._N_constant_object;
		}
		return (option<FixedType>)result;
	}

	private static bool Hides(Nemerle.Builtins.Tuple<IMember, option<FixedType>> e1, Nemerle.Builtins.Tuple<IMember, option<FixedType>> e2)
	{
		IMember field = e1.Field0;
		option<FixedType> option = e1.Field1;
		IMember field2 = e2.Field0;
		option<FixedType> option2 = e2.Field1;
		int result;
		if (_N_getGenericParamCount_58138(field) != _N_getGenericParamCount_58138(field2))
		{
			result = 0;
		}
		else
		{
			if (option == option<FixedType>.None._N_constant_object)
			{
				if (option2 == option<FixedType>.None._N_constant_object)
				{
					result = 1;
					goto IL_0153;
				}
			}
			else if (option is option<FixedType>.Some && option2 is option<FixedType>.Some)
			{
				FixedType val = ((option<FixedType>.Some)option).val;
				FixedType val2 = ((option<FixedType>.Some)option2).val;
				if (TypeVar.StructuralEquals(val, val2))
				{
					string name = field.Name;
					if (name == "apply" || name == "apply_void")
					{
						if (field is IMethod)
						{
							if (true)
							{
								goto IL_00d7;
							}
						}
						else if (false)
						{
							goto IL_00d7;
						}
						if (false)
						{
							goto IL_00f4;
						}
						goto IL_011b;
					}
					result = 1;
					goto IL_0153;
				}
			}
			result = 0;
		}
		goto IL_0153;
		IL_00f4:
		result = ((((IMethod)field).GetParameters().Length == ((IMethod)field2).GetParameters().Length) ? 1 : 0);
		goto IL_0153;
		IL_0153:
		return (byte)result != 0;
		IL_00d7:
		if (field2 is IMethod)
		{
			goto IL_00f4;
		}
		goto IL_011b;
		IL_011b:
		result = 1;
		goto IL_0153;
	}

	internal list<IMember> RemoveHiddenMembers(list<list<IMember>> members)
	{
		list<IMember> list = null;
		Hashtable<string, list<Nemerle.Builtins.Tuple<IMember, option<FixedType>>>.Cons> hashtable = new Hashtable<string, list<Nemerle.Builtins.Tuple<IMember, option<FixedType>>>.Cons>();
		list = list<IMember>.Nil._N_constant_object;
		list<list<IMember>> list2 = members.Rev();
		while (list2 is list<list<IMember>>.Cons)
		{
			list<IMember> list3 = ((list<list<IMember>>.Cons)list2).hd;
			list2 = ((list<list<IMember>>.Cons)list2).tl;
			list3 = list3;
			while (true)
			{
				_N_closureOf_foreach_loop_58213 n_closureOf_foreach_loop_ = new _N_closureOf_foreach_loop_58213();
				if (!(list3 is list<IMember>.Cons))
				{
					break;
				}
				IMember hd = ((list<IMember>.Cons)list3).hd;
				list3 = ((list<IMember>.Cons)list3).tl;
				hd = hd;
				string name = hd.Name;
				n_closureOf_foreach_loop_._N_elem_58218 = new Nemerle.Builtins.Tuple<IMember, option<FixedType>>(hd, GetSignature(hd));
				if (hashtable.Contains(name))
				{
					list<Nemerle.Builtins.Tuple<IMember, option<FixedType>>>.Cons cons = hashtable[name];
					Function<IMember, option<FixedType>, bool> f = new _N__N_lambda__58197__58233(n_closureOf_foreach_loop_);
					if (!cons.Exists(f))
					{
						hashtable[name] = new list<Nemerle.Builtins.Tuple<IMember, option<FixedType>>>.Cons(n_closureOf_foreach_loop_._N_elem_58218, hashtable[name]);
						list = new list<IMember>.Cons(hd, list);
					}
				}
				else
				{
					hashtable[name] = new list<Nemerle.Builtins.Tuple<IMember, option<FixedType>>>.Cons(n_closureOf_foreach_loop_._N_elem_58218, list<Nemerle.Builtins.Tuple<IMember, option<FixedType>>>.Nil._N_constant_object);
					list = new list<IMember>.Cons(hd, list);
				}
				list3 = list3;
			}
			list2 = list2;
		}
		return list.Rev();
	}

	public list<IMember> LookupMember(string name, bool for_completion = false)
	{
		_N_closureOf_LookupMember_58271 n_closureOf_LookupMember_ = new _N_closureOf_LookupMember_58271();
		n_closureOf_LookupMember_._N_name_58276 = name;
		if (special_members == null)
		{
			InitBuiltinMembers();
		}
		object result;
		if (for_completion)
		{
			list<IMember> members = GetMembers();
			Function<IMember, bool> f = new _N__N_lambda__58247__58284(n_closureOf_LookupMember_);
			result = members.Filter(f);
		}
		else if (special_members.Contains(n_closureOf_LookupMember_._N_name_58276))
		{
			result = special_members[n_closureOf_LookupMember_._N_name_58276];
		}
		else if (n_closureOf_LookupMember_._N_name_58276 == ".ctor")
		{
			result = LookupMemberImpl(n_closureOf_LookupMember_._N_name_58276);
		}
		else
		{
			list<list<IMember>> list = list<list<IMember>>.Nil._N_constant_object;
			TypeInfo typeInfo = this;
			object obj;
			while (true)
			{
				list<IMember> list2 = typeInfo.LookupMemberImpl(n_closureOf_LookupMember_._N_name_58276);
				list = (((object)list2 != list<IMember>.Nil._N_constant_object) ? new list<list<IMember>>.Cons(list2, list) : list);
				if (typeInfo.IsInterface)
				{
					list<FixedType.Class> directSuperTypes = typeInfo.GetDirectSuperTypes();
					if ((object)directSuperTypes == list<FixedType.Class>.Nil._N_constant_object)
					{
						obj = new list<list<IMember>>.Cons(InternalType.Object_tc.LookupMemberImpl(n_closureOf_LookupMember_._N_name_58276), list);
						break;
					}
					list<FixedType.Class> obj2 = directSuperTypes;
					Function<FixedType.Class, list<IMember>> convert = new _N__N_lambda__58260__58318(n_closureOf_LookupMember_);
					obj = obj2.Map(convert) + list;
					break;
				}
				option<TypeInfo> option = typeInfo.SuperClass();
				if (option is option<TypeInfo>.Some)
				{
					typeInfo = ((option<TypeInfo>.Some)option).val;
					list<list<IMember>> obj3 = list;
					typeInfo = typeInfo;
					list = obj3;
					continue;
				}
				if (option == option<TypeInfo>.None._N_constant_object)
				{
					obj = list;
					break;
				}
				throw new MatchFailureException();
			}
			list = (list<list<IMember>>)obj;
			if ((object)list == list<list<IMember>>.Nil._N_constant_object)
			{
				result = list<IMember>.Nil._N_constant_object;
			}
			else if (list is list<list<IMember>>.Cons && (object)((list<list<IMember>>.Cons)list).tl == list<list<IMember>>.Nil._N_constant_object)
			{
				list<IMember> list2 = ((list<list<IMember>>.Cons)list).hd;
				result = list2;
			}
			else
			{
				list<IMember> list2 = RemoveHiddenMembers(list);
				result = list2;
			}
		}
		return (list<IMember>)result;
	}

	public abstract override TypeDeclaration GetTydecl();

	internal Subst ConstructSubst(TypeInfo tc, list<StaticTypeVar> typarms, list<TypeVar> args, bool check_parms)
	{
		_N_closureOf_ConstructSubst_58358 n_closureOf_ConstructSubst_ = new _N_closureOf_ConstructSubst_58358();
		n_closureOf_ConstructSubst_._N_tc_58369 = tc;
		n_closureOf_ConstructSubst_._N__N_closurised_this_ptr_58367 = this;
		Subst subst = null;
		checked
		{
			_recursionLevel++;
			n_closureOf_ConstructSubst_._N_res_58365 = new Subst();
			n_closureOf_ConstructSubst_._N_messenger_58363 = Manager.Solver.CurrentMessenger;
			if (_recursionLevel > 1000)
			{
				if (n_closureOf_ConstructSubst_._N_messenger_58363.NeedMessage)
				{
					n_closureOf_ConstructSubst_._N_messenger_58363.Error("recursive type or recursive constraint detected (" + Convert.ToString(n_closureOf_ConstructSubst_._N_tc_58369) + ")");
				}
				else
				{
					n_closureOf_ConstructSubst_._N_messenger_58363.MarkError();
				}
				return n_closureOf_ConstructSubst_._N_res_58365;
			}
			try
			{
				if (!typarms.IsEmpty || !args.IsEmpty)
				{
					int length = typarms.Length;
					int length2 = args.Length;
					if (length == length2)
					{
						FunctionVoid<StaticTypeVar, TypeVar> f = new _N__N_lambda__58341__58386(n_closureOf_ConstructSubst_);
						NList.Iter2(typarms, args, f);
						if (check_parms)
						{
							FunctionVoid<StaticTypeVar, TypeVar> f2 = new _N__N_lambda__58347__58398(n_closureOf_ConstructSubst_);
							NList.Iter2(typarms, args, f2);
						}
					}
					else if (n_closureOf_ConstructSubst_._N_messenger_58363.NeedMessage)
					{
						n_closureOf_ConstructSubst_._N_messenger_58363.Error("type `" + Convert.ToString(n_closureOf_ConstructSubst_._N_tc_58369.FullName) + "' takes " + Convert.ToString(length) + " argument(s) while " + Convert.ToString(length2) + " were supplied");
					}
					else
					{
						n_closureOf_ConstructSubst_._N_messenger_58363.MarkError();
					}
				}
			}
			finally
			{
				_recursionLevel--;
			}
			return n_closureOf_ConstructSubst_._N_res_58365;
		}
	}

	internal Subst MakeSubst(list<TypeVar> parms)
	{
		return ConstructSubst(this, typarms, parms, check_parms: true);
	}

	internal Subst MakeUncheckedSubst(list<TypeVar> args)
	{
		return ConstructSubst(this, typarms, args, check_parms: false);
	}

	internal Subst FreshSubst()
	{
		return Subst.Fresh(typarms).Field0;
	}

	public override FixedType.Class GetFreshType()
	{
		return (FixedType.Class)FreshSubst().MonoApply(GetMemType());
	}

	public list<FixedType> GetTypeArgumentsForSuperClass(TypeInfo typeInfo)
	{
		if (typeInfo == null)
		{
		}
		if (typeInfo.IsInterface && !IsInterface)
		{
		}
		if (!_superTypesCalculated)
		{
		}
		list<FixedType.Class> valueOrDefault = _superTypeInfosLookup.GetValueOrDefault(typeInfo);
		object result;
		if ((object)valueOrDefault == null)
		{
			result = ((!typeInfo.Equals(this)) ? list<FixedType>.Nil._N_constant_object : Solver.FixedValues(GetMemType().args));
		}
		else if (valueOrDefault is list<FixedType.Class>.Cons)
		{
			if ((object)((list<FixedType.Class>.Cons)valueOrDefault).tl != list<FixedType.Class>.Nil._N_constant_object)
			{
				if (((list<FixedType.Class>.Cons)valueOrDefault).tl is list<FixedType.Class>.Cons)
				{
					throw new AssertionException("ncc\\hierarchy\\TypeInfo.n", 915, "", "");
				}
				throw new MatchFailureException();
			}
			FixedType.Class hd = ((list<FixedType.Class>.Cons)valueOrDefault).hd;
			result = Solver.FixedValues(hd.args);
		}
		else
		{
			result = list<FixedType>.Nil._N_constant_object;
		}
		return (list<FixedType>)result;
	}

	public bool IsDerivedFrom(TypeInfo typeInfo)
	{
		if (typeInfo == null)
		{
			throw new AssertionException("ncc\\hierarchy\\TypeInfo.n", 921, "typeInfo != null", "");
		}
		if (!_superTypesCalculated)
		{
			throw new AssertionException("ncc\\hierarchy\\TypeInfo.n", 922, "_superTypesCalculated", "");
		}
		return typeInfo.Equals(this) || typeInfo.Equals(InternalType.Object_tc) || _superTypeInfosLookup.Contains(typeInfo);
	}

	public bool IsDerivedFrom(FixedType.Class fixedType)
	{
		if (fixedType == null)
		{
			throw new AssertionException("ncc\\hierarchy\\TypeInfo.n", 934, "fixedType != null", "");
		}
		if (!_superTypesCalculated)
		{
			throw new AssertionException("ncc\\hierarchy\\TypeInfo.n", 935, "_superTypesCalculated", "");
		}
		return fixedType.Equals(InternalType.Object) || GetMemType().Equals(fixedType) || _superTypesLookup.Contains(fixedType);
	}

	public FixedType.Class LookupParentClassInstantiation(TypeInfo typeInfo)
	{
		if (typeInfo.IsInterface && !IsInterface)
		{
		}
		list<FixedType.Class> list = LookupParentInstantiations(typeInfo);
		if (list is list<FixedType.Class>.Cons)
		{
			if ((object)((list<FixedType.Class>.Cons)list).tl == list<FixedType.Class>.Nil._N_constant_object)
			{
				return ((list<FixedType.Class>.Cons)list).hd;
			}
		}
		else if ((object)list == list<FixedType.Class>.Nil._N_constant_object)
		{
			throw new AssertionException("ncc\\hierarchy\\TypeInfo.n", 952, "", "no instantiations of parent type was found");
		}
		list = list;
		IEnumerable<FixedType.Class> source = list;
		Function<FixedType.Class, string> instance = _N__N_lambda__58514__58544.Instance;
		throw new AssertionException("ncc\\hierarchy\\TypeInfo.n", 953, "", ("more than one instantiation of parent type was found: " + string.Join(", ", source.MapToArray(instance))).ToString());
	}

	public list<FixedType.Class> LookupParentInstantiations(TypeInfo typeInfo)
	{
		list<FixedType.Class> value = null;
		return (!_superTypeInfosLookup.TryGetValue(typeInfo, out value)) ? list<FixedType.Class>.Nil._N_constant_object : value;
	}

	public bool HasSuperType(TypeInfo typeInfo)
	{
		return _superTypeInfosLookup.Contains(typeInfo);
	}

	public Subst SubtypingSubst(TypeInfo tc)
	{
		object result;
		if (Equals(tc))
		{
			result = new Subst();
		}
		else
		{
			list<FixedType> typeArgumentsForSuperClass = GetTypeArgumentsForSuperClass(tc);
			result = (((object)typeArgumentsForSuperClass != list<FixedType>.Nil._N_constant_object && (object)typeArgumentsForSuperClass != null) ? tc.MakeSubst(Solver.MonoTypes(typeArgumentsForSuperClass)) : new Subst());
		}
		return (Subst)result;
	}

	public override Subst NestingSubst(TypeInfo parent)
	{
		Subst result;
		if (parent.Equals(this))
		{
			result = new Subst();
		}
		else
		{
			Subst subst = new Subst();
			int typarmsCount = parent.TyparmsCount;
			list<TypeVar> b = GetMemType().args.FirstN(typarmsCount);
			TypeInfo declaringType = DeclaringType;
			while (true)
			{
				_N_closureOf_loop_58602 n_closureOf_loop_ = new _N_closureOf_loop_58602();
				list<StaticTypeVar> a = declaringType.Typarms.FirstN(typarmsCount);
				n_closureOf_loop_._N__N_obj_cache_58607 = subst;
				FunctionVoid<StaticTypeVar, TypeVar> f = new _N__N_method_lambda__58611(n_closureOf_loop_);
				NList.Iter2(a, b, f);
				if (declaringType.Equals(parent))
				{
					break;
				}
				declaringType = declaringType.DeclaringType;
			}
			result = subst;
		}
		return result;
	}

	public abstract override option<TypeInfo> SuperClass();

	public abstract override list<IMember> GetMembers();

	public abstract override list<IMember> GetMembers(System.Reflection.BindingFlags bindingAttr);

	public abstract override list<IField> GetFields(System.Reflection.BindingFlags bindingAttr);

	public abstract override list<IMethod> GetConstructors(System.Reflection.BindingFlags bindingAttr);

	public list<FixedType.Class> GetSuperTypes()
	{
		return _superTypes;
	}

	public abstract override list<FixedType.Class> GetDirectSuperTypes();

	public abstract override IField GetConstantObject();

	public abstract override bool HasAttribute(TypeInfo attribute);

	public FixedType.Class GetMemType()
	{
		if (self_type == null)
		{
			throw new AssertionException("ncc\\hierarchy\\TypeInfo.n", 1087, "self_type != null", FullName.ToString());
		}
		return self_type;
	}

	public abstract override bool CanAccess(TypeInfo source);

	protected internal static list<FixedType.Class> NormalizeSupertypes(list<FixedType.Class> direct_supertypes)
	{
		list<FixedType.Class> list = null;
		list = list<FixedType.Class>.Nil._N_constant_object;
		list<FixedType.Class> list2 = direct_supertypes;
		while (true)
		{
			_N_closureOf_foreach_loop_58691 n_closureOf_foreach_loop_ = new _N_closureOf_foreach_loop_58691();
			if (!(list2 is list<FixedType.Class>.Cons))
			{
				break;
			}
			FixedType.Class hd = ((list<FixedType.Class>.Cons)list2).hd;
			list2 = ((list<FixedType.Class>.Cons)list2).tl;
			n_closureOf_foreach_loop_._N_t_58696 = hd;
			Function<FixedType.Class, bool> f = new _N__N_lambda__58684__58706(n_closureOf_foreach_loop_);
			if (!direct_supertypes.Exists(f))
			{
				list = new list<FixedType.Class>.Cons(n_closureOf_foreach_loop_._N_t_58696, list);
			}
			list2 = list2;
		}
		return list;
	}

	private void __fake()
	{
		__fake();
		SystemTypeClass systemTypeCache = SystemTypeCache;
		InternalTypeClass internalType = InternalType;
	}

	public override bool Equals(object other)
	{
		return other == this || (other is IMember && Equals((IMember)other));
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
		list<FixedType.Class> superTypes = _superTypes;
		if (superTypes != null)
		{
			superTypes = superTypes;
			while (superTypes is list<FixedType.Class>.Cons)
			{
				FixedType.Class hd = ((list<FixedType.Class>.Cons)superTypes).hd;
				superTypes = ((list<FixedType.Class>.Cons)superTypes).tl;
				((ISupportRelocation)hd).RelocateImpl(_info);
				superTypes = superTypes;
			}
		}
		list<StaticTypeVar> list = typarms;
		if (list != null)
		{
			list = list;
			while (list is list<StaticTypeVar>.Cons)
			{
				StaticTypeVar hd2 = ((list<StaticTypeVar>.Cons)list).hd;
				list = ((list<StaticTypeVar>.Cons)list).tl;
				((ISupportRelocation)hd2).RelocateImpl(_info);
				list = list;
			}
		}
	}

	private static int _N_getGenericParamCount_58138(IMember member)
	{
		return (member is IMethod) ? ((IMethod)member).Header.TypeParameters.Length : 0;
	}

	[SpecialName]
	FixedType IMember.GetMemType()
	{
		return GetMemType();
	}
}
