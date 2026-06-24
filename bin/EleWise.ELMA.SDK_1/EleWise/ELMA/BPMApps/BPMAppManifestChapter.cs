// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.BPMApps.BPMAppManifestChapter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Xml.Serialization;

namespace EleWise.ELMA.BPMApps
{
  /// <summary>Раздел в манифесте BPM App</summary>
  [Component]
  public abstract class BPMAppManifestChapter : IXsiType
  {
    internal static BPMAppManifestChapter hOqhB7fkomCtJMaQEPWA;

    /// <summary>Уникальный идентификатор раздела</summary>
    [XmlElement("Uid")]
    public Guid Uid
    {
      get => this.\u003CUid\u003Ek__BackingField;
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
              this.\u003CUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 0 : 0;
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

    protected BPMAppManifestChapter()
    {
      BPMAppManifestChapter.P95NhKfkGicNNmlwYxl2();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool EooIFSfkb8Qid7cWYZij() => BPMAppManifestChapter.hOqhB7fkomCtJMaQEPWA == null;

    internal static BPMAppManifestChapter AhvycvfkhWGMRJv5VFt1() => BPMAppManifestChapter.hOqhB7fkomCtJMaQEPWA;

    internal static void P95NhKfkGicNNmlwYxl2() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
