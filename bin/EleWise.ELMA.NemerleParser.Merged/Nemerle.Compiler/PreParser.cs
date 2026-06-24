using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using Nemerle.Builtins;
using Nemerle.Collections;
using Nemerle.Core;
using Nemerle.Internal;

namespace Nemerle.Compiler;

public class PreParser : ISupportRelocation
{
	private sealed class _N__N_lambda__44645__44664 : Function<Token, string>
	{
		[SpecialName]
		public static readonly _N__N_lambda__44645__44664 Instance = new _N__N_lambda__44645__44664();

		[SpecialName]
		public sealed override string apply(Token x)
		{
			return Convert.ToString(x);
		}
	}

	private sealed class _N_closureOf_ParseTopLevelImpl_44938
	{
		internal PreParser _N__N_closurised_this_ptr_44947;

		internal int _N_current_begin_44945;

		internal GlobalEnv _N_currentNsEnv_44943;

		internal _N_closureOf_ParseTopLevelImpl_44938()
		{
		}
	}

	private sealed class _N_closureOf_parse_using_directive_45003
	{
		internal list<Token> _N_tokens_in_body_45008;

		internal _N_closureOf_parse_using_directive_45003()
		{
		}
	}

	private sealed class _N_closureOf_create_body_token_45021
	{
		internal list<Token> _N_next_45028;

		internal Location _N_loc_45026;

		internal _N_closureOf_create_body_token_45021()
		{
		}
	}

	private sealed class _N__N_lambda__44897__45030 : FunctionVoid<Token>
	{
		[SpecialName]
		private _N_closureOf_create_body_token_45021 _N_create_body_token_closure_45034;

		public _N__N_lambda__44897__45030(_N_closureOf_create_body_token_45021 _N_create_body_token_closure_45034)
		{
			this._N_create_body_token_closure_45034 = _N_create_body_token_closure_45034;
		}

		[SpecialName]
		public sealed override void apply_void(Token current)
		{
			current.Next = (((object)_N_create_body_token_closure_45034._N_next_45028 != list<Token>.Nil._N_constant_object) ? _N_create_body_token_closure_45034._N_next_45028.Head : null);
			if (!(_N_create_body_token_closure_45034._N_next_45028 == list<Token>.Nil._N_constant_object))
			{
				_N_create_body_token_closure_45034._N_next_45028 = _N_create_body_token_closure_45034._N_next_45028.Tail;
			}
			_N_create_body_token_closure_45034._N_loc_45026 += current.Location;
		}
	}

	protected readonly LexerBase lexer;

	protected Token last_token = null;

	private Token last_declaration_token = null;

	private GlobalEnv Env;

	private bool finished = false;

	private readonly List<Token> parent_stream = new List<Token>(100);

	private readonly List<Token> current_stream = new List<Token>(50);

	private Map<Location, string> doc_comments;

	internal Map<Location, string> DocComments
	{
		[CompilerGenerated]
		[DebuggerStepThrough]
		get
		{
			return doc_comments;
		}
		[DebuggerStepThrough]
		[CompilerGenerated]
		set
		{
			doc_comments = value;
		}
	}

	public PreParser(LexerBase lex)
		: this(lex, lex.Manager.CoreEnv)
	{
	}

	public PreParser(LexerBase lex, GlobalEnv env)
	{
		Env = env;
		lex.Keywords = Env.Keywords;
		lexer = lex;
	}

	private void reset_comment(Token tok)
	{
		if (doc_comments != null)
		{
			doc_comments = doc_comments.Replace(tok.Location, "");
		}
	}

	private void reset_comment(Location loc)
	{
		if (doc_comments != null)
		{
			doc_comments = doc_comments.Replace(loc, "");
		}
	}

