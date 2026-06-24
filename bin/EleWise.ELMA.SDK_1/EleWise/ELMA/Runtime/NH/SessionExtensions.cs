// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.SessionExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Services;
using NHibernate;
using NHibernate.Engine;
using NHibernate.Persister.Entity;
using NHibernate.Proxy;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.NH
{
  public static class SessionExtensions
  {
    private static IRuntimeApplication runtimeApplication;
    internal static SessionExtensions rbcMxYWw3GC9BRxMn3Bx;

    /// <summary>Удалить сущность по идентификатору</summary>
    /// <param name="session">Сессия NHibernate</param>
    /// <param name="id">Идентификатор сущности</param>
    /// <typeparam name="TEntity">Тип сущности</typeparam>
    public static void Delete<TEntity>(this ISession session, object id) where TEntity : IEntity
    {
      Contract.ArgumentNotNull((object) session, z2jc63fLkugS1X8Q9N.tE1kD1vbB(92412609 - 1050237057 ^ -957822096));
      Contract.ArgumentNotNull(id, z2jc63fLkugS1X8Q9N.tE1kD1vbB(654297945 ^ 654243875));
      string tableName = ((EntityMetadata) MetadataLoader.LoadMetadata(typeof (TEntity))).TableName;
      session.Delete(id, tableName);
    }

    /// <summary>Удалить запись из таблицы по идентификатору</summary>
    /// <param name="session">Сессия NHibernate</param>
    /// <param name="id">Идентификатор записи</param>
    /// <param name="tableName">Название таблицы</param>
    public static void Delete(this ISession session, object id, string tableName)
    {
      int num = 6;
      string str;
      Dialect dialect;
      while (true)
      {
        switch (num)
        {
          case 1:
            dialect = ((ITransformationProvider) SessionExtensions.t5PFTVWw6AdjfZ4qc0Pb(SessionExtensions.pnS7LBWw4kRI0s59xvY9())).Dialect;
            num = 2;
            continue;
          case 2:
            str = (string) SessionExtensions.iXx7k5WwDxpwNIikuyXL(516838154 ^ 516947160) + (string) SessionExtensions.SrRq11WwHu2HjuJhNq87((object) dialect, (object) tableName) + (string) SessionExtensions.iXx7k5WwDxpwNIikuyXL(1514961705 ^ 1515018111) + (string) SessionExtensions.SrRq11WwHu2HjuJhNq87((object) dialect, SessionExtensions.iXx7k5WwDxpwNIikuyXL(1994213607 >> 4 ^ 124605904)) + (string) SessionExtensions.iXx7k5WwDxpwNIikuyXL(1218962250 ^ 1218822780);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 4 : 3;
            continue;
          case 3:
            goto label_2;
          case 4:
            ((IQuery) SessionExtensions.SqSwjAWw7Rh2n6OeqUjc(SessionExtensions.iowPdpWwAKodldlhLj8l((object) session, (object) str), SessionExtensions.iXx7k5WwDxpwNIikuyXL(1304605005 ^ 1304658487), id)).ExecuteUpdate();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 1 : 3;
            continue;
          case 5:
            SessionExtensions.HcSIOqWwwYT1PE5gnnlY((object) tableName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1654249598 >> 2 ^ 413646525));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
            continue;
          case 6:
            SessionExtensions.nUPYSsWwtTyrEbmtZBMB((object) session, SessionExtensions.iXx7k5WwDxpwNIikuyXL(964881585 - -1459193222 ^ -1870890233));
            num = 5;
            continue;
          default:
            SessionExtensions.nUPYSsWwtTyrEbmtZBMB(id, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 1418370544));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 1 : 0;
            continue;
        }
      }
label_2:;
    }

    public static bool IsDirtyEntity(this ISession session, object entity)
    {
      int num = 12;
      ISessionImplementor sessionImplementor;
      object obj;
      EntityEntry entityEntry;
      INHibernateProxy nhibernateProxy;
      int[] numArray;
      string entityName;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (((ILazyInitializer) SessionExtensions.LJWjRNWwySBbBDe49hra((object) nhibernateProxy)).IsUninitialized)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 1 : 1;
              continue;
            }
            obj = SessionExtensions.DjTjZnWwJwV1ulN2sssL(SessionExtensions.l3ohuuWwM75bcmU3NL2j((object) sessionImplementor), (object) nhibernateProxy);
            num = 7;
            continue;
          case 3:
            goto label_15;
          case 4:
            if (numArray != null)
            {
              num = 3;
              continue;
            }
            goto label_16;
          case 5:
            IEntityPersister entityPersister = ((ISessionFactoryImplementor) SessionExtensions.IQRVCEWw96ES3BianepS((object) sessionImplementor)).GetEntityPersister(entityName);
            object[] objArray = (object[]) SessionExtensions.v6EMecWwdVn2m2eqmpUG((object) entityEntry);
            numArray = (int[]) SessionExtensions.AY5Ro3Wwl5doR5OnLp1j((object) entityPersister, (object) entityPersister.GetPropertyValues(entity), (object) objArray, entity, (object) sessionImplementor);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 4 : 3;
            continue;
          case 6:
            goto label_17;
          case 7:
            entityEntry = (EntityEntry) SessionExtensions.PiWfEoWw0JZYrefGKAYS((object) sessionImplementor.PersistenceContext, obj);
            num = 9;
            continue;
          case 8:
          case 9:
            if (entityEntry == null)
            {
              num = 6;
              continue;
            }
            entityName = entityEntry.EntityName;
            num = 5;
            continue;
          case 10:
            if (entityEntry == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 0 : 0;
              continue;
            }
            goto case 8;
          case 11:
            entityEntry = (EntityEntry) SessionExtensions.PiWfEoWw0JZYrefGKAYS((object) sessionImplementor.PersistenceContext, entity);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 5 : 10;
            continue;
          case 12:
            sessionImplementor = (ISessionImplementor) SessionExtensions.LCS7tPWwxrukUbCLtfyb((object) session);
            num = 11;
            continue;
          case 13:
            nhibernateProxy = entity as INHibernateProxy;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 2 : 2;
            continue;
          default:
            if (!SessionExtensions.Wdh6h3WwmbbfVOlsZesg(entity))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 6 : 8;
              continue;
            }
            goto case 13;
        }
      }
