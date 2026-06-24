// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.BPMApps.ScriptModulesBAChapter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.BPMApps;
using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Scripts.BPMApps
{
  public class ScriptModulesBAChapter : BPMAppManifestChapter
  {
    private static ScriptModulesBAChapter EFmKodbTQG3pmfxB1tNg;

    /// <summary>Модули</summary>
    [XmlArray("Modules")]
    [DefaultValue(null)]
    public List<ScriptModuleBAItem> Modules { get; set; }

    public ScriptModulesBAChapter()
    {
      ScriptModulesBAChapter.m4aGTEbT8R5OQ8JvZZwi();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void m4aGTEbT8R5OQ8JvZZwi() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool e5QxXQbTCdVeielRkVHm() => ScriptModulesBAChapter.EFmKodbTQG3pmfxB1tNg == null;

    internal static ScriptModulesBAChapter TKS9oAbTvJiv0SAumDFx() => ScriptModulesBAChapter.EFmKodbTQG3pmfxB1tNg;
  }
}
