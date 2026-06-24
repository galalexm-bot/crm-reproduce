// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Services.IModulePermissionsPageProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Security.Services
{
  /// <summary>
  /// Интерфейс для добавления ссылки на страницу настройки привилегий модуля
  /// Ссылка отображается на странице "Настройки доступа" /Security/PermissionManagment
  /// </summary>
  [ExtensionPoint(ServiceScope.Shell, ComponentType.Web)]
  public interface IModulePermissionsPageProvider : IModuleSettingsPageProvider
  {
  }
}
