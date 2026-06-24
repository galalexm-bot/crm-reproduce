// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Manager.IndexQueueManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Cache;
using EleWise.ELMA.FullTextSearch.Exceptions;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.FullTextSearch.Services;
using EleWise.ELMA.FullTextSearch.Settings;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.FullTextSearch.Manager
{
  /// <summary>Менеджер обработки очереди отправки на индексирование</summary>
  public class IndexQueueManager : EntityManager<IIndexQueue, long>
  {
    private static readonly ILogger IndexLog;
    /// <summary>
    /// Ключ значения в IContextBoundVariableService, содержащий список который нужно обработать
    /// </summary>
    public static string IndexQueueListContextKeyConst;
    private IFullTextTypeMappingServiceExt mappingService;
    private static IndexQueueManager i8L63YGQPIi9XJXjODLh;

    /// <summary>Управление блокировками</summary>
    public ILockManager LockManager
    {
      get => this.\u003CLockManager\u003Ek__BackingField;
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
              this.\u003CLockManager\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
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

    /// <summary>Интерфейс провайдера преобразования БД</summary>
    public ITransformationProvider TransformationProvider
    {
      get => this.\u003CTransformationProvider\u003Ek__BackingField;
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
              this.\u003CTransformationProvider\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 0;
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

    public static IndexQueueManager Instance => Locator.GetServiceNotNull<IndexQueueManager>();

    private static ICacheService CacheService => Locator.GetServiceNotNull<ICacheService>();

    private IFullTextTypeMappingServiceExt MappingService
    {
      get
      {
        int num = 2;
        IFullTextTypeMappingServiceExt serviceNotNull;
        IFullTextTypeMappingServiceExt mappingService;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.mappingService = serviceNotNull = Locator.GetServiceNotNull<IFullTextTypeMappingServiceExt>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
              continue;
            case 2:
              mappingService = this.mappingService;
              if (mappingService == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 1;
                continue;
              }
              goto label_2;
            default:
              goto label_6;
          }
        }
label_2:
        return mappingService;
label_6:
        return serviceNotNull;
      }
    }

    [Transaction]
    public override void Save(IIndexQueue obj)
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        long? nullable1;
        while (true)
        {
          bool? visualData;
          bool flag;
          long? nullable2;
          IUser currentUser;
          long? nullable3;
          switch (num2)
          {
            case 1:
              flag = true;
              num2 = 5;
              continue;
            case 2:
              if (currentUser != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 2 : 8;
                continue;
              }
              goto case 10;
            case 3:
              currentUser = ((IAuthenticationService) IndexQueueManager.wA8TeVGQ3Uj6UARs3Gp7((object) this)).GetCurrentUser();
              num2 = 2;
              continue;
            case 4:
              goto label_11;
            case 5:
              if (!(visualData.GetValueOrDefault() == flag & visualData.HasValue))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 11 : 1;
                continue;
              }
              goto label_11;
            case 6:
              if (nullable1.HasValue)
              {
                num2 = 7;
                continue;
              }
              goto label_12;
            case 7:
              visualData = obj.VisualData;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 1 : 0;
              continue;
            case 8:
              nullable3 = (long?) IndexQueueManager.PjoolAGQpMVuZ8hQHCwU((object) currentUser);
              break;
            case 9:
              base.Save(obj);
              num2 = 6;
              continue;
            case 10:
              nullable2 = new long?();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
              continue;
            case 11:
              goto label_19;
            case 12:
              obj.CreationAuthorId = nullable1;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 9 : 6;
              continue;
            case 13:
              goto label_3;
            default:
              nullable3 = nullable2;
              break;
          }
          nullable1 = nullable3;
          num2 = 12;
        }
label_11:
        ((ICacheService) IndexQueueManager.TPo866GQarVj9TuSRtYb()).Insert<long?>((string) IndexQueueManager.SohwcfGQtday0DXOMFvZ(IndexQueueManager.rMfQq0GQDS3LR61R8L47(-1350312861 << 3 ^ 2082448882), IndexQueueManager.rMfQq0GQDS3LR61R8L47(-1872275253 >> 6 ^ -29205091), (object) nullable1), nullable1, (string) IndexQueueManager.rMfQq0GQDS3LR61R8L47(272623989 ^ 272378251));
        num1 = 13;
      }
label_19:
      return;
label_3:
      return;
label_12:;
    }

    /// <summary>
    /// Имеются ли в очереди индексации данные влияющие на отображение гридов для текущего пользователя
    /// </summary>
    public bool ContainIndexingVisualData()
    {
      int num = 1;
      IUser user;
      long? id;
      while (true)
      {
        switch (num)
        {
          case 1:
            user = (IUser) IndexQueueManager.klo5B0GQwkL3UT8bQ7lx(IndexQueueManager.wA8TeVGQ3Uj6UARs3Gp7((object) this));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_5;
          case 3:
            id = (long?) user.GetId();
            num = 6;
            continue;
          case 4:
            goto label_7;
          case 5:
            goto label_8;
          case 6:
            if (id.HasValue)
            {
              num = 5;
              continue;
            }
            goto label_7;
          default:
            if (user != null)
            {
              num = 3;
              continue;
            }
            goto label_5;
        }
      }
label_5:
      return false;
label_7:
      return false;
label_8:
      return IndexQueueManager.oXNnmQGQ4LWj6KBY4eTF(IndexQueueManager.TPo866GQarVj9TuSRtYb(), IndexQueueManager.SohwcfGQtday0DXOMFvZ(IndexQueueManager.rMfQq0GQDS3LR61R8L47(516838154 ^ 516888032), IndexQueueManager.rMfQq0GQDS3LR61R8L47(277947046 - -1479185048 ^ 1756919232), (object) id), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675325631));
    }

    /// <summary>
    /// Имеются ли в очереди индексации данные, влияющие на отображение для указанного типа карточки
    /// </summary>
    /// <param name="cardType"></param>
    /// <returns></returns>
    public bool ContainIndexingVisualData(Guid cardType)
    {
      int num = 3;
      IIndexQueueFilter indexQueueFilter;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            indexQueueFilter = InterfaceActivator.Create<IIndexQueueFilter>();
            num = 5;
            continue;
          case 3:
            if (this.IsIndexingOn())
            {
              num = 2;
              continue;
            }
            goto label_6;
          case 4:
            goto label_6;
          case 5:
            indexQueueFilter.CardTypeUid = new Guid?(cardType);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
            continue;
          default:
            indexQueueFilter.VisualData = new bool?(true);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 1 : 1;
            continue;
        }
      }
label_3:
      return IndexQueueManager.F8hpPeGQ6VRO9BiAk8NQ((object) this, (object) indexQueueFilter);
label_6:
      return false;
    }

    /// <summary>Очистка очереди индексации</summary>
    public void ClearQueue()
    {
      int num = 2;
      string sql;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.TransformationProvider.ExecuteNonQuery(sql);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
            continue;
          case 2:
            sql = (string) IndexQueueManager.UpOcGWGQ7iPBS2tcNYKs(IndexQueueManager.rMfQq0GQDS3LR61R8L47(-138018305 ^ -137984543), IndexQueueManager.k4TYYXGQAiFtvrVK4rAy(IndexQueueManager.UMoj6oGQHa5AGZZM7hKv((object) this.TransformationProvider), IndexQueueManager.rMfQq0GQDS3LR61R8L47(-218496594 ^ -218513254)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    private List<KeyValuePair<string, object>> DirtyValuesHexToList(string valueStr)
    {
      List<KeyValuePair<string, object>> list = new List<KeyValuePair<string, object>>();
      string[] source = valueStr.Split('|');
      if (((IEnumerable<string>) source).Any<string>())
      {
        foreach (string str in source)
        {
          if (MemoryHelper.ActionWithMemoryBuffer<byte, string, object>(str.Length >> 1, str, new MemoryHelper.ActionWithMemoryBufferAndParameterDelegate<byte, string, object>(this.DirtyValuesHexToListAction)) is KeyValuePair<string, object> keyValuePair)
            list.Add(keyValuePair);
        }
      }
      return list;
    }

    /// <summary>
    /// Преобразовать HEX значение в список с использование буфера
    /// </summary>
    /// <param name="buffer">Буфер</param>
    /// <param name="offset">Смещение относительно начала буфера</param>
    /// <param name="length">Длина буфера</param>
    /// <param name="listGrI">Элемент</param>
    /// <returns>Объект</returns>
    private object DirtyValuesHexToListAction(
      byte[] buffer,
      int offset,
      int length,
      string listGrI)
    {
      int num = 4;
      int index;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
          case 3:
            if (index < offset + length)
            {
              num = 5;
              continue;
            }
            goto label_5;
          case 4:
            index = offset;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 1 : 3;
            continue;
          case 5:
          case 6:
            buffer[index] = IndexQueueManager.spB5MiGQ0mTMuxC9LgKY(IndexQueueManager.Sy3OOEGQxV2xCVb8u1dK((object) listGrI, index << 1, 2), 16);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
            continue;
          default:
            ++index;
            num = 2;
            continue;
        }
      }
label_5:
      return ClassSerializationHelper.DeserializeObject(buffer, offset, length);
    }

    /// <summary>Есть ли в очереди элемент очереди полной индексации</summary>
    public bool HasIndexAllQueue()
    {
      int num = 2;
      Dictionary<string, object> paramValues;
      string sql;
      while (true)
      {
        switch (num)
        {
          case 1:
            paramValues = new Dictionary<string, object>()
            {
              {
                (string) IndexQueueManager.rMfQq0GQDS3LR61R8L47(-1598106783 - -968262081 ^ -629762832),
                (object) 0
              }
            };
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 0 : 0;
            continue;
          case 2:
            sql = (string) IndexQueueManager.uANvCPGQyU30dArwmDq1((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(322893104 - -1992822529 ^ -1979398787), (object) new object[4]
            {
              IndexQueueManager.k4TYYXGQAiFtvrVK4rAy(IndexQueueManager.UMoj6oGQHa5AGZZM7hKv((object) this.TransformationProvider), IndexQueueManager.rMfQq0GQDS3LR61R8L47(-1217523399 ^ -1217540083)),
              IndexQueueManager.k4TYYXGQAiFtvrVK4rAy((object) this.TransformationProvider.Dialect, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398696446)),
              (object) ((Dialect) IndexQueueManager.UMoj6oGQHa5AGZZM7hKv((object) this.TransformationProvider)).QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16539813)),
              IndexQueueManager.IpakLTGQme0cJLTV889k((object) this.TransformationProvider)
            });
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 1 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return IndexQueueManager.rC4jCKGQMqoydlwsoqlh(this.TransformationProvider.ExecuteScalar(sql, paramValues)) > 0L;
    }

    /// <summary>
    /// Есть ли в очереди элемент очереди полной индексации или индексации типа
    /// </summary>
    public bool HasIndexAllReIndexByTypeQueue()
    {
      int num = 1;
      Dictionary<string, object> paramValues;
      string sql;
      while (true)
      {
        switch (num)
        {
          case 1:
            sql = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939557506), IndexQueueManager.k4TYYXGQAiFtvrVK4rAy(IndexQueueManager.UMoj6oGQHa5AGZZM7hKv((object) this.TransformationProvider), IndexQueueManager.rMfQq0GQDS3LR61R8L47(-2099751081 ^ -2099538333)), IndexQueueManager.k4TYYXGQAiFtvrVK4rAy(IndexQueueManager.UMoj6oGQHa5AGZZM7hKv((object) this.TransformationProvider), IndexQueueManager.rMfQq0GQDS3LR61R8L47(-812025778 ^ -811992816)), IndexQueueManager.k4TYYXGQAiFtvrVK4rAy(IndexQueueManager.UMoj6oGQHa5AGZZM7hKv((object) this.TransformationProvider), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(87862435 ^ 88042783)), (object) this.TransformationProvider.ParameterSeparator);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            paramValues = new Dictionary<string, object>()
            {
              {
                (string) IndexQueueManager.rMfQq0GQDS3LR61R8L47(-138018305 ^ -138034345),
                (object) 0
              },
              {
                (string) IndexQueueManager.rMfQq0GQDS3LR61R8L47(-1380439818 << 3 ^ 1841464680),
                (object) 1
              }
            };
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 2 : 1;
            continue;
        }
      }
