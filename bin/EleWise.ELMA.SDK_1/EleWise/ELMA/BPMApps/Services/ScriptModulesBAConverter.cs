// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.BPMApps.Services.ScriptModulesBAConverter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Model.Scripts.BPMApps;
using EleWise.ELMA.Model.Scripts.Deploy.Export;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.BPMApps.Services
{
  [Component(Order = 800)]
  public class ScriptModulesBAConverter : IBPMAppItemsConverter
  {
    private static readonly Guid _exportUid;
    internal static ScriptModulesBAConverter GHoKt4feVRgRpReg8SFO;

    public void ToBPMAppManifest(ConfigExportSettings settings, BPMAppManifest bpmAppManifest)
    {
      int num1 = 13;
      while (true)
      {
        int num2 = num1;
        ScriptModulesBAChapter modulesBaChapter1;
        ScriptModuleExportSetting moduleExportSetting;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_9;
            case 1:
              goto label_25;
            case 2:
              object obj;
              if (settings.CustomSettings.TryGetValue(ScriptModuleExportConsts.ExportExtensionUid, out obj))
              {
                moduleExportSetting = obj as ScriptModuleExportSetting;
                num2 = 7;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 1 : 1;
              continue;
            case 3:
              if (modulesBaChapter1.Modules != null)
              {
                num2 = 11;
                continue;
              }
              goto label_3;
            case 4:
              ScriptModulesBAConverter.DHmoBtfekvAeCbFRitZm((object) bpmAppManifest, (object) modulesBaChapter1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 2 : 9;
              continue;
            case 5:
              ScriptModulesBAConverter.JEO1vOfeKxpky3ZHkRWh((object) bpmAppManifest, ScriptModulesBAConverter._exportUid, ScriptModulesBAConverter.oJgsmsfeqRGGT0pj9eSI((object) moduleExportSetting));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 8 : 4;
              continue;
            case 6:
              ScriptModulesBAChapter modulesBaChapter2 = modulesBaChapter1;
              List<ScriptModuleBAItem> scriptModuleBaItemList;
              if (!moduleExportSetting.ExportScriptModules || moduleExportSetting.ScriptModuleUids == null)
              {
                scriptModuleBaItemList = new List<ScriptModuleBAItem>();
              }
              else
              {
                List<Guid> scriptModuleUids = moduleExportSetting.ScriptModuleUids;
                // ISSUE: reference to a compiler-generated field
                Func<Guid, ScriptModuleBAItem> func = ScriptModulesBAConverter.\u003C\u003Ec.\u003C\u003E9__0_0;
                Func<Guid, ScriptModuleBAItem> selector;
                if (func == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  ScriptModulesBAConverter.\u003C\u003Ec.\u003C\u003E9__0_0 = selector = (Func<Guid, ScriptModuleBAItem>) (u =>
                  {
                    return new ScriptModuleBAItem()
                    {
                      Uid = u
                    };
                  });
                }
                else
                  goto label_30;
label_27:
                scriptModuleBaItemList = scriptModuleUids.Select<Guid, ScriptModuleBAItem>(selector).ToList<ScriptModuleBAItem>();
                goto label_28;
label_30:
                selector = func;
                goto label_27;
              }
label_28:
              modulesBaChapter2.Modules = scriptModuleBaItemList;
              num2 = 3;
              continue;
            case 7:
              if (moduleExportSetting != null)
              {
                num2 = 5;
                continue;
              }
              goto label_16;
            case 8:
              ScriptModulesBAChapter modulesBaChapter3 = new ScriptModulesBAChapter();
              ScriptModulesBAConverter.maCeDrfeXcR1QgYLASPn((object) modulesBaChapter3, ScriptModuleExportConsts.ExportExtensionUid);
              modulesBaChapter1 = modulesBaChapter3;
              num2 = 6;
              continue;
            case 9:
              goto label_14;
            case 10:
              goto label_29;
            case 11:
              if (ScriptModulesBAConverter.EGVbgNfeTPU8vtIdI02g((object) modulesBaChapter1.Modules) > 0)
                goto case 4;
              else
                goto label_8;
            case 12:
              ScriptModulesBAConverter.aC0hxHfeRaseLFpLU7uq((object) settings, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(694673736 ^ -23604109 ^ -672079947));
              num2 = 2;
              continue;
            case 13:
              ScriptModulesBAConverter.aC0hxHfeRaseLFpLU7uq((object) bpmAppManifest, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1052221104 - 768835541 ^ 283203145));
              num2 = 12;
              continue;
            default:
              goto label_11;
          }
        }
label_8:
        num1 = 10;
      }
label_9:
      return;
label_25:
      return;
label_14:
      return;
label_29:
      return;
label_11:
      return;
label_3:
      return;
label_16:;
    }

    public void ToExportSettings(BPMAppManifest bpmAppManifest, ConfigExportSettings settings)
    {
      int num = 7;
      ScriptModuleExportSetting moduleExportSetting1;
      ScriptModulesBAChapter chapter;
      while (true)
      {
        switch (num)
        {
          case 1:
            chapter = bpmAppManifest.GetChapter(ScriptModuleExportConsts.ExportExtensionUid) as ScriptModulesBAChapter;
            num = 3;
            continue;
          case 2:
          case 4:
            settings.CustomSettings[ScriptModuleExportConsts.ExportExtensionUid] = (object) moduleExportSetting1;
            num = 9;
            continue;
          case 3:
            if (chapter != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
              continue;
            }
            goto case 2;
          case 5:
            ScriptModuleExportSetting moduleExportSetting2 = moduleExportSetting1;
            List<ScriptModuleBAItem> modules = chapter.Modules;
            // ISSUE: reference to a compiler-generated field
            Func<ScriptModuleBAItem, Guid> func = ScriptModulesBAConverter.\u003C\u003Ec.\u003C\u003E9__1_0;
            Func<ScriptModuleBAItem, Guid> selector;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              ScriptModulesBAConverter.\u003C\u003Ec.\u003C\u003E9__1_0 = selector = (Func<ScriptModuleBAItem, Guid>) (f => ScriptModulesBAConverter.\u003C\u003Ec.HTE29CZF8JNZtmPgyYeG((object) f));
            }
            else
              goto label_2;
label_16:
            List<Guid> list = modules.Select<ScriptModuleBAItem, Guid>(selector).ToList<Guid>();
            moduleExportSetting2.ScriptModuleUids = list;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 2 : 2;
            continue;
label_2:
            selector = func;
            goto label_16;
          case 6:
            Contract.ArgumentNotNull((object) settings, (string) ScriptModulesBAConverter.Bd8sKEfen0TgtXyarCMk(-1837662597 ^ -1837656843));
            num = 8;
            continue;
          case 7:
            Contract.ArgumentNotNull((object) bpmAppManifest, (string) ScriptModulesBAConverter.Bd8sKEfen0TgtXyarCMk(-1839087379 - 334718690 ^ 2120946329));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 6 : 3;
            continue;
          case 8:
            moduleExportSetting1 = new ScriptModuleExportSetting();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 10 : 8;
            continue;
          case 9:
            goto label_14;
          case 10:
            ScriptModulesBAConverter.cOTQqqfe2TJOD7DQxkU8((object) moduleExportSetting1, ScriptModulesBAConverter.wRr5bsfeOedvJ4DfMqMY((object) bpmAppManifest, ScriptModulesBAConverter._exportUid, ScriptModulesBAConverter.oJgsmsfeqRGGT0pj9eSI((object) moduleExportSetting1)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 1;
            continue;
          default:
            if (chapter.Modules == null)
            {
              num = 4;
              continue;
            }
            goto case 5;
        }
      }
label_14:;
    }

    public ScriptModulesBAConverter()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static ScriptModulesBAConverter()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            ScriptModulesBAConverter.BY6ak6feepLdcYA2pL9R();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            ScriptModulesBAConverter._exportUid = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(901793403 ^ 902106169));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static void aC0hxHfeRaseLFpLU7uq([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static bool oJgsmsfeqRGGT0pj9eSI([In] object obj0) => ((ScriptModuleExportSetting) obj0).ExportScriptModules;

    internal static void JEO1vOfeKxpky3ZHkRWh([In] object obj0, Guid uid, bool value) => ((BPMAppManifest) obj0).SetFlag(uid, value);

    internal static void maCeDrfeXcR1QgYLASPn([In] object obj0, Guid value) => ((BPMAppManifestChapter) obj0).Uid = value;

    internal static int EGVbgNfeTPU8vtIdI02g([In] object obj0) => ((List<ScriptModuleBAItem>) obj0).Count;

    internal static void DHmoBtfekvAeCbFRitZm([In] object obj0, [In] object obj1) => ((BPMAppManifest) obj0).SetChapter((BPMAppManifestChapter) obj1);

    internal static bool LymB6KfeSGChUblocU1b() => ScriptModulesBAConverter.GHoKt4feVRgRpReg8SFO == null;

    internal static ScriptModulesBAConverter js9HG3feifqjd5onXIqW() => ScriptModulesBAConverter.GHoKt4feVRgRpReg8SFO;

    internal static object Bd8sKEfen0TgtXyarCMk(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool wRr5bsfeOedvJ4DfMqMY([In] object obj0, Guid uid, bool defaultValue) => ((BPMAppManifest) obj0).GetFlag(uid, defaultValue);

    internal static void cOTQqqfe2TJOD7DQxkU8([In] object obj0, bool value) => ((ScriptModuleExportSetting) obj0).ExportScriptModules = value;

    internal static void BY6ak6feepLdcYA2pL9R() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
