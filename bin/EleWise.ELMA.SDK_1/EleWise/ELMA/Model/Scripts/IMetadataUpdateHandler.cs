// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.IMetadataUpdateHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using System;

namespace EleWise.ELMA.Model.Scripts
{
  /// <summary>
  /// Точка расширения для обновления метаданных на новый рантайм
  /// </summary>
  [ExtensionPoint(ComponentType.All)]
  public interface IMetadataUpdateHandler
  {
    /// <summary>Проверить текущие реализации</summary>
    /// <param name="metadata">Метаданные</param>
    /// <returns><c>True</c>, если реализация подходит</returns>
    bool Check(IMetadata metadata);

    /// <summary>Обновить метаданные</summary>
    /// <param name="updateResult">Результат обновления метаданных</param>
    void UpdateMetadata(IMetadataUpdateResult updateResult);

    /// <summary>Обновить формы</summary>
    /// <param name="updateResult">Результат обновления метаданных</param>
    /// <param name="formUid">Уникальный идентификатор формы</param>
    void UpdateForm(IMetadataUpdateResult updateResult, Guid formUid);

    /// <summary>Обновить модули сценариев</summary>
    /// <param name="updateResult">Результат обновления метаданных</param>
    void UpdateScriptModules(IMetadataUpdateResult updateResult);
  }
}
