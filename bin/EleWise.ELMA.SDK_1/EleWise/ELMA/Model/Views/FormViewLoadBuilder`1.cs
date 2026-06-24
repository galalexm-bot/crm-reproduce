// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.FormViewLoadBuilder`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views
{
  public class FormViewLoadBuilder<TModel> : FormViewBuilder<TModel>
  {
    private static object vF8n7vokS2Lf5TQw4HEx;

    /// <summary>Ctor</summary>
    /// <param name="view">Представление</param>
    /// <param name="metadata">Метаданные</param>
    public FormViewLoadBuilder(RootViewItem view, ClassMetadata metadata)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(view, metadata);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="view">Представление</param>
    /// <param name="metadata">Метаданные</param>
    /// <param name="propertyContainer">Контейнер информации о свойствах на форме</param>
    public FormViewLoadBuilder(
      RootViewItem view,
      ClassMetadata metadata,
      PropertyViewInfoContainer propertyContainer)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(view, metadata, propertyContainer);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool gDXkrMokieKl8694HlUs() => FormViewLoadBuilder<TModel>.vF8n7vokS2Lf5TQw4HEx == null;

    internal static object KOfS9JokRPJec8cD3Kmv() => FormViewLoadBuilder<TModel>.vF8n7vokS2Lf5TQw4HEx;
  }
}
