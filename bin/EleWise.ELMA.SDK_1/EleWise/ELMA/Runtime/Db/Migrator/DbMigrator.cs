// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Db.Migrator.DbMigrator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.Db.Migrator
{
  /// <summary>Мигратор БД</summary>
  public class DbMigrator
  {
    private AbstractDbMetadataProvider dbMetadataProvider;
    private readonly ILogger logger;
    private ForeignKey[] foreignKeys;
    private Index[] indexes;
    private PrimaryKey[] primaryKeys;
    private List<ForeignKey> droppingForeignKeys;
    private List<Index> droppingIndexes;
    private List<PrimaryKey> droppingPrimaryKeys;
    private ITransformationProvider transform;
    private DateTime startTime;
    private readonly EleWise.ELMA.Extensions.CollectionExtensions.DelegateComparer<ForeignKey> foreignKeyComparer;
    private readonly EleWise.ELMA.Extensions.CollectionExtensions.DelegateComparer<Index> indexComparer;
    private readonly EleWise.ELMA.Extensions.CollectionExtensions.DelegateComparer<PrimaryKey> primaryKeyComparer;
    private static DbMigrator ewQcXiWXWwBNLY7sUW6p;

    /// <summary>Ctor</summary>
    /// <param name="transform">Провайдер трансформации</param>
    public DbMigrator(ITransformationProvider transform)
    {
      DbMigrator.BF2AJ2WXhrXEPiH619Z0();
      this.logger = (ILogger) DbMigrator.LvRwyxWXEyyQYNQXJrTS(DbMigrator.lr3cdpWXGhL6a8aNFBBC(-1998538950 ^ -1998502058));
      this.droppingForeignKeys = new List<ForeignKey>();
      this.droppingIndexes = new List<Index>();
      this.droppingPrimaryKeys = new List<PrimaryKey>();
      // ISSUE: reference to a compiler-generated field
      Func<ForeignKey, ForeignKey, bool> func1 = DbMigrator.\u003C\u003Ec.\u003C\u003E9__10_0;
      Func<ForeignKey, ForeignKey, bool> equals1;
      if (func1 == null)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        DbMigrator.\u003C\u003Ec.\u003C\u003E9__10_0 = equals1 = (Func<ForeignKey, ForeignKey, bool>) ((a, b) => DbMigrator.\u003C\u003Ec.elYEIvQw0WPlMKl1cNp6(DbMigrator.\u003C\u003Ec.CbrPeGQwx0pYsxt9Jmmw((object) a), DbMigrator.\u003C\u003Ec.CbrPeGQwx0pYsxt9Jmmw((object) b)));
      }
      else
        goto label_23;
label_3:
      // ISSUE: reference to a compiler-generated field
      Func<ForeignKey, int> func2 = DbMigrator.\u003C\u003Ec.\u003C\u003E9__10_1;
      Func<ForeignKey, int> hashCode1;
      if (func2 == null)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        DbMigrator.\u003C\u003Ec.\u003C\u003E9__10_1 = hashCode1 = (Func<ForeignKey, int>) (i => DbMigrator.\u003C\u003Ec.CbrPeGQwx0pYsxt9Jmmw((object) i).GetHashCode());
      }
      else
        goto label_22;
label_5:
      this.foreignKeyComparer = new EleWise.ELMA.Extensions.CollectionExtensions.DelegateComparer<ForeignKey>(equals1, hashCode1);
      // ISSUE: reference to a compiler-generated field
      Func<Index, Index, bool> func3 = DbMigrator.\u003C\u003Ec.\u003C\u003E9__10_2;
      Func<Index, Index, bool> equals2;
      if (func3 == null)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        DbMigrator.\u003C\u003Ec.\u003C\u003E9__10_2 = equals2 = (Func<Index, Index, bool>) ((a, b) => (string) DbMigrator.\u003C\u003Ec.WDV001QwmT7c55fHkk47((object) a) == (string) DbMigrator.\u003C\u003Ec.WDV001QwmT7c55fHkk47((object) b));
      }
      else
        goto label_21;
label_7:
      // ISSUE: reference to a compiler-generated field
      Func<Index, int> func4 = DbMigrator.\u003C\u003Ec.\u003C\u003E9__10_3;
      Func<Index, int> hashCode2;
      if (func4 == null)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        DbMigrator.\u003C\u003Ec.\u003C\u003E9__10_3 = hashCode2 = (Func<Index, int>) (i => DbMigrator.\u003C\u003Ec.WDV001QwmT7c55fHkk47((object) i).GetHashCode());
      }
      else
        goto label_20;
