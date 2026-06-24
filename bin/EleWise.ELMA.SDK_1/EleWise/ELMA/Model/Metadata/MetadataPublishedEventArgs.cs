// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.MetadataPublishedEventArgs
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Аргументы события публикации метаданных</summary>
  public class MetadataPublishedEventArgs : EventArgs
  {
    internal static MetadataPublishedEventArgs a2fIlBbDHyG87Nj3E1Co;

    /// <summary>Результат публикации</summary>
    public MetadataPublishResult PublishResult
    {
      get => this.\u003CPublishResult\u003Ek__BackingField;
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
              this.\u003CPublishResult\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 0;
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

    /// <summary>Список мягко опубликованных метаданных</summary>
    public ICollection<IRootMetadata> SoftPublishedMetadata { get; set; }

    /// <summary>
    /// Список опубликованных метаданных, для которых нужен перезапуск сервера
    /// </summary>
    public ICollection<IRootMetadata> RestartNeededMetadata { get; set; }

    /// <summary>Список дельта-опубликованных метаданных</summary>
    public ICollection<IRootMetadata> DeltaPublishedMetadata { get; set; }

    public MetadataPublishedEventArgs()
    {
      MetadataPublishedEventArgs.GgU8E0bDxFBdXJje0LFN();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool IsQI4WbDAvwJRgbZdRQU() => MetadataPublishedEventArgs.a2fIlBbDHyG87Nj3E1Co == null;

    internal static MetadataPublishedEventArgs wSGLAabD7iOX5eVtvKnc() => MetadataPublishedEventArgs.a2fIlBbDHyG87Nj3E1Co;

    internal static void GgU8E0bDxFBdXJje0LFN() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
