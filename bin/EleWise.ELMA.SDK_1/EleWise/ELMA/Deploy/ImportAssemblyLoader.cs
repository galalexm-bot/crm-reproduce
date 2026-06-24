// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.ImportAssemblyLoader
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Autofac;
using Autofac.Builder;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Licensing;
using EleWise.ELMA.Licensing.Storages;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.NH.SessionProviders;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Impl;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Web.Hosting;

namespace EleWise.ELMA.Deploy
{
  public class ImportAssemblyLoader : MarshalByRefObject
  {
    private static ComponentManager _componentManager;
    private static readonly Type SessionsContainerProviderType;
    private static ImportAssemblyLoader hki17qEekThcyOlyxI05;

    public Assembly Load(string path)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.ValidatePath(path);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return Assembly.Load(path);
    }

    public Assembly LoadFrom(string path)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.ValidatePath(path);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return (Assembly) ImportAssemblyLoader.wZrsGgEe2JZol5yUn5GX((object) path);
    }

    private void ValidatePath(string path)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_4;
          case 2:
            if (path != null)
            {
              if (!ImportAssemblyLoader.n7WGaAEePPHM5weEdvFE((object) path))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            }
            else
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 1;
              continue;
            }
          default:
            goto label_3;
        }
      }
label_3:
      throw new ArgumentException(string.Format((string) ImportAssemblyLoader.rmKqtJEee9YNKct5o424(-542721635 ^ -542972139), (object) path));
label_4:
      throw new ArgumentNullException((string) ImportAssemblyLoader.rmKqtJEee9YNKct5o424(1925118608 << 2 ^ -889211844));
label_2:;
    }

    public void InitComponentManager(string configurationFileName)
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        ContainerBuilder containerBuilder;
        string[] strArray;
        ComponentManager componentManager;
        while (true)
        {
          switch (num2)
          {
            case 1:
              strArray = new string[1]
              {
                (string) ((object) ((AppDomain) ImportAssemblyLoader.fxBidcEep8ZSgjajRTFw()).RelativeSearchPath ?? ImportAssemblyLoader.pZp07ZEead0GJKH2OGf9(ImportAssemblyLoader.fxBidcEep8ZSgjajRTFw()))
              };
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 3 : 6;
              continue;
            case 2:
              ImportAssemblyLoader.A46tVSEe4h9FSs4R33A1((object) ImportAssemblyLoader._componentManager, (object) new RuntimeApplication(configurationFileName, ImportAssemblyLoader.SessionsContainerProviderType, strArray, (IStartControl) new WebStartControl(), new Dictionary<string, object>()
              {
                {
                  z2jc63fLkugS1X8Q9N.tE1kD1vbB(-138018305 ^ -137916069),
                  (object) true
                }
              }));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 11 : 7;
              continue;
            case 3:
              componentManager = new ComponentManager(ComponentType.Server | ComponentType.WebServer | ComponentType.Web, (IStartControl) new WebStartControl(), containerBuilder);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 5 : 7;
              continue;
            case 4:
              containerBuilder = new ContainerBuilder();
              num2 = 3;
              continue;
            case 5:
              ImportAssemblyLoader.kEIZ5HEe3dfK83mLYeRr(ImportAssemblyLoader.cEr7dEEeNudwCdaBeUGB((object) ImportAssemblyLoader._componentManager), ImportAssemblyLoader.rmKqtJEee9YNKct5o424(-951514650 ^ -951493308));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 1 : 1;
              continue;
            case 6:
              ImportAssemblyLoader.iy0bXREeDOCpgE3vByF7((object) ImportAssemblyLoader._componentManager, (object) strArray);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 0;
              continue;
            case 7:
              componentManager.ActivationKeyStorages = (IEnumerable<IActivationKeyStorage>) new FileSystemActivationKeyStorage[1]
              {
                new FileSystemActivationKeyStorage((string) ImportAssemblyLoader.ppgxG1Ee1tpUFJZp2XM9(ImportAssemblyLoader.rmKqtJEee9YNKct5o424(-882126494 ^ -881881124)))
              };
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 3 : 8;
              continue;
            case 8:
              ImportAssemblyLoader._componentManager = componentManager;
              num2 = 5;
              continue;
            case 9:
              goto label_3;
            case 10:
              this.SetContextVarsImplIfEmpty();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 2;
              continue;
            case 11:
              goto label_12;
            default:
              goto label_9;
          }
        }
