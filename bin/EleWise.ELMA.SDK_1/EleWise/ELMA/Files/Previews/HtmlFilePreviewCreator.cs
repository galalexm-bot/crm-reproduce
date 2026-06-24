// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.Previews.HtmlFilePreviewCreator
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
  /// <summary>Отображение текстовых файлов</summary>
  [Component(Order = 100)]
  public class HtmlFilePreviewCreator : BaseFilePreviewCreatorEx
  {
    public static Guid UID;
    internal static HtmlFilePreviewCreator RIPttqGe2kejKQt5Ztl8;

    public override Guid Uid => HtmlFilePreviewCreator.UID;

    public override string DisplayName => (string) HtmlFilePreviewCreator.c6JjN9GeNHUFTgyTk9RH(HtmlFilePreviewCreator.EpDMXVGe1B3kfgoTsOid(-643786247 ^ -643597303));

    public override List<string> Extensions => new List<string>()
    {
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(1505778440 - 1981636111 ^ -475974539),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1350312861 << 3 ^ 2082286466)
    };

    public override string GetMainFileName(BinaryFile file) => (string) HtmlFilePreviewCreator.YTJBHLGe3TMy3qdVkQ5x((object) file);

    public override string GetTextFileName(BinaryFile file) => (string) HtmlFilePreviewCreator.YTJBHLGe3TMy3qdVkQ5x((object) file);

    public override bool EnableGenerateHtml() => false;

    public override bool RequiredExternalCreator => false;

    public HtmlFilePreviewCreator()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static HtmlFilePreviewCreator()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            HtmlFilePreviewCreator.F3WVroGepXFNiMCOpQjX();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            HtmlFilePreviewCreator.UID = new Guid((string) HtmlFilePreviewCreator.EpDMXVGe1B3kfgoTsOid(1253244298 - 1829393894 ^ -575979124));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 2 : 0;
            continue;
        }
      }
label_2:;
    }

    internal static object EpDMXVGe1B3kfgoTsOid(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object c6JjN9GeNHUFTgyTk9RH([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool dEIBa9GeeUXeSAUsrIbK() => HtmlFilePreviewCreator.RIPttqGe2kejKQt5Ztl8 == null;

    internal static HtmlFilePreviewCreator Y6YLp0GePyLQdOarnWfY() => HtmlFilePreviewCreator.RIPttqGe2kejKQt5Ztl8;

    internal static object YTJBHLGe3TMy3qdVkQ5x([In] object obj0) => (object) ((BinaryFile) obj0).ContentFilePath;

    internal static void F3WVroGepXFNiMCOpQjX() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
