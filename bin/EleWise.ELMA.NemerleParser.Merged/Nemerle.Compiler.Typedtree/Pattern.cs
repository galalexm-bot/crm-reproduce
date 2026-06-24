using System;
using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Core;
using Nemerle.Internal;

namespace Nemerle.Compiler.Typedtree;

[Variant("Nemerle.Compiler.Typedtree.Pattern.Wildcard,Nemerle.Compiler.Typedtree.Pattern.As,Nemerle.Compiler.Typedtree.Pattern.HasType,Nemerle.Compiler.Typedtree.Pattern.Tuple,Nemerle.Compiler.Typedtree.Pattern.Record,Nemerle.Compiler.Typedtree.Pattern.Application,Nemerle.Compiler.Typedtree.Pattern.Enum,Nemerle.Compiler.Typedtree.Pattern.Literal,Nemerle.Compiler.Typedtree.Pattern.Error")]
public abstract class Pattern : TypedBase
{
	[VariantOption]
	public class Wildcard : Pattern
	{
		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 0;
		}

		[RecordCtor]
		public Wildcard()
		{
		}

		[RecordCtor]
		public Wildcard(Location loc)
			: base(loc)
		{
		}

		[RecordCtor]
		public Wildcard([MappedMember("ty")] TypeVar ty)
			: base(ty)
		{
		}

