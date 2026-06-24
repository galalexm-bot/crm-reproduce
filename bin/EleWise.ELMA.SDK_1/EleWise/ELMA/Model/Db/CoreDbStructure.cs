// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Db.CoreDbStructure
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Db
{
  /// <summary>Структура БД для SDK</summary>
  public class CoreDbStructure : DbStructureExtension
  {
    private static readonly ILogger DbUpdateLog;
    internal static CoreDbStructure sWlNbSoW5Ys2mQKZw99Z;

    /// <summary>Все провайдеры</summary>
    public override Guid ProviderUid => Guid.Empty;

    /// <summary>
    /// Создать таблицу для <see cref="T:EleWise.ELMA.Model.Scripts.ModuleReference" />
    /// </summary>
    public void CreateModuleReferenceMetadataTable()
    {
      int num = 1;
      ITransformationProvider serviceNotNull;
      while (true)
      {
        switch (num)
        {
          case 1:
            serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            goto label_6;
          default:
            if (CoreDbStructure.QXhLWYoWU3mVZKDq0iKd((object) serviceNotNull, CoreDbStructure.FOteEaoWLQ1PYIw5Jowo(-1638402543 ^ -1638551045)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 2;
              continue;
            }
            ITransformationProvider transformationProvider = serviceNotNull;
            EleWise.ELMA.Runtime.Db.Migrator.Framework.Table table = new EleWise.ELMA.Runtime.Db.Migrator.Framework.Table();
            CoreDbStructure.YwxxD7oWscxM0P7q9yow((object) table, CoreDbStructure.FOteEaoWLQ1PYIw5Jowo(813604817 ^ 813488187));
            table.Columns = new List<Column>()
            {
              new Column((string) CoreDbStructure.FOteEaoWLQ1PYIw5Jowo(-1852837372 ^ -1852982776), DbType.Guid, ColumnProperty.PrimaryKey),
              new Column((string) CoreDbStructure.FOteEaoWLQ1PYIw5Jowo(864270449 << 6 ^ -521233076), DbType.Guid)
            };
            CoreDbStructure.i5jt1OoWce42sL56AZeD((object) transformationProvider, (object) table);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 3;
            continue;
        }
      }
label_2:
      return;
label_6:;
    }

    /// <summary>
    /// Создать таблицу для <see cref="T:EleWise.ELMA.Model.Scripts.DataClassTypeReference" />
    /// </summary>
    public void CreateDataClassTypeReferenceTable()
    {
      int num = 2;
      ITransformationProvider serviceNotNull;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_4;
          case 1:
            if (!CoreDbStructure.QXhLWYoWU3mVZKDq0iKd((object) serviceNotNull, CoreDbStructure.FOteEaoWLQ1PYIw5Jowo(-542721635 ^ -542838341)))
            {
              ITransformationProvider transformationProvider = serviceNotNull;
              EleWise.ELMA.Runtime.Db.Migrator.Framework.Table table = new EleWise.ELMA.Runtime.Db.Migrator.Framework.Table();
              CoreDbStructure.YwxxD7oWscxM0P7q9yow((object) table, CoreDbStructure.FOteEaoWLQ1PYIw5Jowo(1242972401 >> 4 ^ 77802537));
              table.Columns = new List<Column>()
              {
                new Column((string) CoreDbStructure.FOteEaoWLQ1PYIw5Jowo(1925118608 << 2 ^ -889492706), DbType.Int64, ColumnProperty.PrimaryKey),
                new Column((string) CoreDbStructure.FOteEaoWLQ1PYIw5Jowo(979449278 ^ 979598770), DbType.Guid),
                new Column((string) CoreDbStructure.FOteEaoWLQ1PYIw5Jowo(-35995181 ^ -36140667), DbType.Guid)
              };
              CoreDbStructure.i5jt1OoWce42sL56AZeD((object) transformationProvider, (object) table);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 3 : 3;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
            continue;
          case 2:
            serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 1 : 1;
            continue;
          case 3:
            goto label_2;
          default:
            goto label_8;
        }
      }
label_4:
      return;
label_2:
      return;
label_8:;
    }

    /// <summary>Создать таблицу для хранения файлов</summary>
    public void CreateSystemFileTable4()
    {
      int num = 2;
      ITransformationProvider serviceNotNull;
      EleWise.ELMA.Runtime.Db.Migrator.Framework.Table table1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            if (!serviceNotNull.TableExists((string) CoreDbStructure.FOteEaoWLQ1PYIw5Jowo(1051276242 - 990076387 ^ 61316487)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 1 : 3;
              continue;
            }
            goto label_8;
          case 2:
            serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 1 : 1;
            continue;
          case 3:
            EleWise.ELMA.Runtime.Db.Migrator.Framework.Table table2 = new EleWise.ELMA.Runtime.Db.Migrator.Framework.Table();
            CoreDbStructure.YwxxD7oWscxM0P7q9yow((object) table2, CoreDbStructure.FOteEaoWLQ1PYIw5Jowo(1461625753 ^ 1461513201));
            table2.Columns = new List<Column>()
            {
              new Column((string) CoreDbStructure.FOteEaoWLQ1PYIw5Jowo(1917998801 >> 2 ^ 479466730), DbType.Int32, ColumnProperty.PrimaryKey),
              new Column((string) CoreDbStructure.FOteEaoWLQ1PYIw5Jowo(-244066886 - -48452443 ^ -195606905), DbType.Guid),
              new Column((string) CoreDbStructure.FOteEaoWLQ1PYIw5Jowo(993438473 ^ 993450185), DbType.String),
              new Column((string) CoreDbStructure.FOteEaoWLQ1PYIw5Jowo(1033719030 - 2012070891 ^ -978468489), DbType.String),
              new Column((string) CoreDbStructure.FOteEaoWLQ1PYIw5Jowo(825385222 ^ 825239952), DbType.DateTime),
              new Column((string) CoreDbStructure.FOteEaoWLQ1PYIw5Jowo(-1445902765 ^ -1980277732 ^ 539251425), DbType.String),
              new Column((string) CoreDbStructure.FOteEaoWLQ1PYIw5Jowo(-105199646 ^ -105345190), DbType.Int64),
              new Column((string) CoreDbStructure.FOteEaoWLQ1PYIw5Jowo(~-397266137 ^ 397378580), DbType.Int32),
              new Column((string) CoreDbStructure.FOteEaoWLQ1PYIw5Jowo(1461625753 ^ 1461513031), DbType.String),
              new Column(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917256330 ^ 1917143648), DbType.Boolean)
            };
            table1 = table2;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 4 : 3;
            continue;
          case 4:
            CoreDbStructure.i5jt1OoWce42sL56AZeD((object) serviceNotNull, (object) table1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
            continue;
          default:
            goto label_9;
        }
      }
label_2:
      return;
label_9:
      return;
label_8:;
    }

    /// <summary>Создать таблицу с информацией о конфигурации ELMA</summary>
    public void CreateConfigurationTypeInfoTable()
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        ITransformationProvider serviceNotNull;
        EleWise.ELMA.Runtime.Db.Migrator.Framework.Table table1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_3;
            case 1:
              EleWise.ELMA.Runtime.Db.Migrator.Framework.Table table2 = new EleWise.ELMA.Runtime.Db.Migrator.Framework.Table();
              CoreDbStructure.YwxxD7oWscxM0P7q9yow((object) table2, CoreDbStructure.FOteEaoWLQ1PYIw5Jowo(-1872275253 >> 6 ^ -29109149));
              table2.Columns = new List<Column>()
              {
                new Column((string) CoreDbStructure.FOteEaoWLQ1PYIw5Jowo(1319452732 ^ 1319569690), DbType.Int32)
              };
              table1 = table2;
              num2 = 2;
              continue;
            case 2:
              CoreDbStructure.i5jt1OoWce42sL56AZeD((object) serviceNotNull, (object) table1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 0 : 0;
              continue;
            case 3:
              if (!serviceNotNull.TableExists((string) CoreDbStructure.FOteEaoWLQ1PYIw5Jowo(1178210108 ^ 1178093116)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 1;
                continue;
              }
              goto label_9;
            case 4:
              goto label_8;
            default:
              goto label_10;
          }
        }
label_8:
        serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
        num1 = 3;
      }
label_3:
      return;
label_10:
      return;
