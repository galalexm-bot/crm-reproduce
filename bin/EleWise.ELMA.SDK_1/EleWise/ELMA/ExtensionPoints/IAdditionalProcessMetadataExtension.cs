// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExtensionPoints.IAdditionalProcessMetadataExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.ExtensionPoints
{
  /// <summary>
  /// Точка расширения для обработки дополнительных метаданных
  /// </summary>
  [ExtensionPoint(ComponentType.All)]
  public interface IAdditionalProcessMetadataExtension
  {
    /// <summary>Проверка реализации</summary>
    /// <param name="propertyMetadata">Метаданные свойств класса</param>
    /// <returns>Результат</returns>
    bool Check(IPropertyMetadata propertyMetadata);

    /// <summary>Обработать дополнительные метаданные</summary>
    /// <param name="propertyMetadata">Метаданные свойства класса</param>
    /// <param name="currentModuleUid">Идентификатор модуля</param>
    /// <param name="options">Настройки для анализа зависимостей</param>
    /// <param name="enumDependencies">Зависимости от перечислений</param>
    /// <param name="entityDependencies">Зависимости от сущностей</param>
    /// <param name="dataClassDependencies">Зависимости от Структур обмена данными</param>
    void ProcessMetadata(
      IPropertyMetadata propertyMetadata,
      Guid currentModuleUid,
      DependencyServiceOptions options,
      Dictionary<Guid, EnumDependency> enumDependencies,
      Dictionary<Guid, EntityDependency> entityDependencies,
      Dictionary<Guid, DataClassDependency> dataClassDependencies);
  }
}
