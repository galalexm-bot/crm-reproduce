// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.Previews.PdfFilePreviewCreator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Files.Previews
{
  /// <summary>Обработка PDF</summary>
  [Component(Order = 100)]
  public class PdfFilePreviewCreator : BaseFilePreviewCreatorEx
  {
    public static Guid UID;
    internal static PdfFilePreviewCreator qJeT3qG1Mv9iQ6k5m32a;

    public override Guid Uid => PdfFilePreviewCreator.UID;

    public override string DisplayName => (string) PdfFilePreviewCreator.HMIjbgG1lyVexe3UnGYr(PdfFilePreviewCreator.uTnfesG1duufoYtqrlF1(1232639661 >> 3 ^ 153944007));

    public override List<string> Extensions => new List<string>()
    {
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97992990)
    };

    public override string ExternalCreatorFileName => (string) PdfFilePreviewCreator.uTnfesG1duufoYtqrlF1(516838154 ^ 516800034);

    public override string GetMainFileName(BinaryFile file) => (string) PdfFilePreviewCreator.XxQbBiG1rOUBs2sS9CdW((object) file);

    public override bool HasPreview(BinaryFile file, long priority)
    {
      int num1 = 6;
      while (true)
      {
        int num2 = num1;
        string str;
        while (true)
        {
          string mainFileName;
          switch (num2)
          {
            case 1:
              if (PdfFilePreviewCreator.qFdQp8G158ysL509BwYv((object) mainFileName))
              {
                num2 = 11;
                continue;
              }
              break;
            case 2:
            case 11:
              goto label_9;
            case 4:
            case 9:
              goto label_5;
            case 5:
              if (PdfFilePreviewCreator.gRElrgG1gR32ugMyXs3B((object) mainFileName))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
                continue;
              }
              goto case 1;
            case 6:
              mainFileName = base.GetMainFileName(file);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 1 : 5;
              continue;
            case 7:
              if (string.IsNullOrEmpty(str))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 3 : 9;
                continue;
              }
              goto case 8;
            case 8:
              if (PdfFilePreviewCreator.qFdQp8G158ysL509BwYv((object) str))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 10 : 1;
                continue;
              }
              goto label_5;
            case 10:
              goto label_6;
          }
          Locator.GetServiceNotNull<IFilePreviewService>().AddPreviewWork(file, 0L);
          num2 = 2;
        }
label_9:
        str = (string) PdfFilePreviewCreator.BgLMrqG1joT829UX9ien((object) this, (object) file);
        num1 = 7;
      }
label_5:
      return false;
label_6:
      return true;
    }

    public override bool EnableGenerateHtml() => false;

    public PdfFilePreviewCreator()
    {
      PdfFilePreviewCreator.tDIqKlG1YVcCDvhesTLW();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static PdfFilePreviewCreator()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            PdfFilePreviewCreator.UID = new Guid((string) PdfFilePreviewCreator.uTnfesG1duufoYtqrlF1(-441065788 ^ -2092910478 ^ 1727433676));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 0 : 0;
            continue;
          case 2:
            PdfFilePreviewCreator.tDIqKlG1YVcCDvhesTLW();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static object uTnfesG1duufoYtqrlF1(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object HMIjbgG1lyVexe3UnGYr([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool R3cmvDG1JYFJhuYIgnQg() => PdfFilePreviewCreator.qJeT3qG1Mv9iQ6k5m32a == null;

    internal static PdfFilePreviewCreator eASt1KG19OEM7pyloakx() => PdfFilePreviewCreator.qJeT3qG1Mv9iQ6k5m32a;

    internal static object XxQbBiG1rOUBs2sS9CdW([In] object obj0) => (object) ((BinaryFile) obj0).ContentFilePath;

    internal static bool gRElrgG1gR32ugMyXs3B([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static bool qFdQp8G158ysL509BwYv([In] object obj0) => File.Exists((string) obj0);

    internal static object BgLMrqG1joT829UX9ien([In] object obj0, [In] object obj1) => (object) ((BaseFilePreviewCreator) obj0).GetMainFileName((BinaryFile) obj1);

    internal static void tDIqKlG1YVcCDvhesTLW() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
