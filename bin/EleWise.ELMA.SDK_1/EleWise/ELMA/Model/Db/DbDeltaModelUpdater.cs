// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Db.DbDeltaModelUpdater
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Db.Helpers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.Db.Actions;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Db
{
  /// <summary>
  /// Класс для создания и обновления структур БД для дельта-сборок
  /// </summary>
  internal class DbDeltaModelUpdater : IDbDeltaModelUpdater
  {
    private readonly List<IDbAction> tablesCreatedActions;
    private readonly List<IDbAction> foreignKeysCreatedActions;
    private readonly List<IDbAction> primaryKeysCreatedActions;
    private readonly List<IDbAction> tablesDeletedActions;
    internal static DbDeltaModelUpdater ljmEIeoWJfbyfA1T4KF5;

    /// <summary>Ctor</summary>
    /// <param name="metadataList">Список измененных метаданных</param>
    public DbDeltaModelUpdater(IEnumerable<ModifedEntityPair> metadataList)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.tablesCreatedActions = new List<IDbAction>();
      this.foreignKeysCreatedActions = new List<IDbAction>();
      this.primaryKeysCreatedActions = new List<IDbAction>();
      this.tablesDeletedActions = new List<IDbAction>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      foreach (ModifedEntityPair metadata in metadataList)
      {
        DbDeltaModelUpdater.ActionCollector actionCollector = new DbDeltaModelUpdater.ActionCollector(metadata.OldMetadata, metadata.NewMetadata);
        this.tablesCreatedActions.AddRange((IEnumerable<IDbAction>) actionCollector.TablesCreatedActions);
        this.foreignKeysCreatedActions.AddRange((IEnumerable<IDbAction>) actionCollector.ForeignKeysCreatedActions);
        this.primaryKeysCreatedActions.AddRange((IEnumerable<IDbAction>) actionCollector.PrimaryKeysCreatedActions);
        this.tablesDeletedActions.AddRange((IEnumerable<IDbAction>) ((IActionsHolder) actionCollector).TablesDeletedActions);
      }
    }

    /// <summary>Преобразование структуры БД</summary>
    /// <remarks>Выполняется в 2-х транзакциях</remarks>
    /// <param name="session">Сессия БД</param>
    public void Update(ISession session)
    {
      int num1 = 3;
      ITransaction transaction;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_27;
            case 2:
              try
              {
                // ISSUE: reference to a compiler-generated method
                this.tablesCreatedActions.ForEach((Action<IDbAction>) (action => DbDeltaModelUpdater.\u003C\u003Ec.C0KKVYCbBnD69G4mT1aT((object) action)));
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
                  num3 = 0;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_13;
                    case 2:
                      List<IDbAction> keysCreatedActions = this.foreignKeysCreatedActions;
                      // ISSUE: reference to a compiler-generated field
                      Action<IDbAction> action1 = DbDeltaModelUpdater.\u003C\u003Ec.\u003C\u003E9__2_2;
                      Action<IDbAction> action2;
                      if (action1 == null)
                      {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated method
                        DbDeltaModelUpdater.\u003C\u003Ec.\u003C\u003E9__2_2 = action2 = (Action<IDbAction>) (action => DbDeltaModelUpdater.\u003C\u003Ec.C0KKVYCbBnD69G4mT1aT((object) action));
                      }
                      else
                        goto label_31;
label_22:
                      keysCreatedActions.ForEach(action2);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 3 : 3;
                      continue;
label_31:
                      action2 = action1;
                      goto label_22;
                    case 3:
                      DbDeltaModelUpdater.WvOuG1oWrO6nYkfE8E5B((object) transaction);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 1;
                      continue;
                    default:
                      // ISSUE: reference to a compiler-generated method
                      this.primaryKeysCreatedActions.ForEach((Action<IDbAction>) (action => DbDeltaModelUpdater.\u003C\u003Ec.C0KKVYCbBnD69G4mT1aT((object) action)));
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 2 : 2;
                      continue;
                  }
                }
              }
              catch
              {
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
                  num4 = 0;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      goto label_29;
                    default:
                      transaction.Rollback();
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 1 : 0;
                      continue;
                  }
                }
label_29:
                throw;
              }
            case 3:
              goto label_30;
            case 4:
label_13:
              transaction = (ITransaction) DbDeltaModelUpdater.EudOB5oWlEjUPNIg7GE1((object) session);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
              continue;
            default:
              goto label_3;
          }
        }
label_30:
        transaction = (ITransaction) DbDeltaModelUpdater.EudOB5oWlEjUPNIg7GE1((object) session);
        num1 = 2;
      }
label_27:
      return;
