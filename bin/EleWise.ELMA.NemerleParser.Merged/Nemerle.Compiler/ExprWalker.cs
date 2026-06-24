using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Compiler.Parsetree;
using Nemerle.Compiler.Typedtree;
using Nemerle.Core;
using Nemerle.Internal;

namespace Nemerle.Compiler;

public class ExprWalker : ISupportRelocation
{
	private sealed class _N__N_lambda__90040__90067 : Function<IMember, IMember, int>
	{
		[SpecialName]
		public static readonly _N__N_lambda__90040__90067 Instance = new _N__N_lambda__90040__90067();

		[SpecialName]
		public sealed override int apply(IMember left, IMember right)
		{
			return left.Location.Line.CompareTo(right.Location.Line);
		}
	}

	private sealed class _N__N_lambda__90266__90274<T> : Function<T, T, int> where T : Located
	{
		[SpecialName]
		public static readonly _N__N_lambda__90266__90274<T> Instance = new _N__N_lambda__90266__90274<T>();

		[SpecialName]
		public sealed override int apply(T i1, T i2)
		{
			checked
			{
				int num = i1.Location.Line - i2.Location.Line;
				return (num < 0) ? (-1) : ((num != 0) ? 1 : (i1.Location.Column - i2.Location.Column));
			}
		}
	}

	private sealed class _N__N_lambda__90309__90340 : Function<SyntaxElement, SyntaxElement, int>
	{
		[SpecialName]
		public static readonly _N__N_lambda__90309__90340 Instance = new _N__N_lambda__90309__90340();

		[SpecialName]
		public sealed override int apply(SyntaxElement p1, SyntaxElement p2)
		{
			checked
			{
				int num = p1.Location.Line - p2.Location.Line;
				return (num < 0) ? (-1) : ((num != 0) ? 1 : (p1.Location.Column - p2.Location.Column));
			}
		}
	}

	private sealed class _N_closureOf_GetLocation_90647
	{
		internal Location _N_loc_90652;

		internal _N_closureOf_GetLocation_90647()
		{
		}
	}

	private sealed class _N__N_lambda__90640__90654 : FunctionVoid<ExprWalkInfo>
	{
		[SpecialName]
		private _N_closureOf_GetLocation_90647 _N_GetLocation_closure_90658;

		public _N__N_lambda__90640__90654(_N_closureOf_GetLocation_90647 _N_GetLocation_closure_90658)
		{
			this._N_GetLocation_closure_90658 = _N_GetLocation_closure_90658;
		}

		[SpecialName]
		public sealed override void apply_void(ExprWalkInfo info)
		{
			object node = info.Node;
			if (node is Located)
			{
				_N_GetLocation_closure_90658._N_loc_90652 = _N_GetLocation_closure_90658._N_loc_90652.Combine(((Located)info.Node).Location);
			}
		}
	}

	private sealed class _N_closureOf_GetLocation_90678
	{
		internal Location _N_loc_90683;

		internal _N_closureOf_GetLocation_90678()
		{
		}
	}

	private sealed class _N__N_lambda__90671__90685 : FunctionVoid<ExprWalkInfo>
	{
		[SpecialName]
		private _N_closureOf_GetLocation_90678 _N_GetLocation_closure_90689;

		public _N__N_lambda__90671__90685(_N_closureOf_GetLocation_90678 _N_GetLocation_closure_90689)
		{
			this._N_GetLocation_closure_90689 = _N_GetLocation_closure_90689;
		}

		[SpecialName]
		public sealed override void apply_void(ExprWalkInfo info)
		{
			object node = info.Node;
			if (node is Located)
			{
				_N_GetLocation_closure_90689._N_loc_90683 = _N_GetLocation_closure_90689._N_loc_90683.Combine(((Located)info.Node).Location);
			}
		}
	}

	private sealed class _N_closureOf_Resolve_90711
	{
		internal bool _N_speculative_90716;

		internal _N_closureOf_Resolve_90711()
		{
		}
	}

	private sealed class _N__N_lambda__90702__90718 : FunctionVoid<ExprWalkInfo>
	{
		[SpecialName]
		private _N_closureOf_Resolve_90711 _N_Resolve_closure_90722;

		public _N__N_lambda__90702__90718(_N_closureOf_Resolve_90711 _N_Resolve_closure_90722)
		{
			this._N_Resolve_closure_90722 = _N_Resolve_closure_90722;
		}

		[SpecialName]
		public sealed override void apply_void(ExprWalkInfo info)
		{
			object node = info.Node;
			if (!(node is TExpr))
			{
				return;
			}
			TExpr tExpr = (TExpr)node;
			if (tExpr is TExpr.Delayed)
			{
				Typer.DelayedTyping susp = ((TExpr.Delayed)tExpr).susp;
				if (!susp.IsResolved)
				{
					susp.Resolve(_N_Resolve_closure_90722._N_speculative_90716);
				}
			}
		}
	}

	private sealed class _N_closureOf_ForEachUnresolvedDelayed_90748
	{
		internal ManagerClass _N_manager_90759;

		internal FunctionVoid<Typer.DelayedTyping> _N_action_90757;

		internal FunctionVoid<ExprWalkInfo> _N_walk_90755;

		internal ExprWalker _N__N_closurised_this_ptr_90753;

		internal _N_closureOf_ForEachUnresolvedDelayed_90748()
		{
		}
	}

	private sealed class _N_walk__90761 : FunctionVoid<ExprWalkInfo>
	{
		[SpecialName]
		private _N_closureOf_ForEachUnresolvedDelayed_90748 _N_ForEachUnresolvedDelayed_closure_90765;

		public _N_walk__90761(_N_closureOf_ForEachUnresolvedDelayed_90748 _N_ForEachUnresolvedDelayed_closure_90765)
		{
			this._N_ForEachUnresolvedDelayed_closure_90765 = _N_ForEachUnresolvedDelayed_closure_90765;
		}

