// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Db.Actions.DbRenameTableAction
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.Db.Actions
{
  /// <summary>Действие переименования таблицы</summary>
  public class DbRenameTableAction : DbAction
  {
    private string oldTableName;
    private string newTableName;
    private static DbRenameTableAction hoi9PJWqcU76lLAp2qMY;

    /// <summary>Создание действия</summary>
    /// <param name="transform">Провайдер преобразования БД</param>
    /// <param name="oldTableName">Старое имя таблицы</param>
    /// <param name="newTableName">Новое имя таблицы</param>
    public DbRenameTableAction(
      ITransformationProvider transform,
      string oldTableName,
      string newTableName)
    {
      DbRenameTableAction.I6bBusWKBDn1jN4jQ4yw();
      // ISSUE: explicit constructor call
      base.\u002Ector(transform);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.newTableName = newTableName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 1 : 1;
            continue;
          default:
            this.oldTableName = oldTableName;
            num = 2;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Создание колонки</summary>
    public override void Execute()
    {
      int num1 = 19;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          string str;
          switch (num2)
          {
            case 1:
              DbRenameTableAction.PH0kVFWKvRImEldoCmXA((object) Logger.Log, DbRenameTableAction.bFuY2uWKCTbbWPchYgtB(DbRenameTableAction.BoUQaNWKQCR6ADttgZsn((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 1867253091)), (object) this.oldTableName));
              num2 = 10;
              continue;
            case 2:
            case 5:
              this.WriteLogMessage();
              num2 = 11;
              continue;
            case 3:
              goto label_7;
            case 4:
              goto label_32;
            case 6:
            case 12:
              if (!DbRenameTableAction.PWOvULWK8mPLLPFiQpco((object) this.LogMessage))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 5 : 0;
                continue;
              }
              goto case 15;
            case 7:
              if (!this.Transform.TableExists(this.oldTableName))
                goto case 16;
              else
                goto label_28;
            case 8:
              str = (string) DbRenameTableAction.sU2H80WKbFnWtieSB3VL((object) this.Transform.Dialect, (object) this.oldTableName);
              num2 = 23;
              continue;
            case 9:
label_24:
              if (!this.Transform.TableExists(this.newTableName))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 1 : 1;
                continue;
              }
              goto case 7;
            case 10:
              goto label_18;
            case 11:
              DbRenameTableAction.hGcmAIWKG2HJqVDwWco4((object) this.Transform, (object) this.oldTableName, (object) this.newTableName);
              num2 = 3;
              continue;
            case 13:
              goto label_26;
            case 14:
              if (DbRenameTableAction.DEheXBWKh8bWa4kyICNu((object) this.Transform, (object) this.newTableName))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
                continue;
              }
              break;
            case 15:
              this.LogMessage = SR.T((string) DbRenameTableAction.mmW7u4WKfohlZENbtR93(-643786247 ^ -643732213), (object) this.oldTableName, (object) this.newTableName);
              num2 = 2;
              continue;
            case 16:
              if (!this.Transform.TableExists(this.newTableName))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 3 : 12;
                continue;
              }
              goto label_17;
            case 17:
              goto label_15;
            case 18:
              if (DbRenameTableAction.kfcIDpWKW6NVsAuNvDKW((object) this.oldTableName, (object) this.newTableName))
              {
                num2 = 20;
                continue;
              }
              goto label_19;
            case 19:
              base.Execute();
              num2 = 18;
              continue;
            case 20:
              if (!DbRenameTableAction.mXo2OKWKoT7cYLCqD5Ev((object) this.Transform.Dialect, (object) this.newTableName))
                goto label_19;
              else
                goto label_31;
            case 21:
              this.WriteLogMessage();
              num2 = 8;
              continue;
            case 22:
              DbRenameTableAction.hGcmAIWKG2HJqVDwWco4((object) this.Transform, (object) str, (object) this.newTableName);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 8 : 17;
              continue;
            case 23:
              if (DbRenameTableAction.DEheXBWKh8bWa4kyICNu((object) this.Transform, (object) str))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 1 : 22;
                continue;
              }
              goto label_29;
            default:
              DbRenameTableAction.PH0kVFWKvRImEldoCmXA(DbRenameTableAction.Yxb77DWKE572sZfgB3lr(), DbRenameTableAction.bFuY2uWKCTbbWPchYgtB(DbRenameTableAction.BoUQaNWKQCR6ADttgZsn(DbRenameTableAction.mmW7u4WKfohlZENbtR93(1051276242 - 990076387 ^ 61088201)), (object) this.newTableName));
              num2 = 4;
              continue;
          }
label_8:
          if (DbRenameTableAction.DEheXBWKh8bWa4kyICNu((object) this.Transform, (object) this.oldTableName))
          {
            num2 = 7;
            continue;
          }
          goto label_24;
label_19:
          if (DbRenameTableAction.DEheXBWKh8bWa4kyICNu((object) this.Transform, (object) this.oldTableName))
            num2 = 14;
          else
            goto label_8;
        }
label_28:
        num1 = 6;
        continue;
label_31:
        num1 = 21;
      }
label_7:
      return;
label_32:
      return;
label_18:
      return;
label_26:
      return;
label_15:
      return;
label_17:
      return;
label_29:;
    }

    internal static void I6bBusWKBDn1jN4jQ4yw() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool x17WsLWqzcl6Nwja9h1k() => DbRenameTableAction.hoi9PJWqcU76lLAp2qMY == null;

    internal static DbRenameTableAction Hmk2NjWKFGZagVHI4XZo() => DbRenameTableAction.hoi9PJWqcU76lLAp2qMY;

    internal static bool kfcIDpWKW6NVsAuNvDKW([In] object obj0, [In] object obj1) => ((string) obj0).Equals((string) obj1);

    internal static bool mXo2OKWKoT7cYLCqD5Ev([In] object obj0, [In] object obj1) => ((Dialect) obj0).IsReservedWord((string) obj1);

    internal static object sU2H80WKbFnWtieSB3VL([In] object obj0, [In] object obj1) => (object) ((Dialect) obj0).UnQuoteString((string) obj1);

    internal static bool DEheXBWKh8bWa4kyICNu([In] object obj0, [In] object obj1) => ((ITransformationProvider) obj0).TableExists((string) obj1);

    internal static void hGcmAIWKG2HJqVDwWco4([In] object obj0, [In] object obj1, [In] object obj2) => ((ITransformationProvider) obj0).RenameTable((string) obj1, (string) obj2);

    internal static object Yxb77DWKE572sZfgB3lr() => (object) Logger.Log;

    internal static object mmW7u4WKfohlZENbtR93(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object BoUQaNWKQCR6ADttgZsn([In] object obj0) => (object) SR.T((string) obj0);

    internal static object bFuY2uWKCTbbWPchYgtB([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static void PH0kVFWKvRImEldoCmXA([In] object obj0, [In] object obj1) => ((ILogger) obj0).Warn(obj1);

    internal static bool PWOvULWK8mPLLPFiQpco([In] object obj0) => string.IsNullOrEmpty((string) obj0);
  }
}