label_9:
      this.indexComparer = new EleWise.ELMA.Extensions.CollectionExtensions.DelegateComparer<Index>(equals2, hashCode2);
      // ISSUE: reference to a compiler-generated field
      Func<PrimaryKey, PrimaryKey, bool> func5 = DbMigrator.\u003C\u003Ec.\u003C\u003E9__10_4;
      Func<PrimaryKey, PrimaryKey, bool> equals3;
      if (func5 == null)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        DbMigrator.\u003C\u003Ec.\u003C\u003E9__10_4 = equals3 = (Func<PrimaryKey, PrimaryKey, bool>) ((a, b) => DbMigrator.\u003C\u003Ec.elYEIvQw0WPlMKl1cNp6((object) a.Name, DbMigrator.\u003C\u003Ec.X1ZgvxQwyuHa3i0qqUPK((object) b)));
      }
      else
        goto label_19;
label_11:
      // ISSUE: reference to a compiler-generated field
      Func<PrimaryKey, int> func6 = DbMigrator.\u003C\u003Ec.\u003C\u003E9__10_5;
      Func<PrimaryKey, int> hashCode3;
      if (func6 == null)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        DbMigrator.\u003C\u003Ec.\u003C\u003E9__10_5 = hashCode3 = (Func<PrimaryKey, int>) (i => DbMigrator.\u003C\u003Ec.X1ZgvxQwyuHa3i0qqUPK((object) i).GetHashCode());
      }
      else
        goto label_1;
label_13:
      this.primaryKeyComparer = new EleWise.ELMA.Extensions.CollectionExtensions.DelegateComparer<PrimaryKey>(equals3, hashCode3);
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_16;
          case 2:
            this.transform = transform;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
            continue;
          default:
            this.dbMetadataProvider = transform.DbMetadataProvider;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 1 : 1;
            continue;
        }
      }
label_16:
      return;
label_1:
      hashCode3 = func6;
      goto label_13;
label_19:
      equals3 = func5;
      goto label_11;
label_20:
      hashCode2 = func4;
      goto label_9;
label_21:
      equals2 = func3;
      goto label_7;
label_22:
      hashCode1 = func2;
      goto label_5;
label_23:
      equals1 = func1;
      goto label_3;
    }

    /// <summary>Прочитать метаданные текущей БД</summary>
    public void ReadDbMetadata()
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
              this.indexes = this.dbMetadataProvider.GetIndexes().ToArray<Index>();
              num2 = 2;
              continue;
            case 2:
              goto label_3;
            case 3:
              this.primaryKeys = this.dbMetadataProvider.GetPrimaryKeys().ToArray<PrimaryKey>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 0;
              continue;
            case 4:
              goto label_7;
            default:
              this.foreignKeys = this.dbMetadataProvider.GetForeignKeys().ToArray<ForeignKey>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 1 : 0;
              continue;
          }
        }
label_7:
        DbMigrator.c7oAZrWXfhJrTnAFeIaV((object) this.logger, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~541731958 ^ -541842273));
        num1 = 3;
      }
label_3:;
    }

    /// <summary>Создать нестандатрный индекс</summary>
    /// <param name="indexName">Имя индекса</param>
    /// <param name="tableName">Имя таблицы</param>
    /// <param name="query">SQL-выражение создания индекса</param>
    public void CreateNonStandardIndex(string indexName, string tableName, string query)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (DbMigrator.ph9COfWXQSI9VojbsQJ1((object) this.transform, (object) tableName, (object) indexName))
            {
              num = 4;
              continue;
            }
            break;
          case 2:
            this.logger.DebugFormat((string) DbMigrator.lr3cdpWXGhL6a8aNFBBC(87862435 ^ 87907301), (object) indexName, (object) tableName, (object) query);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 1 : 0;
            continue;
          case 3:
            goto label_5;
          case 4:
            goto label_2;
        }
        this.transform.ExecuteNonQuery(query);
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 3 : 1;
      }
label_5:
      return;