	protected override Token get_token()
	{
		//Discarded unreachable code: IL_00b6
		Token result;
		if (last_token != null)
		{
			Token token = last_token;
			last_token = null;
			result = token;
		}
		else
		{
			Token token4;
			try
			{
				Token token2 = lexer.GetToken();
				object obj;
				if (token2 is Token.QuotedIdentifier)
				{
					Token.QuotedIdentifier quotedIdentifier = (Token.QuotedIdentifier)token2;
					string name = ((Token.QuotedIdentifier)token2).name;
					obj = new Token.Identifier(quotedIdentifier.Location, name);
				}
				else
				{
					Token token3 = token2;
					obj = token3;
				}
				token4 = (Token)obj;
			}
			catch (DecoderFallbackException)
			{
				Message.Error(lexer.Location, string.Concat("detected unsupported encoding of national characters in file `" + Convert.ToString(lexer.Location.File) + "', ", "source files should be in UTF8 (or UTF16/32 when BOM is given) encoding"));
				throw new Recovery();
			}
			catch (LexerBase.Error error)
			{
				Message.Error(lexer.Location, string.Concat(error.Message + " ", error.StackTrace));
				token4 = get_token();
			}
			result = token4;
		}
		return result;
	}

	private void push_back(Token tok)
	{
		if (last_token != null)
		{
			throw new AssertionException("ncc\\parsing\\PreParser.n", 132, "last_token == null", "");
		}
		last_token = tok;
	}

	private Token peek_token()
	{
		Token token = get_token();
		push_back(token);
		return token;
	}

	private static Token make_list(List<Token> tokens, int start)
	{
		int num = 0;
		checked
		{
			for (num = tokens.Count - 2; num >= start; num--)
			{
				tokens[num].Next = tokens[num + 1];
			}
			return tokens[start];
		}
	}

	private static Location list_location(List<Token> tokens, int start)
	{
		if (tokens.Count <= 0)
		{
			throw new AssertionException("ncc\\parsing\\PreParser.n", 154, "tokens.Count > 0", "");
		}
		if (start >= tokens.Count)
		{
			throw new AssertionException("ncc\\parsing\\PreParser.n", 155, "start < tokens.Count", "");
		}
		return tokens[start].Location + tokens[checked(tokens.Count - 1)].Location;
	}

	public static string Dump(Token tok, string ident)
	{
		Nemerle.Builtins.Tuple<string, string, string, Token> tuple = ((tok is Token.RoundGroup) ? new Nemerle.Builtins.Tuple<string, string, string, Token>("(", ")", ", ", tok) : ((tok is Token.BracesGroup) ? new Nemerle.Builtins.Tuple<string, string, string, Token>("{\n" + ident, "}", ";\n" + ident, tok) : ((tok is Token.SquareGroup) ? new Nemerle.Builtins.Tuple<string, string, string, Token>("[", "]", ", ", tok) : ((tok is Token.QuoteGroup) ? new Nemerle.Builtins.Tuple<string, string, string, Token>("<[\n", "]>", "; ", tok) : ((!(tok is Token.LooseGroup)) ? new Nemerle.Builtins.Tuple<string, string, string, Token>("", tok.ToString(describe: false), "", null) : new Nemerle.Builtins.Tuple<string, string, string, Token>("", "", " ", tok))))));
		string field = tuple.Field0;
		string field2 = tuple.Field1;
		string field3 = tuple.Field2;
		Token field4 = tuple.Field3;
		string text = Convert.ToString(field);
		IEnumerable<Token> source = field4;
		Function<Token, string> instance = _N__N_lambda__44645__44664.Instance;
		return text + string.Join(field3, source.MapToArray(instance)) + Convert.ToString(field2);
	}

	private Token finish_parent(int parent_begin, int current_begin)
	{
		finish_current(current_begin);
		Token result = ((parent_begin != parent_stream.Count) ? make_list(parent_stream, parent_begin) : null);
		parent_stream.RemoveRange(parent_begin, checked(parent_stream.Count - parent_begin));
		return result;
	}

	private void finish_current(int current_begin, Token separator_token = null)
	{
		if (current_begin == current_stream.Count)
		{
			if (separator_token != null && !(separator_token is Token.Semicolon))
			{
				Token.LooseGroup item = new Token.LooseGroup(separator_token.Location, separator_token);
				parent_stream.Add(item);
			}
		}
		else
		{
			Token token = make_list(current_stream, current_begin);
			Location loc = ((separator_token == null) ? list_location(current_stream, current_begin) : (token.Location + separator_token.Location.FromStart()));
			Token.LooseGroup item = new Token.LooseGroup(loc, token, separator_token);
			parent_stream.Add(item);
			current_stream.RemoveRange(current_begin, checked(current_stream.Count - current_begin));
		}
	}

