// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExtensionPoints.IFormViewItemTransformate
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.ExtensionPoints
{
  /// <summary>
  /// Точка расширения для преобразования представления формы перед ее отображением
  /// </summary>
  [ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
  public interface IFormViewItemTransformate
  {
    /// <summary>
    /// Возращает трансформированную форму, или ту-же самую, если трансформация не нужна
    /// </summary>
    FormViewItem Transformate(FormViewItem formViewItem, object model);
  }
}
