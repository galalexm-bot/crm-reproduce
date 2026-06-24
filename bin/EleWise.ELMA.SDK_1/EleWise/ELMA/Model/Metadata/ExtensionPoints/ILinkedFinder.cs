// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.ExtensionPoints.ILinkedFinder
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Metadata.ExtensionPoints
{
  /// <summary>Точка расширения для поиска связанных объектов</summary>
  [ExtensionPoint(ComponentType.Server)]
  public interface ILinkedFinder
  {
    /// <summary>Поиск связанных объектов</summary>
    /// <param name="objectsToSearching">Объекты для проверки на связность</param>
    /// <param name="context">Контекст проверки</param>
    /// <returns>Список найденных и добавленных зависимостей</returns>
    FindLinkedObjectsResult FindLinkedObjects(
      ICollection<ILinkedObject> objectsToSearching,
      LinkedObjectsContext context);

    /// <summary>Поиск связанных объектов без ограничений контекста</summary>
    /// <param name="objectsToSearching">Объекты для проверки на связность</param>
    /// <param name="emptyContext">Контекст проверки без предварительной загрузки ограничений</param>
    /// <returns>Список найденных и добавленных зависимостей</returns>
    FindLinkedObjectsResult FindLinkedObjects(
      ICollection<ILinkedObject> objectsToSearching,
      RuntimeObjectsContext emptyContext);
  }
}