	private void handle_default_token(int current_begin, Token tok, bool braces_cut_current = true)
	{
		if (tok is Token.Comment)
		{
			string value = ((Token.Comment)tok).value;
			if (doc_comments != null)
			{
				doc_comments = doc_comments.Replace(tok.Location, value);
			}
			return;
		}
		if (tok is Token.BeginBrace)
		{
			bool generated = ((Token.BeginBrace)tok).generated;
			Token.BracesGroup item = parse_brace_group(tok.Location, (Token.BeginBrace)tok, expect_endbrace: true, generated);
			current_stream.Add(item);
			if (braces_cut_current)
			{
				Token token = peek_token();
				if (token is Token.Semicolon)
				{
					finish_current(current_begin, get_token());
				}
				else
				{
					finish_current(current_begin);
				}
			}
			return;
		}
		if (!(tok is Token.EndBrace))
		{
			if (tok is Token.BeginRound)
			{
				Token.RoundGroup item2 = parse_round_group(tok.Location, (Token.BeginRound)tok);
				current_stream.Add(item2);
				return;
			}
			if (!(tok is Token.EndRound))
			{
				if (tok is Token.BeginSquare)
				{
					Token.SquareGroup item3 = parse_square_group(tok.Location, (Token.BeginSquare)tok);
					current_stream.Add(item3);
					return;
				}
				if (!(tok is Token.EndSquare))
				{
					if (tok is Token.BeginQuote)
					{
						Token.QuoteGroup item4 = parse_quote_group(tok.Location, (Token.BeginQuote)tok);
						current_stream.Add(item4);
						return;
					}
					if (!(tok is Token.EndQuote))
					{
						if (tok is Token.EndOfFile)
						{
							throw new PreParserException(tok.Location, "unexpected end of file");
						}
						current_stream.Add(tok);
						return;
					}
				}
			}
		}
		push_back(tok);
		throw new PreParserException(tok.Location, "unexpected closing bracket `" + Convert.ToString(tok) + "'");
	}

	private Token.BracesGroup parse_brace_group(Location loc, Token.BeginBrace openBrace, bool expect_endbrace, bool generated)
	{
		int count = parent_stream.Count;
		int count2 = current_stream.Count;
		reset_comment(loc);
		try
		{
			Token.BracesGroup result;
			while (true)
			{
				Token token = get_token();
				if (!object.ReferenceEquals(Env.Defines, lexer.Defines))
				{
					Env = Env.SetDefines(lexer.Defines);
				}
				if (token is Token.Semicolon)
				{
					reset_comment(token);
					finish_current(count2, token);
					continue;
				}
				if (token is Token.EndBrace)
				{
					Token.EndBrace closeBrace = (Token.EndBrace)token;
					reset_comment(token);
					Token child = finish_parent(count, count2);
					result = new Token.BracesGroup(loc + token.Location, child, openBrace, closeBrace, generated);
					break;
				}
				if (token is Token.EndOfFile && !expect_endbrace)
				{
					Token child2 = finish_parent(count, count2);
					finished = true;
					result = new Token.BracesGroup(loc + token.Location, child2, openBrace, null, generated);
					break;
				}
				handle_default_token(count2, token);
			}
			return result;
		}
		catch (PreParserException ex)
		{
			Message.Error(loc, "when parsing this `{' brace group");
			Message.Error(ex.Location, ex.Message);
			Token child3 = finish_parent(count, count2);
			return new Token.BracesGroup(shift_end(loc + ex.Location), child3, openBrace, null, generated);
		}
	}

