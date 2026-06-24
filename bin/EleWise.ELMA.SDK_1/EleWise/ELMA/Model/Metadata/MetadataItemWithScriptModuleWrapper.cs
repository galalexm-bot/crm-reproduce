// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.MetadataItemWithScriptModuleWrapper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Обертка над сущностью, имеющей метаданные</summary>
  internal sealed class MetadataItemWithScriptModuleWrapper : ItemWithScriptModuleWrapper
  {
    private static MetadataItemWithScriptModuleWrapper EAfY0ab1dJW1SXZo5TTA;

    /// <summary>Метаданные</summary>
    public IMetadata Metadata
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 0;
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

    public MetadataItemWithScriptModuleWrapper()
    {
      MetadataItemWithScriptModuleWrapper.qTgq2Xb1gBMcNRaMYKa9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool UQed4bb1lyHyvGyVwu3d() => MetadataItemWithScriptModuleWrapper.EAfY0ab1dJW1SXZo5TTA == null;

    internal static MetadataItemWithScriptModuleWrapper jT7phGb1rggFkRhEMp28() => MetadataItemWithScriptModuleWrapper.EAfY0ab1dJW1SXZo5TTA;

    internal static void qTgq2Xb1gBMcNRaMYKa9() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
