using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Core;
using Nemerle.Internal;

namespace Nemerle.Compiler;

[Variant("Nemerle.Compiler.Token.Identifier,Nemerle.Compiler.Token.QuotedIdentifier,Nemerle.Compiler.Token.IdentifierToComplete,Nemerle.Compiler.Token.Keyword,Nemerle.Compiler.Token.Operator,Nemerle.Compiler.Token.StringLiteral,Nemerle.Compiler.Token.CharLiteral,Nemerle.Compiler.Token.IntegerLiteral,Nemerle.Compiler.Token.FloatLiteral,Nemerle.Compiler.Token.DoubleLiteral,Nemerle.Compiler.Token.DecimalLiteral,Nemerle.Compiler.Token.Comment,Nemerle.Compiler.Token.Semicolon,Nemerle.Compiler.Token.Comma,Nemerle.Compiler.Token.BeginBrace,Nemerle.Compiler.Token.EndBrace,Nemerle.Compiler.Token.BeginRound,Nemerle.Compiler.Token.EndRound,Nemerle.Compiler.Token.BeginSquare,Nemerle.Compiler.Token.EndSquare,Nemerle.Compiler.Token.BeginQuote,Nemerle.Compiler.Token.EndQuote,Nemerle.Compiler.Token.Indent,Nemerle.Compiler.Token.WhiteSpace,Nemerle.Compiler.Token.NewLine,Nemerle.Compiler.Token.RoundGroup,Nemerle.Compiler.Token.BracesGroup,Nemerle.Compiler.Token.SquareGroup,Nemerle.Compiler.Token.QuoteGroup,Nemerle.Compiler.Token.LooseGroup,Nemerle.Compiler.Token.Namespace,Nemerle.Compiler.Token.Using,Nemerle.Compiler.Token.EndOfFile,Nemerle.Compiler.Token.EndOfGroup")]
public abstract class Token : IEnumerable, IEnumerable<Token>, ISupportRelocation
{
	[VariantOption]
	public class Identifier : Token
	{
		public readonly string name;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 0;
		}

		[RecordCtor]
		public Identifier([MappedMember("name")] string name)
		{
			this.name = name;
		}