label_2:;
    }

    /// <summary>
    /// Создать стандартный индекс (через метод TransformationProvider)
    /// </summary>
    /// <param name="index">Объявление индекса</param>
    /// <param name="isUnique">Уникальный индекс или нет</param>
    public void CreateStandardIndex(Index index, bool isUnique = false)
    {
      int num1 = 8;
      while (true)
      {
        int num2 = num1;
        string str1;
        while (true)
        {
          string str2;
          object obj;
          switch (num2)
          {
            case 1:
              if (!isUnique)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 9 : 9;
                continue;
              }
              goto case 2;
            case 2:
              DbMigrator.y0IdwNWX8yW9CuqLCx89((object) this.transform, (object) index);
              num2 = 6;
              continue;
            case 3:
              this.logger.DebugFormat((string) DbMigrator.lr3cdpWXGhL6a8aNFBBC(-1876063057 ^ -1876133045), (object) str2, DbMigrator.OelBAFWXCPI5bKNQeR59((object) index), (object) str1, DbMigrator.N2bf4PWXvVePpgZvkB9k((object) index));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 1 : 0;
              continue;
            case 4:
              goto label_12;
            case 5:
              obj = DbMigrator.lr3cdpWXGhL6a8aNFBBC(-1978478350 ^ -1978456288);
              break;
            case 6:
              goto label_7;
            case 7:
              goto label_8;
            case 8:
              if (index.Columns == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 6 : 7;
                continue;
              }
              goto label_16;
            case 9:
              this.transform.AddIndex(index);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 4 : 3;
              continue;
            case 10:
              if (isUnique)
              {
                num2 = 5;
                continue;
              }
              goto default;
            default:
              obj = (object) "";
              break;
          }
          str2 = (string) obj;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 3 : 3;
        }
label_8:
        string str3 = "";
        goto label_17;
label_16:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        str3 = string.Join((string) DbMigrator.lr3cdpWXGhL6a8aNFBBC(874012245 ^ 873991333), index.Columns.Select<string, string>((Func<string, string>) (c => (string) DbMigrator.\u003C\u003Ec.C5xYtoQwMi18vEjZOBea(1178210108 ^ 1178210916) + c + (string) DbMigrator.\u003C\u003Ec.C5xYtoQwMi18vEjZOBea(1917998801 >> 2 ^ 479496428))));
label_17:
        str1 = str3;
        num1 = 10;
      }
label_12:
      return;