label_9:
        ImportAssemblyLoader.qX9lDBEew3eBWulo3ypO((object) new AutofacLocatorImpl((IContainer) ImportAssemblyLoader.wgZVGfEetY5TInNmbYQH((object) containerBuilder, ContainerBuildOptions.None)));
        num1 = 10;
        continue;
label_12:
        ImportAssemblyLoader._componentManager.InitLicensing(strArray, ((AppDomain) ImportAssemblyLoader.fxBidcEep8ZSgjajRTFw()).BaseDirectory);
        num1 = 9;
      }
label_3:;
    }

    /// <summary>
    /// Установка SimpleBoundVariableService в качестве сервиса ContextVars. Выполняется в случае, когда ContextVars не инициализирован.
    /// </summary>
    private void SetContextVarsImplIfEmpty()
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_4;
          case 2:
            goto label_2;
          case 3:
            if (ImportAssemblyLoader.ajVuvHEe6TRku9Zw4cXw())
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 1 : 2;
              continue;
            }
            break;
        }
        ContextVars.SetImpl((IContextBoundVariableService) new SimpleBoundVariableService());
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 1 : 0;
      }
label_4:
      return;
label_2:;
    }

    public bool CheckModuleLicense(string id, out ModuleDTO dto)
    {
      int num1 = 12;
      ILicenseInfo licenseInfo;
      while (true)
      {
        int num2 = num1;
        ILicensedUnit licensedUnit;
        IApplicationUnit unitByUid;
        AssemblyInfoMetadata assemblyInfoMetadata;
        IModule module;
        Assembly assembly;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_10;
            case 2:
              goto label_26;
            case 3:
              dto = module == null ? (ModuleDTO) ImportAssemblyLoader.wMVvfDEe0m1h4Xc1M7h8((object) unitByUid) : (ModuleDTO) ImportAssemblyLoader.KhaQBGEemonLDqcMFQX7((object) module);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 0 : 8;
              continue;
            case 4:
              if (licensedUnit == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 10 : 2;
                continue;
              }
              goto case 3;
            case 5:
              dto = (ModuleDTO) null;
              num2 = 13;
              continue;
            case 6:
              goto label_3;
            case 7:
              licensedUnit = module as ILicensedUnit;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 4;
              continue;
            case 8:
              licenseInfo = (ILicenseInfo) ImportAssemblyLoader.UKndtREeytNLPkrwZBuk((object) licensedUnit);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
              continue;
            case 9:
              ImportAssemblyLoader.POGQrfEeAQVcuVPsfMr0((object) assemblyInfoMetadata, (object) assembly);
              num2 = 5;
              continue;
            case 10:
              licensedUnit = unitByUid as ILicensedUnit;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 14 : 10;
              continue;
            case 11:
              assemblyInfoMetadata = new AssemblyInfoMetadata();
              num2 = 9;
              continue;
            case 12:
              goto label_23;
            case 13:
              unitByUid = ImportAssemblyLoader._componentManager.ModuleManager.FindUnitByUid(ImportAssemblyLoader.ewoCm4Ee7aDo4DRGXcS8((object) assemblyInfoMetadata));
              num2 = 15;
              continue;
            case 14:
              if (licensedUnit != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 3 : 3;
                continue;
              }
              goto label_26;
            case 15:
              if (unitByUid != null)
              {
                module = (IModule) ImportAssemblyLoader.gKhpA9EexwxsNNkwmkLC((object) ImportAssemblyLoader._componentManager.ModuleManager, (object) id);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 7;
                continue;
              }
              num2 = 16;
              continue;
            case 16:
              goto label_19;
            default:
              if (licenseInfo != null)
              {
                if (ImportAssemblyLoader.pI1qGEEeMaMi6XTiKofP((object) licenseInfo) != LicenseStatus.Activated)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 1 : 1;
                  continue;
                }
                goto label_11;
              }
              else
                goto label_15;
          }
        }
label_15:
        num1 = 6;
        continue;
label_23:
        assembly = (Assembly) ImportAssemblyLoader.ElMkBiEeH9jym0krU9Ko((object) id);
        num1 = 11;
      }
label_3:
      return true;
label_10:
      return ImportAssemblyLoader.pI1qGEEeMaMi6XTiKofP((object) licenseInfo) == LicenseStatus.NeedRestart;
label_11:
      return true;
label_19:
      return true;
