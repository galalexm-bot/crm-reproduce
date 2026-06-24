// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.BPMApps.BpmAppsBAChapter
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
  /// <summary>Настройки BPM App для экспорта объектной модели</summary>
  public class BpmAppsBAChapter : BPMAppManifestChapter
  {
    private static BpmAppsBAChapter fIghjHfkmiVoptwt3eE4;

    /// <summary>Списки BPM App из системы</summary>
    [XmlArray("Components")]
    [DefaultValue(null)]
    public List<BpmAppBAItem> Components { get; set; }

    public BpmAppsBAChapter()
    {
      BpmAppsBAChapter.AEaaMHfkJ8aos8V7xIDq();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void AEaaMHfkJ8aos8V7xIDq() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool u43E4ifkytRaVedHYVtR() => BpmAppsBAChapter.fIghjHfkmiVoptwt3eE4 == null;

    internal static BpmAppsBAChapter ukQGA4fkMQqFGVNYXZ4l() => BpmAppsBAChapter.fIghjHfkmiVoptwt3eE4;
  }
}
