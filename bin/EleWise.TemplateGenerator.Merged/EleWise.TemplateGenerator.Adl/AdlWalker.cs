using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using EleWise.TemplateGenerator.Adl.Tree;

namespace EleWise.TemplateGenerator.Adl;

[GeneratedCode("ANTLR", "3.3.1.7705")]
[CLSCompliant(false)]
public class AdlWalker : TreeParser
{
	public sealed class template_return : TreeRuleReturnScope<CommonTree>, IAstRuleReturnScope<CommonTree>, IAstRuleReturnScope, IRuleReturnScope
	{
		public Template Template;

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

		public template_return(AdlWalker grammar)
		{
		}
	}

	private sealed class item_list_return : TreeRuleReturnScope<CommonTree>, IAstRuleReturnScope<CommonTree>, IAstRuleReturnScope, IRuleReturnScope
	{
		public List<TreeItem> Items;

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

		public item_list_return(AdlWalker grammar)
		{
		}
	}

	private sealed class item_return : TreeRuleReturnScope<CommonTree>, IAstRuleReturnScope<CommonTree>, IAstRuleReturnScope, IRuleReturnScope
	{
		public TreeItem Item;

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

		public item_return(AdlWalker grammar)
		{
		}
	}

	private sealed class plaintext_return : TreeRuleReturnScope<CommonTree>, IAstRuleReturnScope<CommonTree>, IAstRuleReturnScope, IRuleReturnScope
	{
		public string Text;

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

		public plaintext_return(AdlWalker grammar)
		{
		}
	}

	private sealed class statement_return : TreeRuleReturnScope<CommonTree>, IAstRuleReturnScope<CommonTree>, IAstRuleReturnScope, IRuleReturnScope
	{
		public TreeItem Item;

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

		public statement_return(AdlWalker grammar)
		{
		}
	}

	private sealed class if_then_stat_return : TreeRuleReturnScope<CommonTree>, IAstRuleReturnScope<CommonTree>, IAstRuleReturnScope, IRuleReturnScope
	{
		public IfStatement Statement;

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

		public if_then_stat_return(AdlWalker grammar)
		{
		}
	}

	private sealed class block_stat_return : TreeRuleReturnScope<CommonTree>, IAstRuleReturnScope<CommonTree>, IAstRuleReturnScope, IRuleReturnScope
	{
		public BlockStatement Block;

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

		public block_stat_return(AdlWalker grammar)
		{
		}
	}

	private sealed class variable_return : TreeRuleReturnScope<CommonTree>, IAstRuleReturnScope<CommonTree>, IAstRuleReturnScope, IRuleReturnScope
	{
		public Variable Variable;

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

		public variable_return(AdlWalker grammar)
		{
		}
	}

	private sealed class globalvariable_return : TreeRuleReturnScope<CommonTree>, IAstRuleReturnScope<CommonTree>, IAstRuleReturnScope, IRuleReturnScope
	{
		public Globalvariable Globalvariable;

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

		public globalvariable_return(AdlWalker grammar)
		{
		}
	}

	public sealed class detachedExpression_return : TreeRuleReturnScope<CommonTree>, IAstRuleReturnScope<CommonTree>, IAstRuleReturnScope, IRuleReturnScope
	{
		public Expression Expression;

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

		public detachedExpression_return(AdlWalker grammar)
		{
		}
	}

	private sealed class expression_return : TreeRuleReturnScope<CommonTree>, IAstRuleReturnScope<CommonTree>, IAstRuleReturnScope, IRuleReturnScope
	{
		public Expression Expression;

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

		public expression_return(AdlWalker grammar)
		{
		}
	}

	private sealed class expression_or_return : TreeRuleReturnScope<CommonTree>, IAstRuleReturnScope<CommonTree>, IAstRuleReturnScope, IRuleReturnScope
	{
		public Expression Expression;

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

		public expression_or_return(AdlWalker grammar)
		{
		}
	}

	private sealed class expression_and_return : TreeRuleReturnScope<CommonTree>, IAstRuleReturnScope<CommonTree>, IAstRuleReturnScope, IRuleReturnScope
	{
		public Expression Expression;

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

		public expression_and_return(AdlWalker grammar)
		{
		}
	}

	private sealed class expression_comp_return : TreeRuleReturnScope<CommonTree>, IAstRuleReturnScope<CommonTree>, IAstRuleReturnScope, IRuleReturnScope
	{
		public Expression Expression;

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

		public expression_comp_return(AdlWalker grammar)
		{
		}
	}

	private sealed class operator_comp_return : TreeRuleReturnScope<CommonTree>, IAstRuleReturnScope<CommonTree>, IAstRuleReturnScope, IRuleReturnScope
	{
		public BinaryOperator Operator;

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

		public operator_comp_return(AdlWalker grammar)
		{
		}
	}

	private sealed class expression_add_return : TreeRuleReturnScope<CommonTree>, IAstRuleReturnScope<CommonTree>, IAstRuleReturnScope, IRuleReturnScope
	{
		public Expression Expression;

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

		public expression_add_return(AdlWalker grammar)
		{
		}
	}

	private sealed class operator_add_return : TreeRuleReturnScope<CommonTree>, IAstRuleReturnScope<CommonTree>, IAstRuleReturnScope, IRuleReturnScope
	{
		public BinaryOperator Operator;

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

		public operator_add_return(AdlWalker grammar)
		{
		}
	}

	private sealed class expression_mult_return : TreeRuleReturnScope<CommonTree>, IAstRuleReturnScope<CommonTree>, IAstRuleReturnScope, IRuleReturnScope
	{
		public Expression Expression;

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

		public expression_mult_return(AdlWalker grammar)
		{
		}
	}

	private sealed class operator_mult_return : TreeRuleReturnScope<CommonTree>, IAstRuleReturnScope<CommonTree>, IAstRuleReturnScope, IRuleReturnScope
	{
		public BinaryOperator Operator;

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

		public operator_mult_return(AdlWalker grammar)
		{
		}
	}

	private sealed class expression_unary_return : TreeRuleReturnScope<CommonTree>, IAstRuleReturnScope<CommonTree>, IAstRuleReturnScope, IRuleReturnScope
	{
		public Expression Expression;

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

		public expression_unary_return(AdlWalker grammar)
		{
		}
	}

	private sealed class operator_unary_return : TreeRuleReturnScope<CommonTree>, IAstRuleReturnScope<CommonTree>, IAstRuleReturnScope, IRuleReturnScope
	{
		public UnaryOperator Operator;

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

		public operator_unary_return(AdlWalker grammar)
		{
		}
	}

	private sealed class atom_return : TreeRuleReturnScope<CommonTree>, IAstRuleReturnScope<CommonTree>, IAstRuleReturnScope, IRuleReturnScope
	{
		public Expression Expression;

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

		public atom_return(AdlWalker grammar)
		{
		}
	}

	private sealed class constant_return : TreeRuleReturnScope<CommonTree>, IAstRuleReturnScope<CommonTree>, IAstRuleReturnScope, IRuleReturnScope
	{
		public Constant Constant;

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

		public constant_return(AdlWalker grammar)
		{
		}
	}

	private sealed class function_call_return : TreeRuleReturnScope<CommonTree>, IAstRuleReturnScope<CommonTree>, IAstRuleReturnScope, IRuleReturnScope
	{
		public FunctionCall Expression;

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

		public function_call_return(AdlWalker grammar)
		{
		}
	}

	private sealed class identifier_return : TreeRuleReturnScope<CommonTree>, IAstRuleReturnScope<CommonTree>, IAstRuleReturnScope, IRuleReturnScope
	{
		public string Value;

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

		public identifier_return(AdlWalker grammar)
		{
		}
	}

	private sealed class param_list_return : TreeRuleReturnScope<CommonTree>, IAstRuleReturnScope<CommonTree>, IAstRuleReturnScope, IRuleReturnScope
	{
		public List<Expression> Params;

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

		public param_list_return(AdlWalker grammar)
		{
		}
	}

	private static class Follow
	{
		public static readonly BitSet _item_list_in_template76 = new BitSet(new ulong[1]);

		public static readonly BitSet _EOF_in_template80 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _ITEM_LIST_in_item_list103 = new BitSet(new ulong[1] { 4uL });

		public static readonly BitSet _item_in_item_list108 = new BitSet(new ulong[1] { 284541591560uL });

		public static readonly BitSet _plaintext_in_item132 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _statement_in_item141 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _PLAINTEXT_in_plaintext162 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _variable_in_statement182 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _globalvariable_in_statement191 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _if_then_stat_in_statement200 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _block_stat_in_statement209 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _PROG_START_in_statement218 = new BitSet(new ulong[1] { 412738463808uL });

		public static readonly BitSet _expression_in_statement222 = new BitSet(new ulong[1] { 4294967296uL });

