// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.IMetadataUpdateDataHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Scripts
{
  /// <summary>
  /// Точка расширения получения необходимых данных для обновления метаданных на новый рантайм
  /// </summary>
  [ExtensionPoint(ComponentType.All)]
  public interface IMetadataUpdateDataHandler
  {
    /// <summary>Проверить текущие реализации</summary>
    /// <param name="metadata">Метаданные</param>
    /// <returns><c>True</c>, если реализация подходит</returns>
    bool Check(IMetadata metadata);

    /// <summary>Получить серверный модуль сценариев</summary>
    /// <param name="updateResult">Результат обновления метаданных</param>
    /// <returns>Серверный модуль сценариев</returns>
    IEnumerable<ScriptModule> GetScriptModules(IMetadataUpdateResult updateResult);

    /// <summary>Получить список уникальных идентификаторов форм</summary>
    /// <param name="updateResult">Результат обновления метаданных</param>
    /// <returns>Список уникальных идентификаторов форм</returns>
    IEnumerable<Guid> GetFormUids(IMetadataUpdateResult updateResult);
  }
}
