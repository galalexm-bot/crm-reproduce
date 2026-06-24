// Decompiled with JetBrains decompiler
// Type: System.Linq.Dynamic.ExpressionParser
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace System.Linq.Dynamic
{
  internal class ExpressionParser
  {
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
    private ExpressionParser.Token token;
    private static ExpressionParser KQg2k3hpaS4cQRE91bw;

    public ExpressionParser(ParameterExpression[] parameters, string expression, object[] values)
    {
      ExpressionParser.geHS7ihtPfbwy00cPCo();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 11;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.literals = new Dictionary<Expression, string>();
            num = 6;
            continue;
          case 2:
            this.SetTextPos(0);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 5 : 12;
            continue;
          case 3:
            this.symbols = new Dictionary<string, object>((IEqualityComparer<string>) ExpressionParser.JRKKHbh4GhyZ7Jb1wLU());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 1 : 1;
            continue;
          case 4:
            if (ExpressionParser.keywords == null)
            {
              num = 5;
              continue;
            }
            goto case 3;
          case 5:
            ExpressionParser.keywords = ExpressionParser.CreateKeywords();
            num = 3;
            continue;
          case 6:
            if (parameters != null)
            {
              num = 7;
              continue;
            }
            goto case 9;
          case 7:
            this.ProcessParameters(parameters);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 6 : 9;
            continue;
          case 8:
            goto label_15;
          case 9:
            if (values == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 0;
              continue;
            }
            goto case 10;
          case 10:
            this.ProcessValues(values);
            num = 13;
            continue;
          case 11:
            if (expression != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 3 : 4;
              continue;
            }
            goto label_15;
          case 12:
            this.NextToken();
            num = 15;
            continue;
          case 14:
            this.textLen = ExpressionParser.OTruAxh6tuxUllMwkqV((object) this.text);
            num = 2;
            continue;
          case 15:
            goto label_18;
          default:
            this.text = expression;
            num = 14;
            continue;
        }
      }
label_18:
      return;
label_15:
      throw new ArgumentNullException((string) ExpressionParser.TZcomMhwloVeNRf8kPa(1581325282 << 3 ^ -234302956));
    }

    private void ProcessParameters(ParameterExpression[] parameters)
    {
      int num = 4;
      while (true)
      {
        ParameterExpression parameterExpression;
        int index;
        ParameterExpression[] parameterExpressionArray;
        switch (num)
        {
          case 1:
          case 6:
            if (index < parameterExpressionArray.Length)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 2 : 8;
              continue;
            }
            break;
          case 2:
          case 8:
            parameterExpression = parameterExpressionArray[index];
            num = 9;
            continue;
          case 3:
            index = 0;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 1 : 0;
            continue;
          case 4:
            parameterExpressionArray = parameters;
            num = 3;
            continue;
          case 5:
            ++index;
            num = 6;
            continue;
          case 7:
            this.AddSymbol((string) ExpressionParser.DtptSGhAmSAJxDpBmjv((object) parameterExpression), (object) parameterExpression);
            num = 5;
            continue;
          case 9:
            if (!ExpressionParser.rM2lRjhH4jTAvWIdTPJ((object) parameterExpression.Name))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 7 : 5;
              continue;
            }
            goto case 5;
          case 10:
            if (ExpressionParser.rM2lRjhH4jTAvWIdTPJ(ExpressionParser.DtptSGhAmSAJxDpBmjv((object) parameters[0])))
            {
              num = 12;
              continue;
            }
            goto label_8;
          case 11:
            goto label_14;
          case 12:
            this.it = parameters[0];
            num = 11;
            continue;
        }
        if (parameters.Length == 1)
          num = 10;
        else
          goto label_2;
      }
label_14:
      return;
label_8:
      return;
label_2:;
    }

    private void ProcessValues(object[] values)
    {
      int num = 2;
      int index;
      object obj;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 9:
            if (index >= values.Length)
            {
              num = 11;
              continue;
            }
            goto case 6;
          case 2:
            index = 0;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 1;
            continue;
          case 3:
          case 8:
            ++index;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 9 : 9;
            continue;
          case 4:
            if (!(obj is IDictionary<string, object>))
            {
              num = 5;
              continue;
            }
            goto case 10;
          case 5:
          case 7:
            this.AddSymbol((string) ExpressionParser.UhP449h7vEDexhBCxa9(ExpressionParser.TZcomMhwloVeNRf8kPa(-1598106783 - -968262081 ^ -629843906), (object) index.ToString((IFormatProvider) CultureInfo.InvariantCulture)), obj);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 3 : 2;
            continue;
          case 6:
            obj = values[index];
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
            continue;
          case 10:
            this.externals = (IDictionary<string, object>) obj;
            num = 8;
            continue;
          case 11:
            goto label_13;
          default:
            if (index == values.Length - 1)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 4 : 3;
              continue;
            }
            goto case 5;
        }
      }
label_13:;
    }

    private void AddSymbol(string name, object value)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.symbols.Add(name, value);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 3 : 3;
            continue;
          case 2:
            if (!this.symbols.ContainsKey(name))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 1;
              continue;
            }
            goto label_2;
          case 3:
            goto label_6;
          default:
            goto label_2;
        }
      }
label_6:
      return;
label_2:
      throw this.ParseError((string) ExpressionParser.TZcomMhwloVeNRf8kPa(1654249598 >> 2 ^ 413563709), (object) name);
    }

    public Expression Parse(Type resultType)
    {
      int num = 1;
      int pos;
      Expression expr;
      while (true)
      {
        switch (num)
        {
          case 1:
            pos = this.token.pos;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 0;
            continue;
          case 2:
            this.ValidateToken(ExpressionParser.TokenId.End, (string) ExpressionParser.TZcomMhwloVeNRf8kPa(1199946765 ^ 1199944135));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 4 : 4;
            continue;
          case 3:
            goto label_2;
          case 4:
            goto label_8;
          case 5:
            if (!ExpressionParser.i3sRlhhxItMoQagKgRK(resultType, (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 1 : 2;
              continue;
            }
            goto case 6;
          case 6:
            if ((expr = this.PromoteExpression(expr, resultType, true)) == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 3 : 3;
              continue;
            }
            goto case 2;
          default:
            expr = this.ParseExpression();
            num = 5;
            continue;
        }
      }
label_2:
      throw this.ParseError(pos, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420742494), ExpressionParser.stYXaUh085EWUoWhgat(resultType));
label_8:
      return expr;
    }

    public IEnumerable<DynamicOrdering> ParseOrdering()
    {
      List<DynamicOrdering> ordering = new List<DynamicOrdering>();
      while (true)
      {
        Expression expression = this.ParseExpression();
        bool flag = true;
        if (this.TokenIdentifierIs(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1350312861 << 3 ^ 2082402046)) || this.TokenIdentifierIs(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~210725948 ^ -210723277)))
          this.NextToken();
        else if (this.TokenIdentifierIs(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1642859704 ^ 1642857150)) || this.TokenIdentifierIs(z2jc63fLkugS1X8Q9N.tE1kD1vbB(381945751 ^ 1158627804 ^ 1405831257)))
        {
          this.NextToken();
          flag = false;
        }
        ordering.Add(new DynamicOrdering()
        {
          Selector = expression,
          Ascending = flag
        });
        if (this.token.id == ExpressionParser.TokenId.Comma)
          this.NextToken();
        else
          break;
      }
      this.ValidateToken(ExpressionParser.TokenId.End, z2jc63fLkugS1X8Q9N.tE1kD1vbB(572119659 - -337058038 ^ 909180587));
      return (IEnumerable<DynamicOrdering>) ordering;
    }

    private Expression ParseExpression()
    {
      int num = 8;
      Expression test;
      Expression expression1;
      Expression expression2;
      int pos;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.ValidateToken(ExpressionParser.TokenId.Colon, (string) ExpressionParser.TZcomMhwloVeNRf8kPa(-882126494 ^ -882122936));
            num = 4;
            continue;
          case 2:
            expression2 = this.ParseExpression();
            num = 9;
            continue;
          case 3:
            goto label_12;
          case 4:
            this.NextToken();
            num = 2;
            continue;
          case 5:
            if (this.token.id == ExpressionParser.TokenId.Question)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
              continue;
            }
            goto label_12;
          case 6:
            expression1 = this.ParseExpression();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 1 : 0;
            continue;
          case 7:
            test = this.ParseLogicalOr();
            num = 5;
            continue;
          case 8:
            pos = this.token.pos;
            num = 7;
            continue;
          case 9:
            test = this.GenerateConditional(test, expression1, expression2, pos);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 3;
            continue;
          default:
            this.NextToken();
            num = 6;
            continue;
        }
      }
label_12:
      return test;
    }

    private Expression ParseLogicalOr()
    {
      int num1 = 2;
      Expression left;
      while (true)
      {
        int num2 = num1;
        ExpressionParser.Token token;
        Expression logicalAnd;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 5:
              if (this.token.id != ExpressionParser.TokenId.DoubleBar)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
                continue;
              }
              goto case 6;
            case 2:
              left = this.ParseLogicalAnd();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 1 : 1;
              continue;
            case 3:
              // ISSUE: type reference
              this.CheckAndPromoteOperands(ExpressionParser.KAF1pPhmquc8fUailtM(__typeref (ExpressionParser.ILogicalSignatures)), token.text, ref left, ref logicalAnd, token.pos);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 7 : 7;
              continue;
            case 4:
              goto label_7;
            case 6:
            case 8:
              token = this.token;
              num2 = 9;
              continue;
            case 7:
              goto label_11;
            case 9:
              this.NextToken();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 10 : 7;
              continue;
            case 10:
              logicalAnd = this.ParseLogicalAnd();
              num2 = 3;
              continue;
            default:
              if (this.TokenIdentifierIs((string) ExpressionParser.TZcomMhwloVeNRf8kPa(647913418 ^ 647909772)))
              {
                num2 = 6;
                continue;
              }
              goto label_7;
          }
        }
label_11:
        left = (Expression) ExpressionParser.W8PUxJhyaMPUXgpFdZy((object) left, (object) logicalAnd);
        num1 = 5;
      }
label_7:
      return left;
    }

    private Expression ParseLogicalAnd()
    {
      int num1 = 8;
      Expression left;
      while (true)
      {
        int num2 = num1;
        Expression comparison;
        ExpressionParser.Token token;
        while (true)
        {
          switch (num2)
          {
            case 1:
              token = this.token;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 4 : 5;
              continue;
            case 2:
              // ISSUE: type reference
              this.CheckAndPromoteOperands(ExpressionParser.KAF1pPhmquc8fUailtM(__typeref (ExpressionParser.ILogicalSignatures)), token.text, ref left, ref comparison, token.pos);
              num2 = 6;
              continue;
            case 3:
              goto label_6;
            case 4:
              if (!this.TokenIdentifierIs((string) ExpressionParser.TZcomMhwloVeNRf8kPa(-1876063057 ^ -1876065567)))
              {
                num2 = 3;
                continue;
              }
              goto case 1;
            case 5:
              this.NextToken();
              num2 = 9;
              continue;
            case 6:
              left = (Expression) Expression.AndAlso(left, comparison);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 0;
              continue;
            case 8:
              goto label_12;
            case 9:
              comparison = this.ParseComparison();
              num2 = 2;
              continue;
            default:
              if (this.token.id != ExpressionParser.TokenId.DoubleAmphersand)
              {
                num2 = 4;
                continue;
              }
              goto case 1;
          }
        }
label_12:
        left = this.ParseComparison();
        num1 = 7;
      }
label_6:
      return left;
    }

    private Expression ParseComparison()
    {
      int num1 = 22;
      ExpressionParser.Token token;
      Expression right;
      Expression left;
      while (true)
      {
        int num2 = num1;
        ExpressionParser.TokenId id;
        while (true)
        {
          Expression expression;
          bool flag;
          int num3;
          switch (num2)
          {
            case 1:
label_28:
              left = this.GenerateGreaterThanEqual(left, right);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 12 : 26;
              continue;
            case 2:
              if (this.token.id != ExpressionParser.TokenId.LessThan)
              {
                num2 = 28;
                continue;
              }
              goto case 18;
            case 3:
              if (!right.Type.IsValueType)
              {
                num2 = 8;
                continue;
              }
              break;
            case 4:
            case 24:
            case 30:
            case 40:
            case 47:
              goto label_17;
            case 5:
              if (!ExpressionParser.xNfa4VhMkUhKyv7OK94((object) right).IsAssignableFrom(ExpressionParser.xNfa4VhMkUhKyv7OK94((object) left)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 12 : 17;
                continue;
              }
              goto case 41;
            case 6:
              if (flag)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 31 : 17;
                continue;
              }
              break;
            case 7:
label_9:
              left = this.GenerateEqual(left, right);
              num2 = 20;
              continue;
            case 8:
              if (ExpressionParser.i3sRlhhxItMoQagKgRK(ExpressionParser.xNfa4VhMkUhKyv7OK94((object) left), right.Type))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 46 : 20;
                continue;
              }
              goto label_17;
            case 9:
              if ((expression = this.PromoteExpression(right, ExpressionParser.xNfa4VhMkUhKyv7OK94((object) left), true)) != null)
              {
                num2 = 53;
                continue;
              }
              goto case 35;
            case 10:
              if (token.id == ExpressionParser.TokenId.Equal)
                goto label_67;
              else
                goto label_4;
            case 11:
              if (this.token.id == ExpressionParser.TokenId.LessGreater)
                goto case 18;
              else
                goto label_30;
            case 13:
              if (token.id != ExpressionParser.TokenId.ExclamationEqual)
              {
                num2 = 37;
                continue;
              }
              goto label_67;
            case 14:
              goto label_69;
            case 15:
              if (this.token.id != ExpressionParser.TokenId.DoubleEqual)
              {
                num2 = 33;
                continue;
              }
              goto case 18;
            case 16:
label_60:
              left = this.GenerateLessThanEqual(left, right);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 36 : 38;
              continue;
            case 17:
            case 45:
              goto label_12;
            case 18:
              token = this.token;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 48 : 45;
              continue;
            case 19:
            case 50:
              if (ExpressionParser.i3sRlhhxItMoQagKgRK(ExpressionParser.xNfa4VhMkUhKyv7OK94((object) left), ExpressionParser.xNfa4VhMkUhKyv7OK94((object) right)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 4 : 9;
                continue;
              }
              goto label_17;
            case 22:
              left = this.ParseAdditive();
              num2 = 21;
              continue;
            case 23:
label_42:
              if (ExpressionParser.Io2IBDh9UNF0yjdyVXo(ExpressionParser.xNfa4VhMkUhKyv7OK94((object) right)))
              {
                num2 = 19;
                continue;
              }
              // ISSUE: type reference
              // ISSUE: type reference
              this.CheckAndPromoteOperands(!flag ? ExpressionParser.KAF1pPhmquc8fUailtM(__typeref (ExpressionParser.IRelationalSignatures)) : ExpressionParser.KAF1pPhmquc8fUailtM(__typeref (ExpressionParser.IEqualitySignatures)), token.text, ref left, ref right, token.pos);
              num2 = 24;
              continue;
            case 25:
              left = expression;
              num2 = 4;
              continue;
            case 27:
              right = (Expression) ExpressionParser.j7VDV7hJ6wTVTBOdLNA((object) right, ExpressionParser.xNfa4VhMkUhKyv7OK94((object) left));
              num2 = 30;
              continue;
            case 28:
              if (this.token.id == ExpressionParser.TokenId.LessThanEqual)
                goto case 18;
              else
                goto label_59;
            case 29:
              if (this.token.id != ExpressionParser.TokenId.GreaterThanEqual)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 2 : 0;
                continue;
              }
              goto case 18;
            case 31:
              if (ExpressionParser.xNfa4VhMkUhKyv7OK94((object) left).IsValueType)
                break;
              goto label_52;
            case 32:
label_26:
              left = this.GenerateLessThan(left, right);
              num2 = 12;
              continue;
            case 33:
              if (this.token.id != ExpressionParser.TokenId.ExclamationEqual)
              {
                num2 = 11;
                continue;
              }
              goto case 18;
            case 34:
              if (token.id != ExpressionParser.TokenId.DoubleEqual)
              {
                num2 = 13;
                continue;
              }
              goto label_67;
            case 35:
              if ((expression = this.PromoteExpression(left, right.Type, true)) != null)
              {
                num2 = 25;
                continue;
              }
              goto label_69;
            case 37:
              num3 = token.id == ExpressionParser.TokenId.LessGreater ? 1 : 0;
              goto label_68;
            case 39:
              right = this.ParseAdditive();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 10 : 6;
              continue;
            case 41:
              left = (Expression) Expression.Convert(left, ExpressionParser.xNfa4VhMkUhKyv7OK94((object) right));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 40 : 11;
              continue;
            case 43:
label_53:
              left = this.GenerateGreaterThan(left, right);
              num2 = 42;
              continue;
            case 44:
              goto label_35;
            case 46:
              if (!ExpressionParser.xNfa4VhMkUhKyv7OK94((object) left).IsAssignableFrom(ExpressionParser.xNfa4VhMkUhKyv7OK94((object) right)))
                goto case 5;
              else
                goto label_32;
            case 48:
              this.NextToken();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 31 : 39;
              continue;
            case 49:
label_27:
              left = this.GenerateNotEqual(left, right);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 10 : 36;
              continue;
            case 51:
              if (this.token.id == ExpressionParser.TokenId.GreaterThan)
                goto case 18;
              else
                goto label_64;
            case 52:
              switch (id)
              {
                case ExpressionParser.TokenId.LessThan:
                  goto label_26;
                case ExpressionParser.TokenId.Equal:
                case ExpressionParser.TokenId.DoubleEqual:
                  goto label_9;
                case ExpressionParser.TokenId.GreaterThan:
                  goto label_53;
                case ExpressionParser.TokenId.Question:
                case ExpressionParser.TokenId.OpenBracket:
                case ExpressionParser.TokenId.CloseBracket:
                case ExpressionParser.TokenId.Bar:
                case ExpressionParser.TokenId.DoubleAmphersand:
                  goto label_18;
                case ExpressionParser.TokenId.ExclamationEqual:
                case ExpressionParser.TokenId.LessGreater:
                  goto label_27;
                case ExpressionParser.TokenId.LessThanEqual:
                  goto label_60;
                case ExpressionParser.TokenId.GreaterThanEqual:
                  goto label_28;
                default:
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 0 : 0;
                  continue;
              }
            case 53:
              right = expression;
              num2 = 47;
              continue;
            default:
label_18:
              if (this.token.id != ExpressionParser.TokenId.Equal)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 1 : 15;
                continue;
              }
              goto case 18;
          }
          if (ExpressionParser.Io2IBDh9UNF0yjdyVXo(ExpressionParser.xNfa4VhMkUhKyv7OK94((object) left)))
          {
            num2 = 50;
            continue;
          }
          goto label_42;
label_67:
          num3 = 1;
label_68:
          flag = num3 != 0;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 6 : 0;
        }
