// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.BPMApps.Services.UIFormsBAConverter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.UI.BPMApps;
using EleWise.ELMA.UI.Deploy.Export;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.BPMApps.Services
{
  [Component(Order = 520)]
  public class UIFormsBAConverter : IBPMAppItemsConverter
  {
    private static readonly Guid _exportUid;
    private static UIFormsBAConverter mGwFAxfexs3Ew698FvDF;

    public void ToBPMAppManifest(ConfigExportSettings settings, BPMAppManifest bpmAppManifest)
    {
      int num1 = 7;
      while (true)
      {
        int num2 = num1;
        UIFormsBAChapter chapter;
        object obj;
        UIFormExportSetting formExportSetting;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_10;
            case 1:
              goto label_21;
            case 2:
              if (formExportSetting != null)
              {
                UIFormsBAConverter.gagu3Vfe9vSsit8Vg9RJ((object) bpmAppManifest, UIFormsBAConverter._exportUid, UIFormsBAConverter.XV4bMyfeJAk2ekevA8Gn((object) formExportSetting));
                num2 = 5;
                continue;
              }
              num2 = 8;
              continue;
            case 3:
              if (UIFormsBAConverter.M15uSEfelykU0ZxfMntT((object) chapter.Forms) <= 0)
              {
                num2 = 10;
                continue;
              }
              goto case 9;
            case 4:
              goto label_22;
            case 5:
              UIFormsBAChapter uiFormsBaChapter1 = new UIFormsBAChapter();
              UIFormsBAConverter.f5xq1yfedklM0o3C7JSr((object) uiFormsBaChapter1, UIFormExportConsts.ExportExtensionUid);
              chapter = uiFormsBaChapter1;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 1 : 0;
              continue;
            case 6:
              UIFormsBAConverter.ieBpQufeywndIc7yY3g4((object) settings, UIFormsBAConverter.I4h2QDfeMnNLLAdY0JaP(2008901894 << 3 ^ -1108630850));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 11 : 3;
              continue;
            case 7:
              UIFormsBAConverter.ieBpQufeywndIc7yY3g4((object) bpmAppManifest, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(901793403 ^ 902106857));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 6;
              continue;
            case 8:
              goto label_25;
            case 9:
              bpmAppManifest.SetChapter((BPMAppManifestChapter) chapter);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
              continue;
            case 10:
              goto label_15;
            case 11:
              if (!settings.CustomSettings.TryGetValue(UIFormExportConsts.ExportExtensionUid, out obj))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 12 : 8;
                continue;
              }
              goto label_11;
            case 12:
              goto label_8;
            case 13:
              if (chapter.Forms != null)
                goto case 3;
              else
                goto label_13;
            default:
              goto label_3;
          }
        }
label_11:
        formExportSetting = obj as UIFormExportSetting;
        num1 = 2;
        continue;
label_13:
        num1 = 4;
        continue;
label_21:
        UIFormsBAChapter uiFormsBaChapter2 = chapter;
        List<UIFormBAItem> uiFormBaItemList;
        if (!UIFormsBAConverter.XV4bMyfeJAk2ekevA8Gn((object) formExportSetting) || formExportSetting.FormHeaderUids == null)
        {
          uiFormBaItemList = new List<UIFormBAItem>();
        }
        else
        {
          List<Guid> formHeaderUids = formExportSetting.FormHeaderUids;
          // ISSUE: reference to a compiler-generated field
          Func<Guid, UIFormBAItem> func = UIFormsBAConverter.\u003C\u003Ec.\u003C\u003E9__0_0;
          Func<Guid, UIFormBAItem> selector;
          if (func == null)
          {
            // ISSUE: reference to a compiler-generated field
            UIFormsBAConverter.\u003C\u003Ec.\u003C\u003E9__0_0 = selector = (Func<Guid, UIFormBAItem>) (u =>
            {
              return new UIFormBAItem() { Uid = u };
            });
          }
          else
            goto label_29;
label_27:
          uiFormBaItemList = formHeaderUids.Select<Guid, UIFormBAItem>(selector).ToList<UIFormBAItem>();
          goto label_28;
label_29:
          selector = func;
          goto label_27;
        }
label_28:
        uiFormsBaChapter2.Forms = uiFormBaItemList;
        num1 = 13;
      }