label_7:;
    }

    /// <summary>Пометить отбрасываемый индекс</summary>
    /// <param name="droppingIndex">Объявление отбрасываемого индекса</param>
    public void MarkDroppingIndex(Index droppingIndex)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.droppingIndexes.Add(droppingIndex);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Пометить отбрасываемый индекс</summary>
    /// <param name="indexName">Имя индекса</param>
    /// <param name="tableName">Имя таблицы</param>
    public void MarkDroppingIndex(string indexName, string tableName)
    {
      int num = 2;
      Index index1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.droppingIndexes.Add(index1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
            continue;
          case 2:
            Index index2 = new Index();
            DbMigrator.BWkag1WXZ3TvKUSJ8dM1((object) index2, (object) indexName);
            DbMigrator.t8OnHHWXuKBut4a2fTae((object) index2, (object) tableName);
            index2.Columns = new List<string>();
            index1 = index2;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    /// <summary>
    /// Отметить метаданные БД, затронутые изменениями в модели данных
    /// </summary>
    /// <param name="tableName">Имя таблицы, которое перестало существовать</param>
    /// <param name="columnName">Имя колонки, которое перестало существовать (необязательно)</param>
    public void MarkTouchedDbMetadata(string tableName, string columnName = null)
    {
      int num1 = 2;
      while (true)
      {
        IEnumerable<ForeignKey> dependantForeignKeys;
        IEnumerator<Index> enumerator1;
        string str1;
        IEnumerable<Index> dependantIndexes;
        IEnumerable<PrimaryKey> dependantPrimaryKeys;
        IEnumerator<PrimaryKey> enumerator2;
        IEnumerator<ForeignKey> enumerator3;
        object obj;
        switch (num1)
        {
          case 1:
            dependantIndexes = this.GetDependantIndexes(tableName, columnName);
            num1 = 14;
            continue;
          case 2:
            dependantForeignKeys = this.GetDependantForeignKeys(tableName, columnName);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 1 : 0;
            continue;
          case 3:
label_26:
            enumerator2 = dependantPrimaryKeys.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 0 : 0;
            continue;
          case 4:
label_23:
            enumerator1 = dependantIndexes.GetEnumerator();
            num1 = 11;
            continue;
          case 5:
            this.AppendDroppingPrimaryKeys(dependantPrimaryKeys);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 6 : 0;
            continue;
          case 6:
            goto label_54;
          case 7:
            try
            {
label_49:
              if (DbMigrator.sPSqMrWXqyGAY7VrepkI((object) enumerator3))
                goto label_47;
              else
                goto label_50;
label_43:
              ForeignKey current;
              string str2;
              string str3;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    str3 = string.Join((string) DbMigrator.lr3cdpWXGhL6a8aNFBBC(1505778440 - 1981636111 ^ -475877879), (IEnumerable<string>) current.Columns);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 0 : 0;
                    continue;
                  case 2:
                    goto label_23;
                  case 3:
                    goto label_47;
                  case 4:
                    goto label_49;
                  case 5:
                    this.logger.DebugFormat((string) DbMigrator.lr3cdpWXGhL6a8aNFBBC(-2099751081 ^ -2099662935), DbMigrator.Ij5eDuWXSTNOZgJbUo25((object) current), DbMigrator.ATQvRiWXiSoEdwmDyoFc((object) current), (object) str3, DbMigrator.H7OshIWXRKjDqIh56KO1((object) current), (object) str2);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 4 : 0;
                    continue;
                  default:
                    str2 = string.Join((string) DbMigrator.lr3cdpWXGhL6a8aNFBBC(87862435 ^ 87883347), (IEnumerable<string>) current.RefColumns);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 5 : 3;
                    continue;
                }
              }
label_47:
              current = enumerator3.Current;
              num2 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
              {
                num2 = 0;
                goto label_43;
              }
              else
                goto label_43;
label_50:
              num2 = 2;
              goto label_43;
            }
            finally
            {
              int num3;
              if (enumerator3 == null)
                num3 = 2;
              else
                goto label_55;
label_53:
              switch (num3)
              {
                case 1:
                  break;
                default:
              }
label_55:
              enumerator3.Dispose();
              num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
              {
                num3 = 0;
                goto label_53;
              }
              else
                goto label_53;
            }
          case 8:
            if (columnName == null)
            {
              num1 = 12;
              continue;
            }
            obj = DbMigrator.KFaGuTWXVcap6lxmhqxS(DbMigrator.lr3cdpWXGhL6a8aNFBBC(1052221104 - 768835541 ^ 283502207), (object) columnName, (object) tableName);
            break;
          case 9:
            enumerator3 = dependantForeignKeys.GetEnumerator();
            num1 = 7;
            continue;
          case 10:
label_2:
            this.AppendDroppingForeignKeys(dependantForeignKeys);
            num1 = 15;
            continue;
          case 11:
            try
            {
label_9:
              if (DbMigrator.sPSqMrWXqyGAY7VrepkI((object) enumerator1))
                goto label_6;
              else
                goto label_10;
label_4:
              Index current;
              string str4;
              int num4;
              while (true)
              {
                switch (num4)
                {
                  case 1:
                    goto label_9;
                  case 2:
                    goto label_6;
                  case 3:
                    this.logger.DebugFormat((string) DbMigrator.lr3cdpWXGhL6a8aNFBBC(-1998538950 ^ -1998500288), DbMigrator.OelBAFWXCPI5bKNQeR59((object) current), (object) str4);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 1 : 1;
                    continue;
                  case 4:
                    goto label_26;
                  default:
                    str4 = string.Join((string) DbMigrator.lr3cdpWXGhL6a8aNFBBC(-35995181 ^ -36007133), (IEnumerable<string>) current.Columns);
                    num4 = 3;
                    continue;
                }
              }
label_6:
              current = enumerator1.Current;
              num4 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
              {
                num4 = 0;
                goto label_4;
              }
              else
                goto label_4;
label_10:
              num4 = 4;
              goto label_4;
            }
            finally
            {
              if (enumerator1 != null)
              {
                int num5 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
                  num5 = 1;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      DbMigrator.kuQaNJWXKlZ5Rmcwxj9A((object) enumerator1);
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_16;
                  }
                }
              }
label_16:;
            }
          case 12:
            obj = DbMigrator.mmdFCuWXIoot7LU5Hi4h(DbMigrator.lr3cdpWXGhL6a8aNFBBC(1178210108 ^ 1178335062), (object) tableName);
            break;
          case 13:
            DbMigrator.c7oAZrWXfhJrTnAFeIaV((object) this.logger, (object) str1);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 4 : 9;
            continue;
          case 14:
            dependantPrimaryKeys = this.GetDependantPrimaryKeys(tableName, columnName);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 8 : 8;
            continue;
          case 15:
            this.AppendDroppingIndexes(dependantIndexes);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 4 : 5;
            continue;
          default:
            try
            {
label_32:
              if (DbMigrator.sPSqMrWXqyGAY7VrepkI((object) enumerator2))
                goto label_30;
              else
                goto label_33;
label_29:
              PrimaryKey current;
              int num6;
              while (true)
              {
                switch (num6)
                {
                  case 1:
                    goto label_2;
                  case 2:
                    goto label_32;
                  case 3:
                    goto label_30;
                  default:
                    this.logger.DebugFormat((string) DbMigrator.lr3cdpWXGhL6a8aNFBBC(-675505729 ^ -675454961), DbMigrator.l67FwpWXXX9xJEo6EXbJ((object) current));
                    num6 = 2;
                    continue;
                }
              }
label_30:
              current = enumerator2.Current;
              num6 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
              {
                num6 = 0;
                goto label_29;
              }
              else
                goto label_29;
label_33:
              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 1 : 1;
              goto label_29;
            }
            finally
            {
              if (enumerator2 != null)
              {
                int num7 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
                  num7 = 0;
                while (true)
                {
                  switch (num7)
                  {
                    case 1:
                      goto label_40;
                    default:
                      DbMigrator.kuQaNJWXKlZ5Rmcwxj9A((object) enumerator2);
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 1 : 1;
                      continue;
                  }
                }
              }
label_40:;
            }
        }
        str1 = (string) obj;
        num1 = 13;
      }
