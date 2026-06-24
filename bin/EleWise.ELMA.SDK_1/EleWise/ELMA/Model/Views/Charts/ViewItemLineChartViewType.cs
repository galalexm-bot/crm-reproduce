// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.Charts.ViewItemLineChartViewType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Model.Views.Charts
{
  /// <summary>Вид отображения линейной диаграммы</summary>
  public enum ViewItemLineChartViewType
  {
    /// <summary>Сглаживание линий</summary>
    MonotoreX,
    /// <summary>Без сглаживания</summary>
    Linear,
    /// <summary>Интерполяция шагов в начале</summary>
    StepAfter,
    /// <summary>Интерполяция шагов в середине</summary>
    Step,
    /// <summary>Интерполяция шагов в конце</summary>
    StepBefore,
  }
}