		[SpecialName]
		public sealed override void apply_void(ExprWalkInfo info)
		{
			object node = info.Node;
			Typer.DelayedTyping susp;
			if (node is TExpr.Call)
			{
				if (!(((TExpr.Call)node).func is TExpr.Delayed))
				{
					return;
				}
				susp = ((TExpr.Delayed)((TExpr.Call)node).func).susp;
				if (susp.IsResolved || _N_ForEachUnresolvedDelayed_closure_90765._N_manager_90759.NotResolvedNestedDelayedTypings.Contains(susp))
				{
					return;
				}
			}
			else
			{
				if (!(node is TExpr.Delayed))
				{
					if (node is TExpr.LocalFunRef && ((TExpr.LocalFunRef)node).decl.ValueKind is LocalValue.Kind.Function && ((LocalValue.Kind.Function)((TExpr.LocalFunRef)node).decl.ValueKind).header.Body is FunBody.Typed)
					{
						TFunHeader header = ((LocalValue.Kind.Function)((TExpr.LocalFunRef)node).decl.ValueKind).header;
						TExpr expr = ((FunBody.Typed)((LocalValue.Kind.Function)((TExpr.LocalFunRef)node).decl.ValueKind).header.Body).expr;
						if (_N_ForEachUnresolvedDelayed_closure_90765._N_manager_90759.DelayedTypingsSecondPass && !_N_ForEachUnresolvedDelayed_closure_90765._N_manager_90759.NotResolvedNestedDelayedTypings.Contains(header))
						{
							_N_ForEachUnresolvedDelayed_closure_90765._N_manager_90759.NotResolvedNestedDelayedTypings.Add(header, value: true);
							_N_ForEachUnresolvedDelayed_closure_90765._N__N_closurised_this_ptr_90753.Walk(expr, _N_ForEachUnresolvedDelayed_closure_90765._N_walk_90755.apply_void);
						}
					}
					return;
				}
				susp = ((TExpr.Delayed)node).susp;
				if (susp.IsResolved || _N_ForEachUnresolvedDelayed_closure_90765._N_manager_90759.NotResolvedNestedDelayedTypings.Contains(susp))
				{
					return;
				}
			}
			_N_ForEachUnresolvedDelayed_closure_90765._N_manager_90759.NotResolvedNestedDelayedTypings.Add(susp, value: true);
			_N_ForEachUnresolvedDelayed_closure_90765._N_action_90757.apply_void(susp);
			info.Skip();
		}
	}

	private sealed class _N_closureOf_FindUnresolvedDelayed_90799
	{
		internal List<Typer.DelayedTyping> _N_result_90804;

		internal _N_closureOf_FindUnresolvedDelayed_90799()
		{
		}
	}

	private sealed class _N__N_lambda__90790__90806 : FunctionVoid<ExprWalkInfo>
	{
		[SpecialName]
		private _N_closureOf_FindUnresolvedDelayed_90799 _N_FindUnresolvedDelayed_closure_90810;

		public _N__N_lambda__90790__90806(_N_closureOf_FindUnresolvedDelayed_90799 _N_FindUnresolvedDelayed_closure_90810)
		{
			this._N_FindUnresolvedDelayed_closure_90810 = _N_FindUnresolvedDelayed_closure_90810;
		}

		[SpecialName]
		public sealed override void apply_void(ExprWalkInfo info)
		{
			object node = info.Node;
			if (!(node is TExpr))
			{
				return;
			}
			TExpr tExpr = (TExpr)node;
			if (tExpr is TExpr.Delayed)
			{
				Typer.DelayedTyping susp = ((TExpr.Delayed)tExpr).susp;
				if (!susp.IsResolved)
				{
					_N_FindUnresolvedDelayed_closure_90810._N_result_90804.Add(susp);
				}
			}
		}
	}

	private sealed class _N_closureOf_IsWellTyped_90879
	{
		internal WellTyped _N_result_90884;

		internal _N_closureOf_IsWellTyped_90879()
		{
		}
	}

	private sealed class _N__N_lambda__90870__90886 : FunctionVoid<ExprWalkInfo>
	{
		[SpecialName]
		private _N_closureOf_IsWellTyped_90879 _N_IsWellTyped_closure_90890;

		public _N__N_lambda__90870__90886(_N_closureOf_IsWellTyped_90879 _N_IsWellTyped_closure_90890)
		{
			this._N_IsWellTyped_closure_90890 = _N_IsWellTyped_closure_90890;
		}

		[SpecialName]
		public sealed override void apply_void(ExprWalkInfo info)
		{
			object node = info.Node;
			if (!(node is TExpr))
			{
				return;
			}
			TExpr tExpr = (TExpr)node;
			if (tExpr is TExpr.Error)
			{
				_N_IsWellTyped_closure_90890._N_result_90884 = WellTyped.Error;
				info.Stop();
				return;
			}
			if (tExpr is TExpr.Delayed)
			{
				Typer.DelayedTyping susp = ((TExpr.Delayed)tExpr).susp;
				if (!susp.IsResolved)
				{
					_N_IsWellTyped_closure_90890._N_result_90884 = WellTyped.NotYet;
					info.Stop();
					return;
				}
				if (!tExpr.Type.Hint.IsNone)
				{
					return;
				}
			}
			else if (!tExpr.Type.Hint.IsNone)
			{
				return;
			}
			_N_IsWellTyped_closure_90890._N_result_90884 = WellTyped.NotYet;
			info.Stop();
		}
	}

	private ExprWalkInfo _info = new ExprWalkInfo();

	private IExprWalkerCallback _callback;

	public ExprWalkInfo Info
	{
		[DebuggerStepThrough]
		[CompilerGenerated]
		get
		{
			return _info;
		}
	}

	public IExprWalkerCallback Callback
	{
		[CompilerGenerated]
		[DebuggerStepThrough]
		get
		{
			return _callback;
		}
	}

	public ExprWalker()
	{
	}

	public ExprWalker(IExprWalkerCallback callback)
	{
		_callback = callback;
	}

	protected bool Push(object node)
	{
		return _info.Push(node);
	}

	protected void Pop()
	{
		_info.Pop();
	}

	protected void Init(ExprWalkHandler walkHandler)
	{
		_info.Init(walkHandler, _callback);
	}

	protected void Go(list<PExpr> lst)
	{
		if (lst != null)
		{
			list<PExpr> list = lst;
			while (list is list<PExpr>.Cons)
			{
				PExpr hd = ((list<PExpr>.Cons)list).hd;
				list = ((list<PExpr>.Cons)list).tl;
				Go(hd);
				list = list;
			}
		}
	}

	protected void Go(list<ClassMember> lst)
	{
		if (lst != null)
		{
			list<ClassMember> list = lst;
			while (list is list<ClassMember>.Cons)
			{
				ClassMember hd = ((list<ClassMember>.Cons)list).hd;
				list = ((list<ClassMember>.Cons)list).tl;
				Go(hd);
				list = list;
			}
		}
	}

	protected void Go(list<Splicable> lst)
	{
		if (lst != null)
		{
			list<Splicable> list = lst;
			while (list is list<Splicable>.Cons)
			{
				Splicable hd = ((list<Splicable>.Cons)list).hd;
				list = ((list<Splicable>.Cons)list).tl;
				Go(hd);
				list = list;
			}
		}
	}