label_3:
      return IndexQueueManager.rC4jCKGQMqoydlwsoqlh(this.TransformationProvider.ExecuteScalar(sql, paramValues)) > 0L;
    }

    /// <summary>
    /// Проверка, есть ли у последнего из элементов очереди полной индексации информация о продолжении
    /// </summary>
    public bool HasIndexAllQueueForContinue()
    {
      int num1 = 5;
      while (true)
      {
        int num2 = num1;
        ICollection<IIndexQueue> source;
        IIndexQueueFilter filter;
        FetchOptions fetchOptions1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!IndexQueueManager.y2j8kpGQdoowRXi1eXCB(IndexQueueManager.NOcmpmGQ9sudnlC0bSHe((object) source.Last<IIndexQueue>())))
              {
                num2 = 2;
                continue;
              }
              goto label_5;
            case 2:
              goto label_6;
            case 3:
              source = this.Find((IEntityFilter) filter, fetchOptions1);
              num2 = 6;
              continue;
            case 4:
              filter.QueueType = new List<IndexQueueType>()
              {
                IndexQueueType.IndexAll
              };
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 4 : 8;
              continue;
            case 5:
              goto label_13;
            case 6:
              if (!source.Any<IIndexQueue>())
              {
                num2 = 7;
                continue;
              }
              goto case 1;
            case 7:
              goto label_7;
            case 8:
              FetchOptions fetchOptions2 = new FetchOptions();
              IndexQueueManager.XJ7mA4GQJZVJMOJL8Gh6((object) fetchOptions2, IndexQueueManager.rMfQq0GQDS3LR61R8L47(-1710575414 ^ -1710607980));
              fetchOptions1 = fetchOptions2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 3 : 3;
              continue;
            default:
              goto label_5;
          }
        }
label_13:
        filter = InterfaceActivator.Create<IIndexQueueFilter>();
        num1 = 4;
      }
label_5:
      return false;
label_6:
      return true;
label_7:
      return false;
    }

    private bool IndexAll(IIndexQueue item)
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          long id;
          bool breakBecauseIsIndexAll;
          string sql;
          switch (num2)
          {
            case 1:
              goto label_3;
            case 2:
              sql = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420989752), (object) ((Dialect) IndexQueueManager.UMoj6oGQHa5AGZZM7hKv((object) this.TransformationProvider)).QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867051359)), IndexQueueManager.k4TYYXGQAiFtvrVK4rAy(IndexQueueManager.UMoj6oGQHa5AGZZM7hKv((object) this.TransformationProvider), IndexQueueManager.rMfQq0GQDS3LR61R8L47(901793403 ^ 901826341)), IndexQueueManager.IpakLTGQme0cJLTV889k((object) this.TransformationProvider), breakBecauseIsIndexAll ? IndexQueueManager.rMfQq0GQDS3LR61R8L47(654297945 ^ 654279839) : (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867843978));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 6 : 3;
              continue;
            case 3:
              id = item.Id;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 5 : 7;
              continue;
            case 4:
              if (IndexQueueManager.QXXkE5GQlnDaLqhRGCpX((object) item) > 5L)
                break;
              goto label_6;
            case 5:
              goto label_7;
            case 6:
              this.TransformationProvider.ExecuteNonQuery(sql, new Dictionary<string, object>()
              {
                {
                  (string) IndexQueueManager.rMfQq0GQDS3LR61R8L47(1597012150 ^ 1597226228),
                  (object) id
                }
              });
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 1;
              continue;
            case 7:
              if (((IFullTextSearchService) IndexQueueManager.ykPnvsGQrFK86K9Je66g((object) this)).ReIndexAllEntities(item, (string) IndexQueueManager.NOcmpmGQ9sudnlC0bSHe((object) item), out breakBecauseIsIndexAll))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 2 : 1;
                continue;
              }
              goto label_4;
          }
          this.FullTextSearchService.StopIndexing(EleWise.ELMA.SR.T((string) IndexQueueManager.rMfQq0GQDS3LR61R8L47(-35995181 ^ -36109521)));
          num2 = 5;
        }
label_6:
        num1 = 3;
      }
label_3:
      return true;
label_4:
      return false;
label_7:
      return false;
    }

    /// <summary>Индексирование по типу</summary>
    /// <param name="item">Элемент очереди индексирования</param>
    private bool IndexByType(IIndexQueue item)
    {
      int num = 9;
      Type cardType;
      Guid? cardTypeUid;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_6;
          case 2:
            IndexQueueManager.Kd5m3EGQUSotUch9Nlhr((object) this.FullTextSearchService, (object) item);
            num = 11;
            continue;
          case 3:
            if (IndexQueueManager.trThAcGQYXb2rpC1RCDI(cardType, (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 0 : 0;
              continue;
            }
            if (!this.HasIndexAllQueue())
            {
              num = 4;
              continue;
            }
            goto case 12;
          case 4:
            IndexQueueManager.WyeK25GQLaC7fjY2bHDC((object) this.FullTextSearchService, cardType);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 2 : 1;
            continue;
          case 5:
            object obj = IndexQueueManager.Q2ni16GQ58UmKva214JP((object) this);
            cardTypeUid = item.CardTypeUid;
            Guid cardUid = cardTypeUid.Value;
            cardType = IndexQueueManager.SIu2N1GQj6Kc0yjN3apa(obj, cardUid);
            num = 3;
            continue;
          case 6:
            goto label_16;
          case 7:
            IndexQueueManager.k6iqAQGQgtiYXt5yWG9y((object) IndexQueueManager.IndexLog, IndexQueueManager.rMfQq0GQDS3LR61R8L47(589593376 ^ -1977315327 ^ -1459409043));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 1 : 0;
            continue;
          case 8:
            if (cardTypeUid.HasValue)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 4 : 5;
              continue;
            }
            goto case 7;
          case 9:
            cardTypeUid = item.CardTypeUid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 2 : 8;
            continue;
          case 10:
            goto label_12;
          case 11:
            goto label_8;
          case 12:
            IndexQueueManager.k6iqAQGQgtiYXt5yWG9y((object) IndexQueueManager.IndexLog, IndexQueueManager.rMfQq0GQDS3LR61R8L47(-951514650 ^ -951399322));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 5 : 6;
            continue;
          default:
            ILogger indexLog = IndexQueueManager.IndexLog;
            object format = IndexQueueManager.rMfQq0GQDS3LR61R8L47(-2112703338 ^ -2112786310);
            object[] objArray = new object[1];
            cardTypeUid = item.CardTypeUid;
            objArray[0] = (object) cardTypeUid.Value;
            indexLog.ErrorFormat((string) format, objArray);
            num = 10;
            continue;
        }
      }
label_6:
      return true;
label_8:
      return false;
label_12:
      return true;
