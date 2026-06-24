using System;
using System.Diagnostics;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Collections;
using Nemerle.Compiler.Parsetree;
using Nemerle.Core;

namespace Nemerle.Compiler;

public class PropertyBuilder : MemberBuilder, IProperty
{
	private sealed class _N__N_lambda__72223__72248 : Function<FixedType, Type>
	{
		[SpecialName]
		public static readonly _N__N_lambda__72223__72248 Instance = new _N__N_lambda__72223__72248();

		[SpecialName]
		public sealed override Type apply(FixedType _N__72222)
		{
			return _N__72222.GetSystemType();
		}
	}

	private sealed class _N_closureOf_Compile_72371
	{
		internal PropertyBuilder _N__N_closurised_this_ptr_72376;

		internal _N_closureOf_Compile_72371()
		{
		}
	}

	private sealed class _N__N_lambda__72281__72381 : Function<AttributeTargets, CustomAttributeBuilder, bool, string>
	{
		[SpecialName]
		private _N_closureOf_Compile_72371 _N_Compile_closure_72385;

		public _N__N_lambda__72281__72381(_N_closureOf_Compile_72371 _N_Compile_closure_72385)
		{
			this._N_Compile_closure_72385 = _N_Compile_closure_72385;
		}

		[SpecialName]
		public sealed override string apply(AttributeTargets target, CustomAttributeBuilder a, bool shouldEmit)
		{
			object result;
			if ((target & AttributeTargets.Property) != 0)
			{
				if (shouldEmit)
				{
					_N_Compile_closure_72385._N__N_closurised_this_ptr_72376.property_builder.SetCustomAttribute(a);
				}
				result = null;
			}
			else
			{
				result = "property " + _N_Compile_closure_72385._N__N_closurised_this_ptr_72376.ToString();
			}
			return (string)result;
		}
	}

	private sealed class _N_closureOf__ctor_72431
	{
		internal TypeBuilder _N_par_72438;

		internal PropertyBuilder _N__N_closurised_this_ptr_72436;

		internal _N_closureOf__ctor_72431()
		{
		}
	}

	private sealed class _N__N_lambda__72414__72446 : Function<PParameter, FixedType>
	{
		[SpecialName]
		private _N_closureOf__ctor_72431 _N__ctor_closure_72450;

		public _N__N_lambda__72414__72446(_N_closureOf__ctor_72431 _N__ctor_closure_72450)
		{
			this._N__ctor_closure_72450 = _N__ctor_closure_72450;
		}

		[SpecialName]
		public sealed override FixedType apply(PParameter parm)
		{
			return _N__ctor_closure_72450._N_par_72438.BindFixedType(parm.Type);
		}
	}

	private readonly bool is_mutable;

	private readonly MethodBuilder getter;

	private readonly MethodBuilder setter;

	internal readonly list<FixedType> parms;

	private IProperty parent_property;

	protected Location _bodyLocation;

	internal System.Reflection.Emit.PropertyBuilder property_builder;

	private readonly option<IMember> autoPropertyField;

	private readonly bool isAutoProperty;

	public new ClassMember.Property Ast => (ClassMember.Property)base.Ast;

	public bool IsMutable => is_mutable;

	public bool IsIndexer
	{
		get
		{
			list<FixedType> list = parms;
			return (object)list != list<FixedType>.Nil._N_constant_object || 1 == 0;
		}
	}

	public override MemberTypes MemberKind => MemberTypes.Property;

	public override bool HasBeenUsed
	{
		set
		{
			base.HasBeenUsed = value;
			if (setter != null)
			{
				setter.HasBeenUsed = value;
			}
			if (getter != null)
			{
				getter.HasBeenUsed = value;
			}
		}
	}

	public IMethod Getter => GetGetter();

	public bool CanRead => Getter != null;

	public IMethod Setter => GetSetter();

	public bool CanWrite => Setter != null;

	protected override AttributeTargets MacroTarget => AttributeTargets.Property;

	protected override list<SyntaxElement> MacroSelfParams => new list<SyntaxElement>.Cons(new SyntaxElement.TypeBuilder(declaring_type), new list<SyntaxElement>.Cons(new SyntaxElement.PropertyBuilder(this), list<SyntaxElement>.Nil._N_constant_object));

	public override Location BodyLocation
	{
		[DebuggerStepThrough]
		[CompilerGenerated]
		get
		{
			return _bodyLocation;
		}
	}

	public option<IMember> AutoPropertyField
	{
		[DebuggerStepThrough]
		[CompilerGenerated]
		get
		{
			return autoPropertyField;
		}
	}

