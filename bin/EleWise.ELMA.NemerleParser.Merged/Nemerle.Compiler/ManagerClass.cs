using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Collections;
using Nemerle.Compiler.Parsetree;
using Nemerle.Compiler.Typedtree;
using Nemerle.Core;
using Nemerle.Internal;

namespace Nemerle.Compiler;

public class ManagerClass : IEngine, ISupportRelocation
{
	public delegate void MessageEventHandler(Location loc, string msg);

	public delegate void SourceChangedHandler(ISource source);

	public delegate void InitDelegate();

	private sealed class _N__N_lambda__27116__27167 : Function<string, Nemerle.Builtins.Tuple<int, TimeSpan>, TimeSpan>
	{
		[SpecialName]
		public static readonly _N__N_lambda__27116__27167 Instance = new _N__N_lambda__27116__27167();

		[SpecialName]
		public sealed override TimeSpan apply(string _N__27165, Nemerle.Builtins.Tuple<int, TimeSpan> _N__27166)
		{
			return _N__27166.Field1;
		}
	}

	private sealed class _N_closureOf_WrapWithCurrentContext_27201
	{
		internal FunctionVoid _N_fn_27214;

		internal Location _N_location_27212;

		internal int _N_color_27210;

		internal ManagerClass _N__N_closurised_this_ptr_27208;

		internal GlobalEnv _N_context_27206;

		internal _N_closureOf_WrapWithCurrentContext_27201()
		{
		}
	}

	private sealed class _N__N_lambda__27193__27216 : FunctionVoid
	{
		[SpecialName]
		private _N_closureOf_WrapWithCurrentContext_27201 _N_WrapWithCurrentContext_closure_27220;

		public _N__N_lambda__27193__27216(_N_closureOf_WrapWithCurrentContext_27201 _N_WrapWithCurrentContext_closure_27220)
		{
			this._N_WrapWithCurrentContext_closure_27220 = _N_WrapWithCurrentContext_closure_27220;
		}

		[SpecialName]
		public sealed override void apply_void()
		{
			_N_WrapWithCurrentContext_closure_27220._N__N_closurised_this_ptr_27208.MacroColors.PushNewColor(_N_WrapWithCurrentContext_closure_27220._N_color_27210, _N_WrapWithCurrentContext_closure_27220._N_context_27206);
			try
			{
				Location n_location_ = _N_WrapWithCurrentContext_closure_27220._N_location_27212;
				bool flag = n_location_.FileIndex != 0;
				if (flag)
				{
					LocationStack.Push(n_location_);
				}
				try
				{
					_N_WrapWithCurrentContext_closure_27220._N_fn_27214.apply_void();
				}
				finally
				{
					if (flag)
					{
						LocationStack.RemoveTop();
					}
				}
			}
			finally
			{
				_N_WrapWithCurrentContext_closure_27220._N__N_closurised_this_ptr_27208.MacroColors.PopColor();
			}
		}
	}

	private sealed class _N_closureOf_ResetCompilerState_27548
	{
		internal ScanTypeHierarchy _N__N_obj_cache_27553;

		internal _N_closureOf_ResetCompilerState_27548()
		{
		}
	}

	private sealed class _N__N_method_lambda__27559 : FunctionVoid<TopDeclaration>
	{
		[SpecialName]
		private _N_closureOf_ResetCompilerState_27548 _N_ResetCompilerState_closure_27563;

		public _N__N_method_lambda__27559(_N_closureOf_ResetCompilerState_27548 _N_ResetCompilerState_closure_27563)
		{
			this._N_ResetCompilerState_closure_27563 = _N_ResetCompilerState_closure_27563;
		}

		[SpecialName]
		public sealed override void apply_void(TopDeclaration _N__27558)
		{
			_N_ResetCompilerState_closure_27563._N__N_obj_cache_27553.ProcessDeclaration(_N__27558);
		}
	}

	private sealed class _N_closureOf_LoadExternalLibraries_28419
	{
		internal ManagerClass _N__N_closurised_this_ptr_28428;

		internal Exception _N_exception_28426;

		internal list<string> _N_referencedLibraries_28424;

		internal _N_closureOf_LoadExternalLibraries_28419()
		{
		}
	}

	private sealed class _N__N_lambda__27782__28452 : FunctionVoid
	{
		[SpecialName]
		private _N_closureOf_LoadExternalLibraries_28419 _N_LoadExternalLibraries_closure_28456;

		public _N__N_lambda__27782__28452(_N_closureOf_LoadExternalLibraries_28419 _N_LoadExternalLibraries_closure_28456)
		{
			this._N_LoadExternalLibraries_closure_28456 = _N_LoadExternalLibraries_closure_28456;
		}

		[SpecialName]
		public sealed override void apply_void()
		{
			int num = 0;
			string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
			string[] files = Directory.GetFiles(baseDirectory, "ncc.parser.*.dll");
			num = 0;
			while (true)
			{
				_N_closureOf_loop_28462 n_closureOf_loop_ = new _N_closureOf_loop_28462();
				if (num >= files.Length)
				{
					break;
				}
				baseDirectory = (n_closureOf_loop_._N_file_28467 = files[num]);
				ManagerClass n__N_closurised_this_ptr_ = _N_LoadExternalLibraries_closure_28456._N__N_closurised_this_ptr_28428;
				_N_closureOf_LoadExternalLibraries_28419 n_LoadExternalLibraries_closure_ = _N_LoadExternalLibraries_closure_28456;
				FunctionVoid f = new _N__N_lambda__28370__28476(n_closureOf_loop_, _N_LoadExternalLibraries_closure_28456);
				n__N_closurised_this_ptr_._N_tryEx_28437(n_LoadExternalLibraries_closure_, f);
				num = checked(num + 1);
			}
		}
	}

	private sealed class _N_closureOf_loop_28462
	{
		internal string _N_file_28467;

		internal _N_closureOf_loop_28462()
		{
		}
	}

	private sealed class _N__N_lambda__28370__28476 : FunctionVoid
	{
		[SpecialName]
		private _N_closureOf_LoadExternalLibraries_28419 _N_LoadExternalLibraries_closure_28482;

		[SpecialName]
		private _N_closureOf_loop_28462 _N_loop_closure_28480;

		public _N__N_lambda__28370__28476(_N_closureOf_loop_28462 _N_loop_closure_28480, _N_closureOf_LoadExternalLibraries_28419 _N_LoadExternalLibraries_closure_28482)
		{
			this._N_loop_closure_28480 = _N_loop_closure_28480;
			this._N_LoadExternalLibraries_closure_28482 = _N_LoadExternalLibraries_closure_28482;
		}

		[SpecialName]
		public sealed override void apply_void()
		{
			_N_LoadExternalLibraries_closure_28482._N__N_closurised_this_ptr_28428.LibrariesManager.LoadPluginsFrom(_N_loop_closure_28480._N_file_28467, null, loadMacros: false);
		}
	}

	private sealed class _N_closureOf_foreach_loop_28488
	{
		internal string _N_lib_28493;

		internal _N_closureOf_foreach_loop_28488()
		{
		}
	}

	private sealed class _N__N_lambda__28383__28500 : FunctionVoid
	{
		[SpecialName]
		private _N_closureOf_LoadExternalLibraries_28419 _N_LoadExternalLibraries_closure_28506;

