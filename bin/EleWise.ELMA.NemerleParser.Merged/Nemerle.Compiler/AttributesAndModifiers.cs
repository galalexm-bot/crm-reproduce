using System;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Compiler.Parsetree;
using Nemerle.Core;
using Nemerle.Internal;
using Nemerle.Utility;

namespace Nemerle.Compiler;

public class AttributesAndModifiers : Located
{
	private sealed class _N_static_proxy_29800 : Function<string, PExpr, PExpr>
	{
		[SpecialName]
		public static readonly _N_static_proxy_29800 single_instance = new _N_static_proxy_29800();

		[SpecialName]
		public sealed override PExpr apply(string _N_sp_parm_29807, PExpr _N_sp_parm_29808)
		{
			return Pair.Second(_N_sp_parm_29807, _N_sp_parm_29808);
		}

		private _N_static_proxy_29800()
		{
		}
	}

	public NemerleModifiers mods;

	public list<PExpr> custom_attrs;

	internal list<Nemerle.Builtins.Tuple<string, PExpr>> macro_attrs;

	private list<PExpr> _N_field_parsed_custom_attrs_embeded_in_ParsedCustomAttributes_3306 = list<PExpr>.Nil._N_constant_object;

	public Location CustomAttributesLocation { get; internal set; }

	public NemerleModifiers Modifiers
	{
		get
		{
			return mods;
		}
		set
		{
			mods = value;
		}
	}

	public list<PExpr> CustomAttributes
	{
		get
		{
			return custom_attrs;
		}
		set
		{
			custom_attrs = value;
		}
	}

	public list<PExpr> ParsedCustomAttributes
	{
		get
		{
			return _N_field_parsed_custom_attrs_embeded_in_ParsedCustomAttributes_3306;
		}
		internal set
		{
			_N_field_parsed_custom_attrs_embeded_in_ParsedCustomAttributes_3306 = ((!(value != null)) ? list<PExpr>.Nil._N_constant_object : value);
		}
	}

	public NemerleModifiers ParsedModifiers { get; }

	public bool IsEmpty => custom_attrs.IsEmpty && macro_attrs.IsEmpty;

	public override Location Location => CustomAttributesLocation;

	public NemerleModifiers Attributes => mods;

	public AttributesAndModifiers(NemerleModifiers mods, list<PExpr> custom_attrs)
	{
		_N_ParsedModifiers_6080 = mods;
		this.mods = mods;
		this.custom_attrs = custom_attrs;
		macro_attrs = list<Nemerle.Builtins.Tuple<string, PExpr>>.Nil._N_constant_object;
	}

	public AttributesAndModifiers()
		: this(NemerleModifiers.None, list<PExpr>.Nil._N_constant_object)
	{
	}

	private AttributesAndModifiers(AttributesAndModifiers other)
	{
		CustomAttributesLocation = other.CustomAttributesLocation;
		mods = other.mods;
		custom_attrs = other.custom_attrs;
		macro_attrs = other.macro_attrs;
		ParsedCustomAttributes = other.ParsedCustomAttributes;
		_N_ParsedModifiers_6080 = other._N_ParsedModifiers_6080;
	}

	public AttributesAndModifiers Clone()
	{
		return new AttributesAndModifiers(this);
	}

	public list<PExpr> GetCustomAttributes()
	{
		return custom_attrs;
	}

	public list<PExpr> GetMacroAttributes()
	{
		return macro_attrs.Map(_N_static_proxy_29800.single_instance);
	}

	public void AddCustomAttribute(PExpr expr)
	{
		custom_attrs = new list<PExpr>.Cons(expr, custom_attrs);
	}

	public override string ToString()
	{
		return Convert.ToString(custom_attrs) + " " + Convert.ToString(mods);
	}

	public bool IsCustomAttributeDefined([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] string attributeFullName, [Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] GlobalEnv env)
	{
		if (env == null)
		{
			throw new ArgumentNullException("env", "The ``NotNull'' contract of parameter ``env'' has been violated. See ncc\\hierarchy\\CustomAttribute.n:828:85:828:88: .");
		}
		if (attributeFullName == null)
		{
			throw new ArgumentNullException("attributeFullName", "The ``NotNull'' contract of parameter ``attributeFullName'' has been violated. See ncc\\hierarchy\\CustomAttribute.n:828:47:828:64: .");
		}
		return FindAttribute(env.Manager.LookupTypeInfo(attributeFullName), env).IsSome;
	}

