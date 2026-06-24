// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.IUniqueFilterExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using System;

namespace EleWise.ELMA.Extensions
{
  /// <summary>
  /// Интерфейс точки расширения для получения типа уникального фильтра.
  /// </summary>
  [ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
  public interface IUniqueFilterExtension
  {
    /// <summary>Uid точки расширения.</summary>
    Guid Uid { get; }

    /// <summary>Возвращает тип фильтра.</summary>
    Type FilterType { get; }

    /// <summary>Возвращает тип сущности для данного фильтра.</summary>
    Type EntityType { get; }
  }
}
