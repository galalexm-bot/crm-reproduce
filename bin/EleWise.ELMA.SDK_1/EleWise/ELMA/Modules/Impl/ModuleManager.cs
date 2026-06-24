// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Modules.Impl.ModuleManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Licensing;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Modules.Attributes;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Remoting;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using NuGet;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace EleWise.ELMA.Modules.Impl
{
  /// <summary>Менеджер модулей</summary>
  internal class ModuleManager : IModuleManager
  {
    private readonly ITransformationProvider transformationProvider;
    private readonly PackageService packageService;
    private Application mainApplication;
    private ConcurrentDictionary<string, IApplicationUnit> unitsById;
    private ConcurrentDictionary<string, IModule> modulesById;
    private ConcurrentDictionary<Guid, IApplicationUnit> unitsByUid;
    private ConcurrentDictionary<Guid, IModule> modulesByUid;
    private ConcurrentDictionary<Assembly, ModuleAssembly> assemblies;
    private ConcurrentDictionary<Assembly, Tuple<bool, ModuleDisabledReason>> assemblyAvailability;
    private Dictionary<Guid, ModuleStatus> serverModuleStatuses;
    private List<string> requiredModuleNames;
    private Dictionary<Guid, ModuleStatus> savedModulesStatuses;
    private List<ModuleManager.StoreComponentConfigurationInfo> installedStoreComponentInfos;
    private IEnumerable<string> activatedModules;
    private List<IStoreComponentInfo> infoToUpdateInDB;
    private static readonly EleWise.ELMA.Logging.ILogger log;
    private readonly DbPreUpdater dbPreUpdater;
    private static ModuleManager bstp4K34ECorWvCd3sT;

    /// <summary>Ctor</summary>
    /// <param name="assemblies">Коллекция сборок</param>
    /// <param name="packageService">Сервис для работы с пакетной системой</param>
    /// <param name="remoteServiceProvider">Провайдер для регистрации Remoting-сервисов</param>
    /// <param name="runtimeApplication">Реализация для работы со средой исполнения приложения</param>
    internal ModuleManager(
      IEnumerable<Assembly> assemblies,
      PackageService packageService,
      RemoteServiceProvider remoteServiceProvider,
      IRuntimeApplication runtimeApplication)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.unitsById = new ConcurrentDictionary<string, IApplicationUnit>();
      this.modulesById = new ConcurrentDictionary<string, IModule>();
      this.unitsByUid = new ConcurrentDictionary<Guid, IApplicationUnit>();
      this.modulesByUid = new ConcurrentDictionary<Guid, IModule>();
      this.assemblies = new ConcurrentDictionary<Assembly, ModuleAssembly>();
      this.assemblyAvailability = new ConcurrentDictionary<Assembly, Tuple<bool, ModuleDisabledReason>>();
      this.requiredModuleNames = new List<string>();
      this.savedModulesStatuses = new Dictionary<Guid, ModuleStatus>();
      this.installedStoreComponentInfos = new List<ModuleManager.StoreComponentConfigurationInfo>();
      this.infoToUpdateInDB = new List<IStoreComponentInfo>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      if (assemblies == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107983460));
      this.packageService = packageService != null ? packageService : throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088307646));
      if (remoteServiceProvider != null)
      {
        ServerInfoManager serviceWithoutProxy = remoteServiceProvider.GetServiceWithoutProxy<ServerInfoManager>();
        if (serviceWithoutProxy != null)
        {
          ModuleStatusInfo[] moduleStatuses = serviceWithoutProxy.GetModuleStatuses();
          this.serverModuleStatuses = new Dictionary<Guid, ModuleStatus>();
          foreach (ModuleStatusInfo moduleStatusInfo in moduleStatuses)
            this.serverModuleStatuses[moduleStatusInfo.Uid] = moduleStatusInfo.Status;
        }
      }
      if (runtimeApplication != null)
      {
        this.dbPreUpdater = runtimeApplication.DbPreUpdater;
        this.requiredModuleNames.AddRange(this.dbPreUpdater.GetAssemblyModelNames().Where<string>((System.Func<string, bool>) (n =>
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                // ISSUE: reference to a compiler-generated method
                if (ModuleManager.\u003C\u003Ec.XgqvosfJIrWclnXP30C2((object) n, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-122002947 ^ 122000486), StringComparison.CurrentCultureIgnoreCase))
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
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
          // ISSUE: reference to a compiler-generated method
          return !ModuleManager.\u003C\u003Ec.XgqvosfJIrWclnXP30C2((object) n, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(2045296739 + 1688595713 ^ -561076406), StringComparison.CurrentCultureIgnoreCase);
label_3:
          return false;
        })));
        this.transformationProvider = runtimeApplication.TransformationProvider;
        this.LoadSavedModuleStatuses();
        this.LoadStoreComponentConfigurationInfos();
        this.activatedModules = this.dbPreUpdater.GetActivatedModules();
      }
      string path1 = AppDomain.CurrentDomain.BaseDirectory;
      if (string.IsNullOrEmpty(path1) && AppDomain.CurrentDomain.SetupInformation.ConfigurationFile != null)
        path1 = Path.GetDirectoryName(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
      Dictionary<Guid, Module> dictionary = new Dictionary<Guid, Module>();
      List<ModuleAssembly> moduleAssemblyList = new List<ModuleAssembly>();
      foreach (Assembly assembly in assemblies)
      {
        Logger.Log.InfoFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~289714581 ^ -289719344), (object) assembly.FullName, (object) assembly.CodeBase);
        AssemblyLicenseUnitAttribute licenseUnitAttr;
        try
        {
          licenseUnitAttr = assembly.GetCustomAttributes(typeof (AssemblyLicenseUnitAttribute), false).Cast<AssemblyLicenseUnitAttribute>().Where<AssemblyLicenseUnitAttribute>((System.Func<AssemblyLicenseUnitAttribute, bool>) (a =>
          {
            int num = 2;
            while (true)
            {
              switch (num)
              {
                case 1:
                  goto label_3;
                case 2:
                  // ISSUE: reference to a compiler-generated method
                  if ((a.ComponentType & ModuleManager.\u003C\u003Ec.uYglVbfJViIFyaDw3iYZ((object) ComponentManager.Current)) != (ComponentType) 0)
                  {
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 1 : 0;
                    continue;
                  }
                  goto label_2;
                default:
                  goto label_2;
              }
            }
label_2:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            return ModuleManager.\u003C\u003Ec.uYglVbfJViIFyaDw3iYZ(ModuleManager.\u003C\u003Ec.Eb5w7GfJSlwI2HCQ3kHU()) == (ComponentType) 0;
label_3:
            return true;
          })).FirstOrDefault<AssemblyLicenseUnitAttribute>();
        }
        catch (Exception ex)
        {
          throw new InvalidOperationException(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1052221104 - 768835541 ^ 283405077), (object) assembly.FullName), ex);
        }
        ModuleAssembly moduleAssembly = licenseUnitAttr != null ? (ModuleAssembly) new LicensedModuleAssembly(assembly, licenseUnitAttr) : new ModuleAssembly(assembly);
        moduleAssemblyList.Add(moduleAssembly);
        this.RegisterUnit((IApplicationUnit) moduleAssembly);
        if (AttributeHelper<ModuleAttribute>.GetAttribute(assembly) != null)
        {
          ModuleInfoMetadata info = new ModuleInfoMetadata();
          info.LoadFromAssembly(assembly);
          Module unit = new Module(info, (IModuleAssembly) moduleAssembly);
          dictionary[unit.Uid] = unit;
          this.RegisterUnit((IApplicationUnit) unit);
        }
        this.assemblies[assembly] = moduleAssembly;
      }
      List<ModuleAssembly> processedModuleAssemblies = new List<ModuleAssembly>();
      foreach (ModuleAssembly asm in moduleAssemblyList)
      {
        Module module;
        if (dictionary.TryGetValue(asm.ModuleUid, out module))
        {
          module.AddAssembly((IModuleAssembly) asm);
          asm.Owner = (IApplicationUnit) module;
          processedModuleAssemblies.Add(asm);
        }
      }
      moduleAssemblyList.RemoveAll((Predicate<ModuleAssembly>) (a => processedModuleAssemblies.Contains(a)));
      string path = !string.IsNullOrEmpty(path1) ? Path.Combine(path1, z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 1418451112)) : (string) null;
      ApplicationDescriptor descriptor = (ApplicationDescriptor) null;
      if (path != null)
      {
        if (File.Exists(path))
        {
          try
          {
            descriptor = ClassSerializationHelper.DeserializeObjectByXml<ApplicationDescriptor>(File.ReadAllBytes(path));
          }
          catch (Exception ex)
          {
            Logger.Log.Error((object) (z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051276242 - 990076387 ^ 61186987) + path), ex);
          }
        }
      }
      if (descriptor == null)
        descriptor = new ApplicationDescriptor()
        {
          Uid = Guid.NewGuid(),
          Id = z2jc63fLkugS1X8Q9N.tE1kD1vbB(1925118608 << 2 ^ -889479966),
          Title = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051802738 - -1831968059 ^ -1411207407))
        };
      List<Module> processedModules = new List<Module>();
      Module module1 = descriptor.MainModule != null ? ModuleManager.FindModule((IEnumerable<Module>) dictionary.Values, (object) descriptor.MainModule) : (Module) null;
      if (module1 != null)
        processedModules.Add(module1);
      ILicensedUnit module2 = descriptor.MainLicensedUnit != null ? (ILicensedUnit) ModuleManager.FindModule((IEnumerable<Module>) dictionary.Values, (object) descriptor.MainLicensedUnit) : (ILicensedUnit) null;
      this.mainApplication = new Application(descriptor, module1, module2);
      this.RegisterUnit((IApplicationUnit) this.mainApplication);
      if (descriptor.Modules != null)
      {
        foreach (ApplicationDescriptor.ModuleReference module3 in descriptor.Modules)
        {
          Module module4 = ModuleManager.FindModule((IEnumerable<Module>) dictionary.Values, (object) module3);
          if (module4 != null && !processedModules.Contains(module4))
          {
            module4.Owner = (IApplicationUnit) this.mainApplication;
            this.mainApplication.AddSystemModule((IModule) module4);
            processedModules.Add(module4);
          }
        }
      }
      foreach (Module module5 in dictionary.Values.Where<Module>((System.Func<Module, bool>) (m1 => !processedModules.Contains(m1))))
      {
        this.mainApplication.AddExtensionModule((IModule) module5);
        processedModules.Add(module5);
      }
    }

    /// <summary>MainApplication</summary>
    public IApplication MainApplication => (IApplication) this.mainApplication;

    /// <summary>Лицензируемая часть приложения</summary>
    public ILicensedUnit MainLicensedUnit
    {
      get
      {
        int num = 1;
        object mainLicensedUnit;
        while (true)
        {
          switch (num)
          {
            case 1:
              mainLicensedUnit = ModuleManager.BVcm5i3AuIFiiyn3CWX((object) this.mainApplication);
              if (mainLicensedUnit == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_5;
          }
        }
label_2:
        return (ILicensedUnit) mainLicensedUnit;
label_5:
        return (ILicensedUnit) this.mainApplication;
      }
    }

    /// <summary>Дата окончания лицензии</summary>
    /// <returns></returns>
    public DateTime? GetMainLicensedUnitExpiration()
    {
      if (!(this.MainApplication is ILicensedUnit mainApplication))
        return new DateTime?();
      return !(mainApplication.GetLicenseInfo() is ITrialLicenseInfo licenseInfo) ? new DateTime?() : licenseInfo.TrialExpiration;
    }

    /// <summary>
    /// Поиск лицензируемой часть приложения по строковому идентификатору
    /// </summary>
    /// <param name="id">Строковый идентификатор</param>
    /// <returns></returns>
    public IApplicationUnit FindUnitById(string id)
    {
      int num = 1;
      IApplicationUnit unitById;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.unitsById.TryGetValue(id, out unitById))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return unitById;
label_5:
      return (IApplicationUnit) null;
    }

    /// <summary>
    /// Поиск лицензируемой часть приложения по уникальному идентификатору
    /// </summary>
    /// <param name="uid">Уникальный идентификатор</param>
    /// <returns></returns>
    public IApplicationUnit FindUnitByUid(Guid uid)
    {
      int num = 1;
      IApplicationUnit unitByUid;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!this.unitsByUid.TryGetValue(uid, out unitByUid))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            goto label_4;
          default:
            goto label_5;
        }
      }
label_4:
      return unitByUid;
label_5:
      return (IApplicationUnit) null;
    }

    /// <summary>Поиск модуля по строковому идентификатору</summary>
    /// <param name="id">Строковый идентификатор</param>
    /// <returns></returns>
    public IModule FindModuleById(string id)
    {
      int num = 1;
      IModule moduleById;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.modulesById.TryGetValue(id, out moduleById))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return moduleById;
label_5:
      return (IModule) null;
    }

    /// <summary>Проверка доступности сборки</summary>
    /// <param name="assembly">Сборка</param>
    /// <returns></returns>
    public bool IsAssemblyAvailable(Assembly assembly) => this.IsAssemblyAvailable(assembly, out ModuleDisabledReason _);

    /// <summary>Проверка доступности сборки</summary>
    /// <param name="assembly">Сборка</param>
    /// <param name="disabledReason">Тип причины отключения модуля</param>
    /// <returns></returns>
    public bool IsAssemblyAvailable(Assembly assembly, out ModuleDisabledReason disabledReason)
    {
      int num = 1;
      Stack<Assembly> checkStack;
      while (true)
      {
        switch (num)
        {
          case 1:
            checkStack = new Stack<Assembly>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return this.IsAssemblyAvailable(assembly, checkStack, out disabledReason);
    }

    private bool IsAssemblyAvailable(
      Assembly assembly,
      Stack<Assembly> checkStack,
      out ModuleDisabledReason disabledReason)
    {
      disabledReason = ModuleDisabledReason.Unknown;
      if (assembly == (Assembly) null)
        return false;
      if (checkStack == null)
        checkStack = new Stack<Assembly>();
      if (checkStack.Contains(assembly))
        return true;
      Tuple<bool, ModuleDisabledReason> tuple;
      if (this.assemblyAvailability.TryGetValue(assembly, out tuple))
      {
        disabledReason = tuple.Item2;
        return tuple.Item1;
      }
      lock (this.assemblyAvailability)
      {
        if (this.assemblyAvailability.TryGetValue(assembly, out tuple))
        {
          disabledReason = tuple.Item2;
          return tuple.Item1;
        }
        ModuleAssembly moduleAssembly;
        if (!this.assemblies.TryGetValue(assembly, out moduleAssembly))
        {
          this.assemblyAvailability[assembly] = new Tuple<bool, ModuleDisabledReason>(true, ModuleDisabledReason.Unknown);
          return true;
        }
        for (IApplicationUnit owner = moduleAssembly.Owner; owner != null; owner = owner.Owner)
        {
          if (owner is IModule module && module.Status != ModuleStatus.Enabled)
          {
            disabledReason = module.DisabledReason;
            this.assemblyAvailability[assembly] = new Tuple<bool, ModuleDisabledReason>(false, disabledReason);
            ModuleManager.log.WarnFormat(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1514961705 ^ 1514933757)), (object) moduleAssembly.Assembly.FullName, (object) module.Title, (object) disabledReason.ToString());
            return false;
          }
        }
        checkStack.Push(assembly);
        foreach (AssemblyName referencedAssembly in assembly.GetReferencedAssemblies())
        {
          AssemblyName refAsmName = referencedAssembly;
          if (!(refAsmName.FullName == assembly.FullName))
          {
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            Assembly assembly1 = ((IEnumerable<Assembly>) AppDomain.CurrentDomain.GetAssemblies()).FirstOrDefault<Assembly>((System.Func<Assembly, bool>) (a => ModuleManager.\u003C\u003Ec__DisplayClass11_0.nk2Wy1fJ756mOX87aa8x((object) ComponentManager.GetAssemblyShortName(a), ModuleManager.\u003C\u003Ec__DisplayClass11_0.gEANmjfJAkSfRZI0keI6((object) refAsmName))));
            if (assembly1 != (Assembly) null && !this.IsAssemblyAvailable(assembly1, checkStack, out disabledReason))
            {
              disabledReason = ModuleDisabledReason.Dependency;
              this.assemblyAvailability[assembly] = new Tuple<bool, ModuleDisabledReason>(false, ModuleDisabledReason.Dependency);
              ModuleManager.log.WarnFormat(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398682574)), (object) assembly.FullName, (object) assembly1.FullName);
              checkStack.Pop();
              return false;
            }
          }
        }
        this.assemblyAvailability[assembly] = new Tuple<bool, ModuleDisabledReason>(true, ModuleDisabledReason.Unknown);
        checkStack.Pop();
        return true;
      }
    }

    /// <summary>Поиск модуля владеющего сборкой</summary>
    /// <param name="assembly">Сборка</param>
    /// <returns></returns>
    public IModule FindModuleByAssembly(Assembly assembly)
    {
      int num = 2;
      IApplicationUnit applicationUnit;
      IModule moduleByAssembly;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            ModuleAssembly moduleAssembly;
            if (this.assemblies.TryGetValue(assembly, out moduleAssembly))
            {
              applicationUnit = moduleAssembly.Owner;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 6 : 1;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 1 : 1;
            continue;
          case 3:
          case 4:
            moduleByAssembly = applicationUnit as IModule;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 5 : 5;
            continue;
          case 5:
            if (moduleByAssembly != null)
            {
              num = 7;
              continue;
            }
            applicationUnit = (IApplicationUnit) ModuleManager.y9Rw7s37vtuqDCQyife((object) applicationUnit);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
            continue;
          case 7:
            goto label_12;
          case 8:
            goto label_4;
          default:
            if (applicationUnit != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 4 : 1;
              continue;
            }
            goto label_4;
        }
      }
label_2:
      return (IModule) null;
label_4:
      return (IModule) null;
