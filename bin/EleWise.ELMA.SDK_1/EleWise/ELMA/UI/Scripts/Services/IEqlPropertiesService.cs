// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Scripts.Services.IEqlPropertiesService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.DataClasses;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.UI.Scripts.Services
{
  /// <summary>
  /// Сервис для работы с свойствами объекта, вычисляемыми через EQL
  /// </summary>
  public interface IEqlPropertiesService
  {
    /// <summary>
    /// Заполнить свойства объекта, которые вычисляются через EQL
    /// </summary>
    /// <param name="source">Объект</param>
    /// <param name="sourceType">Тип объекта</param>
    /// <param name="properties">Свойства объекта</param>
    /// <param name="additionalModels">Дополнительные модели</param>
    void SetEqlComputedProperties(
      object source,
      Type sourceType,
      IEnumerable<PropertyMetadata> properties,
      List<SerializedModel> additionalModels);

    /// <summary>
    /// Заполнить свойства объекта, которые вычисляются через EQL
    /// </summary>
    /// <param name="source">Объект</param>
    /// <param name="viewModelMetadata">Метаданные модели отображения</param>
    /// <param name="additionalModels">Дополнительные модели</param>
    void SetEqlComputedProperties(
      DataClass source,
      DataClassMetadata viewModelMetadata,
      List<SerializedModel> additionalModels);
  }
}
