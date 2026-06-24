// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Helpers.NHibernateHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Engine;
using NHibernate.Impl;
using NHibernate.Loader;
using NHibernate.Loader.Criteria;
using NHibernate.Persister.Entity;
using NHibernate.SqlCommand;
using NHibernate.SqlTypes;
using NHibernate.Type;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Helpers
{
  /// <summary>Набор помощников для постоения запросов</summary>
  public static class NHibernateHelper
  {
    private static IMetadataRuntimeService metadataService;
    internal static NHibernateHelper bTg2L2hzNgepw7r4iW8M;

    /// <summary>Построение and запроса</summary>
    /// <param name="criterions"></param>
    /// <returns></returns>
    public static AbstractCriterion And(params AbstractCriterion[] criterions)
    {
      int num1 = 2;
      Conjunction conjunction;
      while (true)
      {
        int num2 = num1;
        int index;
        AbstractCriterion[] abstractCriterionArray;
        AbstractCriterion abstractCriterion;
        while (true)
        {
          switch (num2)
          {
            case 1:
              abstractCriterionArray = criterions;
              num2 = 7;
              continue;
            case 2:
              conjunction = new Conjunction();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 1 : 0;
              continue;
            case 3:
            case 8:
              abstractCriterion = abstractCriterionArray[index];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 4 : 1;
              continue;
            case 4:
              goto label_10;
            case 6:
              goto label_11;
            case 7:
              index = 0;
              num2 = 5;
              continue;
            case 9:
              ++index;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 0;
              continue;
            default:
              if (index < abstractCriterionArray.Length)
              {
                num2 = 8;
                continue;
              }
              goto label_11;
          }
        }
label_10:
        NHibernateHelper.pPyKp4hzaMQtG9SCgplB((object) conjunction, (object) abstractCriterion);
        num1 = 9;
      }
label_11:
      return (AbstractCriterion) conjunction;
    }

    public static AbstractCriterion And(IEnumerable<AbstractCriterion> criterions) => NHibernateHelper.And(criterions.ToArray<AbstractCriterion>());

    /// <summary>Построение or запроса</summary>
    /// <param name="criterions"></param>
    /// <returns></returns>
    public static AbstractCriterion Or(params AbstractCriterion[] criterions)
    {
      int num = 6;
      Disjunction disjunction;
      while (true)
      {
        AbstractCriterion[] abstractCriterionArray;
        int index;
        AbstractCriterion abstractCriterion;
        switch (num)
        {
          case 1:
            disjunction.Add((ICriterion) abstractCriterion);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 2 : 2;
            continue;
          case 2:
            ++index;
            num = 4;
            continue;
          case 3:
          case 4:
            if (index >= abstractCriterionArray.Length)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 8 : 1;
              continue;
            }
            break;
          case 5:
            abstractCriterionArray = criterions;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 7 : 3;
            continue;
          case 6:
            disjunction = new Disjunction();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 1 : 5;
            continue;
          case 7:
            index = 0;
            num = 3;
            continue;
          case 8:
            goto label_7;
        }
        abstractCriterion = abstractCriterionArray[index];
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 1 : 1;
      }
label_7:
      return (AbstractCriterion) disjunction;
    }

    public static AbstractCriterion Or(IEnumerable<AbstractCriterion> criterions) => NHibernateHelper.Or(criterions.ToArray<AbstractCriterion>());

    public static DetachedCriteria CreateFromCriteria(ICriteria criteria) => (DetachedCriteria) new ConvertedDetachedCriteria((ICriteria) NHibernateHelper.eCHoX4hzDgKGp0UhQFuo((object) criteria));

    /// <summary>Построить критерию с учетом ограничения на In</summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="objects"></param>
    /// <returns></returns>
    [Obsolete("Use Restrictions.In instead", true)]
    public static AbstractCriterion In<T>(string propertyName, params T[] objects) => Restrictions.In(propertyName, (ICollection) objects);

    /// <summary>
    /// Преобразует критерию в SQl-запрос. Все параметры заменяются на символ "?"
    /// </summary>
    /// <param name="criteria"></param>
    /// <returns></returns>
    public static string ConvertToSqlQuery(ICriteria criteria)
    {
      int num = 2;
      CriteriaImpl criteria1;
      CriteriaQueryTranslator translator;
      string[] strArray;
      while (true)
      {
        switch (num)
        {
          case 1:
            translator = new CriteriaQueryTranslator(((ISessionImplementor) NHibernateHelper.v8JOEchztLerDJqawpcu((object) criteria1)).Factory, criteria1, (string) NHibernateHelper.E1jCBshzwUvT0waQ0ODb((object) criteria1), CriteriaQueryTranslator.RootSqlAlias);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
            continue;
          case 2:
            criteria1 = (CriteriaImpl) criteria;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 1 : 1;
            continue;
          case 3:
            goto label_4;
          default:
            strArray = (string[]) NHibernateHelper.YqlKQghz6qBoZVv81Es6(NHibernateHelper.Y63teZhz4qgG6c88Ls9t(NHibernateHelper.v8JOEchztLerDJqawpcu((object) criteria1)), NHibernateHelper.E1jCBshzwUvT0waQ0ODb((object) criteria1));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 3 : 3;
            continue;
        }
      }
label_4:
      return NHibernateHelper.dpnMZOhzHubTp2F4k3eB((object) new CriteriaJoinWalker((IOuterJoinLoadable) ((ISessionFactoryImplementor) NHibernateHelper.Y63teZhz4qgG6c88Ls9t(NHibernateHelper.v8JOEchztLerDJqawpcu((object) criteria1))).GetEntityPersister(strArray[0]), translator, (ISessionFactoryImplementor) NHibernateHelper.Y63teZhz4qgG6c88Ls9t(NHibernateHelper.v8JOEchztLerDJqawpcu((object) criteria1)), (ICriteria) criteria1, (string) NHibernateHelper.E1jCBshzwUvT0waQ0ODb((object) criteria1), criteria1.Session.EnabledFilters)).ToString();
    }

    /// <summary>
    /// Преобразует DetachedCriteria в SQl-запрос. Все параметры заменяются на символ "?"
    /// </summary>
    /// <param name="detachedCriteria"></param>
    /// <param name="session"></param>
    /// <returns></returns>
    public static string ConvertToSqlQuery(DetachedCriteria detachedCriteria, ISession session) => NHibernateHelper.ConvertToSqlQuery(detachedCriteria.GetExecutableCriteria(session));

    /// <summary>
    /// Получить имя свойства TypeUid для построения запроса через критерию.
    /// </summary>
    /// <param name="metadata">Метаданные сущности</param>
    /// <returns>Имя свойства TypeUid для использования в критериях</returns>
    public static string GetCriteriaTypeUidPropertyName(EntityMetadata metadata) => (string) NHibernateHelper.SHgviJhz7meXBYdMdupW(NHibernateHelper.P09xVBhzAAfR5gruTwDV((object) metadata));

    /// <summary>
    /// Получить имя свойства TypeUid для построения запроса через критерию.
    /// </summary>
    /// <param name="typeUid">Уникальный идентификатор типа сущности</param>
    /// <returns>Имя свойства TypeUid для использования в критериях</returns>
    public static string GetCriteriaTypeUidPropertyName(Guid typeUid)
    {
      int num = 1;
      while (true)
      {
        IMetadataRuntimeService metadataRuntimeService;
        switch (num)
        {
          case 1:
            IMetadataRuntimeService metadataService = NHibernateHelper.metadataService;
            if (metadataService == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
              continue;
            }
            metadataRuntimeService = metadataService;
            break;
          case 2:
            goto label_2;
          default:
            metadataRuntimeService = Locator.GetServiceNotNull<IMetadataRuntimeService>();
            break;
        }
        NHibernateHelper.metadataService = metadataRuntimeService;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 2 : 0;
      }
label_2:
      return (string) NHibernateHelper.eVJqqZhzxq0VvB3ULd1L(NHibernateHelper.metadataService.GetTypeByUid(typeUid));
    }

    /// <summary>
    /// Получить имя свойства TypeUid для построения запроса через критерию.
    /// </summary>
    /// <param name="type">Тип сущности</param>
    /// <returns>Имя свойства TypeUid для использования в критериях</returns>
    public static string GetCriteriaTypeUidPropertyName(System.Type type)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            // ISSUE: type reference
            if (NHibernateHelper.qSuMqbhz09eh2yc9CVU5(__typeref (IInheritable)).IsAssignableFrom(type))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 1;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      return (string) NHibernateHelper.ccqAcwhzmofdnbrySy5E(-1886646897 ^ -1886629907);
label_5:
      return (string) NHibernateHelper.ccqAcwhzmofdnbrySy5E(-87337865 ^ -87492015);
    }

    /// <summary>Получить значения по типам</summary>
    /// <param name="session">Реализация сессии</param>
    /// <param name="types">Типы</param>
    /// <param name="values">Значения</param>
    /// <returns>Значения по типам</returns>
    /// <remarks>
    /// Тип может реализовываться в нескольких значениях, в этом случае результат будет содержать все
    /// </remarks>
    internal static IEnumerable<object> NullSafeSet(
      this ISessionImplementor session,
      IEnumerable<IType> types,
      IEnumerable<object> values)
    {
      ISessionFactoryImplementor sessionFactory = session.Factory;
      List<SqlType> parameterTypes = new List<SqlType>();
      int index = 0;
      \u003C\u003Ef__AnonymousType23<IType, int>[] typeIndexes = types.Select(type =>
      {
        parameterTypes.AddRange((IEnumerable<SqlType>) type.SqlTypes((IMapping) sessionFactory));
        // ISSUE: object of a compiler-generated type is created
        var data = new \u003C\u003Ef__AnonymousType23<IType, int>(type, index);
        index += type.GetColumnSpan((IMapping) sessionFactory);
        return data;
      }).ToArray();
      DbCommand command = sessionFactory.ConnectionProvider.Driver.GenerateCommand(CommandType.Text, new SqlString(""), parameterTypes.ToArray());
      values.ForEach<object>((Action<object, int>) ((v, i) =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              // ISSUE: reference to a compiler-generated method
              NHibernateHelper.\u003C\u003Ec__DisplayClass13_0.WpwQYPv9bKsCrcUJWasa((object) typeIndexes[i].type, (object) command, v, typeIndexes[i].index, (object) session);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }));
      return command.Parameters.Cast<IDbDataParameter>().Select<IDbDataParameter, object>((System.Func<IDbDataParameter, object>) (p => p.Value));
    }

    /// <summary>Получить значения по типам</summary>
    /// <param name="session">Реализация сессии</param>
    /// <param name="types">Типы</param>
    /// <param name="values">Значения</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Значения по типам</returns>
    /// <remarks>
    /// Тип может реализовываться в нескольких значениях, в этом случае результат будет содержать все
    /// </remarks>
    internal static async Task<IEnumerable<object>> NullSafeSetAsync(
      this ISessionImplementor session,
      IEnumerable<IType> types,
      IEnumerable<object> values,
      CancellationToken cancellationToken)
    {
      int num1 = 4;
      int num2;
      IEnumerable<object> result;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_34;
          case 1:
label_37:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003E1__state = -2;
            num1 = 2;
            continue;
          case 2:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(result);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
            continue;
          case 3:
            try
            {
              int num3;
              if (num2 == 0)
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 4 : 0;
              else
                goto label_23;
label_5:
              while (true)
              {
                TaskAwaiter taskAwaiter;
                int num4;
                TaskAwaiter awaiter;
                List<SqlType> parameterTypes;
                ISessionFactoryImplementor sessionFactory;
                int index;
                \u003C\u003Ef__AnonymousType23<IType, int>[] typeIndexes;
                DbCommand command;
                ISessionImplementor session1;
                CancellationToken cancellationToken1;
                switch (num3)
                {
                  case 1:
                    sessionFactory = session1.Factory;
                    num3 = 8;
                    continue;
                  case 2:
                    goto label_27;
                  case 3:
                    session1 = session;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 20 : 2;
                    continue;
                  case 4:
                  case 7:
                    awaiter = taskAwaiter;
                    num3 = 12;
                    continue;
                  case 5:
                    if (!awaiter.IsCompleted)
                    {
                      num4 = 18;
                      break;
                    }
                    goto case 17;
                  case 6:
                    goto label_37;
                  case 8:
                    parameterTypes = new List<SqlType>();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 3 : 11;
                    continue;
                  case 9:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, NHibernateHelper.\u003CNullSafeSetAsync\u003Ed__14>(ref awaiter, this);
                    num4 = 2;
                    break;
                  case 10:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num4 = 17;
                    break;
                  case 11:
                    index = 0;
                    num4 = 19;
                    break;
                  case 12:
                    taskAwaiter = new TaskAwaiter();
                    num3 = 10;
                    continue;
                  case 13:
                    taskAwaiter = awaiter;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 9 : 3;
                    continue;
                  case 14:
                    // ISSUE: reference to a compiler-generated method
                    awaiter = NHibernateHelper.\u003CNullSafeSetAsync\u003Ed__14.n4In4Zv9KvMHatpwJFNQ((object) Task.WhenAll(values.Select<object, Task>((Func<object, int, Task>) ((v, i) => typeIndexes[i].type.NullSafeSetAsync(command, v, typeIndexes[i].index, session1, cancellationToken1)))));
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 3 : 5;
                    continue;
                  case 15:
                    goto label_23;
                  case 16:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    result = ((IEnumerable) NHibernateHelper.\u003CNullSafeSetAsync\u003Ed__14.gk4YVuv9XovtvS7QuZpb((object) command)).Cast<IDbDataParameter>().Select<IDbDataParameter, object>((System.Func<IDbDataParameter, object>) (p => NHibernateHelper.\u003C\u003Ec.RY2BJAv9QnCBW1NXxnJA((object) p)));
                    num4 = 6;
                    break;
                  case 17:
                    awaiter.GetResult();
                    num3 = 16;
                    continue;
                  case 18:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 0;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 13;
                    continue;
                  case 19:
                    typeIndexes = types.Select(type =>
                    {
                      parameterTypes.AddRange((IEnumerable<SqlType>) type.SqlTypes((IMapping) sessionFactory));
                      // ISSUE: object of a compiler-generated type is created
                      var data = new \u003C\u003Ef__AnonymousType23<IType, int>(type, index);
                      index += type.GetColumnSpan((IMapping) sessionFactory);
                      return data;
                    }).ToArray();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
                    continue;
                  case 20:
                    cancellationToken1 = cancellationToken;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 0 : 1;
                    continue;
                  default:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    command = (DbCommand) NHibernateHelper.\u003CNullSafeSetAsync\u003Ed__14.I9JeVAv9q7SIgWlgwSSW(NHibernateHelper.\u003CNullSafeSetAsync\u003Ed__14.wqtO1ev9iKrZm1i1aZXp(NHibernateHelper.\u003CNullSafeSetAsync\u003Ed__14.p0HtBrv9S0EfQflhWe4X((object) sessionFactory)), CommandType.Text, (object) new SqlString(""), NHibernateHelper.\u003CNullSafeSetAsync\u003Ed__14.rDcNuMv9RR9cn2CWRY9Q((object) parameterTypes));
                    num3 = 14;
                    continue;
                }
                num3 = num4;
              }
label_27:
              return;
label_23:
              num3 = 3;
              goto label_5;
            }
            catch (Exception ex)
            {
              int num5 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
                num5 = 1;
              while (true)
              {
                switch (num5)
                {
                  case 0:
                    goto label_9;
                  case 1:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num5 = 2;
                    continue;
                  case 2:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_7;
                }
              }
label_9:
              return;
label_7:
              return;
            }
          case 4:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 2 : 3;
            continue;
          default:
            goto label_31;
        }
      }
