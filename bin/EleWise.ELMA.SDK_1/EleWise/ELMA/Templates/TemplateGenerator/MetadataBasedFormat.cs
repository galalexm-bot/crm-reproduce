// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Templates.TemplateGenerator.MetadataBasedFormat
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using EleWise.TemplateGenerator;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Templates.TemplateGenerator
{
  /// <summary>Формат с метаданными</summary>
  public class MetadataBasedFormat : BaseFormat
  {
    private static MetadataBasedFormat jY4ON1BaiiOHPGWhTEKH;

    /// <summary>Метаданные свойства</summary>
    public PropertyMetadata PropertyMetadata
    {
      get => this.\u003CPropertyMetadata\u003Ek__BackingField;
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
              this.\u003CPropertyMetadata\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
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

    public MetadataBasedFormat()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool qHyP1lBaRVAw6Bt2ugLB() => MetadataBasedFormat.jY4ON1BaiiOHPGWhTEKH == null;

    internal static MetadataBasedFormat Qhi5cyBaqlwj8r1mbf3v() => MetadataBasedFormat.jY4ON1BaiiOHPGWhTEKH;
  }
}
