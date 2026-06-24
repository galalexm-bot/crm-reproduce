using System;
using System.Runtime.CompilerServices;
using Nemerle.Collections;

namespace Nemerle.Compiler;

public class PreParserIndent : PreParser
{
	private int explicit_groups;

	private bool indentation_syntax_active = true;

	private Location insertLocation;

	private bool had_some_real_input;

	private bool last_token_was_semicolon;

	private bool force_brace_after_newline;

	private readonly Stack<string> indent_strings = new Stack<string>(20);

	private readonly Queue<Token> tokens_pending = new Queue<Token>();

	private bool set_namespace;

	private bool set_class;

	private string CurrentIndent => indent_strings.Top;

	public PreParserIndent(LexerBase lex)
		: base(lex)
	{
		indent_strings.Push("");
	}

	private void push_end_brace()
	{
		tokens_pending.Push(new Token.EndBrace(insertLocation, generated: true));
	}

	private void handle_real_token(Token lexer_tok)
	{
		if (!(lexer_tok is Token.EndOfFile))
		{
			had_some_real_input = true;
		}
		bool flag = (last_token_was_semicolon = ((lexer_tok is Token.Operator && ((Token.Operator)lexer_tok).name == ";") ? true : false));
		Token token;
		checked
		{
			if (lexer_tok is Token.Identifier)
			{
				if (((Token.Identifier)lexer_tok).name == "set" && indentation_syntax_active && CurrentIndent == "")
				{
					goto IL_0106;
				}
			}
			else if (lexer_tok is Token.Keyword)
			{
				if (((Token.Keyword)lexer_tok).name == "set" && indentation_syntax_active && CurrentIndent == "")
				{
					goto IL_0106;
				}
			}
			else
			{
				if (!(lexer_tok is Token.Operator))
				{
					if (lexer_tok is Token.BeginBrace)
					{
						goto IL_02dd;
					}
					if (!(lexer_tok is Token.EndBrace))
					{
						if (lexer_tok is Token.BeginRound)
						{
							goto IL_02dd;
						}
						if (!(lexer_tok is Token.EndRound))
						{
							if (lexer_tok is Token.BeginSquare)
							{
								goto IL_02dd;
							}
							if (!(lexer_tok is Token.EndSquare))
							{
								if (lexer_tok is Token.BeginQuote)
								{
									goto IL_02dd;
								}
								if (!(lexer_tok is Token.EndQuote))
								{
									if (lexer_tok is Token.EndOfFile)
									{
										insertLocation = lexer_tok.Location;
										while (indent_strings.Count > 1)
										{
											string text = indent_strings.Pop();
											push_end_brace();
										}
										if (set_class)
										{
											push_end_brace();
										}
										if (set_namespace)
										{
											push_end_brace();
										}
										tokens_pending.Push(lexer_tok);
										return;
									}
									goto IL_03e1;
								}
							}
						}
					}
					if (explicit_groups == 0)
					{
						throw new PreParserException(lexer_tok.Location, "unmatched group end");
					}
					explicit_groups--;
					if (explicit_groups == 0)
					{
						indentation_syntax_active = true;
					}
					tokens_pending.Push(lexer_tok);
					return;
				}
				if (((Token.Operator)lexer_tok).name == "\\" && indentation_syntax_active)
				{
					token = lexer.GetToken();
					if (token is Token.Indent)
					{
						return;
					}
					throw new PreParserException(lexer_tok.Location, "unexpected `\\' in middle of a line");
				}
			}
			goto IL_03e1;
		}
		IL_0106:
		token = lexer.GetToken();
		if (token is Token.Keyword)
		{
			if (((Token.Keyword)token).name == "namespace")
			{
				if (set_namespace)
				{
					throw new PreParserException(token.Location, "the 'set namespace' directive can only be used once per file");
				}
				set_namespace = true;
				force_brace_after_newline = true;
			}
			else
			{
				if (!(((Token.Keyword)token).name == "class"))
				{
					goto IL_01af;
				}
				if (set_class)
				{
					throw new PreParserException(token.Location, "the 'set class' directive can only be used once per file");
				}
				set_class = true;
				force_brace_after_newline = true;
			}
			tokens_pending.Push(token);
			return;
		}
		goto IL_01af;
		IL_01af:
		throw new PreParserException(token.Location, "unrecognized 'set' directive: '" + Convert.ToString(token) + "'");
		IL_02dd:
		checked
		{
			explicit_groups++;
			indentation_syntax_active = false;
			tokens_pending.Push(lexer_tok);
			return;
		}
		IL_03e1:
		tokens_pending.Push(lexer_tok);
	}

