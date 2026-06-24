using System;
using System.CodeDom.Compiler;
using System.Linq;
using Antlr.Runtime;
using EleWise.TemplateGenerator.Keywords;

namespace EleWise.TemplateGenerator.Adl;

[GeneratedCode("ANTLR", "3.3.1.7705")]
[CLSCompliant(false)]
public class AdlLexer : Lexer
{
	private class DFA15 : DFA
	{
		private const string DFA15_eotS = "\u0001\u0012\u0001\u0015\u0001\u0016\u0001\u0017\u0001\u0018\u0001\u0019\u0001\u001a\u0001\u001b\u0001\u001f\u0001\u0012\u0001#\u0001$\u0001%\u0001&\u0001\u0012\u0001-\u0001.\u00010\n\uffff\u00017\u0001\u0012\u00019\u0001\uffff\u0002\u0012\u0001=\u0004\uffff\u0003C\u0001\u0012\u0001\uffff\u0001\u0012\u0002\uffff\u0001.\b\uffff\u0001\u0012\u0002\uffff\u0002\u0012\u0005\uffff\u0001\u0012\u0001\uffff\u0002\u0012\u0003C\u0001-\u0004\uffff\u0001\u0012\u0001\uffff\u0001\u001f\u0001#\u0001\uffff\u00017";

		private const string DFA15_eofS = "T\uffff";

		private const string DFA15_minS = "\u0001\t\u0001#\a\0\u0001g\b\0\u0004\uffff\a\0\u0001g\u0002\0\u0002t\t\0\u0001\uffff\u00010\u0004\0\u0006\uffff\u0001\0\u0001t\u0001\0\u0001\uffff\u0002;\u0001\0\u0004\uffff\b\0\u0004\uffff\u0001;\u0001\uffff\u0002\0\u0001\uffff\u0001\0";

		private const string DFA15_maxS = "\u0001\ufaff\u0001$\a\uffff\u0001l\b\uffff\u0004\uffff\u0006\0\u0001\uffff\u0001g\u0001\uffff\u0001\0\u0002t\u0001\uffff\u0004\0\u0004\uffff\u0001\uffff\u00019\u0002\0\u0001\uffff\u0001\0\u0006\uffff\u0001\0\u0001t\u0001\0\u0001\uffff\u0002;\u0001\0\u0004\uffff\u0001\uffff\u0001\0\u0006\uffff\u0004\uffff\u0001;\u0001\uffff\u0002\uffff\u0001\uffff\u0001\uffff";

		private const string DFA15_acceptS = "\u0012\uffff\u0001\u0016\u0001\u0001\u0001\u0002\u0001\u0003\u0015\uffff\u0001\u0012\u0005\uffff\u0001\u0004\u0001\u0005\u0001\u0006\u0001\a\u0001\b\u0001\t\u0003\uffff\u0001\u000e\u0003\uffff\u0001\f\u0001\u000f\u0001\u0010\u0001\u0011\b\uffff\u0001\u0013\u0001\u0014\u0001\u0015\u0001\n\u0001\uffff\u0001\r\u0002\uffff\u0001\v\u0001\uffff";

		private const string DFA15_specialS = "\u0001\0\u0001\uffff\u0001\u0001\u0001\u0002\u0001\u0003\u0001\u0004\u0001\u0005\u0001\u0006\u0001\a\u0001\b\u0001\t\u0001\n\u0001\v\u0001\f\u0001\r\u0001\u000e\u0001\u000f\u0001\u0010\u0004\uffff\u0001\u0011\u0001\u0012\u0001\u0013\u0001\u0014\u0001\u0015\u0001\u0016\u0001\u0017\u0001\u0018\u0001\u0019\u0001\u001a\u0001\u001b\u0001\u001c\u0001\u001d\u0001\u001e\u0001\u001f\u0001 \u0001!\u0001\"\u0001#\u0001$\u0001%\u0001\uffff\u0001&\u0001'\u0001(\u0001)\u0001*\u0006\uffff\u0001+\u0001,\u0001-\u0001\uffff\u0001.\u0001/\u00010\u0004\uffff\u00011\u00012\u00013\u00014\u00015\u00016\u00017\u00018\u0004\uffff\u00019\u0001\uffff\u0001:\u0001;\u0001\uffff\u0001<}>";

		private static readonly string[] DFA15_transitionS;

		private static readonly short[] DFA15_eot;

		private static readonly short[] DFA15_eof;

		private static readonly char[] DFA15_min;

		private static readonly char[] DFA15_max;

		private static readonly short[] DFA15_accept;

		private static readonly short[] DFA15_special;

		private static readonly short[][] DFA15_transition;

		public override string Description => "1:1: Tokens : ( VARIABLE | GLOBALVARIABLE | PROG_START | PROG_END | PLUS | MINUS | MULT | DIVISION | EQUAL | NEQUAL | GE | GT | LE | LT | SEMICOLON | LPAREN | RPAREN | CHARACTER_STRING | NUMBER | IDENTIFIER | WS | PLAINTEXT );";