label_9:;
    }

    /// <summary>
    /// Замена дубликатов Uid'ов на новые Uid'ы и индексирование полей Uid таблиц базы данных
    /// </summary>
    public void SetUniqueUids()
    {
      int num1 = 5;
      IOrderedEnumerable<EntityMetadata> mdList;
      IEnumerable<IIgnoreUidUI> mdIgnoreList;
      ITransformationProvider transformationProvider;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_7;
          case 2:
            transformationProvider = Locator.GetServiceNotNull<ITransformationProvider>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
            continue;
          case 3:
            CoreDbStructure.WZf8jBooBLOxH5Dte3pl((object) transformationProvider, 0, (object) (System.Action) (() =>
            {
              int num2 = 2;
              IEnumerator<EntityMetadata> enumerator1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_115;
                  case 1:
                    goto label_2;
                  case 2:
                    enumerator1 = mdList.GetEnumerator();
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 1 : 0;
                    continue;
                  default:
                    goto label_112;
                }
              }
label_115:
              return;
label_112:
              return;
label_2:
              try
              {
label_56:
                if (enumerator1.MoveNext())
                  goto label_59;
                else
                  goto label_57;
label_3:
                List<KeyValuePair<Guid, long>> keyValuePairList;
                List<long> longList1;
                string sql1;
                List<KeyValuePair<Guid, long>>.Enumerator enumerator2;
                List<long> longList2;
                string sql2;
                IDataReader dataReader1;
                List<long>.Enumerator enumerator3;
                IDataReader dataReader2;
                int num3;
                EntityMetadata md;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      try
                      {
label_88:
                        if (enumerator3.MoveNext())
                          goto label_84;
                        else
                          goto label_89;
label_83:
                        long current;
                        string sql3;
                        int num4;
                        while (true)
                        {
                          switch (num4)
                          {
                            case 1:
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              sql3 = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1445902765 ^ -1980277732 ^ 539201475), (object) transformationProvider.Dialect.QuoteIfNeeded((string) CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.PlumPNCbQ1I2sTNOxhJs((object) md)), CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.IhBuEjCbCjKoN66jMCZi(CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.DwoPAWCbf3uAMEgZe5Js((object) transformationProvider), CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.aO20rdCbGb1AnxqsliIE(323422137 << 2 ^ 1293709686)), CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.IhBuEjCbCjKoN66jMCZi(CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.DwoPAWCbf3uAMEgZe5Js((object) transformationProvider), CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.aO20rdCbGb1AnxqsliIE(~1767720452 ^ -1767753563)), (object) transformationProvider.ParameterSeparator);
                              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
                              continue;
                            case 2:
                              goto label_94;
                            case 3:
                              goto label_84;
                            case 4:
                              goto label_88;
                            default:
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              transformationProvider.ExecuteNonQuery(sql3, new Dictionary<string, object>()
                              {
                                {
                                  (string) CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.aO20rdCbGb1AnxqsliIE(1178210108 ^ 1178115294),
                                  (object) CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.oDY2BLCbVmfF2O0Lrfic()
                                },
                                {
                                  (string) CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.aO20rdCbGb1AnxqsliIE(381945751 ^ 1158627804 ^ 1406063543),
                                  (object) current
                                }
                              });
                              num4 = 4;
                              continue;
                          }
                        }
label_84:
                        current = enumerator3.Current;
                        num4 = 1;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0)
                        {
                          num4 = 1;
                          goto label_83;
                        }
                        else
                          goto label_83;
label_89:
                        num4 = 2;
                        goto label_83;
                      }
                      finally
                      {
                        enumerator3.Dispose();
                        int num5 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
                          num5 = 0;
                        switch (num5)
                        {
                          default:
                        }
                      }
                    case 2:
                      goto label_38;
                    case 3:
                      try
                      {
label_15:
                        if (enumerator2.MoveNext())
                          goto label_13;
                        else
                          goto label_16;
label_10:
                        KeyValuePair<Guid, long> current;
                        IDataReader dataReader3;
                        int num6;
                        while (true)
                        {
                          switch (num6)
                          {
                            case 1:
                              // ISSUE: reference to a compiler-generated method
                              dataReader3 = transformationProvider.ExecuteQuery(sql1, new Dictionary<string, object>()
                              {
                                {
                                  (string) CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.aO20rdCbGb1AnxqsliIE(572119659 - -337058038 ^ 909470531),
                                  (object) current.Key
                                }
                              });
                              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 4 : 5;
                              continue;
                            case 2:
                              goto label_76;
                            case 3:
                              goto label_13;
                            case 4:
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              sql1 = (string) CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.JKpF0ECb8vBmjhQN9s5C((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1255365154 ^ 596875508 ^ -1766151510), (object) new object[6]
                              {
                                (object) transformationProvider.Dialect.QuoteIfNeeded((string) CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.PlumPNCbQ1I2sTNOxhJs((object) md)),
                                CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.IhBuEjCbCjKoN66jMCZi(CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.DwoPAWCbf3uAMEgZe5Js((object) transformationProvider), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1642859704 ^ 1642881834)),
                                CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.IhBuEjCbCjKoN66jMCZi(CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.DwoPAWCbf3uAMEgZe5Js((object) transformationProvider), CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.aO20rdCbGb1AnxqsliIE(516838154 ^ 516870740)),
                                (object) transformationProvider.ParameterSeparator,
                                (object) ((Dialect) CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.DwoPAWCbf3uAMEgZe5Js((object) transformationProvider)).QuoteIfNeeded((string) CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.aO20rdCbGb1AnxqsliIE(-1204263869 ^ -1341583247 ^ 137683290)),
                                (object) current.Value
                              });
                              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 1 : 1;
                              continue;
                            case 5:
                              goto label_17;
                            default:
                              goto label_15;
                          }
                        }
label_17:
                        try
                        {
label_19:
                          // ISSUE: reference to a compiler-generated method
                          if (CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.tprYOHCbX0OwyO1xFmph((object) dataReader3))
                            goto label_21;
                          else
                            goto label_20;
label_18:
                          int num7;
                          switch (num7)
                          {
                            case 1:
                              goto label_19;
                            case 2:
                              goto label_21;
                            default:
                              goto label_15;
                          }
label_20:
                          num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 0 : 0;
                          goto label_18;
label_21:
                          // ISSUE: reference to a compiler-generated method
                          // ISSUE: reference to a compiler-generated method
                          // ISSUE: reference to a compiler-generated method
                          longList2.Add(CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.ejUK19Cbui4W3YRxiSqM(CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.nBPksBCbZTD9LBp8kj8R((object) dataReader3, CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.aO20rdCbGb1AnxqsliIE(1113862659 ^ 1113696107))));
                          num7 = 0;
                          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
                          {
                            num7 = 1;
                            goto label_18;
                          }
                          else
                            goto label_18;
                        }
                        finally
                        {
                          int num8;
                          if (dataReader3 == null)
                            num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 1 : 1;
                          else
                            goto label_26;
label_25:
                          switch (num8)
                          {
                            case 1:
                            case 2:
                          }
label_26:
                          // ISSUE: reference to a compiler-generated method
                          CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.ojxQ63CbIIcSZ7UrHTBF((object) dataReader3);
                          num8 = 2;
                          goto label_25;
                        }
label_13:
                        current = enumerator2.Current;
                        num6 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
                        {
                          num6 = 4;
                          goto label_10;
                        }
                        else
                          goto label_10;
label_16:
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 2 : 2;
                        goto label_10;
                      }
                      finally
                      {
                        enumerator2.Dispose();
                        int num9 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
                          num9 = 0;
                        switch (num9)
                        {
                          default:
                        }
                      }
                    case 4:
label_35:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      ((ILogger) CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.OGf8xVCbSRSwdAhMfAge()).Debug(CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.UlcOU5CbRtAGTQBdLZh7(CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.aO20rdCbGb1AnxqsliIE(-70007027 ^ -69840611), (object) CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.Ld3XFGCbiYWFaPIxGTit((object) longList1)));
                      num3 = 16;
                      continue;
                    case 5:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      Logger.Log.Debug(CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.UlcOU5CbRtAGTQBdLZh7(CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.aO20rdCbGb1AnxqsliIE(1669212571 ^ 1669050729), (object) md.TableName));
                      num3 = 26;
                      continue;
                    case 6:
label_79:
                      enumerator3 = longList1.GetEnumerator();
                      num3 = 24;
                      continue;
                    case 7:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      sql1 = (string) CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.JKpF0ECb8vBmjhQN9s5C((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1120607109 - 305487170 ^ -1426451461), (object) new object[5]
                      {
                        (object) ((Dialect) CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.DwoPAWCbf3uAMEgZe5Js((object) transformationProvider)).QuoteIfNeeded((string) CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.PlumPNCbQ1I2sTNOxhJs((object) md)),
                        CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.IhBuEjCbCjKoN66jMCZi(CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.DwoPAWCbf3uAMEgZe5Js((object) transformationProvider), CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.aO20rdCbGb1AnxqsliIE(-281842504 ^ -281869526)),
                        CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.IhBuEjCbCjKoN66jMCZi((object) transformationProvider.Dialect, CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.aO20rdCbGb1AnxqsliIE(1051802738 - -1831968059 ^ -1411229453)),
                        CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.h4tYD8CbvSxpdlwvbJxd((object) transformationProvider),
                        CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.IhBuEjCbCjKoN66jMCZi(CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.DwoPAWCbf3uAMEgZe5Js((object) transformationProvider), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(874012245 ^ 874367805))
                      });
                      num3 = 21;
                      continue;
                    case 8:
                      if (!transformationProvider.TableExists(md.TableName))
                      {
                        num3 = 18;
                        continue;
                      }
                      goto case 20;
                    case 9:
label_76:
                      enumerator3 = longList2.GetEnumerator();
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 1;
                      continue;
                    case 10:
