// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ComponentModel.IInitHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.ComponentModel
{
  /// <summary>
  /// Интерфейс компонента, поддерживающего методы инициализации
  /// </summary>
  [ExtensionPoint(ComponentType.All)]
  [DeveloperApi(DeveloperApiType.ExtensionPoint)]
  public interface IInitHandler
  {
    /// <summary>
    /// Начало инициализации (могут использоваться свойства ComponentManager.Current и ComponentManager.Builder)
    /// </summary>
    void Init();

    /// <summary>Завершение инициализации (доступен Locator)</summary>
    void InitComplete();
  }
}
