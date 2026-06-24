// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Packaging.StoreComponentInfoBase
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Licensing;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using j3AmrhgkCleVTGdEwA;
using NuGet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Packaging
{
  /// <summary>Базовый класс для информации о компоненте ELMA Store</summary>
  public abstract class StoreComponentInfoBase : IStoreComponentInfo
  {
    private readonly bool isDeprecated;
    internal static StoreComponentInfoBase WkttDyBnAbR4gFRlDXud;

    /// <summary>Ctor</summary>
    /// <param name="isDeprecated">Устарел ли компонент?</param>
    protected StoreComponentInfoBase(bool isDeprecated = false)
    {
      StoreComponentInfoBase.MSeaFOBn0RU0ueDaOPJL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.isDeprecated = isDeprecated;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Идентификатор</summary>
    public abstract string Id { get; }

    /// <summary>Отображаемое имя компонента</summary>
    public abstract string Title { get; }

    /// <summary>Ссылка на иконку компонента</summary>
    public virtual string ImagePath => (string) null;

    /// <summary>Описание компонента</summary>
    public abstract string Description { get; }

    /// <summary>
    /// 
    /// </summary>
    public abstract string Author { get; }

    /// <summary>
    /// 
    /// </summary>
    public abstract string Site { get; }

    /// <summary>Тип компонента</summary>
    public abstract ManifestComponentType Type { get; }

    /// <summary>Статус модуля</summary>
    public virtual ModuleStatus Status
    {
      get
      {
        int num = 15;
        ILicenseInfo licenseInfo;
        ILicensedUnit licensedUnit;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (!this.AllModules.Any<IModule>())
              {
                num = 8;
                continue;
              }
              goto case 11;
            case 2:
            case 5:
            case 8:
              goto label_8;
            case 3:
              goto label_21;
            case 4:
              if (licenseInfo == null)
              {
                num = 9;
                continue;
              }
              goto case 10;
            case 6:
              goto label_18;
            case 7:
              if (licensedUnit != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 9 : 12;
                continue;
              }
              goto case 9;
            case 9:
              if (this.AllModules.Any<IModule>((Func<IModule, bool>) (m => m.Status == ModuleStatus.Disabled)))
              {
                num = 13;
                continue;
              }
              if (!this.AllModules.Any<IModule>((Func<IModule, bool>) (m => m.Status == ModuleStatus.RestartRequired)))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 2 : 5;
                continue;
              }
              goto label_7;
            case 10:
              if (StoreComponentInfoBase.GEQkmpBnMOeQlSBohSAW((object) licenseInfo) == LicenseStatus.NeedRestart)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 3 : 3;
                continue;
              }
              goto case 9;
            case 11:
              licensedUnit = this.LicensedUnit;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 2 : 7;
              continue;
            case 12:
              licenseInfo = (ILicenseInfo) StoreComponentInfoBase.tGtwrABnyJSR3J4RQadf((object) licensedUnit);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 2 : 4;
              continue;
            case 13:
              goto label_24;
            case 14:
              if (!StoreComponentInfoBase.yH5me7BnmOU4dbO9w6wi((object) this))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 1 : 6;
                continue;
              }
              if (this.AllModules == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 1 : 2;
                continue;
              }
              goto case 1;
            case 15:
              if (!this.isDeprecated)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 14 : 12;
                continue;
              }
              goto label_18;
            default:
              goto label_7;
          }
        }
label_7:
        return ModuleStatus.RestartRequired;
label_8:
        return ModuleStatus.Enabled;
label_18:
        return ModuleStatus.Disabled;
label_21:
        return ModuleStatus.RestartRequired;