label_12:
      return moduleByAssembly;
    }

    /// <summary>Сохранить информацию о запущенных компонентах</summary>
    public void SaveStartedModuleInfos()
    {
      int num1 = 2;
      List<IStoreComponentInfo>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_14;
          case 1:
            goto label_3;
          case 2:
            enumerator = this.infoToUpdateInDB.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 1 : 0;
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
label_6:
        if (enumerator.MoveNext())
          goto label_9;
        else
          goto label_7;
label_4:
        IStoreComponentInfo current;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_5;
            case 2:
              this.SaveStoreComponentInfo(current, StoreComponentStatus.Active);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 1 : 3;
              continue;
            case 3:
              goto label_6;
            default:
              goto label_9;
          }
        }
label_5:
        return;
label_7:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 1 : 0;
        goto label_4;
label_9:
        current = enumerator.Current;
        num2 = 2;
        goto label_4;
      }
      finally
      {
        enumerator.Dispose();
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
    }

    /// <summary>Проверка доступности компонентов системы</summary>
    internal void UpdateModuleStatuses()
    {
      int num1 = 1;
      IStartInformation startInformation;
      while (true)
      {
        switch (num1)
        {
          case 1:
            startInformation = (IStartInformation) ModuleManager.xd3TkY30TRJgcA0Gcwk(90.0, ModuleManager.viBoOG3xGktHcXIjbKZ((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -882137454)));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_12;
          default:
            goto label_3;
        }
      }
label_12:
      return;
label_3:
      try
      {
        this.ExecuteUpdateModuleStatuses();
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      finally
      {
        int num3;
        if (startInformation == null)
          num3 = 2;
        else
          goto label_13;
label_10:
        switch (num3)
        {
          case 1:
          case 2:
        }
label_13:
        ModuleManager.iuHeM53mWnmLRYCDxGL((object) startInformation);
        num3 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
        {
          num3 = 1;
          goto label_10;
        }
        else
          goto label_10;
      }
    }

    /// <summary>Проверка доступности компонентов системы</summary>
    internal void ExecuteUpdateModuleStatuses()
    {
      int num1 = 40;
      while (true)
      {
        int num2 = num1;
        List<ModuleManager.StoreComponentConfigurationInfo> list1;
        IEnumerable<IStoreComponentInfo> storeComponentsInfo;
        IStartInformation startInformation;
        List<IStoreComponentInfo> list2;
        while (true)
        {
          IElmaComponent packagingComponent;
          List<IStoreComponentInfo> list3;
          string repositoryPath;
          IEnumerator<string> enumerator;
          List<ModuleManager.StoreComponentConfigurationInfo> list4;
          IStoreComponentInfo storeComponentInfo1;
          object obj;
          HashSet<string> deprecatedPackageIds;
          switch (num2)
          {
            case 1:
              List<IStoreComponentInfo> source1 = list2;
              // ISSUE: reference to a compiler-generated field
              System.Func<IStoreComponentInfo, bool> func1 = ModuleManager.\u003C\u003Ec.\u003C\u003E9__15_4;
              System.Func<IStoreComponentInfo, bool> predicate1;
              if (func1 == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                ModuleManager.\u003C\u003Ec.\u003C\u003E9__15_4 = predicate1 = (System.Func<IStoreComponentInfo, bool>) (i => ModuleManager.\u003C\u003Ec.d09vfMfJKiQfaES3vGCF(ModuleManager.\u003C\u003Ec.NGbW0efJqZ7ntbFRVRQP((object) i), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317763220)));
              }
              else
                goto label_86;
label_136:
              if (source1.Any<IStoreComponentInfo>(predicate1))
              {
                ModuleManager.UpdateConfigurationPackagesFolder((object) packagingComponent, list2);
                num2 = 4;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 41 : 11;
              continue;
label_86:
              predicate1 = func1;
              goto label_136;
            case 2:
              ModuleManager.UpdateConfigurationPackagesFolder((object) packagingComponent, list2);
              num2 = 46;
              continue;
            case 3:
              goto label_5;
            case 4:
              list4 = list2.Select<IStoreComponentInfo, ModuleManager.StoreComponentConfigurationInfo>((System.Func<IStoreComponentInfo, ModuleManager.StoreComponentConfigurationInfo>) (i =>
              {
                int num3 = 1;
                ManifestStoreComponentInfo storeComponentInfo2;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      storeComponentInfo2 = i as ManifestStoreComponentInfo;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_3;
                  }
                }
label_3:
                ModuleManager.StoreComponentConfigurationInfo configurationInfo = new ModuleManager.StoreComponentConfigurationInfo((IModuleManager) this);
                ModuleManager.rkFdxe3LbLmFXWqaDBK((object) configurationInfo, ModuleManager.jJPY6WprI100In2IOGe((object) i));
                ModuleManager.xhl4Ab3sIas6KSoKJAA((object) configurationInfo, ModuleManager.ByS20C3UIDGVZNSBNUu((object) i));
                configurationInfo.Version = !((SemanticVersion) ModuleManager.gwsKGy3cAuMQuMLtXfm((object) i) != (SemanticVersion) null) ? (string) null : ModuleManager.gwsKGy3cAuMQuMLtXfm((object) i).ToString();
                configurationInfo.Manifest = storeComponentInfo2?.InstalledManifest;
                return configurationInfo;
              })).ToList<ModuleManager.StoreComponentConfigurationInfo>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 37 : 49;
              continue;
            case 5:
              // ISSUE: reference to a compiler-generated method
              ModuleManager.fb0eAe3rAXkRVCqXPRS((object) Logger.Log, ModuleManager.JY5ViB3lQGjSNqgjRWT(ModuleManager.yONloC3ygB4MNggpRib(-630932142 - 1120244082 ^ -1751166516), (object) string.Join((string) ModuleManager.yONloC3ygB4MNggpRib(-281842504 ^ -281845574), storeComponentInfo1.AllPackages.Where<PackageDescription>((System.Func<PackageDescription, bool>) (p => !ModuleManager.\u003C\u003Ec.KZvqR2fJXUweBmIWbmRZ((object) p))).Select<PackageDescription, string>((System.Func<PackageDescription, string>) (p => p.Id)))));
              num2 = 47;
              continue;
            case 6:
              startInformation = (IStartInformation) ModuleManager.xd3TkY30TRJgcA0Gcwk(50.0, ModuleManager.viBoOG3xGktHcXIjbKZ(ModuleManager.yONloC3ygB4MNggpRib(-97972138 ^ -97949470)));
              num2 = 45;
              continue;
            case 7:
              goto label_6;
            case 8:
label_37:
              if (ModuleManager.YXwOUB39tk7WWU7qYpd((object) this.installedStoreComponentInfos) > 0)
              {
                num2 = 10;
                continue;
              }
              goto label_63;
            case 9:
              try
              {
label_72:
                if (enumerator.MoveNext())
                  goto label_84;
                else
                  goto label_73;
label_71:
                string current;
                int num4;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      goto label_72;
                    case 2:
                      goto label_84;
                    case 3:
                      goto label_74;
                    case 4:
                      goto label_147;
                    default:
                      ModuleManager.log.DebugFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1113862659 ^ 1113868795), (object) current);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 3 : 1;
                      continue;
                  }
                }
label_74:
                try
                {
                  if (File.Exists(current))
                  {
                    int num5 = 1;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
                      num5 = 1;
                    while (true)
                    {
                      switch (num5)
                      {
                        case 1:
                          ModuleManager.kRCEf935Iwk42OJbs5K((object) current);
                          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 0 : 0;
                          continue;
                        default:
                          goto label_72;
                      }
                    }
                  }
                  else
                    goto label_72;
                }
                catch
                {
                  int num6 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
                    num6 = 0;
                  while (true)
                  {
                    switch (num6)
                    {
                      case 1:
                        goto label_72;
                      default:
                        ModuleManager.log.ErrorFormat((string) ModuleManager.yONloC3ygB4MNggpRib(1304605005 ^ 1304612165), (object) current);
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 1 : 1;
                        continue;
                    }
                  }
                }
label_73:
                num4 = 4;
                goto label_71;