		[SpecialName]
		private _N_closureOf_foreach_loop_28488 _N_foreach_loop_closure_28504;

		public _N__N_lambda__28383__28500(_N_closureOf_foreach_loop_28488 _N_foreach_loop_closure_28504, _N_closureOf_LoadExternalLibraries_28419 _N_LoadExternalLibraries_closure_28506)
		{
			this._N_foreach_loop_closure_28504 = _N_foreach_loop_closure_28504;
			this._N_LoadExternalLibraries_closure_28506 = _N_LoadExternalLibraries_closure_28506;
		}

		[SpecialName]
		public sealed override void apply_void()
		{
			_N_LoadExternalLibraries_closure_28506._N__N_closurised_this_ptr_28428.LibrariesManager.AddLibrary(_N_foreach_loop_closure_28504._N_lib_28493, isUserReference: true);
		}
	}

	private sealed class _N__N_lambda__28387__28511 : FunctionVoid
	{
		[SpecialName]
		private _N_closureOf_LoadExternalLibraries_28419 _N_LoadExternalLibraries_closure_28515;

		public _N__N_lambda__28387__28511(_N_closureOf_LoadExternalLibraries_28419 _N_LoadExternalLibraries_closure_28515)
		{
			this._N_LoadExternalLibraries_closure_28515 = _N_LoadExternalLibraries_closure_28515;
		}

		[SpecialName]
		public sealed override void apply_void()
		{
			_N_LoadExternalLibraries_closure_28515._N__N_closurised_this_ptr_28428.LibrariesManager.LoadLibrariesContents();
		}
	}

	private sealed class _N_closureOf_foreach_loop_28521
	{
		internal string _N_file_28526;

		internal _N_closureOf_foreach_loop_28521()
		{
		}
	}

	private sealed class _N__N_lambda__28399__28533 : FunctionVoid
	{
		[SpecialName]
		private _N_closureOf_LoadExternalLibraries_28419 _N_LoadExternalLibraries_closure_28539;

		[SpecialName]
		private _N_closureOf_foreach_loop_28521 _N_foreach_loop_closure_28537;

		public _N__N_lambda__28399__28533(_N_closureOf_foreach_loop_28521 _N_foreach_loop_closure_28537, _N_closureOf_LoadExternalLibraries_28419 _N_LoadExternalLibraries_closure_28539)
		{
			this._N_foreach_loop_closure_28537 = _N_foreach_loop_closure_28537;
			this._N_LoadExternalLibraries_closure_28539 = _N_LoadExternalLibraries_closure_28539;
		}

		[SpecialName]
		public sealed override void apply_void()
		{
			_N_LoadExternalLibraries_closure_28539._N__N_closurised_this_ptr_28428.LibrariesManager.LoadPluginsFrom(_N_foreach_loop_closure_28537._N_file_28526);
		}
	}

	private sealed class _N__N_lambda__28403__28544 : FunctionVoid
	{
		[SpecialName]
		private _N_closureOf_LoadExternalLibraries_28419 _N_LoadExternalLibraries_closure_28548;

		public _N__N_lambda__28403__28544(_N_closureOf_LoadExternalLibraries_28419 _N_LoadExternalLibraries_closure_28548)
		{
			this._N_LoadExternalLibraries_closure_28548 = _N_LoadExternalLibraries_closure_28548;
		}

		[SpecialName]
		public sealed override void apply_void()
		{
			Function<string, bool> instance = _N_isNemerleDll__28553.Instance;
			_N_LoadExternalLibraries_closure_28548._N__N_closurised_this_ptr_28428.SystemTypeCache.Init();
			_N_LoadExternalLibraries_closure_28548._N__N_closurised_this_ptr_28428.InternalType.InitSystemTypes();
			if (!_N_LoadExternalLibraries_closure_28548._N__N_closurised_this_ptr_28428.Options.DoNotLoadStdlib || _N_LoadExternalLibraries_closure_28548._N_referencedLibraries_28424.Exists(instance))
			{
				_N_LoadExternalLibraries_closure_28548._N__N_closurised_this_ptr_28428.InternalType.InitNemerleTypes();
			}
			if (!_N_LoadExternalLibraries_closure_28548._N__N_closurised_this_ptr_28428.Options.DoNotLoadMacros)
			{
				_N_LoadExternalLibraries_closure_28548._N__N_closurised_this_ptr_28428.LoadNemerleMacros();
			}
		}
	}

	private sealed class _N_isNemerleDll__28553 : Function<string, bool>
	{
		[SpecialName]
		public static readonly _N_isNemerleDll__28553 Instance = new _N_isNemerleDll__28553();

		[SpecialName]
		public sealed override bool apply(string path)
		{
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(path);
			string extension = Path.GetExtension(path);
			return (string.IsNullOrEmpty(extension) || extension.Equals(".dll", StringComparison.OrdinalIgnoreCase)) && fileNameWithoutExtension.Equals("Nemerle", StringComparison.OrdinalIgnoreCase);
		}
	}

	private sealed class _N__N_lambda__28413__28578 : FunctionVoid
	{
		[SpecialName]
		private _N_closureOf_LoadExternalLibraries_28419 _N_LoadExternalLibraries_closure_28582;

		public _N__N_lambda__28413__28578(_N_closureOf_LoadExternalLibraries_28419 _N_LoadExternalLibraries_closure_28582)
		{
			this._N_LoadExternalLibraries_closure_28582 = _N_LoadExternalLibraries_closure_28582;
		}

		[SpecialName]
		public sealed override void apply_void()
		{
			_N_LoadExternalLibraries_closure_28582._N__N_closurised_this_ptr_28428.LibrariesManager.LoadExtensions();
		}
	}

	private sealed class _N_closureOf_Run_29213
	{
		internal DispatchingFileParser _N__N_obj_cache_29218;

		internal _N_closureOf_Run_29213()
		{
		}
	}

	private sealed class _N__N_method_lambda__29221 : Function<ISource, ParseResult>
	{
		[SpecialName]
		private _N_closureOf_Run_29213 _N_Run_closure_29225;

		public _N__N_method_lambda__29221(_N_closureOf_Run_29213 _N_Run_closure_29225)
		{
			this._N_Run_closure_29225 = _N_Run_closure_29225;
		}

		[SpecialName]
		public sealed override ParseResult apply(ISource _N__29220)
		{
			return _N_Run_closure_29225._N__N_obj_cache_29218.Parse(_N__29220);
		}
	}

	private sealed class _N_closureOf_CleanUpTypes_29465
	{
		internal _N_closureOf_CleanUpTypes_29465()
		{
		}
	}

	public FunctionVoid<TypeVar, TExpr, list<Parm>> ExtPointOverloadingRes;

	[ThreadStatic]
	public static ManagerClass Instance;

	private Solver _solver;

	public TypesManager Hierarchy;

	protected internal LibraryReferenceManager LibrariesManager;

	public NamespaceTree NameTree;

	public GlobalEnv CoreEnv;

	public MacroRegistry MacrosRegistry;

	public CompilationOptions Options;

	public MacroColorizator MacroColors;

	internal TypeVarEnv emptyTEnv;

	private CompilerComponentsFactory componentsFactory;

