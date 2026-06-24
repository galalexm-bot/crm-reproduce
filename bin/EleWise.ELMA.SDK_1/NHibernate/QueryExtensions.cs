// Decompiled with JetBrains decompiler
// Type: NHibernate.QueryExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using NHibernate.Cache;
using NHibernate.Engine;
using NHibernate.Impl;
using NHibernate.Stat;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace NHibernate
{
  public static class QueryExtensions
  {
    internal static QueryExtensions icow5EBYSieRB7jrr0D;

    /// <summary>
    /// Выполнить запрос обновления, а также очистить весь кэш NHibernate при необходимости
    /// </summary>
    /// <param name="query">Запрос</param>
    /// <param name="cleanUpCache">Нужно ли очищать весь кэш</param>
    public static int ExecuteUpdate(this IQuery query, bool cleanUpCache)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (query != null)
            {
              query.CleanUpCache = cleanUpCache;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 1 : 1;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return QueryExtensions.lwdmD7Bc5L1rvcCXBRY((object) query);
label_3:
      throw new ArgumentNullException((string) QueryExtensions.HZuN7nBs4Tyh6VjnHxF(-1939377524 ^ -1939375186));
    }

    /// <summary>Очистить весь кэш NHibernate при необходимости</summary>
    /// <param name="query">Запрос</param>
    /// <param name="cleanUpCache">Нужно ли очищать весь кэш</param>
    public static IQuery CleanUpCache(this IQuery query, bool cleanUpCache = true)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            query.CleanUpCache = cleanUpCache;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
            continue;
          case 3:
            if (query != null)
            {
              num = 2;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return query;
label_3:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(333888594 ^ 1075625116 ^ 1408895468));
    }

    /// <summary>Очистить кэш указанных типов сущностей</summary>
    /// <param name="session">Сессия NHibernate</param>
    /// <param name="affectedTypes">Типы сущностей, для которых нужно очистить кэш</param>
    public static void CleanUpCache(this ISession session, params Type[] affectedTypes)
    {
      int num1 = 2;
      while (true)
      {
        int num2 = num1;
        System.Action action;
        IUnitOfWorkManager serviceNotNull;
        List<Type>.Enumerator enumerator1;
        List<Type> types;
        ISession session1;
        List<string> collectionRoles;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_49;
            case 1:
              session1 = session;
              num2 = 15;
              continue;
            case 2:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 1 : 1;
              continue;
            case 3:
              goto label_52;
            case 4:
              types = ((IEnumerable<Type>) affectedTypes).Select<Type, Type>(new Func<Type, Type>(InterfaceActivator.TypeOf)).ToList<Type>();
              num2 = 6;
              continue;
            case 5:
              QueryExtensions.olwMJ0WWEOa78OwxfDR((object) action);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 7 : 6;
              continue;
            case 6:
              goto label_43;
            case 7:
              serviceNotNull = Locator.GetServiceNotNull<IUnitOfWorkManager>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 11 : 13;
              continue;
            case 8:
              goto label_40;
            case 9:
              if (affectedTypes.Length != 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 4 : 2;
                continue;
              }
              goto label_30;
            case 10:
              QueryExtensions.bb1is3WbymTkCS6Vjne((object) serviceNotNull, (object) action);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
              continue;
            case 11:
              enumerator1 = types.GetEnumerator();
              num2 = 12;
              continue;
            case 12:
              try
              {
label_12:
                if (enumerator1.MoveNext())
                  goto label_32;
                else
                  goto label_13;
label_8:
                Type current1;
                ISet<string> entityParticipant;
                IEnumerator<string> enumerator2;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_32;
                    case 2:
                      goto label_3;
                    case 3:
                      entityParticipant = ((ISessionFactoryImplementor) QueryExtensions.HIjpUZBzZTiOFAhEHBq((object) (ISessionImplementor) session1)).GetCollectionRolesByEntityParticipant(current1.FullName);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 0 : 0;
                      continue;
                    case 4:
                    case 5:
                      goto label_12;
                    case 6:
                      goto label_15;
                    case 7:
                      enumerator2 = entityParticipant.GetEnumerator();
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 2 : 6;
                      continue;
                    default:
                      if (entityParticipant == null)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 4 : 4;
                        continue;
                      }
                      goto case 7;
                  }
                }
label_15:
                try
                {
label_17:
                  if (QueryExtensions.triOxOWFC7PsjBGMwFX((object) enumerator2))
                    goto label_19;
                  else
                    goto label_18;
label_16:
                  string current2;
                  int num4;
                  while (true)
                  {
                    switch (num4)
                    {
                      case 1:
                        collectionRoles.Add(current2);
                        num4 = 3;
                        continue;
                      case 2:
                        goto label_12;
                      case 3:
                      case 5:
                        goto label_17;
                      case 4:
                        goto label_19;
                      default:
                        if (collectionRoles.Contains(current2))
                        {
                          num4 = 5;
                          continue;
                        }
                        goto case 1;
                    }
                  }
label_18:
                  num4 = 2;
                  goto label_16;
label_19:
                  current2 = enumerator2.Current;
                  num4 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
                  {
                    num4 = 0;
                    goto label_16;
                  }
                  else
                    goto label_16;
                }
                finally
                {
                  int num5;
                  if (enumerator2 == null)
                    num5 = 2;
                  else
                    goto label_28;
label_26:
                  switch (num5)
                  {
                    case 1:
                    case 2:
                  }
label_28:
                  QueryExtensions.m8XcWbWBbyggBcRFKq6((object) enumerator2);
                  num5 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0)
                  {
                    num5 = 1;
                    goto label_26;
                  }
                  else
                    goto label_26;
                }
