// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.BPMApps.Services.BpmAppsBAConverter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.BPMApps.DTO.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.BPMApps.Services
{
  /// <summary>Конвертер манифеста для приложений</summary>
  [Component(Order = 100)]
  public class BpmAppsBAConverter : IBPMAppItemsConverter
  {
    private static readonly Guid _exportBpmAppsUid;
    private readonly ILazy<IBpmAppService> bpmAppService;
    private static BpmAppsBAConverter dlNGdcf2biKn2shqI6U3;

    /// <summary>Ctor</summary>
    /// <param name="bpmAppService">Сервис управления BpmApp</param>
    public BpmAppsBAConverter(ILazy<IBpmAppService> bpmAppService)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.bpmAppService = bpmAppService;
    }

    /// <inheritdoc />
    public void ToBPMAppManifest(ConfigExportSettings settings, BPMAppManifest bpmAppManifest)
    {
      int num = 9;
      while (true)
      {
        BpmAppsExportSetting appsExportSetting;
        BpmAppsBAChapter chapter;
        switch (num)
        {
          case 1:
            if (appsExportSetting.Files == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 13 : 4;
              continue;
            }
            goto case 15;
          case 2:
            BpmAppsBAConverter.dp1RpKf2fb6E0xwWZpM7((object) settings, BpmAppsBAConverter.JD0FcZf2E0csf15CHk5t(1642859704 ^ 1642915382));
            num = 18;
            continue;
          case 3:
            if (appsExportSetting.Components != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 2 : 6;
              continue;
            }
            goto case 1;
          case 4:
            BpmAppsBAConverter.zjG0aff2C7Q1B2vJJK09((object) bpmAppManifest, BpmAppsBAConverter._exportBpmAppsUid, true);
            num = 3;
            continue;
          case 5:
            BpmAppsBAChapter bpmAppsBaChapter = new BpmAppsBAChapter();
            BpmAppsBAConverter.UEn3ZKf2QLDnrFY5phnY((object) bpmAppsBaChapter, BpmAppsExportConsts.ExportBpmAppsUid);
            bpmAppsBaChapter.Components = new List<BpmAppBAItem>();
            chapter = bpmAppsBaChapter;
            num = 4;
            continue;
          case 6:
            appsExportSetting.Components.ForEach<KeyValuePair<string, BPMAppDTO>>((Action<KeyValuePair<string, BPMAppDTO>>) (c =>
            {
              string str = !string.IsNullOrWhiteSpace(c.Value.ComponentManifest.Title) ? c.Value.ComponentManifest.Title : c.Value.ComponentManifest.Id;
              if (!string.IsNullOrWhiteSpace(c.Value.ComponentManifest.Version))
                str = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1149433385 + 173655049 ^ 1323223302), (object) str, (object) c.Value.ComponentManifest.Version);
              List<BpmAppBAItem> components = chapter.Components;
              components.Add(new BpmAppBAItem()
              {
                BpmAppId = c.Value.ComponentManifest.Id,
                BpmAppTitle = str,
                Uid = c.Value.Uid
              });
            }));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 1;
            continue;
          case 7:
            goto label_26;
          case 8:
            BpmAppsBAConverter.dp1RpKf2fb6E0xwWZpM7((object) bpmAppManifest, BpmAppsBAConverter.JD0FcZf2E0csf15CHk5t(-2138958856 ^ -2138612886));
            num = 2;
            continue;
          case 9:
            num = 8;
            continue;
          case 10:
          case 13:
            if (chapter.Components != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 16 : 6;
              continue;
            }
            goto label_13;
          case 11:
            if (appsExportSetting != null)
            {
              num = 5;
              continue;
            }
            goto label_19;
          case 12:
            goto label_15;
          case 14:
            goto label_2;
          case 15:
            appsExportSetting.Files.ForEach<KeyValuePair<string, ElmaStoreComponentManifest>>((Action<KeyValuePair<string, ElmaStoreComponentManifest>>) (c =>
            {
              string str = !string.IsNullOrWhiteSpace(c.Value.Title) ? c.Value.Title : c.Value.Id;
              if (!string.IsNullOrWhiteSpace(c.Value.Version))
                str = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(825385222 ^ 825233970), (object) str, (object) c.Value.Version);
              chapter.Components.Add(new BpmAppBAItem()
              {
                BpmAppId = c.Value.Id,
                BpmAppTitle = str
              });
            }));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 4 : 10;
            continue;
          case 16:
            if (chapter.Components.Count <= 0)
            {
              num = 12;
              continue;
            }
            break;
          case 17:
            goto label_7;
          case 18:
            object obj;
            if (!settings.CustomSettings.TryGetValue(BpmAppsExportConsts.ExportBpmAppsUid, out obj))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 17 : 12;
              continue;
            }
            appsExportSetting = obj as BpmAppsExportSetting;
            num = 11;
            continue;
        }
        BpmAppsBAConverter.cxpaMYf2v552NtlJuStG((object) bpmAppManifest, (object) chapter);
        num = 14;
      }
label_26:
      return;
label_15:
      return;
label_2:
      return;
label_7:
      return;
label_19:
      return;
