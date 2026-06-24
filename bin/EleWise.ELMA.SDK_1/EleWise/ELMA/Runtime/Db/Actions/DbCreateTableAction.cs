// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Db.Actions.DbCreateTableAction
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.Db.Actions
{
  /// <summary>Действие создания таблицы</summary>
  public class DbCreateTableAction : DbAction
  {
    private Table table;
    internal static DbCreateTableAction eEyciWWK7YScZBiPxaLj;

    /// <summary>Создание действия</summary>
    /// <param name="transform">Провайдер преобразования БД</param>
    /// <param name="table">Таблица</param>
    public DbCreateTableAction(ITransformationProvider transform, Table table)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(transform);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.table = table;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Создание таблицы</summary>
    public override void Execute()
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (DbCreateTableAction.kbf5ElWKlQFIa1GoeB4K((object) this.LogMessage))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
                continue;
              }
              goto case 8;
            case 2:
              goto label_4;
            case 3:
              if (!DbCreateTableAction.pPKBaOWKy98vJgEkXlnI((object) this.Transform, DbCreateTableAction.AmSMN0WKmt5JGrYASNbB((object) this.Table)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 1 : 0;
                continue;
              }
              goto case 6;
            case 4:
              goto label_3;
            case 5:
              goto label_11;
            case 6:
              DbCreateTableAction.kp3D0TWKdtDKMKpGTRLZ(DbCreateTableAction.QqqnxNWKMMABw5j4nBtr(), DbCreateTableAction.LL9ct3WK9t6AgfXrppx1(DbCreateTableAction.Xvooc4WKJfqdoEjJI6Jk(1142330761 ^ 1541959139 ^ 536808974), DbCreateTableAction.AmSMN0WKmt5JGrYASNbB((object) this.Table)));
              num2 = 5;
              continue;
            case 7:
              DbCreateTableAction.jumUBLWKrlHpRhSojOyt((object) this.Transform, (object) this.Table);
              num2 = 2;
              continue;
            case 8:
              this.WriteLogMessage();
              num2 = 7;
              continue;
            default:
              goto label_13;
          }
        }
label_3:
        base.Execute();
        num1 = 3;
        continue;
label_13:
        this.LogMessage = SR.T((string) DbCreateTableAction.Xvooc4WKJfqdoEjJI6Jk(-2138160520 ^ -2138065692), (object) this.Table.Name);
        num1 = 8;
      }
label_4:
      return;
label_11:;
    }

    /// <summary>Структура таблицы</summary>
    protected Table Table => this.table;

    internal static bool I3ginGWKxyJSyGUspVPa() => DbCreateTableAction.eEyciWWK7YScZBiPxaLj == null;

    internal static DbCreateTableAction x7xMD5WK02UjbovksIdG() => DbCreateTableAction.eEyciWWK7YScZBiPxaLj;

    internal static object AmSMN0WKmt5JGrYASNbB([In] object obj0) => (object) ((Table) obj0).Name;

    internal static bool pPKBaOWKy98vJgEkXlnI([In] object obj0, [In] object obj1) => ((ITransformationProvider) obj0).TableExists((string) obj1);

    internal static object QqqnxNWKMMABw5j4nBtr() => (object) Logger.Log;

    internal static object Xvooc4WKJfqdoEjJI6Jk(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object LL9ct3WK9t6AgfXrppx1([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static void kp3D0TWKdtDKMKpGTRLZ([In] object obj0, [In] object obj1) => ((ILogger) obj0).Warn(obj1);

    internal static bool kbf5ElWKlQFIa1GoeB4K([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static void jumUBLWKrlHpRhSojOyt([In] object obj0, [In] object obj1) => ((ITransformationProvider) obj0).AddTable((Table) obj1);
  }
}