label_16:
      return true;
    }

    private void ResetIndexQueueAttempt(IIndexQueue item)
    {
      int num = 1;
      string sql;
      while (true)
      {
        switch (num)
        {
          case 1:
            sql = (string) IndexQueueManager.uANvCPGQyU30dArwmDq1(IndexQueueManager.rMfQq0GQDS3LR61R8L47(-70007027 ^ -70254277), (object) new object[4]
            {
              IndexQueueManager.k4TYYXGQAiFtvrVK4rAy(IndexQueueManager.UMoj6oGQHa5AGZZM7hKv((object) this.TransformationProvider), IndexQueueManager.rMfQq0GQDS3LR61R8L47(-477139494 ^ -477319954)),
              IndexQueueManager.k4TYYXGQAiFtvrVK4rAy((object) this.TransformationProvider.Dialect, IndexQueueManager.rMfQq0GQDS3LR61R8L47(1819636893 << 3 ^ 1672160694)),
              IndexQueueManager.IpakLTGQme0cJLTV889k((object) this.TransformationProvider),
              IndexQueueManager.k4TYYXGQAiFtvrVK4rAy(IndexQueueManager.UMoj6oGQHa5AGZZM7hKv((object) this.TransformationProvider), IndexQueueManager.rMfQq0GQDS3LR61R8L47(-2138958856 ^ -2138974860))
            });
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            this.TransformationProvider.ExecuteNonQuery(sql, new Dictionary<string, object>()
            {
              {
                (string) IndexQueueManager.rMfQq0GQDS3LR61R8L47(~541731958 ^ -541714485),
                (object) item.Id
              }
            });
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    private void IncreaseIndexQueueAttempt(IIndexQueue item)
    {
      int num = 1;
      string sql;
      while (true)
      {
        switch (num)
        {
          case 1:
            IIndexQueue indexQueue = item;
            IndexQueueManager.BsumQEGQsupi7sKIrsWx((object) indexQueue, IndexQueueManager.QXXkE5GQlnDaLqhRGCpX((object) indexQueue) + 1L);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 0 : 0;
            continue;
          case 2:
            this.TransformationProvider.ExecuteNonQuery(sql, new Dictionary<string, object>()
            {
              {
                (string) IndexQueueManager.rMfQq0GQDS3LR61R8L47(-441065788 ^ -2092910478 ^ 1727439604),
                (object) item.Id
              },
              {
                (string) IndexQueueManager.rMfQq0GQDS3LR61R8L47(372753449 ^ 372507427),
                (object) IndexQueueManager.QXXkE5GQlnDaLqhRGCpX((object) item)
              }
            });
            num = 3;
            continue;
          case 3:
            goto label_2;
          default:
            sql = string.Format((string) IndexQueueManager.rMfQq0GQDS3LR61R8L47(-1824388195 ^ -1824404221), IndexQueueManager.k4TYYXGQAiFtvrVK4rAy((object) this.TransformationProvider.Dialect, IndexQueueManager.rMfQq0GQDS3LR61R8L47(-606654180 ^ -606801880)), IndexQueueManager.k4TYYXGQAiFtvrVK4rAy(IndexQueueManager.UMoj6oGQHa5AGZZM7hKv((object) this.TransformationProvider), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1872275253 >> 6 ^ -29287363)), IndexQueueManager.IpakLTGQme0cJLTV889k((object) this.TransformationProvider), IndexQueueManager.k4TYYXGQAiFtvrVK4rAy(IndexQueueManager.UMoj6oGQHa5AGZZM7hKv((object) this.TransformationProvider), IndexQueueManager.rMfQq0GQDS3LR61R8L47(1218962250 ^ 1218717126)), IndexQueueManager.IpakLTGQme0cJLTV889k((object) this.TransformationProvider));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    private bool IndexObject(IIndexQueue item)
    {
      int num = 10;
      IndexQueueType indexQueueType;
      Guid? objectTypeUid;
      Type typeByObjectTypeUid;
      long? objectId;
      IndexQueueType? queueType;
      while (true)
      {
        switch (num)
        {
          case 1:
            objectId = item.ObjectId;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 14 : 11;
            continue;
          case 2:
            object obj = IndexQueueManager.Q2ni16GQ58UmKva214JP((object) this);
            objectTypeUid = item.ObjectTypeUid;
            Guid typeUid = objectTypeUid.Value;
            typeByObjectTypeUid = ((IFullTextSearchCardService) obj).GetCardTypeByObjectTypeUid(typeUid);
            num = 3;
            continue;
          case 3:
            if (IndexQueueManager.qfa6LCGQceYekEv9vGmy(typeByObjectTypeUid, (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 13 : 4;
              continue;
            }
            goto label_11;
          case 4:
            if (!(queueType.GetValueOrDefault() == indexQueueType & queueType.HasValue))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 5 : 3;
              continue;
            }
            goto case 2;
          case 6:
            queueType = item.QueueType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 11 : 2;
            continue;
          case 8:
            if (!objectTypeUid.HasValue)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 0 : 0;
              continue;
            }
            goto case 6;
          case 10:
            if (item == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 1 : 9;
              continue;
            }
            goto case 1;
          case 11:
            indexQueueType = IndexQueueType.IndexObject;
            num = 4;
            continue;
          case 12:
            objectTypeUid = item.ObjectTypeUid;
            num = 8;
            continue;
          case 13:
            IFullTextSearchServiceReIndexingTypeExtension textSearchService = this.FullTextSearchService;
            Type cardType = typeByObjectTypeUid;
            List<long> listId = new List<long>();
            objectId = item.ObjectId;
            listId.Add(objectId.Value);
            textSearchService.IndexEntities(cardType, listId);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 7;
            continue;
          case 14:
            if (objectId.HasValue)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 12 : 6;
              continue;
            }
            goto label_11;
          default:
            goto label_11;
        }
      }
label_11:
      return true;
    }

    private bool ReIndexObjectPart(IIndexQueue item)
    {
      int num1 = 14;
      IEnumerator<IGrouping<Type, QueueToIndex>> enumerator1;
      while (true)
      {
        int num2 = num1;
        long? objectId;
        IndexQueueType? queueType;
        Guid? nullable;
        List<QueueToIndex>.Enumerator enumerator2;
        List<KeyValuePair<string, object>> list;
        IndexQueueType indexQueueType;
        List<QueueToIndex> queueToIndex;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 8:
            case 11:
            case 12:
            case 13:
              goto label_24;
            case 2:
              if (nullable.HasValue)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 9 : 9;
                continue;
              }
              goto label_24;
            case 3:
              if (!list.Any<KeyValuePair<string, object>>())
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 12 : 0;
                continue;
              }
              goto label_67;
            case 4:
              enumerator2 = queueToIndex.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 16 : 14;
              continue;
            case 5:
              if (!objectId.HasValue)
              {
                num2 = 11;
                continue;
              }
              goto case 6;
            case 6:
              nullable = item.ObjectTypeUid;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
              continue;
            case 7:
              goto label_29;
            case 9:
              queueType = item.QueueType;
              num2 = 17;
              continue;
            case 10:
              list = this.DirtyValuesHexToList((string) IndexQueueManager.NOcmpmGQ9sudnlC0bSHe((object) item));
              num2 = 3;
              continue;
            case 14:
              if (item == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 13 : 13;
                continue;
              }
              goto case 19;
            case 15:
              nullable = item.CardTypeUid;
              num2 = 2;
              continue;
            case 16:
              try
              {
label_14:
                if (enumerator2.MoveNext())
                  goto label_12;
                else
                  goto label_15;
label_10:
                QueueToIndex current;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      if (!current.Properties.Any<KeyValuePair<string, object>>((System.Func<KeyValuePair<string, object>, bool>) (p => object.Equals((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 1418407892), (object) p.Key))))
                      {
                        num3 = 2;
                        continue;
                      }
                      goto label_14;
                    case 2:
                      current.Properties.Add(new KeyValuePair<string, object>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1242972401 >> 4 ^ 77718865), (object) current.Id));
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 3 : 2;
                      continue;
                    case 3:
                      goto label_14;
                    case 4:
                      goto label_71;
                    default:
                      goto label_12;
                  }
                }
label_12:
                current = enumerator2.Current;
                num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
                {
                  num3 = 1;
                  goto label_10;
                }
                else
                  goto label_10;
label_15:
                num3 = 4;
                goto label_10;
              }
              finally
              {
                enumerator2.Dispose();
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                }
              }
            case 17:
              indexQueueType = IndexQueueType.ReIndexObjectPart;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 2 : 20;
              continue;
            case 18:
label_71:
              enumerator1 = queueToIndex.GroupBy<QueueToIndex, Type>((System.Func<QueueToIndex, Type>) (i => i.CardType)).GetEnumerator();
              num2 = 7;
              continue;
            case 19:
              objectId = item.ObjectId;
              num2 = 5;
              continue;
            case 20:
              if (!(queueType.GetValueOrDefault() == indexQueueType & queueType.HasValue))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 1 : 1;
                continue;
              }
              goto case 10;
            case 21:
              goto label_67;
            default:
              if (nullable.HasValue)
              {
                num2 = 15;
                continue;
              }
              goto label_24;
          }
        }
label_67:
        IFullTextTypeMappingServiceExt mappingService = this.MappingService;
        List<KeyValuePair<string, object>> keyValuePairList = list;
        objectId = item.ObjectId;
        long id = objectId.Value;
        nullable = item.ObjectTypeUid;
        Guid objectTypeUid = nullable.Value;
        queueToIndex = mappingService.GetQueueToIndex(keyValuePairList, id, objectTypeUid);
        num1 = 4;
      }
label_24:
      return true;
