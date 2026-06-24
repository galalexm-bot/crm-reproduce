using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using Nemerle.Builtins;
using Nemerle.Collections;
using Nemerle.Compiler.Parsetree;
using Nemerle.Compiler.Typedtree;
using Nemerle.Core;
using Nemerle.Internal;
using Nemerle.Utility;

namespace Nemerle.Compiler;

public class GlobalEnv : ISupportRelocation
{
	private sealed class _N_closureOf_LookupMacro_83585
	{
		internal list<string> _N_name_83590;

		internal _N_closureOf_LookupMacro_83585()
		{
		}
	}

	private sealed class _N_collect__83592 : Function<NamespaceTree.Node, option<IMacro>, option<IMacro>>
	{
		[SpecialName]
		private _N_closureOf_LookupMacro_83585 _N_LookupMacro_closure_83596;

		public _N_collect__83592(_N_closureOf_LookupMacro_83585 _N_LookupMacro_closure_83596)
		{
			this._N_LookupMacro_closure_83596 = _N_LookupMacro_closure_83596;
		}

		[SpecialName]
		public sealed override option<IMacro> apply(NamespaceTree.Node pref, option<IMacro> res)
		{
			option<IMacro> option = null;
			option = pref.LookupMacro(_N_LookupMacro_closure_83596._N_name_83590);
			option<IMacro> result;
			if (option == option<IMacro>.None._N_constant_object)
			{
				option = res;
			}
			else
			{
				if (res != option<IMacro>.None._N_constant_object)
				{
					if (res is option<IMacro>.Some && option is option<IMacro>.Some)
					{
						IMacro val = ((option<IMacro>.Some)res).val;
						IMacro val2 = ((option<IMacro>.Some)option).val;
						if (val == val2)
						{
							result = res;
						}
						else
						{
							val2 = ((option<IMacro>.Some)res).val;
							val = ((option<IMacro>.Some)option).val;
							Message.Error("name `..$(name; \".\")' is ambiguous, it could be:");
							Message.Error(Convert.ToString(val2.GetNamespace()) + "." + Convert.ToString(val2.GetName()) + " this macro");
							Message.Error(Convert.ToString(val.GetNamespace()) + "." + Convert.ToString(val.GetName()) + " or this macro");
							result = res;
						}
						goto IL_0104;
					}
					throw new MatchFailureException();
				}
				option = option;
			}
			result = option;
			goto IL_0104;
			IL_0104:
			return result;
		}
	}

	private sealed class _N_closureOf_SymbolExists_83638
	{
		internal list<string> _N_name_83643;

		internal _N_closureOf_SymbolExists_83638()
		{
		}
	}

	private sealed class _N_is_something__83645 : Function<NamespaceTree.Node, bool>
	{
		[SpecialName]
		private _N_closureOf_SymbolExists_83638 _N_SymbolExists_closure_83649;

		public _N_is_something__83645(_N_closureOf_SymbolExists_83638 _N_SymbolExists_closure_83649)
		{
			this._N_SymbolExists_closure_83649 = _N_SymbolExists_closure_83649;
		}

		[SpecialName]
		public sealed override bool apply(NamespaceTree.Node ns)
		{
			NamespaceTree.TypeInfoCache typeInfoCache = ns.TryPath(_N_SymbolExists_closure_83649._N_name_83643);
			return !(typeInfoCache is NamespaceTree.TypeInfoCache.No);
		}
	}

	private sealed class _N_closureOf_LookupType_83706
	{
		internal list<string> _N_name_83717;

		internal TypeBuilder _N_from_83715;

		internal int _N_args_count_83713;

		internal GlobalEnv _N__N_closurised_this_ptr_83711;

		internal _N_closureOf_LookupType_83706()
		{
		}
	}

	private sealed class _N_collect__83757 : Function<NamespaceTree.Node, option<TypeInfo>, option<TypeInfo>>
	{
		[SpecialName]
		private _N_closureOf_LookupType_83706 _N_LookupType_closure_83761;

		public _N_collect__83757(_N_closureOf_LookupType_83706 _N_LookupType_closure_83761)
		{
			this._N_LookupType_closure_83761 = _N_LookupType_closure_83761;
		}

		[SpecialName]
		public sealed override option<TypeInfo> apply(NamespaceTree.Node pref, option<TypeInfo> res)
		{
			Nemerle.Builtins.Tuple<option<TypeInfo>, option<TypeInfo>> tuple = new Nemerle.Builtins.Tuple<option<TypeInfo>, option<TypeInfo>>(res, _N_LookupType_closure_83761._N__N_closurised_this_ptr_83711._N_check_access_83744(_N_LookupType_closure_83761, pref.LookupType(_N_LookupType_closure_83761._N_name_83717, _N_LookupType_closure_83761._N_args_count_83713)));
			option<TypeInfo> option;
			object result;
			TypeInfo val3;
			if (tuple.Field1 == option<TypeInfo>.None._N_constant_object)
			{
				option = tuple.Field0;
			}
			else
			{
				if (tuple.Field0 != option<TypeInfo>.None._N_constant_object)
				{
					if (tuple.Field0 is option<TypeInfo>.Some && tuple.Field1 is option<TypeInfo>.Some)
					{
						TypeInfo val = ((option<TypeInfo>.Some)tuple.Field0).val;
						TypeInfo val2 = ((option<TypeInfo>.Some)tuple.Field1).val;
						if (val.Equals(val2))
						{
							result = res;
						}
						else
						{
							val3 = ((option<TypeInfo>.Some)tuple.Field0).val;
							TypeInfo val4 = ((option<TypeInfo>.Some)tuple.Field1).val;
							Nemerle.Builtins.Tuple<TypeDeclaration, TypeDeclaration> tuple2 = new Nemerle.Builtins.Tuple<TypeDeclaration, TypeDeclaration>(val3.GetTydecl(), val4.GetTydecl());
							if (tuple2.Field0 is TypeDeclaration.Alias)
							{
								if (((TypeDeclaration.Alias)tuple2.Field0).ty is FixedType.Class)
								{
									TypeInfo tycon = ((FixedType.Class)((TypeDeclaration.Alias)tuple2.Field0).ty).tycon;
									if (tycon.Equals(val4))
									{
										result = new option<TypeInfo>.Some(val4);
										goto IL_03dc;
									}
									if (tuple2.Field1 is TypeDeclaration.Alias && ((TypeDeclaration.Alias)tuple2.Field1).ty is FixedType.Class)
									{
										TypeInfo tycon2 = ((FixedType.Class)((TypeDeclaration.Alias)tuple2.Field1).ty).tycon;
										if (tycon2.Equals(val3))
										{
											goto IL_01c0;
										}
									}
								}
								else if (tuple2.Field1 is TypeDeclaration.Alias && ((TypeDeclaration.Alias)tuple2.Field1).ty is FixedType.Class)
								{
									TypeInfo tycon2 = ((FixedType.Class)((TypeDeclaration.Alias)tuple2.Field1).ty).tycon;
									if (tycon2.Equals(val3))
									{
										goto IL_01c0;
									}
								}
							}
							else if (tuple2.Field1 is TypeDeclaration.Alias && ((TypeDeclaration.Alias)tuple2.Field1).ty is FixedType.Class)
							{
								TypeInfo tycon2 = ((FixedType.Class)((TypeDeclaration.Alias)tuple2.Field1).ty).tycon;
								if (tycon2.Equals(val3))
								{
									goto IL_01c0;
								}
							}
							_N_LookupType_closure_83761._N__N_closurised_this_ptr_83711.Manager.BeginRelatedMessageSequence();
							try
							{
								Messenger currentMessenger = _N_LookupType_closure_83761._N__N_closurised_this_ptr_83711.Manager.Solver.CurrentMessenger;
								if (currentMessenger.NeedMessage)
								{
									IEnumerable<string> source = _N_LookupType_closure_83761._N_name_83717;
									Function<string, string> instance = _N__N_lambda__83688__83783.Instance;
									currentMessenger.Error("type name `" + string.Join(".", source.MapToArray(instance)) + "' is ambiguous, it could be:");
								}
								else
								{
									currentMessenger.MarkError();
								}
								if (currentMessenger.NeedMessage)
								{
									Message.Hint(val3.Location.FromStart(), "first  possible type: `" + Convert.ToString(val3) + "'");
									Message.Hint(val4.Location.FromStart(), "second possible type: `" + Convert.ToString(val4) + "'");
								}
							}
							finally
							{
								_N_LookupType_closure_83761._N__N_closurised_this_ptr_83711.Manager.EndRelatedMessageSequence();
							}
							result = res;
						}
						goto IL_03dc;
					}
					throw new MatchFailureException();
				}
				option = tuple.Field1;
			}
			result = option;
			goto IL_03dc;
			IL_03dc:
			return (option<TypeInfo>)result;
			IL_01c0:
			result = new option<TypeInfo>.Some(val3);
			goto IL_03dc;
		}
	}

