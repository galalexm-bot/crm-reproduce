// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Services.IModuleSettingsPageProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System.Web.Mvc;

namespace EleWise.ELMA.Security.Services
{
  /// <summary>
  /// Обобщенный интерфейс для добавления ссылки на страницы настроек модулей
  /// </summary>
  public interface IModuleSettingsPageProvider
  {
    /// <summary>Идентификатор модуля</summary>
    string ModuleUid { get; }

    /// <summary>Адрес страницы настройки модуля</summary>
    string Url(UrlHelper urlHelper);

    /// <summary>Изображение для списка</summary>
    string Image { get; }

    /// <summary>Текст ссылки</summary>
    string Text { get; }

    /// <summary>Описание ссылки</summary>
    string Description { get; }
  }
}
