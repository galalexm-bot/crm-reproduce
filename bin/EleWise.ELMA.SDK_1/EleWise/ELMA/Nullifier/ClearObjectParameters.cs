// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Nullifier.ClearObjectParameters
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Nullifier
{
  /// <summary>Параметры для передачи при вызове очистки объекта</summary>
  public class ClearObjectParameters
  {
    /// <summary>Проверитиь и удалить подчиненные сущности.</summary>
    public Func<EntityMetadata, bool> CheckAndDeleteCildMetadate;
    /// <summary>
    /// Удалить сущность
    /// Параметры функции
    /// EntityMetadata - Удаляемая сущность;
    /// string - ограничивающий запрос;
    /// bool  mark - маркировать сущность как очищенную
    /// bool сlearParentAll - Очистить все зависимые сущности
    /// int level - уровень вложенности запроса
    /// bool noDeleteRootEntity - не удалять корневую сцщность
    /// int clearLevel - уровень вложенности зависимых объектов до которой будет осуществлена очистка
    ///  Возвращаемое значение - Запрос выполнен удачно
    /// </summary>
    public Func<EntityMetadata, string, bool, int, bool, bool> DeleteEntityMetadata;
    /// <summary>
    /// Удалить сущность
    /// Параметры функции
    /// UnitNullConfig - Удаляемая сущность;
    /// string - ограничивающий запрос;
    /// bool  mark - маркировать сущность как очищенную
    /// bool сlearParentAll - Очистить все зависимые сущности
    /// int level - уровень вложенности запроса
    /// bool noDeleteRootEntity - не удалять корневую сцщность
    /// int clearLevel - уровень вложенности зависимых объектов до которой будет осуществлена очистка
    ///  Возвращаемое значение - Запрос выполнен удачно
    /// </summary>
    public Func<UnitNullConfig, string, bool, int, bool, bool> DeleteEntityMetadataUnit;
    /// <summary>Удалить папку</summary>
    public Func<Guid, int, bool, bool> DeleteFolder;
    /// <summary>
    /// Выполнить запрос
    /// Параметры функции
    ///  string - sql запрос;
    ///  string - коментарий к запросу;
    ///  bool - Выполнить запрос в любом случае (не учитывая флаг эмуляции) и без записи запроса в скрипт;
    ///  Возвращаемое значение - Запрос выполнен удачно
    /// </summary>
    public Func<string, string, bool> SqlQuery;
    /// <summary>
    /// Выполнить SQL запрос
    /// Параметры функции
    ///  string - sql запрос;
    ///  string - коментарий к запросу;
    ///  Возвращаемое значение - Запрос выполнен удачно
    /// </summary>
    public Func<string, string, bool> ExecuteQuery;
    /// <summary>Название временной таблицы для</summary>
    public string tempTableNameProject;
    /// <summary>Список очищаемых общектов</summary>
    public List<UnitNullConfig> units;
    /// <summary>Интерфейс провайдера преобразования БД</summary>
    public ITransformationProvider Transform;
    /// <summary>
    /// Добавить комментарий в раздел
    /// Параметры функции
    /// String - Текст сообщения
    ///  Возвращаемое значение - Комментарий добавлен
    /// </summary>
    public Func<string, bool> AddLog;
    internal static ClearObjectParameters bLidKn23oCpOGdQGQYG;

    public ClearObjectParameters()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool gq5vWX2pAaVSBEVI0Ue() => ClearObjectParameters.bLidKn23oCpOGdQGQYG == null;

    internal static ClearObjectParameters VdvHlv2aINB4nkSEgVQ() => ClearObjectParameters.bLidKn23oCpOGdQGQYG;
  }
}
