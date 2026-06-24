// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Models.PageItemViewModel`1
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
  /// <summary>Модель элемента страницы</summary>
  /// <typeparam name="TContext">Тип контекста</typeparam>
  public class PageItemViewModel<TContext> : IPageItemViewModel where TContext : IEntity
  {
    private RootViewItem _view;
    private static object vEo04BBbGanimCkpsWte;

    public PageItemViewModel(TContext context, RootViewItem view)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      Contract.ArgumentNotNull((object) context, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1021410165 ^ 1021394787));
      Contract.ArgumentNotNull((object) view, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2092274397 << 4 ^ 883308722));
      this.Context = context;
      this._view = view;
      EntityMetadata metadata = (EntityMetadata) MetadataLoader.LoadMetadata(context.GetType());
      this.Form = new FormViewBuilder<TContext>(view, (ClassMetadata) metadata);
    }

    /// <summary>Контекст (данные страницы)</summary>
    public TContext Context { get; private set; }

    /// <summary>Построитель представления (формы страницы)</summary>
    public FormViewBuilder<TContext> Form { get; protected set; }

    IEntity IPageItemViewModel.Context => (IEntity) this.Context;

    RootViewItem IPageItemViewModel.View => this.View;

    /// <summary>Представление (форма страницы)</summary>
    protected virtual RootViewItem View => this._view;

    internal static bool TY08O3BbE4k2pEvcAkJU() => PageItemViewModel<TContext>.vEo04BBbGanimCkpsWte == null;

    internal static object fpoctxBbfd6NZvO6c6T1() => PageItemViewModel<TContext>.vEo04BBbGanimCkpsWte;
  }
}