	public option<PExpr> FindAttribute([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] TypeInfo lookingFor, [Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] GlobalEnv env)
	{
		option<PExpr> option = null;
		if (env == null)
		{
			throw new ArgumentNullException("env", "The ``NotNull'' contract of parameter ``env'' has been violated. See ncc\\hierarchy\\CustomAttribute.n:834:70:834:73: .");
		}
		if (lookingFor == null)
		{
			throw new ArgumentNullException("lookingFor", "The ``NotNull'' contract of parameter ``lookingFor'' has been violated. See ncc\\hierarchy\\CustomAttribute.n:834:37:834:47: .");
		}
		AttributeCompilerClass attributeCompiler = env.Manager.AttributeCompiler;
		list<PExpr> list = custom_attrs;
		while (list is list<PExpr>.Cons)
		{
			PExpr hd = ((list<PExpr>.Cons)list).hd;
			list = ((list<PExpr>.Cons)list).tl;
			hd = hd;
			option<Nemerle.Builtins.Tuple<TypeInfo, list<PExpr>>> option2 = attributeCompiler.ResolveAttribute(env, hd, lookingFor);
			if (option2 is option<Nemerle.Builtins.Tuple<TypeInfo, list<PExpr>>>.Some)
			{
				return new option<PExpr>.Some(hd);
			}
			list = list;
		}
		return option<PExpr>.None._N_constant_object;
	}

	public option<Nemerle.Builtins.Tuple<PExpr, list<PExpr>>> FindAttributeWithArgs([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] TypeInfo lookingFor, [Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] GlobalEnv env)
	{
		option<Nemerle.Builtins.Tuple<PExpr, list<PExpr>>> option = null;
		if (env == null)
		{
			throw new ArgumentNullException("env", "The ``NotNull'' contract of parameter ``env'' has been violated. See ncc\\hierarchy\\CustomAttribute.n:844:77:844:80: .");
		}
		if (lookingFor == null)
		{
			throw new ArgumentNullException("lookingFor", "The ``NotNull'' contract of parameter ``lookingFor'' has been violated. See ncc\\hierarchy\\CustomAttribute.n:844:44:844:54: .");
		}
		AttributeCompilerClass attributeCompiler = env.Manager.AttributeCompiler;
		list<PExpr> list = custom_attrs;
		while (list is list<PExpr>.Cons)
		{
			PExpr hd = ((list<PExpr>.Cons)list).hd;
			list = ((list<PExpr>.Cons)list).tl;
			hd = hd;
			option<Nemerle.Builtins.Tuple<TypeInfo, list<PExpr>>> option2 = attributeCompiler.ResolveAttribute(env, hd, lookingFor);
			if (option2 is option<Nemerle.Builtins.Tuple<TypeInfo, list<PExpr>>>.Some)
			{
				list = ((option<Nemerle.Builtins.Tuple<TypeInfo, list<PExpr>>>.Some)option2).val.Field1;
				return new option<Nemerle.Builtins.Tuple<PExpr, list<PExpr>>>.Some(new Nemerle.Builtins.Tuple<PExpr, list<PExpr>>(hd, list));
			}
			list = list;
		}
		return option<Nemerle.Builtins.Tuple<PExpr, list<PExpr>>>.None._N_constant_object;
	}

	public list<Nemerle.Builtins.Tuple<PExpr, list<PExpr>>> FindAttributesWithArgs([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] TypeInfo lookingFor, [Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] GlobalEnv env)
	{
		list<Nemerle.Builtins.Tuple<PExpr, list<PExpr>>> list = null;
		if (env == null)
		{
			throw new ArgumentNullException("env", "The ``NotNull'' contract of parameter ``env'' has been violated. See ncc\\hierarchy\\CustomAttribute.n:854:78:854:81: .");
		}
		if (lookingFor == null)
		{
			throw new ArgumentNullException("lookingFor", "The ``NotNull'' contract of parameter ``lookingFor'' has been violated. See ncc\\hierarchy\\CustomAttribute.n:854:45:854:55: .");
		}
		AttributeCompilerClass attributeCompiler = env.Manager.AttributeCompiler;
		list = list<Nemerle.Builtins.Tuple<PExpr, list<PExpr>>>.Nil._N_constant_object;
		list<PExpr> list2 = custom_attrs;
		while (list2 is list<PExpr>.Cons)
		{
			PExpr hd = ((list<PExpr>.Cons)list2).hd;
			list<PExpr> list3 = ((list<PExpr>.Cons)list2).tl;
			hd = hd;
			option<Nemerle.Builtins.Tuple<TypeInfo, list<PExpr>>> option = attributeCompiler.ResolveAttribute(env, hd, lookingFor);
			if (option is option<Nemerle.Builtins.Tuple<TypeInfo, list<PExpr>>>.Some)
			{
				list2 = ((option<Nemerle.Builtins.Tuple<TypeInfo, list<PExpr>>>.Some)option).val.Field1;
				list = new list<Nemerle.Builtins.Tuple<PExpr, list<PExpr>>>.Cons(new Nemerle.Builtins.Tuple<PExpr, list<PExpr>>(hd, list2), list);
			}
			list2 = list3;
		}
		return list;
	}

