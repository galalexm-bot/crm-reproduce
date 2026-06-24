using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using Nemerle.Builtins;
using Nemerle.Collections;
using Nemerle.Core;
using Nemerle.Internal;

namespace Nemerle.Compiler;

public abstract class LexerBase : ISupportRelocation
{
	protected internal enum NumberMode
	{
		Float,
		Decimal,
		Octal,
		Hex,
		Binary
	}

	public sealed class Error : Exception, ISupportRelocation
	{
		[RecordCtor]
		public Error()
		{
		}

		[RecordCtor]
		public Error(string message)
			: base(message)
		{
		}

		[RecordCtor]
		public Error(string message, Exception innerException)
			: base(message, innerException)
		{
		}

		[RecordCtor]
		public Error(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}

		[CompilerGenerated]
		internal void RelocateImplInternal(RelocationInfo _info)
		{
		}

		void ISupportRelocation.RelocateImpl(RelocationInfo _info)
		{
			//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
			this.RelocateImplInternal(_info);
		}
	}

	public sealed class PragmaIndent : Exception, ISupportRelocation
	{
		[CompilerGenerated]
		internal void RelocateImplInternal(RelocationInfo _info)
		{
		}

		void ISupportRelocation.RelocateImpl(RelocationInfo _info)
		{
			//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
			this.RelocateImplInternal(_info);
		}
	}

	private sealed class _N_closureOf__ctor_32495
	{
		internal LexerBase _N__N_closurised_this_ptr_32500;

		internal _N_closureOf__ctor_32495()
		{
		}
	}

	private sealed class _N__N_lambda__32458__32502 : Function<int, StringBuilder, char>
	{
		[SpecialName]
		private _N_closureOf__ctor_32495 _N__ctor_closure_32506;

		public _N__N_lambda__32458__32502(_N_closureOf__ctor_32495 _N__ctor_closure_32506)
		{
			this._N__ctor_closure_32506 = _N__ctor_closure_32506;
		}

		[SpecialName]
		public sealed override char apply(int _N__32456, StringBuilder _N__32457)
		{
			_N_closureOf__N_lambda__32458_32511 n_closureOf__N_lambda__32458_ = new _N_closureOf__N_lambda__32458_32511();
			n_closureOf__N_lambda__32458_._N__N_obj_cache_32518 = _N__ctor_closure_32506._N__N_closurised_this_ptr_32500;
			Function<char> function = new _N__N_method_lambda__32520(n_closureOf__N_lambda__32458_);
			Function<char> peek = function;
			n_closureOf__N_lambda__32458_._N__N_obj_cache_32516 = _N__ctor_closure_32506._N__N_closurised_this_ptr_32500;
			function = new _N__N_method_lambda__32529(n_closureOf__N_lambda__32458_);
			Function<char> read = function;
			FunctionVoid<string> error = new _N__N_lambda__32466__32538(_N__ctor_closure_32506);
			return GetCharFromHex(_N__32456, _N__32457, peek, read, error);
		}
	}

	private sealed class _N_closureOf__N_lambda__32458_32511
	{
		internal LexerBase _N__N_obj_cache_32518;

		internal LexerBase _N__N_obj_cache_32516;

		internal _N_closureOf__N_lambda__32458_32511()
		{
		}
	}

	private sealed class _N__N_method_lambda__32520 : Function<char>
	{
		[SpecialName]
		private _N_closureOf__N_lambda__32458_32511 _N__N_lambda__32458_closure_32524;

		public _N__N_method_lambda__32520(_N_closureOf__N_lambda__32458_32511 _N__N_lambda__32458_closure_32524)
		{
			this._N__N_lambda__32458_closure_32524 = _N__N_lambda__32458_closure_32524;
		}

		[SpecialName]
		public sealed override char apply()
		{
			return _N__N_lambda__32458_closure_32524._N__N_obj_cache_32518.peek();
		}
	}

	private sealed class _N__N_method_lambda__32529 : Function<char>
	{
		[SpecialName]
		private _N_closureOf__N_lambda__32458_32511 _N__N_lambda__32458_closure_32533;

		public _N__N_method_lambda__32529(_N_closureOf__N_lambda__32458_32511 _N__N_lambda__32458_closure_32533)
		{
			this._N__N_lambda__32458_closure_32533 = _N__N_lambda__32458_closure_32533;
		}

		[SpecialName]
		public sealed override char apply()
		{
			return _N__N_lambda__32458_closure_32533._N__N_obj_cache_32516.read();
		}
	}

	private sealed class _N__N_lambda__32466__32538 : FunctionVoid<string>
	{
		[SpecialName]
		private _N_closureOf__ctor_32495 _N__ctor_closure_32542;

		public _N__N_lambda__32466__32538(_N_closureOf__ctor_32495 _N__ctor_closure_32542)
		{
			this._N__ctor_closure_32542 = _N__ctor_closure_32542;
		}

		[SpecialName]
		public sealed override void apply_void(string _N__32465)
		{
			Message.Error(_N__ctor_closure_32542._N__N_closurised_this_ptr_32500.Location, _N__32465);
		}
	}

	private sealed class _N__N_lambda__32474__32547 : Function<char, StringBuilder, char>
	{
		[SpecialName]
		private _N_closureOf__ctor_32495 _N__ctor_closure_32551;

		public _N__N_lambda__32474__32547(_N_closureOf__ctor_32495 _N__ctor_closure_32551)
		{
			this._N__ctor_closure_32551 = _N__ctor_closure_32551;
		}

		[SpecialName]
		public sealed override char apply(char _N__32472, StringBuilder _N__32473)
		{
			Function<int, StringBuilder, char> get_char_from_hex = _N__ctor_closure_32551._N__N_closurised_this_ptr_32500.get_char_from_hex;
			FunctionVoid<string> error = new _N__N_lambda__32482__32556(_N__ctor_closure_32551);
			return EscapeValue(_N__32472, _N__32473, get_char_from_hex, error);
		}
	}

	private sealed class _N__N_lambda__32482__32556 : FunctionVoid<string>
	{
		[SpecialName]
		private _N_closureOf__ctor_32495 _N__ctor_closure_32560;

		public _N__N_lambda__32482__32556(_N_closureOf__ctor_32495 _N__ctor_closure_32560)
		{
			this._N__ctor_closure_32560 = _N__ctor_closure_32560;
		}

		[SpecialName]
		public sealed override void apply_void(string _N__32481)
		{
			Message.Error(_N__ctor_closure_32560._N__N_closurised_this_ptr_32500.Location, _N__32481);
		}
	}

	private sealed class _N_closureOf_parse_preprocessor_32963
	{
		internal LexerBase _N__N_closurised_this_ptr_32968;

		internal _N_closureOf_parse_preprocessor_32963()
		{
		}
	}

	private sealed class _N_closureOf_get_number_33615
	{
		internal LexerBase _N__N_closurised_this_ptr_33622;

		internal bool _N_already_seen_type_33620;

		internal _N_closureOf_get_number_33615()
		{
		}
	}

	private list<Region> incompleteRegions;

	private list<Region> regions;

	protected bool isPendingChar;

	protected char pendingChar;

	protected int line;

	protected int col;

	protected int file_idx;

	protected List<int> _linesLengths;