	private Token.RoundGroup parse_round_group(Location loc, Token.BeginRound openBrace)
	{
		int count = parent_stream.Count;
		int count2 = current_stream.Count;
		try
		{
			Token token;
			while (true)
			{
				token = get_token();
				if (token is Token.EndRound)
				{
					break;
				}
				if (token is Token.Comma)
				{
					finish_current(count2, token);
				}
				else
				{
					handle_default_token(count2, token, braces_cut_current: false);
				}
			}
			Token.EndRound closeBrace = (Token.EndRound)token;
			Token child = finish_parent(count, count2);
			return new Token.RoundGroup(loc + token.Location, child, openBrace, closeBrace);
		}
		catch (PreParserException ex)
		{
			ManagerClass manager = lexer.Manager;
			manager.BeginRelatedMessageSequence();
			try
			{
				Message.Error(loc, "unclosed bracket");
				Message.Hint(ex.Location, Convert.ToString(ex.Message) + " when parsing this `(' brace group");
			}
			finally
			{
				manager.EndRelatedMessageSequence();
			}
			Token child2 = finish_parent(count, count2);
			return new Token.RoundGroup(shift_end(loc + ex.Location), child2, openBrace, null);
		}
	}

	private Token.SquareGroup parse_square_group(Location loc, Token.BeginSquare openBrace)
	{
		int count = parent_stream.Count;
		int count2 = current_stream.Count;
		try
		{
			Token token;
			while (true)
			{
				token = get_token();
				if (token is Token.EndSquare)
				{
					break;
				}
				if (token is Token.Comma)
				{
					finish_current(count2, token);
				}
				else
				{
					handle_default_token(count2, token, braces_cut_current: false);
				}
			}
			Token.EndSquare closeBrace = (Token.EndSquare)token;
			Token token2 = finish_parent(count, count2);
			Location location = loc + token.Location;
			if (token2 != null)
			{
				token2.Location = location;
			}
			return new Token.SquareGroup(location, token2, openBrace, closeBrace);
		}
		catch (PreParserException ex)
		{
			Message.Error(loc, "when parsing this `[' brace group");
			Message.Error(ex.Location, ex.Message);
			Token token3 = finish_parent(count, count2);
			Location location2 = loc + ex.Location;
			if (token3 != null)
			{
				token3.Location = location2;
			}
			return new Token.SquareGroup(shift_end(location2), token3, openBrace, null);
		}
	}

	private Token.QuoteGroup parse_quote_group(Location loc, Token.BeginQuote openBrace)
	{
		int count = parent_stream.Count;
		int count2 = current_stream.Count;
		try
		{
			Token token;
			while (true)
			{
				token = get_token();
				if (token is Token.EndQuote)
				{
					break;
				}
				if (token is Token.Semicolon)
				{
					finish_current(count2, token);
				}
				else
				{
					handle_default_token(count2, token);
				}
			}
			Token.EndQuote closeBrace = (Token.EndQuote)token;
			Token child = finish_parent(count, count2);
			return new Token.QuoteGroup(loc + token.Location, child, openBrace, closeBrace);
		}
		catch (PreParserException ex)
		{
			Message.Error(loc, "when parsing this `<[' brace group");
			Message.Error(ex.Location, ex.Message);
			Token child2 = finish_parent(count, count2);
			return new Token.QuoteGroup(shift_end(loc + ex.Location), child2, openBrace, null);
		}
	}