label_4:
        num1 = 34;
        continue;
label_17:
        id = token.id;
        num1 = 52;
        continue;
label_30:
        num1 = 51;
        continue;
label_32:
        num1 = 27;
        continue;
label_52:
        num1 = 3;
        continue;
label_59:
        num1 = 44;
        continue;
label_64:
        num1 = 29;
      }
label_12:
      throw this.IncompatibleOperandsError(token.text, left, right, token.pos);
label_35:
      return left;
label_69:
      throw this.IncompatibleOperandsError(token.text, left, right, token.pos);
    }

    private Expression ParseAdditive()
    {
      int num1 = 20;
      Expression left;
      while (true)
      {
        int num2 = num1;
        Expression multiplicative;
        ExpressionParser.Token token;
        ExpressionParser.TokenId id;
        while (true)
        {
          switch (num2)
          {
            case 1:
              this.NextToken();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 5 : 2;
              continue;
            case 2:
              // ISSUE: type reference
              if (!ExpressionParser.JjQQTHhdFqCPEsKhvWZ(ExpressionParser.xNfa4VhMkUhKyv7OK94((object) left), ExpressionParser.KAF1pPhmquc8fUailtM(__typeref (string))))
              {
                num2 = 4;
                continue;
              }
              goto case 12;
            case 3:
              goto label_24;
            case 4:
              if (ExpressionParser.JjQQTHhdFqCPEsKhvWZ(ExpressionParser.xNfa4VhMkUhKyv7OK94((object) multiplicative), typeof (string)))
              {
                num2 = 14;
                continue;
              }
              goto case 13;
            case 5:
              multiplicative = this.ParseMultiplicative();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
              continue;
            case 6:
              left = this.GenerateAdd(left, multiplicative);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 8;
              continue;
            case 7:
            case 8:
            case 10:
            case 19:
            case 21:
              if (this.token.id != ExpressionParser.TokenId.Plus)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 2 : 15;
                continue;
              }
              goto case 11;
            case 9:
              if (id != ExpressionParser.TokenId.Minus)
              {
                num2 = 10;
                continue;
              }
              goto case 18;
            case 11:
              token = this.token;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 1 : 1;
              continue;
            case 12:
            case 14:
              left = this.GenerateStringConcat(left, multiplicative);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 7 : 5;
              continue;
            case 13:
              this.CheckAndPromoteOperands(typeof (ExpressionParser.IAddSignatures), token.text, ref left, ref multiplicative, token.pos);
              num2 = 6;
              continue;
            case 15:
              if (this.token.id != ExpressionParser.TokenId.Minus)
              {
                num2 = 23;
                continue;
              }
              goto case 11;
            case 16:
              left = this.GenerateSubtract(left, multiplicative);
              num2 = 21;
              continue;
            case 17:
              if (id == ExpressionParser.TokenId.Plus)
                goto case 2;
              else
                goto label_29;
            case 18:
              // ISSUE: type reference
              this.CheckAndPromoteOperands(ExpressionParser.KAF1pPhmquc8fUailtM(__typeref (ExpressionParser.ISubtractSignatures)), token.text, ref left, ref multiplicative, token.pos);
              num2 = 16;
              continue;
            case 20:
              left = this.ParseMultiplicative();
              num2 = 19;
              continue;
            case 22:
              if (id != ExpressionParser.TokenId.Amphersand)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 17 : 17;
                continue;
              }
              goto case 12;
            case 23:
              if (this.token.id != ExpressionParser.TokenId.Amphersand)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 3 : 3;
                continue;
              }
              goto case 11;
            default:
              id = token.id;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 22 : 9;
              continue;
          }
        }
label_29:
        num1 = 9;
      }
label_24:
      return left;
    }

    private Expression ParseMultiplicative()
    {
      int num1 = 4;
      Expression left;
      while (true)
      {
        int num2 = num1;
        ExpressionParser.Token token;
        ExpressionParser.TokenId id;
        Expression unary;
        while (true)
        {
          switch (num2)
          {
            case 1:
              left = (Expression) ExpressionParser.fDve4KhloISBw6DaUcB((object) left, (object) unary);
              num2 = 7;
              continue;
            case 2:
              if (this.token.id != ExpressionParser.TokenId.Slash)
              {
                num2 = 21;
                continue;
              }
              goto case 5;
            case 3:
            case 7:
            case 10:
            case 11:
            case 17:
            case 25:
              if (this.token.id != ExpressionParser.TokenId.Asterisk)
              {
                num2 = 2;
                continue;
              }
              goto case 5;
            case 4:
              goto label_4;
            case 5:
            case 24:
              token = this.token;
              num2 = 8;
              continue;
            case 6:
              goto label_3;
            case 8:
              this.NextToken();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 22 : 10;
              continue;
            case 9:
            case 20:
              if (id == ExpressionParser.TokenId.Asterisk)
                goto case 1;
              else
                goto label_11;
            case 12:
              if (id != ExpressionParser.TokenId.Percent)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 25 : 15;
                continue;
              }
              goto case 15;
            case 13:
              id = token.id;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 10 : 23;
              continue;
            case 14:
              if (id != ExpressionParser.TokenId.Slash)
              {
                num2 = 10;
                continue;
              }
              goto case 16;
            case 15:
              left = (Expression) Expression.Modulo(left, unary);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 8 : 17;
              continue;
            case 16:
              left = (Expression) ExpressionParser.QcrGjWhrIvMQo7F1ES1((object) left, (object) unary);
              num2 = 11;
              continue;
            case 18:
              if (this.TokenIdentifierIs((string) ExpressionParser.TZcomMhwloVeNRf8kPa(333888594 ^ 1075625116 ^ 1408896662)))
              {
                num2 = 24;
                continue;
              }
              goto label_3;
            case 19:
              // ISSUE: type reference
              this.CheckAndPromoteOperands(ExpressionParser.KAF1pPhmquc8fUailtM(__typeref (ExpressionParser.IArithmeticSignatures)), token.text, ref left, ref unary, token.pos);
              num2 = 13;
              continue;
            case 21:
              if (this.token.id != ExpressionParser.TokenId.Percent)
              {
                num2 = 18;
                continue;
              }
              goto case 5;
            case 22:
              goto label_30;
            case 23:
              if (id > ExpressionParser.TokenId.Percent)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 9 : 3;
                continue;
              }
              goto default;
            default:
              if (id != ExpressionParser.TokenId.Identifier)
              {
                num2 = 12;
                continue;
              }
              goto case 15;
          }
        }
label_4:
        left = this.ParseUnary();
        num1 = 3;
        continue;
label_11:
        num1 = 14;
        continue;
label_30:
        unary = this.ParseUnary();
        num1 = 19;
      }
label_3:
      return left;
    }

    private Expression ParseUnary()
    {
      int num1 = 8;
      Expression expr;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          ExpressionParser.Token token;
          switch (num2)
          {
            case 1:
            case 17:
              goto label_13;
            case 2:
              this.NextToken();
              num2 = 5;
              continue;
            case 3:
              goto label_24;
            case 4:
              // ISSUE: type reference
              this.CheckAndPromoteOperand(ExpressionParser.KAF1pPhmquc8fUailtM(__typeref (ExpressionParser.INotSignatures)), token.text, ref expr, token.pos);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 10 : 2;
              continue;
            case 5:
              if (token.id == ExpressionParser.TokenId.Minus)
              {
                num2 = 9;
                continue;
              }
              break;
            case 6:
              this.token.pos = token.pos;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 3 : 0;
              continue;
            case 7:
              if (this.token.id != ExpressionParser.TokenId.Exclamation)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 7 : 15;
                continue;
              }
              goto case 12;
            case 8:
              if (this.token.id != ExpressionParser.TokenId.Minus)
              {
                num2 = 7;
                continue;
              }
              goto case 12;
            case 9:
              if (this.token.id == ExpressionParser.TokenId.IntegerLiteral)
                goto case 16;
              else
                goto label_10;
            case 10:
              expr = (Expression) Expression.Not(expr);
              num2 = 17;
              continue;
            case 11:
              if (this.token.id == ExpressionParser.TokenId.RealLiteral)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 16 : 12;
                continue;
              }
              break;
            case 12:
              token = this.token;
              num2 = 2;
              continue;
            case 13:
              expr = (Expression) ExpressionParser.H8LAbdhgHEI1PxnBwK5((object) expr);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 1 : 1;
              continue;
            case 14:
              if (token.id == ExpressionParser.TokenId.Minus)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
                continue;
              }
              goto case 4;
            case 15:
              if (this.TokenIdentifierIs(z2jc63fLkugS1X8Q9N.tE1kD1vbB(813604817 ^ 813601203)))
              {
                num2 = 12;
                continue;
              }
              goto label_14;
            case 16:
              this.token.text = (string) ExpressionParser.TZcomMhwloVeNRf8kPa(--1418440330 ^ 1418436838) + this.token.text;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 6 : 4;
              continue;
            default:
              // ISSUE: type reference
              this.CheckAndPromoteOperand(ExpressionParser.KAF1pPhmquc8fUailtM(__typeref (ExpressionParser.INegationSignatures)), token.text, ref expr, token.pos);
              num2 = 13;
              continue;
          }
          expr = this.ParseUnary();
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 14 : 7;
        }
label_10:
        num1 = 11;
      }
label_13:
      return expr;
label_14:
      return this.ParsePrimary();
label_24:
      return this.ParsePrimary();
    }

    private Expression ParsePrimary()
    {
      int num1 = 4;
      Expression primary;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              primary = this.ParseMemberAccess((Type) null, primary);
              num2 = 6;
              continue;
            case 2:
              if (this.token.id == ExpressionParser.TokenId.OpenBracket)
              {
                num2 = 8;
                continue;
              }
              goto label_9;
            case 3:
            case 5:
            case 6:
              if (this.token.id == ExpressionParser.TokenId.Dot)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 7 : 6;
                continue;
              }
              goto case 2;
            case 4:
              primary = this.ParsePrimaryStart();
              num2 = 3;
              continue;
            case 7:
              this.NextToken();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 1 : 1;
              continue;
            case 8:
              goto label_4;
            default:
              goto label_9;
          }
        }
label_4:
        primary = this.ParseElementAccess(primary);
        num1 = 5;
      }
label_9:
      return primary;
    }

    private Expression ParsePrimaryStart()
    {
      int num = 2;
      ExpressionParser.TokenId id;
      while (true)
      {
        switch (num)
        {
          case 1:
            switch (id)
            {
              case ExpressionParser.TokenId.Identifier:
                goto label_4;
              case ExpressionParser.TokenId.StringLiteral:
                goto label_5;
              case ExpressionParser.TokenId.IntegerLiteral:
                goto label_6;
              case ExpressionParser.TokenId.RealLiteral:
                goto label_7;
              case ExpressionParser.TokenId.Exclamation:
              case ExpressionParser.TokenId.Percent:
              case ExpressionParser.TokenId.Amphersand:
                goto label_9;
              case ExpressionParser.TokenId.OpenParen:
                goto label_8;
              default:
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
                continue;
            }
          case 2:
            id = this.token.id;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_4;
          default:
            goto label_9;
        }
      }
label_4:
      return this.ParseIdentifier();
label_5:
      return this.ParseStringLiteral();
label_6:
      return this.ParseIntegerLiteral();
label_7:
      return this.ParseRealLiteral();
label_8:
      return this.ParseParenExpression();
label_9:
      throw this.ParseError(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1199946765 ^ 1199944319));
    }

    private Expression ParseStringLiteral()
    {
      int num1 = 7;
      string text;
      while (true)
      {
        int num2 = num1;
        char ch;
        int startIndex;
        int num3;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_5;
            case 2:
              text = (string) ExpressionParser.Lla0KjhjTGXZ124Xgfk((object) this.token.text, 1, ExpressionParser.OTruAxh6tuxUllMwkqV((object) this.token.text) - 2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
              continue;
            case 3:
              text = text.Remove(startIndex, 1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 10 : 10;
              continue;
            case 4:
              if (ch == '\'')
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 9 : 4;
                continue;
              }
              this.NextToken();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 9 : 11;
              continue;
            case 5:
              if (startIndex >= 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 3;
                continue;
              }
              goto case 4;
            case 6:
              ch = ExpressionParser.VWOixOh5aBfZJq1DmMl((object) this.token.text, 0);
              num2 = 2;
              continue;
            case 7:
              goto label_8;
            case 8:
            case 13:
              startIndex = ExpressionParser.O2enEChYdQuK4p1Zln4((object) text, ch, num3);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 5 : 4;
              continue;
            case 9:
              if (ExpressionParser.OTruAxh6tuxUllMwkqV((object) text) == 1)
              {
                this.NextToken();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 7 : 12;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 1 : 1;
              continue;
            case 10:
              num3 = startIndex + 1;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 8 : 5;
              continue;
            case 11:
              goto label_20;
            case 12:
              goto label_16;
            default:
              num3 = 0;
              num2 = 13;
              continue;
          }
        }
label_8:
        this.ValidateToken(ExpressionParser.TokenId.StringLiteral);
        num1 = 6;
      }
label_5:
      throw this.ParseError(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1350312861 << 3 ^ 2082401668));
label_16:
      return this.CreateLiteral((object) ExpressionParser.VWOixOh5aBfZJq1DmMl((object) text, 0), text);
label_20:
      return this.CreateLiteral((object) text, text);
    }

    private Expression ParseIntegerLiteral()
    {
      int num1 = 2;
      ulong result1;
      string text;
      long result2;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              text = this.token.text;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 8;
              continue;
            case 2:
              this.ValidateToken(ExpressionParser.TokenId.IntegerLiteral);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 1 : 1;
              continue;
            case 3:
              goto label_8;
            case 4:
              if (result1 > (ulong) int.MaxValue)
              {
                if (result1 > (ulong) uint.MaxValue)
                {
                  if (result1 > (ulong) long.MaxValue)
                  {
                    num2 = 7;
                    continue;
                  }
                  goto label_20;
                }
                else
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 4 : 9;
                  continue;
                }
              }
              else
              {
                num2 = 11;
                continue;
              }
            case 5:
              goto label_20;
            case 6:
              goto label_16;
            case 7:
              goto label_21;
            case 8:
              if (ExpressionParser.VWOixOh5aBfZJq1DmMl((object) text, 0) != '-')
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 5 : 10;
                continue;
              }
              if (long.TryParse(text, out result2))
              {
                this.NextToken();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 0 : 0;
                continue;
              }
              num2 = 6;
              continue;
            case 9:
              goto label_3;
            case 10:
              if (!ulong.TryParse(text, out result1))
              {
                num2 = 12;
                continue;
              }
              this.NextToken();
              num2 = 4;
              continue;
            case 11:
              goto label_9;
            case 12:
              goto label_29;
            case 13:
              goto label_7;
            case 14:
              if (result2 > (long) int.MaxValue)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 3 : 3;
                continue;
              }
              goto label_7;
            default:
              goto label_26;
          }
        }
label_26:
        if (result2 >= (long) int.MinValue)
          num1 = 14;
        else
          goto label_8;
      }
label_3:
      return this.CreateLiteral((object) (uint) result1, text);
label_7:
      return this.CreateLiteral((object) (int) result2, text);
label_8:
      return this.CreateLiteral((object) result2, text);
label_9:
      return this.CreateLiteral((object) (int) result1, text);
label_16:
      throw this.ParseError((string) ExpressionParser.TZcomMhwloVeNRf8kPa(1012087039 ^ 1012086775), (object) text);
label_20:
      return this.CreateLiteral((object) (long) result1, text);
label_21:
      return this.CreateLiteral((object) result1, text);
