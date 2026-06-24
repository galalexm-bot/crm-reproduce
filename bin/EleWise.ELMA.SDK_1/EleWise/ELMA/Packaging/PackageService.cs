// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Packaging.PackageService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Packaging.Components;
using EleWise.ELMA.Packaging.Components.Designer;
using EleWise.ELMA.Packaging.Components.FilePreviewCreator;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Packaging.FileSystems;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NuGet;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace EleWise.ELMA.Packaging
{
  /// <summary>Сервис для работы с пакетной системой</summary>
  public class PackageService : IDisposable
  {
    private bool _initialized;
    private PackagingInitializer _initializer;
    private PackagingHelper _helper;
    private PackagingSettings _settings;
    private bool? _isDesignerInstallerAvailable;
    private string _designerInstallerFileName;
    private IPackageRepository _localRepository;
    private ElmaStoreComponentRepository _serverComponentsRepository;
    private DateTime? _cfgComponentsLastWriteTime;
    private DateTime? _componentsLastWriteTime;
    private ConcurrentDictionary<string, string> _packagesIconFileNames;
    private static readonly List<string> _supportedIconExtensions;
    internal static PackageService jfyBspB2oSSitYC6GSPt;

    /// <summary>Создать сервис</summary>
    public PackageService()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this._packagesIconFileNames = new ConcurrentDictionary<string, string>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.UseConsole = true;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Инициализирован ли сервис</summary>
    public bool Initialized => this._initialized;

    /// <summary>Инициализировать данный сервис</summary>
    public void Initialize()
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        string str;
        while (true)
        {
          switch (num2)
          {
            case 1:
              str = (string) null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
              continue;
            case 2:
              this.Initialize(str);
              num2 = 7;
              continue;
            case 3:
              goto label_7;
            case 4:
            case 5:
              if (!Directory.Exists(str))
              {
                num2 = 9;
                continue;
              }
              goto case 2;
            case 6:
              if (Directory.Exists(str))
              {
                num2 = 5;
                continue;
              }
              goto label_7;
            case 7:
              goto label_8;
            case 8:
              goto label_4;
            case 9:
              PackageService.zBZQFvB288H9uWyvwZjj((object) EleWise.ELMA.Logging.Logger.Log, PackageService.rXNSAoB2CbEfxDC3JZV0(1021410165 ^ 1021331937));
              num2 = 8;
              continue;
            default:
              str = (string) PackageService.RFAa64B2vsw36xTj25Uj(PackageService.veJtXEB2QvUPj9IKqMk4(PackageService.veJtXEB2QvUPj9IKqMk4(PackageService.Ath7IGB2fWorGVKLvPZA(PackageService.zv4an5B2EHvEDqratyAQ(PackageService.W81UwKB2GN69Gqu5gCrU())))), PackageService.rXNSAoB2CbEfxDC3JZV0(-1290212282 ^ -644262414 ^ 1786809280));
              num2 = 6;
              continue;
          }
        }
label_7:
        str = this.GetDebugPackageManagerPath((string) PackageService.veJtXEB2QvUPj9IKqMk4(PackageService.Ath7IGB2fWorGVKLvPZA(PackageService.zv4an5B2EHvEDqratyAQ((object) AppDomain.CurrentDomain))));
        num1 = 4;
      }
label_8:
      return;
label_4:;
    }

    /// <summary>Инициализировать данный сервис</summary>
    /// <param name="packageManagerPath">Путь до менеджера пакетов</param>
    public void Initialize(string packageManagerPath)
    {
      int num = 6;
      Assembly[] compositionAssemblies;
      Lazy<PackagingHelper> export;
      while (true)
      {
        switch (num)
        {
          case 1:
            this._initializer = new PackagingInitializer((IEnumerable<Assembly>) compositionAssemblies, this._settings, (EleWise.ELMA.Packaging.Logging.ILogger) new PackageService.PackagingLogger());
            num = 10;
            continue;
          case 2:
            goto label_5;
          case 3:
            if (export != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          case 4:
            goto label_7;
          case 5:
            this._settings = (PackagingSettings) PackageService.GgLXfeB2ulUCh4Ge8hay((object) packageManagerPath);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 1;
            continue;
          case 6:
            // ISSUE: type reference
            compositionAssemblies = new Assembly[1]
            {
              PackageService.sX2f72B2ZBl7CBN8dPEc(__typeref (PackagingInitializer)).Assembly
            };
            num = 5;
            continue;
          case 7:
            this._serverComponentsRepository = (ElmaStoreComponentRepository) PackageService.hbXDB4B2SUCGpsLdYrfl((object) this._helper);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 7 : 8;
            continue;
          case 8:
            this._initialized = true;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 4 : 4;
            continue;
          case 9:
            this._localRepository = (IPackageRepository) PackageService.E1o1gwB2VTjeIOqXmN5N((object) this._helper);
            num = 7;
            continue;
          case 10:
            export = ((ExportProvider) PackageService.yOwc9pB2IveUo9piLyHc((object) this._initializer)).GetExport<PackagingHelper>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 1 : 3;
            continue;
          default:
            this._helper = export.Value;
            num = 9;
            continue;
        }
      }
label_7:
      return;
label_5:
      throw new ServiceNotFoundException(typeof (PackagingHelper).FullName);
    }

    /// <summary>Проверить инициализацию</summary>
    public virtual void CheckInitialized()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!this._initialized)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:
      throw new InvalidOperationException(EleWise.ELMA.SR.T((string) PackageService.rXNSAoB2CbEfxDC3JZV0(1218962250 ^ 1218892160)));
    }

    /// <summary>Имя (идентификатор) текущего компонента</summary>
    public string ComponentName
    {
      get => this.\u003CComponentName\u003Ek__BackingField;
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
              this.\u003CComponentName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 0 : 0;
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

    /// <summary>
    /// Если True, то для выполнения операций используется консоль в неинтерактивном режиме.
    /// Если False - менеджер в интерактивном режиме.
    /// По умолчанию True.
    /// </summary>
    public bool UseConsole
    {
      get => this.\u003CUseConsole\u003Ek__BackingField;
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
              this.\u003CUseConsole\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 0 : 0;
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

    /// <summary>Настройки пакетной системы</summary>
    public PackagingSettings Settings => this._settings;

    /// <summary>Получить путь до локального репозитория с пакетами</summary>
    public string LocalRepositoryPath
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.CheckInitialized();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_2:
        return (string) PackageService.EZ060nB2icj1kHnMeiSu((object) this._settings);
      }
    }

    /// <summary>
    /// Получить информацию о пакетах, установленных в текущий компонент
    /// </summary>
    /// <returns>Информация о пакетах</returns>
    public IEnumerable<ElmaPackageInfo> GetInstalledPackagesInfos()
    {
      this.CheckInitialized();
      return (IEnumerable<ElmaPackageInfo>) this.GetComponent().GetInstalledPackagesInfo().Where<PackageInfo>((Func<PackageInfo, bool>) (pi => pi.Package != null)).Select<PackageInfo, ElmaPackageInfo>((Func<PackageInfo, ElmaPackageInfo>) (pi =>
      {
        // ISSUE: reference to a compiler-generated method
        return new ElmaPackageInfo(pi.Package)
        {
          Package = (IPackage) PackageService.\u003C\u003Ec.Co3WlbQV5iND0y4CbYMM((object) pi)
        };
      })).ToArray<ElmaPackageInfo>();
    }

    /// <summary>Получить текущий компонент</summary>
    /// <returns></returns>
    public IElmaComponent GetComponent()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (PackageService.OFHPs6B2RTdAQsKtufjk((object) this.ComponentName))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      throw new InvalidOperationException((string) PackageService.JMhBonB2qBe8vZDoQIo6(PackageService.rXNSAoB2CbEfxDC3JZV0(-1837662597 ^ -1837740691)));
label_5:
      return (IElmaComponent) PackageService.RNHLq0B2KdwwoiLFvRM3((object) this, (object) this.ComponentName);
    }

    /// <summary>Возвращает количество пакетов с фильтром по умолчанию</summary>
    /// <returns>Количество пакетов</returns>
    public long Count() => this.Count(this.GetDefaultFilter());

    /// <summary>Возвращает количество пакетов по фильтру</summary>
    /// <param name="filter">Фильтр</param>
    /// <returns>Количество пакетов по фильтру</returns>
    public long Count(PackageFilter filter) => (long) this.Find(filter).Count<PackageDescription>();

    /// <summary>Найти пакеты в соответствии с параметрами выборки</summary>
    /// <param name="fetchOptions">Параметры выборки</param>
    /// <returns>Список найденных пакетов</returns>
    public IEnumerable<PackageDescription> Find(FetchOptions fetchOptions) => this.Find((PackageFilter) null, fetchOptions);

    /// <summary>
    /// Найти пакеты в соответствии с фильтром и параметрами выборки
    /// </summary>
    /// <param name="filter">Фильтр</param>
    /// <param name="fetchOptions">Параметры выборки</param>
    /// <returns>Список найденных сущностей</returns>
    public IEnumerable<PackageDescription> Find(PackageFilter filter, FetchOptions fetchOptions)
    {
      IEnumerable<PackageDescription> packages = this.Find(filter);
      return fetchOptions == (FetchOptions) null ? packages : (IEnumerable<PackageDescription>) PackageService.ApplySorting(packages, fetchOptions).Skip<PackageDescription>(fetchOptions.FirstResult).Take<PackageDescription>(fetchOptions.MaxResults).ToList<PackageDescription>();
    }

    /// <summary>Найти сущности в соответствии с фильтром</summary>
    /// <param name="filter">Фильтр</param>
    /// <returns>Список найденных пакетов</returns>
    public IEnumerable<PackageDescription> Find(PackageFilter filter)
    {
      this.CheckInitialized();
      if (filter == null)
        filter = this.GetDefaultFilter();
      IElmaComponent component = this.GetComponent();
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      List<IPackage> installedPackages = component.GetInstalledPackagesInfo().Where<PackageInfo>((Func<PackageInfo, bool>) (pi => PackageService.\u003C\u003Ec.Co3WlbQV5iND0y4CbYMM((object) pi) != null)).Select<PackageInfo, IPackage>((Func<PackageInfo, IPackage>) (pi => (IPackage) PackageService.\u003C\u003Ec.Co3WlbQV5iND0y4CbYMM((object) pi))).ToList<IPackage>();
      // ISSUE: reference to a compiler-generated method
      return this.FilterPackages((filter == null || !filter.IncludeIncompatiblePackages ? component.GetAvailablePackagesInfo() : component.GetPackagesInfo()).Where<PackageInfo>((Func<PackageInfo, bool>) (pi => PackageService.\u003C\u003Ec.Co3WlbQV5iND0y4CbYMM((object) pi) != null)).Select<PackageInfo, PackageDescription>((Func<PackageInfo, PackageDescription>) (pi =>
      {
        int num = 2;
        PackageInfo pi1;
        while (true)
        {
          switch (num)
          {
            case 1:
              pi1 = pi;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
              continue;
            case 2:
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 1;
              continue;
            default:
              goto label_3;
          }
        }
label_3:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        return new PackageDescription(installedPackages.FirstOrDefault<IPackage>((Func<IPackage, bool>) (p => PackageService.\u003C\u003Ec__DisplayClass24_1.TrOU92QSX4J8O9d6e0md(PackageService.\u003C\u003Ec__DisplayClass24_1.MqhHXyQSqVoJGgYjMx9A((object) p), PackageService.\u003C\u003Ec__DisplayClass24_1.fTm7jrQSK5ZHCHSpMMup((object) pi1)))), (IPackage) PackageService.\u003C\u003Ec__DisplayClass24_0.Rm81TBQSVfmc0KKMpFRj((object) pi1));
      })), filter);
    }

    /// <summary>Найти все пакеты</summary>
    /// <returns>Список найденных пакетов</returns>
    public IEnumerable<PackageDescription> FindAll() => this.Find((PackageFilter) null, (FetchOptions) null);

    /// <summary>Получить файлы компонентов из папки конфигурации ELMA</summary>
    /// <returns></returns>
    public IEnumerable<ElmaStoreComponentFile> GetConfigurationComponentFiles()
    {
      ElmaStoreComponentRepository componentsRepository = this.GetComponent()?.GetConfigurationStoreComponentsRepository();
      return componentsRepository == null ? (IEnumerable<ElmaStoreComponentFile>) new ElmaStoreComponentFile[0] : componentsRepository.GetComponents();
    }

    /// <summary>Скопировать файл компонента в локальный репозиторий</summary>
    /// <param name="componentFile"></param>
    public void UnpackComponentFileToLocal(ElmaStoreComponentFile componentFile)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (componentFile != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          case 2:
            goto label_5;
          case 3:
            goto label_2;
          default:
            PackageService.eQ9VP9B2X9AafdLZERk6((object) componentFile, (object) this.LocalRepositoryPath);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 2 : 3;
            continue;
        }
      }
label_2:
      return;