label_6:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.S3jdXXCbKkWCe2BxbYy7((object) Logger.Log, CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.UlcOU5CbRtAGTQBdLZh7((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-342626196 - 1290888215 ^ -1633215719), (object) keyValuePairList.Count));
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 2 : 27;
                      continue;
                    case 11:
                      // ISSUE: reference to a compiler-generated method
                      CoreDbStructure.DbUpdateLog.DebugFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1242972401 >> 4 ^ 77921393), CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.PlumPNCbQ1I2sTNOxhJs((object) md));
                      num3 = 23;
                      continue;
                    case 12:
                      goto label_108;
                    case 13:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      sql2 = string.Format((string) CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.aO20rdCbGb1AnxqsliIE(-1824388195 ^ -1824023103), CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.IhBuEjCbCjKoN66jMCZi(CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.DwoPAWCbf3uAMEgZe5Js((object) transformationProvider), CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.PlumPNCbQ1I2sTNOxhJs((object) md)), (object) ((Dialect) CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.DwoPAWCbf3uAMEgZe5Js((object) transformationProvider)).QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488887207)), CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.IhBuEjCbCjKoN66jMCZi(CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.DwoPAWCbf3uAMEgZe5Js((object) transformationProvider), CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.aO20rdCbGb1AnxqsliIE(1178210108 ^ 1178242658)), CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.IhBuEjCbCjKoN66jMCZi(CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.DwoPAWCbf3uAMEgZe5Js((object) transformationProvider), CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.aO20rdCbGb1AnxqsliIE(322893104 - -1992822529 ^ -1979542763)), CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.IhBuEjCbCjKoN66jMCZi(CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.DwoPAWCbf3uAMEgZe5Js((object) transformationProvider), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -69840837)));
                      num3 = 22;
                      continue;
                    case 14:
                      // ISSUE: reference to a compiler-generated method
                      if (!mdIgnoreList.Any<IIgnoreUidUI>((System.Func<IIgnoreUidUI, bool>) (m => CoreDbStructure.\u003C\u003Ec__DisplayClass7_1.cx7nQpCbNrsk5vZkyaP2((object) m, (object) md))))
                      {
                        num3 = 8;
                        continue;
                      }
                      goto label_56;
                    case 15:
                      md = enumerator1.Current;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 14 : 11;
                      continue;
                    case 16:
                      keyValuePairList = new List<KeyValuePair<Guid, long>>();
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 13 : 7;
                      continue;
                    case 17:
                      enumerator2 = keyValuePairList.GetEnumerator();
                      num3 = 3;
                      continue;
                    case 19:
                      goto label_59;
                    case 20:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      if (!CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.s7XQP0CbEN5Ow0JoHCaW((object) transformationProvider, (object) md.TableName, CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.aO20rdCbGb1AnxqsliIE(333888594 ^ 1075625116 ^ 1408921436)))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
                        continue;
                      }
                      goto case 31;
                    case 21:
                      // ISSUE: reference to a compiler-generated method
                      dataReader2 = transformationProvider.ExecuteQuery(sql1, new Dictionary<string, object>()
                      {
                        {
                          (string) CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.aO20rdCbGb1AnxqsliIE(-218496594 ^ -218131242),
                          (object) Guid.Empty
                        }
                      });
                      num3 = 28;
                      continue;
                    case 22:
                      dataReader1 = transformationProvider.ExecuteQuery(sql2, (Dictionary<string, object>) null);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 6 : 30;
                      continue;
                    case 23:
                      ITransformationProvider transformationProvider1 = transformationProvider;
                      EleWise.ELMA.Runtime.Db.Migrator.Framework.Index index = new EleWise.ELMA.Runtime.Db.Migrator.Framework.Index();
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      index.Name = string.Format((string) CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.aO20rdCbGb1AnxqsliIE(1505778440 - 1981636111 ^ -476009193), CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.PlumPNCbQ1I2sTNOxhJs((object) md));
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.AMfdQJCbTPP87xtdyhC9((object) index, CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.PlumPNCbQ1I2sTNOxhJs((object) md));
                      // ISSUE: reference to a compiler-generated method
                      index.Columns = new List<string>()
                      {
                        (string) CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.aO20rdCbGb1AnxqsliIE(-281842504 ^ -281869526)
                      };
                      transformationProvider1.AddUniqueIndex(index);
                      num3 = 5;
                      continue;
                    case 24:
                      try
                      {
label_67:
                        if (enumerator3.MoveNext())
                          goto label_64;
                        else
                          goto label_68;
label_62:
                        string sql4;
                        long current;
                        int num10;
                        while (true)
                        {
                          switch (num10)
                          {
                            case 1:
                              goto label_67;
                            case 2:
                              goto label_64;
                            case 3:
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              transformationProvider.ExecuteNonQuery(sql4, new Dictionary<string, object>()
                              {
                                {
                                  z2jc63fLkugS1X8Q9N.tE1kD1vbB(322893104 - -1992822529 ^ -1979344941),
                                  (object) CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.oDY2BLCbVmfF2O0Lrfic()
                                },
                                {
                                  (string) CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.aO20rdCbGb1AnxqsliIE(1218962250 ^ 1218606774),
                                  (object) current
                                }
                              });
                              num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 1 : 1;
                              continue;
                            case 4:
                              goto label_35;
                            default:
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              sql4 = string.Format((string) CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.aO20rdCbGb1AnxqsliIE(-1939377524 ^ -1939675392), CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.IhBuEjCbCjKoN66jMCZi(CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.DwoPAWCbf3uAMEgZe5Js((object) transformationProvider), CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.PlumPNCbQ1I2sTNOxhJs((object) md)), CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.IhBuEjCbCjKoN66jMCZi(CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.DwoPAWCbf3uAMEgZe5Js((object) transformationProvider), CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.aO20rdCbGb1AnxqsliIE(979449278 ^ 979458604)), CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.IhBuEjCbCjKoN66jMCZi(CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.DwoPAWCbf3uAMEgZe5Js((object) transformationProvider), CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.aO20rdCbGb1AnxqsliIE(1505778440 - 1981636111 ^ -475890265)), CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.h4tYD8CbvSxpdlwvbJxd((object) transformationProvider));
                              num10 = 3;
                              continue;
                          }
                        }
label_64:
                        current = enumerator3.Current;
                        num10 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0)
                        {
                          num10 = 0;
                          goto label_62;
                        }
                        else
                          goto label_62;
label_68:
                        num10 = 4;
                        goto label_62;
                      }
                      finally
                      {
                        enumerator3.Dispose();
                        int num11 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
                          num11 = 0;
                        switch (num11)
                        {
                          default:
                        }
                      }
                    case 26:
                    case 29:
                      goto label_56;
                    case 27:
                      longList2 = new List<long>();
                      num3 = 17;
                      continue;
                    case 28:
                      try
                      {
label_99:
                        if (dataReader2.Read())
                          goto label_97;
                        else
                          goto label_100;
label_96:
                        int num12;
                        switch (num12)
                        {
                          case 1:
                            goto label_79;
                          case 2:
                            break;
                          default:
                            goto label_99;
                        }
label_97:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        longList1.Add(CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.ejUK19Cbui4W3YRxiSqM(CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.nBPksBCbZTD9LBp8kj8R((object) dataReader2, CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.aO20rdCbGb1AnxqsliIE(~-306453669 ^ 306285004))));
                        num12 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
                        {
                          num12 = 0;
                          goto label_96;
                        }
                        else
                          goto label_96;
label_100:
                        num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 1 : 0;
                        goto label_96;
                      }
                      finally
                      {
                        int num13;
                        if (dataReader2 == null)
                          num13 = 2;
                        else
                          goto label_104;
label_103:
                        switch (num13)
                        {
                          case 1:
                          case 2:
                        }
label_104:
                        // ISSUE: reference to a compiler-generated method
                        CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.ojxQ63CbIIcSZ7UrHTBF((object) dataReader2);
                        num13 = 1;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
                        {
                          num13 = 1;
                          goto label_103;
                        }
                        else
                          goto label_103;
                      }
                    case 30:
                      try
                      {
label_46:
                        if (dataReader1.Read())
                          goto label_48;
                        else
                          goto label_47;
label_45:
                        int num14;
                        switch (num14)
                        {
                          case 1:
                            goto label_46;
                          case 2:
                            goto label_48;
                          default:
                            goto label_6;
                        }
label_47:
                        num14 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 0 : 0;
                        goto label_45;
label_48:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        keyValuePairList.Add(new KeyValuePair<Guid, long>(CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.O2orvWCbqKHypH7GhUiD(CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.DwoPAWCbf3uAMEgZe5Js((object) transformationProvider), CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.nBPksBCbZTD9LBp8kj8R((object) dataReader1, CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.aO20rdCbGb1AnxqsliIE(-97972138 ^ -97745038))), CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.ejUK19Cbui4W3YRxiSqM(CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.nBPksBCbZTD9LBp8kj8R((object) dataReader1, CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.aO20rdCbGb1AnxqsliIE(-542721635 ^ -542953813)))));
                        num14 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
                        {
                          num14 = 1;
                          goto label_45;
                        }
                        else
                          goto label_45;
                      }
                      finally
                      {
                        if (dataReader1 != null)
                        {
                          int num15 = 0;
                          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0)
                            num15 = 1;
                          while (true)
                          {
                            switch (num15)
                            {
                              case 1:
                                // ISSUE: reference to a compiler-generated method
                                CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.ojxQ63CbIIcSZ7UrHTBF((object) dataReader1);
                                num15 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 0 : 0;
                                continue;
                              default:
                                goto label_55;
                            }
                          }
                        }
label_55:;
                      }
                    case 31:
                      longList1 = new List<long>();
                      num3 = 7;
                      continue;
                    case 32:
label_94:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      Logger.Log.Debug((object) string.Format((string) CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.aO20rdCbGb1AnxqsliIE(-630932142 - 1120244082 ^ -1751469102), (object) CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.Ld3XFGCbiYWFaPIxGTit((object) longList2)));
                      num3 = 11;
                      continue;
                    default:
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 2 : 1;
                      continue;
                  }
                }
label_108:
                return;
label_38:
                try
                {
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.WvDKqlCbOWVGu3gBU6jT((object) Logger.Log, CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.aMfl2CCbnFx9ikUnH4NZ((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(2008901894 << 3 ^ -1108422284), CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.UOuScQCbkQesdRM3K7x7((object) md), CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.PlumPNCbQ1I2sTNOxhJs((object) md)));
                  int num16 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
                    num16 = 0;
                  switch (num16)
                  {
                    default:
                      goto label_56;
                  }
                }
                catch
                {
                  int num17 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
                    num17 = 0;
                  switch (num17)
                  {
                    default:
                      goto label_56;
                  }
                }
label_57:
                num3 = 12;
                goto label_3;
label_59:
                num3 = 15;
                goto label_3;
              }
              finally
              {
                int num18;
                if (enumerator1 == null)
                  num18 = 2;
                else
                  goto label_113;
label_111:
                switch (num18)
                {
                  case 1:
                  case 2:
                }
label_113:
                // ISSUE: reference to a compiler-generated method
                CoreDbStructure.\u003C\u003Ec__DisplayClass7_0.ojxQ63CbIIcSZ7UrHTBF((object) enumerator1);
                num18 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
                {
                  num18 = 1;
                  goto label_111;
                }
                else
                  goto label_111;
              }
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 1;
            continue;
          case 4:
            IEnumerable<EntityMetadata> source = ((IMetadataService) CoreDbStructure.iInrZwoWzq2dTFYVYRhY()).GetMetadataList().OfType<EntityMetadata>().Where<EntityMetadata>((System.Func<EntityMetadata, bool>) (md =>
            {
              int num19 = 4;
              while (true)
              {
                switch (num19)
                {
                  case 1:
                    if (md.Type != EntityMetadataType.Entity)
                    {
                      num19 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
                      continue;
                    }
                    goto label_5;
                  case 2:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    if (CoreDbStructure.\u003C\u003Ec.tsoDrACbwaYAALkupkV7(CoreDbStructure.\u003C\u003Ec.glKdCoCbtkgOhy7xGCUp((object) md), Guid.Empty))
                    {
                      num19 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 1 : 1;
                      continue;
                    }
                    goto label_6;
                  case 3:
                    goto label_6;
                  case 4:
                    if (!md.IsUnique)
                    {
                      num19 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 3 : 2;
                      continue;
                    }
                    goto case 2;
                  default:
                    goto label_4;
                }
              }
label_4:
              // ISSUE: reference to a compiler-generated method
              return CoreDbStructure.\u003C\u003Ec.qJkvCuCb4vmSUFeo1MLw((object) md) == EntityMetadataType.InterfaceImplementation;
label_5:
              return true;
label_6:
              return false;
            }));
            // ISSUE: reference to a compiler-generated field
            System.Func<EntityMetadata, string> func = CoreDbStructure.\u003C\u003Ec.\u003C\u003E9__7_1;
            System.Func<EntityMetadata, string> keySelector;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              CoreDbStructure.\u003C\u003Ec.\u003C\u003E9__7_1 = keySelector = (System.Func<EntityMetadata, string>) (md => md.TableName);
            }
            else
              goto label_10;
