using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Compiler.Parsetree;
using Nemerle.Core;
using Nemerle.Internal;

namespace Nemerle.Compiler.Typedtree;

[Variant("Nemerle.Compiler.Typedtree.TExpr.StaticRef,Nemerle.Compiler.Typedtree.TExpr.LocalRef,Nemerle.Compiler.Typedtree.TExpr.ImplicitValueTypeCtor,Nemerle.Compiler.Typedtree.TExpr.FieldMember,Nemerle.Compiler.Typedtree.TExpr.MethodRef,Nemerle.Compiler.Typedtree.TExpr.Call,Nemerle.Compiler.Typedtree.TExpr.Assign,Nemerle.Compiler.Typedtree.TExpr.DefValIn,Nemerle.Compiler.Typedtree.TExpr.Throw,Nemerle.Compiler.Typedtree.TExpr.TryFinally,Nemerle.Compiler.Typedtree.TExpr.Try,Nemerle.Compiler.Typedtree.TExpr.Literal,Nemerle.Compiler.Typedtree.TExpr.This,Nemerle.Compiler.Typedtree.TExpr.Base,Nemerle.Compiler.Typedtree.TExpr.TypeConversion,Nemerle.Compiler.Typedtree.TExpr.Sequence,Nemerle.Compiler.Typedtree.TExpr.Tuple,Nemerle.Compiler.Typedtree.TExpr.Array,Nemerle.Compiler.Typedtree.TExpr.TypeOf,Nemerle.Compiler.Typedtree.TExpr.MethodOf,Nemerle.Compiler.Typedtree.TExpr.CtorOf,Nemerle.Compiler.Typedtree.TExpr.FieldOf,Nemerle.Compiler.Typedtree.TExpr.ClosureObjectOf,Nemerle.Compiler.Typedtree.TExpr.ClosureFieldOf,Nemerle.Compiler.Typedtree.TExpr.ArrayIndexer,Nemerle.Compiler.Typedtree.TExpr.PointerIndexer,Nemerle.Compiler.Typedtree.TExpr.TupleIndexer,Nemerle.Compiler.Typedtree.TExpr.OpCode,Nemerle.Compiler.Typedtree.TExpr.MacroEnvelope,Nemerle.Compiler.Typedtree.TExpr.PropertyMember,Nemerle.Compiler.Typedtree.TExpr.StaticPropertyRef,Nemerle.Compiler.Typedtree.TExpr.EventMember,Nemerle.Compiler.Typedtree.TExpr.StaticEventRef,Nemerle.Compiler.Typedtree.TExpr.ConstantObjectRef,Nemerle.Compiler.Typedtree.TExpr.Block,Nemerle.Compiler.Typedtree.TExpr.Delayed,Nemerle.Compiler.Typedtree.TExpr.Cache,Nemerle.Compiler.Typedtree.TExpr.CacheRef,Nemerle.Compiler.Typedtree.TExpr.Error,Nemerle.Compiler.Typedtree.TExpr.DefFunctionsIn,Nemerle.Compiler.Typedtree.TExpr.Match,Nemerle.Compiler.Typedtree.TExpr.SelfTailCall,Nemerle.Compiler.Typedtree.TExpr.LocalFunRef,Nemerle.Compiler.Typedtree.TExpr.MethodAddress,Nemerle.Compiler.Typedtree.TExpr.MultipleAssign,Nemerle.Compiler.Typedtree.TExpr.Label,Nemerle.Compiler.Typedtree.TExpr.Goto,Nemerle.Compiler.Typedtree.TExpr.DefaultValue,Nemerle.Compiler.Typedtree.TExpr.If,Nemerle.Compiler.Typedtree.TExpr.HasType,Nemerle.Compiler.Typedtree.TExpr.Switch,Nemerle.Compiler.Typedtree.TExpr.DebugInfo,Nemerle.Compiler.Typedtree.TExpr.Def,Nemerle.Compiler.Typedtree.TExpr.Use")]
public abstract class TExpr : TypedBase
{
	[VariantOption]
	public class StaticRef : TExpr
	{
		public readonly FixedType.Class from;

		public readonly IMember mem;

		public readonly list<TypeVar> type_parms;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 0;
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
			list<TypeVar> list = type_parms;
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
			IMember member = mem;
			if (member != null)
			{
				((ISupportRelocation)member).RelocateImpl(_info);
			}
		}

		[RecordCtor]
		public StaticRef([MappedMember("from")] FixedType.Class from, [MappedMember("mem")] IMember mem, [MappedMember("type_parms")] list<TypeVar> type_parms)
		{
			this.from = from;
			this.mem = mem;
			this.type_parms = type_parms;
		}

		[RecordCtor]
		public StaticRef(TypeVar ty, [MappedMember("from")] FixedType.Class from, [MappedMember("mem")] IMember mem, [MappedMember("type_parms")] list<TypeVar> type_parms)
			: base(ty)
		{
			this.from = from;
			this.mem = mem;
			this.type_parms = type_parms;
		}

