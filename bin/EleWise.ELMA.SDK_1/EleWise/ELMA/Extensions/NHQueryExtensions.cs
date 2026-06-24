// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.NHQueryExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Exceptions;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using NHibernate.Impl;
using NHibernate.SqlCommand;
using NHibernate.Type;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;

namespace EleWise.ELMA.Extensions
{
  /// <summary>Расширения для запросов в NHibernate</summary>
  public static class NHQueryExtensions
  {
    internal static NHQueryExtensions DOM0oqG6yNSigv2j4stt;

    /// <summary>Получить именованный подзапрос</summary>
    /// <param name="session">Сессия NHibernate</param>
    /// <param name="name">Имя подзапроса</param>
    /// <returns></returns>
    public static SqlSubQuery GetNamedSubQuery(this ISession session, string name)
    {
      int num = 1;
      SqlQueryImpl namedQuery;
      while (true)
      {
        switch (num)
        {
          case 1:
            namedQuery = (SqlQueryImpl) session.GetNamedQuery(name);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_5;
          default:
            if (namedQuery == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 2 : 2;
              continue;
            }
            goto label_6;
        }
      }
label_5:
      throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978215776), (object) name));
label_6:
      return new SqlSubQuery(namedQuery, session);
    }

    /// <summary>Создать SQL-подзапрос</summary>
    /// <param name="session">Сессия NHibernate</param>
    /// <param name="queryString">Текст SQL-подзапроса</param>
    /// <returns></returns>
    public static SqlSubQuery CreateSQLSubQuery(this ISession session, string queryString) => new SqlSubQuery(queryString, session);

    /// <summary>Кастомный SQL код с учетом псевдонимов наследников</summary>
    /// <param name="sql"></param>
    /// <param name="values"></param>
    /// <param name="types"></param>
    /// <returns></returns>
    public static AbstractCriterion Sql(SqlString sql, object[] values, IType[] types) => (AbstractCriterion) new AliasesSQLCriterion(sql, values, types);

    /// <summary>Кастомный SQL код с учетом псевдонимов наследников</summary>
    /// <param name="sql"></param>
    /// <returns></returns>
    public static AbstractCriterion Sql(SqlString sql) => NHQueryExtensions.Sql(sql, new object[0], new IType[0]);

    /// <summary>Кастомный SQL код с учетом псевдонимов наследников</summary>
    /// <param name="sql"></param>
    /// <param name="values"></param>
    /// <param name="types"></param>
    /// <returns></returns>
    public static AbstractCriterion Sql(string sql, object[] values, IType[] types) => (AbstractCriterion) NHQueryExtensions.pWnsh2G69Qj1ebgwFhaR((object) SqlString.Parse(sql), (object) values, (object) types);

    /// <summary>Кастомный SQL код с учетом псевдонимов наследников</summary>
    /// <param name="sql"></param>
    /// <returns></returns>
    public static AbstractCriterion Sql(string sql) => (AbstractCriterion) NHQueryExtensions.IXWhu1G6dE4BEZwYalsf((object) sql, (object) new object[0], (object) new IType[0]);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="fullentityName"></param>
    /// <param name="propertyName"></param>
    /// <returns></returns>
    public static CustomPropertyProjection PropertyProjection(
      System.Type rootType,
      string fullentityName,
      string propertyName,
      bool forOrder,
      out string realProperty,
      out EntityMetadata realMetadata,
      out EntityPropertyMetadata realPropertyMetadata)
    {
      int num = 1;
      Tuple<CustomPropertyProjection, string, EntityMetadata, EntityPropertyMetadata> orAdd;
      System.Type rootType1;
      string fullentityName1;
      string propertyName1;
      bool forOrder1;
      while (true)
      {
        switch (num)
        {
          case 1:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 0;
            continue;
          case 2:
            realPropertyMetadata = orAdd.Item4;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 3 : 3;
            continue;
          case 3:
            goto label_13;
          case 4:
            realMetadata = orAdd.Item3;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 2 : 2;
            continue;
          case 5:
            forOrder1 = forOrder;
            num = 10;
            continue;
          case 6:
            realProperty = orAdd.Item2;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 4 : 4;
            continue;
          case 7:
            fullentityName1 = fullentityName;
            num = 8;
            continue;
          case 8:
            propertyName1 = propertyName;
            num = 5;
            continue;
          case 9:
            goto label_9;
          case 10:
            if (!NHQueryExtensions.LQ41AWG6lViUjC4k8CHB(rootType1, (System.Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 11 : 2;
              continue;
            }
            goto label_9;
          case 11:
            string realProperty1;
            EntityMetadata realMetadata1;
            EntityPropertyMetadata realPropertyMetadata1;
            orAdd = ContextVars.GetOrAdd<Tuple<CustomPropertyProjection, string, EntityMetadata, EntityPropertyMetadata>>((string) NHQueryExtensions.qKx8cWG6g54BmXDgLpPJ((object) new string[7]
            {
              (string) NHQueryExtensions.U1f6FgG6r4S6dhxM9Prd(1925118608 << 2 ^ -889198354),
              rootType1.AssemblyQualifiedName,
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-122002947 ^ 122014430),
              fullentityName1,
              propertyName1,
              (string) NHQueryExtensions.U1f6FgG6r4S6dhxM9Prd(92412609 - 1050237057 ^ -957835620),
              forOrder1.ToString()
            }), (Func<Tuple<CustomPropertyProjection, string, EntityMetadata, EntityPropertyMetadata>>) (() => new Tuple<CustomPropertyProjection, string, EntityMetadata, EntityPropertyMetadata>(NHQueryExtensions.PropertyProjectionNonCache(rootType1, (object) fullentityName1, (object) propertyName1, forOrder1, out realProperty1, out realMetadata1, out realPropertyMetadata1), realProperty1, realMetadata1, realPropertyMetadata1)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 6 : 6;
            continue;
          default:
            rootType1 = rootType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 7 : 7;
            continue;
        }
      }
label_9:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1581325282 << 3 ^ -234037878));
label_13:
      return orAdd.Item1;
    }

    /// <summary>
    /// Выполнить операции с указанным максимальным временем выполнения SQL-запросов
    /// </summary>
    /// <param name="timeout">Ограничение по времени (в секундах)</param>
    /// <param name="action"></param>
    public static void ExecuteWithTimeout(this ISession session, int timeout, System.Action action)
    {
      int num1 = 1;
      int? timeout1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            timeout1 = CustomBatcher.SetCurrentContextTimeout(new int?(timeout));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_13;
          default:
            goto label_2;
        }
      }