label_9:
            mdList = source.OrderBy<EntityMetadata, string>(keySelector);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 2 : 1;
            continue;
label_10:
            keySelector = func;
            goto label_9;
          case 5:
            num1 = 4;
            continue;
          default:
            mdIgnoreList = ((ComponentManager) CoreDbStructure.xRTBITooFP6e1PCopJFs()).GetExtensionPoints<IIgnoreUidUI>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 3 : 3;
            continue;
        }
      }
label_7:;
    }

    /// <summary>Навешиваем на такие поля индексы</summary>
    public void CreateIndexesForReferenceObject()
    {
      int num1 = 3;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_5;
          case 2:
            ITransformationProvider transform = Locator.GetServiceNotNull<ITransformationProvider>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
            continue;
          case 3:
            num1 = 2;
            continue;
          default:
            IEnumerable<EntityMetadata> source1 = ((IMetadataService) CoreDbStructure.iInrZwoWzq2dTFYVYRhY()).GetMetadataList().OfType<EntityMetadata>().Where<EntityMetadata>((System.Func<EntityMetadata, bool>) (m =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    if (CoreDbStructure.\u003C\u003Ec.qJkvCuCb4vmSUFeo1MLw((object) m) != EntityMetadataType.InterfaceImplementation)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 0 : 0;
                      continue;
                    }
                    goto label_5;
                  default:
                    goto label_4;
                }
              }
label_4:
              // ISSUE: reference to a compiler-generated method
              return CoreDbStructure.\u003C\u003Ec.qJkvCuCb4vmSUFeo1MLw((object) m) == EntityMetadataType.Entity;
label_5:
              return true;
            }));
            // ISSUE: reference to a compiler-generated field
            System.Func<EntityMetadata, bool> func1 = CoreDbStructure.\u003C\u003Ec.\u003C\u003E9__8_1;
            System.Func<EntityMetadata, bool> predicate1;
            if (func1 == null)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              CoreDbStructure.\u003C\u003Ec.\u003C\u003E9__8_1 = predicate1 = (System.Func<EntityMetadata, bool>) (m => m.Properties.Any<PropertyMetadata>((System.Func<PropertyMetadata, bool>) (p => CoreDbStructure.\u003C\u003Ec.tsoDrACbwaYAALkupkV7(CoreDbStructure.\u003C\u003Ec.fWv57ECb6iDf3Mu1o2ZH((object) p), ReferenceOnEntityDecription.UID))));
            }
            else
              goto label_8;
