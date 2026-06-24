// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Models.PageViewModel`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.UI.Descriptors;
using EleWise.ELMA.UI.Results;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.UI.Models
{
  /// <summary>Модель страницы</summary>
  /// <typeparam name="TContext">Тип контекста</typeparam>
  public class PageViewModel<TContext> : FormViewModel<TContext>, IPageViewModel, IFormViewModel where TContext : IEntity
  {
    private static object LVSHOJBb8TPUbO213bjS;

    /// <summary>Ctor</summary>
    /// <param name="descriptor">Дескриптор контента страницы</param>
    public PageViewModel(PageContentDescriptor descriptor)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(descriptor, (PropertyViewInfoContainer) null);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="descriptor">Дескриптор контента страницы</param>
    /// <param name="propertyContainer">Контейнер информации о свойствах на форме</param>
    public PageViewModel(
      PageContentDescriptor descriptor,
      PropertyViewInfoContainer propertyContainer)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector((IFormPartDescriptor) descriptor, propertyContainer);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="descriptor">Дескриптор контента страницы</param>
    /// <param name="context">Контекст</param>
    /// <param name="view">Форма</param>
    public PageViewModel(PageContentDescriptor descriptor, TContext context, FormViewItem view)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(descriptor, context, view, (PropertyViewInfoContainer) null);
    }

    /// <summary>Ctor</summary>
    /// <param name="descriptor">Дескриптор контента страницы</param>
    /// <param name="context">Контекст</param>
    /// <param name="view">Форма</param>
    /// <param name="propertyContainer">Контейнер информации о свойствах на форме</param>
    public PageViewModel(
      PageContentDescriptor descriptor,
      TContext context,
      FormViewItem view,
      PropertyViewInfoContainer propertyContainer)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector((IFormPartDescriptor) descriptor, context, view, propertyContainer);
    }

    /// <summary>Перенаправить на указанную страницу конфигурации</summary>
    /// <param name="pageId">Идентификатор страницы</param>
    public void RedirectToPage(string pageId)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Result = (FormResult) new RedirectToPageResult(pageId);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Перенаправить на указанный адрес</summary>
    /// <param name="url">Адрес</param>
    public void RedirectToUrl(string url)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Result = (FormResult) new RedirectToUrlResult(url);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    PageContentDescriptor IPageViewModel.PageContentDescriptor => (PageContentDescriptor) this.Descriptor;

    internal static bool dwjkQoBbZoVNSALtDXnu() => PageViewModel<TContext>.LVSHOJBb8TPUbO213bjS == null;

    internal static object WfjdZdBbuloLQLwHhI0j() => PageViewModel<TContext>.LVSHOJBb8TPUbO213bjS;
  }
}