	private Map<Location, string> doc_comments;

	internal int tyinfo_counter;

	private int current_tyinfo_count;

	private int current_pb_stage;

	private bool pb_killed;

	internal Hashtable<object, bool> NotResolvedNestedDelayedTypings;

	private MessageEventHandler _N__N_event_field_of_ErrorOccured_3298;

	private MessageEventHandler _N__N_event_field_of_WarningOccured_3299;

	private MessageEventHandler _N__N_event_field_of_MessageOccured_3300;

	private CompilerEventHandler _N__N_event_field_of_CompilationStart_3301;

	private CompilerEventHandler _N__N_event_field_of_TypeTreeBuildFinish_3302;

	private CompilerEventHandler _N__N_event_field_of_BeforeSaveAssembly_3303;

	private Hashtable<int, string> IdToNameMap;

	private list<FunctionVoid> _beforeAddMembers;

	private list<FunctionVoid> _beforeWithTypedMembers;

	private IDictionary _userData;

	private readonly Hashtable<int, SourceChangedHandler> sourceChangedHandlers;

	internal int StaticTyVarId;

	internal int Typer_DT_Id;

	internal NamespaceTree.Node Typer_checked_macro;

	internal NamespaceTree.Node Typer_unchecked_macro;

	internal NamespaceTree.Node Typer_yield_macro;

	internal TypeVar TyVar_reuse_queue;

	internal int TyVar_Id;

	private int Util_Id;

	internal int AttributeMacroExpansion_global_nr;

	internal bool Macros_in_pattern;

	internal int Message_ErrorCount;

	internal int Message_WarningCount;

	protected internal TextWriter Message_output;

	protected internal FunctionVoid<Location, list<string>, list<Location>, string, Location, GlobalEnv, GlobalEnv> _afterUsingDirectiveParse;

	protected internal FunctionVoid _beforeNamespaceParse;

	protected internal FunctionVoid<Location, list<string>, list<Location>, GlobalEnv, GlobalEnv, Location, Location, Location> _afterNamespaceParse;

	public FunctionVoid<TopDeclaration> ScanningPipeline;

	public DispatchingFileParser Parser;

	private static InitDelegate _N__N_event_field_of_OnInit_3304;

	protected bool _isIntelliSenseMode;

	protected bool _isCompletionInProgress;

	protected internal list<string> _completionParameterNames;

	protected internal string _completionPattern;

	protected internal Location _completionLocation;

	private static readonly Nemerle.Builtins.Tuple<string, string>[] TypeKeywords;

	public override bool IsStop => false;

	public override int TypesTreeVersion => 0;

	public SystemTypeClass SystemTypeCache { get; private set; }

	public InternalTypeClass InternalType { get; private set; }

	internal AttributeCompilerClass AttributeCompiler { get; private set; }

	internal StatsClass Stats { get; private set; }

	public bool DelayedTypingsInProgress { get; internal set; }

	public bool DelayedTypingsSecondPass { get; internal set; }

	public bool IsSpeculativeTyping { get; internal set; }

	public Hashtable<string, Nemerle.Builtins.Tuple<int, TimeSpan>> MethodsStatistics { get; }

	public list<LibraryReference> ReferencedAssemblies => LibrariesManager.ReferencedAssemblies.NToList();

	public IDictionary UserData
	{
		get
		{
			if (_userData == null)
			{
				_userData = new ListDictionary();
			}
			return _userData;
		}
	}

	internal Hashtable<string, int> Message_emitted_hints { get; private set; }

	internal Hashtable<Nemerle.Builtins.Tuple<TypeInfo, TypeInfo>, bool> Typer_BetterTypeCache { get; private set; }

	public Assembly GeneratedAssembly => Hierarchy.GeneratedAssembly;

	public int CompletionMarkLine { get; set; }

	public int CompletionMarkChar { get; set; }

	public bool IsImportCompletion { get; protected set; }

	public Solver Solver
	{
		[CompilerGenerated]
		[DebuggerStepThrough]
		get
		{
			return _solver;
		}
	}

	public CompilerComponentsFactory ComponentsFactory
	{
		[CompilerGenerated]
		[DebuggerStepThrough]
		get
		{
			return componentsFactory;
		}
	}

	public Map<Location, string> DocComments
	{
		[CompilerGenerated]
		[DebuggerStepThrough]
		get
		{
			return doc_comments;
		}
		[DebuggerStepThrough]
		[CompilerGenerated]
		set
		{
			doc_comments = value;
		}
	}

	public bool IsIntelliSenseMode
	{
		[DebuggerStepThrough]
		[CompilerGenerated]
		get
		{
			return _isIntelliSenseMode;
		}
	}

	public bool IsCompletionInProgress
	{
		[DebuggerStepThrough]
		[CompilerGenerated]
		get
		{
			return _isCompletionInProgress;
		}
	}

	public event MessageEventHandler ErrorOccured
	{
		add
		{
			lock (this)
			{
				_N__N_event_field_of_ErrorOccured_3298 = (MessageEventHandler)Delegate.Combine(_N__N_event_field_of_ErrorOccured_3298, value);
			}
		}
		remove
		{
			lock (this)
			{
				_N__N_event_field_of_ErrorOccured_3298 = (MessageEventHandler)Delegate.Remove(_N__N_event_field_of_ErrorOccured_3298, value);
			}
		}
	}

	public event MessageEventHandler WarningOccured
	{
		add
		{
			lock (this)
			{
				_N__N_event_field_of_WarningOccured_3299 = (MessageEventHandler)Delegate.Combine(_N__N_event_field_of_WarningOccured_3299, value);
			}
		}
		remove
		{
			lock (this)
			{
				_N__N_event_field_of_WarningOccured_3299 = (MessageEventHandler)Delegate.Remove(_N__N_event_field_of_WarningOccured_3299, value);
			}
		}
	}

	public event MessageEventHandler MessageOccured
	{
		add
		{
			lock (this)
			{
				_N__N_event_field_of_MessageOccured_3300 = (MessageEventHandler)Delegate.Combine(_N__N_event_field_of_MessageOccured_3300, value);
			}
		}
		remove
		{
			lock (this)
			{
				_N__N_event_field_of_MessageOccured_3300 = (MessageEventHandler)Delegate.Remove(_N__N_event_field_of_MessageOccured_3300, value);
			}
		}
	}

	public event CompilerEventHandler CompilationStart
	{
		add
		{
			lock (this)
			{
				_N__N_event_field_of_CompilationStart_3301 = (CompilerEventHandler)Delegate.Combine(_N__N_event_field_of_CompilationStart_3301, value);
			}
		}
		remove
		{
			lock (this)
			{
				_N__N_event_field_of_CompilationStart_3301 = (CompilerEventHandler)Delegate.Remove(_N__N_event_field_of_CompilationStart_3301, value);
			}
		}
	}

	public event CompilerEventHandler TypeTreeBuildFinish
	{
		add
		{
			lock (this)
			{
				_N__N_event_field_of_TypeTreeBuildFinish_3302 = (CompilerEventHandler)Delegate.Combine(_N__N_event_field_of_TypeTreeBuildFinish_3302, value);
			}
		}
		remove
		{
			lock (this)
			{
				_N__N_event_field_of_TypeTreeBuildFinish_3302 = (CompilerEventHandler)Delegate.Remove(_N__N_event_field_of_TypeTreeBuildFinish_3302, value);
			}
		}
	}