label_54:;
    }

    /// <summary>Действие при начале миграции БД</summary>
    public void OnMigrationStart()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            DbMigrator.c7oAZrWXfhJrTnAFeIaV((object) this.logger, DbMigrator.lr3cdpWXGhL6a8aNFBBC(-2107978722 ^ -2107951624));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
            continue;
          case 2:
            this.startTime = DateTime.Now;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    /// <summary>Действие при завершении миграции БД</summary>
    public void OnMigrationEnd()
    {
      int num1 = 2;
      while (true)
      {
        int num2 = num1;
        TimeSpan timeSpan;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_3;
            case 1:
              goto label_5;
            case 2:
              timeSpan = DbMigrator.PZYdEjWXT8xsGwC6BQsd() - this.startTime;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 1 : 0;
              continue;
            case 3:
              this.logger.DebugFormat((string) DbMigrator.lr3cdpWXGhL6a8aNFBBC(-1120607109 - 305487170 ^ -1426162409), (object) timeSpan);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
              continue;
            default:
              goto label_7;
          }
        }
label_5:
        this.logger.Debug(DbMigrator.lr3cdpWXGhL6a8aNFBBC(1470998129 - 231418599 ^ 1239646598));
        num1 = 3;
      }
label_3:
      return;
label_7:;
    }

    /// <summary>Действие после сброса индексов</summary>
    public void OnIndexesDropped()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.logger.DebugFormat((string) DbMigrator.lr3cdpWXGhL6a8aNFBBC(1033719030 - 2012070891 ^ -978422947), (object) DbMigrator.EVyqlLWXk2pPeIx2CYX1((object) this.droppingPrimaryKeys), (object) this.primaryKeys.Length, (object) DbMigrator.YXNk7JWXnpHtdb0h3vsN((object) this.droppingForeignKeys), (object) this.foreignKeys.Length, (object) this.droppingIndexes.Count, (object) this.indexes.Length);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Отбросить отмеченные внешние ключи</summary>
    public void DropMarkedForeignKeys()
    {
      int num1 = 5;
      List<ForeignKey>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            try
            {
label_22:
              if (enumerator.MoveNext())
                goto label_21;
              else
                goto label_23;
label_17:
              int num2;
              int num3 = num2;
label_18:
              ForeignKey current;
              string str1;
              string str2;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    goto label_22;
                  case 2:
                    this.logger.DebugFormat((string) DbMigrator.lr3cdpWXGhL6a8aNFBBC(1470998129 - 231418599 ^ 1239646268), DbMigrator.Ij5eDuWXSTNOZgJbUo25((object) current), DbMigrator.ATQvRiWXiSoEdwmDyoFc((object) current), (object) str1, (object) current.RefTableName, (object) str2);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 1 : 1;
                    continue;
                  case 3:
                    goto label_15;
                  case 4:
                    str1 = string.Join((string) DbMigrator.lr3cdpWXGhL6a8aNFBBC(~-306453669 ^ 306466388), (IEnumerable<string>) current.Columns);
                    num3 = 5;
                    continue;
                  case 5:
                    goto label_20;
                  default:
                    goto label_21;
                }
              }
label_20:
              str2 = string.Join((string) DbMigrator.lr3cdpWXGhL6a8aNFBBC(1033719030 - 2012070891 ^ -978330629), (IEnumerable<string>) current.RefColumns);
              num2 = 2;
              goto label_17;
label_21:
              current = enumerator.Current;
              num3 = 4;
              goto label_18;
label_23:
              num2 = 3;
              goto label_17;
            }
            finally
            {
              enumerator.Dispose();
              int num4 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
                num4 = 0;
              switch (num4)
              {
                default:
              }
            }
          case 2:
            goto label_29;
          case 3:
            goto label_2;
          case 4:
            enumerator = this.droppingForeignKeys.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 1 : 1;
            continue;
          case 5:
            DbMigrator.c7oAZrWXfhJrTnAFeIaV((object) this.logger, DbMigrator.lr3cdpWXGhL6a8aNFBBC(-345420348 ^ -345459132));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 3 : 4;
            continue;
        }
label_15:
        enumerator = this.droppingForeignKeys.GetEnumerator();
        num1 = 3;
      }
label_29:
      return;