label_7:
            source1.Where<EntityMetadata>(predicate1).ToList<EntityMetadata>().ForEach((Action<EntityMetadata>) (m =>
            {
              int num5 = 1;
              while (true)
              {
                int num6 = num5;
                EntityMetadata m1;
                // ISSUE: variable of a compiler-generated type
                CoreDbStructure.\u003C\u003Ec__DisplayClass8_0 cDisplayClass80;
                while (true)
                {
                  switch (num6)
                  {
                    case 1:
                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
                      continue;
                    case 2:
                      goto label_7;
                    case 3:
                      IEnumerable<EntityPropertyMetadata> source2 = m1.Properties.OfType<EntityPropertyMetadata>();
                      // ISSUE: reference to a compiler-generated field
                      System.Func<EntityPropertyMetadata, bool> func2 = CoreDbStructure.\u003C\u003Ec.\u003C\u003E9__8_4;
                      System.Func<EntityPropertyMetadata, bool> predicate2;
                      if (func2 == null)
                      {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated method
                        CoreDbStructure.\u003C\u003Ec.\u003C\u003E9__8_4 = predicate2 = (System.Func<EntityPropertyMetadata, bool>) (p => CoreDbStructure.\u003C\u003Ec.fWv57ECb6iDf3Mu1o2ZH((object) p) == ReferenceOnEntityDecription.UID);
                      }
                      else
                        goto label_10;
label_9:
                      source2.Where<EntityPropertyMetadata>(predicate2).ToList<EntityPropertyMetadata>().ForEach((Action<EntityPropertyMetadata>) (p =>
                      {
                        int num7 = 5;
                        while (true)
                        {
                          int num8 = num7;
                          string str3;
                          string objectIdName;
                          string str4;
                          string tableName;
                          ReferenceOnEntitySettings settings;
                          while (true)
                          {
                            switch (num8)
                            {
                              case 1:
                                // ISSUE: reference to a compiler-generated method
                                // ISSUE: reference to a compiler-generated method
                                str4 = (string) CoreDbStructure.\u003C\u003Ec__DisplayClass8_1.mVA55jCb5LMOjZSgNcx7(CoreDbStructure.\u003C\u003Ec__DisplayClass8_1.sfMNCfCbglgAnYeFSHeK((object) settings));
                                num8 = 8;
                                continue;
                              case 2:
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated method
                                if (CoreDbStructure.\u003C\u003Ec__DisplayClass8_1.BKTVOyCbsybprr3xZlGQ((object) cDisplayClass80.transform, (object) tableName, (object) objectIdName))
                                {
                                  num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 6 : 6;
                                  continue;
                                }
                                goto label_5;
                              case 3:
                                // ISSUE: reference to a compiler-generated field
                                ITransformationProvider transform2 = cDisplayClass80.transform;
                                EleWise.ELMA.Runtime.Db.Migrator.Framework.Index index = new EleWise.ELMA.Runtime.Db.Migrator.Framework.Index();
                                // ISSUE: reference to a compiler-generated method
                                CoreDbStructure.\u003C\u003Ec__DisplayClass8_1.d98NCGCbzf1NIBmph1eb((object) index, (object) tableName);
                                // ISSUE: reference to a compiler-generated method
                                CoreDbStructure.\u003C\u003Ec__DisplayClass8_1.VbIvhuChFJgtJh7dq3Zg((object) index, (object) str3);
                                index.Columns = new List<string>()
                                {
                                  objectIdName,
                                  str4
                                };
                                // ISSUE: reference to a compiler-generated method
                                CoreDbStructure.\u003C\u003Ec__DisplayClass8_1.zOZWgrChBtILfxWpUxjq((object) transform2, (object) index);
                                num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 6 : 7;
                                continue;
                              case 4:
                                goto label_13;
                              case 5:
                                settings = (ReferenceOnEntitySettings) p.Settings;
                                num8 = 4;
                                continue;
                              case 6:
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated method
                                if (!CoreDbStructure.\u003C\u003Ec__DisplayClass8_1.BKTVOyCbsybprr3xZlGQ((object) cDisplayClass80.transform, (object) tableName, (object) str4))
                                {
                                  num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 5 : 11;
                                  continue;
                                }
                                goto case 9;
                              case 7:
                                goto label_15;
                              case 8:
                                // ISSUE: reference to a compiler-generated method
                                // ISSUE: reference to a compiler-generated method
                                // ISSUE: reference to a compiler-generated method
                                // ISSUE: reference to a compiler-generated method
                                str3 = (string) CoreDbStructure.\u003C\u003Ec__DisplayClass8_1.tVuDnrCbUJsBp1y3E2rh(CoreDbStructure.\u003C\u003Ec__DisplayClass8_1.FgqDe1CbLabpPtp97hfU((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470440286 ^ 1470151360), (object) CoreDbStructure.\u003C\u003Ec__DisplayClass8_1.rf6sVhCbYNtthQaDty4v(CoreDbStructure.\u003C\u003Ec__DisplayClass8_1.F8m0lKCbjDLxy5XtPe1d((object) tableName, (object) objectIdName, (object) str4))), 0, 25);
                                num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 1 : 2;
                                continue;
                              case 9:
                                // ISSUE: reference to a compiler-generated method
                                CoreDbStructure.DbUpdateLog.DebugFormat((string) CoreDbStructure.\u003C\u003Ec__DisplayClass8_1.j1IVUtCbcXTN0TLw3IVq(322893104 - -1992822529 ^ -1979540065), (object) str3, (object) objectIdName, (object) str4, (object) tableName);
                                num8 = 3;
                                continue;
                              case 10:
                                goto label_3;
                              case 11:
                                goto label_19;
                              case 12:
                                // ISSUE: reference to a compiler-generated method
                                objectIdName = ReferenceOnEntityNHType.GenerateObjectIdName((string) CoreDbStructure.\u003C\u003Ec__DisplayClass8_1.sfMNCfCbglgAnYeFSHeK((object) settings));
                                num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 1;
                                continue;
                              default:
                                goto label_11;
                            }
                          }
label_11:
                          // ISSUE: reference to a compiler-generated method
                          tableName = EntityPropertyMetadata.GetTableName((string) CoreDbStructure.\u003C\u003Ec__DisplayClass8_1.WrQBSGCbr6bnBXyvvD6w((object) m1), p.TableNumber);
                          num7 = 12;
                          continue;
label_13:
                          if (settings == null)
                            num7 = 10;
                          else
                            goto label_11;
                        }
label_15:
                        return;
label_3:
                        return;
label_19:
                        return;
label_5:;
                      }));
                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 1 : 2;
                      continue;
label_10:
                      predicate2 = func2;
                      goto label_9;
                    case 4:
                      goto label_5;
                    default:
                      cDisplayClass80 = this;
                      num6 = 4;
                      continue;
                  }
                }
label_5:
                m1 = m;
                num5 = 3;
              }
label_7:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 1 : 1;
            continue;
label_8:
            predicate1 = func1;
            goto label_7;
        }
      }
label_5:;
    }

    /// <summary>Создаем индексы для мягкого удаления</summary>
    public void CreateIndexesForAllSoftDeletable()
    {
      int num1 = 2;
      IMetadataRuntimeService service;
      ITransformationProvider transform;
      while (true)
      {
        switch (num1)
        {
          case 1:
            transform = Locator.GetServiceNotNull<ITransformationProvider>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 0;
            continue;
          case 2:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 1 : 1;
            continue;
          case 3:
            service.GetMetadataList().OfType<EntityMetadata>().Where<EntityMetadata>((System.Func<EntityMetadata, bool>) (m =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    if (CoreDbStructure.\u003C\u003Ec.qJkvCuCb4vmSUFeo1MLw((object) m) != EntityMetadataType.InterfaceImplementation)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 0;
                      continue;
                    }
                    goto label_5;
                  default:
                    goto label_4;
                }
              }
label_4:
              // ISSUE: reference to a compiler-generated method
              return CoreDbStructure.\u003C\u003Ec.qJkvCuCb4vmSUFeo1MLw((object) m) == EntityMetadataType.Entity;
label_5:
              return true;
            })).Where<EntityMetadata>((System.Func<EntityMetadata, bool>) (m =>
            {
              int num3 = 1;
              Type typeByUid;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    typeByUid = service.GetTypeByUid(CoreDbStructure.\u003C\u003Ec__DisplayClass9_0.JtW8X2ChGFUrgiLKWeQY((object) m));
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_2;
                }
              }
label_2:
              return typeof (ISoftDeletable).IsAssignableFrom(typeByUid);
            })).ToList<EntityMetadata>().ForEach((Action<EntityMetadata>) (m =>
            {
              int num4 = 3;
              EntityPropertyMetadata propertyMetadata;
              EntityMetadata entityMetadata;
              string tableName;
              SimpleTypeSettings simpleTypeSettings;
              string indexName;
              while (true)
              {
                switch (num4)
                {
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    if (CoreDbStructure.\u003C\u003Ec__DisplayClass9_0.bVyd1OChZTYPxqjcqksk((object) transform, (object) tableName, CoreDbStructure.\u003C\u003Ec__DisplayClass9_0.COnaOiChCDDkoCHSWuD8((object) simpleTypeSettings)))
                    {
                      num4 = 7;
                      continue;
                    }
                    goto label_17;
                  case 2:
                    IEnumerable<EntityPropertyMetadata> source = entityMetadata.Properties.OfType<EntityPropertyMetadata>();
                    // ISSUE: reference to a compiler-generated field
                    System.Func<EntityPropertyMetadata, bool> func = CoreDbStructure.\u003C\u003Ec.\u003C\u003E9__9_3;
                    System.Func<EntityPropertyMetadata, bool> predicate;
                    if (func == null)
                    {
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      CoreDbStructure.\u003C\u003Ec.\u003C\u003E9__9_3 = predicate = (System.Func<EntityPropertyMetadata, bool>) (p => CoreDbStructure.\u003C\u003Ec.s7eUi6Cb7FK8sLJ0V0Md(CoreDbStructure.\u003C\u003Ec.lUcliICbHvJQpoD9xrgU((object) p), CoreDbStructure.\u003C\u003Ec.Iwxm8MCbAgR5r7xBomS4(1232639661 >> 3 ^ 153967167)));
                    }
                    else
                      goto label_30;
label_28:
                    propertyMetadata = source.FirstOrDefault<EntityPropertyMetadata>(predicate);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
                    continue;
label_30:
                    predicate = func;
                    goto label_28;
                  case 3:
                    // ISSUE: reference to a compiler-generated method
                    entityMetadata = (EntityMetadata) MetadataLoader.LoadMetadata(CoreDbStructure.\u003C\u003Ec__DisplayClass9_0.JtW8X2ChGFUrgiLKWeQY((object) m), false);
                    num4 = 2;
                    continue;
                  case 4:
                    // ISSUE: reference to a compiler-generated method
                    tableName = EntityPropertyMetadata.GetTableName((string) CoreDbStructure.\u003C\u003Ec__DisplayClass9_0.CcFfXmChfpV3d45SQMB6((object) entityMetadata), propertyMetadata.TableNumber);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 5 : 6;
                    continue;
                  case 5:
                    goto label_8;
                  case 6:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    indexName = (string) CoreDbStructure.\u003C\u003Ec__DisplayClass9_0.wlHj1kCh8LwhtYBLhrXV(CoreDbStructure.\u003C\u003Ec__DisplayClass9_0.rnLIw0ChQ3bNnPvFT1Lm(1574260816 ^ 1574378070), CoreDbStructure.\u003C\u003Ec__DisplayClass9_0.V0Uyc5ChvFQwPWsRLMuS((object) (entityMetadata.TableName + (string) CoreDbStructure.\u003C\u003Ec__DisplayClass9_0.rnLIw0ChQ3bNnPvFT1Lm(236071375 ^ 236073739) + (string) CoreDbStructure.\u003C\u003Ec__DisplayClass9_0.COnaOiChCDDkoCHSWuD8((object) simpleTypeSettings)).GetDeterministicGuid().ToString((string) CoreDbStructure.\u003C\u003Ec__DisplayClass9_0.rnLIw0ChQ3bNnPvFT1Lm(1051802738 - -1831968059 ^ -1411243035)), 0, 20));
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 1;
                    continue;
                  case 7:
                    if (!transform.IndexExists(tableName, indexName))
                    {
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 5 : 2;
                      continue;
                    }
                    goto label_13;
                  case 8:
                    goto label_26;
                  case 9:
                    // ISSUE: reference to a compiler-generated method
                    simpleTypeSettings = (SimpleTypeSettings) CoreDbStructure.\u003C\u003Ec__DisplayClass9_0.ljeJNLChEClXgAQYT8ec((object) propertyMetadata);
                    num4 = 4;
                    continue;
                  default:
                    if (propertyMetadata != null)
                    {
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 9 : 2;
                      continue;
                    }
                    goto label_19;
                }
              }
label_26:
              return;
label_19:
              return;
label_17:
              return;
label_8:
              try
              {
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                CoreDbStructure.DbUpdateLog.DebugFormat((string) CoreDbStructure.\u003C\u003Ec__DisplayClass9_0.rnLIw0ChQ3bNnPvFT1Lm(-1088304168 ^ -1088138766), (object) indexName, (object) tableName, CoreDbStructure.\u003C\u003Ec__DisplayClass9_0.COnaOiChCDDkoCHSWuD8((object) simpleTypeSettings));
                int num5 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
                  num5 = 1;
                while (true)
                {
                  switch (num5)
                  {
                    case 0:
                      goto label_11;
                    case 1:
                      ITransformationProvider transformationProvider = transform;
                      EleWise.ELMA.Runtime.Db.Migrator.Framework.Index index = new EleWise.ELMA.Runtime.Db.Migrator.Framework.Index();
                      index.TableName = tableName;
                      // ISSUE: reference to a compiler-generated method
                      CoreDbStructure.\u003C\u003Ec__DisplayClass9_0.qcggMJChu1y7ntO2WfUb((object) index, (object) indexName);
                      // ISSUE: reference to a compiler-generated method
                      index.Columns = new List<string>()
                      {
                        (string) CoreDbStructure.\u003C\u003Ec__DisplayClass9_0.COnaOiChCDDkoCHSWuD8((object) simpleTypeSettings)
                      };
                      // ISSUE: reference to a compiler-generated method
                      CoreDbStructure.\u003C\u003Ec__DisplayClass9_0.a3jBZuChIBmxEkoXxCd8((object) transformationProvider, (object) index);
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_2;
                  }
                }
label_11:
                return;
label_2:
                return;
              }
              catch (Exception ex)
              {
                int num6 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
                  num6 = 0;
                while (true)
                {
                  switch (num6)
                  {
                    case 1:
                      goto label_29;
                    default:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      CoreDbStructure.\u003C\u003Ec__DisplayClass9_0.uBxY6BChSCZd3lWKQYtT(CoreDbStructure.\u003C\u003Ec__DisplayClass9_0.DFSJhqChVIDMLRoZkD1n(), (object) ex);
                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 1 : 0;
                      continue;
                  }
                }
label_29:
                return;
              }
label_13:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 4 : 2;
            continue;
          case 4:
            goto label_2;
          default:
            service = Locator.GetServiceNotNull<IMetadataRuntimeService>();
            num1 = 3;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Сгенерировать зависимости для форм</summary>
    /// <remarks>
    /// Генерация зависимостей установлена в строгом порядке.
    /// Одним списком сохранять нельзя, потому что расширения интерфейсов сохраняются по уиду базового интерфейса, и может произойти ситуация,
    /// когда зависимости из расширения перезапишутся зависимостями из базового интерфейса.
    /// </remarks>
    public void CreateFormViewItemDependencies()
    {
      int num1 = 3;
      Action<EntityMetadata> action;
      List<EntityMetadata> entityMetadataList;
      IEnumerator<EntityMetadata> enumerator1;
      List<IMetadataItem>.Enumerator enumerator2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_35;
          case 2:
            try
            {
label_8:
              if (CoreDbStructure.qIGrXsooW1QhykJ86KBT((object) enumerator1))
                goto label_10;
              else
                goto label_9;
label_3:
              EntityMetadata current;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                  case 6:
                    goto label_8;
                  case 3:
                    goto label_17;
                  case 4:
                    entityMetadataList.Add(current);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 1 : 1;
                    continue;
                  case 5:
                    goto label_10;
                  case 7:
                    if (!current.IsConfig())
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
                      continue;
                    }
                    goto case 4;
                  default:
                    action(current);
                    num2 = 6;
                    continue;
                }
              }
label_9:
              num2 = 3;
              goto label_3;
label_10:
              current = enumerator1.Current;
              num2 = 7;
              goto label_3;
            }
            finally
            {
              if (enumerator1 != null)
              {
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
                  num3 = 0;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_16;
                    default:
                      enumerator1.Dispose();
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 1;
                      continue;
                  }
                }
              }