		[RecordCtor]
		public StaticRef(Location loc, TypeVar ty, [MappedMember("from")] FixedType.Class from, [MappedMember("mem")] IMember mem, [MappedMember("type_parms")] list<TypeVar> type_parms)
			: base(loc, ty)
		{
			this.from = from;
			this.mem = mem;
			this.type_parms = type_parms;
		}
	}

	[VariantOption]
	public class LocalRef : TExpr
	{
		public readonly LocalValue decl;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 1;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				decl?.RelocateImplInternal(_info);
			}
		}

		[RecordCtor]
		public LocalRef([MappedMember("decl")] LocalValue decl)
		{
			this.decl = decl;
		}

		[RecordCtor]
		public LocalRef(TypeVar ty, [MappedMember("decl")] LocalValue decl)
			: base(ty)
		{
			this.decl = decl;
		}

		[RecordCtor]
		public LocalRef(Location loc, TypeVar ty, [MappedMember("decl")] LocalValue decl)
			: base(loc, ty)
		{
			this.decl = decl;
		}
	}

	[VariantOption]
	public class ImplicitValueTypeCtor : TExpr
	{
		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 2;
		}

		[RecordCtor]
		public ImplicitValueTypeCtor()
		{
		}

		[RecordCtor]
		public ImplicitValueTypeCtor(TypeVar ty)
			: base(ty)
		{
		}

		[RecordCtor]
		public ImplicitValueTypeCtor(Location loc, TypeVar ty)
			: base(loc, ty)
		{
		}
	}

	[VariantOption]
	public class FieldMember : TExpr
	{
		public readonly TExpr obj;

		public readonly IField fld;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 3;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				IField field = fld;
				if (field != null)
				{
					((ISupportRelocation)field).RelocateImpl(_info);
				}
				obj?.RelocateImplInternal(_info);
			}
		}

		[RecordCtor]
		public FieldMember([MappedMember("obj")] TExpr obj, [MappedMember("fld")] IField fld)
		{
			this.obj = obj;
			this.fld = fld;
		}

		[RecordCtor]
		public FieldMember(TypeVar ty, [MappedMember("obj")] TExpr obj, [MappedMember("fld")] IField fld)
			: base(ty)
		{
			this.obj = obj;
			this.fld = fld;
		}

		[RecordCtor]
		public FieldMember(Location loc, TypeVar ty, [MappedMember("obj")] TExpr obj, [MappedMember("fld")] IField fld)
			: base(loc, ty)
		{
			this.obj = obj;
			this.fld = fld;
		}
	}

	[VariantOption]
	public class MethodRef : TExpr
	{
		public readonly TExpr obj;

		public readonly IMethod meth;

		public readonly list<TypeVar> type_parms;

		public readonly bool notvirtual;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 4;
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
			list<TypeVar> list = type_parms;
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
			IMethod method = meth;
			if (method != null)
			{
				((ISupportRelocation)method).RelocateImpl(_info);
			}
			obj?.RelocateImplInternal(_info);
		}

		[RecordCtor]
		public MethodRef([MappedMember("obj")] TExpr obj, [MappedMember("meth")] IMethod meth, [MappedMember("type_parms")] list<TypeVar> type_parms, [MappedMember("notvirtual")] bool notvirtual)
		{
			this.obj = obj;
			this.meth = meth;
			this.type_parms = type_parms;
			this.notvirtual = notvirtual;
		}

		[RecordCtor]
		public MethodRef(TypeVar ty, [MappedMember("obj")] TExpr obj, [MappedMember("meth")] IMethod meth, [MappedMember("type_parms")] list<TypeVar> type_parms, [MappedMember("notvirtual")] bool notvirtual)
			: base(ty)
		{
			this.obj = obj;
			this.meth = meth;
			this.type_parms = type_parms;
			this.notvirtual = notvirtual;
		}

		[RecordCtor]
		public MethodRef(Location loc, TypeVar ty, [MappedMember("obj")] TExpr obj, [MappedMember("meth")] IMethod meth, [MappedMember("type_parms")] list<TypeVar> type_parms, [MappedMember("notvirtual")] bool notvirtual)
			: base(loc, ty)
		{
			this.obj = obj;
			this.meth = meth;
			this.type_parms = type_parms;
			this.notvirtual = notvirtual;
		}
	}

	[VariantOption]
	public class Call : TExpr
	{
		public TExpr func;

		public list<Parm> parms;

		public bool is_tail;

		public override void SetParsedObject([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] ParsedBase related)
		{
			if (related == null)
			{
				throw new ArgumentNullException("related", "The ``NotNull'' contract of parameter ``related'' has been violated. See ncc\\typing\\TypedTree.n:749:73:749:80: .");
			}
			if (related is PExpr.Call)
			{
				PExpr parsedObject = ((PExpr.Call)related).func;
				func.SetParsedObject(parsedObject);
			}
			base.SetParsedObject(related);
		}

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 5;
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
			list<Parm> list = parms;
			if (list != null)
			{
				list = list;
				while (list is list<Parm>.Cons)
				{
					Parm hd = ((list<Parm>.Cons)list).hd;
					list = ((list<Parm>.Cons)list).tl;
					((ISupportRelocation)hd).RelocateImpl(_info);
					list = list;
				}
			}
			func?.RelocateImplInternal(_info);
		}

		[RecordCtor]
		public Call([MappedMember("func")] TExpr func, [MappedMember("parms")] list<Parm> parms, [MappedMember("is_tail")] bool is_tail)
		{
			this.func = func;
			this.parms = parms;
			this.is_tail = is_tail;
		}

		[RecordCtor]
		public Call(TypeVar ty, [MappedMember("func")] TExpr func, [MappedMember("parms")] list<Parm> parms, [MappedMember("is_tail")] bool is_tail)
			: base(ty)
		{
			this.func = func;
			this.parms = parms;
			this.is_tail = is_tail;
		}

		[RecordCtor]
		public Call(Location loc, TypeVar ty, [MappedMember("func")] TExpr func, [MappedMember("parms")] list<Parm> parms, [MappedMember("is_tail")] bool is_tail)
			: base(loc, ty)
		{
			this.func = func;
			this.parms = parms;
			this.is_tail = is_tail;
		}
	}

	[VariantOption]
	public class Assign : TExpr
	{
		public readonly TExpr target;

		public readonly TExpr source;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 6;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				source?.RelocateImplInternal(_info);
				target?.RelocateImplInternal(_info);
			}
		}

		[RecordCtor]
		public Assign([MappedMember("target")] TExpr target, [MappedMember("source")] TExpr source)
		{
			this.target = target;
			this.source = source;
		}

		[RecordCtor]
		public Assign(TypeVar ty, [MappedMember("target")] TExpr target, [MappedMember("source")] TExpr source)
			: base(ty)
		{
			this.target = target;
			this.source = source;
		}

		[RecordCtor]
		public Assign(Location loc, TypeVar ty, [MappedMember("target")] TExpr target, [MappedMember("source")] TExpr source)
			: base(loc, ty)
		{
			this.target = target;
			this.source = source;
		}
	}

	[VariantOption]
	public class DefValIn : TExpr
	{
		public readonly LocalValue name;

		public readonly TExpr val;

		public TExpr body;

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
				body?.RelocateImplInternal(_info);
				val?.RelocateImplInternal(_info);
				name?.RelocateImplInternal(_info);
			}
		}

		[RecordCtor]
		public DefValIn([MappedMember("name")] LocalValue name, [MappedMember("val")] TExpr val, [MappedMember("body")] TExpr body)
		{
			this.name = name;
			this.val = val;
			this.body = body;
		}

		[RecordCtor]
		public DefValIn(TypeVar ty, [MappedMember("name")] LocalValue name, [MappedMember("val")] TExpr val, [MappedMember("body")] TExpr body)
			: base(ty)
		{
			this.name = name;
			this.val = val;
			this.body = body;
		}

		[RecordCtor]
		public DefValIn(Location loc, TypeVar ty, [MappedMember("name")] LocalValue name, [MappedMember("val")] TExpr val, [MappedMember("body")] TExpr body)
			: base(loc, ty)
		{
			this.name = name;
			this.val = val;
			this.body = body;
		}
	}

	[VariantOption]
	public class Throw : TExpr
	{
		public readonly TExpr exn;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 8;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				exn?.RelocateImplInternal(_info);
			}
		}

		[RecordCtor]
		public Throw([MappedMember("exn")] TExpr exn)
		{
			this.exn = exn;
		}

		[RecordCtor]
		public Throw(TypeVar ty, [MappedMember("exn")] TExpr exn)
			: base(ty)
		{
			this.exn = exn;
		}

		[RecordCtor]
		public Throw(Location loc, TypeVar ty, [MappedMember("exn")] TExpr exn)
			: base(loc, ty)
		{
			this.exn = exn;
		}
	}

	[VariantOption]
	public class TryFinally : TExpr
	{
		public readonly TExpr body;

		public readonly TExpr handler;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 9;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				handler?.RelocateImplInternal(_info);
				body?.RelocateImplInternal(_info);
			}
		}

		[RecordCtor]
		public TryFinally([MappedMember("body")] TExpr body, [MappedMember("handler")] TExpr handler)
		{
			this.body = body;
			this.handler = handler;
		}

		[RecordCtor]
		public TryFinally(TypeVar ty, [MappedMember("body")] TExpr body, [MappedMember("handler")] TExpr handler)
			: base(ty)
		{
			this.body = body;
			this.handler = handler;
		}

		[RecordCtor]
		public TryFinally(Location loc, TypeVar ty, [MappedMember("body")] TExpr body, [MappedMember("handler")] TExpr handler)
			: base(loc, ty)
		{
			this.body = body;
			this.handler = handler;
		}
	}

	[VariantOption]
	public class Try : TExpr
	{
		public readonly TExpr body;

		public list<Try_case> cases;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 10;
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
			list<Try_case> list = cases;
			if (list != null)
			{
				list = list;
				while (list is list<Try_case>.Cons)
				{
					Try_case hd = ((list<Try_case>.Cons)list).hd;
					list = ((list<Try_case>.Cons)list).tl;
					((ISupportRelocation)hd).RelocateImpl(_info);
					list = list;
				}
			}
			body?.RelocateImplInternal(_info);
		}

		[RecordCtor]
		public Try([MappedMember("body")] TExpr body, [MappedMember("cases")] list<Try_case> cases)
		{
			this.body = body;
			this.cases = cases;
		}

		[RecordCtor]
		public Try(TypeVar ty, [MappedMember("body")] TExpr body, [MappedMember("cases")] list<Try_case> cases)
			: base(ty)
		{
			this.body = body;
			this.cases = cases;
		}

		[RecordCtor]
		public Try(Location loc, TypeVar ty, [MappedMember("body")] TExpr body, [MappedMember("cases")] list<Try_case> cases)
			: base(loc, ty)
		{
			this.body = body;
			this.cases = cases;
		}
	}

	[VariantOption]
	public class Literal : TExpr
	{
		public readonly Nemerle.Compiler.Literal val;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 11;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				val?.RelocateImplInternal(_info);
			}
		}

		[RecordCtor]
		public Literal([MappedMember("val")] Nemerle.Compiler.Literal val)
		{
			this.val = val;
		}

		[RecordCtor]
		public Literal(TypeVar ty, [MappedMember("val")] Nemerle.Compiler.Literal val)
			: base(ty)
		{
			this.val = val;
		}

		[RecordCtor]
		public Literal(Location loc, TypeVar ty, [MappedMember("val")] Nemerle.Compiler.Literal val)
			: base(loc, ty)
		{
			this.val = val;
		}
	}

	[VariantOption]
	public class This : TExpr
	{
		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 12;
		}

		[RecordCtor]
		public This()
		{
		}

		[RecordCtor]
		public This(TypeVar ty)
			: base(ty)
		{
		}

		[RecordCtor]
		public This(Location loc, TypeVar ty)
			: base(loc, ty)
		{
		}
	}

	[VariantOption]
	public class Base : TExpr
	{
		public readonly IMethod base_ctor;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 13;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				IMethod method = base_ctor;
				if (method != null)
				{
					((ISupportRelocation)method).RelocateImpl(_info);
				}
			}
		}

		[RecordCtor]
		public Base([MappedMember("base_ctor")] IMethod base_ctor)
		{
			this.base_ctor = base_ctor;
		}

		[RecordCtor]
		public Base(TypeVar ty, [MappedMember("base_ctor")] IMethod base_ctor)
			: base(ty)
		{
			this.base_ctor = base_ctor;
		}

		[RecordCtor]
		public Base(Location loc, TypeVar ty, [MappedMember("base_ctor")] IMethod base_ctor)
			: base(loc, ty)
		{
			this.base_ctor = base_ctor;
		}
	}

	[VariantOption]
	public class TypeConversion : TExpr
	{
		public TExpr expr;

		public readonly TypeVar target_type;

		public readonly ConversionKind kind;

		public Location target_type_location;

		public TypeConversion(Location loc, TypeVar tv, TExpr expr, TypeVar target_type, ConversionKind kind)
			: this(loc, tv, expr, target_type, kind, Location.Default)
		{
		}

		public TypeConversion(TypeVar tv, TExpr expr, TypeVar target_type, ConversionKind kind)
			: this(tv, expr, target_type, kind, Location.Default)
		{
		}

		public TypeConversion(TExpr expr, TypeVar target_type, ConversionKind kind)
			: this(expr, target_type, kind, Location.Default)
		{
		}

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 14;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				target_type_location = Completion.Relocate(target_type_location, _info);
				kind?.RelocateImplInternal(_info);
				expr?.RelocateImplInternal(_info);
			}
		}

		[RecordCtor]
		public TypeConversion([MappedMember("expr")] TExpr expr, [MappedMember("target_type")] TypeVar target_type, [MappedMember("kind")] ConversionKind kind, [MappedMember("target_type_location")] Location target_type_location)
		{
			this.expr = expr;
			this.target_type = target_type;
			this.kind = kind;
			this.target_type_location = target_type_location;
		}

		[RecordCtor]
		public TypeConversion(TypeVar ty, [MappedMember("expr")] TExpr expr, [MappedMember("target_type")] TypeVar target_type, [MappedMember("kind")] ConversionKind kind, [MappedMember("target_type_location")] Location target_type_location)
			: base(ty)
		{
			this.expr = expr;
			this.target_type = target_type;
			this.kind = kind;
			this.target_type_location = target_type_location;
		}

		[RecordCtor]
		public TypeConversion(Location loc, TypeVar ty, [MappedMember("expr")] TExpr expr, [MappedMember("target_type")] TypeVar target_type, [MappedMember("kind")] ConversionKind kind, [MappedMember("target_type_location")] Location target_type_location)
			: base(loc, ty)
		{
			this.expr = expr;
			this.target_type = target_type;
			this.kind = kind;
			this.target_type_location = target_type_location;
		}
	}

	[VariantOption]
	public class Sequence : TExpr
	{
		public TExpr e1;

		public TExpr e2;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 15;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				e2?.RelocateImplInternal(_info);
				e1?.RelocateImplInternal(_info);
			}
		}

		[RecordCtor]
		public Sequence([MappedMember("e1")] TExpr e1, [MappedMember("e2")] TExpr e2)
		{
			this.e1 = e1;
			this.e2 = e2;
		}

		[RecordCtor]
		public Sequence(TypeVar ty, [MappedMember("e1")] TExpr e1, [MappedMember("e2")] TExpr e2)
			: base(ty)
		{
			this.e1 = e1;
			this.e2 = e2;
		}

		[RecordCtor]
		public Sequence(Location loc, TypeVar ty, [MappedMember("e1")] TExpr e1, [MappedMember("e2")] TExpr e2)
			: base(loc, ty)
		{
			this.e1 = e1;
			this.e2 = e2;
		}
	}

	[VariantOption]
	public class Tuple : TExpr
	{
		public readonly list<TExpr> args;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 16;
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
			list<TExpr> list = args;
			if (list != null)
			{
				list = list;
				while (list is list<TExpr>.Cons)
				{
					TExpr hd = ((list<TExpr>.Cons)list).hd;
					list = ((list<TExpr>.Cons)list).tl;
					((ISupportRelocation)hd).RelocateImpl(_info);
					list = list;
				}
			}
		}

		[RecordCtor]
		public Tuple([MappedMember("args")] list<TExpr> args)
		{
			this.args = args;
		}

		[RecordCtor]
		public Tuple(TypeVar ty, [MappedMember("args")] list<TExpr> args)
			: base(ty)
		{
			this.args = args;
		}

		[RecordCtor]
		public Tuple(Location loc, TypeVar ty, [MappedMember("args")] list<TExpr> args)
			: base(loc, ty)
		{
			this.args = args;
		}
	}

	[VariantOption]
	public class Array : TExpr
	{
		public readonly list<TExpr> args;

		public readonly list<TExpr> dimensions;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 17;
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
			list<TExpr> list = dimensions;
			if (list != null)
			{
				list = list;
				while (list is list<TExpr>.Cons)
				{
					TExpr hd = ((list<TExpr>.Cons)list).hd;
					list = ((list<TExpr>.Cons)list).tl;
					((ISupportRelocation)hd).RelocateImpl(_info);
					list = list;
				}
			}
			list = args;
			if (list != null)
			{
				list = list;
				while (list is list<TExpr>.Cons)
				{
					TExpr hd = ((list<TExpr>.Cons)list).hd;
					list = ((list<TExpr>.Cons)list).tl;
					((ISupportRelocation)hd).RelocateImpl(_info);
					list = list;
				}
			}
		}

		[RecordCtor]
		public Array([MappedMember("args")] list<TExpr> args, [MappedMember("dimensions")] list<TExpr> dimensions)
		{
			this.args = args;
			this.dimensions = dimensions;
		}

		[RecordCtor]
		public Array(TypeVar ty, [MappedMember("args")] list<TExpr> args, [MappedMember("dimensions")] list<TExpr> dimensions)
			: base(ty)
		{
			this.args = args;
			this.dimensions = dimensions;
		}

		[RecordCtor]
		public Array(Location loc, TypeVar ty, [MappedMember("args")] list<TExpr> args, [MappedMember("dimensions")] list<TExpr> dimensions)
			: base(loc, ty)
		{
			this.args = args;
			this.dimensions = dimensions;
		}
	}

	[VariantOption]
	public class TypeOf : TExpr
	{
		public readonly TypeVar target_type;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 18;
		}

		[RecordCtor]
		public TypeOf([MappedMember("target_type")] TypeVar target_type)
		{
			this.target_type = target_type;
		}

		[RecordCtor]
		public TypeOf(TypeVar ty, [MappedMember("target_type")] TypeVar target_type)
			: base(ty)
		{
			this.target_type = target_type;
		}

		[RecordCtor]
		public TypeOf(Location loc, TypeVar ty, [MappedMember("target_type")] TypeVar target_type)
			: base(loc, ty)
		{
			this.target_type = target_type;
		}
	}

	[VariantOption]
	public class MethodOf : TExpr
	{
		public readonly TypeVar from_type;

		public readonly IMethod method;

		public readonly list<TypeVar> typars;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 19;
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
			list<TypeVar> list = typars;
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
			IMethod method = this.method;
			if (method != null)
			{
				((ISupportRelocation)method).RelocateImpl(_info);
			}
		}

		[RecordCtor]
		public MethodOf([MappedMember("from_type")] TypeVar from_type, [MappedMember("method")] IMethod method, [MappedMember("typars")] list<TypeVar> typars)
		{
			this.from_type = from_type;
			this.method = method;
			this.typars = typars;
		}

		[RecordCtor]
		public MethodOf(TypeVar ty, [MappedMember("from_type")] TypeVar from_type, [MappedMember("method")] IMethod method, [MappedMember("typars")] list<TypeVar> typars)
			: base(ty)
		{
			this.from_type = from_type;
			this.method = method;
			this.typars = typars;
		}

		[RecordCtor]
		public MethodOf(Location loc, TypeVar ty, [MappedMember("from_type")] TypeVar from_type, [MappedMember("method")] IMethod method, [MappedMember("typars")] list<TypeVar> typars)
			: base(loc, ty)
		{
			this.from_type = from_type;
			this.method = method;
			this.typars = typars;
		}
	}

	[VariantOption]
	public class CtorOf : TExpr
	{
		public readonly TypeVar type;

		public readonly IMethod method;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 20;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				IMethod method = this.method;
				if (method != null)
				{
					((ISupportRelocation)method).RelocateImpl(_info);
				}
			}
		}

		[RecordCtor]
		public CtorOf([MappedMember("type")] TypeVar type, [MappedMember("method")] IMethod method)
		{
			this.type = type;
			this.method = method;
		}

		[RecordCtor]
		public CtorOf(TypeVar ty, [MappedMember("type")] TypeVar type, [MappedMember("method")] IMethod method)
			: base(ty)
		{
			this.type = type;
			this.method = method;
		}

		[RecordCtor]
		public CtorOf(Location loc, TypeVar ty, [MappedMember("type")] TypeVar type, [MappedMember("method")] IMethod method)
			: base(loc, ty)
		{
			this.type = type;
			this.method = method;
		}
	}

	[VariantOption]
	public class FieldOf : TExpr
	{
		public readonly TypeVar type;

		public readonly IField field;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 21;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				IField field = this.field;
				if (field != null)
				{
					((ISupportRelocation)field).RelocateImpl(_info);
				}
			}
		}

		[RecordCtor]
		public FieldOf([MappedMember("type")] TypeVar type, [MappedMember("field")] IField field)
		{
			this.type = type;
			this.field = field;
		}

		[RecordCtor]
		public FieldOf(TypeVar ty, [MappedMember("type")] TypeVar type, [MappedMember("field")] IField field)
			: base(ty)
		{
			this.type = type;
			this.field = field;
		}

		[RecordCtor]
		public FieldOf(Location loc, TypeVar ty, [MappedMember("type")] TypeVar type, [MappedMember("field")] IField field)
			: base(loc, ty)
		{
			this.type = type;
			this.field = field;
		}
	}

	[VariantOption]
	public class ClosureObjectOf : TExpr
	{
		public readonly TExpr varRef;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 22;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				varRef?.RelocateImplInternal(_info);
			}
		}

		[RecordCtor]
		public ClosureObjectOf([MappedMember("varRef")] TExpr varRef)
		{
			this.varRef = varRef;
		}

		[RecordCtor]
		public ClosureObjectOf(TypeVar ty, [MappedMember("varRef")] TExpr varRef)
			: base(ty)
		{
			this.varRef = varRef;
		}

		[RecordCtor]
		public ClosureObjectOf(Location loc, TypeVar ty, [MappedMember("varRef")] TExpr varRef)
			: base(loc, ty)
		{
			this.varRef = varRef;
		}
	}

	[VariantOption]
	public class ClosureFieldOf : TExpr
	{
		public readonly TExpr varRef;

		public ClosureFieldOf(InternalTypeClass types, TExpr varRef)
		{
			_ty = types.FieldInfo;
			this.varRef = varRef;
		}

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 23;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				varRef?.RelocateImplInternal(_info);
			}
		}

		[RecordCtor]
		public ClosureFieldOf([MappedMember("varRef")] TExpr varRef)
		{
			this.varRef = varRef;
		}

		[RecordCtor]
		public ClosureFieldOf(TypeVar ty, [MappedMember("varRef")] TExpr varRef)
			: base(ty)
		{
			this.varRef = varRef;
		}

		[RecordCtor]
		public ClosureFieldOf(Location loc, TypeVar ty, [MappedMember("varRef")] TExpr varRef)
			: base(loc, ty)
		{
			this.varRef = varRef;
		}
	}

	[VariantOption]
	public class ArrayIndexer : TExpr
	{
		public readonly TExpr obj;

		public readonly list<TExpr> args;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 24;
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
			list<TExpr> list = args;
			if (list != null)
			{
				list = list;
				while (list is list<TExpr>.Cons)
				{
					TExpr hd = ((list<TExpr>.Cons)list).hd;
					list = ((list<TExpr>.Cons)list).tl;
					((ISupportRelocation)hd).RelocateImpl(_info);
					list = list;
				}
			}
			obj?.RelocateImplInternal(_info);
		}

		[RecordCtor]
		public ArrayIndexer([MappedMember("obj")] TExpr obj, [MappedMember("args")] list<TExpr> args)
		{
			this.obj = obj;
			this.args = args;
		}

		[RecordCtor]
		public ArrayIndexer(TypeVar ty, [MappedMember("obj")] TExpr obj, [MappedMember("args")] list<TExpr> args)
			: base(ty)
		{
			this.obj = obj;
			this.args = args;
		}

		[RecordCtor]
		public ArrayIndexer(Location loc, TypeVar ty, [MappedMember("obj")] TExpr obj, [MappedMember("args")] list<TExpr> args)
			: base(loc, ty)
		{
			this.obj = obj;
			this.args = args;
		}
	}

	[VariantOption]
	public class PointerIndexer : TExpr
	{
		public readonly TExpr obj;

		public readonly TExpr index;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 25;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				index?.RelocateImplInternal(_info);
				obj?.RelocateImplInternal(_info);
			}
		}

		[RecordCtor]
		public PointerIndexer([MappedMember("obj")] TExpr obj, [MappedMember("index")] TExpr index)
		{
			this.obj = obj;
			this.index = index;
		}

		[RecordCtor]
		public PointerIndexer(TypeVar ty, [MappedMember("obj")] TExpr obj, [MappedMember("index")] TExpr index)
			: base(ty)
		{
			this.obj = obj;
			this.index = index;
		}

		[RecordCtor]
		public PointerIndexer(Location loc, TypeVar ty, [MappedMember("obj")] TExpr obj, [MappedMember("index")] TExpr index)
			: base(loc, ty)
		{
			this.obj = obj;
			this.index = index;
		}
	}

	[VariantOption]
	public class TupleIndexer : TExpr
	{
		public readonly TExpr obj;

		public readonly int pos;

		public readonly int len;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 26;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				obj?.RelocateImplInternal(_info);
			}
		}

		[RecordCtor]
		public TupleIndexer([MappedMember("obj")] TExpr obj, [MappedMember("pos")] int pos, [MappedMember("len")] int len)
		{
			this.obj = obj;
			this.pos = pos;
			this.len = len;
		}

		[RecordCtor]
		public TupleIndexer(TypeVar ty, [MappedMember("obj")] TExpr obj, [MappedMember("pos")] int pos, [MappedMember("len")] int len)
			: base(ty)
		{
			this.obj = obj;
			this.pos = pos;
			this.len = len;
		}

		[RecordCtor]
		public TupleIndexer(Location loc, TypeVar ty, [MappedMember("obj")] TExpr obj, [MappedMember("pos")] int pos, [MappedMember("len")] int len)
			: base(loc, ty)
		{
			this.obj = obj;
			this.pos = pos;
			this.len = len;
		}
	}

	[VariantOption]
	public class OpCode : TExpr
	{
		public readonly string name;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 27;
		}

		[RecordCtor]
		public OpCode([MappedMember("name")] string name)
		{
			this.name = name;
		}

		[RecordCtor]
		public OpCode(TypeVar ty, [MappedMember("name")] string name)
			: base(ty)
		{
			this.name = name;
		}

		[RecordCtor]
		public OpCode(Location loc, TypeVar ty, [MappedMember("name")] string name)
			: base(loc, ty)
		{
			this.name = name;
		}
	}

	[VariantOption]
	public class MacroEnvelope : TExpr
	{
		public readonly PExpr original;

		public readonly IMacro the_macro;

		public readonly TExpr expanded;

		public readonly PExpr expandedPExpr;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 28;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				expandedPExpr?.RelocateImplInternal(_info);
				expanded?.RelocateImplInternal(_info);
				original?.RelocateImplInternal(_info);
			}
		}

		[RecordCtor]
		public MacroEnvelope([MappedMember("original")] PExpr original, [MappedMember("the_macro")] IMacro the_macro, [MappedMember("expanded")] TExpr expanded, [MappedMember("expandedPExpr")] PExpr expandedPExpr)
		{
			this.original = original;
			this.the_macro = the_macro;
			this.expanded = expanded;
			this.expandedPExpr = expandedPExpr;
		}

		[RecordCtor]
		public MacroEnvelope(TypeVar ty, [MappedMember("original")] PExpr original, [MappedMember("the_macro")] IMacro the_macro, [MappedMember("expanded")] TExpr expanded, [MappedMember("expandedPExpr")] PExpr expandedPExpr)
			: base(ty)
		{
			this.original = original;
			this.the_macro = the_macro;
			this.expanded = expanded;
			this.expandedPExpr = expandedPExpr;
		}

		[RecordCtor]
		public MacroEnvelope(Location loc, TypeVar ty, [MappedMember("original")] PExpr original, [MappedMember("the_macro")] IMacro the_macro, [MappedMember("expanded")] TExpr expanded, [MappedMember("expandedPExpr")] PExpr expandedPExpr)
			: base(loc, ty)
		{
			this.original = original;
			this.the_macro = the_macro;
			this.expanded = expanded;
			this.expandedPExpr = expandedPExpr;
		}
	}

	[VariantOption]
	public class PropertyMember : TExpr
	{
		public readonly TExpr obj;

		public readonly IProperty prop;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 29;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				IProperty property = prop;
				if (property != null)
				{
					((ISupportRelocation)property).RelocateImpl(_info);
				}
				obj?.RelocateImplInternal(_info);
			}
		}

		[RecordCtor]
		public PropertyMember([MappedMember("obj")] TExpr obj, [MappedMember("prop")] IProperty prop)
		{
			this.obj = obj;
			this.prop = prop;
		}

		[RecordCtor]
		public PropertyMember(TypeVar ty, [MappedMember("obj")] TExpr obj, [MappedMember("prop")] IProperty prop)
			: base(ty)
		{
			this.obj = obj;
			this.prop = prop;
		}

		[RecordCtor]
		public PropertyMember(Location loc, TypeVar ty, [MappedMember("obj")] TExpr obj, [MappedMember("prop")] IProperty prop)
			: base(loc, ty)
		{
			this.obj = obj;
			this.prop = prop;
		}
	}

	[VariantOption]
	public class StaticPropertyRef : TExpr
	{
		public readonly FixedType.Class from;

		public readonly IProperty prop;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 30;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				IProperty property = prop;
				if (property != null)
				{
					((ISupportRelocation)property).RelocateImpl(_info);
				}
			}
		}

		[RecordCtor]
		public StaticPropertyRef([MappedMember("from")] FixedType.Class from, [MappedMember("prop")] IProperty prop)
		{
			this.from = from;
			this.prop = prop;
		}

		[RecordCtor]
		public StaticPropertyRef(TypeVar ty, [MappedMember("from")] FixedType.Class from, [MappedMember("prop")] IProperty prop)
			: base(ty)
		{
			this.from = from;
			this.prop = prop;
		}

		[RecordCtor]
		public StaticPropertyRef(Location loc, TypeVar ty, [MappedMember("from")] FixedType.Class from, [MappedMember("prop")] IProperty prop)
			: base(loc, ty)
		{
			this.from = from;
			this.prop = prop;
		}
	}

	[VariantOption]
	public class EventMember : TExpr
	{
		public readonly TExpr obj;

		public readonly IEvent ev;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 31;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				IEvent @event = ev;
				if (@event != null)
				{
					((ISupportRelocation)@event).RelocateImpl(_info);
				}
				obj?.RelocateImplInternal(_info);
			}
		}

		[RecordCtor]
		public EventMember([MappedMember("obj")] TExpr obj, [MappedMember("ev")] IEvent ev)
		{
			this.obj = obj;
			this.ev = ev;
		}

		[RecordCtor]
		public EventMember(TypeVar ty, [MappedMember("obj")] TExpr obj, [MappedMember("ev")] IEvent ev)
			: base(ty)
		{
			this.obj = obj;
			this.ev = ev;
		}

		[RecordCtor]
		public EventMember(Location loc, TypeVar ty, [MappedMember("obj")] TExpr obj, [MappedMember("ev")] IEvent ev)
			: base(loc, ty)
		{
			this.obj = obj;
			this.ev = ev;
		}
	}

	[VariantOption]
	public class StaticEventRef : TExpr
	{
		public readonly FixedType.Class from;

		public readonly IEvent ev;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 32;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				IEvent @event = ev;
				if (@event != null)
				{
					((ISupportRelocation)@event).RelocateImpl(_info);
				}
			}
		}

		[RecordCtor]
		public StaticEventRef([MappedMember("from")] FixedType.Class from, [MappedMember("ev")] IEvent ev)
		{
			this.from = from;
			this.ev = ev;
		}

		[RecordCtor]
		public StaticEventRef(TypeVar ty, [MappedMember("from")] FixedType.Class from, [MappedMember("ev")] IEvent ev)
			: base(ty)
		{
			this.from = from;
			this.ev = ev;
		}

		[RecordCtor]
		public StaticEventRef(Location loc, TypeVar ty, [MappedMember("from")] FixedType.Class from, [MappedMember("ev")] IEvent ev)
			: base(loc, ty)
		{
			this.from = from;
			this.ev = ev;
		}
	}

	[VariantOption]
	public class ConstantObjectRef : TExpr
	{
		public readonly FixedType.Class from;

		public readonly IField mem;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 33;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				IField field = mem;
				if (field != null)
				{
					((ISupportRelocation)field).RelocateImpl(_info);
				}
			}
		}

		[RecordCtor]
		public ConstantObjectRef([MappedMember("from")] FixedType.Class from, [MappedMember("mem")] IField mem)
		{
			this.from = from;
			this.mem = mem;
		}

		[RecordCtor]
		public ConstantObjectRef(TypeVar ty, [MappedMember("from")] FixedType.Class from, [MappedMember("mem")] IField mem)
			: base(ty)
		{
			this.from = from;
			this.mem = mem;
		}

		[RecordCtor]
		public ConstantObjectRef(Location loc, TypeVar ty, [MappedMember("from")] FixedType.Class from, [MappedMember("mem")] IField mem)
			: base(loc, ty)
		{
			this.from = from;
			this.mem = mem;
		}
	}

	[VariantOption]
	public class Block : TExpr
	{
		public readonly LocalValue jump_out;

		public readonly TExpr body;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 34;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				body?.RelocateImplInternal(_info);
				jump_out?.RelocateImplInternal(_info);
			}
		}

		[RecordCtor]
		public Block([MappedMember("jump_out")] LocalValue jump_out, [MappedMember("body")] TExpr body)
		{
			this.jump_out = jump_out;
			this.body = body;
		}

		[RecordCtor]
		public Block(TypeVar ty, [MappedMember("jump_out")] LocalValue jump_out, [MappedMember("body")] TExpr body)
			: base(ty)
		{
			this.jump_out = jump_out;
			this.body = body;
		}

		[RecordCtor]
		public Block(Location loc, TypeVar ty, [MappedMember("jump_out")] LocalValue jump_out, [MappedMember("body")] TExpr body)
			: base(loc, ty)
		{
			this.jump_out = jump_out;
			this.body = body;
		}
	}

	[VariantOption]
	public class Delayed : TExpr
	{
		public readonly Typer.DelayedTyping susp;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 35;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				susp?.RelocateImplInternal(_info);
			}
		}

		[RecordCtor]
		public Delayed([MappedMember("susp")] Typer.DelayedTyping susp)
		{
			this.susp = susp;
		}

		[RecordCtor]
		public Delayed(TypeVar ty, [MappedMember("susp")] Typer.DelayedTyping susp)
			: base(ty)
		{
			this.susp = susp;
		}

		[RecordCtor]
		public Delayed(Location loc, TypeVar ty, [MappedMember("susp")] Typer.DelayedTyping susp)
			: base(loc, ty)
		{
			this.susp = susp;
		}
	}

	[VariantOption]
	public class Cache : TExpr
	{
		public readonly CacheDesc desc;

		public TExpr body;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 36;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				body?.RelocateImplInternal(_info);
				desc?.RelocateImplInternal(_info);
			}
		}

		[RecordCtor]
		public Cache([MappedMember("desc")] CacheDesc desc, [MappedMember("body")] TExpr body)
		{
			this.desc = desc;
			this.body = body;
		}

		[RecordCtor]
		public Cache(TypeVar ty, [MappedMember("desc")] CacheDesc desc, [MappedMember("body")] TExpr body)
			: base(ty)
		{
			this.desc = desc;
			this.body = body;
		}

		[RecordCtor]
		public Cache(Location loc, TypeVar ty, [MappedMember("desc")] CacheDesc desc, [MappedMember("body")] TExpr body)
			: base(loc, ty)
		{
			this.desc = desc;
			this.body = body;
		}
	}

	[VariantOption]
	public class CacheRef : TExpr
	{
		public readonly CacheDesc desc;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 37;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				desc?.RelocateImplInternal(_info);
			}
		}

		[RecordCtor]
		public CacheRef([MappedMember("desc")] CacheDesc desc)
		{
			this.desc = desc;
		}

		[RecordCtor]
		public CacheRef(TypeVar ty, [MappedMember("desc")] CacheDesc desc)
			: base(ty)
		{
			this.desc = desc;
		}

		[RecordCtor]
		public CacheRef(Location loc, TypeVar ty, [MappedMember("desc")] CacheDesc desc)
			: base(loc, ty)
		{
			this.desc = desc;
		}
	}

	[VariantOption]
	public class Error : TExpr
	{
		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 38;
		}

		[RecordCtor]
		public Error()
		{
		}

		[RecordCtor]
		public Error(TypeVar ty)
			: base(ty)
		{
		}

		[RecordCtor]
		public Error(Location loc, TypeVar ty)
			: base(loc, ty)
		{
		}
	}

	[VariantOption]
	public class DefFunctionsIn : TExpr
	{
		public readonly list<TFunHeader> funs;

		public TExpr body;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 39;
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
			body?.RelocateImplInternal(_info);
			list<TFunHeader> list = funs;
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
		}

		[RecordCtor]
		public DefFunctionsIn([MappedMember("funs")] list<TFunHeader> funs, [MappedMember("body")] TExpr body)
		{
			this.funs = funs;
			this.body = body;
		}

		[RecordCtor]
		public DefFunctionsIn(TypeVar ty, [MappedMember("funs")] list<TFunHeader> funs, [MappedMember("body")] TExpr body)
			: base(ty)
		{
			this.funs = funs;
			this.body = body;
		}

		[RecordCtor]
		public DefFunctionsIn(Location loc, TypeVar ty, [MappedMember("funs")] list<TFunHeader> funs, [MappedMember("body")] TExpr body)
			: base(loc, ty)
		{
			this.funs = funs;
			this.body = body;
		}
	}

	[VariantOption]
	public class Match : TExpr
	{
		public readonly TExpr expr;

		public readonly list<Match_case> cases;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 40;
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
			list<Match_case> list = cases;
			if (list != null)
			{
				list = list;
				while (list is list<Match_case>.Cons)
				{
					Match_case hd = ((list<Match_case>.Cons)list).hd;
					list = ((list<Match_case>.Cons)list).tl;
					((ISupportRelocation)hd).RelocateImpl(_info);
					list = list;
				}
			}
			expr?.RelocateImplInternal(_info);
		}

		[RecordCtor]
		public Match([MappedMember("expr")] TExpr expr, [MappedMember("cases")] list<Match_case> cases)
		{
			this.expr = expr;
			this.cases = cases;
		}

		[RecordCtor]
		public Match(TypeVar ty, [MappedMember("expr")] TExpr expr, [MappedMember("cases")] list<Match_case> cases)
			: base(ty)
		{
			this.expr = expr;
			this.cases = cases;
		}

		[RecordCtor]
		public Match(Location loc, TypeVar ty, [MappedMember("expr")] TExpr expr, [MappedMember("cases")] list<Match_case> cases)
			: base(loc, ty)
		{
			this.expr = expr;
			this.cases = cases;
		}
	}

	[VariantOption]
	public class SelfTailCall : TExpr
	{
		public readonly TExpr func;

		public readonly list<Parm> parms;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 41;
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
			list<Parm> list = parms;
			if (list != null)
			{
				list = list;
				while (list is list<Parm>.Cons)
				{
					Parm hd = ((list<Parm>.Cons)list).hd;
					list = ((list<Parm>.Cons)list).tl;
					((ISupportRelocation)hd).RelocateImpl(_info);
					list = list;
				}
			}
			func?.RelocateImplInternal(_info);
		}

		[RecordCtor]
		public SelfTailCall([MappedMember("func")] TExpr func, [MappedMember("parms")] list<Parm> parms)
		{
			this.func = func;
			this.parms = parms;
		}

		[RecordCtor]
		public SelfTailCall(TypeVar ty, [MappedMember("func")] TExpr func, [MappedMember("parms")] list<Parm> parms)
			: base(ty)
		{
			this.func = func;
			this.parms = parms;
		}

		[RecordCtor]
		public SelfTailCall(Location loc, TypeVar ty, [MappedMember("func")] TExpr func, [MappedMember("parms")] list<Parm> parms)
			: base(loc, ty)
		{
			this.func = func;
			this.parms = parms;
		}
	}

	[VariantOption]
	public class LocalFunRef : TExpr
	{
		public readonly LocalValue decl;

		public readonly list<TypeVar> type_parms;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 42;
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
			list<TypeVar> list = type_parms;
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
			decl?.RelocateImplInternal(_info);
		}

		[RecordCtor]
		public LocalFunRef([MappedMember("decl")] LocalValue decl, [MappedMember("type_parms")] list<TypeVar> type_parms)
		{
			this.decl = decl;
			this.type_parms = type_parms;
		}

		[RecordCtor]
		public LocalFunRef(TypeVar ty, [MappedMember("decl")] LocalValue decl, [MappedMember("type_parms")] list<TypeVar> type_parms)
			: base(ty)
		{
			this.decl = decl;
			this.type_parms = type_parms;
		}

		[RecordCtor]
		public LocalFunRef(Location loc, TypeVar ty, [MappedMember("decl")] LocalValue decl, [MappedMember("type_parms")] list<TypeVar> type_parms)
			: base(loc, ty)
		{
			this.decl = decl;
			this.type_parms = type_parms;
		}
	}

	[VariantOption]
	public class MethodAddress : TExpr
	{
		public readonly TypeVar from;

		public readonly IMethod meth;

		public readonly bool is_virt;

		public readonly list<TypeVar> type_parms;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 43;
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
			list<TypeVar> list = type_parms;
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
			IMethod method = meth;
			if (method != null)
			{
				((ISupportRelocation)method).RelocateImpl(_info);
			}
		}

		[RecordCtor]
		public MethodAddress([MappedMember("from")] TypeVar from, [MappedMember("meth")] IMethod meth, [MappedMember("is_virt")] bool is_virt, [MappedMember("type_parms")] list<TypeVar> type_parms)
		{
			this.from = from;
			this.meth = meth;
			this.is_virt = is_virt;
			this.type_parms = type_parms;
		}

		[RecordCtor]
		public MethodAddress(TypeVar ty, [MappedMember("from")] TypeVar from, [MappedMember("meth")] IMethod meth, [MappedMember("is_virt")] bool is_virt, [MappedMember("type_parms")] list<TypeVar> type_parms)
			: base(ty)
		{
			this.from = from;
			this.meth = meth;
			this.is_virt = is_virt;
			this.type_parms = type_parms;
		}

		[RecordCtor]
		public MethodAddress(Location loc, TypeVar ty, [MappedMember("from")] TypeVar from, [MappedMember("meth")] IMethod meth, [MappedMember("is_virt")] bool is_virt, [MappedMember("type_parms")] list<TypeVar> type_parms)
			: base(loc, ty)
		{
			this.from = from;
			this.meth = meth;
			this.is_virt = is_virt;
			this.type_parms = type_parms;
		}
	}

	[VariantOption]
	public class MultipleAssign : TExpr
	{
		public readonly list<Nemerle.Builtins.Tuple<LocalValue, TExpr>> assigns;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 44;
		}

		[RecordCtor]
		public MultipleAssign([MappedMember("assigns")] list<Nemerle.Builtins.Tuple<LocalValue, TExpr>> assigns)
		{
			this.assigns = assigns;
		}

		[RecordCtor]
		public MultipleAssign(TypeVar ty, [MappedMember("assigns")] list<Nemerle.Builtins.Tuple<LocalValue, TExpr>> assigns)
			: base(ty)
		{
			this.assigns = assigns;
		}

		[RecordCtor]
		public MultipleAssign(Location loc, TypeVar ty, [MappedMember("assigns")] list<Nemerle.Builtins.Tuple<LocalValue, TExpr>> assigns)
			: base(loc, ty)
		{
			this.assigns = assigns;
		}
	}

	[VariantOption]
	public class Label : TExpr
	{
		public readonly int id;

		public readonly TExpr body;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 45;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				body?.RelocateImplInternal(_info);
			}
		}

		[RecordCtor]
		public Label([MappedMember("id")] int id, [MappedMember("body")] TExpr body)
		{
			this.id = id;
			this.body = body;
		}

		[RecordCtor]
		public Label(TypeVar ty, [MappedMember("id")] int id, [MappedMember("body")] TExpr body)
			: base(ty)
		{
			this.id = id;
			this.body = body;
		}

		[RecordCtor]
		public Label(Location loc, TypeVar ty, [MappedMember("id")] int id, [MappedMember("body")] TExpr body)
			: base(loc, ty)
		{
			this.id = id;
			this.body = body;
		}
	}

	[VariantOption]
	public class Goto : TExpr
	{
		public readonly int target;

		public int try_block;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 46;
		}

		[RecordCtor]
		public Goto([MappedMember("target")] int target, [MappedMember("try_block")] int try_block)
		{
			this.target = target;
			this.try_block = try_block;
		}

		[RecordCtor]
		public Goto(TypeVar ty, [MappedMember("target")] int target, [MappedMember("try_block")] int try_block)
			: base(ty)
		{
			this.target = target;
			this.try_block = try_block;
		}

		[RecordCtor]
		public Goto(Location loc, TypeVar ty, [MappedMember("target")] int target, [MappedMember("try_block")] int try_block)
			: base(loc, ty)
		{
			this.target = target;
			this.try_block = try_block;
		}
	}

	[VariantOption]
	public class DefaultValue : TExpr
	{
		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 47;
		}

		[RecordCtor]
		public DefaultValue()
		{
		}

		[RecordCtor]
		public DefaultValue(TypeVar ty)
			: base(ty)
		{
		}

		[RecordCtor]
		public DefaultValue(Location loc, TypeVar ty)
			: base(loc, ty)
		{
		}
	}

	[VariantOption]
	public class If : TExpr
	{
		public readonly TExpr cond;

		public readonly TExpr e_then;

		public readonly TExpr e_else;

		public Location then_debug_loc;

		public Location else_debug_loc;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 48;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				else_debug_loc = Completion.Relocate(else_debug_loc, _info);
				then_debug_loc = Completion.Relocate(then_debug_loc, _info);
				e_else?.RelocateImplInternal(_info);
				e_then?.RelocateImplInternal(_info);
				cond?.RelocateImplInternal(_info);
			}
		}

		[RecordCtor]
		public If([MappedMember("cond")] TExpr cond, [MappedMember("e_then")] TExpr e_then, [MappedMember("e_else")] TExpr e_else, [MappedMember("then_debug_loc")] Location then_debug_loc, [MappedMember("else_debug_loc")] Location else_debug_loc)
		{
			this.cond = cond;
			this.e_then = e_then;
			this.e_else = e_else;
			this.then_debug_loc = then_debug_loc;
			this.else_debug_loc = else_debug_loc;
		}

		[RecordCtor]
		public If(TypeVar ty, [MappedMember("cond")] TExpr cond, [MappedMember("e_then")] TExpr e_then, [MappedMember("e_else")] TExpr e_else, [MappedMember("then_debug_loc")] Location then_debug_loc, [MappedMember("else_debug_loc")] Location else_debug_loc)
			: base(ty)
		{
			this.cond = cond;
			this.e_then = e_then;
			this.e_else = e_else;
			this.then_debug_loc = then_debug_loc;
			this.else_debug_loc = else_debug_loc;
		}

		[RecordCtor]
		public If(Location loc, TypeVar ty, [MappedMember("cond")] TExpr cond, [MappedMember("e_then")] TExpr e_then, [MappedMember("e_else")] TExpr e_else, [MappedMember("then_debug_loc")] Location then_debug_loc, [MappedMember("else_debug_loc")] Location else_debug_loc)
			: base(loc, ty)
		{
			this.cond = cond;
			this.e_then = e_then;
			this.e_else = e_else;
			this.then_debug_loc = then_debug_loc;
			this.else_debug_loc = else_debug_loc;
		}
	}

	[VariantOption]
	public class HasType : TExpr
	{
		public readonly TExpr expr;

		public readonly FixedType test_ty;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 49;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				expr?.RelocateImplInternal(_info);
			}
		}

		[RecordCtor]
		public HasType([MappedMember("expr")] TExpr expr, [MappedMember("test_ty")] FixedType test_ty)
		{
			this.expr = expr;
			this.test_ty = test_ty;
		}

		[RecordCtor]
		public HasType(TypeVar ty, [MappedMember("expr")] TExpr expr, [MappedMember("test_ty")] FixedType test_ty)
			: base(ty)
		{
			this.expr = expr;
			this.test_ty = test_ty;
		}

		[RecordCtor]
		public HasType(Location loc, TypeVar ty, [MappedMember("expr")] TExpr expr, [MappedMember("test_ty")] FixedType test_ty)
			: base(loc, ty)
		{
			this.expr = expr;
			this.test_ty = test_ty;
		}
	}

	[VariantOption]
	public class Switch : TExpr
	{
		public readonly TExpr indexing_expr;

		public readonly option<TExpr> @default;

		public readonly list<Nemerle.Builtins.Tuple<int, TExpr>> cases;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 50;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				option<TExpr> option = @default;
				if (option is option<TExpr>.Some)
				{
					TExpr val = ((option<TExpr>.Some)option).val;
					((ISupportRelocation)val).RelocateImpl(_info);
				}
				indexing_expr?.RelocateImplInternal(_info);
			}
		}

		[RecordCtor]
		public Switch([MappedMember("indexing_expr")] TExpr indexing_expr, [MappedMember("default")] option<TExpr> @default, [MappedMember("cases")] list<Nemerle.Builtins.Tuple<int, TExpr>> cases)
		{
			this.indexing_expr = indexing_expr;
			this.@default = @default;
			this.cases = cases;
		}

		[RecordCtor]
		public Switch(TypeVar ty, [MappedMember("indexing_expr")] TExpr indexing_expr, [MappedMember("default")] option<TExpr> @default, [MappedMember("cases")] list<Nemerle.Builtins.Tuple<int, TExpr>> cases)
			: base(ty)
		{
			this.indexing_expr = indexing_expr;
			this.@default = @default;
			this.cases = cases;
		}

		[RecordCtor]
		public Switch(Location loc, TypeVar ty, [MappedMember("indexing_expr")] TExpr indexing_expr, [MappedMember("default")] option<TExpr> @default, [MappedMember("cases")] list<Nemerle.Builtins.Tuple<int, TExpr>> cases)
			: base(loc, ty)
		{
			this.indexing_expr = indexing_expr;
			this.@default = @default;
			this.cases = cases;
		}
	}

	[VariantOption]
	public class DebugInfo : TExpr
	{
		public readonly TExpr expr;

		public readonly PExpr pexpr;

		public DebugInfo(TypeVar ty, TExpr expr, PExpr pexpr)
			: base(ty)
		{
			this.expr = expr;
			this.pexpr = pexpr;
		}

		public DebugInfo(Location loc, TypeVar ty, TExpr expr, PExpr pexpr)
		{
			if (!loc.IsSourceAvailable)
			{
				throw new AssertionException("ncc\\typing\\TypedTree.n", 861, "loc.IsSourceAvailable", "");
			}
			base._002Ector(loc, ty);
			this.expr = expr;
			this.pexpr = pexpr;
		}

		public DebugInfo(Location loc, TExpr expr, PExpr pexpr)
			: this(loc, expr?.ty, expr, pexpr)
		{
		}

		public DebugInfo(TExpr expr, PExpr pexpr)
		{
			TypeVar typeVar = expr?.ty;
			Location location = pexpr?.Location ?? expr?.Location ?? Location.Default;
			if (location.IsSourceAvailable)
			{
				base._002Ector(location, typeVar);
			}
			else
			{
				base._002Ector(typeVar);
			}
		}

		public override void SetParsedObject([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] ParsedBase related)
		{
			if (related == null)
			{
				throw new ArgumentNullException("related", "The ``NotNull'' contract of parameter ``related'' has been violated. See ncc\\typing\\TypedTree.n:889:73:889:80: .");
			}
			expr.SetParsedObject(related);
		}

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 51;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				pexpr?.RelocateImplInternal(_info);
				expr?.RelocateImplInternal(_info);
			}
		}
	}

	[VariantOption]
	public class Def : TExpr
	{
		public TExpr expr;

		public TExpr into;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 52;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				into?.RelocateImplInternal(_info);
				expr?.RelocateImplInternal(_info);
			}
		}

		[RecordCtor]
		public Def([MappedMember("expr")] TExpr expr, [MappedMember("into")] TExpr into)
		{
			this.expr = expr;
			this.into = into;
		}

		[RecordCtor]
		public Def(TypeVar ty, [MappedMember("expr")] TExpr expr, [MappedMember("into")] TExpr into)
			: base(ty)
		{
			this.expr = expr;
			this.into = into;
		}

		[RecordCtor]
		public Def(Location loc, TypeVar ty, [MappedMember("expr")] TExpr expr, [MappedMember("into")] TExpr into)
			: base(loc, ty)
		{
			this.expr = expr;
			this.into = into;
		}
	}

	[VariantOption]
	public class Use : TExpr
	{
		public TExpr expr;

		public Def def_of;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 53;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				def_of?.RelocateImplInternal(_info);
				expr?.RelocateImplInternal(_info);
			}
		}

		[RecordCtor]
		public Use([MappedMember("expr")] TExpr expr, [MappedMember("def_of")] Def def_of)
		{
			this.expr = expr;
			this.def_of = def_of;
		}

		[RecordCtor]
		public Use(TypeVar ty, [MappedMember("expr")] TExpr expr, [MappedMember("def_of")] Def def_of)
			: base(ty)
		{
			this.expr = expr;
			this.def_of = def_of;
		}

		[RecordCtor]
		public Use(Location loc, TypeVar ty, [MappedMember("expr")] TExpr expr, [MappedMember("def_of")] Def def_of)
			: base(loc, ty)
		{
			this.expr = expr;
			this.def_of = def_of;
		}
	}

	private sealed class _N__N_lambda__109085__109095 : Function<TExpr, TExpr>
	{
		[SpecialName]
		public static readonly _N__N_lambda__109085__109095 Instance = new _N__N_lambda__109085__109095();

		[SpecialName]
		public sealed override TExpr apply(TExpr e)
		{
			if (e is PropertyMember || e is StaticPropertyRef || e is EventMember || e is StaticEventRef || e is ConstantObjectRef || e is Block || e is Delayed || e is Cache || e is CacheRef || e is Error)
			{
				if (!Message.SeenError)
				{
					string text = ("invalid TExpr after T2: " + Convert.ToString(e)).ToString();
					Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
				}
				throw new AssertionException("ncc\\typing\\TypedTree.n", 939, "", ("invalid TExpr after T2: " + Convert.ToString(e)).ToString());
			}
			if (e is Def || e is Use)
			{
				if (!Message.SeenError)
				{
					string text = ("invalid def/use TExpr after T2: " + Convert.ToString(e)).ToString();
					Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
				}
				throw new AssertionException("ncc\\typing\\TypedTree.n", 942, "", ("invalid def/use TExpr after T2: " + Convert.ToString(e)).ToString());
			}
			return null;
		}
	}

	private sealed class _N__N_lambda__109118__109129 : Function<TExpr, TExpr>
	{
		[SpecialName]
		public static readonly _N__N_lambda__109118__109129 Instance = new _N__N_lambda__109118__109129();

		[SpecialName]
		public sealed override TExpr apply(TExpr e)
		{
			switch (_N_GetVariantCodeSafe(e))
			{
			default:
				if (e is Def || e is Use)
				{
					if (!Message.SeenError)
					{
						string text = ("invalid def/use TExpr after T3: " + Convert.ToString(e)).ToString();
						Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
					}
					throw new AssertionException("ncc\\typing\\TypedTree.n", 967, "", ("invalid def/use TExpr after T3: " + Convert.ToString(e)).ToString());
				}
				return null;
			case 29:
			case 30:
			case 31:
			case 32:
			case 33:
			case 34:
			case 35:
			case 36:
			case 37:
			case 38:
				if (!Message.SeenError)
				{
					string text = ("invalid TExpr after T3(T2): " + Convert.ToString(e)).ToString();
					Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
				}
				throw new AssertionException("ncc\\typing\\TypedTree.n", 961, "", ("invalid TExpr after T3(T2): " + Convert.ToString(e)).ToString());
			case 39:
			case 40:
			case 41:
			case 42:
				if (!Message.SeenError)
				{
					string text = ("invalid TExpr after T3: " + Convert.ToString(e)).ToString();
					Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
				}
				throw new AssertionException("ncc\\typing\\TypedTree.n", 965, "", ("invalid TExpr after T3: " + Convert.ToString(e)).ToString());
			}
		}
	}

	private sealed class _N_static_proxy_109402 : Function<TExpr, TExpr>
	{
		[SpecialName]
		public static readonly _N_static_proxy_109402 single_instance = new _N_static_proxy_109402();

		[SpecialName]
		public sealed override TExpr apply(TExpr _N_sp_parm_109409)
		{
			return do_copy(_N_sp_parm_109409);
		}

		private _N_static_proxy_109402()
		{
		}
	}

	private sealed class _N_closureOf_do_walk_109720
	{
		internal Function<TExpr, TExpr> _N_f_109725;

		internal _N_closureOf_do_walk_109720()
		{
		}
	}

	private sealed class _N_walk_case__109791 : Function<Try_case, Try_case>
	{
		[SpecialName]
		private _N_closureOf_do_walk_109720 _N_do_walk_closure_109795;

		public _N_walk_case__109791(_N_closureOf_do_walk_109720 _N_do_walk_closure_109795)
		{
			this._N_do_walk_closure_109795 = _N_do_walk_closure_109795;
		}

		[SpecialName]
		public sealed override Try_case apply(Try_case @case)
		{
			object result;
			if (@case is Try_case.Fault)
			{
				TExpr handler = ((Try_case.Fault)@case).handler;
				result = new Try_case.Fault(walk(_N_do_walk_closure_109795._N_f_109725, handler));
			}
			else if (@case is Try_case.Catch)
			{
				LocalValue exn = ((Try_case.Catch)@case).exn;
				TExpr handler = ((Try_case.Catch)@case).handler;
				result = new Try_case.Catch(exn, walk(_N_do_walk_closure_109795._N_f_109725, handler));
			}
			else
			{
				if (!(@case is Try_case.Filter))
				{
					throw new MatchFailureException();
				}
				LocalValue exn = ((Try_case.Filter)@case).exn;
				TExpr handler = ((Try_case.Filter)@case).filter;
				TExpr handler2 = ((Try_case.Filter)@case).handler;
				result = new Try_case.Filter(exn, walk(_N_do_walk_closure_109795._N_f_109725, handler), walk(_N_do_walk_closure_109795._N_f_109725, handler2));
			}
			return (Try_case)result;
		}
	}

	private sealed class _N__N_lambda__109643__109844 : Function<LocalValue, TExpr, Nemerle.Builtins.Tuple<LocalValue, TExpr>>
	{
		[SpecialName]
		private _N_closureOf_do_walk_109720 _N_do_walk_closure_109848;

		public _N__N_lambda__109643__109844(_N_closureOf_do_walk_109720 _N_do_walk_closure_109848)
		{
			this._N_do_walk_closure_109848 = _N_do_walk_closure_109848;
		}

		[SpecialName]
		public sealed override Nemerle.Builtins.Tuple<LocalValue, TExpr> apply(LocalValue v, TExpr e)
		{
			return new Nemerle.Builtins.Tuple<LocalValue, TExpr>(v, walk(_N_do_walk_closure_109848._N_f_109725, e));
		}
	}

	private sealed class _N__N_lambda__109611__109862 : Function<LocalValue, TExpr, Nemerle.Builtins.Tuple<LocalValue, TExpr>>
	{
		[SpecialName]
		private _N_closureOf_do_walk_109720 _N_do_walk_closure_109866;

		public _N__N_lambda__109611__109862(_N_closureOf_do_walk_109720 _N_do_walk_closure_109866)
		{
			this._N_do_walk_closure_109866 = _N_do_walk_closure_109866;
		}

		[SpecialName]
		public sealed override Nemerle.Builtins.Tuple<LocalValue, TExpr> apply(LocalValue s, TExpr t)
		{
			return new Nemerle.Builtins.Tuple<LocalValue, TExpr>(s, walk(_N_do_walk_closure_109866._N_f_109725, t));
		}
	}

	private sealed class _N__N_lambda__109663__109889 : Function<int, TExpr, Nemerle.Builtins.Tuple<int, TExpr>>
	{
		[SpecialName]
		private _N_closureOf_do_walk_109720 _N_do_walk_closure_109893;

		public _N__N_lambda__109663__109889(_N_closureOf_do_walk_109720 _N_do_walk_closure_109893)
		{
			this._N_do_walk_closure_109893 = _N_do_walk_closure_109893;
		}

		[SpecialName]
		public sealed override Nemerle.Builtins.Tuple<int, TExpr> apply(int n, TExpr e)
		{
			return new Nemerle.Builtins.Tuple<int, TExpr>(n, walk(_N_do_walk_closure_109893._N_f_109725, e));
		}
	}

	private TypeVar _ty;

	private TExprFlags flags;

	public TypeVar ty
	{
		[DebuggerStepThrough]
		get
		{
			return _ty;
		}
		[DebuggerStepThrough]
		set
		{
			_ty = value;
		}
	}

	public TypeVar Type
	{
		[DebuggerStepThrough]
		get
		{
			return (ty != null) ? ty : GetType(ManagerClass.Instance);
		}
		internal set
		{
			if (this is DebugInfo)
			{
				TExpr expr = ((DebugInfo)this).expr;
				if (expr != null)
				{
					expr.ty = value;
				}
			}
			ty = value;
		}
	}

	internal bool Throws
	{
		get
		{
			if ((flags & TExprFlags.ThrowsComputed) == 0)
			{
				if (!Message.SeenError)
				{
					Message.Debug("Internal compiler error, please report a bug to bugs.nemerle.org. You can try modifying program near this location.");
				}
				throw new AssertionException("ncc\\typing\\TypedTree.n", 984, ((flags & TExprFlags.ThrowsComputed) != 0).ToString(), "throws not computed for " + Convert.ToString(this));
			}
			return (flags & TExprFlags.Throws) != 0;
		}
		set
		{
			if ((flags & TExprFlags.ThrowsComputed) != 0)
			{
				if (!Message.SeenError)
				{
					Message.Debug("Internal compiler error, please report a bug to bugs.nemerle.org. You can try modifying program near this location.");
				}
				throw new AssertionException("ncc\\typing\\TypedTree.n", 990, ((flags & TExprFlags.ThrowsComputed) == 0).ToString(), "throws already computed for " + Convert.ToString(this));
			}
			if (value)
			{
				flags |= TExprFlags.Throws;
			}
			else
			{
				flags &= ~TExprFlags.Throws;
			}
			flags |= TExprFlags.ThrowsComputed;
		}
	}

	internal bool NeedsEmptyStack
	{
		get
		{
			if ((flags & TExprFlags.NeedsEmptyStackComputed) == 0)
			{
				if (!Message.SeenError)
				{
					Message.Debug("Internal compiler error, please report a bug to bugs.nemerle.org. You can try modifying program near this location.");
				}
				throw new AssertionException("ncc\\typing\\TypedTree.n", 1004, ((flags & TExprFlags.NeedsEmptyStackComputed) != 0).ToString(), "NeedsEmptyStack not computed for " + Convert.ToString(this));
			}
			return (flags & TExprFlags.NeedsEmptyStack) != 0;
		}
		set
		{
			if ((flags & TExprFlags.NeedsEmptyStackComputed) != 0)
			{
				if (!Message.SeenError)
				{
					Message.Debug("Internal compiler error, please report a bug to bugs.nemerle.org. You can try modifying program near this location.");
				}
				throw new AssertionException("ncc\\typing\\TypedTree.n", 1010, ((flags & TExprFlags.NeedsEmptyStackComputed) == 0).ToString(), "NeedsEmptyStack already computed for " + Convert.ToString(this));
			}
			if (value)
			{
				flags |= TExprFlags.NeedsEmptyStack;
			}
			else
			{
				flags &= ~TExprFlags.NeedsEmptyStack;
			}
			flags |= TExprFlags.NeedsEmptyStackComputed;
		}
	}

	internal bool NeedsConstrained
	{
		get
		{
			return (flags & TExprFlags.Constrained) != 0;
		}
		set
		{
			if (value)
			{
				flags |= TExprFlags.Constrained;
			}
		}
	}

	internal bool IsAddressable
	{
		get
		{
			bool result;
			if (this is DebugInfo)
			{
				TExpr expr = ((DebugInfo)this).expr;
				result = expr.IsAddressable;
				goto IL_00f9;
			}
			if ((flags & TExprFlags.AddressableComputed) == 0)
			{
				if (this is StaticRef || this is LocalRef)
				{
					goto IL_00d2;
				}
				if (this is FieldMember)
				{
					TExpr expr = ((FieldMember)this).obj;
					IField fld = ((FieldMember)this).fld;
					if (fld.DeclaringType.IsValueType)
					{
						IsAddressable = expr.IsAddressable;
					}
					else
					{
						IsAddressable = true;
					}
				}
				else
				{
					if (this is This || this is ArrayIndexer || this is PointerIndexer)
					{
						goto IL_00d2;
					}
					IsAddressable = false;
				}
			}
			goto IL_00ea;
			IL_00ea:
			result = (flags & TExprFlags.Addressable) != 0;
			goto IL_00f9;
			IL_00d2:
			IsAddressable = true;
			goto IL_00ea;
			IL_00f9:
			return result;
		}
		set
		{
			if ((flags & TExprFlags.AddressableComputed) != 0)
			{
				if (!Message.SeenError)
				{
					Message.Debug("Internal compiler error, please report a bug to bugs.nemerle.org. You can try modifying program near this location.");
				}
				throw new AssertionException("ncc\\typing\\TypedTree.n", 1053, ((flags & TExprFlags.AddressableComputed) == 0).ToString(), "");
			}
			if (value)
			{
				flags |= TExprFlags.Addressable;
			}
			else
			{
				flags &= ~TExprFlags.Addressable;
			}
			flags |= TExprFlags.AddressableComputed;
		}
	}

	internal bool NeedAddress => (flags & TExprFlags.NeedAddress) != 0;

	internal bool SkipWriteCheck
	{
		get
		{
			return (flags & TExprFlags.SkipWriteCheck) != 0;
		}
		set
		{
			if (value)
			{
				flags |= TExprFlags.SkipWriteCheck;
			}
			else
			{
				flags &= ~TExprFlags.SkipWriteCheck;
			}
		}
	}

	internal bool GenerateTail
	{
		get
		{
			return (flags & TExprFlags.GenerateTail) != 0;
		}
		set
		{
			if (value)
			{
				flags |= TExprFlags.GenerateTail;
			}
			else
			{
				flags &= ~TExprFlags.GenerateTail;
			}
		}
	}

	internal bool Visited
	{
		get
		{
			return (flags & TExprFlags.Visited) != 0;
		}
		set
		{
			if (value)
			{
				flags |= TExprFlags.Visited;
			}
			else
			{
				flags &= ~TExprFlags.Visited;
			}
		}
	}

	internal bool JumpTarget
	{
		get
		{
			return (flags & TExprFlags.JumpTarget) != 0;
		}
		set
		{
			if (value)
			{
				flags |= TExprFlags.JumpTarget;
			}
			else
			{
				flags &= ~TExprFlags.JumpTarget;
			}
		}
	}

	internal bool IsAssigned
	{
		get
		{
			return (flags & TExprFlags.IsAssigned) != 0;
		}
		set
		{
			if (value)
			{
				flags |= TExprFlags.IsAssigned;
			}
			else
			{
				flags &= ~TExprFlags.IsAssigned;
			}
		}
	}

	internal void CheckAfterT2()
	{
		Function<TExpr, TExpr> instance = _N__N_lambda__109085__109095.Instance;
		TExpr tExpr = Walk(instance);
	}

	internal void CheckAfterT3()
	{
		Function<TExpr, TExpr> instance = _N__N_lambda__109118__109129.Instance;
		TExpr tExpr = Walk(instance);
	}

	internal bool setNeedAddress(bool from_ctor)
	{
		if (NeedAddress)
		{
			if (!Message.SeenError)
			{
				Message.Debug("Internal compiler error, please report a bug to bugs.nemerle.org. You can try modifying program near this location.");
			}
			throw new AssertionException("ncc\\typing\\TypedTree.n", 1071, (!NeedAddress).ToString(), "");
		}
		if (this is StaticRef || this is LocalRef)
		{
			goto IL_017c;
		}
		int result;
		if (this is FieldMember)
		{
			TExpr obj;
			IField fld;
			bool flag;
			if (((FieldMember)this).obj is This)
			{
				obj = ((FieldMember)this).obj;
				fld = ((FieldMember)this).fld;
				flag = from_ctor || fld.IsMutable;
			}
			else
			{
				obj = ((FieldMember)this).obj;
				fld = ((FieldMember)this).fld;
				flag = fld.IsMutable || (fld.Attributes & NemerleModifiers.CompilerMutable) != 0;
			}
			if (flag)
			{
				flags |= TExprFlags.NeedAddress;
				result = ((!fld.DeclaringType.IsValueType || obj.NeedAddress || obj.setNeedAddress(from_ctor)) ? 1 : 0);
			}
			else
			{
				result = 0;
			}
		}
		else
		{
			if (this is This || this is ArrayIndexer || this is PointerIndexer)
			{
				goto IL_017c;
			}
			if (this is DebugInfo)
			{
				TExpr obj = ((DebugInfo)this).expr;
				if (obj.setNeedAddress(from_ctor))
				{
					flags |= TExprFlags.NeedAddress;
					result = 1;
				}
				else
				{
					result = 0;
				}
			}
			else
			{
				result = 0;
			}
		}
		goto IL_01d0;
		IL_01d0:
		return (byte)result != 0;
		IL_017c:
		flags |= TExprFlags.NeedAddress;
		result = 1;
		goto IL_01d0;
	}

	public TypeVar GetType(ManagerClass manager)
	{
		if (ty == null)
		{
			TryInitType(manager);
			if (ty == null)
			{
				if (manager.IsIntelliSenseMode)
				{
					ty = manager.Solver.FreshTypeVar();
				}
				else if (ty != null)
				{
				}
			}
		}
		return ty;
	}

	public void TryInitType(ManagerClass manager)
	{
		if (this is DebugInfo)
		{
			TExpr expr = ((DebugInfo)this).expr;
			if (expr != null)
			{
				ty = expr.GetType(manager);
				return;
			}
		}
		if (ty != null)
		{
			return;
		}
		InternalTypeClass internalType = manager.InternalType;
		if (this is Assign)
		{
			ty = internalType.Void;
			return;
		}
		if (!(this is Throw))
		{
			if (this is Literal)
			{
				Nemerle.Compiler.Literal val = ((Literal)this).val;
				ty = val.GetInternalType(internalType);
				return;
			}
			if (this is TypeOf)
			{
				ty = internalType.Type;
				return;
			}
			if (this is MethodOf)
			{
				ty = internalType.MethodInfo;
				return;
			}
			if (this is CtorOf)
			{
				ty = internalType.ConstructorInfo;
				return;
			}
			if (this is MacroEnvelope)
			{
				TExpr expr = ((MacroEnvelope)this).expanded;
				ty = expr.GetType(manager);
				return;
			}
			if (this is Cache)
			{
				Cache cache = (Cache)this;
				if (cache.body == null)
				{
				}
				ty = cache.body.GetType(manager);
				return;
			}
			if (!(this is Error) && !(this is Goto))
			{
				if (this is HasType)
				{
					ty = internalType.Boolean;
				}
				return;
			}
		}
		ty = manager.Solver.FreshTypeVar();
	}

	public FixedType FixedType()
	{
		return Type.Fix();
	}

	public Type GetSystemType()
	{
		return Type.GetSystemType();
	}

	public TExpr()
	{
	}

	public TExpr(TypeVar ty)
	{
		this.ty = ty;
	}

	public TExpr(Location loc, TypeVar ty)
		: base(loc)
	{
		this.ty = ty;
	}

	public override string ToString()
	{
		return PrettyPrint.SprintTyExpr(this);
	}

	public TExpr Copy()
	{
		return Walk(_N_static_proxy_109402.single_instance);
	}

	private static TExpr do_copy(TExpr expr)
	{
		object result;
		if (expr is StaticRef)
		{
			FixedType.Class from = ((StaticRef)expr).from;
			IMember mem = ((StaticRef)expr).mem;
			list<TypeVar> type_parms = ((StaticRef)expr).type_parms;
			result = new StaticRef(from, mem, type_parms);
		}
		else if (expr is LocalRef)
		{
			LocalValue decl = ((LocalRef)expr).decl;
			result = new LocalRef(decl);
		}
		else if (expr is ImplicitValueTypeCtor)
		{
			result = new ImplicitValueTypeCtor();
		}
		else if (expr is Literal)
		{
			Nemerle.Compiler.Literal val = ((Literal)expr).val;
			result = new Literal(val);
		}
		else if (expr is This)
		{
			result = new This();
		}
		else if (expr is Base)
		{
			IMethod base_ctor = ((Base)expr).base_ctor;
			result = new Base(base_ctor);
		}
		else if (expr is TypeOf)
		{
			TypeVar target_type = ((TypeOf)expr).target_type;
			result = new TypeOf(target_type);
		}
		else if (expr is MethodOf)
		{
			TypeVar target_type = ((MethodOf)expr).from_type;
			IMethod base_ctor = ((MethodOf)expr).method;
			list<TypeVar> type_parms = ((MethodOf)expr).typars;
			result = new MethodOf(target_type, base_ctor, type_parms);
		}
		else if (expr is CtorOf)
		{
			TypeVar target_type = ((CtorOf)expr).type;
			IMethod base_ctor = ((CtorOf)expr).method;
			result = new CtorOf(target_type, base_ctor);
		}
		else if (expr is FieldOf)
		{
			TypeVar target_type = ((FieldOf)expr).type;
			IField field = ((FieldOf)expr).field;
			result = new FieldOf(target_type, field);
		}
		else if (expr is ClosureObjectOf)
		{
			TExpr varRef = ((ClosureObjectOf)expr).varRef;
			result = new ClosureObjectOf(varRef);
		}
		else if (expr is ClosureFieldOf)
		{
			TExpr varRef = ((ClosureFieldOf)expr).varRef;
			result = new ClosureFieldOf(varRef);
		}
		else if (expr is OpCode)
		{
			string name = ((OpCode)expr).name;
			result = new OpCode(name);
		}
		else if (expr is ConstantObjectRef)
		{
			FixedType.Class from = ((ConstantObjectRef)expr).from;
			IField field = ((ConstantObjectRef)expr).mem;
			result = new ConstantObjectRef(from, field);
		}
		else if (expr is MethodAddress)
		{
			TypeVar target_type = ((MethodAddress)expr).from;
			IMethod base_ctor = ((MethodAddress)expr).meth;
			bool is_virt = ((MethodAddress)expr).is_virt;
			list<TypeVar> type_parms = ((MethodAddress)expr).type_parms;
			result = new MethodAddress(target_type, base_ctor, is_virt, type_parms);
		}
		else if (!(expr is Goto))
		{
			result = ((!(expr is DefaultValue)) ? null : new DefaultValue());
		}
		else
		{
			int target = ((Goto)expr).target;
			int try_block = ((Goto)expr).try_block;
			result = new Goto(target, try_block);
		}
		return (TExpr)result;
	}

	private static TExpr walk(Function<TExpr, TExpr> f, TExpr expr)
	{
		Location location = expr.Location;
		bool flag = location.FileIndex != 0;
		if (flag)
		{
			LocationStack.Push(location);
		}
		TExpr tExpr3;
		try
		{
			TExpr tExpr = f.apply(expr);
			TExpr tExpr2 = ((tExpr != null) ? tExpr : do_walk(f, expr));
			tExpr3 = ((tExpr2 != null) ? tExpr2 : expr);
		}
		finally
		{
			if (flag)
			{
				LocationStack.RemoveTop();
			}
		}
		TExpr tExpr4 = tExpr3;
		if (tExpr4.ty == null)
		{
			tExpr4.ty = expr.ty;
		}
		return tExpr4;
	}

	private static TExpr null_walk(Function<TExpr, TExpr> f, TExpr expr)
	{
		Location location = expr.Location;
		bool flag = location.FileIndex != 0;
		if (flag)
		{
			LocationStack.Push(location);
		}
		TExpr tExpr2;
		try
		{
			TExpr tExpr = f.apply(expr);
			tExpr2 = ((tExpr != null) ? tExpr : do_walk(f, expr));
		}
		finally
		{
			if (flag)
			{
				LocationStack.RemoveTop();
			}
		}
		TExpr tExpr3 = tExpr2;
		if (tExpr3 != null && tExpr3.ty == null)
		{
			tExpr3.ty = expr.ty;
		}
		return tExpr3;
	}

	private static list<TExpr> walks(Function<TExpr, TExpr> f, list<TExpr> exprs)
	{
		int num = 0;
		TExpr tExpr = null;
		int num2 = 0;
		num = 0;
		num2 = 0;
		tExpr = null;
		list<TExpr> list = exprs;
		checked
		{
			while (list is list<TExpr>.Cons)
			{
				TExpr hd = ((list<TExpr>.Cons)list).hd;
				list = ((list<TExpr>.Cons)list).tl;
				if (tExpr == null)
				{
					hd = null_walk(f, hd);
					if (hd != null)
					{
						tExpr = hd;
					}
					num++;
				}
				num2++;
				list = list;
			}
			list<TExpr> result;
			if (tExpr == null)
			{
				result = exprs;
			}
			else
			{
				list<TExpr> tl = list<TExpr>.Nil._N_constant_object;
				num = num2 - num;
				list = exprs.Rev();
				while (true)
				{
					if (list is list<TExpr>.Cons)
					{
						TExpr hd = ((list<TExpr>.Cons)list).hd;
						list = ((list<TExpr>.Cons)list).tl;
						if (num == 0)
						{
							break;
						}
						list<TExpr> obj = new list<TExpr>.Cons(walk(f, hd), tl);
						int num3 = num - 1;
						list = list;
						num = num3;
						tl = obj;
						continue;
					}
					if ((object)list == list<TExpr>.Nil._N_constant_object)
					{
						if (!Message.SeenError)
						{
							string text = "(see backtrace)".ToString();
							Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
						}
						throw new AssertionException("ncc\\typing\\TypedTree.n", 1281, "", "(see backtrace)");
					}
					throw new MatchFailureException();
				}
				result = list.RevAppend(new list<TExpr>.Cons(tExpr, tl));
			}
			return result;
		}
	}

	private static TExpr do_walk(Function<TExpr, TExpr> f, TExpr expr)
	{
		list<Parm> list = null;
		list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>> list2 = null;
		_N_closureOf_do_walk_109720 n_closureOf_do_walk_ = new _N_closureOf_do_walk_109720();
		n_closureOf_do_walk_._N_f_109725 = f;
		object result;
		switch (_N_GetVariantCodeSafe(expr))
		{
		default:
			throw new MatchFailureException();
		case 3:
		{
			TExpr tExpr = ((FieldMember)expr).obj;
			IField fld = ((FieldMember)expr).fld;
			tExpr = null_walk(n_closureOf_do_walk_._N_f_109725, tExpr);
			result = ((tExpr != null) ? new FieldMember(tExpr, fld) : null);
			break;
		}
		case 4:
		{
			TExpr tExpr = ((MethodRef)expr).obj;
			IMethod meth = ((MethodRef)expr).meth;
			list<TypeVar> type_parms = ((MethodRef)expr).type_parms;
			bool is_tail = ((MethodRef)expr).notvirtual;
			tExpr = null_walk(n_closureOf_do_walk_._N_f_109725, tExpr);
			result = ((tExpr != null) ? new MethodRef(tExpr, meth, type_parms, is_tail) : null);
			break;
		}
		case 5:
		{
			TExpr tExpr = ((Call)expr).func;
			list<Parm> list7 = ((Call)expr).parms;
			bool is_tail = ((Call)expr).is_tail;
			tExpr = walk(n_closureOf_do_walk_._N_f_109725, tExpr);
			list = list<Parm>.Nil._N_constant_object;
			list7 = list7;
			while (list7 is list<Parm>.Cons)
			{
				Parm hd2 = ((list<Parm>.Cons)list7).hd;
				list7 = ((list<Parm>.Cons)list7).tl;
				hd2 = hd2;
				list = new list<Parm>.Cons(new Parm(hd2.kind, walk(n_closureOf_do_walk_._N_f_109725, hd2.expr), hd2.name, hd2.required_type), list);
				list7 = list7;
			}
			result = new Call(tExpr, list.Rev(), is_tail);
			break;
		}
		case 6:
		{
			TExpr tExpr = ((Assign)expr).target;
			TExpr expr2 = ((Assign)expr).source;
			TExpr tExpr2 = walk(n_closureOf_do_walk_._N_f_109725, tExpr);
			TExpr tExpr3 = walk(n_closureOf_do_walk_._N_f_109725, expr2);
			result = ((tExpr2 != tExpr || tExpr3 != expr2) ? new Assign(tExpr2, tExpr3) : null);
			break;
		}
		case 7:
		{
			LocalValue name = ((DefValIn)expr).name;
			TExpr tExpr = ((DefValIn)expr).val;
			TExpr expr2 = ((DefValIn)expr).body;
			TExpr tExpr2 = walk(n_closureOf_do_walk_._N_f_109725, tExpr);
			TExpr tExpr3 = walk(n_closureOf_do_walk_._N_f_109725, expr2);
			result = ((tExpr2 != tExpr || tExpr3 != expr2) ? new DefValIn(name, tExpr2, tExpr3) : null);
			break;
		}
		case 8:
		{
			TExpr tExpr = ((Throw)expr).exn;
			if (tExpr != null)
			{
				tExpr = null_walk(n_closureOf_do_walk_._N_f_109725, tExpr);
				result = ((tExpr != null) ? new Throw(tExpr) : null);
			}
			else
			{
				result = null;
			}
			break;
		}
		case 9:
		{
			TExpr tExpr = ((TryFinally)expr).body;
			TExpr expr2 = ((TryFinally)expr).handler;
			result = new TryFinally(walk(n_closureOf_do_walk_._N_f_109725, tExpr), walk(n_closureOf_do_walk_._N_f_109725, expr2));
			break;
		}
		case 10:
		{
			TExpr tExpr = ((Try)expr).body;
			list<Try_case> list6 = ((Try)expr).cases;
			Function<Try_case, Try_case> convert2 = new _N_walk_case__109791(n_closureOf_do_walk_);
			result = new Try(walk(n_closureOf_do_walk_._N_f_109725, tExpr), list6.Map(convert2));
			break;
		}
		case 14:
		{
			TExpr tExpr = ((TypeConversion)expr).expr;
			TypeVar target_type = ((TypeConversion)expr).target_type;
			ConversionKind kind = ((TypeConversion)expr).kind;
			Location target_type_location = ((TypeConversion)expr).target_type_location;
			tExpr = null_walk(n_closureOf_do_walk_._N_f_109725, tExpr);
			result = ((tExpr != null) ? new TypeConversion(tExpr, target_type, kind, target_type_location) : null);
			break;
		}
		case 15:
		{
			TExpr tExpr = ((Sequence)expr).e1;
			TExpr tExpr3 = ((Sequence)expr).e2;
			TExpr tExpr2 = walk(n_closureOf_do_walk_._N_f_109725, tExpr);
			TExpr expr2 = walk(n_closureOf_do_walk_._N_f_109725, tExpr3);
			result = ((tExpr2 != tExpr || expr2 != tExpr3) ? new Sequence(tExpr2, expr2) : null);
			break;
		}
		case 16:
		{
			list<TExpr> exprs = ((Tuple)expr).args;
			result = new Tuple(walks(n_closureOf_do_walk_._N_f_109725, exprs));
			break;
		}
		case 17:
		{
			list<TExpr> exprs = ((Array)expr).args;
			list<TExpr> exprs2 = ((Array)expr).dimensions;
			result = new Array(walks(n_closureOf_do_walk_._N_f_109725, exprs), walks(n_closureOf_do_walk_._N_f_109725, exprs2));
			break;
		}
		case 22:
		{
			TExpr tExpr = ((ClosureObjectOf)expr).varRef;
			result = new ClosureObjectOf(walk(n_closureOf_do_walk_._N_f_109725, tExpr));
			break;
		}
		case 23:
		{
			TExpr tExpr = ((ClosureFieldOf)expr).varRef;
			result = new ClosureFieldOf(walk(n_closureOf_do_walk_._N_f_109725, tExpr));
			break;
		}
		case 24:
		{
			TExpr tExpr = ((ArrayIndexer)expr).obj;
			list<TExpr> exprs = ((ArrayIndexer)expr).args;
			result = new ArrayIndexer(walk(n_closureOf_do_walk_._N_f_109725, tExpr), walks(n_closureOf_do_walk_._N_f_109725, exprs));
			break;
		}
		case 25:
		{
			TExpr tExpr = ((PointerIndexer)expr).obj;
			TExpr expr2 = ((PointerIndexer)expr).index;
			result = new PointerIndexer(walk(n_closureOf_do_walk_._N_f_109725, tExpr), walk(n_closureOf_do_walk_._N_f_109725, expr2));
			break;
		}
		case 26:
		{
			TExpr tExpr = ((TupleIndexer)expr).obj;
			int pos = ((TupleIndexer)expr).pos;
			int len = ((TupleIndexer)expr).len;
			tExpr = null_walk(n_closureOf_do_walk_._N_f_109725, tExpr);
			result = ((tExpr != null) ? new TupleIndexer(tExpr, pos, len) : null);
			break;
		}
		case 28:
		{
			PExpr original = ((MacroEnvelope)expr).original;
			IMacro the_macro = ((MacroEnvelope)expr).the_macro;
			TExpr tExpr = ((MacroEnvelope)expr).expanded;
			PExpr pexpr = ((MacroEnvelope)expr).expandedPExpr;
			tExpr = null_walk(n_closureOf_do_walk_._N_f_109725, tExpr);
			result = ((tExpr != null) ? new MacroEnvelope(original, the_macro, tExpr, pexpr) : null);
			break;
		}
		case 29:
		case 30:
		case 31:
		case 32:
		case 34:
		case 35:
		case 36:
		case 37:
			Message.Warning(expr.Location, "invalid expr in walk: " + Convert.ToString(expr.GetType()) + ": " + Convert.ToString(expr));
			throw new AssertionException("ncc\\typing\\TypedTree.n", 1302, "", "");
		case 39:
		{
			list<TFunHeader> list3 = ((DefFunctionsIn)expr).funs;
			TExpr tExpr = ((DefFunctionsIn)expr).body;
			list<TFunHeader> list4 = list3;
			while (list4 is list<TFunHeader>.Cons)
			{
				TFunHeader hd = ((list<TFunHeader>.Cons)list4).hd;
				list4 = ((list<TFunHeader>.Cons)list4).tl;
				hd = hd;
				FunBody body = hd.body;
				if (body is FunBody.Typed)
				{
					TExpr expr2 = ((FunBody.Typed)body).expr;
					hd.body = new FunBody.Typed(walk(n_closureOf_do_walk_._N_f_109725, expr2));
				}
				list4 = list4;
			}
			result = new DefFunctionsIn(list3, walk(n_closureOf_do_walk_._N_f_109725, tExpr));
			break;
		}
		case 40:
		{
			TExpr tExpr = ((Match)expr).expr;
			list<Match_case> list10 = ((Match)expr).cases;
			list<Match_case> list11 = list10;
			while (list11 is list<Match_case>.Cons)
			{
				Match_case hd3 = ((list<Match_case>.Cons)list11).hd;
				list11 = ((list<Match_case>.Cons)list11).tl;
				hd3 = hd3;
				list2 = list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Nil._N_constant_object;
				list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>> list12 = hd3.patterns;
				while (list12 is list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons)
				{
					Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>> hd4 = ((list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons)list12).hd;
					list12 = ((list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons)list12).tl;
					Pattern field = hd4.Field0;
					TExpr expr2 = hd4.Field1;
					list<Nemerle.Builtins.Tuple<LocalValue, TExpr>> list8 = hd4.Field2;
					list<Nemerle.Builtins.Tuple<LocalValue, TExpr>> list13 = list8;
					Function<LocalValue, TExpr, Nemerle.Builtins.Tuple<LocalValue, TExpr>> convert3 = new _N__N_lambda__109643__109844(n_closureOf_do_walk_);
					list8 = list13.Map(convert3);
					list2 = new list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons(new Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>(field, walk(n_closureOf_do_walk_._N_f_109725, expr2), list8), list2);
					list12 = list12;
				}
				hd3.patterns = list2.Rev();
				hd3.body = walk(n_closureOf_do_walk_._N_f_109725, hd3.body);
				list11 = list11;
			}
			tExpr = null_walk(n_closureOf_do_walk_._N_f_109725, tExpr);
			result = ((tExpr != null) ? new Match(tExpr, list10) : null);
			break;
		}
		case 41:
		{
			list<Parm> list7 = ((SelfTailCall)expr).parms;
			list7 = list7;
			while (list7 is list<Parm>.Cons)
			{
				Parm hd2 = ((list<Parm>.Cons)list7).hd;
				list7 = ((list<Parm>.Cons)list7).tl;
				hd2 = hd2;
				hd2.expr = walk(n_closureOf_do_walk_._N_f_109725, hd2.expr);
				list7 = list7;
			}
			result = null;
			break;
		}
		case 44:
		{
			list<Nemerle.Builtins.Tuple<LocalValue, TExpr>> list8 = ((MultipleAssign)expr).assigns;
			list<Nemerle.Builtins.Tuple<LocalValue, TExpr>> list9 = list8;
			Function<LocalValue, TExpr, Nemerle.Builtins.Tuple<LocalValue, TExpr>> convert3 = new _N__N_lambda__109611__109862(n_closureOf_do_walk_);
			result = new MultipleAssign(list9.Map(convert3));
			break;
		}
		case 45:
		{
			int len = ((Label)expr).id;
			TExpr tExpr = ((Label)expr).body;
			tExpr = null_walk(n_closureOf_do_walk_._N_f_109725, tExpr);
			result = ((tExpr != null) ? new Label(len, tExpr) : null);
			break;
		}
		case 0:
		case 1:
		case 2:
		case 11:
		case 12:
		case 13:
		case 18:
		case 19:
		case 20:
		case 21:
		case 27:
		case 33:
		case 38:
		case 42:
		case 43:
		case 46:
		case 47:
			result = null;
			break;
		case 48:
		{
			TExpr tExpr = ((If)expr).cond;
			TExpr expr2 = ((If)expr).e_then;
			TExpr tExpr3 = ((If)expr).e_else;
			Location target_type_location = ((If)expr).then_debug_loc;
			Location else_debug_loc = ((If)expr).else_debug_loc;
			TExpr tExpr4 = walk(n_closureOf_do_walk_._N_f_109725, tExpr);
			TExpr tExpr5 = walk(n_closureOf_do_walk_._N_f_109725, expr2);
			TExpr tExpr2 = walk(n_closureOf_do_walk_._N_f_109725, tExpr3);
			result = ((tExpr4 != tExpr || tExpr5 != expr2 || tExpr2 != tExpr3) ? new If(tExpr4, tExpr5, tExpr2, target_type_location, else_debug_loc) : null);
			break;
		}
		case 49:
		{
			TExpr tExpr = ((HasType)expr).expr;
			FixedType test_ty = ((HasType)expr).test_ty;
			tExpr = null_walk(n_closureOf_do_walk_._N_f_109725, tExpr);
			result = ((tExpr != null) ? new HasType(tExpr, test_ty) : null);
			break;
		}
		case 50:
		{
			TExpr tExpr = ((Switch)expr).indexing_expr;
			option<TExpr> option = ((Switch)expr).@default;
			list<Nemerle.Builtins.Tuple<int, TExpr>> list5 = ((Switch)expr).cases;
			TExpr indexing_expr = walk(n_closureOf_do_walk_._N_f_109725, tExpr);
			object obj;
			if (option is option<TExpr>.Some)
			{
				tExpr = ((option<TExpr>.Some)option).val;
				obj = new option<TExpr>.Some(walk(n_closureOf_do_walk_._N_f_109725, tExpr));
			}
			else
			{
				if (option != option<TExpr>.None._N_constant_object)
				{
					throw new MatchFailureException();
				}
				obj = option;
			}
			option<TExpr> @default = (option<TExpr>)obj;
			Function<int, TExpr, Nemerle.Builtins.Tuple<int, TExpr>> convert = new _N__N_lambda__109663__109889(n_closureOf_do_walk_);
			result = new Switch(indexing_expr, @default, list5.Map(convert));
			break;
		}
		case 51:
		{
			if ((object)((DebugInfo)expr).expr == null)
			{
				result = null;
				break;
			}
			TExpr expr2 = ((DebugInfo)expr).expr;
			PExpr pexpr = ((DebugInfo)expr).pexpr;
			TExpr tExpr = walk(n_closureOf_do_walk_._N_f_109725, expr2);
			result = ((tExpr != expr2) ? new DebugInfo(expr.Location, tExpr.ty, tExpr, pexpr) : null);
			break;
		}
		case 52:
		case 53:
			throw new AssertionException("ncc\\typing\\TypedTree.n", 1509, "", "");
		}
		return (TExpr)result;
	}

	public TExpr Walk(Function<TExpr, TExpr> f)
	{
		return walk(f, this);
	}

	public static TExpr BoolLiteral(ManagerClass mgr, bool val)
	{
		return new Literal(mgr.InternalType.Boolean, new Nemerle.Compiler.Literal.Bool(val));
	}

	public static TExpr TrueLiteral(ManagerClass mgr)
	{
		return BoolLiteral(mgr, val: true);
	}

	public static TExpr FalseLiteral(ManagerClass mgr)
	{
		return BoolLiteral(mgr, val: false);
	}

	[SpecialName]
	public abstract override int _N_GetVariantCode();

	[SpecialName]
	public static int _N_GetVariantCodeSafe(TExpr x)
	{
		return ((object)x != null) ? x._N_GetVariantCode() : (-1);
	}

	[SpecialName]
	public static int _N_GetVariantCodeObject(object x)
	{
		return (!(x is TExpr)) ? (-1) : ((TExpr)x)._N_GetVariantCode();
	}
}