	public event CompilerEventHandler BeforeSaveAssembly
	{
		add
		{
			lock (this)
			{
				_N__N_event_field_of_BeforeSaveAssembly_3303 = (CompilerEventHandler)Delegate.Combine(_N__N_event_field_of_BeforeSaveAssembly_3303, value);
			}
		}
		remove
		{
			lock (this)
			{
				_N__N_event_field_of_BeforeSaveAssembly_3303 = (CompilerEventHandler)Delegate.Remove(_N__N_event_field_of_BeforeSaveAssembly_3303, value);
			}
		}
	}

	public static event InitDelegate OnInit
	{
		add
		{
			lock (typeof(ManagerClass))
			{
				_N__N_event_field_of_OnInit_3304 = (InitDelegate)Delegate.Combine(_N__N_event_field_of_OnInit_3304, value);
			}
		}
		remove
		{
			lock (typeof(ManagerClass))
			{
				_N__N_event_field_of_OnInit_3304 = (InitDelegate)Delegate.Remove(_N__N_event_field_of_OnInit_3304, value);
			}
		}
	}

	static ManagerClass()
	{
		TypeKeywords = new Nemerle.Builtins.Tuple<string, string>[2]
		{
			new Nemerle.Builtins.Tuple<string, string>("void", "System.Void"),
			new Nemerle.Builtins.Tuple<string, string>("array", "System.Array")
		};
	}

	public void SetSolver(Solver solver)
	{
		_solver = solver;
	}

	public void CheckSolver()
	{
		if (Solver.IsTopLevel)
		{
		}
	}

	public override void BeginRelatedMessageSequence()
	{
	}

	public override void EndRelatedMessageSequence()
	{
	}

	public override void RequestOnBuildTypesTree()
	{
	}

	protected void OnTypeTreeBuildFinish()
	{
		CompilerEventHandler n__N_event_field_of_TypeTreeBuildFinish_ = _N__N_event_field_of_TypeTreeBuildFinish_3302;
		if (n__N_event_field_of_TypeTreeBuildFinish_ != null)
		{
			n__N_event_field_of_TypeTreeBuildFinish_(this);
		}
	}

	protected void OnBeforeSaveAssembly()
	{
		CompilerEventHandler n__N_event_field_of_BeforeSaveAssembly_ = _N__N_event_field_of_BeforeSaveAssembly_3303;
		if (n__N_event_field_of_BeforeSaveAssembly_ != null)
		{
			n__N_event_field_of_BeforeSaveAssembly_(this);
		}
	}

	internal void UpdateMethodsStatistics(string currentMethodKey, TimeSpan timeSpan)
	{
		Nemerle.Builtins.Tuple<int, TimeSpan> value = default(Nemerle.Builtins.Tuple<int, TimeSpan>);
		Nemerle.Builtins.Tuple<int, TimeSpan> value2 = ((!MethodsStatistics.TryGetValue(currentMethodKey, out value)) ? new Nemerle.Builtins.Tuple<int, TimeSpan>(1, timeSpan) : new Nemerle.Builtins.Tuple<int, TimeSpan>(checked(value.Field0 + 1), value.Field1 + timeSpan));
		MethodsStatistics[currentMethodKey] = value2;
	}

	private void ShowStatistics()
	{
		if (!Options.ShowCompilerStatistics || MethodsStatistics.Count <= 1)
		{
			return;
		}
		Nemerle.Builtins.Tuple<string, Nemerle.Builtins.Tuple<int, TimeSpan>>[] keyValuePairs = MethodsStatistics.KeyValuePairs;
		Function<string, Nemerle.Builtins.Tuple<int, TimeSpan>, TimeSpan> instance = _N__N_lambda__27116__27167.Instance;
		IEnumerator<Nemerle.Builtins.Tuple<string, Nemerle.Builtins.Tuple<int, TimeSpan>>> enumerator = keyValuePairs.OrderBy(instance.apply).GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Nemerle.Builtins.Tuple<string, Nemerle.Builtins.Tuple<int, TimeSpan>> current = enumerator.Current;
				string field = current.Field0;
				int field2 = current.Field1.Field0;
				TimeSpan field3 = current.Field1.Field1;
				string m = Convert.ToString(field) + ": " + Convert.ToString(field3) + "  " + Convert.ToString(field2);
				Message.Hint(m);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
	}

	private FunctionVoid WrapWithCurrentContext(FunctionVoid fn)
	{
		_N_closureOf_WrapWithCurrentContext_27201 n_closureOf_WrapWithCurrentContext_ = new _N_closureOf_WrapWithCurrentContext_27201();
		n_closureOf_WrapWithCurrentContext_._N_fn_27214 = fn;
		n_closureOf_WrapWithCurrentContext_._N__N_closurised_this_ptr_27208 = this;
		n_closureOf_WrapWithCurrentContext_._N_location_27212 = LocationStack.Top();
		n_closureOf_WrapWithCurrentContext_._N_color_27210 = MacroColors.Color;
		n_closureOf_WrapWithCurrentContext_._N_context_27206 = MacroColors.UseContext;
		return new _N__N_lambda__27193__27216(n_closureOf_WrapWithCurrentContext_);
	}

	private static void CallAndResetList(ref list<FunctionVoid> fancs)
	{
		if (fancs != null)
		{
			list<FunctionVoid> list = fancs;
			while (list is list<FunctionVoid>.Cons)
			{
				FunctionVoid hd = ((list<FunctionVoid>.Cons)list).hd;
				list<FunctionVoid> tl = ((list<FunctionVoid>.Cons)list).tl;
				FunctionVoid functionVoid = hd;
				functionVoid.apply_void();
				list = tl;
			}
			fancs = null;
		}
	}

	internal void OnBeforeAddMembers()
	{
		CallAndResetList(ref _beforeAddMembers);
	}

	public void ExecBeforeAddMembers(FunctionVoid fn)
	{
		_beforeAddMembers = new list<FunctionVoid>.Cons(WrapWithCurrentContext(fn), _beforeAddMembers);
	}

	internal void OnBeforeWithTypedMembers()
	{
		CallAndResetList(ref _beforeWithTypedMembers);
	}

	public void ExecBeforeWithTypedMembers(FunctionVoid fn)
	{
		_beforeWithTypedMembers = new list<FunctionVoid>.Cons(WrapWithCurrentContext(fn), _beforeWithTypedMembers);
	}

	public void NotifySourceChanged(ISource source)
	{
		Nemerle.Builtins.Tuple<SourceChangedHandler, bool> tuple = sourceChangedHandlers.TryGetValue(source.FileIndex);
		if (tuple.Field1)
		{
			SourceChangedHandler field = tuple.Field0;
			field(source);
		}
	}