label_16:;
            }
          case 3:
            IMetadataRuntimeService service = Locator.GetServiceNotNull<IMetadataRuntimeService>();
            action = (Action<EntityMetadata>) (metadata =>
            {
              int num4 = 15;
              // ISSUE: variable of a compiler-generated type
              CoreDbStructure.\u003C\u003Ec__DisplayClass10_1 cDisplayClass101;
              List<FormViewItemTransformation> list;
              EntityMetadata metadata1;
              List<FormViewItemTransformation>.Enumerator enumerator3;
              List<Guid> guidList1;
              while (true)
              {
                switch (num4)
                {
                  case 1:
                    goto label_34;
                  case 2:
                    enumerator3 = list.GetEnumerator();
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 7 : 2;
                    continue;
                  case 3:
                    try
                    {
label_42:
                      if (enumerator3.MoveNext())
                        goto label_44;
                      else
                        goto label_43;
label_37:
                      // ISSUE: variable of a compiler-generated type
                      CoreDbStructure.\u003C\u003Ec__DisplayClass10_2 cDisplayClass102;
                      int num5;
                      while (true)
                      {
                        switch (num5)
                        {
                          case 1:
                            goto label_3;
                          case 2:
                            // ISSUE: reference to a compiler-generated method
                            if (!list.Any<FormViewItemTransformation>(new System.Func<FormViewItemTransformation, bool>(cDisplayClass102.\u003CCreateFormViewItemDependencies\u003Eb__6)))
                            {
                              num5 = 5;
                              continue;
                            }
                            goto label_42;
                          case 3:
                            goto label_44;
                          case 4:
                            // ISSUE: reference to a compiler-generated field
                            cDisplayClass102.t = enumerator3.Current;
                            num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 2 : 2;
                            continue;
                          case 5:
                            // ISSUE: reference to a compiler-generated field
                            list.Add(cDisplayClass102.t);
                            num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
                            continue;
                          default:
                            goto label_42;
                        }
                      }
label_43:
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 1 : 0;
                      goto label_37;
label_44:
                      // ISSUE: object of a compiler-generated type is created
                      cDisplayClass102 = new CoreDbStructure.\u003C\u003Ec__DisplayClass10_2();
                      num5 = 2;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
                      {
                        num5 = 4;
                        goto label_37;
                      }
                      else
                        goto label_37;
                    }
                    finally
                    {
                      enumerator3.Dispose();
                      int num6 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0)
                        num6 = 0;
                      switch (num6)
                      {
                        default:
                      }
                    }
                  case 4:
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated method
                    cDisplayClass101.objectUid = CoreDbStructure.\u003C\u003Ec__DisplayClass10_0.oYnARpChXLr6GDBnge1c((object) metadata);
                    num4 = 16;
                    continue;
                  case 5:
                    goto label_11;
                  case 6:
label_3:
                    // ISSUE: reference to a compiler-generated field
                    cDisplayClass101.deps = new List<IFormDependencyData>();
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 2 : 1;
                    continue;
                  case 7:
                    try
                    {
label_18:
                      if (enumerator3.MoveNext())
                        goto label_24;
                      else
                        goto label_19;
label_14:
                      // ISSUE: variable of a compiler-generated type
                      CoreDbStructure.\u003C\u003Ec__DisplayClass10_4 cDisplayClass104;
                      // ISSUE: variable of a compiler-generated type
                      CoreDbStructure.\u003C\u003Ec__DisplayClass10_3 cDisplayClass103;
                      int num7;
                      while (true)
                      {
                        switch (num7)
                        {
                          case 1:
                            // ISSUE: object of a compiler-generated type is created
                            cDisplayClass104 = new CoreDbStructure.\u003C\u003Ec__DisplayClass10_4();
                            num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 8 : 8;
                            continue;
                          case 2:
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            cDisplayClass104.CS\u0024\u003C\u003E8__locals2.CS\u0024\u003C\u003E8__locals1.deps.Add((IFormDependencyData) new FormDependencyData(cDisplayClass104.CS\u0024\u003C\u003E8__locals2.CS\u0024\u003C\u003E8__locals1.objectUid, cDisplayClass104.dependFormUid, cDisplayClass104.CS\u0024\u003C\u003E8__locals2.CS\u0024\u003C\u003E8__locals1.objectUid, cDisplayClass104.CS\u0024\u003C\u003E8__locals2.t.Uid, cDisplayClass104.dependType));
                            num7 = 11;
                            continue;
                          case 3:
                          case 11:
                            // ISSUE: reference to a compiler-generated method
                            guidList1.ForEach(new Action<Guid>(cDisplayClass104.\u003CCreateFormViewItemDependencies\u003Eb__7));
                            num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 13 : 11;
                            continue;
                          case 4:
                            // ISSUE: reference to a compiler-generated field
                            cDisplayClass103.CS\u0024\u003C\u003E8__locals1 = cDisplayClass101;
                            num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 5 : 1;
                            continue;
                          case 5:
                            // ISSUE: reference to a compiler-generated field
                            cDisplayClass103.t = enumerator3.Current;
                            num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 1 : 1;
                            continue;
                          case 6:
                            goto label_24;
                          case 7:
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated method
                            // ISSUE: reference to a compiler-generated method
                            if (!CoreDbStructure.\u003C\u003Ec__DisplayClass10_0.m2afZfChnQJvmqm3PC9e(CoreDbStructure.\u003C\u003Ec__DisplayClass10_0.cQHPA8ChkqLoivvUlFZh((object) cDisplayClass104.CS\u0024\u003C\u003E8__locals2.t), Guid.Empty))
                            {
                              num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 3;
                              continue;
                            }
                            goto case 9;
                          case 8:
                            // ISSUE: reference to a compiler-generated field
                            cDisplayClass104.CS\u0024\u003C\u003E8__locals2 = cDisplayClass103;
                            num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 4 : 14;
                            continue;
                          case 9:
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated method
                            cDisplayClass104.dependFormUid = CoreDbStructure.\u003C\u003Ec__DisplayClass10_0.cQHPA8ChkqLoivvUlFZh((object) cDisplayClass104.CS\u0024\u003C\u003E8__locals2.t);
                            num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 0;
                            continue;
                          case 10:
                            goto label_4;
                          case 12:
                            // ISSUE: reference to a compiler-generated field
                            cDisplayClass104.dependType = FormDependencyDataType.Inherit;
                            num7 = 7;
                            continue;
                          case 13:
                            goto label_18;
                          case 14:
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            cDisplayClass104.dependFormUid = cDisplayClass104.CS\u0024\u003C\u003E8__locals2.t.Uid;
                            num7 = 12;
                            continue;
                          default:
                            // ISSUE: reference to a compiler-generated field
                            cDisplayClass104.dependType = FormDependencyDataType.Child;
                            num7 = 2;
                            continue;
                        }
                      }
label_19:
                      num7 = 10;
                      goto label_14;
label_24:
                      // ISSUE: object of a compiler-generated type is created
                      cDisplayClass103 = new CoreDbStructure.\u003C\u003Ec__DisplayClass10_3();
                      num7 = 4;
                      goto label_14;
                    }
                    finally
                    {
                      enumerator3.Dispose();
                      int num8 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
                        num8 = 0;
                      switch (num8)
                      {
                        default:
                      }
                    }
                  case 8:
                    List<Guid> guidList2 = guidList1;
                    List<ClassMetadata> classMetadataList = MetadataLoader.GetBaseClassMetadataList((ClassMetadata) metadata1, false, false);
                    // ISSUE: reference to a compiler-generated field
                    System.Func<ClassMetadata, Guid> func = CoreDbStructure.\u003C\u003Ec.\u003C\u003E9__10_5;
                    System.Func<ClassMetadata, Guid> selector;
                    if (func == null)
                    {
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: reference to a compiler-generated method
                      CoreDbStructure.\u003C\u003Ec.\u003C\u003E9__10_5 = selector = (System.Func<ClassMetadata, Guid>) (q => CoreDbStructure.\u003C\u003Ec.mROHVUCbxcxecfDjD4Em((object) q));
                    }
                    else
                      goto label_65;
label_63:
                    IEnumerable<Guid> collection = classMetadataList.Select<ClassMetadata, Guid>(selector);
                    guidList2.AddRange(collection);
                    num4 = 13;
                    continue;
label_65:
                    selector = func;
                    goto label_63;
                  case 9:
                    if (metadata1 != null)
                    {
                      num4 = 8;
                      continue;
                    }
                    goto case 6;
                  case 10:
                    if (metadata.Type == EntityMetadataType.InterfaceExtension)
                    {
                      num4 = 4;
                      continue;
                    }
                    goto case 19;
                  case 11:
                    goto label_61;
                  case 12:
label_4:
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated method
                    if (CoreDbStructure.\u003C\u003Ec__DisplayClass10_0.u4uoxfChOousOof7Y1hJ((object) cDisplayClass101.deps) == 0)
                    {
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 11 : 6;
                      continue;
                    }
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated field
                    FormDependencyHelper.Update(CoreDbStructure.\u003C\u003Ec__DisplayClass10_0.kLSibjChT2heZlRNPkHl((object) metadata), cDisplayClass101.deps.ToArray());
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 1 : 1;
                    continue;
                  case 13:
                    enumerator3 = metadata1.FormTransformations.GetEnumerator();
                    num4 = 3;
                    continue;
                  case 14:
                    if (metadata != null)
                    {
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
                      continue;
                    }
                    goto label_49;
                  case 15:
                    // ISSUE: object of a compiler-generated type is created
                    cDisplayClass101 = new CoreDbStructure.\u003C\u003Ec__DisplayClass10_1();
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 7 : 14;
                    continue;
                  case 16:
                    // ISSUE: reference to a compiler-generated method
                    metadata1 = service.GetMetadata(CoreDbStructure.\u003C\u003Ec__DisplayClass10_0.oYnARpChXLr6GDBnge1c((object) metadata), false) as EntityMetadata;
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 9 : 4;
                    continue;
                  case 17:
                    guidList1.AddRange(MetadataLoader.GetBaseClassMetadataList((ClassMetadata) metadata, false, false).Select<ClassMetadata, Guid>((System.Func<ClassMetadata, Guid>) (q => q.Uid)));
                    num4 = 6;
                    continue;
                  case 18:
                    list = metadata.FormTransformations.ToList<FormViewItemTransformation>();
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 9 : 10;
                    continue;
                  case 19:
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated method
                    cDisplayClass101.objectUid = CoreDbStructure.\u003C\u003Ec__DisplayClass10_0.kLSibjChT2heZlRNPkHl((object) metadata);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 13 : 17;
                    continue;
                  default:
                    if (metadata.FormTransformations.Count == 0)
                    {
                      num4 = 5;
                      continue;
                    }
                    guidList1 = new List<Guid>();
                    num4 = 18;
                    continue;
                }
              }
label_34:
              return;
label_11:
              return;
label_61:
              return;
label_49:;
            });
            List<EntityMetadata> list1 = service.GetMetadataList().OfType<EntityMetadata>().ToList<EntityMetadata>();
            // ISSUE: reference to a compiler-generated field
            System.Func<EntityMetadata, bool> func1 = CoreDbStructure.\u003C\u003Ec.\u003C\u003E9__10_1;
            System.Func<EntityMetadata, bool> predicate;
            if (func1 == null)
            {
              // ISSUE: reference to a compiler-generated field
              CoreDbStructure.\u003C\u003Ec.\u003C\u003E9__10_1 = predicate = (System.Func<EntityMetadata, bool>) (q => q.Type == EntityMetadataType.Interface);
            }
            else
              goto label_39;
