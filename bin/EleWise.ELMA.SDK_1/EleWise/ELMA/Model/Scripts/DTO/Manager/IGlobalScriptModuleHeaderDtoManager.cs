// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.DTO.Manager.IGlobalScriptModuleHeaderDtoManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Scripts.DTO.Models;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Scripts.DTO.Manager
{
  public interface IGlobalScriptModuleHeaderDtoManager : IConfigurationService
  {
    /// <summary>Сохранить пользовательское расширение</summary>
    /// <param name="gsm">Глобальный модуль сценариев</param>
    GlobalScriptModuleHeaderDto Save(GlobalScriptModuleHeaderDto gsm);

    /// <summary>Загрузить пользовательское расширение</summary>
    /// <param name="id">Id глобального модуля сценариев</param>
    /// <returns>Пользовательское расширение</returns>
    GlobalScriptModuleHeaderDto LoadOrNull(long id);

    /// <summary>Загрузить пользовательское расширение</summary>
    /// <param name="uid">Идентификатор глобального модуля сценариев</param>
    /// <returns>Пользовательское расширение</returns>
    GlobalScriptModuleHeaderDto LoadOrNull(Guid uid);

    /// <summary>
    /// Проверить, можно ли использовать указанное имя пользовательского расширения
    /// </summary>
    /// <param name="id">Id пользовательского расширения. Если пользовательское расширение новое, то 0</param>
    /// <param name="name">Имя пользовательского расширения</param>
    /// <param name="errorMessage">Сообщение об ошибке</param>
    /// <returns>True, если имя использовать можно</returns>
    bool CheckGlobalScriptModuleName(long id, string name, out string errorMessage);

    /// <summary>
    /// Проверить, можно ли использовать указанное имя для класса контекста пользовательского расширения
    /// </summary>
    /// <param name="id">Id пользовательского расширения. Если пользовательское расширение новое, то 0</param>
    /// <param name="name">Имя класса контекста пользовательского расширения</param>
    /// <param name="errorMessage">Сообщение об ошибке</param>
    /// <returns>True, если имя использовать можно</returns>
    bool CheckGlobalScriptModuleClassName(long id, string name, out string errorMessage);

    /// <summary>
    /// Проверить, можно ли использовать указанное имя для таблицы контекста пользовательского расширения
    /// </summary>
    /// <param name="id">Id пользовательского расширения. Если пользовательское расширение новое, то 0</param>
    /// <param name="name">Имя таблицы контекста пользовательского расширения</param>
    /// <param name="errorMessage">Сообщение об ошибке</param>
    /// <returns>True, если имя использовать можно</returns>
    bool CheckGlobalScriptModuleTableName(long id, string name, out string errorMessage);

    /// <summary>
    /// Получить все заголовки пользовательских расширений с указанным именем
    /// </summary>
    /// <returns></returns>
    IEnumerable<GlobalScriptModuleHeaderDto> LoadGlobalScriptModulesByName(string headerName);

    /// <summary>
    /// Получить все опубликованные заголовки пользовательских расширений
    /// </summary>
    /// <returns></returns>
    IEnumerable<GlobalScriptModuleHeaderDto> LoadPublishedGlobalScriptModuleHeaders();

    /// <summary>Загрузить все заголовки глобальных модулей</summary>
    /// <returns></returns>
    IEnumerable<GlobalScriptModuleHeaderDto> LoadAllGlobalScriptModuleHeaders();

    /// <summary>
    /// Получить все опубликованные заголовки пользовательских расширений
    /// </summary>
    /// <returns></returns>
    IEnumerable<GlobalScriptModuleHeaderDto> LoadPublishedGlobalScriptModuleHeaders(
      bool deletedIncluded);

    /// <summary>Получить все загруженные в домен глобальные модули</summary>
    /// <returns></returns>
    IEnumerable<GlobalScriptModuleHeaderDto> LoadRuntimeLoadedHeaders();

    /// <summary>
    /// Удаление заголовка пользовательского расширения.
    /// Сущность из базы не удаляется.
    /// </summary>
    /// <param name="header"></param>
    void Delete(GlobalScriptModuleHeaderDto header);

    /// <summary>Получить raw сборки</summary>
    /// <param name="headerUid"></param>
    /// <returns></returns>
    byte[] GetAssemblyRaw(Guid headerUid);
  }
}
