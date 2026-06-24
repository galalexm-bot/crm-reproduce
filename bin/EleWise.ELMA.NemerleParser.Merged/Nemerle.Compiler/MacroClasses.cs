using System;
using System.Runtime.CompilerServices;
using System.Text;
using Nemerle.Builtins;
using Nemerle.Collections;
using Nemerle.Compiler.Parsetree;
using Nemerle.Core;

namespace Nemerle.Compiler;

public static class MacroClasses
{
	private sealed class _N_closureOf_GenerateMacroClass_85020
	{
		internal list<string> _N_types_85037;

		internal Location _N_loc_85035;

		internal string _N_name_85033;

		internal PExpr _N_expr_85031;

		internal MacroPhase _N_phase_85029;

		internal string _N_target_type_suff_85027;

		internal int _N_count_85025;

		internal _N_closureOf_GenerateMacroClass_85020()
		{
		}
	}

	private sealed class _N_closureOf_makeGrammarString_85300
	{
		internal Function<PExpr, bool> _N_isParams_85305;

		internal _N_closureOf_makeGrammarString_85300()
		{
		}
	}

	private sealed class _N_isParams__85322 : Function<PExpr, bool>
	{
		[SpecialName]
		public static readonly _N_isParams__85322 Instance = new _N_isParams__85322();

		[SpecialName]
		public sealed override bool apply(PExpr e)
		{
			return (e is PExpr.Member && ((PExpr.Member)e).obj is PExpr.Ref && ((PExpr.Ref)((PExpr.Member)e).obj).name.idl == "System" && ((PExpr.Member)e).member is Splicable.Name && ((Splicable.Name)((PExpr.Member)e).member).body.idl == "ParamArrayAttribute") ? true : false;
		}
	}

	private sealed class _N__N_lambda__84915__85351 : Function<PParameter, MacroParm, Nemerle.Builtins.Tuple<bool, PParameter>>
	{
		[SpecialName]
		public static readonly _N__N_lambda__84915__85351 Instance = new _N__N_lambda__84915__85351();

		[SpecialName]
		public sealed override Nemerle.Builtins.Tuple<bool, PParameter> apply(PParameter p, MacroParm inf)
		{
			return new Nemerle.Builtins.Tuple<bool, PParameter>(inf != MacroParm.Implicit, p);
		}
	}

	private sealed class _N__N_lambda__84922__85361 : Function<PParameter, PExpr>
	{
		[SpecialName]
		public static readonly _N__N_lambda__84922__85361 Instance = new _N__N_lambda__84922__85361();

		[SpecialName]
		public sealed override PExpr apply(PParameter p)
		{
			return new PExpr.Literal(new Literal.String(p.Name));
		}
	}

	private sealed class _N__N_lambda__84928__85371 : Function<PParameter, PExpr>
	{
		[SpecialName]
		private _N_closureOf_makeGrammarString_85300 _N_makeGrammarString_closure_85375;

		public _N__N_lambda__84928__85371(_N_closureOf_makeGrammarString_85300 _N_makeGrammarString_closure_85375)
		{
			this._N_makeGrammarString_closure_85375 = _N_makeGrammarString_closure_85375;
		}

		[SpecialName]
		public sealed override PExpr apply(PParameter p)
		{
			return new PExpr.Literal(new Literal.String(_N_makeParamType_85335(p)));
		}
	}

	private sealed class _N__N_lambda__84934__85380 : Function<PParameter, PExpr>
	{
		[SpecialName]
		private _N_closureOf_makeGrammarString_85300 _N_makeGrammarString_closure_85384;

		public _N__N_lambda__84934__85380(_N_closureOf_makeGrammarString_85300 _N_makeGrammarString_closure_85384)
		{
			this._N_makeGrammarString_closure_85384 = _N_makeGrammarString_closure_85384;
		}

		[SpecialName]
		public sealed override PExpr apply(PParameter p)
		{
			return new PExpr.Literal(new Literal.String(_N_makeParamDefaultValues_85307(p)));
		}
	}

	private sealed class _N__N_lambda__84940__85389 : Function<PParameter, PExpr>
	{
		[SpecialName]
		private _N_closureOf_makeGrammarString_85300 _N_makeGrammarString_closure_85393;

		public _N__N_lambda__84940__85389(_N_closureOf_makeGrammarString_85300 _N_makeGrammarString_closure_85393)
		{
			this._N_makeGrammarString_closure_85393 = _N_makeGrammarString_closure_85393;
		}

		[SpecialName]
		public sealed override PExpr apply(PParameter p)
		{
			return new PExpr.Literal(new Literal.Bool(p.modifiers.custom_attrs.Exists(_N_makeGrammarString_closure_85393._N_isParams_85305)));
		}
	}

	private sealed class _N_static_proxy_85477 : Function<string, PExpr>
	{
		[SpecialName]
		public static readonly _N_static_proxy_85477 single_instance = new _N_static_proxy_85477();

		[SpecialName]
		public sealed override PExpr apply(string _N_sp_parm_85484)
		{
			return Macros.Lift(_N_sp_parm_85484);
		}

		private _N_static_proxy_85477()
		{
		}
	}

	private sealed class _N__N_lambda__85008__85508 : Function<PExpr, PExpr>
	{
		[SpecialName]
		public static readonly _N__N_lambda__85008__85508 Instance = new _N__N_lambda__85008__85508();

		[SpecialName]
		public sealed override PExpr apply(PExpr _N_wildcard_3383)
		{
			PExpr.Sequence result;
			if (_N_wildcard_3383 is PExpr.Sequence)
			{
				list<PExpr> list = ((PExpr.Sequence)_N_wildcard_3383).body;
				result = new PExpr.Sequence(((PExpr.Sequence)_N_wildcard_3383).Location, list + new list<PExpr>.Cons(new PExpr.Literal(new Literal.Void()), list<PExpr>.Nil._N_constant_object));
			}
			else
			{
				result = new PExpr.Sequence(new list<PExpr>.Cons(Macros.QuotationChoose(_N_wildcard_3383), new list<PExpr>.Cons(new PExpr.Literal(new Literal.Void()), list<PExpr>.Nil._N_constant_object)));
			}
			return result;
		}
	}

	private sealed class _N_static_proxy_85592 : Function<GrammarElement, PExpr>
	{
		[SpecialName]
		public static readonly _N_static_proxy_85592 single_instance = new _N_static_proxy_85592();

		[SpecialName]
		public sealed override PExpr apply(GrammarElement _N_sp_parm_85599)
		{
			return lift_ge(_N_sp_parm_85599);
		}

		private _N_static_proxy_85592()
		{
		}
	}

	private sealed class _N_closureOf_analyze_syntax_85626
	{
		internal Map<string, Nemerle.Builtins.Tuple<int, PExpr>> _N_paramsmap_85637;

		internal list<string> _N_keywords_85635;

		internal list<int> _N_positions_85633;

		internal Function<PExpr, GrammarElement, GrammarElement> _N_analyze_one_85631;

		internal _N_closureOf_analyze_syntax_85626()
		{
		}
	}

	private sealed class _N_analyze_one__85639 : Function<PExpr, GrammarElement, GrammarElement>
	{
		[SpecialName]
		private _N_closureOf_analyze_syntax_85626 _N_analyze_syntax_closure_85643;

		public _N_analyze_one__85639(_N_closureOf_analyze_syntax_85626 _N_analyze_syntax_closure_85643)
		{
			this._N_analyze_syntax_closure_85643 = _N_analyze_syntax_closure_85643;
		}

		[SpecialName]
		public sealed override GrammarElement apply(PExpr tok, GrammarElement acc)
		{
			int field;
			object obj;
			if (tok is PExpr.Ref)
			{
				string idl = ((PExpr.Ref)tok).name.idl;
				option<Nemerle.Builtins.Tuple<int, PExpr>> option = _N_analyze_syntax_closure_85643._N_paramsmap_85637.Find(idl);
				if (option is option<Nemerle.Builtins.Tuple<int, PExpr>>.Some)
				{
					field = ((option<Nemerle.Builtins.Tuple<int, PExpr>>.Some)option).val.Field0;
					PExpr field2 = ((option<Nemerle.Builtins.Tuple<int, PExpr>>.Some)option).val.Field1;
					_N_analyze_syntax_closure_85643._N_paramsmap_85637 = _N_analyze_syntax_closure_85643._N_paramsmap_85637.Remove(idl);
					if (field2 is PExpr.Ref)
					{
						if (((PExpr.Ref)field2).name.idl == "parameter")
						{
							obj = new GrammarElement.Parameter(acc);
						}
						else
						{
							if (!(((PExpr.Ref)field2).name.idl == "Token"))
							{
								goto IL_03e6;
							}
							obj = new GrammarElement.RawToken(acc);
						}
						goto IL_03ec;
					}
					if (field2 is PExpr.Array)
					{
						if (((PExpr.Array)field2).rank is PExpr.Literal && ((PExpr.Literal)((PExpr.Array)field2).rank).val is Literal.Integer && ((Literal.Integer)((PExpr.Literal)((PExpr.Array)field2).rank).val).val == 1 && !((Literal.Integer)((PExpr.Literal)((PExpr.Array)field2).rank).val).is_negative && ((PExpr.Array)field2).args is PExpr.ListLiteral && ((PExpr.ListLiteral)((PExpr.Array)field2).args).elements is list<PExpr>.Cons && ((list<PExpr>.Cons)((PExpr.ListLiteral)((PExpr.Array)field2).args).elements).hd is PExpr.Ref)
						{
							if (((PExpr.Ref)((list<PExpr>.Cons)((PExpr.ListLiteral)((PExpr.Array)field2).args).elements).hd).name.idl == "PExpr")
							{
								if ((object)((list<PExpr>.Cons)((PExpr.ListLiteral)((PExpr.Array)field2).args).elements).tl == list<PExpr>.Nil._N_constant_object)
								{
									goto IL_039f;
								}
							}
							else if (((PExpr.Ref)((list<PExpr>.Cons)((PExpr.ListLiteral)((PExpr.Array)field2).args).elements).hd).name.idl == "expr" && (object)((list<PExpr>.Cons)((PExpr.ListLiteral)((PExpr.Array)field2).args).elements).tl == list<PExpr>.Nil._N_constant_object)
							{
								goto IL_039f;
							}
						}
					}
					else if (field2 is PExpr.Indexer && ((PExpr.Indexer)field2).obj is PExpr.Ref && ((PExpr.Ref)((PExpr.Indexer)field2).obj).name.idl == "list" && ((PExpr.Indexer)field2).args is list<PExpr>.Cons && ((list<PExpr>.Cons)((PExpr.Indexer)field2).args).hd is PExpr.Ref && ((PExpr.Ref)((list<PExpr>.Cons)((PExpr.Indexer)field2).args).hd).name.idl == "PExpr" && (object)((list<PExpr>.Cons)((PExpr.Indexer)field2).args).tl == list<PExpr>.Nil._N_constant_object)
					{
						goto IL_039f;
					}
					goto IL_03e6;
				}
				if (option == option<Nemerle.Builtins.Tuple<int, PExpr>>.None._N_constant_object)
				{
					Message.Error(tok.Location, "parameters from syntax description doesn't match macro's");
					throw new Recovery();
				}
				throw new MatchFailureException();
			}
			object result;
			GrammarElement grammarElement;
			if (tok is PExpr.Call)
			{
				if (!(((PExpr.Call)tok).func is PExpr.Ref) || !(((PExpr.Ref)((PExpr.Call)tok).func).name.idl == "Optional"))
				{
					goto IL_059a;
				}
				list<PExpr> l = ((PExpr.Call)tok).parms;
				grammarElement = NList.FoldRight(l, null, _N_analyze_syntax_closure_85643._N_analyze_one_85631);
				if (grammarElement is GrammarElement.Optional)
				{
					Message.Error(tok.Location, "nested Optional tokens not allowed in syntax definition");
					throw new Recovery();
				}
				result = new GrammarElement.Optional(acc, grammarElement);
			}
			else
			{
				if (!(tok is PExpr.Literal) || !(((PExpr.Literal)tok).val is Literal.String))
				{
					goto IL_059a;
				}
				string idl = ((Literal.String)((PExpr.Literal)tok).val).val;
				if (LexerBase.HasKeywordChars(idl))
				{
					_N_analyze_syntax_closure_85643._N_keywords_85635 = new list<string>.Cons(idl, _N_analyze_syntax_closure_85643._N_keywords_85635);
					result = new GrammarElement.Keyword(acc, idl);
				}
				else
				{
					idl = ((Literal.String)((PExpr.Literal)tok).val).val;
					if (!LexerBase.IsOperator(idl))
					{
						goto IL_059a;
					}
					result = new GrammarElement.Operator(acc, idl);
				}
			}
			goto IL_05b0;
			IL_05b0:
			return (GrammarElement)result;
			IL_059a:
			Message.Error(tok.Location, "unsupported syntax token");
			throw new Recovery();
			IL_039f:
			obj = new GrammarElement.ExpressionList(acc);
			goto IL_03ec;
			IL_03e6:
			obj = new GrammarElement.Expression(acc);
			goto IL_03ec;
			IL_03ec:
			grammarElement = (GrammarElement)obj;
			_N_analyze_syntax_closure_85643._N_positions_85633 = new list<int>.Cons(field, _N_analyze_syntax_closure_85643._N_positions_85633);
			result = grammarElement;
			goto IL_05b0;
		}
	}

	private sealed class _N__N_lambda__85673__85691 : Function<int, int, int>
	{
		[SpecialName]
		public static readonly _N__N_lambda__85673__85691 Instance = new _N__N_lambda__85673__85691();

		[SpecialName]
		public sealed override int apply(int now, int prev)
		{
			return (now >= prev) ? now : int.MaxValue;
		}
	}

