// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.ICompositeMetadata
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Метаданные составной сущности</summary>
  public interface ICompositeMetadata : IMetadata, IXsiType
  {
    /// <summary>Получить метаданные составных частей</summary>
    /// <returns>Метаданные составных частей</returns>
    IEnumerable<IMetadata> GetCompositeParts();
  }
}