label_3:
      try
      {
        // ISSUE: reference to a compiler-generated method
        this.tablesDeletedActions.ForEach((Action<IDbAction>) (action => DbDeltaModelUpdater.\u003C\u003Ec.C0KKVYCbBnD69G4mT1aT((object) action)));
        int num5 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
          num5 = 0;
        while (true)
        {
          switch (num5)
          {
            case 0:
              goto label_23;
            case 1:
              DbDeltaModelUpdater.WvOuG1oWrO6nYkfE8E5B((object) transaction);
              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
              continue;
            default:
              goto label_20;
          }
        }
label_23:
        return;
label_20:;
      }
      catch
      {
        int num6 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
          num6 = 1;
        while (true)
        {
          switch (num6)
          {
            case 1:
              DbDeltaModelUpdater.mKtE60oWgjctsLVPxync((object) transaction);
              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 0;
              continue;
            default:
              goto label_12;
          }
        }
label_12:
        throw;
      }
    }

    internal static object EudOB5oWlEjUPNIg7GE1([In] object obj0) => (object) ((ISession) obj0).BeginTransaction();

    internal static void WvOuG1oWrO6nYkfE8E5B([In] object obj0) => ((ITransaction) obj0).Commit();

    internal static void mKtE60oWgjctsLVPxync([In] object obj0) => ((ITransaction) obj0).Rollback();

    internal static bool Hmw3NVoW990204mraLkW() => DbDeltaModelUpdater.ljmEIeoWJfbyfA1T4KF5 == null;

    internal static DbDeltaModelUpdater nQanyOoWduhZc0K7PGxj() => DbDeltaModelUpdater.ljmEIeoWJfbyfA1T4KF5;

    private class ActionCollector : IDbModelUpdater, IActionsHolder
    {
      private readonly object transformationProvider;
      private readonly object oldModelMetadata;
      private readonly object newModelMetadata;
      private readonly Dictionary<string, List<ForeignKey>> existingForeignKeys;
      internal static object r0hQ97CoaRyYAogGTJV8;

      /// <summary>Ctor</summary>
      /// <param name="oldMetadata">Старые метаданные</param>
      /// <param name="newMetadata">Новые метаданные</param>
      public ActionCollector(EntityMetadata oldMetadata, EntityMetadata newMetadata)
      {
        DbDeltaModelUpdater.ActionCollector.PM6wKTCowU8tjWnRfOMt();
        this.existingForeignKeys = new Dictionary<string, List<ForeignKey>>();
        this.TablesCreatedActions = new List<IDbAction>();
        this.EleWise\u002EELMA\u002ERuntime\u002EDb\u002EActions\u002EIActionsHolder\u002ETablesDeletedActions = new List<IDbAction>();
        this.ForeignKeysCreatedActions = new List<IDbAction>();
        this.PrimaryKeysCreatedActions = new List<IDbAction>();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0)
          num = 5;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.transformationProvider = (object) Locator.GetServiceNotNull<ITransformationProvider>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 2 : 3;
              continue;
            case 2:
              this.newModelMetadata = (object) newMetadata;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 1;
              continue;
            case 3:
              this.PrepareActions();
              num = 4;
              continue;
            case 4:
              goto label_3;
            case 5:
              DbDeltaModelUpdater.ActionCollector.IjeAbfCo4usVeq6i9Yc7((object) newMetadata, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1819636893 << 3 ^ 1671998486));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
              continue;
            default:
              this.oldModelMetadata = (object) oldMetadata;
              num = 2;
              continue;
          }
        }
