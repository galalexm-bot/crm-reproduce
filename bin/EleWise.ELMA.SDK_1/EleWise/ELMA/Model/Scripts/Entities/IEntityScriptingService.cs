// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.Entities.IEntityScriptingService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Scripts.Entities
{
  /// <summary>Сервис исполнения сценариев для сущностей</summary>
  public interface IEntityScriptingService
  {
    /// <summary>Получить тип модуля сценариев</summary>
    /// <param name="entity">Сущность</param>
    /// <returns></returns>
    Type GetScriptModuleType(IEntity entity);

    /// <summary>
    /// Получить тип сущности, используемый в модуле сценариев сущности
    /// </summary>
    /// <param name="entity">Сущность</param>
    /// <returns></returns>
    Type GetScriptModuleItemType(IEntity entity);

    /// <summary>Получить экземпляр модуля сценариев</summary>
    /// <param name="entity">Сущность</param>
    /// <returns></returns>
    object GetScriptInstance(IEntity entity);

    /// <summary>Выполнить сценарий</summary>
    /// <param name="entity">Сущность</param>
    /// <param name="scriptName">Имя сценария</param>
    /// <param name="parameters">Параметры для сценария</param>
    /// <param name="parameterAccessor">Функция, возвращающая значение параметра</param>
    /// <returns>Результат выполнения сценария</returns>
    object ExecuteScript(
      IEntity entity,
      string scriptName,
      Dictionary<string, object> parameters = null,
      Func<string, Type, object> parameterAccessor = null);
  }
}
