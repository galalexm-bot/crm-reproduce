// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.Charts.IChartViewItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;

namespace EleWise.ELMA.Model.Views.Charts
{
  /// <summary>Карточка</summary>
  internal interface IChartViewItem : IDynamicViewItem, IViewItemWithPropertyParents
  {
    /// <summary>Заголовок</summary>
    string Title { get; set; }

    /// <summary>Идентификатор свойства с значением</summary>
    Guid ValueUid { get; set; }

    /// <summary>Идентификатор свойства с наименованием</summary>
    Guid NameUid { get; set; }

    /// <summary>Вид отображения легенды</summary>
    ViewItemChartLegendViewType LegendViewType { get; set; }
  }
}