label_29:
      try
      {
label_31:
        if (IndexQueueManager.jnqeyoGQzGCacFmWvxVP((object) enumerator1))
          goto label_33;
        else
          goto label_32;
label_30:
        IGrouping<Type, QueueToIndex> current1;
        IEnumerator<QueueToIndex> enumerator3;
        List<IEnumerable<KeyValuePair<string, object>>> listProperty;
        int num5;
        while (true)
        {
          switch (num5)
          {
            case 1:
              listProperty = new List<IEnumerable<KeyValuePair<string, object>>>();
              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 4 : 4;
              continue;
            case 2:
label_56:
              ((IFullTextSearchService) IndexQueueManager.ykPnvsGQrFK86K9Je66g((object) this)).ReIndexByPropertyList(current1.Key, listProperty);
              num5 = 3;
              continue;
            case 3:
              goto label_31;
            case 4:
              enumerator3 = current1.GetEnumerator();
              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
              continue;
            case 5:
              goto label_33;
            case 6:
              goto label_24;
            default:
              try
              {
label_38:
                if (IndexQueueManager.jnqeyoGQzGCacFmWvxVP((object) enumerator3))
                  goto label_40;
                else
                  goto label_39;
label_37:
                QueueToIndex current2;
                List<KeyValuePair<string, object>> list;
                int num6;
                while (true)
                {
                  switch (num6)
                  {
                    case 1:
                      goto label_38;
                    case 2:
                      List<KeyValuePair<string, object>> keyValuePairList = list;
                      FieldIndexList dynamicProperties = current2.DynamicProperties;
                      // ISSUE: reference to a compiler-generated field
                      System.Func<FieldIndexListItem, KeyValuePair<string, object>> func1 = IndexQueueManager.\u003C\u003Ec.\u003C\u003E9__33_3;
                      System.Func<FieldIndexListItem, KeyValuePair<string, object>> selector1;
                      if (func1 == null)
                      {
                        // ISSUE: reference to a compiler-generated field
                        IndexQueueManager.\u003C\u003Ec.\u003C\u003E9__33_3 = selector1 = (System.Func<FieldIndexListItem, KeyValuePair<string, object>>) (di => new KeyValuePair<string, object>(di.Field, (object) di));
                      }
                      else
                        goto label_72;
label_48:
                      IEnumerable<KeyValuePair<string, object>> collection = dynamicProperties.Select<FieldIndexListItem, KeyValuePair<string, object>>(selector1);
                      keyValuePairList.AddRange(collection);
                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 5 : 1;
                      continue;
label_72:
                      selector1 = func1;
                      goto label_48;
                    case 3:
                      goto label_40;
                    case 4:
                      List<KeyValuePair<string, object>> properties = current2.Properties;
                      // ISSUE: reference to a compiler-generated field
                      System.Func<KeyValuePair<string, object>, KeyValuePair<string, object>> func2 = IndexQueueManager.\u003C\u003Ec.\u003C\u003E9__33_2;
                      System.Func<KeyValuePair<string, object>, KeyValuePair<string, object>> selector2;
                      if (func2 == null)
                      {
                        // ISSUE: reference to a compiler-generated field
                        IndexQueueManager.\u003C\u003Ec.\u003C\u003E9__33_2 = selector2 = (System.Func<KeyValuePair<string, object>, KeyValuePair<string, object>>) (p => new KeyValuePair<string, object>(p.Key, p.Value));
                      }
                      else
                        goto label_73;
label_45:
                      list = properties.Select<KeyValuePair<string, object>, KeyValuePair<string, object>>(selector2).ToList<KeyValuePair<string, object>>();
                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 0 : 2;
                      continue;
label_73:
                      selector2 = func2;
                      goto label_45;
                    case 5:
                      listProperty.Add((IEnumerable<KeyValuePair<string, object>>) list);
                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 1;
                      continue;
                    default:
                      goto label_56;
                  }
                }
label_39:
                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 0 : 0;
                goto label_37;
label_40:
                current2 = enumerator3.Current;
                num6 = 4;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
                {
                  num6 = 1;
                  goto label_37;
                }
                else
                  goto label_37;
              }
              finally
              {
                int num7;
                if (enumerator3 == null)
                  num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 0;
                else
                  goto label_52;
label_51:
                switch (num7)
                {
                  case 1:
                    break;
                  default:
                }
label_52:
                IndexQueueManager.fkWwVQGCFbH6EYExRcw9((object) enumerator3);
                num7 = 2;
                goto label_51;
              }
          }
        }
label_32:
        num5 = 6;
        goto label_30;
label_33:
        current1 = enumerator1.Current;
        num5 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
        {
          num5 = 0;
          goto label_30;
        }
        else
          goto label_30;
      }
      finally
      {
        if (enumerator1 != null)
        {
          int num8 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
            num8 = 0;
          while (true)
          {
            switch (num8)
            {
              case 1:
                goto label_62;
              default:
                enumerator1.Dispose();
                num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 1 : 1;
                continue;
            }
          }
        }
label_62:;
      }
    }

    /// <summary>Схлопывание пачки грязных данных</summary>
    private void MergeBlanks(
      List<IIndexQueue> itemsIndex,
      out List<IIndexQueue> itemsForIndex,
      out List<IIndexQueue> itemsForClear)
    {
      itemsForIndex = new List<IIndexQueue>();
      itemsForClear = new List<IIndexQueue>();
      foreach (IGrouping<Guid?, IIndexQueue> source1 in itemsIndex.GroupBy<IIndexQueue, Guid?>((System.Func<IIndexQueue, Guid?>) (i => i.CardTypeUid)))
      {
        if (source1.Key.HasValue)
        {
          IIndexQueue newestIndexByType = source1.Where<IIndexQueue>((System.Func<IIndexQueue, bool>) (i =>
          {
            int num = 1;
            IndexQueueType? queueType;
            IndexQueueType indexQueueType;
            while (true)
            {
              switch (num)
              {
                case 1:
                  queueType = i.QueueType;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 0;
                  continue;
                case 2:
                  goto label_4;
                default:
                  indexQueueType = IndexQueueType.IndexByType;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 2 : 1;
                  continue;
              }
            }
label_4:
            return queueType.GetValueOrDefault() == indexQueueType & queueType.HasValue;
          })).OrderBy<IIndexQueue, long>((System.Func<IIndexQueue, long>) (i => i.Id)).LastOrDefault<IIndexQueue>();
          if (newestIndexByType != null)
            itemsForIndex.Add(newestIndexByType);
          foreach (IEnumerable<IIndexQueue> source2 in (newestIndexByType == null ? source1.Where<IIndexQueue>((System.Func<IIndexQueue, bool>) (i =>
          {
            int num = 2;
            IndexQueueType indexQueueType;
            IndexQueueType? queueType;
            while (true)
            {
              switch (num)
              {
                case 1:
                  indexQueueType = IndexQueueType.IndexObject;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
                  continue;
                case 2:
                  queueType = i.QueueType;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 1 : 1;
                  continue;
                case 3:
                  goto label_4;
                case 4:
                  queueType = i.QueueType;
                  num = 6;
                  continue;
                case 5:
                  goto label_5;
                case 6:
                  indexQueueType = IndexQueueType.ReIndexObject;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 2 : 3;
                  continue;
                default:
                  if (queueType.GetValueOrDefault() == indexQueueType & queueType.HasValue)
                  {
                    num = 5;
                    continue;
                  }
                  goto case 4;
              }
            }
label_4:
            return queueType.GetValueOrDefault() == indexQueueType & queueType.HasValue;
label_5:
            return true;
          })) : source1.Where<IIndexQueue>((System.Func<IIndexQueue, bool>) (i =>
          {
            int num = 2;
            IndexQueueType? queueType;
            IndexQueueType indexQueueType;
            while (true)
            {
              switch (num)
              {
                case 1:
                  indexQueueType = IndexQueueType.IndexObject;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 3 : 2;
                  continue;
                case 2:
                  queueType = i.QueueType;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 1 : 0;
                  continue;
                case 3:
                  if (queueType.GetValueOrDefault() == indexQueueType & queueType.HasValue)
                  {
                    num = 4;
                    continue;
                  }
                  goto case 6;
                case 4:
                  goto label_5;
                case 5:
                  goto label_4;
                case 6:
                  queueType = i.QueueType;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 0 : 0;
                  continue;
                default:
                  indexQueueType = IndexQueueType.ReIndexObject;
                  num = 5;
                  continue;
              }
            }
label_4:
            return queueType.GetValueOrDefault() == indexQueueType & queueType.HasValue;
label_5:
            return true;
          })).Where<IIndexQueue>((System.Func<IIndexQueue, bool>) (i => i.Id > newestIndexByType.Id))).GroupBy<IIndexQueue, long?>((System.Func<IIndexQueue, long?>) (i => i.ObjectId)))
          {
            IIndexQueue indexQueue = source2.OrderBy<IIndexQueue, long>((System.Func<IIndexQueue, long>) (i => i.Id)).LastOrDefault<IIndexQueue>();
            if (indexQueue != null)
              itemsForIndex.Add(indexQueue);
          }
          IEnumerable<IIndexQueue> source3 = newestIndexByType == null ? source1.Where<IIndexQueue>((System.Func<IIndexQueue, bool>) (i =>
          {
            int num = 2;
            IndexQueueType indexQueueType;
            IndexQueueType? queueType;
            while (true)
            {
              switch (num)
              {
                case 1:
                  indexQueueType = IndexQueueType.ReIndexObjectPart;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
                  continue;
                case 2:
                  queueType = i.QueueType;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 1 : 0;
                  continue;
                default:
                  goto label_3;
              }
            }
label_3:
            return queueType.GetValueOrDefault() == indexQueueType & queueType.HasValue;
          })) : source1.Where<IIndexQueue>((System.Func<IIndexQueue, bool>) (i =>
          {
            int num = 2;
            IndexQueueType? queueType;
            IndexQueueType indexQueueType;
            while (true)
            {
              switch (num)
              {
                case 1:
                  indexQueueType = IndexQueueType.ReIndexObjectPart;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
                  continue;
                case 2:
                  queueType = i.QueueType;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 1 : 1;
                  continue;
                default:
                  goto label_3;
              }
            }
label_3:
            return queueType.GetValueOrDefault() == indexQueueType & queueType.HasValue;
          })).Where<IIndexQueue>((System.Func<IIndexQueue, bool>) (i => i.Id > newestIndexByType.Id));
          foreach (IGrouping<Guid?, IIndexQueue> grouping in source3.GroupBy<IIndexQueue, Guid?>((System.Func<IIndexQueue, Guid?>) (i => i.ObjectTypeUid)))
          {
            if (grouping != null)
            {
              IGrouping<Guid?, IIndexQueue> objectTypeGroupF = grouping;
              foreach (IGrouping<long?, IIndexQueue> source4 in source3.GroupBy<IIndexQueue, long?>((System.Func<IIndexQueue, long?>) (i => i.ObjectId)))
              {
                if (source4 != null)
                {
                  IGrouping<long?, IIndexQueue> objectIdGroupF = source4;
                  IIndexQueue newestIndexObjectForTypeAndId = itemsForIndex.FirstOrDefault<IIndexQueue>((System.Func<IIndexQueue, bool>) (i =>
                  {
                    int num = 6;
                    long? objectId;
                    long? key1;
                    Guid? objectTypeUid;
                    Guid? key2;
                    while (true)
                    {
                      switch (num)
                      {
                        case 1:
                          goto label_13;
                        case 2:
                          goto label_5;
                        case 3:
                          goto label_4;
                        case 4:
                          key2 = objectTypeGroupF.Key;
                          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 9 : 1;
                          continue;
                        case 5:
                          key1 = objectIdGroupF.Key;
                          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
                          continue;
                        case 6:
                          objectId = i.ObjectId;
                          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 5 : 4;
                          continue;
                        case 7:
                          goto label_6;
                        case 8:
                          objectTypeUid = i.ObjectTypeUid;
                          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 1 : 4;
                          continue;
                        case 9:
                          if (objectTypeUid.HasValue != key2.HasValue)
                          {
                            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 1 : 1;
                            continue;
                          }
                          if (objectTypeUid.HasValue)
                          {
                            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 2 : 2;
                            continue;
                          }
                          goto label_4;
                        default:
                          if (!(objectId.GetValueOrDefault() == key1.GetValueOrDefault() & objectId.HasValue == key1.HasValue))
                          {
                            num = 7;
                            continue;
                          }
                          goto case 8;
                      }
                    }
label_4:
                    return true;
label_5:
                    return objectTypeUid.GetValueOrDefault() == key2.GetValueOrDefault();
label_6:
                    return false;
label_13:
                    return false;
                  }));
                  IEnumerable<IIndexQueue> indexQueues = newestIndexObjectForTypeAndId == null ? source4.Where<IIndexQueue>((System.Func<IIndexQueue, bool>) (i =>
                  {
                    int num = 2;
                    IndexQueueType indexQueueType;
                    IndexQueueType? queueType;
                    while (true)
                    {
                      switch (num)
                      {
                        case 1:
                          indexQueueType = IndexQueueType.ReIndexObjectPart;
                          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 0;
                          continue;
                        case 2:
                          queueType = i.QueueType;
                          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 1 : 0;
                          continue;
                        default:
                          goto label_3;
                      }
                    }
label_3:
                    return queueType.GetValueOrDefault() == indexQueueType & queueType.HasValue;
                  })) : source4.Where<IIndexQueue>((System.Func<IIndexQueue, bool>) (i =>
                  {
                    int num = 2;
                    IndexQueueType? queueType;
                    IndexQueueType indexQueueType;
                    while (true)
                    {
                      switch (num)
                      {
                        case 1:
                          indexQueueType = IndexQueueType.ReIndexObjectPart;
                          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 0;
                          continue;
                        case 2:
                          queueType = i.QueueType;
                          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 1 : 1;
                          continue;
                        default:
                          goto label_2;
                      }
                    }
label_2:
                    return queueType.GetValueOrDefault() == indexQueueType & queueType.HasValue;
                  })).Where<IIndexQueue>((System.Func<IIndexQueue, bool>) (i => i.Id > newestIndexObjectForTypeAndId.Id));
                  if (indexQueues != null)
                  {
                    foreach (IIndexQueue indexQueue in indexQueues)
                    {
                      IIndexQueue item = indexQueue;
                      if (!itemsForIndex.Any<IIndexQueue>((System.Func<IIndexQueue, bool>) (a =>
                      {
                        int num = 2;
                        long? objectId1;
                        long? objectId2;
                        while (true)
                        {
                          switch (num)
                          {
                            case 1:
                              objectId1 = item.ObjectId;
                              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 0 : 0;
                              continue;
                            case 2:
                              objectId2 = a.ObjectId;
                              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 1;
                              continue;
                            default:
                              goto label_4;
                          }
                        }
label_4:
                        return objectId2.GetValueOrDefault() == objectId1.GetValueOrDefault() & objectId2.HasValue == objectId1.HasValue;
                      })) || itemsForIndex.Any<IIndexQueue>() && itemsForIndex.LastOrDefault<IIndexQueue>().DirtyValues != item.DirtyValues)
                        itemsForIndex.Add(item);
                    }
                  }
                }
              }
            }
          }
        }
      }
      foreach (IIndexQueue indexQueue in itemsIndex)
      {
        if (!itemsForIndex.Contains(indexQueue))
          itemsForClear.Add(indexQueue);
      }
    }

    private bool IsIndexingOn() => IndexQueueManager.rbiHaVGCBnyKaogqpbQH(IndexQueueManager.ykPnvsGQrFK86K9Je66g((object) this)) == FullTextSearchState.On;

    private bool IndexingIsWorking() => IndexQueueManager.nmmUsEGCWxjrRf1gXdUb(IndexQueueManager.ykPnvsGQrFK86K9Je66g((object) this));

    /// <summary>
    /// Обработка пачки грязных данных из очереди на индексацию
    /// </summary>
    [Obsolete("Устарело. Используйте FullTextHandlerActor", true)]
    public void IndexQueueProcessing()
    {
    }

    /// <summary>
    /// Обработка пачки грязных данных из очереди на индексацию
    /// <remarks>Отсутствует проверка на конкурентность обработки. Следует вызывать только в коде, реализующем такой механизм.</remarks>
    /// </summary>
    internal void InternalIndexQueueProcessing()
    {
      int num1 = 2;
      IUnitOfWork unitOfWork;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_43;
          case 1:
            goto label_2;
          case 2:
            if (!this.IndexingIsWorking())
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 1;
              continue;
            }
            unitOfWork = ((IUnitOfWorkManager) IndexQueueManager.iPal6mGCo5SosxVD3aVo((object) this)).Create(string.Empty, true);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 3;
            continue;
          case 3:
            goto label_5;
          default:
            goto label_40;
        }
      }