label_29:
      throw this.ParseError((string) ExpressionParser.TZcomMhwloVeNRf8kPa(1149433385 + 173655049 ^ 1323087162), (object) text);
    }

    private Expression ParseRealLiteral()
    {
      int num = 10;
      string text;
      object obj;
      while (true)
      {
        double result1;
        float result2;
        char ch;
        switch (num)
        {
          case 1:
            goto label_4;
          case 3:
            goto label_12;
          case 4:
            if (ch == 'f')
            {
              num = 13;
              continue;
            }
            goto case 6;
          case 5:
            this.NextToken();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 3;
            continue;
          case 6:
            if (double.TryParse(text, out result1))
            {
              num = 8;
              continue;
            }
            break;
          case 8:
            obj = (object) result1;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
            continue;
          case 9:
            text = this.token.text;
            num = 11;
            continue;
          case 10:
            this.ValidateToken(ExpressionParser.TokenId.RealLiteral);
            num = 9;
            continue;
          case 11:
            obj = (object) null;
            num = 12;
            continue;
          case 12:
            ch = ExpressionParser.VWOixOh5aBfZJq1DmMl((object) text, ExpressionParser.OTruAxh6tuxUllMwkqV((object) text) - 1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 14 : 8;
            continue;
          case 13:
            if (!float.TryParse((string) ExpressionParser.Lla0KjhjTGXZ124Xgfk((object) text, 0, ExpressionParser.OTruAxh6tuxUllMwkqV((object) text) - 1), out result2))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 2 : 0;
              continue;
            }
            goto case 15;
          case 14:
            if (ch != 'F')
            {
              num = 4;
              continue;
            }
            goto case 13;
          case 15:
            obj = (object) result2;
            num = 7;
            continue;
        }
        if (obj != null)
          num = 5;
        else
          break;
      }
label_4:
      throw this.ParseError(z2jc63fLkugS1X8Q9N.tE1kD1vbB(236071375 ^ 236070537), (object) text);
label_12:
      return this.CreateLiteral(obj, text);
    }

    private Expression CreateLiteral(object value, string text)
    {
      int num = 1;
      ConstantExpression key;
      while (true)
      {
        switch (num)
        {
          case 1:
            key = Expression.Constant(value);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            this.literals.Add((Expression) key, text);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 2 : 1;
            continue;
        }
      }
label_3:
      return (Expression) key;
    }

    private Expression ParseParenExpression()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.NextToken();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 0 : 0;
            continue;
          case 2:
            this.ValidateToken(ExpressionParser.TokenId.OpenParen, (string) ExpressionParser.TZcomMhwloVeNRf8kPa(-1487388570 ^ -1487384808));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 1 : 1;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      Expression expression = this.ParseExpression();
      this.ValidateToken(ExpressionParser.TokenId.CloseParen, (string) ExpressionParser.TZcomMhwloVeNRf8kPa(-1886646897 ^ -1886649835));
      this.NextToken();
      return expression;
    }

    private Expression ParseIdentifier()
    {
      int num1 = 10;
      Expression identifier1;
      LambdaExpression lambda;
      object identifier2;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_9;
            case 2:
              goto label_5;
            case 3:
              if ((object) (identifier2 as Type) != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
                continue;
              }
              if (identifier2 != (object) ExpressionParser.keywordIt)
              {
                if (identifier2 != (object) ExpressionParser.keywordIif)
                {
                  if (identifier2 == (object) ExpressionParser.keywordNew)
                  {
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 19 : 3;
                    continue;
                  }
                  this.NextToken();
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 1 : 0;
                  continue;
                }
                num2 = 4;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 17 : 9;
              continue;
            case 4:
              goto label_14;
            case 5:
              if (!this.symbols.TryGetValue(this.token.text, out identifier2))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 11 : 7;
                continue;
              }
              goto case 21;
            case 6:
              goto label_33;
            case 7:
              identifier1 = (Expression) ExpressionParser.JuDEY9hLMrnNBJuTbEA(identifier2);
              num2 = 20;
              continue;
            case 8:
              lambda = identifier1 as LambdaExpression;
              num2 = 15;
              continue;
            case 9:
              if (!ExpressionParser.keywords.TryGetValue(this.token.text, out identifier2))
              {
                num2 = 5;
                continue;
              }
              goto case 3;
            case 10:
              this.ValidateToken(ExpressionParser.TokenId.Identifier);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 9 : 9;
              continue;
            case 11:
              if (this.externals != null)
              {
                num2 = 16;
                continue;
              }
              goto label_31;
            case 12:
              if (identifier1 == null)
              {
                num2 = 7;
                continue;
              }
              goto case 8;
            case 13:
              goto label_31;
            case 14:
              goto label_4;
            case 15:
              if (lambda != null)
              {
                num2 = 6;
                continue;
              }
              goto case 20;
            case 16:
              if (!this.externals.TryGetValue(this.token.text, out identifier2))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 13 : 6;
                continue;
              }
              goto case 21;
            case 17:
              goto label_17;
            case 18:
              goto label_30;
            case 19:
              goto label_27;
            case 20:
              this.NextToken();
              num2 = 18;
              continue;
            case 21:
              identifier1 = identifier2 as Expression;
              num2 = 12;
              continue;
            default:
              goto label_37;
          }
        }
label_31:
        if (this.it == null)
          num1 = 2;
        else
          break;
      }
label_4:
      return this.ParseMemberAccess((Type) null, (Expression) this.it);
label_5:
      throw this.ParseError((string) ExpressionParser.TZcomMhwloVeNRf8kPa(~-397266137 ^ 397263638), (object) this.token.text);
label_9:
      return (Expression) identifier2;
label_14:
      return this.ParseIif();
label_17:
      return this.ParseIt();
label_27:
      return this.ParseNew();
label_30:
      return identifier1;
label_33:
      return this.ParseLambdaInvocation(lambda);
label_37:
      return this.ParseTypeAccess((Type) identifier2);
    }

    private Expression ParseIt()
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_6;
          case 2:
            this.NextToken();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 1;
            continue;
          case 3:
            if (this.it != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 2 : 2;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      throw this.ParseError((string) ExpressionParser.TZcomMhwloVeNRf8kPa(993438473 ^ 993442571));
label_6:
      return (Expression) this.it;
    }

    private Expression ParseIif()
    {
      int num = 4;
      Expression[] argumentList;
      int pos;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (argumentList.Length != 3)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 0 : 1;
              continue;
            }
            goto label_6;
          case 3:
            this.NextToken();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
            continue;
          case 4:
            pos = this.token.pos;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 3 : 3;
            continue;
          default:
            argumentList = this.ParseArgumentList();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 2;
            continue;
        }
      }
label_5:
      throw this.ParseError(pos, (string) ExpressionParser.TZcomMhwloVeNRf8kPa(-2099751081 ^ -2099755141));
label_6:
      return this.GenerateConditional(argumentList[0], argumentList[1], argumentList[2], pos);
    }

    private Expression GenerateConditional(
      Expression test,
      Expression expr1,
      Expression expr2,
      int errorPos)
    {
      int num1 = 7;
      string str1;
      string str2;
      while (true)
      {
        int num2 = num1;
        Expression expression1;
        while (true)
        {
          Expression expression2;
          object obj1;
          object obj2;
          Expression expression3;
          switch (num2)
          {
            case 1:
              if (expression2 == null)
              {
                num2 = 3;
                continue;
              }
              goto label_23;
            case 2:
              obj1 = ExpressionParser.TZcomMhwloVeNRf8kPa(1178210108 ^ 1178214362);
              goto label_44;
            case 3:
            case 15:
              goto label_24;
            case 4:
            case 25:
              goto label_25;
            case 5:
              if (expression2 == null)
              {
                num2 = 23;
                continue;
              }
              goto case 8;
            case 6:
              if (ExpressionParser.i3sRlhhxItMoQagKgRK(ExpressionParser.xNfa4VhMkUhKyv7OK94((object) expr1), ExpressionParser.xNfa4VhMkUhKyv7OK94((object) expr2)))
              {
                num2 = 17;
                continue;
              }
              goto label_25;
            case 7:
              // ISSUE: type reference
              if (!ExpressionParser.i3sRlhhxItMoQagKgRK(ExpressionParser.xNfa4VhMkUhKyv7OK94((object) test), ExpressionParser.KAF1pPhmquc8fUailtM(__typeref (bool))))
              {
                num2 = 6;
                continue;
              }
              goto label_27;
            case 8:
              if (expression1 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 2 : 9;
                continue;
              }
              goto case 12;
            case 9:
            case 16:
            case 23:
              if (expr1 == ExpressionParser.nullLiteral)
              {
                num2 = 24;
                continue;
              }
              obj2 = ExpressionParser.UXWy9khU64Y7m676YRf((object) ExpressionParser.xNfa4VhMkUhKyv7OK94((object) expr1));
              goto label_42;
            case 10:
              if (expr1 == ExpressionParser.nullLiteral)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 14 : 7;
                continue;
              }
              expression3 = this.PromoteExpression(expr2, expr1.Type, true);
              break;
            case 11:
              goto label_27;
            case 12:
              expr2 = expression2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 19 : 25;
              continue;
            case 13:
              goto label_23;
            case 14:
              expression3 = (Expression) null;
              break;
            case 17:
              if (expr2 == ExpressionParser.nullLiteral)
              {
                num2 = 19;
                continue;
              }
              goto label_37;
            case 18:
              if (expr2 == ExpressionParser.nullLiteral)
              {
                num2 = 2;
                continue;
              }
              obj1 = (object) expr2.Type.Name;
              goto label_44;
            case 19:
              goto label_10;
            case 20:
              if (expression1 == null)
              {
                num2 = 15;
                continue;
              }
              goto case 1;
            case 21:
              expr1 = expression1;
              num2 = 4;
              continue;
            case 22:
              if (expression2 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 21 : 15;
                continue;
              }
              goto case 5;
            case 24:
              obj2 = (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1597012150 ^ 1597007952);
              goto label_42;
            default:
              if (expression1 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 6 : 22;
                continue;
              }
              goto case 5;
          }
          expression2 = expression3;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 0 : 0;
          continue;
label_42:
          str1 = (string) obj2;
          num2 = 18;
          continue;
label_44:
          str2 = (string) obj1;
          num2 = 20;
        }
label_10:
        Expression expression4 = (Expression) null;
        goto label_38;
label_37:
        expression4 = this.PromoteExpression(expr1, ExpressionParser.xNfa4VhMkUhKyv7OK94((object) expr2), true);
label_38:
        expression1 = expression4;
        num1 = 10;
      }
label_23:
      throw this.ParseError(errorPos, (string) ExpressionParser.TZcomMhwloVeNRf8kPa(874012245 ^ 874008231), (object) str1, (object) str2);
label_24:
      throw this.ParseError(errorPos, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710579288), (object) str1, (object) str2);
label_25:
      return (Expression) ExpressionParser.NUhEDbhsC9F1Rge5Psd((object) test, (object) expr1, (object) expr2);
label_27:
      throw this.ParseError(errorPos, (string) ExpressionParser.TZcomMhwloVeNRf8kPa(1514961705 ^ 1514957743));
    }

    private Expression ParseNew()
    {
      int num1 = 19;
      MemberBinding[] memberBindingArray;
      Type type;
      int pos;
      while (true)
      {
        int num2 = num1;
        List<DynamicProperty> properties;
        Expression expression;
        List<Expression> expressionList;
        string name;
        int index;
        while (true)
        {
          switch (num2)
          {
            case 1:
              expressionList = new List<Expression>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 14 : 7;
              continue;
            case 2:
              type = DynamicExpression.CreateClass((IEnumerable<DynamicProperty>) properties);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 13 : 10;
              continue;
            case 3:
              ++index;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 8 : 20;
              continue;
            case 5:
              goto label_16;
            case 6:
              goto label_5;
            case 7:
              memberBindingArray[index] = (MemberBinding) ExpressionParser.GANVmVhzXKv1j6TbigI((object) type.GetProperty((string) ExpressionParser.XD37AshcvCgMSDA2yNL((object) properties[index])), (object) expressionList[index]);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 3 : 0;
              continue;
            case 8:
              this.NextToken();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 2 : 23;
              continue;
            case 9:
              properties = new List<DynamicProperty>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 1 : 1;
              continue;
            case 10:
              this.NextToken();
              num2 = 5;
              continue;
            case 11:
              goto label_21;
            case 12:
              properties.Add(new DynamicProperty(name, expression.Type));
              num2 = 17;
              continue;
            case 13:
              memberBindingArray = new MemberBinding[properties.Count];
              num2 = 24;
              continue;
            case 14:
            case 23:
              pos = this.token.pos;
              num2 = 6;
              continue;
            case 15:
              this.NextToken();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 9 : 1;
              continue;
            case 16:
              if (!this.TokenIdentifierIs(z2jc63fLkugS1X8Q9N.tE1kD1vbB(589593376 ^ -1977315327 ^ -1459553541)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
                continue;
              }
              goto case 10;
            case 17:
              if (this.token.id == ExpressionParser.TokenId.Comma)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 5 : 8;
                continue;
              }
              goto case 27;
            case 18:
              this.ValidateToken(ExpressionParser.TokenId.OpenParen, z2jc63fLkugS1X8Q9N.tE1kD1vbB(979449278 ^ 979450560));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 15 : 15;
              continue;
            case 19:
              this.NextToken();
              num2 = 18;
              continue;
            case 20:
            case 26:
              if (index >= memberBindingArray.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 4 : 21;
                continue;
              }
              goto case 7;
            case 21:
              goto label_6;
            case 22:
              this.NextToken();
              num2 = 28;
              continue;
            case 24:
              index = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 26 : 17;
              continue;
            case 25:
            case 28:
              expressionList.Add(expression);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 12 : 0;
              continue;
            case 27:
              this.ValidateToken(ExpressionParser.TokenId.CloseParen, (string) ExpressionParser.TZcomMhwloVeNRf8kPa(-1839087379 - 334718690 ^ 2121156645));
              num2 = 11;
              continue;
            default:
              if (expression is MemberExpression memberExpression)
              {
                name = memberExpression.Member.Name;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 20 : 25;
                continue;
              }
              goto label_31;
          }
        }
label_5:
        expression = this.ParseExpression();
        num1 = 16;
        continue;
label_16:
        name = this.GetIdentifier();
        num1 = 22;
        continue;
label_21:
        this.NextToken();
        num1 = 2;
      }
label_6:
      return (Expression) ExpressionParser.PZMCscGBhAvQMOvfWJL(ExpressionParser.juH5Z3GF5GjImv1e2W0(type), (object) memberBindingArray);
label_31:
      throw this.ParseError(pos, (string) ExpressionParser.TZcomMhwloVeNRf8kPa(1199946765 ^ 1199943151));
    }

    private Expression ParseLambdaInvocation(LambdaExpression lambda)
    {
      int num = 3;
      int pos;
      Expression[] argumentList;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_4;
          case 2:
            this.NextToken();
            num = 4;
            continue;
          case 3:
            pos = this.token.pos;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 1 : 2;
            continue;
          case 4:
            argumentList = this.ParseArgumentList();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
            continue;
          default:
            if (this.FindMethod(ExpressionParser.xNfa4VhMkUhKyv7OK94((object) lambda), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107974074), false, argumentList, out MethodBase _) != 1)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 1;
              continue;
            }
            goto label_5;
        }
      }
label_4:
      throw this.ParseError(pos, (string) ExpressionParser.TZcomMhwloVeNRf8kPa(-1710575414 ^ -1710579038));
label_5:
      return (Expression) ExpressionParser.AZJNBCGWK3MyRIawtWo((object) lambda, (object) argumentList);
    }

    private Expression ParseTypeAccess(Type type)
    {
      int num = 8;
      int bestMethod;
      Expression[] argumentList;
      MethodBase method;
      int pos;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_24;
          case 2:
            this.NextToken();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 5 : 0;
            continue;
          case 3:
          case 18:
            goto label_28;
          case 4:
            if (argumentList.Length == 1)
            {
              num = 16;
              continue;
            }
            goto label_22;
          case 5:
            goto label_2;
          case 6:
            if (bestMethod != 1)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 1;
              continue;
            }
            goto label_23;
          case 7:
            this.NextToken();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 0 : 0;
            continue;
          case 8:
            pos = this.token.pos;
            num = 7;
            continue;
          case 9:
            // ISSUE: type reference
            type = ExpressionParser.KAF1pPhmquc8fUailtM(__typeref (Nullable<>)).MakeGenericType(type);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 12 : 9;
            continue;
          case 10:
            if (!ExpressionParser.TNnRioGoMVKlM0VpPWH(type))
            {
              num = 9;
              continue;
            }
            goto label_28;
          case 11:
            bestMethod = this.FindBestMethod((IEnumerable<MethodBase>) type.GetConstructors(), argumentList, out method);
            num = 17;
            continue;
          case 12:
            this.NextToken();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 8 : 14;
            continue;
          case 13:
            argumentList = this.ParseArgumentList();
            num = 11;
            continue;
          case 14:
            if (this.token.id == ExpressionParser.TokenId.OpenParen)
            {
              num = 13;
              continue;
            }
            this.ValidateToken(ExpressionParser.TokenId.Dot, (string) ExpressionParser.TZcomMhwloVeNRf8kPa(1654249598 >> 2 ^ 413558187));
            num = 2;
            continue;
          case 15:
            if (!type.IsValueType)
            {
              num = 18;
              continue;
            }
            goto case 10;
          case 16:
            goto label_21;
          case 17:
            if (bestMethod != 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 6;
              continue;
            }
            goto case 4;
          default:
            if (this.token.id == ExpressionParser.TokenId.Question)
            {
              num = 15;
              continue;
            }
            goto case 14;
        }
      }
label_2:
      return this.ParseMemberAccess(type, (Expression) null);
label_21:
      return this.GenerateConversion(argumentList[0], type, pos);
label_22:
      throw this.ParseError(pos, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345415980), ExpressionParser.stYXaUh085EWUoWhgat(type));
label_23:
      return (Expression) ExpressionParser.Fi0OPoGbin4DuNpQQSb((object) (ConstructorInfo) method, (object) argumentList);
label_24:
      throw this.ParseError(pos, (string) ExpressionParser.TZcomMhwloVeNRf8kPa(-488881205 ^ -488877931), ExpressionParser.stYXaUh085EWUoWhgat(type));