		static DFA15()
		{
			DFA15_transitionS = new string[84]
			{
				"\u0002\u0011\u0002\uffff\u0001\u0011\u0012\uffff\u0001\u0011\u0003\uffff\u0001\u0010\u0001\uffff\u0001\t\u0001\u000e\u0001\f\u0001\r\u0001\u0005\u0001\u0003\u0001\uffff\u0001\u0004\u0001\uffff\u0001\u0006\n\u000f\u0001\uffff\u0001\v\u0001\b\u0001\a\u0001\n\u0002\uffff\u001a\u0010\u0004\uffff\u0001\u0010\u0001\uffff\u001a\u0010\u0001\u0001\u0001\uffff\u0001\u0002B\uffff\u0017\u0010\u0001\uffff\u001f\u0010\u0001\uffffἈ\u0010\u0018\uffff\u0002\u000eဦ\uffffŐ\u0010Ű\uffff\u0080\u0010\u0080\uffffम\u0010გ\uffff刀\u0010夀\uffffȀ\u0010", "\u0001\u0014\u0001\u0013", "{\u0012\u0001\uffffﾄ\u0012", "{\u0012\u0001\uffffﾄ\u0012", "{\u0012\u0001\uffffﾄ\u0012", "{\u0012\u0001\uffffﾄ\u0012", "{\u0012\u0001\uffffﾄ\u0012", "{\u0012\u0001\uffffﾄ\u0012", "&\u0012\u0001\u001d\u0016\u0012\u0001\u001e\u0001\u001c<\u0012\u0001\uffffﾄ\u0012", "\u0001!\u0004\uffff\u0001 ",
				"=\u0012\u0001\"=\u0012\u0001\uffffﾄ\u0012", "{\u0012\u0001\uffffﾄ\u0012", "{\u0012\u0001\uffffﾄ\u0012", "{\u0012\u0001\uffffﾄ\u0012", "'*\u0001'S*\u0001+ᾜ*\u0001(\u0001)\udfe6*", ",\u0012\u0001,\u0001\u0012\u0001,\u0001\u0012\n\u000fA\u0012\u0001\uffffﾄ\u0012", "$\u0012\u0001/\v\u0012\n/\a\u0012\u001a/\u0004\u0012\u0001/\u0001\u0012\u001a/\u0001\uffffD\u0012\u0017/\u0001\u0012\u001f/\u0001\u0012Ἀ/၀\u0012Ő/Ű\u0012\u0080/\u0080\u0012म/გ\u0012刀/夀\u0012Ȁ/Ԁ\u0012", "{\u0012\u0001\uffffﾄ\u0012", "", "",
				"", "", "\u0001\uffff", "\u0001\uffff", "\u0001\uffff", "\u0001\uffff", "\u0001\uffff", "\u0001\uffff", "{\u0012\u0001\uffffﾄ\u0012", "\u00018",
				"{\u0012\u0001\uffffﾄ\u0012", "\u0001\uffff", "\u0001;", "\u0001<", "{\u0012\u0001\uffffﾄ\u0012", "\u0001\uffff", "\u0001\uffff", "\u0001\uffff", "\u0001\uffff", "'\u0012\u0001BS\u0012\u0001\uffffﾄ\u0012",
				"{\u0012\u0001\uffffᾜ\u0012\u0001D\udfe7\u0012", "{\u0012\u0001\uffffᾝ\u0012\u0001E\udfe6\u0012", "'*\u0001FS*\u0001+ᾜ*\u0001G\u0001H\udfe6*", "", "\nI", "\u0001\uffff", "\u0001\uffff", "$\u0012\u0001/\v\u0012\n/\a\u0012\u001a/\u0004\u0012\u0001/\u0001\u0012\u001a/\u0001\uffffD\u0012\u0017/\u0001\u0012\u001f/\u0001\u0012Ἀ/၀\u0012Ő/Ű\u0012\u0080/\u0080\u0012म/გ\u0012刀/夀\u0012Ȁ/Ԁ\u0012", "\u0001\uffff", "",
				"", "", "", "", "", "\u0001\uffff", "\u0001N", "\u0001\uffff", "", "\u0001P",
				"\u0001Q", "\u0001\uffff", "", "", "", "", "'*\u0001FS*\u0001+ᾜ*\u0001G\u0001H\udfe6*", "\u0001\uffff", "'*\u0001FS*\u0001+ᾜ*\u0001G\u0001H\udfe6*", "'*\u0001FS*\u0001+ᾜ*\u0001G\u0001H\udfe6*",
				"'\u0012\u0001BS\u0012\u0001\uffffﾄ\u0012", "{\u0012\u0001\uffffᾜ\u0012\u0001D\udfe7\u0012", "{\u0012\u0001\uffffᾝ\u0012\u0001E\udfe6\u0012", "0\u0012\nIA\u0012\u0001\uffffﾄ\u0012", "", "", "", "", "\u0001S", "",
				"&\u0012\u0001\u001d\u0016\u0012\u0001\u001e\u0001\u001c<\u0012\u0001\uffffﾄ\u0012", "=\u0012\u0001\"=\u0012\u0001\uffffﾄ\u0012", "", "{\u0012\u0001\uffffﾄ\u0012"
			};
			DFA15_eot = DFA.UnpackEncodedString("\u0001\u0012\u0001\u0015\u0001\u0016\u0001\u0017\u0001\u0018\u0001\u0019\u0001\u001a\u0001\u001b\u0001\u001f\u0001\u0012\u0001#\u0001$\u0001%\u0001&\u0001\u0012\u0001-\u0001.\u00010\n\uffff\u00017\u0001\u0012\u00019\u0001\uffff\u0002\u0012\u0001=\u0004\uffff\u0003C\u0001\u0012\u0001\uffff\u0001\u0012\u0002\uffff\u0001.\b\uffff\u0001\u0012\u0002\uffff\u0002\u0012\u0005\uffff\u0001\u0012\u0001\uffff\u0002\u0012\u0003C\u0001-\u0004\uffff\u0001\u0012\u0001\uffff\u0001\u001f\u0001#\u0001\uffff\u00017");
			DFA15_eof = DFA.UnpackEncodedString("T\uffff");
			DFA15_min = DFA.UnpackEncodedStringToUnsignedChars("\u0001\t\u0001#\a\0\u0001g\b\0\u0004\uffff\a\0\u0001g\u0002\0\u0002t\t\0\u0001\uffff\u00010\u0004\0\u0006\uffff\u0001\0\u0001t\u0001\0\u0001\uffff\u0002;\u0001\0\u0004\uffff\b\0\u0004\uffff\u0001;\u0001\uffff\u0002\0\u0001\uffff\u0001\0");
			DFA15_max = DFA.UnpackEncodedStringToUnsignedChars("\u0001\ufaff\u0001$\a\uffff\u0001l\b\uffff\u0004\uffff\u0006\0\u0001\uffff\u0001g\u0001\uffff\u0001\0\u0002t\u0001\uffff\u0004\0\u0004\uffff\u0001\uffff\u00019\u0002\0\u0001\uffff\u0001\0\u0006\uffff\u0001\0\u0001t\u0001\0\u0001\uffff\u0002;\u0001\0\u0004\uffff\u0001\uffff\u0001\0\u0006\uffff\u0004\uffff\u0001;\u0001\uffff\u0002\uffff\u0001\uffff\u0001\uffff");
			DFA15_accept = DFA.UnpackEncodedString("\u0012\uffff\u0001\u0016\u0001\u0001\u0001\u0002\u0001\u0003\u0015\uffff\u0001\u0012\u0005\uffff\u0001\u0004\u0001\u0005\u0001\u0006\u0001\a\u0001\b\u0001\t\u0003\uffff\u0001\u000e\u0003\uffff\u0001\f\u0001\u000f\u0001\u0010\u0001\u0011\b\uffff\u0001\u0013\u0001\u0014\u0001\u0015\u0001\n\u0001\uffff\u0001\r\u0002\uffff\u0001\v\u0001\uffff");
			DFA15_special = DFA.UnpackEncodedString("\u0001\0\u0001\uffff\u0001\u0001\u0001\u0002\u0001\u0003\u0001\u0004\u0001\u0005\u0001\u0006\u0001\a\u0001\b\u0001\t\u0001\n\u0001\v\u0001\f\u0001\r\u0001\u000e\u0001\u000f\u0001\u0010\u0004\uffff\u0001\u0011\u0001\u0012\u0001\u0013\u0001\u0014\u0001\u0015\u0001\u0016\u0001\u0017\u0001\u0018\u0001\u0019\u0001\u001a\u0001\u001b\u0001\u001c\u0001\u001d\u0001\u001e\u0001\u001f\u0001 \u0001!\u0001\"\u0001#\u0001$\u0001%\u0001\uffff\u0001&\u0001'\u0001(\u0001)\u0001*\u0006\uffff\u0001+\u0001,\u0001-\u0001\uffff\u0001.\u0001/\u00010\u0004\uffff\u00011\u00012\u00013\u00014\u00015\u00016\u00017\u00018\u0004\uffff\u00019\u0001\uffff\u0001:\u0001;\u0001\uffff\u0001<}>");
			int num = DFA15_transitionS.Length;
			DFA15_transition = new short[num][];
			for (int i = 0; i < num; i++)
			{
				DFA15_transition[i] = DFA.UnpackEncodedString(DFA15_transitionS[i]);
			}
		}

		public DFA15(BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition)
			: base(specialStateTransition)
		{
			base.recognizer = recognizer;
			decisionNumber = 15;
			eot = DFA15_eot;
			eof = DFA15_eof;
			min = DFA15_min;
			max = DFA15_max;
			accept = DFA15_accept;
			special = DFA15_special;
			transition = DFA15_transition;
		}

		public override void Error(NoViableAltException nvae)
		{
		}
	}

	private bool isProgramMode;

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

	private DFA15 dfa15;

	internal KeywordLocalizationStore KeywordLocalizationStore { get; set; }

	public bool IsProgramMode
	{
		get
		{
			return isProgramMode;
		}
		set
		{
			isProgramMode = value;
		}
	}

	public override string GrammarFileName => "Adl\\Adl.g3";

	public override void ReportError(RecognitionException e)
	{
		base.ReportError(e);
		throw e;
	}

	private int CheckKeyword(string text)
	{
		if (KeywordLocalizationStore == null)
		{
			throw new NullReferenceException("KeywordLocalizationStore == null");
		}
		KeywordType? keywordType = KeywordLocalizationStore.CheckWord(text);
		if (!keywordType.HasValue)
		{
			return 16;
		}
		return ((KeywordTokenAttribute)typeof(KeywordType).GetMember(keywordType.Value.ToString())[0].GetCustomAttributes(typeof(KeywordTokenAttribute), inherit: false).FirstOrDefault())?.Token ?? 16;
	}

