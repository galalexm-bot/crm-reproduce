// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.Previews.VisioFilePreviewCreator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Files.Previews
{
  [Component(Order = 100)]
  public class VisioFilePreviewCreator : BaseFilePreviewCreatorEx
  {
    public static Guid UID;
    private static VisioFilePreviewCreator NHx799GNzFSmZ1XC8f7l;

    public override Guid Uid => VisioFilePreviewCreator.UID;

    public override string DisplayName => EleWise.ELMA.SR.T((string) VisioFilePreviewCreator.bsnU22G3WGXhnZemwRi5(901793403 ^ 902018433));

    public override List<string> Extensions => new List<string>()
    {
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317541806),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 1418222084),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(1994213607 >> 4 ^ 124657682),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(322893104 - -1992822529 ^ -1979387751),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-710283084 ^ -537863435 ^ 173727477),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-688192331 - 435440695 ^ -1123726146),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-138018305 ^ -138021581),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-53329496 >> 4 ^ -3223358)
    };

    public override string ExternalCreatorFileName => z2jc63fLkugS1X8Q9N.tE1kD1vbB(1232639661 >> 3 ^ 153937457);

    public VisioFilePreviewCreator()
    {
      VisioFilePreviewCreator.R2Oid5G3o2irjKlF5FbM();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static VisioFilePreviewCreator()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            VisioFilePreviewCreator.UID = new Guid((string) VisioFilePreviewCreator.bsnU22G3WGXhnZemwRi5(-70007027 ^ -70241737));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
            continue;
          case 2:
            VisioFilePreviewCreator.R2Oid5G3o2irjKlF5FbM();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static object bsnU22G3WGXhnZemwRi5(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool hm4NmQG3F3W9UXRWYgj6() => VisioFilePreviewCreator.NHx799GNzFSmZ1XC8f7l == null;

    internal static VisioFilePreviewCreator ttnmxXG3BJnBY9lME1Pu() => VisioFilePreviewCreator.NHx799GNzFSmZ1XC8f7l;

    internal static void R2Oid5G3o2irjKlF5FbM() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