	private bool _intoCode;

	public Set<string> Keywords;

	private readonly List<Comment> comments;

	private readonly List<Directive> directives;

	protected readonly StringBuilder id_buffer;

	protected Location insert_location;

	protected Token tok_pending;

	protected bool counting_indentation;

	protected bool insert_indent;

	protected string indent_string;

	protected bool in_indentation_mode;

	protected bool white_beginning;

	protected Nemerle.Collections.Stack<int> eating_stack;

	protected int eating_now;

	private int line_stack;

	private int line_start;

	protected readonly string file_real;

	protected Map<string, bool> defines;

	private bool is_check_wrong_chars;

	protected readonly Function<int, StringBuilder, char> get_char_from_hex;

	protected readonly Function<char, StringBuilder, char> escape_value;

	protected static readonly bool[] opchars;

	public static readonly Set<string> BaseKeywords;

	public readonly ManagerClass Manager;

	public int[] LinesLengths => _linesLengths.ToArray();

	public int LinesCount => checked(_linesLengths.Count - 1);

	public bool IsEof { get; private set; }

	public Location Location => new Location(file_idx, line, col);

	public InternalTypeClass InternalType => Manager.InternalType;

	public SystemTypeClass SystemTypeCache => Manager.SystemTypeCache;

	public list<Region> IncompleteRegions
	{
		[DebuggerStepThrough]
		[CompilerGenerated]
		get
		{
			return incompleteRegions;
		}
	}

	public list<Region> Regions
	{
		[DebuggerStepThrough]
		[CompilerGenerated]
		get
		{
			return regions;
		}
	}

	public bool InIndentationMode
	{
		[DebuggerStepThrough]
		[CompilerGenerated]
		get
		{
			return in_indentation_mode;
		}
	}

	public Map<string, bool> Defines
	{
		[DebuggerStepThrough]
		[CompilerGenerated]
		get
		{
			return defines;
		}
	}

	protected LexerBase(ManagerClass manager, string fn)
	{
		_N_closureOf__ctor_32495 n_closureOf__ctor_ = new _N_closureOf__ctor_32495();
		incompleteRegions = list<Region>.Nil._N_constant_object;
		regions = list<Region>.Nil._N_constant_object;
		_linesLengths = new List<int>(256);
		comments = new List<Comment>(64);
		directives = new List<Directive>(16);
		id_buffer = new StringBuilder();
		get_char_from_hex = new _N__N_lambda__32458__32502(n_closureOf__ctor_);
		escape_value = new _N__N_lambda__32474__32547(n_closureOf__ctor_);
		base._002Ector();
		n_closureOf__ctor_._N__N_closurised_this_ptr_32500 = this;
		Manager = manager;
		line = 1;
		col = 1;
		isPendingChar = false;
		white_beginning = true;
		defines = Manager.Options.CommandDefines;
		eating_stack = new Nemerle.Collections.Stack<int>();
		eating_now = 0;
		line_stack = -1;
		file_real = fn;
	}

	public Comment[] GetComments()
	{
		return comments.ToArray();
	}

	public Directive[] GetDirectives()
	{
		return directives.ToArray();
	}

	protected internal override void OnAfterUsingDirectiveParse(Location location, list<string> name, list<Location> nameLocations, string alias, Location aliasLocation, GlobalEnv beforeEnv, GlobalEnv afterEnv)
	{
		Manager._afterUsingDirectiveParse?.apply_void(location, name, nameLocations, alias, aliasLocation, beforeEnv, afterEnv);
	}

	protected internal override void OnBeforeNamespaceParse()
	{
		Manager._beforeNamespaceParse?.apply_void();
	}

	protected internal override void OnAfterNamespaceParse(Location location, list<string> name, list<Location> nameLocations, GlobalEnv outsideEnv, GlobalEnv insideEnv, Location headerLocation, Location bodyOpenTokenLocation, Location bodyCloseTokenLocation)
	{
		Manager._afterNamespaceParse?.apply_void(location, name, nameLocations, outsideEnv, insideEnv, headerLocation, bodyOpenTokenLocation, bodyCloseTokenLocation);
	}

	protected void register_comment(int position, bool isMultiline, bool isDocument)
	{
		int position2 = get_position();
		comments.Add(new Comment(position, checked(position2 - position), isMultiline, isDocument));
	}

	protected void register_directive(int position)
	{
		int position2 = get_position();
		directives.Add(new Directive(position, checked(position2 - position)));
	}

	public void SwitchToIndentationMode()
	{
		in_indentation_mode = true;
		counting_indentation = true;
		indent_string = "";
	}

	private void pragma_indent()
	{
		if (!in_indentation_mode)
		{
			SwitchToIndentationMode();
			string text = read_to_the_end_of_line();
			throw new PragmaIndent();
		}
	}

	public void BeginParseFile()
	{
		IsEof = false;
		is_check_wrong_chars = Manager.Options.Warnings.IsEnabled(10002);
		if (_linesLengths != null)
		{
			_linesLengths.Clear();
			_linesLengths.Add(-1);
		}
	}

	public bool IsKeyword(string str)
	{
		if (Keywords == null)
		{
			throw new InvalidOperationException("Keywords property of lexer is not initialized!");
		}
		return Keywords.Contains(str);
	}

	public override Token GetToken()
	{
		object result;
		if (tok_pending != null)
		{
			Token token = tok_pending;
			tok_pending = null;
			result = token;
		}
		else
		{
			if (!isPendingChar)
			{
				bool flag = eat_whitespace();
			}
			if (insert_indent)
			{
				insert_indent = false;
				result = new Token.Indent(insert_location, indent_string);
			}
			else
			{
				int num = line;
				int num2 = col;
				Token token = do_get_token();
				if (token.Location.FileIndex == 0)
				{
					token.Location = new Location(file_idx, num, num2, line, col);
				}
				else
				{
					token.Location = new Location(file_idx, num, num2, token.Location.EndLine, token.Location.EndColumn);
				}
				result = token;
			}
		}
		return (Token)result;
	}

	protected abstract override int get_position();

	protected abstract override char read_from_input();

	protected abstract override char peek_or_white();

	protected abstract override char peek();

	protected override void ignore_comments()
	{
	}

	protected abstract override bool try_read_comment();

	protected override bool eat_whitespace()
	{
		bool flag = false;
		if (in_indentation_mode)
		{
			insert_location = Location;
		}
		bool flag2 = false;
		int result;
		while (true)
		{
			if (flag2)
			{
				read();
			}
			char c;
			try
			{
				c = peek();
			}
			catch (Error)
			{
				flag = true;
				c = '_';
			}
			char c2 = c;
			if (c2 == '\0')
			{
				flag = true;
			}
			if (flag)
			{
				if (eating_now > 0)
				{
					Message.Error(Location, "unexpected end of file before finishing preprocessor directive");
					eating_now = 0;
				}
				else if (!eating_stack.IsEmpty)
				{
					Message.Error(Location, "there are still open preprocessing directives at the end of file");
				}
				result = 0;
				break;
			}
			switch (c2)
			{
			case '\t':
			case ' ':
				flag2 = true;
				continue;
			case '\n':
			case '\r':
			case '\u0085':
			case '\u2028':
			case '\u2029':
				white_beginning = true;
				flag2 = true;
				continue;
			case '/':
				read();
				if (try_read_comment())
				{
					flag2 = false;
					continue;
				}
				if (eating_now > 0)
				{
					flag2 = false;
					continue;
				}
				pendingChar = '/';
				isPendingChar = true;
				result = 1;
				break;
			case '#':
				if (white_beginning)
				{
					Location location = Location;
					read();
					if (peek() != '>')
					{
						parse_preprocessor(location);
					}
					flag2 = false;
				}
				else
				{
					while (!IsEndOfLine(read_or_eol()))
					{
					}
					flag2 = false;
				}
				continue;
			default:
				white_beginning = false;
				if (eating_now > 0)
				{
					flag2 = true;
					continue;
				}
				result = 1;
				break;
			}
			break;
		}
		return (byte)result != 0;
	}

