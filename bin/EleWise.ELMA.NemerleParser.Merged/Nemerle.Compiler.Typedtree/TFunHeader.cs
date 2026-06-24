using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Collections;
using Nemerle.Compiler.Parsetree;
using Nemerle.Core;
using Nemerle.Internal;

namespace Nemerle.Compiler.Typedtree;

public class TFunHeader : TypedBase, IComparable<TFunHeader>, IParametersProvider
{
	private sealed class _N__N_lambda__107922__107929 : Function<TParameter, string>
	{
		[SpecialName]
		public static readonly _N__N_lambda__107922__107929 Instance = new _N__N_lambda__107922__107929();

		[SpecialName]
		public sealed override string apply(TParameter x)
		{
			return Convert.ToString(x);
		}
	}

	private sealed class _N__N_lambda__107955__107974 : Function<Type[], bool>
	{
		[SpecialName]
		public static readonly _N__N_lambda__107955__107974 Instance = new _N__N_lambda__107955__107974();

		[SpecialName]
		public sealed override bool apply(Type[] x)
		{
			return x == null;
		}
	}

	private sealed class _N__N_lambda__107994__108013 : Function<Type[], bool>
	{
		[SpecialName]
		public static readonly _N__N_lambda__107994__108013 Instance = new _N__N_lambda__107994__108013();

		[SpecialName]
		public sealed override bool apply(Type[] x)
		{
			return x == null;
		}
	}

	private sealed class _N__N_lambda__108025__108032 : Function<TParameter, PParameter>
	{
		[SpecialName]
		public static readonly _N__N_lambda__108025__108032 Instance = new _N__N_lambda__108025__108032();

		[SpecialName]
		public sealed override PParameter apply(TParameter _N__108024)
		{
			return _N__108024.AsParsed();
		}
	}

	private sealed class _N__N_lambda__108044__108051 : Function<TParameter, PExpr>
	{
		[SpecialName]
		public static readonly _N__N_lambda__108044__108051 Instance = new _N__N_lambda__108044__108051();

		[SpecialName]
		public sealed override PExpr apply(TParameter _N__108043)
		{
			return _N__108043.ReferencingExpr;
		}
	}

	private sealed class _N__N_lambda__108067__108075 : Function<StaticTypeVar, PExpr>
	{
		[SpecialName]
		public static readonly _N__N_lambda__108067__108075 Instance = new _N__N_lambda__108067__108075();

		[SpecialName]
		public sealed override PExpr apply(StaticTypeVar x)
		{
			return Macros.TypedChoose(new FixedType.StaticTypeVarRef(x));
		}
	}

	public readonly int id;

	public readonly TypeVarEnv tenv;

	public list<Type> ret_type_required_modifiers;

	public list<Type> ret_type_optional_modifiers;

	public FunctionUsage usage;

	private FunBody _body;

	public bool has_1st_class_child;

	public bool cannot_inline;

	public list<LocalValue> closure_vars;

	public LocalValue decl;

	public list<LocalValue> all_locals;

	internal list<TFunHeader> children_funs;

	internal bool uses_try_block;

	internal TypeVar yield_type;

	internal int is_in_closure_of;

	internal list<TFunHeader> used_closures;

	internal IMethod static_method;

	internal list<TypeVar> typarms_to_pass;

	internal FixedType.Class closure_type;

	public string Name { get; internal set; }

	public TypeVar ReturnType { get; internal set; }

	public Location ReturnTypeLocation { get; internal set; }

	public list<TParameter> Parameters { get; internal set; }

	public list<StaticTypeVar> TypeParameters { get; internal set; }

	public TypeVarEnv TypeVarEnv => tenv;

	public FunBody Body => body;

	public PExpr ParsedBody { get; private set; }

	public TExpr TypedBody { get; private set; }

	public list<LocalValue> ClosureVars => closure_vars;

	public LocalValue Declaration => decl;

	public Function_decl Parsed { get; set; }

	[Obsolete("Use ReturnTypeLocation instead of RetTypeLoc")]
	public Location RetTypeLoc => ReturnTypeLocation;

	[Obsolete("Use ReturnType instead of RetType")]
	public TypeVar RetType => ReturnType;

	[Obsolete("Use Name instead of name")]
	public string name => Name;

	[Obsolete("Use ReturnType instead of ret_type")]
	public TypeVar ret_type => ReturnType;

	[Obsolete("Use ReturnTypeLocation instead of ret_type_loc")]
	public Location ret_type_loc => ReturnTypeLocation;

	[Obsolete("Use Parameters instead of parms")]
	public list<TParameter> parms => Parameters;

	[Obsolete("Use TypeParameters instead of typarms")]
	public list<StaticTypeVar> typarms => TypeParameters;