label_2:
      try
      {
label_5:
        if (enumerator.MoveNext())
          goto label_7;
        else
          goto label_6;
label_3:
        ForeignKey current;
        int num5;
        while (true)
        {
          switch (num5)
          {
            case 1:
              DbMigrator.xLV8KiWXOQL9KsADjtRa((object) this.transform, DbMigrator.ATQvRiWXiSoEdwmDyoFc((object) current), DbMigrator.Ij5eDuWXSTNOZgJbUo25((object) current));
              num5 = 3;
              continue;
            case 2:
              goto label_25;
            case 3:
              goto label_5;
            default:
              goto label_7;
          }
        }
label_25:
        return;
label_6:
        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 1 : 2;
        goto label_3;
label_7:
        current = enumerator.Current;
        num5 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
        {
          num5 = 1;
          goto label_3;
        }
        else
          goto label_3;
      }
      finally
      {
        enumerator.Dispose();
        int num6 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0)
          num6 = 0;
        switch (num6)
        {
          default:
        }
      }
    }

    /// <summary>Отбросить отмеченные первичные ключи</summary>
    public void DropMarkedPrimaryKeys()
    {
      int num1 = 2;
      List<PrimaryKey>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_27;
          case 1:
            enumerator = this.droppingPrimaryKeys.GetEnumerator();
            num1 = 3;
            continue;
          case 2:
            DbMigrator.c7oAZrWXfhJrTnAFeIaV((object) this.logger, DbMigrator.lr3cdpWXGhL6a8aNFBBC(-1445902765 ^ -1980277732 ^ 539485803));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 1 : 1;
            continue;
          case 3:
            try
            {
label_6:
              if (enumerator.MoveNext())
                goto label_8;
              else
                goto label_7;
label_3:
              PrimaryKey current;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_30;
                  case 2:
                    goto label_6;
                  case 3:
                    this.logger.DebugFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1290212282 ^ -644262414 ^ 1786791406), DbMigrator.l67FwpWXXX9xJEo6EXbJ((object) current), DbMigrator.JlFWt8WX22hB5voVjvrC((object) current));
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 2 : 0;
                    continue;
                  case 4:
                    string.Join((string) DbMigrator.lr3cdpWXGhL6a8aNFBBC(1470998129 - 231418599 ^ 1239558522), (IEnumerable<string>) current.Columns);
                    num2 = 3;
                    continue;
                  default:
                    goto label_8;
                }
              }
label_7:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 1 : 1;
              goto label_3;
label_8:
              current = enumerator.Current;
              num2 = 4;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
              {
                num2 = 1;
                goto label_3;
              }
              else
                goto label_3;
            }
            finally
            {
              enumerator.Dispose();
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
                num3 = 0;
              switch (num3)
              {
                default:
              }
            }
          case 4:
label_30:
            enumerator = this.droppingPrimaryKeys.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 2 : 5;
            continue;
          case 5:
            goto label_15;
          default:
            goto label_23;
        }
      }
label_27:
      return;
label_23:
      return;
label_15:
      try
      {
label_18:
        if (enumerator.MoveNext())
          goto label_20;
        else
          goto label_19;
label_16:
        PrimaryKey current;
        int num4;
        while (true)
        {
          switch (num4)
          {
            case 1:
              DbMigrator.HPGEGnWXeAphfOX4ZJLk((object) this.transform, DbMigrator.JlFWt8WX22hB5voVjvrC((object) current), DbMigrator.l67FwpWXXX9xJEo6EXbJ((object) current));
              num4 = 2;
              continue;
            case 2:
              goto label_18;
            case 3:
              goto label_17;
            default:
              goto label_20;
          }
        }
label_17:
        return;
label_19:
        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 3 : 3;
        goto label_16;
label_20:
        current = enumerator.Current;
        num4 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
        {
          num4 = 1;
          goto label_16;
        }
        else
          goto label_16;
      }
      finally
      {
        enumerator.Dispose();
        int num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
          num5 = 0;
        switch (num5)
        {
          default:
        }
      }
    }

    /// <summary>Отбросить отмеченные индексы</summary>
    public void DropMarkedIndexes()
    {
      int num1 = 5;
      List<Index>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_17;
          case 2:
            goto label_28;
          case 3:
label_16:
            enumerator = this.droppingIndexes.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 1 : 1;
            continue;
          case 4:
            enumerator = this.droppingIndexes.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
            continue;
          case 5:
            this.logger.Debug((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(694673736 ^ -23604109 ^ -672020089));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 4 : 1;
            continue;
          default:
            try
            {
label_10:
              if (enumerator.MoveNext())
                goto label_8;
              else
                goto label_11;
label_6:
              Index current;
              string str;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_8;
                  case 2:
                    this.logger.DebugFormat((string) DbMigrator.lr3cdpWXGhL6a8aNFBBC(1461825605 - 1531863589 ^ -70077752), DbMigrator.OelBAFWXCPI5bKNQeR59((object) current), DbMigrator.N2bf4PWXvVePpgZvkB9k((object) current), (object) str);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 3 : 1;
                    continue;
                  case 3:
                    goto label_10;
                  case 4:
                    str = string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837683573), (IEnumerable<string>) current.Columns);
                    num2 = 2;
                    continue;
                  default:
                    goto label_16;
                }
              }
