// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.IMetadataUpdateService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using System;

namespace EleWise.ELMA.Model.Scripts
{
  /// <summary>Сервис обновления метаданных на новую версию рантайма</summary>
  public interface IMetadataUpdateService
  {
    /// <summary>Обновить метаданные</summary>
    /// <param name="metadata">Метаданные</param>
    /// <returns>Результат обновления метаданных</returns>
    IMetadataUpdateResult Update(IMetadata metadata);

    /// <summary>Обновить метаданные</summary>
    /// <param name="metadata">Метаданные</param>
    /// <param name="formUid">Уникальный идентификатор формы</param>
    /// <returns>Результат обновления метаданных</returns>
    IMetadataUpdateResult Update(IMetadata metadata, Guid formUid);
  }
}
