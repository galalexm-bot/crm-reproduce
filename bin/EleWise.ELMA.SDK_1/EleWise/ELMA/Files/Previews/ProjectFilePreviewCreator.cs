// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.Previews.ProjectFilePreviewCreator
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
  [Component(Order = 100)]
  public class ProjectFilePreviewCreator : BaseFilePreviewCreatorEx
  {
    public static Guid UID;
    internal static ProjectFilePreviewCreator guDI5aGN7KdmQF5oPbsR;

    public override Guid Uid => ProjectFilePreviewCreator.UID;

    public override string DisplayName => (string) ProjectFilePreviewCreator.cfVv3pGNyZyghh9jH9GF(ProjectFilePreviewCreator.hSFFcOGNmBZUxnO5aDTO(993438473 ^ 993352259));

    public override List<string> Extensions => new List<string>()
    {
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1120607109 - 305487170 ^ -1426183791),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(993438473 ^ 993352347)
    };

    public override string ExternalCreatorFileName => (string) ProjectFilePreviewCreator.hSFFcOGNmBZUxnO5aDTO(-1872275253 >> 6 ^ -29201155);

    public ProjectFilePreviewCreator()
    {
      ProjectFilePreviewCreator.tLk4BqGNM76fuKdhgIKm();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static ProjectFilePreviewCreator()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            ProjectFilePreviewCreator.UID = new Guid((string) ProjectFilePreviewCreator.hSFFcOGNmBZUxnO5aDTO(1461625753 ^ 1461539425));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 1 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static object hSFFcOGNmBZUxnO5aDTO(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object cfVv3pGNyZyghh9jH9GF([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool pgdC0pGNxEVqi58jhhqi() => ProjectFilePreviewCreator.guDI5aGN7KdmQF5oPbsR == null;

    internal static ProjectFilePreviewCreator hXVOnZGN0WNgJeuUND8P() => ProjectFilePreviewCreator.guDI5aGN7KdmQF5oPbsR;

    internal static void tLk4BqGNM76fuKdhgIKm() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
