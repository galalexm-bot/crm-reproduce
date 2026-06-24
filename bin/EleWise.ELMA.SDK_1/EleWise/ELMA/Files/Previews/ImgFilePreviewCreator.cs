// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.Previews.ImgFilePreviewCreator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Files.Previews
{
  /// <summary>Отображение картинок</summary>
  [Component(Order = 100)]
  public class ImgFilePreviewCreator : BaseFilePreviewCreatorEx
  {
    public static Guid UID;
    internal static ImgFilePreviewCreator EXuXELG1AVmiHt4PSm9G;

    public override Guid Uid => ImgFilePreviewCreator.UID;

    public override string DisplayName => EleWise.ELMA.SR.T((string) ImgFilePreviewCreator.cmn1GhG10lxWwfpXaLN2(1514961705 ^ 1515165557));

    public override List<string> Extensions => new List<string>()
    {
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-680446928 - -370807692 ^ -309722072),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(1819636893 << 3 ^ 1672124734),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(1142330761 ^ 1541959139 ^ 536855944),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105121188),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1290212282 ^ -644262414 ^ 1786807422)
    };

    public override string GetMainFileName(BinaryFile file) => (string) ImgFilePreviewCreator.wZerP6G1mYPyNnlX9nTU((object) file);

    public override string GetPreviewText(BinaryFile file) => (string) null;

    public override bool EnableGenerateHtml() => false;

    public override bool RequiredExternalCreator => false;

    public ImgFilePreviewCreator()
    {
      ImgFilePreviewCreator.pJP7yRG1y8N1PvFcGLfX();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static ImgFilePreviewCreator()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ImgFilePreviewCreator.UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(2045296739 + 1688595713 ^ -561167962));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 0 : 0;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static object cmn1GhG10lxWwfpXaLN2(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool li1XTrG17LLHEZOuh9gg() => ImgFilePreviewCreator.EXuXELG1AVmiHt4PSm9G == null;

    internal static ImgFilePreviewCreator XGCDkdG1x4efSgF5OFm4() => ImgFilePreviewCreator.EXuXELG1AVmiHt4PSm9G;

    internal static object wZerP6G1mYPyNnlX9nTU([In] object obj0) => (object) ((BinaryFile) obj0).ContentFilePath;

    internal static void pJP7yRG1y8N1PvFcGLfX() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
