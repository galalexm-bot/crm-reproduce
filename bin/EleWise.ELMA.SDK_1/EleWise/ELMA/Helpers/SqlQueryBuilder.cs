// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Helpers.SqlQueryBuilder
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Engine;
using NHibernate.Loader;
using NHibernate.Loader.Criteria;
using NHibernate.Param;
using NHibernate.Transform;
using NHibernate.Type;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Helpers
{
  /// <summary>Генератор sql запросов.</summary>
  public class SqlQueryBuilder
  {
    private readonly ISession session;
    private static SqlQueryBuilder yrgmuFhYEgYRlhkR4G5Y;

    /// <summary>Список параметров для добавляемых частей запросов.</summary>
    internal List<List<object>> PartsParametersList { get; set; }

    /// <summary>Создаёт новый экземпляр построителя запросов.</summary>
    /// <param name="session">Сессия</param>
    public SqlQueryBuilder(ISession session)
    {
      SqlQueryBuilder.lrgZwkhYC8C3g79KSYRo();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.PartsParametersList = new List<List<object>>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
            continue;
          case 2:
            this.session = session;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    /// <summary>Добавить критерию.</summary>
    /// <param name="criteria">Критерия.</param>
    /// <returns>Возвращает строковый sql запрос из критерии.</returns>
    public string AddPartQuery(ICriteria criteria) => this.AddPartQuery(criteria, (string) null);

    /// <summary>Добавить критерию</summary>
    /// <param name="criteria">Критерия</param>
    /// <param name="rootAlias">Корневой алиас</param>
    /// <returns>Возвращает строковый sql запрос из критерии</returns>
    public string AddPartQuery(ICriteria criteria, string rootAlias)
    {
      int num1 = 2;
      string str;
      while (true)
      {
        int num2 = num1;
        CriteriaLoader loader;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_9;
            case 2:
              loader = HibernateHqlAndCriteriaToSqlTranslator.GetLoader(criteria);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 1 : 0;
              continue;
            case 3:
              str = SqlQueryBuilder.D2M3syhYZF2engTmY32g((object) loader).ToString();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 0;
              continue;
            case 4:
              goto label_3;
            default:
              if (!string.IsNullOrEmpty(rootAlias))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 4 : 0;
                continue;
              }
              goto label_4;
          }
        }
label_9:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        this.PartsParametersList.Add(((ISessionImplementor) SqlQueryBuilder.D1vipphYv90IZkxnTKUK((object) this.session)).NullSafeSet(((CriteriaQueryTranslator) SqlQueryBuilder.Ae4Gw1hY8QH3EYswJeaJ((object) loader)).CollectedParameters.Select<NamedParameter, IType>((Func<NamedParameter, IType>) (p => (IType) SqlQueryBuilder.\u003C\u003Ec.UocCuevmlLK8V77O08X3((object) p))), ((CriteriaQueryTranslator) SqlQueryBuilder.Ae4Gw1hY8QH3EYswJeaJ((object) loader)).CollectedParameters.Select<NamedParameter, object>((Func<NamedParameter, object>) (p => SqlQueryBuilder.\u003C\u003Ec.sx18bovmrAuqv8GCmGha((object) p)))).ToList<object>());
        num1 = 3;
      }
label_3:
      return (string) SqlQueryBuilder.BXVZWhhYuHDuCAZnWRhN((object) str, (object) CriteriaSpecification.RootAlias, (object) rootAlias);
label_4:
      return str;
    }

    /// <summary>Генерирует запрос из строкового sql запроса.</summary>
    /// <param name="queryString">sql-запрос.</param>
    /// <typeparam name="T">Тип, в который будет преобразован результат запроса.</typeparam>
    public ISQLQuery Build<T>(string queryString)
    {
      ISQLQuery sqlQuery = (ISQLQuery) this.session.CreateSQLQuery(queryString).SetResultTransformer(Transformers.AliasToBean(typeof (T))).CleanUpCache(false);
      if (this.PartsParametersList.Count > 0)
      {
        int position = 0;
        foreach (List<object> partsParameters in this.PartsParametersList)
        {
          if (partsParameters.Count != 0)
          {
            foreach (object val in partsParameters)
            {
              sqlQuery.SetParameter(position, val);
              ++position;
            }
          }
        }
      }
      return sqlQuery;
    }

    /// <summary>Возвращает алиас идентификатора.</summary>
    /// <param name="criteria">Критерия</param>
    /// <param name="alias">Псевдоним</param>
    public string GetAliaseIdentifier(ICriteria criteria, string alias = "this")
    {
      int num1 = 5;
      IEntityAliases[] entityAliasesArray;
      int index1;
      while (true)
      {
        int num2 = num1;
        System.Type type;
        PropertyInfo property;
        FieldInfo field;
        CriteriaLoader criteriaLoader;
        string[] strArray;
        int index2;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 2:
            case 9:
              if (index1 != -1)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 19 : 11;
                continue;
              }
              goto label_25;
            case 3:
            case 12:
              if (!SqlQueryBuilder.toe2HIhYq8PFjTXNF2Sx((object) strArray[index2], (object) alias))
              {
                num2 = 17;
                continue;
              }
              goto case 21;
            case 4:
              alias = (string) SqlQueryBuilder.moZBhnhYVcLvZObTSX7w(1142330761 ^ 1541959139 ^ 536697716);
              num2 = 18;
              continue;
            case 5:
              if (SqlQueryBuilder.BshRdlhYIjWZHqlXKXGZ((object) alias))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 4 : 2;
                continue;
              }
              goto case 18;
            case 6:
              if (!(field != (FieldInfo) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 1 : 1;
                continue;
              }
              goto case 8;
            case 7:
              field = type.GetField((string) SqlQueryBuilder.moZBhnhYVcLvZObTSX7w(-630932142 - 1120244082 ^ -1751349080), BindingFlags.Instance | BindingFlags.NonPublic);
              num2 = 6;
              continue;
            case 8:
              strArray = (string[]) SqlQueryBuilder.WhhDrqhYRbiqTomZYtrE((object) field, (object) criteriaLoader);
              num2 = 11;
              continue;
            case 10:
              index1 = -1;
              num2 = 7;
              continue;
            case 11:
              index2 = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 5 : 16;
              continue;
            case 13:
              if (entityAliasesArray.Length != 0)
              {
                num2 = 15;
                continue;
              }
              goto label_24;
            case 14:
              if (SqlQueryBuilder.nDlPvghYicbA1WTytGPi((object) property, (object) null))
              {
                num2 = 10;
                continue;
              }
              goto label_25;
            case 15:
              goto label_23;
            case 16:
            case 20:
              if (index2 < strArray.Length)
              {
                num2 = 3;
                continue;
              }
              goto case 1;
            case 17:
              goto label_20;
            case 18:
              criteriaLoader = (CriteriaLoader) SqlQueryBuilder.wiU2enhYSJNycI7X09LO((object) criteria);
              num2 = 22;
              continue;
            case 19:
              goto label_11;
            case 21:
              ++index2;
              num2 = 20;
              continue;
            case 22:
              type = criteriaLoader.GetType();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 0;
              continue;
            default:
              property = type.GetProperty((string) SqlQueryBuilder.moZBhnhYVcLvZObTSX7w(1917256330 ^ 1917100448), BindingFlags.Instance | BindingFlags.NonPublic);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 14 : 10;
              continue;
          }
        }
