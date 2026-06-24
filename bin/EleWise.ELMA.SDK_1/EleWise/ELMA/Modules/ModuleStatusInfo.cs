// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Modules.ModuleStatusInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Modules
{
  /// <summary>Информация о статусе модуля</summary>
  [Serializable]
  public class ModuleStatusInfo
  {
    private static ModuleStatusInfo k8IgSl1bJf1W0JsRVxW;

    /// <summary>Уникальный идентификатор модуля</summary>
    public Guid Uid
    {
      get => this.\u003CUid\u003Ek__BackingField;
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
              this.\u003CUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
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

    /// <summary>Статус модуля</summary>
    public ModuleStatus Status
    {
      get => this.\u003CStatus\u003Ek__BackingField;
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
              this.\u003CStatus\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
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

    public ModuleStatusInfo()
    {
      ModuleStatusInfo.d47OAM1Et4eF4vywyEw();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool Ag0W4k1hAh8trNrs1AL() => ModuleStatusInfo.k8IgSl1bJf1W0JsRVxW == null;

    internal static ModuleStatusInfo jkDxsU1GqgeQqNKuQEI() => ModuleStatusInfo.k8IgSl1bJf1W0JsRVxW;

    internal static void d47OAM1Et4eF4vywyEw() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
