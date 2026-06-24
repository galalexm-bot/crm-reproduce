// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.BPMApps.Services.RazorViewsBAConverter
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
  [Component(Order = 570)]
  public class RazorViewsBAConverter : IBPMAppItemsConverter
  {
    private static readonly Guid _exportUid;
    internal static RazorViewsBAConverter FBFORYfeoHeSDmuTl5bT;

    public void ToBPMAppManifest(ConfigExportSettings settings, BPMAppManifest bpmAppManifest)
    {
      int num = 4;
      RazorViewsExportSetting viewsExportSetting;
      RazorViewsBAChapter razorViewsBaChapter1;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (viewsExportSetting == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 2 : 8;
              continue;
            }
            RazorViewsBAConverter.QRXJRsfefLYjYnOB3ZDs((object) bpmAppManifest, RazorViewsBAConverter._exportUid, RazorViewsBAConverter.VFgBxHfeENf1NX0Y5A3q((object) viewsExportSetting));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 8 : 10;
            continue;
          case 3:
            Contract.ArgumentNotNull((object) settings, (string) RazorViewsBAConverter.cMjsXhfeGuviH5e8Jg3n(--1418440330 ^ 1418413060));
            num = 5;
            continue;
          case 4:
            Contract.ArgumentNotNull((object) bpmAppManifest, (string) RazorViewsBAConverter.cMjsXhfeGuviH5e8Jg3n(694673736 ^ -23604109 ^ -671777367));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 3 : 2;
            continue;
          case 5:
            object obj;
            if (settings.CustomSettings.TryGetValue(RazorViewsExportConsts.ExportExtensionUid, out obj))
            {
              viewsExportSetting = obj as RazorViewsExportSetting;
              num = 2;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 1 : 1;
            continue;
          case 6:
            if (RazorViewsBAConverter.wPwW3hfeCYPoY5y2c5IP((object) razorViewsBaChapter1.ViewVirtualPaths) > 0)
            {
              num = 11;
              continue;
            }
            goto label_20;
          case 7:
            goto label_9;
          case 8:
            goto label_23;
          case 9:
            RazorViewsBAChapter razorViewsBaChapter2 = razorViewsBaChapter1;
            List<RazorViewBAItem> razorViewBaItemList;
            if (!RazorViewsBAConverter.VFgBxHfeENf1NX0Y5A3q((object) viewsExportSetting) || viewsExportSetting.ViewVirtualPaths == null)
            {
              razorViewBaItemList = new List<RazorViewBAItem>();
            }
            else
            {
              List<string> viewVirtualPaths = viewsExportSetting.ViewVirtualPaths;
              // ISSUE: reference to a compiler-generated field
              Func<string, RazorViewBAItem> func = RazorViewsBAConverter.\u003C\u003Ec.\u003C\u003E9__0_0;
              Func<string, RazorViewBAItem> selector;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                RazorViewsBAConverter.\u003C\u003Ec.\u003C\u003E9__0_0 = selector = (Func<string, RazorViewBAItem>) (p =>
                {
                  RazorViewBAItem bpmAppManifest1 = new RazorViewBAItem();
                  // ISSUE: reference to a compiler-generated method
                  RazorViewsBAConverter.\u003C\u003Ec.Xa9WfdZFGAoHCJy8W561((object) bpmAppManifest1, (object) p);
                  return bpmAppManifest1;
                });
              }
              else
                goto label_27;
label_25:
              razorViewBaItemList = viewVirtualPaths.Select<string, RazorViewBAItem>(selector).ToList<RazorViewBAItem>();
              goto label_26;
label_27:
              selector = func;
              goto label_25;
            }
label_26:
            razorViewsBaChapter2.ViewVirtualPaths = razorViewBaItemList;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
            continue;
          case 10:
            RazorViewsBAChapter razorViewsBaChapter3 = new RazorViewsBAChapter();
            RazorViewsBAConverter.JgKoKufeQDpGGrwLE235((object) razorViewsBaChapter3, RazorViewsExportConsts.ExportExtensionUid);
            razorViewsBaChapter1 = razorViewsBaChapter3;
            num = 9;
            continue;
          case 11:
            RazorViewsBAConverter.HqBFCefevTDODIkNWRfn((object) bpmAppManifest, (object) razorViewsBaChapter1);
            num = 7;
            continue;
          default:
            if (razorViewsBaChapter1.ViewVirtualPaths != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 6 : 1;
              continue;
            }
            goto label_2;
        }
      }
label_5:
      return;
label_9:
      return;
label_23:
      return;
label_20:
      return;
