// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Db.Actions.DbUpdateAction
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;

namespace EleWise.ELMA.Runtime.Db.Actions
{
  /// <summary>Действие обновления значений в таблице</summary>
  public class DbUpdateAction : DbAction
  {
    private string table;
    private string[] columns;
    private object[] values;
    private string where;
    private Dictionary<string, object> paramValues;
    private static DbUpdateAction OX383CWqxysk46KkIKSe;

    /// <summary>Создание действия</summary>
    /// <param name="transform">Провайдер преобразования БД</param>
    /// <param name="table">Имя таблицы</param>
    /// <param name="columns">Имена колонок</param>
    /// <param name="values">Значения колонок</param>
    /// <param name="where">Условие</param>
    /// <param name="paramValues">Значения параметров</param>
    public DbUpdateAction(
      ITransformationProvider transform,
      string table,
      string[] columns,
      object[] values,
      string where = null,
      Dictionary<string, object> paramValues = null)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(transform);
      this.table = table;
      this.columns = columns;
      this.values = values;
      this.where = where;
      this.paramValues = paramValues;
    }

    /// <summary>Создание колонки</summary>
    public override void Execute()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            base.Execute();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            this.Transform.Update(this.table, this.columns, this.values, this.where, this.paramValues);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 2 : 1;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Имя таблицы</summary>
    protected string Table => this.table;

    /// <summary>Имена колонок</summary>
    protected string[] Columns => this.columns;

    /// <summary>Значения колонок</summary>
    protected object[] Values => this.values;

    /// <summary>Условие</summary>
    protected string Where => this.where;

    /// <summary>Значения параметров</summary>
    protected Dictionary<string, object> ParamValues => this.paramValues;

    internal static bool S7liXBWq0HXl37o59RUZ() => DbUpdateAction.OX383CWqxysk46KkIKSe == null;

    internal static DbUpdateAction Ckh0heWqmJJUDPEdpEph() => DbUpdateAction.OX383CWqxysk46KkIKSe;
  }
}
