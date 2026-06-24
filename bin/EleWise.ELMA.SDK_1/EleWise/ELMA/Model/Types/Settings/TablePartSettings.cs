// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Settings.TablePartSettings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Types.Settings
{
  /// <summary>Настройки блока</summary>
  [Serializable]
  public class TablePartSettings : TypeSettings
  {
    private ITablePartMetadata metadata;
    private static TablePartSettings wRx2BXozcPfMCNUXwuf0;

    /// <summary>Ctor</summary>
    public TablePartSettings()
    {
      TablePartSettings.K1orfXbFBgYaXsQiMZo8();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="metadata">Метаданные блока</param>
    public TablePartSettings(ITablePartMetadata metadata)
    {
      TablePartSettings.K1orfXbFBgYaXsQiMZo8();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.metadata = metadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Метаданные</summary>
    [JsonSerializationIgnore]
    public ITablePartMetadata Metadata => this.metadata;

    internal static void K1orfXbFBgYaXsQiMZo8() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool om5w1oozzX5mJ96Aj954() => TablePartSettings.wRx2BXozcPfMCNUXwuf0 == null;

    internal static TablePartSettings M4xV9ZbFFUeudYViRuuM() => TablePartSettings.wRx2BXozcPfMCNUXwuf0;
  }
}
