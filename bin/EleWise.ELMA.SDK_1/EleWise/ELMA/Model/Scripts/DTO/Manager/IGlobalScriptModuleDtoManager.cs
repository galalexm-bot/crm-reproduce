// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.DTO.Manager.IGlobalScriptModuleDtoManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Scripts.DTO.Models;
using System;

namespace EleWise.ELMA.Model.Scripts.DTO.Manager
{
  public interface IGlobalScriptModuleDtoManager : IConfigurationService
  {
    /// <summary>Сохранить глобальный модуль сценариев</summary>
    /// <param name="gsm">Модуль сценариев</param>
    /// <returns>Сохраненный модуль сценариев</returns>
    GlobalScriptModuleDto Save(GlobalScriptModuleDto gsm);

    /// <summary>Опубликовать глобальный модуль сценариев</summary>
    /// <param name="gsm">Глобальный модуль</param>
    /// <returns>Сохраненный глобальный модуль сценариев</returns>
    GlobalScriptModuleDto Publish(GlobalScriptModuleDto gsm);

    /// <summary>Нужна ли перезагрузка сервера</summary>
    /// <returns></returns>
    bool NeedRestartServer();

    /// <summary>Загрузить глобальный модуль по идентификатору</summary>
    /// <param name="id">Идентификатор глобального модуля</param>
    /// <returns>Глобальный модуль сценариев</returns>
    GlobalScriptModuleDto LoadOrNull(long id);

    /// <summary>Загрузить глобальный модуль по UID</summary>
    /// <param name="uid"></param>
    /// <returns></returns>
    GlobalScriptModuleDto LoadOrNull(Guid uid);

    /// <summary>Удалить директорию</summary>
    void DeleteDirectory(string directoryPath);

    /// <summary>Загрузить глобальный модуль по идентификатору</summary>
    /// <param name="id">Идентификатор глобального модуля</param>
    /// <returns>Глобальный модуль сценариев</returns>
    GlobalScriptModuleDto Load(long id);

    /// <summary>Скомпилировать код для проверки, без сохранения</summary>
    /// <param name="gsm"></param>
    /// <returns></returns>
    GlobalScriptModuleDto Validate(GlobalScriptModuleDto gsm);

    /// <summary>Загрузить модуль сценариев для редактирования</summary>
    /// <param name="gsmId">Идентификатор глобального модуля</param>
    /// <returns>Модуль для редактирования</returns>
    ScriptModuleDTO LoadScriptModuleForEdit(long gsmId);

    /// <summary>Сохранить модуль сценариев</summary>
    /// <param name="scriptModule">Модуль сценариев</param>
    void SaveScriptModule(ScriptModuleDTO scriptModule);

    /// <summary>Проверить идентификатор модуля</summary>
    /// <param name="space"></param>
    /// <returns></returns>
    bool CheckGlobalModuleNamespace(string space);

    /// <summary>Проверить имя модуля</summary>
    /// <param name="name"></param>
    /// <returns></returns>
    bool CheckGlobalModuleName(string name);

    /// <summary>
    /// Создать новый глобальный модуль сценариев из имеющегося
    /// </summary>
    /// <param name="oldGsm"></param>
    /// <param name="newPrefix"></param>
    /// <param name="copy"></param>
    /// <returns></returns>
    GlobalScriptModuleDto DoNew(GlobalScriptModuleDto oldGsm, string newPrefix = "", bool copy = false);
  }
}
