// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.BPMApps.Services.FunctionsBAConverter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.BPMApps.Services
{
  /// <summary>
  /// Конвертации манифеста и настроек экспорта метаданных функций
  /// </summary>
  [Component(Order = 1050)]
  internal class FunctionsBAConverter : IBPMAppItemsConverter
  {
    internal static FunctionsBAConverter Tf0JpXfO5Y0hGsxTsYr1;

    /// <inheritdoc />
    public void ToBPMAppManifest(ConfigExportSettings settings, BPMAppManifest bpmAppManifest)
    {
      int num = 3;
      FunctionBAChapter chapter;
      FunctionExportSetting functionExportSetting;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_10;
          case 2:
            FunctionsBAConverter.uyawnSfOUKlTQkVPF8sL((object) settings, FunctionsBAConverter.Vc3PUofOLibih4DpJKVK(-1317790512 ^ -1317734818));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 3 : 4;
            continue;
          case 3:
            FunctionsBAConverter.uyawnSfOUKlTQkVPF8sL((object) bpmAppManifest, FunctionsBAConverter.Vc3PUofOLibih4DpJKVK(-345420348 ^ -345242282));
            num = 2;
            continue;
          case 4:
            object obj;
            if (!settings.CustomSettings.TryGetValue(FunctionExportConsts.ExportExtensionUid, out obj))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 4 : 12;
              continue;
            }
            functionExportSetting = obj as FunctionExportSetting;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 8 : 11;
            continue;
          case 5:
            if (FunctionsBAConverter.G97fCkfOsvIePRs868AH((object) chapter.Functions) > 0)
            {
              num = 8;
              continue;
            }
            goto label_9;
          case 6:
            chapter.Functions = functionExportSetting.FunctionsIds.Select<Guid, FunctionBAItem>((Func<Guid, FunctionBAItem>) (uid =>
            {
              FunctionBAItem bpmAppManifest1 = new FunctionBAItem();
              // ISSUE: reference to a compiler-generated method
              FunctionsBAConverter.\u003C\u003Ec.YvqXyh8zDf0k5Mr1YpCa((object) bpmAppManifest1, uid);
              return bpmAppManifest1;
            })).ToList<FunctionBAItem>();
            num = 9;
            continue;
          case 7:
            goto label_2;
          case 8:
            bpmAppManifest.SetChapter((BPMAppManifestChapter) chapter);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 1 : 1;
            continue;
          case 9:
            if (chapter.Functions == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 7 : 5;
              continue;
            }
            goto case 5;
          case 10:
            if (functionExportSetting.FunctionsIds != null)
            {
              num = 6;
              continue;
            }
            goto case 9;
          case 11:
            if (functionExportSetting != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
              continue;
            }
            goto label_23;
          case 12:
            goto label_15;
          case 13:
            goto label_8;
          default:
            FunctionBAChapter functionBaChapter = new FunctionBAChapter();
            functionBaChapter.Uid = FunctionExportConsts.ExportExtensionUid;
            chapter = functionBaChapter;
            num = 10;
            continue;
        }
      }
label_10:
      return;
label_2:
      return;
label_15:
      return;
label_8:
      return;
label_23:
      return;
label_9:;
    }

    /// <inheritdoc />
    public void ToExportSettings(BPMAppManifest bpmAppManifest, ConfigExportSettings settings)
    {
      int num1 = 8;
      FunctionBAChapter functionBaChapter;
      FunctionExportSetting functionExportSetting;
      List<FunctionBAItem>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (functionBaChapter != null)
            {
              functionExportSetting = new FunctionExportSetting();
              num1 = 10;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 3;
            continue;
          case 2:
            functionExportSetting.FunctionsIds = new List<Guid>();
            num1 = 9;
            continue;
          case 3:
            goto label_5;
          case 4:
            functionBaChapter = FunctionsBAConverter.m6Qx5YfOcMSLR6j5RP5C((object) bpmAppManifest, FunctionExportConsts.ExportExtensionUid) as FunctionBAChapter;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 1;
            continue;
          case 5:
            goto label_17;
          case 6:
label_4:
            settings.CustomSettings[FunctionExportConsts.ExportExtensionUid] = (object) functionExportSetting;
            num1 = 5;
            continue;
          case 7:
            Contract.ArgumentNotNull((object) settings, (string) FunctionsBAConverter.Vc3PUofOLibih4DpJKVK(1470440286 ^ 1470482896));
            num1 = 4;
            continue;
          case 8:
            FunctionsBAConverter.uyawnSfOUKlTQkVPF8sL((object) bpmAppManifest, FunctionsBAConverter.Vc3PUofOLibih4DpJKVK(1574260816 ^ 1573918914));
            num1 = 7;
            continue;
          case 9:
            enumerator = functionBaChapter.Functions.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 0 : 0;
            continue;
          case 10:
            if (functionBaChapter.Functions != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 2 : 2;
              continue;
            }
            goto case 6;
          default:
            try
            {
label_12:
              if (enumerator.MoveNext())
                goto label_9;
              else
                goto label_13;
label_8:
              FunctionBAItem current;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_9;
                  case 2:
                    functionExportSetting.FunctionsIds.Add(FunctionsBAConverter.A68WB7fOzgUUhwFhgndX((object) current));
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
                    continue;
                  case 3:
                    goto label_4;
                  default:
                    goto label_12;
                }
              }
label_9:
              current = enumerator.Current;
              num2 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
              {
                num2 = 2;
                goto label_8;
              }
              else
                goto label_8;
label_13:
              num2 = 3;
              goto label_8;
            }
            finally
            {
              enumerator.Dispose();
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
                num3 = 0;
              switch (num3)
              {
                default:
              }
            }
        }
      }
label_5:
      return;
label_17:;
    }

    public FunctionsBAConverter()
    {
      FunctionsBAConverter.tILH16f2FW1NvgwOnXX5();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object Vc3PUofOLibih4DpJKVK(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void uyawnSfOUKlTQkVPF8sL([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static int G97fCkfOsvIePRs868AH([In] object obj0) => ((List<FunctionBAItem>) obj0).Count;

    internal static bool P642F0fOjEEyI3E3YLMn() => FunctionsBAConverter.Tf0JpXfO5Y0hGsxTsYr1 == null;

    internal static FunctionsBAConverter pN7TjsfOYYh7lWYKQALX() => FunctionsBAConverter.Tf0JpXfO5Y0hGsxTsYr1;

    internal static object m6Qx5YfOcMSLR6j5RP5C([In] object obj0, Guid uid) => (object) ((BPMAppManifest) obj0).GetChapter(uid);

    internal static Guid A68WB7fOzgUUhwFhgndX([In] object obj0) => ((BPMAppManifestItem) obj0).Uid;

    internal static void tILH16f2FW1NvgwOnXX5() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
