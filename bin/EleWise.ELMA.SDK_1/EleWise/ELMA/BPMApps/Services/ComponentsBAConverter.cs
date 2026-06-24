// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.BPMApps.Services.ComponentsBAConverter
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
  /// Конвертации манифеста и настроек экспорта метаданных компонентов
  /// </summary>
  [Component(Order = 1050)]
  internal class ComponentsBAConverter : IBPMAppItemsConverter
  {
    internal static ComponentsBAConverter DwLCxBfOwLFRvyPuJXrd;

    /// <inheritdoc />
    public void ToBPMAppManifest(ConfigExportSettings settings, BPMAppManifest bpmAppManifest)
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        ComponentExportSetting componentExportSetting;
        ComponentBAChapter componentBaChapter1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              ComponentsBAConverter.GgLUWPfOA5mD71Duu5q3((object) bpmAppManifest, ComponentsBAConverter.BI5uvXfOH1ZE8ssNtGM5(-1255365154 ^ 596875508 ^ -1766165064));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_19;
            case 3:
              if (ComponentsBAConverter.pAo6MnfOxAOmmW95xPaJ((object) componentBaChapter1.Components) <= 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 11 : 7;
                continue;
              }
              goto label_19;
            case 4:
              if (componentExportSetting != null)
              {
                num2 = 7;
                continue;
              }
              goto label_8;
            case 5:
              ComponentBAChapter componentBaChapter2 = componentBaChapter1;
              List<Guid> componentsIds = componentExportSetting.ComponentsIds;
              // ISSUE: reference to a compiler-generated field
              Func<Guid, ComponentBAItem> func = ComponentsBAConverter.\u003C\u003Ec.\u003C\u003E9__0_0;
              Func<Guid, ComponentBAItem> selector;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                ComponentsBAConverter.\u003C\u003Ec.\u003C\u003E9__0_0 = selector = (Func<Guid, ComponentBAItem>) (uid =>
                {
                  return new ComponentBAItem() { Uid = uid };
                });
              }
              else
                goto label_27;
label_26:
              List<ComponentBAItem> list = componentsIds.Select<Guid, ComponentBAItem>(selector).ToList<ComponentBAItem>();
              componentBaChapter2.Components = list;
              num2 = 6;
              continue;
label_27:
              selector = func;
              goto label_26;
            case 6:
            case 10:
              goto label_11;
            case 7:
              ComponentBAChapter componentBaChapter3 = new ComponentBAChapter();
              ComponentsBAConverter.mK1W5cfO71adsHaP3JHR((object) componentBaChapter3, ComponentExportConsts.ExportExtensionUid);
              componentBaChapter1 = componentBaChapter3;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 8 : 0;
              continue;
            case 8:
              if (componentExportSetting.ComponentsIds == null)
              {
                num2 = 10;
                continue;
              }
              goto case 5;
            case 9:
              goto label_5;
            case 11:
              goto label_18;
            case 12:
              goto label_24;
            case 13:
              object obj;
              if (!settings.CustomSettings.TryGetValue(ComponentExportConsts.ExportExtensionUid, out obj))
              {
                num2 = 12;
                continue;
              }
              componentExportSetting = obj as ComponentExportSetting;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 1 : 4;
              continue;
            case 14:
              goto label_7;
            default:
              Contract.ArgumentNotNull((object) settings, (string) ComponentsBAConverter.BI5uvXfOH1ZE8ssNtGM5(979449278 ^ 979492656));
              num2 = 13;
              continue;
          }
        }
label_11:
        if (componentBaChapter1.Components != null)
        {
          num1 = 3;
          continue;
        }
        goto label_20;
label_19:
        ComponentsBAConverter.FYNVpRfO0A0WuxVeYZIS((object) bpmAppManifest, (object) componentBaChapter1);
        num1 = 9;
      }
label_5:
      return;
label_18:
      return;
label_24:
      return;
label_7:
      return;
label_20:
      return;
