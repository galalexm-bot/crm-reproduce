using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace System.Linq.Dynamic;

internal class ExpressionParser
{
	private struct Token
	{
		public TokenId id;

		public string text;

		public int pos;
	}

	private enum TokenId
	{
		Unknown,
		End,
		Identifier,
		StringLiteral,
		IntegerLiteral,
		RealLiteral,
		Exclamation,
		Percent,
		Amphersand,
		OpenParen,
		CloseParen,
		Asterisk,
		Plus,
		Comma,
		Minus,
		Dot,
		Slash,
		Colon,
		LessThan,
		Equal,
		GreaterThan,
		Question,
		OpenBracket,
		CloseBracket,
		Bar,
		ExclamationEqual,
		DoubleAmphersand,
		LessThanEqual,
		LessGreater,
		DoubleEqual,
		GreaterThanEqual,
		DoubleBar
	}

	private interface ILogicalSignatures
	{
		void F(bool x, bool y);

		void F(bool? x, bool? y);
	}

	private interface IArithmeticSignatures
	{
		void F(int x, int y);

		void F(uint x, uint y);

		void F(long x, long y);

		void F(ulong x, ulong y);

		void F(float x, float y);

		void F(double x, double y);

		void F(decimal x, decimal y);

		void F(int? x, int? y);

		void F(uint? x, uint? y);

		void F(long? x, long? y);

		void F(ulong? x, ulong? y);

		void F(float? x, float? y);

		void F(double? x, double? y);

		void F(decimal? x, decimal? y);
	}

	private interface IRelationalSignatures : IArithmeticSignatures
	{
		void F(string x, string y);

		void F(char x, char y);

		void F(DateTime x, DateTime y);

		void F(TimeSpan x, TimeSpan y);

		void F(char? x, char? y);

		void F(DateTime? x, DateTime? y);

		void F(TimeSpan? x, TimeSpan? y);
	}

	private interface IEqualitySignatures : IRelationalSignatures, IArithmeticSignatures
	{
		void F(bool x, bool y);

		void F(bool? x, bool? y);
	}

	private interface IAddSignatures : IArithmeticSignatures
	{
		void F(DateTime x, TimeSpan y);

		void F(TimeSpan x, TimeSpan y);

		void F(DateTime? x, TimeSpan? y);

		void F(TimeSpan? x, TimeSpan? y);
	}

	private interface ISubtractSignatures : IAddSignatures, IArithmeticSignatures
	{
		void F(DateTime x, DateTime y);

		void F(DateTime? x, DateTime? y);
	}

	private interface INegationSignatures
	{
		void F(int x);

		void F(long x);

		void F(float x);

		void F(double x);

		void F(decimal x);

		void F(int? x);

		void F(long? x);

		void F(float? x);

		void F(double? x);

		void F(decimal? x);
	}

	private interface INotSignatures
	{
		void F(bool x);

		void F(bool? x);
	}

	private interface IEnumerableSignatures
	{
		void Where(bool predicate);

		void Any();

		void Any(bool predicate);

		void All(bool predicate);

		void Count();

		void Count(bool predicate);

		void Min(object selector);

		void Max(object selector);

		void Sum(int selector);

		void Sum(int? selector);

		void Sum(long selector);

		void Sum(long? selector);

		void Sum(float selector);

		void Sum(float? selector);

		void Sum(double selector);

		void Sum(double? selector);

		void Sum(decimal selector);

		void Sum(decimal? selector);

		void Average(int selector);

		void Average(int? selector);

		void Average(long selector);

		void Average(long? selector);

		void Average(float selector);

		void Average(float? selector);

		void Average(double selector);

		void Average(double? selector);

		void Average(decimal selector);

		void Average(decimal? selector);
	}

	private class MethodData
	{
		public object MethodBase;

		public object Parameters;

		public object Args;

		internal static object vH354Ef60VK6Cun3CJv4;

		public MethodData()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			kO9rJAf6M5IY4vMPdln3();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static void kO9rJAf6M5IY4vMPdln3()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool XKr7mQf6mhcFJaX8iCeg()
		{
			return vH354Ef60VK6Cun3CJv4 == null;
		}

		internal static MethodData mfGtN0f6yrNUigHi5BGh()
		{
			return (MethodData)vH354Ef60VK6Cun3CJv4;
		}
	}

	private static readonly Type[] predefinedTypes;

	private static readonly Expression trueLiteral;

	private static readonly Expression falseLiteral;

	private static readonly Expression nullLiteral;

	private static readonly string keywordIt;

	private static readonly string keywordIif;

	private static readonly string keywordNew;

	private static Dictionary<string, object> keywords;

	private Dictionary<string, object> symbols;

	private IDictionary<string, object> externals;

	private Dictionary<Expression, string> literals;

	private ParameterExpression it;

	private string text;

	private int textPos;

	private int textLen;

	private char ch;

	private Token token;

	private static ExpressionParser KQg2k3hpaS4cQRE91bw;

	public ExpressionParser(ParameterExpression[] parameters, string expression, object[] values)
	{
		//Discarded unreachable code: IL_001a, IL_0136, IL_01b2, IL_01c1
		geHS7ihtPfbwy00cPCo();
		base._002Ector();
		int num = 11;
		while (true)
		{
			switch (num)
			{
			case 14:
				textLen = OTruAxh6tuxUllMwkqV(text);
				num = 2;
				continue;
			case 7:
				ProcessParameters(parameters);
				num = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
				{
					num = 9;
				}
				continue;
			case 6:
				if (parameters != null)
				{
					num = 7;
					continue;
				}
				goto case 9;
			case 10:
				ProcessValues(values);
				num = 13;
				continue;
			case 15:
				return;
			default:
				text = expression;
				num = 14;
				continue;
			case 2:
				SetTextPos(0);
				num = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
				{
					num = 12;
				}
				continue;
			case 5:
				keywords = CreateKeywords();
				num = 3;
				continue;
			case 11:
				if (expression != null)
				{
					num = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
					{
						num = 4;
					}
					continue;
				}
				goto case 8;
			case 9:
				if (values == null)
				{
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
					{
						num = 0;
					}
					continue;
				}
				goto case 10;
			case 1:
			{
				literals = new Dictionary<Expression, string>();
				int num2 = 6;
				num = num2;
				continue;
			}
			case 8:
				throw new ArgumentNullException((string)TZcomMhwloVeNRf8kPa(-234299632 ^ -234302956));
			case 4:
				if (keywords == null)
				{
					num = 5;
					continue;
				}
				break;
			case 12:
				NextToken();
				num = 15;
				continue;
			case 3:
				break;
			}
			symbols = new Dictionary<string, object>((IEqualityComparer<string>)JRKKHbh4GhyZ7Jb1wLU());
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
			{
				num = 1;
			}
		}
	}