	public bool IsAutoProperty
	{
		[CompilerGenerated]
		[DebuggerStepThrough]
		get
		{
			return isAutoProperty;
		}
	}

	internal override void CreateEmitBuilder(System.Reflection.Emit.TypeBuilder tb)
	{
		PropertyAttributes propertyAttributes = default(PropertyAttributes);
		NemerleModifiers nemerleModifiers = Attributes;
		propertyAttributes = PropertyAttributes.None;
		if ((nemerleModifiers & NemerleModifiers.SpecialName) != 0)
		{
			propertyAttributes |= PropertyAttributes.SpecialName | PropertyAttributes.RTSpecialName;
		}
		propertyAttributes = propertyAttributes;
		Type returnType = ((!IsIndexer) ? GetMemType().GetSystemType() : ((FixedType.Fun)GetMemType()).to.GetSystemType());
		list<FixedType> list = parms;
		Function<FixedType, Type> instance = _N__N_lambda__72223__72248.Instance;
		Type[] parameterTypes = list.MapToArray(instance);
		IMethod method = GetGetter();
		Nemerle.Builtins.Tuple<Type[], Type[]> tuple = ((method != null) ? new Nemerle.Builtins.Tuple<Type[], Type[]>(((MethodBuilder)method).Header.GetRetTypeRequiredModifiers(), ((MethodBuilder)method).Header.GetRetTypeOptionalModifiers()) : new Nemerle.Builtins.Tuple<Type[], Type[]>(null, null));
		Type[] field = tuple.Field0;
		Type[] field2 = tuple.Field1;
		MethodBuilder methodBuilder = (MethodBuilder)GetSetter();
		Nemerle.Builtins.Tuple<Type[][], Type[][]> tuple2 = ((methodBuilder != null) ? new Nemerle.Builtins.Tuple<Type[][], Type[][]>(_N_chop_72272(methodBuilder.Header.GetParamTypeRequiredModifiers()), _N_chop_72272(methodBuilder.Header.GetParamTypeOptionalModifiers())) : new Nemerle.Builtins.Tuple<Type[][], Type[][]>(null, null));
		Type[][] field3 = tuple2.Field0;
		Type[][] field4 = tuple2.Field1;
		property_builder = tb.DefineProperty(Name, propertyAttributes, returnType, field, field2, parameterTypes, field3, field4);
	}

	internal override void Compile()
	{
		_N_closureOf_Compile_72371 n_closureOf_Compile_ = new _N_closureOf_Compile_72371();
		n_closureOf_Compile_._N__N_closurised_this_ptr_72376 = this;
		base.Compile();
		if (!modifiers.IsEmpty)
		{
			AttributesAndModifiers attributesAndModifiers = modifiers;
			TypeBuilder ti = declaring_type;
			Function<AttributeTargets, CustomAttributeBuilder, bool, string> adder = new _N__N_lambda__72281__72381(n_closureOf_Compile_);
			attributesAndModifiers.SaveCustomAttributes(ti, adder);
		}
		object declaringType = DeclaringType;
		if (getter != null && getter.DeclaringType == declaringType)
		{
			property_builder.SetGetMethod(getter.GetMethodInfo());
		}
		if (setter != null && setter.DeclaringType == declaringType)
		{
			property_builder.SetSetMethod(setter.GetMethodInfo());
		}
	}

	public PropertyBuilder(TypeBuilder par, ClassMember.Property propertyAst)
	{
		_N_closureOf__ctor_72431 n_closureOf__ctor_ = new _N_closureOf__ctor_72431
		{
			_N_par_72438 = par
		};
		parent_property = null;
		autoPropertyField = option<IMember>.None._N_constant_object;
		base._002Ector(n_closureOf__ctor_._N_par_72438, propertyAst);
		n_closureOf__ctor_._N__N_closurised_this_ptr_72436 = this;
		if (propertyAst.getter.IsNone && propertyAst.setter.IsNone)
		{
			Message.Error(propertyAst.BodyLocation, "expecting property getter/setter");
		}
		_bodyLocation = propertyAst.BodyLocation;
		is_mutable = Option.IsSome(propertyAst.setter);
		ty = n_closureOf__ctor_._N_par_72438.BindFixedType(propertyAst.SignatureType);
		list<PParameter> parameters = propertyAst.parameters;
		Function<PParameter, FixedType> convert = new _N__N_lambda__72414__72446(n_closureOf__ctor_);
		parms = parameters.Map(convert);
		if (n_closureOf__ctor_._N_par_72438.IsInterface)
		{
			if (propertyAst.initializer.IsSome)
			{
				Message.Error("initializer cannot be used in interfaces");
			}
		}
		else
		{
			ClassMember.Field field = MainParser.TryExpandAutoproperty(propertyAst);
			if (field != null)
			{
				isAutoProperty = true;
				MemberBuilder memberBuilder = n_closureOf__ctor_._N_par_72438.DefineAndReturn(field);
				if (memberBuilder != null)
				{
					autoPropertyField = new option<IMember>.Some(memberBuilder);
				}
			}
		}
		getter = _N_process_accessor_72468(n_closureOf__ctor_, propertyAst.getter);
		setter = _N_process_accessor_72468(n_closureOf__ctor_, propertyAst.setter);
		ty.CheckAccessibility(this, accessibility);
		m_has_been_used = true;
	}

