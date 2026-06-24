using System;
using System.CodeDom.Compiler;
using Antlr.Runtime;
using Antlr.Runtime.Tree;

namespace EleWise.TemplateGenerator.Adl;

[GeneratedCode("ANTLR", "3.3.1.7705")]
[CLSCompliant(false)]
public class AdlParser : Parser
{
	public sealed class template_return : ParserRuleReturnScope<CommonToken>, IAstRuleReturnScope<CommonTree>, IAstRuleReturnScope, IRuleReturnScope
	{
		private CommonTree _tree;

		public CommonTree Tree
		{
			get
			{
				return _tree;
			}
			set
			{
				_tree = value;
			}
		}

		object IAstRuleReturnScope.Tree => Tree;

		public template_return(AdlParser grammar)
		{
		}
	}

	private sealed class item_return : ParserRuleReturnScope<CommonToken>, IAstRuleReturnScope<CommonTree>, IAstRuleReturnScope, IRuleReturnScope
	{
		private CommonTree _tree;

		public CommonTree Tree
		{
			get
			{
				return _tree;
			}
			set
			{
				_tree = value;
			}
		}

		object IAstRuleReturnScope.Tree => Tree;

		public item_return(AdlParser grammar)
		{
		}
	}

	private sealed class item_list_return : ParserRuleReturnScope<CommonToken>, IAstRuleReturnScope<CommonTree>, IAstRuleReturnScope, IRuleReturnScope
	{
		private CommonTree _tree;

		public CommonTree Tree
		{
			get
			{
				return _tree;
			}
			set
			{
				_tree = value;
			}
		}

		object IAstRuleReturnScope.Tree => Tree;

		public item_list_return(AdlParser grammar)
		{
		}
	}

	private sealed class statement_return : ParserRuleReturnScope<CommonToken>, IAstRuleReturnScope<CommonTree>, IAstRuleReturnScope, IRuleReturnScope
	{
		private CommonTree _tree;

		public CommonTree Tree
		{
			get
			{
				return _tree;
			}
			set
			{
				_tree = value;
			}
		}

		object IAstRuleReturnScope.Tree => Tree;

		public statement_return(AdlParser grammar)
		{
		}
	}

	private sealed class if_then_stat_return : ParserRuleReturnScope<CommonToken>, IAstRuleReturnScope<CommonTree>, IAstRuleReturnScope, IRuleReturnScope
	{
		private CommonTree _tree;

		public CommonTree Tree
		{
			get
			{
				return _tree;
			}
			set
			{
				_tree = value;
			}
		}

		object IAstRuleReturnScope.Tree => Tree;

		public if_then_stat_return(AdlParser grammar)
		{
		}
	}

	private sealed class block_stat_return : ParserRuleReturnScope<CommonToken>, IAstRuleReturnScope<CommonTree>, IAstRuleReturnScope, IRuleReturnScope
	{
		private CommonTree _tree;

		public CommonTree Tree
		{
			get
			{
				return _tree;
			}
			set
			{
				_tree = value;
			}
		}

		object IAstRuleReturnScope.Tree => Tree;

		public block_stat_return(AdlParser grammar)
		{
		}
	}

	public sealed class detachedExpression_return : ParserRuleReturnScope<CommonToken>, IAstRuleReturnScope<CommonTree>, IAstRuleReturnScope, IRuleReturnScope
	{
		private CommonTree _tree;

		public CommonTree Tree
		{
			get
			{
				return _tree;
			}
			set
			{
				_tree = value;
			}
		}

		object IAstRuleReturnScope.Tree => Tree;

		public detachedExpression_return(AdlParser grammar)
		{
		}
	}

	private sealed class expression_return : ParserRuleReturnScope<CommonToken>, IAstRuleReturnScope<CommonTree>, IAstRuleReturnScope, IRuleReturnScope
	{
		private CommonTree _tree;

		public CommonTree Tree
		{
			get
			{
				return _tree;
			}
			set
			{
				_tree = value;
			}
		}

		object IAstRuleReturnScope.Tree => Tree;

		public expression_return(AdlParser grammar)
		{
		}
	}

	private sealed class expression_or_return : ParserRuleReturnScope<CommonToken>, IAstRuleReturnScope<CommonTree>, IAstRuleReturnScope, IRuleReturnScope
	{
		private CommonTree _tree;

		public CommonTree Tree
		{
			get
			{
				return _tree;
			}
			set
			{
				_tree = value;
			}
		}

		object IAstRuleReturnScope.Tree => Tree;

		public expression_or_return(AdlParser grammar)
		{
		}
	}

	private sealed class expression_and_return : ParserRuleReturnScope<CommonToken>, IAstRuleReturnScope<CommonTree>, IAstRuleReturnScope, IRuleReturnScope
	{
		private CommonTree _tree;

		public CommonTree Tree
		{
			get
			{
				return _tree;
			}
			set
			{
				_tree = value;
			}
		}

		object IAstRuleReturnScope.Tree => Tree;

		public expression_and_return(AdlParser grammar)
		{
		}
	}

	private sealed class expression_comp_return : ParserRuleReturnScope<CommonToken>, IAstRuleReturnScope<CommonTree>, IAstRuleReturnScope, IRuleReturnScope
	{
		private CommonTree _tree;

		public CommonTree Tree
		{
			get
			{
				return _tree;
			}
			set
			{
				_tree = value;
			}
		}

		object IAstRuleReturnScope.Tree => Tree;

		public expression_comp_return(AdlParser grammar)
		{
		}
	}

	private sealed class operator_comp_return : ParserRuleReturnScope<CommonToken>, IAstRuleReturnScope<CommonTree>, IAstRuleReturnScope, IRuleReturnScope
	{
		private CommonTree _tree;

		public CommonTree Tree
		{
			get
			{
				return _tree;
			}
			set
			{
				_tree = value;
			}
		}

		object IAstRuleReturnScope.Tree => Tree;

		public operator_comp_return(AdlParser grammar)
		{
		}
	}

	private sealed class expression_add_return : ParserRuleReturnScope<CommonToken>, IAstRuleReturnScope<CommonTree>, IAstRuleReturnScope, IRuleReturnScope
	{
		private CommonTree _tree;

		public CommonTree Tree
		{
			get
			{
				return _tree;
			}
			set
			{
				_tree = value;
			}
		}

		object IAstRuleReturnScope.Tree => Tree;

		public expression_add_return(AdlParser grammar)
		{
		}
	}

	private sealed class operator_add_return : ParserRuleReturnScope<CommonToken>, IAstRuleReturnScope<CommonTree>, IAstRuleReturnScope, IRuleReturnScope
	{
		private CommonTree _tree;

		public CommonTree Tree
		{
			get
			{
				return _tree;
			}
			set
			{
				_tree = value;
			}
		}

		object IAstRuleReturnScope.Tree => Tree;

		public operator_add_return(AdlParser grammar)
		{
		}
	}

	private sealed class expression_mult_return : ParserRuleReturnScope<CommonToken>, IAstRuleReturnScope<CommonTree>, IAstRuleReturnScope, IRuleReturnScope
	{
		private CommonTree _tree;

		public CommonTree Tree
		{
			get
			{
				return _tree;
			}
			set
			{
				_tree = value;
			}
		}

		object IAstRuleReturnScope.Tree => Tree;

		public expression_mult_return(AdlParser grammar)
		{
		}
	}

	private sealed class operator_mult_return : ParserRuleReturnScope<CommonToken>, IAstRuleReturnScope<CommonTree>, IAstRuleReturnScope, IRuleReturnScope
	{
		private CommonTree _tree;

		public CommonTree Tree
		{
			get
			{
				return _tree;
			}
			set
			{
				_tree = value;
			}
		}

		object IAstRuleReturnScope.Tree => Tree;

		public operator_mult_return(AdlParser grammar)
		{
		}
	}

	private sealed class expression_unary_return : ParserRuleReturnScope<CommonToken>, IAstRuleReturnScope<CommonTree>, IAstRuleReturnScope, IRuleReturnScope
	{
		private CommonTree _tree;

		public CommonTree Tree
		{
			get
			{
				return _tree;
			}
			set
			{
				_tree = value;
			}
		}

		object IAstRuleReturnScope.Tree => Tree;

		public expression_unary_return(AdlParser grammar)
		{
		}
	}

	private sealed class operator_unary_return : ParserRuleReturnScope<CommonToken>, IAstRuleReturnScope<CommonTree>, IAstRuleReturnScope, IRuleReturnScope
	{
		private CommonTree _tree;

		public CommonTree Tree
		{
			get
			{
				return _tree;
			}
			set
			{
				_tree = value;
			}
		}

		object IAstRuleReturnScope.Tree => Tree;

		public operator_unary_return(AdlParser grammar)
		{
		}
	}

	private sealed class atom_return : ParserRuleReturnScope<CommonToken>, IAstRuleReturnScope<CommonTree>, IAstRuleReturnScope, IRuleReturnScope
	{
		private CommonTree _tree;

		public CommonTree Tree
		{
			get
			{
				return _tree;
			}
			set
			{
				_tree = value;
			}
		}

		object IAstRuleReturnScope.Tree => Tree;

		public atom_return(AdlParser grammar)
		{
		}
	}

	private sealed class constant_return : ParserRuleReturnScope<CommonToken>, IAstRuleReturnScope<CommonTree>, IAstRuleReturnScope, IRuleReturnScope
	{
		private CommonTree _tree;

		public CommonTree Tree
		{
			get
			{
				return _tree;
			}
			set
			{
				_tree = value;
			}
		}

		object IAstRuleReturnScope.Tree => Tree;

		public constant_return(AdlParser grammar)
		{
		}
	}

	private sealed class function_call_return : ParserRuleReturnScope<CommonToken>, IAstRuleReturnScope<CommonTree>, IAstRuleReturnScope, IRuleReturnScope
	{
		private CommonTree _tree;

		public CommonTree Tree
		{
			get
			{
				return _tree;
			}
			set
			{
				_tree = value;
			}
		}

		object IAstRuleReturnScope.Tree => Tree;

		public function_call_return(AdlParser grammar)
		{
		}
	}

	private sealed class param_list_return : ParserRuleReturnScope<CommonToken>, IAstRuleReturnScope<CommonTree>, IAstRuleReturnScope, IRuleReturnScope
	{
		private CommonTree _tree;

		public CommonTree Tree
		{
			get
			{
				return _tree;
			}
			set
			{
				_tree = value;
			}
		}

		object IAstRuleReturnScope.Tree => Tree;

		public param_list_return(AdlParser grammar)
		{
		}
	}

	private class DFA2 : DFA
	{
		private const string DFA2_eotS = "\u0010\uffff";

		private const string DFA2_eofS = "\u0001\u0001\u000f\uffff";

		private const string DFA2_minS = "\u0001\r\u0001\uffff\u0001\u0005\r\uffff";

		private const string DFA2_maxS = "\u0001&\u0001\uffff\u0001&\r\uffff";

		private const string DFA2_acceptS = "\u0001\uffff\u0001\u0002\u0001\uffff\u0001\u0001\f\uffff";

		private const string DFA2_specialS = "\u0010\uffff}>";

		private static readonly string[] DFA2_transitionS;

		private static readonly short[] DFA2_eot;

		private static readonly short[] DFA2_eof;

		private static readonly char[] DFA2_min;

		private static readonly char[] DFA2_max;

		private static readonly short[] DFA2_accept;

