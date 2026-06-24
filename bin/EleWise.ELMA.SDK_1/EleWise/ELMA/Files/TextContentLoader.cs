// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.TextContentLoader
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Collections.Generic;

namespace EleWise.ELMA.Files
{
  /// <summary>Извлекатель текста из текстовых документов.</summary>
  [Component(Order = 10)]
  public class TextContentLoader : BaseFileContentLoader
  {
    internal static TextContentLoader yW9vZLGTkVl425VOYqkx;

    /// <summary>Расширения файлов</summary>
    public override List<string> Extensions => new List<string>()
    {
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(1113862659 ^ 1113956083),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-680446928 - -370807692 ^ -309817552),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(1178210108 ^ 1178191792)
    };

    /// <summary>Нужно ли чистить HTML после получения из файла</summary>
    public override bool NeedHtmlClear => false;

    public TextContentLoader()
    {
      TextContentLoader.i8JlovGT2Jte5yEi46LC();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void i8JlovGT2Jte5yEi46LC() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool Q50JB1GTncDb792q4FBp() => TextContentLoader.yW9vZLGTkVl425VOYqkx == null;

    internal static TextContentLoader wpsJojGTOb6jUOWLKWlf() => TextContentLoader.yW9vZLGTkVl425VOYqkx;
  }
}
