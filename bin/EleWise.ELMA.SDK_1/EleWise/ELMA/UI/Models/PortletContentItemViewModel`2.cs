// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Models.PortletContentItemViewModel`2
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Models
{
  /// <summary>Модель элемента содержимого портлета</summary>
  /// <typeparam name="TContext">Тип контекста</typeparam>
  public class PortletContentItemViewModel<TContext, TPersonalization> : IPortletContentItemViewModel
    where TContext : IEntity
    where TPersonalization : IPortletPersonalization
  {
    private RootViewItem _view;
    internal static object q8qtCHBbKW2cjygSaeg2;

    public PortletContentItemViewModel(
      TContext context,
      TPersonalization settings,
      RootViewItem view)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      Contract.ArgumentNotNull((object) context, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138941458));
      Contract.ArgumentNotNull((object) settings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(589593376 ^ -1977315327 ^ -1459617361));
      Contract.ArgumentNotNull((object) view, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317734830));
      this.Context = context;
      this.Settings = settings;
      this._view = view;
      EntityMetadata metadata = (EntityMetadata) MetadataLoader.LoadMetadata(context.GetType());
      this.Form = new FormViewBuilder<TContext>(view, (ClassMetadata) metadata);
    }

    /// <summary>Контекст</summary>
    public TContext Context { get; private set; }

    /// <summary>Настройки</summary>
    public TPersonalization Settings { get; private set; }

    /// <summary>Построитель представления (формы страницы)</summary>
    public FormViewBuilder<TContext> Form { get; protected set; }

    IEntity IPortletContentItemViewModel.Context => (IEntity) this.Context;

    IPortletPersonalization IPortletContentItemViewModel.Settings => (IPortletPersonalization) this.Settings;

    RootViewItem IPortletContentItemViewModel.View => this.View;

    /// <summary>Представление (форма страницы)</summary>
    protected virtual RootViewItem View => this._view;

    internal static bool XoBdFBBbXGs0xOy5cHao() => PortletContentItemViewModel<TContext, TPersonalization>.q8qtCHBbKW2cjygSaeg2 == null;

    internal static object hKsxAIBbTDmCneTyDebS() => PortletContentItemViewModel<TContext, TPersonalization>.q8qtCHBbKW2cjygSaeg2;
  }
}
