// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Db.DbReservedWordsUpdater
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Actions;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.Db
{
  /// <summary>Обработчик изменения набора ключевых слов</summary>
  [Component(Order = -10)]
  internal class DbReservedWordsUpdater : DbUpdateHandler
  {
    private List<string> oldReservedWords;
    private List<string> newReservedWords;
    private bool hasChanges;
    private readonly Dictionary<Guid, EntityMetadata> prevMetadata;
    internal static DbReservedWordsUpdater cOUtv4Wv5DeSUhdWbbqD;

    private IEnumerable<EntityMetadata> AllEnitityMetadata => MetadataServiceContext.Service.GetMetadataList().OfType<EntityMetadata>();

    /// <summary>Сервис управления метаданными в режиме Runtime</summary>
    public IMetadataRuntimeService MetadataService
    {
      get => this.\u003CMetadataService\u003Ek__BackingField;
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
              this.\u003CMetadataService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 0 : 0;
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

    /// <summary>Для всех провайдеров</summary>
    public override Guid ProviderUid => Guid.Empty;

    /// <inheritdoc />
    public override bool HasChanges => this.hasChanges;

    /// <inheritdoc />
    public override bool NeedRecreateConstraints => this.hasChanges;

    /// <inheritdoc />
    public override void Init()
    {
      int num1 = 10;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_17;
            case 2:
              goto label_4;
            case 3:
              if (this.newReservedWords == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 1 : 0;
                continue;
              }
              break;
            case 4:
              if (DbReservedWordsUpdater.QKfGdjWvLb5L77tAPK9H((object) this.oldReservedWords) <= 0)
              {
                num2 = 5;
                continue;
              }
              goto label_14;
            case 5:
              goto label_19;
            case 6:
              goto label_14;
            case 7:
              this.FillDbActions(this.AllEnitityMetadata, this.prevMetadata, this.newReservedWords);
              num2 = 2;
              continue;
            case 8:
              goto label_8;
            case 9:
              this.InitReservedWords();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 3 : 3;
              continue;
            case 10:
              base.Init();
              num2 = 9;
              continue;
          }
          if (this.newReservedWords.Count != 0)
          {
            if (this.oldReservedWords != null)
              num2 = 4;
            else
              goto label_3;
          }
          else
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 8 : 2;
        }
label_14:
        this.LoadPreviousMetadata();
        num1 = 7;
      }
label_17:
      return;
label_4:
      return;
label_19:
      return;
label_8:
      return;
label_3:;
    }

    /// <inheritdoc />
    public override void CreateInitialStructures()
    {
      int num1 = 3;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_15;
          case 2:
            if (!DbReservedWordsUpdater.bSNxiJWvsZO2ViHriAqi((object) this.Transform, DbReservedWordsUpdater.GcrTyJWvU4CaDo91xeK1(-244066886 - -48452443 ^ -195656123)))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
              continue;
            }
            goto label_11;
          case 3:
            base.CreateInitialStructures();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 2 : 2;
            continue;
          default:
            goto label_5;
        }
      }
label_15:
      return;
label_11:
      return;
label_5:
      try
      {
        Table table1 = new Table();
        DbReservedWordsUpdater.TJn5x9WvcXPAcRlU2Bai((object) table1, false);
        DbReservedWordsUpdater.I8TrxPWvzjcuwdQBURtW((object) table1, DbReservedWordsUpdater.GcrTyJWvU4CaDo91xeK1(-1872275253 >> 6 ^ -29347277));
        table1.Columns = new List<Column>()
        {
          new Column((string) DbReservedWordsUpdater.GcrTyJWvU4CaDo91xeK1(-1867198571 ^ -1867161571), DbType.String, int.MaxValue)
        };
        Table table2 = table1;
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0)
          num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_9;
            default:
              DbReservedWordsUpdater.vMpeSfW8FPfWr9rttlFO((object) this.Transform, (object) table2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 1;
              continue;
          }
        }
label_9:;
      }
      catch
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
          num3 = 1;
        while (true)
        {
          switch (num3)
          {
            case 1:
              this.Transform.RollbackTransaction();
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 0;
              continue;
            default:
              goto label_17;
          }
        }