label_5:
      return false;
label_15:
      return numArray.Length != 0;
label_16:
      return false;
label_17:
      return false;
    }

    public static bool IsDirtyEntity(
      this ISession session,
      IEntityPersister persister,
      object[] oldState,
      object[] currentState,
      object entity)
    {
      int num = 1;
      ISessionImplementor sessionImplementor;
      int[] numArray;
      while (true)
      {
        switch (num)
        {
          case 1:
            sessionImplementor = (ISessionImplementor) SessionExtensions.LCS7tPWwxrukUbCLtfyb((object) session);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_5;
          case 3:
            if (numArray == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 2 : 2;
              continue;
            }
            goto label_4;
          case 4:
            goto label_4;
          default:
            numArray = (int[]) SessionExtensions.AY5Ro3Wwl5doR5OnLp1j((object) persister, (object) currentState, (object) oldState, entity, (object) sessionImplementor);
            num = 3;
            continue;
        }
      }
label_4:
      return numArray.Length != 0;
label_5:
      return false;
    }

    public static bool IsDirtyProperty(this ISession session, object entity, string propertyName)
    {
      int num1 = 1;
      int[] array;
      int num2;
      while (true)
      {
        int num3 = num1;
        ISessionImplementor sessionImplementation;
        string str;
        EntityEntry entityEntry;
        INHibernateProxy nhibernateProxy;
        object obj1;
        while (true)
        {
          switch (num3)
          {
            case 1:
              sessionImplementation = session.GetSessionImplementation();
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
              continue;
            case 2:
              if (SessionExtensions.FBhrynWwrGh4pf9On01F(SessionExtensions.LJWjRNWwySBbBDe49hra((object) nhibernateProxy)))
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 1 : 6;
                continue;
              }
              obj1 = SessionExtensions.DjTjZnWwJwV1ulN2sssL(SessionExtensions.l3ohuuWwM75bcmU3NL2j((object) sessionImplementation), (object) nhibernateProxy);
              num3 = 8;
              continue;
            case 3:
              goto label_3;
            case 4:
              goto label_7;
            case 5:
              nhibernateProxy = entity as INHibernateProxy;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 2 : 2;
              continue;
            case 6:
              goto label_19;
            case 7:
              if (array != null)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 8 : 10;
                continue;
              }
              goto label_14;
            case 8:
              entityEntry = (EntityEntry) SessionExtensions.PiWfEoWw0JZYrefGKAYS(SessionExtensions.l3ohuuWwM75bcmU3NL2j((object) sessionImplementation), obj1);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 12 : 5;
              continue;
            case 9:
              if (entity.IsProxy())
              {
                num3 = 5;
                continue;
              }
              goto case 12;
            case 10:
              goto label_13;
            case 11:
              if (entityEntry == null)
              {
                num3 = 9;
                continue;
              }
              goto case 12;
            case 12:
              if (entityEntry != null)
              {
                str = (string) SessionExtensions.F0XmqhWwg20l9BFDQPft((object) entityEntry);
                num3 = 3;
                continue;
              }
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 2 : 4;
              continue;
            default:
              entityEntry = ((IPersistenceContext) SessionExtensions.l3ohuuWwM75bcmU3NL2j((object) sessionImplementation)).GetEntry(entity);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 4 : 11;
              continue;
          }
        }
