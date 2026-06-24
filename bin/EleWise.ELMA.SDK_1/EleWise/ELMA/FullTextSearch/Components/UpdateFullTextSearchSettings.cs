// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Components.UpdateFullTextSearchSettings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.FullTextSearch.Constants;
using EleWise.ELMA.FullTextSearch.Services;
using EleWise.ELMA.FullTextSearch.Settings;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.FullTextSearch.Components
{
  /// <summary>Обновление настроек индексации при старте</summary>
  [Component(Order = 10000, Type = ComponentType.Server)]
  internal class UpdateFullTextSearchSettings : IModuleContainerEvents
  {
    private static UpdateFullTextSearchSettings GygMwEGViE1VeXrD26Mh;

    public void Activated() => UpdateFullTextSearchSettings.CheckSettings();

    public void Terminating()
    {
    }

    /// <summary>Проверка настроек индексации</summary>
    private static void CheckSettings()
    {
      switch (1)
      {
        case 1:
          try
          {
            Guid guid = new Guid();
            int num1 = 2;
            while (true)
            {
              int num2;
              FullTextSearchSettingsModule serviceNotNull1;
              bool flag;
              IFullTextSearchService serviceNotNull2;
              bool? nullable1;
              bool? nullable2;
              bool? nullable3;
              int num3;
              switch (num1)
              {
                case 1:
                  if (serviceNotNull1.Settings == null)
                  {
                    num1 = 13;
                    continue;
                  }
                  goto case 10;
                case 2:
                  serviceNotNull1 = Locator.GetServiceNotNull<FullTextSearchSettingsModule>();
                  num2 = 14;
                  break;
                case 3:
                  if (UpdateFullTextSearchSettings.Mb98npGVOtCPpcFgACnr((object) serviceNotNull2) != FullTextSearchState.Off)
                  {
                    num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 4 : 4;
                    continue;
                  }
                  goto case 15;
                case 4:
                  goto label_35;
                case 5:
                  serviceNotNull2 = Locator.GetServiceNotNull<IFullTextSearchService>();
                  num1 = 3;
                  continue;
                case 6:
                  flag = true;
                  num1 = 8;
                  continue;
                case 7:
                  IRuntimeApplication service = Locator.GetService<IRuntimeApplication>();
                  if (service == null)
                  {
                    num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 9 : 1;
                    continue;
                  }
                  DbPreUpdater dbPreUpdater = service.DbPreUpdater;
                  if (dbPreUpdater == null)
                  {
                    num2 = 11;
                    break;
                  }
                  nullable3 = new bool?(dbPreUpdater.IsFirstStart);
                  goto label_31;
                case 8:
                  num3 = nullable2.GetValueOrDefault() == flag & nullable2.HasValue ? 1 : 0;
                  goto label_33;
                case 9:
                  num3 = 0;
                  goto label_33;
                case 10:
                  if (UpdateFullTextSearchSettings.DXJyBrGVX7iiiW2wymUm(guid, Guid.Empty))
                  {
                    num2 = 7;
                    break;
                  }
                  goto label_23;
                case 11:
                  nullable1 = new bool?();
                  num1 = 18;
                  continue;
                case 12:
                  guid = UpdateFullTextSearchSettings.EcCvofGVKbaQkkBVp4Z6((object) serviceNotNull1.Settings);
                  num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 1 : 1;
                  continue;
                case 13:
                  goto label_5;
                case 14:
                  if (serviceNotNull1.Settings != null)
                  {
                    num1 = 12;
                    continue;
                  }
                  goto case 1;
                case 15:
                  serviceNotNull2.StartIndexing();
                  num1 = 16;
                  continue;
                case 16:
                  goto label_1;
                case 17:
                  UpdateFullTextSearchSettings.WP8GMqGVkMq5T3ExbEk7((object) serviceNotNull1.Settings, UpdateFullTextSearchSettings.QBCIqmGVThZNwBfq88jh());
                  num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
                  continue;
                case 18:
                  nullable3 = nullable1;
                  goto label_31;
                default:
                  UpdateFullTextSearchSettings.b4dbeXGVndCmr91P6jC2((object) serviceNotNull1);
                  num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 3 : 5;
                  continue;
              }
              num1 = num2;
              continue;
label_31:
              nullable2 = nullable3;
              num1 = 6;
              continue;
label_33:
              if (num3 != 0)
                num1 = 17;
              else
                goto label_21;
            }
label_35:
            break;
label_5:
            break;
label_1:
            break;
label_23:
            break;
label_21:
            break;
          }
          catch (Exception ex)
          {
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0)
              num = 1;
            while (true)
            {
              switch (num)
              {
                case 0:
                  goto label_42;
                case 1:
                  UpdateFullTextSearchSettings.rPUq1pGVeEddG65i5Xte(UpdateFullTextSearchSettings.Y82GiXGV2onRk3hqf4bk(), (object) ex);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 0 : 0;
                  continue;
                default:
                  goto label_43;
              }
            }
label_42:
            break;
label_43:
            break;
          }
      }
    }

    public UpdateFullTextSearchSettings()
    {
      UpdateFullTextSearchSettings.S2ALX1GVPm5HMtuxVlbh();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Guid EcCvofGVKbaQkkBVp4Z6([In] object obj0) => ((FullTextSearchSettings) obj0).ProviderUid;

    internal static bool DXJyBrGVX7iiiW2wymUm([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static Guid QBCIqmGVThZNwBfq88jh() => FullTextSearchConst.DeafultProviderUid;

    internal static void WP8GMqGVkMq5T3ExbEk7([In] object obj0, Guid value) => ((FullTextSearchSettings) obj0).ProviderUid = value;

    internal static void b4dbeXGVndCmr91P6jC2([In] object obj0) => ((GlobalSettingsModuleBase<FullTextSearchSettings>) obj0).SaveSettings();

    internal static FullTextSearchState Mb98npGVOtCPpcFgACnr([In] object obj0) => ((IFullTextSearchService) obj0).GetIndexState();

    internal static object Y82GiXGV2onRk3hqf4bk() => (object) Logger.Log;

    internal static void rPUq1pGVeEddG65i5Xte([In] object obj0, [In] object obj1) => ((ILogger) obj0).Error(obj1);

    internal static bool phedceGVRJFK2ccJuxFi() => UpdateFullTextSearchSettings.GygMwEGViE1VeXrD26Mh == null;

    internal static UpdateFullTextSearchSettings q7x0SwGVqO9LxfoDnTYR() => UpdateFullTextSearchSettings.GygMwEGViE1VeXrD26Mh;

    internal static void S2ALX1GVPm5HMtuxVlbh() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