label_5:
      throw new ArgumentNullException((string) PackageService.rXNSAoB2CbEfxDC3JZV0(-1380439818 << 3 ^ 1841329402));
    }

    /// <summary>
    /// Получить информацию об установленных компонентах ELMA Store в текущий компонент ELMA
    /// </summary>
    /// <param name="forRuntime">Формировать список на основании информации, сохраненной в БД</param>
    /// <returns></returns>
    public IEnumerable<IStoreComponentInfo> GetStoreComponentsInfo(bool forRuntime)
    {
      if (!this.Initialized)
        return (IEnumerable<IStoreComponentInfo>) new IStoreComponentInfo[0];
      IElmaComponent packagingComponent = this.GetComponent();
      if (packagingComponent == null)
        return (IEnumerable<IStoreComponentInfo>) new IStoreComponentInfo[0];
      ElmaStoreComponentRepository componentsRepository = packagingComponent != null ? packagingComponent.GetConfigurationStoreComponentsRepository() : (ElmaStoreComponentRepository) null;
      string source1 = componentsRepository?.Source;
      DateTime? nullable1 = source1 == null || !Directory.Exists(source1) ? new DateTime?() : new DateTime?(Directory.GetLastWriteTime(source1));
      string source2 = this._helper == null || this._helper.LocalRepository == null ? (string) null : this._helper.LocalRepository.Source;
      DateTime? nullable2 = source2 == null || !Directory.Exists(source2) ? new DateTime?() : new DateTime?(Directory.GetLastWriteTime(source2));
      if (!this._cfgComponentsLastWriteTime.HasValue && nullable1.HasValue || this._cfgComponentsLastWriteTime.HasValue && nullable1.HasValue && this._cfgComponentsLastWriteTime.Value != nullable1.Value || !this._componentsLastWriteTime.HasValue && nullable2.HasValue || this._componentsLastWriteTime.HasValue && nullable2.HasValue && this._componentsLastWriteTime.Value != nullable2.Value)
      {
        packagingComponent.UnpackPackagesFromComponents((IEnumerable<string>) ComponentManager.Current.LicenseManager.GetActivationKeys().Select<KeyValuePair<Guid, string>, string>((Func<KeyValuePair<Guid, string>, string>) (p => p.Value)).ToArray<string>(), new Func<DateTime?>(ComponentManager.Current.ModuleManager.GetMainLicensedUnitExpiration));
        this._cfgComponentsLastWriteTime = nullable1;
        this._componentsLastWriteTime = nullable2;
      }
      IEnumerable<PackageDescription> packageDescriptors = this.Find(new PackageFilter()
      {
        Level = PackageLevel.All,
        IncludeIncompatiblePackages = true
      });
      // ISSUE: reference to a compiler-generated method
      List<PackageDescription> compatiblePackageDescriptors = packageDescriptors.Where<PackageDescription>((Func<PackageDescription, bool>) (d => packagingComponent.IsCompatible((ElmaPackageMetadata) PackageService.\u003C\u003Ec__DisplayClass28_0.DgDvmnQS2weuME4p8NcX((object) d)))).ToList<PackageDescription>();
      List<PackageDescription> elmaPackageDescriptors = this.FilterElmaPackageDescriptors(packageDescriptors);
      // ISSUE: reference to a compiler-generated method
      HashSet<string> hashSet = packagingComponent.GetInstalledPackagesInfo().SelectMany<PackageInfo, PackageUninstallDependency>((Func<PackageInfo, IEnumerable<PackageUninstallDependency>>) (info => info.Package.UninstallDependencies.EmptyIfNull<PackageUninstallDependency>())).Select<PackageUninstallDependency, string>((Func<PackageUninstallDependency, string>) (dep => (string) PackageService.\u003C\u003Ec.LrPhDAQVjkyMGfwVMkFU((object) dep))).ToHashSet<string>();
      IModuleManager moduleManager = ComponentManager.Current.ModuleManager;
      List<IModule> moduleList = new List<IModule>();
      List<IStoreComponentInfo> source3 = new List<IStoreComponentInfo>();
      List<Tuple<ElmaStoreComponentManifest, ElmaStoreComponentFile>> manifestWithFiles = new List<Tuple<ElmaStoreComponentManifest, ElmaStoreComponentFile>>();
      IEnumerable<ElmaStoreComponentManifest> installedManifests = forRuntime ? moduleManager.GetInstalledComponentManifests() : (IEnumerable<ElmaStoreComponentManifest>) null;
      if (installedManifests != null)
      {
        foreach (ElmaStoreComponentManifest componentManifest in installedManifests)
          manifestWithFiles.Add(new Tuple<ElmaStoreComponentManifest, ElmaStoreComponentFile>(componentManifest, (ElmaStoreComponentFile) null));
      }
      Action<IEnumerable<ElmaStoreComponentFile>> action = (Action<IEnumerable<ElmaStoreComponentFile>>) (components =>
      {
        foreach (ElmaStoreComponentFile component in components)
        {
          if (!(component.Id == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852870364)))
          {
            ElmaStoreComponentFile component1 = component;
            Tuple<ElmaStoreComponentManifest, ElmaStoreComponentFile> tuple = manifestWithFiles.FirstOrDefault<Tuple<ElmaStoreComponentManifest, ElmaStoreComponentFile>>((Func<Tuple<ElmaStoreComponentManifest, ElmaStoreComponentFile>, bool>) (t => t.Item1.Id == component1.Id && t.Item1.SemanticVersion.Equals(component1.Version)));
            if (tuple == null)
              manifestWithFiles.Add(new Tuple<ElmaStoreComponentManifest, ElmaStoreComponentFile>(component.Manifest, component));
            else if (tuple.Item2 == null)
            {
              manifestWithFiles.Remove(tuple);
              manifestWithFiles.Add(new Tuple<ElmaStoreComponentManifest, ElmaStoreComponentFile>(tuple.Item1, component));
            }
          }
        }
      });
      IEnumerable<ElmaStoreComponentFile> components1 = this._serverComponentsRepository.GetComponents();
      action(components1);
      IEnumerable<ElmaStoreComponentFile> components2 = componentsRepository?.GetComponents();
      if (components2 != null)
        action(components2);
      foreach (IGrouping<string, Tuple<ElmaStoreComponentManifest, ElmaStoreComponentFile>> grouping in manifestWithFiles.GroupBy<Tuple<ElmaStoreComponentManifest, ElmaStoreComponentFile>, string>((Func<Tuple<ElmaStoreComponentManifest, ElmaStoreComponentFile>, string>) (c => c.Item1.Id), (IEqualityComparer<string>) StringComparer.CurrentCultureIgnoreCase))
      {
        IGrouping<string, Tuple<ElmaStoreComponentManifest, ElmaStoreComponentFile>> componentVersions = grouping;
        List<Tuple<ElmaStoreComponentManifest, ElmaStoreComponentFile>> list = componentVersions.OrderByDescending<Tuple<ElmaStoreComponentManifest, ElmaStoreComponentFile>, SemanticVersion>((Func<Tuple<ElmaStoreComponentManifest, ElmaStoreComponentFile>, SemanticVersion>) (c => c.Item1.SemanticVersion)).ToList<Tuple<ElmaStoreComponentManifest, ElmaStoreComponentFile>>();
        Tuple<ElmaStoreComponentManifest, ElmaStoreComponentFile> tuple1 = list.FirstOrDefault<Tuple<ElmaStoreComponentManifest, ElmaStoreComponentFile>>((Func<Tuple<ElmaStoreComponentManifest, ElmaStoreComponentFile>, bool>) (c =>
        {
          if (installedManifests != null && installedManifests.Contains<ElmaStoreComponentManifest>(c.Item1))
            return true;
          ElmaStoreComponentFile storeComponentFile = c.Item2;
          if (storeComponentFile == null || storeComponentFile.Manifest.Packages.Count == 0)
            return false;
          foreach (PackageManifest package in storeComponentFile.Manifest.Packages)
          {
            PackageManifest packageRef = package;
            if (packagingComponent.IsCompatible(new ElmaPackageMetadata(packageRef.Tags)))
            {
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              PackageDescription packageDescription = packageDescriptors.FirstOrDefault<PackageDescription>((Func<PackageDescription, bool>) (p => PackageService.\u003C\u003Ec__DisplayClass28_3.dMGZ1uQSxanmbF0OWGTZ(PackageService.\u003C\u003Ec__DisplayClass28_3.OZrPXjQSAhfahLPmtmU6((object) p), PackageService.\u003C\u003Ec__DisplayClass28_3.p7AdpgQS743KY9Y3Sn3g((object) packageRef))));
              if (packageDescription == null)
              {
                EleWise.ELMA.Logging.Logger.Log.Error((object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(333888594 ^ 1075625116 ^ 1409250748), (object) packageRef.Id, (object) componentVersions.Key));
                return false;
              }
              if (elmaPackageDescriptors.Contains(packageDescription))
              {
                if (!packageDescription.IsInstalled || packageDescription.InstalledVersion == (SemanticVersion) null)
                {
                  if (compatiblePackageDescriptors.Contains(packageDescription))
                    return false;
                }
                else if (packageRef.SemanticVersion != (SemanticVersion) null && packageRef.SemanticVersion > packageDescription.InstalledVersion)
                  return false;
              }
            }
          }
          return true;
        }));
        Tuple<ElmaStoreComponentManifest, ElmaStoreComponentFile> tuple2 = list.FirstOrDefault<Tuple<ElmaStoreComponentManifest, ElmaStoreComponentFile>>((Func<Tuple<ElmaStoreComponentManifest, ElmaStoreComponentFile>, bool>) (c =>
        {
          if (forRuntime)
            return true;
          ElmaStoreComponentFile storeComponentFile = c.Item2;
          if (storeComponentFile == null || storeComponentFile.Manifest.Packages.Count == 0)
            return false;
          foreach (PackageManifest package in storeComponentFile.Manifest.Packages)
          {
            PackageManifest packageRef = package;
            if (packagingComponent.IsCompatible(new ElmaPackageMetadata(packageRef.Tags)))
            {
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              PackageDescription packageDescription = packageDescriptors.FirstOrDefault<PackageDescription>((Func<PackageDescription, bool>) (p => PackageService.\u003C\u003Ec__DisplayClass28_4.XUY3nRQSdwHb4kMiwgpP(PackageService.\u003C\u003Ec__DisplayClass28_4.SQs1oQQSJ29E99N5mg2k((object) p), PackageService.\u003C\u003Ec__DisplayClass28_4.uK8AaPQS9QG3Pr8YMyeD((object) packageRef))));
              if (packageDescription == null)
              {
                EleWise.ELMA.Logging.Logger.Log.Error((object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1839087379 - 334718690 ^ 2120953721), (object) packageRef.Id, (object) componentVersions.Key));
                return false;
              }
              if (elmaPackageDescriptors.Contains(packageDescription))
                compatiblePackageDescriptors.Contains(packageDescription);
            }
          }
          return true;
        }));
        if (tuple1 != null || tuple2 != null)
        {
          bool isDeprecated = hashSet.Contains<string>(componentVersions.Key, (IEqualityComparer<string>) StringComparer.CurrentCultureIgnoreCase);
          ManifestStoreComponentInfo storeComponentInfo = new ManifestStoreComponentInfo(tuple1?.Item1, tuple2?.Item1, tuple1?.Item2, tuple2?.Item2, isDeprecated);
          List<string> source4 = new List<string>();
          if (tuple1 != null)
            source4.AddRange(tuple1.Item1.Packages.Select<PackageManifest, string>((Func<PackageManifest, string>) (p => p.Id)));
          if (tuple2 != null)
          {
            // ISSUE: reference to a compiler-generated method
            source4.AddRange(tuple2.Item1.Packages.Select<PackageManifest, string>((Func<PackageManifest, string>) (p => (string) PackageService.\u003C\u003Ec.KMaGCAQVYIaJeCygW6IB((object) p))));
          }
          foreach (string str in source4.Distinct<string>())
          {
            string packageId = str;
            // ISSUE: reference to a compiler-generated method
            PackageDescription packageDescription = compatiblePackageDescriptors.FirstOrDefault<PackageDescription>((Func<PackageDescription, bool>) (p => ((string) PackageService.\u003C\u003Ec__DisplayClass28_5.NdkuSkQSjC5UOC6oo9TC((object) p)).Equals(packageId)));
            if (packageDescription != null)
            {
              storeComponentInfo.Packages.Add(packageDescription);
              if (elmaPackageDescriptors.Contains(packageDescription))
                storeComponentInfo.ElmaPackages.Add(packageDescription);
              IModule moduleById = moduleManager.FindModuleById(packageDescription.Id);
              if (moduleById != null)
                storeComponentInfo.Modules.Add(moduleById);
            }
          }
          source3.Add((IStoreComponentInfo) storeComponentInfo);
        }
      }
      foreach (PackageDescription packageDescription in compatiblePackageDescriptors)
      {
        PackageDescription packageDescriptor = packageDescription;
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        if (packageDescriptor.Type == ElmaPackageType.Module && !source3.Any<IStoreComponentInfo>((Func<IStoreComponentInfo, bool>) (i => i.AllPackages.Any<PackageDescription>((Func<PackageDescription, bool>) (p => PackageService.\u003C\u003Ec__DisplayClass28_6.B8ZLx1QScGGSI4OwhgMg(PackageService.\u003C\u003Ec__DisplayClass28_6.oTHkYYQSsPRBXdccPWwp((object) p), PackageService.\u003C\u003Ec__DisplayClass28_6.oTHkYYQSsPRBXdccPWwp((object) packageDescriptor)))))))
        {
          bool isDeprecated = hashSet.Contains<string>(packageDescriptor.Id, (IEqualityComparer<string>) StringComparer.CurrentCultureIgnoreCase);
          PackageStoreComponentInfo storeComponentInfo = new PackageStoreComponentInfo(packageDescriptor, isDeprecated);
          IModule moduleById = moduleManager.FindModuleById(packageDescriptor.Id);
          if (moduleById != null)
            storeComponentInfo.Modules.Add(moduleById);
          source3.Add((IStoreComponentInfo) storeComponentInfo);
        }
      }
      if (moduleManager.MainApplication != null)
      {
        foreach (IModule extensionModule in moduleManager.MainApplication.ExtensionModules)
        {
          IModule module = extensionModule;
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          if (module.ModuleType == ModuleType.Default && !source3.Any<IStoreComponentInfo>((Func<IStoreComponentInfo, bool>) (i => i.AllModules.Any<IModule>((Func<IModule, bool>) (m => PackageService.\u003C\u003Ec__DisplayClass28_7.n3HYG3QioKByGnGREKBe(PackageService.\u003C\u003Ec__DisplayClass28_7.Jutqm5QiWeOQiSlSsTTi((object) m), (object) module.Id))))))
          {
            bool isDeprecated = hashSet.Contains<string>(module.Id, (IEqualityComparer<string>) StringComparer.CurrentCultureIgnoreCase);
            AssemblyStoreComponentInfo storeComponentInfo = new AssemblyStoreComponentInfo(module, isDeprecated);
            source3.Add((IStoreComponentInfo) storeComponentInfo);
          }
        }
      }
      // ISSUE: reference to a compiler-generated method
      return (IEnumerable<IStoreComponentInfo>) source3.OrderByDescending<IStoreComponentInfo, int>((Func<IStoreComponentInfo, int>) (c => this.GetComponentTypeOrder(PackageService.\u003C\u003Ec__DisplayClass28_0.rIN4ivQSe9U73EQ7yAfJ((object) c)))).ThenBy<IStoreComponentInfo, string>((Func<IStoreComponentInfo, string>) (c =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              if (PackageService.\u003C\u003Ec.U7MdIhQVUkpTjapPc9eC(PackageService.\u003C\u003Ec.HwHR11QVLjgjEIyeamZJ((object) c)))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            default:
              goto label_4;
          }
        }
label_4:
        // ISSUE: reference to a compiler-generated method
        return (string) PackageService.\u003C\u003Ec.Hipu3QQVslxaLwiJGd1G((object) c);
label_5:
        // ISSUE: reference to a compiler-generated method
        return EleWise.ELMA.SR.T((string) PackageService.\u003C\u003Ec.HwHR11QVLjgjEIyeamZJ((object) c));
      })).ToList<IStoreComponentInfo>();
    }

    /// <summary>
    /// Сохранить файл компонента ELMA Store в папку конфигурации
    /// </summary>
    /// <param name="manifest"></param>
    /// <param name="fileName"></param>
    public void SaveStoreComponentFileToConfiguration(
      ElmaStoreComponentManifest manifest,
      string fileName,
      string unpackedPackagesFolder = null)
    {
      int num1 = 11;
      while (true)
      {
        string str1;
        string str2;
        string fileName1;
        string[] files;
        int index;
        string path;
        string fileName2;
        IElmaComponent component;
        FileStream fileStream1;
        FileStream fileStream2;
        switch (num1)
        {
          case 1:
            if (PackageService.OFHPs6B2RTdAQsKtufjk((object) str1))
            {
              num1 = 12;
              continue;
            }
            goto case 29;
          case 2:
            try
            {
              FS.CreateFile(fileName2, (Stream) fileStream1);
              int num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
                num2 = 0;
              switch (num2)
              {
                default:
                  goto label_59;
              }
            }
            finally
            {
              if (fileStream1 != null)
              {
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
                  num3 = 0;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_41;
                    default:
                      PackageService.qMOLB8B23JG6o9TjeWFC((object) fileStream1);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 1 : 1;
                      continue;
                  }
                }
              }
label_41:;
            }
          case 3:
          case 12:
label_15:
            if (PackageService.OFHPs6B2RTdAQsKtufjk((object) unpackedPackagesFolder))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 31 : 22;
              continue;
            }
            goto case 19;
          case 4:
            goto label_17;
          case 5:
label_59:
            ++index;
            num1 = 36;
            continue;
          case 6:
            if (PackageService.PirI1HB2PvtDmSbC6anK((object) fileName2))
            {
              num1 = 38;
              continue;
            }
            goto case 20;
          case 7:
            goto label_69;
          case 8:
            if (!PackageService.OFHPs6B2RTdAQsKtufjk((object) str1))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 1 : 1;
              continue;
            }
            goto label_44;
          case 9:
          case 23:
            str2 = (string) PackageService.hVxC57B2OBYlbMFEpE67((object) manifest) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1033719030 - 2012070891 ^ -978349105) + (string) PackageService.TZNUo5B22AI0CZUsPf2s((object) manifest) + (string) PackageService.rXNSAoB2CbEfxDC3JZV0(-87337865 ^ -87348939);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 3 : 18;
            continue;
          case 10:
            goto label_66;
          case 11:
            if (manifest == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 4 : 10;
              continue;
            }
            if (!PackageService.OFHPs6B2RTdAQsKtufjk((object) fileName))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 17 : 6;
              continue;
            }
            goto label_17;
          case 13:
            if (PackageService.PirI1HB2PvtDmSbC6anK((object) fileName1))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 14 : 11;
              continue;
            }
            break;
          case 14:
            PackageService.HrYUQaB21oefkQB02m8x((object) fileName1, false, (object) null);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 0;
            continue;
          case 15:
          case 36:
            if (index < files.Length)
            {
              num1 = 33;
              continue;
            }
            goto label_56;
          case 16:
            if (component != null)
            {
              num1 = 35;
              continue;
            }
            goto label_60;
          case 17:
            component = this.GetComponent();
            num1 = 16;
            continue;
          case 18:
            fileName1 = (string) PackageService.RFAa64B2vsw36xTj25Uj((object) str1, (object) str2);
            num1 = 32;
            continue;
          case 19:
            if (!PackageService.yx6quxB2kyxRAb9HogjX((object) unpackedPackagesFolder))
            {
              num1 = 24;
              continue;
            }
            goto case 21;
          case 20:
            fileStream1 = (FileStream) PackageService.eFepEyB2NsI2vS5U0DYb((object) path);
            num1 = 2;
            continue;
          case 21:
            files = Directory.GetFiles(unpackedPackagesFolder, (string) PackageService.rXNSAoB2CbEfxDC3JZV0(1113862659 ^ 1113915755));
            num1 = 25;
            continue;
          case 22:
          case 33:
            path = files[index];
            num1 = 37;
            continue;
          case 24:
            goto label_29;
          case 25:
            index = 0;
            num1 = 15;
            continue;
          case 26:
            try
            {
              FS.CreateFile(fileName1, (Stream) fileStream2);
              int num4 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
                num4 = 0;
              switch (num4)
              {
                default:
                  goto label_15;
              }
            }
            finally
            {
              if (fileStream2 != null)
              {
                int num5 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
                  num5 = 1;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      fileStream2.Dispose();
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_58;
                  }
                }
              }
label_58:;
            }
          case 27:
            if (!PackageService.gXXZ30B2eHdbtqumVWvd((object) path, (object) fileName2, StringComparison.CurrentCultureIgnoreCase))
            {
              num1 = 6;
              continue;
            }
            goto case 5;
          case 28:
            goto label_32;
          case 29:
            if (PackageService.yx6quxB2kyxRAb9HogjX((object) str1))
            {
              num1 = 9;
              continue;
            }
            goto case 30;
          case 30:
            PackageService.tbFllNB2nlWQHUCSopP2((object) str1);
            num1 = 23;
            continue;
          case 31:
            goto label_51;
          case 32:
            if (!PackageService.gXXZ30B2eHdbtqumVWvd((object) fileName, (object) fileName1, StringComparison.CurrentCultureIgnoreCase))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 13 : 12;
              continue;
            }
            goto case 3;
          case 34:
            goto label_50;
          case 35:
            str1 = (string) PackageService.HulRU3B2T4PJyCICDVsr((object) component);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 8 : 3;
            continue;
          case 37:
            fileName2 = (string) PackageService.RFAa64B2vsw36xTj25Uj((object) str1, (object) Path.GetFileName(path));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 16 : 27;
            continue;
          case 38:
            PackageService.HrYUQaB21oefkQB02m8x((object) fileName2, false, (object) null);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 20 : 10;
            continue;
        }
        fileStream2 = (FileStream) PackageService.eFepEyB2NsI2vS5U0DYb((object) fileName);
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 26 : 8;
      }
label_69:
      return;
label_29:
      return;
label_32:
      return;
label_51:
      return;
label_50:
      return;