label_26:
      return true;
    }

    public Guid ActivateNewModules(List<ModuleDTO> modules, string key)
    {
      Guid guid = ImportAssemblyLoader._componentManager.LicenseManager.AddActivationKey(key);
      foreach (ModuleDTO module in modules)
      {
        Assembly asm = Assembly.Load(module.Id);
        AssemblyInfoMetadata assemblyInfoMetadata = new AssemblyInfoMetadata();
        assemblyInfoMetadata.LoadFromAssembly(asm);
        if (ImportAssemblyLoader._componentManager.ModuleManager.FindUnitByUid(assemblyInfoMetadata.Uid) is ILicensedModuleAssembly unitByUid)
          unitByUid.UpdateLicenseInfo();
      }
      return guid;
    }

    public ImportAssemblyLoader()
    {
      ImportAssemblyLoader.pEDNRHEeJYBD5cOEjwga();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static ImportAssemblyLoader()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            // ISSUE: type reference
            ImportAssemblyLoader.SessionsContainerProviderType = ImportAssemblyLoader.xdt9xoEe9nVOuUwm2v0t(__typeref (WebSessionProvider));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 0;
            continue;
          case 2:
            ImportAssemblyLoader.pEDNRHEeJYBD5cOEjwga();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool xgF44rEenTspacyMC5wD() => ImportAssemblyLoader.hki17qEekThcyOlyxI05 == null;

    internal static ImportAssemblyLoader qhMZ56EeOj1GAwunfQqD() => ImportAssemblyLoader.hki17qEekThcyOlyxI05;

    internal static object wZrsGgEe2JZol5yUn5GX([In] object obj0) => (object) Assembly.LoadFrom((string) obj0);

    internal static object rmKqtJEee9YNKct5o424(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool n7WGaAEePPHM5weEdvFE([In] object obj0) => File.Exists((string) obj0);

    internal static object ppgxG1Ee1tpUFJZp2XM9([In] object obj0) => (object) HostingEnvironment.MapPath((string) obj0);

    internal static object cEr7dEEeNudwCdaBeUGB([In] object obj0) => (object) ((ComponentManager) obj0).PackageService;

    internal static void kEIZ5HEe3dfK83mLYeRr([In] object obj0, [In] object obj1) => ((PackageService) obj0).ComponentName = (string) obj1;

    internal static object fxBidcEep8ZSgjajRTFw() => (object) AppDomain.CurrentDomain;

    internal static object pZp07ZEead0GJKH2OGf9([In] object obj0) => (object) ((AppDomain) obj0).BaseDirectory;

    internal static void iy0bXREeDOCpgE3vByF7([In] object obj0, [In] object obj1) => ((ComponentManager) obj0).LoadAssemblies((string[]) obj1);

    internal static object wgZVGfEetY5TInNmbYQH([In] object obj0, [In] ContainerBuildOptions obj1) => (object) ((ContainerBuilder) obj0).Build(obj1);

    internal static void qX9lDBEew3eBWulo3ypO([In] object obj0) => Locator.SetImpl((ILocatorImpl) obj0);

    internal static object A46tVSEe4h9FSs4R33A1([In] object obj0, [In] object obj1) => (object) ((ComponentManager) obj0).RegisterComponent(obj1);

    internal static bool ajVuvHEe6TRku9Zw4cXw() => ContextVars.HasImpl;

    internal static object ElMkBiEeH9jym0krU9Ko([In] object obj0) => (object) Assembly.Load((string) obj0);

    internal static void POGQrfEeAQVcuVPsfMr0([In] object obj0, [In] object obj1) => ((AssemblyInfoMetadata) obj0).LoadFromAssembly((Assembly) obj1);

    internal static Guid ewoCm4Ee7aDo4DRGXcS8([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static object gKhpA9EexwxsNNkwmkLC([In] object obj0, [In] object obj1) => (object) ((IModuleManager) obj0).FindModuleById((string) obj1);

    internal static object wMVvfDEe0m1h4Xc1M7h8([In] object obj0) => (object) ModuleDTO.CreateFrom((IApplicationUnit) obj0);

    internal static object KhaQBGEemonLDqcMFQX7([In] object obj0) => (object) ModuleDTO.CreateFrom((IModule) obj0);

    internal static object UKndtREeytNLPkrwZBuk([In] object obj0) => (object) ((ILicensedUnit) obj0).GetLicenseInfo();

    internal static LicenseStatus pI1qGEEeMaMi6XTiKofP([In] object obj0) => ((ILicenseInfo) obj0).Status;

    internal static void pEDNRHEeJYBD5cOEjwga() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static Type xdt9xoEe9nVOuUwm2v0t([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);
  }
}
