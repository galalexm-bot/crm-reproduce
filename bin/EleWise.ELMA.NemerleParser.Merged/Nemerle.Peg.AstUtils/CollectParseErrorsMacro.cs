using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Collections;
using Nemerle.Compiler;
using Nemerle.Compiler.Parsetree;
using Nemerle.Compiler.Typedtree;
using Nemerle.Core;
using Nemerle.Internal;
using Nemerle.Utility;

namespace Nemerle.Peg.AstUtils;

[MacroInfo("CollectParseErrors", false, new string[] { "ast" }, new string[] { "PExpr" }, new string[] { "" }, new bool[] { false }, "")]
public sealed class CollectParseErrorsMacro : IMacro
{
	private sealed class _N_closureOf_Run_10277
	{
		internal Typer _N_typer_10282;

		internal _N_closureOf_Run_10277()
		{
		}
	}

	private sealed class _N_makeResult__10287 : Function<PExpr, TExpr, PExpr>
	{
		[SpecialName]
		private _N_closureOf_Run_10277 _N_Run_closure_10291;

		public _N_makeResult__10287(_N_closureOf_Run_10277 _N_Run_closure_10291)
		{
			this._N_Run_closure_10291 = _N_Run_closure_10291;
		}

		[SpecialName]
		public sealed override PExpr apply(PExpr _N_wildcard_4194, TExpr x)
		{
			_N_closureOf_makeResult_10296 n_closureOf_makeResult_ = new _N_closureOf_makeResult_10296();
			n_closureOf_makeResult_._N_pegLocatedType_10301 = new FixedType.Class(_N_Run_closure_10291._N_typer_10282.Manager.LookupTypeInfo("Nemerle.Peg.Located", 0), list<TypeVar>.Nil._N_constant_object);
			Function<FixedType, PExpr, option<PExpr>> userHandler = new _N_typeHandler__10303(n_closureOf_makeResult_);
			TypeWalker typeWalker = new TypeWalker(userHandler);
			typeWalker.Run(x.Type);
			return new PExpr.Sequence(new list<PExpr>.Cons(new PExpr.Define(new PExpr.Ref(Nemerle.Compiler.Parsetree.Name.NameInCurrentColor("buffer", Nemerle_002EPeg_002EMacros780011_002E_N_MacroContexts.Get(1, ManagerClass.Instance))), new PExpr.Call(new PExpr.GenericSpecifier(new PExpr.Member(new PExpr.Member(new PExpr.Member(new PExpr.Ref(Nemerle.Compiler.Parsetree.Name.NameInCurrentColor("System", Nemerle_002EPeg_002EMacros780011_002E_N_MacroContexts.Get(1, ManagerClass.Instance))), new Splicable.Name(Nemerle.Compiler.Parsetree.Name.NameInCurrentColor("Collections", Nemerle_002EPeg_002EMacros780011_002E_N_MacroContexts.Get(1, ManagerClass.Instance)))), new Splicable.Name(Nemerle.Compiler.Parsetree.Name.NameInCurrentColor("Generic", Nemerle_002EPeg_002EMacros780011_002E_N_MacroContexts.Get(1, ManagerClass.Instance)))), new Splicable.Name(Nemerle.Compiler.Parsetree.Name.NameInCurrentColor("List", Nemerle_002EPeg_002EMacros780011_002E_N_MacroContexts.Get(1, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Member(new PExpr.Member(new PExpr.Ref(Nemerle.Compiler.Parsetree.Name.NameInCurrentColor("Nemerle", Nemerle_002EPeg_002EMacros780011_002E_N_MacroContexts.Get(1, ManagerClass.Instance))), new Splicable.Name(Nemerle.Compiler.Parsetree.Name.NameInCurrentColor("Peg", Nemerle_002EPeg_002EMacros780011_002E_N_MacroContexts.Get(1, ManagerClass.Instance)))), new Splicable.Name(Nemerle.Compiler.Parsetree.Name.NameInCurrentColor("Located", Nemerle_002EPeg_002EMacros780011_002E_N_MacroContexts.Get(1, ManagerClass.Instance)))), list<PExpr>.Nil._N_constant_object)), list<PExpr>.Nil._N_constant_object)), new list<PExpr>.Cons(Macros.QuotationChoose(typeWalker.Compile(x)), new list<PExpr>.Cons(new PExpr.Ref(Nemerle.Compiler.Parsetree.Name.NameInCurrentColor("buffer", Nemerle_002EPeg_002EMacros780011_002E_N_MacroContexts.Get(1, ManagerClass.Instance))), list<PExpr>.Nil._N_constant_object))));
		}
	}

	private sealed class _N_closureOf_makeResult_10296
	{
		internal FixedType.Class _N_pegLocatedType_10301;

		internal _N_closureOf_makeResult_10296()
		{
		}
	}

	private sealed class _N_typeHandler__10303 : Function<FixedType, PExpr, option<PExpr>>
	{
		[SpecialName]
		private _N_closureOf_makeResult_10296 _N_makeResult_closure_10307;

		public _N_typeHandler__10303(_N_closureOf_makeResult_10296 _N_makeResult_closure_10307)
		{
			this._N_makeResult_closure_10307 = _N_makeResult_closure_10307;
		}

		[SpecialName]
		public sealed override option<PExpr> apply(FixedType ty, PExpr var)
		{
			object result;
			if (ty is FixedType.Class)
			{
				TypeInfo tycon = ((FixedType.Class)ty).tycon;
				if (ty.TryRequire(_N_makeResult_closure_10307._N_pegLocatedType_10301) && tycon.Name.StartsWith("Error"))
				{
					result = new option<PExpr>.Some(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Nemerle.Compiler.Parsetree.Name.NameInCurrentColor("buffer", Nemerle_002EPeg_002EMacros780011_002E_N_MacroContexts.Get(1, ManagerClass.Instance))), new Splicable.Name(Nemerle.Compiler.Parsetree.Name.NameInCurrentColor("Add", Nemerle_002EPeg_002EMacros780011_002E_N_MacroContexts.Get(1, ManagerClass.Instance)))), new list<PExpr>.Cons(Macros.QuotationChoose(var), list<PExpr>.Nil._N_constant_object)));
					goto IL_00ac;
				}
			}
			result = option<PExpr>.None._N_constant_object;
			goto IL_00ac;
			IL_00ac:
			return (option<PExpr>)result;
		}
	}