label_28:
      throw this.ParseError(pos, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488877819), ExpressionParser.stYXaUh085EWUoWhgat(type));
    }

    private Expression GenerateConversion(Expression expr, Type type, int errorPos)
    {
      int num1 = 15;
      Type type1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 7:
            case 17:
              goto label_3;
            case 2:
              goto label_31;
            case 3:
              if (type.IsInterface)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 8 : 17;
                continue;
              }
              goto label_4;
            case 4:
              if (type.IsValueType)
                goto case 22;
              else
                goto label_10;
            case 5:
            case 8:
              if (!ExpressionParser.Io2IBDh9UNF0yjdyVXo(type))
              {
                num2 = 12;
                continue;
              }
              goto label_34;
            case 6:
              if (type1.IsInterface)
              {
                num2 = 7;
                continue;
              }
              goto case 3;
            case 9:
              if (ExpressionParser.wWMmdxGG3QByaxCRm6Y(type1))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 24 : 22;
                continue;
              }
              goto case 20;
            case 10:
            case 21:
              goto label_34;
            case 11:
            case 24:
              if (ExpressionParser.wWMmdxGG3QByaxCRm6Y(type))
              {
                num2 = 10;
                continue;
              }
              goto case 5;
            case 12:
            case 23:
            case 25:
              if (!type1.IsAssignableFrom(type))
              {
                num2 = 18;
                continue;
              }
              goto label_3;
            case 13:
              goto label_17;
            case 14:
              if (!ExpressionParser.JjQQTHhdFqCPEsKhvWZ(type1, type))
              {
                if (!type1.IsValueType)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 23 : 20;
                  continue;
                }
                goto case 4;
              }
              else
              {
                num2 = 13;
                continue;
              }
            case 15:
              type1 = expr.Type;
              num2 = 14;
              continue;
            case 16:
            case 19:
              goto label_7;
            case 18:
              if (type.IsAssignableFrom(type1))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 1 : 1;
                continue;
              }
              goto case 6;
            case 20:
              if (!ExpressionParser.Io2IBDh9UNF0yjdyVXo(type1))
              {
                num2 = 8;
                continue;
              }
              goto case 11;
            case 22:
              if (ExpressionParser.TNnRioGoMVKlM0VpPWH(type1))
              {
                num2 = 19;
                continue;
              }
              goto default;
            default:
              if (ExpressionParser.IsNullableType(type))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 16 : 11;
                continue;
              }
              goto case 9;
          }
        }
label_7:
        if (!ExpressionParser.JjQQTHhdFqCPEsKhvWZ(ExpressionParser.sf4koeGhqdpuOwGl0td(type1), ExpressionParser.sf4koeGhqdpuOwGl0td(type)))
        {
          num1 = 9;
          continue;
        }
        goto label_31;
label_10:
        num1 = 25;
      }
label_3:
      return (Expression) ExpressionParser.j7VDV7hJ6wTVTBOdLNA((object) expr, type);
label_4:
      throw this.ParseError(errorPos, (string) ExpressionParser.TZcomMhwloVeNRf8kPa(-105199646 ^ -105196484), ExpressionParser.stYXaUh085EWUoWhgat(type1), ExpressionParser.stYXaUh085EWUoWhgat(type));
label_17:
      return expr;
label_31:
      return (Expression) ExpressionParser.j7VDV7hJ6wTVTBOdLNA((object) expr, type);
label_34:
      return (Expression) ExpressionParser.dZZnnPGEHLVNIqwWNiT((object) expr, type);
    }

    private Expression ParseMemberAccess(Type type, Expression instance)
    {
      int num1 = 4;
      int pos;
      string identifier;
      MethodInfo methodInfo;
      Expression[] argumentList;
      MemberInfo propertyOrField;
      Type genericArgument;
      while (true)
      {
        int num2 = num1;
        Type genericType;
        MethodBase method1;
        int method2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_3;
            case 2:
            case 19:
              goto label_21;
            case 3:
              type = instance.Type;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 12 : 14;
              continue;
            case 4:
              if (instance == null)
                goto case 14;
              else
                goto label_30;
            case 5:
              goto label_17;
            case 6:
              this.NextToken();
              num2 = 10;
              continue;
            case 7:
              argumentList = this.ParseArgumentList();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 13 : 21;
              continue;
            case 8:
              // ISSUE: type reference
              genericType = ExpressionParser.FindGenericType(ExpressionParser.KAF1pPhmquc8fUailtM(__typeref (IEnumerable<>)), type);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
              continue;
            case 9:
              // ISSUE: type reference
              if (!ExpressionParser.i3sRlhhxItMoQagKgRK(type, ExpressionParser.KAF1pPhmquc8fUailtM(__typeref (string))))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 2 : 7;
                continue;
              }
              goto case 8;
            case 10:
              if (this.token.id != ExpressionParser.TokenId.OpenParen)
              {
                propertyOrField = this.FindPropertyOrField(type, identifier, instance == null);
                num2 = 12;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 23 : 0;
              continue;
            case 11:
              goto label_18;
            case 12:
              if (ExpressionParser.wpLy1BGCndfypRCWO1L((object) propertyOrField, (object) null))
              {
                num2 = 18;
                continue;
              }
              goto label_8;
            case 13:
              goto label_16;
            case 14:
              pos = this.token.pos;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 11 : 11;
              continue;
            case 15:
              goto label_5;
            case 16:
              if (!ExpressionParser.IsPredefinedType(ExpressionParser.nufyg4GfPZpS2Cxr7U8((object) methodInfo)))
              {
                num2 = 24;
                continue;
              }
              goto label_11;
            case 17:
              goto label_4;
            case 18:
              goto label_7;
            case 20:
              goto label_14;
            case 21:
              method2 = this.FindMethod(type, identifier, instance == null, argumentList, out method1);
              num2 = 25;
              continue;
            case 22:
              if (method2 == 1)
              {
                methodInfo = (MethodInfo) method1;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 16 : 4;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 15 : 5;
              continue;
            case 23:
              if (instance != null)
              {
                num2 = 9;
                continue;
              }
              goto case 7;
            case 24:
              goto label_10;
            case 25:
              if (method2 == 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 16 : 19;
                continue;
              }
              goto case 22;
            case 26:
              genericArgument = genericType.GetGenericArguments()[0];
              num2 = 20;
              continue;
            default:
              if (genericType != (Type) null)
              {
                num2 = 26;
                continue;
              }
              goto case 7;
          }
        }
label_8:
        if ((object) (propertyOrField as PropertyInfo) != null)
        {
          num1 = 5;
          continue;
        }
        goto label_16;
label_11:
        // ISSUE: type reference
        if (!(methodInfo.ReturnType == ExpressionParser.KAF1pPhmquc8fUailtM(__typeref (void))))
        {
          num1 = 17;
          continue;
        }
        break;
label_18:
        identifier = this.GetIdentifier();
        num1 = 6;
        continue;
label_30:
        num1 = 3;
      }
label_3:
      throw this.ParseError(pos, (string) ExpressionParser.TZcomMhwloVeNRf8kPa(1470998129 - 231418599 ^ 1239576204), (object) identifier, ExpressionParser.stYXaUh085EWUoWhgat(methodInfo.DeclaringType));
label_4:
      return (Expression) ExpressionParser.i8nGnDGQRSscQIHrQM8((object) instance, (object) methodInfo, (object) argumentList);
label_5:
      throw this.ParseError(pos, (string) ExpressionParser.TZcomMhwloVeNRf8kPa(-35995181 ^ -35990339), (object) identifier, ExpressionParser.stYXaUh085EWUoWhgat(type));
label_7:
      throw this.ParseError(pos, (string) ExpressionParser.TZcomMhwloVeNRf8kPa(381945751 ^ 1158627804 ^ 1405834141), (object) identifier, ExpressionParser.stYXaUh085EWUoWhgat(type));
label_10:
      throw this.ParseError(pos, (string) ExpressionParser.TZcomMhwloVeNRf8kPa(-542721635 ^ -542724817), ExpressionParser.stYXaUh085EWUoWhgat(ExpressionParser.nufyg4GfPZpS2Cxr7U8((object) methodInfo)));
label_14:
      return this.ParseAggregate(instance, genericArgument, identifier, pos);
label_16:
      return (Expression) ExpressionParser.U33gD2GvC8qSF0CFLpv((object) instance, (object) (FieldInfo) propertyOrField);
label_17:
      return (Expression) Expression.Property(instance, (PropertyInfo) propertyOrField);
label_21:
      throw this.ParseError(pos, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1642859704 ^ 1642862824), (object) identifier, (object) ExpressionParser.GetTypeName(type));
    }

    private static Type FindGenericType(Type generic, Type type)
    {
      int num1 = 8;
      Type genericType;
      while (true)
      {
        int num2 = num1;
        Type[] interfaces;
        int index;
        Type type1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_21;
            case 2:
              ++index;
              num2 = 21;
              continue;
            case 3:
            case 21:
              if (index < interfaces.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 4 : 0;
                continue;
              }
              goto case 5;
            case 5:
            case 19:
              type = type.BaseType;
              num2 = 18;
              continue;
            case 6:
              if (!generic.IsInterface)
              {
                num2 = 19;
                continue;
              }
              goto case 16;
            case 7:
            case 14:
              if (!type.IsGenericType)
                goto case 6;
              else
                goto label_10;
            case 8:
            case 18:
              if (!ExpressionParser.i3sRlhhxItMoQagKgRK(type, (Type) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 11 : 20;
                continue;
              }
              goto case 13;
            case 9:
            case 20:
              goto label_22;
            case 10:
              goto label_14;
            case 11:
              genericType = ExpressionParser.xicM9VG8aF6bXXvuQR2(generic, type1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 15 : 4;
              continue;
            case 12:
              if (!ExpressionParser.JjQQTHhdFqCPEsKhvWZ(type.GetGenericTypeDefinition(), generic))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 6;
                continue;
              }
              goto label_18;
            case 13:
              // ISSUE: type reference
              if (ExpressionParser.i3sRlhhxItMoQagKgRK(type, ExpressionParser.KAF1pPhmquc8fUailtM(__typeref (object))))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 14 : 14;
                continue;
              }
              goto label_22;
            case 15:
              if (!ExpressionParser.i3sRlhhxItMoQagKgRK(genericType, (Type) null))
              {
                num2 = 2;
                continue;
              }
              goto label_14;
            case 16:
              interfaces = type.GetInterfaces();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 1;
              continue;
            case 17:
              goto label_18;
            default:
              type1 = interfaces[index];
              num2 = 11;
              continue;
          }
        }
label_10:
        num1 = 12;
        continue;
label_21:
        index = 0;
        num1 = 3;
      }
label_14:
      return genericType;
label_18:
      return type;
label_22:
      return (Type) null;
    }

    private Expression ParseAggregate(
      Expression instance,
      Type elementType,
      string methodName,
      int errorPos)
    {
      int num1 = 2;
      MethodBase method;
      Type[] typeArray;
      Expression[] args;
      while (true)
      {
        int num2 = num1;
        ParameterExpression parameterExpression;
        ParameterExpression it;
        while (true)
        {
          switch (num2)
          {
            case 1:
              parameterExpression = (ParameterExpression) ExpressionParser.US6aAkGZM6smVMK28FU(elementType, (object) "");
              num2 = 3;
              continue;
            case 2:
              it = this.it;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 1 : 0;
              continue;
            case 3:
              this.it = parameterExpression;
              num2 = 9;
              continue;
            case 4:
              goto label_6;
            case 5:
            case 13:
              goto label_3;
            case 7:
              goto label_20;
            case 8:
              this.it = it;
              num2 = 16;
              continue;
            case 9:
              args = this.ParseArgumentList();
              num2 = 8;
              continue;
            case 10:
            case 11:
              goto label_4;
            case 12:
              goto label_11;
            case 14:
              args = new Expression[1]{ instance };
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 5 : 5;
              continue;
            case 15:
            case 17:
              typeArray = new Type[2]
              {
                elementType,
                ExpressionParser.xNfa4VhMkUhKyv7OK94((object) args[0])
              };
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
              continue;
            case 16:
              // ISSUE: type reference
              if (this.FindMethod(ExpressionParser.KAF1pPhmquc8fUailtM(__typeref (ExpressionParser.IEnumerableSignatures)), methodName, false, args, out method) == 1)
              {
                if (ExpressionParser.AJYpf9Guxe4ohobF9cA(ExpressionParser.UXWy9khU64Y7m676YRf((object) method), ExpressionParser.TZcomMhwloVeNRf8kPa(-787452571 ^ -787448841)))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 15 : 9;
                  continue;
                }
                goto label_6;
              }
              else
                goto label_9;
            default:
              if (args.Length != 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 1 : 11;
                continue;
              }
              goto case 14;
          }
        }
label_4:
        args = new Expression[2]
        {
          instance,
          (Expression) Expression.Lambda(args[0], parameterExpression)
        };
        num1 = 13;
        continue;
label_6:
        if (ExpressionParser.AJYpf9Guxe4ohobF9cA((object) method.Name, ExpressionParser.TZcomMhwloVeNRf8kPa(-477139494 ^ -477136058)))
        {
          num1 = 17;
          continue;
        }
        goto label_20;
label_9:
        num1 = 12;
        continue;
label_20:
        typeArray = new Type[1]{ elementType };
        num1 = 6;
      }
label_3:
      return (Expression) ExpressionParser.VHg54LGIC2SWgIt8OZ7(typeof (Enumerable), ExpressionParser.UXWy9khU64Y7m676YRf((object) method), (object) typeArray, (object) args);
label_11:
      throw this.ParseError(errorPos, (string) ExpressionParser.TZcomMhwloVeNRf8kPa(2045296739 + 1688595713 ^ -561071268), (object) methodName);
    }

    private Expression[] ParseArgumentList()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.ValidateToken(ExpressionParser.TokenId.OpenParen, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281844794));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 0 : 0;
            continue;
          case 2:
            if (this.token.id == ExpressionParser.TokenId.CloseParen)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 3 : 0;
              continue;
            }
            goto label_7;
          case 3:
            goto label_3;
          default:
            this.NextToken();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 1 : 2;
            continue;
        }
      }
label_3:
      Expression[] argumentList = new Expression[0];
      goto label_8;
label_7:
      argumentList = this.ParseArguments();
label_8:
      this.ValidateToken(ExpressionParser.TokenId.CloseParen, (string) ExpressionParser.TZcomMhwloVeNRf8kPa(964881585 - -1459193222 ^ -1870897127));
      this.NextToken();
      return argumentList;
    }

    private Expression[] ParseArguments()
    {
      int num = 4;
      List<Expression> expressionList;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 3:
            expressionList.Add(this.ParseExpression());
            num = 2;
            continue;
          case 2:
            if (this.token.id == ExpressionParser.TokenId.Comma)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 4:
            expressionList = new List<Expression>();
            num = 3;
            continue;
          case 5:
            goto label_2;
          default:
            this.NextToken();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 1 : 1;
            continue;
        }
      }
label_2:
      return (Expression[]) ExpressionParser.nQljjAGVO5bmkogFQLi((object) expressionList);
    }

    private Expression ParseElementAccess(Expression expr)
    {
      int num = 15;
      int indexer;
      int pos;
      Expression[] arguments;
      Expression index;
      MethodBase method;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_15;
          case 2:
            if (arguments.Length == 1)
            {
              // ISSUE: type reference
              index = this.PromoteExpression(arguments[0], ExpressionParser.KAF1pPhmquc8fUailtM(__typeref (int)), true);
              num = 16;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 9 : 0;
            continue;
          case 3:
            if (ExpressionParser.xNfa4VhMkUhKyv7OK94((object) expr).GetArrayRank() == 1)
            {
              num = 2;
              continue;
            }
            goto label_5;
          case 4:
            goto label_16;
          case 5:
            if (indexer != 1)
            {
              num = 13;
              continue;
            }
            goto label_8;
          case 6:
            if (!ExpressionParser.xNfa4VhMkUhKyv7OK94((object) expr).IsArray)
            {
              indexer = this.FindIndexer(ExpressionParser.xNfa4VhMkUhKyv7OK94((object) expr), arguments, out method);
              num = 12;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 3 : 3;
            continue;
          case 7:
            goto label_7;
          case 8:
            this.NextToken();
            num = 11;
            continue;
          case 9:
            goto label_5;
          case 10:
            this.ValidateToken(ExpressionParser.TokenId.CloseBracket, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669371371 ^ 1669366605));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 0;
            continue;
          case 11:
            arguments = this.ParseArguments();
            num = 10;
            continue;
          case 12:
            if (indexer != 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 5 : 5;
              continue;
            }
            goto label_7;
          case 13:
            goto label_9;
          case 14:
            this.ValidateToken(ExpressionParser.TokenId.OpenBracket, (string) ExpressionParser.TZcomMhwloVeNRf8kPa(-441065788 ^ -2092910478 ^ 1727359432));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 8 : 7;
            continue;
          case 15:
            pos = this.token.pos;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 6 : 14;
            continue;
          case 16:
            if (index != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 2 : 4;
              continue;
            }
            goto label_15;
          default:
            this.NextToken();
            num = 6;
            continue;
        }
      }
label_5:
      throw this.ParseError(pos, (string) ExpressionParser.TZcomMhwloVeNRf8kPa(333888594 ^ 1075625116 ^ 1408898590));
label_7:
      throw this.ParseError(pos, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-138018305 ^ -138013077), (object) ExpressionParser.GetTypeName(ExpressionParser.xNfa4VhMkUhKyv7OK94((object) expr)));
label_8:
      return (Expression) ExpressionParser.i8nGnDGQRSscQIHrQM8((object) expr, (object) (MethodInfo) method, (object) arguments);
label_9:
      throw this.ParseError(pos, (string) ExpressionParser.TZcomMhwloVeNRf8kPa(964881585 - -1459193222 ^ -1870895653), ExpressionParser.stYXaUh085EWUoWhgat(ExpressionParser.xNfa4VhMkUhKyv7OK94((object) expr)));
label_15:
      throw this.ParseError(pos, (string) ExpressionParser.TZcomMhwloVeNRf8kPa(381945751 ^ 1158627804 ^ 1405833589));
label_16:
      return (Expression) Expression.ArrayIndex(expr, index);
    }

    private static bool IsPredefinedType(Type type)
    {
      int num = 6;
      Type[] predefinedTypes;
      int index;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_8;
          case 3:
          case 4:
            if (index < predefinedTypes.Length)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
              continue;
            }
            goto label_8;
          case 5:
            index = 0;
            num = 3;
            continue;
          case 6:
            predefinedTypes = ExpressionParser.predefinedTypes;
            num = 5;
            continue;
          case 7:
            goto label_4;
          default:
            if (ExpressionParser.JjQQTHhdFqCPEsKhvWZ(predefinedTypes[index], type))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 6 : 7;
              continue;
            }
            ++index;
            num = 4;
            continue;
        }
      }
