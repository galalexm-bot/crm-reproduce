// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Db.Actions.NewEntityAction
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Runtime.Db.Actions;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Db.Actions
{
  /// <summary>Действие при добавлении новой сущности</summary>
  public class NewEntityAction : EntityAction
  {
    internal static NewEntityAction kYtAuyoGxkDC2L6TDfqk;

    /// <summary>Создать действие</summary>
    /// <param name="updater">Обработчик изменения структуры БД моделей</param>
    /// <param name="metadata">Метаданные сущности</param>
    public NewEntityAction(IDbModelUpdater updater, EntityMetadata metadata)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(updater, metadata);
      int num1 = 7;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
        num1 = 30;
      List<IDbCreateTableActionExtender> list;
      List<IDbCreateTableActionExtender>.Enumerator enumerator1;
      IMetadata metadata1;
      IEnumerator<EntityPropertyMetadata> enumerator2;
      Table table1;
      while (true)
      {
        int num2;
        int? length;
        Column column1;
        Column columnForIdentifier;
        Column column2;
        switch (num1)
        {
          case 1:
          case 21:
            enumerator2 = this.Metadata.Properties.OfType<EntityPropertyMetadata>().GetEnumerator();
            num1 = 29;
            continue;
          case 2:
            if (!length.HasValue)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 8 : 11;
              continue;
            }
            goto case 25;
          case 3:
            goto label_26;
          case 4:
            if (NewEntityAction.PJQ3LWoGYlHLXpXVqNg0(NewEntityAction.nqP4d9oGj2wGhvLGlWC0((object) columnForIdentifier)) == DbType.String)
            {
              num1 = 32;
              continue;
            }
            goto case 16;
          case 5:
            column2 = new Column((string) NewEntityAction.o6dbl3oGUsrjiiFHHAhU(1113862659 ^ 1113878625), DbType.Guid);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 5 : 8;
            continue;
          case 6:
          case 10:
            if (this.Metadata.AllowCreateHeirs)
            {
              num1 = 27;
              continue;
            }
            goto case 1;
          case 7:
            list = ((ComponentManager) NewEntityAction.vlXNIQoGlH0VlIo6Dvsg()).GetExtensionPoints<IDbCreateTableActionExtender>().ToList<IDbCreateTableActionExtender>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 12 : 23;
            continue;
          case 8:
            table1.Columns.Add(column2);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 1 : 0;
            continue;
          case 9:
            goto label_31;
          case 11:
          case 15:
            ((ColumnType) NewEntityAction.nqP4d9oGj2wGhvLGlWC0((object) columnForIdentifier)).Length = new int?((int) byte.MaxValue);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 13 : 16;
            continue;
          case 12:
            if (length.Value > (int) byte.MaxValue)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 15 : 10;
              continue;
            }
            goto case 16;
          case 13:
            NewEntityAction.NRQg19oGLWlsk4Rxioj1((object) column1, ColumnProperty.PrimaryKey);
            num1 = 19;
            continue;
          case 14:
            table1.Columns.Add(columnForIdentifier);
            num1 = 6;
            continue;
          case 16:
            NewEntityAction.NRQg19oGLWlsk4Rxioj1((object) columnForIdentifier, ColumnProperty.PrimaryKey);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 11 : 14;
            continue;
          case 17:
            Table table2 = new Table();
            table2.Columns = new List<Column>();
            NewEntityAction.Q2OZdQoGdIMKFIwlusfG((object) table2, NewEntityAction.aXPn2poGyN2aOI241sOW((object) this.Metadata));
            table1 = table2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 3 : 28;
            continue;
          case 18:
            try
            {
label_112:
              if (enumerator1.MoveNext())
                goto label_114;
              else
                goto label_113;
label_111:
              int num3;
              switch (num3)
              {
                case 1:
                  goto label_112;
                case 2:
                  goto label_114;
                default:
                  goto label_17;
              }
label_113:
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 0;
              goto label_111;
label_114:
              NewEntityAction.TDgng2oGr2GAM7G17oiG((object) enumerator1.Current, (object) this.Updater, (object) this.Transform, (object) table1);
              num3 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0)
              {
                num3 = 1;
                goto label_111;
              }
              else
                goto label_111;
            }
            finally
            {
              enumerator1.Dispose();
              int num4 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
                num4 = 0;
              switch (num4)
              {
                default:
              }
            }
          case 19:
            table1.Columns.Add(column1);
            num1 = 10;
            continue;
          case 20:
            if (metadata1 != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 21 : 34;
              continue;
            }
            goto label_31;
          case 22:
            goto label_7;
          case 23:
            enumerator1 = list.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 5 : 18;
            continue;
          case 24:
label_17:
            if (!NewEntityAction.oJ8tpPoG5cFJwq9UsjGF(NewEntityAction.SWUO1XoGgxxnM2T4bRcq((object) this.Metadata), Guid.Empty))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
              continue;
            }
            goto case 31;
          case 25:
            length = ((ColumnType) NewEntityAction.nqP4d9oGj2wGhvLGlWC0((object) columnForIdentifier)).Length;
            num2 = 12;
            break;
          case 26:
            goto label_120;
          case 27:
            if (!NewEntityAction.oJ8tpPoG5cFJwq9UsjGF(NewEntityAction.SWUO1XoGgxxnM2T4bRcq((object) metadata), Guid.Empty))
            {
              num1 = 21;
              continue;
            }
            goto case 5;
          case 28:
            this.Updater.TablesCreatedActions.Add((IDbAction) new DbCreateTableAction(this.Transform, table1));
            num2 = 7;
            break;
          case 29:
            goto label_35;
          case 30:
            if (!NewEntityAction.ReDCV1oGMVP6E0ITlvJ4(NewEntityAction.aXPn2poGyN2aOI241sOW((object) this.Metadata)))
            {
              num1 = 17;
              continue;
            }
            goto label_26;
          case 31:
            columnForIdentifier = DbModelHelper.GetColumnForIdentifier(this.Metadata, out bool _);
            num2 = 4;
            break;
          case 32:
            length = ((ColumnType) NewEntityAction.nqP4d9oGj2wGhvLGlWC0((object) columnForIdentifier)).Length;
            num1 = 2;
            continue;
          case 33:
            column1 = (Column) NewEntityAction.YZtHdAoGzUYxca7MZY1N((object) this.Metadata);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 13 : 8;
            continue;
          case 34:
            if (metadata1 is EntityMetadata)
            {
              num1 = 33;
              continue;
            }
            goto label_7;
          default:
            metadata1 = MetadataLoader.LoadMetadata(NewEntityAction.SWUO1XoGgxxnM2T4bRcq((object) this.Metadata));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 20 : 14;
            continue;
        }
        num1 = num2;
      }
