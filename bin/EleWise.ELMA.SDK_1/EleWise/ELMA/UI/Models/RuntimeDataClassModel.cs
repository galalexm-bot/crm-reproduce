// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Models.RuntimeDataClassModel
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.UI.Models
{
  /// <summary>Модель данных датакласса</summary>
  public sealed class RuntimeDataClassModel
  {
    private static RuntimeDataClassModel I0kitBBWdajQFTYelOvO;

    /// <summary>Метаданные датакласса</summary>
    public DataClassMetadataItem MetadataItem
    {
      get => this.\u003CMetadataItem\u003Ek__BackingField;
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
              this.\u003CMetadataItem\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
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

    public RuntimeDataClassModel()
    {
      RuntimeDataClassModel.m27OpdBWgXWP58f3AFpN();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool gtC8DXBWlXd9A5MMDP9k() => RuntimeDataClassModel.I0kitBBWdajQFTYelOvO == null;

    internal static RuntimeDataClassModel wKtTV1BWriIGqDRbiXD2() => RuntimeDataClassModel.I0kitBBWdajQFTYelOvO;

    internal static void m27OpdBWgXWP58f3AFpN() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
