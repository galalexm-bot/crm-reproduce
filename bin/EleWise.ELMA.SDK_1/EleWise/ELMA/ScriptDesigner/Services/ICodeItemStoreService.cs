// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ScriptDesigner.Services.ICodeItemStoreService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.ScriptDesigner.ToolBoxItems;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.ScriptDesigner.Services
{
  /// <summary>Сервис для хранения и работы с элементами кода</summary>
  public interface ICodeItemStoreService
  {
    /// <summary>Инициализировать</summary>
    void Initialize();

    /// <summary>Регистрация действий</summary>
    void RegistrateActions();

    /// <summary>Загрузить локальную переменную для цикла</summary>
    /// <param name="variableUid"></param>
    /// <returns></returns>
    VariableCodeItemToolBoxItem LoadLocalVariableByUid(Guid variableUid);

    /// <summary>Получить список контекстных переменных</summary>
    /// <param name="uid">Идентификатор заголовка процесса</param>
    /// <param name="propertyList">Список метадат</param>
    void RegistrateContextVariables(Guid uid, List<IMetadata> propertyList);

    /// <summary>Удалить локальную переменную</summary>
    /// <param name="uid"></param>
    void RemoveStoreLocalItem(Guid uid);

    /// <summary>
    /// Обновить список действий (после перезагрузки сервера, при перегенерации ELMA API)
    /// </summary>
    void UpdateActions();
  }
}