label_43:
      return;
label_2:
      return;
label_40:
      return;
label_5:
      try
      {
        int num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
          num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 1:
              try
              {
                this.SecurityService.RunBySystemUser((System.Action) (() =>
                {
                  int num4 = 1;
                  while (true)
                  {
                    switch (num4)
                    {
                      case 0:
                        goto label_2;
                      case 1:
                        ((ISecurityService) IndexQueueManager.RHyEDpGCXsQ1IFlorLcI((object) this)).RunWithElevatedPrivilegies((System.Action) (() =>
                        {
                          int num5 = 1;
                          while (true)
                          {
                            switch (num5)
                            {
                              case 0:
                                goto label_2;
                              case 1:
                                this.Processing();
                                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 0 : 0;
                                continue;
                              default:
                                goto label_4;
                            }
                          }
label_2:
                          return;
label_4:;
                        }));
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_4;
                    }
                  }
label_2:
                  return;
label_4:;
                }));
                int num6 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
                  num6 = 0;
                while (true)
                {
                  switch (num6)
                  {
                    case 1:
                      goto label_8;
                    default:
                      unitOfWork.Commit();
                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 1 : 1;
                      continue;
                  }
                }
              }
              catch (StopIndexingException ex)
              {
                int num7 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0)
                  num7 = 1;
                while (true)
                {
                  switch (num7)
                  {
                    case 0:
                      goto label_36;
                    case 1:
                      unitOfWork.Commit();
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_35;
                  }
                }
label_36:
                return;
label_35:
                return;
              }
              catch (IndexingServerUnavailableException ex)
              {
                int num8 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
                  num8 = 0;
                while (true)
                {
                  switch (num8)
                  {
                    case 1:
                      goto label_33;
                    default:
                      unitOfWork.Commit();
                      num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 1 : 1;
                      continue;
                  }
                }
label_33:
                return;
              }
              catch (MappingServiceNotAvailableException ex)
              {
                int num9 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
                  num9 = 0;
                while (true)
                {
                  switch (num9)
                  {
                    case 1:
                      goto label_29;
                    default:
                      unitOfWork.Commit();
                      num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 1 : 0;
                      continue;
                  }
                }
label_29:
                return;
              }
              catch (Exception ex)
              {
                int num10 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
                  num10 = 1;
                while (true)
                {
                  switch (num10)
                  {
                    case 1:
                      IndexQueueManager.vDvMVoGCbwh8tddmgffV((object) unitOfWork);
                      num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_8;
                  }
                }
              }
            case 2:
              if (!this.HasIndexAllQueueForContinue())
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 2 : 3;
                continue;
              }
              goto label_5;
            case 3:
              IndexQueueManager.rQX5DTGCE3ukFqxsf50W((object) unitOfWork);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 4 : 3;
              continue;
            case 4:
              goto label_27;
          }
label_8:
          IndexQueueManager.KWqnsqGCGjbdPZarcfHx(IndexQueueManager.gTri96GCh5qHdW5A7xKA((object) this.SessionProvider, (object) string.Empty));
          num2 = 2;
        }