label_56:
      return;
label_44:
      return;
label_17:
      throw new ArgumentNullException((string) PackageService.rXNSAoB2CbEfxDC3JZV0(-812025778 ^ -812054956));
label_60:
      return;
label_66:
      throw new ArgumentNullException((string) PackageService.rXNSAoB2CbEfxDC3JZV0(323422137 << 2 ^ 1293705442));
    }

    /// <summary>Есть ли для указанного пакета локальная иконка</summary>
    /// <param name="id"></param>
    /// <param name="version"></param>
    /// <returns></returns>
    public bool HasPackageLocalIcon(string id, string version) => this.GetPackageIconFileName(id, version) != null;

    /// <summary>Есть ли для указанного пакета локальная иконка</summary>
    /// <param name="id">Идентификатор пакета</param>
    /// <param name="version">Версия пакета</param>
    /// <returns></returns>
    public string GetPackageIconFileName(string id, string version)
    {
      int num1 = 4;
      string fileNameNonCached;
      while (true)
      {
        int num2 = num1;
        string key;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_6;
            case 2:
              goto label_14;
            case 3:
              goto label_8;
            case 4:
              if (id == null)
              {
                num2 = 3;
                continue;
              }
              if (!PackageService.OFHPs6B2RTdAQsKtufjk((object) id))
              {
                key = (string) PackageService.cctrCjB2pAbZUIrje4AF((object) id, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(979449278 ^ 979445996), (object) version);
                num2 = 7;
                continue;
              }
              goto label_10;
            case 5:
              this._packagesIconFileNames[key] = fileNameNonCached;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 0 : 0;
              continue;
            case 6:
              goto label_5;
            case 7:
              if (!this._packagesIconFileNames.TryGetValue(key, out fileNameNonCached))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 1 : 1;
                continue;
              }
              goto label_5;
            default:
              goto label_7;
          }
        }
label_6:
        fileNameNonCached = this.GetPackageIconFileNameNonCached(id, version);
        num1 = 5;
        continue;
label_10:
        num1 = 2;
      }
label_5:
      return fileNameNonCached;
label_7:
      return fileNameNonCached;
label_8:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138083070));
label_14:
      throw new ArgumentException((string) PackageService.rXNSAoB2CbEfxDC3JZV0(1142330761 ^ 1541959139 ^ 536857576));
    }

    /// <summary>Получить пакет по идентификатору и версии</summary>
    /// <param name="id">Идентификатор пакета</param>
    /// <param name="version">Версия пакета</param>
    /// <returns></returns>
    public IPackage GetPackage(string id, string version)
    {
      int num1 = 19;
      IPackage package;
      while (true)
      {
        int num2 = num1;
        IElmaComponent component;
        SemanticVersion semanticVersion;
        LocalPackageRepository packageRepository;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (PackageService.z1xRNDB26eJrsbEvqFHa(PackageService.vWmE6ZB24OJSGSHm8iLS((object) this._settings)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 4 : 0;
                continue;
              }
              goto case 7;
            case 2:
              if (component == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 1 : 1;
                continue;
              }
              goto case 15;
            case 3:
              if (package == null)
              {
                num2 = 5;
                continue;
              }
              goto label_24;
            case 4:
            case 10:
              goto label_3;
            case 5:
              component = this.GetComponent();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 2 : 2;
              continue;
            case 6:
              goto label_22;
            case 7:
              package = (IPackage) PackageService.bn1n2QB2DWOn5d4Rcy6d(PackageService.SGgbGkB2HKMoSVDJ5DaE((object) PackageRepositoryFactory.Default, (object) this._settings.Repository), (object) id, (object) semanticVersion);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 10 : 3;
              continue;
            case 8:
              goto label_19;
            case 9:
              package = (IPackage) PackageService.Fj3CPyB2wbTLI5x8Aqk9((object) packageRepository, (object) id, (object) semanticVersion);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 9 : 14;
              continue;
            case 11:
              if (PackageService.OFHPs6B2RTdAQsKtufjk((object) version))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 3 : 6;
                continue;
              }
              PackageService.dMoin1B2asOnpDvd8xnD((object) this);
              num2 = 16;
              continue;
            case 12:
              goto label_28;
            case 13:
              if (packageRepository != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 4 : 9;
                continue;
              }
              goto case 1;
            case 14:
              if (package == null)
                goto case 1;
              else
                goto label_9;
            case 15:
              packageRepository = (LocalPackageRepository) PackageService.LlFdgHB2tYpvPMb6ShmA((object) component);
              num2 = 13;
              continue;
            case 16:
              semanticVersion = new SemanticVersion(version);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 20 : 4;
              continue;
            case 17:
              goto label_32;
            case 18:
              if (PackageService.OFHPs6B2RTdAQsKtufjk((object) id))
              {
                num2 = 12;
                continue;
              }
              if (version != null)
              {
                num2 = 11;
                continue;
              }
              goto label_19;
            case 19:
              if (id != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 3 : 18;
                continue;
              }
              goto label_10;
            case 20:
              package = (IPackage) PackageService.bn1n2QB2DWOn5d4Rcy6d((object) this._localRepository, (object) id, (object) semanticVersion);
              num2 = 3;
              continue;
            case 21:
              goto label_10;
            default:
              goto label_24;
          }
        }
label_9:
        num1 = 17;
      }
label_3:
      return package;
label_10:
      throw new ArgumentNullException((string) PackageService.rXNSAoB2CbEfxDC3JZV0(-710283084 ^ -537863435 ^ 173545787));
label_19:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1021410165 ^ 1021441793));
label_22:
      throw new ArgumentException((string) PackageService.rXNSAoB2CbEfxDC3JZV0(-675505729 ^ -675435997));
label_24:
      return package;
label_28:
      throw new ArgumentException((string) PackageService.rXNSAoB2CbEfxDC3JZV0(1232639661 >> 3 ^ 154018135));
label_32:
      return package;
    }

    /// <summary>Выполнить операции с пакетами в текущем компоненте</summary>
    /// <param name="operations">Список операций</param>
    public void ExecuteOperations(IEnumerable<PackageOperationInfo> operations) => this.ExecuteOperations(operations, new PackageOperationOptions());

    /// <summary>Выполнить операции с пакетами в текущем компоненте</summary>
    /// <param name="operations">Список операций</param>
    /// <param name="options">Опции</param>
    public void ExecuteOperations(
      IEnumerable<PackageOperationInfo> operations,
      PackageOperationOptions options)
    {
      this.ExecuteOperationsWithResult(operations, options);
    }

    /// <summary>Выполнить операции с пакетами в текущем компоненте</summary>
    /// <param name="operations">Список операций</param>
    /// <param name="options">Опции</param>
    private bool ExecuteOperationsWithResult(
      IEnumerable<PackageOperationInfo> operations,
      PackageOperationOptions options)
    {
      if (operations == null)
        return false;
      this.CheckInitialized();
      List<string> stringList1 = new List<string>();
      // ISSUE: reference to a compiler-generated method
      List<PackageInfo> list1 = operations.Where<PackageOperationInfo>((Func<PackageOperationInfo, bool>) (op =>
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              if (PackageService.\u003C\u003Ec.Lr4v2mQVz24FVTfwqCog((object) op) == PackageOperationType.Install)
              {
                num = 3;
                continue;
              }
              goto label_4;
            case 2:
              // ISSUE: reference to a compiler-generated method
              if (PackageService.\u003C\u003Ec.fkUqDRQVcguISBYaQj7c((object) op) != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 1 : 1;
                continue;
              }
              goto label_6;
            case 3:
              goto label_5;
            default:
              goto label_4;
          }
        }
label_4:
        // ISSUE: reference to a compiler-generated method
        return PackageService.\u003C\u003Ec.Lr4v2mQVz24FVTfwqCog((object) op) == PackageOperationType.Update;
label_5:
        return true;
label_6:
        return false;
      })).Select<PackageOperationInfo, PackageInfo>((Func<PackageOperationInfo, PackageInfo>) (op => (PackageInfo) PackageService.\u003C\u003Ec.fkUqDRQVcguISBYaQj7c((object) op))).ToList<PackageInfo>();
      if (list1.Any<PackageInfo>())
      {
        List<string> stringList2 = new List<string>()
        {
          z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -35917293),
          z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088358390),
          this.ComponentName
        };
        if (!string.IsNullOrEmpty(options.PackageServerUrl))
          stringList2.AddRange((IEnumerable<string>) new string[2]
          {
            z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-306453669 ^ 306524030),
            options.PackageServerUrl
          });
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        stringList2.AddRange(list1.Select<PackageInfo, string>((Func<PackageInfo, string>) (pi => (string) PackageService.\u003C\u003Ec.tdg8nyQSWc1811i1SyaQ((object) pi.Id, !((SemanticVersion) PackageService.\u003C\u003Ec.yKwdEVQSFDhUJPrI9QVT((object) pi) != (SemanticVersion) null) ? (object) "" : PackageService.\u003C\u003Ec.tdg8nyQSWc1811i1SyaQ(PackageService.\u003C\u003Ec.r9V60BQSBqOhtcaRT2C9(-1598106783 - -968262081 ^ -629847952), (object) PackageService.\u003C\u003Ec.yKwdEVQSFDhUJPrI9QVT((object) pi).ToString())))));
        stringList1.Add(this.PrepareCommandLineArguments(stringList2.ToArray()));
      }
      List<PackageInfo> list2 = operations.Where<PackageOperationInfo>((Func<PackageOperationInfo, bool>) (op =>
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_5;
            case 2:
              if (op.Package == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 1 : 1;
                continue;
              }
              goto label_4;
            default:
              goto label_4;
          }
        }
label_4:
        // ISSUE: reference to a compiler-generated method
        return PackageService.\u003C\u003Ec.Lr4v2mQVz24FVTfwqCog((object) op) == PackageOperationType.Uninstall;
label_5:
        return false;
      })).Select<PackageOperationInfo, PackageInfo>((Func<PackageOperationInfo, PackageInfo>) (op => op.Package)).ToList<PackageInfo>();
      if (list2.Any<PackageInfo>())
      {
        List<string> stringList3 = new List<string>()
        {
          z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998486312),
          z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787390793),
          this.ComponentName
        };
        // ISSUE: reference to a compiler-generated method
        stringList3.AddRange(list2.Select<PackageInfo, string>((Func<PackageInfo, string>) (pi => (string) PackageService.\u003C\u003Ec.sYRDNtQSo3Rdb5SymbjQ((object) pi))));
        stringList1.Add(this.PrepareCommandLineArguments(stringList3.ToArray()));
      }
      string fileName = PackageOperationStatus.GenerateFileName(options.UpdatingUid);
      if (stringList1.Any<string>())
      {
        string tempFileName = IOExtensions.GetTempFileName();
        File.WriteAllLines(tempFileName, (IEnumerable<string>) stringList1);
        List<string> stringList4 = new List<string>();
        stringList4.AddRange((IEnumerable<string>) new string[4]
        {
          z2jc63fLkugS1X8Q9N.tE1kD1vbB(~541731958 ^ -541794191),
          z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917256330 ^ 1917202776),
          this.ComponentName,
          z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70061303)
        });
        if (options.StartAfterUpdate)
          stringList4.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-441065788 ^ -2092910478 ^ 1727287976));
        stringList4.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-688192331 - 435440695 ^ -1123578800));
        stringList4.Add(fileName);
        stringList4.Add(tempFileName);
        string contents = string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1642859704 ^ 1642884998), (IEnumerable<string>) stringList1);
        string statusDir = PackagingHelper.GetStatusDir(Path.Combine(this.Settings.Root, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1994213607 >> 4 ^ 124577530)));
        if (!Directory.Exists(statusDir))
          Directory.CreateDirectory(statusDir);
        string path1 = Path.Combine(statusDir, z2jc63fLkugS1X8Q9N.tE1kD1vbB(322893104 - -1992822529 ^ -1979305887));
        string path2 = Path.Combine(statusDir, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1304605005 ^ 1304659413));
        if (File.Exists(path1))
        {
          string str1 = File.ReadAllText(path1);
          string path4 = File.Exists(path2) ? File.ReadAllText(path2) : (string) null;
          string str2 = path4 != null ? Path.Combine(this.Settings.Root, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107900310), z2jc63fLkugS1X8Q9N.tE1kD1vbB(132912447 ^ 132981213), path4) : (string) null;
          PackageOperationStatus statusByFullFileName = string.IsNullOrEmpty(str2) || !File.Exists(str2) ? (PackageOperationStatus) null : PackagingHelper.GetOperationStatusByFullFileName(str2);
          string message = statusByFullFileName == null || statusByFullFileName.Type != PackageOperationStatusType.Error ? (string) null : statusByFullFileName.Message;
          string str3 = contents;
          if (str1.Equals(str3))
          {
            this.Complete();
            if (!string.IsNullOrEmpty(message))
              throw new PackagingException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1350312861 << 3 ^ 2082461674), (object) message));
            throw new PackagingException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(323422137 << 2 ^ 1293757360)));
          }
        }
        File.WriteAllText(path1, contents);
        File.WriteAllText(path2, fileName);
        this.ExecutePackageConsoleOrManager(fileName, stringList4.ToArray(), this.UseConsole);
        return true;
      }
      this._helper.SaveOperationStatus(fileName, new PackageOperationStatus()
      {
        Type = PackageOperationStatusType.Completed,
        Message = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1514961705 ^ 1515015813))
      });
      return false;
    }

    /// <summary>Завершить инициализацию</summary>
    public void Complete()
    {
      int num = 3;
      string str1;
      string str2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_8;
          case 1:
          case 6:
            if (PackageService.PirI1HB2PvtDmSbC6anK((object) str1))
            {
              num = 4;
              continue;
            }
            goto label_2;
          case 2:
            if (!PackageService.PirI1HB2PvtDmSbC6anK((object) str2))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 6 : 4;
              continue;
            }
            goto case 5;
          case 3:
            string statusDir = PackagingHelper.GetStatusDir(Path.Combine(this.Settings.Root, z2jc63fLkugS1X8Q9N.tE1kD1vbB(~538519529 ^ -538449310)));
            str2 = (string) PackageService.RFAa64B2vsw36xTj25Uj((object) statusDir, PackageService.rXNSAoB2CbEfxDC3JZV0(-35995181 ^ -35916413));
            str1 = (string) PackageService.RFAa64B2vsw36xTj25Uj((object) statusDir, PackageService.rXNSAoB2CbEfxDC3JZV0(-1872275253 >> 6 ^ -29316613));
            num = 2;
            continue;
          case 4:
            PackageService.Pi67NPB2AnFLeI9rZ1Eb((object) str1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 0;
            continue;
          case 5:
            PackageService.Pi67NPB2AnFLeI9rZ1Eb((object) str2);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 1;
            continue;
          default:
            goto label_11;
        }
      }
label_8:
      return;
label_11:
      return;
label_2:;
    }

    /// <summary>Установить все доступные обновления</summary>
    /// <param name="updatingUid">Уникальный идентификатор обновления</param>
    public void InstallAllUpdates(Guid updatingUid)
    {
      int num1 = 6;
      while (true)
      {
        int num2 = num1;
        string str;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!PackageService.DAV3WmB27hQhc2jq6M5p((object) this.ComponentName, PackageService.rXNSAoB2CbEfxDC3JZV0(1012087039 ^ 1012100189), StringComparison.CurrentCultureIgnoreCase))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 7 : 3;
                continue;
              }
              goto case 4;
            case 2:
              goto label_8;
            case 3:
              goto label_5;
            case 4:
              str = (string) PackageService.lV9xxvB2xqbOEIoHUIQY((object) str, PackageService.rXNSAoB2CbEfxDC3JZV0(1505778440 - 1981636111 ^ -475805409));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 0;
              continue;
            case 5:
              if (this.ComponentName == null)
              {
                num2 = 8;
                continue;
              }
              goto case 1;
            case 6:
              str = this.ComponentName;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 5 : 5;
              continue;
            default:
              goto label_6;
          }
        }
label_6:
        string statusFileName = (string) PackageService.ejqLmWB20GBmQsoQKXP7(updatingUid);
        num1 = 2;
        continue;
label_8:
        this.ExecutePackageConsoleOrManager(statusFileName, new string[5]
        {
          (string) PackageService.rXNSAoB2CbEfxDC3JZV0(-138018305 ^ -137938977),
          (string) PackageService.rXNSAoB2CbEfxDC3JZV0(712480695 ^ 712418405),
          str,
          (string) PackageService.rXNSAoB2CbEfxDC3JZV0(-1217523399 ^ -1217452777),
          statusFileName
        }, (this.UseConsole ? 1 : 0) != 0);
        num1 = 3;
      }
