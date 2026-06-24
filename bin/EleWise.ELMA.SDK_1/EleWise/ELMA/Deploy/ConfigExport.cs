// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.ConfigExport
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.BPMApps.Managers;
using EleWise.ELMA.BPMApps.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Deploy.Export.Entities;
using EleWise.ELMA.Deploy.Export.ExtensionPoints;
using EleWise.ELMA.Deploy.Export.Metadata;
using EleWise.ELMA.Deploy.ExtensionPoints;
using EleWise.ELMA.Deploy.Manifest;
using EleWise.ELMA.Deploy.Models;
using EleWise.ELMA.Deploy.Services;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NuGet;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Xml;

namespace EleWise.ELMA.Deploy
{
  /// <summary>Класс экспорта конфигурации</summary>
  public class ConfigExport
  {
    private readonly IAuthenticationService authenticationService;
    private readonly ISecurityService securityService;
    private readonly IMembershipService membershipService;
    private readonly IExportImportFileService exportImportFileService;
    private readonly IZipService zipService;
    private readonly PackageService packageService;
    private readonly IModuleManager moduleManager;
    private readonly IEnumerable<ISecurityDeployHelperExtension> securityDeployHelperExtensions;
    private readonly IEnumerable<IManifestChapterCreator> manifestChapterCreators;
    private readonly IEnumerable<IConfigExportExtension> configExportExtensions;
    private readonly IEnumerable<IExportDataExtension> exportDataExtension;
    /// <summary>Уникальные идентификаторы важных данных для импорта</summary>
    private ISet<Guid> importants;
    /// <summary>
    /// Экспортируемые объекты безопасности, группы метаданных, процессы
    /// </summary>
    private Dictionary<string, object> exportServiceData;
    /// <summary>Экспортируемые пакеты</summary>
    private List<PackageDescription> exportedPackages;
    /// <summary>Реальные пакеты, которые экспортируются</summary>
    private Dictionary<string, IPackage> exportPackages;
    /// <summary>Экспортируемые пакеты сущностей</summary>
    private List<PacketEntity> exportedPacketEntities;
    /// <summary>Экспортируемые пакеты метаданных</summary>
    private List<PacketMetadata> exportedPacketMetadatas;
    /// <summary>Экспортируемые метаданные с флагом переноса данных</summary>
    private Dictionary<IGroupedMetadata, bool> exportedObjects;
    /// <summary>Эскпортируемые формы</summary>
    private List<FormExportData> formExportData;
    /// <summary>
    /// Действия для записи дополнительных файлов компонента ELMA. Параметр - корневая папка для записи доп. файлов
    /// </summary>
    private List<Action<IExportImportFileService, string>> writeComponentFileActions;
    private ConfigExportSettings exportSettings;
    private static readonly EleWise.ELMA.Logging.ILogger ExportLog;
    private List<string> fileUidsM;
    private List<string> fileUidsD;
    internal static ConfigExport v8oOK9EPV7R8Xar9GdCl;

    /// <summary>Ctor</summary>
    public ConfigExport(
      ConfigExportSettings settings,
      IAuthenticationService authenticationService,
      ISecurityService securityService,
      IMembershipService membershipService,
      IExportImportFileService exportImportFileService,
      IZipService zipService,
      PackageService packageService,
      IModuleManager moduleManager,
      IEnumerable<ISecurityDeployHelperExtension> securityDeployHelperExtensions,
      IEnumerable<IManifestChapterCreator> manifestChapterCreators,
      IEnumerable<IConfigExportExtension> configExportExtensions)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.exportPackages = new Dictionary<string, IPackage>();
      this.fileUidsM = new List<string>();
      this.fileUidsD = new List<string>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.exportSettings = settings;
      this.authenticationService = authenticationService;
      this.securityService = securityService;
      this.membershipService = membershipService;
      this.exportImportFileService = exportImportFileService;
      this.zipService = zipService;
      this.packageService = packageService;
      this.moduleManager = moduleManager;
      this.securityDeployHelperExtensions = securityDeployHelperExtensions;
      this.manifestChapterCreators = manifestChapterCreators;
      this.configExportExtensions = configExportExtensions;
    }

    /// <summary>Протокол экспорта-импорта</summary>
    private string Protocol
    {
      get
      {
        int num1 = 1;
        while (true)
        {
          int num2;
          switch (num1)
          {
            case 1:
              ISet<Guid> importants = this.importants;
              if (importants == null)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 0 : 0;
                continue;
              }
              num2 = ConfigExport.eLgxOFEPRbqCYA6N0jED((object) importants) > 0 ? 1 : 0;
              break;
            case 2:
              goto label_2;
            default:
              num2 = 0;
              break;
          }
          if (num2 == 0)
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 1 : 2;
          else
            goto label_3;
        }
label_2:
        return (string) ConfigExport.AG4Q6BEPqE5aLValmTMo(1012087039 ^ 1012360729);
label_3:
        return (string) ConfigExport.AG4Q6BEPqE5aLValmTMo(864270449 << 6 ^ -521518416);
      }
    }

    /// <summary>Версия экспорта-импорта</summary>
    private string Version => (string) ConfigExport.AG4Q6BEPqE5aLValmTMo(-2092274397 << 4 ^ 883068106);

    /// <summary>Версия сборки</summary>
    private string Build => VersionInfo.GetVersion<EleWise.ELMA.SR>().ToString();

    /// <summary>Ctor</summary>
    /// <param name="settings">Настройки экспорта, полученные из визарда</param>
    public ConfigExport(ConfigExportSettings settings)
    {
      ConfigExport.m3QHF6EPKH5TVrsw1Tf2();
      this.exportPackages = new Dictionary<string, IPackage>();
      this.fileUidsM = new List<string>();
      this.fileUidsD = new List<string>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.moduleManager = Locator.GetServiceNotNull<IModuleManager>();
            num = 6;
            continue;
          case 2:
            goto label_3;
          case 3:
            this.configExportExtensions = ((ComponentManager) ConfigExport.l6cGbPEPXXLEvRQqcrsc()).GetExtensionPoints<IConfigExportExtension>();
            num = 4;
            continue;
          case 4:
            this.exportDataExtension = ComponentManager.Current.GetExtensionPoints<IExportDataExtension>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 2 : 1;
            continue;
          case 5:
            this.manifestChapterCreators = ((ComponentManager) ConfigExport.l6cGbPEPXXLEvRQqcrsc()).GetExtensionPoints<IManifestChapterCreator>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 3 : 3;
            continue;
          case 6:
            this.securityDeployHelperExtensions = ((ComponentManager) ConfigExport.l6cGbPEPXXLEvRQqcrsc()).GetExtensionPoints<ISecurityDeployHelperExtension>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 5 : 2;
            continue;
          case 7:
            this.securityService = Locator.GetServiceNotNull<ISecurityService>();
            num = 9;
            continue;
          case 8:
            this.authenticationService = Locator.GetServiceNotNull<IAuthenticationService>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 7 : 2;
            continue;
          case 9:
            this.membershipService = Locator.GetServiceNotNull<IMembershipService>();
            num = 11;
            continue;
          case 10:
            this.zipService = Locator.GetServiceNotNull<IZipService>();
            num = 12;
            continue;
          case 11:
            this.exportImportFileService = Locator.GetServiceNotNull<IExportImportFileService>();
            num = 10;
            continue;
          case 12:
            this.packageService = Locator.GetServiceNotNull<PackageService>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 1;
            continue;
          default:
            this.exportSettings = settings;
            num = 8;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Запуск экспорта конфигурации</summary>
    public void RunExport(IRunExportParameters parameters)
    {
      int num1 = 2;
      ConfigExport configExport;
      List<DeployLogMessage> messages;
      IRunExportParameters parameters1;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_39;
          case 1:
            configExport = this;
            num1 = 4;
            continue;
          case 2:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 1 : 1;
            continue;
          case 3:
            messages = parameters1.LogMessages;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 1 : 5;
            continue;
          case 4:
            parameters1 = parameters;
            num1 = 6;
            continue;
          case 5:
            goto label_6;
          case 6:
            Contract.ArgumentNotNull((object) parameters1, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1120607109 - 305487170 ^ -1426111049));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 3 : 0;
            continue;
          default:
            goto label_35;
        }
      }
label_39:
      return;
label_35:
      return;