	protected void Go(list<SyntaxElement> lst)
	{
		if (lst != null)
		{
			list<SyntaxElement> list = lst;
			while (list is list<SyntaxElement>.Cons)
			{
				SyntaxElement hd = ((list<SyntaxElement>.Cons)list).hd;
				list = ((list<SyntaxElement>.Cons)list).tl;
				Go(hd);
				list = list;
			}
		}
	}

	protected void Go(list<Function_decl> lst)
	{
		if (lst != null)
		{
			list<Function_decl> list = lst;
			while (list is list<Function_decl>.Cons)
			{
				Function_decl hd = ((list<Function_decl>.Cons)list).hd;
				list = ((list<Function_decl>.Cons)list).tl;
				Go(hd);
				list = list;
			}
		}
	}

	protected void Go(list<MatchCase> lst)
	{
		if (lst != null)
		{
			list<MatchCase> list = lst;
			while (list is list<MatchCase>.Cons)
			{
				MatchCase hd = ((list<MatchCase>.Cons)list).hd;
				list = ((list<MatchCase>.Cons)list).tl;
				Go(hd);
				list = list;
			}
		}
	}

	protected void Go(list<TryCase> lst)
	{
		if (lst != null)
		{
			list<TryCase> list = lst;
			while (list is list<TryCase>.Cons)
			{
				TryCase hd = ((list<TryCase>.Cons)list).hd;
				list = ((list<TryCase>.Cons)list).tl;
				Go(hd);
				list = list;
			}
		}
	}

	protected void Go(list<PParameter> lst)
	{
		if (lst != null)
		{
			list<PParameter> list = lst;
			while (list is list<PParameter>.Cons)
			{
				PParameter hd = ((list<PParameter>.Cons)list).hd;
				list = ((list<PParameter>.Cons)list).tl;
				Go(hd);
				list = list;
			}
		}
	}

	protected void Go(list<TExpr> lst)
	{
		if (lst != null)
		{
			list<TExpr> list = lst;
			while (list is list<TExpr>.Cons)
			{
				TExpr hd = ((list<TExpr>.Cons)list).hd;
				list = ((list<TExpr>.Cons)list).tl;
				Go(hd);
				list = list;
			}
		}
	}

	protected void Go(list<Parm> lst)
	{
		if (lst != null)
		{
			list<Parm> list = lst;
			while (list is list<Parm>.Cons)
			{
				Parm hd = ((list<Parm>.Cons)list).hd;
				list = ((list<Parm>.Cons)list).tl;
				Go(hd);
				list = list;
			}
		}
	}

	protected void Go(list<Try_case> lst)
	{
		if (lst != null)
		{
			list<Try_case> list = lst;
			while (list is list<Try_case>.Cons)
			{
				Try_case hd = ((list<Try_case>.Cons)list).hd;
				list = ((list<Try_case>.Cons)list).tl;
				Go(hd);
				list = list;
			}
		}
	}

	protected void Go(list<TParameter> lst)
	{
		if (lst != null)
		{
			list<TParameter> list = lst;
			while (list is list<TParameter>.Cons)
			{
				TParameter hd = ((list<TParameter>.Cons)list).hd;
				list = ((list<TParameter>.Cons)list).tl;
				Go(hd);
				list = list;
			}
		}
	}

	protected void Go(list<TFunHeader> lst)
	{
		if (lst != null)
		{
			list<TFunHeader> list = lst;
			while (list is list<TFunHeader>.Cons)
			{
				TFunHeader hd = ((list<TFunHeader>.Cons)list).hd;
				list = ((list<TFunHeader>.Cons)list).tl;
				Go(hd);
				list = list;
			}
		}
	}

	protected void Go(list<Pattern> lst)
	{
		if (lst != null)
		{
			list<Pattern> list = lst;
			while (list is list<Pattern>.Cons)
			{
				Pattern hd = ((list<Pattern>.Cons)list).hd;
				list = ((list<Pattern>.Cons)list).tl;
				Go(hd);
				list = list;
			}
		}
	}

	protected void Go(list<Match_case> lst)
	{
		if (lst != null)
		{
			list<Match_case> list = lst;
			while (list is list<Match_case>.Cons)
			{
				Match_case hd = ((list<Match_case>.Cons)list).hd;
				list = ((list<Match_case>.Cons)list).tl;
				Go(hd);
				list = list;
			}
		}
	}

	protected void Go(list<IMember> lst)
	{
		if (lst != null)
		{
			list<IMember> list = lst;
			while (list is list<IMember>.Cons)
			{
				IMember hd = ((list<IMember>.Cons)list).hd;
				list = ((list<IMember>.Cons)list).tl;
				Go(hd);
				list = list;
			}
		}
	}

	protected void Go(IMember member)
	{
		if (!_info.Push(member))
		{
			return;
		}
		if (member is MethodBuilder)
		{
			MethodBuilder methodBuilder = (MethodBuilder)member;
			Go(methodBuilder.Ast.name);
			Go(methodBuilder.GetParameters());
			if (!methodBuilder.IsAbstract)
			{
				Go(methodBuilder.BodyParsed);
			}
		}
		else if (member is FieldBuilder)
		{
			FieldBuilder fieldBuilder = (FieldBuilder)member;
			Go(fieldBuilder.Ast.name);
			if (fieldBuilder.IsInitializerPresent)
			{
				Go(fieldBuilder.InitializerParsed);
			}
		}
		else if (member is TypeBuilder)
		{
			TypeBuilder typeBuilder = (TypeBuilder)member;
			Go(typeBuilder.Ast.name);
			list<IMember> directMembers = typeBuilder.GetDirectMembers();
			Function<IMember, IMember, int> instance = _N__N_lambda__90040__90067.Instance;
			Go(directMembers.Sort(instance));
		}
		else if (member is PropertyBuilder)
		{
			PropertyBuilder propertyBuilder = (PropertyBuilder)member;
			if (!propertyBuilder.IsAbstract)
			{
				Go(propertyBuilder.GetGetter());
				Go(propertyBuilder.GetSetter());
			}
		}
		_info.Pop();
	}

	protected void Go(FunBody body)
	{
		if (_info.Push(body))
		{
			if (body is FunBody.Parsed)
			{
				PExpr expr = ((FunBody.Parsed)body).expr;
				Go(expr);
			}
			else if (body is FunBody.Typed)
			{
				TExpr expr2 = ((FunBody.Typed)body).expr;
				Go(expr2);
			}
			else if (body != FunBody.ILed._N_constant_object && body != FunBody.Abstract._N_constant_object)
			{
				throw new MatchFailureException();
			}
			_info.Pop();
		}
	}