label_5:;
    }

    /// <summary>
    /// Получить информацию о требуемых операциях с пакетами в текущем компоненте
    /// </summary>
    /// <param name="serverPackages">Информация о пакетах на стороне сервера</param>
    /// <returns></returns>
    public IEnumerable<PackageOperationInfo> GetRequiredOperations(
      IEnumerable<ElmaPackageInfo> serverPackages)
    {
      return this.GetRequiredOperationsGeneric<DesignerComponent>(serverPackages);
    }

    /// <summary>
    /// Получить информацию о требуемых операциях с пакетами в текущем компоненте (для модулей предпросмотра)
    /// </summary>
    /// <param name="serverPackages">Информация о пакетах на стороне сервера</param>
    /// <returns></returns>
    public IEnumerable<PackageOperationInfo> GetRequiredOperationsFilePreview(
      IEnumerable<ElmaPackageInfo> serverPackages)
    {
      return this.GetRequiredOperationsGeneric<FilePreviewCreatorComponent>(serverPackages);
    }

    /// <summary>Получить статус выполнения текущей операции</summary>
    /// <returns></returns>
    public PackageOperationStatus GetCurrentOperationStatus()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            PackageService.dMoin1B2asOnpDvd8xnD((object) this);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return (PackageOperationStatus) PackageService.eRCv1MB2m8j36sbD4cuH((object) this._helper);
    }

    /// <summary>Получить статус выполнения текущей операции</summary>
    /// <param name="updatingUid">Уникальный идентификатор операции</param>
    /// <returns></returns>
    public PackageOperationStatus GetOperationStatus(Guid updatingUid)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            PackageService.dMoin1B2asOnpDvd8xnD((object) this);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return (PackageOperationStatus) PackageService.ihGPqDB2ywy2ehlxS93E((object) this._helper, updatingUid);
    }

    /// <summary>
    /// Сохранить список установленных пакетов текущего компонента в файл
    /// </summary>
    /// <param name="packagesFileName">Имя файла, в который будет сохранен список</param>
    public void SaveConfigurationPackages(string packagesFileName)
    {
      int num1 = 7;
      while (true)
      {
        int num2 = num1;
        string str;
        SingleFileFileSystem singleFileFileSystem;
        IElmaComponent component;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_39;
            case 1:
              singleFileFileSystem = new SingleFileFileSystem(str);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 4 : 1;
              continue;
            case 2:
              goto label_26;
            case 3:
              PackageService.Pi67NPB2AnFLeI9rZ1Eb((object) packagesFileName);
              num2 = 11;
              continue;
            case 4:
              try
              {
                PackageReferenceFile packageReferenceFile = new PackageReferenceFile((IFileSystem) singleFileFileSystem, str);
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
                  num3 = 0;
                IEnumerator<PackageInfo> enumerator;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_10;
                    default:
                      enumerator = component.GetInstalledPackagesInfo().GetEnumerator();
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 0 : 1;
                      continue;
                  }
                }
label_10:
                try
                {
label_14:
                  if (enumerator.MoveNext())
                    goto label_13;
                  else
                    goto label_15;
label_11:
                  PackageInfo current;
                  int num4;
                  while (true)
                  {
                    switch (num4)
                    {
                      case 1:
                        goto label_13;
                      case 2:
                        packageReferenceFile.AddEntry((string) PackageService.QLZ8nDB2MhqDivcWoDol((object) current), (SemanticVersion) PackageService.Y48M0PB2JaJL42ZLbOnV((object) current));
                        num4 = 3;
                        continue;
                      case 3:
                        goto label_14;
                      default:
                        goto label_30;
                    }
                  }
label_13:
                  current = enumerator.Current;
                  num4 = 2;
                  goto label_11;
label_15:
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 0 : 0;
                  goto label_11;
                }
                finally
                {
                  int num5;
                  if (enumerator == null)
                    num5 = 2;
                  else
                    goto label_19;
label_18:
                  switch (num5)
                  {
                    case 1:
                      break;
                    default:
                  }
label_19:
                  PackageService.qMOLB8B23JG6o9TjeWFC((object) enumerator);
                  num5 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
                  {
                    num5 = 0;
                    goto label_18;
                  }
                  else
                    goto label_18;
                }
              }
              finally
              {
                int num6;
                if (singleFileFileSystem == null)
                  num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 1 : 2;
                else
                  goto label_27;
label_24:
                switch (num6)
                {
                  case 1:
                    break;
                  default:
                }
label_27:
                PackageService.qMOLB8B23JG6o9TjeWFC((object) singleFileFileSystem);
                num6 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
                {
                  num6 = 0;
                  goto label_24;
                }
                else
                  goto label_24;
              }
            case 5:
              if (PackageService.PirI1HB2PvtDmSbC6anK((object) packagesFileName))
              {
                num2 = 3;
                continue;
              }
              goto case 11;
            case 6:
              goto label_38;
            case 7:
              PackageService.dMoin1B2asOnpDvd8xnD((object) this);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 1 : 6;
              continue;
            case 8:
              File.Delete(str);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 1 : 0;
              continue;
            case 9:
              str = (string) PackageService.lV9xxvB2xqbOEIoHUIQY((object) packagesFileName, PackageService.rXNSAoB2CbEfxDC3JZV0(-244066886 - -48452443 ^ -195682523));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 5 : 10;
              continue;
            case 10:
              if (PackageService.PirI1HB2PvtDmSbC6anK((object) str))
              {
                num2 = 8;
                continue;
              }
              goto case 1;
            case 11:
              PackageService.eLZdlkB29aqmJLYmsRhI((object) str, (object) packagesFileName);
              num2 = 2;
              continue;
            case 12:
label_30:
              if (!PackageService.PirI1HB2PvtDmSbC6anK((object) str))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
                continue;
              }
              goto case 5;
            default:
              goto label_25;
          }
        }
label_38:
        component = this.GetComponent();
        num1 = 9;
      }
label_39:
      return;
label_26:
      return;
label_25:;
    }

    /// <summary>
    /// Создать установщик компонентов, не требующих перезапуск сервера.
    /// </summary>
    /// <param name="updatingUid">Идентификатор установки пакетов.</param>
    /// <returns>Установщик компонентов.</returns>
    [Obsolete("Метод утратил актуальность - не используйте его", true)]
    public ISoftInstallWorker CreateSoftInstallWorker(Guid updatingUid) => (ISoftInstallWorker) null;

    /// <summary>Установить компоненты ELMA Store</summary>
    /// <param name="componentsInfo"></param>
    /// <param name="updatingUid"></param>
    /// <param name="saveStatusToDb"></param>
    public void InstallStoreComponents(
      IEnumerable<IStoreComponentInfo> componentsInfo,
      Guid updatingUid,
      bool saveStatusToDb)
    {
      if (componentsInfo == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669371371 ^ 1669440731));
      IElmaComponent component = this.GetComponent();
      if (component == null)
        throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1597012150 ^ 1597066890)));
      component.UnpackPackagesFromComponents((IEnumerable<string>) ComponentManager.Current.LicenseManager.GetActivationKeys().Select<KeyValuePair<Guid, string>, string>((Func<KeyValuePair<Guid, string>, string>) (p => p.Value)).ToArray<string>(), new Func<DateTime?>(ComponentManager.Current.ModuleManager.GetMainLicensedUnitExpiration));
      Dictionary<string, SemanticVersion> dictionary = new Dictionary<string, SemanticVersion>();
      foreach (IStoreComponentInfo storeComponentInfo1 in componentsInfo)
      {
        switch (storeComponentInfo1)
        {
          case ManifestStoreComponentInfo storeComponentInfo2:
            if (storeComponentInfo2.LastFile == null)
              throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477209780), (object) EleWise.ELMA.SR.T(storeComponentInfo2.Title), (object) storeComponentInfo2.Id));
            if (!storeComponentInfo2.IsInstalled || !storeComponentInfo2.IsLatestVersionInstalled)
            {
              using (List<PackageManifest>.Enumerator enumerator = storeComponentInfo2.LastManifest.Packages.GetEnumerator())
              {
                while (enumerator.MoveNext())
                {
                  PackageManifest current = enumerator.Current;
                  ElmaPackageMetadata metadata = new ElmaPackageMetadata(current.Tags);
                  if (component.IsCompatible(metadata))
                  {
                    SemanticVersion semanticVersion;
                    if (!dictionary.TryGetValue(current.Id, out semanticVersion))
                      semanticVersion = (SemanticVersion) null;
                    if (semanticVersion == (SemanticVersion) null || semanticVersion != (SemanticVersion) null && current.SemanticVersion != (SemanticVersion) null && current.SemanticVersion > semanticVersion)
                      dictionary[current.Id] = current.SemanticVersion;
                  }
                }
                continue;
              }
            }
            else
              continue;
          case PackageStoreComponentInfo storeComponentInfo3:
            if (!storeComponentInfo3.IsInstalled || !storeComponentInfo3.IsLatestVersionInstalled)
            {
              SemanticVersion semanticVersion;
              if (!dictionary.TryGetValue(storeComponentInfo3.Id, out semanticVersion))
                semanticVersion = (SemanticVersion) null;
              if (semanticVersion == (SemanticVersion) null || semanticVersion != (SemanticVersion) null && storeComponentInfo3.LastVersion != (SemanticVersion) null && storeComponentInfo3.LastVersion > semanticVersion)
              {
                dictionary[storeComponentInfo3.Id] = storeComponentInfo3.LastVersion;
                continue;
              }
              continue;
            }
            continue;
          case AssemblyStoreComponentInfo _:
            if (storeComponentInfo1.IsInstalled)
              continue;
            break;
        }
        throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(95909607 + 343705423 ^ 439535884), (object) EleWise.ELMA.SR.T(storeComponentInfo1.Title), (object) storeComponentInfo1.Id));
      }
      if (saveStatusToDb)
      {
        foreach (IStoreComponentInfo info in componentsInfo)
          ComponentManager.Current.ModuleManager.SaveStoreComponentInfo(info, StoreComponentStatus.Allowed);
      }
      if (dictionary.Count == 0 && !saveStatusToDb)
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(322893104 - -1992822529 ^ -1979305087), (object) string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638401517), componentsInfo.Select<IStoreComponentInfo, string>((Func<IStoreComponentInfo, string>) (c => (string) PackageService.\u003C\u003Ec.heClUvQSEJak0s3qoqBn(PackageService.\u003C\u003Ec.r9V60BQSBqOhtcaRT2C9(964881585 - -1459193222 ^ -1871112761), PackageService.\u003C\u003Ec.YIcRW6QSb4WBn4EEa7t6(PackageService.\u003C\u003Ec.HwHR11QVLjgjEIyeamZJ((object) c)), PackageService.\u003C\u003Ec.tLqBY9QSGIGc7tuZKSaC(PackageService.\u003C\u003Ec.Hipu3QQVslxaLwiJGd1G((object) c), PackageService.\u003C\u003Ec.r9V60BQSBqOhtcaRT2C9(-688192331 - 435440695 ^ -1123618468), PackageService.\u003C\u003Ec.QP3sUAQShHRg8ePw3Yo1((object) c))))))));
      }
      List<PackageOperationInfo> packageOperationInfoList = new List<PackageOperationInfo>();
      foreach (KeyValuePair<string, SemanticVersion> keyValuePair in dictionary)
        packageOperationInfoList.Add(new PackageOperationInfo()
        {
          Package = new PackageInfo(keyValuePair.Key, keyValuePair.Value),
          Type = PackageOperationType.Install
        });
      if (this.ExecuteOperationsWithResult((IEnumerable<PackageOperationInfo>) packageOperationInfoList.ToArray(), new PackageOperationOptions()
      {
        UpdatingUid = updatingUid
      }) || !componentsInfo.Any<IStoreComponentInfo>())
        return;
      Locator.GetServiceNotNull<IWebHostEnvironmentService>().RestartHost();
    }

    /// <summary>Доступен ли Online-установщик дизайнера</summary>
    /// <returns>True, если доступен</returns>
    public bool IsDesignerInstallerAvailable()
    {
      int num1 = 3;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_5;
          case 2:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
            continue;
          case 3:
            if (!this._isDesignerInstallerAvailable.HasValue)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 2 : 1;
              continue;
            }
            goto label_5;
          case 4:
            goto label_4;
          default:
            goto label_7;
        }
      }
label_4:
      bool flag;
      return flag;
label_5:
      return this._isDesignerInstallerAvailable.Value;
label_7:
      try
      {
        this._isDesignerInstallerAvailable = new bool?(this.GetDesignerInstallerFile(false) != null);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
          num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_4;
            default:
              flag = this._isDesignerInstallerAvailable.Value;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 1;
              continue;
          }
        }
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
          num3 = 0;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_4;
            case 2:
              flag = false;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 1 : 0;
              continue;
            default:
              PackageService.vOAJJNB2lfBvDwwO0BaA(PackageService.YI2LyaB2dBs9o8oMTMio(), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-542721635 ^ -542670369), (object) ex);
              num3 = 2;
              continue;
          }
        }
      }
    }

    /// <summary>Получить имя файла Online-установщика дизайнера</summary>
    /// <returns>Имя файла установщика</returns>
    public string GetDesignerInstallerFileName()
    {
      int num = 2;
      IPackageFile designerInstallerFile;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 4:
            goto label_3;
          case 2:
            if (!PackageService.OFHPs6B2RTdAQsKtufjk((object) this._designerInstallerFileName))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 1 : 0;
              continue;
            }
            goto case 3;
          case 3:
            designerInstallerFile = this.GetDesignerInstallerFile(true);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
            continue;
          default:
            this._designerInstallerFileName = (string) PackageService.jGN8ScB2gfR6KdL2i0gy(PackageService.RIRnrFB2rDxIWcKRcKFT((object) designerInstallerFile));
            num = 4;
            continue;
        }
      }
label_3:
      return this._designerInstallerFileName;
    }

    /// <summary>Получить поток Online-установщика дизайнера</summary>
    /// <returns>Поток</returns>
    public Stream GetDesignerInstallerStream() => (Stream) PackageService.uZDrCuB25L9Fv34FKd0u((object) this.GetDesignerInstallerFile(true));

    /// <summary>Записать дополнительные данные установщика ELMA</summary>
    /// <param name="fileName">Имя файла</param>
    /// <param name="data">Данные</param>
    public void WriteDesignerInstallerData(string fileName, DesignerInstallerData data)
    {
      int num = 2;
      while (true)
      {
        Guid guid;
        IRuntimeApplication runtimeApplication1;
        string str1;
        ElmaEdition? nullable;
        IRuntimeApplication runtimeApplication2;
        string str2;
        switch (num)
        {
          case 1:
            if (PackageService.PirI1HB2PvtDmSbC6anK((object) fileName))
            {
              guid = data.AppId;
              num = 12;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 1 : 6;
            continue;
          case 2:
            if (!PackageService.OFHPs6B2RTdAQsKtufjk((object) fileName))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 1 : 1;
              continue;
            }
            goto label_13;
          case 3:
            if (!PackageService.E2vBXxB2YyhU8G09iaml(guid, Guid.Empty))
            {
              num = 17;
              continue;
            }
            goto case 13;
          case 4:
            PackageService.UvMuWlBeBV8VvkRA9KeI((object) fileName, PackageService.oO9UOTBeFh6mFShyWo3s(PackageService.PcGLqjB2zFkgHYFNTYku(), (object) str1));
            num = 9;
            continue;
          case 5:
            str2 = "";
            goto label_33;
          case 6:
            goto label_8;
          case 7:
            goto label_13;
          case 8:
          case 17:
            if (nullable.HasValue)
            {
              num = 19;
              continue;
            }
            goto case 10;
          case 9:
            goto label_34;
          case 10:
            nullable = VersionInfo.GetEditionType();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 18 : 16;
            continue;
          case 11:
            if (!Locator.Initialized)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 13 : 21;
              continue;
            }
            goto default;
          case 12:
            nullable = data.ProductEdition;
            num = 14;
            continue;
          case 13:
            if (runtimeApplication1 != null)
            {
              num = 20;
              continue;
            }
            goto case 8;
          case 14:
            if (!ComponentManager.Initialized)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 16 : 9;
              continue;
            }
            if (((ComponentManager) PackageService.Vk2nGdB2jsh58ac4e5rm()).Stage != ComponentManager.LifetimeStage.BeforeInit)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 1 : 11;
              continue;
            }
            goto case 21;
          case 15:
            str2 = string.Format((string) PackageService.rXNSAoB2CbEfxDC3JZV0(2045296739 + 1688595713 ^ -561015340), (object) guid);
            goto label_33;
          case 16:
            runtimeApplication2 = (IRuntimeApplication) null;
            break;
          case 18:
          case 19:
            if (PackageService.Kgt7yrB2UoMx5JwsSpdJ(guid, Guid.Empty))
            {
              num = 15;
              continue;
            }
            goto case 5;
          case 20:
            guid = PackageService.qkiNirB2LOjLbJ54lOVP((object) runtimeApplication1);
            num = 8;
            continue;
          case 21:
            runtimeApplication2 = ((ComponentManager) PackageService.Vk2nGdB2jsh58ac4e5rm()).GetComponentsForRegister<IRuntimeApplication>().FirstOrDefault<IRuntimeApplication>();
            break;
          default:
            runtimeApplication2 = Locator.GetService<IRuntimeApplication>();
            break;
        }
        runtimeApplication1 = runtimeApplication2;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 1 : 3;
        continue;
label_33:
        object obj1 = !nullable.HasValue ? (object) "" : PackageService.M7QZIBB2sG1EC6e9RxKw(PackageService.rXNSAoB2CbEfxDC3JZV0(1242972401 >> 4 ^ 77618373), (object) nullable.Value.ToString());
        object obj2 = PackageService.ejLSfpB2cwbypd65fFJi(PackageService.rXNSAoB2CbEfxDC3JZV0(1642859704 ^ 1642935374), (object) data.InstallationName, (object) data.RemoteUrl, (object) data.PackageManagerRepository);
        str1 = (string) PackageService.cctrCjB2pAbZUIrje4AF((object) str2, obj1, obj2);
        num = 4;
      }
label_34:
      return;
label_8:
      throw new FileNotFoundException((string) PackageService.JMhBonB2qBe8vZDoQIo6(PackageService.rXNSAoB2CbEfxDC3JZV0(1669212571 ^ 1669271819)), fileName);