label_6:
      try
      {
        CallContextSessionOwner contextSessionOwner = (CallContextSessionOwner) ConfigExport.D4IV6LEPTsHFZ4dWj1so();
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
          num2 = 0;
        switch (num2)
        {
          case 1:
            break;
          default:
            try
            {
              int num3;
              if (parameters1.SignedUserId != 0L)
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
              else
                goto label_14;
label_12:
              IUser user1;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    System.Action action;
                    ConfigExport.PHqqbPEPniItLegN6evn((object) this.securityService, (object) user1, (object) (System.Action) (() =>
                    {
                      int num37 = 1;
                      while (true)
                      {
                        switch (num37)
                        {
                          case 0:
                            goto label_2;
                          case 1:
                            // ISSUE: reference to a compiler-generated method
                            ConfigExport.\u003C\u003Ec__DisplayClass32_0.tD4QfO8TSIOl6FiaPJJk((object) configExport.securityService, (object) (System.Action) (() =>
                            {
                              int num38 = 16;
                              while (true)
                              {
                                int num39 = num38;
                                CancellationToken cancellationToken;
                                string str7;
                                string folderPath;
                                string configFile;
                                string str8;
                                string str9;
                                XmlWriter writer;
                                IEnumerator<IManifestChapterCreator> enumerator11;
                                string str10;
                                string wbLssPp2qKj;
                                string str11;
                                ExportedObjectsDescription objectsDescription;
                                while (true)
                                {
                                  switch (num39)
                                  {
                                    case 1:
                                      objectsDescription = new ExportedObjectsDescription()
                                      {
                                        ExportServiceData = configExport.exportServiceData,
                                        ExportedObjects = configExport.exportedObjects,
                                        ExportPackages = configExport.exportPackages,
                                        ExportedPacketEntities = configExport.exportedPacketEntities,
                                        ExportedPacketMetadatas = configExport.exportedPacketMetadatas
                                      };
                                      num39 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 31 : 5;
                                      continue;
                                    case 2:
                                      // ISSUE: reference to a compiler-generated method
                                      // ISSUE: reference to a compiler-generated method
                                      str10 = (string) ConfigExport.\u003C\u003Ec__DisplayClass32_0.l2HQ0P8TzUhTy0CIIl0u(ConfigExport.\u003C\u003Ec__DisplayClass32_0.N1aD4H8Ts50173e7MtAA((object) configExport.exportSettings));
                                      num39 = 24;
                                      continue;
                                    case 3:
                                      configExport.WriteAdditionalFiles(str7);
                                      num39 = 9;
                                      continue;
                                    case 4:
                                      // ISSUE: reference to a compiler-generated method
                                      cancellationToken = ConfigExport.\u003C\u003Ec__DisplayClass32_0.scspod8THPX6VrSQf11n((object) parameters1);
                                      num39 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 29 : 17;
                                      continue;
                                    case 5:
                                    case 22:
                                    case 47:
                                      // ISSUE: reference to a compiler-generated method
                                      str11 = (string) ConfigExport.\u003C\u003Ec__DisplayClass32_0.So0j538kFITJuh8nNtdB((object) configExport.exportImportFileService, (object) str7);
                                      num39 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 30 : 17;
                                      continue;
                                    case 6:
                                      // ISSUE: reference to a compiler-generated method
                                      if (ConfigExport.\u003C\u003Ec__DisplayClass32_0.Qj2f168TU6mrn5GQ4pLP((object) configExport.exportSettings) == null)
                                      {
                                        num39 = 47;
                                        continue;
                                      }
                                      goto case 35;
                                    case 7:
                                      configExport.WritePackages(folderPath);
                                      num39 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 13 : 36;
                                      continue;
                                    case 8:
                                      try
                                      {
label_286:
                                        // ISSUE: reference to a compiler-generated method
                                        if (ConfigExport.\u003C\u003Ec__DisplayClass32_0.JnW8mQ8TMBwTE6h2iEia((object) enumerator11))
                                          goto label_284;
                                        else
                                          goto label_287;
label_283:
                                        int num40;
                                        switch (num40)
                                        {
                                          case 1:
                                            break;
                                          case 2:
                                            goto label_286;
                                          default:
                                            goto label_275;
                                        }
label_284:
                                        // ISSUE: reference to a compiler-generated method
                                        ConfigExport.\u003C\u003Ec__DisplayClass32_0.U0NhGV8TjsWYnaQ15Zbe((object) enumerator11.Current, (object) configExport.exportSettings, (object) objectsDescription);
                                        num40 = 2;
                                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
                                        {
                                          num40 = 0;
                                          goto label_283;
                                        }
                                        else
                                          goto label_283;
label_287:
                                        num40 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
                                        goto label_283;
                                      }
                                      finally
                                      {
                                        if (enumerator11 != null)
                                        {
                                          int num41 = 1;
                                          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
                                            num41 = 1;
                                          while (true)
                                          {
                                            switch (num41)
                                            {
                                              case 1:
                                                // ISSUE: reference to a compiler-generated method
                                                ConfigExport.\u003C\u003Ec__DisplayClass32_0.GBuYLM8T93NyrkdrLc2T((object) enumerator11);
                                                num41 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 0 : 0;
                                                continue;
                                              default:
                                                goto label_293;
                                            }
                                          }
                                        }
label_293:;
                                      }
                                    case 9:
                                      // ISSUE: reference to a compiler-generated method
                                      if (ConfigExport.\u003C\u003Ec__DisplayClass32_0.v8jN9a8TdaH0rCukDeVa((object) configExport.exportSettings) == null)
                                      {
                                        num39 = 5;
                                        continue;
                                      }
                                      goto case 34;
                                    case 10:
                                      // ISSUE: reference to a compiler-generated method
                                      object obj = ConfigExport.\u003C\u003Ec__DisplayClass32_0.Y4Gk9c8kWE55M9J2i02B((object) exportParameters2);
                                      if (obj == null)
                                      {
                                        num39 = 42;
                                        continue;
                                      }
                                      // ISSUE: reference to a compiler-generated method
                                      ConfigExport.\u003C\u003Ec__DisplayClass32_0.y6LOqS8koGHYplIOnScn(obj, (object) str11);
                                      num39 = 43;
                                      continue;
                                    case 11:
                                      // ISSUE: reference to a compiler-generated method
                                      str8 = (string) ConfigExport.\u003C\u003Ec__DisplayClass32_0.GTbkLW8Tn8SG0hHjOmpF((object) configExport.exportImportFileService, (object) str7);
                                      num39 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 19 : 1;
                                      continue;
                                    case 12:
                                      configExport.WriteFiles(str7, wbLssPp2qKj);
                                      num39 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 3;
                                      continue;
                                    case 13:
                                      goto label_294;
                                    case 14:
                                      if (!(parameters1 is ISignedExportParameters exportParameters2))
                                      {
                                        num39 = 48;
                                        continue;
                                      }
                                      goto case 28;
                                    case 15:
                                      // ISSUE: reference to a compiler-generated method
                                      // ISSUE: reference to a compiler-generated method
                                      messages.Add(new DeployLogMessage(DeployLogMessageType.Info, (string) ConfigExport.\u003C\u003Ec__DisplayClass32_0.YBoG0Z8TqpBm69r2FfW2(ConfigExport.\u003C\u003Ec__DisplayClass32_0.KFRgXN8TiCgmk2BHGWut(993438473 ^ 993215451)), false));
                                      num39 = 13;
                                      continue;
                                    case 16:
                                      // ISSUE: reference to a compiler-generated method
                                      // ISSUE: reference to a compiler-generated method
                                      ConfigExport.\u003C\u003Ec__DisplayClass32_0.IJx9u28TRx21aJlKk02X((object) ConfigExport.ExportLog, ConfigExport.\u003C\u003Ec__DisplayClass32_0.KFRgXN8TiCgmk2BHGWut(-1921202237 ^ -1921437871));
                                      num39 = 15;
                                      continue;
                                    case 17:
                                      goto label_276;
                                    case 18:
                                      // ISSUE: reference to a compiler-generated method
                                      ConfigExport.\u003C\u003Ec__DisplayClass32_0.GqhvjR8TLoA9nfsAxP9d((object) new ManifestBuilder(configExport.exportSettings.Manifest), (object) str9);
                                      num39 = 6;
                                      continue;
                                    case 19:
                                      // ISSUE: reference to a compiler-generated method
                                      wbLssPp2qKj = (string) ConfigExport.\u003C\u003Ec__DisplayClass32_0.or4tkw8TOWbLssPp2qKj((object) configExport.exportImportFileService, (object) str7);
                                      num39 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 9 : 39;
                                      continue;
                                    case 20:
                                      goto label_11;
                                    case 21:
                                      configExport.WriteHash(configFile);
                                      num39 = 12;
                                      continue;
                                    case 23:
label_275:
                                      // ISSUE: reference to a compiler-generated method
                                      str9 = (string) ConfigExport.\u003C\u003Ec__DisplayClass32_0.jABUhM8TYl665aFugOK0((object) str8, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088151480));
                                      num39 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 15 : 18;
                                      continue;
                                    case 24:
                                      // ISSUE: reference to a compiler-generated method
                                      // ISSUE: reference to a compiler-generated method
                                      // ISSUE: reference to a compiler-generated method
                                      File.WriteAllBytes((string) ConfigExport.\u003C\u003Ec__DisplayClass32_0.jABUhM8TYl665aFugOK0((object) str8, (object) ((string) ConfigExport.\u003C\u003Ec__DisplayClass32_0.KFRgXN8TiCgmk2BHGWut(-1978478350 ^ -1978189006) + str10)), (byte[]) ConfigExport.\u003C\u003Ec__DisplayClass32_0.Qj2f168TU6mrn5GQ4pLP((object) configExport.exportSettings));
                                      num39 = 22;
                                      continue;
                                    case 25:
                                      goto label_303;
                                    case 26:
                                      // ISSUE: reference to a compiler-generated method
                                      ((ElmaStoreComponentManifest) ConfigExport.\u003C\u003Ec__DisplayClass32_0.v8jN9a8TdaH0rCukDeVa((object) configExport.exportSettings)).Processes.Clear();
                                      num39 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 44 : 31;
                                      continue;
                                    case 27:
                                      // ISSUE: reference to a compiler-generated method
                                      // ISSUE: reference to a compiler-generated method
                                      messages.Add(new DeployLogMessage(DeployLogMessageType.Info, (string) ConfigExport.\u003C\u003Ec__DisplayClass32_0.YBoG0Z8TqpBm69r2FfW2(ConfigExport.\u003C\u003Ec__DisplayClass32_0.KFRgXN8TiCgmk2BHGWut(-1426456882 ^ 2009939514 ^ -583980088)), false));
                                      num39 = 4;
                                      continue;
                                    case 28:
                                      // ISSUE: reference to a compiler-generated method
                                      if (ConfigExport.\u003C\u003Ec__DisplayClass32_0.v8jN9a8TdaH0rCukDeVa((object) configExport.exportSettings) == null)
                                      {
                                        num39 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 0 : 0;
                                        continue;
                                      }
                                      goto case 10;
                                    case 29:
                                      cancellationToken.ThrowIfCancellationRequested();
                                      num39 = 21;
                                      continue;
                                    case 30:
                                      // ISSUE: reference to a compiler-generated method
                                      ConfigExport.\u003C\u003Ec__DisplayClass32_0.N48qTu8kB4LtUS8vnrSo((object) configExport.zipService, (object) str11, (object) str8, true);
                                      num39 = 14;
                                      continue;
                                    case 31:
                                      goto label_260;
                                    case 32:
                                      CultureInfo keyCultureInfo = EleWise.ELMA.SR.KeyCultureInfo;
                                      System.Action action3 = action;
                                      System.Action action4 = action3 == null ? (action = (System.Action) (() =>
                                      {
                                        int num9 = 1;
                                        while (true)
                                        {
                                          switch (num9)
                                          {
                                            case 0:
                                              goto label_2;
                                            case 1:
                                              configExport.FillExportedObjects(messages);
                                              num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
                                              continue;
                                            default:
                                              goto label_4;
                                          }
                                        }
label_2:
                                        return;
label_4:;
                                      })) : action3;
                                      // ISSUE: reference to a compiler-generated method
                                      ConfigExport.\u003C\u003Ec__DisplayClass32_0.KS0xBJ8TXnuxpEoEtGyB((object) keyCultureInfo, (object) action4);
                                      num39 = 41;
                                      continue;
                                    case 33:
                                      // ISSUE: reference to a compiler-generated method
                                      // ISSUE: reference to a compiler-generated method
                                      folderPath = (string) ConfigExport.\u003C\u003Ec__DisplayClass32_0.q1MdXs8TeODT7ZbZIJZA((object) configExport.exportImportFileService, (object) str7, ConfigExport.\u003C\u003Ec__DisplayClass32_0.KFRgXN8TiCgmk2BHGWut(87862435 ^ 87607677));
                                      num39 = 7;
                                      continue;
                                    case 34:
                                      // ISSUE: reference to a compiler-generated method
                                      // ISSUE: reference to a compiler-generated method
                                      ConfigExport.\u003C\u003Ec__DisplayClass32_0.QcVdGK8Tl4FB4ErAQ5Ci((object) ((ElmaStoreComponentManifest) ConfigExport.\u003C\u003Ec__DisplayClass32_0.v8jN9a8TdaH0rCukDeVa((object) configExport.exportSettings)).Packages);
                                      num39 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 38 : 22;
                                      continue;
                                    case 35:
                                      // ISSUE: reference to a compiler-generated method
                                      // ISSUE: reference to a compiler-generated method
                                      if (ConfigExport.\u003C\u003Ec__DisplayClass32_0.HyqbsD8Tc6LK6kho2qmP(ConfigExport.\u003C\u003Ec__DisplayClass32_0.N1aD4H8Ts50173e7MtAA((object) configExport.exportSettings)))
                                        goto case 5;
                                      else
                                        goto label_297;
                                    case 36:
                                      string str12 = configFile;
                                      XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
                                      // ISSUE: reference to a compiler-generated method
                                      // ISSUE: reference to a compiler-generated method
                                      ConfigExport.\u003C\u003Ec__DisplayClass32_0.EanPsf8T1UYgk4SVtsDK((object) xmlWriterSettings, ConfigExport.\u003C\u003Ec__DisplayClass32_0.dZdxtH8TPCuA43iMKbpb());
                                      // ISSUE: reference to a compiler-generated method
                                      ConfigExport.\u003C\u003Ec__DisplayClass32_0.sDGkNF8TNxuJsafrPW8y((object) xmlWriterSettings, true);
                                      // ISSUE: reference to a compiler-generated method
                                      ConfigExport.\u003C\u003Ec__DisplayClass32_0.sA5FN28T3Gg7dtNMTPCl((object) xmlWriterSettings, true);
                                      // ISSUE: reference to a compiler-generated method
                                      ConfigExport.\u003C\u003Ec__DisplayClass32_0.bMypWT8TphmRSL1kTmKh((object) xmlWriterSettings, ConformanceLevel.Fragment);
                                      // ISSUE: reference to a compiler-generated method
                                      writer = (XmlWriter) ConfigExport.\u003C\u003Ec__DisplayClass32_0.LbpRl38Ta8w1wt7podIb((object) str12, (object) xmlWriterSettings);
                                      num39 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 46 : 7;
                                      continue;
                                    case 37:
                                      // ISSUE: reference to a compiler-generated method
                                      ConfigExport.\u003C\u003Ec__DisplayClass32_0.Qp2WMu8T2jrxkloPVYaf((object) wbLssPp2qKj);
                                      num39 = 33;
                                      continue;
                                    case 38:
                                      // ISSUE: reference to a compiler-generated method
                                      // ISSUE: reference to a compiler-generated method
                                      ConfigExport.\u003C\u003Ec__DisplayClass32_0.PuQ5uq8TrUm5brK89Mxc((object) ((ElmaStoreComponentManifest) ConfigExport.\u003C\u003Ec__DisplayClass32_0.v8jN9a8TdaH0rCukDeVa((object) configExport.exportSettings)).Entities);
                                      num39 = 26;
                                      continue;
                                    case 39:
                                      // ISSUE: reference to a compiler-generated method
                                      ConfigExport.\u003C\u003Ec__DisplayClass32_0.Qp2WMu8T2jrxkloPVYaf((object) str8);
                                      num39 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 37 : 18;
                                      continue;
                                    case 40:
                                      // ISSUE: reference to a compiler-generated method
                                      // ISSUE: reference to a compiler-generated method
                                      ConfigExport.\u003C\u003Ec__DisplayClass32_0.lRYNja8T5psVjYQenyHi((object) ((ElmaStoreComponentManifest) ConfigExport.\u003C\u003Ec__DisplayClass32_0.v8jN9a8TdaH0rCukDeVa((object) configExport.exportSettings)).BpmApps);
                                      num39 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 1;
                                      continue;
                                    case 41:
                                      // ISSUE: reference to a compiler-generated method
                                      str7 = (string) ConfigExport.\u003C\u003Ec__DisplayClass32_0.WRclQn8TTX3GNIF0CP1f((object) configExport.exportSettings);
                                      num39 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 10 : 20;
                                      continue;
                                    case 44:
                                      // ISSUE: reference to a compiler-generated method
                                      // ISSUE: reference to a compiler-generated method
                                      ConfigExport.\u003C\u003Ec__DisplayClass32_0.VnYryT8TgJZYwIG57DsS((object) ((ElmaStoreComponentManifest) ConfigExport.\u003C\u003Ec__DisplayClass32_0.v8jN9a8TdaH0rCukDeVa((object) configExport.exportSettings)).Reports);
                                      num39 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 5 : 40;
                                      continue;
                                    case 45:
label_295:
                                      messages.Add(new DeployLogMessage(DeployLogMessageType.Empty, "", false));
                                      num39 = 27;
                                      continue;
                                    case 46:
                                      try
                                      {
                                        // ISSUE: reference to a compiler-generated method
                                        // ISSUE: reference to a compiler-generated method
                                        ConfigExport.\u003C\u003Ec__DisplayClass32_0.Y0ojNS8TDDVWJMNdxYh6((object) writer, ConfigExport.\u003C\u003Ec__DisplayClass32_0.KFRgXN8TiCgmk2BHGWut(323422137 << 2 ^ 1293443094));
                                        int num42 = 6;
                                        while (true)
                                        {
                                          int num43;
                                          List<List<ClassMetadata>> classMetadataListList;
                                          List<List<ClassMetadata>>.Enumerator enumerator12;
                                          List<ClassMetadata>.Enumerator enumerator13;
                                          List<ClassMetadata> classMetadataList;
                                          List<PacketMetadata>.Enumerator enumerator14;
                                          List<PacketEntity>.Enumerator enumerator15;
                                          List<ClassMetadata> wasExported;
                                          IEnumerator<KeyValuePair<IGroupedMetadata, bool>> enumerator16;
                                          List<ClassMetadata> group;
                                          switch (num42)
                                          {
                                            case 1:
                                              enumerator12 = classMetadataListList.GetEnumerator();
                                              num42 = 37;
                                              continue;
                                            case 2:
                                              // ISSUE: reference to a compiler-generated method
                                              messages.Add(new DeployLogMessage(DeployLogMessageType.Info, EleWise.ELMA.SR.T((string) ConfigExport.\u003C\u003Ec__DisplayClass32_0.KFRgXN8TiCgmk2BHGWut(-1204263869 ^ -1341583247 ^ 137666076)), false));
                                              num42 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 31 : 36;
                                              continue;
                                            case 3:
label_53:
                                              classMetadataList.RemoveAll((Predicate<ClassMetadata>) (mdC =>
                                              {
                                                List<ClassMetadata> source = group;
                                                // ISSUE: reference to a compiler-generated field
                                                Func<ClassMetadata, Guid> func = ConfigExport.\u003C\u003Ec.\u003C\u003E9__32_8;
                                                Func<ClassMetadata, Guid> selector;
                                                if (func == null)
                                                {
                                                  // ISSUE: reference to a compiler-generated field
                                                  // ISSUE: reference to a compiler-generated method
                                                  ConfigExport.\u003C\u003Ec.\u003C\u003E9__32_8 = selector = (Func<ClassMetadata, Guid>) (g => ConfigExport.\u003C\u003Ec.AkjMcB8kKjImnI2VEdAx((object) g));
                                                }
                                                else
                                                  goto label_1;
label_3:
                                                return source.Select<ClassMetadata, Guid>(selector).Contains<Guid>(mdC.Uid);
label_1:
                                                selector = func;
                                                goto label_3;
                                              }));
                                              num42 = 14;
                                              continue;
                                            case 4:
                                              group = new List<ClassMetadata>();
                                              num42 = 10;
                                              continue;
                                            case 5:
                                              // ISSUE: reference to a compiler-generated method
                                              // ISSUE: reference to a compiler-generated method
                                              ConfigExport.\u003C\u003Ec__DisplayClass32_0.IJx9u28TRx21aJlKk02X((object) ConfigExport.ExportLog, ConfigExport.\u003C\u003Ec__DisplayClass32_0.AxPnN38TwEKwgIf56aG4((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -811790112), (object) configExport.Protocol));
                                              num42 = 20;
                                              continue;
                                            case 6:
                                              // ISSUE: reference to a compiler-generated method
                                              ConfigExport.\u003C\u003Ec__DisplayClass32_0.rrA7Nj8Tt83f73gfBFey((object) writer, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951230060), (object) configExport.Protocol);
                                              num43 = 28;
                                              break;
                                            case 7:
                                              enumerator15 = configExport.exportedPacketEntities.GetEnumerator();
                                              num42 = 32;
                                              continue;
                                            case 8:
                                              num42 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 4 : 3;
                                              continue;
                                            case 9:
                                              messages.Add(new DeployLogMessage(DeployLogMessageType.Empty, "", false));
                                              num43 = 44;
                                              break;
                                            case 10:
                                              enumerator13 = classMetadataList.GetEnumerator();
                                              num42 = 29;
                                              continue;
                                            case 11:
                                              configExport.WriteImportants(writer);
                                              num42 = 26;
                                              continue;
                                            case 12:
                                              try
                                              {
label_238:
                                                // ISSUE: reference to a compiler-generated method
                                                if (ConfigExport.\u003C\u003Ec__DisplayClass32_0.JnW8mQ8TMBwTE6h2iEia((object) enumerator16))
                                                  goto label_235;
                                                else
                                                  goto label_239;
label_232:
                                                ClassMetadata key;
                                                KeyValuePair<IGroupedMetadata, bool> current;
                                                int num44;
                                                while (true)
                                                {
                                                  switch (num44)
                                                  {
                                                    case 2:
                                                      if (key == null)
                                                      {
                                                        num44 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 1 : 1;
                                                        continue;
                                                      }
                                                      goto case 3;
                                                    case 3:
                                                      if (classMetadataList.Contains(key))
                                                      {
                                                        num44 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 0 : 0;
                                                        continue;
                                                      }
                                                      goto case 4;
                                                    case 4:
                                                      classMetadataList.Add(key);
                                                      num44 = 8;
                                                      continue;
                                                    case 5:
                                                      key = current.Key as ClassMetadata;
                                                      num44 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 2 : 0;
                                                      continue;
                                                    case 6:
                                                      goto label_235;
                                                    case 7:
                                                      goto label_187;
                                                    default:
                                                      goto label_238;
                                                  }
                                                }
label_235:
                                                current = enumerator16.Current;
                                                num44 = 5;
                                                goto label_232;
label_239:
                                                num44 = 7;
                                                goto label_232;
                                              }
                                              finally
                                              {
                                                int num45;
                                                if (enumerator16 == null)
                                                  num45 = 2;
                                                else
                                                  goto label_245;
label_244:
                                                switch (num45)
                                                {
                                                  case 1:
                                                  case 2:
                                                }
label_245:
                                                enumerator16.Dispose();
                                                num45 = 0;
                                                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
                                                {
                                                  num45 = 1;
                                                  goto label_244;
                                                }
                                                else
                                                  goto label_244;
                                              }
                                            case 13:
                                              messages.Add(new DeployLogMessage(DeployLogMessageType.Empty, "", false));
                                              num42 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
                                              continue;
                                            case 14:
                                              classMetadataListList.Add(group);
                                              num42 = 19;
                                              continue;
                                            case 15:
                                              enumerator14 = configExport.exportedPacketMetadatas.GetEnumerator();
                                              num42 = 33;
                                              continue;
                                            case 16:
                                              messages.Add(new DeployLogMessage(DeployLogMessageType.Empty, "", false));
                                              num42 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 34 : 10;
                                              continue;
                                            case 17:
label_30:
                                              // ISSUE: reference to a compiler-generated method
                                              ConfigExport.\u003C\u003Ec__DisplayClass32_0.jgfI638T6aONTIIJcK9o((object) writer);
                                              num43 = 30;
                                              break;
                                            case 18:
                                              writer.WriteEndElement();
                                              num42 = 42;
                                              continue;
                                            case 19:
label_187:
                                              // ISSUE: reference to a compiler-generated method
                                              if (ConfigExport.\u003C\u003Ec__DisplayClass32_0.V0eBYp8TJGl31spPlWVy((object) classMetadataList) <= 0)
                                              {
                                                num42 = 31;
                                                continue;
                                              }
                                              goto case 8;
                                            case 20:
                                              // ISSUE: reference to a compiler-generated method
                                              // ISSUE: reference to a compiler-generated method
                                              // ISSUE: reference to a compiler-generated method
                                              ConfigExport.\u003C\u003Ec__DisplayClass32_0.IJx9u28TRx21aJlKk02X((object) ConfigExport.ExportLog, ConfigExport.\u003C\u003Ec__DisplayClass32_0.AxPnN38TwEKwgIf56aG4(ConfigExport.\u003C\u003Ec__DisplayClass32_0.KFRgXN8TiCgmk2BHGWut(--1360331293 ^ 1360063249), (object) configExport.Version));
                                              num42 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 18 : 27;
                                              continue;
                                            case 21:
label_152:
                                              classMetadataListList = new List<List<ClassMetadata>>();
                                              num42 = 46;
                                              continue;
                                            case 22:
                                              // ISSUE: reference to a compiler-generated method
                                              ConfigExport.\u003C\u003Ec__DisplayClass32_0.Y0ojNS8TDDVWJMNdxYh6((object) writer, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218202606));
                                              num42 = 47;
                                              continue;
                                            case 23:
label_185:
                                              // ISSUE: reference to a compiler-generated method
                                              ConfigExport.\u003C\u003Ec__DisplayClass32_0.jgfI638T6aONTIIJcK9o((object) writer);
                                              num42 = 2;
                                              continue;
                                            case 24:
                                              // ISSUE: reference to a compiler-generated method
                                              messages.Add(new DeployLogMessage(DeployLogMessageType.Info, EleWise.ELMA.SR.T((string) ConfigExport.\u003C\u003Ec__DisplayClass32_0.KFRgXN8TiCgmk2BHGWut(-740338220 ^ -740606638), (object) configExport.Protocol, (object) ExportImportVersion.VersionDescription), false));
                                              num42 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 5 : 2;
                                              continue;
                                            case 25:
                                              enumerator16 = configExport.exportedObjects.Where<KeyValuePair<IGroupedMetadata, bool>>((Func<KeyValuePair<IGroupedMetadata, bool>, bool>) (o => o.Value)).GetEnumerator();
                                              num42 = 12;
                                              continue;
                                            case 26:
                                              // ISSUE: reference to a compiler-generated method
                                              ConfigExport.\u003C\u003Ec__DisplayClass32_0.jgfI638T6aONTIIJcK9o((object) writer);
                                              num42 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 24 : 38;
                                              continue;
                                            case 27:
                                              // ISSUE: reference to a compiler-generated method
                                              // ISSUE: reference to a compiler-generated method
                                              ConfigExport.\u003C\u003Ec__DisplayClass32_0.IJx9u28TRx21aJlKk02X((object) ConfigExport.ExportLog, (object) string.Format((string) ConfigExport.\u003C\u003Ec__DisplayClass32_0.KFRgXN8TiCgmk2BHGWut(1669212571 ^ 1668957135), (object) configExport.Build));
                                              num42 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 22 : 17;
                                              continue;
                                            case 28:
                                              writer.WriteAttributeString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(2045296739 + 1688595713 ^ -561331052), configExport.Build);
                                              num42 = 24;
                                              continue;
                                            case 29:
                                              try
                                              {
label_37:
                                                if (enumerator13.MoveNext())
                                                  goto label_35;
                                                else
                                                  goto label_38;
label_33:
                                                ClassMetadata current;
                                                int num46;
                                                while (true)
                                                {
                                                  switch (num46)
                                                  {
                                                    case 1:
                                                      num46 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
                                                      continue;
                                                    case 2:
                                                      goto label_37;
                                                    case 3:
                                                      group.Add(current);
                                                      num46 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 2 : 0;
                                                      continue;
                                                    case 4:
                                                      goto label_35;
                                                    case 5:
                                                      goto label_53;
                                                    default:
                                                      // ISSUE: reference to a compiler-generated method
                                                      IEnumerable<Guid> source3 = MetadataLoader.GetChildClasses(current, false).Select<ClassMetadata, Guid>((Func<ClassMetadata, Guid>) (md => ConfigExport.\u003C\u003Ec.AkjMcB8kKjImnI2VEdAx((object) md)));
                                                      List<ClassMetadata> source4 = classMetadataList;
                                                      // ISSUE: reference to a compiler-generated field
                                                      Func<ClassMetadata, Guid> func = ConfigExport.\u003C\u003Ec.\u003C\u003E9__32_6;
                                                      Func<ClassMetadata, Guid> selector;
                                                      if (func == null)
                                                      {
                                                        // ISSUE: reference to a compiler-generated field
                                                        // ISSUE: reference to a compiler-generated method
                                                        ConfigExport.\u003C\u003Ec.\u003C\u003E9__32_6 = selector = (Func<ClassMetadata, Guid>) (md => ConfigExport.\u003C\u003Ec.AkjMcB8kKjImnI2VEdAx((object) md));
                                                      }
                                                      else
                                                        goto label_305;
label_42:
                                                      IEnumerable<Guid> mdCU2 = source4.Select<ClassMetadata, Guid>(selector);
                                                      Func<Guid, bool> predicate = (Func<Guid, bool>) (u => !mdCU2.Contains<Guid>(u));
                                                      if (source3.All<Guid>(predicate))
                                                      {
                                                        num46 = 3;
                                                        continue;
                                                      }
                                                      goto label_37;
label_305:
                                                      selector = func;
                                                      goto label_42;
                                                  }
                                                }
label_35:
                                                current = enumerator13.Current;
                                                num46 = 1;
                                                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
                                                {
                                                  num46 = 0;
                                                  goto label_33;
                                                }
                                                else
                                                  goto label_33;
label_38:
                                                num46 = 5;
                                                goto label_33;
                                              }
                                              finally
                                              {
                                                enumerator13.Dispose();
                                                int num47 = 0;
                                                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0)
                                                  num47 = 0;
                                                switch (num47)
                                                {
                                                  default:
                                                }
                                              }
                                            case 30:
                                              // ISSUE: reference to a compiler-generated method
                                              // ISSUE: reference to a compiler-generated method
                                              messages.Add(new DeployLogMessage(DeployLogMessageType.Info, (string) ConfigExport.\u003C\u003Ec__DisplayClass32_0.YBoG0Z8TqpBm69r2FfW2(ConfigExport.\u003C\u003Ec__DisplayClass32_0.KFRgXN8TiCgmk2BHGWut(-53329496 >> 4 ^ -3617008)), false));
                                              num42 = 43;
                                              continue;
                                            case 31:
                                              wasExported = new List<ClassMetadata>();
                                              num42 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 1 : 0;
                                              continue;
                                            case 32:
                                              try
                                              {
label_196:
                                                if (enumerator15.MoveNext())
                                                  goto label_200;
                                                else
                                                  goto label_197;
label_192:
                                                PacketEntity current;
                                                List<IEntity>.Enumerator enumerator17;
                                                int num48;
                                                while (true)
                                                {
                                                  switch (num48)
                                                  {
                                                    case 1:
                                                      enumerator17 = current.SubEntities.GetEnumerator();
                                                      num48 = 6;
                                                      continue;
                                                    case 2:
                                                      goto label_196;
                                                    case 3:
label_193:
                                                      // ISSUE: reference to a compiler-generated method
                                                      ConfigExport.\u003C\u003Ec__DisplayClass32_0.jgfI638T6aONTIIJcK9o((object) writer);
                                                      num48 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 8 : 8;
                                                      continue;
                                                    case 4:
                                                      cancellationToken.ThrowIfCancellationRequested();
                                                      num48 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 11 : 12;
                                                      continue;
                                                    case 5:
                                                      goto label_200;
                                                    case 6:
                                                      try
                                                      {
label_204:
                                                        if (enumerator17.MoveNext())
                                                          goto label_209;
                                                        else
                                                          goto label_205;
label_203:
                                                        EntityExportObject entityExportObject;
                                                        int num49;
                                                        while (true)
                                                        {
                                                          switch (num49)
                                                          {
                                                            case 1:
                                                              goto label_209;
                                                            case 2:
                                                              goto label_193;
                                                            case 3:
                                                              configExport.fileUidsD.AddRange((IEnumerable<string>) entityExportObject.FileUids);
                                                              num49 = 4;
                                                              continue;
                                                            case 4:
                                                              goto label_204;
                                                            case 5:
                                                              // ISSUE: reference to a compiler-generated method
                                                              ConfigExport.\u003C\u003Ec__DisplayClass32_0.hb3RbV8TA8BiWmworM46((object) entityExportObject);
                                                              num49 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 0;
                                                              continue;
                                                            default:
                                                              // ISSUE: reference to a compiler-generated method
                                                              messages.Add((DeployLogMessage) ConfigExport.\u003C\u003Ec__DisplayClass32_0.BStCyt8T7lDhpwuB60ub((object) entityExportObject, (object) writer));
                                                              num49 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 3 : 1;
                                                              continue;
                                                          }
                                                        }
label_205:
                                                        num49 = 2;
                                                        goto label_203;
label_209:
                                                        entityExportObject = new EntityExportObject(enumerator17.Current, current.ExportRules);
                                                        num49 = 5;
                                                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0)
                                                        {
                                                          num49 = 3;
                                                          goto label_203;
                                                        }
                                                        else
                                                          goto label_203;
                                                      }
                                                      finally
                                                      {
                                                        enumerator17.Dispose();
                                                        int num50 = 0;
                                                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
                                                          num50 = 0;
                                                        switch (num50)
                                                        {
                                                          default:
                                                        }
                                                      }
                                                    case 7:
                                                      // ISSUE: reference to a compiler-generated method
                                                      // ISSUE: reference to a compiler-generated method
                                                      ConfigExport.\u003C\u003Ec__DisplayClass32_0.rrA7Nj8Tt83f73gfBFey((object) writer, ConfigExport.\u003C\u003Ec__DisplayClass32_0.KFRgXN8TiCgmk2BHGWut(-477139494 ^ -477289050), (object) current.ContentType);
                                                      num48 = 11;
                                                      continue;
                                                    case 8:
                                                      // ISSUE: reference to a compiler-generated method
                                                      // ISSUE: reference to a compiler-generated method
                                                      messages.Add(new DeployLogMessage(DeployLogMessageType.Info, (string) ConfigExport.\u003C\u003Ec__DisplayClass32_0.YBoG0Z8TqpBm69r2FfW2(ConfigExport.\u003C\u003Ec__DisplayClass32_0.KFRgXN8TiCgmk2BHGWut(1925118608 << 2 ^ -889323368)), false));
                                                      num48 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 0 : 0;
                                                      continue;
                                                    case 9:
                                                      // ISSUE: reference to a compiler-generated method
                                                      if (!ConfigExport.\u003C\u003Ec__DisplayClass32_0.HQYOCO8TyC0Oi4PDsnKZ((object) current.ContentType))
                                                      {
                                                        num48 = 7;
                                                        continue;
                                                      }
                                                      goto case 11;
                                                    case 10:
                                                      goto label_152;
                                                    case 11:
                                                      // ISSUE: reference to a compiler-generated method
                                                      configExport.WriteDictionary(writer, current.PacketData, (string) ConfigExport.\u003C\u003Ec__DisplayClass32_0.KFRgXN8TiCgmk2BHGWut(901793403 ^ 902147259));
                                                      num48 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 1 : 0;
                                                      continue;
                                                    case 12:
                                                      // ISSUE: reference to a compiler-generated method
                                                      // ISSUE: reference to a compiler-generated method
                                                      messages.Add(new DeployLogMessage(DeployLogMessageType.Info, (string) ConfigExport.\u003C\u003Ec__DisplayClass32_0.YBoG0Z8TqpBm69r2FfW2(ConfigExport.\u003C\u003Ec__DisplayClass32_0.KFRgXN8TiCgmk2BHGWut(-1380439818 << 3 ^ 1841605924)), false));
                                                      num48 = 14;
                                                      continue;
                                                    case 13:
                                                      // ISSUE: reference to a compiler-generated method
                                                      cancellationToken = ConfigExport.\u003C\u003Ec__DisplayClass32_0.scspod8THPX6VrSQf11n((object) parameters1);
                                                      num48 = 4;
                                                      continue;
                                                    case 14:
                                                      // ISSUE: reference to a compiler-generated method
                                                      ConfigExport.\u003C\u003Ec__DisplayClass32_0.Y0ojNS8TDDVWJMNdxYh6((object) writer, (object) current.NodeName);
                                                      num48 = 9;
                                                      continue;
                                                    default:
                                                      messages.Add(new DeployLogMessage(DeployLogMessageType.Empty, "", false));
                                                      num48 = 2;
                                                      continue;
                                                  }
                                                }
label_197:
                                                num48 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 10 : 0;
                                                goto label_192;
label_200:
                                                current = enumerator15.Current;
                                                num48 = 13;
                                                goto label_192;
                                              }
                                              finally
                                              {
                                                enumerator15.Dispose();
                                                int num51 = 0;
                                                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0)
                                                  num51 = 0;
                                                switch (num51)
                                                {
                                                  default:
                                                }
                                              }
                                            case 33:
                                              try
                                              {
label_103:
                                                if (enumerator14.MoveNext())
                                                  goto label_105;
                                                else
                                                  goto label_104;
label_56:
                                                IEnumerator<KeyValuePair<Guid, SubUserMetadataInfo>> enumerator18;
                                                PacketMetadata current6;
                                                List<IGroupedMetadata>.Enumerator enumerator19;
                                                Dictionary<IEntity, Guid?>.Enumerator enumerator20;
                                                int num52;
                                                while (true)
                                                {
                                                  switch (num52)
                                                  {
                                                    case 1:
label_114:
                                                      // ISSUE: reference to a compiler-generated method
                                                      // ISSUE: reference to a compiler-generated method
                                                      ConfigExport.\u003C\u003Ec__DisplayClass32_0.Y0ojNS8TDDVWJMNdxYh6((object) writer, ConfigExport.\u003C\u003Ec__DisplayClass32_0.KFRgXN8TiCgmk2BHGWut(--1867379187 ^ 1867091429));
                                                      num52 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 6 : 6;
                                                      continue;
                                                    case 2:
                                                      enumerator18 = current6.SubUserMetadataInfo.GetEnumerator();
                                                      num52 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
                                                      continue;
                                                    case 3:
                                                      // ISSUE: reference to a compiler-generated method
                                                      // ISSUE: reference to a compiler-generated method
                                                      messages.Add(new DeployLogMessage(DeployLogMessageType.Info, (string) ConfigExport.\u003C\u003Ec__DisplayClass32_0.YBoG0Z8TqpBm69r2FfW2(ConfigExport.\u003C\u003Ec__DisplayClass32_0.KFRgXN8TiCgmk2BHGWut(-1487388570 ^ -1487033984)), false));
                                                      num52 = 20;
                                                      continue;
                                                    case 4:
                                                      cancellationToken.ThrowIfCancellationRequested();
                                                      num52 = 16;
                                                      continue;
                                                    case 5:
label_108:
                                                      // ISSUE: reference to a compiler-generated method
                                                      ConfigExport.\u003C\u003Ec__DisplayClass32_0.jgfI638T6aONTIIJcK9o((object) writer);
                                                      num52 = 7;
                                                      continue;
                                                    case 6:
                                                      enumerator19 = current6.SubSystemMetadata.GetEnumerator();
                                                      num52 = 18;
                                                      continue;
                                                    case 7:
                                                      // ISSUE: reference to a compiler-generated method
                                                      // ISSUE: reference to a compiler-generated method
                                                      ConfigExport.\u003C\u003Ec__DisplayClass32_0.Y0ojNS8TDDVWJMNdxYh6((object) writer, ConfigExport.\u003C\u003Ec__DisplayClass32_0.KFRgXN8TiCgmk2BHGWut(1917256330 ^ 1917024624));
                                                      num52 = 2;
                                                      continue;
                                                    case 8:
                                                      // ISSUE: reference to a compiler-generated method
                                                      // ISSUE: reference to a compiler-generated method
                                                      writer.WriteAttributeString((string) ConfigExport.\u003C\u003Ec__DisplayClass32_0.KFRgXN8TiCgmk2BHGWut(694673736 ^ -23604109 ^ -672133667), (string) ConfigExport.\u003C\u003Ec__DisplayClass32_0.KFRgXN8TiCgmk2BHGWut(1925118608 << 2 ^ -889496446));
                                                      num52 = 22;
                                                      continue;
                                                    case 9:
                                                      // ISSUE: reference to a compiler-generated method
                                                      cancellationToken = ConfigExport.\u003C\u003Ec__DisplayClass32_0.scspod8THPX6VrSQf11n((object) parameters1);
                                                      num52 = 4;
                                                      continue;
                                                    case 10:
                                                      // ISSUE: reference to a compiler-generated method
                                                      ConfigExport.\u003C\u003Ec__DisplayClass32_0.Y0ojNS8TDDVWJMNdxYh6((object) writer, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(516838154 ^ 516558182));
                                                      num52 = 8;
                                                      continue;
                                                    case 11:
                                                      goto label_105;
                                                    case 12:
                                                      enumerator20 = current6.SubEntitiesAfter.GetEnumerator();
                                                      num52 = 19;
                                                      continue;
                                                    case 13:
label_116:
                                                      // ISSUE: reference to a compiler-generated method
                                                      ConfigExport.\u003C\u003Ec__DisplayClass32_0.jgfI638T6aONTIIJcK9o((object) writer);
                                                      num52 = 12;
                                                      continue;
                                                    case 14:
                                                      try
                                                      {
label_138:
                                                        if (enumerator20.MoveNext())
                                                          goto label_134;
                                                        else
                                                          goto label_139;
label_133:
                                                        KeyValuePair<IEntity, Guid?> current7;
                                                        EntityExportObject entityExportObject;
                                                        int num53;
                                                        while (true)
                                                        {
                                                          switch (num53)
                                                          {
                                                            case 1:
                                                              goto label_114;
                                                            case 2:
                                                              goto label_138;
                                                            case 3:
                                                              // ISSUE: reference to a compiler-generated method
                                                              messages.Add((DeployLogMessage) ConfigExport.\u003C\u003Ec__DisplayClass32_0.BStCyt8T7lDhpwuB60ub((object) entityExportObject, (object) writer));
                                                              num53 = 6;
                                                              continue;
                                                            case 4:
                                                              entityExportObject = new EntityExportObject(current7.Key, current6.ExportRules);
                                                              num53 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 7 : 7;
                                                              continue;
                                                            case 5:
                                                              goto label_134;
                                                            case 6:
                                                              configExport.fileUidsM.AddRange((IEnumerable<string>) entityExportObject.FileUids);
                                                              num53 = 2;
                                                              continue;
                                                            case 7:
                                                              // ISSUE: reference to a compiler-generated method
                                                              ConfigExport.\u003C\u003Ec__DisplayClass32_0.hb3RbV8TA8BiWmworM46((object) entityExportObject);
                                                              num53 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 0 : 0;
                                                              continue;
                                                            default:
                                                              entityExportObject.CustomUid = current7.Value;
                                                              num53 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 3 : 3;
                                                              continue;
                                                          }
                                                        }
label_134:
                                                        current7 = enumerator20.Current;
                                                        num53 = 2;
                                                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0)
                                                        {
                                                          num53 = 4;
                                                          goto label_133;
                                                        }
                                                        else
                                                          goto label_133;
label_139:
                                                        num53 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 1 : 0;
                                                        goto label_133;
                                                      }
                                                      finally
                                                      {
                                                        enumerator20.Dispose();
                                                        int num54 = 0;
                                                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
                                                          num54 = 0;
                                                        switch (num54)
                                                        {
                                                          default:
                                                        }
                                                      }
                                                    case 15:
                                                      goto label_103;
                                                    case 16:
                                                      // ISSUE: reference to a compiler-generated method
                                                      // ISSUE: reference to a compiler-generated method
                                                      messages.Add(new DeployLogMessage(DeployLogMessageType.Info, (string) ConfigExport.\u003C\u003Ec__DisplayClass32_0.YBoG0Z8TqpBm69r2FfW2(ConfigExport.\u003C\u003Ec__DisplayClass32_0.KFRgXN8TiCgmk2BHGWut(-398663332 ^ -398915336)), false));
                                                      num52 = 10;
                                                      continue;
                                                    case 17:
                                                      goto label_185;
                                                    case 18:
                                                      try
                                                      {
label_94:
                                                        if (enumerator19.MoveNext())
                                                          goto label_90;
                                                        else
                                                          goto label_95;
label_86:
                                                        int num55;
                                                        int num56 = num55;
label_87:
                                                        IGroupedMetadata current8;
                                                        while (true)
                                                        {
                                                          MetadataExportObject metadataExportObject;
                                                          switch (num56)
                                                          {
                                                            case 1:
                                                              goto label_108;
                                                            case 2:
                                                              configExport.formExportData.AddRange(metadataExportObject.GetFormExportData());
                                                              num56 = 6;
                                                              continue;
                                                            case 3:
                                                            case 6:
                                                              goto label_94;
                                                            case 4:
                                                              goto label_90;
                                                            case 5:
                                                              if (current8 != null)
                                                                break;
                                                              goto label_92;
                                                            case 7:
                                                              // ISSUE: reference to a compiler-generated method
                                                              messages.Add((DeployLogMessage) ConfigExport.\u003C\u003Ec__DisplayClass32_0.GZNJYh8TxS6syPMcFW4v((object) metadataExportObject, (object) writer));
                                                              num56 = 2;
                                                              continue;
                                                            case 8:
                                                              metadataExportObject.Read();
                                                              num56 = 7;
                                                              continue;
                                                          }
                                                          metadataExportObject = new MetadataExportObject(current8);
                                                          num56 = 8;
                                                        }
label_92:
                                                        num55 = 3;
                                                        goto label_86;
label_90:
                                                        current8 = enumerator19.Current;
                                                        num55 = 5;
                                                        goto label_86;
label_95:
                                                        num56 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 1 : 1;
                                                        goto label_87;
                                                      }
                                                      finally
                                                      {
                                                        enumerator19.Dispose();
                                                        int num57 = 0;
                                                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
                                                          num57 = 0;
                                                        switch (num57)
                                                        {
                                                          default:
                                                        }
                                                      }
                                                    case 19:
                                                      try
                                                      {
label_126:
                                                        if (enumerator20.MoveNext())
                                                          goto label_124;
                                                        else
                                                          goto label_127;
label_118:
                                                        EntityExportObject entityExportObject;
                                                        KeyValuePair<IEntity, Guid?> current9;
                                                        int num58;
                                                        while (true)
                                                        {
                                                          switch (num58)
                                                          {
                                                            case 1:
                                                              entityExportObject.CustomUid = current9.Value;
                                                              num58 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 7 : 7;
                                                              continue;
                                                            case 2:
                                                              goto label_83;
                                                            case 3:
                                                              configExport.fileUidsM.AddRange((IEnumerable<string>) entityExportObject.FileUids);
                                                              num58 = 4;
                                                              continue;
                                                            case 4:
                                                              goto label_126;
                                                            case 5:
                                                              entityExportObject = new EntityExportObject(current9.Key, current6.ExportRules);
                                                              num58 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 0;
                                                              continue;
                                                            case 6:
                                                              goto label_124;
                                                            case 7:
                                                              messages.Add(entityExportObject.Write(writer));
                                                              num58 = 3;
                                                              continue;
                                                            default:
                                                              entityExportObject.Read();
                                                              num58 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 1 : 1;
                                                              continue;
                                                          }
                                                        }
label_124:
                                                        current9 = enumerator20.Current;
                                                        num58 = 4;
                                                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
                                                        {
                                                          num58 = 5;
                                                          goto label_118;
                                                        }
                                                        else
                                                          goto label_118;
label_127:
                                                        num58 = 2;
                                                        goto label_118;
                                                      }
                                                      finally
                                                      {
                                                        enumerator20.Dispose();
                                                        int num59 = 0;
                                                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
                                                          num59 = 0;
                                                        switch (num59)
                                                        {
                                                          default:
                                                        }
                                                      }
                                                    case 20:
                                                      messages.Add(new DeployLogMessage(DeployLogMessageType.Empty, "", false));
                                                      num52 = 15;
                                                      continue;
                                                    case 21:
label_83:
                                                      // ISSUE: reference to a compiler-generated method
                                                      ConfigExport.\u003C\u003Ec__DisplayClass32_0.jgfI638T6aONTIIJcK9o((object) writer);
                                                      num52 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 3 : 3;
                                                      continue;
                                                    case 22:
                                                      enumerator20 = current6.SubEntitiesBefore.GetEnumerator();
                                                      num52 = 14;
                                                      continue;
                                                    default:
                                                      try
                                                      {
label_67:
                                                        if (enumerator18.MoveNext())
                                                          goto label_62;
                                                        else
                                                          goto label_68;
label_61:
                                                        KeyValuePair<Guid, SubUserMetadataInfo> current10;
                                                        int num60;
                                                        while (true)
                                                        {
                                                          MetadataExportObject metadataExportObject;
                                                          IMetadata metadata;
                                                          switch (num60)
                                                          {
                                                            case 1:
                                                              goto label_62;
                                                            case 2:
                                                              goto label_116;
                                                            case 3:
                                                              SubUserMetadataInfo userMetadataInfo = current10.Value;
                                                              if (userMetadataInfo == null)
                                                              {
                                                                num60 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 5;
                                                                continue;
                                                              }
                                                              metadata = userMetadataInfo.Metadata;
                                                              break;
                                                            case 5:
                                                              metadata = (IMetadata) null;
                                                              break;
                                                            case 6:
label_69:
                                                              // ISSUE: reference to a compiler-generated method
                                                              metadataExportObject = new MetadataExportObject((IMetadata) ConfigExport.\u003C\u003Ec__DisplayClass32_0.oj1b3U8T03MtIRoWcIae((object) current10.Value));
                                                              num60 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 7 : 1;
                                                              continue;
                                                            case 7:
                                                              // ISSUE: reference to a compiler-generated method
                                                              ConfigExport.\u003C\u003Ec__DisplayClass32_0.jgq1nJ8Tmc1mHKnRDw69((object) metadataExportObject);
                                                              num60 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 4 : 8;
                                                              continue;
                                                            case 8:
                                                              metadataExportObject.ScriptModules = current10.Value.ScriptModules;
                                                              num60 = 9;
                                                              continue;
                                                            case 9:
                                                              // ISSUE: reference to a compiler-generated method
                                                              messages.Add((DeployLogMessage) ConfigExport.\u003C\u003Ec__DisplayClass32_0.GZNJYh8TxS6syPMcFW4v((object) metadataExportObject, (object) writer));
                                                              num60 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 4 : 10;
                                                              continue;
                                                            case 10:
                                                              configExport.formExportData.AddRange(metadataExportObject.GetFormExportData());
                                                              num60 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
                                                              continue;
                                                            default:
                                                              goto label_67;
                                                          }
                                                          if (metadata == null)
                                                            num60 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 4 : 3;
                                                          else
                                                            goto label_69;
                                                        }
label_62:
                                                        current10 = enumerator18.Current;
                                                        num60 = 3;
                                                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
                                                        {
                                                          num60 = 2;
                                                          goto label_61;
                                                        }
                                                        else
                                                          goto label_61;
label_68:
                                                        num60 = 2;
                                                        goto label_61;
                                                      }
                                                      finally
                                                      {
                                                        int num61;
                                                        if (enumerator18 == null)
                                                          num61 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 2 : 1;
                                                        else
                                                          goto label_80;
label_79:
                                                        switch (num61)
                                                        {
                                                          case 1:
                                                          case 2:
                                                        }
label_80:
                                                        enumerator18.Dispose();
                                                        num61 = 1;
                                                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
                                                        {
                                                          num61 = 0;
                                                          goto label_79;
                                                        }
                                                        else
                                                          goto label_79;
                                                      }
                                                  }
                                                }
label_104:
                                                num52 = 17;
                                                goto label_56;
label_105:
                                                current6 = enumerator14.Current;
                                                num52 = 9;
                                                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
                                                {
                                                  num52 = 9;
                                                  goto label_56;
                                                }
                                                else
                                                  goto label_56;
                                              }
                                              finally
                                              {
                                                enumerator14.Dispose();
                                                int num62 = 0;
                                                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
                                                  num62 = 0;
                                                switch (num62)
                                                {
                                                  default:
                                                }
                                              }
                                            case 34:
                                              // ISSUE: reference to a compiler-generated method
                                              ConfigExport.\u003C\u003Ec__DisplayClass32_0.Y0ojNS8TDDVWJMNdxYh6((object) writer, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97682548));
                                              num42 = 15;
                                              continue;
                                            case 35:
                                              messages.Add(new DeployLogMessage(DeployLogMessageType.Empty, "", false));
                                              num42 = 39;
                                              continue;
                                            case 36:
                                              messages.Add(new DeployLogMessage(DeployLogMessageType.Empty, "", false));
                                              num42 = 41;
                                              continue;
                                            case 37:
                                              try
                                              {
label_163:
                                                if (enumerator12.MoveNext())
                                                  goto label_161;
                                                else
                                                  goto label_164;
label_160:
                                                int num63;
                                                switch (num63)
                                                {
                                                  case 1:
                                                    goto label_163;
                                                  case 2:
                                                    try
                                                    {
label_172:
                                                      if (enumerator13.MoveNext())
                                                        goto label_168;
                                                      else
                                                        goto label_173;
label_167:
                                                      int num64;
                                                      while (true)
                                                      {
                                                        int num65;
                                                        IExportDataExtension exportDataExtension;
                                                        ClassMetadata mdC;
                                                        switch (num64)
                                                        {
                                                          case 1:
                                                          case 4:
                                                            goto label_172;
                                                          case 2:
                                                            if (exportDataExtension == null)
                                                            {
                                                              num64 = 4;
                                                              continue;
                                                            }
                                                            goto case 3;
                                                          case 3:
                                                            wasExported = exportDataExtension.ExportObjects(writer, mdC, messages, wasExported, configExport.fileUidsD);
                                                            num64 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 1;
                                                            continue;
                                                          case 5:
                                                            // ISSUE: reference to a compiler-generated method
                                                            exportDataExtension = configExport.exportDataExtension.FirstOrDefault<IExportDataExtension>((Func<IExportDataExtension, bool>) (a => ConfigExport.\u003C\u003Ec__DisplayClass32_3.Qq1DBm8kVHFnsfFf6STh((object) a, (object) mdC)));
                                                            num65 = 2;
                                                            break;
                                                          case 6:
                                                            mdC = enumerator13.Current;
                                                            num65 = 5;
                                                            break;
                                                          case 7:
                                                            goto label_163;
                                                          default:
                                                            goto label_168;
                                                        }
                                                        num64 = num65;
                                                      }
label_168:
                                                      num64 = 0;
                                                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
                                                      {
                                                        num64 = 6;
                                                        goto label_167;
                                                      }
                                                      else
                                                        goto label_167;
label_173:
                                                      num64 = 7;
                                                      goto label_167;
                                                    }
                                                    finally
                                                    {
                                                      enumerator13.Dispose();
                                                      int num66 = 0;
                                                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
                                                        num66 = 0;
                                                      switch (num66)
                                                      {
                                                        default:
                                                      }
                                                    }
                                                  case 3:
                                                    goto label_30;
                                                }
label_161:
                                                enumerator13 = enumerator12.Current.GetEnumerator();
                                                num63 = 2;
                                                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
                                                {
                                                  num63 = 2;
                                                  goto label_160;
                                                }
                                                else
                                                  goto label_160;
label_164:
                                                num63 = 3;
                                                goto label_160;
                                              }
                                              finally
                                              {
                                                enumerator12.Dispose();
                                                int num67 = 0;
                                                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
                                                  num67 = 0;
                                                switch (num67)
                                                {
                                                  default:
                                                }
                                              }
                                            case 38:
                                            case 40:
                                              configExport.WriteServiceData(writer);
                                              num42 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 9 : 4;
                                              continue;
                                            case 39:
                                              // ISSUE: reference to a compiler-generated method
                                              messages.Add(new DeployLogMessage(DeployLogMessageType.Info, EleWise.ELMA.SR.T((string) ConfigExport.\u003C\u003Ec__DisplayClass32_0.KFRgXN8TiCgmk2BHGWut(381945751 ^ 1158627804 ^ 1406054203)), false));
                                              num42 = 16;
                                              continue;
                                            case 41:
                                              // ISSUE: reference to a compiler-generated method
                                              messages.Add(new DeployLogMessage(DeployLogMessageType.Info, EleWise.ELMA.SR.T((string) ConfigExport.\u003C\u003Ec__DisplayClass32_0.KFRgXN8TiCgmk2BHGWut(381945751 ^ 1158627804 ^ 1406053411)), false));
                                              num42 = 13;
                                              continue;
                                            case 42:
                                              goto label_295;
                                            case 43:
                                              // ISSUE: reference to a compiler-generated method
                                              ConfigExport.\u003C\u003Ec__DisplayClass32_0.jgfI638T6aONTIIJcK9o((object) writer);
                                              num43 = 18;
                                              break;
                                            case 44:
                                              // ISSUE: reference to a compiler-generated method
                                              // ISSUE: reference to a compiler-generated method
                                              messages.Add(new DeployLogMessage(DeployLogMessageType.Info, (string) ConfigExport.\u003C\u003Ec__DisplayClass32_0.YBoG0Z8TqpBm69r2FfW2(ConfigExport.\u003C\u003Ec__DisplayClass32_0.KFRgXN8TiCgmk2BHGWut(-2138958856 ^ -2138572102)), false));
                                              num42 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 35 : 24;
                                              continue;
                                            case 45:
                                              writer.WriteStartElement(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -811789466));
                                              num42 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 3 : 11;
                                              continue;
                                            case 46:
                                              classMetadataList = new List<ClassMetadata>();
                                              num42 = 25;
                                              continue;
                                            case 47:
                                              // ISSUE: reference to a compiler-generated method
                                              // ISSUE: reference to a compiler-generated method
                                              if (!ConfigExport.\u003C\u003Ec__DisplayClass32_0.ykveO98T4X0RauipuZWS((object) configExport.Protocol, ConfigExport.\u003C\u003Ec__DisplayClass32_0.KFRgXN8TiCgmk2BHGWut(1051276242 - 990076387 ^ 60918537)))
                                              {
                                                num43 = 40;
                                                break;
                                              }
                                              goto case 45;
                                            default:
                                              // ISSUE: reference to a compiler-generated method
                                              ConfigExport.\u003C\u003Ec__DisplayClass32_0.Y0ojNS8TDDVWJMNdxYh6((object) writer, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487344402));
                                              num42 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 1 : 7;
                                              continue;
                                          }
                                          num42 = num43;
                                        }
                                      }
                                      finally
                                      {
                                        int num68;
                                        if (writer == null)
                                          num68 = 2;
                                        else
                                          goto label_257;
label_256:
                                        switch (num68)
                                        {
                                          case 1:
                                            break;
                                          default:
                                        }
label_257:
                                        // ISSUE: reference to a compiler-generated method
                                        ConfigExport.\u003C\u003Ec__DisplayClass32_0.GBuYLM8T93NyrkdrLc2T((object) writer);
                                        num68 = 0;
                                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
                                        {
                                          num68 = 0;
                                          goto label_256;
                                        }
                                        else
                                          goto label_256;
                                      }
                                    default:
                                      // ISSUE: reference to a compiler-generated method
                                      // ISSUE: reference to a compiler-generated method
                                      messages.Add(new DeployLogMessage(DeployLogMessageType.Info, (string) ConfigExport.\u003C\u003Ec__DisplayClass32_0.YBoG0Z8TqpBm69r2FfW2(ConfigExport.\u003C\u003Ec__DisplayClass32_0.KFRgXN8TiCgmk2BHGWut(1461825605 - 1531863589 ^ -69818900)), true));
                                      num39 = 25;
                                      continue;
                                  }
                                }
label_11:
                                // ISSUE: reference to a compiler-generated method
                                // ISSUE: reference to a compiler-generated method
                                // ISSUE: reference to a compiler-generated method
                                configFile = (string) ConfigExport.\u003C\u003Ec__DisplayClass32_0.XsioCb8TkNnrDBZGQYg9((object) configExport.exportImportFileService, (object) str7, ConfigExport.\u003C\u003Ec__DisplayClass32_0.KFRgXN8TiCgmk2BHGWut(-488881205 ^ -488774541), ConfigExport.\u003C\u003Ec__DisplayClass32_0.KFRgXN8TiCgmk2BHGWut(-97972138 ^ -97685420));
                                num38 = 11;
                                continue;
label_260:
                                enumerator11 = configExport.manifestChapterCreators.GetEnumerator();
                                num38 = 8;
                                continue;
label_276:
                                IUser user3;
                                configExport.authenticationService.SetAuthenticatedUserForRequest(user3);
                                num38 = 32;
                                continue;
label_294:
                                // ISSUE: reference to a compiler-generated method
                                user3 = configExport.membershipService.GetUser((object) ConfigExport.\u003C\u003Ec__DisplayClass32_0.mPpDWW8TKK8FgF4mOVNR((object) parameters1));
                                num38 = 17;
                                continue;
label_297:
                                num38 = 2;
                              }
