// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Common.PublishData
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Common
{
  /// <summary>Информация о списках публикуемых метаданных</summary>
  public class PublishData
  {
    internal static PublishData WypBKEhqiNJ06nPZj8eO;

    /// <summary>Список метаданных, требующих перезагрузку</summary>
    public Dictionary<Guid, IRootMetadata> RestartNeededMetadata { get; }

    /// <summary>Список дельта-опубликованных метаданных</summary>
    public Dictionary<Guid, IRootMetadata> DeltaPublishedMetadata { get; }

    /// <summary>Список метаданных, не требующих перезагрузку</summary>
    public Dictionary<Guid, IRootMetadata> SoftPublishedMetadata { get; }

    /// <summary>Элементы метаданных</summary>
    internal List<IMetadataItem> MetadataItems { get; }

    /// <summary>
    /// Имеется ли хотя бы одна запись в любом из списков метаданных
    /// </summary>
    internal bool Any()
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_5;
            case 2:
            case 3:
              goto label_6;
            case 4:
              if (PublishData.eU9pOBhqKECwDJQTcv0I((object) this.SoftPublishedMetadata) > 0)
              {
                num2 = 3;
                continue;
              }
              goto label_3;
            default:
              goto label_3;
          }
        }
label_3:
        if (PublishData.eU9pOBhqKECwDJQTcv0I((object) this.DeltaPublishedMetadata) > 0)
          num1 = 2;
        else
          break;
      }
label_5:
      return PublishData.eU9pOBhqKECwDJQTcv0I((object) this.RestartNeededMetadata) > 0;
label_6:
      return true;
    }

    /// <summary>В списках кроме списка мягкой публикации записей нет</summary>
    internal bool OnlySoftPublished()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (PublishData.eU9pOBhqKECwDJQTcv0I((object) this.DeltaPublishedMetadata) != 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 1 : 0;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      return this.RestartNeededMetadata.Count == 0;
label_5:
      return false;
    }

    public PublishData()
    {
      PublishData.qfUXVShqXjCcwNtHmhV3();
      this.RestartNeededMetadata = new Dictionary<Guid, IRootMetadata>();
      this.DeltaPublishedMetadata = new Dictionary<Guid, IRootMetadata>();
      this.SoftPublishedMetadata = new Dictionary<Guid, IRootMetadata>();
      this.MetadataItems = new List<IMetadataItem>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static int eU9pOBhqKECwDJQTcv0I([In] object obj0) => ((Dictionary<Guid, IRootMetadata>) obj0).Count;

    internal static bool N4EAN0hqRs4ma5Cy403X() => PublishData.WypBKEhqiNJ06nPZj8eO == null;

    internal static PublishData JcE9JohqqVqSUW6vnGrF() => PublishData.WypBKEhqiNJ06nPZj8eO;

    internal static void qfUXVShqXjCcwNtHmhV3() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
