// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Manifest.BpmAppsManifestChapterCreator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.BPMApps.DTO.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy.Manifest
{
  /// <summary>Инфа по отчетам в манифесте</summary>
  [Component]
  public class BpmAppsManifestChapterCreator : IManifestChapterCreator
  {
    private static BpmAppsManifestChapterCreator so0fjJEaDYth6CmS9Ne8;

    public void Resolve(ConfigExportSettings settings, ExportedObjectsDescription desc)
    {
      int num1 = 6;
      Dictionary<string, ElmaStoreComponentManifest>.Enumerator enumerator1;
      while (true)
      {
        Dictionary<string, BPMAppDTO>.Enumerator enumerator2;
        object obj;
        switch (num1)
        {
          case 1:
            enumerator1 = appsExportSetting.Files.GetEnumerator();
            num1 = 8;
            continue;
          case 2:
label_20:
            if (appsExportSetting.Files == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 4 : 4;
              continue;
            }
            goto case 1;
          case 3:
            if (appsExportSetting.Components != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 9 : 9;
              continue;
            }
            goto case 2;
          case 4:
            goto label_17;
          case 5:
            if (!settings.CustomSettings.TryGetValue(BpmAppsExportConsts.ExportBpmAppsUid, out obj))
            {
              num1 = 10;
              continue;
            }
            break;
          case 6:
            if (BpmAppsManifestChapterCreator.QQPnl3Ea4JD5cLEGRoOa((object) settings) != null)
            {
              num1 = 5;
              continue;
            }
            goto label_38;
          case 7:
            goto label_27;
          case 8:
            goto label_2;
          case 9:
            enumerator2 = appsExportSetting.Components.GetEnumerator();
            num1 = 11;
            continue;
          case 10:
            goto label_24;
          case 11:
            try
            {
label_28:
              if (enumerator2.MoveNext())
                goto label_25;
              else
                goto label_29;
label_23:
              KeyValuePair<string, BPMAppDTO> current;
              BpmAppManifest bpmAppManifest1;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    ((ElmaStoreComponentManifest) BpmAppsManifestChapterCreator.QQPnl3Ea4JD5cLEGRoOa((object) settings)).BpmApps.Add(bpmAppManifest1);
                    num2 = 3;
                    continue;
                  case 2:
                    if (current.Value == null)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 0;
                      continue;
                    }
                    goto case 5;
                  case 4:
                    goto label_20;
                  case 5:
                    BpmAppManifest bpmAppManifest2 = new BpmAppManifest();
                    BpmAppsManifestChapterCreator.HBkqb2EaAccrxfewrTP1((object) bpmAppManifest2, BpmAppsManifestChapterCreator.Mat0AUEaHDdEuD1yFpiy(BpmAppsManifestChapterCreator.xiT1s8Ea6dPIsAQnxqTp((object) current.Value)));
                    BpmAppsManifestChapterCreator.wMV4NvEaxW5p7ITjwS5W((object) bpmAppManifest2, BpmAppsManifestChapterCreator.RCSsnGEa7O3Q4p4Uj3ay(BpmAppsManifestChapterCreator.xiT1s8Ea6dPIsAQnxqTp((object) current.Value)));
                    BpmAppsManifestChapterCreator.ADe71fEam7siZGNXXMUU((object) bpmAppManifest2, BpmAppsManifestChapterCreator.RB4EivEa0IZovYV6riF5(BpmAppsManifestChapterCreator.xiT1s8Ea6dPIsAQnxqTp((object) current.Value)));
                    BpmAppsManifestChapterCreator.mwoBlZEaJmL6BkKZa2je((object) bpmAppManifest2, !BpmAppsManifestChapterCreator.v6s6rvEaMDGtI2NLdREP(BpmAppsManifestChapterCreator.xtBqYVEaybeUQVdjQXIZ(BpmAppsManifestChapterCreator.xiT1s8Ea6dPIsAQnxqTp((object) current.Value))) ? BpmAppsManifestChapterCreator.xtBqYVEaybeUQVdjQXIZ(BpmAppsManifestChapterCreator.xiT1s8Ea6dPIsAQnxqTp((object) current.Value)) : BpmAppsManifestChapterCreator.Mat0AUEaHDdEuD1yFpiy(BpmAppsManifestChapterCreator.xiT1s8Ea6dPIsAQnxqTp((object) current.Value)));
                    bpmAppManifest2.Description = (string) BpmAppsManifestChapterCreator.JuJ5vdEa95NwuWgHHSPS(BpmAppsManifestChapterCreator.xiT1s8Ea6dPIsAQnxqTp((object) current.Value));
                    bpmAppManifest2.TagDataBase = (string) BpmAppsManifestChapterCreator.cV10Y7EadgKqSO8IDDZU(BpmAppsManifestChapterCreator.xiT1s8Ea6dPIsAQnxqTp((object) current.Value));
                    BpmAppsManifestChapterCreator.tyAOYqEaryjRN7LLYXCK((object) bpmAppManifest2, BpmAppsManifestChapterCreator.YScKn4EalTO9tkHUKqyJ(BpmAppsManifestChapterCreator.xiT1s8Ea6dPIsAQnxqTp((object) current.Value)));
                    BpmAppsManifestChapterCreator.r9C4mREagO8Hw13q31bZ((object) bpmAppManifest2, (object) current.Value.ComponentManifest.TagLanguage);
                    bpmAppManifest1 = bpmAppManifest2;
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 1 : 1;
                    continue;
                  case 6:
                    goto label_25;
                  default:
                    goto label_28;
                }
              }
label_25:
              current = enumerator2.Current;
              num2 = 2;
              goto label_23;
label_29:
              num2 = 4;
              goto label_23;
            }
            finally
            {
              enumerator2.Dispose();
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
                num3 = 0;
              switch (num3)
              {
                default:
              }
            }
          case 12:
            goto label_42;
        }
        if (obj is BpmAppsExportSetting appsExportSetting)
          num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 3;
        else
          goto label_34;
      }
