// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.LocalizationSaveOperation
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Globalization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Services
{
  internal class LocalizationSaveOperation : LocalizationOperation
  {
    private static LocalizationSaveOperation nAWSjXB7uVs70Ci28uhn;

    public LocalizationSaveOperation()
    {
      LocalizationSaveOperation.N2MZSeB7SBwRO6rbJsXw();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Name = (string) LocalizationSaveOperation.bgtMgRB7iVP8eAskMkIY(-787452571 ^ -787468365);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public LocalizationFile File
    {
      get => this.\u003CFile\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CFile\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    public override void Execute()
    {
      int num = 5;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_4;
          case 1:
            goto label_3;
          case 2:
            if (this.File == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 1 : 0;
              continue;
            }
            goto case 3;
          case 3:
            LocalizationSaveOperation.PeZuBtB7RDplmbZm189p((object) this.TranslateService, (object) this.File);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
            continue;
          case 4:
            goto label_2;
          case 5:
            if (this.TranslateService == null)
            {
              num = 4;
              continue;
            }
            goto case 2;
          default:
            goto label_10;
        }
      }
label_4:
      return;
label_3:
      return;
label_2:
      return;
label_10:;
    }

    internal static void N2MZSeB7SBwRO6rbJsXw() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object bgtMgRB7iVP8eAskMkIY(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool stKB5cB7IOhy0qOX0bIK() => LocalizationSaveOperation.nAWSjXB7uVs70Ci28uhn == null;

    internal static LocalizationSaveOperation GSL9l0B7V6WI8k18w5Xd() => LocalizationSaveOperation.nAWSjXB7uVs70Ci28uhn;

    internal static void PeZuBtB7RDplmbZm189p([In] object obj0, [In] object obj1) => ((TranslateService) obj0).SaveChanges((LocalizationFile) obj1);
  }
}
