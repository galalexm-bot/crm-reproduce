// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.IComponentMetadataSourcesService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model;
using EleWise.ELMA.OmniSharp.Models;
using EleWise.ELMA.UI.Metadata;
using System.Collections.Generic;

namespace EleWise.ELMA.Services
{
  /// <summary>Сервис получения исходников для метаданных компонента</summary>
  public interface IComponentMetadataSourcesService
  {
    /// <summary>Получить имя серверного контроллера</summary>
    /// <param name="metadata">Метаданные компонента</param>
    /// <returns>Имя серверного контроллера</returns>
    string ServerControllerName(ComponentMetadata metadata);

    /// <summary>Получить серверные исходники</summary>
    /// <param name="args">Аргументы</param>
    /// <returns>Серверные исходники</returns>
    IEnumerable<IScriptSource> GetServerSources(MetadataSourcesProviderArgs args);

    /// <summary>Получить имя клиентского контроллера</summary>
    /// <param name="metadata">Метаданные компонента</param>
    /// <returns>Имя клиентского контроллера</returns>
    string ClientControllerName(ComponentMetadata metadata);

    /// <summary>Получить клиентские исходники</summary>
    /// <param name="args">Аргументы</param>
    /// <returns>Клиентские исходники</returns>
    IEnumerable<IScriptSource> GetClientSources(MetadataSourcesProviderArgs args);

    /// <summary>Получить имя тестового контроллера</summary>
    /// <param name="metadata">Метаданные компонента</param>
    /// <returns>Имя тестового контроллера</returns>
    string TestControllerName(ComponentMetadata metadata);

    /// <summary>Получить тестовые исходники</summary>
    /// <param name="args">Аргументы</param>
    /// <returns>Тестовые исходники</returns>
    IEnumerable<IScriptSource> GetTestSources(MetadataSourcesProviderArgs args);

    /// <summary>Получить имя контроллера представления</summary>
    /// <param name="metadata">Метаданные компонента</param>
    /// <returns></returns>
    string ViewControllerName(ComponentMetadata metadata);

    /// <summary>Получить исходники представления</summary>
    /// <param name="args">Аргументы</param>
    /// <returns>Исходники представления</returns>
    IEnumerable<IScriptSource> GetViewSources(MetadataSourcesProviderArgs args);
  }
}