		private static readonly short[] DFA2_special;

		private static readonly short[][] DFA2_transition;

		public override string Description => "()* loopback of 47:2: ( item )*";

		static DFA2()
		{
			DFA2_transitionS = new string[16]
			{
				"\u0001\u0003\u0010\uffff\u0001\u0003\u0002\uffff\u0001\u0002\u0004\uffff\u0001\u0003", "", "\u0002\u0003\u0001\uffff\u0002\u0001\u0001\uffff\u0001\u0003\u0001\uffff\u0001\u0003\u0002\uffff\u0002\u0003\u0003\uffff\u0001\u0003\u0002\uffff\u0001\u0003\u0002\uffff\u0002\u0003\b\uffff\u0002\u0003", "", "", "", "", "", "", "",
				"", "", "", "", "", ""
			};
			DFA2_eot = DFA.UnpackEncodedString("\u0010\uffff");
			DFA2_eof = DFA.UnpackEncodedString("\u0001\u0001\u000f\uffff");
			DFA2_min = DFA.UnpackEncodedStringToUnsignedChars("\u0001\r\u0001\uffff\u0001\u0005\r\uffff");
			DFA2_max = DFA.UnpackEncodedStringToUnsignedChars("\u0001&\u0001\uffff\u0001&\r\uffff");
			DFA2_accept = DFA.UnpackEncodedString("\u0001\uffff\u0001\u0002\u0001\uffff\u0001\u0001\f\uffff");
			DFA2_special = DFA.UnpackEncodedString("\u0010\uffff}>");
			int num = DFA2_transitionS.Length;
			DFA2_transition = new short[num][];
			for (int i = 0; i < num; i++)
			{
				DFA2_transition[i] = DFA.UnpackEncodedString(DFA2_transitionS[i]);
			}
		}

		public DFA2(BaseRecognizer recognizer)
		{
			base.recognizer = recognizer;
			decisionNumber = 2;
			eot = DFA2_eot;
			eof = DFA2_eof;
			min = DFA2_min;
			max = DFA2_max;
			accept = DFA2_accept;
			special = DFA2_special;
			transition = DFA2_transition;
		}

		public override void Error(NoViableAltException nvae)
		{
		}
	}

	private class DFA3 : DFA
	{
		private const string DFA3_eotS = "\f\uffff";

		private const string DFA3_eofS = "\f\uffff";

		private const string DFA3_minS = "\u0001\r\u0002\uffff\u0001\u0005\b\uffff";

		private const string DFA3_maxS = "\u0001&\u0002\uffff\u0001&\b\uffff";

		private const string DFA3_acceptS = "\u0001\uffff\u0001\u0001\u0001\u0002\u0001\uffff\u0001\u0003\u0001\u0004\u0001\u0005\u0005\uffff";

		private const string DFA3_specialS = "\f\uffff}>";

		private static readonly string[] DFA3_transitionS;

		private static readonly short[] DFA3_eot;

		private static readonly short[] DFA3_eof;

		private static readonly char[] DFA3_min;

		private static readonly char[] DFA3_max;

		private static readonly short[] DFA3_accept;

		private static readonly short[] DFA3_special;

		private static readonly short[][] DFA3_transition;

		public override string Description => "51:1: statement : ( VARIABLE | GLOBALVARIABLE | if_then_stat | block_stat | PROG_START expression PROG_END );";

		static DFA3()
		{
			DFA3_transitionS = new string[12]
			{
				"\u0001\u0002\u0013\uffff\u0001\u0003\u0004\uffff\u0001\u0001", "", "", "\u0001\u0005\u0001\u0006\u0004\uffff\u0001\u0006\u0001\uffff\u0001\u0006\u0002\uffff\u0001\u0006\u0001\u0004\u0003\uffff\u0001\u0006\u0002\uffff\u0001\u0006\u0002\uffff\u0002\u0006\b\uffff\u0002\u0006", "", "", "", "", "", "",
				"", ""
			};
			DFA3_eot = DFA.UnpackEncodedString("\f\uffff");
			DFA3_eof = DFA.UnpackEncodedString("\f\uffff");
			DFA3_min = DFA.UnpackEncodedStringToUnsignedChars("\u0001\r\u0002\uffff\u0001\u0005\b\uffff");
			DFA3_max = DFA.UnpackEncodedStringToUnsignedChars("\u0001&\u0002\uffff\u0001&\b\uffff");
			DFA3_accept = DFA.UnpackEncodedString("\u0001\uffff\u0001\u0001\u0001\u0002\u0001\uffff\u0001\u0003\u0001\u0004\u0001\u0005\u0005\uffff");
			DFA3_special = DFA.UnpackEncodedString("\f\uffff}>");
			int num = DFA3_transitionS.Length;
			DFA3_transition = new short[num][];
			for (int i = 0; i < num; i++)
			{
				DFA3_transition[i] = DFA.UnpackEncodedString(DFA3_transitionS[i]);
			}
		}

		public DFA3(BaseRecognizer recognizer)
		{
			base.recognizer = recognizer;
			decisionNumber = 3;
			eot = DFA3_eot;
			eof = DFA3_eof;
			min = DFA3_min;
			max = DFA3_max;
			accept = DFA3_accept;
			special = DFA3_special;
			transition = DFA3_transition;
		}

		public override void Error(NoViableAltException nvae)
		{
		}
	}

	private class DFA10 : DFA
	{
		private const string DFA10_eotS = "\n\uffff";

		private const string DFA10_eofS = "\u0001\u0001\t\uffff";

		private const string DFA10_minS = "\u0001\u0004\t\uffff";

		private const string DFA10_maxS = "\u0001$\t\uffff";

		private const string DFA10_acceptS = "\u0001\uffff\u0001\u0002\a\uffff\u0001\u0001";

		private const string DFA10_specialS = "\n\uffff}>";

		private static readonly string[] DFA10_transitionS;

		private static readonly short[] DFA10_eot;

		private static readonly short[] DFA10_eof;

		private static readonly char[] DFA10_min;

		private static readonly char[] DFA10_max;

		private static readonly short[] DFA10_accept;

		private static readonly short[] DFA10_special;

		private static readonly short[][] DFA10_transition;

		public override string Description => "()* loopback of 104:18: ( operator_add expression_mult )*";

		static DFA10()
		{
			DFA10_transitionS = new string[10] { "\u0001\u0001\u0005\uffff\u0001\u0001\u0001\uffff\u0001\u0001\u0001\uffff\u0001\u0001\u0005\uffff\u0001\u0001\u0001\uffff\u0001\u0001\u0001\uffff\u0001\t\u0001\uffff\u0001\u0001\u0002\uffff\u0001\u0001\u0001\uffff\u0001\t\u0001\u0001\u0001\uffff\u0003\u0001", "", "", "", "", "", "", "", "", "" };
			DFA10_eot = DFA.UnpackEncodedString("\n\uffff");
			DFA10_eof = DFA.UnpackEncodedString("\u0001\u0001\t\uffff");
			DFA10_min = DFA.UnpackEncodedStringToUnsignedChars("\u0001\u0004\t\uffff");
			DFA10_max = DFA.UnpackEncodedStringToUnsignedChars("\u0001$\t\uffff");
			DFA10_accept = DFA.UnpackEncodedString("\u0001\uffff\u0001\u0002\a\uffff\u0001\u0001");
			DFA10_special = DFA.UnpackEncodedString("\n\uffff}>");
			int num = DFA10_transitionS.Length;
			DFA10_transition = new short[num][];
			for (int i = 0; i < num; i++)
			{
				DFA10_transition[i] = DFA.UnpackEncodedString(DFA10_transitionS[i]);
			}
		}

		public DFA10(BaseRecognizer recognizer)
		{
			base.recognizer = recognizer;
			decisionNumber = 10;
			eot = DFA10_eot;
			eof = DFA10_eof;
			min = DFA10_min;
			max = DFA10_max;
			accept = DFA10_accept;
			special = DFA10_special;
			transition = DFA10_transition;
		}

		public override void Error(NoViableAltException nvae)
		{
		}
	}

	private class DFA11 : DFA
	{
		private const string DFA11_eotS = "\v\uffff";

		private const string DFA11_eofS = "\u0001\u0001\n\uffff";

		private const string DFA11_minS = "\u0001\u0004\n\uffff";

		private const string DFA11_maxS = "\u0001$\n\uffff";

		private const string DFA11_acceptS = "\u0001\uffff\u0001\u0002\b\uffff\u0001\u0001";

		private const string DFA11_specialS = "\v\uffff}>";

		private static readonly string[] DFA11_transitionS;

		private static readonly short[] DFA11_eot;

		private static readonly short[] DFA11_eof;

		private static readonly char[] DFA11_min;

		private static readonly char[] DFA11_max;

		private static readonly short[] DFA11_accept;

		private static readonly short[] DFA11_special;

		private static readonly short[][] DFA11_transition;

		public override string Description => "()* loopback of 115:19: ( operator_mult expression_unary )*";

		static DFA11()
		{
			DFA11_transitionS = new string[11]
			{
				"\u0001\u0001\u0002\uffff\u0001\n\u0002\uffff\u0001\u0001\u0001\uffff\u0001\u0001\u0001\uffff\u0001\u0001\u0005\uffff\u0001\u0001\u0001\uffff\u0001\u0001\u0001\uffff\u0001\u0001\u0001\n\u0001\u0001\u0002\uffff\u0001\u0001\u0001\uffff\u0002\u0001\u0001\uffff\u0003\u0001", "", "", "", "", "", "", "", "", "",
				""
			};
			DFA11_eot = DFA.UnpackEncodedString("\v\uffff");
			DFA11_eof = DFA.UnpackEncodedString("\u0001\u0001\n\uffff");
			DFA11_min = DFA.UnpackEncodedStringToUnsignedChars("\u0001\u0004\n\uffff");
			DFA11_max = DFA.UnpackEncodedStringToUnsignedChars("\u0001$\n\uffff");
			DFA11_accept = DFA.UnpackEncodedString("\u0001\uffff\u0001\u0002\b\uffff\u0001\u0001");
			DFA11_special = DFA.UnpackEncodedString("\v\uffff}>");
			int num = DFA11_transitionS.Length;
			DFA11_transition = new short[num][];
			for (int i = 0; i < num; i++)
			{
				DFA11_transition[i] = DFA.UnpackEncodedString(DFA11_transitionS[i]);
			}
		}

		public DFA11(BaseRecognizer recognizer)
		{
			base.recognizer = recognizer;
			decisionNumber = 11;
			eot = DFA11_eot;
			eof = DFA11_eof;
			min = DFA11_min;
			max = DFA11_max;
			accept = DFA11_accept;
			special = DFA11_special;
			transition = DFA11_transition;
		}

		public override void Error(NoViableAltException nvae)
		{
		}
	}

	private static class Follow
	{
		public static readonly BitSet _item_list_in_template138 = new BitSet(new ulong[1]);

		public static readonly BitSet _EOF_in_template140 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _PLAINTEXT_in_item153 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _statement_in_item158 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _item_in_item_list173 = new BitSet(new ulong[1] { 284541591554uL });

		public static readonly BitSet _VARIABLE_in_statement195 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _GLOBALVARIABLE_in_statement200 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _if_then_stat_in_statement205 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _block_stat_in_statement210 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _PROG_START_in_statement215 = new BitSet(new ulong[1] { 412738463808uL });

