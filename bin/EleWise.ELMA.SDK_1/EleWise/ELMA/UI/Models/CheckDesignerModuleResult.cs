// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Models.CheckDesignerModuleResult
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Runtime.Serialization;

namespace EleWise.ELMA.UI.Models
{
  /// <summary>Результат валидации версии модуля</summary>
  [DataContract]
  public sealed class CheckDesignerModuleResult
  {
    private static CheckDesignerModuleResult WriOGYBB3W8m2T9YW3Hy;

    /// <summary>Наименование модуля</summary>
    [DataMember]
    public string ModuleName
    {
      get => this.\u003CModuleName\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CModuleName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
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

    /// <summary>Версия</summary>
    [DataMember]
    public string Version
    {
      get => this.\u003CVersion\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CVersion\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 0;
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

    /// <summary>Текст ошибки</summary>
    [DataMember]
    public string CheckResult
    {
      get => this.\u003CCheckResult\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CCheckResult\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
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

    public CheckDesignerModuleResult()
    {
      CheckDesignerModuleResult.vBEfRwBBDr4mPHUFgF3e();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool Vt987XBBpKBvLo95k5ee() => CheckDesignerModuleResult.WriOGYBB3W8m2T9YW3Hy == null;

    internal static CheckDesignerModuleResult uv1X6QBBaK2hVmFlqDsK() => CheckDesignerModuleResult.WriOGYBB3W8m2T9YW3Hy;

    internal static void vBEfRwBBDr4mPHUFgF3e() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
