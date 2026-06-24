using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Collections;
using Nemerle.Compiler.Parsetree;
using Nemerle.Core;
using Nemerle.Internal;

namespace Nemerle.Compiler;

public class MainParser : ISupportRelocation
{
	protected internal class OperatorInfo : ISupportRelocation
	{
		public readonly string Name;

		public readonly int LeftPriority;

		public readonly int RightPriority;

		public static readonly OperatorInfo RoundInfo;

		public static readonly OperatorInfo SquareInfo;

		public static readonly OperatorInfo ProductInfo;

		public static readonly OperatorInfo UnMinus;

		public static readonly OperatorInfo UnPlus;

		static OperatorInfo()
		{
			RoundInfo = new OperatorInfo("(", 290, 291);
			SquareInfo = new OperatorInfo("[", 290, 291);
			ProductInfo = new OperatorInfo("*", 261, 260);
			UnMinus = new UnaryOperatorInfo("-", 281, 280);
			UnPlus = new UnaryOperatorInfo("+", 281, 280);
		}

		public override string ToString()
		{
			return Convert.ToString(GetType().Name) + ":'" + Convert.ToString(Name) + "'";
		}

		[RecordCtor]
		public OperatorInfo([MappedMember("Name")] string name, [MappedMember("LeftPriority")] int leftPriority, [MappedMember("RightPriority")] int rightPriority)
		{
			Name = name;
			LeftPriority = leftPriority;
			RightPriority = rightPriority;
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

	protected internal class UnaryOperatorInfo : OperatorInfo
	{
		public UnaryOperatorInfo(string name, int left, int right)
			: base(name, left, right)
		{
		}
	}

	protected internal class BinaryOperatorInfo : OperatorInfo
	{
		public BinaryOperatorInfo(string name, int left, int right)
			: base(name, left, right)
		{
		}
	}

	private class NaryOperatorInfo : OperatorInfo
	{
		public Location Location;

		public list<PExpr> ExprsBegin;

		public NaryOperatorInfo(OperatorInfo copy, Location location)
			: base(copy.Name, copy.LeftPriority, copy.RightPriority)
		{
			Location = location;
		}

		public override string ToString()
		{
			return "NaryOperatorInfo:'" + Convert.ToString(Name) + "' (ExprsBegin=" + Convert.ToString(ExprsBegin) + ")";
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
			list<PExpr> exprsBegin = ExprsBegin;
			if (exprsBegin != null)
			{
				exprsBegin = exprsBegin;
				while (exprsBegin is list<PExpr>.Cons)
				{
					PExpr hd = ((list<PExpr>.Cons)exprsBegin).hd;
					exprsBegin = ((list<PExpr>.Cons)exprsBegin).tl;
					((ISupportRelocation)hd).RelocateImpl(_info);
					exprsBegin = exprsBegin;
				}
			}
			Location = Completion.Relocate(Location, _info);
		}
	}

	private sealed class _N_closureOf_parse_top_extensions_35169
	{
		internal Token.Keyword _N_tok_35180;

		internal list<SyntaxElement> _N_parms_35178;

		internal AttributesAndModifiers _N_modifiers_35176;

		internal MainParser _N__N_closurised_this_ptr_35174;

		internal _N_closureOf_parse_top_extensions_35169()
		{
		}
	}

	private sealed class _N__N_lambda__35227__35243 : Function<SyntaxElement, Location, Location>
	{
		[SpecialName]
		public static readonly _N__N_lambda__35227__35243 Instance = new _N__N_lambda__35227__35243();

		[SpecialName]
		public sealed override Location apply(SyntaxElement e, Location l)
		{
			return l.Combine(e.Location);
		}
	}

	private sealed class _N_closureOf_parse_grammar_rule_35374
	{
		internal TokenStoppers _N_stop_35383;

		internal AttributeTargets _N_target_35381;

		internal MainParser _N__N_closurised_this_ptr_35379;

		internal _N_closureOf_parse_grammar_rule_35374()
		{
		}
	}

	private sealed class _N_closureOf_loop_35407
	{
		internal string _N_brace_35412;

		internal _N_closureOf_loop_35407()
		{
		}
	}

	private sealed class _N__N_lambda__35344__35461 : Function<PExpr, SyntaxElement>
	{
		[SpecialName]
		public static readonly _N__N_lambda__35344__35461 Instance = new _N__N_lambda__35344__35461();

		[SpecialName]
		public sealed override SyntaxElement apply(PExpr x)
		{
			return new SyntaxElement.Expression(x);
		}
	}

	private sealed class _N_closureOf_ParseCommaSeparatedExprList_35562
	{
		internal MainParser _N_parser_35567;

		internal _N_closureOf_ParseCommaSeparatedExprList_35562()
		{
		}
	}

	private sealed class _N__N_lambda__35556__35584 : Function<PExpr>
	{
		[SpecialName]
		private _N_closureOf_ParseCommaSeparatedExprList_35562 _N_ParseCommaSeparatedExprList_closure_35588;

		public _N__N_lambda__35556__35584(_N_closureOf_ParseCommaSeparatedExprList_35562 _N_ParseCommaSeparatedExprList_closure_35588)
		{
			this._N_ParseCommaSeparatedExprList_closure_35588 = _N_ParseCommaSeparatedExprList_closure_35588;
		}

		[SpecialName]
		public sealed override PExpr apply()
		{
			return _N_ParseCommaSeparatedExprList_closure_35588._N_parser_35567.parse_expr(TokenStoppers.All);
		}
	}

	private sealed class _N_closureOf_ParseTypeDeclaration_36358
	{
		internal AttributesAndModifiers _N_mods_36367;

		internal Location _N_startLocation_36365;

		internal MainParser _N__N_closurised_this_ptr_36363;

		internal _N_closureOf_ParseTypeDeclaration_36358()
		{
		}
	}

	private sealed class _N_closureOf_processType_36376
	{
		internal Location _N_end_loc_36381;

		internal _N_closureOf_processType_36376()
		{
		}
	}

	private sealed class _N__N_lambda__36271__36420 : Function<PExpr>
	{
		[SpecialName]
		private _N_closureOf_ParseTypeDeclaration_36358 _N_ParseTypeDeclaration_closure_36424;

		public _N__N_lambda__36271__36420(_N_closureOf_ParseTypeDeclaration_36358 _N_ParseTypeDeclaration_closure_36424)
		{
			this._N_ParseTypeDeclaration_closure_36424 = _N_ParseTypeDeclaration_closure_36424;
		}

		[SpecialName]
		public sealed override PExpr apply()
		{
			return _N_ParseTypeDeclaration_closure_36424._N__N_closurised_this_ptr_36363.parse_expr(TokenStoppers.All);
		}
	}

	private sealed class _N__N_lambda__36276__36434 : Function<PExpr, bool>
	{
		[SpecialName]
		public static readonly _N__N_lambda__36276__36434 Instance = new _N__N_lambda__36276__36434();

		[SpecialName]
		public sealed override bool apply(PExpr e)
		{
			if (e is PExpr.Error)
			{
				if (true)
				{
					goto IL_001c;
				}
			}
			else if (false)
			{
				goto IL_001c;
			}
			int result = ((e is PExpr.Member && (object)((PExpr.Member)e).member == null) ? 1 : 0);
			goto IL_0051;
			IL_001c:
			result = 1;
			goto IL_0051;
			IL_0051:
			return (byte)result != 0;
		}
	}

	private sealed class _N__N_lambda__36282__36453 : Function<PExpr, bool>
	{
		[SpecialName]
		public static readonly _N__N_lambda__36282__36453 Instance = new _N__N_lambda__36282__36453();

		[SpecialName]
		public sealed override bool apply(PExpr e)
		{
			if (e is PExpr.Error)
			{
				if (true)
				{
					goto IL_001c;
				}
			}
			else if (false)
			{
				goto IL_001c;
			}
			int num = ((e is PExpr.Member && (object)((PExpr.Member)e).member == null) ? 1 : 0);
			goto IL_0051;
			IL_001c:
			num = 1;
			goto IL_0051;
			IL_0051:
			bool flag = (byte)num != 0;
			return !flag;
		}
	}

	private sealed class _N_closureOf_ParseClassMember_36615
	{
		internal List<ClassMember> _N_members_36628;

		internal Token _N_start_tok_36626;

		internal MainParser _N__N_closurised_this_ptr_36624;

		internal list<Token.SquareGroup> _N_customs_36622;

		internal AttributesAndModifiers _N_mods_36620;

		internal _N_closureOf_ParseClassMember_36615()
		{
		}
	}

	private sealed class _N_closureOf_parse_method_36735
	{
		internal MainParser _N__N_closurised_this_ptr_36740;

		internal _N_closureOf_parse_method_36735()
		{
		}
	}

	private sealed class _N__N_lambda__36717__36745 : Function<PExpr>
	{
		[SpecialName]
		private _N_closureOf_parse_method_36735 _N_parse_method_closure_36749;

		public _N__N_lambda__36717__36745(_N_closureOf_parse_method_36735 _N_parse_method_closure_36749)
		{
			this._N_parse_method_closure_36749 = _N_parse_method_closure_36749;
		}

		[SpecialName]
		public sealed override PExpr apply()
		{
			return _N_parse_method_closure_36749._N__N_closurised_this_ptr_36740.parse_expr(TokenStoppers.All);
		}
	}

	private sealed class _N_closureOf_parse_option_36840
	{
		internal AttributesAndModifiers _N_modifiers_36847;

		internal MainParser _N__N_closurised_this_ptr_36845;

		internal _N_closureOf_parse_option_36840()
		{
		}
	}

	private sealed class _N_closureOf_parse_property_36993
	{
		internal MainParser _N__N_closurised_this_ptr_36998;

		internal _N_closureOf_parse_property_36993()
		{
		}
	}

	private sealed class _N__N_lambda__36915__37018 : Function<PExpr>
	{
		[SpecialName]
		private _N_closureOf_parse_property_36993 _N_parse_property_closure_37022;

		public _N__N_lambda__36915__37018(_N_closureOf_parse_property_36993 _N_parse_property_closure_37022)
		{
			this._N_parse_property_closure_37022 = _N_parse_property_closure_37022;
		}

		[SpecialName]
		public sealed override PExpr apply()
		{
			return _N_parse_property_closure_37022._N__N_closurised_this_ptr_36998.parse_expr(TokenStoppers.All);
		}
	}

	private sealed class _N__N_lambda__37162__37187 : Function<PExpr, bool>
	{
		[SpecialName]
		public static readonly _N__N_lambda__37162__37187 Instance = new _N__N_lambda__37162__37187();

		[SpecialName]
		public sealed override bool apply(PExpr x)
		{
			int result;
			if (x is PExpr.Ref)
			{
				Name name = ((PExpr.Ref)x).name;
				result = ((name.Id == "RecordIgnore") ? 1 : 0);
			}
			else
			{
				result = 0;
			}
			return (byte)result != 0;
		}
	}

	private sealed class _N_closureOf_take_attributes_out_37432
	{
		internal AttributeTargets _N_what_37445;

		internal bool _N_comply_on_other_37443;

		internal AttributesAndModifiers _N_mods_37441;

		internal list<PExpr> _N_parsedCustomAttrsRev_37439;

		internal MainParser _N__N_closurised_this_ptr_37437;

		internal _N_closureOf_take_attributes_out_37432()
		{
		}
	}

	private sealed class _N__N_lambda__37418__37447 : Function<Token.SquareGroup, bool>
	{
		[SpecialName]
		private _N_closureOf_take_attributes_out_37432 _N_take_attributes_out_closure_37451;

		public _N__N_lambda__37418__37447(_N_closureOf_take_attributes_out_37432 _N_take_attributes_out_closure_37451)
		{
			this._N_take_attributes_out_closure_37451 = _N_take_attributes_out_closure_37451;
		}

		[SpecialName]
		public sealed override bool apply(Token.SquareGroup x)
		{
			bool flag = false;
			_N_take_attributes_out_closure_37451._N_mods_37441.CustomAttributesLocation = _N_take_attributes_out_closure_37451._N_mods_37441.CustomAttributesLocation + x.Location;
			if (_N_take_attributes_out_closure_37451._N_mods_37441.CustomAttributesLocation.Line <= 0)
			{
			}
			flag = true;
			Token child = x.Child;
			int num;
			if (child is Token.LooseGroup)
			{
				child = ((Token.LooseGroup)child).Child;
				_N_take_attributes_out_closure_37451._N__N_closurised_this_ptr_37437.push_stream(child);
				if (child is Token.Identifier)
				{
					if (((Token.Identifier)child).name == "assembly")
					{
						num = 1;
					}
					else if (((Token.Identifier)child).name == "field")
					{
						num = 256;
					}
					else if (((Token.Identifier)child).name == "method")
					{
						num = 64;
					}
					else if (((Token.Identifier)child).name == "param")
					{
						num = 2048;
					}
					else if (((Token.Identifier)child).name == "property")
					{
						num = 128;
					}
					else if (((Token.Identifier)child).name == "return")
					{
						num = 8192;
					}
					else
					{
						if (!(((Token.Identifier)child).name == "type"))
						{
							goto IL_0180;
						}
						num = 4;
					}
				}
				else
				{
					if (!(child is Token.Keyword))
					{
						goto IL_0180;
					}
					if (((Token.Keyword)child).name == "event")
					{
						num = 512;
					}
					else
					{
						if (!(((Token.Keyword)child).name == "module"))
						{
							goto IL_0180;
						}
						num = 2;
					}
				}
				goto IL_01e2;
			}
			if (!Message.SeenError)
			{
				string text = "broken brackets in attribute".ToString();
				Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
			}
			throw new AssertionException("ncc\\parsing\\MainParser.n", 2060, "", "broken brackets in attribute");
			IL_0180:
			num = 32767;
			goto IL_01e2;
			IL_01e2:
			AttributeTargets attributeTargets = (AttributeTargets)num;
			if (attributeTargets != AttributeTargets.All)
			{
				_N_take_attributes_out_closure_37451._N__N_closurised_this_ptr_37437.shift();
				_N_take_attributes_out_closure_37451._N__N_closurised_this_ptr_37437.expect_operator(":");
			}
			if ((attributeTargets & _N_take_attributes_out_closure_37451._N_what_37445) != 0 || attributeTargets == AttributeTargets.All)
			{
				flag = false;
				_N_take_attributes_out_closure_37451._N_parsedCustomAttrsRev_37439 = new list<PExpr>.Cons(_N_take_attributes_out_closure_37451._N__N_closurised_this_ptr_37437.parse_expr(), _N_take_attributes_out_closure_37451._N_parsedCustomAttrsRev_37439);
				if (x.Child.Next != null)
				{
					x.Child = x.Child.Next;
					_N_take_attributes_out_closure_37451._N_parsedCustomAttrsRev_37439 = _N_take_attributes_out_closure_37451._N__N_closurised_this_ptr_37437.parse_expr_sequence(x.Child, _N_take_attributes_out_closure_37451._N_parsedCustomAttrsRev_37439);
				}
				_N_take_attributes_out_closure_37451._N__N_closurised_this_ptr_37437.pop_stream("custom attribute");
			}
			else
			{
				if (_N_take_attributes_out_closure_37451._N_comply_on_other_37443)
				{
					Error(child, "unexpected attribute target `" + Convert.ToString(child) + "'");
				}
				_N_take_attributes_out_closure_37451._N__N_closurised_this_ptr_37437.pop_stream();
			}
			return flag;
		}
	}

	private sealed class _N_closureOf_get_modifiers_37512
	{
		internal MainParser _N__N_closurised_this_ptr_37517;

		internal _N_closureOf_get_modifiers_37512()
		{
		}
	}

	private sealed class _N_closureOf_loop_37526
	{
		internal NemerleModifiers _N_acc_37535;

		internal Token _N_tok_37533;

		internal string _N_key_37531;

		internal _N_closureOf_loop_37526()
		{
		}
	}

	private sealed class _N_closureOf_parse_tyvars_37584
	{
		internal MainParser _N__N_obj_cache_37589;

		internal _N_closureOf_parse_tyvars_37584()
		{
		}
	}

	private sealed class _N__N_method_lambda__37602 : Function<PExpr>
	{
		[SpecialName]
		private _N_closureOf_parse_tyvars_37584 _N_parse_tyvars_closure_37606;

		public _N__N_method_lambda__37602(_N_closureOf_parse_tyvars_37584 _N_parse_tyvars_closure_37606)
		{
			this._N_parse_tyvars_closure_37606 = _N_parse_tyvars_closure_37606;
		}

		[SpecialName]
		public sealed override PExpr apply()
		{
			return _N_parse_tyvars_closure_37606._N__N_obj_cache_37589.parse_expr();
		}
	}

	private sealed class _N_closureOf_parse_where_constraints_37662
	{
		internal MainParser _N__N_closurised_this_ptr_37667;

		internal _N_closureOf_parse_where_constraints_37662()
		{
		}
	}

	private sealed class _N_closureOf_loop_37690
	{
		internal Splicable _N_tv_37695;

		internal _N_closureOf_loop_37690()
		{
		}
	}

	private sealed class _N__N_lambda__37621__37705 : Function<Nemerle.Builtins.Tuple<bool, PExpr>>
	{
		[SpecialName]
		private _N_closureOf_parse_where_constraints_37662 _N_parse_where_constraints_closure_37709;

		public _N__N_lambda__37621__37705(_N_closureOf_parse_where_constraints_37662 _N_parse_where_constraints_closure_37709)
		{
			this._N_parse_where_constraints_closure_37709 = _N_parse_where_constraints_closure_37709;
		}

		[SpecialName]
		public sealed override Nemerle.Builtins.Tuple<bool, PExpr> apply()
		{
			Token token = _N_parse_where_constraints_closure_37709._N__N_closurised_this_ptr_37667.peek_token();
			Nemerle.Builtins.Tuple<bool, PExpr> result;
			if (token is Token.Keyword)
			{
				Token.Keyword keyword = (Token.Keyword)token;
				string name;
				if (((Token.Keyword)token).name == "enum")
				{
					name = ((Token.Keyword)token).name;
				}
				else if (((Token.Keyword)token).name == "class")
				{
					keyword = (Token.Keyword)token;
					name = ((Token.Keyword)token).name;
				}
				else
				{
					if (!(((Token.Keyword)token).name == "struct"))
					{
						if (!(((Token.Keyword)token).name == "new"))
						{
							goto IL_019c;
						}
						keyword = (Token.Keyword)token;
						_N_parse_where_constraints_closure_37709._N__N_closurised_this_ptr_37667.shift();
						token = _N_parse_where_constraints_closure_37709._N__N_closurised_this_ptr_37667.get_token();
						if (!(token is Token.RoundGroup) || (object)((Token.RoundGroup)token).Child != null)
						{
							Error(token, "expected `()' after `new' in generic constraint");
						}
						result = new Nemerle.Builtins.Tuple<bool, PExpr>(field0: true, new PExpr.Ref(keyword.Location, _N_parse_where_constraints_closure_37709._N__N_closurised_this_ptr_37667.MkName("new", keyword.Location)));
						goto IL_01bf;
					}
					keyword = (Token.Keyword)token;
					name = ((Token.Keyword)token).name;
				}
				_N_parse_where_constraints_closure_37709._N__N_closurised_this_ptr_37667.shift();
				result = new Nemerle.Builtins.Tuple<bool, PExpr>(field0: true, new PExpr.Ref(keyword.Location, _N_parse_where_constraints_closure_37709._N__N_closurised_this_ptr_37667.MkName(name, keyword.Location)));
				goto IL_01bf;
			}
			goto IL_019c;
			IL_019c:
			result = new Nemerle.Builtins.Tuple<bool, PExpr>(field0: false, _N_parse_where_constraints_closure_37709._N__N_closurised_this_ptr_37667.parse_expr(TokenStoppers.Braces | TokenStoppers.Where | TokenStoppers.Equal));
			goto IL_01bf;
			IL_01bf:
			return result;
		}
	}

	private sealed class _N__N_lambda__37631__37731 : Function<Nemerle.Builtins.Tuple<bool, PExpr>, list<Constraint>, list<Constraint>>
	{
		[SpecialName]
		private _N_closureOf_loop_37690 _N_loop_closure_37735;

		public _N__N_lambda__37631__37731(_N_closureOf_loop_37690 _N_loop_closure_37735)
		{
			this._N_loop_closure_37735 = _N_loop_closure_37735;
		}

		[SpecialName]
		public sealed override list<Constraint> apply(Nemerle.Builtins.Tuple<bool, PExpr> _N__37729, list<Constraint> _N__37730)
		{
			bool field = _N__37729.Field0;
			PExpr field2 = _N__37729.Field1;
			return new list<Constraint>.Cons(new Constraint(_N_loop_closure_37735._N_tv_37695, field2, field), _N__37730);
		}
	}

	private sealed class _N_closureOf_parse_parameters_37828
	{
		internal bool _N_allow_patterns_37835;

		internal MainParser _N__N_closurised_this_ptr_37833;

		internal _N_closureOf_parse_parameters_37828()
		{
		}
	}

	private sealed class _N__N_lambda__37821__37846 : Function<PParameter>
	{
		[SpecialName]
		private _N_closureOf_parse_parameters_37828 _N_parse_parameters_closure_37850;

		public _N__N_lambda__37821__37846(_N_closureOf_parse_parameters_37828 _N_parse_parameters_closure_37850)
		{
			this._N_parse_parameters_closure_37850 = _N_parse_parameters_closure_37850;
		}

		[SpecialName]
		public sealed override PParameter apply()
		{
			return _N_parse_parameters_closure_37850._N__N_closurised_this_ptr_37833.parse_parameter(_N_parse_parameters_closure_37850._N_allow_patterns_37835);
		}
	}

	private sealed class _N_closureOf_ParseBlock_37919
	{
		internal MainParser _N__N_obj_cache_37924;

		internal _N_closureOf_ParseBlock_37919()
		{
		}
	}

	private sealed class _N__N_method_lambda__37933 : Function<MatchCase>
	{
		[SpecialName]
		private _N_closureOf_ParseBlock_37919 _N_ParseBlock_closure_37937;

		public _N__N_method_lambda__37933(_N_closureOf_ParseBlock_37919 _N_ParseBlock_closure_37937)
		{
			this._N_ParseBlock_closure_37937 = _N_ParseBlock_closure_37937;
		}

		[SpecialName]
		public sealed override MatchCase apply()
		{
			return _N_ParseBlock_closure_37937._N__N_obj_cache_37924.parse_match_case();
		}
	}

	private sealed class _N_closureOf_parse_match_case_38334
	{
		internal Location _N_arrowLocation_38341;

		internal MainParser _N__N_closurised_this_ptr_38339;

		internal _N_closureOf_parse_match_case_38334()
		{
		}
	}

	private sealed class _N_closureOf_loop2_38350
	{
		internal list<PExpr> _N_acc_38355;

		internal _N_closureOf_loop2_38350()
		{
		}
	}

	private sealed class _N__N_lambda__38324__38401 : Function<PExpr, Location, Location>
	{
		[SpecialName]
		public static readonly _N__N_lambda__38324__38401 Instance = new _N__N_lambda__38324__38401();

		[SpecialName]
		public sealed override Location apply(PExpr e, Location loc)
		{
			return loc.Combine(e.Location);
		}
	}

	private sealed class _N_closureOf_parse_embedded_expr_38602
	{
		internal MainParser _N__N_closurised_this_ptr_38611;

		internal MainParser _N__N_obj_cache_38609;

		internal MainParser _N__N_obj_cache_38607;

		internal _N_closureOf_parse_embedded_expr_38602()
		{
		}
	}

	private sealed class _N__N_method_lambda__38779 : Function<MatchCase>
	{
		[SpecialName]
		private _N_closureOf_parse_embedded_expr_38602 _N_parse_embedded_expr_closure_38783;

		public _N__N_method_lambda__38779(_N_closureOf_parse_embedded_expr_38602 _N_parse_embedded_expr_closure_38783)
		{
			this._N_parse_embedded_expr_closure_38783 = _N_parse_embedded_expr_closure_38783;
		}

		[SpecialName]
		public sealed override MatchCase apply()
		{
			return _N_parse_embedded_expr_closure_38783._N__N_obj_cache_38609.parse_match_case();
		}
	}

	private sealed class _N_mktry__38791 : Function<MatchCase, list<TryCase>, list<TryCase>>
	{
		[SpecialName]
		private _N_closureOf_parse_embedded_expr_38602 _N_parse_embedded_expr_closure_38795;

		public _N_mktry__38791(_N_closureOf_parse_embedded_expr_38602 _N_parse_embedded_expr_closure_38795)
		{
			this._N_parse_embedded_expr_closure_38795 = _N_parse_embedded_expr_closure_38795;
		}

		[SpecialName]
		public sealed override list<TryCase> apply(MatchCase h, list<TryCase> cases)
		{
			list<PExpr> patterns = h.patterns;
			object result;
			PExpr ty2;
			PExpr.Call call;
			PExpr ty;
			PExpr body;
			if (patterns is list<PExpr>.Cons)
			{
				if (((list<PExpr>.Cons)patterns).hd is PExpr.Wildcard)
				{
					PExpr.Wildcard wildcard = (PExpr.Wildcard)((list<PExpr>.Cons)patterns).hd;
					if ((object)((list<PExpr>.Cons)patterns).tl == list<PExpr>.Nil._N_constant_object)
					{
						result = new list<TryCase>.Cons(new TryCase.Catch(wildcard.Location, _N_parse_embedded_expr_closure_38795._N__N_closurised_this_ptr_38611.MkWildcardSplicableName(wildcard.Location), new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("System", _N_MacroContexts.Get(2, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Exception", _N_MacroContexts.Get(2, ManagerClass.Instance)))), h.body), cases);
						goto IL_0f78;
					}
				}
				else if (((list<PExpr>.Cons)patterns).hd is PExpr.Is)
				{
					PExpr.Is @is = (PExpr.Is)((list<PExpr>.Cons)patterns).hd;
					if (((PExpr.Is)((list<PExpr>.Cons)patterns).hd).pat is PExpr.Wildcard)
					{
						PExpr.Wildcard wildcard = (PExpr.Wildcard)((PExpr.Is)((list<PExpr>.Cons)patterns).hd).pat;
						if ((object)((list<PExpr>.Cons)patterns).tl == list<PExpr>.Nil._N_constant_object)
						{
							ty = ((PExpr.Is)((list<PExpr>.Cons)patterns).hd).ty;
							result = new list<TryCase>.Cons(new TryCase.Catch(@is.Location, _N_parse_embedded_expr_closure_38795._N__N_closurised_this_ptr_38611.MkWildcardSplicableName(wildcard.Location), ty, h.body), cases);
							goto IL_0f78;
						}
					}
					else if (((PExpr.Is)((list<PExpr>.Cons)patterns).hd).pat is PExpr.Ref)
					{
						@is = (PExpr.Is)((list<PExpr>.Cons)patterns).hd;
						if ((object)((list<PExpr>.Cons)patterns).tl == list<PExpr>.Nil._N_constant_object)
						{
							Location location = ((PExpr.Is)((list<PExpr>.Cons)patterns).hd).pat.Location;
							Name name = ((PExpr.Ref)((PExpr.Is)((list<PExpr>.Cons)patterns).hd).pat).name;
							ty = ((PExpr.Is)((list<PExpr>.Cons)patterns).hd).ty;
							result = new list<TryCase>.Cons(new TryCase.Catch(@is.Location, new Splicable.Name(location, name), ty, h.body), cases);
							goto IL_0f78;
						}
					}
					else if (((PExpr.Is)((list<PExpr>.Cons)patterns).hd).pat is PExpr.Spliced)
					{
						@is = (PExpr.Is)((list<PExpr>.Cons)patterns).hd;
						if ((object)((list<PExpr>.Cons)patterns).tl == list<PExpr>.Nil._N_constant_object)
						{
							Location location = ((PExpr.Is)((list<PExpr>.Cons)patterns).hd).pat.Location;
							body = ((PExpr.Spliced)((PExpr.Is)((list<PExpr>.Cons)patterns).hd).pat).body;
							ty = ((PExpr.Is)((list<PExpr>.Cons)patterns).hd).ty;
							result = new list<TryCase>.Cons(new TryCase.Catch(@is.Location, new Splicable.Expression(location, body, _N_parse_embedded_expr_closure_38795._N__N_closurised_this_ptr_38611.env), ty, h.body), cases);
							goto IL_0f78;
						}
					}
				}
				else if (((list<PExpr>.Cons)patterns).hd is PExpr.Ref)
				{
					PExpr.Ref @ref = (PExpr.Ref)((list<PExpr>.Cons)patterns).hd;
					if ((object)((list<PExpr>.Cons)patterns).tl == list<PExpr>.Nil._N_constant_object)
					{
						Location location = ((list<PExpr>.Cons)patterns).hd.Location;
						Name name = ((PExpr.Ref)((list<PExpr>.Cons)patterns).hd).name;
						result = new list<TryCase>.Cons(new TryCase.Catch(@ref.Location, new Splicable.Name(location, name), new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("System", _N_MacroContexts.Get(2, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Exception", _N_MacroContexts.Get(2, ManagerClass.Instance)))), h.body), cases);
						goto IL_0f78;
					}
				}
				else if (((list<PExpr>.Cons)patterns).hd is PExpr.Call)
				{
					call = (PExpr.Call)((list<PExpr>.Cons)patterns).hd;
					if (((PExpr.Call)((list<PExpr>.Cons)patterns).hd).func is PExpr.Ref && ((PExpr.Ref)((PExpr.Call)((list<PExpr>.Cons)patterns).hd).func).name.idl == "when" && ((PExpr.Call)((list<PExpr>.Cons)patterns).hd).parms is list<PExpr>.Cons)
					{
						if (((list<PExpr>.Cons)((PExpr.Call)((list<PExpr>.Cons)patterns).hd).parms).hd is PExpr.Is)
						{
							if (((list<PExpr>.Cons)((PExpr.Call)((list<PExpr>.Cons)patterns).hd).parms).tl is list<PExpr>.Cons)
							{
								ty = ((PExpr.Is)((list<PExpr>.Cons)((PExpr.Call)((list<PExpr>.Cons)patterns).hd).parms).hd).pat;
								ty2 = ((PExpr.Is)((list<PExpr>.Cons)((PExpr.Call)((list<PExpr>.Cons)patterns).hd).parms).hd).ty;
								if ((object)((list<PExpr>.Cons)((list<PExpr>.Cons)((PExpr.Call)((list<PExpr>.Cons)patterns).hd).parms).tl).tl == list<PExpr>.Nil._N_constant_object)
								{
									body = ((list<PExpr>.Cons)((list<PExpr>.Cons)((PExpr.Call)((list<PExpr>.Cons)patterns).hd).parms).tl).hd;
									if ((object)((list<PExpr>.Cons)patterns).tl == list<PExpr>.Nil._N_constant_object)
									{
										if (ty is PExpr.Wildcard)
										{
											if (true)
											{
												goto IL_05d0;
											}
										}
										else if (false)
										{
											goto IL_05d0;
										}
										if (((PExpr.Is)((list<PExpr>.Cons)((PExpr.Call)((list<PExpr>.Cons)patterns).hd).parms).hd).pat is PExpr.Ref)
										{
											call = (PExpr.Call)((list<PExpr>.Cons)patterns).hd;
											Location location = ((PExpr.Is)((list<PExpr>.Cons)((PExpr.Call)((list<PExpr>.Cons)patterns).hd).parms).hd).pat.Location;
											Name name = ((PExpr.Ref)((PExpr.Is)((list<PExpr>.Cons)((PExpr.Call)((list<PExpr>.Cons)patterns).hd).parms).hd).pat).name;
											body = ((PExpr.Is)((list<PExpr>.Cons)((PExpr.Call)((list<PExpr>.Cons)patterns).hd).parms).hd).ty;
											ty = ((list<PExpr>.Cons)((list<PExpr>.Cons)((PExpr.Call)((list<PExpr>.Cons)patterns).hd).parms).tl).hd;
											result = new list<TryCase>.Cons(new TryCase.Filter(call.Location, new Splicable.Name(location, name), body, ty, h.body), cases);
										}
										else
										{
											call = (PExpr.Call)((list<PExpr>.Cons)patterns).hd;
											ty = ((list<PExpr>.Cons)((PExpr.Call)((list<PExpr>.Cons)patterns).hd).parms).hd;
											body = ((list<PExpr>.Cons)((list<PExpr>.Cons)((PExpr.Call)((list<PExpr>.Cons)patterns).hd).parms).tl).hd;
											if (ty is PExpr.Wildcard)
											{
												if (true)
												{
													goto IL_07a8;
												}
											}
											else if (false)
											{
												goto IL_07a8;
											}
											if (!(((PExpr.Is)((list<PExpr>.Cons)((PExpr.Call)((list<PExpr>.Cons)patterns).hd).parms).hd).pat is PExpr.Spliced))
											{
												goto IL_0f5b;
											}
											call = (PExpr.Call)((list<PExpr>.Cons)patterns).hd;
											Location location = ((PExpr.Is)((list<PExpr>.Cons)((PExpr.Call)((list<PExpr>.Cons)patterns).hd).parms).hd).pat.Location;
											ty = ((PExpr.Spliced)((PExpr.Is)((list<PExpr>.Cons)((PExpr.Call)((list<PExpr>.Cons)patterns).hd).parms).hd).pat).body;
											body = ((PExpr.Is)((list<PExpr>.Cons)((PExpr.Call)((list<PExpr>.Cons)patterns).hd).parms).hd).ty;
											ty2 = ((list<PExpr>.Cons)((list<PExpr>.Cons)((PExpr.Call)((list<PExpr>.Cons)patterns).hd).parms).tl).hd;
											result = new list<TryCase>.Cons(new TryCase.Filter(call.Location, new Splicable.Expression(location, ty, _N_parse_embedded_expr_closure_38795._N__N_closurised_this_ptr_38611.env), body, ty2, h.body), cases);
										}
										goto IL_0f78;
									}
								}
							}
							if (!(((PExpr.Is)((list<PExpr>.Cons)((PExpr.Call)((list<PExpr>.Cons)patterns).hd).parms).hd).pat is PExpr.Ref) && !(((PExpr.Is)((list<PExpr>.Cons)((PExpr.Call)((list<PExpr>.Cons)patterns).hd).parms).hd).pat is PExpr.Spliced))
							{
							}
						}
						else if (((list<PExpr>.Cons)((PExpr.Call)((list<PExpr>.Cons)patterns).hd).parms).hd is PExpr.Ref)
						{
							call = (PExpr.Call)((list<PExpr>.Cons)patterns).hd;
							if (((list<PExpr>.Cons)((PExpr.Call)((list<PExpr>.Cons)patterns).hd).parms).tl is list<PExpr>.Cons)
							{
								Location location = ((list<PExpr>.Cons)((PExpr.Call)((list<PExpr>.Cons)patterns).hd).parms).hd.Location;
								Name name = ((PExpr.Ref)((list<PExpr>.Cons)((PExpr.Call)((list<PExpr>.Cons)patterns).hd).parms).hd).name;
								if ((object)((list<PExpr>.Cons)((list<PExpr>.Cons)((PExpr.Call)((list<PExpr>.Cons)patterns).hd).parms).tl).tl == list<PExpr>.Nil._N_constant_object)
								{
									ty = ((list<PExpr>.Cons)((list<PExpr>.Cons)((PExpr.Call)((list<PExpr>.Cons)patterns).hd).parms).tl).hd;
									if ((object)((list<PExpr>.Cons)patterns).tl == list<PExpr>.Nil._N_constant_object)
									{
										result = new list<TryCase>.Cons(new TryCase.Filter(call.Location, new Splicable.Name(location, name), new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("System", _N_MacroContexts.Get(2, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Exception", _N_MacroContexts.Get(2, ManagerClass.Instance)))), ty, h.body), cases);
										goto IL_0f78;
									}
								}
							}
						}
						else if (((list<PExpr>.Cons)((PExpr.Call)((list<PExpr>.Cons)patterns).hd).parms).tl is list<PExpr>.Cons)
						{
							call = (PExpr.Call)((list<PExpr>.Cons)patterns).hd;
							ty = ((list<PExpr>.Cons)((PExpr.Call)((list<PExpr>.Cons)patterns).hd).parms).hd;
							if ((object)((list<PExpr>.Cons)((list<PExpr>.Cons)((PExpr.Call)((list<PExpr>.Cons)patterns).hd).parms).tl).tl == list<PExpr>.Nil._N_constant_object)
							{
								body = ((list<PExpr>.Cons)((list<PExpr>.Cons)((PExpr.Call)((list<PExpr>.Cons)patterns).hd).parms).tl).hd;
								if ((object)((list<PExpr>.Cons)patterns).tl == list<PExpr>.Nil._N_constant_object)
								{
									if (ty is PExpr.Wildcard)
									{
										if (true)
										{
											goto IL_07a8;
										}
									}
									else if (false)
									{
										goto IL_07a8;
									}
								}
							}
						}
					}
				}
				else if (((list<PExpr>.Cons)patterns).hd is PExpr.TypeEnforcement)
				{
					PExpr.TypeEnforcement typeEnforcement = (PExpr.TypeEnforcement)((list<PExpr>.Cons)patterns).hd;
					if (((PExpr.TypeEnforcement)((list<PExpr>.Cons)patterns).hd).expr is PExpr.Wildcard)
					{
						PExpr.Wildcard wildcard = (PExpr.Wildcard)((PExpr.TypeEnforcement)((list<PExpr>.Cons)patterns).hd).expr;
						if ((object)((list<PExpr>.Cons)patterns).tl == list<PExpr>.Nil._N_constant_object)
						{
							ty = ((PExpr.TypeEnforcement)((list<PExpr>.Cons)patterns).hd).ty;
							Message.Warning(602, wildcard.Location, "using ``:'' as a type tests is deprecated, please use ``is'' instead");
							result = new list<TryCase>.Cons(new TryCase.Catch(typeEnforcement.Location, _N_parse_embedded_expr_closure_38795._N__N_closurised_this_ptr_38611.MkWildcardSplicableName(wildcard.Location), ty, h.body), cases);
							goto IL_0f78;
						}
					}
					else if (((PExpr.TypeEnforcement)((list<PExpr>.Cons)patterns).hd).expr is PExpr.Ref)
					{
						typeEnforcement = (PExpr.TypeEnforcement)((list<PExpr>.Cons)patterns).hd;
						if ((object)((list<PExpr>.Cons)patterns).tl == list<PExpr>.Nil._N_constant_object)
						{
							Location location = ((PExpr.TypeEnforcement)((list<PExpr>.Cons)patterns).hd).expr.Location;
							Name name = ((PExpr.Ref)((PExpr.TypeEnforcement)((list<PExpr>.Cons)patterns).hd).expr).name;
							ty = ((PExpr.TypeEnforcement)((list<PExpr>.Cons)patterns).hd).ty;
							Message.Warning(602, location, "using ``:'' as a type tests is deprecated, please use ``is'' instead");
							result = new list<TryCase>.Cons(new TryCase.Catch(typeEnforcement.Location, new Splicable.Name(location, name), ty, h.body), cases);
							goto IL_0f78;
						}
					}
					else if (((PExpr.TypeEnforcement)((list<PExpr>.Cons)patterns).hd).expr is PExpr.Spliced)
					{
						typeEnforcement = (PExpr.TypeEnforcement)((list<PExpr>.Cons)patterns).hd;
						if ((object)((list<PExpr>.Cons)patterns).tl == list<PExpr>.Nil._N_constant_object)
						{
							Location location = ((PExpr.TypeEnforcement)((list<PExpr>.Cons)patterns).hd).expr.Location;
							ty = ((PExpr.Spliced)((PExpr.TypeEnforcement)((list<PExpr>.Cons)patterns).hd).expr).body;
							body = ((PExpr.TypeEnforcement)((list<PExpr>.Cons)patterns).hd).ty;
							Message.Warning(602, location, "using ``:'' as a type tests is deprecated, please use ``is'' instead");
							result = new list<TryCase>.Cons(new TryCase.Catch(typeEnforcement.Location, new Splicable.Expression(ty, _N_parse_embedded_expr_closure_38795._N__N_closurised_this_ptr_38611.env), body, h.body), cases);
							goto IL_0f78;
						}
					}
				}
			}
			goto IL_0f5b;
			IL_05d0:
			result = new list<TryCase>.Cons(new TryCase.Filter(call.Location, _N_parse_embedded_expr_closure_38795._N__N_closurised_this_ptr_38611.MkWildcardSplicableName(ty.Location), ty2, body, h.body), cases);
			goto IL_0f78;
			IL_0f78:
			return (list<TryCase>)result;
			IL_0f5b:
			Message.Error(h.body.Location, "exception catch pattern must be in form of `| e is ExceptionType => handler' or`| e => handler' for System.Exception");
			result = cases;
			goto IL_0f78;
			IL_07a8:
			result = new list<TryCase>.Cons(new TryCase.Filter(call.Location, _N_parse_embedded_expr_closure_38795._N__N_closurised_this_ptr_38611.MkWildcardSplicableName(ty.Location), new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("System", _N_MacroContexts.Get(2, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Exception", _N_MacroContexts.Get(2, ManagerClass.Instance)))), body, h.body), cases);
			goto IL_0f78;
		}
	}

	private sealed class _N__N_method_lambda__38850 : Function<MatchCase>
	{
		[SpecialName]
		private _N_closureOf_parse_embedded_expr_38602 _N_parse_embedded_expr_closure_38854;

		public _N__N_method_lambda__38850(_N_closureOf_parse_embedded_expr_38602 _N_parse_embedded_expr_closure_38854)
		{
			this._N_parse_embedded_expr_closure_38854 = _N_parse_embedded_expr_closure_38854;
		}

		[SpecialName]
		public sealed override MatchCase apply()
		{
			return _N_parse_embedded_expr_closure_38854._N__N_obj_cache_38607.parse_match_case();
		}
	}

	private sealed class _N_closureOf_parse_quotation_38964
	{
		internal Token.LooseGroup _N_group_38973;

		internal MainParser _N__N_closurised_this_ptr_38971;

		internal MainParser _N__N_obj_cache_38969;

		internal _N_closureOf_parse_quotation_38964()
		{
		}
	}

	private sealed class _N__N_lambda__38945__39008 : Function<Function_decl>
	{
		[SpecialName]
		private _N_closureOf_parse_quotation_38964 _N_parse_quotation_closure_39012;

		public _N__N_lambda__38945__39008(_N_closureOf_parse_quotation_38964 _N_parse_quotation_closure_39012)
		{
			this._N_parse_quotation_closure_39012 = _N_parse_quotation_closure_39012;
		}

		[SpecialName]
		public sealed override Function_decl apply()
		{
			PFunHeader pFunHeader = _N_parse_quotation_closure_39012._N__N_closurised_this_ptr_38971.parse_fun_header(null);
			return new Function_decl(pFunHeader, _N_parse_quotation_closure_39012._N__N_closurised_this_ptr_38971.parse_block(pFunHeader.Parameters));
		}
	}

	private sealed class _N__N_method_lambda__39017 : Function<PParameter>
	{
		[SpecialName]
		private _N_closureOf_parse_quotation_38964 _N_parse_quotation_closure_39021;

		public _N__N_method_lambda__39017(_N_closureOf_parse_quotation_38964 _N_parse_quotation_closure_39021)
		{
			this._N_parse_quotation_closure_39021 = _N_parse_quotation_closure_39021;
		}

		[SpecialName]
		public sealed override PParameter apply()
		{
			return _N_parse_quotation_closure_39021._N__N_obj_cache_38969.parse_parameter();
		}
	}

	private sealed class _N_closureOf_parse_expr_sequence_39101
	{
		internal _N_closureOf_parse_expr_sequence_39101()
		{
		}
	}

	private sealed class _N_closureOf_makeStrsConcat_39126
	{
		internal Token _N_tok_39137;

		internal bool _N_prevDollarised_39135;

		internal Token.StringLiteral _N_litTok_39133;

		internal bool _N_isDollarised_39131;

		internal _N_closureOf_makeStrsConcat_39126()
		{
		}
	}

	private GlobalEnv env;

	private bool in_variant;

	private Token stream;

	private Token last_tok;

	private Nemerle.Collections.Stack<Token> streams_stack = new Nemerle.Collections.Stack<Token>(20);

	public readonly ManagerClass Manager;

	public InternalTypeClass InternalType => Manager.InternalType;

	public SystemTypeClass SystemTypeCache => Manager.SystemTypeCache;

	internal static Map<string, GrammarElement> load_syntax(list<SyntaxDefinition> extensions, Map<string, GrammarElement> keywords)
	{
		list<SyntaxDefinition> list = extensions;
		while (list is list<SyntaxDefinition>.Cons)
		{
			SyntaxDefinition hd = ((list<SyntaxDefinition>.Cons)list).hd;
			list = ((list<SyntaxDefinition>.Cons)list).tl;
			hd = hd;
			if (!(hd is OperatorDefinition) && 0 == 0)
			{
				string start = hd.Start;
				option<GrammarElement> option = keywords.Find(start);
				Map<string, GrammarElement> map;
				if (option is option<GrammarElement>.Some)
				{
					GrammarElement val = ((option<GrammarElement>.Some)option).val;
					map = keywords.Replace(start, MergeSyntax(hd.Tree, val, hd));
				}
				else
				{
					map = keywords.Add(start, MergeSyntax(hd.Tree, null, hd));
				}
				keywords = map;
			}
			list = list;
		}
		return keywords;
	}

	[Macro("Nemerle.Assertions.Requires:method:postscan", 0, "ext != null")]
	internal static GrammarElement MergeSyntax(GrammarElement s1, GrammarElement s2, SyntaxDefinition ext)
	{
		if (ext == null)
		{
			throw new AssertionException("ncc\\parsing\\MainParser-Extensions.n", 180, "ext != null", "The ``Requires'' contract of method `MergeSyntax' has been violated.".ToString());
		}
		object result;
		GrammarElement other;
		if (s1 == null)
		{
			NamespaceTree.TypeInfoCache value = ext.MacroNamespace.Value;
			if (!(value is NamespaceTree.TypeInfoCache.MacroCall))
			{
				if (!Message.SeenError)
				{
					string text = "no macro".ToString();
					Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
				}
				throw new AssertionException("ncc\\parsing\\MainParser-Extensions.n", 195, "", "no macro");
			}
			IMacro m = ((NamespaceTree.TypeInfoCache.MacroCall)value).m;
			AttributeTargets target = ((m.Usage != null) ? m.Usage.ValidOn : ((AttributeTargets)32768));
			GrammarElement.End end = new GrammarElement.End(null, target, ext);
			result = ((s2 == null) ? end : s2.AddBranch(end));
		}
		else if (s2 == null)
		{
			other = MergeSyntax(s1.Next, null, ext);
			if (s1 is GrammarElement.Optional)
			{
				GrammarElement body = ((GrammarElement.Optional)s1).body;
				body = MergeSyntax(body, null, ext);
				result = new GrammarElement.Optional(body).CloneWithNext(other);
			}
			else
			{
				result = s1.CloneWithNext(other);
			}
		}
		else
		{
			if (s1 is GrammarElement.Operator)
			{
				if (s2 is GrammarElement.Operator)
				{
					string text = ((GrammarElement.Operator)s1).name;
					string name = ((GrammarElement.Operator)s2).name;
					if (text == name)
					{
						goto IL_026e;
					}
				}
			}
			else if (s1 is GrammarElement.Keyword)
			{
				if (s2 is GrammarElement.Keyword)
				{
					string text = ((GrammarElement.Keyword)s1).name;
					string name = ((GrammarElement.Keyword)s2).name;
					if (text == name)
					{
						goto IL_026e;
					}
				}
			}
			else if (s1 is GrammarElement.Expression)
			{
				if (s2 is GrammarElement.Expression)
				{
					goto IL_026e;
				}
			}
			else if (s1 is GrammarElement.Parameter)
			{
				if (s2 is GrammarElement.Parameter)
				{
					goto IL_026e;
				}
			}
			else if (s1 is GrammarElement.RawToken)
			{
				if (s2 is GrammarElement.RawToken)
				{
					goto IL_026e;
				}
			}
			else if (s1 is GrammarElement.ExpressionList)
			{
				if (s2 is GrammarElement.ExpressionList)
				{
					goto IL_026e;
				}
			}
			else if (s1 is GrammarElement.Optional && s2 is GrammarElement.Optional)
			{
				GrammarElement body = ((GrammarElement.Optional)s1).body;
				other = ((GrammarElement.Optional)s2).body;
				if (body.Equals(other))
				{
					GrammarElement other2 = MergeSyntax(s1.Next, s2.Next, ext);
					other = MergeSyntax(body, other, ext);
					result = new GrammarElement.Optional(other).CloneWithNext(other2);
					goto IL_0369;
				}
			}
			if (s1.Equals(s2))
			{
				throw new AssertionException("ncc\\parsing\\MainParser-Extensions.n", 226, "!s1.Equals(s2)", "");
			}
			other = MergeSyntax(s1.Next, null, ext);
			other = s1.CloneWithNext(other);
			result = s2.AddBranch(other);
		}
		goto IL_0369;
		IL_026e:
		other = MergeSyntax(s1.Next, s2.Next, ext);
		result = s1.CloneWithNext(other);
		goto IL_0369;
		IL_0369:
		return (GrammarElement)result;
	}

	private void parse_top_extensions(AttributesAndModifiers modifiers, AttributeTargets target)
	{
		_N_closureOf_parse_top_extensions_35169 n_closureOf_parse_top_extensions_ = new _N_closureOf_parse_top_extensions_35169();
		n_closureOf_parse_top_extensions_._N_modifiers_35176 = modifiers;
		n_closureOf_parse_top_extensions_._N__N_closurised_this_ptr_35174 = this;
		while (true)
		{
			Token token = peek_token();
			if (!(token is Token.Keyword))
			{
				break;
			}
			n_closureOf_parse_top_extensions_._N_tok_35180 = (Token.Keyword)token;
			string name = ((Token.Keyword)token).name;
			option<GrammarElement> option = env.SyntaxKeywords.Find(name);
			if (!(option is option<GrammarElement>.Some))
			{
				break;
			}
			GrammarElement val = ((option<GrammarElement>.Some)option).val;
			if ((val.Target & target) == 0)
			{
				break;
			}
			shift();
			Nemerle.Builtins.Tuple<GrammarElement, list<SyntaxElement>> tuple = parse_grammar_rule(val, TokenStoppers.None, target);
			val = tuple.Field0;
			n_closureOf_parse_top_extensions_._N_parms_35178 = tuple.Field1;
			if (val is GrammarElement.End)
			{
				SyntaxDefinition define = ((GrammarElement.End)val).define;
				_N_eat_definition_35198(n_closureOf_parse_top_extensions_, define);
				continue;
			}
			if (val is GrammarElement.Branch)
			{
				list<GrammarElement> list = ((GrammarElement.Branch)val).options;
				list = list;
				while (list is list<GrammarElement>.Cons)
				{
					val = ((list<GrammarElement>.Cons)list).hd;
					list = ((list<GrammarElement>.Cons)list).tl;
					if (val is GrammarElement.End)
					{
						SyntaxDefinition define = ((GrammarElement.End)val).define;
						if ((((GrammarElement.End)val).Target & target) != 0)
						{
							_N_eat_definition_35198(n_closureOf_parse_top_extensions_, define);
						}
					}
					list = list;
				}
				continue;
			}
			Message.Error(n_closureOf_parse_top_extensions_._N_tok_35180.Location, "unable to parse syntax rule, stopped at: " + Convert.ToString(val));
			throw new Recovery();
		}
	}

	private PExpr parse_syntax_definition(GrammarElement tree, TokenStoppers stop)
	{
		string id = last_tok.ToString();
		Location location = last_tok.Location;
		Nemerle.Builtins.Tuple<GrammarElement, list<SyntaxElement>> tuple = parse_grammar_rule(tree, stop, (AttributeTargets)32768);
		GrammarElement field = tuple.Field0;
		list<SyntaxElement> list = tuple.Field1;
		object result;
		if (field is GrammarElement.End)
		{
			SyntaxDefinition define = ((GrammarElement.End)field).define;
			Location location2 = location.Combine(last_tok.Location);
			Location acc = location2;
			Function<SyntaxElement, Location, Location> instance = _N__N_lambda__35227__35243.Instance;
			location2 = list.FoldLeft(acc, instance);
			result = new PExpr.MacroCall(location2, MkName(id, location), define.MacroNamespace, define.Permute.apply(list));
		}
		else
		{
			result = fatal_error(location, "unable to parse syntax rule, stopped at: " + field.ToString());
		}
		return (PExpr)result;
	}

	private bool matches_stream(GrammarElement tree)
	{
		int result;
		while (true)
		{
			Token token = peek_sibling_token();
			if (tree is GrammarElement.Operator)
			{
				string name = ((GrammarElement.Operator)tree).name;
				switch (name)
				{
				case "]":
				case ")":
					result = ((token is Token.EndOfGroup) ? 1 : 0);
					break;
				case ";":
					result = ((token is Token.Semicolon) ? 1 : 0);
					break;
				case "(":
					result = ((token is Token.RoundGroup) ? 1 : 0);
					break;
				case "[":
					result = ((token is Token.SquareGroup) ? 1 : 0);
					break;
				default:
					if (token is Token.Operator)
					{
						string name2 = ((Token.Operator)token).name;
						if (name2 == name)
						{
							result = 1;
							break;
						}
					}
					result = 0;
					break;
				}
				break;
			}
			if (tree is GrammarElement.Keyword)
			{
				string name2 = ((GrammarElement.Keyword)tree).name;
				if (token is Token.Keyword)
				{
					string name = ((Token.Keyword)token).name;
					if (name == name2)
					{
						result = 1;
						break;
					}
				}
				result = 0;
				break;
			}
			if (tree is GrammarElement.Expression)
			{
				result = ((stream != null) ? 1 : 0);
				break;
			}
			if (tree is GrammarElement.Optional)
			{
				GrammarElement body = ((GrammarElement.Optional)tree).body;
				if (matches_stream(body))
				{
					result = 1;
					break;
				}
				tree = tree.Next;
				continue;
			}
			if (tree is GrammarElement.End)
			{
				if (token is Token.EndOfGroup)
				{
					if (true)
					{
						goto IL_01cd;
					}
				}
				else if (false)
				{
					goto IL_01cd;
				}
				result = ((stream == null) ? 1 : 0);
			}
			else
			{
				result = 0;
			}
			break;
			IL_01cd:
			result = 1;
			break;
		}
		return (byte)result != 0;
	}

	private static list<SyntaxElement> create_optional_holders(GrammarElement tre, list<SyntaxElement> acc)
	{
		while (tre != null)
		{
			if (tre is GrammarElement.Expression)
			{
				acc = new list<SyntaxElement>.Cons(new SyntaxElement.Expression(null), acc);
			}
			else if (tre is GrammarElement.Parameter)
			{
				acc = new list<SyntaxElement>.Cons(new SyntaxElement.Parameter(null), acc);
			}
			tre = tre.Next;
		}
		return acc;
	}

	private Nemerle.Builtins.Tuple<GrammarElement, list<SyntaxElement>> parse_grammar_rule(GrammarElement tree, TokenStoppers stop, AttributeTargets target)
	{
		_N_closureOf_parse_grammar_rule_35374 n_closureOf_parse_grammar_rule_ = new _N_closureOf_parse_grammar_rule_35374();
		n_closureOf_parse_grammar_rule_._N_stop_35383 = stop;
		n_closureOf_parse_grammar_rule_._N_target_35381 = target;
		n_closureOf_parse_grammar_rule_._N__N_closurised_this_ptr_35379 = this;
		return _N_loop_35401(n_closureOf_parse_grammar_rule_, list<SyntaxElement>.Nil._N_constant_object, tree);
	}

	public MainParser(GlobalEnv env)
	{
		this.env = env;
		Manager = env.Manager;
	}

	public static PExpr ParseExpr([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] GlobalEnv env, [Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] string expr, bool allow_empty = false)
	{
		if (expr == null)
		{
			throw new ArgumentNullException("expr", "The ``NotNull'' contract of parameter ``expr'' has been violated. See ncc\\parsing\\MainParser.n:141:40:141:44: .");
		}
		if (env == null)
		{
			throw new ArgumentNullException("env", "The ``NotNull'' contract of parameter ``env'' has been violated. See ncc\\parsing\\MainParser.n:140:40:140:43: .");
		}
		return ParseExpr(env, expr, LocationStack.Top(), allow_empty);
	}

	public static PExpr ParseExpr([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] GlobalEnv env, [Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] string expr, Location startLocation, bool allow_empty = false)
	{
		if (expr == null)
		{
			throw new ArgumentNullException("expr", "The ``NotNull'' contract of parameter ``expr'' has been violated. See ncc\\parsing\\MainParser.n:148:40:148:44: .");
		}
		if (env == null)
		{
			throw new ArgumentNullException("env", "The ``NotNull'' contract of parameter ``env'' has been violated. See ncc\\parsing\\MainParser.n:147:40:147:43: .");
		}
		ManagerClass manager = env.Manager;
		int completionMarkLine = manager.CompletionMarkLine;
		int completionMarkChar = manager.CompletionMarkChar;
		string code = expr + " ";
		LexerString lexer = ((!manager.IsCompletionInProgress || !startLocation.Contains(completionMarkLine, completionMarkChar)) ? new LexerString(env.Manager, code, startLocation) : new LexerCompletion(env.Manager, code, startLocation, completionMarkLine, completionMarkChar));
		return ParseExpr(env, lexer, allow_empty);
	}

	public static list<PExpr> ParseCommaSeparatedExprList([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] GlobalEnv env, [Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] LexerBase lexer, bool allowEmpty = false)
	{
		_N_closureOf_ParseCommaSeparatedExprList_35562 n_closureOf_ParseCommaSeparatedExprList_ = new _N_closureOf_ParseCommaSeparatedExprList_35562();
		if (lexer == null)
		{
			throw new ArgumentNullException("lexer", "The ``NotNull'' contract of parameter ``lexer'' has been violated. See ncc\\parsing\\MainParser.n:165:17:165:22: .");
		}
		if (env == null)
		{
			throw new ArgumentNullException("env", "The ``NotNull'' contract of parameter ``env'' has been violated. See ncc\\parsing\\MainParser.n:164:17:164:20: .");
		}
		PreParser preParser = new PreParser(lexer, env);
		Token.BracesGroup bracesGroup = preParser.PreParse();
		n_closureOf_ParseCommaSeparatedExprList_._N_parser_35567 = new MainParser(env);
		object result;
		if (bracesGroup.Child == null)
		{
			if (!allowEmpty)
			{
				Message.Error(Location.Default, "expression without content is not allowed here");
				throw new Recovery();
			}
			result = list<PExpr>.Nil._N_constant_object;
		}
		else
		{
			if (bracesGroup.Child.Next == null)
			{
				n_closureOf_ParseCommaSeparatedExprList_._N_parser_35567.push_stream(((Token.LooseGroup)bracesGroup.Child).Child);
			}
			else
			{
				n_closureOf_ParseCommaSeparatedExprList_._N_parser_35567.push_stream(bracesGroup);
			}
			MainParser n_parser_ = n_closureOf_ParseCommaSeparatedExprList_._N_parser_35567;
			Function<PExpr> f = new _N__N_lambda__35556__35584(n_closureOf_ParseCommaSeparatedExprList_);
			list<PExpr> list = n_parser_.comma_separated_list(f);
			result = list;
		}
		return (list<PExpr>)result;
	}

	public static PExpr ParseExpr([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] GlobalEnv env, [Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] LexerBase lexer, bool allow_empty = false)
	{
		if (lexer == null)
		{
			throw new ArgumentNullException("lexer", "The ``NotNull'' contract of parameter ``lexer'' has been violated. See ncc\\parsing\\MainParser.n:196:40:196:45: .");
		}
		if (env == null)
		{
			throw new ArgumentNullException("env", "The ``NotNull'' contract of parameter ``env'' has been violated. See ncc\\parsing\\MainParser.n:195:40:195:43: .");
		}
		PreParser preParser = new PreParser(lexer, env);
		Token.BracesGroup bracesGroup = preParser.PreParse();
		MainParser mainParser = new MainParser(env);
		object result;
		if (bracesGroup.Child == null)
		{
			if (!allow_empty)
			{
				Message.Error(Location.Default, "expression without content is not allowed here");
				throw new Recovery();
			}
			result = null;
		}
		else
		{
			if (bracesGroup.Child.Next == null)
			{
				mainParser.push_stream(((Token.LooseGroup)bracesGroup.Child).Child);
			}
			else
			{
				mainParser.push_stream(bracesGroup);
			}
			PExpr pExpr = mainParser.parse_expr(TokenStoppers.None);
			Token token = mainParser.peek_token();
			Token token2 = mainParser.peek_token();
			if (!(token2 is Token.EndOfGroup))
			{
				Message.Error(token.Location, "expected token '" + Convert.ToString(token) + "'");
			}
			result = pExpr;
		}
		return (PExpr)result;
	}

	public static Nemerle.Builtins.Tuple<PExpr, Token> ParseExpr([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] GlobalEnv env, [Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] Token tokens)
	{
		if (tokens == null)
		{
			throw new ArgumentNullException("tokens", "The ``NotNull'' contract of parameter ``tokens'' has been violated. See ncc\\parsing\\MainParser.n:223:40:223:46: .");
		}
		if (env == null)
		{
			throw new ArgumentNullException("env", "The ``NotNull'' contract of parameter ``env'' has been violated. See ncc\\parsing\\MainParser.n:222:40:222:43: .");
		}
		return ParseExpr(env, tokens, TokenStoppers.All);
	}

	public static Nemerle.Builtins.Tuple<PExpr, Token> ParseExpr([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] GlobalEnv env, [Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] Token tokens, TokenStoppers stoppers)
	{
		if (tokens == null)
		{
			throw new ArgumentNullException("tokens", "The ``NotNull'' contract of parameter ``tokens'' has been violated. See ncc\\parsing\\MainParser.n:229:40:229:46: .");
		}
		if (env == null)
		{
			throw new ArgumentNullException("env", "The ``NotNull'' contract of parameter ``env'' has been violated. See ncc\\parsing\\MainParser.n:228:40:228:43: .");
		}
		MainParser mainParser = new MainParser(env);
		if (tokens.Next == null)
		{
			mainParser.push_stream(((Token.LooseGroup)tokens).Child);
		}
		else
		{
			mainParser.push_stream(tokens);
		}
		return new Nemerle.Builtins.Tuple<PExpr, Token>(mainParser.parse_expr(stoppers), mainParser.stream);
	}

	public Nemerle.Builtins.Tuple<PExpr, Token> ParseExpr([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] Token tokens, TokenStoppers stoppers)
	{
		if (tokens == null)
		{
			throw new ArgumentNullException("tokens", "The ``NotNull'' contract of parameter ``tokens'' has been violated. See ncc\\parsing\\MainParser.n:242:32:242:38: .");
		}
		if (tokens.Next == null)
		{
			if (tokens is Token.LooseGroup)
			{
				goto IL_0042;
			}
		}
		else if (false)
		{
			goto IL_0042;
		}
		push_stream(tokens);
		goto IL_005f;
		IL_0042:
		push_stream(((Token.LooseGroup)tokens).Child);
		goto IL_005f;
		IL_005f:
		return new Nemerle.Builtins.Tuple<PExpr, Token>(parse_expr(stoppers), stream);
	}

	public static List<ClassMember> ParseMember([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] GlobalEnv env, [Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] LexerBase lexer, string parentType)
	{
		if (lexer == null)
		{
			throw new ArgumentNullException("lexer", "The ``NotNull'' contract of parameter ``lexer'' has been violated. See ncc\\parsing\\MainParser.n:253:41:253:46: .");
		}
		if (env == null)
		{
			throw new ArgumentNullException("env", "The ``NotNull'' contract of parameter ``env'' has been violated. See ncc\\parsing\\MainParser.n:252:41:252:44: .");
		}
		PreParser preParser = new PreParser(lexer, env);
		Token.BracesGroup bracesGroup = preParser.PreParse();
		MainParser mainParser = new MainParser(env);
		object result;
		if (bracesGroup.Child == null)
		{
			result = null;
		}
		else
		{
			mainParser.push_stream((Token.LooseGroup)bracesGroup.Child);
			List<ClassMember> list = new List<ClassMember>(4);
			mainParser.ParseClassMember(parentType, list);
			result = list;
		}
		return (List<ClassMember>)result;
	}

	public static PExpr ParseExpr([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] GlobalEnv env, [Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] LexerBase lexer, [Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] PFunHeader funHeader)
	{
		if (funHeader == null)
		{
			throw new ArgumentNullException("funHeader", "The ``NotNull'' contract of parameter ``funHeader'' has been violated. See ncc\\parsing\\MainParser.n:277:17:277:26: .");
		}
		if (lexer == null)
		{
			throw new ArgumentNullException("lexer", "The ``NotNull'' contract of parameter ``lexer'' has been violated. See ncc\\parsing\\MainParser.n:276:17:276:22: .");
		}
		if (env == null)
		{
			throw new ArgumentNullException("env", "The ``NotNull'' contract of parameter ``env'' has been violated. See ncc\\parsing\\MainParser.n:275:17:275:20: .");
		}
		PreParser preParser = new PreParser(lexer, env);
		Token.BracesGroup tokens = preParser.PreParse();
		return ParseFunctionBody(env, funHeader, tokens);
	}

	public static PExpr ParseFunctionBody([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] GlobalEnv env, [Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] PFunHeader funHeader, [Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] Token.BracesGroup tokens)
	{
		if (tokens == null)
		{
			throw new ArgumentNullException("tokens", "The ``NotNull'' contract of parameter ``tokens'' has been violated. See ncc\\parsing\\MainParser.n:288:17:288:23: .");
		}
		if (funHeader == null)
		{
			throw new ArgumentNullException("funHeader", "The ``NotNull'' contract of parameter ``funHeader'' has been violated. See ncc\\parsing\\MainParser.n:287:17:287:26: .");
		}
		if (env == null)
		{
			throw new ArgumentNullException("env", "The ``NotNull'' contract of parameter ``env'' has been violated. See ncc\\parsing\\MainParser.n:286:17:286:20: .");
		}
		MainParser mainParser = new MainParser(env);
		Token.BracesGroup bracesGroup2;
		Token.BracesGroup bracesGroup;
		if (tokens.Child is Token.LooseGroup && ((Token.LooseGroup)tokens.Child).Child is Token.BracesGroup)
		{
			bracesGroup = (Token.BracesGroup)((Token.LooseGroup)tokens.Child).Child;
			bracesGroup2 = bracesGroup;
		}
		else
		{
			bracesGroup2 = tokens;
		}
		bracesGroup = bracesGroup2;
		return mainParser.ParseBlock(bracesGroup, funHeader.Parameters);
	}

	public static list<PParameter> ParseFunParms([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] GlobalEnv env, [Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] Token.RoundGroup round_group)
	{
		if (round_group == null)
		{
			throw new ArgumentNullException("round_group", "The ``NotNull'' contract of parameter ``round_group'' has been violated. See ncc\\parsing\\MainParser.n:304:19:304:30: .");
		}
		if (env == null)
		{
			throw new ArgumentNullException("env", "The ``NotNull'' contract of parameter ``env'' has been violated. See ncc\\parsing\\MainParser.n:303:19:303:22: .");
		}
		MainParser mainParser = new MainParser(env);
		mainParser.push_stream(round_group);
		return mainParser.parse_parameters().Field0;
	}

	public static Nemerle.Builtins.Tuple<list<PExpr>, PExpr, Location> ParseTyVars([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] GlobalEnv env, [Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] Token sqr_group)
	{
		if (sqr_group == null)
		{
			throw new ArgumentNullException("sqr_group", "The ``NotNull'' contract of parameter ``sqr_group'' has been violated. See ncc\\parsing\\MainParser.n:315:19:315:28: .");
		}
		if (env == null)
		{
			throw new ArgumentNullException("env", "The ``NotNull'' contract of parameter ``env'' has been violated. See ncc\\parsing\\MainParser.n:314:19:314:22: .");
		}
		MainParser mainParser = new MainParser(env);
		mainParser.push_stream(sqr_group);
		return mainParser.parse_tyvars();
	}

	public static Typarms ParseWhereConstraints([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] GlobalEnv env, [Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] Token tok, Nemerle.Builtins.Tuple<list<PExpr>, PExpr, Location> tyvars)
	{
		if (tok == null)
		{
			throw new ArgumentNullException("tok", "The ``NotNull'' contract of parameter ``tok'' has been violated. See ncc\\parsing\\MainParser.n:325:19:325:22: .");
		}
		if (env == null)
		{
			throw new ArgumentNullException("env", "The ``NotNull'' contract of parameter ``env'' has been violated. See ncc\\parsing\\MainParser.n:324:19:324:22: .");
		}
		MainParser mainParser = new MainParser(env);
		mainParser.push_stream(tok);
		return mainParser.parse_where_constraints(tyvars.Field0, tyvars.Field1, tyvars.Field2);
	}

	public static list<TopDeclaration> Parse(LexerBase lex)
	{
		return Parse(lex, null);
	}

	public static list<TopDeclaration> Parse(LexerBase lex, FunctionVoid<Token> tokenHandler)
	{
		lex.BeginParseFile();
		bool indentationSyntax = lex.Manager.Options.IndentationSyntax;
		PreParser preParser = ((!indentationSyntax) ? new PreParser(lex) : new PreParserIndent(lex));
		preParser.DocComments = lex.Manager.DocComments;
		list<TopDeclaration> list = list<TopDeclaration>.Nil._N_constant_object;
		Token.BracesGroup bracesGroup = preParser.ParseTopLevel();
		tokenHandler?.apply_void(bracesGroup);
		Token.LooseGroup looseGroup = (Token.LooseGroup)bracesGroup.Child;
		lex.Manager.DocComments = preParser.DocComments;
		if (looseGroup != null && indentationSyntax)
		{
			Location.SetIndentationSyntaxForFile(looseGroup.Location.FileIndex, indentationSyntax);
		}
		MainParser mainParser = new MainParser(lex.Manager.CoreEnv);
		while (looseGroup != null)
		{
			mainParser.eat_assembly_attributes(looseGroup);
			if (lex.Manager.IsIntelliSenseMode || IsTopLevel(looseGroup))
			{
				list = mainParser.ParseTopLevel(looseGroup, list);
				looseGroup = (Token.LooseGroup)looseGroup.Next;
				continue;
			}
			list<PExpr> expr = mainParser.parse_expr_sequence(looseGroup);
			string text = Util.Escape(Path.GetFileNameWithoutExtension(lex.Location.File));
			Location loc = looseGroup.Location + lex.Location;
			bool flag = loc.FileIndex != 0;
			if (flag)
			{
				LocationStack.Push(loc);
			}
			TopDeclaration td;
			try
			{
				td = new ClassMember.TypeDeclaration(new TopDeclaration.Class(new Splicable.Name(mainParser.MkNameGenerated(text)), new AttributesAndModifiers(NemerleModifiers.Public, list<PExpr>.Nil._N_constant_object), new Typarms(list<Splicable>.Nil._N_constant_object, list<Constraint>.Nil._N_constant_object), list<PExpr>.Nil._N_constant_object, new list<ClassMember>.Cons(new ClassMember.Function(new Splicable.Name(Name.NameInCurrentColor("Main", _N_MacroContexts.Get(2, ManagerClass.Instance))), new AttributesAndModifiers(NemerleModifiers.Public | NemerleModifiers.Static, list<PExpr>.Nil._N_constant_object), new PFunHeader(new Typarms(list<Splicable>.Nil._N_constant_object, list<Constraint>.Nil._N_constant_object), new Splicable.Name(Name.NameInCurrentColor("Main", _N_MacroContexts.Get(2, ManagerClass.Instance))), new PExpr.Void(), list<PParameter>.Nil._N_constant_object), list<PExpr>.Nil._N_constant_object, new FunBody.Parsed(new PExpr.Sequence(Macros.QuotationChoose(expr)))), list<ClassMember>.Nil._N_constant_object))).td;
			}
			finally
			{
				if (flag)
				{
					LocationStack.RemoveTop();
				}
			}
			TopDeclaration hd = td;
			list = new list<TopDeclaration>.Cons(hd, list);
			if (lex.Manager.Options.IsMainClassAutogenerated)
			{
				lex.Manager.Options.MainClass = null;
			}
			else if (lex.Manager.Options.MainClass == null)
			{
				lex.Manager.Options.MainClass = mainParser.env.CurrentNamespace.GetDisplayName() + text;
				lex.Manager.Options.IsMainClassAutogenerated = true;
			}
			break;
		}
		return list.Rev();
	}

	private static bool IsTopLevel(Token.LooseGroup tok)
	{
		Token token = tok.Child;
		int result;
		while (true)
		{
			if (token is Token.Identifier)
			{
				if (((Token.Identifier)token).name == "type")
				{
					Token next = token.Next;
					if (next is Token.Identifier)
					{
						result = 1;
						break;
					}
				}
			}
			else if (!(token is Token.IdentifierToComplete))
			{
				if (token is Token.Keyword)
				{
					switch (((Token.Keyword)token).name)
					{
					case "public":
					case "private":
					case "static":
					case "internal":
					case "abstract":
					case "sealed":
					case "partial":
					case "class":
					case "module":
					case "variant":
					case "enum":
					case "interface":
					case "struct":
					case "delegate":
					case "macro":
						result = 1;
						break;
					default:
						result = 0;
						break;
					}
				}
				else
				{
					result = ((token is Token.SquareGroup || token is Token.Namespace || token is Token.Using || (object)token == null) ? 1 : 0);
				}
				break;
			}
			token = token.Next;
		}
		return (byte)result != 0;
	}

	private void push_stream(Token newstream)
	{
		streams_stack.Push(stream);
		stream = newstream;
	}

	private void pop_stream()
	{
		stream = streams_stack.Pop();
		if (streams_stack.IsEmpty)
		{
			stream = null;
		}
	}

	private void pop_stream(string finish_entity)
	{
		expect_empty(finish_entity);
		pop_stream();
	}

	private Token get_token()
	{
		object result;
		if (stream != null)
		{
			last_tok = stream;
			stream = stream.Next;
			result = last_tok;
		}
		else
		{
			Error(last_tok, "unexpected end of token sequence");
			result = new Token.EndOfGroup(last_tok.Location);
		}
		return (Token)result;
	}

	private Token peek_token()
	{
		return (stream == null) ? new Token.EndOfGroup(last_tok.Location) : stream;
	}

	private Token peek_second_token()
	{
		return (stream == null) ? new Token.EndOfGroup(last_tok.Location) : ((stream.Next == null) ? new Token.EndOfGroup(stream.Location) : stream.Next);
	}

	private Token peek_sibling_token()
	{
		object result;
		if (stream != null)
		{
			result = stream;
		}
		else
		{
			Token token = streams_stack.Peek();
			result = ((token == null || token.Next == null) ? new Token.EndOfGroup(last_tok.Location) : ((Token.LooseGroup)token.Next).Child);
		}
		return (Token)result;
	}

	private void jump_to_sibling()
	{
		if (stream == null)
		{
			Token next = streams_stack.Pop().Next;
			streams_stack.Push(next);
			Token.LooseGroup looseGroup = (Token.LooseGroup)next;
			if (looseGroup == null)
			{
				Error(last_tok, "unexpected end of token sequence");
			}
			else
			{
				stream = looseGroup.Child;
			}
			return;
		}
		if (!Message.SeenError)
		{
			string text = "cannot jump to sibling, some tokens are still here".ToString();
			Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
		}
		throw new AssertionException("ncc\\parsing\\MainParser.n", 507, "", "cannot jump to sibling, some tokens are still here");
	}

	private void shift_sibling()
	{
		if (stream == null)
		{
			jump_to_sibling();
			shift();
		}
		else
		{
			shift();
		}
	}

	private void new_group_beginning()
	{
		if (stream != null)
		{
			Token.LooseGroup looseGroup = new Token.LooseGroup(calc_group_location(stream), stream);
			looseGroup.Next = streams_stack.Pop();
			streams_stack.Push(looseGroup);
			stream = null;
		}
	}

	private static Location calc_group_location(Token tok)
	{
		if (tok == null)
		{
			throw new AssertionException("ncc\\parsing\\MainParser.n", 532, "tok != null", "");
		}
		Location location = tok.Location;
		Token token = tok;
		while (true)
		{
			Token next = token.Next;
			if (next == null)
			{
				break;
			}
			token = token.Next;
		}
		Location location2 = token.Location;
		return location + location2;
	}

	private void push_back()
	{
		stream = last_tok;
		last_tok = null;
	}

	private void shift()
	{
		if (stream != null)
		{
			last_tok = stream;
			stream = stream.Next;
		}
		else
		{
			Error(last_tok, "unexpected end of token sequence");
		}
	}

	private void expect_empty(string msg)
	{
		if (stream != null)
		{
			Error(stream, "unexpected token after " + Convert.ToString(msg) + " (you forget a closing bracket?).");
		}
	}

	private void expect_operator(string op)
	{
		Token token = get_token();
		if (token is Token.Operator)
		{
			string name = ((Token.Operator)token).name;
			if (op == name)
			{
				return;
			}
			string name2 = ((Token.Operator)token).name;
			token = peek_token();
			if (token is Token.Operator)
			{
				name = ((Token.Operator)token).name;
				if (op == name2 + name)
				{
					shift();
					return;
				}
			}
			Error(token, string.Concat("expecting operator `" + op, "'"));
		}
		else
		{
			Error(token, string.Concat("expecting operator `" + op, "'"));
		}
	}

	private bool flag_keyword(string kw)
	{
		Token token = peek_token();
		int result;
		if (token is Token.Keyword)
		{
			string name = ((Token.Keyword)token).name;
			if (name == kw)
			{
				shift();
				result = 1;
				goto IL_003e;
			}
		}
		result = 0;
		goto IL_003e;
		IL_003e:
		return (byte)result != 0;
	}

	private bool flag_sibling_keyword(string kw)
	{
		Token token = peek_sibling_token();
		int result;
		if (token is Token.Keyword)
		{
			string name = ((Token.Keyword)token).name;
			if (kw == name)
			{
				shift_sibling();
				result = 1;
				goto IL_003e;
			}
		}
		result = 0;
		goto IL_003e;
		IL_003e:
		return (byte)result != 0;
	}

	private bool should_stop(TokenStoppers stop)
	{
		return should_stop(stream, stop);
	}

	private static bool should_stop(Token tok, TokenStoppers stop)
	{
		if ((object)tok == null)
		{
			goto IL_000c;
		}
		int result;
		if (tok is Token.Keyword)
		{
			if (!(((Token.Keyword)tok).name == "where"))
			{
				goto IL_0174;
			}
			result = (((stop & TokenStoppers.Where) != 0) ? 1 : 0);
		}
		else
		{
			string name;
			if (tok is Token.Operator)
			{
				name = ((Token.Operator)tok).name;
			}
			else
			{
				if (tok is Token.Semicolon)
				{
					goto IL_000c;
				}
				if (tok is Token.BracesGroup)
				{
					result = (((stop & TokenStoppers.Braces) != 0) ? 1 : 0);
					goto IL_0175;
				}
				if (!(tok is Token.LooseGroup) || !(((Token.LooseGroup)tok).Child is Token.Operator))
				{
					goto IL_0174;
				}
				name = ((Token.Operator)((Token.LooseGroup)tok).Child).name;
			}
			switch (name)
			{
			case "|":
				if ((stop & TokenStoppers.Pipe) != 0)
				{
					goto IL_00e1;
				}
				goto default;
			default:
				result = 0;
				break;
			case "=":
				if ((stop & TokenStoppers.Equal) != 0)
				{
					goto IL_00e1;
				}
				goto default;
			case "=>":
				if ((stop & TokenStoppers.Arrow) != 0)
				{
					goto IL_00e1;
				}
				goto default;
			case "$":
				if ((stop & TokenStoppers.Dollar) != 0)
				{
					goto IL_00e1;
				}
				goto default;
			case ":":
				{
					if ((stop & TokenStoppers.Colon) != 0)
					{
						goto IL_00e1;
					}
					goto default;
				}
				IL_00e1:
				result = 1;
				break;
			}
		}
		goto IL_0175;
		IL_0175:
		return (byte)result != 0;
		IL_0174:
		result = 0;
		goto IL_0175;
		IL_000c:
		result = 1;
		goto IL_0175;
	}

	private list<T> comma_separated_list<T>(Function<T> f)
	{
		list<T>.Cons cons = new list<T>.Cons(f.apply(), list<T>.Nil._N_constant_object);
		while (true)
		{
			Token token = peek_token();
			if (!(token is Token.Comma))
			{
				break;
			}
			shift();
			cons = new list<T>.Cons(f.apply(), cons);
		}
		return NList.Rev(cons);
	}

	private List<ClassMember> ParseClassMembers<T>(Token first, string parentType)
	{
		push_stream(first);
		List<ClassMember> list = new List<ClassMember>();
		while (stream != null)
		{
			ParseClassMember(parentType, list);
		}
		pop_stream("type member");
		return list;
	}

	private list<T> process_groups<T>(Token first, string name, Function<T> f) where T : class
	{
		list<T> list = null;
		T val = null;
		push_stream(first);
		list = list<T>.Nil._N_constant_object;
		while (stream != null)
		{
			val = f.apply();
			if (val != null)
			{
				list = new list<T>.Cons(val, list);
			}
		}
		pop_stream(name);
		return list.Rev();
	}

	private static PExpr fatal_error(Token tok, string msg)
	{
		Error(tok, msg);
		return new PExpr.Error(tok.Location);
	}

	private static PExpr fatal_error(Location loc, string msg)
	{
		Message.Error(loc, msg);
		return new PExpr.Error(loc);
	}

	private static void Error(Token tok, string msg)
	{
		Message.Error(tok.Location, string.Concat(string.Concat("parse error near " + tok.ToString(describe: true), ": "), msg));
	}

	private Name MkNameGenerated(string id)
	{
		return Name.NameInCurrentColor(id, env);
	}

	private Name MkName(string id, Location loc)
	{
		return Name.NameInCurrentColor(id, loc, env);
	}

	private Splicable.Name MkSplicableName(string id, Location loc)
	{
		return new Splicable.Name(loc, Name.NameInCurrentColor(id, loc, env));
	}

	private Name MkTempName(string placeholder_base, string parsedName, Location loc)
	{
		return Name.NameInCurrentColor(Util.tmpname(placeholder_base), parsedName, loc, env);
	}

	private Splicable.Name MkTempSplicableName(string placeholder_base, string parsedName, Location loc)
	{
		return new Splicable.Name(loc, MkTempName(placeholder_base, parsedName, loc));
	}

	private Splicable.Name MkWildcardSplicableName(Location loc)
	{
		return new Splicable.Name(loc, MkTempName("wildcard", "_", loc));
	}

	private list<T> TokenMap<T>(Token tokens, Function<T> f)
	{
		list<T> list = list<T>.Nil._N_constant_object;
		IEnumerator<Token> enumerator = tokens.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Token current = enumerator.Current;
				if (current is Token.LooseGroup)
				{
					Token.LooseGroup looseGroup = (Token.LooseGroup)current;
					push_stream(looseGroup.Child);
					list = new list<T>.Cons(f.apply(), list);
					pop_stream("group of tokens");
				}
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		return NList.Rev(list);
	}

	private Splicable get_splicable_id()
	{
		if (env == null)
		{
			throw new AssertionException("ncc\\parsing\\MainParser.n", 738, "env != null", "");
		}
		Token token = get_token();
		Location location = token.Location;
		object result;
		Location loc;
		PExpr hd;
		string name;
		Splicable.Expression expression;
		if (token is Token.Identifier)
		{
			name = ((Token.Identifier)token).name;
			result = new Splicable.Name(location, MkName(name, location));
		}
		else if (token is Token.IdentifierToComplete)
		{
			name = ((Token.IdentifierToComplete)token).prefix;
			result = new Splicable.HalfId(location, MkName(name, location));
		}
		else if (token is Token.Keyword)
		{
			if (!(((Token.Keyword)token).name == "_"))
			{
				goto IL_038d;
			}
			result = MkWildcardSplicableName(location);
		}
		else
		{
			if (!(token is Token.Operator) || !(((Token.Operator)token).name == "$"))
			{
				goto IL_038d;
			}
			token = get_token();
			loc = location + token.Location;
			location = token.Location;
			if (token is Token.Identifier)
			{
				name = ((Token.Identifier)token).name;
				result = new Splicable.Expression(loc, new PExpr.Ref(location, MkName(name, location)), env);
			}
			else
			{
				if (token is Token.Keyword)
				{
					if (((Token.Keyword)token).name == "_")
					{
						result = new Splicable.Expression(loc, new PExpr.Wildcard(location), env);
						goto IL_03ad;
					}
				}
				else if (token is Token.RoundGroup)
				{
					token = ((Token.RoundGroup)token).Child;
					push_stream(token);
					list<PExpr> list = parse_expr_sequence(TokenStoppers.Colon);
					PExpr pExpr;
					if (list is list<PExpr>.Cons && (object)((list<PExpr>.Cons)list).tl == list<PExpr>.Nil._N_constant_object)
					{
						hd = ((list<PExpr>.Cons)list).hd;
						pExpr = hd;
					}
					else
					{
						pExpr = fatal_error(location, "only single element in `$(...)' is allowed");
					}
					hd = pExpr;
					token = peek_token();
					if (token is Token.LooseGroup)
					{
						if (((Token.LooseGroup)token).Child is Token.Operator)
						{
							Token.Operator @operator = (Token.Operator)((Token.LooseGroup)token).Child;
							if (((Token.Operator)((Token.LooseGroup)token).Child).name == ":")
							{
								shift();
								push_stream(@operator.Next);
								token = get_token();
								pop_stream("spliced expression");
								if (token is Token.Keyword)
								{
									if (((Token.Keyword)token).name == "enum")
									{
										name = ((Token.Keyword)token).name;
										goto IL_02ab;
									}
								}
								else if (token is Token.Identifier)
								{
									name = ((Token.Identifier)token).name;
									goto IL_02ab;
								}
								expression = new Splicable.Expression(fatal_error(token, "expecting identifier specifying splicing type"), env);
								goto IL_0354;
							}
						}
					}
					else if (token is Token.EndOfGroup)
					{
						expression = new Splicable.Expression(location, hd, env);
						goto IL_0354;
					}
					expression = new Splicable.Expression(fatal_error(token, "expecting end of spliced expression"), env);
					goto IL_0354;
				}
				result = new Splicable.Expression(fatal_error(token, "expecting expression after `$' operator"), env);
			}
		}
		goto IL_03ad;
		IL_02ab:
		expression = new Splicable.Expression(loc, new PExpr.TypeEnforcement(location, hd, new PExpr.Ref(location, MkName(name, token.Location))), env);
		goto IL_0354;
		IL_0354:
		Splicable.Expression expression2 = expression;
		pop_stream("spliced expression");
		result = expression2;
		goto IL_03ad;
		IL_03ad:
		return (Splicable)result;
		IL_038d:
		token = token;
		Error(token, "expecting identifier");
		result = new Splicable.Name(location, MkName(token.ToString(), location));
		goto IL_03ad;
	}

	private list<TopDeclaration> ParseTopLevel(Token.LooseGroup tok, list<TopDeclaration> acc)
	{
		eat_assembly_attributes(tok);
		Token child = tok.Child;
		object result;
		if (child is Token.SquareGroup)
		{
			if ((object)((Token.SquareGroup)child).Child != null)
			{
				goto IL_00f5;
			}
			Error(tok, "empty custom attribute");
			result = acc;
		}
		else if (child is Token.Namespace)
		{
			GlobalEnv globalEnv = ((Token.Namespace)child).Env;
			GlobalEnv globalEnv2 = env;
			env = globalEnv;
			IEnumerator<Token> enumerator = child.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Token.LooseGroup looseGroup = (Token.LooseGroup)enumerator.Current;
					Token.LooseGroup tok2 = looseGroup;
					acc = ParseTopLevel(tok2, acc);
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			env = globalEnv2;
			result = acc;
		}
		else if (child is Token.Using)
		{
			GlobalEnv globalEnv3 = (env = ((Token.Using)child).Env);
			result = acc;
		}
		else
		{
			if ((object)child != null)
			{
				goto IL_00f5;
			}
			result = acc;
		}
		goto IL_0102;
		IL_0102:
		return (list<TopDeclaration>)result;
		IL_00f5:
		result = new list<TopDeclaration>.Cons(ParseTypeDeclaration(child), acc);
		goto IL_0102;
	}

	private void eat_assembly_attributes(Token.LooseGroup tok)
	{
		while (true)
		{
			Token child = tok.Child;
			if (child is Token.SquareGroup)
			{
				Token.SquareGroup squareGroup = (Token.SquareGroup)child;
				if (((Token.SquareGroup)child).Child is Token.LooseGroup && ((Token.LooseGroup)((Token.SquareGroup)child).Child).Child is Token.Identifier && ((Token.Identifier)((Token.LooseGroup)((Token.SquareGroup)child).Child).Child).name == "assembly")
				{
					list<Token.SquareGroup> from = new list<Token.SquareGroup>.Cons(squareGroup, list<Token.SquareGroup>.Nil._N_constant_object);
					AttributesAndModifiers attributesAndModifiers = new AttributesAndModifiers(NemerleModifiers.None, list<PExpr>.Nil._N_constant_object);
					take_attributes_out(ref from, AttributeTargets.Assembly, comply_on_other: true, attributesAndModifiers);
					list<PExpr> list = attributesAndModifiers.custom_attrs;
					while (list is list<PExpr>.Cons)
					{
						PExpr hd = ((list<PExpr>.Cons)list).hd;
						list<PExpr> list2 = ((list<PExpr>.Cons)list).tl;
						PExpr attr = hd;
						Manager.Hierarchy.AddAssemblyAttribute(env, attr);
						list = list2;
					}
					tok.Child = squareGroup.Next;
					tok = tok;
					continue;
				}
				break;
			}
			break;
		}
	}

	private TopDeclaration ParseTypeDeclaration(Token toks)
	{
		push_stream(toks);
		list<Token.SquareGroup> from = get_customs();
		AttributesAndModifiers mods = new AttributesAndModifiers(get_modifiers(), list<PExpr>.Nil._N_constant_object);
		TopDeclaration topDeclaration = ParseTypeDeclaration(mods, toks.Location);
		if (topDeclaration is TopDeclaration.Delegate)
		{
			TopDeclaration.Delegate @delegate = (TopDeclaration.Delegate)topDeclaration;
			take_attributes_out(ref from, AttributeTargets.Class, comply_on_other: false, mods);
			AttributesAndModifiers attributesAndModifiers = new AttributesAndModifiers();
			take_attributes_out(ref from, AttributeTargets.ReturnValue, comply_on_other: true, attributesAndModifiers);
			@delegate.ReturnValueModifiers = attributesAndModifiers;
		}
		else
		{
			take_attributes_out(ref from, AttributeTargets.Class, comply_on_other: true, mods);
		}
		pop_stream("type declaration");
		return topDeclaration;
	}

	private TopDeclaration ParseTypeDeclaration(AttributesAndModifiers mods, Location startLocation)
	{
		_N_closureOf_ParseTypeDeclaration_36358 n_closureOf_ParseTypeDeclaration_ = new _N_closureOf_ParseTypeDeclaration_36358();
		n_closureOf_ParseTypeDeclaration_._N_mods_36367 = mods;
		n_closureOf_ParseTypeDeclaration_._N_startLocation_36365 = startLocation;
		n_closureOf_ParseTypeDeclaration_._N__N_closurised_this_ptr_36363 = this;
		Token token = get_token();
		object obj;
		if (token is Token.Keyword)
		{
			string name = ((Token.Keyword)token).name;
			switch (name)
			{
			case "class":
			case "struct":
			case "module":
			case "interface":
			case "enum":
			case "variant":
				obj = _N_processType_36370(n_closureOf_ParseTypeDeclaration_, name);
				break;
			case "delegate":
			{
				PFunHeader pFunHeader = parse_fun_header(null);
				TopDeclaration.Delegate @delegate = new TopDeclaration.Delegate(n_closureOf_ParseTypeDeclaration_._N_startLocation_36365 + pFunHeader.Location, pFunHeader.ParsedSplicableName, n_closureOf_ParseTypeDeclaration_._N_mods_36367, pFunHeader.ParsedTypeParameters, pFunHeader);
				expect_empty("delegate declaraion");
				obj = @delegate;
				break;
			}
			case "macro":
			{
				PFunHeader pFunHeader = parse_fun_header(null);
				token = peek_token();
				object obj2;
				if (token is Token.Keyword && ((Token.Keyword)token).name == "syntax")
				{
					shift();
					token = get_token();
					if (token is Token.RoundGroup)
					{
						token = ((Token.RoundGroup)token).Child;
						obj2 = parse_expr_sequence(token);
					}
					else
					{
						Error(token, "expecting comma sperated list of syntax specifiers in `()'");
						obj2 = list<PExpr>.Nil._N_constant_object;
					}
				}
				else
				{
					obj2 = list<PExpr>.Nil._N_constant_object;
				}
				list<PExpr> synt = (list<PExpr>)obj2;
				PExpr pExpr = parse_block(list<PParameter>.Nil._N_constant_object);
				Location loc = n_closureOf_ParseTypeDeclaration_._N_startLocation_36365.Combine(pFunHeader.Location).Combine(pExpr.Location);
				TopDeclaration.Macro macro = new TopDeclaration.Macro(loc, pFunHeader.ParsedSplicableName, n_closureOf_ParseTypeDeclaration_._N_mods_36367, null, pFunHeader, synt, pExpr);
				macro._headerLocation = pFunHeader.Location;
				obj = macro;
				break;
			}
			default:
				Error(token, "expecting type declaration");
				obj = new TopDeclaration.Delegate(null);
				break;
			}
		}
		else if (token is Token.Identifier && ((Token.Identifier)token).name == "type")
		{
			obj = _N_processType_36370(n_closureOf_ParseTypeDeclaration_, "type");
		}
		else
		{
			Error(token, "expecting type declaration");
			obj = new TopDeclaration.Delegate(null);
		}
		TopDeclaration topDeclaration = (TopDeclaration)obj;
		topDeclaration.modifiers = n_closureOf_ParseTypeDeclaration_._N_mods_36367;
		return topDeclaration;
	}

	private void ParseClassMember(string parentType, List<ClassMember> members)
	{
		_N_closureOf_ParseClassMember_36615 n_closureOf_ParseClassMember_ = new _N_closureOf_ParseClassMember_36615();
		n_closureOf_ParseClassMember_._N_members_36628 = members;
		n_closureOf_ParseClassMember_._N__N_closurised_this_ptr_36624 = this;
		n_closureOf_ParseClassMember_._N_start_tok_36626 = get_token();
		if (!(n_closureOf_ParseClassMember_._N_start_tok_36626 is Token.LooseGroup))
		{
			return;
		}
		Token child = ((Token.LooseGroup)n_closureOf_ParseClassMember_._N_start_tok_36626).Child;
		push_stream(child);
		n_closureOf_ParseClassMember_._N_customs_36622 = get_customs();
		n_closureOf_ParseClassMember_._N_mods_36620 = new AttributesAndModifiers(get_modifiers(), list<PExpr>.Nil._N_constant_object);
		bool flag = false;
		AttributesAndModifiers attributesAndModifiers = new AttributesAndModifiers();
		parse_top_extensions(attributesAndModifiers, AttributeTargets.All & ~AttributeTargets.Parameter);
		if (!attributesAndModifiers.IsEmpty)
		{
			flag = true;
			list<PExpr> list = attributesAndModifiers.GetCustomAttributes();
			while (list is list<PExpr>.Cons)
			{
				PExpr hd = ((list<PExpr>.Cons)list).hd;
				list<PExpr> list2 = ((list<PExpr>.Cons)list).tl;
				PExpr expr = hd;
				n_closureOf_ParseClassMember_._N_mods_36620.AddCustomAttribute(expr);
				list = list2;
			}
		}
		Location location = default(Location);
		Location location2 = default(Location);
		Token token = peek_token();
		if (token is Token.Identifier)
		{
			if (((Token.Identifier)token).name == "type")
			{
				Token token2 = peek_second_token();
				if (token2 is Token.Identifier)
				{
					_N_parseNestedTypeDeclaration_36643(n_closureOf_ParseClassMember_);
					goto IL_078e;
				}
			}
			goto IL_0332;
		}
		checked
		{
			if (token is Token.Keyword)
			{
				if (((Token.Keyword)token).name == "this")
				{
					shift();
					Nemerle.Builtins.Tuple<list<PParameter>, Location> tuple = parse_parameters();
					list<PParameter> parameters = tuple.Field0;
					Location field = tuple.Field1;
					location = new Location(field, field.Line, field.Column, field.Line, field.Column + 1);
					location2 = new Location(field, field.EndLine, field.EndColumn - 1, field.EndLine, field.EndColumn);
					PFunHeader h = new PFunHeader(n_closureOf_ParseClassMember_._N_start_tok_36626.Location.FromStart() + field, Typarms.Empty, MkSplicableName(".ctor", token.Location), new PExpr.Void(), parameters, location, location2);
					take_attributes_out(ref n_closureOf_ParseClassMember_._N_customs_36622, AttributeTargets.Method, comply_on_other: true, n_closureOf_ParseClassMember_._N_mods_36620);
					ClassMember classMember = parse_method(h, n_closureOf_ParseClassMember_._N_mods_36620, null);
					if (classMember != null)
					{
						n_closureOf_ParseClassMember_._N_members_36628.Add(classMember);
					}
				}
				else
				{
					if (!(((Token.Keyword)token).name == "event"))
					{
						goto IL_0787;
					}
					shift();
					ClassMember classMember2 = parse_event(n_closureOf_ParseClassMember_._N_start_tok_36626.Location.FromStart(), n_closureOf_ParseClassMember_._N_mods_36620, n_closureOf_ParseClassMember_._N_customs_36622);
					if (classMember2 != null)
					{
						n_closureOf_ParseClassMember_._N_members_36628.Add(classMember2);
					}
				}
				goto IL_078e;
			}
			if (token is Token.Operator)
			{
				if (((Token.Operator)token).name == "$")
				{
					goto IL_0332;
				}
				if (((Token.Operator)token).name == "|")
				{
					shift();
					AttributeTargets what = ((!in_variant) ? AttributeTargets.Field : AttributeTargets.Class);
					take_attributes_out(ref n_closureOf_ParseClassMember_._N_customs_36622, what, comply_on_other: true, n_closureOf_ParseClassMember_._N_mods_36620);
					if (n_closureOf_ParseClassMember_._N_mods_36620.Attributes != 0 && n_closureOf_ParseClassMember_._N_mods_36620.Attributes != NemerleModifiers.Partial)
					{
						Error(token, "modifiers not allowed on options");
					}
					ClassMember classMember3 = parse_option(n_closureOf_ParseClassMember_._N_mods_36620);
					if (classMember3 is ClassMember.TypeDeclaration)
					{
						TopDeclaration td = ((ClassMember.TypeDeclaration)classMember3).td;
						td._headerLocation = n_closureOf_ParseClassMember_._N_start_tok_36626.Location.FromStart() + td.NameLocation;
					}
					if (classMember3 != null)
					{
						n_closureOf_ParseClassMember_._N_members_36628.Add(classMember3);
					}
					goto IL_078e;
				}
			}
			else if (token is Token.EndOfGroup)
			{
				Token.EndOfGroup endOfGroup = (Token.EndOfGroup)token;
				if (flag)
				{
					take_attributes_out(ref n_closureOf_ParseClassMember_._N_customs_36622, AttributeTargets.Method, comply_on_other: true, n_closureOf_ParseClassMember_._N_mods_36620);
					Location loc = n_closureOf_ParseClassMember_._N_start_tok_36626.Location.Combine(endOfGroup.Location).AsGenerated();
					Splicable.Name name = MkTempSplicableName("custom_member", "custom_member", loc);
					PFunHeader pFunHeader = new PFunHeader(loc, Typarms.Empty, name, new PExpr.Void(), list<PParameter>.Nil._N_constant_object);
					ClassMember.Function item = new ClassMember.Function(loc, pFunHeader.ParsedSplicableName, n_closureOf_ParseClassMember_._N_mods_36620, pFunHeader, list<PExpr>.Nil._N_constant_object, new FunBody.Parsed(new PExpr.Sequence(list<PExpr>.Nil._N_constant_object)));
					n_closureOf_ParseClassMember_._N_members_36628.Add(item);
					goto IL_078e;
				}
			}
			goto IL_0787;
		}
		IL_078e:
		pop_stream("class member");
		return;
		IL_0787:
		_N_parseNestedTypeDeclaration_36643(n_closureOf_ParseClassMember_);
		goto IL_078e;
		IL_0332:
		Splicable splicable_id = get_splicable_id();
		bool flag2 = false;
		Nemerle.Builtins.Tuple<Token, Token> tuple2 = new Nemerle.Builtins.Tuple<Token, Token>(peek_token(), peek_second_token());
		Nemerle.Builtins.Tuple<Nemerle.Builtins.Tuple<list<PExpr>, PExpr, Location>, Nemerle.Builtins.Tuple<list<PParameter>, Location>> tuple3;
		if (tuple2.Field0 is Token.SquareGroup)
		{
			if (tuple2.Field1 is Token.SquareGroup)
			{
				flag2 = true;
				tuple3 = new Nemerle.Builtins.Tuple<Nemerle.Builtins.Tuple<list<PExpr>, PExpr, Location>, Nemerle.Builtins.Tuple<list<PParameter>, Location>>(parse_tyvars(), parse_parameters());
			}
			else if (tuple2.Field1 is Token.RoundGroup)
			{
				tuple3 = new Nemerle.Builtins.Tuple<Nemerle.Builtins.Tuple<list<PExpr>, PExpr, Location>, Nemerle.Builtins.Tuple<list<PParameter>, Location>>(parse_tyvars(), parse_parameters());
			}
			else
			{
				flag2 = true;
				tuple3 = new Nemerle.Builtins.Tuple<Nemerle.Builtins.Tuple<list<PExpr>, PExpr, Location>, Nemerle.Builtins.Tuple<list<PParameter>, Location>>(new Nemerle.Builtins.Tuple<list<PExpr>, PExpr, Location>(null, null, Location.Default), parse_parameters());
			}
		}
		else if (tuple2.Field0 is Token.RoundGroup)
		{
			tuple3 = new Nemerle.Builtins.Tuple<Nemerle.Builtins.Tuple<list<PExpr>, PExpr, Location>, Nemerle.Builtins.Tuple<list<PParameter>, Location>>(new Nemerle.Builtins.Tuple<list<PExpr>, PExpr, Location>(null, null, Location.Default), parse_parameters());
		}
		else
		{
			flag2 = true;
			tuple3 = new Nemerle.Builtins.Tuple<Nemerle.Builtins.Tuple<list<PExpr>, PExpr, Location>, Nemerle.Builtins.Tuple<list<PParameter>, Location>>(new Nemerle.Builtins.Tuple<list<PExpr>, PExpr, Location>(null, null, Location.Default), new Nemerle.Builtins.Tuple<list<PParameter>, Location>(list<PParameter>.Nil._N_constant_object, Location.Default));
		}
		Nemerle.Builtins.Tuple<Nemerle.Builtins.Tuple<list<PExpr>, PExpr, Location>, Nemerle.Builtins.Tuple<list<PParameter>, Location>> tuple4 = tuple3;
		Nemerle.Builtins.Tuple<list<PExpr>, PExpr, Location> field2 = tuple4.Field0;
		list<PParameter> list3 = tuple4.Field1.Field0;
		Location field3 = tuple4.Field1.Field1;
		checked
		{
			location = new Location(field3, field3.Line, field3.Column, field3.Line, field3.Column + 1);
			location2 = new Location(field3, field3.EndLine, field3.EndColumn - 1, field3.EndLine, field3.EndColumn);
			PExpr pExpr = parse_return_type(allow_inference: true, location2.FromEnd());
			Nemerle.Builtins.Tuple<list<PExpr>, PExpr, Location> tuple5 = field2;
			Typarms typarms = parse_where_constraints(tuple5.Field0, tuple5.Field1, tuple5.Field2);
			if (flag2)
			{
				parse_property(parentType, n_closureOf_ParseClassMember_._N_members_36628, n_closureOf_ParseClassMember_._N_start_tok_36626.Location, n_closureOf_ParseClassMember_._N_mods_36620, n_closureOf_ParseClassMember_._N_customs_36622, splicable_id, pExpr, list3, typarms, location, location2);
			}
			else
			{
				PFunHeader h2 = new PFunHeader(n_closureOf_ParseClassMember_._N_start_tok_36626.Location.FromStart() + field3 + pExpr.Location, typarms, splicable_id, pExpr, list3, location, location2);
				take_attributes_out(ref n_closureOf_ParseClassMember_._N_customs_36622, AttributeTargets.Method, comply_on_other: false, n_closureOf_ParseClassMember_._N_mods_36620);
				AttributesAndModifiers attributesAndModifiers2 = new AttributesAndModifiers();
				take_attributes_out(ref n_closureOf_ParseClassMember_._N_customs_36622, AttributeTargets.ReturnValue, comply_on_other: true, attributesAndModifiers2);
				ClassMember classMember4 = parse_method(h2, n_closureOf_ParseClassMember_._N_mods_36620, attributesAndModifiers2);
				if (classMember4 != null)
				{
					n_closureOf_ParseClassMember_._N_members_36628.Add(classMember4);
				}
			}
			goto IL_078e;
		}
	}

	private ClassMember parse_method(PFunHeader h, AttributesAndModifiers modifiers, AttributesAndModifiers return_value_modifiers)
	{
		Location location = default(Location);
		list<PExpr> list = null;
		Token.BracesGroup bodyBracesGroup = null;
		_N_closureOf_parse_method_36735 n_closureOf_parse_method_ = new _N_closureOf_parse_method_36735();
		n_closureOf_parse_method_._N__N_closurised_this_ptr_36740 = this;
		list = list<PExpr>.Nil._N_constant_object;
		if (flag_keyword("implements"))
		{
			Function<PExpr> f = new _N__N_lambda__36717__36745(n_closureOf_parse_method_);
			list = comma_separated_list(f);
		}
		parse_top_extensions(modifiers, AttributeTargets.Method);
		location = h.Location;
		Token token = peek_token();
		Location alternate = ((token != null) ? CalcTokenLocation(token) : location.FromEnd());
		object obj;
		if (token is Token.Operator)
		{
			if (!(((Token.Operator)token).name == "$"))
			{
				goto IL_0150;
			}
			PExpr.Spliced spliced = parse_spliced_expr();
			location += spliced.Location;
			FunBody.Parsed parsed = new FunBody.Parsed(spliced);
			new_group_beginning();
			obj = parsed;
		}
		else if (token is Token.BracesGroup)
		{
			Token.BracesGroup bracesGroup = (Token.BracesGroup)token;
			shift();
			location += bracesGroup.Location;
			bodyBracesGroup = bracesGroup;
			obj = new FunBody.Parsed(ParseBlock(bracesGroup, h.Parameters));
		}
		else
		{
			if (!(token is Token.EndOfGroup))
			{
				goto IL_0150;
			}
			location += ((Token.EndOfGroup)token).Location;
			obj = FunBody.Abstract._N_constant_object;
		}
		goto IL_01b8;
		IL_0150:
		token = token;
		Error(token, "expecting method body");
		token = token.Next;
		if (token is Token.BracesGroup)
		{
			Token.BracesGroup bracesGroup = (Token.BracesGroup)token;
			shift();
			shift();
			location += bracesGroup.Location;
			bodyBracesGroup = bracesGroup;
			obj = new FunBody.Parsed(ParseBlock(bracesGroup, h.Parameters));
		}
		else
		{
			obj = FunBody.Abstract._N_constant_object;
		}
		goto IL_01b8;
		IL_01b8:
		FunBody body = (FunBody)obj;
		ClassMember.Function function = new ClassMember.Function(location, h.ParsedSplicableName, modifiers, h, list, body);
		InitBodyLocations(function, bodyBracesGroup, alternate);
		function._env = env;
		function.ReturnValueModifiers = return_value_modifiers;
		return function;
	}

	private static Location CombineLocations(Token token1, Token token2)
	{
		if (token1 == null)
		{
			throw new AssertionException("ncc\\parsing\\MainParser.n", 1296, "token1 != null", "");
		}
		return CombineLocations(token1.Location, token2);
	}

	private static Location CombineLocations(Location loc, Token token)
	{
		return (token != null) ? loc.Combine(token.Location) : loc;
	}

	private static void InitBodyLocations(MemberBase member, Token.BracesGroup bodyBracesGroup)
	{
		checked
		{
			if (bodyBracesGroup != null)
			{
				Location location = bodyBracesGroup.Location;
				if (bodyBracesGroup.generated)
				{
					member._bodyOpenTokenLocation = location.FromStart();
					member._bodyCloseTokenLocation = location.FromEnd();
					member._isIndentationSyntax = true;
				}
				else
				{
					member._bodyOpenTokenLocation = new Location(location.FileIndex, location.Line, location.Column, location.Line, location.Column + 1);
					member._bodyCloseTokenLocation = new Location(location.FileIndex, location.EndLine, location.EndColumn - 1, location.EndLine, location.EndColumn);
				}
			}
		}
	}

	private static void InitBodyLocations(MemberBase member, Token.BracesGroup bodyBracesGroup, Location alternate)
	{
		if (bodyBracesGroup != null)
		{
			InitBodyLocations(member, bodyBracesGroup);
		}
		else if (alternate.Line != 0)
		{
			member._bodyOpenTokenLocation = alternate.FromStart();
			member._bodyCloseTokenLocation = alternate.FromEnd();
		}
	}

	private Token.BracesGroup TryPeekBracesGroup()
	{
		Token token = peek_token();
		return (!(token is Token.BracesGroup)) ? null : ((Token.BracesGroup)token);
	}

	private ClassMember parse_option(AttributesAndModifiers modifiers)
	{
		_N_closureOf_parse_option_36840 n_closureOf_parse_option_ = new _N_closureOf_parse_option_36840();
		n_closureOf_parse_option_._N_modifiers_36847 = modifiers;
		n_closureOf_parse_option_._N__N_closurised_this_ptr_36845 = this;
		Splicable splicable_id = get_splicable_id();
		Token token = peek_token();
		object result;
		if (token is Token.Operator)
		{
			if (!(((Token.Operator)token).name == "="))
			{
				goto IL_00e9;
			}
			shift();
			option<PExpr>.Some value = new option<PExpr>.Some(parse_expr(TokenStoppers.Pipe));
			new_group_beginning();
			result = new ClassMember.EnumOption(splicable_id.Location, splicable_id, n_closureOf_parse_option_._N_modifiers_36847, value);
		}
		else if (token is Token.BracesGroup)
		{
			Token.BracesGroup bracesGroup = (Token.BracesGroup)token;
			token = ((Token.BracesGroup)token).Child;
			shift();
			result = _N_make_option_36850(n_closureOf_parse_option_, splicable_id, token, splicable_id.Location + bracesGroup.Location, bracesGroup);
		}
		else
		{
			if (!(token is Token.EndOfGroup))
			{
				goto IL_00e9;
			}
			result = _N_make_option_36850(n_closureOf_parse_option_, splicable_id, null, splicable_id.Location, null);
		}
		goto IL_00ff;
		IL_00ff:
		return (ClassMember)result;
		IL_00e9:
		new_group_beginning();
		result = _N_make_option_36850(n_closureOf_parse_option_, splicable_id, null, splicable_id.Location, null);
		goto IL_00ff;
	}

	private FunBody parse_accessor_body(list<PParameter> p)
	{
		Token token = peek_token();
		object result;
		if (token is Token.EndOfGroup)
		{
			result = FunBody.Abstract._N_constant_object;
		}
		else
		{
			PExpr expr = parse_block(p);
			result = new FunBody.Parsed(expr);
		}
		return (FunBody)result;
	}

	private void parse_property(string _parentType, List<ClassMember> members, Location startLocation, AttributesAndModifiers mods, list<Token.SquareGroup> customs, Splicable id, PExpr ret_type, list<PParameter> parms, Typarms typarms, Location prmsOpenLoc, Location prmsCloseLoc)
	{
		_N_closureOf_parse_property_36993 n_closureOf_parse_property_ = new _N_closureOf_parse_property_36993();
		n_closureOf_parse_property_._N__N_closurised_this_ptr_36998 = this;
		Location location = startLocation + ret_type.Location;
		list<PExpr> list = list<PExpr>.Nil._N_constant_object;
		if (flag_keyword("implements"))
		{
			Function<PExpr> f = new _N__N_lambda__36915__37018(n_closureOf_parse_property_);
			list = comma_separated_list(f);
		}
		Token token = peek_token();
		object obj;
		if (token is Token.Operator)
		{
			Token.Operator @operator = (Token.Operator)token;
			if (!(((Token.Operator)token).name == "="))
			{
				goto IL_093d;
			}
			shift();
			Location location2 = @operator.Location.FromEnd() + CalcTokenLocation(stream);
			PExpr pExpr = parse_expr();
			pExpr.Location = location2;
			Location loc = location2;
			bool flag = loc.FileIndex != 0;
			if (flag)
			{
				LocationStack.Push(loc);
			}
			try
			{
				mods.AddCustomAttribute(new PExpr.Call(new PExpr.Member(new PExpr.Member(new PExpr.Ref(MkNameGenerated("Nemerle")), new Splicable.Name(Name.NameInCurrentColor("InternalMacros", _N_MacroContexts.Get(2, ManagerClass.Instance)))), new Splicable.Name(Name.NameInCurrentColor("StaticInitializer", _N_MacroContexts.Get(2, ManagerClass.Instance)))), new list<PExpr>.Cons(Macros.QuotationChoose(pExpr), list<PExpr>.Nil._N_constant_object)));
			}
			finally
			{
				if (flag)
				{
					LocationStack.RemoveTop();
				}
			}
			take_attributes_out(ref customs, AttributeTargets.Field, comply_on_other: true, mods);
			Location loc2 = location.Combine(last_tok.Location).Combine(location2);
			ClassMember.Field field = new ClassMember.Field(loc2, id, mods, ret_type, pExpr);
			InitBodyLocations(field, null, location2);
			obj = field;
		}
		else if (token is Token.BracesGroup)
		{
			Token.BracesGroup bracesGroup = (Token.BracesGroup)token;
			shift();
			take_attributes_out(ref customs, AttributeTargets.Property, comply_on_other: true, mods);
			option<ClassMember.Function> option = option<ClassMember.Function>.None._N_constant_object;
			option<ClassMember.Function> option2 = option<ClassMember.Function>.None._N_constant_object;
			option<PExpr> option3 = option<PExpr>.None._N_constant_object;
			List<Nemerle.Builtins.Tuple<Name, Name>> list2 = null;
			IEnumerator<Token> enumerator = bracesGroup.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Token current = enumerator.Current;
					if (!(current is Token.LooseGroup))
					{
						continue;
					}
					Token child = ((Token.LooseGroup)current).Child;
					push_stream(child);
					Token next = child.Next;
					Location location3 = ((next != null) ? CalcTokenLocation(next) : child.Location.FromEnd());
					Location location4 = ((next != null) ? (child.Location + location3) : child.Location);
					list<Token.SquareGroup> from = get_customs();
					NemerleModifiers modifiers = get_modifiers();
					Token token2 = get_token();
					if (token2 is Token.Identifier)
					{
						Token.Identifier identifier = (Token.Identifier)token2;
						string name = ((Token.Identifier)token2).name;
						Location loc3 = identifier.Location.AsGenerated();
						Location loc4 = location4;
						bool flag2 = loc4.FileIndex != 0;
						if (flag2)
						{
							LocationStack.Push(loc4);
						}
						try
						{
							switch (name)
							{
							case "get":
							{
								if (!option2.IsNone)
								{
									Message.Error("property cannot have multiple getters");
								}
								AttributesAndModifiers attributesAndModifiers2 = new AttributesAndModifiers(modifiers, list<PExpr>.Nil._N_constant_object);
								take_attributes_out(ref from, AttributeTargets.Method, comply_on_other: false, attributesAndModifiers2);
								parse_top_extensions(attributesAndModifiers2, AttributeTargets.Method);
								AttributesAndModifiers attributesAndModifiers3 = new AttributesAndModifiers();
								take_attributes_out(ref from, AttributeTargets.ReturnValue, comply_on_other: true, attributesAndModifiers3);
								Token.BracesGroup bodyBracesGroup = TryPeekBracesGroup();
								list<PExpr> implemented = list;
								FunBody body = ParseFunctionOrExpression(list<PParameter>.Nil._N_constant_object);
								Splicable name4 = AddPrefixToSplicable("get_", id, loc3);
								PFunHeader pFunHeader = new PFunHeader(loc3, name4, ret_type, parms);
								ClassMember.Function function = new ClassMember.Function(location4.AsGenerated(), pFunHeader.ParsedSplicableName, attributesAndModifiers2, pFunHeader, implemented, body);
								InitBodyLocations(function, bodyBracesGroup);
								function._env = env;
								function.ReturnValueModifiers = attributesAndModifiers3;
								option2 = new option<ClassMember.Function>.Some(function);
								break;
							}
							case "set":
							{
								if (!option.IsNone)
								{
									Message.Error("property cannot have multiple setters");
								}
								AttributesAndModifiers attributesAndModifiers4 = new AttributesAndModifiers(modifiers, list<PExpr>.Nil._N_constant_object);
								take_attributes_out(ref from, AttributeTargets.Method, comply_on_other: false, attributesAndModifiers4);
								parse_top_extensions(attributesAndModifiers4, AttributeTargets.Method);
								AttributesAndModifiers attributesAndModifiers5 = new AttributesAndModifiers();
								take_attributes_out(ref from, AttributeTargets.ReturnValue, comply_on_other: false, attributesAndModifiers5);
								AttributesAndModifiers attributesAndModifiers6 = new AttributesAndModifiers(NemerleModifiers.None, list<PExpr>.Nil._N_constant_object);
								take_attributes_out(ref from, AttributeTargets.Parameter, comply_on_other: true, attributesAndModifiers6);
								Splicable.Name name5 = MkSplicableName("value", loc3);
								list<PParameter> list3 = parms + new list<PParameter>.Cons(new PParameter(name5, ret_type, attributesAndModifiers6), list<PParameter>.Nil._N_constant_object);
								Token.BracesGroup bodyBracesGroup2 = TryPeekBracesGroup();
								list<PExpr> implemented2 = list;
								FunBody body2 = ParseFunctionOrExpression(list3);
								Splicable name6 = AddPrefixToSplicable("set_", id, loc3);
								PFunHeader pFunHeader2 = new PFunHeader(loc3, typarms, name6, new PExpr.Void(), list3);
								ClassMember.Function function2 = new ClassMember.Function(location4.AsGenerated(), pFunHeader2.ParsedSplicableName, attributesAndModifiers4, pFunHeader2, implemented2, body2);
								InitBodyLocations(function2, bodyBracesGroup2);
								function2._env = env;
								function2.ReturnValueModifiers = attributesAndModifiers5;
								option = new option<ClassMember.Function>.Some(function2);
								break;
							}
							case "default":
							{
								if (option3.IsSome)
								{
									Message.Error("property cannot have multiple initializers");
								}
								PExpr pExpr4 = ParseBlockOrExpression(list<PParameter>.Nil._N_constant_object);
								Token.BracesGroup bracesGroup2 = TryPeekBracesGroup();
								if (bracesGroup2 != null)
								{
									pExpr4.Location = bracesGroup2.Location;
								}
								option3 = new option<PExpr>.Some(pExpr4);
								break;
							}
							default:
							{
								Name name2 = MkName(name, identifier.Location);
								bool flag3 = !Manager.IsIntelliSenseMode;
								Name name3 = ((!flag3) ? name2 : MkTempName("field_" + Convert.ToString(name) + "_embeded_in_" + Convert.ToString(id), name, identifier.Location));
								PExpr pExpr2 = parse_return_type(allow_inference: false, Location.Default);
								NemerleModifiers mods2 = (mods.mods & NemerleModifiers.Static) | modifiers;
								AttributesAndModifiers attributesAndModifiers = new AttributesAndModifiers(mods2, list<PExpr>.Nil._N_constant_object);
								take_attributes_out(ref from, AttributeTargets.Field, comply_on_other: true, attributesAndModifiers);
								ClassMember.Field field2 = new ClassMember.Field(location4 + pExpr2.Location, new Splicable.Name(name3), attributesAndModifiers, pExpr2);
								if (list2 == null)
								{
									list2 = new List<Nemerle.Builtins.Tuple<Name, Name>>();
								}
								if (flag3)
								{
									list2.Add(new Nemerle.Builtins.Tuple<Name, Name>(name2, name3));
								}
								field2._env = env;
								members.Add(field2);
								Token token3 = peek_token();
								if (!(token3 is Token.Operator))
								{
									break;
								}
								Token.Operator operator2 = (Token.Operator)token3;
								if (!(((Token.Operator)token3).name == "="))
								{
									break;
								}
								shift();
								Location location5 = operator2.Location.FromEnd() + CalcTokenLocation(stream);
								PExpr pExpr3 = parse_expr();
								pExpr3.Location = location5;
								field2.Initializer = pExpr3;
								Location loc5 = location5;
								bool flag4 = loc5.FileIndex != 0;
								if (flag4)
								{
									LocationStack.Push(loc5);
								}
								try
								{
									attributesAndModifiers.AddCustomAttribute(new PExpr.Call(new PExpr.Member(new PExpr.Member(new PExpr.Ref(MkNameGenerated("Nemerle")), new Splicable.Name(Name.NameInCurrentColor("InternalMacros", _N_MacroContexts.Get(2, ManagerClass.Instance)))), new Splicable.Name(Name.NameInCurrentColor("StaticInitializer", _N_MacroContexts.Get(2, ManagerClass.Instance)))), new list<PExpr>.Cons(Macros.QuotationChoose(pExpr3), list<PExpr>.Nil._N_constant_object)));
								}
								finally
								{
									if (flag4)
									{
										LocationStack.RemoveTop();
									}
								}
								field2.Location = location4.Combine(last_tok.Location).Combine(location5);
								InitBodyLocations(field2, null, location5);
								break;
							}
							}
						}
						finally
						{
							if (flag2)
							{
								LocationStack.RemoveTop();
							}
						}
					}
					else
					{
						Token tok = token2;
						Error(tok, "expecting property accessor");
					}
					pop_stream("property member");
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			ClassMember.Property property = new ClassMember.Property(location + bracesGroup.Location, id, mods, ret_type, parms, option2, option, option3);
			property._parsedParametersOpenLocation = prmsOpenLoc;
			property._parsedParametersCloseLocation = prmsCloseLoc;
			property.ParsedImplemented = list;
			InitBodyLocations(property, bracesGroup);
			if (list2 != null)
			{
				foreach (Nemerle.Builtins.Tuple<Name, Name> item in list2)
				{
					Name field3 = item.Field0;
					Name field4 = item.Field1;
					_N_redirect_37000(field3, field4, property.setter);
					_N_redirect_37000(field3, field4, property.getter);
				}
			}
			obj = property;
		}
		else
		{
			if (!(token is Token.EndOfGroup))
			{
				goto IL_093d;
			}
			take_attributes_out(ref customs, AttributeTargets.Field, comply_on_other: true, mods);
			obj = new ClassMember.Field(location, id, mods, ret_type);
		}
		goto IL_0969;
		IL_0969:
		ClassMember classMember = (ClassMember)obj;
		if (classMember != null)
		{
			classMember._env = env;
			members.Add(classMember);
		}
		return;
		IL_093d:
		Token tok2 = token;
		Error(tok2, "expecting `=', `;' or `{' in field / property declaration");
		take_attributes_out(ref customs, AttributeTargets.Field, comply_on_other: true, mods);
		obj = new ClassMember.Field(location, id, mods, ret_type);
		goto IL_0969;
	}

	private FunBody ParseFunctionOrExpression(list<PParameter> p)
	{
		Token token = peek_token();
		return (token is Token.BracesGroup) ? parse_accessor_body(p) : ((!(token is Token.EndOfGroup)) ? ((FunBody)new FunBody.Parsed(parse_expr())) : ((FunBody)FunBody.Abstract._N_constant_object));
	}

	private PExpr ParseBlockOrExpression(list<PParameter> p)
	{
		Token token = peek_token();
		return (!(token is Token.BracesGroup)) ? parse_expr() : parse_block(p);
	}

	private static bool IsAutoGeneratedProperty(ClassMember.Property prop)
	{
		return (prop.Attributes & (NemerleModifiers.Abstract | NemerleModifiers.Extern)) == 0 && prop.parameters.IsEmpty;
	}

	private static void ValidateNoPropertyInitializer(ClassMember.Property prop)
	{
		if (prop.initializer.IsSome)
		{
			Message.Error("initializer can be set only for automatically generated properties");
		}
	}

	public static ClassMember.Field TryExpandAutoproperty(ClassMember.Property prop)
	{
		option<ClassMember.Function> option = null;
		option<ClassMember.Function> option2 = null;
		NemerleModifiers nemerleModifiers = default(NemerleModifiers);
		list<PExpr>.Cons cons = null;
		ClassMember.Function val;
		ClassMember.Function function;
		object result;
		if (IsAutoGeneratedProperty(prop))
		{
			option2 = prop.getter;
			option = prop.setter;
			if (option2 is option<ClassMember.Function>.Some && ((option<ClassMember.Function>.Some)option2).val.body == FunBody.Abstract._N_constant_object)
			{
				val = ((option<ClassMember.Function>.Some)option2).val;
				if (option is option<ClassMember.Function>.Some)
				{
					if (((option<ClassMember.Function>.Some)option).val.body == FunBody.Abstract._N_constant_object)
					{
						function = ((option<ClassMember.Function>.Some)option).val;
						goto IL_008e;
					}
				}
				else if (option == option<ClassMember.Function>.None._N_constant_object)
				{
					val = ((option<ClassMember.Function>.Some)option2).val;
					function = null;
					goto IL_008e;
				}
			}
			ValidateNoPropertyInitializer(prop);
			result = null;
		}
		else
		{
			ValidateNoPropertyInitializer(prop);
			result = null;
		}
		goto IL_0500;
		IL_008e:
		nemerleModifiers = prop.Attributes & NemerleModifiers.Static;
		if (function != null)
		{
			nemerleModifiers |= NemerleModifiers.Mutable;
		}
		list<PExpr> parsedCustomAttributes = prop.modifiers.ParsedCustomAttributes;
		Function<PExpr, bool> instance = _N__N_lambda__37162__37187.Instance;
		bool flag = parsedCustomAttributes.Exists(instance);
		cons = new list<PExpr>.Cons(new PExpr.Call(new PExpr.Member(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("System", _N_MacroContexts.Get(2, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Diagnostics", _N_MacroContexts.Get(2, ManagerClass.Instance)))), new Splicable.Name(Name.NameInCurrentColor("DebuggerBrowsable", _N_MacroContexts.Get(2, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Member(new PExpr.Member(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("System", _N_MacroContexts.Get(2, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Diagnostics", _N_MacroContexts.Get(2, ManagerClass.Instance)))), new Splicable.Name(Name.NameInCurrentColor("DebuggerBrowsableState", _N_MacroContexts.Get(2, ManagerClass.Instance)))), new Splicable.Name(Name.NameInCurrentColor("Never", _N_MacroContexts.Get(2, ManagerClass.Instance)))), list<PExpr>.Nil._N_constant_object)), new list<PExpr>.Cons(new PExpr.Member(new PExpr.Member(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("System", _N_MacroContexts.Get(2, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Runtime", _N_MacroContexts.Get(2, ManagerClass.Instance)))), new Splicable.Name(Name.NameInCurrentColor("CompilerServices", _N_MacroContexts.Get(2, ManagerClass.Instance)))), new Splicable.Name(Name.NameInCurrentColor("CompilerGenerated", _N_MacroContexts.Get(2, ManagerClass.Instance)))), list<PExpr>.Nil._N_constant_object));
		if (flag)
		{
			cons = new list<PExpr>.Cons(new PExpr.Ref(Name.NameInCurrentColor("RecordIgnore", _N_MacroContexts.Get(2, ManagerClass.Instance))), cons);
		}
		AttributesAndModifiers expr = new AttributesAndModifiers(nemerleModifiers, cons);
		Name name = Macros.NewSymbol(prop.Name);
		val.Body = new PExpr.Ref(name);
		val.AddCustomAttribute(new PExpr.Member(new PExpr.Member(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("System", _N_MacroContexts.Get(2, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Runtime", _N_MacroContexts.Get(2, ManagerClass.Instance)))), new Splicable.Name(Name.NameInCurrentColor("CompilerServices", _N_MacroContexts.Get(2, ManagerClass.Instance)))), new Splicable.Name(Name.NameInCurrentColor("CompilerGenerated", _N_MacroContexts.Get(2, ManagerClass.Instance)))));
		if (function != null)
		{
			function.Body = new PExpr.Assign(new PExpr.Ref(name), new PExpr.Ref(new Name("value", -1, null)));
			function.AddCustomAttribute(new PExpr.Member(new PExpr.Member(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("System", _N_MacroContexts.Get(2, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Runtime", _N_MacroContexts.Get(2, ManagerClass.Instance)))), new Splicable.Name(Name.NameInCurrentColor("CompilerServices", _N_MacroContexts.Get(2, ManagerClass.Instance)))), new Splicable.Name(Name.NameInCurrentColor("CompilerGenerated", _N_MacroContexts.Get(2, ManagerClass.Instance)))));
		}
		option<PExpr> initializer = prop.initializer;
		if (initializer is option<PExpr>.Some)
		{
			PExpr val2 = ((option<PExpr>.Some)initializer).val;
			Splicable.Name name2 = new Splicable.Name(name);
			expr = Macros.QuotationChoose(expr);
			result = new ClassMember.Field(name2, new AttributesAndModifiers(NemerleModifiers.None | expr.mods, new list<PExpr>.Cons(new PExpr.Call(new PExpr.Member(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("Nemerle", _N_MacroContexts.Get(2, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("InternalMacros", _N_MacroContexts.Get(2, ManagerClass.Instance)))), new Splicable.Name(Name.NameInCurrentColor("StaticInitializer", _N_MacroContexts.Get(2, ManagerClass.Instance)))), new list<PExpr>.Cons(Macros.QuotationChoose(val2), list<PExpr>.Nil._N_constant_object)), list<PExpr>.Nil._N_constant_object) + expr.custom_attrs), Macros.QuotationChoose(prop.returnType));
		}
		else
		{
			result = new ClassMember.Field(new Splicable.Name(name), Macros.QuotationChoose(expr), Macros.QuotationChoose(prop.returnType));
		}
		goto IL_0500;
		IL_0500:
		return (ClassMember.Field)result;
	}

	private static Location CalcTokenLocation(Token tok)
	{
		Location result;
		if (tok == null)
		{
			result = Location.Default;
		}
		else
		{
			Location location = tok.Location;
			Location location2 = location;
			Token token = tok;
			while (token.Next != null)
			{
				token = token.Next;
			}
			Location location3 = token.Location;
			result = location2 + location3;
		}
		return result;
	}

	private Splicable AddPrefixToSplicable(string prefix, Splicable id, Location loc, bool doRenaming = false)
	{
		object result;
		if (id is Splicable.Name)
		{
			Name body = ((Splicable.Name)id).body;
			string text = prefix + body.Id;
			result = ((!doRenaming) ? MkSplicableName(text, loc) : MkTempSplicableName(text, text, loc));
		}
		else if (id is Splicable.Expression)
		{
			PExpr expr = ((Splicable.Expression)id).expr;
			PExpr.TypeEnforcement typeEnforcement;
			if (expr is PExpr.TypeEnforcement)
			{
				expr = ((PExpr.TypeEnforcement)expr).expr;
				typeEnforcement = _N_mekeNewSplicable_37257(expr, prefix, doRenaming);
			}
			else
			{
				typeEnforcement = _N_mekeNewSplicable_37257(expr, prefix, doRenaming);
			}
			PExpr.TypeEnforcement expr2 = typeEnforcement;
			result = new Splicable.Expression(loc, expr2, env);
		}
		else
		{
			if (!(id is Splicable.HalfId))
			{
				throw new MatchFailureException();
			}
			Name body = ((Splicable.HalfId)id).prefix;
			result = MkSplicableName(prefix + body.Id, loc);
		}
		return (Splicable)result;
	}

	private ClassMember parse_event(Location loc, AttributesAndModifiers mods, list<Token.SquareGroup> customs)
	{
		Splicable splicable_id = get_splicable_id();
		PExpr pExpr = parse_return_type(allow_inference: false, Location.Default);
		loc += pExpr.Location;
		Splicable.Name name = MkSplicableName("value", loc.AsGenerated());
		ClassMember.Function function = null;
		ClassMember.Function function2 = null;
		Token token = peek_token();
		object result;
		if (token is Token.BracesGroup)
		{
			Token.BracesGroup bracesGroup = (Token.BracesGroup)token;
			shift();
			take_attributes_out(ref customs, AttributeTargets.Event, comply_on_other: true, mods);
			IEnumerator<Token> enumerator = bracesGroup.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Token current = enumerator.Current;
					if (!(current is Token.LooseGroup))
					{
						continue;
					}
					Token child = ((Token.LooseGroup)current).Child;
					push_stream(child);
					list<Token.SquareGroup> from = get_customs();
					NemerleModifiers modifiers = get_modifiers();
					Token token2 = get_token();
					if (token2 is Token.Identifier)
					{
						Token.Identifier identifier = (Token.Identifier)token2;
						string name2 = ((Token.Identifier)token2).name;
						Location loc2 = identifier.Location.AsGenerated();
						if (name2 == "remove" || name2 == "add")
						{
							if (name2 == "remove")
							{
								if (function != null)
								{
									Message.Error(identifier.Location, "event cannot have multiple remove methods");
								}
							}
							else if (function2 != null)
							{
								Message.Error(identifier.Location, "event cannot have multiple add methods");
							}
							AttributesAndModifiers attributesAndModifiers = new AttributesAndModifiers(modifiers, list<PExpr>.Nil._N_constant_object);
							take_attributes_out(ref from, AttributeTargets.Method, comply_on_other: false, attributesAndModifiers);
							parse_top_extensions(attributesAndModifiers, AttributeTargets.Method);
							AttributesAndModifiers attributesAndModifiers2 = new AttributesAndModifiers();
							take_attributes_out(ref from, AttributeTargets.ReturnValue, comply_on_other: false, attributesAndModifiers2);
							AttributesAndModifiers attributesAndModifiers3 = new AttributesAndModifiers(NemerleModifiers.None, list<PExpr>.Nil._N_constant_object);
							take_attributes_out(ref from, AttributeTargets.Parameter, comply_on_other: true, attributesAndModifiers3);
							list<PParameter>.Cons cons = new list<PParameter>.Cons(new PParameter(name, pExpr, attributesAndModifiers3), list<PParameter>.Nil._N_constant_object);
							Token.BracesGroup bracesGroup2 = TryPeekBracesGroup();
							list<PExpr>.Nil n_constant_object = list<PExpr>.Nil._N_constant_object;
							FunBody body = ParseFunctionOrExpression(cons);
							Splicable name3 = AddPrefixToSplicable(name2 + "_", splicable_id, loc2);
							PFunHeader header = new PFunHeader(loc2, name3, new PExpr.Void(loc2), cons);
							ClassMember.Function function3 = new ClassMember.Function(CombineLocations(identifier, bracesGroup2), name3, attributesAndModifiers, header, n_constant_object, body);
							InitBodyLocations(function3, bracesGroup2);
							function3._env = env;
							function3.ReturnValueModifiers = attributesAndModifiers2;
							if (name2 == "remove")
							{
								function = function3;
							}
							else
							{
								function2 = function3;
							}
						}
						else
						{
							Splicable.Name name4 = MkSplicableName(name2, identifier.Location);
							PExpr pExpr2 = parse_return_type(allow_inference: false, Location.Default);
							AttributesAndModifiers attributesAndModifiers4 = new AttributesAndModifiers(modifiers, list<PExpr>.Nil._N_constant_object);
							take_attributes_out(ref from, AttributeTargets.Field, comply_on_other: true, attributesAndModifiers4);
							ClassMember.Field body2 = new ClassMember.Field(identifier.Location.Combine(pExpr2.Location), name4, attributesAndModifiers4, pExpr2);
							PExpr.Quoted expr = new PExpr.Quoted(loc2, new SyntaxElement.ClassMember(body2));
							mods.AddCustomAttribute(new PExpr.Call(new PExpr.Member(new PExpr.Member(new PExpr.Ref(MkNameGenerated("Nemerle")), new Splicable.Name(Name.NameInCurrentColor("InternalMacros", _N_MacroContexts.Get(2, ManagerClass.Instance)))), new Splicable.Name(Name.NameInCurrentColor("EventEmbeddedField", _N_MacroContexts.Get(2, ManagerClass.Instance)))), new list<PExpr>.Cons(Macros.QuotationChoose(expr), list<PExpr>.Nil._N_constant_object)));
						}
					}
					else
					{
						Token tok = token2;
						Error(tok, "expecting event accessor");
					}
					pop_stream("property member");
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			if (function2 == null || function == null)
			{
				Message.Error(loc, "both of event accessors `add' and 'remove' must be specified");
			}
			result = new ClassMember.Event(loc + bracesGroup.Location, splicable_id, mods, pExpr, null, function2, function);
		}
		else if (token is Token.EndOfGroup)
		{
			take_attributes_out(ref customs, AttributeTargets.Event, comply_on_other: false, mods);
			NemerleModifiers mods2 = NemerleModifiers.Private | NemerleModifiers.Mutable;
			Location loc3 = loc.AsGenerated();
			AttributesAndModifiers attributesAndModifiers5 = new AttributesAndModifiers(mods2, list<PExpr>.Nil._N_constant_object);
			take_attributes_out(ref customs, AttributeTargets.Field, comply_on_other: false, attributesAndModifiers5);
			bool doRenaming = !Manager.IsIntelliSenseMode;
			Splicable name5 = AddPrefixToSplicable("_N_event_field_of_", splicable_id, loc3, doRenaming);
			ClassMember.Field field = new ClassMember.Field(loc3, name5, attributesAndModifiers5, pExpr);
			AttributesAndModifiers attributesAndModifiers6 = new AttributesAndModifiers(mods.Attributes, list<PExpr>.Nil._N_constant_object);
			take_attributes_out(ref customs, AttributeTargets.Method, comply_on_other: false, attributesAndModifiers6);
			AttributesAndModifiers returnValueModifiers = new AttributesAndModifiers();
			take_attributes_out(ref customs, AttributeTargets.ReturnValue, comply_on_other: true, attributesAndModifiers6);
			list<PParameter>.Cons parameters = new list<PParameter>.Cons(new PParameter(name, pExpr, new AttributesAndModifiers()), list<PParameter>.Nil._N_constant_object);
			Splicable name6 = AddPrefixToSplicable("add_", splicable_id, loc3);
			PFunHeader header2 = new PFunHeader(loc3, name6, new PExpr.Void(loc3), parameters);
			function2 = new ClassMember.Function(loc3, name6, attributesAndModifiers6, header2, list<PExpr>.Nil._N_constant_object, null);
			function2._env = env;
			function2.ReturnValueModifiers = returnValueModifiers;
			Splicable name7 = AddPrefixToSplicable("remove_", splicable_id, loc3);
			PFunHeader header3 = new PFunHeader(loc3, name7, new PExpr.Void(loc3), parameters);
			function = new ClassMember.Function(loc3, name7, attributesAndModifiers6, header3, list<PExpr>.Nil._N_constant_object, null);
			function._env = env;
			function.ReturnValueModifiers = returnValueModifiers;
			result = new ClassMember.Event(loc, splicable_id, mods, pExpr, field, function2, function);
		}
		else
		{
			Token tok2 = token;
			Error(tok2, "expecting `;' or `{ }' in event declaration");
			result = null;
		}
		return (ClassMember)result;
	}

	private option<PExpr> maybe_parse_ellipsis()
	{
		Token token = peek_token();
		object result;
		if (token is Token.LooseGroup)
		{
			if (((Token.LooseGroup)token).Child is Token.Operator)
			{
				Token.Operator @operator = (Token.Operator)((Token.LooseGroup)token).Child;
				if (((Token.Operator)((Token.LooseGroup)token).Child).name == "..")
				{
					shift();
					push_stream(@operator);
					shift();
					PExpr.Spliced spliced = parse_spliced_expr();
					pop_stream("ellipsis splicing");
					result = new option<PExpr>.Some(new PExpr.Ellipsis(@operator.Location + spliced.Location, spliced));
					goto IL_0114;
				}
			}
		}
		else if (token is Token.Operator && ((Token.Operator)token).name == "..")
		{
			shift();
			PExpr.Spliced spliced = parse_spliced_expr();
			result = new option<PExpr>.Some(new PExpr.Ellipsis(((Token.Operator)token).Location + spliced.Location, spliced));
			goto IL_0114;
		}
		result = option<PExpr>.None._N_constant_object;
		goto IL_0114;
		IL_0114:
		return (option<PExpr>)result;
	}

	private list<Token.SquareGroup> get_customs()
	{
		int num = 0;
		Token token = peek_token();
		object result;
		if (token is Token.Operator)
		{
			Token.Operator @operator = (Token.Operator)token;
			if (((Token.Operator)token).name == "..")
			{
				token = null;
				for (num = 3; num > 0; num = checked(num - 1))
				{
					token = get_token();
				}
				token.Next = null;
				result = new list<Token.SquareGroup>.Cons(new Token.SquareGroup(@operator.Location, new Token.LooseGroup(@operator.Location, @operator), null, null), list<Token.SquareGroup>.Nil._N_constant_object);
				goto IL_00ee;
			}
		}
		list<Token.SquareGroup> list = list<Token.SquareGroup>.Nil._N_constant_object;
		while (true)
		{
			token = peek_token();
			if (!(token is Token.SquareGroup))
			{
				break;
			}
			Token.SquareGroup squareGroup = (Token.SquareGroup)token;
			token = ((Token.SquareGroup)token).Child;
			shift();
			if (token != null)
			{
				list = new list<Token.SquareGroup>.Cons(squareGroup, list);
				continue;
			}
			Error(squareGroup, "custom attributes brackets cannot be empty");
			list = list;
		}
		result = NList.Rev(list);
		goto IL_00ee;
		IL_00ee:
		return (list<Token.SquareGroup>)result;
	}

	private void take_attributes_out(ref list<Token.SquareGroup> from, AttributeTargets what, bool comply_on_other, AttributesAndModifiers mods)
	{
		_N_closureOf_take_attributes_out_37432 n_closureOf_take_attributes_out_ = new _N_closureOf_take_attributes_out_37432();
		n_closureOf_take_attributes_out_._N_what_37445 = what;
		n_closureOf_take_attributes_out_._N_comply_on_other_37443 = comply_on_other;
		n_closureOf_take_attributes_out_._N_mods_37441 = mods;
		n_closureOf_take_attributes_out_._N__N_closurised_this_ptr_37437 = this;
		n_closureOf_take_attributes_out_._N_parsedCustomAttrsRev_37439 = list<PExpr>.Nil._N_constant_object;
		list<Token.SquareGroup> l = from;
		Function<Token.SquareGroup, bool> f = new _N__N_lambda__37418__37447(n_closureOf_take_attributes_out_);
		from = NList.RevFilter(l, f);
		list<PExpr> list = n_closureOf_take_attributes_out_._N_parsedCustomAttrsRev_37439.Rev();
		n_closureOf_take_attributes_out_._N_mods_37441.ParsedCustomAttributes = list;
		list<PExpr> custom_attrs = n_closureOf_take_attributes_out_._N_mods_37441.custom_attrs;
		AttributesAndModifiers n_mods_ = n_closureOf_take_attributes_out_._N_mods_37441;
		list<PExpr> list2 = (n_mods_.custom_attrs = ((!(custom_attrs == null) && !custom_attrs.IsEmpty) ? (custom_attrs + list) : list));
	}

	private NemerleModifiers get_modifiers()
	{
		_N_closureOf_get_modifiers_37512 n_closureOf_get_modifiers_ = new _N_closureOf_get_modifiers_37512();
		n_closureOf_get_modifiers_._N__N_closurised_this_ptr_37517 = this;
		return _N_loop_37520(n_closureOf_get_modifiers_, NemerleModifiers.None);
	}

	private Nemerle.Builtins.Tuple<list<PExpr>, PExpr, Location> parse_tyvars()
	{
		_N_closureOf_parse_tyvars_37584 n_closureOf_parse_tyvars_ = new _N_closureOf_parse_tyvars_37584();
		Token token = peek_token();
		Nemerle.Builtins.Tuple<list<PExpr>, PExpr, Location> result;
		if (token is Token.SquareGroup)
		{
			if ((object)((Token.SquareGroup)token).Child == null)
			{
				shift();
				Error((Token.SquareGroup)token, "expecting type variables");
				result = new Nemerle.Builtins.Tuple<list<PExpr>, PExpr, Location>(null, null, Location.Default);
			}
			else
			{
				Token.SquareGroup squareGroup = (Token.SquareGroup)token;
				token = ((Token.SquareGroup)token).Child;
				push_stream(((Token.LooseGroup)token).Child);
				option<PExpr> option = maybe_parse_ellipsis();
				if (option is option<PExpr>.Some)
				{
					PExpr val = ((option<PExpr>.Some)option).val;
					pop_stream("type variables");
					shift();
					result = new Nemerle.Builtins.Tuple<list<PExpr>, PExpr, Location>(list<PExpr>.Nil._N_constant_object, val, squareGroup.Location);
				}
				else
				{
					pop_stream();
					shift();
					n_closureOf_parse_tyvars_._N__N_obj_cache_37589 = this;
					Function<PExpr> f = new _N__N_method_lambda__37602(n_closureOf_parse_tyvars_);
					result = new Nemerle.Builtins.Tuple<list<PExpr>, PExpr, Location>(TokenMap(squareGroup, f), new PExpr.Void(), squareGroup.Location);
				}
			}
		}
		else
		{
			result = new Nemerle.Builtins.Tuple<list<PExpr>, PExpr, Location>(null, null, Location.Default);
		}
		return result;
	}

	private Typarms parse_where_constraints(list<PExpr> tyvars, PExpr splicing_type, Location _loc)
	{
		_N_closureOf_parse_where_constraints_37662 n_closureOf_parse_where_constraints_ = new _N_closureOf_parse_where_constraints_37662();
		n_closureOf_parse_where_constraints_._N__N_closurised_this_ptr_37667 = this;
		object result;
		if (tyvars != null)
		{
			list<Constraint> list = list<Constraint>.Nil._N_constant_object;
			Nemerle.Builtins.Tuple<list<Constraint>, PExpr> tuple;
			PExpr val;
			while (true)
			{
				_N_closureOf_loop_37690 n_closureOf_loop_ = new _N_closureOf_loop_37690();
				if (flag_keyword("where"))
				{
					option<PExpr> option = maybe_parse_ellipsis();
					if (option is option<PExpr>.Some)
					{
						val = ((option<PExpr>.Some)option).val;
						tuple = new Nemerle.Builtins.Tuple<list<Constraint>, PExpr>(NList.Rev(list), val);
						break;
					}
					n_closureOf_loop_._N_tv_37695 = get_splicable_id();
					expect_operator(":");
					Function<Nemerle.Builtins.Tuple<bool, PExpr>> f = new _N__N_lambda__37621__37705(n_closureOf_parse_where_constraints_);
					list<Nemerle.Builtins.Tuple<bool, PExpr>> list2 = comma_separated_list(f);
					list<Constraint> acc = list;
					Function<Nemerle.Builtins.Tuple<bool, PExpr>, list<Constraint>, list<Constraint>> f2 = new _N__N_lambda__37631__37731(n_closureOf_loop_);
					list = list2.FoldLeft(acc, f2);
					list = list;
					continue;
				}
				tuple = new Nemerle.Builtins.Tuple<list<Constraint>, PExpr>(NList.Rev(list), new PExpr.Void());
				break;
			}
			Nemerle.Builtins.Tuple<list<Constraint>, PExpr> tuple2 = tuple;
			list = tuple2.Field0;
			val = tuple2.Field1;
			result = ((!(splicing_type is PExpr.Void) || !(val is PExpr.Void)) ? _N_create_typarms_37672(tyvars, new list<Constraint>.Cons(new Constraint(null, new PExpr.Tuple(new list<PExpr>.Cons(Macros.QuotationChoose(splicing_type), new list<PExpr>.Cons(Macros.QuotationChoose(val), list<PExpr>.Nil._N_constant_object))), isSpecial: false), list)) : _N_create_typarms_37672(tyvars, list));
		}
		else
		{
			result = Typarms.Empty;
		}
		return (Typarms)result;
	}

	private PFunHeader parse_fun_header(Splicable name, bool allow_patterns = false)
	{
		if (name == null)
		{
			name = get_splicable_id();
		}
		Nemerle.Builtins.Tuple<list<PExpr>, PExpr, Location> tuple = parse_tyvars();
		Token token = peek_token();
		Location obj;
		if (token is Token.RoundGroup)
		{
			token = token;
		}
		else
		{
			if (!(token is Token.SquareGroup))
			{
				obj = Location.Default;
				goto IL_0088;
			}
			token = token;
		}
		obj = ((token.Next != null) ? (token.Location.FromEnd() + token.Next.Location.FromStart()) : token.Location.FromEnd());
		goto IL_0088;
		IL_0088:
		Location postHeaderLoc = obj;
		Nemerle.Builtins.Tuple<list<PParameter>, Location> tuple2 = parse_parameters(allow_patterns);
		list<PParameter> parameters = tuple2.Field0;
		Location field = tuple2.Field1;
		PExpr pExpr = parse_return_type(allow_inference: true, postHeaderLoc);
		Typarms typeParameters = parse_where_constraints(tuple.Field0, tuple.Field1, tuple.Field2);
		checked
		{
			postHeaderLoc = new Location(field, field.Line, field.Column, field.Line, field.Column + 1);
			Location parametersCloseLocation = new Location(field, field.EndLine, field.EndColumn - 1, field.EndLine, field.EndColumn);
			field = name.Location + field + pExpr.Location;
			return new PFunHeader(field, typeParameters, name, pExpr, parameters, postHeaderLoc, parametersCloseLocation);
		}
	}

	private PParameter parse_parameter()
	{
		return parse_parameter(allow_patterns: false);
	}

	private PParameter parse_parameter(bool allow_patterns)
	{
		list<Token.SquareGroup> from = get_customs();
		AttributesAndModifiers attributesAndModifiers = new AttributesAndModifiers(get_modifiers(), list<PExpr>.Nil._N_constant_object);
		take_attributes_out(ref from, AttributeTargets.Parameter, comply_on_other: true, attributesAndModifiers);
		parse_top_extensions(attributesAndModifiers, AttributeTargets.Parameter);
		PExpr patternHack = null;
		Token token = peek_token();
		object obj;
		if (token is Token.Keyword)
		{
			if (((Token.Keyword)token).name == "params")
			{
				shift();
				attributesAndModifiers.custom_attrs = new list<PExpr>.Cons(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("System", _N_MacroContexts.Get(2, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("ParamArrayAttribute", _N_MacroContexts.Get(2, ManagerClass.Instance)))), attributesAndModifiers.custom_attrs);
				obj = get_splicable_id();
				goto IL_010b;
			}
		}
		else if (token is Token.RoundGroup)
		{
			Token.RoundGroup roundGroup = (Token.RoundGroup)token;
			if (allow_patterns)
			{
				patternHack = parse_expr();
				obj = new Splicable.Name(roundGroup.Location, Macros.NewSymbol("pat"));
				goto IL_010b;
			}
		}
		obj = get_splicable_id();
		goto IL_010b;
		IL_010b:
		Splicable splicable = (Splicable)obj;
		Token token2 = peek_token();
		object obj2;
		if (token2 is Token.Operator && ((Token.Operator)token2).name == ":")
		{
			shift();
			obj2 = parse_expr(TokenStoppers.Equal);
		}
		else
		{
			obj2 = new PExpr.Wildcard(splicable.Location.AsGenerated());
		}
		PExpr pExpr = (PExpr)obj2;
		Token token3 = peek_token();
		object obj3;
		if (token3 is Token.Operator && ((Token.Operator)token3).name == "=")
		{
			shift();
			PExpr val = parse_expr();
			obj3 = new option<PExpr>.Some(val);
		}
		else
		{
			obj3 = option<PExpr>.None._N_constant_object;
		}
		option<PExpr> defval = (option<PExpr>)obj3;
		return new PParameter(splicable.Location.Combine(pExpr.Location), splicable, pExpr, attributesAndModifiers, defval, patternHack);
	}

	private Nemerle.Builtins.Tuple<list<PParameter>, Location> parse_parameters(bool allow_patterns = false, bool allow_omit = false)
	{
		_N_closureOf_parse_parameters_37828 n_closureOf_parse_parameters_ = new _N_closureOf_parse_parameters_37828();
		n_closureOf_parse_parameters_._N_allow_patterns_37835 = allow_patterns;
		n_closureOf_parse_parameters_._N__N_closurised_this_ptr_37833 = this;
		Token token = get_token();
		Token child;
		object obj;
		if (token is Token.RoundGroup)
		{
			if ((object)((Token.RoundGroup)token).Child == null)
			{
				goto IL_003c;
			}
			child = ((Token.RoundGroup)token).Child;
		}
		else
		{
			if (!(token is Token.SquareGroup))
			{
				if (allow_omit)
				{
					push_back();
				}
				else
				{
					Error(token, "expecting function parameters");
				}
				obj = list<PParameter>.Nil._N_constant_object;
				goto IL_014a;
			}
			if ((object)((Token.SquareGroup)token).Child == null)
			{
				goto IL_003c;
			}
			child = ((Token.SquareGroup)token).Child;
		}
		push_stream(child);
		option<PExpr> option = maybe_parse_ellipsis();
		if (option is option<PExpr>.Some)
		{
			PExpr val = ((option<PExpr>.Some)option).val;
			pop_stream("ellipsis spliced expression");
			obj = new list<PParameter>.Cons(new PParameter(val.Location, new Splicable.Name(MkNameGenerated("")), new PExpr.Void(val.Location.AsGenerated()), new AttributesAndModifiers(NemerleModifiers.None, new list<PExpr>.Cons(val, list<PExpr>.Nil._N_constant_object))), list<PParameter>.Nil._N_constant_object);
		}
		else
		{
			pop_stream();
			Function<PParameter> f = new _N__N_lambda__37821__37846(n_closureOf_parse_parameters_);
			obj = TokenMap(token, f);
		}
		goto IL_014a;
		IL_003c:
		obj = list<PParameter>.Nil._N_constant_object;
		goto IL_014a;
		IL_014a:
		list<PParameter> field = (list<PParameter>)obj;
		return new Nemerle.Builtins.Tuple<list<PParameter>, Location>(field, token.Location);
	}

	private PExpr parse_return_type(bool allow_inference, Location postHeaderLoc)
	{
		Token token = peek_token();
		object result;
		if (token is Token.Operator && ((Token.Operator)token).name == ":")
		{
			shift();
			Token token2 = peek_token();
			if (token2 is Token.Keyword)
			{
				if (((Token.Keyword)token2).name == "where")
				{
					goto IL_00b2;
				}
			}
			else if (token2 is Token.Operator)
			{
				if (((Token.Operator)token2).name == "=")
				{
					goto IL_00b2;
				}
			}
			else if (token2 is Token.Semicolon || token2 is Token.BracesGroup)
			{
				goto IL_00b2;
			}
			result = parse_expr(TokenStoppers.Equal | TokenStoppers.Braces | TokenStoppers.Dollar | TokenStoppers.Where);
		}
		else
		{
			Token token2 = token;
			Location loc = ((!(postHeaderLoc == Location.Default)) ? (postHeaderLoc + token2.Location.FromStart()) : token2.Location.FromStart());
			if (!allow_inference)
			{
				Message.Error(loc, "expecting `:' and type specifier for class member");
			}
			result = new PExpr.Wildcard(loc.AsGenerated());
		}
		goto IL_013e;
		IL_00b2:
		result = new PExpr.Error(((Token.Operator)token).Location.FromEnd());
		goto IL_013e;
		IL_013e:
		return (PExpr)result;
	}

	public PExpr ParseBlock(Token.BracesGroup tok, list<PParameter> parms)
	{
		PExpr pExpr = null;
		_N_closureOf_ParseBlock_37919 n_closureOf_ParseBlock_ = new _N_closureOf_ParseBlock_37919();
		Location location = tok.Location;
		Token child = tok.Child;
		object obj;
		list<MatchCase> cases;
		object obj2;
		list<PParameter> list;
		if ((object)child == null)
		{
			obj = new PExpr.Sequence(location, list<PExpr>.Nil._N_constant_object);
		}
		else
		{
			if (child is Token.LooseGroup)
			{
				Token.LooseGroup looseGroup = (Token.LooseGroup)child;
				if (((Token.LooseGroup)child).Child is Token.Operator && ((Token.Operator)((Token.LooseGroup)child).Child).name == "|")
				{
					n_closureOf_ParseBlock_._N__N_obj_cache_37924 = this;
					Function<MatchCase> f = new _N__N_method_lambda__37933(n_closureOf_ParseBlock_);
					cases = process_groups(looseGroup, "function body", f);
					if (parms is list<PParameter>.Cons)
					{
						if (((list<PParameter>.Cons)parms).hd.name is Splicable.Name)
						{
							Splicable.Name name = (Splicable.Name)((list<PParameter>.Cons)parms).hd.name;
							if ((object)((list<PParameter>.Cons)parms).tl == list<PParameter>.Nil._N_constant_object)
							{
								Name body = ((Splicable.Name)((list<PParameter>.Cons)parms).hd.name).body;
								obj2 = new PExpr.Ref(name.Location, body);
								goto IL_026d;
							}
						}
						if (((list<PParameter>.Cons)parms).tl is list<PParameter>.Cons)
						{
							list = parms;
							list<PExpr> list2 = list<PExpr>.Nil._N_constant_object;
							while (true)
							{
								if ((object)list == list<PParameter>.Nil._N_constant_object)
								{
									obj2 = PExpr.Tuple.Create(looseGroup.Location, NList.Rev(list2));
									break;
								}
								if (list is list<PParameter>.Cons)
								{
									if (((list<PParameter>.Cons)list).hd.name is Splicable.Name)
									{
										Splicable.Name name = (Splicable.Name)((list<PParameter>.Cons)list).hd.name;
										Name body = ((Splicable.Name)((list<PParameter>.Cons)list).hd.name).body;
										list = ((list<PParameter>.Cons)list).tl;
										list<PParameter> obj3 = list;
										list2 = new list<PExpr>.Cons(new PExpr.Ref(name.Location, body), list2);
										list = obj3;
										continue;
									}
									PParameter hd = ((list<PParameter>.Cons)list).hd;
									obj2 = fatal_error(hd.Location, "illegal spliced parameter?");
									break;
								}
								throw new MatchFailureException();
							}
						}
						else
						{
							PParameter hd = ((list<PParameter>.Cons)parms).hd;
							obj2 = fatal_error(hd.Location, "illegal spliced parameter?");
						}
					}
					else
					{
						if ((object)parms != list<PParameter>.Nil._N_constant_object)
						{
							throw new MatchFailureException();
						}
						obj2 = null;
					}
					goto IL_026d;
				}
			}
			obj = new PExpr.Sequence(location, parse_expr_sequence(child));
		}
		goto IL_0297;
		IL_0297:
		pExpr = (PExpr)obj;
		list = parms;
		while (list is list<PParameter>.Cons)
		{
			PParameter hd = ((list<PParameter>.Cons)list).hd;
			list = ((list<PParameter>.Cons)list).tl;
			hd = hd;
			if (hd.PatternHack != null)
			{
				pExpr = new PExpr.Sequence(new list<PExpr>.Cons(new PExpr.Define(Macros.QuotationChoose(hd.PatternHack), new PExpr.Ref(hd.name.GetName())), new list<PExpr>.Cons(Macros.QuotationChoose(pExpr), list<PExpr>.Nil._N_constant_object)));
				pExpr.Location = location;
				hd.ResetPatternHack();
			}
			list = list;
		}
		return pExpr;
		IL_026d:
		pExpr = (PExpr)obj2;
		obj = new PExpr.Match(location, pExpr, cases);
		goto IL_0297;
	}

	private PExpr parse_block(list<PParameter> parms)
	{
		Token token = get_token();
		object result;
		if (token is Token.Operator)
		{
			if (!(((Token.Operator)token).name == "$"))
			{
				goto IL_003d;
			}
			push_back();
			result = parse_spliced_expr();
		}
		else
		{
			if (!(token is Token.BracesGroup))
			{
				goto IL_003d;
			}
			result = ParseBlock((Token.BracesGroup)token, parms);
		}
		goto IL_006c;
		IL_006c:
		return (PExpr)result;
		IL_003d:
		result = fatal_error(token, "expected `{' at the beginning of function body");
		goto IL_006c;
	}

	private static Splicable make_splicable(PExpr e)
	{
		object result;
		if (e is PExpr.Ref)
		{
			Name name = ((PExpr.Ref)e).name;
			result = new Splicable.Name(e.Location, name);
		}
		else if (e is PExpr.Spliced)
		{
			PExpr body = ((PExpr.Spliced)e).body;
			result = new Splicable.Expression(e.Location, body);
		}
		else if (e is PExpr.ToComplete)
		{
			Name name = ((PExpr.ToComplete)e).body;
			result = new Splicable.HalfId(e.Location, name);
		}
		else
		{
			Message.Error(e.Location, "expecting simple identifier instead of `" + Convert.ToString(e) + "'");
			result = null;
		}
		return (Splicable)result;
	}

	private PExpr make_operator_call(string name, Location op_loc, PExpr e1, PExpr e2)
	{
		Location loc = e1.Location + e2.Location;
		object result;
		switch (name)
		{
		case ".":
			if (e2 is PExpr.ListLiteral)
			{
				list<PExpr> generic_parms = ((PExpr.ListLiteral)e2).elements;
				result = new PExpr.GenericSpecifier(loc, e1, generic_parms);
			}
			else
			{
				result = new PExpr.Member(loc, e1, make_splicable(e2));
			}
			break;
		case "=":
			result = new PExpr.Assign(loc, e1, e2);
			break;
		case ":":
			result = new PExpr.TypeEnforcement(loc, e1, e2);
			break;
		case ":>":
			result = new PExpr.TypeConversion(loc, e1, e2);
			break;
		case "::":
			result = Util.set(loc, new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("list", _N_MacroContexts.Get(2, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Cons", _N_MacroContexts.Get(2, ManagerClass.Instance)))), new list<PExpr>.Cons(Macros.QuotationChoose(e1), new list<PExpr>.Cons(Macros.QuotationChoose(e2), list<PExpr>.Nil._N_constant_object))));
			break;
		case "as":
			result = new PExpr.As(loc, e1, make_splicable(e2));
			break;
		case "where":
			result = new PExpr.Where(loc, e1, e2);
			break;
		case "is":
			result = new PExpr.Is(loc, e1, e2);
			break;
		case "matches":
			result = Util.set(loc, new PExpr.Match(Macros.QuotationChoose(e1), new list<MatchCase>.Cons(new MatchCase(new list<PExpr>.Cons(Macros.QuotationChoose(e2), list<PExpr>.Nil._N_constant_object), new PExpr.Literal(new Literal.Bool(val: true))), new list<MatchCase>.Cons(new MatchCase(new list<PExpr>.Cons(new PExpr.Wildcard(), list<PExpr>.Nil._N_constant_object), new PExpr.Literal(new Literal.Bool(val: false))), list<MatchCase>.Nil._N_constant_object))));
			break;
		default:
			result = new PExpr.Call(loc, new PExpr.Ref(op_loc, MkName(name, op_loc)), new list<PExpr>.Cons(e1, new list<PExpr>.Cons(e2, list<PExpr>.Nil._N_constant_object)));
			break;
		}
		return (PExpr)result;
	}

	private PExpr make_operator_call(string name, PExpr e)
	{
		return new PExpr.Call(e.Location, new PExpr.Ref(e.Location, MkName(name, e.Location)), new list<PExpr>.Cons(e, list<PExpr>.Nil._N_constant_object));
	}

	private PExpr make_operator_call(string name, list<PExpr> parms, Location location)
	{
		Location loc = location.Combine(parms.Head.Location + parms.Last.Location);
		return (name == "(") ? new PExpr.Call(loc, parms.Head, parms.Tail) : ((!(name == "[")) ? ((PExpr)new PExpr.Call(loc, new PExpr.Ref(loc, MkName(name, location)), parms)) : ((PExpr)new PExpr.Indexer(loc, parms.Head, parms.Tail)));
	}

	private static list<PExpr> roll_exprs(ref list<PExpr> exprs, list<PExpr> begin)
	{
		list<PExpr> list = list<PExpr>.Nil._N_constant_object;
		while ((object)exprs != begin)
		{
			if (exprs is list<PExpr>.Cons)
			{
				PExpr hd = ((list<PExpr>.Cons)exprs).hd;
				list<PExpr> list2 = ((list<PExpr>.Cons)exprs).tl;
				list = new list<PExpr>.Cons(hd, list);
				exprs = list2;
				continue;
			}
			if (!Message.SeenError)
			{
				string text = "invalidated expressions stack".ToString();
				Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
			}
			throw new AssertionException("ncc\\parsing\\MainParser.n", 2497, "", "invalidated expressions stack");
		}
		return list;
	}

	private void roll_operators(ref list<PExpr> exprs, ref list<Nemerle.Builtins.Tuple<OperatorInfo, Location>> ops, int priority)
	{
		while (true)
		{
			if ((object)ops == list<Nemerle.Builtins.Tuple<OperatorInfo, Location>>.Nil._N_constant_object)
			{
				return;
			}
			if (!(ops is list<Nemerle.Builtins.Tuple<OperatorInfo, Location>>.Cons))
			{
				break;
			}
			OperatorInfo field = ((list<Nemerle.Builtins.Tuple<OperatorInfo, Location>>.Cons)ops).hd.Field0;
			Location field2 = ((list<Nemerle.Builtins.Tuple<OperatorInfo, Location>>.Cons)ops).hd.Field1;
			list<Nemerle.Builtins.Tuple<OperatorInfo, Location>> list = ((list<Nemerle.Builtins.Tuple<OperatorInfo, Location>>.Cons)ops).tl;
			if (field.RightPriority < priority)
			{
				return;
			}
			PExpr pExpr;
			if (field is NaryOperatorInfo)
			{
				NaryOperatorInfo naryOperatorInfo = (NaryOperatorInfo)field;
				list<PExpr> parms = roll_exprs(ref exprs, naryOperatorInfo.ExprsBegin);
				pExpr = make_operator_call(field.Name, parms, naryOperatorInfo.Location);
			}
			else if (field is BinaryOperatorInfo)
			{
				if (!(exprs is list<PExpr>.Cons) || !(((list<PExpr>.Cons)exprs).tl is list<PExpr>.Cons))
				{
					if (!Message.SeenError)
					{
						string text = "not enough parms for binary".ToString();
						Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
					}
					throw new AssertionException("ncc\\parsing\\MainParser.n", 2530, "", "not enough parms for binary");
				}
				PExpr hd = ((list<PExpr>.Cons)exprs).hd;
				PExpr hd2 = ((list<PExpr>.Cons)((list<PExpr>.Cons)exprs).tl).hd;
				list<PExpr> list2 = (exprs = ((list<PExpr>.Cons)((list<PExpr>.Cons)exprs).tl).tl);
				pExpr = make_operator_call(field.Name, field2, hd2, hd);
			}
			else
			{
				PExpr e = NList.Head(exprs);
				exprs = NList.Tail(exprs);
				pExpr = make_operator_call(field.Name, e);
			}
			PExpr hd3 = pExpr;
			exprs = new list<PExpr>.Cons(hd3, exprs);
			ops = list;
		}
		throw new MatchFailureException();
	}

	private PExpr parse_expr()
	{
		return parse_expr(TokenStoppers.None);
	}

	private PExpr parse_expr(TokenStoppers stop)
	{
		list<PExpr> exprs = list<PExpr>.Nil._N_constant_object;
		list<Nemerle.Builtins.Tuple<OperatorInfo, Location>> ops = list<Nemerle.Builtins.Tuple<OperatorInfo, Location>>.Nil._N_constant_object;
		OpContext opContext = OpContext.Prefix;
		while (true)
		{
			Location location;
			string name;
			if (opContext == OpContext.Prefix)
			{
				Token token = peek_token();
				location = token.Location;
				if (token is Token.Operator)
				{
					if (((Token.Operator)token).name == "..")
					{
						shift();
						PExpr.Spliced spliced = parse_spliced_expr();
						exprs = new list<PExpr>.Cons(new PExpr.Ellipsis(spliced.Location, spliced), exprs);
						expect_empty("ellipsis expression");
						opContext = OpContext.Postfix;
						continue;
					}
					name = ((Token.Operator)token).name;
					if (name != "$")
					{
						goto IL_00a5;
					}
				}
				else if (token is Token.Keyword)
				{
					name = ((Token.Keyword)token).name;
					goto IL_00a5;
				}
				PExpr hd = parse_embedded_expr(stop);
				exprs = new list<PExpr>.Cons(hd, exprs);
				opContext = OpContext.Postfix;
				continue;
			}
			Token group = null;
			Token token2 = peek_token();
			Location location2 = token2.Location;
			Nemerle.Builtins.Tuple<OperatorInfo, Location> obj;
			if (token2 is Token.Keyword)
			{
				string name2 = ((Token.Keyword)token2).name;
				obj = ((!should_stop(stop)) ? new Nemerle.Builtins.Tuple<OperatorInfo, Location>(env.LookupOperator(name2), location2) : new Nemerle.Builtins.Tuple<OperatorInfo, Location>(null, location2));
			}
			else if (token2 is Token.Operator)
			{
				string name3 = ((Token.Operator)token2).name;
				if (should_stop(stop))
				{
					obj = new Nemerle.Builtins.Tuple<OperatorInfo, Location>(null, location2);
				}
				else if (!env.HasOperator(name3))
				{
					obj = ((!(name3 == "*")) ? new Nemerle.Builtins.Tuple<OperatorInfo, Location>(env.FetchOperator(name3), location2) : new Nemerle.Builtins.Tuple<OperatorInfo, Location>(new NaryOperatorInfo(OperatorInfo.ProductInfo, location2), location2));
				}
				else
				{
					Token tok = peek_second_token();
					obj = ((env.HasUnaryOperator(name3) && is_operator_or_stoper(tok, stop)) ? new Nemerle.Builtins.Tuple<OperatorInfo, Location>(env.LookupUnaryOperator(name3), location2) : ((!(name3 == "*")) ? new Nemerle.Builtins.Tuple<OperatorInfo, Location>(env.FetchOperator(name3), location2) : new Nemerle.Builtins.Tuple<OperatorInfo, Location>(new NaryOperatorInfo(env.FetchOperator(name3), location2), location2)));
				}
			}
			else
			{
				Token child;
				OperatorInfo copy;
				if (token2 is Token.RoundGroup)
				{
					child = ((Token.RoundGroup)token2).Child;
					copy = OperatorInfo.RoundInfo;
				}
				else
				{
					if (!(token2 is Token.SquareGroup))
					{
						obj = new Nemerle.Builtins.Tuple<OperatorInfo, Location>(null, location2);
						goto IL_03b5;
					}
					child = ((Token.SquareGroup)token2).Child;
					copy = OperatorInfo.SquareInfo;
				}
				group = child;
				obj = new Nemerle.Builtins.Tuple<OperatorInfo, Location>(new NaryOperatorInfo(copy, location2), location2);
			}
			goto IL_03b5;
			IL_054a:
			exprs = parse_expr_sequence(group, exprs);
			OperatorInfo field;
			if (field is BinaryOperatorInfo)
			{
				opContext = OpContext.Prefix;
			}
			continue;
			IL_03b5:
			Nemerle.Builtins.Tuple<OperatorInfo, Location> hd2 = obj;
			field = hd2.Field0;
			Location field2 = hd2.Field1;
			if (field == null)
			{
				break;
			}
			shift();
			roll_operators(ref exprs, ref ops, field.LeftPriority);
			if (field is NaryOperatorInfo)
			{
				NaryOperatorInfo naryOperatorInfo = (NaryOperatorInfo)field;
				naryOperatorInfo.ExprsBegin = exprs.Tail;
			}
			if (field.Name == "*")
			{
				if (field is NaryOperatorInfo)
				{
					goto IL_04eb;
				}
			}
			else if (false)
			{
				goto IL_04eb;
			}
			ops = new list<Nemerle.Builtins.Tuple<OperatorInfo, Location>>.Cons(new Nemerle.Builtins.Tuple<OperatorInfo, Location>(field, field2), ops);
			goto IL_054a;
			IL_00a5:
			option<GrammarElement> option = env.SyntaxKeywords.Find(name);
			if (option is option<GrammarElement>.Some)
			{
				GrammarElement val = ((option<GrammarElement>.Some)option).val;
				if ((val.Target & (AttributeTargets)32768) != 0)
				{
					shift();
					exprs = new list<PExpr>.Cons(parse_syntax_definition(val, stop), exprs);
					opContext = OpContext.Postfix;
					continue;
				}
			}
			OperatorInfo operatorInfo = ((name == "-") ? OperatorInfo.UnMinus : ((!(name == "+")) ? env.LookupUnaryOperator(name) : OperatorInfo.UnPlus));
			if (operatorInfo != null)
			{
				shift();
				ops = new list<Nemerle.Builtins.Tuple<OperatorInfo, Location>>.Cons(new Nemerle.Builtins.Tuple<OperatorInfo, Location>(operatorInfo, location), ops);
			}
			else
			{
				PExpr hd3 = parse_embedded_expr(stop);
				exprs = new list<PExpr>.Cons(hd3, exprs);
				opContext = OpContext.Postfix;
			}
			continue;
			IL_04eb:
			opContext = OpContext.Prefix;
			if (ops is list<Nemerle.Builtins.Tuple<OperatorInfo, Location>>.Cons)
			{
				OperatorInfo field3 = ((list<Nemerle.Builtins.Tuple<OperatorInfo, Location>>.Cons)ops).hd.Field0;
				if (field3.Name == "*")
				{
					goto IL_054a;
				}
			}
			ops = new list<Nemerle.Builtins.Tuple<OperatorInfo, Location>>.Cons(hd2, ops);
			goto IL_054a;
		}
		roll_operators(ref exprs, ref ops, 0);
		if (exprs is list<PExpr>.Cons && (object)((list<PExpr>.Cons)exprs).tl == list<PExpr>.Nil._N_constant_object)
		{
			return ((list<PExpr>.Cons)exprs).hd;
		}
		if (!Message.SeenError)
		{
			string text = "something different than one expression after rolling".ToString();
			Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
		}
		throw new AssertionException("ncc\\parsing\\MainParser.n", 2705, "", "something different than one expression after rolling");
	}

	private bool is_operator_or_stoper(Token tok, TokenStoppers stop)
	{
		int result;
		if (!(tok is Token.Keyword))
		{
			result = ((tok is Token.Operator || tok is Token.EndOfGroup || should_stop(tok, stop)) ? 1 : 0);
		}
		else
		{
			string name = ((Token.Keyword)tok).name;
			result = (env.HasOperator(name) ? 1 : 0);
		}
		return (byte)result != 0;
	}

	private PExpr parse_literal()
	{
		Token token = peek_token();
		object obj;
		if (token is Token.Keyword)
		{
			if (((Token.Keyword)token).name == "null")
			{
				obj = new Literal.Null();
			}
			else if (((Token.Keyword)token).name == "true")
			{
				obj = new Literal.Bool(val: true);
			}
			else
			{
				if (!(((Token.Keyword)token).name == "false"))
				{
					goto IL_01e7;
				}
				obj = new Literal.Bool(val: false);
			}
		}
		else if (token is Token.StringLiteral)
		{
			string value = ((Token.StringLiteral)token).value;
			string rawString = ((Token.StringLiteral)token).rawString;
			if (!(value != null))
			{
				throw new AssertionException("ncc\\parsing\\MainParser.n", 2767, "str != null", "");
			}
			Literal.String @string = new Literal.String(value);
			@string.RawString = rawString;
			obj = @string;
		}
		else if (token is Token.CharLiteral)
		{
			char value2 = ((Token.CharLiteral)token).value;
			obj = new Literal.Char(value2);
		}
		else if (token is Token.IntegerLiteral)
		{
			Literal.Integer lit = ((Token.IntegerLiteral)token).lit;
			obj = ((null != lit.treat_as) ? lit : lit.WithProperType());
		}
		else if (token is Token.FloatLiteral)
		{
			float value3 = ((Token.FloatLiteral)token).value;
			obj = new Literal.Float(value3);
		}
		else if (token is Token.DoubleLiteral)
		{
			double value4 = ((Token.DoubleLiteral)token).value;
			obj = new Literal.Double(value4);
		}
		else if (token is Token.DecimalLiteral)
		{
			decimal value5 = ((Token.DecimalLiteral)token).value;
			obj = new Literal.Decimal(value5);
		}
		else
		{
			if (!(token is Token.RoundGroup) || (object)((Token.RoundGroup)token).Child != null)
			{
				goto IL_01e7;
			}
			obj = new Literal.Void();
		}
		goto IL_01e8;
		IL_01e8:
		Literal literal = (Literal)obj;
		object result;
		if (literal != null)
		{
			shift();
			result = new PExpr.Literal(token.Location, literal);
		}
		else
		{
			result = null;
		}
		return (PExpr)result;
		IL_01e7:
		obj = null;
		goto IL_01e8;
	}

	private PExpr.Spliced parse_spliced_expr()
	{
		Splicable splicable_id = get_splicable_id();
		if (splicable_id is Splicable.Expression)
		{
			PExpr expr = ((Splicable.Expression)splicable_id).expr;
			return new PExpr.Spliced(splicable_id.Location, expr);
		}
		Message.Error(splicable_id.Location, "expected spliced expression");
		throw new Recovery();
	}

	private MatchCase parse_match_case()
	{
		Location patternsLocation = default(Location);
		_N_closureOf_parse_match_case_38334 n_closureOf_parse_match_case_ = new _N_closureOf_parse_match_case_38334();
		n_closureOf_parse_match_case_._N__N_closurised_this_ptr_38339 = this;
		Token.LooseGroup looseGroup = (Token.LooseGroup)stream;
		push_stream(looseGroup.Child);
		Token token = peek_token();
		object obj;
		PExpr val;
		if (token is Token.Operator && ((Token.Operator)token).name == "|")
		{
			patternsLocation = ((Token.Operator)token).Location;
			shift();
			option<PExpr> option = maybe_parse_ellipsis();
			if (option is option<PExpr>.Some)
			{
				val = ((option<PExpr>.Some)option).val;
				n_closureOf_parse_match_case_._N_arrowLocation_38341 = peek_token().Location;
				expect_operator("=>");
				token = peek_token();
				if (token is Token.EndOfGroup || (token is Token.Operator && ((Token.Operator)token).name == "|"))
				{
					Error(last_tok, "expecting body of match case");
				}
				obj = new list<PExpr>.Cons(val, list<PExpr>.Nil._N_constant_object);
			}
			else
			{
				if (option != option<PExpr>.None._N_constant_object)
				{
					throw new MatchFailureException();
				}
				obj = _N_loop2_38344(n_closureOf_parse_match_case_, list<PExpr>.Nil._N_constant_object);
			}
		}
		else
		{
			obj = _N_loop2_38344(n_closureOf_parse_match_case_, list<PExpr>.Nil._N_constant_object);
		}
		list<PExpr> list = (list<PExpr>)obj;
		if (!list.IsEmpty)
		{
			patternsLocation += list.Last.Location;
		}
		looseGroup.Child = stream;
		pop_stream();
		list<PExpr> list2 = parse_expr_sequence(TokenStoppers.Pipe);
		object obj2;
		if (list2 is list<PExpr>.Cons)
		{
			if ((object)((list<PExpr>.Cons)list2).tl != list<PExpr>.Nil._N_constant_object)
			{
				goto IL_01cd;
			}
			val = ((list<PExpr>.Cons)list2).hd;
			obj2 = val;
		}
		else
		{
			if ((object)list2 != list<PExpr>.Nil._N_constant_object)
			{
				goto IL_01cd;
			}
			obj2 = fatal_error(last_tok, "match case body cannot be empty");
		}
		goto IL_022f;
		IL_01cd:
		list2 = list2;
		list<PExpr> tail = list2.Tail;
		Location location = list2.Head.Location;
		Function<PExpr, Location, Location> instance = _N__N_lambda__38324__38401.Instance;
		obj2 = new PExpr.Sequence(tail.FoldLeft(location, instance).AsGenerated(), list2);
		goto IL_022f;
		IL_022f:
		val = (PExpr)obj2;
		return new MatchCase(list, val, patternsLocation, n_closureOf_parse_match_case_._N_arrowLocation_38341);
	}

	private PExpr parse_embedded_expr(TokenStoppers stop)
	{
		_N_closureOf_parse_embedded_expr_38602 n_closureOf_parse_embedded_expr_ = new _N_closureOf_parse_embedded_expr_38602();
		n_closureOf_parse_embedded_expr_._N__N_closurised_this_ptr_38611 = this;
		PExpr pExpr = parse_literal();
		PExpr result;
		if (pExpr != null)
		{
			result = pExpr;
			goto IL_193d;
		}
		Token token = get_token();
		Location location = token.Location;
		object obj;
		PExpr pExpr2;
		Token token6;
		Token.RoundGroup roundGroup2;
		list<PExpr> list6;
		object obj4;
		Nemerle.Builtins.Tuple<PExpr, Location> tuple5;
		PExpr pExpr9;
		PExpr pExpr10;
		Token token12;
		list<PExpr> list10;
		checked
		{
			if (token is Token.Identifier)
			{
				string name = ((Token.Identifier)token).name;
				obj = new PExpr.Ref(location, MkName(name, location));
			}
			else if (token is Token.IdentifierToComplete)
			{
				string prefix = ((Token.IdentifierToComplete)token).prefix;
				obj = new PExpr.ToComplete(location, MkName(prefix, location));
			}
			else if (token is Token.Keyword)
			{
				if (((Token.Keyword)token).name == "void")
				{
					obj = new PExpr.Void(location);
				}
				else if (((Token.Keyword)token).name == "this")
				{
					obj = new PExpr.This(location);
				}
				else if (((Token.Keyword)token).name == "base")
				{
					Token token2 = peek_token();
					if (token2 is Token.Operator)
					{
						Token.Operator @operator = (Token.Operator)token2;
						if (((Token.Operator)token2).name == ":")
						{
							Token next = @operator.Next;
							if (next is Token.Identifier)
							{
								get_token();
								location = token.Location + @operator.Next.Location;
								obj = new PExpr.Base(location, parse_expr(stop));
								goto IL_1931;
							}
						}
					}
					obj = new PExpr.Base(location);
				}
				else if (((Token.Keyword)token).name == "_")
				{
					obj = new PExpr.Wildcard(location);
				}
				else if (((Token.Keyword)token).name == "typeof")
				{
					Token token3 = get_token();
					if (token3 is Token.RoundGroup)
					{
						Token.RoundGroup roundGroup = (Token.RoundGroup)token3;
						Token child = ((Token.RoundGroup)token3).Child;
						list<PExpr> list = parse_expr_sequence(child, list<PExpr>.Nil._N_constant_object);
						if (list is list<PExpr>.Cons && (object)((list<PExpr>.Cons)list).tl == list<PExpr>.Nil._N_constant_object)
						{
							PExpr hd = ((list<PExpr>.Cons)list).hd;
							obj = new PExpr.Typeof(location + roundGroup.Location, hd);
						}
						else
						{
							obj = fatal_error(roundGroup.Location, "expecting single type in `typeof (...)'");
						}
					}
					else
					{
						Token tok = token3;
						obj = fatal_error(tok, "expecting `(..)' after `typeof'");
					}
				}
				else if (((Token.Keyword)token).name == "array")
				{
					Token token4 = peek_token();
					object obj2;
					if (token4 is Token.Operator && ((Token.Operator)token4).name == ".")
					{
						shift();
						Token token5 = get_token();
						if (token5 is Token.SquareGroup)
						{
							if ((object)((Token.SquareGroup)token5).Child == null)
							{
								obj2 = new PExpr.Literal(new Literal.Integer(1uL, is_negative: false, null).WithProperType());
							}
							else
							{
								Token child2 = ((Token.SquareGroup)token5).Child;
								list<PExpr> list2 = parse_expr_sequence(child2, list<PExpr>.Nil._N_constant_object);
								if (list2 is list<PExpr>.Cons && (object)((list<PExpr>.Cons)list2).tl == list<PExpr>.Nil._N_constant_object)
								{
									PExpr hd2 = ((list<PExpr>.Cons)list2).hd;
									obj2 = hd2;
								}
								else
								{
									Error(child2, "expecting `[rank]' after `array.'");
									obj2 = new PExpr.Literal(new Literal.Integer(1uL, is_negative: false, null).WithProperType());
								}
							}
						}
						else
						{
							Token tok2 = token5;
							Error(tok2, "expecting `[rank]' after `array.'");
							obj2 = new PExpr.Literal(new Literal.Integer(1uL, is_negative: false, null).WithProperType());
						}
					}
					else
					{
						obj2 = new PExpr.Literal(new Literal.Integer(1uL, is_negative: false, null).WithProperType());
					}
					pExpr2 = (PExpr)obj2;
					token6 = peek_token();
					if (token6 is Token.Operator)
					{
						if (((Token.Operator)token6).name == "$")
						{
							goto IL_051c;
						}
					}
					else
					{
						if (token6 is Token.RoundGroup)
						{
							Token child3 = ((Token.RoundGroup)token6).Child;
							if (!(pExpr2 is PExpr.Literal) || !(((PExpr.Literal)pExpr2).val is Literal.Integer) || ((Literal.Integer)((PExpr.Literal)pExpr2).val).val != 1 || ((Literal.Integer)((PExpr.Literal)pExpr2).val).is_negative || 1 == 0)
							{
								Message.Error(pExpr2.Location, "Invalid array rank: " + Convert.ToString(pExpr2) + ". You can use only '1' in rank of empty array.");
							}
							shift();
							list<PExpr> sizes = parse_expr_sequence(child3);
							obj = new PExpr.EmptyArray(location + token6.Location, sizes);
							goto IL_1931;
						}
						if (token6 is Token.SquareGroup)
						{
							goto IL_051c;
						}
					}
					Token tok3 = token6;
					obj = fatal_error(tok3, "expected [ ..elements of array.. ], ( ..sizes of empty array.. )  or `array .[rank] [..]' in array creation");
				}
				else if (((Token.Keyword)token).name == "ref")
				{
					PExpr pExpr3 = parse_expr(TokenStoppers.All);
					obj = new PExpr.ParmByRef(location + pExpr3.Location, pExpr3);
				}
				else if (((Token.Keyword)token).name == "out")
				{
					PExpr pExpr4 = parse_expr(TokenStoppers.All);
					obj = new PExpr.ParmOut(location + pExpr4.Location, pExpr4);
				}
				else if (((Token.Keyword)token).name == "throw")
				{
					if (stream != null)
					{
						PExpr pExpr5 = parse_expr(stop);
						obj = new PExpr.Throw(location + pExpr5.Location, pExpr5);
					}
					else
					{
						obj = new PExpr.Throw(location, null);
					}
				}
				else if (((Token.Keyword)token).name == "mutable")
				{
					list<PExpr> list3 = list<PExpr>.Nil._N_constant_object;
					list<PExpr> list4 = list<PExpr>.Nil._N_constant_object;
					while (true)
					{
						PExpr pExpr6 = parse_expr(TokenStoppers.All);
						if (pExpr6 is PExpr.Call && ((PExpr.Call)pExpr6).func is PExpr.Ref)
						{
							PExpr.Ref @ref = (PExpr.Ref)((PExpr.Call)pExpr6).func;
							if (((PExpr.Call)pExpr6).parms is list<PExpr>.Cons && ((list<PExpr>.Cons)((PExpr.Call)pExpr6).parms).tl is list<PExpr>.Cons)
							{
								PExpr hd3 = ((list<PExpr>.Cons)((PExpr.Call)pExpr6).parms).hd;
								if ((object)((list<PExpr>.Cons)((list<PExpr>.Cons)((PExpr.Call)pExpr6).parms).tl).tl == list<PExpr>.Nil._N_constant_object)
								{
									PExpr.Ref ref2 = @ref;
									string text = null;
									if (ref2 != null)
									{
										text = ref2.ToString();
									}
									string text2 = text;
									object obj3;
									if (text2 != null)
									{
										PExpr.Ref ref3 = @ref;
										string text3 = null;
										if (ref3 != null)
										{
											text3 = ref3.ToString();
										}
										obj3 = text3;
									}
									else
									{
										obj3 = "";
									}
									string text4 = (string)obj3;
									string text5 = ((@ref == null || text4.Length <= 1 || text4[0] != '=') ? "" : " Maybe you forgot to separate the operator by space?");
									Message.Error(@ref.Location, "Unexpected operator or function call. '" + Convert.ToString(text4) + "'." + Convert.ToString(text5));
									if (!(hd3 is PExpr.Ref))
									{
										Message.Error(@ref.Location, "Expected variable name. See http://nemerle.org/Core_expressions_%28ref%29#Mutable_value_definition. '" + Convert.ToString(text4) + "'." + Convert.ToString(text5));
									}
									list3 = new list<PExpr>.Cons(hd3, list3);
									goto IL_0861;
								}
							}
						}
						list3 = new list<PExpr>.Cons(pExpr6, list3);
						goto IL_0861;
						IL_0861:
						Token token7 = peek_token();
						if (token7 is Token.Operator && ((Token.Operator)token7).name == "=")
						{
							shift();
							PExpr hd4 = parse_expr(stop);
							list4 = new list<PExpr>.Cons(hd4, list4);
						}
						else
						{
							list4 = new list<PExpr>.Cons(null, list4);
						}
						Token token8 = peek_token();
						if (!(token8 is Token.Comma))
						{
							break;
						}
						shift();
					}
					Nemerle.Builtins.Tuple<list<PExpr>, list<PExpr>> tuple = new Nemerle.Builtins.Tuple<list<PExpr>, list<PExpr>>(list3, list4);
					if (tuple.Field0 is list<PExpr>.Cons && (object)((list<PExpr>.Cons)tuple.Field0).tl == list<PExpr>.Nil._N_constant_object)
					{
						PExpr hd5 = ((list<PExpr>.Cons)tuple.Field0).hd;
						if (tuple.Field1 is list<PExpr>.Cons && (object)((list<PExpr>.Cons)tuple.Field1).tl == list<PExpr>.Nil._N_constant_object)
						{
							PExpr hd6 = ((list<PExpr>.Cons)tuple.Field1).hd;
							Location loc = ((hd6 == null) ? (location + hd5.Location) : (location + hd6.Location));
							obj = new PExpr.DefMutable(loc, hd5, hd6);
							goto IL_1931;
						}
					}
					obj = new PExpr.DefMutable(location, PExpr.Tuple.Create(location, list3.Reverse()), PExpr.Tuple.Create(location, list4.Reverse()));
				}
				else if (((Token.Keyword)token).name == "fun")
				{
					Nemerle.Builtins.Tuple<list<PExpr>, PExpr, Location> tuple2 = parse_tyvars();
					Nemerle.Builtins.Tuple<list<PParameter>, Location> tuple3 = parse_parameters(allow_patterns: true, allow_omit: true);
					list<PParameter> list5 = tuple3.Field0;
					Location field = tuple3.Field1;
					Location source = field;
					Location parametersOpenLocation = new Location(source, source.Line, source.Column, source.Line, source.Column + 1);
					Location parametersCloseLocation = new Location(source, source.EndLine, source.EndColumn - 1, source.EndLine, source.EndColumn);
					PExpr pExpr7 = parse_return_type(allow_inference: true, Location.Default);
					Nemerle.Builtins.Tuple<list<PExpr>, PExpr, Location> tuple4 = tuple2;
					Typarms typeParameters = parse_where_constraints(tuple4.Field0, tuple4.Field1, tuple4.Field2);
					PFunHeader pFunHeader = new PFunHeader(location.Combine(field).Combine(pExpr7.Location), typeParameters, MkSplicableName("", token.Location), pExpr7, list5, parametersOpenLocation, parametersCloseLocation);
					PExpr pExpr8 = parse_block(list5);
					obj = new PExpr.Lambda(pFunHeader.Location.Combine(pExpr8.Location), new Function_decl(pFunHeader, pExpr8));
				}
				else
				{
					if (((Token.Keyword)token).name == "match")
					{
						Token token9 = get_token();
						if (token9 is Token.RoundGroup)
						{
							roundGroup2 = (Token.RoundGroup)token9;
							Token child4 = ((Token.RoundGroup)token9).Child;
							if (child4 != null)
							{
								location += roundGroup2.Location;
								list6 = parse_expr_sequence(child4, list<PExpr>.Nil._N_constant_object);
								if (list6 is list<PExpr>.Cons)
								{
									if ((object)((list<PExpr>.Cons)list6).tl != list<PExpr>.Nil._N_constant_object)
									{
										goto IL_0bb4;
									}
									PExpr hd7 = ((list<PExpr>.Cons)list6).hd;
									obj4 = hd7;
								}
								else
								{
									if ((object)list6 != list<PExpr>.Nil._N_constant_object)
									{
										goto IL_0bb4;
									}
									obj4 = fatal_error(child4.Location, "expecting expression inside `match (..)'");
								}
								goto IL_0bf3;
							}
						}
						Token tok4 = token9;
						tuple5 = new Nemerle.Builtins.Tuple<PExpr, Location>(fatal_error(tok4, "expecting non-empty `(..)' after `match'"), Location.Default);
						goto IL_0c29;
					}
					if (((Token.Keyword)token).name == "try")
					{
						pExpr9 = parse_expr();
						pExpr10 = pExpr9;
						if (flag_sibling_keyword("catch"))
						{
							Function<MatchCase, list<TryCase>, list<TryCase>> f = new _N_mktry__38791(n_closureOf_parse_embedded_expr_);
							Token token10 = get_token();
							if (token10 is Token.BracesGroup)
							{
								if (((Token.BracesGroup)token10).Child is Token.LooseGroup)
								{
									Token.LooseGroup newstream = (Token.LooseGroup)((Token.BracesGroup)token10).Child;
									if (((Token.LooseGroup)((Token.BracesGroup)token10).Child).Child is Token.Operator && ((Token.Operator)((Token.LooseGroup)((Token.BracesGroup)token10).Child).Child).name == "..")
									{
										push_stream(newstream);
										option<PExpr> option = maybe_parse_ellipsis();
										if (option is option<PExpr>.Some)
										{
											PExpr val = ((option<PExpr>.Some)option).val;
											pop_stream("catch body");
											pExpr10 = new PExpr.Try(location, pExpr10, new list<TryCase>.Cons(new TryCase.Ellipsis(val), list<TryCase>.Nil._N_constant_object));
											goto IL_109e;
										}
										if (!Message.SeenError)
										{
											string text6 = "(see backtrace)".ToString();
											Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text6) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
										}
										throw new AssertionException("ncc\\parsing\\MainParser.n", 3200, "", "(see backtrace)");
									}
								}
								Token.BracesGroup bracesGroup = (Token.BracesGroup)token10;
								Token child5 = ((Token.BracesGroup)token10).Child;
								n_closureOf_parse_embedded_expr_._N__N_obj_cache_38607 = this;
								Function<MatchCase> f2 = new _N__N_method_lambda__38850(n_closureOf_parse_embedded_expr_);
								list<TryCase> list7 = NList.FoldLeft(process_groups(child5, "exception handlers", f2), list<TryCase>.Nil._N_constant_object, f);
								if ((object)list7 == list<TryCase>.Nil._N_constant_object)
								{
									Error(bracesGroup, "catch body must have at least one handler");
								}
								pExpr10 = new PExpr.Try(location + bracesGroup.Location, pExpr10, list7.Rev());
							}
							else
							{
								Token token11 = token10;
								push_back();
								PExpr handler = parse_expr();
								list<TryCase>.Cons cases = new list<TryCase>.Cons(new TryCase.Catch(Location.Default, MkWildcardSplicableName(Location.Default), new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("System", _N_MacroContexts.Get(2, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Exception", _N_MacroContexts.Get(2, ManagerClass.Instance)))), handler), list<TryCase>.Nil._N_constant_object);
								pExpr10 = new PExpr.Try(location + token11.Location, pExpr10, cases);
							}
						}
						goto IL_109e;
					}
					if (((Token.Keyword)token).name == "def")
					{
						option<PExpr> option2 = maybe_parse_ellipsis();
						if (option2 is option<PExpr>.Some)
						{
							PExpr val2 = ((option<PExpr>.Some)option2).val;
							obj = new PExpr.DefFunctions(location + val2.Location, new list<Function_decl>.Cons(new Function_decl(null, val2), list<Function_decl>.Nil._N_constant_object));
						}
						else
						{
							token12 = peek_token();
							if (token12 is Token.Identifier)
							{
								goto IL_11cc;
							}
							if (token12 is Token.Keyword)
							{
								if (((Token.Keyword)token12).name == "_")
								{
									goto IL_11cc;
								}
							}
							else if (token12 is Token.Operator && ((Token.Operator)token12).name == "$")
							{
								goto IL_11cc;
							}
							PExpr pattern = parse_expr(stop | TokenStoppers.Equal);
							expect_operator("=");
							PExpr pExpr11 = parse_expr(stop);
							obj = new PExpr.Define(location + pExpr11.Location, pattern, pExpr11);
						}
					}
					else
					{
						string name2 = ((Token.Keyword)token).name;
						option<GrammarElement> option3 = env.SyntaxKeywords.Find(name2);
						if (option3 is option<GrammarElement>.Some)
						{
							GrammarElement val3 = ((option<GrammarElement>.Some)option3).val;
							if ((val3.Target & (AttributeTargets)32768) != 0)
							{
								obj = parse_syntax_definition(val3, stop);
								goto IL_1931;
							}
						}
						obj = fatal_error(token, "unexpected keyword in expression context");
					}
				}
			}
			else if (token is Token.Operator)
			{
				if (!(((Token.Operator)token).name == "$"))
				{
					goto IL_1926;
				}
				Token token13 = peek_token();
				if (token13 is Token.StringLiteral)
				{
					Token.StringLiteral stringLiteral = (Token.StringLiteral)token13;
					string value = ((Token.StringLiteral)token13).value;
					string rawString = ((Token.StringLiteral)token13).rawString;
					shift();
					Literal.String @string = new Literal.String(value);
					@string.RawString = rawString;
					PExpr.Literal expr = new PExpr.Literal(stringLiteral.Location, @string);
					PExpr.Call call = new PExpr.Call(new PExpr.Member(new PExpr.Member(new PExpr.Ref(MkNameGenerated("Nemerle")), new Splicable.Name(Name.NameInCurrentColor("IO", _N_MacroContexts.Get(2, ManagerClass.Instance)))), new Splicable.Name(Name.NameInCurrentColor("sprint", _N_MacroContexts.Get(2, ManagerClass.Instance)))), new list<PExpr>.Cons(Macros.QuotationChoose(expr), list<PExpr>.Nil._N_constant_object));
					call.Location = location + stringLiteral.Location;
					obj = call;
				}
				else if (token13 is Token.SquareGroup)
				{
					Token.SquareGroup squareGroup = (Token.SquareGroup)token13;
					Token child6 = ((Token.SquareGroup)token13).Child;
					shift();
					push_stream(child6);
					list<PExpr> list8 = parse_expr_sequence(TokenStoppers.Pipe);
					Token token14 = stream;
					if (token14 is Token.LooseGroup)
					{
						Token.LooseGroup looseGroup = (Token.LooseGroup)token14;
						if (((Token.LooseGroup)token14).Child is Token.Operator && ((Token.Operator)((Token.LooseGroup)token14).Child).name == "|")
						{
							looseGroup.Child = looseGroup.Child.Next;
						}
					}
					list<PExpr> list9 = parse_expr_sequence(TokenStoppers.None);
					list<PExpr> expr2 = list8 + list9;
					pop_stream("list comprehension");
					Location location2 = squareGroup.Location;
					bool flag = location2.FileIndex != 0;
					if (flag)
					{
						LocationStack.Push(location2);
					}
					PExpr.Call call2;
					try
					{
						call2 = new PExpr.Call(new PExpr.Member(new PExpr.Member(new PExpr.Ref(MkNameGenerated("Nemerle")), new Splicable.Name(Name.NameInCurrentColor("Utility", _N_MacroContexts.Get(2, ManagerClass.Instance)))), new Splicable.Name(Name.NameInCurrentColor("ExpandListComprehension", _N_MacroContexts.Get(2, ManagerClass.Instance)))), Macros.QuotationChoose(expr2));
					}
					finally
					{
						if (flag)
						{
							LocationStack.RemoveTop();
						}
					}
					obj = call2;
				}
				else
				{
					push_back();
					obj = parse_spliced_expr();
				}
			}
			else if (token is Token.RoundGroup)
			{
				Token child7 = ((Token.RoundGroup)token).Child;
				list10 = parse_expr_sequence(child7);
				if (!(list10 is list<PExpr>.Cons))
				{
					goto IL_17da;
				}
				list<PExpr>.Cons args = (list<PExpr>.Cons)list10;
				if (((list<PExpr>.Cons)list10).hd is PExpr.Ellipsis)
				{
					if ((object)((list<PExpr>.Cons)list10).tl != list<PExpr>.Nil._N_constant_object)
					{
						goto IL_17da;
					}
					obj = PExpr.Tuple.Create(location, args);
				}
				else if (((list<PExpr>.Cons)list10).hd is PExpr.Tuple)
				{
					PExpr.Tuple tuple6 = (PExpr.Tuple)((list<PExpr>.Cons)list10).hd;
					if ((object)((list<PExpr>.Cons)list10).tl != list<PExpr>.Nil._N_constant_object)
					{
						goto IL_17da;
					}
					tuple6.argsCount = 1;
					obj = tuple6;
				}
				else
				{
					if ((object)((list<PExpr>.Cons)list10).tl != list<PExpr>.Nil._N_constant_object)
					{
						goto IL_17da;
					}
					PExpr hd8 = ((list<PExpr>.Cons)list10).hd;
					obj = hd8;
				}
			}
			else if (token is Token.BracesGroup)
			{
				Token.BracesGroup tok5 = (Token.BracesGroup)token;
				if ((stop & TokenStoppers.Braces) != 0)
				{
					goto IL_1926;
				}
				obj = ParseBlock(tok5, list<PParameter>.Nil._N_constant_object);
			}
			else if (token is Token.SquareGroup)
			{
				Token child8 = ((Token.SquareGroup)token).Child;
				obj = new PExpr.ListLiteral(location, parse_expr_sequence(child8));
			}
			else
			{
				if (!(token is Token.QuoteGroup))
				{
					goto IL_1926;
				}
				Token child9 = ((Token.QuoteGroup)token).Child;
				push_stream(child9);
				PExpr pExpr12 = parse_quotation();
				pop_stream("code quotation");
				obj = pExpr12;
			}
			goto IL_1931;
		}
		IL_193d:
		return result;
		IL_109e:
		if (flag_sibling_keyword("finally"))
		{
			PExpr pExpr13 = parse_expr();
			pExpr10 = new PExpr.TryFinally(location.Combine(pExpr13.Location), pExpr10, pExpr13);
		}
		if (pExpr10 == pExpr9)
		{
			Message.Error(location, "expecting `catch' or `finally'");
		}
		obj = pExpr10;
		goto IL_1931;
		IL_1926:
		obj = fatal_error(token, "expecting expression");
		goto IL_1931;
		IL_1400:
		Token token15;
		Token tok6 = token15;
		obj = fatal_error(tok6, "expecting `def x = expr' or `def f () { .. }'");
		goto IL_1931;
		IL_0c29:
		Nemerle.Builtins.Tuple<PExpr, Location> tuple7 = tuple5;
		PExpr field2 = tuple7.Field0;
		Location field3 = tuple7.Field1;
		Token token16 = get_token();
		if (token16 is Token.BracesGroup)
		{
			if (((Token.BracesGroup)token16).Child is Token.LooseGroup)
			{
				Token.LooseGroup newstream2 = (Token.LooseGroup)((Token.BracesGroup)token16).Child;
				if (((Token.LooseGroup)((Token.BracesGroup)token16).Child).Child is Token.Operator && ((Token.Operator)((Token.LooseGroup)((Token.BracesGroup)token16).Child).Child).name == "..")
				{
					push_stream(newstream2);
					option<PExpr> option4 = maybe_parse_ellipsis();
					if (option4 is option<PExpr>.Some)
					{
						PExpr val4 = ((option<PExpr>.Some)option4).val;
						pop_stream("match body");
						obj = new PExpr.Match(location, field2, new list<MatchCase>.Cons(new MatchCase(list<PExpr>.Nil._N_constant_object, val4), list<MatchCase>.Nil._N_constant_object), field3);
						goto IL_1931;
					}
					if (!Message.SeenError)
					{
						string text7 = "(see backtrace)".ToString();
						Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text7) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
					}
					throw new AssertionException("ncc\\parsing\\MainParser.n", 3121, "", "(see backtrace)");
				}
			}
			Token.BracesGroup bracesGroup2 = (Token.BracesGroup)token16;
			Token child10 = ((Token.BracesGroup)token16).Child;
			Location loc2 = location.Combine(bracesGroup2.Location);
			n_closureOf_parse_embedded_expr_._N__N_obj_cache_38609 = this;
			Function<MatchCase> f3 = new _N__N_method_lambda__38779(n_closureOf_parse_embedded_expr_);
			obj = new PExpr.Match(loc2, field2, process_groups(child10, "match body", f3), field3);
		}
		else
		{
			Token token17 = token16;
			Message.Error(token17.Location, "expecting '{' after 'match (e)'");
			obj = field2;
		}
		goto IL_1931;
		IL_0bf3:
		PExpr field4 = (PExpr)obj4;
		tuple5 = new Nemerle.Builtins.Tuple<PExpr, Location>(field4, roundGroup2.Location);
		goto IL_0c29;
		IL_17da:
		list<PExpr> args2 = list10;
		obj = PExpr.Tuple.Create(location, args2);
		goto IL_1931;
		IL_0bb4:
		list<PExpr> list11 = list6;
		obj4 = PExpr.Tuple.Create(location, list11.Reverse());
		goto IL_0bf3;
		IL_1931:
		PExpr pExpr14 = (PExpr)obj;
		pExpr14.Token = token;
		result = pExpr14;
		goto IL_193d;
		IL_051c:
		obj = new PExpr.Array(location + token6.Location, pExpr2, parse_embedded_expr(TokenStoppers.All));
		goto IL_1931;
		IL_11cc:
		Splicable splicable_id = get_splicable_id();
		token15 = peek_token();
		if (token15 is Token.Operator)
		{
			PExpr pExpr16;
			if (((Token.Operator)token15).name == ":")
			{
				shift();
				PExpr pExpr15 = parse_expr(stop | TokenStoppers.Equal);
				expect_operator("=");
				pExpr16 = pExpr15;
			}
			else
			{
				if (!(((Token.Operator)token15).name == "="))
				{
					goto IL_1400;
				}
				pExpr16 = null;
			}
			Manager.CompleteTypeRef(pExpr16, null, env);
			object obj5;
			if (pExpr16 == null)
			{
				shift();
				obj5 = parse_expr(stop);
			}
			else
			{
				PExpr pExpr17 = parse_expr(stop);
				obj5 = new PExpr.TypeEnforcement(pExpr16.Location.Combine(pExpr17.Location), pExpr17, pExpr16);
			}
			PExpr pExpr18 = (PExpr)obj5;
			object obj6;
			if (splicable_id is Splicable.Name)
			{
				Name body = ((Splicable.Name)splicable_id).body;
				obj6 = new PExpr.Ref(token12.Location, body);
			}
			else if (splicable_id is Splicable.Expression)
			{
				PExpr expr3 = ((Splicable.Expression)splicable_id).expr;
				obj6 = new PExpr.Spliced(location, expr3);
			}
			else
			{
				if (!(splicable_id is Splicable.HalfId))
				{
					throw new MatchFailureException();
				}
				Name prefix2 = ((Splicable.HalfId)splicable_id).prefix;
				obj6 = new PExpr.ToComplete(location, prefix2);
			}
			PExpr pattern2 = (PExpr)obj6;
			obj = new PExpr.Define(location + pExpr18.Location, pattern2, pExpr18);
		}
		else
		{
			if (!(token15 is Token.RoundGroup) && !(token15 is Token.SquareGroup))
			{
				goto IL_1400;
			}
			list<Function_decl> tl = list<Function_decl>.Nil._N_constant_object;
			Splicable name3 = splicable_id;
			Function_decl hd9;
			while (true)
			{
				PFunHeader pFunHeader2 = parse_fun_header(name3, allow_patterns: true);
				PExpr pExpr19 = parse_block(pFunHeader2.Parameters);
				hd9 = new Function_decl(location + pFunHeader2.Location + pExpr19.Location, pFunHeader2, pExpr19);
				if (!flag_sibling_keyword("and"))
				{
					break;
				}
				list<Function_decl> obj7 = new list<Function_decl>.Cons(hd9, tl);
				name3 = get_splicable_id();
				tl = obj7;
			}
			list<Function_decl> list12 = new list<Function_decl>.Cons(hd9, tl).Rev();
			Location loc3 = Location.EnclosingLocation(list12);
			obj = new PExpr.DefFunctions(loc3, list12);
		}
		goto IL_1931;
	}

	private PExpr parse_quotation()
	{
		_N_closureOf_parse_quotation_38964 n_closureOf_parse_quotation_ = new _N_closureOf_parse_quotation_38964();
		n_closureOf_parse_quotation_._N__N_closurised_this_ptr_38971 = this;
		Token token = peek_token();
		Token.Identifier identifier;
		string name;
		if (token is Token.LooseGroup)
		{
			n_closureOf_parse_quotation_._N_group_38973 = (Token.LooseGroup)token;
			if (((Token.LooseGroup)token).Child is Token.Identifier)
			{
				identifier = (Token.Identifier)((Token.LooseGroup)token).Child;
				name = ((Token.Identifier)((Token.LooseGroup)token).Child).name;
				if (identifier.Next != null)
				{
					Token next = identifier.Next;
					if (next is Token.Operator && ((Token.Operator)next).name == ":")
					{
						goto IL_00bb;
					}
				}
				else if (false)
				{
					goto IL_00bb;
				}
			}
		}
		list<PExpr> list = parse_expr_sequence(TokenStoppers.None);
		object obj;
		PExpr hd;
		if (list is list<PExpr>.Cons && (object)((list<PExpr>.Cons)list).tl == list<PExpr>.Nil._N_constant_object)
		{
			hd = ((list<PExpr>.Cons)list).hd;
			obj = hd;
		}
		else
		{
			obj = new PExpr.Sequence(token.Location, list);
		}
		hd = (PExpr)obj;
		PExpr.Quoted result = new PExpr.Quoted(hd.Location, new SyntaxElement.Expression(hd));
		goto IL_0354;
		IL_00bb:
		n_closureOf_parse_quotation_._N_group_38973.Child = identifier.Next.Next;
		object obj2;
		bool flag;
		List<ClassMember> list2;
		bool flag2;
		switch (name)
		{
		case "ttype":
			list = parse_expr_sequence(TokenStoppers.None);
			if (list is list<PExpr>.Cons && (object)((list<PExpr>.Cons)list).tl == list<PExpr>.Nil._N_constant_object)
			{
				hd = ((list<PExpr>.Cons)list).hd;
				obj2 = new SyntaxElement.TType(hd);
			}
			else
			{
				Error(n_closureOf_parse_quotation_._N_group_38973, "expecting single type in quotated code");
				obj2 = new SyntaxElement.TType(null);
			}
			break;
		case "fundecl":
		{
			Function<Function_decl> f2 = new _N__N_lambda__38945__39008(n_closureOf_parse_quotation_);
			Function_decl body = _N_push_38990(n_closureOf_parse_quotation_, "quoted function", f2);
			obj2 = new SyntaxElement.Function(body);
			break;
		}
		case "case":
			obj2 = new SyntaxElement.MatchCase(parse_match_case());
			break;
		case "parameter":
		{
			n_closureOf_parse_quotation_._N__N_obj_cache_38969 = this;
			Function<PParameter> f = new _N__N_method_lambda__39017(n_closureOf_parse_quotation_);
			obj2 = new SyntaxElement.Parameter(_N_push_38990(n_closureOf_parse_quotation_, "quoted parameter", f));
			break;
		}
		case "variant_option":
			flag = true;
			goto IL_01e6;
		case "decl":
			flag = false;
			goto IL_01e6;
		default:
			{
				obj2 = new SyntaxElement.Expression(fatal_error(identifier, "bad quotation type"));
				break;
			}
			IL_01e6:
			list2 = new List<ClassMember>();
			flag2 = in_variant;
			if (flag)
			{
				in_variant = true;
			}
			ParseClassMember("decl", list2);
			if (flag)
			{
				in_variant = flag2;
			}
			if (list2.Count == 1)
			{
				obj2 = new SyntaxElement.ClassMember(list2[0]);
			}
			else if (list2.Count > 1)
			{
				Message.Error(list2[1].Location, "expecting single member declaration in quotated code (autoproperty & embeded fields not allowed here)");
				obj2 = new SyntaxElement.ClassMember(list2[0]);
			}
			else
			{
				obj2 = new SyntaxElement.Expression(fatal_error(n_closureOf_parse_quotation_._N_group_38973, "expecting single member declaration in quotated code"));
			}
			break;
		}
		SyntaxElement body2 = (SyntaxElement)obj2;
		result = new PExpr.Quoted(identifier.Location, body2);
		goto IL_0354;
		IL_0354:
		return result;
	}

	private list<PExpr> parse_expr_sequence(TokenStoppers stop)
	{
		return NList.Rev(parse_expr_sequence(stop, list<PExpr>.Nil._N_constant_object));
	}

	private list<PExpr> parse_expr_sequence(Token group)
	{
		return NList.Rev(parse_expr_sequence(group, list<PExpr>.Nil._N_constant_object));
	}

	private list<PExpr> parse_expr_sequence(Token group, list<PExpr> acc)
	{
		push_stream(group);
		list<PExpr> result = parse_expr_sequence(TokenStoppers.None, acc);
		pop_stream("group of expressions");
		return result;
	}

	private list<PExpr> parse_expr_sequence(TokenStoppers stop, list<PExpr> result)
	{
		_N_closureOf_parse_expr_sequence_39101 n_parse_expr_sequence_cp_ = new _N_closureOf_parse_expr_sequence_39101();
		while (!should_stop(stop))
		{
			Token.LooseGroup looseGroup = (Token.LooseGroup)stream;
			Token newstream = _N_makeStrsConcat_39120(n_parse_expr_sequence_cp_, looseGroup.Child, prevDollarised: false);
			push_stream(newstream);
			result = new list<PExpr>.Cons(parse_expr(stop), result);
			if (stream == null || !should_stop(stop))
			{
				if (stream != null)
				{
					Message.Error(stream.Location, "expected `;'");
				}
				pop_stream("expression in sequence");
				shift();
				continue;
			}
			newstream = stream;
			pop_stream();
			((Token.LooseGroup)stream).Child = newstream;
			break;
		}
		return result;
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
		Nemerle.Collections.Stack<Token> stack = streams_stack;
		if (stack != null)
		{
			foreach (Token item in stack)
			{
				Token token = item;
				((ISupportRelocation)token).RelocateImpl(_info);
			}
		}
		last_tok?.RelocateImplInternal(_info);
		stream?.RelocateImplInternal(_info);
	}

	void ISupportRelocation.RelocateImpl(RelocationInfo _info)
	{
		//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
		this.RelocateImplInternal(_info);
	}

	private void _N_eat_definition_35198(_N_closureOf_parse_top_extensions_35169 _N_parse_top_extensions_cp_35197, SyntaxDefinition definition)
	{
		PExpr.MacroCall expr = new PExpr.MacroCall(_N_parse_top_extensions_cp_35197._N_tok_35180.Location, MkNameGenerated(""), definition.MacroNamespace, definition.Permute.apply(_N_parse_top_extensions_cp_35197._N_parms_35178));
		_N_parse_top_extensions_cp_35197._N_modifiers_35176.AddCustomAttribute(expr);
	}

	private void _N_expect_semicolon_35386(_N_closureOf_parse_grammar_rule_35374 _N_parse_grammar_rule_cp_35385)
	{
		if (stream == null)
		{
			jump_to_sibling();
			return;
		}
		Token token = stream;
		if (token is Token.Semicolon)
		{
			shift();
		}
		else
		{
			Error(stream, "expected `;'");
		}
	}

	private Nemerle.Builtins.Tuple<GrammarElement, list<SyntaxElement>> _N_loop_35401(_N_closureOf_parse_grammar_rule_35374 _N_parse_grammar_rule_cp_35400, list<SyntaxElement> acc, GrammarElement x)
	{
		Nemerle.Builtins.Tuple<GrammarElement, list<SyntaxElement>> result;
		while (true)
		{
			_N_closureOf_loop_35407 n_closureOf_loop_ = new _N_closureOf_loop_35407();
			if (x == null)
			{
				throw new AssertionException("ncc\\parsing\\MainParser-Extensions.n", 365, "x != null", "");
			}
			if ((x.Target & _N_parse_grammar_rule_cp_35400._N_target_35381) == 0)
			{
				Message.Error(last_tok.Location, "parse error, none of syntax definitions matches input");
				throw new Recovery();
			}
			GrammarElement next = x.Next;
			Token.LooseGroup looseGroup;
			Token token;
			if (x is GrammarElement.Operator)
			{
				if (((GrammarElement.Operator)x).name == "[")
				{
					n_closureOf_loop_._N_brace_35412 = ((GrammarElement.Operator)x).name;
				}
				else
				{
					if (!(((GrammarElement.Operator)x).name == "("))
					{
						if (((GrammarElement.Operator)x).name == "]" || ((GrammarElement.Operator)x).name == ")")
						{
							result = new Nemerle.Builtins.Tuple<GrammarElement, list<SyntaxElement>>(x, NList.Rev(acc));
							break;
						}
						if (((GrammarElement.Operator)x).name == ";")
						{
							_N_expect_semicolon_35386(_N_parse_grammar_rule_cp_35400);
							list<SyntaxElement> obj = acc;
							x = next;
							acc = obj;
						}
						else
						{
							string name = ((GrammarElement.Operator)x).name;
							expect_operator(name);
							list<SyntaxElement> obj2 = acc;
							x = next;
							acc = obj2;
						}
						continue;
					}
					n_closureOf_loop_._N_brace_35412 = ((GrammarElement.Operator)x).name;
				}
				token = get_token();
				if (token is Token.RoundGroup)
				{
					if (((Token.RoundGroup)token).Child is Token.LooseGroup)
					{
						looseGroup = (Token.LooseGroup)((Token.RoundGroup)token).Child;
						token = ((Token.LooseGroup)((Token.RoundGroup)token).Child).Child;
						if (n_closureOf_loop_._N_brace_35412 == "(")
						{
							goto IL_0101;
						}
					}
				}
				else
				{
					if (!(token is Token.SquareGroup))
					{
						Error(token, "expecting `" + Convert.ToString(n_closureOf_loop_._N_brace_35412) + "' and some tokens inside");
						list<SyntaxElement> obj3 = acc;
						x = next;
						acc = obj3;
						continue;
					}
					if (((Token.SquareGroup)token).Child is Token.LooseGroup)
					{
						looseGroup = (Token.LooseGroup)((Token.SquareGroup)token).Child;
						token = ((Token.LooseGroup)((Token.SquareGroup)token).Child).Child;
						if (n_closureOf_loop_._N_brace_35412 == "[")
						{
							goto IL_0101;
						}
					}
				}
				list<SyntaxElement> obj4 = acc;
				x = _N_expect_close_35441(n_closureOf_loop_, _N_parse_grammar_rule_cp_35400, next.Next);
				acc = obj4;
				continue;
			}
			if (x is GrammarElement.Keyword)
			{
				string name = ((GrammarElement.Keyword)x).name;
				if (!flag_sibling_keyword(name))
				{
					Error(peek_token(), "expected `" + Convert.ToString(name) + "' keyword");
				}
				list<SyntaxElement> obj5 = acc;
				x = next;
				acc = obj5;
				continue;
			}
			if (x is GrammarElement.Expression)
			{
				PExpr body = parse_expr(_N_parse_grammar_rule_cp_35400._N_stop_35383);
				list<SyntaxElement> obj6 = new list<SyntaxElement>.Cons(new SyntaxElement.Expression(body), acc);
				x = next;
				acc = obj6;
				continue;
			}
			if (x is GrammarElement.Parameter)
			{
				PParameter body2 = parse_parameter();
				list<SyntaxElement> obj7 = new list<SyntaxElement>.Cons(new SyntaxElement.Parameter(body2), acc);
				x = next;
				acc = obj7;
				continue;
			}
			if (x is GrammarElement.RawToken)
			{
				if (stream == null)
				{
					Error(last_tok, "expecting some tokens after this one");
					list<SyntaxElement> obj8 = acc;
					x = next;
					acc = obj8;
					continue;
				}
				new_group_beginning();
				pop_stream("raw token");
				token = get_token();
				push_stream(stream);
				stream = null;
				list<SyntaxElement> obj9 = new list<SyntaxElement>.Cons(new SyntaxElement.RawToken(token), acc);
				x = next;
				acc = obj9;
				continue;
			}
			if (x is GrammarElement.ExpressionList)
			{
				if (!Message.SeenError)
				{
					string name = "expr list?".ToString();
					Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(name) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
				}
				throw new AssertionException("ncc\\parsing\\MainParser-Extensions.n", 447, "", "expr list?");
			}
			list<SyntaxElement> list;
			if (x is GrammarElement.Optional)
			{
				if (((GrammarElement.Optional)x).body is GrammarElement.Expression)
				{
					GrammarElement.Expression tre = (GrammarElement.Expression)((GrammarElement.Optional)x).body;
					list = ((!matches_stream(next)) ? new list<SyntaxElement>.Cons(new SyntaxElement.Expression(parse_expr(_N_parse_grammar_rule_cp_35400._N_stop_35383)), acc) : create_optional_holders(tre, acc));
					list<SyntaxElement> obj10 = list;
					x = next;
					acc = obj10;
					continue;
				}
				GrammarElement body3 = ((GrammarElement.Optional)x).body;
				if (matches_stream(body3))
				{
					list = parse_grammar_rule(body3, _N_parse_grammar_rule_cp_35400._N_stop_35383, _N_parse_grammar_rule_cp_35400._N_target_35381).Field1;
					list<SyntaxElement> obj11 = NList.RevAppend(list, acc);
					x = next;
					acc = obj11;
				}
				else
				{
					list<SyntaxElement> obj12 = create_optional_holders(body3, acc);
					x = next;
					acc = obj12;
				}
				continue;
			}
			if (x is GrammarElement.Branch)
			{
				list<GrammarElement> list2 = ((GrammarElement.Branch)x).options;
				next = null;
				list<GrammarElement> list3 = list2;
				while (true)
				{
					if ((object)list3 == list<GrammarElement>.Nil._N_constant_object)
					{
						if (next == null)
						{
							Message.Error(last_tok.Location, "parse error, none of syntax definitions matches input: " + list2.ToString());
							throw new Recovery();
						}
						result = new Nemerle.Builtins.Tuple<GrammarElement, list<SyntaxElement>>(next, NList.Rev(acc));
						break;
					}
					if (list3 is list<GrammarElement>.Cons)
					{
						GrammarElement body3 = ((list<GrammarElement>.Cons)list3).hd;
						list<GrammarElement> list4 = ((list<GrammarElement>.Cons)list3).tl;
						if ((body3.Target & _N_parse_grammar_rule_cp_35400._N_target_35381) != 0)
						{
							if (body3 is GrammarElement.End)
							{
								next = ((next == null) ? ((GrammarElement.End)body3) : x);
								list3 = list4;
								continue;
							}
							if (matches_stream(body3))
							{
								result = _N_loop_35401(_N_parse_grammar_rule_cp_35400, acc, body3);
								break;
							}
							list3 = list4;
						}
						else
						{
							list3 = ((list<GrammarElement>.Cons)list3).tl;
							list3 = list3;
						}
						continue;
					}
					throw new MatchFailureException();
				}
				break;
			}
			if (x is GrammarElement.End)
			{
				result = new Nemerle.Builtins.Tuple<GrammarElement, list<SyntaxElement>>(x, NList.Rev(acc));
				break;
			}
			throw new MatchFailureException();
			IL_0101:
			if (next is GrammarElement.ExpressionList)
			{
				list<PExpr> list5 = parse_expr_sequence(looseGroup);
				Function<PExpr, SyntaxElement> instance = _N__N_lambda__35344__35461.Instance;
				list<SyntaxElement> obj13 = list5.RevMap(instance) + acc;
				x = _N_expect_close_35441(n_closureOf_loop_, _N_parse_grammar_rule_cp_35400, next.Next);
				acc = obj13;
				continue;
			}
			push_stream(looseGroup);
			push_stream(token);
			Nemerle.Builtins.Tuple<GrammarElement, list<SyntaxElement>> tuple = parse_grammar_rule(next, TokenStoppers.None, _N_parse_grammar_rule_cp_35400._N_target_35381);
			next = tuple.Field0;
			list = tuple.Field1;
			pop_stream("tokens inside of " + Convert.ToString(n_closureOf_loop_._N_brace_35412) + "...");
			shift();
			pop_stream("end of " + Convert.ToString(n_closureOf_loop_._N_brace_35412) + "...");
			list<SyntaxElement> obj14 = NList.RevAppend(list, acc);
			x = _N_expect_close_35441(n_closureOf_loop_, _N_parse_grammar_rule_cp_35400, next);
			acc = obj14;
		}
		return result;
	}

	private GrammarElement _N_expect_close_35441(_N_closureOf_loop_35407 _N_loop_cp_35439, _N_closureOf_parse_grammar_rule_35374 _N_parse_grammar_rule_cp_35440, GrammarElement el)
	{
		GrammarElement result;
		if (el is GrammarElement.Operator)
		{
			GrammarElement.Operator @operator = (GrammarElement.Operator)el;
			if (!(((GrammarElement.Operator)el).name == ")"))
			{
				if (!(((GrammarElement.Operator)el).name == "]"))
				{
					goto IL_005a;
				}
				@operator = (GrammarElement.Operator)el;
			}
			result = @operator.Next;
			goto IL_0087;
		}
		goto IL_005a;
		IL_0087:
		return result;
		IL_005a:
		Error(last_tok, "error parsing `" + Convert.ToString(_N_loop_cp_35439._N_brace_35412) + "...' syntax rule");
		result = el;
		goto IL_0087;
	}

	private TopDeclaration _N_processType_36370(_N_closureOf_ParseTypeDeclaration_36358 _N_ParseTypeDeclaration_cp_36369, string key)
	{
		_N_closureOf_processType_36376 n_closureOf_processType_ = new _N_closureOf_processType_36376();
		Splicable splicable_id = get_splicable_id();
		n_closureOf_processType_._N_end_loc_36381 = splicable_id.Location;
		Nemerle.Builtins.Tuple<list<PExpr>, PExpr, Location> tuple = parse_tyvars();
		Location field = tuple.Field2;
		if (field != Location.Default)
		{
			n_closureOf_processType_._N_end_loc_36381 = field;
		}
		Token token = peek_token();
		object obj;
		if (token is Token.Operator)
		{
			Token.Operator @operator = (Token.Operator)token;
			if (((Token.Operator)token).name == ":")
			{
				shift();
				Token token2 = peek_token();
				if (token2 == null || token2 is Token.BracesGroup || false || ((token2 is Token.Keyword && ((Token.Keyword)token2).name == "where") ? true : false))
				{
					_N_errTypeExpected_36394(n_closureOf_processType_, @operator.Location);
					obj = list<PExpr>.Nil._N_constant_object;
				}
				else
				{
					option<PExpr> option = maybe_parse_ellipsis();
					if (option is option<PExpr>.Some)
					{
						PExpr val = ((option<PExpr>.Some)option).val;
						obj = new list<PExpr>.Cons(val, list<PExpr>.Nil._N_constant_object);
					}
					else
					{
						Function<PExpr> f = new _N__N_lambda__36271__36420(_N_ParseTypeDeclaration_cp_36369);
						list<PExpr> list = comma_separated_list(f);
						Function<PExpr, bool> instance = _N__N_lambda__36276__36434.Instance;
						option<PExpr> option2 = list.Find(instance);
						if (option2 is option<PExpr>.Some)
						{
							PExpr val2 = ((option<PExpr>.Some)option2).val;
							push_back();
							_N_errTypeExpected_36394(n_closureOf_processType_, val2.Location);
							Function<PExpr, bool> instance2 = _N__N_lambda__36282__36453.Instance;
							obj = list.Filter(instance2);
						}
						else
						{
							obj = list;
						}
					}
				}
				goto IL_01b2;
			}
		}
		obj = list<PExpr>.Nil._N_constant_object;
		goto IL_01b2;
		IL_01b2:
		list<PExpr> list2 = (list<PExpr>)obj;
		if (!((!(list2 != null)) ? list<PExpr>.Nil._N_constant_object : list2).IsEmpty)
		{
			n_closureOf_processType_._N_end_loc_36381 = list2.Last.Location;
		}
		Nemerle.Builtins.Tuple<list<PExpr>, PExpr, Location> tuple2 = tuple;
		Typarms typarms = parse_where_constraints(tuple2.Field0, tuple2.Field1, tuple2.Field2);
		parse_top_extensions(_N_ParseTypeDeclaration_cp_36369._N_mods_36367, AttributeTargets.Class);
		List<ClassMember> list3 = new List<ClassMember>();
		Token.BracesGroup bodyBracesGroup = null;
		if (!(key == "type"))
		{
			Token token3 = get_token();
			if (token3 is Token.BracesGroup)
			{
				Token.BracesGroup bracesGroup = (Token.BracesGroup)token3;
				Token child = ((Token.BracesGroup)token3).Child;
				bodyBracesGroup = bracesGroup;
				n_closureOf_processType_._N_end_loc_36381 = bracesGroup.Location;
				push_stream(child);
				option<PExpr> option3 = maybe_parse_ellipsis();
				if (option3 is option<PExpr>.Some)
				{
					PExpr val3 = ((option<PExpr>.Some)option3).val;
					pop_stream();
					list3.Add(new ClassMember.Field(val3.Location, null, null, val3));
				}
				else
				{
					pop_stream();
					bool flag = in_variant;
					if (key == "variant")
					{
						in_variant = true;
					}
					list3 = ParseClassMembers<object>(child, key);
					list3.RemoveAll(_N__N_lambda__36297_36495);
					in_variant = flag;
				}
			}
			else
			{
				Token tok = token3;
				Error(tok, "expecting type body");
				push_back();
			}
		}
		list<ClassMember> list4 = list3.NToList();
		Location loc = _N_ParseTypeDeclaration_cp_36369._N_startLocation_36365 + n_closureOf_processType_._N_end_loc_36381;
		object obj2;
		switch (key)
		{
		case "class":
			obj2 = new TopDeclaration.Class(loc, splicable_id, _N_ParseTypeDeclaration_cp_36369._N_mods_36367, typarms, list2, list4);
			break;
		case "struct":
			_N_ParseTypeDeclaration_cp_36369._N_mods_36367.mods = _N_ParseTypeDeclaration_cp_36369._N_mods_36367.mods | NemerleModifiers.Struct;
			obj2 = new TopDeclaration.Class(loc, splicable_id, _N_ParseTypeDeclaration_cp_36369._N_mods_36367, typarms, list2, list4);
			break;
		case "module":
			_N_ParseTypeDeclaration_cp_36369._N_mods_36367.mods = _N_ParseTypeDeclaration_cp_36369._N_mods_36367.mods | NemerleModifiers.Static;
			foreach (ClassMember item in list3)
			{
				ClassMember classMember = item;
				if (!(classMember is ClassMember.TypeDeclaration) && 0 == 0 && classMember.modifiers != null)
				{
					AttributesAndModifiers modifiers = classMember.modifiers;
					modifiers.mods |= NemerleModifiers.Static;
				}
			}
			obj2 = new TopDeclaration.Class(loc, splicable_id, _N_ParseTypeDeclaration_cp_36369._N_mods_36367, typarms, list2, list4);
			break;
		case "type":
		{
			expect_operator("=");
			PExpr ty = parse_expr();
			expect_empty("type alias declaration");
			obj2 = new TopDeclaration.Alias(loc, splicable_id, _N_ParseTypeDeclaration_cp_36369._N_mods_36367, typarms, ty);
			break;
		}
		case "interface":
			obj2 = new TopDeclaration.Interface(loc, splicable_id, _N_ParseTypeDeclaration_cp_36369._N_mods_36367, typarms, list2, list4);
			break;
		case "variant":
			obj2 = new TopDeclaration.Variant(loc, splicable_id, _N_ParseTypeDeclaration_cp_36369._N_mods_36367, typarms, list2, list4);
			break;
		case "enum":
			obj2 = new TopDeclaration.Enum(loc, splicable_id, _N_ParseTypeDeclaration_cp_36369._N_mods_36367, typarms, list2, list4);
			break;
		default:
			if (!Message.SeenError)
			{
				string text = "(see backtrace)".ToString();
				Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
			}
			throw new AssertionException("ncc\\parsing\\MainParser.n", 1004, "", "(see backtrace)");
		}
		TopDeclaration topDeclaration = (TopDeclaration)obj2;
		InitBodyLocations(topDeclaration, bodyBracesGroup);
		if (field != Location.Default)
		{
			topDeclaration._headerLocation = _N_ParseTypeDeclaration_cp_36369._N_startLocation_36365 + field;
			topDeclaration._typeParametersLocation = field;
		}
		else
		{
			topDeclaration._headerLocation = _N_ParseTypeDeclaration_cp_36369._N_startLocation_36365 + splicable_id.Location;
		}
		foreach (ClassMember item2 in list3)
		{
			if (item2 is ClassMember.TypeDeclaration)
			{
				TopDeclaration td = ((ClassMember.TypeDeclaration)item2).td;
				item2._definedIn = topDeclaration;
				td._definedIn = topDeclaration;
				continue;
			}
			if (item2 is ClassMember.Property)
			{
				ClassMember.Function val6;
				if (((ClassMember.Property)item2).getter is option<ClassMember.Function>.Some)
				{
					if (((ClassMember.Property)item2).setter is option<ClassMember.Function>.Some)
					{
						ClassMember.Function val4 = ((option<ClassMember.Function>.Some)((ClassMember.Property)item2).getter).val;
						ClassMember.Function val5 = ((option<ClassMember.Function>.Some)((ClassMember.Property)item2).setter).val;
						item2._definedIn = topDeclaration;
						val4._definedIn = topDeclaration;
						val5._definedIn = topDeclaration;
						continue;
					}
					val6 = ((option<ClassMember.Function>.Some)((ClassMember.Property)item2).getter).val;
				}
				else
				{
					if (!(((ClassMember.Property)item2).setter is option<ClassMember.Function>.Some))
					{
						goto IL_0732;
					}
					val6 = ((option<ClassMember.Function>.Some)((ClassMember.Property)item2).setter).val;
				}
				item2._definedIn = topDeclaration;
				val6._definedIn = topDeclaration;
				continue;
			}
			goto IL_0732;
			IL_0732:
			item2._definedIn = topDeclaration;
		}
		topDeclaration.name = splicable_id;
		topDeclaration.Location = _N_ParseTypeDeclaration_cp_36369._N_startLocation_36365 + n_closureOf_processType_._N_end_loc_36381;
		return topDeclaration;
	}

	private static void _N_errTypeExpected_36394(_N_closureOf_processType_36376 _N_processType_cp_36393, Location loc)
	{
		Message.Error(loc, "Type expected");
		_N_processType_cp_36393._N_end_loc_36381 = loc;
	}

	private static bool _N__N_lambda__36297_36495(ClassMember _N__36296)
	{
		return (_N__36296 is ClassMember.TypeDeclaration && ((ClassMember.TypeDeclaration)_N__36296).td is TopDeclaration.Delegate && (object)((TopDeclaration.Delegate)((ClassMember.TypeDeclaration)_N__36296).td).header == null) ? true : false;
	}

	private void _N_parseNestedTypeDeclaration_36643(_N_closureOf_ParseClassMember_36615 _N_ParseClassMember_cp_36642)
	{
		take_attributes_out(ref _N_ParseClassMember_cp_36642._N_customs_36622, AttributeTargets.Class, comply_on_other: true, _N_ParseClassMember_cp_36642._N_mods_36620);
		TopDeclaration topDeclaration = ParseTypeDeclaration(_N_ParseClassMember_cp_36642._N_mods_36620, _N_ParseClassMember_cp_36642._N_start_tok_36626.Location.FromStart());
		ClassMember.TypeDeclaration typeDeclaration = new ClassMember.TypeDeclaration(topDeclaration.Location, topDeclaration.name, topDeclaration.modifiers, topDeclaration);
		if (typeDeclaration != null)
		{
			_N_ParseClassMember_cp_36642._N_members_36628.Add(typeDeclaration);
		}
	}

	private ClassMember _N_make_option_36850(_N_closureOf_parse_option_36840 _N_parse_option_cp_36849, Splicable id, Token children, Location loc, Token.BracesGroup bodyBracesGroup)
	{
		object result;
		if (in_variant)
		{
			list<ClassMember> list = ((children == null) ? list<ClassMember>.Nil._N_constant_object : ParseClassMembers<object>(children, "variant option").NToList());
			TopDeclaration.VariantOption variantOption = new TopDeclaration.VariantOption(loc, id, _N_parse_option_cp_36849._N_modifiers_36847, null, list);
			InitBodyLocations(variantOption, bodyBracesGroup);
			list = list;
			while (list is list<ClassMember>.Cons)
			{
				ClassMember hd = ((list<ClassMember>.Cons)list).hd;
				list = ((list<ClassMember>.Cons)list).tl;
				hd._definedIn = variantOption;
				list = list;
			}
			result = new ClassMember.TypeDeclaration(loc, id, _N_parse_option_cp_36849._N_modifiers_36847, variantOption);
		}
		else
		{
			if (children != null)
			{
				Error(children, "only variant types can hold options with members");
			}
			result = new ClassMember.EnumOption(id.Location, id, _N_parse_option_cp_36849._N_modifiers_36847, option<PExpr>.None._N_constant_object);
		}
		return (ClassMember)result;
	}

	private static void _N_redirect_37000(Name parsedFieldName, Name uniqueFieldName, option<ClassMember.Function> getterOrSetterFunc)
	{
		if (!(getterOrSetterFunc is option<ClassMember.Function>.Some) || !(((option<ClassMember.Function>.Some)getterOrSetterFunc).val.body is FunBody.Parsed))
		{
			return;
		}
		ClassMember.Function val = ((option<ClassMember.Function>.Some)getterOrSetterFunc).val;
		PExpr expr = ((FunBody.Parsed)((option<ClassMember.Function>.Some)getterOrSetterFunc).val.body).expr;
		Location location = expr.Location;
		bool flag = location.FileIndex != 0;
		if (flag)
		{
			LocationStack.Push(location);
		}
		PExpr.Call call;
		try
		{
			call = new PExpr.Call(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("InternalMacros", _N_MacroContexts.Get(2, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("RedirectName", _N_MacroContexts.Get(2, ManagerClass.Instance)))), new list<PExpr>.Cons(new PExpr.Ref(parsedFieldName), new list<PExpr>.Cons(new PExpr.Ref(uniqueFieldName), new list<PExpr>.Cons(Macros.QuotationChoose(expr), list<PExpr>.Nil._N_constant_object))));
		}
		finally
		{
			if (flag)
			{
				LocationStack.RemoveTop();
			}
		}
		PExpr.Call expr2 = call;
		val.body = new FunBody.Parsed(expr2);
	}

	private static PExpr.TypeEnforcement _N_mekeNewSplicable_37257(PExpr expr, string prefix, bool doRenaming)
	{
		return (!doRenaming) ? new PExpr.TypeEnforcement(new PExpr.Call(new PExpr.Ref(Name.NameInCurrentColor("+", _N_MacroContexts.Get(2, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Literal(new Literal.String(prefix)), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Member(Macros.QuotationChoose(expr), new Splicable.Name(Name.NameInCurrentColor("ToString", _N_MacroContexts.Get(2, ManagerClass.Instance)))), list<PExpr>.Nil._N_constant_object), list<PExpr>.Nil._N_constant_object))), new PExpr.Ref(Name.NameInCurrentColor("dyn", _N_MacroContexts.Get(2, ManagerClass.Instance)))) : new PExpr.TypeEnforcement(new PExpr.Call(new PExpr.Ref(Name.NameInCurrentColor("+", _N_MacroContexts.Get(2, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Ref(Name.NameInCurrentColor("+", _N_MacroContexts.Get(2, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Ref(Name.NameInCurrentColor("+", _N_MacroContexts.Get(2, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Literal(new Literal.String(prefix)), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Member(Macros.QuotationChoose(expr), new Splicable.Name(Name.NameInCurrentColor("ToString", _N_MacroContexts.Get(2, ManagerClass.Instance)))), list<PExpr>.Nil._N_constant_object), list<PExpr>.Nil._N_constant_object))), new list<PExpr>.Cons(new PExpr.Literal(new Literal.String("_")), list<PExpr>.Nil._N_constant_object))), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Member(new PExpr.Call(new PExpr.Member(new PExpr.Member(new PExpr.Ref(Name.NameInCurrentColor("ManagerClass", _N_MacroContexts.Get(2, ManagerClass.Instance))), new Splicable.Name(Name.NameInCurrentColor("Instance", _N_MacroContexts.Get(2, ManagerClass.Instance)))), new Splicable.Name(Name.NameInCurrentColor("GetNewId", _N_MacroContexts.Get(2, ManagerClass.Instance)))), list<PExpr>.Nil._N_constant_object), new Splicable.Name(Name.NameInCurrentColor("ToString", _N_MacroContexts.Get(2, ManagerClass.Instance)))), list<PExpr>.Nil._N_constant_object), list<PExpr>.Nil._N_constant_object))), new PExpr.Ref(Name.NameInCurrentColor("dyn", _N_MacroContexts.Get(2, ManagerClass.Instance))));
	}

	private NemerleModifiers _N_loop_37520(_N_closureOf_get_modifiers_37512 _N_get_modifiers_cp_37519, NemerleModifiers acc)
	{
		_N_closureOf_loop_37526 n_closureOf_loop_ = new _N_closureOf_loop_37526();
		n_closureOf_loop_._N_acc_37535 = acc;
		n_closureOf_loop_._N_tok_37533 = peek_token();
		int result;
		if (n_closureOf_loop_._N_tok_37533 is Token.Keyword)
		{
			n_closureOf_loop_._N_key_37531 = ((Token.Keyword)n_closureOf_loop_._N_tok_37533).name;
			result = (int)((n_closureOf_loop_._N_key_37531 == "mutable") ? _N_add_and_loop_37542(n_closureOf_loop_, _N_get_modifiers_cp_37519, NemerleModifiers.Mutable) : ((n_closureOf_loop_._N_key_37531 == "public") ? _N_add_and_loop_37542(n_closureOf_loop_, _N_get_modifiers_cp_37519, NemerleModifiers.Public) : ((n_closureOf_loop_._N_key_37531 == "private") ? _N_add_and_loop_37542(n_closureOf_loop_, _N_get_modifiers_cp_37519, NemerleModifiers.Private) : ((n_closureOf_loop_._N_key_37531 == "static") ? _N_add_and_loop_37542(n_closureOf_loop_, _N_get_modifiers_cp_37519, NemerleModifiers.Static) : ((n_closureOf_loop_._N_key_37531 == "new") ? _N_add_and_loop_37542(n_closureOf_loop_, _N_get_modifiers_cp_37519, NemerleModifiers.New) : ((n_closureOf_loop_._N_key_37531 == "protected") ? _N_add_and_loop_37542(n_closureOf_loop_, _N_get_modifiers_cp_37519, NemerleModifiers.Protected) : ((n_closureOf_loop_._N_key_37531 == "internal") ? _N_add_and_loop_37542(n_closureOf_loop_, _N_get_modifiers_cp_37519, NemerleModifiers.Internal) : ((n_closureOf_loop_._N_key_37531 == "abstract") ? _N_add_and_loop_37542(n_closureOf_loop_, _N_get_modifiers_cp_37519, NemerleModifiers.Abstract) : ((n_closureOf_loop_._N_key_37531 == "sealed") ? _N_add_and_loop_37542(n_closureOf_loop_, _N_get_modifiers_cp_37519, NemerleModifiers.Sealed) : ((n_closureOf_loop_._N_key_37531 == "override") ? _N_add_and_loop_37542(n_closureOf_loop_, _N_get_modifiers_cp_37519, NemerleModifiers.Override) : ((n_closureOf_loop_._N_key_37531 == "virtual") ? _N_add_and_loop_37542(n_closureOf_loop_, _N_get_modifiers_cp_37519, NemerleModifiers.Virtual) : ((n_closureOf_loop_._N_key_37531 == "volatile") ? _N_add_and_loop_37542(n_closureOf_loop_, _N_get_modifiers_cp_37519, NemerleModifiers.Volatile) : ((n_closureOf_loop_._N_key_37531 == "partial") ? _N_add_and_loop_37542(n_closureOf_loop_, _N_get_modifiers_cp_37519, NemerleModifiers.Partial) : ((!(n_closureOf_loop_._N_key_37531 == "extern")) ? n_closureOf_loop_._N_acc_37535 : _N_add_and_loop_37542(n_closureOf_loop_, _N_get_modifiers_cp_37519, NemerleModifiers.Extern)))))))))))))));
		}
		else
		{
			if ((n_closureOf_loop_._N_acc_37535 & NemerleModifiers.Virtual) != 0 && (n_closureOf_loop_._N_acc_37535 & NemerleModifiers.Override) != 0)
			{
				Message.Warning(n_closureOf_loop_._N_tok_37533.Location, "the `virtual' attribute is redundant, `override' implies `virtual'");
			}
			result = (int)n_closureOf_loop_._N_acc_37535;
		}
		return (NemerleModifiers)result;
	}

	private NemerleModifiers _N_add_and_loop_37542(_N_closureOf_loop_37526 _N_loop_cp_37540, _N_closureOf_get_modifiers_37512 _N_get_modifiers_cp_37541, NemerleModifiers attr)
	{
		shift();
		if ((attr & _N_loop_cp_37540._N_acc_37535) != 0)
		{
			Error(_N_loop_cp_37540._N_tok_37533, string.Concat("attribute '" + _N_loop_cp_37540._N_key_37531, "' specified more than once"));
		}
		return _N_loop_37520(_N_get_modifiers_cp_37541, attr | _N_loop_cp_37540._N_acc_37535);
	}

	private static Typarms _N_create_typarms_37672(list<PExpr> tyvar_exprs, list<Constraint> where_cts)
	{
		list<Splicable> list = null;
		list = list<Splicable>.Nil._N_constant_object;
		list<PExpr> list2;
		for (list2 = tyvar_exprs; list2 is list<PExpr>.Cons; list2 = list2)
		{
			PExpr hd = ((list<PExpr>.Cons)list2).hd;
			list2 = ((list<PExpr>.Cons)list2).tl;
			if (hd is PExpr.Call && ((PExpr.Call)hd).func is PExpr.Ref)
			{
				if (((PExpr.Ref)((PExpr.Call)hd).func).name.idl == "+")
				{
					if (((PExpr.Call)hd).parms is list<PExpr>.Cons && (object)((list<PExpr>.Cons)((PExpr.Call)hd).parms).tl == list<PExpr>.Nil._N_constant_object)
					{
						hd = ((list<PExpr>.Cons)((PExpr.Call)hd).parms).hd;
						Splicable splicable = make_splicable(hd);
						where_cts = new list<Constraint>.Cons(new Constraint(splicable, new PExpr.Ref(Name.NameInCurrentColor("+", _N_MacroContexts.Get(2, ManagerClass.Instance)))), where_cts);
						list = new list<Splicable>.Cons(splicable, list);
						continue;
					}
				}
				else if (((PExpr.Ref)((PExpr.Call)hd).func).name.idl == "-" && ((PExpr.Call)hd).parms is list<PExpr>.Cons && (object)((list<PExpr>.Cons)((PExpr.Call)hd).parms).tl == list<PExpr>.Nil._N_constant_object)
				{
					hd = ((list<PExpr>.Cons)((PExpr.Call)hd).parms).hd;
					Splicable splicable = make_splicable(hd);
					where_cts = new list<Constraint>.Cons(new Constraint(splicable, new PExpr.Ref(Name.NameInCurrentColor("-", _N_MacroContexts.Get(2, ManagerClass.Instance)))), where_cts);
					list = new list<Splicable>.Cons(splicable, list);
					continue;
				}
			}
			list = new list<Splicable>.Cons(make_splicable(hd), list);
		}
		return new Typarms(list.Reverse(), where_cts);
	}

	private list<PExpr> _N_loop2_38344(_N_closureOf_parse_match_case_38334 _N_parse_match_case_cp_38343, list<PExpr> acc)
	{
		object result;
		while (true)
		{
			_N_closureOf_loop2_38350 n_closureOf_loop2_ = new _N_closureOf_loop2_38350();
			n_closureOf_loop2_._N_acc_38355 = acc;
			PExpr pExpr = parse_expr(TokenStoppers.Pipe | TokenStoppers.Arrow);
			Token token = get_token();
			if (token is Token.Operator)
			{
				if (((Token.Operator)token).name == "=>")
				{
					_N_parse_match_case_cp_38343._N_arrowLocation_38341 = ((Token.Operator)token).Location;
					result = NList.Rev(new list<PExpr>.Cons(pExpr, n_closureOf_loop2_._N_acc_38355));
					break;
				}
				if (((Token.Operator)token).name == "|")
				{
					acc = new list<PExpr>.Cons(pExpr, n_closureOf_loop2_._N_acc_38355);
					continue;
				}
			}
			else if (token is Token.EndOfGroup)
			{
				result = ((!(pExpr is PExpr.ToComplete) && (!(pExpr is PExpr.Member) || !(((PExpr.Member)pExpr).member is Splicable.HalfId))) ? _N_ReportError_38358(n_closureOf_loop2_, (Token.EndOfGroup)token, pExpr) : NList.Rev(new list<PExpr>.Cons(pExpr, n_closureOf_loop2_._N_acc_38355)));
				break;
			}
			result = _N_ReportError_38358(n_closureOf_loop2_, token, pExpr);
			break;
		}
		return (list<PExpr>)result;
	}

	private static list<PExpr> _N_ReportError_38358(_N_closureOf_loop2_38350 _N_loop2_cp_38357, Token x, PExpr res)
	{
		Error(x, "'=>' or '|' expected (or incorrect pattern format)");
		return NList.Rev(new list<PExpr>.Cons(res, _N_loop2_cp_38357._N_acc_38355));
	}

	private T _N_push_38990<T>(_N_closureOf_parse_quotation_38964 _N_parse_quotation_cp_38989, string describe, Function<T> f)
	{
		T val = default(T);
		push_stream(_N_parse_quotation_cp_38989._N_group_38973.Child);
		val = f.apply();
		pop_stream(describe);
		shift();
		return val;
	}

	private static bool _N_isStr_39106(Token tok)
	{
		if (tok is Token.StringLiteral)
		{
			goto IL_000b;
		}
		if (tok is Token.RoundGroup && ((Token.RoundGroup)tok).Child is Token.LooseGroup && ((Token.LooseGroup)((Token.RoundGroup)tok).Child).Child is Token.Operator)
		{
			Token.Operator @operator = (Token.Operator)((Token.LooseGroup)((Token.RoundGroup)tok).Child).Child;
			if (((Token.Operator)((Token.LooseGroup)((Token.RoundGroup)tok).Child).Child).name == "$")
			{
				Token next = @operator.Next;
				if (next is Token.StringLiteral)
				{
					goto IL_000b;
				}
			}
		}
		int result = 0;
		goto IL_00d9;
		IL_00d9:
		return (byte)result != 0;
		IL_000b:
		result = 1;
		goto IL_00d9;
	}

	private static Token _N_makeStrsConcat_39120(_N_closureOf_parse_expr_sequence_39101 _N_parse_expr_sequence_cp_39119, Token tok, bool prevDollarised)
	{
		_N_closureOf_makeStrsConcat_39126 n_closureOf_makeStrsConcat_ = new _N_closureOf_makeStrsConcat_39126();
		n_closureOf_makeStrsConcat_._N_tok_39137 = tok;
		n_closureOf_makeStrsConcat_._N_prevDollarised_39135 = prevDollarised;
		object result;
		Token next;
		if ((object)n_closureOf_makeStrsConcat_._N_tok_39137 == null)
		{
			result = null;
		}
		else
		{
			if (n_closureOf_makeStrsConcat_._N_tok_39137 is Token.RoundGroup)
			{
				if (((Token.RoundGroup)n_closureOf_makeStrsConcat_._N_tok_39137).Child is Token.LooseGroup && ((Token.LooseGroup)((Token.RoundGroup)n_closureOf_makeStrsConcat_._N_tok_39137).Child).Child is Token.Operator)
				{
					Token.Operator @operator = (Token.Operator)((Token.LooseGroup)((Token.RoundGroup)n_closureOf_makeStrsConcat_._N_tok_39137).Child).Child;
					if (((Token.Operator)((Token.LooseGroup)((Token.RoundGroup)n_closureOf_makeStrsConcat_._N_tok_39137).Child).Child).name == "$")
					{
						next = @operator.Next;
						if (next is Token.StringLiteral)
						{
							n_closureOf_makeStrsConcat_._N_litTok_39133 = (Token.StringLiteral)@operator.Next;
							n_closureOf_makeStrsConcat_._N_isDollarised_39131 = true;
							goto IL_0102;
						}
					}
				}
			}
			else if (n_closureOf_makeStrsConcat_._N_tok_39137 is Token.StringLiteral)
			{
				n_closureOf_makeStrsConcat_._N_litTok_39133 = (Token.StringLiteral)n_closureOf_makeStrsConcat_._N_tok_39137;
				n_closureOf_makeStrsConcat_._N_isDollarised_39131 = false;
				goto IL_0102;
			}
			next = _N_makeStrsConcat_39120(_N_parse_expr_sequence_cp_39119, n_closureOf_makeStrsConcat_._N_tok_39137.Next, prevDollarised: false);
			if (next != n_closureOf_makeStrsConcat_._N_tok_39137.Next)
			{
				n_closureOf_makeStrsConcat_._N_tok_39137.Next = next;
			}
			result = n_closureOf_makeStrsConcat_._N_tok_39137;
		}
		goto IL_027c;
		IL_027c:
		return (Token)result;
		IL_0102:
		next = n_closureOf_makeStrsConcat_._N_tok_39137;
		if (_N_isStr_39106(next.Next))
		{
			Token.Operator @operator = new Token.Operator("+");
			@operator.Location = next.Location.FromEndAsGenerated() + next.Next.Location.FromStartAsGenerated();
			@operator.Next = next.Next;
			next = _N_tryMakeDollarised_39149(n_closureOf_makeStrsConcat_);
			next.Next = @operator;
			@operator.Next = _N_makeStrsConcat_39120(_N_parse_expr_sequence_cp_39119, @operator.Next, n_closureOf_makeStrsConcat_._N_isDollarised_39131 || n_closureOf_makeStrsConcat_._N_prevDollarised_39135);
			if (@operator.Location.IsEmpty)
			{
				Message.Warning(@operator.Location, "auto-concatenated strings is come together (this is probably error");
			}
			result = next;
		}
		else
		{
			next = _N_tryMakeDollarised_39149(n_closureOf_makeStrsConcat_);
			Token token = _N_makeStrsConcat_39120(_N_parse_expr_sequence_cp_39119, next.Next, prevDollarised: false);
			if (token != next.Next)
			{
				next.Next = token;
			}
			result = next;
		}
		goto IL_027c;
	}

	private static Token _N_tryMakeDollarised_39149(_N_closureOf_makeStrsConcat_39126 _N_makeStrsConcat_cp_39148)
	{
		Token n_tok_ = _N_makeStrsConcat_cp_39148._N_tok_39137;
		bool flag = _N_makeStrsConcat_cp_39148._N_litTok_39133.value.Contains("$");
		if (_N_makeStrsConcat_cp_39148._N_isDollarised_39131 && !flag)
		{
			Token next = n_tok_.Next;
			while (next is Token.StringLiteral)
			{
				string value = ((Token.StringLiteral)next).value;
				if (!value.Contains("$"))
				{
					next = next.Next;
					continue;
				}
				goto IL_0085;
			}
		}
		else if (false)
		{
			goto IL_0085;
		}
		object result;
		if (!_N_makeStrsConcat_cp_39148._N_isDollarised_39131 && _N_makeStrsConcat_cp_39148._N_prevDollarised_39135 && flag)
		{
			Token.Operator @operator = new Token.Operator("$");
			@operator.Next = _N_makeStrsConcat_cp_39148._N_litTok_39133;
			Token next = _N_makeStrsConcat_cp_39148._N_litTok_39133.Next;
			_N_makeStrsConcat_cp_39148._N_litTok_39133.Next = null;
			Token.RoundGroup roundGroup = new Token.RoundGroup(new Token.LooseGroup(@operator), null, null);
			roundGroup.Next = next;
			result = roundGroup;
		}
		else
		{
			result = n_tok_;
		}
		goto IL_0109;
		IL_0085:
		result = _N_makeStrsConcat_cp_39148._N_litTok_39133;
		goto IL_0109;
		IL_0109:
		return (Token)result;
	}
}
