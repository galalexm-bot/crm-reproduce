// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Helpers.INHibernatePropertiesMapper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Types.Settings;
using System;

namespace EleWise.ELMA.Helpers
{
  /// <summary>Интерфейс формирования свойств NHibernate маппинга</summary>
  public interface INHibernatePropertiesMapper
  {
    /// <summary>Свойство</summary>
    /// <param name="name">Имя свойства</param>
    /// <param name="columnName">Имя колонки в базе</param>
    /// <param name="propertyTypeBuilder">Формирование типа свойства</param>
    /// <param name="notNull">Not null</param>
    /// <param name="formula">sql-формула</param>
    /// <param name="sqlType">sql-тип</param>
    void Property(
      string name,
      string columnName = null,
      Action<INHibernatePropertyTypeMapper> propertyTypeBuilder = null,
      bool notNull = true,
      string formula = null,
      string sqlType = null);

    /// <summary>Ссылка на сущность</summary>
    /// <param name="name">Имя свойства</param>
    /// <param name="columnName">Имя колонки в базе</param>
    /// <param name="cascadeMode">Тип режима поведения дочерних сущностей при операции удаления, сохранения изменений</param>
    void ManyToOne(string name, string columnName = null, CascadeMode cascadeMode = CascadeMode.None);

    /// <summary>Коллекция один-ко-многим</summary>
    /// <param name="name">Имя свойства</param>
    /// <param name="tableName">Имя таблицы</param>
    /// <param name="keyColumn">Имя ключевой колонки</param>
    /// <param name="cascadeMode">Тип режима поведения дочерних сущностей при операции удаления, сохранения изменений</param>
    /// <param name="batchSize">batchSize</param>
    /// <param name="comparerType">Тип сравнивателя для сортированных коллекций</param>
    void OneToManyCollection(
      string name,
      string tableName,
      string keyColumn,
      CascadeMode cascadeMode,
      int batchSize,
      Type comparerType);

    /// <summary>Коллекция многие-ко-многим</summary>
    /// <param name="name">Имя свойства</param>
    /// <param name="tableName">Имя таблицы связи</param>
    /// <param name="parentKeyColumn">Имя родительской колонки</param>
    /// <param name="childKeyColumn">Имя дочерней колонки</param>
    /// <param name="cascadeMode">Тип режима поведения дочерних сущностей при операции удаления, сохранения изменений</param>
    /// <param name="batchSize">batchSize</param>
    /// <param name="comparerType">Тип сравнивателя для сортированных коллекций</param>
    /// <param name="inverse">Многие-ко-многим инферсия</param>
    void ManyToManyCollection(
      string name,
      string tableName,
      string parentKeyColumn,
      string childKeyColumn,
      CascadeMode cascadeMode,
      int batchSize,
      Type comparerType,
      bool inverse = false);

    /// <summary>Set-коллекция многие-ко-многим</summary>
    /// <param name="name">Имя свойства</param>
    /// <param name="tableName">Имя таблицы связи</param>
    /// <param name="parentKeyColumn">Имя родительской колонки</param>
    /// <param name="childKeyColumn">Имя дочерней колонки</param>
    /// <param name="cascadeMode">Тип режима поведения дочерних сущностей при операции удаления, сохранения изменений</param>
    /// <param name="batchSize">batchSize</param>
    /// <param name="comparerType">Тип сравнивателя для сортированных коллекций</param>
    /// <param name="propertyTypeBuilder">Построитель типа для свойства</param>
    void Set(
      string name,
      string tableName,
      string parentKeyColumn,
      string childKeyColumn,
      CascadeMode cascadeMode,
      int batchSize,
      Type comparerType,
      Action<INHibernatePropertyTypeMapper> propertyTypeBuilder = null);
  }
}
