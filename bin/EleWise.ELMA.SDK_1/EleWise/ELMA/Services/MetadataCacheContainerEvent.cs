// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.MetadataCacheContainerEvent
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.ExtensionPoints;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Cache;
using EleWise.ELMA.Runtime.NH;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Services
{
  /// <summary>Событие формирования кеша рантайма</summary>
  [Component]
  internal sealed class MetadataCacheContainerEvent : IInitHandler
  {
    private readonly IMetadataCacheService metadataCacheService;
    internal static MetadataCacheContainerEvent N4pYhBBDvBN18Ji35Mg4;

    /// <summary>Ctor</summary>
    /// <param name="metadataCacheService">Интерфейс сервиса получения кеша рантайма метаданных</param>
    public MetadataCacheContainerEvent(IMetadataCacheService metadataCacheService)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.metadataCacheService = metadataCacheService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public void Init()
    {
    }

    /// <inheritdoc />
    public void InitComplete()
    {
      int num1 = 7;
      while (true)
      {
        int num2 = num1;
        IRuntimeApplication service;
        string str1;
        bool flag;
        string str2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_15;
            case 2:
              flag = MetadataCacheContainerEvent.l9kwHABDSbPHLhFRPckW((object) str2, (object) str1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 11 : 5;
              continue;
            case 3:
              goto label_6;
            case 4:
            case 11:
              if (!flag)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 1 : 0;
                continue;
              }
              goto case 10;
            case 5:
            case 8:
              flag = true;
              num2 = 4;
              continue;
            case 6:
              if (service == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 1 : 3;
                continue;
              }
              goto label_14;
            case 7:
              goto label_13;
            case 9:
              str1 = (string) MetadataCacheContainerEvent.g072bABDIlNr9sFnwpQ2((object) service);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
              continue;
            case 10:
              MetadataCacheContainerEvent.WKavGTBDiGkdulJ8EFVK((object) this.metadataCacheService, (object) str1);
              num2 = 12;
              continue;
            case 12:
              goto label_7;
            default:
              if (MetadataCacheContainerEvent.suXbRhBDVr4Cm3yQRA04((object) str2))
              {
                num2 = 5;
                continue;
              }
              goto case 2;
          }
        }
label_13:
        service = Locator.GetService<IRuntimeApplication>();
        num1 = 6;
        continue;
label_14:
        str2 = (string) MetadataCacheContainerEvent.JObSN6BDu2rAamjq0TNF((object) this.metadataCacheService);
        num1 = 9;
      }
label_15:
      return;
label_6:
      return;
label_7:;
    }

    private static string GetHashes(object runtimeApplication)
    {
      int num1 = 1;
      AssemblyInfoCache[] assemblyInfos;
      while (true)
      {
        switch (num1)
        {
          case 1:
            assemblyInfos = ((ApplicationStartCache) MetadataCacheContainerEvent.K1XF89BDRxKULWvKJ3bU(runtimeApplication)).AssemblyInfos;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      // ISSUE: reference to a compiler-generated method
      return string.Join((string) MetadataCacheContainerEvent.mBpV3pBDqWsTrIORIpqQ(-606654180 ^ -606651034), ((IEnumerable<AssemblyInfoCache>) assemblyInfos).Where<AssemblyInfoCache>((Func<AssemblyInfoCache, bool>) (a =>
      {
        int num2 = 1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              if (!MetadataCacheContainerEvent.\u003C\u003Ec.uFVBvqQXbZaAyd9FSCXj((object) a.AssemblyName, MetadataCacheContainerEvent.\u003C\u003Ec.RnvB39QXoVId8rmcEhMo(-1638402543 ^ -1638400961)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            default:
              goto label_2;
          }
        }
label_2:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        return MetadataCacheContainerEvent.\u003C\u003Ec.uFVBvqQXbZaAyd9FSCXj(MetadataCacheContainerEvent.\u003C\u003Ec.X5dJk1QXhPRbXhrnQ082((object) a), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1319452732 ^ 1319455320));
label_3:
        return true;
      })).Select<AssemblyInfoCache, string>((Func<AssemblyInfoCache, string>) (a => (string) MetadataCacheContainerEvent.\u003C\u003Ec.HTnByJQXG1IAFAqKjM0D((object) a))));
    }

    internal static bool P2k7gcBD8R0NbJHDaDyT() => MetadataCacheContainerEvent.N4pYhBBDvBN18Ji35Mg4 == null;

    internal static MetadataCacheContainerEvent Up4mJ9BDZS8ExoYDUT49() => MetadataCacheContainerEvent.N4pYhBBDvBN18Ji35Mg4;

    internal static object JObSN6BDu2rAamjq0TNF([In] object obj0) => (object) ((IMetadataCacheService) obj0).GetRuntimeHash();

    internal static object g072bABDIlNr9sFnwpQ2([In] object obj0) => (object) MetadataCacheContainerEvent.GetHashes(obj0);

    internal static bool suXbRhBDVr4Cm3yQRA04([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static bool l9kwHABDSbPHLhFRPckW([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

    internal static void WKavGTBDiGkdulJ8EFVK([In] object obj0, [In] object obj1) => ((IMetadataCacheService) obj0).SetRuntimeHash((string) obj1);

    internal static object K1XF89BDRxKULWvKJ3bU([In] object obj0) => (object) ((IRuntimeApplication) obj0).ApplicationStartCache;

    internal static object mBpV3pBDqWsTrIORIpqQ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    [Component]
    private sealed class RuntimeHashGenerator : IAfterDeltaPublishEventHandler, IEventHandler
    {
      private readonly object metadataCacheService;
      private readonly object unitOfWorkManager;
      private readonly object runtimeApplication;
      private static object z8li3TQK5O6kXgHB9758;

      public RuntimeHashGenerator(
        IMetadataCacheService metadataCacheService,
        IUnitOfWorkManager unitOfWorkManager,
        IRuntimeApplication runtimeApplication)
      {
        MetadataCacheContainerEvent.RuntimeHashGenerator.MUnvCLQKL99glU3FhB8n();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
          num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.metadataCacheService = (object) metadataCacheService;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_3;
            case 3:
              this.runtimeApplication = (object) runtimeApplication;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 2 : 1;
              continue;
            default:
              this.unitOfWorkManager = (object) unitOfWorkManager;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 3 : 0;
              continue;
          }
        }
label_3:;
      }

      /// <inheritdoc />
      public void Processing(MetadataPublishedEventArgs e)
      {
        int num1 = 1;
        while (true)
        {
          switch (num1)
          {
            case 0:
              goto label_2;
            case 1:
              MetadataCacheContainerEvent.RuntimeHashGenerator.aVLmCLQKUScSmknHD3mv(this.unitOfWorkManager, (object) (System.Action) (() =>
              {
                int num2 = 1;
                string str;
                while (true)
                {
                  switch (num2)
                  {
                    case 1:
                      str = (string) MetadataCacheContainerEvent.RuntimeHashGenerator.H2ly88QKsHJJTN03MMw5(this.runtimeApplication);
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
                      continue;
                    case 2:
                      goto label_2;
                    default:
                      MetadataCacheContainerEvent.RuntimeHashGenerator.j7dIZYQKcqksckLG3aBn(this.metadataCacheService, (object) str);
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 2;
                      continue;
                  }
                }
label_2:;
              }));
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      internal static void MUnvCLQKL99glU3FhB8n() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool mk8MdoQKjphQsiKO2DYG() => MetadataCacheContainerEvent.RuntimeHashGenerator.z8li3TQK5O6kXgHB9758 == null;

      internal static MetadataCacheContainerEvent.RuntimeHashGenerator gs9IKaQKYXfFSwoEQycg() => (MetadataCacheContainerEvent.RuntimeHashGenerator) MetadataCacheContainerEvent.RuntimeHashGenerator.z8li3TQK5O6kXgHB9758;

      internal static void aVLmCLQKUScSmknHD3mv([In] object obj0, [In] object obj1) => ((IUnitOfWorkManager) obj0).RegisterPreCommitAction((System.Action) obj1);

      internal static object H2ly88QKsHJJTN03MMw5([In] object obj0) => (object) MetadataCacheContainerEvent.GetHashes(obj0);

      internal static void j7dIZYQKcqksckLG3aBn([In] object obj0, [In] object obj1) => ((IMetadataCacheService) obj0).SetRuntimeHash((string) obj1);
    }
  }
}