label_120:
      return;
label_7:
      throw new DbModelException((string) NewEntityAction.v2RvZloGsGyWLOo0Jy8i(NewEntityAction.T1r2epoGcBM9GAye21hl((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(864270449 << 6 ^ -521385328)), (object) this.Metadata.FullTypeName, (object) metadata1.GetType().FullName));
label_26:
      throw new DbModelException((string) NewEntityAction.Nnbg9hoG9ExiHujgT2dQ((object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-680446928 - -370807692 ^ -309783430)), NewEntityAction.Yk1FqioGJONY29vsyeUs((object) this.Metadata)));
label_31:
      throw new DbModelException((string) NewEntityAction.v2RvZloGsGyWLOo0Jy8i((object) EleWise.ELMA.SR.T((string) NewEntityAction.o6dbl3oGUsrjiiFHHAhU(--1360331293 ^ 1360484335)), NewEntityAction.Yk1FqioGJONY29vsyeUs((object) this.Metadata), (object) NewEntityAction.SWUO1XoGgxxnM2T4bRcq((object) this.Metadata)));
label_35:
      try
      {
label_56:
        if (NewEntityAction.frCorsoEb8F9GZFoq0yX((object) enumerator2))
          goto label_61;
        else
          goto label_57;
label_37:
        EntityPropertyMetadata current1;
        int num5;
        while (true)
        {
          int num6;
          List<ForeignKey>.Enumerator enumerator3;
          TypeDbStructures typeDbStructures;
          List<Table>.Enumerator enumerator4;
          List<Column>.Enumerator enumerator5;
          switch (num5)
          {
            case 1:
label_52:
              enumerator4 = typeDbStructures.Tables.GetEnumerator();
              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 1 : 4;
              continue;
            case 2:
              enumerator5 = typeDbStructures.Columns.GetEnumerator();
              num5 = 10;
              continue;
            case 3:
label_64:
              if (!((string) NewEntityAction.d1E5ccoEBoD45esaRdIi((object) current1) == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-542721635 ^ -542714353)))
              {
                num5 = 13;
                continue;
              }
              goto default;
            case 4:
              try
              {
label_80:
                if (enumerator4.MoveNext())
                  goto label_82;
                else
                  goto label_81;
label_67:
                Table current2;
                int num7;
                while (true)
                {
                  switch (num7)
                  {
                    case 1:
                      goto label_80;
                    case 2:
                      this.Updater.TablesCreatedActions.Add((IDbAction) new DbCreateTableAction(this.Transform, current2));
                      num7 = 5;
                      continue;
                    case 3:
                      goto label_82;
                    case 4:
                      goto label_62;
                    case 5:
                      enumerator1 = list.GetEnumerator();
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_68;
                  }
                }
label_68:
                try
                {
label_71:
                  if (enumerator1.MoveNext())
                    goto label_73;
                  else
                    goto label_72;
label_70:
                  int num8;
                  switch (num8)
                  {
                    case 1:
                      goto label_80;
                    case 2:
                      goto label_71;
                    default:
                      goto label_73;
                  }
label_72:
                  num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 1;
                  goto label_70;
label_73:
                  NewEntityAction.TDgng2oGr2GAM7G17oiG((object) enumerator1.Current, (object) this.Updater, (object) this.Transform, (object) current2);
                  num8 = 2;
                  goto label_70;
                }
                finally
                {
                  enumerator1.Dispose();
                  int num9 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
                    num9 = 0;
                  switch (num9)
                  {
                    default:
                  }
                }
label_81:
                num7 = 4;
                goto label_67;
label_82:
                current2 = enumerator4.Current;
                num7 = 2;
                goto label_67;
              }
              finally
              {
                enumerator4.Dispose();
                int num10 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0)
                  num10 = 0;
                switch (num10)
                {
                  default:
                }
              }
            case 5:
label_62:
              enumerator3 = typeDbStructures.ForeignKeys.GetEnumerator();
              num6 = 9;
              break;
            case 6:
              goto label_61;
            case 7:
              goto label_116;
            case 8:
              if (NewEntityAction.oJ8tpPoG5cFJwq9UsjGF(NewEntityAction.SWUO1XoGgxxnM2T4bRcq((object) this.Metadata), Guid.Empty))
              {
                num5 = 14;
                continue;
              }
              goto label_56;
            case 9:
              try
              {
label_42:
                if (enumerator3.MoveNext())
                  goto label_45;
                else
                  goto label_43;
label_41:
                ForeignKey current3;
                int num11;
                while (true)
                {
                  switch (num11)
                  {
                    case 1:
                      current3.Name = this.Updater.GenerateForeignKeyName(current3.TableName, current3.Columns[0]);
                      num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 4 : 4;
                      continue;
                    case 2:
                      goto label_42;
                    case 3:
                      goto label_45;
                    case 4:
                      this.Updater.ForeignKeysCreatedActions.Add((IDbAction) new DbCreateForeignKeyAction(this.Transform, current3));
                      num11 = 2;
                      continue;
                    default:
                      goto label_64;
                  }
                }
label_43:
                num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
                goto label_41;
label_45:
                current3 = enumerator3.Current;
                num11 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
                {
                  num11 = 1;
                  goto label_41;
                }
                else
                  goto label_41;
              }
              finally
              {
                enumerator3.Dispose();
                int num12 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
                  num12 = 0;
                switch (num12)
                {
                  default:
                }
              }
            case 10:
              try
              {
label_89:
                if (enumerator5.MoveNext())
                  goto label_92;
                else
                  goto label_90;
label_88:
                Column current4;
                int num13;
                while (true)
                {
                  switch (num13)
                  {
                    case 1:
                      table1.Columns.Add(current4);
                      num13 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 0 : 0;
                      continue;
                    case 2:
                      goto label_92;
                    case 3:
                      goto label_52;
                    default:
                      goto label_89;
                  }
                }
label_90:
                num13 = 3;
                goto label_88;
label_92:
                current4 = enumerator5.Current;
                num13 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0)
                {
                  num13 = 1;
                  goto label_88;
                }
                else
                  goto label_88;
              }
              finally
              {
                enumerator5.Dispose();
                int num14 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
                  num14 = 0;
                switch (num14)
                {
                  default:
                }
              }
            case 11:
              typeDbStructures = (TypeDbStructures) NewEntityAction.PGwEBDoEFUCQEFDBwXr0((object) this.Metadata, (object) current1);
              num5 = 2;
              continue;
            case 12:
              List<IDbAction> tablesCreatedActions = this.Updater.TablesCreatedActions;
              ITransformationProvider transform = this.Transform;
              EleWise.ELMA.Runtime.Db.Migrator.Framework.Index index = new EleWise.ELMA.Runtime.Db.Migrator.Framework.Index();
              NewEntityAction.fSsMD3oEoC7FQryRO0nT((object) index, (object) string.Format((string) NewEntityAction.o6dbl3oGUsrjiiFHHAhU(-1317790512 ^ -1317647042), NewEntityAction.aXPn2poGyN2aOI241sOW((object) this.Metadata)));
              index.TableName = (string) NewEntityAction.aXPn2poGyN2aOI241sOW((object) this.Metadata);
              index.Columns = new List<string>()
              {
                z2jc63fLkugS1X8Q9N.tE1kD1vbB(979449278 ^ 979458604)
              };
              DbCreateUniqueIndexAction uniqueIndexAction = new DbCreateUniqueIndexAction(transform, index);
              tablesCreatedActions.Add((IDbAction) uniqueIndexAction);
              num6 = 16;
              break;
            case 13:
            case 15:
            case 16:
              goto label_56;
            case 14:
              if (!((ComponentManager) NewEntityAction.vlXNIQoGlH0VlIo6Dvsg()).GetExtensionPoints<IIgnoreUidUI>().Any<IIgnoreUidUI>((System.Func<IIgnoreUidUI, bool>) (m => NewEntityAction.TNZfwuoEhh631ieCllEU((object) m, (object) this.Metadata))))
              {
                num5 = 12;
                continue;
              }
              goto label_56;
            default:
              if (!NewEntityAction.P0YKnAoEWp2Wx5Fxo1Tj((object) this.Metadata))
              {
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 15 : 4;
                continue;
              }
              goto case 8;
          }
          num5 = num6;
        }