	private sealed class _N__N_lambda__83688__83783 : Function<string, string>
	{
		[SpecialName]
		public static readonly _N__N_lambda__83688__83783 Instance = new _N__N_lambda__83688__83783();

		[SpecialName]
		public sealed override string apply(string x)
		{
			return Convert.ToString(x);
		}
	}

	private sealed class _N__N_lambda__83817__83830 : Function<Nemerle.Builtins.Tuple<TypeInfo, IMember>, list<IMember>, list<IMember>>
	{
		[SpecialName]
		public static readonly _N__N_lambda__83817__83830 Instance = new _N__N_lambda__83817__83830();

		[SpecialName]
		public sealed override list<IMember> apply(Nemerle.Builtins.Tuple<TypeInfo, IMember> _N__83828, list<IMember> _N__83829)
		{
			IMember field = _N__83828.Field1;
			return (!NList.Contains(_N__83829, field)) ? new list<IMember>.Cons(field, _N__83829) : _N__83829;
		}
	}

	private sealed class _N_closureOf_LookupSymbolExt_83924
	{
		internal list<string> _N_name_83939;

		internal bool _N_for_completion_83937;

		internal list<Nemerle.Builtins.Tuple<TypeInfo, TypeInfo>> _N_visited_83935;

		internal list<string> _N_type_part_83933;

		internal string _N_the_name_83931;

		internal TypeInfo _N_type_node_83929;

		internal _N_closureOf_LookupSymbolExt_83924()
		{
		}
	}

	private sealed class _N_closureOf_add_members_from_83952
	{
		internal TypeInfo _N_pt_83959;

		internal TypeInfo _N_ti_83957;

		internal _N_closureOf_add_members_from_83952()
		{
		}
	}

	private sealed class _N_collectNewMembers__83969 : Function<IMember, list<Nemerle.Builtins.Tuple<TypeInfo, IMember>>, list<Nemerle.Builtins.Tuple<TypeInfo, IMember>>>
	{
		[SpecialName]
		private _N_closureOf_add_members_from_83952 _N_add_members_from_closure_83973;

		public _N_collectNewMembers__83969(_N_closureOf_add_members_from_83952 _N_add_members_from_closure_83973)
		{
			this._N_add_members_from_closure_83973 = _N_add_members_from_closure_83973;
		}

		[SpecialName]
		public sealed override list<Nemerle.Builtins.Tuple<TypeInfo, IMember>> apply(IMember mem, list<Nemerle.Builtins.Tuple<TypeInfo, IMember>> acc)
		{
			TypeInfo field = ((_N_add_members_from_closure_83973._N_pt_83959 != null) ? _N_add_members_from_closure_83973._N_pt_83959 : _N_add_members_from_closure_83973._N_ti_83957);
			return (!acc.Contains(new Nemerle.Builtins.Tuple<TypeInfo, IMember>(_N_add_members_from_closure_83973._N_pt_83959, mem))) ? new list<Nemerle.Builtins.Tuple<TypeInfo, IMember>>.Cons(new Nemerle.Builtins.Tuple<TypeInfo, IMember>(field, mem), acc) : acc;
		}
	}

	private sealed class _N_closureOf_LookupSymbolExtPriority_84188
	{
		internal list<string> _N_name_84203;

		internal bool _N_for_completion_84201;

		internal List<Nemerle.Builtins.Tuple<TypeInfo, TypeInfo>> _N_visited_84199;

		internal list<string> _N_type_part_84197;

		internal string _N_the_name_84195;

		internal TypeInfo _N_type_node_84193;

		internal _N_closureOf_LookupSymbolExtPriority_84188()
		{
		}
	}

	private sealed class _N_closureOf_AddNamespaceAlias_84384
	{
		internal string _N_short_name_84389;

		internal _N_closureOf_AddNamespaceAlias_84384()
		{
		}
	}

	private sealed class _N__N_lambda__84376__84391 : Function<NamespaceTree.Node, NamespaceTree.Node>
	{
		[SpecialName]
		private _N_closureOf_AddNamespaceAlias_84384 _N_AddNamespaceAlias_closure_84395;

		public _N__N_lambda__84376__84391(_N_closureOf_AddNamespaceAlias_84384 _N_AddNamespaceAlias_closure_84395)
		{
			this._N_AddNamespaceAlias_closure_84395 = _N_AddNamespaceAlias_closure_84395;
		}

		[SpecialName]
		public sealed override NamespaceTree.Node apply(NamespaceTree.Node x)
		{
			return x.Path(new list<string>.Cons(_N_AddNamespaceAlias_closure_84395._N_short_name_84389, list<string>.Nil._N_constant_object));
		}
	}

	private sealed class _N_closureOf_IsOpenNamespace_84414
	{
		internal NamespaceTree.Node _N_ns_84419;

		internal _N_closureOf_IsOpenNamespace_84414()
		{
		}
	}

	private sealed class _N__N_lambda__84407__84421 : Function<NamespaceTree.Node, bool>
	{
		[SpecialName]
		private _N_closureOf_IsOpenNamespace_84414 _N_IsOpenNamespace_closure_84425;

		public _N__N_lambda__84407__84421(_N_closureOf_IsOpenNamespace_84414 _N_IsOpenNamespace_closure_84425)
		{
			this._N_IsOpenNamespace_closure_84425 = _N_IsOpenNamespace_closure_84425;
		}

		[SpecialName]
		public sealed override bool apply(NamespaceTree.Node _N__84406)
		{
			return _N__84406.Equals(_N_IsOpenNamespace_closure_84425._N_ns_84419);
		}
	}

	private sealed class _N_closureOf_add_open_nodes_84481
	{
		internal list<NamespaceTree.Node> _N_old_84494;

		internal Location _N_loc_84492;

		internal bool _N_should_warn_84490;

		internal list<list<SyntaxDefinition>> _N_exts_84488;

		internal GlobalEnv _N__N_closurised_this_ptr_84486;

		internal _N_closureOf_add_open_nodes_84481()
		{
		}
	}

	private sealed class _N__N_lambda__84471__84496 : Function<NamespaceTree.Node, list<NamespaceTree.Node>, list<NamespaceTree.Node>>
	{
		[SpecialName]
		private _N_closureOf_add_open_nodes_84481 _N_add_open_nodes_closure_84500;

		public _N__N_lambda__84471__84496(_N_closureOf_add_open_nodes_84481 _N_add_open_nodes_closure_84500)
		{
			this._N_add_open_nodes_closure_84500 = _N_add_open_nodes_closure_84500;
		}

		[SpecialName]
		public sealed override list<NamespaceTree.Node> apply(NamespaceTree.Node x, list<NamespaceTree.Node> acc)
		{
			object result;
			if (NList.ContainsRef(_N_add_open_nodes_closure_84500._N_old_84494, x))
			{
				if (_N_add_open_nodes_closure_84500._N_should_warn_84490)
				{
					Message.Warning(105, _N_add_open_nodes_closure_84500._N_loc_84492, "namespace `" + Convert.ToString(x.GetDisplayName()) + "' is already open");
				}
				result = acc;
			}
			else
			{
				list<SyntaxDefinition> syntaxExtensions = _N_add_open_nodes_closure_84500._N__N_closurised_this_ptr_84486.Manager.MacrosRegistry.GetSyntaxExtensions(x);
				if (syntaxExtensions != list<object>.Nil._N_constant_object)
				{
					_N_add_open_nodes_closure_84500._N_exts_84488 = new list<list<SyntaxDefinition>>.Cons(syntaxExtensions, _N_add_open_nodes_closure_84500._N_exts_84488);
				}
				result = new list<NamespaceTree.Node>.Cons(x, acc);
			}
			return (list<NamespaceTree.Node>)result;
		}
	}

	private sealed class _N_collect__84590 : Function<string, string, string>
	{
		[SpecialName]
		public static readonly _N_collect__84590 Instance = new _N_collect__84590();

		[SpecialName]
		public sealed override string apply(string k, string v)
		{
			return string.Concat(k + "=", v);
		}
	}

	private sealed class _N_extract__84600 : Function<NamespaceTree.Node, list<string>, list<string>>
	{
		[SpecialName]
		public static readonly _N_extract__84600 Instance = new _N_extract__84600();