label_4:
      return true;
label_8:
      return false;
    }

    private static bool IsNullableType(Type type)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (type.IsGenericType)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      // ISSUE: type reference
      return ExpressionParser.JjQQTHhdFqCPEsKhvWZ(type.GetGenericTypeDefinition(), ExpressionParser.KAF1pPhmquc8fUailtM(__typeref (Nullable<>)));
label_5:
      return false;
    }

    private static Type GetNonNullableType(Type type)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (ExpressionParser.TNnRioGoMVKlM0VpPWH(type))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 1;
              continue;
            }
            goto label_2;
          default:
            goto label_2;
        }
      }
label_2:
      return type;
label_3:
      return type.GetGenericArguments()[0];
    }

    private static string GetTypeName(Type type)
    {
      int num = 4;
      Type type1;
      string typeName;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (ExpressionParser.i3sRlhhxItMoQagKgRK(type, type1))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            goto label_4;
          case 3:
            typeName = (string) ExpressionParser.UXWy9khU64Y7m676YRf((object) type1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 1 : 1;
            continue;
          case 4:
            type1 = ExpressionParser.sf4koeGhqdpuOwGl0td(type);
            num = 3;
            continue;
          default:
            typeName = (string) ExpressionParser.UhP449h7vEDexhBCxa9((object) typeName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917998801 >> 2 ^ 479497726));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 2 : 1;
            continue;
        }
      }
label_4:
      return typeName;
    }

    private static bool IsNumericType(Type type) => ExpressionParser.WhJhC3GSiv92ur0R5Yo(type) != 0;

    private static bool IsSignedIntegralType(Type type) => ExpressionParser.WhJhC3GSiv92ur0R5Yo(type) == 2;

    private static bool IsUnsignedIntegralType(Type type) => ExpressionParser.WhJhC3GSiv92ur0R5Yo(type) == 3;

    private static int GetNumericTypeKind(Type type)
    {
      int num = 1;
      TypeCode typeCode;
      while (true)
      {
        switch (num)
        {
          case 1:
            type = ExpressionParser.sf4koeGhqdpuOwGl0td(type);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            goto label_5;
          case 4:
            goto label_7;
          case 5:
            switch (typeCode)
            {
              case TypeCode.Char:
              case TypeCode.Single:
              case TypeCode.Double:
              case TypeCode.Decimal:
                goto label_2;
              case TypeCode.SByte:
              case TypeCode.Int16:
              case TypeCode.Int32:
              case TypeCode.Int64:
                goto label_3;
              case TypeCode.Byte:
              case TypeCode.UInt16:
              case TypeCode.UInt32:
              case TypeCode.UInt64:
                goto label_4;
              default:
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 3 : 3;
                continue;
            }
          default:
            if (!type.IsEnum)
            {
              typeCode = Type.GetTypeCode(type);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 5 : 4;
              continue;
            }
            num = 4;
            continue;
        }
      }
label_2:
      return 1;
label_3:
      return 2;
label_4:
      return 3;
label_5:
      return 0;
label_7:
      return 0;
    }

    private static bool IsEnumType(Type type) => ExpressionParser.sf4koeGhqdpuOwGl0td(type).IsEnum;

    private void CheckAndPromoteOperand(
      Type signatures,
      string opName,
      ref Expression expr,
      int errorPos)
    {
      int num = 3;
      Expression[] args;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            goto label_3;
          case 2:
            if (this.FindMethod(signatures, (string) ExpressionParser.TZcomMhwloVeNRf8kPa(-87337865 ^ -87339993), false, args, out MethodBase _) == 1)
            {
              expr = args[0];
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 1 : 0;
            continue;
          case 3:
            args = new Expression[1]{ expr };
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 2 : 1;
            continue;
          default:
            goto label_8;
        }
      }
label_2:
      return;
label_8:
      return;
label_3:
      throw this.ParseError(errorPos, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70000805), (object) opName, ExpressionParser.stYXaUh085EWUoWhgat(ExpressionParser.xNfa4VhMkUhKyv7OK94((object) args[0])));
    }

    private void CheckAndPromoteOperands(
      Type signatures,
      string opName,
      ref Expression left,
      ref Expression right,
      int errorPos)
    {
      int num = 1;
      Expression[] args;
      while (true)
      {
        switch (num)
        {
          case 1:
            args = new Expression[2]{ left, right };
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            right = args[1];
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 1 : 2;
            continue;
          case 4:
            goto label_7;
          default:
            if (this.FindMethod(signatures, (string) ExpressionParser.TZcomMhwloVeNRf8kPa(-1939377524 ^ -1939379492), false, args, out MethodBase _) != 1)
            {
              num = 4;
              continue;
            }
            left = args[0];
            num = 3;
            continue;
        }
      }
label_2:
      return;
label_7:
      throw this.IncompatibleOperandsError(opName, left, right, errorPos);
    }

    private Exception IncompatibleOperandsError(
      string opName,
      Expression left,
      Expression right,
      int pos)
    {
      return this.ParseError(pos, (string) ExpressionParser.TZcomMhwloVeNRf8kPa(1819636893 << 3 ^ 1672199208), (object) opName, ExpressionParser.stYXaUh085EWUoWhgat(ExpressionParser.xNfa4VhMkUhKyv7OK94((object) left)), ExpressionParser.stYXaUh085EWUoWhgat(ExpressionParser.xNfa4VhMkUhKyv7OK94((object) right)));
    }

    private MemberInfo FindPropertyOrField(Type type, string memberName, bool staticAccess)
    {
      int num1 = 1;
      IEnumerator<Type> enumerator;
      BindingFlags bindingAttr;
      while (true)
      {
        switch (num1)
        {
          case 1:
            bindingAttr = (BindingFlags) (18 | (!staticAccess ? 4 : 8));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            goto label_4;
          default:
            enumerator = ExpressionParser.SelfAndBaseTypes(type).GetEnumerator();
            num1 = 3;
            continue;
        }
      }
label_2:
      return (MemberInfo) null;
label_4:
      MemberInfo propertyOrField;
      try
      {
label_9:
        if (ExpressionParser.ldp1IJGi5QyVT4i2JIZ((object) enumerator))
          goto label_11;
        else
          goto label_10;
label_5:
        MemberInfo[] members;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              propertyOrField = members[0];
              num2 = 4;
              continue;
            case 2:
              goto label_2;
            case 3:
              goto label_11;
            case 4:
              goto label_3;
            case 5:
              if (members.Length != 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 1;
                continue;
              }
              goto label_9;
            default:
              goto label_9;
          }
        }
label_10:
        num2 = 2;
        goto label_5;
label_11:
        members = enumerator.Current.FindMembers(MemberTypes.Field | MemberTypes.Property, bindingAttr, Type.FilterNameIgnoreCase, (object) memberName);
        num2 = 5;
        goto label_5;
      }
      finally
      {
        if (enumerator != null)
        {
          int num3 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0)
            num3 = 1;
          while (true)
          {
            switch (num3)
            {
              case 1:
                ExpressionParser.fMBpO3GRbi1fwKK0v55((object) enumerator);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
                continue;
              default:
                goto label_17;
            }
          }
        }
label_17:;
      }
label_3:
      return propertyOrField;
    }

    private int FindMethod(
      Type type,
      string methodName,
      bool staticAccess,
      Expression[] args,
      out MethodBase method)
    {
      int num1 = 3;
      int method1;
      IEnumerator<Type> enumerator;
      BindingFlags bindingAttr;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_3;
          case 2:
            enumerator = ExpressionParser.SelfAndBaseTypes(type).GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 0 : 0;
            continue;
          case 3:
            bindingAttr = (BindingFlags) (18 | (staticAccess ? 8 : 4));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 2 : 1;
            continue;
          case 4:
label_2:
            method = (MethodBase) null;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 1;
            continue;
          default:
            try
            {
label_13:
              if (enumerator.MoveNext())
                goto label_9;
              else
                goto label_14;
label_7:
              int bestMethod;
              MemberInfo[] members;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    if (bestMethod != 0)
                    {
                      num2 = 5;
                      continue;
                    }
                    goto label_13;
                  case 2:
                    bestMethod = this.FindBestMethod(members.Cast<MethodBase>(), args, out method);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 1 : 1;
                    continue;
                  case 3:
                    goto label_13;
                  case 4:
                    goto label_2;
                  case 5:
                    method1 = bestMethod;
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 6 : 6;
                    continue;
                  case 6:
                    goto label_4;
                  default:
                    goto label_9;
                }
              }
label_9:
              members = enumerator.Current.FindMembers(MemberTypes.Method, bindingAttr, Type.FilterNameIgnoreCase, (object) methodName);
              num2 = 2;
              goto label_7;
label_14:
              num2 = 4;
              goto label_7;
            }
            finally
            {
              int num3;
              if (enumerator == null)
                num3 = 2;
              else
                goto label_18;
label_17:
              switch (num3)
              {
                case 1:
                case 2:
              }
label_18:
              ExpressionParser.fMBpO3GRbi1fwKK0v55((object) enumerator);
              num3 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0)
              {
                num3 = 1;
                goto label_17;
              }
              else
                goto label_17;
            }
        }
      }
label_3:
      return 0;
label_4:
      return method1;
    }

    private int FindIndexer(Type type, Expression[] args, out MethodBase method)
    {
      int num1 = 2;
      int indexer;
      while (true)
      {
        int num2 = num1;
        IEnumerator<Type> enumerator;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_7;
            case 2:
              enumerator = ExpressionParser.SelfAndBaseTypes(type).GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 1 : 1;
              continue;
            case 3:
              goto label_3;
            default:
              goto label_5;
          }
        }
label_5:
        method = (MethodBase) null;
        num1 = 3;
        continue;
label_7:
        try
        {
label_11:
          if (ExpressionParser.ldp1IJGi5QyVT4i2JIZ((object) enumerator))
            goto label_15;
          else
            goto label_12;
label_8:
          int bestMethod;
          IEnumerable<MethodBase> methods;
          MemberInfo[] defaultMembers;
          int num3;
          while (true)
          {
            switch (num3)
            {
              case 1:
                bestMethod = this.FindBestMethod(methods, args, out method);
                num3 = 4;
                continue;
              case 2:
                indexer = bestMethod;
                num3 = 7;
                continue;
              case 3:
                goto label_15;
              case 4:
                if (bestMethod == 0)
                {
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 0 : 0;
                  continue;
                }
                goto case 2;
              case 5:
                if (defaultMembers.Length != 0)
                {
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 3 : 9;
                  continue;
                }
                goto label_11;
              case 6:
                goto label_5;
              case 7:
                goto label_4;
              case 9:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                methods = defaultMembers.OfType<PropertyInfo>().Select<PropertyInfo, MethodBase>((Func<PropertyInfo, MethodBase>) (p => (MethodBase) ExpressionParser.\u003C\u003Ec.nh27oCf6rbdg64ZenNfM((object) p))).Where<MethodBase>((Func<MethodBase, bool>) (m => ExpressionParser.\u003C\u003Ec.O621GAf6g3fZ80Aqx2Mk((object) m, (object) null)));
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 1 : 1;
                continue;
              default:
                goto label_11;
            }
          }
label_12:
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 6 : 5;
          goto label_8;
label_15:
          defaultMembers = enumerator.Current.GetDefaultMembers();
          num3 = 5;
          goto label_8;
        }
        finally
        {
          if (enumerator != null)
          {
            int num4 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
              num4 = 0;
            while (true)
            {
              switch (num4)
              {
                case 1:
                  goto label_24;
                default:
                  ExpressionParser.fMBpO3GRbi1fwKK0v55((object) enumerator);
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 1;
                  continue;
              }
            }
          }
label_24:;
        }
      }
label_3:
      return 0;
label_4:
      return indexer;
    }

    private static IEnumerable<Type> SelfAndBaseTypes(Type type)
    {
      if (!type.IsInterface)
        return ExpressionParser.SelfAndBaseClasses(type);
      List<Type> types = new List<Type>();
      ExpressionParser.AddInterface(types, type);
      return (IEnumerable<Type>) types;
    }

    private static IEnumerable<Type> SelfAndBaseClasses(Type type) => (IEnumerable<Type>) new ExpressionParser.\u003CSelfAndBaseClasses\u003Ed__78(-2)
    {
      \u003C\u003E3__type = type
    };

    private static void AddInterface(List<Type> types, Type type)
    {
      if (types.Contains(type))
        return;
      types.Add(type);
      foreach (Type type1 in type.GetInterfaces())
        ExpressionParser.AddInterface(types, type1);
    }

    private int FindBestMethod(
      IEnumerable<MethodBase> methods,
      Expression[] args,
      out MethodBase method)
    {
      // ISSUE: reference to a compiler-generated method
      ExpressionParser.MethodData[] applicable = methods.Select<MethodBase, ExpressionParser.MethodData>((Func<MethodBase, ExpressionParser.MethodData>) (m => new ExpressionParser.MethodData()
      {
        MethodBase = (object) m,
        Parameters = ExpressionParser.\u003C\u003Ec.msVZh3f65R5rjgAHNA3W((object) m)
      })).Where<ExpressionParser.MethodData>((Func<ExpressionParser.MethodData, bool>) (m => this.IsApplicable(m, args))).ToArray<ExpressionParser.MethodData>();
      if (applicable.Length > 1)
        applicable = ((IEnumerable<ExpressionParser.MethodData>) applicable).Where<ExpressionParser.MethodData>((Func<ExpressionParser.MethodData, bool>) (m =>
        {
          int num1 = 3;
          ExpressionParser.MethodData m1;
          // ISSUE: variable of a compiler-generated type
          ExpressionParser.\u003C\u003Ec__DisplayClass81_0 cDisplayClass810;
          while (true)
          {
            switch (num1)
            {
              case 1:
                m1 = m;
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
                continue;
              case 2:
                cDisplayClass810 = this;
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 1 : 1;
                continue;
              case 3:
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 2;
                continue;
              default:
                goto label_4;
            }
          }
label_4:
          return ((IEnumerable<ExpressionParser.MethodData>) applicable).All<ExpressionParser.MethodData>((Func<ExpressionParser.MethodData, bool>) (n =>
          {
            int num2 = 1;
            while (true)
            {
              switch (num2)
              {
                case 1:
                  if (m1 != n)
                  {
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 0 : 0;
                    continue;
                  }
                  goto label_5;
                default:
                  goto label_4;
              }
            }
label_4:
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            return ExpressionParser.\u003C\u003Ec__DisplayClass81_1.YYSvnAfHGdnaREBZpkkH((object) cDisplayClass810.args, (object) m1, (object) n);
label_5:
            return true;
          }));
        })).ToArray<ExpressionParser.MethodData>();
      if (applicable.Length == 1)
      {
        ExpressionParser.MethodData methodData = applicable[0];
        for (int index = 0; index < args.Length; ++index)
          args[index] = (Expression) methodData.Args[index];
        method = (MethodBase) methodData.MethodBase;
      }
      else
        method = (MethodBase) null;
      return applicable.Length;
    }

    private bool IsApplicable(ExpressionParser.MethodData method, Expression[] args)
    {
      int num1 = 2;
      while (true)
      {
        int num2 = num1;
        int index;
        ParameterInfo parameter;
        Expression expression;
        Expression[] expressionArray;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_11;
            case 2:
              if (method.Parameters.Length != args.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 1;
                continue;
              }
              goto label_12;
            case 3:
              if (!ExpressionParser.epG7hyGqA2M2eHroPVQ((object) parameter))
              {
                expression = this.PromoteExpression(args[index], parameter.ParameterType, false);
                num2 = 6;
                continue;
              }
              num2 = 7;
              continue;
            case 4:
              ++index;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
              continue;
            case 5:
            case 10:
              goto label_14;
            case 6:
              if (expression == null)
              {
                num2 = 13;
                continue;
              }
              expressionArray[index] = expression;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 4 : 3;
              continue;
            case 7:
              goto label_4;
            case 8:
              goto label_3;
            case 9:
              method.Args = (object) expressionArray;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 7 : 8;
              continue;
            case 11:
              index = 0;
              num2 = 12;
              continue;
            case 13:
              goto label_19;
            default:
              if (index < args.Length)
              {
                num2 = 10;
                continue;
              }
              goto case 9;
          }
        }
label_12:
        expressionArray = new Expression[args.Length];
        num1 = 11;
        continue;
label_14:
        parameter = (ParameterInfo) method.Parameters[index];
        num1 = 3;
      }
label_3:
      return true;
label_4:
      return false;
label_11:
      return false;
label_19:
      return false;
    }

    private Expression PromoteExpression(Expression expr, Type type, bool exact)
    {
      int num1 = 11;
      object obj;
      while (true)
      {
        int num2 = num1;
        Type type1;
        ConstantExpression key;
        string str;
        TypeCode typeCode;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!ExpressionParser.TNnRioGoMVKlM0VpPWH(type))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 15 : 4;
                continue;
              }
              goto label_10;
            case 2:
              goto label_20;
            case 3:
            case 6:
            case 17:
            case 21:
            case 24:
label_22:
              if (obj != null)
              {
                num2 = 27;
                continue;
              }
              goto case 9;
            case 4:
              typeCode = ExpressionParser.a8JAGJGXKH2RUp32h9S(ExpressionParser.xNfa4VhMkUhKyv7OK94((object) key));
              num2 = 5;
              continue;
            case 5:
              switch (typeCode)
              {
                case TypeCode.Int32:
                case TypeCode.UInt32:
                case TypeCode.Int64:
                case TypeCode.UInt64:
                  goto label_25;
                case TypeCode.Single:
                case TypeCode.Decimal:
                case TypeCode.DateTime:
                case TypeCode.Object | TypeCode.DateTime:
                  goto label_22;
                case TypeCode.Double:
                  goto label_17;
                case TypeCode.String:
                  goto label_14;
                default:
                  num2 = 3;
                  continue;
              }
            case 7:
              key = (ConstantExpression) expr;
              num2 = 23;
              continue;
            case 8:
            case 16:
              goto label_10;
            case 9:
            case 15:
            case 19:
              if (ExpressionParser.yU3fV3Gn2T7jO4wHQUI(ExpressionParser.xNfa4VhMkUhKyv7OK94((object) expr), type))
                goto case 26;
              else
                goto label_9;
            case 10:
              if (!(expr is ConstantExpression))
              {
                num2 = 19;
                continue;
              }
              goto case 7;
            case 11:
              if (!ExpressionParser.JjQQTHhdFqCPEsKhvWZ(expr.Type, type))
              {
                num2 = 10;
                continue;
              }
              goto label_26;
            case 12:
