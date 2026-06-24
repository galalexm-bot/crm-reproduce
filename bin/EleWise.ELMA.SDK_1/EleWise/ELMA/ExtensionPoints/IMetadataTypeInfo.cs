// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExtensionPoints.IMetadataTypeInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using System;

namespace EleWise.ELMA.ExtensionPoints
{
  /// <summary>
  /// Интерфейс компонента, содержащего информацию о типе метаданных
  /// </summary>
  [ExtensionPoint(ComponentType.All)]
  public interface IMetadataTypeInfo
  {
    /// <summary>Имя типа метаданных</summary>
    string Name { get; }

    /// <summary>Описание типа метаданных</summary>
    string Description { get; }

    /// <summary>Тип метаданных</summary>
    Type MetadataType { get; }

    /// <summary>Тип класса генератора</summary>
    Type GeneratorType { get; }
  }
}