		[RecordCtor]
		public Wildcard(Location loc, [MappedMember("ty")] TypeVar ty)
			: base(loc, ty)
		{
		}
	}

	[VariantOption]
	public class As : Pattern
	{
		public readonly Pattern pat;

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
				pat?.RelocateImplInternal(_info);
			}
		}

		[RecordCtor]
		public As([MappedMember("pat")] Pattern pat, [MappedMember("decl")] LocalValue decl)
		{
			this.pat = pat;
			this.decl = decl;
		}

		[RecordCtor]
		public As(Location loc, [MappedMember("pat")] Pattern pat, [MappedMember("decl")] LocalValue decl)
			: base(loc)
		{
			this.pat = pat;
			this.decl = decl;
		}

		[RecordCtor]
		public As([MappedMember("ty")] TypeVar ty, [MappedMember("pat")] Pattern pat, [MappedMember("decl")] LocalValue decl)
			: base(ty)
		{
			this.pat = pat;
			this.decl = decl;
		}

		[RecordCtor]
		public As(Location loc, [MappedMember("ty")] TypeVar ty, [MappedMember("pat")] Pattern pat, [MappedMember("decl")] LocalValue decl)
			: base(loc, ty)
		{
			this.pat = pat;
			this.decl = decl;
		}
	}

	[VariantOption]
	public class HasType : Pattern
	{
		public readonly FixedType typ;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 2;
		}

		[RecordCtor]
		public HasType([MappedMember("typ")] FixedType typ)
		{
			this.typ = typ;
		}

		[RecordCtor]
		public HasType(Location loc, [MappedMember("typ")] FixedType typ)
			: base(loc)
		{
			this.typ = typ;
		}

		[RecordCtor]
		public HasType([MappedMember("ty")] TypeVar ty, [MappedMember("typ")] FixedType typ)
			: base(ty)
		{
			this.typ = typ;
		}

		[RecordCtor]
		public HasType(Location loc, [MappedMember("ty")] TypeVar ty, [MappedMember("typ")] FixedType typ)
			: base(loc, ty)
		{
			this.typ = typ;
		}
	}

	[VariantOption]
	public class Tuple : Pattern
	{
		public readonly list<Pattern> args;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 3;
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
			list<Pattern> list = args;
			if (list != null)
			{
				list = list;
				while (list is list<Pattern>.Cons)
				{
					Pattern hd = ((list<Pattern>.Cons)list).hd;
					list = ((list<Pattern>.Cons)list).tl;
					((ISupportRelocation)hd).RelocateImpl(_info);
					list = list;
				}
			}
		}

		[RecordCtor]
		public Tuple([MappedMember("args")] list<Pattern> args)
		{
			this.args = args;
		}

		[RecordCtor]
		public Tuple(Location loc, [MappedMember("args")] list<Pattern> args)
			: base(loc)
		{
			this.args = args;
		}

		[RecordCtor]
		public Tuple([MappedMember("ty")] TypeVar ty, [MappedMember("args")] list<Pattern> args)
			: base(ty)
		{
			this.args = args;
		}

		[RecordCtor]
		public Tuple(Location loc, [MappedMember("ty")] TypeVar ty, [MappedMember("args")] list<Pattern> args)
			: base(loc, ty)
		{
			this.args = args;
		}
	}

	[VariantOption]
	public class Record : Pattern
	{
		public readonly list<Nemerle.Builtins.Tuple<IMember, Pattern>> args;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 4;
		}

		[RecordCtor]
		public Record([MappedMember("args")] list<Nemerle.Builtins.Tuple<IMember, Pattern>> args)
		{
			this.args = args;
		}

		[RecordCtor]
		public Record(Location loc, [MappedMember("args")] list<Nemerle.Builtins.Tuple<IMember, Pattern>> args)
			: base(loc)
		{
			this.args = args;
		}

		[RecordCtor]
		public Record([MappedMember("ty")] TypeVar ty, [MappedMember("args")] list<Nemerle.Builtins.Tuple<IMember, Pattern>> args)
			: base(ty)
		{
			this.args = args;
		}

		[RecordCtor]
		public Record(Location loc, [MappedMember("ty")] TypeVar ty, [MappedMember("args")] list<Nemerle.Builtins.Tuple<IMember, Pattern>> args)
			: base(loc, ty)
		{
			this.args = args;
		}
	}

	[VariantOption]
	public class Application : Pattern
	{
		public readonly TypeInfo name;

		public readonly Pattern arg;

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
				arg?.RelocateImplInternal(_info);
			}
		}

		[RecordCtor]
		public Application([MappedMember("name")] TypeInfo name, [MappedMember("arg")] Pattern arg)
		{
			this.name = name;
			this.arg = arg;
		}

		[RecordCtor]
		public Application(Location loc, [MappedMember("name")] TypeInfo name, [MappedMember("arg")] Pattern arg)
			: base(loc)
		{
			this.name = name;
			this.arg = arg;
		}

		[RecordCtor]
		public Application([MappedMember("ty")] TypeVar ty, [MappedMember("name")] TypeInfo name, [MappedMember("arg")] Pattern arg)
			: base(ty)
		{
			this.name = name;
			this.arg = arg;
		}

		[RecordCtor]
		public Application(Location loc, [MappedMember("ty")] TypeVar ty, [MappedMember("name")] TypeInfo name, [MappedMember("arg")] Pattern arg)
			: base(loc, ty)
		{
			this.name = name;
			this.arg = arg;
		}
	}

	[VariantOption]
	public class Enum : Pattern
	{
		public readonly IField fld;

		public readonly Nemerle.Compiler.Literal val;

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
				val?.RelocateImplInternal(_info);
				IField field = fld;
				if (field != null)
				{
					((ISupportRelocation)field).RelocateImpl(_info);
				}
			}
		}

		[RecordCtor]
		public Enum([MappedMember("fld")] IField fld, [MappedMember("val")] Nemerle.Compiler.Literal val)
		{
			this.fld = fld;
			this.val = val;
		}

		[RecordCtor]
		public Enum(Location loc, [MappedMember("fld")] IField fld, [MappedMember("val")] Nemerle.Compiler.Literal val)
			: base(loc)
		{
			this.fld = fld;
			this.val = val;
		}

		[RecordCtor]
		public Enum([MappedMember("ty")] TypeVar ty, [MappedMember("fld")] IField fld, [MappedMember("val")] Nemerle.Compiler.Literal val)
			: base(ty)
		{
			this.fld = fld;
			this.val = val;
		}

		[RecordCtor]
		public Enum(Location loc, [MappedMember("ty")] TypeVar ty, [MappedMember("fld")] IField fld, [MappedMember("val")] Nemerle.Compiler.Literal val)
			: base(loc, ty)
		{
			this.fld = fld;
			this.val = val;
		}
	}

	[VariantOption]
	public class Literal : Pattern
	{
		public readonly Nemerle.Compiler.Literal lit;

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
				lit?.RelocateImplInternal(_info);
			}
		}

		[RecordCtor]
		public Literal([MappedMember("lit")] Nemerle.Compiler.Literal lit)
		{
			this.lit = lit;
		}

		[RecordCtor]
		public Literal(Location loc, [MappedMember("lit")] Nemerle.Compiler.Literal lit)
			: base(loc)
		{
			this.lit = lit;
		}

		[RecordCtor]
		public Literal([MappedMember("ty")] TypeVar ty, [MappedMember("lit")] Nemerle.Compiler.Literal lit)
			: base(ty)
		{
			this.lit = lit;
		}

		[RecordCtor]
		public Literal(Location loc, [MappedMember("ty")] TypeVar ty, [MappedMember("lit")] Nemerle.Compiler.Literal lit)
			: base(loc, ty)
		{
			this.lit = lit;
		}
	}

	[VariantOption]
	public class Error : Pattern
	{
		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 8;
		}

		[RecordCtor]
		public Error()
		{
		}

		[RecordCtor]
		public Error(Location loc)
			: base(loc)
		{
		}

		[RecordCtor]
		public Error([MappedMember("ty")] TypeVar ty)
			: base(ty)
		{
		}

		[RecordCtor]
		public Error(Location loc, [MappedMember("ty")] TypeVar ty)
			: base(loc, ty)
		{
		}
	}

	private sealed class _N__N_lambda__108224__108232 : Function<Pattern, Pattern>
	{
		[SpecialName]
		public static readonly _N__N_lambda__108224__108232 Instance = new _N__N_lambda__108224__108232();

		[SpecialName]
		public sealed override Pattern apply(Pattern _N_wildcard_3424)
		{
			object result;
			if (_N_wildcard_3424 is Enum)
			{
				Nemerle.Compiler.Literal val = ((Enum)_N_wildcard_3424).val;
				result = new Literal(val);
			}
			else
			{
				result = null;
			}
			return (Pattern)result;
		}
	}

	private sealed class _N_closureOf_Walk_108273
	{
		internal Function<Pattern, Pattern> _N_f_108280;

		internal Function<Pattern, Pattern> _N_walk_108278;

		internal _N_closureOf_Walk_108273()
		{
		}
	}

	private sealed class _N_walk__108288 : Function<Pattern, Pattern>
	{
		[SpecialName]
		private _N_closureOf_Walk_108273 _N_Walk_closure_108292;

		public _N_walk__108288(_N_closureOf_Walk_108273 _N_Walk_closure_108292)
		{
			this._N_Walk_closure_108292 = _N_Walk_closure_108292;
		}

		[SpecialName]
		public sealed override Pattern apply(Pattern pat)
		{
			Location location = pat.Location;
			bool flag = location.FileIndex != 0;
			if (flag)
			{
				LocationStack.Push(location);
			}
			Pattern pattern2;
			try
			{
				Pattern pattern = _N_Walk_closure_108292._N_f_108280.apply(pat);
				pattern2 = ((pattern != null) ? pattern : _N_do_walk_108283(_N_Walk_closure_108292, pat));
			}
			finally
			{
				if (flag)
				{
					LocationStack.RemoveTop();
				}
			}
			Pattern pattern3 = pattern2;
			if (pattern3.ty == null)
			{
				pattern3.ty = pat.ty;
			}
			return pattern3;
		}
	}

	private sealed class _N__N_lambda__108257__108305 : Function<IMember, Pattern, Nemerle.Builtins.Tuple<IMember, Pattern>>
	{
		[SpecialName]
		private _N_closureOf_Walk_108273 _N_Walk_closure_108309;

		public _N__N_lambda__108257__108305(_N_closureOf_Walk_108273 _N_Walk_closure_108309)
		{
			this._N_Walk_closure_108309 = _N_Walk_closure_108309;
		}

		[SpecialName]
		public sealed override Nemerle.Builtins.Tuple<IMember, Pattern> apply(IMember f, Pattern p)
		{
			return new Nemerle.Builtins.Tuple<IMember, Pattern>(f, _N_Walk_closure_108309._N_walk_108278.apply(p));
		}
	}

	public TypeVar ty;

	public TypeVar Type
	{
		get
		{
			if (ty == null)
			{
				if (!Message.SeenError)
				{
					Message.Debug("Internal compiler error, please report a bug to bugs.nemerle.org. You can try modifying program near this location.");
				}
				throw new AssertionException("ncc\\typing\\TypedTree.n", 503, (ty != null).ToString(), "");
			}
			return ty;
		}
	}

	public Pattern()
	{
	}

	public Pattern(Location loc)
		: base(loc)
	{
	}

	public Type GetSystemType()
	{
		if (ty == null)
		{
			if (!Message.SeenError)
			{
				Message.Debug("Internal compiler error, please report a bug to bugs.nemerle.org. You can try modifying program near this location.");
			}
			throw new AssertionException("ncc\\typing\\TypedTree.n", 496, (ty != null).ToString(), "");
		}
		return ty.GetSystemType();
	}

	public Pattern StripEnums()
	{
		Function<Pattern, Pattern> instance = _N__N_lambda__108224__108232.Instance;
		return Walk(instance);
	}

	public Pattern Walk(Function<Pattern, Pattern> f)
	{
		_N_closureOf_Walk_108273 n_closureOf_Walk_ = new _N_closureOf_Walk_108273();
		n_closureOf_Walk_._N_f_108280 = f;
		n_closureOf_Walk_._N_walk_108278 = new _N_walk__108288(n_closureOf_Walk_);
		return n_closureOf_Walk_._N_walk_108278.apply(this);
	}

	public override string ToString()
	{
		return PrettyPrint.SprintPattern(this);
	}

	[SpecialName]
	public abstract override int _N_GetVariantCode();

	[SpecialName]
	public static int _N_GetVariantCodeSafe(Pattern x)
	{
		return ((object)x != null) ? x._N_GetVariantCode() : (-1);
	}

	[SpecialName]
	public static int _N_GetVariantCodeObject(object x)
	{
		return (!(x is Pattern)) ? (-1) : ((Pattern)x)._N_GetVariantCode();
	}

	[RecordCtor]
	protected Pattern([MappedMember("ty")] TypeVar ty)
	{
		this.ty = ty;
	}

	[RecordCtor]
	protected Pattern(Location loc, [MappedMember("ty")] TypeVar ty)
		: base(loc)
	{
		this.ty = ty;
	}

	private static Pattern _N_do_walk_108283(_N_closureOf_Walk_108273 _N_Walk_cp_108282, Pattern pat)
	{
		if (pat is Wildcard)
		{
			goto IL_0141;
		}
		object result;
		if (pat is As)
		{
			Pattern pat2 = ((As)pat).pat;
			LocalValue decl = ((As)pat).decl;
			result = new As(pat.Location, _N_Walk_cp_108282._N_walk_108278.apply(pat2), decl);
		}
		else
		{
			if (pat is HasType)
			{
				goto IL_0141;
			}
			if (pat is Tuple)
			{
				list<Pattern> list = ((Tuple)pat).args;
				result = new Tuple(pat.Location, list.Map(_N_Walk_cp_108282._N_walk_108278));
			}
			else if (pat is Record)
			{
				list<Nemerle.Builtins.Tuple<IMember, Pattern>> list2 = ((Record)pat).args;
				Location location = pat.Location;
				Function<IMember, Pattern, Nemerle.Builtins.Tuple<IMember, Pattern>> convert = new _N__N_lambda__108257__108305(_N_Walk_cp_108282);
				result = new Record(location, list2.Map(convert));
			}
			else
			{
				if (!(pat is Application))
				{
					if (pat is Enum || pat is Literal || pat is Error)
					{
						goto IL_0141;
					}
					throw new MatchFailureException();
				}
				TypeInfo name = ((Application)pat).name;
				Pattern pat2 = ((Application)pat).arg;
				result = new Application(pat.Location, name, _N_Walk_cp_108282._N_walk_108278.apply(pat2));
			}
		}
		goto IL_014d;
		IL_0141:
		result = pat;
		goto IL_014d;
		IL_014d:
		return (Pattern)result;
	}
}