	public list<TypeInfo> AttributeTypes([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] GlobalEnv env)
	{
		list<TypeInfo> list = null;
		if (env == null)
		{
			throw new ArgumentNullException("env", "The ``NotNull'' contract of parameter ``env'' has been violated. See ncc\\hierarchy\\CustomAttribute.n:864:37:864:40: .");
		}
		AttributeCompilerClass attributeCompiler = env.Manager.AttributeCompiler;
		list = list<TypeInfo>.Nil._N_constant_object;
		list<PExpr> list2 = custom_attrs;
		while (list2 is list<PExpr>.Cons)
		{
			PExpr hd = ((list<PExpr>.Cons)list2).hd;
			list2 = ((list<PExpr>.Cons)list2).tl;
			option<Nemerle.Builtins.Tuple<TypeInfo, list<PExpr>>> option = attributeCompiler.ResolveAttribute(env, hd);
			if (option is option<Nemerle.Builtins.Tuple<TypeInfo, list<PExpr>>>.Some)
			{
				TypeInfo field = ((option<Nemerle.Builtins.Tuple<TypeInfo, list<PExpr>>>.Some)option).val.Field0;
				list = new list<TypeInfo>.Cons(field, list);
			}
			list2 = list2;
		}
		return list;
	}

	internal void SaveCustomAttributes([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] TypeBuilder ti, Function<AttributeTargets, CustomAttributeBuilder, bool, string> adder)
	{
		if (ti == null)
		{
			throw new ArgumentNullException("ti", "The ``NotNull'' contract of parameter ``ti'' has been violated. See ncc\\hierarchy\\CustomAttribute.n:874:46:874:48: .");
		}
		list<PExpr> list = custom_attrs;
		while (list is list<PExpr>.Cons)
		{
			PExpr hd = ((list<PExpr>.Cons)list).hd;
			list<PExpr> list2 = ((list<PExpr>.Cons)list).tl;
			PExpr pExpr = hd;
			try
			{
				string text = adder.apply(ti.Manager.AttributeCompiler.CompileAttribute(ti.GlobalEnv, ti, pExpr));
				if (text != null)
				{
					Message.Error(pExpr.Location, string.Concat("custom attribute " + Convert.ToString(pExpr) + " is not valid on ", text));
				}
			}
			catch (Recovery)
			{
			}
			list = list2;
		}
		list<Nemerle.Builtins.Tuple<string, PExpr>> list3 = macro_attrs;
		while (list3 is list<Nemerle.Builtins.Tuple<string, PExpr>>.Cons)
		{
			Nemerle.Builtins.Tuple<string, PExpr> hd2 = ((list<Nemerle.Builtins.Tuple<string, PExpr>>.Cons)list3).hd;
			list<Nemerle.Builtins.Tuple<string, PExpr>> list4 = ((list<Nemerle.Builtins.Tuple<string, PExpr>>.Cons)list3).tl;
			string field = hd2.Field0;
			PExpr field2 = hd2.Field1;
			try
			{
				option<Nemerle.Builtins.Tuple<Name, IMacro, list<SyntaxElement>>> option = MacroRegistry.lookup_macro(ti.GlobalEnv, field2, field);
				if (!(option is option<Nemerle.Builtins.Tuple<Name, IMacro, list<SyntaxElement>>>.Some))
				{
					if (!Message.SeenError)
					{
						string text2 = ("macro is not a macro?" + PrettyPrint.SprintExpr(option<Typer>.None._N_constant_object, field2)).ToString();
						Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text2) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
					}
					throw new AssertionException("ncc\\hierarchy\\CustomAttribute.n", 894, "", ("macro is not a macro?" + PrettyPrint.SprintExpr(option<Typer>.None._N_constant_object, field2)).ToString());
				}
				IMacro field3 = ((option<Nemerle.Builtins.Tuple<Name, IMacro, list<SyntaxElement>>>.Some)option).val.Field1;
				list<SyntaxElement> field4 = ((option<Nemerle.Builtins.Tuple<Name, IMacro, list<SyntaxElement>>>.Some)option).val.Field2;
				Nemerle.Builtins.Tuple<IMacro, list<SyntaxElement>> tuple = new Nemerle.Builtins.Tuple<IMacro, list<SyntaxElement>>(field3, field4);
				IMacro field5 = tuple.Field0;
				list<SyntaxElement> list5 = tuple.Field1;
				if (field5.IsInherited && !ti.IsSealed)
				{
					string val = list5.ToString("@");
					string text3 = string.Concat(field5.GetNamespace() + ".", field5.GetName());
					PExpr.Call expr = new PExpr.Call(new PExpr.Member(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("Nemerle", _N_MacroContexts.Get(1, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Internal", _N_MacroContexts.Get(1, ManagerClass.Instance)))), new Splicable.Name(Name.NameInCurrentColor("MacroAttribute", _N_MacroContexts.Get(1, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Literal(new Literal.String(text3)), new list<PExpr>.Cons(new PExpr.Literal(new Literal.Integer(0uL, is_negative: false, null).WithProperType()), new list<PExpr>.Cons(new PExpr.Literal(new Literal.String(val)), list<PExpr>.Nil._N_constant_object))));
					string text4 = adder.apply(ti.Manager.AttributeCompiler.CompileAttribute(ti.GlobalEnv, ti, expr));
					if (text4 != null)
					{
						Message.Error(string.Concat("macro attribute " + Convert.ToString(text3) + " is not valid on ", text4));
					}
				}
			}
			catch (Recovery)
			{
			}
			list3 = list4;
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
		list<PExpr> n_field_parsed_custom_attrs_embeded_in_ParsedCustomAttributes_ = _N_field_parsed_custom_attrs_embeded_in_ParsedCustomAttributes_3306;
		if (n_field_parsed_custom_attrs_embeded_in_ParsedCustomAttributes_ != null)
		{
			n_field_parsed_custom_attrs_embeded_in_ParsedCustomAttributes_ = n_field_parsed_custom_attrs_embeded_in_ParsedCustomAttributes_;
			while (n_field_parsed_custom_attrs_embeded_in_ParsedCustomAttributes_ is list<PExpr>.Cons)
			{
				PExpr hd = ((list<PExpr>.Cons)n_field_parsed_custom_attrs_embeded_in_ParsedCustomAttributes_).hd;
				n_field_parsed_custom_attrs_embeded_in_ParsedCustomAttributes_ = ((list<PExpr>.Cons)n_field_parsed_custom_attrs_embeded_in_ParsedCustomAttributes_).tl;
				((ISupportRelocation)hd).RelocateImpl(_info);
				n_field_parsed_custom_attrs_embeded_in_ParsedCustomAttributes_ = n_field_parsed_custom_attrs_embeded_in_ParsedCustomAttributes_;
			}
		}
		n_field_parsed_custom_attrs_embeded_in_ParsedCustomAttributes_ = custom_attrs;
		if (n_field_parsed_custom_attrs_embeded_in_ParsedCustomAttributes_ != null)
		{
			n_field_parsed_custom_attrs_embeded_in_ParsedCustomAttributes_ = n_field_parsed_custom_attrs_embeded_in_ParsedCustomAttributes_;
			while (n_field_parsed_custom_attrs_embeded_in_ParsedCustomAttributes_ is list<PExpr>.Cons)
			{
				PExpr hd = ((list<PExpr>.Cons)n_field_parsed_custom_attrs_embeded_in_ParsedCustomAttributes_).hd;
				n_field_parsed_custom_attrs_embeded_in_ParsedCustomAttributes_ = ((list<PExpr>.Cons)n_field_parsed_custom_attrs_embeded_in_ParsedCustomAttributes_).tl;
				((ISupportRelocation)hd).RelocateImpl(_info);
				n_field_parsed_custom_attrs_embeded_in_ParsedCustomAttributes_ = n_field_parsed_custom_attrs_embeded_in_ParsedCustomAttributes_;
			}
		}
	}
}
