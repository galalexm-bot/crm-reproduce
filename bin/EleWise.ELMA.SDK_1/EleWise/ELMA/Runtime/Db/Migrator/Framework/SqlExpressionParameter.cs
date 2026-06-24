// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Db.Migrator.Framework.SqlExpressionParameter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Runtime.Db.Migrator.Framework
{
  /// <summary>
  /// Может использоваться в функциях Insert и Update в качестве параметра
  /// </summary>
  public class SqlExpressionParameter
  {
    private static SqlExpressionParameter TrSAmtWOyBXkX41NnHp0;

    /// <summary>Ctor</summary>
    /// <param name="expression">Выражение SQL</param>
    public SqlExpressionParameter(string expression)
    {
      SqlExpressionParameter.hReksUWO9EBuOUv9wrcL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Expression = expression;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Выражение SQL</summary>
    public string Expression
    {
      get => this.\u003CExpression\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CExpression\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    internal static void hReksUWO9EBuOUv9wrcL() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool RWIlaNWOMyulV3wkmPPg() => SqlExpressionParameter.TrSAmtWOyBXkX41NnHp0 == null;

    internal static SqlExpressionParameter t2oHqeWOJnv3CJRVVuhy() => SqlExpressionParameter.TrSAmtWOyBXkX41NnHp0;
  }
}
