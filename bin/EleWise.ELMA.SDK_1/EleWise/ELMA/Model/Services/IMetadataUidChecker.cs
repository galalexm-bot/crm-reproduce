// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Services.IMetadataUidChecker
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Services
{
  /// <summary>
  /// Проверка наличия уникального идентификатора в свойствах метаданных
  /// </summary>
  public interface IMetadataUidChecker
  {
    /// <summary>Добавить уникальный идентификатор</summary>
    /// <param name="metadata">Список метаданных</param>
    /// <returns>true, если Uid не найден и был добавлен</returns>
    bool AddUidIfNeeded(IEnumerable<IMetadata> metadata);

    /// <summary>Добавить уникальный идентификатор</summary>
    /// <param name="metadataItems">Элементы метаданных</param>
    /// <returns>true, если Uid не найден и был добавлен</returns>
    bool AddUidIfNeeded(IEnumerable<IMetadataItem> metadataItems);

    /// <summary>Добавить уникальный идентификатор</summary>
    /// <param name="metadata">Метаданные</param>
    /// <returns>true, если Uid не найден и был добавлен</returns>
    bool AddUidIfNeeded(IMetadata metadata);
  }
}
