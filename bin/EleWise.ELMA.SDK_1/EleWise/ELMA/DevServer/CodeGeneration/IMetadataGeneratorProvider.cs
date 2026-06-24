// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.DevServer.CodeGeneration.IMetadataGeneratorProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;

namespace EleWise.ELMA.DevServer.CodeGeneration
{
  /// <summary>
  /// Провайдер генераторов кода по типу метаданных. Исключительно для генерации DynamicModel на DevServer.
  /// </summary>
  [Obsolete("Не использовать! Указанный API не зафиксирован и может быть изменен или удален в любой момент!", false)]
  public interface IMetadataGeneratorProvider
  {
    /// <summary>Тип метаданных</summary>
    Type MetadataType { get; }

    /// <summary>Тип класса генератора</summary>
    Type GeneratorType { get; }
  }
}