label_84:
                current = enumerator.Current;
                num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
                {
                  num4 = 0;
                  goto label_71;
                }
                else
                  goto label_71;
              }
              finally
              {
                if (enumerator != null)
                {
                  int num7 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
                    num7 = 0;
                  while (true)
                  {
                    switch (num7)
                    {
                      case 1:
                        ModuleManager.iuHeM53mWnmLRYCDxGL((object) enumerator);
                        num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_92;
                    }
                  }
                }
label_92:;
              }
            case 10:
              startInformation = (IStartInformation) ModuleManager.xd3TkY30TRJgcA0Gcwk(95.0, ModuleManager.viBoOG3xGktHcXIjbKZ(ModuleManager.yONloC3ygB4MNggpRib(1051276242 - 990076387 ^ 61189271)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 20 : 20;
              continue;
            case 11:
              num2 = 25;
              continue;
            case 12:
              if (ModuleManager.YXwOUB39tk7WWU7qYpd((object) this.installedStoreComponentInfos) != 0)
              {
                ModuleManager.log.DebugFormat((string) ModuleManager.yONloC3ygB4MNggpRib(333888594 ^ 1075625116 ^ 1408924558));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 2 : 1;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 1 : 0;
              continue;
            case 13:
              goto label_68;
            case 14:
              if (packagingComponent != null)
              {
                num2 = 16;
                continue;
              }
              goto label_144;
            case 15:
              if (list3.Count > 0)
              {
                num2 = 28;
                continue;
              }
              goto case 19;
            case 16:
              if (!ModuleManager.VYyCqi3JOYKnxSFMxKe((object) packagingComponent))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 26 : 2;
                continue;
              }
              goto case 11;
            case 17:
              obj = (object) null;
              break;
            case 18:
label_93:
              startInformation = (IStartInformation) ModuleManager.xd3TkY30TRJgcA0Gcwk(40.0, ModuleManager.viBoOG3xGktHcXIjbKZ(ModuleManager.yONloC3ygB4MNggpRib(372753449 ^ 372751445)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 7 : 4;
              continue;
            case 19:
label_147:
              // ISSUE: reference to a compiler-generated method
              list1 = storeComponentsInfo.Where<IStoreComponentInfo>((System.Func<IStoreComponentInfo, bool>) (i => ModuleManager.\u003C\u003Ec.URXMpIfJRPH0iktvlWwC((object) i) == ModuleStatus.Enabled)).Select<IStoreComponentInfo, ModuleManager.StoreComponentConfigurationInfo>((System.Func<IStoreComponentInfo, ModuleManager.StoreComponentConfigurationInfo>) (i =>
              {
                int num8 = 1;
                ModuleManager.StoreComponentConfigurationInfo configurationInfo1;
                IStoreComponentInfo i1;
                while (true)
                {
                  switch (num8)
                  {
                    case 1:
                      num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 0;
                      continue;
                    case 2:
                      goto label_6;
                    case 3:
                      // ISSUE: reference to a compiler-generated method
                      configurationInfo1 = this.installedStoreComponentInfos.FirstOrDefault<ModuleManager.StoreComponentConfigurationInfo>((System.Func<ModuleManager.StoreComponentConfigurationInfo, bool>) (c => c.Id == (string) ModuleManager.\u003C\u003Ec__DisplayClass15_1.mJEn6vfJlWZqrDHt9wXr((object) i1)));
                      if (configurationInfo1 == null)
                      {
                        num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 2 : 0;
                        continue;
                      }
                      goto label_7;
                    default:
                      i1 = i;
                      num8 = 3;
                      continue;
                  }
                }
label_7:
                return configurationInfo1;
label_6:
                ModuleManager.StoreComponentConfigurationInfo configurationInfo2 = new ModuleManager.StoreComponentConfigurationInfo((IModuleManager) this);
                ModuleManager.rkFdxe3LbLmFXWqaDBK((object) configurationInfo2, ModuleManager.jJPY6WprI100In2IOGe((object) i1));
                configurationInfo2.Title = i1.Title;
                configurationInfo2.Version = (SemanticVersion) ModuleManager.gwsKGy3cAuMQuMLtXfm((object) i1) != (SemanticVersion) null ? ModuleManager.gwsKGy3cAuMQuMLtXfm((object) i1).ToString() : (string) null;
                ModuleManager.m9pQrSpWnf13sPhlEc4((object) configurationInfo2, !(i1 is ManifestStoreComponentInfo storeComponentInfo4) ? (object) null : ModuleManager.fKTUiapgJybd8MyoSSb((object) storeComponentInfo4));
                return configurationInfo2;
              })).ToList<ModuleManager.StoreComponentConfigurationInfo>();
              num2 = 31;
              continue;
            case 20:
              try
              {
                // ISSUE: reference to a compiler-generated method
                IEnumerable<ModuleManager.StoreComponentConfigurationInfo> installedStoreComponentInfos = this.installedStoreComponentInfos.Where<ModuleManager.StoreComponentConfigurationInfo>((System.Func<ModuleManager.StoreComponentConfigurationInfo, bool>) (c => !deprecatedPackageIds.Contains((string) ModuleManager.\u003C\u003Ec__DisplayClass15_0.leFUxgfJMqA1Cj5Mks9o((object) c))));
                int num9 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
                  num9 = 0;
                while (true)
                {
                  switch (num9)
                  {
                    case 1:
                      this.CheckRequiredComponentsForConfiguration(packagingComponent, installedStoreComponentInfos, storeComponentsInfo);
                      num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_93;
                  }
                }
              }
              finally
              {
                if (startInformation != null)
                {
                  int num10 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
                    num10 = 0;
                  while (true)
                  {
                    switch (num10)
                    {
                      case 1:
                        goto label_123;
                      default:
                        ModuleManager.iuHeM53mWnmLRYCDxGL((object) startInformation);
                        num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 1 : 1;
                        continue;
                    }
                  }
                }
label_123:;
              }
            case 21:
label_32:
              startInformation = (IStartInformation) ModuleManager.xd3TkY30TRJgcA0Gcwk(4.0, (object) EleWise.ELMA.SR.M((string) ModuleManager.yONloC3ygB4MNggpRib(1242972401 >> 4 ^ 77667443)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 0;
              continue;
            case 22:
label_59:
              if (this.packageService.Initialized)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 10 : 43;
                continue;
              }
              goto case 17;
            case 23:
              if (this.installedStoreComponentInfos.Count > 0)
              {
                num2 = 27;
                continue;
              }
              goto label_132;
            case 24:
              if (this.transformationProvider != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 14 : 4;
                continue;
              }
              goto label_139;
            case 25:
              // ISSUE: reference to a compiler-generated method
              deprecatedPackageIds = packagingComponent.GetInstalledPackagesInfo().SelectMany<PackageInfo, PackageUninstallDependency>((System.Func<PackageInfo, IEnumerable<PackageUninstallDependency>>) (info => info.Package.UninstallDependencies.EmptyIfNull<PackageUninstallDependency>())).Select<PackageUninstallDependency, string>((System.Func<PackageUninstallDependency, string>) (dep => (string) ModuleManager.\u003C\u003Ec.Fig36bfJi50dOVhomum0((object) dep))).ToHashSet<string>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 6 : 5;
              continue;
            case 26:
              goto label_134;
            case 27:
              this.CheckComponentsStatusForConfiguration(packagingComponent, (IEnumerable<ModuleManager.StoreComponentConfigurationInfo>) this.installedStoreComponentInfos, storeComponentsInfo);
              num2 = 33;
              continue;
            case 28:
              repositoryPath = (string) ModuleManager.e5GOnH3gL6FkjYerpVx((object) packagingComponent);
              num2 = 52;
              continue;
            case 29:
              try
              {
                storeComponentsInfo = this.packageService.GetStoreComponentsInfo(false);
                int num11 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
                  num11 = 0;
                switch (num11)
                {
                  default:
                    goto label_37;
                }
              }
              finally
              {
                if (startInformation != null)
                {
                  int num12 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
                    num12 = 0;
                  while (true)
                  {
                    switch (num12)
                    {
                      case 1:
                        goto label_58;
                      default:
                        ModuleManager.iuHeM53mWnmLRYCDxGL((object) startInformation);
                        num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 1 : 1;
                        continue;
                    }
                  }
                }
label_58:;
              }
            case 30:
              EleWise.ELMA.Logging.ILogger log = ModuleManager.log;
              object format = ModuleManager.yONloC3ygB4MNggpRib(-710283084 ^ -537863435 ^ 173627091);
              object[] objArray = new object[1];
              List<ModuleManager.StoreComponentConfigurationInfo> source2 = list1;
              // ISSUE: reference to a compiler-generated field
              System.Func<ModuleManager.StoreComponentConfigurationInfo, string> func2 = ModuleManager.\u003C\u003Ec.\u003C\u003E9__15_12;
              System.Func<ModuleManager.StoreComponentConfigurationInfo, string> selector;
              if (func2 == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                ModuleManager.\u003C\u003Ec.\u003C\u003E9__15_12 = selector = (System.Func<ModuleManager.StoreComponentConfigurationInfo, string>) (item => string.Format((string) ModuleManager.\u003C\u003Ec.TLpCyMfJTMJ1YITq5kHL(-1837662597 ^ -1838016085), ModuleManager.\u003C\u003Ec.RSOXQIfJkYMvmq3G3hAo(), ModuleManager.\u003C\u003Ec.Njc2tyfJnhg3mBiiug8t((object) item), ModuleManager.\u003C\u003Ec.jjVRuofJOFf7VHC3Xb9x((object) item)));
              }
              else
                goto label_152;
label_151:
              objArray[0] = (object) string.Concat(source2.Select<ModuleManager.StoreComponentConfigurationInfo, string>(selector));
              log.DebugFormat((string) format, objArray);
              num2 = 36;
              continue;
label_152:
              selector = func2;
              goto label_151;
            case 31:
              if (!ModuleManager.log.IsDebugEnabled())
              {
                num2 = 48;
                continue;
              }
              goto case 30;
            case 32:
              this.installedStoreComponentInfos.AddRange((IEnumerable<ModuleManager.StoreComponentConfigurationInfo>) list4);
              num2 = 38;
              continue;
            case 33:
              goto label_132;
            case 34:
label_14:
              startInformation = (IStartInformation) ModuleManager.xd3TkY30TRJgcA0Gcwk(95.0, ModuleManager.viBoOG3xGktHcXIjbKZ(ModuleManager.yONloC3ygB4MNggpRib(-1978478350 ^ -1978488352)));
              num2 = 29;
              continue;
            case 35:
              this.installedStoreComponentInfos.Clear();
              num2 = 32;
              continue;
            case 36:
            case 48:
              this.SaveStoreComponentConfigurationInfos((IEnumerable<ModuleManager.StoreComponentConfigurationInfo>) list1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 44 : 17;
              continue;
            case 37:
              if (!storeComponentInfo1.IsInstalled)
              {
                num2 = 5;
                continue;
              }
              goto label_18;
            case 38:
              goto label_149;
            case 39:
              try
              {
                this.UpdateModuleStatusesByActivation();
                int num13 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
                  num13 = 0;
                switch (num13)
                {
                  default:
                    goto label_32;
                }
              }
              finally
              {
                int num14;
                if (startInformation == null)
                  num14 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 0;
                else
                  goto label_29;
label_28:
                switch (num14)
                {
                  case 1:
                    break;
                  default:
                }
label_29:
                ModuleManager.iuHeM53mWnmLRYCDxGL((object) startInformation);
                num14 = 2;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
                {
                  num14 = 2;
                  goto label_28;
                }
                else
                  goto label_28;
              }
            case 40:
              startInformation = (IStartInformation) ModuleManager.xd3TkY30TRJgcA0Gcwk(4.0, (object) EleWise.ELMA.SR.M((string) ModuleManager.yONloC3ygB4MNggpRib(--1867379187 ^ 1867352503)));
              num2 = 39;
              continue;
            case 41:
              IEnumerable<IStoreComponentInfo> source3 = storeComponentsInfo;
              // ISSUE: reference to a compiler-generated field
              System.Func<IStoreComponentInfo, bool> func3 = ModuleManager.\u003C\u003Ec.\u003C\u003E9__15_6;
              System.Func<IStoreComponentInfo, bool> predicate2;
              if (func3 == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                ModuleManager.\u003C\u003Ec.\u003C\u003E9__15_6 = predicate2 = (System.Func<IStoreComponentInfo, bool>) (i => ModuleManager.\u003C\u003Ec.d09vfMfJKiQfaES3vGCF(ModuleManager.\u003C\u003Ec.NGbW0efJqZ7ntbFRVRQP((object) i), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-649342099 - -1150814748 ^ 501433909)));
              }
              else
                goto label_153;
label_141:
              storeComponentInfo1 = source3.FirstOrDefault<IStoreComponentInfo>(predicate2);
              num2 = 51;
              continue;
label_153:
              predicate2 = func3;
              goto label_141;
            case 42:
              goto label_63;
            case 43:
              obj = ModuleManager.Au5noq3MyumEpUNuXEA((object) this.packageService);
              break;
            case 44:
              this.installedStoreComponentInfos.Clear();
              num2 = 3;
              continue;
            case 45:
              try
              {
                this.UpdateModuleStatusesByPackages();
                int num15 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
                  num15 = 0;
                switch (num15)
                {
                  default:
                    goto label_14;
                }
              }
              finally
              {
                int num16;
                if (startInformation == null)
                  num16 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 2 : 2;
                else
                  goto label_100;
label_99:
                switch (num16)
                {
                  case 1:
                  case 2:
                }
label_100:
                ModuleManager.iuHeM53mWnmLRYCDxGL((object) startInformation);
                num16 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
                {
                  num16 = 1;
                  goto label_99;
                }
                else
                  goto label_99;
              }
            case 46:
              IEnumerable<IStoreComponentInfo> source4 = storeComponentsInfo;
              // ISSUE: reference to a compiler-generated field
              System.Func<IStoreComponentInfo, bool> func4 = ModuleManager.\u003C\u003Ec.\u003C\u003E9__15_9;
              System.Func<IStoreComponentInfo, bool> predicate3;
              if (func4 == null)
              {
                // ISSUE: reference to a compiler-generated field
                ModuleManager.\u003C\u003Ec.\u003C\u003E9__15_9 = predicate3 = (System.Func<IStoreComponentInfo, bool>) (i =>
                {
                  int num17 = 1;
                  while (true)
                  {
                    switch (num17)
                    {
                      case 1:
                        // ISSUE: reference to a compiler-generated method
                        if (ModuleManager.\u003C\u003Ec.URXMpIfJRPH0iktvlWwC((object) i) == ModuleStatus.Disabled)
                        {
                          num17 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
                          continue;
                        }
                        goto label_5;
                      default:
                        goto label_4;
                    }
                  }
label_4:
                  return i.DisabledReason == ModuleDisabledReason.Deprecated;
label_5:
                  return false;
                });
              }
              else
                goto label_154;
label_146:
              list3 = source4.Where<IStoreComponentInfo>(predicate3).ToList<IStoreComponentInfo>();
              num2 = 15;
              continue;
label_154:
              predicate3 = func4;
              goto label_146;
            case 47:
              goto label_17;
            case 49:
              this.SaveStoreComponentConfigurationInfos((IEnumerable<ModuleManager.StoreComponentConfigurationInfo>) list4);
              num2 = 35;
              continue;
            case 50:
              goto label_39;
            case 51:
              if (storeComponentInfo1 != null)
              {
                num2 = 37;
                continue;
              }
              goto label_39;
            case 52:
              IEnumerable<string> deprecatedComponentFiles = ModuleManager.GetDeprecatedComponentFiles((IEnumerable<IStoreComponentInfo>) list3, (object) repositoryPath);
              ModuleManager.log.DebugFormat((string) ModuleManager.yONloC3ygB4MNggpRib(-1886646897 ^ -1886619919));
              enumerator = deprecatedComponentFiles.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 9 : 9;
              continue;
            default:
              try
              {
                this.UpdateModuleStatusesByDependencies();
                int num18 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
                  num18 = 0;
                switch (num18)
                {
                  default:
                    goto label_59;
                }
              }
              finally
              {
                int num19;
                if (startInformation == null)
                  num19 = 2;
                else
                  goto label_111;
label_110:
                switch (num19)
                {
                  case 1:
                    break;
                  default:
                }
label_111:
                startInformation.Dispose();
                num19 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0)
                {
                  num19 = 0;
                  goto label_110;
                }
                else
                  goto label_110;
              }
          }
          packagingComponent = (IElmaComponent) obj;
          num2 = 24;
        }
label_5:
        this.installedStoreComponentInfos.AddRange((IEnumerable<ModuleManager.StoreComponentConfigurationInfo>) list1);
        num1 = 13;
        continue;
label_6:
        try
        {
          this.UpdateModuleStatusesByComponents(storeComponentsInfo);
          int num20 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
            num20 = 0;
          switch (num20)
          {
          }
        }
        finally
        {
          int num21;
          if (startInformation == null)
            num21 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 0 : 0;
          else
            goto label_12;
label_11:
          switch (num21)
          {
            case 1:
              break;
            default:
          }
label_12:
          ModuleManager.iuHeM53mWnmLRYCDxGL((object) startInformation);
          num21 = 2;
          goto label_11;
        }
label_63:
        this.UpdateModuleStatusesByDependencies();
        num1 = 23;
        continue;
label_132:
        // ISSUE: reference to a compiler-generated method
        list2 = storeComponentsInfo.Where<IStoreComponentInfo>((System.Func<IStoreComponentInfo, bool>) (i => ModuleManager.\u003C\u003Ec.URXMpIfJRPH0iktvlWwC((object) i) == ModuleStatus.Enabled)).ToList<IStoreComponentInfo>();
        num1 = 12;
      }
label_68:
      return;
label_134:
      return;
label_149:
      return;
label_144:
      return;
label_17:
      throw new InvalidOperationException((string) ModuleManager.T6y7cn3dwy25eMCwujO(ModuleManager.yONloC3ygB4MNggpRib(1253244298 - 1829393894 ^ -576135886)));
label_18:
      throw new InvalidOperationException((string) ModuleManager.T6y7cn3dwy25eMCwujO(ModuleManager.yONloC3ygB4MNggpRib(~-306453669 ^ 306472522)));
label_139:
      return;
label_39:
      throw new InvalidOperationException((string) ModuleManager.T6y7cn3dwy25eMCwujO(ModuleManager.yONloC3ygB4MNggpRib(-606654180 ^ -606648128)));
    }

    private static void UpdateConfigurationPackagesFolder(
      object packagingComponent,
      List<IStoreComponentInfo> enabledComponentInfos)
    {
      string packagesDirectory = ((IElmaComponent) packagingComponent).GetConfigurationPackagesDirectory();
      if (string.IsNullOrEmpty(packagesDirectory))
        return;
      if (!Directory.Exists(packagesDirectory))
        Directory.CreateDirectory(packagesDirectory);
      foreach (ManifestStoreComponentInfo storeComponentInfo in enabledComponentInfos.OfType<ManifestStoreComponentInfo>())
      {
        ModuleManager.log.InfoFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1350312861 << 3 ^ 2082381774), (object) storeComponentInfo.Id, (object) storeComponentInfo.InstalledVersion, (object) storeComponentInfo.LastVersion);
        if (storeComponentInfo.InstalledFile != null && storeComponentInfo.InstalledManifest.ProductType != ManifestComponentType.Platform)
        {
          string path2 = storeComponentInfo.InstalledManifest.Id + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1350312861 << 3 ^ 2082404828) + storeComponentInfo.InstalledManifest.Version + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477163368);
          string str = Path.Combine(packagesDirectory, path2);
          if (!File.Exists(str))
          {
            ModuleManager.log.InfoFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(277947046 - -1479185048 ^ 1757137004), (object) str);
            using (StartInformation.Operation(StartInformation.Current.Percent, EleWise.ELMA.SR.M(z2jc63fLkugS1X8Q9N.tE1kD1vbB(95909607 + 343705423 ^ 439583652), (object) storeComponentInfo.InstalledManifest.Id)))
              storeComponentInfo.InstalledFile.SaveTo(str);
          }
        }
      }
    }

    /// <summary>
    /// Получить коллекцию строковых идентификаторов отсутствующих, но необходимых сборок
    /// </summary>
    /// <returns></returns>
    public IEnumerable<string> GetMissedRequiredModules()
    {
      List<string> missedRequiredModules = new List<string>();
      foreach (string requiredModuleName in this.requiredModuleNames)
      {
        string moduleName = requiredModuleName;
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        if (this.unitsByUid.Values.OfType<IModuleAssembly>().FirstOrDefault<IModuleAssembly>((System.Func<IModuleAssembly, bool>) (m => ModuleManager.\u003C\u003Ec__DisplayClass17_0.p8R23ifJYaE7atLyTERw(ModuleManager.\u003C\u003Ec__DisplayClass17_0.QbKnbbfJjf1EChl1NmkE((object) m), (object) moduleName, StringComparison.CurrentCultureIgnoreCase))) == null)
          missedRequiredModules.Add(moduleName);
      }
      return (IEnumerable<string>) missedRequiredModules;
    }

    /// <summary>
    /// Получить коллекцию строковых идентификаторов недоступных, но необходимых и лицензируемых частей приложения
    /// </summary>
    /// <returns></returns>
    public IEnumerable<string> GetDisableRequiredModules()
    {
      List<string> disableRequiredModules = new List<string>();
      foreach (string requiredModuleName in this.requiredModuleNames)
      {
        string moduleName = requiredModuleName;
        // ISSUE: reference to a compiler-generated method
        IModuleAssembly moduleAssembly = this.unitsByUid.Values.OfType<IModuleAssembly>().FirstOrDefault<IModuleAssembly>((System.Func<IModuleAssembly, bool>) (m => ModuleManager.\u003C\u003Ec__DisplayClass18_0.pO1pJlfJzF6CwGRaJZDt((object) m.Id, (object) moduleName, StringComparison.CurrentCultureIgnoreCase)));
        if (moduleAssembly != null)
        {
          for (IApplicationUnit owner = moduleAssembly.Owner; owner != null; owner = owner.Owner)
          {
            if (owner is ILicensedUnit licensedUnit)
            {
              ILicenseInfo licenseInfo = licensedUnit.GetLicenseInfo();
              if (licenseInfo != null && licenseInfo.Status != LicenseStatus.Activated)
              {
                if (!disableRequiredModules.Contains(owner.Title))
                {
                  disableRequiredModules.Add(owner.Title);
                  break;
                }
                break;
              }
            }
          }
        }
      }
      return (IEnumerable<string>) disableRequiredModules;
    }

    /// <summary>Сохранить статус модуля</summary>
    /// <param name="uid">Уникальный идентификатор</param>
    /// <param name="status">Статус модуля</param>
    public void SaveModuleStatus(Guid uid, ModuleStatus status)
    {
      int num = 1;
      IModule module;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_4;
          case 1:
            if (!this.modulesByUid.TryGetValue(uid, out module))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
              continue;
            }
            goto case 2;
          case 2:
            ModuleManager.DLkNZ13jvE6BDLmf2Cg((object) (ModuleBase) module, ModuleStatus.RestartRequired);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 4 : 4;
            continue;
          case 3:
            goto label_2;
          case 4:
            this.SaveModuleStatusToDb(uid, status);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 3;
            continue;
          default:
            goto label_8;
        }
      }
label_4:
      return;
label_2:
      return;
label_8:;
    }

    /// <summary>
    /// Сохранить информацию о подключенном компоненте ELMA Store
    /// </summary>
    /// <param name="manifest">Манифест компонента</param>
    /// <param name="signatures">Подписи компонента</param>
    /// <param name="fileName">Полный путь до файла компонента</param>
    /// <param name="status">Если Allowed, то информация записывается в базу только в том случае, если данный компонент еще не был установлен. Если Active - в любом случае.</param>
    public void SaveStoreComponent(
      ElmaStoreComponentManifest manifest,
      IEnumerable<StoreComponentSignatureInfo> signatures,
      string fileName,
      StoreComponentStatus status,
      string unpackedPackagesFolder = null)
    {
      if (manifest == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675485767));
      if (string.IsNullOrEmpty(fileName))
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487389060));
      this.packageService.SaveStoreComponentFileToConfiguration(manifest, fileName, unpackedPackagesFolder);
      this.SaveStoreComponentInfo(manifest, signatures, status);
    }

    /// <summary>
    /// Сохранить информацию о подключенном компоненте ELMA Store без файла компонента
    /// </summary>
    /// <param name="info">Информация о компоненте</param>
    /// <param name="status">Если Allowed, то информация записывается в базу только в том случае, если данный компонент еще не был установлен. Если Active - в любом случае.</param>
    public void SaveStoreComponentInfo(IStoreComponentInfo info, StoreComponentStatus status)
    {
      int num1 = 5;
      IEnumerator<Module> enumerator;
      while (true)
      {
        int num2 = num1;
        ModuleManager.StoreComponentConfigurationInfo configurationInfo1;
        ModuleManager.StoreComponentConfigurationInfo info2;
        while (true)
        {
          ManifestStoreComponentInfo storeComponentInfo;
          object obj1;
          IStoreComponentInfo info1;
          switch (num2)
          {
            case 1:
              if (status == StoreComponentStatus.Allowed)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 16 : 7;
                continue;
              }
              goto case 3;
            case 2:
              if (storeComponentInfo != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 7 : 7;
                continue;
              }
              goto case 10;
            case 3:
              storeComponentInfo = info1 as ManifestStoreComponentInfo;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 8 : 18;
              continue;
            case 4:
              info1 = info;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 15 : 6;
              continue;
            case 5:
              num2 = 4;
              continue;
            case 6:
              info2.InitLicensedUnit();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 24 : 5;
              continue;
            case 7:
              object obj2 = ModuleManager.Mxao2GpoH3j3rHjDeqf((object) storeComponentInfo);
              if (obj2 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 22 : 8;
                continue;
              }
              obj1 = obj2;
              break;
            case 8:
              this.installedStoreComponentInfos.Remove(configurationInfo1);
              num2 = 12;
              continue;
            case 9:
              goto label_44;
            case 10:
              obj1 = (object) null;
              break;
            case 11:
              goto label_32;
            case 12:
              this.installedStoreComponentInfos.Add(info2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 12 : 20;
              continue;
            case 13:
              if (configurationInfo1 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 30 : 28;
                continue;
              }
              goto case 3;
            case 14:
              goto label_4;
            case 15:
              if (info1 != null)
              {
                // ISSUE: reference to a compiler-generated method
                configurationInfo1 = this.installedStoreComponentInfos.FirstOrDefault<ModuleManager.StoreComponentConfigurationInfo>((System.Func<ModuleManager.StoreComponentConfigurationInfo, bool>) (i => i.Id.Equals((string) ModuleManager.\u003C\u003Ec__DisplayClass21_0.deka1df9biHQ1M62q73o((object) info1), StringComparison.CurrentCultureIgnoreCase)));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 13 : 13;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 26 : 21;
              continue;
            case 16:
              goto label_62;
            case 17:
              ModuleManager.iwYfvvpfg3gZfFMs6td((object) info2, ModuleManager.axXbShpExox4KD0IfdS((object) configurationInfo1));
              num2 = 25;
              continue;
            case 18:
              ModuleManager.StoreComponentConfigurationInfo configurationInfo2 = new ModuleManager.StoreComponentConfigurationInfo((IModuleManager) this);
              ModuleManager.rkFdxe3LbLmFXWqaDBK((object) configurationInfo2, (object) info1.Id);
              ModuleManager.xhl4Ab3sIas6KSoKJAA((object) configurationInfo2, ModuleManager.ByS20C3UIDGVZNSBNUu((object) info1));
              ModuleManager.RYyZt8pFHQCPdFvpZGX((object) configurationInfo2, ModuleManager.AwOZwt3zbx1CXTaF9kw(ModuleManager.gwsKGy3cAuMQuMLtXfm((object) info1), (object) null) ? (object) ModuleManager.gwsKGy3cAuMQuMLtXfm((object) info1).ToString() : (!(info1.LastVersion != (SemanticVersion) null) ? (object) "" : (object) info1.LastVersion.ToString()));
              configurationInfo2.Status = status;
              object obj3;
              if (storeComponentInfo == null)
              {
                obj3 = (object) null;
              }
              else
              {
                ElmaStoreComponentManifest installedManifest = storeComponentInfo.InstalledManifest;
                obj3 = installedManifest == null ? ModuleManager.SFeA9OpB0kWZ4CZ69VS((object) storeComponentInfo) : (object) installedManifest;
              }
              ModuleManager.m9pQrSpWnf13sPhlEc4((object) configurationInfo2, obj3);
              info2 = configurationInfo2;
              num2 = 2;
              continue;
            case 19:
              if (status != StoreComponentStatus.Active)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 29;
                continue;
              }
              goto case 23;
            case 20:
            case 29:
              if (ModuleManager.ngtxIXpQl2A3PXVLYB6((object) info1) == ModuleStatus.Disabled)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 27 : 1;
                continue;
              }
              goto label_56;
            case 21:
label_8:
              info2.Signatures = ((ElmaStoreComponentFile) ModuleManager.KwFBXKpbx8pGbmVOeUF((object) storeComponentInfo)).GetSignatures();
              num2 = 6;
              continue;
            case 22:
              obj1 = ModuleManager.KwFBXKpbx8pGbmVOeUF((object) storeComponentInfo);
              break;
            case 23:
              if (configurationInfo1 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 8;
                continue;
              }
              goto case 12;
            case 25:
              this.SaveStoreComponentConfigurationInfo(info2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 19 : 16;
              continue;
            case 26:
              goto label_19;
            case 27:
              if (ModuleManager.zck0uqpCnRQt4SNTHOI((object) info1) == ModuleDisabledReason.DisabledManually)
              {
                num2 = 28;
                continue;
              }
              goto label_53;
            case 28:
              IEnumerable<Module> source = info1.AllModules.OfType<Module>();
              // ISSUE: reference to a compiler-generated field
              System.Func<Module, bool> func = ModuleManager.\u003C\u003Ec.\u003C\u003E9__21_1;
              System.Func<Module, bool> predicate;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                ModuleManager.\u003C\u003Ec.\u003C\u003E9__21_1 = predicate = (System.Func<Module, bool>) (m =>
                {
                  int num3 = 1;
                  while (true)
                  {
                    switch (num3)
                    {
                      case 1:
                        // ISSUE: reference to a compiler-generated method
                        if (ModuleManager.\u003C\u003Ec.AIhApHfJ2Z5c69RkKvy6((object) m) == ModuleStatus.Disabled)
                        {
                          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 0 : 0;
                          continue;
                        }
                        goto label_5;
                      default:
                        goto label_4;
                    }
                  }
label_4:
                  // ISSUE: reference to a compiler-generated method
                  return ModuleManager.\u003C\u003Ec.zWrf2UfJeMyqKSp8LIQs((object) m) == ModuleDisabledReason.DisabledManually;
label_5:
                  return false;
                });
              }
              else
                goto label_66;
label_64:
              enumerator = source.Where<Module>(predicate).GetEnumerator();
              num2 = 11;
              continue;
label_66:
              predicate = func;
              goto label_64;
            case 30:
              if (ModuleManager.nWhm5b3YKIDl314M13q((object) configurationInfo1) != StoreComponentStatus.Active)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 2 : 3;
                continue;
              }
              goto case 1;
            default:
              if (configurationInfo1 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 9;
                continue;
              }
              goto case 25;
          }
          if (obj1 == null)
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
          else
            goto label_8;
        }