	public AdlLexer()
	{
	}

	public AdlLexer(ICharStream input)
		: this(input, new RecognizerSharedState())
	{
	}

	public AdlLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state)
	{
	}

	[GrammarRule("VARIABLE")]
	private void mVARIABLE()
	{
		try
		{
			int type = 38;
			int channel = 0;
			Match("{$");
			try
			{
				while (true)
				{
					int num = 2;
					try
					{
						int num2 = input.LA(1);
						if ((num2 >= 0 && num2 <= 124) || (num2 >= 126 && num2 <= 65535))
						{
							num = 1;
						}
					}
					finally
					{
					}
					if (num != 1)
					{
						break;
					}
					input.Consume();
				}
			}
			finally
			{
			}
			Match(125);
			state.type = type;
			state.channel = channel;
		}
		finally
		{
		}
	}

	[GrammarRule("GLOBALVARIABLE")]
	private void mGLOBALVARIABLE()
	{
		try
		{
			int type = 13;
			int channel = 0;
			Match("{#");
			try
			{
				while (true)
				{
					int num = 2;
					try
					{
						int num2 = input.LA(1);
						if ((num2 >= 0 && num2 <= 124) || (num2 >= 126 && num2 <= 65535))
						{
							num = 1;
						}
					}
					finally
					{
					}
					if (num != 1)
					{
						break;
					}
					input.Consume();
				}
			}
			finally
			{
			}
			Match(125);
			state.type = type;
			state.channel = channel;
		}
		finally
		{
		}
	}

	[GrammarRule("PROG_START")]
	private void mPROG_START()
	{
		try
		{
			int type = 33;
			int channel = 0;
			Match(123);
			IsProgramMode = true;
			state.type = type;
			state.channel = channel;
		}
		finally
		{
		}
	}

	[GrammarRule("PROG_END")]
	private void mPROG_END()
	{
		try
		{
			int type = 32;
			int channel = 0;
			if (!IsProgramMode)
			{
				throw new FailedPredicateException(input, "PROG_END", " IsProgramMode ");
			}
			Match(125);
			IsProgramMode = false;
			state.type = type;
			state.channel = channel;
		}
		finally
		{
		}
	}

	[GrammarRule("PLUS")]
	private void mPLUS()
	{
		try
		{
			int type = 31;
			int channel = 0;
			if (!IsProgramMode)
			{
				throw new FailedPredicateException(input, "PLUS", " IsProgramMode ");
			}
			Match(43);
			state.type = type;
			state.channel = channel;
		}
		finally
		{
		}
	}

	[GrammarRule("MINUS")]
	private void mMINUS()
	{
		try
		{
			int type = 24;
			int channel = 0;
			if (!IsProgramMode)
			{
				throw new FailedPredicateException(input, "MINUS", " IsProgramMode ");
			}
			Match(45);
			state.type = type;
			state.channel = channel;
		}
		finally
		{
		}
	}

	[GrammarRule("MULT")]
	private void mMULT()
	{
		try
		{
			int type = 25;
			int channel = 0;
			if (!IsProgramMode)
			{
				throw new FailedPredicateException(input, "MULT", " IsProgramMode ");
			}
			Match(42);
			state.type = type;
			state.channel = channel;
		}
		finally
		{
		}
	}

	[GrammarRule("DIVISION")]
	private void mDIVISION()
	{
		try
		{
			int type = 7;
			int channel = 0;
			if (!IsProgramMode)
			{
				throw new FailedPredicateException(input, "DIVISION", " IsProgramMode ");
			}
			Match(47);
			state.type = type;
			state.channel = channel;
		}
		finally
		{
		}
	}

	[GrammarRule("EQUAL")]
	private void mEQUAL()
	{
		try
		{
			int type = 10;
			int channel = 0;
			if (!IsProgramMode)
			{
				throw new FailedPredicateException(input, "EQUAL", " IsProgramMode ");
			}
			Match(61);
			state.type = type;
			state.channel = channel;
		}
		finally
		{
		}
	}

	[GrammarRule("NEQUAL")]
	private void mNEQUAL()
	{
		try
		{
			int type = 26;
			int channel = 0;
			if (!IsProgramMode)
			{
				throw new FailedPredicateException(input, "NEQUAL", " IsProgramMode ");
			}
			int num = 2;
			try
			{
				try
				{
					num = input.LA(1) switch
					{
						60 => 1, 
						38 => 2, 
						_ => throw new NoViableAltException("", 3, 0, input), 
					};
				}
				finally
				{
				}
				switch (num)
				{
				case 1:
					Match(60);
					break;
				case 2:
					Match("&lt;");
					break;
				}
			}
			finally
			{
			}
			int num2 = 2;
			try
			{
				try
				{
					num2 = input.LA(1) switch
					{
						62 => 1, 
						38 => 2, 
						_ => throw new NoViableAltException("", 4, 0, input), 
					};
				}
				finally
				{
				}
				switch (num2)
				{
				case 1:
					Match(62);
					break;
				case 2:
					Match("&gt;");
					break;
				}
			}
			finally
			{
			}
			state.type = type;
			state.channel = channel;
		}
		finally
		{
		}
	}

	[GrammarRule("GE")]
	private void mGE()
	{
		try
		{
			int type = 12;
			int channel = 0;
			if (!IsProgramMode)
			{
				throw new FailedPredicateException(input, "GE", " IsProgramMode ");
			}
			int num = 2;
			try
			{
				try
				{
					num = input.LA(1) switch
					{
						62 => 1, 
						38 => 2, 
						_ => throw new NoViableAltException("", 5, 0, input), 
					};
				}
				finally
				{
				}
				switch (num)
				{
				case 1:
					Match(62);
					break;
				case 2:
					Match("&gt;");
					break;
				}
			}
			finally
			{
			}
			Match(61);
			state.type = type;
			state.channel = channel;
		}
		finally
		{
		}
	}

	[GrammarRule("GT")]
	private void mGT()
	{
		try
		{
			int type = 14;
			int channel = 0;
			if (!IsProgramMode)
			{
				throw new FailedPredicateException(input, "GT", " IsProgramMode ");
			}
			int num = 2;
			try
			{
				try
				{
					num = input.LA(1) switch
					{
						62 => 1, 
						38 => 2, 
						_ => throw new NoViableAltException("", 6, 0, input), 
					};
				}
				finally
				{
				}
				switch (num)
				{
				case 1:
					Match(62);
					break;
				case 2:
					Match("&gt;");
					break;
				}
			}
			finally
			{
			}
			state.type = type;
			state.channel = channel;
		}
		finally
		{
		}
	}

	[GrammarRule("LE")]
	private void mLE()
	{
		try
		{
			int type = 20;
			int channel = 0;
			if (!IsProgramMode)
			{
				throw new FailedPredicateException(input, "LE", " IsProgramMode ");
			}
			int num = 2;
			try
			{
				try
				{
					num = input.LA(1) switch
					{
						60 => 1, 
						38 => 2, 
						_ => throw new NoViableAltException("", 7, 0, input), 
					};
				}
				finally
				{
				}
				switch (num)
				{
				case 1:
					Match(60);
					break;
				case 2:
					Match("&lt;");
					break;
				}
			}
			finally
			{
			}
			Match(61);
			state.type = type;
			state.channel = channel;
		}
		finally
		{
		}
	}

	[GrammarRule("LT")]
	private void mLT()
	{
		try
		{
			int type = 22;
			int channel = 0;
			if (!IsProgramMode)
			{
				throw new FailedPredicateException(input, "LT", " IsProgramMode ");
			}
			int num = 2;
			try
			{
				try
				{
					num = input.LA(1) switch
					{
						60 => 1, 
						38 => 2, 
						_ => throw new NoViableAltException("", 8, 0, input), 
					};
				}
				finally
				{
				}
				switch (num)
				{
				case 1:
					Match(60);
					break;
				case 2:
					Match("&lt;");
					break;
				}
			}
			finally
			{
			}
			state.type = type;
			state.channel = channel;
		}
		finally
		{
		}
	}

	[GrammarRule("SEMICOLON")]
	private void mSEMICOLON()
	{
		try
		{
			int type = 35;
			int channel = 0;
			if (!IsProgramMode)
			{
				throw new FailedPredicateException(input, "SEMICOLON", " IsProgramMode ");
			}
			Match(59);
			state.type = type;
			state.channel = channel;
		}
		finally
		{
		}
	}

	[GrammarRule("LPAREN")]
	private void mLPAREN()
	{
		try
		{
			int type = 21;
			int channel = 0;
			if (!IsProgramMode)
			{
				throw new FailedPredicateException(input, "LPAREN", " IsProgramMode ");
			}
			Match(40);
			state.type = type;
			state.channel = channel;
		}
		finally
		{
		}
	}

	[GrammarRule("RPAREN")]
	private void mRPAREN()
	{
		try
		{
			int type = 34;
			int channel = 0;
			if (!IsProgramMode)
			{
				throw new FailedPredicateException(input, "RPAREN", " IsProgramMode ");
			}
			Match(41);
			state.type = type;
			state.channel = channel;
		}
		finally
		{
		}
	}

	[GrammarRule("CHARACTER_STRING")]
	private void mCHARACTER_STRING()
	{
		try
		{
			int type = 6;
			int channel = 0;
			if (!IsProgramMode)
			{
				throw new FailedPredicateException(input, "CHARACTER_STRING", " IsProgramMode ");
			}
			input.Consume();
			try
			{
				while (true)
				{
					int num = 5;
					try
					{
						int num2 = input.LA(1);
						switch (num2)
						{
						case 39:
							if (input.LA(2) == 39)
							{
								num = 1;
							}
							goto end_IL_0032;
						case 8216:
							if (input.LA(2) == 8216)
							{
								num = 2;
							}
							goto end_IL_0032;
						case 8217:
							if (input.LA(2) == 8217)
							{
								num = 3;
							}
							goto end_IL_0032;
						default:
							if ((num2 >= 40 && num2 <= 8215) || (num2 >= 8218 && num2 <= 65535))
							{
								break;
							}
							goto end_IL_0032;
						case 0:
						case 1:
						case 2:
						case 3:
						case 4:
						case 5:
						case 6:
						case 7:
						case 8:
						case 9:
						case 10:
						case 11:
						case 12:
						case 13:
						case 14:
						case 15:
						case 16:
						case 17:
						case 18:
						case 19:
						case 20:
						case 21:
						case 22:
						case 23:
						case 24:
						case 25:
						case 26:
						case 27:
						case 28:
						case 29:
						case 30:
						case 31:
						case 32:
						case 33:
						case 34:
						case 35:
						case 36:
						case 37:
						case 38:
							break;
						}
						num = 4;
						end_IL_0032:;
					}
					finally
					{
					}
					switch (num)
					{
					case 1:
						Match("''");
						continue;
					case 2:
						Match("‘‘");
						continue;
					case 3:
						Match("’’");
						continue;
					case 4:
						input.Consume();
						continue;
					}
					break;
				}
			}
			finally
			{
			}
			input.Consume();
			state.type = type;
			state.channel = channel;
		}
		finally
		{
		}
	}

	[GrammarRule("NUMBER")]
	private void mNUMBER()
	{
		try
		{
			int type = 28;
			int channel = 0;
			if (!IsProgramMode)
			{
				throw new FailedPredicateException(input, "NUMBER", " IsProgramMode ");
			}
			int num = 0;
			try
			{
				while (true)
				{
					int num2 = 2;
					try
					{
						int num3 = input.LA(1);
						if (num3 >= 48 && num3 <= 57)
						{
							num2 = 1;
						}
					}
					finally
					{
					}
					if (num2 != 1)
					{
						break;
					}
					input.Consume();
					num++;
				}
				if (num < 1)
				{
					throw new EarlyExitException(10, input);
				}
			}
			finally
			{
			}
			int num4 = 2;
			try
			{
				try
				{
					int num5 = input.LA(1);
					if (num5 == 44 || num5 == 46)
					{
						num4 = 1;
					}
				}
				finally
				{
				}
				if (num4 == 1)
				{
					input.Consume();
					int num6 = 0;
					try
					{
						while (true)
						{
							int num7 = 2;
							try
							{
								int num8 = input.LA(1);
								if (num8 >= 48 && num8 <= 57)
								{
									num7 = 1;
								}
							}
							finally
							{
							}
							if (num7 != 1)
							{
								break;
							}
							input.Consume();
							num6++;
						}
						if (num6 < 1)
						{
							throw new EarlyExitException(11, input);
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
			state.type = type;
			state.channel = channel;
		}
		finally
		{
		}
	}

	[GrammarRule("IDENTIFIER")]
	private void mIDENTIFIER()
	{
		try
		{
			int num = 16;
			int channel = 0;
			if (!IsProgramMode)
			{
				throw new FailedPredicateException(input, "IDENTIFIER", " IsProgramMode ");
			}
			mLetter();
			try
			{
				while (true)
				{
					int num2 = 2;
					try
					{
						int num3 = input.LA(1);
						switch (num3)
						{
						default:
							if (num3 >= 65 && num3 <= 90)
							{
								break;
							}
							switch (num3)
							{
							default:
								if ((num3 >= 192 && num3 <= 214) || (num3 >= 216 && num3 <= 246) || (num3 >= 248 && num3 <= 8191) || (num3 >= 12352 && num3 <= 12687) || (num3 >= 13056 && num3 <= 13183) || (num3 >= 13312 && num3 <= 15661) || (num3 >= 19968 && num3 <= 40959) || (num3 >= 63744 && num3 <= 64255))
								{
									break;
								}
								goto end_IL_002e;
							case 95:
							case 97:
							case 98:
							case 99:
							case 100:
							case 101:
							case 102:
							case 103:
							case 104:
							case 105:
							case 106:
							case 107:
							case 108:
							case 109:
							case 110:
							case 111:
							case 112:
							case 113:
							case 114:
							case 115:
							case 116:
							case 117:
							case 118:
							case 119:
							case 120:
							case 121:
							case 122:
								break;
							}
							break;
						case 36:
						case 48:
						case 49:
						case 50:
						case 51:
						case 52:
						case 53:
						case 54:
						case 55:
						case 56:
						case 57:
							break;
						}
						num2 = 1;
						end_IL_002e:;
					}
					finally
					{
					}
					if (num2 != 1)
					{
						break;
					}
					input.Consume();
				}
			}
			finally
			{
			}
			num = CheckKeyword(base.Text);
			state.type = num;
			state.channel = channel;
		}
		finally
		{
		}
	}

	[GrammarRule("WS")]
	private void mWS()
	{
		try
		{
			int type = 39;
			int num = 0;
			if (!IsProgramMode)
			{
				throw new FailedPredicateException(input, "WS", " IsProgramMode ");
			}
			if ((input.LA(1) >= 9 && input.LA(1) <= 10) || input.LA(1) == 13 || input.LA(1) == 32)
			{
				input.Consume();
				num = 99;
				state.type = type;
				state.channel = num;
				return;
			}
			MismatchedSetException ex = new MismatchedSetException(null, input);
			Recover(ex);
			throw ex;
		}
		finally
		{
		}
	}

	[GrammarRule("Letter")]
	private void mLetter()
	{
		try
		{
			if (input.LA(1) == 36 || (input.LA(1) >= 65 && input.LA(1) <= 90) || input.LA(1) == 95 || (input.LA(1) >= 97 && input.LA(1) <= 122) || (input.LA(1) >= 192 && input.LA(1) <= 214) || (input.LA(1) >= 216 && input.LA(1) <= 246) || (input.LA(1) >= 248 && input.LA(1) <= 8191) || (input.LA(1) >= 12352 && input.LA(1) <= 12687) || (input.LA(1) >= 13056 && input.LA(1) <= 13183) || (input.LA(1) >= 13312 && input.LA(1) <= 15661) || (input.LA(1) >= 19968 && input.LA(1) <= 40959) || (input.LA(1) >= 63744 && input.LA(1) <= 64255))
			{
				input.Consume();
				return;
			}
			MismatchedSetException ex = new MismatchedSetException(null, input);
			Recover(ex);
			throw ex;
		}
		finally
		{
		}
	}

	[GrammarRule("IDDigit")]
	private void mIDDigit()
	{
		try
		{
			if ((input.LA(1) >= 48 && input.LA(1) <= 57) || (input.LA(1) >= 1632 && input.LA(1) <= 1641) || (input.LA(1) >= 1776 && input.LA(1) <= 1785) || (input.LA(1) >= 2406 && input.LA(1) <= 2415) || (input.LA(1) >= 2534 && input.LA(1) <= 2543) || (input.LA(1) >= 2662 && input.LA(1) <= 2671) || (input.LA(1) >= 2790 && input.LA(1) <= 2799) || (input.LA(1) >= 2918 && input.LA(1) <= 2927) || (input.LA(1) >= 3047 && input.LA(1) <= 3055) || (input.LA(1) >= 3174 && input.LA(1) <= 3183) || (input.LA(1) >= 3302 && input.LA(1) <= 3311) || (input.LA(1) >= 3430 && input.LA(1) <= 3439) || (input.LA(1) >= 3664 && input.LA(1) <= 3673) || (input.LA(1) >= 3792 && input.LA(1) <= 3801) || (input.LA(1) >= 4160 && input.LA(1) <= 4169))
			{
				input.Consume();
				return;
			}
			MismatchedSetException ex = new MismatchedSetException(null, input);
			Recover(ex);
			throw ex;
		}
		finally
		{
		}
	}

	[GrammarRule("PLAINTEXT")]
	private void mPLAINTEXT()
	{
		try
		{
			int type = 30;
			int channel = 0;
			if (IsProgramMode)
			{
				throw new FailedPredicateException(input, "PLAINTEXT", " !IsProgramMode ");
			}
			try
			{
				while (true)
				{
					int num = 2;
					try
					{
						int num2 = input.LA(1);
						if ((num2 >= 0 && num2 <= 122) || (num2 >= 124 && num2 <= 65535))
						{
							num = 1;
						}
					}
					finally
					{
					}
					if (num != 1)
					{
						break;
					}
					input.Consume();
				}
			}
			finally
			{
			}
			state.type = type;
			state.channel = channel;
		}
		finally
		{
		}
	}

	public override void mTokens()
	{
		int num = 22;
		try
		{
			num = dfa15.Predict(input);
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
			mVARIABLE();
			break;
		case 2:
			mGLOBALVARIABLE();
			break;
		case 3:
			mPROG_START();
			break;
		case 4:
			mPROG_END();
			break;
		case 5:
			mPLUS();
			break;
		case 6:
			mMINUS();
			break;
		case 7:
			mMULT();
			break;
		case 8:
			mDIVISION();
			break;
		case 9:
			mEQUAL();
			break;
		case 10:
			mNEQUAL();
			break;
		case 11:
			mGE();
			break;
		case 12:
			mGT();
			break;
		case 13:
			mLE();
			break;
		case 14:
			mLT();
			break;
		case 15:
			mSEMICOLON();
			break;
		case 16:
			mLPAREN();
			break;
		case 17:
			mRPAREN();
			break;
		case 18:
			mCHARACTER_STRING();
			break;
		case 19:
			mNUMBER();
			break;
		case 20:
			mIDENTIFIER();
			break;
		case 21:
			mWS();
			break;
		case 22:
			mPLAINTEXT();
			break;
		}
	}

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa15 = new DFA15(this, SpecialStateTransition15);
	}

	private int SpecialStateTransition15(DFA dfa, int s, IIntStream _input)
	{
		int stateNumber = s;
		switch (s)
		{
		case 0:
		{
			int num2 = _input.LA(1);
			int index6 = _input.Index;
			_input.Rewind();
			s = -1;
			s = ((num2 == 123) ? 1 : ((num2 == 125 && (IsProgramMode || !IsProgramMode)) ? 2 : ((num2 == 43 && (IsProgramMode || !IsProgramMode)) ? 3 : ((num2 == 45 && (IsProgramMode || !IsProgramMode)) ? 4 : ((num2 == 42 && (IsProgramMode || !IsProgramMode)) ? 5 : ((num2 == 47 && (IsProgramMode || !IsProgramMode)) ? 6 : ((num2 == 61 && (IsProgramMode || !IsProgramMode)) ? 7 : ((num2 == 60 && (IsProgramMode || !IsProgramMode)) ? 8 : ((num2 == 38 && (IsProgramMode || !IsProgramMode)) ? 9 : ((num2 == 62 && (IsProgramMode || !IsProgramMode)) ? 10 : ((num2 == 59 && (IsProgramMode || !IsProgramMode)) ? 11 : ((num2 == 40 && (IsProgramMode || !IsProgramMode)) ? 12 : ((num2 == 41 && (IsProgramMode || !IsProgramMode)) ? 13 : (((num2 == 39 || (num2 >= 8216 && num2 <= 8217)) && (IsProgramMode || !IsProgramMode)) ? 14 : ((num2 >= 48 && num2 <= 57 && (IsProgramMode || !IsProgramMode)) ? 15 : (((num2 == 36 || (num2 >= 65 && num2 <= 90) || num2 == 95 || (num2 >= 97 && num2 <= 122) || (num2 >= 192 && num2 <= 214) || (num2 >= 216 && num2 <= 246) || (num2 >= 248 && num2 <= 8191) || (num2 >= 12352 && num2 <= 12687) || (num2 >= 13056 && num2 <= 13183) || (num2 >= 13312 && num2 <= 15661) || (num2 >= 19968 && num2 <= 40959) || (num2 >= 63744 && num2 <= 64255)) && (IsProgramMode || !IsProgramMode)) ? 16 : ((((num2 < 9 || num2 > 10) && num2 != 13 && num2 != 32) || (!IsProgramMode && IsProgramMode)) ? 18 : 17)))))))))))))))));
			_input.Seek(index6);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 1:
		{
			int num24 = _input.LA(1);
			int index34 = _input.Index;
			_input.Rewind();
			s = -1;
			s = ((((num24 < 0 || num24 > 122) && (num24 < 124 || num24 > 65535)) || IsProgramMode) ? 22 : 18);
			_input.Seek(index34);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 2:
		{
			int num19 = _input.LA(1);
			int index28 = _input.Index;
			_input.Rewind();
			s = -1;
			s = ((((num19 < 0 || num19 > 122) && (num19 < 124 || num19 > 65535)) || IsProgramMode) ? 23 : 18);
			_input.Seek(index28);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 3:
		{
			int num35 = _input.LA(1);
			int index47 = _input.Index;
			_input.Rewind();
			s = -1;
			s = ((((num35 < 0 || num35 > 122) && (num35 < 124 || num35 > 65535)) || IsProgramMode) ? 24 : 18);
			_input.Seek(index47);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 4:
		{
			int num39 = _input.LA(1);
			int index53 = _input.Index;
			_input.Rewind();
			s = -1;
			s = ((((num39 < 0 || num39 > 122) && (num39 < 124 || num39 > 65535)) || IsProgramMode) ? 25 : 18);
			_input.Seek(index53);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 5:
		{
			int num25 = _input.LA(1);
			int index35 = _input.Index;
			_input.Rewind();
			s = -1;
			s = ((((num25 < 0 || num25 > 122) && (num25 < 124 || num25 > 65535)) || IsProgramMode) ? 26 : 18);
			_input.Seek(index35);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 6:
		{
			int num42 = _input.LA(1);
			int index59 = _input.Index;
			_input.Rewind();
			s = -1;
			s = ((((num42 < 0 || num42 > 122) && (num42 < 124 || num42 > 65535)) || IsProgramMode) ? 27 : 18);
			_input.Seek(index59);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 7:
		{
			int num21 = _input.LA(1);
			int index31 = _input.Index;
			_input.Rewind();
			s = -1;
			s = ((num21 == 62 && (IsProgramMode || !IsProgramMode)) ? 28 : ((num21 == 38 && (IsProgramMode || !IsProgramMode)) ? 29 : ((num21 == 61 && (IsProgramMode || !IsProgramMode)) ? 30 : ((((num21 < 0 || num21 > 37) && (num21 < 39 || num21 > 60) && (num21 < 63 || num21 > 122) && (num21 < 124 || num21 > 65535)) || IsProgramMode) ? 31 : 18))));
			_input.Seek(index31);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 8:
		{
			int num26 = _input.LA(1);
			int index36 = _input.Index;
			_input.Rewind();
			s = -1;
			s = ((num26 == 108 && (IsProgramMode || !IsProgramMode)) ? 32 : ((num26 != 103 || (!IsProgramMode && IsProgramMode)) ? 18 : 33));
			_input.Seek(index36);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 9:
		{
			int num30 = _input.LA(1);
			int index40 = _input.Index;
			_input.Rewind();
			s = -1;
			s = ((num30 == 61 && (IsProgramMode || !IsProgramMode)) ? 34 : ((((num30 < 0 || num30 > 60) && (num30 < 62 || num30 > 122) && (num30 < 124 || num30 > 65535)) || IsProgramMode) ? 35 : 18));
			_input.Seek(index40);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 10:
		{
			int num27 = _input.LA(1);
			int index37 = _input.Index;
			_input.Rewind();
			s = -1;
			s = ((((num27 < 0 || num27 > 122) && (num27 < 124 || num27 > 65535)) || IsProgramMode) ? 36 : 18);
			_input.Seek(index37);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 11:
		{
			int num15 = _input.LA(1);
			int index24 = _input.Index;
			_input.Rewind();
			s = -1;
			s = ((((num15 < 0 || num15 > 122) && (num15 < 124 || num15 > 65535)) || IsProgramMode) ? 37 : 18);
			_input.Seek(index24);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 12:
		{
			int num14 = _input.LA(1);
			int index23 = _input.Index;
			_input.Rewind();
			s = -1;
			s = ((((num14 < 0 || num14 > 122) && (num14 < 124 || num14 > 65535)) || IsProgramMode) ? 38 : 18);
			_input.Seek(index23);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 13:
		{
			int num29 = _input.LA(1);
			int index39 = _input.Index;
			_input.Rewind();
			s = -1;
			s = ((num29 == 39 && (IsProgramMode || !IsProgramMode)) ? 39 : ((num29 == 8216 && (IsProgramMode || !IsProgramMode)) ? 40 : ((num29 == 8217 && (IsProgramMode || !IsProgramMode)) ? 41 : ((((num29 >= 0 && num29 <= 38) || (num29 >= 40 && num29 <= 122) || (num29 >= 124 && num29 <= 8215) || (num29 >= 8218 && num29 <= 65535)) && (IsProgramMode || !IsProgramMode)) ? 42 : ((num29 != 123 || !IsProgramMode) ? 18 : 43)))));
			_input.Seek(index39);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 14:
		{
			int num38 = _input.LA(1);
			int index52 = _input.Index;
			_input.Rewind();
			s = -1;
			s = (((num38 == 44 || num38 == 46) && (IsProgramMode || !IsProgramMode)) ? 44 : ((num38 >= 48 && num38 <= 57 && (IsProgramMode || !IsProgramMode)) ? 15 : ((((num38 < 0 || num38 > 43) && num38 != 45 && num38 != 47 && (num38 < 58 || num38 > 122) && (num38 < 124 || num38 > 65535)) || IsProgramMode) ? 45 : 18)));
			_input.Seek(index52);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 15:
		{
			int num13 = _input.LA(1);
			int index22 = _input.Index;
			_input.Rewind();
			s = -1;
			s = (((num13 == 36 || (num13 >= 48 && num13 <= 57) || (num13 >= 65 && num13 <= 90) || num13 == 95 || (num13 >= 97 && num13 <= 122) || (num13 >= 192 && num13 <= 214) || (num13 >= 216 && num13 <= 246) || (num13 >= 248 && num13 <= 8191) || (num13 >= 12352 && num13 <= 12687) || (num13 >= 13056 && num13 <= 13183) || (num13 >= 13312 && num13 <= 15661) || (num13 >= 19968 && num13 <= 40959) || (num13 >= 63744 && num13 <= 64255)) && (IsProgramMode || !IsProgramMode)) ? 47 : ((((num13 < 0 || num13 > 35) && (num13 < 37 || num13 > 47) && (num13 < 58 || num13 > 64) && (num13 < 91 || num13 > 94) && num13 != 96 && (num13 < 124 || num13 > 191) && num13 != 215 && num13 != 247 && (num13 < 8192 || num13 > 12351) && (num13 < 12688 || num13 > 13055) && (num13 < 13184 || num13 > 13311) && (num13 < 15662 || num13 > 19967) && (num13 < 40960 || num13 > 63743) && (num13 < 64256 || num13 > 65535)) || IsProgramMode) ? 46 : 18));
			_input.Seek(index22);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 16:
		{
			int num40 = _input.LA(1);
			int index54 = _input.Index;
			_input.Rewind();
			s = -1;
			s = ((((num40 < 0 || num40 > 122) && (num40 < 124 || num40 > 65535)) || IsProgramMode) ? 48 : 18);
			_input.Seek(index54);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 17:
		{
			_input.LA(1);
			int index29 = _input.Index;
			_input.Rewind();
			s = -1;
			if (IsProgramMode)
			{
				s = 49;
			}
			else if (!IsProgramMode)
			{
				s = 18;
			}
			_input.Seek(index29);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 18:
		{
			_input.LA(1);
			int index14 = _input.Index;
			_input.Rewind();
			s = -1;
			if (IsProgramMode)
			{
				s = 50;
			}
			else if (!IsProgramMode)
			{
				s = 18;
			}
			_input.Seek(index14);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 19:
		{
			_input.LA(1);
			int index49 = _input.Index;
			_input.Rewind();
			s = -1;
			if (IsProgramMode)
			{
				s = 51;
			}
			else if (!IsProgramMode)
			{
				s = 18;
			}
			_input.Seek(index49);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 20:
		{
			_input.LA(1);
			int index12 = _input.Index;
			_input.Rewind();
			s = -1;
			if (IsProgramMode)
			{
				s = 52;
			}
			else if (!IsProgramMode)
			{
				s = 18;
			}
			_input.Seek(index12);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 21:
		{
			_input.LA(1);
			int index5 = _input.Index;
			_input.Rewind();
			s = -1;
			if (IsProgramMode)
			{
				s = 53;
			}
			else if (!IsProgramMode)
			{
				s = 18;
			}
			_input.Seek(index5);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 22:
		{
			_input.LA(1);
			int index3 = _input.Index;
			_input.Rewind();
			s = -1;
			if (IsProgramMode)
			{
				s = 54;
			}
			else if (!IsProgramMode)
			{
				s = 18;
			}
			_input.Seek(index3);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 23:
		{
			int num3 = _input.LA(1);
			int index7 = _input.Index;
			_input.Rewind();
			s = -1;
			s = ((((num3 < 0 || num3 > 122) && (num3 < 124 || num3 > 65535)) || IsProgramMode) ? 55 : 18);
			_input.Seek(index7);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 24:
		{
			int num34 = _input.LA(1);
			int index45 = _input.Index;
			_input.Rewind();
			s = -1;
			s = ((num34 != 103 || (!IsProgramMode && IsProgramMode)) ? 18 : 56);
			_input.Seek(index45);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 25:
		{
			int num11 = _input.LA(1);
			int index20 = _input.Index;
			_input.Rewind();
			s = -1;
			s = ((((num11 < 0 || num11 > 122) && (num11 < 124 || num11 > 65535)) || IsProgramMode) ? 57 : 18);
			_input.Seek(index20);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 26:
		{
			_input.LA(1);
			int index55 = _input.Index;
			_input.Rewind();
			s = -1;
			if (IsProgramMode)
			{
				s = 58;
			}
			else if (!IsProgramMode)
			{
				s = 18;
			}
			_input.Seek(index55);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 27:
		{
			int num28 = _input.LA(1);
			int index38 = _input.Index;
			_input.Rewind();
			s = -1;
			s = ((num28 != 116 || (!IsProgramMode && IsProgramMode)) ? 18 : 59);
			_input.Seek(index38);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 28:
		{
			int num8 = _input.LA(1);
			int index17 = _input.Index;
			_input.Rewind();
			s = -1;
			s = ((num8 != 116 || (!IsProgramMode && IsProgramMode)) ? 18 : 60);
			_input.Seek(index17);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 29:
		{
			int num7 = _input.LA(1);
			int index16 = _input.Index;
			_input.Rewind();
			s = -1;
			s = ((((num7 < 0 || num7 > 122) && (num7 < 124 || num7 > 65535)) || IsProgramMode) ? 61 : 18);
			_input.Seek(index16);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 30:
		{
			_input.LA(1);
			int index46 = _input.Index;
			_input.Rewind();
			s = -1;
			if (IsProgramMode)
			{
				s = 62;
			}
			else if (!IsProgramMode)
			{
				s = 18;
			}
			_input.Seek(index46);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 31:
		{
			_input.LA(1);
			int index11 = _input.Index;
			_input.Rewind();
			s = -1;
			if (IsProgramMode)
			{
				s = 63;
			}
			else if (!IsProgramMode)
			{
				s = 18;
			}
			_input.Seek(index11);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 32:
		{
			_input.LA(1);
			int index51 = _input.Index;
			_input.Rewind();
			s = -1;
			if (IsProgramMode)
			{
				s = 64;
			}
			else if (!IsProgramMode)
			{
				s = 18;
			}
			_input.Seek(index51);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 33:
		{
			_input.LA(1);
			int index56 = _input.Index;
			_input.Rewind();
			s = -1;
			if (IsProgramMode)
			{
				s = 65;
			}
			else if (!IsProgramMode)
			{
				s = 18;
			}
			_input.Seek(index56);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 34:
		{
			int num33 = _input.LA(1);
			int index44 = _input.Index;
			_input.Rewind();
			s = -1;
			s = ((num33 == 39 && (IsProgramMode || !IsProgramMode)) ? 66 : ((((num33 < 0 || num33 > 38) && (num33 < 40 || num33 > 122) && (num33 < 124 || num33 > 65535)) || IsProgramMode) ? 67 : 18));
			_input.Seek(index44);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 35:
		{
			int num22 = _input.LA(1);
			int index32 = _input.Index;
			_input.Rewind();
			s = -1;
			s = ((num22 == 8216 && (IsProgramMode || !IsProgramMode)) ? 68 : ((((num22 < 0 || num22 > 122) && (num22 < 124 || num22 > 8215) && (num22 < 8217 || num22 > 65535)) || IsProgramMode) ? 67 : 18));
			_input.Seek(index32);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 36:
		{
			int num10 = _input.LA(1);
			int index19 = _input.Index;
			_input.Rewind();
			s = -1;
			s = ((num10 == 8217 && (IsProgramMode || !IsProgramMode)) ? 69 : ((((num10 < 0 || num10 > 122) && (num10 < 124 || num10 > 8216) && (num10 < 8218 || num10 > 65535)) || IsProgramMode) ? 67 : 18));
			_input.Seek(index19);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 37:
		{
			int num12 = _input.LA(1);
			int index21 = _input.Index;
			_input.Rewind();
			s = -1;
			s = ((num12 == 39 && (IsProgramMode || !IsProgramMode)) ? 70 : ((num12 == 8216 && (IsProgramMode || !IsProgramMode)) ? 71 : ((num12 == 8217 && (IsProgramMode || !IsProgramMode)) ? 72 : ((((num12 >= 0 && num12 <= 38) || (num12 >= 40 && num12 <= 122) || (num12 >= 124 && num12 <= 8215) || (num12 >= 8218 && num12 <= 65535)) && (IsProgramMode || !IsProgramMode)) ? 42 : ((num12 != 123 || !IsProgramMode) ? 18 : 43)))));
			_input.Seek(index21);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 38:
		{
			int num36 = _input.LA(1);
			int index48 = _input.Index;
			_input.Rewind();
			s = -1;
			s = ((num36 < 48 || num36 > 57 || (!IsProgramMode && IsProgramMode)) ? 18 : 73);
			_input.Seek(index48);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 39:
		{
			_input.LA(1);
			int index2 = _input.Index;
			_input.Rewind();
			s = -1;
			if (IsProgramMode)
			{
				s = 74;
			}
			else if (!IsProgramMode)
			{
				s = 18;
			}
			_input.Seek(index2);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 40:
		{
			_input.LA(1);
			int index60 = _input.Index;
			_input.Rewind();
			s = -1;
			if (IsProgramMode)
			{
				s = 75;
			}
			else if (!IsProgramMode)
			{
				s = 18;
			}
			_input.Seek(index60);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 41:
		{
			int num31 = _input.LA(1);
			int index42 = _input.Index;
			_input.Rewind();
			s = -1;
			s = (((num31 == 36 || (num31 >= 48 && num31 <= 57) || (num31 >= 65 && num31 <= 90) || num31 == 95 || (num31 >= 97 && num31 <= 122) || (num31 >= 192 && num31 <= 214) || (num31 >= 216 && num31 <= 246) || (num31 >= 248 && num31 <= 8191) || (num31 >= 12352 && num31 <= 12687) || (num31 >= 13056 && num31 <= 13183) || (num31 >= 13312 && num31 <= 15661) || (num31 >= 19968 && num31 <= 40959) || (num31 >= 63744 && num31 <= 64255)) && (IsProgramMode || !IsProgramMode)) ? 47 : ((((num31 < 0 || num31 > 35) && (num31 < 37 || num31 > 47) && (num31 < 58 || num31 > 64) && (num31 < 91 || num31 > 94) && num31 != 96 && (num31 < 124 || num31 > 191) && num31 != 215 && num31 != 247 && (num31 < 8192 || num31 > 12351) && (num31 < 12688 || num31 > 13055) && (num31 < 13184 || num31 > 13311) && (num31 < 15662 || num31 > 19967) && (num31 < 40960 || num31 > 63743) && (num31 < 64256 || num31 > 65535)) || IsProgramMode) ? 46 : 18));
			_input.Seek(index42);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 42:
		{
			_input.LA(1);
			int index41 = _input.Index;
			_input.Rewind();
			s = -1;
			if (IsProgramMode)
			{
				s = 76;
			}
			else if (!IsProgramMode)
			{
				s = 18;
			}
			_input.Seek(index41);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 43:
		{
			_input.LA(1);
			int index15 = _input.Index;
			_input.Rewind();
			s = -1;
			if (IsProgramMode)
			{
				s = 77;
			}
			else if (!IsProgramMode)
			{
				s = 18;
			}
			_input.Seek(index15);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 44:
		{
			int num9 = _input.LA(1);
			int index18 = _input.Index;
			_input.Rewind();
			s = -1;
			s = ((num9 != 116 || (!IsProgramMode && IsProgramMode)) ? 18 : 78);
			_input.Seek(index18);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 45:
		{
			_input.LA(1);
			int index9 = _input.Index;
			_input.Rewind();
			s = -1;
			if (IsProgramMode)
			{
				s = 79;
			}
			else if (!IsProgramMode)
			{
				s = 18;
			}
			_input.Seek(index9);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 46:
		{
			int num23 = _input.LA(1);
			int index33 = _input.Index;
			_input.Rewind();
			s = -1;
			s = ((num23 != 59 || (!IsProgramMode && IsProgramMode)) ? 18 : 80);
			_input.Seek(index33);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 47:
		{
			int num4 = _input.LA(1);
			int index8 = _input.Index;
			_input.Rewind();
			s = -1;
			s = ((num4 != 59 || (!IsProgramMode && IsProgramMode)) ? 18 : 81);
			_input.Seek(index8);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 48:
		{
			_input.LA(1);
			int index58 = _input.Index;
			_input.Rewind();
			s = -1;
			if (IsProgramMode)
			{
				s = 82;
			}
			else if (!IsProgramMode)
			{
				s = 18;
			}
			_input.Seek(index58);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 49:
		{
			int num17 = _input.LA(1);
			int index26 = _input.Index;
			_input.Rewind();
			s = -1;
			s = ((num17 == 39 && (IsProgramMode || !IsProgramMode)) ? 70 : ((num17 == 8216 && (IsProgramMode || !IsProgramMode)) ? 71 : ((num17 == 8217 && (IsProgramMode || !IsProgramMode)) ? 72 : ((((num17 >= 0 && num17 <= 38) || (num17 >= 40 && num17 <= 122) || (num17 >= 124 && num17 <= 8215) || (num17 >= 8218 && num17 <= 65535)) && (IsProgramMode || !IsProgramMode)) ? 42 : ((num17 != 123 || !IsProgramMode) ? 18 : 43)))));
			_input.Seek(index26);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 50:
		{
			_input.LA(1);
			int index4 = _input.Index;
			_input.Rewind();
			s = -1;
			if (IsProgramMode)
			{
				s = 43;
			}
			else if (!IsProgramMode)
			{
				s = 18;
			}
			_input.Seek(index4);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 51:
		{
			int num20 = _input.LA(1);
			int index30 = _input.Index;
			_input.Rewind();
			s = -1;
			s = ((num20 == 39 && (IsProgramMode || !IsProgramMode)) ? 70 : ((num20 == 8216 && (IsProgramMode || !IsProgramMode)) ? 71 : ((num20 == 8217 && (IsProgramMode || !IsProgramMode)) ? 72 : ((((num20 >= 0 && num20 <= 38) || (num20 >= 40 && num20 <= 122) || (num20 >= 124 && num20 <= 8215) || (num20 >= 8218 && num20 <= 65535)) && (IsProgramMode || !IsProgramMode)) ? 42 : ((num20 != 123 || !IsProgramMode) ? 18 : 43)))));
			_input.Seek(index30);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 52:
		{
			int num43 = _input.LA(1);
			int index61 = _input.Index;
			_input.Rewind();
			s = -1;
			s = ((num43 == 39 && (IsProgramMode || !IsProgramMode)) ? 70 : ((num43 == 8216 && (IsProgramMode || !IsProgramMode)) ? 71 : ((num43 == 8217 && (IsProgramMode || !IsProgramMode)) ? 72 : ((((num43 >= 0 && num43 <= 38) || (num43 >= 40 && num43 <= 122) || (num43 >= 124 && num43 <= 8215) || (num43 >= 8218 && num43 <= 65535)) && (IsProgramMode || !IsProgramMode)) ? 42 : ((num43 != 123 || !IsProgramMode) ? 18 : 43)))));
			_input.Seek(index61);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 53:
		{
			int num32 = _input.LA(1);
			int index43 = _input.Index;
			_input.Rewind();
			s = -1;
			s = ((num32 == 39 && (IsProgramMode || !IsProgramMode)) ? 66 : ((((num32 < 0 || num32 > 38) && (num32 < 40 || num32 > 122) && (num32 < 124 || num32 > 65535)) || IsProgramMode) ? 67 : 18));
			_input.Seek(index43);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 54:
		{
			int num18 = _input.LA(1);
			int index27 = _input.Index;
			_input.Rewind();
			s = -1;
			s = ((num18 == 8216 && (IsProgramMode || !IsProgramMode)) ? 68 : ((((num18 < 0 || num18 > 122) && (num18 < 124 || num18 > 8215) && (num18 < 8217 || num18 > 65535)) || IsProgramMode) ? 67 : 18));
			_input.Seek(index27);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 55:
		{
			int num6 = _input.LA(1);
			int index13 = _input.Index;
			_input.Rewind();
			s = -1;
			s = ((num6 == 8217 && (IsProgramMode || !IsProgramMode)) ? 69 : ((((num6 < 0 || num6 > 122) && (num6 < 124 || num6 > 8216) && (num6 < 8218 || num6 > 65535)) || IsProgramMode) ? 67 : 18));
			_input.Seek(index13);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 56:
		{
			int num41 = _input.LA(1);
			int index57 = _input.Index;
			_input.Rewind();
			s = -1;
			s = ((num41 >= 48 && num41 <= 57 && (IsProgramMode || !IsProgramMode)) ? 73 : ((((num41 < 0 || num41 > 47) && (num41 < 58 || num41 > 122) && (num41 < 124 || num41 > 65535)) || IsProgramMode) ? 45 : 18));
			_input.Seek(index57);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 57:
		{
			int num37 = _input.LA(1);
			int index50 = _input.Index;
			_input.Rewind();
			s = -1;
			s = ((num37 != 59 || (!IsProgramMode && IsProgramMode)) ? 18 : 83);
			_input.Seek(index50);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 58:
		{
			int num16 = _input.LA(1);
			int index25 = _input.Index;
			_input.Rewind();
			s = -1;
			s = ((num16 == 62 && (IsProgramMode || !IsProgramMode)) ? 28 : ((num16 == 38 && (IsProgramMode || !IsProgramMode)) ? 29 : ((num16 == 61 && (IsProgramMode || !IsProgramMode)) ? 30 : ((((num16 < 0 || num16 > 37) && (num16 < 39 || num16 > 60) && (num16 < 63 || num16 > 122) && (num16 < 124 || num16 > 65535)) || IsProgramMode) ? 31 : 18))));
			_input.Seek(index25);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 59:
		{
			int num5 = _input.LA(1);
			int index10 = _input.Index;
			_input.Rewind();
			s = -1;
			s = ((num5 == 61 && (IsProgramMode || !IsProgramMode)) ? 34 : ((((num5 < 0 || num5 > 60) && (num5 < 62 || num5 > 122) && (num5 < 124 || num5 > 65535)) || IsProgramMode) ? 35 : 18));
			_input.Seek(index10);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		case 60:
		{
			int num = _input.LA(1);
			int index = _input.Index;
			_input.Rewind();
			s = -1;
			s = ((((num < 0 || num > 122) && (num < 124 || num > 65535)) || IsProgramMode) ? 55 : 18);
			_input.Seek(index);
			if (s >= 0)
			{
				return s;
			}
			break;
		}
		}
		NoViableAltException ex = new NoViableAltException(dfa.Description, 15, stateNumber, _input);
		dfa.Error(ex);
		throw ex;
	}
}