		[SpecialName]
		public sealed override list<string> apply(NamespaceTree.Node x, list<string> acc)
		{
			return (!x.IsFromAlias) ? new list<string>.Cons(x.GetDisplayName(), acc) : acc;
		}
	}

	private sealed class _N_static_proxy_84613 : Function<string, string, int>
	{
		[SpecialName]
		public static readonly _N_static_proxy_84613 single_instance = new _N_static_proxy_84613();

		[SpecialName]
		public sealed override int apply(string _N_sp_parm_84620, string _N_sp_parm_84621)
		{
			return string.CompareOrdinal(_N_sp_parm_84620, _N_sp_parm_84621);
		}

		private _N_static_proxy_84613()
		{
		}
	}

	private sealed class _N__N_lambda__84631__84638 : Function<NamespaceTree.Node, string>
	{
		[SpecialName]
		public static readonly _N__N_lambda__84631__84638 Instance = new _N__N_lambda__84631__84638();

		[SpecialName]
		public sealed override string apply(NamespaceTree.Node _N__84630)
		{
			return _N__84630.GetDisplayName();
		}
	}

	private readonly list<NamespaceTree.Node> open_namespaces;

	private readonly NamespaceTree.Node current_namespace;

	private readonly list<Nemerle.Builtins.Tuple<string, string>> namespace_aliases;

	private int macro_ctx_cache;

	public readonly Map<string, GrammarElement> SyntaxKeywords;

	public readonly Set<string> Keywords;

	internal readonly Map<string, MainParser.OperatorInfo> UnaryOperators;

	internal readonly Map<string, MainParser.OperatorInfo> Operators;

	public readonly Map<string, bool> Defines;

	private readonly NamespaceTree nameTree;

	public readonly ManagerClass Manager;

	public NamespaceTree.Node CurrentNamespace => current_namespace;

	public InternalTypeClass InternalType => Manager.InternalType;

	public SystemTypeClass SystemTypeCache => Manager.SystemTypeCache;

	public list<NamespaceTree.Node> OpenNamespaces
	{
		[CompilerGenerated]
		[DebuggerStepThrough]
		get
		{
			return open_namespaces;
		}
	}

	public list<Nemerle.Builtins.Tuple<string, string>> NamespaceAliases
	{
		[DebuggerStepThrough]
		[CompilerGenerated]
		get
		{
			return namespace_aliases;
		}
	}

	public NamespaceTree NameTree
	{
		[CompilerGenerated]
		[DebuggerStepThrough]
		get
		{
			return nameTree;
		}
	}

	internal static GlobalEnv CreateCore(NamespaceTree nameTree)
	{
		return new GlobalEnv(nameTree).AddOpenNamespace(new list<NamespaceTree.Node>.Cons(nameTree.NamespaceTree, list<NamespaceTree.Node>.Nil._N_constant_object), Location.Default).AddOpenNamespace(new list<string>.Cons("Nemerle", new list<string>.Cons("Core", list<string>.Nil._N_constant_object)), Location.Default).AddOpenNamespace(new list<string>.Cons("Nemerle", new list<string>.Cons("Core", new list<string>.Cons("option", list<string>.Nil._N_constant_object))), Location.Default)
			.AddOpenNamespace(new list<string>.Cons("Nemerle", new list<string>.Cons("Core", new list<string>.Cons("ValueOptionStatic", list<string>.Nil._N_constant_object))), Location.Default);
	}

	public GlobalEnv(GlobalEnv prototype, list<string> additionalKeywords)
	{
		Manager = prototype.Manager;
		Keywords = prototype.Keywords.ReplaceList(additionalKeywords);
		open_namespaces = prototype.open_namespaces;
		current_namespace = prototype.current_namespace;
		namespace_aliases = prototype.namespace_aliases;
		macro_ctx_cache = prototype.macro_ctx_cache;
		SyntaxKeywords = prototype.SyntaxKeywords;
		UnaryOperators = prototype.UnaryOperators;
		Operators = prototype.Operators;
		nameTree = prototype.nameTree;
		Defines = prototype.Defines;
	}

	private GlobalEnv(NamespaceTree nameTree)
		: this(list<NamespaceTree.Node>.Nil._N_constant_object, nameTree.namespace_tree, list<Nemerle.Builtins.Tuple<string, string>>.Nil._N_constant_object, new Map<string, GrammarElement>(), LexerBase.BaseKeywords, new Map<string, MainParser.OperatorInfo>(), new Map<string, MainParser.OperatorInfo>(), nameTree, nameTree.Manager.Options.CommandDefines)
	{
	}

	private GlobalEnv(list<NamespaceTree.Node> open_namespaces, NamespaceTree.Node current_namespace, list<Nemerle.Builtins.Tuple<string, string>> namespace_aliases, Map<string, GrammarElement> syntax_keys, Set<string> keywords, Map<string, MainParser.OperatorInfo> unaryOperators, Map<string, MainParser.OperatorInfo> operators, NamespaceTree nameTree, [Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] Map<string, bool> defines)
	{
		if (defines == null)
		{
			throw new ArgumentNullException("defines", "The ``NotNull'' contract of parameter ``defines'' has been violated. See ncc\\hierarchy\\GlobalEnv.n:109:21:109:28: .");
		}
		Manager = nameTree.Manager;
		this.open_namespaces = open_namespaces;
		this.current_namespace = current_namespace;
		this.namespace_aliases = namespace_aliases;
		SyntaxKeywords = syntax_keys;
		Keywords = keywords;
		UnaryOperators = unaryOperators;
		Operators = operators;
		this.nameTree = nameTree;
		Defines = defines;
		macro_ctx_cache = -1;
	}

	public bool IsKeyword(string x)
	{
		return Keywords.Contains(x);
	}

	internal MainParser.OperatorInfo FetchOperator(string op)
	{
		option<MainParser.OperatorInfo> option = Operators.Find(op);
		object result;
		if (option is option<MainParser.OperatorInfo>.Some)
		{
			MainParser.OperatorInfo val = ((option<MainParser.OperatorInfo>.Some)option).val;
			result = val;
		}
		else
		{
			if (option != option<MainParser.OperatorInfo>.None._N_constant_object)
			{
				throw new MatchFailureException();
			}
			result = new MainParser.BinaryOperatorInfo(op, 200, 201);
		}
		return (MainParser.OperatorInfo)result;
	}

	internal bool HasUnaryOperator(string op)
	{
		return UnaryOperators.Contains(op);
	}

	internal bool HasOperator(string op)
	{
		return UnaryOperators.Contains(op) || Operators.Contains(op);
	}

	internal MainParser.OperatorInfo LookupUnaryOperator(string op)
	{
		option<MainParser.OperatorInfo> option = UnaryOperators.Find(op);
		object result;
		if (option is option<MainParser.OperatorInfo>.Some)
		{
			MainParser.OperatorInfo val = ((option<MainParser.OperatorInfo>.Some)option).val;
			result = val;
		}
		else
		{
			if (option != option<MainParser.OperatorInfo>.None._N_constant_object)
			{
				throw new MatchFailureException();
			}
			result = null;
		}
		return (MainParser.OperatorInfo)result;
	}

	internal MainParser.OperatorInfo LookupOperator(string op)
	{
		option<MainParser.OperatorInfo> option = Operators.Find(op);
		object result;
		if (option is option<MainParser.OperatorInfo>.Some)
		{
			MainParser.OperatorInfo val = ((option<MainParser.OperatorInfo>.Some)option).val;
			result = val;
		}
		else
		{
			if (option != option<MainParser.OperatorInfo>.None._N_constant_object)
			{
				throw new MatchFailureException();
			}
			option = UnaryOperators.Find(op);
			if (option is option<MainParser.OperatorInfo>.Some)
			{
				MainParser.OperatorInfo val = ((option<MainParser.OperatorInfo>.Some)option).val;
				result = val;
			}
			else
			{
				if (option != option<MainParser.OperatorInfo>.None._N_constant_object)
				{
					throw new MatchFailureException();
				}
				result = null;
			}
		}
		return (MainParser.OperatorInfo)result;
	}