	public void SubscribeSourceChanged(int fileIndex, SourceChangedHandler handler, bool invokeAfterSubscription = true)
	{
		Nemerle.Builtins.Tuple<SourceChangedHandler, bool> tuple = sourceChangedHandlers.TryGetValue(fileIndex);
		object obj;
		SourceChangedHandler field;
		if (tuple.Field1)
		{
			field = tuple.Field0;
			obj = (SourceChangedHandler)Delegate.Combine(field, handler);
		}
		else
		{
			obj = handler;
		}
		field = (SourceChangedHandler)obj;
		sourceChangedHandlers[fileIndex] = field;
		if (invokeAfterSubscription)
		{
			ISource source = GetSource(fileIndex);
			handler(source);
		}
	}

	public void UnsubscribeSourceChanged(int fileIndex, SourceChangedHandler handler)
	{
		Nemerle.Builtins.Tuple<SourceChangedHandler, bool> tuple = sourceChangedHandlers.TryGetValue(fileIndex);
		if (tuple.Field1)
		{
			SourceChangedHandler field = tuple.Field0;
			field = (SourceChangedHandler)Delegate.Remove(field, handler);
			if ((object)field == null)
			{
				sourceChangedHandlers.Remove(fileIndex);
			}
			else
			{
				sourceChangedHandlers[fileIndex] = field;
			}
		}
	}

	public bool HasSourceChangedSubscribers(int fileIndex)
	{
		return sourceChangedHandlers.ContainsKey(fileIndex);
	}

	protected void UnsubscribeSourceChangedHandler(int fileIndex)
	{
		sourceChangedHandlers.Remove(fileIndex);
	}

	protected void UnsubscribeSourceChangedHandlers()
	{
		sourceChangedHandlers.Clear();
	}

	public override ISource GetSource(int fileIndex)
	{
		return FileSource.ReadFile(Location.GetFileName(fileIndex), checkDuplicatedFiles: false, checkLastLineForLF: false);
	}

	internal void RunErrorOccured(Location loc, string msg)
	{
		MessageEventHandler n__N_event_field_of_ErrorOccured_ = _N__N_event_field_of_ErrorOccured_3298;
		if (n__N_event_field_of_ErrorOccured_ != null)
		{
			n__N_event_field_of_ErrorOccured_(loc, msg);
		}
	}

	internal void RunWarningOccured(Location loc, string msg)
	{
		MessageEventHandler n__N_event_field_of_WarningOccured_ = _N__N_event_field_of_WarningOccured_3299;
		if (n__N_event_field_of_WarningOccured_ != null)
		{
			n__N_event_field_of_WarningOccured_(loc, msg);
		}
	}

	internal void RunMessageOccured(Location loc, string msg)
	{
		MessageEventHandler n__N_event_field_of_MessageOccured_ = _N__N_event_field_of_MessageOccured_3300;
		if (n__N_event_field_of_MessageOccured_ != null)
		{
			n__N_event_field_of_MessageOccured_(loc, msg);
		}
	}

	public void InitOutput(TextWriter o)
	{
		Message_output = o;
	}

	protected override void FullResetNamespaceTree()
	{
		Hierarchy = null;
		Typer_checked_macro = null;
		Typer_unchecked_macro = null;
		Typer_yield_macro = null;
		Typer_BetterTypeCache.Clear();
		StaticTyVarId = 0;
		Typer_DT_Id = 0;
		TyVar_Id = 0;
		TyVar_reuse_queue = null;
		Util_Id = 0;
		IdToNameMap = null;
		AttributeMacroExpansion_global_nr = 0;
	}

	public int GetNewId()
	{
		checked
		{
			Util_Id++;
			return Util_Id;
		}
	}

	public int GetNewId([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name", "The ``NotNull'' contract of parameter ``name'' has been violated. See ncc\\passes.n:353:31:353:35: .");
		}
		checked
		{
			Util_Id++;
			if (IdToNameMap == null)
			{
				IdToNameMap = new Hashtable<int, string>();
			}
			IdToNameMap[Util_Id] = name;
			return Util_Id;
		}
	}

	public string GetIdName(int id)
	{
		string value = null;
		if (IdToNameMap != null)
		{
			IdToNameMap.TryGetValue(id, out value);
		}
		return value;
	}

	public bool HasName(int id)
	{
		bool result = false;
		Hashtable<int, string> idToNameMap = IdToNameMap;
		if (idToNameMap != null)
		{
			result = idToNameMap.ContainsKey(id);
		}
		return result;
	}

	protected void ResetCompilerState(CompilationOptions options)
	{
		_N_closureOf_ResetCompilerState_27548 n_closureOf_ResetCompilerState_ = new _N_closureOf_ResetCompilerState_27548();
		if (options == null)
		{
		}
		ExtPointOverloadingRes = null;
		Instance = null;
		_N_SystemTypeCache_5457 = null;
		_N_InternalType_5464 = null;
		_N_AttributeCompiler_5471 = null;
		_N_Stats_5478 = null;
		_solver = null;
		Hierarchy = null;
		LibrariesManager = null;
		NameTree = null;
		CoreEnv = null;
		MacrosRegistry = null;
		Options = null;
		MacroColors = null;
		emptyTEnv = null;
		componentsFactory = null;
		doc_comments = null;
		tyinfo_counter = 0;
		current_tyinfo_count = 0;
		current_pb_stage = 0;
		pb_killed = false;
		_N_DelayedTypingsInProgress_5504 = false;
		_N_DelayedTypingsSecondPass_5511 = false;
		_N_IsSpeculativeTyping_5518 = false;
		NotResolvedNestedDelayedTypings = null;
		_N__N_event_field_of_ErrorOccured_3298 = null;
		_N__N_event_field_of_WarningOccured_3299 = null;
		_N__N_event_field_of_MessageOccured_3300 = null;
		_N__N_event_field_of_CompilationStart_3301 = null;
		_N__N_event_field_of_TypeTreeBuildFinish_3302 = null;
		_N__N_event_field_of_BeforeSaveAssembly_3303 = null;
		IdToNameMap = null;
		_beforeAddMembers = null;
		_beforeWithTypedMembers = null;
		_userData = null;
		StaticTyVarId = 0;
		Typer_DT_Id = 0;
		Typer_checked_macro = null;
		Typer_unchecked_macro = null;
		Typer_yield_macro = null;
		TyVar_reuse_queue = null;
		TyVar_Id = 0;
		Util_Id = 0;
		AttributeMacroExpansion_global_nr = 0;
		Macros_in_pattern = false;
		Message_ErrorCount = 0;
		Message_WarningCount = 0;
		_N_Message_emitted_hints_5639 = null;
		_N_Typer_BetterTypeCache_5646 = null;
		Message_output = null;
		_afterUsingDirectiveParse = null;
		_beforeNamespaceParse = null;
		_afterNamespaceParse = null;
		ScanningPipeline = null;
		Parser = null;
		_isIntelliSenseMode = false;
		_isCompletionInProgress = false;
		_N_CompletionMarkLine_5698 = 0;
		_N_CompletionMarkChar_5705 = 0;
		_completionParameterNames = null;
		_completionPattern = null;
		_completionLocation = default(Location);
		_N_IsImportCompletion_5715 = false;
		Instance = this;
		Typer_BetterTypeCache = new Hashtable<Nemerle.Builtins.Tuple<TypeInfo, TypeInfo>, bool>();
		Message_emitted_hints = new Hashtable<string, int>();
		componentsFactory = CreateComponentsFactory();
		Parser = new DispatchingFileParser(this);
		n_closureOf_ResetCompilerState_._N__N_obj_cache_27553 = new ScanTypeHierarchy(this);
		FunctionVoid<TopDeclaration> functionVoid = (ScanningPipeline = new _N__N_method_lambda__27559(n_closureOf_ResetCompilerState_));
		Options = options;
		InternalType = new InternalTypeClass(this);
		SystemTypeCache = new SystemTypeClass(this);
		AttributeCompiler = new AttributeCompilerClass(this);
		Stats = new StatsClass();
		UnsubscribeSourceChangedHandlers();
	}