	public static bool IsEndOfLine(char ch)
	{
		return (ch == '\n' || ch == '\u2028' || ch == '\u2029' || ch == '\u0085') ? true : false;
	}

	protected override Token do_get_token()
	{
		char num;
		if (isPendingChar)
		{
			isPendingChar = false;
			num = pendingChar;
		}
		else
		{
			char c;
			try
			{
				c = read();
			}
			catch (Error)
			{
				c = ' ';
			}
			num = c;
		}
		char c2 = num;
		object result;
		checked
		{
			if (c2 == '"')
			{
				result = get_string('"', is_dollarized: false);
			}
			else if (c2 == '\'')
			{
				result = get_id('\'');
			}
			else if (c2 == '.')
			{
				char c3 = peek_or_white();
				if (char.IsDigit(c3))
				{
					result = get_number(c2);
				}
				else if (c3 == '.')
				{
					read();
					result = new Token.Operator("..");
				}
				else
				{
					result = new Token.Operator(".");
				}
			}
			else if (c2 == '{')
			{
				result = new Token.BeginBrace(generated: false);
			}
			else if (c2 == '}')
			{
				result = new Token.EndBrace(generated: false);
			}
			else if (c2 == '[')
			{
				result = new Token.BeginSquare();
			}
			else if (c2 == ']')
			{
				if (peek_or_white() == '>')
				{
					read();
					result = new Token.EndQuote();
				}
				else
				{
					result = new Token.EndSquare();
				}
			}
			else if (c2 == '(')
			{
				result = new Token.BeginRound();
			}
			else if (c2 == ')')
			{
				result = new Token.EndRound();
			}
			else if (c2 == ',')
			{
				result = new Token.Comma();
			}
			else if (c2 == ';')
			{
				result = new Token.Semicolon(generated: false);
			}
			else if (c2 == '<')
			{
				if (peek() == '[')
				{
					read();
					result = new Token.BeginQuote();
				}
				else
				{
					if (peek() != '#')
					{
						goto IL_01ac;
					}
					read();
					result = get_recursive_string();
				}
			}
			else if (c2 == '@')
			{
				char c4 = read();
				if (c4 == '#')
				{
					result = new Token.IdentifierToComplete("");
				}
				else if (IsOperatorChar(c4))
				{
					Token token = get_op(c4);
					if (!(token is Token.Operator))
					{
						if (!Message.SeenError)
						{
							string text = "(see backtrace)".ToString();
							Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
						}
						throw new AssertionException("ncc\\parsing\\Lexer.n", 641, "", "(see backtrace)");
					}
					string name = ((Token.Operator)token).name;
					result = new Token.Identifier(name);
				}
				else if (IsIdBeginning(c4))
				{
					Token token2 = get_id(c4);
					string name2;
					if (token2 is Token.Identifier)
					{
						name2 = ((Token.Identifier)token2).name;
					}
					else
					{
						if (!(token2 is Token.Keyword))
						{
							if (!Message.SeenError)
							{
								string text2 = "(see backtrace)".ToString();
								Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text2) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
							}
							throw new AssertionException("ncc\\parsing\\Lexer.n", 647, "", "(see backtrace)");
						}
						name2 = ((Token.Keyword)token2).name;
					}
					result = new Token.QuotedIdentifier(name2);
				}
				else
				{
					switch (c4)
					{
					case '"':
						result = get_monkey_string();
						break;
					case '(':
					{
						char c5 = read();
						if (c5 == ')')
						{
							result = new Token.Identifier("()");
							break;
						}
						throw new Error("expecting pair of parenthesis after '@'");
					}
					default:
						throw new Error("expecting operator, identifier or string literal after '@'");
					}
				}
			}
			else if (c2 == '*')
			{
				result = ((peek_or_white() != '*') ? get_op(c2) : get_op(c2));
			}
			else if (c2 == '/')
			{
				result = get_op(c2);
			}
			else if (c2 == '%' || c2 == '\\' || c2 == '`')
			{
				result = get_op(c2);
			}
			else if (c2 == '-')
			{
				result = ((peek_or_white() == '.') ? new Token.Operator("-") : get_op(c2));
			}
			else if (c2 == '+')
			{
				result = ((peek_or_white() == '.') ? new Token.Operator("+") : get_op(c2));
			}
			else if (c2 == '$')
			{
				Fake();
				int endLine = Location.Line;
				int column = Location.Column;
				bool flag = eat_whitespace();
				char c6 = peek();
				if (c6 == '"' || c6 == '@' || c6 == '<')
				{
					Location location = Location;
					char c7 = read();
					char c8 = peek();
					if (c7 == '<' && c8 != '#')
					{
						if (flag)
						{
							Token token3 = get_op('<');
							token3.Location = location;
							Location location2 = new Location(location.FileIndex, endLine, column - 1, endLine, column);
							Location loc = location2 + token3.Location;
							Token.Operator @operator = new Token.Operator(location2, "$");
							@operator.Next = token3;
							result = new Token.RoundGroup(loc, new Token.LooseGroup(loc, @operator), null, null);
						}
						else
						{
							result = get_op('$', '<');
						}
					}
					else
					{
						object obj;
						if (c7 == '"')
						{
							obj = get_string(c7, is_dollarized: true);
						}
						else if (c7 == '<' && c8 == '#')
						{
							read();
							obj = get_recursive_string();
						}
						else
						{
							if (read() != '"')
							{
								Message.Error(Location, "expected string literal after @");
							}
							obj = get_monkey_string();
						}
						Token token4 = (Token)obj;
						Location location3 = new Location(location.FileIndex, endLine, column - 1, endLine, column);
						token4.Location = location + token4.Location;
						Location loc2 = location3 + token4.Location;
						Token.Operator operator2 = new Token.Operator(location3, "$");
						operator2.Next = token4;
						result = new Token.RoundGroup(loc2, new Token.LooseGroup(loc2, operator2), null, null);
					}
				}
				else
				{
					result = ((!flag) ? get_op('$') : new Token.Operator("$"));
				}
			}
			else if (c2 == '^' || c2 == '~' || c2 == '?' || c2 == '#')
			{
				result = get_op(c2);
			}
			else
			{
				if (c2 == '=' || c2 == '>' || c2 == '!')
				{
					goto IL_01ac;
				}
				switch (c2)
				{
				case '&':
					result = get_op(c2);
					break;
				case '|':
					result = get_op(c2);
					break;
				case ':':
					result = get_op(c2);
					break;
				case ' ':
					result = new Token.EndOfFile();
					break;
				case '\0':
					result = new Token.EndOfFile();
					break;
				default:
					if (char.IsDigit(c2))
					{
						result = get_number(c2);
						break;
					}
					if (IsIdBeginning(c2))
					{
						result = get_id(c2);
						break;
					}
					throw new Error("invalid character: `" + Convert.ToString(c2) + "'");
				}
			}
			goto IL_0787;
		}
		IL_0787:
		return (Token)result;
		IL_01ac:
		result = get_op(c2);
		goto IL_0787;
	}

	protected override void parse_preprocessor(Location startLocation)
	{
		//Discarded unreachable code: IL_094d
		_N_closureOf_parse_preprocessor_32963 n_closureOf_parse_preprocessor_ = new _N_closureOf_parse_preprocessor_32963();
		n_closureOf_parse_preprocessor_._N__N_closurised_this_ptr_32968 = this;
		checked
		{
			int position = get_position() - 1;
			string text = _N_read_word_32985(n_closureOf_parse_preprocessor_);
			switch (text)
			{
			case "":
				throw new Error("expected preprocessing directive after `#'");
			case "if":
			{
				eating_stack.Push(eating_now);
				bool flag2 = PreprocessorEvaluator.EvalCondition(defines, read_to_the_end_of_line().Trim());
				if (eating_now > 0)
				{
					eating_now = 2;
				}
				else
				{
					int num5 = (eating_now = ((!flag2) ? 1 : (-1)));
				}
				break;
			}
			case "elif":
			{
				bool flag3 = PreprocessorEvaluator.EvalCondition(defines, read_to_the_end_of_line().Trim());
				switch (eating_now)
				{
				default:
					throw new Error("unbalanced preprocessing directives");
				case 1:
				{
					int num9 = (eating_now = ((!flag3) ? 1 : (-1)));
					break;
				}
				case -1:
				case 2:
					eating_now = 2;
					break;
				case -3:
				case 3:
					throw new Error("unexpected #elif after #else");
				case -4:
				case 4:
					throw new Error("unexpected #elif inside region");
				}
				break;
			}
			case "else":
				_N_eat_spaces_32971(n_closureOf_parse_preprocessor_);
				if (read_to_the_end_of_line() != "")
				{
					throw new Error("extra tokens after #else");
				}
				switch (eating_now)
				{
				default:
					throw new Error("unbalanced preprocessing directives");
				case 1:
					eating_now = -3;
					break;
				case -1:
				case 2:
					eating_now = 3;
					break;
				case -3:
				case 3:
					throw new Error("unexpected #else after #else");
				case -4:
				case 4:
					throw new Error("unexpected #else inside region");
				}
				break;
			case "endif":
				_N_eat_spaces_32971(n_closureOf_parse_preprocessor_);
				if (read_to_the_end_of_line() != "")
				{
					throw new Error("extra tokens after #endif");
				}
				switch (eating_now)
				{
				case 0:
					throw new Error("unbalanced preprocessing directives");
				case -4:
				case 4:
					throw new Error("unexpected #endif inside region");
				}
				eating_now = eating_stack.Pop();
				break;
			case "line":
			{
				_N_eat_spaces_32971(n_closureOf_parse_preprocessor_);
				char c = peek_or_white();
				Nemerle.Builtins.Tuple<int, string> tuple;
				if (c == 'd')
				{
					if (!(_N_read_word_32985(n_closureOf_parse_preprocessor_) == "default"))
					{
						throw new Error("expecting line number or `default' indicator");
					}
					_N_eat_spaces_32971(n_closureOf_parse_preprocessor_);
					if (read_to_the_end_of_line() != "")
					{
						throw new Error("extra tokens after directive");
					}
					tuple = new Nemerle.Builtins.Tuple<int, string>(-1, null);
				}
				else
				{
					StringBuilder stringBuilder = new StringBuilder();
					while (char.IsDigit(c))
					{
						stringBuilder.Append(read());
						c = peek_or_white();
					}
					if (stringBuilder.Length > 0)
					{
						tuple = new Nemerle.Builtins.Tuple<int, string>(int.Parse(stringBuilder.ToString()), read_to_the_end_of_line().Trim().Trim('"'));
					}
					else
					{
						Message.Error(Location, "expecting line number or `default' indicator");
						read_to_the_end_of_line();
						tuple = new Nemerle.Builtins.Tuple<int, string>(-1, null);
					}
				}
				Nemerle.Builtins.Tuple<int, string> tuple2 = tuple;
				int field = tuple2.Field0;
				string field2 = tuple2.Field1;
				if (Manager.IsIntelliSenseMode)
				{
					break;
				}
				if (field == -1)
				{
					if (line_stack != -1)
					{
						line = line - line_start + line_stack;
					}
					file_idx = Location.GetFileIndex(file_real);
					line_stack = -1;
					break;
				}
				if (line_stack != -1)
				{
					line = line - line_start + line_stack;
				}
				line_start = field;
				line_stack = line;
				line = field;
				if (field2 != "")
				{
					file_idx = Location.GetFileIndex(field2);
				}
				break;
			}
			case "error":
			{
				int num6 = eating_now;
				if (num6 == -1 || num6 == -3)
				{
					Message.Error(Location, read_to_the_end_of_line().Trim());
				}
				break;
			}
			case "warning":
			{
				int num8 = eating_now;
				if (num8 == -1 || num8 == -3)
				{
					Message.Warning(Location, read_to_the_end_of_line().Trim());
				}
				break;
			}
			case "region":
			{
				eating_stack.Push(eating_now);
				int num7 = (eating_now = ((eating_now <= 0) ? (-4) : 4));
				incompleteRegions = new list<Region>.Cons(new Region(startLocation, read_to_the_end_of_line(pedantic_comment_check: false)), incompleteRegions);
				break;
			}
			case "endregion":
			{
				if (eating_now != 4 && eating_now != -4)
				{
					throw new Error("Unexpected #endregion");
				}
				eating_now = eating_stack.Pop();
				list<Region> list = incompleteRegions;
				if (list is list<Region>.Cons)
				{
					Region hd = ((list<Region>.Cons)list).hd;
					list<Region> list2 = ((list<Region>.Cons)list).tl;
					hd.SetEndRegion(Location);
					regions = new list<Region>.Cons(hd, regions);
					incompleteRegions = list2;
					read_to_the_end_of_line();
					break;
				}
				if ((object)list == list<Region>.Nil._N_constant_object)
				{
					throw new Error("Unexpected preprocessor directive");
				}
				throw new MatchFailureException();
			}
			case "define":
			{
				if (_intoCode)
				{
					read_to_the_end_of_line();
					throw new Error("cannot define preprocessor symbols after first token in file");
				}
				string text9 = _N_read_word_32985(n_closureOf_parse_preprocessor_);
				if (text9 == "")
				{
					throw new Error("#define should be followed by name to define");
				}
				if (text9 == "true" || text9 == "false")
				{
					throw new Error("Attempt to define ``" + Convert.ToString(text9) + "''");
				}
				if (eating_now <= 0)
				{
					defines = defines.Replace(text9, value: true);
				}
				read_to_the_end_of_line();
				break;
			}
			case "undef":
			{
				if (_intoCode)
				{
					read_to_the_end_of_line();
					throw new Error("cannot undefine preprocessor symbols after first token in file");
				}
				string text8 = _N_read_word_32985(n_closureOf_parse_preprocessor_);
				if (text8 == "")
				{
					throw new Error("#undef should be followed by name to undefine");
				}
				if (text8 == "true" || text8 == "false")
				{
					throw new Error("Attempt to undefine ``" + Convert.ToString(text8) + "''");
				}
				if (eating_now <= 0)
				{
					defines = defines.Replace(text8, value: false);
				}
				read_to_the_end_of_line();
				break;
			}
			case "pragma":
			{
				string text3 = _N_read_word_32985(n_closureOf_parse_preprocessor_);
				if (text3 == "warning")
				{
					string text4 = _N_read_word_32985(n_closureOf_parse_preprocessor_);
					int num;
					if (text4 == "disable")
					{
						num = 1;
					}
					else
					{
						if (!(text4 == "restore"))
						{
							string text5 = text4;
							throw new Error(string.Concat("#pragma should be followed by ", "``disable'' or ``restore'', not ``" + Convert.ToString(text5) + "''"));
						}
						num = -1;
					}
					int num2 = num;
					string[] array = read_to_the_end_of_line().Replace(',', ' ').Split(null);
					bool flag = false;
					string[] array2 = array;
					foreach (string text6 in array2)
					{
						string text7 = text6;
						if (!(text7 == ""))
						{
							flag = true;
							int num3;
							try
							{
								num3 = int.Parse(text7);
							}
							catch (Exception ex)
							{
								throw new Error("invalid warning number ``" + Convert.ToString(text7) + "'': " + Convert.ToString(ex));
							}
							int num4 = num3;
							Manager.Options.Warnings.AddPragmaWarning(file_idx, line, num2 * num4);
						}
					}
					if (!flag)
					{
						Manager.Options.Warnings.AddPragmaWarning(file_idx, line, 1 * num2);
					}
				}
				else if (text3 == "indent")
				{
					pragma_indent();
				}
				else
				{
					Message.Warning(1633, Location, "unrecognized #pragma directive");
					read_to_the_end_of_line();
				}
				break;
			}
			default:
			{
				string text2 = text;
				throw new Error("unsupported preprocessing directive `" + Convert.ToString(text2) + "'");
			}
			}
			register_directive(position);
		}
	}

	protected char read_or_eol()
	{
		char c = read();
		return (c != 0) ? c : '\n';
	}

	protected char read()
	{
		char c = '\0';
		c = read_from_input();
		checked
		{
			switch (c)
			{
			case '\n':
			case '\u0085':
			case '\u2028':
			case '\u2029':
				if (_linesLengths == null)
				{
					line++;
				}
				else
				{
					_linesLengths.Add(col);
					line++;
					if (_linesLengths.Count != line && _linesLengths.Count == line - line_start + line_stack)
					{
					}
				}
				col = 1;
				break;
			case '\t':
				col++;
				if (is_check_wrong_chars)
				{
					Message.Warning(10002, Location, "tab character found in input stream");
				}
				break;
			case '\r':
				if (peek_or_white() != '\n')
				{
					c = '\n';
				}
				else if (is_check_wrong_chars)
				{
					Message.Warning(10002, Location, "CR character found in input stream");
				}
				break;
			case '\0':
				if (!IsEof)
				{
					IsEof = true;
					if (_linesLengths != null)
					{
						_linesLengths.Add(col);
					}
				}
				break;
			default:
				col++;
				break;
			}
			if (in_indentation_mode)
			{
				if (IsEndOfLine(c))
				{
					indent_string = "";
					counting_indentation = true;
					insert_indent = true;
				}
				else if (counting_indentation)
				{
					if (c == '\t' || c == ' ')
					{
						indent_string += c;
					}
					else
					{
						counting_indentation = false;
					}
				}
			}
			return c;
		}
	}

	protected void clear_id_buffer()
	{
		id_buffer.Length = 0;
	}

	protected Token get_op(char first_ch)
	{
		clear_id_buffer();
		StringBuilder stringBuilder = id_buffer.Append(first_ch);
		return continue_get_op();
	}

	protected Token get_op(char first_ch, char second_ch)
	{
		clear_id_buffer();
		StringBuilder stringBuilder = id_buffer.Append(first_ch);
		stringBuilder = id_buffer.Append(second_ch);
		return continue_get_op();
	}

	private Token continue_get_op()
	{
		bool flag = false;
		flag = true;
		while (flag)
		{
			if (IsOperatorChar(peek_or_white()))
			{
				char c = read();
				if (c == '/')
				{
					if (try_read_comment())
					{
						flag = false;
					}
					else
					{
						StringBuilder stringBuilder = id_buffer.Append('/');
					}
				}
				else
				{
					StringBuilder stringBuilder = id_buffer.Append(c);
				}
			}
			else
			{
				flag = false;
			}
		}
		return new Token.Operator(id_buffer.ToString());
	}

	protected Token get_number(char first_ch)
	{
		_N_closureOf_get_number_33615 n_closureOf_get_number_ = new _N_closureOf_get_number_33615();
		n_closureOf_get_number_._N__N_closurised_this_ptr_33622 = this;
		clear_id_buffer();
		n_closureOf_get_number_._N_already_seen_type_33620 = false;
		int num;
		switch (first_ch)
		{
		case '.':
			num = 0;
			break;
		case '0':
			switch (peek_or_white())
			{
			case 'X':
			case 'x':
				read();
				num = 3;
				break;
			case 'O':
			case 'o':
				read();
				num = 2;
				break;
			case 'B':
			case 'b':
				read();
				if (!char.IsDigit(peek_or_white()))
				{
					n_closureOf_get_number_._N_already_seen_type_33620 = true;
				}
				num = 4;
				break;
			case '0':
				Message.Warning(Location, "leading zeros look like octal modifiers, but they are not");
				num = 1;
				break;
			default:
				num = 1;
				break;
			}
			break;
		default:
			num = 1;
			break;
		}
		NumberMode numberMode = (NumberMode)num;
		bool flag = true;
		id_buffer.Append(first_ch);
		while (true)
		{
			char c = peek_or_white();
			switch (c)
			{
			case '.':
				if (numberMode == NumberMode.Decimal)
				{
					numberMode = NumberMode.Float;
					read();
					if (char.IsDigit(peek_or_white()))
					{
						id_buffer.Append('.');
						continue;
					}
					isPendingChar = true;
					pendingChar = '.';
					flag = false;
					numberMode = NumberMode.Decimal;
				}
				break;
			case 'A':
			case 'B':
			case 'C':
			case 'D':
			case 'E':
			case 'F':
			case 'a':
			case 'b':
			case 'c':
			case 'd':
			case 'e':
			case 'f':
				if (numberMode == NumberMode.Hex)
				{
					id_buffer.Append(read());
					continue;
				}
				break;
			case '_':
			{
				read();
				char c3 = char.ToLower(peek_or_white());
				if (char.IsDigit(c3) || (numberMode == NumberMode.Hex && c3 >= 'a' && c3 <= 'f'))
				{
					continue;
				}
				isPendingChar = true;
				pendingChar = '_';
				break;
			}
			default:
			{
				char c2 = c;
				if (char.IsDigit(c2))
				{
					id_buffer.Append(read());
					continue;
				}
				break;
			}
			}
			break;
		}
		if ((numberMode == NumberMode.Hex || numberMode == NumberMode.Octal) && id_buffer.Length <= 1)
		{
			Message.Error(Location, "expected value letters in numeric literal");
		}
		checked
		{
			try
			{
				object result;
				switch (numberMode)
				{
				default:
					throw new MatchFailureException();
				case NumberMode.Float:
				{
					char c6 = peek_or_white();
					result = ((c6 != 'E' && c6 != 'e') ? _N_exponent_part_33679(n_closureOf_get_number_, only_realsuf: true) : _N_exponent_part_33679(n_closureOf_get_number_, only_realsuf: false));
					break;
				}
				case NumberMode.Decimal:
					if (flag)
					{
						switch (char.ToLower(peek_or_white(), CultureInfo.InvariantCulture))
						{
						case 'e':
							result = _N_exponent_part_33679(n_closureOf_get_number_, only_realsuf: false);
							break;
						case 'd':
						case 'f':
						case 'm':
							result = _N_exponent_part_33679(n_closureOf_get_number_, only_realsuf: true);
							break;
						default:
							result = _N_check_type_suffix_33713(n_closureOf_get_number_, ulong.Parse(id_buffer.ToString()));
							break;
						}
					}
					else
					{
						result = new Token.IntegerLiteral(new Literal.Integer(ulong.Parse(id_buffer.ToString()), is_negative: false, null));
					}
					break;
				case NumberMode.Octal:
				{
					ulong num3 = 0uL;
					for (int j = 0; j < id_buffer.Length; j++)
					{
						ulong num4 = Convert.ToUInt64(id_buffer[j]) - 48uL;
						ulong num5 = num4;
						if (0 <= num5 && num5 <= 7)
						{
							num3 <<= 3;
							num3 += num5;
						}
						else
						{
							ulong num6 = num4;
							Message.Error(Location, string.Concat("octal literal number must be", " composed of 0 to 7 digits while it has `" + Convert.ToString(num6) + "'"));
						}
					}
					result = _N_check_type_suffix_33713(n_closureOf_get_number_, num3);
					break;
				}
				case NumberMode.Hex:
				{
					ulong val = ulong.Parse(id_buffer.ToString(), NumberStyles.HexNumber, CultureInfo.InvariantCulture);
					result = _N_check_type_suffix_33713(n_closureOf_get_number_, val);
					break;
				}
				case NumberMode.Binary:
				{
					ulong num2 = 0uL;
					for (int i = 0; i < id_buffer.Length; i++)
					{
						char c4 = id_buffer[i];
						switch (c4)
						{
						case '0':
							num2 <<= 1;
							break;
						case '1':
							num2 <<= 1;
							num2++;
							break;
						default:
						{
							char c5 = c4;
							Message.Error(Location, string.Concat("binary literal numer must be", " composed of 1 and 0s, while there is `" + Convert.ToString(c5) + "'"));
							break;
						}
						}
					}
					result = _N_check_type_suffix_33713(n_closureOf_get_number_, num2);
					break;
				}
				}
				return (Token)result;
			}
			catch (OverflowException)
			{
				Message.Error(Location, "number literal " + Convert.ToString(id_buffer) + " is too large for given type");
				return new Token.IntegerLiteral(new Literal.Integer(0uL, is_negative: false, null));
			}
		}
	}

	protected Token get_id(char first_ch)
	{
		char c = '\0';
		object result;
		if (first_ch == '\'' && !IsIdBeginning(peek_or_white()))
		{
			result = get_char();
		}
		else
		{
			clear_id_buffer();
			StringBuilder stringBuilder = id_buffer.Append(first_ch);
			c = peek_or_white();
			while (IsIdBeginning(c) || char.IsDigit(c) || c == '\'')
			{
				stringBuilder = id_buffer.Append(read());
				c = peek_or_white();
			}
			string text = string.Intern(id_buffer.ToString());
			_intoCode = true;
			result = ((first_ch == '\'' && text.Length == 3 && text[2] == '\'') ? new Token.CharLiteral(text[1]) : ((!IsKeyword(text)) ? ((Token)new Token.Identifier(text)) : ((Token)new Token.Keyword(text))));
		}
		return (Token)result;
	}

	protected Token.CharLiteral get_char()
	{
		string value = get_string('\'', is_dollarized: false).value;
		if (value.Length == 0)
		{
			throw new Error("empty character literal");
		}
		if (value.Length != 1)
		{
			throw new Error("character literal too long");
		}
		return new Token.CharLiteral(value[0]);
	}

	protected Token.StringLiteral get_string(char end_ch, bool is_dollarized)
	{
		Token.StringLiteral stringLiteral = null;
		int num = line;
		checked
		{
			int num2 = col - 1;
			StringBuilder stringBuilder = new StringBuilder();
			StringBuilder stringBuilder2 = new StringBuilder();
			StringBuilder stringBuilder3 = stringBuilder2.Append(end_ch);
			while (true)
			{
				char c = read();
				stringBuilder3 = stringBuilder2.Append(c);
				if (c == '\\')
				{
					c = escape_value.apply(read(), stringBuilder2);
					stringBuilder3 = stringBuilder.Append(c);
					continue;
				}
				if (c == '$')
				{
					if (!is_dollarized && end_ch == '"')
					{
						c = peek_or_white();
						if (char.IsLetter(c) || c == '_' || c == '(')
						{
							Message.Warning(10007, Location, "`$' occurs inside string literal, which is not prefixed itself with `$'");
						}
						stringBuilder3 = stringBuilder.Append('$');
						continue;
					}
					c = c;
					if (c != end_ch)
					{
						goto IL_00f0;
					}
				}
				else
				{
					if (c == '\0')
					{
						stringBuilder2.Length--;
						Message.Error(Location, "Unterminated string literal");
						break;
					}
					if (c == '\n' || c == '\u2028' || c == '\u2029' || c == '\u0085')
					{
						stringBuilder2.Length--;
						Message.Error(Location, "Newline in constant");
						break;
					}
					c = c;
					if (c != end_ch)
					{
						goto IL_00f0;
					}
				}
				stringLiteral = new Token.StringLiteral(stringBuilder.ToString(), stringBuilder2.ToString());
				stringLiteral.Location = new Location(file_idx, num, num2, line, col);
				break;
				IL_00f0:
				stringBuilder3 = stringBuilder.Append(c);
			}
			Token.StringLiteral result;
			if (stringLiteral == null)
			{
				stringLiteral = new Token.StringLiteral(stringBuilder.ToString(), stringBuilder2.ToString());
				stringLiteral.Location = new Location(file_idx, num, num2, line, col);
				result = stringLiteral;
			}
			else
			{
				result = stringLiteral;
			}
			return result;
		}
	}

	protected Token get_monkey_string()
	{
		StringBuilder stringBuilder = new StringBuilder(32);
		int num = line;
		checked
		{
			int num2 = col - 2;
			StringBuilder stringBuilder2 = new StringBuilder();
			StringBuilder stringBuilder3 = stringBuilder2.Append("@\"");
			Token.StringLiteral result;
			while (true)
			{
				char c = read();
				stringBuilder3 = stringBuilder2.Append(c);
				switch (c)
				{
				case '"':
				{
					c = peek_or_white();
					if (c == '"')
					{
						stringBuilder3 = stringBuilder.Append('"');
						c = read();
						continue;
					}
					Token.StringLiteral stringLiteral = new Token.StringLiteral(stringBuilder.ToString(), stringBuilder2.ToString());
					stringLiteral.Location = new Location(file_idx, num, num2, line, col);
					result = stringLiteral;
					break;
				}
				case '\0':
				{
					Message.Error(Location, "Unterminated string literal");
					stringBuilder2.Length--;
					Token.StringLiteral stringLiteral = new Token.StringLiteral(stringBuilder.ToString(), stringBuilder2.ToString());
					stringLiteral.Location = new Location(file_idx, num, num2, line, col - 1);
					result = stringLiteral;
					break;
				}
				default:
					stringBuilder3 = stringBuilder.Append(c);
					continue;
				}
				break;
			}
			return result;
		}
	}

	protected Token get_recursive_string()
	{
		StringBuilder stringBuilder = new StringBuilder(1024);
		StringBuilder stringBuilder2 = new StringBuilder();
		StringBuilder stringBuilder3 = stringBuilder2.Append("<#");
		int num = line;
		checked
		{
			int num2 = col - 2;
			int num3 = 1;
			Token.StringLiteral result;
			while (true)
			{
				char c = read();
				stringBuilder3 = stringBuilder2.Append(c);
				if (c == '<')
				{
					if (peek() == '#')
					{
						stringBuilder3 = stringBuilder2.Append(read());
						stringBuilder3 = stringBuilder.Append("<#");
						num3++;
						continue;
					}
				}
				else
				{
					if (c == '#')
					{
						c = read();
						stringBuilder3 = stringBuilder2.Append(c);
						if (c == '>')
						{
							if (num3 == 1)
							{
								Token.StringLiteral stringLiteral = new Token.StringLiteral(stringBuilder.ToString(), stringBuilder2.ToString());
								stringLiteral.Location = new Location(file_idx, num, num2, line, col);
								result = stringLiteral;
								break;
							}
							stringBuilder3 = stringBuilder.Append("#>");
							num3--;
						}
						else
						{
							stringBuilder3 = stringBuilder.Append('#');
							stringBuilder3 = stringBuilder.Append(c);
							num3 = num3;
						}
						continue;
					}
					if (c == '\0')
					{
						Message.Error(Location, "Unterminated string literal");
						stringBuilder2.Length--;
						Token.StringLiteral stringLiteral = new Token.StringLiteral(stringBuilder.ToString(), stringBuilder2.ToString());
						stringLiteral.Location = new Location(file_idx, num, num2, line, col - 1);
						result = stringLiteral;
						break;
					}
				}
				stringBuilder3 = stringBuilder.Append(c);
				num3 = num3;
			}
			return result;
		}
	}

	private string read_to_the_end_of_line(bool pedantic_comment_check = true)
	{
		char c = '\0';
		c = read_or_eol();
		StringBuilder stringBuilder = new StringBuilder(80);
		while (!IsEndOfLine(c))
		{
			if (c == '/')
			{
				c = read_or_eol();
				if (c != '/')
				{
					if (!pedantic_comment_check)
					{
						continue;
					}
					if (Message.ErrorCount <= 0)
					{
						Message.Warning(1696, Location, "Single-line comment or end-of-line expected");
					}
				}
				while (!IsEndOfLine(c))
				{
					c = read_or_eol();
				}
			}
			else
			{
				StringBuilder stringBuilder2 = stringBuilder.Append(c);
				c = read_or_eol();
			}
		}
		return stringBuilder.ToString();
	}

	static LexerBase()
	{
		int num = 0;
		string[] coll = new string[53]
		{
			"_", "abstract", "and", "array", "as", "base", "catch", "class", "def", "delegate",
			"enum", "event", "extern", "false", "finally", "fun", "implements", "interface", "internal", "is",
			"macro", "match", "matches", "module", "mutable", "namespace", "new", "null", "out", "override",
			"params", "partial", "private", "protected", "public", "ref", "sealed", "static", "struct", "syntax",
			"this", "throw", "true", "try", "typeof", "using", "variant", "virtual", "void", "volatile",
			"when", "where", "with"
		};
		BaseKeywords = new Set<string>(coll);
		char[] array = new char[21]
		{
			'=', '<', '>', '@', '^', '&', '-', '+', '|', '*',
			'/', '$', '%', '!', '?', '~', '.', ':', '#', '\\',
			'`'
		};
		opchars = new bool[256];
		foreach (char c in array)
		{
			opchars[(uint)c] = true;
		}
	}

	public static bool IsIdBeginning(char ch)
	{
		return char.IsLetter(ch) || ch == '_';
	}

	public static bool IsOperatorChar(char ch)
	{
		return ch <= 'ÿ' && opchars[(uint)ch];
	}

	public static bool IsOperator(string str)
	{
		bool flag = false;
		CharEnumerator enumerator = str.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				char current = enumerator.Current;
				char c = current;
				if (!IsOperatorChar(c) && !IsOperatorSpecial(c))
				{
					return false;
				}
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		return true;
	}

	public static bool HasKeywordChars(string str)
	{
		bool flag = false;
		CharEnumerator enumerator = str.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				char current = enumerator.Current;
				char c = current;
				if (!char.IsLetterOrDigit(c) && c != '_')
				{
					return false;
				}
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		return true;
	}

	public static char GetCharFromHex(int len, StringBuilder rawStringBuilder, Function<char> peek, Function<char> read, FunctionVoid<string> error)
	{
		int num = ((len >= 0) ? len : 4);
		StringBuilder stringBuilder = new StringBuilder(num);
		int num2 = 0;
		int num3;
		while (true)
		{
			if (num2 < num)
			{
				char c = peek.apply();
				if (c == 'a' || c == 'A' || c == 'b' || c == 'B' || c == 'c' || c == 'C' || c == 'd' || c == 'D' || c == 'e' || c == 'E' || c == 'f' || c == 'F' || c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9')
				{
					stringBuilder.Append(read.apply());
					num2 = checked(num2 + 1);
					continue;
				}
				if (len == -1 && num2 != 0)
				{
					num3 = 1;
					break;
				}
				error.apply_void("bad escape character '" + Convert.ToString(c) + "'");
				num3 = 0;
				break;
			}
			num3 = 1;
			break;
		}
		bool flag = (byte)num3 != 0;
		rawStringBuilder?.Append(stringBuilder);
		int result;
		if (flag)
		{
			char c2;
			try
			{
				c2 = Convert.ToChar(ulong.Parse(stringBuilder.ToString(), NumberStyles.HexNumber, CultureInfo.InvariantCulture));
			}
			catch (OverflowException)
			{
				error.apply_void("Character literal '" + Convert.ToString(stringBuilder) + "' must be in the range U+0000 to U+FFFF");
				c2 = '?';
			}
			result = c2;
		}
		else
		{
			result = 63;
		}
		return (char)result;
	}

	public static char EscapeValue(char ch, StringBuilder rawStringBuilder, Function<int, StringBuilder, char> get_char_from_hex, FunctionVoid<string> error)
	{
		if (rawStringBuilder != null)
		{
			StringBuilder stringBuilder = rawStringBuilder.Append(ch);
		}
		int result;
		switch (ch)
		{
		case 'n':
			result = 10;
			break;
		case 't':
			result = 9;
			break;
		case 'r':
			result = 13;
			break;
		case 'e':
			result = 27;
			break;
		case 'a':
			result = 7;
			break;
		case 'b':
			result = 8;
			break;
		case 'f':
			result = 12;
			break;
		case 'v':
			result = 11;
			break;
		case '"':
			result = 34;
			break;
		case '\'':
			result = 39;
			break;
		case '\\':
			result = 92;
			break;
		case '0':
			result = 0;
			break;
		case 'x':
			result = get_char_from_hex.apply(-1, rawStringBuilder);
			break;
		case 'u':
			result = get_char_from_hex.apply(4, rawStringBuilder);
			break;
		case 'U':
			result = get_char_from_hex.apply(8, rawStringBuilder);
			break;
		case '$':
			result = 36;
			break;
		default:
			error.apply_void("bad escape character `\\" + Convert.ToString(ch) + "'");
			result = 32;
			break;
		}
		return (char)result;
	}

	private static void Fake()
	{
		if (1 == 0)
		{
			throw new AssertionException("ncc\\parsing\\Lexer.n", 1761, "true", "");
		}
	}

	private static bool IsOperatorSpecial(char c)
	{
		return (c == '(' || c == ')' || c == ';' || c == '[' || c == ']') ? true : false;
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
		tok_pending?.RelocateImplInternal(_info);
		insert_location = Completion.Relocate(insert_location, _info);
		list<Region> list = regions;
		if (list != null)
		{
			list = list;
			while (list is list<Region>.Cons)
			{
				Region hd = ((list<Region>.Cons)list).hd;
				list = ((list<Region>.Cons)list).tl;
				((ISupportRelocation)hd).RelocateImpl(_info);
				list = list;
			}
		}
		list = incompleteRegions;
		if (list != null)
		{
			list = list;
			while (list is list<Region>.Cons)
			{
				Region hd = ((list<Region>.Cons)list).hd;
				list = ((list<Region>.Cons)list).tl;
				((ISupportRelocation)hd).RelocateImpl(_info);
				list = list;
			}
		}
	}

	void ISupportRelocation.RelocateImpl(RelocationInfo _info)
	{
		//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
		this.RelocateImplInternal(_info);
	}

	private void _N_eat_spaces_32971(_N_closureOf_parse_preprocessor_32963 _N_parse_preprocessor_cp_32970)
	{
		char c = '\0';
		c = peek();
		while (char.IsWhiteSpace(c) && !IsEndOfLine(c))
		{
			c = read();
			c = peek();
		}
	}

	private string _N_read_word_32985(_N_closureOf_parse_preprocessor_32963 _N_parse_preprocessor_cp_32984)
	{
		_N_eat_spaces_32971(_N_parse_preprocessor_cp_32984);
		StringBuilder stringBuilder = new StringBuilder();
		try
		{
			while (IsIdBeginning(peek_or_white()) || char.IsDigit(peek_or_white()))
			{
				stringBuilder.Append(read());
			}
		}
		catch (Error)
		{
		}
		return stringBuilder.ToString();
	}

	private Token _N_exponent_part_33679(_N_closureOf_get_number_33615 _N_get_number_cp_33678, bool only_realsuf)
	{
		if (!only_realsuf)
		{
			char c = peek_or_white();
			if (c == 'E' || c == 'e')
			{
				StringBuilder stringBuilder = id_buffer.Append(read());
				c = peek_or_white();
				if (c == '+' || c == '-')
				{
					stringBuilder = id_buffer.Append(read());
				}
				if (!char.IsDigit(peek_or_white()))
				{
					throw new Error("no digits after exponent sign in float literal");
				}
				do
				{
					stringBuilder = id_buffer.Append(read());
				}
				while (char.IsDigit(peek_or_white()));
			}
		}
		object result;
		switch (char.ToLower(peek_or_white(), CultureInfo.InvariantCulture))
		{
		case 'f':
		{
			char c = read();
			result = new Token.FloatLiteral(float.Parse(id_buffer.ToString(), NumberFormatInfo.InvariantInfo));
			break;
		}
		case 'd':
		{
			char c = read();
			result = new Token.DoubleLiteral(double.Parse(id_buffer.ToString(), NumberFormatInfo.InvariantInfo));
			break;
		}
		case 'm':
		{
			char c = read();
			result = new Token.DecimalLiteral(decimal.Parse(id_buffer.ToString(), NumberStyles.Float, NumberFormatInfo.InvariantInfo));
			break;
		}
		default:
			result = new Token.DoubleLiteral(double.Parse(id_buffer.ToString(), NumberFormatInfo.InvariantInfo));
			break;
		}
		return (Token)result;
	}

	private Token.IntegerLiteral _N_check_type_suffix_33713(_N_closureOf_get_number_33615 _N_get_number_cp_33712, ulong val)
	{
		char c = '\0';
		bool flag = false;
		c = ((!_N_get_number_cp_33712._N_already_seen_type_33620) ? char.ToLower(peek_or_white(), CultureInfo.InvariantCulture) : 'b');
		if (_N_special_33719(c))
		{
			char c2;
			if (!_N_get_number_cp_33712._N_already_seen_type_33620)
			{
				c2 = read();
			}
			flag = c == 'u';
			c2 = char.ToLower(peek_or_white(), CultureInfo.InvariantCulture);
			if (_N_special_33719(c2))
			{
				char c3 = read();
				if (c2 == 'u')
				{
					if (flag)
					{
						throw new Error("bad integer suffix (unsigned twice)");
					}
					flag = true;
				}
				else
				{
					if (c == 's')
					{
						if (c2 == 'b')
						{
							goto IL_00a5;
						}
					}
					else if (c == 'b' && c2 == 's')
					{
						goto IL_00a5;
					}
					if (!flag)
					{
						throw new Error("bad integer suffix (type contraint twice)");
					}
					c = c2;
				}
			}
			else if (c == 'b')
			{
				flag = true;
			}
			goto IL_00f2;
		}
		Token.IntegerLiteral result = new Token.IntegerLiteral(new Literal.Integer(val, is_negative: false, null));
		goto IL_0187;
		IL_00f2:
		result = new Token.IntegerLiteral(checked(c switch
		{
			'b' => (!flag) ? Literal.FromSByte((sbyte)(int)val) : Literal.FromByte((byte)val), 
			's' => (!flag) ? Literal.FromShort((short)(int)val) : Literal.FromUShort((ushort)val), 
			'l' => (!flag) ? Literal.FromLong((long)val) : Literal.FromULong(val), 
			_ => Literal.FromUInt((uint)val), 
		}));
		goto IL_0187;
		IL_00a5:
		c = 'b';
		goto IL_00f2;
		IL_0187:
		return result;
	}

	private static bool _N_special_33719(char c)
	{
		return (c == 'l' || c == 's' || c == 'b' || c == 'u') ? true : false;
	}
}