label_13:
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 2 : 0;
                goto label_8;
label_32:
                current1 = enumerator1.Current;
                num3 = 3;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
                {
                  num3 = 3;
                  goto label_8;
                }
                else
                  goto label_8;
              }
              finally
              {
                enumerator1.Dispose();
                int num6 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
                  num6 = 0;
                switch (num6)
                {
                  default:
                }
              }
            case 13:
              if (QueryExtensions.N8utNWWoR2Pqrp6XNYb((object) serviceNotNull, (object) ""))
              {
                num2 = 10;
                continue;
              }
              goto label_38;
            case 14:
label_3:
              action = (System.Action) (() =>
              {
                int num7 = 2;
                List<string>.Enumerator enumerator3;
                while (true)
                {
                  List<Type>.Enumerator enumerator4;
                  switch (num7)
                  {
                    case 1:
                      try
                      {
label_6:
                        if (enumerator4.MoveNext())
                          goto label_14;
                        else
                          goto label_7;
label_5:
                        Type current;
                        IQueryCache queryCache;
                        int num8;
                        while (true)
                        {
                          switch (num8)
                          {
                            case 1:
                              if (queryCache != null)
                              {
                                num8 = 6;
                                continue;
                              }
                              goto label_6;
                            case 2:
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              if (QueryExtensions.\u003C\u003Ec__DisplayClass2_0.UwAY6uf4nXTkouRsrmhM(QueryExtensions.\u003C\u003Ec__DisplayClass2_0.NpXCwxf4kgx0T0ZusqnH((object) ((ISessionImplementor) session1).Factory, (object) current.FullName)))
                              {
                                num8 = 7;
                                continue;
                              }
                              goto label_6;
                            case 3:
                              goto label_14;
                            case 4:
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              queryCache = ((ISessionFactoryImplementor) QueryExtensions.\u003C\u003Ec__DisplayClass2_0.On2bp8f4OrmdoblrHK48((object) session1)).GetQueryCache((string) QueryExtensions.\u003C\u003Ec__DisplayClass2_0.OA9gmof42o6syTtayQPm((object) current.FullName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-542721635 ^ -542800409)));
                              num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 1 : 1;
                              continue;
                            case 5:
                              goto label_6;
                            case 6:
                              // ISSUE: reference to a compiler-generated method
                              QueryExtensions.\u003C\u003Ec__DisplayClass2_0.feHhpnf4eDBDXTKxXQYj((object) queryCache);
                              num8 = 5;
                              continue;
                            case 7:
                              session1.SessionFactory.Evict(current);
                              num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 1 : 4;
                              continue;
                            default:
                              goto label_2;
                          }
                        }
label_7:
                        num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
                        goto label_5;
label_14:
                        current = enumerator4.Current;
                        num8 = 2;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
                        {
                          num8 = 2;
                          goto label_5;
                        }
                        else
                          goto label_5;
                      }
                      finally
                      {
                        enumerator4.Dispose();
                        int num9 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
                          num9 = 0;
                        switch (num9)
                        {
                          default:
                        }
                      }
                    case 2:
                      enumerator4 = types.GetEnumerator();
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 1 : 0;
                      continue;
                    case 3:
                      goto label_21;
                    case 4:
                      goto label_34;
                  }
label_2:
                  enumerator3 = collectionRoles.GetEnumerator();
                  num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 3 : 2;
                }
label_34:
                return;
label_21:
                try
                {
label_24:
                  if (enumerator3.MoveNext())
                    goto label_26;
                  else
                    goto label_25;
label_22:
                  string current;
                  int num10;
                  while (true)
                  {
                    switch (num10)
                    {
                      case 1:
                        goto label_24;
                      case 2:
                        goto label_26;
                      case 3:
                        goto label_30;
                      case 4:
                        // ISSUE: reference to a compiler-generated method
                        ((ISessionFactory) QueryExtensions.\u003C\u003Ec__DisplayClass2_0.On2bp8f4OrmdoblrHK48((object) session1)).EvictCollection(current);
                        num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 1 : 0;
                        continue;
                      default:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        if (QueryExtensions.\u003C\u003Ec__DisplayClass2_0.WYXTEmf4117U0ewu8Q9D(QueryExtensions.\u003C\u003Ec__DisplayClass2_0.Sn45X6f4Pfc9onjqCnWq((object) ((ISessionImplementor) session1).Factory, (object) current)))
                        {
                          num10 = 4;
                          continue;
                        }
                        goto label_24;
                    }
                  }
label_30:
                  return;
label_25:
                  num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 3 : 3;
                  goto label_22;
label_26:
                  current = enumerator3.Current;
                  num10 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
                  {
                    num10 = 0;
                    goto label_22;
                  }
                  else
                    goto label_22;
                }
                finally
                {
                  enumerator3.Dispose();
                  int num11 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
                    num11 = 0;
                  switch (num11)
                  {
                    default:
                  }
                }
              });
              num2 = 5;
              continue;
            case 15:
              if (session1 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 1 : 3;
                continue;
              }
              if (affectedTypes != null)
              {
                num2 = 9;
                continue;
              }
              goto label_27;
            default:
              goto label_34;
          }
        }
