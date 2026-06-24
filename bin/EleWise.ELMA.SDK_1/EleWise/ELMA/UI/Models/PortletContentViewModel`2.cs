// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Models.PortletContentViewModel`2
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.UI.Descriptors;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Models
{
  /// <summary>Модель содержимого портлета</summary>
  /// <typeparam name="TContext">Тип контекста</typeparam>
  public class PortletContentViewModel<TContext, TPersonalization> : 
    FormViewModel<TContext>,
    IPortletContentViewModel,
    IFormViewModel
    where TContext : IEntity
    where TPersonalization : IPortletPersonalization
  {
    internal static object sm1GiUBbiL2iDixM9pBY;

    public PortletContentViewModel(PortletContentDescriptor descriptor, TPersonalization settings)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector((IFormPartDescriptor) descriptor);
      Contract.ArgumentNotNull((object) settings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1598106783 - -968262081 ^ -629817428));
      this.Settings = settings;
    }

    public PortletContentViewModel(
      PortletContentDescriptor descriptor,
      TContext context,
      TPersonalization settings,
      FormViewItem view)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector((IFormPartDescriptor) descriptor, context, view);
      this.Settings = settings;
    }

    public TPersonalization Settings { get; private set; }

    public PortletContentDescriptor PortletContentDescriptor => (PortletContentDescriptor) this.Descriptor;

    IPortletPersonalization IPortletContentViewModel.Settings => (IPortletPersonalization) this.Settings;

    internal static bool THcPXUBbR5cHCcTQnaOk() => PortletContentViewModel<TContext, TPersonalization>.sm1GiUBbiL2iDixM9pBY == null;

    internal static object S6gsYaBbqMqc2en6E8pN() => PortletContentViewModel<TContext, TPersonalization>.sm1GiUBbiL2iDixM9pBY;
  }
}
