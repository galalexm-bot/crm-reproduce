// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Db.Actions.DbSqlAction
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Collections.Generic;

namespace EleWise.ELMA.Runtime.Db.Actions
{
  /// <summary>Действие с произвольным запросом SQL</summary>
  public class DbSqlAction : DbAction
  {
    private string sql;
    private Dictionary<string, object> paramValues;
    private static DbSqlAction L8sDVaWqHQbsVlFkQapN;

    /// <summary>Создание действия</summary>
    /// <param name="transform">Провайдер преобразования БД</param>
    /// <param name="sql">SQL-скрипт</param>
    /// <param name="paramValues">Значения параметров</param>
    public DbSqlAction(
      ITransformationProvider transform,
      string sql,
      Dictionary<string, object> paramValues = null)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(transform);
      this.sql = sql;
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
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_5;
          case 3:
          case 4:
            this.WriteLogMessage();
            num = 6;
            continue;
          case 5:
            this.LogMessage = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -812086536), (object) this.sql);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 4 : 0;
            continue;
          case 6:
            this.Transform.ExecuteNonQuery(this.sql, this.paramValues);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 2 : 1;
            continue;
          default:
            if (!string.IsNullOrEmpty(this.LogMessage))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 3;
              continue;
            }
            goto case 5;
        }
      }
label_5:;
    }

    /// <summary>SQL-скрипт</summary>
    protected string Sql => this.sql;

    /// <summary>Значения параметров</summary>
    protected Dictionary<string, object> ParamValues => this.paramValues;

    internal static bool qW4xDAWqACUxIpQMakjH() => DbSqlAction.L8sDVaWqHQbsVlFkQapN == null;

    internal static DbSqlAction OsjG78Wq78uKFQcBT3Yb() => DbSqlAction.L8sDVaWqHQbsVlFkQapN;
  }
}