label_44:
        ModuleManager.oVRZM8pGulEWGGvneFD((object) info2, ModuleManager.Wsce5IphTR50SQ5rsEu((object) configurationInfo1));
        num1 = 17;
      }
label_4:
      return;
label_62:
      return;
label_56:
      return;
label_19:
      throw new ArgumentNullException((string) ModuleManager.yONloC3ygB4MNggpRib(92412609 - 1050237057 ^ -957827322));
label_53:
      return;
label_32:
      try
      {
label_36:
        if (ModuleManager.yiHGD7pvyVKFJQpxj3Y((object) enumerator))
          goto label_34;
        else
          goto label_37;
label_33:
        int num4;
        switch (num4)
        {
          case 1:
            return;
          case 2:
            goto label_36;
        }
label_34:
        ModuleManager.DLkNZ13jvE6BDLmf2Cg((object) enumerator.Current, ModuleStatus.RestartRequired);
        num4 = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
        {
          num4 = 2;
          goto label_33;
        }
        else
          goto label_33;
label_37:
        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 1 : 1;
        goto label_33;
      }
      finally
      {
        if (enumerator != null)
        {
          int num5 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0)
            num5 = 0;
          while (true)
          {
            switch (num5)
            {
              case 1:
                goto label_43;
              default:
                ModuleManager.iuHeM53mWnmLRYCDxGL((object) enumerator);
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 1 : 0;
                continue;
            }
          }
        }
label_43:;
      }
    }

    /// <summary>Обновить информацию о компоненте ELMA Store</summary>
    /// <param name="info">Информация о компоненте ELMA Store</param>
    /// <param name="status">Статус авторазвертывания компонента ELMA</param>
    public void UpdateAutoDeployComponentInfo(
      ModuleManager.StoreComponentConfigurationInfo info,
      AutoDeployComponentStatus status)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.UpdateAutoDeployComponentInfo(info, new AutoDeployComponentStatus?(status), (SemanticVersion) null);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Обновить информацию о компоненте ELMA Store</summary>
    /// <param name="info">Информация о компоненте ELMA Store</param>
    /// <param name="version">Версия в типе NuGet</param>
    public void UpdateAutoDeployComponentInfo(
      ModuleManager.StoreComponentConfigurationInfo info,
      SemanticVersion version)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.UpdateAutoDeployComponentInfo(info, new AutoDeployComponentStatus?(), version);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Обновить информацию о компоненте ELMA Store</summary>
    /// <param name="info">Информация о компоненте ELMA Store</param>
    /// <param name="status">Статус авторазвертывания компонента ELMA</param>
    /// <param name="version">Версия в типе NuGet</param>
    public void UpdateAutoDeployComponentInfo(
      ModuleManager.StoreComponentConfigurationInfo info,
      AutoDeployComponentStatus status,
      SemanticVersion version)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.UpdateAutoDeployComponentInfo(info, new AutoDeployComponentStatus?(status), version);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    private void UpdateAutoDeployComponentInfo(
      ModuleManager.StoreComponentConfigurationInfo info,
      AutoDeployComponentStatus? status,
      SemanticVersion version)
    {
      if (info == null)
        return;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      ModuleManager.StoreComponentConfigurationInfo info1 = this.installedStoreComponentInfos.FirstOrDefault<ModuleManager.StoreComponentConfigurationInfo>((System.Func<ModuleManager.StoreComponentConfigurationInfo, bool>) (i => ModuleManager.\u003C\u003Ec__DisplayClass25_0.mbthBUf9Cgq64HBDiy6S((object) i.Id, ModuleManager.\u003C\u003Ec__DisplayClass25_0.xPphUof9QtI0jbpoAOIj((object) info), StringComparison.CurrentCultureIgnoreCase)));
      if (info1 != null)
      {
        if (status.HasValue)
          info1.DeployStatus = status.Value;
        if (version != (SemanticVersion) null)
          info1.SemanticDeployVersion = version;
        info = info1;
        this.SaveStoreComponentConfigurationInfo(info1);
      }
      else
      {
        if (status.HasValue)
          info.DeployStatus = status.Value;
        if (version != (SemanticVersion) null)
          info.SemanticDeployVersion = version;
        this.SaveStoreComponentConfigurationInfo(info);
        if (this.installedStoreComponentInfos.Contains(info))
          return;
        this.installedStoreComponentInfos.Add(info);
      }
    }

    /// <summary>Получить манифесты установленных компонентов</summary>
    /// <returns></returns>
    public IEnumerable<ElmaStoreComponentManifest> GetInstalledComponentManifests() => (IEnumerable<ElmaStoreComponentManifest>) this.installedStoreComponentInfos.Where<ModuleManager.StoreComponentConfigurationInfo>((System.Func<ModuleManager.StoreComponentConfigurationInfo, bool>) (i => ModuleManager.\u003C\u003Ec.hcY4I0fJPAHCTCUp9cyJ((object) i) != null)).Select<ModuleManager.StoreComponentConfigurationInfo, ElmaStoreComponentManifest>((System.Func<ModuleManager.StoreComponentConfigurationInfo, ElmaStoreComponentManifest>) (i => (ElmaStoreComponentManifest) ModuleManager.\u003C\u003Ec.hcY4I0fJPAHCTCUp9cyJ((object) i))).ToList<ElmaStoreComponentManifest>();

    /// <summary>Получить манифесты установленных компонентов</summary>
    /// <returns></returns>
    internal IEnumerable<ModuleManager.StoreComponentConfigurationInfo> GetInstalledComponentInfos() => (IEnumerable<ModuleManager.StoreComponentConfigurationInfo>) this.installedStoreComponentInfos.ToArray();

    /// <summary>Получить пакеты компонента</summary>
    /// <param name="componentId"></param>
    /// <returns></returns>
    public virtual IEnumerable<PackageManifest> GetComponentPackages(string componentId)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      ElmaStoreComponentManifest component = this.GetInstalledComponentManifests().FirstOrDefault<ElmaStoreComponentManifest>((System.Func<ElmaStoreComponentManifest, bool>) (c => ModuleManager.\u003C\u003Ec__DisplayClass28_0.JM28Lqf9VGOAKAmrwhAQ(ModuleManager.\u003C\u003Ec__DisplayClass28_0.m29dXIf9IcTXAcIUYnCb((object) c), (object) componentId)));
      if (component == null)
        return (IEnumerable<PackageManifest>) null;
      List<PackageManifest> packages = new List<PackageManifest>();
      this.GetPackagesFromComponent(component, packages);
      return (IEnumerable<PackageManifest>) packages;
    }

    /// <summary>Получить пакеты компонента (рекурсия)</summary>
    /// <param name="component">Описание компонента Elma Store</param>
    /// <param name="packages">Коллекция описаний пакетов</param>
    protected virtual void GetPackagesFromComponent(
      ElmaStoreComponentManifest component,
      List<PackageManifest> packages)
    {
      foreach (PackageManifest package1 in component.Packages)
      {
        PackageManifest package = package1;
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        if (packages.All<PackageManifest>((System.Func<PackageManifest, bool>) (p => ModuleManager.\u003C\u003Ec__DisplayClass29_0.HERY69f9XLrlIVPAwlCU(ModuleManager.\u003C\u003Ec__DisplayClass29_0.BJMkvGf9KFxt1kF8aL7u((object) p), ModuleManager.\u003C\u003Ec__DisplayClass29_0.BJMkvGf9KFxt1kF8aL7u((object) package)))))
          packages.Add(package);
      }
      if (component.Dependencies == null || component.Dependencies.Count <= 0)
        return;
      List<ElmaStoreComponentManifest> list = this.GetInstalledComponentManifests().ToList<ElmaStoreComponentManifest>();
      foreach (ElmaStoreComponentDependency dependency1 in component.Dependencies)
      {
        ElmaStoreComponentDependency dependency = dependency1;
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        ElmaStoreComponentManifest component1 = list.FirstOrDefault<ElmaStoreComponentManifest>((System.Func<ElmaStoreComponentManifest, bool>) (c => ModuleManager.\u003C\u003Ec__DisplayClass29_1.SeDxhWf9PeMaJUf1ll4i(ModuleManager.\u003C\u003Ec__DisplayClass29_1.sH27QWf92je8O1VvDL1o((object) c), ModuleManager.\u003C\u003Ec__DisplayClass29_1.Q0BCUtf9e0DMPQvxopyN((object) dependency))));
        if (component1 != null)
          this.GetPackagesFromComponent(component1, packages);
      }
    }

    private static Module FindModule(IEnumerable<Module> modules, object moduleRef)
    {
      ApplicationDescriptor.ModuleReference moduleRef1 = (ApplicationDescriptor.ModuleReference) moduleRef;
      if (moduleRef1 == null)
        return (Module) null;
      if (moduleRef1.Uid != Guid.Empty)
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        return modules.FirstOrDefault<Module>((System.Func<Module, bool>) (m => ModuleManager.\u003C\u003Ec__DisplayClass47_0.mZtENvf9tUXP7vHksZtO(ModuleManager.\u003C\u003Ec__DisplayClass47_0.RTZvmqf9aQnVQCfq4Yce((object) m), ModuleManager.\u003C\u003Ec__DisplayClass47_0.CyFnFbf9DKFa6oGEhPul((object) moduleRef1))));
      }
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return !string.IsNullOrEmpty(moduleRef1.Id) ? modules.FirstOrDefault<Module>((System.Func<Module, bool>) (m => ModuleManager.\u003C\u003Ec__DisplayClass47_0.RKgNjbf94B2mMXpP1ACE((object) m.Id, ModuleManager.\u003C\u003Ec__DisplayClass47_0.zbPMOLf9waIJjXu2b9j3((object) moduleRef1)))) : (Module) null;
    }

    private void RegisterUnit(IApplicationUnit unit)
    {
      int num = 6;
      IModule module;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.modulesByUid[ModuleManager.HbHbtIpZSxNStZA7kQ9((object) module)] = module;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
            continue;
          case 2:
            this.modulesById[(string) ModuleManager.thF2eJp85704Nk54WwF((object) module)] = module;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 1 : 1;
            continue;
          case 3:
            module = unit as IModule;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 4 : 0;
            continue;
          case 4:
            if (module != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 2 : 0;
              continue;
            }
            goto label_10;
          case 5:
            this.unitsByUid[ModuleManager.HbHbtIpZSxNStZA7kQ9((object) unit)] = unit;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 3 : 3;
            continue;
          case 6:
            this.unitsById[(string) ModuleManager.thF2eJp85704Nk54WwF((object) unit)] = unit;
            num = 5;
            continue;
          default:
            goto label_11;
        }
      }
label_2:
      return;
label_11:
      return;
label_10:;
    }

    private void SaveStoreComponentInfo(
      ElmaStoreComponentManifest manifest,
      IEnumerable<StoreComponentSignatureInfo> signatures,
      StoreComponentStatus status)
    {
      if (manifest == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 1867354101));
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      ModuleManager.StoreComponentConfigurationInfo configurationInfo = this.installedStoreComponentInfos.FirstOrDefault<ModuleManager.StoreComponentConfigurationInfo>((System.Func<ModuleManager.StoreComponentConfigurationInfo, bool>) (i => ModuleManager.\u003C\u003Ec__DisplayClass49_0.sXThbTf90QVPsJ9hJcKF((object) i.Id, ModuleManager.\u003C\u003Ec__DisplayClass49_0.UJGOexf9xdjGgMbMDviQ((object) manifest), StringComparison.CurrentCultureIgnoreCase)));
      if (configurationInfo != null && configurationInfo.Status == StoreComponentStatus.Active && status == StoreComponentStatus.Allowed)
        return;
      ModuleManager.StoreComponentConfigurationInfo info = new ModuleManager.StoreComponentConfigurationInfo((IModuleManager) this, manifest, signatures, status);
      if (configurationInfo != null)
      {
        info.DeployStatus = configurationInfo.DeployStatus;
        info.DeployVersion = configurationInfo.DeployVersion;
      }
      this.SaveStoreComponentConfigurationInfo(info);
      if (status != StoreComponentStatus.Active)
        return;
      if (configurationInfo != null)
        this.installedStoreComponentInfos.Remove(configurationInfo);
      this.installedStoreComponentInfos.Add(info);
    }

    /// <summary>
    /// Обновить статусы модулей (по доступности сборок и текущим статусам модулей)
    /// </summary>
    private void UpdateModuleStatusesByDependencies()
    {
      int num1 = 1;
      IEnumerator<ModuleBase> enumerator1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            ModuleManager.soLcsrpuMFAfRcbevLd((object) this.assemblyAvailability);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_31;
          case 3:
            goto label_2;
          default:
            enumerator1 = this.unitsByUid.Values.OfType<ModuleBase>().GetEnumerator();
            num1 = 3;
            continue;
        }
      }
label_31:
      return;
label_2:
      try
      {
label_4:
        if (ModuleManager.yiHGD7pvyVKFJQpxj3Y((object) enumerator1))
          goto label_24;
        else
          goto label_5;
label_3:
        ModuleBase current1;
        IEnumerator<IModuleAssembly> enumerator2;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_4;
            case 2:
              enumerator2 = current1.Assemblies.GetEnumerator();
              num2 = 4;
              continue;
            case 3:
              goto label_26;
            case 4:
              goto label_6;
            default:
              goto label_24;
          }
        }
label_26:
        return;
label_6:
        try
        {
label_14:
          if (ModuleManager.yiHGD7pvyVKFJQpxj3Y((object) enumerator2))
            goto label_12;
          else
            goto label_15;
label_7:
          ModuleDisabledReason disabledReason;
          IModuleAssembly current2;
          int num3;
          while (true)
          {
            switch (num3)
            {
              case 1:
                ModuleManager.jpkPjwpSod5pILbep3X((object) current1, disabledReason);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 2 : 2;
                continue;
              case 2:
              case 6:
                goto label_4;
              case 3:
                goto label_12;
              case 4:
                goto label_14;
              case 5:
                if (ModuleManager.P7RptNpVLamYrCNwPMO((object) current1) != ModuleStatus.Disabled)
                {
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 7 : 5;
                  continue;
                }
                goto label_14;
              case 7:
                ModuleManager.DLkNZ13jvE6BDLmf2Cg((object) current1, ModuleStatus.Disabled);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 1 : 1;
                continue;
              default:
                if (!this.IsAssemblyAvailable((Assembly) ModuleManager.fMZA9kpI308HGCkyBLl((object) current2), out disabledReason))
                {
                  num3 = 5;
                  continue;
                }
                goto label_14;
            }
          }
label_12:
          current2 = enumerator2.Current;
          num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
          {
            num3 = 0;
            goto label_7;
          }
          else
            goto label_7;
label_15:
          num3 = 6;
          goto label_7;
        }
        finally
        {
          int num4;
          if (enumerator2 == null)
            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 1 : 0;
          else
            goto label_21;
label_20:
          switch (num4)
          {
            case 2:
              break;
            default:
          }
label_21:
          enumerator2.Dispose();
          num4 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
          {
            num4 = 0;
            goto label_20;
          }
          else
            goto label_20;
        }