	protected void Go(Splicable splicable)
	{
		if (splicable is Splicable.Expression)
		{
			if (1 == 0)
			{
				return;
			}
		}
		else if (0 == 0)
		{
			return;
		}
		if (!_info.Push(splicable))
		{
			return;
		}
		if (!(splicable is Splicable.Name))
		{
			if (splicable is Splicable.Expression)
			{
				PExpr expr = ((Splicable.Expression)splicable).expr;
				Go(expr);
			}
			else if (!(splicable is Splicable.HalfId))
			{
				throw new MatchFailureException();
			}
		}
		_info.Pop();
	}

	protected void Go(Typarms parms)
	{
		if (_info.Push(parms))
		{
			Go(parms.tyvars);
			list<Constraint> list = parms.constraints;
			while (list is list<Constraint>.Cons)
			{
				Constraint hd = ((list<Constraint>.Cons)list).hd;
				list = ((list<Constraint>.Cons)list).tl;
				hd = hd;
				Go(hd.tyvar);
				Go(hd.ty);
				list = list;
			}
			_info.Pop();
		}
	}

	protected void Go(PFunHeader header)
	{
		if (_info.Push(header))
		{
			Go(header.TypeParameters);
			Go(header.SplicableName);
			Go(header.Parameters);
			Go(header.ReturnType);
			_info.Pop();
		}
	}

	protected void Go(Function_decl decl)
	{
		if (_info.Push(decl))
		{
			Go(decl.header);
			Go(decl.body);
			_info.Pop();
		}
	}

	protected void Go(PParameter parm)
	{
		if (_info.Push(parm))
		{
			Go(parm.Type);
			Go(parm.name);
			_info.Pop();
		}
	}

	protected void Go(TryCase tryCase)
	{
		if (!_info.Push(tryCase))
		{
			return;
		}
		if (tryCase is TryCase.Catch)
		{
			Splicable exn = ((TryCase.Catch)tryCase).exn;
			PExpr exn_ty = ((TryCase.Catch)tryCase).exn_ty;
			PExpr handler = ((TryCase.Catch)tryCase).handler;
			Go(exn);
			Go(exn_ty);
			Go(handler);
		}
		else if (tryCase is TryCase.Filter)
		{
			Splicable exn = ((TryCase.Filter)tryCase).exn;
			PExpr exn_ty = ((TryCase.Filter)tryCase).exn_ty;
			PExpr handler = ((TryCase.Filter)tryCase).filter;
			PExpr handler2 = ((TryCase.Filter)tryCase).handler;
			Go(exn);
			Go(exn_ty);
			Go(handler);
			Go(handler2);
		}
		else
		{
			if (!(tryCase is TryCase.Ellipsis))
			{
				throw new MatchFailureException();
			}
			PExpr handler = ((TryCase.Ellipsis)tryCase).body;
			Go(handler);
		}
		_info.Pop();
	}

	protected void Go(MatchCase matchCase)
	{
		if (_info.Push(matchCase))
		{
			Go(matchCase.patterns);
			Go(matchCase.body);
			_info.Pop();
		}
	}

	protected void Go(TopDeclaration decl)
	{
		if (!_info.Push(decl))
		{
			return;
		}
		list<ClassMember> lst2;
		list<PExpr> lst;
		if (decl is TopDeclaration.Class)
		{
			lst = ((TopDeclaration.Class)decl).t_extends;
			lst2 = ((TopDeclaration.Class)decl).decls;
		}
		else
		{
			if (decl is TopDeclaration.Alias)
			{
				PExpr ty = ((TopDeclaration.Alias)decl).ty;
				Go(ty);
				goto IL_01a9;
			}
			if (decl is TopDeclaration.Interface)
			{
				lst = ((TopDeclaration.Interface)decl).t_extends;
				lst2 = ((TopDeclaration.Interface)decl).methods;
			}
			else
			{
				if (!(decl is TopDeclaration.Variant))
				{
					if (decl is TopDeclaration.VariantOption)
					{
						lst2 = ((TopDeclaration.VariantOption)decl).decls;
						Go(lst2);
					}
					else if (decl is TopDeclaration.Macro)
					{
						PFunHeader header = ((TopDeclaration.Macro)decl).header;
						lst = ((TopDeclaration.Macro)decl).synt;
						PExpr ty = ((TopDeclaration.Macro)decl).expr;
						Go(header);
						Go(lst);
						Go(ty);
					}
					else
					{
						if (!(decl is TopDeclaration.Delegate))
						{
							if (decl is TopDeclaration.Enum)
							{
								lst = ((TopDeclaration.Enum)decl).t_extends;
								lst2 = ((TopDeclaration.Enum)decl).decls;
								goto IL_0190;
							}
							throw new MatchFailureException();
						}
						PFunHeader header = ((TopDeclaration.Delegate)decl).header;
						Go(header);
					}
					goto IL_01a9;
				}
				lst = ((TopDeclaration.Variant)decl).t_extends;
				lst2 = ((TopDeclaration.Variant)decl).decls;
			}
		}
		goto IL_0190;
		IL_0190:
		Go(lst);
		Go(lst2);
		goto IL_01a9;
		IL_01a9:
		Go(decl.name);
		_info.Pop();
	}

	protected void Go(ClassMember member)
	{
		if (!_info.Push(member))
		{
			return;
		}
		PExpr expression;
		if (member is ClassMember.TypeDeclaration)
		{
			TopDeclaration td = ((ClassMember.TypeDeclaration)member).td;
			Go(td);
		}
		else
		{
			if (member is ClassMember.Field)
			{
				expression = ((ClassMember.Field)member).ty;
				goto IL_01cd;
			}
			if (member is ClassMember.Function)
			{
				PFunHeader header = ((ClassMember.Function)member).header;
				FunBody body = ((ClassMember.Function)member).body;
				Go(header);
				Go(body);
			}
			else if (member is ClassMember.Property)
			{
				expression = ((ClassMember.Property)member).returnType;
				list<PParameter> lst = ((ClassMember.Property)member).parameters;
				option<ClassMember.Function> option = ((ClassMember.Property)member).getter;
				option<ClassMember.Function> option2 = ((ClassMember.Property)member).setter;
				Go(expression);
				Go(lst);
				if (option is option<ClassMember.Function>.Some)
				{
					ClassMember.Function val = ((option<ClassMember.Function>.Some)option).val;
					Go(val);
				}
				if (option2 is option<ClassMember.Function>.Some)
				{
					ClassMember.Function val = ((option<ClassMember.Function>.Some)option2).val;
					Go(val);
				}
			}
			else if (member is ClassMember.Event)
			{
				expression = ((ClassMember.Event)member).ty;
				ClassMember.Field field = ((ClassMember.Event)member).field;
				ClassMember.Function val = ((ClassMember.Event)member).add;
				ClassMember.Function remove = ((ClassMember.Event)member).remove;
				Go(expression);
				Go(field);
				Go(val);
				Go(remove);
			}
			else
			{
				if (!(member is ClassMember.EnumOption))
				{
					throw new MatchFailureException();
				}
				if (((ClassMember.EnumOption)member).value is option<PExpr>.Some)
				{
					expression = ((option<PExpr>.Some)((ClassMember.EnumOption)member).value).val;
					goto IL_01cd;
				}
			}
		}
		goto IL_01e4;
		IL_01cd:
		Go(expression);
		goto IL_01e4;
		IL_01e4:
		Go(member.name);
		_info.Pop();
	}

