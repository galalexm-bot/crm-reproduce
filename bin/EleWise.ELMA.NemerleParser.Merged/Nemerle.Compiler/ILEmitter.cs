using System;
using System.Diagnostics;
using System.Diagnostics.SymbolStore;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Nemerle.Builtins;
using Nemerle.Collections;
using Nemerle.Compiler.Parsetree;
using Nemerle.Compiler.Typedtree;
using Nemerle.Core;
using Nemerle.Internal;
using Nemerle.Utility;

namespace Nemerle.Compiler;

internal class ILEmitter : ISupportRelocation
{
	private class NemerleGenerator : ISupportRelocation
	{
		private sealed class _N_closureOf_Emit_76200
		{
			internal NemerleGenerator _N__N_closurised_this_ptr_76205;

			internal _N_closureOf_Emit_76200()
			{
			}
		}

		private sealed class _N__N_lambda__76193__76207 : FunctionVoid<Label>
		{
			[SpecialName]
			private _N_closureOf_Emit_76200 _N_Emit_closure_76211;

			public _N__N_lambda__76193__76207(_N_closureOf_Emit_76200 _N_Emit_closure_76211)
			{
				this._N_Emit_closure_76211 = _N_Emit_closure_76211;
			}

			[SpecialName]
			public sealed override void apply_void(Label l)
			{
				_N_Emit_closure_76211._N__N_closurised_this_ptr_76205.jumped[l] = null;
			}
		}

		private readonly ILGenerator _ilg;

		private ISymbolDocumentWriter _document;

		private readonly Hashtable<Label, object> jumped = new Hashtable<Label, object>();

		private bool _throw;

		private bool _marked;

		private bool _first_code = true;

		public NemerleGenerator(ILGenerator ilg)
		{
			_ilg = ilg;
		}

		public void SetDocument(ISymbolDocumentWriter document)
		{
			_document = document;
		}

		public void BeginCatchBlock(Type tp)
		{
			_throw = false;
			_ilg.BeginCatchBlock(tp);
		}

		public void BeginExceptFilterBlock()
		{
			_throw = false;
			_ilg.BeginExceptFilterBlock();
		}

		public Label BeginExceptionBlock()
		{
			return _ilg.BeginExceptionBlock();
		}

		public void BeginFaultBlock()
		{
			_throw = false;
			_ilg.BeginFaultBlock();
		}

		public void BeginFinallyBlock()
		{
			_throw = false;
			_ilg.BeginFinallyBlock();
		}

		public void EndExceptionBlock()
		{
			_throw = false;
			_ilg.EndExceptionBlock();
		}

		public void ThrowException(Type excType)
		{
			_ilg.ThrowException(excType);
		}

		public void BeginScope()
		{
			_ilg.BeginScope();
		}

		public void EndScope()
		{
			_ilg.EndScope();
		}

		public LocalBuilder DeclareLocal(Type localType)
		{
			return _ilg.DeclareLocal(localType);
		}

		public LocalBuilder DeclareLocal(Type localType, bool pinned)
		{
			return _ilg.DeclareLocal(localType, pinned);
		}

		public Label DefineLabel()
		{
			return _ilg.DefineLabel();
		}

		public void Emit(OpCode opcode)
		{
			Emited(opcode);
			_ilg.Emit(opcode);
		}

		public void Emit(OpCode opcode, byte arg)
		{
			Emited(opcode);
			_ilg.Emit(opcode, arg);
		}

		public void Emit(OpCode opcode, ConstructorInfo con)
		{
			Emited(opcode);
			_ilg.Emit(opcode, con);
		}

		public void Emit(OpCode opcode, double arg)
		{
			Emited(opcode);
			_ilg.Emit(opcode, arg);
		}

		public void Emit(OpCode opcode, FieldInfo field)
		{
			Emited(opcode);
			_ilg.Emit(opcode, field);
		}

		public void Emit(OpCode opcode, float arg)
		{
			Emited(opcode);
			_ilg.Emit(opcode, arg);
		}

		public void Emit(OpCode opcode, int arg)
		{
			Emited(opcode);
			_ilg.Emit(opcode, arg);
		}

		public void Emit(OpCode opcode, Label label)
		{
			Emited(opcode);
			jumped[label] = null;
			_ilg.Emit(opcode, label);
		}

		public void Emit(OpCode opcode, Label[] labels)
		{
			_N_closureOf_Emit_76200 n_closureOf_Emit_ = new _N_closureOf_Emit_76200();
			n_closureOf_Emit_._N__N_closurised_this_ptr_76205 = this;
			Emited(opcode);
			FunctionVoid<Label> f = new _N__N_lambda__76193__76207(n_closureOf_Emit_);
			labels.Iter(f);
			_ilg.Emit(opcode, labels);
		}

		public void Emit(OpCode opcode, LocalBuilder local)
		{
			Emited(opcode);
			_ilg.Emit(opcode, local);
		}

		public void Emit(OpCode opcode, long arg)
		{
			Emited(opcode);
			_ilg.Emit(opcode, arg);
		}

		public void Emit(OpCode opcode, MethodInfo meth)
		{
			Emited(opcode);
			_ilg.Emit(opcode, meth);
		}

		public void Emit(OpCode opcode, sbyte arg)
		{
			Emited(opcode);
			_ilg.Emit(opcode, arg);
		}

		public void Emit(OpCode opcode, short arg)
		{
			Emited(opcode);
			_ilg.Emit(opcode, arg);
		}

		public void Emit(OpCode opcode, SignatureHelper signature)
		{
			Emited(opcode);
			_ilg.Emit(opcode, signature);
		}

		public void Emit(OpCode opcode, string str)
		{
			Emited(opcode);
			_ilg.Emit(opcode, str);
		}

		public void Emit(OpCode opcode, Type cls)
		{
			Emited(opcode);
			_ilg.Emit(opcode, cls);
		}

		public void EmitCall(OpCode opcode, MethodInfo methodInfo, Type[] optionalParameterTypes)
		{
			Emited(opcode);
			_ilg.EmitCall(opcode, methodInfo, optionalParameterTypes);
		}

		public void EmitCalli(OpCode opcode, CallingConvention unmanagedCallConv, Type returnType, Type[] parameterTypes)
		{
			Emited(opcode);
			_ilg.EmitCalli(opcode, unmanagedCallConv, returnType, parameterTypes);
		}

		public void EmitCalli(OpCode opcode, CallingConventions callingConvention, Type returnType, Type[] parameterTypes, Type[] optionalParameterTypes)
		{
			Emited(opcode);
			_ilg.EmitCalli(opcode, callingConvention, returnType, parameterTypes, optionalParameterTypes);
		}

		public void EmitWriteLine(FieldInfo fld)
		{
			_ilg.EmitWriteLine(fld);
		}

		public void EmitWriteLine(LocalBuilder localBuilder)
		{
			_ilg.EmitWriteLine(localBuilder);
		}

		public void EmitWriteLine(string value)
		{
			_ilg.EmitWriteLine(value);
		}

		public void MarkLabel(Label loc, bool reset_throw = false)
		{
			if (reset_throw || jumped.Contains(loc))
			{
				_throw = false;
			}
			_ilg.MarkLabel(loc);
			if (_marked)
			{
				_marked = false;
				_ilg.MarkSequencePoint(_document, 16707566, 0, 16707566, 0);
				if (!_throw)
				{
					_ilg.Emit(OpCodes.Nop);
				}
				else
				{
					_ilg.Emit(OpCodes.Br, loc);
				}
			}
		}

		public void MarkSequencePoint(ISymbolDocumentWriter document, int startLine, int startColumn, int endLine, int endColumn)
		{
			if (!_throw)
			{
				_marked = true;
				_ilg.MarkSequencePoint(document, startLine, startColumn, endLine, endColumn);
				_ilg.Emit(OpCodes.Nop);
			}
		}

		public void UsingNamespace(string usingNamespace)
		{
			_ilg.UsingNamespace(usingNamespace);
		}

		private void Emited(OpCode opcode)
		{
			if (_first_code)
			{
				_first_code = false;
				if (_document != null && !_marked)
				{
					_ilg.MarkSequencePoint(_document, 16707566, 0, 16707566, 0);
				}
			}
			if (opcode == OpCodes.Throw || opcode == OpCodes.Rethrow || opcode == OpCodes.Br || opcode == OpCodes.Leave || opcode == OpCodes.Ret)
			{
				_throw = true;
			}
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
		}

		void ISupportRelocation.RelocateImpl(RelocationInfo _info)
		{
			//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
			this.RelocateImplInternal(_info);
		}
	}

	private sealed class _N_closureOf_GetMethodInfo_73819
	{
		internal IMethod _N_meth_73824;

		internal _N_closureOf_GetMethodInfo_73819()
		{
		}
	}

	private sealed class _N__N_lambda__73803__73832 : Function<TypeVar, Type>
	{
		[SpecialName]
		public static readonly _N__N_lambda__73803__73832 Instance = new _N__N_lambda__73803__73832();

		[SpecialName]
		public sealed override Type apply(TypeVar x)
		{
			return x.GetNonVoidSystemType();
		}
	}

	private sealed class _N__N_lambda__73812__73842 : FunctionVoid<StaticTypeVar, TypeVar>
	{
		[SpecialName]
		private _N_closureOf_GetMethodInfo_73819 _N_GetMethodInfo_closure_73846;

		public _N__N_lambda__73812__73842(_N_closureOf_GetMethodInfo_73819 _N_GetMethodInfo_closure_73846)
		{
			this._N_GetMethodInfo_closure_73846 = _N_GetMethodInfo_closure_73846;
		}

		[SpecialName]
		public sealed override void apply_void(StaticTypeVar _N__73810, TypeVar _N__73811)
		{
			_N__73810.CheckConstraints(_N__73811, _N_GetMethodInfo_closure_73846._N_meth_73824);
		}
	}

	private sealed class _N__N_lambda__73886__73893 : Function<Parm, TExpr>
	{
		[SpecialName]
		public static readonly _N__N_lambda__73886__73893 Instance = new _N__N_lambda__73886__73893();

		[SpecialName]
		public sealed override TExpr apply(Parm _N__73885)
		{
			return _N__73885.expr;
		}
	}

	private sealed class _N_closureOf_emit_tuple_function_conversion_73942
	{
		internal IMember _N_member_73947;

		internal _N_closureOf_emit_tuple_function_conversion_73942()
		{
		}
	}

	private sealed class _N_closureOf_emit_74401
	{
		internal ILEmitter _N__N_closurised_this_ptr_74410;

		internal bool _N_ignore_try_result_74408;

		internal LocalBuilder _N_try_result_74406;

		internal _N_closureOf_emit_74401()
		{
		}
	}

	private sealed class _N__N_lambda__74186__74517 : Function<LocalValue, TExpr, TExpr>
	{
		[SpecialName]
		public static readonly _N__N_lambda__74186__74517 Instance = new _N__N_lambda__74186__74517();

		[SpecialName]
		public sealed override TExpr apply(LocalValue _N_wildcard_74185, TExpr e)
		{
			return e;
		}
	}

	private sealed class _N_closureOf_emit_branch_74583
	{
		internal Label _N_else_label_74590;

		internal Location _N_debug_loc_74588;

		internal _N_closureOf_emit_branch_74583()
		{
		}
	}

	private sealed class _N__N_lambda__74222__74681 : Function<Parm, TExpr>
	{
		[SpecialName]
		public static readonly _N__N_lambda__74222__74681 Instance = new _N__N_lambda__74222__74681();

		[SpecialName]
		public sealed override TExpr apply(Parm _N__74221)
		{
			return _N__74221.expr;
		}
	}

	private sealed class _N__N_lambda__74236__74694 : Function<Parm, TExpr>
	{
		[SpecialName]
		public static readonly _N__N_lambda__74236__74694 Instance = new _N__N_lambda__74236__74694();

		[SpecialName]
		public sealed override TExpr apply(Parm _N__74235)
		{
			return _N__74235.expr;
		}
	}

	private sealed class _N__N_lambda__74203__74716 : Function<Parm, TExpr>
	{
		[SpecialName]
		public static readonly _N__N_lambda__74203__74716 Instance = new _N__N_lambda__74203__74716();

		[SpecialName]
		public sealed override TExpr apply(Parm _N__74202)
		{
			return _N__74202.expr;
		}
	}

	private sealed class _N__N_lambda__74320__75078 : Function<TExpr, bool>
	{
		[SpecialName]
		public static readonly _N__N_lambda__74320__75078 Instance = new _N__N_lambda__74320__75078();

		[SpecialName]
		public sealed override bool apply(TExpr _N__74319)
		{
			return _N__74319.NeedsEmptyStack;
		}
	}

	private sealed class _N__N_lambda__74360__75138 : Function<TExpr, bool>
	{
		[SpecialName]
		public static readonly _N__N_lambda__74360__75138 Instance = new _N__N_lambda__74360__75138();

		[SpecialName]
		public sealed override bool apply(TExpr _N__74359)
		{
			return _N__74359.NeedsEmptyStack;
		}
	}

	private sealed class _N_closureOf_emit_debug_info_75300
	{
		internal ILEmitter _N__N_closurised_this_ptr_75305;

		internal _N_closureOf_emit_debug_info_75300()
		{
		}
	}

	private sealed class _N_closureOf_emit_switch_75453
	{
		internal ILEmitter _N__N_closurised_this_ptr_75462;

		internal Label _N_default_jump_target_75460;

		internal list<Label> _N_reversed_labels_75458;

		internal _N_closureOf_emit_switch_75453()
		{
		}
	}

	private sealed class _N_compare_cases__75467 : Function<Nemerle.Builtins.Tuple<int, TExpr>, Nemerle.Builtins.Tuple<int, TExpr>, int>
	{
		[SpecialName]
		public static readonly _N_compare_cases__75467 Instance = new _N_compare_cases__75467();

		[SpecialName]
		public sealed override int apply(Nemerle.Builtins.Tuple<int, TExpr> l, Nemerle.Builtins.Tuple<int, TExpr> r)
		{
			return Pair.First(l.Field0, l.Field1).CompareTo(r.Field0);
		}
	}

	private sealed class _N_closureOf_emit_value_type_conversion_75570
	{
		internal Location _N_loc_75579;

		internal FixedType _N_l_t_75577;

		internal FixedType _N_r_t_75575;

		internal _N_closureOf_emit_value_type_conversion_75570()
		{
		}
	}

	private sealed class _N_closureOf_declare_val_local_slot_ex_75723
	{
		internal LocalValue _N_val_75730;

		internal ILEmitter _N__N_closurised_this_ptr_75728;

		internal _N_closureOf_declare_val_local_slot_ex_75723()
		{
		}
	}

	private sealed class _N__N_lambda__75715__75741 : FunctionVoid
	{
		[SpecialName]
		private _N_closureOf_declare_val_local_slot_ex_75723 _N_declare_val_local_slot_ex_closure_75745;

		public _N__N_lambda__75715__75741(_N_closureOf_declare_val_local_slot_ex_75723 _N_declare_val_local_slot_ex_closure_75745)
		{
			this._N_declare_val_local_slot_ex_closure_75745 = _N_declare_val_local_slot_ex_closure_75745;
		}

