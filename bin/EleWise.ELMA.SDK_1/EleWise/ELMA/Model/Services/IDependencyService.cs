// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Services.IDependencyService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.UI.Metadata;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Services
{
  /// <summary>Сервис по работе с зависимостями</summary>
  public interface IDependencyService
  {
    /// <summary>Получить зависимости метаданных класса</summary>
    /// <param name="contextMetadata">Контекстные метаданные</param>
    /// <param name="metadata">Метаданные</param>
    /// <param name="forms">Список связанных форм класса</param>
    /// <param name="options">Настройки для анализа зависимостей</param>
    /// <returns>Результат анализа зависимостей</returns>
    MetadataDependencyContainer GetClassMetadataDependencies(
      ClassMetadata contextMetadata,
      IMetadata metadata,
      IEnumerable<FormViewItem> forms,
      DependencyServiceOptions options = null);

    /// <summary>Простой анализ зависимостей формы</summary>
    /// <param name="contextMetadata">Контекстные метаданные</param>
    /// <param name="metadata">Метаданные</param>
    /// <param name="form">Форма</param>
    /// <param name="options">Настройки для анализа зависимостей</param>
    /// <returns>Результат анализа зависимостей</returns>
    DependencyAnalysisResult SimpleFormDependencyAnalysis(
      ClassMetadata contextMetadata,
      IMetadata metadata,
      FormViewItem form,
      DependencyServiceOptions options = null);

    /// <summary>Простой анализ зависимостей функции</summary>
    /// <param name="metadata">Метаданные функции</param>
    /// <param name="options">Настройки для анализа зависимостей</param>
    /// <returns>Результат анализа зависимостей</returns>
    DependencyAnalysisResult SimpleFunctionDependencyAnalysis(
      FunctionMetadata metadata,
      DependencyServiceOptions options = null);

    /// <summary>Проверить функцию на совместимость</summary>
    /// <param name="current">Текущая зависимость</param>
    /// <param name="candidate">Зависимость-кандидат</param>
    /// <returns>Результат совместимости</returns>
    CompatibilityResult CheckFunctionCompatibility(
      FunctionDependency current,
      FunctionDependency candidate);

    /// <summary>Проверить датаклассы на совместимость</summary>
    /// <param name="current">Текущая зависимость</param>
    /// <param name="candidate">Зависимость-кандидат</param>
    /// <returns>Результат совместимости</returns>
    CompatibilityResult CheckDataClassCompatibility(
      DataClassDependency current,
      DataClassDependency candidate);

    /// <summary>Заполнить зависимости метаданных компонента</summary>
    /// <param name="componentMetadata">Метаданные компонента</param>
    /// <param name="ignoredMetadata">Идентифкаторы метаданных, которые нужно проигнорировать</param>
    /// <param name="options">Настройки для анализа зависимостей</param>
    void FillDependencies(
      ComponentMetadata componentMetadata,
      IEnumerable<Guid> ignoredMetadata,
      DependencyServiceOptions options = null);

    /// <summary>Вычисление зависимостей модуля</summary>
    /// <param name="module">Модуль</param>
    /// <param name="ignoredMetadata">Список идентификаторов метаданных, которые нужно проигнорировать</param>
    /// <returns>Зависимости модуля</returns>
    ModuleDependency CalculateDependencies(
      ModuleInfoMetadata module,
      IEnumerable<Guid> ignoredMetadata);
  }
}