	private static MacroUsageAttribute my_usage;

	private static readonly list<string> keywords;

	public Nemerle.Compiler.Location Location => new Nemerle.Compiler.Location(Nemerle.Compiler.Location.GetFileIndex("AstUtils\\CollectParseErrors.n"), 17, 3);

	public bool IsInherited => my_usage != null && my_usage.Inherited;

	public list<string> Keywords => keywords;

	public string Name => "CollectParseErrors";

	public string Namespace => "Nemerle.Peg.AstUtils";

	public MacroUsageAttribute Usage => my_usage;

	public bool IsTailRecursionTransparent => false;

	static CollectParseErrorsMacro()
	{
		int num = 0;
		object[] customAttributes = typeof(CollectParseErrorsMacro).GetCustomAttributes(inherit: false);
		foreach (object obj in customAttributes)
		{
			if (obj is MacroUsageAttribute)
			{
				my_usage = (MacroUsageAttribute)obj;
			}
		}
		keywords = list<string>.Nil._N_constant_object;
	}

	public string GetName()
	{
		return "CollectParseErrors";
	}

	public string GetNamespace()
	{
		return "Nemerle.Peg.AstUtils";
	}

	public list<SyntaxElement> CallTransform(list<PExpr> trans_p)
	{
		list<SyntaxElement> list = null;
		list = list<SyntaxElement>.Nil._N_constant_object;
		if (trans_p is list<PExpr>.Cons)
		{
			PExpr hd = ((list<PExpr>.Cons)trans_p).hd;
			list<PExpr> tl = ((list<PExpr>.Cons)trans_p).tl;
			list = new list<SyntaxElement>.Cons(new SyntaxElement.Expression(hd), list);
			if (tl is list<PExpr>.Cons)
			{
				hd = ((list<PExpr>.Cons)tl).hd;
				list = new list<SyntaxElement>.Cons(new SyntaxElement.Expression(hd), list);
			}
			else if ((object)tl != list<PExpr>.Nil._N_constant_object)
			{
				throw new MatchFailureException();
			}
		}
		else if ((object)trans_p != list<PExpr>.Nil._N_constant_object)
		{
			throw new MatchFailureException();
		}
		return NList.Rev(list);
	}