label_24:
        return ModuleStatus.Disabled;
      }
    }

    /// <summary>Причина отключения</summary>
    public virtual ModuleDisabledReason DisabledReason
    {
      get
      {
        int num1 = 11;
        IModule module;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 1:
              case 4:
                goto label_24;
              case 2:
                goto label_21;
              case 3:
                if (this.AllModules != null)
                {
                  num2 = 15;
                  continue;
                }
                goto label_19;
              case 5:
                goto label_15;
              case 6:
                IEnumerable<IModule> allModules1 = this.AllModules;
                Func<IModule, bool> func1 = StoreComponentInfoBase.\u003C\u003Ec.\u003C\u003E9__19_2;
                Func<IModule, bool> predicate1;
                if (func1 == null)
                  StoreComponentInfoBase.\u003C\u003Ec.\u003C\u003E9__19_2 = predicate1 = (Func<IModule, bool>) (m => StoreComponentInfoBase.\u003C\u003Ec.edmC8yQVe6WdD45rLTbi((object) m) == ModuleStatus.RestartRequired);
                else
                  goto label_30;
label_29:
                module = allModules1.FirstOrDefault<IModule>(predicate1);
                num2 = 14;
                continue;
label_30:
                predicate1 = func1;
                goto label_29;
              case 7:
                if (module == null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 2 : 4;
                  continue;
                }
                goto default;
              case 8:
                goto label_16;
              case 9:
                goto label_8;
              case 10:
                if (StoreComponentInfoBase.yH5me7BnmOU4dbO9w6wi((object) this))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 3 : 0;
                  continue;
                }
                goto label_8;
              case 11:
                if (!this.isDeprecated)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 10 : 10;
                  continue;
                }
                goto label_21;
              case 12:
                goto label_19;
              case 13:
                if (module != null)
                  goto case 14;
                else
                  goto label_18;
              case 14:
                if (module != null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 8 : 0;
                  continue;
                }
                goto label_15;
              case 15:
                module = this.AllModules.FirstOrDefault<IModule>((Func<IModule, bool>) (m => ((string) StoreComponentInfoBase.C6GF3EBnr9T157IE7dfD((object) m)).Equals(this.Id, StringComparison.CurrentCultureIgnoreCase)));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 7 : 4;
                continue;
              default:
                if (module.Status == ModuleStatus.Enabled)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 1 : 1;
                  continue;
                }
                goto case 14;
            }
          }
label_18:
          num1 = 6;
          continue;
label_24:
          IEnumerable<IModule> allModules2 = this.AllModules;
          Func<IModule, bool> func2 = StoreComponentInfoBase.\u003C\u003Ec.\u003C\u003E9__19_1;
          Func<IModule, bool> predicate2;
          if (func2 == null)
            StoreComponentInfoBase.\u003C\u003Ec.\u003C\u003E9__19_1 = predicate2 = (Func<IModule, bool>) (m => StoreComponentInfoBase.\u003C\u003Ec.edmC8yQVe6WdD45rLTbi((object) m) == ModuleStatus.Disabled);
          else
            goto label_3;
label_26:
          module = allModules2.FirstOrDefault<IModule>(predicate2);
          num1 = 13;
          continue;
label_3:
          predicate2 = func2;
          goto label_26;
        }
label_8:
        return ModuleDisabledReason.PackageNotInstalled;
label_15:
        return ModuleDisabledReason.Unknown;
label_16:
        return module.DisabledReason;
label_19:
        return ModuleDisabledReason.Unknown;