	public ManagerClass(CompilationOptions options)
	{
		_N_MethodsStatistics_5527 = new Hashtable<string, Nemerle.Builtins.Tuple<int, TimeSpan>>();
		sourceChangedHandlers = new Hashtable<int, SourceChangedHandler>(10);
		_isIntelliSenseMode = false;
		_isCompletionInProgress = false;
		_completionParameterNames = list<string>.Nil._N_constant_object;
		base._002Ector();
		ResetCompilerState(options);
	}

	public void MarkAsUsed(IMember member)
	{
		MarkAsUsed(member, Location.Default, trigger_obsolete_warn: true);
	}

	public void MarkAsUsed(IMember member, bool trigger_obsolete_warn)
	{
		MarkAsUsed(member, Location.Default, trigger_obsolete_warn);
	}

	public override void MarkAsUsed(IMember member, Location _location, bool trigger_obsolete_warn)
	{
		member.HasBeenUsed = trigger_obsolete_warn;
	}

	public override void MarkAsAssigned(IField member)
	{
		member.HasBeenAssigned = true;
	}

	public override void MarkAsAssigned(IField member, Location _location, bool trigger_obsolete_warn)
	{
		member.HasBeenAssigned = trigger_obsolete_warn;
	}

	protected override CompilerComponentsFactory CreateComponentsFactory()
	{
		return new CompilerComponentsFactory();
	}

	internal void MarkTypeBuilderCompiled()
	{
		checked
		{
			current_tyinfo_count++;
			ProgressBar(10 + unchecked(checked(current_tyinfo_count * 90) / tyinfo_counter));
		}
	}

	private void ProgressBar(int stage)
	{
		if (Options.ProgressBar)
		{
			int num = checked(stage * 60) / 100;
			num = ((num <= 60) ? num : 60);
			checked
			{
				int num2 = num - current_pb_stage;
				if ((pb_killed && num2 > 10) || (!pb_killed && num2 > 0))
				{
					Console.Write(string.Concat(string.Concat("\r" + new string('_', num), new string('.', 60 - num)), "\r"));
					current_pb_stage = num;
					pb_killed = false;
				}
			}
		}
	}

	public void KillProgressBar()
	{
		if (Options.ProgressBar && !pb_killed)
		{
			Console.Write("\n");
			pb_killed = true;
		}
	}

	protected bool shouldCreate(object obj)
	{
		return !Options.PersistentLibraries || obj == null;
	}

	private void CleanUp()
	{
		if (Hierarchy != null)
		{
			Hierarchy.Dispose();
		}
	}

	protected void InitCompiler()
	{
		string text = null;
		string text2 = null;
		string text3 = null;
		string text4 = null;
		MethodsStatistics.Clear();
		if (Options.TryStartDebugger)
		{
			CompilationOptions options = Options;
			if (options != null)
			{
				text2 = options.OutputFileName;
			}
			object path;
			if (text2 != null)
			{
				options = Options;
				if (options != null)
				{
					text3 = options.OutputFileName;
				}
				path = text3;
			}
			else
			{
				options = Options;
				if (options != null)
				{
					text4 = options.ProjectPath;
				}
				if (text4 != null)
				{
					options = Options;
					if (options != null)
					{
						text = options.ProjectPath;
					}
					path = text;
				}
				else
				{
					path = "?";
				}
			}
			text = Path.GetFileName((string)path);
		}
		_userData = null;
		Typer_BetterTypeCache.Clear();
		if (_N__N_event_field_of_CompilationStart_3301 != null)
		{
			_N__N_event_field_of_CompilationStart_3301(this);
		}
		Stats.Reset();
		Message_emitted_hints.Clear();
		Macros_in_pattern = false;
		Message_ErrorCount = 0;
		Message_WarningCount = 0;
		MacroColors = new MacroColorizator();
		if (shouldCreate(NameTree))
		{
			NameTree = new NamespaceTree(this);
		}
		else
		{
			NameTree.Init();
		}
		if (shouldCreate(MacrosRegistry))
		{
			MacrosRegistry = new MacroRegistry(this);
		}
		if (shouldCreate(LibrariesManager))
		{
			LibrariesManager = ComponentsFactory.CreateLibraryReferenceManager(this, Options.LibraryPaths);
		}
		Options.Validate();
		_solver = new Solver(this);
		emptyTEnv = new TypeVarEnv(this);
		if (Options.LexerStoreComments)
		{
			DocComments = new Map<Location, string>();
		}
		else
		{
			DocComments = null;
		}
		if (Hierarchy != null)
		{
			Hierarchy.RemoveProgramTypes();
		}
		if (Parser == null)
		{
			Parser = new DispatchingFileParser(this);
		}
		if (_N__N_event_field_of_OnInit_3304 != null)
		{
			_N__N_event_field_of_OnInit_3304();
		}
	}

	protected internal void LoadExternalLibraries()
	{
		_N_closureOf_LoadExternalLibraries_28419 n_closureOf_LoadExternalLibraries_ = new _N_closureOf_LoadExternalLibraries_28419();
		n_closureOf_LoadExternalLibraries_._N__N_closurised_this_ptr_28428 = this;
		MethodsStatistics.Clear();
		if (shouldCreate(InternalType.Void))
		{
			if (!Options.DoNotLoadStdlib)
			{
				LibrariesManager.AddLibrary("mscorlib", isUserReference: true);
				LibrariesManager.AddLibrary("System", isUserReference: true);
				LibrariesManager.AddLibrary("Nemerle", isUserReference: true);
				LibrariesManager.AddLibrary("System.Xml", isUserReference: true);
			}
			n_closureOf_LoadExternalLibraries_._N_exception_28426 = null;
			FunctionVoid f;
			if (!Options.DisableExternalParsers)
			{
				f = new _N__N_lambda__27782__28452(n_closureOf_LoadExternalLibraries_);
				_N_tryEx_28437(n_closureOf_LoadExternalLibraries_, f);
			}
			n_closureOf_LoadExternalLibraries_._N_referencedLibraries_28424 = Options.ReferencedLibraries.Reverse();
			list<string> list = n_closureOf_LoadExternalLibraries_._N_referencedLibraries_28424;
			while (true)
			{
				_N_closureOf_foreach_loop_28488 n_closureOf_foreach_loop_ = new _N_closureOf_foreach_loop_28488();
				if (!(list is list<string>.Cons))
				{
					break;
				}
				string hd = ((list<string>.Cons)list).hd;
				list = ((list<string>.Cons)list).tl;
				n_closureOf_foreach_loop_._N_lib_28493 = hd;
				f = new _N__N_lambda__28383__28500(n_closureOf_foreach_loop_, n_closureOf_LoadExternalLibraries_);
				_N_tryEx_28437(n_closureOf_LoadExternalLibraries_, f);
				list = list;
			}
			f = new _N__N_lambda__28387__28511(n_closureOf_LoadExternalLibraries_);
			_N_tryEx_28437(n_closureOf_LoadExternalLibraries_, f);
			list = Options.MacrosToLoad.Reverse();
			while (true)
			{
				_N_closureOf_foreach_loop_28521 n_closureOf_foreach_loop_2 = new _N_closureOf_foreach_loop_28521();
				if (!(list is list<string>.Cons))
				{
					break;
				}
				string hd = ((list<string>.Cons)list).hd;
				list = ((list<string>.Cons)list).tl;
				n_closureOf_foreach_loop_2._N_file_28526 = hd;
				f = new _N__N_lambda__28399__28533(n_closureOf_foreach_loop_2, n_closureOf_LoadExternalLibraries_);
				_N_tryEx_28437(n_closureOf_LoadExternalLibraries_, f);
				list = list;
			}
			f = new _N__N_lambda__28403__28544(n_closureOf_LoadExternalLibraries_);
			_N_tryEx_28437(n_closureOf_LoadExternalLibraries_, f);
			CoreEnv = GlobalEnv.CreateCore(NameTree);
			f = new _N__N_lambda__28413__28578(n_closureOf_LoadExternalLibraries_);
			_N_tryEx_28437(n_closureOf_LoadExternalLibraries_, f);
			if (n_closureOf_LoadExternalLibraries_._N_exception_28426 != null)
			{
				throw n_closureOf_LoadExternalLibraries_._N_exception_28426;
			}
		}
		else
		{
			LibrariesManager.RemoveInternalExtensionMethods();
		}
	}