label_25:
              obj = ExpressionParser.SwLclmGTgRtJvlS5fPt((object) str, type1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 8 : 17;
              continue;
            case 13:
              obj = ExpressionParser.SwLclmGTgRtJvlS5fPt((object) str, type1);
              num2 = 21;
              continue;
            case 14:
label_14:
              obj = ExpressionParser.F0vtwDGk3JQbAhpNZBu((object) str, type1);
              num2 = 24;
              continue;
            case 18:
              goto label_26;
            case 20:
              goto label_19;
            case 22:
              type1 = ExpressionParser.sf4koeGhqdpuOwGl0td(type);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 28 : 27;
              continue;
            case 23:
              if (key != ExpressionParser.nullLiteral)
              {
                if (!this.literals.TryGetValue((Expression) key, out str))
                {
                  num2 = 9;
                  continue;
                }
                goto case 22;
              }
              else
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
                continue;
              }
            case 25:
              goto label_21;
            case 26:
              if (!(type.IsValueType | exact))
              {
                num2 = 2;
                continue;
              }
              goto label_19;
            case 27:
              goto label_7;
            case 28:
              obj = (object) null;
              num2 = 4;
              continue;
            case 29:
label_17:
              // ISSUE: type reference
              if (!(type1 == ExpressionParser.KAF1pPhmquc8fUailtM(__typeref (Decimal))))
              {
                num2 = 6;
                continue;
              }
              goto case 13;
            default:
              if (!type.IsValueType)
              {
                num2 = 16;
                continue;
              }
              goto case 1;
          }
        }
label_9:
        num1 = 25;
      }
label_7:
      return (Expression) ExpressionParser.ihkCtuGKbgQLsdAR7pg(obj, type);
label_10:
      return (Expression) ExpressionParser.ihkCtuGKbgQLsdAR7pg((object) null, type);
label_19:
      return (Expression) ExpressionParser.j7VDV7hJ6wTVTBOdLNA((object) expr, type);
label_20:
      return expr;
label_21:
      return (Expression) null;
label_26:
      return expr;
    }

    private static object ParseNumber(object text, Type type)
    {
      int num = 20;
      int result1;
      uint result2;
      byte result3;
      short result4;
      long result5;
      ulong result6;
      double result7;
      Decimal result8;
      TypeCode typeCode;
      ushort result9;
      sbyte result10;
      float result11;
      while (true)
      {
        switch (num)
        {
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
            goto label_38;
          case 5:
            goto label_34;
          case 7:
            goto label_14;
          case 9:
            goto label_5;
          case 11:
            goto label_31;
          case 12:
            goto label_37;
          case 13:
            goto label_8;
          case 16:
label_26:
            if (!sbyte.TryParse((string) text, out result10))
            {
              num = 10;
              continue;
            }
            goto label_34;
          case 17:
            goto label_2;
          case 18:
            goto label_28;
          case 19:
            switch (typeCode)
            {
              case TypeCode.SByte:
                goto label_26;
              case TypeCode.Byte:
                if (!byte.TryParse((string) text, out result3))
                {
                  num = 22;
                  continue;
                }
                goto label_5;
              case TypeCode.Int16:
                if (short.TryParse((string) text, out result4))
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 0 : 0;
                  continue;
                }
                goto label_38;
              case TypeCode.UInt16:
                if (ushort.TryParse((string) text, out result9))
                {
                  num = 21;
                  continue;
                }
                goto label_38;
              case TypeCode.Int32:
                if (!int.TryParse((string) text, out result1))
                {
                  num = 6;
                  continue;
                }
                goto label_2;
              case TypeCode.UInt32:
                if (!uint.TryParse((string) text, out result2))
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 9 : 15;
                  continue;
                }
                goto label_11;
              case TypeCode.Int64:
                if (!long.TryParse((string) text, out result5))
                {
                  num = 14;
                  continue;
                }
                goto label_8;
              case TypeCode.UInt64:
                if (!ulong.TryParse((string) text, out result6))
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 2 : 1;
                  continue;
                }
                goto label_28;
              case TypeCode.Single:
                if (!float.TryParse((string) text, out result11))
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 1;
                  continue;
                }
                goto label_31;
              case TypeCode.Double:
                if (!double.TryParse((string) text, out result7))
                {
                  num = 4;
                  continue;
                }
                goto label_14;
              case TypeCode.Decimal:
                if (!Decimal.TryParse((string) text, out result8))
                {
                  num = 8;
                  continue;
                }
                goto label_37;
              default:
                num = 3;
                continue;
            }
          case 20:
            typeCode = Type.GetTypeCode(ExpressionParser.sf4koeGhqdpuOwGl0td(type));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 9 : 19;
            continue;
          case 21:
            goto label_19;
          case 23:
            goto label_11;
          default:
            goto label_22;
        }
      }
label_2:
      return (object) result1;
label_5:
      return (object) result3;
label_8:
      return (object) result5;
label_11:
      return (object) result2;
label_14:
      return (object) result7;
label_19:
      return (object) result9;
label_22:
      return (object) result4;
label_28:
      return (object) result6;
label_31:
      return (object) result11;
label_34:
      return (object) result10;
label_37:
      return (object) result8;
label_38:
      return (object) null;
    }

    private static object ParseEnum(object name, Type type)
    {
      int num = 2;
      MemberInfo[] members;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_6;
          case 2:
            if (!type.IsEnum)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 1 : 0;
              continue;
            }
            goto case 4;
          case 3:
            goto label_5;
          case 4:
            members = type.FindMembers(MemberTypes.Field, BindingFlags.DeclaredOnly | BindingFlags.Static | BindingFlags.Public, Type.FilterNameIgnoreCase, name);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
            continue;
          default:
            if (members.Length != 0)
            {
              num = 3;
              continue;
            }
            goto label_6;
        }
      }
label_5:
      return ExpressionParser.QfgMoVGOu7abmasC3Ar((object) (FieldInfo) members[0], (object) null);
label_6:
      return (object) null;
    }

    private static bool IsCompatibleWith(Type source, Type target)
    {
      int num1 = 28;
      while (true)
      {
        int num2 = num1;
        TypeCode typeCode1;
        while (true)
        {
          Type type1;
          Type type2;
          TypeCode typeCode2;
          int num3;
          int num4;
          switch (num2)
          {
            case 1:
              if (!(type1 != source))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 26 : 20;
                continue;
              }
              goto case 7;
            case 2:
label_48:
              switch (typeCode1)
              {
                case TypeCode.SByte:
                case TypeCode.Int16:
                case TypeCode.Int32:
                case TypeCode.Int64:
                case TypeCode.Single:
                case TypeCode.Double:
                case TypeCode.Decimal:
                  goto label_23;
                case TypeCode.Byte:
                case TypeCode.UInt16:
                case TypeCode.UInt32:
                case TypeCode.UInt64:
                  goto label_46;
                default:
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 1 : 12;
                  continue;
              }
            case 3:
              num3 = 1;
              break;
            case 4:
            case 8:
            case 9:
            case 10:
            case 12:
            case 25:
              goto label_46;
            case 5:
              goto label_23;
            case 6:
              goto label_14;
            case 7:
              if (!ExpressionParser.JjQQTHhdFqCPEsKhvWZ(type2, target))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 1 : 33;
                continue;
              }
              goto label_38;
            case 11:
              goto label_11;
            case 13:
              type1 = ExpressionParser.sf4koeGhqdpuOwGl0td(source);
              num2 = 17;
              continue;
            case 14:
              switch (typeCode2)
              {
                case TypeCode.SByte:
                  goto label_48;
                case TypeCode.Byte:
                  switch (typeCode1)
                  {
                    case TypeCode.Byte:
                    case TypeCode.Int16:
                    case TypeCode.UInt16:
                    case TypeCode.Int32:
                    case TypeCode.UInt32:
                    case TypeCode.Int64:
                    case TypeCode.UInt64:
                    case TypeCode.Single:
                    case TypeCode.Double:
                    case TypeCode.Decimal:
                      goto label_14;
                    default:
                      num2 = 25;
                      continue;
                  }
                case TypeCode.Int16:
                  goto label_15;
                case TypeCode.UInt16:
                  switch (typeCode1)
                  {
                    case TypeCode.UInt16:
                    case TypeCode.Int32:
                    case TypeCode.UInt32:
                    case TypeCode.Int64:
                    case TypeCode.UInt64:
                    case TypeCode.Single:
                    case TypeCode.Double:
                    case TypeCode.Decimal:
                      num2 = 18;
                      continue;
                    default:
                      goto label_46;
                  }
                case TypeCode.Int32:
                  switch (typeCode1)
                  {
                    case TypeCode.Int32:
                    case TypeCode.Int64:
                    case TypeCode.Single:
                    case TypeCode.Double:
                    case TypeCode.Decimal:
                      goto label_11;
                    case TypeCode.UInt32:
                    case TypeCode.UInt64:
                      goto label_46;
                    default:
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 8 : 3;
                      continue;
                  }
                case TypeCode.UInt32:
                  switch (typeCode1)
                  {
                    case TypeCode.UInt32:
                    case TypeCode.Int64:
                    case TypeCode.UInt64:
                    case TypeCode.Single:
                    case TypeCode.Double:
                    case TypeCode.Decimal:
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_46;
                  }
                case TypeCode.Int64:
                  if (typeCode1 != TypeCode.Int64)
                  {
                    num2 = 32;
                    continue;
                  }
                  goto label_26;
                case TypeCode.UInt64:
                  goto label_27;
                case TypeCode.Single:
                  switch (typeCode1)
                  {
                    case TypeCode.Single:
                    case TypeCode.Double:
                      num2 = 24;
                      continue;
                    default:
                      goto label_46;
                  }
                default:
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 22 : 23;
                  continue;
              }
            case 15:
              if (!type2.IsEnum)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 24 : 29;
                continue;
              }
              num4 = 1;
              goto label_60;
            case 16:
              goto label_26;
            case 17:
              type2 = ExpressionParser.sf4koeGhqdpuOwGl0td(target);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 1 : 1;
              continue;
            case 18:
              goto label_17;
            case 19:
              goto label_55;
            case 20:
              goto label_5;
            case 21:
              num3 = (int) Type.GetTypeCode(type1);
              break;
            case 22:
              goto label_38;
            case 23:
              if (ExpressionParser.JjQQTHhdFqCPEsKhvWZ(type1, type2))
              {
                num2 = 31;
                continue;
              }
              goto label_46;
            case 24:
              goto label_8;
            case 26:
            case 33:
              if (type1.IsEnum)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 3 : 2;
                continue;
              }
              goto case 21;
            case 27:
              if (target.IsValueType)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 13 : 7;
                continue;
              }
              goto label_55;
            case 28:
              if (!ExpressionParser.JjQQTHhdFqCPEsKhvWZ(source, target))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 27 : 25;
                continue;
              }
              goto label_33;
            case 29:
              num4 = (int) ExpressionParser.a8JAGJGXKH2RUp32h9S(type2);
              goto label_60;
            case 30:
              goto label_41;
            case 31:
              goto label_45;
            case 32:
              switch (typeCode1)
              {
                case TypeCode.Single:
                case TypeCode.Double:
                case TypeCode.Decimal:
                  goto label_26;
                default:
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 7 : 9;
                  continue;
              }
            case 34:
              goto label_33;
            default:
              goto label_20;
          }
          typeCode2 = (TypeCode) num3;
          num2 = 15;
          continue;
label_60:
          typeCode1 = (TypeCode) num4;
          num2 = 14;
        }
label_15:
        switch (typeCode1)
        {
          case TypeCode.Int16:
          case TypeCode.Int32:
          case TypeCode.Int64:
          case TypeCode.Single:
          case TypeCode.Double:
          case TypeCode.Decimal:
            goto label_41;
          case TypeCode.UInt16:
          case TypeCode.UInt32:
          case TypeCode.UInt64:
            goto label_46;
          default:
            num1 = 4;
            continue;
        }
label_27:
        switch (typeCode1)
        {
          case TypeCode.UInt64:
          case TypeCode.Single:
          case TypeCode.Double:
          case TypeCode.Decimal:
            goto label_5;
          default:
            num1 = 10;
            continue;
        }
      }
label_5:
      return true;
label_8:
      return true;
label_11:
      return true;
label_14:
      return true;
label_17:
      return true;
label_20:
      return true;
label_23:
      return true;
label_26:
      return true;
label_33:
      return true;
label_38:
      return false;
label_41:
      return true;
label_45:
      return true;
label_46:
      return false;
label_55:
      return target.IsAssignableFrom(source);
    }

    private static bool IsBetterThan(object args, object m1, object m2)
    {
      int num1 = 2;
      bool flag;
      while (true)
      {
        int num2 = num1;
        int index;
        int num3;
        while (true)
        {
          switch (num2)
          {
            case 1:
              index = 0;
              num2 = 6;
              continue;
            case 2:
              flag = false;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 1;
              continue;
            case 3:
            case 8:
              num3 = ExpressionParser.MJOJx5GeBNWaI8belE2(ExpressionParser.xNfa4VhMkUhKyv7OK94(args[index]), ExpressionParser.MZLpxVG2yWWaF4cWCFV(((ExpressionParser.MethodData) m1).Parameters[index]), ((ParameterInfo) ((ExpressionParser.MethodData) m2).Parameters[index]).ParameterType);
              num2 = 12;
              continue;
            case 4:
            case 6:
              if (index < args.Length)
              {
                num2 = 8;
                continue;
              }
              goto label_15;
            case 5:
              goto label_9;
            case 7:
            case 11:
              ++index;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 2 : 4;
              continue;
            case 9:
              goto label_15;
            case 10:
              if (num3 <= 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 10 : 11;
                continue;
              }
              goto label_12;
            case 12:
              if (num3 >= 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 10 : 8;
                continue;
              }
              goto label_9;
            default:
              goto label_12;
          }
        }
label_12:
        flag = true;
        num1 = 7;
      }
label_9:
      return false;
label_15:
      return flag;
    }

    private static int CompareConversions(Type s, Type t1, Type t2)
    {
      int num = 4;
      while (true)
      {
        bool flag1;
        bool flag2;
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            goto label_30;
          case 3:
            goto label_8;
          case 4:
            if (!ExpressionParser.JjQQTHhdFqCPEsKhvWZ(t1, t2))
            {
              if (ExpressionParser.JjQQTHhdFqCPEsKhvWZ(s, t1))
              {
                num = 6;
                continue;
              }
              if (!ExpressionParser.JjQQTHhdFqCPEsKhvWZ(s, t2))
              {
                flag2 = ExpressionParser.yU3fV3Gn2T7jO4wHQUI(t1, t2);
                num = 12;
                continue;
              }
              num = 5;
              continue;
            }
            num = 3;
            continue;
          case 5:
            goto label_18;
          case 6:
            goto label_25;
          case 7:
            if (flag2)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 10 : 11;
              continue;
            }
            break;
          case 8:
            if (ExpressionParser.aHIXgxGP6WrfmN3LWr7(t1))
            {
              num = 14;
              continue;
            }
            goto case 10;
          case 9:
label_32:
            if (!flag2)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 1;
              continue;
            }
            goto case 8;
          case 10:
            if (ExpressionParser.IsSignedIntegralType(t2))
            {
              num = 15;
              continue;
            }
            goto label_31;
          case 11:
            if (!flag1)
            {
              num = 13;
              continue;
            }
            break;
          case 12:
            flag1 = ExpressionParser.yU3fV3Gn2T7jO4wHQUI(t2, t1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 7 : 7;
            continue;
          case 13:
            goto label_15;
          case 14:
            if (!ExpressionParser.mGwJmPG1v7F873XA3JN(t2))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 10 : 2;
              continue;
            }
            goto label_22;
          case 15:
            if (ExpressionParser.IsUnsignedIntegralType(t1))
            {
              num = 2;
              continue;
            }
            goto label_31;
          default:
            goto label_22;
        }
        if (!flag1)
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 6 : 8;
        else
          goto label_32;
      }
label_2:
      return -1;
label_8:
      return 0;
label_15:
      return 1;
label_18:
      return -1;
label_22:
      return 1;
label_25:
      return 1;
label_30:
      return -1;
label_31:
      return 0;
    }

    private Expression GenerateEqual(Expression left, Expression right) => (Expression) Expression.Equal(left, right);

    private Expression GenerateNotEqual(Expression left, Expression right) => (Expression) Expression.NotEqual(left, right);

    private Expression GenerateGreaterThan(Expression left, Expression right)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: type reference
            if (!ExpressionParser.JjQQTHhdFqCPEsKhvWZ(ExpressionParser.xNfa4VhMkUhKyv7OK94((object) left), ExpressionParser.KAF1pPhmquc8fUailtM(__typeref (string))))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            goto label_4;
          default:
            goto label_5;
        }
      }
label_4:
      return (Expression) ExpressionParser.MPoPDeGNFZZpadpS6Pr((object) this.GenerateStaticMethodCall(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824386339), left, right), ExpressionParser.JuDEY9hLMrnNBJuTbEA((object) 0));
