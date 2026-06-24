using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Collections;
using Nemerle.Compiler.Parsetree;
using Nemerle.Compiler.Typedtree;
using Nemerle.Core;
using Nemerle.Internal;

namespace Nemerle.Compiler;

public class LocalValue : TypedBase, IComparable<LocalValue>, IEquatable<LocalValue>
{
	[Variant("Nemerle.Compiler.LocalValue.ILKind.None,Nemerle.Compiler.LocalValue.ILKind.Parm,Nemerle.Compiler.LocalValue.ILKind.ByRefParm,Nemerle.Compiler.LocalValue.ILKind.Local")]
	private abstract class ILKind : ISupportRelocation
	{
		[ConstantVariantOption]
		public class None : ILKind
		{
			public static readonly None _N_constant_object;

			[SpecialName]
			public static None _N_constant_object_generator()
			{
				return _N_constant_object;
			}

			static None()
			{
				_N_constant_object = new None();
			}

			[SpecialName]
			public override int _N_GetVariantCode()
			{
				return 0;
			}

			[RecordCtor]
			private None()
			{
			}
		}

		[VariantOption]
		public class Parm : ILKind
		{
			public readonly int slot;

			[SpecialName]
			public override int _N_GetVariantCode()
			{
				return 1;
			}

			[RecordCtor]
			public Parm([MappedMember("slot")] int slot)
			{
				this.slot = slot;
			}
		}

		[VariantOption]
		public class ByRefParm : ILKind
		{
			public readonly int slot;

			[SpecialName]
			public override int _N_GetVariantCode()
			{
				return 2;
			}

			[RecordCtor]
			public ByRefParm([MappedMember("slot")] int slot)
			{
				this.slot = slot;
			}
		}

		[VariantOption]
		public class Local : ILKind
		{
			public readonly LocalBuilder builder;

			[SpecialName]
			public override int _N_GetVariantCode()
			{
				return 3;
			}

			[RecordCtor]
			public Local([MappedMember("builder")] LocalBuilder builder)
			{
				this.builder = builder;
			}
		}

		[SpecialName]
		public abstract override int _N_GetVariantCode();

		[SpecialName]
		public static int _N_GetVariantCodeSafe(ILKind x)
		{
			return ((object)x != null) ? x._N_GetVariantCode() : (-1);
		}

