// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Services.ISearchFormService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Services.Models;

namespace EleWise.ELMA.Model.Services
{
  /// <summary>Сервис поиска форм</summary>
  public interface ISearchFormService
  {
    /// <summary>Получить форму сущности</summary>
    /// <param name="searchForm">Модель поиска формы</param>
    /// <returns>Модель формы сущности</returns>
    EntityFormView GetEntityForm(SearchForm searchForm);

    /// <summary>Обработать форму сущности</summary>
    /// <param name="entityForm">Модель обработки формы</param>
    /// <returns>Модель формы сущности</returns>
    EntityFormView ProcessEntityForm(EntityForm entityForm);
  }
}
