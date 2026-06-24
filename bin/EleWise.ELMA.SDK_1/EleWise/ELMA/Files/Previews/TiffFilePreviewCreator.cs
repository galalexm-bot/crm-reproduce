// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.Previews.TiffFilePreviewCreator
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
  /// <summary>Обработка TIFF изображений</summary>
  [Component(Order = 100)]
  public class TiffFilePreviewCreator : BaseFilePreviewCreatorEx
  {
    public static Guid UID;
    internal static TiffFilePreviewCreator eTd3sxGNgX3vyL3SFYqN;

    public override Guid Uid => TiffFilePreviewCreator.UID;

    public override string DisplayName => EleWise.ELMA.SR.T((string) TiffFilePreviewCreator.P7fGe3GNYXHLeIigFlUM(1470440286 ^ 1470550134));

    public override List<string> Extensions => new List<string>()
    {
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1350312861 << 3 ^ 2082447540),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740419980)
    };

    public override string GetRelativeMainFileName(BinaryFile file) => z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106399612);

    public override string GetPreviewText(BinaryFile file) => (string) null;

    public override bool EnableGenerateHtml() => false;

    public override string ExternalCreatorFileName => z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426456882 ^ 2009939514 ^ -583584862);

    public TiffFilePreviewCreator()
    {
      TiffFilePreviewCreator.UqgHE4GNLQ6vw1mwl8dK();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static TiffFilePreviewCreator()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            TiffFilePreviewCreator.UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837855279));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 0 : 0;
            continue;
          case 2:
            TiffFilePreviewCreator.UqgHE4GNLQ6vw1mwl8dK();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static object P7fGe3GNYXHLeIigFlUM(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool tG2AWgGN52nHrqDOmlsE() => TiffFilePreviewCreator.eTd3sxGNgX3vyL3SFYqN == null;

    internal static TiffFilePreviewCreator cm6Pm2GNjUjgN4VBREjc() => TiffFilePreviewCreator.eTd3sxGNgX3vyL3SFYqN;

    internal static void UqgHE4GNLQ6vw1mwl8dK() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
