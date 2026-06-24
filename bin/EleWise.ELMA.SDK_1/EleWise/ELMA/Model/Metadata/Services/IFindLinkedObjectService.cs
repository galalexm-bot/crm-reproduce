// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.Services.IFindLinkedObjectService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Model.Metadata.Services
{
  /// <summary>Сервис для поиска связных объектов</summary>
  public interface IFindLinkedObjectService
  {
    /// <summary>Поиск зависимостей по списку объектов</summary>
    /// <param name="searchParams">Параметры поиска связанных объектов.</param>
    LinkedObjectsSearchResult FindLinkedObjects(RuntimeObjectsSearchParams searchParams);

    /// <summary>
    /// Поиск зависимостей по списку объектов с контекстом проверки
    /// </summary>
    /// <param name="searchParams">Параметры поиска связанных объектов с учетом контекста</param>
    LinkedObjectsSearchResult FindLinkedObjects(LinkedObjectsSearchParams searchParams);
  }
}