		[SpecialName]
		public static int _N_GetVariantCodeObject(object x)
		{
			return (!(x is ILKind)) ? (-1) : ((ILKind)x)._N_GetVariantCode();
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

	[Variant("Nemerle.Compiler.LocalValue.Kind.Plain,Nemerle.Compiler.LocalValue.Kind.Function,Nemerle.Compiler.LocalValue.Kind.FunParm,Nemerle.Compiler.LocalValue.Kind.ExceptionValue,Nemerle.Compiler.LocalValue.Kind.PatternVariable,Nemerle.Compiler.LocalValue.Kind.BlockReturn,Nemerle.Compiler.LocalValue.Kind.ClosurisedThisPointer,Nemerle.Compiler.LocalValue.Kind.MacroRedirection")]
	public abstract class Kind : ISupportRelocation
	{
		[ConstantVariantOption]
		public class Plain : Kind
		{
			public static readonly Plain _N_constant_object;

			[SpecialName]
			public static Plain _N_constant_object_generator()
			{
				return _N_constant_object;
			}

			static Plain()
			{
				_N_constant_object = new Plain();
			}

			[SpecialName]
			public override int _N_GetVariantCode()
			{
				return 0;
			}

			[RecordCtor]
			private Plain()
			{
			}
		}

		[VariantOption]
		public class Function : Kind
		{
			public readonly TFunHeader header;

			public readonly list<TFunHeader> uses_closure_of;

			[SpecialName]
			public override int _N_GetVariantCode()
			{
				return 1;
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
				list<TFunHeader> list = uses_closure_of;
				if (list != null)
				{
					list = list;
					while (list is list<TFunHeader>.Cons)
					{
						TFunHeader hd = ((list<TFunHeader>.Cons)list).hd;
						list = ((list<TFunHeader>.Cons)list).tl;
						((ISupportRelocation)hd).RelocateImpl(_info);
						list = list;
					}
				}
				header?.RelocateImplInternal(_info);
			}

			[RecordCtor]
			public Function([MappedMember("header")] TFunHeader header, [MappedMember("uses_closure_of")] list<TFunHeader> uses_closure_of)
			{
				this.header = header;
				this.uses_closure_of = uses_closure_of;
			}
		}

		[VariantOption]
		public class FunParm : Kind
		{
			public readonly ParmKind kind;

			[SpecialName]
			public override int _N_GetVariantCode()
			{
				return 2;
			}

			[RecordCtor]
			public FunParm([MappedMember("kind")] ParmKind kind)
			{
				this.kind = kind;
			}
		}

		[ConstantVariantOption]
		public class ExceptionValue : Kind
		{
			public static readonly ExceptionValue _N_constant_object;

			[SpecialName]
			public static ExceptionValue _N_constant_object_generator()
			{
				return _N_constant_object;
			}

			static ExceptionValue()
			{
				_N_constant_object = new ExceptionValue();
			}

			[SpecialName]
			public override int _N_GetVariantCode()
			{
				return 3;
			}

			[RecordCtor]
			private ExceptionValue()
			{
			}
		}

		[VariantOption]
		public class PatternVariable : Kind
		{
			public bool used_in_body;

			[SpecialName]
			public override int _N_GetVariantCode()
			{
				return 4;
			}

			[RecordCtor]
			public PatternVariable([MappedMember("used_in_body")] bool used_in_body)
			{
				this.used_in_body = used_in_body;
			}
		}

		[VariantOption]
		public class BlockReturn : Kind
		{
			public LocalValue result_val;

			public int block_label;

			[SpecialName]
			public override int _N_GetVariantCode()
			{
				return 5;
			}

			[CompilerGenerated]
			internal override void RelocateImplInternal(RelocationInfo _info)
			{
				if (!_info.VisitedObjects.ContainsKey(this))
				{
					base.RelocateImplInternal(_info);
					_info.VisitedObjects[this] = 0;
					result_val?.RelocateImplInternal(_info);
				}
			}

			[RecordCtor]
			public BlockReturn([MappedMember("result_val")] LocalValue result_val, [MappedMember("block_label")] int block_label)
			{
				this.result_val = result_val;
				this.block_label = block_label;
			}
		}

		[ConstantVariantOption]
		public class ClosurisedThisPointer : Kind
		{
			public static readonly ClosurisedThisPointer _N_constant_object;

			[SpecialName]
			public static ClosurisedThisPointer _N_constant_object_generator()
			{
				return _N_constant_object;
			}

			static ClosurisedThisPointer()
			{
				_N_constant_object = new ClosurisedThisPointer();
			}

			[SpecialName]
			public override int _N_GetVariantCode()
			{
				return 6;
			}

			[RecordCtor]
			private ClosurisedThisPointer()
			{
			}
		}

		[VariantOption]
		public class MacroRedirection : Kind
		{
			public readonly PExpr subst;

			[SpecialName]
			public override int _N_GetVariantCode()
			{
				return 7;
			}

			[CompilerGenerated]
			internal override void RelocateImplInternal(RelocationInfo _info)
			{
				if (!_info.VisitedObjects.ContainsKey(this))
				{
					base.RelocateImplInternal(_info);
					_info.VisitedObjects[this] = 0;
					subst?.RelocateImplInternal(_info);
				}
			}

			[RecordCtor]
			public MacroRedirection([MappedMember("subst")] PExpr subst)
			{
				this.subst = subst;
			}
		}

		public override string ToString()
		{
			object result;
			if (this == Plain._N_constant_object)
			{
				result = "a local value";
			}
			else if (this is Function)
			{
				result = "a local function";
			}
			else if (this is FunParm)
			{
				result = "a function parameter";
			}
			else if (this == ExceptionValue._N_constant_object)
			{
				result = "a caught exception";
			}
			else if (this is PatternVariable)
			{
				result = "a value bound in pattern";
			}
			else if (this is BlockReturn)
			{
				result = "a return from a block";
			}
			else if (this == ClosurisedThisPointer._N_constant_object)
			{
				result = "a `this' pointer";
			}
			else
			{
				if (!(this is MacroRedirection))
				{
					throw new MatchFailureException();
				}
				result = "a macro invocation";
			}
			return (string)result;
		}

		[SpecialName]
		public abstract override int _N_GetVariantCode();

		[SpecialName]
		public static int _N_GetVariantCodeSafe(Kind x)
		{
			return ((object)x != null) ? x._N_GetVariantCode() : (-1);
		}

		[SpecialName]
		public static int _N_GetVariantCodeObject(object x)
		{
			return (!(x is Kind)) ? (-1) : ((Kind)x)._N_GetVariantCode();
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

	private TypeVar ty;

	private bool is_registered;

	private IField closure_field;

	internal readonly Kind kind;

	private readonly int id;

	private readonly string name;

	private readonly bool is_mutable;

	private readonly TFunHeader defined_in;

	internal Location name_location;

	private Set<TFunHeader> used_in;

	private bool in_closure;

	private bool ever_used;

	private bool is_cache;

	private bool is_managed_ptr;

	private bool never_closurise;

	private bool postponed_declaration;

	private FunctionVoid declare;

	private bool expanded_block_return;

	private IDictionary _N_field__userData_embeded_in_UserData_3417;

	private ILKind ilkind;

	public Kind ValueKind => kind;

	public int Id => id;

	public bool IsPinned { get; set; }

	public bool CanInline => !IsPinned && !is_managed_ptr && !is_cache;

	public IDictionary UserData
	{
		get
		{
			if (_N_field__userData_embeded_in_UserData_3417 == null)
			{
				_N_field__userData_embeded_in_UserData_3417 = new ListDictionary();
			}
			return _N_field__userData_embeded_in_UserData_3417;
		}
	}

	public TypeVar Type => ty;

	public Kind ValKind => kind;

	internal bool UsedInPatternBody
	{
		get
		{
			Kind kind = this.kind;
			if (kind is Kind.PatternVariable)
			{
				return ((Kind.PatternVariable)kind).used_in_body;
			}
			throw new AssertionException("ncc\\typing\\LocalValue.n", 158, "", "");
		}
		set
		{
			((Kind.PatternVariable)kind).used_in_body = value;
		}
	}

	internal bool IsRegistered => is_registered;

	internal IField ClosureField
	{
		get
		{
			return closure_field;
		}
		set
		{
			if (closure_field != null)
			{
				throw new AssertionException("ncc\\typing\\LocalValue.n", 189, "closure_field == null", "");
			}
			closure_field = value;
		}
	}

	internal bool IsByRefParm
	{
		get
		{
			CheckIL();
			ILKind iLKind = ilkind;
			return iLKind is ILKind.ByRefParm;
		}
	}

	internal bool IsParm
	{
		get
		{
			CheckIL();
			ILKind iLKind = ilkind;
			if (iLKind == ILKind.None._N_constant_object)
			{
				if (!Message.SeenError)
				{
					string text = "(see backtrace)".ToString();
					Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
				}
				throw new AssertionException("ncc\\typing\\LocalValue.n", 238, "", "(see backtrace)");
			}
			int result;
			if (iLKind is ILKind.Parm || iLKind is ILKind.ByRefParm)
			{
				result = 1;
			}
			else
			{
				if (!(iLKind is ILKind.Local))
				{
					throw new MatchFailureException();
				}
				result = 0;
			}
			return (byte)result != 0;
		}
	}

	internal LocalBuilder LocalSlot
	{
		get
		{
			CheckIL();
			ILKind iLKind = ilkind;
			if (iLKind is ILKind.Local)
			{
				return ((ILKind.Local)iLKind).builder;
			}
			if (!Message.SeenError)
			{
				string text = "(see backtrace)".ToString();
				Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
			}
			throw new AssertionException("ncc\\typing\\LocalValue.n", 252, "", "(see backtrace)");
		}
		set
		{
			ILKind iLKind = ilkind;
			if (!(iLKind is ILKind.None) && 1 == 0)
			{
				throw new AssertionException("ncc\\typing\\LocalValue.n", 259, "true", "");
			}
			iLKind = ilkind;
			if (!(iLKind is ILKind.None))
			{
				if (!Message.SeenError)
				{
					Message.Debug("Internal compiler error, please report a bug to bugs.nemerle.org. You can try modifying program near this location.");
				}
				iLKind = ilkind;
				throw new AssertionException("ncc\\typing\\LocalValue.n", 261, (iLKind is ILKind.None).ToString(), "");
			}
			ilkind = new ILKind.Local(value);
		}
	}

	internal int ParmIndex
	{
		get
		{
			CheckIL();
			ILKind iLKind = ilkind;
			if (iLKind is ILKind.Parm)
			{
				return ((ILKind.Parm)iLKind).slot;
			}
			if (iLKind is ILKind.ByRefParm)
			{
				return ((ILKind.ByRefParm)iLKind).slot;
			}
			if (!Message.SeenError)
			{
				string text = "(see backtrace)".ToString();
				Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
			}
			throw new AssertionException("ncc\\typing\\LocalValue.n", 273, "", "(see backtrace)");
		}
	}

	public string Name
	{
		[CompilerGenerated]
		[DebuggerStepThrough]
		get
		{
			return name;
		}
	}

	public bool IsMutable
	{
		[CompilerGenerated]
		[DebuggerStepThrough]
		get
		{
			return is_mutable;
		}
	}

	public TFunHeader DefinedIn
	{
		[CompilerGenerated]
		[DebuggerStepThrough]
		get
		{
			return defined_in;
		}
	}

	public Location NameLocation
	{
		[CompilerGenerated]
		[DebuggerStepThrough]
		get
		{
			return name_location;
		}
	}

	public Set<TFunHeader> UsedIn
	{
		[DebuggerStepThrough]
		[CompilerGenerated]
		get
		{
			return used_in;
		}
	}

	public bool InClosure
	{
		[DebuggerStepThrough]
		[CompilerGenerated]
		get
		{
			return in_closure;
		}
		[CompilerGenerated]
		[DebuggerStepThrough]
		set
		{
			in_closure = value;
		}
	}

	public bool EverUsed
	{
		[CompilerGenerated]
		[DebuggerStepThrough]
		get
		{
			return ever_used;
		}
		[CompilerGenerated]
		[DebuggerStepThrough]
		set
		{
			ever_used = value;
		}
	}

	public bool IsCache
	{
		[DebuggerStepThrough]
		[CompilerGenerated]
		get
		{
			return is_cache;
		}
		[DebuggerStepThrough]
		[CompilerGenerated]
		set
		{
			is_cache = value;
		}
	}

	public bool IsManagedPtr
	{
		[CompilerGenerated]
		[DebuggerStepThrough]
		get
		{
			return is_managed_ptr;
		}
		[CompilerGenerated]
		[DebuggerStepThrough]
		set
		{
			is_managed_ptr = value;
		}
	}

	internal bool NeverClosurise
	{
		[DebuggerStepThrough]
		[CompilerGenerated]
		get
		{
			return never_closurise;
		}
		[CompilerGenerated]
		[DebuggerStepThrough]
		set
		{
			never_closurise = value;
		}
	}

	internal bool PostponedDeclaration
	{
		[DebuggerStepThrough]
		[CompilerGenerated]
		get
		{
			return postponed_declaration;
		}
		[DebuggerStepThrough]
		[CompilerGenerated]
		set
		{
			postponed_declaration = value;
		}
	}

	internal FunctionVoid Declare
	{
		[CompilerGenerated]
		[DebuggerStepThrough]
		get
		{
			return declare;
		}
		[DebuggerStepThrough]
		[CompilerGenerated]
		set
		{
			declare = value;
		}
	}

	public bool ExpandedBlockReturn
	{
		[CompilerGenerated]
		[DebuggerStepThrough]
		get
		{
			return expanded_block_return;
		}
		[CompilerGenerated]
		[DebuggerStepThrough]
		set
		{
			expanded_block_return = value;
		}
	}

	public LocalValue(TFunHeader defined_in, string name, TypeVar ty, Kind kind, bool is_mutable)
		: this(defined_in, name, Location.Default, ty, kind, is_mutable)
	{
	}

	public LocalValue(TFunHeader defined_in, string name, Location name_location, TypeVar ty, Kind kind, bool is_mutable)
	{
		if (name_location.IsEmpty)
		{
			ilkind = ILKind.None._N_constant_object;
			base._002Ector();
		}
		else
		{
			ilkind = ILKind.None._N_constant_object;
			base._002Ector(name_location);
		}
		this.defined_in = defined_in;
		this.name = name;
		this.name_location = name_location;
		this.ty = ty;
		this.kind = kind;
		this.is_mutable = is_mutable;
		id = defined_in.ReturnType.Manager.GetNewId();
		used_in = new Set<TFunHeader>();
	}

	public bool Equals(LocalValue other)
	{
		return id == other.id;
	}

	public override int GetHashCode()
	{
		return id;
	}

	internal void UseFrom(TFunHeader fh)
	{
		ever_used = true;
		used_in = used_in.Replace(fh);
	}

	public override string ToString()
	{
		return Convert.ToString(kind) + " " + Convert.ToString(Name);
	}

	public int CompareTo(LocalValue other)
	{
		return checked(id - other.id);
	}

	public void Register()
	{
		if (IsRegistered)
		{
			if (!Message.SeenError)
			{
				Message.Debug("Internal compiler error, please report a bug to bugs.nemerle.org. You can try modifying program near this location.");
			}
			throw new AssertionException("ncc\\typing\\LocalValue.n", 173, (!IsRegistered).ToString(), ToString());
		}
		is_registered = true;
		DefinedIn.all_locals = new list<LocalValue>.Cons(this, DefinedIn.all_locals);
		Kind valKind = ValKind;
		if (valKind is Kind.Function)
		{
			TFunHeader header = ((Kind.Function)valKind).header;
			list<TFunHeader> list = ((Kind.Function)valKind).uses_closure_of;
			list = list;
			while (list is list<TFunHeader>.Cons)
			{
				TFunHeader hd = ((list<TFunHeader>.Cons)list).hd;
				list = ((list<TFunHeader>.Cons)list).tl;
				hd = hd;
				hd.children_funs = new list<TFunHeader>.Cons(header, hd.children_funs);
				list = list;
			}
		}
	}

	internal void SetType(TypeVar t)
	{
		ty = t;
	}

	private void CheckIL()
	{
		if (postponed_declaration)
		{
			postponed_declaration = false;
			if (declare != null)
			{
				declare.apply_void();
			}
		}
		ILKind iLKind = ilkind;
		if (iLKind is ILKind.None)
		{
		}
		iLKind = ilkind;
		if (iLKind is ILKind.None)
		{
			if (!Message.SeenError)
			{
				Message.Debug("Internal compiler error, please report a bug to bugs.nemerle.org. You can try modifying program near this location.");
			}
			iLKind = ilkind;
			throw new AssertionException("ncc\\typing\\LocalValue.n", 219, (!(iLKind is ILKind.None)).ToString(), "ilkind is none for " + Convert.ToString(this) + " (id=" + Convert.ToString(id) + ")");
		}
	}

	internal void SetParmIndex(int idx, bool is_by_ref)
	{
		ILKind iLKind = ilkind;
		if (!(iLKind is ILKind.None))
		{
			if (!Message.SeenError)
			{
				Message.Debug("Internal compiler error, please report a bug to bugs.nemerle.org. You can try modifying program near this location.");
			}
			iLKind = ilkind;
			throw new AssertionException("ncc\\typing\\LocalValue.n", 280, (iLKind is ILKind.None).ToString(), "");
		}
		ilkind = ((!is_by_ref) ? ((ILKind)new ILKind.Parm(idx)) : ((ILKind)new ILKind.ByRefParm(idx)));
	}

	public override bool Equals(object other)
	{
		return other == this || (other is LocalValue && Equals((LocalValue)other));
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
		ilkind?.RelocateImplInternal(_info);
		Set<TFunHeader> set = used_in;
		if (set != null)
		{
			IEnumerator<TFunHeader> enumerator = set.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					TFunHeader current = enumerator.Current;
					TFunHeader tFunHeader = current;
					((ISupportRelocation)tFunHeader).RelocateImpl(_info);
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
		}
		name_location = Completion.Relocate(name_location, _info);
		defined_in?.RelocateImplInternal(_info);
		kind?.RelocateImplInternal(_info);
		IField field = closure_field;
		if (field != null)
		{
			((ISupportRelocation)field).RelocateImpl(_info);
		}
	}
}