label_13:
      throw new ArgumentNullException((string) PackageService.rXNSAoB2CbEfxDC3JZV0(-281842504 ^ -281865566));
    }

    /// <summary>Установлена ли веб-часть для дизайнера</summary>
    public bool IsDesignerWebInstalled()
    {
      int num = 3;
      IElmaComponent elmaComponent;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            if (elmaComponent == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 3:
            elmaComponent = (IElmaComponent) PackageService.RNHLq0B2KdwwoiLFvRM3((object) this, PackageService.rXNSAoB2CbEfxDC3JZV0(277947046 - -1479185048 ^ 1757056132));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 2 : 1;
            continue;
          default:
            goto label_3;
        }
      }
label_2:
      return elmaComponent.IsInstalled();
label_3:
      return false;
    }

    /// <summary>Установить веб-часть для дизайнера</summary>
    public void InstallDesignerWeb(string packagesFileName)
    {
      int num = 4;
      IElmaComponent elmaComponent;
      string statusFileName;
      List<string> stringList;
      while (true)
      {
        switch (num)
        {
          case 1:
            statusFileName = (string) PackageService.ejqLmWB20GBmQsoQKXP7(PackageService.exEnydBeogCumrvpvqnm());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 2;
            continue;
          case 2:
            stringList = new List<string>((IEnumerable<string>) new string[1]
            {
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-122002947 ^ 121939926)
            });
            num = 5;
            continue;
          case 3:
            if (elmaComponent != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 4:
            elmaComponent = (IElmaComponent) PackageService.RNHLq0B2KdwwoiLFvRM3((object) this, PackageService.rXNSAoB2CbEfxDC3JZV0(-1255365154 ^ 596875508 ^ -1765931888));
            num = 3;
            continue;
          case 5:
            if (!PackageService.OFHPs6B2RTdAQsKtufjk((object) packagesFileName))
            {
              num = 9;
              continue;
            }
            goto case 6;
          case 6:
            stringList.Add((string) PackageService.rXNSAoB2CbEfxDC3JZV0(-882126494 ^ -882186024));
            num = 10;
            continue;
          case 7:
            goto label_8;
          case 8:
            stringList.Add(packagesFileName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 6 : 1;
            continue;
          case 9:
            stringList.Add((string) PackageService.rXNSAoB2CbEfxDC3JZV0(-1255365154 ^ 596875508 ^ -1765931786));
            num = 8;
            continue;
          case 10:
            this.ExecutePackageConsoleOrManager(statusFileName, stringList.ToArray(), this.UseConsole, true);
            num = 11;
            continue;
          case 11:
            goto label_17;
          default:
            if (PackageService.Ink5HQBeWKvxfRKHCZHu((object) elmaComponent))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 7 : 7;
              continue;
            }
            goto case 1;
        }
      }
label_8:
      return;
label_17:
      return;
label_2:;
    }

    /// <summary>Получить папку компонента "Веб-часть"</summary>
    /// <returns></returns>
    public string GetWebFolder()
    {
      int num1 = 3;
      IElmaComponent elmaComponent;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!PackageService.Ink5HQBeWKvxfRKHCZHu((object) elmaComponent))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
                continue;
              }
              goto label_6;
            case 2:
              if (elmaComponent != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 1;
                continue;
              }
              goto label_7;
            case 3:
              goto label_5;
            case 4:
              goto label_6;
            default:
              goto label_7;
          }
        }
label_5:
        elmaComponent = (IElmaComponent) PackageService.RNHLq0B2KdwwoiLFvRM3((object) this, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97958668));
        num1 = 2;
      }
label_6:
      return (string) PackageService.TGqrk3BebbuuKLWdJtGT((object) elmaComponent);
label_7:
      return (string) null;
    }

    /// <summary>
    /// Получить папку компонента "Веб-часть дизайнера (тестовый сервер)"
    /// </summary>
    /// <returns></returns>
    public string GetDesignerWebFolder()
    {
      int num = 4;
      IElmaComponent elmaComponent;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 2:
            goto label_6;
          case 3:
            if (elmaComponent == null)
            {
              num = 2;
              continue;
            }
            break;
          case 4:
            elmaComponent = (IElmaComponent) PackageService.RNHLq0B2KdwwoiLFvRM3((object) this, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-306453669 ^ 306521374));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 3 : 1;
            continue;
          case 5:
            goto label_5;
        }
        if (!elmaComponent.IsInstalled())
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 1 : 0;
        else
          break;
      }
label_5:
      return (string) PackageService.TGqrk3BebbuuKLWdJtGT((object) elmaComponent);
label_6:
      return (string) null;
    }

    /// <summary>Получить компонент пакетной системы</summary>
    /// <param name="componentName">Имя (идентификатор) компонента</param>
    /// <returns></returns>
    public virtual IElmaComponent GetComponent(string componentName)
    {
      int num1 = 1;
      Lazy<IElmaComponent> lazy;
      string componentName1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_8;
            case 3:
              if (lazy == null)
              {
                num2 = 8;
                continue;
              }
              goto case 7;
            case 4:
              goto label_3;
            case 5:
            case 8:
              goto label_7;
            case 6:
              goto label_12;
            case 7:
              if (lazy.Value != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 2 : 2;
                continue;
              }
              goto label_7;
            default:
              componentName1 = componentName;
              num2 = 6;
              continue;
          }
        }
label_3:
        lazy = ((ExportProvider) PackageService.yOwc9pB2IveUo9piLyHc((object) this._initializer)).GetExports<IElmaComponent>().FirstOrDefault<Lazy<IElmaComponent>>((Func<Lazy<IElmaComponent>, bool>) (c => c.Value.Id.Equals(componentName1)));
        num1 = 3;
        continue;
label_12:
        PackageService.dMoin1B2asOnpDvd8xnD((object) this);
        num1 = 4;
      }
label_7:
      throw new InvalidOperationException(EleWise.ELMA.SR.T((string) PackageService.rXNSAoB2CbEfxDC3JZV0(712480695 ^ 712420789), (object) componentName1));
label_8:
      return lazy.Value;
    }

    private PackageFilter GetDefaultFilter()
    {
      PackageFilter defaultFilter = new PackageFilter();
      PackageService.x4qQYWBehxoepfgiwJeo((object) defaultFilter, PackageLevel.Modules);
      PackageService.HiQU99BeGprPIxKNPZCv((object) defaultFilter, PackageStatus.Any);
      return defaultFilter;
    }

    private IEnumerable<PackageDescription> FilterPackages(
      IEnumerable<PackageDescription> packages,
      PackageFilter filter)
    {
      if (packages == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(323422137 << 2 ^ 1293755566));
      if (filter == null)
        return packages;
      Func<string, bool> ContainsSearchString = (Func<string, bool>) (s =>
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_5;
            case 2:
              if (s == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 1;
                continue;
              }
              goto label_4;
            default:
              goto label_4;
          }
        }
label_4:
        // ISSUE: reference to a compiler-generated method
        return PackageService.\u003C\u003Ec__DisplayClass69_0.Cl5brTQi8w6XPUcw2Acp((object) s, (object) filter.SearchString, StringComparison.CurrentCultureIgnoreCase) >= 0;
label_5:
        return false;
      });
      Func<string, bool> func;
      List<PackageDescription> list = packages.Where<PackageDescription>((Func<PackageDescription, bool>) (p =>
      {
        int num1 = 18;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 1:
              case 24:
              case 27:
                goto label_29;
              case 2:
                // ISSUE: reference to a compiler-generated method
                if (PackageService.\u003C\u003Ec__DisplayClass69_0.Focx1kQiZe4Ey6psFxXY((object) p) != ElmaPackageType.Core)
                {
                  num2 = 15;
                  continue;
                }
                goto label_41;
              case 3:
              case 20:
                goto label_52;
              case 4:
                // ISSUE: reference to a compiler-generated method
                if (PackageService.\u003C\u003Ec__DisplayClass69_0.Focx1kQiZe4Ey6psFxXY((object) p) == ElmaPackageType.Translates)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 14 : 9;
                  continue;
                }
                goto label_40;
              case 5:
                goto label_34;
              case 6:
                goto label_40;
              case 7:
                // ISSUE: reference to a compiler-generated method
                if (PackageService.\u003C\u003Ec__DisplayClass69_0.Focx1kQiZe4Ey6psFxXY((object) p) != ElmaPackageType.Application)
                {
                  num2 = 29;
                  continue;
                }
                goto case 14;
              case 8:
                // ISSUE: reference to a compiler-generated method
                if (!PackageService.\u003C\u003Ec__DisplayClass69_0.MJr2sFQiVN5TssTmopJC((object) p))
                {
                  num2 = 12;
                  continue;
                }
                break;
              case 9:
                if (ContainsSearchString(p.Id))
                {
                  num2 = 24;
                  continue;
                }
                goto case 11;
              case 10:
                goto label_47;
              case 11:
                // ISSUE: reference to a compiler-generated method
                if (ContainsSearchString((string) PackageService.\u003C\u003Ec__DisplayClass69_0.BDYEuQQiRd2W0r4JVTGX((object) p)))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 1;
                  continue;
                }
                goto case 16;
              case 12:
                goto label_17;
              case 13:
                if (p.Type != ElmaPackageType.Module)
                {
                  num2 = 7;
                  continue;
                }
                goto case 14;
              case 14:
              case 17:
                // ISSUE: reference to a compiler-generated method
                if (PackageService.\u003C\u003Ec__DisplayClass69_0.YlIjvIQiuUFshLN74pIN((object) filter) == PackageLevel.Core)
                {
                  num2 = 19;
                  continue;
                }
                goto label_41;
              case 15:
                // ISSUE: reference to a compiler-generated method
                if (PackageService.\u003C\u003Ec__DisplayClass69_0.Focx1kQiZe4Ey6psFxXY((object) p) != ElmaPackageType.Integration)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 0;
                  continue;
                }
                goto label_41;
              case 16:
                IEnumerable<string> authors = p.Authors;
                Func<string, bool> func1 = func;
                Func<string, bool> predicate = func1 == null ? (func = (Func<string, bool>) (a => ContainsSearchString(a))) : func1;
                if (authors.Any<string>(predicate))
                {
                  num2 = 27;
                  continue;
                }
                goto label_34;
              case 18:
                if (filter.Level != PackageLevel.Modules)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 17 : 6;
                  continue;
                }
                goto case 13;
              case 19:
                // ISSUE: reference to a compiler-generated method
                if (PackageService.\u003C\u003Ec__DisplayClass69_0.Focx1kQiZe4Ey6psFxXY((object) p) == ElmaPackageType.Module)
                  goto label_41;
                else
                  goto label_33;
              case 21:
                // ISSUE: reference to a compiler-generated method
                if (!PackageService.\u003C\u003Ec__DisplayClass69_0.MJr2sFQiVN5TssTmopJC((object) p))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 3 : 2;
                  continue;
                }
                goto case 26;
              case 22:
                // ISSUE: reference to a compiler-generated method
                if (PackageService.\u003C\u003Ec__DisplayClass69_0.MJr2sFQiVN5TssTmopJC((object) p))
                {
                  num2 = 10;
                  continue;
                }
                goto label_48;
              case 23:
                if (p.Type != ElmaPackageType.Application)
                {
                  num2 = 28;
                  continue;
                }
                goto label_41;
              case 25:
                goto label_28;
              case 26:
                // ISSUE: reference to a compiler-generated method
                if (!PackageService.\u003C\u003Ec__DisplayClass69_0.J3bv8IQiSKJ5U96V4McX((object) p))
                  goto label_53;
                else
                  goto label_39;
              case 28:
                // ISSUE: reference to a compiler-generated method
                if (PackageService.\u003C\u003Ec__DisplayClass69_0.Focx1kQiZe4Ey6psFxXY((object) p) != ElmaPackageType.MobileApplication)
                {
                  num2 = 2;
                  continue;
                }
                goto label_41;
              case 29:
                // ISSUE: reference to a compiler-generated method
                if (PackageService.\u003C\u003Ec__DisplayClass69_0.Focx1kQiZe4Ey6psFxXY((object) p) != ElmaPackageType.MobileApplication)
                {
                  num2 = 4;
                  continue;
                }
                goto case 14;
              default:
                // ISSUE: reference to a compiler-generated method
                if (PackageService.\u003C\u003Ec__DisplayClass69_0.Focx1kQiZe4Ey6psFxXY((object) p) != ElmaPackageType.Translates)
                {
                  num2 = 6;
                  continue;
                }
                goto label_41;
            }
label_18:
            if (filter.Status == PackageStatus.InstalledHasUpdate)
            {
              num2 = 21;
              continue;
            }
            goto label_53;
label_41:
            // ISSUE: reference to a compiler-generated method
            if (PackageService.\u003C\u003Ec__DisplayClass69_0.CMehVtQiIdRMKaaPdrQf((object) filter) == PackageStatus.NotInstalled)
            {
              num2 = 22;
              continue;
            }
label_48:
            // ISSUE: reference to a compiler-generated method
            if (PackageService.\u003C\u003Ec__DisplayClass69_0.CMehVtQiIdRMKaaPdrQf((object) filter) == PackageStatus.Installed)
            {
              num2 = 8;
              continue;
            }
            goto label_18;
label_53:
            // ISSUE: reference to a compiler-generated method
            if (!PackageService.\u003C\u003Ec__DisplayClass69_0.RLG2pAQiihqStUeWFIRw((object) filter.SearchString))
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 5 : 9;
            else
              goto label_29;
          }
label_33:
          num1 = 23;
          continue;
label_34:
          // ISSUE: reference to a compiler-generated method
          if (!ContainsSearchString((string) PackageService.\u003C\u003Ec__DisplayClass69_0.Rs2fwkQiqTPPHxHsJZrv((object) p)))
          {
            num1 = 25;
            continue;
          }
          goto label_29;
label_39:
          num1 = 20;
        }
label_17:
        return false;
label_28:
        return false;
label_29:
        return true;
label_40:
        return false;
label_47:
        return false;
label_52:
        return false;
      })).ToList<PackageDescription>();
      if (!string.IsNullOrEmpty(filter.Owner))
        list = list.Where<PackageDescription>((Func<PackageDescription, bool>) (p => p.OwnerIds.Contains(filter.Owner))).ToList<PackageDescription>();
      return (IEnumerable<PackageDescription>) list;
    }

    public static IEnumerable<PackageDescription> ApplySorting(
      IEnumerable<PackageDescription> packages,
      FetchOptions options)
    {
      List<string> sortExpressions1 = new List<string>();
      if (options == (FetchOptions) null || string.IsNullOrWhiteSpace(options.SortExpression))
      {
        sortExpressions1.Add(PackageService.SortExpressions.Installed.ToString());
        List<string> stringList1 = sortExpressions1;
        PackageService.SortExpressions sortExpressions2 = PackageService.SortExpressions.Type;
        string str1 = sortExpressions2.ToString();
        stringList1.Add(str1);
        List<string> stringList2 = sortExpressions1;
        sortExpressions2 = PackageService.SortExpressions.Priority;
        string str2 = sortExpressions2.ToString();
        stringList2.Add(str2);
        List<string> stringList3 = sortExpressions1;
        sortExpressions2 = PackageService.SortExpressions.Title;
        string str3 = sortExpressions2.ToString();
        stringList3.Add(str3);
      }
      else
        sortExpressions1 = ((IEnumerable<string>) options.SortExpression.Split(z2jc63fLkugS1X8Q9N.tE1kD1vbB(964881585 - -1459193222 ^ -1870906603).ToCharArray())).ToList<string>();
      packages = (IEnumerable<PackageDescription>) packages.OrderByDescending<PackageDescription, PackageDescription>((Func<PackageDescription, PackageDescription>) (p => p), (IComparer<PackageDescription>) new PackageService.PackageDescriptionComparer((IEnumerable<string>) sortExpressions1)).ToList<PackageDescription>();
      return packages;
    }

    private void ExecutePackageManager(string[] arguments, bool waitForExit)
    {
      int num1 = 3;
      string fileName;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_6;
            case 2:
              if (PackageService.PirI1HB2PvtDmSbC6anK((object) fileName))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 1 : 1;
                continue;
              }
              goto label_5;
            case 3:
              fileName = Path.Combine((string) PackageService.pGZukjBeEfrNEZsHraO3((object) this._settings), (string) PackageService.rXNSAoB2CbEfxDC3JZV0(-1217523399 ^ -1217453235), z2jc63fLkugS1X8Q9N.tE1kD1vbB(92412609 - 1050237057 ^ -957745122));
              num2 = 2;
              continue;
            case 4:
              goto label_8;
            default:
              goto label_5;
          }
        }
label_6:
        this.StartProcess(fileName, (string) PackageService.lV9xxvB2xqbOEIoHUIQY(PackageService.rXNSAoB2CbEfxDC3JZV0(1251470110 >> 2 ^ 312787407), (object) this.PrepareCommandLineArguments(arguments)), waitForExit);
        num1 = 4;
      }
label_8:
      return;
label_5:
      throw new FileNotFoundException(EleWise.ELMA.SR.T((string) PackageService.rXNSAoB2CbEfxDC3JZV0(1021410165 ^ 1021329875), (object) fileName));
    }

    private void ExecutePackageConsole(string[] arguments, bool waitForExit)
    {
      int num = 2;
      string fileName;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (PackageService.PirI1HB2PvtDmSbC6anK((object) fileName))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            fileName = (string) PackageService.KlElDTBefWtrrOO3xY1D((object) this._settings.Root, PackageService.rXNSAoB2CbEfxDC3JZV0(-1876063057 ^ -1876115749), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -812104870));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_6;
          case 4:
            goto label_2;
          default:
            this.StartProcess(fileName, this.PrepareCommandLineArguments(arguments), waitForExit);
            num = 3;
            continue;
        }
      }
