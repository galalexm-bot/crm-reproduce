// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.MetadataContainer
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Контейнер метаданных</summary>
  [Component]
  public class MetadataContainer : IXsiRoot
  {
    private static MetadataContainer vivXwkbxXEKamfPt9q1r;

    /// <summary>Список метаданных</summary>
    public AbstractMetadata[] Metadata
    {
      get => this.\u003CMetadata\u003Ek__BackingField;
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
              this.\u003CMetadata\u003Ek__BackingField = value;
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

    public MetadataContainer()
    {
      MetadataContainer.kiVN0SbxntKw8MGAUrop();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool jDvipGbxTkRfwvMccBR8() => MetadataContainer.vivXwkbxXEKamfPt9q1r == null;

    internal static MetadataContainer QUtoNwbxkTILqMioVE0K() => MetadataContainer.vivXwkbxXEKamfPt9q1r;

    internal static void kiVN0SbxntKw8MGAUrop() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
