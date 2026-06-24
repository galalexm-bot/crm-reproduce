// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Db.Actions.DbDeleteColumnAction
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.Db.Actions
{
  /// <summary>Действие удаления колонки из таблицы</summary>
  public class DbDeleteColumnAction : DbAction
  {
    private string tableName;
    private string columnName;
    private static DbDeleteColumnAction eLU7u3WKgyvDRxIsWJcW;

    /// <summary>Создание действия</summary>
    /// <param name="transform">Провайдер преобразования БД</param>
    /// <param name="tableName">Имя таблицы</param>
    /// <param name="columnName">Имя колонки</param>
    public DbDeleteColumnAction(
      ITransformationProvider transform,
      string tableName,
      string columnName)
    {
      DbDeleteColumnAction.NWjcJ0WKYtMRv6QpnjZe();
      // ISSUE: explicit constructor call
      base.\u002Ector(transform);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
        num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.tableName = tableName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
            continue;
          default:
            this.columnName = columnName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Удаление колонки</summary>
    public override void Execute()
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.LogMessage = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 1360327889), (object) this.columnName, (object) this.tableName);
            num = 5;
            continue;
          case 2:
            this.Transform.RemoveColumn(this.tableName, this.columnName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 0 : 0;
            continue;
          case 3:
            if (DbDeleteColumnAction.sB2qOnWKL77jBy0JSqSP((object) this.LogMessage))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 1 : 1;
              continue;
            }
            goto case 5;
          case 4:
            base.Execute();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 3;
            continue;
          case 5:
            this.WriteLogMessage();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 2 : 2;
            continue;
          default:
            goto label_9;
        }
      }
label_2:
      return;
label_9:;
    }

    /// <summary>Имя таблицы</summary>
    public string TableName => this.tableName;

    /// <summary>Имя колонки</summary>
    public string ColumnName => this.columnName;

    internal static void NWjcJ0WKYtMRv6QpnjZe() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool XhDT7fWK5BGWwM4BFmjd() => DbDeleteColumnAction.eLU7u3WKgyvDRxIsWJcW == null;

    internal static DbDeleteColumnAction lrvCYIWKjMAfbhChV2dr() => DbDeleteColumnAction.eLU7u3WKgyvDRxIsWJcW;

    internal static bool sB2qOnWKL77jBy0JSqSP([In] object obj0) => string.IsNullOrEmpty((string) obj0);
  }
}
