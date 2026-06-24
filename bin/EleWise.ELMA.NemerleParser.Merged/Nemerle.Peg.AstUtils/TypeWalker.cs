using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Collections;
using Nemerle.Compiler;
using Nemerle.Compiler.Parsetree;
using Nemerle.Compiler.Typedtree;
using Nemerle.Core;
using Nemerle.Internal;

namespace Nemerle.Peg.AstUtils;

public class TypeWalker
{
	private sealed class _N_static_proxy_10504 : Function<Nemerle.Compiler.TypeInfo, list<IMember>>
	{
		[SpecialName]
		public static readonly _N_static_proxy_10504 single_instance = new _N_static_proxy_10504();

		[SpecialName]
		public sealed override list<IMember> apply(Nemerle.Compiler.TypeInfo _N_sp_parm_10511)
		{
			return DefaultMemberSelector(_N_sp_parm_10511);
		}

		private _N_static_proxy_10504()
		{
		}
	}

	private sealed class _N_static_proxy_10514 : Function<FixedType, PExpr, option<PExpr>>
	{
		[SpecialName]
		public static readonly _N_static_proxy_10514 single_instance = new _N_static_proxy_10514();

		[SpecialName]
		public sealed override option<PExpr> apply(FixedType _N_sp_parm_10521, PExpr _N_sp_parm_10522)
		{
			return DefaultUserHandler(_N_sp_parm_10521, _N_sp_parm_10522);
		}

		private _N_static_proxy_10514()
		{
		}
	}

	private sealed class _N_static_proxy_10528 : Function<Nemerle.Compiler.TypeInfo, list<IMember>>
	{
		[SpecialName]
		public static readonly _N_static_proxy_10528 single_instance = new _N_static_proxy_10528();

		[SpecialName]
		public sealed override list<IMember> apply(Nemerle.Compiler.TypeInfo _N_sp_parm_10535)
		{
			return DefaultMemberSelector(_N_sp_parm_10535);
		}

		private _N_static_proxy_10528()
		{
		}
	}

	private sealed class _N_static_proxy_10541 : Function<FixedType, PExpr, option<PExpr>>
	{
		[SpecialName]
		public static readonly _N_static_proxy_10541 single_instance = new _N_static_proxy_10541();

		[SpecialName]
		public sealed override option<PExpr> apply(FixedType _N_sp_parm_10548, PExpr _N_sp_parm_10549)
		{
			return DefaultUserHandler(_N_sp_parm_10548, _N_sp_parm_10549);
		}

		private _N_static_proxy_10541()
		{
		}
	}

	private sealed class _N_closureOf_BuildWalkHandler_11513
	{
		internal FixedType _N_t_11524;

		internal Function<Nemerle.Compiler.TypeInfo, list<IMember>> _N_memberSelector_11522;

		internal Function<FixedType, PExpr, option<PExpr>> _N_userHandler_11520;

		internal TypeWalker _N__N_closurised_this_ptr_11518;

		internal _N_closureOf_BuildWalkHandler_11513()
		{
		}
	}

	private sealed class _N__N_lambda__11643__11660 : Function<IMember, bool>
	{
		[SpecialName]
		public static readonly _N__N_lambda__11643__11660 Instance = new _N__N_lambda__11643__11660();

		[SpecialName]
		public sealed override bool apply(IMember m)
		{
			return m is IField;
		}
	}

	private sealed class _N__N_lambda__11648__11673 : Function<IMember, bool>
	{
		[SpecialName]
		public static readonly _N__N_lambda__11648__11673 Instance = new _N__N_lambda__11648__11673();

		[SpecialName]
		public sealed override bool apply(IMember m)
		{
			return m is IProperty;
		}
	}

	private readonly Function<Nemerle.Compiler.TypeInfo, list<IMember>> defaultMemberSelector;

	private readonly Function<FixedType, PExpr, option<PExpr>> defaultUserHandler;

