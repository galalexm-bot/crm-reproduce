// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Model.IFullTextSearchObjectContainer
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using System.Dynamic;

namespace EleWise.ELMA.FullTextSearch.Model
{
  /// <summary>
  /// Обертка передачи информации об объекте в полнотекстовом поиске
  /// </summary>
  public interface IFullTextSearchObjectContainer
  {
    /// <summary>Объект индексации</summary>
    IFullTextSearchObject SearchObject { get; set; }

    /// <summary>Индексируемый объект</summary>
    IEntity IndexedObject { get; set; }

    /// <summary>Runtime-свойства</summary>
    ExpandoObject Properties { get; set; }
  }
}
