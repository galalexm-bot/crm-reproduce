// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Managers.DeployManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Configuration;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Deploy.Services;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NuGet;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace EleWise.ELMA.Deploy.Managers
{
  /// <summary>
  /// Менеджер экспорта-импорта конфигурации для работы через Remoting
  /// </summary>
  internal class DeployManager : DTOManager, IDeployManager, IConfigurationService
  {
    private readonly ConcurrentDictionary<Guid, int> logMessages;
    private readonly ConcurrentDictionary<Guid, int> systemMessages;
    private readonly IExportImportService exportImportService;
    internal static DeployManager qvEG6rEtZC94e41l49O8;

    /// <summary>Ctor</summary>
    /// <param name="exportImportService">Сервис экспорта/импорта</param>
    public DeployManager(IExportImportService exportImportService)
    {
      DeployManager.nlsBOUEtVgHGWICfgK8J();
      this.logMessages = new ConcurrentDictionary<Guid, int>();
      this.systemMessages = new ConcurrentDictionary<Guid, int>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.exportImportService = exportImportService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public virtual Guid ExportConfiguration(ConfigExportSettings settings)
    {
      int num = 3;
      Guid result;
      TaskAwaiter<Guid> awaiter;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.logMessages[result] = 0;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
            continue;
          case 2:
            result = awaiter.GetResult();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 1 : 1;
            continue;
          case 3:
            awaiter = this.exportImportService.Export(settings).GetAwaiter();
            num = 2;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return result;
    }

    /// <summary>Проверка файла импорта</summary>
    /// <param name="settings">Настройки импорта</param>
    /// <returns></returns>
    public virtual Guid TestConfiguration(IConfigImportSettings settings, string activateKey = null)
    {
      int num1 = 2;
      Guid result;
      while (true)
      {
        int num2 = num1;
        TaskAwaiter<Guid> awaiter;
        while (true)
        {
          switch (num2)
          {
            case 1:
              result = awaiter.GetResult();
              num2 = 3;
              continue;
            case 2:
              awaiter = this.exportImportService.Test(settings, activateKey).GetAwaiter();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 1 : 0;
              continue;
            case 3:
              this.logMessages[result] = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
              continue;
            case 4:
              goto label_7;
            default:
              goto label_5;
          }
        }
label_5:
        this.systemMessages[result] = 0;
        num1 = 4;
      }
label_7:
      return result;
    }

    /// <summary>Прописать ключ активации</summary>
    /// <param name="activateKey"></param>
    /// <returns></returns>
    public virtual bool AddActivationKey(
      string activateKey,
      List<ElmaStoreComponentManifest> componentsToInstall,
      out List<ElmaStoreComponentManifest> notActivatedComponents)
    {
      notActivatedComponents = new List<ElmaStoreComponentManifest>();
      if (!string.IsNullOrEmpty(activateKey))
      {
        IEnumerable<IStoreComponentInfo> newActivatedComponents;
        ComponentManager.Current.LicenseManager.AddActivationKey(activateKey, out newActivatedComponents);
        List<IStoreComponentInfo> list = newActivatedComponents.ToList<IStoreComponentInfo>();
        foreach (ElmaStoreComponentManifest componentManifest in componentsToInstall.Where<ElmaStoreComponentManifest>((Func<ElmaStoreComponentManifest, bool>) (c => c.ProductType != ManifestComponentType.Platform)).ToList<ElmaStoreComponentManifest>())
        {
          ElmaStoreComponentManifest manifest = componentManifest;
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          if (list.All<IStoreComponentInfo>((Func<IStoreComponentInfo, bool>) (nc => (string) DeployManager.\u003C\u003Ec__DisplayClass6_0.zwQ3qJ8ehalR445yVjG2((object) nc) != (string) DeployManager.\u003C\u003Ec__DisplayClass6_0.rOn6ee8eG866FMJVHIc0((object) manifest))))
            notActivatedComponents.Add(componentManifest);
        }
      }
      return notActivatedComponents.Count == 0;
    }

    /// <inheritdoc />
    public virtual Guid ImportConfiguration(IConfigImportSettings settings)
    {
      int num = 2;
      TaskAwaiter<Guid> awaiter;
      Guid result;
      while (true)
      {
        switch (num)
        {
          case 1:
            result = awaiter.GetResult();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 2 : 4;
            continue;
          case 2:
            awaiter = this.exportImportService.Import((IImportSettings) settings).GetAwaiter();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 1 : 1;
            continue;
          case 3:
            this.systemMessages[result] = 0;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 0;
            continue;
          case 4:
            this.logMessages[result] = 0;
            num = 3;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return result;
    }

    public virtual void ExecutePackagesOperations(PackageInstallInfo installInfo)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            Locator.GetServiceNotNull<PackageService>().ExecuteOperations((IEnumerable<PackageOperationInfo>) installInfo.Operations.Select<PackageInstallOperationInfo, PackageOperationInfo>((Func<PackageInstallOperationInfo, PackageOperationInfo>) (o =>
            {
              PackageOperationInfo packageOperationInfo = new PackageOperationInfo();
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              DeployManager.\u003C\u003Ec.YlwJrm8e8Tj5oQJWjwyT((object) packageOperationInfo, DeployManager.\u003C\u003Ec.JcctWk8evfMYSUygix6k((object) o));
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              packageOperationInfo.Package = DeployManager.\u003C\u003Ec.S07Yb48eZr6ME0pB7Jv3((object) o) == null ? new PackageInfo((string) DeployManager.\u003C\u003Ec.o6veDF8euOsSo5SucBM6((object) o)) : new PackageInfo((string) DeployManager.\u003C\u003Ec.o6veDF8euOsSo5SucBM6((object) o), new SemanticVersion((string) DeployManager.\u003C\u003Ec.S07Yb48eZr6ME0pB7Jv3((object) o)));
              return packageOperationInfo;
            })).ToList<PackageOperationInfo>(), new PackageOperationOptions()
            {
              UpdatingUid = DeployManager.EINUHZEtSHLkEnK48rhe((object) installInfo),
              StartAfterUpdate = true
            });
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public virtual PackageOperationStatus GetUpdatePackagesOperationsStatus(Guid uid) => (PackageOperationStatus) DeployManager.glvfHuEtiwhm9EKSPTKv((object) Locator.GetServiceNotNull<PackageService>(), uid);

    /// <inheritdoc />
    public virtual List<DeploySystemMessage> GetImportSystemMessages(Guid importUid) => this.GetLog<DeploySystemMessage>(importUid, this.systemMessages, new Func<Guid, int, int, Task<IEnumerable<DeploySystemMessage>>>(this.exportImportService.GetImportSystemMessages));

    /// <inheritdoc />
    public virtual List<DeploySystemMessage> GetTestSystemMessages(Guid testUid) => this.GetLog<DeploySystemMessage>(testUid, this.systemMessages, new Func<Guid, int, int, Task<IEnumerable<DeploySystemMessage>>>(this.exportImportService.GetTestSystemMessages));

    /// <inheritdoc />
    public virtual List<TestImportMessages> GetTestLog(Guid testUid) => this.GetLog<TestImportMessages>(testUid, this.logMessages, new Func<Guid, int, int, Task<IEnumerable<TestImportMessages>>>(this.exportImportService.GetTestLog));

    /// <inheritdoc />
    public virtual List<DeployLogMessage> GetImportLog(Guid importUid) => this.GetLog<DeployLogMessage>(importUid, this.logMessages, new Func<Guid, int, int, Task<IEnumerable<DeployLogMessage>>>(this.exportImportService.GetImportLog));

    /// <inheritdoc />
    public virtual List<DeployLogMessage> GetExportLog(Guid exportUid) => this.GetLog<DeployLogMessage>(exportUid, this.logMessages, new Func<Guid, int, int, Task<IEnumerable<DeployLogMessage>>>(this.exportImportService.GetExportLog));

    /// <summary>Получить сообщения лога</summary>
    /// <typeparam name="T">Тип сообщений</typeparam>
    /// <param name="sessionId">Идентификатор сессии</param>
    /// <param name="messageCountDictionary">Словарь с данными о количестве сообщений на клиенте</param>
    /// <param name="getLogsFunc">Метод получения логов</param>
    /// <returns>Список сообщений лога</returns>
    private List<T> GetLog<T>(
      Guid sessionId,
      ConcurrentDictionary<Guid, int> messageCountDictionary,
      Func<Guid, int, int, Task<IEnumerable<T>>> getLogsFunc)
    {
      int num;
      if (!messageCountDictionary.TryGetValue(sessionId, out num))
        return (List<T>) null;
      List<T> list = getLogsFunc(sessionId, num, 0).GetAwaiter().GetResult().ToList<T>();
      messageCountDictionary[sessionId] += list.Count;
      return list;
    }

    /// <summary>Все пакеты сервера</summary>
    /// <returns></returns>
    public virtual List<PackageDescription> FindAllPackages() => Locator.GetServiceNotNull<PackageService>().FindAll().ToList<PackageDescription>();

    /// <summary>Возвращаем зависимости пакета</summary>
    /// <param name="description"></param>
    /// <returns></returns>
    public virtual List<PackageDescription> FindPackageDependencies(PackageDescription description)
    {
      List<PackageDescription> packageDependencies = new List<PackageDescription>();
      PackageService serviceNotNull = Locator.GetServiceNotNull<PackageService>();
      string id = description.Id;
      SemanticVersion semanticVersion = description.InstalledVersion;
      if ((object) semanticVersion == null)
        semanticVersion = description.LastVersion;
      string version = semanticVersion.ToString();
      IPackage package = serviceNotNull.GetPackage(id, version);
      List<PackageDescription> list = serviceNotNull.Find(new PackageFilter()
      {
        Level = PackageLevel.All,
        Status = PackageStatus.Any
      }).ToList<PackageDescription>();
      if (package != null)
      {
        foreach (PackageDependencySet dependencySet in package.DependencySets)
        {
          foreach (PackageDependency dependency1 in (IEnumerable<PackageDependency>) dependencySet.Dependencies)
          {
            PackageDependency dependency = dependency1;
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            PackageDescription packageDescription1 = list.FirstOrDefault<PackageDescription>((Func<PackageDescription, bool>) (p => DeployManager.\u003C\u003Ec__DisplayClass17_0.XroWNc8eKEKVif9RnpIR(DeployManager.\u003C\u003Ec__DisplayClass17_0.WJEuEM8eREHo3Pk3wWdh((object) p), DeployManager.\u003C\u003Ec__DisplayClass17_0.VZpxVr8eqrMGDkvahrLA((object) dependency))));
            if (packageDescription1 != null)
            {
              PackageDescription packageDescription2 = ClassSerializationHelper.CloneObject<PackageDescription>(packageDescription1);
              packageDescription2.DependencyVersion = dependency.VersionSpec.ToString();
              packageDependencies.Add(packageDescription2);
            }
          }
        }
      }
      return packageDependencies;
    }

    /// <summary>Поиск пакета на сервере</summary>
    /// <param name="filter"></param>
    /// <returns></returns>
    public virtual List<PackageDescription> FindPackages(PackageFilter filter) => Locator.GetServiceNotNull<PackageService>().Find(filter).ToList<PackageDescription>();

    /// <summary>Получить информацию по лицензированию сервера</summary>
    /// <returns></returns>
    public virtual ImportLicenseInfo GetServerLicenseInfo()
    {
      ImportLicenseInfo serverLicenseInfo = new ImportLicenseInfo();
      DeployManager.KyiHDcEtRFhXWtmNWoQR((object) serverLicenseInfo);
      return serverLicenseInfo;
    }

    /// <summary>
    /// Получить содержимое файла из папки дополнительных файлов компонента
    /// </summary>
    /// <param name="componentId">Идентификатор компонента</param>
    /// <param name="version">Версия компонента</param>
    /// <param name="relativeFileName">Путь до файла относительно папки с дополнительными файлами данного компонента</param>
    /// <returns></returns>
    public virtual byte[] GetComponentFileContent(
      string componentId,
      string version,
      string relativeFileName)
    {
      int num = 12;
      string str;
      string componentId1;
      string version1;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_6;
          case 2:
            DeployManager.MFxKZLEtKFcJXe6CSJfj((object) relativeFileName, DeployManager.QkU5wREtqRhCg3cFfHR1(1304605005 ^ 1304836009));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 3 : 5;
            continue;
          case 3:
            goto label_15;
          case 4:
            version1 = version;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 0;
            continue;
          case 5:
            if (((IEnumerable<char>) Path.GetInvalidFileNameChars()).Any<char>((Func<char, bool>) (ch => componentId1.Contains<char>(ch))))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 3 : 0;
              continue;
            }
            if (!((IEnumerable<char>) DeployManager.uDAo4SEtTILjuxaiuZmi()).Any<char>((Func<char, bool>) (ch => version1.Contains<char>(ch))))
            {
              num = 7;
              continue;
            }
            goto label_6;
          case 6:
            Contract.ArgumentNotNullOrEmpty(version1, (string) DeployManager.QkU5wREtqRhCg3cFfHR1(-1350312861 << 3 ^ 2082369388));
            num = 2;
            continue;
          case 7:
            if (!relativeFileName.Contains((string) DeployManager.QkU5wREtqRhCg3cFfHR1(~210725948 ^ -210456179)))
            {
              str = (string) DeployManager.BeA82NEteic1dZ9cBIwP(DeployManager.w1m3yWEtPe2PKXkXwhWH(DeployManager.BeA82NEteic1dZ9cBIwP(DeployManager.VBb6bqEt2ALjeEXGewji(DeployManager.hJMbnfEtOfr7cl6Zj7YS(DeployManager.B1hu90EtnAgX14sEyfVH(DeployManager.h51oOfEtkXIdWcw5aRPY((object) Locator.GetServiceNotNull<IRuntimeApplication>())))), DeployManager.QkU5wREtqRhCg3cFfHR1(-1317790512 ^ -1318020236)), (object) componentId1, (object) version1), (object) relativeFileName);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 4 : 10;
              continue;
            }
            num = 8;
            continue;
          case 8:
            goto label_2;
          case 9:
            goto label_4;
          case 10:
            if (!File.Exists(str))
            {
              num = 9;
              continue;
            }
            goto label_5;
          case 11:
            componentId1 = componentId;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 1 : 4;
            continue;
          case 12:
            num = 11;
            continue;
          default:
            DeployManager.MFxKZLEtKFcJXe6CSJfj((object) componentId1, DeployManager.QkU5wREtqRhCg3cFfHR1(2008901894 << 3 ^ -1108357382));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 2 : 6;
            continue;
        }
      }
label_2:
      throw new ArgumentException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(2045296739 + 1688595713 ^ -561370600)));
label_4:
      throw new FileNotFoundException((string) DeployManager.DnGCrMEtXH1NjAtlDq2w(DeployManager.QkU5wREtqRhCg3cFfHR1(~210725948 ^ -210654381)), str);
label_5:
      return File.ReadAllBytes(str);
label_6:
      throw new ArgumentException(EleWise.ELMA.SR.T((string) DeployManager.QkU5wREtqRhCg3cFfHR1(1149433385 + 173655049 ^ 1322794364)));
label_15:
      throw new ArgumentException((string) DeployManager.DnGCrMEtXH1NjAtlDq2w(DeployManager.QkU5wREtqRhCg3cFfHR1(-477139494 ^ -477369646)));
    }

    /// <summary>Проверяем запущен ли импорт в текущий момент</summary>
    /// <returns>true - если импорт запущен</returns>
    public virtual bool IsImportAlreadyRun() => this.GetCurrentImportId() != Guid.Empty;

    /// <summary>Получение идентификатора текущего импорта</summary>
    private Guid GetCurrentImportId()
    {
      int num = 1;
      TaskAwaiter<Guid> awaiter;
      while (true)
      {
        switch (num)
        {
          case 1:
            awaiter = this.exportImportService.GetCurrentImportId().GetAwaiter();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return awaiter.GetResult();
    }

    /// <inheritdoc />
    public virtual IImportSettings GetImportSettings(Guid testUid)
    {
      int num = 1;
      TaskAwaiter<IEnumerable<IImportSettings>> awaiter;
      while (true)
      {
        switch (num)
        {
          case 1:
            awaiter = this.exportImportService.GetImportSettings(testUid).GetAwaiter();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return awaiter.GetResult().FirstOrDefault<IImportSettings>();
    }

    internal static void nlsBOUEtVgHGWICfgK8J() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool evSWRUEtuRnCaV0Xjbib() => DeployManager.qvEG6rEtZC94e41l49O8 == null;

    internal static DeployManager EK0HE1EtI2qXp4VcP6kI() => DeployManager.qvEG6rEtZC94e41l49O8;

    internal static Guid EINUHZEtSHLkEnK48rhe([In] object obj0) => ((PackageInstallInfo) obj0).UpdatingUid;

    internal static object glvfHuEtiwhm9EKSPTKv([In] object obj0, Guid updatingUid) => (object) ((PackageService) obj0).GetOperationStatus(updatingUid);

    internal static void KyiHDcEtRFhXWtmNWoQR([In] object obj0) => ConfigurationImportExecutor.InitImportLicenseInfo((ImportLicenseInfo) obj0);

    internal static object QkU5wREtqRhCg3cFfHR1(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void MFxKZLEtKFcJXe6CSJfj([In] object obj0, [In] object obj1) => Contract.ArgumentNotNullOrEmpty((string) obj0, (string) obj1);

    internal static object DnGCrMEtXH1NjAtlDq2w([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object uDAo4SEtTILjuxaiuZmi() => (object) Path.GetInvalidFileNameChars();

    internal static object h51oOfEtkXIdWcw5aRPY([In] object obj0) => (object) ((IRuntimeApplication) obj0).Configuration;

    internal static object B1hu90EtnAgX14sEyfVH([In] object obj0) => (object) ((RuntimeConfiguration) obj0).Config;

    internal static object hJMbnfEtOfr7cl6Zj7YS([In] object obj0) => (object) ((System.Configuration.Configuration) obj0).FilePath;

    internal static object VBb6bqEt2ALjeEXGewji([In] object obj0) => (object) Path.GetDirectoryName((string) obj0);

    internal static object BeA82NEteic1dZ9cBIwP([In] object obj0, [In] object obj1) => (object) Path.Combine((string) obj0, (string) obj1);

    internal static object w1m3yWEtPe2PKXkXwhWH([In] object obj0, [In] object obj1, [In] object obj2) => (object) Path.Combine((string) obj0, (string) obj1, (string) obj2);
  }
}
