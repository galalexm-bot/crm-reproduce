// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Models.PortletContentLoadViewModel`2
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.UI.Descriptors;
using EleWise.ELMA.UI.Results;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.UI.Models
{
  /// <summary>Модель первоначальной загрузки портлета</summary>
  /// <typeparam name="TContext"></typeparam>
  public class PortletContentLoadViewModel<TContext, TPersonalization> : 
    PortletContentViewModel<TContext, TPersonalization>,
    IPortletContentLoadViewModel,
    IPortletContentViewModel,
    IFormViewModel
    where TContext : IEntity
    where TPersonalization : IPortletPersonalization
  {
    internal static object xrUX7CBbIxug9iAFAuD5;

    public PortletContentLoadViewModel(
      PortletContentDescriptor descriptor,
      TPersonalization settings)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(descriptor, settings);
      this.Result = (FormResult) new PortletContentLoadResult((IPortletContentLoadViewModel) this);
    }

    public PortletContentLoadViewModel(
      PortletContentDescriptor descriptor,
      TContext context,
      TPersonalization personalization,
      FormViewItem view)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(descriptor, context, personalization, view);
    }

    /// <summary>Построитель представления (формы страницы)</summary>
    public FormViewLoadBuilder<TContext> Form
    {
      get => (FormViewLoadBuilder<TContext>) base.Form;
      protected set => this.Form = (FormViewBuilder<TContext>) value;
    }

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
              this.Form = value != null ? new FormViewLoadBuilder<TContext>((RootViewItem) value, (ClassMetadata) this._descriptor.Metadata.Context) : (FormViewLoadBuilder<TContext>) null;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 0;
              continue;
            case 2:
              base.View = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 1 : 0;
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

    internal static bool i48aINBbVUxog4SiU45a() => PortletContentLoadViewModel<TContext, TPersonalization>.xrUX7CBbIxug9iAFAuD5 == null;

    internal static object lBaqkEBbSgxnw5dVGYWf() => PortletContentLoadViewModel<TContext, TPersonalization>.xrUX7CBbIxug9iAFAuD5;
  }
}