label_3:
        object obj2 = SessionExtensions.tnx18eWw5B7qLKW9ikqv(SessionExtensions.IQRVCEWw96ES3BianepS((object) sessionImplementation), (object) str);
        object[] objArray = (object[]) SessionExtensions.v6EMecWwdVn2m2eqmpUG((object) entityEntry);
        array = (int[]) SessionExtensions.AY5Ro3Wwl5doR5OnLp1j(obj2, (object) ((IEntityPersister) obj2).GetPropertyValues(entity), (object) objArray, entity, (object) sessionImplementation);
        num2 = Array.IndexOf<string>((string[]) SessionExtensions.RQf7tEWwj2TtOdQWmwQv(obj2), propertyName);
        num1 = 7;
      }
label_7:
      return false;
label_13:
      return Array.IndexOf<int>(array, num2) != -1;
label_14:
      return false;
label_19:
      return false;
    }

    public static object GetOriginalEntityProperty(
      this ISession session,
      object entity,
      string propertyName)
    {
      int num1 = 7;
      object[] propertyValues;
      int index;
      object[] objArray;
      while (true)
      {
        int num2 = num1;
        EntityEntry entityEntry;
        ISessionImplementor sessionImplementor;
        object entity1;
        while (true)
        {
          INHibernateProxy nhibernateProxy;
          int[] array;
          string entityName;
          int num3;
          switch (num2)
          {
            case 1:
              if (entityEntry == null)
              {
                num2 = 5;
                continue;
              }
              goto case 12;
            case 2:
              num3 = Array.IndexOf<int>(array, index) != -1 ? 1 : 0;
              break;
            case 3:
              goto label_14;
            case 4:
              goto label_19;
            case 5:
              if (entity.IsProxy())
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
                continue;
              }
              goto case 12;
            case 6:
              entityEntry = (EntityEntry) SessionExtensions.PiWfEoWw0JZYrefGKAYS(SessionExtensions.l3ohuuWwM75bcmU3NL2j((object) sessionImplementor), entity);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 1;
              continue;
            case 7:
              sessionImplementor = (ISessionImplementor) SessionExtensions.LCS7tPWwxrukUbCLtfyb((object) session);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 6 : 4;
              continue;
            case 8:
              if (SessionExtensions.FBhrynWwrGh4pf9On01F(SessionExtensions.LJWjRNWwySBbBDe49hra((object) nhibernateProxy)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 10 : 6;
                continue;
              }
              entity1 = SessionExtensions.DjTjZnWwJwV1ulN2sssL(SessionExtensions.l3ohuuWwM75bcmU3NL2j((object) sessionImplementor), (object) nhibernateProxy);
              num2 = 3;
              continue;
            case 9:
              entityName = (string) SessionExtensions.F0XmqhWwg20l9BFDQPft((object) entityEntry);
              num2 = 11;
              continue;
            case 10:
              goto label_17;
            case 11:
              IEntityPersister entityPersister = ((ISessionFactoryImplementor) SessionExtensions.IQRVCEWw96ES3BianepS((object) sessionImplementor)).GetEntityPersister(entityName);
              objArray = (object[]) SessionExtensions.v6EMecWwdVn2m2eqmpUG((object) entityEntry);
              propertyValues = entityPersister.GetPropertyValues(entity);
              array = (int[]) SessionExtensions.AY5Ro3Wwl5doR5OnLp1j((object) entityPersister, (object) propertyValues, (object) objArray, entity, (object) sessionImplementor);
              index = Array.IndexOf<string>((string[]) SessionExtensions.RQf7tEWwj2TtOdQWmwQv((object) entityPersister), propertyName);
              num2 = 13;
              continue;
            case 12:
              if (entityEntry != null)
              {
                num2 = 9;
                continue;
              }
              goto label_15;
            case 13:
              if (array != null)
              {
                num2 = 2;
                continue;
              }
              num3 = 0;
              break;
            case 14:
              goto label_15;
            default:
              nhibernateProxy = entity as INHibernateProxy;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 1 : 8;
              continue;
          }
          if (num3 == 0)
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 3 : 4;
          else
            goto label_20;
        }
label_14:
        entityEntry = ((IPersistenceContext) SessionExtensions.l3ohuuWwM75bcmU3NL2j((object) sessionImplementor)).GetEntry(entity1);
        num1 = 12;
      }
label_15:
      return entity.GetPropertyValue(propertyName, (object) null);
label_17:
      return entity.GetPropertyValue(propertyName, (object) null);
label_19:
      return propertyValues[index];
label_20:
      return objArray[index];
    }

    public static object GetOriginalEntity(this ISession session, object entity)
    {
      int num1 = 10;
      object originalEntity;
      while (true)
      {
        int num2 = num1;
        EntityEntry entityEntry;
        object[] objArray;
        IEntityPersister entityPersister;
        INHibernateProxy nhibernateProxy;
        IPersistenceContext persistenceContext;
        object obj;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_13;
            case 2:
              goto label_17;
            case 3:
              entityPersister = (IEntityPersister) SessionExtensions.GdhKZeWwYmRon9C16Ae2((object) session, entity);
              num2 = 7;
              continue;
            case 4:
              goto label_27;
            case 5:
              goto label_23;
            case 6:
              originalEntity = SessionExtensions.uwZptiWwUBKttXQrhwa5(entity.GetType());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 1 : 14;
              continue;
            case 7:
              if (SessionExtensions.IYSJwOWwLxOwS66nONo2((object) entityPersister, entity))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 1 : 1;
                continue;
              }
              goto label_14;
            case 8:
              if (entityEntry != null)
              {
                num2 = 11;
                continue;
              }
              goto default;
            case 9:
              persistenceContext = (IPersistenceContext) SessionExtensions.l3ohuuWwM75bcmU3NL2j(SessionExtensions.LCS7tPWwxrukUbCLtfyb((object) session));
              num2 = 3;
              continue;
            case 10:
              goto label_19;
            case 11:
            case 18:
            case 19:
              if (entityEntry != null)
              {
                objArray = (object[]) SessionExtensions.v6EMecWwdVn2m2eqmpUG((object) entityEntry);
                num2 = 6;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 16 : 13;
              continue;
            case 12:
              entityEntry = (EntityEntry) SessionExtensions.PiWfEoWw0JZYrefGKAYS((object) persistenceContext, obj);
              num2 = 18;
              continue;
            case 13:
              nhibernateProxy = entity as INHibernateProxy;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 17 : 15;
              continue;
            case 14:
              SessionExtensions.EqJX4oWwsLlhdM0epWx2((object) entityPersister, originalEntity, (object) objArray);
              num2 = 2;
              continue;
            case 15:
              obj = SessionExtensions.DjTjZnWwJwV1ulN2sssL((object) persistenceContext, (object) nhibernateProxy);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 11 : 12;
              continue;
            case 16:
              goto label_6;
            case 17:
              goto label_9;
            default:
              if (!SessionExtensions.Wdh6h3WwmbbfVOlsZesg(entity))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 14 : 19;
                continue;
              }
              goto case 13;
          }
        }