label_8:
              current = enumerator.Current;
              num2 = 4;
              goto label_6;
label_11:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
              goto label_6;
            }
            finally
            {
              enumerator.Dispose();
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
                num3 = 0;
              switch (num3)
              {
                default:
              }
            }
        }
      }
label_28:
      return;
label_17:
      try
      {
label_21:
        if (enumerator.MoveNext())
          goto label_20;
        else
          goto label_22;
label_18:
        Index current;
        int num4;
        while (true)
        {
          switch (num4)
          {
            case 0:
              goto label_24;
            case 1:
              goto label_20;
            case 2:
              goto label_21;
            case 3:
              this.transform.RemoveIndex((string) DbMigrator.N2bf4PWXvVePpgZvkB9k((object) current), (string) DbMigrator.OelBAFWXCPI5bKNQeR59((object) current));
              num4 = 2;
              continue;
            default:
              goto label_19;
          }
        }
label_24:
        return;
label_19:
        return;
label_20:
        current = enumerator.Current;
        num4 = 3;
        goto label_18;
label_22:
        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
        goto label_18;
      }
      finally
      {
        enumerator.Dispose();
        int num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
          num5 = 0;
        switch (num5)
        {
          default:
        }
      }
    }

    private void AppendDroppingForeignKeys(IEnumerable<ForeignKey> foreignKeys) => this.droppingForeignKeys.AddRange(foreignKeys.Except<ForeignKey>((IEnumerable<ForeignKey>) this.droppingForeignKeys, (IEqualityComparer<ForeignKey>) this.foreignKeyComparer));

    private void AppendDroppingIndexes(IEnumerable<Index> indexes) => this.droppingIndexes.AddRange(indexes.Except<Index>((IEnumerable<Index>) this.droppingIndexes, (IEqualityComparer<Index>) this.indexComparer));

    private void AppendDroppingPrimaryKeys(IEnumerable<PrimaryKey> primaryKeys) => this.droppingPrimaryKeys.AddRange(primaryKeys.Except<PrimaryKey>((IEnumerable<PrimaryKey>) this.droppingPrimaryKeys, (IEqualityComparer<PrimaryKey>) this.primaryKeyComparer));

    private IEnumerable<ForeignKey> GetDependantForeignKeys(string tableName, string columnName = null)
    {
      tableName = this.dbMetadataProvider.GetAsDbIdentifier(tableName);
      columnName = this.dbMetadataProvider.GetAsDbIdentifier(columnName);
      bool isNullColumnName = string.IsNullOrEmpty(columnName);
      return ((IEnumerable<ForeignKey>) this.foreignKeys).Where<ForeignKey>((Func<ForeignKey, bool>) (fk =>
      {
        int num = 5;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (fk.Columns.Contains(columnName))
              {
                num = 2;
                continue;
              }
              goto case 4;
            case 2:
              goto label_11;
            case 3:
              if (!isNullColumnName)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 1 : 1;
                continue;
              }
              goto label_11;
            case 4:
            case 6:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              if (DbMigrator.\u003C\u003Ec__DisplayClass29_0.SSDDaPQwghfAc6dJsTDx(DbMigrator.\u003C\u003Ec__DisplayClass29_0.fYu1XeQw5PyDRldUgmZr((object) fk), (object) tableName))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
                continue;
              }
              goto label_10;
            case 5:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              if (!DbMigrator.\u003C\u003Ec__DisplayClass29_0.SSDDaPQwghfAc6dJsTDx(DbMigrator.\u003C\u003Ec__DisplayClass29_0.bL2b7lQwrg4jE782cNsu((object) fk), (object) tableName))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 1 : 4;
                continue;
              }
              goto case 3;
            case 7:
              goto label_8;
            default:
              if (!isNullColumnName)
              {
                num = 7;
                continue;
              }
              goto label_9;
          }
        }
label_8:
        return fk.RefColumns.Contains(columnName);
label_9:
        return true;
label_10:
        return false;
label_11:
        return true;
      }));
    }

    private IEnumerable<Index> GetDependantIndexes(string tableName, string columnName = null)
    {
      tableName = this.dbMetadataProvider.GetAsDbIdentifier(tableName);
      columnName = this.dbMetadataProvider.GetAsDbIdentifier(columnName);
      bool isNullColumnName = string.IsNullOrEmpty(columnName);
      return ((IEnumerable<Index>) this.indexes).Where<Index>((Func<Index, bool>) (idx =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              if (DbMigrator.\u003C\u003Ec__DisplayClass30_0.Bi0CUJQwcitnUnORY7hE(DbMigrator.\u003C\u003Ec__DisplayClass30_0.tQvmlmQwsCcYjuEvi8ak((object) idx), (object) tableName))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
                continue;
              }
              goto label_6;
            case 2:
              goto label_4;
            default:
              if (!isNullColumnName)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 1 : 2;
                continue;
              }
              goto label_5;
          }
        }