label_5:
        num2 = 3;
        goto label_3;
label_24:
        current1 = enumerator1.Current;
        num2 = 2;
        goto label_3;
      }
      finally
      {
        if (enumerator1 != null)
        {
          int num5 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
            num5 = 1;
          while (true)
          {
            switch (num5)
            {
              case 1:
                ModuleManager.iuHeM53mWnmLRYCDxGL((object) enumerator1);
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
                continue;
              default:
                goto label_33;
            }
          }
        }
label_33:;
      }
    }

    /// <summary>Обновить статусы модулей в соответствии с активацией</summary>
    private void UpdateModuleStatusesByActivation()
    {
      int num1 = 2;
      IEnumerator<ModuleBase> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_73;
          case 1:
            goto label_3;
          case 2:
            enumerator = this.unitsByUid.Values.OfType<ModuleBase>().GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 1 : 0;
            continue;
          default:
            goto label_70;
        }
      }
label_73:
      return;
label_70:
      return;
label_3:
      try
      {
label_36:
        if (ModuleManager.yiHGD7pvyVKFJQpxj3Y((object) enumerator))
          goto label_26;
        else
          goto label_37;
label_5:
        ModuleBase current;
        int num2;
        while (true)
        {
          int num3;
          IApplicationUnit applicationUnit1;
          ILicensedUnit licensedUnit;
          ILicenseInfo licenseInfo;
          ModuleStatus moduleStatus1;
          ModuleStatus moduleStatus2;
          IApplicationUnit applicationUnit2;
          switch (num2)
          {
            case 1:
              goto label_66;
            case 2:
              applicationUnit1 = licensedUnit as IApplicationUnit;
              num2 = 25;
              continue;
            case 3:
              ModuleManager.jpkPjwpSod5pILbep3X((object) current, ModuleDisabledReason.DisabledManually);
              num2 = 4;
              continue;
            case 4:
              ModuleManager.log.WarnFormat((string) ModuleManager.T6y7cn3dwy25eMCwujO(ModuleManager.yONloC3ygB4MNggpRib(-1146510045 ^ -1146496243)), (object) current.Title);
              num2 = 15;
              continue;
            case 5:
              if (!ModuleManager.NpOjjbpRMXMKaqldEiq((object) current))
              {
                num2 = 49;
                continue;
              }
              goto case 41;
            case 6:
              ModuleManager.DLkNZ13jvE6BDLmf2Cg((object) current, ModuleStatus.Disabled);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 7 : 45;
              continue;
            case 7:
            case 39:
            case 49:
              applicationUnit2 = (IApplicationUnit) current;
              num3 = 8;
              break;
            case 8:
            case 34:
              if (applicationUnit2 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 3 : 44;
                continue;
              }
              goto case 22;
            case 9:
            case 10:
            case 29:
            case 38:
              applicationUnit2 = (IApplicationUnit) ModuleManager.y9Rw7s37vtuqDCQyife((object) applicationUnit2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 32 : 34;
              continue;
            case 11:
              if (moduleStatus1 == ModuleStatus.Disabled)
              {
                num2 = 3;
                continue;
              }
              goto case 15;
            case 12:
              current.DisabledReason = ModuleDisabledReason.DisabledOnServer;
              num2 = 18;
              continue;
            case 13:
              if (licenseInfo != null)
              {
                num2 = 28;
                continue;
              }
              goto case 9;
            case 14:
              if (moduleStatus2 != ModuleStatus.Enabled)
              {
                num2 = 47;
                continue;
              }
              goto case 7;
            case 15:
              if (this.serverModuleStatuses == null)
              {
                num2 = 39;
                continue;
              }
              goto case 5;
            case 16:
              ModuleManager.DLkNZ13jvE6BDLmf2Cg((object) current, ModuleStatus.Enabled);
              num2 = 36;
              continue;
            case 17:
              if (current.Status != ModuleStatus.Disabled)
              {
                num2 = 2;
                continue;
              }
              goto case 9;
            case 18:
              ModuleManager.log.WarnFormat((string) ModuleManager.T6y7cn3dwy25eMCwujO((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1654249598 >> 2 ^ 413534321)), ModuleManager.kxZ0xApqQOoXhVW4IDJ((object) current));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 40 : 16;
              continue;
            case 19:
              if (!this.activatedModules.Contains<string>(applicationUnit1.Id))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 6 : 6;
                continue;
              }
              goto case 9;
            case 20:
              ModuleManager.log.WarnFormat((string) ModuleManager.T6y7cn3dwy25eMCwujO((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1872275253 >> 6 ^ -29236261)), ModuleManager.kxZ0xApqQOoXhVW4IDJ((object) current));
              num2 = 42;
              continue;
            case 21:
              ModuleManager.DLkNZ13jvE6BDLmf2Cg((object) current, ModuleStatus.Disabled);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 48 : 40;
              continue;
            case 22:
              licensedUnit = applicationUnit2 as ILicensedUnit;
              num2 = 33;
              continue;
            case 23:
            case 47:
              ModuleManager.DLkNZ13jvE6BDLmf2Cg((object) current, ModuleStatus.Disabled);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 11 : 12;
              continue;
            case 24:
              if (ModuleManager.P7RptNpVLamYrCNwPMO((object) current) == ModuleStatus.Unknown)
              {
                num2 = 16;
                continue;
              }
              goto case 36;
            case 25:
              if (applicationUnit1 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 38 : 22;
                continue;
              }
              goto case 19;
            case 26:
              ModuleManager.log.WarnFormat(EleWise.ELMA.SR.T((string) ModuleManager.yONloC3ygB4MNggpRib(-281842504 ^ -281865652)), ModuleManager.kxZ0xApqQOoXhVW4IDJ((object) current));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 43 : 32;
              continue;
            case 27:
              if (!(licensedUnit is IApplication))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 3 : 17;
                continue;
              }
              goto case 9;
            case 28:
              if (this.activatedModules == null)
              {
                num2 = 10;
                continue;
              }
              goto case 30;
            case 30:
              if (!this.activatedModules.Any<string>())
              {
                num3 = 9;
                break;
              }
              goto case 27;
            case 31:
              goto label_26;
            case 32:
              licenseInfo = licensedUnit.GetLicenseInfo();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 0 : 0;
              continue;
            case 33:
              if (licensedUnit != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 17 : 32;
                continue;
              }
              goto case 9;
            case 35:
              if (ModuleManager.MPovyqpKKJPra3Yif3v((object) licenseInfo) != LicenseStatus.Activated)
              {
                num3 = 37;
                break;
              }
              goto case 13;
            case 36:
              if (this.savedModulesStatuses.TryGetValue(ModuleManager.jGUClkpi8cj3WWqyZtt((object) current), out moduleStatus1))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 46 : 17;
                continue;
              }
              goto case 15;
            case 37:
              if (current.Status != ModuleStatus.Disabled)
              {
                num2 = 21;
                continue;
              }
              goto case 13;
            case 40:
            case 42:
            case 43:
            case 44:
              goto label_36;
            case 41:
              if (!this.serverModuleStatuses.TryGetValue(ModuleManager.jGUClkpi8cj3WWqyZtt((object) current), out moduleStatus2))
              {
                num2 = 23;
                continue;
              }
              goto case 14;
            case 45:
              ModuleManager.jpkPjwpSod5pILbep3X((object) current, ModuleDisabledReason.ActivationInDb);
              num2 = 26;
              continue;
            case 46:
              ModuleManager.DLkNZ13jvE6BDLmf2Cg((object) current, moduleStatus1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 11 : 9;
              continue;
            case 48:
              current.DisabledReason = ModuleDisabledReason.Activation;
              num2 = 20;
              continue;
            default:
              if (licenseInfo != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 35 : 0;
                continue;
              }
              goto case 13;
          }
          num2 = num3;
        }
label_66:
        return;
label_26:
        current = enumerator.Current;
        num2 = 24;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
        {
          num2 = 6;
          goto label_5;
        }
        else
          goto label_5;
label_37:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 1;
        goto label_5;
      }
      finally
      {
        int num4;
        if (enumerator == null)
          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 0 : 0;
        else
          goto label_71;
label_69:
        switch (num4)
        {
          case 2:
            break;
          default:
        }
label_71:
        ModuleManager.iuHeM53mWnmLRYCDxGL((object) enumerator);
        num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
        {
          num4 = 1;
          goto label_69;
        }
        else
          goto label_69;
      }
    }

    /// <summary>Обновить статусы модулей по установленным пакетам</summary>
    private void UpdateModuleStatusesByPackages()
    {
      int num1 = 2;
      IEnumerator<PackageDescription> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_28;
          case 1:
            goto label_3;
          case 2:
            enumerator = this.packageService.Find(new PackageFilter()
            {
              Level = PackageLevel.All,
              Status = PackageStatus.Any
            }).GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 1 : 1;
            continue;
          default:
            goto label_23;
        }
      }
label_28:
      return;
label_23:
      return;
label_3:
      try
      {
label_19:
        if (ModuleManager.yiHGD7pvyVKFJQpxj3Y((object) enumerator))
          goto label_12;
        else
          goto label_20;
label_4:
        int num2;
        while (true)
        {
          IModule module;
          PackageDescription package;
          switch (num2)
          {
            case 1:
            case 11:
              goto label_19;
            case 2:
              if (ModuleManager.jpLZJVpTslFh7r0gZHr((object) module) != ModuleStatus.Disabled)
              {
                num2 = 9;
                continue;
              }
              goto label_19;
            case 3:
              if (ModuleManager.cIjf0TpXumxu1T6m4kp((object) package))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 3 : 11;
                continue;
              }
              break;
            case 4:
              ModuleManager.log.WarnFormat(EleWise.ELMA.SR.T((string) ModuleManager.yONloC3ygB4MNggpRib(-2112703338 ^ -2112697348)), (object) module.Title);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 1 : 0;
              continue;
            case 5:
              ModuleManager.DLkNZ13jvE6BDLmf2Cg((object) (ModuleBase) module, ModuleStatus.Disabled);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 1 : 6;
              continue;
            case 6:
              ModuleManager.jpkPjwpSod5pILbep3X((object) (ModuleBase) module, ModuleDisabledReason.PackageNotInstalled);
              num2 = 4;
              continue;
            case 7:
              package = enumerator.Current;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 3;
              continue;
            case 8:
              goto label_12;
            case 9:
              if (module is ModuleBase)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 5 : 5;
                continue;
              }
              goto label_19;
            case 10:
              if (module != null)
              {
                num2 = 2;
                continue;
              }
              goto label_19;
            case 12:
              goto label_10;
          }
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          module = this.modulesById.Values.FirstOrDefault<IModule>((System.Func<IModule, bool>) (m => ModuleManager.\u003C\u003Ec__DisplayClass52_0.VlTl44f99V4BHhlHQOTs((object) m.Id, ModuleManager.\u003C\u003Ec__DisplayClass52_0.CKfOJYf9Jsw0490CRZ1m((object) package), StringComparison.CurrentCultureIgnoreCase)));
          num2 = 10;
        }
label_10:
        return;
label_12:
        num2 = 7;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
        {
          num2 = 2;
          goto label_4;
        }
        else
          goto label_4;
label_20:
        num2 = 12;
        goto label_4;
      }
      finally
      {
        if (enumerator != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_30;
              default:
                ModuleManager.iuHeM53mWnmLRYCDxGL((object) enumerator);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 1 : 0;
                continue;
            }
          }
        }
