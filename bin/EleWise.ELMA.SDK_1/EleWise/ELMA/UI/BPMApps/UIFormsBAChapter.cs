// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.BPMApps.UIFormsBAChapter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.BPMApps;
using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

namespace EleWise.ELMA.UI.BPMApps
{
  public class UIFormsBAChapter : BPMAppManifestChapter
  {
    internal static UIFormsBAChapter YsDBUN9ckmos1qxkijF;

    /// <summary>Формы</summary>
    [XmlArray("Forms")]
    [DefaultValue(null)]
    public List<UIFormBAItem> Forms { get; set; }

    public UIFormsBAChapter()
    {
      UIFormsBAChapter.TFtXvYdBskktQBL11ha();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void TFtXvYdBskktQBL11ha() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool GNOuks9zS7SvvV5rDnh() => UIFormsBAChapter.YsDBUN9ckmos1qxkijF == null;

    internal static UIFormsBAChapter AsCiCjdFDijN16tMvXE() => UIFormsBAChapter.YsDBUN9ckmos1qxkijF;
  }
}