label_4:
        return idx.Columns.Contains(columnName);
label_5:
        return true;
label_6:
        return false;
      }));
    }

    private IEnumerable<PrimaryKey> GetDependantPrimaryKeys(string tableName, string columnName = null)
    {
      tableName = this.dbMetadataProvider.GetAsDbIdentifier(tableName);
      columnName = this.dbMetadataProvider.GetAsDbIdentifier(columnName);
      bool isNullColumnName = string.IsNullOrEmpty(columnName);
      return ((IEnumerable<PrimaryKey>) this.primaryKeys).Where<PrimaryKey>((Func<PrimaryKey, bool>) (pk =>
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (!isNullColumnName)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            case 2:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              if (DbMigrator.\u003C\u003Ec__DisplayClass31_0.SedAT8Q4oIibTeCEQohF(DbMigrator.\u003C\u003Ec__DisplayClass31_0.iT1ihAQ4WiZRt8h9ai6A((object) pk), (object) tableName))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 1 : 1;
                continue;
              }
              goto label_4;
            default:
              goto label_2;
          }
        }
label_2:
        return pk.Columns.Contains(columnName);
label_3:
        return true;
label_4:
        return false;
      }));
    }

    internal static void BF2AJ2WXhrXEPiH619Z0() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object lr3cdpWXGhL6a8aNFBBC(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object LvRwyxWXEyyQYNQXJrTS([In] object obj0) => (object) Logger.GetLogger((string) obj0);

    internal static bool U9hy0yWXoYw24MWoNo4D() => DbMigrator.ewQcXiWXWwBNLY7sUW6p == null;

    internal static DbMigrator rMewIuWXbnhdCdGXlZvE() => DbMigrator.ewQcXiWXWwBNLY7sUW6p;

    internal static void c7oAZrWXfhJrTnAFeIaV([In] object obj0, [In] object obj1) => ((ILogger) obj0).Debug(obj1);

    internal static bool ph9COfWXQSI9VojbsQJ1([In] object obj0, [In] object obj1, [In] object obj2) => ((ITransformationProvider) obj0).IndexExists((string) obj1, (string) obj2);

    internal static object OelBAFWXCPI5bKNQeR59([In] object obj0) => (object) ((Index) obj0).Name;

    internal static object N2bf4PWXvVePpgZvkB9k([In] object obj0) => (object) ((Index) obj0).TableName;

    internal static void y0IdwNWX8yW9CuqLCx89([In] object obj0, [In] object obj1) => ((ITransformationProvider) obj0).AddUniqueIndex((Index) obj1);

    internal static void BWkag1WXZ3TvKUSJ8dM1([In] object obj0, [In] object obj1) => ((Index) obj0).Name = (string) obj1;

    internal static void t8OnHHWXuKBut4a2fTae([In] object obj0, [In] object obj1) => ((Index) obj0).TableName = (string) obj1;

    internal static object mmdFCuWXIoot7LU5Hi4h([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static object KFaGuTWXVcap6lxmhqxS([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static object Ij5eDuWXSTNOZgJbUo25([In] object obj0) => (object) ((ForeignKey) obj0).Name;

    internal static object ATQvRiWXiSoEdwmDyoFc([In] object obj0) => (object) ((ForeignKey) obj0).TableName;

    internal static object H7OshIWXRKjDqIh56KO1([In] object obj0) => (object) ((ForeignKey) obj0).RefTableName;

    internal static bool sPSqMrWXqyGAY7VrepkI([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void kuQaNJWXKlZ5Rmcwxj9A([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object l67FwpWXXX9xJEo6EXbJ([In] object obj0) => (object) ((PrimaryKey) obj0).Name;

    internal static DateTime PZYdEjWXT8xsGwC6BQsd() => DateTime.Now;

    internal static int EVyqlLWXk2pPeIx2CYX1([In] object obj0) => ((List<PrimaryKey>) obj0).Count;

    internal static int YXNk7JWXnpHtdb0h3vsN([In] object obj0) => ((List<ForeignKey>) obj0).Count;

    internal static void xLV8KiWXOQL9KsADjtRa([In] object obj0, [In] object obj1, [In] object obj2) => ((ITransformationProvider) obj0).RemoveForeignKey((string) obj1, (string) obj2);

    internal static object JlFWt8WX22hB5voVjvrC([In] object obj0) => (object) ((PrimaryKey) obj0).TableName;

    internal static void HPGEGnWXeAphfOX4ZJLk([In] object obj0, [In] object obj1, [In] object obj2) => ((ITransformationProvider) obj0).RemovePrimaryKey((string) obj1, (string) obj2);
  }
}
