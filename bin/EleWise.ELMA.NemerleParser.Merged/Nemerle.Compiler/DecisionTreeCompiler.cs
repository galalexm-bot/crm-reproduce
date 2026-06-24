using System;
using System.IO;
using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Collections;
using Nemerle.Compiler.Typedtree;
using Nemerle.Core;
using Nemerle.Internal;

namespace Nemerle.Compiler;

public class DecisionTreeCompiler : ISupportRelocation
{
	[TypeAlias("Nemerle.Compiler.DecisionTreeBuilder+Path()")]
	private interface Path
	{
	}

	[TypeAlias("Nemerle.Compiler.DecisionTreeBuilder+Decision()")]
	private interface Decision
	{
	}

	private class SharedEffect : ISupportRelocation
	{
		private sealed class _N_closureOf_GetExpr_61289
		{
			internal TExpr _N_effect_expr_61294;

			internal _N_closureOf_GetExpr_61289()
			{
			}
		}

		private sealed class _N__N_lambda__61277__61299 : Function<Nemerle.Builtins.Tuple<LocalValue, TExpr>, TExpr, TExpr>
		{
			[SpecialName]
			private _N_closureOf_GetExpr_61289 _N_GetExpr_closure_61303;

			public _N__N_lambda__61277__61299(_N_closureOf_GetExpr_61289 _N_GetExpr_closure_61303)
			{
				this._N_GetExpr_closure_61303 = _N_GetExpr_closure_61303;
			}

			[SpecialName]
			public sealed override TExpr apply(Nemerle.Builtins.Tuple<LocalValue, TExpr> assign, TExpr acc)
			{
				LocalValue field = assign.Field0;
				TExpr field2 = assign.Field1;
				Location location = field2.Location;
				bool flag = location.FileIndex != 0;
				if (flag)
				{
					LocationStack.Push(location);
				}
				try
				{
					return new TExpr.Sequence(_N_GetExpr_closure_61303._N_effect_expr_61294.Type, new TExpr.Assign(new TExpr.LocalRef(field.Type, field), field2), acc);
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

		private TExpr body;

		private option<int> label_id;

		private bool body_emitted;

		private readonly DecisionTreeCompiler parent;

		public SharedEffect(DecisionTreeCompiler par, TExpr body)
		{
			parent = par;
			this.body = body;
			label_id = option<int>.None._N_constant_object;
		}

		public TExpr GetExpr()
		{
			option<int> option = label_id;
			object result;
			if (option is option<int>.Some)
			{
				int val = ((option<int>.Some)option).val;
				result = new TExpr.Goto(body.Location, null, val, 1);
			}
			else
			{
				if (option != option<int>.None._N_constant_object)
				{
					throw new MatchFailureException();
				}
				int val = body.Type.Manager.GetNewId();
				label_id = new option<int>.Some(val);
				body_emitted = true;
				result = new TExpr.Label(body.Location, body.Type, val, body);
			}
			return (TExpr)result;
		}

		public TExpr GetExpr(list<Nemerle.Builtins.Tuple<LocalValue, TExpr>> assigns)
		{
			_N_closureOf_GetExpr_61289 n_closureOf_GetExpr_ = new _N_closureOf_GetExpr_61289();
			n_closureOf_GetExpr_._N_effect_expr_61294 = GetExpr();
			TExpr result;
			if (assigns.IsEmpty)
			{
				result = n_closureOf_GetExpr_._N_effect_expr_61294;
			}
			else
			{
				TExpr n_effect_expr_ = n_closureOf_GetExpr_._N_effect_expr_61294;
				Function<Nemerle.Builtins.Tuple<LocalValue, TExpr>, TExpr, TExpr> f = new _N__N_lambda__61277__61299(n_closureOf_GetExpr_);
				result = assigns.FoldRight(n_effect_expr_, f);
			}
			return result;
		}

		public TExpr BuildRest(TExpr prev)
		{
			object result;
			if (body_emitted || label_id.IsNone)
			{
				result = prev;
			}
			else
			{
				body_emitted = true;
				result = new TExpr.Sequence(prev.Location, body.Type, prev, body);
			}
			return (TExpr)result;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				_info.VisitedObjects[this] = 0;
				parent?.RelocateImplInternal(_info);
				body?.RelocateImplInternal(_info);
			}
		}

		void ISupportRelocation.RelocateImpl(RelocationInfo _info)
		{
			//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
			this.RelocateImplInternal(_info);
		}
	}

	[Variant("Nemerle.Compiler.DecisionTreeCompiler.SingleSwitchCaseHandler.NonRequiredSwitchExpr,Nemerle.Compiler.DecisionTreeCompiler.SingleSwitchCaseHandler.RequiredSwitchExpr")]
	private abstract class SingleSwitchCaseHandler : ISupportRelocation
	{
		[VariantOption]
		public class NonRequiredSwitchExpr : SingleSwitchCaseHandler
		{
			public readonly Function<DecisionTreeBuilder.Decision.IfEq, TExpr, TExpr> handler;

			[SpecialName]
			public override int _N_GetVariantCode()
			{
				return 0;
			}

			[RecordCtor]
			public NonRequiredSwitchExpr([MappedMember("handler")] Function<DecisionTreeBuilder.Decision.IfEq, TExpr, TExpr> handler)
			{
				this.handler = handler;
			}
		}

		[VariantOption]
		public class RequiredSwitchExpr : SingleSwitchCaseHandler
		{
			public readonly Function<TExpr, DecisionTreeBuilder.Decision.IfEq, TExpr, TExpr> handler;

			[SpecialName]
			public override int _N_GetVariantCode()
			{
				return 1;
			}

			[RecordCtor]
			public RequiredSwitchExpr([MappedMember("handler")] Function<TExpr, DecisionTreeBuilder.Decision.IfEq, TExpr, TExpr> handler)
			{
				this.handler = handler;
			}
		}

		[SpecialName]
		public abstract override int _N_GetVariantCode();

		[SpecialName]
		public static int _N_GetVariantCodeSafe(SingleSwitchCaseHandler x)
		{
			return ((object)x != null) ? x._N_GetVariantCode() : (-1);
		}

