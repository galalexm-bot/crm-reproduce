// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.Previews.TextFilePreviewCreator
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
  /// <summary>Отображение текстовых файлов</summary>
  [Component(Order = 100)]
  public class TextFilePreviewCreator : BaseFilePreviewCreatorEx
  {
    public static Guid UID;
    private static TextFilePreviewCreator Gi86J9GNJuR4s7bKioZm;

    public override Guid Uid => TextFilePreviewCreator.UID;

    public override string DisplayName => EleWise.ELMA.SR.T((string) TextFilePreviewCreator.f2yiL9GNlsXB8UlIusSW(694673736 ^ -23604109 ^ -671889549));

    public override List<string> Extensions => new List<string>()
    {
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051276242 - 990076387 ^ 61110559),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(~289714581 ^ -289685468)
    };

    public override string ExternalCreatorFileName => (string) TextFilePreviewCreator.f2yiL9GNlsXB8UlIusSW(~538519529 ^ -538629486);

    public TextFilePreviewCreator()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static TextFilePreviewCreator()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TextFilePreviewCreator.YBbokIGNrYa7XTwFgn6e();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            TextFilePreviewCreator.UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(572119659 - -337058038 ^ 909312441));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 2 : 1;
            continue;
        }
      }
label_2:;
    }

    internal static object f2yiL9GNlsXB8UlIusSW(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool sv82cLGN9G9RoPx6Ipdy() => TextFilePreviewCreator.Gi86J9GNJuR4s7bKioZm == null;

    internal static TextFilePreviewCreator G2LyCwGNdKYcOnbwORM0() => TextFilePreviewCreator.Gi86J9GNJuR4s7bKioZm;

    internal static void YBbokIGNrYa7XTwFgn6e() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
