// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Models.PageLoadViewModel`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Model.Views.Toolbar;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.UI.Descriptors;
using EleWise.ELMA.UI.Results;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.UI.Models
{
  /// <summary>Модель первоначальной загрузки страницы</summary>
  /// <typeparam name="TContext"></typeparam>
  public class PageLoadViewModel<TContext> : 
    PageViewModel<TContext>,
    IPageLoadViewModel,
    IPageViewModel,
    IFormViewModel
    where TContext : IEntity
  {
    private static object VX5QcvBbQE025FaNv14l;

    /// <summary>Ctor</summary>
    /// <param name="descriptor">Дескриптор контента страницы</param>
    public PageLoadViewModel(PageContentDescriptor descriptor)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(descriptor, (PropertyViewInfoContainer) null);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="descriptor">Дескриптор контента страницы</param>
    /// <param name="propertyContainer">Контейнер информации о свойствах на форме</param>
    public PageLoadViewModel(
      PageContentDescriptor descriptor,
      PropertyViewInfoContainer propertyContainer)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(descriptor, propertyContainer);
      int num = 2;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_6;
          case 1:
            this.PageLoadViewModelToolbar = descriptor.Metadata.View.Toolbar == null ? (EleWise.ELMA.Model.Views.Toolbar.Toolbar) null : ClassSerializationHelper.CloneObjectByXml<EleWise.ELMA.Model.Views.Toolbar.Toolbar>(descriptor.Metadata.View.Toolbar);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
            continue;
          case 2:
            this.Result = (FormResult) new PageLoadResult((IPageLoadViewModel) this);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 1;
            continue;
          default:
            goto label_3;
        }
      }
label_6:
      return;
label_3:;
    }

    /// <summary>Ctor</summary>
    /// <param name="descriptor">Дескриптор контента страницы</param>
    /// <param name="context">Контекст</param>
    /// <param name="view">Форма</param>
    public PageLoadViewModel(PageContentDescriptor descriptor, TContext context, FormViewItem view)
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
    public PageLoadViewModel(
      PageContentDescriptor descriptor,
      TContext context,
      FormViewItem view,
      PropertyViewInfoContainer propertyContainer)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(descriptor, context, view, propertyContainer);
      this.PageLoadViewModelToolbar = descriptor.Metadata.View.Toolbar != null ? ClassSerializationHelper.CloneObjectByXml<EleWise.ELMA.Model.Views.Toolbar.Toolbar>(descriptor.Metadata.View.Toolbar) : (EleWise.ELMA.Model.Views.Toolbar.Toolbar) null;
    }

    /// <summary>Построитель представления (формы страницы)</summary>
    public FormViewLoadBuilder<TContext> Form
    {
      get => (FormViewLoadBuilder<TContext>) base.Form;
      protected set => this.Form = (FormViewBuilder<TContext>) value;
    }

    /// <summary>Построитель представления (формы страницы)</summary>
    public ToolbarLoadBuilder<TContext> Toolbar { get; protected set; }

    protected override FormViewItem View
    {
      get => base.View;
      set
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.Form = value != null ? new FormViewLoadBuilder<TContext>((RootViewItem) value, (ClassMetadata) this._descriptor.Metadata.Context, this.PropertyContainer) : (FormViewLoadBuilder<TContext>) null;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
              continue;
            case 2:
              base.View = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 1 : 1;
              continue;
            default:
              goto label_5;
          }
        }
label_2:
        return;
label_5:;
      }
    }

    protected EleWise.ELMA.Model.Views.Toolbar.Toolbar PageLoadViewModelToolbar
    {
      get => this.Toolbar.Toolbar;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.Toolbar = new ToolbarLoadBuilder<TContext>(value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    internal static bool RQw8kRBbCsSaxkKODpCZ() => PageLoadViewModel<TContext>.VX5QcvBbQE025FaNv14l == null;

    internal static object Dwn9dOBbvphKBk6CgpSO() => PageLoadViewModel<TContext>.VX5QcvBbQE025FaNv14l;
  }
}
