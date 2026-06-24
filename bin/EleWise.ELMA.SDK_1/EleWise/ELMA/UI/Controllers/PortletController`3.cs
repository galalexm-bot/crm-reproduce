// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Controllers.PortletController`3
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.UI.Controllers
{
  /// <summary>Базовый контроллер портлета</summary>
  /// <typeparam name="TContentModel">Тип модели содержимого портлета</typeparam>
  /// <typeparam name="TPersonalization">Тип настроек персонализации</typeparam>
  /// <typeparam name="TSettingsModel">Тип модели формы настроек портлета</typeparam>
  public abstract class PortletController<TContentModel, TPersonalization, TSettingsModel>
    where TContentModel : IEntity
    where TPersonalization : IPortletPersonalization
    where TSettingsModel : IPortletSettings
  {
    internal static object RNRU7VJZpVGyjDp3Q22;

    /// <summary>Загрузка содержимого портлета</summary>
    /// <param name="portlet">Модель портлета</param>
    public abstract void Content_Load(
      PortletContentLoadViewModel<TContentModel, TPersonalization> portlet);

    protected PortletController()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool KsHpGWJumLwFIRr37wb() => PortletController<TContentModel, TPersonalization, TSettingsModel>.RNRU7VJZpVGyjDp3Q22 == null;

    internal static object cZ1gHYJIvXYJSwnCR7m() => PortletController<TContentModel, TPersonalization, TSettingsModel>.RNRU7VJZpVGyjDp3Q22;
  }
}