label_3:;
      }

      /// <summary>Подготовить (создать) действия</summary>
      private void PrepareActions()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.PrepareActions((EntityMetadata) this.oldModelMetadata, (EntityMetadata) this.newModelMetadata);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      /// <summary>Подготовить (создать) действия</summary>
      /// <param name="oldMetadata">Старые метаданные</param>
      /// <param name="newMetadata">Новые метаданные</param>
      private void PrepareActions(EntityMetadata oldMetadata, EntityMetadata newMetadata)
      {
        int num1 = 26;
        List<TablePartMetadata>.Enumerator enumerator1;
        while (true)
        {
          int num2 = num1;
          string str1;
          while (true)
          {
            // ISSUE: variable of a compiler-generated type
            DbDeltaModelUpdater.ActionCollector.\u003C\u003Ec__DisplayClass7_0 cDisplayClass70;
            EntityMetadata metadataImpl;
            DbUpdateAction dbUpdateAction;
            List<PropertyMetadata>.Enumerator enumerator2;
            Table table1;
            Table table2;
            switch (num2)
            {
              case 1:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                dbUpdateAction = new DbUpdateAction((ITransformationProvider) this.transformationProvider, str1, new string[1]
                {
                  (string) DbDeltaModelUpdater.ActionCollector.TOOKcMCo9nAG6RBmcg46(993438473 ^ 993454443)
                }, new object[1]
                {
                  (object) (DbDeltaModelUpdater.ActionCollector.YZt1QgCo6yF679CeNgEI((object) cDisplayClass70.newMetadata) == EntityMetadataType.InterfaceImplementation ? cDisplayClass70.newMetadata.Uid : DbDeltaModelUpdater.ActionCollector.OmGgAlCo5sjkL8T43cms((object) cDisplayClass70.newMetadata))
                }, z2jc63fLkugS1X8Q9N.tE1kD1vbB(92412609 - 1050237057 ^ -957705386));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 23 : 17;
                continue;
              case 2:
                // ISSUE: reference to a compiler-generated field
                enumerator2 = cDisplayClass70.newMetadata.Properties.GetEnumerator();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 5 : 14;
                continue;
              case 3:
                // ISSUE: reference to a compiler-generated field
                if (cDisplayClass70.newMetadata == null)
                {
                  num2 = 4;
                  continue;
                }
                goto case 17;
              case 4:
              case 29:
                table2 = (Table) null;
                break;
              case 5:
label_32:
                // ISSUE: reference to a compiler-generated field
                if (!DbDeltaModelUpdater.ActionCollector.YJNZ4HCorcHuiwQSrDvn((object) cDisplayClass70.newMetadata))
                  goto case 8;
                else
                  goto label_33;
              case 6:
                if (oldMetadata == null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 8 : 2;
                  continue;
                }
                goto case 1;
              case 7:
                goto label_15;
              case 8:
              case 10:
                // ISSUE: reference to a compiler-generated field
                enumerator1 = cDisplayClass70.newMetadata.TableParts.GetEnumerator();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 7 : 7;
                continue;
              case 9:
                // ISSUE: reference to a compiler-generated field
                cDisplayClass70.\u003C\u003E4__this = this;
                num2 = 18;
                continue;
              case 11:
              case 21:
                goto label_35;
              case 12:
                if (!DbDeltaModelUpdater.ActionCollector.YJNZ4HCorcHuiwQSrDvn((object) oldMetadata))
                {
                  num2 = 21;
                  continue;
                }
                goto case 8;
              case 13:
              case 28:
                // ISSUE: reference to a compiler-generated field
                metadataImpl = this.GetMetadataImpl(cDisplayClass70.newMetadata);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 2 : 2;
                continue;
              case 14:
                try
                {
label_112:
                  if (enumerator2.MoveNext())
                    goto label_80;
                  else
                    goto label_113;
label_55:
                  // ISSUE: variable of a compiler-generated type
                  DbDeltaModelUpdater.ActionCollector.\u003C\u003Ec__DisplayClass7_2 cDisplayClass72;
                  EntityPropertyMetadata propertyMetadata1;
                  string str2;
                  string str3;
                  // ISSUE: variable of a compiler-generated type
                  DbDeltaModelUpdater.ActionCollector.\u003C\u003Ec__DisplayClass7_1 cDisplayClass71;
                  int num3;
                  while (true)
                  {
                    int num4;
                    List<Table>.Enumerator enumerator3;
                    TypeDbStructures typeDbStructures;
                    Action<bool, TypeDbStructures> action;
                    IPropertyTypeInfo propertyTypeInfo;
                    List<Column>.Enumerator enumerator4;
                    EntityPropertyMetadata propertyMetadata2;
                    switch (num3)
                    {
                      case 1:
                        action(true, typeDbStructures);
                        num3 = 23;
                        continue;
                      case 2:
                        goto label_32;
                      case 3:
                        // ISSUE: reference to a compiler-generated field
                        enumerator4 = cDisplayClass72.propStructures.Columns.GetEnumerator();
                        num3 = 15;
                        continue;
                      case 4:
                      case 23:
                        goto label_112;
                      case 5:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        cDisplayClass72.propStructures = (TypeDbStructures) DbDeltaModelUpdater.ActionCollector.jnI1p7Co7QZYW0Bk4hZ7((object) metadataImpl, (object) cDisplayClass72.CS\u0024\u003C\u003E8__locals2.propertyMetadata);
                        num3 = 9;
                        continue;
                      case 6:
                      case 37:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if ((string) DbDeltaModelUpdater.ActionCollector.wXcuPECoxxsIc1HmWJXh((object) cDisplayClass72.CS\u0024\u003C\u003E8__locals2.propertyMetadata) == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675542647))
                        {
                          num4 = 36;
                          break;
                        }
                        goto case 24;
                      case 7:
                      case 11:
                        propertyTypeInfo = (IPropertyTypeInfo) DbDeltaModelUpdater.ActionCollector.BTbfFYCoJPVkccgs5NqB(DbDeltaModelUpdater.ActionCollector.PQuPcqCoMEbHS5CWpXln(), DbDeltaModelUpdater.ActionCollector.kcpNuiCo0u0IM8At5WnV((object) propertyMetadata1), DbDeltaModelUpdater.ActionCollector.t7TxpiCoyNRFetu7Uf2b((object) propertyMetadata1));
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 20 : 18;
                        continue;
                      case 8:
                        // ISSUE: reference to a compiler-generated method
                        action = new Action<bool, TypeDbStructures>(cDisplayClass72.\u003CPrepareActions\u003Eb__1);
                        num3 = 12;
                        continue;
                      case 9:
                        if (oldMetadata == null)
                        {
                          num3 = 32;
                          continue;
                        }
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated method
                        propertyMetadata2 = (EntityPropertyMetadata) oldMetadata.Properties.FirstOrDefault<PropertyMetadata>(new System.Func<PropertyMetadata, bool>(cDisplayClass72.CS\u0024\u003C\u003E8__locals2.\u003CPrepareActions\u003Eb__0));
                        goto label_126;
                      case 10:
                        goto label_56;
                      case 12:
                        if (propertyMetadata1 != null)
                        {
                          num3 = 6;
                          continue;
                        }
                        goto case 3;
                      case 13:
label_116:
                        action(propertyMetadata1 == null, (TypeDbStructures) null);
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 4 : 0;
                        continue;
                      case 14:
                        goto label_80;
                      case 15:
                        try
                        {
label_106:
                          if (enumerator4.MoveNext())
                            goto label_101;
                          else
                            goto label_107;
label_100:
                          Column current;
                          int num5;
                          while (true)
                          {
                            switch (num5)
                            {
                              case 2:
                                goto label_72;
                              case 3:
                                this.TablesCreatedActions.Add((IDbAction) new DbCreateColumnAction((ITransformationProvider) this.transformationProvider, str1, current));
                                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 1 : 1;
                                continue;
                              case 4:
                                if (table1 != null)
                                {
                                  num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 5 : 1;
                                  continue;
                                }
                                goto case 3;
                              case 5:
                                table1.Columns.Add(current);
                                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
                                continue;
                              case 6:
                                goto label_101;
                              default:
                                goto label_106;
                            }
                          }
label_101:
                          current = enumerator4.Current;
                          num5 = 4;
                          goto label_100;
label_107:
                          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 1 : 2;
                          goto label_100;
                        }
                        finally
                        {
                          enumerator4.Dispose();
                          int num6 = 0;
                          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
                            num6 = 0;
                          switch (num6)
                          {
                            default:
                          }
                        }
                      case 16:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (cDisplayClass72.CS\u0024\u003C\u003E8__locals2.propertyMetadata.Settings != null)
                        {
                          num3 = 26;
                          continue;
                        }
                        goto case 1;
                      case 17:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        DbModelHelper.ApplyPropertyDbChanges((IDbModelUpdater) this, cDisplayClass72.CS\u0024\u003C\u003E8__locals2.CS\u0024\u003C\u003E8__locals1.newMetadata, cDisplayClass72.CS\u0024\u003C\u003E8__locals2.propertyMetadata, propertyMetadata1);
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 1 : 1;
                        continue;
                      case 18:
                        // ISSUE: reference to a compiler-generated field
                        cDisplayClass71.propertyMetadata = (EntityPropertyMetadata) enumerator2.Current;
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
                        continue;
                      case 19:
                        typeDbStructures = DbModelHelper.GetPropertyDbStructures(metadataImpl, propertyMetadata1);
                        num3 = 17;
                        continue;
                      case 20:
                        if (propertyTypeInfo != null)
                        {
                          // ISSUE: reference to a compiler-generated field
                          // ISSUE: reference to a compiler-generated field
                          // ISSUE: reference to a compiler-generated field
                          // ISSUE: reference to a compiler-generated field
                          if ((IPropertyTypeInfo) ((IMetadataService) DbDeltaModelUpdater.ActionCollector.PQuPcqCoMEbHS5CWpXln()).GetTypeDescriptor(DbDeltaModelUpdater.ActionCollector.kcpNuiCo0u0IM8At5WnV((object) cDisplayClass72.CS\u0024\u003C\u003E8__locals2.propertyMetadata), DbDeltaModelUpdater.ActionCollector.t7TxpiCoyNRFetu7Uf2b((object) cDisplayClass72.CS\u0024\u003C\u003E8__locals2.propertyMetadata)) != null)
                          {
                            num3 = 30;
                            continue;
                          }
                          goto label_86;
                        }
                        else
                        {
                          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 9 : 10;
                          continue;
                        }
                      case 21:
                        typeDbStructures = (TypeDbStructures) null;
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 16 : 15;
                        continue;
                      case 22:
                        // ISSUE: reference to a compiler-generated field
                        cDisplayClass72.CS\u0024\u003C\u003E8__locals2 = cDisplayClass71;
                        num3 = 5;
                        continue;
                      case 24:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (DbDeltaModelUpdater.ActionCollector.VUHnm6ComSOf8Hh2jiB2(DbDeltaModelUpdater.ActionCollector.kcpNuiCo0u0IM8At5WnV((object) cDisplayClass72.CS\u0024\u003C\u003E8__locals2.propertyMetadata), propertyMetadata1.TypeUid))
                        {
                          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 3 : 11;
                          continue;
                        }
                        goto case 34;
                      case 25:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (!DbDeltaModelUpdater.ActionCollector.kCjhPaColZqB78i6PTZf((object) cDisplayClass72.CS\u0024\u003C\u003E8__locals2.propertyMetadata).Equals(DbDeltaModelUpdater.ActionCollector.kCjhPaColZqB78i6PTZf((object) propertyMetadata1)))
                        {
                          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 19;
                          continue;
                        }
                        goto case 1;
                      case 26:
                        if (DbDeltaModelUpdater.ActionCollector.kCjhPaColZqB78i6PTZf((object) propertyMetadata1) != null)
                        {
                          num3 = 25;
                          continue;
                        }
                        goto case 1;
                      case 27:
label_72:
                        // ISSUE: reference to a compiler-generated field
                        enumerator3 = cDisplayClass72.propStructures.Tables.GetEnumerator();
                        num3 = 31;
                        continue;
                      case 28:
                        goto label_70;
                      case 29:
                        goto label_86;
                      case 30:
                        str2 = (string) DbDeltaModelUpdater.ActionCollector.LNA5GpCodiJVrVK7iBiX((object) propertyTypeInfo, (object) propertyMetadata1);
                        num3 = 33;
                        continue;
                      case 31:
                        try
                        {
label_61:
                          if (enumerator3.MoveNext())
                            goto label_64;
                          else
                            goto label_62;
label_60:
                          Table current;
                          int num7;
                          while (true)
                          {
                            switch (num7)
                            {
                              case 1:
                                goto label_64;
                              case 2:
                                goto label_61;
                              case 3:
                                this.TablesCreatedActions.Add((IDbAction) new DbCreateTableAction((ITransformationProvider) this.transformationProvider, current));
                                num7 = 2;
                                continue;
                              default:
                                goto label_116;
                            }
                          }
label_62:
                          num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
                          goto label_60;
label_64:
                          current = enumerator3.Current;
                          num7 = 3;
                          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
                          {
                            num7 = 3;
                            goto label_60;
                          }
                          else
                            goto label_60;
                        }
                        finally
                        {
                          enumerator3.Dispose();
                          int num8 = 0;
                          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
                            num8 = 0;
                          switch (num8)
                          {
                            default:
                          }
                        }
                      case 32:
                        propertyMetadata2 = (EntityPropertyMetadata) null;
                        goto label_126;
                      case 33:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        str3 = (string) DbDeltaModelUpdater.ActionCollector.LNA5GpCodiJVrVK7iBiX((object) propertyTypeInfo, (object) cDisplayClass72.CS\u0024\u003C\u003E8__locals2.propertyMetadata);
                        num4 = 28;
                        break;
                      case 34:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (!DbDeltaModelUpdater.ActionCollector.VUHnm6ComSOf8Hh2jiB2(DbDeltaModelUpdater.ActionCollector.t7TxpiCoyNRFetu7Uf2b((object) cDisplayClass72.CS\u0024\u003C\u003E8__locals2.propertyMetadata), DbDeltaModelUpdater.ActionCollector.t7TxpiCoyNRFetu7Uf2b((object) propertyMetadata1)))
                        {
                          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 6 : 21;
                          continue;
                        }
                        goto case 7;
                      case 35:
                        // ISSUE: reference to a compiler-generated field
                        cDisplayClass71.CS\u0024\u003C\u003E8__locals1 = cDisplayClass70;
                        num3 = 18;
                        continue;
                      case 36:
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        if (!(cDisplayClass72.CS\u0024\u003C\u003E8__locals2.CS\u0024\u003C\u003E8__locals1.newMetadata is TablePartMetadata))
                        {
                          num3 = 24;
                          continue;
                        }
                        goto case 21;
                      default:
                        // ISSUE: object of a compiler-generated type is created
                        cDisplayClass72 = new DbDeltaModelUpdater.ActionCollector.\u003C\u003Ec__DisplayClass7_2();
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 22 : 8;
                        continue;
                    }
                    num3 = num4;
                    continue;
label_126:
                    propertyMetadata1 = propertyMetadata2;
                    num3 = 8;
                  }
label_56:
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  throw new DbModelException(EleWise.ELMA.SR.T((string) DbDeltaModelUpdater.ActionCollector.TOOKcMCo9nAG6RBmcg46(-1876063057 ^ -1875911341), DbDeltaModelUpdater.ActionCollector.wXcuPECoxxsIc1HmWJXh((object) cDisplayClass72.CS\u0024\u003C\u003E8__locals2.propertyMetadata), DbDeltaModelUpdater.ActionCollector.wXcuPECoxxsIc1HmWJXh((object) cDisplayClass72.CS\u0024\u003C\u003E8__locals2.CS\u0024\u003C\u003E8__locals1.newMetadata), (object) DbDeltaModelUpdater.ActionCollector.kcpNuiCo0u0IM8At5WnV((object) propertyMetadata1)));
label_70:
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  throw new DbModelException(EleWise.ELMA.SR.T((string) DbDeltaModelUpdater.ActionCollector.TOOKcMCo9nAG6RBmcg46(--1333735954 ^ 1333616782), DbDeltaModelUpdater.ActionCollector.wXcuPECoxxsIc1HmWJXh((object) cDisplayClass72.CS\u0024\u003C\u003E8__locals2.propertyMetadata), DbDeltaModelUpdater.ActionCollector.wXcuPECoxxsIc1HmWJXh((object) cDisplayClass72.CS\u0024\u003C\u003E8__locals2.CS\u0024\u003C\u003E8__locals1.newMetadata), (object) str2, (object) str3));
label_86:
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  throw new DbModelException(EleWise.ELMA.SR.T((string) DbDeltaModelUpdater.ActionCollector.TOOKcMCo9nAG6RBmcg46(--1867379187 ^ 1867489295), DbDeltaModelUpdater.ActionCollector.wXcuPECoxxsIc1HmWJXh((object) cDisplayClass72.CS\u0024\u003C\u003E8__locals2.propertyMetadata), DbDeltaModelUpdater.ActionCollector.wXcuPECoxxsIc1HmWJXh((object) cDisplayClass72.CS\u0024\u003C\u003E8__locals2.CS\u0024\u003C\u003E8__locals1.newMetadata), (object) DbDeltaModelUpdater.ActionCollector.kcpNuiCo0u0IM8At5WnV((object) cDisplayClass72.CS\u0024\u003C\u003E8__locals2.propertyMetadata)));
label_80:
                  // ISSUE: object of a compiler-generated type is created
                  cDisplayClass71 = new DbDeltaModelUpdater.ActionCollector.\u003C\u003Ec__DisplayClass7_1();
                  num3 = 35;
                  goto label_55;
label_113:
                  num3 = 2;
                  goto label_55;
                }
                finally
                {
                  enumerator2.Dispose();
                  int num9 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
                    num9 = 0;
                  switch (num9)
                  {
                    default:
                  }
                }
              case 15:
                str1 = metadata.TableName;
                num2 = 13;
                continue;
              case 16:
                // ISSUE: reference to a compiler-generated field
                str1 = (string) DbDeltaModelUpdater.ActionCollector.AwcHXTCoH5ExUZ5IKg5u((object) cDisplayClass70.newMetadata);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 24 : 17;
                continue;
              case 17:
                // ISSUE: reference to a compiler-generated field
                if (DbDeltaModelUpdater.ActionCollector.YZt1QgCo6yF679CeNgEI((object) cDisplayClass70.newMetadata) == EntityMetadataType.InterfaceExtension)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 29 : 20;
                  continue;
                }
                // ISSUE: reference to a compiler-generated field
                table2 = this.PrepareTable(cDisplayClass70.newMetadata);
                break;
              case 18:
                if (oldMetadata == null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 3 : 3;
                  continue;
                }
                goto case 4;
              case 19:
                // ISSUE: reference to a compiler-generated field
                if (MetadataServiceContext.MetadataRuntimeService.GetMetadata(cDisplayClass70.newMetadata.BaseClassUid) is EntityMetadata metadata)
                {
                  num2 = 15;
                  continue;
                }
                goto case 13;
              case 20:
                goto label_131;
              case 22:
                // ISSUE: reference to a compiler-generated field
                if (cDisplayClass70.newMetadata.Type != EntityMetadataType.InterfaceExtension)
                {
                  num2 = 30;
                  continue;
                }
                goto case 8;
              case 23:
                ((IActionsHolder) this).TablesDeletedActions.Add((IDbAction) dbUpdateAction);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 7 : 10;
                continue;
              case 24:
                // ISSUE: reference to a compiler-generated field
                if (!DbDeltaModelUpdater.ActionCollector.kBSdZPCoAtB3pS069crB(DbDeltaModelUpdater.ActionCollector.AwcHXTCoH5ExUZ5IKg5u((object) cDisplayClass70.newMetadata)))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 28 : 14;
                  continue;
                }
                goto default;
              case 25:
                // ISSUE: reference to a compiler-generated field
                cDisplayClass70.newMetadata = newMetadata;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 9 : 5;
                continue;
              case 26:
                // ISSUE: object of a compiler-generated type is created
                cDisplayClass70 = new DbDeltaModelUpdater.ActionCollector.\u003C\u003Ec__DisplayClass7_0();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 10 : 25;
                continue;
              case 27:
                // ISSUE: reference to a compiler-generated field
                if (DbDeltaModelUpdater.ActionCollector.wJ9gLHCogOSgrMVLQ29E((object) cDisplayClass70.newMetadata) == Guid.Empty)
                {
                  num2 = 22;
                  continue;
                }
                goto case 8;
              case 30:
                if (oldMetadata == null)
                {
                  num2 = 11;
                  continue;
                }
                goto case 12;
              default:
                // ISSUE: reference to a compiler-generated field
                if (DbDeltaModelUpdater.ActionCollector.YZt1QgCo6yF679CeNgEI((object) cDisplayClass70.newMetadata) == EntityMetadataType.InterfaceExtension)
                {
                  num2 = 19;
                  continue;
                }
                goto case 13;
            }
            table1 = table2;
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 16 : 12;
          }