		public static readonly BitSet _PROG_END_in_statement226 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _PROG_START_in_if_then_stat252 = new BitSet(new ulong[1] { 131072uL });

		public static readonly BitSet _IF_in_if_then_stat258 = new BitSet(new ulong[1] { 412738463808uL });

		public static readonly BitSet _expression_in_if_then_stat264 = new BitSet(new ulong[1] { 73014444032uL });

		public static readonly BitSet _THEN_in_if_then_stat269 = new BitSet(new ulong[1] { 4294967296uL });

		public static readonly BitSet _PROG_END_in_if_then_stat274 = new BitSet(new ulong[1] { 524288uL });

		public static readonly BitSet _item_list_in_if_then_stat280 = new BitSet(new ulong[1] { 8589934592uL });

		public static readonly BitSet _PROG_START_in_if_then_stat288 = new BitSet(new ulong[1] { 256uL });

		public static readonly BitSet _ELSE_in_if_then_stat290 = new BitSet(new ulong[1] { 4294967296uL });

		public static readonly BitSet _PROG_END_in_if_then_stat292 = new BitSet(new ulong[1] { 524288uL });

		public static readonly BitSet _item_list_in_if_then_stat296 = new BitSet(new ulong[1] { 8589934592uL });

		public static readonly BitSet _PROG_START_in_if_then_stat306 = new BitSet(new ulong[1] { 512uL });

		public static readonly BitSet _END_in_if_then_stat310 = new BitSet(new ulong[1] { 4295098368uL });

		public static readonly BitSet _IF_in_if_then_stat314 = new BitSet(new ulong[1] { 4294967296uL });

		public static readonly BitSet _PROG_END_in_if_then_stat321 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _PROG_START_in_block_stat347 = new BitSet(new ulong[1] { 32uL });

		public static readonly BitSet _BLOCK_in_block_stat352 = new BitSet(new ulong[1] { 65536uL });

		public static readonly BitSet _identifier_in_block_stat358 = new BitSet(new ulong[1] { 262144uL });

		public static readonly BitSet _IN_in_block_stat363 = new BitSet(new ulong[1] { 412738463808uL });

		public static readonly BitSet _expression_in_block_stat368 = new BitSet(new ulong[1] { 4294967296uL });

		public static readonly BitSet _PROG_END_in_block_stat375 = new BitSet(new ulong[1] { 524288uL });

		public static readonly BitSet _item_list_in_block_stat381 = new BitSet(new ulong[1] { 8589934592uL });

		public static readonly BitSet _PROG_START_in_block_stat388 = new BitSet(new ulong[1] { 512uL });

		public static readonly BitSet _END_in_block_stat392 = new BitSet(new ulong[1] { 4294967296uL });

		public static readonly BitSet _PROG_END_in_block_stat398 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _VARIABLE_in_variable418 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _GLOBALVARIABLE_in_globalvariable438 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _expression_in_detachedExpression460 = new BitSet(new ulong[1]);

		public static readonly BitSet _EOF_in_detachedExpression464 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _expression_or_in_expression482 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _expression_and_in_expression_or500 = new BitSet(new ulong[1] { 536870914uL });

		public static readonly BitSet _OR_in_expression_or509 = new BitSet(new ulong[1] { 412738463808uL });

		public static readonly BitSet _expression_and_in_expression_or513 = new BitSet(new ulong[1] { 536870914uL });

		public static readonly BitSet _expression_comp_in_expression_and537 = new BitSet(new ulong[1] { 18uL });

		public static readonly BitSet _AND_in_expression_and546 = new BitSet(new ulong[1] { 412738463808uL });

		public static readonly BitSet _expression_comp_in_expression_and550 = new BitSet(new ulong[1] { 18uL });

		public static readonly BitSet _expression_add_in_expression_comp574 = new BitSet(new ulong[1] { 72373250uL });

		public static readonly BitSet _operator_comp_in_expression_comp585 = new BitSet(new ulong[1] { 412738463808uL });

		public static readonly BitSet _expression_add_in_expression_comp589 = new BitSet(new ulong[1] { 72373250uL });

		public static readonly BitSet _EQUAL_in_operator_comp611 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _NEQUAL_in_operator_comp618 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _GE_in_operator_comp625 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _GT_in_operator_comp632 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _LE_in_operator_comp639 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _LT_in_operator_comp646 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _expression_mult_in_expression_add666 = new BitSet(new ulong[1] { 2164260866uL });

		public static readonly BitSet _operator_add_in_expression_add677 = new BitSet(new ulong[1] { 412738463808uL });

		public static readonly BitSet _expression_mult_in_expression_add681 = new BitSet(new ulong[1] { 2164260866uL });

		public static readonly BitSet _PLUS_in_operator_add703 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _MINUS_in_operator_add710 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _expression_unary_in_expression_mult730 = new BitSet(new ulong[1] { 33554562uL });

		public static readonly BitSet _operator_mult_in_expression_mult742 = new BitSet(new ulong[1] { 412738463808uL });

		public static readonly BitSet _expression_unary_in_expression_mult746 = new BitSet(new ulong[1] { 33554562uL });

		public static readonly BitSet _MULT_in_operator_mult768 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _DIVISION_in_operator_mult775 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _operator_unary_in_expression_unary796 = new BitSet(new ulong[1] { 412738463808uL });

		public static readonly BitSet _atom_in_expression_unary800 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _atom_in_expression_unary810 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _MINUS_in_operator_unary828 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _LPAREN_in_atom846 = new BitSet(new ulong[1] { 412738463808uL });

		public static readonly BitSet _expression_in_atom850 = new BitSet(new ulong[1] { 17179869184uL });

		public static readonly BitSet _RPAREN_in_atom852 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _variable_in_atom861 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _globalvariable_in_atom870 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _constant_in_atom879 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _function_call_in_atom888 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _NUMBER_in_constant908 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _CHARACTER_STRING_in_constant917 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _TRUE_in_constant926 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _FALSE_in_constant935 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _NULL_in_constant944 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _IDENTIFIER_in_function_call970 = new BitSet(new ulong[1] { 2097152uL });

		public static readonly BitSet _LPAREN_in_function_call977 = new BitSet(new ulong[1] { 429918332992uL });

		public static readonly BitSet _param_list_in_function_call983 = new BitSet(new ulong[1] { 17179869184uL });

		public static readonly BitSet _RPAREN_in_function_call990 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _IDENTIFIER_in_identifier1009 = new BitSet(new ulong[1] { 2uL });

		public static readonly BitSet _expression_in_param_list1036 = new BitSet(new ulong[1] { 34359738370uL });

		public static readonly BitSet _SEMICOLON_in_param_list1041 = new BitSet(new ulong[1] { 412738463808uL });

		public static readonly BitSet _expression_in_param_list1045 = new BitSet(new ulong[1] { 34359738370uL });
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

	public override string GrammarFileName => "Adl\\AdlWalker.g3";

	public override void ReportError(RecognitionException e)
	{
		base.ReportError(e);
		throw e;
	}

	public AdlWalker(ITreeNodeStream input)
		: this(input, new RecognizerSharedState())
	{
	}

	public AdlWalker(ITreeNodeStream input, RecognizerSharedState state)
		: base(input, state)
	{
		ITreeAdaptor treeAdaptor = null;
		TreeAdaptor = treeAdaptor ?? new CommonTreeAdaptor();
	}

