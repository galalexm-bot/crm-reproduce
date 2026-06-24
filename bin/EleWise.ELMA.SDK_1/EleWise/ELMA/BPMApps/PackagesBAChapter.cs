// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.BPMApps.PackagesBAChapter
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
  public class PackagesBAChapter : BPMAppManifestChapter
  {
    internal static PackagesBAChapter oIGdBZfkLZNZUgxbP0p8;

    /// <summary>Экспортируемые пакеты</summary>
    [XmlArray("Packages")]
    [DefaultValue(null)]
    public List<PackageBAItem> Packages { get; set; }

    public PackagesBAChapter()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool jIHBspfkUbNQTkCR81QR() => PackagesBAChapter.oIGdBZfkLZNZUgxbP0p8 == null;

    internal static PackagesBAChapter l00Z7gfksP2V8xrBcKoS() => PackagesBAChapter.oIGdBZfkLZNZUgxbP0p8;
  }
}