		[SpecialName]
		public sealed override void apply_void()
		{
			LocalBuilder localBuilder = _N_declare_val_local_slot_ex_closure_75745._N__N_closurised_this_ptr_75728.declare_val_local_slot(_N_declare_val_local_slot_ex_closure_75745._N_val_75730);
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly object _N_lockVar_18571 = new object();

	[IgnoreField]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Hashtable<int, ISymbolDocumentWriter> _N_cache_18572;

	private readonly ModuleBuilder _module_builder;

	private readonly NemerleGenerator _ilg;

	private readonly TypeBuilder _parent_type_builder;

	private readonly bool _this_is_value_type;

	private readonly Type _type_of_this;

	private readonly string _method_name;

	private readonly MethodBuilder _method_builder;

	private Label _method_start_label;

	private ISymbolDocumentWriter _debug_doc;

	private bool _is_ctor;

	private bool _is_lambda;

	private readonly Hashtable<int, Label> _labels = new Hashtable<int, Label>();

	private readonly Hashtable<int, TExpr> _label_usage = new Hashtable<int, TExpr>();

	private static readonly Type MS_NET_RUNTIME_TYPE;

	private static readonly Type MONO_RUNTIME_TYPE;

	private static readonly Type RUNTIME_TYPE;

	private static readonly bool IsRunningOnMono;

	public readonly ManagerClass Manager;

	private bool IsDebugEnabled => _debug_doc != null;

	public InternalTypeClass InternalType => Manager.InternalType;

	public SystemTypeClass SystemTypeCache => Manager.SystemTypeCache;

	static ILEmitter()
	{
		MS_NET_RUNTIME_TYPE = typeof(object).Assembly.GetType("System.RuntimeType");
		MONO_RUNTIME_TYPE = typeof(object).Assembly.GetType("System.MonoType");
		RUNTIME_TYPE = ((!(MONO_RUNTIME_TYPE != null)) ? MS_NET_RUNTIME_TYPE : MONO_RUNTIME_TYPE);
		IsRunningOnMono = typeof(object).Assembly.GetType("Mono.Runtime") != null;
	}

	internal ILEmitter(MethodBuilder method_builder)
	{
		Manager = method_builder.Manager;
		_method_builder = method_builder;
		MethodBase methodBase = _method_builder.GetMethodBase();
		_ilg = new NemerleGenerator((ILGenerator)methodBase.GetType().InvokeMember("GetILGenerator", System.Reflection.BindingFlags.InvokeMethod, null, methodBase, null, null, null, null));
		_module_builder = (ModuleBuilder)methodBase.Module;
		_parent_type_builder = _method_builder.DeclaringType;
		_method_name = string.Concat(methodBase.DeclaringType.TypeFullName() + "::", methodBase.Name);
		_this_is_value_type = _parent_type_builder.IsValueType;
		_type_of_this = _parent_type_builder.GetMemType().GetSystemType();
	}

	public void Run()
	{
		int num = 0;
		_ilg.SetDocument(_debug_doc);
		_method_start_label = _ilg.DefineLabel();
		_ilg.MarkLabel(_method_start_label);
		FunBody body = _method_builder.GetHeader().body;
		if (body is FunBody.Typed)
		{
			TExpr expr = ((FunBody.Typed)body).expr;
			_is_ctor = is_ctor(_method_builder);
			_is_lambda = _method_builder.DeclaringType.is_lambda;
			_ilg.BeginScope();
			emit(expr);
			if (expr.Throws)
			{
				Label label = _ilg.DefineLabel();
				_ilg.MarkLabel(label);
				_ilg.Emit(OpCodes.Br, label);
			}
			else
			{
				_ilg.Emit(OpCodes.Ret);
			}
			_ilg.EndScope();
			_method_builder.GetHeader().body = FunBody.ILed._N_constant_object;
			Nemerle.Builtins.Tuple<int, TExpr>[] keyValuePairs = _label_usage.KeyValuePairs;
			for (num = 0; num < keyValuePairs.Length; num = checked(num + 1))
			{
				Nemerle.Builtins.Tuple<int, TExpr> tuple = keyValuePairs[num];
				int field = tuple.Field0;
				expr = tuple.Field1;
				if (expr != null)
				{
					Message.Error(expr.Location, "non local goto (block return?) detected (l" + Convert.ToString(field) + ")");
				}
			}
			return;
		}
		if (!Message.SeenError)
		{
			string text = ("method " + Convert.ToString(_method_name) + " is already ILed").ToString();
			Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
		}
		throw new AssertionException("ncc\\generation\\ILEmitter.n", 136, "", ("method " + Convert.ToString(_method_name) + " is already ILed").ToString());
	}

	private static bool is_always_true(TExpr expr)
	{
		int result;
		if (expr is TExpr.Literal)
		{
			if (!(((TExpr.Literal)expr).val is Literal.Bool) || !((Literal.Bool)((TExpr.Literal)expr).val).val)
			{
				goto IL_0040;
			}
			result = 1;
		}
		else
		{
			if (!(expr is TExpr.If))
			{
				goto IL_0040;
			}
			TExpr cond = ((TExpr.If)expr).cond;
			TExpr e_then = ((TExpr.If)expr).e_then;
			TExpr e_else = ((TExpr.If)expr).e_else;
			bool flag = is_always_true(cond);
			bool flag2 = is_always_false(cond);
			bool flag3 = is_always_true(e_then);
			bool flag4 = is_always_true(e_else);
			result = (((flag && flag3) || (flag2 && flag4)) ? 1 : 0);
		}
		goto IL_00cd;
		IL_0040:
		result = 0;
		goto IL_00cd;
		IL_00cd:
		return (byte)result != 0;
	}

	private ISymbolDocumentWriter DefineDebugDocument(int fileIndex)
	{
		lock (_N_lockVar_18571)
		{
			if (_N_cache_18572 == null)
			{
				_N_cache_18572 = new Hashtable<int, ISymbolDocumentWriter>();
			}
			Nemerle.Builtins.Tuple<ISymbolDocumentWriter, bool> tuple = _N_cache_18572.TryGetValue(fileIndex);
			ISymbolDocumentWriter result;
			if (tuple.Field1)
			{
				ISymbolDocumentWriter field = tuple.Field0;
				result = field;
			}
			else
			{
				object obj;
				if (fileIndex != 0)
				{
					obj = _module_builder.DefineDocument(Path.GetFullPath(Location.GetFileName(fileIndex)), SymDocumentType.Text, SymLanguageType.ILAssembly, SymLanguageVendor.Microsoft);
				}
				else
				{
					Message.Warning("missing debug location, this is probably some internal compiler error");
					Location location = LocationStack.Top();
					obj = ((!(location != Location.Default)) ? _debug_doc : DefineDebugDocument(location.FileIndex));
				}
				ISymbolDocumentWriter symbolDocumentWriter = (ISymbolDocumentWriter)obj;
				_N_cache_18572[fileIndex] = symbolDocumentWriter;
				result = symbolDocumentWriter;
			}
			return result;
		}
	}

	public void SetDocument(Location loc)
	{
		_debug_doc = DefineDebugDocument(loc.FileIndex);
	}

	private static bool is_always_false(TExpr expr)
	{
		int result;
		if (expr is TExpr.Literal)
		{
			if (!(((TExpr.Literal)expr).val is Literal.Bool) || ((Literal.Bool)((TExpr.Literal)expr).val).val)
			{
				goto IL_0041;
			}
			result = 1;
		}
		else
		{
			if (!(expr is TExpr.If))
			{
				goto IL_0041;
			}
			TExpr cond = ((TExpr.If)expr).cond;
			TExpr e_then = ((TExpr.If)expr).e_then;
			TExpr e_else = ((TExpr.If)expr).e_else;
			bool flag = is_always_true(cond);
			bool flag2 = is_always_false(cond);
			bool flag3 = is_always_false(e_then);
			bool flag4 = is_always_false(e_else);
			result = (((flag && flag3) || (flag2 && flag4)) ? 1 : 0);
		}
		goto IL_00ce;
		IL_0041:
		result = 0;
		goto IL_00ce;
		IL_00ce:
		return (byte)result != 0;
	}

	private void maybe_volatile(TExpr expr)
	{
		IField field;
		if (expr is TExpr.StaticRef)
		{
			if (!(((TExpr.StaticRef)expr).mem is IField))
			{
				return;
			}
			field = (IField)((TExpr.StaticRef)expr).mem;
		}
		else
		{
			if (!(expr is TExpr.FieldMember))
			{
				return;
			}
			field = ((TExpr.FieldMember)expr).fld;
		}
		if (field.IsVolatile)
		{
			_ilg.Emit(OpCodes.Volatile);
		}
	}

	private void need_reference(Type t)
	{
		if (t.IsValueType || t.IsGenericParameter)
		{
			_ilg.Emit(OpCodes.Box, t);
		}
	}

	private bool is_void(TypeVar ty)
	{
		return ty.Fix() == InternalType.Void;
	}

	private static bool is_ctor(IMethod meth)
	{
		return meth.MemberKind == MemberTypes.Constructor;
	}

	private static ConstructorInfo GetHackishConstructor(Type _from_type, ConstructorInfo ctr)
	{
		int num = 0;
		int num2 = ((!(ctr is ConstructorBuilder)) ? ctr.MetadataToken : ((ConstructorBuilder)ctr).GetToken().Token);
		ConstructorInfo[] constructors = _from_type.GetConstructors(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.DeclaredOnly);
		for (num = 0; num < constructors.Length; num = checked(num + 1))
		{
			ConstructorInfo constructorInfo = constructors[num];
			constructorInfo = constructorInfo;
			if (constructorInfo.MetadataToken == num2)
			{
				return constructorInfo;
			}
		}
		throw new Exception("not found: " + Convert.ToString(ctr) + " in " + Convert.ToString(_from_type));
	}

	private static MethodInfo GetHackishMethod(Type _from_type, MethodInfo meth)
	{
		int num = 0;
		int num2 = ((!(meth is System.Reflection.Emit.MethodBuilder)) ? meth.MetadataToken : ((System.Reflection.Emit.MethodBuilder)meth).GetToken().Token);
		MethodInfo[] methods = _from_type.GetMethods(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.DeclaredOnly);
		for (num = 0; num < methods.Length; num = checked(num + 1))
		{
			MethodInfo methodInfo = methods[num];
			methodInfo = methodInfo;
			if (methodInfo.MetadataToken == num2)
			{
				return methodInfo;
			}
		}
		throw new Exception("not found: " + Convert.ToString(meth) + " in " + Convert.ToString(_from_type));
	}

	private static FieldInfo GetHackishField(Type _from_type, FieldInfo fld)
	{
		int num = 0;
		int num2 = ((!(fld is System.Reflection.Emit.FieldBuilder)) ? fld.MetadataToken : ((System.Reflection.Emit.FieldBuilder)fld).GetToken().Token);
		FieldInfo[] fields = _from_type.GetFields(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.DeclaredOnly);
		for (num = 0; num < fields.Length; num = checked(num + 1))
		{
			FieldInfo fieldInfo = fields[num];
			fieldInfo = fieldInfo;
			if (fieldInfo.MetadataToken == num2)
			{
				return fieldInfo;
			}
		}
		throw new Exception("not found: " + Convert.ToString(fld) + " in " + Convert.ToString(_from_type));
	}

	private static ConstructorInfo FrameworkGetConstructor(Type t, ConstructorInfo m)
	{
		ConstructorInfo result;
		if (RUNTIME_TYPE != null)
		{
			if (t.GetType().Equals(RUNTIME_TYPE))
			{
				result = GetHackishConstructor(t, m);
			}
			else
			{
				Type genericTypeDefinition = t.GetGenericTypeDefinition();
				if (genericTypeDefinition.GetType().Equals(RUNTIME_TYPE))
				{
					m = GetHackishConstructor(genericTypeDefinition, m);
				}
				result = System.Reflection.Emit.TypeBuilder.GetConstructor(t, m);
			}
		}
		else
		{
			result = System.Reflection.Emit.TypeBuilder.GetConstructor(t, m);
		}
		return result;
	}

	private static MethodInfo FrameworkGetMethod(Type t, MethodInfo m)
	{
		MethodInfo result;
		if (RUNTIME_TYPE != null)
		{
			if (t.GetType().Equals(RUNTIME_TYPE))
			{
				result = GetHackishMethod(t, m);
			}
			else
			{
				Type genericTypeDefinition = t.GetGenericTypeDefinition();
				if (genericTypeDefinition.GetType().Equals(RUNTIME_TYPE))
				{
					m = GetHackishMethod(genericTypeDefinition, m);
				}
				result = System.Reflection.Emit.TypeBuilder.GetMethod(t, m);
			}
		}
		else
		{
			result = System.Reflection.Emit.TypeBuilder.GetMethod(t, m);
		}
		return result;
	}

	private static FieldInfo FrameworkGetField(Type t, FieldInfo m)
	{
		FieldInfo result;
		if (!IsRunningOnMono)
		{
			if (t.GetType().Equals(MS_NET_RUNTIME_TYPE))
			{
				result = GetHackishField(t, m);
			}
			else
			{
				Type genericTypeDefinition = t.GetGenericTypeDefinition();
				if (genericTypeDefinition.GetType().Equals(MS_NET_RUNTIME_TYPE))
				{
					m = GetHackishField(genericTypeDefinition, m);
				}
				result = System.Reflection.Emit.TypeBuilder.GetField(t, m);
			}
		}
		else
		{
			result = System.Reflection.Emit.TypeBuilder.GetField(t, m);
		}
		return result;
	}

	private static ConstructorInfo GetConstructorInfo(Type _from_type, IMethod meth)
	{
		ConstructorInfo constructorInfo = null;
		constructorInfo = meth.GetConstructorInfo();
		if (_from_type.IsGenericType)
		{
			constructorInfo = FrameworkGetConstructor(_from_type, constructorInfo);
		}
		return constructorInfo;
	}

	internal static MethodInfo GetMethodInfo(FixedType _from_type, IMethod meth)
	{
		MethodInfo methodInfo = null;
		methodInfo = meth.GetMethodInfo();
		Type systemType = _from_type.Fix().GetInstantiatedSuperType(meth.DeclaringType).GetSystemType();
		if (systemType.IsGenericType)
		{
			methodInfo = FrameworkGetMethod(systemType, methodInfo);
		}
		return methodInfo;
	}

	private static MethodInfo GetMethodInfo(TypeVar from_type, IMethod meth, list<TypeVar> typars)
	{
		MethodInfo methodInfo = null;
		_N_closureOf_GetMethodInfo_73819 n_closureOf_GetMethodInfo_ = new _N_closureOf_GetMethodInfo_73819();
		n_closureOf_GetMethodInfo_._N_meth_73824 = meth;
		methodInfo = n_closureOf_GetMethodInfo_._N_meth_73824.GetMethodInfo();
		FixedType.Class instantiatedSuperType = from_type.Fix().GetInstantiatedSuperType(n_closureOf_GetMethodInfo_._N_meth_73824.DeclaringType);
		Type systemType = instantiatedSuperType.GetSystemType();
		if (systemType.IsGenericType)
		{
			methodInfo = FrameworkGetMethod(systemType, methodInfo);
		}
		list<StaticTypeVar> typeParameters = n_closureOf_GetMethodInfo_._N_meth_73824.GetHeader().TypeParameters;
		if (!typeParameters.IsEmpty)
		{
			Function<TypeVar, Type> instance = _N__N_lambda__73803__73832.Instance;
			Type[] typeArguments = typars.MapToArray(instance);
			int errorCount = Message.ErrorCount;
			FunctionVoid<StaticTypeVar, TypeVar> f = new _N__N_lambda__73812__73842(n_closureOf_GetMethodInfo_);
			NList.Iter2(typeParameters, typars, f);
			if (errorCount == Message.ErrorCount)
			{
				methodInfo = methodInfo.MakeGenericMethod(typeArguments);
			}
		}
		return methodInfo;
	}

	private static FieldInfo GetFieldInfo(TExpr _obj, IField fld)
	{
		Type systemType = _obj.FixedType().GetInstantiatedSuperType(fld.DeclaringType).GetSystemType();
		return GetFieldInfo(systemType, fld);
	}

	private static FieldInfo GetFieldInfo(Type _from_type, IField meth)
	{
		FieldInfo fieldInfo = null;
		fieldInfo = meth.GetFieldInfo();
		if (_from_type.IsGenericType)
		{
			fieldInfo = FrameworkGetField(_from_type, fieldInfo);
		}
		return fieldInfo;
	}

	private void store_local(LocalValue decl)
	{
		if (decl.IsParm)
		{
			if (decl.IsByRefParm)
			{
				if (!Message.SeenError)
				{
					Message.Debug("Internal compiler error, please report a bug to bugs.nemerle.org. You can try modifying program near this location.");
				}
				throw new AssertionException("ncc\\generation\\ILEmitter.n", 416, (!decl.IsByRefParm).ToString(), "");
			}
			store_argument(decl.ParmIndex);
		}
		else if (!is_void(decl.Type))
		{
			_ilg.Emit(OpCodes.Stloc, decl.LocalSlot);
		}
	}

	private void emit_parms(list<Parm> parms)
	{
		Function<Parm, TExpr> instance = _N__N_lambda__73886__73893.Instance;
		emit_exprs(parms.Map(instance));
	}

	private static void skipped(TExpr expr)
	{
		if (expr is TExpr.Literal)
		{
			if (((TExpr.Literal)expr).val is Literal.Void)
			{
				return;
			}
		}
		else if (expr is TExpr.Label)
		{
			if (((TExpr.Label)expr).body is TExpr.Literal && ((TExpr.Literal)((TExpr.Label)expr).body).val is Literal.Void)
			{
				return;
			}
		}
		else
		{
			if (expr is TExpr.Goto)
			{
				return;
			}
			if (expr is TExpr.DebugInfo)
			{
				if (((TExpr.DebugInfo)expr).expr is TExpr.Literal)
				{
					if (((TExpr.Literal)((TExpr.DebugInfo)expr).expr).val is Literal.Void && (object)((TExpr.DebugInfo)expr).pexpr == null)
					{
						return;
					}
				}
				else if ((object)((TExpr.DebugInfo)expr).expr == null)
				{
					return;
				}
			}
		}
		Message.Warning(expr.Location, "this expression has been skipped in code generation because of unreachable code");
	}

	private static bool no_cast_needed(Type src_type, Type target_type)
	{
		return (object)src_type == target_type;
	}

	private static Type make_ref_type(Type t)
	{
		return t.MakeByRefType();
	}

	private void emit_tuple_function_conversion(FixedType after, FixedType member_from, IMember member)
	{
		_N_closureOf_emit_tuple_function_conversion_73942 n_closureOf_emit_tuple_function_conversion_ = new _N_closureOf_emit_tuple_function_conversion_73942();
		n_closureOf_emit_tuple_function_conversion_._N_member_73947 = member;
		if ((!(member_from is FixedType.Class) && !(member_from is FixedType.StaticTypeVarRef) && !(member_from is FixedType.Array)) || !(after is FixedType.Fun))
		{
			return;
		}
		TypeVar from = ((FixedType.Fun)after).from;
		TypeVar to = ((FixedType.Fun)after).to;
		FixedType fixedType = from.Fix();
		if (!(fixedType is FixedType.Tuple))
		{
			return;
		}
		list<TypeVar> list = ((FixedType.Tuple)fixedType).args;
		if (_N_is_single_arg_function_73968(n_closureOf_emit_tuple_function_conversion_, n_closureOf_emit_tuple_function_conversion_._N_member_73947.GetMemType()) || _N_is_single_arg_function_73968(n_closureOf_emit_tuple_function_conversion_, member_from.TypeOfMember(n_closureOf_emit_tuple_function_conversion_._N_member_73947)))
		{
			FunctionType functionType = InternalType.GetFunctionType(list.Length);
			fixedType = to.Fix();
			ConstructorInfo constructorInfo;
			if (fixedType is FixedType.Void)
			{
				FixedType.Class @class = new FixedType.Class(functionType.FromTupleVoidTyCon, list);
				constructorInfo = GetConstructorInfo(@class.GetSystemType(), functionType.FromTupleVoidCtor);
			}
			else
			{
				FixedType.Class @class = new FixedType.Class(functionType.FromTupleTyCon, list + new list<TypeVar>.Cons(to, list<TypeVar>.Nil._N_constant_object));
				constructorInfo = GetConstructorInfo(@class.GetSystemType(), functionType.FromTupleCtor);
			}
			ConstructorInfo con = constructorInfo;
			_ilg.Emit(OpCodes.Newobj, con);
		}
	}

	private void InversBool()
	{
		_ilg.Emit(OpCodes.Ldc_I4_0);
		_ilg.Emit(OpCodes.Ceq);
	}

	private void emit(TExpr expr)
	{
		_N_closureOf_emit_74401 n_closureOf_emit_ = new _N_closureOf_emit_74401();
		n_closureOf_emit_._N__N_closurised_this_ptr_74410 = this;
		if (expr == null)
		{
			if (!Message.SeenError)
			{
				Message.Debug("Internal compiler error, please report a bug to bugs.nemerle.org. You can try modifying program near this location.");
			}
			throw new AssertionException("ncc\\generation\\ILEmitter.n", 522, (expr != null).ToString(), "");
		}
		Location location = expr.Location;
		bool flag = location.FileIndex != 0;
		if (flag)
		{
			LocationStack.Push(location);
		}
		checked
		{
			try
			{
				int id;
				TExpr body;
				bool reset_throw;
				LocalValue name;
				TExpr val;
				TExpr body5;
				TExpr expr6;
				TypeVar target_type4;
				TExpr expr7;
				TExpr expr8;
				TypeVar target_type6;
				ConversionKind kind;
				FixedType fixedType;
				Type systemType3;
				switch (TExpr._N_GetVariantCodeSafe(expr))
				{
				default:
					if (expr is TExpr.MethodAddress)
					{
						TypeVar from = ((TExpr.MethodAddress)expr).from;
						IMethod meth = ((TExpr.MethodAddress)expr).meth;
						bool is_virt = ((TExpr.MethodAddress)expr).is_virt;
						list<TypeVar> typars = ((TExpr.MethodAddress)expr).type_parms;
						MethodInfo methodInfo = GetMethodInfo(from, meth, typars);
						if (is_virt && methodInfo.IsVirtual)
						{
							_ilg.Emit(OpCodes.Dup);
							_ilg.Emit(OpCodes.Ldvirtftn, methodInfo);
						}
						else
						{
							_ilg.Emit(OpCodes.Ldftn, methodInfo);
						}
						break;
					}
					if (expr is TExpr.MultipleAssign)
					{
						list<Nemerle.Builtins.Tuple<LocalValue, TExpr>> list2 = ((TExpr.MultipleAssign)expr).assigns;
						Function<LocalValue, TExpr, TExpr> instance = _N__N_lambda__74186__74517.Instance;
						emit_exprs(list2.Map(instance));
						list<Nemerle.Builtins.Tuple<LocalValue, TExpr>> list3 = list2.Rev();
						while (list3 is list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>.Cons)
						{
							Nemerle.Builtins.Tuple<LocalValue, TExpr> hd2 = ((list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>.Cons)list3).hd;
							list<Nemerle.Builtins.Tuple<LocalValue, TExpr>> list4 = ((list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>.Cons)list3).tl;
							Nemerle.Builtins.Tuple<LocalValue, TExpr> tuple = hd2;
							Nemerle.Builtins.Tuple<LocalValue, TExpr> tuple2 = tuple;
							_N_emit_store_74508(n_closureOf_emit_, tuple2.Field0, tuple2.Field1);
							list3 = list4;
						}
						break;
					}
					if (expr is TExpr.Label)
					{
						if (((TExpr.Label)expr).body is TExpr.DefaultValue)
						{
							id = ((TExpr.Label)expr).id;
							body = ((TExpr.Label)expr).body;
							TypeVar type = body.Type;
							if (type is FixedType.Void)
							{
								reset_throw = true;
								goto IL_029d;
							}
						}
						id = ((TExpr.Label)expr).id;
						body = ((TExpr.Label)expr).body;
						reset_throw = false;
						goto IL_029d;
					}
					if (expr is TExpr.Goto)
					{
						int target = ((TExpr.Goto)expr).target;
						int try_block = ((TExpr.Goto)expr).try_block;
						if (_labels.Contains(target))
						{
							_label_usage[target] = null;
						}
						else
						{
							_label_usage[target] = expr;
							_labels[target] = _ilg.DefineLabel();
						}
						if (try_block == 0)
						{
							_ilg.Emit(OpCodes.Br, _labels[target]);
						}
						else
						{
							_ilg.Emit(OpCodes.Leave, _labels[target]);
						}
						break;
					}
					if (expr is TExpr.DefaultValue)
					{
						Type systemType4 = expr.GetSystemType();
						if (is_void(expr.FixedType()))
						{
							break;
						}
						Type type2 = systemType4;
						if (!type2.Equals(SystemTypeCache.Char))
						{
							type2 = systemType4;
							if (!type2.Equals(SystemTypeCache.Byte))
							{
								type2 = systemType4;
								if (!type2.Equals(SystemTypeCache.SByte))
								{
									type2 = systemType4;
									if (!type2.Equals(SystemTypeCache.Int16))
									{
										type2 = systemType4;
										if (!type2.Equals(SystemTypeCache.Int32))
										{
											type2 = systemType4;
											if (!type2.Equals(SystemTypeCache.UInt16))
											{
												type2 = systemType4;
												if (!type2.Equals(SystemTypeCache.UInt32))
												{
													type2 = systemType4;
													if (!type2.Equals(SystemTypeCache.Boolean))
													{
														Type type3 = systemType4;
														if (!type3.Equals(SystemTypeCache.Int64))
														{
															type3 = systemType4;
															if (!type3.Equals(SystemTypeCache.UInt64))
															{
																Type type4 = systemType4;
																if (type4.Equals(SystemTypeCache.Single))
																{
																	_ilg.Emit(OpCodes.Ldc_R4, 0f);
																	break;
																}
																Type type5 = systemType4;
																if (type5.Equals(SystemTypeCache.Double))
																{
																	_ilg.Emit(OpCodes.Ldc_R8, 0.0);
																	break;
																}
																Type type6 = systemType4;
																if (type6.Equals(SystemTypeCache.Decimal))
																{
																	_ilg.Emit(OpCodes.Ldc_I4_0);
																	_ilg.Emit(OpCodes.Newobj, type6.GetConstructor(new Type[1] { SystemTypeCache.Int32 }));
																	break;
																}
																Type type7 = systemType4;
																if (type7.IsValueType || type7.IsGenericParameter)
																{
																	LocalBuilder local2 = _ilg.DeclareLocal(type7);
																	_ilg.Emit(OpCodes.Ldloca, local2);
																	_ilg.Emit(OpCodes.Initobj, type7);
																	_ilg.Emit(OpCodes.Ldloc, local2);
																}
																else
																{
																	_ilg.Emit(OpCodes.Ldnull);
																}
																break;
															}
														}
														_ilg.Emit(OpCodes.Ldc_I4_0);
														_ilg.Emit(OpCodes.Conv_I8);
														break;
													}
												}
											}
										}
									}
								}
							}
						}
						_ilg.Emit(OpCodes.Ldc_I4_0);
						break;
					}
					if (expr is TExpr.If)
					{
						TExpr cond = ((TExpr.If)expr).cond;
						TExpr e_then = ((TExpr.If)expr).e_then;
						TExpr e_else = ((TExpr.If)expr).e_else;
						Location then_debug_loc = ((TExpr.If)expr).then_debug_loc;
						Location else_debug_loc = ((TExpr.If)expr).else_debug_loc;
						Label label = _ilg.DefineLabel();
						Label label2 = _ilg.DefineLabel();
						_ilg.BeginScope();
						_N_emit_branch_74577(n_closureOf_emit_, cond, label, else_debug_loc);
						_ilg.BeginScope();
						_N_emit_debug_74564(n_closureOf_emit_, then_debug_loc);
						emit(e_then);
						_ilg.EndScope();
						if (!e_then.Throws)
						{
							_ilg.Emit(OpCodes.Br, label2);
						}
						_ilg.BeginScope();
						_ilg.MarkLabel(label);
						emit(e_else);
						_ilg.EndScope();
						_ilg.MarkLabel(label2);
						_ilg.EndScope();
						break;
					}
					if (expr is TExpr.HasType)
					{
						TExpr expr10 = ((TExpr.HasType)expr).expr;
						FixedType test_ty = ((TExpr.HasType)expr).test_ty;
						emit(expr10);
						Label label3 = _ilg.DefineLabel();
						Label label4 = _ilg.DefineLabel();
						Label label5 = _ilg.DefineLabel();
						_ilg.Emit(OpCodes.Dup);
						_ilg.Emit(OpCodes.Brtrue_S, label3);
						_ilg.ThrowException(SystemTypeCache.NullMatchException);
						_ilg.MarkLabel(label3);
						need_reference(expr10.GetSystemType());
						_ilg.Emit(OpCodes.Isinst, test_ty.GetSystemType());
						_ilg.Emit(OpCodes.Brtrue_S, label4);
						_ilg.Emit(OpCodes.Ldc_I4_0);
						_ilg.Emit(OpCodes.Br_S, label5);
						_ilg.MarkLabel(label4);
						_ilg.Emit(OpCodes.Ldc_I4_1);
						_ilg.MarkLabel(label5);
						break;
					}
					if (expr is TExpr.Switch)
					{
						TExpr indexing_expr = ((TExpr.Switch)expr).indexing_expr;
						option<TExpr> default_expr = ((TExpr.Switch)expr).@default;
						list<Nemerle.Builtins.Tuple<int, TExpr>> list5 = ((TExpr.Switch)expr).cases;
						if ((object)list5 == list<Nemerle.Builtins.Tuple<int, TExpr>>.Nil._N_constant_object)
						{
							Message.Warning("empty TExpr.Switch instruction");
							break;
						}
						emit(indexing_expr);
						emit_switch(default_expr, list5);
						break;
					}
					if (expr is TExpr.DebugInfo)
					{
						TExpr.DebugInfo di = (TExpr.DebugInfo)expr;
						emit_debug_info(di);
						break;
					}
					goto IL_0988;
				case 0:
					if (((TExpr.StaticRef)expr).mem is IField)
					{
						FixedType.Class from2 = ((TExpr.StaticRef)expr).from;
						IField field = (IField)((TExpr.StaticRef)expr).mem;
						FieldInfo fieldInfo = GetFieldInfo(from2.GetSystemType(), field);
						if (!fieldInfo.IsStatic)
						{
							throw new AssertionException("ncc\\generation\\ILEmitter.n", 970, "field_info.IsStatic", "GlobalRef to a non-static field");
						}
						if (fieldInfo.IsLiteral)
						{
							Message.Warning(string.Concat("loading literal as field `" + fieldInfo.ToString(), "'"));
						}
						maybe_volatile(expr);
						if (expr.NeedAddress)
						{
							if (field.IsMutable)
							{
								_ilg.Emit(OpCodes.Ldsflda, fieldInfo);
							}
							else
							{
								LocalBuilder local6 = _ilg.DeclareLocal(field.GetMemType().GetSystemType());
								_ilg.Emit(OpCodes.Ldsfld, fieldInfo);
								_ilg.Emit(OpCodes.Stloc, local6);
								_ilg.Emit(OpCodes.Ldloca, local6);
							}
						}
						else
						{
							_ilg.Emit(OpCodes.Ldsfld, fieldInfo);
						}
						emit_tuple_function_conversion(expr.FixedType(), from2, field);
						break;
					}
					goto IL_0988;
				case 1:
				{
					LocalValue decl = ((TExpr.LocalRef)expr).decl;
					if (!is_void(decl.Type))
					{
						emit_ce_ref(decl, expr.NeedAddress);
					}
					break;
				}
				case 2:
				{
					LocalBuilder local = declare_expr_local_slot(expr);
					_ilg.Emit(OpCodes.Ldloca, local);
					_ilg.Emit(OpCodes.Initobj, expr.GetSystemType());
					_ilg.Emit(OpCodes.Ldloc, local);
					break;
				}
				case 3:
				{
					TExpr obj11 = ((TExpr.FieldMember)expr).obj;
					IField fld3 = ((TExpr.FieldMember)expr).fld;
					bool needAddress = expr.NeedAddress;
					if (needAddress)
					{
						emit_and_convert_to_address(obj11);
					}
					else
					{
						emit(obj11);
					}
					maybe_volatile(expr);
					FieldInfo fieldInfo5 = GetFieldInfo(obj11, fld3);
					if (obj11.GetSystemType().IsGenericParameter)
					{
						_ilg.Emit(OpCodes.Box, obj11.GetSystemType());
					}
					if (needAddress)
					{
						_ilg.Emit(OpCodes.Ldflda, fieldInfo5);
					}
					else
					{
						_ilg.Emit(OpCodes.Ldfld, fieldInfo5);
					}
					emit_tuple_function_conversion(expr.FixedType(), obj11.FixedType(), fld3);
					break;
				}
				case 5:
					if (((TExpr.Call)expr).func is TExpr.StaticRef)
					{
						if (((TExpr.StaticRef)((TExpr.Call)expr).func).mem is IMethod)
						{
							FixedType.Class from4 = ((TExpr.StaticRef)((TExpr.Call)expr).func).from;
							IMethod meth3 = (IMethod)((TExpr.StaticRef)((TExpr.Call)expr).func).mem;
							list<Parm> parms = ((TExpr.Call)expr).parms;
							if (is_ctor(meth3))
							{
								emit_parms(parms);
								ConstructorInfo constructorInfo = GetConstructorInfo(from4.GetSystemType(), meth3);
								_ilg.Emit(OpCodes.Newobj, constructorInfo);
								if (expr.GenerateTail)
								{
									_ilg.Emit(OpCodes.Ret);
								}
								break;
							}
							FixedType.Class from5 = ((TExpr.StaticRef)((TExpr.Call)expr).func).from;
							IMethod method3 = (IMethod)((TExpr.StaticRef)((TExpr.Call)expr).func).mem;
							list<TypeVar> typars2 = ((TExpr.StaticRef)((TExpr.Call)expr).func).type_parms;
							list<Parm> parms2 = ((TExpr.Call)expr).parms;
							MethodInfo methodInfo2 = GetMethodInfo(from5, method3, typars2);
							if (!methodInfo2.IsStatic)
							{
								if (!Message.SeenError)
								{
									Message.Debug("Internal compiler error, please report a bug to bugs.nemerle.org. You can try modifying program near this location.");
								}
								throw new AssertionException("ncc\\generation\\ILEmitter.n", 1223, methodInfo2.IsStatic.ToString(), "Call TExpr.GlobalRef to a non-static field: " + Convert.ToString(methodInfo2.Name));
							}
							emit_parms(parms2);
							emit_method_call(expr, base_is_value_type_or_static: true, methodInfo2, method3, from5);
							break;
						}
					}
					else
					{
						if (((TExpr.Call)expr).func is TExpr.MethodRef)
						{
							if (((TExpr.MethodRef)((TExpr.Call)expr).func).obj is TExpr.This)
							{
								TExpr.This @this = (TExpr.This)((TExpr.MethodRef)((TExpr.Call)expr).func).obj;
								IMethod meth4 = ((TExpr.MethodRef)((TExpr.Call)expr).func).meth;
								list<TypeVar> typars3 = ((TExpr.MethodRef)((TExpr.Call)expr).func).type_parms;
								list<Parm> list10 = ((TExpr.Call)expr).parms;
								if (_this_is_value_type)
								{
									MethodInfo methodInfo3 = GetMethodInfo(@this.Type, meth4, typars3);
									Function<Parm, TExpr> instance2 = _N__N_lambda__74222__74681.Instance;
									list<TExpr> exprs = list10.Map(instance2);
									LocalBuilder[] local_variables3 = emit_exprs_prepare(exprs);
									_ilg.Emit(OpCodes.Ldarg_0);
									if (!@this.FixedType().Equals(_parent_type_builder.GetMemType()))
									{
										_ilg.Emit(OpCodes.Ldobj, _type_of_this);
										_ilg.Emit(OpCodes.Box, _type_of_this);
									}
									emit_exprs_push(local_variables3, exprs);
									emit_method_call(expr, base_is_value_type_or_static: true, methodInfo3, meth4, @this.FixedType());
									break;
								}
							}
							TExpr obj10 = ((TExpr.MethodRef)((TExpr.Call)expr).func).obj;
							IMethod meth5 = ((TExpr.MethodRef)((TExpr.Call)expr).func).meth;
							list<TypeVar> typars4 = ((TExpr.MethodRef)((TExpr.Call)expr).func).type_parms;
							bool notvirtual = ((TExpr.MethodRef)((TExpr.Call)expr).func).notvirtual;
							list<Parm> list11 = ((TExpr.Call)expr).parms;
							MethodInfo methodInfo4 = GetMethodInfo(obj10.Type, meth5, typars4);
							Function<Parm, TExpr> instance3 = _N__N_lambda__74236__74694.Instance;
							list<TExpr> exprs2 = list11.Map(instance3);
							LocalBuilder[] local_variables4 = emit_exprs_prepare(exprs2);
							bool flag5 = emit_and_convert_to_address(obj10);
							emit_exprs_push(local_variables4, exprs2);
							if (obj10.NeedsConstrained)
							{
								bool generateTail = expr.GenerateTail;
								if (generateTail)
								{
									expr.GenerateTail = false;
									_ilg.Emit(OpCodes.Tailcall);
								}
								_ilg.Emit(OpCodes.Constrained, obj10.GetSystemType());
								emit_method_call(expr, base_is_value_type_or_static: false, methodInfo4, meth5, obj10.FixedType());
								if (generateTail)
								{
									_ilg.Emit(OpCodes.Ret);
								}
							}
							else
							{
								bool base_is_value_type_or_static = flag5 || notvirtual;
								emit_method_call(expr, base_is_value_type_or_static, methodInfo4, meth5, obj10.FixedType());
							}
							break;
						}
						if (((TExpr.Call)expr).func is TExpr.Base)
						{
							IMethod base_ctor = ((TExpr.Base)((TExpr.Call)expr).func).base_ctor;
							list<Parm> list12 = ((TExpr.Call)expr).parms;
							Function<Parm, TExpr> instance4 = _N__N_lambda__74203__74716.Instance;
							list<TExpr> exprs3 = list12.Map(instance4);
							LocalBuilder[] local_variables5 = emit_exprs_prepare(exprs3);
							_ilg.Emit(OpCodes.Ldarg_0);
							emit_exprs_push(local_variables5, exprs3);
							Type from_type = ((!base_ctor.DeclaringType.Equals(_parent_type_builder)) ? _type_of_this.BaseType : _type_of_this);
							ConstructorInfo constructorInfo2 = GetConstructorInfo(from_type, base_ctor);
							_ilg.Emit(OpCodes.Call, constructorInfo2);
							if (expr.GenerateTail)
							{
								_ilg.Emit(OpCodes.Ret);
							}
							break;
						}
						if (((TExpr.Call)expr).func is TExpr.OpCode)
						{
							string name3 = ((TExpr.OpCode)((TExpr.Call)expr).func).name;
							list<Parm> list13 = ((TExpr.Call)expr).parms;
							emit_parms(list13);
							bool flag7;
							bool flag6;
							switch (name3)
							{
							case "+.s":
								_ilg.Emit(OpCodes.Add_Ovf);
								break;
							case "+.u":
								_ilg.Emit(OpCodes.Add_Ovf_Un);
								break;
							case "+.f":
								_ilg.Emit(OpCodes.Add);
								break;
							case "+.p":
								flag7 = true;
								goto IL_1277;
							case "-.p":
								flag7 = false;
								goto IL_1277;
							case "<<.s":
							case "<<.f":
							case "<<.u":
								_ilg.Emit(OpCodes.Shl);
								break;
							case ">>.s":
							case ">>.f":
								_ilg.Emit(OpCodes.Shr);
								break;
							case ">>.u":
								_ilg.Emit(OpCodes.Shr_Un);
								break;
							case "-.s":
								_ilg.Emit(OpCodes.Sub_Ovf);
								break;
							case "-.u":
								_ilg.Emit(OpCodes.Sub_Ovf_Un);
								break;
							case "-.f":
								_ilg.Emit(OpCodes.Sub);
								break;
							case "unary.-.s":
								_ilg.Emit(OpCodes.Ldc_I4_M1);
								emit_value_type_conversion(expr.Location, InternalType.Int32, list13.Head.expr.FixedType(), is_checked: true);
								_ilg.Emit(OpCodes.Mul_Ovf);
								break;
							case "unary.-.f":
								_ilg.Emit(OpCodes.Neg);
								break;
							case "unary.~.u":
							case "unary.~.s":
								_ilg.Emit(OpCodes.Not);
								break;
							case "++.i4.f":
								_ilg.Emit(OpCodes.Ldc_I4_1);
								_ilg.Emit(OpCodes.Add);
								break;
							case "--.i4.f":
								_ilg.Emit(OpCodes.Ldc_I4_1);
								_ilg.Emit(OpCodes.Sub);
								break;
							case "++.i4.s":
								_ilg.Emit(OpCodes.Ldc_I4_1);
								_ilg.Emit(OpCodes.Add_Ovf);
								break;
							case "--.i4.s":
								_ilg.Emit(OpCodes.Ldc_I4_1);
								_ilg.Emit(OpCodes.Sub_Ovf);
								break;
							case "++.i4.u":
								_ilg.Emit(OpCodes.Ldc_I4_1);
								_ilg.Emit(OpCodes.Add_Ovf_Un);
								break;
							case "--.i4.u":
								_ilg.Emit(OpCodes.Ldc_I4_1);
								_ilg.Emit(OpCodes.Sub_Ovf_Un);
								break;
							case "++.i4.s.i1":
								_ilg.Emit(OpCodes.Ldc_I4_1);
								_ilg.Emit(OpCodes.Add_Ovf);
								_ilg.Emit(OpCodes.Conv_Ovf_I1);
								break;
							case "--.i4.s.i1":
								_ilg.Emit(OpCodes.Ldc_I4_1);
								_ilg.Emit(OpCodes.Sub_Ovf);
								_ilg.Emit(OpCodes.Conv_Ovf_I1);
								break;
							case "++.i4.u.i1":
								_ilg.Emit(OpCodes.Ldc_I4_1);
								_ilg.Emit(OpCodes.Add_Ovf_Un);
								_ilg.Emit(OpCodes.Conv_Ovf_I1_Un);
								break;
							case "--.i4.u.i1":
								_ilg.Emit(OpCodes.Ldc_I4_1);
								_ilg.Emit(OpCodes.Sub_Ovf_Un);
								_ilg.Emit(OpCodes.Conv_Ovf_I1_Un);
								break;
							case "++.i4.s.i2":
								_ilg.Emit(OpCodes.Ldc_I4_1);
								_ilg.Emit(OpCodes.Add_Ovf);
								_ilg.Emit(OpCodes.Conv_Ovf_I2);
								break;
							case "--.i4.s.i2":
								_ilg.Emit(OpCodes.Ldc_I4_1);
								_ilg.Emit(OpCodes.Sub_Ovf);
								_ilg.Emit(OpCodes.Conv_Ovf_I2);
								break;
							case "++.i4.u.i2":
								_ilg.Emit(OpCodes.Ldc_I4_1);
								_ilg.Emit(OpCodes.Add_Ovf_Un);
								_ilg.Emit(OpCodes.Conv_Ovf_I2_Un);
								break;
							case "--.i4.u.i2":
								_ilg.Emit(OpCodes.Ldc_I4_1);
								_ilg.Emit(OpCodes.Sub_Ovf_Un);
								_ilg.Emit(OpCodes.Conv_Ovf_I2_Un);
								break;
							case "++.i8.f":
								_ilg.Emit(OpCodes.Ldc_I4_1);
								_ilg.Emit(OpCodes.Conv_I8);
								_ilg.Emit(OpCodes.Add);
								break;
							case "--.i8.f":
								_ilg.Emit(OpCodes.Ldc_I4_1);
								_ilg.Emit(OpCodes.Conv_I8);
								_ilg.Emit(OpCodes.Sub);
								break;
							case "++.i8.s":
								_ilg.Emit(OpCodes.Ldc_I4_1);
								_ilg.Emit(OpCodes.Conv_I8);
								_ilg.Emit(OpCodes.Add_Ovf);
								break;
							case "--.i8.s":
								_ilg.Emit(OpCodes.Ldc_I4_1);
								_ilg.Emit(OpCodes.Conv_I8);
								_ilg.Emit(OpCodes.Sub_Ovf);
								break;
							case "++.i8.u":
								_ilg.Emit(OpCodes.Ldc_I4_1);
								_ilg.Emit(OpCodes.Conv_I8);
								_ilg.Emit(OpCodes.Add_Ovf_Un);
								break;
							case "--.i8.u":
								_ilg.Emit(OpCodes.Ldc_I4_1);
								_ilg.Emit(OpCodes.Conv_I8);
								_ilg.Emit(OpCodes.Sub_Ovf_Un);
								break;
							case "++.r4.f":
								_ilg.Emit(OpCodes.Ldc_I4_1);
								_ilg.Emit(OpCodes.Conv_R4);
								_ilg.Emit(OpCodes.Add);
								break;
							case "--.r4.f":
								_ilg.Emit(OpCodes.Ldc_I4_1);
								_ilg.Emit(OpCodes.Conv_R4);
								_ilg.Emit(OpCodes.Sub);
								break;
							case "++.r8.f":
								_ilg.Emit(OpCodes.Ldc_I4_1);
								_ilg.Emit(OpCodes.Conv_R8);
								_ilg.Emit(OpCodes.Add);
								break;
							case "--.r8.f":
								_ilg.Emit(OpCodes.Ldc_I4_1);
								_ilg.Emit(OpCodes.Conv_R8);
								_ilg.Emit(OpCodes.Sub);
								break;
							case "++.p":
								flag6 = true;
								goto IL_1ccf;
							case "--.p":
								flag6 = false;
								goto IL_1ccf;
							case "unary.~.f":
							{
								Type systemType9 = list13.Head.expr.GetSystemType();
								if (systemType9.TypeFullName() == "System.Single" || systemType9.TypeFullName() == "System.Double" || systemType9.TypeFullName() == "System.Decimal")
								{
									if (!Message.SeenError)
									{
										string text3 = "float, double or decimal as an argument for binary negation in CGIL".ToString();
										Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text3) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
									}
									throw new AssertionException("ncc\\generation\\ILEmitter.n", 1325, "", "float, double or decimal as an argument for binary negation in CGIL");
								}
								_ilg.Emit(OpCodes.Not);
								break;
							}
							case "*.s":
								_ilg.Emit(OpCodes.Mul_Ovf);
								break;
							case "*.u":
								_ilg.Emit(OpCodes.Mul_Ovf_Un);
								break;
							case "*.f":
								_ilg.Emit(OpCodes.Mul);
								break;
							case "/.s":
							case "/.f":
								_ilg.Emit(OpCodes.Div);
								break;
							case "/.u":
								_ilg.Emit(OpCodes.Div_Un);
								break;
							case "%.s":
							case "%.f":
								_ilg.Emit(OpCodes.Rem);
								break;
							case "%.u":
								_ilg.Emit(OpCodes.Rem_Un);
								break;
							case "|.s":
							case "|.u":
							case "|.f":
							case "|":
								_ilg.Emit(OpCodes.Or);
								break;
							case "&.s":
							case "&.u":
							case "&.f":
							case "&":
								_ilg.Emit(OpCodes.And);
								break;
							case "^.s":
							case "^.u":
							case "^.f":
							case "^":
								_ilg.Emit(OpCodes.Xor);
								break;
							case "bool.!":
								_ilg.Emit(OpCodes.Ldc_I4_0);
								_ilg.Emit(OpCodes.Ceq);
								break;
							case "==.ref":
							case "==":
								_ilg.Emit(OpCodes.Ceq);
								break;
							case "!=.ref":
							case "!=":
								_ilg.Emit(OpCodes.Ceq);
								InversBool();
								break;
							case "<.s":
							case "<.f":
								_ilg.Emit(OpCodes.Clt);
								break;
							case "<.u":
								_ilg.Emit(OpCodes.Clt_Un);
								break;
							case ">.s":
							case ">.f":
								_ilg.Emit(OpCodes.Cgt);
								break;
							case ">.u":
								_ilg.Emit(OpCodes.Cgt_Un);
								break;
							case "<=.s":
								_ilg.Emit(OpCodes.Cgt);
								InversBool();
								break;
							case "<=.f":
								_ilg.Emit(OpCodes.Cgt_Un);
								InversBool();
								break;
							case "<=.u":
								_ilg.Emit(OpCodes.Cgt_Un);
								InversBool();
								break;
							case ">=.s":
								_ilg.Emit(OpCodes.Clt);
								InversBool();
								break;
							case ">=.f":
								_ilg.Emit(OpCodes.Clt_Un);
								InversBool();
								break;
							case ">=.u":
								_ilg.Emit(OpCodes.Clt_Un);
								InversBool();
								break;
							default:
								if (!Message.SeenError)
								{
									string text2 = string.Concat(string.Concat(_method_name + ": unmatched TExpr.Opcode (", name3), ")").ToString();
									Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text2) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
								}
								throw new AssertionException("ncc\\generation\\ILEmitter.n", 1351, "", string.Concat(string.Concat(_method_name + ": unmatched TExpr.Opcode (", name3), ")").ToString());
							case "unary.+.s":
							case "unary.+.u":
							case "unary.+.f":
								break;
								IL_1ccf:
								if (list13 is list<Parm>.Cons && (object)((list<Parm>.Cons)list13).tl == list<Parm>.Nil._N_constant_object)
								{
									Parm hd5 = ((list<Parm>.Cons)list13).hd;
									if (hd5.expr.Type.IsPointer)
									{
										TypeVar type9 = hd5.expr.Type;
										emit_index_multiplier(type9);
										_ilg.Emit(OpCodes.Conv_I);
										if (flag6)
										{
											_ilg.Emit(OpCodes.Add);
										}
										else
										{
											_ilg.Emit(OpCodes.Sub);
										}
										break;
									}
								}
								if (!Message.SeenError)
								{
									string text4 = string.Concat(string.Concat(_method_name + ": incorrect args for TExpr.Opcode (", name3), ")").ToString();
									Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text4) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
								}
								throw new AssertionException("ncc\\generation\\ILEmitter.n", 1317, "", string.Concat(string.Concat(_method_name + ": incorrect args for TExpr.Opcode (", name3), ")").ToString());
								IL_1277:
								if (list13 is list<Parm>.Cons && ((list<Parm>.Cons)list13).tl is list<Parm>.Cons)
								{
									Parm hd6 = ((list<Parm>.Cons)list13).hd;
									if ((object)((list<Parm>.Cons)((list<Parm>.Cons)list13).tl).tl == list<Parm>.Nil._N_constant_object)
									{
										Parm hd7 = ((list<Parm>.Cons)((list<Parm>.Cons)list13).tl).hd;
										if (hd6.expr.Type.IsPointer && hd7.expr.Type.Fix().Equals(InternalType.Int32))
										{
											TypeVar type10 = hd6.expr.Type;
											int num2 = get_elem_size(type10);
											_ilg.Emit(OpCodes.Conv_I);
											emit_index_multiplier(num2);
											if (num2 > 8)
											{
												_ilg.Emit(OpCodes.Mul);
											}
											if (flag7)
											{
												_ilg.Emit(OpCodes.Add);
											}
											else
											{
												_ilg.Emit(OpCodes.Sub);
											}
											break;
										}
									}
								}
								if (!Message.SeenError)
								{
									string text5 = string.Concat(string.Concat(_method_name + ": incorrect args for TExpr.Opcode (", name3), ")").ToString();
									Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text5) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
								}
								throw new AssertionException("ncc\\generation\\ILEmitter.n", 1259, "", string.Concat(string.Concat(_method_name + ": incorrect args for TExpr.Opcode (", name3), ")").ToString());
							}
							if (expr.GenerateTail)
							{
								_ilg.Emit(OpCodes.Ret);
							}
							break;
						}
					}
					goto IL_0988;
				case 6:
					if (((TExpr.Assign)expr).target is TExpr.StaticRef)
					{
						TExpr.StaticRef expr11 = (TExpr.StaticRef)((TExpr.Assign)expr).target;
						if (((TExpr.StaticRef)((TExpr.Assign)expr).target).mem is IField)
						{
							FixedType.Class from3 = ((TExpr.StaticRef)((TExpr.Assign)expr).target).from;
							IField meth2 = (IField)((TExpr.StaticRef)((TExpr.Assign)expr).target).mem;
							TExpr source = ((TExpr.Assign)expr).source;
							emit(source);
							maybe_volatile(expr11);
							FieldInfo fieldInfo3 = GetFieldInfo(from3.GetSystemType(), meth2);
							_ilg.Emit(OpCodes.Stsfld, fieldInfo3);
							break;
						}
					}
					else
					{
						if (((TExpr.Assign)expr).target is TExpr.LocalRef)
						{
							TExpr source2 = ((TExpr.Assign)expr).source;
							if (!source2.Throws)
							{
								LocalValue decl2 = ((TExpr.LocalRef)((TExpr.Assign)expr).target).decl;
								source2 = ((TExpr.Assign)expr).source;
								if (!is_void(decl2.Type))
								{
									if (((TExpr.Assign)expr).source is TExpr.ImplicitValueTypeCtor)
									{
										LocalValue decl3 = ((TExpr.LocalRef)((TExpr.Assign)expr).target).decl;
										TExpr.ImplicitValueTypeCtor implicitValueTypeCtor = (TExpr.ImplicitValueTypeCtor)((TExpr.Assign)expr).source;
										emit_ce_ref(decl3, get_address_for_value_types: true);
										_ilg.Emit(OpCodes.Initobj, implicitValueTypeCtor.GetSystemType());
										break;
									}
									LocalValue decl4 = ((TExpr.LocalRef)((TExpr.Assign)expr).target).decl;
									TExpr source3 = ((TExpr.Assign)expr).source;
									if (decl4.IsByRefParm)
									{
										LocalBuilder[] local_variables = emit_exprs_prepare(new list<TExpr>.Cons(source3, list<TExpr>.Nil._N_constant_object));
										emit_ldarg(decl4.ParmIndex);
										emit_exprs_push(local_variables, new list<TExpr>.Cons(source3, list<TExpr>.Nil._N_constant_object));
										Type systemType7 = source3.GetSystemType();
										if (systemType7.IsValueType || systemType7.IsGenericParameter)
										{
											_ilg.Emit(OpCodes.Stobj, systemType7);
										}
										else
										{
											_ilg.Emit(OpCodes.Stind_Ref);
										}
									}
									else
									{
										LocalValue decl5 = ((TExpr.LocalRef)((TExpr.Assign)expr).target).decl;
										TExpr source4 = ((TExpr.Assign)expr).source;
										emit(source4);
										if (!source4.Throws)
										{
											store_local(decl5);
										}
									}
									break;
								}
							}
							emit(source2);
							break;
						}
						if (((TExpr.Assign)expr).target is TExpr.FieldMember)
						{
							TExpr.FieldMember expr12 = (TExpr.FieldMember)((TExpr.Assign)expr).target;
							TExpr obj7 = ((TExpr.FieldMember)((TExpr.Assign)expr).target).obj;
							IField fld2 = ((TExpr.FieldMember)((TExpr.Assign)expr).target).fld;
							TExpr source5 = ((TExpr.Assign)expr).source;
							if (source5.NeedsEmptyStack)
							{
								LocalBuilder local7 = declare_expr_local_slot(obj7);
								LocalBuilder local8 = declare_expr_local_slot(source5);
								emit(obj7);
								_ilg.Emit(OpCodes.Stloc, local7);
								emit(source5);
								_ilg.Emit(OpCodes.Stloc, local8);
								_ilg.Emit(OpCodes.Ldloc, local7);
								if (obj7.GetSystemType().IsGenericParameter)
								{
									_ilg.Emit(OpCodes.Box, obj7.GetSystemType());
								}
								_ilg.Emit(OpCodes.Ldloc, local8);
							}
							else
							{
								emit(obj7);
								if (obj7.GetSystemType().IsGenericParameter)
								{
									_ilg.Emit(OpCodes.Box, obj7.GetSystemType());
								}
								emit(source5);
							}
							maybe_volatile(expr12);
							FieldInfo fieldInfo4 = GetFieldInfo(obj7, fld2);
							_ilg.Emit(OpCodes.Stfld, fieldInfo4);
							break;
						}
						if (((TExpr.Assign)expr).target is TExpr.This)
						{
							TExpr source6 = ((TExpr.Assign)expr).source;
							if (!_this_is_value_type)
							{
								if (!Message.SeenError)
								{
									Message.Debug("Internal compiler error, please report a bug to bugs.nemerle.org. You can try modifying program near this location.");
								}
								throw new AssertionException("ncc\\generation\\ILEmitter.n", 1124, _this_is_value_type.ToString(), "we can assign to 'this' only in valuetypes");
							}
							LocalBuilder[] local_variables2 = emit_exprs_prepare(new list<TExpr>.Cons(source6, list<TExpr>.Nil._N_constant_object));
							_ilg.Emit(OpCodes.Ldarg_0);
							emit_exprs_push(local_variables2, new list<TExpr>.Cons(source6, list<TExpr>.Nil._N_constant_object));
							_ilg.Emit(OpCodes.Stobj, _type_of_this);
							break;
						}
						if (((TExpr.Assign)expr).target is TExpr.ArrayIndexer)
						{
							TExpr.ArrayIndexer arrayIndexer = (TExpr.ArrayIndexer)((TExpr.Assign)expr).target;
							if (((TExpr.ArrayIndexer)((TExpr.Assign)expr).target).args is list<TExpr>.Cons)
							{
								TExpr obj8 = ((TExpr.ArrayIndexer)((TExpr.Assign)expr).target).obj;
								if ((object)((list<TExpr>.Cons)((TExpr.ArrayIndexer)((TExpr.Assign)expr).target).args).tl == list<TExpr>.Nil._N_constant_object)
								{
									TExpr hd4 = ((list<TExpr>.Cons)((TExpr.ArrayIndexer)((TExpr.Assign)expr).target).args).hd;
									TExpr source7 = ((TExpr.Assign)expr).source;
									Type systemType8 = source7.GetSystemType();
									if (hd4.NeedsEmptyStack || source7.NeedsEmptyStack)
									{
										LocalBuilder local9 = declare_expr_local_slot(obj8);
										LocalBuilder local10 = declare_expr_local_slot(hd4);
										LocalBuilder local11 = declare_expr_local_slot(source7);
										emit(obj8);
										_ilg.Emit(OpCodes.Stloc, local9);
										emit(hd4);
										_ilg.Emit(OpCodes.Stloc, local10);
										emit(source7);
										_ilg.Emit(OpCodes.Stloc, local11);
										_ilg.Emit(OpCodes.Ldloc, local9);
										_ilg.Emit(OpCodes.Ldloc, local10);
										if (systemType8.IsValueType && !systemType8.IsPrimitive)
										{
											_ilg.Emit(OpCodes.Ldelema, systemType8);
										}
										_ilg.Emit(OpCodes.Ldloc, local11);
									}
									else
									{
										emit(obj8);
										emit(hd4);
										if (systemType8.IsValueType && !systemType8.IsPrimitive)
										{
											_ilg.Emit(OpCodes.Ldelema, systemType8);
										}
										emit(source7);
									}
									emit_array_store_opcode(arrayIndexer.GetSystemType());
									break;
								}
							}
							TExpr obj9 = ((TExpr.ArrayIndexer)((TExpr.Assign)expr).target).obj;
							list<TExpr> list9 = ((TExpr.ArrayIndexer)((TExpr.Assign)expr).target).args;
							TExpr source8 = ((TExpr.Assign)expr).source;
							emit_exprs(new list<TExpr>.Cons(obj9, list<TExpr>.Nil._N_constant_object) + list9 + new list<TExpr>.Cons(source8, list<TExpr>.Nil._N_constant_object));
							MethodInfo method2 = array_set_method(obj9);
							emit_method_call(expr, base_is_value_type_or_static: true, method2);
							break;
						}
					}
					goto IL_0988;
				case 7:
				{
					TExpr val2 = ((TExpr.DefValIn)expr).val;
					TExpr body4 = ((TExpr.DefValIn)expr).body;
					if (val2.Throws && !body4.JumpTarget)
					{
						emit(val2);
						skipped(body4);
						break;
					}
					if (((TExpr.DefValIn)expr).val is TExpr.Literal)
					{
						LocalValue name2 = ((TExpr.DefValIn)expr).name;
						if (((TExpr.DefValIn)expr).body is TExpr.Literal && ((TExpr.Literal)((TExpr.DefValIn)expr).body).val is Literal.Void && !name2.EverUsed && !name2.InClosure)
						{
							break;
						}
					}
					name = ((TExpr.DefValIn)expr).name;
					val = ((TExpr.DefValIn)expr).val;
					body5 = ((TExpr.DefValIn)expr).body;
					if (val is TExpr.DefaultValue)
					{
						if (name.IsMutable)
						{
							goto IL_2d56;
						}
						if (!is_void(name.Type))
						{
							declare_val_local_slot_ex(name);
						}
					}
					else
					{
						if (!(val is TExpr.ImplicitValueTypeCtor))
						{
							goto IL_2d56;
						}
						LocalBuilder local5 = declare_val_local_slot(name);
						_ilg.Emit(OpCodes.Ldloca, local5);
						_ilg.Emit(OpCodes.Initobj, val.GetSystemType());
					}
					goto IL_2e16;
				}
				case 8:
				{
					if ((object)((TExpr.Throw)expr).exn == null)
					{
						_ilg.Emit(OpCodes.Rethrow);
						break;
					}
					TExpr exn = ((TExpr.Throw)expr).exn;
					emit(exn);
					_ilg.Emit(OpCodes.Throw);
					break;
				}
				case 9:
				{
					TExpr body2 = ((TExpr.TryFinally)expr).body;
					TExpr handler = ((TExpr.TryFinally)expr).handler;
					Type systemType5 = body2.GetSystemType();
					_ilg.BeginExceptionBlock();
					emit(body2);
					bool flag4 = is_void(body2.Type);
					LocalBuilder local3 = null;
					if (!flag4)
					{
						local3 = _ilg.DeclareLocal(systemType5);
						if (!body2.Throws)
						{
							_ilg.Emit(OpCodes.Stloc, local3);
						}
					}
					_ilg.BeginFinallyBlock();
					emit(handler);
					_ilg.EndExceptionBlock();
					if (!flag4)
					{
						_ilg.Emit(OpCodes.Ldloc, local3);
					}
					break;
				}
				case 10:
				{
					TExpr body3 = ((TExpr.Try)expr).body;
					list<Try_case> list6 = ((TExpr.Try)expr).cases;
					Type systemType6 = expr.GetSystemType();
					n_closureOf_emit_._N_ignore_try_result_74408 = is_void(body3.Type);
					n_closureOf_emit_._N_try_result_74406 = null;
					if (!n_closureOf_emit_._N_ignore_try_result_74408)
					{
						n_closureOf_emit_._N_try_result_74406 = _ilg.DeclareLocal(systemType6);
					}
					_ilg.BeginExceptionBlock();
					emit(body3);
					if (!body3.Throws && !n_closureOf_emit_._N_ignore_try_result_74408)
					{
						_ilg.Emit(OpCodes.Stloc, n_closureOf_emit_._N_try_result_74406);
					}
					list<Try_case> list7 = list6;
					while (list7 is list<Try_case>.Cons)
					{
						Try_case hd3 = ((list<Try_case>.Cons)list7).hd;
						list<Try_case> list8 = ((list<Try_case>.Cons)list7).tl;
						Try_case @case = hd3;
						_N_walk_case_74922(n_closureOf_emit_, @case);
						list7 = list8;
					}
					_ilg.EndExceptionBlock();
					if (!n_closureOf_emit_._N_ignore_try_result_74408)
					{
						_ilg.Emit(OpCodes.Ldloc, n_closureOf_emit_._N_try_result_74406);
					}
					break;
				}
				case 11:
				{
					Literal val3 = ((TExpr.Literal)expr).val;
					if (val3 == null)
					{
						if (!Message.SeenError)
						{
							Message.Debug("Internal compiler error, please report a bug to bugs.nemerle.org. You can try modifying program near this location.");
						}
						throw new AssertionException("ncc\\generation\\ILEmitter.n", 1501, (val3 != null).ToString(), "");
					}
					if (val3 is Literal.Null)
					{
						FixedType fixedType5 = expr.FixedType();
						if (!(fixedType5 is FixedType.StaticTypeVarRef))
						{
							if (fixedType5 is FixedType.Class && ((FixedType.Class)fixedType5).args is list<TypeVar>.Cons)
							{
								TypeInfo tycon = ((FixedType.Class)fixedType5).tycon;
								if ((object)((list<TypeVar>.Cons)((FixedType.Class)fixedType5).args).tl == list<TypeVar>.Nil._N_constant_object && tycon.Equals(InternalType.Generic_Nullable_tc))
								{
									goto IL_3112;
								}
							}
							emit_literal(val3);
							break;
						}
						goto IL_3112;
					}
					if (!(val3 is Literal.Void))
					{
						emit_literal(val3);
					}
					break;
				}
				case 12:
					if (_method_builder.IsStatic)
					{
						if (!Message.SeenError)
						{
							Message.Debug("Internal compiler error, please report a bug to bugs.nemerle.org. You can try modifying program near this location.");
						}
						throw new AssertionException("ncc\\generation\\ILEmitter.n", 1489, (!_method_builder.IsStatic).ToString(), "This is a static method");
					}
					_ilg.Emit(OpCodes.Ldarg_0);
					if (_this_is_value_type && !expr.NeedAddress)
					{
						_ilg.Emit(OpCodes.Ldobj, expr.GetSystemType());
					}
					break;
				case 14:
				{
					TExpr expr2 = ((TExpr.TypeConversion)expr).expr;
					if (expr2.Throws)
					{
						emit(expr2);
						break;
					}
					TExpr expr3 = ((TExpr.TypeConversion)expr).expr;
					TypeVar target_type = ((TExpr.TypeConversion)expr).target_type;
					if (target_type.IsPointer)
					{
						emit_value_to_ptr_conversion(expr3, target_type);
						break;
					}
					TExpr expr4 = ((TExpr.TypeConversion)expr).expr;
					TypeVar target_type2 = ((TExpr.TypeConversion)expr).target_type;
					if (no_cast_needed(expr4.GetSystemType(), target_type2.GetSystemType()))
					{
						emit(expr4);
						break;
					}
					if (((TExpr.TypeConversion)expr).kind == ConversionKind.Boxing._N_constant_object)
					{
						TExpr expr5 = ((TExpr.TypeConversion)expr).expr;
						TypeVar target_type3 = ((TExpr.TypeConversion)expr).target_type;
						if (target_type3.GetSystemType().IsGenericParameter)
						{
							emit(expr5);
							_ilg.Emit(OpCodes.Box, expr5.GetSystemType());
							_ilg.Emit(OpCodes.Unbox_Any, target_type3.GetSystemType());
							break;
						}
						expr6 = ((TExpr.TypeConversion)expr).expr;
						target_type4 = ((TExpr.TypeConversion)expr).target_type;
						if (target_type4.GetSystemType().IsGenericParameter)
						{
							goto IL_33c8;
						}
						expr7 = ((TExpr.TypeConversion)expr).expr;
						TypeVar target_type5 = ((TExpr.TypeConversion)expr).target_type;
						if (is_void(target_type5))
						{
							goto IL_3467;
						}
						expr8 = ((TExpr.TypeConversion)expr).expr;
						target_type6 = ((TExpr.TypeConversion)expr).target_type;
						kind = ((TExpr.TypeConversion)expr).kind;
						if (!target_type6.Fix().IsValueType)
						{
							goto IL_34db;
						}
					}
					else
					{
						expr6 = ((TExpr.TypeConversion)expr).expr;
						target_type4 = ((TExpr.TypeConversion)expr).target_type;
						if (target_type4.GetSystemType().IsGenericParameter)
						{
							goto IL_33c8;
						}
						expr7 = ((TExpr.TypeConversion)expr).expr;
						TypeVar target_type5 = ((TExpr.TypeConversion)expr).target_type;
						if (is_void(target_type5))
						{
							goto IL_3467;
						}
						expr8 = ((TExpr.TypeConversion)expr).expr;
						target_type6 = ((TExpr.TypeConversion)expr).target_type;
						kind = ((TExpr.TypeConversion)expr).kind;
						if (!target_type6.Fix().IsValueType)
						{
							goto IL_34db;
						}
					}
					TExpr expr9 = ((TExpr.TypeConversion)expr).expr;
					TypeVar target_type7 = ((TExpr.TypeConversion)expr).target_type;
					ConversionKind kind2 = ((TExpr.TypeConversion)expr).kind;
					bool flag2 = ((kind2 is ConversionKind.IL && !((ConversionKind.IL)kind2).is_checked) ? true : false);
					bool is_checked = !flag2;
					emit(expr9);
					Type systemType = expr9.GetSystemType();
					Type systemType2 = target_type7.GetSystemType();
					int num;
					if (systemType.IsGenericParameter)
					{
						_ilg.Emit(OpCodes.Box, systemType);
						num = 1;
					}
					else
					{
						num = 0;
					}
					bool flag3 = unchecked((byte)num) != 0;
					if (systemType.IsValueType)
					{
						emit_value_type_conversion(expr.Location, expr9.FixedType(), target_type7.Fix(), is_checked);
						break;
					}
					if ((object)SystemTypeCache.Object == systemType && systemType2.IsValueType)
					{
						_ilg.Emit(OpCodes.Unbox_Any, systemType2);
						break;
					}
					if (flag3 || (object)SystemTypeCache.Object == systemType || systemType.IsInterface || ((object)SystemTypeCache.Enum == systemType && systemType2.IsEnum))
					{
						_ilg.Emit(OpCodes.Unbox, systemType2);
						maybe_volatile(expr9);
						emit_ldind_for_value_type(systemType2);
						break;
					}
					if (!Message.SeenError)
					{
						string text = (Convert.ToString(_method_name) + ": failed to convert non-value type " + Convert.ToString(systemType) + " to a value type " + Convert.ToString(target_type7)).ToString();
						Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
					}
					throw new AssertionException("ncc\\generation\\ILEmitter.n", 934, "", (Convert.ToString(_method_name) + ": failed to convert non-value type " + Convert.ToString(systemType) + " to a value type " + Convert.ToString(target_type7)).ToString());
				}
				case 15:
				{
					TExpr e = ((TExpr.Sequence)expr).e1;
					TExpr e2 = ((TExpr.Sequence)expr).e2;
					emit(e);
					if (!e.Throws || e2.JumpTarget)
					{
						emit(e2);
					}
					else
					{
						skipped(e2);
					}
					break;
				}
				case 16:
				{
					list<TExpr> list23 = ((TExpr.Tuple)expr).args;
					emit_exprs(list23);
					IMethod ctor = InternalType.GetTupleType(list23.Length).Ctor;
					_ilg.Emit(OpCodes.Newobj, GetConstructorInfo(expr.GetSystemType(), ctor));
					break;
				}
				case 17:
				{
					if (((TExpr.Array)expr).dimensions is list<TExpr>.Cons)
					{
						list<TExpr> list14 = ((TExpr.Array)expr).args;
						if ((object)((list<TExpr>.Cons)((TExpr.Array)expr).dimensions).tl == list<TExpr>.Nil._N_constant_object)
						{
							TExpr hd8 = ((list<TExpr>.Cons)((TExpr.Array)expr).dimensions).hd;
							FixedType fixedType3 = expr.Type.Fix();
							if (fixedType3 is FixedType.Array)
							{
								TypeVar t = ((FixedType.Array)fixedType3).t;
								Type systemType11 = t.GetSystemType();
								emit(hd8);
								_ilg.Emit(OpCodes.Newarr, systemType11);
								Function<TExpr, bool> instance5 = _N__N_lambda__74320__75078.Instance;
								bool flag8 = list14.Exists(instance5);
								LocalBuilder local12 = null;
								LocalBuilder local13 = null;
								if (flag8)
								{
									local12 = declare_expr_local_slot(expr);
									local13 = _ilg.DeclareLocal(systemType11);
									_ilg.Emit(OpCodes.Stloc, local12);
									_ilg.Emit(OpCodes.Ldloc, local12);
								}
								int num3 = 0;
								list<TExpr> list15 = list14;
								while (true)
								{
									if ((object)list15 == list<TExpr>.Nil._N_constant_object)
									{
										return;
									}
									if (!(list15 is list<TExpr>.Cons))
									{
										break;
									}
									TExpr hd9 = ((list<TExpr>.Cons)list15).hd;
									list<TExpr> list16 = ((list<TExpr>.Cons)list15).tl;
									if (hd9.NeedsEmptyStack)
									{
										_ilg.Emit(OpCodes.Pop);
										emit(hd9);
										_ilg.Emit(OpCodes.Stloc, local13);
										_ilg.Emit(OpCodes.Ldloc, local12);
										_ilg.Emit(OpCodes.Ldc_I4, num3);
										if (systemType11.IsValueType && !systemType11.IsPrimitive)
										{
											_ilg.Emit(OpCodes.Ldelema, systemType11);
										}
										_ilg.Emit(OpCodes.Ldloc, local13);
										emit_array_store_opcode(systemType11);
										_ilg.Emit(OpCodes.Ldloc, local12);
									}
									else
									{
										_ilg.Emit(OpCodes.Dup);
										_ilg.Emit(OpCodes.Ldc_I4, num3);
										if (systemType11.IsValueType && !systemType11.IsPrimitive)
										{
											_ilg.Emit(OpCodes.Ldelema, systemType11);
										}
										emit(hd9);
										emit_array_store_opcode(systemType11);
									}
									int num4 = num3 + 1;
									list15 = list16;
									num3 = num4;
								}
								throw new MatchFailureException();
							}
							if (!Message.SeenError)
							{
								string text6 = "(see backtrace)".ToString();
								Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text6) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
							}
							throw new AssertionException("ncc\\generation\\ILEmitter.n", 1539, "", "(see backtrace)");
						}
					}
					list<TExpr> list17 = ((TExpr.Array)expr).args;
					list<TExpr> list18 = ((TExpr.Array)expr).dimensions;
					FixedType fixedType4 = expr.Type.Fix();
					if (fixedType4 is FixedType.Array)
					{
						TypeVar t2 = ((FixedType.Array)fixedType4).t;
						Type systemType12 = t2.GetSystemType();
						int length = list18.Length;
						emit_exprs(list18);
						Type[] array = new Type[length];
						for (int i = 0; i < length; i++)
						{
							array[i] = SystemTypeCache.Int32;
						}
						MethodInfo arrayMethod = _module_builder.GetArrayMethod(expr.GetSystemType(), ".ctor", CallingConventions.HasThis, null, array);
						_ilg.Emit(OpCodes.Newobj, arrayMethod);
						if (list17.IsEmpty)
						{
							break;
						}
						MethodInfo method6 = array_set_method(expr.GetSystemType());
						ulong[] array2 = new ulong[length];
						int num5 = 0;
						list<TExpr> list19 = list18;
						while (list19 is list<TExpr>.Cons)
						{
							TExpr hd10 = ((list<TExpr>.Cons)list19).hd;
							list<TExpr> list20 = ((list<TExpr>.Cons)list19).tl;
							if (hd10 is TExpr.Literal && ((TExpr.Literal)hd10).val is Literal.Integer)
							{
								ulong num6 = (array2[num5] = ((Literal.Integer)((TExpr.Literal)hd10).val).val);
								num5++;
							}
							list19 = list20;
						}
						if (num5 != length)
						{
							if (!Message.SeenError)
							{
								Message.Debug("Internal compiler error, please report a bug to bugs.nemerle.org. You can try modifying program near this location.");
							}
							throw new AssertionException("ncc\\generation\\ILEmitter.n", 1622, (num5 == length).ToString(), "dimensions must be literals when initializes are supplied");
						}
						Function<TExpr, bool> instance6 = _N__N_lambda__74360__75138.Instance;
						bool flag9 = list17.Exists(instance6);
						LocalBuilder local14 = null;
						LocalBuilder local15 = null;
						if (flag9)
						{
							local14 = declare_expr_local_slot(expr);
							local15 = _ilg.DeclareLocal(systemType12);
							_ilg.Emit(OpCodes.Stloc, local14);
							_ilg.Emit(OpCodes.Ldloc, local14);
						}
						ulong[] array3 = new ulong[array2.Length];
						list<TExpr> list21 = list17;
						while (true)
						{
							if ((object)list21 == list<TExpr>.Nil._N_constant_object)
							{
								return;
							}
							if (!(list21 is list<TExpr>.Cons))
							{
								break;
							}
							TExpr hd11 = ((list<TExpr>.Cons)list21).hd;
							list<TExpr> list22 = ((list<TExpr>.Cons)list21).tl;
							if (hd11.NeedsEmptyStack)
							{
								_ilg.Emit(OpCodes.Pop);
								emit(hd11);
								_ilg.Emit(OpCodes.Stloc, local15);
								_ilg.Emit(OpCodes.Ldloc, local14);
								_ilg.Emit(OpCodes.Dup);
								for (int j = 0; j < array3.Length; j++)
								{
									emit_literal(new Literal.Integer((ulong)(int)array3[j], is_negative: false, InternalType.Int32));
								}
								_ilg.Emit(OpCodes.Ldloc, local15);
							}
							else
							{
								_ilg.Emit(OpCodes.Dup);
								for (int k = 0; k < array3.Length; k++)
								{
									emit_literal(new Literal.Integer((ulong)(int)array3[k], is_negative: false, InternalType.Int32));
								}
								emit(hd11);
							}
							emit_method_call(expr, base_is_value_type_or_static: true, method6);
							ulong[] array4 = array3;
							int num7 = array4.Length - 1;
							array4[num7]++;
							int num8 = array4.Length - 1;
							while (array4[num8] == array2[num8] && num8 > 0)
							{
								array4[num8] = 0uL;
								int num9 = num8 - 1;
								array4[num9]++;
								num8--;
							}
							ulong[] array5 = array4;
							list21 = list22;
							array3 = array5;
						}
						throw new MatchFailureException();
					}
					if (!Message.SeenError)
					{
						string text7 = "(see backtrace)".ToString();
						Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text7) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
					}
					throw new AssertionException("ncc\\generation\\ILEmitter.n", 1595, "", "(see backtrace)");
				}
				case 18:
				{
					TypeVar target_type8 = ((TExpr.TypeOf)expr).target_type;
					_ilg.Emit(OpCodes.Ldtoken, target_type8.GetSystemType());
					_ilg.Emit(OpCodes.Call, SystemTypeCache.Type_GetTypeFromHandle);
					break;
				}
				case 19:
				{
					TypeVar from_type2 = ((TExpr.MethodOf)expr).from_type;
					IMethod method5 = ((TExpr.MethodOf)expr).method;
					list<TypeVar> typars5 = ((TExpr.MethodOf)expr).typars;
					MethodInfo methodInfo5 = GetMethodInfo(from_type2, method5, typars5);
					Type declaringType2 = methodInfo5.DeclaringType;
					_ilg.Emit(OpCodes.Ldtoken, methodInfo5);
					if (declaringType2 == null)
					{
						_ilg.Emit(OpCodes.Call, SystemTypeCache.MethodBase_GetMethodFromHandle);
					}
					else
					{
						_ilg.Emit(OpCodes.Ldtoken, declaringType2);
						_ilg.Emit(OpCodes.Call, SystemTypeCache.MethodBase_GetMethodFromHandle2);
					}
					_ilg.Emit(OpCodes.Castclass, typeof(MethodInfo));
					break;
				}
				case 20:
				{
					TypeVar type11 = ((TExpr.CtorOf)expr).type;
					IMethod method4 = ((TExpr.CtorOf)expr).method;
					Type systemType10 = type11.GetSystemType();
					ConstructorInfo constructorInfo3 = GetConstructorInfo(systemType10, method4);
					_ilg.Emit(OpCodes.Ldtoken, constructorInfo3);
					_ilg.Emit(OpCodes.Ldtoken, systemType10);
					_ilg.Emit(OpCodes.Call, SystemTypeCache.MethodBase_GetMethodFromHandle2);
					_ilg.Emit(OpCodes.Castclass, typeof(ConstructorInfo));
					break;
				}
				case 21:
				{
					TypeVar type8 = ((TExpr.FieldOf)expr).type;
					IField field2 = ((TExpr.FieldOf)expr).field;
					FieldInfo fieldInfo2 = GetFieldInfo(type8.GetSystemType(), field2);
					Type declaringType = fieldInfo2.DeclaringType;
					_ilg.Emit(OpCodes.Ldtoken, fieldInfo2);
					if (declaringType == null)
					{
						_ilg.Emit(OpCodes.Call, SystemTypeCache.FieldInfo_GetFieldFromHandle);
					}
					else
					{
						_ilg.Emit(OpCodes.Ldtoken, declaringType);
						_ilg.Emit(OpCodes.Call, SystemTypeCache.FieldInfo_GetFieldFromHandle2);
					}
					_ilg.Emit(OpCodes.Castclass, typeof(FieldInfo));
					break;
				}
				case 22:
					if (((TExpr.ClosureObjectOf)expr).varRef is TExpr.FieldMember)
					{
						TExpr obj6 = ((TExpr.FieldMember)((TExpr.ClosureObjectOf)expr).varRef).obj;
						emit(obj6);
						break;
					}
					throw new AssertionException("ncc\\generation\\ILEmitter.n", 763, "", "You mast put into ClosureObjectOf only TExpr.LocalRef which will be closured by compiler");
				case 23:
					if (((TExpr.ClosureFieldOf)expr).varRef is TExpr.FieldMember)
					{
						TExpr obj5 = ((TExpr.FieldMember)((TExpr.ClosureFieldOf)expr).varRef).obj;
						IField fld = ((TExpr.FieldMember)((TExpr.ClosureFieldOf)expr).varRef).fld;
						emit(new TExpr.FieldOf(obj5.Type, fld));
						break;
					}
					throw new AssertionException("ncc\\generation\\ILEmitter.n", 764, "", "You mast put into ClosureFieldOf only TExpr.LocalRef which will be closured by compiler");
				case 24:
				{
					if (((TExpr.ArrayIndexer)expr).args is list<TExpr>.Cons)
					{
						TExpr obj3 = ((TExpr.ArrayIndexer)expr).obj;
						if ((object)((list<TExpr>.Cons)((TExpr.ArrayIndexer)expr).args).tl == list<TExpr>.Nil._N_constant_object)
						{
							TExpr hd = ((list<TExpr>.Cons)((TExpr.ArrayIndexer)expr).args).hd;
							emit_exprs(new list<TExpr>.Cons(obj3, new list<TExpr>.Cons(hd, list<TExpr>.Nil._N_constant_object)));
							Type elementType = obj3.GetSystemType().GetElementType();
							if (!(elementType != null))
							{
								throw new AssertionException("ncc\\generation\\ILEmitter.n", 997, "element_type != null", "non-array in TExpr.ArrayIndexer");
							}
							if (expr.NeedAddress)
							{
								_ilg.Emit(OpCodes.Ldelema, elementType);
							}
							else
							{
								emit_array_load_opcode(elementType);
							}
							break;
						}
					}
					TExpr obj4 = ((TExpr.ArrayIndexer)expr).obj;
					list<TExpr> list = ((TExpr.ArrayIndexer)expr).args;
					emit_exprs(new list<TExpr>.Cons(obj4, list<TExpr>.Nil._N_constant_object) + list);
					MethodInfo method = ((!expr.NeedAddress) ? array_get_method(obj4) : array_addr_method(obj4));
					emit_method_call(expr, base_is_value_type_or_static: true, method);
					break;
				}
				case 25:
				{
					TExpr obj2 = ((TExpr.PointerIndexer)expr).obj;
					TExpr index = ((TExpr.PointerIndexer)expr).index;
					emit_ptr_indexing(expr.NeedAddress, obj2, index);
					break;
				}
				case 26:
				{
					TExpr obj = ((TExpr.TupleIndexer)expr).obj;
					int pos = ((TExpr.TupleIndexer)expr).pos;
					int len = ((TExpr.TupleIndexer)expr).len;
					TupleType tupleType = InternalType.GetTupleType(len);
					emit(obj);
					_ilg.Emit(OpCodes.Ldfld, GetFieldInfo(obj.GetSystemType(), tupleType.GetField(pos + 1)));
					break;
				}
				case 28:
					{
						TExpr expanded = ((TExpr.MacroEnvelope)expr).expanded;
						emit(expanded);
						break;
					}
					IL_34db:
					emit(expr8);
					if (is_void(expr8.Type))
					{
						_ilg.Emit(OpCodes.Ldnull);
						break;
					}
					if (expr8.GetSystemType().IsGenericParameter)
					{
						_ilg.Emit(OpCodes.Box, expr8.GetSystemType());
						if (!target_type6.Fix().IsSystemObject)
						{
							if (target_type6.Fix().IsValueType)
							{
								_ilg.Emit(OpCodes.Unbox_Any, target_type6.GetSystemType());
							}
							else
							{
								_ilg.Emit(OpCodes.Castclass, target_type6.GetSystemType());
							}
						}
						break;
					}
					if (expr8.GetSystemType().IsValueType)
					{
						_ilg.Emit(OpCodes.Box, expr8.GetSystemType());
						break;
					}
					fixedType = target_type6.Fix();
					systemType3 = target_type6.GetSystemType();
					if (expr8.GetSystemType().IsArray && systemType3.IsArray && expr8.GetSystemType().GetElementType().IsValueType != systemType3.GetElementType().IsValueType)
					{
						Message.Error(expr8.Location, "attempting to cast a value type array " + Convert.ToString(expr8.GetSystemType()) + " to non-value type array " + Convert.ToString(systemType3) + " which cannot succeed");
					}
					if ((!(kind is ConversionKind.UpCast) && 0 == 0) || fixedType.IsInterface)
					{
						_ilg.Emit(OpCodes.Castclass, systemType3);
					}
					break;
					IL_3112:
					emit(new TExpr.DefaultValue(expr.Location, expr.Type));
					break;
					IL_2d56:
					emit(val);
					if (!is_void(name.Type))
					{
						if (!name.EverUsed)
						{
							_ilg.Emit(OpCodes.Pop);
						}
						else
						{
							LocalBuilder local4 = declare_val_local_slot(name);
							if (!val.Throws)
							{
								_ilg.Emit(OpCodes.Stloc, local4);
							}
						}
					}
					goto IL_2e16;
					IL_33c8:
					emit(expr6);
					if (!expr6.FixedType().IsValueType)
					{
						FixedType fixedType2 = expr6.FixedType();
						if (!(fixedType2 is FixedType.StaticTypeVarRef))
						{
							goto IL_3424;
						}
					}
					_ilg.Emit(OpCodes.Box, expr6.GetSystemType());
					goto IL_3424;
					IL_029d:
					if (_labels.Contains(id))
					{
						_label_usage[id] = null;
					}
					else
					{
						_labels[id] = _ilg.DefineLabel();
					}
					_ilg.MarkLabel(_labels[id], reset_throw);
					emit(body);
					break;
					IL_0988:
					Message.Warning("FIXME: unmatched: " + Convert.ToString(expr));
					break;
					IL_3424:
					_ilg.Emit(OpCodes.Unbox_Any, target_type4.GetSystemType());
					break;
					IL_2e16:
					emit(body5);
					break;
					IL_3467:
					if (is_void(expr7.Type))
					{
						emit(expr7);
						break;
					}
					emit(expr7);
					_ilg.Emit(OpCodes.Pop);
					break;
				}
			}
			finally
			{
				if (flag)
				{
					LocationStack.RemoveTop();
				}
			}
		}
	}

	private void emit_exprs(list<TExpr> exprs)
	{
		LocalBuilder[] local_variables = emit_exprs_prepare(exprs);
		emit_exprs_push(local_variables, exprs);
	}

	private LocalBuilder[] emit_exprs_prepare(list<TExpr> exprs)
	{
		int num = 0;
		int num2 = 0;
		bool flag = false;
		int num3 = 0;
		TExpr[] array = exprs.ToArray();
		num = exprs.Length;
		num3 = 0;
		num2 = 0;
		int num4 = checked(num - 1);
		flag = num2 <= num4;
		num = num4 - 1;
		bool flag2 = num > num4;
		while (flag)
		{
			num4 = num2;
			flag = ((!flag2) ? (num2 <= num) : (num2 >= num));
			num2++;
			if (array[num4].NeedsEmptyStack)
			{
				num3 = checked(num4 + 1);
			}
		}
		LocalBuilder[] array2 = new LocalBuilder[num3];
		num2 = 0;
		num = checked(num3 - 1);
		flag = num2 <= num;
		num3 = num - 1;
		flag2 = num3 > num;
		while (flag)
		{
			num = num2;
			flag = ((!flag2) ? (num2 <= num3) : (num2 >= num3));
			num2++;
			TExpr tExpr = array[num];
			Type localType = ((!tExpr.NeedAddress) ? tExpr.GetSystemType() : make_ref_type(tExpr.GetSystemType()));
			array2[num] = _ilg.DeclareLocal(localType);
			emit(tExpr);
			_ilg.Emit(OpCodes.Stloc, array2[num]);
		}
		return array2;
	}

	private void emit_exprs_push(LocalBuilder[] local_variables, list<TExpr> exprs)
	{
		int num = 0;
		foreach (LocalBuilder local in local_variables)
		{
			_ilg.Emit(OpCodes.Ldloc, local);
		}
		num = 0;
		list<TExpr> list = exprs;
		while (list is list<TExpr>.Cons)
		{
			TExpr hd = ((list<TExpr>.Cons)list).hd;
			list = ((list<TExpr>.Cons)list).tl;
			if (num >= local_variables.Length)
			{
				emit(hd);
			}
			num = checked(num + 1);
			list = list;
		}
	}

	private void emit_debug_info(TExpr.DebugInfo di)
	{
		_N_closureOf_emit_debug_info_75300 n_closureOf_emit_debug_info_;
		while (true)
		{
			n_closureOf_emit_debug_info_ = new _N_closureOf_emit_debug_info_75300();
			n_closureOf_emit_debug_info_._N__N_closurised_this_ptr_75305 = this;
			if (_debug_doc == null)
			{
				emit(di.expr);
				return;
			}
			TExpr expr = di.expr;
			if (!(expr is TExpr.DebugInfo))
			{
				break;
			}
			di = (TExpr.DebugInfo)di.expr;
		}
		Location location = di.Location;
		ISymbolDocumentWriter doc = DefineDebugDocument(di.Location.FileIndex);
		PExpr pexpr = di.pexpr;
		checked
		{
			if (pexpr is PExpr.Sequence)
			{
				_N_emit_debug_75316(n_closureOf_emit_debug_info_, doc, location.Line, location.Column, location.Line, location.Column + 1);
				_ilg.BeginScope();
			}
			else
			{
				_N_emit_debug_75316(n_closureOf_emit_debug_info_, doc, location.Line, location.Column, location.EndLine, location.EndColumn);
			}
			if (di.expr != null)
			{
				emit(di.expr);
			}
			pexpr = di.pexpr;
			if (pexpr is PExpr.Sequence)
			{
				_N_emit_debug_75316(n_closureOf_emit_debug_info_, doc, location.EndLine, location.EndColumn - 1, location.EndLine, location.EndColumn);
				_ilg.EndScope();
			}
		}
	}

	private MethodInfo array_set_method(Type t)
	{
		int num = 0;
		int arrayRank = t.GetArrayRank();
		checked
		{
			Type[] array = new Type[arrayRank + 1];
			for (num = 0; num < arrayRank; num++)
			{
				array[num] = SystemTypeCache.Int32;
			}
			array[arrayRank] = t.GetElementType();
			return _module_builder.GetArrayMethod(t, "Set", CallingConventions.HasThis | CallingConventions.Standard, SystemTypeCache.Void, array);
		}
	}

	private void emit_ce_ref(LocalValue decl, bool get_address_for_value_types)
	{
		if (decl.IsParm)
		{
			if (get_address_for_value_types && !decl.IsByRefParm)
			{
				emit_ldarga(decl.ParmIndex);
				return;
			}
			emit_ldarg(decl.ParmIndex);
			if (!get_address_for_value_types && decl.IsByRefParm)
			{
				Type systemType = decl.Type.GetSystemType();
				if (systemType.IsGenericParameter || systemType.IsValueType)
				{
					emit_ldind_for_value_type(systemType);
				}
				else
				{
					_ilg.Emit(OpCodes.Ldind_Ref);
				}
			}
		}
		else if (get_address_for_value_types && !decl.IsManagedPtr)
		{
			_ilg.Emit(OpCodes.Ldloca, decl.LocalSlot);
		}
		else
		{
			_ilg.Emit(OpCodes.Ldloc, decl.LocalSlot);
		}
	}

	private MethodInfo array_set_method(TExpr arr)
	{
		return array_set_method(arr.GetSystemType());
	}

	private MethodInfo array_get_method(TExpr arr)
	{
		int num = 0;
		Type systemType = arr.GetSystemType();
		int arrayRank = systemType.GetArrayRank();
		Type[] array = new Type[arrayRank];
		for (num = 0; num < arrayRank; num = checked(num + 1))
		{
			array[num] = SystemTypeCache.Int32;
		}
		return _module_builder.GetArrayMethod(systemType, "Get", CallingConventions.HasThis | CallingConventions.Standard, systemType.GetElementType(), array);
	}

	private MethodInfo array_addr_method(TExpr arr)
	{
		int num = 0;
		Type systemType = arr.GetSystemType();
		int arrayRank = systemType.GetArrayRank();
		Type[] array = new Type[arrayRank];
		for (num = 0; num < arrayRank; num = checked(num + 1))
		{
			array[num] = SystemTypeCache.Int32;
		}
		return _module_builder.GetArrayMethod(systemType, "Address", CallingConventions.HasThis | CallingConventions.Standard, make_ref_type(systemType.GetElementType()), array);
	}

	private void emit_switch(option<TExpr> default_expr, list<Nemerle.Builtins.Tuple<int, TExpr>> cases)
	{
		_N_closureOf_emit_switch_75453 n_closureOf_emit_switch_ = new _N_closureOf_emit_switch_75453();
		n_closureOf_emit_switch_._N__N_closurised_this_ptr_75462 = this;
		Label label = _ilg.DefineLabel();
		Label label2 = _ilg.DefineLabel();
		_N_closureOf_emit_switch_75453 n_closureOf_emit_switch_2 = n_closureOf_emit_switch_;
		Label n_default_jump_target_;
		if (default_expr is option<TExpr>.Some)
		{
			n_default_jump_target_ = label;
		}
		else
		{
			if (default_expr != option<TExpr>.None._N_constant_object)
			{
				throw new MatchFailureException();
			}
			n_default_jump_target_ = label2;
		}
		Label label3 = (n_closureOf_emit_switch_2._N_default_jump_target_75460 = n_default_jump_target_);
		Function<Nemerle.Builtins.Tuple<int, TExpr>, Nemerle.Builtins.Tuple<int, TExpr>, int> instance = _N_compare_cases__75467.Instance;
		list<Nemerle.Builtins.Tuple<int, TExpr>> list = cases.Sort(instance);
		if (list.Head.Field0 != 0)
		{
			if (!Message.SeenError)
			{
				Message.Debug("Internal compiler error, please report a bug to bugs.nemerle.org. You can try modifying program near this location.");
			}
			throw new AssertionException("ncc\\generation\\ILEmitter.n", 1894, (list.Head.Field0 == 0).ToString(), "");
		}
		n_closureOf_emit_switch_._N_reversed_labels_75458 = list<Label>.Nil._N_constant_object;
		list<Nemerle.Builtins.Tuple<Label, TExpr>> list2 = _N_make_labels_75486(n_closureOf_emit_switch_, 0, list);
		Label[] array = n_closureOf_emit_switch_._N_reversed_labels_75458.ToArray();
		Array.Reverse(array);
		_ilg.Emit(OpCodes.Switch, array);
		_ilg.MarkLabel(label);
		if (default_expr is option<TExpr>.Some)
		{
			TExpr val = ((option<TExpr>.Some)default_expr).val;
			emit(val);
			if (!val.Throws)
			{
				_ilg.Emit(OpCodes.Br, label2);
			}
		}
		else
		{
			if (default_expr != option<TExpr>.None._N_constant_object)
			{
				throw new MatchFailureException();
			}
			_ilg.Emit(OpCodes.Br, label2);
		}
		list2 = list2;
		while (list2 is list<Nemerle.Builtins.Tuple<Label, TExpr>>.Cons)
		{
			label = ((list<Nemerle.Builtins.Tuple<Label, TExpr>>.Cons)list2).hd.Field0;
			TExpr val = ((list<Nemerle.Builtins.Tuple<Label, TExpr>>.Cons)list2).hd.Field1;
			list2 = ((list<Nemerle.Builtins.Tuple<Label, TExpr>>.Cons)list2).tl;
			_ilg.MarkLabel(label);
			emit(val);
			if (!val.Throws)
			{
				_ilg.Emit(OpCodes.Br, label2);
			}
			list2 = list2;
		}
		if ((object)list2 != list<Nemerle.Builtins.Tuple<Label, TExpr>>.Nil._N_constant_object)
		{
			throw new MatchFailureException();
		}
		_ilg.MarkLabel(label2);
	}

	private void emit_ldarg(int index)
	{
		switch (index)
		{
		case 0:
			_ilg.Emit(OpCodes.Ldarg_0);
			return;
		case 1:
			_ilg.Emit(OpCodes.Ldarg_1);
			return;
		case 2:
			_ilg.Emit(OpCodes.Ldarg_2);
			return;
		case 3:
			_ilg.Emit(OpCodes.Ldarg_3);
			return;
		}
		if (index <= 255)
		{
			_ilg.Emit(OpCodes.Ldarg_S, checked((byte)index));
		}
		else
		{
			_ilg.Emit(OpCodes.Ldarg, index);
		}
	}

	private void store_argument(int index)
	{
		if (index < 256)
		{
			_ilg.Emit(OpCodes.Starg_S, checked((byte)index));
		}
		else
		{
			_ilg.Emit(OpCodes.Starg, index);
		}
	}

	private void emit_ldarga(int index)
	{
		if (index <= 255)
		{
			_ilg.Emit(OpCodes.Ldarga_S, checked((byte)index));
		}
		else
		{
			_ilg.Emit(OpCodes.Ldarga, index);
		}
	}

	private void emit_value_type_conversion(Location loc, FixedType l_t, FixedType r_t, bool is_checked)
	{
		TypeInfo typeInfo = null;
		TypeInfo typeInfo2 = null;
		_N_closureOf_emit_value_type_conversion_75570 n_closureOf_emit_value_type_conversion_ = new _N_closureOf_emit_value_type_conversion_75570();
		n_closureOf_emit_value_type_conversion_._N_loc_75579 = loc;
		n_closureOf_emit_value_type_conversion_._N_l_t_75577 = l_t;
		n_closureOf_emit_value_type_conversion_._N_r_t_75575 = r_t;
		if (n_closureOf_emit_value_type_conversion_._N_l_t_75577.Equals(n_closureOf_emit_value_type_conversion_._N_r_t_75575))
		{
			return;
		}
		typeInfo2 = n_closureOf_emit_value_type_conversion_._N_l_t_75577.TypeInfo;
		if (typeInfo2.IsEnum)
		{
			typeInfo2 = typeInfo2.UnderlyingType;
		}
		typeInfo = n_closureOf_emit_value_type_conversion_._N_r_t_75575.TypeInfo;
		if (typeInfo.IsEnum)
		{
			typeInfo = typeInfo.UnderlyingType;
		}
		if (typeInfo is LibraryReference.ExternalPrimitiveTypeInfo)
		{
			if (typeInfo2 is LibraryReference.ExternalPrimitiveTypeInfo && ((LibraryReference.ExternalPrimitiveTypeInfo)typeInfo2).CanOmmitConversionTo((LibraryReference.ExternalPrimitiveTypeInfo)typeInfo))
			{
				return;
			}
			LibraryReference.ExternalPrimitiveTypeInfo externalPrimitiveTypeInfo = (LibraryReference.ExternalPrimitiveTypeInfo)typeInfo;
			char c = typeInfo2.Name[0];
			bool flag = ((c == 'U' || c == 'B' || c == 'C') ? true : false);
			string name = externalPrimitiveTypeInfo.Name;
			OpCode obj;
			if (name == "Single")
			{
				obj = ((!flag) ? OpCodes.Conv_R4 : OpCodes.Conv_R_Un);
			}
			else if (name == "Double")
			{
				if (flag)
				{
					_ilg.Emit(OpCodes.Conv_R_Un);
					obj = OpCodes.Conv_R8;
				}
				else
				{
					obj = OpCodes.Conv_R8;
				}
			}
			else if (is_checked)
			{
				switch (name)
				{
				case "Int64":
					obj = ((!flag) ? OpCodes.Conv_Ovf_I8 : OpCodes.Conv_Ovf_I8_Un);
					break;
				case "Int32":
					obj = ((!flag) ? OpCodes.Conv_Ovf_I4 : OpCodes.Conv_Ovf_I4_Un);
					break;
				case "Int16":
					obj = ((!flag) ? OpCodes.Conv_Ovf_I2 : OpCodes.Conv_Ovf_I2_Un);
					break;
				case "SByte":
					obj = ((!flag) ? OpCodes.Conv_Ovf_I1 : OpCodes.Conv_Ovf_I1_Un);
					break;
				case "UInt64":
					obj = ((!flag) ? OpCodes.Conv_Ovf_U8 : OpCodes.Conv_Ovf_U8_Un);
					break;
				case "UInt32":
					obj = ((!flag) ? OpCodes.Conv_Ovf_U4 : OpCodes.Conv_Ovf_U4_Un);
					break;
				case "UInt16":
					obj = ((!flag) ? OpCodes.Conv_Ovf_U2 : OpCodes.Conv_Ovf_U2_Un);
					break;
				case "Boolean":
					obj = ((!flag) ? OpCodes.Conv_Ovf_U1 : OpCodes.Conv_Ovf_U1_Un);
					break;
				case "Byte":
					obj = ((!flag) ? OpCodes.Conv_Ovf_U1 : OpCodes.Conv_Ovf_U1_Un);
					break;
				case "Char":
					obj = ((!flag) ? OpCodes.Conv_Ovf_U2 : OpCodes.Conv_Ovf_U2_Un);
					break;
				default:
					_N_fail_75582(n_closureOf_emit_value_type_conversion_);
					obj = OpCodes.Nop;
					break;
				}
			}
			else
			{
				switch (name)
				{
				case "Int64":
					obj = ((!flag) ? OpCodes.Conv_I8 : OpCodes.Conv_U8);
					break;
				case "Int32":
					obj = OpCodes.Conv_I4;
					break;
				case "Int16":
					obj = OpCodes.Conv_I2;
					break;
				case "SByte":
					obj = OpCodes.Conv_I1;
					break;
				case "UInt64":
					obj = (flag ? OpCodes.Conv_U8 : OpCodes.Conv_I8);
					break;
				case "UInt32":
					obj = OpCodes.Conv_U4;
					break;
				case "UInt16":
					obj = OpCodes.Conv_U2;
					break;
				case "Byte":
					obj = OpCodes.Conv_U1;
					break;
				case "Boolean":
					obj = OpCodes.Conv_U1;
					break;
				case "Char":
					obj = OpCodes.Conv_U2;
					break;
				default:
					_N_fail_75582(n_closureOf_emit_value_type_conversion_);
					obj = OpCodes.Nop;
					break;
				}
			}
			OpCode opcode = obj;
			_ilg.Emit(opcode);
		}
		else if (typeInfo.Equals(InternalType.Decimal_tc))
		{
			string name = typeInfo2.Name;
			switch (name)
			{
			case "Int32":
			case "UInt32":
			case "Single":
			case "Int64":
			case "UInt64":
			case "Double":
				_ilg.Emit(OpCodes.Newobj, SystemTypeCache.Decimal_ctors.Get(name).UnSome());
				break;
			default:
				_N_fail_75582(n_closureOf_emit_value_type_conversion_);
				break;
			}
		}
		else
		{
			_N_fail_75582(n_closureOf_emit_value_type_conversion_);
		}
	}

	private void emit_method_call(TExpr expr, bool base_is_value_type_or_static, MethodInfo method, IMethod imethod = null, FixedType from = null)
	{
		if (expr.GenerateTail)
		{
			_ilg.Emit(OpCodes.Tailcall);
		}
		if (base_is_value_type_or_static)
		{
			_ilg.Emit(OpCodes.Call, method);
		}
		else
		{
			_ilg.Emit(OpCodes.Callvirt, method);
		}
		if (imethod != null)
		{
			emit_tuple_function_conversion(expr.FixedType(), from, imethod);
		}
		if (expr.GenerateTail)
		{
			_ilg.Emit(OpCodes.Ret);
		}
	}

	private bool emit_and_convert_to_address(TExpr base_object)
	{
		emit(base_object);
		Type systemType = base_object.GetSystemType();
		bool isValueType = systemType.IsValueType;
		if ((isValueType || systemType.IsGenericParameter) && !base_object.NeedAddress)
		{
			LocalBuilder local = _ilg.DeclareLocal(base_object.GetSystemType());
			_ilg.Emit(OpCodes.Stloc, local);
			_ilg.Emit(OpCodes.Ldloca, local);
		}
		return isValueType;
	}

	private LocalBuilder declare_val_local_slot(LocalValue val)
	{
		Type localType = ((!val.IsManagedPtr) ? val.Type.GetSystemType() : val.Type.GetSystemType().MakeByRefType());
		LocalBuilder localBuilder = _ilg.DeclareLocal(localType, val.IsPinned);
		if (IsDebugEnabled && val.Location.IsSourceAvailable)
		{
			localBuilder.SetLocalSymInfo(val.Name);
		}
		val.LocalSlot = localBuilder;
		return localBuilder;
	}

	private void declare_val_local_slot_ex(LocalValue val)
	{
		_N_closureOf_declare_val_local_slot_ex_75723 n_closureOf_declare_val_local_slot_ex_ = new _N_closureOf_declare_val_local_slot_ex_75723();
		n_closureOf_declare_val_local_slot_ex_._N_val_75730 = val;
		n_closureOf_declare_val_local_slot_ex_._N__N_closurised_this_ptr_75728 = this;
		if (n_closureOf_declare_val_local_slot_ex_._N_val_75730.PostponedDeclaration && IsDebugEnabled && n_closureOf_declare_val_local_slot_ex_._N_val_75730.Location.IsSourceAvailable)
		{
			FunctionVoid functionVoid2 = (n_closureOf_declare_val_local_slot_ex_._N_val_75730.Declare = new _N__N_lambda__75715__75741(n_closureOf_declare_val_local_slot_ex_));
		}
		else
		{
			LocalBuilder localBuilder = declare_val_local_slot(n_closureOf_declare_val_local_slot_ex_._N_val_75730);
		}
	}

	private LocalBuilder declare_expr_local_slot(TExpr expr)
	{
		Type localType = ((!expr.NeedAddress || !expr.IsAddressable) ? expr.GetSystemType() : expr.GetSystemType().MakeByRefType());
		return _ilg.DeclareLocal(localType);
	}

	private void emit_array_store_opcode(Type ty)
	{
		if (ty.IsGenericParameter)
		{
			_ilg.Emit(OpCodes.Stelem, ty);
		}
		else if (ty.IsPrimitive)
		{
			OpCode opCode;
			switch (ty.Name)
			{
			case "SByte":
			case "Boolean":
			case "Byte":
				opCode = OpCodes.Stelem_I1;
				break;
			case "Char":
			case "Int16":
			case "UInt16":
				opCode = OpCodes.Stelem_I2;
				break;
			case "Int32":
			case "UInt32":
				opCode = OpCodes.Stelem_I4;
				break;
			case "Int64":
			case "UInt64":
				opCode = OpCodes.Stelem_I8;
				break;
			case "Single":
				opCode = OpCodes.Stelem_R4;
				break;
			case "Double":
				opCode = OpCodes.Stelem_R8;
				break;
			case "IntPtr":
			case "UIntPtr":
				opCode = OpCodes.Stelem_I;
				break;
			default:
				if (!Message.SeenError)
				{
					string text = "System.Type IsPrimitive has lied".ToString();
					Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
				}
				throw new AssertionException("ncc\\generation\\ILEmitter.n", 2210, "", "System.Type IsPrimitive has lied");
			}
			OpCode opcode = opCode;
			_ilg.Emit(opcode);
		}
		else if (ty.IsValueType)
		{
			_ilg.Emit(OpCodes.Stobj, ty);
		}
		else
		{
			_ilg.Emit(OpCodes.Stelem_Ref);
		}
	}

	private void emit_value_to_ptr_conversion(TExpr expr, TypeVar target_type)
	{
		FixedType fixedType = expr.Type.Fix();
		if (fixedType is FixedType.Class)
		{
			if ((object)((FixedType.Class)fixedType).args == list<TypeVar>.Nil._N_constant_object)
			{
				if (fixedType.Equals(InternalType.IntPtr))
				{
					emit(expr);
					return;
				}
				if (fixedType.Equals(InternalType.String))
				{
					emit(expr);
					Label label = _ilg.DefineLabel();
					_ilg.Emit(OpCodes.Conv_I);
					_ilg.Emit(OpCodes.Dup);
					_ilg.Emit(OpCodes.Brfalse_S, label);
					_ilg.Emit(OpCodes.Call, SystemTypeCache.RuntimeHelpers_get_OffsetToStringData);
					_ilg.Emit(OpCodes.Add);
					_ilg.MarkLabel(label);
					return;
				}
			}
		}
		else if (fixedType is FixedType.Array && ((FixedType.Array)fixedType).rank == 1)
		{
			TypeVar t = ((FixedType.Array)fixedType).t;
			emit(expr);
			_ilg.Emit(OpCodes.Ldc_I4_0);
			_ilg.Emit(OpCodes.Ldelema, t.TypeInfo.SystemType);
			_ilg.Emit(OpCodes.Conv_I);
			return;
		}
		throw new AssertionException("ncc\\generation\\ILEmitter.n", 2250, "", "Unsupported pointer convertion.");
	}

	private static int get_elem_size(TypeVar ptr_type)
	{
		FixedType fixedType = ptr_type.Fix();
		option<TypeInfo> elementTypeInfo = fixedType.TypeInfo.GetElementTypeInfo();
		int size = elementTypeInfo.Value.Size;
		if (size <= 0)
		{
		}
		return size;
	}

	private void emit_index_multiplier(TypeVar ptr_type)
	{
		emit_index_multiplier(get_elem_size(ptr_type));
	}

	private void emit_index_multiplier(int size)
	{
		switch (size)
		{
		case 8:
			break;
		case 16:
			_ilg.Emit(OpCodes.Ldc_I4_2);
			break;
		case 32:
			_ilg.Emit(OpCodes.Ldc_I4_4);
			break;
		case 64:
			_ilg.Emit(OpCodes.Ldc_I4_8);
			break;
		default:
			throw new AssertionException("ncc\\generation\\ILEmitter.n", 2274, "", "");
		}
	}

	private void emit_ptr_indexing(bool needAddress, TExpr ptr, TExpr index)
	{
		TypeVar type = ptr.Type;
		if (!type.IsPointer)
		{
			throw new AssertionException("ncc\\generation\\ILEmitter.n", 2281, "type.IsPointer", "");
		}
		emit(ptr);
		int num = get_elem_size(type);
		checked
		{
			if (index is TExpr.Literal && ((TExpr.Literal)index).val is Literal.Integer)
			{
				if (((Literal.Integer)((TExpr.Literal)index).val).val != 0uL)
				{
					ulong val = ((Literal.Integer)((TExpr.Literal)index).val).val;
					bool is_negative = ((Literal.Integer)((TExpr.Literal)index).val).is_negative;
					FixedType.Class treat_as = ((Literal.Integer)((TExpr.Literal)index).val).treat_as;
					int x = unchecked(num / 8) * (int)val * ((!is_negative) ? 1 : (-1));
					_ilg.Emit(OpCodes.Conv_I);
					emit_i4(x);
					_ilg.Emit(OpCodes.Add);
				}
			}
			else
			{
				emit(index);
				_ilg.Emit(OpCodes.Conv_I);
				emit_index_multiplier(num);
				if (num > 8)
				{
					_ilg.Emit(OpCodes.Mul);
				}
				_ilg.Emit(OpCodes.Add);
			}
			if (!needAddress)
			{
				switch (num)
				{
				case 8:
					_ilg.Emit(OpCodes.Ldind_U1);
					break;
				case 16:
					_ilg.Emit(OpCodes.Ldind_U2);
					break;
				case 32:
					_ilg.Emit(OpCodes.Ldind_U4);
					break;
				case 64:
					_ilg.Emit(OpCodes.Ldind_I8);
					break;
				default:
					throw new AssertionException("ncc\\generation\\ILEmitter.n", 2314, "", "");
				}
			}
		}
	}

	private void emit_array_load_opcode(Type ty)
	{
		if (ty.IsGenericParameter)
		{
			_ilg.Emit(OpCodes.Ldelem, ty);
			return;
		}
		if (ty.IsValueType && !ty.IsPrimitive)
		{
			_ilg.Emit(OpCodes.Ldelema, ty);
			_ilg.Emit(OpCodes.Ldobj, ty);
			return;
		}
		OpCode opCode;
		if (ty.IsPrimitive)
		{
			switch (ty.Name)
			{
			case "SByte":
			case "Boolean":
				opCode = OpCodes.Ldelem_I1;
				break;
			case "Byte":
				opCode = OpCodes.Ldelem_U1;
				break;
			case "Char":
			case "Int16":
				opCode = OpCodes.Ldelem_I2;
				break;
			case "UInt16":
				opCode = OpCodes.Ldelem_U2;
				break;
			case "Int32":
				opCode = OpCodes.Ldelem_I4;
				break;
			case "UInt32":
				opCode = OpCodes.Ldelem_U4;
				break;
			case "Int64":
			case "UInt64":
				opCode = OpCodes.Ldelem_I8;
				break;
			case "Single":
				opCode = OpCodes.Ldelem_R4;
				break;
			case "Double":
				opCode = OpCodes.Ldelem_R8;
				break;
			case "IntPtr":
			case "UIntPtr":
				opCode = OpCodes.Ldelem_I;
				break;
			default:
				if (!Message.SeenError)
				{
					string text = "System.Type.IsPrimitive has lied".ToString();
					Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
				}
				throw new AssertionException("ncc\\generation\\ILEmitter.n", 2343, "", "System.Type.IsPrimitive has lied");
			}
		}
		else
		{
			opCode = OpCodes.Ldelem_Ref;
		}
		OpCode opcode = opCode;
		_ilg.Emit(opcode);
	}

	private void emit_ldind_for_value_type(Type ty)
	{
		if (!ty.IsPrimitive || ty.IsEnum)
		{
			_ilg.Emit(OpCodes.Ldobj, ty);
			return;
		}
		OpCode opCode;
		switch (ty.Name)
		{
		case "SByte":
		case "Boolean":
			opCode = OpCodes.Ldind_I1;
			break;
		case "Byte":
			opCode = OpCodes.Ldind_U1;
			break;
		case "Char":
		case "Int16":
			opCode = OpCodes.Ldind_I2;
			break;
		case "UInt16":
			opCode = OpCodes.Ldind_U2;
			break;
		case "Int32":
			opCode = OpCodes.Ldind_I4;
			break;
		case "UInt32":
			opCode = OpCodes.Ldind_U4;
			break;
		case "Int64":
			opCode = OpCodes.Ldind_I8;
			break;
		case "UInt64":
			opCode = OpCodes.Ldind_I8;
			break;
		case "Single":
			opCode = OpCodes.Ldind_R4;
			break;
		case "Double":
			opCode = OpCodes.Ldind_R8;
			break;
		case "IntPtr":
		case "UIntPtr":
			opCode = OpCodes.Ldind_I;
			break;
		default:
			if (!Message.SeenError)
			{
				string text = string.Concat(_method_name + ": not a recognized value type: ", ty.TypeFullName()).ToString();
				Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
			}
			throw new AssertionException("ncc\\generation\\ILEmitter.n", 2375, "", string.Concat(_method_name + ": not a recognized value type: ", ty.TypeFullName()).ToString());
		}
		OpCode opcode = opCode;
		_ilg.Emit(opcode);
	}

	private void emit_i4(int x)
	{
		switch (x)
		{
		case -1:
			_ilg.Emit(OpCodes.Ldc_I4_M1);
			return;
		case 0:
			_ilg.Emit(OpCodes.Ldc_I4_0);
			return;
		case 1:
			_ilg.Emit(OpCodes.Ldc_I4_1);
			return;
		case 2:
			_ilg.Emit(OpCodes.Ldc_I4_2);
			return;
		case 3:
			_ilg.Emit(OpCodes.Ldc_I4_3);
			return;
		case 4:
			_ilg.Emit(OpCodes.Ldc_I4_4);
			return;
		case 5:
			_ilg.Emit(OpCodes.Ldc_I4_5);
			return;
		case 6:
			_ilg.Emit(OpCodes.Ldc_I4_6);
			return;
		case 7:
			_ilg.Emit(OpCodes.Ldc_I4_7);
			return;
		case 8:
			_ilg.Emit(OpCodes.Ldc_I4_8);
			return;
		}
		if (x >= -128 && x <= 127)
		{
			_ilg.Emit(OpCodes.Ldc_I4_S, checked((sbyte)x));
		}
		else
		{
			_ilg.Emit(OpCodes.Ldc_I4, x);
		}
	}

	private void emit_literal(Literal l)
	{
		while (true)
		{
			if (l is Literal.Void)
			{
				return;
			}
			if (l is Literal.Null)
			{
				_ilg.Emit(OpCodes.Ldnull);
				return;
			}
			if (l is Literal.String)
			{
				string val = ((Literal.String)l).val;
				if (!(val != null))
				{
					throw new AssertionException("ncc\\generation\\ILEmitter.n", 2438, "s != null", "");
				}
				_ilg.Emit(OpCodes.Ldstr, val);
				return;
			}
			if (l is Literal.Float)
			{
				float val2 = ((Literal.Float)l).val;
				_ilg.Emit(OpCodes.Ldc_R4, val2);
				return;
			}
			if (l is Literal.Double)
			{
				double val3 = ((Literal.Double)l).val;
				_ilg.Emit(OpCodes.Ldc_R8, val3);
				return;
			}
			if (l is Literal.Decimal)
			{
				decimal val4 = ((Literal.Decimal)l).val;
				int[] bits = decimal.GetBits(val4);
				bool flag = bits[3] < 0;
				int num = (bits[3] >> 16) & 0xFF;
				if (bits[2] != 0 || (bits[1] < 0 && flag) || num != 0)
				{
					if (bits[0] != 0)
					{
						_ilg.Emit(OpCodes.Ldc_I4, bits[0]);
					}
					else
					{
						_ilg.Emit(OpCodes.Ldc_I4_0);
					}
					if (bits[1] != 0)
					{
						_ilg.Emit(OpCodes.Ldc_I4, bits[1]);
					}
					else
					{
						_ilg.Emit(OpCodes.Ldc_I4_0);
					}
					if (bits[2] != 0)
					{
						_ilg.Emit(OpCodes.Ldc_I4, bits[2]);
					}
					else
					{
						_ilg.Emit(OpCodes.Ldc_I4_0);
					}
					if (flag)
					{
						_ilg.Emit(OpCodes.Ldc_I4_1);
					}
					else
					{
						_ilg.Emit(OpCodes.Ldc_I4_0);
					}
					if (num != 0)
					{
						_ilg.Emit(OpCodes.Ldc_I4_S, num);
					}
					else
					{
						_ilg.Emit(OpCodes.Ldc_I4_0);
					}
					_ilg.Emit(OpCodes.Newobj, SystemTypeCache.Decimal_ctors.Get("Int32, Int32, Int32, Boolean, Byte").UnSome());
					return;
				}
				if (bits[1] != 0 || (bits[0] < 0 && flag))
				{
					long num2 = ((long)bits[1] << 32) | bits[0];
					if (flag)
					{
						if (num2 < 0)
						{
							throw new AssertionException("ncc\\generation\\ILEmitter.n", 2464, "val >= 0L", "");
						}
						_ilg.Emit(OpCodes.Ldc_I8, num2 | 0x800000000000000L);
						_ilg.Emit(OpCodes.Newobj, SystemTypeCache.Decimal_ctors.Get("Int64").UnSome());
					}
					else
					{
						_ilg.Emit(OpCodes.Ldc_I8, num2);
						_ilg.Emit(OpCodes.Newobj, SystemTypeCache.Decimal_ctors.Get("UInt64").UnSome());
					}
					return;
				}
				num = bits[0];
				if (flag)
				{
					if (num < 0)
					{
						throw new AssertionException("ncc\\generation\\ILEmitter.n", 2478, "val >= 0", "");
					}
					_ilg.Emit(OpCodes.Ldc_I4, num | int.MinValue);
					_ilg.Emit(OpCodes.Newobj, SystemTypeCache.Decimal_ctors.Get("Int32").UnSome());
				}
				else
				{
					_ilg.Emit(OpCodes.Ldc_I4, num);
					_ilg.Emit(OpCodes.Newobj, SystemTypeCache.Decimal_ctors.Get("UInt32").UnSome());
				}
				return;
			}
			if (l is Literal.Char)
			{
				char val5 = ((Literal.Char)l).val;
				emit_i4(val5);
				return;
			}
			if (l is Literal.Bool)
			{
				if (((Literal.Bool)l).val)
				{
					_ilg.Emit(OpCodes.Ldc_I4_1);
				}
				else
				{
					_ilg.Emit(OpCodes.Ldc_I4_0);
				}
				return;
			}
			if (l is Literal.Integer)
			{
				ulong val6 = ((Literal.Integer)l).val;
				bool flag = ((Literal.Integer)l).is_negative;
				FixedType.Class treat_as = ((Literal.Integer)l).treat_as;
				if (treat_as == null)
				{
					throw new AssertionException("ncc\\generation\\ILEmitter.n", 2410, "t != null", "");
				}
				if (treat_as.Equals(InternalType.UInt64))
				{
					if (flag)
					{
						throw new AssertionException("ncc\\generation\\ILEmitter.n", 2412, "!is_neg", "");
					}
					_ilg.Emit(OpCodes.Ldc_I8, (long)val6);
					_ilg.Emit(OpCodes.Conv_U8);
				}
				else if (treat_as.Equals(InternalType.Int64))
				{
					if (flag)
					{
						if (val6 == 9223372036854775808uL)
						{
							_ilg.Emit(OpCodes.Ldc_I8, long.MinValue);
						}
						else
						{
							_ilg.Emit(OpCodes.Ldc_I8, checked((long)val6 * -1L));
						}
					}
					else
					{
						_ilg.Emit(OpCodes.Ldc_I8, (long)val6);
					}
				}
				else if (treat_as.Equals(InternalType.UInt32))
				{
					if (flag)
					{
						throw new AssertionException("ncc\\generation\\ILEmitter.n", 2425, "!is_neg", "");
					}
					emit_i4((int)val6);
				}
				else if (val6 <= 2147483647uL)
				{
					emit_i4(checked((!flag) ? ((int)val6) : ((int)val6 * -1)));
				}
				else
				{
					if (val6 != 2147483648uL || !flag)
					{
						Message.Warning("cannot emit: " + Convert.ToString(l) + " : " + Convert.ToString(treat_as));
						throw new AssertionException("ncc\\generation\\ILEmitter.n", 2434, "", "");
					}
					emit_i4(int.MinValue);
				}
				return;
			}
			if (!(l is Literal.Enum))
			{
				break;
			}
			Literal.Integer val7 = ((Literal.Enum)l).val;
			l = val7;
		}
		throw new MatchFailureException();
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
			_method_builder?.RelocateImplInternal(_info);
			_parent_type_builder?.RelocateImplInternal(_info);
			_ilg?.RelocateImplInternal(_info);
		}
	}

	void ISupportRelocation.RelocateImpl(RelocationInfo _info)
	{
		//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
		this.RelocateImplInternal(_info);
	}

	private static TypeVar _N_interesting_part_73950(_N_closureOf_emit_tuple_function_conversion_73942 _N_emit_tuple_function_conversion_cp_73949, TypeVar t)
	{
		TypeVar result;
		if (_N_emit_tuple_function_conversion_cp_73949._N_member_73947 is IMethod)
		{
			FixedType fixedType = t.Fix();
			if (!(fixedType is FixedType.Fun))
			{
				if (!Message.SeenError)
				{
					string text = "(see backtrace)".ToString();
					Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
				}
				throw new AssertionException("ncc\\generation\\ILEmitter.n", 461, "", "(see backtrace)");
			}
			TypeVar to = ((FixedType.Fun)fixedType).to;
			result = to;
		}
		else
		{
			result = t;
		}
		return result;
	}

	private static bool _N_is_single_arg_function_73968(_N_closureOf_emit_tuple_function_conversion_73942 _N_emit_tuple_function_conversion_cp_73967, TypeVar t)
	{
		FixedType fixedType = _N_interesting_part_73950(_N_emit_tuple_function_conversion_cp_73967, t).Fix();
		int result;
		if (fixedType is FixedType.Fun)
		{
			TypeVar from = ((FixedType.Fun)fixedType).from;
			fixedType = from.Fix();
			result = ((!(fixedType is FixedType.Tuple)) ? 1 : 0);
		}
		else
		{
			result = 0;
		}
		return (byte)result != 0;
	}

	private void _N_emit_store_74508(_N_closureOf_emit_74401 _N_emit_cp_74507, LocalValue local_var, TExpr _N_wildcard_3353)
	{
		if (local_var.EverUsed)
		{
			store_local(local_var);
		}
		else
		{
			_ilg.Emit(OpCodes.Pop);
		}
	}

	private void _N_emit_debug_74564(_N_closureOf_emit_74401 _N_emit_cp_74563, Location loc)
	{
		if (IsDebugEnabled && loc.IsSourceAvailable)
		{
			emit_debug_info(new TExpr.DebugInfo(loc, null, null, null));
		}
	}

	private void _N_emit_branch_74577(_N_closureOf_emit_74401 _N_emit_cp_74576, TExpr expr, Label else_label, Location debug_loc)
	{
		_N_closureOf_emit_branch_74583 n_closureOf_emit_branch_;
		while (true)
		{
			n_closureOf_emit_branch_ = new _N_closureOf_emit_branch_74583();
			n_closureOf_emit_branch_._N_else_label_74590 = else_label;
			n_closureOf_emit_branch_._N_debug_loc_74588 = debug_loc;
			if (expr is TExpr.Call)
			{
				if (((TExpr.Call)expr).func is TExpr.OpCode)
				{
					if (((TExpr.OpCode)((TExpr.Call)expr).func).name == "==" && ((TExpr.Call)expr).parms is list<Parm>.Cons && ((list<Parm>.Cons)((TExpr.Call)expr).parms).tl is list<Parm>.Cons)
					{
						Parm hd = ((list<Parm>.Cons)((TExpr.Call)expr).parms).hd;
						if (((list<Parm>.Cons)((list<Parm>.Cons)((TExpr.Call)expr).parms).tl).hd.expr is TExpr.TypeConversion && ((TExpr.TypeConversion)((list<Parm>.Cons)((list<Parm>.Cons)((TExpr.Call)expr).parms).tl).hd.expr).expr is TExpr.Literal && ((TExpr.Literal)((TExpr.TypeConversion)((list<Parm>.Cons)((list<Parm>.Cons)((TExpr.Call)expr).parms).tl).hd.expr).expr).val is Literal.Bool && ((Literal.Bool)((TExpr.Literal)((TExpr.TypeConversion)((list<Parm>.Cons)((list<Parm>.Cons)((TExpr.Call)expr).parms).tl).hd.expr).expr).val).val && (object)((list<Parm>.Cons)((list<Parm>.Cons)((TExpr.Call)expr).parms).tl).tl == list<Parm>.Nil._N_constant_object)
						{
							TExpr expr2 = hd.expr;
							Label n_else_label_ = n_closureOf_emit_branch_._N_else_label_74590;
							debug_loc = Location.Default;
							else_label = n_else_label_;
							expr = expr2;
							continue;
						}
					}
					string name = ((TExpr.OpCode)((TExpr.Call)expr).func).name;
					list<Parm> parms = ((TExpr.Call)expr).parms;
					emit_parms(parms);
					Nemerle.Builtins.Tuple<OpCode, OpCode> tuple;
					switch (name)
					{
					case "==.ref":
					case "==":
						tuple = new Nemerle.Builtins.Tuple<OpCode, OpCode>(OpCodes.Bne_Un, OpCodes.Beq);
						break;
					case "!=.ref":
					case "!=":
						tuple = new Nemerle.Builtins.Tuple<OpCode, OpCode>(OpCodes.Beq, OpCodes.Bne_Un);
						break;
					case "<.s":
					case "<.f":
						tuple = new Nemerle.Builtins.Tuple<OpCode, OpCode>(OpCodes.Bge, OpCodes.Blt);
						break;
					case "<.u":
						tuple = new Nemerle.Builtins.Tuple<OpCode, OpCode>(OpCodes.Bge_Un, OpCodes.Blt_Un);
						break;
					case ">.s":
					case ">.f":
						tuple = new Nemerle.Builtins.Tuple<OpCode, OpCode>(OpCodes.Ble, OpCodes.Bgt);
						break;
					case ">.u":
						tuple = new Nemerle.Builtins.Tuple<OpCode, OpCode>(OpCodes.Ble_Un, OpCodes.Bgt_Un);
						break;
					case "<=.s":
					case "<=.f":
						tuple = new Nemerle.Builtins.Tuple<OpCode, OpCode>(OpCodes.Bgt, OpCodes.Ble);
						break;
					case "<=.u":
						tuple = new Nemerle.Builtins.Tuple<OpCode, OpCode>(OpCodes.Bgt_Un, OpCodes.Ble_Un);
						break;
					case ">=.s":
					case ">=.f":
						tuple = new Nemerle.Builtins.Tuple<OpCode, OpCode>(OpCodes.Blt, OpCodes.Bge);
						break;
					case ">=.u":
						tuple = new Nemerle.Builtins.Tuple<OpCode, OpCode>(OpCodes.Blt_Un, OpCodes.Bge_Un);
						break;
					case "bool.!":
						tuple = new Nemerle.Builtins.Tuple<OpCode, OpCode>(OpCodes.Brtrue, OpCodes.Brfalse);
						break;
					default:
						if (!Message.SeenError)
						{
							string text = string.Concat("invalid opcode '" + name, "' in optimized TExpr.If pattern").ToString();
							Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
						}
						throw new AssertionException("ncc\\generation\\ILEmitter.n", 621, "", string.Concat("invalid opcode '" + name, "' in optimized TExpr.If pattern").ToString());
					}
					Nemerle.Builtins.Tuple<OpCode, OpCode> tuple2 = tuple;
					_N_emit_br_74594(n_closureOf_emit_branch_, _N_emit_cp_74576, tuple2.Field0, tuple2.Field1);
					return;
				}
				if (is_always_true(expr))
				{
					return;
				}
				if (!is_always_false(expr))
				{
					break;
				}
			}
			else
			{
				if (expr is TExpr.If)
				{
					TExpr cond = ((TExpr.If)expr).cond;
					TExpr e_then = ((TExpr.If)expr).e_then;
					TExpr e_else = ((TExpr.If)expr).e_else;
					Label label = _ilg.DefineLabel();
					Label label2 = _ilg.DefineLabel();
					_N_emit_branch_74577(_N_emit_cp_74576, cond, label, Location.Default);
					_N_emit_branch_74577(_N_emit_cp_74576, e_then, n_closureOf_emit_branch_._N_else_label_74590, Location.Default);
					if (!e_then.Throws)
					{
						_ilg.Emit(OpCodes.Br, label2);
					}
					_ilg.MarkLabel(label);
					_N_emit_branch_74577(_N_emit_cp_74576, e_else, n_closureOf_emit_branch_._N_else_label_74590, Location.Default);
					_ilg.MarkLabel(label2);
					return;
				}
				if (expr is TExpr.HasType)
				{
					TExpr e_then = ((TExpr.HasType)expr).expr;
					FixedType test_ty = ((TExpr.HasType)expr).test_ty;
					emit(e_then);
					need_reference(e_then.GetSystemType());
					_ilg.Emit(OpCodes.Isinst, test_ty.GetSystemType());
					_N_emit_br_74594(n_closureOf_emit_branch_, _N_emit_cp_74576, OpCodes.Brfalse, OpCodes.Brtrue);
					return;
				}
				if (is_always_true(expr))
				{
					return;
				}
				if (!is_always_false(expr))
				{
					break;
				}
			}
			_ilg.Emit(OpCodes.Br, n_closureOf_emit_branch_._N_else_label_74590);
			return;
		}
		emit(expr);
		if (!expr.Throws)
		{
			_N_emit_br_74594(n_closureOf_emit_branch_, _N_emit_cp_74576, OpCodes.Brfalse, OpCodes.Brtrue);
		}
	}

	private void _N_emit_br_74594(_N_closureOf_emit_branch_74583 _N_emit_branch_cp_74592, _N_closureOf_emit_74401 _N_emit_cp_74593, OpCode opcode1, OpCode opcode2)
	{
		if (!IsDebugEnabled || !_N_emit_branch_cp_74592._N_debug_loc_74588.IsSourceAvailable)
		{
			_ilg.Emit(opcode1, _N_emit_branch_cp_74592._N_else_label_74590);
			return;
		}
		Label label = _ilg.DefineLabel();
		_ilg.Emit(opcode2, label);
		_N_emit_debug_74564(_N_emit_cp_74593, _N_emit_branch_cp_74592._N_debug_loc_74588);
		_ilg.Emit(OpCodes.Br, _N_emit_branch_cp_74592._N_else_label_74590);
		_ilg.MarkLabel(label);
	}

	private void _N_walk_case_74922(_N_closureOf_emit_74401 _N_emit_cp_74921, Try_case @case)
	{
		if (@case is Try_case.Fault)
		{
			TExpr handler = ((Try_case.Fault)@case).handler;
			_ilg.BeginFaultBlock();
			emit(handler);
			return;
		}
		if (@case is Try_case.Catch)
		{
			LocalValue exn = ((Try_case.Catch)@case).exn;
			TExpr handler = ((Try_case.Catch)@case).handler;
			_ilg.BeginCatchBlock(exn.Type.GetSystemType());
			LocalBuilder local = declare_val_local_slot(exn);
			_ilg.Emit(OpCodes.Stloc, local);
			emit(handler);
			if (!handler.Throws && !_N_emit_cp_74921._N_ignore_try_result_74408)
			{
				_ilg.Emit(OpCodes.Stloc, _N_emit_cp_74921._N_try_result_74406);
			}
			return;
		}
		if (@case is Try_case.Filter)
		{
			LocalValue exn = ((Try_case.Filter)@case).exn;
			TExpr filter = ((Try_case.Filter)@case).filter;
			TExpr handler = ((Try_case.Filter)@case).handler;
			Label label = _ilg.DefineLabel();
			Label label2 = _ilg.DefineLabel();
			_ilg.BeginExceptFilterBlock();
			_ilg.Emit(OpCodes.Isinst, exn.Type.GetSystemType());
			_ilg.Emit(OpCodes.Dup);
			_ilg.Emit(OpCodes.Brfalse, label);
			LocalBuilder local = declare_val_local_slot(exn);
			_ilg.Emit(OpCodes.Stloc, local);
			emit(filter);
			_ilg.Emit(OpCodes.Br, label2);
			_ilg.MarkLabel(label);
			_ilg.Emit(OpCodes.Pop);
			_ilg.Emit(OpCodes.Ldc_I4_0);
			_ilg.MarkLabel(label2);
			_ilg.BeginCatchBlock(null);
			_ilg.Emit(OpCodes.Pop);
			emit(handler);
			if (!handler.Throws && !_N_emit_cp_74921._N_ignore_try_result_74408)
			{
				_ilg.Emit(OpCodes.Stloc, _N_emit_cp_74921._N_try_result_74406);
			}
			return;
		}
		throw new MatchFailureException();
	}

	private void _N_emit_debug_75316(_N_closureOf_emit_debug_info_75300 _N_emit_debug_info_cp_75315, ISymbolDocumentWriter doc, int line, int col, int eline, int ecol)
	{
		_ilg.MarkSequencePoint(doc, line, col, eline, ecol);
	}

	private list<Nemerle.Builtins.Tuple<Label, TExpr>> _N_make_labels_75486(_N_closureOf_emit_switch_75453 _N_emit_switch_cp_75485, int index, list<Nemerle.Builtins.Tuple<int, TExpr>> cases)
	{
		checked
		{
			object result;
			while (true)
			{
				if (index < 0)
				{
					if (!Message.SeenError)
					{
						Message.Debug("Internal compiler error, please report a bug to bugs.nemerle.org. You can try modifying program near this location.");
					}
					throw new AssertionException("ncc\\generation\\ILEmitter.n", 1901, (index >= 0).ToString(), "");
				}
				if (cases is list<Nemerle.Builtins.Tuple<int, TExpr>>.Cons)
				{
					int field = ((list<Nemerle.Builtins.Tuple<int, TExpr>>.Cons)cases).hd.Field0;
					TExpr field2 = ((list<Nemerle.Builtins.Tuple<int, TExpr>>.Cons)cases).hd.Field1;
					list<Nemerle.Builtins.Tuple<int, TExpr>> cases2 = ((list<Nemerle.Builtins.Tuple<int, TExpr>>.Cons)cases).tl;
					if (index > field)
					{
						if (!Message.SeenError)
						{
							Message.Debug("Internal compiler error, please report a bug to bugs.nemerle.org. You can try modifying program near this location.");
						}
						throw new AssertionException("ncc\\generation\\ILEmitter.n", 1904, (index <= field).ToString(), "");
					}
					if (field == index)
					{
						Label label = _ilg.DefineLabel();
						_N_emit_switch_cp_75485._N_reversed_labels_75458 = new list<Label>.Cons(label, _N_emit_switch_cp_75485._N_reversed_labels_75458);
						result = new list<Nemerle.Builtins.Tuple<Label, TExpr>>.Cons(new Nemerle.Builtins.Tuple<Label, TExpr>(label, field2), _N_make_labels_75486(_N_emit_switch_cp_75485, index + 1, cases2));
						break;
					}
					_N_emit_switch_cp_75485._N_reversed_labels_75458 = new list<Label>.Cons(_N_emit_switch_cp_75485._N_default_jump_target_75460, _N_emit_switch_cp_75485._N_reversed_labels_75458);
					int num = index + 1;
					cases = cases;
					index = num;
					continue;
				}
				if ((object)cases == list<Nemerle.Builtins.Tuple<int, TExpr>>.Nil._N_constant_object)
				{
					result = list<Nemerle.Builtins.Tuple<Label, TExpr>>.Nil._N_constant_object;
					break;
				}
				throw new MatchFailureException();
			}
			return (list<Nemerle.Builtins.Tuple<Label, TExpr>>)result;
		}
	}

	private static void _N_fail_75582(_N_closureOf_emit_value_type_conversion_75570 _N_emit_value_type_conversion_cp_75581)
	{
		Message.Warning(_N_emit_value_type_conversion_cp_75581._N_loc_75579, "failed to emit value type conversion from " + Convert.ToString(_N_emit_value_type_conversion_cp_75581._N_l_t_75577) + " to " + Convert.ToString(_N_emit_value_type_conversion_cp_75581._N_r_t_75575));
	}
}