label_17:
        throw;
      }
    }

    /// <summary>Сохранение информации о метаданных в БД</summary>
    public override void OnComplete()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            base.OnComplete();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            this.SetReservedWords(this.newReservedWords.Union<string>((IEnumerable<string>) this.oldReservedWords));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Заполнить действия</summary>
    /// <param name="allMetadata">Метаданные</param>
    /// <param name="oldMetadata">Набор метаданных предыдущего запуска</param>
    /// <param name="reservedWords">Зарезервированные слова</param>
    protected void FillDbActions(
      IEnumerable<EntityMetadata> allMetadata,
      Dictionary<Guid, EntityMetadata> oldMetadata,
      List<string> reservedWords)
    {
      foreach (EntityMetadata entityMetadata in allMetadata)
      {
        EntityMetadata metadata = entityMetadata;
        if (metadata.Type == EntityMetadataType.InterfaceImplementation && oldMetadata.ContainsKey(metadata.Uid))
        {
          // ISSUE: reference to a compiler-generated method
          if (reservedWords.Any<string>((System.Func<string, bool>) (rw => DbReservedWordsUpdater.\u003C\u003Ec__DisplayClass19_0.HZUyy4Q30IRgrQSrqWDa((object) StringComparer.OrdinalIgnoreCase, (object) rw, (object) metadata.TableName))))
          {
            this.TablesCreatedActions.Add((IDbAction) new DbRenameTableAction(this.Transform, metadata.TableName, metadata.TableName));
            this.hasChanges = true;
          }
          foreach (PropertyMetadata property in metadata.Properties)
          {
            SimpleTypeSettings simpleTypeSettings = property.Settings as SimpleTypeSettings;
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            if (simpleTypeSettings != null && reservedWords.Any<string>((System.Func<string, bool>) (rw => DbReservedWordsUpdater.\u003C\u003Ec__DisplayClass19_1.CCdfXEQ3l1WNyNF3ycaM(DbReservedWordsUpdater.\u003C\u003Ec__DisplayClass19_1.nX7VKGQ39ctfrFDrfyGu(), (object) rw, DbReservedWordsUpdater.\u003C\u003Ec__DisplayClass19_1.qIhTleQ3dbd1Tt96m8mN((object) simpleTypeSettings)))))
            {
              this.TablesCreatedActions.Add((IDbAction) new DbRenameColumnAction(this.Transform, metadata.TableName, simpleTypeSettings.FieldName, simpleTypeSettings.FieldName));
              this.hasChanges = true;
            }
            EntitySettings entitySettings = property.Settings as EntitySettings;
            if (entitySettings != null)
            {
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              if (reservedWords.Any<string>((System.Func<string, bool>) (rw => DbReservedWordsUpdater.\u003C\u003Ec__DisplayClass19_1.CCdfXEQ3l1WNyNF3ycaM(DbReservedWordsUpdater.\u003C\u003Ec__DisplayClass19_1.nX7VKGQ39ctfrFDrfyGu(), (object) rw, DbReservedWordsUpdater.\u003C\u003Ec__DisplayClass19_1.NFhe7SQ3r6YKsw64JN4r((object) entitySettings)))))
              {
                this.TablesCreatedActions.Add((IDbAction) new DbRenameTableAction(this.Transform, entitySettings.RelationTableName, entitySettings.RelationTableName));
                this.hasChanges = true;
              }
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              if (reservedWords.Any<string>((System.Func<string, bool>) (rw => DbReservedWordsUpdater.\u003C\u003Ec__DisplayClass19_1.CCdfXEQ3l1WNyNF3ycaM((object) StringComparer.OrdinalIgnoreCase, (object) rw, DbReservedWordsUpdater.\u003C\u003Ec__DisplayClass19_1.rVCADlQ3gk4WtS7HQRXS((object) entitySettings)))))
              {
                this.TablesCreatedActions.Add((IDbAction) new DbRenameColumnAction(this.Transform, entitySettings.RelationTableName, entitySettings.ParentColumnName, entitySettings.ParentColumnName));
                this.hasChanges = true;
              }
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              if (reservedWords.Any<string>((System.Func<string, bool>) (rw => DbReservedWordsUpdater.\u003C\u003Ec__DisplayClass19_1.CCdfXEQ3l1WNyNF3ycaM(DbReservedWordsUpdater.\u003C\u003Ec__DisplayClass19_1.nX7VKGQ39ctfrFDrfyGu(), (object) rw, (object) entitySettings.ChildColumnName))))
              {
                this.TablesCreatedActions.Add((IDbAction) new DbRenameColumnAction(this.Transform, entitySettings.RelationTableName, entitySettings.ChildColumnName, entitySettings.ChildColumnName));
                this.hasChanges = true;
              }
            }
          }
        }
      }
    }

    private void InitReservedWords()
    {
      int num = 2;
      List<string> list;
      while (true)
      {
        switch (num)
        {
          case 1:
            List<string> reservedWords = ((Dialect) DbReservedWordsUpdater.L13FvjW8BMkvIH1UySSt((object) this.Transform)).ReservedWords;
            // ISSUE: reference to a compiler-generated field
            System.Func<string, bool> func = DbReservedWordsUpdater.\u003C\u003Ec.\u003C\u003E9__22_0;
            System.Func<string, bool> predicate;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              DbReservedWordsUpdater.\u003C\u003Ec.\u003C\u003E9__22_0 = predicate = (System.Func<string, bool>) (a => !string.IsNullOrEmpty(a));
            }
            else
              goto label_2;
label_14:
            list = reservedWords.Where<string>(predicate).ToList<string>();
            num = 4;
            continue;
label_2:
            predicate = func;
            goto label_14;
          case 2:
            this.InitOldReservedWords();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 1;
            continue;
          case 3:
            goto label_6;
          case 4:
            if (this.oldReservedWords == null)
            {
              num = 5;
              continue;
            }
            goto case 7;
          case 5:
          case 6:
            this.newReservedWords = list;
            num = 8;
            continue;
          case 7:
            if (DbReservedWordsUpdater.QKfGdjWvLb5L77tAPK9H((object) this.oldReservedWords) != 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
              continue;
            }
            goto case 5;
          case 8:
            goto label_12;
          default:
            this.newReservedWords = list.Where<string>((System.Func<string, bool>) (a => !this.oldReservedWords.Contains(a))).ToList<string>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 1 : 3;
            continue;
        }
      }
