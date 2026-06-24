// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExtensionPoints.IDbUpdateHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Runtime.Db;
using System;

namespace EleWise.ELMA.ExtensionPoints
{
  /// <summary>
  /// Точка расширения для обработки действий при преобразовании структуры БД
  /// </summary>
  [DeveloperApi(DeveloperApiType.ExtensionPoint)]
  [ExtensionPoint(ComponentType.Server)]
  public interface IDbUpdateHandler
  {
    /// <summary>
    /// Uid провайдера, для которого предназначается расширение (соответсвует <see cref="P:EleWise.ELMA.IProvider.Uid" />)
    /// </summary>
    /// <remarks>
    /// Если равен Guid.Empty, то применяется для всех провайдеров
    /// </remarks>
    Guid ProviderUid { get; }

    /// <summary>Создать структуры, необходимые для инициализации</summary>
    void CreateInitialStructures();

    /// <summary>Инициализация</summary>
    void Init();

    /// <summary>Определяет, есть ли изменения в структуре</summary>
    bool HasChanges { get; }

    /// <summary>
    /// Нужно ли пересоздавать все ограничения, индексы и внешние ключи
    /// </summary>
    bool NeedRecreateConstraints { get; }

    /// <summary>Начало преобразования</summary>
    /// <param name="parameters">Параметры</param>
    void OnStart(DbUpdateParameters parameters);

    /// <summary>Перед удалением триггеров</summary>
    /// <param name="e">Параметры события</param>
    void OnTriggersDeleting(TriggersDeletingEventArgs e);

    /// <summary>После удаления триггеров</summary>
    void OnTriggersDeleted();

    /// <summary>Перед удалением процедур и функций</summary>
    /// <param name="e">Параметры события</param>
    void OnProceduresDeleting(ProceduresDeletingEventArgs e);

    /// <summary>После удаления процедур и функций</summary>
    void OnProceduresDeleted();

    /// <summary>Перед удалением представлений</summary>
    /// <param name="e">Параметры события</param>
    void OnViewsDeleting(ViewsDeletingEventArgs e);

    /// <summary>После удаления представлений</summary>
    void OnViewsDeleted();

    /// <summary>Перед удалением индексов</summary>
    /// <param name="e">Параметры события</param>
    void OnIndexesDeleting(IndexesDeletingEventArgs e);

    /// <summary>После удаления индексов</summary>
    void OnIndexesDeleted();

    /// <summary>Перед удалением внешних ключей</summary>
    /// <param name="e">Параметры события</param>
    void OnForeignKeysDeleting(ForeginKeysDeletingEventArgs e);

    /// <summary>После удаления внешних ключей</summary>
    void OnForeignKeysDeleted();

    /// <summary>Перед удалением внешних ключей</summary>
    /// <param name="e">Параметры события</param>
    void OnPrimaryKeysDeleting(PrimaryKeysDeletingEventArgs e);

    /// <summary>
    /// После удаления первичных ключей (только для некоторых баз, например, Оракл)
    /// </summary>
    void OnPrimaryKeysDeleted();

    /// <summary>Перед созданием/преобразованием таблиц и колонок</summary>
    /// <param name="e">Параметры события</param>
    void OnTablesCreating(TablesCreatingEventArgs e);

    /// <summary>После создания/преобразования таблиц и колонок</summary>
    void OnTablesCreated();

    /// <summary>Перед удалением таблиц и колонок</summary>
    /// <param name="e">Параметры события</param>
    void OnTablesDeleting(TablesDeletingEventArgs e);

    /// <summary>После удаления таблиц и колонок</summary>
    void OnTablesDeleted();

    /// <summary>Перед созданием внешних ключей</summary>
    /// <param name="e">Параметры события</param>
    void OnForeignKeysCreating(ForeignKeysCreatingEventArgs e);

    /// <summary>После создания внешних ключей</summary>
    void OnForeignKeysCreated();

    /// <summary>Перед созданием первичных ключей</summary>
    /// <param name="e">Параметры события</param>
    void OnPrimaryKeysCreating(PrimaryKeysCreatingEventArgs e);

    /// <summary>После создания первичных ключей</summary>
    void OnPrimaryKeysCreated();

    /// <summary>Перед созданием индексов</summary>
    /// <param name="e">Параметры события</param>
    void OnIndexesCreating(IndexesCreatingEventArgs e);

    /// <summary>После создания индексов</summary>
    void OnIndexesCreated();

    /// <summary>Перед созданием представлений</summary>
    /// <param name="e">Параметры события</param>
    void OnViewsCreating(ViewsCreatingEventArgs e);

    /// <summary>После создания представлений</summary>
    void OnViewsCreated();

    /// <summary>Перед созданием процедур и функций</summary>
    /// <param name="e">Параметры события</param>
    void OnProceduresCreating(ProceduresCreatingEventArgs e);

    /// <summary>После создания процедур и функций</summary>
    void OnProceduresCreated();

    /// <summary>Перед созданием триггеров</summary>
    /// <param name="e">Параметры события</param>
    void OnTriggersCreating(TriggersCreatingEventArgs e);

    /// <summary>После создания триггеров</summary>
    void OnTriggersCreated();

    /// <summary>Завершение преобразования</summary>
    void OnComplete();
  }
}
