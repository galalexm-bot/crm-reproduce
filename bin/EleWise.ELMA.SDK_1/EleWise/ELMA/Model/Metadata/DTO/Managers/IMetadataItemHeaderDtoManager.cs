// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.DTO.Managers.IMetadataItemHeaderDtoManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Metadata.DTO.Managers
{
  public interface IMetadataItemHeaderDtoManager : IConfigurationService
  {
    IEnumerable<string> GetGlobalModuleNames(IEnumerable<EntityMetadata> mds);

    /// <summary>
    /// Получить идентификаторы зависимых объектов из зависимостей метаданных
    /// </summary>
    /// <param name="uid">Идентификатор метаданных</param>
    /// <returns>Список пар идентификатор-отображаемое имя зависимых объектов</returns>
    IDictionary<Guid, string> GetObjectsUidsFromDependencies(Guid uid);
  }
}
