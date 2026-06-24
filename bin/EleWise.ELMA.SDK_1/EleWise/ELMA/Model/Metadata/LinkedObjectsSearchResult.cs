// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.LinkedObjectsSearchResult
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Результат поиска связанных объектов</summary>
  public class LinkedObjectsSearchResult
  {
    /// <summary>Найденные объекты</summary>
    public ICollection<ILinkedObject> FindedObjects { get; }

    /// <summary>Ctor</summary>
    /// <param name="findedObjects">Список найденных объектов</param>
    public LinkedObjectsSearchResult(ICollection<ILinkedObject> findedObjects)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.FindedObjects = findedObjects;
    }
  }
}
