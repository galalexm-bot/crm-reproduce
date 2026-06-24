// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.Public.IPublicMetadataInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Common;
using EleWise.ELMA.Model.Metadata;
using System;

namespace EleWise.ELMA.Services.Public
{
  /// <summary>Информация об объекте метаданных, доступном через API</summary>
  public interface IPublicMetadataInfo
  {
    /// <summary>Уникальный идентификатор</summary>
    Guid Uid { get; }

    /// <summary>Уникальный идентификатор группы</summary>
    Guid GroupUid { get; }

    /// <summary>Имя</summary>
    string Name { get; }

    /// <summary>Отображаемое имя</summary>
    string DisplayName { get; }

    /// <summary>Получить объект метаданных</summary>
    /// <returns></returns>
    IMetadata GetMetadata();

    /// <summary>Обработать дескриптор свойства</summary>
    /// <param name="propMetadata">Метаданные свойства</param>
    /// <param name="propDescriptor">Дескриптор свойства</param>
    void ProcessPropertyDescriptor(
      IPropertyMetadata propMetadata,
      TypeSerializationItemDescriptor propDescriptor);
  }
}
