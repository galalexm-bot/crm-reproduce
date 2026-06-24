// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Db.DbMetadata
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using SG9KiyIbtdgGDf12qr;
using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Db
{
  public static class DbMetadata
  {
    private static DbMetadata zkFyf7ohCgPtvk9oEeXX;

    public static void CreateStructures(ITransformationProvider transform, int version)
    {
      int num = 1;
      Table table1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_5;
          case 1:
            if (version != 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 0 : 0;
              continue;
            }
            goto case 3;
          case 2:
            goto label_10;
          case 3:
            if (!DbMetadata.RPJkaCohuqqNIv52cCpD((object) transform, DbMetadata.PvHukIohZwulCdZ3aBvJ(-1978478350 ^ -1978441688)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 5;
              continue;
            }
            goto label_2;
          case 4:
            DbMetadata.z8H4m3ohVk4D6qxiaQ0N((object) transform, (object) table1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 2 : 1;
            continue;
          case 5:
            Table table2 = new Table();
            table2.Name = (string) DbMetadata.PvHukIohZwulCdZ3aBvJ(-812025778 ^ -812070764);
            List<Column> columnList = new List<Column>();
            Column column = new Column((string) DbMetadata.PvHukIohZwulCdZ3aBvJ(864270449 << 6 ^ -521233122), DbType.Int64);
            DbMetadata.C5wMxqohIDbGjyAgRXnr((object) column, ColumnProperty.PrimaryKey);
            columnList.Add(column);
            columnList.Add(new Column((string) DbMetadata.PvHukIohZwulCdZ3aBvJ(1597012150 ^ 1597098214), DbType.String, (int) byte.MaxValue));
            columnList.Add(new Column((string) DbMetadata.PvHukIohZwulCdZ3aBvJ(323422137 << 2 ^ 1293721442), DbType.Int32));
            columnList.Add(new Column((string) DbMetadata.PvHukIohZwulCdZ3aBvJ(-398663332 ^ -398698594), DbType.Binary));
            columnList.Add(new Column((string) DbMetadata.PvHukIohZwulCdZ3aBvJ(1574260816 ^ 1574232400), DbType.Binary));
            columnList.Add(new Column((string) DbMetadata.PvHukIohZwulCdZ3aBvJ(-680446928 - -370807692 ^ -309659994), DbType.Binary));
            columnList.Add(new Column(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867153733), DbType.Binary));
            table2.Columns = columnList;
            table1 = table2;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 4 : 1;
            continue;
          default:
            goto label_11;
        }
      }
label_5:
      return;
label_10:
      return;
label_11:
      return;
label_2:;
    }

    internal static object PvHukIohZwulCdZ3aBvJ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool RPJkaCohuqqNIv52cCpD([In] object obj0, [In] object obj1) => ((ITransformationProvider) obj0).TableExists((string) obj1);

    internal static void C5wMxqohIDbGjyAgRXnr([In] object obj0, ColumnProperty value) => ((Column) obj0).ColumnProperty = value;

    internal static void z8H4m3ohVk4D6qxiaQ0N([In] object obj0, [In] object obj1) => ((ITransformationProvider) obj0).AddTable((Table) obj1);

    internal static bool xaraB3ohvvW8xxbFw2OV() => DbMetadata.zkFyf7ohCgPtvk9oEeXX == null;

    internal static DbMetadata aPGrksoh8Hf7deG2w39G() => DbMetadata.zkFyf7ohCgPtvk9oEeXX;

    /// <summary>Таблицы БД</summary>
    public static class Tables
    {
      /// <summary>Таблица хранения модели</summary>
      public static class Model
      {
        /// <summary>Имя таблицы</summary>
        public const string TableName = "MD_MODEL";

        /// <summary>Поля</summary>
        public static class Fields
        {
          /// <summary>Идентификатор</summary>
          public const string Id = "Id";
          /// <summary>Номер версии</summary>
          public const string Version = "VERSION";
          /// <summary>Дата обновления на данную модель</summary>
          public const string UpdateDate = "UpdateDate";
        }
      }

      /// <summary>Таблица хранения модели</summary>
      public static class AssemblyModel
      {
        /// <summary>Имя таблицы</summary>
        public const string TableName = "MD_ASSEMBLY_MODEL";

        /// <summary>Поля</summary>
        public static class Fields
        {
          /// <summary>Идентификатор</summary>
          public const string Id = "Id";
          /// <summary>Имя сборки</summary>
          public const string Name = "AssemblyName";
          /// <summary>Статус</summary>
          public const string Status = "Status";
          /// <summary>Метаданные модели в заархивированном виде</summary>
          public const string Metadata = "Metadata";
          /// <summary>Бинарный код сборки</summary>
          public const string AssemblyRaw = "AssemblyRaw";
          /// <summary>Бинарный код сборки для отладки</summary>
          public const string DebugRaw = "DebugRaw";
          /// <summary>Содержимое файла документации (XML)</summary>
          public const string DocumentationRaw = "DocumentationRaw";
        }
      }
    }
  }
}