label_43:
        collectionRoles = new List<string>();
        num1 = 11;
      }
label_49:
      return;
label_40:
      return;
label_34:
      return;
label_38:
      return;
label_30:
      return;
label_52:
      throw new ArgumentNullException((string) QueryExtensions.HZuN7nBs4Tyh6VjnHxF(-70007027 ^ -70005187));
label_27:;
    }

    /// <summary>Очистить кэш для указанной сущности</summary>
    /// <param name="session">Сессия NHibernate</param>
    /// <param name="entity">Сущность, для которой нужно очистить кэш</param>
    public static void CleanUpCache(this ISession session, IEntity entity)
    {
      int num1 = 9;
      while (true)
      {
        int num2 = num1;
        IUnitOfWorkManager serviceNotNull;
        System.Action action;
        ISession session1;
        Type type;
        object id;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_4;
            case 1:
              if (!QueryExtensions.N8utNWWoR2Pqrp6XNYb((object) serviceNotNull, (object) ""))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
                continue;
              }
              goto case 3;
            case 2:
              goto label_7;
            case 3:
              serviceNotNull.RegisterPostCommitAction(action);
              num2 = 7;
              continue;
            case 4:
              id = QueryExtensions.SHpVcmWGAGqWnSZBYgy((object) entity);
              num2 = 6;
              continue;
            case 5:
              goto label_16;
            case 6:
              action = (System.Action) (() =>
              {
                int num3 = 2;
                while (true)
                {
                  switch (num3)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      QueryExtensions.\u003C\u003Ec__DisplayClass3_0.SyH70af46w7RJAYlm8Ci(QueryExtensions.\u003C\u003Ec__DisplayClass3_0.YxImhPf44oHniSoU14IV((object) session1), type, id);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
                      continue;
                    case 2:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      if (QueryExtensions.\u003C\u003Ec__DisplayClass3_0.CmS5lAf4wGpTCgweoa8g(QueryExtensions.\u003C\u003Ec__DisplayClass3_0.LOIg2Wf4tx5v9hgNngTI(QueryExtensions.\u003C\u003Ec__DisplayClass3_0.W8UndFf4D0SoNpbdKsmi((object) (ISessionImplementor) session1), (object) type.FullName)))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 1;
                        continue;
                      }
                      goto label_6;
                    default:
                      goto label_7;
                  }
                }
label_2:
                return;
label_7:
                return;
label_6:;
              });
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 5 : 0;
              continue;
            case 7:
              goto label_3;
            case 8:
              session1 = session;
              num2 = 11;
              continue;
            case 9:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 4 : 8;
              continue;
            case 10:
              serviceNotNull = Locator.GetServiceNotNull<IUnitOfWorkManager>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 1 : 1;
              continue;
            case 11:
              if (entity != null)
              {
                type = QueryExtensions.s0JvZuWhKYttlPTurne(entity.CastAsRealType<IEntity>().GetType());
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 4 : 4;
                continue;
              }
              num2 = 2;
              continue;
            default:
              goto label_18;
          }
        }