label_13:
      return;
label_2:
      try
      {
        int num2;
        if (action == null)
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 2 : 1;
        else
          goto label_7;
label_5:
        switch (num2)
        {
          case 1:
            return;
          case 2:
            return;
        }
label_7:
        action();
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
        {
          num2 = 1;
          goto label_5;
        }
        else
          goto label_5;
      }
      finally
      {
        CustomBatcher.SetCurrentContextTimeout(timeout1);
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
    }

    /// <summary>
    /// Выполнить блокировку сущности с ожиданием в течение ограничения времени на исполнение команд
    /// </summary>
    /// <param name="session"></param>
    /// <param name="obj"></param>
    /// <returns></returns>
    public static void LockWithWait(this ISession session, object obj)
    {
      int num1 = 17;
      while (true)
      {
        int num2 = num1;
        DateTime dateTime1;
        int? nullable1;
        DateTime dateTime2;
        while (true)
        {
          int? nullable2;
          int num3;
          IRuntimeApplication runtimeApplication1;
          int num4;
          IRuntimeApplication runtimeApplication2;
          int? nullable3;
          switch (num2)
          {
            case 1:
              if (nullable2.Value <= 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
                continue;
              }
              num4 = nullable2.Value;
              goto label_47;
            case 2:
              goto label_8;
            case 3:
              dateTime2 = dateTime1.AddSeconds((double) num3);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 11 : 2;
              continue;
            case 5:
              if (!NHQueryExtensions.rCn7nOG65RgJ0qdFVdxE())
                goto case 13;
              else
                goto label_13;
            case 6:
              goto label_10;
            case 7:
              if (!nullable2.HasValue)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 3 : 4;
                continue;
              }
              goto case 1;
            case 8:
              goto label_41;
            case 9:
              goto label_11;
            case 10:
              nullable3 = nullable1;
              goto label_45;
            case 11:
              goto label_33;
            case 12:
              goto label_14;
            case 13:
              runtimeApplication2 = (IRuntimeApplication) null;
              break;
            case 14:
              runtimeApplication2 = Locator.GetService<IRuntimeApplication>();
              break;
            case 15:
              if (runtimeApplication1 != null)
              {
                nullable3 = runtimeApplication1.GetCommandTimeout();
                goto label_45;
              }
              else
                goto label_38;
            case 16:
              goto label_34;
            case 17:
              if (session == null)
              {
                num2 = 16;
                continue;
              }
              if (obj != null)
              {
                num2 = 5;
                continue;
              }
              goto label_11;
            default:
              num4 = 30;
              goto label_47;
          }
          runtimeApplication1 = runtimeApplication2;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 4 : 15;
          continue;
label_45:
          nullable2 = nullable3;
          num2 = 7;
          continue;
label_47:
          num3 = num4;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 1 : 2;
        }
label_8:
        dateTime1 = NHQueryExtensions.eUrvZNG6jcn2KiLyU46x();
        num1 = 3;
        continue;
label_10:
        nullable1 = new int?();
        num1 = 10;
        continue;
label_13:
        num1 = 14;
        continue;
label_14:
        try
        {
          session.Lock(obj, LockMode.Upgrade);
          int num5 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
            num5 = 0;
          switch (num5)
          {
            case 0:
              return;
            default:
              return;
          }
        }
        catch (GenericADOException ex)
        {
          int num6 = 6;
          object obj1;
          while (true)
          {
            IEntity entity;
            object obj2;
            switch (num6)
            {
              case 1:
                NHQueryExtensions.qa6ZZZG6U1u3esJ9tRFB(1000);
                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 5 : 4;
                continue;
              case 2:
                obj2 = (object) null;
                break;
              case 3:
                goto label_27;
              case 4:
                entity = obj as IEntity;
                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
                continue;
              case 5:
                goto label_33;
              case 6:
                if (!NHQueryExtensions.UQR7NUG6YqwRbTH1hMtm(DateTime.Now, dateTime2))
                {
                  num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 1 : 0;
                  continue;
                }
                goto case 4;
              default:
                if (entity == null)
                {
                  num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 2;
                  continue;
                }
                obj2 = NHQueryExtensions.LoJCUSG6LdBC9ocyUMvL((object) entity);
                break;
            }
            obj1 = obj2;
            num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 3;
          }
label_27:
          throw new ObtainObjectLockException(obj.GetType().FullName, obj1 == null ? (object) obj.ToString() : obj1);
        }
label_33:
        num1 = 12;
        continue;
label_38:
        num1 = 6;
      }
