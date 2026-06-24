// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Db.Actions.DbRenameRelationTableAction
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Actions;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Db.Actions
{
  /// <summary>Дествие переименования таблицы связи</summary>
  public class DbRenameRelationTableAction : ModelAction
  {
    private EntityMetadata _parentMetadata;
    private EntityMetadata _childMetadata;
    private EntitySettings _oldSettings;
    private EntitySettings _newSettings;
    private DbRenameRelationTableAction.MoveDataAction _moveDataAction;
    private static DbRenameRelationTableAction huRDF7oh2kPBSu59x0ne;

    /// <summary>Создать действие</summary>
    /// <param name="updater">Провайдер преобразования БД</param>
    public DbRenameRelationTableAction(
      IDbModelUpdater updater,
      ClassMetadata parentMetadata,
      ClassMetadata childMetadata,
      EntitySettings oldSettings,
      EntitySettings newSettings)
    {
      DbRenameRelationTableAction.WIaVU0oh1AoXY1pU2vwW();
      // ISSUE: explicit constructor call
      base.\u002Ector(updater);
      int num = 11;
      Func<string, string> func;
      string query;
      DbDeleteTableAction deleteTableAction;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this._newSettings != null)
            {
              func = (Func<string, string>) (s => (string) DbRenameRelationTableAction.aRaccLoh0E2e1WEV86jl(DbRenameRelationTableAction.IqmpMLohx5imfemImkxw((object) this.Transform), (object) s));
              num = 19;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 22 : 14;
            continue;
          case 2:
            if (this._childMetadata != null)
            {
              num = 20;
              continue;
            }
            goto case 13;
          case 3:
            this._newSettings = newSettings;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 9 : 4;
            continue;
          case 4:
            if (this._oldSettings != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 1 : 0;
              continue;
            }
            goto label_20;
          case 5:
          case 6:
            updater.TablesDeletedActions.Add((IDbAction) this._moveDataAction);
            num = 13;
            continue;
          case 7:
            deleteTableAction = new DbDeleteTableAction(this.Transform, (string) DbRenameRelationTableAction.x7QB1hohtE4AL7OvALcG((object) this._oldSettings));
            num = 8;
            continue;
          case 8:
            updater.TablesDeletedActions.Add((IDbAction) deleteTableAction);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 12 : 6;
            continue;
          case 9:
            if (this._parentMetadata == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 21 : 10;
              continue;
            }
            goto case 4;
          case 10:
            this._childMetadata = childMetadata as EntityMetadata;
            num = 15;
            continue;
          case 11:
            this._parentMetadata = parentMetadata as EntityMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 10 : 0;
            continue;
          case 12:
            goto label_2;
          case 13:
          case 14:
            if (deleteTableAction != null)
            {
              num = 16;
              continue;
            }
            goto case 7;
          case 15:
            this._oldSettings = oldSettings;
            num = 3;
            continue;
          case 16:
            goto label_4;
          case 17:
            this._moveDataAction = new DbRenameRelationTableAction.MoveDataAction(this.Transform, query);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
            continue;
          case 18:
            updater.TablesDeletedActions.Insert(updater.TablesDeletedActions.IndexOf((IDbAction) deleteTableAction), (IDbAction) this._moveDataAction);
            num = 14;
            continue;
          case 19:
            deleteTableAction = updater.TablesDeletedActions.OfType<DbDeleteTableAction>().FirstOrDefault<DbDeleteTableAction>((Func<DbDeleteTableAction, bool>) (a => DbRenameRelationTableAction.wV3tnWohyM0OyDKB2SZf(DbRenameRelationTableAction.xbUCu3ohmQjKlTMDCQeF((object) a), DbRenameRelationTableAction.x7QB1hohtE4AL7OvALcG((object) this._oldSettings), StringComparison.CurrentCultureIgnoreCase)));
            num = 2;
            continue;
          case 20:
            query = (string) DbRenameRelationTableAction.NIH3AaohD2GY11rQEv6w((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1925118608 << 2 ^ -889602474), (object) new object[9]
            {
              (object) func(this._newSettings.RelationTableName),
              (object) func(this._newSettings.ParentColumnName),
              (object) func((string) DbRenameRelationTableAction.U8qtuCohNIaX7sK5sl62((object) this._newSettings)),
              (object) func(this._oldSettings.RelationTableName),
              (object) func((string) DbRenameRelationTableAction.Y5W5gnoh3NRTUF6dqyXC((object) this._oldSettings)),
              (object) func((string) DbRenameRelationTableAction.U8qtuCohNIaX7sK5sl62((object) this._oldSettings)),
              (object) func((string) DbRenameRelationTableAction.J8Ten5ohpZ6emSct9bSL(~-306453669 ^ 306486778)),
              (object) func((string) DbRenameRelationTableAction.MTlcIRoha3stw9W3P6ys((object) this._parentMetadata)),
              (object) func(this._childMetadata.TableName)
            });
            num = 17;
            continue;
          case 21:
            goto label_25;
          case 22:
            goto label_17;
          default:
            if (deleteTableAction == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 5 : 5;
              continue;
            }
            goto case 18;
        }
      }
label_2:
      return;
label_4:
      return;
label_25:
      return;
label_17:
      return;
label_20:;
    }

    public override void Execute()
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          Column column1;
          Column column2;
          bool flag;
          Column columnForIdentifier;
          switch (num2)
          {
            case 1:
              base.Execute();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 0 : 0;
              continue;
            case 2:
              if (flag)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 3 : 5;
                continue;
              }
              goto case 10;
            case 3:
              goto label_19;
            case 4:
              ITransformationProvider transform = this.Transform;
              Table table = new Table();
              DbRenameRelationTableAction.UtdrfjohAtVVM0jeS7Gt((object) table, DbRenameRelationTableAction.x7QB1hohtE4AL7OvALcG((object) this._newSettings));
              table.Columns = new List<Column>()
              {
                column1,
                column2
              };
              DbRenameRelationTableAction.BGkPVVoh7jEFUU3EHx1c((object) transform, (object) table);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 3 : 3;
              continue;
            case 5:
              goto label_18;
            case 6:
              DbRenameRelationTableAction.wxpSdAohH0Qq4TUJwSFa((object) column1, DbRenameRelationTableAction.Y5W5gnoh3NRTUF6dqyXC((object) this._newSettings));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 14 : 7;
              continue;
            case 7:
              DbRenameRelationTableAction.wxpSdAohH0Qq4TUJwSFa((object) column2, DbRenameRelationTableAction.U8qtuCohNIaX7sK5sl62((object) this._newSettings));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 4 : 2;
              continue;
            case 8:
              DbRenameRelationTableAction.ajTGqIoh4HcW9VRy4d5V((object) this._moveDataAction, DbRenameRelationTableAction.ILJtxQohwaOD6jj3X0Ou((object) this.Transform, DbRenameRelationTableAction.x7QB1hohtE4AL7OvALcG((object) this._oldSettings)) && !flag);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 2;
              continue;
            case 9:
              columnForIdentifier = DbModelHelper.GetDefaultColumnForIdentifier();
              break;
            case 10:
              column1 = (Column) DbRenameRelationTableAction.vxQl6Moh6lUou4RYt9M2((object) this._parentMetadata);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 3 : 6;
              continue;
            case 11:
              if (this._oldSettings != null)
              {
                num2 = 16;
                continue;
              }
              goto label_29;
            case 12:
              goto label_13;
            case 13:
              columnForIdentifier = DbModelHelper.GetColumnForIdentifier(this._childMetadata);
              break;
            case 14:
              if (this._childMetadata == null)
                goto case 9;
              else
                goto label_7;
            case 15:
              if (this._moveDataAction != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 4 : 8;
                continue;
              }
              goto case 2;
            case 16:
              if (this._newSettings == null)
              {
                num2 = 12;
                continue;
              }
              flag = DbRenameRelationTableAction.ILJtxQohwaOD6jj3X0Ou((object) this.Transform, (object) this._newSettings.RelationTableName);
              num2 = 15;
              continue;
            default:
              if (this._parentMetadata != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 11;
                continue;
              }
              goto label_3;
          }
          column2 = columnForIdentifier;
          num2 = 7;
        }