	protected override void LoadNemerleMacros()
	{
		string text = typeof(ManagerClass).Assembly.GetName().Version.ToString();
		LibrariesManager.LoadPluginsFrom("Nemerle.Macros", ", Version=" + Convert.ToString(text) + ", Culture=neutral, PublicKeyToken=5291d186334f6101", loadMacros: true, loadParsers: false);
	}

	public void Run()
	{
		_N_closureOf_Run_29213 n_closureOf_Run_ = new _N_closureOf_Run_29213();
		Instance = this;
		try
		{
			InitCompiler();
			try
			{
				ProgressBar(1);
				LoadExternalLibraries();
				ProgressBar(2);
				Hierarchy = new TypesManager(this);
				list<ISource> sources = Options.Sources;
				n_closureOf_Run_._N__N_obj_cache_29218 = Parser;
				Function<ISource, ParseResult> convert = new _N__N_method_lambda__29221(n_closureOf_Run_);
				list<ParseResult> list = sources.Map(convert);
				Message.MaybeBailout();
				ProgressBar(5);
				list<ParseResult> list2 = list;
				while (list2 is list<ParseResult>.Cons)
				{
					ParseResult hd = ((list<ParseResult>.Cons)list2).hd;
					list<ParseResult> list3 = ((list<ParseResult>.Cons)list2).tl;
					ParseResult parseResult = hd;
					list<TopDeclaration> list4 = parseResult.TopDeclarations;
					while (list4 is list<TopDeclaration>.Cons)
					{
						TopDeclaration hd2 = ((list<TopDeclaration>.Cons)list4).hd;
						list<TopDeclaration> list5 = ((list<TopDeclaration>.Cons)list4).tl;
						TopDeclaration n_wildcard_ = hd2;
						ScanningPipeline.apply_void(n_wildcard_);
						list4 = list5;
					}
					list2 = list3;
				}
				if (Options.DoNotLoadStdlib)
				{
					InternalType.InitNemerleTypes();
				}
				ProgressBar(8);
				Hierarchy.Run();
			}
			finally
			{
				OnTypeTreeBuildFinish();
			}
			if (Message.SeenError)
			{
				NameTree.CheckReferencedNamespaces();
			}
			Hierarchy.CreateAssembly();
			ProgressBar(10);
			Hierarchy.EmitAuxDecls();
			if (Message.SeenError)
			{
				NameTree.CheckReferencedNamespaces();
			}
			NameTree.CheckReferencedNamespaces();
			Hierarchy.EmitDecls();
			Message.MaybeBailout();
			NameTree.FinishMacroContextClass();
			Hierarchy.CheckForUnusedGlobalSymbols();
			Hierarchy.CheckFinalization();
			if (Options.XmlDocOutputFileName != null)
			{
				XmlDoc xmlDoc = new XmlDoc(DocComments, Options.XmlDocOutputFileName);
				list<TypeBuilder> list6 = Hierarchy.TopTypeBuilders();
				while (list6 is list<TypeBuilder>.Cons)
				{
					TypeBuilder hd3 = ((list<TypeBuilder>.Cons)list6).hd;
					list<TypeBuilder> list7 = ((list<TypeBuilder>.Cons)list6).tl;
					TypeBuilder typeBuilder = hd3;
					Location location = typeBuilder.Location;
					bool flag = location.FileIndex != 0;
					if (flag)
					{
						LocationStack.Push(location);
					}
					try
					{
						xmlDoc.DumpType(typeBuilder);
					}
					finally
					{
						if (flag)
						{
							LocationStack.RemoveTop();
						}
					}
					list6 = list7;
				}
				xmlDoc.Save();
			}
			OnBeforeSaveAssembly();
			if (!Options.CompileToMemory)
			{
				Hierarchy.SaveAssembly();
			}
			ShowStatistics();
			Message.MaybeBailout();
			KillProgressBar();
			Stats.Run(this);
		}
		finally
		{
			CleanUp();
			if (Options.PersistentLibraries)
			{
				Hierarchy.RemoveProgramTypes();
			}
		}
	}

	public TypeInfo Lookup(string typeName)
	{
		return LookupTypeInfo(typeName);
	}

	public TypeInfo LookupTypeInfo(string typeName)
	{
		option<TypeInfo> option = NameTree.LookupExactType(typeName);
		if (option is option<TypeInfo>.Some)
		{
			return ((option<TypeInfo>.Some)option).val;
		}
		if (option == option<TypeInfo>.None._N_constant_object)
		{
			if (!Message.SeenError)
			{
				string text = ("internal type " + Convert.ToString(typeName) + " not found").ToString();
				Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
			}
			throw new AssertionException("ncc\\passes.n", 755, "", ("internal type " + Convert.ToString(typeName) + " not found").ToString());
		}
		throw new MatchFailureException();
	}

	public TypeInfo Lookup(string typeName, int argsCount)
	{
		return LookupTypeInfo(typeName, argsCount);
	}

	public TypeInfo LookupTypeInfo(string typeName, int argsCount)
	{
		option<TypeInfo> option = NameTree.LookupExactType(typeName, argsCount);
		if (option is option<TypeInfo>.Some)
		{
			return ((option<TypeInfo>.Some)option).val;
		}
		if (option == option<TypeInfo>.None._N_constant_object)
		{
			if (!Message.SeenError)
			{
				string text = ("internal type " + Convert.ToString(typeName) + " with " + Convert.ToString(argsCount) + " type arguments not found").ToString();
				Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
			}
			throw new AssertionException("ncc\\passes.n", 771, "", ("internal type " + Convert.ToString(typeName) + " with " + Convert.ToString(argsCount) + " type arguments not found").ToString());
		}
		throw new MatchFailureException();
	}

