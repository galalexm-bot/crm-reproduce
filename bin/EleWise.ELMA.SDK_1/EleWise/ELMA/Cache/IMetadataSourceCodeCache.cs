// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Cache.IMetadataSourceCodeCache
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Scripts.Models;
using System;

namespace EleWise.ELMA.Cache
{
  /// <summary>Кэш исходных кодов, сгенерированных для метаданных</summary>
  public interface IMetadataSourceCodeCache
  {
    /// <summary>Получить путь до папки с исходниками</summary>
    /// <param name="codeType">Тип модуля сценариев</param>
    /// <returns>Путь до папки с исходниками</returns>
    string GetFolderPath(CodeType codeType);

    /// <summary>Существует ли глобальный кэш</summary>
    /// <returns><c>True</c>, если глобальный кэш существует</returns>
    bool IsGlobalCacheExists();

    /// <summary>
    /// Инвалидировать кэш для определённого заголовка метаданных
    /// </summary>
    /// <param name="metadataItemHeaderUid">Уникальный идентификатор заголовка элемента метаданных</param>
    void InvalidateCache(Guid metadataItemHeaderUid);

    /// <summary>Обновить кэш на диске</summary>
    void UpdateDiskCache();
  }
}