	private readonly Hashtable<string, option<Nemerle.Builtins.Tuple<FixedType, Name, PExpr>>> visitedTypes = new Hashtable<string, option<Nemerle.Builtins.Tuple<FixedType, Name, PExpr>>>();

	public TypeWalker()
		: this(_N_static_proxy_10504.single_instance, _N_static_proxy_10514.single_instance)
	{
	}

	public TypeWalker(Function<FixedType, PExpr, option<PExpr>> userHandler)
		: this(_N_static_proxy_10528.single_instance, userHandler)
	{
	}

	public TypeWalker(Function<Nemerle.Compiler.TypeInfo, list<IMember>> memberSelector)
		: this(memberSelector, _N_static_proxy_10541.single_instance)
	{
	}

	public TypeWalker([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] Function<Nemerle.Compiler.TypeInfo, list<IMember>> memberSelector, [Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] Function<FixedType, PExpr, option<PExpr>> userHandler)
	{
		if (userHandler == null)
		{
			throw new ArgumentNullException("userHandler", "The ``NotNull'' contract of parameter ``userHandler'' has been violated. See AstUtils\\TypeWalker.n:45:27:45:38: .");
		}
		if (memberSelector == null)
		{
			throw new ArgumentNullException("memberSelector", "The ``NotNull'' contract of parameter ``memberSelector'' has been violated. See AstUtils\\TypeWalker.n:44:27:44:41: .");
		}
		defaultMemberSelector = memberSelector;
		defaultUserHandler = userHandler;
	}

	public void Run(TypeVar ty)
	{
		Run(ty, defaultMemberSelector, defaultUserHandler);
	}

	public void Run(TypeVar ty, Function<FixedType, PExpr, option<PExpr>> userHandler)
	{
		Run(ty, defaultMemberSelector, userHandler);
	}

	public void Run(TypeVar ty, Function<Nemerle.Compiler.TypeInfo, list<IMember>> memberSelector)
	{
		Run(ty, memberSelector, defaultUserHandler);
	}

	public void Run([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] TypeVar ty, [Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] Function<Nemerle.Compiler.TypeInfo, list<IMember>> memberSelector, [Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] Function<FixedType, PExpr, option<PExpr>> userHandler)
	{
		if (userHandler == null)
		{
			throw new ArgumentNullException("userHandler", "The ``NotNull'' contract of parameter ``userHandler'' has been violated. See AstUtils\\TypeWalker.n:70:27:70:38: .");
		}
		if (memberSelector == null)
		{
			throw new ArgumentNullException("memberSelector", "The ``NotNull'' contract of parameter ``memberSelector'' has been violated. See AstUtils\\TypeWalker.n:69:27:69:41: .");
		}
		if (ty == null)
		{
			throw new ArgumentNullException("ty", "The ``NotNull'' contract of parameter ``ty'' has been violated. See AstUtils\\TypeWalker.n:68:27:68:29: .");
		}
		option<Name> walkHandler = GetWalkHandler(ty, memberSelector, userHandler);
	}

