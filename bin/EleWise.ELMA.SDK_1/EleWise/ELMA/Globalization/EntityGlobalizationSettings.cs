// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Globalization.EntityGlobalizationSettings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Globalization
{
  /// <summary>Выгрузка ресурсов из справочников</summary>
  [Serializable]
  public class EntityGlobalizationSettings
  {
    private static EntityGlobalizationSettings VNnUn0Gor6PNda5ZhUMh;

    /// <summary>Ctor</summary>
    public EntityGlobalizationSettings()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.EntityUids = new Guid[0];
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            this.EnumUids = new Guid[0];
            num = 2;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Выбранные каталоги</summary>
    public Guid[] EntityUids
    {
      get => this.\u003CEntityUids\u003Ek__BackingField;
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
              this.\u003CEntityUids\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 0;
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

    /// <summary>Выбранные перечисления</summary>
    public Guid[] EnumUids
    {
      get => this.\u003CEnumUids\u003Ek__BackingField;
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
              this.\u003CEnumUids\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 0;
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

    internal static bool reQYOoGogludXYAqrDOZ() => EntityGlobalizationSettings.VNnUn0Gor6PNda5ZhUMh == null;

    internal static EntityGlobalizationSettings c4xYyIGo5QuZL4j3X8ox() => EntityGlobalizationSettings.VNnUn0Gor6PNda5ZhUMh;
  }
}