label_17:
      return;
label_27:
      return;
label_24:
      return;
label_42:
      return;
label_2:
      try
      {
label_5:
        if (enumerator1.MoveNext())
          goto label_7;
        else
          goto label_6;
label_3:
        BpmAppManifest bpmAppManifest3;
        KeyValuePair<string, ElmaStoreComponentManifest> current;
        int num4;
        while (true)
        {
          switch (num4)
          {
            case 1:
              goto label_5;
            case 2:
              goto label_33;
            case 3:
              BpmAppManifest bpmAppManifest4 = new BpmAppManifest();
              BpmAppsManifestChapterCreator.HBkqb2EaAccrxfewrTP1((object) bpmAppManifest4, BpmAppsManifestChapterCreator.Mat0AUEaHDdEuD1yFpiy((object) current.Value));
              bpmAppManifest4.Author = (string) BpmAppsManifestChapterCreator.RCSsnGEa7O3Q4p4Uj3ay((object) current.Value);
              bpmAppManifest4.Version = (string) BpmAppsManifestChapterCreator.RB4EivEa0IZovYV6riF5((object) current.Value);
              BpmAppsManifestChapterCreator.mwoBlZEaJmL6BkKZa2je((object) bpmAppManifest4, !string.IsNullOrWhiteSpace((string) BpmAppsManifestChapterCreator.xtBqYVEaybeUQVdjQXIZ((object) current.Value)) ? BpmAppsManifestChapterCreator.xtBqYVEaybeUQVdjQXIZ((object) current.Value) : BpmAppsManifestChapterCreator.Mat0AUEaHDdEuD1yFpiy((object) current.Value));
              BpmAppsManifestChapterCreator.Pcdct6Ea5QwsZ2Y78RhW((object) bpmAppManifest4, BpmAppsManifestChapterCreator.JuJ5vdEa95NwuWgHHSPS((object) current.Value));
              bpmAppManifest4.TagDataBase = current.Value.TagDataBase;
              BpmAppsManifestChapterCreator.tyAOYqEaryjRN7LLYXCK((object) bpmAppManifest4, BpmAppsManifestChapterCreator.YScKn4EalTO9tkHUKqyJ((object) current.Value));
              BpmAppsManifestChapterCreator.r9C4mREagO8Hw13q31bZ((object) bpmAppManifest4, BpmAppsManifestChapterCreator.o61vSGEajnHL6od8Odi9((object) current.Value));
              bpmAppManifest3 = bpmAppManifest4;
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 4;
              continue;
            case 4:
              ((ElmaStoreComponentManifest) BpmAppsManifestChapterCreator.QQPnl3Ea4JD5cLEGRoOa((object) settings)).BpmApps.Add(bpmAppManifest3);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 1 : 1;
              continue;
            case 5:
              goto label_7;
            default:
              if (current.Value != null)
              {
                num4 = 3;
                continue;
              }
              goto label_5;
          }
        }
label_33:
        return;
label_6:
        num4 = 2;
        goto label_3;
label_7:
        current = enumerator1.Current;
        num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
        {
          num4 = 0;
          goto label_3;
        }
        else
          goto label_3;
      }
      finally
      {
        enumerator1.Dispose();
        int num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
          num5 = 0;
        switch (num5)
        {
          default:
        }
      }
