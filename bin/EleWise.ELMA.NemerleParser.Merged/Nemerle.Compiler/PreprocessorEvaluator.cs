using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Collections;
using Nemerle.Core;
using Nemerle.Internal;

namespace Nemerle.Compiler;

[Nemerle.Internal.Extension]
internal static class PreprocessorEvaluator
{
	private sealed class _N_closureOf_EvalCondition_45558
	{
		internal list<string> _N_tokens_45563;

		internal _N_closureOf_EvalCondition_45558()
		{
		}
	}

	private sealed class _N_closureOf_EvalConditions_45680
	{
		internal GlobalEnv _N_env_45685;

		internal _N_closureOf_EvalConditions_45680()
		{
		}
	}

	private sealed class _N__N_lambda__45673__45695 : Function<string, bool>
	{
		[SpecialName]
		private _N_closureOf_EvalConditions_45680 _N_EvalConditions_closure_45699;

		public _N__N_lambda__45673__45695(_N_closureOf_EvalConditions_45680 _N_EvalConditions_closure_45699)
		{
			this._N_EvalConditions_closure_45699 = _N_EvalConditions_closure_45699;
		}

		[SpecialName]
		public sealed override bool apply(string condition)
		{
			try
			{
				return EvalCondition(_N_EvalConditions_closure_45699._N_env_45685.Defines, condition);
			}
			catch (LexerBase.Error)
			{
				return false;
			}
		}
	}

	public static bool EvalCondition(Map<string, bool> defines, string str)
	{
		int num = 0;
		_N_closureOf_EvalCondition_45558 n_closureOf_EvalCondition_ = new _N_closureOf_EvalCondition_45558();
		if (defines == null)
		{
		}
		_N_closureOf_EvalCondition_45558 n_closureOf_EvalCondition_2 = n_closureOf_EvalCondition_;
		string text = str;
		list<string> list = list<string>.Nil._N_constant_object;
		checked
		{
			bool result;
			while (true)
			{
				for (num = 0; num < text.Length && char.IsWhiteSpace(text[num]); num++)
				{
				}
				text = text.Substring(num);
				string text2 = text;
				if (text2.StartsWith("false"))
				{
					string text3 = text2.Substring(5);
					list = new list<string>.Cons("false", list);
					text = text3;
					continue;
				}
				text2 = text;
				if (text2.StartsWith("true"))
				{
					string text4 = text2.Substring(4);
					list = new list<string>.Cons("true", list);
					text = text4;
					continue;
				}
				text2 = text;
				if (text2.StartsWith("||"))
				{
					string text5 = text2.Substring(2);
					list = new list<string>.Cons("||", list);
					text = text5;
					continue;
				}
				text2 = text;
				if (text2.StartsWith("&&"))
				{
					string text6 = text2.Substring(2);
					list = new list<string>.Cons("&&", list);
					text = text6;
					continue;
				}
				text2 = text;
				if (text2.StartsWith("=="))
				{
					string text7 = text2.Substring(2);
					list = new list<string>.Cons("==", list);
					text = text7;
					continue;
				}
				text2 = text;
				if (text2.StartsWith("!="))
				{
					string text8 = text2.Substring(2);
					list = new list<string>.Cons("!=", list);
					text = text8;
					continue;
				}
				text2 = text;
				if (text2.StartsWith("("))
				{
					string text9 = text2.Substring(1);
					list = new list<string>.Cons("(", list);
					text = text9;
					continue;
				}
				text2 = text;
				if (text2.StartsWith(")"))
				{
					string text10 = text2.Substring(1);
					list = new list<string>.Cons(")", list);
					text = text10;
					continue;
				}
				text2 = text;
				if (text2.StartsWith("!"))
				{
					string text11 = text2.Substring(1);
					list = new list<string>.Cons("!", list);
					text = text11;
					continue;
				}
				if (!(text == ""))
				{
					text = text;
					for (num = 0; num < text.Length && (LexerBase.IsIdBeginning(text[num]) || char.IsDigit(text[num])); num++)
					{
					}
					if (num == 0)
					{
						throw new LexerBase.Error("bad preprocessing condition format");
					}
					option<bool> option = defines.Find(text.Substring(0, num));
					if (option is option<bool>.Some)
					{
						if (((option<bool>.Some)option).val)
						{
							string text12 = text.Substring(num);
							list = new list<string>.Cons("true", list);
							text = text12;
							continue;
						}
					}
					else if (option != option<bool>.None._N_constant_object)
					{
						throw new MatchFailureException();
					}
					string text13 = text.Substring(num);
					list = new list<string>.Cons("false", list);
					text = text13;
					continue;
				}
				list<string> list2 = (n_closureOf_EvalCondition_2._N_tokens_45563 = NList.Rev(list));
				result = _N_highest_45628(n_closureOf_EvalCondition_);
				if (!(n_closureOf_EvalCondition_._N_tokens_45563 != list<string>.Nil._N_constant_object))
				{
					break;
				}
				throw new LexerBase.Error("Unexpected token after expression");
			}
			return result;
		}
	}

	[Nemerle.Internal.Extension]
	public static bool EvalConditions(this IMember conditionalMember, GlobalEnv env)
	{
		_N_closureOf_EvalConditions_45680 n_closureOf_EvalConditions_ = new _N_closureOf_EvalConditions_45680();
		n_closureOf_EvalConditions_._N_env_45685 = env;
		if (n_closureOf_EvalConditions_._N_env_45685 == null)
		{
		}
		list<string> conditions = conditionalMember.GetConditions();
		int result;
		if ((object)conditions == list<string>.Nil._N_constant_object)
		{
			result = 1;
		}
		else
		{
			Function<string, bool> f = new _N__N_lambda__45673__45695(n_closureOf_EvalConditions_);
			result = (conditions.Exists(f) ? 1 : 0);
		}
		return (byte)result != 0;
	}