label_13:;
    }

    /// <inheritdoc />
    public void ToExportSettings(BPMAppManifest bpmAppManifest, ConfigExportSettings settings)
    {
      int num1 = 11;
      while (true)
      {
        int num2 = num1;
        BpmAppsBAChapter bpmAppsBaChapter;
        List<BpmAppBAItem>.Enumerator enumerator;
        List<BPMAppDTO> list;
        BpmAppsExportSetting appsExportSetting;
        while (true)
        {
          switch (num2)
          {
            case 1:
              try
              {
label_9:
                if (enumerator.MoveNext())
                  goto label_7;
                else
                  goto label_10;
label_6:
                BPMAppDTO bpmAppDto;
                int num3;
                BpmAppBAItem component;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      bpmAppDto = list.FirstOrDefault<BPMAppDTO>((Func<BPMAppDTO, bool>) (app => BpmAppsBAConverter.\u003C\u003Ec__DisplayClass4_0.V3wl7u8z0193y3oy3JfV(BpmAppsBAConverter.\u003C\u003Ec__DisplayClass4_0.bInpIp8zxBGLNWX7Olnt((object) app.ComponentManifest), (object) component.BpmAppId)));
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 1 : 5;
                      continue;
                    case 2:
                    case 3:
                      goto label_9;
                    case 4:
                      goto label_29;
                    case 5:
                      if (bpmAppDto == null)
                      {
                        num3 = 3;
                        continue;
                      }
                      goto case 7;
                    case 6:
                      component = enumerator.Current;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 1 : 1;
                      continue;
                    case 7:
                      appsExportSetting.Components.Add((string) BpmAppsBAConverter.JDP9qjf2Zqb5nldCG4iS((object) component), bpmAppDto);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 2 : 2;
                      continue;
                    default:
                      goto label_7;
                  }
                }
label_7:
                num3 = 6;
                goto label_6;
label_10:
                num3 = 4;
                goto label_6;
              }
              finally
              {
                enumerator.Dispose();
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                }
              }
            case 2:
              enumerator = bpmAppsBaChapter.Components.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 1;
              continue;
            case 3:
              if (bpmAppsBaChapter != null)
              {
                appsExportSetting = new BpmAppsExportSetting();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
                continue;
              }
              num2 = 9;
              continue;
            case 4:
              goto label_4;
            case 5:
              goto label_18;
            case 6:
            case 8:
label_29:
              settings.CustomSettings[BpmAppsExportConsts.ExportBpmAppsUid] = (object) appsExportSetting;
              num2 = 5;
              continue;
            case 7:
              bpmAppsBaChapter = BpmAppsBAConverter.HwVNKgf28CiQBlIrgBJi((object) bpmAppManifest, BpmAppsExportConsts.ExportBpmAppsUid) as BpmAppsBAChapter;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 3 : 3;
              continue;
            case 9:
              goto label_20;
            case 10:
              Contract.ArgumentNotNull((object) settings, (string) BpmAppsBAConverter.JD0FcZf2E0csf15CHk5t(44884861 ^ 44829171));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 7 : 1;
              continue;
            case 11:
              BpmAppsBAConverter.dp1RpKf2fb6E0xwWZpM7((object) bpmAppManifest, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(589593376 ^ -1977315327 ^ -1459248205));
              num2 = 10;
              continue;
            default:
              goto label_23;
          }
        }
label_4:
        list = this.bpmAppService.Value.LoadAll().ToList<BPMAppDTO>();
        num1 = 2;
        continue;
label_23:
        if (bpmAppsBaChapter.Components == null)
          num1 = 6;
        else
          goto label_4;
      }
label_18:
      return;
label_20:;
    }

    static BpmAppsBAConverter()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            BpmAppsBAConverter._exportBpmAppsUid = new Guid((string) BpmAppsBAConverter.JD0FcZf2E0csf15CHk5t(1304605005 ^ 1304951295));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 0;
            continue;
          case 2:
            BpmAppsBAConverter.Iedv3ef2ueH6F82YGefp();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static object JD0FcZf2E0csf15CHk5t(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void dp1RpKf2fb6E0xwWZpM7([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static void UEn3ZKf2QLDnrFY5phnY([In] object obj0, Guid value) => ((BPMAppManifestChapter) obj0).Uid = value;

    internal static void zjG0aff2C7Q1B2vJJK09([In] object obj0, Guid uid, bool value) => ((BPMAppManifest) obj0).SetFlag(uid, value);

    internal static void cxpaMYf2v552NtlJuStG([In] object obj0, [In] object obj1) => ((BPMAppManifest) obj0).SetChapter((BPMAppManifestChapter) obj1);

    internal static bool WyKu31f2hWhtf4frgdXC() => BpmAppsBAConverter.dlNGdcf2biKn2shqI6U3 == null;

    internal static BpmAppsBAConverter TWGaDlf2Gc0DtgcnpeaC() => BpmAppsBAConverter.dlNGdcf2biKn2shqI6U3;

    internal static object HwVNKgf28CiQBlIrgBJi([In] object obj0, Guid uid) => (object) ((BPMAppManifest) obj0).GetChapter(uid);

    internal static object JDP9qjf2Zqb5nldCG4iS([In] object obj0) => (object) ((BpmAppBAItem) obj0).BpmAppId;

    internal static void Iedv3ef2ueH6F82YGefp() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