label_34:
      return;
label_31:;
    }

    static NHibernateHelper() => NHibernateHelper.t2gIEShzyFYqZaOZKkbQ();

    internal static object pPyKp4hzaMQtG9SCgplB([System.Runtime.InteropServices.In] object obj0, [System.Runtime.InteropServices.In] object obj1) => (object) ((Junction) obj0).Add((ICriterion) obj1);

    internal static bool tDD1wjhz3Bx48uBQjX7U() => NHibernateHelper.bTg2L2hzNgepw7r4iW8M == null;

    internal static NHibernateHelper nbFlcchzpyN4SbWb1qbk() => NHibernateHelper.bTg2L2hzNgepw7r4iW8M;

    internal static object eCHoX4hzDgKGp0UhQFuo([System.Runtime.InteropServices.In] object obj0) => (object) CriteriaTransformer.Clone((ICriteria) obj0);

    internal static object v8JOEchztLerDJqawpcu([System.Runtime.InteropServices.In] object obj0) => (object) ((CriteriaImpl) obj0).Session;

    internal static object E1jCBshzwUvT0waQ0ODb([System.Runtime.InteropServices.In] object obj0) => (object) ((CriteriaImpl) obj0).EntityOrClassName;

    internal static object Y63teZhz4qgG6c88Ls9t([System.Runtime.InteropServices.In] object obj0) => (object) ((ISessionImplementor) obj0).Factory;

    internal static object YqlKQghz6qBoZVv81Es6([System.Runtime.InteropServices.In] object obj0, [System.Runtime.InteropServices.In] object obj1) => (object) ((ISessionFactoryImplementor) obj0).GetImplementors((string) obj1);

    internal static object dpnMZOhzHubTp2F4k3eB([System.Runtime.InteropServices.In] object obj0) => (object) ((JoinWalker) obj0).SqlString;

    internal static Guid P09xVBhzAAfR5gruTwDV([System.Runtime.InteropServices.In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static object SHgviJhz7meXBYdMdupW(Guid typeUid) => (object) NHibernateHelper.GetCriteriaTypeUidPropertyName(typeUid);

    internal static object eVJqqZhzxq0VvB3ULd1L(System.Type type) => (object) NHibernateHelper.GetCriteriaTypeUidPropertyName(type);

    internal static System.Type qSuMqbhz09eh2yc9CVU5([System.Runtime.InteropServices.In] RuntimeTypeHandle obj0) => System.Type.GetTypeFromHandle(obj0);

    internal static object ccqAcwhzmofdnbrySy5E(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void t2gIEShzyFYqZaOZKkbQ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