	private Token ParseTopLevelImpl(int nesting = 0)
	{
		_N_closureOf_ParseTopLevelImpl_44938 n_closureOf_ParseTopLevelImpl_ = new _N_closureOf_ParseTopLevelImpl_44938();
		n_closureOf_ParseTopLevelImpl_._N__N_closurised_this_ptr_44947 = this;
		int count = parent_stream.Count;
		n_closureOf_ParseTopLevelImpl_._N_current_begin_44945 = current_stream.Count;
		n_closureOf_ParseTopLevelImpl_._N_currentNsEnv_44943 = Env;
		try
		{
			Token result;
			while (true)
			{
				Token token = get_token();
				if (!object.ReferenceEquals(Env.Defines, lexer.Defines))
				{
					Env = Env.SetDefines(lexer.Defines);
				}
				if (token is Token.Keyword)
				{
					if (((Token.Keyword)token).name == "using")
					{
						_N_parse_using_directive_44997(n_closureOf_ParseTopLevelImpl_, token);
						continue;
					}
					if (((Token.Keyword)token).name == "namespace")
					{
						finish_current(n_closureOf_ParseTopLevelImpl_._N_current_begin_44945);
						GlobalEnv n_currentNsEnv_ = n_closureOf_ParseTopLevelImpl_._N_currentNsEnv_44943;
						n_closureOf_ParseTopLevelImpl_._N_currentNsEnv_44943 = Env;
						Nemerle.Builtins.Tuple<list<string>, list<Location>> tuple = _N_get_qualified_identifier_44950(n_closureOf_ParseTopLevelImpl_);
						list<string> field = tuple.Field0;
						list<Location> list = tuple.Field1;
						Location headerLocation = ((!list.IsEmpty) ? (token.Location + list.Last) : token.Location);
						Token token2 = get_token();
						if (token2 is Token.BeginBrace)
						{
							Token.BeginBrace beginBrace = (Token.BeginBrace)token2;
							last_declaration_token = null;
							Location location = token.Location + beginBrace.Location;
							GlobalEnv env = Env;
							Env = Env.EnterIntoNamespace(field);
							lexer.Keywords = Env.Keywords;
							lexer.OnBeforeNamespaceParse();
							Token body = ParseTopLevelImpl(checked(nesting + 1));
							Token token3 = last_declaration_token;
							Location location2;
							if ((object)token3 == null)
							{
								location2 = Location.Default;
							}
							else
							{
								Location location3 = last_declaration_token.Location;
								last_declaration_token = null;
								location2 = location3;
							}
							Location location4 = location2;
							Token.Namespace @namespace = new Token.Namespace(location + location4, Env, token, body);
							lexer.OnAfterNamespaceParse(@namespace.Location, field, list, env, Env, headerLocation, beginBrace.Location, location4);
							Env = env;
							lexer.Keywords = Env.Keywords;
							current_stream.Add(@namespace);
						}
						else
						{
							Token token4 = token2;
							Message.Error(token4.Location, "expecting `{' opening namespace scope");
						}
						finish_current(n_closureOf_ParseTopLevelImpl_._N_current_begin_44945);
						n_closureOf_ParseTopLevelImpl_._N_currentNsEnv_44943 = n_currentNsEnv_;
						continue;
					}
				}
				else
				{
					if (token is Token.Semicolon)
					{
						finish_current(n_closureOf_ParseTopLevelImpl_._N_current_begin_44945, token);
						continue;
					}
					if (token is Token.EndBrace)
					{
						if (nesting > 0)
						{
							last_declaration_token = token;
							reset_comment(token);
							result = finish_parent(count, n_closureOf_ParseTopLevelImpl_._N_current_begin_44945);
							break;
						}
					}
					else if (token is Token.EndOfFile && count == 0)
					{
						list<Region> incompleteRegions = lexer.IncompleteRegions;
						if (incompleteRegions is list<Region>.Cons)
						{
							Region hd = ((list<Region>.Cons)incompleteRegions).hd;
							Message.Error(hd.Location, "#endregion directive expected");
						}
						else if ((object)incompleteRegions != list<Region>.Nil._N_constant_object)
						{
							throw new MatchFailureException();
						}
						Token token5 = finish_parent(count, n_closureOf_ParseTopLevelImpl_._N_current_begin_44945);
						finished = true;
						last_declaration_token = token;
						result = token5;
						break;
					}
				}
				handle_default_token(n_closureOf_ParseTopLevelImpl_._N_current_begin_44945, token);
			}
			return result;
		}
		catch (PreParserException ex)
		{
			Message.Error(ex.Location, ex.Message);
			return finish_parent(count, n_closureOf_ParseTopLevelImpl_._N_current_begin_44945);
		}
	}

	private static FixedType parseTypeName(list<Token> _idToks2, Token _brace)
	{
		return null;
	}

	private PreParser indention_based_copy()
	{
		PreParserIndent preParserIndent = new PreParserIndent(lexer);
		preParserIndent.last_token = last_token;
		preParserIndent.Env = Env;
		preParserIndent.finished = finished;
		return preParserIndent;
	}

	public Token.BracesGroup ParseTopLevel()
	{
		try
		{
			Token token = ParseTopLevelImpl();
			Location loc = token?.Location ?? Location.Default;
			return new Token.BracesGroup(loc, token, null, null, generated: true);
		}
		catch (LexerBase.PragmaIndent)
		{
			return indention_based_copy().ParseTopLevel();
		}
	}