	public System.Reflection.Emit.PropertyBuilder GetPropertyInfo()
	{
		if (!(property_builder != null))
		{
			throw new AssertionException("ncc\\hierarchy\\ClassMembers.n", 800, "property_builder != null", "");
		}
		return property_builder;
	}

	public IMethod GetGetter()
	{
		return (getter != null || parent_property == null) ? ((IMethod)getter) : parent_property.GetGetter();
	}

	public IMethod GetSetter()
	{
		return (setter != null || parent_property == null) ? ((IMethod)setter) : parent_property.GetSetter();
	}

	public list<FixedType> GetParameters()
	{
		return parms;
	}

	public void UpdateParentProperty(IProperty parent_property)
	{
		this.parent_property = parent_property;
	}

	public override System.Reflection.MemberInfo GetHandle()
	{
		if (!(property_builder != null))
		{
			throw new AssertionException("ncc\\hierarchy\\ClassMembers.n", 838, "property_builder != null", "");
		}
		return property_builder;
	}

	public override void CheckAttributes()
	{
		if (IsStatic && IsIndexer)
		{
			Message.FatalError2(loc, "indexer properties are not allowed to be static in " + Convert.ToString(this));
		}
		check_method_like_attributes("property", "properties");
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
		option<IMember> option = autoPropertyField;
		if (option is option<IMember>.Some && ((option<IMember>.Some)option).val is ISupportRelocation)
		{
			ISupportRelocation supportRelocation = (ISupportRelocation)((option<IMember>.Some)option).val;
			supportRelocation.RelocateImpl(_info);
		}
		_bodyLocation = Completion.Relocate(_bodyLocation, _info);
		IProperty property = parent_property;
		if (property != null)
		{
			((ISupportRelocation)property).RelocateImpl(_info);
		}
		list<FixedType> list = parms;
		if (list != null)
		{
			list = list;
			while (list is list<FixedType>.Cons)
			{
				FixedType hd = ((list<FixedType>.Cons)list).hd;
				list = ((list<FixedType>.Cons)list).tl;
				((ISupportRelocation)hd).RelocateImpl(_info);
				list = list;
			}
		}
		setter?.RelocateImplInternal(_info);
		getter?.RelocateImplInternal(_info);
	}

	private static Type[][] _N_chop_72272(Type[][] a)
	{
		return a?.ChopLastN(1);
	}

	private MethodBuilder _N_process_accessor_72468(_N_closureOf__ctor_72431 _N__ctor_cp_72467, option<ClassMember.Function> _N_wildcard_3367)
	{
		object result;
		if (_N_wildcard_3367 is option<ClassMember.Function>.Some)
		{
			ClassMember.Function val = ((option<ClassMember.Function>.Some)_N_wildcard_3367).val;
			if (val.Env == null)
			{
				val.SetEnv(Env);
			}
			Location location = val.Location;
			bool flag = location.FileIndex != 0;
			if (flag)
			{
				LocationStack.Push(location);
			}
			try
			{
				MemberBuilder.UpdateEmbeddedModifiers(attributes, ref val.modifiers.mods);
			}
			finally
			{
				if (flag)
				{
					LocationStack.RemoveTop();
				}
			}
			MethodBuilder methodBuilder = Manager.ComponentsFactory.CreateMethodBuilder(_N__ctor_cp_72467._N_par_72438, val, is_property: true);
			methodBuilder.MarkWithSpecialName();
			declaring_type.AddMember(methodBuilder);
			result = methodBuilder;
		}
		else
		{
			if (_N_wildcard_3367 != option<ClassMember.Function>.None._N_constant_object)
			{
				throw new MatchFailureException();
			}
			result = null;
		}
		return (MethodBuilder)result;
	}

	[SpecialName]
	PropertyInfo IProperty.GetPropertyInfo()
	{
		return GetPropertyInfo();
	}
}
