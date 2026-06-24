// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.ExtensionPoints.IFullTextSearchModuleSettingsRender
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.FullTextSearch.Settings;
using EleWise.ELMA.Runtime.Settings;
using System.Web.Mvc;

namespace EleWise.ELMA.FullTextSearch.ExtensionPoints
{
  /// <summary>
  /// Интерфейс точки расширения отображения и редактирования настроек модуля полнотекстового поиска
  /// </summary>
  [ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
  public interface IFullTextSearchModuleSettingsRender
  {
    bool IsSupported(IFullTextSearchModuleSettings settings);

    /// <summary>Отобразить представление только для чтения</summary>
    MvcHtmlString RenderDisplay(HtmlHelper html);

    /// <summary>
    /// Отобразить представление для редактирования (уже внутри формы)
    /// </summary>
    MvcHtmlString RenderEdit(HtmlHelper html);

    /// <summary>Сохранить настройки из текущего контекста</summary>
    FullTextSettingsSaveResult SaveSettings(ControllerContext context);

    IGlobalSettingsModule Module { get; }
  }
}