label_33:
          num1 = 27;
          continue;
label_35:
          this.TablesCreatedActions.Add((IDbAction) new DbCreateColumnAction((ITransformationProvider) this.transformationProvider, str1, new Column((string) DbDeltaModelUpdater.ActionCollector.TOOKcMCo9nAG6RBmcg46(979449278 ^ 979466204), DbType.Guid)));
          num1 = 6;
        }
label_131:
        return;
label_15:
        try
        {
label_20:
          if (enumerator1.MoveNext())
            goto label_24;
          else
            goto label_21;
label_16:
          // ISSUE: variable of a compiler-generated type
          DbDeltaModelUpdater.ActionCollector.\u003C\u003Ec__DisplayClass7_5 cDisplayClass75;
          int num10;
          while (true)
          {
            TablePartMetadata oldMetadata1;
            TablePartMetadata tablePartMetadata;
            switch (num10)
            {
              case 1:
                // ISSUE: reference to a compiler-generated method
                tablePartMetadata = oldMetadata.TableParts.FirstOrDefault<TablePartMetadata>(new System.Func<TablePartMetadata, bool>(cDisplayClass75.\u003CPrepareActions\u003Eb__7));
                break;
              case 2:
                if (oldMetadata != null)
                {
                  num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 1;
                  continue;
                }
                goto default;
              case 3:
                goto label_20;
              case 4:
                goto label_24;
              case 5:
                // ISSUE: reference to a compiler-generated field
                this.PrepareActions((EntityMetadata) oldMetadata1, (EntityMetadata) cDisplayClass75.tablePartNew);
                num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 3 : 0;
                continue;
              case 6:
                // ISSUE: reference to a compiler-generated field
                cDisplayClass75.tablePartNew = enumerator1.Current;
                num10 = 2;
                continue;
              case 7:
                goto label_127;
              default:
                tablePartMetadata = (TablePartMetadata) null;
                break;
            }
            oldMetadata1 = tablePartMetadata;
            num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 5;
          }
label_127:
          return;
label_21:
          num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 7 : 4;
          goto label_16;
label_24:
          // ISSUE: object of a compiler-generated type is created
          cDisplayClass75 = new DbDeltaModelUpdater.ActionCollector.\u003C\u003Ec__DisplayClass7_5();
          num10 = 3;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0)
          {
            num10 = 6;
            goto label_16;
          }
          else
            goto label_16;
        }
        finally
        {
          enumerator1.Dispose();
          int num11 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
            num11 = 0;
          switch (num11)
          {
            default:
          }
        }
      }

      /// <summary>Создать таблицы, если нужно</summary>
      private Table PrepareTable(EntityMetadata newMetadata)
      {
        int num1 = 2;
        string str;
        Table table;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 1:
                goto label_8;
              case 2:
                str = (string) DbDeltaModelUpdater.ActionCollector.AwcHXTCoH5ExUZ5IKg5u((object) newMetadata);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 1 : 1;
                continue;
              case 3:
                this.TablesCreatedActions.Add((IDbAction) new DbCreateTableAction((ITransformationProvider) this.transformationProvider, table));
                num2 = 4;
                continue;
              case 4:
                goto label_6;
              case 5:
                goto label_3;
              case 6:
                if (!DbDeltaModelUpdater.ActionCollector.m7qAseCojMFlGEDx4YSH(this.transformationProvider, (object) str))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 0 : 0;
                  continue;
                }
                goto label_7;
              default:
                table = this.CreateTable(newMetadata);
                num2 = 3;
                continue;
            }
          }