	[Macro("Nemerle.Assertions.Ensures:method:postadd", 0, "value != null")]
	public Token.BracesGroup PreParse()
	{
		Token.BracesGroup bracesGroup2;
		try
		{
			Token.BracesGroup bracesGroup = parse_brace_group(lexer.Location, null, expect_endbrace: false, generated: true);
			if (!finished)
			{
				Message.Error(lexer.Location, "expected end of file, encountered closing brace");
			}
			bracesGroup2 = bracesGroup;
		}
		catch (LexerBase.PragmaIndent)
		{
			bracesGroup2 = indention_based_copy().PreParse();
		}
		Token.BracesGroup bracesGroup3 = bracesGroup2;
		if (bracesGroup3 == null)
		{
			throw new AssertionException("ncc\\parsing\\PreParser.n", 672, "value != null", "The ``Ensures'' contract of method `PreParse' has been violated.".ToString());
		}
		return bracesGroup3;
	}

	private static Location shift_end(Location loc)
	{
		return (loc.EndColumn <= 1) ? loc : new Location(loc.FileIndex, loc.Line, loc.Column, loc.EndLine, checked(loc.EndColumn - 1));
	}

	[CompilerGenerated]
	internal override void RelocateImplInternal(RelocationInfo _info)
	{
		if (_info.VisitedObjects.ContainsKey(this))
		{
			return;
		}
		_info.VisitedObjects[this] = 0;
		List<Token> list = current_stream;
		if (list != null)
		{
			foreach (Token item in list)
			{
				Token token = item;
				((ISupportRelocation)token).RelocateImpl(_info);
			}
		}
		List<Token> list2 = parent_stream;
		if (list2 != null)
		{
			foreach (Token item2 in list2)
			{
				Token token2 = item2;
				((ISupportRelocation)token2).RelocateImpl(_info);
			}
		}
		last_declaration_token?.RelocateImplInternal(_info);
		last_token?.RelocateImplInternal(_info);
		lexer?.RelocateImplInternal(_info);
	}

	void ISupportRelocation.RelocateImpl(RelocationInfo _info)
	{
		//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
		this.RelocateImplInternal(_info);
	}

	private Nemerle.Builtins.Tuple<list<string>, list<Location>> _N_get_qualified_identifier_44950(_N_closureOf_ParseTopLevelImpl_44938 _N_ParseTopLevelImpl_cp_44949)
	{
		Token token = get_token();
		Nemerle.Builtins.Tuple<list<string>, list<Location>> result;
		if (token is Token.Identifier)
		{
			string name = ((Token.Identifier)token).name;
			Token token2 = get_token();
			if (token2 is Token.Operator && ((Token.Operator)token2).name == ".")
			{
				Nemerle.Builtins.Tuple<list<string>, list<Location>> tuple = _N_get_qualified_identifier_44950(_N_ParseTopLevelImpl_cp_44949);
				list<string> field = tuple.Field0;
				list<Location> tl = tuple.Field1;
				result = (((object)field != list<string>.Nil._N_constant_object) ? new Nemerle.Builtins.Tuple<list<string>, list<Location>>(new list<string>.Cons(name, field), new list<Location>.Cons(token.Location, new list<Location>.Cons(token2.Location, tl))) : new Nemerle.Builtins.Tuple<list<string>, list<Location>>(new list<string>.Cons(name, list<string>.Nil._N_constant_object), new list<Location>.Cons(token.Location, new list<Location>.Cons(token2.Location, list<Location>.Nil._N_constant_object))));
			}
			else
			{
				push_back(token2);
				result = new Nemerle.Builtins.Tuple<list<string>, list<Location>>(new list<string>.Cons(name, list<string>.Nil._N_constant_object), new list<Location>.Cons(token.Location, list<Location>.Nil._N_constant_object));
			}
		}
		else
		{
			token = token;
			Message.Error(token.Location, "expected qualified identifier, got token " + Convert.ToString(token));
			push_back(token);
			result = new Nemerle.Builtins.Tuple<list<string>, list<Location>>(list<string>.Nil._N_constant_object, list<Location>.Nil._N_constant_object);
		}
		return result;
	}

