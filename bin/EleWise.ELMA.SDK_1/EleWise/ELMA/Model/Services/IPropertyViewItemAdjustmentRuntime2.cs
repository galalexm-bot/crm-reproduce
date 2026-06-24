// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Services.IPropertyViewItemAdjustmentRuntime2
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Model.Services
{
  /// <summary>
  /// Точка расширения для изменения представления свойства перед его отображением
  /// </summary>
  [ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
  public interface IPropertyViewItemAdjustmentRuntime2
  {
    /// <summary>Корректирует представление свойства</summary>
    /// <param name="propertyViewItem">Элемент отображения свойства</param>
    /// <param name="model">Модель</param>
    /// <param name="viewType">Типы представления</param>
    void Adjust(PropertyViewItem propertyViewItem, object model, ViewType viewType);
  }
}
