// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Globalization.ExtensionPoints.IExportLocalizationFileExtensionPoint
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Globalization.Models;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Globalization.ExtensionPoints
{
  /// <summary>
  /// Точка расширения шагов визарда выгрузки файлов локализации конфигурации
  /// </summary>
  [ExtensionPoint(ComponentType.All)]
  public interface IExportLocalizationFileExtensionPoint
  {
    /// <summary>Уникальный идентификатор</summary>
    Guid Uid { get; }

    /// <summary>Заголовок шага визарда</summary>
    string Header { get; }

    /// <summary>
    /// Словарь соответствия уникальных идентификаторов и названий вкладок на странице шага визарда
    /// </summary>
    /// <remarks>
    /// Уникальный идентификаторы должны быть вида "00000000000000000000000000000000"
    /// т.е. Guid.ToString("N"), т.к. эти идентификаторы используются при отображении панелей
    /// </remarks>
    IDictionary<string, string> Tabs { get; }

    /// <summary>
    /// Получить объект локализации из списка локализуемых объектов
    /// </summary>
    /// <param name="settingsJsonData">список локализуемых объектов</param>
    /// <returns>Объект локализации</returns>
    /// <remarks>
    /// Под объектом локализации понимается объект GlobalizationSettings,
    /// соответствующий своей реализации данной точки расширения
    /// </remarks>
    object GetSettingObj(IDictionary<string, string> settingsJsonData);

    /// <summary>Получить все данные для локализации</summary>
    /// <returns>Словарь соответствия названия типа локализуемых данных и списка локализуемых объектов этого типа</returns>
    IDictionary<string, IEnumerable<LocalizableData>> GetAllData();
  }
}
