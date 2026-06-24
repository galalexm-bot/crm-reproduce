// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Db.Actions.DbCreateColumnAction
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
  /// <summary>Действие добавления колонки в таблицу</summary>
  public class DbCreateColumnAction : DbAction
  {
    private string tableName;
    private Column column;
    private static DbCreateColumnAction AW6lxxWKKTNknL0RjXa9;

    /// <summary>Создание действия</summary>
    /// <param name="transform">Провайдер преобразования БД</param>
    /// <param name="tableName">Имя таблицы</param>
    /// <param name="column">Колонка</param>
    public DbCreateColumnAction(ITransformationProvider transform, string tableName, Column column)
    {
      DbCreateColumnAction.pBdGhGWKkwhPAuM3myKg();
      // ISSUE: explicit constructor call
      base.\u002Ector(transform);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.column = column;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 1 : 2;
            continue;
          case 2:
            goto label_3;
          default:
            this.tableName = tableName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Создание колонки</summary>
    public override void Execute()
    {
      int num1 = 2;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_8;
            case 1:
              if (DbCreateColumnAction.DmryK2WKOYHCP8TkxjCX((object) this.Transform, (object) this.tableName, DbCreateColumnAction.DiSt37WKnBtlGtBjTPkp((object) this.column)))
              {
                num2 = 5;
                continue;
              }
              if (string.IsNullOrEmpty(this.LogMessage))
              {
                num2 = 7;
                continue;
              }
              goto case 6;
            case 2:
              base.Execute();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 1 : 1;
              continue;
            case 3:
              goto label_3;
            case 4:
              goto label_9;
            case 5:
              DbCreateColumnAction.EJWQWaWK1nXi2ncKwjed(DbCreateColumnAction.nOqQmDWK2WakgTiVhdry(), DbCreateColumnAction.oyAWCuWKPHfI6npBYKsF(DbCreateColumnAction.EFuUVuWKeeOfPCdAsKMO(1304605005 ^ 1304642573), DbCreateColumnAction.DiSt37WKnBtlGtBjTPkp((object) this.column), (object) this.tableName));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
              continue;
            case 6:
              this.WriteLogMessage();
              num2 = 4;
              continue;
            case 7:
              this.LogMessage = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426456882 ^ 2009939514 ^ -583715476), DbCreateColumnAction.DiSt37WKnBtlGtBjTPkp((object) this.column), DbCreateColumnAction.yAwg2cWKN4ZYPiCu8vrc((object) this.column) != null ? (object) DbCreateColumnAction.yAwg2cWKN4ZYPiCu8vrc((object) this.column).ToString() : (object) "", (object) this.tableName);
              num2 = 6;
              continue;
            default:
              goto label_14;
          }
        }
label_9:
        DbCreateColumnAction.Tj435FWK3J7eN6jaxFqy((object) this.Transform, (object) this.tableName, (object) this.column);
        num1 = 3;
      }
label_8:
      return;
label_3:
      return;
label_14:;
    }

    /// <summary>Имя таблицы</summary>
    protected string TableName => this.tableName;

    /// <summary>Колонка</summary>
    protected Column Column => this.column;

    internal static void pBdGhGWKkwhPAuM3myKg() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool FoAGlFWKXt3W7yWPkWA7() => DbCreateColumnAction.AW6lxxWKKTNknL0RjXa9 == null;

    internal static DbCreateColumnAction Wiw3XvWKTDS5tyLNNMv7() => DbCreateColumnAction.AW6lxxWKKTNknL0RjXa9;

    internal static object DiSt37WKnBtlGtBjTPkp([In] object obj0) => (object) ((Column) obj0).Name;

    internal static bool DmryK2WKOYHCP8TkxjCX([In] object obj0, [In] object obj1, [In] object obj2) => ((ITransformationProvider) obj0).ColumnExists((string) obj1, (string) obj2);

    internal static object nOqQmDWK2WakgTiVhdry() => (object) Logger.Log;

    internal static object EFuUVuWKeeOfPCdAsKMO(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object oyAWCuWKPHfI6npBYKsF([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static void EJWQWaWK1nXi2ncKwjed([In] object obj0, [In] object obj1) => ((ILogger) obj0).Warn(obj1);

    internal static object yAwg2cWKN4ZYPiCu8vrc([In] object obj0) => (object) ((Column) obj0).ColumnType;

    internal static void Tj435FWK3J7eN6jaxFqy([In] object obj0, [In] object obj1, [In] object obj2) => ((ITransformationProvider) obj0).AddColumn((string) obj1, (Column) obj2);
  }
}