label_16:
        QueryExtensions.olwMJ0WWEOa78OwxfDR((object) action);
        num1 = 10;
      }
label_4:
      return;
label_7:
      return;
label_3:
      return;
label_18:;
    }

    /// <summary>Очистить кэш для указанных коллекций</summary>
    /// <param name="session">Сессия NHibernate</param>
    /// <param name="collectionRoles">Список коллекций</param>
    public static void CleanUpCollectionsCache(
      this ISession session,
      params string[] collectionRoles)
    {
      int num1 = 13;
      System.Action action;
      IUnitOfWorkManager serviceNotNull;
      string[] collectionRoles1;
      ISession session1;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_18;
          case 1:
            QueryExtensions.olwMJ0WWEOa78OwxfDR((object) action);
            num1 = 5;
            continue;
          case 2:
            if (!QueryExtensions.N8utNWWoR2Pqrp6XNYb((object) serviceNotNull, (object) ""))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 11 : 9;
              continue;
            }
            goto case 4;
          case 3:
            if (collectionRoles1.Length != 0)
            {
              action = (System.Action) (() =>
              {
                int num2 = 6;
                while (true)
                {
                  int num3 = num2;
                  int index;
                  string[] strArray;
                  string role;
                  while (true)
                  {
                    switch (num3)
                    {
                      case 1:
                      case 7:
                        if (index < strArray.Length)
                        {
                          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 9 : 3;
                          continue;
                        }
                        goto label_9;
                      case 2:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        QueryExtensions.\u003C\u003Ec__DisplayClass4_0.z2UaVlf406KGEcFJOETU(QueryExtensions.\u003C\u003Ec__DisplayClass4_0.MWaZUPf4xwxCNPecq4r6((object) session1), (object) role);
                        num3 = 4;
                        continue;
                      case 3:
                        if (((ISessionImplementor) session1).Factory.GetCollectionPersister(role).HasCache)
                        {
                          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 2 : 2;
                          continue;
                        }
                        goto case 4;
                      case 4:
                        ++index;
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 1 : 0;
                        continue;
                      case 5:
                        index = 0;
                        num3 = 7;
                        continue;
                      case 6:
                        goto label_8;
                      case 8:
                        goto label_11;
                      default:
                        role = strArray[index];
                        num3 = 3;
                        continue;
                    }
                  }
label_8:
                  strArray = collectionRoles1;
                  num2 = 5;
                }
label_11:
                return;
label_9:;
              });
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 1;
              continue;
            }
            num1 = 8;
            continue;
          case 4:
            serviceNotNull.RegisterPostCommitAction(action);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
            continue;
          case 5:
            serviceNotNull = Locator.GetServiceNotNull<IUnitOfWorkManager>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 2 : 1;
            continue;
          case 6:
            if (collectionRoles1 == null)
            {
              num1 = 14;
              continue;
            }
            goto case 3;
          case 7:
            session1 = session;
            num1 = 10;
            continue;
          case 8:
            goto label_16;
          case 9:
            goto label_11;
          case 10:
            if (session1 != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 6 : 5;
              continue;
            }
            goto label_11;
          case 11:
            goto label_10;
          case 12:
            collectionRoles1 = collectionRoles;
            num1 = 7;
            continue;
          case 13:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 12 : 0;
            continue;
          case 14:
            goto label_2;
          default:
            goto label_5;
        }
      }