	internal static void GenerateMacroClass(ManagerClass Manager, TopDeclaration.Macro decl, NamespaceTree.Node ns_node)
	{
		_N_closureOf_GenerateMacroClass_85020 n_closureOf_GenerateMacroClass_ = new _N_closureOf_GenerateMacroClass_85020();
		n_closureOf_GenerateMacroClass_._N_loc_85035 = decl.Location;
		PFunHeader header = decl.header;
		_N_closureOf_GenerateMacroClass_85020 n_closureOf_GenerateMacroClass_2 = n_closureOf_GenerateMacroClass_;
		Splicable splicableName = header.SplicableName;
		if (splicableName is Splicable.Name)
		{
			Name body = ((Splicable.Name)splicableName).body;
			string text = (n_closureOf_GenerateMacroClass_2._N_name_85033 = body.Id);
			list<PExpr> synt = decl.synt;
			n_closureOf_GenerateMacroClass_._N_expr_85031 = decl.expr;
			GlobalEnv context = decl.PName.context;
			AttributesAndModifiers modifiers = decl.modifiers;
			n_closureOf_GenerateMacroClass_._N_phase_85029 = MacroPhase.None;
			AttributeTargets attributeTargets = default(AttributeTargets);
			bool val = false;
			list<PExpr> list2;
			for (list<PExpr> list = modifiers.custom_attrs; list is list<PExpr>.Cons; list = list2)
			{
				PExpr hd = ((list<PExpr>.Cons)list).hd;
				list2 = ((list<PExpr>.Cons)list).tl;
				PExpr pExpr = hd;
				if (!(pExpr is PExpr.Call))
				{
					continue;
				}
				PExpr hd2;
				PExpr hd3;
				if (((PExpr.Call)pExpr).func is PExpr.Ref)
				{
					if (((PExpr.Ref)((PExpr.Call)pExpr).func).name.idl == "MacroUsage")
					{
						if (((PExpr.Call)pExpr).parms is list<PExpr>.Cons && ((list<PExpr>.Cons)((PExpr.Call)pExpr).parms).tl is list<PExpr>.Cons)
						{
							hd2 = ((list<PExpr>.Cons)((PExpr.Call)pExpr).parms).hd;
							hd3 = ((list<PExpr>.Cons)((list<PExpr>.Cons)((PExpr.Call)pExpr).parms).tl).hd;
							goto IL_0197;
						}
						continue;
					}
					if (!(((PExpr.Ref)((PExpr.Call)pExpr).func).name.idl == "TailRecursionTransparent") || !(((PExpr.Call)pExpr).parms is list<PExpr>.Cons) || !(((list<PExpr>.Cons)((PExpr.Call)pExpr).parms).hd is PExpr.Literal) || !(((PExpr.Literal)((list<PExpr>.Cons)((PExpr.Call)pExpr).parms).hd).val is Literal.Bool) || !((Literal.Bool)((PExpr.Literal)((list<PExpr>.Cons)((PExpr.Call)pExpr).parms).hd).val).val || (object)((list<PExpr>.Cons)((PExpr.Call)pExpr).parms).tl != list<PExpr>.Nil._N_constant_object)
					{
						continue;
					}
				}
				else
				{
					if (!(((PExpr.Call)pExpr).func is PExpr.Member) || !(((PExpr.Member)((PExpr.Call)pExpr).func).member is Splicable.Name))
					{
						continue;
					}
					if (((Splicable.Name)((PExpr.Member)((PExpr.Call)pExpr).func).member).body.idl == "MacroUsage")
					{
						if (!(((PExpr.Call)pExpr).parms is list<PExpr>.Cons) || !(((list<PExpr>.Cons)((PExpr.Call)pExpr).parms).tl is list<PExpr>.Cons))
						{
							continue;
						}
						hd2 = ((list<PExpr>.Cons)((PExpr.Call)pExpr).parms).hd;
						hd3 = ((list<PExpr>.Cons)((list<PExpr>.Cons)((PExpr.Call)pExpr).parms).tl).hd;
						goto IL_0197;
					}
					if (!(((Splicable.Name)((PExpr.Member)((PExpr.Call)pExpr).func).member).body.idl == "TailRecursionTransparent") || !(((PExpr.Call)pExpr).parms is list<PExpr>.Cons) || !(((list<PExpr>.Cons)((PExpr.Call)pExpr).parms).hd is PExpr.Literal) || !(((PExpr.Literal)((list<PExpr>.Cons)((PExpr.Call)pExpr).parms).hd).val is Literal.Bool) || !((Literal.Bool)((PExpr.Literal)((list<PExpr>.Cons)((PExpr.Call)pExpr).parms).hd).val).val || (object)((list<PExpr>.Cons)((PExpr.Call)pExpr).parms).tl != list<PExpr>.Nil._N_constant_object)
					{
						continue;
					}
				}
				val = true;
				continue;
				IL_0197:
				_N_closureOf_GenerateMacroClass_85020 n_closureOf_GenerateMacroClass_3 = n_closureOf_GenerateMacroClass_;
				PExpr pExpr2 = ConstantFolder.FoldConstants(context, hd2);
				if (pExpr2 is PExpr.Literal && ((PExpr.Literal)pExpr2).val is Literal.Enum && !((Literal.Enum)((PExpr.Literal)pExpr2).val).val.is_negative)
				{
					ulong val2 = ((Literal.Enum)((PExpr.Literal)pExpr2).val).val.val;
					TypeInfo ty = ((Literal.Enum)((PExpr.Literal)pExpr2).val).ty;
					if (ty.FullName == "Nemerle.MacroPhase")
					{
						MacroPhase macroPhase = (n_closureOf_GenerateMacroClass_3._N_phase_85029 = (MacroPhase)checked((int)val2));
						PExpr pExpr3 = ConstantFolder.FoldConstants(context, hd3);
						if (pExpr3 is PExpr.Literal && ((PExpr.Literal)pExpr3).val is Literal.Enum && !((Literal.Enum)((PExpr.Literal)pExpr3).val).val.is_negative)
						{
							ulong val3 = ((Literal.Enum)((PExpr.Literal)pExpr3).val).val.val;
							TypeInfo ty2 = ((Literal.Enum)((PExpr.Literal)pExpr3).val).ty;
							if (ty2.FullName == "System.AttributeTargets")
							{
								attributeTargets = (AttributeTargets)checked((int)val3);
								continue;
							}
						}
						Message.Error(Location.Default, "invalid value on MacroTargets position: " + hd3.ToString());
						throw new Recovery();
					}
				}
				Message.Error(Location.Default, "invalid value on MacroPhase position: " + hd2.ToString());
				throw new Recovery();
			}
			n_closureOf_GenerateMacroClass_._N_target_type_suff_85027 = "";
			list<PParameter> list3 = header.Parameters;
			list<PExpr> list4 = list<PExpr>.Nil._N_constant_object;
			list<list<PExpr>> list5 = list<list<PExpr>>.Nil._N_constant_object;
			list<MacroParm> list6 = list<MacroParm>.Nil._N_constant_object;
			list<Nemerle.Builtins.Tuple<Name, PExpr>> list7 = list<Nemerle.Builtins.Tuple<Name, PExpr>>.Nil._N_constant_object;
			list<string> n_types_ = list<string>.Nil._N_constant_object;
			Nemerle.Builtins.Tuple<list<PExpr>, list<PExpr>, list<MacroParm>> tuple2;
			while (true)
			{
				n_closureOf_GenerateMacroClass_._N_types_85037 = n_types_;
				if ((object)list3 == list<PParameter>.Nil._N_constant_object)
				{
					PExpr.Sequence hd4 = _N_message_85170(n_closureOf_GenerateMacroClass_, n_closureOf_GenerateMacroClass_._N_types_85037);
					Nemerle.Builtins.Tuple<list<PExpr>.Cons, list<PExpr>.Cons> tuple = _N_traverse_patterns_85152(n_closureOf_GenerateMacroClass_, new list<list<PExpr>>.Cons(list4, list5), list7, list<Nemerle.Builtins.Tuple<Name, PExpr>>.Nil._N_constant_object, new list<PExpr>.Cons(new PExpr.Wildcard(), list<PExpr>.Nil._N_constant_object), new list<PExpr>.Cons(hd4, list<PExpr>.Nil._N_constant_object));
					list<PExpr> field = tuple.Field0;
					list<PExpr> field2 = tuple.Field1;
					tuple2 = new Nemerle.Builtins.Tuple<list<PExpr>, list<PExpr>, list<MacroParm>>(field, field2, list6.Rev());
					break;
				}
				Name body2;
				list<PExpr> tl;
				list<PExpr> tl2;
				Name body3;
				PExpr type2;
				if (list3 is list<PParameter>.Cons)
				{
					if (((list<PParameter>.Cons)list3).hd.name is Splicable.Name)
					{
						if (((list<PParameter>.Cons)list3).hd.modifiers.custom_attrs is list<PExpr>.Cons)
						{
							body2 = ((Splicable.Name)((list<PParameter>.Cons)list3).hd.name).body;
							PExpr type = ((list<PParameter>.Cons)list3).hd.Type;
							if (((list<PExpr>.Cons)((list<PParameter>.Cons)list3).hd.modifiers.custom_attrs).hd is PExpr.Member)
							{
								if (((PExpr.Member)((list<PExpr>.Cons)((list<PParameter>.Cons)list3).hd.modifiers.custom_attrs).hd).obj is PExpr.Ref)
								{
									if (((PExpr.Ref)((PExpr.Member)((list<PExpr>.Cons)((list<PParameter>.Cons)list3).hd.modifiers.custom_attrs).hd).obj).name.idl == "System")
									{
										if (((PExpr.Member)((list<PExpr>.Cons)((list<PParameter>.Cons)list3).hd.modifiers.custom_attrs).hd).member is Splicable.Name)
										{
											if (((Splicable.Name)((PExpr.Member)((list<PExpr>.Cons)((list<PParameter>.Cons)list3).hd.modifiers.custom_attrs).hd).member).body.idl == "ParamArrayAttribute")
											{
												if ((object)((list<PExpr>.Cons)((list<PParameter>.Cons)list3).hd.modifiers.custom_attrs).tl == list<PExpr>.Nil._N_constant_object)
												{
													if ((object)((list<PParameter>.Cons)list3).tl == list<PParameter>.Nil._N_constant_object)
													{
														Nemerle.Builtins.Tuple<list<PExpr>, list<PExpr>> tuple3;
														if (list4 is list<PExpr>.Cons)
														{
															PExpr.Sequence hd5 = _N_message_85170(n_closureOf_GenerateMacroClass_, new list<string>.Cons("params array", n_closureOf_GenerateMacroClass_._N_types_85037));
															tuple3 = new Nemerle.Builtins.Tuple<list<PExpr>, list<PExpr>>(new list<PExpr>.Cons(new PExpr.Wildcard(), list<PExpr>.Nil._N_constant_object), new list<PExpr>.Cons(hd5, list<PExpr>.Nil._N_constant_object));
														}
														else
														{
															tuple3 = new Nemerle.Builtins.Tuple<list<PExpr>, list<PExpr>>(list<PExpr>.Nil._N_constant_object, list<PExpr>.Nil._N_constant_object);
														}
														Nemerle.Builtins.Tuple<list<PExpr>, list<PExpr>> tuple4 = tuple3;
														tl = tuple4.Field0;
														tl2 = tuple4.Field1;
														if (type is PExpr.Array)
														{
															if (((PExpr.Array)type).args is PExpr.ListLiteral && ((PExpr.ListLiteral)((PExpr.Array)type).args).elements is list<PExpr>.Cons && ((list<PExpr>.Cons)((PExpr.ListLiteral)((PExpr.Array)type).args).elements).hd is PExpr.Ref)
															{
																if (((PExpr.Ref)((list<PExpr>.Cons)((PExpr.ListLiteral)((PExpr.Array)type).args).elements).hd).name.idl == "PExpr")
																{
																	if ((object)((list<PExpr>.Cons)((PExpr.ListLiteral)((PExpr.Array)type).args).elements).tl == list<PExpr>.Nil._N_constant_object)
																	{
																		goto IL_0a89;
																	}
																}
																else if (((PExpr.Ref)((list<PExpr>.Cons)((PExpr.ListLiteral)((PExpr.Array)type).args).elements).hd).name.idl == "expr" && (object)((list<PExpr>.Cons)((PExpr.ListLiteral)((PExpr.Array)type).args).elements).tl == list<PExpr>.Nil._N_constant_object)
																{
																	goto IL_0a89;
																}
															}
														}
														else if (type is PExpr.Indexer && ((PExpr.Indexer)type).obj is PExpr.Ref && ((PExpr.Ref)((PExpr.Indexer)type).obj).name.idl == "list" && ((PExpr.Indexer)type).args is list<PExpr>.Cons && ((list<PExpr>.Cons)((PExpr.Indexer)type).args).hd is PExpr.Ref && ((PExpr.Ref)((list<PExpr>.Cons)((PExpr.Indexer)type).args).hd).name.idl == "PExpr" && (object)((list<PExpr>.Cons)((PExpr.Indexer)type).args).tl == list<PExpr>.Nil._N_constant_object)
														{
															Nemerle.Builtins.Tuple<list<PExpr>.Cons, list<PExpr>.Cons> tuple5 = _N_traverse_patterns_85152(n_closureOf_GenerateMacroClass_, list5, list7, list<Nemerle.Builtins.Tuple<Name, PExpr>>.Nil._N_constant_object, new list<PExpr>.Cons(_N_roll_85096(list4, new PExpr.Ref(Name.NameInCurrentColor("exprs", _N_MacroContexts.Get(10, ManagerClass.Instance)))), tl), new list<PExpr>.Cons(new PExpr.Sequence(new list<PExpr>.Cons(new PExpr.Define(new PExpr.Ref(body2), new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("NList", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Map", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("exprs", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Lambda(new Function_decl(new PFunHeader(new Typarms(list<Splicable>.Nil._N_constant_object, list<Constraint>.Nil._N_constant_object), new Splicable.Name(new Name("")), new PExpr.Wildcard(), new list<PParameter>.Cons(new PParameter(new Splicable.Name(Name.NameInCurrentColor("x", _N_MacroContexts.Get(10, ManagerClass.Instance))), new AttributesAndModifiers(NemerleModifiers.None, list<PExpr>.Nil._N_constant_object), new PExpr.Ref(Name.NameInCurrentColor("SyntaxElement", _N_MacroContexts.Get(10, ManagerClass.Instance)))), list<PParameter>.Nil._N_constant_object)), new PExpr.Sequence(new list<PExpr>.Cons(new PExpr.Member(new PExpr.TypeConversion(new PExpr.Ref(Name.NameInCurrentColor("x", _N_MacroContexts.Get(10, ManagerClass.Instance))), new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("SyntaxElement", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Expression", _N_MacroContexts.Get(10, ManagerClass.Instance))))), new Splicable.Name(Name.NameInCurrentColor("body", _N_MacroContexts.Get(10, ManagerClass.Instance)))), list<PExpr>.Nil._N_constant_object)))), list<PExpr>.Nil._N_constant_object)))), new list<PExpr>.Cons(Macros.QuotationChoose(n_closureOf_GenerateMacroClass_._N_expr_85031), list<PExpr>.Nil._N_constant_object))), tl2));
															list<PExpr> field3 = tuple5.Field0;
															list<PExpr> field4 = tuple5.Field1;
															tuple2 = new Nemerle.Builtins.Tuple<list<PExpr>, list<PExpr>, list<MacroParm>>(field3, field4, NList.Rev(new list<MacroParm>.Cons(MacroParm.Exprs, list6)));
															break;
														}
														Message.Error(n_closureOf_GenerateMacroClass_._N_loc_85035, "only array of expr or parm are supported in params");
														throw new Recovery();
													}
													if (((list<PParameter>.Cons)list3).hd.DefaultValue is option<PExpr>.Some)
													{
														body3 = ((Splicable.Name)((list<PParameter>.Cons)list3).hd.name).body;
														type2 = ((list<PParameter>.Cons)list3).hd.Type;
														goto IL_1206;
													}
												}
												else if (((list<PParameter>.Cons)list3).hd.DefaultValue is option<PExpr>.Some)
												{
													body3 = ((Splicable.Name)((list<PParameter>.Cons)list3).hd.name).body;
													type2 = ((list<PParameter>.Cons)list3).hd.Type;
													goto IL_1206;
												}
											}
											else if (((list<PParameter>.Cons)list3).hd.DefaultValue is option<PExpr>.Some)
											{
												body3 = ((Splicable.Name)((list<PParameter>.Cons)list3).hd.name).body;
												type2 = ((list<PParameter>.Cons)list3).hd.Type;
												goto IL_1206;
											}
										}
										else if (((list<PParameter>.Cons)list3).hd.DefaultValue is option<PExpr>.Some)
										{
											body3 = ((Splicable.Name)((list<PParameter>.Cons)list3).hd.name).body;
											type2 = ((list<PParameter>.Cons)list3).hd.Type;
											goto IL_1206;
										}
									}
									else if (((list<PParameter>.Cons)list3).hd.DefaultValue is option<PExpr>.Some)
									{
										body3 = ((Splicable.Name)((list<PParameter>.Cons)list3).hd.name).body;
										type2 = ((list<PParameter>.Cons)list3).hd.Type;
										goto IL_1206;
									}
								}
								else if (((list<PParameter>.Cons)list3).hd.DefaultValue is option<PExpr>.Some)
								{
									body3 = ((Splicable.Name)((list<PParameter>.Cons)list3).hd.name).body;
									type2 = ((list<PParameter>.Cons)list3).hd.Type;
									goto IL_1206;
								}
							}
							else
							{
								if (((list<PParameter>.Cons)list3).hd.DefaultValue is option<PExpr>.Some)
								{
									body3 = ((Splicable.Name)((list<PParameter>.Cons)list3).hd.name).body;
									type2 = ((list<PParameter>.Cons)list3).hd.Type;
									goto IL_1206;
								}
								if (((list<PExpr>.Cons)((list<PParameter>.Cons)list3).hd.modifiers.custom_attrs).hd is PExpr.Call)
								{
									Name body4 = ((Splicable.Name)((list<PParameter>.Cons)list3).hd.name).body;
									PExpr type3 = ((list<PParameter>.Cons)list3).hd.Type;
									if (((PExpr.Call)((list<PExpr>.Cons)((list<PParameter>.Cons)list3).hd.modifiers.custom_attrs).hd).func is PExpr.Member && ((PExpr.Member)((PExpr.Call)((list<PExpr>.Cons)((list<PParameter>.Cons)list3).hd.modifiers.custom_attrs).hd).func).obj is PExpr.Member && ((PExpr.Member)((PExpr.Member)((PExpr.Call)((list<PExpr>.Cons)((list<PParameter>.Cons)list3).hd.modifiers.custom_attrs).hd).func).obj).obj is PExpr.Ref && ((PExpr.Ref)((PExpr.Member)((PExpr.Member)((PExpr.Call)((list<PExpr>.Cons)((list<PParameter>.Cons)list3).hd.modifiers.custom_attrs).hd).func).obj).obj).name.idl == "System" && ((PExpr.Member)((PExpr.Member)((PExpr.Call)((list<PExpr>.Cons)((list<PParameter>.Cons)list3).hd.modifiers.custom_attrs).hd).func).obj).member is Splicable.Name && ((Splicable.Name)((PExpr.Member)((PExpr.Member)((PExpr.Call)((list<PExpr>.Cons)((list<PParameter>.Cons)list3).hd.modifiers.custom_attrs).hd).func).obj).member).body.idl == "ComponentModel" && ((PExpr.Member)((PExpr.Call)((list<PExpr>.Cons)((list<PParameter>.Cons)list3).hd.modifiers.custom_attrs).hd).func).member is Splicable.Name && ((Splicable.Name)((PExpr.Member)((PExpr.Call)((list<PExpr>.Cons)((list<PParameter>.Cons)list3).hd.modifiers.custom_attrs).hd).func).member).body.idl == "DefaultValueAttribute" && ((PExpr.Call)((list<PExpr>.Cons)((list<PParameter>.Cons)list3).hd.modifiers.custom_attrs).hd).parms is list<PExpr>.Cons && (object)((list<PExpr>.Cons)((PExpr.Call)((list<PExpr>.Cons)((list<PParameter>.Cons)list3).hd.modifiers.custom_attrs).hd).parms).tl == list<PExpr>.Nil._N_constant_object)
									{
										PExpr hd6 = ((list<PExpr>.Cons)((PExpr.Call)((list<PExpr>.Cons)((list<PParameter>.Cons)list3).hd.modifiers.custom_attrs).hd).parms).hd;
										if ((object)((list<PExpr>.Cons)((list<PParameter>.Cons)list3).hd.modifiers.custom_attrs).tl == list<PExpr>.Nil._N_constant_object)
										{
											list<PParameter> list8 = ((list<PParameter>.Cons)list3).tl;
											Nemerle.Builtins.Tuple<PExpr.Call, list<string>.Cons, MacroParm> tuple6 = _N_normal_parm_85113(n_closureOf_GenerateMacroClass_, type3, body4);
											PExpr.Call field5 = tuple6.Field0;
											string hd7 = tuple6.Field1.hd;
											list<string> tl3 = tuple6.Field1.tl;
											MacroParm field6 = tuple6.Field2;
											list<PParameter> obj = list8;
											list<PExpr> obj2 = new list<PExpr>.Cons(field5, list4);
											list<list<PExpr>> obj3 = new list<list<PExpr>>.Cons(list4, list5);
											list<MacroParm> obj4 = new list<MacroParm>.Cons(field6, list6);
											list<Nemerle.Builtins.Tuple<Name, PExpr>> obj5 = new list<Nemerle.Builtins.Tuple<Name, PExpr>>.Cons(new Nemerle.Builtins.Tuple<Name, PExpr>(body4, hd6), list7);
											n_types_ = new list<string>.Cons(hd7 + "(opt)", tl3);
											list7 = obj5;
											list6 = obj4;
											list5 = obj3;
											list4 = obj2;
											list3 = obj;
											continue;
										}
									}
								}
							}
						}
						else if (((list<PParameter>.Cons)list3).hd.DefaultValue is option<PExpr>.Some)
						{
							body3 = ((Splicable.Name)((list<PParameter>.Cons)list3).hd.name).body;
							type2 = ((list<PParameter>.Cons)list3).hd.Type;
							goto IL_1206;
						}
						Name body5 = ((Splicable.Name)((list<PParameter>.Cons)list3).hd.name).body;
						PExpr type4 = ((list<PParameter>.Cons)list3).hd.Type;
						list<PParameter> list9 = ((list<PParameter>.Cons)list3).tl;
						if ((object)list7 == list<Nemerle.Builtins.Tuple<Name, PExpr>>.Nil._N_constant_object)
						{
							Nemerle.Builtins.Tuple<PExpr.Call, list<string>.Cons, MacroParm> tuple7 = _N_normal_parm_85113(n_closureOf_GenerateMacroClass_, type4, body5);
							PExpr.Call field7 = tuple7.Field0;
							list<string>.Cons field8 = tuple7.Field1;
							MacroParm field9 = tuple7.Field2;
							list<PParameter> obj6 = list9;
							list<PExpr> obj7 = new list<PExpr>.Cons(field7, list4);
							list<list<PExpr>> obj8 = list5;
							list<MacroParm> obj9 = new list<MacroParm>.Cons(field9, list6);
							list<Nemerle.Builtins.Tuple<Name, PExpr>> obj10 = list7;
							n_types_ = field8;
							list7 = obj10;
							list6 = obj9;
							list5 = obj8;
							list4 = obj7;
							list3 = obj6;
							continue;
						}
						Message.Error(n_closureOf_GenerateMacroClass_._N_loc_85035, "parameters with default values must not be mixed with normal");
						throw new Recovery();
					}
					if (((list<PParameter>.Cons)list3).hd.name is Splicable.Expression)
					{
						if (!Message.SeenError)
						{
							string text2 = "wrong spliced in macro parameters".ToString();
							Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text2) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
						}
						throw new AssertionException("ncc\\hierarchy\\MacroClassGen.n", 443, "", "wrong spliced in macro parameters");
					}
					if (((list<PParameter>.Cons)list3).hd.name is Splicable.HalfId)
					{
						if (!Message.SeenError)
						{
							string text3 = "completion not supported here".ToString();
							Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text3) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
						}
						throw new AssertionException("ncc\\hierarchy\\MacroClassGen.n", 444, "", "completion not supported here");
					}
					throw new MatchFailureException();
				}
				throw new MatchFailureException();
				IL_0a89:
				Nemerle.Builtins.Tuple<list<PExpr>.Cons, list<PExpr>.Cons> tuple8 = _N_traverse_patterns_85152(n_closureOf_GenerateMacroClass_, list5, list7, list<Nemerle.Builtins.Tuple<Name, PExpr>>.Nil._N_constant_object, new list<PExpr>.Cons(_N_roll_85096(list4, new PExpr.Ref(Name.NameInCurrentColor("exprs", _N_MacroContexts.Get(10, ManagerClass.Instance)))), tl), new list<PExpr>.Cons(new PExpr.Sequence(new list<PExpr>.Cons(new PExpr.Define(new PExpr.Ref(body2), new PExpr.TypeEnforcement(new PExpr.EmptyArray(new list<PExpr>.Cons(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("exprs", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Length", _N_MacroContexts.Get(10, ManagerClass.Instance)))), list<PExpr>.Nil._N_constant_object)), new PExpr.Array(new PExpr.Literal(new Literal.Integer(1uL, is_negative: false, null).WithProperType()), new PExpr.ListLiteral(new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("PExpr", _N_MacroContexts.Get(10, ManagerClass.Instance))), list<PExpr>.Nil._N_constant_object))))), new list<PExpr>.Cons(new PExpr.DefMutable(new PExpr.Ref(Name.NameInCurrentColor("i", _N_MacroContexts.Get(10, ManagerClass.Instance))), new PExpr.Literal(new Literal.Integer(0uL, is_negative: false, null).WithProperType())), new list<PExpr>.Cons(new PExpr.MacroCall(Name.NameInCurrentColor("foreach", _N_MacroContexts.Get(10, ManagerClass.Instance)), ManagerClass.Instance.NameTree.ExactPath(new list<string>.Cons("Nemerle", new list<string>.Cons("Core", new list<string>.Cons("foreach", list<string>.Nil._N_constant_object)))), new list<SyntaxElement>.Cons(new SyntaxElement.Expression(new PExpr.Call(new PExpr.Ref(Name.NameInCurrentColor("in", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("e", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("exprs", _N_MacroContexts.Get(10, ManagerClass.Instance))), list<PExpr>.Nil._N_constant_object)))), new list<SyntaxElement>.Cons(new SyntaxElement.Expression(new PExpr.Sequence(new list<PExpr>.Cons(new PExpr.Assign(new PExpr.Indexer(new PExpr.Ref(body2), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("i", _N_MacroContexts.Get(10, ManagerClass.Instance))), list<PExpr>.Nil._N_constant_object)), new PExpr.Member(new PExpr.TypeConversion(new PExpr.Ref(Name.NameInCurrentColor("e", _N_MacroContexts.Get(10, ManagerClass.Instance))), new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("SyntaxElement", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Expression", _N_MacroContexts.Get(10, ManagerClass.Instance))))), new Splicable.Name(Name.NameInCurrentColor("body", _N_MacroContexts.Get(10, ManagerClass.Instance))))), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Ref(Name.NameInCurrentColor("++", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("i", _N_MacroContexts.Get(10, ManagerClass.Instance))), list<PExpr>.Nil._N_constant_object)), list<PExpr>.Nil._N_constant_object)))), list<SyntaxElement>.Nil._N_constant_object))), new list<PExpr>.Cons(Macros.QuotationChoose(n_closureOf_GenerateMacroClass_._N_expr_85031), list<PExpr>.Nil._N_constant_object))))), tl2));
				list<PExpr> field10 = tuple8.Field0;
				list<PExpr> field11 = tuple8.Field1;
				tuple2 = new Nemerle.Builtins.Tuple<list<PExpr>, list<PExpr>, list<MacroParm>>(field10, field11, NList.Rev(new list<MacroParm>.Cons(MacroParm.Exprs, list6)));
				break;
				IL_1206:
				PExpr val4 = ((option<PExpr>.Some)((list<PParameter>.Cons)list3).hd.DefaultValue).val;
				list<PParameter> list10 = ((list<PParameter>.Cons)list3).tl;
				Nemerle.Builtins.Tuple<PExpr.Call, list<string>.Cons, MacroParm> tuple9 = _N_normal_parm_85113(n_closureOf_GenerateMacroClass_, type2, body3);
				PExpr.Call field12 = tuple9.Field0;
				string hd8 = tuple9.Field1.hd;
				list<string> tl4 = tuple9.Field1.tl;
				MacroParm field13 = tuple9.Field2;
				list<PParameter> obj11 = list10;
				list<PExpr> obj12 = new list<PExpr>.Cons(field12, list4);
				list<list<PExpr>> obj13 = new list<list<PExpr>>.Cons(list4, list5);
				list<MacroParm> obj14 = new list<MacroParm>.Cons(field13, list6);
				list<Nemerle.Builtins.Tuple<Name, PExpr>> obj15 = new list<Nemerle.Builtins.Tuple<Name, PExpr>>.Cons(new Nemerle.Builtins.Tuple<Name, PExpr>(body3, val4), list7);
				n_types_ = new list<string>.Cons(hd8 + "(opt)", tl4);
				list7 = obj15;
				list6 = obj14;
				list5 = obj13;
				list4 = obj12;
				list3 = obj11;
			}
			Nemerle.Builtins.Tuple<list<PExpr>, list<PExpr>, list<MacroParm>> tuple10 = tuple2;
			list<PExpr> list11 = tuple10.Field0;
			list<PExpr> list12 = tuple10.Field1;
			list<MacroParm> list13 = tuple10.Field2;
			string text6;
			if (n_closureOf_GenerateMacroClass_._N_target_type_suff_85027 != "" || n_closureOf_GenerateMacroClass_._N_phase_85029 != 0)
			{
				if (!(n_closureOf_GenerateMacroClass_._N_target_type_suff_85027 != "") && attributeTargets != AttributeTargets.Assembly)
				{
					Message.Error(n_closureOf_GenerateMacroClass_._N_loc_85035, "macro with phase modifier must operate on type declaration parts");
					throw new Recovery();
				}
				object obj16;
				if (n_closureOf_GenerateMacroClass_._N_phase_85029 == MacroPhase.BeforeInheritance)
				{
					obj16 = ":postscan";
				}
				else if (n_closureOf_GenerateMacroClass_._N_phase_85029 == MacroPhase.BeforeTypedMembers)
				{
					obj16 = ":preadd";
				}
				else
				{
					if (n_closureOf_GenerateMacroClass_._N_phase_85029 != MacroPhase.WithTypedMembers)
					{
						Message.Error(n_closureOf_GenerateMacroClass_._N_loc_85035, "macro operating on type declaration parts must have phase modifier");
						throw new Recovery();
					}
					obj16 = ":postadd";
				}
				string text4 = (string)obj16;
				object obj17;
				switch (attributeTargets)
				{
				case AttributeTargets.Method:
					obj17 = ":method";
					break;
				case AttributeTargets.Property:
					obj17 = ":property";
					break;
				case AttributeTargets.Field:
					obj17 = ":field";
					break;
				case AttributeTargets.Event:
					obj17 = ":event";
					break;
				case AttributeTargets.Parameter:
					obj17 = ":param";
					break;
				default:
				{
					AttributeTargets attributeTargets2 = attributeTargets;
					if (attributeTargets2 == default(AttributeTargets))
					{
						obj17 = "";
						break;
					}
					Message.Error(n_closureOf_GenerateMacroClass_._N_loc_85035, "invalid macro target: " + Convert.ToString(attributeTargets));
					obj17 = n_closureOf_GenerateMacroClass_._N_target_type_suff_85027;
					break;
				}
				case AttributeTargets.Assembly:
					if (!(n_closureOf_GenerateMacroClass_._N_target_type_suff_85027 == ""))
					{
						Message.Error("invalid parameters specified for assembly macro");
					}
					n_closureOf_GenerateMacroClass_._N_target_type_suff_85027 = ":assembly";
					obj17 = ":assembly";
					break;
				case AttributeTargets.Class:
					obj17 = ":type";
					break;
				}
				string text5 = (string)obj17;
				if (!(text5 == n_closureOf_GenerateMacroClass_._N_target_type_suff_85027))
				{
					Message.Error(n_closureOf_GenerateMacroClass_._N_loc_85035, "macro target " + Convert.ToString(attributeTargets) + " do not match macro parameters");
				}
				text6 = string.Concat(n_closureOf_GenerateMacroClass_._N_name_85033 + n_closureOf_GenerateMacroClass_._N_target_type_suff_85027, text4);
			}
			else
			{
				text6 = n_closureOf_GenerateMacroClass_._N_name_85033;
			}
			string text7 = text6;
			list<MacroParm> list14 = list13;
			_N_closureOf_makeGrammarString_85300 n_closureOf_makeGrammarString_ = new _N_closureOf_makeGrammarString_85300();
			Nemerle.Builtins.Tuple<list<PExpr>, list<PExpr>, list<PExpr>, list<PExpr>, string> tuple11;
			try
			{
				n_closureOf_makeGrammarString_._N_isParams_85305 = _N_isParams__85322.Instance;
				list<PParameter> parameters = decl.header.Parameters;
				Function<PParameter, MacroParm, Nemerle.Builtins.Tuple<bool, PParameter>> instance = _N__N_lambda__84915__85351.Instance;
				list<PParameter> list15 = NList.Filter2(parameters, list14, instance);
				Function<PParameter, PExpr> instance2 = _N__N_lambda__84922__85361.Instance;
				list<PExpr> list16 = list15.Map(instance2);
				Function<PParameter, PExpr> convert = new _N__N_lambda__84928__85371(n_closureOf_makeGrammarString_);
				list<PExpr> list17 = list15.Map(convert);
				Function<PParameter, PExpr> convert2 = new _N__N_lambda__84934__85380(n_closureOf_makeGrammarString_);
				list<PExpr> list18 = list15.Map(convert2);
				Function<PParameter, PExpr> convert3 = new _N__N_lambda__84940__85389(n_closureOf_makeGrammarString_);
				list<PExpr> list19 = list15.Map(convert3);
				bool flag = decl.synt != list<PExpr>.Nil._N_constant_object;
				StringBuilder stringBuilder = new StringBuilder();
				if (flag)
				{
					list<PExpr> list20 = decl.synt;
					while (list20 is list<PExpr>.Cons)
					{
						PExpr hd9 = ((list<PExpr>.Cons)list20).hd;
						list<PExpr> list21 = ((list<PExpr>.Cons)list20).tl;
						PExpr expr = hd9;
						_N_makeRuleStr_85402(n_closureOf_makeGrammarString_, expr, stringBuilder);
						list20 = list21;
					}
				}
				if (list16.Length != list17.Length || list17.Length != list18.Length || list19.Length != list18.Length)
				{
					string text8 = "Assertion: paramNames.Length == paramTypes.Length && paramTypes.Length == paramDefaultValues.Length && isParamArrays.Length == paramDefaultValues.Length\nAt: ncc\\hierarchy\\MacroClassGen.n failed.";
				}
				tuple11 = new Nemerle.Builtins.Tuple<list<PExpr>, list<PExpr>, list<PExpr>, list<PExpr>, string>(list16, list17, list18, list19, stringBuilder.ToString());
			}
			catch (Exception ex)
			{
				tuple11 = new Nemerle.Builtins.Tuple<list<PExpr>, list<PExpr>, list<PExpr>, list<PExpr>, string>(list<PExpr>.Nil._N_constant_object, list<PExpr>.Nil._N_constant_object, list<PExpr>.Nil._N_constant_object, list<PExpr>.Nil._N_constant_object, "ICE: " + ex.Message);
			}
			Nemerle.Builtins.Tuple<list<PExpr>, list<PExpr>, list<PExpr>, list<PExpr>, string> tuple12 = tuple11;
			list<PExpr> expr2 = tuple12.Field0;
			list<PExpr> expr3 = tuple12.Field1;
			list<PExpr> expr4 = tuple12.Field2;
			list<PExpr> expr5 = tuple12.Field3;
			string field14 = tuple12.Field4;
			bool val5 = decl.synt != list<PExpr>.Nil._N_constant_object;
			string file = decl.Location.File;
			Location location = n_closureOf_GenerateMacroClass_._N_expr_85031.Location;
			bool flag2 = location.FileIndex != 0;
			if (flag2)
			{
				LocationStack.Push(location);
			}
			try
			{
				modifiers.custom_attrs = new list<PExpr>.Cons(new PExpr.Call(new PExpr.Member(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("Nemerle", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Internal", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new Splicable.Name(Name.NameInCurrentColor("MacroInfo", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Literal(new Literal.String(n_closureOf_GenerateMacroClass_._N_name_85033)), new list<PExpr>.Cons(new PExpr.Literal(new Literal.Bool(val5)), new list<PExpr>.Cons(new PExpr.Array(new PExpr.Literal(new Literal.Integer(1uL, is_negative: false, null).WithProperType()), new PExpr.ListLiteral(Macros.QuotationChoose(expr2))), new list<PExpr>.Cons(new PExpr.Array(new PExpr.Literal(new Literal.Integer(1uL, is_negative: false, null).WithProperType()), new PExpr.ListLiteral(Macros.QuotationChoose(expr3))), new list<PExpr>.Cons(new PExpr.Array(new PExpr.Literal(new Literal.Integer(1uL, is_negative: false, null).WithProperType()), new PExpr.ListLiteral(Macros.QuotationChoose(expr4))), new list<PExpr>.Cons(new PExpr.Array(new PExpr.Literal(new Literal.Integer(1uL, is_negative: false, null).WithProperType()), new PExpr.ListLiteral(Macros.QuotationChoose(expr5))), new list<PExpr>.Cons(new PExpr.Literal(new Literal.String(field14)), list<PExpr>.Nil._N_constant_object)))))))), modifiers.custom_attrs);
				modifiers.mods |= NemerleModifiers.Public | NemerleModifiers.Sealed | NemerleModifiers.Macro;
				list<PParameter> list22 = header.Parameters;
				int num = 0;
				Map<string, Nemerle.Builtins.Tuple<int, PExpr>> map = new Map<string, Nemerle.Builtins.Tuple<int, PExpr>>();
				list<string> field15;
				GrammarElement field16;
				list<int> field17;
				Name name;
				bool flag3;
				while (true)
				{
					if ((object)list22 != list<PParameter>.Nil._N_constant_object)
					{
						if (list22 is list<PParameter>.Cons)
						{
							if (((list<PParameter>.Cons)list22).hd.name is Splicable.Name)
							{
								string idl = ((Splicable.Name)((list<PParameter>.Cons)list22).hd.name).body.idl;
								PExpr type5 = ((list<PParameter>.Cons)list22).hd.Type;
								list<PParameter> list23 = ((list<PParameter>.Cons)list22).tl;
								if (map.Contains(idl))
								{
									Message.Error(n_closureOf_GenerateMacroClass_._N_loc_85035, "parameter names cannot repeat");
									throw new Recovery();
								}
								list<PParameter> obj18 = list23;
								int num2 = checked(num + 1);
								map = map.Add(idl, new Nemerle.Builtins.Tuple<int, PExpr>(num, type5));
								num = num2;
								list22 = obj18;
								continue;
							}
							if (((list<PParameter>.Cons)list22).hd.name is Splicable.Expression)
							{
								if (!Message.SeenError)
								{
									string text9 = "wrong Splicable in macro params".ToString();
									Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text9) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
								}
								throw new AssertionException("ncc\\hierarchy\\MacroClassGen.n", 471, "", "wrong Splicable in macro params");
							}
							if (((list<PParameter>.Cons)list22).hd.name is Splicable.HalfId)
							{
								if (!Message.SeenError)
								{
									string text10 = "completion not supported here".ToString();
									Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text10) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
								}
								throw new AssertionException("ncc\\hierarchy\\MacroClassGen.n", 472, "", "completion not supported here");
							}
							throw new MatchFailureException();
						}
						throw new MatchFailureException();
					}
					Map<string, Nemerle.Builtins.Tuple<int, PExpr>> paramsmap = map;
					Nemerle.Builtins.Tuple<list<string>, GrammarElement, list<int>> tuple13 = analyze_syntax(synt, paramsmap);
					field15 = tuple13.Field0;
					field16 = tuple13.Field1;
					field17 = tuple13.Field2;
					name = header.PName.NewName(convert_to_valid_type_name(text7) + "Macro");
					Location n_loc_ = n_closureOf_GenerateMacroClass_._N_loc_85035;
					flag3 = n_loc_.FileIndex != 0;
					if (flag3)
					{
						LocationStack.Push(n_loc_);
					}
					break;
				}
				ClassMember.TypeDeclaration typeDeclaration;
				try
				{
					typeDeclaration = new ClassMember.TypeDeclaration(new TopDeclaration.Class(new Splicable.Name(name), Macros.QuotationChoose(modifiers), new Typarms(list<Splicable>.Nil._N_constant_object, list<Constraint>.Nil._N_constant_object), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("IMacro", _N_MacroContexts.Get(10, ManagerClass.Instance))), list<PExpr>.Nil._N_constant_object), list<ClassMember>.Nil._N_constant_object));
				}
				finally
				{
					if (flag3)
					{
						LocationStack.RemoveTop();
					}
				}
				ClassMember.TypeDeclaration td = typeDeclaration;
				TypeBuilder typeBuilder = context.Define(td);
				typeBuilder.Define(new ClassMember.Field(new Splicable.Name(Name.NameInCurrentColor("my_usage", _N_MacroContexts.Get(10, ManagerClass.Instance))), new AttributesAndModifiers(NemerleModifiers.Static | NemerleModifiers.Mutable, list<PExpr>.Nil._N_constant_object), new PExpr.Ref(Name.NameInCurrentColor("MacroUsageAttribute", _N_MacroContexts.Get(10, ManagerClass.Instance)))));
				typeBuilder.Define(new ClassMember.Field(new Splicable.Name(Name.NameInCurrentColor("keywords", _N_MacroContexts.Get(10, ManagerClass.Instance))), new AttributesAndModifiers(NemerleModifiers.Static, list<PExpr>.Nil._N_constant_object), new PExpr.Indexer(new PExpr.Ref(Name.NameInCurrentColor("list", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("string", _N_MacroContexts.Get(10, ManagerClass.Instance))), list<PExpr>.Nil._N_constant_object))));
				typeBuilder.Define(new ClassMember.Function(new Splicable.Name(Name.NameInCurrentColor(".ctor", _N_MacroContexts.Get(10, ManagerClass.Instance))), new AttributesAndModifiers(NemerleModifiers.Static, list<PExpr>.Nil._N_constant_object), new PFunHeader(new Typarms(list<Splicable>.Nil._N_constant_object, list<Constraint>.Nil._N_constant_object), new Splicable.Name(Name.NameInCurrentColor(".ctor", _N_MacroContexts.Get(10, ManagerClass.Instance))), new PExpr.Void(), list<PParameter>.Nil._N_constant_object), list<PExpr>.Nil._N_constant_object, new FunBody.Parsed(new PExpr.Sequence(new list<PExpr>.Cons(new PExpr.Define(new PExpr.Ref(Name.NameInCurrentColor("customs", _N_MacroContexts.Get(10, ManagerClass.Instance))), new PExpr.Call(new PExpr.Member(new PExpr.Typeof(new PExpr.Ref(name)), new Splicable.Name(Name.NameInCurrentColor("GetCustomAttributes", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Literal(new Literal.Bool(val: false)), list<PExpr>.Nil._N_constant_object))), new list<PExpr>.Cons(new PExpr.MacroCall(Name.NameInCurrentColor("foreach", _N_MacroContexts.Get(10, ManagerClass.Instance)), ManagerClass.Instance.NameTree.ExactPath(new list<string>.Cons("Nemerle", new list<string>.Cons("Core", new list<string>.Cons("foreach", list<string>.Nil._N_constant_object)))), new list<SyntaxElement>.Cons(new SyntaxElement.Expression(new PExpr.Call(new PExpr.Ref(Name.NameInCurrentColor("in", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Is(new PExpr.Ref(Name.NameInCurrentColor("x", _N_MacroContexts.Get(10, ManagerClass.Instance))), new PExpr.Ref(Name.NameInCurrentColor("MacroUsageAttribute", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("customs", _N_MacroContexts.Get(10, ManagerClass.Instance))), list<PExpr>.Nil._N_constant_object)))), new list<SyntaxElement>.Cons(new SyntaxElement.Expression(new PExpr.Assign(new PExpr.Ref(Name.NameInCurrentColor("my_usage", _N_MacroContexts.Get(10, ManagerClass.Instance))), new PExpr.Ref(Name.NameInCurrentColor("x", _N_MacroContexts.Get(10, ManagerClass.Instance))))), list<SyntaxElement>.Nil._N_constant_object))), new list<PExpr>.Cons(new PExpr.Assign(new PExpr.Ref(Name.NameInCurrentColor("keywords", _N_MacroContexts.Get(10, ManagerClass.Instance))), new PExpr.ListLiteral(Macros.QuotationChoose(field15.Map(_N_static_proxy_85477.single_instance)))), list<PExpr>.Nil._N_constant_object)))))));
				typeBuilder.Define(new ClassMember.Property(new Splicable.Name(Name.NameInCurrentColor("Location", _N_MacroContexts.Get(10, ManagerClass.Instance))), new AttributesAndModifiers(NemerleModifiers.Public, list<PExpr>.Nil._N_constant_object), new PExpr.Member(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("Nemerle", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Compiler", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new Splicable.Name(Name.NameInCurrentColor("Location", _N_MacroContexts.Get(10, ManagerClass.Instance)))), list<PParameter>.Nil._N_constant_object, new option<ClassMember.Function>.Some(new ClassMember.Function(new Splicable.Name(Name.NameInCurrentColor("get_Location", _N_MacroContexts.Get(10, ManagerClass.Instance))), new AttributesAndModifiers(NemerleModifiers.None, list<PExpr>.Nil._N_constant_object), new PFunHeader(new Typarms(list<Splicable>.Nil._N_constant_object, list<Constraint>.Nil._N_constant_object), new Splicable.Name(Name.NameInCurrentColor("get_Location", _N_MacroContexts.Get(10, ManagerClass.Instance))), new PExpr.Member(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("Nemerle", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Compiler", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new Splicable.Name(Name.NameInCurrentColor("Location", _N_MacroContexts.Get(10, ManagerClass.Instance)))), list<PParameter>.Nil._N_constant_object), list<PExpr>.Nil._N_constant_object, new FunBody.Parsed(new PExpr.Sequence(new list<PExpr>.Cons(new PExpr.Call(new PExpr.Ref(Name.NameInCurrentColor("Location", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("Location", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("GetFileIndex", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Literal(new Literal.String(file)), list<PExpr>.Nil._N_constant_object)), new list<PExpr>.Cons(new PExpr.Literal(Literal.FromInt(decl.Location.Line)), new list<PExpr>.Cons(new PExpr.Literal(Literal.FromInt(decl.Location.Column)), list<PExpr>.Nil._N_constant_object)))), list<PExpr>.Nil._N_constant_object))))), option<ClassMember.Function>.None._N_constant_object));
				typeBuilder.Define(new ClassMember.Property(new Splicable.Name(Name.NameInCurrentColor("IsInherited", _N_MacroContexts.Get(10, ManagerClass.Instance))), new AttributesAndModifiers(NemerleModifiers.Public, list<PExpr>.Nil._N_constant_object), new PExpr.Ref(Name.NameInCurrentColor("bool", _N_MacroContexts.Get(10, ManagerClass.Instance))), list<PParameter>.Nil._N_constant_object, new option<ClassMember.Function>.Some(new ClassMember.Function(new Splicable.Name(Name.NameInCurrentColor("get_IsInherited", _N_MacroContexts.Get(10, ManagerClass.Instance))), new AttributesAndModifiers(NemerleModifiers.None, list<PExpr>.Nil._N_constant_object), new PFunHeader(new Typarms(list<Splicable>.Nil._N_constant_object, list<Constraint>.Nil._N_constant_object), new Splicable.Name(Name.NameInCurrentColor("get_IsInherited", _N_MacroContexts.Get(10, ManagerClass.Instance))), new PExpr.Ref(Name.NameInCurrentColor("bool", _N_MacroContexts.Get(10, ManagerClass.Instance))), list<PParameter>.Nil._N_constant_object), list<PExpr>.Nil._N_constant_object, new FunBody.Parsed(new PExpr.Sequence(new list<PExpr>.Cons(new PExpr.Call(new PExpr.Ref(Name.NameInCurrentColor("&&", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Ref(Name.NameInCurrentColor("!=", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("my_usage", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Literal(new Literal.Null()), list<PExpr>.Nil._N_constant_object))), new list<PExpr>.Cons(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("my_usage", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Inherited", _N_MacroContexts.Get(10, ManagerClass.Instance)))), list<PExpr>.Nil._N_constant_object))), list<PExpr>.Nil._N_constant_object))))), option<ClassMember.Function>.None._N_constant_object));
				typeBuilder.Define(new ClassMember.Property(new Splicable.Name(Name.NameInCurrentColor("Keywords", _N_MacroContexts.Get(10, ManagerClass.Instance))), new AttributesAndModifiers(NemerleModifiers.Public, list<PExpr>.Nil._N_constant_object), new PExpr.Indexer(new PExpr.Ref(Name.NameInCurrentColor("list", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("string", _N_MacroContexts.Get(10, ManagerClass.Instance))), list<PExpr>.Nil._N_constant_object)), list<PParameter>.Nil._N_constant_object, new option<ClassMember.Function>.Some(new ClassMember.Function(new Splicable.Name(Name.NameInCurrentColor("get_Keywords", _N_MacroContexts.Get(10, ManagerClass.Instance))), new AttributesAndModifiers(NemerleModifiers.None, list<PExpr>.Nil._N_constant_object), new PFunHeader(new Typarms(list<Splicable>.Nil._N_constant_object, list<Constraint>.Nil._N_constant_object), new Splicable.Name(Name.NameInCurrentColor("get_Keywords", _N_MacroContexts.Get(10, ManagerClass.Instance))), new PExpr.Indexer(new PExpr.Ref(Name.NameInCurrentColor("list", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("string", _N_MacroContexts.Get(10, ManagerClass.Instance))), list<PExpr>.Nil._N_constant_object)), list<PParameter>.Nil._N_constant_object), list<PExpr>.Nil._N_constant_object, new FunBody.Parsed(new PExpr.Sequence(new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("keywords", _N_MacroContexts.Get(10, ManagerClass.Instance))), list<PExpr>.Nil._N_constant_object))))), option<ClassMember.Function>.None._N_constant_object));
				typeBuilder.Define(new ClassMember.Function(new Splicable.Name(Name.NameInCurrentColor("GetName", _N_MacroContexts.Get(10, ManagerClass.Instance))), new AttributesAndModifiers(NemerleModifiers.Public, list<PExpr>.Nil._N_constant_object), new PFunHeader(new Typarms(list<Splicable>.Nil._N_constant_object, list<Constraint>.Nil._N_constant_object), new Splicable.Name(Name.NameInCurrentColor("GetName", _N_MacroContexts.Get(10, ManagerClass.Instance))), new PExpr.Ref(Name.NameInCurrentColor("string", _N_MacroContexts.Get(10, ManagerClass.Instance))), list<PParameter>.Nil._N_constant_object), list<PExpr>.Nil._N_constant_object, new FunBody.Parsed(new PExpr.Sequence(new list<PExpr>.Cons(new PExpr.Literal(new Literal.String(text7)), list<PExpr>.Nil._N_constant_object)))));
				typeBuilder.Define(new ClassMember.Property(new Splicable.Name(Name.NameInCurrentColor("Name", _N_MacroContexts.Get(10, ManagerClass.Instance))), new AttributesAndModifiers(NemerleModifiers.Public, list<PExpr>.Nil._N_constant_object), new PExpr.Ref(Name.NameInCurrentColor("string", _N_MacroContexts.Get(10, ManagerClass.Instance))), list<PParameter>.Nil._N_constant_object, new option<ClassMember.Function>.Some(new ClassMember.Function(new Splicable.Name(Name.NameInCurrentColor("get_Name", _N_MacroContexts.Get(10, ManagerClass.Instance))), new AttributesAndModifiers(NemerleModifiers.None, list<PExpr>.Nil._N_constant_object), new PFunHeader(new Typarms(list<Splicable>.Nil._N_constant_object, list<Constraint>.Nil._N_constant_object), new Splicable.Name(Name.NameInCurrentColor("get_Name", _N_MacroContexts.Get(10, ManagerClass.Instance))), new PExpr.Ref(Name.NameInCurrentColor("string", _N_MacroContexts.Get(10, ManagerClass.Instance))), list<PParameter>.Nil._N_constant_object), list<PExpr>.Nil._N_constant_object, new FunBody.Parsed(new PExpr.Sequence(new list<PExpr>.Cons(new PExpr.Literal(new Literal.String(text7)), list<PExpr>.Nil._N_constant_object))))), option<ClassMember.Function>.None._N_constant_object));
				typeBuilder.Define(new ClassMember.Property(new Splicable.Name(Name.NameInCurrentColor("Namespace", _N_MacroContexts.Get(10, ManagerClass.Instance))), new AttributesAndModifiers(NemerleModifiers.Public, list<PExpr>.Nil._N_constant_object), new PExpr.Ref(Name.NameInCurrentColor("string", _N_MacroContexts.Get(10, ManagerClass.Instance))), list<PParameter>.Nil._N_constant_object, new option<ClassMember.Function>.Some(new ClassMember.Function(new Splicable.Name(Name.NameInCurrentColor("get_Namespace", _N_MacroContexts.Get(10, ManagerClass.Instance))), new AttributesAndModifiers(NemerleModifiers.None, list<PExpr>.Nil._N_constant_object), new PFunHeader(new Typarms(list<Splicable>.Nil._N_constant_object, list<Constraint>.Nil._N_constant_object), new Splicable.Name(Name.NameInCurrentColor("get_Namespace", _N_MacroContexts.Get(10, ManagerClass.Instance))), new PExpr.Ref(Name.NameInCurrentColor("string", _N_MacroContexts.Get(10, ManagerClass.Instance))), list<PParameter>.Nil._N_constant_object), list<PExpr>.Nil._N_constant_object, new FunBody.Parsed(new PExpr.Sequence(new list<PExpr>.Cons(new PExpr.Literal(new Literal.String(ns_node.GetDisplayName())), list<PExpr>.Nil._N_constant_object))))), option<ClassMember.Function>.None._N_constant_object));
				typeBuilder.Define(new ClassMember.Function(new Splicable.Name(Name.NameInCurrentColor("GetNamespace", _N_MacroContexts.Get(10, ManagerClass.Instance))), new AttributesAndModifiers(NemerleModifiers.Public, list<PExpr>.Nil._N_constant_object), new PFunHeader(new Typarms(list<Splicable>.Nil._N_constant_object, list<Constraint>.Nil._N_constant_object), new Splicable.Name(Name.NameInCurrentColor("GetNamespace", _N_MacroContexts.Get(10, ManagerClass.Instance))), new PExpr.Ref(Name.NameInCurrentColor("string", _N_MacroContexts.Get(10, ManagerClass.Instance))), list<PParameter>.Nil._N_constant_object), list<PExpr>.Nil._N_constant_object, new FunBody.Parsed(new PExpr.Sequence(new list<PExpr>.Cons(new PExpr.Literal(new Literal.String(ns_node.GetDisplayName())), list<PExpr>.Nil._N_constant_object)))));
				typeBuilder.Define(new ClassMember.Property(new Splicable.Name(Name.NameInCurrentColor("Usage", _N_MacroContexts.Get(10, ManagerClass.Instance))), new AttributesAndModifiers(NemerleModifiers.Public, list<PExpr>.Nil._N_constant_object), new PExpr.Ref(Name.NameInCurrentColor("MacroUsageAttribute", _N_MacroContexts.Get(10, ManagerClass.Instance))), list<PParameter>.Nil._N_constant_object, new option<ClassMember.Function>.Some(new ClassMember.Function(new Splicable.Name(Name.NameInCurrentColor("get_Usage", _N_MacroContexts.Get(10, ManagerClass.Instance))), new AttributesAndModifiers(NemerleModifiers.None, list<PExpr>.Nil._N_constant_object), new PFunHeader(new Typarms(list<Splicable>.Nil._N_constant_object, list<Constraint>.Nil._N_constant_object), new Splicable.Name(Name.NameInCurrentColor("get_Usage", _N_MacroContexts.Get(10, ManagerClass.Instance))), new PExpr.Ref(Name.NameInCurrentColor("MacroUsageAttribute", _N_MacroContexts.Get(10, ManagerClass.Instance))), list<PParameter>.Nil._N_constant_object), list<PExpr>.Nil._N_constant_object, new FunBody.Parsed(new PExpr.Sequence(new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("my_usage", _N_MacroContexts.Get(10, ManagerClass.Instance))), list<PExpr>.Nil._N_constant_object))))), option<ClassMember.Function>.None._N_constant_object));
				typeBuilder.Define(new ClassMember.Property(new Splicable.Name(Name.NameInCurrentColor("IsTailRecursionTransparent", _N_MacroContexts.Get(10, ManagerClass.Instance))), new AttributesAndModifiers(NemerleModifiers.Public, list<PExpr>.Nil._N_constant_object), new PExpr.Ref(Name.NameInCurrentColor("bool", _N_MacroContexts.Get(10, ManagerClass.Instance))), list<PParameter>.Nil._N_constant_object, new option<ClassMember.Function>.Some(new ClassMember.Function(new Splicable.Name(Name.NameInCurrentColor("get_IsTailRecursionTransparent", _N_MacroContexts.Get(10, ManagerClass.Instance))), new AttributesAndModifiers(NemerleModifiers.None, list<PExpr>.Nil._N_constant_object), new PFunHeader(new Typarms(list<Splicable>.Nil._N_constant_object, list<Constraint>.Nil._N_constant_object), new Splicable.Name(Name.NameInCurrentColor("get_IsTailRecursionTransparent", _N_MacroContexts.Get(10, ManagerClass.Instance))), new PExpr.Ref(Name.NameInCurrentColor("bool", _N_MacroContexts.Get(10, ManagerClass.Instance))), list<PParameter>.Nil._N_constant_object), list<PExpr>.Nil._N_constant_object, new FunBody.Parsed(new PExpr.Sequence(new list<PExpr>.Cons(new PExpr.Literal(new Literal.Bool(val)), list<PExpr>.Nil._N_constant_object))))), option<ClassMember.Function>.None._N_constant_object));
				typeBuilder.MarkWithSpecialName();
				n_closureOf_GenerateMacroClass_._N_count_85025 = list13.Length;
				typeBuilder.Define(new ClassMember.Function(new Splicable.Name(Name.NameInCurrentColor("CallTransform", _N_MacroContexts.Get(10, ManagerClass.Instance))), new AttributesAndModifiers(NemerleModifiers.Public, list<PExpr>.Nil._N_constant_object), new PFunHeader(new Typarms(list<Splicable>.Nil._N_constant_object, list<Constraint>.Nil._N_constant_object), new Splicable.Name(Name.NameInCurrentColor("CallTransform", _N_MacroContexts.Get(10, ManagerClass.Instance))), new PExpr.Indexer(new PExpr.Ref(Name.NameInCurrentColor("list", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("SyntaxElement", _N_MacroContexts.Get(10, ManagerClass.Instance))), list<PExpr>.Nil._N_constant_object)), new list<PParameter>.Cons(new PParameter(new Splicable.Name(Name.NameInCurrentColor("trans_p", _N_MacroContexts.Get(10, ManagerClass.Instance))), new AttributesAndModifiers(NemerleModifiers.None, list<PExpr>.Nil._N_constant_object), new PExpr.Indexer(new PExpr.Ref(Name.NameInCurrentColor("list", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("PExpr", _N_MacroContexts.Get(10, ManagerClass.Instance))), list<PExpr>.Nil._N_constant_object))), list<PParameter>.Nil._N_constant_object)), list<PExpr>.Nil._N_constant_object, new FunBody.Parsed(new PExpr.Sequence(new list<PExpr>.Cons(new PExpr.DefMutable(new PExpr.Ref(Name.NameInCurrentColor("trans_res", _N_MacroContexts.Get(10, ManagerClass.Instance))), new PExpr.ListLiteral(list<PExpr>.Nil._N_constant_object)), new list<PExpr>.Cons(Macros.QuotationChoose(_N_create_transform_tree_85488(n_closureOf_GenerateMacroClass_, list13)), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("NList", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Rev", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("trans_res", _N_MacroContexts.Get(10, ManagerClass.Instance))), list<PExpr>.Nil._N_constant_object)), list<PExpr>.Nil._N_constant_object)))))));
				list<PExpr> list24;
				if (n_closureOf_GenerateMacroClass_._N_phase_85029 == MacroPhase.None)
				{
					list24 = list12;
				}
				else
				{
					Function<PExpr, PExpr> instance3 = _N__N_lambda__85008__85508.Instance;
					list24 = list12.Map(instance3);
				}
				list<PExpr> list25 = list24;
				list<PExpr> field18 = list11;
				list<PExpr> field19 = list25;
				list<MatchCase> list26 = list<MatchCase>.Nil._N_constant_object;
				PExpr obj19;
				while (true)
				{
					Nemerle.Builtins.Tuple<list<PExpr>, list<PExpr>> tuple14 = new Nemerle.Builtins.Tuple<list<PExpr>, list<PExpr>>(field18, field19);
					if ((object)tuple14.Field0 == list<PExpr>.Nil._N_constant_object)
					{
						if ((object)tuple14.Field1 == list<PExpr>.Nil._N_constant_object)
						{
							list<MatchCase> l = list26;
							list<MatchCase> expr6 = NList.Rev(l);
							obj19 = ((n_closureOf_GenerateMacroClass_._N_phase_85029 != 0) ? ((PExpr)new PExpr.Sequence(new list<PExpr>.Cons(new PExpr.Assign(new PExpr.Wildcard(), new PExpr.Match(new PExpr.Ref(Name.NameInCurrentColor("parms", _N_MacroContexts.Get(10, ManagerClass.Instance))), Macros.QuotationChoose(expr6))), new list<PExpr>.Cons(new PExpr.Literal(new Literal.Null()), list<PExpr>.Nil._N_constant_object)))) : ((PExpr)new PExpr.Match(new PExpr.Ref(Name.NameInCurrentColor("parms", _N_MacroContexts.Get(10, ManagerClass.Instance))), Macros.QuotationChoose(expr6))));
							break;
						}
					}
					else if (tuple14.Field0 is list<PExpr>.Cons && tuple14.Field1 is list<PExpr>.Cons)
					{
						PExpr hd10 = ((list<PExpr>.Cons)tuple14.Field0).hd;
						list<PExpr> list27 = ((list<PExpr>.Cons)tuple14.Field0).tl;
						PExpr hd11 = ((list<PExpr>.Cons)tuple14.Field1).hd;
						list<PExpr> list28 = ((list<PExpr>.Cons)tuple14.Field1).tl;
						list<PExpr> obj20 = list27;
						list<PExpr> obj21 = list28;
						list26 = new list<MatchCase>.Cons(new MatchCase(new list<PExpr>.Cons(Macros.QuotationChoose(hd10), list<PExpr>.Nil._N_constant_object), Macros.QuotationChoose(hd11)), list26);
						field19 = obj21;
						field18 = obj20;
						continue;
					}
					if (!Message.SeenError)
					{
						string text11 = "(see backtrace)".ToString();
						Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text11) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
					}
					throw new AssertionException("ncc\\hierarchy\\MacroClassGen.n", 456, "", "(see backtrace)");
				}
				PExpr expr7 = obj19;
				typeBuilder.Define(new ClassMember.Function(new Splicable.Name(Name.NameInCurrentColor("Run", _N_MacroContexts.Get(10, ManagerClass.Instance))), new AttributesAndModifiers(NemerleModifiers.Public, list<PExpr>.Nil._N_constant_object), new PFunHeader(new Typarms(list<Splicable>.Nil._N_constant_object, list<Constraint>.Nil._N_constant_object), new Splicable.Name(Name.NameInCurrentColor("Run", _N_MacroContexts.Get(10, ManagerClass.Instance))), new PExpr.Ref(Name.NameInCurrentColor("PExpr", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<PParameter>.Cons(new PParameter(new Splicable.Name(Manager.MacrosRegistry.GetImplicitCTXName()), new AttributesAndModifiers(NemerleModifiers.None, list<PExpr>.Nil._N_constant_object), new PExpr.Ref(Name.NameInCurrentColor("Typer", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PParameter>.Cons(new PParameter(new Splicable.Name(Name.NameInCurrentColor("parms", _N_MacroContexts.Get(10, ManagerClass.Instance))), new AttributesAndModifiers(NemerleModifiers.None, list<PExpr>.Nil._N_constant_object), new PExpr.Indexer(new PExpr.Ref(Name.NameInCurrentColor("list", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("SyntaxElement", _N_MacroContexts.Get(10, ManagerClass.Instance))), list<PExpr>.Nil._N_constant_object))), list<PParameter>.Nil._N_constant_object))), list<PExpr>.Nil._N_constant_object, new FunBody.Parsed(new PExpr.Sequence(new list<PExpr>.Cons(Macros.QuotationChoose(expr7), list<PExpr>.Nil._N_constant_object)))));
				typeBuilder.Define(new ClassMember.Function(new Splicable.Name(Name.NameInCurrentColor("SyntaxExtension", _N_MacroContexts.Get(10, ManagerClass.Instance))), new AttributesAndModifiers(NemerleModifiers.Public, list<PExpr>.Nil._N_constant_object), new PFunHeader(new Typarms(list<Splicable>.Nil._N_constant_object, list<Constraint>.Nil._N_constant_object), new Splicable.Name(Name.NameInCurrentColor("SyntaxExtension", _N_MacroContexts.Get(10, ManagerClass.Instance))), new PExpr.Call(new PExpr.Ref(Name.NameInCurrentColor("*", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("GrammarElement", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Ref(Name.NameInCurrentColor("->", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Indexer(new PExpr.Ref(Name.NameInCurrentColor("list", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("SyntaxElement", _N_MacroContexts.Get(10, ManagerClass.Instance))), list<PExpr>.Nil._N_constant_object)), new list<PExpr>.Cons(new PExpr.Indexer(new PExpr.Ref(Name.NameInCurrentColor("list", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("SyntaxElement", _N_MacroContexts.Get(10, ManagerClass.Instance))), list<PExpr>.Nil._N_constant_object)), list<PExpr>.Nil._N_constant_object))), list<PExpr>.Nil._N_constant_object))), list<PParameter>.Nil._N_constant_object), list<PExpr>.Nil._N_constant_object, new FunBody.Parsed(new PExpr.Sequence(new list<PExpr>.Cons(new PExpr.Tuple(new list<PExpr>.Cons(Macros.QuotationChoose(lift_ge(field16)), new list<PExpr>.Cons(Macros.QuotationChoose(CreatePermutingFunction(field17)), list<PExpr>.Nil._N_constant_object))), list<PExpr>.Nil._N_constant_object)))));
				typeBuilder.Compile();
				return;
			}
			finally
			{
				if (flag2)
				{
					LocationStack.RemoveTop();
				}
			}
		}
		Message.Error(n_closureOf_GenerateMacroClass_._N_loc_85035, "spliced name in macro name is not allowed");
		throw new Recovery();
	}

	private static string convert_to_valid_type_name(string x)
	{
		int num = 0;
		bool flag = false;
		StringBuilder stringBuilder = new StringBuilder(x);
		flag = false;
		for (num = 0; num < x.Length; num = checked(num + 1))
		{
			if (!char.IsLetter(x[num]) && x[num] != '_')
			{
				if (x[num] == ':')
				{
					stringBuilder[num] = '_';
				}
				else
				{
					flag = true;
				}
			}
		}
		return (!flag) ? stringBuilder.ToString() : Util.tmpname("operator" + Convert.ToString(x.GetHashCode()));
	}

	private static PExpr lift_ge(GrammarElement x)
	{
		object result;
		if (x == null)
		{
			result = new PExpr.Literal(new Literal.Null());
		}
		else
		{
			PExpr expr = lift_ge(x.Next);
			if (x is GrammarElement.Operator)
			{
				string name = ((GrammarElement.Operator)x).name;
				result = new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("GrammarElement", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Operator", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(Macros.QuotationChoose(expr), new list<PExpr>.Cons(new PExpr.Literal(new Literal.String(name)), list<PExpr>.Nil._N_constant_object)));
			}
			else if (x is GrammarElement.Keyword)
			{
				string name = ((GrammarElement.Keyword)x).name;
				result = new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("GrammarElement", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Keyword", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(Macros.QuotationChoose(expr), new list<PExpr>.Cons(new PExpr.Literal(new Literal.String(name)), list<PExpr>.Nil._N_constant_object)));
			}
			else if (x is GrammarElement.Expression)
			{
				result = new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("GrammarElement", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Expression", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(Macros.QuotationChoose(expr), list<PExpr>.Nil._N_constant_object));
			}
			else if (x is GrammarElement.Parameter)
			{
				result = new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("GrammarElement", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Parameter", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(Macros.QuotationChoose(expr), list<PExpr>.Nil._N_constant_object));
			}
			else if (x is GrammarElement.RawToken)
			{
				result = new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("GrammarElement", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("RawToken", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(Macros.QuotationChoose(expr), list<PExpr>.Nil._N_constant_object));
			}
			else if (x is GrammarElement.ExpressionList)
			{
				result = new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("GrammarElement", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("ExpressionList", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(Macros.QuotationChoose(expr), list<PExpr>.Nil._N_constant_object));
			}
			else if (x is GrammarElement.Optional)
			{
				GrammarElement body = ((GrammarElement.Optional)x).body;
				result = new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("GrammarElement", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Optional", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(Macros.QuotationChoose(expr), new list<PExpr>.Cons(Macros.QuotationChoose(lift_ge(body)), list<PExpr>.Nil._N_constant_object)));
			}
			else
			{
				if (!(x is GrammarElement.Branch))
				{
					if (x is GrammarElement.End)
					{
						if (!Message.SeenError)
						{
							string name = "invalid node".ToString();
							Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(name) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
						}
						throw new AssertionException("ncc\\hierarchy\\MacroClassGen.n", 771, "", "invalid node");
					}
					throw new MatchFailureException();
				}
				list<GrammarElement> list = ((GrammarElement.Branch)x).options;
				result = new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("GrammarElement", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Branch", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(Macros.QuotationChoose(expr), new list<PExpr>.Cons(Macros.QuotationChoose(Macros.Lift(list, _N_static_proxy_85592.single_instance)), list<PExpr>.Nil._N_constant_object)));
			}
		}
		return (PExpr)result;
	}

	private static Nemerle.Builtins.Tuple<list<string>, GrammarElement, list<int>> analyze_syntax(list<PExpr> toks, Map<string, Nemerle.Builtins.Tuple<int, PExpr>> paramsmap)
	{
		_N_closureOf_analyze_syntax_85626 n_closureOf_analyze_syntax_ = new _N_closureOf_analyze_syntax_85626();
		n_closureOf_analyze_syntax_._N_paramsmap_85637 = paramsmap;
		n_closureOf_analyze_syntax_._N_keywords_85635 = list<string>.Nil._N_constant_object;
		n_closureOf_analyze_syntax_._N_positions_85633 = list<int>.Nil._N_constant_object;
		n_closureOf_analyze_syntax_._N_analyze_one_85631 = new _N_analyze_one__85639(n_closureOf_analyze_syntax_);
		GrammarElement field = NList.FoldRight(toks, null, n_closureOf_analyze_syntax_._N_analyze_one_85631);
		return new Nemerle.Builtins.Tuple<list<string>, GrammarElement, list<int>>(n_closureOf_analyze_syntax_._N_keywords_85635, field, n_closureOf_analyze_syntax_._N_positions_85633);
	}

	public static PExpr CreatePermutingFunction(list<int> positions)
	{
		list<PExpr> list = null;
		Function<int, int, int> instance = _N__N_lambda__85673__85691.Instance;
		int num = NList.FoldLeft(positions, -1, instance);
		object result;
		if (num != int.MaxValue)
		{
			result = new PExpr.TypeConversion(new PExpr.TypeEnforcement(new PExpr.Call(new PExpr.GenericSpecifier(new PExpr.Member(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("Nemerle", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Utility", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new Splicable.Name(Name.NameInCurrentColor("Identity", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Indexer(new PExpr.Ref(Name.NameInCurrentColor("list", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("SyntaxElement", _N_MacroContexts.Get(10, ManagerClass.Instance))), list<PExpr>.Nil._N_constant_object)), new list<PExpr>.Cons(new PExpr.Indexer(new PExpr.Ref(Name.NameInCurrentColor("list", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("SyntaxElement", _N_MacroContexts.Get(10, ManagerClass.Instance))), list<PExpr>.Nil._N_constant_object)), list<PExpr>.Nil._N_constant_object))), list<PExpr>.Nil._N_constant_object), new PExpr.Ref(Name.NameInCurrentColor("object", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new PExpr.Call(new PExpr.Ref(Name.NameInCurrentColor("->", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Indexer(new PExpr.Ref(Name.NameInCurrentColor("list", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("SyntaxElement", _N_MacroContexts.Get(10, ManagerClass.Instance))), list<PExpr>.Nil._N_constant_object)), new list<PExpr>.Cons(new PExpr.Indexer(new PExpr.Ref(Name.NameInCurrentColor("list", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("SyntaxElement", _N_MacroContexts.Get(10, ManagerClass.Instance))), list<PExpr>.Nil._N_constant_object)), list<PExpr>.Nil._N_constant_object))));
		}
		else
		{
			int length = positions.Length;
			list = list<PExpr>.Nil._N_constant_object;
			list<int> list2 = positions;
			while (list2 is list<int>.Cons)
			{
				num = ((list<int>.Cons)list2).hd;
				list2 = ((list<int>.Cons)list2).tl;
				num = num;
				list = new list<PExpr>.Cons((num != checked(length - 1)) ? ((PExpr)new PExpr.Match(new PExpr.Ref(Name.NameInCurrentColor("li", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<MatchCase>.Cons(new MatchCase(new list<PExpr>.Cons(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("list", _N_MacroContexts.Get(2, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Cons", _N_MacroContexts.Get(2, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("x", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("xs", _N_MacroContexts.Get(10, ManagerClass.Instance))), list<PExpr>.Nil._N_constant_object))), list<PExpr>.Nil._N_constant_object), new PExpr.Sequence(new list<PExpr>.Cons(new PExpr.Assign(new PExpr.Indexer(new PExpr.Ref(Name.NameInCurrentColor("pararr", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Literal(Literal.FromInt(num)), list<PExpr>.Nil._N_constant_object)), new PExpr.Ref(Name.NameInCurrentColor("x", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Assign(new PExpr.Ref(Name.NameInCurrentColor("li", _N_MacroContexts.Get(10, ManagerClass.Instance))), new PExpr.Ref(Name.NameInCurrentColor("xs", _N_MacroContexts.Get(10, ManagerClass.Instance)))), list<PExpr>.Nil._N_constant_object)))), new list<MatchCase>.Cons(new MatchCase(new list<PExpr>.Cons(new PExpr.Wildcard(), list<PExpr>.Nil._N_constant_object), new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("Util", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("ice", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Literal(new Literal.String("not enough elements")), list<PExpr>.Nil._N_constant_object))), list<MatchCase>.Nil._N_constant_object)))) : ((PExpr)new PExpr.MacroCall(Name.NameInCurrentColor("for", _N_MacroContexts.Get(10, ManagerClass.Instance)), ManagerClass.Instance.NameTree.ExactPath(new list<string>.Cons("Nemerle", new list<string>.Cons("Core", new list<string>.Cons("for", list<string>.Nil._N_constant_object)))), new list<SyntaxElement>.Cons(new SyntaxElement.Expression(new PExpr.DefMutable(new PExpr.Ref(Name.NameInCurrentColor("i", _N_MacroContexts.Get(10, ManagerClass.Instance))), new PExpr.Literal(Literal.FromInt(num)))), new list<SyntaxElement>.Cons(new SyntaxElement.Expression(new PExpr.Call(new PExpr.Ref(Name.NameInCurrentColor("<", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("i", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("len", _N_MacroContexts.Get(10, ManagerClass.Instance))), list<PExpr>.Nil._N_constant_object)))), new list<SyntaxElement>.Cons(new SyntaxElement.Expression(new PExpr.Call(new PExpr.Ref(Name.NameInCurrentColor("++", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("i", _N_MacroContexts.Get(10, ManagerClass.Instance))), list<PExpr>.Nil._N_constant_object))), new list<SyntaxElement>.Cons(new SyntaxElement.Expression(new PExpr.Sequence(new list<PExpr>.Cons(new PExpr.Match(new PExpr.Ref(Name.NameInCurrentColor("li", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<MatchCase>.Cons(new MatchCase(new list<PExpr>.Cons(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("list", _N_MacroContexts.Get(2, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Cons", _N_MacroContexts.Get(2, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("x", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("xs", _N_MacroContexts.Get(10, ManagerClass.Instance))), list<PExpr>.Nil._N_constant_object))), list<PExpr>.Nil._N_constant_object), new PExpr.Sequence(new list<PExpr>.Cons(new PExpr.Assign(new PExpr.Indexer(new PExpr.Ref(Name.NameInCurrentColor("pararr", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("i", _N_MacroContexts.Get(10, ManagerClass.Instance))), list<PExpr>.Nil._N_constant_object)), new PExpr.Ref(Name.NameInCurrentColor("x", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Assign(new PExpr.Ref(Name.NameInCurrentColor("li", _N_MacroContexts.Get(10, ManagerClass.Instance))), new PExpr.Ref(Name.NameInCurrentColor("xs", _N_MacroContexts.Get(10, ManagerClass.Instance)))), list<PExpr>.Nil._N_constant_object)))), new list<MatchCase>.Cons(new MatchCase(new list<PExpr>.Cons(new PExpr.Wildcard(), list<PExpr>.Nil._N_constant_object), new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("Util", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("ice", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Literal(new Literal.String("not enough elements")), list<PExpr>.Nil._N_constant_object))), list<MatchCase>.Nil._N_constant_object))), list<PExpr>.Nil._N_constant_object))), list<SyntaxElement>.Nil._N_constant_object)))))), list);
				list2 = list2;
			}
			result = new PExpr.Lambda(new Function_decl(new PFunHeader(new Typarms(list<Splicable>.Nil._N_constant_object, list<Constraint>.Nil._N_constant_object), new Splicable.Name(new Name("")), new PExpr.Wildcard(), new list<PParameter>.Cons(new PParameter(new Splicable.Name(Name.NameInCurrentColor("li", _N_MacroContexts.Get(10, ManagerClass.Instance))), new AttributesAndModifiers(NemerleModifiers.Mutable, list<PExpr>.Nil._N_constant_object), new PExpr.Indexer(new PExpr.Ref(Name.NameInCurrentColor("list", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("SyntaxElement", _N_MacroContexts.Get(10, ManagerClass.Instance))), list<PExpr>.Nil._N_constant_object))), list<PParameter>.Nil._N_constant_object)), new PExpr.Sequence(new list<PExpr>.Cons(new PExpr.Define(new PExpr.Ref(Name.NameInCurrentColor("len", _N_MacroContexts.Get(10, ManagerClass.Instance))), new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("li", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Length", _N_MacroContexts.Get(10, ManagerClass.Instance))))), new list<PExpr>.Cons(new PExpr.Define(new PExpr.Ref(Name.NameInCurrentColor("pararr", _N_MacroContexts.Get(10, ManagerClass.Instance))), new PExpr.EmptyArray(new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("len", _N_MacroContexts.Get(10, ManagerClass.Instance))), list<PExpr>.Nil._N_constant_object))), new list<PExpr>.Cons(new PExpr.Sequence(Macros.QuotationChoose(NList.Rev(list))), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("NList", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("FromArray", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("pararr", _N_MacroContexts.Get(10, ManagerClass.Instance))), list<PExpr>.Nil._N_constant_object)), list<PExpr>.Nil._N_constant_object)))))));
		}
		return (PExpr)result;
	}

	private static void _N_set_target_info_85065(_N_closureOf_GenerateMacroClass_85020 _N_GenerateMacroClass_cp_85064, int atleast, int atmost, string suff, string name)
	{
		if (_N_GenerateMacroClass_cp_85064._N_phase_85029 == MacroPhase.None)
		{
			Message.Error(_N_GenerateMacroClass_cp_85064._N_loc_85035, "macro operating on declaration must have stage attribute");
		}
		if (atleast > (int)_N_GenerateMacroClass_cp_85064._N_phase_85029 || atmost < (int)_N_GenerateMacroClass_cp_85064._N_phase_85029)
		{
			Message.Error(_N_GenerateMacroClass_cp_85064._N_loc_85035, string.Concat("macro from this stage cannot have `" + name, "' parameter"));
		}
		if (_N_GenerateMacroClass_cp_85064._N_target_type_suff_85027 == "")
		{
			_N_GenerateMacroClass_cp_85064._N_target_type_suff_85027 = suff;
		}
		else if (_N_GenerateMacroClass_cp_85064._N_target_type_suff_85027 == ":type")
		{
			switch (suff)
			{
			case ":method":
			case ":field":
			case ":property":
			case ":event":
			case ":param":
				_N_GenerateMacroClass_cp_85064._N_target_type_suff_85027 = suff;
				break;
			default:
				Message.Error(_N_GenerateMacroClass_cp_85064._N_loc_85035, "multiple `TypeBuilder' parameters");
				break;
			}
		}
		else if (_N_GenerateMacroClass_cp_85064._N_target_type_suff_85027 == ":method")
		{
			if (suff == ":param")
			{
				_N_GenerateMacroClass_cp_85064._N_target_type_suff_85027 = suff;
			}
			else
			{
				Message.Error(_N_GenerateMacroClass_cp_85064._N_loc_85035, "after `Method' theres can be only `Parameter', not " + suff);
			}
		}
		else
		{
			Message.Error(_N_GenerateMacroClass_cp_85064._N_loc_85035, "parameter `TypeBuilder' must occure before " + suff);
		}
	}

	private static PExpr _N_roll_85096(list<PExpr> li, PExpr bu)
	{
		while (true)
		{
			if ((object)li == list<PExpr>.Nil._N_constant_object)
			{
				return bu;
			}
			if (!(li is list<PExpr>.Cons))
			{
				break;
			}
			PExpr hd = ((list<PExpr>.Cons)li).hd;
			list<PExpr> list = ((list<PExpr>.Cons)li).tl;
			list<PExpr> obj = list;
			bu = new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("list", _N_MacroContexts.Get(2, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Cons", _N_MacroContexts.Get(2, ManagerClass.Instance)))), new list<PExpr>.Cons(Macros.QuotationChoose(hd), new list<PExpr>.Cons(Macros.QuotationChoose(bu), list<PExpr>.Nil._N_constant_object)));
			li = obj;
		}
		throw new MatchFailureException();
	}

	private static PExpr _N_roll_expr_85104(list<Nemerle.Builtins.Tuple<Name, PExpr>> li, PExpr bu)
	{
		while (true)
		{
			if ((object)li == list<Nemerle.Builtins.Tuple<Name, PExpr>>.Nil._N_constant_object)
			{
				return bu;
			}
			if (!(li is list<Nemerle.Builtins.Tuple<Name, PExpr>>.Cons))
			{
				break;
			}
			Name field = ((list<Nemerle.Builtins.Tuple<Name, PExpr>>.Cons)li).hd.Field0;
			PExpr field2 = ((list<Nemerle.Builtins.Tuple<Name, PExpr>>.Cons)li).hd.Field1;
			list<Nemerle.Builtins.Tuple<Name, PExpr>> list = ((list<Nemerle.Builtins.Tuple<Name, PExpr>>.Cons)li).tl;
			list<Nemerle.Builtins.Tuple<Name, PExpr>> obj = list;
			bu = new PExpr.Sequence(new list<PExpr>.Cons(new PExpr.Define(new PExpr.Ref(field), Macros.QuotationChoose(field2)), new list<PExpr>.Cons(Macros.QuotationChoose(bu), list<PExpr>.Nil._N_constant_object)));
			li = obj;
		}
		throw new MatchFailureException();
	}

	private static Nemerle.Builtins.Tuple<PExpr.Call, list<string>.Cons, MacroParm> _N_normal_parm_85113(_N_closureOf_GenerateMacroClass_85020 _N_GenerateMacroClass_cp_85112, PExpr t, Name va)
	{
		Nemerle.Builtins.Tuple<PExpr.Call, list<string>.Cons, MacroParm> result;
		if (!(t is PExpr.Wildcard))
		{
			if (!(t is PExpr.Ref))
			{
				if (t is PExpr.Member && ((PExpr.Member)t).obj is PExpr.Ref && ((PExpr.Ref)((PExpr.Member)t).obj).name.idl == "ClassMember" && ((PExpr.Member)t).member is Splicable.Name)
				{
					if (((Splicable.Name)((PExpr.Member)t).member).body.idl == "Field")
					{
						goto IL_189d;
					}
					if (((Splicable.Name)((PExpr.Member)t).member).body.idl == "Function")
					{
						goto IL_1983;
					}
					if (((Splicable.Name)((PExpr.Member)t).member).body.idl == "Property")
					{
						goto IL_1a69;
					}
					if (((Splicable.Name)((PExpr.Member)t).member).body.idl == "Event")
					{
						goto IL_1b4f;
					}
				}
				Message.Error(_N_GenerateMacroClass_cp_85112._N_loc_85035, "complex types are not supported for macro parameters: " + Convert.ToString(t));
				throw new Recovery();
			}
			if (!(((PExpr.Ref)t).name.idl == "PExpr") && !(((PExpr.Ref)t).name.idl == "expr"))
			{
				if (((PExpr.Ref)t).name.idl == "parameter")
				{
					result = new Nemerle.Builtins.Tuple<PExpr.Call, list<string>.Cons, MacroParm>(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("SyntaxElement", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Parameter", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Ref(va), list<PExpr>.Nil._N_constant_object)), new list<string>.Cons("parameter", _N_GenerateMacroClass_cp_85112._N_types_85037), MacroParm.Expr);
				}
				else if (((PExpr.Ref)t).name.idl == "Token")
				{
					result = new Nemerle.Builtins.Tuple<PExpr.Call, list<string>.Cons, MacroParm>(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("SyntaxElement", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("RawToken", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Ref(va), list<PExpr>.Nil._N_constant_object)), new list<string>.Cons("Token", _N_GenerateMacroClass_cp_85112._N_types_85037), MacroParm.Expr);
				}
				else if (((PExpr.Ref)t).name.idl == "string")
				{
					result = new Nemerle.Builtins.Tuple<PExpr.Call, list<string>.Cons, MacroParm>(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("SyntaxElement", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Expression", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("PExpr", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Literal", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("Literal", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("String", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Ref(va), list<PExpr>.Nil._N_constant_object)), list<PExpr>.Nil._N_constant_object)), list<PExpr>.Nil._N_constant_object)), new list<string>.Cons("string", _N_GenerateMacroClass_cp_85112._N_types_85037), MacroParm.Expr);
				}
				else if (((PExpr.Ref)t).name.idl == "int")
				{
					result = new Nemerle.Builtins.Tuple<PExpr.Call, list<string>.Cons, MacroParm>(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("SyntaxElement", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Expression", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("PExpr", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Literal", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("Literal", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Integer", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Assign(new PExpr.Ref(Name.NameInCurrentColor("AsInt", _N_MacroContexts.Get(10, ManagerClass.Instance))), new PExpr.Call(new PExpr.Ref(Name.NameInCurrentColor("Some", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Ref(va), list<PExpr>.Nil._N_constant_object))), list<PExpr>.Nil._N_constant_object)), list<PExpr>.Nil._N_constant_object)), list<PExpr>.Nil._N_constant_object)), new list<string>.Cons("int", _N_GenerateMacroClass_cp_85112._N_types_85037), MacroParm.Expr);
				}
				else
				{
					if (((PExpr.Ref)t).name.idl == "ParsedField")
					{
						goto IL_189d;
					}
					if (((PExpr.Ref)t).name.idl == "ParsedMethod")
					{
						goto IL_1983;
					}
					if (((PExpr.Ref)t).name.idl == "ParsedProperty")
					{
						goto IL_1a69;
					}
					if (((PExpr.Ref)t).name.idl == "ParsedEvent")
					{
						goto IL_1b4f;
					}
					if (((PExpr.Ref)t).name.idl == "PParameter" || ((PExpr.Ref)t).name.idl == "ParsedParameter")
					{
						_N_set_target_info_85065(_N_GenerateMacroClass_cp_85112, 1, 2, ":param", "ParsedParameter");
						result = new Nemerle.Builtins.Tuple<PExpr.Call, list<string>.Cons, MacroParm>(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("SyntaxElement", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Parameter", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Ref(va), list<PExpr>.Nil._N_constant_object)), new list<string>.Cons("ParsedParameter", _N_GenerateMacroClass_cp_85112._N_types_85037), MacroParm.Implicit);
					}
					else if (((PExpr.Ref)t).name.idl == "TypeBuilder")
					{
						_N_set_target_info_85065(_N_GenerateMacroClass_cp_85112, 1, 3, ":type", "TypeBuilder");
						_N_GenerateMacroClass_cp_85112._N_target_type_suff_85027 = ":type";
						result = new Nemerle.Builtins.Tuple<PExpr.Call, list<string>.Cons, MacroParm>(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("SyntaxElement", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("TypeBuilder", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Ref(va), list<PExpr>.Nil._N_constant_object)), new list<string>.Cons("TypeBuilder", _N_GenerateMacroClass_cp_85112._N_types_85037), MacroParm.Implicit);
					}
					else if (((PExpr.Ref)t).name.idl == "FieldBuilder")
					{
						_N_set_target_info_85065(_N_GenerateMacroClass_cp_85112, 3, 3, ":field", "FieldBuilder");
						result = new Nemerle.Builtins.Tuple<PExpr.Call, list<string>.Cons, MacroParm>(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("SyntaxElement", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("FieldBuilder", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Ref(va), list<PExpr>.Nil._N_constant_object)), new list<string>.Cons("FieldBuilder", _N_GenerateMacroClass_cp_85112._N_types_85037), MacroParm.Implicit);
					}
					else if (((PExpr.Ref)t).name.idl == "MethodBuilder")
					{
						_N_set_target_info_85065(_N_GenerateMacroClass_cp_85112, 3, 3, ":method", "MethodBuilder");
						result = new Nemerle.Builtins.Tuple<PExpr.Call, list<string>.Cons, MacroParm>(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("SyntaxElement", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("MethodBuilder", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Ref(va), list<PExpr>.Nil._N_constant_object)), new list<string>.Cons("MethodBuilder", _N_GenerateMacroClass_cp_85112._N_types_85037), MacroParm.Implicit);
					}
					else if (((PExpr.Ref)t).name.idl == "PropertyBuilder")
					{
						_N_set_target_info_85065(_N_GenerateMacroClass_cp_85112, 3, 3, ":property", "PropertyBuilder");
						result = new Nemerle.Builtins.Tuple<PExpr.Call, list<string>.Cons, MacroParm>(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("SyntaxElement", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("PropertyBuilder", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Ref(va), list<PExpr>.Nil._N_constant_object)), new list<string>.Cons("PropertyBuilder", _N_GenerateMacroClass_cp_85112._N_types_85037), MacroParm.Implicit);
					}
					else if (((PExpr.Ref)t).name.idl == "EventBuilder")
					{
						_N_set_target_info_85065(_N_GenerateMacroClass_cp_85112, 3, 3, ":event", "EventBuilder");
						result = new Nemerle.Builtins.Tuple<PExpr.Call, list<string>.Cons, MacroParm>(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("SyntaxElement", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("EventBuilder", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Ref(va), list<PExpr>.Nil._N_constant_object)), new list<string>.Cons("EventBuilder", _N_GenerateMacroClass_cp_85112._N_types_85037), MacroParm.Implicit);
					}
					else if (((PExpr.Ref)t).name.idl == "TParameter" || ((PExpr.Ref)t).name.idl == "ParameterBuilder")
					{
						_N_set_target_info_85065(_N_GenerateMacroClass_cp_85112, 3, 3, ":param", "ParameterBuilder");
						result = new Nemerle.Builtins.Tuple<PExpr.Call, list<string>.Cons, MacroParm>(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("SyntaxElement", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("ParameterBuilder", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Ref(va), list<PExpr>.Nil._N_constant_object)), new list<string>.Cons("ParameterBuilder", _N_GenerateMacroClass_cp_85112._N_types_85037), MacroParm.Implicit);
					}
					else if (((PExpr.Ref)t).name.idl == "uint")
					{
						result = new Nemerle.Builtins.Tuple<PExpr.Call, list<string>.Cons, MacroParm>(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("SyntaxElement", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Expression", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("PExpr", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Literal", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("Literal", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Integer", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Assign(new PExpr.Ref(Name.NameInCurrentColor("AsUInt", _N_MacroContexts.Get(10, ManagerClass.Instance))), new PExpr.Call(new PExpr.Ref(Name.NameInCurrentColor("Some", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Ref(va), list<PExpr>.Nil._N_constant_object))), list<PExpr>.Nil._N_constant_object)), list<PExpr>.Nil._N_constant_object)), list<PExpr>.Nil._N_constant_object)), new list<string>.Cons("uint", _N_GenerateMacroClass_cp_85112._N_types_85037), MacroParm.Expr);
					}
					else if (((PExpr.Ref)t).name.idl == "long")
					{
						result = new Nemerle.Builtins.Tuple<PExpr.Call, list<string>.Cons, MacroParm>(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("SyntaxElement", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Expression", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("PExpr", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Literal", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("Literal", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Integer", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Assign(new PExpr.Ref(Name.NameInCurrentColor("AsLong", _N_MacroContexts.Get(10, ManagerClass.Instance))), new PExpr.Call(new PExpr.Ref(Name.NameInCurrentColor("Some", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Ref(va), list<PExpr>.Nil._N_constant_object))), list<PExpr>.Nil._N_constant_object)), list<PExpr>.Nil._N_constant_object)), list<PExpr>.Nil._N_constant_object)), new list<string>.Cons("long", _N_GenerateMacroClass_cp_85112._N_types_85037), MacroParm.Expr);
					}
					else if (((PExpr.Ref)t).name.idl == "ulong")
					{
						result = new Nemerle.Builtins.Tuple<PExpr.Call, list<string>.Cons, MacroParm>(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("SyntaxElement", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Expression", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("PExpr", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Literal", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("Literal", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Integer", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Assign(new PExpr.Ref(Name.NameInCurrentColor("AsULong", _N_MacroContexts.Get(10, ManagerClass.Instance))), new PExpr.Call(new PExpr.Ref(Name.NameInCurrentColor("Some", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Ref(va), list<PExpr>.Nil._N_constant_object))), list<PExpr>.Nil._N_constant_object)), list<PExpr>.Nil._N_constant_object)), list<PExpr>.Nil._N_constant_object)), new list<string>.Cons("ulong", _N_GenerateMacroClass_cp_85112._N_types_85037), MacroParm.Expr);
					}
					else if (((PExpr.Ref)t).name.idl == "short")
					{
						result = new Nemerle.Builtins.Tuple<PExpr.Call, list<string>.Cons, MacroParm>(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("SyntaxElement", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Expression", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("PExpr", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Literal", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("Literal", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Integer", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Assign(new PExpr.Ref(Name.NameInCurrentColor("AsShort", _N_MacroContexts.Get(10, ManagerClass.Instance))), new PExpr.Call(new PExpr.Ref(Name.NameInCurrentColor("Some", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Ref(va), list<PExpr>.Nil._N_constant_object))), list<PExpr>.Nil._N_constant_object)), list<PExpr>.Nil._N_constant_object)), list<PExpr>.Nil._N_constant_object)), new list<string>.Cons("short", _N_GenerateMacroClass_cp_85112._N_types_85037), MacroParm.Expr);
					}
					else if (((PExpr.Ref)t).name.idl == "ushort")
					{
						result = new Nemerle.Builtins.Tuple<PExpr.Call, list<string>.Cons, MacroParm>(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("SyntaxElement", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Expression", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("PExpr", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Literal", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("Literal", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Integer", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Assign(new PExpr.Ref(Name.NameInCurrentColor("AsUShort", _N_MacroContexts.Get(10, ManagerClass.Instance))), new PExpr.Call(new PExpr.Ref(Name.NameInCurrentColor("Some", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Ref(va), list<PExpr>.Nil._N_constant_object))), list<PExpr>.Nil._N_constant_object)), list<PExpr>.Nil._N_constant_object)), list<PExpr>.Nil._N_constant_object)), new list<string>.Cons("ushort", _N_GenerateMacroClass_cp_85112._N_types_85037), MacroParm.Expr);
					}
					else if (((PExpr.Ref)t).name.idl == "byte")
					{
						result = new Nemerle.Builtins.Tuple<PExpr.Call, list<string>.Cons, MacroParm>(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("SyntaxElement", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Expression", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("PExpr", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Literal", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("Literal", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Integer", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Assign(new PExpr.Ref(Name.NameInCurrentColor("AsByte", _N_MacroContexts.Get(10, ManagerClass.Instance))), new PExpr.Call(new PExpr.Ref(Name.NameInCurrentColor("Some", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Ref(va), list<PExpr>.Nil._N_constant_object))), list<PExpr>.Nil._N_constant_object)), list<PExpr>.Nil._N_constant_object)), list<PExpr>.Nil._N_constant_object)), new list<string>.Cons("byte", _N_GenerateMacroClass_cp_85112._N_types_85037), MacroParm.Expr);
					}
					else if (((PExpr.Ref)t).name.idl == "sbyte")
					{
						result = new Nemerle.Builtins.Tuple<PExpr.Call, list<string>.Cons, MacroParm>(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("SyntaxElement", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Expression", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("PExpr", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Literal", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("Literal", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Integer", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Assign(new PExpr.Ref(Name.NameInCurrentColor("AsSByte", _N_MacroContexts.Get(10, ManagerClass.Instance))), new PExpr.Call(new PExpr.Ref(Name.NameInCurrentColor("Some", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Ref(va), list<PExpr>.Nil._N_constant_object))), list<PExpr>.Nil._N_constant_object)), list<PExpr>.Nil._N_constant_object)), list<PExpr>.Nil._N_constant_object)), new list<string>.Cons("sbyte", _N_GenerateMacroClass_cp_85112._N_types_85037), MacroParm.Expr);
					}
					else if (((PExpr.Ref)t).name.idl == "float")
					{
						result = new Nemerle.Builtins.Tuple<PExpr.Call, list<string>.Cons, MacroParm>(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("SyntaxElement", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Expression", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("PExpr", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Literal", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("Literal", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Float", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Ref(va), list<PExpr>.Nil._N_constant_object)), list<PExpr>.Nil._N_constant_object)), list<PExpr>.Nil._N_constant_object)), new list<string>.Cons("float", _N_GenerateMacroClass_cp_85112._N_types_85037), MacroParm.Expr);
					}
					else if (((PExpr.Ref)t).name.idl == "double")
					{
						result = new Nemerle.Builtins.Tuple<PExpr.Call, list<string>.Cons, MacroParm>(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("SyntaxElement", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Expression", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("PExpr", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Literal", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("Literal", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Double", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Ref(va), list<PExpr>.Nil._N_constant_object)), list<PExpr>.Nil._N_constant_object)), list<PExpr>.Nil._N_constant_object)), new list<string>.Cons("double", _N_GenerateMacroClass_cp_85112._N_types_85037), MacroParm.Expr);
					}
					else if (((PExpr.Ref)t).name.idl == "decimal")
					{
						result = new Nemerle.Builtins.Tuple<PExpr.Call, list<string>.Cons, MacroParm>(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("SyntaxElement", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Expression", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("PExpr", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Literal", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("Literal", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Decimal", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Ref(va), list<PExpr>.Nil._N_constant_object)), list<PExpr>.Nil._N_constant_object)), list<PExpr>.Nil._N_constant_object)), new list<string>.Cons("decimal", _N_GenerateMacroClass_cp_85112._N_types_85037), MacroParm.Expr);
					}
					else
					{
						if (!(((PExpr.Ref)t).name.idl == "bool"))
						{
							Name name = ((PExpr.Ref)t).name;
							Message.Error(_N_GenerateMacroClass_cp_85112._N_loc_85035, "type " + Convert.ToString(name.Id) + " not supported for macro parameter");
							throw new Recovery();
						}
						result = new Nemerle.Builtins.Tuple<PExpr.Call, list<string>.Cons, MacroParm>(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("SyntaxElement", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Expression", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("PExpr", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Literal", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("Literal", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Bool", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Ref(va), list<PExpr>.Nil._N_constant_object)), list<PExpr>.Nil._N_constant_object)), list<PExpr>.Nil._N_constant_object)), new list<string>.Cons("bool", _N_GenerateMacroClass_cp_85112._N_types_85037), MacroParm.Expr);
					}
				}
				goto IL_1c55;
			}
		}
		result = new Nemerle.Builtins.Tuple<PExpr.Call, list<string>.Cons, MacroParm>(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("SyntaxElement", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Expression", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Ref(va), list<PExpr>.Nil._N_constant_object)), new list<string>.Cons("PExpr", _N_GenerateMacroClass_cp_85112._N_types_85037), MacroParm.Expr);
		goto IL_1c55;
		IL_1b4f:
		_N_set_target_info_85065(_N_GenerateMacroClass_cp_85112, 1, 2, ":event", "ParsedEvent");
		result = new Nemerle.Builtins.Tuple<PExpr.Call, list<string>.Cons, MacroParm>(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("SyntaxElement", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("ClassMember", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.As(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("ClassMember", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Event", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new Splicable.Name(va)), list<PExpr>.Nil._N_constant_object)), new list<string>.Cons("ParsedEvent", _N_GenerateMacroClass_cp_85112._N_types_85037), MacroParm.Implicit);
		goto IL_1c55;
		IL_189d:
		_N_set_target_info_85065(_N_GenerateMacroClass_cp_85112, 1, 2, ":field", "ParsedField");
		result = new Nemerle.Builtins.Tuple<PExpr.Call, list<string>.Cons, MacroParm>(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("SyntaxElement", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("ClassMember", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.As(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("ClassMember", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Field", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new Splicable.Name(va)), list<PExpr>.Nil._N_constant_object)), new list<string>.Cons("ParsedField", _N_GenerateMacroClass_cp_85112._N_types_85037), MacroParm.Implicit);
		goto IL_1c55;
		IL_1c55:
		return result;
		IL_1983:
		_N_set_target_info_85065(_N_GenerateMacroClass_cp_85112, 1, 2, ":method", "ParsedMethod");
		result = new Nemerle.Builtins.Tuple<PExpr.Call, list<string>.Cons, MacroParm>(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("SyntaxElement", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("ClassMember", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.As(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("ClassMember", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Function", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new Splicable.Name(va)), list<PExpr>.Nil._N_constant_object)), new list<string>.Cons("ParsedMethod", _N_GenerateMacroClass_cp_85112._N_types_85037), MacroParm.Implicit);
		goto IL_1c55;
		IL_1a69:
		_N_set_target_info_85065(_N_GenerateMacroClass_cp_85112, 1, 2, ":property", "ParsedProperty");
		result = new Nemerle.Builtins.Tuple<PExpr.Call, list<string>.Cons, MacroParm>(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("SyntaxElement", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("ClassMember", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.As(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("ClassMember", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Property", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new Splicable.Name(va)), list<PExpr>.Nil._N_constant_object)), new list<string>.Cons("ParsedProperty", _N_GenerateMacroClass_cp_85112._N_types_85037), MacroParm.Implicit);
		goto IL_1c55;
	}

	private static Nemerle.Builtins.Tuple<list<PExpr>.Cons, list<PExpr>.Cons> _N_traverse_patterns_85152(_N_closureOf_GenerateMacroClass_85020 _N_GenerateMacroClass_cp_85151, list<list<PExpr>> pattss, list<Nemerle.Builtins.Tuple<Name, PExpr>> defaults, list<Nemerle.Builtins.Tuple<Name, PExpr>> defsrest, list<PExpr>.Cons accpat, list<PExpr>.Cons accexp)
	{
		while (true)
		{
			if ((object)pattss == list<list<PExpr>>.Nil._N_constant_object)
			{
				return new Nemerle.Builtins.Tuple<list<PExpr>.Cons, list<PExpr>.Cons>(accpat, accexp);
			}
			if (!(pattss is list<list<PExpr>>.Cons))
			{
				break;
			}
			if ((object)defaults == list<Nemerle.Builtins.Tuple<Name, PExpr>>.Nil._N_constant_object)
			{
				list<PExpr> list = ((list<list<PExpr>>.Cons)pattss).hd;
				list<list<PExpr>> list2 = ((list<list<PExpr>>.Cons)pattss).tl;
				list<list<PExpr>> obj = list2;
				list<Nemerle.Builtins.Tuple<Name, PExpr>> obj2 = list<Nemerle.Builtins.Tuple<Name, PExpr>>.Nil._N_constant_object;
				list<Nemerle.Builtins.Tuple<Name, PExpr>> obj3 = list<Nemerle.Builtins.Tuple<Name, PExpr>>.Nil._N_constant_object;
				list<PExpr>.Cons obj4 = new list<PExpr>.Cons(new PExpr.ListLiteral(Macros.QuotationChoose(list.Rev())), accpat);
				accexp = new list<PExpr>.Cons(_N_roll_expr_85104(defsrest, _N_GenerateMacroClass_cp_85151._N_expr_85031), accexp);
				accpat = obj4;
				defsrest = obj3;
				defaults = obj2;
				pattss = obj;
				continue;
			}
			if (defaults is list<Nemerle.Builtins.Tuple<Name, PExpr>>.Cons)
			{
				list<PExpr> list = ((list<list<PExpr>>.Cons)pattss).hd;
				list<list<PExpr>> list2 = ((list<list<PExpr>>.Cons)pattss).tl;
				Nemerle.Builtins.Tuple<Name, PExpr> hd = ((list<Nemerle.Builtins.Tuple<Name, PExpr>>.Cons)defaults).hd;
				list<Nemerle.Builtins.Tuple<Name, PExpr>> list3 = ((list<Nemerle.Builtins.Tuple<Name, PExpr>>.Cons)defaults).tl;
				list<Nemerle.Builtins.Tuple<Name, PExpr>>.Cons cons = new list<Nemerle.Builtins.Tuple<Name, PExpr>>.Cons(hd, defsrest);
				list<list<PExpr>> obj5 = list2;
				list<Nemerle.Builtins.Tuple<Name, PExpr>> obj6 = list3;
				list<Nemerle.Builtins.Tuple<Name, PExpr>> obj7 = cons;
				list<PExpr>.Cons obj8 = new list<PExpr>.Cons(new PExpr.ListLiteral(Macros.QuotationChoose(list.Rev())), accpat);
				accexp = new list<PExpr>.Cons(_N_roll_expr_85104(defsrest, _N_GenerateMacroClass_cp_85151._N_expr_85031), accexp);
				accpat = obj8;
				defsrest = obj7;
				defaults = obj6;
				pattss = obj5;
				continue;
			}
			throw new MatchFailureException();
		}
		throw new MatchFailureException();
	}

	private static PExpr.Sequence _N_message_85170(_N_closureOf_GenerateMacroClass_85020 _N_GenerateMacroClass_cp_85169, list<string> types)
	{
		string val = types.Rev().ToString(", ");
		return new PExpr.Sequence(new list<PExpr>.Cons(new PExpr.Define(new PExpr.Ref(Name.NameInCurrentColor("len", _N_MacroContexts.Get(10, ManagerClass.Instance))), new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("parms", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Length", _N_MacroContexts.Get(10, ManagerClass.Instance))))), new list<PExpr>.Cons(new PExpr.Define(new PExpr.Ref(Name.NameInCurrentColor("types", _N_MacroContexts.Get(10, ManagerClass.Instance))), new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("parms", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("ToString", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Literal(new Literal.String(", ")), list<PExpr>.Nil._N_constant_object))), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("Message", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("FatalError", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Ref(Name.NameInCurrentColor("+", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Ref(Name.NameInCurrentColor("+", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Ref(Name.NameInCurrentColor("+", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Ref(Name.NameInCurrentColor("+", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Ref(Name.NameInCurrentColor("+", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Ref(Name.NameInCurrentColor("+", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Ref(Name.NameInCurrentColor("+", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Ref(Name.NameInCurrentColor("+", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Literal(new Literal.String("macro `")), new list<PExpr>.Cons(new PExpr.Literal(new Literal.String(_N_GenerateMacroClass_cp_85169._N_name_85033)), list<PExpr>.Nil._N_constant_object))), new list<PExpr>.Cons(new PExpr.Literal(new Literal.String("' expects following list of arguments: (")), list<PExpr>.Nil._N_constant_object))), new list<PExpr>.Cons(new PExpr.Literal(new Literal.String(val)), list<PExpr>.Nil._N_constant_object))), new list<PExpr>.Cons(new PExpr.Literal(new Literal.String(") got some ")), list<PExpr>.Nil._N_constant_object))), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("len", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("ToString", _N_MacroContexts.Get(10, ManagerClass.Instance)))), list<PExpr>.Nil._N_constant_object), list<PExpr>.Nil._N_constant_object))), new list<PExpr>.Cons(new PExpr.Literal(new Literal.String(" parameters [")), list<PExpr>.Nil._N_constant_object))), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("types", _N_MacroContexts.Get(10, ManagerClass.Instance))), list<PExpr>.Nil._N_constant_object))), new list<PExpr>.Cons(new PExpr.Literal(new Literal.String("]")), list<PExpr>.Nil._N_constant_object))), list<PExpr>.Nil._N_constant_object)), list<PExpr>.Nil._N_constant_object))));
	}

	private static string _N_makeParamDefaultValues_85307(PParameter param)
	{
		option<PExpr> defaultValue = param.DefaultValue;
		object result;
		if (defaultValue is option<PExpr>.Some)
		{
			PExpr val = ((option<PExpr>.Some)defaultValue).val;
			result = val.ToString();
		}
		else
		{
			list<PExpr> custom_attrs = param.modifiers.custom_attrs;
			if (custom_attrs is list<PExpr>.Cons && ((list<PExpr>.Cons)custom_attrs).hd is PExpr.Call && ((PExpr.Call)((list<PExpr>.Cons)custom_attrs).hd).func is PExpr.Member && ((PExpr.Member)((PExpr.Call)((list<PExpr>.Cons)custom_attrs).hd).func).obj is PExpr.Member && ((PExpr.Member)((PExpr.Member)((PExpr.Call)((list<PExpr>.Cons)custom_attrs).hd).func).obj).obj is PExpr.Ref && ((PExpr.Ref)((PExpr.Member)((PExpr.Member)((PExpr.Call)((list<PExpr>.Cons)custom_attrs).hd).func).obj).obj).name.idl == "System" && ((PExpr.Member)((PExpr.Member)((PExpr.Call)((list<PExpr>.Cons)custom_attrs).hd).func).obj).member is Splicable.Name && ((Splicable.Name)((PExpr.Member)((PExpr.Member)((PExpr.Call)((list<PExpr>.Cons)custom_attrs).hd).func).obj).member).body.idl == "ComponentModel" && ((PExpr.Member)((PExpr.Call)((list<PExpr>.Cons)custom_attrs).hd).func).member is Splicable.Name && ((Splicable.Name)((PExpr.Member)((PExpr.Call)((list<PExpr>.Cons)custom_attrs).hd).func).member).body.idl == "DefaultValueAttribute" && ((PExpr.Call)((list<PExpr>.Cons)custom_attrs).hd).parms is list<PExpr>.Cons && (object)((list<PExpr>.Cons)((PExpr.Call)((list<PExpr>.Cons)custom_attrs).hd).parms).tl == list<PExpr>.Nil._N_constant_object)
			{
				PExpr val = ((list<PExpr>.Cons)((PExpr.Call)((list<PExpr>.Cons)custom_attrs).hd).parms).hd;
				if ((object)((list<PExpr>.Cons)custom_attrs).tl == list<PExpr>.Nil._N_constant_object)
				{
					result = val.ToString();
					goto IL_02d8;
				}
			}
			result = "";
		}
		goto IL_02d8;
		IL_02d8:
		return (string)result;
	}

	private static string _N_makeParamType_85335(PParameter param)
	{
		PExpr type = param.Type;
		object result;
		if ((object)type != null && !(type is PExpr.Wildcard))
		{
			if (!(type is PExpr.Ref))
			{
				if (type is PExpr.Array)
				{
					if (!(((PExpr.Array)type).rank is PExpr.Literal) || !(((PExpr.Literal)((PExpr.Array)type).rank).val is Literal.Integer) || ((Literal.Integer)((PExpr.Literal)((PExpr.Array)type).rank).val).val != 1 || ((Literal.Integer)((PExpr.Literal)((PExpr.Array)type).rank).val).is_negative || !(((PExpr.Array)type).args is PExpr.ListLiteral) || !(((PExpr.ListLiteral)((PExpr.Array)type).args).elements is list<PExpr>.Cons) || !(((list<PExpr>.Cons)((PExpr.ListLiteral)((PExpr.Array)type).args).elements).hd is PExpr.Ref))
					{
						goto IL_039c;
					}
					if (((PExpr.Ref)((list<PExpr>.Cons)((PExpr.ListLiteral)((PExpr.Array)type).args).elements).hd).name.idl == "PExpr")
					{
						if ((object)((list<PExpr>.Cons)((PExpr.ListLiteral)((PExpr.Array)type).args).elements).tl != list<PExpr>.Nil._N_constant_object)
						{
							goto IL_039c;
						}
						result = "array[PExpr]";
					}
					else
					{
						if (!(((PExpr.Ref)((list<PExpr>.Cons)((PExpr.ListLiteral)((PExpr.Array)type).args).elements).hd).name.idl == "expr") || (object)((list<PExpr>.Cons)((PExpr.ListLiteral)((PExpr.Array)type).args).elements).tl != list<PExpr>.Nil._N_constant_object)
						{
							goto IL_039c;
						}
						result = "array[PExpr]";
					}
				}
				else
				{
					if (!(type is PExpr.Indexer) || !(((PExpr.Indexer)type).obj is PExpr.Ref) || !(((PExpr.Ref)((PExpr.Indexer)type).obj).name.idl == "list") || !(((PExpr.Indexer)type).args is list<PExpr>.Cons) || !(((list<PExpr>.Cons)((PExpr.Indexer)type).args).hd is PExpr.Ref) || !(((PExpr.Ref)((list<PExpr>.Cons)((PExpr.Indexer)type).args).hd).name.idl == "expr") || (object)((list<PExpr>.Cons)((PExpr.Indexer)type).args).tl != list<PExpr>.Nil._N_constant_object)
					{
						goto IL_039c;
					}
					result = "list[PExpr]";
				}
				goto IL_03a2;
			}
			if (!(((PExpr.Ref)type).name.idl == "expr"))
			{
				goto IL_039c;
			}
		}
		result = "PExpr";
		goto IL_03a2;
		IL_03a2:
		return (string)result;
		IL_039c:
		result = type.ToString();
		goto IL_03a2;
	}

	private static void _N_makeRuleStr_85402(_N_closureOf_makeGrammarString_85300 _N_makeGrammarString_cp_85401, PExpr expr, StringBuilder sb)
	{
		if (sb.Length > 0)
		{
			char c = sb[checked(sb.Length - 1)];
			if (c != '(')
			{
				StringBuilder stringBuilder = sb.Append(' ');
			}
		}
		if (expr is PExpr.Ref)
		{
			Name name = ((PExpr.Ref)expr).name;
			StringBuilder stringBuilder = sb.Append(name.Id);
			return;
		}
		if (expr is PExpr.Call)
		{
			if (((PExpr.Call)expr).func is PExpr.Ref && ((PExpr.Ref)((PExpr.Call)expr).func).name.idl == "Optional")
			{
				StringBuilder stringBuilder;
				if (((PExpr.Call)expr).parms is list<PExpr>.Cons && (object)((list<PExpr>.Cons)((PExpr.Call)expr).parms).tl == list<PExpr>.Nil._N_constant_object)
				{
					PExpr hd = ((list<PExpr>.Cons)((PExpr.Call)expr).parms).hd;
					_N_makeRuleStr_85402(_N_makeGrammarString_cp_85401, hd, sb);
					stringBuilder = sb.Append("?");
					return;
				}
				list<PExpr> list = ((PExpr.Call)expr).parms;
				stringBuilder = sb.Append("(");
				list = list;
				while (list is list<PExpr>.Cons)
				{
					PExpr hd = ((list<PExpr>.Cons)list).hd;
					list = ((list<PExpr>.Cons)list).tl;
					_N_makeRuleStr_85402(_N_makeGrammarString_cp_85401, hd, sb);
					list = list;
				}
				stringBuilder = sb.Append(")?");
				return;
			}
		}
		else if (expr is PExpr.Literal)
		{
			Literal val = ((PExpr.Literal)expr).val;
			StringBuilder stringBuilder = sb.Append((!(val.RawString != null)) ? val.ToString() : val.RawString);
			return;
		}
		throw new AssertionException("ncc\\hierarchy\\MacroClassGen.n", 580, "", "");
	}

	private static PExpr _N_create_transform_tree_85488(_N_closureOf_GenerateMacroClass_85020 _N_GenerateMacroClass_cp_85487, list<MacroParm> parms)
	{
		checked
		{
			object result;
			while (true)
			{
				if (parms is list<MacroParm>.Cons)
				{
					MacroParm hd = ((list<MacroParm>.Cons)parms).hd;
					if (hd == MacroParm.Expr)
					{
						list<MacroParm> parms2 = ((list<MacroParm>.Cons)parms).tl;
						result = new PExpr.Match(new PExpr.Ref(Name.NameInCurrentColor("trans_p", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<MatchCase>.Cons(new MatchCase(new list<PExpr>.Cons(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("list", _N_MacroContexts.Get(2, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Cons", _N_MacroContexts.Get(2, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("x", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("trans_p", _N_MacroContexts.Get(10, ManagerClass.Instance))), list<PExpr>.Nil._N_constant_object))), list<PExpr>.Nil._N_constant_object), new PExpr.Sequence(new list<PExpr>.Cons(new PExpr.Assign(new PExpr.Ref(Name.NameInCurrentColor("trans_res", _N_MacroContexts.Get(10, ManagerClass.Instance))), new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("list", _N_MacroContexts.Get(2, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Cons", _N_MacroContexts.Get(2, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("SyntaxElement", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Expression", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("x", _N_MacroContexts.Get(10, ManagerClass.Instance))), list<PExpr>.Nil._N_constant_object)), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("trans_res", _N_MacroContexts.Get(10, ManagerClass.Instance))), list<PExpr>.Nil._N_constant_object)))), new list<PExpr>.Cons(Macros.QuotationChoose(_N_create_transform_tree_85488(_N_GenerateMacroClass_cp_85487, parms2)), list<PExpr>.Nil._N_constant_object)))), new list<MatchCase>.Cons(new MatchCase(new list<PExpr>.Cons(new PExpr.ListLiteral(list<PExpr>.Nil._N_constant_object), list<PExpr>.Nil._N_constant_object), new PExpr.Literal(new Literal.Void())), list<MatchCase>.Nil._N_constant_object)));
						break;
					}
					if (hd == MacroParm.Exprs)
					{
						if ((object)((list<MacroParm>.Cons)parms).tl == list<MacroParm>.Nil._N_constant_object)
						{
							result = new PExpr.Sequence(new list<PExpr>.Cons(new PExpr.DefFunctions(new list<Function_decl>.Cons(new Function_decl(new PFunHeader(new Typarms(list<Splicable>.Nil._N_constant_object, list<Constraint>.Nil._N_constant_object), new Splicable.Name(Name.NameInCurrentColor("app_expr", _N_MacroContexts.Get(10, ManagerClass.Instance))), new PExpr.Wildcard(), new list<PParameter>.Cons(new PParameter(new Splicable.Name(Name.NameInCurrentColor("l", _N_MacroContexts.Get(10, ManagerClass.Instance))), new AttributesAndModifiers(NemerleModifiers.None, list<PExpr>.Nil._N_constant_object), new PExpr.Indexer(new PExpr.Ref(Name.NameInCurrentColor("list", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("PExpr", _N_MacroContexts.Get(10, ManagerClass.Instance))), list<PExpr>.Nil._N_constant_object))), list<PParameter>.Nil._N_constant_object)), new PExpr.Match(new PExpr.Ref(Name.NameInCurrentColor("l", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<MatchCase>.Cons(new MatchCase(new list<PExpr>.Cons(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("list", _N_MacroContexts.Get(2, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Cons", _N_MacroContexts.Get(2, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("x", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("xs", _N_MacroContexts.Get(10, ManagerClass.Instance))), list<PExpr>.Nil._N_constant_object))), list<PExpr>.Nil._N_constant_object), new PExpr.Sequence(new list<PExpr>.Cons(new PExpr.Assign(new PExpr.Ref(Name.NameInCurrentColor("trans_res", _N_MacroContexts.Get(10, ManagerClass.Instance))), new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("list", _N_MacroContexts.Get(2, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Cons", _N_MacroContexts.Get(2, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("SyntaxElement", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Expression", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("x", _N_MacroContexts.Get(10, ManagerClass.Instance))), list<PExpr>.Nil._N_constant_object)), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("trans_res", _N_MacroContexts.Get(10, ManagerClass.Instance))), list<PExpr>.Nil._N_constant_object)))), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Ref(Name.NameInCurrentColor("app_expr", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("xs", _N_MacroContexts.Get(10, ManagerClass.Instance))), list<PExpr>.Nil._N_constant_object)), list<PExpr>.Nil._N_constant_object)))), new list<MatchCase>.Cons(new MatchCase(new list<PExpr>.Cons(new PExpr.ListLiteral(list<PExpr>.Nil._N_constant_object), list<PExpr>.Nil._N_constant_object), new PExpr.Literal(new Literal.Void())), list<MatchCase>.Nil._N_constant_object)))), list<Function_decl>.Nil._N_constant_object)), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Ref(Name.NameInCurrentColor("app_expr", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("trans_p", _N_MacroContexts.Get(10, ManagerClass.Instance))), list<PExpr>.Nil._N_constant_object)), list<PExpr>.Nil._N_constant_object)));
							break;
						}
					}
					else if (hd == MacroParm.Implicit)
					{
						list<MacroParm> parms2 = ((list<MacroParm>.Cons)parms).tl;
						_N_GenerateMacroClass_cp_85487._N_count_85025--;
						parms = parms2;
						continue;
					}
				}
				else if ((object)parms == list<MacroParm>.Nil._N_constant_object)
				{
					result = new PExpr.Match(new PExpr.Ref(Name.NameInCurrentColor("trans_p", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<MatchCase>.Cons(new MatchCase(new list<PExpr>.Cons(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("list", _N_MacroContexts.Get(2, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Cons", _N_MacroContexts.Get(2, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("x", _N_MacroContexts.Get(10, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Wildcard(), list<PExpr>.Nil._N_constant_object))), list<PExpr>.Nil._N_constant_object), new PExpr.Assign(new PExpr.Ref(Name.NameInCurrentColor("trans_res", _N_MacroContexts.Get(10, ManagerClass.Instance))), new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("list", _N_MacroContexts.Get(2, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Cons", _N_MacroContexts.Get(2, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("SyntaxElement", _N_MacroContexts.Get(10, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Expression", _N_MacroContexts.Get(10, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("x", _N_MacroContexts.Get(10, ManagerClass.Instance))), list<PExpr>.Nil._N_constant_object)), new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("trans_res", _N_MacroContexts.Get(10, ManagerClass.Instance))), list<PExpr>.Nil._N_constant_object))))), new list<MatchCase>.Cons(new MatchCase(new list<PExpr>.Cons(new PExpr.ListLiteral(list<PExpr>.Nil._N_constant_object), list<PExpr>.Nil._N_constant_object), new PExpr.Literal(new Literal.Void())), list<MatchCase>.Nil._N_constant_object)));
					break;
				}
				if (!Message.SeenError)
				{
					string text = "corrupted macro parameters".ToString();
					Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
				}
				throw new AssertionException("ncc\\hierarchy\\MacroClassGen.n", 689, "", "corrupted macro parameters");
			}
			return (PExpr)result;
		}
	}
}
