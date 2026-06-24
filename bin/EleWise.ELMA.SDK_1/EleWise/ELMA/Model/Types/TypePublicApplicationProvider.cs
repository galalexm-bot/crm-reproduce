// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.TypePublicApplicationProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.API.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>
  /// Провайдер, которые может изменять доступность типов во внешних приложениях
  /// </summary>
  [Component]
  public abstract class TypePublicApplicationProvider : ITypePublicApplicationProvider
  {
    internal static TypePublicApplicationProvider EvbYxCoyIcCtlBupBQ7K;

    /// <summary>Доступен ли в режиме "Только для чтения"</summary>
    /// <param name="typeUid">Уникальный идентификатор типа</param>
    /// <param name="subTypeUid">Уникальный идентификатор подтипа</param>
    /// <returns>Null, если провайдер не изменяет доступность. True, если тип доступен.</returns>
    public virtual bool? IsPublicApplicationDisplayEnabled(Guid typeUid, Guid subTypeUid) => new bool?();

    /// <summary>Доступен ли в режиме редактирования</summary>
    /// <param name="typeUid">Уникальный идентификатор типа</param>
    /// <param name="subTypeUid">Уникальный идентификатор подтипа</param>
    /// <returns>Null, если провайдер не изменяет доступность. True, если тип доступен</returns>
    public virtual bool? IsPublicApplicationEditorEnabled(Guid typeUid, Guid subTypeUid) => new bool?();

    /// <summary>
    /// Определить доступность отображения свойства во внешних приложениях
    /// </summary>
    /// <param name="classMetadata">Метаданные класса, в котором содержится свойство</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="viewItem">Параметры отображения свойства</param>
    /// <param name="parentPropertyName">Имя родительского свойства</param>
    /// <param name="errors">Текущий спсиок ошибок</param>
    public virtual void CheckPublicApplicationCompatibility(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata,
      PropertyViewItem viewItem,
      string parentPropertyName,
      List<IPublicApplicationCompatibilityError> errors)
    {
    }

    protected TypePublicApplicationProvider()
    {
      TypePublicApplicationProvider.vXIYswoyiep3Xnn3K4Qk();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void vXIYswoyiep3Xnn3K4Qk() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool m5PseKoyVfc7sviYpZUm() => TypePublicApplicationProvider.EvbYxCoyIcCtlBupBQ7K == null;

    internal static TypePublicApplicationProvider fWAPiqoySDoUnTSI1h6T() => TypePublicApplicationProvider.EvbYxCoyIcCtlBupBQ7K;
  }
}