	public Type LookupSystemType(string typeName)
	{
		option<Type> option = NameTree.LookupSystemType(typeName);
		if (option is option<Type>.Some)
		{
			return ((option<Type>.Some)option).val;
		}
		if (option == option<Type>.None._N_constant_object)
		{
			if (!Message.SeenError)
			{
				string text = ("internal type " + Convert.ToString(typeName) + " not found").ToString();
				Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
			}
			throw new AssertionException("ncc\\passes.n", 781, "", ("internal type " + Convert.ToString(typeName) + " not found").ToString());
		}
		throw new MatchFailureException();
	}

	protected internal override bool IsExtensionMethod(IMethod method, TypeVar tyVar2)
	{
		//Discarded unreachable code: IL_0006
		throw new NotImplementedException();
	}

	protected internal override TExpr Complete(PExpr expression, TypeVar expected, Typer typer, GlobalEnv env)
	{
		//Discarded unreachable code: IL_0006
		throw new NotImplementedException();
	}

	protected internal override void CompletePattern(PExpr expression, TypeVar matched_value_type, Typer.PatternTyper patternTyper, GlobalEnv env)
	{
		//Discarded unreachable code: IL_0006
		throw new NotImplementedException();
	}

	protected internal override void CompleteTypeRef(PExpr expression, TypeBuilder curTypeBuilder, GlobalEnv env)
	{
		int num = 0;
		PExpr pExpr;
		Name name;
		if (expression is PExpr.ToComplete)
		{
			name = ((PExpr.ToComplete)expression).body;
			pExpr = null;
		}
		else
		{
			if (!(expression is PExpr.Member) || !(((PExpr.Member)expression).member is Splicable.HalfId))
			{
				return;
			}
			pExpr = ((PExpr.Member)expression).obj;
			name = ((Splicable.HalfId)((PExpr.Member)expression).member).prefix;
		}
		pExpr = pExpr;
		name = name;
		List<Elem> list = new List<Elem>();
		list<NamespaceTree.Node>.Cons nss = new list<NamespaceTree.Node>.Cons(CoreEnv.NameTree.NamespaceTree, name.GetEnv(CoreEnv).OpenNamespaces);
		Completion.AddTypesAndNamespaces(list, nss, pExpr, name, noMacros: true, noMembers: true);
		Nemerle.Builtins.Tuple<string, string>[] typeKeywords = TypeKeywords;
		for (num = 0; num < typeKeywords.Length; num = checked(num + 1))
		{
			Nemerle.Builtins.Tuple<string, string> tuple = typeKeywords[num];
			string field = tuple.Field0;
			string field2 = tuple.Field1;
			if (Completion.MatchName(field, name.Id))
			{
				list.Add(new Elem.Simple(field, field2, 0));
			}
		}
		if (curTypeBuilder != null)
		{
			list<StaticTypeVar> list2 = ((!(curTypeBuilder.Typarms != null)) ? list<StaticTypeVar>.Nil._N_constant_object : curTypeBuilder.Typarms);
			while (list2 is list<StaticTypeVar>.Cons)
			{
				StaticTypeVar hd = ((list<StaticTypeVar>.Cons)list2).hd;
				list2 = ((list<StaticTypeVar>.Cons)list2).tl;
				hd = hd;
				if (Completion.MatchName(hd.Name, name.Id))
				{
					list.Add(new Elem.Simple(hd.Name, "Type parameter", 0));
				}
				list2 = list2;
			}
		}
		CompletionResult completionResult = new CompletionResult(list, name.Id, name.Location, pExpr != null);
		completionResult.Env = env;
		throw completionResult;
	}

	protected void CleanUpTypes()
	{
		_N_closureOf_CleanUpTypes_29465 n_CleanUpTypes_cp_ = new _N_closureOf_CleanUpTypes_29465();
		if (NameTree.NamespaceTree.Children != null)
		{
			_N_resetChildren_29471(n_CleanUpTypes_cp_, NameTree.NamespaceTree.Children);
		}
	}

	[CompilerGenerated]
	internal override void RelocateImplInternal(RelocationInfo _info)
	{
		if (!_info.VisitedObjects.ContainsKey(this))
		{
			_info.VisitedObjects[this] = 0;
			_completionLocation = Completion.Relocate(_completionLocation, _info);
			Parser?.RelocateImplInternal(_info);
			componentsFactory?.RelocateImplInternal(_info);
			emptyTEnv?.RelocateImplInternal(_info);
			MacroColors?.RelocateImplInternal(_info);
			Options?.RelocateImplInternal(_info);
			MacrosRegistry?.RelocateImplInternal(_info);
			NameTree?.RelocateImplInternal(_info);
			LibrariesManager?.RelocateImplInternal(_info);
			_solver?.RelocateImplInternal(_info);
		}
	}

	void ISupportRelocation.RelocateImpl(RelocationInfo _info)
	{
		//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
		this.RelocateImplInternal(_info);
	}

	private void _N_tryEx_28437(_N_closureOf_LoadExternalLibraries_28419 _N_LoadExternalLibraries_cp_28436, FunctionVoid f)
	{
		Exception n_exception_ = default(Exception);
		try
		{
			f.apply_void();
		}
		catch (object obj) when (((Func<bool>)delegate
		{
			// Could not convert BlockContainer to single expression
			Exception obj2 = obj as Exception;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			if (obj2 != null)
			{
				n_exception_ = obj2;
				result = (IsIntelliSenseMode ? 1 : 0);
			}
			else
			{
				result = 0;
			}
			return (byte)result != 0;
		}).Invoke())
		{
			if (_N_LoadExternalLibraries_cp_28436._N_exception_28426 == null)
			{
				_N_LoadExternalLibraries_cp_28436._N_exception_28426 = n_exception_;
			}
		}
	}

	private static void _N_resetChildren_29471(_N_closureOf_CleanUpTypes_29465 _N_CleanUpTypes_cp_29470, Hashtable<string, NamespaceTree.Node> children)
	{
		foreach (NamespaceTree.Node value2 in children.Values)
		{
			NamespaceTree.Node node = value2;
			if (node.Children != null)
			{
				_N_resetChildren_29471(_N_CleanUpTypes_cp_29470, node.Children);
			}
			NamespaceTree.TypeInfoCache value = node.Value;
			if (value is NamespaceTree.TypeInfoCache.Cached)
			{
				TypeInfo tycon = ((NamespaceTree.TypeInfoCache.Cached)value).tycon;
				tycon.CleanUp();
			}
			else if (value is NamespaceTree.TypeInfoCache.CachedAmbiguous)
			{
				list<TypeInfo> list = ((NamespaceTree.TypeInfoCache.CachedAmbiguous)value).elems;
				list<TypeInfo> list2 = list;
				while (list2 is list<TypeInfo>.Cons)
				{
					TypeInfo hd = ((list<TypeInfo>.Cons)list2).hd;
					list<TypeInfo> list3 = ((list<TypeInfo>.Cons)list2).tl;
					TypeInfo typeInfo = hd;
					typeInfo.CleanUp();
					list2 = list3;
				}
			}
		}
	}
}
