// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.Previews.WordFilePreviewCreator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Aspose.Words;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Files.Previews
{
  /// <summary>Обработка вордовских дкоументов</summary>
  [Component(Order = 100)]
  public class WordFilePreviewCreator : BasePasswordFilePreviewCreatorEx
  {
    public static Guid UID;
    private static WordFilePreviewCreator CiO2HMG3bp0SeRdfycSh;

    public override Guid Uid => WordFilePreviewCreator.UID;

    public override string DisplayName => (string) WordFilePreviewCreator.WQEQggG3frt30pGqH0sY(WordFilePreviewCreator.va53OfG3Epk9P1hLZAu5(1470998129 - 231418599 ^ 1239518720));

    public override List<string> Extensions => new List<string>()
    {
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1380439818 << 3 ^ 1841301268),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(864270449 << 6 ^ -521184016),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-244066886 - -48452443 ^ -195663411),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(1253244298 - 1829393894 ^ -575974886),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(2045296739 + 1688595713 ^ -561162070),
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112798388)
    };

    public override string ExternalCreatorFileName => (string) WordFilePreviewCreator.va53OfG3Epk9P1hLZAu5(-488881205 ^ -488655315);

    /// <inheritdoc />
    public override bool CheckPassword(BinaryFile file, string password)
    {
      int num1 = 6;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_10;
            case 2:
              goto label_14;
            case 3:
              goto label_11;
            case 4:
              goto label_7;
            case 5:
              if (((FileFormatInfo) WordFilePreviewCreator.j9D8tRG3vfRVM8XXG6CH(WordFilePreviewCreator.NGjuRCG3Q6pXd8nTa9B3((object) file))).IsEncrypted)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 8 : 4;
                continue;
              }
              goto label_7;
            case 6:
              if (!WordFilePreviewCreator.YGhP1EG3CfjKb9nbgVWg(WordFilePreviewCreator.NGjuRCG3Q6pXd8nTa9B3((object) file)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 3 : 5;
                continue;
              }
              goto label_11;
            case 7:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 2 : 1;
              continue;
            case 8:
              goto label_8;
            default:
              goto label_3;
          }
        }
label_8:
        if (password != null)
          num1 = 7;
        else
          break;
      }
label_3:
      return false;
label_7:
      return password == null;
label_10:
      bool flag;
      return flag;
label_11:
      return password == null;
label_14:
      try
      {
        Document document = new Document((string) WordFilePreviewCreator.NGjuRCG3Q6pXd8nTa9B3((object) file), new LoadOptions()
        {
          Password = password
        });
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
          num3 = 0;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_10;
            default:
              flag = true;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 1 : 1;
              continue;
          }
        }
      }
      catch (IncorrectPasswordException ex)
      {
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
          num4 = 0;
        while (true)
        {
          switch (num4)
          {
            case 1:
              goto label_10;
            default:
              flag = false;
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 1 : 1;
              continue;
          }
        }
      }
    }

    public WordFilePreviewCreator()
    {
      WordFilePreviewCreator.oOUIkYG38xFVnfN2ePFm();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static WordFilePreviewCreator()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            WordFilePreviewCreator.UID = new Guid((string) WordFilePreviewCreator.va53OfG3Epk9P1hLZAu5(222162814 ^ 222173508));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 1 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static object va53OfG3Epk9P1hLZAu5(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object WQEQggG3frt30pGqH0sY([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool Jl44BXG3h3nAQj29NlOM() => WordFilePreviewCreator.CiO2HMG3bp0SeRdfycSh == null;

    internal static WordFilePreviewCreator MTxKJyG3G9sQTZwktD9s() => WordFilePreviewCreator.CiO2HMG3bp0SeRdfycSh;

    internal static object NGjuRCG3Q6pXd8nTa9B3([In] object obj0) => (object) ((BinaryFile) obj0).ContentFilePath;

    internal static bool YGhP1EG3CfjKb9nbgVWg([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object j9D8tRG3vfRVM8XXG6CH([In] object obj0) => (object) FileFormatUtil.DetectFileFormat((string) obj0);

    internal static void oOUIkYG38xFVnfN2ePFm() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
