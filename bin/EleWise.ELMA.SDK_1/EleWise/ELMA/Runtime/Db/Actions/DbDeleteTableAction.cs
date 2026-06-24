// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Db.Actions.DbDeleteTableAction
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
  /// <summary>Действие удаления таблицы</summary>
  public class DbDeleteTableAction : DbAction
  {
    private string tableName;
    internal static DbDeleteTableAction VE8Z52Wq3D0HNiYy0uOQ;

    /// <summary>Создание действия</summary>
    /// <param name="transform">Провайдер преобразования БД</param>
    /// <param name="tableName">Имя таблицы</param>
    public DbDeleteTableAction(ITransformationProvider transform, string tableName)
    {
      DbDeleteTableAction.GgPe9tWqD66o23vmTaPQ();
      // ISSUE: explicit constructor call
      base.\u002Ector(transform);
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.tableName = tableName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Удаление таблицы</summary>
    public override void Execute()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            base.Execute();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 0 : 0;
            continue;
          case 2:
            DbDeleteTableAction.lV3t26Wq4KkA4FKNw95Q(DbDeleteTableAction.WjwMjkWqtVwOaGyLVfc5(), DbDeleteTableAction.VMCvglWqwwa01kBkw2lc((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1178210108 ^ 1178336546), (object) this.tableName));
            num = 7;
            continue;
          case 3:
            this.LogMessage = SR.T((string) DbDeleteTableAction.TKifj2Wq6kXor9NqwOu7(372753449 ^ 372651695), (object) this.tableName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 4 : 4;
            continue;
          case 4:
            this.WriteLogMessage();
            num = 5;
            continue;
          case 5:
            this.Transform.RemoveTable(this.tableName);
            num = 6;
            continue;
          case 6:
            goto label_2;
          case 7:
            goto label_10;
          case 8:
            if (string.IsNullOrEmpty(this.LogMessage))
            {
              num = 3;
              continue;
            }
            goto case 4;
          default:
            if (this.Transform.TableExists(this.tableName))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 8 : 4;
              continue;
            }
            goto case 2;
        }
      }
label_2:
      return;
label_10:;
    }

    /// <summary>Имя таблицы</summary>
    public string TableName => this.tableName;

    internal static void GgPe9tWqD66o23vmTaPQ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool sZ7cM5WqptHf8CKADiAe() => DbDeleteTableAction.VE8Z52Wq3D0HNiYy0uOQ == null;

    internal static DbDeleteTableAction p43aVRWqaOl4TPsgEvP5() => DbDeleteTableAction.VE8Z52Wq3D0HNiYy0uOQ;

    internal static object WjwMjkWqtVwOaGyLVfc5() => (object) Logger.Log;

    internal static object VMCvglWqwwa01kBkw2lc([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static void lV3t26Wq4KkA4FKNw95Q([In] object obj0, [In] object obj1) => ((ILogger) obj0).Warn(obj1);

    internal static object TKifj2Wq6kXor9NqwOu7(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
