using System;
using System.Diagnostics;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Compiler.Parsetree;
using Nemerle.Compiler.Typedtree;
using Nemerle.Core;

namespace Nemerle.Compiler;

public class FieldBuilder : MemberBuilder, IField
{
	private sealed class _N_closureOf_Compile_72016
	{
		internal FieldBuilder _N__N_closurised_this_ptr_72021;

		internal _N_closureOf_Compile_72016()
		{
		}
	}

	private sealed class _N__N_lambda__72005__72026 : Function<AttributeTargets, CustomAttributeBuilder, bool, string>
	{
		[SpecialName]
		private _N_closureOf_Compile_72016 _N_Compile_closure_72030;

		public _N__N_lambda__72005__72026(_N_closureOf_Compile_72016 _N_Compile_closure_72030)
		{
			this._N_Compile_closure_72030 = _N_Compile_closure_72030;
		}

		[SpecialName]
		public sealed override string apply(AttributeTargets target, CustomAttributeBuilder a, bool shouldEmit)
		{
			object result;
			if ((target & AttributeTargets.Field) != 0)
			{
				if (shouldEmit)
				{
					_N_Compile_closure_72030._N__N_closurised_this_ptr_72021.field_builder.SetCustomAttribute(a);
				}
				result = null;
			}
			else
			{
				result = "field " + _N_Compile_closure_72030._N__N_closurised_this_ptr_72021.ToString();
			}
			return (string)result;
		}
	}

	private System.Reflection.Emit.FieldBuilder field_builder;

	private Literal const_value;

	private bool has_been_assigned = false;

	private Location _initializerLocation;

	public new ClassMember.Field Ast => (ClassMember.Field)base.Ast;

	public override MemberTypes MemberKind => MemberTypes.Field;

	public bool IsInitializerPresent => InitializerLocation.FileIndex != 0;

	public Token.BracesGroup InitializerTokens => LookupInitializerMethod().BodyTokens;

	public PExpr InitializerParsed => LookupInitializerMethod().BodyParsed;

	public TExpr InitializerTyped => LookupInitializerMethod().BodyTyped;

	public bool IsMutable => (attributes & NemerleModifiers.Mutable) != 0;

	public bool IsVolatile => (attributes & NemerleModifiers.Volatile) != 0;

	public bool IsLiteral => !IsMutable && IsStatic && const_value != null;

	public bool HasBeenAssigned
	{
		get
		{
			return has_been_assigned;
		}
		set
		{
			if (!has_been_assigned)
			{
				HasBeenUsed = value;
				has_been_assigned = true;
			}
		}
	}

	protected override AttributeTargets MacroTarget => AttributeTargets.Field;

	protected override list<SyntaxElement> MacroSelfParams => new list<SyntaxElement>.Cons(new SyntaxElement.TypeBuilder(declaring_type), new list<SyntaxElement>.Cons(new SyntaxElement.FieldBuilder(this), list<SyntaxElement>.Nil._N_constant_object));

	public Literal ConstValue
	{
		[DebuggerStepThrough]
		[CompilerGenerated]
		get
		{
			return const_value;
		}
		[DebuggerStepThrough]
		[CompilerGenerated]
		set
		{
			const_value = value;
		}
	}

	public Location InitializerLocation
	{
		[DebuggerStepThrough]
		[CompilerGenerated]
		get
		{
			return _initializerLocation;
		}
	}

	internal override void CreateEmitBuilder(System.Reflection.Emit.TypeBuilder tb)
	{
		FieldAttributes fieldAttributes = default(FieldAttributes);
		NemerleModifiers nemerleModifiers = Attributes;
		fieldAttributes = FieldAttributes.PrivateScope;
		if ((nemerleModifiers & NemerleModifiers.Public) != 0)
		{
			fieldAttributes |= FieldAttributes.Public;
		}
		if ((nemerleModifiers & NemerleModifiers.Private) != 0)
		{
			fieldAttributes |= FieldAttributes.Private;
		}
		if ((nemerleModifiers & NemerleModifiers.Internal) != 0)
		{
			fieldAttributes = (((nemerleModifiers & NemerleModifiers.Protected) == 0) ? (fieldAttributes | FieldAttributes.Assembly) : (fieldAttributes | FieldAttributes.FamORAssem));
		}
		else if ((nemerleModifiers & NemerleModifiers.Protected) != 0)
		{
			fieldAttributes |= FieldAttributes.Family;
		}
		if ((nemerleModifiers & NemerleModifiers.Static) != 0)
		{
			fieldAttributes |= FieldAttributes.Static;
		}
		if ((nemerleModifiers & NemerleModifiers.SpecialName) != 0)
		{
			fieldAttributes |= FieldAttributes.SpecialName | FieldAttributes.RTSpecialName;
		}
		if ((nemerleModifiers & (NemerleModifiers.Mutable | NemerleModifiers.CompilerMutable)) == 0)
		{
			fieldAttributes |= FieldAttributes.InitOnly;
		}
		fieldAttributes = fieldAttributes;
		if (IsLiteral)
		{
			fieldAttributes = (fieldAttributes | FieldAttributes.Literal) & ~FieldAttributes.InitOnly;
		}
		if (Name != "value__")
		{
			fieldAttributes &= ~FieldAttributes.RTSpecialName;
		}
		field_builder = tb.DefineField(Name, GetMemType().GetSystemType(), required_modifiers.ToArray(), optional_modifiers.ToArray(), fieldAttributes);
		if (IsLiteral)
		{
			field_builder.SetConstant(const_value.AsObject(InternalType));
		}
	}