label_30:;
      }
    }

    /// <summary>
    /// Обновить статусы модулей в зависимости от установленных в конфигурации компонентов ELMA Store
    /// </summary>
    private void UpdateModuleStatusesByComponents(
      IEnumerable<IStoreComponentInfo> serverStoreComponentInfos)
    {
      Dictionary<IModule, ModuleStatus> dictionary = new Dictionary<IModule, ModuleStatus>();
      foreach (IStoreComponentInfo storeComponentInfo in serverStoreComponentInfos)
      {
        IStoreComponentInfo serverComponent = storeComponentInfo;
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        ModuleManager.StoreComponentConfigurationInfo configurationInfo = this.installedStoreComponentInfos.FirstOrDefault<ModuleManager.StoreComponentConfigurationInfo>((System.Func<ModuleManager.StoreComponentConfigurationInfo, bool>) (i => ((string) ModuleManager.\u003C\u003Ec__DisplayClass53_0.sxEVyxf95KeopuqZYNFZ((object) i)).Equals((string) ModuleManager.\u003C\u003Ec__DisplayClass53_0.XVpqOvf9jhyMvq4fCYcy((object) serverComponent), StringComparison.CurrentCultureIgnoreCase)));
        foreach (IModule allModule in serverComponent.AllModules)
        {
          if (configurationInfo != null)
            dictionary[allModule] = ModuleStatus.Enabled;
          else if (!dictionary.ContainsKey(allModule))
            dictionary[allModule] = ModuleStatus.Disabled;
        }
      }
      foreach (KeyValuePair<IModule, ModuleStatus> keyValuePair in dictionary)
      {
        if (keyValuePair.Key is ModuleBase key)
        {
          if (keyValuePair.Value == ModuleStatus.Disabled && key.Status != ModuleStatus.Disabled)
          {
            key.Status = ModuleStatus.Disabled;
            key.DisabledReason = ModuleDisabledReason.NotUsedInDb;
            ModuleManager.log.WarnFormat(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-122002947 ^ 122020274)), (object) key.Title);
          }
          else if (keyValuePair.Value == ModuleStatus.Enabled && key.Status == ModuleStatus.Disabled && key.DisabledReason == ModuleDisabledReason.DisabledManually)
          {
            key.Status = ModuleStatus.Enabled;
            key.DisabledReason = ModuleDisabledReason.Unknown;
          }
        }
      }
    }

    /// <summary>
    /// Проверить наличие на стороне сервера требуемых компонентов ELMA Store для текущей конфигурации
    /// </summary>
    private void CheckRequiredComponentsForConfiguration(
      IElmaComponent packagingComponent,
      IEnumerable<ModuleManager.StoreComponentConfigurationInfo> installedStoreComponentInfos,
      IEnumerable<IStoreComponentInfo> serverStoreComponentInfos)
    {
      this.infoToUpdateInDB.Clear();
      List<IStoreComponentInfo> componentsInfo = new List<IStoreComponentInfo>();
      List<ModuleManager.StoreComponentConfigurationInfo> source = new List<ModuleManager.StoreComponentConfigurationInfo>();
      foreach (ModuleManager.StoreComponentConfigurationInfo storeComponentInfo1 in installedStoreComponentInfos)
      {
        ModuleManager.StoreComponentConfigurationInfo installedInfo = storeComponentInfo1;
        if (installedInfo.Manifest == null || installedInfo.Manifest.Packages.Where<PackageManifest>((System.Func<PackageManifest, bool>) (p =>
        {
          int num = 1;
          ElmaPackageMetadata elmaPackageMetadata;
          while (true)
          {
            switch (num)
            {
              case 1:
                // ISSUE: reference to a compiler-generated method
                elmaPackageMetadata = new ElmaPackageMetadata((string) ModuleManager.\u003C\u003Ec__DisplayClass54_0.U6M7snf9scm7loXGKAAD((object) p));
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
                continue;
              default:
                goto label_2;
            }
          }
label_2:
          // ISSUE: reference to a compiler-generated method
          return ModuleManager.\u003C\u003Ec__DisplayClass54_0.Y5SQknf9cO02DSxj0ute((object) packagingComponent, (object) elmaPackageMetadata);
        })).ToList<PackageManifest>().Count != 0)
        {
          // ISSUE: reference to a compiler-generated method
          IStoreComponentInfo storeComponentInfo2 = serverStoreComponentInfos.FirstOrDefault<IStoreComponentInfo>((System.Func<IStoreComponentInfo, bool>) (i => ModuleManager.\u003C\u003Ec__DisplayClass54_1.f9BmZSfdooG11lumiVuo((object) i.Id, (object) installedInfo.Id, StringComparison.CurrentCultureIgnoreCase)));
          SemanticVersion semanticVersion = (SemanticVersion) null;
          if (string.IsNullOrEmpty(installedInfo.Version) || !SemanticVersion.TryParse(installedInfo.Version, out semanticVersion))
            semanticVersion = (SemanticVersion) null;
          if (storeComponentInfo2 != null && storeComponentInfo2.IsInstalled)
          {
            if (storeComponentInfo2.InstalledVersion != (SemanticVersion) null && semanticVersion != (SemanticVersion) null)
            {
              if (storeComponentInfo2.InstalledVersion > semanticVersion)
                this.infoToUpdateInDB.Add(storeComponentInfo2);
              else if (storeComponentInfo2.InstalledVersion < semanticVersion)
              {
                if (!storeComponentInfo2.IsLatestVersionInstalled && storeComponentInfo2.LastVersion != (SemanticVersion) null && storeComponentInfo2.LastVersion >= semanticVersion)
                  componentsInfo.Add(storeComponentInfo2);
                else if (installedInfo.Status == StoreComponentStatus.Active)
                  source.Add(installedInfo);
              }
              else if (installedInfo.Status == StoreComponentStatus.Allowed)
                this.infoToUpdateInDB.Add(storeComponentInfo2);
            }
            else if (installedInfo.Status == StoreComponentStatus.Allowed)
              this.infoToUpdateInDB.Add(storeComponentInfo2);
          }
          else if (storeComponentInfo2 != null && storeComponentInfo2.LastVersion != (SemanticVersion) null)
            componentsInfo.Add(storeComponentInfo2);
          else if (installedInfo.Status == StoreComponentStatus.Active)
            source.Add(installedInfo);
        }
      }
      if (source.Count > 0)
      {
        this.dbPreUpdater?.EndUpdating();
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921234985), (object) string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-244066886 - -48452443 ^ -195615465), source.Select<ModuleManager.StoreComponentConfigurationInfo, string>((System.Func<ModuleManager.StoreComponentConfigurationInfo, string>) (c => (string) ModuleManager.\u003C\u003Ec.oXFNTwfJ3Ore1AlF2SrF((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~210725948 ^ -210373581), (object) EleWise.ELMA.SR.T((string) ModuleManager.\u003C\u003Ec.SvnTZyfJ1Fka1fP3nGEF((object) c)), ModuleManager.\u003C\u003Ec.u7yadlfJNMwAAo373us6(ModuleManager.\u003C\u003Ec.Njc2tyfJnhg3mBiiug8t((object) c), ModuleManager.\u003C\u003Ec.TLpCyMfJTMJ1YITq5kHL(-2106517564 ^ -2106499354), (object) c.Version)))))));
      }
      if (componentsInfo.Count > 0)
      {
        this.dbPreUpdater?.EndUpdating();
        throw new RequiredInstallStoreComponentsException((IEnumerable<IStoreComponentInfo>) componentsInfo);
      }
    }

    /// <summary>
    /// Проверить статусы компонентов, требуемых для текущей конфигурации
    /// </summary>
    private void CheckComponentsStatusForConfiguration(
      IElmaComponent packagingComponent,
      IEnumerable<ModuleManager.StoreComponentConfigurationInfo> installedStoreComponentInfos,
      IEnumerable<IStoreComponentInfo> serverStoreComponentInfos)
    {
      List<ModuleManager.StoreComponentConfigurationInfo> source = new List<ModuleManager.StoreComponentConfigurationInfo>();
      List<string> list = ComponentManager.Current.LicenseManager.GetActivationKeys().Select<KeyValuePair<Guid, string>, string>((System.Func<KeyValuePair<Guid, string>, string>) (p => p.Value)).ToList<string>();
      foreach (ModuleManager.StoreComponentConfigurationInfo storeComponentInfo1 in installedStoreComponentInfos)
      {
        ModuleManager.StoreComponentConfigurationInfo installedInfo = storeComponentInfo1;
        bool flag1 = false;
        bool flag2 = false;
        if (installedInfo.Manifest != null)
        {
          if (installedInfo.Manifest.ActivationType == ElmaStoreComponentActivationType.Paid)
          {
            flag2 = true;
            if (installedInfo.Signatures != null && installedInfo.Signatures.Any<StoreComponentSignatureInfo>())
            {
              ComponentLicenseInfo licenseInfo = ElmaStoreComponentsBuilder.GetLicenseInfo(installedInfo.Manifest, installedInfo.Signatures, (IEnumerable<string>) list, new Func<DateTime?>(this.GetMainLicensedUnitExpiration));
              if (licenseInfo != null)
              {
                flag1 = true;
                if (licenseInfo.Status != ComponentLicenseStatus.Activated)
                  source.Add(installedInfo);
              }
            }
          }
          if (installedInfo.Manifest.Packages.Where<PackageManifest>((System.Func<PackageManifest, bool>) (p =>
          {
            int num = 1;
            ElmaPackageMetadata metadata;
            while (true)
            {
              switch (num)
              {
                case 1:
                  // ISSUE: reference to a compiler-generated method
                  metadata = new ElmaPackageMetadata((string) ModuleManager.\u003C\u003Ec__DisplayClass55_0.gvI5RUfdfFNtFKiYPZCy((object) p));
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
                  continue;
                default:
                  goto label_3;
              }
            }
label_3:
            return packagingComponent.IsCompatible(metadata);
          })).ToList<PackageManifest>().Count == 0)
            continue;
        }
        // ISSUE: reference to a compiler-generated method
        IStoreComponentInfo storeComponentInfo2 = serverStoreComponentInfos.FirstOrDefault<IStoreComponentInfo>((System.Func<IStoreComponentInfo, bool>) (i => ModuleManager.\u003C\u003Ec__DisplayClass55_1.IWtY2JfdZJSWJ7XjIhmp((object) i.Id, (object) installedInfo.Id, StringComparison.CurrentCultureIgnoreCase)));
        if (storeComponentInfo2 != null && storeComponentInfo2.IsInstalled)
        {
          ILicensedUnit licensedUnit = storeComponentInfo2.LicensedUnit;
          if (licensedUnit != null)
          {
            ILicenseInfo licenseInfo = licensedUnit.GetLicenseInfo();
            if (licenseInfo != null)
            {
              flag1 = true;
              if (licenseInfo.Status != LicenseStatus.Activated)
                source.Add(installedInfo);
            }
          }
        }
        if (flag2)
        {
          int num1 = flag1 ? 1 : 0;
        }
      }
      if (source.Count > 0)
        throw new LicenseActivationRequiredException(source.Select<ModuleManager.StoreComponentConfigurationInfo, string>((System.Func<ModuleManager.StoreComponentConfigurationInfo, string>) (c =>
        {
          int num = 2;
          while (true)
          {
            switch (num)
            {
              case 1:
                goto label_5;
              case 2:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                if (!ModuleManager.\u003C\u003Ec.C3F1a2fJpIvAFNX9XZfb(ModuleManager.\u003C\u003Ec.SvnTZyfJ1Fka1fP3nGEF((object) c)))
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 1 : 0;
                  continue;
                }
                goto label_4;
              default:
                goto label_4;
            }
          }
label_4:
          // ISSUE: reference to a compiler-generated method
          return (string) ModuleManager.\u003C\u003Ec.Njc2tyfJnhg3mBiiug8t((object) c);
label_5:
          return c.Title;
        })).ToArray<string>());
    }

    private static IEnumerable<string> GetDeprecatedComponentFiles(
      IEnumerable<IStoreComponentInfo> storeComponentInfos,
      object repositoryPath)
    {
      string repositoryPath1 = (string) repositoryPath;
      return storeComponentInfos.Where<IStoreComponentInfo>((System.Func<IStoreComponentInfo, bool>) (info =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              if (ModuleManager.\u003C\u003Ec.URXMpIfJRPH0iktvlWwC((object) info) == ModuleStatus.Disabled)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            default:
              goto label_2;
          }
        }
label_2:
        // ISSUE: reference to a compiler-generated method
        return ModuleManager.\u003C\u003Ec.R1TkvCfJaLivejQetpkk((object) info) == ModuleDisabledReason.Deprecated;
label_3:
        return false;
      })).SelectMany<IStoreComponentInfo, string>((System.Func<IStoreComponentInfo, IEnumerable<string>>) (info => ModuleManager.GetComponentFiles((object) info, (object) repositoryPath1))).Distinct<string>();
    }

    private static IEnumerable<string> GetComponentFiles(object info, object repositoryPath)
    {
      string repositoryPath1 = (string) repositoryPath;
      ManifestStoreComponentInfo manifestComponent = info as ManifestStoreComponentInfo;
      if (manifestComponent == null)
        return Enumerable.Empty<string>();
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return manifestComponent.AllPackages.Select<PackageDescription, string>((System.Func<PackageDescription, string>) (p => (string) ModuleManager.\u003C\u003Ec.I0abZpfJt95P3rZtdAX9(ModuleManager.\u003C\u003Ec.TLpCyMfJTMJ1YITq5kHL(-1939377524 ^ -1939727738), ModuleManager.\u003C\u003Ec.awqQuJfJDqE6CksVNroY((object) p)))).Union<string>(((IEnumerable<string>) ElmaStoreComponentFile.SupportedComponentMask).Select<string, string>((System.Func<string, string>) (mask => (string) ModuleManager.\u003C\u003Ec__DisplayClass57_0.l6PMoOfdkRFQTJ2m8NAJ(ModuleManager.\u003C\u003Ec__DisplayClass57_0.I3TaNDfdTSheOJ4aQUJK(ModuleManager.\u003C\u003Ec__DisplayClass57_0.j76tAXfdXiPbI4oPpFiR((object) manifestComponent), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921196793), (object) mask), (object) Array.Empty<object>())))).Union<string>(((IEnumerable<string>) ElmaStoreComponentFile.SupportedManifestMask).Select<string, string>((System.Func<string, string>) (mask => (string) ModuleManager.\u003C\u003Ec__DisplayClass57_0.l6PMoOfdkRFQTJ2m8NAJ(ModuleManager.\u003C\u003Ec__DisplayClass57_0.I3TaNDfdTSheOJ4aQUJK((object) manifestComponent.Id, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(322893104 - -1992822529 ^ -1979244811), (object) mask), (object) Array.Empty<object>())))).Union<string>((IEnumerable<string>) new string[2]
      {
        string.Format(manifestComponent.Id + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1445902765 ^ -1980277732 ^ 539400955)),
        string.Format(manifestComponent.Id + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710608382))
      }).SelectMany<string, string>((System.Func<string, IEnumerable<string>>) (pattern => Directory.EnumerateFiles(repositoryPath1, pattern, SearchOption.TopDirectoryOnly)));
    }

    /// <summary>Создать структуры в БД</summary>
    /// <param name="transform">Провайдер преобразования БД</param>
    /// <param name="version">Версия структуры БД</param>
    internal static void CreateDbStructures(ITransformationProvider transform, int version)
    {
      int num = 9;
      EleWise.ELMA.Runtime.Db.Migrator.Framework.Table table1;
      EleWise.ELMA.Runtime.Db.Migrator.Framework.Table table2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_6;
          case 1:
            ModuleManager.BNyjwspOPY0cjvbRZim((object) transform, (object) table2);
            num = 7;
            continue;
          case 2:
            EleWise.ELMA.Runtime.Db.Migrator.Framework.Table table3 = new EleWise.ELMA.Runtime.Db.Migrator.Framework.Table();
            ModuleManager.OEfs2Tpn5J5PrhNJqYi((object) table3, ModuleManager.yONloC3ygB4MNggpRib(236071375 ^ 236103921));
            table3.Columns = new List<Column>()
            {
              new Column((string) ModuleManager.yONloC3ygB4MNggpRib(-1598106783 - -968262081 ^ -629812100), new ColumnType(DbType.String, (int) byte.MaxValue)),
              new Column(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 1333769076), new ColumnType(DbType.String, int.MaxValue)),
              new Column((string) ModuleManager.yONloC3ygB4MNggpRib(~210725948 ^ -210758985), new ColumnType(DbType.String, (int) byte.MaxValue)),
              new Column(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1052221104 - 768835541 ^ 283418461), DbType.Int32),
              new Column((string) ModuleManager.yONloC3ygB4MNggpRib(372753449 ^ 372721087), new ColumnType(DbType.String, (int) byte.MaxValue)),
              new Column((string) ModuleManager.yONloC3ygB4MNggpRib(272623989 ^ 272591041), DbType.Int32),
              new Column((string) ModuleManager.yONloC3ygB4MNggpRib(2045296739 + 1688595713 ^ -561107788), new ColumnType(DbType.String, int.MaxValue)),
              new Column((string) ModuleManager.yONloC3ygB4MNggpRib(-1852837372 ^ -1852869664), DbType.Binary)
            };
            table1 = table3;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 6 : 4;
            continue;
          case 3:
            EleWise.ELMA.Runtime.Db.Migrator.Framework.Table table4 = new EleWise.ELMA.Runtime.Db.Migrator.Framework.Table();
            ModuleManager.OEfs2Tpn5J5PrhNJqYi((object) table4, ModuleManager.yONloC3ygB4MNggpRib(-867826612 ^ -867793760));
            table4.Columns = new List<Column>()
            {
              new Column((string) ModuleManager.yONloC3ygB4MNggpRib(-1872275253 >> 6 ^ -29287313), DbType.Guid),
              new Column(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470998129 - 231418599 ^ 1239612072), DbType.Int32)
            };
            table2 = table4;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 1;
            continue;
          case 4:
            ITransformationProvider transformationProvider = transform;
            EleWise.ELMA.Runtime.Db.Migrator.Framework.Index index = new EleWise.ELMA.Runtime.Db.Migrator.Framework.Index();
            ModuleManager.J2KZrAp2HuEihN1WQrK((object) index, ModuleManager.yONloC3ygB4MNggpRib(-218496594 ^ -218464112));
            ModuleManager.aJASigpe8g59sQ3a9wu((object) index, ModuleManager.yONloC3ygB4MNggpRib(-1921202237 ^ -1921235393));
            index.Columns.Add((string) ModuleManager.yONloC3ygB4MNggpRib(1304605005 ^ 1304571923));
            transformationProvider.AddUniqueIndex(index);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 0;
            continue;
          case 5:
            goto label_15;
          case 6:
            transform.AddTable(table1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 4 : 2;
            continue;
          case 7:
            if (ModuleManager.POMfEGpkRyXSF6PrYrk((object) transform, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(381945751 ^ 1158627804 ^ 1405863797)))
            {
              num = 5;
              continue;
            }
            goto case 2;
          case 8:
            if (!ModuleManager.POMfEGpkRyXSF6PrYrk((object) transform, ModuleManager.yONloC3ygB4MNggpRib(323422137 << 2 ^ 1293721096)))
            {
              num = 3;
              continue;
            }
            goto case 7;
          case 9:
            if (version == 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 8;
              continue;
            }
            goto label_2;
          default:
            goto label_16;
        }
      }
label_6:
      return;
label_15:
      return;
label_16:
      return;
label_2:;
    }

    private void LoadSavedModuleStatuses()
    {
      int num1 = 1;
      IDataReader dataReader;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (this.transformationProvider != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
              continue;
            }
            goto label_15;
          case 2:
            goto label_20;
          case 3:
            goto label_4;
          case 4:
            goto label_6;
          default:
            dataReader = this.transformationProvider.ExecuteQuery((string) ModuleManager.mvJMT9pN9DhRaWVIlCD(ModuleManager.yONloC3ygB4MNggpRib(1113862659 ^ 1113894949), ModuleManager.nikZbnp18ka5K8Sp8EL(ModuleManager.PQlFZ9pP2CyFgoPbJoo((object) this.transformationProvider), ModuleManager.yONloC3ygB4MNggpRib(-2092274397 << 4 ^ 883315420))), (Dictionary<string, object>) null);
            num1 = 4;
            continue;
        }
      }
label_20:
      return;
label_4:
      return;
label_15:
      return;
label_6:
      try
      {
label_11:
        if (dataReader.Read())
          goto label_9;
        else
          goto label_12;
label_7:
        Guid key;
        ModuleStatus moduleStatus;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              moduleStatus = (ModuleStatus) ModuleManager.W6smCNpa8rqMQZCNgsT(dataReader[(string) ModuleManager.yONloC3ygB4MNggpRib(-1350312861 << 3 ^ 2082366010)]);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_11;
            case 3:
              goto label_9;
            case 4:
              goto label_8;
            default:
              this.savedModulesStatuses[key] = moduleStatus;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 2 : 2;
              continue;
          }
        }
label_8:
        return;
label_9:
        key = ModuleManager.qNjHT7pp57kACrTj8IH(ModuleManager.PQlFZ9pP2CyFgoPbJoo((object) this.transformationProvider), ModuleManager.xBLEm0p31qkQ5IvcsFm((object) dataReader, ModuleManager.yONloC3ygB4MNggpRib(-688192331 - 435440695 ^ -1123665550)));
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
        {
          num2 = 1;
          goto label_7;
        }
        else
          goto label_7;
label_12:
        num2 = 4;
        goto label_7;
      }
      finally
      {
        if (dataReader != null)
        {
          int num3 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                ModuleManager.iuHeM53mWnmLRYCDxGL((object) dataReader);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
                continue;
              default:
                goto label_22;
            }
          }
        }
label_22:;
      }
    }

    private void SaveModuleStatusToDb(Guid uid, ModuleStatus status)
    {
      int num = 4;
      string sql;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.transformationProvider.ExecuteNonQuery(sql, new Dictionary<string, object>()
            {
              {
                z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638435699),
                (object) uid
              }
            });
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_2;
          case 4:
            if (this.transformationProvider != null)
            {
              sql = (string) ModuleManager.mXTG76ptt81V82tSAi6((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(864270449 << 6 ^ -521232884), ModuleManager.nikZbnp18ka5K8Sp8EL(ModuleManager.PQlFZ9pP2CyFgoPbJoo((object) this.transformationProvider), ModuleManager.yONloC3ygB4MNggpRib(-882126494 ^ -882159218)), ModuleManager.nikZbnp18ka5K8Sp8EL(ModuleManager.PQlFZ9pP2CyFgoPbJoo((object) this.transformationProvider), ModuleManager.yONloC3ygB4MNggpRib(1994213607 >> 4 ^ 124605826)), ModuleManager.TheDa1pD5QxNyWuVDpV((object) this.transformationProvider));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 2 : 5;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 3 : 3;
            continue;
          case 5:
            this.transformationProvider.ExecuteNonQuery(sql, new Dictionary<string, object>()
            {
              {
                (string) ModuleManager.yONloC3ygB4MNggpRib(323422137 << 2 ^ 1293720696),
                (object) uid
              }
            });
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
            continue;
          default:
            sql = (string) ModuleManager.vZJeQCpw0JvvMLPgcOC((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218463460), (object) new object[5]
            {
              (object) ((Dialect) ModuleManager.PQlFZ9pP2CyFgoPbJoo((object) this.transformationProvider)).QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1505778440 - 1981636111 ^ -475890667)),
              ModuleManager.nikZbnp18ka5K8Sp8EL(ModuleManager.PQlFZ9pP2CyFgoPbJoo((object) this.transformationProvider), ModuleManager.yONloC3ygB4MNggpRib(~210725948 ^ -210758961)),
              ModuleManager.nikZbnp18ka5K8Sp8EL((object) this.transformationProvider.Dialect, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(516838154 ^ 516870696)),
              ModuleManager.TheDa1pD5QxNyWuVDpV((object) this.transformationProvider),
              (object) (int) status
            });
            num = 2;
            continue;
        }
      }
label_3:
      return;