label_303:;
                            }));
                            num37 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
                            continue;
                          default:
                            goto label_4;
                        }
                      }
label_2:
                      return;
label_4:;
                    }));
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 2 : 3;
                    continue;
                  case 2:
                    goto label_14;
                  case 3:
                    goto label_29;
                  default:
                    goto label_15;
                }
              }
label_29:
              break;
label_15:
              object obj1 = ConfigExport.FyIjNAEPk8Gc0ZhhLviP((object) this.securityDeployHelperExtensions.First<ISecurityDeployHelperExtension>(), parameters1.SignedUserId);
              goto label_16;
label_14:
              obj1 = (object) null;
label_16:
              user1 = (IUser) obj1;
              num3 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0)
              {
                num3 = 1;
                goto label_12;
              }
              else
                goto label_12;
            }
            finally
            {
              int num69;
              if (contextSessionOwner == null)
                num69 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 0;
              else
                goto label_22;
label_20:
              switch (num69)
              {
                case 1:
                  break;
                default:
              }
label_22:
              ConfigExport.amyCuPEPONea2Y3rgLkk((object) contextSessionOwner);
              num69 = 2;
              goto label_20;
            }
        }
      }
      catch (OperationCanceledException ex)
      {
        int num70 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
          num70 = 1;
        while (true)
        {
          switch (num70)
          {
            case 0:
              goto label_25;
            case 1:
              messages.Add(new DeployLogMessage(DeployLogMessageType.Error, (string) ConfigExport.JmSPtCEP2AFdjU8Jqdnc(ConfigExport.AG4Q6BEPqE5aLValmTMo(-138018305 ^ -138256645)), true));
              num70 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 0 : 0;
              continue;
            default:
              goto label_23;
          }
        }
label_25:
        return;
label_23:;
      }
      catch (Exception ex)
      {
        int num71 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
          num71 = 0;
        while (true)
        {
          switch (num71)
          {
            case 1:
              messages.Add(new DeployLogMessage(DeployLogMessageType.Empty, "", false));
              num71 = 2;
              continue;
            case 2:
              messages.Add(new DeployLogMessage(DeployLogMessageType.Error, EleWise.ELMA.SR.T((string) ConfigExport.AG4Q6BEPqE5aLValmTMo(~538519529 ^ -538802384), ConfigExport.FgfQoeEPePex3xR0tvkT((object) ex)), true));
              num71 = 3;
              continue;
            case 3:
              goto label_21;
            default:
              ConfigExport.ExportLog.Error(ConfigExport.FgfQoeEPePex3xR0tvkT((object) ex), ex);
              num71 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 1 : 0;
              continue;
          }
        }
label_21:;
      }
    }

    /// <summary>Заполнение списков экспорта</summary>
    private void FillExportedObjects(List<DeployLogMessage> messages)
    {
      this.fileUidsM = new List<string>();
      this.fileUidsD = new List<string>();
      this.exportedPacketEntities = new List<PacketEntity>();
      this.exportedPacketMetadatas = new List<PacketMetadata>();
      this.importants = (ISet<Guid>) new HashSet<Guid>();
      this.exportServiceData = new Dictionary<string, object>();
      this.exportedObjects = new Dictionary<IGroupedMetadata, bool>();
      this.exportedPackages = new List<PackageDescription>();
      this.formExportData = new List<FormExportData>();
      this.writeComponentFileActions = new List<Action<IExportImportFileService, string>>();
      ExportExtensionParams parameters = new ExportExtensionParams(this.exportSettings.CustomSettings, this.exportedObjects, this.importants, this.exportServiceData, this.exportedPacketEntities, this.exportedPacketMetadatas, this.exportedPackages, this.formExportData, this.writeComponentFileActions, messages, this.exportSettings.Manifest);
      foreach (IConfigExportExtension configExportExtension in this.configExportExtensions)
        configExportExtension.AddExportObjects(parameters);
    }

    /// <summary>Запись блока Importants</summary>
    /// <param name="writer"></param>
    private void WriteImportants(XmlWriter writer)
    {
      int num1 = 1;
      IEnumerator<IImportantData> enumerator1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            ConfigExport.WYv0WjEPPi09LpaLe4pq((object) writer, ConfigExport.AG4Q6BEPqE5aLValmTMo(-477139494 ^ -477416794));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 0;
            continue;
          case 2:
label_36:
            writer.WriteEndElement();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 3 : 0;
            continue;
          case 3:
            goto label_32;
          case 4:
            try
            {
label_13:
              if (ConfigExport.O6tRLhEPpgfxm2eto07C((object) enumerator1))
                goto label_6;
              else
                goto label_14;
label_5:
              IImportantData current1;
              int num2;
              while (true)
              {
                IEnumerator<System.Version> enumerator2;
                switch (num2)
                {
                  case 1:
                    try
                    {
label_18:
                      if (ConfigExport.O6tRLhEPpgfxm2eto07C((object) enumerator2))
                        goto label_21;
                      else
                        goto label_19;
label_17:
                      System.Version current2;
                      int num3;
                      while (true)
                      {
                        switch (num3)
                        {
                          case 1:
                            goto label_21;
                          case 2:
                            goto label_7;
                          case 3:
                            writer.WriteElementString((string) ConfigExport.AG4Q6BEPqE5aLValmTMo(-1939377524 ^ -1939344392), current2.ToString());
                            num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
                            continue;
                          default:
                            goto label_18;
                        }
                      }
label_19:
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 2 : 2;
                      goto label_17;
label_21:
                      current2 = enumerator2.Current;
                      num3 = 3;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
                      {
                        num3 = 3;
                        goto label_17;
                      }
                      else
                        goto label_17;
                    }
                    finally
                    {
                      if (enumerator2 != null)
                      {
                        int num4 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
                          num4 = 0;
                        while (true)
                        {
                          switch (num4)
                          {
                            case 1:
                              goto label_28;
                            default:
                              ConfigExport.amyCuPEPONea2Y3rgLkk((object) enumerator2);
                              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 1 : 1;
                              continue;
                          }
                        }
                      }
label_28:;
                    }
                  case 2:
                    if (ConfigExport.zZ7rO4EPN7a0SVuA9Poe((object) current1.Module))
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 2 : 3;
                      continue;
                    }
                    break;
                  case 3:
                  case 10:
                    enumerator2 = current1.Versions.GetEnumerator();
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 1 : 0;
                    continue;
                  case 4:
                    goto label_6;
                  case 5:
                    ConfigExport.VhdgEREP1R7gVwF6UdK7((object) writer, ConfigExport.AG4Q6BEPqE5aLValmTMo(2008901894 << 3 ^ -1108702234), (object) current1.Uid.ToString());
                    num2 = 2;
                    continue;
                  case 6:
label_7:
                    ConfigExport.XT0ubCEPa5LP6YLPfYsE((object) writer);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 4 : 9;
                    continue;
                  case 7:
                    ConfigExport.WYv0WjEPPi09LpaLe4pq((object) writer, ConfigExport.AG4Q6BEPqE5aLValmTMo(-1710575414 ^ -1710297250));
                    num2 = 5;
                    continue;
                  case 8:
                    goto label_36;
                  case 9:
                    goto label_13;
                }
                ConfigExport.VhdgEREP1R7gVwF6UdK7((object) writer, ConfigExport.AG4Q6BEPqE5aLValmTMo(-1426456882 ^ 2009939514 ^ -583667668), ConfigExport.iQnLl8EP3DHhdsnkdph2((object) current1));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 10 : 5;
              }
label_6:
              current1 = enumerator1.Current;
              num2 = 7;
              goto label_5;
label_14:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 8 : 8;
              goto label_5;
            }
            finally
            {
              int num5;
              if (enumerator1 == null)
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 0;
              else
                goto label_33;
label_31:
              switch (num5)
              {
                case 1:
                  break;
                default:
              }
label_33:
              enumerator1.Dispose();
              num5 = 2;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
              {
                num5 = 2;
                goto label_31;
              }
              else
                goto label_31;
            }
          default:
            enumerator1 = ((ComponentManager) ConfigExport.l6cGbPEPXXLEvRQqcrsc()).GetExtensionPoints<IImportantData>().Where<IImportantData>((Func<IImportantData, bool>) (d => this.importants.Contains(d.Uid))).GetEnumerator();
            num1 = 4;
            continue;
        }
      }