	public PExpr Compile(TExpr context)
	{
		string typeName = GetTypeName(context.Type);
		Nemerle.Builtins.Tuple<option<Nemerle.Builtins.Tuple<FixedType, Name, PExpr>>, bool> tuple = visitedTypes.TryGetValue(typeName);
		object result;
		if (tuple.Field0 is option<Nemerle.Builtins.Tuple<FixedType, Name, PExpr>>.Some && tuple.Field1)
		{
			Name field = ((option<Nemerle.Builtins.Tuple<FixedType, Name, PExpr>>.Some)tuple.Field0).val.Field1;
			list<Function_decl> list = list<Function_decl>.Nil._N_constant_object;
			foreach (KeyValuePair<string, option<Nemerle.Builtins.Tuple<FixedType, Name, PExpr>>> visitedType in visitedTypes)
			{
				KeyValuePair<string, option<Nemerle.Builtins.Tuple<FixedType, Name, PExpr>>> keyValuePair = visitedType;
				option<Nemerle.Builtins.Tuple<FixedType, Name, PExpr>> value = keyValuePair.Value;
				if (value is option<Nemerle.Builtins.Tuple<FixedType, Name, PExpr>>.Some)
				{
					FixedType field2 = ((option<Nemerle.Builtins.Tuple<FixedType, Name, PExpr>>.Some)value).val.Field0;
					Name field3 = ((option<Nemerle.Builtins.Tuple<FixedType, Name, PExpr>>.Some)value).val.Field1;
					PExpr field4 = ((option<Nemerle.Builtins.Tuple<FixedType, Name, PExpr>>.Some)value).val.Field2;
					Splicable.Name name = new Splicable.Name(field3);
					PFunHeader header = new PFunHeader(name.Location, name, new PExpr.Void(), new list<PParameter>.Cons(new PParameter(new Splicable.Name(new Name("x", -1, ManagerClass.Instance.MacroColors.UseContext)), new AttributesAndModifiers(NemerleModifiers.None, list<PExpr>.Nil._N_constant_object), Macros.TypedChoose(field2)), list<PParameter>.Nil._N_constant_object));
					list = new list<Function_decl>.Cons(new Function_decl(header, field4), list);
				}
			}
			PExpr.DefFunctions expr = new PExpr.DefFunctions(list);
			result = new PExpr.Sequence(new list<PExpr>.Cons(Macros.QuotationChoose(expr), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Ref(field), new list<PExpr>.Cons(Macros.TypedChoose(context), list<PExpr>.Nil._N_constant_object)), list<PExpr>.Nil._N_constant_object)));
		}
		else
		{
			result = Macros.TypedChoose(context);
		}
		return (PExpr)result;
	}

	private option<Name> GetWalkHandler(TypeVar t, Function<Nemerle.Compiler.TypeInfo, list<IMember>> memberSelector, Function<FixedType, PExpr, option<PExpr>> userHandler)
	{
		FixedType fixedType = t.Fix();
		string typeName = GetTypeName(fixedType);
		Nemerle.Builtins.Tuple<option<Nemerle.Builtins.Tuple<FixedType, Name, PExpr>>, bool> tuple = visitedTypes.TryGetValue(typeName);
		object result;
		Name field;
		if (tuple.Field0 is option<Nemerle.Builtins.Tuple<FixedType, Name, PExpr>>.Some)
		{
			if (!tuple.Field1)
			{
				goto IL_0057;
			}
			field = ((option<Nemerle.Builtins.Tuple<FixedType, Name, PExpr>>.Some)tuple.Field0).val.Field1;
			result = new option<Name>.Some(field);
		}
		else
		{
			if (tuple.Field0 != option<Nemerle.Builtins.Tuple<FixedType, Name, PExpr>>.None._N_constant_object || !tuple.Field1)
			{
				goto IL_0057;
			}
			result = option<Name>.None._N_constant_object;
		}
		goto IL_011a;
		IL_0057:
		field = Macros.NewSymbol("walk_" + typeName);
		visitedTypes[typeName] = new option<Nemerle.Builtins.Tuple<FixedType, Name, PExpr>>.Some(new Nemerle.Builtins.Tuple<FixedType, Name, PExpr>(fixedType, field, null));
		option<PExpr> option = BuildWalkHandler(fixedType, memberSelector, userHandler);
		if (option is option<PExpr>.Some)
		{
			PExpr val = ((option<PExpr>.Some)option).val;
			visitedTypes[typeName] = new option<Nemerle.Builtins.Tuple<FixedType, Name, PExpr>>.Some(new Nemerle.Builtins.Tuple<FixedType, Name, PExpr>(fixedType, field, val));
			result = new option<Name>.Some(field);
		}
		else
		{
			visitedTypes[typeName] = option<Nemerle.Builtins.Tuple<FixedType, Name, PExpr>>.None._N_constant_object;
			result = option<Name>.None._N_constant_object;
		}
		goto IL_011a;
		IL_011a:
		return (option<Name>)result;
	}

	private option<PExpr> BuildWalkHandler(FixedType t, Function<Nemerle.Compiler.TypeInfo, list<IMember>> memberSelector, Function<FixedType, PExpr, option<PExpr>> userHandler)
	{
		list<PExpr> list = null;
		option<PExpr> option = null;
		bool flag = false;
		_N_closureOf_BuildWalkHandler_11513 n_closureOf_BuildWalkHandler_ = new _N_closureOf_BuildWalkHandler_11513();
		n_closureOf_BuildWalkHandler_._N_t_11524 = t;
		n_closureOf_BuildWalkHandler_._N_memberSelector_11522 = memberSelector;
		n_closureOf_BuildWalkHandler_._N_userHandler_11520 = userHandler;
		n_closureOf_BuildWalkHandler_._N__N_closurised_this_ptr_11518 = this;
		object result;
		if (n_closureOf_BuildWalkHandler_._N_t_11524 is FixedType.Class)
		{
			Nemerle.Compiler.TypeInfo tycon = ((FixedType.Class)n_closureOf_BuildWalkHandler_._N_t_11524).tycon;
			list<TypeVar> args = ((FixedType.Class)n_closureOf_BuildWalkHandler_._N_t_11524).args;
			TypeDeclaration tydecl = tycon.GetTydecl();
			if (tydecl is TypeDeclaration.Variant)
			{
				list<Nemerle.Compiler.TypeInfo> members = ((TypeDeclaration.Variant)tydecl).members;
				option<PExpr> option2 = n_closureOf_BuildWalkHandler_._N_userHandler_11520.apply(n_closureOf_BuildWalkHandler_._N_t_11524, new PExpr.Ref(Name.NameInCurrentColor("x", Nemerle_002EPeg_002EMacros780011_002E_N_MacroContexts.Get(2, ManagerClass.Instance))));
				flag = false;
				List<MatchCase> list2 = new List<MatchCase>();
				members = members;
				while (members is list<Nemerle.Compiler.TypeInfo>.Cons)
				{
					tycon = ((list<Nemerle.Compiler.TypeInfo>.Cons)members).hd;
					members = ((list<Nemerle.Compiler.TypeInfo>.Cons)members).tl;
					tycon = tycon;
					FixedType.Class @class = new FixedType.Class(tycon, args);
					list = _N_walkMembers_11531(n_closureOf_BuildWalkHandler_, tycon, @class);
					option = n_closureOf_BuildWalkHandler_._N_userHandler_11520.apply(@class, new PExpr.Ref(Name.NameInCurrentColor("x", Nemerle_002EPeg_002EMacros780011_002E_N_MacroContexts.Get(2, ManagerClass.Instance))));
					if ((object)list == list<PExpr>.Nil._N_constant_object)
					{
						if (option == option<PExpr>.None._N_constant_object)
						{
							flag = true;
						}
						else
						{
							if (!(option is option<PExpr>.Some))
							{
								throw new MatchFailureException();
							}
							PExpr val = ((option<PExpr>.Some)option).val;
							list2.Add(new MatchCase(new list<PExpr>.Cons(new PExpr.As(new PExpr.Ref(new Name(tycon.Name, ManagerClass.Instance.MacroColors.UseColor, ManagerClass.Instance.MacroColors.UseContext)), new Splicable.Name(Name.NameInCurrentColor("x", Nemerle_002EPeg_002EMacros780011_002E_N_MacroContexts.Get(2, ManagerClass.Instance)))), list<PExpr>.Nil._N_constant_object), Macros.QuotationChoose(val)));
						}
					}
					else if (option == option<PExpr>.None._N_constant_object)
					{
						list2.Add(new MatchCase(new list<PExpr>.Cons(new PExpr.As(new PExpr.Ref(new Name(tycon.Name, ManagerClass.Instance.MacroColors.UseColor, ManagerClass.Instance.MacroColors.UseContext)), new Splicable.Name(Name.NameInCurrentColor("x", Nemerle_002EPeg_002EMacros780011_002E_N_MacroContexts.Get(2, ManagerClass.Instance)))), list<PExpr>.Nil._N_constant_object), new PExpr.Sequence(Macros.QuotationChoose(list))));
					}
					else
					{
						if (!(option is option<PExpr>.Some))
						{
							throw new MatchFailureException();
						}
						PExpr val = ((option<PExpr>.Some)option).val;
						list2.Add(new MatchCase(new list<PExpr>.Cons(new PExpr.As(new PExpr.Ref(new Name(tycon.Name, ManagerClass.Instance.MacroColors.UseColor, ManagerClass.Instance.MacroColors.UseContext)), new Splicable.Name(Name.NameInCurrentColor("x", Nemerle_002EPeg_002EMacros780011_002E_N_MacroContexts.Get(2, ManagerClass.Instance)))), list<PExpr>.Nil._N_constant_object), new PExpr.Sequence(Macros.QuotationChoose((list<PExpr>)new list<PExpr>.Cons(val, list)))));
					}
					members = members;
				}
				if (list2.Count > 0)
				{
					if (flag)
					{
						list2.Add(new MatchCase(new list<PExpr>.Cons(new PExpr.Wildcard(), list<PExpr>.Nil._N_constant_object), new PExpr.Literal(new Literal.Void())));
					}
					else
					{
						list2.Insert(0, new MatchCase(new list<PExpr>.Cons(new PExpr.Literal(new Literal.Null()), list<PExpr>.Nil._N_constant_object), new PExpr.Literal(new Literal.Void())));
					}
					if (option2 is option<PExpr>.Some)
					{
						PExpr val = ((option<PExpr>.Some)option2).val;
						result = new option<PExpr>.Some(new PExpr.Sequence(new list<PExpr>.Cons(Macros.QuotationChoose(val), new list<PExpr>.Cons(new PExpr.Match(new PExpr.Ref(Name.NameInCurrentColor("x", Nemerle_002EPeg_002EMacros780011_002E_N_MacroContexts.Get(2, ManagerClass.Instance))), Macros.QuotationChoose(NList.ToList(list2))), list<PExpr>.Nil._N_constant_object))));
					}
					else
					{
						result = new option<PExpr>.Some(new PExpr.Match(new PExpr.Ref(Name.NameInCurrentColor("x", Nemerle_002EPeg_002EMacros780011_002E_N_MacroContexts.Get(2, ManagerClass.Instance))), Macros.QuotationChoose(NList.ToList(list2))));
					}
				}
				else
				{
					result = option2;
				}
			}
			else
			{
				list = _N_walkMembers_11531(n_closureOf_BuildWalkHandler_, tycon, n_closureOf_BuildWalkHandler_._N_t_11524);
				option = n_closureOf_BuildWalkHandler_._N_userHandler_11520.apply(n_closureOf_BuildWalkHandler_._N_t_11524, new PExpr.Ref(Name.NameInCurrentColor("x", Nemerle_002EPeg_002EMacros780011_002E_N_MacroContexts.Get(2, ManagerClass.Instance))));
				if ((object)list == list<PExpr>.Nil._N_constant_object)
				{
					if (option == option<PExpr>.None._N_constant_object)
					{
						result = option<PExpr>.None._N_constant_object;
					}
					else
					{
						if (!(option is option<PExpr>.Some))
						{
							throw new MatchFailureException();
						}
						PExpr val = ((option<PExpr>.Some)option).val;
						result = new option<PExpr>.Some(val);
					}
				}
				else if (option == option<PExpr>.None._N_constant_object)
				{
					list = list;
					result = ((!tycon.IsValueType) ? new option<PExpr>.Some(new PExpr.MacroCall(Name.NameInCurrentColor("unless", Nemerle_002EPeg_002EMacros780011_002E_N_MacroContexts.Get(2, ManagerClass.Instance)), ManagerClass.Instance.NameTree.ExactPath(new list<string>.Cons("Nemerle", new list<string>.Cons("Core", new list<string>.Cons("unless", list<string>.Nil._N_constant_object)))), new list<SyntaxElement>.Cons(new SyntaxElement.Expression(new PExpr.Call(new PExpr.Ref(Name.NameInCurrentColor("==", Nemerle_002EPeg_002EMacros780011_002E_N_MacroContexts.Get(2, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Literal(new Literal.Null()), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("x", Nemerle_002EPeg_002EMacros780011_002E_N_MacroContexts.Get(2, ManagerClass.Instance))), list<PExpr>.Nil._N_constant_object)))), new list<SyntaxElement>.Cons(new SyntaxElement.Expression(new PExpr.Sequence(Macros.QuotationChoose(list))), list<SyntaxElement>.Nil._N_constant_object)))) : new option<PExpr>.Some(new PExpr.Sequence(Macros.QuotationChoose(list))));
				}
				else
				{
					if (!(option is option<PExpr>.Some))
					{
						throw new MatchFailureException();
					}
					list = list;
					PExpr val = ((option<PExpr>.Some)option).val;
					result = ((!tycon.IsValueType) ? new option<PExpr>.Some(new PExpr.MacroCall(Name.NameInCurrentColor("unless", Nemerle_002EPeg_002EMacros780011_002E_N_MacroContexts.Get(2, ManagerClass.Instance)), ManagerClass.Instance.NameTree.ExactPath(new list<string>.Cons("Nemerle", new list<string>.Cons("Core", new list<string>.Cons("unless", list<string>.Nil._N_constant_object)))), new list<SyntaxElement>.Cons(new SyntaxElement.Expression(new PExpr.Call(new PExpr.Ref(Name.NameInCurrentColor("==", Nemerle_002EPeg_002EMacros780011_002E_N_MacroContexts.Get(2, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Literal(new Literal.Null()), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("x", Nemerle_002EPeg_002EMacros780011_002E_N_MacroContexts.Get(2, ManagerClass.Instance))), list<PExpr>.Nil._N_constant_object)))), new list<SyntaxElement>.Cons(new SyntaxElement.Expression(new PExpr.Sequence(Macros.QuotationChoose((list<PExpr>)new list<PExpr>.Cons(val, list)))), list<SyntaxElement>.Nil._N_constant_object)))) : new option<PExpr>.Some(new PExpr.Sequence(Macros.QuotationChoose((list<PExpr>)new list<PExpr>.Cons(val, list)))));
				}
			}
		}
		else if (n_closureOf_BuildWalkHandler_._N_t_11524 is FixedType.Tuple)
		{
			list<TypeVar> args = ((FixedType.Tuple)n_closureOf_BuildWalkHandler_._N_t_11524).args;
			list = list<PExpr>.Nil._N_constant_object;
			args = args;
			int num = 0;
			while (args is list<TypeVar>.Cons)
			{
				TypeVar hd = ((list<TypeVar>.Cons)args).hd;
				args = ((list<TypeVar>.Cons)args).tl;
				option<Name> walkHandler = GetWalkHandler(hd, n_closureOf_BuildWalkHandler_._N_memberSelector_11522, n_closureOf_BuildWalkHandler_._N_userHandler_11520);
				if (walkHandler is option<Name>.Some)
				{
					Name val2 = ((option<Name>.Some)walkHandler).val;
					list = new list<PExpr>.Cons(new PExpr.Call(new PExpr.Ref(val2), new list<PExpr>.Cons(new PExpr.Indexer(new PExpr.Ref(Name.NameInCurrentColor("x", Nemerle_002EPeg_002EMacros780011_002E_N_MacroContexts.Get(2, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Literal(Literal.FromInt(num)), list<PExpr>.Nil._N_constant_object)), list<PExpr>.Nil._N_constant_object)), list);
				}
				list<TypeVar> list3 = args;
				num = checked(num + 1);
				args = list3;
			}
			list = list.Rev();
			result = (((object)list != list<PExpr>.Nil._N_constant_object) ? ((option<PExpr>)new option<PExpr>.Some(new PExpr.Sequence(Macros.QuotationChoose(list)))) : ((option<PExpr>)option<PExpr>.None._N_constant_object));
		}
		else
		{
			result = option<PExpr>.None._N_constant_object;
		}
		return (option<PExpr>)result;
	}

	private static string GetTypeName(TypeVar t)
	{
		return t.ToString();
	}

	private static list<IMember> DefaultMemberSelector(Nemerle.Compiler.TypeInfo t)
	{
		list<IMember> members = t.GetMembers(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
		TypeDeclaration tydecl = t.GetTydecl();
		list<IMember> result;
		if (tydecl == TypeDeclaration.VariantOption._N_constant_object)
		{
			Function<IMember, bool> instance = _N__N_lambda__11643__11660.Instance;
			result = members.Filter(instance);
		}
		else
		{
			Function<IMember, bool> instance = _N__N_lambda__11648__11673.Instance;
			result = members.Filter(instance);
		}
		return result;
	}

	private static option<PExpr> DefaultUserHandler(FixedType _N_wildcard_4195, PExpr _N_wildcard_4196)
	{
		return option<PExpr>.None._N_constant_object;
	}

	private list<PExpr> _N_walkMembers_11531(_N_closureOf_BuildWalkHandler_11513 _N_BuildWalkHandler_cp_11530, Nemerle.Compiler.TypeInfo ti, FixedType ft)
	{
		List<PExpr.Call> list = new List<PExpr.Call>();
		list<IMember> list2 = _N_BuildWalkHandler_cp_11530._N_memberSelector_11522.apply(ti);
		while (list2 is list<IMember>.Cons)
		{
			IMember hd = ((list<IMember>.Cons)list2).hd;
			list2 = ((list<IMember>.Cons)list2).tl;
			hd = hd;
			TypeVar typeVar = ft.TypeOfMember(hd);
			option<Name> walkHandler = GetWalkHandler(typeVar, _N_BuildWalkHandler_cp_11530._N_memberSelector_11522, _N_BuildWalkHandler_cp_11530._N_userHandler_11520);
			if (walkHandler is option<Name>.Some)
			{
				Name val = ((option<Name>.Some)walkHandler).val;
				if (typeVar.Equals(_N_BuildWalkHandler_cp_11530._N_t_11524))
				{
					list.Insert(0, new PExpr.Call(new PExpr.Ref(val), new list<PExpr>.Cons(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("x", Nemerle_002EPeg_002EMacros780011_002E_N_MacroContexts.Get(2, ManagerClass.Instance))), new Splicable.Name(new Name(hd.Name, ManagerClass.Instance.MacroColors.UseColor, ManagerClass.Instance.MacroColors.UseContext))), list<PExpr>.Nil._N_constant_object)));
				}
				else
				{
					val = ((option<Name>.Some)walkHandler).val;
					list.Add(new PExpr.Call(new PExpr.Ref(val), new list<PExpr>.Cons(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("x", Nemerle_002EPeg_002EMacros780011_002E_N_MacroContexts.Get(2, ManagerClass.Instance))), new Splicable.Name(new Name(hd.Name, ManagerClass.Instance.MacroColors.UseColor, ManagerClass.Instance.MacroColors.UseContext))), list<PExpr>.Nil._N_constant_object)));
				}
			}
			list2 = list2;
		}
		return ((IEnumerable<PExpr>)list).ToListRev();
	}
}