label_6:
      return;
label_2:
      throw new FileNotFoundException(EleWise.ELMA.SR.T((string) PackageService.rXNSAoB2CbEfxDC3JZV0(222162814 ^ 222090274), (object) fileName));
    }

    private Process StartProcess(string fileName, string arguments, bool waitForExit)
    {
      int num = 5;
      Process process;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!waitForExit)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 0 : 0;
              continue;
            }
            goto case 3;
          case 2:
            PackageService.Wq9NG8Be8VNwMZryuCSN((object) process.StartInfo, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1654249598 >> 2 ^ 413617573));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 4 : 6;
            continue;
          case 3:
            process.WaitForExit();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 2 : 7;
            continue;
          case 4:
            PackageService.cVkRGOBeCjVCdxypBUF9(PackageService.ocucCrBeQxyUaF3es4NW((object) process), (object) fileName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 5 : 8;
            continue;
          case 5:
            process = new Process();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 4 : 2;
            continue;
          case 6:
            PackageService.wmE83RBeZr0A3dubfIj3((object) process);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 1;
            continue;
          case 8:
            PackageService.pqytLSBev7kFJAToN9Qr((object) process.StartInfo, (object) arguments);
            num = 2;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return process;
    }

    private void ExecutePackageConsoleOrManager(
      string statusFileName,
      string[] arguments,
      bool useConsole,
      bool waitForExit = false)
    {
      int num1 = 2;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_14;
          case 1:
            goto label_3;
          case 2:
            PackagingHelper helper1 = this._helper;
            string str1 = statusFileName;
            PackageOperationStatus packageOperationStatus1 = new PackageOperationStatus();
            PackageService.hVf9SOBeu3cK9eI5oJKh((object) packageOperationStatus1, PackageOperationStatusType.Initializing);
            PackageService.EH81ncBeInTs3ZO2yAY0((object) packageOperationStatus1, PackageService.JMhBonB2qBe8vZDoQIo6(PackageService.rXNSAoB2CbEfxDC3JZV0(516838154 ^ 516909250)));
            PackageService.gJOKAKBeVw2hJwJeWCnQ((object) helper1, (object) str1, (object) packageOperationStatus1);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 1 : 1;
            continue;
          default:
            goto label_10;
        }
      }
label_14:
      return;
label_10:
      return;
label_3:
      try
      {
        int num2;
        if (useConsole)
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 1;
        else
          goto label_7;
label_5:
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_9;
            case 1:
              this.ExecutePackageConsole(arguments, waitForExit);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_6;
            case 3:
              goto label_7;
            default:
              goto label_2;
          }
        }
label_9:
        return;
label_6:
        return;
label_2:
        return;
label_7:
        this.ExecutePackageManager(arguments, waitForExit);
        num2 = 2;
        goto label_5;
      }
      catch (FileNotFoundException ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
          num3 = 0;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_16;
            default:
              PackagingHelper helper2 = this._helper;
              string str2 = statusFileName;
              PackageOperationStatus packageOperationStatus2 = new PackageOperationStatus();
              PackageService.hVf9SOBeu3cK9eI5oJKh((object) packageOperationStatus2, PackageOperationStatusType.Error);
              PackageService.EH81ncBeInTs3ZO2yAY0((object) packageOperationStatus2, PackageService.tGBlrqBeSB8Go47aQgSZ((object) ex));
              PackageService.gJOKAKBeVw2hJwJeWCnQ((object) helper2, (object) str2, (object) packageOperationStatus2);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 1 : 1;
              continue;
          }
        }
label_16:
        throw;
      }
    }

    private string PrepareCommandLineArguments(string[] arguments)
    {
      int num1 = 1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (arguments == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return "";
label_5:
      return string.Join((string) PackageService.rXNSAoB2CbEfxDC3JZV0(236071375 ^ 236085485), ((IEnumerable<string>) arguments).Select<string, string>((Func<string, string>) (a =>
      {
        int num2 = 1;
        string source;
        while (true)
        {
          switch (num2)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              source = (string) PackageService.\u003C\u003Ec.s8w0L7QSfnQiwT4HMnDb((object) a, PackageService.\u003C\u003Ec.r9V60BQSBqOhtcaRT2C9(-1858887263 ^ -1858880263), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1149433385 + 173655049 ^ 1323238748));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 0 : 0;
              continue;
            case 2:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              source = (string) PackageService.\u003C\u003Ec.mGGADSQSQLsikSTTr8BM(PackageService.\u003C\u003Ec.r9V60BQSBqOhtcaRT2C9(-1255365154 ^ 596875508 ^ -1765859214), (object) source, PackageService.\u003C\u003Ec.r9V60BQSBqOhtcaRT2C9(-1852837372 ^ -1852838052));
              num2 = 4;
              continue;
            case 3:
            case 4:
              goto label_4;
            default:
              if (!source.Contains<char>(' '))
              {
                num2 = 3;
                continue;
              }
              goto case 2;
          }
        }
label_4:
        return source;
      })));
    }

    private string GetDebugPackageManagerPath(string currentFolder)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (currentFolder.Count<char>((Func<char, bool>) (ch => ch == '\\')) <= 1)
            {
              num = 3;
              continue;
            }
            goto label_4;
          case 2:
            if (!PackageService.PirI1HB2PvtDmSbC6anK((object) Path.Combine(currentFolder, (string) PackageService.rXNSAoB2CbEfxDC3JZV0(-477139494 ^ -477212204))))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 1 : 1;
              continue;
            }
            goto label_6;
          case 3:
            goto label_5;
          case 4:
            goto label_6;
          default:
            goto label_4;
        }
      }
label_4:
      return this.GetDebugPackageManagerPath((string) PackageService.veJtXEB2QvUPj9IKqMk4((object) currentFolder));
label_5:
      return (string) null;
label_6:
      return (string) PackageService.KlElDTBefWtrrOO3xY1D((object) currentFolder, PackageService.rXNSAoB2CbEfxDC3JZV0(-688192331 - 435440695 ^ -1123580852), PackageService.rXNSAoB2CbEfxDC3JZV0(-680446928 - -370807692 ^ -309692984));
    }

    private IPackage GetDesignerInstallerPackage()
    {
      int num1 = 9;
      IPackage installerPackage;
      while (true)
      {
        int num2 = num1;
        // ISSUE: variable of a compiler-generated type
        PackageService.\u003C\u003Ec__DisplayClass79_1 cDisplayClass791;
        IQueryable<IPackage> queryable;
        // ISSUE: variable of a compiler-generated type
        PackageService.\u003C\u003Ec__DisplayClass79_0 cDisplayClass790;
        List<IPackage> list;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_7;
            case 2:
              // ISSUE: object of a compiler-generated type is created
              cDisplayClass791 = new PackageService.\u003C\u003Ec__DisplayClass79_1();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
              continue;
            case 3:
              // ISSUE: reference to a compiler-generated method
              installerPackage = list.First<IPackage>(new Func<IPackage, bool>(cDisplayClass791.\u003CGetDesignerInstallerPackage\u003Eb__5));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 16 : 5;
              continue;
            case 4:
              IEnumerable<ElmaPackageInfo> installedPackagesInfos = this.GetInstalledPackagesInfos();
              // ISSUE: reference to a compiler-generated field
              Func<ElmaPackageInfo, bool> func1 = PackageService.\u003C\u003Ec.\u003C\u003E9__79_0;
              Func<ElmaPackageInfo, bool> predicate1;
              if (func1 == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                PackageService.\u003C\u003Ec.\u003C\u003E9__79_0 = predicate1 = (Func<ElmaPackageInfo, bool>) (p => PackageService.\u003C\u003Ec.LRDqxvQSCcHDhOoeeeoO(PackageService.\u003C\u003Ec.sYRDNtQSo3Rdb5SymbjQ((object) p), PackageService.\u003C\u003Ec.r9V60BQSBqOhtcaRT2C9(1142330761 ^ 1541959139 ^ 536479304)));
              }
              else
                goto label_29;
label_24:
              ElmaPackageInfo elmaPackageInfo = installedPackagesInfos.FirstOrDefault<ElmaPackageInfo>(predicate1);
              // ISSUE: reference to a compiler-generated field
              cDisplayClass790.packagingPackage = elmaPackageInfo;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 5 : 7;
              continue;
label_29:
              predicate1 = func1;
              goto label_24;
            case 5:
            case 14:
              goto label_21;
            case 6:
              goto label_25;
            case 7:
              // ISSUE: reference to a compiler-generated field
              if (cDisplayClass790.packagingPackage != null)
              {
                num2 = 15;
                continue;
              }
              goto label_7;
            case 8:
              if (!this.Initialized)
              {
                num2 = 5;
                continue;
              }
              goto case 13;
            case 9:
              // ISSUE: object of a compiler-generated type is created
              cDisplayClass790 = new PackageService.\u003C\u003Ec__DisplayClass79_0();
              num2 = 8;
              continue;
            case 10:
              if (PackageService.oaJ0hrBenDlyo9MkhGNb((object) list) != 0)
              {
                List<IPackage> source = list;
                // ISSUE: reference to a compiler-generated field
                Func<IPackage, SemanticVersion> func2 = PackageService.\u003C\u003Ec.\u003C\u003E9__79_4;
                Func<IPackage, SemanticVersion> selector;
                if (func2 == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated method
                  PackageService.\u003C\u003Ec.\u003C\u003E9__79_4 = selector = (Func<IPackage, SemanticVersion>) (p => (SemanticVersion) PackageService.\u003C\u003Ec.DZGno4QSvgNOUOHXjj4r((object) p));
                }
                else
                  goto label_30;
label_28:
                SemanticVersion semanticVersion = source.Max<IPackage, SemanticVersion>(selector);
                // ISSUE: reference to a compiler-generated field
                cDisplayClass791.maxAvailableVersion = semanticVersion;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 3;
                continue;
label_30:
                selector = func2;
                goto label_28;
              }
              else
                goto label_18;
            case 11:
            case 16:
              goto label_16;
            case 12:
              IQueryable<IPackage> source1 = queryable;
              // ISSUE: type reference
              ParameterExpression parameterExpression1 = (ParameterExpression) PackageService.rRuf2nBeiQolpIATNdqr(PackageService.sX2f72B2ZBl7CBN8dPEc(__typeref (IPackage)), PackageService.rXNSAoB2CbEfxDC3JZV0(-2099751081 ^ -2099733105));
              // ISSUE: method reference
              // ISSUE: method reference
              // ISSUE: type reference
              // ISSUE: field reference
              // ISSUE: method reference
              Expression<Func<IPackage, bool>> predicate2 = Expression.Lambda<Func<IPackage, bool>>((Expression) Expression.Call((Expression) PackageService.GkggMqBeqbow9Ng9OKbL((object) parameterExpression1, (object) (MethodInfo) PackageService.Iy9m97BeR4xDRf1Oib2i(__methodref (IPackageName.get_Version))), (MethodInfo) PackageService.Iy9m97BeR4xDRf1Oib2i(__methodref (SemanticVersion.Equals)), (Expression) PackageService.GkggMqBeqbow9Ng9OKbL(PackageService.AcvNbWBeXYPnDrrQ3PdX((object) Expression.Constant((object) cDisplayClass790, PackageService.sX2f72B2ZBl7CBN8dPEc(__typeref (PackageService.\u003C\u003Ec__DisplayClass79_0))), PackageService.tV3Tv8BeKQaQRECB2SMG(__fieldref (PackageService.\u003C\u003Ec__DisplayClass79_0.packagingPackage))), (object) (MethodInfo) PackageService.Iy9m97BeR4xDRf1Oib2i(__methodref (PackageInfo.get_Version)))), parameterExpression1);
              installerPackage = source1.FirstOrDefault<IPackage>(predicate2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 17 : 7;
              continue;
            case 13:
              if (this._localRepository != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 4 : 4;
                continue;
              }
              goto label_21;
            case 15:
              goto label_8;
            case 17:
              if (installerPackage != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 11 : 3;
                continue;
              }
              goto case 2;
            default:
              IQueryable<IPackage> source2 = queryable;
              // ISSUE: type reference
              ParameterExpression parameterExpression2 = Expression.Parameter(PackageService.sX2f72B2ZBl7CBN8dPEc(__typeref (IPackage)), (string) PackageService.rXNSAoB2CbEfxDC3JZV0(2045296739 + 1688595713 ^ -561092676));
              // ISSUE: method reference
              // ISSUE: type reference
              // ISSUE: field reference
              // ISSUE: method reference
              // ISSUE: method reference
              Expression<Func<IPackage, bool>> predicate3 = Expression.Lambda<Func<IPackage, bool>>((Expression) PackageService.q7irKrBekj6lndDm8ktH(PackageService.GkggMqBeqbow9Ng9OKbL((object) parameterExpression2, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (IPackageName.get_Version))), PackageService.GkggMqBeqbow9Ng9OKbL(PackageService.AcvNbWBeXYPnDrrQ3PdX(PackageService.MJ4f3pBeTys0rck1hxkh((object) cDisplayClass790, PackageService.sX2f72B2ZBl7CBN8dPEc(__typeref (PackageService.\u003C\u003Ec__DisplayClass79_0))), PackageService.tV3Tv8BeKQaQRECB2SMG(__fieldref (PackageService.\u003C\u003Ec__DisplayClass79_0.packagingPackage))), (object) (MethodInfo) PackageService.Iy9m97BeR4xDRf1Oib2i(__methodref (PackageInfo.get_Version))), false, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (SemanticVersion.op_LessThan))), parameterExpression2);
              list = source2.Where<IPackage>(predicate3).ToList<IPackage>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 10 : 5;
              continue;
          }
        }
label_8:
        IQueryable<IPackage> packages = this._localRepository.GetPackages();
        ParameterExpression parameterExpression3 = (ParameterExpression) PackageService.rRuf2nBeiQolpIATNdqr(typeof (IPackage), PackageService.rXNSAoB2CbEfxDC3JZV0(132912447 ^ 132964327));
        // ISSUE: method reference
        // ISSUE: type reference
        Expression<Func<IPackage, bool>> predicate4 = Expression.Lambda<Func<IPackage, bool>>((Expression) Expression.Equal((Expression) PackageService.GkggMqBeqbow9Ng9OKbL((object) parameterExpression3, (object) (MethodInfo) PackageService.Iy9m97BeR4xDRf1Oib2i(__methodref (IPackageName.get_Id))), (Expression) Expression.Constant(PackageService.rXNSAoB2CbEfxDC3JZV0(372753449 ^ 372701205), PackageService.sX2f72B2ZBl7CBN8dPEc(__typeref (string)))), parameterExpression3);
        queryable = packages.Where<IPackage>(predicate4);
        num1 = 12;
        continue;
label_18:
        num1 = 6;
      }
label_7:
      return (IPackage) null;
label_16:
      return installerPackage;
label_21:
      return (IPackage) null;
label_25:
      return (IPackage) null;
    }

    private IPackageFile GetDesignerInstallerFile(bool throwExpceptionOnError)
    {
      int num = 7;
      IPackage installerPackage;
      IPackageFile designerInstallerFile;
      string fn;
      while (true)
      {
        Version version;
        switch (num)
        {
          case 1:
            goto label_6;
          case 2:
            goto label_3;
          case 3:
            version = ((SemanticVersion) PackageService.yWRYBOBeONXfJJL7jb2n((object) installerPackage)).Version;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 10 : 8;
            continue;
          case 4:
            if (installerPackage != null)
            {
              num = 3;
              continue;
            }
            break;
          case 5:
            goto label_7;
          case 6:
            installerPackage = this.GetDesignerInstallerPackage();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 2 : 4;
            continue;
          case 7:
            num = 6;
            continue;
          case 8:
            if (!(designerInstallerFile == null & throwExpceptionOnError))
            {
              num = 5;
              continue;
            }
            goto label_6;
          case 9:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            designerInstallerFile = installerPackage.GetFiles().FirstOrDefault<IPackageFile>((Func<IPackageFile, bool>) (f => PackageService.\u003C\u003Ec__DisplayClass80_0.S1LmXpQitrhjFnv6eZRE(PackageService.\u003C\u003Ec__DisplayClass80_0.tt3GVEQipHkTi2jhkQi6((object) f), PackageService.\u003C\u003Ec__DisplayClass80_0.haMVg7QiDRnuVh8XyK6G(PackageService.\u003C\u003Ec__DisplayClass80_0.MwVLwrQia1iPOsvPIliY(-1876063057 ^ -1876362907), (object) fn), StringComparison.CurrentCultureIgnoreCase)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 3 : 8;
            continue;
          case 10:
            fn = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-542721635 ^ -542669529), (object) PackageService.KR6nAXBe25dvEE9o0qtu((object) version), (object) PackageService.Elv4tOBeeLwyOhxR4cqC((object) version), (object) PackageService.ke8qaIBePSAq1CaTWJ9x((object) version));
            num = 9;
            continue;
        }
        if (throwExpceptionOnError)
          num = 2;
        else
          goto label_4;
      }
label_3:
      throw new InvalidOperationException((string) PackageService.JMhBonB2qBe8vZDoQIo6(PackageService.rXNSAoB2CbEfxDC3JZV0(95909607 + 343705423 ^ 439534170)));
label_4:
      return (IPackageFile) null;
label_6:
      throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-542721635 ^ -542669465), (object) fn, (object) installerPackage.ToString()));
