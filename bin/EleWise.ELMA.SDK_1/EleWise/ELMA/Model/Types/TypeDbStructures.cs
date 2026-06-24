// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.TypeDbStructures
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>
  /// Информация о структурах в БД для свойств с определенным типом
  /// </summary>
  public class TypeDbStructures
  {
    private List<Column> columns;
    private List<ForeignKey> foreignKeys;
    private List<PrimaryKey> primaryKeys;
    private List<Table> tables;
    private List<Tuple<string, object>> updates;
    internal static TypeDbStructures rGvxNIo9ZqYykUQruGpG;

    /// <summary>Колонки для основной таблицы</summary>
    public List<Column> Columns => this.columns;

    /// <summary>Внешние ключи для основной таблицы</summary>
    public List<ForeignKey> ForeignKeys => this.foreignKeys;

    /// <summary>Первичные ключи</summary>
    public List<PrimaryKey> PrimaryKeys => this.primaryKeys;

    /// <summary>Список дополнительных таблиц</summary>
    public List<Table> Tables => this.tables;

    /// <summary>Список обновлений данных</summary>
    internal List<Tuple<string, object>> Updates => this.updates;

    public TypeDbStructures()
    {
      TypeDbStructures.f1waguo9V95SX5kGKAVW();
      this.columns = new List<Column>();
      this.foreignKeys = new List<ForeignKey>();
      this.primaryKeys = new List<PrimaryKey>();
      this.tables = new List<Table>();
      this.updates = new List<Tuple<string, object>>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void f1waguo9V95SX5kGKAVW() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool JsVWyco9u3wIYDKowcVc() => TypeDbStructures.rGvxNIo9ZqYykUQruGpG == null;

    internal static TypeDbStructures Sf14ago9IbCAEPsZKEdi() => TypeDbStructures.rGvxNIo9ZqYykUQruGpG;
  }
}