label_6:
      return;
label_12:;
    }

    private void InitOldReservedWords()
    {
      int num1 = 2;
      IDataReader dataReader;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_16;
          case 1:
            goto label_3;
          case 2:
            dataReader = this.Transform.ExecuteQuery((string) DbReservedWordsUpdater.oA8NGCW8oykfBgqrOLft(DbReservedWordsUpdater.GcrTyJWvU4CaDo91xeK1(1597012150 ^ 1597101854), DbReservedWordsUpdater.NAIIIMW8WKao84MDJtaY(DbReservedWordsUpdater.L13FvjW8BMkvIH1UySSt((object) this.Transform), DbReservedWordsUpdater.GcrTyJWvU4CaDo91xeK1(1581325282 << 3 ^ -234262376)), DbReservedWordsUpdater.NAIIIMW8WKao84MDJtaY((object) this.Transform.Dialect, DbReservedWordsUpdater.GcrTyJWvU4CaDo91xeK1(1021410165 ^ 1021367333))), (Dictionary<string, object>) null);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 1 : 0;
            continue;
          default:
            goto label_11;
        }
      }
label_16:
      return;
label_11:
      return;
label_3:
      try
      {
        if (!dataReader.Read())
          return;
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
          num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_2;
            case 2:
              this.oldReservedWords = this.GetReservedWords(DbReservedWordsUpdater.zOT93AW8b1bJld54IlYu((object) dataReader, DbReservedWordsUpdater.GcrTyJWvU4CaDo91xeK1(~289714581 ^ -289742366)).ToString());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 1 : 1;
              continue;
            default:
              if (!(dataReader[(string) DbReservedWordsUpdater.GcrTyJWvU4CaDo91xeK1(-1839087379 - 334718690 ^ 2121266563)] is DBNull))
              {
                num2 = 2;
                continue;
              }
              goto label_20;
          }
        }
label_2:
        return;
label_20:;
      }
      finally
      {
        if (dataReader != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_18;
              default:
                DbReservedWordsUpdater.UDiUpSW8hecK6Kxvp8n1((object) dataReader);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 1 : 1;
                continue;
            }
          }
        }
label_18:;
      }
    }

    private List<string> GetReservedWords(string reservedWords) => ((IEnumerable<string>) reservedWords.Split('\'')).Where<string>((System.Func<string, bool>) (a => !DbReservedWordsUpdater.\u003C\u003Ec.T9kuS8Q3UuKhClcYMqRH((object) a))).ToList<string>() ?? new List<string>();

    private void SetReservedWords(IEnumerable<string> reservedWords) => this.SetReservedWords(string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-53329496 >> 4 ^ -3327676), reservedWords));

    private void SetReservedWords(string reservedWords)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Transform.Insert((string) DbReservedWordsUpdater.GcrTyJWvU4CaDo91xeK1(~538519529 ^ -538478778), new string[1]
            {
              (string) DbReservedWordsUpdater.GcrTyJWvU4CaDo91xeK1(~-306453669 ^ 306557740)
            }, new object[1]{ (object) reservedWords });
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 0 : 0;
            continue;
          case 2:
            this.Transform.ExecuteNonQuery(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1242972401 >> 4 ^ 77646813) + (string) DbReservedWordsUpdater.NAIIIMW8WKao84MDJtaY(DbReservedWordsUpdater.L13FvjW8BMkvIH1UySSt((object) this.Transform), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~541731958 ^ -541819687)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    private void LoadPreviousMetadata()
    {
      int num1 = 2;
      IEnumerator<AssemblyModelsMetadata> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_19;
          case 1:
            enumerator = this.MetadataService.GetPreviousAssemblyModelsMetadataList().GetEnumerator();
            num1 = 3;
            continue;
          case 2:
            this.prevMetadata.Clear();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_3;
          default:
            goto label_18;
        }
      }
