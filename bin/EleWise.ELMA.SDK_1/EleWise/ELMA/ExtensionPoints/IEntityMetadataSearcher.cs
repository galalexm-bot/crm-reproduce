// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExtensionPoints.IEntityMetadataSearcher
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.ExtensionPoints
{
  /// <summary>
  /// Точка расширения для поиска метаданных (используется в EQL)
  /// </summary>
  [ExtensionPoint(ComponentType.All)]
  public interface IEntityMetadataSearcher
  {
    /// <summary>Найти метаданные по уникальному идентификатору</summary>
    /// <param name="uid">Уникальный идентификатор</param>
    EntityMetadata FindEntityMetadata(Guid uid);

    /// <summary>Найти метаданные по имени сущности</summary>
    /// <param name="className">Имя сущности</param>
    EntityMetadata FindEntityMetadata(string className);

    /// <summary>Получить все метаданные</summary>
    IEnumerable<EntityMetadata> GetEntityMetadataList();

    /// <summary>Отображаемое имя точки расширения</summary>
    string DisplayName { get; }
  }
}
