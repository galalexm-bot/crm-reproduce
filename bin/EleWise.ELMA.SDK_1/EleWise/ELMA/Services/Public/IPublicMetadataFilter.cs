// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.Public.IPublicMetadataFilter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using System;

namespace EleWise.ELMA.Services.Public
{
  /// <summary>
  /// Точка расширения для фильтрации метаданных, доступных через публичные сервисы
  /// </summary>
  [ExtensionPoint(ComponentType.Server)]
  public interface IPublicMetadataFilter
  {
    /// <summary>Функция фильтрации метаданных</summary>
    Func<IMetadata, bool> Filter { get; }
  }
}