label_32:;
    }

    /// <summary>Запись блока ServiceData</summary>
    /// <param name="writer"></param>
    private void WriteServiceData(XmlWriter writer)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.WriteDictionary(writer, (IDictionary<string, object>) this.exportServiceData, (string) ConfigExport.AG4Q6BEPqE5aLValmTMo(~-397266137 ^ 396989298));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Запись произвольного словаря</summary>
    /// <param name="writer"></param>
    /// <param name="dictionary"></param>
    /// <param name="name"></param>
    private void WriteDictionary(
      XmlWriter writer,
      IDictionary<string, object> dictionary,
      string name)
    {
      writer.WriteStartElement(name);
      foreach (KeyValuePair<string, object> keyValuePair in (IEnumerable<KeyValuePair<string, object>>) dictionary)
        writer.WriteElementString(keyValuePair.Key, keyValuePair.Value.ToString());
      writer.WriteEndElement();
    }

    /// <summary>Запись хэша файла конфигурации</summary>
    private void WriteHash(string configFile)
    {
      switch (1)
      {
        case 1:
          try
          {
            if (!File.Exists(configFile))
              break;
            int num1 = 1;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
              num1 = 1;
            StreamWriter text;
            string str;
            while (true)
            {
              int num2;
              FileStream inputStream;
              string id;
              switch (num1)
              {
                case 0:
                  goto label_42;
                case 1:
                  inputStream = (FileStream) ConfigExport.KRjpH6EPDQlNyjDjiLPn((object) configFile);
                  num2 = 3;
                  break;
                case 2:
label_8:
                  if (!ConfigExport.zZ7rO4EPN7a0SVuA9Poe((object) str))
                  {
                    num1 = 4;
                    continue;
                  }
                  goto label_37;
                case 3:
                  try
                  {
                    SHA1CryptoServiceProvider cryptoServiceProvider = new SHA1CryptoServiceProvider();
                    int num3 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0)
                      num3 = 0;
                    switch (num3)
                    {
                      case 1:
                        goto label_8;
                      default:
                        try
                        {
                          str = (string) ConfigExport.R6aP6iEPw6rtOhJ5e3jA(ConfigExport.WbKuXyEPtFnM8NoetdEm((object) cryptoServiceProvider.ComputeHash((Stream) inputStream)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(222162814 ^ 222159122), (object) string.Empty);
                          int num4 = 0;
                          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
                            num4 = 0;
                          switch (num4)
                          {
                            default:
                              goto label_8;
                          }
                        }
                        finally
                        {
                          if (cryptoServiceProvider != null)
                          {
                            int num5 = 0;
                            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
                              num5 = 0;
                            while (true)
                            {
                              switch (num5)
                              {
                                case 1:
                                  goto label_23;
                                default:
                                  ConfigExport.amyCuPEPONea2Y3rgLkk((object) cryptoServiceProvider);
                                  num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 1 : 1;
                                  continue;
                              }
                            }
                          }
label_23:;
                        }
                    }
                  }
                  finally
                  {
                    int num6;
                    if (inputStream == null)
                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 0 : 0;
                    else
                      goto label_29;
label_27:
                    switch (num6)
                    {
                      case 1:
                        break;
                      default:
                    }
label_29:
                    ConfigExport.amyCuPEPONea2Y3rgLkk((object) inputStream);
                    num6 = 2;
                    goto label_27;
                  }
                case 4:
                  id = (string) ConfigExport.MBjDuSEP4KiAbh3OsRot((object) this.exportSettings);
                  num2 = 5;
                  break;
                case 5:
                  text = File.CreateText(this.exportImportFileService.CreateFileName(id, (string) ConfigExport.AG4Q6BEPqE5aLValmTMo(-53329496 >> 4 ^ -3374174), (string) ConfigExport.AG4Q6BEPqE5aLValmTMo(-951514650 ^ -951232990)));
                  num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 6 : 5;
                  continue;
                case 6:
                  goto label_33;
                default:
                  goto label_36;
              }
              num1 = num2;
            }
label_42:
            break;
label_36:
            break;
label_37:
            break;
label_33:
            try
            {
              ConfigExport.vQ58LXEP6SBO7Mje660k((object) text, (object) str);
              int num7 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
                num7 = 0;
              switch (num7)
              {
                case 0:
                  return;
                default:
                  return;
              }
            }
            finally
            {
              if (text != null)
              {
                int num8 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
                  num8 = 0;
                while (true)
                {
                  switch (num8)
                  {
                    case 1:
                      goto label_44;
                    default:
                      ConfigExport.amyCuPEPONea2Y3rgLkk((object) text);
                      num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 1 : 1;
                      continue;
                  }
                }
              }
label_44:;
            }
          }
          catch (Exception ex)
          {
            int num = 1;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
              num = 1;
            while (true)
            {
              switch (num)
              {
                case 0:
                  goto label_24;
                case 1:
                  ConfigExport.nG9Tw3EPHSYppZ0yEvQc((object) ConfigExport.ExportLog, ConfigExport.AG4Q6BEPqE5aLValmTMo(1925118608 << 2 ^ -889211506), (object) ex);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 0 : 0;
                  continue;
                default:
                  goto label_21;
              }
            }
label_24:
            break;
label_21:
            break;
          }
      }
    }

    /// <summary>Запись экспортируемых файлов</summary>
    private void WriteFiles(string id, string folderPath)
    {
      int num1 = 2;
      string path;
      Dictionary<Guid, long> dictionary;
      XmlWriter xmlWriter1;
      while (true)
      {
        int num2 = num1;
        List<string>.Enumerator enumerator1;
        Guid result1;
        string str1;
        while (true)
        {
          IEnumerator<KeyValuePair<string, object>> enumerator2;
          switch (num2)
          {
            case 1:
              try
              {
label_62:
                if (ConfigExport.O6tRLhEPpgfxm2eto07C((object) enumerator2))
                  goto label_50;
                else
                  goto label_63;
label_44:
                KeyValuePair<string, object> current;
                int num3;
                while (true)
                {
                  string[] source;
                  long result2;
                  Guid result3;
                  switch (num3)
                  {
                    case 1:
                      if (((IEnumerable<string>) source).Count<string>() == 3)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 7 : 5;
                        continue;
                      }
                      goto label_62;
                    case 2:
                      this.fileUidsM.Add(source[1]);
                      num3 = 16;
                      continue;
                    case 3:
                      if (!long.TryParse(current.Value.ToString(), out result2))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 20 : 20;
                        continue;
                      }
                      goto case 6;
                    case 4:
                      goto label_50;
                    case 5:
                    case 10:
                    case 11:
                    case 12:
                    case 14:
                    case 16:
                    case 19:
                    case 20:
                      goto label_62;
                    case 6:
                      if (result2 != 1L)
                      {
                        num3 = 22;
                        continue;
                      }
                      break;
                    case 7:
                      if (!Guid.TryParse(source[1], out result3))
                      {
                        num3 = 10;
                        continue;
                      }
                      goto case 15;
                    case 8:
                      if (this.fileUidsD.Contains(source[1]))
                      {
                        num3 = 19;
                        continue;
                      }
                      goto case 21;
                    case 9:
                      source = (string[]) ConfigExport.K2AyhHEPAr2kTTZlNqlC((object) current.Key, (object) new char[1]
                      {
                        '_'
                      });
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 13 : 10;
                      continue;
                    case 13:
                      if (source != null)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 1;
                        continue;
                      }
                      goto label_62;
                    case 15:
                      if (!ConfigExport.ehjakIEP7FpjBWxThaX2(result3, Guid.Empty))
                      {
                        num3 = 14;
                        continue;
                      }
                      goto case 3;
                    case 17:
                      if (current.Value == null)
                      {
                        num3 = 5;
                        continue;
                      }
                      goto case 9;
                    case 18:
                      goto label_80;
                    case 21:
                      this.fileUidsD.Add(source[1]);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 11 : 11;
                      continue;
                    case 22:
                      if (result2 != 2L)
                      {
                        num3 = 12;
                        continue;
                      }
                      goto case 8;
                  }
                  if (!this.fileUidsM.Contains(source[1]))
                    num3 = 2;
                  else
                    goto label_62;
                }
label_50:
                current = enumerator2.Current;
                num3 = 17;
                goto label_44;
label_63:
                num3 = 18;
                goto label_44;
              }
              finally
              {
                int num4;
                if (enumerator2 == null)
                  num4 = 2;
                else
                  goto label_74;
label_73:
                switch (num4)
                {
                  case 1:
                  case 2:
                }
label_74:
                ConfigExport.amyCuPEPONea2Y3rgLkk((object) enumerator2);
                num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0)
                {
                  num4 = 1;
                  goto label_73;
                }
                else
                  goto label_73;
              }
            case 2:
              enumerator2 = this.exportServiceData.Where<KeyValuePair<string, object>>((Func<KeyValuePair<string, object>, bool>) (sd => sd.Key.StartsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487033220)))).GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 1;
              continue;
            case 3:
              goto label_125;
            case 4:
              goto label_26;
            case 5:
              goto label_81;
            case 6:
              goto label_124;
            case 7:
              goto label_77;
            case 8:
              enumerator1 = this.fileUidsD.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 4 : 1;
              continue;
            case 9:
              if (string.IsNullOrWhiteSpace(path))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 10 : 13;
                continue;
              }
              goto case 19;
            case 10:
              goto label_120;
            case 11:
              goto label_82;
            case 12:
              goto label_130;
            case 13:
              goto label_116;
            case 14:
label_80:
              dictionary = new Dictionary<Guid, long>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 8 : 7;
              continue;
            case 15:
              try
              {
label_17:
                if (enumerator1.MoveNext())
                  goto label_13;
                else
                  goto label_18;
label_9:
                int num5;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                    case 5:
                    case 8:
                      goto label_17;
                    case 2:
                      dictionary.Add(result1, 1L);
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 5 : 8;
                      continue;
                    case 3:
                      dictionary[result1] = 1L;
                      num5 = 5;
                      continue;
                    case 4:
                      goto label_13;
                    case 6:
                      if (dictionary[result1] == 2L)
                      {
                        num5 = 3;
                        continue;
                      }
                      goto label_17;
                    case 7:
                      if (!(result1 != Guid.Empty))
                      {
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 1 : 1;
                        continue;
                      }
                      goto case 9;
                    case 9:
                      if (!dictionary.ContainsKey(result1))
                      {
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 2 : 2;
                        continue;
                      }
                      goto case 6;
                    default:
                      goto label_78;
                  }
                }
label_13:
                if (Guid.TryParse(enumerator1.Current, out result1))
                {
                  num5 = 7;
                  goto label_9;
                }
                else
                  goto label_17;
label_18:
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 0;
                goto label_9;
              }
              finally
              {
                enumerator1.Dispose();
                int num6 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
                  num6 = 0;
                switch (num6)
                {
                  default:
                }
              }
            case 16:
              Directory.CreateDirectory(path);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 9 : 9;
              continue;
            case 17:
              if (ConfigExport.WBRT5kEPmZFHWdHavVcR((object) path))
                goto case 9;
              else
                goto label_7;
            case 18:
