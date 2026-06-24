using System.Runtime.CompilerServices;
using Nemerle.Compiler.Typedtree;
using Nemerle.Core;
using Nemerle.Internal;

namespace Nemerle.Compiler.Parsetree;

[Variant("Nemerle.Compiler.Parsetree.PExpr.Wildcard,Nemerle.Compiler.Parsetree.PExpr.Void,Nemerle.Compiler.Parsetree.PExpr.As,Nemerle.Compiler.Parsetree.PExpr.Is,Nemerle.Compiler.Parsetree.PExpr.Where,Nemerle.Compiler.Parsetree.PExpr.Match,Nemerle.Compiler.Parsetree.PExpr.Ref,Nemerle.Compiler.Parsetree.PExpr.Member,Nemerle.Compiler.Parsetree.PExpr.Call,Nemerle.Compiler.Parsetree.PExpr.GenericSpecifier,Nemerle.Compiler.Parsetree.PExpr.ListLiteral,Nemerle.Compiler.Parsetree.PExpr.Assign,Nemerle.Compiler.Parsetree.PExpr.DefMutable,Nemerle.Compiler.Parsetree.PExpr.Define,Nemerle.Compiler.Parsetree.PExpr.DefFunctions,Nemerle.Compiler.Parsetree.PExpr.Lambda,Nemerle.Compiler.Parsetree.PExpr.Throw,Nemerle.Compiler.Parsetree.PExpr.Try,Nemerle.Compiler.Parsetree.PExpr.TryFinally,Nemerle.Compiler.Parsetree.PExpr.Literal,Nemerle.Compiler.Parsetree.PExpr.This,Nemerle.Compiler.Parsetree.PExpr.Base,Nemerle.Compiler.Parsetree.PExpr.Typeof,Nemerle.Compiler.Parsetree.PExpr.TypeConversion,Nemerle.Compiler.Parsetree.PExpr.TypeEnforcement,Nemerle.Compiler.Parsetree.PExpr.Sequence,Nemerle.Compiler.Parsetree.PExpr.Tuple,Nemerle.Compiler.Parsetree.PExpr.Array,Nemerle.Compiler.Parsetree.PExpr.EmptyArray,Nemerle.Compiler.Parsetree.PExpr.Indexer,Nemerle.Compiler.Parsetree.PExpr.ParmByRef,Nemerle.Compiler.Parsetree.PExpr.ParmOut,Nemerle.Compiler.Parsetree.PExpr.Error,Nemerle.Compiler.Parsetree.PExpr.MacroCall,Nemerle.Compiler.Parsetree.PExpr.Quoted,Nemerle.Compiler.Parsetree.PExpr.Spliced,Nemerle.Compiler.Parsetree.PExpr.ToComplete,Nemerle.Compiler.Parsetree.PExpr.Ellipsis,Nemerle.Compiler.Parsetree.PExpr.Typed,Nemerle.Compiler.Parsetree.PExpr.TypedPattern,Nemerle.Compiler.Parsetree.PExpr.TypedType")]
public abstract class PExpr : ParsedBase
{
	[VariantOption]
	public class Wildcard : PExpr
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
	}

	[VariantOption]
	public class Void : PExpr
	{
		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 1;
		}

		[RecordCtor]
		public Void()
		{
		}

		[RecordCtor]
		public Void(Location loc)
			: base(loc)
		{
		}
	}

	[VariantOption]
	public class As : PExpr
	{
		public readonly PExpr pat;

		public readonly Splicable name;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 2;
		}

		[RecordCtor]
		public As([MappedMember("pat")] PExpr pat, [MappedMember("name")] Splicable name)
		{
			this.pat = pat;
			this.name = name;
		}

		[RecordCtor]
		public As(Location loc, [MappedMember("pat")] PExpr pat, [MappedMember("name")] Splicable name)
			: base(loc)
		{
			this.pat = pat;
			this.name = name;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				name?.RelocateImplInternal(_info);
				pat?.RelocateImplInternal(_info);
			}
		}
	}

	[VariantOption]
	public class Is : PExpr
	{
		public readonly PExpr pat;

		public readonly PExpr ty;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 3;
		}

		[RecordCtor]
		public Is([MappedMember("pat")] PExpr pat, [MappedMember("ty")] PExpr ty)
		{
			this.pat = pat;
			this.ty = ty;
		}

		[RecordCtor]
		public Is(Location loc, [MappedMember("pat")] PExpr pat, [MappedMember("ty")] PExpr ty)
			: base(loc)
		{
			this.pat = pat;
			this.ty = ty;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				ty?.RelocateImplInternal(_info);
				pat?.RelocateImplInternal(_info);
			}
		}
	}

	[VariantOption]
	public class Where : PExpr
	{
		public readonly PExpr name;

		public readonly PExpr fields;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 4;
		}

		[RecordCtor]
		public Where([MappedMember("name")] PExpr name, [MappedMember("fields")] PExpr fields)
		{
			this.name = name;
			this.fields = fields;
		}

		[RecordCtor]
		public Where(Location loc, [MappedMember("name")] PExpr name, [MappedMember("fields")] PExpr fields)
			: base(loc)
		{
			this.name = name;
			this.fields = fields;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				fields?.RelocateImplInternal(_info);
				name?.RelocateImplInternal(_info);
			}
		}
	}

	[VariantOption]
	public class Match : PExpr
	{
		public readonly PExpr expr;

		public readonly list<MatchCase> cases;

		public Location expr_loc;

		public Match(Location loc, PExpr expr, list<MatchCase> cases)
			: this(loc, expr, cases, Location.Default)
		{
		}

		public Match(PExpr expr, list<MatchCase> cases)
			: this(expr, cases, Location.Default)
		{
		}

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 5;
		}

		[RecordCtor]
		public Match([MappedMember("expr")] PExpr expr, [MappedMember("cases")] list<MatchCase> cases, [MappedMember("expr_loc")] Location expr_loc)
		{
			this.expr = expr;
			this.cases = cases;
			this.expr_loc = expr_loc;
		}

		[RecordCtor]
		public Match(Location loc, [MappedMember("expr")] PExpr expr, [MappedMember("cases")] list<MatchCase> cases, [MappedMember("expr_loc")] Location expr_loc)
			: base(loc)
		{
			this.expr = expr;
			this.cases = cases;
			this.expr_loc = expr_loc;
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
			expr_loc = Completion.Relocate(expr_loc, _info);
			list<MatchCase> list = cases;
			if (list != null)
			{
				list = list;
				while (list is list<MatchCase>.Cons)
				{
					MatchCase hd = ((list<MatchCase>.Cons)list).hd;
					list = ((list<MatchCase>.Cons)list).tl;
					((ISupportRelocation)hd).RelocateImpl(_info);
					list = list;
				}
			}
			expr?.RelocateImplInternal(_info);
		}
	}

	[VariantOption]
	public class Ref : PExpr
	{
		public Name name;

		public Ref(Name name)
			: base((name != null && !(name.Location == Location.Default)) ? name.Location : LocationStack.Top())
		{
			this.name = name;
		}

		public Ref(Location loc, Name name)
			: base(loc)
		{
			this.name = name;
		}

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
				name?.RelocateImplInternal(_info);
			}
		}
	}

	[VariantOption]
	public class Member : PExpr
	{
		public readonly PExpr obj;

		public readonly Splicable member;

		public Member(PExpr obj, Ref member)
		{
			if (obj.Location.IsGenerated && !member.Location.IsGenerated)
			{
				base._002Ector(member.Location);
			}
			else
			{
				base._002Ector();
			}
			this.obj = obj;
			this.member = new Splicable.Name(member.Location, member.name);
		}

		public Member(PExpr obj, Splicable member)
		{
			Location location = obj.Location;
			Location location2 = member.Location;
			if (location.IsGeneratedOrEmpty && !location2.IsGenerated)
			{
				base._002Ector(member.Location);
			}
			else if (location2.IsSourceAvailable && location.IsSourceAvailable)
			{
				base._002Ector(location + location2);
			}
			else
			{
				base._002Ector();
			}
			this.obj = obj;
			this.member = member;
		}

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 7;
		}

		[RecordCtor]
		public Member(Location loc, [MappedMember("obj")] PExpr obj, [MappedMember("member")] Splicable member)
			: base(loc)
		{
			this.obj = obj;
			this.member = member;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				member?.RelocateImplInternal(_info);
				obj?.RelocateImplInternal(_info);
			}
		}
	}

	[VariantOption]
	public class Call : PExpr
	{
		public readonly PExpr func;

		public readonly list<PExpr> parms;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 8;
		}

		[RecordCtor]
		public Call([MappedMember("func")] PExpr func, [MappedMember("parms")] list<PExpr> parms)
		{
			this.func = func;
			this.parms = parms;
		}

		[RecordCtor]
		public Call(Location loc, [MappedMember("func")] PExpr func, [MappedMember("parms")] list<PExpr> parms)
			: base(loc)
		{
			this.func = func;
			this.parms = parms;
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
			list<PExpr> list = parms;
			if (list != null)
			{
				list = list;
				while (list is list<PExpr>.Cons)
				{
					PExpr hd = ((list<PExpr>.Cons)list).hd;
					list = ((list<PExpr>.Cons)list).tl;
					((ISupportRelocation)hd).RelocateImpl(_info);
					list = list;
				}
			}
			func?.RelocateImplInternal(_info);
		}
	}

	[VariantOption]
	public class GenericSpecifier : PExpr
	{
		public readonly PExpr func;

		public readonly list<PExpr> generic_parms;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 9;
		}

		[RecordCtor]
		public GenericSpecifier([MappedMember("func")] PExpr func, [MappedMember("generic_parms")] list<PExpr> generic_parms)
		{
			this.func = func;
			this.generic_parms = generic_parms;
		}

		[RecordCtor]
		public GenericSpecifier(Location loc, [MappedMember("func")] PExpr func, [MappedMember("generic_parms")] list<PExpr> generic_parms)
			: base(loc)
		{
			this.func = func;
			this.generic_parms = generic_parms;
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
			list<PExpr> list = generic_parms;
			if (list != null)
			{
				list = list;
				while (list is list<PExpr>.Cons)
				{
					PExpr hd = ((list<PExpr>.Cons)list).hd;
					list = ((list<PExpr>.Cons)list).tl;
					((ISupportRelocation)hd).RelocateImpl(_info);
					list = list;
				}
			}
			func?.RelocateImplInternal(_info);
		}
	}

	[VariantOption]
	public class ListLiteral : PExpr
	{
		public readonly list<PExpr> elements;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 10;
		}

		[RecordCtor]
		public ListLiteral([MappedMember("elements")] list<PExpr> elements)
		{
			this.elements = elements;
		}

		[RecordCtor]
		public ListLiteral(Location loc, [MappedMember("elements")] list<PExpr> elements)
			: base(loc)
		{
			this.elements = elements;
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
			list<PExpr> list = elements;
			if (list != null)
			{
				list = list;
				while (list is list<PExpr>.Cons)
				{
					PExpr hd = ((list<PExpr>.Cons)list).hd;
					list = ((list<PExpr>.Cons)list).tl;
					((ISupportRelocation)hd).RelocateImpl(_info);
					list = list;
				}
			}
		}
	}

	[VariantOption]
	public class Assign : PExpr
	{
		public readonly PExpr target;

		public readonly PExpr source;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 11;
		}

		[RecordCtor]
		public Assign([MappedMember("target")] PExpr target, [MappedMember("source")] PExpr source)
		{
			this.target = target;
			this.source = source;
		}

		[RecordCtor]
		public Assign(Location loc, [MappedMember("target")] PExpr target, [MappedMember("source")] PExpr source)
			: base(loc)
		{
			this.target = target;
			this.source = source;
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
	}

	[VariantOption]
	public class DefMutable : PExpr
	{
		public readonly PExpr name;

		public readonly PExpr val;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 12;
		}

		[RecordCtor]
		public DefMutable([MappedMember("name")] PExpr name, [MappedMember("val")] PExpr val)
		{
			this.name = name;
			this.val = val;
		}

		[RecordCtor]
		public DefMutable(Location loc, [MappedMember("name")] PExpr name, [MappedMember("val")] PExpr val)
			: base(loc)
		{
			this.name = name;
			this.val = val;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				val?.RelocateImplInternal(_info);
				name?.RelocateImplInternal(_info);
			}
		}
	}

	[VariantOption]
	public class Define : PExpr
	{
		public readonly PExpr pattern;

		public readonly PExpr val;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 13;
		}

		[RecordCtor]
		public Define([MappedMember("pattern")] PExpr pattern, [MappedMember("val")] PExpr val)
		{
			this.pattern = pattern;
			this.val = val;
		}

		[RecordCtor]
		public Define(Location loc, [MappedMember("pattern")] PExpr pattern, [MappedMember("val")] PExpr val)
			: base(loc)
		{
			this.pattern = pattern;
			this.val = val;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				val?.RelocateImplInternal(_info);
				pattern?.RelocateImplInternal(_info);
			}
		}
	}

	[VariantOption]
	public class DefFunctions : PExpr
	{
		public readonly list<Function_decl> funs;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 14;
		}

		[RecordCtor]
		public DefFunctions([MappedMember("funs")] list<Function_decl> funs)
		{
			this.funs = funs;
		}

		[RecordCtor]
		public DefFunctions(Location loc, [MappedMember("funs")] list<Function_decl> funs)
			: base(loc)
		{
			this.funs = funs;
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
			list<Function_decl> list = funs;
			if (list != null)
			{
				list = list;
				while (list is list<Function_decl>.Cons)
				{
					Function_decl hd = ((list<Function_decl>.Cons)list).hd;
					list = ((list<Function_decl>.Cons)list).tl;
					((ISupportRelocation)hd).RelocateImpl(_info);
					list = list;
				}
			}
		}
	}

	[VariantOption]
	public class Lambda : PExpr
	{
		public readonly Function_decl decl;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 15;
		}

		[RecordCtor]
		public Lambda([MappedMember("decl")] Function_decl decl)
		{
			this.decl = decl;
		}

		[RecordCtor]
		public Lambda(Location loc, [MappedMember("decl")] Function_decl decl)
			: base(loc)
		{
			this.decl = decl;
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
	}

	[VariantOption]
	public class Throw : PExpr
	{
		public readonly PExpr exn;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 16;
		}

		[RecordCtor]
		public Throw([MappedMember("exn")] PExpr exn)
		{
			this.exn = exn;
		}

		[RecordCtor]
		public Throw(Location loc, [MappedMember("exn")] PExpr exn)
			: base(loc)
		{
			this.exn = exn;
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
	}

	[VariantOption]
	public class Try : PExpr
	{
		public readonly PExpr body;

		public readonly list<TryCase> cases;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 17;
		}

		[RecordCtor]
		public Try([MappedMember("body")] PExpr body, [MappedMember("cases")] list<TryCase> cases)
		{
			this.body = body;
			this.cases = cases;
		}

		[RecordCtor]
		public Try(Location loc, [MappedMember("body")] PExpr body, [MappedMember("cases")] list<TryCase> cases)
			: base(loc)
		{
			this.body = body;
			this.cases = cases;
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
			list<TryCase> list = cases;
			if (list != null)
			{
				list = list;
				while (list is list<TryCase>.Cons)
				{
					TryCase hd = ((list<TryCase>.Cons)list).hd;
					list = ((list<TryCase>.Cons)list).tl;
					((ISupportRelocation)hd).RelocateImpl(_info);
					list = list;
				}
			}
			body?.RelocateImplInternal(_info);
		}
	}

	[VariantOption]
	public class TryFinally : PExpr
	{
		public readonly PExpr body;

		public readonly PExpr handler;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 18;
		}

		[RecordCtor]
		public TryFinally([MappedMember("body")] PExpr body, [MappedMember("handler")] PExpr handler)
		{
			this.body = body;
			this.handler = handler;
		}

		[RecordCtor]
		public TryFinally(Location loc, [MappedMember("body")] PExpr body, [MappedMember("handler")] PExpr handler)
			: base(loc)
		{
			this.body = body;
			this.handler = handler;
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
	}

	[VariantOption]
	public class Literal : PExpr
	{
		public readonly Nemerle.Compiler.Literal val;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 19;
		}

		[RecordCtor]
		public Literal([MappedMember("val")] Nemerle.Compiler.Literal val)
		{
			this.val = val;
		}

		[RecordCtor]
		public Literal(Location loc, [MappedMember("val")] Nemerle.Compiler.Literal val)
			: base(loc)
		{
			this.val = val;
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
	}

	[VariantOption]
	public class This : PExpr
	{
		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 20;
		}

		[RecordCtor]
		public This()
		{
		}

		[RecordCtor]
		public This(Location loc)
			: base(loc)
		{
		}
	}

	[VariantOption]
	public class Base : PExpr
	{
		public readonly option<PExpr> ty;

		public Base()
			: this(option<PExpr>.None._N_constant_object)
		{
		}

		public Base(Location loc)
			: this(loc, option<PExpr>.None._N_constant_object)
		{
		}

		public Base(PExpr ty)
			: this(new option<PExpr>.Some(ty))
		{
		}

		public Base(Location loc, PExpr ty)
			: this(loc, new option<PExpr>.Some(ty))
		{
		}

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 21;
		}

		[RecordCtor]
		public Base([MappedMember("ty")] option<PExpr> ty)
		{
			this.ty = ty;
		}

		[RecordCtor]
		public Base(Location loc, [MappedMember("ty")] option<PExpr> ty)
			: base(loc)
		{
			this.ty = ty;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				option<PExpr> option = ty;
				if (option is option<PExpr>.Some)
				{
					PExpr val = ((option<PExpr>.Some)option).val;
					((ISupportRelocation)val).RelocateImpl(_info);
				}
			}
		}
	}

	[VariantOption]
	public class Typeof : PExpr
	{
		public readonly PExpr ty;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 22;
		}

		[RecordCtor]
		public Typeof([MappedMember("ty")] PExpr ty)
		{
			this.ty = ty;
		}

		[RecordCtor]
		public Typeof(Location loc, [MappedMember("ty")] PExpr ty)
			: base(loc)
		{
			this.ty = ty;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				ty?.RelocateImplInternal(_info);
			}
		}
	}

	[VariantOption]
	public class TypeConversion : PExpr
	{
		public readonly PExpr expr;

		public readonly PExpr ty;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 23;
		}

		[RecordCtor]
		public TypeConversion([MappedMember("expr")] PExpr expr, [MappedMember("ty")] PExpr ty)
		{
			this.expr = expr;
			this.ty = ty;
		}

		[RecordCtor]
		public TypeConversion(Location loc, [MappedMember("expr")] PExpr expr, [MappedMember("ty")] PExpr ty)
			: base(loc)
		{
			this.expr = expr;
			this.ty = ty;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				ty?.RelocateImplInternal(_info);
				expr?.RelocateImplInternal(_info);
			}
		}
	}

	[VariantOption]
	public class TypeEnforcement : PExpr
	{
		public readonly PExpr expr;

		public readonly PExpr ty;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 24;
		}

		[RecordCtor]
		public TypeEnforcement([MappedMember("expr")] PExpr expr, [MappedMember("ty")] PExpr ty)
		{
			this.expr = expr;
			this.ty = ty;
		}

		[RecordCtor]
		public TypeEnforcement(Location loc, [MappedMember("expr")] PExpr expr, [MappedMember("ty")] PExpr ty)
			: base(loc)
		{
			this.expr = expr;
			this.ty = ty;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				ty?.RelocateImplInternal(_info);
				expr?.RelocateImplInternal(_info);
			}
		}
	}

	[VariantOption]
	public class Sequence : PExpr
	{
		public readonly list<PExpr> body;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 25;
		}

		[RecordCtor]
		public Sequence([MappedMember("body")] list<PExpr> body)
		{
			this.body = body;
		}

		[RecordCtor]
		public Sequence(Location loc, [MappedMember("body")] list<PExpr> body)
			: base(loc)
		{
			this.body = body;
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
			list<PExpr> list = body;
			if (list != null)
			{
				list = list;
				while (list is list<PExpr>.Cons)
				{
					PExpr hd = ((list<PExpr>.Cons)list).hd;
					list = ((list<PExpr>.Cons)list).tl;
					((ISupportRelocation)hd).RelocateImpl(_info);
					list = list;
				}
			}
		}
	}

	[VariantOption]
	public class Tuple : PExpr
	{
		public readonly list<PExpr> args;

		[IgnoreField]
		public int argsCount;

		public static Tuple Create(Location loc, list<PExpr> args)
		{
			return new Tuple(loc, args, args.Length);
		}

		public static Tuple Create(list<PExpr> args)
		{
			return new Tuple(Location.EnclosingLocation(args), args, args.Length);
		}

		public Tuple(list<PExpr> args, int argsCount)
			: this(args)
		{
			this.argsCount = argsCount;
		}

		public Tuple(Location loc, list<PExpr> args, int argsCount)
			: this(loc, args)
		{
			this.argsCount = argsCount;
		}

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 26;
		}

		[RecordCtor]
		public Tuple([MappedMember("args")] list<PExpr> args)
		{
			this.args = args;
		}

		[RecordCtor]
		public Tuple(Location loc, [MappedMember("args")] list<PExpr> args)
			: base(loc)
		{
			this.args = args;
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
			list<PExpr> list = args;
			if (list != null)
			{
				list = list;
				while (list is list<PExpr>.Cons)
				{
					PExpr hd = ((list<PExpr>.Cons)list).hd;
					list = ((list<PExpr>.Cons)list).tl;
					((ISupportRelocation)hd).RelocateImpl(_info);
					list = list;
				}
			}
		}
	}

	[VariantOption]
	public class Array : PExpr
	{
		public readonly PExpr rank;

		public readonly PExpr args;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 27;
		}

		[RecordCtor]
		public Array([MappedMember("rank")] PExpr rank, [MappedMember("args")] PExpr args)
		{
			this.rank = rank;
			this.args = args;
		}

		[RecordCtor]
		public Array(Location loc, [MappedMember("rank")] PExpr rank, [MappedMember("args")] PExpr args)
			: base(loc)
		{
			this.rank = rank;
			this.args = args;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				args?.RelocateImplInternal(_info);
				rank?.RelocateImplInternal(_info);
			}
		}
	}

	[VariantOption]
	public class EmptyArray : PExpr
	{
		public readonly list<PExpr> sizes;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 28;
		}

		[RecordCtor]
		public EmptyArray([MappedMember("sizes")] list<PExpr> sizes)
		{
			this.sizes = sizes;
		}

		[RecordCtor]
		public EmptyArray(Location loc, [MappedMember("sizes")] list<PExpr> sizes)
			: base(loc)
		{
			this.sizes = sizes;
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
			list<PExpr> list = sizes;
			if (list != null)
			{
				list = list;
				while (list is list<PExpr>.Cons)
				{
					PExpr hd = ((list<PExpr>.Cons)list).hd;
					list = ((list<PExpr>.Cons)list).tl;
					((ISupportRelocation)hd).RelocateImpl(_info);
					list = list;
				}
			}
		}
	}

	[VariantOption]
	public class Indexer : PExpr
	{
		public readonly PExpr obj;

		public readonly list<PExpr> args;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 29;
		}

		[RecordCtor]
		public Indexer([MappedMember("obj")] PExpr obj, [MappedMember("args")] list<PExpr> args)
		{
			this.obj = obj;
			this.args = args;
		}

		[RecordCtor]
		public Indexer(Location loc, [MappedMember("obj")] PExpr obj, [MappedMember("args")] list<PExpr> args)
			: base(loc)
		{
			this.obj = obj;
			this.args = args;
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
			list<PExpr> list = args;
			if (list != null)
			{
				list = list;
				while (list is list<PExpr>.Cons)
				{
					PExpr hd = ((list<PExpr>.Cons)list).hd;
					list = ((list<PExpr>.Cons)list).tl;
					((ISupportRelocation)hd).RelocateImpl(_info);
					list = list;
				}
			}
			obj?.RelocateImplInternal(_info);
		}
	}

	[VariantOption]
	public class ParmByRef : PExpr
	{
		public readonly PExpr parm;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 30;
		}

		[RecordCtor]
		public ParmByRef([MappedMember("parm")] PExpr parm)
		{
			this.parm = parm;
		}

		[RecordCtor]
		public ParmByRef(Location loc, [MappedMember("parm")] PExpr parm)
			: base(loc)
		{
			this.parm = parm;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				parm?.RelocateImplInternal(_info);
			}
		}
	}

	[VariantOption]
	public class ParmOut : PExpr
	{
		public readonly PExpr parm;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 31;
		}

		[RecordCtor]
		public ParmOut([MappedMember("parm")] PExpr parm)
		{
			this.parm = parm;
		}

		[RecordCtor]
		public ParmOut(Location loc, [MappedMember("parm")] PExpr parm)
			: base(loc)
		{
			this.parm = parm;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				parm?.RelocateImplInternal(_info);
			}
		}
	}

	[VariantOption]
	public class Error : PExpr
	{
		public readonly object msg;

		public Error()
		{
			msg = null;
		}

		public Error(Location location)
			: base(location)
		{
			msg = null;
		}

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 32;
		}

		[RecordCtor]
		public Error([MappedMember("msg")] object msg)
		{
			this.msg = msg;
		}

		[RecordCtor]
		public Error(Location loc, [MappedMember("msg")] object msg)
			: base(loc)
		{
			this.msg = msg;
		}
	}

	[VariantOption]
	public class MacroCall : PExpr
	{
		public readonly Name name;

		public readonly NamespaceTree.Node ns;

		public readonly list<SyntaxElement> parms;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 33;
		}

		[RecordCtor]
		public MacroCall([MappedMember("name")] Name name, [MappedMember("ns")] NamespaceTree.Node ns, [MappedMember("parms")] list<SyntaxElement> parms)
		{
			this.name = name;
			this.ns = ns;
			this.parms = parms;
		}

		[RecordCtor]
		public MacroCall(Location loc, [MappedMember("name")] Name name, [MappedMember("ns")] NamespaceTree.Node ns, [MappedMember("parms")] list<SyntaxElement> parms)
			: base(loc)
		{
			this.name = name;
			this.ns = ns;
			this.parms = parms;
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
			list<SyntaxElement> list = parms;
			if (list != null)
			{
				list = list;
				while (list is list<SyntaxElement>.Cons)
				{
					SyntaxElement hd = ((list<SyntaxElement>.Cons)list).hd;
					list = ((list<SyntaxElement>.Cons)list).tl;
					((ISupportRelocation)hd).RelocateImpl(_info);
					list = list;
				}
			}
			name?.RelocateImplInternal(_info);
		}
	}

	[VariantOption]
	public class Quoted : PExpr
	{
		public readonly SyntaxElement body;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 34;
		}

		[RecordCtor]
		public Quoted([MappedMember("body")] SyntaxElement body)
		{
			this.body = body;
		}

		[RecordCtor]
		public Quoted(Location loc, [MappedMember("body")] SyntaxElement body)
			: base(loc)
		{
			this.body = body;
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
	}

	[VariantOption]
	public class Spliced : PExpr
	{
		public readonly PExpr body;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 35;
		}

		[RecordCtor]
		public Spliced([MappedMember("body")] PExpr body)
		{
			this.body = body;
		}

		[RecordCtor]
		public Spliced(Location loc, [MappedMember("body")] PExpr body)
			: base(loc)
		{
			this.body = body;
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
	}

	[VariantOption]
	public class ToComplete : PExpr
	{
		public readonly Name body;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 36;
		}

		[RecordCtor]
		public ToComplete([MappedMember("body")] Name body)
		{
			this.body = body;
		}

		[RecordCtor]
		public ToComplete(Location loc, [MappedMember("body")] Name body)
			: base(loc)
		{
			this.body = body;
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
	}

	[VariantOption]
	public class Ellipsis : PExpr
	{
		public readonly PExpr body;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 37;
		}

		[RecordCtor]
		public Ellipsis([MappedMember("body")] PExpr body)
		{
			this.body = body;
		}

		[RecordCtor]
		public Ellipsis(Location loc, [MappedMember("body")] PExpr body)
			: base(loc)
		{
			this.body = body;
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
	}

	[VariantOption]
	public class Typed : PExpr
	{
		public readonly TExpr body;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 38;
		}

		[RecordCtor]
		public Typed([MappedMember("body")] TExpr body)
		{
			this.body = body;
		}

		[RecordCtor]
		public Typed(Location loc, [MappedMember("body")] TExpr body)
			: base(loc)
		{
			this.body = body;
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
	}

	[VariantOption]
	public class TypedPattern : PExpr
	{
		public readonly Pattern body;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 39;
		}

		[RecordCtor]
		public TypedPattern([MappedMember("body")] Pattern body)
		{
			this.body = body;
		}

		[RecordCtor]
		public TypedPattern(Location loc, [MappedMember("body")] Pattern body)
			: base(loc)
		{
			this.body = body;
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
	}

	[VariantOption]
	public class TypedType : PExpr
	{
		public readonly TypeVar body;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 40;
		}

		[RecordCtor]
		public TypedType([MappedMember("body")] TypeVar body)
		{
			this.body = body;
		}

		[RecordCtor]
		public TypedType(Location loc, [MappedMember("body")] TypeVar body)
			: base(loc)
		{
			this.body = body;
		}
	}

	[IgnoreField]
	[field: IgnoreField]
	public Token Token { get; set; }

	public override string ToString()
	{
		return PrettyPrint.SprintExpr(option<Typer>.None._N_constant_object, this);
	}

	public static PExpr FromQualifiedIdentifier(ManagerClass manager, string qid)
	{
		int num = 0;
		PExpr pExpr = null;
		object result;
		if (string.IsNullOrEmpty(qid))
		{
			result = null;
		}
		else
		{
			string[] array = qid.Split('.');
			pExpr = new Ref(new Name(array[0], manager.MacroColors.UseColor, manager.MacroColors.UseContext));
			for (num = 1; num < array.Length; num = checked(num + 1))
			{
				pExpr = new Member(Macros.QuotationChoose(pExpr), new Splicable.Name(new Name(array[num], manager.MacroColors.UseColor, manager.MacroColors.UseContext)));
			}
			result = pExpr;
		}
		return (PExpr)result;
	}

	[SpecialName]
	public abstract override int _N_GetVariantCode();

	[SpecialName]
	public static int _N_GetVariantCodeSafe(PExpr x)
	{
		return ((object)x != null) ? x._N_GetVariantCode() : (-1);
	}

	[SpecialName]
	public static int _N_GetVariantCodeObject(object x)
	{
		return (!(x is PExpr)) ? (-1) : ((PExpr)x)._N_GetVariantCode();
	}

	[RecordCtor]
	protected PExpr()
	{
	}

	[RecordCtor]
	protected PExpr(Location loc)
		: base(loc)
	{
	}
}