	internal GlobalEnv CreateExtended(list<NamespaceTree.Node> o, NamespaceTree.Node c, list<Nemerle.Builtins.Tuple<string, string>> n, list<list<SyntaxDefinition>> syntax_exts)
	{
		Set<string> set = null;
		Map<string, GrammarElement> map = null;
		Map<string, MainParser.OperatorInfo> map2 = null;
		Map<string, MainParser.OperatorInfo> map3 = null;
		map = SyntaxKeywords;
		set = Keywords;
		map3 = UnaryOperators;
		map2 = Operators;
		list<list<SyntaxDefinition>> list = syntax_exts;
		while (list is list<list<SyntaxDefinition>>.Cons)
		{
			list<SyntaxDefinition> list2 = ((list<list<SyntaxDefinition>>.Cons)list).hd;
			list = ((list<list<SyntaxDefinition>>.Cons)list).tl;
			list2 = list2;
			map = MainParser.load_syntax(list2, map);
			list2 = list2;
			while (list2 is list<SyntaxDefinition>.Cons)
			{
				SyntaxDefinition hd = ((list<SyntaxDefinition>.Cons)list2).hd;
				list2 = ((list<SyntaxDefinition>.Cons)list2).tl;
				if (hd is OperatorDefinition)
				{
					OperatorDefinition operatorDefinition = (OperatorDefinition)hd;
					if (LexerBase.HasKeywordChars(operatorDefinition.Start))
					{
						set = set.Replace(operatorDefinition.Start);
					}
					if (operatorDefinition.Keywords == null)
					{
						map2 = map2.Replace(operatorDefinition.Start, new MainParser.BinaryOperatorInfo(operatorDefinition.Start, operatorDefinition.Left, operatorDefinition.Right));
					}
					else
					{
						map3 = map3.Replace(operatorDefinition.Start, new MainParser.UnaryOperatorInfo(operatorDefinition.Start, operatorDefinition.Left, operatorDefinition.Right));
					}
				}
				else
				{
					list<string> list3 = hd.Keywords;
					while (list3 is list<string>.Cons)
					{
						string hd2 = ((list<string>.Cons)list3).hd;
						list3 = ((list<string>.Cons)list3).tl;
						hd2 = hd2;
						if (!Manager.Options.IsKeywordDisabled(hd2, o))
						{
							set = set.Replace(hd2);
						}
						list3 = list3;
					}
				}
				list2 = list2;
			}
			list = list;
		}
		return new GlobalEnv(o, c, n, map, set, map3, map2, nameTree, Defines);
	}

	public TypeBuilder Define(ClassMember td)
	{
		return Define(td, do_fixup: true);
	}

	public TypeBuilder Define(ClassMember td, bool do_fixup)
	{
		object result;
		if (td is ClassMember.TypeDeclaration)
		{
			if (((ClassMember.TypeDeclaration)td).td is TopDeclaration.Delegate)
			{
				TopDeclaration.Delegate @delegate = (TopDeclaration.Delegate)((ClassMember.TypeDeclaration)td).td;
				PFunHeader header = ((TopDeclaration.Delegate)((ClassMember.TypeDeclaration)td).td).header;
				TypeBuilder typeBuilder = Delegates.GenerateDelegateClass(this, null, @delegate.modifiers, @delegate.ReturnValueModifiers, header);
				result = typeBuilder;
			}
			else
			{
				TopDeclaration td2 = ((ClassMember.TypeDeclaration)td).td;
				TypeBuilder typeBuilder = Manager.NameTree.AddType(null, current_namespace, td2);
				typeBuilder.CalcAccessibility();
				if (do_fixup)
				{
					typeBuilder.FixupDefinedClass();
				}
				result = typeBuilder;
			}
		}
		else
		{
			Message.Error("only types can be defined in global namespaces");
			result = null;
		}
		return (TypeBuilder)result;
	}