		public static readonly BitSet _expression_in_statement217 = new BitSet(new ulong[1] { 4294967296uL });

		public static readonly BitSet _PROG_END_in_statement219 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _PROG_START_in_if_then_stat231 = new BitSet(new ulong[1] { 131072uL });

		public static readonly BitSet _IF_in_if_then_stat233 = new BitSet(new ulong[1] { 412738463808uL });

		public static readonly BitSet _expression_in_if_then_stat235 = new BitSet(new ulong[1] { 73014444032uL });

		public static readonly BitSet _THEN_in_if_then_stat237 = new BitSet(new ulong[1] { 4294967296uL });

		public static readonly BitSet _PROG_END_in_if_then_stat240 = new BitSet(new ulong[1] { 284541591552uL });

		public static readonly BitSet _item_list_in_if_then_stat242 = new BitSet(new ulong[1] { 8589934592uL });

		public static readonly BitSet _PROG_START_in_if_then_stat245 = new BitSet(new ulong[1] { 256uL });

		public static readonly BitSet _ELSE_in_if_then_stat247 = new BitSet(new ulong[1] { 4294967296uL });

		public static readonly BitSet _PROG_END_in_if_then_stat249 = new BitSet(new ulong[1] { 284541591552uL });

		public static readonly BitSet _item_list_in_if_then_stat251 = new BitSet(new ulong[1] { 8589934592uL });

		public static readonly BitSet _PROG_START_in_if_then_stat256 = new BitSet(new ulong[1] { 512uL });

		public static readonly BitSet _END_in_if_then_stat258 = new BitSet(new ulong[1] { 4295098368uL });

		public static readonly BitSet _IF_in_if_then_stat260 = new BitSet(new ulong[1] { 4294967296uL });

		public static readonly BitSet _PROG_END_in_if_then_stat263 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _PROG_START_in_block_stat275 = new BitSet(new ulong[1] { 32uL });

		public static readonly BitSet _BLOCK_in_block_stat277 = new BitSet(new ulong[1] { 65536uL });

		public static readonly BitSet _IDENTIFIER_in_block_stat279 = new BitSet(new ulong[1] { 262144uL });

		public static readonly BitSet _IN_in_block_stat281 = new BitSet(new ulong[1] { 412738463808uL });

		public static readonly BitSet _expression_in_block_stat283 = new BitSet(new ulong[1] { 4294967296uL });

		public static readonly BitSet _PROG_END_in_block_stat285 = new BitSet(new ulong[1] { 284541591552uL });

		public static readonly BitSet _item_list_in_block_stat287 = new BitSet(new ulong[1] { 8589934592uL });

		public static readonly BitSet _PROG_START_in_block_stat289 = new BitSet(new ulong[1] { 512uL });

		public static readonly BitSet _END_in_block_stat291 = new BitSet(new ulong[1] { 4294967296uL });

		public static readonly BitSet _PROG_END_in_block_stat293 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _expression_in_detachedExpression307 = new BitSet(new ulong[1]);

		public static readonly BitSet _EOF_in_detachedExpression309 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _expression_or_in_expression319 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _expression_and_in_expression_or329 = new BitSet(new ulong[1] { 536870914uL });

		public static readonly BitSet _OR_in_expression_or332 = new BitSet(new ulong[1] { 412738463808uL });

		public static readonly BitSet _expression_and_in_expression_or334 = new BitSet(new ulong[1] { 536870914uL });

		public static readonly BitSet _expression_comp_in_expression_and348 = new BitSet(new ulong[1] { 18uL });

		public static readonly BitSet _AND_in_expression_and351 = new BitSet(new ulong[1] { 412738463808uL });

		public static readonly BitSet _expression_comp_in_expression_and353 = new BitSet(new ulong[1] { 18uL });

		public static readonly BitSet _expression_add_in_expression_comp367 = new BitSet(new ulong[1] { 72373250uL });

		public static readonly BitSet _operator_comp_in_expression_comp370 = new BitSet(new ulong[1] { 412738463808uL });

		public static readonly BitSet _expression_add_in_expression_comp372 = new BitSet(new ulong[1] { 72373250uL });

		public static readonly BitSet _set_in_operator_comp383 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _expression_mult_in_expression_add423 = new BitSet(new ulong[1] { 2164260866uL });

		public static readonly BitSet _operator_add_in_expression_add426 = new BitSet(new ulong[1] { 412738463808uL });

		public static readonly BitSet _expression_mult_in_expression_add428 = new BitSet(new ulong[1] { 2164260866uL });

		public static readonly BitSet _set_in_operator_add439 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _expression_unary_in_expression_mult459 = new BitSet(new ulong[1] { 33554562uL });

		public static readonly BitSet _operator_mult_in_expression_mult462 = new BitSet(new ulong[1] { 412738463808uL });

		public static readonly BitSet _expression_unary_in_expression_mult464 = new BitSet(new ulong[1] { 33554562uL });

		public static readonly BitSet _set_in_operator_mult475 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _operator_unary_in_expression_unary495 = new BitSet(new ulong[1] { 412738463808uL });

		public static readonly BitSet _atom_in_expression_unary497 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _atom_in_expression_unary502 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _MINUS_in_operator_unary514 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _LPAREN_in_atom526 = new BitSet(new ulong[1] { 412738463808uL });

		public static readonly BitSet _expression_in_atom528 = new BitSet(new ulong[1] { 17179869184uL });

		public static readonly BitSet _RPAREN_in_atom530 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _VARIABLE_in_atom536 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _GLOBALVARIABLE_in_atom541 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _constant_in_atom546 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _function_call_in_atom551 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _set_in_constant560 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _IDENTIFIER_in_function_call596 = new BitSet(new ulong[1] { 2097152uL });

		public static readonly BitSet _LPAREN_in_function_call598 = new BitSet(new ulong[1] { 429918332992uL });

		public static readonly BitSet _param_list_in_function_call600 = new BitSet(new ulong[1] { 17179869184uL });

		public static readonly BitSet _RPAREN_in_function_call602 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _expression_in_param_list615 = new BitSet(new ulong[1] { 34359738370uL });

		public static readonly BitSet _SEMICOLON_in_param_list618 = new BitSet(new ulong[1] { 412738463808uL });

		public static readonly BitSet _expression_in_param_list620 = new BitSet(new ulong[1] { 34359738370uL });
	}

	internal static readonly string[] tokenNames = new string[40]
	{
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "AND", "BLOCK", "CHARACTER_STRING", "DIVISION", "ELSE", "END",
		"EQUAL", "FALSE", "GE", "GLOBALVARIABLE", "GT", "IDDigit", "IDENTIFIER", "IF", "IN", "ITEM_LIST",
		"LE", "LPAREN", "LT", "Letter", "MINUS", "MULT", "NEQUAL", "NULL", "NUMBER", "OR",
		"PLAINTEXT", "PLUS", "PROG_END", "PROG_START", "RPAREN", "SEMICOLON", "THEN", "TRUE", "VARIABLE", "WS"
	};

	public const int EOF = -1;

	public const int AND = 4;

	public const int BLOCK = 5;

	public const int CHARACTER_STRING = 6;

	public const int DIVISION = 7;

	public const int ELSE = 8;

	public const int END = 9;

	public const int EQUAL = 10;

	public const int FALSE = 11;

	public const int GE = 12;

	public const int GLOBALVARIABLE = 13;

	public const int GT = 14;

	public const int IDDigit = 15;

	public const int IDENTIFIER = 16;

	public const int IF = 17;

	public const int IN = 18;

	public const int ITEM_LIST = 19;

	public const int LE = 20;

	public const int LPAREN = 21;

	public const int LT = 22;

	public const int Letter = 23;

	public const int MINUS = 24;

	public const int MULT = 25;

	public const int NEQUAL = 26;

	public const int NULL = 27;

	public const int NUMBER = 28;

	public const int OR = 29;

	public const int PLAINTEXT = 30;

	public const int PLUS = 31;

	public const int PROG_END = 32;

	public const int PROG_START = 33;

	public const int RPAREN = 34;

	public const int SEMICOLON = 35;

	public const int THEN = 36;

	public const int TRUE = 37;

	public const int VARIABLE = 38;

	public const int WS = 39;

	private ITreeAdaptor adaptor;

	private DFA2 dfa2;

	private DFA3 dfa3;

	private DFA10 dfa10;

	private DFA11 dfa11;

	public ITreeAdaptor TreeAdaptor
	{
		get
		{
			return adaptor;
		}
		set
		{
			adaptor = value;
		}
	}

	public override string[] TokenNames => tokenNames;

	public override string GrammarFileName => "Adl\\Adl.g3";

	public override void ReportError(RecognitionException e)
	{
		base.ReportError(e);
		throw e;
	}

	public AdlParser(ITokenStream input)
		: this(input, new RecognizerSharedState())
	{
	}

	public AdlParser(ITokenStream input, RecognizerSharedState state)
		: base(input, state)
	{
		ITreeAdaptor treeAdaptor = null;
		TreeAdaptor = treeAdaptor ?? new CommonTreeAdaptor();
	}

	[GrammarRule("template")]
	public template_return template()
	{
		template_return template_return = new template_return(this);
		template_return.Start = (CommonToken)input.LT(1);
		CommonTree commonTree = null;
		CommonToken commonToken = null;
		item_list_return item_list_return = null;
		CommonTree commonTree2 = null;
		try
		{
			try
			{
				commonTree = (CommonTree)adaptor.Nil();
				PushFollow(Follow._item_list_in_template138);
				item_list_return = item_list();
				PopFollow();
				if (state.failed)
				{
					return template_return;
				}
				if (state.backtracking == 0)
				{
					adaptor.AddChild(commonTree, item_list_return.Tree);
				}
				commonToken = (CommonToken)Match(input, -1, Follow._EOF_in_template140);
				if (state.failed)
				{
					return template_return;
				}
				if (state.backtracking == 0)
				{
					commonTree2 = (CommonTree)adaptor.Create(commonToken);
					adaptor.AddChild(commonTree, commonTree2);
				}
				template_return.Stop = (CommonToken)input.LT(-1);
				if (state.backtracking == 0)
				{
					template_return.Tree = (CommonTree)adaptor.RulePostProcessing(commonTree);
					adaptor.SetTokenBoundaries(template_return.Tree, template_return.Start, template_return.Stop);
					return template_return;
				}
				return template_return;
			}
			catch (RecognitionException ex)
			{
				ReportError(ex);
				Recover(input, ex);
				template_return.Tree = (CommonTree)adaptor.ErrorNode(input, template_return.Start, input.LT(-1), ex);
				return template_return;
			}
			finally
			{
			}
		}
		finally
		{
		}
	}