label_21:
        return ModuleDisabledReason.Deprecated;
      }
    }

    /// <summary>Список всех пакетов, входящих в данный компонент</summary>
    public abstract IEnumerable<PackageDescription> AllPackages { get; }

    /// <summary>
    /// Список всех рантаймовых модулей, входящих в данный компонент
    /// </summary>
    public abstract IEnumerable<IModule> AllModules { get; }

    /// <summary>Лицензируемый модуль</summary>
    public virtual ILicensedUnit LicensedUnit
    {
      get
      {
        int num1 = 1;
        ILicensedUnit licensedUnit1;
        while (true)
        {
          ILicensedUnit licensedUnit2;
          switch (num1)
          {
            case 1:
              if (this.AllModules != null)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              licensedUnit2 = (ILicensedUnit) null;
              break;
            case 3:
              licensedUnit2 = this.AllModules.FirstOrDefault<IModule>((Func<IModule, bool>) (m =>
              {
                int num2 = 2;
                while (true)
                {
                  switch (num2)
                  {
                    case 1:
                      goto label_3;
                    case 2:
                      if (StoreComponentInfoBase.C6GF3EBnr9T157IE7dfD((object) m) == null)
                      {
                        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 1 : 1;
                        continue;
                      }
                      goto label_2;
                    default:
                      goto label_2;
                  }
                }
label_2:
                return StoreComponentInfoBase.Hix1nBBn5ITINl29sa6S(StoreComponentInfoBase.MScDnsBngnKJyQ9ADOeb((object) this), (object) m.Id, StringComparison.CurrentCultureIgnoreCase);
label_3:
                return false;
              })) as ILicensedUnit;
              break;
            case 4:
              goto label_2;
            case 5:
              goto label_9;
            case 6:
              if (licensedUnit1 != null)
              {
                num1 = 5;
                continue;
              }
              goto label_10;
            default:
              if (this.AllModules != null)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 3 : 2;
                continue;
              }
              goto case 2;
          }
          licensedUnit1 = licensedUnit2;
          num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 2 : 6;
        }
label_2:
        return (ILicensedUnit) null;
label_9:
        return licensedUnit1;
label_10:
        return this.AllModules.OfType<ILicensedUnit>().FirstOrDefault<ILicensedUnit>();
      }
    }

    public override string ToString() => this.Id;

    /// <summary>Установлен или нет</summary>
    public abstract bool IsInstalled { get; }

    /// <summary>Версия</summary>
    public abstract SemanticVersion InstalledVersion { get; }

    /// <summary>Установлена ли последняя версия</summary>
    public virtual bool IsLatestVersionInstalled
    {
      get
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
            case 4:
              goto label_5;
            case 2:
              if (StoreComponentInfoBase.vPE3xOBn95XpAVLc9Sac(StoreComponentInfoBase.v8glXoBnJkLG9OgOp7Vi((object) this), (object) null))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 1 : 1;
                continue;
              }
              break;
            case 3:
              goto label_4;
          }
          if (StoreComponentInfoBase.vPE3xOBn95XpAVLc9Sac(StoreComponentInfoBase.HomueXBndqrqhwFN941g((object) this), (object) null))
            num = 4;
          else
            break;
        }
label_4:
        return StoreComponentInfoBase.QQ7VOJBnlVT0VdonAuSS(StoreComponentInfoBase.v8glXoBnJkLG9OgOp7Vi((object) this), StoreComponentInfoBase.HomueXBndqrqhwFN941g((object) this));
label_5:
        return true;
      }
    }

    /// <summary>Номер последней версии</summary>
    public abstract SemanticVersion LastVersion { get; }

    /// <summary>
    /// Требуется ли перезагрузка сервера после установки/обновления Store-компонента.
    /// </summary>
    public virtual bool DoesInstallOrUpdateRequireRestart => true;

    internal static void MSeaFOBn0RU0ueDaOPJL() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool tvVAKMBn7qJymDcO4ikD() => StoreComponentInfoBase.WkttDyBnAbR4gFRlDXud == null;

    internal static StoreComponentInfoBase GE9pHuBnxyywEGiYZSO0() => StoreComponentInfoBase.WkttDyBnAbR4gFRlDXud;

    internal static bool yH5me7BnmOU4dbO9w6wi([In] object obj0) => ((StoreComponentInfoBase) obj0).IsInstalled;

    internal static object tGtwrABnyJSR3J4RQadf([In] object obj0) => (object) ((ILicensedUnit) obj0).GetLicenseInfo();

    internal static LicenseStatus GEQkmpBnMOeQlSBohSAW([In] object obj0) => ((ILicenseInfo) obj0).Status;

    internal static object v8glXoBnJkLG9OgOp7Vi([In] object obj0) => (object) ((StoreComponentInfoBase) obj0).LastVersion;

    internal static bool vPE3xOBn95XpAVLc9Sac([In] object obj0, [In] object obj1) => (SemanticVersion) obj0 == (SemanticVersion) obj1;

    internal static object HomueXBndqrqhwFN941g([In] object obj0) => (object) ((StoreComponentInfoBase) obj0).InstalledVersion;

    internal static bool QQ7VOJBnlVT0VdonAuSS([In] object obj0, [In] object obj1) => ((SemanticVersion) obj0).Equals((SemanticVersion) obj1);

    internal static object C6GF3EBnr9T157IE7dfD([In] object obj0) => (object) ((IApplicationUnit) obj0).Id;

    internal static object MScDnsBngnKJyQ9ADOeb([In] object obj0) => (object) ((StoreComponentInfoBase) obj0).Id;

    internal static bool Hix1nBBn5ITINl29sa6S([In] object obj0, [In] object obj1, [In] StringComparison obj2) => ((string) obj0).Equals((string) obj1, obj2);
  }
}