label_8:
          if (!DbDeltaModelUpdater.ActionCollector.kBSdZPCoAtB3pS069crB((object) str))
            num1 = 6;
          else
            break;
        }
label_3:
        return (Table) null;
label_6:
        return table;
label_7:
        throw new DbModelException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487023086), (object) str));
      }

      /// <summary>
      /// Создать новую таблицу для хранения значений переменных (в соответствии с именем context.TableName и номером context.LastTableNumber
      /// </summary>
      /// <param name="newMetadata">Новые метаданные</param>
      /// <returns>Модель таблицы</returns>
      private Table CreateTable(EntityMetadata newMetadata)
      {
        Table table = new Table();
        DbDeltaModelUpdater.ActionCollector.FaNvpoCoYtWOICUdGJZW((object) table, DbDeltaModelUpdater.ActionCollector.AwcHXTCoH5ExUZ5IKg5u((object) newMetadata));
        table.Columns = new List<Column>();
        DbDeltaModelUpdater.ActionCollector.XCbuYFCoLAK681VnVkkb((object) table, true);
        Column columnForIdentifier = DbModelHelper.GetColumnForIdentifier(newMetadata);
        columnForIdentifier.ColumnProperty = ColumnProperty.PrimaryKey;
        table.Columns.Add(columnForIdentifier);
        return table;
      }

      /// <summary>Получить внешние ключи таблицы</summary>
      /// <param name="tableName">Имя таблицы</param>
      /// <returns>Внешние ключи</returns>
      private IEnumerable<ForeignKey> GetTableForeignKeys(string tableName)
      {
        List<ForeignKey> foreignKeys;
        if (!this.existingForeignKeys.TryGetValue(tableName.ToUpper(), out foreignKeys))
        {
          foreignKeys = ((ITransformationProvider) this.transformationProvider).GetForeignKeys(tableName);
          this.existingForeignKeys[tableName.ToUpper()] = foreignKeys;
        }
        return (IEnumerable<ForeignKey>) foreignKeys;
      }

      private EntityMetadata GetMetadataImpl(EntityMetadata metadata)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (metadata != null)
              {
                if (DbDeltaModelUpdater.ActionCollector.YZt1QgCo6yF679CeNgEI((object) metadata) == EntityMetadataType.Interface)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 1 : 2;
                  continue;
                }
                if (metadata.Type == EntityMetadataType.InterfaceExtension)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 1 : 3;
                  continue;
                }
                goto label_3;
              }
              else
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 0;
                continue;
              }
            case 2:
              goto label_7;
            case 3:
              goto label_2;
            default:
              goto label_4;
          }
        }