label_41:
      return;
label_11:
      throw new ArgumentNullException((string) NHQueryExtensions.U1f6FgG6r4S6dhxM9Prd(1199946765 ^ 1199906693));
label_34:
      throw new ArgumentNullException((string) NHQueryExtensions.U1f6FgG6r4S6dhxM9Prd(-1978478350 ^ -1978476094));
    }

    /// <summary>
    /// Выполнить блокировку сущности с ожиданием в течение указанного времени
    /// </summary>
    /// <param name="session"></param>
    /// <param name="obj"></param>
    /// <param name="timeout">Ограничение по времени (в секундах)</param>
    /// <returns></returns>
    public static void LockWithWait(this ISession session, object obj, int timeout)
    {
      int num1 = 2;
      ISession session1;
      object obj1;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_2;
          case 1:
            session1 = session;
            num1 = 4;
            continue;
          case 2:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 1 : 1;
            continue;
          case 3:
            session1.ExecuteWithTimeout(timeout, (System.Action) (() =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    session1.LockWithWait(obj1);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 0;
            continue;
          case 4:
            obj1 = obj;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 3 : 3;
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
    /// Загрузить сущность и выполнить ее блокировку с ожиданием в течение ограничения времени на исполнение команд
    /// </summary>
    /// <param name="session"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    public static object LoadAndLockWithWait<T>(this ISession session, object id)
    {
      int? commandTimeout = (int?) (Locator.Initialized ? Locator.GetService<IRuntimeApplication>() : (IRuntimeApplication) null)?.GetCommandTimeout();
      DateTime dateTime = DateTime.Now.AddSeconds(!commandTimeout.HasValue || commandTimeout.Value <= 0 ? 30.0 : (double) commandTimeout.Value);
      while (true)
      {
        try
        {
          return (object) session.Load<T>(id, LockMode.Upgrade);
        }
        catch (GenericADOException ex)
        {
          Logger.Log.Log(EleWise.ELMA.Logging.LogLevel.Debug, (Exception) ex, string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1505778440 - 1981636111 ^ -475594793), (object) dateTime));
          if (DateTime.Now > dateTime)
            throw new ObtainObjectLockException(typeof (T).FullName, id);
          Thread.Sleep(1000);
        }
      }
    }

    private static CustomPropertyProjection PropertyProjectionNonCache(
      System.Type rootType,
      object fullentityName,
      object propertyName,
      bool forOrder,
      out string realProperty,
      out EntityMetadata realMetadata,
      out EntityPropertyMetadata realPropertyMetadata)
    {
      int num1 = 18;
      EntityMetadata entityMetadata1;
      PropertyMetadata propertyMetadata1;
      EntityPropertyMetadata propertyMetadata2;
      string propertyName2;
      string fullentityName1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          EntityMetadata entityMetadata2;
          object obj;
          PropertySettings settings;
          EntityMetadata rootMetadata;
          string propertyName1;
          switch (num2)
          {
            case 1:
              propertyName1 = (string) propertyName;
              num2 = 29;
              continue;
            case 2:
              goto label_35;
            case 3:
              goto label_15;
            case 4:
              goto label_37;
            case 5:
              // ISSUE: reference to a compiler-generated method
              propertyMetadata1 = entityMetadata2.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => p.Uid == NHQueryExtensions.\u003C\u003Ec__DisplayClass11_1.kqZ3Fv8GZxQ0k3QY6oEN((object) settings)));
              num2 = 27;
              continue;
            case 6:
              goto label_38;
            case 7:
              realPropertyMetadata = propertyMetadata2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 16 : 14;
              continue;
            case 8:
              goto label_26;
            case 9:
              realMetadata = (EntityMetadata) null;
              num2 = 22;
              continue;
            case 10:
              settings = propertyMetadata2.Settings as PropertySettings;
              num2 = 20;
              continue;
            case 11:
              realPropertyMetadata = (EntityPropertyMetadata) null;
              num2 = 9;
              continue;
            case 12:
              entityMetadata2 = (EntityMetadata) MetadataLoader.LoadMetadata(NHQueryExtensions.aiOUYYG6cAAokS1pyZFW((object) entityMetadata2));
              num2 = 28;
              continue;
            case 13:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              entityMetadata2 = (EntityMetadata) ContextVars.GetOrAdd<List<ClassMetadata>>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217785259) + (object) NHQueryExtensions.aiOUYYG6cAAokS1pyZFW((object) rootMetadata), (Func<List<ClassMetadata>>) (() => NHQueryExtensions.GetChildMetadata((object) rootMetadata))).FirstOrDefault<ClassMetadata>((Func<ClassMetadata, bool>) (ch => NHQueryExtensions.\u003C\u003Ec__DisplayClass11_0.DVV9Af8GfaQFtm4UnyMV(NHQueryExtensions.\u003C\u003Ec__DisplayClass11_0.YYu5GD8GQh12m5ycmynS((object) ch), (object) fullentityName1)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 15 : 19;
              continue;
            case 14:
              num2 = 10;
              continue;
            case 15:
              obj = (object) propertyName1;
              break;
            case 16:
              if (!NHQueryExtensions.m6Oe6IG6zEO1PlN70OWX((object) propertyName1, NHQueryExtensions.U1f6FgG6r4S6dhxM9Prd(-2138160520 ^ -2138177510)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 15 : 12;
                continue;
              }
              obj = NHQueryExtensions.DhuB8FGHFSkm2Une0y4i(rootType);
              break;
            case 17:
              fullentityName1 = (string) fullentityName;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 1 : 0;
              continue;
            case 18:
              goto label_5;
            case 19:
              if (entityMetadata2 == null)
              {
                num2 = 6;
                continue;
              }
              goto case 12;
            case 20:
              if (settings == null)
              {
                num2 = 24;
                continue;
              }
              goto case 5;
            case 21:
              if (entityMetadata1 != null)
              {
                rootMetadata = (EntityMetadata) MetadataLoader.LoadMetadata(rootType);
                num2 = 13;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 25 : 15;
              continue;
            case 22:
              // ISSUE: reference to a compiler-generated method
              entityMetadata1 = ((IMetadataService) NHQueryExtensions.db9iKxG6sFuQ4BYCpCkF()).GetMetadataList().OfType<EntityMetadata>().FirstOrDefault<EntityMetadata>((Func<EntityMetadata, bool>) (m => NHQueryExtensions.\u003C\u003Ec__DisplayClass11_0.DVV9Af8GfaQFtm4UnyMV((object) m.FullTypeName, (object) fullentityName1)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 21 : 21;
              continue;
            case 23:
              if (NHQueryExtensions.Hu6G57GHoyRqgUXADq4K(NHQueryExtensions.b4Rc3QGHWRQOaVX474iN((object) Locator.GetServiceNotNull<IMetadataRuntimeService>(), propertyMetadata2.TypeUid, NHQueryExtensions.raukyWGHB0cU4bVW6qHV((object) propertyMetadata2)), (object) entityMetadata2, (object) propertyMetadata2))
              {
                num2 = 4;
                continue;
              }
              goto case 14;
            case 24:
              goto label_36;
            case 25:
              goto label_3;
            case 26:
              if (propertyMetadata2 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 7 : 5;
                continue;
              }
              goto label_15;
            case 27:
              if (propertyMetadata1 == null)
              {
                num2 = 8;
                continue;
              }
              realProperty = (string) NHQueryExtensions.GQ4glRGHbbOw4sGAFY4B((object) propertyMetadata1);
              num2 = 2;
              continue;
            case 28:
              realMetadata = entityMetadata2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
              continue;
            case 29:
              goto label_29;
            default:
              propertyMetadata2 = (EntityPropertyMetadata) entityMetadata2.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => p.Name.Equals(propertyName1)));
              num2 = 26;
              continue;
          }
          propertyName2 = (string) obj;
          num2 = 23;
        }
label_5:
        num1 = 17;
        continue;
label_29:
        realProperty = "";
        num1 = 11;
      }
label_3:
      return (CustomPropertyProjection) null;
label_15:
      return (CustomPropertyProjection) null;
label_26:
      return (CustomPropertyProjection) null;
label_35:
      return new CustomPropertyProjection(propertyMetadata1.Name, fullentityName1, (string) NHQueryExtensions.hVTnfrGHhvIRl6cwPVBO((object) entityMetadata1), propertyMetadata1, forOrder);
label_36:
      return new CustomPropertyProjection(propertyName2, fullentityName1, (string) NHQueryExtensions.hVTnfrGHhvIRl6cwPVBO((object) entityMetadata1), (PropertyMetadata) propertyMetadata2, forOrder);
label_37:
      return new CustomPropertyProjection(propertyName2, fullentityName1, (string) NHQueryExtensions.hVTnfrGHhvIRl6cwPVBO((object) entityMetadata1), (PropertyMetadata) propertyMetadata2, forOrder);
label_38:
      return (CustomPropertyProjection) null;
    }

    private static List<ClassMetadata> GetChildMetadata(object metadata)
    {
      List<ClassMetadata> childClasses = MetadataLoader.GetChildClasses((ClassMetadata) metadata);
      childClasses.Insert(0, (ClassMetadata) metadata);
      childClasses.AddRange((IEnumerable<ClassMetadata>) MetadataLoader.GetBaseClasses((ClassMetadata) metadata));
      return childClasses;
    }

    internal static bool deJ26XG6MAkq2hXL6dQa() => NHQueryExtensions.DOM0oqG6yNSigv2j4stt == null;

    internal static NHQueryExtensions G1yGslG6J2HKYYBg31ZR() => NHQueryExtensions.DOM0oqG6yNSigv2j4stt;

    internal static object pWnsh2G69Qj1ebgwFhaR([In] object obj0, [In] object obj1, [In] object obj2) => (object) NHQueryExtensions.Sql((SqlString) obj0, (object[]) obj1, (IType[]) obj2);

    internal static object IXWhu1G6dE4BEZwYalsf([In] object obj0, [In] object obj1, [In] object obj2) => (object) NHQueryExtensions.Sql((string) obj0, (object[]) obj1, (IType[]) obj2);

    internal static bool LQ41AWG6lViUjC4k8CHB([In] System.Type obj0, [In] System.Type obj1) => obj0 == obj1;

    internal static object U1f6FgG6r4S6dhxM9Prd(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object qKx8cWG6g54BmXDgLpPJ([In] object obj0) => (object) string.Concat((string[]) obj0);

    internal static bool rCn7nOG65RgJ0qdFVdxE() => Locator.Initialized;

    internal static DateTime eUrvZNG6jcn2KiLyU46x() => DateTime.Now;

    internal static bool UQR7NUG6YqwRbTH1hMtm([In] DateTime obj0, [In] DateTime obj1) => obj0 > obj1;

    internal static object LoJCUSG6LdBC9ocyUMvL([In] object obj0) => ((IIdentified) obj0).GetId();

    internal static void qa6ZZZG6U1u3esJ9tRFB([In] int obj0) => Thread.Sleep(obj0);

    internal static object db9iKxG6sFuQ4BYCpCkF() => (object) MetadataServiceContext.Service;

    internal static Guid aiOUYYG6cAAokS1pyZFW([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static bool m6Oe6IG6zEO1PlN70OWX([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static object DhuB8FGHFSkm2Une0y4i(System.Type type) => (object) NHibernateHelper.GetCriteriaTypeUidPropertyName(type);

    internal static Guid raukyWGHB0cU4bVW6qHV([In] object obj0) => ((PropertyMetadata) obj0).SubTypeUid;

    internal static object b4Rc3QGHWRQOaVX474iN([In] object obj0, Guid typeUid, Guid subTypeUid) => (object) ((IMetadataService) obj0).GetTypeDescriptor(typeUid, subTypeUid);

    internal static bool Hu6G57GHoyRqgUXADq4K([In] object obj0, [In] object obj1, [In] object obj2) => ((ITypeDescriptor) obj0).HasRealColumn((EntityMetadata) obj1, (EntityPropertyMetadata) obj2);

    internal static object GQ4glRGHbbOw4sGAFY4B([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object hVTnfrGHhvIRl6cwPVBO([In] object obj0) => (object) ((EntityMetadata) obj0).TableName;
  }
}
