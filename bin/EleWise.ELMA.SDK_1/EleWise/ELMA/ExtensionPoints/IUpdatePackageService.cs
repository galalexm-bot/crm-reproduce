// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExtensionPoints.IUpdatePackageService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.API.Models;
using EleWise.ELMA.ComponentModel;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace EleWise.ELMA.ExtensionPoints
{
  /// <summary>Сервис, позволяющий создавать пакеты обновлений</summary>
  [ExtensionPoint(ComponentType.All)]
  public interface IUpdatePackageService
  {
    /// <summary>
    /// Перечень типов-реализаций <see cref="T:EleWise.ELMA.API.Models.PackageBase" />, возращаемых сервисом
    /// </summary>
    /// <param name="provider"></param>
    /// <returns></returns>
    IEnumerable<Type> KnownTypes(ICustomAttributeProvider provider);

    /// <summary>Наименование сервиса/набора данных</summary>
    string ServiceName { get; }

    /// <summary>Уникальный идентификатор сервиса/набора данных</summary>
    Guid ServiceUid { get; }

    /// <summary>Создать пакеты обновлений</summary>
    /// <param name="date">Дата обновления</param>
    IEnumerable<PackageBase> CreatePackages(DateTime date);

    /// <summary>
    /// Преобразование пакетов с идентификаторами объектов в пакеты с данными
    /// </summary>
    /// <param name="updateIdPackages"></param>
    /// <returns></returns>
    PackageBase[] ConvertPackages(UpdateIdPackage[] updateIdPackages);

    /// <summary>Запомнить список данныз для устройства</summary>
    /// <param name="serverTime"></param>
    /// <param name="now"></param>
    /// <param name="packages"></param>
    bool PackagesCommit(DateTime serverTime, DateTime now, PackageBase[] packages);

    /// <summary>Синхронизация данных с устройством</summary>
    /// <param name="now"></param>
    /// <param name="changes"></param>
    bool Sync(DateTime now, PackageChangesSyncData[] changes);
  }
}