label_8:;
    }

    /// <inheritdoc />
    public void ToExportSettings(BPMAppManifest bpmAppManifest, ConfigExportSettings settings)
    {
      int num1 = 6;
      ComponentBAChapter componentBaChapter;
      List<ComponentBAItem>.Enumerator enumerator;
      ComponentExportSetting componentExportSetting;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            if (componentBaChapter != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 0;
              continue;
            }
            goto label_12;
          case 3:
            try
            {
label_9:
              if (enumerator.MoveNext())
                goto label_7;
              else
                goto label_10;
label_6:
              ComponentBAItem current;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_19;
                  case 2:
                    goto label_7;
                  case 3:
                    goto label_9;
                  default:
                    componentExportSetting.ComponentsIds.Add(ComponentsBAConverter.H4QWBrfOyh9b14yIwuAN((object) current));
                    num2 = 3;
                    continue;
                }
              }
label_7:
              current = enumerator.Current;
              num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
              {
                num2 = 0;
                goto label_6;
              }
              else
                goto label_6;
label_10:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 1 : 1;
              goto label_6;
            }
            finally
            {
              enumerator.Dispose();
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
                num3 = 0;
              switch (num3)
              {
                default:
              }
            }
          case 4:
            componentExportSetting.ComponentsIds = new List<Guid>();
            num1 = 7;
            continue;
          case 5:
            ComponentsBAConverter.GgLUWPfOA5mD71Duu5q3((object) settings, ComponentsBAConverter.BI5uvXfOH1ZE8ssNtGM5(1052221104 - 768835541 ^ 283440213));
            num1 = 8;
            continue;
          case 6:
            ComponentsBAConverter.GgLUWPfOA5mD71Duu5q3((object) bpmAppManifest, ComponentsBAConverter.BI5uvXfOH1ZE8ssNtGM5(1033719030 - 2012070891 ^ -978665063));
            num1 = 5;
            continue;
          case 7:
            enumerator = componentBaChapter.Components.GetEnumerator();
            num1 = 3;
            continue;
          case 8:
            componentBaChapter = ComponentsBAConverter.LtNjbUfOmEW8FiJ2uSZw((object) bpmAppManifest, ComponentExportConsts.ExportExtensionUid) as ComponentBAChapter;
            num1 = 2;
            continue;
          case 9:
label_19:
            settings.CustomSettings[ComponentExportConsts.ExportExtensionUid] = (object) componentExportSetting;
            num1 = 11;
            continue;
          case 10:
            if (componentBaChapter.Components != null)
            {
              num1 = 4;
              continue;
            }
            goto case 9;
          case 11:
            goto label_16;
          default:
            componentExportSetting = new ComponentExportSetting();
            num1 = 10;
            continue;
        }
      }
label_2:
      return;
label_16:
      return;
label_12:;
    }

    public ComponentsBAConverter()
    {
      ComponentsBAConverter.XHgxDufOM3nMGcEUrrhE();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object BI5uvXfOH1ZE8ssNtGM5(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void GgLUWPfOA5mD71Duu5q3([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static void mK1W5cfO71adsHaP3JHR([In] object obj0, Guid value) => ((BPMAppManifestChapter) obj0).Uid = value;

    internal static int pAo6MnfOxAOmmW95xPaJ([In] object obj0) => ((List<ComponentBAItem>) obj0).Count;

    internal static void FYNVpRfO0A0WuxVeYZIS([In] object obj0, [In] object obj1) => ((BPMAppManifest) obj0).SetChapter((BPMAppManifestChapter) obj1);

    internal static bool hf0BkjfO4lNjMPPiwJ1Q() => ComponentsBAConverter.DwLCxBfOwLFRvyPuJXrd == null;

    internal static ComponentsBAConverter QQyNxAfO6ZvnGPrVMVFu() => ComponentsBAConverter.DwLCxBfOwLFRvyPuJXrd;

    internal static object LtNjbUfOmEW8FiJ2uSZw([In] object obj0, Guid uid) => (object) ((BPMAppManifest) obj0).GetChapter(uid);

    internal static Guid H4QWBrfOyh9b14yIwuAN([In] object obj0) => ((BPMAppManifestItem) obj0).Uid;

    internal static void XHgxDufOM3nMGcEUrrhE() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
