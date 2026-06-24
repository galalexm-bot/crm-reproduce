// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Db.Actions.DbRenameColumnAction
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.Db.Actions
{
  /// <summary>Действие переименования колонки в таблице</summary>
  public class DbRenameColumnAction : DbAction
  {
    private string tableName;
    private string oldName;
    private string newName;
    private static DbRenameColumnAction GCj79GWqy0P7Qh5nb5RN;

    /// <summary>Имя таблицы</summary>
    public string TableName => this.tableName;

    /// <summary>Текущее имя колонки</summary>
    public string OldColumnName => this.oldName;

    /// <summary>Новое имя колонки</summary>
    public string NewColumnName => this.newName;

    /// <summary>Создание действия</summary>
    /// <param name="transform">Провайдер преобразования БД</param>
    /// <param name="tableName">Имя таблицы</param>
    /// <param name="oldName">Старое имя</param>
    /// <param name="newName">Новое имя</param>
    public DbRenameColumnAction(
      ITransformationProvider transform,
      string tableName,
      string oldName,
      string newName)
    {
      DbRenameColumnAction.GHWriEWq9ExkDikG19UG();
      // ISSUE: explicit constructor call
      base.\u002Ector(transform);
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            this.tableName = tableName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 3 : 0;
            continue;
          case 3:
            this.oldName = oldName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
            continue;
          default:
            this.newName = newName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 1 : 1;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Создание колонки</summary>
    public override void Execute()
    {
      int num = 23;
      while (true)
      {
        string str;
        switch (num)
        {
          case 1:
            if (DbRenameColumnAction.yKMu86Wq5k2ldMBcxXrQ((object) this.Transform, (object) this.tableName, (object) this.oldName))
            {
              num = 30;
              continue;
            }
            goto case 19;
          case 2:
            goto label_40;
          case 3:
            this.LogMessage = EleWise.ELMA.SR.T((string) DbRenameColumnAction.ntY11BWqYyrhv5qyadSp(-812025778 ^ -812086286), (object) this.tableName, (object) this.oldName, (object) this.newName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 15 : 9;
            continue;
          case 4:
            if (this.Transform.Dialect.IsReservedWord(this.newName))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 21 : 26;
              continue;
            }
            goto label_30;
          case 5:
            if (((Dialect) DbRenameColumnAction.ubD9FtWqlXjMVvAKCZ8l((object) this.Transform)).IsReservedWord(this.oldName))
            {
              num = 29;
              continue;
            }
            goto case 4;
          case 6:
            goto label_7;
          case 7:
            if (!DbRenameColumnAction.yKMu86Wq5k2ldMBcxXrQ((object) this.Transform, (object) this.tableName, (object) this.newName))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 5 : 11;
              continue;
            }
            goto label_37;
          case 8:
          case 11:
          case 12:
            if (string.IsNullOrEmpty(this.LogMessage))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 3 : 3;
              continue;
            }
            goto case 15;
          case 9:
            if (DbRenameColumnAction.cF9eGyWqsZGlDyhkuAK6((object) this.oldName, (object) this.newName, StringComparison.CurrentCultureIgnoreCase))
            {
              num = 12;
              continue;
            }
            goto case 10;
          case 10:
            if (this.Transform.ColumnExists(this.tableName, this.oldName))
            {
              num = 8;
              continue;
            }
            goto case 7;
          case 13:
            goto label_2;
          case 14:
            if (DbRenameColumnAction.jiOCnPWqroLgtWJBV2IC(DbRenameColumnAction.ubD9FtWqlXjMVvAKCZ8l((object) this.Transform), (object) this.oldName))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 16 : 14;
              continue;
            }
            break;
          case 15:
            this.WriteLogMessage();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
            continue;
          case 16:
            this.WriteLogMessage();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 25 : 28;
            continue;
          case 17:
            goto label_18;
          case 18:
            if (DbRenameColumnAction.yKMu86Wq5k2ldMBcxXrQ((object) this.Transform, (object) this.tableName, (object) this.newName))
            {
              num = 9;
              continue;
            }
            goto label_34;
          case 19:
            if (!DbRenameColumnAction.yKMu86Wq5k2ldMBcxXrQ((object) this.Transform, (object) this.tableName, (object) this.oldName))
            {
              num = 18;
              continue;
            }
            goto case 9;
          case 20:
            DbRenameColumnAction.dBUnhCWqjK8FOLHpOOnD((object) this.Transform, (object) this.tableName, (object) str, (object) this.newName);
            num = 6;
            continue;
          case 21:
            goto label_34;
          case 22:
            if (DbRenameColumnAction.kM76SFWqdTwtCPQxqYc2((object) this.oldName, (object) this.newName))
            {
              num = 14;
              continue;
            }
            break;
          case 23:
            base.Execute();
            num = 22;
            continue;
          case 24:
            goto label_31;
          case 25:
            goto label_44;
          case 26:
          case 29:
label_46:
            if (!string.Equals(this.oldName, this.newName, StringComparison.CurrentCultureIgnoreCase))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 1 : 1;
              continue;
            }
            goto case 19;
          case 27:
            if (!DbRenameColumnAction.yKMu86Wq5k2ldMBcxXrQ((object) this.Transform, (object) this.tableName, (object) str))
            {
              num = 24;
              continue;
            }
            goto case 20;
          case 28:
            str = (string) DbRenameColumnAction.fUnmnSWqgZvnYopTMRFL((object) this.Transform.Dialect, (object) this.oldName);
            num = 27;
            continue;
          case 30:
            if (!DbRenameColumnAction.yKMu86Wq5k2ldMBcxXrQ((object) this.Transform, (object) this.tableName, (object) this.newName))
            {
              num = 19;
              continue;
            }
            goto label_40;
          default:
            DbRenameColumnAction.dBUnhCWqjK8FOLHpOOnD((object) this.Transform, (object) this.tableName, (object) this.oldName, (object) this.newName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 13 : 5;
            continue;
        }
        if (string.Equals(this.oldName, this.newName, StringComparison.CurrentCultureIgnoreCase))
          num = 5;
        else
          goto label_46;
      }
label_7:
      return;
label_2:
      return;
label_18:
      return;
label_31:
      return;
label_44:
      return;
label_30:
      return;
label_37:
      return;
label_34:
      throw new DbStructureException((string) DbRenameColumnAction.fGW2R6WqUhRJ10sC3XqL((object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638529721)), (object) this.oldName, (object) this.tableName));
