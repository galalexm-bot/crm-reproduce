// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.CatalogLinkedObject
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>
  /// Краткая информация об каталоге, который могжет проверяться на связанность
  /// </summary>
  public class CatalogLinkedObject : MetadataLinkedObject
  {
    internal static CatalogLinkedObject ExJUFdb15rWZaoZEQSHg;

    /// <summary>Идентификатор расширения каталога</summary>
    public Guid ExtensionUid
    {
      get => this.\u003CExtensionUid\u003Ek__BackingField;
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
              this.\u003CExtensionUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
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

    public CatalogLinkedObject()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool B8EIdPb1jsEWP5tJI6pi() => CatalogLinkedObject.ExJUFdb15rWZaoZEQSHg == null;

    internal static CatalogLinkedObject nscbFXb1Y4cQb1frdNDL() => CatalogLinkedObject.ExJUFdb15rWZaoZEQSHg;
  }
}