	public TypeInfo GetType(list<string> name, TypeBuilder from, int args_count)
	{
		option<TypeInfo> option = LookupType(name, from, args_count);
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
			string text = ((args_count <= 0) ? "'" : string.Concat("`" + args_count, "'"));
			if (Manager.Solver.CurrentMessenger.NeedMessage)
			{
				Manager.Solver.CurrentMessenger.Error(string.Concat("unbound type name `" + name.ToString("."), text));
			}
			else
			{
				Manager.Solver.CurrentMessenger.MarkError();
			}
			result = InternalType.Object_tc;
		}
		return result;
	}

	public option<TypeInfo> LookupType(list<string> name)
	{
		return LookupType(name, null, -1);
	}

	public option<IMacro> LookupMacro(list<string> name)
	{
		_N_closureOf_LookupMacro_83585 n_closureOf_LookupMacro_ = new _N_closureOf_LookupMacro_83585();
		n_closureOf_LookupMacro_._N_name_83590 = name;
		Function<NamespaceTree.Node, option<IMacro>, option<IMacro>> f = new _N_collect__83592(n_closureOf_LookupMacro_);
		return new list<NamespaceTree.Node>.Cons(nameTree.namespace_tree, open_namespaces).FoldLeft(option<IMacro>.None._N_constant_object, f);
	}

	public TypeVar BindType(PExpr expr)
	{
		Location location = expr.Location;
		bool flag = location.FileIndex != 0;
		if (flag)
		{
			LocationStack.Push(location);
		}
		try
		{
			return Manager.emptyTEnv.Bind(this, null, expr, allow_tyvars: true, check_parms: false);
		}
		finally
		{
			if (flag)
			{
				LocationStack.RemoveTop();
			}
		}
	}

	public FixedType BindFixedType(PExpr expr)
	{
		return Manager.emptyTEnv.BindFixedType(this, null, expr, check_parms: false);
	}

	public bool SymbolExists(list<string> name)
	{
		_N_closureOf_SymbolExists_83638 n_closureOf_SymbolExists_ = new _N_closureOf_SymbolExists_83638();
		n_closureOf_SymbolExists_._N_name_83643 = name;
		Function<NamespaceTree.Node, bool> f = new _N_is_something__83645(n_closureOf_SymbolExists_);
		return new list<NamespaceTree.Node>.Cons(nameTree.namespace_tree, open_namespaces).Exists(f);
	}

	public option<TypeInfo> LookupType(list<string> name, TypeBuilder from, int args_count)
	{
		option<TypeInfo> option = null;
		TypeInfo typeInfo = null;
		NamespaceTree.Node node = null;
		_N_closureOf_LookupType_83706 n_closureOf_LookupType_ = new _N_closureOf_LookupType_83706();
		n_closureOf_LookupType_._N_name_83717 = name;
		n_closureOf_LookupType_._N_from_83715 = from;
		n_closureOf_LookupType_._N_args_count_83713 = args_count;
		n_closureOf_LookupType_._N__N_closurised_this_ptr_83711 = this;
		option = nameTree.LookupExactType(n_closureOf_LookupType_._N_name_83717, n_closureOf_LookupType_._N_args_count_83713);
		object result;
		if (option is option<TypeInfo>.Some)
		{
			typeInfo = ((option<TypeInfo>.Some)option).val;
			if (n_closureOf_LookupType_._N_from_83715 == null || typeInfo.CanAccess(n_closureOf_LookupType_._N_from_83715))
			{
				result = (option<TypeInfo>.Some)option;
				goto IL_012e;
			}
		}
		Function<NamespaceTree.Node, option<TypeInfo>, option<TypeInfo>> function = new _N_collect__83757(n_closureOf_LookupType_);
		option = open_namespaces.FoldLeft(option<TypeInfo>.None._N_constant_object, function);
		for (node = ((n_closureOf_LookupType_._N_from_83715 != null) ? n_closureOf_LookupType_._N_from_83715.NamespaceNode : null); node != null; node = node.Parent)
		{
			option = function.apply(node, option);
		}
		for (typeInfo = ((n_closureOf_LookupType_._N_from_83715 != null) ? n_closureOf_LookupType_._N_from_83715.BaseType : null); typeInfo != null; typeInfo = typeInfo.BaseType)
		{
			option = function.apply(typeInfo.NamespaceNode, option);
		}
		result = option;
		goto IL_012e;
		IL_012e:
		return (option<TypeInfo>)result;
	}

	public list<IMember> LookupSymbol(list<string> name, TypeBuilder parent, bool for_completion = false)
	{
		list<Nemerle.Builtins.Tuple<TypeInfo, IMember>> list = LookupSymbolExt(name, parent, for_completion);
		list<IMember>.Nil n_constant_object = list<IMember>.Nil._N_constant_object;
		Function<Nemerle.Builtins.Tuple<TypeInfo, IMember>, list<IMember>, list<IMember>> instance = _N__N_lambda__83817__83830.Instance;
		return list.FoldLeft(n_constant_object, instance);
	}

	public list<Nemerle.Builtins.Tuple<TypeInfo, IMember>> LookupSymbolExt(list<string> name, TypeBuilder parent, bool for_completion = false)
	{
		NamespaceTree.Node node = null;
		list<Nemerle.Builtins.Tuple<TypeInfo, IMember>> list = null;
		NamespaceTree.Node node2 = null;
		_N_closureOf_LookupSymbolExt_83924 n_closureOf_LookupSymbolExt_ = new _N_closureOf_LookupSymbolExt_83924();
		n_closureOf_LookupSymbolExt_._N_name_83939 = name;
		n_closureOf_LookupSymbolExt_._N_for_completion_83937 = for_completion;
		n_closureOf_LookupSymbolExt_._N_visited_83935 = list<Nemerle.Builtins.Tuple<TypeInfo, TypeInfo>>.Nil._N_constant_object;
		Nemerle.Builtins.Tuple<list<string>, string> tuple = NList.DivideLast(n_closureOf_LookupSymbolExt_._N_name_83939);
		n_closureOf_LookupSymbolExt_._N_type_part_83933 = tuple.Field0;
		n_closureOf_LookupSymbolExt_._N_the_name_83931 = tuple.Field1;
		n_closureOf_LookupSymbolExt_._N_type_node_83929 = null;
		list = list<Nemerle.Builtins.Tuple<TypeInfo, IMember>>.Nil._N_constant_object;
		list<NamespaceTree.Node> list2 = open_namespaces;
		while (list2 is list<NamespaceTree.Node>.Cons)
		{
			node = ((list<NamespaceTree.Node>.Cons)list2).hd;
			list2 = ((list<NamespaceTree.Node>.Cons)list2).tl;
			node = node;
			if (node.IsFromAlias)
			{
				list = _N_lookup_members_83991(n_closureOf_LookupSymbolExt_, node, list);
			}
			list2 = list2;
		}
		if (list.IsEmpty)
		{
			list = _N_lookup_members_83991(n_closureOf_LookupSymbolExt_, nameTree.namespace_tree, list);
			list2 = open_namespaces;
			while (list2 is list<NamespaceTree.Node>.Cons)
			{
				node = ((list<NamespaceTree.Node>.Cons)list2).hd;
				list2 = ((list<NamespaceTree.Node>.Cons)list2).tl;
				node = node;
				if (!node.IsFromAlias)
				{
					list = _N_lookup_members_83991(n_closureOf_LookupSymbolExt_, node, list);
				}
				list2 = list2;
			}
		}
		if (parent != null)
		{
			node2 = parent.NamespaceNode;
		}
		for (node = node2; node != null; node = node.Parent)
		{
			list = _N_lookup_members_83991(n_closureOf_LookupSymbolExt_, node, list);
			NamespaceTree.TypeInfoCache value = node.Value;
			if (value is NamespaceTree.TypeInfoCache.Cached && ((NamespaceTree.TypeInfoCache.Cached)value).tycon is TypeBuilder)
			{
				TypeBuilder typeBuilder = (TypeBuilder)((NamespaceTree.TypeInfoCache.Cached)value).tycon;
				n_closureOf_LookupSymbolExt_._N_type_node_83929 = typeBuilder.BaseType;
				while (n_closureOf_LookupSymbolExt_._N_type_node_83929 != null)
				{
					list = _N_lookup_members_83991(n_closureOf_LookupSymbolExt_, n_closureOf_LookupSymbolExt_._N_type_node_83929.NamespaceNode, list);
					n_closureOf_LookupSymbolExt_._N_type_node_83929 = n_closureOf_LookupSymbolExt_._N_type_node_83929.BaseType;
				}
			}
		}
		return list;
	}

	public Nemerle.Builtins.Tuple<List<IMember>, List<IMember>> LookupSymbolPriority(list<string> name, TypeBuilder parent, bool for_completion = false)
	{
		Nemerle.Builtins.Tuple<List<Nemerle.Builtins.Tuple<TypeInfo, IMember>>, List<Nemerle.Builtins.Tuple<TypeInfo, IMember>>> tuple = LookupSymbolExtPriority(name, parent, for_completion);
		List<Nemerle.Builtins.Tuple<TypeInfo, IMember>> list = tuple.Field0;
		List<Nemerle.Builtins.Tuple<TypeInfo, IMember>> list2 = tuple.Field1;
		List<IMember> list3 = new List<IMember>();
		foreach (Nemerle.Builtins.Tuple<TypeInfo, IMember> item in list)
		{
			IMember field = item.Field1;
			if (!list3.Contains(field))
			{
				list3.Add(field);
			}
		}
		List<IMember> list4 = new List<IMember>();
		foreach (Nemerle.Builtins.Tuple<TypeInfo, IMember> item2 in list2)
		{
			IMember field2 = item2.Field1;
			if (!list3.Contains(field2) && !list4.Contains(field2))
			{
				list4.Add(field2);
			}
		}
		return new Nemerle.Builtins.Tuple<List<IMember>, List<IMember>>(list3, list4);
	}

	public Nemerle.Builtins.Tuple<List<Nemerle.Builtins.Tuple<TypeInfo, IMember>>, List<Nemerle.Builtins.Tuple<TypeInfo, IMember>>> LookupSymbolExtPriority(list<string> name, TypeBuilder parent, bool for_completion = false)
	{
		NamespaceTree.Node node = null;
		NamespaceTree.Node node2 = null;
		_N_closureOf_LookupSymbolExtPriority_84188 n_closureOf_LookupSymbolExtPriority_ = new _N_closureOf_LookupSymbolExtPriority_84188();
		n_closureOf_LookupSymbolExtPriority_._N_name_84203 = name;
		n_closureOf_LookupSymbolExtPriority_._N_for_completion_84201 = for_completion;
		n_closureOf_LookupSymbolExtPriority_._N_visited_84199 = new List<Nemerle.Builtins.Tuple<TypeInfo, TypeInfo>>();
		Nemerle.Builtins.Tuple<list<string>, string> tuple = NList.DivideLast(n_closureOf_LookupSymbolExtPriority_._N_name_84203);
		n_closureOf_LookupSymbolExtPriority_._N_type_part_84197 = tuple.Field0;
		n_closureOf_LookupSymbolExtPriority_._N_the_name_84195 = tuple.Field1;
		n_closureOf_LookupSymbolExtPriority_._N_type_node_84193 = null;
		List<Nemerle.Builtins.Tuple<TypeInfo, IMember>> list = new List<Nemerle.Builtins.Tuple<TypeInfo, IMember>>();
		list<NamespaceTree.Node> list2 = open_namespaces;
		while (list2 is list<NamespaceTree.Node>.Cons)
		{
			node = ((list<NamespaceTree.Node>.Cons)list2).hd;
			list2 = ((list<NamespaceTree.Node>.Cons)list2).tl;
			node = node;
			if (node.IsFromAlias)
			{
				_N_lookup_members_84243(n_closureOf_LookupSymbolExtPriority_, node, list);
			}
			list2 = list2;
		}
		if (((ICollection)list).IsEmpty())
		{
			_N_lookup_members_84243(n_closureOf_LookupSymbolExtPriority_, nameTree.namespace_tree, list);
			list2 = open_namespaces;
			while (list2 is list<NamespaceTree.Node>.Cons)
			{
				node = ((list<NamespaceTree.Node>.Cons)list2).hd;
				list2 = ((list<NamespaceTree.Node>.Cons)list2).tl;
				node = node;
				if (!node.IsFromAlias)
				{
					_N_lookup_members_84243(n_closureOf_LookupSymbolExtPriority_, node, list);
				}
				list2 = list2;
			}
		}
		List<Nemerle.Builtins.Tuple<TypeInfo, IMember>> list3 = new List<Nemerle.Builtins.Tuple<TypeInfo, IMember>>();
		if (parent != null)
		{
			node2 = parent.NamespaceNode;
		}
		for (node = node2; node != null; node = node.Parent)
		{
			_N_lookup_members_84243(n_closureOf_LookupSymbolExtPriority_, node, list3);
			NamespaceTree.TypeInfoCache value = node.Value;
			if (value is NamespaceTree.TypeInfoCache.Cached && ((NamespaceTree.TypeInfoCache.Cached)value).tycon is TypeBuilder)
			{
				TypeBuilder typeBuilder = (TypeBuilder)((NamespaceTree.TypeInfoCache.Cached)value).tycon;
				n_closureOf_LookupSymbolExtPriority_._N_type_node_84193 = typeBuilder.BaseType;
				while (n_closureOf_LookupSymbolExtPriority_._N_type_node_84193 != null)
				{
					_N_lookup_members_84243(n_closureOf_LookupSymbolExtPriority_, n_closureOf_LookupSymbolExtPriority_._N_type_node_84193.NamespaceNode, list3);
					n_closureOf_LookupSymbolExtPriority_._N_type_node_84193 = n_closureOf_LookupSymbolExtPriority_._N_type_node_84193.BaseType;
				}
			}
		}
		return new Nemerle.Builtins.Tuple<List<Nemerle.Builtins.Tuple<TypeInfo, IMember>>, List<Nemerle.Builtins.Tuple<TypeInfo, IMember>>>(list3, list);
	}

	public GlobalEnv AddOpenNamespace(list<string> ns, Location loc)
	{
		list<NamespaceTree.Node>.Cons cons = null;
		if (ns is list<string>.Cons)
		{
			string hd = ((list<string>.Cons)ns).hd;
			list<string> tl = ((list<string>.Cons)ns).tl;
			cons = new list<NamespaceTree.Node>.Cons(nameTree.ExactPath(ns), list<NamespaceTree.Node>.Nil._N_constant_object);
			list<Nemerle.Builtins.Tuple<string, string>> list = namespace_aliases;
			while (list is list<Nemerle.Builtins.Tuple<string, string>>.Cons)
			{
				Nemerle.Builtins.Tuple<string, string> hd2 = ((list<Nemerle.Builtins.Tuple<string, string>>.Cons)list).hd;
				list = ((list<Nemerle.Builtins.Tuple<string, string>>.Cons)list).tl;
				string field = hd2.Field0;
				string field2 = hd2.Field1;
				if (field == hd)
				{
					cons = new list<NamespaceTree.Node>.Cons(nameTree.ExactPath(NString.Split(field2, '.')).Path(tl), cons);
				}
				list = list;
			}
			return AddOpenNamespace(cons, loc);
		}
		if (!Message.SeenError)
		{
			string field2 = "empty or null namespace cannot be opened".ToString();
			Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(field2) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
		}
		throw new AssertionException("ncc\\hierarchy\\GlobalEnv.n", 598, "", "empty or null namespace cannot be opened");
	}

	private GlobalEnv AddOpenNamespace(list<NamespaceTree.Node> nses, Location loc)
	{
		list<NamespaceTree.Node> list = null;
		list = nses;
		list<NamespaceTree.Node> list2 = nses;
		while (list2 is list<NamespaceTree.Node>.Cons)
		{
			NamespaceTree.Node hd = ((list<NamespaceTree.Node>.Cons)list2).hd;
			list2 = ((list<NamespaceTree.Node>.Cons)list2).tl;
			NamespaceTree.Node parent = current_namespace;
			while (parent.Parent != null)
			{
				list = new list<NamespaceTree.Node>.Cons(parent.Path(hd.FullName), list);
				parent = parent.Parent;
			}
			list2 = list2;
		}
		nameTree.referenced_namespace_nodes.Add(new Nemerle.Builtins.Tuple<list<NamespaceTree.Node>, Location>(list, loc));
		Nemerle.Builtins.Tuple<list<list<SyntaxDefinition>>, list<NamespaceTree.Node>> tuple = add_open_nodes(open_namespaces, list, loc, should_warn: true);
		list<list<SyntaxDefinition>> syntax_exts = tuple.Field0;
		list = tuple.Field1;
		return CreateExtended(list, current_namespace, namespace_aliases, syntax_exts);
	}

	public GlobalEnv AddNamespaceAlias(string short_name, list<string> long_name, Location loc)
	{
		_N_closureOf_AddNamespaceAlias_84384 n_closureOf_AddNamespaceAlias_ = new _N_closureOf_AddNamespaceAlias_84384();
		n_closureOf_AddNamespaceAlias_._N_short_name_84389 = short_name;
		list<NamespaceTree.Node> list = add_alias_nodes(n_closureOf_AddNamespaceAlias_._N_short_name_84389, long_name);
		Function<NamespaceTree.Node, NamespaceTree.Node> convert = new _N__N_lambda__84376__84391(n_closureOf_AddNamespaceAlias_);
		list<NamespaceTree.Node> field = list.Map(convert);
		nameTree.referenced_namespace_nodes.Add(new Nemerle.Builtins.Tuple<list<NamespaceTree.Node>, Location>(field, loc));
		return new GlobalEnv(NList.RevAppend(list, open_namespaces), current_namespace, new list<Nemerle.Builtins.Tuple<string, string>>.Cons(new Nemerle.Builtins.Tuple<string, string>(n_closureOf_AddNamespaceAlias_._N_short_name_84389, long_name.ToString(".")), namespace_aliases), SyntaxKeywords, Keywords, UnaryOperators, Operators, nameTree, Defines);
	}

	public GlobalEnv SetDefines(Map<string, bool> defines)
	{
		return new GlobalEnv(open_namespaces, current_namespace, namespace_aliases, SyntaxKeywords, Keywords, UnaryOperators, Operators, nameTree, defines);
	}

	public bool IsOpenNamespace(NamespaceTree.Node ns)
	{
		_N_closureOf_IsOpenNamespace_84414 n_closureOf_IsOpenNamespace_ = new _N_closureOf_IsOpenNamespace_84414();
		n_closureOf_IsOpenNamespace_._N_ns_84419 = ns;
		list<NamespaceTree.Node>.Cons cons = new list<NamespaceTree.Node>.Cons(current_namespace, open_namespaces);
		Function<NamespaceTree.Node, bool> f = new _N__N_lambda__84407__84421(n_closureOf_IsOpenNamespace_);
		return cons.Exists(f);
	}

	public GlobalEnv EnterIntoNamespace(list<string> qid)
	{
		GlobalEnv globalEnv = null;
		NamespaceTree.Node node = null;
		node = current_namespace;
		globalEnv = this;
		list<string> list = qid;
		while (list is list<string>.Cons)
		{
			string hd = ((list<string>.Cons)list).hd;
			list = ((list<string>.Cons)list).tl;
			node = node.Path(new list<string>.Cons(hd, list<string>.Nil._N_constant_object));
			globalEnv = globalEnv.EnterIntoNamespace(node);
			list = list;
		}
		return globalEnv;
	}

	public GlobalEnv EnterIntoNamespace(NamespaceTree.Node full)
	{
		NamespaceTree.TypeInfoCache value = full.Value;
		if (value is NamespaceTree.TypeInfoCache.No)
		{
			full.Value = NamespaceTree.TypeInfoCache.NamespaceReference._N_constant_object;
		}
		Nemerle.Builtins.Tuple<list<list<SyntaxDefinition>>, list<NamespaceTree.Node>> tuple = add_open_nodes(open_namespaces, new list<NamespaceTree.Node>.Cons(full, list<NamespaceTree.Node>.Nil._N_constant_object), Location.Default, should_warn: false);
		list<list<SyntaxDefinition>> syntax_exts = tuple.Field0;
		list<NamespaceTree.Node> o = tuple.Field1;
		return CreateExtended(o, full, namespace_aliases, syntax_exts);
	}

	private Nemerle.Builtins.Tuple<list<list<SyntaxDefinition>>, list<NamespaceTree.Node>> add_open_nodes(list<NamespaceTree.Node> old, list<NamespaceTree.Node> added, Location loc, bool should_warn)
	{
		_N_closureOf_add_open_nodes_84481 n_closureOf_add_open_nodes_ = new _N_closureOf_add_open_nodes_84481();
		n_closureOf_add_open_nodes_._N_old_84494 = old;
		n_closureOf_add_open_nodes_._N_loc_84492 = loc;
		n_closureOf_add_open_nodes_._N_should_warn_84490 = should_warn;
		n_closureOf_add_open_nodes_._N__N_closurised_this_ptr_84486 = this;
		n_closureOf_add_open_nodes_._N_exts_84488 = list<list<SyntaxDefinition>>.Nil._N_constant_object;
		list<NamespaceTree.Node> n_old_ = n_closureOf_add_open_nodes_._N_old_84494;
		Function<NamespaceTree.Node, list<NamespaceTree.Node>, list<NamespaceTree.Node>> f = new _N__N_lambda__84471__84496(n_closureOf_add_open_nodes_);
		list<NamespaceTree.Node> field = added.FoldLeft(n_old_, f);
		return new Nemerle.Builtins.Tuple<list<list<SyntaxDefinition>>, list<NamespaceTree.Node>>(n_closureOf_add_open_nodes_._N_exts_84488, field);
	}

	[Macro("Nemerle.Assertions.Requires:method:postscan", 0, "short_name != \"\"")]
	private list<NamespaceTree.Node> add_alias_nodes(string short_name, list<string> long_name)
	{
		list<NamespaceTree.Node> list = null;
		if (!(short_name != ""))
		{
			throw new AssertionException("ncc\\hierarchy\\GlobalEnv.n", 722, "short_name != \"\"", "The ``Requires'' contract of method `add_alias_nodes' has been violated.".ToString());
		}
		list = list<NamespaceTree.Node>.Nil._N_constant_object;
		for (NamespaceTree.Node parent = current_namespace; parent != null; parent = parent.Parent)
		{
			NamespaceTree.Node node = new NamespaceTree.Node(parent, null, NamespaceTree.TypeInfoCache.No._N_constant_object);
			NamespaceTree.Node node2 = parent.Path(long_name);
			node.AddChild(short_name, node2);
			list = new list<NamespaceTree.Node>.Cons(node, list);
		}
		return list;
	}

	public GlobalEnv(string coded, ManagerClass in_manager)
	{
		int num = 0;
		int num2 = 0;
		char c = '\0';
		int num3 = 0;
		string text = null;
		base._002Ector();
		Defines = in_manager.CoreEnv.Defines;
		Manager = in_manager;
		nameTree = Manager.NameTree;
		num3 = 0;
		num2 = 0;
		text = "";
		current_namespace = nameTree.namespace_tree;
		open_namespaces = list<NamespaceTree.Node>.Nil._N_constant_object;
		namespace_aliases = list<Nemerle.Builtins.Tuple<string, string>>.Nil._N_constant_object;
		macro_ctx_cache = -1;
		checked
		{
			for (num = 0; num < coded.Length; num++)
			{
				c = coded[num];
				if (num3 == 0)
				{
					switch (c)
					{
					case '&':
						current_namespace = nameTree.namespace_tree.Path(coded.Substring(0, num));
						num3 = 1;
						num2 = num + 1;
						continue;
					case '=':
						break;
					default:
						continue;
					}
				}
				else if (num3 == 1)
				{
					switch (c)
					{
					case '=':
						break;
					case '#':
						open_namespaces = new list<NamespaceTree.Node>.Cons(nameTree.namespace_tree.Path(coded.Substring(num2, num - num2)), open_namespaces);
						num2 = num + 1;
						continue;
					case '&':
						open_namespaces = new list<NamespaceTree.Node>.Cons(nameTree.namespace_tree.Path(coded.Substring(num2, num - num2)), open_namespaces);
						num3 = 2;
						num2 = num + 1;
						continue;
					default:
						continue;
					}
				}
				else if (c != '=')
				{
					if (num3 == 3 && (c == '#' || c == '&'))
					{
						string text2 = coded.Substring(num2, num - num2);
						list<NamespaceTree.Node> x = add_alias_nodes(text, NString.Split(text2, '.'));
						open_namespaces = NList.RevAppend(x, open_namespaces);
						namespace_aliases = new list<Nemerle.Builtins.Tuple<string, string>>.Cons(new Nemerle.Builtins.Tuple<string, string>(text, text2), namespace_aliases);
						num2 = num + 1;
					}
					continue;
				}
				text = coded.Substring(num2, num - num2);
				num3 = 3;
				num2 = num + 1;
			}
		}
	}

	public int GetMacroContext()
	{
		checked
		{
			if (macro_ctx_cache == -1)
			{
				nameTree.prepare_macro_context_class();
				Function<string, string, string> instance = _N_collect__84590.Instance;
				Function<NamespaceTree.Node, list<string>, list<string>> instance2 = _N_extract__84600.Instance;
				list<string> list = NList.Sort(NList.RevMap(namespace_aliases, instance), _N_static_proxy_84613.single_instance);
				list<string> list2 = NList.Sort(NList.FoldLeft(open_namespaces, list<string>.Nil._N_constant_object, instance2), _N_static_proxy_84613.single_instance);
				string text = list.ToString("#");
				string text2 = list2.ToString("#");
				StringBuilder stringBuilder = new StringBuilder(current_namespace.GetDisplayName() + "&");
				StringBuilder stringBuilder2 = stringBuilder.Append(text2 + "&");
				stringBuilder2 = stringBuilder.Append(text + "&");
				option<int> option = nameTree.macro_contexts.Get(stringBuilder.ToString());
				if (option == option<int>.None._N_constant_object)
				{
					NamespaceTree namespaceTree = nameTree;
					namespaceTree.macro_context++;
					nameTree.macro_contexts.Add(stringBuilder.ToString(), nameTree.macro_context);
					macro_ctx_cache = nameTree.macro_context;
				}
				else
				{
					if (!(option is option<int>.Some))
					{
						throw new MatchFailureException();
					}
					int num = (macro_ctx_cache = ((option<int>.Some)option).val);
				}
			}
			return macro_ctx_cache;
		}
	}

	public override string ToString()
	{
		string text = string.Concat("GlobalEnv(" + current_namespace.GetDisplayName(), ": ");
		list<NamespaceTree.Node> list = open_namespaces;
		Function<NamespaceTree.Node, string> instance = _N__N_lambda__84631__84638.Instance;
		return string.Concat(text + list.Map(instance).ToString(), ")");
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
		if (_info.VisitedObjects.ContainsKey(this))
		{
			return;
		}
		_info.VisitedObjects[this] = 0;
		nameTree?.RelocateImplInternal(_info);
		list<NamespaceTree.Node> list = open_namespaces;
		if (list != null)
		{
			list = list;
			while (list is list<NamespaceTree.Node>.Cons)
			{
				NamespaceTree.Node hd = ((list<NamespaceTree.Node>.Cons)list).hd;
				list = ((list<NamespaceTree.Node>.Cons)list).tl;
				((ISupportRelocation)hd).RelocateImpl(_info);
				list = list;
			}
		}
	}

	void ISupportRelocation.RelocateImpl(RelocationInfo _info)
	{
		//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
		this.RelocateImplInternal(_info);
	}

	private bool _N_non_public_external_83728(_N_closureOf_LookupType_83706 _N_LookupType_cp_83727, TypeInfo t)
	{
		return (_N_LookupType_cp_83727._N_args_count_83713 != -1 && t.TyparmsCount != _N_LookupType_cp_83727._N_args_count_83713) || (!(t is TypeBuilder) && t.SystemType.IsNotPublic);
	}

	private option<TypeInfo> _N_check_access_83744(_N_closureOf_LookupType_83706 _N_LookupType_cp_83743, option<TypeInfo> x)
	{
		object result;
		if (x is option<TypeInfo>.Some)
		{
			TypeInfo val = ((option<TypeInfo>.Some)x).val;
			if (_N_non_public_external_83728(_N_LookupType_cp_83743, val))
			{
				result = option<TypeInfo>.None._N_constant_object;
			}
			else
			{
				val = ((option<TypeInfo>.Some)x).val;
				if (_N_LookupType_cp_83743._N_from_83715 != null && !val.CanAccess(_N_LookupType_cp_83743._N_from_83715))
				{
					goto IL_0063;
				}
				result = x;
			}
			goto IL_006f;
		}
		goto IL_0063;
		IL_0063:
		result = option<TypeInfo>.None._N_constant_object;
		goto IL_006f;
		IL_006f:
		return (option<TypeInfo>)result;
	}

	private static list<Nemerle.Builtins.Tuple<TypeInfo, IMember>> _N_add_members_from_83946(_N_closureOf_LookupSymbolExt_83924 _N_LookupSymbolExt_cp_83945, Nemerle.Builtins.Tuple<TypeInfo, TypeInfo> _N_pat_3380, list<Nemerle.Builtins.Tuple<TypeInfo, IMember>> acc)
	{
		list<Nemerle.Builtins.Tuple<TypeInfo, IMember>> result;
		while (true)
		{
			_N_closureOf_add_members_from_83952 n_closureOf_add_members_from_ = new _N_closureOf_add_members_from_83952();
			n_closureOf_add_members_from_._N_pt_83959 = _N_pat_3380.Field0;
			n_closureOf_add_members_from_._N_ti_83957 = _N_pat_3380.Field1;
			if (_N_LookupSymbolExt_cp_83945._N_visited_83935.Contains(new Nemerle.Builtins.Tuple<TypeInfo, TypeInfo>(n_closureOf_add_members_from_._N_pt_83959, n_closureOf_add_members_from_._N_ti_83957)))
			{
				result = acc;
				break;
			}
			list<IMember> list = ((!n_closureOf_add_members_from_._N_ti_83957.LookupMemberAvailable) ? list<IMember>.Nil._N_constant_object : n_closureOf_add_members_from_._N_ti_83957.LookupMember(_N_LookupSymbolExt_cp_83945._N_the_name_83931, _N_LookupSymbolExt_cp_83945._N_for_completion_83937));
			_N_LookupSymbolExt_cp_83945._N_visited_83935 = new list<Nemerle.Builtins.Tuple<TypeInfo, TypeInfo>>.Cons(new Nemerle.Builtins.Tuple<TypeInfo, TypeInfo>(n_closureOf_add_members_from_._N_pt_83959, n_closureOf_add_members_from_._N_ti_83957), _N_LookupSymbolExt_cp_83945._N_visited_83935);
			Function<IMember, list<Nemerle.Builtins.Tuple<TypeInfo, IMember>>, list<Nemerle.Builtins.Tuple<TypeInfo, IMember>>> f = new _N_collectNewMembers__83969(n_closureOf_add_members_from_);
			list<Nemerle.Builtins.Tuple<TypeInfo, IMember>> list2 = list.FoldLeft(acc, f);
			TypeDeclaration tydecl = n_closureOf_add_members_from_._N_ti_83957.GetTydecl();
			if (tydecl is TypeDeclaration.Alias && ((TypeDeclaration.Alias)tydecl).ty is FixedType.Class)
			{
				TypeInfo tycon = ((FixedType.Class)((TypeDeclaration.Alias)tydecl).ty).tycon;
				list<TypeVar> list3 = ((FixedType.Class)((TypeDeclaration.Alias)tydecl).ty).args;
				if (list3.Length == 0)
				{
					Nemerle.Builtins.Tuple<TypeInfo, TypeInfo> tuple = new Nemerle.Builtins.Tuple<TypeInfo, TypeInfo>(n_closureOf_add_members_from_._N_pt_83959, tycon);
					acc = list2;
					_N_pat_3380 = tuple;
					continue;
				}
				tycon = ((FixedType.Class)((TypeDeclaration.Alias)tydecl).ty).tycon;
				list3 = ((FixedType.Class)((TypeDeclaration.Alias)tydecl).ty).args;
				if (list3.Length > 0)
				{
					Nemerle.Builtins.Tuple<TypeInfo, TypeInfo> tuple2 = new Nemerle.Builtins.Tuple<TypeInfo, TypeInfo>(n_closureOf_add_members_from_._N_ti_83957, tycon);
					acc = list2;
					_N_pat_3380 = tuple2;
					continue;
				}
			}
			result = list2;
			break;
		}
		return result;
	}

	private static list<Nemerle.Builtins.Tuple<TypeInfo, IMember>> _N_lookup_members_83991(_N_closureOf_LookupSymbolExt_83924 _N_LookupSymbolExt_cp_83990, NamespaceTree.Node pref, list<Nemerle.Builtins.Tuple<TypeInfo, IMember>> acc)
	{
		list<TypeInfo> list;
		if (_N_LookupSymbolExt_cp_83990._N_type_node_83929 == null || !_N_LookupSymbolExt_cp_83990._N_type_part_83933.IsEmpty)
		{
			list = pref.LookupTypes(_N_LookupSymbolExt_cp_83990._N_type_part_83933);
			while (list is list<TypeInfo>.Cons)
			{
				TypeInfo hd = ((list<TypeInfo>.Cons)list).hd;
				list = ((list<TypeInfo>.Cons)list).tl;
				acc = _N_add_members_from_83946(_N_LookupSymbolExt_cp_83990, new Nemerle.Builtins.Tuple<TypeInfo, TypeInfo>(null, hd), acc);
				list = list;
			}
		}
		list = pref.LookupTypes(_N_LookupSymbolExt_cp_83990._N_name_83939, _N_LookupSymbolExt_cp_83990._N_for_completion_83937);
		while (list is list<TypeInfo>.Cons)
		{
			TypeInfo hd = ((list<TypeInfo>.Cons)list).hd;
			list = ((list<TypeInfo>.Cons)list).tl;
			IMember field = hd;
			if (!acc.Contains(new Nemerle.Builtins.Tuple<TypeInfo, IMember>(null, field)))
			{
				acc = new list<Nemerle.Builtins.Tuple<TypeInfo, IMember>>.Cons(new Nemerle.Builtins.Tuple<TypeInfo, IMember>(null, field), acc);
			}
			list = list;
		}
		return acc;
	}

	private static void _N_add_members_from_84210(_N_closureOf_LookupSymbolExtPriority_84188 _N_LookupSymbolExtPriority_cp_84209, Nemerle.Builtins.Tuple<TypeInfo, TypeInfo> _N_pat_3381, List<Nemerle.Builtins.Tuple<TypeInfo, IMember>> result)
	{
		TypeInfo field = _N_pat_3381.Field0;
		TypeInfo field2 = _N_pat_3381.Field1;
		if (_N_LookupSymbolExtPriority_cp_84209._N_visited_84199.Contains(new Nemerle.Builtins.Tuple<TypeInfo, TypeInfo>(field, field2)))
		{
			return;
		}
		list<IMember> list = ((!field2.LookupMemberAvailable) ? list<IMember>.Nil._N_constant_object : field2.LookupMember(_N_LookupSymbolExtPriority_cp_84209._N_the_name_84195, _N_LookupSymbolExtPriority_cp_84209._N_for_completion_84201));
		_N_LookupSymbolExtPriority_cp_84209._N_visited_84199.Add(new Nemerle.Builtins.Tuple<TypeInfo, TypeInfo>(field, field2));
		list = list;
		TypeInfo field3;
		while (list is list<IMember>.Cons)
		{
			IMember hd = ((list<IMember>.Cons)list).hd;
			list = ((list<IMember>.Cons)list).tl;
			hd = hd;
			if (!result.Contains(new Nemerle.Builtins.Tuple<TypeInfo, IMember>(field, hd)))
			{
				field3 = ((field != null) ? field : field2);
				result.Add(new Nemerle.Builtins.Tuple<TypeInfo, IMember>(field3, hd));
			}
			list = list;
		}
		TypeDeclaration tydecl = field2.GetTydecl();
		if (!(tydecl is TypeDeclaration.Alias) || !(((TypeDeclaration.Alias)tydecl).ty is FixedType.Class))
		{
			return;
		}
		field3 = ((FixedType.Class)((TypeDeclaration.Alias)tydecl).ty).tycon;
		list<TypeVar> list2 = ((FixedType.Class)((TypeDeclaration.Alias)tydecl).ty).args;
		if (list2.Length == 0)
		{
			_N_add_members_from_84210(_N_LookupSymbolExtPriority_cp_84209, new Nemerle.Builtins.Tuple<TypeInfo, TypeInfo>(field, field3), result);
			return;
		}
		field = ((FixedType.Class)((TypeDeclaration.Alias)tydecl).ty).tycon;
		list2 = ((FixedType.Class)((TypeDeclaration.Alias)tydecl).ty).args;
		if (list2.Length > 0)
		{
			_N_add_members_from_84210(_N_LookupSymbolExtPriority_cp_84209, new Nemerle.Builtins.Tuple<TypeInfo, TypeInfo>(field2, field), result);
		}
	}

	private static void _N_lookup_members_84243(_N_closureOf_LookupSymbolExtPriority_84188 _N_LookupSymbolExtPriority_cp_84242, NamespaceTree.Node pref, List<Nemerle.Builtins.Tuple<TypeInfo, IMember>> result)
	{
		list<TypeInfo> list;
		if (_N_LookupSymbolExtPriority_cp_84242._N_type_node_84193 == null || !_N_LookupSymbolExtPriority_cp_84242._N_type_part_84197.IsEmpty)
		{
			list = pref.LookupTypes(_N_LookupSymbolExtPriority_cp_84242._N_type_part_84197);
			while (list is list<TypeInfo>.Cons)
			{
				TypeInfo hd = ((list<TypeInfo>.Cons)list).hd;
				list = ((list<TypeInfo>.Cons)list).tl;
				_N_add_members_from_84210(_N_LookupSymbolExtPriority_cp_84242, new Nemerle.Builtins.Tuple<TypeInfo, TypeInfo>(null, hd), result);
				list = list;
			}
		}
		list = pref.LookupTypes(_N_LookupSymbolExtPriority_cp_84242._N_name_84203, _N_LookupSymbolExtPriority_cp_84242._N_for_completion_84201);
		while (list is list<TypeInfo>.Cons)
		{
			TypeInfo hd = ((list<TypeInfo>.Cons)list).hd;
			list = ((list<TypeInfo>.Cons)list).tl;
			IMember field = hd;
			if (!result.Contains(new Nemerle.Builtins.Tuple<TypeInfo, IMember>(null, field)))
			{
				result.Add(new Nemerle.Builtins.Tuple<TypeInfo, IMember>(null, field));
			}
			list = list;
		}
	}
}