	[GrammarRule("template")]
	public template_return template()
	{
		template_return template_return = new template_return(this);
		template_return.Start = (CommonTree)input.LT(1);
		CommonTree commonTree = null;
		CommonTree commonTree2 = null;
		item_list_return item_list_return = null;
		CommonTree commonTree3 = null;
		template_return.Template = new Template();
		try
		{
			try
			{
				commonTree = (CommonTree)adaptor.Nil();
				_ = (CommonTree)input.LT(1);
				PushFollow(Follow._item_list_in_template76);
				item_list_return = item_list();
				PopFollow();
				adaptor.AddChild(commonTree, item_list_return.Tree);
				template_return.Template.Items.AddRange(item_list_return?.Items);
				template_return.Template.RefreshParent();
				_ = (CommonTree)input.LT(1);
				commonTree2 = (CommonTree)Match(input, -1, Follow._EOF_in_template80);
				commonTree3 = (CommonTree)adaptor.DupNode(commonTree2);
				adaptor.AddChild(commonTree, commonTree3);
				template_return.Tree = (CommonTree)adaptor.RulePostProcessing(commonTree);
				return template_return;
			}
			catch (RecognitionException ex)
			{
				ReportError(ex);
				Recover(input, ex);
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

	[GrammarRule("item_list")]
	private item_list_return item_list()
	{
		item_list_return item_list_return = new item_list_return(this);
		item_list_return.Start = (CommonTree)input.LT(1);
		CommonTree commonTree = null;
		CommonTree commonTree2 = null;
		item_return item_return = null;
		CommonTree commonTree3 = null;
		item_list_return.Items = new List<TreeItem>();
		try
		{
			try
			{
				commonTree = (CommonTree)adaptor.Nil();
				CommonTree commonTree4 = (CommonTree)input.LT(1);
				CommonTree oldRoot = (CommonTree)adaptor.Nil();
				_ = (CommonTree)input.LT(1);
				commonTree2 = (CommonTree)Match(input, 19, Follow._ITEM_LIST_in_item_list103);
				commonTree3 = (CommonTree)adaptor.DupNode(commonTree2);
				oldRoot = (CommonTree)adaptor.BecomeRoot(commonTree3, oldRoot);
				if (input.LA(1) == 2)
				{
					Match(input, 2, null);
					try
					{
						while (true)
						{
							int num = 2;
							try
							{
								int num2 = input.LA(1);
								if (num2 == 13 || num2 == 30 || num2 == 33 || num2 == 38)
								{
									num = 1;
								}
							}
							finally
							{
							}
							if (num == 1)
							{
								_ = (CommonTree)input.LT(1);
								PushFollow(Follow._item_in_item_list108);
								item_return = item();
								PopFollow();
								adaptor.AddChild(oldRoot, item_return.Tree);
								item_list_return.Items.Add(item_return?.Item);
								continue;
							}
							break;
						}
					}
					finally
					{
					}
					Match(input, 3, null);
				}
				adaptor.AddChild(commonTree, oldRoot);
				item_list_return.Tree = (CommonTree)adaptor.RulePostProcessing(commonTree);
				return item_list_return;
			}
			catch (RecognitionException ex)
			{
				ReportError(ex);
				Recover(input, ex);
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

	[GrammarRule("item")]
	private item_return item()
	{
		item_return item_return = new item_return(this);
		item_return.Start = (CommonTree)input.LT(1);
		CommonTree commonTree = null;
		plaintext_return plaintext_return = null;
		statement_return statement_return = null;
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
						throw new NoViableAltException("", 2, 0, input);
					}
				}
				finally
				{
				}
				switch (num)
				{
				case 1:
					commonTree = (CommonTree)adaptor.Nil();
					_ = (CommonTree)input.LT(1);
					PushFollow(Follow._plaintext_in_item132);
					plaintext_return = plaintext();
					PopFollow();
					adaptor.AddChild(commonTree, plaintext_return.Tree);
					item_return.Item = new PlainText
					{
						Start = (plaintext_return?.Tree).Token.StartIndex,
						Stop = (plaintext_return?.Tree).Token.StopIndex,
						Text = plaintext_return?.Text
					};
					break;
				case 2:
					commonTree = (CommonTree)adaptor.Nil();
					_ = (CommonTree)input.LT(1);
					PushFollow(Follow._statement_in_item141);
					statement_return = statement();
					PopFollow();
					adaptor.AddChild(commonTree, statement_return.Tree);
					item_return.Item = statement_return?.Item;
					break;
				}
				item_return.Tree = (CommonTree)adaptor.RulePostProcessing(commonTree);
				return item_return;
			}
			catch (RecognitionException ex)
			{
				ReportError(ex);
				Recover(input, ex);
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

	[GrammarRule("plaintext")]
	private plaintext_return plaintext()
	{
		plaintext_return plaintext_return = new plaintext_return(this);
		plaintext_return.Start = (CommonTree)input.LT(1);
		CommonTree commonTree = null;
		CommonTree commonTree2 = null;
		CommonTree commonTree3 = null;
		try
		{
			try
			{
				commonTree = (CommonTree)adaptor.Nil();
				_ = (CommonTree)input.LT(1);
				commonTree2 = (CommonTree)Match(input, 30, Follow._PLAINTEXT_in_plaintext162);
				commonTree3 = (CommonTree)adaptor.DupNode(commonTree2);
				adaptor.AddChild(commonTree, commonTree3);
				plaintext_return.Text = input.TokenStream.ToString(input.TreeAdaptor.GetTokenStartIndex(plaintext_return.Start), input.TreeAdaptor.GetTokenStopIndex(plaintext_return.Start));
				plaintext_return.Tree = (CommonTree)adaptor.RulePostProcessing(commonTree);
				return plaintext_return;
			}
			catch (RecognitionException ex)
			{
				ReportError(ex);
				Recover(input, ex);
				return plaintext_return;
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
		statement_return.Start = (CommonTree)input.LT(1);
		CommonTree commonTree = null;
		CommonTree commonTree2 = null;
		CommonTree commonTree3 = null;
		variable_return variable_return = null;
		globalvariable_return globalvariable_return = null;
		if_then_stat_return if_then_stat_return = null;
		block_stat_return block_stat_return = null;
		expression_return expression_return = null;
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
					case 38:
						num = 1;
						break;
					case 13:
						num = 2;
						break;
					case 33:
						switch (input.LA(2))
						{
						case 17:
							num = 3;
							break;
						case 5:
							num = 4;
							break;
						case 6:
						case 11:
						case 13:
						case 16:
						case 21:
						case 24:
						case 27:
						case 28:
						case 37:
						case 38:
							num = 5;
							break;
						default:
							throw new NoViableAltException("", 3, 3, input);
						}
						break;
					default:
						throw new NoViableAltException("", 3, 0, input);
					}
				}
				finally
				{
				}
				switch (num)
				{
				case 1:
					commonTree = (CommonTree)adaptor.Nil();
					_ = (CommonTree)input.LT(1);
					PushFollow(Follow._variable_in_statement182);
					variable_return = variable();
					PopFollow();
					adaptor.AddChild(commonTree, variable_return.Tree);
					statement_return.Item = variable_return?.Variable;
					break;
				case 2:
					commonTree = (CommonTree)adaptor.Nil();
					_ = (CommonTree)input.LT(1);
					PushFollow(Follow._globalvariable_in_statement191);
					globalvariable_return = globalvariable();
					PopFollow();
					adaptor.AddChild(commonTree, globalvariable_return.Tree);
					statement_return.Item = globalvariable_return?.Globalvariable;
					break;
				case 3:
					commonTree = (CommonTree)adaptor.Nil();
					_ = (CommonTree)input.LT(1);
					PushFollow(Follow._if_then_stat_in_statement200);
					if_then_stat_return = if_then_stat();
					PopFollow();
					adaptor.AddChild(commonTree, if_then_stat_return.Tree);
					statement_return.Item = if_then_stat_return?.Statement;
					break;
				case 4:
					commonTree = (CommonTree)adaptor.Nil();
					_ = (CommonTree)input.LT(1);
					PushFollow(Follow._block_stat_in_statement209);
					block_stat_return = block_stat();
					PopFollow();
					adaptor.AddChild(commonTree, block_stat_return.Tree);
					statement_return.Item = block_stat_return?.Block;
					break;
				case 5:
					commonTree = (CommonTree)adaptor.Nil();
					_ = (CommonTree)input.LT(1);
					commonTree2 = (CommonTree)Match(input, 33, Follow._PROG_START_in_statement218);
					commonTree4 = (CommonTree)adaptor.DupNode(commonTree2);
					adaptor.AddChild(commonTree, commonTree4);
					_ = (CommonTree)input.LT(1);
					PushFollow(Follow._expression_in_statement222);
					expression_return = expression();
					PopFollow();
					adaptor.AddChild(commonTree, expression_return.Tree);
					_ = (CommonTree)input.LT(1);
					commonTree3 = (CommonTree)Match(input, 32, Follow._PROG_END_in_statement226);
					commonTree5 = (CommonTree)adaptor.DupNode(commonTree3);
					adaptor.AddChild(commonTree, commonTree5);
					statement_return.Item = new ExpressionStatement
					{
						Expression = expression_return?.Expression,
						Start = commonTree4.Token.StartIndex,
						Stop = commonTree5.Token.StopIndex
					};
					break;
				}
				statement_return.Tree = (CommonTree)adaptor.RulePostProcessing(commonTree);
				return statement_return;
			}
			catch (RecognitionException ex)
			{
				ReportError(ex);
				Recover(input, ex);
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
		if_then_stat_return.Start = (CommonTree)input.LT(1);
		CommonTree commonTree = null;
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
		expression_return expression_return = null;
		item_list_return item_list_return = null;
		item_list_return item_list_return2 = null;
		CommonTree commonTree13 = null;
		CommonTree commonTree14 = null;
		CommonTree commonTree15 = null;
		CommonTree commonTree16 = null;
		CommonTree commonTree17 = null;
		CommonTree commonTree18 = null;
		CommonTree commonTree19 = null;
		CommonTree commonTree20 = null;
		CommonTree commonTree21 = null;
		CommonTree commonTree22 = null;
		CommonTree commonTree23 = null;
		if_then_stat_return.Statement = new IfStatement();
		try
		{
			try
			{
				commonTree = (CommonTree)adaptor.Nil();
				_ = (CommonTree)input.LT(1);
				commonTree2 = (CommonTree)Match(input, 33, Follow._PROG_START_in_if_then_stat252);
				commonTree13 = (CommonTree)adaptor.DupNode(commonTree2);
				adaptor.AddChild(commonTree, commonTree13);
				if_then_stat_return.Statement.Start = commonTree13.Token.StartIndex;
				_ = (CommonTree)input.LT(1);
				commonTree4 = (CommonTree)Match(input, 17, Follow._IF_in_if_then_stat258);
				commonTree15 = (CommonTree)adaptor.DupNode(commonTree4);
				adaptor.AddChild(commonTree, commonTree15);
				_ = (CommonTree)input.LT(1);
				PushFollow(Follow._expression_in_if_then_stat264);
				expression_return = expression();
				PopFollow();
				adaptor.AddChild(commonTree, expression_return.Tree);
				if_then_stat_return.Statement.Condition = expression_return?.Expression;
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
						_ = (CommonTree)input.LT(1);
						commonTree5 = (CommonTree)Match(input, 36, Follow._THEN_in_if_then_stat269);
						commonTree16 = (CommonTree)adaptor.DupNode(commonTree5);
						adaptor.AddChild(commonTree, commonTree16);
					}
				}
				finally
				{
				}
				_ = (CommonTree)input.LT(1);
				commonTree6 = (CommonTree)Match(input, 32, Follow._PROG_END_in_if_then_stat274);
				commonTree17 = (CommonTree)adaptor.DupNode(commonTree6);
				adaptor.AddChild(commonTree, commonTree17);
				_ = (CommonTree)input.LT(1);
				PushFollow(Follow._item_list_in_if_then_stat280);
				item_list_return = item_list();
				PopFollow();
				adaptor.AddChild(commonTree, item_list_return.Tree);
				if_then_stat_return.Statement.TrueContent.Items.AddRange(item_list_return?.Items);
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
						_ = (CommonTree)input.LT(1);
						commonTree7 = (CommonTree)Match(input, 33, Follow._PROG_START_in_if_then_stat288);
						commonTree18 = (CommonTree)adaptor.DupNode(commonTree7);
						adaptor.AddChild(commonTree, commonTree18);
						_ = (CommonTree)input.LT(1);
						commonTree8 = (CommonTree)Match(input, 8, Follow._ELSE_in_if_then_stat290);
						commonTree19 = (CommonTree)adaptor.DupNode(commonTree8);
						adaptor.AddChild(commonTree, commonTree19);
						_ = (CommonTree)input.LT(1);
						commonTree9 = (CommonTree)Match(input, 32, Follow._PROG_END_in_if_then_stat292);
						commonTree20 = (CommonTree)adaptor.DupNode(commonTree9);
						adaptor.AddChild(commonTree, commonTree20);
						_ = (CommonTree)input.LT(1);
						PushFollow(Follow._item_list_in_if_then_stat296);
						item_list_return2 = item_list();
						PopFollow();
						adaptor.AddChild(commonTree, item_list_return2.Tree);
						if_then_stat_return.Statement.FalseContent = new CompositeTreeItem();
						if_then_stat_return.Statement.FalseContent.Items.AddRange(item_list_return2?.Items);
					}
				}
				finally
				{
				}
				_ = (CommonTree)input.LT(1);
				commonTree10 = (CommonTree)Match(input, 33, Follow._PROG_START_in_if_then_stat306);
				commonTree21 = (CommonTree)adaptor.DupNode(commonTree10);
				adaptor.AddChild(commonTree, commonTree21);
				_ = (CommonTree)input.LT(1);
				commonTree11 = (CommonTree)Match(input, 9, Follow._END_in_if_then_stat310);
				commonTree22 = (CommonTree)adaptor.DupNode(commonTree11);
				adaptor.AddChild(commonTree, commonTree22);
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
						_ = (CommonTree)input.LT(1);
						commonTree12 = (CommonTree)Match(input, 17, Follow._IF_in_if_then_stat314);
						commonTree23 = (CommonTree)adaptor.DupNode(commonTree12);
						adaptor.AddChild(commonTree, commonTree23);
					}
				}
				finally
				{
				}
				_ = (CommonTree)input.LT(1);
				commonTree3 = (CommonTree)Match(input, 32, Follow._PROG_END_in_if_then_stat321);
				commonTree14 = (CommonTree)adaptor.DupNode(commonTree3);
				adaptor.AddChild(commonTree, commonTree14);
				if_then_stat_return.Statement.Stop = commonTree14.Token.StartIndex;
				if_then_stat_return.Tree = (CommonTree)adaptor.RulePostProcessing(commonTree);
				return if_then_stat_return;
			}
			catch (RecognitionException ex)
			{
				ReportError(ex);
				Recover(input, ex);
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
		block_stat_return.Start = (CommonTree)input.LT(1);
		CommonTree commonTree = null;
		CommonTree commonTree2 = null;
		CommonTree commonTree3 = null;
		CommonTree commonTree4 = null;
		CommonTree commonTree5 = null;
		CommonTree commonTree6 = null;
		CommonTree commonTree7 = null;
		CommonTree commonTree8 = null;
		identifier_return identifier_return = null;
		expression_return expression_return = null;
		item_list_return item_list_return = null;
		CommonTree commonTree9 = null;
		CommonTree commonTree10 = null;
		CommonTree commonTree11 = null;
		CommonTree commonTree12 = null;
		CommonTree commonTree13 = null;
		CommonTree commonTree14 = null;
		CommonTree commonTree15 = null;
		block_stat_return.Block = new BlockStatement();
		try
		{
			try
			{
				commonTree = (CommonTree)adaptor.Nil();
				_ = (CommonTree)input.LT(1);
				commonTree2 = (CommonTree)Match(input, 33, Follow._PROG_START_in_block_stat347);
				commonTree9 = (CommonTree)adaptor.DupNode(commonTree2);
				adaptor.AddChild(commonTree, commonTree9);
				block_stat_return.Block.Start = commonTree9.Token.StartIndex;
				_ = (CommonTree)input.LT(1);
				commonTree6 = (CommonTree)Match(input, 5, Follow._BLOCK_in_block_stat352);
				commonTree13 = (CommonTree)adaptor.DupNode(commonTree6);
				adaptor.AddChild(commonTree, commonTree13);
				_ = (CommonTree)input.LT(1);
				PushFollow(Follow._identifier_in_block_stat358);
				identifier_return = identifier();
				PopFollow();
				adaptor.AddChild(commonTree, identifier_return.Tree);
				block_stat_return.Block.Identifier = identifier_return?.Value;
				_ = (CommonTree)input.LT(1);
				commonTree7 = (CommonTree)Match(input, 18, Follow._IN_in_block_stat363);
				commonTree14 = (CommonTree)adaptor.DupNode(commonTree7);
				adaptor.AddChild(commonTree, commonTree14);
				_ = (CommonTree)input.LT(1);
				PushFollow(Follow._expression_in_block_stat368);
				expression_return = expression();
				PopFollow();
				adaptor.AddChild(commonTree, expression_return.Tree);
				block_stat_return.Block.Expression = expression_return?.Expression;
				_ = (CommonTree)input.LT(1);
				commonTree3 = (CommonTree)Match(input, 32, Follow._PROG_END_in_block_stat375);
				commonTree10 = (CommonTree)adaptor.DupNode(commonTree3);
				adaptor.AddChild(commonTree, commonTree10);
				_ = (CommonTree)input.LT(1);
				PushFollow(Follow._item_list_in_block_stat381);
				item_list_return = item_list();
				PopFollow();
				adaptor.AddChild(commonTree, item_list_return.Tree);
				block_stat_return.Block.Content.Items.AddRange(item_list_return?.Items);
				_ = (CommonTree)input.LT(1);
				commonTree4 = (CommonTree)Match(input, 33, Follow._PROG_START_in_block_stat388);
				commonTree11 = (CommonTree)adaptor.DupNode(commonTree4);
				adaptor.AddChild(commonTree, commonTree11);
				_ = (CommonTree)input.LT(1);
				commonTree8 = (CommonTree)Match(input, 9, Follow._END_in_block_stat392);
				commonTree15 = (CommonTree)adaptor.DupNode(commonTree8);
				adaptor.AddChild(commonTree, commonTree15);
				_ = (CommonTree)input.LT(1);
				commonTree5 = (CommonTree)Match(input, 32, Follow._PROG_END_in_block_stat398);
				commonTree12 = (CommonTree)adaptor.DupNode(commonTree5);
				adaptor.AddChild(commonTree, commonTree12);
				block_stat_return.Block.Stop = commonTree12.Token.StartIndex;
				block_stat_return.Tree = (CommonTree)adaptor.RulePostProcessing(commonTree);
				return block_stat_return;
			}
			catch (RecognitionException ex)
			{
				ReportError(ex);
				Recover(input, ex);
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

	[GrammarRule("variable")]
	private variable_return variable()
	{
		variable_return variable_return = new variable_return(this);
		variable_return.Start = (CommonTree)input.LT(1);
		CommonTree commonTree = null;
		CommonTree commonTree2 = null;
		CommonTree commonTree3 = null;
		try
		{
			try
			{
				commonTree = (CommonTree)adaptor.Nil();
				_ = (CommonTree)input.LT(1);
				commonTree2 = (CommonTree)Match(input, 38, Follow._VARIABLE_in_variable418);
				commonTree3 = (CommonTree)adaptor.DupNode(commonTree2);
				adaptor.AddChild(commonTree, commonTree3);
				variable_return.Variable = new Variable
				{
					Name = input.TokenStream.ToString(input.TreeAdaptor.GetTokenStartIndex(variable_return.Start), input.TreeAdaptor.GetTokenStopIndex(variable_return.Start)).Substring(2, input.TokenStream.ToString(input.TreeAdaptor.GetTokenStartIndex(variable_return.Start), input.TreeAdaptor.GetTokenStopIndex(variable_return.Start)).Length - 3),
					Start = commonTree3.Token.StartIndex,
					Stop = commonTree3.Token.StopIndex
				};
				variable_return.Tree = (CommonTree)adaptor.RulePostProcessing(commonTree);
				return variable_return;
			}
			catch (RecognitionException ex)
			{
				ReportError(ex);
				Recover(input, ex);
				return variable_return;
			}
			finally
			{
			}
		}
		finally
		{
		}
	}

	[GrammarRule("globalvariable")]
	private globalvariable_return globalvariable()
	{
		globalvariable_return globalvariable_return = new globalvariable_return(this);
		globalvariable_return.Start = (CommonTree)input.LT(1);
		CommonTree commonTree = null;
		CommonTree commonTree2 = null;
		CommonTree commonTree3 = null;
		try
		{
			try
			{
				commonTree = (CommonTree)adaptor.Nil();
				_ = (CommonTree)input.LT(1);
				commonTree2 = (CommonTree)Match(input, 13, Follow._GLOBALVARIABLE_in_globalvariable438);
				commonTree3 = (CommonTree)adaptor.DupNode(commonTree2);
				adaptor.AddChild(commonTree, commonTree3);
				globalvariable_return.Globalvariable = new Globalvariable
				{
					Name = input.TokenStream.ToString(input.TreeAdaptor.GetTokenStartIndex(globalvariable_return.Start), input.TreeAdaptor.GetTokenStopIndex(globalvariable_return.Start)).Substring(2, input.TokenStream.ToString(input.TreeAdaptor.GetTokenStartIndex(globalvariable_return.Start), input.TreeAdaptor.GetTokenStopIndex(globalvariable_return.Start)).Length - 3),
					Start = commonTree3.Token.StartIndex,
					Stop = commonTree3.Token.StopIndex
				};
				globalvariable_return.Tree = (CommonTree)adaptor.RulePostProcessing(commonTree);
				return globalvariable_return;
			}
			catch (RecognitionException ex)
			{
				ReportError(ex);
				Recover(input, ex);
				return globalvariable_return;
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
		detachedExpression_return.Start = (CommonTree)input.LT(1);
		CommonTree commonTree = null;
		CommonTree commonTree2 = null;
		expression_return expression_return = null;
		CommonTree commonTree3 = null;
		try
		{
			try
			{
				commonTree = (CommonTree)adaptor.Nil();
				_ = (CommonTree)input.LT(1);
				PushFollow(Follow._expression_in_detachedExpression460);
				expression_return = expression();
				PopFollow();
				adaptor.AddChild(commonTree, expression_return.Tree);
				detachedExpression_return.Expression = expression_return?.Expression;
				_ = (CommonTree)input.LT(1);
				commonTree2 = (CommonTree)Match(input, -1, Follow._EOF_in_detachedExpression464);
				commonTree3 = (CommonTree)adaptor.DupNode(commonTree2);
				adaptor.AddChild(commonTree, commonTree3);
				detachedExpression_return.Tree = (CommonTree)adaptor.RulePostProcessing(commonTree);
				return detachedExpression_return;
			}
			catch (RecognitionException ex)
			{
				ReportError(ex);
				Recover(input, ex);
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
		expression_return.Start = (CommonTree)input.LT(1);
		CommonTree commonTree = null;
		expression_or_return expression_or_return = null;
		try
		{
			try
			{
				commonTree = (CommonTree)adaptor.Nil();
				_ = (CommonTree)input.LT(1);
				PushFollow(Follow._expression_or_in_expression482);
				expression_or_return = expression_or();
				PopFollow();
				adaptor.AddChild(commonTree, expression_or_return.Tree);
				expression_return.Expression = expression_or_return?.Expression;
				expression_return.Tree = (CommonTree)adaptor.RulePostProcessing(commonTree);
				return expression_return;
			}
			catch (RecognitionException ex)
			{
				ReportError(ex);
				Recover(input, ex);
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
		expression_or_return.Start = (CommonTree)input.LT(1);
		CommonTree commonTree = null;
		CommonTree commonTree2 = null;
		expression_and_return expression_and_return = null;
		expression_and_return expression_and_return2 = null;
		CommonTree commonTree3 = null;
		try
		{
			try
			{
				commonTree = (CommonTree)adaptor.Nil();
				_ = (CommonTree)input.LT(1);
				PushFollow(Follow._expression_and_in_expression_or500);
				expression_and_return = expression_and();
				PopFollow();
				adaptor.AddChild(commonTree, expression_and_return.Tree);
				expression_or_return.Expression = expression_and_return?.Expression;
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
							_ = (CommonTree)input.LT(1);
							commonTree2 = (CommonTree)Match(input, 29, Follow._OR_in_expression_or509);
							commonTree3 = (CommonTree)adaptor.DupNode(commonTree2);
							adaptor.AddChild(commonTree, commonTree3);
							_ = (CommonTree)input.LT(1);
							PushFollow(Follow._expression_and_in_expression_or513);
							expression_and_return2 = expression_and();
							PopFollow();
							adaptor.AddChild(commonTree, expression_and_return2.Tree);
							expression_or_return.Expression = new BinaryExpression
							{
								Operand1 = expression_or_return.Expression,
								Operator = BinaryOperator.Or,
								Operand2 = expression_and_return2?.Expression
							};
							continue;
						}
						break;
					}
				}
				finally
				{
				}
				expression_or_return.Tree = (CommonTree)adaptor.RulePostProcessing(commonTree);
				return expression_or_return;
			}
			catch (RecognitionException ex)
			{
				ReportError(ex);
				Recover(input, ex);
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
		expression_and_return.Start = (CommonTree)input.LT(1);
		CommonTree commonTree = null;
		CommonTree commonTree2 = null;
		expression_comp_return expression_comp_return = null;
		expression_comp_return expression_comp_return2 = null;
		CommonTree commonTree3 = null;
		try
		{
			try
			{
				commonTree = (CommonTree)adaptor.Nil();
				_ = (CommonTree)input.LT(1);
				PushFollow(Follow._expression_comp_in_expression_and537);
				expression_comp_return = expression_comp();
				PopFollow();
				adaptor.AddChild(commonTree, expression_comp_return.Tree);
				expression_and_return.Expression = expression_comp_return?.Expression;
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
							_ = (CommonTree)input.LT(1);
							commonTree2 = (CommonTree)Match(input, 4, Follow._AND_in_expression_and546);
							commonTree3 = (CommonTree)adaptor.DupNode(commonTree2);
							adaptor.AddChild(commonTree, commonTree3);
							_ = (CommonTree)input.LT(1);
							PushFollow(Follow._expression_comp_in_expression_and550);
							expression_comp_return2 = expression_comp();
							PopFollow();
							adaptor.AddChild(commonTree, expression_comp_return2.Tree);
							expression_and_return.Expression = new BinaryExpression
							{
								Operand1 = expression_and_return.Expression,
								Operator = BinaryOperator.And,
								Operand2 = expression_comp_return2?.Expression
							};
							continue;
						}
						break;
					}
				}
				finally
				{
				}
				expression_and_return.Tree = (CommonTree)adaptor.RulePostProcessing(commonTree);
				return expression_and_return;
			}
			catch (RecognitionException ex)
			{
				ReportError(ex);
				Recover(input, ex);
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
		expression_comp_return.Start = (CommonTree)input.LT(1);
		CommonTree commonTree = null;
		expression_add_return expression_add_return = null;
		operator_comp_return operator_comp_return = null;
		expression_add_return expression_add_return2 = null;
		try
		{
			try
			{
				commonTree = (CommonTree)adaptor.Nil();
				_ = (CommonTree)input.LT(1);
				PushFollow(Follow._expression_add_in_expression_comp574);
				expression_add_return = expression_add();
				PopFollow();
				adaptor.AddChild(commonTree, expression_add_return.Tree);
				expression_comp_return.Expression = expression_add_return?.Expression;
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
							_ = (CommonTree)input.LT(1);
							PushFollow(Follow._operator_comp_in_expression_comp585);
							operator_comp_return = operator_comp();
							PopFollow();
							adaptor.AddChild(commonTree, operator_comp_return.Tree);
							_ = (CommonTree)input.LT(1);
							PushFollow(Follow._expression_add_in_expression_comp589);
							expression_add_return2 = expression_add();
							PopFollow();
							adaptor.AddChild(commonTree, expression_add_return2.Tree);
							expression_comp_return.Expression = new BinaryExpression
							{
								Operand1 = expression_comp_return.Expression,
								Operator = (operator_comp_return?.Operator ?? BinaryOperator.Equal),
								Operand2 = expression_add_return2?.Expression
							};
							continue;
						}
						break;
					}
				}
				finally
				{
				}
				expression_comp_return.Tree = (CommonTree)adaptor.RulePostProcessing(commonTree);
				return expression_comp_return;
			}
			catch (RecognitionException ex)
			{
				ReportError(ex);
				Recover(input, ex);
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
		operator_comp_return.Start = (CommonTree)input.LT(1);
		CommonTree commonTree = null;
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
		CommonTree commonTree13 = null;
		try
		{
			try
			{
				int num = 6;
				try
				{
					num = input.LA(1) switch
					{
						10 => 1, 
						26 => 2, 
						12 => 3, 
						14 => 4, 
						20 => 5, 
						22 => 6, 
						_ => throw new NoViableAltException("", 10, 0, input), 
					};
				}
				finally
				{
				}
				switch (num)
				{
				case 1:
					commonTree = (CommonTree)adaptor.Nil();
					_ = (CommonTree)input.LT(1);
					commonTree2 = (CommonTree)Match(input, 10, Follow._EQUAL_in_operator_comp611);
					commonTree8 = (CommonTree)adaptor.DupNode(commonTree2);
					adaptor.AddChild(commonTree, commonTree8);
					operator_comp_return.Operator = BinaryOperator.Equal;
					break;
				case 2:
					commonTree = (CommonTree)adaptor.Nil();
					_ = (CommonTree)input.LT(1);
					commonTree3 = (CommonTree)Match(input, 26, Follow._NEQUAL_in_operator_comp618);
					commonTree9 = (CommonTree)adaptor.DupNode(commonTree3);
					adaptor.AddChild(commonTree, commonTree9);
					operator_comp_return.Operator = BinaryOperator.NEqual;
					break;
				case 3:
					commonTree = (CommonTree)adaptor.Nil();
					_ = (CommonTree)input.LT(1);
					commonTree4 = (CommonTree)Match(input, 12, Follow._GE_in_operator_comp625);
					commonTree10 = (CommonTree)adaptor.DupNode(commonTree4);
					adaptor.AddChild(commonTree, commonTree10);
					operator_comp_return.Operator = BinaryOperator.GE;
					break;
				case 4:
					commonTree = (CommonTree)adaptor.Nil();
					_ = (CommonTree)input.LT(1);
					commonTree5 = (CommonTree)Match(input, 14, Follow._GT_in_operator_comp632);
					commonTree11 = (CommonTree)adaptor.DupNode(commonTree5);
					adaptor.AddChild(commonTree, commonTree11);
					operator_comp_return.Operator = BinaryOperator.GT;
					break;
				case 5:
					commonTree = (CommonTree)adaptor.Nil();
					_ = (CommonTree)input.LT(1);
					commonTree6 = (CommonTree)Match(input, 20, Follow._LE_in_operator_comp639);
					commonTree12 = (CommonTree)adaptor.DupNode(commonTree6);
					adaptor.AddChild(commonTree, commonTree12);
					operator_comp_return.Operator = BinaryOperator.LE;
					break;
				case 6:
					commonTree = (CommonTree)adaptor.Nil();
					_ = (CommonTree)input.LT(1);
					commonTree7 = (CommonTree)Match(input, 22, Follow._LT_in_operator_comp646);
					commonTree13 = (CommonTree)adaptor.DupNode(commonTree7);
					adaptor.AddChild(commonTree, commonTree13);
					operator_comp_return.Operator = BinaryOperator.LT;
					break;
				}
				operator_comp_return.Tree = (CommonTree)adaptor.RulePostProcessing(commonTree);
				return operator_comp_return;
			}
			catch (RecognitionException ex)
			{
				ReportError(ex);
				Recover(input, ex);
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
		expression_add_return.Start = (CommonTree)input.LT(1);
		CommonTree commonTree = null;
		expression_mult_return expression_mult_return = null;
		operator_add_return operator_add_return = null;
		expression_mult_return expression_mult_return2 = null;
		try
		{
			try
			{
				commonTree = (CommonTree)adaptor.Nil();
				_ = (CommonTree)input.LT(1);
				PushFollow(Follow._expression_mult_in_expression_add666);
				expression_mult_return = expression_mult();
				PopFollow();
				adaptor.AddChild(commonTree, expression_mult_return.Tree);
				expression_add_return.Expression = expression_mult_return?.Expression;
				try
				{
					while (true)
					{
						int num = 2;
						try
						{
							int num2 = input.LA(1);
							if (num2 == 24 || num2 == 31)
							{
								num = 1;
							}
						}
						finally
						{
						}
						if (num == 1)
						{
							_ = (CommonTree)input.LT(1);
							PushFollow(Follow._operator_add_in_expression_add677);
							operator_add_return = operator_add();
							PopFollow();
							adaptor.AddChild(commonTree, operator_add_return.Tree);
							_ = (CommonTree)input.LT(1);
							PushFollow(Follow._expression_mult_in_expression_add681);
							expression_mult_return2 = expression_mult();
							PopFollow();
							adaptor.AddChild(commonTree, expression_mult_return2.Tree);
							expression_add_return.Expression = new BinaryExpression
							{
								Operand1 = expression_add_return.Expression,
								Operator = (operator_add_return?.Operator ?? BinaryOperator.Equal),
								Operand2 = expression_mult_return2?.Expression
							};
							continue;
						}
						break;
					}
				}
				finally
				{
				}
				expression_add_return.Tree = (CommonTree)adaptor.RulePostProcessing(commonTree);
				return expression_add_return;
			}
			catch (RecognitionException ex)
			{
				ReportError(ex);
				Recover(input, ex);
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
		operator_add_return.Start = (CommonTree)input.LT(1);
		CommonTree commonTree = null;
		CommonTree commonTree2 = null;
		CommonTree commonTree3 = null;
		CommonTree commonTree4 = null;
		CommonTree commonTree5 = null;
		try
		{
			try
			{
				int num = 2;
				try
				{
					num = input.LA(1) switch
					{
						31 => 1, 
						24 => 2, 
						_ => throw new NoViableAltException("", 12, 0, input), 
					};
				}
				finally
				{
				}
				switch (num)
				{
				case 1:
					commonTree = (CommonTree)adaptor.Nil();
					_ = (CommonTree)input.LT(1);
					commonTree2 = (CommonTree)Match(input, 31, Follow._PLUS_in_operator_add703);
					commonTree4 = (CommonTree)adaptor.DupNode(commonTree2);
					adaptor.AddChild(commonTree, commonTree4);
					operator_add_return.Operator = BinaryOperator.Plus;
					break;
				case 2:
					commonTree = (CommonTree)adaptor.Nil();
					_ = (CommonTree)input.LT(1);
					commonTree3 = (CommonTree)Match(input, 24, Follow._MINUS_in_operator_add710);
					commonTree5 = (CommonTree)adaptor.DupNode(commonTree3);
					adaptor.AddChild(commonTree, commonTree5);
					operator_add_return.Operator = BinaryOperator.Minus;
					break;
				}
				operator_add_return.Tree = (CommonTree)adaptor.RulePostProcessing(commonTree);
				return operator_add_return;
			}
			catch (RecognitionException ex)
			{
				ReportError(ex);
				Recover(input, ex);
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
		expression_mult_return.Start = (CommonTree)input.LT(1);
		CommonTree commonTree = null;
		expression_unary_return expression_unary_return = null;
		operator_mult_return operator_mult_return = null;
		expression_unary_return expression_unary_return2 = null;
		try
		{
			try
			{
				commonTree = (CommonTree)adaptor.Nil();
				_ = (CommonTree)input.LT(1);
				PushFollow(Follow._expression_unary_in_expression_mult730);
				expression_unary_return = expression_unary();
				PopFollow();
				adaptor.AddChild(commonTree, expression_unary_return.Tree);
				expression_mult_return.Expression = expression_unary_return?.Expression;
				try
				{
					while (true)
					{
						int num = 2;
						try
						{
							int num2 = input.LA(1);
							if (num2 == 7 || num2 == 25)
							{
								num = 1;
							}
						}
						finally
						{
						}
						if (num == 1)
						{
							_ = (CommonTree)input.LT(1);
							PushFollow(Follow._operator_mult_in_expression_mult742);
							operator_mult_return = operator_mult();
							PopFollow();
							adaptor.AddChild(commonTree, operator_mult_return.Tree);
							_ = (CommonTree)input.LT(1);
							PushFollow(Follow._expression_unary_in_expression_mult746);
							expression_unary_return2 = expression_unary();
							PopFollow();
							adaptor.AddChild(commonTree, expression_unary_return2.Tree);
							expression_mult_return.Expression = new BinaryExpression
							{
								Operand1 = expression_mult_return.Expression,
								Operator = (operator_mult_return?.Operator ?? BinaryOperator.Equal),
								Operand2 = expression_unary_return2?.Expression
							};
							continue;
						}
						break;
					}
				}
				finally
				{
				}
				expression_mult_return.Tree = (CommonTree)adaptor.RulePostProcessing(commonTree);
				return expression_mult_return;
			}
			catch (RecognitionException ex)
			{
				ReportError(ex);
				Recover(input, ex);
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
		operator_mult_return.Start = (CommonTree)input.LT(1);
		CommonTree commonTree = null;
		CommonTree commonTree2 = null;
		CommonTree commonTree3 = null;
		CommonTree commonTree4 = null;
		CommonTree commonTree5 = null;
		try
		{
			try
			{
				int num = 2;
				try
				{
					num = input.LA(1) switch
					{
						25 => 1, 
						7 => 2, 
						_ => throw new NoViableAltException("", 14, 0, input), 
					};
				}
				finally
				{
				}
				switch (num)
				{
				case 1:
					commonTree = (CommonTree)adaptor.Nil();
					_ = (CommonTree)input.LT(1);
					commonTree2 = (CommonTree)Match(input, 25, Follow._MULT_in_operator_mult768);
					commonTree4 = (CommonTree)adaptor.DupNode(commonTree2);
					adaptor.AddChild(commonTree, commonTree4);
					operator_mult_return.Operator = BinaryOperator.Mult;
					break;
				case 2:
					commonTree = (CommonTree)adaptor.Nil();
					_ = (CommonTree)input.LT(1);
					commonTree3 = (CommonTree)Match(input, 7, Follow._DIVISION_in_operator_mult775);
					commonTree5 = (CommonTree)adaptor.DupNode(commonTree3);
					adaptor.AddChild(commonTree, commonTree5);
					operator_mult_return.Operator = BinaryOperator.Division;
					break;
				}
				operator_mult_return.Tree = (CommonTree)adaptor.RulePostProcessing(commonTree);
				return operator_mult_return;
			}
			catch (RecognitionException ex)
			{
				ReportError(ex);
				Recover(input, ex);
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
		expression_unary_return.Start = (CommonTree)input.LT(1);
		CommonTree commonTree = null;
		operator_unary_return operator_unary_return = null;
		atom_return atom_return = null;
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
						goto end_IL_0027;
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
						goto end_IL_0027;
					}
					throw new NoViableAltException("", 15, 0, input);
					end_IL_0027:;
				}
				finally
				{
				}
				switch (num)
				{
				case 1:
					commonTree = (CommonTree)adaptor.Nil();
					_ = (CommonTree)input.LT(1);
					PushFollow(Follow._operator_unary_in_expression_unary796);
					operator_unary_return = operator_unary();
					PopFollow();
					adaptor.AddChild(commonTree, operator_unary_return.Tree);
					_ = (CommonTree)input.LT(1);
					PushFollow(Follow._atom_in_expression_unary800);
					atom_return = atom();
					PopFollow();
					adaptor.AddChild(commonTree, atom_return.Tree);
					expression_unary_return.Expression = new UnaryExpression
					{
						Operand = atom_return?.Expression,
						Operator = (operator_unary_return?.Operator ?? UnaryOperator.Minus)
					};
					break;
				case 2:
					commonTree = (CommonTree)adaptor.Nil();
					_ = (CommonTree)input.LT(1);
					PushFollow(Follow._atom_in_expression_unary810);
					atom_return = atom();
					PopFollow();
					adaptor.AddChild(commonTree, atom_return.Tree);
					expression_unary_return.Expression = atom_return?.Expression;
					break;
				}
				expression_unary_return.Tree = (CommonTree)adaptor.RulePostProcessing(commonTree);
				return expression_unary_return;
			}
			catch (RecognitionException ex)
			{
				ReportError(ex);
				Recover(input, ex);
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
		operator_unary_return.Start = (CommonTree)input.LT(1);
		CommonTree commonTree = null;
		CommonTree commonTree2 = null;
		CommonTree commonTree3 = null;
		try
		{
			try
			{
				commonTree = (CommonTree)adaptor.Nil();
				_ = (CommonTree)input.LT(1);
				commonTree2 = (CommonTree)Match(input, 24, Follow._MINUS_in_operator_unary828);
				commonTree3 = (CommonTree)adaptor.DupNode(commonTree2);
				adaptor.AddChild(commonTree, commonTree3);
				operator_unary_return.Operator = UnaryOperator.Minus;
				operator_unary_return.Tree = (CommonTree)adaptor.RulePostProcessing(commonTree);
				return operator_unary_return;
			}
			catch (RecognitionException ex)
			{
				ReportError(ex);
				Recover(input, ex);
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
		atom_return.Start = (CommonTree)input.LT(1);
		CommonTree commonTree = null;
		CommonTree commonTree2 = null;
		CommonTree commonTree3 = null;
		expression_return expression_return = null;
		variable_return variable_return = null;
		globalvariable_return globalvariable_return = null;
		constant_return constant_return = null;
		function_call_return function_call_return = null;
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
						throw new NoViableAltException("", 16, 0, input);
					}
				}
				finally
				{
				}
				switch (num)
				{
				case 1:
					commonTree = (CommonTree)adaptor.Nil();
					_ = (CommonTree)input.LT(1);
					commonTree2 = (CommonTree)Match(input, 21, Follow._LPAREN_in_atom846);
					commonTree4 = (CommonTree)adaptor.DupNode(commonTree2);
					adaptor.AddChild(commonTree, commonTree4);
					_ = (CommonTree)input.LT(1);
					PushFollow(Follow._expression_in_atom850);
					expression_return = expression();
					PopFollow();
					adaptor.AddChild(commonTree, expression_return.Tree);
					_ = (CommonTree)input.LT(1);
					commonTree3 = (CommonTree)Match(input, 34, Follow._RPAREN_in_atom852);
					commonTree5 = (CommonTree)adaptor.DupNode(commonTree3);
					adaptor.AddChild(commonTree, commonTree5);
					atom_return.Expression = expression_return?.Expression;
					break;
				case 2:
					commonTree = (CommonTree)adaptor.Nil();
					_ = (CommonTree)input.LT(1);
					PushFollow(Follow._variable_in_atom861);
					variable_return = variable();
					PopFollow();
					adaptor.AddChild(commonTree, variable_return.Tree);
					atom_return.Expression = variable_return?.Variable;
					break;
				case 3:
					commonTree = (CommonTree)adaptor.Nil();
					_ = (CommonTree)input.LT(1);
					PushFollow(Follow._globalvariable_in_atom870);
					globalvariable_return = globalvariable();
					PopFollow();
					adaptor.AddChild(commonTree, globalvariable_return.Tree);
					atom_return.Expression = globalvariable_return?.Globalvariable;
					break;
				case 4:
					commonTree = (CommonTree)adaptor.Nil();
					_ = (CommonTree)input.LT(1);
					PushFollow(Follow._constant_in_atom879);
					constant_return = constant();
					PopFollow();
					adaptor.AddChild(commonTree, constant_return.Tree);
					atom_return.Expression = constant_return?.Constant;
					break;
				case 5:
					commonTree = (CommonTree)adaptor.Nil();
					_ = (CommonTree)input.LT(1);
					PushFollow(Follow._function_call_in_atom888);
					function_call_return = function_call();
					PopFollow();
					adaptor.AddChild(commonTree, function_call_return.Tree);
					atom_return.Expression = function_call_return?.Expression;
					break;
				}
				atom_return.Tree = (CommonTree)adaptor.RulePostProcessing(commonTree);
				return atom_return;
			}
			catch (RecognitionException ex)
			{
				ReportError(ex);
				Recover(input, ex);
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
		constant_return.Start = (CommonTree)input.LT(1);
		CommonTree commonTree = null;
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
				int num = 5;
				try
				{
					num = input.LA(1) switch
					{
						28 => 1, 
						6 => 2, 
						37 => 3, 
						11 => 4, 
						27 => 5, 
						_ => throw new NoViableAltException("", 17, 0, input), 
					};
				}
				finally
				{
				}
				switch (num)
				{
				case 1:
					commonTree = (CommonTree)adaptor.Nil();
					_ = (CommonTree)input.LT(1);
					commonTree2 = (CommonTree)Match(input, 28, Follow._NUMBER_in_constant908);
					commonTree6 = (CommonTree)adaptor.DupNode(commonTree2);
					adaptor.AddChild(commonTree, commonTree6);
					constant_return.Constant = Constant.ParseNumberConstant(input.TokenStream.ToString(input.TreeAdaptor.GetTokenStartIndex(constant_return.Start), input.TreeAdaptor.GetTokenStopIndex(constant_return.Start)));
					constant_return.Constant.Start = commonTree6.Token.StartIndex;
					constant_return.Constant.Stop = commonTree6.Token.StopIndex;
					break;
				case 2:
					commonTree = (CommonTree)adaptor.Nil();
					_ = (CommonTree)input.LT(1);
					commonTree3 = (CommonTree)Match(input, 6, Follow._CHARACTER_STRING_in_constant917);
					commonTree7 = (CommonTree)adaptor.DupNode(commonTree3);
					adaptor.AddChild(commonTree, commonTree7);
					constant_return.Constant = Constant.ParseStringConstant(input.TokenStream.ToString(input.TreeAdaptor.GetTokenStartIndex(constant_return.Start), input.TreeAdaptor.GetTokenStopIndex(constant_return.Start)));
					constant_return.Constant.Start = commonTree7.Token.StartIndex;
					constant_return.Constant.Stop = commonTree7.Token.StopIndex;
					break;
				case 3:
					commonTree = (CommonTree)adaptor.Nil();
					_ = (CommonTree)input.LT(1);
					commonTree4 = (CommonTree)Match(input, 37, Follow._TRUE_in_constant926);
					commonTree8 = (CommonTree)adaptor.DupNode(commonTree4);
					adaptor.AddChild(commonTree, commonTree8);
					constant_return.Constant = new Constant
					{
						Value = true
					};
					constant_return.Constant.Start = commonTree8.Token.StartIndex;
					constant_return.Constant.Stop = commonTree8.Token.StopIndex;
					break;
				case 4:
					commonTree = (CommonTree)adaptor.Nil();
					_ = (CommonTree)input.LT(1);
					commonTree5 = (CommonTree)Match(input, 11, Follow._FALSE_in_constant935);
					commonTree9 = (CommonTree)adaptor.DupNode(commonTree5);
					adaptor.AddChild(commonTree, commonTree9);
					constant_return.Constant = new Constant
					{
						Value = false
					};
					constant_return.Constant.Start = commonTree9.Token.StartIndex;
					constant_return.Constant.Stop = commonTree9.Token.StopIndex;
					break;
				case 5:
					commonTree = (CommonTree)adaptor.Nil();
					_ = (CommonTree)input.LT(1);
					commonTree5 = (CommonTree)Match(input, 27, Follow._NULL_in_constant944);
					commonTree9 = (CommonTree)adaptor.DupNode(commonTree5);
					adaptor.AddChild(commonTree, commonTree9);
					constant_return.Constant = new Constant
					{
						Value = null
					};
					constant_return.Constant.Start = commonTree9.Token.StartIndex;
					constant_return.Constant.Stop = commonTree9.Token.StopIndex;
					break;
				}
				constant_return.Tree = (CommonTree)adaptor.RulePostProcessing(commonTree);
				return constant_return;
			}
			catch (RecognitionException ex)
			{
				ReportError(ex);
				Recover(input, ex);
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
		function_call_return.Start = (CommonTree)input.LT(1);
		CommonTree commonTree = null;
		CommonTree commonTree2 = null;
		CommonTree commonTree3 = null;
		CommonTree commonTree4 = null;
		param_list_return param_list_return = null;
		CommonTree commonTree5 = null;
		CommonTree commonTree6 = null;
		CommonTree commonTree7 = null;
		function_call_return.Expression = new FunctionCall();
		try
		{
			try
			{
				commonTree = (CommonTree)adaptor.Nil();
				_ = (CommonTree)input.LT(1);
				commonTree2 = (CommonTree)Match(input, 16, Follow._IDENTIFIER_in_function_call970);
				commonTree5 = (CommonTree)adaptor.DupNode(commonTree2);
				adaptor.AddChild(commonTree, commonTree5);
				function_call_return.Expression.Name = input.TokenStream.ToString(input.TreeAdaptor.GetTokenStartIndex(function_call_return.Start), input.TreeAdaptor.GetTokenStopIndex(function_call_return.Start));
				function_call_return.Expression.Start = commonTree5.Token.StartIndex;
				_ = (CommonTree)input.LT(1);
				commonTree3 = (CommonTree)Match(input, 21, Follow._LPAREN_in_function_call977);
				commonTree6 = (CommonTree)adaptor.DupNode(commonTree3);
				adaptor.AddChild(commonTree, commonTree6);
				_ = (CommonTree)input.LT(1);
				PushFollow(Follow._param_list_in_function_call983);
				param_list_return = param_list();
				PopFollow();
				adaptor.AddChild(commonTree, param_list_return.Tree);
				function_call_return.Expression.Params = param_list_return?.Params;
				_ = (CommonTree)input.LT(1);
				commonTree4 = (CommonTree)Match(input, 34, Follow._RPAREN_in_function_call990);
				commonTree7 = (CommonTree)adaptor.DupNode(commonTree4);
				adaptor.AddChild(commonTree, commonTree7);
				function_call_return.Expression.Stop = commonTree7.Token.StopIndex;
				function_call_return.Tree = (CommonTree)adaptor.RulePostProcessing(commonTree);
				return function_call_return;
			}
			catch (RecognitionException ex)
			{
				ReportError(ex);
				Recover(input, ex);
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

	[GrammarRule("identifier")]
	private identifier_return identifier()
	{
		identifier_return identifier_return = new identifier_return(this);
		identifier_return.Start = (CommonTree)input.LT(1);
		CommonTree commonTree = null;
		CommonTree commonTree2 = null;
		CommonTree commonTree3 = null;
		try
		{
			try
			{
				commonTree = (CommonTree)adaptor.Nil();
				_ = (CommonTree)input.LT(1);
				commonTree2 = (CommonTree)Match(input, 16, Follow._IDENTIFIER_in_identifier1009);
				commonTree3 = (CommonTree)adaptor.DupNode(commonTree2);
				adaptor.AddChild(commonTree, commonTree3);
				identifier_return.Value = input.TokenStream.ToString(input.TreeAdaptor.GetTokenStartIndex(identifier_return.Start), input.TreeAdaptor.GetTokenStopIndex(identifier_return.Start));
				identifier_return.Tree = (CommonTree)adaptor.RulePostProcessing(commonTree);
				return identifier_return;
			}
			catch (RecognitionException ex)
			{
				ReportError(ex);
				Recover(input, ex);
				return identifier_return;
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
		param_list_return.Start = (CommonTree)input.LT(1);
		CommonTree commonTree = null;
		CommonTree commonTree2 = null;
		expression_return expression_return = null;
		expression_return expression_return2 = null;
		CommonTree commonTree3 = null;
		param_list_return.Params = new List<Expression>();
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
							goto end_IL_0049;
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
						end_IL_0049:;
					}
					finally
					{
					}
					if (num == 1)
					{
						_ = (CommonTree)input.LT(1);
						PushFollow(Follow._expression_in_param_list1036);
						expression_return = expression();
						PopFollow();
						adaptor.AddChild(commonTree, expression_return.Tree);
						param_list_return.Params.Add(expression_return?.Expression);
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
									_ = (CommonTree)input.LT(1);
									commonTree2 = (CommonTree)Match(input, 35, Follow._SEMICOLON_in_param_list1041);
									commonTree3 = (CommonTree)adaptor.DupNode(commonTree2);
									adaptor.AddChild(commonTree, commonTree3);
									_ = (CommonTree)input.LT(1);
									PushFollow(Follow._expression_in_param_list1045);
									expression_return2 = expression();
									PopFollow();
									adaptor.AddChild(commonTree, expression_return2.Tree);
									param_list_return.Params.Add(expression_return2?.Expression);
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
				param_list_return.Tree = (CommonTree)adaptor.RulePostProcessing(commonTree);
				return param_list_return;
			}
			catch (RecognitionException ex)
			{
				ReportError(ex);
				Recover(input, ex);
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
}
