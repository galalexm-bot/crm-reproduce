// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.Public.IPublicMetadataGroupInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;

namespace EleWise.ELMA.Services.Public
{
  /// <summary>
  /// Информация о группе объектов метаданных, доступных через API
  /// </summary>
  public interface IPublicMetadataGroupInfo
  {
    /// <summary>Уникальный идентификатор группы</summary>
    Guid GroupUid { get; }

    /// <summary>Порядок (для сортировки групп)</summary>
    int Order { get; }

    /// <summary>Отображаемое имя</summary>
    string DisplayName { get; }
  }
}