label_19:
      return;
label_18:
      return;
label_3:
      try
      {
label_8:
        if (DbReservedWordsUpdater.FfXOvFW8E991dAq8jqQ6((object) enumerator))
          goto label_7;
        else
          goto label_9;
label_4:
        AbstractMetadata metadata;
        int index;
        AbstractMetadata[] abstractMetadataArray;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_14;
            case 2:
              index = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 3 : 3;
              continue;
            case 3:
            case 5:
              if (index < abstractMetadataArray.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 8 : 4;
                continue;
              }
              goto label_8;
            case 4:
              this.AddMetadataToDictionary(this.prevMetadata, metadata);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
              continue;
            case 6:
            case 8:
              metadata = abstractMetadataArray[index];
              num2 = 4;
              continue;
            case 7:
              goto label_7;
            case 9:
              goto label_8;
            default:
              ++index;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 5 : 5;
              continue;
          }
        }
label_14:
        return;
label_7:
        abstractMetadataArray = (AbstractMetadata[]) DbReservedWordsUpdater.AtXPjcW8GRMGJK3xcAwn((object) enumerator.Current);
        num2 = 2;
        goto label_4;
label_9:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 1;
        goto label_4;
      }
      finally
      {
        int num3;
        if (enumerator == null)
          num3 = 2;
        else
          goto label_20;
label_17:
        switch (num3)
        {
          case 1:
          case 2:
        }
label_20:
        enumerator.Dispose();
        num3 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
        {
          num3 = 0;
          goto label_17;
        }
        else
          goto label_17;
      }
    }

    private void AddMetadataToDictionary(
      Dictionary<Guid, EntityMetadata> dictionary,
      AbstractMetadata metadata)
    {
      if (metadata is EntityMetadata entityMetadata)
        dictionary[metadata.Uid] = entityMetadata;
      if (!(metadata is ICompositeMetadata compositeMetadata))
        return;
      IEnumerable<IMetadata> compositeParts = compositeMetadata.GetCompositeParts();
      if (compositeParts == null)
        return;
      foreach (IMetadata metadata1 in compositeParts)
      {
        if (metadata1 is EntityMetadata metadata2)
          this.AddMetadataToDictionary(dictionary, (AbstractMetadata) metadata2);
      }
    }

    public DbReservedWordsUpdater()
    {
      DbReservedWordsUpdater.GglgcLW8flLlwJPZnJwM();
      this.oldReservedWords = new List<string>();
      this.newReservedWords = new List<string>();
      this.prevMetadata = new Dictionary<Guid, EntityMetadata>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool rGAn6dWvj7XW4hZLloFS() => DbReservedWordsUpdater.cOUtv4Wv5DeSUhdWbbqD == null;

    internal static DbReservedWordsUpdater WPf6HcWvY5iyyIS0mRKC() => DbReservedWordsUpdater.cOUtv4Wv5DeSUhdWbbqD;

    internal static int QKfGdjWvLb5L77tAPK9H([In] object obj0) => ((List<string>) obj0).Count;

    internal static object GcrTyJWvU4CaDo91xeK1(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool bSNxiJWvsZO2ViHriAqi([In] object obj0, [In] object obj1) => ((ITransformationProvider) obj0).TableExists((string) obj1);

    internal static void TJn5x9WvcXPAcRlU2Bai([In] object obj0, bool value) => ((Table) obj0).Sequence = value;

    internal static void I8TrxPWvzjcuwdQBURtW([In] object obj0, [In] object obj1) => ((Table) obj0).Name = (string) obj1;

    internal static void vMpeSfW8FPfWr9rttlFO([In] object obj0, [In] object obj1) => ((ITransformationProvider) obj0).AddTable((Table) obj1);

    internal static object L13FvjW8BMkvIH1UySSt([In] object obj0) => (object) ((ITransformationProvider) obj0).Dialect;

    internal static object NAIIIMW8WKao84MDJtaY([In] object obj0, [In] object obj1) => (object) ((Dialect) obj0).QuoteIfNeeded((string) obj1);

    internal static object oA8NGCW8oykfBgqrOLft([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static object zOT93AW8b1bJld54IlYu([In] object obj0, [In] object obj1) => ((IDataRecord) obj0)[(string) obj1];

    internal static void UDiUpSW8hecK6Kxvp8n1([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object AtXPjcW8GRMGJK3xcAwn([In] object obj0) => (object) ((AssemblyModelsMetadata) obj0).RestoreMetadata();

    internal static bool FfXOvFW8E991dAq8jqQ6([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void GglgcLW8flLlwJPZnJwM() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