		[RecordCtor]
		public Identifier(Location loc, [MappedMember("name")] string name)
			: base(loc)
		{
			this.name = name;
		}
	}

	[VariantOption]
	public class QuotedIdentifier : Token
	{
		public readonly string name;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 1;
		}

		[RecordCtor]
		public QuotedIdentifier([MappedMember("name")] string name)
		{
			this.name = name;
		}

		[RecordCtor]
		public QuotedIdentifier(Location loc, [MappedMember("name")] string name)
			: base(loc)
		{
			this.name = name;
		}
	}

	[VariantOption]
	public class IdentifierToComplete : Token
	{
		public readonly string prefix;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 2;
		}

		[RecordCtor]
		public IdentifierToComplete([MappedMember("prefix")] string prefix)
		{
			this.prefix = prefix;
		}

		[RecordCtor]
		public IdentifierToComplete(Location loc, [MappedMember("prefix")] string prefix)
			: base(loc)
		{
			this.prefix = prefix;
		}
	}

	[VariantOption]
	public class Keyword : Token
	{
		public readonly string name;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 3;
		}

		[RecordCtor]
		public Keyword([MappedMember("name")] string name)
		{
			this.name = name;
		}

		[RecordCtor]
		public Keyword(Location loc, [MappedMember("name")] string name)
			: base(loc)
		{
			this.name = name;
		}
	}

	[VariantOption]
	public class Operator : Token
	{
		public readonly string name;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 4;
		}

		[RecordCtor]
		public Operator([MappedMember("name")] string name)
		{
			this.name = name;
		}

		[RecordCtor]
		public Operator(Location loc, [MappedMember("name")] string name)
			: base(loc)
		{
			this.name = name;
		}
	}

	[VariantOption]
	public class StringLiteral : Token
	{
		public readonly string value;

		public readonly string rawString;

		public StringLiteral(string val)
			: this(val, "")
		{
		}

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 5;
		}

		[RecordCtor]
		public StringLiteral([MappedMember("value")] string value, [MappedMember("rawString")] string rawString)
		{
			this.value = value;
			this.rawString = rawString;
		}

		[RecordCtor]
		public StringLiteral(Location loc, [MappedMember("value")] string value, [MappedMember("rawString")] string rawString)
			: base(loc)
		{
			this.value = value;
			this.rawString = rawString;
		}
	}

	[VariantOption]
	public class CharLiteral : Token
	{
		public readonly char value;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 6;
		}

		[RecordCtor]
		public CharLiteral([MappedMember("value")] char value)
		{
			this.value = value;
		}

		[RecordCtor]
		public CharLiteral(Location loc, [MappedMember("value")] char value)
			: base(loc)
		{
			this.value = value;
		}
	}

	[VariantOption]
	public class IntegerLiteral : Token
	{
		public readonly Literal.Integer lit;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 7;
		}

		[RecordCtor]
		public IntegerLiteral([MappedMember("lit")] Literal.Integer lit)
		{
			this.lit = lit;
		}

		[RecordCtor]
		public IntegerLiteral(Location loc, [MappedMember("lit")] Literal.Integer lit)
			: base(loc)
		{
			this.lit = lit;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				lit?.RelocateImplInternal(_info);
			}
		}
	}

	[VariantOption]
	public class FloatLiteral : Token
	{
		public readonly float value;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 8;
		}

		[RecordCtor]
		public FloatLiteral([MappedMember("value")] float value)
		{
			this.value = value;
		}

		[RecordCtor]
		public FloatLiteral(Location loc, [MappedMember("value")] float value)
			: base(loc)
		{
			this.value = value;
		}
	}

	[VariantOption]
	public class DoubleLiteral : Token
	{
		public readonly double value;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 9;
		}

		[RecordCtor]
		public DoubleLiteral([MappedMember("value")] double value)
		{
			this.value = value;
		}

		[RecordCtor]
		public DoubleLiteral(Location loc, [MappedMember("value")] double value)
			: base(loc)
		{
			this.value = value;
		}
	}

	[VariantOption]
	public class DecimalLiteral : Token
	{
		public readonly decimal value;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 10;
		}

		[RecordCtor]
		public DecimalLiteral([MappedMember("value")] decimal value)
		{
			this.value = value;
		}

		[RecordCtor]
		public DecimalLiteral(Location loc, [MappedMember("value")] decimal value)
			: base(loc)
		{
			this.value = value;
		}
	}

	[VariantOption]
	public class Comment : Token
	{
		public readonly string value;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 11;
		}

		[RecordCtor]
		public Comment([MappedMember("value")] string value)
		{
			this.value = value;
		}

		[RecordCtor]
		public Comment(Location loc, [MappedMember("value")] string value)
			: base(loc)
		{
			this.value = value;
		}
	}

	[VariantOption]
	public class Semicolon : Token
	{
		public readonly bool generated;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 12;
		}

		[RecordCtor]
		public Semicolon([MappedMember("generated")] bool generated)
		{
			this.generated = generated;
		}

		[RecordCtor]
		public Semicolon(Location loc, [MappedMember("generated")] bool generated)
			: base(loc)
		{
			this.generated = generated;
		}
	}

	[VariantOption]
	public class Comma : Token
	{
		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 13;
		}

		[RecordCtor]
		public Comma()
		{
		}

		[RecordCtor]
		public Comma(Location loc)
			: base(loc)
		{
		}
	}

	[VariantOption]
	public class BeginBrace : Token
	{
		public readonly bool generated;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 14;
		}

		[RecordCtor]
		public BeginBrace([MappedMember("generated")] bool generated)
		{
			this.generated = generated;
		}

		[RecordCtor]
		public BeginBrace(Location loc, [MappedMember("generated")] bool generated)
			: base(loc)
		{
			this.generated = generated;
		}
	}

	[VariantOption]
	public class EndBrace : Token
	{
		public readonly bool generated;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 15;
		}

		[RecordCtor]
		public EndBrace([MappedMember("generated")] bool generated)
		{
			this.generated = generated;
		}

		[RecordCtor]
		public EndBrace(Location loc, [MappedMember("generated")] bool generated)
			: base(loc)
		{
			this.generated = generated;
		}
	}

	[VariantOption]
	public class BeginRound : Token
	{
		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 16;
		}

		[RecordCtor]
		public BeginRound()
		{
		}

		[RecordCtor]
		public BeginRound(Location loc)
			: base(loc)
		{
		}
	}

	[VariantOption]
	public class EndRound : Token
	{
		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 17;
		}

		[RecordCtor]
		public EndRound()
		{
		}

		[RecordCtor]
		public EndRound(Location loc)
			: base(loc)
		{
		}
	}

	[VariantOption]
	public class BeginSquare : Token
	{
		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 18;
		}

		[RecordCtor]
		public BeginSquare()
		{
		}

		[RecordCtor]
		public BeginSquare(Location loc)
			: base(loc)
		{
		}
	}

	[VariantOption]
	public class EndSquare : Token
	{
		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 19;
		}

		[RecordCtor]
		public EndSquare()
		{
		}

		[RecordCtor]
		public EndSquare(Location loc)
			: base(loc)
		{
		}
	}

	[VariantOption]
	public class BeginQuote : Token
	{
		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 20;
		}

		[RecordCtor]
		public BeginQuote()
		{
		}

		[RecordCtor]
		public BeginQuote(Location loc)
			: base(loc)
		{
		}
	}

	[VariantOption]
	public class EndQuote : Token
	{
		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 21;
		}

		[RecordCtor]
		public EndQuote()
		{
		}

		[RecordCtor]
		public EndQuote(Location loc)
			: base(loc)
		{
		}
	}

	[VariantOption]
	public class Indent : Token
	{
		public readonly string value;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 22;
		}

		[RecordCtor]
		public Indent([MappedMember("value")] string value)
		{
			this.value = value;
		}

		[RecordCtor]
		public Indent(Location loc, [MappedMember("value")] string value)
			: base(loc)
		{
			this.value = value;
		}
	}

	[VariantOption]
	public class WhiteSpace : Token
	{
		public readonly string value;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 23;
		}

		[RecordCtor]
		public WhiteSpace([MappedMember("value")] string value)
		{
			this.value = value;
		}

		[RecordCtor]
		public WhiteSpace(Location loc, [MappedMember("value")] string value)
			: base(loc)
		{
			this.value = value;
		}
	}

	[VariantOption]
	public class NewLine : Token
	{
		public readonly string value;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 24;
		}

		[RecordCtor]
		public NewLine([MappedMember("value")] string value)
		{
			this.value = value;
		}

		[RecordCtor]
		public NewLine(Location loc, [MappedMember("value")] string value)
			: base(loc)
		{
			this.value = value;
		}
	}

	[VariantOption]
	public class RoundGroup : Token
	{
		public readonly Token Child;

		public readonly BeginRound OpenBrace;

		public readonly EndRound CloseBrace;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 25;
		}

		[RecordCtor]
		public RoundGroup([MappedMember("Child")] Token child, [MappedMember("OpenBrace")] BeginRound openBrace, [MappedMember("CloseBrace")] EndRound closeBrace)
		{
			Child = child;
			OpenBrace = openBrace;
			CloseBrace = closeBrace;
		}

		[RecordCtor]
		public RoundGroup(Location loc, [MappedMember("Child")] Token child, [MappedMember("OpenBrace")] BeginRound openBrace, [MappedMember("CloseBrace")] EndRound closeBrace)
			: base(loc)
		{
			Child = child;
			OpenBrace = openBrace;
			CloseBrace = closeBrace;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				CloseBrace?.RelocateImplInternal(_info);
				OpenBrace?.RelocateImplInternal(_info);
				Child?.RelocateImplInternal(_info);
			}
		}
	}

	[VariantOption]
	public class BracesGroup : Token
	{
		public readonly Token Child;

		public readonly BeginBrace OpenBrace;

		public readonly EndBrace CloseBrace;

		public readonly bool generated;

		public BracesGroup(Token child)
		{
			Child = child;
		}

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 26;
		}

		[RecordCtor]
		public BracesGroup([MappedMember("Child")] Token child, [MappedMember("OpenBrace")] BeginBrace openBrace, [MappedMember("CloseBrace")] EndBrace closeBrace, [MappedMember("generated")] bool generated)
		{
			Child = child;
			OpenBrace = openBrace;
			CloseBrace = closeBrace;
			this.generated = generated;
		}

		[RecordCtor]
		public BracesGroup(Location loc, [MappedMember("Child")] Token child, [MappedMember("OpenBrace")] BeginBrace openBrace, [MappedMember("CloseBrace")] EndBrace closeBrace, [MappedMember("generated")] bool generated)
			: base(loc)
		{
			Child = child;
			OpenBrace = openBrace;
			CloseBrace = closeBrace;
			this.generated = generated;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				CloseBrace?.RelocateImplInternal(_info);
				OpenBrace?.RelocateImplInternal(_info);
				Child?.RelocateImplInternal(_info);
			}
		}
	}

	[VariantOption]
	public class SquareGroup : Token
	{
		public Token Child;

		public readonly BeginSquare OpenBrace;

		public readonly EndSquare CloseBrace;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 27;
		}

		[RecordCtor]
		public SquareGroup([MappedMember("Child")] Token child, [MappedMember("OpenBrace")] BeginSquare openBrace, [MappedMember("CloseBrace")] EndSquare closeBrace)
		{
			Child = child;
			OpenBrace = openBrace;
			CloseBrace = closeBrace;
		}

		[RecordCtor]
		public SquareGroup(Location loc, [MappedMember("Child")] Token child, [MappedMember("OpenBrace")] BeginSquare openBrace, [MappedMember("CloseBrace")] EndSquare closeBrace)
			: base(loc)
		{
			Child = child;
			OpenBrace = openBrace;
			CloseBrace = closeBrace;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				CloseBrace?.RelocateImplInternal(_info);
				OpenBrace?.RelocateImplInternal(_info);
				Child?.RelocateImplInternal(_info);
			}
		}
	}

	[VariantOption]
	public class QuoteGroup : Token
	{
		public readonly Token Child;

		public readonly BeginQuote OpenBrace;

		public readonly EndQuote CloseBrace;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 28;
		}

		[RecordCtor]
		public QuoteGroup([MappedMember("Child")] Token child, [MappedMember("OpenBrace")] BeginQuote openBrace, [MappedMember("CloseBrace")] EndQuote closeBrace)
		{
			Child = child;
			OpenBrace = openBrace;
			CloseBrace = closeBrace;
		}

		[RecordCtor]
		public QuoteGroup(Location loc, [MappedMember("Child")] Token child, [MappedMember("OpenBrace")] BeginQuote openBrace, [MappedMember("CloseBrace")] EndQuote closeBrace)
			: base(loc)
		{
			Child = child;
			OpenBrace = openBrace;
			CloseBrace = closeBrace;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				CloseBrace?.RelocateImplInternal(_info);
				OpenBrace?.RelocateImplInternal(_info);
				Child?.RelocateImplInternal(_info);
			}
		}
	}

	[VariantOption]
	public class LooseGroup : Token
	{
		public Token Child;

		[IgnoreField]
		public readonly Token SeparatorToken;

		public LooseGroup(Location loc, Token child, Token separatorToken)
			: base(loc)
		{
			Child = child;
			SeparatorToken = separatorToken;
		}

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 29;
		}

		[RecordCtor]
		public LooseGroup([MappedMember("Child")] Token child)
		{
			Child = child;
		}

		[RecordCtor]
		public LooseGroup(Location loc, [MappedMember("Child")] Token child)
			: base(loc)
		{
			Child = child;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				SeparatorToken?.RelocateImplInternal(_info);
				Child?.RelocateImplInternal(_info);
			}
		}
	}

	[VariantOption]
	public class Namespace : Token
	{
		public readonly GlobalEnv Env;

		public readonly Token KeywordToken;

		public readonly Token Body;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 30;
		}

		[RecordCtor]
		public Namespace([MappedMember("Env")] GlobalEnv env, [MappedMember("KeywordToken")] Token keywordToken, [MappedMember("Body")] Token body)
		{
			Env = env;
			KeywordToken = keywordToken;
			Body = body;
		}

		[RecordCtor]
		public Namespace(Location loc, [MappedMember("Env")] GlobalEnv env, [MappedMember("KeywordToken")] Token keywordToken, [MappedMember("Body")] Token body)
			: base(loc)
		{
			Env = env;
			KeywordToken = keywordToken;
			Body = body;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				Body?.RelocateImplInternal(_info);
				KeywordToken?.RelocateImplInternal(_info);
			}
		}
	}

	[VariantOption]
	public class Using : Token
	{
		public readonly GlobalEnv Env;

		public readonly Token KeywordToken;

		public readonly Token Body;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 31;
		}

		[RecordCtor]
		public Using([MappedMember("Env")] GlobalEnv env, [MappedMember("KeywordToken")] Token keywordToken, [MappedMember("Body")] Token body)
		{
			Env = env;
			KeywordToken = keywordToken;
			Body = body;
		}

		[RecordCtor]
		public Using(Location loc, [MappedMember("Env")] GlobalEnv env, [MappedMember("KeywordToken")] Token keywordToken, [MappedMember("Body")] Token body)
			: base(loc)
		{
			Env = env;
			KeywordToken = keywordToken;
			Body = body;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				Body?.RelocateImplInternal(_info);
				KeywordToken?.RelocateImplInternal(_info);
			}
		}
	}

	[VariantOption]
	public class EndOfFile : Token
	{
		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 32;
		}

		[RecordCtor]
		public EndOfFile()
		{
		}

		[RecordCtor]
		public EndOfFile(Location loc)
			: base(loc)
		{
		}
	}

	[VariantOption]
	public class EndOfGroup : Token
	{
		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 33;
		}

		[RecordCtor]
		public EndOfGroup()
		{
		}

		[RecordCtor]
		public EndOfGroup(Location loc)
			: base(loc)
		{
		}
	}

	private class _N_Enumerator_31662 : IEnumerator, IDisposable, IEnumerator<Token>
	{
		internal Token _N_current_31686;

		internal Token _N_child_31684;

		internal Token _N_current;

		internal int _N_state;

		internal Function<bool> _N__N_yielding_function_31680;

		internal Token _N__N_closurised_this_ptr_31678;

		internal Function<bool> _N__N_wildcard_3438_31676;

		public Token Current => _N_current;

		public void Dispose()
		{
			_N_state = -1;
		}

		public void Reset()
		{
			//Discarded unreachable code: IL_0006
			throw new NotSupportedException();
		}

		public bool MoveNext()
		{
			try
			{
				bool flag = false;
				Token n_current_;
				if (_N_state != 1)
				{
					if (_N_state != 0)
					{
						return false;
					}
					if (_N__N_closurised_this_ptr_31678 is RoundGroup)
					{
						_N_child_31684 = ((RoundGroup)_N__N_closurised_this_ptr_31678).Child;
					}
					else if (_N__N_closurised_this_ptr_31678 is BracesGroup)
					{
						_N_child_31684 = ((BracesGroup)_N__N_closurised_this_ptr_31678).Child;
					}
					else if (_N__N_closurised_this_ptr_31678 is SquareGroup)
					{
						_N_child_31684 = ((SquareGroup)_N__N_closurised_this_ptr_31678).Child;
					}
					else if (_N__N_closurised_this_ptr_31678 is QuoteGroup)
					{
						_N_child_31684 = ((QuoteGroup)_N__N_closurised_this_ptr_31678).Child;
					}
					else if (_N__N_closurised_this_ptr_31678 is LooseGroup)
					{
						_N_child_31684 = ((LooseGroup)_N__N_closurised_this_ptr_31678).Child;
					}
					else if (_N__N_closurised_this_ptr_31678 is Namespace)
					{
						_N_child_31684 = ((Namespace)_N__N_closurised_this_ptr_31678).Body;
					}
					else
					{
						if (!(_N__N_closurised_this_ptr_31678 is Using))
						{
							throw new ArgumentException("this is not a group token");
						}
						_N_child_31684 = ((Using)_N__N_closurised_this_ptr_31678).Body;
					}
					n_current_ = _N_child_31684;
				}
				else
				{
					n_current_ = _N_current_31686.Next;
				}
				_N_current_31686 = n_current_;
				if (_N_current_31686 != null)
				{
					_N_current = _N_current_31686;
					_N_state = 1;
					return true;
				}
				return false;
			}
			catch
			{
				//try-fault
				Dispose();
				throw;
			}
		}

		[SpecialName]
		object IEnumerator.get_Current()
		{
			return Current;
		}
	}

	public Location Location;

	public Token Next;

	public Token()
	{
	}

	public Token(Location loc)
	{
		Location = loc;
	}

	public override string ToString()
	{
		object result;
		switch (_N_GetVariantCodeSafe(this))
		{
		default:
			throw new MatchFailureException();
		case 0:
		{
			string value = ((Identifier)this).name;
			result = value;
			break;
		}
		case 1:
		{
			string value = ((QuotedIdentifier)this).name;
			result = "@" + value;
			break;
		}
		case 2:
		{
			string value = ((IdentifierToComplete)this).prefix;
			result = "<COMPLETE '" + Convert.ToString(value) + "'>";
			break;
		}
		case 3:
		{
			string value = ((Keyword)this).name;
			result = value;
			break;
		}
		case 4:
		{
			string value = ((Operator)this).name;
			result = value;
			break;
		}
		case 5:
		{
			string value = ((StringLiteral)this).rawString;
			result = value;
			break;
		}
		case 6:
			result = string.Concat("'" + ((CharLiteral)this).value, "'");
			break;
		case 7:
		{
			Literal.Integer lit = ((IntegerLiteral)this).lit;
			result = lit.ToString();
			break;
		}
		case 8:
			result = ((FloatLiteral)this).value.ToString();
			break;
		case 9:
			result = ((DoubleLiteral)this).value.ToString();
			break;
		case 10:
			result = ((DecimalLiteral)this).value.ToString();
			break;
		case 11:
		{
			string value = ((Comment)this).value;
			result = string.Concat("/*" + value, "*/");
			break;
		}
		case 12:
			result = ";";
			break;
		case 13:
			result = ",";
			break;
		case 14:
			result = "{";
			break;
		case 15:
			result = "}";
			break;
		case 16:
			result = "(";
			break;
		case 17:
			result = ")";
			break;
		case 18:
			result = "[";
			break;
		case 19:
			result = "]";
			break;
		case 20:
			result = "<[";
			break;
		case 21:
			result = "]>";
			break;
		case 22:
			result = "indentation";
			break;
		case 23:
		{
			string value = ((WhiteSpace)this).value;
			result = value;
			break;
		}
		case 24:
			result = "\\r\\n";
			break;
		case 25:
		case 26:
		case 27:
		case 28:
		case 29:
			result = PreParser.Dump(this, "");
			break;
		case 30:
		{
			GlobalEnv env = ((Namespace)this).Env;
			Token body = ((Namespace)this).Body;
			result = string.Concat(string.Concat(string.Concat("namespace " + env.CurrentNamespace.GetDisplayName(), " { "), PreParser.Dump(body, "")), " }");
			break;
		}
		case 31:
			result = "using import;";
			break;
		case 32:
			result = " /*EOF*/ ";
			break;
		case 33:
			result = " /*EOG*/ ";
			break;
		}
		return (string)result;
	}

	public IEnumerator<Token> GetEnumerator()
	{
		_N_Enumerator_31662 n_Enumerator_ = new _N_Enumerator_31662();
		n_Enumerator_._N__N_closurised_this_ptr_31678 = this;
		return n_Enumerator_;
	}

	public string ToString(bool describe)
	{
		object result;
		if (describe)
		{
			switch (_N_GetVariantCodeSafe(this))
			{
			default:
				throw new MatchFailureException();
			case 0:
			{
				string value = ((Identifier)this).name;
				result = string.Concat("identifier `" + value, "'");
				break;
			}
			case 1:
			{
				string value = ((QuotedIdentifier)this).name;
				result = string.Concat("quoted identifier `" + value, "'");
				break;
			}
			case 2:
			{
				string value = ((IdentifierToComplete)this).prefix;
				result = string.Concat("identifier to complete `" + value, "'");
				break;
			}
			case 3:
			{
				string value = ((Keyword)this).name;
				result = string.Concat("keyword `" + value, "'");
				break;
			}
			case 4:
			{
				string value = ((Operator)this).name;
				result = string.Concat("operator `" + value, "'");
				break;
			}
			case 5:
				result = "string literal";
				break;
			case 6:
				result = "character literal";
				break;
			case 7:
				result = "integer number literal";
				break;
			case 8:
				result = "float literal";
				break;
			case 9:
				result = "double literal";
				break;
			case 10:
				result = "decimal literal";
				break;
			case 11:
				result = "documentation comment";
				break;
			case 12:
				result = ((!((Semicolon)this).generated) ? string.Concat("operator `" + ToString(), "'") : "end of statement");
				break;
			case 14:
				result = ((!((BeginBrace)this).generated) ? string.Concat("operator `" + ToString(), "'") : "group begin");
				break;
			case 15:
				result = ((!((EndBrace)this).generated) ? string.Concat("operator `" + ToString(), "'") : "group end");
				break;
			case 13:
			case 16:
			case 17:
			case 18:
			case 19:
			case 20:
			case 21:
				result = string.Concat("operator `" + ToString(), "'");
				break;
			case 22:
			{
				string value = ((Indent)this).value;
				result = "indentation `" + Convert.ToString(value) + "'";
				break;
			}
			case 23:
				result = "";
				break;
			case 24:
			{
				string value = ((NewLine)this).value;
				result = "newline char: '" + Convert.ToString(value) + "'";
				break;
			}
			case 25:
				result = "`(...)' group";
				break;
			case 26:
				result = "`{...}' group";
				break;
			case 27:
				result = "`[...]' group";
				break;
			case 28:
				result = "`<[...]>' group";
				break;
			case 29:
			{
				Token child = ((LooseGroup)this).Child;
				result = ((child != null) ? child.ToString(describe: true) : "token group");
				break;
			}
			case 30:
				result = "namespace scoping";
				break;
			case 31:
				result = "using declaration";
				break;
			case 32:
				result = "end of file";
				break;
			case 33:
				result = "separator or closing bracket";
				break;
			}
		}
		else
		{
			result = ToString();
		}
		return (string)result;
	}

	[SpecialName]
	public abstract override int _N_GetVariantCode();

	[SpecialName]
	public static int _N_GetVariantCodeSafe(Token x)
	{
		return ((object)x != null) ? x._N_GetVariantCode() : (-1);
	}

	[SpecialName]
	public static int _N_GetVariantCodeObject(object x)
	{
		return (!(x is Token)) ? (-1) : ((Token)x)._N_GetVariantCode();
	}

	[CompilerGenerated]
	internal override void RelocateImplInternal(RelocationInfo _info)
	{
		if (!_info.VisitedObjects.ContainsKey(this))
		{
			_info.VisitedObjects[this] = 0;
			Next?.RelocateImplInternal(_info);
			Location = Completion.Relocate(Location, _info);
		}
	}

	void ISupportRelocation.RelocateImpl(RelocationInfo _info)
	{
		//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
		this.RelocateImplInternal(_info);
	}

	[SpecialName]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}