	[GrammarRule("item")]
	private item_return item()
	{
		item_return item_return = new item_return(this);
		item_return.Start = (CommonToken)input.LT(1);
		CommonTree commonTree = null;
		CommonToken commonToken = null;
		statement_return statement_return = null;
		CommonTree commonTree2 = null;
		try
		{
			try
			{
				int num = 2;
				try
				{
					switch (input.LA(1))
					{
					case 30:
						num = 1;
						break;
					case 13:
					case 33:
					case 38:
						num = 2;
						break;
					default:
						if (state.backtracking > 0)
						{
							state.failed = true;
							return item_return;
						}
						throw new NoViableAltException("", 1, 0, input);
					}
				}
				finally
				{
				}
				switch (num)
				{
				case 1:
					commonTree = (CommonTree)adaptor.Nil();
					commonToken = (CommonToken)Match(input, 30, Follow._PLAINTEXT_in_item153);
					if (state.failed)
					{
						return item_return;
					}
					if (state.backtracking == 0)
					{
						commonTree2 = (CommonTree)adaptor.Create(commonToken);
						adaptor.AddChild(commonTree, commonTree2);
					}
					break;
				case 2:
					commonTree = (CommonTree)adaptor.Nil();
					PushFollow(Follow._statement_in_item158);
					statement_return = statement();
					PopFollow();
					if (state.failed)
					{
						return item_return;
					}
					if (state.backtracking == 0)
					{
						adaptor.AddChild(commonTree, statement_return.Tree);
					}
					break;
				}
				item_return.Stop = (CommonToken)input.LT(-1);
				if (state.backtracking == 0)
				{
					item_return.Tree = (CommonTree)adaptor.RulePostProcessing(commonTree);
					adaptor.SetTokenBoundaries(item_return.Tree, item_return.Start, item_return.Stop);
					return item_return;
				}
				return item_return;
			}
			catch (RecognitionException ex)
			{
				ReportError(ex);
				Recover(input, ex);
				item_return.Tree = (CommonTree)adaptor.ErrorNode(input, item_return.Start, input.LT(-1), ex);
				return item_return;
			}
			finally
			{
			}
		}
		finally
		{
		}
	}

