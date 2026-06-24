// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.LocalizationMergeOperation
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Services
{
  internal class LocalizationMergeOperation : LocalizationOperation
  {
    internal static LocalizationMergeOperation BKei7uB7qLQ7vpEyildk;

    public LocalizationMergeOperation()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Name = (string) LocalizationMergeOperation.jcMSp1B7TIGh1CwTfCm5(--1360331293 ^ 1360288963);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public string LocalId
    {
      get => this.\u003CLocalId\u003Ek__BackingField;
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
              this.\u003CLocalId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 0 : 0;
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
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_5;
          case 1:
            if (this.TranslateService == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 0;
              continue;
            }
            goto case 2;
          case 2:
            if (!LocalizationMergeOperation.yxvvBHB7kibKvXvCXxgL((object) this.LocalId))
            {
              num = 3;
              continue;
            }
            goto label_2;
          case 3:
            LocalizationMergeOperation.cJNgHxB7nTWSo1NqBy0A((object) this.TranslateService, (object) this.LocalId);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 4 : 4;
            continue;
          case 4:
            goto label_9;
          default:
            goto label_10;
        }
      }
label_5:
      return;
label_9:
      return;
label_10:
      return;
label_2:;
    }

    internal static object jcMSp1B7TIGh1CwTfCm5(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool rKh7ytB7KPnXtS3E6Log() => LocalizationMergeOperation.BKei7uB7qLQ7vpEyildk == null;

    internal static LocalizationMergeOperation xcGOQUB7XwWCvQDKGIHy() => LocalizationMergeOperation.BKei7uB7qLQ7vpEyildk;

    internal static bool yxvvBHB7kibKvXvCXxgL([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static void cJNgHxB7nTWSo1NqBy0A([In] object obj0, [In] object obj1) => ((TranslateService) obj0).MergeFiles((string) obj1);
  }
}