	private Nemerle.Builtins.Tuple<list<string>, list<Location>, list<Token>> _N_get_qualified_tokens_44971(_N_closureOf_ParseTopLevelImpl_44938 _N_ParseTopLevelImpl_cp_44970)
	{
		Token token = get_token();
		Nemerle.Builtins.Tuple<list<string>, list<Location>, list<Token>> result;
		if (token is Token.Identifier)
		{
			string name = ((Token.Identifier)token).name;
			Token token2 = get_token();
			if (token2 is Token.Operator && ((Token.Operator)token2).name == ".")
			{
				Nemerle.Builtins.Tuple<list<string>, list<Location>, list<Token>> tuple = _N_get_qualified_tokens_44971(_N_ParseTopLevelImpl_cp_44970);
				list<string> field = tuple.Field0;
				list<Location> tl = tuple.Field1;
				list<Token> tl2 = tuple.Field2;
				result = (((object)field != list<string>.Nil._N_constant_object) ? new Nemerle.Builtins.Tuple<list<string>, list<Location>, list<Token>>(new list<string>.Cons(name, field), new list<Location>.Cons(token.Location, new list<Location>.Cons(token2.Location, tl)), new list<Token>.Cons(token, new list<Token>.Cons(token2, tl2))) : new Nemerle.Builtins.Tuple<list<string>, list<Location>, list<Token>>(new list<string>.Cons(name, list<string>.Nil._N_constant_object), new list<Location>.Cons(token.Location, new list<Location>.Cons(token2.Location, list<Location>.Nil._N_constant_object)), new list<Token>.Cons(token, new list<Token>.Cons(token2, list<Token>.Nil._N_constant_object))));
			}
			else
			{
				push_back(token2);
				result = new Nemerle.Builtins.Tuple<list<string>, list<Location>, list<Token>>(new list<string>.Cons(name, list<string>.Nil._N_constant_object), new list<Location>.Cons(token.Location, list<Location>.Nil._N_constant_object), new list<Token>.Cons(token, list<Token>.Nil._N_constant_object));
			}
		}
		else
		{
			token = token;
			Message.Error(token.Location, "expected qualified identifier, got token " + Convert.ToString(token));
			push_back(token);
			result = new Nemerle.Builtins.Tuple<list<string>, list<Location>, list<Token>>(list<string>.Nil._N_constant_object, list<Location>.Nil._N_constant_object, list<Token>.Nil._N_constant_object);
		}
		return result;
	}

	private static Location _N_make_before_location_44991(Location location)
	{
		return new Location(location.FileIndex, location.Line, location.Column);
	}