label_27:;
      }
      finally
      {
        int num11;
        if (unitOfWork == null)
          num11 = 2;
        else
          goto label_41;
label_39:
        switch (num11)
        {
          case 1:
            break;
          default:
        }
label_41:
        unitOfWork.Dispose();
        num11 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
        {
          num11 = 0;
          goto label_39;
        }
        else
          goto label_39;
      }
    }

    /// <summary>Обработка пачки из очереди индексации</summary>
    private bool Processing()
    {
      int num1 = 8;
      ICollection<IIndexQueue> source1;
      IFullTextTypeMappingAvailability mappingAvailability;
      while (true)
      {
        int num2 = num1;
        ICollection<IIndexQueue> source2;
        List<IIndexQueue> itemsForIndex;
        List<IIndexQueue> itemsForClear;
        IEnumerator<IIndexQueue> enumerator1;
        Dictionary<long, long> dictionary1;
        IIndexQueueFilter filter1;
        FetchOptions fetchOptions1;
        List<IIndexQueue> indexQueueList1;
        IIndexQueueFilter filter2;
        FetchOptions fetchOptions2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_129;
            case 2:
              ((ICacheService) IndexQueueManager.TPo866GQarVj9TuSRtYb()).ClearRegion((string) IndexQueueManager.rMfQq0GQDS3LR61R8L47(-1886646897 ^ -1886401167));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 22 : 9;
              continue;
            case 3:
              try
              {
                if (IndexQueueManager.prnUOBGCI0hdi65LIbMO((object) dictionary1) > 0)
                {
                  int num3 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
                    num3 = 6;
                  Dictionary<long, long>.Enumerator enumerator2;
                  Dictionary<long, long> dictionary2;
                  string sql;
                  Dictionary<string, object> paramValues;
                  IDataReader dataReader;
                  while (true)
                  {
                    switch (num3)
                    {
                      case 1:
                        paramValues = new Dictionary<string, object>()
                        {
                          {
                            (string) IndexQueueManager.rMfQq0GQDS3LR61R8L47(-105199646 ^ -105312270),
                            (object) true
                          }
                        };
                        num3 = 3;
                        continue;
                      case 2:
                        goto label_124;
                      case 3:
                        dictionary2 = new Dictionary<long, long>();
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
                        continue;
                      case 4:
                        goto label_78;
                      case 5:
label_114:
                        enumerator2 = dictionary1.GetEnumerator();
                        num3 = 4;
                        continue;
                      case 6:
                        sql = string.Format((string) IndexQueueManager.rMfQq0GQDS3LR61R8L47(1597012150 ^ 1597226964), (object) ((Dialect) IndexQueueManager.UMoj6oGQHa5AGZZM7hKv((object) this.TransformationProvider)).QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099538333)), IndexQueueManager.k4TYYXGQAiFtvrVK4rAy(IndexQueueManager.UMoj6oGQHa5AGZZM7hKv((object) this.TransformationProvider), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1505778440 - 1981636111 ^ -475890265)), (object) this.TransformationProvider.Dialect.QuoteIfNeeded((string) IndexQueueManager.rMfQq0GQDS3LR61R8L47(-244066886 - -48452443 ^ -195698697)), (object) ((Dialect) IndexQueueManager.UMoj6oGQHa5AGZZM7hKv((object) this.TransformationProvider)).QuoteIfNeeded((string) IndexQueueManager.rMfQq0GQDS3LR61R8L47(-630932142 - 1120244082 ^ -1751323624)), (object) this.TransformationProvider.ParameterSeparator);
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 1 : 1;
                        continue;
                      case 7:
                        try
                        {
label_101:
                          if (IndexQueueManager.dqxoQVGCSeuTXoWMDjMN((object) dataReader))
                            goto label_98;
                          else
                            goto label_102;
label_96:
                          long int64;
                          long num4;
                          int num5;
                          while (true)
                          {
                            switch (num5)
                            {
                              case 1:
                              case 6:
                              case 7:
                                goto label_101;
                              case 2:
                                if (!dictionary1.ContainsKey(int64))
                                {
                                  num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 1;
                                  continue;
                                }
                                goto case 4;
                              case 3:
                                goto label_114;
                              case 4:
                                dictionary2.Add(int64, num4);
                                num5 = 6;
                                continue;
                              case 5:
                                num4 = IndexQueueManager.rC4jCKGQMqoydlwsoqlh(IndexQueueManager.jcsq2TGCVDXalNGxp2pd((object) dataReader, 1));
                                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 0 : 0;
                                continue;
                              case 8:
                                goto label_98;
                              default:
                                if (dictionary2.ContainsKey(int64))
                                {
                                  num5 = 7;
                                  continue;
                                }
                                goto case 2;
                            }
                          }
label_98:
                          int64 = Convert.ToInt64(IndexQueueManager.jcsq2TGCVDXalNGxp2pd((object) dataReader, 0));
                          num5 = 5;
                          goto label_96;
label_102:
                          num5 = 3;
                          goto label_96;
                        }
                        finally
                        {
                          if (dataReader != null)
                          {
                            int num6 = 0;
                            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
                              num6 = 0;
                            while (true)
                            {
                              switch (num6)
                              {
                                case 1:
                                  goto label_111;
                                default:
                                  IndexQueueManager.fkWwVQGCFbH6EYExRcw9((object) dataReader);
                                  num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 1 : 1;
                                  continue;
                              }
                            }
                          }
label_111:;
                        }
                      default:
                        dataReader = this.TransformationProvider.ExecuteQuery(sql, paramValues);
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 7 : 6;
                        continue;
                    }
                  }
label_78:
                  try
                  {
label_80:
                    if (enumerator2.MoveNext())
                      goto label_84;
                    else
                      goto label_81;
label_79:
                    KeyValuePair<long, long> current;
                    int num7;
                    while (true)
                    {
                      switch (num7)
                      {
                        case 1:
                          if (dictionary2[current.Key] == current.Value)
                          {
                            num7 = 5;
                            continue;
                          }
                          goto label_80;
                        case 2:
                          goto label_84;
                        case 3:
                          goto label_124;
                        case 4:
                          if (dictionary2.ContainsKey(current.Key))
                          {
                            num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 1 : 1;
                            continue;
                          }
                          goto case 5;
                        case 5:
                          IndexQueueManager.cZtNv0GCieBFW8xFilMN((object) IndexQueueManager.CacheService, IndexQueueManager.SohwcfGQtday0DXOMFvZ(IndexQueueManager.rMfQq0GQDS3LR61R8L47(-740338220 ^ -740420802), IndexQueueManager.rMfQq0GQDS3LR61R8L47(2045296739 + 1688595713 ^ -561156710), (object) current.Key), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1253244298 - 1829393894 ^ -575969446));
                          num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 0 : 0;
                          continue;
                        default:
                          goto label_80;
                      }
                    }
label_81:
                    num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 1 : 3;
                    goto label_79;
label_84:
                    current = enumerator2.Current;
                    num7 = 4;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
                    {
                      num7 = 1;
                      goto label_79;
                    }
                    else
                      goto label_79;
                  }
                  finally
                  {
                    enumerator2.Dispose();
                    int num8 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
                      num8 = 0;
                    switch (num8)
                    {
                      default:
                    }
                  }
                }
                else
                  goto default;
              }
              catch (Exception ex)
              {
                int num9 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
                  num9 = 1;
                while (true)
                {
                  switch (num9)
                  {
                    case 1:
                      IndexQueueManager.k6iqAQGQgtiYXt5yWG9y((object) IndexQueueManager.IndexLog, (object) ex);
                      num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 0 : 0;
                      continue;
                    case 2:
                      goto label_124;
                    default:
                      IndexQueueManager.z7P7cZGCvkmqLpkW9vCX(IndexQueueManager.TPo866GQarVj9TuSRtYb(), IndexQueueManager.rMfQq0GQDS3LR61R8L47(1470440286 ^ 1470555040));
                      num9 = 2;
                      continue;
                  }
                }
              }
            case 4:
              FetchOptions fetchOptions3 = new FetchOptions();
              IndexQueueManager.rT5KaiGC8rGEuWpIhAPl((object) fetchOptions3, 100);
              IndexQueueManager.XJ7mA4GQJZVJMOJL8Gh6((object) fetchOptions3, IndexQueueManager.rMfQq0GQDS3LR61R8L47(~210725948 ^ -210759011));
              fetchOptions2 = fetchOptions3;
              num2 = 6;
              continue;
            case 5:
              goto label_69;
            case 6:
              source2 = this.Find((IEntityFilter) filter2, fetchOptions2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 3 : 24;
              continue;
            case 7:
              goto label_134;
            case 8:
              if (!this.IsIndexingOn())
              {
                num2 = 7;
                continue;
              }
              if (this.IndexingIsWorking())
              {
                num2 = 9;
                continue;
              }
              goto label_129;
            case 9:
              mappingAvailability = (IFullTextTypeMappingAvailability) IndexQueueManager.AL5FMpGCfT1HlyuYH14R((object) this.MappingService);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 26 : 1;
              continue;
            case 10:
              List<IIndexQueue> source3 = itemsForIndex;
              // ISSUE: reference to a compiler-generated field
              System.Func<IIndexQueue, long> func = IndexQueueManager.\u003C\u003Ec.\u003C\u003E9__39_3;
              System.Func<IIndexQueue, long> keySelector;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                IndexQueueManager.\u003C\u003Ec.\u003C\u003E9__39_3 = keySelector = (System.Func<IIndexQueue, long>) (i => i.Id);
              }
              else
                goto label_153;
label_146:
              enumerator1 = source3.OrderBy<IIndexQueue, long>(keySelector).GetEnumerator();
              num2 = 14;
              continue;
label_153:
              keySelector = func;
              goto label_146;
            case 11:
              this.MergeBlanks(source2.ToList<IIndexQueue>(), out itemsForIndex, out itemsForClear);
              num2 = 10;
              continue;
            case 12:
              goto label_27;
            case 13:
              if (IndexQueueManager.mFnGYHGCCfUZM3iEX2vi((object) source1) <= 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 10 : 20;
                continue;
              }
              goto label_69;
            case 14:
              try
              {
label_60:
                if (IndexQueueManager.jnqeyoGQzGCacFmWvxVP((object) enumerator1))
                  goto label_31;
                else
                  goto label_61;
label_30:
                int num10;
                while (true)
                {
                  switch (num10)
                  {
                    case 1:
                      goto label_60;
                    case 2:
                      goto label_31;
                    case 3:
                      goto label_34;
                    case 4:
                      goto label_72;
                    case 5:
                      if (!this.IsIndexingOn())
                      {
                        num10 = 3;
                        continue;
                      }
                      num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_36;
                  }
                }
label_34:
                throw new StopIndexingException();
label_36:
                IIndexQueue current;
                try
                {
                  IndexQueueType? queueType = current.QueueType;
                  int num11 = 6;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
                    num11 = 3;
                  IndexQueueType valueOrDefault;
                  while (true)
                  {
                    switch (num11)
                    {
                      case 2:
                        indexQueueList1.Add(current);
                        num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 1 : 1;
                        continue;
                      case 3:
label_47:
                        if (!this.IndexByType(current))
                        {
                          num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 4 : 1;
                          continue;
                        }
                        goto case 8;
                      case 5:
                        switch (valueOrDefault)
                        {
                          case IndexQueueType.IndexByType:
                            goto label_47;
                          case IndexQueueType.IndexObject:
                            goto label_45;
                          case IndexQueueType.ReIndexObject:
                            goto label_60;
                          case IndexQueueType.ReIndexObjectPart:
                            goto label_43;
                          default:
                            num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 1 : 7;
                            continue;
                        }
                      case 6:
                        if (!queueType.HasValue)
                        {
                          num11 = 12;
                          continue;
                        }
                        goto case 13;
                      case 8:
                        indexQueueList1.Add(current);
                        num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
                        continue;
                      case 9:
label_45:
                        this.IndexObject(current);
                        num11 = 10;
                        continue;
                      case 10:
                        indexQueueList1.Add(current);
                        num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 4 : 14;
                        continue;
                      case 11:
label_43:
                        this.ReIndexObjectPart(current);
                        num11 = 2;
                        continue;
                      case 13:
                        valueOrDefault = queueType.GetValueOrDefault();
                        num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 4 : 5;
                        continue;
                      default:
                        goto label_60;
                    }
                  }
                }
                catch (StopIndexingException ex)
                {
                  int num12 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0)
                    num12 = 0;
                  switch (num12)
                  {
                    default:
                      throw;
                  }
                }
                catch (Exception ex)
                {
                  int num13 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
                    num13 = 1;
                  while (true)
                  {
                    switch (num13)
                    {
                      case 1:
                        IndexQueueManager.NBSFoKGCul9oJHvV8gkI((object) IndexQueueManager.IndexLog, IndexQueueManager.UpOcGWGQ7iPBS2tcNYKs(IndexQueueManager.rMfQq0GQDS3LR61R8L47(-1350312861 << 3 ^ 2082284600), IndexQueueManager.jkY6eOGCZN3eEffwbCOa((object) ex)), (object) ex);
                        num13 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_60;
                    }
                  }
                }
