// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Packaging.IStoreComponentInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Modules;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using NuGet;
using System.Collections.Generic;

namespace EleWise.ELMA.Packaging
{
  /// <summary>Информация о компоненте ELMA Store</summary>
  public interface IStoreComponentInfo
  {
    /// <summary>Идентификатор</summary>
    string Id { get; }

    /// <summary>Отображаемое имя компонента</summary>
    string Title { get; }

    /// <summary>Путь до иконки</summary>
    string ImagePath { get; }

    /// <summary>Описание компонента</summary>
    string Description { get; }

    /// <summary>
    /// 
    /// </summary>
    string Author { get; }

    /// <summary>
    /// 
    /// </summary>
    string Site { get; }

    /// <summary>Тип компонента</summary>
    ManifestComponentType Type { get; }

    /// <summary>Статус модуля</summary>
    ModuleStatus Status { get; }

    /// <summary>Причина отключения</summary>
    ModuleDisabledReason DisabledReason { get; }

    /// <summary>Список всех пакетов, входящих в данный компонент</summary>
    IEnumerable<PackageDescription> AllPackages { get; }

    /// <summary>
    /// Список всех рантаймовых модулей, входящих в данный компонент
    /// </summary>
    IEnumerable<IModule> AllModules { get; }

    /// <summary>Лицензируемый модуль</summary>
    ILicensedUnit LicensedUnit { get; }

    /// <summary>Установлен или нет</summary>
    bool IsInstalled { get; }

    /// <summary>Версия</summary>
    SemanticVersion InstalledVersion { get; }

    /// <summary>Установлена ли последняя версия</summary>
    bool IsLatestVersionInstalled { get; }

    /// <summary>Номер последней версии</summary>
    SemanticVersion LastVersion { get; }

    /// <summary>
    /// Требуется ли перезагрузка сервера после установки/обновления Store-компонента.
    /// </summary>
    bool DoesInstallOrUpdateRequireRestart { get; }
  }
}