	protected void Go(SyntaxElement element)
	{
		if (_info.Push(element))
		{
			PExpr body2;
			switch (SyntaxElement._N_GetVariantCodeSafe(element))
			{
			default:
				throw new MatchFailureException();
			case 0:
				body2 = ((SyntaxElement.Expression)element).body;
				goto IL_00bf;
			case 1:
			{
				MatchCase body5 = ((SyntaxElement.MatchCase)element).body;
				Go(body5);
				break;
			}
			case 2:
			{
				Function_decl body4 = ((SyntaxElement.Function)element).body;
				Go(body4);
				break;
			}
			case 3:
			{
				PParameter body3 = ((SyntaxElement.Parameter)element).body;
				Go(body3);
				break;
			}
			case 4:
				body2 = ((SyntaxElement.TType)element).body;
				goto IL_00bf;
			case 6:
			{
				ClassMember body = ((SyntaxElement.ClassMember)element).body;
				Go(body);
				break;
			}
			case 5:
			case 7:
			case 8:
			case 9:
			case 10:
			case 11:
			case 12:
				break;
				IL_00bf:
				Go(body2);
				break;
			}
			_info.Pop();
		}
	}

	private static list<T> Sort<T>(list<T> lst) where T : Located
	{
		Function<T, T, int> instance = _N__N_lambda__90266__90274<T>.Instance;
		return lst.Sort(instance);
	}

	protected void Go(PExpr expression)
	{
		if (_info.Push(expression))
		{
			Splicable splicable;
			PExpr expression3;
			list<PExpr> list2;
			PExpr expression2;
			switch (PExpr._N_GetVariantCodeSafe(expression))
			{
			default:
				throw new MatchFailureException();
			case 2:
				expression2 = ((PExpr.As)expression).pat;
				splicable = ((PExpr.As)expression).name;
				goto IL_0178;
			case 3:
				expression2 = ((PExpr.Is)expression).pat;
				expression3 = ((PExpr.Is)expression).ty;
				goto IL_0378;
			case 4:
				expression2 = ((PExpr.Where)expression).name;
				expression3 = ((PExpr.Where)expression).fields;
				goto IL_0378;
			case 5:
			{
				expression2 = ((PExpr.Match)expression).expr;
				list<MatchCase> lst3 = ((PExpr.Match)expression).cases;
				Go(expression2);
				Go(lst3);
				break;
			}
			case 7:
				expression2 = ((PExpr.Member)expression).obj;
				splicable = ((PExpr.Member)expression).member;
				goto IL_0178;
			case 8:
				expression2 = ((PExpr.Call)expression).func;
				list2 = ((PExpr.Call)expression).parms;
				goto IL_03c8;
			case 9:
				expression2 = ((PExpr.GenericSpecifier)expression).func;
				list2 = ((PExpr.GenericSpecifier)expression).generic_parms;
				goto IL_03c8;
			case 10:
				list2 = ((PExpr.ListLiteral)expression).elements;
				goto IL_039d;
			case 11:
				expression2 = ((PExpr.Assign)expression).target;
				expression3 = ((PExpr.Assign)expression).source;
				goto IL_0378;
			case 12:
				expression2 = ((PExpr.DefMutable)expression).name;
				expression3 = ((PExpr.DefMutable)expression).val;
				goto IL_0378;
			case 13:
				expression2 = ((PExpr.Define)expression).pattern;
				expression3 = ((PExpr.Define)expression).val;
				goto IL_0378;
			case 14:
			{
				list<Function_decl> lst2 = ((PExpr.DefFunctions)expression).funs;
				Go(lst2);
				break;
			}
			case 15:
			{
				Function_decl decl = ((PExpr.Lambda)expression).decl;
				Go(decl);
				break;
			}
			case 16:
				expression2 = ((PExpr.Throw)expression).exn;
				goto IL_0488;
			case 17:
			{
				expression2 = ((PExpr.Try)expression).body;
				list<TryCase> lst = ((PExpr.Try)expression).cases;
				Go(expression2);
				Go(lst);
				break;
			}
			case 18:
				expression2 = ((PExpr.TryFinally)expression).body;
				expression3 = ((PExpr.TryFinally)expression).handler;
				goto IL_0378;
			case 22:
				expression2 = ((PExpr.Typeof)expression).ty;
				goto IL_0488;
			case 23:
				expression2 = ((PExpr.TypeConversion)expression).expr;
				expression3 = ((PExpr.TypeConversion)expression).ty;
				goto IL_0378;
			case 24:
				expression2 = ((PExpr.TypeEnforcement)expression).expr;
				expression3 = ((PExpr.TypeEnforcement)expression).ty;
				goto IL_0378;
			case 25:
				list2 = ((PExpr.Sequence)expression).body;
				goto IL_039d;
			case 26:
				list2 = ((PExpr.Tuple)expression).args;
				goto IL_039d;
			case 27:
				expression2 = ((PExpr.Array)expression).rank;
				expression3 = ((PExpr.Array)expression).args;
				goto IL_0378;
			case 28:
				list2 = ((PExpr.EmptyArray)expression).sizes;
				goto IL_039d;
			case 29:
				expression2 = ((PExpr.Indexer)expression).obj;
				list2 = ((PExpr.Indexer)expression).args;
				goto IL_03c8;
			case 30:
				expression2 = ((PExpr.ParmByRef)expression).parm;
				goto IL_0488;
			case 31:
				expression2 = ((PExpr.ParmOut)expression).parm;
				goto IL_0488;
			case 33:
			{
				list<SyntaxElement> list = ((PExpr.MacroCall)expression).parms;
				Function<SyntaxElement, SyntaxElement, int> instance = _N__N_lambda__90309__90340.Instance;
				Go(list.Sort(instance));
				break;
			}
			case 34:
			{
				SyntaxElement body2 = ((PExpr.Quoted)expression).body;
				Go(body2);
				break;
			}
			case 35:
				expression2 = ((PExpr.Spliced)expression).body;
				goto IL_0488;
			case 37:
				expression2 = ((PExpr.Ellipsis)expression).body;
				goto IL_0488;
			case 38:
			{
				TExpr body = ((PExpr.Typed)expression).body;
				Go(body);
				break;
			}
			case 0:
			case 1:
			case 6:
			case 19:
			case 20:
			case 21:
			case 32:
			case 36:
			case 39:
			case 40:
				break;
				IL_0488:
				Go(expression2);
				break;
				IL_039d:
				Go(list2);
				break;
				IL_03c8:
				if ((object)list2 == list<PExpr>.Nil._N_constant_object)
				{
					Go(expression2);
				}
				else
				{
					Go(Sort(new list<PExpr>.Cons(expression2, list2)));
				}
				break;
				IL_0178:
				Go(expression2);
				Go(splicable);
				break;
				IL_0378:
				Go(expression2);
				Go(expression3);
				break;
			}
			_info.Pop();
		}
	}

