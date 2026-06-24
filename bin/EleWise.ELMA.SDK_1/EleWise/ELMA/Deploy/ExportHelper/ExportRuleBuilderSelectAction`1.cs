// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.ExportHelper.ExportRuleBuilderSelectAction`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy.ExportHelper
{
  public class ExportRuleBuilderSelectAction<T> : ExportRuleBuilderBase<T>
  {
    internal static object KcCbP0EDDCRprUtL8Dsw;

    public ExportRuleBuilderSelectAction(
      ExportRuleBuilderSelectType<T> baseExportRuleBuilder)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(baseExportRuleBuilder.rules, baseExportRuleBuilder.exportRuleBuilder);
    }

    /// <summary>Не добавляется в список сущностей. Не пишется в xml.</summary>
    public void Ignore()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.rules.ExportRuleType = ExportRuleType.Ignore;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Добавляется в список сущностей. Пишется в xml.</summary>
    public void ExportDeep()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.rules.ExportRuleType = ExportRuleType.ExportDeep;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Не добавляется в список сущностей. Пишется в xml.</summary>
    public void Export()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.rules.ExportRuleType = ExportRuleType.Export;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    internal static bool jN4k08EDtXXQTi6J0Da5() => ExportRuleBuilderSelectAction<T>.KcCbP0EDDCRprUtL8Dsw == null;

    internal static object vH3QSHEDwuEjrS1TnQoI() => ExportRuleBuilderSelectAction<T>.KcCbP0EDDCRprUtL8Dsw;
  }
}