label_37:
            list1.Where<EntityMetadata>(predicate).ForEach<EntityMetadata>(action);
            entityMetadataList = new List<EntityMetadata>();
            // ISSUE: reference to a compiler-generated method
            enumerator1 = list1.Where<EntityMetadata>((System.Func<EntityMetadata, bool>) (q => CoreDbStructure.\u003C\u003Ec.qJkvCuCb4vmSUFeo1MLw((object) q) == EntityMetadataType.InterfaceExtension)).GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 2 : 2;
            continue;
label_39:
            predicate = func1;
            goto label_37;
          case 4:
            IEntityManager<IMetadataItemHeader, long> instance = AbstractNHEntityManager<IMetadataItemHeader, long>.Instance;
            // ISSUE: type reference
            ParameterExpression parameterExpression = (ParameterExpression) CoreDbStructure.dp4VOeoobIsZZAnLlHta(CoreDbStructure.mijW1wooorQmuNQcLdwH(__typeref (IMetadataItemHeader)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2139071820));
            // ISSUE: method reference
            Expression<System.Func<IMetadataItemHeader, bool>> condition = Expression.Lambda<System.Func<IMetadataItemHeader, bool>>((Expression) CoreDbStructure.KG6VL6ooGxXu1Vjd9lWG((object) parameterExpression, (object) (MethodInfo) CoreDbStructure.oxkay6oohUE9qViLuQl6(__methodref (IMetadataItemHeader.get_IsDirtyItem))), parameterExpression);
            enumerator2 = instance.Find(condition).Select<IMetadataItemHeader, IMetadataItem>((System.Func<IMetadataItemHeader, IMetadataItem>) (q => q.Current)).ToList<IMetadataItem>().GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
            continue;
          case 5:
label_17:
            entityMetadataList.ForEach(action);
            num1 = 4;
            continue;
          default:
            goto label_18;
        }
      }
label_35:
      return;
label_18:
      try
      {
label_21:
        if (enumerator2.MoveNext())
          goto label_23;
        else
          goto label_22;
label_20:
        EntityMetadata entityMetadata;
        int num9;
        while (true)
        {
          switch (num9)
          {
            case 0:
              goto label_32;
            case 1:
              if (entityMetadata == null)
              {
                num9 = 3;
                continue;
              }
              goto case 4;
            case 2:
              goto label_23;
            case 3:
            case 5:
              goto label_21;
            case 4:
              action(entityMetadata);
              num9 = 5;
              continue;
            default:
              goto label_28;
          }
        }
label_32:
        return;
label_28:
        return;
label_22:
        num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 0 : 0;
        goto label_20;
label_23:
        entityMetadata = CoreDbStructure.uSHj0xooEHVyM0Xgo9e0((object) enumerator2.Current) as EntityMetadata;
        num9 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
        {
          num9 = 1;
          goto label_20;
        }
        else
          goto label_20;
      }
      finally
      {
        enumerator2.Dispose();
        int num10 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0)
          num10 = 0;
        switch (num10)
        {
          default:
        }
      }
    }

    /// <summary>Создать таблицу зависимостей форм</summary>
    public void CreateFormDependenciesTable()
    {
      int num = 2;
      ITransformationProvider serviceNotNull;
      EleWise.ELMA.Runtime.Db.Migrator.Framework.Table table1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!CoreDbStructure.QXhLWYoWU3mVZKDq0iKd((object) serviceNotNull, CoreDbStructure.FOteEaoWLQ1PYIw5Jowo(572119659 - -337058038 ^ 909294131)))
            {
              num = 3;
              continue;
            }
            goto label_2;
          case 2:
            serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 1 : 0;
            continue;
          case 3:
            EleWise.ELMA.Runtime.Db.Migrator.Framework.Table table2 = new EleWise.ELMA.Runtime.Db.Migrator.Framework.Table();
            CoreDbStructure.YwxxD7oWscxM0P7q9yow((object) table2, CoreDbStructure.FOteEaoWLQ1PYIw5Jowo(979449278 ^ 979598572));
            CoreDbStructure.aZ5VZqoofrnArL0drNLE((object) table2, false);
            table2.Columns = new List<Column>()
            {
              new Column(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852982414), DbType.Guid),
              new Column((string) CoreDbStructure.FOteEaoWLQ1PYIw5Jowo(-1487388570 ^ -1487271426), DbType.Guid),
              new Column((string) CoreDbStructure.FOteEaoWLQ1PYIw5Jowo(-420743386 ^ -420888860), DbType.Guid),
              new Column((string) CoreDbStructure.FOteEaoWLQ1PYIw5Jowo(1819636893 << 3 ^ 1672080648), DbType.Guid),
              new Column((string) CoreDbStructure.FOteEaoWLQ1PYIw5Jowo(-1939377524 ^ -1939387798), DbType.Int64)
            };
            table1 = table2;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
            continue;
          case 4:
            goto label_9;
          case 5:
            goto label_3;
          default:
            serviceNotNull.AddTable(table1);
            num = 4;
            continue;
        }
      }
label_9:
      return;
label_3:
      return;
label_2:;
    }

    /// <summary>Создать индексы для таблицы зависимостей форм</summary>
    internal void CreateFormDependenciesIndex()
    {
      int num = 4;
      string str1;
      ITransformationProvider serviceNotNull;
      string str2;
      EleWise.ELMA.Runtime.Db.Migrator.Framework.Index index1;
      EleWise.ELMA.Runtime.Db.Migrator.Framework.Index index2;
      while (true)
      {
        switch (num)
        {
          case 1:
            serviceNotNull.AddIndex(index2);
            num = 2;
            continue;
          case 2:
            goto label_11;
          case 3:
            str1 = (string) CoreDbStructure.FOteEaoWLQ1PYIw5Jowo(-1290212282 ^ -644262414 ^ 1787032498) + CoreDbStructure.owqjXSooQpZhd0vXbu3J(CoreDbStructure.FOteEaoWLQ1PYIw5Jowo(813604817 ^ 813487583)).ToString((string) CoreDbStructure.FOteEaoWLQ1PYIw5Jowo(-2112703338 ^ -2112729378)).Substring(0, 20);
            num = 8;
            continue;
          case 4:
            serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 3;
            continue;
          case 5:
            if (!CoreDbStructure.US4sj7ooC8SBoFFmMXFh((object) serviceNotNull, CoreDbStructure.FOteEaoWLQ1PYIw5Jowo(272623989 ^ 272474151), (object) str2))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 6:
            CoreDbStructure.miCvR8oovoI28hhYsPee((object) serviceNotNull, (object) index1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 7;
            continue;
          case 7:
          case 11:
            str2 = (string) CoreDbStructure.t5Jo8Doo8tuQOP9CPSrM(CoreDbStructure.FOteEaoWLQ1PYIw5Jowo(-710283084 ^ -537863435 ^ 173760583), (object) CoreDbStructure.owqjXSooQpZhd0vXbu3J(CoreDbStructure.FOteEaoWLQ1PYIw5Jowo(-2107978722 ^ -2108127668)).ToString((string) CoreDbStructure.FOteEaoWLQ1PYIw5Jowo(~-306453669 ^ 306505452)).Substring(0, 20));
            num = 5;
            continue;
          case 8:
            if (CoreDbStructure.US4sj7ooC8SBoFFmMXFh((object) serviceNotNull, CoreDbStructure.FOteEaoWLQ1PYIw5Jowo(-1886646897 ^ -1886501667), (object) str1))
            {
              num = 11;
              continue;
            }
            goto case 9;
          case 9:
            index1 = new EleWise.ELMA.Runtime.Db.Migrator.Framework.Index()
            {
              TableName = (string) CoreDbStructure.FOteEaoWLQ1PYIw5Jowo(1642859704 ^ 1643005418),
              Name = str1,
              Columns = new List<string>()
              {
                (string) CoreDbStructure.FOteEaoWLQ1PYIw5Jowo(1242972401 >> 4 ^ 77802873)
              }
            };
            num = 6;
            continue;
          case 10:
            goto label_6;
          default:
            EleWise.ELMA.Runtime.Db.Migrator.Framework.Index index3 = new EleWise.ELMA.Runtime.Db.Migrator.Framework.Index();
            CoreDbStructure.m0URYWooZ690Wq3fZI9o((object) index3, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1445902765 ^ -1980277732 ^ 539251485));
            CoreDbStructure.zLdRBVoou4v2uAaJQkCN((object) index3, (object) str2);
            index3.Columns = new List<string>()
            {
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97822316)
            };
            index2 = index3;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 1 : 0;
            continue;
        }
      }
label_11:
      return;
label_6:
      return;