	protected void Go(Parm parm)
	{
		if (_info.Push(parm))
		{
			Go(parm.expr);
			_info.Pop();
		}
	}

	protected void Go(LocalValue localValue)
	{
		if (_info.Push(localValue))
		{
			_info.Pop();
		}
	}

	protected void Go(Try_case tryCase)
	{
		if (!_info.Push(tryCase))
		{
			return;
		}
		if (tryCase is Try_case.Fault)
		{
			TExpr handler = ((Try_case.Fault)tryCase).handler;
			Go(handler);
		}
		else if (tryCase is Try_case.Catch)
		{
			LocalValue exn = ((Try_case.Catch)tryCase).exn;
			TExpr handler = ((Try_case.Catch)tryCase).handler;
			Go(exn);
			Go(handler);
		}
		else
		{
			if (!(tryCase is Try_case.Filter))
			{
				throw new MatchFailureException();
			}
			LocalValue exn = ((Try_case.Filter)tryCase).exn;
			TExpr handler = ((Try_case.Filter)tryCase).filter;
			TExpr handler2 = ((Try_case.Filter)tryCase).handler;
			Go(exn);
			Go(handler);
			Go(handler2);
		}
		_info.Pop();
	}

	protected void Go(TParameter parm)
	{
		if (_info.Push(parm))
		{
			option<TExpr> default_value = parm.default_value;
			if (default_value is option<TExpr>.Some)
			{
				TExpr val = ((option<TExpr>.Some)default_value).val;
				Go(val);
			}
			_info.Pop();
		}
	}

	protected void Go(TFunHeader header)
	{
		if (_info.Push(header))
		{
			Go(header.Parameters);
			Go(header.body);
			_info.Pop();
		}
	}

	protected void Go(Match_case @case)
	{
		if (!_info.Push(@case))
		{
			return;
		}
		list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>> list = @case.patterns;
		while (list is list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons)
		{
			Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>> hd = ((list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons)list).hd;
			list = ((list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons)list).tl;
			Pattern field = hd.Field0;
			TExpr field2 = hd.Field1;
			list<Nemerle.Builtins.Tuple<LocalValue, TExpr>> list2 = hd.Field2;
			Go(field);
			Go(field2);
			list2 = list2;
			while (list2 is list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>.Cons)
			{
				Nemerle.Builtins.Tuple<LocalValue, TExpr> hd2 = ((list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>.Cons)list2).hd;
				list2 = ((list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>.Cons)list2).tl;
				field2 = hd2.Field1;
				Go(field2);
				list2 = list2;
			}
			list = list;
		}
		Go(@case.body);
		_info.Pop();
	}

	protected void Go(Pattern pattern)
	{
		if (!_info.Push(pattern))
		{
			return;
		}
		if (!(pattern is Pattern.Wildcard))
		{
			if (pattern is Pattern.As)
			{
				Pattern pat = ((Pattern.As)pattern).pat;
				LocalValue decl = ((Pattern.As)pattern).decl;
				Go(pat);
				Go(decl);
			}
			else if (!(pattern is Pattern.HasType))
			{
				if (pattern is Pattern.Tuple)
				{
					list<Pattern> lst = ((Pattern.Tuple)pattern).args;
					Go(lst);
				}
				else if (pattern is Pattern.Record)
				{
					list<Nemerle.Builtins.Tuple<IMember, Pattern>> list = ((Pattern.Record)pattern).args;
					list = list;
					while (list is list<Nemerle.Builtins.Tuple<IMember, Pattern>>.Cons)
					{
						Nemerle.Builtins.Tuple<IMember, Pattern> hd = ((list<Nemerle.Builtins.Tuple<IMember, Pattern>>.Cons)list).hd;
						list = ((list<Nemerle.Builtins.Tuple<IMember, Pattern>>.Cons)list).tl;
						Pattern pat = hd.Field1;
						Go(pat);
						list = list;
					}
				}
				else if (pattern is Pattern.Application)
				{
					Pattern pat = ((Pattern.Application)pattern).arg;
					Go(pat);
				}
				else if (!(pattern is Pattern.Enum) && !(pattern is Pattern.Literal) && !(pattern is Pattern.Error))
				{
					throw new MatchFailureException();
				}
			}
		}
		_info.Pop();
	}

