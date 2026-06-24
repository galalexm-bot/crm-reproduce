// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.ExpirationInfoService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Licensing;
using EleWise.ELMA.Modules.Impl;
using EleWise.ELMA.Packaging;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Services
{
  /// <summary>
  /// Предоставляет доступ к информации об окончании лицензии
  /// </summary>
  [Service]
  public class ExpirationInfoService
  {
    /// <summary>Менеджер модулей</summary>
    private ModuleManager moduleManager;
    /// <summary>Список установленных компонентов ELMA Store</summary>
    private IEnumerable<ModuleManager.StoreComponentConfigurationInfo> components;
    /// <summary>Сервис проверки лицензии компонентов</summary>
    private static ExpirationInfoService _expirationInfoService;
    internal static ExpirationInfoService NxwgwFBwtk8A9EsZ1a8h;

    /// <summary>Менеджер модулей</summary>
    internal ModuleManager ModuleManager
    {
      get
      {
        int num = 1;
        ModuleManager moduleManager1;
        ModuleManager moduleManager2;
        while (true)
        {
          switch (num)
          {
            case 1:
              moduleManager2 = this.moduleManager;
              if (moduleManager2 == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_6;
            default:
              this.moduleManager = moduleManager1 = ExpirationInfoService.Pun1eSBwHaPQPr8qDJQX(ExpirationInfoService.nvQhmlBw6RB4xRYyTWlm()) as ModuleManager;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 2;
              continue;
          }
        }
label_2:
        return moduleManager2;
label_6:
        return moduleManager1;
      }
    }

    /// <summary>Экземпляр сервиса проверки лицензии компонентов</summary>
    public static ExpirationInfoService Instance
    {
      get
      {
        int num = 1;
        ExpirationInfoService expirationInfoService;
        while (true)
        {
          switch (num)
          {
            case 1:
              expirationInfoService = ExpirationInfoService._expirationInfoService;
              if (expirationInfoService == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_5;
          }
        }
label_2:
        return expirationInfoService;
label_5:
        return ExpirationInfoService._expirationInfoService = Locator.GetServiceNotNull<ExpirationInfoService>();
      }
    }

    /// <summary>Сервис для работы с пакетной системой</summary>
    public PackageService PackageService
    {
      get => this.\u003CPackageService\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CPackageService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Получить дату и время истечения лицензии модуля</summary>
    /// <param name="info">Информация о компоненте</param>
    public DateTime? GetExpirationDate(IStoreComponentInfo info)
    {
      DateTime? expirationDate = new DateTime?();
      if (info != null)
      {
        ILicenseInfo licenseInfo = info.LicensedUnit?.GetLicenseInfo();
        if (licenseInfo == null)
        {
          if (this.components == null)
            this.components = this.ModuleManager.GetInstalledComponentInfos();
          // ISSUE: reference to a compiler-generated method
          licenseInfo = this.components.FirstOrDefault<ModuleManager.StoreComponentConfigurationInfo>((Func<ModuleManager.StoreComponentConfigurationInfo, bool>) (x => string.Equals(x.Id, (string) ExpirationInfoService.\u003C\u003Ec__DisplayClass11_0.ETk4gvQXm3yXvHNxbQWa((object) info))))?.LicensedUnit?.GetLicenseInfo();
        }
        expirationDate = (!(licenseInfo is ITrialLicenseInfo trialLicenseInfo) ? 0 : (trialLicenseInfo.TrialExpiration.HasValue ? 1 : 0)) != 0 ? new DateTime?(trialLicenseInfo.TrialExpiration.Value) : new DateTime?();
      }
      return expirationDate;
    }

    /// <summary>
    /// Получить информацию о всех модулях с истекающей лицензией
    /// </summary>
    /// <param name="daysBeforExp">Количество дней до истечения</param>
    public IEnumerable<IStoreComponentInfo> GetExpiringComponents(int daysBeforExp) => (IEnumerable<IStoreComponentInfo>) new ExpirationInfoService.\u003CGetExpiringComponents\u003Ed__12(-2)
    {
      \u003C\u003E4__this = this,
      \u003C\u003E3__daysBeforExp = daysBeforExp
    };

    public ExpirationInfoService()
    {
      ExpirationInfoService.N5yhkrBwAYQKqGk9Fp8h();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object nvQhmlBw6RB4xRYyTWlm() => (object) ComponentManager.Current;

    internal static object Pun1eSBwHaPQPr8qDJQX([In] object obj0) => (object) ((ComponentManager) obj0).ModuleManager;

    internal static bool e7xt5ZBwwRRBFE7SYXe5() => ExpirationInfoService.NxwgwFBwtk8A9EsZ1a8h == null;

    internal static ExpirationInfoService NNd6pxBw4MtKrjaDbomO() => ExpirationInfoService.NxwgwFBwtk8A9EsZ1a8h;

    internal static void N5yhkrBwAYQKqGk9Fp8h() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