label_2:;
    }

    private void LoadStoreComponentConfigurationInfos()
    {
      int num1 = 1;
      IDataReader dataReader;
      while (true)
      {
        switch (num1)
        {
          case 1:
            dataReader = this.transformationProvider.ExecuteQuery((string) ModuleManager.mvJMT9pN9DhRaWVIlCD(ModuleManager.yONloC3ygB4MNggpRib(-951514650 ^ -951481408), ModuleManager.nikZbnp18ka5K8Sp8EL((object) this.transformationProvider.Dialect, ModuleManager.yONloC3ygB4MNggpRib(1505778440 - 1981636111 ^ -475890233))), (Dictionary<string, object>) null);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_53;
          default:
            goto label_3;
        }
      }
label_53:
      return;
label_3:
      try
      {
label_28:
        if (ModuleManager.AtLuOPp0HkjuWfuFT95((object) dataReader))
          goto label_22;
        else
          goto label_29;
label_5:
        ModuleManager.StoreComponentConfigurationInfo configurationInfo;
        int num2;
        while (true)
        {
          string xml;
          byte[] data;
          byte[] numArray;
          string str;
          switch (num2)
          {
            case 1:
              ModuleManager.m9pQrSpWnf13sPhlEc4((object) configurationInfo, (object) ClassSerializationHelper.DeserializeObjectByXml<ElmaStoreComponentManifest>(xml, false));
              num2 = 10;
              continue;
            case 2:
              if (!string.IsNullOrEmpty(xml))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 1 : 1;
                continue;
              }
              goto case 10;
            case 3:
              if (ModuleManager.qrMmTWp641xiDg5vrSs(ModuleManager.dyLHTMp4DVSetq5MxCD((object) configurationInfo), ModuleManager.yONloC3ygB4MNggpRib(1251470110 >> 2 ^ 312834455)))
              {
                num2 = 14;
                continue;
              }
              goto case 18;
            case 4:
              if (ModuleManager.xBLEm0p31qkQ5IvcsFm((object) dataReader, ModuleManager.yONloC3ygB4MNggpRib(-2099751081 ^ -2099718477)) is DBNull)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 12 : 12;
                continue;
              }
              numArray = (byte[]) ModuleManager.xBLEm0p31qkQ5IvcsFm((object) dataReader, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1021410165 ^ 1021442705));
              goto label_46;
            case 5:
              goto label_22;
            case 6:
              try
              {
                IEnumerable<StoreComponentSignatureInfo> componentSignatureInfos = StoreComponentSignatureInfo.Decompress(data);
                int num3 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
                  num3 = 0;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      configurationInfo.Signatures = componentSignatureInfos;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_30;
                  }
                }
              }
              catch (Exception ex)
              {
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                    throw new InvalidOperationException(EleWise.ELMA.SR.T((string) ModuleManager.yONloC3ygB4MNggpRib(-2092274397 << 4 ^ 883315096), ModuleManager.YiDquWp7wpcjTjcP7sO(ModuleManager.Ts3wDkpA8qCNAnReBfp((object) configurationInfo)) ? (object) configurationInfo.Id : ModuleManager.Ts3wDkpA8qCNAnReBfp((object) configurationInfo)), ex);
                }
              }
            case 7:
              configurationInfo.DeployVersion = ModuleManager.xBLEm0p31qkQ5IvcsFm((object) dataReader, ModuleManager.yONloC3ygB4MNggpRib(901793403 ^ 901826541)) is DBNull ? (string) null : (string) dataReader[(string) ModuleManager.yONloC3ygB4MNggpRib(-1350312861 << 3 ^ 2082366094)];
              num2 = 16;
              continue;
            case 8:
              this.installedStoreComponentInfos.Add(configurationInfo);
              num2 = 11;
              continue;
            case 9:
              if (ModuleManager.xBLEm0p31qkQ5IvcsFm((object) dataReader, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217490711)) is DBNull)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 10 : 22;
                continue;
              }
              str = (string) dataReader[(string) ModuleManager.yONloC3ygB4MNggpRib(-1998538950 ^ -1998571798)];
              break;
            case 10:
              if (data == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 19 : 9;
                continue;
              }
              goto default;
            case 11:
            case 14:
            case 15:
              goto label_28;
            case 12:
              numArray = (byte[]) null;
              goto label_46;
            case 13:
              if (ModuleManager.qrMmTWp641xiDg5vrSs(ModuleManager.dyLHTMp4DVSetq5MxCD((object) configurationInfo), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(813604817 ^ 813571313)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 15 : 15;
                continue;
              }
              goto case 3;
            case 16:
              ModuleManager.oVRZM8pGulEWGGvneFD((object) configurationInfo, !(ModuleManager.xBLEm0p31qkQ5IvcsFm((object) dataReader, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669371371 ^ 1669338207)) is DBNull) ? (AutoDeployComponentStatus) Convert.ToInt32(ModuleManager.xBLEm0p31qkQ5IvcsFm((object) dataReader, ModuleManager.yONloC3ygB4MNggpRib(-1867198571 ^ -1867231711))) : AutoDeployComponentStatus.None);
              num2 = 9;
              continue;
            case 17:
              ModuleManager.OetiW4pHr23Uq4O0arV((object) configurationInfo, dataReader[(string) ModuleManager.yONloC3ygB4MNggpRib(-2112703338 ^ -2112735984)] is DBNull ? StoreComponentStatus.Active : (StoreComponentStatus) ModuleManager.W6smCNpa8rqMQZCNgsT(ModuleManager.xBLEm0p31qkQ5IvcsFm((object) dataReader, ModuleManager.yONloC3ygB4MNggpRib(322893104 - -1992822529 ^ -1979218505))));
              num2 = 7;
              continue;
            case 18:
              ModuleManager.xhl4Ab3sIas6KSoKJAA((object) configurationInfo, !(ModuleManager.xBLEm0p31qkQ5IvcsFm((object) dataReader, ModuleManager.yONloC3ygB4MNggpRib(-2092274397 << 4 ^ 883315542)) is DBNull) ? (object) (string) ModuleManager.xBLEm0p31qkQ5IvcsFm((object) dataReader, ModuleManager.yONloC3ygB4MNggpRib(~289714581 ^ -289681652)) : (object) (string) null);
              num2 = 21;
              continue;
            case 19:
            case 23:
label_30:
              ModuleManager.JQbk1ypxL15KXUMbbPV((object) configurationInfo);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 6 : 8;
              continue;
            case 20:
              ModuleManager.rkFdxe3LbLmFXWqaDBK((object) configurationInfo, (object) (string) ModuleManager.xBLEm0p31qkQ5IvcsFm((object) dataReader, ModuleManager.yONloC3ygB4MNggpRib(-680446928 - -370807692 ^ -309606686)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 13 : 4;
              continue;
            case 21:
              configurationInfo.Version = !(ModuleManager.xBLEm0p31qkQ5IvcsFm((object) dataReader, ModuleManager.yONloC3ygB4MNggpRib(-244066886 - -48452443 ^ -195581855)) is DBNull) ? (string) ModuleManager.xBLEm0p31qkQ5IvcsFm((object) dataReader, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867231519)) : (string) null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 17 : 0;
              continue;
            case 22:
              str = (string) null;
              break;
            case 24:
              goto label_50;
            default:
              if (data.Length != 0)
              {
                num2 = 6;
                continue;
              }
              goto case 19;
          }
          xml = str;
          num2 = 4;
          continue;
label_46:
          data = numArray;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 2 : 0;
        }
label_50:
        return;
label_22:
        configurationInfo = new ModuleManager.StoreComponentConfigurationInfo((IModuleManager) this);
        num2 = 20;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
        {
          num2 = 3;
          goto label_5;
        }
        else
          goto label_5;
label_29:
        num2 = 24;
        goto label_5;
      }
      finally
      {
        int num5;
        if (dataReader == null)
          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 1 : 1;
        else
          goto label_51;
label_49:
        switch (num5)
        {
          case 2:
            break;
          default:
        }
label_51:
        ModuleManager.iuHeM53mWnmLRYCDxGL((object) dataReader);
        num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
        {
          num5 = 0;
          goto label_49;
        }
        else
          goto label_49;
      }
    }

    private void SaveStoreComponentConfigurationInfos(
      IEnumerable<ModuleManager.StoreComponentConfigurationInfo> infos)
    {
      this.transformationProvider.BeginTransaction();
      try
      {
        this.transformationProvider.ExecuteNonQuery(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97938360), (object) this.transformationProvider.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146543075))));
        foreach (ModuleManager.StoreComponentConfigurationInfo info in infos)
          this.InsertStoreComponentConfigurationInfo(info);
        this.transformationProvider.CommitTransaction();
      }
      catch
      {
        this.transformationProvider.RollbackTransaction();
        throw;
      }
    }

    private void SaveStoreComponentConfigurationInfo(
      ModuleManager.StoreComponentConfigurationInfo info)
    {
      int num1 = 1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (info == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
              continue;
            }
            if (this.transformationProvider != null)
            {
              this.transformationProvider.BeginTransaction();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 2 : 1;
              continue;
            }
            num1 = 4;
            continue;
          case 2:
            goto label_3;
          case 3:
            goto label_13;
          case 4:
            goto label_2;
          default:
            goto label_19;
        }
      }
label_13:
      return;
label_2:
      return;
label_3:
      try
      {
        this.transformationProvider.ExecuteNonQuery((string) ModuleManager.mXTG76ptt81V82tSAi6((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1232639661 >> 3 ^ 154113685), ModuleManager.nikZbnp18ka5K8Sp8EL(ModuleManager.PQlFZ9pP2CyFgoPbJoo((object) this.transformationProvider), ModuleManager.yONloC3ygB4MNggpRib(1051802738 - -1831968059 ^ -1411229549)), ModuleManager.nikZbnp18ka5K8Sp8EL(ModuleManager.PQlFZ9pP2CyFgoPbJoo((object) this.transformationProvider), ModuleManager.yONloC3ygB4MNggpRib(1470440286 ^ 1470472704)), ModuleManager.TheDa1pD5QxNyWuVDpV((object) this.transformationProvider)), new Dictionary<string, object>()
        {
          {
            (string) ModuleManager.yONloC3ygB4MNggpRib(-2106517564 ^ -2106485944),
            (object) info.Id
          }
        });
        int num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
          num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_9;
            case 1:
              this.InsertStoreComponentConfigurationInfo(info);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 1 : 2;
              continue;
            case 2:
              ModuleManager.nKidfWpm0w5fIS182iy((object) this.transformationProvider);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
              continue;
            default:
              goto label_6;
          }
        }
label_9:
        return;
label_6:
        return;
      }
      catch
      {
        int num3 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
          num3 = 1;
        while (true)
        {
          switch (num3)
          {
            case 1:
              ModuleManager.qvH0ghpyNoKNIMPf7FJ((object) this.transformationProvider);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 0 : 0;
              continue;
            default:
              goto label_15;
          }
        }
label_15:
        throw;
      }
label_19:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1021410165 ^ 1021382195));
    }

    private void InsertStoreComponentConfigurationInfo(
      ModuleManager.StoreComponentConfigurationInfo info)
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          string str1;
          byte[] numArray1;
          byte[] numArray2;
          string str2;
          switch (num2)
          {
            case 0:
              goto label_7;
            case 1:
              if (info.Signatures == null)
              {
                num2 = 7;
                continue;
              }
              goto case 8;
            case 2:
              str2 = (string) null;
              break;
            case 3:
              if (ModuleManager.hJKXPmpMrT1dNVVdIBo((object) info) == null)
              {
                num2 = 2;
                continue;
              }
              str2 = ClassSerializationHelper.SerializeObjectByXml((object) info.Manifest, false);
              break;
            case 4:
            case 7:
              numArray2 = (byte[]) null;
              goto label_17;
            case 5:
              ModuleManager.VL40blp9ywHdKskC2h9((object) this.transformationProvider, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(2008901894 << 3 ^ -1108621042), (object) new string[8]
              {
                (string) ModuleManager.yONloC3ygB4MNggpRib(-1876063057 ^ -1876095503),
                z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867231501),
                z2jc63fLkugS1X8Q9N.tE1kD1vbB(979449278 ^ 979481802),
                (string) ModuleManager.yONloC3ygB4MNggpRib(1051276242 - 990076387 ^ 61166697),
                (string) ModuleManager.yONloC3ygB4MNggpRib(-441065788 ^ -2092910478 ^ 1727391520),
                (string) ModuleManager.yONloC3ygB4MNggpRib(--1418440330 ^ 1418407742),
                (string) ModuleManager.yONloC3ygB4MNggpRib(~538519529 ^ -538551866),
                (string) ModuleManager.yONloC3ygB4MNggpRib(1021410165 ^ 1021442705)
              }, (object) new object[8]
              {
                ModuleManager.dyLHTMp4DVSetq5MxCD((object) info),
                ModuleManager.Ts3wDkpA8qCNAnReBfp((object) info),
                ModuleManager.Co6sAIpJxoUy6YirMj7((object) info),
                (object) (int) ModuleManager.nWhm5b3YKIDl314M13q((object) info),
                (object) info.DeployVersion,
                (object) (int) ModuleManager.Wsce5IphTR50SQ5rsEu((object) info),
                (object) str1,
                (object) new ParameterValue(DbType.Binary, (object) numArray1)
              });
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
              continue;
            case 6:
              numArray2 = StoreComponentSignatureInfo.Compress(info.Signatures);
              goto label_17;
            case 8:
              if (!info.Signatures.Any<StoreComponentSignatureInfo>())
                goto case 4;
              else
                goto label_13;
            default:
              goto label_5;
          }
          str1 = str2;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 1 : 1;
          continue;
label_17:
          numArray1 = numArray2;
          num2 = 5;
        }
label_13:
        num1 = 6;
      }
label_7:
      return;
label_5:;
    }

    static ModuleManager()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            ModuleManager.oSb9g2pdI90cCdc8cXO();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            ModuleManager.log = (EleWise.ELMA.Logging.ILogger) ModuleManager.K6pmOGplRI6sDxk56H2(ModuleManager.yONloC3ygB4MNggpRib(-688192331 - 435440695 ^ -1123664672));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 2 : 0;
            continue;
        }
      }