label_7:
      return designerInstallerFile;
    }

    private string GetPackageIconFileNameNonCached(string id, string version)
    {
      int num1 = 7;
      string path1;
      IPackageFile packageFile;
      while (true)
      {
        int num2 = num1;
        IPackage package;
        string id1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_21;
            case 2:
              if (Directory.Exists(path1))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 13 : 15;
                continue;
              }
              goto case 10;
            case 3:
            case 15:
              goto label_3;
            case 4:
              goto label_8;
            case 5:
              path1 = (string) PackageService.RFAa64B2vsw36xTj25Uj(PackageService.EZ060nB2icj1kHnMeiSu((object) this._settings), PackageService.rXNSAoB2CbEfxDC3JZV0(-2138160520 ^ -2138079248));
              num2 = 2;
              continue;
            case 6:
              id1 = id;
              num2 = 9;
              continue;
            case 7:
              num2 = 6;
              continue;
            case 8:
              package = (IPackage) PackageService.bn1n2QB2DWOn5d4Rcy6d((object) this._localRepository, (object) id1, (object) new SemanticVersion(version));
              num2 = 13;
              continue;
            case 9:
              PackageService.dMoin1B2asOnpDvd8xnD((object) this);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 1 : 1;
              continue;
            case 10:
              Directory.CreateDirectory(path1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 3 : 1;
              continue;
            case 11:
              goto label_19;
            case 12:
              if (this._localRepository != null)
              {
                num2 = 16;
                continue;
              }
              goto label_19;
            case 13:
              if (package == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 0;
                continue;
              }
              packageFile = package.GetFiles().FirstOrDefault<IPackageFile>((Func<IPackageFile, bool>) (f =>
              {
                int num3 = 4;
                IPackageFile f1;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_7;
                    case 2:
                      goto label_6;
                    case 3:
                      f1 = f;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 0;
                      continue;
                    case 4:
                      num3 = 3;
                      continue;
                    default:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      if (!PackageService.\u003C\u003Ec__DisplayClass81_0.EWjvm3Qixsv2S6ZMPdqg(PackageService.\u003C\u003Ec__DisplayClass81_0.xSccUJQi7AB7hRlG4wMW(PackageService.\u003C\u003Ec__DisplayClass81_0.MXHoMTQiAHZqyy4eWxvB((object) f1)), (object) id1, StringComparison.CurrentCultureIgnoreCase))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 1 : 1;
                        continue;
                      }
                      goto label_6;
                  }
                }
label_6:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                return PackageService._supportedIconExtensions.Any<string>((Func<string, bool>) (ext => ((string) PackageService.\u003C\u003Ec__DisplayClass81_1.DSQaqjQi9MDR4EBZiMIA(PackageService.\u003C\u003Ec__DisplayClass81_1.W2WBOPQiJt9QwLjf0KKt((object) f1))).Equals(ext, StringComparison.CurrentCultureIgnoreCase)));
label_7:
                return false;
              }));
              num2 = 18;
              continue;
            case 14:
              if (!PackageService.OFHPs6B2RTdAQsKtufjk((object) id1))
              {
                num2 = 12;
                continue;
              }
              goto label_27;
            case 16:
              if (!PackageService.OFHPs6B2RTdAQsKtufjk((object) version))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 8 : 6;
                continue;
              }
              goto label_19;
            case 17:
              goto label_15;
            case 18:
              if (packageFile != null)
              {
                num2 = 5;
                continue;
              }
              goto label_15;
            case 19:
              goto label_27;
            default:
              goto label_25;
          }
        }
label_21:
        if (id1 != null)
          num1 = 14;
        else
          goto label_8;
      }
label_3:
      object path2 = PackageService.RFAa64B2vsw36xTj25Uj((object) path1, (object) packageFile.Path);
      File.WriteAllBytes((string) path2, EleWise.ELMA.Extensions.StreamExtensions.ReadAllBytes((Stream) PackageService.uZDrCuB25L9Fv34FKd0u((object) packageFile)));
      return (string) path2;
label_8:
      throw new ArgumentNullException((string) PackageService.rXNSAoB2CbEfxDC3JZV0(-1876063057 ^ -1876115499));
label_15:
      return (string) null;
label_19:
      return (string) null;
label_25:
      return (string) null;
label_27:
      throw new ArgumentException((string) PackageService.rXNSAoB2CbEfxDC3JZV0(901793403 ^ 901871097));
    }

    private int GetComponentTypeOrder(ManifestComponentType type)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (type == ManifestComponentType.Platform)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
              continue;
            }
            goto label_11;
          case 2:
            switch (type)
            {
              case ManifestComponentType.Module:
                goto label_7;
              case ManifestComponentType.Application:
                goto label_4;
              case ManifestComponentType.Solution:
                goto label_3;
              case ManifestComponentType.MobileApplication:
                goto label_5;
              case ManifestComponentType.ProcessPackage:
                goto label_8;
              case ManifestComponentType.Process:
                goto label_9;
              case ManifestComponentType.ExternalApplication:
                goto label_6;
              case ManifestComponentType.Report:
                goto label_10;
              default:
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 1 : 1;
                continue;
            }
          default:
            goto label_2;
        }
      }
label_2:
      return 1000;
label_3:
      return 500;
label_4:
      return 100;
label_5:
      return 90;
label_6:
      return 80;
label_7:
      return 50;
label_8:
      return 40;
label_9:
      return 20;
label_10:
      return 19;
label_11:
      return 0;
    }

    private List<PackageDescription> FilterElmaPackageDescriptors(
      IEnumerable<PackageDescription> packageDescriptors)
    {
      Dictionary<PackageDescription, bool?> isElmaPackageDictionary = new Dictionary<PackageDescription, bool?>();
      List<PackageDescription> packageDescriptionList = new List<PackageDescription>();
      foreach (PackageDescription packageDescriptor in packageDescriptors)
      {
        if (this.IsElmaPackage(packageDescriptor, packageDescriptors, isElmaPackageDictionary))
          packageDescriptionList.Add(packageDescriptor);
      }
      return packageDescriptionList;
    }

    private bool IsElmaPackage(
      PackageDescription packageDescription,
      IEnumerable<PackageDescription> packageDescriptors,
      Dictionary<PackageDescription, bool?> isElmaPackageDictionary)
    {
      Contract.ArgumentNotNull((object) packageDescription, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710518948));
      bool? nullable;
      if (isElmaPackageDictionary.TryGetValue(packageDescription, out nullable))
        return nullable.HasValue && nullable.Value;
      if (packageDescription.Id.Equals(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740340792)))
      {
        isElmaPackageDictionary[packageDescription] = new bool?(true);
        return true;
      }
      isElmaPackageDictionary[packageDescription] = new bool?();
      List<string> source = new List<string>();
      if (packageDescription.InstalledVersion != (SemanticVersion) null)
      {
        IPackage package = this.GetPackage(packageDescription.Id, packageDescription.InstalledVersion.ToString());
        if (package != null)
        {
          // ISSUE: reference to a compiler-generated method
          source.AddRange(package.DependencySets.SelectMany<PackageDependencySet, PackageDependency>((Func<PackageDependencySet, IEnumerable<PackageDependency>>) (s => (IEnumerable<PackageDependency>) s.Dependencies)).Select<PackageDependency, string>((Func<PackageDependency, string>) (d => (string) PackageService.\u003C\u003Ec.YZLTFpQS86LnEWNpotUv((object) d))));
        }
      }
      if (packageDescription.LastVersion != (SemanticVersion) null && (packageDescription.InstalledVersion == (SemanticVersion) null || !packageDescription.InstalledVersion.Equals(packageDescription.LastVersion)))
      {
        IPackage package = this.GetPackage(packageDescription.Id, packageDescription.LastVersion.ToString());
        if (package != null)
        {
          // ISSUE: reference to a compiler-generated method
          source.AddRange(package.DependencySets.SelectMany<PackageDependencySet, PackageDependency>((Func<PackageDependencySet, IEnumerable<PackageDependency>>) (s => (IEnumerable<PackageDependency>) s.Dependencies)).Select<PackageDependency, string>((Func<PackageDependency, string>) (d => (string) PackageService.\u003C\u003Ec.YZLTFpQS86LnEWNpotUv((object) d))));
        }
      }
      foreach (string str in source.Distinct<string>().ToList<string>())
      {
        string depId = str;
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        PackageDescription packageDescription1 = packageDescriptors.FirstOrDefault<PackageDescription>((Func<PackageDescription, bool>) (p => PackageService.\u003C\u003Ec__DisplayClass85_0.FpGky0Qijla8ZkEHNbv6(PackageService.\u003C\u003Ec__DisplayClass85_0.bCJI17Qi59lBRHPYq2xQ((object) p), (object) depId)));
        if (packageDescription1 != null && this.IsElmaPackage(packageDescription1, packageDescriptors, isElmaPackageDictionary))
        {
          isElmaPackageDictionary[packageDescription] = new bool?(true);
          return true;
        }
      }
      isElmaPackageDictionary[packageDescription] = new bool?(false);
      return false;
    }

    private IEnumerable<PackageOperationInfo> GetRequiredOperationsGeneric<Component>(
      IEnumerable<ElmaPackageInfo> serverPackages)
      where Component : ElmaComponent
    {
      this.CheckInitialized();
      if (serverPackages == null)
        return (IEnumerable<PackageOperationInfo>) new PackageOperationInfo[0];
      List<PackageOperationInfo> packageOperationInfoList = new List<PackageOperationInfo>();
      Component component = this._initializer.CompositionContainer.GetExport<Component>().Value;
      IEnumerable<PackageInfo> installedPackagesInfo = component.GetInstalledPackagesInfo();
      foreach (ElmaPackageInfo serverPackage in serverPackages)
      {
        ElmaPackageInfo package = serverPackage;
        if (package.ElmaMetadata != null && component.IsCompatible(package.ElmaMetadata))
        {
          PackageInfo packageInfo = installedPackagesInfo.FirstOrDefault<PackageInfo>((Func<PackageInfo, bool>) (pi => pi.Id == package.Id));
          if (packageInfo == null)
          {
            if (package.ElmaMetadata.Type != ElmaPackageType.Unknown)
              packageOperationInfoList.Add(new PackageOperationInfo()
              {
                Package = (PackageInfo) package,
                Type = PackageOperationType.Install
              });
          }
          else if (package.Version != (SemanticVersion) null && (packageInfo.Version == (SemanticVersion) null || packageInfo.Version < package.Version))
            packageOperationInfoList.Add(new PackageOperationInfo()
            {
              Package = (PackageInfo) package,
              Type = PackageOperationType.Update,
              InstalledVersion = packageInfo.Version
            });
        }
      }
      return (IEnumerable<PackageOperationInfo>) packageOperationInfoList.ToArray();
    }

    void IDisposable.Dispose()
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_6;
          case 2:
            this._initializer = (PackagingInitializer) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 1 : 0;
            continue;
          case 3:
            goto label_2;
          case 4:
            if (this._initializer == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 3 : 0;
              continue;
            }
            break;
        }
        this._initializer.Dispose();
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 2;
      }
label_6:
      return;
