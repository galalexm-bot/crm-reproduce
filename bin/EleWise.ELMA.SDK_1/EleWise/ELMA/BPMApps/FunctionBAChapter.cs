// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.BPMApps.FunctionBAChapter
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
  /// <summary>Настройки BPM App для экспорта метаданных функций</summary>
  public sealed class FunctionBAChapter : BPMAppManifestChapter
  {
    internal static FunctionBAChapter qc6XpZfT9XkDRkajOarP;

    /// <summary>Идентификаторы метаданных функций</summary>
    [XmlArray("Functions")]
    [DefaultValue(null)]
    public List<FunctionBAItem> Functions { get; set; }

    public FunctionBAChapter()
    {
      FunctionBAChapter.NpkcmSfTroVqJLc2oRvE();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void NpkcmSfTroVqJLc2oRvE() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool xsQ2tHfTdsQyGnqc2ouI() => FunctionBAChapter.qc6XpZfT9XkDRkajOarP == null;

    internal static FunctionBAChapter PTQtUffTlc32BcohqAZp() => FunctionBAChapter.qc6XpZfT9XkDRkajOarP;
  }
}