	[GrammarRule("item_list")]
	private item_list_return item_list()
	{
		item_list_return item_list_return = new item_list_return(this);
		item_list_return.Start = (CommonToken)input.LT(1);
		CommonTree commonTree = null;
		item_return item_return = null;
		RewriteRuleSubtreeStream rewriteRuleSubtreeStream = new RewriteRuleSubtreeStream(adaptor, "rule item");
		try
		{
			try
			{
				try
				{
					while (true)
					{
						int num = 2;
						try
						{
							num = dfa2.Predict(input);
						}
						catch (NoViableAltException)
						{
							throw;
						}
						finally
						{
						}
						if (num == 1)
						{
							PushFollow(Follow._item_in_item_list173);
							item_return = item();
							PopFollow();
							if (state.failed)
							{
								return item_list_return;
							}
							if (state.backtracking == 0)
							{
								rewriteRuleSubtreeStream.Add(item_return.Tree);
							}
							continue;
						}
						break;
					}
				}
				finally
				{
				}
				if (state.backtracking == 0)
				{
					item_list_return.Tree = commonTree;
					new RewriteRuleSubtreeStream(adaptor, "rule retval", item_list_return?.Tree);
					commonTree = (CommonTree)adaptor.Nil();
					CommonTree oldRoot = (CommonTree)adaptor.Nil();
					oldRoot = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(19, "ITEM_LIST"), oldRoot);
					while (rewriteRuleSubtreeStream.HasNext)
					{
						adaptor.AddChild(oldRoot, rewriteRuleSubtreeStream.NextTree());
					}
					rewriteRuleSubtreeStream.Reset();
					adaptor.AddChild(commonTree, oldRoot);
					item_list_return.Tree = commonTree;
				}
				item_list_return.Stop = (CommonToken)input.LT(-1);
				if (state.backtracking == 0)
				{
					item_list_return.Tree = (CommonTree)adaptor.RulePostProcessing(commonTree);
					adaptor.SetTokenBoundaries(item_list_return.Tree, item_list_return.Start, item_list_return.Stop);
					return item_list_return;
				}
				return item_list_return;
			}
			catch (RecognitionException ex2)
			{
				ReportError(ex2);
				Recover(input, ex2);
				item_list_return.Tree = (CommonTree)adaptor.ErrorNode(input, item_list_return.Start, input.LT(-1), ex2);
				return item_list_return;
			}
			finally
			{
			}
		}
		finally
		{
		}
	}

	[GrammarRule("statement")]
	private statement_return statement()
	{
		statement_return statement_return = new statement_return(this);
		statement_return.Start = (CommonToken)input.LT(1);
		CommonTree commonTree = null;
		CommonToken commonToken = null;
		CommonToken commonToken2 = null;
		CommonToken commonToken3 = null;
		CommonToken commonToken4 = null;
		if_then_stat_return if_then_stat_return = null;
		block_stat_return block_stat_return = null;
		expression_return expression_return = null;
		CommonTree commonTree2 = null;
		CommonTree commonTree3 = null;
		CommonTree commonTree4 = null;
		CommonTree commonTree5 = null;
		try
		{
			try
			{
				int num = 5;
				try
				{
					num = dfa3.Predict(input);
				}
				catch (NoViableAltException)
				{
					throw;
				}
				finally
				{
				}
				switch (num)
				{
				case 1:
					commonTree = (CommonTree)adaptor.Nil();
					commonToken = (CommonToken)Match(input, 38, Follow._VARIABLE_in_statement195);
					if (state.failed)
					{
						return statement_return;
					}
					if (state.backtracking == 0)
					{
						commonTree2 = (CommonTree)adaptor.Create(commonToken);
						adaptor.AddChild(commonTree, commonTree2);
					}
					break;
				case 2:
					commonTree = (CommonTree)adaptor.Nil();
					commonToken2 = (CommonToken)Match(input, 13, Follow._GLOBALVARIABLE_in_statement200);
					if (state.failed)
					{
						return statement_return;
					}
					if (state.backtracking == 0)
					{
						commonTree3 = (CommonTree)adaptor.Create(commonToken2);
						adaptor.AddChild(commonTree, commonTree3);
					}
					break;
				case 3:
					commonTree = (CommonTree)adaptor.Nil();
					PushFollow(Follow._if_then_stat_in_statement205);
					if_then_stat_return = if_then_stat();
					PopFollow();
					if (state.failed)
					{
						return statement_return;
					}
					if (state.backtracking == 0)
					{
						adaptor.AddChild(commonTree, if_then_stat_return.Tree);
					}
					break;
				case 4:
					commonTree = (CommonTree)adaptor.Nil();
					PushFollow(Follow._block_stat_in_statement210);
					block_stat_return = block_stat();
					PopFollow();
					if (state.failed)
					{
						return statement_return;
					}
					if (state.backtracking == 0)
					{
						adaptor.AddChild(commonTree, block_stat_return.Tree);
					}
					break;
				case 5:
					commonTree = (CommonTree)adaptor.Nil();
					commonToken3 = (CommonToken)Match(input, 33, Follow._PROG_START_in_statement215);
					if (state.failed)
					{
						return statement_return;
					}
					if (state.backtracking == 0)
					{
						commonTree4 = (CommonTree)adaptor.Create(commonToken3);
						adaptor.AddChild(commonTree, commonTree4);
					}
					PushFollow(Follow._expression_in_statement217);
					expression_return = expression();
					PopFollow();
					if (state.failed)
					{
						return statement_return;
					}
					if (state.backtracking == 0)
					{
						adaptor.AddChild(commonTree, expression_return.Tree);
					}
					commonToken4 = (CommonToken)Match(input, 32, Follow._PROG_END_in_statement219);
					if (state.failed)
					{
						return statement_return;
					}
					if (state.backtracking == 0)
					{
						commonTree5 = (CommonTree)adaptor.Create(commonToken4);
						adaptor.AddChild(commonTree, commonTree5);
					}
					break;
				}
				statement_return.Stop = (CommonToken)input.LT(-1);
				if (state.backtracking == 0)
				{
					statement_return.Tree = (CommonTree)adaptor.RulePostProcessing(commonTree);
					adaptor.SetTokenBoundaries(statement_return.Tree, statement_return.Start, statement_return.Stop);
					return statement_return;
				}
				return statement_return;
			}
			catch (RecognitionException ex2)
			{
				ReportError(ex2);
				Recover(input, ex2);
				statement_return.Tree = (CommonTree)adaptor.ErrorNode(input, statement_return.Start, input.LT(-1), ex2);
				return statement_return;
			}
			finally
			{
			}
		}
		finally
		{
		}
	}

	[GrammarRule("if_then_stat")]
	private if_then_stat_return if_then_stat()
	{
		if_then_stat_return if_then_stat_return = new if_then_stat_return(this);
		if_then_stat_return.Start = (CommonToken)input.LT(1);
		CommonTree commonTree = null;
		CommonToken commonToken = null;
		CommonToken commonToken2 = null;
		CommonToken commonToken3 = null;
		CommonToken commonToken4 = null;
		CommonToken commonToken5 = null;
		CommonToken commonToken6 = null;
		CommonToken commonToken7 = null;
		CommonToken commonToken8 = null;
		CommonToken commonToken9 = null;
		CommonToken commonToken10 = null;
		CommonToken commonToken11 = null;
		expression_return expression_return = null;
		item_list_return item_list_return = null;
		item_list_return item_list_return2 = null;
		CommonTree commonTree2 = null;
		CommonTree commonTree3 = null;
		CommonTree commonTree4 = null;
		CommonTree commonTree5 = null;
		CommonTree commonTree6 = null;
		CommonTree commonTree7 = null;
		CommonTree commonTree8 = null;
		CommonTree commonTree9 = null;
		CommonTree commonTree10 = null;
		CommonTree commonTree11 = null;
		CommonTree commonTree12 = null;
		try
		{
			try
			{
				commonTree = (CommonTree)adaptor.Nil();
				commonToken = (CommonToken)Match(input, 33, Follow._PROG_START_in_if_then_stat231);
				if (state.failed)
				{
					return if_then_stat_return;
				}
				if (state.backtracking == 0)
				{
					commonTree2 = (CommonTree)adaptor.Create(commonToken);
					adaptor.AddChild(commonTree, commonTree2);
				}
				commonToken2 = (CommonToken)Match(input, 17, Follow._IF_in_if_then_stat233);
				if (state.failed)
				{
					return if_then_stat_return;
				}
				if (state.backtracking == 0)
				{
					commonTree3 = (CommonTree)adaptor.Create(commonToken2);
					adaptor.AddChild(commonTree, commonTree3);
				}
				PushFollow(Follow._expression_in_if_then_stat235);
				expression_return = expression();
				PopFollow();
				if (state.failed)
				{
					return if_then_stat_return;
				}
				if (state.backtracking == 0)
				{
					adaptor.AddChild(commonTree, expression_return.Tree);
				}
				int num = 2;
				try
				{
					try
					{
						if (input.LA(1) == 36)
						{
							num = 1;
						}
					}
					finally
					{
					}
					if (num == 1)
					{
						commonToken3 = (CommonToken)Match(input, 36, Follow._THEN_in_if_then_stat237);
						if (state.failed)
						{
							return if_then_stat_return;
						}
						if (state.backtracking == 0)
						{
							commonTree4 = (CommonTree)adaptor.Create(commonToken3);
							adaptor.AddChild(commonTree, commonTree4);
						}
					}
				}
				finally
				{
				}
				commonToken4 = (CommonToken)Match(input, 32, Follow._PROG_END_in_if_then_stat240);
				if (state.failed)
				{
					return if_then_stat_return;
				}
				if (state.backtracking == 0)
				{
					commonTree5 = (CommonTree)adaptor.Create(commonToken4);
					adaptor.AddChild(commonTree, commonTree5);
				}
				PushFollow(Follow._item_list_in_if_then_stat242);
				item_list_return = item_list();
				PopFollow();
				if (state.failed)
				{
					return if_then_stat_return;
				}
				if (state.backtracking == 0)
				{
					adaptor.AddChild(commonTree, item_list_return.Tree);
				}
				int num2 = 2;
				try
				{
					try
					{
						if (input.LA(1) == 33 && input.LA(2) == 8)
						{
							num2 = 1;
						}
					}
					finally
					{
					}
					if (num2 == 1)
					{
						commonToken5 = (CommonToken)Match(input, 33, Follow._PROG_START_in_if_then_stat245);
						if (state.failed)
						{
							return if_then_stat_return;
						}
						if (state.backtracking == 0)
						{
							commonTree6 = (CommonTree)adaptor.Create(commonToken5);
							adaptor.AddChild(commonTree, commonTree6);
						}
						commonToken6 = (CommonToken)Match(input, 8, Follow._ELSE_in_if_then_stat247);
						if (state.failed)
						{
							return if_then_stat_return;
						}
						if (state.backtracking == 0)
						{
							commonTree7 = (CommonTree)adaptor.Create(commonToken6);
							adaptor.AddChild(commonTree, commonTree7);
						}
						commonToken7 = (CommonToken)Match(input, 32, Follow._PROG_END_in_if_then_stat249);
						if (state.failed)
						{
							return if_then_stat_return;
						}
						if (state.backtracking == 0)
						{
							commonTree8 = (CommonTree)adaptor.Create(commonToken7);
							adaptor.AddChild(commonTree, commonTree8);
						}
						PushFollow(Follow._item_list_in_if_then_stat251);
						item_list_return2 = item_list();
						PopFollow();
						if (state.failed)
						{
							return if_then_stat_return;
						}
						if (state.backtracking == 0)
						{
							adaptor.AddChild(commonTree, item_list_return2.Tree);
						}
					}
				}
				finally
				{
				}
				commonToken8 = (CommonToken)Match(input, 33, Follow._PROG_START_in_if_then_stat256);
				if (state.failed)
				{
					return if_then_stat_return;
				}
				if (state.backtracking == 0)
				{
					commonTree9 = (CommonTree)adaptor.Create(commonToken8);
					adaptor.AddChild(commonTree, commonTree9);
				}
				commonToken9 = (CommonToken)Match(input, 9, Follow._END_in_if_then_stat258);
				if (state.failed)
				{
					return if_then_stat_return;
				}
				if (state.backtracking == 0)
				{
					commonTree10 = (CommonTree)adaptor.Create(commonToken9);
					adaptor.AddChild(commonTree, commonTree10);
				}
				int num3 = 2;
				try
				{
					try
					{
						if (input.LA(1) == 17)
						{
							num3 = 1;
						}
					}
					finally
					{
					}
					if (num3 == 1)
					{
						commonToken10 = (CommonToken)Match(input, 17, Follow._IF_in_if_then_stat260);
						if (state.failed)
						{
							return if_then_stat_return;
						}
						if (state.backtracking == 0)
						{
							commonTree11 = (CommonTree)adaptor.Create(commonToken10);
							adaptor.AddChild(commonTree, commonTree11);
						}
					}
				}
				finally
				{
				}
				commonToken11 = (CommonToken)Match(input, 32, Follow._PROG_END_in_if_then_stat263);
				if (state.failed)
				{
					return if_then_stat_return;
				}
				if (state.backtracking == 0)
				{
					commonTree12 = (CommonTree)adaptor.Create(commonToken11);
					adaptor.AddChild(commonTree, commonTree12);
				}
				if_then_stat_return.Stop = (CommonToken)input.LT(-1);
				if (state.backtracking == 0)
				{
					if_then_stat_return.Tree = (CommonTree)adaptor.RulePostProcessing(commonTree);
					adaptor.SetTokenBoundaries(if_then_stat_return.Tree, if_then_stat_return.Start, if_then_stat_return.Stop);
					return if_then_stat_return;
				}
				return if_then_stat_return;
			}
			catch (RecognitionException ex)
			{
				ReportError(ex);
				Recover(input, ex);
				if_then_stat_return.Tree = (CommonTree)adaptor.ErrorNode(input, if_then_stat_return.Start, input.LT(-1), ex);
				return if_then_stat_return;
			}
			finally
			{
			}
		}
		finally
		{
		}
	}

	[GrammarRule("block_stat")]
	private block_stat_return block_stat()
	{
		block_stat_return block_stat_return = new block_stat_return(this);
		block_stat_return.Start = (CommonToken)input.LT(1);
		CommonTree commonTree = null;
		CommonToken commonToken = null;
		CommonToken commonToken2 = null;
		CommonToken commonToken3 = null;
		CommonToken commonToken4 = null;
		CommonToken commonToken5 = null;
		CommonToken commonToken6 = null;
		CommonToken commonToken7 = null;
		CommonToken commonToken8 = null;
		expression_return expression_return = null;
		item_list_return item_list_return = null;
		CommonTree commonTree2 = null;
		CommonTree commonTree3 = null;
		CommonTree commonTree4 = null;
		CommonTree commonTree5 = null;
		CommonTree commonTree6 = null;
		CommonTree commonTree7 = null;
		CommonTree commonTree8 = null;
		CommonTree commonTree9 = null;
		try
		{
			try
			{
				commonTree = (CommonTree)adaptor.Nil();
				commonToken = (CommonToken)Match(input, 33, Follow._PROG_START_in_block_stat275);
				if (state.failed)
				{
					return block_stat_return;
				}
				if (state.backtracking == 0)
				{
					commonTree2 = (CommonTree)adaptor.Create(commonToken);
					adaptor.AddChild(commonTree, commonTree2);
				}
				commonToken2 = (CommonToken)Match(input, 5, Follow._BLOCK_in_block_stat277);
				if (state.failed)
				{
					return block_stat_return;
				}
				if (state.backtracking == 0)
				{
					commonTree3 = (CommonTree)adaptor.Create(commonToken2);
					adaptor.AddChild(commonTree, commonTree3);
				}
				commonToken3 = (CommonToken)Match(input, 16, Follow._IDENTIFIER_in_block_stat279);
				if (state.failed)
				{
					return block_stat_return;
				}
				if (state.backtracking == 0)
				{
					commonTree4 = (CommonTree)adaptor.Create(commonToken3);
					adaptor.AddChild(commonTree, commonTree4);
				}
				commonToken4 = (CommonToken)Match(input, 18, Follow._IN_in_block_stat281);
				if (state.failed)
				{
					return block_stat_return;
				}
				if (state.backtracking == 0)
				{
					commonTree5 = (CommonTree)adaptor.Create(commonToken4);
					adaptor.AddChild(commonTree, commonTree5);
				}
				PushFollow(Follow._expression_in_block_stat283);
				expression_return = expression();
				PopFollow();
				if (state.failed)
				{
					return block_stat_return;
				}
				if (state.backtracking == 0)
				{
					adaptor.AddChild(commonTree, expression_return.Tree);
				}
				commonToken5 = (CommonToken)Match(input, 32, Follow._PROG_END_in_block_stat285);
				if (state.failed)
				{
					return block_stat_return;
				}
				if (state.backtracking == 0)
				{
					commonTree6 = (CommonTree)adaptor.Create(commonToken5);
					adaptor.AddChild(commonTree, commonTree6);
				}
				PushFollow(Follow._item_list_in_block_stat287);
				item_list_return = item_list();
				PopFollow();
				if (state.failed)
				{
					return block_stat_return;
				}
				if (state.backtracking == 0)
				{
					adaptor.AddChild(commonTree, item_list_return.Tree);
				}
				commonToken6 = (CommonToken)Match(input, 33, Follow._PROG_START_in_block_stat289);
				if (state.failed)
				{
					return block_stat_return;
				}
				if (state.backtracking == 0)
				{
					commonTree7 = (CommonTree)adaptor.Create(commonToken6);
					adaptor.AddChild(commonTree, commonTree7);
				}
				commonToken7 = (CommonToken)Match(input, 9, Follow._END_in_block_stat291);
				if (state.failed)
				{
					return block_stat_return;
				}
				if (state.backtracking == 0)
				{
					commonTree8 = (CommonTree)adaptor.Create(commonToken7);
					adaptor.AddChild(commonTree, commonTree8);
				}
				commonToken8 = (CommonToken)Match(input, 32, Follow._PROG_END_in_block_stat293);
				if (state.failed)
				{
					return block_stat_return;
				}
				if (state.backtracking == 0)
				{
					commonTree9 = (CommonTree)adaptor.Create(commonToken8);
					adaptor.AddChild(commonTree, commonTree9);
				}
				block_stat_return.Stop = (CommonToken)input.LT(-1);
				if (state.backtracking == 0)
				{
					block_stat_return.Tree = (CommonTree)adaptor.RulePostProcessing(commonTree);
					adaptor.SetTokenBoundaries(block_stat_return.Tree, block_stat_return.Start, block_stat_return.Stop);
					return block_stat_return;
				}
				return block_stat_return;
			}
			catch (RecognitionException ex)
			{
				ReportError(ex);
				Recover(input, ex);
				block_stat_return.Tree = (CommonTree)adaptor.ErrorNode(input, block_stat_return.Start, input.LT(-1), ex);
				return block_stat_return;
			}
			finally
			{
			}
		}
		finally
		{
		}
	}

	[GrammarRule("detachedExpression")]
	public detachedExpression_return detachedExpression()
	{
		detachedExpression_return detachedExpression_return = new detachedExpression_return(this);
		detachedExpression_return.Start = (CommonToken)input.LT(1);
		CommonTree commonTree = null;
		CommonToken commonToken = null;
		expression_return expression_return = null;
		CommonTree commonTree2 = null;
		try
		{
			try
			{
				commonTree = (CommonTree)adaptor.Nil();
				PushFollow(Follow._expression_in_detachedExpression307);
				expression_return = expression();
				PopFollow();
				if (state.failed)
				{
					return detachedExpression_return;
				}
				if (state.backtracking == 0)
				{
					adaptor.AddChild(commonTree, expression_return.Tree);
				}
				commonToken = (CommonToken)Match(input, -1, Follow._EOF_in_detachedExpression309);
				if (state.failed)
				{
					return detachedExpression_return;
				}
				if (state.backtracking == 0)
				{
					commonTree2 = (CommonTree)adaptor.Create(commonToken);
					adaptor.AddChild(commonTree, commonTree2);
				}
				detachedExpression_return.Stop = (CommonToken)input.LT(-1);
				if (state.backtracking == 0)
				{
					detachedExpression_return.Tree = (CommonTree)adaptor.RulePostProcessing(commonTree);
					adaptor.SetTokenBoundaries(detachedExpression_return.Tree, detachedExpression_return.Start, detachedExpression_return.Stop);
					return detachedExpression_return;
				}
				return detachedExpression_return;
			}
			catch (RecognitionException ex)
			{
				ReportError(ex);
				Recover(input, ex);
				detachedExpression_return.Tree = (CommonTree)adaptor.ErrorNode(input, detachedExpression_return.Start, input.LT(-1), ex);
				return detachedExpression_return;
			}
			finally
			{
			}
		}
		finally
		{
		}
	}

	[GrammarRule("expression")]
	private expression_return expression()
	{
		expression_return expression_return = new expression_return(this);
		expression_return.Start = (CommonToken)input.LT(1);
		CommonTree commonTree = null;
		expression_or_return expression_or_return = null;
		try
		{
			try
			{
				commonTree = (CommonTree)adaptor.Nil();
				PushFollow(Follow._expression_or_in_expression319);
				expression_or_return = expression_or();
				PopFollow();
				if (state.failed)
				{
					return expression_return;
				}
				if (state.backtracking == 0)
				{
					adaptor.AddChild(commonTree, expression_or_return.Tree);
				}
				expression_return.Stop = (CommonToken)input.LT(-1);
				if (state.backtracking == 0)
				{
					expression_return.Tree = (CommonTree)adaptor.RulePostProcessing(commonTree);
					adaptor.SetTokenBoundaries(expression_return.Tree, expression_return.Start, expression_return.Stop);
					return expression_return;
				}
				return expression_return;
			}
			catch (RecognitionException ex)
			{
				ReportError(ex);
				Recover(input, ex);
				expression_return.Tree = (CommonTree)adaptor.ErrorNode(input, expression_return.Start, input.LT(-1), ex);
				return expression_return;
			}
			finally
			{
			}
		}
		finally
		{
		}
	}

	[GrammarRule("expression_or")]
	private expression_or_return expression_or()
	{
		expression_or_return expression_or_return = new expression_or_return(this);
		expression_or_return.Start = (CommonToken)input.LT(1);
		CommonTree commonTree = null;
		CommonToken commonToken = null;
		expression_and_return expression_and_return = null;
		expression_and_return expression_and_return2 = null;
		CommonTree commonTree2 = null;
		try
		{
			try
			{
				commonTree = (CommonTree)adaptor.Nil();
				PushFollow(Follow._expression_and_in_expression_or329);
				expression_and_return = expression_and();
				PopFollow();
				if (state.failed)
				{
					return expression_or_return;
				}
				if (state.backtracking == 0)
				{
					adaptor.AddChild(commonTree, expression_and_return.Tree);
				}
				try
				{
					while (true)
					{
						int num = 2;
						try
						{
							if (input.LA(1) == 29)
							{
								num = 1;
							}
						}
						finally
						{
						}
						if (num == 1)
						{
							commonToken = (CommonToken)Match(input, 29, Follow._OR_in_expression_or332);
							if (state.failed)
							{
								return expression_or_return;
							}
							if (state.backtracking == 0)
							{
								commonTree2 = (CommonTree)adaptor.Create(commonToken);
								adaptor.AddChild(commonTree, commonTree2);
							}
							PushFollow(Follow._expression_and_in_expression_or334);
							expression_and_return2 = expression_and();
							PopFollow();
							if (state.failed)
							{
								return expression_or_return;
							}
							if (state.backtracking == 0)
							{
								adaptor.AddChild(commonTree, expression_and_return2.Tree);
							}
							continue;
						}
						break;
					}
				}
				finally
				{
				}
				expression_or_return.Stop = (CommonToken)input.LT(-1);
				if (state.backtracking == 0)
				{
					expression_or_return.Tree = (CommonTree)adaptor.RulePostProcessing(commonTree);
					adaptor.SetTokenBoundaries(expression_or_return.Tree, expression_or_return.Start, expression_or_return.Stop);
					return expression_or_return;
				}
				return expression_or_return;
			}
			catch (RecognitionException ex)
			{
				ReportError(ex);
				Recover(input, ex);
				expression_or_return.Tree = (CommonTree)adaptor.ErrorNode(input, expression_or_return.Start, input.LT(-1), ex);
				return expression_or_return;
			}
			finally
			{
			}
		}
		finally
		{
		}
	}

	[GrammarRule("expression_and")]
	private expression_and_return expression_and()
	{
		expression_and_return expression_and_return = new expression_and_return(this);
		expression_and_return.Start = (CommonToken)input.LT(1);
		CommonTree commonTree = null;
		CommonToken commonToken = null;
		expression_comp_return expression_comp_return = null;
		expression_comp_return expression_comp_return2 = null;
		CommonTree commonTree2 = null;
		try
		{
			try
			{
				commonTree = (CommonTree)adaptor.Nil();
				PushFollow(Follow._expression_comp_in_expression_and348);
				expression_comp_return = expression_comp();
				PopFollow();
				if (state.failed)
				{
					return expression_and_return;
				}
				if (state.backtracking == 0)
				{
					adaptor.AddChild(commonTree, expression_comp_return.Tree);
				}
				try
				{
					while (true)
					{
						int num = 2;
						try
						{
							if (input.LA(1) == 4)
							{
								num = 1;
							}
						}
						finally
						{
						}
						if (num == 1)
						{
							commonToken = (CommonToken)Match(input, 4, Follow._AND_in_expression_and351);
							if (state.failed)
							{
								return expression_and_return;
							}
							if (state.backtracking == 0)
							{
								commonTree2 = (CommonTree)adaptor.Create(commonToken);
								adaptor.AddChild(commonTree, commonTree2);
							}
							PushFollow(Follow._expression_comp_in_expression_and353);
							expression_comp_return2 = expression_comp();
							PopFollow();
							if (state.failed)
							{
								return expression_and_return;
							}
							if (state.backtracking == 0)
							{
								adaptor.AddChild(commonTree, expression_comp_return2.Tree);
							}
							continue;
						}
						break;
					}
				}
				finally
				{
				}
				expression_and_return.Stop = (CommonToken)input.LT(-1);
				if (state.backtracking == 0)
				{
					expression_and_return.Tree = (CommonTree)adaptor.RulePostProcessing(commonTree);
					adaptor.SetTokenBoundaries(expression_and_return.Tree, expression_and_return.Start, expression_and_return.Stop);
					return expression_and_return;
				}
				return expression_and_return;
			}
			catch (RecognitionException ex)
			{
				ReportError(ex);
				Recover(input, ex);
				expression_and_return.Tree = (CommonTree)adaptor.ErrorNode(input, expression_and_return.Start, input.LT(-1), ex);
				return expression_and_return;
			}
			finally
			{
			}
		}
		finally
		{
		}
	}

	[GrammarRule("expression_comp")]
	private expression_comp_return expression_comp()
	{
		expression_comp_return expression_comp_return = new expression_comp_return(this);
		expression_comp_return.Start = (CommonToken)input.LT(1);
		CommonTree commonTree = null;
		expression_add_return expression_add_return = null;
		operator_comp_return operator_comp_return = null;
		expression_add_return expression_add_return2 = null;
		try
		{
			try
			{
				commonTree = (CommonTree)adaptor.Nil();
				PushFollow(Follow._expression_add_in_expression_comp367);
				expression_add_return = expression_add();
				PopFollow();
				if (state.failed)
				{
					return expression_comp_return;
				}
				if (state.backtracking == 0)
				{
					adaptor.AddChild(commonTree, expression_add_return.Tree);
				}
				try
				{
					while (true)
					{
						int num = 2;
						try
						{
							int num2 = input.LA(1);
							if (num2 == 10 || num2 == 12 || num2 == 14 || num2 == 20 || num2 == 22 || num2 == 26)
							{
								num = 1;
							}
						}
						finally
						{
						}
						if (num == 1)
						{
							PushFollow(Follow._operator_comp_in_expression_comp370);
							operator_comp_return = operator_comp();
							PopFollow();
							if (state.failed)
							{
								return expression_comp_return;
							}
							if (state.backtracking == 0)
							{
								adaptor.AddChild(commonTree, operator_comp_return.Tree);
							}
							PushFollow(Follow._expression_add_in_expression_comp372);
							expression_add_return2 = expression_add();
							PopFollow();
							if (state.failed)
							{
								return expression_comp_return;
							}
							if (state.backtracking == 0)
							{
								adaptor.AddChild(commonTree, expression_add_return2.Tree);
							}
							continue;
						}
						break;
					}
				}
				finally
				{
				}
				expression_comp_return.Stop = (CommonToken)input.LT(-1);
				if (state.backtracking == 0)
				{
					expression_comp_return.Tree = (CommonTree)adaptor.RulePostProcessing(commonTree);
					adaptor.SetTokenBoundaries(expression_comp_return.Tree, expression_comp_return.Start, expression_comp_return.Stop);
					return expression_comp_return;
				}
				return expression_comp_return;
			}
			catch (RecognitionException ex)
			{
				ReportError(ex);
				Recover(input, ex);
				expression_comp_return.Tree = (CommonTree)adaptor.ErrorNode(input, expression_comp_return.Start, input.LT(-1), ex);
				return expression_comp_return;
			}
			finally
			{
			}
		}
		finally
		{
		}
	}

	[GrammarRule("operator_comp")]
	private operator_comp_return operator_comp()
	{
		operator_comp_return operator_comp_return = new operator_comp_return(this);
		operator_comp_return.Start = (CommonToken)input.LT(1);
		CommonTree commonTree = null;
		CommonToken commonToken = null;
		try
		{
			try
			{
				commonTree = (CommonTree)adaptor.Nil();
				commonToken = (CommonToken)input.LT(1);
				if (input.LA(1) == 10 || input.LA(1) == 12 || input.LA(1) == 14 || input.LA(1) == 20 || input.LA(1) == 22 || input.LA(1) == 26)
				{
					input.Consume();
					if (state.backtracking == 0)
					{
						adaptor.AddChild(commonTree, (CommonTree)adaptor.Create(commonToken));
					}
					state.errorRecovery = false;
					state.failed = false;
					operator_comp_return.Stop = (CommonToken)input.LT(-1);
					if (state.backtracking == 0)
					{
						operator_comp_return.Tree = (CommonTree)adaptor.RulePostProcessing(commonTree);
						adaptor.SetTokenBoundaries(operator_comp_return.Tree, operator_comp_return.Start, operator_comp_return.Stop);
						return operator_comp_return;
					}
					return operator_comp_return;
				}
				if (state.backtracking > 0)
				{
					state.failed = true;
					return operator_comp_return;
				}
				throw new MismatchedSetException(null, input);
			}
			catch (RecognitionException ex)
			{
				ReportError(ex);
				Recover(input, ex);
				operator_comp_return.Tree = (CommonTree)adaptor.ErrorNode(input, operator_comp_return.Start, input.LT(-1), ex);
				return operator_comp_return;
			}
			finally
			{
			}
		}
		finally
		{
		}
	}

	[GrammarRule("expression_add")]
	private expression_add_return expression_add()
	{
		expression_add_return expression_add_return = new expression_add_return(this);
		expression_add_return.Start = (CommonToken)input.LT(1);
		CommonTree commonTree = null;
		expression_mult_return expression_mult_return = null;
		operator_add_return operator_add_return = null;
		expression_mult_return expression_mult_return2 = null;
		try
		{
			try
			{
				commonTree = (CommonTree)adaptor.Nil();
				PushFollow(Follow._expression_mult_in_expression_add423);
				expression_mult_return = expression_mult();
				PopFollow();
				if (state.failed)
				{
					return expression_add_return;
				}
				if (state.backtracking == 0)
				{
					adaptor.AddChild(commonTree, expression_mult_return.Tree);
				}
				try
				{
					while (true)
					{
						int num = 2;
						try
						{
							num = dfa10.Predict(input);
						}
						catch (NoViableAltException)
						{
							throw;
						}
						finally
						{
						}
						if (num == 1)
						{
							PushFollow(Follow._operator_add_in_expression_add426);
							operator_add_return = operator_add();
							PopFollow();
							if (state.failed)
							{
								return expression_add_return;
							}
							if (state.backtracking == 0)
							{
								adaptor.AddChild(commonTree, operator_add_return.Tree);
							}
							PushFollow(Follow._expression_mult_in_expression_add428);
							expression_mult_return2 = expression_mult();
							PopFollow();
							if (state.failed)
							{
								return expression_add_return;
							}
							if (state.backtracking == 0)
							{
								adaptor.AddChild(commonTree, expression_mult_return2.Tree);
							}
							continue;
						}
						break;
					}
				}
				finally
				{
				}
				expression_add_return.Stop = (CommonToken)input.LT(-1);
				if (state.backtracking == 0)
				{
					expression_add_return.Tree = (CommonTree)adaptor.RulePostProcessing(commonTree);
					adaptor.SetTokenBoundaries(expression_add_return.Tree, expression_add_return.Start, expression_add_return.Stop);
					return expression_add_return;
				}
				return expression_add_return;
			}
			catch (RecognitionException ex2)
			{
				ReportError(ex2);
				Recover(input, ex2);
				expression_add_return.Tree = (CommonTree)adaptor.ErrorNode(input, expression_add_return.Start, input.LT(-1), ex2);
				return expression_add_return;
			}
			finally
			{
			}
		}
		finally
		{
		}
	}

	[GrammarRule("operator_add")]
	private operator_add_return operator_add()
	{
		operator_add_return operator_add_return = new operator_add_return(this);
		operator_add_return.Start = (CommonToken)input.LT(1);
		CommonTree commonTree = null;
		CommonToken commonToken = null;
		try
		{
			try
			{
				commonTree = (CommonTree)adaptor.Nil();
				commonToken = (CommonToken)input.LT(1);
				if (input.LA(1) == 24 || input.LA(1) == 31)
				{
					input.Consume();
					if (state.backtracking == 0)
					{
						adaptor.AddChild(commonTree, (CommonTree)adaptor.Create(commonToken));
					}
					state.errorRecovery = false;
					state.failed = false;
					operator_add_return.Stop = (CommonToken)input.LT(-1);
					if (state.backtracking == 0)
					{
						operator_add_return.Tree = (CommonTree)adaptor.RulePostProcessing(commonTree);
						adaptor.SetTokenBoundaries(operator_add_return.Tree, operator_add_return.Start, operator_add_return.Stop);
						return operator_add_return;
					}
					return operator_add_return;
				}
				if (state.backtracking > 0)
				{
					state.failed = true;
					return operator_add_return;
				}
				throw new MismatchedSetException(null, input);
			}
			catch (RecognitionException ex)
			{
				ReportError(ex);
				Recover(input, ex);
				operator_add_return.Tree = (CommonTree)adaptor.ErrorNode(input, operator_add_return.Start, input.LT(-1), ex);
				return operator_add_return;
			}
			finally
			{
			}
		}
		finally
		{
		}
	}

	[GrammarRule("expression_mult")]
	private expression_mult_return expression_mult()
	{
		expression_mult_return expression_mult_return = new expression_mult_return(this);
		expression_mult_return.Start = (CommonToken)input.LT(1);
		CommonTree commonTree = null;
		expression_unary_return expression_unary_return = null;
		operator_mult_return operator_mult_return = null;
		expression_unary_return expression_unary_return2 = null;
		try
		{
			try
			{
				commonTree = (CommonTree)adaptor.Nil();
				PushFollow(Follow._expression_unary_in_expression_mult459);
				expression_unary_return = expression_unary();
				PopFollow();
				if (state.failed)
				{
					return expression_mult_return;
				}
				if (state.backtracking == 0)
				{
					adaptor.AddChild(commonTree, expression_unary_return.Tree);
				}
				try
				{
					while (true)
					{
						int num = 2;
						try
						{
							num = dfa11.Predict(input);
						}
						catch (NoViableAltException)
						{
							throw;
						}
						finally
						{
						}
						if (num == 1)
						{
							PushFollow(Follow._operator_mult_in_expression_mult462);
							operator_mult_return = operator_mult();
							PopFollow();
							if (state.failed)
							{
								return expression_mult_return;
							}
							if (state.backtracking == 0)
							{
								adaptor.AddChild(commonTree, operator_mult_return.Tree);
							}
							PushFollow(Follow._expression_unary_in_expression_mult464);
							expression_unary_return2 = expression_unary();
							PopFollow();
							if (state.failed)
							{
								return expression_mult_return;
							}
							if (state.backtracking == 0)
							{
								adaptor.AddChild(commonTree, expression_unary_return2.Tree);
							}
							continue;
						}
						break;
					}
				}
				finally
				{
				}
				expression_mult_return.Stop = (CommonToken)input.LT(-1);
				if (state.backtracking == 0)
				{
					expression_mult_return.Tree = (CommonTree)adaptor.RulePostProcessing(commonTree);
					adaptor.SetTokenBoundaries(expression_mult_return.Tree, expression_mult_return.Start, expression_mult_return.Stop);
					return expression_mult_return;
				}
				return expression_mult_return;
			}
			catch (RecognitionException ex2)
			{
				ReportError(ex2);
				Recover(input, ex2);
				expression_mult_return.Tree = (CommonTree)adaptor.ErrorNode(input, expression_mult_return.Start, input.LT(-1), ex2);
				return expression_mult_return;
			}
			finally
			{
			}
		}
		finally
		{
		}
	}

	[GrammarRule("operator_mult")]
	private operator_mult_return operator_mult()
	{
		operator_mult_return operator_mult_return = new operator_mult_return(this);
		operator_mult_return.Start = (CommonToken)input.LT(1);
		CommonTree commonTree = null;
		CommonToken commonToken = null;
		try
		{
			try
			{
				commonTree = (CommonTree)adaptor.Nil();
				commonToken = (CommonToken)input.LT(1);
				if (input.LA(1) == 7 || input.LA(1) == 25)
				{
					input.Consume();
					if (state.backtracking == 0)
					{
						adaptor.AddChild(commonTree, (CommonTree)adaptor.Create(commonToken));
					}
					state.errorRecovery = false;
					state.failed = false;
					operator_mult_return.Stop = (CommonToken)input.LT(-1);
					if (state.backtracking == 0)
					{
						operator_mult_return.Tree = (CommonTree)adaptor.RulePostProcessing(commonTree);
						adaptor.SetTokenBoundaries(operator_mult_return.Tree, operator_mult_return.Start, operator_mult_return.Stop);
						return operator_mult_return;
					}
					return operator_mult_return;
				}
				if (state.backtracking > 0)
				{
					state.failed = true;
					return operator_mult_return;
				}
				throw new MismatchedSetException(null, input);
			}
			catch (RecognitionException ex)
			{
				ReportError(ex);
				Recover(input, ex);
				operator_mult_return.Tree = (CommonTree)adaptor.ErrorNode(input, operator_mult_return.Start, input.LT(-1), ex);
				return operator_mult_return;
			}
			finally
			{
			}
		}
		finally
		{
		}
	}

	[GrammarRule("expression_unary")]
	private expression_unary_return expression_unary()
	{
		expression_unary_return expression_unary_return = new expression_unary_return(this);
		expression_unary_return.Start = (CommonToken)input.LT(1);
		CommonTree commonTree = null;
		operator_unary_return operator_unary_return = null;
		atom_return atom_return = null;
		atom_return atom_return2 = null;
		try
		{
			try
			{
				int num = 2;
				try
				{
					int num2 = input.LA(1);
					switch (num2)
					{
					case 24:
						num = 1;
						goto end_IL_002a;
					default:
						if (num2 < 37 || num2 > 38)
						{
							break;
						}
						goto case 6;
					case 6:
					case 11:
					case 13:
					case 16:
					case 21:
					case 27:
					case 28:
						num = 2;
						goto end_IL_002a;
					}
					if (state.backtracking > 0)
					{
						state.failed = true;
						return expression_unary_return;
					}
					throw new NoViableAltException("", 12, 0, input);
					end_IL_002a:;
				}
				finally
				{
				}
				switch (num)
				{
				case 1:
					commonTree = (CommonTree)adaptor.Nil();
					PushFollow(Follow._operator_unary_in_expression_unary495);
					operator_unary_return = operator_unary();
					PopFollow();
					if (state.failed)
					{
						return expression_unary_return;
					}
					if (state.backtracking == 0)
					{
						adaptor.AddChild(commonTree, operator_unary_return.Tree);
					}
					PushFollow(Follow._atom_in_expression_unary497);
					atom_return = atom();
					PopFollow();
					if (state.failed)
					{
						return expression_unary_return;
					}
					if (state.backtracking == 0)
					{
						adaptor.AddChild(commonTree, atom_return.Tree);
					}
					break;
				case 2:
					commonTree = (CommonTree)adaptor.Nil();
					PushFollow(Follow._atom_in_expression_unary502);
					atom_return2 = atom();
					PopFollow();
					if (state.failed)
					{
						return expression_unary_return;
					}
					if (state.backtracking == 0)
					{
						adaptor.AddChild(commonTree, atom_return2.Tree);
					}
					break;
				}
				expression_unary_return.Stop = (CommonToken)input.LT(-1);
				if (state.backtracking == 0)
				{
					expression_unary_return.Tree = (CommonTree)adaptor.RulePostProcessing(commonTree);
					adaptor.SetTokenBoundaries(expression_unary_return.Tree, expression_unary_return.Start, expression_unary_return.Stop);
					return expression_unary_return;
				}
				return expression_unary_return;
			}
			catch (RecognitionException ex)
			{
				ReportError(ex);
				Recover(input, ex);
				expression_unary_return.Tree = (CommonTree)adaptor.ErrorNode(input, expression_unary_return.Start, input.LT(-1), ex);
				return expression_unary_return;
			}
			finally
			{
			}
		}
		finally
		{
		}
	}

	[GrammarRule("operator_unary")]
	private operator_unary_return operator_unary()
	{
		operator_unary_return operator_unary_return = new operator_unary_return(this);
		operator_unary_return.Start = (CommonToken)input.LT(1);
		CommonTree commonTree = null;
		CommonToken commonToken = null;
		CommonTree commonTree2 = null;
		try
		{
			try
			{
				commonTree = (CommonTree)adaptor.Nil();
				commonToken = (CommonToken)Match(input, 24, Follow._MINUS_in_operator_unary514);
				if (state.failed)
				{
					return operator_unary_return;
				}
				if (state.backtracking == 0)
				{
					commonTree2 = (CommonTree)adaptor.Create(commonToken);
					adaptor.AddChild(commonTree, commonTree2);
				}
				operator_unary_return.Stop = (CommonToken)input.LT(-1);
				if (state.backtracking == 0)
				{
					operator_unary_return.Tree = (CommonTree)adaptor.RulePostProcessing(commonTree);
					adaptor.SetTokenBoundaries(operator_unary_return.Tree, operator_unary_return.Start, operator_unary_return.Stop);
					return operator_unary_return;
				}
				return operator_unary_return;
			}
			catch (RecognitionException ex)
			{
				ReportError(ex);
				Recover(input, ex);
				operator_unary_return.Tree = (CommonTree)adaptor.ErrorNode(input, operator_unary_return.Start, input.LT(-1), ex);
				return operator_unary_return;
			}
			finally
			{
			}
		}
		finally
		{
		}
	}

	[GrammarRule("atom")]
	private atom_return atom()
	{
		atom_return atom_return = new atom_return(this);
		atom_return.Start = (CommonToken)input.LT(1);
		CommonTree commonTree = null;
		CommonToken commonToken = null;
		CommonToken commonToken2 = null;
		CommonToken commonToken3 = null;
		CommonToken commonToken4 = null;
		expression_return expression_return = null;
		constant_return constant_return = null;
		function_call_return function_call_return = null;
		CommonTree commonTree2 = null;
		CommonTree commonTree3 = null;
		CommonTree commonTree4 = null;
		CommonTree commonTree5 = null;
		try
		{
			try
			{
				int num = 5;
				try
				{
					switch (input.LA(1))
					{
					case 21:
						num = 1;
						break;
					case 38:
						num = 2;
						break;
					case 13:
						num = 3;
						break;
					case 6:
					case 11:
					case 27:
					case 28:
					case 37:
						num = 4;
						break;
					case 16:
						num = 5;
						break;
					default:
						if (state.backtracking > 0)
						{
							state.failed = true;
							return atom_return;
						}
						throw new NoViableAltException("", 13, 0, input);
					}
				}
				finally
				{
				}
				switch (num)
				{
				case 1:
					commonTree = (CommonTree)adaptor.Nil();
					commonToken = (CommonToken)Match(input, 21, Follow._LPAREN_in_atom526);
					if (state.failed)
					{
						return atom_return;
					}
					if (state.backtracking == 0)
					{
						commonTree2 = (CommonTree)adaptor.Create(commonToken);
						adaptor.AddChild(commonTree, commonTree2);
					}
					PushFollow(Follow._expression_in_atom528);
					expression_return = expression();
					PopFollow();
					if (state.failed)
					{
						return atom_return;
					}
					if (state.backtracking == 0)
					{
						adaptor.AddChild(commonTree, expression_return.Tree);
					}
					commonToken2 = (CommonToken)Match(input, 34, Follow._RPAREN_in_atom530);
					if (state.failed)
					{
						return atom_return;
					}
					if (state.backtracking == 0)
					{
						commonTree3 = (CommonTree)adaptor.Create(commonToken2);
						adaptor.AddChild(commonTree, commonTree3);
					}
					break;
				case 2:
					commonTree = (CommonTree)adaptor.Nil();
					commonToken3 = (CommonToken)Match(input, 38, Follow._VARIABLE_in_atom536);
					if (state.failed)
					{
						return atom_return;
					}
					if (state.backtracking == 0)
					{
						commonTree4 = (CommonTree)adaptor.Create(commonToken3);
						adaptor.AddChild(commonTree, commonTree4);
					}
					break;
				case 3:
					commonTree = (CommonTree)adaptor.Nil();
					commonToken4 = (CommonToken)Match(input, 13, Follow._GLOBALVARIABLE_in_atom541);
					if (state.failed)
					{
						return atom_return;
					}
					if (state.backtracking == 0)
					{
						commonTree5 = (CommonTree)adaptor.Create(commonToken4);
						adaptor.AddChild(commonTree, commonTree5);
					}
					break;
				case 4:
					commonTree = (CommonTree)adaptor.Nil();
					PushFollow(Follow._constant_in_atom546);
					constant_return = constant();
					PopFollow();
					if (state.failed)
					{
						return atom_return;
					}
					if (state.backtracking == 0)
					{
						adaptor.AddChild(commonTree, constant_return.Tree);
					}
					break;
				case 5:
					commonTree = (CommonTree)adaptor.Nil();
					PushFollow(Follow._function_call_in_atom551);
					function_call_return = function_call();
					PopFollow();
					if (state.failed)
					{
						return atom_return;
					}
					if (state.backtracking == 0)
					{
						adaptor.AddChild(commonTree, function_call_return.Tree);
					}
					break;
				}
				atom_return.Stop = (CommonToken)input.LT(-1);
				if (state.backtracking == 0)
				{
					atom_return.Tree = (CommonTree)adaptor.RulePostProcessing(commonTree);
					adaptor.SetTokenBoundaries(atom_return.Tree, atom_return.Start, atom_return.Stop);
					return atom_return;
				}
				return atom_return;
			}
			catch (RecognitionException ex)
			{
				ReportError(ex);
				Recover(input, ex);
				atom_return.Tree = (CommonTree)adaptor.ErrorNode(input, atom_return.Start, input.LT(-1), ex);
				return atom_return;
			}
			finally
			{
			}
		}
		finally
		{
		}
	}

	[GrammarRule("constant")]
	private constant_return constant()
	{
		constant_return constant_return = new constant_return(this);
		constant_return.Start = (CommonToken)input.LT(1);
		CommonTree commonTree = null;
		CommonToken commonToken = null;
		try
		{
			try
			{
				commonTree = (CommonTree)adaptor.Nil();
				commonToken = (CommonToken)input.LT(1);
				if (input.LA(1) == 6 || input.LA(1) == 11 || (input.LA(1) >= 27 && input.LA(1) <= 28) || input.LA(1) == 37)
				{
					input.Consume();
					if (state.backtracking == 0)
					{
						adaptor.AddChild(commonTree, (CommonTree)adaptor.Create(commonToken));
					}
					state.errorRecovery = false;
					state.failed = false;
					constant_return.Stop = (CommonToken)input.LT(-1);
					if (state.backtracking == 0)
					{
						constant_return.Tree = (CommonTree)adaptor.RulePostProcessing(commonTree);
						adaptor.SetTokenBoundaries(constant_return.Tree, constant_return.Start, constant_return.Stop);
						return constant_return;
					}
					return constant_return;
				}
				if (state.backtracking > 0)
				{
					state.failed = true;
					return constant_return;
				}
				throw new MismatchedSetException(null, input);
			}
			catch (RecognitionException ex)
			{
				ReportError(ex);
				Recover(input, ex);
				constant_return.Tree = (CommonTree)adaptor.ErrorNode(input, constant_return.Start, input.LT(-1), ex);
				return constant_return;
			}
			finally
			{
			}
		}
		finally
		{
		}
	}

	[GrammarRule("function_call")]
	private function_call_return function_call()
	{
		function_call_return function_call_return = new function_call_return(this);
		function_call_return.Start = (CommonToken)input.LT(1);
		CommonTree commonTree = null;
		CommonToken commonToken = null;
		CommonToken commonToken2 = null;
		CommonToken commonToken3 = null;
		param_list_return param_list_return = null;
		CommonTree commonTree2 = null;
		CommonTree commonTree3 = null;
		CommonTree commonTree4 = null;
		try
		{
			try
			{
				commonTree = (CommonTree)adaptor.Nil();
				commonToken = (CommonToken)Match(input, 16, Follow._IDENTIFIER_in_function_call596);
				if (state.failed)
				{
					return function_call_return;
				}
				if (state.backtracking == 0)
				{
					commonTree2 = (CommonTree)adaptor.Create(commonToken);
					adaptor.AddChild(commonTree, commonTree2);
				}
				commonToken2 = (CommonToken)Match(input, 21, Follow._LPAREN_in_function_call598);
				if (state.failed)
				{
					return function_call_return;
				}
				if (state.backtracking == 0)
				{
					commonTree3 = (CommonTree)adaptor.Create(commonToken2);
					adaptor.AddChild(commonTree, commonTree3);
				}
				PushFollow(Follow._param_list_in_function_call600);
				param_list_return = param_list();
				PopFollow();
				if (state.failed)
				{
					return function_call_return;
				}
				if (state.backtracking == 0)
				{
					adaptor.AddChild(commonTree, param_list_return.Tree);
				}
				commonToken3 = (CommonToken)Match(input, 34, Follow._RPAREN_in_function_call602);
				if (state.failed)
				{
					return function_call_return;
				}
				if (state.backtracking == 0)
				{
					commonTree4 = (CommonTree)adaptor.Create(commonToken3);
					adaptor.AddChild(commonTree, commonTree4);
				}
				function_call_return.Stop = (CommonToken)input.LT(-1);
				if (state.backtracking == 0)
				{
					function_call_return.Tree = (CommonTree)adaptor.RulePostProcessing(commonTree);
					adaptor.SetTokenBoundaries(function_call_return.Tree, function_call_return.Start, function_call_return.Stop);
					return function_call_return;
				}
				return function_call_return;
			}
			catch (RecognitionException ex)
			{
				ReportError(ex);
				Recover(input, ex);
				function_call_return.Tree = (CommonTree)adaptor.ErrorNode(input, function_call_return.Start, input.LT(-1), ex);
				return function_call_return;
			}
			finally
			{
			}
		}
		finally
		{
		}
	}

	[GrammarRule("param_list")]
	private param_list_return param_list()
	{
		param_list_return param_list_return = new param_list_return(this);
		param_list_return.Start = (CommonToken)input.LT(1);
		CommonTree commonTree = null;
		CommonToken commonToken = null;
		expression_return expression_return = null;
		expression_return expression_return2 = null;
		CommonTree commonTree2 = null;
		try
		{
			try
			{
				commonTree = (CommonTree)adaptor.Nil();
				int num = 2;
				try
				{
					try
					{
						int num2 = input.LA(1);
						switch (num2)
						{
						default:
							if (num2 >= 37 && num2 <= 38)
							{
								break;
							}
							goto end_IL_003e;
						case 6:
						case 11:
						case 13:
						case 16:
						case 21:
						case 24:
						case 27:
						case 28:
							break;
						}
						num = 1;
						end_IL_003e:;
					}
					finally
					{
					}
					if (num == 1)
					{
						PushFollow(Follow._expression_in_param_list615);
						expression_return = expression();
						PopFollow();
						if (state.failed)
						{
							return param_list_return;
						}
						if (state.backtracking == 0)
						{
							adaptor.AddChild(commonTree, expression_return.Tree);
						}
						try
						{
							while (true)
							{
								int num3 = 2;
								try
								{
									if (input.LA(1) == 35)
									{
										num3 = 1;
									}
								}
								finally
								{
								}
								if (num3 == 1)
								{
									commonToken = (CommonToken)Match(input, 35, Follow._SEMICOLON_in_param_list618);
									if (state.failed)
									{
										return param_list_return;
									}
									if (state.backtracking == 0)
									{
										commonTree2 = (CommonTree)adaptor.Create(commonToken);
										adaptor.AddChild(commonTree, commonTree2);
									}
									PushFollow(Follow._expression_in_param_list620);
									expression_return2 = expression();
									PopFollow();
									if (state.failed)
									{
										return param_list_return;
									}
									if (state.backtracking == 0)
									{
										adaptor.AddChild(commonTree, expression_return2.Tree);
									}
									continue;
								}
								break;
							}
						}
						finally
						{
						}
					}
				}
				finally
				{
				}
				param_list_return.Stop = (CommonToken)input.LT(-1);
				if (state.backtracking == 0)
				{
					param_list_return.Tree = (CommonTree)adaptor.RulePostProcessing(commonTree);
					adaptor.SetTokenBoundaries(param_list_return.Tree, param_list_return.Start, param_list_return.Stop);
					return param_list_return;
				}
				return param_list_return;
			}
			catch (RecognitionException ex)
			{
				ReportError(ex);
				Recover(input, ex);
				param_list_return.Tree = (CommonTree)adaptor.ErrorNode(input, param_list_return.Start, input.LT(-1), ex);
				return param_list_return;
			}
			finally
			{
			}
		}
		finally
		{
		}
	}

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa2 = new DFA2(this);
		dfa3 = new DFA3(this);
		dfa10 = new DFA10(this);
		dfa11 = new DFA11(this);
	}
}