	private void _N_parse_using_directive_44997(_N_closureOf_ParseTopLevelImpl_44938 _N_ParseTopLevelImpl_cp_44996, Token tok)
	{
		_N_closureOf_parse_using_directive_45003 n_closureOf_parse_using_directive_ = new _N_closureOf_parse_using_directive_45003();
		finish_current(_N_ParseTopLevelImpl_cp_44996._N_current_begin_44945);
		Nemerle.Builtins.Tuple<list<string>, list<Location>, list<Token>> tuple = _N_get_qualified_tokens_44971(_N_ParseTopLevelImpl_cp_44996);
		list<string> field = tuple.Field0;
		list<Location> list = tuple.Field1;
		list<Token> list2 = (n_closureOf_parse_using_directive_._N_tokens_in_body_45008 = tuple.Field2);
		Token token = get_token();
		list<string> field2;
		list<Location> nameLocations;
		Token.Using item;
		if (token is Token.Semicolon)
		{
			Token.Semicolon semicolon = (Token.Semicolon)token;
			Location location = tok.Location + semicolon.Location;
			Env = Env.AddOpenNamespace(field, location);
			lexer.Keywords = Env.Keywords;
			item = new Token.Using(location, Env, tok, _N_create_body_token_45015(n_closureOf_parse_using_directive_));
			current_stream.Add(item);
			lexer.OnAfterUsingDirectiveParse(location + _N_make_before_location_44991(semicolon.Location), field, list, "", Location.Default, _N_ParseTopLevelImpl_cp_44996._N_currentNsEnv_44943, Env);
		}
		else
		{
			if (token is Token.Operator && ((Token.Operator)token).name == "=")
			{
				tuple = _N_get_qualified_tokens_44971(_N_ParseTopLevelImpl_cp_44996);
				field2 = tuple.Field0;
				nameLocations = tuple.Field1;
				list2 = tuple.Field2;
				n_closureOf_parse_using_directive_._N_tokens_in_body_45008 = new list<Token>.Cons((Token.Operator)token, n_closureOf_parse_using_directive_._N_tokens_in_body_45008).Append(list2);
				token = get_token();
				object obj;
				if (token is Token.Semicolon)
				{
					obj = null;
				}
				else if (token is Token.BeginSquare)
				{
					obj = parseTypeName(list2, token);
				}
				else
				{
					push_back(token);
					Message.Error(token.Location, "expecting `;' after using alias");
					obj = null;
				}
				FixedType fixedType = (FixedType)obj;
				if (field is list<string>.Cons)
				{
					if ((object)((list<string>.Cons)field).tl != list<string>.Nil._N_constant_object)
					{
						goto IL_0286;
					}
					string hd = ((list<string>.Cons)field).hd;
					if (fixedType == null)
					{
						Env = Env.AddNamespaceAlias(hd, field2, tok.Location);
						lexer.OnAfterUsingDirectiveParse(tok.Location + _N_make_before_location_44991(token.Location), field2, nameLocations, hd, list.Head, _N_ParseTopLevelImpl_cp_44996._N_currentNsEnv_44943, Env);
						if (list.Length != 1)
						{
							throw new AssertionException("ncc\\parsing\\PreParser.n", 523, "idLocs.Length == 1", "");
						}
					}
					else
					{
						hd = ((list<string>.Cons)field).hd;
					}
				}
				else
				{
					if ((object)field != list<string>.Nil._N_constant_object)
					{
						goto IL_0286;
					}
					lexer.OnAfterUsingDirectiveParse(tok.Location + _N_make_before_location_44991(token.Location), field2, nameLocations, "", Location.Default, _N_ParseTopLevelImpl_cp_44996._N_currentNsEnv_44943, Env);
				}
				goto IL_0335;
			}
			token = token;
			push_back(token);
			Location location = (((object)list != list<Location>.Nil._N_constant_object) ? list.Last : tok.Location);
			location = new Location(location.FileIndex, location.EndLine, location.EndColumn);
			Message.Error(location, "expecting `;' or `='");
			lexer.OnAfterUsingDirectiveParse(tok.Location + token.Location.FromStart(), field, list, "", Location.Default, _N_ParseTopLevelImpl_cp_44996._N_currentNsEnv_44943, Env);
		}
		goto IL_0403;
		IL_0403:
		finish_current(_N_ParseTopLevelImpl_cp_44996._N_current_begin_44945);
		return;
		IL_0335:
		item = new Token.Using(tok.Location + token.Location, Env, tok, _N_create_body_token_45015(n_closureOf_parse_using_directive_));
		current_stream.Add(item);
		goto IL_0403;
		IL_0286:
		Message.Error(tok.Location, "using alias must be simple name without dots");
		lexer.OnAfterUsingDirectiveParse(tok.Location + _N_make_before_location_44991(token.Location), field2, nameLocations, field.ToString(), list.Head + list.Last, _N_ParseTopLevelImpl_cp_44996._N_currentNsEnv_44943, Env);
		goto IL_0335;
	}

	private static Token.LooseGroup _N_create_body_token_45015(_N_closureOf_parse_using_directive_45003 _N_parse_using_directive_cp_45014)
	{
		_N_closureOf_create_body_token_45021 n_closureOf_create_body_token_ = new _N_closureOf_create_body_token_45021();
		list<Token> list = _N_parse_using_directive_cp_45014._N_tokens_in_body_45008.Rev();
		n_closureOf_create_body_token_._N_next_45028 = list.Tail;
		n_closureOf_create_body_token_._N_loc_45026 = list.Head.Location;
		FunctionVoid<Token> f = new _N__N_lambda__44897__45030(n_closureOf_create_body_token_);
		list.Iter(f);
		return new Token.LooseGroup(n_closureOf_create_body_token_._N_loc_45026, list.Head);
	}
}