	public PExpr Run(Typer _N__1, list<SyntaxElement> parms)
	{
		_N_closureOf_Run_10277 n_closureOf_Run_ = new _N_closureOf_Run_10277();
		if (parms is list<SyntaxElement>.Cons && ((list<SyntaxElement>.Cons)parms).hd is SyntaxElement.Expression && (object)((list<SyntaxElement>.Cons)parms).tl == list<SyntaxElement>.Nil._N_constant_object)
		{
			PExpr body = ((SyntaxElement.Expression)((list<SyntaxElement>.Cons)parms).hd).body;
			n_closureOf_Run_._N_typer_10282 = _N__1;
			Function<PExpr, TExpr, PExpr> transform = new _N_makeResult__10287(n_closureOf_Run_);
			return (!ManagerClass.Instance.IsIntelliSenseMode) ? n_closureOf_Run_._N_typer_10282.TransformWhenAllTypesWouldBeInfered(transform, n_closureOf_Run_._N_typer_10282.TypeExpr(body)) : new PExpr.Call(new PExpr.GenericSpecifier(new PExpr.Member(new PExpr.Member(new PExpr.Member(new PExpr.Ref(Nemerle.Compiler.Parsetree.Name.NameInCurrentColor("System", Nemerle_002EPeg_002EMacros780011_002E_N_MacroContexts.Get(1, ManagerClass.Instance))), new Splicable.Name(Nemerle.Compiler.Parsetree.Name.NameInCurrentColor("Collections", Nemerle_002EPeg_002EMacros780011_002E_N_MacroContexts.Get(1, ManagerClass.Instance)))), new Splicable.Name(Nemerle.Compiler.Parsetree.Name.NameInCurrentColor("Generic", Nemerle_002EPeg_002EMacros780011_002E_N_MacroContexts.Get(1, ManagerClass.Instance)))), new Splicable.Name(Nemerle.Compiler.Parsetree.Name.NameInCurrentColor("List", Nemerle_002EPeg_002EMacros780011_002E_N_MacroContexts.Get(1, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Member(new PExpr.Member(new PExpr.Ref(Nemerle.Compiler.Parsetree.Name.NameInCurrentColor("Nemerle", Nemerle_002EPeg_002EMacros780011_002E_N_MacroContexts.Get(1, ManagerClass.Instance))), new Splicable.Name(Nemerle.Compiler.Parsetree.Name.NameInCurrentColor("Peg", Nemerle_002EPeg_002EMacros780011_002E_N_MacroContexts.Get(1, ManagerClass.Instance)))), new Splicable.Name(Nemerle.Compiler.Parsetree.Name.NameInCurrentColor("Located", Nemerle_002EPeg_002EMacros780011_002E_N_MacroContexts.Get(1, ManagerClass.Instance)))), list<PExpr>.Nil._N_constant_object)), list<PExpr>.Nil._N_constant_object);
		}
		int length = parms.Length;
		string text = parms.ToString(", ");
		Message.Error(Nemerle.Compiler.Location.Default, string.Concat(string.Concat(string.Concat("macro `CollectParseErrors' expects following list of arguments: (PExpr) got some " + length, " parameters ["), text), "]"));
		throw new Recovery();
	}

	public Tuple<GrammarElement, Function<list<SyntaxElement>, list<SyntaxElement>>> SyntaxExtension()
	{
		return new Tuple<GrammarElement, Function<list<SyntaxElement>, list<SyntaxElement>>>(null, new Identity<list<SyntaxElement>, list<SyntaxElement>>());
	}
}
