// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Export.ExtensionPoints.IConfigExportExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Deploy.Export.ExtensionPoints
{
  /// <summary>Интерфейс экспорта объектов определенного типа</summary>
  [ExtensionPoint(ComponentType.All)]
  public interface IConfigExportExtension
  {
    /// <summary>
    /// Получить новый объект с настройками экспорта реализации точки расширения
    /// </summary>
    /// <returns></returns>
    Dictionary<Guid, object> GetNewSettingObj();

    /// <summary>
    /// Добавить в списке объектов экспорта объекты из расширения, которые будут экспортированы
    /// </summary>
    /// <param name="parameters">Параметры выгрузки объектов</param>
    void AddExportObjects(ExportExtensionParams parameters);
  }
}
