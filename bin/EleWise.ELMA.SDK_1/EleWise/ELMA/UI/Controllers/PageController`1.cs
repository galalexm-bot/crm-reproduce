// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Controllers.PageController`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.UI.Controllers
{
  /// <summary>Базовый контроллер страницы</summary>
  /// <typeparam name="TIndexModel">Тип модели основной формы страницы</typeparam>
  public abstract class PageController<TIndexModel> where TIndexModel : IEntity
  {
    internal static object e8VGhmJqkFyLrOGOHgV;

    /// <summary>Загрузка основной формы страницы</summary>
    /// <param name="page">Модель страницы</param>
    public abstract void Index_Load(PageLoadViewModel<TIndexModel> page);

    protected PageController()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool x40ZMlJKfIYHhBMkoPf() => PageController<TIndexModel>.e8VGhmJqkFyLrOGOHgV == null;

    internal static object pceWuPJXmjFWvq0Ul6C() => PageController<TIndexModel>.e8VGhmJqkFyLrOGOHgV;
  }
}