label_18:
      return;
label_16:
      return;
label_10:
      return;
label_2:
      return;
label_5:
      return;
label_11:
      throw new ArgumentNullException((string) QueryExtensions.HZuN7nBs4Tyh6VjnHxF(-488881205 ^ -488879365));
    }

    /// <summary>Установить сатистику для фабрики</summary>
    /// <param name="sessionFactory">Реализация фабрики сессий NHibernate</param>
    /// <param name="statistics">Реализация статистики для фабрики сессий NHibernate</param>
    public static void SetStatistics(
      this SessionFactoryImpl sessionFactory,
      StatisticsImpl statistics)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            QueryExtensions.kZ3fJRWEAYG4epbUAai((object) sessionFactory, (object) statistics);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    internal static object HZuN7nBs4Tyh6VjnHxF(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static int lwdmD7Bc5L1rvcCXBRY([In] object obj0) => ((IQuery) obj0).ExecuteUpdate();

    internal static bool JWEUDwBL5QuLAwVdcVK() => QueryExtensions.icow5EBYSieRB7jrr0D == null;

    internal static QueryExtensions p3pwjFBUFARfVNeBARX() => QueryExtensions.icow5EBYSieRB7jrr0D;

    internal static object HIjpUZBzZTiOFAhEHBq([In] object obj0) => (object) ((ISessionImplementor) obj0).Factory;

    internal static bool triOxOWFC7PsjBGMwFX([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void m8XcWbWBbyggBcRFKq6([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void olwMJ0WWEOa78OwxfDR([In] object obj0) => ((System.Action) obj0)();

    internal static bool N8utNWWoR2Pqrp6XNYb([In] object obj0, [In] object obj1) => ((IUnitOfWorkManager) obj0).HasActiveTransaction((string) obj1);

    internal static void bb1is3WbymTkCS6Vjne([In] object obj0, [In] object obj1) => ((IUnitOfWorkManager) obj0).RegisterPostCommitAction((System.Action) obj1);

    internal static Type s0JvZuWhKYttlPTurne(Type t) => InterfaceActivator.TypeOf(t);

    internal static object SHpVcmWGAGqWnSZBYgy([In] object obj0) => ((IIdentified) obj0).GetId();

    internal static void kZ3fJRWEAYG4epbUAai([In] object obj0, [In] object obj1) => ((SessionFactoryImpl) obj0).SetStatistics((StatisticsImpl) obj1);
  }
}