label_78:
              if (dictionary.Count <= 0)
              {
                num2 = 10;
                continue;
              }
              break;
            case 19:
              if (!ConfigExport.WBRT5kEPmZFHWdHavVcR((object) path))
              {
                num2 = 6;
                continue;
              }
              goto label_77;
          }
          str1 = (string) ConfigExport.EDtyRYEPx1wpv4ZsPOwN((object) this.exportImportFileService, (object) id, ConfigExport.AG4Q6BEPqE5aLValmTMo(-542721635 ^ -542972311), ConfigExport.AG4Q6BEPqE5aLValmTMo(2045296739 + 1688595713 ^ -561328794));
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 5 : 5;
        }
label_7:
        num1 = 16;
        continue;
label_26:
        try
        {
label_35:
          if (enumerator1.MoveNext())
            goto label_31;
          else
            goto label_36;
label_27:
          int num7;
          while (true)
          {
            switch (num7)
            {
              case 1:
                goto label_130;
              case 2:
                dictionary.Add(result1, 2L);
                num7 = 5;
                continue;
              case 3:
                if (!dictionary.ContainsKey(result1))
                {
                  num7 = 2;
                  continue;
                }
                goto label_35;
              case 4:
              case 5:
                goto label_35;
              case 6:
                goto label_33;
              default:
                goto label_31;
            }
          }
label_31:
          if (!Guid.TryParse(enumerator1.Current, out result1))
          {
            num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 4 : 4;
            goto label_27;
          }
label_33:
          if (ConfigExport.ehjakIEP7FpjBWxThaX2(result1, Guid.Empty))
          {
            num7 = 3;
            goto label_27;
          }
          else
            goto label_35;
label_36:
          num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 1 : 1;
          goto label_27;
        }
        finally
        {
          enumerator1.Dispose();
          int num8 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
            num8 = 0;
          switch (num8)
          {
            default:
          }
        }
