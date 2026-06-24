// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.ExportHelper.ExportRuleBuilder`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy.ExportHelper
{
  public class ExportRuleBuilder<T>
  {
    public readonly ExportRuleList ExportRules;
    private static object BivwyOEDONEYkbS4Fqyt;

    public ExportRuleBuilder(ExportRuleList exportRuleList)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.ExportRules = exportRuleList;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Создать новое правило</summary>
    /// <returns></returns>
    public ExportRuleBuilderSelectType<T> Rule()
    {
      ExportRule exportRule = new ExportRule();
      this.ExportRules.Add(exportRule);
      return new ExportRuleBuilderSelectType<T>(exportRule, this);
    }

    internal static bool bbt1frED2vR61ThkuBZ2() => ExportRuleBuilder<T>.BivwyOEDONEYkbS4Fqyt == null;

    internal static object d080gDEDeZSg9cQs0xhJ() => ExportRuleBuilder<T>.BivwyOEDONEYkbS4Fqyt;
  }
}