label_31:
                current = enumerator1.Current;
                num10 = 5;
                goto label_30;
label_61:
                num10 = 4;
                goto label_30;
              }
              finally
              {
                if (enumerator1 != null)
                {
                  int num14 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
                    num14 = 0;
                  while (true)
                  {
                    switch (num14)
                    {
                      case 1:
                        goto label_67;
                      default:
                        IndexQueueManager.fkWwVQGCFbH6EYExRcw9((object) enumerator1);
                        num14 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 1 : 1;
                        continue;
                    }
                  }
                }
label_67:;
              }
            case 15:
label_72:
              if (this.IndexingIsWorking())
              {
                num2 = 3;
                continue;
              }
              goto label_138;
            case 16:
              dictionary1 = new Dictionary<long, long>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 27 : 23;
              continue;
            case 17:
              goto label_120;
            case 18:
              if (IndexQueueManager.vaZMNHGCRNR7JMiZ6Vvo((object) itemsForClear) > 0)
              {
                num2 = 28;
                continue;
              }
              goto label_138;
            case 19:
              filter2.QueueType = new List<IndexQueueType>()
              {
                IndexQueueType.IndexByType,
                IndexQueueType.IndexObject,
                IndexQueueType.ReIndexObject,
                IndexQueueType.ReIndexObjectPart
              };
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 4 : 1;
              continue;
            case 20:
              filter2 = InterfaceActivator.Create<IIndexQueueFilter>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 6 : 19;
              continue;
            case 21:
              source1 = this.Find((IEntityFilter) filter1, fetchOptions1);
              num2 = 13;
              continue;
            case 22:
            case 31:
              goto label_138;
            case 23:
              List<IIndexQueue> indexQueueList2 = indexQueueList1;
              // ISSUE: reference to a compiler-generated field
              Action<IIndexQueue> action1 = IndexQueueManager.\u003C\u003Ec.\u003C\u003E9__39_0;
              Action<IIndexQueue> action2;
              if (action1 == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                IndexQueueManager.\u003C\u003Ec.\u003C\u003E9__39_0 = action2 = (Action<IIndexQueue>) (i => IndexQueueManager.\u003C\u003Ec.dZSbm8vjEhjnRFYXqyvL((object) i));
              }
              else
                goto label_154;
label_149:
              indexQueueList2.ForEach(action2);
              num2 = 18;
              continue;
label_154:
              action2 = action1;
              goto label_149;
            case 24:
              if (IndexQueueManager.mFnGYHGCCfUZM3iEX2vi((object) source2) <= 0)
                goto case 2;
              else
                goto label_128;
            case 25:
label_68:
              indexQueueList1 = new List<IIndexQueue>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 7 : 11;
              continue;
            case 26:
              if (IndexQueueManager.gqnGNjGCQKciI9nZLc0U((object) mappingAvailability))
              {
                filter1 = InterfaceActivator.Create<IIndexQueueFilter>();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 12 : 4;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 17 : 13;
              continue;
            case 27:
              enumerator1 = source2.Where<IIndexQueue>((System.Func<IIndexQueue, bool>) (i =>
              {
                int num15 = 1;
                bool flag;
                bool? visualData;
                while (true)
                {
                  switch (num15)
                  {
                    case 1:
                      visualData = i.VisualData;
                      num15 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
                      continue;
                    case 2:
                      goto label_4;
                    default:
                      flag = true;
                      num15 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 2 : 0;
                      continue;
                  }
                }
label_4:
                return visualData.GetValueOrDefault() == flag & visualData.HasValue;
              })).GetEnumerator();
              num2 = 29;
              continue;
            case 28:
              List<IIndexQueue> indexQueueList3 = itemsForClear;
              // ISSUE: reference to a compiler-generated field
              Action<IIndexQueue> action3 = IndexQueueManager.\u003C\u003Ec.\u003C\u003E9__39_1;
              Action<IIndexQueue> action4;
              if (action3 == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                IndexQueueManager.\u003C\u003Ec.\u003C\u003E9__39_1 = action4 = (Action<IIndexQueue>) (i => IndexQueueManager.\u003C\u003Ec.dZSbm8vjEhjnRFYXqyvL((object) i));
              }
              else
                goto label_155;
label_152:
              indexQueueList3.ForEach(action4);
              num2 = 31;
              continue;
label_155:
              action4 = action3;
              goto label_152;
            case 29:
              try
              {
label_8:
                if (IndexQueueManager.jnqeyoGQzGCacFmWvxVP((object) enumerator1))
                  goto label_13;
                else
                  goto label_9;
label_7:
                IIndexQueue current;
                long? creationAuthorId;
                long key;
                int num16;
                while (true)
                {
                  switch (num16)
                  {
                    case 1:
                      if (!creationAuthorId.HasValue)
                      {
                        num16 = 7;
                        continue;
                      }
                      goto case 5;
                    case 2:
                      goto label_13;
                    case 3:
                    case 7:
                    case 11:
                      goto label_8;
                    case 4:
                      goto label_68;
                    case 5:
                      creationAuthorId = current.CreationAuthorId;
                      num16 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
                      continue;
                    case 6:
                    case 9:
                      dictionary1.Add(key, 1L);
                      num16 = 3;
                      continue;
                    case 8:
                      dictionary1[key]++;
                      num16 = 11;
                      continue;
                    case 10:
                      if (!dictionary1.ContainsKey(key))
                      {
                        num16 = 9;
                        continue;
                      }
                      goto case 8;
                    case 12:
                      creationAuthorId = current.CreationAuthorId;
                      num16 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 1;
                      continue;
                    default:
                      key = creationAuthorId.Value;
                      num16 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 10 : 6;
                      continue;
                  }
                }
label_9:
                num16 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 3 : 4;
                goto label_7;
label_13:
                current = enumerator1.Current;
                num16 = 11;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
                {
                  num16 = 12;
                  goto label_7;
                }
                else
                  goto label_7;
              }
              finally
              {
                int num17;
                if (enumerator1 == null)
                  num17 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
                else
                  goto label_24;
label_23:
                switch (num17)
                {
                  case 2:
                    break;
                  default:
                }
label_24:
                IndexQueueManager.fkWwVQGCFbH6EYExRcw9((object) enumerator1);
                num17 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
                {
                  num17 = 0;
                  goto label_23;
                }
                else
                  goto label_23;
              }
            case 30:
              FetchOptions fetchOptions4 = new FetchOptions();
              IndexQueueManager.XJ7mA4GQJZVJMOJL8Gh6((object) fetchOptions4, IndexQueueManager.rMfQq0GQDS3LR61R8L47(-867826612 ^ -867793646));
              fetchOptions1 = fetchOptions4;
              num2 = 21;
              continue;
            default:
label_124:
              if (IndexQueueManager.vaZMNHGCRNR7JMiZ6Vvo((object) indexQueueList1) > 0)
              {
                num2 = 23;
                continue;
              }
              goto case 18;
          }
        }
label_27:
        filter1.QueueType = new List<IndexQueueType>()
        {
          IndexQueueType.IndexAll
        };
        num1 = 30;
        continue;
label_128:
        num1 = 16;
      }
label_69:
      int num18 = this.IndexAll(source1.Last<IIndexQueue>()) ? 1 : 0;
      IndexQueueManager.z7P7cZGCvkmqLpkW9vCX(IndexQueueManager.TPo866GQarVj9TuSRtYb(), IndexQueueManager.rMfQq0GQDS3LR61R8L47(-1255365154 ^ 596875508 ^ -1765999148));
      return num18 != 0;
label_120:
      throw new MappingServiceNotAvailableException((IEnumerable<string>) mappingAvailability.Errors);
label_129:
      throw new IndexingServerUnavailableException();
label_134:
      throw new StopIndexingException();