label_77:
        string str2 = str1;
        XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
        ConfigExport.YR860UEPyXhs1IBuERcn((object) xmlWriterSettings, (object) Encoding.UTF8);
        ConfigExport.IwJBHHEPM6cHbWhGrt0U((object) xmlWriterSettings, true);
        ConfigExport.SbBJHwEPJ9HHBls1K8DA((object) xmlWriterSettings, true);
        ConfigExport.PlRO3xEP9KFY0jW5MuCk((object) xmlWriterSettings, ConformanceLevel.Fragment);
        xmlWriter1 = (XmlWriter) ConfigExport.UHLMCgEPdadJW7Vr9MJ6((object) str2, (object) xmlWriterSettings);
        num1 = 11;
        continue;
label_81:
        path = (string) ConfigExport.m8N5feEP0SyMkkApBXBn((object) folderPath, ConfigExport.AG4Q6BEPqE5aLValmTMo(712480695 ^ 712438911));
        num1 = 17;
        continue;
label_130:
        enumerator1 = this.fileUidsM.GetEnumerator();
        num1 = 15;
      }
label_125:
      return;
label_124:
      return;
label_120:
      return;
label_116:
      return;
label_82:
      try
      {
        ConfigExport.WYv0WjEPPi09LpaLe4pq((object) xmlWriter1, ConfigExport.AG4Q6BEPqE5aLValmTMo(1304605005 ^ 1304875329));
        int num9 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
          num9 = 0;
        Dictionary<Guid, long>.Enumerator enumerator;
        while (true)
        {
          switch (num9)
          {
            case 1:
              goto label_112;
            case 2:
label_118:
              ConfigExport.XT0ubCEPa5LP6YLPfYsE((object) xmlWriter1);
              num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 1;
              continue;
            case 3:
              try
              {
label_110:
                if (enumerator.MoveNext())
                  goto label_87;
                else
                  goto label_111;
label_86:
                KeyValuePair<Guid, long> current;
                int num10;
                switch (num10)
                {
                  case 1:
                    goto label_110;
                  case 2:
                    break;
                  case 3:
                    goto label_118;
                  default:
                    try
                    {
                      string path1 = path;
                      Guid key = current.Key;
                      string path2 = key.ToString();
                      string str3 = Path.Combine(path1, path2);
                      int num11 = 13;
                      BinaryFile binaryFile;
                      while (true)
                      {
                        switch (num11)
                        {
                          case 1:
                            ConfigExport.oF2OUREPUqnmS3bjWjAg((object) xmlWriter1, ConfigExport.AG4Q6BEPqE5aLValmTMo(-1204263869 ^ -1341583247 ^ 137491820), ConfigExport.di82NbEPLglNkWCgAfdA((object) binaryFile));
                            num11 = 9;
                            continue;
                          case 2:
                            ConfigExport.Dt6JohEPjR7p93ZLnC34((object) binaryFile, (object) str3);
                            num11 = 3;
                            continue;
                          case 3:
                            ConfigExport.WYv0WjEPPi09LpaLe4pq((object) xmlWriter1, ConfigExport.AG4Q6BEPqE5aLValmTMo(-1487388570 ^ -1487134656));
                            num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
                            continue;
                          case 4:
                            xmlWriter1.WriteElementString((string) ConfigExport.AG4Q6BEPqE5aLValmTMo(1149433385 + 173655049 ^ 1323092466), (string) ConfigExport.iDFMy3EPYfbaJbLbF2fA((object) binaryFile));
                            num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 1;
                            continue;
                          case 5:
                            object obj = ConfigExport.tNJCmlEPr2o7u11cWDBG();
                            key = current.Key;
                            string str4 = key.ToString();
                            binaryFile = (BinaryFile) ConfigExport.CZHd9WEPg4SZwgScjpmm(obj, (object) str4);
                            num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 11 : 4;
                            continue;
                          case 6:
                          case 7:
                            goto label_110;
                          case 8:
                            ConfigExport.VhdgEREP1R7gVwF6UdK7((object) xmlWriter1, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051802738 - -1831968059 ^ -1410942561), (object) current.Value.ToString());
                            num11 = 4;
                            continue;
                          case 9:
                            ConfigExport.oF2OUREPUqnmS3bjWjAg((object) xmlWriter1, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(92412609 - 1050237057 ^ -957707716), ConfigExport.Y4jHvCEPsdkWWJuwn9Vc((object) binaryFile));
                            num11 = 12;
                            continue;
                          case 10:
                            ConfigExport.XT0ubCEPa5LP6YLPfYsE((object) xmlWriter1);
                            num11 = 6;
                            continue;
                          case 11:
                            if (ConfigExport.ktyCqZEP5U1KhkURa0MA((object) binaryFile.ContentLocation, (object) null))
                            {
                              num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 2 : 2;
                              continue;
                            }
                            goto label_110;
                          case 12:
                            ConfigExport.oF2OUREPUqnmS3bjWjAg((object) xmlWriter1, ConfigExport.AG4Q6BEPqE5aLValmTMo(1232639661 >> 3 ^ 153967171), (object) Convert.ToString(ConfigExport.s4XkMOEPcKEJf8tsoS4O((object) binaryFile), (IFormatProvider) ConfigExport.KVtt7EEPz7g1iSpkmV2V()));
                            num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 10 : 3;
                            continue;
                          case 13:
                            if (ConfigExport.rrTl4uEPlaYWf0XxAqkE((object) str3))
                            {
                              num11 = 7;
                              continue;
                            }
                            goto case 5;
                          default:
                            XmlWriter xmlWriter2 = xmlWriter1;
                            object localName = ConfigExport.AG4Q6BEPqE5aLValmTMo(694673736 ^ -23604109 ^ -672114007);
                            key = current.Key;
                            string str5 = key.ToString();
                            xmlWriter2.WriteAttributeString((string) localName, str5);
                            num11 = 8;
                            continue;
                        }
                      }
                    }
                    catch (Exception ex)
                    {
                      int num12 = 1;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
                        num12 = 0;
                      while (true)
                      {
                        switch (num12)
                        {
                          case 1:
                            ConfigExport.mUfkm6E1FS8GF2bvGRC1((object) ConfigExport.ExportLog, ConfigExport.FgfQoeEPePex3xR0tvkT((object) ex), (object) ex);
                            num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 0;
                            continue;
                          default:
                            goto label_110;
                        }
                      }
                    }
                }
label_87:
                current = enumerator.Current;
                num10 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0)
                {
                  num10 = 0;
                  goto label_86;
                }
                else
                  goto label_86;
label_111:
                num10 = 3;
                goto label_86;
              }
              finally
              {
                enumerator.Dispose();
                int num13 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
                  num13 = 0;
                switch (num13)
                {
                  default:
                }
              }
            default:
              enumerator = dictionary.GetEnumerator();
              num9 = 3;
              continue;
          }
        }
label_112:;
      }
      finally
      {
        int num14;
        if (xmlWriter1 == null)
          num14 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
        else
          goto label_126;
label_123:
        switch (num14)
        {
          case 1:
            break;
          default:
        }
label_126:
        ConfigExport.amyCuPEPONea2Y3rgLkk((object) xmlWriter1);
        num14 = 2;
        goto label_123;
      }
    }

    /// <summary>Запись дополнительных файлов</summary>
    private void WriteAdditionalFiles(string fileName)
    {
      int num1 = 2;
      List<Action<IExportImportFileService, string>>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_14;
          case 1:
            goto label_3;
          case 2:
            enumerator = this.writeComponentFileActions.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 1 : 1;
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
          goto label_8;
        else
          goto label_7;
label_4:
        int num2;
        switch (num2)
        {
          case 1:
            goto label_8;
          case 2:
            return;
          default:
            goto label_6;
        }
label_7:
        num2 = 2;
        goto label_4;
label_8:
        enumerator.Current(this.exportImportFileService, fileName);
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
        {
          num2 = 0;
          goto label_4;
        }
        else
          goto label_4;
      }
      finally
      {
        enumerator.Dispose();
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
    }

    /// <summary>Пишем пакеты в экспорт</summary>
    /// <param name="folderPath"></param>
    private void WritePackages(string folderPath)
    {
      int num1 = 6;
      Dictionary<string, IPackage>.Enumerator enumerator1;
      while (true)
      {
        int num2 = num1;
        List<PackageDescription>.Enumerator enumerator2;
        List<ElmaStoreComponentDependency> dependencies;
        ConfigExport configExport;
        List<PackageManifest> componentsPackages;
        while (true)
        {
          switch (num2)
          {
            case 1:
label_3:
              enumerator1 = this.exportPackages.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_40;
            case 3:
              goto label_4;
            case 4:
              dependencies = this.exportSettings.Manifest.Dependencies;
              num2 = 2;
              continue;
            case 5:
              configExport = this;
              num2 = 7;
              continue;
            case 6:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 5 : 5;
              continue;
            case 7:
              if (ConfigExport.DLlX1TE1B2XxcdZsVRuZ((object) this.exportSettings) == null)
              {
                num2 = 3;
                continue;
              }
              this.exportPackages = new Dictionary<string, IPackage>();
              num2 = 4;
              continue;
            case 8:
              enumerator2 = this.exportedPackages.GetEnumerator();
              num2 = 10;
              continue;
            case 9:
              goto label_74;
            case 10:
              try
              {
label_10:
                if (enumerator2.MoveNext())
                  goto label_29;
                else
                  goto label_11;
label_9:
                PackageDescription current1;
                IPackage package1;
                List<PackageDescription>.Enumerator enumerator3;
                PackageFilter filter;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_10;
                    case 2:
                      IEnumerable<PackageDescription> source = this.packageService.Find(filter);
                      Func<PackageDescription, bool> func;
                      Func<PackageDescription, bool> func1 = func;
                      Func<PackageDescription, bool> predicate = func1 == null ? (func = (Func<PackageDescription, bool>) (p =>
                      {
                        int num4 = 2;
                        PackageDescription p1;
                        while (true)
                        {
                          switch (num4)
                          {
                            case 1:
                              p1 = p;
                              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 0;
                              continue;
                            case 2:
                              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 1 : 0;
                              continue;
                            default:
                              goto label_2;
                          }
                        }
label_2:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        return componentsPackages.All<PackageManifest>((Func<PackageManifest, bool>) (cp => ConfigExport.\u003C\u003Ec__DisplayClass40_1.BdHOD68k179QKCqc8Rks(ConfigExport.\u003C\u003Ec__DisplayClass40_1.F8SU0J8kP15uP8eSg2xq((object) cp), (object) p1.Id)));
                      })) : func1;
                      enumerator3 = source.Where<PackageDescription>(predicate).ToList<PackageDescription>().GetEnumerator();
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 4 : 1;
                      continue;
                    case 3:
                      if (!this.exportPackages.ContainsKey((string) ConfigExport.Iv3TSjE1WKCynwNNgHbm((object) current1)))
                      {
                        num3 = 7;
                        continue;
                      }
                      goto case 5;
                    case 4:
                      goto label_16;
                    case 5:
                      PackageFilter packageFilter = new PackageFilter();
                      ConfigExport.aD00qNE1h8ADhlfSYnVd((object) packageFilter, PackageLevel.All);
                      ConfigExport.CwvqDBE1GGjLkEQEBqw0((object) packageFilter, PackageStatus.Any);
                      ConfigExport.pj31LCE1fDweU8JxjUFY((object) packageFilter, ConfigExport.dDB4BSE1EKE419sblRHx((object) package1));
                      ConfigExport.D7mAVYE1QWVb8naAVWUJ((object) packageFilter, true);
                      filter = packageFilter;
                      num3 = 2;
                      continue;
                    case 6:
                      goto label_29;
                    case 7:
                      this.exportPackages.Add((string) ConfigExport.Iv3TSjE1WKCynwNNgHbm((object) current1), package1);
                      num3 = 5;
                      continue;
                    case 8:
                      goto label_3;
                    default:
                      package1 = (IPackage) ConfigExport.Hf4P0EE1bEYwfturK5l4((object) this.packageService, ConfigExport.Iv3TSjE1WKCynwNNgHbm((object) current1), (object) ConfigExport.t7hxO7E1onQBsgjPEcBo((object) current1).ToString());
                      num3 = 3;
                      continue;
                  }
                }
label_16:
                try
                {
label_18:
                  if (enumerator3.MoveNext())
                    goto label_22;
                  else
                    goto label_19;
label_17:
                  PackageDescription current2;
                  IPackage package2;
                  int num5;
                  while (true)
                  {
                    switch (num5)
                    {
                      case 1:
                        if (!this.exportPackages.ContainsKey((string) ConfigExport.Iv3TSjE1WKCynwNNgHbm((object) current2)))
                        {
                          num5 = 4;
                          continue;
                        }
                        goto label_18;
                      case 2:
                        package2 = (IPackage) ConfigExport.Hf4P0EE1bEYwfturK5l4((object) this.packageService, (object) current2.Id, (object) ConfigExport.t7hxO7E1onQBsgjPEcBo((object) current2).ToString());
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 1 : 1;
                        continue;
                      case 3:
                        goto label_10;
                      case 4:
                        this.exportPackages.Add(current2.Id, package2);
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
                        continue;
                      case 5:
                        goto label_22;
                      default:
                        goto label_18;
                    }
                  }
label_19:
                  num5 = 3;
                  goto label_17;
label_22:
                  current2 = enumerator3.Current;
                  num5 = 2;
                  goto label_17;
                }
                finally
                {
                  enumerator3.Dispose();
                  int num6 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0)
                    num6 = 0;
                  switch (num6)
                  {
                    default:
                  }
                }
label_11:
                num3 = 8;
                goto label_9;
label_29:
                current1 = enumerator2.Current;
                num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
                {
                  num3 = 0;
                  goto label_9;
                }
                else
                  goto label_9;
              }
              finally
              {
                enumerator2.Dispose();
                int num7 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
                  num7 = 0;
                switch (num7)
                {
                  default:
                }
              }
            default:
              goto label_41;
          }
        }
