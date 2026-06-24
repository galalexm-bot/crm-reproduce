// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Components.SystemComponentContainerEvents
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Components
{
  /// <summary>Создание системных компонентов</summary>
  [Component(Type = ComponentType.Server, Order = 2147483647)]
  internal sealed class SystemComponentContainerEvents : IModuleContainerEvents
  {
    internal static SystemComponentContainerEvents fJfXqofGuKy52pyQsS9H;

    /// <inheritdoc />
    public void Activated()
    {
      int num1 = 2;
      ComponentMetadataItemManager instance1;
      ComponentMetadataItemHeaderManager instance2;
      IEnumerator<ISystemComponentCreator> enumerator;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_21;
            case 1:
              instance2 = ComponentMetadataItemHeaderManager.Instance;
              num2 = 3;
              continue;
            case 2:
              instance1 = ComponentMetadataItemManager.Instance;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 1 : 0;
              continue;
            case 3:
              goto label_5;
            case 4:
              goto label_6;
            default:
              goto label_16;
          }
        }
label_5:
        enumerator = Locator.GetServiceNotNull<IEnumerable<ISystemComponentCreator>>().GetEnumerator();
        num1 = 4;
      }
label_21:
      return;
label_16:
      return;
label_6:
      try
      {
label_8:
        if (enumerator.MoveNext())
          goto label_14;
        else
          goto label_9;
label_7:
        ComponentMetadataItem componentMetadataItem;
        int num3;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_14;
            case 2:
            case 6:
              goto label_8;
            case 3:
              SystemComponentContainerEvents.AATQTBfGi8A5ft8UMdvO((object) instance1, (object) componentMetadataItem);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
              continue;
            case 4:
              if (componentMetadataItem == null)
              {
                num3 = 2;
                continue;
              }
              goto case 3;
            case 5:
              goto label_10;
            default:
              SystemComponentContainerEvents.eH4xgffGqJdpsNme1brT((object) instance2, SystemComponentContainerEvents.VCDyMofGRqMXSIpMqVYQ((object) componentMetadataItem));
              num3 = 6;
              continue;
          }
        }
label_10:
        return;
label_9:
        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 5;
        goto label_7;
label_14:
        componentMetadataItem = (ComponentMetadataItem) SystemComponentContainerEvents.CKOWPJfGS7RofMjEMhoA((object) enumerator.Current);
        num3 = 4;
        goto label_7;
      }
      finally
      {
        if (enumerator != null)
        {
          int num4 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
            num4 = 0;
          while (true)
          {
            switch (num4)
            {
              case 1:
                goto label_23;
              default:
                SystemComponentContainerEvents.xGionNfGKf7J78v2mhtt((object) enumerator);
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 1 : 1;
                continue;
            }
          }
        }
label_23:;
      }
    }

    /// <inheritdoc />
    public void Terminating()
    {
    }

    public SystemComponentContainerEvents()
    {
      SystemComponentContainerEvents.X11KHSfGXPcdMsW9as0l();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object CKOWPJfGS7RofMjEMhoA([In] object obj0) => (object) ((ISystemComponentCreator) obj0).Create();

    internal static void AATQTBfGi8A5ft8UMdvO([In] object obj0, [In] object obj1) => ((ComponentMetadataItemManager) obj0).AddSystemComponent((ComponentMetadataItem) obj1);

    internal static object VCDyMofGRqMXSIpMqVYQ([In] object obj0) => (object) ((ComponentMetadataItem) obj0).Header;

    internal static void eH4xgffGqJdpsNme1brT([In] object obj0, [In] object obj1) => ((ComponentMetadataItemHeaderManager) obj0).AddSystemComponent((ComponentMetadataItemHeader) obj1);

    internal static void xGionNfGKf7J78v2mhtt([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool sfgQ2FfGIpigGYb6ikqD() => SystemComponentContainerEvents.fJfXqofGuKy52pyQsS9H == null;

    internal static SystemComponentContainerEvents T65gL7fGVybJVbSIqZLH() => SystemComponentContainerEvents.fJfXqofGuKy52pyQsS9H;

    internal static void X11KHSfGXPcdMsW9as0l() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