label_138:
      return true;
    }

    /// <summary>Добавление элемента очереди частичной переиндексации</summary>
    public void AddReindexObjectPartItem(
      Type cardType,
      long objectId,
      Guid objectTypeUid,
      List<KeyValuePair<string, object>> listPairs,
      bool visualData = false)
    {
      Guid? cardUidByCardType = this.FullTextSearchCardService.GetCardUidByCardType(cardType);
      if (!cardUidByCardType.HasValue)
        return;
      this.AddReindexObjectPartItem(cardUidByCardType.Value, objectId, objectTypeUid, listPairs, visualData);
    }

    /// <summary>Добавление элемента очереди частичной переиндексации</summary>
    public void AddReindexObjectPartItem(
      Guid cardUid,
      long objectId,
      Guid objectTypeUid,
      List<KeyValuePair<string, object>> listPairs,
      bool visualData = false)
    {
      if (cardUid == Guid.Empty)
        return;
      this.CreateReindexObjectPartItem(cardUid, objectId, objectTypeUid, listPairs, visualData)?.Save();
    }

    /// <summary>Добавление элемента очереди частичной переиндексации</summary>
    /// <param name="cardType">Тип карточки объекта</param>
    /// <param name="objectId">Идентификатор объекта</param>
    /// <param name="objectTypeUid">Уникальный идентификатор типа</param>
    /// <param name="listPairs">Измененные данные</param>
    /// <param name="visualData">Наличие визуальных данных</param>
    /// <returns><see cref="T:EleWise.ELMA.FullTextSearch.Model.IIndexQueue" /></returns>
    public IIndexQueue CreateReindexObjectPartItem(
      Type cardType,
      long objectId,
      Guid objectTypeUid,
      List<KeyValuePair<string, object>> listPairs,
      bool visualData = false)
    {
      Guid? cardUidByCardType = this.FullTextSearchCardService.GetCardUidByCardType(cardType);
      return cardUidByCardType.HasValue ? this.CreateReindexObjectPartItem(cardUidByCardType.Value, objectId, objectTypeUid, listPairs, visualData) : (IIndexQueue) null;
    }

    /// <summary>Создание элемента очереди частичной переиндексации</summary>
    /// <param name="cardUid">Уникальный идентификатор типа карточки объекта</param>
    /// <param name="objectId">Идентификатор объекта</param>
    /// <param name="objectTypeUid">Уникальный идентификатор типа</param>
    /// <param name="listPairs">Измененные данные</param>
    /// <param name="visualData">Наличие визуальных данных</param>
    /// <returns><see cref="T:EleWise.ELMA.FullTextSearch.Model.IIndexQueue" /></returns>
    public IIndexQueue CreateReindexObjectPartItem(
      Guid cardUid,
      long objectId,
      Guid objectTypeUid,
      List<KeyValuePair<string, object>> listPairs,
      bool visualData = false)
    {
      if (cardUid == Guid.Empty)
        return (IIndexQueue) null;
      List<string> values = new List<string>();
      if (listPairs == null || !listPairs.Any<KeyValuePair<string, object>>())
        return (IIndexQueue) null;
      foreach (KeyValuePair<string, object> listPair in listPairs)
      {
        if (!string.IsNullOrWhiteSpace(listPair.Key))
        {
          byte[] numArray = ClassSerializationHelper.SerializeObject((object) new KeyValuePair<string, object>(listPair.Key, listPair.Value));
          values.Add(BitConverter.ToString(numArray).Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1178210108 ^ 1178206544), ""));
        }
      }
      IIndexQueue reindexObjectPartItem = InterfaceActivator.Create<IIndexQueue>();
      reindexObjectPartItem.DirtyValues = string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1574260816 ^ 1574259970), (IEnumerable<string>) values);
      reindexObjectPartItem.CardTypeUid = new Guid?(cardUid);
      reindexObjectPartItem.ObjectId = new long?(objectId);
      reindexObjectPartItem.ObjectTypeUid = new Guid?(objectTypeUid);
      reindexObjectPartItem.QueueType = new IndexQueueType?(IndexQueueType.ReIndexObjectPart);
      reindexObjectPartItem.VisualData = new bool?(visualData);
      return reindexObjectPartItem;
    }

    public IndexQueueManager()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static IndexQueueManager()
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            IndexQueueManager.IndexQueueListContextKeyConst = (string) IndexQueueManager.rMfQq0GQDS3LR61R8L47(-787452571 ^ -787241641);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
            continue;
          case 2:
            IndexQueueManager.IndexLog = (ILogger) IndexQueueManager.AJvsL1GCKC15DQdQpsIB(IndexQueueManager.rMfQq0GQDS3LR61R8L47(44884861 ^ 45079533));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 1 : 1;
            continue;
          case 3:
            IndexQueueManager.huGS4SGCqOAmPcKT4DVn();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 2 : 2;
            continue;
          default:
            goto label_6;
        }
      }
label_2:
      return;
label_6:;
    }

    internal static bool piUJfkGQ1lmoICVawQLS() => IndexQueueManager.i8L63YGQPIi9XJXjODLh == null;

    internal static IndexQueueManager g3g1TcGQNSsePB90neuR() => IndexQueueManager.i8L63YGQPIi9XJXjODLh;

    internal static object wA8TeVGQ3Uj6UARs3Gp7([In] object obj0) => (object) ((EntityManager<IIndexQueue, long>) obj0).AuthenticationService;

    internal static object PjoolAGQpMVuZ8hQHCwU([In] object obj0) => ((IIdentified) obj0).GetId();

    internal static object TPo866GQarVj9TuSRtYb() => (object) IndexQueueManager.CacheService;

    internal static object rMfQq0GQDS3LR61R8L47(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object SohwcfGQtday0DXOMFvZ([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static object klo5B0GQwkL3UT8bQ7lx([In] object obj0) => (object) ((IAuthenticationService) obj0).GetCurrentUser();

    internal static bool oXNnmQGQ4LWj6KBY4eTF([In] object obj0, [In] object obj1, [In] object obj2) => ((ICacheService) obj0).Contains((string) obj1, (string) obj2);

    internal static bool F8hpPeGQ6VRO9BiAk8NQ([In] object obj0, [In] object obj1) => __nonvirtual (((EntityManager<IIndexQueue, long>) obj0).Exists((IEntityFilter) obj1));

    internal static object UMoj6oGQHa5AGZZM7hKv([In] object obj0) => (object) ((ITransformationProvider) obj0).Dialect;

    internal static object k4TYYXGQAiFtvrVK4rAy([In] object obj0, [In] object obj1) => (object) ((Dialect) obj0).QuoteIfNeeded((string) obj1);

    internal static object UpOcGWGQ7iPBS2tcNYKs([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static object Sy3OOEGQxV2xCVb8u1dK([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Substring(obj1, obj2);

    internal static byte spB5MiGQ0mTMuxC9LgKY([In] object obj0, [In] int obj1) => Convert.ToByte((string) obj0, obj1);

    internal static object IpakLTGQme0cJLTV889k([In] object obj0) => (object) ((ITransformationProvider) obj0).ParameterSeparator;

    internal static object uANvCPGQyU30dArwmDq1([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, (object[]) obj1);

    internal static long rC4jCKGQMqoydlwsoqlh([In] object obj0) => Convert.ToInt64(obj0);

    internal static void XJ7mA4GQJZVJMOJL8Gh6([In] object obj0, [In] object obj1) => ((FetchOptions) obj0).SortExpression = (string) obj1;

    internal static object NOcmpmGQ9sudnlC0bSHe([In] object obj0) => (object) ((IIndexQueue) obj0).DirtyValues;

    internal static bool y2j8kpGQdoowRXi1eXCB([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static long QXXkE5GQlnDaLqhRGCpX([In] object obj0) => ((IIndexQueue) obj0).Attempt;

    internal static object ykPnvsGQrFK86K9Je66g([In] object obj0) => (object) ((EntityManager<IIndexQueue, long>) obj0).FullTextSearchService;

    internal static void k6iqAQGQgtiYXt5yWG9y([In] object obj0, [In] object obj1) => ((ILogger) obj0).Error(obj1);

    internal static object Q2ni16GQ58UmKva214JP([In] object obj0) => (object) ((EntityManager<IIndexQueue, long>) obj0).FullTextSearchCardService;

    internal static Type SIu2N1GQj6Kc0yjN3apa([In] object obj0, Guid cardUid) => ((IFullTextSearchCardService) obj0).GetCardTypeByCardUid(cardUid);

    internal static bool trThAcGQYXb2rpC1RCDI([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static void WyeK25GQLaC7fjY2bHDC([In] object obj0, Type cardType) => ((IFullTextSearchService) obj0).StopIndexingType(cardType);

    internal static object Kd5m3EGQUSotUch9Nlhr([In] object obj0, [In] object obj1) => (object) ((IFullTextSearchServiceReIndexingTypeExtension) obj0).ReIndexingByType((IIndexQueue) obj1);

    internal static void BsumQEGQsupi7sKIrsWx([In] object obj0, long value) => ((IIndexQueue) obj0).Attempt = value;

    internal static bool qfa6LCGQceYekEv9vGmy([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static bool jnqeyoGQzGCacFmWvxVP([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void fkWwVQGCFbH6EYExRcw9([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static FullTextSearchState rbiHaVGCBnyKaogqpbQH([In] object obj0) => ((IFullTextSearchService) obj0).GetIndexState();

    internal static bool nmmUsEGCWxjrRf1gXdUb([In] object obj0) => ((IFullTextSearchService) obj0).IndexingIsWorking();

    internal static object iPal6mGCo5SosxVD3aVo([In] object obj0) => (object) ((EntityManager<IIndexQueue, long>) obj0).UnitOfWorkManager;

    internal static void vDvMVoGCbwh8tddmgffV([In] object obj0) => ((IUnitOfWork) obj0).Rollback();

    internal static object gTri96GCh5qHdW5A7xKA([In] object obj0, [In] object obj1) => (object) ((ISessionProvider) obj0).GetSession((string) obj1);

    internal static void KWqnsqGCGjbdPZarcfHx([In] object obj0) => ((ISession) obj0).Clear();

    internal static void rQX5DTGCE3ukFqxsf50W([In] object obj0) => ((IUnitOfWork) obj0).Commit();

    internal static object AL5FMpGCfT1HlyuYH14R([In] object obj0) => (object) ((IFullTextTypeMappingServiceExt) obj0).CheckAvailability();

    internal static bool gqnGNjGCQKciI9nZLc0U([In] object obj0) => ((IFullTextTypeMappingAvailability) obj0).IsAvailable;

    internal static int mFnGYHGCCfUZM3iEX2vi([In] object obj0) => ((ICollection<IIndexQueue>) obj0).Count;

    internal static void z7P7cZGCvkmqLpkW9vCX([In] object obj0, [In] object obj1) => ((ICacheService) obj0).ClearRegion((string) obj1);

    internal static void rT5KaiGC8rGEuWpIhAPl([In] object obj0, int value) => ((FetchOptions) obj0).MaxResults = value;

    internal static object jkY6eOGCZN3eEffwbCOa([In] object obj0) => (object) ((Exception) obj0).Message;

    internal static void NBSFoKGCul9oJHvV8gkI([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static int prnUOBGCI0hdi65LIbMO([In] object obj0) => ((Dictionary<long, long>) obj0).Count;

    internal static object jcsq2TGCVDXalNGxp2pd([In] object obj0, [In] int obj1) => ((IDataRecord) obj0)[obj1];

    internal static bool dqxoQVGCSeuTXoWMDjMN([In] object obj0) => ((IDataReader) obj0).Read();

    internal static void cZtNv0GCieBFW8xFilMN([In] object obj0, [In] object obj1, [In] object obj2) => ((ICacheService) obj0).Remove((string) obj1, (string) obj2);

    internal static int vaZMNHGCRNR7JMiZ6Vvo([In] object obj0) => ((List<IIndexQueue>) obj0).Count;

    internal static void huGS4SGCqOAmPcKT4DVn() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object AJvsL1GCKC15DQdQpsIB([In] object obj0) => (object) EleWise.ELMA.Logging.Logger.GetLogger((string) obj0);

    internal static object RHyEDpGCXsQ1IFlorLcI([In] object obj0) => (object) ((EntityManager<IIndexQueue, long>) obj0).SecurityService;
  }
}