label_40:
        componentsPackages = dependencies.SelectMany<ElmaStoreComponentDependency, PackageManifest>((Func<ElmaStoreComponentDependency, IEnumerable<PackageManifest>>) (d =>
        {
          IEnumerable<PackageManifest> componentPackages = configExport.moduleManager.GetComponentPackages(d.Id);
          if (componentPackages != null)
            return componentPackages;
          IBPMApp bpmApp = BPMAppManager.Instance.LoadOrNull(d.Id);
          if (bpmApp == null)
            return (IEnumerable<PackageManifest>) new List<PackageManifest>();
          return !(bpmApp.ComponentManifest is ElmaStoreComponentManifest componentManifest2) ? (IEnumerable<PackageManifest>) new List<PackageManifest>() : (IEnumerable<PackageManifest>) componentManifest2.Packages;
        })).ToList<PackageManifest>();
        num1 = 8;
      }
label_4:
      return;
label_74:
      return;
label_41:
      try
      {
label_44:
        if (enumerator1.MoveNext())
          goto label_46;
        else
          goto label_45;
label_43:
        KeyValuePair<string, IPackage> current;
        int num8;
        switch (num8)
        {
          case 1:
            goto label_46;
          case 2:
            return;
          case 3:
            goto label_44;
          default:
            try
            {
              string path1 = folderPath;
              int num9 = 2;
              string path2;
              FileStream fileStream;
              while (true)
              {
                switch (num9)
                {
                  case 2:
                    if (ConfigExport.WBRT5kEPmZFHWdHavVcR((object) path1))
                    {
                      num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 1 : 0;
                      continue;
                    }
                    goto case 5;
                  case 3:
                    goto label_44;
                  case 4:
                    goto label_55;
                  case 5:
                    ConfigExport.gjEk0jE1Csw56G9Rmw5J((object) path1);
                    num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
                    continue;
                  case 6:
                    fileStream = new FileStream(Path.Combine(path1, path2), FileMode.CreateNew);
                    num9 = 4;
                    continue;
                  default:
                    path2 = (string) ConfigExport.LvAWGeE1viPKCkH4pW4a(ConfigExport.AG4Q6BEPqE5aLValmTMo(1994213607 >> 4 ^ 124368048), ConfigExport.dDB4BSE1EKE419sblRHx((object) current.Value), (object) current.Value.Version);
                    num9 = 6;
                    continue;
                }
              }
label_55:
              try
              {
                byte[] buffer = (byte[]) ConfigExport.LulUBkE1Z1M4kXPQTB8h(ConfigExport.J3qbQtE18TZr1ZnENxZB((object) current.Value));
                int num10 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
                  num10 = 0;
                while (true)
                {
                  switch (num10)
                  {
                    case 1:
                      goto label_44;
                    default:
                      fileStream.Write(buffer, 0, buffer.Length);
                      num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 1 : 0;
                      continue;
                  }
                }
              }
              finally
              {
                if (fileStream != null)
                {
                  int num11 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0)
                    num11 = 1;
                  while (true)
                  {
                    switch (num11)
                    {
                      case 1:
                        ConfigExport.amyCuPEPONea2Y3rgLkk((object) fileStream);
                        num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_64;
                    }
                  }
                }
label_64:;
              }
            }
            catch (Exception ex)
            {
              int num12 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
                num12 = 0;
              while (true)
              {
                switch (num12)
                {
                  case 1:
                    ConfigExport.mUfkm6E1FS8GF2bvGRC1((object) ConfigExport.ExportLog, ConfigExport.FgfQoeEPePex3xR0tvkT((object) ex), (object) ex);
                    num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_44;
                }
              }
            }
        }
label_45:
        num8 = 2;
        goto label_43;
label_46:
        current = enumerator1.Current;
        num8 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0)
        {
          num8 = 0;
          goto label_43;
        }
        else
          goto label_43;
      }
      finally
      {
        enumerator1.Dispose();
        int num13 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
          num13 = 0;
        switch (num13)
        {
          default:
        }
      }
    }

    static ConfigExport()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ConfigExport.ExportLog = Logger.GetLogger((string) ConfigExport.AG4Q6BEPqE5aLValmTMo(874012245 ^ 874266121));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static int eLgxOFEPRbqCYA6N0jED([In] object obj0) => ((ICollection<Guid>) obj0).Count;

    internal static object AG4Q6BEPqE5aLValmTMo(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool p9lGwKEPSmQiGVI75Ifi() => ConfigExport.v8oOK9EPV7R8Xar9GdCl == null;

    internal static ConfigExport dsq18yEPiBvLKjkZK9gk() => ConfigExport.v8oOK9EPV7R8Xar9GdCl;

    internal static void m3QHF6EPKH5TVrsw1Tf2() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object l6cGbPEPXXLEvRQqcrsc() => (object) ComponentManager.Current;

    internal static object D4IV6LEPTsHFZ4dWj1so() => (object) CallContextSessionOwner.Create();

    internal static object FyIjNAEPk8Gc0ZhhLviP([In] object obj0, long userId) => (object) ((ISecurityDeployHelperExtension) obj0).LoadUserOrNull(userId);

    internal static void PHqqbPEPniItLegN6evn([In] object obj0, [In] object obj1, [In] object obj2) => ((ISecurityService) obj0).RunByUser((IUser) obj1, (System.Action) obj2);

    internal static void amyCuPEPONea2Y3rgLkk([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object JmSPtCEP2AFdjU8Jqdnc([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object FgfQoeEPePex3xR0tvkT([In] object obj0) => (object) ((Exception) obj0).Message;

    internal static void WYv0WjEPPi09LpaLe4pq([In] object obj0, [In] object obj1) => ((XmlWriter) obj0).WriteStartElement((string) obj1);

    internal static void VhdgEREP1R7gVwF6UdK7([In] object obj0, [In] object obj1, [In] object obj2) => ((XmlWriter) obj0).WriteAttributeString((string) obj1, (string) obj2);

    internal static bool zZ7rO4EPN7a0SVuA9Poe([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static object iQnLl8EP3DHhdsnkdph2([In] object obj0) => (object) ((IImportantData) obj0).Module;

    internal static bool O6tRLhEPpgfxm2eto07C([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void XT0ubCEPa5LP6YLPfYsE([In] object obj0) => ((XmlWriter) obj0).WriteEndElement();

    internal static object KRjpH6EPDQlNyjDjiLPn([In] object obj0) => (object) File.OpenRead((string) obj0);

    internal static object WbKuXyEPtFnM8NoetdEm([In] object obj0) => (object) BitConverter.ToString((byte[]) obj0);

    internal static object R6aP6iEPw6rtOhJ5e3jA([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0).Replace((string) obj1, (string) obj2);

    internal static object MBjDuSEP4KiAbh3OsRot([In] object obj0) => (object) ((ConfigExportSettings) obj0).FileName;

    internal static void vQ58LXEP6SBO7Mje660k([In] object obj0, [In] object obj1) => ((TextWriter) obj0).Write((string) obj1);

    internal static void nG9Tw3EPHSYppZ0yEvQc([In] object obj0, [In] object obj1, [In] object obj2) => ((EleWise.ELMA.Logging.ILogger) obj0).Warn(obj1, (Exception) obj2);

    internal static object K2AyhHEPAr2kTTZlNqlC([In] object obj0, [In] object obj1) => (object) ((string) obj0).Split((char[]) obj1);

    internal static bool ehjakIEP7FpjBWxThaX2([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static object EDtyRYEPx1wpv4ZsPOwN(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) ((IExportImportFileService) obj0).CreateFileName((string) obj1, (string) obj2, (string) obj3);
    }

    internal static object m8N5feEP0SyMkkApBXBn([In] object obj0, [In] object obj1) => (object) Path.Combine((string) obj0, (string) obj1);

    internal static bool WBRT5kEPmZFHWdHavVcR([In] object obj0) => Directory.Exists((string) obj0);

    internal static void YR860UEPyXhs1IBuERcn([In] object obj0, [In] object obj1) => ((XmlWriterSettings) obj0).Encoding = (Encoding) obj1;

    internal static void IwJBHHEPM6cHbWhGrt0U([In] object obj0, [In] bool obj1) => ((XmlWriterSettings) obj0).CloseOutput = obj1;

    internal static void SbBJHwEPJ9HHBls1K8DA([In] object obj0, [In] bool obj1) => ((XmlWriterSettings) obj0).Indent = obj1;

    internal static void PlRO3xEP9KFY0jW5MuCk([In] object obj0, [In] ConformanceLevel obj1) => ((XmlWriterSettings) obj0).ConformanceLevel = obj1;

    internal static object UHLMCgEPdadJW7Vr9MJ6([In] object obj0, [In] object obj1) => (object) XmlWriter.Create((string) obj0, (XmlWriterSettings) obj1);

    internal static bool rrTl4uEPlaYWf0XxAqkE([In] object obj0) => File.Exists((string) obj0);

    internal static object tNJCmlEPr2o7u11cWDBG() => (object) DataAccessManager.FileManager;

    internal static object CZHd9WEPg4SZwgScjpmm([In] object obj0, [In] object obj1) => (object) ((IFileManager) obj0).LoadFile((string) obj1);

    internal static bool ktyCqZEP5U1KhkURa0MA([In] object obj0, [In] object obj1) => (Uri) obj0 != (Uri) obj1;

    internal static void Dt6JohEPjR7p93ZLnC34([In] object obj0, [In] object obj1) => ((BinaryFile) obj0).SaveToLocalPath((string) obj1);

    internal static object iDFMy3EPYfbaJbLbF2fA([In] object obj0) => (object) ((BinaryFile) obj0).Name;

    internal static object di82NbEPLglNkWCgAfdA([In] object obj0) => (object) ((BinaryFile) obj0).Id;

    internal static void oF2OUREPUqnmS3bjWjAg([In] object obj0, [In] object obj1, [In] object obj2) => ((XmlWriter) obj0).WriteElementString((string) obj1, (string) obj2);

    internal static object Y4jHvCEPsdkWWJuwn9Vc([In] object obj0) => (object) ((BinaryFile) obj0).ContentType;

    internal static DateTime s4XkMOEPcKEJf8tsoS4O([In] object obj0) => ((BinaryFile) obj0).CreateDate;

    internal static object KVtt7EEPz7g1iSpkmV2V() => (object) CultureInfo.InvariantCulture;

    internal static void mUfkm6E1FS8GF2bvGRC1([In] object obj0, [In] object obj1, [In] object obj2) => ((EleWise.ELMA.Logging.ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static object DLlX1TE1B2XxcdZsVRuZ([In] object obj0) => (object) ((ConfigExportSettings) obj0).Manifest;

    internal static object Iv3TSjE1WKCynwNNgHbm([In] object obj0) => (object) ((PackageDescription) obj0).Id;

    internal static object t7hxO7E1onQBsgjPEcBo([In] object obj0) => (object) ((PackageDescription) obj0).LastVersion;

    internal static object Hf4P0EE1bEYwfturK5l4([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((PackageService) obj0).GetPackage((string) obj1, (string) obj2);

    internal static void aD00qNE1h8ADhlfSYnVd([In] object obj0, PackageLevel value) => ((PackageFilter) obj0).Level = value;

    internal static void CwvqDBE1GGjLkEQEBqw0([In] object obj0, PackageStatus value) => ((PackageFilter) obj0).Status = value;

    internal static object dDB4BSE1EKE419sblRHx([In] object obj0) => (object) ((IPackageName) obj0).Id;

    internal static void pj31LCE1fDweU8JxjUFY([In] object obj0, [In] object obj1) => ((PackageFilter) obj0).Owner = (string) obj1;

    internal static void D7mAVYE1QWVb8naAVWUJ([In] object obj0, bool value) => ((PackageFilter) obj0).IncludeIncompatiblePackages = value;

    internal static object gjEk0jE1Csw56G9Rmw5J([In] object obj0) => (object) Directory.CreateDirectory((string) obj0);

    internal static object LvAWGeE1viPKCkH4pW4a([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static object J3qbQtE18TZr1ZnENxZB([In] object obj0) => (object) ((IPackage) obj0).GetStream();

    internal static object LulUBkE1Z1M4kXPQTB8h([In] object obj0) => (object) EleWise.ELMA.Extensions.StreamExtensions.ReadAllBytes((Stream) obj0);
  }
}
