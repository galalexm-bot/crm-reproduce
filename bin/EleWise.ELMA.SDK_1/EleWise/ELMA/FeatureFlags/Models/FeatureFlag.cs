// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FeatureFlags.Models.FeatureFlag
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.FeatureFlags.Models
{
  /// <summary>Простой флаг функций</summary>
  internal struct FeatureFlag : IFeatureFlag
  {
    private readonly bool enabled;
    internal static object qf1pDMGWNHgfEU6mAFnB;

    /// <summary>Ctor</summary>
    /// <param name="name">Имя</param>
    /// <param name="enabled">Состояние</param>
    internal FeatureFlag(string name, bool enabled)
    {
      FeatureFlag.rUFEJpGWaLbDT1tVQskE();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.enabled = enabled;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
            continue;
          case 2:
            this.Name = name;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    /// <inheritdoc />
    public string Name
    {
      get => this.\u003CName\u003Ek__BackingField;
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
              this.\u003CName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 0 : 0;
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

    /// <inheritdoc />
    public bool Enabled() => this.enabled;

    internal static void rUFEJpGWaLbDT1tVQskE() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool kbbTuBGW3yy4VSSWPSB3() => FeatureFlag.qf1pDMGWNHgfEU6mAFnB == null;

    internal static object Dbh0wAGWppe7vFKgviNl() => FeatureFlag.qf1pDMGWNHgfEU6mAFnB;
  }
}