label_40:
      throw new DbStructureException(string.Format((string) DbRenameColumnAction.aIjZ2qWqL5lFxomDQXaw(DbRenameColumnAction.ntY11BWqYyrhv5qyadSp(-643786247 ^ -643732719)), (object) this.newName, (object) this.tableName));
    }

    internal static void GHWriEWq9ExkDikG19UG() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool JgHWqOWqMAruGFHa9ECF() => DbRenameColumnAction.GCj79GWqy0P7Qh5nb5RN == null;

    internal static DbRenameColumnAction PiNdFqWqJOf6J6KDYlBi() => DbRenameColumnAction.GCj79GWqy0P7Qh5nb5RN;

    internal static bool kM76SFWqdTwtCPQxqYc2([In] object obj0, [In] object obj1) => string.Equals((string) obj0, (string) obj1);

    internal static object ubD9FtWqlXjMVvAKCZ8l([In] object obj0) => (object) ((ITransformationProvider) obj0).Dialect;

    internal static bool jiOCnPWqroLgtWJBV2IC([In] object obj0, [In] object obj1) => ((Dialect) obj0).IsReservedWord((string) obj1);

    internal static object fUnmnSWqgZvnYopTMRFL([In] object obj0, [In] object obj1) => (object) ((Dialect) obj0).UnQuoteString((string) obj1);

    internal static bool yKMu86Wq5k2ldMBcxXrQ([In] object obj0, [In] object obj1, [In] object obj2) => ((ITransformationProvider) obj0).ColumnExists((string) obj1, (string) obj2);

    internal static void dBUnhCWqjK8FOLHpOOnD([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((ITransformationProvider) obj0).RenameColumn((string) obj1, (string) obj2, (string) obj3);

    internal static object ntY11BWqYyrhv5qyadSp(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object aIjZ2qWqL5lFxomDQXaw([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object fGW2R6WqUhRJ10sC3XqL([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static bool cF9eGyWqsZGlDyhkuAK6([In] object obj0, [In] object obj1, [In] StringComparison obj2) => string.Equals((string) obj0, (string) obj1, obj2);
  }
}
