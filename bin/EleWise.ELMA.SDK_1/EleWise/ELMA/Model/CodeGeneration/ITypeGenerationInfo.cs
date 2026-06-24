// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.ITypeGenerationInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.MetadataInternalContainer.Containers;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.CodeGeneration
{
  /// <summary>
  /// Дополнительный интерфейс описания типа данных, предоставляющий методы, вызываемые при генерации свойств с данным типом
  /// </summary>
  public interface ITypeGenerationInfo
  {
    /// <summary>Получить ссылку на тип данных для свойства</summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="forFilter">True, если свойство генерируется для фильтра</param>
    /// <returns>Ссылка на тип данных</returns>
    ISyntaxNode GetPropertyTypeReference(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata,
      bool forFilter);

    /// <summary>Получить выражение инициализации свойства</summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="forFilter">Для фильтра</param>
    /// <returns>Выражение</returns>
    ISyntaxNode GetPropertyInitExpression(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata,
      bool forFilter = false);

    /// <summary>Есть ли Getter у свойства</summary>
    bool HasPropertyGetter { get; }

    /// <summary>Есть ли Setter у свойства</summary>
    bool HasPropertySetter { get; }

    /// <summary>Получить список выражений для Getter-а свойства</summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="fieldName">Имя поля в классе, соответствующее данному свойству</param>
    /// <returns>Список выражений. Если возвращается null, используются стандартные выражения.</returns>
    IEnumerable<ISyntaxNode> GetPropertyGetterExpressions(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata,
      string fieldName);

    /// <summary>Получить список выражений для Setter-а свойства</summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="fieldName">Имя поля в классе, соответствующее данному свойству</param>
    /// <returns>Список выражений. Если возвращается null, используются стандартные выражения.</returns>
    IEnumerable<ISyntaxNode> GetPropertySetterExpressions(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata,
      string fieldName);

    /// <summary>Записать в генерируемый тип дополнительные члены</summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <returns>Список выражений</returns>
    IEnumerable<ISyntaxNode> GetAdditionalTypeMembers(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata);

    /// <summary>
    /// Получить контейнер свойства сущности с данными по умолчанию
    /// </summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="forFilter">Для фильтра</param>
    /// <returns></returns>
    IPropertyDefaultValueContainer GetDefaultContainer(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata,
      bool forFilter = false);
  }
}