label_2:;
    }

    public void ToExportSettings(BPMAppManifest bpmAppManifest, ConfigExportSettings settings)
    {
      int num1 = 9;
      while (true)
      {
        int num2 = num1;
        RazorViewsBAChapter razorViewsBaChapter;
        RazorViewsExportSetting viewsExportSetting1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (razorViewsBaChapter == null)
              {
                num2 = 6;
                continue;
              }
              goto case 11;
            case 2:
              razorViewsBaChapter = RazorViewsBAConverter.tevhGlfeuXEmWuetAypw((object) bpmAppManifest, RazorViewsExportConsts.ExportExtensionUid) as RazorViewsBAChapter;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 1 : 1;
              continue;
            case 3:
              RazorViewsExportSetting viewsExportSetting2 = viewsExportSetting1;
              List<RazorViewBAItem> viewVirtualPaths = razorViewsBaChapter.ViewVirtualPaths;
              // ISSUE: reference to a compiler-generated field
              Func<RazorViewBAItem, string> func = RazorViewsBAConverter.\u003C\u003Ec.\u003C\u003E9__1_0;
              Func<RazorViewBAItem, string> selector;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                RazorViewsBAConverter.\u003C\u003Ec.\u003C\u003E9__1_0 = selector = (Func<RazorViewBAItem, string>) (i => (string) RazorViewsBAConverter.\u003C\u003Ec.fxZAX5ZFEAr5DCmXfJoK((object) i));
              }
              else
                goto label_3;
label_17:
              List<string> list = viewVirtualPaths.Select<RazorViewBAItem, string>(selector).ToList<string>();
              viewsExportSetting2.ViewVirtualPaths = list;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
              continue;
label_3:
              selector = func;
              goto label_17;
            case 4:
              goto label_13;
            case 5:
              goto label_15;
            case 8:
              RazorViewsBAConverter.Uqa8OWfe8O2cFgI97eKI((object) settings, RazorViewsBAConverter.cMjsXhfeGuviH5e8Jg3n(-1710575414 ^ -1710597564));
              num2 = 10;
              continue;
            case 9:
              RazorViewsBAConverter.Uqa8OWfe8O2cFgI97eKI((object) bpmAppManifest, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487075084));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 4 : 8;
              continue;
            case 10:
              viewsExportSetting1 = new RazorViewsExportSetting();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 4 : 2;
              continue;
            case 11:
              if (razorViewsBaChapter.ViewVirtualPaths == null)
              {
                num2 = 7;
                continue;
              }
              goto case 3;
            default:
              settings.CustomSettings[RazorViewsExportConsts.ExportExtensionUid] = (object) viewsExportSetting1;
              num2 = 5;
              continue;
          }
        }
label_13:
        RazorViewsBAConverter.ADJ0nTfeZNkJ34JIsTub((object) viewsExportSetting1, bpmAppManifest.GetFlag(RazorViewsBAConverter._exportUid, viewsExportSetting1.ExportViews));
        num1 = 2;
      }
label_15:;
    }

    public RazorViewsBAConverter()
    {
      RazorViewsBAConverter.nRLGAffeIAKRIKhnHrpC();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static RazorViewsBAConverter()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            RazorViewsBAConverter._exportUid = new Guid((string) RazorViewsBAConverter.cMjsXhfeGuviH5e8Jg3n(-1886646897 ^ -1886829443));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 1 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static object cMjsXhfeGuviH5e8Jg3n(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool VFgBxHfeENf1NX0Y5A3q([In] object obj0) => ((RazorViewsExportSetting) obj0).ExportViews;

    internal static void QRXJRsfefLYjYnOB3ZDs([In] object obj0, Guid uid, bool value) => ((BPMAppManifest) obj0).SetFlag(uid, value);

    internal static void JgKoKufeQDpGGrwLE235([In] object obj0, Guid value) => ((BPMAppManifestChapter) obj0).Uid = value;

    internal static int wPwW3hfeCYPoY5y2c5IP([In] object obj0) => ((List<RazorViewBAItem>) obj0).Count;

    internal static void HqBFCefevTDODIkNWRfn([In] object obj0, [In] object obj1) => ((BPMAppManifest) obj0).SetChapter((BPMAppManifestChapter) obj1);

    internal static bool tNdAwgfebt3OK5sr7Jpc() => RazorViewsBAConverter.FBFORYfeoHeSDmuTl5bT == null;

    internal static RazorViewsBAConverter BtLGJqfehxoKsKsay58R() => RazorViewsBAConverter.FBFORYfeoHeSDmuTl5bT;

    internal static void Uqa8OWfe8O2cFgI97eKI([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static void ADJ0nTfeZNkJ34JIsTub([In] object obj0, bool value) => ((RazorViewsExportSetting) obj0).ExportViews = value;

    internal static object tevhGlfeuXEmWuetAypw([In] object obj0, Guid uid) => (object) ((BPMAppManifest) obj0).GetChapter(uid);

    internal static void nRLGAffeIAKRIKhnHrpC() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