label_34:
      return;
label_38:;
    }

    public BpmAppsManifestChapterCreator()
    {
      BpmAppsManifestChapterCreator.JsQl3NEaYepuDtUmpIfc();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object QQPnl3Ea4JD5cLEGRoOa([In] object obj0) => (object) ((ConfigExportSettings) obj0).Manifest;

    internal static object xiT1s8Ea6dPIsAQnxqTp([In] object obj0) => (object) ((BPMAppDTO) obj0).ComponentManifest;

    internal static object Mat0AUEaHDdEuD1yFpiy([In] object obj0) => (object) ((ElmaStoreComponentManifest) obj0).Id;

    internal static void HBkqb2EaAccrxfewrTP1([In] object obj0, [In] object obj1) => ((BpmAppManifest) obj0).Id = (string) obj1;

    internal static object RCSsnGEa7O3Q4p4Uj3ay([In] object obj0) => (object) ((ElmaStoreComponentManifest) obj0).Author;

    internal static void wMV4NvEaxW5p7ITjwS5W([In] object obj0, [In] object obj1) => ((BpmAppManifest) obj0).Author = (string) obj1;

    internal static object RB4EivEa0IZovYV6riF5([In] object obj0) => (object) ((ElmaStoreComponentManifest) obj0).Version;

    internal static void ADe71fEam7siZGNXXMUU([In] object obj0, [In] object obj1) => ((BpmAppManifest) obj0).Version = (string) obj1;

    internal static object xtBqYVEaybeUQVdjQXIZ([In] object obj0) => (object) ((ElmaStoreComponentManifest) obj0).Title;

    internal static bool v6s6rvEaMDGtI2NLdREP([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static void mwoBlZEaJmL6BkKZa2je([In] object obj0, [In] object obj1) => ((BpmAppManifest) obj0).Title = (string) obj1;

    internal static object JuJ5vdEa95NwuWgHHSPS([In] object obj0) => (object) ((ElmaStoreComponentManifest) obj0).Description;

    internal static object cV10Y7EadgKqSO8IDDZU([In] object obj0) => (object) ((ElmaStoreComponentManifest) obj0).TagDataBase;

    internal static object YScKn4EalTO9tkHUKqyJ([In] object obj0) => (object) ((ElmaStoreComponentManifest) obj0).TagEdition;

    internal static void tyAOYqEaryjRN7LLYXCK([In] object obj0, [In] object obj1) => ((BpmAppManifest) obj0).TagEdition = (string) obj1;

    internal static void r9C4mREagO8Hw13q31bZ([In] object obj0, [In] object obj1) => ((BpmAppManifest) obj0).TagLanguage = (string) obj1;

    internal static void Pcdct6Ea5QwsZ2Y78RhW([In] object obj0, [In] object obj1) => ((BpmAppManifest) obj0).Description = (string) obj1;

    internal static object o61vSGEajnHL6od8Odi9([In] object obj0) => (object) ((ElmaStoreComponentManifest) obj0).TagLanguage;

    internal static bool xc88qbEatc2MYml7FfR5() => BpmAppsManifestChapterCreator.so0fjJEaDYth6CmS9Ne8 == null;

    internal static BpmAppsManifestChapterCreator fRYutxEawoI179LyfKRS() => BpmAppsManifestChapterCreator.so0fjJEaDYth6CmS9Ne8;

    internal static void JsQl3NEaYepuDtUmpIfc() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