	public FunBody body
	{
		get
		{
			return _body;
		}
		set
		{
			if (value is FunBody.Parsed)
			{
				PExpr pExpr = (ParsedBody = ((FunBody.Parsed)value).expr);
			}
			else if (value is FunBody.Typed)
			{
				TExpr tExpr = (TypedBody = ((FunBody.Typed)value).expr);
			}
			else if (value != FunBody.ILed._N_constant_object && value != FunBody.Abstract._N_constant_object)
			{
			}
			_body = value;
		}
	}

	public bool ConvertToLoopWithClosure { get; internal set; }

	public list<PParameter> ParametersDeclarations
	{
		get
		{
			list<TParameter> parameters = Parameters;
			Function<TParameter, PParameter> instance = _N__N_lambda__108025__108032.Instance;
			return parameters.Map(instance);
		}
	}

	public list<PExpr> ParametersReferences
	{
		get
		{
			list<TParameter> parameters = Parameters;
			Function<TParameter, PExpr> instance = _N__N_lambda__108044__108051.Instance;
			return parameters.Map(instance);
		}
	}

	public TFunHeader(Location loc, string name, [Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] TypeVar ret_type, Location ret_type_loc, list<TParameter> parms, list<StaticTypeVar> typarms, TypeVarEnv tenv)
	{
		if (ret_type == null)
		{
			throw new ArgumentNullException("ret_type", "The ``NotNull'' contract of parameter ``ret_type'' has been violated. See ncc\\typing\\TypedTree.n:346:18:346:26: .");
		}
		ret_type_required_modifiers = list<Type>.Nil._N_constant_object;
		ret_type_optional_modifiers = list<Type>.Nil._N_constant_object;
		closure_vars = list<LocalValue>.Nil._N_constant_object;
		all_locals = list<LocalValue>.Nil._N_constant_object;
		children_funs = list<TFunHeader>.Nil._N_constant_object;
		base._002Ector(loc);
		Name = name;
		ReturnType = ret_type;
		ReturnTypeLocation = ret_type_loc;
		Parameters = parms;
		TypeParameters = typarms;
		this.tenv = tenv;
		id = ret_type.Manager.GetNewId();
		usage = FunctionUsage.NotUsed;
	}

	public void Reset()
	{
		body = null;
		has_1st_class_child = false;
		cannot_inline = false;
		ConvertToLoopWithClosure = false;
		closure_vars = list<LocalValue>.Nil._N_constant_object;
		decl = null;
		all_locals = list<LocalValue>.Nil._N_constant_object;
		children_funs = list<TFunHeader>.Nil._N_constant_object;
		uses_try_block = false;
		yield_type = null;
		is_in_closure_of = 0;
		used_closures = null;
		static_method = null;
		typarms_to_pass = null;
		closure_type = null;
	}

	public int CompareTo(TFunHeader other)
	{
		return checked(id - other.id);
	}

	public list<TFunHeader> GetParents()
	{
		object result;
		if (decl != null)
		{
			LocalValue.Kind valKind = decl.ValKind;
			if (!(valKind is LocalValue.Kind.Function))
			{
				if (!Message.SeenError)
				{
					string text = "invalid value kind for function".ToString();
					Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
				}
				throw new AssertionException("ncc\\typing\\TypedTree.n", 398, "", "invalid value kind for function");
			}
			list<TFunHeader> list = ((LocalValue.Kind.Function)valKind).uses_closure_of;
			result = list;
		}
		else
		{
			result = list<TFunHeader>.Nil._N_constant_object;
		}
		return (list<TFunHeader>)result;
	}

	public override string ToString()
	{
		string[] obj = new string[5]
		{
			Convert.ToString(Name),
			"(",
			null,
			null,
			null
		};
		IEnumerable<TParameter> source = Parameters;
		Function<TParameter, string> instance = _N__N_lambda__107922__107929.Instance;
		obj[2] = string.Join(", ", source.MapToArray(instance));
		obj[3] = ") : ";
		obj[4] = Convert.ToString(ReturnType);
		return string.Concat(obj);
	}

	public Type[] GetRetTypeRequiredModifiers()
	{
		return ret_type_required_modifiers.ToArray();
	}

	public Type[] GetRetTypeOptionalModifiers()
	{
		return ret_type_optional_modifiers.ToArray();
	}

	public Type[][] GetParamTypeRequiredModifiers()
	{
		list<Type[]> list = null;
		list = list<Type[]>.Nil._N_constant_object;
		list<TParameter> list2 = Parameters;
		while (list2 is list<TParameter>.Cons)
		{
			TParameter hd = ((list<TParameter>.Cons)list2).hd;
			list2 = ((list<TParameter>.Cons)list2).tl;
			hd = hd;
			list = ((!hd.required_modifiers.IsEmpty) ? new list<Type[]>.Cons(hd.required_modifiers.ToArray(), list) : new list<Type[]>.Cons(null, list));
			list2 = list2;
		}
		list<Type[]> list3 = list;
		Function<Type[], bool> instance = _N__N_lambda__107955__107974.Instance;
		return (!list3.ForAll(instance)) ? list.Reverse().ToArray() : null;
	}