label_5:
      return (Expression) ExpressionParser.MPoPDeGNFZZpadpS6Pr((object) left, (object) right);
    }

    private Expression GenerateGreaterThanEqual(Expression left, Expression right)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (ExpressionParser.JjQQTHhdFqCPEsKhvWZ(left.Type, typeof (string)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return (Expression) ExpressionParser.bvQ26pG3Hn7EfWCCuvB((object) this.GenerateStaticMethodCall(z2jc63fLkugS1X8Q9N.tE1kD1vbB(825385222 ^ 825391174), left, right), ExpressionParser.JuDEY9hLMrnNBJuTbEA((object) 0));
label_3:
      return (Expression) ExpressionParser.bvQ26pG3Hn7EfWCCuvB((object) left, (object) right);
    }

    private Expression GenerateLessThan(Expression left, Expression right)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!ExpressionParser.JjQQTHhdFqCPEsKhvWZ(ExpressionParser.xNfa4VhMkUhKyv7OK94((object) left), typeof (string)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            goto label_4;
          default:
            goto label_5;
        }
      }
label_4:
      return (Expression) ExpressionParser.qGrFlqGpXWQ6UGuaToE((object) this.GenerateStaticMethodCall((string) ExpressionParser.TZcomMhwloVeNRf8kPa(1669212571 ^ 1669214427), left, right), ExpressionParser.JuDEY9hLMrnNBJuTbEA((object) 0));
label_5:
      return (Expression) ExpressionParser.qGrFlqGpXWQ6UGuaToE((object) left, (object) right);
    }

    private Expression GenerateLessThanEqual(Expression left, Expression right)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: type reference
            if (ExpressionParser.JjQQTHhdFqCPEsKhvWZ(left.Type, ExpressionParser.KAF1pPhmquc8fUailtM(__typeref (string))))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return (Expression) ExpressionParser.t1ssLbGaMoDUW5Q3XHG((object) this.GenerateStaticMethodCall((string) ExpressionParser.TZcomMhwloVeNRf8kPa(-1217523399 ^ -1217525639), left, right), ExpressionParser.JuDEY9hLMrnNBJuTbEA((object) 0));
label_5:
      return (Expression) ExpressionParser.t1ssLbGaMoDUW5Q3XHG((object) left, (object) right);
    }

    private Expression GenerateAdd(Expression left, Expression right)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!ExpressionParser.JjQQTHhdFqCPEsKhvWZ(left.Type, typeof (string)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
              continue;
            }
            goto case 3;
          case 3:
            // ISSUE: type reference
            if (!ExpressionParser.JjQQTHhdFqCPEsKhvWZ(ExpressionParser.xNfa4VhMkUhKyv7OK94((object) right), ExpressionParser.KAF1pPhmquc8fUailtM(__typeref (string))))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 2 : 0;
              continue;
            }
            goto label_2;
          case 4:
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      return this.GenerateStaticMethodCall((string) ExpressionParser.TZcomMhwloVeNRf8kPa(-1837662597 ^ -1837668567), left, right);
label_3:
      return (Expression) ExpressionParser.Qs1B6FGDGIY4UE5LPBr((object) left, (object) right);
    }

    private Expression GenerateSubtract(Expression left, Expression right) => (Expression) ExpressionParser.kxsNjVGtO7Prm79DpHF((object) left, (object) right);

    private Expression GenerateStringConcat(Expression left, Expression right) => (Expression) Expression.Call((Expression) null, __nonvirtual (ExpressionParser.KAF1pPhmquc8fUailtM(__typeref (string)).GetMethod((string) ExpressionParser.TZcomMhwloVeNRf8kPa(1461625753 ^ 1461631691), new Type[2]
    {
      ExpressionParser.KAF1pPhmquc8fUailtM(__typeref (object)),
      ExpressionParser.KAF1pPhmquc8fUailtM(__typeref (object))
    })), new Expression[2]{ left, right });

    private MethodInfo GetStaticMethod(string methodName, Expression left, Expression right) => ExpressionParser.xNfa4VhMkUhKyv7OK94((object) left).GetMethod(methodName, new Type[2]
    {
      ExpressionParser.xNfa4VhMkUhKyv7OK94((object) left),
      ExpressionParser.xNfa4VhMkUhKyv7OK94((object) right)
    });

    private Expression GenerateStaticMethodCall(
      string methodName,
      Expression left,
      Expression right)
    {
      return (Expression) ExpressionParser.i8nGnDGQRSscQIHrQM8((object) null, (object) this.GetStaticMethod(methodName, left, right), (object) new Expression[2]
      {
        left,
        right
      });
    }

    private void SetTextPos(int pos)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_5;
          case 1:
            this.ch = this.textPos >= this.textLen ? char.MinValue : this.text[this.textPos];
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
            continue;
          case 2:
            this.textPos = pos;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 1 : 1;
            continue;
          default:
            goto label_2;
        }
      }
label_5:
      return;
label_2:;
    }

    private void NextChar()
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            ++this.textPos;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 0;
            continue;
          case 3:
            if (this.textPos < this.textLen)
            {
              num = 2;
              continue;
            }
            break;
        }
        this.ch = this.textPos < this.textLen ? ExpressionParser.VWOixOh5aBfZJq1DmMl((object) this.text, this.textPos) : char.MinValue;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 1 : 0;
      }
label_2:;
    }

    private void NextToken()
    {
      int num1 = 70;
      while (true)
      {
        int num2 = num1;
        ExpressionParser.TokenId tokenId;
        char ch1;
        while (true)
        {
          int textPos;
          char ch2;
          switch (num2)
          {
            case 1:
              tokenId = ExpressionParser.TokenId.Identifier;
              num2 = 58;
              continue;
            case 2:
            case 145:
              this.NextChar();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 97 : 37;
              continue;
            case 3:
              tokenId = ExpressionParser.TokenId.LessThanEqual;
              num2 = 55;
              continue;
            case 4:
              goto label_124;
            case 5:
label_134:
              this.NextChar();
              num2 = 13;
              continue;
            case 6:
label_144:
              this.NextChar();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 80 : 2;
              continue;
            case 7:
              textPos = this.textPos;
              num2 = 76;
              continue;
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
              goto label_125;
            case 9:
label_106:
              this.NextChar();
              num2 = 131;
              continue;
            case 10:
              this.NextChar();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 61 : 52;
              continue;
            case 11:
              this.NextChar();
              num2 = 50;
              continue;
            case 12:
              this.ValidateDigit();
              num2 = 145;
              continue;
            case 13:
              tokenId = ExpressionParser.TokenId.OpenParen;
              num2 = 91;
              continue;
            case 16:
label_43:
              ch2 = this.ch;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 37 : 112;
              continue;
            case 17:
              this.ValidateDigit();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 4 : 10;
              continue;
            case 18:
            case 70:
              if (ExpressionParser.cj25XfGwEyX4Hil5xoo(this.ch))
              {
                num2 = 137;
                continue;
              }
              goto case 7;
            case 19:
            case 79:
            case 150:
label_150:
              if (!char.IsLetter(this.ch))
              {
                num2 = 51;
                continue;
              }
              goto label_107;
            case 20:
              goto label_121;
            case 21:
              if (!char.IsDigit(this.ch))
              {
                num2 = 103;
                continue;
              }
              goto case 109;
            case 22:
              this.NextChar();
              num2 = 17;
              continue;
            case 23:
label_120:
              this.NextChar();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 119 : 28;
              continue;
            case 24:
              this.NextChar();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 95 : 94;
              continue;
            case 25:
              if (this.ch == '>')
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 3 : 78;
                continue;
              }
              goto case 124;
            case 28:
              if (this.ch != '_')
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 1 : 0;
                continue;
              }
              goto label_107;
            case 29:
              tokenId = ExpressionParser.TokenId.Question;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 11 : 27;
              continue;
            case 30:
              tokenId = ExpressionParser.TokenId.IntegerLiteral;
              num2 = 109;
              continue;
            case 32:
              if (ch1 <= '[')
              {
                num2 = 47;
                continue;
              }
              goto case 146;
            case 33:
              tokenId = ExpressionParser.TokenId.Bar;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 31 : 29;
              continue;
            case 34:
              tokenId = ExpressionParser.TokenId.LessGreater;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 142 : 35;
              continue;
            case 35:
            case 148:
              goto label_107;
            case 36:
              if (this.ch == '_')
              {
                num2 = 148;
                continue;
              }
              goto case 59;
            case 37:
              this.NextChar();
              num2 = 77;
              continue;
            case 38:
label_114:
              this.NextChar();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 95 : 108;
              continue;
            case 39:
              tokenId = ExpressionParser.TokenId.Equal;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 16 : 42;
              continue;
            case 40:
              if (this.textPos == this.textLen)
              {
                num2 = 20;
                continue;
              }
              this.NextChar();
              num2 = 93;
              continue;
            case 41:
label_48:
              this.NextChar();
              num2 = 57;
              continue;
            case 43:
              tokenId = ExpressionParser.TokenId.Minus;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 117 : 1;
              continue;
            case 44:
              tokenId = ExpressionParser.TokenId.DoubleEqual;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 103 : 105;
              continue;
            case 47:
              switch (ch1)
              {
                case '!':
                  goto label_38;
                case '"':
                case '\'':
                  goto label_43;
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
                  goto label_150;
                case '%':
                  goto label_106;
                case '&':
                  goto label_21;
                case '(':
                  goto label_134;
                case ')':
                  goto label_144;
                case '*':
                  goto label_7;
                case '+':
                  goto label_120;
                case ',':
                  goto label_148;
                case '-':
                  goto label_130;
                case '.':
                  goto label_42;
                case '/':
                  goto label_20;
                case ':':
                  goto label_114;
                case '<':
                  goto label_133;
                case '=':
                  goto label_48;
                case '>':
                  goto label_111;
                case '?':
                  goto label_146;
                default:
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 75 : 85;
                  continue;
              }
            case 48:
              tokenId = ExpressionParser.TokenId.CloseBracket;
              num2 = 122;
              continue;
            case 50:
              if (this.ch != '+')
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 111 : 21;
                continue;
              }
              goto case 89;
            case 51:
              if (this.ch != '@')
              {
                num2 = 36;
                continue;
              }
              goto label_107;
            case 52:
            case 72:
              if (this.textPos < this.textLen)
              {
                num2 = 144;
                continue;
              }
              goto case 40;
            case 53:
              if (this.ch != 'F')
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 81 : 132;
                continue;
              }
              break;
            case 54:
              if (this.ch == 'e')
              {
                num2 = 147;
                continue;
              }
              goto case 53;
            case 56:
              goto label_83;
            case 57:
              if (this.ch == '=')
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 129 : 61;
                continue;
              }
              goto case 39;
            case 59:
              if (!ExpressionParser.rBNFgjG61KxHNDdiS8A(this.ch))
              {
                num2 = 116;
                continue;
              }
              goto case 30;
            case 60:
              if (this.ch == '&')
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 118 : 112;
                continue;
              }
              goto case 68;
            case 61:
              if (!char.IsDigit(this.ch))
              {
                num2 = 110;
                continue;
              }
              goto case 10;
            case 62:
              this.NextChar();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 72 : 39;
              continue;
            case 63:
label_20:
              this.NextChar();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 41 : 96;
              continue;
            case 64:
label_42:
              this.NextChar();
              num2 = 130;
              continue;
            case 67:
              goto label_147;
            case 68:
              tokenId = ExpressionParser.TokenId.Amphersand;
              num2 = 26;
              continue;
            case 69:
            case 137:
              this.NextChar();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 16 : 18;
              continue;
            case 71:
              if (this.ch == '=')
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 16 : 123;
                continue;
              }
              goto case 25;
            case 73:
              tokenId = ExpressionParser.TokenId.RealLiteral;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 22 : 9;
              continue;
            case 74:
              tokenId = ExpressionParser.TokenId.End;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 49 : 32;
              continue;
            case 75:
              this.NextChar();
              num2 = (int) sbyte.MaxValue;
              continue;
            case 76:
              goto label_27;
            case 77:
              if (this.ch == '|')
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 16 : 75;
                continue;
              }
              goto case 33;
            case 78:
              this.NextChar();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 9 : 34;
              continue;
            case 80:
              tokenId = ExpressionParser.TokenId.CloseParen;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 49 : 138;
              continue;
            case 83:
              this.NextChar();
              num2 = 100;
              continue;
            case 84:
              tokenId = ExpressionParser.TokenId.GreaterThan;
              num2 = 141;
              continue;
            case 85:
              if (ch1 != '[')
              {
                num2 = 150;
                continue;
              }
              goto case 134;
            case 86:
              if (ExpressionParser.HJLjtJG4uAe19bJdlCS(this.ch))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 35 : 23;
                continue;
              }
              goto case 28;
            case 89:
              this.NextChar();
              num2 = 12;
              continue;
            case 90:
label_148:
              this.NextChar();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 27 : 139;
              continue;
            case 93:
              if ((int) this.ch == (int) ch2)
                goto case 112;
              else
                goto label_109;
            case 94:
              tokenId = ExpressionParser.TokenId.OpenBracket;
              num2 = 81;
              continue;
            case 95:
              tokenId = ExpressionParser.TokenId.ExclamationEqual;
              num2 = 46;
              continue;
            case 96:
              tokenId = ExpressionParser.TokenId.Slash;
              num2 = 88;
              continue;
            case 97:
              if (ExpressionParser.rBNFgjG61KxHNDdiS8A(this.ch))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 2 : 1;
                continue;
              }
              goto case 53;
            case 98:
label_38:
              this.NextChar();
              num2 = 114;
              continue;
            case 100:
              tokenId = ExpressionParser.TokenId.GreaterThanEqual;
              num2 = 136;
              continue;
            case 101:
              if (this.ch == '=')
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 69 : 83;
                continue;
              }
              goto case 84;
            case 102:
              this.token.pos = textPos;
              num2 = 67;
              continue;
            case 103:
              if (this.ch == '.')
              {
                num2 = 73;
                continue;
              }
              goto case 110;
            case 104:
            case 116:
              if (this.textPos == this.textLen)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 74 : 73;
                continue;
              }
              goto label_124;
            case 106:
label_130:
              this.NextChar();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 19 : 43;
              continue;
            case 107:
label_7:
              this.NextChar();
              num2 = 149;
              continue;
            case 108:
              tokenId = ExpressionParser.TokenId.Colon;
              num2 = 45;
              continue;
            case 109:
              this.NextChar();
              num2 = 21;
              continue;
            case 110:
              if (this.ch != 'E')
              {
                num2 = 54;
                continue;
              }
              goto case 147;
            case 111:
              if (this.ch == '-')
              {
                num2 = 89;
                continue;
              }
              goto case 12;
            case 112:
              this.NextChar();
              num2 = 52;
              continue;
            case 113:
label_133:
              this.NextChar();
              num2 = 71;
              continue;
            case 114:
              if (this.ch == '=')
              {
                num2 = 24;
                continue;
              }
              goto label_83;
            case 118:
              this.NextChar();
              num2 = 135;
              continue;
            case 119:
              goto label_14;
            case 120:
              tokenId = ExpressionParser.TokenId.StringLiteral;
              num2 = 87;
              continue;
            case 121:
label_21:
              this.NextChar();
              num2 = 60;
              continue;
            case 123:
              this.NextChar();
              num2 = 3;
              continue;
            case 124:
              tokenId = ExpressionParser.TokenId.LessThan;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 4 : 8;
              continue;
            case 125:
              if (ch1 == '|')
                goto case 37;
              else
                goto label_90;
            case 126:
label_146:
              this.NextChar();
              num2 = 29;
              continue;
            case (int) sbyte.MaxValue:
              tokenId = ExpressionParser.TokenId.DoubleBar;
              num2 = 65;
              continue;
            case 129:
              goto label_35;
            case 130:
              tokenId = ExpressionParser.TokenId.Dot;
              num2 = 15;
              continue;
            case 131:
              tokenId = ExpressionParser.TokenId.Percent;
              num2 = 115;
              continue;
            case 132:
              if (this.ch == 'f')
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
                continue;
              }
              goto label_125;
            case 133:
              this.token.text = (string) ExpressionParser.Lla0KjhjTGXZ124Xgfk((object) this.text, textPos, this.textPos - textPos);
              num2 = 102;
              continue;
            case 134:
              this.NextChar();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 13 : 94;
              continue;
            case 135:
              tokenId = ExpressionParser.TokenId.DoubleAmphersand;
              num2 = 99;
              continue;
            case 139:
              tokenId = ExpressionParser.TokenId.Comma;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 82 : 47;
              continue;
            case 140:
label_111:
              this.NextChar();
              num2 = 101;
              continue;
            case 143:
              this.NextChar();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 6 : 48;
              continue;
            case 144:
              if ((int) this.ch == (int) ch2)
              {
                num2 = 40;
                continue;
              }
              goto case 62;
            case 146:
              if (ch1 != ']')
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 60 : 125;
                continue;
              }
              goto case 143;
            case 147:
              tokenId = ExpressionParser.TokenId.RealLiteral;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 11 : 10;
              continue;
            case 149:
              tokenId = ExpressionParser.TokenId.Asterisk;
              num2 = 66;
              continue;
          }
          this.NextChar();
          num2 = 14;
        }
label_14:
        tokenId = ExpressionParser.TokenId.Plus;
        num1 = 128;
        continue;
label_27:
        ch1 = this.ch;
        num1 = 32;
        continue;
label_35:
        this.NextChar();
        num1 = 44;
        continue;
label_83:
        tokenId = ExpressionParser.TokenId.Exclamation;
        num1 = 92;
        continue;
label_90:
        num1 = 19;
        continue;
label_107:
        this.NextChar();
        num1 = 86;
        continue;
label_109:
        num1 = 120;
        continue;
label_125:
        this.token.id = tokenId;
        num1 = 133;
      }
label_147:
      return;
label_121:
      throw this.ParseError(this.textPos, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138154214));
label_124:
      throw this.ParseError(this.textPos, (string) ExpressionParser.TZcomMhwloVeNRf8kPa(1819636893 << 3 ^ 1672199540), (object) this.ch);
    }

    private bool TokenIdentifierIs(string id)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.token.id == ExpressionParser.TokenId.Identifier)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return ExpressionParser.HX3OPEGHPXKHAGGpvNg((object) id, (object) this.token.text, StringComparison.OrdinalIgnoreCase);