label_2:;
    }

    /// <summary>Замена дублей uid в таблице FS_FILES</summary>
    internal void UpdateDoubleUidsSystemFile()
    {
      int num = 1;
      string sql;
      while (true)
      {
        switch (num)
        {
          case 1:
            sql = string.Format((string) CoreDbStructure.FOteEaoWLQ1PYIw5Jowo(-53329496 >> 4 ^ -3182968), CoreDbStructure.EKY5BRooVtlYq0iLcyhJ(CoreDbStructure.VifNIUooIKC9VFxUYX5b((object) this.Transformation), CoreDbStructure.FOteEaoWLQ1PYIw5Jowo(-882126494 ^ -882271990)), CoreDbStructure.EKY5BRooVtlYq0iLcyhJ((object) this.Transformation.Dialect, CoreDbStructure.FOteEaoWLQ1PYIw5Jowo(~541731958 ^ -541737957)), CoreDbStructure.NYt1hSooSGa1Up500GHj(CoreDbStructure.VifNIUooIKC9VFxUYX5b((object) this.Transformation)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            this.Transformation.ExecuteNonQuery(sql);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 2 : 0;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Ограничить длину поля "Name" в MetadataItemHeader</summary>
    internal void ConvertMetadataItemHeaderNameColumn()
    {
      int num = 2;
      string tableName;
      string columnName;
      ParameterExpression parameterExpression;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: type reference
            parameterExpression = Expression.Parameter(CoreDbStructure.mijW1wooorQmuNQcLdwH(__typeref (IMetadataItemHeader)), (string) CoreDbStructure.FOteEaoWLQ1PYIw5Jowo(1232639661 >> 3 ^ 154123873));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
            continue;
          case 2:
            tableName = (string) CoreDbStructure.FOteEaoWLQ1PYIw5Jowo(-1088304168 ^ -1088192378);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 1 : 1;
            continue;
          case 3:
            this.Transformation.ConvertColumnString(tableName, columnName, 512);
            num = 4;
            continue;
          case 4:
            goto label_2;
          case 5:
            CoreDbStructure.vq2d1Ioois52STxplnMK((object) this.Transformation, (object) tableName, CoreDbStructure.FOteEaoWLQ1PYIw5Jowo(813604817 ^ 813487191));
            num = 3;
            continue;
          default:
            // ISSUE: method reference
            columnName = LinqUtils.NameOf<IMetadataItemHeader>(Expression.Lambda<System.Func<IMetadataItemHeader, object>>((Expression) CoreDbStructure.KG6VL6ooGxXu1Vjd9lWG((object) parameterExpression, (object) (MethodInfo) CoreDbStructure.oxkay6oohUE9qViLuQl6(__methodref (IMetadataItemHeader.get_Name))), parameterExpression));
            num = 5;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Ограничить длину поля "Tag" в MetadataItemHeader</summary>
    internal void ConvertMetadataItemHeaderTagColumn()
    {
      int num = 3;
      ParameterExpression parameterExpression;
      string str1;
      string str2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            CoreDbStructure.VmxTBbooRPBVPvlZUEe0((object) this.Transformation, (object) str2, (object) str1, 512);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
            continue;
          case 2:
            // ISSUE: type reference
            parameterExpression = (ParameterExpression) CoreDbStructure.dp4VOeoobIsZZAnLlHta(CoreDbStructure.mijW1wooorQmuNQcLdwH(__typeref (IMetadataItemHeader)), CoreDbStructure.FOteEaoWLQ1PYIw5Jowo(1654249598 >> 2 ^ 413588139));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 4 : 4;
            continue;
          case 3:
            str2 = (string) CoreDbStructure.FOteEaoWLQ1PYIw5Jowo(-218496594 ^ -218608912);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 2 : 2;
            continue;
          case 4:
            // ISSUE: method reference
            str1 = LinqUtils.NameOf<IMetadataItemHeader>(Expression.Lambda<System.Func<IMetadataItemHeader, object>>((Expression) CoreDbStructure.KG6VL6ooGxXu1Vjd9lWG((object) parameterExpression, (object) (MethodInfo) CoreDbStructure.oxkay6oohUE9qViLuQl6(__methodref (IMetadataItemHeader.get_Tag))), parameterExpression));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 1;
            continue;
          default:
            goto label_7;
        }
      }
label_2:
      return;
label_7:;
    }

    /// <summary>
    /// Ограничить длину поля "Name" в ModuleMetadataItemHeader
    /// </summary>
    internal void ConvertModuleMetadataItemHeaderNameColumn()
    {
      int num = 2;
      string tableName;
      string columnName;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            columnName = (string) CoreDbStructure.FOteEaoWLQ1PYIw5Jowo(864270449 << 6 ^ -521244800);
            num = 3;
            continue;
          case 2:
            tableName = z2jc63fLkugS1X8Q9N.tE1kD1vbB(44884861 ^ 45000897);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 1 : 1;
            continue;
          case 3:
            this.Transformation.ConvertColumnString(tableName, columnName, 512);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_2:
      return;
label_6:;
    }

    /// <summary>
    /// Ограничить длину поля "Namespace" в GlobalScriptModuleHeader
    /// </summary>
    internal void ConvertGlobalScriptModuleHeaderNamespaceColumn()
    {
      int num = 2;
      string str1;
      string str2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            str1 = (string) CoreDbStructure.FOteEaoWLQ1PYIw5Jowo(1669371371 ^ 1669403559);
            num = 3;
            continue;
          case 2:
            str2 = (string) CoreDbStructure.KIKK7LooqyrZQVZ9YDkN((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-244066886 - -48452443 ^ -195730715), 1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 1;
            continue;
          case 3:
            CoreDbStructure.VmxTBbooRPBVPvlZUEe0((object) this.Transformation, (object) str2, (object) str1, 2000);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_2:
      return;
label_6:;
    }

    public CoreDbStructure()
    {
      CoreDbStructure.TlViORooKdkTj8NGgXGb();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static CoreDbStructure()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            CoreDbStructure.DbUpdateLog = Logger.GetLogger((string) CoreDbStructure.FOteEaoWLQ1PYIw5Jowo(-1998538950 ^ -1998502058));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
            continue;
          case 2:
            CoreDbStructure.TlViORooKdkTj8NGgXGb();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static object FOteEaoWLQ1PYIw5Jowo(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool QXhLWYoWU3mVZKDq0iKd([In] object obj0, [In] object obj1) => ((ITransformationProvider) obj0).TableExists((string) obj1);

    internal static void YwxxD7oWscxM0P7q9yow([In] object obj0, [In] object obj1) => ((EleWise.ELMA.Runtime.Db.Migrator.Framework.Table) obj0).Name = (string) obj1;

    internal static void i5jt1OoWce42sL56AZeD([In] object obj0, [In] object obj1) => ((ITransformationProvider) obj0).AddTable((EleWise.ELMA.Runtime.Db.Migrator.Framework.Table) obj1);

    internal static bool uJM30JoWj5KWJroUIWIw() => CoreDbStructure.sWlNbSoW5Ys2mQKZw99Z == null;

    internal static CoreDbStructure GHbHiKoWYkC2NWmLu1O7() => CoreDbStructure.sWlNbSoW5Ys2mQKZw99Z;

    internal static object iInrZwoWzq2dTFYVYRhY() => (object) MetadataServiceContext.Service;

    internal static object xRTBITooFP6e1PCopJFs() => (object) ComponentManager.Current;

    internal static void WZf8jBooBLOxH5Dte3pl([In] object obj0, int timeout, [In] object obj2) => ((ITransformationProvider) obj0).ExecuteWithTimeout(timeout, (System.Action) obj2);

    internal static bool qIGrXsooW1QhykJ86KBT([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static Type mijW1wooorQmuNQcLdwH([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object dp4VOeoobIsZZAnLlHta([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static object oxkay6oohUE9qViLuQl6([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static object KG6VL6ooGxXu1Vjd9lWG([In] object obj0, [In] object obj1) => (object) Expression.Property((Expression) obj0, (MethodInfo) obj1);

    internal static object uSHj0xooEHVyM0Xgo9e0([In] object obj0) => ((IMetadataItem) obj0).Metadata;

    internal static void aZ5VZqoofrnArL0drNLE([In] object obj0, bool value) => ((EleWise.ELMA.Runtime.Db.Migrator.Framework.Table) obj0).IsTemporary = value;

    internal static Guid owqjXSooQpZhd0vXbu3J([In] object obj0) => ((string) obj0).GetDeterministicGuid();

    internal static bool US4sj7ooC8SBoFFmMXFh([In] object obj0, [In] object obj1, [In] object obj2) => ((ITransformationProvider) obj0).IndexExists((string) obj1, (string) obj2);

    internal static void miCvR8oovoI28hhYsPee([In] object obj0, [In] object obj1) => ((ITransformationProvider) obj0).AddIndex((EleWise.ELMA.Runtime.Db.Migrator.Framework.Index) obj1);

    internal static object t5Jo8Doo8tuQOP9CPSrM([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static void m0URYWooZ690Wq3fZI9o([In] object obj0, [In] object obj1) => ((EleWise.ELMA.Runtime.Db.Migrator.Framework.Index) obj0).TableName = (string) obj1;

    internal static void zLdRBVoou4v2uAaJQkCN([In] object obj0, [In] object obj1) => ((EleWise.ELMA.Runtime.Db.Migrator.Framework.Index) obj0).Name = (string) obj1;

    internal static object VifNIUooIKC9VFxUYX5b([In] object obj0) => (object) ((ITransformationProvider) obj0).Dialect;

    internal static object EKY5BRooVtlYq0iLcyhJ([In] object obj0, [In] object obj1) => (object) ((Dialect) obj0).QuoteIfNeeded((string) obj1);

    internal static object NYt1hSooSGa1Up500GHj([In] object obj0) => (object) ((Dialect) obj0).GenUid();

    internal static void vq2d1Ioois52STxplnMK([In] object obj0, [In] object obj1, [In] object obj2) => ((ITransformationProvider) obj0).RemoveIndex((string) obj1, (string) obj2);

    internal static void VmxTBbooRPBVPvlZUEe0(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      int columnSize)
    {
      ((ITransformationProvider) obj0).ConvertColumnString((string) obj1, (string) obj2, columnSize);
    }

    internal static object KIKK7LooqyrZQVZ9YDkN([In] object obj0, [In] int obj1) => (object) ((string) obj0).Substring(obj1);

    internal static void TlViORooKdkTj8NGgXGb() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