	public Type[][] GetParamTypeOptionalModifiers()
	{
		list<Type[]> list = null;
		list = list<Type[]>.Nil._N_constant_object;
		list<TParameter> list2 = Parameters;
		while (list2 is list<TParameter>.Cons)
		{
			TParameter hd = ((list<TParameter>.Cons)list2).hd;
			list2 = ((list<TParameter>.Cons)list2).tl;
			hd = hd;
			list = ((!hd.optional_modifiers.IsEmpty) ? new list<Type[]>.Cons(hd.optional_modifiers.ToArray(), list) : new list<Type[]>.Cons(null, list));
			list2 = list2;
		}
		list<Type[]> list3 = list;
		Function<Type[], bool> instance = _N__N_lambda__107994__108013.Instance;
		return (!list3.ForAll(instance)) ? list.Reverse().ToArray() : null;
	}

	public ClassMember CreateAliasMethod(NemerleModifiers mods, PExpr obj, Subst custom_subst)
	{
		AttributesAndModifiers expr = new AttributesAndModifiers(mods, list<PExpr>.Nil._N_constant_object);
		ClassMember.Function function = new ClassMember.Function(new Splicable.Name(new Name(Name, ManagerClass.Instance.MacroColors.UseColor, ManagerClass.Instance.MacroColors.UseContext)), Macros.QuotationChoose(expr), new PFunHeader(new Typarms(list<Splicable>.Nil._N_constant_object, list<Constraint>.Nil._N_constant_object), new Splicable.Name(new Name(Name, ManagerClass.Instance.MacroColors.UseColor, ManagerClass.Instance.MacroColors.UseContext)), Macros.TypedChoose(ReturnType), Macros.QuotationChoose(ParametersDeclarations)), list<PExpr>.Nil._N_constant_object, new FunBody.Parsed(new PExpr.Sequence(list<PExpr>.Nil._N_constant_object)));
		function.header.TypeParameters = new CopyTypedTyparms(TypeParameters, custom_subst);
		list<StaticTypeVar> existingTyvars = function.header.TypeParameters.ExistingTyvars;
		Function<StaticTypeVar, PExpr> instance = _N__N_lambda__108067__108075.Instance;
		list<PExpr> expr2 = existingTyvars.Map(instance);
		function.Body = new PExpr.Call(new PExpr.GenericSpecifier(new PExpr.Member(Macros.QuotationChoose(obj), new Splicable.Name(new Name(Name, ManagerClass.Instance.MacroColors.UseColor, ManagerClass.Instance.MacroColors.UseContext))), Macros.QuotationChoose(expr2)), Macros.QuotationChoose(ParametersReferences));
		return function;
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
		list<TypeVar> list = typarms_to_pass;
		if (list != null)
		{
			list = list;
			while (list is list<TypeVar>.Cons)
			{
				TypeVar hd = ((list<TypeVar>.Cons)list).hd;
				list = ((list<TypeVar>.Cons)list).tl;
				((ISupportRelocation)hd).RelocateImpl(_info);
				list = list;
			}
		}
		IMethod method = static_method;
		if (method != null)
		{
			((ISupportRelocation)method).RelocateImpl(_info);
		}
		list<TFunHeader> list2 = used_closures;
		if (list2 != null)
		{
			list2 = list2;
			while (list2 is list<TFunHeader>.Cons)
			{
				TFunHeader hd2 = ((list<TFunHeader>.Cons)list2).hd;
				list2 = ((list<TFunHeader>.Cons)list2).tl;
				((ISupportRelocation)hd2).RelocateImpl(_info);
				list2 = list2;
			}
		}
		list2 = children_funs;
		if (list2 != null)
		{
			list2 = list2;
			while (list2 is list<TFunHeader>.Cons)
			{
				TFunHeader hd2 = ((list<TFunHeader>.Cons)list2).hd;
				list2 = ((list<TFunHeader>.Cons)list2).tl;
				((ISupportRelocation)hd2).RelocateImpl(_info);
				list2 = list2;
			}
		}
		list<LocalValue> list3 = all_locals;
		if (list3 != null)
		{
			list3 = list3;
			while (list3 is list<LocalValue>.Cons)
			{
				LocalValue hd3 = ((list<LocalValue>.Cons)list3).hd;
				list3 = ((list<LocalValue>.Cons)list3).tl;
				((ISupportRelocation)hd3).RelocateImpl(_info);
				list3 = list3;
			}
		}
		decl?.RelocateImplInternal(_info);
		list3 = closure_vars;
		if (list3 != null)
		{
			list3 = list3;
			while (list3 is list<LocalValue>.Cons)
			{
				LocalValue hd3 = ((list<LocalValue>.Cons)list3).hd;
				list3 = ((list<LocalValue>.Cons)list3).tl;
				((ISupportRelocation)hd3).RelocateImpl(_info);
				list3 = list3;
			}
		}
		_body?.RelocateImplInternal(_info);
		tenv?.RelocateImplInternal(_info);
	}
}