label_3:
      return false;
    }

    private string GetIdentifier()
    {
      int num1 = 3;
      string identifier;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_7;
            case 2:
              identifier = this.token.text;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 0 : 0;
              continue;
            case 3:
              this.ValidateToken(ExpressionParser.TokenId.Identifier, (string) ExpressionParser.TZcomMhwloVeNRf8kPa(-138018305 ^ -138012613));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 1 : 2;
              continue;
            case 4:
              goto label_6;
            case 5:
              if (ExpressionParser.VWOixOh5aBfZJq1DmMl((object) identifier, 0) == '@')
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 1 : 1;
                continue;
              }
              goto label_6;
            default:
              if (identifier.Length > 1)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 4 : 5;
                continue;
              }
              goto label_6;
          }
        }
label_7:
        identifier = identifier.Substring(1);
        num1 = 4;
      }
label_6:
      return identifier;
    }

    private void ValidateDigit()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!ExpressionParser.rBNFgjG61KxHNDdiS8A(this.ch))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:
      throw this.ParseError(this.textPos, (string) ExpressionParser.TZcomMhwloVeNRf8kPa(-542721635 ^ -542728077));
    }

    private void ValidateToken(ExpressionParser.TokenId t, string errorMessage)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.token.id != t)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          default:
            goto label_3;
        }
      }
label_3:
      throw this.ParseError(errorMessage);
label_2:;
    }

    private void ValidateToken(ExpressionParser.TokenId t)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.token.id != t)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:
      throw this.ParseError(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1350312861 << 3 ^ 2082402002));
    }

    private Exception ParseError(string format, params object[] args) => this.ParseError(this.token.pos, format, args);

    private Exception ParseError(int pos, string format, params object[] args) => (Exception) new ParseException((string) ExpressionParser.yetcrwGASsx1WQdUZW1((object) CultureInfo.CurrentCulture, (object) format, (object) args), pos);

    private static Dictionary<string, object> CreateKeywords()
    {
      Dictionary<string, object> keywords = new Dictionary<string, object>((IEqualityComparer<string>) StringComparer.OrdinalIgnoreCase);
      keywords.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461625753 ^ 1461631383), (object) ExpressionParser.trueLiteral);
      keywords.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1304605005 ^ 1304603479), (object) ExpressionParser.falseLiteral);
      keywords.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-441065788 ^ -2092910478 ^ 1727362640), (object) ExpressionParser.nullLiteral);
      keywords.Add(ExpressionParser.keywordIt, (object) ExpressionParser.keywordIt);
      keywords.Add(ExpressionParser.keywordIif, (object) ExpressionParser.keywordIif);
      keywords.Add(ExpressionParser.keywordNew, (object) ExpressionParser.keywordNew);
      foreach (Type predefinedType in ExpressionParser.predefinedTypes)
        keywords.Add(predefinedType.Name, (object) predefinedType);
      return keywords;
    }

    static ExpressionParser()
    {
      int num = 6;
      while (true)
      {
        switch (num)
        {
          case 1:
            ExpressionParser.falseLiteral = (Expression) Expression.Constant((object) false);
            num = 2;
            continue;
          case 2:
            ExpressionParser.nullLiteral = (Expression) ExpressionParser.JuDEY9hLMrnNBJuTbEA((object) null);
            num = 3;
            continue;
          case 3:
            ExpressionParser.keywordIt = (string) ExpressionParser.TZcomMhwloVeNRf8kPa(-1350312861 << 3 ^ 2082404656);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 8 : 4;
            continue;
          case 4:
            goto label_2;
          case 5:
            // ISSUE: type reference
            // ISSUE: type reference
            // ISSUE: type reference
            // ISSUE: type reference
            // ISSUE: type reference
            // ISSUE: type reference
            // ISSUE: type reference
            // ISSUE: type reference
            // ISSUE: type reference
            // ISSUE: type reference
            // ISSUE: type reference
            // ISSUE: type reference
            ExpressionParser.predefinedTypes = new Type[20]
            {
              typeof (object),
              ExpressionParser.KAF1pPhmquc8fUailtM(__typeref (bool)),
              typeof (char),
              ExpressionParser.KAF1pPhmquc8fUailtM(__typeref (string)),
              ExpressionParser.KAF1pPhmquc8fUailtM(__typeref (sbyte)),
              ExpressionParser.KAF1pPhmquc8fUailtM(__typeref (byte)),
              ExpressionParser.KAF1pPhmquc8fUailtM(__typeref (short)),
              typeof (ushort),
              typeof (int),
              ExpressionParser.KAF1pPhmquc8fUailtM(__typeref (uint)),
              ExpressionParser.KAF1pPhmquc8fUailtM(__typeref (long)),
              typeof (ulong),
              typeof (float),
              ExpressionParser.KAF1pPhmquc8fUailtM(__typeref (double)),
              ExpressionParser.KAF1pPhmquc8fUailtM(__typeref (Decimal)),
              ExpressionParser.KAF1pPhmquc8fUailtM(__typeref (DateTime)),
              typeof (TimeSpan),
              ExpressionParser.KAF1pPhmquc8fUailtM(__typeref (Guid)),
              ExpressionParser.KAF1pPhmquc8fUailtM(__typeref (Math)),
              typeof (Convert)
            };
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 0;
            continue;
          case 6:
            ExpressionParser.geHS7ihtPfbwy00cPCo();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 5 : 5;
            continue;
          case 7:
            ExpressionParser.keywordNew = (string) ExpressionParser.TZcomMhwloVeNRf8kPa(589593376 ^ -1977315327 ^ -1459556069);
            num = 4;
            continue;
          case 8:
            ExpressionParser.keywordIif = (string) ExpressionParser.TZcomMhwloVeNRf8kPa(-105199646 ^ -105194030);
            num = 7;
            continue;
          default:
            ExpressionParser.trueLiteral = (Expression) ExpressionParser.JuDEY9hLMrnNBJuTbEA((object) true);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 1 : 1;
            continue;
        }
      }
label_2:;
    }

    internal static void geHS7ihtPfbwy00cPCo() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object TZcomMhwloVeNRf8kPa(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object JRKKHbh4GhyZ7Jb1wLU() => (object) StringComparer.OrdinalIgnoreCase;

    internal static int OTruAxh6tuxUllMwkqV([In] object obj0) => ((string) obj0).Length;

    internal static bool FS9Y1UhaODBO2Gslphq() => ExpressionParser.KQg2k3hpaS4cQRE91bw == null;

    internal static ExpressionParser i38SJRhDDREx8KG0jLV() => ExpressionParser.KQg2k3hpaS4cQRE91bw;

    internal static bool rM2lRjhH4jTAvWIdTPJ([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object DtptSGhAmSAJxDpBmjv([In] object obj0) => (object) ((ParameterExpression) obj0).Name;

    internal static object UhP449h7vEDexhBCxa9([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static bool i3sRlhhxItMoQagKgRK([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static object stYXaUh085EWUoWhgat(Type type) => (object) ExpressionParser.GetTypeName(type);

    internal static Type KAF1pPhmquc8fUailtM([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object W8PUxJhyaMPUXgpFdZy([In] object obj0, [In] object obj1) => (object) Expression.OrElse((Expression) obj0, (Expression) obj1);

    internal static Type xNfa4VhMkUhKyv7OK94([In] object obj0) => ((Expression) obj0).Type;

    internal static object j7VDV7hJ6wTVTBOdLNA([In] object obj0, [In] Type obj1) => (object) Expression.Convert((Expression) obj0, obj1);

    internal static bool Io2IBDh9UNF0yjdyVXo(Type type) => ExpressionParser.IsEnumType(type);

    internal static bool JjQQTHhdFqCPEsKhvWZ([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static object fDve4KhloISBw6DaUcB([In] object obj0, [In] object obj1) => (object) Expression.Multiply((Expression) obj0, (Expression) obj1);

    internal static object QcrGjWhrIvMQo7F1ES1([In] object obj0, [In] object obj1) => (object) Expression.Divide((Expression) obj0, (Expression) obj1);

    internal static object H8LAbdhgHEI1PxnBwK5([In] object obj0) => (object) Expression.Negate((Expression) obj0);

    internal static char VWOixOh5aBfZJq1DmMl([In] object obj0, [In] int obj1) => ((string) obj0)[obj1];

    internal static object Lla0KjhjTGXZ124Xgfk([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Substring(obj1, obj2);

    internal static int O2enEChYdQuK4p1Zln4([In] object obj0, [In] char obj1, [In] int obj2) => ((string) obj0).IndexOf(obj1, obj2);

    internal static object JuDEY9hLMrnNBJuTbEA([In] object obj0) => (object) Expression.Constant(obj0);

    internal static object UXWy9khU64Y7m676YRf([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static object NUhEDbhsC9F1Rge5Psd([In] object obj0, [In] object obj1, [In] object obj2) => (object) Expression.Condition((Expression) obj0, (Expression) obj1, (Expression) obj2);

    internal static object XD37AshcvCgMSDA2yNL([In] object obj0) => (object) ((DynamicProperty) obj0).Name;

    internal static object GANVmVhzXKv1j6TbigI([In] object obj0, [In] object obj1) => (object) Expression.Bind((MemberInfo) obj0, (Expression) obj1);

    internal static object juH5Z3GF5GjImv1e2W0([In] Type obj0) => (object) Expression.New(obj0);

    internal static object PZMCscGBhAvQMOvfWJL([In] object obj0, [In] object obj1) => (object) Expression.MemberInit((NewExpression) obj0, (MemberBinding[]) obj1);

    internal static object AZJNBCGWK3MyRIawtWo([In] object obj0, [In] object obj1) => (object) Expression.Invoke((Expression) obj0, (Expression[]) obj1);

    internal static bool TNnRioGoMVKlM0VpPWH(Type type) => ExpressionParser.IsNullableType(type);

    internal static object Fi0OPoGbin4DuNpQQSb([In] object obj0, [In] object obj1) => (object) Expression.New((ConstructorInfo) obj0, (Expression[]) obj1);

    internal static Type sf4koeGhqdpuOwGl0td(Type type) => ExpressionParser.GetNonNullableType(type);

    internal static bool wWMmdxGG3QByaxCRm6Y(Type type) => ExpressionParser.IsNumericType(type);

    internal static object dZZnnPGEHLVNIqwWNiT([In] object obj0, [In] Type obj1) => (object) Expression.ConvertChecked((Expression) obj0, obj1);

    internal static Type nufyg4GfPZpS2Cxr7U8([In] object obj0) => ((MemberInfo) obj0).DeclaringType;

    internal static object i8nGnDGQRSscQIHrQM8([In] object obj0, [In] object obj1, [In] object obj2) => (object) Expression.Call((Expression) obj0, (MethodInfo) obj1, (Expression[]) obj2);

    internal static bool wpLy1BGCndfypRCWO1L([In] object obj0, [In] object obj1) => (MemberInfo) obj0 == (MemberInfo) obj1;

    internal static object U33gD2GvC8qSF0CFLpv([In] object obj0, [In] object obj1) => (object) Expression.Field((Expression) obj0, (FieldInfo) obj1);

    internal static Type xicM9VG8aF6bXXvuQR2(Type generic, Type type) => ExpressionParser.FindGenericType(generic, type);

    internal static object US6aAkGZM6smVMK28FU([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static bool AJYpf9Guxe4ohobF9cA([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static object VHg54LGIC2SWgIt8OZ7([In] Type obj0, [In] object obj1, [In] object obj2, [In] object obj3) => (object) Expression.Call(obj0, (string) obj1, (Type[]) obj2, (Expression[]) obj3);

    internal static object nQljjAGVO5bmkogFQLi([In] object obj0) => (object) ((List<Expression>) obj0).ToArray();

    internal static int WhJhC3GSiv92ur0R5Yo(Type type) => ExpressionParser.GetNumericTypeKind(type);

    internal static bool ldp1IJGi5QyVT4i2JIZ([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void fMBpO3GRbi1fwKK0v55([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool epG7hyGqA2M2eHroPVQ([In] object obj0) => ((ParameterInfo) obj0).IsOut;

    internal static object ihkCtuGKbgQLsdAR7pg([In] object obj0, [In] Type obj1) => (object) Expression.Constant(obj0, obj1);

    internal static TypeCode a8JAGJGXKH2RUp32h9S([In] Type obj0) => Type.GetTypeCode(obj0);

    internal static object SwLclmGTgRtJvlS5fPt([In] object obj0, Type type) => ExpressionParser.ParseNumber(obj0, type);

    internal static object F0vtwDGk3JQbAhpNZBu([In] object obj0, Type type) => ExpressionParser.ParseEnum(obj0, type);

    internal static bool yU3fV3Gn2T7jO4wHQUI(Type source, Type target) => ExpressionParser.IsCompatibleWith(source, target);

    internal static object QfgMoVGOu7abmasC3Ar([In] object obj0, [In] object obj1) => ((FieldInfo) obj0).GetValue(obj1);

    internal static Type MZLpxVG2yWWaF4cWCFV([In] object obj0) => ((ParameterInfo) obj0).ParameterType;

    internal static int MJOJx5GeBNWaI8belE2(Type s, Type t1, Type t2) => ExpressionParser.CompareConversions(s, t1, t2);

    internal static bool aHIXgxGP6WrfmN3LWr7(Type type) => ExpressionParser.IsSignedIntegralType(type);

    internal static bool mGwJmPG1v7F873XA3JN(Type type) => ExpressionParser.IsUnsignedIntegralType(type);

    internal static object MPoPDeGNFZZpadpS6Pr([In] object obj0, [In] object obj1) => (object) Expression.GreaterThan((Expression) obj0, (Expression) obj1);

    internal static object bvQ26pG3Hn7EfWCCuvB([In] object obj0, [In] object obj1) => (object) Expression.GreaterThanOrEqual((Expression) obj0, (Expression) obj1);

    internal static object qGrFlqGpXWQ6UGuaToE([In] object obj0, [In] object obj1) => (object) Expression.LessThan((Expression) obj0, (Expression) obj1);

    internal static object t1ssLbGaMoDUW5Q3XHG([In] object obj0, [In] object obj1) => (object) Expression.LessThanOrEqual((Expression) obj0, (Expression) obj1);

    internal static object Qs1B6FGDGIY4UE5LPBr([In] object obj0, [In] object obj1) => (object) Expression.Add((Expression) obj0, (Expression) obj1);

    internal static object kxsNjVGtO7Prm79DpHF([In] object obj0, [In] object obj1) => (object) Expression.Subtract((Expression) obj0, (Expression) obj1);

    internal static bool cj25XfGwEyX4Hil5xoo([In] char obj0) => char.IsWhiteSpace(obj0);

    internal static bool HJLjtJG4uAe19bJdlCS([In] char obj0) => char.IsLetterOrDigit(obj0);

    internal static bool rBNFgjG61KxHNDdiS8A([In] char obj0) => char.IsDigit(obj0);

    internal static bool HX3OPEGHPXKHAGGpvNg([In] object obj0, [In] object obj1, [In] StringComparison obj2) => string.Equals((string) obj0, (string) obj1, obj2);

    internal static object yetcrwGASsx1WQdUZW1([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((IFormatProvider) obj0, (string) obj1, (object[]) obj2);

    private struct Token
    {
      public ExpressionParser.TokenId id;
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
      DoubleBar,
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

      void F(Decimal x, Decimal y);

      void F(int? x, int? y);

      void F(uint? x, uint? y);

      void F(long? x, long? y);

      void F(ulong? x, ulong? y);

      void F(float? x, float? y);

      void F(double? x, double? y);

      void F(Decimal? x, Decimal? y);
    }

    private interface IRelationalSignatures : ExpressionParser.IArithmeticSignatures
    {
      void F(string x, string y);

      void F(char x, char y);

      void F(DateTime x, DateTime y);

      void F(TimeSpan x, TimeSpan y);

      void F(char? x, char? y);

      void F(DateTime? x, DateTime? y);

      void F(TimeSpan? x, TimeSpan? y);
    }

    private interface IEqualitySignatures : 
      ExpressionParser.IRelationalSignatures,
      ExpressionParser.IArithmeticSignatures
    {
      void F(bool x, bool y);

      void F(bool? x, bool? y);
    }

    private interface IAddSignatures : ExpressionParser.IArithmeticSignatures
    {
      void F(DateTime x, TimeSpan y);

      void F(TimeSpan x, TimeSpan y);

      void F(DateTime? x, TimeSpan? y);

      void F(TimeSpan? x, TimeSpan? y);
    }

    private interface ISubtractSignatures : 
      ExpressionParser.IAddSignatures,
      ExpressionParser.IArithmeticSignatures
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

      void F(Decimal x);

      void F(int? x);

      void F(long? x);

      void F(float? x);

      void F(double? x);

      void F(Decimal? x);
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

      void Sum(Decimal selector);

      void Sum(Decimal? selector);

      void Average(int selector);

      void Average(int? selector);

      void Average(long selector);

      void Average(long? selector);

      void Average(float selector);

      void Average(float? selector);

      void Average(double selector);

      void Average(double? selector);

      void Average(Decimal selector);

      void Average(Decimal? selector);
    }

    private class MethodData
    {
      public object MethodBase;
      public object Parameters;
      public object Args;
      internal static object vH354Ef60VK6Cun3CJv4;

      public MethodData()
      {
        ExpressionParser.MethodData.kO9rJAf6M5IY4vMPdln3();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static void kO9rJAf6M5IY4vMPdln3() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool XKr7mQf6mhcFJaX8iCeg() => ExpressionParser.MethodData.vH354Ef60VK6Cun3CJv4 == null;

      internal static ExpressionParser.MethodData mfGtN0f6yrNUigHi5BGh() => (ExpressionParser.MethodData) ExpressionParser.MethodData.vH354Ef60VK6Cun3CJv4;
    }
  }
}