label_2:
        return (EntityMetadata) MetadataLoader.LoadMetadata(DbDeltaModelUpdater.ActionCollector.wJ9gLHCogOSgrMVLQ29E((object) metadata));
label_3:
        return metadata;
label_4:
        return metadata;
label_7:
        return (EntityMetadata) MetadataLoader.LoadMetadata(metadata.Uid);
      }

      public List<IDbAction> TablesCreatedActions { get; }

      ITransformationProvider IDbModelUpdater.Transform => (ITransformationProvider) this.transformationProvider;

      DbUpdateMarkerService IDbModelUpdater.MarkerService => throw new NotImplementedException();

      bool IDbModelUpdater.RecreateConstraints => throw new NotImplementedException();

      string IDbModelUpdater.GenerateForeignKeyName(string tableName, string columnName) => GenerateNameHelper.GenerateForeignKeyName(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-542721635 ^ -542840265), tableName, columnName);

      string IDbModelUpdater.GeneratePrimaryKeyName(string tableName, string columnName) => (string) DbDeltaModelUpdater.ActionCollector.nMNRc1CoUnGwpY0KasbR(DbDeltaModelUpdater.ActionCollector.TOOKcMCo9nAG6RBmcg46(-1867198571 ^ -1867080659), (object) tableName, (object) columnName);

      string IDbModelUpdater.GenerateDeletingColumnTemporaryName(
        string tableName,
        string columnName)
      {
        throw new NotImplementedException();
      }

      string IDbModelUpdater.GetDeletingColumnTemporaryName(string tableName, string columnName) => throw new NotImplementedException();

      List<IDbAction> IActionsHolder.TablesDeletedActions { get; }

      public List<IDbAction> ForeignKeysCreatedActions { get; }

      public List<IDbAction> PrimaryKeysCreatedActions { get; }

      internal static void PM6wKTCowU8tjWnRfOMt() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static void IjeAbfCo4usVeq6i9Yc7([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

      internal static bool NDALb8CoD856DmE8a2E9() => DbDeltaModelUpdater.ActionCollector.r0hQ97CoaRyYAogGTJV8 == null;

      internal static DbDeltaModelUpdater.ActionCollector YAxXYICotoM7KSqAcG31() => (DbDeltaModelUpdater.ActionCollector) DbDeltaModelUpdater.ActionCollector.r0hQ97CoaRyYAogGTJV8;

      internal static EntityMetadataType YZt1QgCo6yF679CeNgEI([In] object obj0) => ((EntityMetadata) obj0).Type;

      internal static object AwcHXTCoH5ExUZ5IKg5u([In] object obj0) => (object) ((EntityMetadata) obj0).TableName;

      internal static bool kBSdZPCoAtB3pS069crB([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

      internal static object jnI1p7Co7QZYW0Bk4hZ7([In] object obj0, [In] object obj1) => (object) DbModelHelper.GetPropertyDbStructures((EntityMetadata) obj0, (EntityPropertyMetadata) obj1);

      internal static object wXcuPECoxxsIc1HmWJXh([In] object obj0) => (object) ((EleWise.ELMA.Model.Metadata.NamedMetadata) obj0).Name;

      internal static Guid kcpNuiCo0u0IM8At5WnV([In] object obj0) => ((PropertyMetadata) obj0).TypeUid;

      internal static bool VUHnm6ComSOf8Hh2jiB2([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

      internal static Guid t7TxpiCoyNRFetu7Uf2b([In] object obj0) => ((PropertyMetadata) obj0).SubTypeUid;

      internal static object PQuPcqCoMEbHS5CWpXln() => (object) MetadataServiceContext.MetadataRuntimeService;

      internal static object BTbfFYCoJPVkccgs5NqB([In] object obj0, Guid typeUid, Guid subTypeUid) => (object) ((IMetadataService) obj0).GetTypeDescriptor(typeUid, subTypeUid);

      internal static object TOOKcMCo9nAG6RBmcg46(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static object LNA5GpCodiJVrVK7iBiX([In] object obj0, [In] object obj1) => (object) ((IPropertyTypeInfo) obj0).GetPropertyTypeDisplayName((PropertyMetadata) obj1);

      internal static object kCjhPaColZqB78i6PTZf([In] object obj0) => (object) ((PropertyMetadata) obj0).Settings;

      internal static bool YJNZ4HCorcHuiwQSrDvn([In] object obj0) => ((ClassMetadata) obj0).AllowCreateHeirs;

      internal static Guid wJ9gLHCogOSgrMVLQ29E([In] object obj0) => ((ClassMetadata) obj0).BaseClassUid;

      internal static Guid OmGgAlCo5sjkL8T43cms([In] object obj0) => ((EntityMetadata) obj0).ImplementationUid;

      internal static bool m7qAseCojMFlGEDx4YSH([In] object obj0, [In] object obj1) => ((ITransformationProvider) obj0).TableExists((string) obj1);

      internal static void FaNvpoCoYtWOICUdGJZW([In] object obj0, [In] object obj1) => ((Table) obj0).Name = (string) obj1;

      internal static void XCbuYFCoLAK681VnVkkb([In] object obj0, bool value) => ((Table) obj0).Sequence = value;

      internal static object nMNRc1CoUnGwpY0KasbR([In] object obj0, [In] object obj1, [In] object obj2) => (object) GenerateNameHelper.GeneratePrimaryKeyName((string) obj0, (string) obj1, (string) obj2);
    }
  }
}