label_10:
      return;
label_22:
      return;
label_25:
      return;
label_15:
      return;
label_8:
      return;
label_3:;
    }

    public void ToExportSettings(BPMAppManifest bpmAppManifest, ConfigExportSettings settings)
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        UIFormsBAChapter uiFormsBaChapter;
        UIFormExportSetting formExportSetting;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (uiFormsBaChapter.Forms != null)
              {
                num2 = 10;
                continue;
              }
              goto label_11;
            case 2:
              UIFormsBAConverter.ieBpQufeywndIc7yY3g4((object) settings, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606610542));
              num2 = 4;
              continue;
            case 3:
              UIFormsBAConverter.ieBpQufeywndIc7yY3g4((object) bpmAppManifest, UIFormsBAConverter.I4h2QDfeMnNLLAdY0JaP(-649342099 - -1150814748 ^ 501650715));
              num2 = 2;
              continue;
            case 4:
              formExportSetting = new UIFormExportSetting();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 1 : 8;
              continue;
            case 5:
              if (uiFormsBaChapter == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
                continue;
              }
              goto case 1;
            case 7:
              uiFormsBaChapter = UIFormsBAConverter.PVKQ6ife5E2RRt5NcoAG((object) bpmAppManifest, UIFormExportConsts.ExportExtensionUid) as UIFormsBAChapter;
              num2 = 5;
              continue;
            case 8:
              UIFormsBAConverter.DkVrkhfegZ37cZNthu8l((object) formExportSetting, UIFormsBAConverter.ziAZiFferdos0AgaFAQB((object) bpmAppManifest, UIFormsBAConverter._exportUid, formExportSetting.ExportForms));
              num2 = 7;
              continue;
            case 9:
              goto label_3;
            case 10:
              formExportSetting.FormHeaderUids = uiFormsBaChapter.Forms.Select<UIFormBAItem, Guid>((Func<UIFormBAItem, Guid>) (f => f.Uid)).ToList<Guid>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 6 : 6;
              continue;
            default:
              goto label_11;
          }
        }
label_11:
        settings.CustomSettings[UIFormExportConsts.ExportExtensionUid] = (object) formExportSetting;
        num1 = 9;
      }
label_3:;
    }

    public UIFormsBAConverter()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static UIFormsBAConverter()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            UIFormsBAConverter._exportUid = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822577414));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 2 : 1;
            continue;
        }
      }
label_2:;
    }

    internal static void ieBpQufeywndIc7yY3g4([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object I4h2QDfeMnNLLAdY0JaP(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool XV4bMyfeJAk2ekevA8Gn([In] object obj0) => ((UIFormExportSetting) obj0).ExportForms;

    internal static void gagu3Vfe9vSsit8Vg9RJ([In] object obj0, Guid uid, bool value) => ((BPMAppManifest) obj0).SetFlag(uid, value);

    internal static void f5xq1yfedklM0o3C7JSr([In] object obj0, Guid value) => ((BPMAppManifestChapter) obj0).Uid = value;

    internal static int M15uSEfelykU0ZxfMntT([In] object obj0) => ((List<UIFormBAItem>) obj0).Count;

    internal static bool mhOt9Xfe0g05fTqjIqHT() => UIFormsBAConverter.mGwFAxfexs3Ew698FvDF == null;

    internal static UIFormsBAConverter HB6bHRfem4T42VR5Yvbs() => UIFormsBAConverter.mGwFAxfexs3Ew698FvDF;

    internal static bool ziAZiFferdos0AgaFAQB([In] object obj0, Guid uid, bool defaultValue) => ((BPMAppManifest) obj0).GetFlag(uid, defaultValue);

    internal static void DkVrkhfegZ37cZNthu8l([In] object obj0, bool value) => ((UIFormExportSetting) obj0).ExportForms = value;

    internal static object PVKQ6ife5E2RRt5NcoAG([In] object obj0, Guid uid) => (object) ((BPMAppManifest) obj0).GetChapter(uid);
  }
}