label_11:
        entityAliasesArray = (IEntityAliases[]) property.GetValue((object) criteriaLoader, (object[]) null);
        num1 = 13;
        continue;
label_20:
        index1 = index2;
        num1 = 2;
      }
label_23:
      return entityAliasesArray[index1].SuffixedKeyAliases[0];
label_24:
      return (string) SqlQueryBuilder.moZBhnhYVcLvZObTSX7w(--1360331293 ^ 1360364355);
label_25:
      return "";
    }

    /// <summary>Возвращает алиас для критерии.</summary>
    /// <param name="criteria">Критерия.</param>
    public static string GetCriteriaAlias(ICriteria criteria) => (string) SqlQueryBuilder.PNOdOFhYKyfEXCS0xlUl(SqlQueryBuilder.Ae4Gw1hY8QH3EYswJeaJ(SqlQueryBuilder.wiU2enhYSJNycI7X09LO((object) criteria)));

    /// <summary>
    /// Возвращает имя свойства в базе данных, являющегося наименованием.
    /// </summary>
    public static string EntityTitleProperty(Guid entityUid) => SqlQueryBuilder.EntityTitleProperty(ModelHelper.GetEntityType(entityUid));

    /// <summary>
    /// Возвращает имя свойства в базе данных, являющегося наименованием.
    /// </summary>
    public static string EntityTitleProperty(System.Type entityType)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (SqlQueryBuilder.JxpARkhYXopnwbLfhUZU(entityType, (System.Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return (string) null;
label_5:
      return (string) SqlQueryBuilder.VZ7MR4hYkmbMe8dsvqnX(SqlQueryBuilder.H0TY3FhYTQfQuqReW7DY((object) (EntityMetadata) MetadataLoader.LoadMetadata(InterfaceActivator.TypeOf(entityType))));
    }

    /// <summary>
    /// Возвращает имя свойства в базе данных, являющегося наименованием.
    /// </summary>
    public static string EntityTitleProperty<T>() => SqlQueryBuilder.EntityTitleProperty(typeof (T));

    private static string EntityTitlePropertyString(object entityTitleProperty)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (entityTitleProperty != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            goto label_4;
          default:
            goto label_5;
        }
      }
label_4:
      return (string) null;
label_5:
      return (string) SqlQueryBuilder.KksFqvhYnAaDt7hCjxSG((object) (SimpleTypeSettings) ((IPropertyMetadata) entityTitleProperty).Settings);
    }

    internal static void lrgZwkhYC8C3g79KSYRo() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool pgmJsChYf11wv1X6X4bl() => SqlQueryBuilder.yrgmuFhYEgYRlhkR4G5Y == null;

    internal static SqlQueryBuilder M1wZSJhYQGDv0PircNoE() => SqlQueryBuilder.yrgmuFhYEgYRlhkR4G5Y;

    internal static object D1vipphYv90IZkxnTKUK([In] object obj0) => (object) ((ISession) obj0).GetSessionImplementation();

    internal static object Ae4Gw1hY8QH3EYswJeaJ([In] object obj0) => (object) ((CriteriaLoader) obj0).Translator;

    internal static object D2M3syhYZF2engTmY32g([In] object obj0) => (object) ((NHibernate.Loader.Loader) obj0).SqlString;

    internal static object BXVZWhhYuHDuCAZnWRhN([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0).Replace((string) obj1, (string) obj2);

    internal static bool BshRdlhYIjWZHqlXKXGZ([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object moZBhnhYVcLvZObTSX7w(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object wiU2enhYSJNycI7X09LO([In] object obj0) => (object) HibernateHqlAndCriteriaToSqlTranslator.GetLoader((ICriteria) obj0);

    internal static bool nDlPvghYicbA1WTytGPi([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 != (PropertyInfo) obj1;

    internal static object WhhDrqhYRbiqTomZYtrE([In] object obj0, [In] object obj1) => ((FieldInfo) obj0).GetValue(obj1);

    internal static bool toe2HIhYq8PFjTXNF2Sx([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

    internal static object PNOdOFhYKyfEXCS0xlUl([In] object obj0) => (object) ((CriteriaQueryTranslator) obj0).RootSQLAlias;

    internal static bool JxpARkhYXopnwbLfhUZU([In] System.Type obj0, [In] System.Type obj1) => obj0 == obj1;

    internal static object H0TY3FhYTQfQuqReW7DY([In] object obj0) => (object) ((ClassMetadata) obj0).GetTitleProperty();

    internal static object VZ7MR4hYkmbMe8dsvqnX([In] object obj0) => (object) SqlQueryBuilder.EntityTitlePropertyString(obj0);

    internal static object KksFqvhYnAaDt7hCjxSG([In] object obj0) => (object) ((SimpleTypeSettings) obj0).FieldName;
  }
}
