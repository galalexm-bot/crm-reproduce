// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.TranslatesImportExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.BPMApps;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy.Import
{
  /// <summary>Точка расширения импорта переводов</summary>
  [Component]
  internal class TranslatesImportExtension : ConfigImportExtension
  {
    internal static TranslatesImportExtension iHhCnpE0YrWwkONhxHKD;

    /// <inheritdoc />
    public override void OnPostCompleteTest(PostCompleteTestImportParameters parameters)
    {
      int num1 = 6;
      while (true)
      {
        TranslatesBAChapter translatesBaChapter;
        ConfigImportSettings configImportSettings;
        BPMAppManifest bpmAppManifest;
        IImportSettings importSettings;
        BPMAppManifestFakeChapter chapter;
        switch (num1)
        {
          case 1:
            if (TranslatesImportExtension.fYLjjuE0z9affJ0tJt09((object) configImportSettings) == null)
            {
              num1 = 21;
              continue;
            }
            // ISSUE: reference to a compiler-generated method
            translatesBaChapter = bpmAppManifest.Chapters.FirstOrDefault<BPMAppManifestChapter>((Func<BPMAppManifestChapter, bool>) (c => TranslatesImportExtension.\u003C\u003Ec.hDWYKt8DOtchI97YFR8X((object) c.Uid, (object) TranslateExportConst.ExportExtensionUid))) as TranslatesBAChapter;
            num1 = 19;
            continue;
          case 2:
            goto label_26;
          case 3:
            goto label_25;
          case 4:
            chapter = ((BPMAppFakeManifest) TranslatesImportExtension.fYLjjuE0z9affJ0tJt09((object) configImportSettings)).GetOrCreateChapterByUid(TranslateExportConst.ExportExtensionUid);
            num1 = 13;
            continue;
          case 5:
            importSettings = (IImportSettings) null;
            break;
          case 6:
            if (parameters == null)
            {
              num1 = 5;
              continue;
            }
            importSettings = parameters.ImportSettings;
            break;
          case 7:
            if (parameters != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 16 : 1;
              continue;
            }
            goto label_3;
          case 8:
            goto label_16;
          case 9:
            if (configImportSettings == null)
            {
              num1 = 17;
              continue;
            }
            goto default;
          case 10:
            if (configImportSettings.Manifest.Packages.Any<PackageManifest>())
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 1;
              continue;
            }
            goto label_42;
          case 11:
            if (configImportSettings == null)
            {
              num1 = 8;
              continue;
            }
            goto case 7;
          case 12:
            goto label_41;
          case 13:
            translatesBaChapter.Translates.ForEach((Action<TranslateBAItem>) (p =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    chapter.GetOrCreateItemByUidProxy((string) TranslatesImportExtension.\u003C\u003Ec__DisplayClass0_0.MvbX0s8DqjnMk2PavQH8((object) p), (string) TranslatesImportExtension.\u003C\u003Ec__DisplayClass0_0.irPwS18DKcviOn6yWfSH((object) p));
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 3;
            continue;
          case 14:
            bpmAppManifest = ClassSerializationHelper.DeserializeObjectByXml<BPMAppManifest>(parameters.Manifest.BPMAppManifest);
            num1 = 22;
            continue;
          case 15:
            if (bpmAppManifest.Chapters.Any<BPMAppManifestChapter>())
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 9 : 7;
              continue;
            }
            goto label_43;
          case 16:
            if (TranslatesImportExtension.ylov2AE0swuD83XJddT4((object) parameters) != null)
            {
              num1 = 14;
              continue;
            }
            goto label_2;
          case 17:
            goto label_45;
          case 18:
            if (translatesBaChapter.Translates.Any<TranslateBAItem>())
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 20;
              continue;
            }
            goto label_6;
          case 19:
            if (translatesBaChapter != null)
            {
              num1 = 18;
              continue;
            }
            goto label_22;
          case 20:
            num1 = 4;
            continue;
          case 21:
            goto label_46;
          case 22:
            if (bpmAppManifest != null)
            {
              num1 = 15;
              continue;
            }
            goto label_44;
          default:
            if (TranslatesImportExtension.RXQfUoE0clMXlOIsDdBk((object) configImportSettings) == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 2 : 1;
              continue;
            }
            goto case 10;
        }
        configImportSettings = importSettings as ConfigImportSettings;
        num1 = 11;
      }
label_26:
      return;
label_25:
      return;
label_16:
      return;
label_41:
      return;
label_45:
      return;
label_46:
      return;
label_22:
      return;
label_42:
      return;
label_6:
      return;
label_43:
      return;
label_3:
      return;
label_2:
      return;
label_44:;
    }

    public TranslatesImportExtension()
    {
      TranslatesImportExtension.FBVBQKEmFkBeuPc0NPwA();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object ylov2AE0swuD83XJddT4([In] object obj0) => (object) ((TestImportExtensionParameters) obj0).Manifest;

    internal static object RXQfUoE0clMXlOIsDdBk([In] object obj0) => (object) ((ConfigImportSettings) obj0).Manifest;

    internal static object fYLjjuE0z9affJ0tJt09([In] object obj0) => (object) ((ConfigImportSettings) obj0).FakeManifest;

    internal static bool yyrD2NE0LACPI4PFYxfV() => TranslatesImportExtension.iHhCnpE0YrWwkONhxHKD == null;

    internal static TranslatesImportExtension UxV6i6E0ULqJIaXAvjvk() => TranslatesImportExtension.iHhCnpE0YrWwkONhxHKD;

    internal static void FBVBQKEmFkBeuPc0NPwA() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