	private static bool _N_lowest_45610(_N_closureOf_EvalCondition_45558 _N_EvalCondition_cp_45609)
	{
		if (_N_EvalCondition_cp_45609._N_tokens_45563 is list<string>.Cons)
		{
			int result;
			if (((list<string>.Cons)_N_EvalCondition_cp_45609._N_tokens_45563).hd == "(")
			{
				list<string> list = (_N_EvalCondition_cp_45609._N_tokens_45563 = ((list<string>.Cons)_N_EvalCondition_cp_45609._N_tokens_45563).tl);
				bool flag = _N_highest_45628(_N_EvalCondition_cp_45609);
				if (!(_N_EvalCondition_cp_45609._N_tokens_45563 is list<string>.Cons) || !(((list<string>.Cons)_N_EvalCondition_cp_45609._N_tokens_45563).hd == ")"))
				{
					throw new LexerBase.Error("unbalanced parenthesis in preprocessing expression");
				}
				list = (_N_EvalCondition_cp_45609._N_tokens_45563 = ((list<string>.Cons)_N_EvalCondition_cp_45609._N_tokens_45563).tl);
				result = (flag ? 1 : 0);
			}
			else if (((list<string>.Cons)_N_EvalCondition_cp_45609._N_tokens_45563).hd == "!")
			{
				list<string> list = (_N_EvalCondition_cp_45609._N_tokens_45563 = ((list<string>.Cons)_N_EvalCondition_cp_45609._N_tokens_45563).tl);
				result = ((!_N_lowest_45610(_N_EvalCondition_cp_45609)) ? 1 : 0);
			}
			else if (((list<string>.Cons)_N_EvalCondition_cp_45609._N_tokens_45563).hd == "false")
			{
				list<string> list = (_N_EvalCondition_cp_45609._N_tokens_45563 = ((list<string>.Cons)_N_EvalCondition_cp_45609._N_tokens_45563).tl);
				result = 0;
			}
			else
			{
				if (!(((list<string>.Cons)_N_EvalCondition_cp_45609._N_tokens_45563).hd == "true"))
				{
					goto IL_0171;
				}
				list<string> list = (_N_EvalCondition_cp_45609._N_tokens_45563 = ((list<string>.Cons)_N_EvalCondition_cp_45609._N_tokens_45563).tl);
				result = 1;
			}
			return (byte)result != 0;
		}
		goto IL_0171;
		IL_0171:
		throw new LexerBase.Error("bad expression");
	}

	private static bool _N_low_45616(_N_closureOf_EvalCondition_45558 _N_EvalCondition_cp_45615)
	{
		bool flag = false;
		flag = _N_lowest_45610(_N_EvalCondition_cp_45615);
		while (_N_EvalCondition_cp_45615._N_tokens_45563 is list<string>.Cons && ((list<string>.Cons)_N_EvalCondition_cp_45615._N_tokens_45563).hd == "&&")
		{
			list<string> list = (_N_EvalCondition_cp_45615._N_tokens_45563 = ((list<string>.Cons)_N_EvalCondition_cp_45615._N_tokens_45563).tl);
			flag = _N_lowest_45610(_N_EvalCondition_cp_45615) && flag;
		}
		return flag;
	}

	private static bool _N_high_45622(_N_closureOf_EvalCondition_45558 _N_EvalCondition_cp_45621)
	{
		bool flag = false;
		flag = _N_low_45616(_N_EvalCondition_cp_45621);
		while (_N_EvalCondition_cp_45621._N_tokens_45563 is list<string>.Cons && ((list<string>.Cons)_N_EvalCondition_cp_45621._N_tokens_45563).hd == "||")
		{
			list<string> list = (_N_EvalCondition_cp_45621._N_tokens_45563 = ((list<string>.Cons)_N_EvalCondition_cp_45621._N_tokens_45563).tl);
			flag = _N_low_45616(_N_EvalCondition_cp_45621) || flag;
		}
		return flag;
	}

	private static bool _N_highest_45628(_N_closureOf_EvalCondition_45558 _N_EvalCondition_cp_45627)
	{
		bool flag = false;
		flag = _N_high_45622(_N_EvalCondition_cp_45627);
		while (_N_EvalCondition_cp_45627._N_tokens_45563 is list<string>.Cons)
		{
			list<string> list;
			if (((list<string>.Cons)_N_EvalCondition_cp_45627._N_tokens_45563).hd == "==")
			{
				list = (_N_EvalCondition_cp_45627._N_tokens_45563 = ((list<string>.Cons)_N_EvalCondition_cp_45627._N_tokens_45563).tl);
				flag = _N_high_45622(_N_EvalCondition_cp_45627) == flag;
				continue;
			}
			if (!(((list<string>.Cons)_N_EvalCondition_cp_45627._N_tokens_45563).hd == "!="))
			{
				break;
			}
			list = (_N_EvalCondition_cp_45627._N_tokens_45563 = ((list<string>.Cons)_N_EvalCondition_cp_45627._N_tokens_45563).tl);
			flag = _N_high_45622(_N_EvalCondition_cp_45627) != flag;
		}
		return flag;
	}
}