label_2:;
    }

    internal static object BVcm5i3AuIFiiyn3CWX([In] object obj0) => (object) ((Application) obj0).MainLicensedUnit;

    internal static bool PNTXtK36LfU89Nj5O58() => ModuleManager.bstp4K34ECorWvCd3sT == null;

    internal static ModuleManager r0JUUP3HM5LHPXgfZbm() => ModuleManager.bstp4K34ECorWvCd3sT;

    internal static object y9Rw7s37vtuqDCQyife([In] object obj0) => (object) ((IApplicationUnit) obj0).Owner;

    internal static object viBoOG3xGktHcXIjbKZ([In] object obj0) => (object) EleWise.ELMA.SR.M((string) obj0);

    internal static object xd3TkY30TRJgcA0Gcwk(double completePercent, [In] object obj1) => (object) StartInformation.Operation(completePercent, (string) obj1);

    internal static void iuHeM53mWnmLRYCDxGL([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object yONloC3ygB4MNggpRib(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object Au5noq3MyumEpUNuXEA([In] object obj0) => (object) ((PackageService) obj0).GetComponent();

    internal static bool VYyCqi3JOYKnxSFMxKe([In] object obj0) => ((IElmaComponent) obj0).IsInstalled();

    internal static int YXwOUB39tk7WWU7qYpd([In] object obj0) => ((List<ModuleManager.StoreComponentConfigurationInfo>) obj0).Count;

    internal static object T6y7cn3dwy25eMCwujO([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object JY5ViB3lQGjSNqgjRWT([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static void fb0eAe3rAXkRVCqXPRS([In] object obj0, [In] object obj1) => ((EleWise.ELMA.Logging.ILogger) obj0).Error(obj1);

    internal static object e5GOnH3gL6FkjYerpVx([In] object obj0) => (object) ((IElmaComponent) obj0).GetConfigurationPackagesDirectory();

    internal static void kRCEf935Iwk42OJbs5K([In] object obj0) => File.Delete((string) obj0);

    internal static void DLkNZ13jvE6BDLmf2Cg([In] object obj0, ModuleStatus value) => ((ModuleBase) obj0).Status = value;

    internal static StoreComponentStatus nWhm5b3YKIDl314M13q([In] object obj0) => ((ModuleManager.StoreComponentConfigurationInfo) obj0).Status;

    internal static void rkFdxe3LbLmFXWqaDBK([In] object obj0, [In] object obj1) => ((ModuleManager.StoreComponentConfigurationInfo) obj0).Id = (string) obj1;

    internal static object ByS20C3UIDGVZNSBNUu([In] object obj0) => (object) ((IStoreComponentInfo) obj0).Title;

    internal static void xhl4Ab3sIas6KSoKJAA([In] object obj0, [In] object obj1) => ((ModuleManager.StoreComponentConfigurationInfo) obj0).Title = (string) obj1;

    internal static object gwsKGy3cAuMQuMLtXfm([In] object obj0) => (object) ((IStoreComponentInfo) obj0).InstalledVersion;

    internal static bool AwOZwt3zbx1CXTaF9kw([In] object obj0, [In] object obj1) => (SemanticVersion) obj0 != (SemanticVersion) obj1;

    internal static void RYyZt8pFHQCPdFvpZGX([In] object obj0, [In] object obj1) => ((ModuleManager.StoreComponentConfigurationInfo) obj0).Version = (string) obj1;

    internal static object SFeA9OpB0kWZ4CZ69VS([In] object obj0) => (object) ((ManifestStoreComponentInfo) obj0).LastManifest;

    internal static void m9pQrSpWnf13sPhlEc4([In] object obj0, [In] object obj1) => ((ModuleManager.StoreComponentConfigurationInfo) obj0).Manifest = (ElmaStoreComponentManifest) obj1;

    internal static object Mxao2GpoH3j3rHjDeqf([In] object obj0) => (object) ((ManifestStoreComponentInfo) obj0).InstalledFile;

    internal static object KwFBXKpbx8pGbmVOeUF([In] object obj0) => (object) ((ManifestStoreComponentInfo) obj0).LastFile;

    internal static AutoDeployComponentStatus Wsce5IphTR50SQ5rsEu([In] object obj0) => ((ModuleManager.StoreComponentConfigurationInfo) obj0).DeployStatus;

    internal static void oVRZM8pGulEWGGvneFD([In] object obj0, AutoDeployComponentStatus value) => ((ModuleManager.StoreComponentConfigurationInfo) obj0).DeployStatus = value;

    internal static object axXbShpExox4KD0IfdS([In] object obj0) => (object) ((ModuleManager.StoreComponentConfigurationInfo) obj0).DeployVersion;

    internal static void iwYfvvpfg3gZfFMs6td([In] object obj0, [In] object obj1) => ((ModuleManager.StoreComponentConfigurationInfo) obj0).DeployVersion = (string) obj1;

    internal static ModuleStatus ngtxIXpQl2A3PXVLYB6([In] object obj0) => ((IStoreComponentInfo) obj0).Status;

    internal static ModuleDisabledReason zck0uqpCnRQt4SNTHOI([In] object obj0) => ((IStoreComponentInfo) obj0).DisabledReason;

    internal static bool yiHGD7pvyVKFJQpxj3Y([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static object thF2eJp85704Nk54WwF([In] object obj0) => (object) ((IApplicationUnit) obj0).Id;

    internal static Guid HbHbtIpZSxNStZA7kQ9([In] object obj0) => ((IApplicationUnit) obj0).Uid;

    internal static void soLcsrpuMFAfRcbevLd([In] object obj0) => ((ConcurrentDictionary<Assembly, Tuple<bool, ModuleDisabledReason>>) obj0).Clear();

    internal static object fMZA9kpI308HGCkyBLl([In] object obj0) => (object) ((IModuleAssembly) obj0).Assembly;

    internal static ModuleStatus P7RptNpVLamYrCNwPMO([In] object obj0) => ((ModuleBase) obj0).Status;

    internal static void jpkPjwpSod5pILbep3X([In] object obj0, ModuleDisabledReason value) => ((ModuleBase) obj0).DisabledReason = value;

    internal static Guid jGUClkpi8cj3WWqyZtt([In] object obj0) => ((ApplicationUnit) obj0).Uid;

    internal static bool NpOjjbpRMXMKaqldEiq([In] object obj0) => ((ModuleBase) obj0).ServerModuleRequired;

    internal static object kxZ0xApqQOoXhVW4IDJ([In] object obj0) => (object) ((ApplicationUnit) obj0).Title;

    internal static LicenseStatus MPovyqpKKJPra3Yif3v([In] object obj0) => ((ILicenseInfo) obj0).Status;

    internal static bool cIjf0TpXumxu1T6m4kp([In] object obj0) => ((PackageDescription) obj0).IsInstalled;

    internal static ModuleStatus jpLZJVpTslFh7r0gZHr([In] object obj0) => ((IModule) obj0).Status;

    internal static bool POMfEGpkRyXSF6PrYrk([In] object obj0, [In] object obj1) => ((ITransformationProvider) obj0).TableExists((string) obj1);

    internal static void OEfs2Tpn5J5PrhNJqYi([In] object obj0, [In] object obj1) => ((EleWise.ELMA.Runtime.Db.Migrator.Framework.Table) obj0).Name = (string) obj1;

    internal static void BNyjwspOPY0cjvbRZim([In] object obj0, [In] object obj1) => ((ITransformationProvider) obj0).AddTable((EleWise.ELMA.Runtime.Db.Migrator.Framework.Table) obj1);

    internal static void J2KZrAp2HuEihN1WQrK([In] object obj0, [In] object obj1) => ((EleWise.ELMA.Runtime.Db.Migrator.Framework.Index) obj0).TableName = (string) obj1;

    internal static void aJASigpe8g59sQ3a9wu([In] object obj0, [In] object obj1) => ((EleWise.ELMA.Runtime.Db.Migrator.Framework.Index) obj0).Name = (string) obj1;

    internal static object PQlFZ9pP2CyFgoPbJoo([In] object obj0) => (object) ((ITransformationProvider) obj0).Dialect;

    internal static object nikZbnp18ka5K8Sp8EL([In] object obj0, [In] object obj1) => (object) ((Dialect) obj0).QuoteIfNeeded((string) obj1);

    internal static object mvJMT9pN9DhRaWVIlCD([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static object xBLEm0p31qkQ5IvcsFm([In] object obj0, [In] object obj1) => ((IDataRecord) obj0)[(string) obj1];

    internal static Guid qNjHT7pp57kACrTj8IH([In] object obj0, [In] object obj1) => ((Dialect) obj0).GetGuid(obj1);

    internal static int W6smCNpa8rqMQZCNgsT([In] object obj0) => Convert.ToInt32(obj0);

    internal static object TheDa1pD5QxNyWuVDpV([In] object obj0) => (object) ((ITransformationProvider) obj0).ParameterSeparator;

    internal static object mXTG76ptt81V82tSAi6([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => (object) string.Format((string) obj0, obj1, obj2, obj3);

    internal static object vZJeQCpw0JvvMLPgcOC([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, (object[]) obj1);

    internal static object dyLHTMp4DVSetq5MxCD([In] object obj0) => (object) ((ModuleManager.StoreComponentConfigurationInfo) obj0).Id;

    internal static bool qrMmTWp641xiDg5vrSs([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static void OetiW4pHr23Uq4O0arV([In] object obj0, StoreComponentStatus value) => ((ModuleManager.StoreComponentConfigurationInfo) obj0).Status = value;

    internal static object Ts3wDkpA8qCNAnReBfp([In] object obj0) => (object) ((ModuleManager.StoreComponentConfigurationInfo) obj0).Title;

    internal static bool YiDquWp7wpcjTjcP7sO([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static void JQbk1ypxL15KXUMbbPV([In] object obj0) => ((ModuleManager.StoreComponentConfigurationInfo) obj0).InitLicensedUnit();

    internal static bool AtLuOPp0HkjuWfuFT95([In] object obj0) => ((IDataReader) obj0).Read();

    internal static void nKidfWpm0w5fIS182iy([In] object obj0) => ((ITransformationProviderBase) obj0).CommitTransaction();

    internal static void qvH0ghpyNoKNIMPf7FJ([In] object obj0) => ((ITransformationProvider) obj0).RollbackTransaction();

    internal static object hJKXPmpMrT1dNVVdIBo([In] object obj0) => (object) ((ModuleManager.StoreComponentConfigurationInfo) obj0).Manifest;

    internal static object Co6sAIpJxoUy6YirMj7([In] object obj0) => (object) ((ModuleManager.StoreComponentConfigurationInfo) obj0).Version;

    internal static int VL40blp9ywHdKskC2h9([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((ITransformationProvider) obj0).Insert((string) obj1, (string[]) obj2, (object[]) obj3);

    internal static void oSb9g2pdI90cCdc8cXO() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object K6pmOGplRI6sDxk56H2([In] object obj0) => (object) Logger.GetLogger((string) obj0);

    internal static object jJPY6WprI100In2IOGe([In] object obj0) => (object) ((IStoreComponentInfo) obj0).Id;

    internal static object fKTUiapgJybd8MyoSSb([In] object obj0) => (object) ((ManifestStoreComponentInfo) obj0).InstalledManifest;

    private static class DbModuleStatuses
    {
      /// <summary>Поля</summary>
      public static class Fields
      {
        public const string ModuleUid = "ModuleUid";
        public const string ModuleStatus = "ModuleStatus";
      }
    }

    private static class DbStoreComponentConfigurationInfo
    {
      /// <summary>Поля</summary>
      public static class Fields
      {
        public const string Id = "Id";
        public const string Title = "Title";
        public const string Version = "Version";
        public const string Status = "Status";
        public const string DeployVersion = "DeployVersion";
        public const string DeployStatus = "DeployStatus";
        public const string Manifest = "Manifest";
        public const string Signatures = "Signatures";
      }
    }

    /// <summary>Информация о компоненте ELMA Store</summary>
    internal class StoreComponentConfigurationInfo
    {
      private IModuleManager _owner;
      internal static ModuleManager.StoreComponentConfigurationInfo zSTCKxfMLw4ViXSiigTu;

      /// <summary>Информация о компоненте ELMA Store</summary>
      /// <param name="owner">Менеджер управления модулями</param>
      public StoreComponentConfigurationInfo(IModuleManager owner)
      {
        ModuleManager.StoreComponentConfigurationInfo.HrJqJffMcUInH8nFPFyt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_3;
            case 1:
              this._owner = owner;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
              continue;
            default:
              goto label_5;
          }
        }
label_3:
        return;
label_5:;
      }

      /// <summary>Информация о компоненте ELMA Store</summary>
      /// <param name="owner">Менеджер управления модулями</param>
      /// <param name="manifest">Описание компонента Elma Store</param>
      /// <param name="signatures">Информация об электронной подписи компонента Elma Store</param>
      /// <param name="status">Статус компонента ELMA Store</param>
      public StoreComponentConfigurationInfo(
        IModuleManager owner,
        ElmaStoreComponentManifest manifest,
        IEnumerable<StoreComponentSignatureInfo> signatures,
        StoreComponentStatus status)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        this._owner = owner;
        this.Id = manifest != null ? manifest.Id : throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917256330 ^ 1917287564));
        this.Title = manifest.Title;
        this.Version = manifest.Version;
        this.Manifest = manifest;
        this.Signatures = signatures;
        this.InitLicensedUnit();
      }

      /// <summary>Строковый идентификатор</summary>
      public string Id
      {
        get => this.\u003CId\u003Ek__BackingField;
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
                this.\u003CId\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 0 : 0;
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

      /// <summary>Название</summary>
      public string Title
      {
        get => this.\u003CTitle\u003Ek__BackingField;
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
                this.\u003CTitle\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 0 : 0;
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

      /// <summary>Версия</summary>
      public string Version
      {
        get => this.\u003CVersion\u003Ek__BackingField;
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
                this.\u003CVersion\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
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

      /// <summary>Статус</summary>
      public StoreComponentStatus Status
      {
        get => this.\u003CStatus\u003Ek__BackingField;
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
                this.\u003CStatus\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
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

      /// <summary>Версия при авторазвертывании</summary>
      public string DeployVersion
      {
        get => this.\u003CDeployVersion\u003Ek__BackingField;
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
                this.\u003CDeployVersion\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
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

      /// <summary>Версия в нугетовском формате</summary>
      public SemanticVersion SemanticDeployVersion
      {
        get
        {
          SemanticVersion semanticDeployVersion;
          switch (1)
          {
            case 1:
              try
              {
                semanticDeployVersion = new SemanticVersion(this.DeployVersion);
                int num = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
                  num = 0;
                switch (num)
                {
                }
              }
              catch (Exception ex)
              {
                int num = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
                  num = 0;
                while (true)
                {
                  switch (num)
                  {
                    case 1:
                      goto label_8;
                    default:
                      semanticDeployVersion = (SemanticVersion) null;
                      num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 1 : 1;
                      continue;
                  }
                }
              }
              break;
          }
label_8:
          return semanticDeployVersion;
        }
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
                this.DeployVersion = value.ToString();
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 0;
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

      /// <summary>Статус при авторазвертывании</summary>
      public AutoDeployComponentStatus DeployStatus
      {
        get => this.\u003CDeployStatus\u003Ek__BackingField;
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
                this.\u003CDeployStatus\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
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

      /// <summary>Описание компонента</summary>
      public ElmaStoreComponentManifest Manifest
      {
        get => this.\u003CManifest\u003Ek__BackingField;
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
                this.\u003CManifest\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
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

      /// <summary>Электронные подписи</summary>
      public IEnumerable<StoreComponentSignatureInfo> Signatures { get; set; }

      /// <summary>Лицензируемая часть приложения</summary>
      public ILicensedUnit LicensedUnit
      {
        get => this.\u003CLicensedUnit\u003Ek__BackingField;
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
                this.\u003CLicensedUnit\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 0 : 0;
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

      /// <summary>Инициализация лицензируемой части приложения</summary>
      public void InitLicensedUnit()
      {
        int num1 = 5;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            List<string>.Enumerator enumerator;
            switch (num2)
            {
              case 1:
                try
                {
label_15:
                  if (enumerator.MoveNext())
                    goto label_17;
                  else
                    goto label_16;
label_12:
                  string current;
                  int num3;
                  while (true)
                  {
                    switch (num3)
                    {
                      case 1:
                        goto label_3;
                      case 2:
                        ModuleManager.StoreComponentConfigurationInfo.X0L9tnfJhWKUo6qsGdwO((object) this.LicensedUnit, (object) current);
                        num3 = 3;
                        continue;
                      case 3:
                        goto label_15;
                      default:
                        goto label_17;
                    }
                  }
label_16:
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 1 : 1;
                  goto label_12;
label_17:
                  current = enumerator.Current;
                  num3 = 2;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
                  {
                    num3 = 0;
                    goto label_12;
                  }
                  else
                    goto label_12;
                }
                finally
                {
                  enumerator.Dispose();
                  int num4 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
                    num4 = 0;
                  switch (num4)
                  {
                    default:
                  }
                }
              case 2:
                List<string> list = ((ComponentManager) ModuleManager.StoreComponentConfigurationInfo.Xo0xyEfJBqYqton5XF9a()).LicenseManager.GetActivationKeys().Select<KeyValuePair<Guid, string>, string>((System.Func<KeyValuePair<Guid, string>, string>) (p => p.Value)).ToList<string>();
                Guid moduleUid = ModuleManager.StoreComponentConfigurationInfo.NeKl84fJWAHMY8Gtr8kE((object) this.Manifest);
                object id = ModuleManager.StoreComponentConfigurationInfo.eq2VdafJofGYGpx0xeWF((object) this.Manifest);
                object version = ModuleManager.StoreComponentConfigurationInfo.gO6qPXfJbwZlmhhGLJQV((object) this.Manifest);
                IEnumerable<StoreComponentSignatureInfo> signatures = this.Signatures;
                // ISSUE: reference to a compiler-generated field
                System.Func<StoreComponentSignatureInfo, X509Certificate2> func = ModuleManager.StoreComponentConfigurationInfo.\u003C\u003Ec.\u003C\u003E9__42_1;
                System.Func<StoreComponentSignatureInfo, X509Certificate2> selector;
                if (func == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  ModuleManager.StoreComponentConfigurationInfo.\u003C\u003Ec.\u003C\u003E9__42_1 = selector = (System.Func<StoreComponentSignatureInfo, X509Certificate2>) (s => s.ComponentCertificate);
                }
                else
                  goto label_34;
label_33:
                X509Certificate2[] array = signatures.Select<StoreComponentSignatureInfo, X509Certificate2>(selector).ToArray<X509Certificate2>();
                Func<DateTime?> getMainUnitExpiration = new Func<DateTime?>(this._owner.GetMainLicensedUnitExpiration);
                this.LicensedUnit = (ILicensedUnit) new RSALicensedUnit(moduleUid, (string) id, (string) version, (IEnumerable<X509Certificate2>) array, getMainUnitExpiration);
                enumerator = list.GetEnumerator();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 1;
                continue;
label_34:
                selector = func;
                goto label_33;
              case 3:
                if (this.Signatures.Any<StoreComponentSignatureInfo>())
                  goto case 9;
                else
                  goto label_5;
              case 4:
                if (ModuleManager.StoreComponentConfigurationInfo.NpG3FHfMzlDbEcy8Fa3c((object) this.Manifest) == ElmaStoreComponentActivationType.Paid)
                {
                  num2 = 7;
                  continue;
                }
                goto label_23;
              case 5:
                if (this.Manifest != null)
                {
                  num2 = 4;
                  continue;
                }
                goto label_19;
              case 6:
                goto label_31;
              case 7:
                if (this.Signatures != null)
                {
                  num2 = 3;
                  continue;
                }
                goto label_25;
              case 8:
                goto label_13;
              case 9:
                if (!ModuleManager.StoreComponentConfigurationInfo.qQ0kR6fJFud9pskTNtQd())
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 8 : 6;
                  continue;
                }
                goto case 2;
              case 10:
                goto label_8;
            }
label_3:
            ModuleManager.StoreComponentConfigurationInfo.fI9djgfJGY3VQ4on4rEs((object) this.LicensedUnit);
            num2 = 10;
          }
label_5:
          num1 = 6;
        }
label_31:
        return;
label_13:
        return;
label_8:
        return;
label_25:
        return;
label_23:
        return;
label_19:;
      }

      /// <summary>Преобразовать в строку</summary>
      /// <returns></returns>
      public override string ToString() => this.Id + (string) ModuleManager.StoreComponentConfigurationInfo.SZXWgqfJEpSQniLSmSgm(1319452732 ^ 1319438622) + this.Version;

      internal static void HrJqJffMcUInH8nFPFyt() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool sfPHY9fMUEKVJRlftmdK() => ModuleManager.StoreComponentConfigurationInfo.zSTCKxfMLw4ViXSiigTu == null;

      internal static ModuleManager.StoreComponentConfigurationInfo Qu71AQfMsaB8GvG6gL3V() => ModuleManager.StoreComponentConfigurationInfo.zSTCKxfMLw4ViXSiigTu;

      internal static ElmaStoreComponentActivationType NpG3FHfMzlDbEcy8Fa3c([In] object obj0) => ((ElmaStoreComponentManifest) obj0).ActivationType;

      internal static bool qQ0kR6fJFud9pskTNtQd() => ComponentManager.Initialized;

      internal static object Xo0xyEfJBqYqton5XF9a() => (object) ComponentManager.Current;

      internal static Guid NeKl84fJWAHMY8Gtr8kE([In] object obj0) => ((ElmaStoreComponentManifest) obj0).GetUid();

      internal static object eq2VdafJofGYGpx0xeWF([In] object obj0) => (object) ((ElmaStoreComponentManifest) obj0).Id;

      internal static object gO6qPXfJbwZlmhhGLJQV([In] object obj0) => (object) ((ElmaStoreComponentManifest) obj0).Version;

      internal static void X0L9tnfJhWKUo6qsGdwO([In] object obj0, [In] object obj1) => ((ILicensedUnit) obj0).ApplyActivationKey((string) obj1);

      internal static void fI9djgfJGY3VQ4on4rEs([In] object obj0) => ((ILicensedUnit) obj0).CompleteLicensingInitialize();

      internal static object SZXWgqfJEpSQniLSmSgm(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
    }
  }
}