label_9:
        if (!SessionExtensions.FBhrynWwrGh4pf9On01F(SessionExtensions.LJWjRNWwySBbBDe49hra((object) nhibernateProxy)))
        {
          num1 = 15;
          continue;
        }
        goto label_27;
label_14:
        entityEntry = (EntityEntry) SessionExtensions.PiWfEoWw0JZYrefGKAYS((object) persistenceContext, entity);
        num1 = 8;
        continue;
label_19:
        if (entity != null)
          num1 = 9;
        else
          goto label_23;
      }
label_6:
      return entity;
label_13:
      return entity;
label_17:
      return originalEntity;
label_23:
      return (object) null;
label_27:
      return entity;
    }

    /// <summary>Среда исполнения приложения</summary>
    private static IRuntimeApplication RuntimeApplication
    {
      get
      {
        int num = 1;
        IRuntimeApplication runtimeApplication;
        while (true)
        {
          switch (num)
          {
            case 1:
              runtimeApplication = SessionExtensions.runtimeApplication;
              if (runtimeApplication == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_5;
          }
        }
label_2:
        return runtimeApplication;
label_5:
        return SessionExtensions.runtimeApplication = Locator.GetService<IRuntimeApplication>();
      }
    }

    internal static object iXx7k5WwDxpwNIikuyXL(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void nUPYSsWwtTyrEbmtZBMB([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static void HcSIOqWwwYT1PE5gnnlY([In] object obj0, [In] object obj1) => Contract.ArgumentNotNullOrEmpty((string) obj0, (string) obj1);

    internal static object pnS7LBWw4kRI0s59xvY9() => (object) SessionExtensions.RuntimeApplication;

    internal static object t5PFTVWw6AdjfZ4qc0Pb([In] object obj0) => (object) ((IRuntimeApplication) obj0).TransformationProvider;

    internal static object SrRq11WwHu2HjuJhNq87([In] object obj0, [In] object obj1) => (object) ((Dialect) obj0).QuoteIfNeeded((string) obj1);

    internal static object iowPdpWwAKodldlhLj8l([In] object obj0, [In] object obj1) => (object) ((ISession) obj0).CreateSQLQuery((string) obj1);

    internal static object SqSwjAWw7Rh2n6OeqUjc([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((IQuery) obj0).SetParameter((string) obj1, obj2);

    internal static bool jiSfyNWwpxAR7iL43sWZ() => SessionExtensions.rbcMxYWw3GC9BRxMn3Bx == null;

    internal static SessionExtensions YitjVPWwa72Eao643rFr() => SessionExtensions.rbcMxYWw3GC9BRxMn3Bx;

    internal static object LCS7tPWwxrukUbCLtfyb([In] object obj0) => (object) ((ISession) obj0).GetSessionImplementation();

    internal static object PiWfEoWw0JZYrefGKAYS([In] object obj0, [In] object obj1) => (object) ((IPersistenceContext) obj0).GetEntry(obj1);

    internal static bool Wdh6h3WwmbbfVOlsZesg([In] object obj0) => obj0.IsProxy();

    internal static object LJWjRNWwySBbBDe49hra([In] object obj0) => (object) ((INHibernateProxy) obj0).HibernateLazyInitializer;

    internal static object l3ohuuWwM75bcmU3NL2j([In] object obj0) => (object) ((ISessionImplementor) obj0).PersistenceContext;

    internal static object DjTjZnWwJwV1ulN2sssL([In] object obj0, [In] object obj1) => ((IPersistenceContext) obj0).Unproxy(obj1);

    internal static object IQRVCEWw96ES3BianepS([In] object obj0) => (object) ((ISessionImplementor) obj0).Factory;

    internal static object v6EMecWwdVn2m2eqmpUG([In] object obj0) => (object) ((EntityEntry) obj0).LoadedState;

    internal static object AY5Ro3Wwl5doR5OnLp1j(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3,
      [In] object obj4)
    {
      return (object) ((IEntityPersister) obj0).FindDirty((object[]) obj1, (object[]) obj2, obj3, (ISessionImplementor) obj4);
    }

    internal static bool FBhrynWwrGh4pf9On01F([In] object obj0) => ((ILazyInitializer) obj0).IsUninitialized;

    internal static object F0XmqhWwg20l9BFDQPft([In] object obj0) => (object) ((EntityEntry) obj0).EntityName;

    internal static object tnx18eWw5B7qLKW9ikqv([In] object obj0, [In] object obj1) => (object) ((ISessionFactoryImplementor) obj0).GetEntityPersister((string) obj1);

    internal static object RQf7tEWwj2TtOdQWmwQv([In] object obj0) => (object) ((IEntityPersister) obj0).PropertyNames;

    internal static object GdhKZeWwYmRon9C16Ae2([In] object obj0, [In] object obj1) => (object) ((ISession) obj0).GetEntityPersister(obj1);

    internal static bool IYSJwOWwLxOwS66nONo2([In] object obj0, [In] object obj1) => ((IEntityPersister) obj0).HasUninitializedLazyProperties(obj1);

    internal static object uwZptiWwUBKttXQrhwa5(Type t) => InterfaceActivator.Create(t);

    internal static void EqJX4oWwsLlhdM0epWx2([In] object obj0, [In] object obj1, [In] object obj2) => ((IEntityPersister) obj0).SetPropertyValues(obj1, (object[]) obj2);
  }
}