label_7:
        num1 = 13;
      }
label_19:
      return;
label_18:
      return;
label_13:
      return;
label_3:
      return;
label_29:;
    }

    internal static void WIaVU0oh1AoXY1pU2vwW() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object U8qtuCohNIaX7sK5sl62([In] object obj0) => (object) ((EntitySettings) obj0).ChildColumnName;

    internal static object Y5W5gnoh3NRTUF6dqyXC([In] object obj0) => (object) ((EntitySettings) obj0).ParentColumnName;

    internal static object J8Ten5ohpZ6emSct9bSL(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object MTlcIRoha3stw9W3P6ys([In] object obj0) => (object) ((EntityMetadata) obj0).TableName;

    internal static object NIH3AaohD2GY11rQEv6w([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, (object[]) obj1);

    internal static object x7QB1hohtE4AL7OvALcG([In] object obj0) => (object) ((EntitySettings) obj0).RelationTableName;

    internal static bool drV4J6oheP8sPC05YYNF() => DbRenameRelationTableAction.huRDF7oh2kPBSu59x0ne == null;

    internal static DbRenameRelationTableAction M3T7dDohPC2l3wYV4ly5() => DbRenameRelationTableAction.huRDF7oh2kPBSu59x0ne;

    internal static bool ILJtxQohwaOD6jj3X0Ou([In] object obj0, [In] object obj1) => ((ITransformationProvider) obj0).TableExists((string) obj1);

    internal static void ajTGqIoh4HcW9VRy4d5V([In] object obj0, bool value) => ((DbRenameRelationTableAction.MoveDataAction) obj0).Enabled = value;

    internal static object vxQl6Moh6lUou4RYt9M2([In] object obj0) => (object) DbModelHelper.GetColumnForIdentifier((EntityMetadata) obj0);

    internal static void wxpSdAohH0Qq4TUJwSFa([In] object obj0, [In] object obj1) => ((Column) obj0).Name = (string) obj1;

    internal static void UtdrfjohAtVVM0jeS7Gt([In] object obj0, [In] object obj1) => ((Table) obj0).Name = (string) obj1;

    internal static void BGkPVVoh7jEFUU3EHx1c([In] object obj0, [In] object obj1) => ((ITransformationProvider) obj0).AddTable((Table) obj1);

    internal static object IqmpMLohx5imfemImkxw([In] object obj0) => (object) ((ITransformationProvider) obj0).Dialect;

    internal static object aRaccLoh0E2e1WEV86jl([In] object obj0, [In] object obj1) => (object) ((Dialect) obj0).QuoteIfNeeded((string) obj1);

    internal static object xbUCu3ohmQjKlTMDCQeF([In] object obj0) => (object) ((DbDeleteTableAction) obj0).TableName;

    internal static bool wV3tnWohyM0OyDKB2SZf([In] object obj0, [In] object obj1, [In] StringComparison obj2) => ((string) obj0).Equals((string) obj1, obj2);

    private class MoveDataAction : DbAction
    {
      private object _query;
      internal static object b2fEM0CGAkZkMZqZBx6H;

      public MoveDataAction(ITransformationProvider transform, string query)
      {
        DbRenameRelationTableAction.MoveDataAction.xV72xxCG0WPPYwl94u71();
        // ISSUE: explicit constructor call
        base.\u002Ector(transform);
        int num = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
          num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_3;
            case 1:
              this._query = (object) query;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 0 : 0;
              continue;
            default:
              goto label_5;
          }
        }
label_3:
        return;
label_5:;
      }

      public bool Enabled
      {
        get => this.\u003CEnabled\u003Ek__BackingField;
        set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this.\u003CEnabled\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }
      }

      public override void Execute()
      {
        int num = 4;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_6;
            case 1:
              goto label_2;
            case 2:
              this.Transform.ExecuteNonQuery((string) this._query);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
              continue;
            case 3:
              if (!this.Enabled)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 1;
                continue;
              }
              goto case 2;
            case 4:
              base.Execute();
              num = 3;
              continue;
            default:
              goto label_8;
          }
        }
label_6:
        return;
label_2:
        return;
label_8:;
      }

      internal static void xV72xxCG0WPPYwl94u71() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool IKP51eCG7PmAsvYcetZx() => DbRenameRelationTableAction.MoveDataAction.b2fEM0CGAkZkMZqZBx6H == null;

      internal static DbRenameRelationTableAction.MoveDataAction JcLsqOCGxD0pDBrSQAgp() => (DbRenameRelationTableAction.MoveDataAction) DbRenameRelationTableAction.MoveDataAction.b2fEM0CGAkZkMZqZBx6H;
    }
  }
}
