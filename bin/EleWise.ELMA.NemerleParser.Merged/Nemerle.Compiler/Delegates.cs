using System;
using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Compiler.Parsetree;
using Nemerle.Core;
using Nemerle.Internal;

namespace Nemerle.Compiler;

internal static class Delegates
{
	private sealed class _N_hasnt_params__83369 : Function<PExpr, bool>
	{
		[SpecialName]
		public static readonly _N_hasnt_params__83369 Instance = new _N_hasnt_params__83369();

		[SpecialName]
		public sealed override bool apply(PExpr x)
		{
			bool flag = ((x is PExpr.Member && ((PExpr.Member)x).obj is PExpr.Ref && ((PExpr.Ref)((PExpr.Member)x).obj).name.idl == "System" && ((PExpr.Member)x).member is Splicable.Name && ((Splicable.Name)((PExpr.Member)x).member).body.idl == "ParamArrayAttribute") ? true : false);
			return !flag;
		}
	}

	internal static TypeBuilder GenerateDelegateClass([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] GlobalEnv globenv, TypeBuilder parent_type, AttributesAndModifiers attrs, AttributesAndModifiers return_value_attrs, PFunHeader header)
	{
		if (globenv == null)
		{
			throw new ArgumentNullException("globenv", "The ``NotNull'' contract of parameter ``globenv'' has been violated. See ncc\\hierarchy\\DelegateClassGen.n:42:47:42:54: .");
		}
		Location location = header.Location;
		bool flag = location.FileIndex != 0;
		if (flag)
		{
			LocationStack.Push(location);
		}
		try
		{
			if ((attrs.mods & ~NemerleModifiers.AccessModifiers) != 0)
			{
				Message.Error(header.Location, "delegates are only allowed to have access specifiers as attributes");
			}
			attrs.mods |= NemerleModifiers.Sealed;
			list<PParameter> expr = create_begin_invoke_parms(header.Parameters);
			PExpr returnType = header.ReturnType;
			PExpr.Call expr2 = new PExpr.Call(new PExpr.Member(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("Nemerle", _N_MacroContexts.Get(9, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Extensions", _N_MacroContexts.Get(9, ManagerClass.Instance)))), new Splicable.Name(Name.NameInCurrentColor("DefaultValue", _N_MacroContexts.Get(9, ManagerClass.Instance)))), new list<PExpr>.Cons(Macros.QuotationChoose(returnType), list<PExpr>.Nil._N_constant_object));
			Name pName = header.PName;
			Typarms typeParameters = header.TypeParameters;
			ClassMember.TypeDeclaration typeDeclaration = new ClassMember.TypeDeclaration(new TopDeclaration.Class(new Splicable.Name(pName), Macros.QuotationChoose(attrs), new Typarms(typeParameters.tyvars, typeParameters.constraints), new list<PExpr>.Cons(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("System", _N_MacroContexts.Get(9, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("MulticastDelegate", _N_MacroContexts.Get(9, ManagerClass.Instance)))), list<PExpr>.Nil._N_constant_object), new list<ClassMember>.Cons(new ClassMember.Function(new Splicable.Name(Name.NameInCurrentColor("BeginInvoke", _N_MacroContexts.Get(9, ManagerClass.Instance))), new AttributesAndModifiers(NemerleModifiers.Public | NemerleModifiers.Virtual, list<PExpr>.Nil._N_constant_object), new PFunHeader(new Typarms(list<Splicable>.Nil._N_constant_object, list<Constraint>.Nil._N_constant_object), new Splicable.Name(Name.NameInCurrentColor("BeginInvoke", _N_MacroContexts.Get(9, ManagerClass.Instance))), new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("System", _N_MacroContexts.Get(9, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("IAsyncResult", _N_MacroContexts.Get(9, ManagerClass.Instance)))), Macros.QuotationChoose(expr)), list<PExpr>.Nil._N_constant_object, new FunBody.Parsed(new PExpr.Sequence(new list<PExpr>.Cons(new PExpr.Literal(new Literal.Null()), list<PExpr>.Nil._N_constant_object)))), new list<ClassMember>.Cons(new ClassMember.Function(new Splicable.Name(Name.NameInCurrentColor("EndInvoke", _N_MacroContexts.Get(9, ManagerClass.Instance))), new AttributesAndModifiers(NemerleModifiers.Public | NemerleModifiers.Virtual, list<PExpr>.Nil._N_constant_object), new PFunHeader(new Typarms(list<Splicable>.Nil._N_constant_object, list<Constraint>.Nil._N_constant_object), new Splicable.Name(Name.NameInCurrentColor("EndInvoke", _N_MacroContexts.Get(9, ManagerClass.Instance))), Macros.QuotationChoose(returnType), new list<PParameter>.Cons(new PParameter(new Splicable.Name(Name.NameInCurrentColor("_N_wildcard_3377", _N_MacroContexts.Get(9, ManagerClass.Instance))), new AttributesAndModifiers(NemerleModifiers.None, list<PExpr>.Nil._N_constant_object), new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("System", _N_MacroContexts.Get(9, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("IAsyncResult", _N_MacroContexts.Get(9, ManagerClass.Instance))))), list<PParameter>.Nil._N_constant_object)), list<PExpr>.Nil._N_constant_object, new FunBody.Parsed(Macros.QuotationChoose(expr2))), new list<ClassMember>.Cons(new ClassMember.Function(new Splicable.Name(Name.NameInCurrentColor("Invoke", _N_MacroContexts.Get(9, ManagerClass.Instance))), new AttributesAndModifiers(NemerleModifiers.Public | NemerleModifiers.Virtual, list<PExpr>.Nil._N_constant_object), new PFunHeader(new Typarms(list<Splicable>.Nil._N_constant_object, list<Constraint>.Nil._N_constant_object), new Splicable.Name(Name.NameInCurrentColor("Invoke", _N_MacroContexts.Get(9, ManagerClass.Instance))), Macros.QuotationChoose(returnType), Macros.QuotationChoose(header.Parameters)), list<PExpr>.Nil._N_constant_object, new FunBody.Parsed(Macros.QuotationChoose(expr2))), new list<ClassMember>.Cons(new ClassMember.Function(new Splicable.Name(Name.NameInCurrentColor(".ctor", _N_MacroContexts.Get(9, ManagerClass.Instance))), new AttributesAndModifiers(NemerleModifiers.Public, list<PExpr>.Nil._N_constant_object), new PFunHeader(new Typarms(list<Splicable>.Nil._N_constant_object, list<Constraint>.Nil._N_constant_object), new Splicable.Name(Name.NameInCurrentColor(".ctor", _N_MacroContexts.Get(9, ManagerClass.Instance))), new PExpr.Void(), new list<PParameter>.Cons(new PParameter(new Splicable.Name(Name.NameInCurrentColor("_N_wildcard_3378", _N_MacroContexts.Get(9, ManagerClass.Instance))), new AttributesAndModifiers(NemerleModifiers.None, list<PExpr>.Nil._N_constant_object), new PExpr.Ref(Name.NameInCurrentColor("object", _N_MacroContexts.Get(9, ManagerClass.Instance)))), new list<PParameter>.Cons(new PParameter(new Splicable.Name(Name.NameInCurrentColor("_N_wildcard_3379", _N_MacroContexts.Get(9, ManagerClass.Instance))), new AttributesAndModifiers(NemerleModifiers.None, list<PExpr>.Nil._N_constant_object), new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("System", _N_MacroContexts.Get(9, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("IntPtr", _N_MacroContexts.Get(9, ManagerClass.Instance))))), list<PParameter>.Nil._N_constant_object))), list<PExpr>.Nil._N_constant_object, new FunBody.Parsed(new PExpr.Sequence(new list<PExpr>.Cons(new PExpr.Call(new PExpr.Base(), new list<PExpr>.Cons(new PExpr.Typeof(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("System", _N_MacroContexts.Get(9, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Object", _N_MacroContexts.Get(9, ManagerClass.Instance))))), new list<PExpr>.Cons(new PExpr.Literal(new Literal.String("")), list<PExpr>.Nil._N_constant_object))), list<PExpr>.Nil._N_constant_object)))), list<ClassMember>.Nil._N_constant_object))))));
			bool flag2 = false;
			if (return_value_attrs != null)
			{
				flag2 = return_value_attrs.IsEmpty;
			}
			if (!flag2)
			{
				list<ClassMember> list = ((TopDeclaration.Class)typeDeclaration.td).decls;
				while (list is list<ClassMember>.Cons)
				{
					ClassMember hd = ((list<ClassMember>.Cons)list).hd;
					list<ClassMember> list2 = ((list<ClassMember>.Cons)list).tl;
					if (hd is ClassMember.Function)
					{
						ClassMember.Function function = (ClassMember.Function)hd;
						string name = function.header.Name;
						if (name == "Invoke" || name == "EndInvoke")
						{
							function.ReturnValueModifiers = return_value_attrs;
						}
					}
					list = list2;
				}
			}
			TypeBuilder typeBuilder;
			if ((object)parent_type == null)
			{
				typeBuilder = globenv.Define(typeDeclaration);
			}
			else
			{
				typeBuilder = parent_type.DefineNestedType(typeDeclaration);
			}
			TypeBuilder typeBuilder2 = typeBuilder;
			typeBuilder2.MarkAsDelegate();
			typeBuilder2.Compile();
			return typeBuilder2;
		}
		finally
		{
			if (flag)
			{
				LocationStack.RemoveTop();
			}
		}
	}

	private static list<PParameter> create_begin_invoke_parms(list<PParameter> existing)
	{
		object result;
		if ((object)existing == list<PParameter>.Nil._N_constant_object)
		{
			result = new list<PParameter>.Cons(new PParameter(new Splicable.Name(new Name(Util.tmpname("asyncCallback"), -1, ManagerClass.Instance.MacroColors.UseContext)), new AttributesAndModifiers(NemerleModifiers.None, list<PExpr>.Nil._N_constant_object), new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("System", _N_MacroContexts.Get(9, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("AsyncCallback", _N_MacroContexts.Get(9, ManagerClass.Instance))))), new list<PParameter>.Cons(new PParameter(new Splicable.Name(new Name(Util.tmpname("object"), -1, ManagerClass.Instance.MacroColors.UseContext)), new AttributesAndModifiers(NemerleModifiers.None, list<PExpr>.Nil._N_constant_object), new PExpr.Ref(Name.NameInCurrentColor("object", _N_MacroContexts.Get(9, ManagerClass.Instance)))), list<PParameter>.Nil._N_constant_object));
		}
		else
		{
			if (!(existing is list<PParameter>.Cons))
			{
				throw new MatchFailureException();
			}
			PParameter hd = ((list<PParameter>.Cons)existing).hd;
			list<PParameter> existing2 = ((list<PParameter>.Cons)existing).tl;
			Function<PExpr, bool> instance = _N_hasnt_params__83369.Instance;
			result = (hd.modifiers.custom_attrs.ForAll(instance) ? new list<PParameter>.Cons(hd, create_begin_invoke_parms(existing2)) : new list<PParameter>.Cons(new PParameter(hd.Location, hd.name, hd.Type, new AttributesAndModifiers(hd.modifiers.mods, hd.modifiers.custom_attrs.Filter(instance))), create_begin_invoke_parms(existing2)));
		}
		return (list<PParameter>)result;
	}
}