	protected void Go(TExpr expression)
	{
		if (!_info.Push(expression))
		{
			return;
		}
		TExpr expression3;
		TExpr expression2;
		switch (TExpr._N_GetVariantCodeSafe(expression))
		{
		default:
			throw new MatchFailureException();
		case 3:
			expression2 = ((TExpr.FieldMember)expression).obj;
			goto IL_06ae;
		case 4:
			expression2 = ((TExpr.MethodRef)expression).obj;
			goto IL_06ae;
		case 5:
		{
			expression2 = ((TExpr.Call)expression).func;
			list<Parm> lst = ((TExpr.Call)expression).parms;
			Go(expression2);
			Go(lst);
			break;
		}
		case 6:
			expression2 = ((TExpr.Assign)expression).target;
			expression3 = ((TExpr.Assign)expression).source;
			goto IL_0252;
		case 7:
		{
			LocalValue field = ((TExpr.DefValIn)expression).name;
			expression2 = ((TExpr.DefValIn)expression).val;
			expression3 = ((TExpr.DefValIn)expression).body;
			Go(field);
			Go(expression2);
			Go(expression3);
			break;
		}
		case 8:
			expression2 = ((TExpr.Throw)expression).exn;
			goto IL_06ae;
		case 9:
			expression2 = ((TExpr.TryFinally)expression).body;
			expression3 = ((TExpr.TryFinally)expression).handler;
			goto IL_0252;
		case 10:
		{
			expression2 = ((TExpr.Try)expression).body;
			list<Try_case> lst6 = ((TExpr.Try)expression).cases;
			Go(expression2);
			Go(lst6);
			break;
		}
		case 14:
			expression2 = ((TExpr.TypeConversion)expression).expr;
			goto IL_06ae;
		case 15:
			expression2 = ((TExpr.Sequence)expression).e1;
			expression3 = ((TExpr.Sequence)expression).e2;
			goto IL_0252;
		case 16:
		{
			list<TExpr> lst4 = ((TExpr.Tuple)expression).args;
			Go(lst4);
			break;
		}
		case 17:
		{
			list<TExpr> lst5 = ((TExpr.Array)expression).args;
			list<TExpr> lst4 = ((TExpr.Array)expression).dimensions;
			Go(lst5);
			Go(lst4);
			break;
		}
		case 22:
			expression2 = ((TExpr.ClosureObjectOf)expression).varRef;
			Go(expression2);
			break;
		case 23:
			expression2 = ((TExpr.ClosureFieldOf)expression).varRef;
			Go(expression2);
			break;
		case 24:
		{
			expression2 = ((TExpr.ArrayIndexer)expression).obj;
			list<TExpr> lst4 = ((TExpr.ArrayIndexer)expression).args;
			Go(expression2);
			Go(lst4);
			break;
		}
		case 25:
			expression2 = ((TExpr.PointerIndexer)expression).obj;
			expression3 = ((TExpr.PointerIndexer)expression).index;
			Go(expression2);
			Go(expression3);
			break;
		case 26:
			expression2 = ((TExpr.TupleIndexer)expression).obj;
			goto IL_06ae;
		case 28:
		{
			expression2 = ((TExpr.MacroEnvelope)expression).expanded;
			PExpr expandedPExpr = ((TExpr.MacroEnvelope)expression).expandedPExpr;
			Go(expression2);
			Go(expandedPExpr);
			break;
		}
		case 29:
			expression2 = ((TExpr.PropertyMember)expression).obj;
			goto IL_06ae;
		case 31:
			expression2 = ((TExpr.EventMember)expression).obj;
			goto IL_06ae;
		case 34:
		{
			LocalValue field = ((TExpr.Block)expression).jump_out;
			expression2 = ((TExpr.Block)expression).body;
			Go(field);
			Go(expression2);
			break;
		}
		case 35:
		{
			Typer.DelayedTyping susp = ((TExpr.Delayed)expression).susp;
			if (susp.IsResolved)
			{
				Go(susp.ResolutionResult);
			}
			break;
		}
		case 36:
		{
			CacheDesc desc = ((TExpr.Cache)expression).desc;
			expression2 = ((TExpr.Cache)expression).body;
			Go(desc.TExpr);
			Go(expression2);
			break;
		}
		case 37:
		{
			CacheDesc desc = ((TExpr.CacheRef)expression).desc;
			Go(desc.TExpr);
			break;
		}
		case 39:
		{
			list<TFunHeader> lst3 = ((TExpr.DefFunctionsIn)expression).funs;
			expression2 = ((TExpr.DefFunctionsIn)expression).body;
			Go(lst3);
			Go(expression2);
			break;
		}
		case 40:
		{
			expression2 = ((TExpr.Match)expression).expr;
			list<Match_case> lst2 = ((TExpr.Match)expression).cases;
			Go(expression2);
			Go(lst2);
			break;
		}
		case 41:
		{
			list<Parm> lst = ((TExpr.SelfTailCall)expression).parms;
			Go(lst);
			break;
		}
		case 44:
		{
			list<Nemerle.Builtins.Tuple<LocalValue, TExpr>> list2 = ((TExpr.MultipleAssign)expression).assigns;
			list2 = list2;
			while (list2 is list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>.Cons)
			{
				Nemerle.Builtins.Tuple<LocalValue, TExpr> hd2 = ((list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>.Cons)list2).hd;
				list2 = ((list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>.Cons)list2).tl;
				LocalValue field = hd2.Field0;
				expression2 = hd2.Field1;
				Go(field);
				Go(expression2);
				list2 = list2;
			}
			break;
		}
		case 45:
			expression2 = ((TExpr.Label)expression).body;
			goto IL_06ae;
		case 48:
		{
			expression3 = ((TExpr.If)expression).cond;
			expression2 = ((TExpr.If)expression).e_then;
			TExpr e_else = ((TExpr.If)expression).e_else;
			Go(expression3);
			Go(expression2);
			Go(e_else);
			break;
		}
		case 49:
			expression2 = ((TExpr.HasType)expression).expr;
			goto IL_06ae;
		case 50:
		{
			expression2 = ((TExpr.Switch)expression).indexing_expr;
			option<TExpr> option = ((TExpr.Switch)expression).@default;
			list<Nemerle.Builtins.Tuple<int, TExpr>> list = ((TExpr.Switch)expression).cases;
			Go(expression2);
			if (option is option<TExpr>.Some)
			{
				expression2 = ((option<TExpr>.Some)option).val;
				Go(expression2);
			}
			list = list;
			while (list is list<Nemerle.Builtins.Tuple<int, TExpr>>.Cons)
			{
				Nemerle.Builtins.Tuple<int, TExpr> hd = ((list<Nemerle.Builtins.Tuple<int, TExpr>>.Cons)list).hd;
				list = ((list<Nemerle.Builtins.Tuple<int, TExpr>>.Cons)list).tl;
				expression2 = hd.Field1;
				Go(expression2);
				list = list;
			}
			break;
		}
		case 51:
			expression2 = ((TExpr.DebugInfo)expression).expr;
			if (expression2 == null)
			{
				break;
			}
			goto IL_06ae;
		case 52:
		case 53:
			if (!Message.SeenError)
			{
				string text = "wrong node type".ToString();
				Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
			}
			throw new AssertionException("ncc\\misc\\ExprWalker.n", 691, "", "wrong node type");
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
		case 30:
		case 32:
		case 33:
		case 38:
		case 42:
		case 43:
		case 46:
		case 47:
			break;
			IL_0252:
			Go(expression2);
			Go(expression3);
			break;
			IL_06ae:
			Go(expression2);
			break;
		}
		_info.Pop();
	}