	internal override void Compile()
	{
		_N_closureOf_Compile_72016 n_closureOf_Compile_ = new _N_closureOf_Compile_72016();
		n_closureOf_Compile_._N__N_closurised_this_ptr_72021 = this;
		base.Compile();
		if (!modifiers.IsEmpty)
		{
			AttributesAndModifiers attributesAndModifiers = modifiers;
			TypeBuilder ti = declaring_type;
			Function<AttributeTargets, CustomAttributeBuilder, bool, string> adder = new _N__N_lambda__72005__72026(n_closureOf_Compile_);
			attributesAndModifiers.SaveCustomAttributes(ti, adder);
		}
		if (IsVolatile)
		{
			CustomAttributeBuilder customAttribute = Manager.AttributeCompiler.MakeEmittedAttribute(SystemTypeCache.VolatileModifier);
			field_builder.SetCustomAttribute(customAttribute);
		}
		if (!IsMutable && !IsLiteral && (attributes & NemerleModifiers.CompilerMutable) != 0)
		{
			CustomAttributeBuilder customAttribute = Manager.AttributeCompiler.MakeEmittedAttribute(SystemTypeCache.ImmutableAttribute);
			field_builder.SetCustomAttribute(customAttribute);
		}
	}

	public FieldBuilder(TypeBuilder par, ClassMember.Field fieldAst)
		: base(par, fieldAst)
	{
		_initializerLocation = fieldAst.BodyLocation;
		PExpr pExpr = fieldAst.ty;
		if (pExpr is PExpr.Wildcard)
		{
			Message.Error("type inference for fields is available only when assigning literal value to them");
		}
		ty = par.BindFixedType(fieldAst.ty);
		if (ty.Equals(InternalType.Void))
		{
			Message.Error(Convert.ToString(this) + " has void type, which is not allowed");
		}
		ty.CheckAccessibility(this, accessibility);
	}

	public void EnsureCompiled()
	{
		LookupInitializerMethod().EnsureCompiled();
	}

	public MethodBuilder LookupInitializerMethod()
	{
		if (IsInitializerPresent)
		{
			if (!DeclaringType.LookupMemberAvailable)
			{
				throw new AssertionException("ncc\\hierarchy\\ClassMembers.n", 553, "DeclaringType.LookupMemberAvailable", "");
			}
			list<IMember> list = DeclaringType.LookupMemberImpl("_N_field_initialiser__" + Name);
			if (list is list<IMember>.Cons && ((list<IMember>.Cons)list).hd is MethodBuilder)
			{
				MethodBuilder result = (MethodBuilder)((list<IMember>.Cons)list).hd;
				if ((object)((list<IMember>.Cons)list).tl == list<IMember>.Nil._N_constant_object)
				{
					return result;
				}
			}
			throw new ApplicationException("Initialiser for " + Convert.ToString(Name) + " not found.");
		}
		throw new ApplicationException("IsInitializerPresent == false");
	}

	public override void ResetCodeCache()
	{
		LookupInitializerMethod().ResetCodeCache();
	}

	public Literal GetValue()
	{
		if (!IsLiteral)
		{
			throw new AssertionException("ncc\\hierarchy\\ClassMembers.n", 631, "IsLiteral", Name.ToString());
		}
		return const_value;
	}

	public System.Reflection.Emit.FieldBuilder GetFieldInfo()
	{
		if (!(field_builder != null))
		{
			throw new AssertionException("ncc\\hierarchy\\ClassMembers.n", 637, "field_builder != null", Name.ToString());
		}
		return field_builder;
	}

	public override System.Reflection.MemberInfo GetHandle()
	{
		if (!(field_builder != null))
		{
			throw new AssertionException("ncc\\hierarchy\\ClassMembers.n", 643, "field_builder != null", Name.ToString());
		}
		return field_builder;
	}

	public override void CheckAttributes()
	{
		if (declaring_type.IsInterface)
		{
			Message.FatalError2(loc, "fields cannot be defined inside interface");
		}
		check_for_invalid_attr(NemerleModifiers.Extern, "extern");
		check_for_invalid_attr(NemerleModifiers.Abstract, "abstract");
		check_for_invalid_attr(NemerleModifiers.Virtual, "virtual");
		check_for_invalid_attr(NemerleModifiers.Sealed, "sealed");
		check_for_invalid_attr(NemerleModifiers.Override, "override");
		check_for_invalid_attr(NemerleModifiers.Struct, "struct");
		check_for_invalid_attr(NemerleModifiers.Macro, "macro");
		check_for_invalid_attr(NemerleModifiers.Partial, "partial");
		option<string> option = TypeBuilder.CheckAccessAttributes(attributes);
		if (option is option<string>.Some)
		{
			string val = ((option<string>.Some)option).val;
			Message.FatalError2(loc, Convert.ToString(val) + " for " + Convert.ToString(this));
		}
		if (!IsMutable && IsVolatile)
		{
			Message.Error(loc, "only mutable fields are allowed to be volatile in " + Convert.ToString(this));
		}
		if (declaring_type.IsStruct && IsProtected)
		{
			string val = ((!IsInternal) ? "protected" : "protected internal");
			Message.Error(loc, string.Concat(string.Concat("fields defined in a struct are not allowed to be " + val, "in "), ToString()));
		}
	}

	[CompilerGenerated]
	internal override void RelocateImplInternal(RelocationInfo _info)
	{
		if (!_info.VisitedObjects.ContainsKey(this))
		{
			base.RelocateImplInternal(_info);
			_info.VisitedObjects[this] = 0;
			_initializerLocation = Completion.Relocate(_initializerLocation, _info);
			const_value?.RelocateImplInternal(_info);
		}
	}

	[SpecialName]
	FieldInfo IField.GetFieldInfo()
	{
		return GetFieldInfo();
	}
}