label_116:
        return;
label_57:
        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 7 : 3;
        goto label_37;
label_61:
        current1 = enumerator2.Current;
        num5 = 11;
        goto label_37;
      }
      finally
      {
        int num15;
        if (enumerator2 == null)
          num15 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 1 : 0;
        else
          goto label_101;
label_100:
        switch (num15)
        {
          case 2:
            break;
          default:
        }
label_101:
        enumerator2.Dispose();
        num15 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
        {
          num15 = 0;
          goto label_100;
        }
        else
          goto label_100;
      }
    }

    internal static object aXPn2poGyN2aOI241sOW([In] object obj0) => (object) ((EntityMetadata) obj0).TableName;

    internal static bool ReDCV1oGMVP6E0ITlvJ4([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object Yk1FqioGJONY29vsyeUs([In] object obj0) => (object) ((ClassMetadata) obj0).FullTypeName;

    internal static object Nnbg9hoG9ExiHujgT2dQ([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static void Q2OZdQoGdIMKFIwlusfG([In] object obj0, [In] object obj1) => ((Table) obj0).Name = (string) obj1;

    internal static object vlXNIQoGlH0VlIo6Dvsg() => (object) ComponentManager.Current;

    internal static void TDgng2oGr2GAM7G17oiG([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((IDbCreateTableActionExtender) obj0).Extend((IDbModelUpdater) obj1, (ITransformationProvider) obj2, (Table) obj3);

    internal static Guid SWUO1XoGgxxnM2T4bRcq([In] object obj0) => ((ClassMetadata) obj0).BaseClassUid;

    internal static bool oJ8tpPoG5cFJwq9UsjGF([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static object nqP4d9oGj2wGhvLGlWC0([In] object obj0) => (object) ((Column) obj0).ColumnType;

    internal static DbType PJQ3LWoGYlHLXpXVqNg0([In] object obj0) => ((ColumnType) obj0).DataType;

    internal static void NRQg19oGLWlsk4Rxioj1([In] object obj0, ColumnProperty value) => ((Column) obj0).ColumnProperty = value;

    internal static object o6dbl3oGUsrjiiFHHAhU(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object v2RvZloGsGyWLOo0Jy8i([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static object T1r2epoGcBM9GAye21hl([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object YZtHdAoGzUYxca7MZY1N([In] object obj0) => (object) DbModelHelper.GetColumnForIdentifier((EntityMetadata) obj0);

    internal static object PGwEBDoEFUCQEFDBwXr0([In] object obj0, [In] object obj1) => (object) DbModelHelper.GetPropertyDbStructures((EntityMetadata) obj0, (EntityPropertyMetadata) obj1);

    internal static object d1E5ccoEBoD45esaRdIi([In] object obj0) => (object) ((EleWise.ELMA.Model.Metadata.NamedMetadata) obj0).Name;

    internal static bool P0YKnAoEWp2Wx5Fxo1Tj([In] object obj0) => ((EntityMetadata) obj0).IsUnique;

    internal static void fSsMD3oEoC7FQryRO0nT([In] object obj0, [In] object obj1) => ((EleWise.ELMA.Runtime.Db.Migrator.Framework.Index) obj0).Name = (string) obj1;

    internal static bool frCorsoEb8F9GZFoq0yX([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static bool X8mqiFoG0uP7u2FI2Jjq() => NewEntityAction.kYtAuyoGxkDC2L6TDfqk == null;

    internal static NewEntityAction EUJ9kPoGmINXngx3QUco() => NewEntityAction.kYtAuyoGxkDC2L6TDfqk;

    internal static bool TNZfwuoEhh631ieCllEU([In] object obj0, [In] object obj1) => ((IIgnoreUidUI) obj0).NeedIgnoreUid((EntityMetadata) obj1);
  }
}