	private void ProcessParameters(ParameterExpression[] parameters)
	{
		//Discarded unreachable code: IL_00b5, IL_00c4, IL_0129
		int num = 4;
		int num2 = num;
		ParameterExpression parameterExpression = default(ParameterExpression);
		int num3 = default(int);
		ParameterExpression[] array = default(ParameterExpression[]);
		while (true)
		{
			switch (num2)
			{
			case 10:
				if (rM2lRjhH4jTAvWIdTPJ(DtptSGhAmSAJxDpBmjv(parameters[0])))
				{
					num2 = 12;
					break;
				}
				return;
			case 9:
				if (!rM2lRjhH4jTAvWIdTPJ(parameterExpression.Name))
				{
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 5;
			case 7:
				AddSymbol((string)DtptSGhAmSAJxDpBmjv(parameterExpression), parameterExpression);
				num2 = 5;
				break;
			case 5:
				num3++;
				num2 = 6;
				break;
			case 12:
				it = parameters[0];
				num2 = 11;
				break;
			case 4:
				array = parameters;
				num2 = 3;
				break;
			case 1:
			case 6:
				if (num3 < array.Length)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
					{
						num2 = 8;
					}
					break;
				}
				goto default;
			default:
				if (parameters.Length == 1)
				{
					num2 = 10;
					break;
				}
				return;
			case 2:
			case 8:
				parameterExpression = array[num3];
				num2 = 9;
				break;
			case 3:
				num3 = 0;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num2 = 0;
				}
				break;
			case 11:
				return;
			}
		}
	}

	private void ProcessValues(object[] values)
	{
		//Discarded unreachable code: IL_00f9, IL_010c, IL_0181
		int num = 2;
		int num2 = num;
		int num3 = default(int);
		object obj = default(object);
		while (true)
		{
			switch (num2)
			{
			case 3:
			case 8:
				num3++;
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
				{
					num2 = 9;
				}
				break;
			case 11:
				return;
			case 10:
				externals = (IDictionary<string, object>)obj;
				num2 = 8;
				break;
			case 6:
				obj = values[num3];
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				if (!(obj is IDictionary<string, object>))
				{
					num2 = 5;
					break;
				}
				goto case 10;
			default:
				if (num3 == values.Length - 1)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 5;
			case 1:
			case 9:
				if (num3 >= values.Length)
				{
					num2 = 11;
					break;
				}
				goto case 6;
			case 5:
			case 7:
				AddSymbol((string)UhP449h7vEDexhBCxa9(TZcomMhwloVeNRf8kPa(-629844702 ^ -629843906), num3.ToString(CultureInfo.InvariantCulture)), obj);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				num3 = 0;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private void AddSymbol(string name, object value)
	{
		//Discarded unreachable code: IL_00ab, IL_00ba
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				throw ParseError((string)TZcomMhwloVeNRf8kPa(0x18A6761F ^ 0x18A67B3D), name);
			case 1:
				symbols.Add(name, value);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				if (!symbols.ContainsKey(name))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			case 3:
				return;
			}
		}
	}

	public Expression Parse(Type resultType)
	{
		//Discarded unreachable code: IL_003d
		int num = 1;
		int num2 = num;
		int pos = default(int);
		Expression expression = default(Expression);
		while (true)
		{
			switch (num2)
			{
			case 3:
				throw ParseError(pos, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420742494), stYXaUh085EWUoWhgat(resultType));
			case 2:
				ValidateToken(TokenId.End, (string)TZcomMhwloVeNRf8kPa(0x4785BC0D ^ 0x4785B1C7));
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
				{
					num2 = 4;
				}
				break;
			case 5:
				if (!i3sRlhhxItMoQagKgRK(resultType, null))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 6;
			default:
				expression = ParseExpression();
				num2 = 5;
				break;
			case 1:
				pos = token.pos;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				return expression;
			case 6:
				if ((expression = PromoteExpression(expression, resultType, exact: true)) == null)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	public IEnumerable<DynamicOrdering> ParseOrdering()
	{
		List<DynamicOrdering> list = new List<DynamicOrdering>();
		while (true)
		{
			Expression selector = ParseExpression();
			bool ascending = true;
			if (TokenIdentifierIs(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7C1EE318 ^ 0x7C1EEEFE)) || TokenIdentifierIs(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-210725949 ^ -210723277)))
			{
				NextToken();
			}
			else if (TokenIdentifierIs(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x61EC0CB8 ^ 0x61EC02BE)) || TokenIdentifierIs(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CB464B ^ 0x53CB4859)))
			{
				NextToken();
				ascending = false;
			}
			list.Add(new DynamicOrdering
			{
				Selector = selector,
				Ascending = ascending
			});
			if (token.id != TokenId.Comma)
			{
				break;
			}
			NextToken();
		}
		ValidateToken(TokenId.End, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3630F361 ^ 0x3630FEAB));
		return list;
	}

	private Expression ParseExpression()
	{
		int num = 8;
		int num2 = num;
		Expression expression = default(Expression);
		Expression expr = default(Expression);
		Expression expr2 = default(Expression);
		int pos = default(int);
		while (true)
		{
			switch (num2)
			{
			case 4:
				NextToken();
				num2 = 2;
				continue;
			case 1:
				ValidateToken(TokenId.Colon, (string)TZcomMhwloVeNRf8kPa(-882126494 ^ -882122936));
				num2 = 4;
				continue;
			default:
				NextToken();
				num2 = 6;
				continue;
			case 9:
				expression = GenerateConditional(expression, expr, expr2, pos);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num2 = 3;
				}
				continue;
			case 5:
				if (token.id == TokenId.Question)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 7:
				expression = ParseLogicalOr();
				num2 = 5;
				continue;
			case 2:
				expr2 = ParseExpression();
				num2 = 9;
				continue;
			case 6:
				expr = ParseExpression();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
				{
					num2 = 0;
				}
				continue;
			case 8:
				pos = token.pos;
				num2 = 7;
				continue;
			case 3:
				break;
			}
			break;
		}
		return expression;
	}

	private Expression ParseLogicalOr()
	{
		//Discarded unreachable code: IL_0081, IL_016b
		int num = 2;
		Token token = default(Token);
		Expression left = default(Expression);
		Expression right = default(Expression);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
				case 8:
					token = this.token;
					num2 = 9;
					continue;
				case 2:
					left = ParseLogicalAnd();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
					{
						num2 = 1;
					}
					continue;
				default:
					if (TokenIdentifierIs((string)TZcomMhwloVeNRf8kPa(0x269E5FCA ^ 0x269E518C)))
					{
						num2 = 6;
						continue;
					}
					goto case 4;
				case 4:
					return left;
				case 3:
					CheckAndPromoteOperands(KAF1pPhmquc8fUailtM(typeof(ILogicalSignatures).TypeHandle), token.text, ref left, ref right, token.pos);
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
					{
						num2 = 7;
					}
					continue;
				case 1:
				case 5:
					if (this.token.id != TokenId.DoubleBar)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 6;
				case 7:
					break;
				case 9:
					NextToken();
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
					{
						num2 = 7;
					}
					continue;
				case 10:
					right = ParseLogicalAnd();
					num2 = 3;
					continue;
				}
				break;
			}
			left = (Expression)W8PUxJhyaMPUXgpFdZy(left, right);
			num = 5;
		}
	}

	private Expression ParseLogicalAnd()
	{
		//Discarded unreachable code: IL_0100, IL_010f
		int num = 8;
		Expression left = default(Expression);
		Expression right = default(Expression);
		Token token = default(Token);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					left = Expression.AndAlso(left, right);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					CheckAndPromoteOperands(KAF1pPhmquc8fUailtM(typeof(ILogicalSignatures).TypeHandle), token.text, ref left, ref right, token.pos);
					num2 = 6;
					continue;
				case 9:
					right = ParseComparison();
					num2 = 2;
					continue;
				case 3:
					return left;
				case 5:
					NextToken();
					num2 = 9;
					continue;
				case 4:
					if (!TokenIdentifierIs((string)TZcomMhwloVeNRf8kPa(-1876063057 ^ -1876065567)))
					{
						num2 = 3;
						continue;
					}
					break;
				default:
					if (this.token.id != TokenId.DoubleAmphersand)
					{
						num2 = 4;
						continue;
					}
					break;
				case 8:
					goto end_IL_0012;
				case 1:
					break;
				}
				token = this.token;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num2 = 5;
				}
				continue;
				end_IL_0012:
				break;
			}
			left = ParseComparison();
			num = 7;
		}
	}

	private Expression ParseComparison()
	{
		//Discarded unreachable code: IL_0115, IL_0124, IL_0134, IL_0181, IL_029b, IL_02aa, IL_02ba, IL_02c9, IL_032c, IL_033b, IL_0397, IL_03a6, IL_03fc, IL_040b, IL_043a, IL_04c3, IL_04d2, IL_055b, IL_056a, IL_057a, IL_0589, IL_05dc, IL_0754
		int num = 22;
		Token token = default(Token);
		Expression expression = default(Expression);
		Expression right = default(Expression);
		Expression left = default(Expression);
		TokenId id = default(TokenId);
		bool flag = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3;
				switch (num2)
				{
				case 10:
					if (token.id != TokenId.Equal)
					{
						num = 34;
						break;
					}
					goto IL_075e;
				case 9:
					if ((expression = PromoteExpression(right, xNfa4VhMkUhKyv7OK94(left), exact: true)) != null)
					{
						num2 = 53;
						continue;
					}
					goto case 35;
				case 2:
					if (this.token.id != TokenId.LessThan)
					{
						num2 = 28;
						continue;
					}
					goto case 18;
				case 7:
					left = GenerateEqual(left, right);
					num2 = 20;
					continue;
				case 25:
					left = expression;
					num2 = 4;
					continue;
				case 53:
					right = expression;
					num2 = 47;
					continue;
				case 17:
				case 45:
					throw IncompatibleOperandsError(token.text, left, right, token.pos);
				case 29:
					if (this.token.id != TokenId.GreaterThanEqual)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 18;
				case 4:
				case 24:
				case 30:
				case 40:
				case 47:
					id = token.id;
					num = 52;
					break;
				default:
					goto IL_0238;
				case 19:
				case 50:
					if (i3sRlhhxItMoQagKgRK(xNfa4VhMkUhKyv7OK94(left), xNfa4VhMkUhKyv7OK94(right)))
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto case 4;
				case 33:
					if (this.token.id != TokenId.ExclamationEqual)
					{
						num2 = 11;
						continue;
					}
					goto case 18;
				case 6:
					if (flag)
					{
						num2 = 31;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
						{
							num2 = 17;
						}
						continue;
					}
					goto IL_01da;
				case 32:
					goto IL_0311;
				case 49:
					goto IL_0346;
				case 1:
					goto IL_036c;
				case 11:
					if (this.token.id != TokenId.LessGreater)
					{
						num = 51;
						break;
					}
					goto case 18;
				case 46:
					if (xNfa4VhMkUhKyv7OK94(left).IsAssignableFrom(xNfa4VhMkUhKyv7OK94(right)))
					{
						num = 27;
						break;
					}
					goto case 5;
				case 15:
					if (this.token.id != TokenId.DoubleEqual)
					{
						num2 = 33;
						continue;
					}
					goto case 18;
				case 44:
					return left;
				case 52:
					switch (id)
					{
					case TokenId.Equal:
					case TokenId.DoubleEqual:
						break;
					case TokenId.Question:
					case TokenId.OpenBracket:
					case TokenId.CloseBracket:
					case TokenId.Bar:
					case TokenId.DoubleAmphersand:
						goto IL_0238;
					case TokenId.LessThan:
						goto IL_0311;
					case TokenId.ExclamationEqual:
					case TokenId.LessGreater:
						goto IL_0346;
					case TokenId.GreaterThanEqual:
						goto IL_036c;
					default:
						goto IL_0482;
					case TokenId.GreaterThan:
						goto IL_0622;
					case TokenId.LessThanEqual:
						goto IL_06d6;
					}
					goto case 7;
				case 18:
					token = this.token;
					num2 = 48;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
					{
						num2 = 45;
					}
					continue;
				case 22:
					left = ParseAdditive();
					num2 = 21;
					continue;
				case 5:
					if (!xNfa4VhMkUhKyv7OK94(right).IsAssignableFrom(xNfa4VhMkUhKyv7OK94(left)))
					{
						num2 = 12;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
						{
							num2 = 17;
						}
						continue;
					}
					goto case 41;
				case 23:
					if (Io2IBDh9UNF0yjdyVXo(xNfa4VhMkUhKyv7OK94(right)))
					{
						num2 = 19;
						continue;
					}
					CheckAndPromoteOperands(flag ? KAF1pPhmquc8fUailtM(typeof(IEqualitySignatures).TypeHandle) : KAF1pPhmquc8fUailtM(typeof(IRelationalSignatures).TypeHandle), token.text, ref left, ref right, token.pos);
					num2 = 24;
					continue;
				case 27:
					right = (Expression)j7VDV7hJ6wTVTBOdLNA(right, xNfa4VhMkUhKyv7OK94(left));
					num2 = 30;
					continue;
				case 48:
					NextToken();
					num2 = 31;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num2 = 39;
					}
					continue;
				case 13:
					if (token.id != TokenId.ExclamationEqual)
					{
						num2 = 37;
						continue;
					}
					goto IL_075e;
				case 37:
					num3 = ((token.id == TokenId.LessGreater) ? 1 : 0);
					goto IL_075f;
				case 35:
					if ((expression = PromoteExpression(left, right.Type, exact: true)) != null)
					{
						num2 = 25;
						continue;
					}
					goto case 14;
				case 31:
					if (!xNfa4VhMkUhKyv7OK94(left).IsValueType)
					{
						num = 3;
						break;
					}
					goto IL_01da;
				case 43:
					goto IL_0622;
				case 8:
					if (i3sRlhhxItMoQagKgRK(xNfa4VhMkUhKyv7OK94(left), right.Type))
					{
						num2 = 46;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
						{
							num2 = 20;
						}
						continue;
					}
					goto case 4;
				case 41:
					left = Expression.Convert(left, xNfa4VhMkUhKyv7OK94(right));
					num2 = 40;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 11;
					}
					continue;
				case 39:
					right = ParseAdditive();
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
					{
						num2 = 6;
					}
					continue;
				case 28:
					if (this.token.id != TokenId.LessThanEqual)
					{
						num = 44;
						break;
					}
					goto case 18;
				case 16:
					goto IL_06d6;
				case 3:
					if (!right.Type.IsValueType)
					{
						num2 = 8;
						continue;
					}
					goto IL_01da;
				case 51:
					if (this.token.id != TokenId.GreaterThan)
					{
						num = 29;
						break;
					}
					goto case 18;
				case 34:
					if (token.id != TokenId.DoubleEqual)
					{
						num2 = 13;
						continue;
					}
					goto IL_075e;
				case 14:
					{
						throw IncompatibleOperandsError(token.text, left, right, token.pos);
					}
					IL_01da:
					if (Io2IBDh9UNF0yjdyVXo(xNfa4VhMkUhKyv7OK94(left)))
					{
						num2 = 50;
						continue;
					}
					goto case 23;
					IL_075e:
					num3 = 1;
					goto IL_075f;
					IL_06d6:
					left = GenerateLessThanEqual(left, right);
					num2 = 36;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num2 = 38;
					}
					continue;
					IL_0622:
					left = GenerateGreaterThan(left, right);
					num2 = 42;
					continue;
					IL_0482:
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
					{
						num2 = 0;
					}
					continue;
					IL_0238:
					if (this.token.id != TokenId.Equal)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
						{
							num2 = 15;
						}
						continue;
					}
					goto case 18;
					IL_036c:
					left = GenerateGreaterThanEqual(left, right);
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
					{
						num2 = 26;
					}
					continue;
					IL_075f:
					flag = (byte)num3 != 0;
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num2 = 0;
					}
					continue;
					IL_0346:
					left = GenerateNotEqual(left, right);
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
					{
						num2 = 36;
					}
					continue;
					IL_0311:
					left = GenerateLessThan(left, right);
					num2 = 12;
					continue;
				}
				break;
			}
		}
	}

	private Expression ParseAdditive()
	{
		//Discarded unreachable code: IL_0081, IL_0115, IL_01ff, IL_022e, IL_0263
		int num = 20;
		Expression left = default(Expression);
		Expression right = default(Expression);
		Token token = default(Token);
		TokenId id = default(TokenId);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 20:
					left = ParseMultiplicative();
					num2 = 19;
					continue;
				case 7:
				case 8:
				case 10:
				case 19:
				case 21:
					if (this.token.id != TokenId.Plus)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
						{
							num2 = 15;
						}
						continue;
					}
					goto case 11;
				case 5:
					right = ParseMultiplicative();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					if (!JjQQTHhdFqCPEsKhvWZ(xNfa4VhMkUhKyv7OK94(left), KAF1pPhmquc8fUailtM(typeof(string).TypeHandle)))
					{
						num2 = 4;
						continue;
					}
					goto case 12;
				case 13:
					CheckAndPromoteOperands(typeof(IAddSignatures), token.text, ref left, ref right, token.pos);
					num2 = 6;
					continue;
				case 16:
					left = GenerateSubtract(left, right);
					num2 = 21;
					continue;
				case 12:
				case 14:
					left = GenerateStringConcat(left, right);
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num2 = 5;
					}
					continue;
				case 23:
					if (this.token.id != TokenId.Amphersand)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 11;
				case 15:
					if (this.token.id != TokenId.Minus)
					{
						num2 = 23;
						continue;
					}
					goto case 11;
				case 18:
					CheckAndPromoteOperands(KAF1pPhmquc8fUailtM(typeof(ISubtractSignatures).TypeHandle), token.text, ref left, ref right, token.pos);
					num2 = 16;
					continue;
				case 1:
					NextToken();
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num2 = 2;
					}
					continue;
				case 6:
					left = GenerateAdd(left, right);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
					{
						num2 = 8;
					}
					continue;
				case 11:
					token = this.token;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					if (JjQQTHhdFqCPEsKhvWZ(xNfa4VhMkUhKyv7OK94(right), typeof(string)))
					{
						num2 = 14;
						continue;
					}
					goto case 13;
				case 22:
					if (id != TokenId.Amphersand)
					{
						num2 = 17;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
						{
							num2 = 17;
						}
						continue;
					}
					goto case 12;
				case 3:
					return left;
				default:
					id = token.id;
					num2 = 22;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
					{
						num2 = 9;
					}
					continue;
				case 9:
					if (id != TokenId.Minus)
					{
						num2 = 10;
						continue;
					}
					goto case 18;
				case 17:
					if (id != TokenId.Plus)
					{
						break;
					}
					goto case 2;
				}
				break;
			}
			num = 9;
		}
	}

	private Expression ParseMultiplicative()
	{
		//Discarded unreachable code: IL_00a2, IL_00b1, IL_00e4, IL_00f3, IL_0116, IL_0125, IL_01ac, IL_01dd, IL_0267, IL_0276, IL_0285
		int num = 4;
		Expression left = default(Expression);
		TokenId id = default(TokenId);
		Token token = default(Token);
		Expression right = default(Expression);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					return left;
				case 4:
					left = ParseUnary();
					num = 3;
					break;
				case 13:
					id = token.id;
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num2 = 23;
					}
					continue;
				case 14:
					if (id != TokenId.Slash)
					{
						num2 = 10;
						continue;
					}
					goto case 16;
				case 16:
					left = (Expression)QcrGjWhrIvMQo7F1ES1(left, right);
					num2 = 11;
					continue;
				case 8:
					NextToken();
					num2 = 22;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num2 = 10;
					}
					continue;
				case 9:
				case 20:
					if (id != TokenId.Asterisk)
					{
						num = 14;
						break;
					}
					goto case 1;
				case 18:
					if (TokenIdentifierIs((string)TZcomMhwloVeNRf8kPa(0x53FA00CE ^ 0x53FA0E96)))
					{
						num2 = 24;
						continue;
					}
					goto case 6;
				case 23:
					if (id > TokenId.Percent)
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto default;
				case 2:
					if (this.token.id != TokenId.Slash)
					{
						num2 = 21;
						continue;
					}
					goto case 5;
				case 5:
				case 24:
					token = this.token;
					num2 = 8;
					continue;
				default:
					if (id != TokenId.Identifier)
					{
						num2 = 12;
						continue;
					}
					goto case 15;
				case 3:
				case 7:
				case 10:
				case 11:
				case 17:
				case 25:
					if (this.token.id != TokenId.Asterisk)
					{
						num2 = 2;
						continue;
					}
					goto case 5;
				case 21:
					if (this.token.id != TokenId.Percent)
					{
						num2 = 18;
						continue;
					}
					goto case 5;
				case 15:
					left = Expression.Modulo(left, right);
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 17;
					}
					continue;
				case 12:
					if (id != TokenId.Percent)
					{
						num2 = 25;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
						{
							num2 = 15;
						}
						continue;
					}
					goto case 15;
				case 1:
					left = (Expression)fDve4KhloISBw6DaUcB(left, right);
					num2 = 7;
					continue;
				case 19:
					CheckAndPromoteOperands(KAF1pPhmquc8fUailtM(typeof(IArithmeticSignatures).TypeHandle), token.text, ref left, ref right, token.pos);
					num2 = 13;
					continue;
				case 22:
					right = ParseUnary();
					num = 19;
					break;
				}
				break;
			}
		}
	}

	private Expression ParseUnary()
	{
		//Discarded unreachable code: IL_02c0
		int num = 8;
		Token token = default(Token);
		Expression expr = default(Expression);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 11:
					if (this.token.id == TokenId.RealLiteral)
					{
						num2 = 16;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
						{
							num2 = 12;
						}
						break;
					}
					goto IL_0237;
				case 14:
					if (token.id == TokenId.Minus)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 4;
				case 15:
					if (TokenIdentifierIs(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x307E9FD1 ^ 0x307E91B3)))
					{
						num2 = 12;
						break;
					}
					return ParsePrimary();
				case 9:
					if (this.token.id != TokenId.IntegerLiteral)
					{
						goto end_IL_0012;
					}
					goto case 16;
				case 16:
					this.token.text = (string)TZcomMhwloVeNRf8kPa(--1418440330 ^ 0x548BA0E6) + this.token.text;
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
					{
						num2 = 4;
					}
					break;
				default:
					CheckAndPromoteOperand(KAF1pPhmquc8fUailtM(typeof(INegationSignatures).TypeHandle), token.text, ref expr, token.pos);
					num2 = 13;
					break;
				case 1:
				case 17:
					return expr;
				case 2:
					NextToken();
					num2 = 5;
					break;
				case 8:
					if (this.token.id != TokenId.Minus)
					{
						num2 = 7;
						break;
					}
					goto case 12;
				case 4:
					CheckAndPromoteOperand(KAF1pPhmquc8fUailtM(typeof(INotSignatures).TypeHandle), token.text, ref expr, token.pos);
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num2 = 2;
					}
					break;
				case 7:
					if (this.token.id != TokenId.Exclamation)
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
						{
							num2 = 15;
						}
						break;
					}
					goto case 12;
				case 12:
					token = this.token;
					num2 = 2;
					break;
				case 5:
					if (token.id == TokenId.Minus)
					{
						num2 = 9;
						break;
					}
					goto IL_0237;
				case 3:
					return ParsePrimary();
				case 13:
					expr = (Expression)H8LAbdhgHEI1PxnBwK5(expr);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num2 = 1;
					}
					break;
				case 6:
					this.token.pos = token.pos;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num2 = 0;
					}
					break;
				case 10:
					{
						expr = Expression.Not(expr);
						num2 = 17;
						break;
					}
					IL_0237:
					expr = ParseUnary();
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num2 = 7;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 11;
		}
	}

	private Expression ParsePrimary()
	{
		//Discarded unreachable code: IL_008f, IL_009e, IL_00f2, IL_0101
		int num = 4;
		Expression expression = default(Expression);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					expression = ParsePrimaryStart();
					num2 = 3;
					continue;
				case 8:
					break;
				case 7:
					NextToken();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					expression = ParseMemberAccess(null, expression);
					num2 = 6;
					continue;
				case 3:
				case 5:
				case 6:
					if (token.id == TokenId.Dot)
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 2;
				default:
					return expression;
				case 2:
					if (token.id == TokenId.OpenBracket)
					{
						num2 = 8;
						continue;
					}
					goto default;
				}
				break;
			}
			expression = ParseElementAccess(expression);
			num = 5;
		}
	}

	private Expression ParsePrimaryStart()
	{
		//Discarded unreachable code: IL_0074, IL_0083
		int num = 2;
		int num2 = num;
		TokenId id = default(TokenId);
		while (true)
		{
			switch (num2)
			{
			case 1:
				switch (id)
				{
				case TokenId.Identifier:
					goto IL_008e;
				case TokenId.StringLiteral:
					return ParseStringLiteral();
				case TokenId.IntegerLiteral:
					return ParseIntegerLiteral();
				case TokenId.RealLiteral:
					return ParseRealLiteral();
				case TokenId.OpenParen:
					return ParseParenExpression();
				case TokenId.Exclamation:
				case TokenId.Percent:
				case TokenId.Amphersand:
					goto IL_00b1;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				goto IL_008e;
			default:
				goto IL_00b1;
			case 2:
				{
					id = token.id;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 1;
					}
					break;
				}
				IL_008e:
				return ParseIdentifier();
				IL_00b1:
				throw ParseError(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4785BC0D ^ 0x4785B27F));
			}
		}
	}

	private Expression ParseStringLiteral()
	{
		//Discarded unreachable code: IL_0233
		int num = 7;
		char c = default(char);
		string text = default(string);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					c = VWOixOh5aBfZJq1DmMl(token.text, 0);
					num2 = 2;
					continue;
				case 3:
					text = text.Remove(num3, 1);
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
					{
						num2 = 10;
					}
					continue;
				case 1:
					throw ParseError(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7C1EE318 ^ 0x7C1EED84));
				default:
					num4 = 0;
					num2 = 13;
					continue;
				case 7:
					break;
				case 8:
				case 13:
					num3 = O2enEChYdQuK4p1Zln4(text, c, num4);
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num2 = 4;
					}
					continue;
				case 5:
					if (num3 >= 0)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 4;
				case 2:
					text = (string)Lla0KjhjTGXZ124Xgfk(token.text, 1, OTruAxh6tuxUllMwkqV(token.text) - 2);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					if (c == '\'')
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
						{
							num2 = 4;
						}
						continue;
					}
					NextToken();
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
					{
						num2 = 11;
					}
					continue;
				case 10:
					num4 = num3 + 1;
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num2 = 5;
					}
					continue;
				case 12:
					return CreateLiteral(VWOixOh5aBfZJq1DmMl(text, 0), text);
				case 9:
					if (OTruAxh6tuxUllMwkqV(text) == 1)
					{
						NextToken();
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
						{
							num2 = 12;
						}
					}
					else
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
						{
							num2 = 1;
						}
					}
					continue;
				case 11:
					return CreateLiteral(text, text);
				}
				break;
			}
			ValidateToken(TokenId.StringLiteral);
			num = 6;
		}
	}

	private Expression ParseIntegerLiteral()
	{
		//Discarded unreachable code: IL_0088, IL_014d
		int num = 2;
		ulong result = default(ulong);
		string text = default(string);
		long result2 = default(long);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					return CreateLiteral((uint)result, text);
				case 2:
					ValidateToken(TokenId.IntegerLiteral);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num2 = 1;
					}
					break;
				case 13:
					return CreateLiteral((int)result2, text);
				case 3:
					return CreateLiteral(result2, text);
				case 11:
					return CreateLiteral((int)result, text);
				case 4:
					if (result > int.MaxValue)
					{
						if (result > uint.MaxValue)
						{
							if (result > long.MaxValue)
							{
								num2 = 7;
								break;
							}
							goto case 5;
						}
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
						{
							num2 = 9;
						}
						break;
					}
					num2 = 11;
					break;
				case 8:
					if (VWOixOh5aBfZJq1DmMl(text, 0) != '-')
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
						{
							num2 = 10;
						}
					}
					else if (long.TryParse(text, out result2))
					{
						NextToken();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 6;
					}
					break;
				case 6:
					throw ParseError((string)TZcomMhwloVeNRf8kPa(0x3C5338FF ^ 0x3C5337F7), text);
				case 10:
					if (!ulong.TryParse(text, out result))
					{
						num2 = 12;
						break;
					}
					NextToken();
					num2 = 4;
					break;
				case 5:
					return CreateLiteral((long)result, text);
				case 7:
					return CreateLiteral(result, text);
				case 14:
					if (result2 > int.MaxValue)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
						{
							num2 = 3;
						}
						break;
					}
					goto case 13;
				default:
					if (result2 >= int.MinValue)
					{
						goto end_IL_0012;
					}
					goto case 3;
				case 1:
					text = token.text;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num2 = 8;
					}
					break;
				case 12:
					throw ParseError((string)TZcomMhwloVeNRf8kPa(0x4EDCBA32 ^ 0x4EDCB53A), text);
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 14;
		}
	}

	private Expression ParseRealLiteral()
	{
		//Discarded unreachable code: IL_00c8, IL_0135, IL_0144, IL_0154
		int num = 10;
		int num2 = num;
		string text = default(string);
		double result2 = default(double);
		object obj = default(object);
		float result = default(float);
		char c = default(char);
		while (true)
		{
			switch (num2)
			{
			case 6:
				if (double.TryParse(text, out result2))
				{
					num2 = 8;
					break;
				}
				goto default;
			case 1:
				throw ParseError(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xE1229CF ^ 0xE122689), text);
			case 5:
				NextToken();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
				{
					num2 = 3;
				}
				break;
			case 11:
				obj = null;
				num2 = 12;
				break;
			case 8:
				obj = result2;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num2 = 0;
				}
				break;
			case 9:
				text = token.text;
				num2 = 11;
				break;
			default:
				if (obj != null)
				{
					num2 = 5;
					break;
				}
				goto case 1;
			case 15:
				obj = result;
				num2 = 7;
				break;
			case 3:
				return CreateLiteral(obj, text);
			case 10:
				ValidateToken(TokenId.RealLiteral);
				num2 = 9;
				break;
			case 12:
				c = VWOixOh5aBfZJq1DmMl(text, OTruAxh6tuxUllMwkqV(text) - 1);
				num2 = 14;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
				{
					num2 = 8;
				}
				break;
			case 4:
				if (c == 'f')
				{
					num2 = 13;
					break;
				}
				goto case 6;
			case 14:
				if (c != 'F')
				{
					num2 = 4;
					break;
				}
				goto case 13;
			case 13:
				if (!float.TryParse((string)Lla0KjhjTGXZ124Xgfk(text, 0, OTruAxh6tuxUllMwkqV(text) - 1), out result))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 15;
			}
		}
	}

	private Expression CreateLiteral(object value, string text)
	{
		int num = 1;
		int num2 = num;
		ConstantExpression constantExpression = default(ConstantExpression);
		while (true)
		{
			switch (num2)
			{
			default:
				literals.Add(constantExpression, text);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				return constantExpression;
			case 1:
				constantExpression = Expression.Constant(value);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private Expression ParseParenExpression()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				ValidateToken(TokenId.OpenParen, (string)TZcomMhwloVeNRf8kPa(-1487388570 ^ -1487384808));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
				{
					num2 = 1;
				}
				break;
			default:
			{
				Expression result = ParseExpression();
				ValidateToken(TokenId.CloseParen, (string)TZcomMhwloVeNRf8kPa(-1886646897 ^ -1886649835));
				NextToken();
				return result;
			}
			case 1:
				NextToken();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private Expression ParseIdentifier()
	{
		//Discarded unreachable code: IL_008c, IL_009b, IL_00aa, IL_0235, IL_028c
		int num = 10;
		LambdaExpression lambdaExpression = default(LambdaExpression);
		Expression expression = default(Expression);
		object value = default(object);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					lambdaExpression = expression as LambdaExpression;
					num2 = 15;
					break;
				case 14:
					return ParseMemberAccess(null, it);
				case 2:
					throw ParseError((string)TZcomMhwloVeNRf8kPa(0x17ADCCD8 ^ 0x17ADC316), token.text);
				case 15:
					if (lambdaExpression != null)
					{
						num2 = 6;
						break;
					}
					goto case 20;
				case 21:
					expression = value as Expression;
					num2 = 12;
					break;
				case 1:
					return (Expression)value;
				case 5:
					if (!symbols.TryGetValue(token.text, out value))
					{
						num2 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
						{
							num2 = 7;
						}
						break;
					}
					goto case 21;
				case 9:
					if (!keywords.TryGetValue(token.text, out value))
					{
						num2 = 5;
						break;
					}
					goto case 3;
				case 4:
					return ParseIif();
				case 17:
					return ParseIt();
				case 12:
					if (expression == null)
					{
						num2 = 7;
						break;
					}
					goto case 8;
				case 3:
					if (value is Type)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
						{
							num2 = 0;
						}
					}
					else if (value != keywordIt)
					{
						if (value != keywordIif)
						{
							if (value == keywordNew)
							{
								num2 = 19;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
								{
									num2 = 3;
								}
								break;
							}
							NextToken();
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
							{
								num2 = 0;
							}
						}
						else
						{
							num2 = 4;
						}
					}
					else
					{
						num2 = 17;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
						{
							num2 = 9;
						}
					}
					break;
				case 16:
					if (!externals.TryGetValue(token.text, out value))
					{
						num2 = 13;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
						{
							num2 = 6;
						}
						break;
					}
					goto case 21;
				case 10:
					ValidateToken(TokenId.Identifier);
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 9;
					}
					break;
				case 19:
					return ParseNew();
				case 7:
					expression = (Expression)JuDEY9hLMrnNBJuTbEA(value);
					num2 = 20;
					break;
				case 18:
					return expression;
				case 13:
					if (it == null)
					{
						goto end_IL_0012;
					}
					goto case 14;
				case 6:
					return ParseLambdaInvocation(lambdaExpression);
				case 20:
					NextToken();
					num2 = 18;
					break;
				case 11:
					if (externals != null)
					{
						num2 = 16;
						break;
					}
					goto case 13;
				default:
					return ParseTypeAccess((Type)value);
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 2;
		}
	}

	private Expression ParseIt()
	{
		//Discarded unreachable code: IL_0056, IL_0065
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (it != null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto default;
			default:
				throw ParseError((string)TZcomMhwloVeNRf8kPa(0x3B36AB09 ^ 0x3B36BB0B));
			case 2:
				NextToken();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				return it;
			}
		}
	}

	private Expression ParseIif()
	{
		int num = 4;
		int num2 = num;
		Expression[] array = default(Expression[]);
		int pos = default(int);
		while (true)
		{
			switch (num2)
			{
			default:
				array = ParseArgumentList();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				if (array.Length != 3)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
					{
						num2 = 1;
					}
					break;
				}
				return GenerateConditional(array[0], array[1], array[2], pos);
			case 1:
				throw ParseError(pos, (string)TZcomMhwloVeNRf8kPa(-2099751081 ^ -2099755141));
			case 3:
				NextToken();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				pos = token.pos;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	private Expression GenerateConditional(Expression test, Expression expr1, Expression expr2, int errorPos)
	{
		//Discarded unreachable code: IL_0089, IL_0098, IL_00a8, IL_00da, IL_00e9, IL_012f, IL_01cd, IL_0269, IL_0273, IL_02d5, IL_02e4, IL_0309, IL_0339
		int num = 7;
		Expression expression = default(Expression);
		Expression expression2 = default(Expression);
		string text = default(string);
		string text2 = default(string);
		while (true)
		{
			int num2 = num;
			object obj4;
			while (true)
			{
				object obj3;
				object obj2;
				object obj;
				switch (num2)
				{
				case 21:
					expr1 = expression;
					num2 = 4;
					continue;
				case 20:
					if (expression == null)
					{
						num2 = 15;
						continue;
					}
					goto case 1;
				case 10:
					if (expr1 == nullLiteral)
					{
						num2 = 14;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
						{
							num2 = 7;
						}
						continue;
					}
					obj3 = PromoteExpression(expr2, expr1.Type, exact: true);
					goto IL_036a;
				case 1:
					if (expression2 == null)
					{
						num2 = 3;
						continue;
					}
					goto case 13;
				case 19:
					obj4 = null;
					goto end_IL_0012;
				case 8:
					if (expression != null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto case 12;
				default:
					if (expression != null)
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
						{
							num2 = 22;
						}
						continue;
					}
					goto case 5;
				case 12:
					expr2 = expression2;
					num2 = 19;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
					{
						num2 = 25;
					}
					continue;
				case 7:
					if (!i3sRlhhxItMoQagKgRK(xNfa4VhMkUhKyv7OK94(test), KAF1pPhmquc8fUailtM(typeof(bool).TypeHandle)))
					{
						num2 = 6;
						continue;
					}
					goto case 11;
				case 24:
					obj2 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F3078B6 ^ 0x5F306850);
					goto IL_0391;
				case 22:
					if (expression2 == null)
					{
						num2 = 21;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
						{
							num2 = 15;
						}
						continue;
					}
					goto case 5;
				case 18:
					if (expr2 == nullLiteral)
					{
						num2 = 2;
						continue;
					}
					obj = expr2.Type.Name;
					break;
				case 13:
					throw ParseError(errorPos, (string)TZcomMhwloVeNRf8kPa(0x34185E55 ^ 0x34184EA7), text, text2);
				case 3:
				case 15:
					throw ParseError(errorPos, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710579288), text, text2);
				case 4:
				case 25:
					return (Expression)NUhEDbhsC9F1Rge5Psd(test, expr1, expr2);
				case 14:
					obj3 = null;
					goto IL_036a;
				case 11:
					throw ParseError(errorPos, (string)TZcomMhwloVeNRf8kPa(0x5A4C7B29 ^ 0x5A4C6BAF));
				case 6:
					if (i3sRlhhxItMoQagKgRK(xNfa4VhMkUhKyv7OK94(expr1), xNfa4VhMkUhKyv7OK94(expr2)))
					{
						num2 = 17;
						continue;
					}
					goto case 4;
				case 17:
					if (expr2 == nullLiteral)
					{
						num2 = 19;
						continue;
					}
					obj4 = PromoteExpression(expr1, xNfa4VhMkUhKyv7OK94(expr2), exact: true);
					goto end_IL_0012;
				case 9:
				case 16:
				case 23:
					if (expr1 == nullLiteral)
					{
						num2 = 24;
						continue;
					}
					obj2 = UXWy9khU64Y7m676YRf(xNfa4VhMkUhKyv7OK94(expr1));
					goto IL_0391;
				case 5:
					if (expression2 == null)
					{
						num2 = 23;
						continue;
					}
					goto case 8;
				case 2:
					{
						obj = TZcomMhwloVeNRf8kPa(0x463A0F3C ^ 0x463A1FDA);
						break;
					}
					IL_036a:
					expression2 = (Expression)obj3;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
					{
						num2 = 0;
					}
					continue;
					IL_0391:
					text = (string)obj2;
					num2 = 18;
					continue;
				}
				text2 = (string)obj;
				num2 = 20;
				continue;
				end_IL_0012:
				break;
			}
			expression = (Expression)obj4;
			num = 10;
		}
	}

	private Expression ParseNew()
	{
		//Discarded unreachable code: IL_0220, IL_0272, IL_0281, IL_02e5, IL_0346
		int num = 19;
		MemberBinding[] array = default(MemberBinding[]);
		List<DynamicProperty> list2 = default(List<DynamicProperty>);
		Expression expression = default(Expression);
		Type type = default(Type);
		List<Expression> list = default(List<Expression>);
		string name = default(string);
		int num3 = default(int);
		int pos = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 13:
					array = new MemberBinding[list2.Count];
					num2 = 24;
					continue;
				case 9:
					list2 = new List<DynamicProperty>();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num2 = 1;
					}
					continue;
				case 6:
					expression = ParseExpression();
					num = 16;
					break;
				case 21:
					return (Expression)PZMCscGBhAvQMOvfWJL(juH5Z3GF5GjImv1e2W0(type), array);
				case 22:
					NextToken();
					num2 = 28;
					continue;
				case 1:
					list = new List<Expression>();
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
					{
						num2 = 7;
					}
					continue;
				case 8:
					NextToken();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
					{
						num2 = 23;
					}
					continue;
				case 12:
					list2.Add(new DynamicProperty(name, expression.Type));
					num2 = 17;
					continue;
				case 20:
				case 26:
					if (num3 >= array.Length)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
						{
							num2 = 21;
						}
						continue;
					}
					goto case 7;
				case 15:
					NextToken();
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
					{
						num2 = 1;
					}
					continue;
				case 18:
					ValidateToken(TokenId.OpenParen, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A6135BE ^ 0x3A613AC0));
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num2 = 15;
					}
					continue;
				case 3:
					num3++;
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num2 = 20;
					}
					continue;
				case 5:
					name = GetIdentifier();
					num = 22;
					break;
				case 19:
					NextToken();
					num2 = 18;
					continue;
				case 17:
					if (token.id == TokenId.Comma)
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
						{
							num2 = 8;
						}
						continue;
					}
					goto case 27;
				case 14:
				case 23:
					pos = token.pos;
					num2 = 6;
					continue;
				case 11:
					NextToken();
					num = 2;
					break;
				case 24:
					num3 = 0;
					num2 = 26;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num2 = 17;
					}
					continue;
				case 25:
				case 28:
					list.Add(expression);
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					array[num3] = (MemberBinding)GANVmVhzXKv1j6TbigI(type.GetProperty((string)XD37AshcvCgMSDA2yNL(list2[num3])), list[num3]);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
					{
						num2 = 0;
					}
					continue;
				case 10:
					NextToken();
					num2 = 5;
					continue;
				case 2:
					type = DynamicExpression.CreateClass(list2);
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
					{
						num2 = 10;
					}
					continue;
				case 27:
					ValidateToken(TokenId.CloseParen, (string)TZcomMhwloVeNRf8kPa(0x7E6E5A0B ^ 0x7E6E4825));
					num2 = 11;
					continue;
				case 16:
					if (!TokenIdentifierIs(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1459557599 ^ -1459553541)))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 10;
				default:
					name = ((expression as MemberExpression) ?? throw ParseError(pos, (string)TZcomMhwloVeNRf8kPa(0x4785BC0D ^ 0x4785ADEF))).Member.Name;
					num2 = 20;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
					{
						num2 = 25;
					}
					continue;
				}
				break;
			}
		}
	}

	private Expression ParseLambdaInvocation(LambdaExpression lambda)
	{
		int num = 3;
		int num2 = num;
		int pos = default(int);
		Expression[] array = default(Expression[]);
		while (true)
		{
			switch (num2)
			{
			case 3:
				pos = token.pos;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
				{
					num2 = 2;
				}
				continue;
			case 2:
				NextToken();
				num2 = 4;
				continue;
			case 1:
				throw ParseError(pos, (string)TZcomMhwloVeNRf8kPa(-1710575414 ^ -1710579038));
			case 4:
				array = ParseArgumentList();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
				{
					num2 = 0;
				}
				continue;
			}
			if (FindMethod(xNfa4VhMkUhKyv7OK94(lambda), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107974074), staticAccess: false, array, out var _) == 1)
			{
				return (Expression)AZJNBCGWK3MyRIawtWo(lambda, array);
			}
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
			{
				num2 = 1;
			}
		}
	}

	private Expression ParseTypeAccess(Type type)
	{
		//Discarded unreachable code: IL_0098, IL_00ab, IL_00cf
		int num = 8;
		int num2 = num;
		int num3 = default(int);
		MethodBase method = default(MethodBase);
		Expression[] array = default(Expression[]);
		int pos = default(int);
		while (true)
		{
			switch (num2)
			{
			case 5:
				return ParseMemberAccess(type, null);
			case 6:
				if (num3 != 1)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
					{
						num2 = 1;
					}
					break;
				}
				return (Expression)Fi0OPoGbin4DuNpQQSb((ConstructorInfo)method, array);
			case 15:
				if (!type.IsValueType)
				{
					num2 = 18;
					break;
				}
				goto case 10;
			case 2:
				NextToken();
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
				{
					num2 = 0;
				}
				break;
			case 17:
				if (num3 != 0)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num2 = 6;
					}
					break;
				}
				goto case 4;
			case 11:
				num3 = FindBestMethod(type.GetConstructors(), array, out method);
				num2 = 17;
				break;
			case 4:
				if (array.Length == 1)
				{
					num2 = 16;
					break;
				}
				throw ParseError(pos, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345415980), stYXaUh085EWUoWhgat(type));
			case 14:
				if (token.id == TokenId.OpenParen)
				{
					num2 = 13;
					break;
				}
				ValidateToken(TokenId.Dot, (string)TZcomMhwloVeNRf8kPa(0x18A6761F ^ 0x18A665AB));
				num2 = 2;
				break;
			case 12:
				NextToken();
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
				{
					num2 = 14;
				}
				break;
			default:
				if (token.id == TokenId.Question)
				{
					num2 = 15;
					break;
				}
				goto case 14;
			case 13:
				array = ParseArgumentList();
				num2 = 11;
				break;
			case 10:
				if (!TNnRioGoMVKlM0VpPWH(type))
				{
					num2 = 9;
					break;
				}
				goto case 3;
			case 16:
				return GenerateConversion(array[0], type, pos);
			case 1:
				throw ParseError(pos, (string)TZcomMhwloVeNRf8kPa(-488881205 ^ -488877931), stYXaUh085EWUoWhgat(type));
			case 8:
				pos = token.pos;
				num2 = 7;
				break;
			case 7:
				NextToken();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
			case 18:
				throw ParseError(pos, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488877819), stYXaUh085EWUoWhgat(type));
			case 9:
				type = KAF1pPhmquc8fUailtM(typeof(Nullable<>).TypeHandle).MakeGenericType(type);
				num2 = 12;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 9;
				}
				break;
			}
		}
	}

	private Expression GenerateConversion(Expression expr, Type type, int errorPos)
	{
		//Discarded unreachable code: IL_0089, IL_0098, IL_00a8, IL_0106, IL_013a, IL_018d, IL_019c, IL_01ac, IL_01bb, IL_0254, IL_027a, IL_0322
		int num = 15;
		Type type2 = default(Type);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
				case 7:
				case 17:
					return (Expression)j7VDV7hJ6wTVTBOdLNA(expr, type);
				case 20:
					if (!Io2IBDh9UNF0yjdyVXo(type2))
					{
						num2 = 8;
						continue;
					}
					goto case 11;
				case 16:
				case 19:
					if (!JjQQTHhdFqCPEsKhvWZ(sf4koeGhqdpuOwGl0td(type2), sf4koeGhqdpuOwGl0td(type)))
					{
						num = 9;
						break;
					}
					goto case 2;
				case 4:
					if (!type.IsValueType)
					{
						num = 25;
						break;
					}
					goto case 22;
				case 6:
					if (type2.IsInterface)
					{
						num2 = 7;
						continue;
					}
					goto case 3;
				case 11:
				case 24:
					if (wWMmdxGG3QByaxCRm6Y(type))
					{
						num2 = 10;
						continue;
					}
					goto case 5;
				case 22:
					if (TNnRioGoMVKlM0VpPWH(type2))
					{
						num2 = 19;
						continue;
					}
					goto default;
				case 13:
					return expr;
				case 15:
					type2 = expr.Type;
					num2 = 14;
					continue;
				case 5:
				case 8:
					if (!Io2IBDh9UNF0yjdyVXo(type))
					{
						num2 = 12;
						continue;
					}
					goto case 10;
				default:
					if (IsNullableType(type))
					{
						num2 = 16;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
						{
							num2 = 11;
						}
						continue;
					}
					goto case 9;
				case 14:
					if (!JjQQTHhdFqCPEsKhvWZ(type2, type))
					{
						if (!type2.IsValueType)
						{
							num2 = 23;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
							{
								num2 = 20;
							}
							continue;
						}
						goto case 4;
					}
					num2 = 13;
					continue;
				case 18:
					if (type.IsAssignableFrom(type2))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 6;
				case 3:
					if (!type.IsInterface)
					{
						throw ParseError(errorPos, (string)TZcomMhwloVeNRf8kPa(-105199646 ^ -105196484), stYXaUh085EWUoWhgat(type2), stYXaUh085EWUoWhgat(type));
					}
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
					{
						num2 = 17;
					}
					continue;
				case 2:
					return (Expression)j7VDV7hJ6wTVTBOdLNA(expr, type);
				case 9:
					if (wWMmdxGG3QByaxCRm6Y(type2))
					{
						num2 = 24;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
						{
							num2 = 22;
						}
						continue;
					}
					goto case 20;
				case 10:
				case 21:
					return (Expression)dZZnnPGEHLVNIqwWNiT(expr, type);
				case 12:
				case 23:
				case 25:
					if (!type2.IsAssignableFrom(type))
					{
						num2 = 18;
						continue;
					}
					goto case 1;
				}
				break;
			}
		}
	}

	private Expression ParseMemberAccess(Type type, Expression instance)
	{
		//Discarded unreachable code: IL_008d, IL_01f6, IL_0205, IL_0215, IL_0224, IL_0322, IL_042b, IL_043a
		int num = 4;
		int pos = default(int);
		string identifier = default(string);
		MethodInfo methodInfo = default(MethodInfo);
		Expression[] array = default(Expression[]);
		Type type2 = default(Type);
		Type elementType = default(Type);
		MemberInfo memberInfo = default(MemberInfo);
		int num3 = default(int);
		MethodBase method = default(MethodBase);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					throw ParseError(pos, (string)TZcomMhwloVeNRf8kPa(0x49E27B8A ^ 0x49E26E8C), identifier, stYXaUh085EWUoWhgat(methodInfo.DeclaringType));
				case 17:
					return (Expression)i8nGnDGQRSscQIHrQM8(instance, methodInfo, array);
				case 15:
					throw ParseError(pos, (string)TZcomMhwloVeNRf8kPa(-35995181 ^ -35990339), identifier, stYXaUh085EWUoWhgat(type));
				case 18:
					throw ParseError(pos, (string)TZcomMhwloVeNRf8kPa(0x53CB464B ^ 0x53CB539D), identifier, stYXaUh085EWUoWhgat(type));
				case 24:
					throw ParseError(pos, (string)TZcomMhwloVeNRf8kPa(-542721635 ^ -542724817), stYXaUh085EWUoWhgat(nufyg4GfPZpS2Cxr7U8(methodInfo)));
				case 8:
					type2 = FindGenericType(KAF1pPhmquc8fUailtM(typeof(IEnumerable<>).TypeHandle), type);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 0;
					}
					continue;
				case 20:
					return ParseAggregate(instance, elementType, identifier, pos);
				case 7:
					array = ParseArgumentList();
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num2 = 21;
					}
					continue;
				case 13:
					return (Expression)U33gD2GvC8qSF0CFLpv(instance, (FieldInfo)memberInfo);
				case 5:
					return Expression.Property(instance, (PropertyInfo)memberInfo);
				case 11:
					identifier = GetIdentifier();
					num = 6;
					break;
				case 10:
					if (token.id != TokenId.OpenParen)
					{
						memberInfo = FindPropertyOrField(type, identifier, instance == null);
						num2 = 12;
						continue;
					}
					num2 = 23;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
				case 19:
					throw ParseError(pos, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x61EC0CB8 ^ 0x61EC18E8), identifier, GetTypeName(type));
				case 6:
					NextToken();
					num2 = 10;
					continue;
				case 12:
					if (!wpLy1BGCndfypRCWO1L(memberInfo, null))
					{
						if (memberInfo is PropertyInfo)
						{
							num = 5;
							break;
						}
						goto case 13;
					}
					num2 = 18;
					continue;
				case 21:
					num3 = FindMethod(type, identifier, instance == null, array, out method);
					num2 = 25;
					continue;
				case 23:
					if (instance != null)
					{
						num2 = 9;
						continue;
					}
					goto case 7;
				case 4:
					if (instance != null)
					{
						num = 3;
						break;
					}
					goto case 14;
				case 9:
					if (!i3sRlhhxItMoQagKgRK(type, KAF1pPhmquc8fUailtM(typeof(string).TypeHandle)))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto case 8;
				case 25:
					if (num3 == 0)
					{
						num2 = 16;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
						{
							num2 = 19;
						}
						continue;
					}
					goto case 22;
				case 26:
					elementType = type2.GetGenericArguments()[0];
					num2 = 20;
					continue;
				case 16:
					if (IsPredefinedType(nufyg4GfPZpS2Cxr7U8(methodInfo)))
					{
						if (!(methodInfo.ReturnType == KAF1pPhmquc8fUailtM(typeof(void).TypeHandle)))
						{
							num = 17;
							break;
						}
						goto case 1;
					}
					num2 = 24;
					continue;
				case 22:
					if (num3 == 1)
					{
						methodInfo = (MethodInfo)method;
						num2 = 16;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
						{
							num2 = 4;
						}
					}
					else
					{
						num2 = 15;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
						{
							num2 = 5;
						}
					}
					continue;
				case 14:
					pos = token.pos;
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
					{
						num2 = 11;
					}
					continue;
				case 3:
					type = instance.Type;
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
					{
						num2 = 14;
					}
					continue;
				default:
					if (type2 != null)
					{
						num2 = 26;
						continue;
					}
					goto case 7;
				}
				break;
			}
		}
	}

	private static Type FindGenericType(Type generic, Type type)
	{
		//Discarded unreachable code: IL_008a, IL_0099, IL_00a8, IL_01a5, IL_01b4, IL_01c4, IL_01ea, IL_01f9, IL_0209, IL_0218, IL_0227
		int num = 8;
		Type type2 = default(Type);
		Type[] interfaces = default(Type[]);
		int num3 = default(int);
		Type type3 = default(Type);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					type2 = interfaces[num3];
					num2 = 11;
					continue;
				case 15:
					if (!i3sRlhhxItMoQagKgRK(type3, null))
					{
						num2 = 2;
						continue;
					}
					goto case 10;
				case 5:
				case 19:
					type = type.BaseType;
					num2 = 18;
					continue;
				case 3:
				case 21:
					if (num3 < interfaces.Length)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 5;
				case 7:
				case 14:
					if (type.IsGenericType)
					{
						num = 12;
						break;
					}
					goto case 6;
				case 12:
					if (!JjQQTHhdFqCPEsKhvWZ(type.GetGenericTypeDefinition(), generic))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 17;
				case 16:
					interfaces = type.GetInterfaces();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
					{
						num2 = 1;
					}
					continue;
				case 10:
					return type3;
				case 2:
					num3++;
					num2 = 21;
					continue;
				case 8:
				case 18:
					if (!i3sRlhhxItMoQagKgRK(type, null))
					{
						num2 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
						{
							num2 = 20;
						}
						continue;
					}
					goto case 13;
				case 17:
					return type;
				case 6:
					if (!generic.IsInterface)
					{
						num2 = 19;
						continue;
					}
					goto case 16;
				case 1:
					num3 = 0;
					num = 3;
					break;
				case 9:
				case 20:
					return null;
				case 11:
					type3 = xicM9VG8aF6bXXvuQR2(generic, type2);
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
					{
						num2 = 4;
					}
					continue;
				case 13:
					if (i3sRlhhxItMoQagKgRK(type, KAF1pPhmquc8fUailtM(typeof(object).TypeHandle)))
					{
						num2 = 14;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
						{
							num2 = 14;
						}
						continue;
					}
					goto case 9;
				}
				break;
			}
		}
	}

	private Expression ParseAggregate(Expression instance, Type elementType, string methodName, int errorPos)
	{
		//Discarded unreachable code: IL_0125, IL_0156, IL_0165, IL_0174, IL_0242, IL_0251
		int num = 2;
		MethodBase method = default(MethodBase);
		Type[] array2 = default(Type[]);
		Expression[] array = default(Expression[]);
		ParameterExpression parameterExpression2 = default(ParameterExpression);
		ParameterExpression parameterExpression = default(ParameterExpression);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
				case 13:
					return (Expression)VHg54LGIC2SWgIt8OZ7(typeof(Enumerable), UXWy9khU64Y7m676YRf(method), array2, array);
				case 10:
				case 11:
					array = new Expression[2]
					{
						instance,
						Expression.Lambda(array[0], parameterExpression2)
					};
					num = 13;
					break;
				case 1:
					parameterExpression2 = (ParameterExpression)US6aAkGZM6smVMK28FU(elementType, "");
					num2 = 3;
					continue;
				case 4:
					if (AJYpf9Guxe4ohobF9cA(method.Name, TZcomMhwloVeNRf8kPa(-477139494 ^ -477136058)))
					{
						num = 17;
						break;
					}
					goto case 7;
				case 16:
					if (FindMethod(KAF1pPhmquc8fUailtM(typeof(IEnumerableSignatures).TypeHandle), methodName, staticAccess: false, array, out method) != 1)
					{
						num = 12;
						break;
					}
					if (AJYpf9Guxe4ohobF9cA(UXWy9khU64Y7m676YRf(method), TZcomMhwloVeNRf8kPa(-787452571 ^ -787448841)))
					{
						num2 = 15;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto case 4;
				case 2:
					parameterExpression = it;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num2 = 0;
					}
					continue;
				case 12:
					throw ParseError(errorPos, (string)TZcomMhwloVeNRf8kPa(-561074844 ^ -561071268), methodName);
				case 3:
					it = parameterExpression2;
					num2 = 9;
					continue;
				default:
					if (array.Length != 0)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
						{
							num2 = 11;
						}
						continue;
					}
					goto case 14;
				case 14:
					array = new Expression[1] { instance };
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
					{
						num2 = 5;
					}
					continue;
				case 8:
					it = parameterExpression;
					num2 = 16;
					continue;
				case 15:
				case 17:
					array2 = new Type[2]
					{
						elementType,
						xNfa4VhMkUhKyv7OK94(array[0])
					};
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					array2 = new Type[1] { elementType };
					num = 6;
					break;
				case 9:
					array = ParseArgumentList();
					num2 = 8;
					continue;
				}
				break;
			}
		}
	}

	private Expression[] ParseArgumentList()
	{
		//Discarded unreachable code: IL_0057
		int num = 1;
		int num2 = num;
		Expression[] result;
		while (true)
		{
			switch (num2)
			{
			default:
				NextToken();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num2 = 2;
				}
				continue;
			case 3:
				result = new Expression[0];
				break;
			case 1:
				ValidateToken(TokenId.OpenParen, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281844794));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				if (token.id == TokenId.CloseParen)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				result = ParseArguments();
				break;
			}
			break;
		}
		ValidateToken(TokenId.CloseParen, (string)TZcomMhwloVeNRf8kPa(-1870892489 ^ -1870897127));
		NextToken();
		return result;
	}

	private Expression[] ParseArguments()
	{
		//Discarded unreachable code: IL_0089
		int num = 4;
		int num2 = num;
		List<Expression> list = default(List<Expression>);
		while (true)
		{
			switch (num2)
			{
			case 5:
				return (Expression[])nQljjAGVO5bmkogFQLi(list);
			case 4:
				list = new List<Expression>();
				num2 = 3;
				break;
			case 1:
			case 3:
				list.Add(ParseExpression());
				num2 = 2;
				break;
			default:
				NextToken();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				if (token.id == TokenId.Comma)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 5;
			}
		}
	}

	private Expression ParseElementAccess(Expression expr)
	{
		//Discarded unreachable code: IL_00b8, IL_00c7, IL_0302
		int num = 15;
		int num2 = num;
		int num3 = default(int);
		int pos = default(int);
		Expression[] array = default(Expression[]);
		Expression expression = default(Expression);
		MethodBase method = default(MethodBase);
		while (true)
		{
			switch (num2)
			{
			case 10:
				ValidateToken(TokenId.CloseBracket, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x638095EB ^ 0x6380834D));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
				{
					num2 = 0;
				}
				break;
			case 12:
				if (num3 != 0)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 7;
			case 9:
				throw ParseError(pos, (string)TZcomMhwloVeNRf8kPa(0x53FA00CE ^ 0x53FA161E));
			case 7:
				throw ParseError(pos, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-138018305 ^ -138013077), GetTypeName(xNfa4VhMkUhKyv7OK94(expr)));
			case 13:
				throw ParseError(pos, (string)TZcomMhwloVeNRf8kPa(-1870892489 ^ -1870895653), stYXaUh085EWUoWhgat(xNfa4VhMkUhKyv7OK94(expr)));
			case 11:
				array = ParseArguments();
				num2 = 10;
				break;
			case 14:
				ValidateToken(TokenId.OpenBracket, (string)TZcomMhwloVeNRf8kPa(0x66F566B6 ^ 0x66F569C8));
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
				{
					num2 = 7;
				}
				break;
			case 3:
				if (xNfa4VhMkUhKyv7OK94(expr).GetArrayRank() == 1)
				{
					num2 = 2;
					break;
				}
				goto case 9;
			case 15:
				pos = token.pos;
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num2 = 14;
				}
				break;
			case 1:
				throw ParseError(pos, (string)TZcomMhwloVeNRf8kPa(0x53CB464B ^ 0x53CB5175));
			case 4:
				return Expression.ArrayIndex(expr, expression);
			case 5:
				if (num3 == 1)
				{
					return (Expression)i8nGnDGQRSscQIHrQM8(expr, (MethodInfo)method, array);
				}
				num2 = 13;
				break;
			default:
				NextToken();
				num2 = 6;
				break;
			case 2:
				if (array.Length == 1)
				{
					expression = PromoteExpression(array[0], KAF1pPhmquc8fUailtM(typeof(int).TypeHandle), exact: true);
					num2 = 16;
					break;
				}
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
				{
					num2 = 0;
				}
				break;
			case 8:
				NextToken();
				num2 = 11;
				break;
			case 6:
				if (!xNfa4VhMkUhKyv7OK94(expr).IsArray)
				{
					num3 = FindIndexer(xNfa4VhMkUhKyv7OK94(expr), array, out method);
					num2 = 12;
					break;
				}
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
				{
					num2 = 3;
				}
				break;
			case 16:
				if (expression != null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 1;
			}
		}
	}

	private static bool IsPredefinedType(Type type)
	{
		//Discarded unreachable code: IL_008a, IL_0099, IL_00bc, IL_00cb
		int num = 6;
		int num2 = num;
		int num3 = default(int);
		Type[] array = default(Type[]);
		while (true)
		{
			switch (num2)
			{
			case 7:
				return true;
			case 5:
				num3 = 0;
				num2 = 3;
				continue;
			case 6:
				array = predefinedTypes;
				num2 = 5;
				continue;
			case 1:
				return false;
			case 3:
			case 4:
				if (num3 < array.Length)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 1;
			}
			if (JjQQTHhdFqCPEsKhvWZ(array[num3], type))
			{
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
				{
					num2 = 7;
				}
			}
			else
			{
				num3++;
				num2 = 4;
			}
		}
	}

	private static bool IsNullableType(Type type)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (type.IsGenericType)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return false;
			default:
				return JjQQTHhdFqCPEsKhvWZ(type.GetGenericTypeDefinition(), KAF1pPhmquc8fUailtM(typeof(Nullable<>).TypeHandle));
			}
		}
	}

	private static Type GetNonNullableType(Type type)
	{
		//Discarded unreachable code: IL_005d, IL_006c
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return type;
			case 1:
				return type.GetGenericArguments()[0];
			case 2:
				if (TNnRioGoMVKlM0VpPWH(type))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	private static string GetTypeName(Type type)
	{
		int num = 4;
		int num2 = num;
		Type type2 = default(Type);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (i3sRlhhxItMoQagKgRK(type, type2))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return text;
			case 4:
				type2 = sf4koeGhqdpuOwGl0td(type);
				num2 = 3;
				break;
			default:
				text = (string)UhP449h7vEDexhBCxa9(text, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C9495B4 ^ 0x1C948DFE));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				text = (string)UXWy9khU64Y7m676YRf(type2);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private static bool IsNumericType(Type type)
	{
		return WhJhC3GSiv92ur0R5Yo(type) != 0;
	}

	private static bool IsSignedIntegralType(Type type)
	{
		return WhJhC3GSiv92ur0R5Yo(type) == 2;
	}

	private static bool IsUnsignedIntegralType(Type type)
	{
		return WhJhC3GSiv92ur0R5Yo(type) == 3;
	}

	private static int GetNumericTypeKind(Type type)
	{
		//Discarded unreachable code: IL_00da, IL_00e9
		int num = 1;
		int num2 = num;
		TypeCode typeCode = default(TypeCode);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return 1;
			case 3:
				return 0;
			case 1:
				type = sf4koeGhqdpuOwGl0td(type);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
				{
					num2 = 0;
				}
				continue;
			case 4:
				return 0;
			case 5:
				switch (typeCode)
				{
				case TypeCode.Char:
				case TypeCode.Single:
				case TypeCode.Double:
				case TypeCode.Decimal:
					break;
				case TypeCode.SByte:
				case TypeCode.Int16:
				case TypeCode.Int32:
				case TypeCode.Int64:
					return 2;
				case TypeCode.Byte:
				case TypeCode.UInt16:
				case TypeCode.UInt32:
				case TypeCode.UInt64:
					return 3;
				default:
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
					{
						num2 = 3;
					}
					continue;
				}
				goto case 2;
			}
			if (!type.IsEnum)
			{
				typeCode = Type.GetTypeCode(type);
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
				{
					num2 = 4;
				}
			}
			else
			{
				num2 = 4;
			}
		}
	}

	private static bool IsEnumType(Type type)
	{
		return sf4koeGhqdpuOwGl0td(type).IsEnum;
	}

	private void CheckAndPromoteOperand(Type signatures, string opName, ref Expression expr, int errorPos)
	{
		int num = 3;
		int num2 = num;
		Expression[] array = default(Expression[]);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				throw ParseError(errorPos, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70000805), opName, stYXaUh085EWUoWhgat(xNfa4VhMkUhKyv7OK94(array[0])));
			case 2:
			{
				if (FindMethod(signatures, (string)TZcomMhwloVeNRf8kPa(-87337865 ^ -87339993), staticAccess: false, array, out var _) == 1)
				{
					expr = array[0];
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num2 = 0;
					}
				}
				break;
			}
			case 0:
				return;
			case 3:
				array = new Expression[1] { expr };
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private void CheckAndPromoteOperands(Type signatures, string opName, ref Expression left, ref Expression right, int errorPos)
	{
		int num = 1;
		int num2 = num;
		Expression[] array = default(Expression[]);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				array = new Expression[2] { left, right };
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
				{
					num2 = 0;
				}
				break;
			default:
			{
				if (FindMethod(signatures, (string)TZcomMhwloVeNRf8kPa(-1939377524 ^ -1939379492), staticAccess: false, array, out var _) != 1)
				{
					num2 = 4;
					break;
				}
				left = array[0];
				num2 = 3;
				break;
			}
			case 3:
				right = array[1];
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
				{
					num2 = 2;
				}
				break;
			case 4:
				throw IncompatibleOperandsError(opName, left, right, errorPos);
			}
		}
	}

	private Exception IncompatibleOperandsError(string opName, Expression left, Expression right, int pos)
	{
		return ParseError(pos, (string)TZcomMhwloVeNRf8kPa(0x63ABA4E8 ^ 0x63ABBC28), opName, stYXaUh085EWUoWhgat(xNfa4VhMkUhKyv7OK94(left)), stYXaUh085EWUoWhgat(xNfa4VhMkUhKyv7OK94(right)));
	}

	private MemberInfo FindPropertyOrField(Type type, string memberName, bool staticAccess)
	{
		//Discarded unreachable code: IL_0037, IL_0046, IL_0051, IL_00e6, IL_00f5, IL_0126, IL_015e, IL_016d
		int num = 1;
		int num2 = num;
		IEnumerator<Type> enumerator = default(IEnumerator<Type>);
		MemberInfo result = default(MemberInfo);
		MemberInfo[] array = default(MemberInfo[]);
		BindingFlags bindingAttr = default(BindingFlags);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return null;
			case 3:
				try
				{
					while (true)
					{
						int num3;
						if (!ldp1IJGi5QyVT4i2JIZ(enumerator))
						{
							num3 = 2;
							goto IL_0055;
						}
						goto IL_00bf;
						IL_0055:
						while (true)
						{
							switch (num3)
							{
							case 4:
								return result;
							case 5:
								if (array.Length != 0)
								{
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
									{
										num3 = 1;
									}
									continue;
								}
								break;
							case 1:
								result = array[0];
								num3 = 4;
								continue;
							case 3:
								goto IL_00bf;
							case 2:
								goto end_IL_00a9;
							}
							break;
						}
						continue;
						IL_00bf:
						array = enumerator.Current.FindMembers(MemberTypes.Field | MemberTypes.Property, bindingAttr, Type.FilterNameIgnoreCase, memberName);
						num3 = 5;
						goto IL_0055;
						continue;
						end_IL_00a9:
						break;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								fMBpO3GRbi1fwKK0v55(enumerator);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
								{
									num4 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
				goto case 2;
			default:
				enumerator = SelfAndBaseTypes(type).GetEnumerator();
				num2 = 3;
				break;
			case 1:
				bindingAttr = BindingFlags.DeclaredOnly | BindingFlags.Public | (staticAccess ? BindingFlags.Static : BindingFlags.Instance);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private int FindMethod(Type type, string methodName, bool staticAccess, Expression[] args, out MethodBase method)
	{
		//Discarded unreachable code: IL_0059, IL_0068, IL_0073, IL_011f, IL_0155, IL_0195, IL_01a4, IL_01b0, IL_01bf
		int num = 3;
		int num2 = num;
		IEnumerator<Type> enumerator = default(IEnumerator<Type>);
		int result = default(int);
		int num4 = default(int);
		MemberInfo[] source = default(MemberInfo[]);
		BindingFlags bindingAttr = default(BindingFlags);
		while (true)
		{
			switch (num2)
			{
			case 4:
				method = null;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				return 0;
			default:
				try
				{
					while (true)
					{
						IL_0129:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 4;
							goto IL_0077;
						}
						goto IL_00bb;
						IL_0077:
						while (true)
						{
							switch (num3)
							{
							case 6:
								return result;
							case 5:
								result = num4;
								num3 = 6;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
								{
									num3 = 6;
								}
								continue;
							case 2:
								num4 = FindBestMethod(source.Cast<MethodBase>(), args, out method);
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
								{
									num3 = 1;
								}
								continue;
							case 1:
								if (num4 != 0)
								{
									num3 = 5;
									continue;
								}
								goto IL_0129;
							case 3:
								goto IL_0129;
							case 4:
								goto end_IL_0129;
							}
							break;
						}
						goto IL_00bb;
						IL_00bb:
						source = enumerator.Current.FindMembers(MemberTypes.Method, bindingAttr, Type.FilterNameIgnoreCase, methodName);
						num3 = 2;
						goto IL_0077;
						continue;
						end_IL_0129:
						break;
					}
				}
				finally
				{
					int num5;
					if (enumerator == null)
					{
						num5 = 2;
						goto IL_0159;
					}
					goto IL_016f;
					IL_0159:
					switch (num5)
					{
					case 2:
						goto end_IL_0144;
					case 1:
						goto end_IL_0144;
					}
					goto IL_016f;
					IL_016f:
					fMBpO3GRbi1fwKK0v55(enumerator);
					num5 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
					{
						num5 = 1;
					}
					goto IL_0159;
					end_IL_0144:;
				}
				goto case 4;
			case 2:
				enumerator = SelfAndBaseTypes(type).GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				bindingAttr = BindingFlags.DeclaredOnly | BindingFlags.Public | (staticAccess ? BindingFlags.Static : BindingFlags.Instance);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private int FindIndexer(Type type, Expression[] args, out MethodBase method)
	{
		//Discarded unreachable code: IL_006f, IL_0079, IL_00b4, IL_00d5, IL_00e4, IL_021d, IL_0255, IL_0264
		int num = 2;
		IEnumerator<Type> enumerator = default(IEnumerator<Type>);
		MemberInfo[] defaultMembers = default(MemberInfo[]);
		int result = default(int);
		int num4 = default(int);
		IEnumerable<MethodBase> methods = default(IEnumerable<MethodBase>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					return 0;
				case 2:
					enumerator = SelfAndBaseTypes(type).GetEnumerator();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					try
					{
						while (true)
						{
							int num3;
							if (!ldp1IJGi5QyVT4i2JIZ(enumerator))
							{
								num3 = 6;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
								{
									num3 = 5;
								}
								goto IL_007d;
							}
							goto IL_014c;
							IL_014c:
							defaultMembers = enumerator.Current.GetDefaultMembers();
							num3 = 5;
							goto IL_007d;
							IL_007d:
							while (true)
							{
								switch (num3)
								{
								case 7:
									return result;
								case 2:
									result = num4;
									num3 = 7;
									continue;
								case 1:
									num4 = FindBestMethod(methods, args, out method);
									num3 = 4;
									continue;
								case 4:
									if (num4 == 0)
									{
										num3 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
										{
											num3 = 0;
										}
										continue;
									}
									goto case 2;
								case 3:
									goto IL_014c;
								case 5:
									if (defaultMembers.Length != 0)
									{
										num3 = 3;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
										{
											num3 = 9;
										}
										continue;
									}
									break;
								case 9:
									methods = from p in defaultMembers.OfType<PropertyInfo>()
										select (MethodBase)_003C_003Ec.nh27oCf6rbdg64ZenNfM(p) into m
										where _003C_003Ec.O621GAf6g3fZ80Aqx2Mk(m, null)
										select m;
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
									{
										num3 = 1;
									}
									continue;
								case 6:
									goto end_IL_0105;
								}
								break;
							}
							continue;
							end_IL_0105:
							break;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
							{
								num5 = 0;
							}
							while (true)
							{
								switch (num5)
								{
								default:
									fMBpO3GRbi1fwKK0v55(enumerator);
									num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
									{
										num5 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					break;
				}
				break;
			}
			method = null;
			num = 3;
		}
	}

	private static IEnumerable<Type> SelfAndBaseTypes(Type type)
	{
		if (type.IsInterface)
		{
			List<Type> list = new List<Type>();
			AddInterface(list, type);
			return list;
		}
		return SelfAndBaseClasses(type);
	}

	[IteratorStateMachine(typeof(_003CSelfAndBaseClasses_003Ed__78))]
	private static IEnumerable<Type> SelfAndBaseClasses(Type type)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CSelfAndBaseClasses_003Ed__78(-2)
		{
			_003C_003E3__type = type
		};
	}

	private static void AddInterface(List<Type> types, Type type)
	{
		if (!types.Contains(type))
		{
			types.Add(type);
			Type[] interfaces = type.GetInterfaces();
			foreach (Type type2 in interfaces)
			{
				AddInterface(types, type2);
			}
		}
	}

	private int FindBestMethod(IEnumerable<MethodBase> methods, Expression[] args, out MethodBase method)
	{
		_003C_003Ec__DisplayClass81_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass81_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.args = args;
		CS_0024_003C_003E8__locals0.applicable = (from m in methods
			select new MethodData
			{
				MethodBase = m,
				Parameters = _003C_003Ec.msVZh3f65R5rjgAHNA3W(m)
			} into m
			where CS_0024_003C_003E8__locals0._003C_003E4__this.IsApplicable(m, CS_0024_003C_003E8__locals0.args)
			select m).ToArray();
		if (CS_0024_003C_003E8__locals0.applicable.Length > 1)
		{
			CS_0024_003C_003E8__locals0.applicable = CS_0024_003C_003E8__locals0.applicable.Where(delegate(MethodData m)
			{
				int num = 3;
				int num2 = num;
				_003C_003Ec__DisplayClass81_1 _003C_003Ec__DisplayClass81_ = default(_003C_003Ec__DisplayClass81_1);
				while (true)
				{
					switch (num2)
					{
					case 1:
						_003C_003Ec__DisplayClass81_.m = m;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
						{
							num2 = 0;
						}
						break;
					case 3:
						_003C_003Ec__DisplayClass81_ = new _003C_003Ec__DisplayClass81_1();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
						{
							num2 = 2;
						}
						break;
					default:
						return CS_0024_003C_003E8__locals0.applicable.All(_003C_003Ec__DisplayClass81_._003CFindBestMethod_003Eb__3);
					case 2:
						_003C_003Ec__DisplayClass81_.CS_0024_003C_003E8__locals1 = CS_0024_003C_003E8__locals0;
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
						{
							num2 = 1;
						}
						break;
					}
				}
			}).ToArray();
		}
		if (CS_0024_003C_003E8__locals0.applicable.Length == 1)
		{
			MethodData methodData = CS_0024_003C_003E8__locals0.applicable[0];
			for (int i = 0; i < CS_0024_003C_003E8__locals0.args.Length; i++)
			{
				CS_0024_003C_003E8__locals0.args[i] = (Expression)((object[])methodData.Args)[i];
			}
			method = (MethodBase)methodData.MethodBase;
		}
		else
		{
			method = null;
		}
		return CS_0024_003C_003E8__locals0.applicable.Length;
	}

	private bool IsApplicable(MethodData method, Expression[] args)
	{
		//Discarded unreachable code: IL_007b, IL_0187
		int num = 2;
		Expression[] array = default(Expression[]);
		int num3 = default(int);
		ParameterInfo parameterInfo = default(ParameterInfo);
		Expression expression = default(Expression);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					return true;
				case 7:
					return false;
				case 9:
					method.Args = array;
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
					{
						num2 = 8;
					}
					continue;
				case 2:
					if (((Array)method.Parameters).Length != args.Length)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
						{
							num2 = 1;
						}
						continue;
					}
					array = new Expression[args.Length];
					num = 11;
					break;
				default:
					if (num3 < args.Length)
					{
						num2 = 10;
						continue;
					}
					goto case 9;
				case 1:
					return false;
				case 4:
					num3++;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
				case 10:
					parameterInfo = (ParameterInfo)((object[])method.Parameters)[num3];
					num = 3;
					break;
				case 3:
					if (!epG7hyGqA2M2eHroPVQ(parameterInfo))
					{
						expression = PromoteExpression(args[num3], parameterInfo.ParameterType, exact: false);
						num2 = 6;
					}
					else
					{
						num2 = 7;
					}
					continue;
				case 6:
					if (expression == null)
					{
						num2 = 13;
						continue;
					}
					array[num3] = expression;
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 3;
					}
					continue;
				case 13:
					return false;
				case 11:
					num3 = 0;
					num2 = 12;
					continue;
				}
				break;
			}
		}
	}

	private Expression PromoteExpression(Expression expr, Type type, bool exact)
	{
		//Discarded unreachable code: IL_00a6, IL_00b5, IL_00c4, IL_0133, IL_0168, IL_01c6, IL_0201, IL_0210, IL_0231, IL_0258, IL_0267, IL_0276, IL_02ab, IL_0377, IL_0386
		int num = 11;
		object obj = default(object);
		Type type2 = default(Type);
		string value = default(string);
		TypeCode typeCode = default(TypeCode);
		ConstantExpression constantExpression = default(ConstantExpression);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 28:
					obj = null;
					num2 = 4;
					break;
				default:
					if (!type.IsValueType)
					{
						num2 = 16;
						break;
					}
					goto case 1;
				case 22:
					type2 = sf4koeGhqdpuOwGl0td(type);
					num2 = 28;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num2 = 27;
					}
					break;
				case 27:
					return (Expression)ihkCtuGKbgQLsdAR7pg(obj, type);
				case 9:
				case 15:
				case 19:
					if (!yU3fV3Gn2T7jO4wHQUI(xNfa4VhMkUhKyv7OK94(expr), type))
					{
						goto end_IL_0012;
					}
					goto case 26;
				case 8:
				case 16:
					return (Expression)ihkCtuGKbgQLsdAR7pg(null, type);
				case 13:
					obj = SwLclmGTgRtJvlS5fPt(value, type2);
					num2 = 21;
					break;
				case 14:
					obj = F0vtwDGk3JQbAhpNZBu(value, type2);
					num2 = 24;
					break;
				case 1:
					if (!TNnRioGoMVKlM0VpPWH(type))
					{
						num2 = 15;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
						{
							num2 = 4;
						}
						break;
					}
					goto case 8;
				case 29:
					goto IL_01d0;
				case 20:
					return (Expression)j7VDV7hJ6wTVTBOdLNA(expr, type);
				case 2:
					return expr;
				case 25:
					return null;
				case 3:
				case 6:
				case 17:
				case 21:
				case 24:
					goto IL_021b;
				case 4:
					typeCode = a8JAGJGXKH2RUp32h9S(xNfa4VhMkUhKyv7OK94(constantExpression));
					num2 = 5;
					break;
				case 12:
					goto IL_0281;
				case 18:
					return expr;
				case 10:
					if (!(expr is ConstantExpression))
					{
						num2 = 19;
						break;
					}
					goto case 7;
				case 5:
					switch (typeCode)
					{
					case TypeCode.String:
						break;
					case TypeCode.Double:
						goto IL_01d0;
					case TypeCode.Single:
					case TypeCode.Decimal:
					case TypeCode.DateTime:
					case (TypeCode)17:
						goto IL_021b;
					case TypeCode.Int32:
					case TypeCode.UInt32:
					case TypeCode.Int64:
					case TypeCode.UInt64:
						goto IL_0281;
					default:
						goto IL_02fe;
					}
					goto case 14;
				case 11:
					if (!JjQQTHhdFqCPEsKhvWZ(expr.Type, type))
					{
						num2 = 10;
						break;
					}
					goto case 18;
				case 7:
					constantExpression = (ConstantExpression)expr;
					num2 = 23;
					break;
				case 26:
					if (!(type.IsValueType || exact))
					{
						num2 = 2;
						break;
					}
					goto case 20;
				case 23:
					{
						if (constantExpression != nullLiteral)
						{
							if (!literals.TryGetValue(constantExpression, out value))
							{
								num2 = 9;
								break;
							}
							goto case 22;
						}
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
						{
							num2 = 0;
						}
						break;
					}
					IL_02fe:
					num2 = 3;
					break;
					IL_0281:
					obj = SwLclmGTgRtJvlS5fPt(value, type2);
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 17;
					}
					break;
					IL_021b:
					if (obj != null)
					{
						num2 = 27;
						break;
					}
					goto case 9;
					IL_01d0:
					if (!(type2 == KAF1pPhmquc8fUailtM(typeof(decimal).TypeHandle)))
					{
						num2 = 6;
						break;
					}
					goto case 13;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 25;
		}
	}

	private static object ParseNumber(object text, Type type)
	{
		//Discarded unreachable code: IL_00df, IL_00ee, IL_012c, IL_013b, IL_016a, IL_0198, IL_0295, IL_02a4, IL_02d3, IL_02e6, IL_02f5, IL_032e, IL_033d
		int num = 20;
		int num2 = num;
		int result10 = default(int);
		byte result5 = default(byte);
		long result = default(long);
		uint result4 = default(uint);
		double result6 = default(double);
		TypeCode typeCode = default(TypeCode);
		ushort result3 = default(ushort);
		short result2 = default(short);
		ulong result7 = default(ulong);
		float result8 = default(float);
		sbyte result9 = default(sbyte);
		decimal result11 = default(decimal);
		while (true)
		{
			switch (num2)
			{
			case 17:
				return result10;
			case 9:
				return result5;
			case 13:
				return result;
			case 23:
				return result4;
			case 7:
				return result6;
			case 19:
				switch (typeCode)
				{
				case TypeCode.UInt32:
					break;
				case TypeCode.Int16:
					goto IL_00b3;
				case TypeCode.UInt64:
					goto IL_0100;
				case TypeCode.Int64:
					goto IL_014e;
				case TypeCode.Decimal:
					goto IL_017c;
				default:
					goto IL_01db;
				case TypeCode.Int32:
					goto IL_01ed;
				case TypeCode.UInt16:
					goto IL_020c;
				case TypeCode.SByte:
					goto IL_024a;
				case TypeCode.Single:
					goto IL_0269;
				case TypeCode.Double:
					goto IL_02b7;
				case TypeCode.Byte:
					goto IL_0308;
				}
				if (!uint.TryParse((string)text, out result4))
				{
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 15;
					}
					continue;
				}
				goto case 23;
			case 21:
				return result3;
			default:
				return result2;
			case 20:
				typeCode = Type.GetTypeCode(sf4koeGhqdpuOwGl0td(type));
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num2 = 19;
				}
				continue;
			case 16:
				goto IL_024a;
			case 18:
				return result7;
			case 11:
				return result8;
			case 5:
				return result9;
			case 12:
				return result11;
			case 1:
			case 2:
			case 3:
			case 4:
			case 6:
			case 8:
			case 10:
			case 14:
			case 15:
			case 22:
				break;
				IL_014e:
				if (!long.TryParse((string)text, out result))
				{
					num2 = 14;
					continue;
				}
				goto case 13;
				IL_0308:
				if (!byte.TryParse((string)text, out result5))
				{
					num2 = 22;
					continue;
				}
				goto case 9;
				IL_02b7:
				if (!double.TryParse((string)text, out result6))
				{
					num2 = 4;
					continue;
				}
				goto case 7;
				IL_0269:
				if (!float.TryParse((string)text, out result8))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto case 11;
				IL_00b3:
				if (short.TryParse((string)text, out result2))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
				IL_024a:
				if (!sbyte.TryParse((string)text, out result9))
				{
					num2 = 10;
					continue;
				}
				goto case 5;
				IL_020c:
				if (ushort.TryParse((string)text, out result3))
				{
					num2 = 21;
					continue;
				}
				break;
				IL_01ed:
				if (!int.TryParse((string)text, out result10))
				{
					num2 = 6;
					continue;
				}
				goto case 17;
				IL_01db:
				num2 = 3;
				continue;
				IL_017c:
				if (!decimal.TryParse((string)text, out result11))
				{
					num2 = 8;
					continue;
				}
				goto case 12;
				IL_0100:
				if (!ulong.TryParse((string)text, out result7))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto case 18;
			}
			break;
		}
		return null;
	}

	private static object ParseEnum(object name, Type type)
	{
		//Discarded unreachable code: IL_0072
		int num = 2;
		int num2 = num;
		MemberInfo[] array = default(MemberInfo[]);
		while (true)
		{
			switch (num2)
			{
			default:
				if (array.Length != 0)
				{
					num2 = 3;
					break;
				}
				goto case 1;
			case 4:
				array = type.FindMembers(MemberTypes.Field, BindingFlags.DeclaredOnly | BindingFlags.Static | BindingFlags.Public, Type.FilterNameIgnoreCase, name);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return QfgMoVGOu7abmasC3Ar((FieldInfo)array[0], null);
			case 1:
				return null;
			case 2:
				if (!type.IsEnum)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			}
		}
	}

	private static bool IsCompatibleWith(Type source, Type target)
	{
		//Discarded unreachable code: IL_00ad, IL_00e1, IL_020e, IL_021d, IL_022c, IL_02d9, IL_02e8, IL_0336, IL_0345, IL_0354, IL_036b, IL_0375, IL_0384, IL_0398, IL_03a7, IL_03d9, IL_03e8, IL_048e, IL_04cb
		int num = 28;
		TypeCode typeCode2 = default(TypeCode);
		Type type = default(Type);
		Type type2 = default(Type);
		TypeCode typeCode = default(TypeCode);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num4;
				int num3;
				switch (num2)
				{
				case 32:
					if ((uint)(typeCode2 - 13) > 2u)
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto case 16;
				case 20:
					return true;
				case 24:
					return true;
				case 23:
					if (JjQQTHhdFqCPEsKhvWZ(type, type2))
					{
						num2 = 31;
						continue;
					}
					goto IL_0391;
				case 11:
					return true;
				case 6:
					return true;
				case 18:
					return true;
				default:
					return true;
				case 5:
					return true;
				case 16:
					return true;
				case 1:
					if (!(type != source))
					{
						num2 = 26;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
						{
							num2 = 20;
						}
						continue;
					}
					goto case 7;
				case 15:
					if (!type2.IsEnum)
					{
						num2 = 24;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
						{
							num2 = 29;
						}
						continue;
					}
					num4 = 1;
					goto IL_04f8;
				case 34:
					return true;
				case 27:
					if (target.IsValueType)
					{
						num2 = 13;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto case 19;
				case 28:
					if (!JjQQTHhdFqCPEsKhvWZ(source, target))
					{
						num2 = 27;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
						{
							num2 = 25;
						}
						continue;
					}
					goto case 34;
				case 22:
					return false;
				case 26:
				case 33:
					if (type.IsEnum)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 21;
				case 30:
					goto IL_031b;
				case 29:
					num4 = (int)a8JAGJGXKH2RUp32h9S(type2);
					goto IL_04f8;
				case 31:
					return true;
				case 4:
				case 8:
				case 9:
				case 10:
				case 12:
				case 25:
					goto IL_0391;
				case 17:
					type2 = sf4koeGhqdpuOwGl0td(target);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
					goto IL_03f3;
				case 14:
					switch (typeCode)
					{
					case TypeCode.Single:
						break;
					case TypeCode.UInt32:
						goto IL_011e;
					case TypeCode.Int16:
						goto IL_0145;
					case TypeCode.Int32:
						goto IL_0182;
					case TypeCode.Int64:
						goto IL_01c4;
					case TypeCode.Byte:
						goto IL_01d9;
					case TypeCode.UInt64:
						goto IL_01f0;
					case TypeCode.UInt16:
						goto IL_031d;
					case TypeCode.SByte:
						goto IL_03f3;
					default:
						goto IL_046f;
					}
					if ((uint)(typeCode2 - 13) <= 1u)
					{
						num2 = 24;
						continue;
					}
					goto IL_0391;
				case 7:
					if (!JjQQTHhdFqCPEsKhvWZ(type2, target))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
						{
							num2 = 33;
						}
						continue;
					}
					goto case 22;
				case 21:
					num3 = (int)Type.GetTypeCode(type);
					goto IL_04eb;
				case 19:
					return target.IsAssignableFrom(source);
				case 13:
					type = sf4koeGhqdpuOwGl0td(source);
					num2 = 17;
					continue;
				case 3:
					{
						num3 = 1;
						goto IL_04eb;
					}
					IL_046f:
					num2 = 22;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 23;
					}
					continue;
					IL_031d:
					if ((uint)(typeCode2 - 8) <= 7u)
					{
						num2 = 18;
						continue;
					}
					goto IL_0391;
					IL_01f0:
					if ((uint)(typeCode2 - 12) > 3u)
					{
						num = 10;
						break;
					}
					goto case 20;
					IL_01d9:
					if ((uint)(typeCode2 - 6) > 9u)
					{
						num2 = 25;
						continue;
					}
					goto case 6;
					IL_01c4:
					if (typeCode2 != TypeCode.Int64)
					{
						num2 = 32;
						continue;
					}
					goto case 16;
					IL_0182:
					switch (typeCode2)
					{
					case TypeCode.Int32:
					case TypeCode.Int64:
					case TypeCode.Single:
					case TypeCode.Double:
					case TypeCode.Decimal:
						break;
					default:
						goto IL_01a8;
					case TypeCode.UInt32:
					case TypeCode.UInt64:
						goto IL_0391;
					}
					goto case 11;
					IL_01a8:
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
					{
						num2 = 3;
					}
					continue;
					IL_04f8:
					typeCode2 = (TypeCode)num4;
					num2 = 14;
					continue;
					IL_0145:
					switch (typeCode2)
					{
					case TypeCode.Int16:
					case TypeCode.Int32:
					case TypeCode.Int64:
					case TypeCode.Single:
					case TypeCode.Double:
					case TypeCode.Decimal:
						goto IL_031b;
					case TypeCode.UInt16:
					case TypeCode.UInt32:
					case TypeCode.UInt64:
						goto IL_0391;
					}
					num = 4;
					break;
					IL_011e:
					if ((uint)(typeCode2 - 10) <= 5u)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto IL_0391;
					IL_0391:
					return false;
					IL_03f3:
					switch (typeCode2)
					{
					case TypeCode.SByte:
					case TypeCode.Int16:
					case TypeCode.Int32:
					case TypeCode.Int64:
					case TypeCode.Single:
					case TypeCode.Double:
					case TypeCode.Decimal:
						break;
					case TypeCode.Byte:
					case TypeCode.UInt16:
					case TypeCode.UInt32:
					case TypeCode.UInt64:
						goto IL_0391;
					default:
						goto IL_0428;
					}
					goto case 5;
					IL_0428:
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
					{
						num2 = 12;
					}
					continue;
					IL_031b:
					return true;
					IL_04eb:
					typeCode = (TypeCode)num3;
					num2 = 15;
					continue;
				}
				break;
			}
		}
	}

	private static bool IsBetterThan(object args, object m1, object m2)
	{
		//Discarded unreachable code: IL_0055, IL_00ae, IL_00bd, IL_0125, IL_0158
		int num = 2;
		bool result = default(bool);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					result = false;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num2 = 1;
					}
					continue;
				case 7:
				case 11:
					num3++;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
					{
						num2 = 4;
					}
					continue;
				case 1:
					num3 = 0;
					num2 = 6;
					continue;
				case 12:
					if (num4 >= 0)
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
						{
							num2 = 8;
						}
						continue;
					}
					goto case 5;
				case 3:
				case 8:
					num4 = MJOJx5GeBNWaI8belE2(xNfa4VhMkUhKyv7OK94(((object[])args)[num3]), MZLpxVG2yWWaF4cWCFV(((object[])((MethodData)m1).Parameters)[num3]), ((ParameterInfo)((object[])((MethodData)m2).Parameters)[num3]).ParameterType);
					num2 = 12;
					continue;
				case 5:
					return false;
				case 10:
					if (num4 <= 0)
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
						{
							num2 = 11;
						}
						continue;
					}
					goto end_IL_0012;
				default:
					goto end_IL_0012;
				case 4:
				case 6:
					if (num3 < ((Array)args).Length)
					{
						num2 = 8;
						continue;
					}
					break;
				case 9:
					break;
				}
				return result;
				continue;
				end_IL_0012:
				break;
			}
			result = true;
			num = 7;
		}
	}

	private static int CompareConversions(Type s, Type t1, Type t2)
	{
		//Discarded unreachable code: IL_015c, IL_016b, IL_017b
		int num = 4;
		int num2 = num;
		bool flag = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return -1;
			case 8:
				if (aHIXgxGP6WrfmN3LWr7(t1))
				{
					num2 = 14;
					break;
				}
				goto case 10;
			case 12:
				flag = yU3fV3Gn2T7jO4wHQUI(t2, t1);
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
				{
					num2 = 7;
				}
				break;
			case 15:
				if (IsUnsignedIntegralType(t1))
				{
					num2 = 2;
					break;
				}
				goto IL_01c7;
			case 3:
				return 0;
			case 4:
				if (!JjQQTHhdFqCPEsKhvWZ(t1, t2))
				{
					if (JjQQTHhdFqCPEsKhvWZ(s, t1))
					{
						num2 = 6;
					}
					else if (!JjQQTHhdFqCPEsKhvWZ(s, t2))
					{
						flag2 = yU3fV3Gn2T7jO4wHQUI(t1, t2);
						num2 = 12;
					}
					else
					{
						num2 = 5;
					}
				}
				else
				{
					num2 = 3;
				}
				break;
			case 14:
				if (!mGwJmPG1v7F873XA3JN(t2))
				{
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
					{
						num2 = 2;
					}
					break;
				}
				goto default;
			case 13:
				return 1;
			case 5:
				return -1;
			case 7:
				if (flag2)
				{
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
					{
						num2 = 11;
					}
					break;
				}
				goto IL_0100;
			default:
				return 1;
			case 10:
				if (IsSignedIntegralType(t2))
				{
					num2 = 15;
					break;
				}
				goto IL_01c7;
			case 6:
				return 1;
			case 11:
				if (!flag)
				{
					num2 = 13;
					break;
				}
				goto IL_0100;
			case 2:
				return -1;
			case 9:
				{
					if (!flag2)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 8;
				}
				IL_0100:
				if (!flag)
				{
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num2 = 8;
					}
					break;
				}
				goto case 9;
				IL_01c7:
				return 0;
			}
		}
	}

	private Expression GenerateEqual(Expression left, Expression right)
	{
		return Expression.Equal(left, right);
	}

	private Expression GenerateNotEqual(Expression left, Expression right)
	{
		return Expression.NotEqual(left, right);
	}

	private Expression GenerateGreaterThan(Expression left, Expression right)
	{
		//Discarded unreachable code: IL_0061, IL_0070
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!JjQQTHhdFqCPEsKhvWZ(xNfa4VhMkUhKyv7OK94(left), KAF1pPhmquc8fUailtM(typeof(string).TypeHandle)))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return (Expression)MPoPDeGNFZZpadpS6Pr(GenerateStaticMethodCall(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824386339), left, right), JuDEY9hLMrnNBJuTbEA(0));
			default:
				return (Expression)MPoPDeGNFZZpadpS6Pr(left, right);
			}
		}
	}

	private Expression GenerateGreaterThanEqual(Expression left, Expression right)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return (Expression)bvQ26pG3Hn7EfWCCuvB(GenerateStaticMethodCall(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31326106 ^ 0x31327846), left, right), JuDEY9hLMrnNBJuTbEA(0));
			case 1:
				if (!JjQQTHhdFqCPEsKhvWZ(left.Type, typeof(string)))
				{
					return (Expression)bvQ26pG3Hn7EfWCCuvB(left, right);
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private Expression GenerateLessThan(Expression left, Expression right)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!JjQQTHhdFqCPEsKhvWZ(xNfa4VhMkUhKyv7OK94(left), typeof(string)))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return (Expression)qGrFlqGpXWQ6UGuaToE(GenerateStaticMethodCall((string)TZcomMhwloVeNRf8kPa(0x637E299B ^ 0x637E30DB), left, right), JuDEY9hLMrnNBJuTbEA(0));
			default:
				return (Expression)qGrFlqGpXWQ6UGuaToE(left, right);
			}
		}
	}

	private Expression GenerateLessThanEqual(Expression left, Expression right)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (JjQQTHhdFqCPEsKhvWZ(left.Type, KAF1pPhmquc8fUailtM(typeof(string).TypeHandle)))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
					{
						num2 = 0;
					}
					break;
				}
				return (Expression)t1ssLbGaMoDUW5Q3XHG(left, right);
			default:
				return (Expression)t1ssLbGaMoDUW5Q3XHG(GenerateStaticMethodCall((string)TZcomMhwloVeNRf8kPa(-1217523399 ^ -1217525639), left, right), JuDEY9hLMrnNBJuTbEA(0));
			}
		}
	}

	private Expression GenerateAdd(Expression left, Expression right)
	{
		//Discarded unreachable code: IL_0035, IL_0099, IL_00a8
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				return GenerateStaticMethodCall((string)TZcomMhwloVeNRf8kPa(-1837662597 ^ -1837668567), left, right);
			default:
				return (Expression)Qs1B6FGDGIY4UE5LPBr(left, right);
			case 1:
				if (!JjQQTHhdFqCPEsKhvWZ(left.Type, typeof(string)))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 3:
				if (!JjQQTHhdFqCPEsKhvWZ(xNfa4VhMkUhKyv7OK94(right), KAF1pPhmquc8fUailtM(typeof(string).TypeHandle)))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			}
		}
	}

	private Expression GenerateSubtract(Expression left, Expression right)
	{
		return (Expression)kxsNjVGtO7Prm79DpHF(left, right);
	}

	private Expression GenerateStringConcat(Expression left, Expression right)
	{
		return Expression.Call(null, KAF1pPhmquc8fUailtM(typeof(string).TypeHandle).GetMethod((string)TZcomMhwloVeNRf8kPa(0x571EA399 ^ 0x571EBACB), new Type[2]
		{
			KAF1pPhmquc8fUailtM(typeof(object).TypeHandle),
			KAF1pPhmquc8fUailtM(typeof(object).TypeHandle)
		}), new Expression[2] { left, right });
	}

	private MethodInfo GetStaticMethod(string methodName, Expression left, Expression right)
	{
		return xNfa4VhMkUhKyv7OK94(left).GetMethod(methodName, new Type[2]
		{
			xNfa4VhMkUhKyv7OK94(left),
			xNfa4VhMkUhKyv7OK94(right)
		});
	}

	private Expression GenerateStaticMethodCall(string methodName, Expression left, Expression right)
	{
		return (Expression)i8nGnDGQRSscQIHrQM8(null, GetStaticMethod(methodName, left, right), new Expression[2] { left, right });
	}

	private void SetTextPos(int pos)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				textPos = pos;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				ch = ((textPos < textLen) ? text[textPos] : '\0');
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void NextChar()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				textPos++;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				if (textPos < textLen)
				{
					num2 = 2;
					continue;
				}
				break;
			case 1:
				return;
			}
			ch = ((textPos < textLen) ? VWOixOh5aBfZJq1DmMl(text, textPos) : '\0');
			num2 = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
			{
				num2 = 0;
			}
		}
	}

	private void NextToken()
	{
		//Discarded unreachable code: IL_032d, IL_035c, IL_036b, IL_03a0, IL_03c1, IL_03d0, IL_0479, IL_0488, IL_0497, IL_04c3, IL_04fe, IL_050d, IL_05e4, IL_05f3, IL_0679, IL_06dd, IL_06ec, IL_071d, IL_072c, IL_0803, IL_0812, IL_093d, IL_095c, IL_096b, IL_097b, IL_098a, IL_099a, IL_09a9, IL_09d0, IL_0a25, IL_0a34, IL_0a44, IL_0a53, IL_0a62, IL_0a90, IL_0ac1, IL_0ad0, IL_0b17, IL_0b26, IL_0b78, IL_0c75, IL_0c9f, IL_0cae, IL_0d4b, IL_0df2, IL_0e01, IL_0e10, IL_0fe1, IL_0ff0, IL_0fff, IL_100e, IL_109a, IL_10a9, IL_10f6, IL_1105, IL_1114
		int num = 70;
		TokenId id = default(TokenId);
		int num3 = default(int);
		char c2 = default(char);
		char c = default(char);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 44:
					id = TokenId.DoubleEqual;
					num2 = 103;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
					{
						num2 = 105;
					}
					continue;
				case 133:
					token.text = (string)Lla0KjhjTGXZ124Xgfk(text, num3, textPos - num3);
					num2 = 102;
					continue;
				case 60:
					if (ch == '&')
					{
						num2 = 118;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
						{
							num2 = 112;
						}
						continue;
					}
					goto case 68;
				case 107:
					NextChar();
					num2 = 149;
					continue;
				case 17:
					ValidateDigit();
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
					{
						num2 = 10;
					}
					continue;
				case 11:
					NextChar();
					num2 = 50;
					continue;
				case 62:
					NextChar();
					num2 = 72;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num2 = 39;
					}
					continue;
				case 110:
					if (ch != 'E')
					{
						num2 = 54;
						continue;
					}
					goto case 147;
				case 127:
					id = TokenId.DoubleBar;
					num2 = 65;
					continue;
				case 119:
					id = TokenId.Plus;
					num = 128;
					break;
				case 144:
					if (ch == c2)
					{
						num2 = 40;
						continue;
					}
					goto case 62;
				case 22:
					NextChar();
					num2 = 17;
					continue;
				case 18:
				case 70:
					if (cj25XfGwEyX4Hil5xoo(ch))
					{
						num2 = 137;
						continue;
					}
					goto case 7;
				case 67:
					return;
				case 63:
					goto IL_041d;
				case 121:
					goto IL_043d;
				case 28:
					if (ch != '_')
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 35;
				case 73:
					id = TokenId.RealLiteral;
					num2 = 22;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num2 = 9;
					}
					continue;
				case 34:
					id = TokenId.LessGreater;
					num2 = 142;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 35;
					}
					continue;
				case 48:
					id = TokenId.CloseBracket;
					num2 = 122;
					continue;
				case 76:
					c = ch;
					num = 32;
					break;
				case 53:
					if (ch != 'F')
					{
						num2 = 81;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
						{
							num2 = 132;
						}
						continue;
					}
					goto default;
				case 120:
					id = TokenId.StringLiteral;
					num2 = 87;
					continue;
				case 104:
				case 116:
					if (textPos == textLen)
					{
						num2 = 74;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
						{
							num2 = 73;
						}
						continue;
					}
					goto case 4;
				case 50:
					if (ch != '+')
					{
						num2 = 111;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
						{
							num2 = 21;
						}
						continue;
					}
					goto case 89;
				case 129:
					NextChar();
					num = 44;
					break;
				case 54:
					if (ch == 'e')
					{
						num2 = 147;
						continue;
					}
					goto case 53;
				case 98:
					goto IL_05fe;
				case 74:
					id = TokenId.End;
					num2 = 49;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
					{
						num2 = 32;
					}
					continue;
				case 36:
					if (ch == '_')
					{
						num2 = 148;
						continue;
					}
					goto case 59;
				case 64:
					goto IL_0642;
				case 16:
					goto IL_0652;
				case 123:
					NextChar();
					num2 = 3;
					continue;
				case 132:
					if (ch == 'f')
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 8;
				case 84:
					id = TokenId.GreaterThan;
					num2 = 141;
					continue;
				case 41:
					goto IL_06c8;
				case 85:
					if (c != '[')
					{
						num2 = 150;
						continue;
					}
					goto case 134;
				case 130:
					id = TokenId.Dot;
					num2 = 15;
					continue;
				case 71:
					if (ch == '=')
					{
						num2 = 16;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
						{
							num2 = 123;
						}
						continue;
					}
					goto case 25;
				case 89:
					NextChar();
					num2 = 12;
					continue;
				case 30:
					id = TokenId.IntegerLiteral;
					num2 = 109;
					continue;
				case 101:
					if (ch == '=')
					{
						num2 = 69;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
						{
							num2 = 83;
						}
						continue;
					}
					goto case 84;
				case 143:
					NextChar();
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num2 = 48;
					}
					continue;
				case 114:
					if (ch == '=')
					{
						num2 = 24;
						continue;
					}
					goto case 56;
				case 103:
					if (ch == '.')
					{
						num2 = 73;
						continue;
					}
					goto case 110;
				case 95:
					id = TokenId.ExclamationEqual;
					num2 = 46;
					continue;
				case 51:
					if (ch != '@')
					{
						num2 = 36;
						continue;
					}
					goto case 35;
				case 80:
					id = TokenId.CloseParen;
					num2 = 49;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
					{
						num2 = 138;
					}
					continue;
				case 40:
					if (textPos == textLen)
					{
						num2 = 20;
						continue;
					}
					NextChar();
					num2 = 93;
					continue;
				case 69:
				case 137:
					NextChar();
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
					{
						num2 = 18;
					}
					continue;
				case 2:
				case 145:
					NextChar();
					num2 = 97;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
					{
						num2 = 37;
					}
					continue;
				case 147:
					id = TokenId.RealLiteral;
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
					{
						num2 = 10;
					}
					continue;
				case 83:
					NextChar();
					num2 = 100;
					continue;
				case 96:
					id = TokenId.Slash;
					num2 = 88;
					continue;
				case 97:
					if (rBNFgjG61KxHNDdiS8A(ch))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 53;
				case 146:
					if (c != ']')
					{
						num2 = 60;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
						{
							num2 = 125;
						}
						continue;
					}
					goto case 143;
				case 37:
					NextChar();
					num2 = 77;
					continue;
				case 102:
					token.pos = num3;
					num2 = 67;
					continue;
				case 39:
					id = TokenId.Equal;
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num2 = 42;
					}
					continue;
				case 32:
					if ((uint)c <= 91u)
					{
						num2 = 47;
						continue;
					}
					goto case 146;
				case 56:
					id = TokenId.Exclamation;
					num = 92;
					break;
				case 139:
					id = TokenId.Comma;
					num2 = 82;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
					{
						num2 = 47;
					}
					continue;
				case 3:
					id = TokenId.LessThanEqual;
					num2 = 55;
					continue;
				case 118:
					NextChar();
					num2 = 135;
					continue;
				case 7:
					num3 = textPos;
					num2 = 76;
					continue;
				case 149:
					id = TokenId.Asterisk;
					num2 = 66;
					continue;
				case 125:
					if (c != '|')
					{
						num = 19;
						break;
					}
					goto case 37;
				case 111:
					if (ch == '-')
					{
						num2 = 89;
						continue;
					}
					goto case 12;
				case 131:
					id = TokenId.Percent;
					num2 = 115;
					continue;
				case 43:
					id = TokenId.Minus;
					num2 = 117;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
					{
						num2 = 1;
					}
					continue;
				case 47:
					switch (c)
					{
					case '*':
						break;
					case '/':
						goto IL_041d;
					case '&':
						goto IL_043d;
					case '!':
						goto IL_05fe;
					case '.':
						goto IL_0642;
					case '"':
					case '\'':
						goto IL_0652;
					case '=':
						goto IL_06c8;
					default:
						goto IL_0c08;
					case '%':
						goto IL_0ce7;
					case '>':
						goto IL_0d55;
					case ':':
						goto IL_0d95;
					case '+':
						goto IL_0e2b;
					case '-':
						goto IL_0f28;
					case '<':
						goto IL_0f74;
					case '(':
						goto IL_0f84;
					case ')':
						goto IL_10b4;
					case '?':
						goto IL_10e1;
					case ',':
						goto IL_111f;
					case '#':
					case '$':
					case '0':
					case '1':
					case '2':
					case '3':
					case '4':
					case '5':
					case '6':
					case '7':
					case '8':
					case '9':
					case ';':
						goto IL_114d;
					}
					goto case 107;
				case 68:
					id = TokenId.Amphersand;
					num2 = 26;
					continue;
				case 57:
					if (ch == '=')
					{
						num2 = 129;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
						{
							num2 = 61;
						}
						continue;
					}
					goto case 39;
				case 59:
					if (!rBNFgjG61KxHNDdiS8A(ch))
					{
						num2 = 116;
						continue;
					}
					goto case 30;
				case 52:
				case 72:
					if (textPos < textLen)
					{
						num2 = 144;
						continue;
					}
					goto case 40;
				case 134:
					NextChar();
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
					{
						num2 = 94;
					}
					continue;
				case 108:
					id = TokenId.Colon;
					num2 = 45;
					continue;
				case 9:
					goto IL_0ce7;
				case 35:
				case 148:
					NextChar();
					num = 86;
					break;
				case 93:
					if (ch != c2)
					{
						num = 120;
						break;
					}
					goto case 112;
				case 24:
					NextChar();
					num2 = 95;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 94;
					}
					continue;
				case 140:
					goto IL_0d55;
				case 78:
					NextChar();
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
					{
						num2 = 34;
					}
					continue;
				default:
					NextChar();
					num2 = 14;
					continue;
				case 38:
					goto IL_0d95;
				case 21:
					if (!char.IsDigit(ch))
					{
						num2 = 103;
						continue;
					}
					goto case 109;
				case 100:
					id = TokenId.GreaterThanEqual;
					num2 = 136;
					continue;
				case 112:
					NextChar();
					num2 = 52;
					continue;
				case 12:
					ValidateDigit();
					num2 = 145;
					continue;
				case 23:
					goto IL_0e2b;
				case 20:
					throw ParseError(textPos, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138154214));
				case 75:
					NextChar();
					num2 = 127;
					continue;
				case 4:
					throw ParseError(textPos, (string)TZcomMhwloVeNRf8kPa(0x63ABA4E8 ^ 0x63ABBD74), ch);
				case 8:
				case 14:
				case 15:
				case 26:
				case 27:
				case 31:
				case 42:
				case 45:
				case 46:
				case 49:
				case 55:
				case 58:
				case 65:
				case 66:
				case 81:
				case 82:
				case 87:
				case 88:
				case 91:
				case 92:
				case 99:
				case 105:
				case 115:
				case 117:
				case 122:
				case 128:
				case 136:
				case 138:
				case 141:
				case 142:
					token.id = id;
					num = 133;
					break;
				case 109:
					NextChar();
					num2 = 21;
					continue;
				case 29:
					id = TokenId.Question;
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num2 = 27;
					}
					continue;
				case 61:
					if (!char.IsDigit(ch))
					{
						num2 = 110;
						continue;
					}
					goto case 10;
				case 106:
					goto IL_0f28;
				case 13:
					id = TokenId.OpenParen;
					num2 = 91;
					continue;
				case 33:
					id = TokenId.Bar;
					num2 = 31;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
					{
						num2 = 29;
					}
					continue;
				case 113:
					goto IL_0f74;
				case 5:
					goto IL_0f84;
				case 124:
					id = TokenId.LessThan;
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
					{
						num2 = 8;
					}
					continue;
				case 86:
					if (HJLjtJG4uAe19bJdlCS(ch))
					{
						num2 = 35;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
						{
							num2 = 23;
						}
						continue;
					}
					goto case 28;
				case 77:
					if (ch == '|')
					{
						num2 = 16;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
						{
							num2 = 75;
						}
						continue;
					}
					goto case 33;
				case 10:
					NextChar();
					num2 = 61;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num2 = 52;
					}
					continue;
				case 135:
					id = TokenId.DoubleAmphersand;
					num2 = 99;
					continue;
				case 25:
					if (ch == '>')
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
						{
							num2 = 78;
						}
						continue;
					}
					goto case 124;
				case 6:
					goto IL_10b4;
				case 1:
					id = TokenId.Identifier;
					num2 = 58;
					continue;
				case 126:
					goto IL_10e1;
				case 90:
					goto IL_111f;
				case 94:
					id = TokenId.OpenBracket;
					num2 = 81;
					continue;
				case 19:
				case 79:
				case 150:
					goto IL_114d;
					IL_043d:
					NextChar();
					num2 = 60;
					continue;
					IL_06c8:
					NextChar();
					num2 = 57;
					continue;
					IL_041d:
					NextChar();
					num2 = 41;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
					{
						num2 = 96;
					}
					continue;
					IL_0652:
					c2 = ch;
					num2 = 37;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 112;
					}
					continue;
					IL_0642:
					NextChar();
					num2 = 130;
					continue;
					IL_114d:
					if (!char.IsLetter(ch))
					{
						num2 = 51;
						continue;
					}
					goto case 35;
					IL_111f:
					NextChar();
					num2 = 27;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
					{
						num2 = 139;
					}
					continue;
					IL_10e1:
					NextChar();
					num2 = 29;
					continue;
					IL_10b4:
					NextChar();
					num2 = 80;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
					{
						num2 = 2;
					}
					continue;
					IL_0f84:
					NextChar();
					num2 = 13;
					continue;
					IL_0f74:
					NextChar();
					num2 = 71;
					continue;
					IL_0f28:
					NextChar();
					num2 = 19;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num2 = 43;
					}
					continue;
					IL_0e2b:
					NextChar();
					num2 = 119;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
					{
						num2 = 28;
					}
					continue;
					IL_0d95:
					NextChar();
					num2 = 95;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
					{
						num2 = 108;
					}
					continue;
					IL_0d55:
					NextChar();
					num2 = 101;
					continue;
					IL_0ce7:
					NextChar();
					num2 = 131;
					continue;
					IL_0c08:
					num2 = 75;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num2 = 85;
					}
					continue;
					IL_05fe:
					NextChar();
					num2 = 114;
					continue;
				}
				break;
			}
		}
	}

	private bool TokenIdentifierIs(string id)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return HX3OPEGHPXKHAGGpvNg(id, token.text, StringComparison.OrdinalIgnoreCase);
			case 1:
				if (token.id != TokenId.Identifier)
				{
					return false;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private string GetIdentifier()
	{
		int num = 3;
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					ValidateToken(TokenId.Identifier, (string)TZcomMhwloVeNRf8kPa(-138018305 ^ -138012613));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num2 = 2;
					}
					continue;
				default:
					if (text.Length > 1)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 4;
				case 4:
					return text;
				case 1:
					break;
				case 5:
					if (VWOixOh5aBfZJq1DmMl(text, 0) == '@')
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 4;
				case 2:
					text = token.text;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			text = text.Substring(1);
			num = 4;
		}
	}

	private void ValidateDigit()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!rBNFgjG61KxHNDdiS8A(ch))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			default:
				throw ParseError(textPos, (string)TZcomMhwloVeNRf8kPa(-542721635 ^ -542728077));
			}
		}
	}

	private void ValidateToken(TokenId t, string errorMessage)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				throw ParseError(errorMessage);
			case 1:
				if (token.id == t)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void ValidateToken(TokenId t)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (token.id != t)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			default:
				throw ParseError(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7C1EE318 ^ 0x7C1EEED2));
			}
		}
	}

	private Exception ParseError(string format, params object[] args)
	{
		return ParseError(token.pos, format, args);
	}

	private Exception ParseError(int pos, string format, params object[] args)
	{
		return new ParseException((string)yetcrwGASsx1WQdUZW1(CultureInfo.CurrentCulture, format, args), pos);
	}

	private static Dictionary<string, object> CreateKeywords()
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
		dictionary.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x571EA399 ^ 0x571EB997), trueLiteral);
		dictionary.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4DC2B14D ^ 0x4DC2AB57), falseLiteral);
		dictionary.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x66F566B6 ^ 0x66F57650), nullLiteral);
		dictionary.Add(keywordIt, keywordIt);
		dictionary.Add(keywordIif, keywordIif);
		dictionary.Add(keywordNew, keywordNew);
		Type[] array = predefinedTypes;
		foreach (Type type in array)
		{
			dictionary.Add(type.Name, type);
		}
		return dictionary;
	}

	static ExpressionParser()
	{
		int num = 6;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 8:
				keywordIif = (string)TZcomMhwloVeNRf8kPa(-105199646 ^ -105194030);
				num2 = 7;
				break;
			case 5:
				predefinedTypes = new Type[20]
				{
					typeof(object),
					KAF1pPhmquc8fUailtM(typeof(bool).TypeHandle),
					typeof(char),
					KAF1pPhmquc8fUailtM(typeof(string).TypeHandle),
					KAF1pPhmquc8fUailtM(typeof(sbyte).TypeHandle),
					KAF1pPhmquc8fUailtM(typeof(byte).TypeHandle),
					KAF1pPhmquc8fUailtM(typeof(short).TypeHandle),
					typeof(ushort),
					typeof(int),
					KAF1pPhmquc8fUailtM(typeof(uint).TypeHandle),
					KAF1pPhmquc8fUailtM(typeof(long).TypeHandle),
					typeof(ulong),
					typeof(float),
					KAF1pPhmquc8fUailtM(typeof(double).TypeHandle),
					KAF1pPhmquc8fUailtM(typeof(decimal).TypeHandle),
					KAF1pPhmquc8fUailtM(typeof(DateTime).TypeHandle),
					typeof(TimeSpan),
					KAF1pPhmquc8fUailtM(typeof(Guid).TypeHandle),
					KAF1pPhmquc8fUailtM(typeof(Math).TypeHandle),
					typeof(Convert)
				};
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				geHS7ihtPfbwy00cPCo();
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num2 = 5;
				}
				break;
			default:
				trueLiteral = (Expression)JuDEY9hLMrnNBJuTbEA(true);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
				{
					num2 = 1;
				}
				break;
			case 7:
				keywordNew = (string)TZcomMhwloVeNRf8kPa(-1459557599 ^ -1459556069);
				num2 = 4;
				break;
			case 3:
				keywordIt = (string)TZcomMhwloVeNRf8kPa(0x7C1EE318 ^ 0x7C1EF930);
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
				{
					num2 = 4;
				}
				break;
			case 2:
				nullLiteral = (Expression)JuDEY9hLMrnNBJuTbEA(null);
				num2 = 3;
				break;
			case 4:
				return;
			case 1:
				falseLiteral = Expression.Constant(false);
				num2 = 2;
				break;
			}
		}
	}

	internal static void geHS7ihtPfbwy00cPCo()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object TZcomMhwloVeNRf8kPa(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object JRKKHbh4GhyZ7Jb1wLU()
	{
		return StringComparer.OrdinalIgnoreCase;
	}

	internal static int OTruAxh6tuxUllMwkqV(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static bool FS9Y1UhaODBO2Gslphq()
	{
		return KQg2k3hpaS4cQRE91bw == null;
	}

	internal static ExpressionParser i38SJRhDDREx8KG0jLV()
	{
		return KQg2k3hpaS4cQRE91bw;
	}

	internal static bool rM2lRjhH4jTAvWIdTPJ(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object DtptSGhAmSAJxDpBmjv(object P_0)
	{
		return ((ParameterExpression)P_0).Name;
	}

	internal static object UhP449h7vEDexhBCxa9(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static bool i3sRlhhxItMoQagKgRK(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static object stYXaUh085EWUoWhgat(Type type)
	{
		return GetTypeName(type);
	}

	internal static Type KAF1pPhmquc8fUailtM(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object W8PUxJhyaMPUXgpFdZy(object P_0, object P_1)
	{
		return Expression.OrElse((Expression)P_0, (Expression)P_1);
	}

	internal static Type xNfa4VhMkUhKyv7OK94(object P_0)
	{
		return ((Expression)P_0).Type;
	}

	internal static object j7VDV7hJ6wTVTBOdLNA(object P_0, Type P_1)
	{
		return Expression.Convert((Expression)P_0, P_1);
	}

	internal static bool Io2IBDh9UNF0yjdyVXo(Type type)
	{
		return IsEnumType(type);
	}

	internal static bool JjQQTHhdFqCPEsKhvWZ(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object fDve4KhloISBw6DaUcB(object P_0, object P_1)
	{
		return Expression.Multiply((Expression)P_0, (Expression)P_1);
	}

	internal static object QcrGjWhrIvMQo7F1ES1(object P_0, object P_1)
	{
		return Expression.Divide((Expression)P_0, (Expression)P_1);
	}

	internal static object H8LAbdhgHEI1PxnBwK5(object P_0)
	{
		return Expression.Negate((Expression)P_0);
	}

	internal static char VWOixOh5aBfZJq1DmMl(object P_0, int P_1)
	{
		return ((string)P_0)[P_1];
	}

	internal static object Lla0KjhjTGXZ124Xgfk(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}

	internal static int O2enEChYdQuK4p1Zln4(object P_0, char P_1, int P_2)
	{
		return ((string)P_0).IndexOf(P_1, P_2);
	}

	internal static object JuDEY9hLMrnNBJuTbEA(object P_0)
	{
		return Expression.Constant(P_0);
	}

	internal static object UXWy9khU64Y7m676YRf(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static object NUhEDbhsC9F1Rge5Psd(object P_0, object P_1, object P_2)
	{
		return Expression.Condition((Expression)P_0, (Expression)P_1, (Expression)P_2);
	}

	internal static object XD37AshcvCgMSDA2yNL(object P_0)
	{
		return ((DynamicProperty)P_0).Name;
	}

	internal static object GANVmVhzXKv1j6TbigI(object P_0, object P_1)
	{
		return Expression.Bind((MemberInfo)P_0, (Expression)P_1);
	}

	internal static object juH5Z3GF5GjImv1e2W0(Type P_0)
	{
		return Expression.New(P_0);
	}

	internal static object PZMCscGBhAvQMOvfWJL(object P_0, object P_1)
	{
		return Expression.MemberInit((NewExpression)P_0, (MemberBinding[])P_1);
	}

	internal static object AZJNBCGWK3MyRIawtWo(object P_0, object P_1)
	{
		return Expression.Invoke((Expression)P_0, (Expression[])P_1);
	}

	internal static bool TNnRioGoMVKlM0VpPWH(Type type)
	{
		return IsNullableType(type);
	}

	internal static object Fi0OPoGbin4DuNpQQSb(object P_0, object P_1)
	{
		return Expression.New((ConstructorInfo)P_0, (Expression[])P_1);
	}

	internal static Type sf4koeGhqdpuOwGl0td(Type type)
	{
		return GetNonNullableType(type);
	}

	internal static bool wWMmdxGG3QByaxCRm6Y(Type type)
	{
		return IsNumericType(type);
	}

	internal static object dZZnnPGEHLVNIqwWNiT(object P_0, Type P_1)
	{
		return Expression.ConvertChecked((Expression)P_0, P_1);
	}

	internal static Type nufyg4GfPZpS2Cxr7U8(object P_0)
	{
		return ((MemberInfo)P_0).DeclaringType;
	}

	internal static object i8nGnDGQRSscQIHrQM8(object P_0, object P_1, object P_2)
	{
		return Expression.Call((Expression)P_0, (MethodInfo)P_1, (Expression[])P_2);
	}

	internal static bool wpLy1BGCndfypRCWO1L(object P_0, object P_1)
	{
		return (MemberInfo)P_0 == (MemberInfo)P_1;
	}

	internal static object U33gD2GvC8qSF0CFLpv(object P_0, object P_1)
	{
		return Expression.Field((Expression)P_0, (FieldInfo)P_1);
	}

	internal static Type xicM9VG8aF6bXXvuQR2(Type generic, Type type)
	{
		return FindGenericType(generic, type);
	}

	internal static object US6aAkGZM6smVMK28FU(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static bool AJYpf9Guxe4ohobF9cA(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object VHg54LGIC2SWgIt8OZ7(Type P_0, object P_1, object P_2, object P_3)
	{
		return Expression.Call(P_0, (string)P_1, (Type[])P_2, (Expression[])P_3);
	}

	internal static object nQljjAGVO5bmkogFQLi(object P_0)
	{
		return ((List<Expression>)P_0).ToArray();
	}

	internal static int WhJhC3GSiv92ur0R5Yo(Type type)
	{
		return GetNumericTypeKind(type);
	}

	internal static bool ldp1IJGi5QyVT4i2JIZ(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void fMBpO3GRbi1fwKK0v55(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool epG7hyGqA2M2eHroPVQ(object P_0)
	{
		return ((ParameterInfo)P_0).IsOut;
	}

	internal static object ihkCtuGKbgQLsdAR7pg(object P_0, Type P_1)
	{
		return Expression.Constant(P_0, P_1);
	}

	internal static TypeCode a8JAGJGXKH2RUp32h9S(Type P_0)
	{
		return Type.GetTypeCode(P_0);
	}

	internal static object SwLclmGTgRtJvlS5fPt(object P_0, Type type)
	{
		return ParseNumber(P_0, type);
	}

	internal static object F0vtwDGk3JQbAhpNZBu(object P_0, Type type)
	{
		return ParseEnum(P_0, type);
	}

	internal static bool yU3fV3Gn2T7jO4wHQUI(Type source, Type target)
	{
		return IsCompatibleWith(source, target);
	}

	internal static object QfgMoVGOu7abmasC3Ar(object P_0, object P_1)
	{
		return ((FieldInfo)P_0).GetValue(P_1);
	}

	internal static Type MZLpxVG2yWWaF4cWCFV(object P_0)
	{
		return ((ParameterInfo)P_0).ParameterType;
	}

	internal static int MJOJx5GeBNWaI8belE2(Type s, Type t1, Type t2)
	{
		return CompareConversions(s, t1, t2);
	}

	internal static bool aHIXgxGP6WrfmN3LWr7(Type type)
	{
		return IsSignedIntegralType(type);
	}

	internal static bool mGwJmPG1v7F873XA3JN(Type type)
	{
		return IsUnsignedIntegralType(type);
	}

	internal static object MPoPDeGNFZZpadpS6Pr(object P_0, object P_1)
	{
		return Expression.GreaterThan((Expression)P_0, (Expression)P_1);
	}

	internal static object bvQ26pG3Hn7EfWCCuvB(object P_0, object P_1)
	{
		return Expression.GreaterThanOrEqual((Expression)P_0, (Expression)P_1);
	}

	internal static object qGrFlqGpXWQ6UGuaToE(object P_0, object P_1)
	{
		return Expression.LessThan((Expression)P_0, (Expression)P_1);
	}

	internal static object t1ssLbGaMoDUW5Q3XHG(object P_0, object P_1)
	{
		return Expression.LessThanOrEqual((Expression)P_0, (Expression)P_1);
	}

	internal static object Qs1B6FGDGIY4UE5LPBr(object P_0, object P_1)
	{
		return Expression.Add((Expression)P_0, (Expression)P_1);
	}

	internal static object kxsNjVGtO7Prm79DpHF(object P_0, object P_1)
	{
		return Expression.Subtract((Expression)P_0, (Expression)P_1);
	}

	internal static bool cj25XfGwEyX4Hil5xoo(char P_0)
	{
		return char.IsWhiteSpace(P_0);
	}

	internal static bool HJLjtJG4uAe19bJdlCS(char P_0)
	{
		return char.IsLetterOrDigit(P_0);
	}

	internal static bool rBNFgjG61KxHNDdiS8A(char P_0)
	{
		return char.IsDigit(P_0);
	}

	internal static bool HX3OPEGHPXKHAGGpvNg(object P_0, object P_1, StringComparison P_2)
	{
		return string.Equals((string)P_0, (string)P_1, P_2);
	}

	internal static object yetcrwGASsx1WQdUZW1(object P_0, object P_1, object P_2)
	{
		return string.Format((IFormatProvider)P_0, (string)P_1, (object[])P_2);
	}
}