	protected override Token get_token()
	{
		object result;
		if (last_token != null)
		{
			Token token = last_token;
			last_token = null;
			result = token;
		}
		else if (!tokens_pending.IsEmpty)
		{
			Token token2 = tokens_pending.Take();
			if (token2 is Token.QuotedIdentifier)
			{
				Token.QuotedIdentifier quotedIdentifier = (Token.QuotedIdentifier)token2;
				string name = ((Token.QuotedIdentifier)token2).name;
				result = new Token.Identifier(quotedIdentifier.Location, name);
			}
			else
			{
				if (token2 is Token.Identifier)
				{
					Token.Identifier identifier = (Token.Identifier)token2;
					string name2 = ((Token.Identifier)token2).name;
					if (lexer.Keywords.Contains(name2))
					{
						result = new Token.Keyword(identifier.Location, name2);
						goto IL_0159;
					}
				}
				Token token3 = token2;
				result = token3;
			}
		}
		else
		{
			Token token5;
			try
			{
				Token token4 = lexer.GetToken();
				object obj;
				if (token4 is Token.Indent)
				{
					Token.Indent tok = (Token.Indent)token4;
					obj = ((!indentation_syntax_active) ? get_token() : get_token_after_indent(tok));
				}
				else
				{
					Token lexer_tok = token4;
					handle_real_token(lexer_tok);
					obj = get_token();
				}
				token5 = (Token)obj;
			}
			catch (LexerBase.Error error)
			{
				Message.Error(lexer.Location, error.Message);
				token5 = get_token();
			}
			result = token5;
		}
		goto IL_0159;
		IL_0159:
		return (Token)result;
	}

	private static string display_space(string s)
	{
		return s.Replace(" ", "S").Replace("\t", "T");
	}

	private Token get_token_after_indent(Token tok, string new_indent = "")
	{
		while (true)
		{
			if (tok is Token.Indent)
			{
				string value = ((Token.Indent)tok).value;
				insertLocation = tok.Location;
				Token token = lexer.GetToken();
				new_indent = value;
				tok = token;
				continue;
			}
			if (tok is Token.Comment)
			{
				Token token2 = lexer.GetToken();
				new_indent = new_indent;
				tok = token2;
				continue;
			}
			if (!force_brace_after_newline)
			{
				break;
			}
			force_brace_after_newline = false;
			tokens_pending.Push(new Token.BeginBrace(insertLocation, generated: true));
			Token token3 = tok;
			new_indent = new_indent;
			tok = token3;
		}
		if (new_indent.Length >= CurrentIndent.Length)
		{
			if (!new_indent.StartsWith(CurrentIndent))
			{
				Message.Error(tok.Location, "inconsistent indentation");
			}
			if (new_indent == CurrentIndent)
			{
				if (had_some_real_input && !last_token_was_semicolon && !(tok is Token.BeginBrace))
				{
					tokens_pending.Push(new Token.Semicolon(insertLocation, generated: true));
				}
				handle_real_token(tok);
			}
			else
			{
				indent_strings.Push(new_indent);
				tokens_pending.Push(new Token.BeginBrace(insertLocation, generated: true));
				handle_real_token(tok);
			}
		}
		else
		{
			if (!indent_strings.Contains(new_indent))
			{
				throw new PreParserException(tok.Location, "inconsistent indentation");
			}
			while (indent_strings.Top != new_indent)
			{
				push_end_brace();
				string value = indent_strings.Pop();
			}
			handle_real_token(tok);
		}
		return get_token();
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
		Queue<Token> queue = tokens_pending;
		if (queue != null)
		{
			foreach (Token item in queue)
			{
				Token token = item;
				((ISupportRelocation)token).RelocateImpl(_info);
			}
		}
		insertLocation = Completion.Relocate(insertLocation, _info);
	}
}