		[SpecialName]
		public static int _N_GetVariantCodeObject(object x)
		{
			return (!(x is SingleSwitchCaseHandler)) ? (-1) : ((SingleSwitchCaseHandler)x)._N_GetVariantCode();
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

	private sealed class _N__N_lambda__60005__60021 : Function<Match_case, bool>
	{
		[SpecialName]
		public static readonly _N__N_lambda__60005__60021 Instance = new _N__N_lambda__60005__60021();

		[SpecialName]
		public sealed override bool apply(Match_case mc)
		{
			return mc.disable_warnings;
		}
	}

	private sealed class _N_closureOf_collect_effects_and_guards_60071
	{
		internal DecisionTreeCompiler _N__N_closurised_this_ptr_60076;

		internal _N_closureOf_collect_effects_and_guards_60071()
		{
		}
	}

	private sealed class _N_closureOf_walk_patterns_60095
	{
		internal SharedEffect _N_effect_60102;

		internal list<Nemerle.Builtins.Tuple<LocalValue, TExpr>> _N_assigns_60100;

		internal _N_closureOf_walk_patterns_60095()
		{
		}
	}

	private sealed class _N__N_lambda__60065__60107 : Function<TExpr>
	{
		[SpecialName]
		private _N_closureOf_walk_patterns_60095 _N_walk_patterns_closure_60111;

		public _N__N_lambda__60065__60107(_N_closureOf_walk_patterns_60095 _N_walk_patterns_closure_60111)
		{
			this._N_walk_patterns_closure_60111 = _N_walk_patterns_closure_60111;
		}

		[SpecialName]
		public sealed override TExpr apply()
		{
			return _N_walk_patterns_closure_60111._N_effect_60102.GetExpr(_N_walk_patterns_closure_60111._N_assigns_60100);
		}
	}

	private sealed class _N_closureOf_compile2_60247
	{
		internal DecisionTreeCompiler _N__N_closurised_this_ptr_60252;

		internal _N_closureOf_compile2_60247()
		{
		}
	}

	private sealed class _N_preventInlining__60270 : Function<TExpr, TExpr>
	{
		[SpecialName]
		private _N_closureOf_compile2_60247 _N_compile2_closure_60274;

		public _N_preventInlining__60270(_N_closureOf_compile2_60247 _N_compile2_closure_60274)
		{
			this._N_compile2_closure_60274 = _N_compile2_closure_60274;
		}

		[SpecialName]
		public sealed override TExpr apply(TExpr expr)
		{
			object result;
			if (expr is TExpr.Call)
			{
				LocalValue decl;
				if (((TExpr.Call)expr).func is TExpr.LocalFunRef)
				{
					decl = ((TExpr.LocalFunRef)((TExpr.Call)expr).func).decl;
				}
				else
				{
					if (!(((TExpr.Call)expr).func is TExpr.LocalRef))
					{
						goto IL_013a;
					}
					decl = ((TExpr.LocalRef)((TExpr.Call)expr).func).decl;
				}
				LocalValue.Kind valKind = decl.ValKind;
				if (valKind is LocalValue.Kind.Function)
				{
					TFunHeader header = ((LocalValue.Kind.Function)valKind).header;
					switch (header.usage)
					{
					default:
						throw new MatchFailureException();
					case FunctionUsage.NotUsed:
						if (!Message.SeenError)
						{
							string text = "(see backtrace)".ToString();
							Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
						}
						throw new AssertionException("ncc\\generation\\DecisionTreeCompiler.n", 256, "", "(see backtrace)");
					case FunctionUsage.UsedJustOnce:
						header.usage = FunctionUsage.Used;
						_N_compile2_closure_60274._N__N_closurised_this_ptr_60252.typer3.EmitStaticLocalFunction(header);
						break;
					case FunctionUsage.Used:
					case FunctionUsage.UsedAsFirstClass:
						break;
					}
					result = null;
				}
				else
				{
					result = null;
				}
				goto IL_0142;
			}
			goto IL_013a;
			IL_0142:
			return (TExpr)result;
			IL_013a:
			result = null;
			goto IL_0142;
		}
	}

	private sealed class _N_closureOf_compile_ifeq_60391
	{
		internal DecisionTreeCompiler _N__N_closurised_this_ptr_60398;

		internal TypeInfo _N_rootVar_60396;

		internal _N_closureOf_compile_ifeq_60391()
		{
		}
	}

	private sealed class _N__N_lambda__60343__60461 : Function<DecisionTreeBuilder.Decision.IfEq, Nemerle.Builtins.Tuple<bool, int>>
	{
		[SpecialName]
		private _N_closureOf_compile_ifeq_60391 _N_compile_ifeq_closure_60465;

		public _N__N_lambda__60343__60461(_N_closureOf_compile_ifeq_60391 _N_compile_ifeq_closure_60465)
		{
			this._N_compile_ifeq_closure_60465 = _N_compile_ifeq_closure_60465;
		}

		[SpecialName]
		public sealed override Nemerle.Builtins.Tuple<bool, int> apply(DecisionTreeBuilder.Decision.IfEq decision)
		{
			DecisionTreeBuilder.Con con = decision.con;
			Nemerle.Builtins.Tuple<bool, int> result;
			if (con is DecisionTreeBuilder.Con.Variant)
			{
				TypeInfo ti = ((DecisionTreeBuilder.Con.Variant)con).ti;
				if (_N_compile_ifeq_closure_60465._N_rootVar_60396.BaseType.Equals(ti.BaseType))
				{
					result = new Nemerle.Builtins.Tuple<bool, int>(field0: true, ti.VariantOptionCode);
					goto IL_005d;
				}
			}
			result = new Nemerle.Builtins.Tuple<bool, int>(field0: false, 0);
			goto IL_005d;
			IL_005d:
			return result;
		}
	}

	private sealed class _N__N_lambda__60349__60475 : Function<DecisionTreeBuilder.Decision.IfEq, TExpr, TExpr>
	{
		[SpecialName]
		private _N_closureOf_compile_ifeq_60391 _N_compile_ifeq_closure_60479;

		public _N__N_lambda__60349__60475(_N_closureOf_compile_ifeq_60391 _N_compile_ifeq_closure_60479)
		{
			this._N_compile_ifeq_closure_60479 = _N_compile_ifeq_closure_60479;
		}

		[SpecialName]
		public sealed override TExpr apply(DecisionTreeBuilder.Decision.IfEq decision, TExpr @default)
		{
			DecisionTreeBuilder.Con con = decision.con;
			if (con is DecisionTreeBuilder.Con.Variant)
			{
				TypeInfo ti = ((DecisionTreeBuilder.Con.Variant)con).ti;
				TExpr path_expr = _N_compile_ifeq_closure_60479._N__N_closurised_this_ptr_60398.get_path_expression(decision.path);
				TExpr true_expr = _N_compile_ifeq_closure_60479._N__N_closurised_this_ptr_60398.compile(decision.if_true);
				return _N_compile_ifeq_closure_60479._N__N_closurised_this_ptr_60398._N_compile_variant_60401(_N_compile_ifeq_closure_60479, ti, path_expr, true_expr, @default, _N_compile_ifeq_closure_60479._N__N_closurised_this_ptr_60398.get_debug_loc(decision.if_true), _N_compile_ifeq_closure_60479._N__N_closurised_this_ptr_60398.get_debug_loc(decision.if_false));
			}
			if (!Message.SeenError)
			{
				string text = ("unexpected decision tree node `" + Convert.ToString(decision) + "'").ToString();
				Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
			}
			throw new AssertionException("ncc\\generation\\DecisionTreeCompiler.n", 389, "", ("unexpected decision tree node `" + Convert.ToString(decision) + "'").ToString());
		}
	}

	private sealed class _N__N_lambda__60368__60515 : Function<DecisionTreeBuilder.Decision.IfEq, Nemerle.Builtins.Tuple<bool, int>>
	{
		[SpecialName]
		public static readonly _N__N_lambda__60368__60515 Instance = new _N__N_lambda__60368__60515();

		[SpecialName]
		public sealed override Nemerle.Builtins.Tuple<bool, int> apply(DecisionTreeBuilder.Decision.IfEq decision)
		{
			DecisionTreeBuilder.Con con = decision.con;
			Nemerle.Builtins.Tuple<bool, int> result;
			if (con is DecisionTreeBuilder.Con.Lit)
			{
				Literal lit = ((DecisionTreeBuilder.Con.Lit)con).lit;
				option<int> asRawInt = lit.AsRawInt;
				if (asRawInt is option<int>.Some)
				{
					int val = ((option<int>.Some)asRawInt).val;
					result = new Nemerle.Builtins.Tuple<bool, int>(field0: true, val);
				}
				else
				{
					result = new Nemerle.Builtins.Tuple<bool, int>(field0: false, 0);
				}
			}
			else
			{
				result = new Nemerle.Builtins.Tuple<bool, int>(field0: false, 0);
			}
			return result;
		}
	}

	private sealed class _N__N_lambda__60375__60535 : Function<TExpr, DecisionTreeBuilder.Decision.IfEq, TExpr, TExpr>
	{
		[SpecialName]
		private _N_closureOf_compile_ifeq_60391 _N_compile_ifeq_closure_60539;

		public _N__N_lambda__60375__60535(_N_closureOf_compile_ifeq_60391 _N_compile_ifeq_closure_60539)
		{
			this._N_compile_ifeq_closure_60539 = _N_compile_ifeq_closure_60539;
		}

		[SpecialName]
		public sealed override TExpr apply(TExpr switchExpr, DecisionTreeBuilder.Decision.IfEq decision, TExpr @default)
		{
			DecisionTreeBuilder.Con con = decision.con;
			if (con is DecisionTreeBuilder.Con.Lit)
			{
				Literal lit = ((DecisionTreeBuilder.Con.Lit)con).lit;
				TExpr true_expr = _N_compile_ifeq_closure_60539._N__N_closurised_this_ptr_60398.compile(decision.if_true);
				return _N_compile_ifeq_closure_60539._N__N_closurised_this_ptr_60398._N_compile_literal_60414(_N_compile_ifeq_closure_60539, lit, switchExpr, true_expr, @default, _N_compile_ifeq_closure_60539._N__N_closurised_this_ptr_60398.get_debug_loc(decision.if_true), _N_compile_ifeq_closure_60539._N__N_closurised_this_ptr_60398.get_debug_loc(decision.if_false));
			}
			if (!Message.SeenError)
			{
				string text = ("unexpected decision tree node `" + Convert.ToString(decision) + "'").ToString();
				Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
			}
			throw new AssertionException("ncc\\generation\\DecisionTreeCompiler.n", 445, "", ("unexpected decision tree node `" + Convert.ToString(decision) + "'").ToString());
		}
	}

	private sealed class _N_closureOf_compile_switch_60666
	{
		internal DecisionTreeBuilder.Decision.IfEq _N_root_60685;

		internal int _N_minSwitchSize_60683;

		internal Function<DecisionTreeBuilder.Decision.IfEq, Nemerle.Builtins.Tuple<bool, int>> _N_caseSelector_60681;

		internal SingleSwitchCaseHandler _N_compileSingleCase_60679;

		internal DecisionTreeBuilder.Decision _N_default_60677;

		internal list<list<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>>>.Cons _N_caseClusters_60675;

		internal bool _N_switchExprIsUsed_60673;

		internal DecisionTreeCompiler _N__N_closurised_this_ptr_60671;

		internal _N_closureOf_compile_switch_60666()
		{
		}
	}

	private sealed class _N__N_lambda__60589__60714 : Function<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>, Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>, int>
	{
		[SpecialName]
		public static readonly _N__N_lambda__60589__60714 Instance = new _N__N_lambda__60589__60714();

		[SpecialName]
		public sealed override int apply(Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq> _N__60712, Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq> _N__60713)
		{
			int field = _N__60713.Field0;
			int field2 = _N__60712.Field0;
			return field.CompareTo(field2);
		}
	}

	private sealed class _N__N_lambda__60598__60728 : Function<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>, list<list<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>>>.Cons, list<list<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>>>.Cons>
	{
		[SpecialName]
		public static readonly _N__N_lambda__60598__60728 Instance = new _N__N_lambda__60598__60728();

		[SpecialName]
		public sealed override list<list<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>>>.Cons apply(Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq> @case, list<list<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>>>.Cons _N_pat_3343)
		{
			if (_N_pat_3343.hd is list<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>>.Cons)
			{
				list<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>>.Cons cons = (list<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>>.Cons)_N_pat_3343.hd;
				Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq> hd = ((list<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>>.Cons)_N_pat_3343.hd).hd;
				list<list<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>>> tl = _N_pat_3343.tl;
				return (hd.Field0 - @case.Field0) switch
				{
					1 => new list<list<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>>>.Cons(new list<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>>.Cons(@case, cons), tl), 
					2 => new list<list<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>>>.Cons(new list<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>>.Cons(@case, new list<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>>.Cons(new Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>(checked(@case.Field0 + 1), null), cons)), tl), 
					3 => new list<list<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>>>.Cons(new list<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>>.Cons(@case, checked(new list<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>>.Cons(new Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>(@case.Field0 + 1, null), new list<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>>.Cons(new Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>(@case.Field0 + 2, null), cons)))), tl), 
					_ => new list<list<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>>>.Cons(new list<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>>.Cons(@case, list<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>>.Nil._N_constant_object), new list<list<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>>>.Cons(cons, tl)), 
				};
			}
			throw new MatchFailureException();
		}
	}

	private sealed class _N__N_lambda__60609__60748 : Function<TExpr, TExpr>
	{
		[SpecialName]
		private _N_closureOf_compile_switch_60666 _N_compile_switch_closure_60752;

		public _N__N_lambda__60609__60748(_N_closureOf_compile_switch_60666 _N_compile_switch_closure_60752)
		{
			this._N_compile_switch_closure_60752 = _N_compile_switch_closure_60752;
		}

		[SpecialName]
		public sealed override TExpr apply(TExpr switchExpr)
		{
			_N_closureOf__N_lambda__60609_60757 n_closureOf__N_lambda__60609_ = new _N_closureOf__N_lambda__60609_60757();
			n_closureOf__N_lambda__60609_._N_switchExpr_60762 = switchExpr;
			list<list<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>>>.Cons n_caseClusters_ = _N_compile_switch_closure_60752._N_caseClusters_60675;
			TExpr acc = _N_compile_switch_closure_60752._N__N_closurised_this_ptr_60671.compile(_N_compile_switch_closure_60752._N_default_60677);
			Function<list<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>>, TExpr, TExpr> f = new _N__N_lambda__60614__60764(n_closureOf__N_lambda__60609_, _N_compile_switch_closure_60752);
			return n_caseClusters_.FoldRight(acc, f);
		}
	}

	private sealed class _N_closureOf__N_lambda__60609_60757
	{
		internal TExpr _N_switchExpr_60762;

		internal _N_closureOf__N_lambda__60609_60757()
		{
		}
	}

	private sealed class _N__N_lambda__60614__60764 : Function<list<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>>, TExpr, TExpr>
	{
		[SpecialName]
		private _N_closureOf_compile_switch_60666 _N_compile_switch_closure_60770;

		[SpecialName]
		private _N_closureOf__N_lambda__60609_60757 _N__N_lambda__60609_closure_60768;

		public _N__N_lambda__60614__60764(_N_closureOf__N_lambda__60609_60757 _N__N_lambda__60609_closure_60768, _N_closureOf_compile_switch_60666 _N_compile_switch_closure_60770)
		{
			this._N__N_lambda__60609_closure_60768 = _N__N_lambda__60609_closure_60768;
			this._N_compile_switch_closure_60770 = _N_compile_switch_closure_60770;
		}

		[SpecialName]
		public sealed override TExpr apply(list<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>> cases, TExpr @default)
		{
			_N_closureOf__N_lambda__60614_60775 n_closureOf__N_lambda__60614_ = new _N_closureOf__N_lambda__60614_60775();
			if ((object)cases == list<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>>.Nil._N_constant_object)
			{
				if (!Message.SeenError)
				{
					string text = "got empty list of switch cases".ToString();
					Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
				}
				throw new AssertionException("ncc\\generation\\DecisionTreeCompiler.n", 548, "", "got empty list of switch cases");
			}
			list<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>> list = cases;
			TExpr result;
			if (list.Length < _N_compile_switch_closure_60770._N_minSwitchSize_60683)
			{
				Function<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>, TExpr, TExpr> function2;
				Function<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>, TExpr, TExpr> function;
				if (_N_compile_switch_closure_60770._N_compileSingleCase_60679 is SingleSwitchCaseHandler.NonRequiredSwitchExpr)
				{
					n_closureOf__N_lambda__60614_._N_handler_60784 = ((SingleSwitchCaseHandler.NonRequiredSwitchExpr)_N_compile_switch_closure_60770._N_compileSingleCase_60679).handler;
					function = new _N__N_lambda__60623__60798(n_closureOf__N_lambda__60614_);
					function2 = function;
				}
				else
				{
					if (!(_N_compile_switch_closure_60770._N_compileSingleCase_60679 is SingleSwitchCaseHandler.RequiredSwitchExpr))
					{
						throw new MatchFailureException();
					}
					n_closureOf__N_lambda__60614_._N_handler_60782 = ((SingleSwitchCaseHandler.RequiredSwitchExpr)_N_compile_switch_closure_60770._N_compileSingleCase_60679).handler;
					_N_compile_switch_closure_60770._N_switchExprIsUsed_60673 = true;
					function = new _N__N_lambda__60632__60817(n_closureOf__N_lambda__60614_, _N__N_lambda__60609_closure_60768);
					function2 = function;
				}
				function = function2;
				result = list.FoldRight(@default, function);
			}
			else
			{
				_N_compile_switch_closure_60770._N_switchExprIsUsed_60673 = true;
				int field = cases.Head.Field0;
				Nemerle.Builtins.Tuple<TExpr, int> tuple;
				if (field == 0)
				{
					tuple = new Nemerle.Builtins.Tuple<TExpr, int>(_N__N_lambda__60609_closure_60768._N_switchExpr_60762, 0);
				}
				else
				{
					field = field;
					TExpr.Call call = new TExpr.Call(_N_compile_switch_closure_60770._N__N_closurised_this_ptr_60671.InternalType.Int32, new TExpr.OpCode("-.f"), new list<Parm>.Cons(new Parm(_N__N_lambda__60609_closure_60768._N_switchExpr_60762), new list<Parm>.Cons(new Parm(new TExpr.Literal(_N_compile_switch_closure_60770._N__N_closurised_this_ptr_60671.InternalType.Int32, Literal.FromInt(field))), list<Parm>.Nil._N_constant_object)), is_tail: false);
					tuple = new Nemerle.Builtins.Tuple<TExpr, int>(call, field);
				}
				Nemerle.Builtins.Tuple<TExpr, int> tuple2 = tuple;
				TExpr field2 = tuple2.Field0;
				n_closureOf__N_lambda__60614_._N_delta_60780 = tuple2.Field1;
				Nemerle.Builtins.Tuple<list<Nemerle.Builtins.Tuple<int, TExpr>>, TExpr> acc = new Nemerle.Builtins.Tuple<list<Nemerle.Builtins.Tuple<int, TExpr>>, TExpr>(list<Nemerle.Builtins.Tuple<int, TExpr>>.Nil._N_constant_object, @default);
				Function<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>, Nemerle.Builtins.Tuple<list<Nemerle.Builtins.Tuple<int, TExpr>>, TExpr>, Nemerle.Builtins.Tuple<list<Nemerle.Builtins.Tuple<int, TExpr>>, TExpr>> f = new _N__N_lambda__60645__60851(n_closureOf__N_lambda__60614_, _N_compile_switch_closure_60770);
				Nemerle.Builtins.Tuple<list<Nemerle.Builtins.Tuple<int, TExpr>>, TExpr> tuple3 = cases.FoldRight(acc, f);
				list<Nemerle.Builtins.Tuple<int, TExpr>> cases2 = tuple3.Field0;
				TExpr field3 = tuple3.Field1;
				result = Switch(field2, new option<TExpr>.Some(field3), cases2);
			}
			return result;
		}
	}

	private sealed class _N_closureOf__N_lambda__60614_60775
	{
		internal Function<DecisionTreeBuilder.Decision.IfEq, TExpr, TExpr> _N_handler_60784;

		internal Function<TExpr, DecisionTreeBuilder.Decision.IfEq, TExpr, TExpr> _N_handler_60782;

		internal int _N_delta_60780;

		internal _N_closureOf__N_lambda__60614_60775()
		{
		}
	}

	private sealed class _N__N_lambda__60623__60798 : Function<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>, TExpr, TExpr>
	{
		[SpecialName]
		private _N_closureOf__N_lambda__60614_60775 _N__N_lambda__60614_closure_60802;

		public _N__N_lambda__60623__60798(_N_closureOf__N_lambda__60614_60775 _N__N_lambda__60614_closure_60802)
		{
			this._N__N_lambda__60614_closure_60802 = _N__N_lambda__60614_closure_60802;
		}

		[SpecialName]
		public sealed override TExpr apply(Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq> _N__60796, TExpr _N__60797)
		{
			TExpr result;
			if ((object)_N__60796.Field1 == null)
			{
				result = _N__60797;
			}
			else
			{
				DecisionTreeBuilder.Decision.IfEq field = _N__60796.Field1;
				result = _N__N_lambda__60614_closure_60802._N_handler_60784.apply(field, _N__60797);
			}
			return result;
		}
	}

	private sealed class _N__N_lambda__60632__60817 : Function<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>, TExpr, TExpr>
	{
		[SpecialName]
		private _N_closureOf__N_lambda__60609_60757 _N__N_lambda__60609_closure_60823;

		[SpecialName]
		private _N_closureOf__N_lambda__60614_60775 _N__N_lambda__60614_closure_60821;

		public _N__N_lambda__60632__60817(_N_closureOf__N_lambda__60614_60775 _N__N_lambda__60614_closure_60821, _N_closureOf__N_lambda__60609_60757 _N__N_lambda__60609_closure_60823)
		{
			this._N__N_lambda__60614_closure_60821 = _N__N_lambda__60614_closure_60821;
			this._N__N_lambda__60609_closure_60823 = _N__N_lambda__60609_closure_60823;
		}

		[SpecialName]
		public sealed override TExpr apply(Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq> _N__60815, TExpr _N__60816)
		{
			TExpr result;
			if ((object)_N__60815.Field1 == null)
			{
				result = _N__60816;
			}
			else
			{
				DecisionTreeBuilder.Decision.IfEq field = _N__60815.Field1;
				result = _N__N_lambda__60614_closure_60821._N_handler_60782.apply(_N__N_lambda__60609_closure_60823._N_switchExpr_60762, field, _N__60816);
			}
			return result;
		}
	}

	private sealed class _N__N_lambda__60645__60851 : Function<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>, Nemerle.Builtins.Tuple<list<Nemerle.Builtins.Tuple<int, TExpr>>, TExpr>, Nemerle.Builtins.Tuple<list<Nemerle.Builtins.Tuple<int, TExpr>>, TExpr>>
	{
		[SpecialName]
		private _N_closureOf_compile_switch_60666 _N_compile_switch_closure_60857;

		[SpecialName]
		private _N_closureOf__N_lambda__60614_60775 _N__N_lambda__60614_closure_60855;

		public _N__N_lambda__60645__60851(_N_closureOf__N_lambda__60614_60775 _N__N_lambda__60614_closure_60855, _N_closureOf_compile_switch_60666 _N_compile_switch_closure_60857)
		{
			this._N__N_lambda__60614_closure_60855 = _N__N_lambda__60614_closure_60855;
			this._N_compile_switch_closure_60857 = _N_compile_switch_closure_60857;
		}

		[SpecialName]
		public sealed override Nemerle.Builtins.Tuple<list<Nemerle.Builtins.Tuple<int, TExpr>>, TExpr> apply(Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq> _N__60849, Nemerle.Builtins.Tuple<list<Nemerle.Builtins.Tuple<int, TExpr>>, TExpr> _N__60850)
		{
			list<Nemerle.Builtins.Tuple<int, TExpr>> tl = _N__60850.Field0;
			TExpr field = _N__60850.Field1;
			int field2;
			Nemerle.Builtins.Tuple<TExpr.Goto, TExpr> tuple;
			int target;
			if ((object)_N__60849.Field1 == null)
			{
				field2 = _N__60849.Field0;
				if (field is TExpr.Goto)
				{
					target = ((TExpr.Goto)field).target;
				}
				else
				{
					if (!(field is TExpr.Label))
					{
						target = _N_compile_switch_closure_60857._N__N_closurised_this_ptr_60671.Manager.GetNewId();
						tuple = new Nemerle.Builtins.Tuple<TExpr.Goto, TExpr>(new TExpr.Goto(field.Type, target, 0), new TExpr.Label(field.Location, field.Type, target, field));
						goto IL_00b3;
					}
					target = ((TExpr.Label)field).id;
				}
				tuple = new Nemerle.Builtins.Tuple<TExpr.Goto, TExpr>(new TExpr.Goto(field.Type, target, 0), field);
				goto IL_00b3;
			}
			target = _N__60849.Field0;
			DecisionTreeBuilder.Decision.IfEq field3 = _N__60849.Field1;
			Nemerle.Builtins.Tuple<list<Nemerle.Builtins.Tuple<int, TExpr>>, TExpr> result = new Nemerle.Builtins.Tuple<list<Nemerle.Builtins.Tuple<int, TExpr>>, TExpr>(new list<Nemerle.Builtins.Tuple<int, TExpr>>.Cons(new Nemerle.Builtins.Tuple<int, TExpr>(checked(target - _N__N_lambda__60614_closure_60855._N_delta_60780), _N_compile_switch_closure_60857._N__N_closurised_this_ptr_60671.compile(field3.if_true)), tl), field);
			goto IL_013e;
			IL_00b3:
			Nemerle.Builtins.Tuple<TExpr.Goto, TExpr> tuple2 = tuple;
			field = tuple2.Field0;
			TExpr field4 = tuple2.Field1;
			result = new Nemerle.Builtins.Tuple<list<Nemerle.Builtins.Tuple<int, TExpr>>, TExpr>(new list<Nemerle.Builtins.Tuple<int, TExpr>>.Cons(new Nemerle.Builtins.Tuple<int, TExpr>(checked(field2 - _N__N_lambda__60614_closure_60855._N_delta_60780), field), tl), field4);
			goto IL_013e;
			IL_013e:
			return result;
		}
	}

	private sealed class _N_closureOf_get_stats_60969
	{
		internal int _N_num_nodes_60984;

		internal int _N_num_shared_60982;

		internal Hashtable<DecisionTreeBuilder.Decision, DecisionTreeBuilder.Decision> _N_shared_nodes_60980;

		internal int _N_all_paths_length_60978;

		internal int _N_num_paths_60976;

		internal int _N_longest_path_60974;

		internal _N_closureOf_get_stats_60969()
		{
		}
	}

	private sealed class _N__N_lambda__61147__61163 : Function<Nemerle.Builtins.Tuple<int, TExpr>, TypeVar, TypeVar>
	{
		[SpecialName]
		public static readonly _N__N_lambda__61147__61163 Instance = new _N__N_lambda__61147__61163();

		[SpecialName]
		public sealed override TypeVar apply(Nemerle.Builtins.Tuple<int, TExpr> _N__61161, TypeVar _N__61162)
		{
			TExpr field = _N__61161.Field1;
			object result;
			if ((object)_N__61162 == null)
			{
				result = field.Type;
			}
			else
			{
				result = ((!_N__61162.IsFixed) ? field.Type : _N__61162);
			}
			return (TypeVar)result;
		}
	}

	private readonly TypeVar tyvar;

	private readonly TExpr val;

	private readonly list<Match_case> cases;

	private readonly DecisionTreeBuilder.Decision decision;

	private Function<TExpr>[] effects;

	private SharedEffect[] shared_effects;

	private TExpr[] guards;

	private bool[] guardUsed;

	private readonly int jump_out_id;

	private readonly Typer3 typer3;

	private readonly int min_switch_size_for_variants;

	private readonly int min_switch_size_for_ordinals;

	public readonly ManagerClass Manager;

	public InternalTypeClass InternalType => Manager.InternalType;

	public SystemTypeClass SystemTypeCache => Manager.SystemTypeCache;

	public DecisionTreeCompiler(TypeVar t, TExpr val, list<Match_case> mcs, Typer3 typer3)
	{
		Manager = t.Manager;
		this.typer3 = typer3;
		tyvar = t;
		this.val = val;
		cases = mcs;
		jump_out_id = Manager.GetNewId();
		min_switch_size_for_variants = Manager.Options.MatchOptions.MinSwitchSizeForVariants;
		min_switch_size_for_ordinals = Manager.Options.MatchOptions.MinSwitchSizeForOrdinals;
		DecisionTreeBuilder decisionTreeBuilder = new DecisionTreeBuilder(mcs);
		Function<Match_case, bool> instance = _N__N_lambda__60005__60021.Instance;
		if (!mcs.Exists(instance) && Manager.Solver.CurrentMessenger.NeedMessage)
		{
			decisionTreeBuilder.CheckMatching();
		}
		list<Match_case> list = mcs;
		while (list is list<Match_case>.Cons)
		{
			Match_case hd = ((list<Match_case>.Cons)list).hd;
			list = ((list<Match_case>.Cons)list).tl;
			Typer.FixupMatchCase(hd);
			list = list;
		}
		decision = decisionTreeBuilder.GetDecision();
		if (Manager.Options.DumpDecisionTree)
		{
			Message.Debug(string.Concat(string.Concat("decision tree", Convert.ToString(dag_to_string(decision, Manager.Options.ColorMessages)) + Environment.NewLine), Convert.ToString(get_stats(decision)) + Environment.NewLine));
		}
		collect_effects_and_guards();
	}

	private void collect_effects_and_guards()
	{
		_N_closureOf_collect_effects_and_guards_60071 n_closureOf_collect_effects_and_guards_ = new _N_closureOf_collect_effects_and_guards_60071();
		n_closureOf_collect_effects_and_guards_._N__N_closurised_this_ptr_60076 = this;
		list<Match_case> list = cases;
		if (!(list is list<Match_case>.Cons))
		{
			throw new AssertionException("ncc\\generation\\DecisionTreeCompiler.n", 172, "(cases is _  :: _ )", "");
		}
		_N_walk_cases_60079(n_closureOf_collect_effects_and_guards_, 0, cases);
	}

	public TExpr Run()
	{
		int num = 0;
		TExpr tExpr = null;
		tExpr = compile(decision);
		SharedEffect[] array = shared_effects;
		foreach (SharedEffect sharedEffect in array)
		{
			tExpr = sharedEffect.BuildRest(tExpr);
		}
		tExpr.Type.ForceRequire(tyvar);
		return tExpr;
	}

	public static TExpr Run(TypeVar t, TExpr val, list<Match_case> mcs, Typer3 typer3)
	{
		DecisionTreeCompiler decisionTreeCompiler = new DecisionTreeCompiler(t, val, mcs, typer3);
		return decisionTreeCompiler.Run();
	}

	private TExpr compile(DecisionTreeBuilder.Decision decision)
	{
		object result;
		if (decision is DecisionTreeBuilder.Decision.Success)
		{
			result = compile2(decision);
		}
		else if (decision.IsShared)
		{
			option<int> labelId = decision.LabelId;
			if (labelId == option<int>.None._N_constant_object)
			{
				int newId = Manager.GetNewId();
				decision.LabelId = new option<int>.Some(newId);
				TExpr tExpr = compile2(decision);
				result = new TExpr.Label(tExpr.Location, tExpr.Type, newId, tExpr);
			}
			else
			{
				if (!(labelId is option<int>.Some))
				{
					throw new MatchFailureException();
				}
				int target = ((option<int>.Some)labelId).val;
				result = new TExpr.Goto(target, 1);
			}
		}
		else
		{
			Location location = decision.Location;
			bool flag = location.FileIndex != 0;
			if (flag)
			{
				LocationStack.Push(location);
			}
			TExpr tExpr2;
			try
			{
				tExpr2 = compile2(decision);
			}
			finally
			{
				if (flag)
				{
					LocationStack.RemoveTop();
				}
			}
			result = tExpr2;
		}
		return (TExpr)result;
	}

	private TExpr compile2(DecisionTreeBuilder.Decision decision)
	{
		_N_closureOf_compile2_60247 n_closureOf_compile2_ = new _N_closureOf_compile2_60247();
		n_closureOf_compile2_._N__N_closurised_this_ptr_60252 = this;
		TExpr result;
		if (decision is DecisionTreeBuilder.Decision.Success)
		{
			int res = ((DecisionTreeBuilder.Decision.Success)decision).res;
			TExpr tExpr = effects[res].apply();
			result = tExpr;
		}
		else if (decision is DecisionTreeBuilder.Decision.Failure)
		{
			result = ThrowMatchFailure();
		}
		else if (decision is DecisionTreeBuilder.Decision.Assign)
		{
			DecisionTreeBuilder.Path path = ((DecisionTreeBuilder.Decision.Assign)decision).path;
			LocalValue decl = ((DecisionTreeBuilder.Decision.Assign)decision).decl;
			DecisionTreeBuilder.Decision dtree = ((DecisionTreeBuilder.Decision.Assign)decision).dtree;
			TExpr tExpr = get_path_expression(path);
			TExpr.Assign e = new TExpr.Assign(new TExpr.LocalRef(decl.Type, decl), Cast(tExpr, decl.Type));
			Location loc = get_debug_loc(decision);
			tExpr = compile(dtree);
			tExpr = ((!loc.IsEmpty) ? new TExpr.DebugInfo(loc, null, tExpr, null) : tExpr);
			result = Sequence(e, tExpr);
		}
		else
		{
			if (!(decision is DecisionTreeBuilder.Decision.IfEq))
			{
				throw new AssertionException("ncc\\generation\\DecisionTreeCompiler.n", 280, "", "");
			}
			if (((DecisionTreeBuilder.Decision.IfEq)decision).con == DecisionTreeBuilder.Con.Guard._N_constant_object && ((DecisionTreeBuilder.Decision.IfEq)decision).if_true is DecisionTreeBuilder.Decision.Success)
			{
				DecisionTreeBuilder.Decision.Success success = (DecisionTreeBuilder.Decision.Success)((DecisionTreeBuilder.Decision.IfEq)decision).if_true;
				int res = ((DecisionTreeBuilder.Decision.Success)((DecisionTreeBuilder.Decision.IfEq)decision).if_true).res;
				DecisionTreeBuilder.Decision dtree = ((DecisionTreeBuilder.Decision.IfEq)decision).if_false;
				TExpr e2 = compile(success);
				TExpr tExpr = compile(dtree);
				TExpr tExpr2;
				if (guardUsed[res])
				{
					Function<TExpr, TExpr> f = new _N_preventInlining__60270(n_closureOf_compile2_);
					tExpr2 = guards[res].Walk(f);
				}
				else
				{
					guardUsed[res] = true;
					tExpr2 = guards[res];
				}
				TExpr cond = tExpr2;
				result = If(cond, e2, tExpr, get_debug_loc(success), get_debug_loc(dtree));
			}
			else
			{
				result = compile_ifeq((DecisionTreeBuilder.Decision.IfEq)decision);
			}
		}
		return result;
	}

	private TExpr compile_ifeq(DecisionTreeBuilder.Decision.IfEq decision)
	{
		_N_closureOf_compile_ifeq_60391 n_closureOf_compile_ifeq_ = new _N_closureOf_compile_ifeq_60391();
		n_closureOf_compile_ifeq_._N__N_closurised_this_ptr_60398 = this;
		DecisionTreeBuilder.Con con = decision.con;
		FixedType.Class from;
		Nemerle.Builtins.Tuple<string, FixedType.Fun, TExpr> tuple;
		object obj;
		TExpr tExpr;
		if (con is DecisionTreeBuilder.Con.Variant)
		{
			n_closureOf_compile_ifeq_._N_rootVar_60396 = ((DecisionTreeBuilder.Con.Variant)con).ti;
			if (min_switch_size_for_variants > 0)
			{
				DecisionTreeBuilder.Decision if_false = decision.if_false;
				if (if_false is DecisionTreeBuilder.Decision.IfEq && ((DecisionTreeBuilder.Decision.IfEq)if_false).con is DecisionTreeBuilder.Con.Variant)
				{
					DecisionTreeBuilder.Path path = ((DecisionTreeBuilder.Decision.IfEq)if_false).path;
					if (((DecisionTreeBuilder.Decision.IfEq)if_false).if_false is DecisionTreeBuilder.Decision.IfEq)
					{
						TypeInfo ti = ((DecisionTreeBuilder.Con.Variant)((DecisionTreeBuilder.Decision.IfEq)if_false).con).ti;
						if (((DecisionTreeBuilder.Decision.IfEq)((DecisionTreeBuilder.Decision.IfEq)if_false).if_false).con is DecisionTreeBuilder.Con.Variant)
						{
							DecisionTreeBuilder.Path path2 = ((DecisionTreeBuilder.Decision.IfEq)((DecisionTreeBuilder.Decision.IfEq)if_false).if_false).path;
							TypeInfo ti2 = ((DecisionTreeBuilder.Con.Variant)((DecisionTreeBuilder.Decision.IfEq)((DecisionTreeBuilder.Decision.IfEq)if_false).if_false).con).ti;
							if (n_closureOf_compile_ifeq_._N_rootVar_60396.BaseType.Equals(ti.BaseType) && n_closureOf_compile_ifeq_._N_rootVar_60396.BaseType.Equals(ti2.BaseType) && decision.path.Equals(path) && decision.path.Equals(path2))
							{
								tExpr = get_path_expression(decision.path);
								FixedType.Class freshType = n_closureOf_compile_ifeq_._N_rootVar_60396.GetFreshType();
								FixedType.Class @class;
								if ((object)freshType.args == list<TypeVar>.Nil._N_constant_object)
								{
									@class = freshType;
								}
								else
								{
									freshType = freshType;
									tExpr.Type.ForceProvide(freshType);
									@class = freshType;
								}
								from = @class;
								FixedType fixedType = tExpr.Type.Fix();
								if (fixedType is FixedType.Class)
								{
									freshType = (FixedType.Class)fixedType;
									if (n_closureOf_compile_ifeq_._N_rootVar_60396.BaseType.Equals(freshType.TypeInfo))
									{
										tuple = new Nemerle.Builtins.Tuple<string, FixedType.Fun, TExpr>("_N_GetVariantCodeSafe", new FixedType.Fun(freshType, 1, InternalType.Int32), tExpr);
										goto IL_024c;
									}
								}
								tuple = new Nemerle.Builtins.Tuple<string, FixedType.Fun, TExpr>("_N_GetVariantCodeObject", new FixedType.Fun(InternalType.Object, 1, InternalType.Int32), Cast(tExpr, InternalType.Object));
								goto IL_024c;
							}
						}
					}
				}
				obj = null;
			}
			else
			{
				obj = null;
			}
			goto IL_02fc;
		}
		Literal lit;
		object obj2;
		Function<DecisionTreeBuilder.Decision.IfEq, Nemerle.Builtins.Tuple<bool, int>> instance;
		if (con is DecisionTreeBuilder.Con.Lit)
		{
			lit = ((DecisionTreeBuilder.Con.Lit)con).lit;
			if (min_switch_size_for_ordinals > 0 && lit.AsRawInt.IsSome)
			{
				DecisionTreeBuilder.Decision if_false = decision.if_false;
				if (if_false is DecisionTreeBuilder.Decision.IfEq && ((DecisionTreeBuilder.Decision.IfEq)if_false).con is DecisionTreeBuilder.Con.Lit)
				{
					DecisionTreeBuilder.Path path = ((DecisionTreeBuilder.Decision.IfEq)if_false).path;
					if (((DecisionTreeBuilder.Decision.IfEq)if_false).if_false is DecisionTreeBuilder.Decision.IfEq)
					{
						Literal lit2 = ((DecisionTreeBuilder.Con.Lit)((DecisionTreeBuilder.Decision.IfEq)if_false).con).lit;
						if (((DecisionTreeBuilder.Decision.IfEq)((DecisionTreeBuilder.Decision.IfEq)if_false).if_false).con is DecisionTreeBuilder.Con.Lit)
						{
							DecisionTreeBuilder.Path path2 = ((DecisionTreeBuilder.Decision.IfEq)((DecisionTreeBuilder.Decision.IfEq)if_false).if_false).path;
							Literal lit3 = ((DecisionTreeBuilder.Con.Lit)((DecisionTreeBuilder.Decision.IfEq)((DecisionTreeBuilder.Decision.IfEq)if_false).if_false).con).lit;
							if (lit2.AsRawInt.IsSome && lit3.AsRawInt.IsSome && decision.path.Equals(path) && decision.path.Equals(path2))
							{
								TExpr switchExpr = get_path_expression(decision.path);
								int minSwitchSize = min_switch_size_for_ordinals;
								instance = _N__N_lambda__60368__60515.Instance;
								Function<DecisionTreeBuilder.Decision.IfEq, Nemerle.Builtins.Tuple<bool, int>> caseSelector = instance;
								Function<TExpr, DecisionTreeBuilder.Decision.IfEq, TExpr, TExpr> compileSingleCase = new _N__N_lambda__60375__60535(n_closureOf_compile_ifeq_);
								obj2 = compile_switch(switchExpr, decision, minSwitchSize, caseSelector, compileSingleCase);
								goto IL_0508;
							}
						}
					}
				}
				obj2 = null;
			}
			else
			{
				obj2 = null;
			}
			goto IL_0508;
		}
		TExpr result;
		if (con is DecisionTreeBuilder.Con.Type)
		{
			FixedType fixedType = ((DecisionTreeBuilder.Con.Type)con).ti;
			tExpr = get_path_expression(decision.path);
			TExpr e = compile(decision.if_true);
			TExpr e2 = compile(decision.if_false);
			TExpr.HasType cond = new TExpr.HasType(tExpr, fixedType);
			result = If(cond, e, e2, get_debug_loc(decision.if_true), get_debug_loc(decision.if_false));
			goto IL_0603;
		}
		throw new AssertionException("ncc\\generation\\DecisionTreeCompiler.n", 464, "", "");
		IL_02fc:
		tExpr = (TExpr)obj;
		if ((object)tExpr == null)
		{
			TExpr e2 = get_path_expression(decision.path);
			TExpr e = compile(decision.if_true);
			tExpr = compile(decision.if_false);
			result = _N_compile_variant_60401(n_closureOf_compile_ifeq_, n_closureOf_compile_ifeq_._N_rootVar_60396, e2, e, tExpr, get_debug_loc(decision.if_true), get_debug_loc(decision.if_false));
		}
		else
		{
			result = tExpr;
		}
		goto IL_0603;
		IL_0603:
		return result;
		IL_024c:
		Nemerle.Builtins.Tuple<string, FixedType.Fun, TExpr> tuple2 = tuple;
		string field = tuple2.Field0;
		FixedType.Fun field2 = tuple2.Field1;
		tExpr = tuple2.Field2;
		IMember mem = Typer3.SingleMemberLookup(n_closureOf_compile_ifeq_._N_rootVar_60396.BaseType, field);
		TExpr.Call switchExpr2 = new TExpr.Call(InternalType.Int32, new TExpr.StaticRef(field2, from, mem, list<TypeVar>.Nil._N_constant_object), new list<Parm>.Cons(new Parm(tExpr), list<Parm>.Nil._N_constant_object), is_tail: false);
		int minSwitchSize2 = min_switch_size_for_variants;
		instance = new _N__N_lambda__60343__60461(n_closureOf_compile_ifeq_);
		Function<DecisionTreeBuilder.Decision.IfEq, Nemerle.Builtins.Tuple<bool, int>> caseSelector2 = instance;
		Function<DecisionTreeBuilder.Decision.IfEq, TExpr, TExpr> compileSingleCase2 = new _N__N_lambda__60349__60475(n_closureOf_compile_ifeq_);
		obj = compile_switch(switchExpr2, decision, minSwitchSize2, caseSelector2, compileSingleCase2);
		goto IL_02fc;
		IL_0508:
		tExpr = (TExpr)obj2;
		if ((object)tExpr == null)
		{
			tExpr = get_path_expression(decision.path);
			TExpr e2 = compile(decision.if_true);
			TExpr e = compile(decision.if_false);
			result = _N_compile_literal_60414(n_closureOf_compile_ifeq_, lit, tExpr, e2, e, get_debug_loc(decision.if_true), get_debug_loc(decision.if_false));
		}
		else
		{
			result = tExpr;
		}
		goto IL_0603;
	}

	private TExpr compile_switch(TExpr switchExpr, DecisionTreeBuilder.Decision.IfEq root, int minSwitchSize, Function<DecisionTreeBuilder.Decision.IfEq, Nemerle.Builtins.Tuple<bool, int>> caseSelector, Function<DecisionTreeBuilder.Decision.IfEq, TExpr, TExpr> compileSingleCase)
	{
		return compile_switch(switchExpr, root, minSwitchSize, caseSelector, new SingleSwitchCaseHandler.NonRequiredSwitchExpr(compileSingleCase));
	}

	private TExpr compile_switch(TExpr switchExpr, DecisionTreeBuilder.Decision.IfEq root, int minSwitchSize, Function<DecisionTreeBuilder.Decision.IfEq, Nemerle.Builtins.Tuple<bool, int>> caseSelector, Function<TExpr, DecisionTreeBuilder.Decision.IfEq, TExpr, TExpr> compileSingleCase)
	{
		return compile_switch(switchExpr, root, minSwitchSize, caseSelector, new SingleSwitchCaseHandler.RequiredSwitchExpr(compileSingleCase));
	}

	private TExpr compile_switch(TExpr switchExpr, DecisionTreeBuilder.Decision.IfEq root, int minSwitchSize, Function<DecisionTreeBuilder.Decision.IfEq, Nemerle.Builtins.Tuple<bool, int>> caseSelector, SingleSwitchCaseHandler compileSingleCase)
	{
		_N_closureOf_compile_switch_60666 n_closureOf_compile_switch_ = new _N_closureOf_compile_switch_60666();
		n_closureOf_compile_switch_._N_root_60685 = root;
		n_closureOf_compile_switch_._N_minSwitchSize_60683 = minSwitchSize;
		n_closureOf_compile_switch_._N_caseSelector_60681 = caseSelector;
		n_closureOf_compile_switch_._N_compileSingleCase_60679 = compileSingleCase;
		n_closureOf_compile_switch_._N__N_closurised_this_ptr_60671 = this;
		Nemerle.Builtins.Tuple<DecisionTreeBuilder.Decision, list<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>>> tuple = _N_selectCases_60688(n_closureOf_compile_switch_, n_closureOf_compile_switch_._N_root_60685);
		n_closureOf_compile_switch_._N_default_60677 = tuple.Field0;
		list<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>> list = tuple.Field1;
		list<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>> list2 = list;
		Function<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>, Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>, int> instance = _N__N_lambda__60589__60714.Instance;
		list = list2.Sort(instance);
		list<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>> tail = list.Tail;
		list<list<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>>>.Cons acc = new list<list<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>>>.Cons(new list<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>>.Cons(list.Head, list<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>>.Nil._N_constant_object), list<list<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>>>.Nil._N_constant_object);
		Function<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>, list<list<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>>>.Cons, list<list<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>>>.Cons> instance2 = _N__N_lambda__60598__60728.Instance;
		n_closureOf_compile_switch_._N_caseClusters_60675 = tail.FoldLeft(acc, instance2);
		n_closureOf_compile_switch_._N_switchExprIsUsed_60673 = false;
		Typer3 obj = typer3;
		Function<TExpr, TExpr> f = new _N__N_lambda__60609__60748(n_closureOf_compile_switch_);
		TExpr tExpr = obj.WithCached(switchExpr, f);
		TExpr result;
		if (n_closureOf_compile_switch_._N_switchExprIsUsed_60673)
		{
			result = tExpr;
		}
		else
		{
			TExpr tExpr2 = tExpr;
			if (tExpr2 is TExpr.DefValIn)
			{
				tExpr = ((TExpr.DefValIn)tExpr2).body;
				result = tExpr;
			}
			else
			{
				result = tExpr;
			}
		}
		return result;
	}

	private Location get_debug_loc(DecisionTreeBuilder.Decision decision)
	{
		Location result;
		if (Manager.Options.EmitDebug && decision.Location.IsSourceAvailable && !decision.IsDebugMarked)
		{
			if (decision is DecisionTreeBuilder.Decision.Success || decision is DecisionTreeBuilder.Decision.Assign)
			{
				decision.MarkDebug();
				result = decision.Location;
			}
			else
			{
				result = Location.Default;
			}
		}
		else
		{
			result = Location.Default;
		}
		return result;
	}

	private TExpr get_path_expression(DecisionTreeBuilder.Path path)
	{
		if (path.AccessExpr == null)
		{
			path.AccessExpr = build_path_expression(path);
		}
		return path.AccessExpr;
	}

	private TExpr build_path_expression(DecisionTreeBuilder.Path path)
	{
		int num = 0;
		object result;
		if (path is DecisionTreeBuilder.Path.Here)
		{
			result = val;
		}
		else
		{
			if (!(path is DecisionTreeBuilder.Path.Field))
			{
				throw new MatchFailureException();
			}
			IMember field = ((DecisionTreeBuilder.Path.Field)path).field;
			DecisionTreeBuilder.Path path2 = ((DecisionTreeBuilder.Path.Field)path).path;
			TExpr tExpr = get_path_expression(path2);
			TypeDeclaration tydecl = field.DeclaringType.GetTydecl();
			TExpr tExpr2;
			if (tydecl == TypeDeclaration.VariantOption._N_constant_object)
			{
				FixedType.Class freshType = field.DeclaringType.GetFreshType();
				tExpr.Type.ForceProvide(freshType);
				tExpr2 = Cast(tExpr, freshType);
			}
			else if (tydecl == TypeDeclaration.Class._N_constant_object)
			{
				FixedType.Class freshType = field.DeclaringType.GetFreshType();
				if (tExpr.Type.TryProvide(freshType))
				{
					tExpr.Type.ForceProvide(freshType);
					tExpr2 = Cast(tExpr, freshType);
				}
				else
				{
					tExpr2 = tExpr;
				}
			}
			else
			{
				tExpr2 = tExpr;
			}
			tExpr = tExpr2;
			if (TupleType.IsTupleMember(field))
			{
				int typarmsCount = field.DeclaringType.TyparmsCount;
				num = default(int);
				StringReader input = new StringReader(field.Name);
				Nemerle.IO.CheckInput("Field", input);
				Nemerle.IO.ConsumeWhiteSpace(input);
				num = Convert.ToInt32(Nemerle.IO.ReadIntDigits(input));
				result = new TExpr.TupleIndexer(path.Type, tExpr, num, typarmsCount);
			}
			else
			{
				result = build_record_field_ref(path.Type, tExpr, field);
			}
		}
		return (TExpr)result;
	}

	private static string get_stats(DecisionTreeBuilder.Decision decision)
	{
		_N_closureOf_get_stats_60969 n_closureOf_get_stats_ = new _N_closureOf_get_stats_60969();
		n_closureOf_get_stats_._N_num_nodes_60984 = 0;
		n_closureOf_get_stats_._N_num_shared_60982 = 0;
		n_closureOf_get_stats_._N_shared_nodes_60980 = new Hashtable<DecisionTreeBuilder.Decision, DecisionTreeBuilder.Decision>();
		n_closureOf_get_stats_._N_all_paths_length_60978 = 0;
		n_closureOf_get_stats_._N_num_paths_60976 = 0;
		n_closureOf_get_stats_._N_longest_path_60974 = 0;
		_N_make_stats_60987(n_closureOf_get_stats_, decision, 1, was_here_before: false);
		return string.Concat(string.Concat(string.Concat(string.Concat("Number of nodes: " + Convert.ToString(n_closureOf_get_stats_._N_num_nodes_60984) + Environment.NewLine, "Number of shared nodes: " + Convert.ToString(n_closureOf_get_stats_._N_num_shared_60982) + Environment.NewLine), "Number of paths: " + Convert.ToString(n_closureOf_get_stats_._N_num_paths_60976) + Environment.NewLine), "Length of the longest path: " + Convert.ToString(n_closureOf_get_stats_._N_longest_path_60974) + Environment.NewLine), "Average length of a path: " + Convert.ToString(n_closureOf_get_stats_._N_all_paths_length_60978 / n_closureOf_get_stats_._N_num_paths_60976));
	}

	private static string dag_to_string(DecisionTreeBuilder.Decision decision, bool color)
	{
		int num = 0;
		Hashtable<DecisionTreeBuilder.Decision, int> hashtable = new Hashtable<DecisionTreeBuilder.Decision, int>();
		string text = "\n";
		option<int> option = hashtable.Get(decision);
		object obj;
		if (option is option<int>.Some)
		{
			num = ((option<int>.Some)option).val;
			obj = ((!color) ? (Convert.ToString("") + "-> *" + Convert.ToString(num) + "*" + Environment.NewLine) : (Convert.ToString("") + "\u001b[01;34m-> *" + Convert.ToString(num) + "*\u001b[0m" + Environment.NewLine));
		}
		else
		{
			if (option != option<int>.None._N_constant_object)
			{
				throw new MatchFailureException();
			}
			object obj2;
			if (decision.IsShared)
			{
				num = checked(0 + 1);
				hashtable.Add(decision, num);
				obj2 = ((!color) ? ("  (*" + Convert.ToString(num) + "*)" + Environment.NewLine) : ("  \u001b[01;34m(*" + Convert.ToString(num) + "*)\u001b[0m" + Environment.NewLine));
			}
			else
			{
				obj2 = "\n";
			}
			string text2 = (string)obj2;
			if (decision is DecisionTreeBuilder.Decision.Success)
			{
				num = ((DecisionTreeBuilder.Decision.Success)decision).res;
				obj = Convert.ToString("") + "success " + Convert.ToString(num) + " " + Convert.ToString(text2);
			}
			else if (decision is DecisionTreeBuilder.Decision.Failure)
			{
				obj = Convert.ToString("") + "failure " + Convert.ToString(text2);
			}
			else if (decision is DecisionTreeBuilder.Decision.Assign)
			{
				DecisionTreeBuilder.Path path = ((DecisionTreeBuilder.Decision.Assign)decision).path;
				LocalValue decl = ((DecisionTreeBuilder.Decision.Assign)decision).decl;
				DecisionTreeBuilder.Decision dtree = ((DecisionTreeBuilder.Decision.Assign)decision).dtree;
				obj = "<debug:Assign>";
			}
			else
			{
				if (!(decision is DecisionTreeBuilder.Decision.IfEq))
				{
					throw new MatchFailureException();
				}
				DecisionTreeBuilder.Path path = ((DecisionTreeBuilder.Decision.IfEq)decision).path;
				DecisionTreeBuilder.Con con = ((DecisionTreeBuilder.Decision.IfEq)decision).con;
				DecisionTreeBuilder.Decision dtree = ((DecisionTreeBuilder.Decision.IfEq)decision).if_true;
				dtree = ((DecisionTreeBuilder.Decision.IfEq)decision).if_false;
				obj = "<debug:IfEq>";
			}
		}
		string text3 = (string)obj;
		return text + text3;
	}

	private static TExpr build_record_field_ref(TypeVar ty, TExpr val, IMember member)
	{
		object result;
		if (member is IField)
		{
			result = new TExpr.FieldMember(ty, val, (IField)member);
		}
		else
		{
			if (!(member is IProperty))
			{
				if (!Message.SeenError)
				{
					string text = "(see backtrace)".ToString();
					Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
				}
				throw new AssertionException("ncc\\generation\\DecisionTreeCompiler.n", 797, "", "(see backtrace)");
			}
			IMethod getter = ((IProperty)member).GetGetter();
			TExpr.MethodRef func = new TExpr.MethodRef(FixedType.ConstructFunctionType(list<TypeVar>.Nil._N_constant_object, ty), val, getter, list<TypeVar>.Nil._N_constant_object, notvirtual: false);
			result = new TExpr.Call(ty, func, list<Parm>.Nil._N_constant_object, is_tail: false);
		}
		return (TExpr)result;
	}

	private TExpr emit_compare_with(TExpr compare_to, Literal literal)
	{
		FixedType fixedType = compare_to.Type.Fix();
		TypeInfo typeInfo = fixedType.TypeInfo;
		TypeInfo generic_Nullable_tc = InternalType.Generic_Nullable_tc;
		FixedType.Class boolean = InternalType.Boolean;
		if (typeInfo != null && typeInfo.Equals(generic_Nullable_tc))
		{
			if (literal is Literal.Null)
			{
				goto IL_0061;
			}
		}
		else if (false)
		{
			goto IL_0061;
		}
		object obj;
		IMethod string_opEquality;
		if (literal is Literal.String)
		{
			string_opEquality = InternalType.String_opEquality;
			obj = new TExpr.StaticRef(string_opEquality.GetMemType(), InternalType.String, string_opEquality, list<TypeVar>.Nil._N_constant_object);
		}
		else if (literal is Literal.Decimal)
		{
			string_opEquality = InternalType.Decimal_opEquality;
			obj = new TExpr.StaticRef(string_opEquality.GetMemType(), InternalType.Decimal, string_opEquality, list<TypeVar>.Nil._N_constant_object);
		}
		else
		{
			obj = new TExpr.OpCode("==");
		}
		TExpr func = (TExpr)obj;
		Nemerle.Builtins.Tuple<TExpr, TExpr> tuple = ((!compare_to.GetSystemType().IsValueType) ? new Nemerle.Builtins.Tuple<TExpr, TExpr>(Cast(compare_to, literal.GetInternalType(compare_to.Type.Manager.InternalType)), new TExpr.Literal(literal)) : new Nemerle.Builtins.Tuple<TExpr, TExpr>(compare_to, Cast(new TExpr.Literal(literal), compare_to.Type)));
		TExpr field = tuple.Field0;
		TExpr field2 = tuple.Field1;
		TExpr.Call result = new TExpr.Call(field.Location, boolean, func, new list<Parm>.Cons(new Parm(field), new list<Parm>.Cons(new Parm(field2), list<Parm>.Nil._N_constant_object)), is_tail: false);
		goto IL_01fc;
		IL_0061:
		string_opEquality = (IMethod)generic_Nullable_tc.LookupMember("get_HasValue").Head;
		TExpr.MethodRef func2 = new TExpr.MethodRef(compare_to.Location, boolean, compare_to, string_opEquality, list<TypeVar>.Nil._N_constant_object, notvirtual: false);
		TExpr.Call expr = new TExpr.Call(compare_to.Location, boolean, func2, list<Parm>.Nil._N_constant_object, is_tail: false);
		TExpr.OpCode func3 = new TExpr.OpCode(Location.Default, boolean, "bool.!");
		expr = new TExpr.Call(compare_to.Location, boolean, func3, new list<Parm>.Cons(new Parm(expr), list<Parm>.Nil._N_constant_object), is_tail: false);
		result = expr;
		goto IL_01fc;
		IL_01fc:
		return result;
	}

	private static option<Nemerle.Builtins.Tuple<FixedType.Class, IField>> get_constant_object(TypeInfo variant_tycon, TypeVar matched_value_type)
	{
		list<IMember> list = variant_tycon.LookupMember("_N_constant_object");
		object result;
		if ((object)list == list<IMember>.Nil._N_constant_object)
		{
			result = option<Nemerle.Builtins.Tuple<FixedType.Class, IField>>.None._N_constant_object;
			goto IL_00ee;
		}
		if (list is list<IMember>.Cons && ((list<IMember>.Cons)list).hd is IField)
		{
			IField field = (IField)((list<IMember>.Cons)list).hd;
			if ((object)((list<IMember>.Cons)list).tl == list<IMember>.Nil._N_constant_object)
			{
				FixedType.Class freshType = variant_tycon.GetFreshType();
				freshType.ForceRequire(matched_value_type);
				result = new option<Nemerle.Builtins.Tuple<FixedType.Class, IField>>.Some(new Nemerle.Builtins.Tuple<FixedType.Class, IField>(freshType, field));
				goto IL_00ee;
			}
		}
		if (!Message.SeenError)
		{
			string text = "get_constant_object: expected zero or exactly one _N_constant_object fields".ToString();
			Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
		}
		throw new AssertionException("ncc\\generation\\DecisionTreeCompiler.n", 864, "", "get_constant_object: expected zero or exactly one _N_constant_object fields");
		IL_00ee:
		return (option<Nemerle.Builtins.Tuple<FixedType.Class, IField>>)result;
	}

	private static TExpr If(TExpr cond, TExpr e1, TExpr e2, Location l1, Location l2)
	{
		return new TExpr.If(e1.Type, cond, e1, e2, l1, l2);
	}

	private static TExpr Switch(TExpr indexing_expr, option<TExpr> @default, list<Nemerle.Builtins.Tuple<int, TExpr>> cases)
	{
		object obj;
		if (@default is option<TExpr>.Some)
		{
			TExpr tExpr = ((option<TExpr>.Some)@default).val;
			obj = tExpr.Type;
		}
		else
		{
			obj = null;
		}
		TypeVar typeVar = (TypeVar)obj;
		TypeVar acc = typeVar;
		Function<Nemerle.Builtins.Tuple<int, TExpr>, TypeVar, TypeVar> instance = _N__N_lambda__61147__61163.Instance;
		typeVar = cases.FoldLeft(acc, instance);
		return new TExpr.Switch(typeVar, indexing_expr, @default, cases);
	}

	private static TExpr Cast(TExpr expr, TypeVar ty)
	{
		FixedType fixedType = ty.Fix();
		return (!Typer4.NeedBoxing(fixedType, expr)) ? new TExpr.TypeConversion(expr.Location, fixedType, expr, fixedType, new ConversionKind.IL(is_checked: true)) : new TExpr.TypeConversion(expr.Location, fixedType, expr, fixedType, ConversionKind.Boxing._N_constant_object);
	}

	private static TExpr Sequence(TExpr e1, TExpr e2)
	{
		return new TExpr.Sequence(e1.Location, e2.Type, e1, e2);
	}

	private static TExpr HasType(TExpr e, TypeInfo ti)
	{
		FixedType.Class freshType = ti.GetFreshType();
		TExpr.HasType result;
		if ((object)freshType.args == list<TypeVar>.Nil._N_constant_object)
		{
			result = new TExpr.HasType(e, freshType);
		}
		else
		{
			freshType = freshType;
			e.Type.ForceProvide(freshType);
			result = new TExpr.HasType(e, freshType);
		}
		return result;
	}

	private TExpr ThrowMatchFailure()
	{
		IMethod newMatchFailureException_ctor = InternalType.NewMatchFailureException_ctor;
		return new TExpr.Throw(Manager.Solver.FreshTypeVar(), new TExpr.Call(InternalType.MatchFailureException, new TExpr.StaticRef(newMatchFailureException_ctor.GetMemType(), InternalType.MatchFailureException, newMatchFailureException_ctor, list<TypeVar>.Nil._N_constant_object), list<Parm>.Nil._N_constant_object, is_tail: false));
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
		typer3?.RelocateImplInternal(_info);
		decision?.RelocateImplInternal(_info);
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
		val?.RelocateImplInternal(_info);
	}

	void ISupportRelocation.RelocateImpl(RelocationInfo _info)
	{
		//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
		this.RelocateImplInternal(_info);
	}

	private void _N_walk_cases_60079(_N_closureOf_collect_effects_and_guards_60071 _N_collect_effects_and_guards_cp_60078, int i, list<Match_case> cases)
	{
		if (cases is list<Match_case>.Cons)
		{
			Match_case hd = ((list<Match_case>.Cons)cases).hd;
			list<Match_case> list = ((list<Match_case>.Cons)cases).tl;
			SharedEffect effect = new SharedEffect(this, hd.body);
			_N_walk_patterns_60085(_N_collect_effects_and_guards_cp_60078, i, effect, hd.patterns, list);
		}
		else
		{
			effects = new Function<TExpr>[i];
			shared_effects = new SharedEffect[i];
			guards = new TExpr[i];
			guardUsed = new bool[i];
		}
	}

	private void _N_walk_patterns_60085(_N_closureOf_collect_effects_and_guards_60071 _N_collect_effects_and_guards_cp_60084, int i, SharedEffect effect, list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>> patterns, list<Match_case> cases)
	{
		_N_closureOf_walk_patterns_60095 n_closureOf_walk_patterns_ = new _N_closureOf_walk_patterns_60095();
		n_closureOf_walk_patterns_._N_effect_60102 = effect;
		if (patterns is list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons)
		{
			TExpr field = ((list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons)patterns).hd.Field1;
			n_closureOf_walk_patterns_._N_assigns_60100 = ((list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons)patterns).hd.Field2;
			list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>> patterns2 = ((list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons)patterns).tl;
			_N_walk_patterns_60085(_N_collect_effects_and_guards_cp_60084, checked(i + 1), n_closureOf_walk_patterns_._N_effect_60102, patterns2, cases);
			Function<TExpr> function = (effects[i] = new _N__N_lambda__60065__60107(n_closureOf_walk_patterns_));
			shared_effects[i] = n_closureOf_walk_patterns_._N_effect_60102;
			guards[i] = field;
		}
		else
		{
			_N_walk_cases_60079(_N_collect_effects_and_guards_cp_60084, i, cases);
		}
	}

	private TExpr _N_compile_variant_60401(_N_closureOf_compile_ifeq_60391 _N_compile_ifeq_cp_60400, TypeInfo var, TExpr path_expr, TExpr true_expr, TExpr false_expr, Location true_loc, Location false_loc)
	{
		option<Nemerle.Builtins.Tuple<FixedType.Class, IField>> option = ((var.GetConstantObject() == null) ? option<Nemerle.Builtins.Tuple<FixedType.Class, IField>>.None._N_constant_object : get_constant_object(var, path_expr.Type));
		TExpr result;
		if (option is option<Nemerle.Builtins.Tuple<FixedType.Class, IField>>.Some)
		{
			FixedType.Class field = ((option<Nemerle.Builtins.Tuple<FixedType.Class, IField>>.Some)option).val.Field0;
			IField field2 = ((option<Nemerle.Builtins.Tuple<FixedType.Class, IField>>.Some)option).val.Field1;
			TExpr.StaticRef expr = new TExpr.StaticRef(field, field, field2, list<TypeVar>.Nil._N_constant_object);
			TExpr.Call cond = new TExpr.Call(InternalType.Boolean, new TExpr.OpCode("==.ref"), new list<Parm>.Cons(new Parm(path_expr), new list<Parm>.Cons(new Parm(expr), list<Parm>.Nil._N_constant_object)), is_tail: false);
			result = If(cond, true_expr, false_expr, true_loc, false_loc);
		}
		else
		{
			if (option != option<Nemerle.Builtins.Tuple<FixedType.Class, IField>>.None._N_constant_object)
			{
				throw new MatchFailureException();
			}
			TExpr cond2 = HasType(path_expr, var);
			result = If(cond2, true_expr, false_expr, true_loc, false_loc);
		}
		return result;
	}

	private TExpr _N_compile_literal_60414(_N_closureOf_compile_ifeq_60391 _N_compile_ifeq_cp_60413, Literal lit, TExpr path_expr, TExpr true_expr, TExpr false_expr, Location true_loc, Location false_loc)
	{
		TExpr cond = emit_compare_with(path_expr, lit);
		return If(cond, true_expr, false_expr, true_loc, false_loc);
	}

	private Nemerle.Builtins.Tuple<DecisionTreeBuilder.Decision, list<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>>> _N_selectCases_60688(_N_closureOf_compile_switch_60666 _N_compile_switch_cp_60687, DecisionTreeBuilder.Decision decision)
	{
		Nemerle.Builtins.Tuple<DecisionTreeBuilder.Decision, list<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>>> result;
		if (decision is DecisionTreeBuilder.Decision.IfEq)
		{
			DecisionTreeBuilder.Decision.IfEq ifEq = (DecisionTreeBuilder.Decision.IfEq)decision;
			if (_N_compile_switch_cp_60687._N_root_60685.path.Equals(ifEq.path))
			{
				Nemerle.Builtins.Tuple<bool, int> tuple = _N_compile_switch_cp_60687._N_caseSelector_60681.apply(ifEq);
				if (tuple.Field0)
				{
					int field = tuple.Field1;
					Nemerle.Builtins.Tuple<DecisionTreeBuilder.Decision, list<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>>> tuple2 = _N_selectCases_60688(_N_compile_switch_cp_60687, ifEq.if_false);
					DecisionTreeBuilder.Decision field2 = tuple2.Field0;
					list<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>> tl = tuple2.Field1;
					result = new Nemerle.Builtins.Tuple<DecisionTreeBuilder.Decision, list<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>>>(field2, new list<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>>.Cons(new Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>(field, ifEq), tl));
				}
				else
				{
					result = new Nemerle.Builtins.Tuple<DecisionTreeBuilder.Decision, list<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>>>(ifEq, list<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>>.Nil._N_constant_object);
				}
				goto IL_00bf;
			}
		}
		result = new Nemerle.Builtins.Tuple<DecisionTreeBuilder.Decision, list<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>>>(decision, list<Nemerle.Builtins.Tuple<int, DecisionTreeBuilder.Decision.IfEq>>.Nil._N_constant_object);
		goto IL_00bf;
		IL_00bf:
		return result;
	}

	private static void _N_make_stats_60987(_N_closureOf_get_stats_60969 _N_get_stats_cp_60986, DecisionTreeBuilder.Decision decision, int path_len, bool was_here_before)
	{
		checked
		{
			while (true)
			{
				if (!was_here_before)
				{
					if (!_N_get_stats_cp_60986._N_shared_nodes_60980.Contains(decision))
					{
						_N_get_stats_cp_60986._N_num_nodes_60984++;
						if (decision.IsShared)
						{
							_N_get_stats_cp_60986._N_num_shared_60982++;
							_N_get_stats_cp_60986._N_shared_nodes_60980.Add(decision, decision);
						}
					}
					else
					{
						was_here_before = true;
					}
				}
				DecisionTreeBuilder.Decision if_true;
				if (decision is DecisionTreeBuilder.Decision.IfEq)
				{
					if_true = ((DecisionTreeBuilder.Decision.IfEq)decision).if_true;
					DecisionTreeBuilder.Decision if_false = ((DecisionTreeBuilder.Decision.IfEq)decision).if_false;
					_N_make_stats_60987(_N_get_stats_cp_60986, if_true, path_len + 1, was_here_before);
					int num = path_len + 1;
					was_here_before = was_here_before;
					path_len = num;
					decision = if_false;
					continue;
				}
				if (!(decision is DecisionTreeBuilder.Decision.Assign))
				{
					break;
				}
				if_true = ((DecisionTreeBuilder.Decision.Assign)decision).dtree;
				DecisionTreeBuilder.Decision obj = if_true;
				int num2 = path_len + 1;
				was_here_before = was_here_before;
				path_len = num2;
				decision = obj;
			}
			_N_get_stats_cp_60986._N_all_paths_length_60978 += path_len;
			_N_get_stats_cp_60986._N_num_paths_60976++;
			if (path_len > _N_get_stats_cp_60986._N_longest_path_60974)
			{
				_N_get_stats_cp_60986._N_longest_path_60974 = path_len;
			}
		}
	}
}