label_2:;
    }

    static PackageService()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            PackageService._supportedIconExtensions = new List<string>()
            {
              (string) PackageService.rXNSAoB2CbEfxDC3JZV0(712480695 ^ 712419849),
              (string) PackageService.rXNSAoB2CbEfxDC3JZV0(874012245 ^ 874079135),
              (string) PackageService.rXNSAoB2CbEfxDC3JZV0(654297945 ^ 654243471),
              (string) PackageService.rXNSAoB2CbEfxDC3JZV0(-420743386 ^ -420820284)
            };
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static bool GO8qyhB2bEDkg5evq9pR() => PackageService.jfyBspB2oSSitYC6GSPt == null;

    internal static PackageService DONuikB2hW5XceC8umv2() => PackageService.jfyBspB2oSSitYC6GSPt;

    internal static object W81UwKB2GN69Gqu5gCrU() => (object) AppDomain.CurrentDomain;

    internal static object zv4an5B2EHvEDqratyAQ([In] object obj0) => (object) ((AppDomain) obj0).SetupInformation;

    internal static object Ath7IGB2fWorGVKLvPZA([In] object obj0) => (object) ((AppDomainSetup) obj0).ConfigurationFile;

    internal static object veJtXEB2QvUPj9IKqMk4([In] object obj0) => (object) Path.GetDirectoryName((string) obj0);

    internal static object rXNSAoB2CbEfxDC3JZV0(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object RFAa64B2vsw36xTj25Uj([In] object obj0, [In] object obj1) => (object) Path.Combine((string) obj0, (string) obj1);

    internal static void zBZQFvB288H9uWyvwZjj([In] object obj0, [In] object obj1) => ((EleWise.ELMA.Logging.ILogger) obj0).Warn(obj1);

    internal static Type sX2f72B2ZBl7CBN8dPEc([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object GgLXfeB2ulUCh4Ge8hay([In] object obj0) => (object) PackagingSettings.LoadFromDirectory((string) obj0);

    internal static object yOwc9pB2IveUo9piLyHc([In] object obj0) => (object) ((PackagingInitializer) obj0).CompositionContainer;

    internal static object E1o1gwB2VTjeIOqXmN5N([In] object obj0) => (object) ((PackagingHelper) obj0).LocalRepository;

    internal static object hbXDB4B2SUCGpsLdYrfl([In] object obj0) => (object) ((PackagingHelper) obj0).LocalComponentsRepository;

    internal static object EZ060nB2icj1kHnMeiSu([In] object obj0) => (object) ((PackagingSettings) obj0).LocalRepository;

    internal static bool OFHPs6B2RTdAQsKtufjk([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object JMhBonB2qBe8vZDoQIo6([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object RNHLq0B2KdwwoiLFvRM3([In] object obj0, [In] object obj1) => (object) ((PackageService) obj0).GetComponent((string) obj1);

    internal static void eQ9VP9B2X9AafdLZERk6([In] object obj0, [In] object obj1) => ((ElmaStoreComponentFile) obj0).UnpackTo((string) obj1);

    internal static object HulRU3B2T4PJyCICDVsr([In] object obj0) => (object) ((IElmaComponent) obj0).GetConfigurationPackagesDirectory();

    internal static bool yx6quxB2kyxRAb9HogjX([In] object obj0) => Directory.Exists((string) obj0);

    internal static object tbFllNB2nlWQHUCSopP2([In] object obj0) => (object) Directory.CreateDirectory((string) obj0);

    internal static object hVxC57B2OBYlbMFEpE67([In] object obj0) => (object) ((ElmaStoreComponentManifest) obj0).Id;

    internal static object TZNUo5B22AI0CZUsPf2s([In] object obj0) => (object) ((ElmaStoreComponentManifest) obj0).Version;

    internal static bool gXXZ30B2eHdbtqumVWvd([In] object obj0, [In] object obj1, [In] StringComparison obj2) => string.Equals((string) obj0, (string) obj1, obj2);

    internal static bool PirI1HB2PvtDmSbC6anK([In] object obj0) => File.Exists((string) obj0);

    internal static void HrYUQaB21oefkQB02m8x([In] object obj0, [In] bool obj1, [In] object obj2) => FS.DeleteFile((string) obj0, obj1, (string) obj2);

    internal static object eFepEyB2NsI2vS5U0DYb([In] object obj0) => (object) File.OpenRead((string) obj0);

    internal static void qMOLB8B23JG6o9TjeWFC([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object cctrCjB2pAbZUIrje4AF([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static void dMoin1B2asOnpDvd8xnD([In] object obj0) => ((PackageService) obj0).CheckInitialized();

    internal static object bn1n2QB2DWOn5d4Rcy6d([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((IPackageRepository) obj0).FindPackage((string) obj1, (SemanticVersion) obj2);

    internal static object LlFdgHB2tYpvPMb6ShmA([In] object obj0) => (object) ((IElmaComponent) obj0).GetConfigurationPackageRepository();

    internal static object Fj3CPyB2wbTLI5x8Aqk9([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((LocalPackageRepository) obj0).FindPackage((string) obj1, (SemanticVersion) obj2);

    internal static object vWmE6ZB24OJSGSHm8iLS([In] object obj0) => (object) ((PackagingSettings) obj0).Repository;

    internal static bool z1xRNDB26eJrsbEvqFHa([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static object SGgbGkB2HKMoSVDJ5DaE([In] object obj0, [In] object obj1) => (object) ((PackageRepositoryFactory) obj0).CreateRepository((string) obj1);

    internal static void Pi67NPB2AnFLeI9rZ1Eb([In] object obj0) => File.Delete((string) obj0);

    internal static bool DAV3WmB27hQhc2jq6M5p([In] object obj0, [In] object obj1, [In] StringComparison obj2) => ((string) obj0).Equals((string) obj1, obj2);

    internal static object lV9xxvB2xqbOEIoHUIQY([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object ejqLmWB20GBmQsoQKXP7([In] Guid obj0) => (object) PackageOperationStatus.GenerateFileName(obj0);

    internal static object eRCv1MB2m8j36sbD4cuH([In] object obj0) => (object) ((PackagingHelper) obj0).GetOperationStatus();

    internal static object ihGPqDB2ywy2ehlxS93E([In] object obj0, [In] Guid obj1) => (object) ((PackagingHelper) obj0).GetOperationStatus(obj1);

    internal static object QLZ8nDB2MhqDivcWoDol([In] object obj0) => (object) ((PackageInfo) obj0).Id;

    internal static object Y48M0PB2JaJL42ZLbOnV([In] object obj0) => (object) ((PackageInfo) obj0).Version;

    internal static void eLZdlkB29aqmJLYmsRhI([In] object obj0, [In] object obj1) => File.Move((string) obj0, (string) obj1);

    internal static object YI2LyaB2dBs9o8oMTMio() => (object) EleWise.ELMA.Logging.Logger.Log;

    internal static void vOAJJNB2lfBvDwwO0BaA([In] object obj0, [In] object obj1, [In] object obj2) => ((EleWise.ELMA.Logging.ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static object RIRnrFB2rDxIWcKRcKFT([In] object obj0) => (object) ((IPackageFile) obj0).Path;

    internal static object jGN8ScB2gfR6KdL2i0gy([In] object obj0) => (object) Path.GetFileName((string) obj0);

    internal static object uZDrCuB25L9Fv34FKd0u([In] object obj0) => (object) ((IPackageFile) obj0).GetStream();

    internal static object Vk2nGdB2jsh58ac4e5rm() => (object) ComponentManager.Current;

    internal static bool E2vBXxB2YyhU8G09iaml([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static Guid qkiNirB2LOjLbJ54lOVP([In] object obj0) => ((IRuntimeApplication) obj0).ConfigurationUid;

    internal static bool Kgt7yrB2UoMx5JwsSpdJ([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static object M7QZIBB2sG1EC6e9RxKw([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static object ejLSfpB2cwbypd65fFJi(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) string.Format((string) obj0, obj1, obj2, obj3);
    }

    internal static object PcGLqjB2zFkgHYFNTYku() => (object) Encoding.UTF8;

    internal static object oO9UOTBeFh6mFShyWo3s([In] object obj0, [In] object obj1) => (object) ((Encoding) obj0).GetBytes((string) obj1);

    internal static bool UvMuWlBeBV8VvkRA9KeI([In] object obj0, [In] object obj1) => PEFile.AppendAdditionalData((string) obj0, (byte[]) obj1);

    internal static bool Ink5HQBeWKvxfRKHCZHu([In] object obj0) => ((IElmaComponent) obj0).IsInstalled();

    internal static Guid exEnydBeogCumrvpvqnm() => Guid.NewGuid();

    internal static object TGqrk3BebbuuKLWdJtGT([In] object obj0) => (object) ((IElmaComponent) obj0).ComponentRoot;

    internal static void x4qQYWBehxoepfgiwJeo([In] object obj0, PackageLevel value) => ((PackageFilter) obj0).Level = value;

    internal static void HiQU99BeGprPIxKNPZCv([In] object obj0, PackageStatus value) => ((PackageFilter) obj0).Status = value;

    internal static object pGZukjBeEfrNEZsHraO3([In] object obj0) => (object) ((PackagingSettings) obj0).Root;

    internal static object KlElDTBefWtrrOO3xY1D([In] object obj0, [In] object obj1, [In] object obj2) => (object) Path.Combine((string) obj0, (string) obj1, (string) obj2);

    internal static object ocucCrBeQxyUaF3es4NW([In] object obj0) => (object) ((Process) obj0).StartInfo;

    internal static void cVkRGOBeCjVCdxypBUF9([In] object obj0, [In] object obj1) => ((ProcessStartInfo) obj0).FileName = (string) obj1;

    internal static void pqytLSBev7kFJAToN9Qr([In] object obj0, [In] object obj1) => ((ProcessStartInfo) obj0).Arguments = (string) obj1;

    internal static void Wq9NG8Be8VNwMZryuCSN([In] object obj0, [In] object obj1) => ((ProcessStartInfo) obj0).Verb = (string) obj1;

    internal static bool wmE83RBeZr0A3dubfIj3([In] object obj0) => ((Process) obj0).Start();

    internal static void hVf9SOBeu3cK9eI5oJKh([In] object obj0, [In] PackageOperationStatusType obj1) => ((PackageOperationStatus) obj0).Type = obj1;

    internal static void EH81ncBeInTs3ZO2yAY0([In] object obj0, [In] object obj1) => ((PackageOperationStatus) obj0).Message = (string) obj1;

    internal static void gJOKAKBeVw2hJwJeWCnQ([In] object obj0, [In] object obj1, [In] object obj2) => ((PackagingHelper) obj0).SaveOperationStatus((string) obj1, (PackageOperationStatus) obj2);

    internal static object tGBlrqBeSB8Go47aQgSZ([In] object obj0) => (object) ((Exception) obj0).Message;

    internal static object rRuf2nBeiQolpIATNdqr([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static object Iy9m97BeR4xDRf1Oib2i([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static object GkggMqBeqbow9Ng9OKbL([In] object obj0, [In] object obj1) => (object) Expression.Property((Expression) obj0, (MethodInfo) obj1);

    internal static object tV3Tv8BeKQaQRECB2SMG([In] RuntimeFieldHandle obj0) => (object) FieldInfo.GetFieldFromHandle(obj0);

    internal static object AcvNbWBeXYPnDrrQ3PdX([In] object obj0, [In] object obj1) => (object) Expression.Field((Expression) obj0, (FieldInfo) obj1);

    internal static object MJ4f3pBeTys0rck1hxkh([In] object obj0, [In] Type obj1) => (object) Expression.Constant(obj0, obj1);

    internal static object q7irKrBekj6lndDm8ktH([In] object obj0, [In] object obj1, [In] bool obj2, [In] object obj3) => (object) Expression.LessThan((Expression) obj0, (Expression) obj1, obj2, (MethodInfo) obj3);

    internal static int oaJ0hrBenDlyo9MkhGNb([In] object obj0) => ((List<IPackage>) obj0).Count;

    internal static object yWRYBOBeONXfJJL7jb2n([In] object obj0) => (object) ((IPackageName) obj0).Version;

    internal static int KR6nAXBe25dvEE9o0qtu([In] object obj0) => ((Version) obj0).Major;

    internal static int Elv4tOBeeLwyOhxR4cqC([In] object obj0) => ((Version) obj0).Minor;

    internal static int ke8qaIBePSAq1CaTWJ9x([In] object obj0) => ((Version) obj0).Build;

    private enum SortExpressions
    {
      Installed,
      Priority,
      Type,
      Title,
    }

    private class PackageDescriptionComparer : IComparer<PackageDescription>
    {
      private IEnumerable<string> _sortExpressions;
      private static object uKGTQQQV3NUb3S5cskPB;

      public PackageDescriptionComparer(IEnumerable<string> sortExpressions)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        this._sortExpressions = sortExpressions;
      }

      public int Compare(PackageDescription x, PackageDescription y)
      {
        int num1 = 6;
        IEnumerator<string> enumerator;
        while (true)
        {
          switch (num1)
          {
            case 1:
              if (x == null)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 3 : 3;
                continue;
              }
              goto case 7;
            case 2:
              if (y == null)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 5 : 12;
                continue;
              }
              goto label_2;
            case 3:
            case 9:
              if (x == null)
              {
                num1 = 2;
                continue;
              }
              goto case 12;
            case 4:
              goto label_52;
            case 5:
              if (y != null)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 1 : 1;
                continue;
              }
              goto label_11;
            case 6:
              if (x == null)
              {
                num1 = 5;
                continue;
              }
              goto case 1;
            case 7:
              if (y != null)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 7 : 9;
                continue;
              }
              goto label_4;
            case 8:
              goto label_14;
            case 10:
              goto label_11;
            case 11:
              goto label_2;
            case 12:
              enumerator = this._sortExpressions.GetEnumerator();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 8 : 8;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return -1;
label_4:
        return 1;
label_11:
        return 0;
label_14:
        int num2;
        try
        {
label_25:
          if (PackageService.PackageDescriptionComparer.mVPyaMQVwJadp34mnxkJ((object) enumerator))
            goto label_35;
          else
            goto label_26;
label_16:
          string current;
          int num3;
          while (true)
          {
            int num4;
            int num5;
            int num6;
            int num7;
            int num8;
            switch (num3)
            {
              case 1:
              case 4:
              case 5:
              case 23:
                goto label_53;
              case 2:
                if (!current.Equals(PackageService.SortExpressions.Priority.ToString()))
                {
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 14 : 2;
                  continue;
                }
                goto case 25;
              case 3:
              case 16:
              case 17:
              case 22:
                goto label_25;
              case 6:
                if (num8 != 0)
                {
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 3 : 9;
                  continue;
                }
                goto label_25;
              case 7:
                num2 = num6;
                num3 = 23;
                continue;
              case 8:
                if (num7 == 0)
                {
                  num3 = 22;
                  continue;
                }
                goto case 13;
              case 9:
                num2 = num8;
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 5 : 3;
                continue;
              case 10:
                goto label_52;
              case 11:
                if (!PackageService.PackageDescriptionComparer.zoaB2QQVDyrFDerbAPN2((object) current, (object) PackageService.SortExpressions.Title.ToString()))
                {
                  num3 = 16;
                  continue;
                }
                goto default;
              case 12:
                num6 = this.GetInstalledValue(x) - this.GetInstalledValue(y);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 20 : 14;
                continue;
              case 13:
                num2 = num7;
                num3 = 4;
                continue;
              case 14:
              case 24:
                if (PackageService.PackageDescriptionComparer.zoaB2QQVDyrFDerbAPN2((object) current, (object) PackageService.SortExpressions.Type.ToString()))
                {
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 15 : 13;
                  continue;
                }
                goto case 11;
              case 15:
                num5 = this.GetModuleTypeValue(x) - this.GetModuleTypeValue(y);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 19 : 16;
                continue;
              case 18:
                num2 = num5;
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 1 : 0;
                continue;
              case 19:
                if (num5 != 0)
                {
                  num4 = 18;
                  break;
                }
                goto label_25;
              case 20:
                if (num6 == 0)
                {
                  num3 = 3;
                  continue;
                }
                goto case 7;
              case 21:
                if (PackageService.PackageDescriptionComparer.zoaB2QQVDyrFDerbAPN2((object) current, (object) PackageService.SortExpressions.Installed.ToString()))
                {
                  num3 = 12;
                  continue;
                }
                goto case 2;
              case 25:
                num8 = PackageService.PackageDescriptionComparer.cYa7juQVt4OkKswhWy6F((object) x) - PackageService.PackageDescriptionComparer.cYa7juQVt4OkKswhWy6F((object) y);
                num4 = 6;
                break;
              case 26:
                goto label_35;
              default:
                num7 = this.GetTitle(x).CompareTo(this.GetTitle(y));
                num3 = 8;
                continue;
            }
            num3 = num4;
          }
label_26:
          num3 = 10;
          goto label_16;
label_35:
          current = enumerator.Current;
          num3 = 21;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
          {
            num3 = 21;
            goto label_16;
          }
          else
            goto label_16;
        }
        finally
        {
          int num9;
          if (enumerator == null)
            num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 1 : 1;
          else
            goto label_48;
label_47:
          switch (num9)
          {
            case 1:
            case 2:
          }
label_48:
          PackageService.PackageDescriptionComparer.nMcC39QV4gvDHpce1DRR((object) enumerator);
          num9 = 2;
          goto label_47;
        }
label_53:
        return num2;
label_52:
        return 0;
      }

      private int GetInstalledValue(PackageDescription p)
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            case 2:
              if (PackageService.PackageDescriptionComparer.MMD0sWQV6KQalxq36nEk((object) p))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 1 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_2;
          }
        }
label_2:
        return 0;
label_3:
        return 1;
      }

      private int GetModuleTypeValue(PackageDescription p)
      {
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_2;
            case 2:
              if (PackageService.PackageDescriptionComparer.g3LZlQQVHIyKDWWe48C2((object) p) != ElmaPackageType.MobileApplication)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 4 : 4;
                continue;
              }
              goto label_7;
            case 3:
              if (PackageService.PackageDescriptionComparer.g3LZlQQVHIyKDWWe48C2((object) p) != ElmaPackageType.Application)
              {
                num = 2;
                continue;
              }
              goto label_8;
            case 4:
              if (p.Type != ElmaPackageType.Module)
              {
                num = 5;
                continue;
              }
              goto label_6;
            case 5:
              if (p.Type != ElmaPackageType.Core)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            case 6:
              if (PackageService.PackageDescriptionComparer.g3LZlQQVHIyKDWWe48C2((object) p) != ElmaPackageType.Help)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 1 : 1;
                continue;
              }
              goto label_3;
            default:
              if (PackageService.PackageDescriptionComparer.g3LZlQQVHIyKDWWe48C2((object) p) != ElmaPackageType.Integration)
              {
                num = 6;
                continue;
              }
              goto label_4;
          }
        }
label_2:
        return 0;
label_3:
        return 4;
label_4:
        return 8;
label_5:
        return 8;
label_6:
        return 10;
label_7:
        return 14;
label_8:
        return 20;
      }

      private string GetTitle(PackageDescription p)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (!PackageService.PackageDescriptionComparer.drkyESQV7a2bylTSSiKg(PackageService.PackageDescriptionComparer.StRj0uQVAgLoPOwHohCZ((object) p)))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_2;
            default:
              goto label_3;
          }
        }
label_2:
        return ((string) PackageService.PackageDescriptionComparer.QVQCFXQVxpw7RutyOsWq((object) p)).ToLower();
label_3:
        return ((string) PackageService.PackageDescriptionComparer.StRj0uQVAgLoPOwHohCZ((object) p)).ToLower();
      }

      internal static bool zoaB2QQVDyrFDerbAPN2([In] object obj0, [In] object obj1) => ((string) obj0).Equals((string) obj1);

      internal static int cYa7juQVt4OkKswhWy6F([In] object obj0) => ((PackageDescription) obj0).Priority;

      internal static bool mVPyaMQVwJadp34mnxkJ([In] object obj0) => ((IEnumerator) obj0).MoveNext();

      internal static void nMcC39QV4gvDHpce1DRR([In] object obj0) => ((IDisposable) obj0).Dispose();

      internal static bool TjwAM0QVpLQHBDRBX8xs() => PackageService.PackageDescriptionComparer.uKGTQQQV3NUb3S5cskPB == null;

      internal static PackageService.PackageDescriptionComparer J8RveNQVaWGUU29CHKgO() => (PackageService.PackageDescriptionComparer) PackageService.PackageDescriptionComparer.uKGTQQQV3NUb3S5cskPB;

      internal static bool MMD0sWQV6KQalxq36nEk([In] object obj0) => ((PackageDescription) obj0).IsInstalled;

      internal static ElmaPackageType g3LZlQQVHIyKDWWe48C2([In] object obj0) => ((PackageDescription) obj0).Type;

      internal static object StRj0uQVAgLoPOwHohCZ([In] object obj0) => (object) ((PackageDescription) obj0).Title;

      internal static bool drkyESQV7a2bylTSSiKg([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

      internal static object QVQCFXQVxpw7RutyOsWq([In] object obj0) => (object) ((PackageDescription) obj0).Id;
    }

    private class PackagingLogger : EleWise.ELMA.Packaging.Logging.ILogger
    {
      internal static object xubgOUQV0rPrMS5mdgcc;

      public bool IsEnabled(EleWise.ELMA.Packaging.Logging.LogLevel level) => PackageService.PackagingLogger.MofE0WQVJ5GLVQ3yhDsU(PackageService.PackagingLogger.t0sYd6QVMjSQRfmXGL4F(), this.ConvertLevel(level));

      public void Log(EleWise.ELMA.Packaging.Logging.LogLevel level, Exception exception, string format, params object[] args)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              EleWise.ELMA.Logging.Logger.Log.Log(this.ConvertLevel(level), exception, format, args);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      private EleWise.ELMA.Logging.LogLevel ConvertLevel(EleWise.ELMA.Packaging.Logging.LogLevel level)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              switch (level)
              {
                case EleWise.ELMA.Packaging.Logging.LogLevel.Verbose:
                  goto label_7;
                case EleWise.ELMA.Packaging.Logging.LogLevel.Trace:
                  goto label_6;
                case EleWise.ELMA.Packaging.Logging.LogLevel.Debug:
                  goto label_2;
                case EleWise.ELMA.Packaging.Logging.LogLevel.Information:
                  goto label_5;
                case EleWise.ELMA.Packaging.Logging.LogLevel.Warning:
                  goto label_8;
                case EleWise.ELMA.Packaging.Logging.LogLevel.Error:
                  goto label_3;
                case EleWise.ELMA.Packaging.Logging.LogLevel.Fatal:
                  goto label_4;
                default:
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 0;
                  continue;
              }
            case 2:
              goto label_2;
            default:
              goto label_9;
          }
        }
label_2:
        return EleWise.ELMA.Logging.LogLevel.Debug;
label_3:
        return EleWise.ELMA.Logging.LogLevel.Error;
label_4:
        return EleWise.ELMA.Logging.LogLevel.Fatal;
label_5:
        return EleWise.ELMA.Logging.LogLevel.Information;
label_6:
        return EleWise.ELMA.Logging.LogLevel.Trace;
label_7:
        return EleWise.ELMA.Logging.LogLevel.Verbose;
label_8:
        return EleWise.ELMA.Logging.LogLevel.Warning;
label_9:
        return EleWise.ELMA.Logging.LogLevel.Debug;
      }

      public PackagingLogger()
      {
        PackageService.PackagingLogger.d71fG5QV9EOTQltgYq3r();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static object t0sYd6QVMjSQRfmXGL4F() => (object) EleWise.ELMA.Logging.Logger.Log;

      internal static bool MofE0WQVJ5GLVQ3yhDsU([In] object obj0, EleWise.ELMA.Logging.LogLevel level) => ((EleWise.ELMA.Logging.ILogger) obj0).IsEnabled(level);

      internal static bool XeY5fdQVmKjWBmQZdOdH() => PackageService.PackagingLogger.xubgOUQV0rPrMS5mdgcc == null;

      internal static PackageService.PackagingLogger rfA5qUQVyuCaBRAdB9Qx() => (PackageService.PackagingLogger) PackageService.PackagingLogger.xubgOUQV0rPrMS5mdgcc;

      internal static void d71fG5QV9EOTQltgYq3r() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }
  }
}
