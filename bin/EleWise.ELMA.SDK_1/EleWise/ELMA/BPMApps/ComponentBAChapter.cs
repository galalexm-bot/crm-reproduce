// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.BPMApps.ComponentBAChapter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

namespace EleWise.ELMA.BPMApps
{
  /// <summary>Настройки BPM App для экспорта метаданных компонентов</summary>
  public sealed class ComponentBAChapter : BPMAppManifestChapter
  {
    internal static ComponentBAChapter KxrfYofTm267S373pORW;

    /// <summary>Идентификаторы метаданных компонентов</summary>
    [DefaultValue(null)]
    [XmlArray("Components")]
    public List<ComponentBAItem> Components { get; set; }

    public ComponentBAChapter()
    {
      ComponentBAChapter.dDjjktfTJI2aqTkbR2xy();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void dDjjktfTJI2aqTkbR2xy() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool Se4fUNfTyqbxQVZrRtSj() => ComponentBAChapter.KxrfYofTm267S373pORW == null;

    internal static ComponentBAChapter ofP3W7fTMCIpXflpFhoG() => ComponentBAChapter.KxrfYofTm267S373pORW;
  }
}
