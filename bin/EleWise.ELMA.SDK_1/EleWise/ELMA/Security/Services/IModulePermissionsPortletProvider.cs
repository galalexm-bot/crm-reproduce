// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Services.IModulePermissionsPortletProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Security.Services
{
  /// <summary>
  /// Интерфейс для добавления ссылки на страницу настройки привилегий модуля
  /// Ссылка отображается на портлете "Доступ приложений"
  /// </summary>
  public interface IModulePermissionsPortletProvider : IModuleSettingsPageProvider
  {
    /// <summary>Отображать ссылку на страницу настройки в портлете</summary>
    bool UseOnPortlet { get; }
  }
}