	public void Walk([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] PExpr expression, [Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] ExprWalkHandler walkHandler)
	{
		if (walkHandler == null)
		{
			throw new ArgumentNullException("walkHandler", "The ``NotNull'' contract of parameter ``walkHandler'' has been violated. See ncc\\misc\\ExprWalker.n:698:57:698:68: .");
		}
		if (expression == null)
		{
			throw new ArgumentNullException("expression", "The ``NotNull'' contract of parameter ``expression'' has been violated. See ncc\\misc\\ExprWalker.n:698:27:698:37: .");
		}
		Init(walkHandler);
		Go(expression);
	}

	public void Walk([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] Pattern pattern, [Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] ExprWalkHandler walkHandler)
	{
		if (walkHandler == null)
		{
			throw new ArgumentNullException("walkHandler", "The ``NotNull'' contract of parameter ``walkHandler'' has been violated. See ncc\\misc\\ExprWalker.n:704:58:704:69: .");
		}
		if (pattern == null)
		{
			throw new ArgumentNullException("pattern", "The ``NotNull'' contract of parameter ``pattern'' has been violated. See ncc\\misc\\ExprWalker.n:704:27:704:34: .");
		}
		Init(walkHandler);
		Go(pattern);
	}

	public void Walk([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] ClassMember member, [Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] ExprWalkHandler walkHandler)
	{
		if (walkHandler == null)
		{
			throw new ArgumentNullException("walkHandler", "The ``NotNull'' contract of parameter ``walkHandler'' has been violated. See ncc\\misc\\ExprWalker.n:710:61:710:72: .");
		}
		if (member == null)
		{
			throw new ArgumentNullException("member", "The ``NotNull'' contract of parameter ``member'' has been violated. See ncc\\misc\\ExprWalker.n:710:27:710:33: .");
		}
		Init(walkHandler);
		Go(member);
	}

	public void Walk([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] TExpr expression, [Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] ExprWalkHandler walkHandler)
	{
		if (walkHandler == null)
		{
			throw new ArgumentNullException("walkHandler", "The ``NotNull'' contract of parameter ``walkHandler'' has been violated. See ncc\\misc\\ExprWalker.n:716:57:716:68: .");
		}
		if (expression == null)
		{
			throw new ArgumentNullException("expression", "The ``NotNull'' contract of parameter ``expression'' has been violated. See ncc\\misc\\ExprWalker.n:716:27:716:37: .");
		}
		Init(walkHandler);
		Go(expression);
	}

	public Location GetLocation(PExpr expression)
	{
		_N_closureOf_GetLocation_90647 n_closureOf_GetLocation_ = new _N_closureOf_GetLocation_90647();
		n_closureOf_GetLocation_._N_loc_90652 = expression.Location;
		FunctionVoid<ExprWalkInfo> functionVoid = new _N__N_lambda__90640__90654(n_closureOf_GetLocation_);
		Walk(expression, functionVoid.apply_void);
		return n_closureOf_GetLocation_._N_loc_90652;
	}

	public Location GetLocation(ClassMember member)
	{
		_N_closureOf_GetLocation_90678 n_closureOf_GetLocation_ = new _N_closureOf_GetLocation_90678();
		n_closureOf_GetLocation_._N_loc_90683 = member.Location;
		FunctionVoid<ExprWalkInfo> functionVoid = new _N__N_lambda__90671__90685(n_closureOf_GetLocation_);
		Walk(member, functionVoid.apply_void);
		return n_closureOf_GetLocation_._N_loc_90683;
	}

	public void Resolve(TExpr expression, bool speculative = false)
	{
		_N_closureOf_Resolve_90711 n_closureOf_Resolve_ = new _N_closureOf_Resolve_90711();
		n_closureOf_Resolve_._N_speculative_90716 = speculative;
		FunctionVoid<ExprWalkInfo> functionVoid = new _N__N_lambda__90702__90718(n_closureOf_Resolve_);
		Walk(expression, functionVoid.apply_void);
	}

	public void ForEachUnresolvedDelayed(ManagerClass manager, TExpr expression, FunctionVoid<Typer.DelayedTyping> action)
	{
		_N_closureOf_ForEachUnresolvedDelayed_90748 n_closureOf_ForEachUnresolvedDelayed_ = new _N_closureOf_ForEachUnresolvedDelayed_90748();
		n_closureOf_ForEachUnresolvedDelayed_._N_manager_90759 = manager;
		n_closureOf_ForEachUnresolvedDelayed_._N_action_90757 = action;
		n_closureOf_ForEachUnresolvedDelayed_._N__N_closurised_this_ptr_90753 = this;
		n_closureOf_ForEachUnresolvedDelayed_._N_walk_90755 = new _N_walk__90761(n_closureOf_ForEachUnresolvedDelayed_);
		Walk(expression, n_closureOf_ForEachUnresolvedDelayed_._N_walk_90755.apply_void);
	}

	public IEnumerable<Typer.DelayedTyping> FindUnresolvedDelayed(TExpr expression)
	{
		_N_closureOf_FindUnresolvedDelayed_90799 n_closureOf_FindUnresolvedDelayed_ = new _N_closureOf_FindUnresolvedDelayed_90799();
		n_closureOf_FindUnresolvedDelayed_._N_result_90804 = new List<Typer.DelayedTyping>();
		FunctionVoid<ExprWalkInfo> functionVoid = new _N__N_lambda__90790__90806(n_closureOf_FindUnresolvedDelayed_);
		Walk(expression, functionVoid.apply_void);
		return n_closureOf_FindUnresolvedDelayed_._N_result_90804;
	}

	public WellTyped IsWellTyped(TExpr expression)
	{
		_N_closureOf_IsWellTyped_90879 n_closureOf_IsWellTyped_ = new _N_closureOf_IsWellTyped_90879();
		n_closureOf_IsWellTyped_._N_result_90884 = WellTyped.Yes;
		FunctionVoid<ExprWalkInfo> functionVoid = new _N__N_lambda__90870__90886(n_closureOf_IsWellTyped_);
		Walk(expression, functionVoid.apply_void);
		return n_closureOf_IsWellTyped_._N_result_90884;
	}

	[CompilerGenerated]
	internal override void RelocateImplInternal(RelocationInfo _info)
	{
		if (!_info.VisitedObjects.ContainsKey(this))
		{
			_info.VisitedObjects[this] = 0;
			IExprWalkerCallback callback = _callback;
			if (callback != null)
			{
				((ISupportRelocation)callback).RelocateImpl(_info);
			}
			this._info?.RelocateImplInternal(_info);
		}
	}

	void ISupportRelocation.RelocateImpl(RelocationInfo _info)
	{
		//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
		this.RelocateImplInternal(_info);
	}
}
