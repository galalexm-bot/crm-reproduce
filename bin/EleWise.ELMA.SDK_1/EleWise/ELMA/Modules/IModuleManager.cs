// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Modules.IModuleManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Packaging;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace EleWise.ELMA.Modules
{
  /// <summary>Менеджер управления модулями</summary>
  public interface IModuleManager
  {
    /// <summary>Получить основное приложение</summary>
    IApplication MainApplication { get; }

    /// <summary>Получить основной лицензируемый модуль</summary>
    ILicensedUnit MainLicensedUnit { get; }

    /// <summary>
    /// Получить дату истечения срока действия лицензии основного модуля
    /// </summary>
    /// <returns></returns>
    DateTime? GetMainLicensedUnitExpiration();

    /// <summary>Найти элемент приложения по строковому идентификатору</summary>
    /// <param name="id">Строковый идентификатор элемента приложения</param>
    /// <returns>Элемент приложения</returns>
    IApplicationUnit FindUnitById(string id);

    /// <summary>
    /// Найти элемент приложения по уникальному идентификатору
    /// </summary>
    /// <param name="uid">Уникальный идентификатор элемента приложения</param>
    /// <returns>Элемент приложения</returns>
    IApplicationUnit FindUnitByUid(Guid uid);

    /// <summary>Найти модуль по идентификатору</summary>
    /// <param name="id">Строковый идентификатор элемента приложения</param>
    /// <returns>Модуль приложения</returns>
    IModule FindModuleById(string id);

    /// <summary>Доступна ли данная сборка</summary>
    /// <param name="assembly">Сборка</param>
    /// <returns></returns>
    bool IsAssemblyAvailable(Assembly assembly);

    /// <summary>Найти модуль по сборке</summary>
    /// <param name="assembly">Сборка приложения</param>
    /// <returns>Модуль приложения</returns>
    IModule FindModuleByAssembly(Assembly assembly);

    /// <summary>Сохранить статус модуля</summary>
    /// <param name="uid">Уникальный идентификатор модуля</param>
    /// <param name="status">Статус</param>
    void SaveModuleStatus(Guid uid, ModuleStatus status);

    /// <summary>
    /// Сохранить информацию о подключенном компоненте ELMA Store
    /// </summary>
    /// <param name="manifest">Манифест компонента</param>
    /// <param name="signatures">Подписи компонента</param>
    /// <param name="fileName">Полный путь до файла компонента</param>
    /// <param name="status">Если Allowed, то информация записывается в базу только в том случае, если данный компонент еще не был установлен. Если Active - в любом случае.</param>
    void SaveStoreComponent(
      ElmaStoreComponentManifest manifest,
      IEnumerable<StoreComponentSignatureInfo> signatures,
      string fileName,
      StoreComponentStatus status,
      string unpackedPackagesFolder = null);

    /// <summary>
    /// Сохранить информацию о подключенном компоненте ELMA Store без файла компонента
    /// </summary>
    /// <param name="info">Информация о компоненте</param>
    /// <param name="status">Если Allowed, то информация записывается в базу только в том случае, если данный компонент еще не был установлен. Если Active - в любом случае.</param>
    void SaveStoreComponentInfo(IStoreComponentInfo info, StoreComponentStatus status);

    /// <summary>Получить манифесты установленных компонентов</summary>
    /// <returns></returns>
    IEnumerable<ElmaStoreComponentManifest> GetInstalledComponentManifests();

    /// <summary>Получить все пакеты компонета</summary>
    /// <param name="componentId"></param>
    /// <returns></returns>
    IEnumerable<PackageManifest> GetComponentPackages(string componentId);

    /// <summary>Сохранить информацию о запущенных компонентах</summary>
    void SaveStartedModuleInfos();
  }
}
