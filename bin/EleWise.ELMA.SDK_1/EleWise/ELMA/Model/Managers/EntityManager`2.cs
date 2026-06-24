// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Managers.EntityManager`2
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Actions;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Extensions.NHibernateLinqExtensions;
using EleWise.ELMA.FullTextSearch.Exceptions;
using EleWise.ELMA.FullTextSearch.ExtensionPoints;
using EleWise.ELMA.FullTextSearch.Manager;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.FullTextSearch.Services;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Filters;
using EleWise.ELMA.Model.Managers.EQL;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Context;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Runtime.Providers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Collection;
using NHibernate.Criterion;
using NHibernate.Engine;
using NHibernate.Persister.Entity;
using NHibernate.Proxy;
using NHibernate.SqlCommand;
using NHibernate.Transform;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.Caching;
using System.Threading;

namespace EleWise.ELMA.Model.Managers
{
  /// <summary>
  /// Базовый типизированный менеджер сущности с идентификатором
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <typeparam name="IdT"></typeparam>
  [DeveloperApi(DeveloperApiType.Manager)]
  public class EntityManager<T, IdT> : 
    AbstractNHEntityManager<T, IdT>,
    IEntityExistsManager,
    IEntityManagerAlias
    where T : IEntity<IdT>
  {
    private static readonly ILogger IndexLog;
    private static MemoryCache memoryCache;
    private static readonly object locker;
    /// <summary>
    /// Настройки работы с MemoryCache по умолчанию для всех классов
    /// </summary>
    private static CacheItemPolicy DefaultCacheItemPolicy;
    private bool authenticationServiceExists;
    private bool securityServiceExists;
    private IndexQueueManager indexQueueManager;
    private RunWithSoftDeletableService runWithSoftDeletableService;
    private readonly NestedScopeComponents<IEntityManagerBehavior> behaviors;
    private bool? hasUidProperty;
    private PropertyMetadata uidPropertyMetadata;
    private Type implementationType;
    private string entityName;
    private Guid implementationTypeUid;
    private bool? isTablePart;
    private string entityTypeUidPropertyName;
    internal static object uNnDhfhvZuDlpgSRtlRK;

    /// <summary>Системный кэш для сохранения связки Uid и Id сущности</summary>
    private static MemoryCache MemoryCache
    {
      get
      {
        int num1 = 1;
        bool lockTaken;
        object locker;
        while (true)
        {
          switch (num1)
          {
            case 1:
              if (EntityManager<T, IdT>.memoryCache != null)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
                continue;
              }
              goto case 3;
            case 2:
              goto label_5;
            case 3:
              locker = EntityManager<T, IdT>.locker;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 4;
              continue;
            case 4:
              lockTaken = false;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 2 : 0;
              continue;
            default:
              goto label_3;
          }
        }
label_3:
        return EntityManager<T, IdT>.memoryCache;
label_5:
        try
        {
          Monitor.Enter(locker, ref lockTaken);
          int num2 = 2;
          while (true)
          {
            switch (num2)
            {
              case 1:
                EntityManager<T, IdT>.memoryCache = new MemoryCache(EntityManager<T, IdT>.GetCacheForUidName());
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 0 : 0;
                continue;
              case 2:
                if (EntityManager<T, IdT>.memoryCache == null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 1;
                  continue;
                }
                goto label_3;
              default:
                goto label_3;
            }
          }
        }
        finally
        {
          if (lockTaken)
          {
            int num3 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
              num3 = 0;
            while (true)
            {
              switch (num3)
              {
                case 1:
                  goto label_15;
                default:
                  Monitor.Exit(locker);
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 1 : 1;
                  continue;
              }
            }
          }
label_15:;
        }
      }
    }

    /// <summary>Провайдер трансформации БД</summary>
    [NotNull]
    public ITransformationProvider Transformation
    {
      get => this.\u003CTransformation\u003Ek__BackingField;
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
              this.\u003CTransformation\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 0 : 0;
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

    /// <summary>Сервис работы с метаданными</summary>
    [NotNull]
    public IMetadataRuntimeService MetadataRuntimeService
    {
      get => this.\u003CMetadataRuntimeService\u003Ek__BackingField;
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
              this.\u003CMetadataRuntimeService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 0 : 0;
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

    /// <summary>Сервис работы с кэшем</summary>
    [NotNull]
    public IMemoryCacheService MemoryCacheService => Locator.GetServiceNotNull<IMemoryCacheService>();

    /// <summary>Обработчик действий с сущностью</summary>
    [NotNull]
    public IEntityActionHandler ActionHandler
    {
      get => this.\u003CActionHandler\u003Ek__BackingField;
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
              this.\u003CActionHandler\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
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

    /// <summary>Сервис аутентификации, работа с текущим пользователем</summary>
    [NotNull]
    public IAuthenticationService AuthenticationService => Locator.GetServiceNotNull<IAuthenticationService>();

    protected bool AuthenticationServiceExists
    {
      get
      {
        int num = 1;
        bool authenticationServiceExists;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (!this.authenticationServiceExists)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 0;
                continue;
              }
              goto label_4;
            case 2:
              goto label_3;
            default:
              this.authenticationServiceExists = authenticationServiceExists = Locator.GetService<IAuthenticationService>() != null;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 1 : 2;
              continue;
          }
        }
label_3:
        return authenticationServiceExists;
label_4:
        return true;
      }
    }

    /// <summary>Сервис работы с действиями</summary>
    [NotNull]
    public ActionDispatcherService ActionDispatcherService
    {
      get => this.\u003CActionDispatcherService\u003Ek__BackingField;
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
              this.\u003CActionDispatcherService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 0 : 0;
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

    /// <summary>Логгер</summary>
    [NotNull]
    public ILogger Logger
    {
      get => this.\u003CLogger\u003Ek__BackingField;
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
              this.\u003CLogger\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 0;
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

    /// <summary>Провайдер единиц работы unit-of-work</summary>
    [NotNull]
    public IUnitOfWorkManager UnitOfWorkManager
    {
      get => this.\u003CUnitOfWorkManager\u003Ek__BackingField;
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
              this.\u003CUnitOfWorkManager\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
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

    /// <summary>Провайдер основной БД</summary>
    [NotNull]
    public IMainDatabaseProvider MainDatabaseProvider
    {
      get => this.\u003CMainDatabaseProvider\u003Ek__BackingField;
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
              this.\u003CMainDatabaseProvider\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
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

    /// <summary>Сервис, указывающий, что выполняется скрипт</summary>
    [NotNull]
    public ScriptExecutionService ScriptExecutionService
    {
      get => this.\u003CScriptExecutionService\u003Ek__BackingField;
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
              this.\u003CScriptExecutionService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
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

    /// <summary>Сервис проверки привилегий</summary>
    [NotNull]
    public ISecurityService SecurityService => Locator.GetServiceNotNull<ISecurityService>();

    protected bool SecurityServiceExists
    {
      get
      {
        int num = 2;
        bool securityServiceExists;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.securityServiceExists = securityServiceExists = Locator.GetService<ISecurityService>() != null;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
              continue;
            case 2:
              if (!this.securityServiceExists)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 1;
                continue;
              }
              goto label_4;
            default:
              goto label_3;
          }
        }
label_3:
        return securityServiceExists;
label_4:
        return true;
      }
    }

    /// <summary>
    /// Сервис работы со значениями переменных в рамках контекста (например, веб-запроса)
    /// </summary>
    public IContextBoundVariableService ContextService
    {
      get => this.\u003CContextService\u003Ek__BackingField;
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
              this.\u003CContextService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 0;
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

    /// <summary>Сервис работы с карточками объектов индексации</summary>
    public IFullTextSearchCardService FullTextSearchCardService
    {
      get => this.\u003CFullTextSearchCardService\u003Ek__BackingField;
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
              this.\u003CFullTextSearchCardService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 0 : 0;
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

    /// <summary>Сервис индексации</summary>
    public IFullTextSearchServiceReIndexingTypeExtension FullTextSearchService
    {
      get => this.\u003CFullTextSearchService\u003Ek__BackingField;
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
              this.\u003CFullTextSearchService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
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

    /// <summary>Менеджер индексации</summary>
    protected IndexQueueManager IndexQueueManager
    {
      get
      {
        int num = 1;
        IndexQueueManager instance;
        IndexQueueManager indexQueueManager;
        while (true)
        {
          switch (num)
          {
            case 1:
              indexQueueManager = this.indexQueueManager;
              if (indexQueueManager == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_6;
            default:
              this.indexQueueManager = instance = IndexQueueManager.Instance;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 2 : 2;
              continue;
          }
        }
label_2:
        return indexQueueManager;
label_6:
        return instance;
      }
    }

    /// <summary>Расширение критерий поиска</summary>
    public IEnumerable<IFindCriteriaExtender> FindCriteriaExtenders { get; set; }

    /// <summary>
    /// Управление проверкой на загрузку мягкоудаленных объектов
    /// </summary>
    public RunWithSoftDeletableService RunWithSoftDeletableService
    {
      get
      {
        int num = 2;
        RunWithSoftDeletableService service;
        RunWithSoftDeletableService deletableService;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.runWithSoftDeletableService = service = Locator.GetService<RunWithSoftDeletableService>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 0 : 0;
              continue;
            case 2:
              deletableService = this.runWithSoftDeletableService;
              if (deletableService == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 1 : 1;
                continue;
              }
              goto label_2;
            default:
              goto label_6;
          }
        }
label_2:
        return deletableService;
label_6:
        return service;
      }
    }

    /// <summary>Статический конструктор класса. Задает настройки</summary>
    static EntityManager()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            EntityManager<T, IdT>.IndexLog = EleWise.ELMA.Logging.Logger.GetLogger(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1033719030 - 2012070891 ^ -978538085));
            num = 4;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 1 : 1;
            continue;
          case 3:
            EntityManager<T, IdT>.SetDefaultCacheItemPolicy();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
            continue;
          case 4:
            EntityManager<T, IdT>.locker = new object();
            num = 3;
            continue;
          default:
            goto label_7;
        }
      }
label_2:
      return;
label_7:;
    }

    /// <summary>Создать новую сущность (без записи в БД)</summary>
    /// <example>
    /// <code>
    /// //Для примера создадим объект "Контакт"
    /// //Создаем объект
    /// var contact = PublicAPI.CRM.Contact.Create();
    /// 
    /// //Чтобы объект был валидным, т.е. чтобы с ним можно было корректно работать, нужно заполнить некоторые обязательные поля, преждем чем сохранить объект в базу данных
    /// //Все обязательные поля вы можете найти в веб-части
    /// //В случае с контактом, нужно заполнить поля "Фамилия", "Имя", "Контрагент", "Дата создания", "Автор создания"
    /// 
    /// //заполняем поле "Автор создания", указываем текущего пользователя системы
    /// contact.CreationAuthor = PublicAPI.Portal.Security.User.GetCurrentUser();
    /// 
    /// //заполняем поле "Дата создания", указываем текущую дату
    /// contact.CreationDate = DateTime.Now;
    /// 
    /// //заполняем поле "Имя"
    /// contact.Firstname = "Андрей";
    /// 
    /// //заполняем поле "Фамилия"
    /// contact.Surname  = "Сидоров";
    /// 
    /// //заполняем поле "Контрагент", загружаем из базы данных уже созданного контрагента
    /// contact.Contractor = PublicAPI.CRM.Contractor.Load(3);
    /// 
    /// //Только после заполнения этих полей можно сохранить контакта в базу данных
    /// contact.Save();
    /// </code>
    /// </example>
    /// <returns>Сущность</returns>
    [Auditable]
    [PublicApiMember]
    [PublicApiObsoleteInNode("PublicAPI.Docflow.Document", "SR.M('Этот метод устарел')", true)]
    public override T Create()
    {
      T obj = Locator.GetService<T>();
      if ((object) obj == null)
      {
        if (this.ImplementationType.IsClass)
          obj = Activator.CreateInstance<T>();
        else
          throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70189141), (object) this.ImplementationType.FullName));
      }
      return obj;
    }

    /// <summary>
    /// Проверить, является ли объект новым (не сохранен в БД)
    /// </summary>
    /// <param name="obj">Объект системы</param>
    /// <returns><c>true</c>, если новый</returns>
    [PublicApiMember]
    public override bool IsNew(T obj)
    {
      if ((object) obj == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1251470110 >> 2 ^ 312826191));
      return Convert.ToInt64(obj.GetId()) <= 0L;
    }

    /// <summary>Проверить, есть ли несохраненные изменения в объекте</summary>
    /// <param name="obj">Объект системы</param>
    /// <returns><c>true</c>, если есть изменения</returns>
    [PublicApiMember]
    public override sealed bool IsDirty(T obj) => this.CheckDirty(obj, (List<Guid>) null, (object) null);

    /// <summary>Проверить, есть ли несохраненные изменения в объекте</summary>
    /// <param name="obj">Объект системы</param>
    /// <param name="originalState">Оригинальное состояние сущности</param>
    /// <returns><c>true</c>, если есть изменения</returns>
    public override sealed bool IsDirty(T obj, object originalState) => this.CheckDirty(obj, (List<Guid>) null, originalState);

    /// <summary>Получить идентификаторы измененных свойств</summary>
    /// <param name="obj">Объект системы</param>
    /// <returns>Список идентификаторов свойств</returns>
    public override sealed Guid[] GetDirtyPropertyUids(T obj)
    {
      List<Guid> propertyUids = new List<Guid>();
      this.CheckDirty(obj, propertyUids, (object) null);
      return propertyUids.ToArray();
    }

    /// <summary>Получить идентификаторы измененных свойств</summary>
    /// <param name="obj">Объект системы</param>
    /// <param name="originalState">Оригинальное состояние сущности</param>
    /// <returns>Список идентификаторов свойств</returns>
    public override sealed Guid[] GetDirtyPropertyUids(T obj, object originalState)
    {
      List<Guid> propertyUids = new List<Guid>();
      this.CheckDirty(obj, propertyUids, originalState);
      return propertyUids.ToArray();
    }

    /// <summary>
    /// Получить текущее состояние сущности (для применения в функции GetDirtyPropertyUids)
    /// </summary>
    /// <returns></returns>
    public override sealed object GetCurrentState(T obj) => this.GetEntityState((IEntity) obj, (object[]) null);

    /// <summary>
    /// Загрузить по идентификатору. Если не найдена - вызывается исключение
    /// </summary>
    /// <remarks>
    /// <see href="http://www.elma-bpm.ru/kb/article-645.html">Как узнать идентификаторы объектов</see>
    /// </remarks>
    /// <param name="id">Идентификатор</param>
    /// <returns>Объект системы</returns>
    [PublicApiMember]
    [Auditable]
    public override T Load(IdT id) => this.LoadOrNull(id) ?? throw new EleWise.ELMA.Exceptions.ObjectNotFoundException(this.ImplementationType.FullName, (object) id);

    /// <summary>
    /// Загрузить по идентификатору. Если не найдена - возвращается null
    /// </summary>
    /// <remarks>
    /// <see href="http://www.elma-bpm.ru/kb/article-645.html">Как узнать идентификаторы объектов</see>
    /// </remarks>
    /// <param name="id">Идентификатор</param>
    /// <returns>Объект системы или null</returns>
    [PublicApiMember]
    [Auditable]
    public override T LoadOrNull(IdT id)
    {
      T obj;
      if (this.CreateOnLoad(id))
      {
        obj = this.GetContextObject(id);
        if ((object) obj == null)
        {
          obj = this.Create();
          obj.SetId((object) id);
          this.AddContextObject(obj);
        }
      }
      else
      {
        obj = (T) this.Session.Get(this.entityName ?? (this.entityName = this.Session.GetSessionImplementation().Factory.TryGetGuessEntityName(this.ImplementationType) ?? this.ImplementationType.FullName), (object) id) ?? this.GetContextObject(id);
        if ((object) obj != null)
        {
          NHibernateUtil.Initialize((object) obj);
          try
          {
            foreach (IEntityManagerBehavior behavior in this.Behaviors)
              behavior.OnLoad((object) obj);
            if (EntityManager<T, IdT>.CanCache(obj))
            {
              if (!this.hasUidProperty.HasValue)
                this.InitUidPropertyMetadata();
              if (this.hasUidProperty.HasValue)
              {
                if (this.hasUidProperty.Value)
                {
                  if (this.uidPropertyMetadata != null)
                  {
                    PropertyInfo reflectionProperty = obj.GetType().GetReflectionProperty(this.uidPropertyMetadata.Name);
                    if (reflectionProperty != (PropertyInfo) null)
                    {
                      Guid? nullable = (Guid?) reflectionProperty.GetValue((object) obj, (object[]) null);
                      if (nullable.GetValueOrDefault() != Guid.Empty)
                        EntityManager<T, IdT>.MemoryCache.Set(EntityManager<T, IdT>.GetCacheKeyByUid(nullable.GetValueOrDefault()), (object) obj.Id, this.GetCacheItemPolicy(), (string) null);
                    }
                  }
                }
              }
            }
          }
          catch (ObjectIsDeletedException ex)
          {
            obj = (T) null;
          }
        }
      }
      return obj;
    }

    /// <summary>Можно ли кэшировать связку Uid с Id</summary>
    /// <param name="res">Объект с данными</param>
    /// <returns>True -  можно, False - нельзя</returns>
    private static bool CanCache(T res) => (object) res != null && !res.IsProxy() && (object) res.Id != null && !res.Id.Equals((object) default (IdT));

    private static string GetCacheForUidName() => InterfaceActivator.TypeOf<T>().FullName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-53329496 >> 4 ^ -3323000);

    /// <summary>
    /// Загрузить по уникальному идентификатору. Если не найдена - вызывается исключение
    /// </summary>
    /// <remarks>
    /// <see href="http://www.elma-bpm.ru/kb/article-645.html">Как узнать идентификаторы объектов</see>
    /// </remarks>
    /// <param name="uid">Уникальный идентификатор объекта</param>
    /// <returns>Объект системы</returns>
    [Auditable]
    [PublicApiMember]
    public override T Load(Guid uid) => this.LoadOrNull(uid) ?? throw new EleWise.ELMA.Exceptions.ObjectNotFoundException(this.ImplementationType.FullName, (object) uid);

    /// <summary>
    /// Загрузить по уникальному идентификатору. Если не найдена - возвращается null
    /// </summary>
    /// <remarks>
    /// <see href="http://www.elma-bpm.ru/kb/article-645.html">Как узнать идентификаторы объектов</see>
    /// </remarks>
    /// <param name="uid">Уникальный идентификатор объекта системы</param>
    /// <returns>Объект системы или null</returns>
    [Auditable]
    [PublicApiMember]
    public override T LoadOrNull(Guid uid) => this.LoadOrNull(uid, (string[]) null);

    /// <summary>
    /// Загрузить по уникальному идентификатору. Если не найдена - возвращается null
    /// </summary>
    /// <param name="uid">Уникальный идентификатор объекта системы</param>
    /// <param name="fetchColumns">Добираемые колонки</param>
    /// <returns>Объект системы или null</returns>
    internal T LoadOrNull(Guid uid, string[] fetchColumns) => this.LoadByUid(uid, fetchColumns);

    /// <summary>
    /// Загрузить по идентификатору. Если не найден - возвращается новый объект
    /// </summary>
    /// <remarks>
    /// <see href="http://www.elma-bpm.ru/kb/article-645.html">Как узнать идентификаторы объектов</see>
    /// </remarks>
    /// <param name="id">Идентификатор объекта</param>
    /// <returns>Сущность</returns>
    [Auditable]
    [PublicApiMember]
    public override T LoadOrCreate(IdT id)
    {
      T obj = this.LoadOrNull(id);
      if ((object) obj == null)
      {
        obj = this.Create();
        obj.SetId((object) id);
        this.AddContextObject(obj);
      }
      return obj;
    }

    /// <summary>
    /// Загрузить по идентификатору. Если не найден - возвращается новый объект
    /// </summary>
    /// <remarks>
    /// <see href="http://www.elma-bpm.ru/kb/article-645.html">Как узнать идентификаторы объектов</see>
    /// </remarks>
    /// <param name="uid">Уникальный идентификатор объекта системы</param>
    /// <returns>Сущность</returns>
    [PublicApiMember]
    [Auditable]
    public override T LoadOrCreate(Guid uid)
    {
      T res = this.LoadOrNull(uid);
      if ((object) res == null)
      {
        res = this.Create();
        this.InternalSetUid(uid, res);
        this.AddContextObject(res);
      }
      return res;
    }

    /// <summary>Обновить (перечитать) объект из БД</summary>
    /// <param name="obj">Объект системы</param>
    [Auditable]
    [PublicApiMember]
    public override void Refresh(T obj) => this.Session.Refresh((object) obj);

    /// <inheritdoc />
    [ActionCheck("42986da3-d210-414d-9225-f3cde17c18c9")]
    public override ActionCheckResult CanSave(T obj)
    {
      if (this.ScriptExecutionService.Turned || !this.SecurityServiceExists || !this.AuthenticationServiceExists || this.AuthenticationService.GetCurrentUser() == null)
        return ActionCheckResult.True;
      string name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(1505778440 - 1981636111 ^ -475937781) + (object) obj.GetHashCode();
      ActionCheckResult actionCheckResult;
      if (ContextVars.TryGetValue<ActionCheckResult>(name, out actionCheckResult))
        return actionCheckResult;
      Permission permission = obj.IsNew() ? CommonPermissions.Create : (this.ChangeAccess(obj) ? CommonPermissions.GrantAccess : CommonPermissions.Edit);
      if (this.SecurityService.CanCheckPermission(permission, (object) obj) && !this.SecurityService.HasPermission(permission, (object) obj))
      {
        string errorMessage;
        if (!obj.IsNew())
          errorMessage = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138211458), (object) obj);
        else
          errorMessage = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-53329496 >> 4 ^ -3269266), (object) ((NamedMetadata) MetadataLoader.LoadMetadata(obj.GetType())).DisplayName);
        return ActionCheckResult.False(errorMessage);
      }
      if (permission == CommonPermissions.Create)
        ContextVars.Set<ActionCheckResult>(name, ActionCheckResult.True);
      else if (permission == CommonPermissions.Edit && obj is ISoftDeletable softDeletable && (softDeletable.IsDeleted || softDeletable.HardDelete) && this.objectDeletion(obj))
        return this.CanDelete(obj);
      return ActionCheckResult.True;
    }

    /// <summary>Сохранить объект в БД</summary>
    /// <param name="obj">Объект системы</param>
    [Transaction]
    [PublicApiMember]
    [Auditable]
    [ActionMethod("42986da3-d210-414d-9225-f3cde17c18c9")]
    public override void Save(T obj)
    {
      if (this.Logger.IsInfoEnabled())
        this.Logger.InfoFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146446655), (object) typeof (T).FullName, (object) obj != null ? (object) obj.Id.ToString() : (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1839087379 - 334718690 ^ 2121157357), (object) Environment.StackTrace);
      this.Session.SaveOrUpdate((object) obj);
      this.AddContextObject(obj);
    }

    [ActionCheck("f5d56c0f-95af-48d5-89a0-ea4e9a336429")]
    public override ActionCheckResult CanDelete(T obj)
    {
      if (this.ScriptExecutionService.Turned || !this.SecurityServiceExists || !this.SecurityService.CanCheckPermission(CommonPermissions.Delete, (object) obj) || this.SecurityService.HasPermission(CommonPermissions.Delete, (object) obj))
        return ActionCheckResult.True;
      return ActionCheckResult.False(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87527829), (object) obj));
    }

    /// <summary>Удалить объект</summary>
    /// <param name="obj">Объект системы</param>
    [ActionMethod("f5d56c0f-95af-48d5-89a0-ea4e9a336429")]
    [PublicApiMember]
    [Transaction]
    [Auditable]
    public override void Delete(T obj)
    {
      if (MetadataLoader.LoadMetadata(obj.GetType()) is EntityMetadata entitymetadata && entitymetadata.ShowInCatalogList && entitymetadata.Hierarchical)
      {
        if (entitymetadata.HierarchyType == HierarchyType.GroupAndElements)
        {
          if ((bool) this.Session.GetOriginalEntityProperty((object) obj, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998453718)) && this.GetSubElementCountOfHierarchicalEntity(obj, entitymetadata) > 0L)
            throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1218962250 ^ 1218763060)));
        }
        else if (entitymetadata.HierarchyType == HierarchyType.Elements && this.GetSubElementCountOfHierarchicalEntity(obj, entitymetadata) > 0L)
          throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(825385222 ^ 825318362)));
      }
      this.Session.Delete((object) obj);
      this.RemoveFromContextObject(obj);
    }

    /// <summary>Найти объекты в соответствии с параметрами выборки</summary>
    /// <param name="fetchOptions">Параметры выборки (для получения всех результатов из БД используйте <see cref="P:EleWise.ELMA.Model.Common.FetchOptions.All" />)</param>
    /// <returns>Список найденных объектов</returns>
    [NotNull]
    [PublicApiMember]
    public override sealed ICollection<T> Find(FetchOptions fetchOptions) => this.Find((IEntityFilter) null, fetchOptions, this.CacheEnabled);

    /// <summary>
    /// Найти объекты в соответствии с фильтром и параметрами выборки
    /// </summary>
    /// <example>
    /// <code>
    /// //Создаем фильтр (в данном случае для документа)
    /// var docFilter = PublicAPI.Docflow.Document.CreateFilter();
    /// //Указываем критерии выборки
    /// docFilter.Folder = PublicAPI.Docflow.Folder.LoadOrNull(35);
    /// docFilter.Name = "Документ от 10.07.1991";
    /// //Передаем фильтр в функцию поиска
    /// //documents - список документов удовлетворяющих условию выборки, заданной в фильтре
    /// var documents = PublicAPI.Docflow.Document.Find(docFilter, null);
    /// </code>
    /// </example>
    /// <param name="filter">Фильтр объекта</param>
    /// <param name="fetchOptions">Параметры выборки (для получения всех результатов из БД используйте <see cref="P:EleWise.ELMA.Model.Common.FetchOptions.All" />)</param>
    /// <returns>Список найденных объектов</returns>
    [NotNull]
    [PublicApiMember]
    public override sealed ICollection<T> Find(IEntityFilter filter, FetchOptions fetchOptions) => this.Find(filter, fetchOptions, this.CacheEnabled);

    /// <summary>Найти объекты в соответствии с фильтром на языке EQL</summary>
    /// <example>
    /// <code>
    /// //documents - список документов удовлетворяющих условию выборки, заданной в фильтре
    /// var documents = PublicAPI.Docflow.Document.Find("Folder = 35 and Name = 'Документ от 10.07.1991'");
    /// </code>
    /// </example>
    /// <param name="eqlFilter">Условие поиска на языке EQL</param>
    /// <returns>Список найденных объектов</returns>
    [NotNull]
    [PublicApiMember]
    public override sealed ICollection<T> Find(string eqlFilter) => this.Find((IEntityFilter) new Filter()
    {
      Query = eqlFilter
    }, FetchOptions.All);

    /// <summary>Найти объекты в соответствии с фильтром на языке EQL</summary>
    /// <example>
    /// <code>
    /// //documents - список документов удовлетворяющих условию выборки, заданной в фильтре
    /// var documents = PublicAPI.Docflow.Document.Find("Folder = 35 and Name = 'Документ от 10.07.1991'", FetchOptions.All);
    /// </code>
    /// </example>
    /// <param name="eqlFilter">Условие поиска на языке EQL</param>
    /// <param name="fetchOptions">Параметры выборки (для получения всех результатов из БД используйте <see cref="P:EleWise.ELMA.Model.Common.FetchOptions.All" />)</param>
    /// <returns>Список найденных объектов</returns>
    [NotNull]
    [PublicApiMember]
    public override sealed ICollection<T> Find(string eqlFilter, FetchOptions fetchOptions) => this.Find((IEntityFilter) new Filter()
    {
      Query = eqlFilter
    }, fetchOptions);

    /// <summary>
    /// Найти объекты в соответствии с фильтром и параметрами выборки
    /// </summary>
    /// <example>
    /// <code>
    /// //Создаем фильтр (в данном случае для документа)
    /// var docFilter = PublicAPI.Docflow.Document.CreateFilter();
    /// //Указываем критерии выборки
    /// docFilter.Folder = PublicAPI.Docflow.Folder.LoadOrNull(35);
    /// docFilter.Name = "Документ от 10.07.1991";
    /// //Передаем фильтр в функцию поиска
    /// //documents - список документов удовлетворяющих условию выборки, заданной в фильтре
    /// var documents = PublicAPI.Docflow.Document.Find(docFilter, null);
    /// </code>
    /// </example>
    /// <param name="filter">Фильтр объекта</param>
    /// <param name="fetchOptions">Параметры выборки (для получения всех результатов из БД используйте <see cref="P:EleWise.ELMA.Model.Common.FetchOptions.All" />)</param>
    /// <returns>Список найденных объектов</returns>
    [NotNull]
    public ICollection<IdT> FindIds(IEntityFilter filter, FetchOptions fetchOptions) => this.FindIds(filter, fetchOptions, this.CacheEnabled);

    /// <summary>Возвращает количество всех объектов этого типа</summary>
    /// <returns>Количество всех объектов</returns>
    [PublicApiMember]
    public override sealed long Count() => this.Count((IEntityFilter) null);

    /// <summary>Обновить (перечитать) сущность из БД с блокировками</summary>
    /// <param name="obj"></param>
    /// <param name="mode"></param>
    [Auditable]
    public override void Refresh(T obj, LockMode mode) => this.Session.Refresh((object) obj, mode);

    /// <summary>Получить количество всех объектов по фильтру</summary>
    /// <param name="filter">Фильтр объекта</param>
    /// <returns>Количество объектов по фильтру</returns>
    [PublicApiMember]
    public override sealed long Count(IEntityFilter filter)
    {
      int num1 = 2;
      long? nullable;
      ICriteria criteria;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (nullable.HasValue)
              {
                num2 = 4;
                continue;
              }
              goto label_6;
            case 2:
              nullable = this.CountByIndex(filter);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 1;
              continue;
            case 3:
              this.SetupFilter(criteria, filter);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 0;
              continue;
            case 4:
              goto label_5;
            default:
              goto label_7;
          }
        }
label_6:
        criteria = this.CreateCriteria(filter);
        num1 = 3;
      }
label_5:
      return nullable.Value;
label_7:
      return this.ReturnCount(criteria);
    }

    /// <summary>Узнать о наличии объектов</summary>
    /// <returns>Наличие объектов</returns>
    [PublicApiMember]
    public bool Exists() => this.Exists((IEntityFilter) null);

    /// <summary>Узнать о наличии подходящих объектов по фильтру</summary>
    /// <param name="filter">Фильтр объекта</param>
    /// <returns>Наличие объектов по фильтру</returns>
    [PublicApiMember]
    public bool Exists(IEntityFilter filter)
    {
      int num1 = 2;
      long num2;
      long? nullable1;
      long? nullable2;
      ICriteria criteria;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (!nullable1.HasValue)
            {
              num1 = 7;
              continue;
            }
            goto case 6;
          case 2:
            nullable1 = this.CountByIndex(filter);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 1 : 1;
            continue;
          case 3:
            goto label_10;
          case 4:
            this.SetupFilter(criteria, filter);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 3 : 1;
            continue;
          case 5:
            goto label_7;
          case 6:
            nullable2 = nullable1;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
            continue;
          case 7:
            criteria = this.CreateCriteria(filter);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 4 : 3;
            continue;
          default:
            num2 = 0L;
            num1 = 5;
            continue;
        }
      }
label_7:
      return nullable2.GetValueOrDefault() > num2 & nullable2.HasValue;
label_10:
      return this.ReturnExists(criteria);
    }

    /// <summary>
    /// Проверяет правильность фильтра (основная проверка для EQL), в противном случае исключение
    /// </summary>
    /// <param name="filter">Фильт</param>
    public override void CheckFilter(IEntityFilter filter)
    {
      int num = 1;
      ICriteria criteria;
      while (true)
      {
        switch (num)
        {
          case 1:
            criteria = this.CreateCriteria(filter);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            this.SetupFilter(criteria, filter);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 2 : 1;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Найти все объекты по идентификаторам из массива</summary>
    /// <remarks>
    /// <see href="http://www.elma-bpm.ru/kb/article-645.html">Как узнать идентификаторы объектов</see>
    /// </remarks>
    /// <param name="idArray">Массив идентификаторов</param>
    /// <returns>Список найденных объектов</returns>
    [PublicApiMember]
    [NotNull]
    public override sealed ICollection<T> FindByIdArray([NotNull] IdT[] idArray) => this.FindByIdArray(idArray, (IEntityFilter) null, (FetchOptions) null);

    /// <summary>
    /// Найти все объекты по идентификаторам из массива с учётом фильтра
    /// </summary>
    /// <param name="idArray">Массив идентификаторов</param>
    /// <param name="filter">Фильтр</param>
    /// <param name="fetchOptions">Параметры выборки</param>
    /// <returns>Список найденных объектов</returns>
    public virtual ICollection<T> FindByIdArray(
      [NotNull] IdT[] idArray,
      IEntityFilter filter,
      FetchOptions fetchOptions)
    {
      if (idArray == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(813604817 ^ 813540511));
      return idArray.Length == 0 ? (ICollection<T>) new System.Collections.ObjectModel.Collection<T>() : this.Find(this.CreateCriteriaForArraySearch<IdT>((IEnumerable<IdT>) idArray, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669212571 ^ 1669245125), filter, fetchOptions));
    }

    /// <summary>Найти все объекты по Uid'ам из массива</summary>
    /// <param name="uidArray">Массив идентификаторов</param>
    /// <returns>Список найденных объектов</returns>
    public virtual ICollection<T> FindByIdArray([NotNull] Guid[] uidArray)
    {
      if (uidArray == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(92412609 - 1050237057 ^ -957613792));
      return uidArray.Length == 0 ? (ICollection<T>) new System.Collections.ObjectModel.Collection<T>() : this.Find(this.CreateCriteriaForArraySearch<Guid>((IEnumerable<Guid>) uidArray, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675482067), (IEntityFilter) null, (FetchOptions) null));
    }

    /// <summary>Сформировать критерию для поиска по массиву</summary>
    /// <param name="vaues">Перечисление значений для поиска</param>
    /// <param name="filter">Фильтр</param>
    /// <param name="fetchOptions">Параметры выборки</param>
    /// <returns>Критерия для поиска</returns>
    public ICriteria CreateCriteriaForArraySearch<TData>(
      [NotNull] IEnumerable<TData> values,
      string property,
      IEntityFilter filter,
      FetchOptions fetchOptions)
    {
      ICriteria criteria = this.CreateCriteria(fetchOptions, this.GetFetchType(filter), filter: filter);
      if (filter != null && fetchOptions != (FetchOptions) null)
      {
        this.SetupFilter(criteria, filter);
        if (!string.IsNullOrEmpty(fetchOptions.QueryKey))
        {
          foreach (IFindCriteriaExtender criteriaExtender in this.FindCriteriaExtenders)
          {
            if (criteriaExtender.QueryKey == fetchOptions.QueryKey)
              criteriaExtender.Extend(filter, criteria, fetchOptions);
          }
        }
      }
      return criteria.Add((ICriterion) Restrictions.In(property, (ICollection) values.ToArray<TData>()));
    }

    /// <summary>Конструктор</summary>
    public EntityManager()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.behaviors = new NestedScopeComponents<IEntityManagerBehavior>(ServiceScope.Shell);
      this.implementationTypeUid = Guid.Empty;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.Logger = NullLogger.Instance;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>
    /// Список точек расширения для изменения поведения менеджеров
    /// </summary>
    public IEnumerable<IEntityManagerBehavior> Behaviors => this.behaviors.Value;

    /// <summary>
    /// Удалить сущность в БД по запросу.
    /// ВНИМАНИЕ!!! Не использовать для больших массивов, т.к. данные сначала загружаются в память из БД и только потом удаляются.
    /// </summary>
    /// <param name="query">Запрос</param>
    [Auditable]
    [Transaction]
    public override void Delete(string query)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Session.Delete(query);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Удалить все сущности из БД</summary>
    /// <remarks>Метод выполняется долго, т.к. загружает все записи в память и формирует большую транзакцию для удаления.
    /// При необходимости нужно написать свою реализацию либо одним запросом, либо разбивать на удаление небольшими пачками в отдельных транзакциях.</remarks>
    [Auditable]
    [Transaction]
    [Obsolete("При необходимости используйте собственную реализацию метода, текущая работает долго и может превысить допустимое время выполнения при большом количестве записей.")]
    public override void DeleteAll()
    {
      int num1 = 2;
      IEnumerator<T> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_15;
          case 1:
            goto label_2;
          case 2:
            enumerator = this.FindAll(false).GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 1 : 1;
            continue;
          default:
            goto label_10;
        }
      }
label_15:
      return;
label_10:
      return;
label_2:
      try
      {
label_6:
        if (enumerator.MoveNext())
          goto label_8;
        else
          goto label_7;
label_3:
        T current;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_8;
            case 2:
              goto label_4;
            case 3:
              goto label_6;
            default:
              this.Delete(current);
              num2 = 3;
              continue;
          }
        }
label_4:
        return;
label_7:
        num2 = 2;
        goto label_3;
label_8:
        current = enumerator.Current;
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
        {
          num2 = 0;
          goto label_3;
        }
        else
          goto label_3;
      }
      finally
      {
        if (enumerator != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
            num3 = 1;
          while (true)
          {
            switch (num3)
            {
              case 1:
                enumerator.Dispose();
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 0 : 0;
                continue;
              default:
                goto label_17;
            }
          }
        }
label_17:;
      }
    }

    /// <summary>Удалить объект из текущей сесии</summary>
    /// <param name="obj"></param>
    public virtual void Evict(T obj) => this.Session.Evict((object) obj);

    /// <summary>Найти все сущности</summary>
    /// <returns>Список всех сущностей</returns>
    [NotNull]
    public override sealed ICollection<T> FindAll() => this.Find((IEntityFilter) null, (FetchOptions) null, this.CacheEnabled);

    /// <summary>Найти все сущности с кэшированием</summary>
    /// <param name="cacheble">Кэшировать ли результат запроса</param>
    /// <returns>Список всех сущностей</returns>
    [NotNull]
    public override sealed ICollection<T> FindAll(bool cacheble) => this.Find((IEntityFilter) null, (FetchOptions) null, cacheble);

    /// <summary>Выбрать значения по условию поиска в виде выражения</summary>
    /// <param name="queryExpression">Выражение для выборки</param>
    /// <returns>Список значений, удовлетворяющих условию поиска</returns>
    [Auditable]
    public virtual ICollection<RT> Query<RT>(
      Func<IQueryable<T>, IQueryable<RT>> queryExpression)
    {
      return (ICollection<RT>) queryExpression(this.Session.Query<T>()).ToList<RT>();
    }

    [Auditable]
    [NotNull]
    public override ICollection<T> Find(Expression<Func<T, bool>> condition) => this.Find(condition, (FetchOptions) null);

    [Auditable]
    [NotNull]
    public override ICollection<TResult> Find<TResult>(Expression<Func<TResult, bool>> condition)
    {
      if (!typeof (TResult).IsAssignableFrom(this.ImplementationType))
        throw new ArgumentException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638609563), (object) typeof (TResult), (object) this.ImplementationType), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16554701));
      return this.Find<TResult>(condition, (FetchOptions) null);
    }

    /// <summary>Поиск объектов, удовлетворяющих условию</summary>
    /// <param name="condition">Условие</param>
    /// <param name="fetchOptions">Параметры выборки, учитываются следующие параметры:
    /// 1. FirstResult;
    /// 2. MaxResults;
    /// 3. FetchRelations, в т.ч. вложенные свойства и коллекции
    /// 4. OrderBy, в виде "имя_свойства направление_сортировки", напр. "prop1 desc, prop2 asc, prop3"
    /// Прочие параметры выборки игнорируются
    /// </param>
    /// <returns>Коллекция объектов</returns>
    public override ICollection<T> Find(
      Expression<Func<T, bool>> condition,
      FetchOptions fetchOptions)
    {
      return (ICollection<T>) this.Session.Query<T>().Where<T>(condition).SetupFetchOptions<T>(fetchOptions).ToList<T>();
    }

    /// <summary>Поиск объектов, удовлетворяющих условию</summary>
    /// <param name="condition">Условие</param>
    /// <param name="fetchOptions">Параметры выборки, учитываются следующие поля:
    /// 1. FirstResult;
    /// 2. MaxResults;
    /// 3. FetchRelations, в т.ч. вложенные свойства и коллекции
    /// 4. OrderBy, в виде "имя_свойства направление_сортировки", напр. "prop1 desc, prop2 asc, prop3"
    /// Прочие параметры выборки игнорируются
    /// </param>
    /// <returns>Коллекция объектов</returns>
    public override ICollection<TResult> Find<TResult>(
      Expression<Func<TResult, bool>> condition,
      FetchOptions fetchOptions)
    {
      if (!typeof (TResult).IsAssignableFrom(this.ImplementationType))
        throw new ArgumentException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1021410165 ^ 1021460481), (object) typeof (TResult), (object) this.ImplementationType), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917256330 ^ 1917073758));
      return (ICollection<TResult>) this.Session.Query<TResult>().Where<TResult>(condition).SetupFetchOptions<TResult>(fetchOptions).ToList<TResult>();
    }

    /// <summary>Получить проекцию значений свойства</summary>
    /// <typeparam name="PT">Тип свойства</typeparam>
    /// <param name="propertyName">Имя свойства</param>
    /// <returns>Список выбранных значений</returns>
    [Auditable]
    public override ICollection<PT> Projection<PT>(string propertyName) => (ICollection<PT>) this.ReturnProjection<PT>(this.CreateCriteria(), propertyName);

    public override ExportRuleList ExportRules() => new ExportRuleList();

    /// <summary>Есть ли поля учавствующие в быстром поиске</summary>
    /// <param name="metadata">Метаданные</param>
    /// <param name="filter">Фильтр</param>
    /// <returns>true если есть поля учавствующие в быстром поиске</returns>
    public override bool ExistPropertiesForFastSearch(
      IEntityMetadata metadata,
      IEntityFilter filter = null)
    {
      int num = 4;
      EntityMetadata metadata1;
      List<EntityPropertyMetadata> propertiesForFastSearch;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (propertiesForFastSearch != null)
            {
              num = 5;
              continue;
            }
            goto label_8;
          case 2:
            propertiesForFastSearch = this.GetPropertiesForFastSearch(metadata1, filter);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 1;
            continue;
          case 3:
            if (metadata1 != null)
            {
              num = 2;
              continue;
            }
            goto label_9;
          case 4:
            metadata1 = metadata as EntityMetadata;
            num = 3;
            continue;
          case 5:
            goto label_7;
          default:
            goto label_9;
        }
      }
label_7:
      return propertiesForFastSearch.Count > 0;
label_8:
      return false;
label_9:
      return false;
    }

    /// <inheritdoc />
    public string GetDefaultCriteriaAlias() => this.DefaultCriteriaAlias;

    /// <summary>Получить идентификаторы измененных свойств</summary>
    /// <param name="obj">Сущность</param>
    /// <param name="propertyUids">Список, в который будут записаны идентификаторы измененных свойств. Если null, то нужно только вернуть результат функции</param>
    /// <returns>Список идентификаторов свойств</returns>
    protected virtual bool CheckDirty(T obj, List<Guid> propertyUids, object originalState)
    {
      bool turned = this.RunWithSoftDeletableService.Turned;
      try
      {
        this.RunWithSoftDeletableService.Turned = true;
        ISessionImplementor sessionImplementation = this.Session.GetSessionImplementation();
        IEntityPersister entityPersister = this.Session.GetEntityPersister((object) obj);
        if (entityPersister.HasUninitializedLazyProperties((object) obj))
          return false;
        bool flag1 = originalState != null;
        if (originalState == null)
        {
          NHibernate.Engine.EntityEntry entry = sessionImplementation.PersistenceContext.GetEntry((object) obj);
          if (entry == null && obj.IsProxy())
          {
            INHibernateProxy maybeProxy = (object) obj as INHibernateProxy;
            object entity = sessionImplementation.PersistenceContext.Unproxy((object) maybeProxy);
            entry = sessionImplementation.PersistenceContext.GetEntry(entity);
          }
          if (entry == null)
            return false;
          object[] loadedState = entry.LoadedState;
          originalState = this.GetEntityState((IEntity) obj, loadedState);
        }
        if (!(originalState is Dictionary<string, object> dictionary1))
          return false;
        object[] propertyValues = entityPersister.GetPropertyValues((object) obj);
        bool flag2 = false;
        ClassMetadata classMetadata = (ClassMetadata) MetadataLoader.LoadMetadata(entityPersister.EntityMetamodel.Type);
        Dictionary<string, PropertyMetadata> dictionary2 = classMetadata.Properties.ToDictionary<PropertyMetadata, string, PropertyMetadata>((Func<PropertyMetadata, string>) (k => k.Name), (Func<PropertyMetadata, PropertyMetadata>) (v => v));
        object[] previousState = new object[entityPersister.PropertyNames.Length];
        for (int index = 0; index < entityPersister.PropertyNames.Length; ++index)
        {
          string propertyName = entityPersister.PropertyNames[index];
          object obj1;
          previousState[index] = !dictionary1.TryGetValue(propertyName, out obj1) ? (object) null : obj1;
          PropertyMetadata propertyMetadata;
          if (dictionary2.TryGetValue(propertyName, out propertyMetadata) && propertyMetadata.Settings is EntitySettings && ((EntitySettings) propertyMetadata.Settings).RelationType == RelationType.OneToOne)
          {
            IEntity entity1 = previousState[index] as IEntity;
            IEntity entity2 = propertyValues[index] as IEntity;
            if (!object.Equals(entity1?.GetId(), entity2?.GetId()))
            {
              if (propertyUids == null)
                return true;
              propertyUids.Add(propertyMetadata.Uid);
              flag2 = true;
            }
            propertyValues[index] = previousState[index];
          }
        }
        int[] dirty = entityPersister.FindDirty(propertyValues, previousState, (object) obj, sessionImplementation);
        if (dirty != null && dirty.Length != 0)
        {
          if (propertyUids != null)
          {
            foreach (int index in dirty)
            {
              string propertyName = entityPersister.PropertyNames[index];
              PropertyMetadata propertyMetadata;
              if (dictionary2.TryGetValue(propertyName, out propertyMetadata) && !propertyUids.Contains(propertyMetadata.Uid))
                propertyUids.Add(propertyMetadata.Uid);
            }
          }
          if (propertyUids == null)
            return true;
          flag2 = true;
        }
        foreach (IPropertyMetadata propertyMetadata in classMetadata is IEntityMetadata entityMetadata ? entityMetadata.GetPropertiesAndTableParts() : classMetadata.Properties.Cast<IPropertyMetadata>())
        {
          if (propertyMetadata is ITablePartMetadata || propertyMetadata.Settings is EntitySettings && ((EntitySettings) propertyMetadata.Settings).RelationType != RelationType.OneToOne)
          {
            object propertyValue = obj.GetPropertyValue(propertyMetadata.PropertyUid);
            IEnumerable source = !(propertyValue is IPersistentCollection persistentCollection) || !persistentCollection.WasInitialized ? propertyValue as IEnumerable : persistentCollection.GetValue() as IEnumerable;
            if (source != null)
            {
              bool flag3 = source.CastToListOrNull<object>().Any<object>();
              object obj2;
              if (!dictionary1.TryGetValue(propertyMetadata.Name, out obj2))
                obj2 = (object) null;
              bool flag4;
              if (propertyMetadata is ITablePartMetadata tablePartMetadata)
              {
                if (flag1)
                {
                  flag4 = (persistentCollection != null ? (persistentCollection.IsDirty ? 1 : 0) : (flag3 ? 1 : 0)) != 0 && obj2 == null;
                  if (!flag4 && obj2 is Dictionary<object, object> dictionary3)
                  {
                    IEntity[] array = source.OfType<IEntity>().ToArray<IEntity>();
                    if (dictionary3.Count != array.Length)
                    {
                      flag4 = true;
                    }
                    else
                    {
                      IEntityManager entityManager = ModelHelper.GetEntityManager(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(tablePartMetadata.Uid));
                      foreach (IEntity entity in array)
                      {
                        object originalState1;
                        if (dictionary3.TryGetValue(entity.GetId(), out originalState1) && entityManager.IsDirty((object) entity, originalState1))
                        {
                          flag4 = true;
                          break;
                        }
                      }
                    }
                  }
                }
                else
                {
                  flag4 = persistentCollection != null ? persistentCollection.IsDirty : flag3;
                  if (!flag4)
                  {
                    if (!(persistentCollection is IEnumerable enumerable))
                      enumerable = source;
                    foreach (IEntity entity in enumerable)
                    {
                      if (entity.IsDirty())
                      {
                        flag4 = true;
                        break;
                      }
                    }
                  }
                }
              }
              else if (flag1)
              {
                flag4 = (persistentCollection != null ? (persistentCollection.IsDirty ? 1 : 0) : (flag3 ? 1 : 0)) != 0 && obj2 == null;
                if (!flag4 && obj2 != null && obj2 is IEnumerable<object> objects)
                {
                  List<object> list = source.OfType<IEntity>().Select<IEntity, object>((Func<IEntity, object>) (i => i.GetId())).ToList<object>();
                  flag4 = list.Count != objects.Count<object>() || !list.SequenceEqual<object>(objects);
                }
              }
              else
                flag4 = persistentCollection != null ? persistentCollection.IsDirty : flag3;
              if (flag4)
              {
                if (propertyUids == null)
                  return true;
                propertyUids.Add(propertyMetadata.PropertyUid);
                flag2 = true;
              }
            }
          }
        }
        return flag2;
      }
      finally
      {
        this.RunWithSoftDeletableService.Turned = turned;
      }
    }

    protected virtual object GetEntityState(IEntity obj, object[] state)
    {
      int num1 = 1;
      bool turned;
      while (true)
      {
        switch (num1)
        {
          case 1:
            turned = this.RunWithSoftDeletableService.Turned;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            goto label_4;
        }
      }
label_2:
      object entityState;
      return entityState;
label_4:
      try
      {
        this.RunWithSoftDeletableService.Turned = true;
        int num2 = 8;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
          num2 = 8;
        while (true)
        {
          Dictionary<string, object> dictionary1;
          IEntityPersister entityPersister;
          ClassMetadata classMetadata;
          int index;
          string propertyName;
          object obj1;
          IEnumerator<IPropertyMetadata> enumerator1;
          IEntityMetadata entityMetadata;
          IEnumerable<IPropertyMetadata> propertyMetadatas;
          switch (num2)
          {
            case 1:
            case 6:
              if (state == null)
              {
                num2 = 14;
                continue;
              }
              goto case 20;
            case 2:
              obj1 = state[index];
              num2 = 21;
              continue;
            case 3:
              if (!entityPersister.HasUninitializedLazyProperties((object) obj))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 1 : 1;
                continue;
              }
              goto case 9;
            case 4:
              entityMetadata = classMetadata as IEntityMetadata;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 11 : 9;
              continue;
            case 5:
              classMetadata = (ClassMetadata) MetadataLoader.LoadMetadata(entityPersister.EntityMetamodel.Type);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 7 : 4;
              continue;
            case 7:
              index = 0;
              num2 = 15;
              continue;
            case 8:
              entityPersister = this.Session.GetEntityPersister((object) obj);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 1 : 3;
              continue;
            case 9:
              entityState = (object) null;
              num2 = 19;
              continue;
            case 10:
              propertyMetadatas = classMetadata.Properties.Cast<IPropertyMetadata>();
              break;
            case 11:
              if (entityMetadata != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 0;
                continue;
              }
              goto case 10;
            case 12:
              try
              {
label_33:
                if (enumerator1.MoveNext())
                  goto label_27;
                else
                  goto label_34;
label_24:
                IPropertyMetadata current1;
                int num3;
                while (true)
                {
                  int num4;
                  object propertyValue;
                  IEnumerable source;
                  object obj2;
                  IPersistentCollection persistentCollection;
                  ITablePartMetadata tablePartMetadata;
                  IEnumerator<IEntity> enumerator2;
                  Dictionary<object, object> dictionary2;
                  List<object> objectList;
                  IEntityManager entityManager;
                  switch (num3)
                  {
                    case 1:
                    case 19:
                      dictionary1[current1.Name] = obj2;
                      num3 = 15;
                      continue;
                    case 2:
                    case 10:
                      source = persistentCollection.GetValue() as IEnumerable;
                      num3 = 28;
                      continue;
                    case 3:
                    case 15:
                    case 23:
                      goto label_33;
                    case 4:
                      if (!(current1 is ITablePartMetadata))
                      {
                        num3 = 13;
                        continue;
                      }
                      goto case 26;
                    case 5:
                      if (persistentCollection == null)
                      {
                        num3 = 22;
                        continue;
                      }
                      goto case 24;
                    case 6:
                      enumerator2 = source.OfType<IEntity>().GetEnumerator();
                      num4 = 21;
                      break;
                    case 7:
                    case 22:
                      source = propertyValue as IEnumerable;
                      num3 = 25;
                      continue;
                    case 8:
                      goto label_8;
                    case 9:
                      try
                      {
label_66:
                        if (enumerator2.MoveNext())
                          goto label_65;
                        else
                          goto label_67;
label_64:
                        IEntity current2;
                        int num5;
                        while (true)
                        {
                          switch (num5)
                          {
                            case 1:
                              goto label_76;
                            case 2:
                              objectList.Add(current2.GetId());
                              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 0;
                              continue;
                            case 3:
                              goto label_65;
                            default:
                              goto label_66;
                          }
                        }
label_65:
                        current2 = enumerator2.Current;
                        num5 = 2;
                        goto label_64;
label_67:
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 1 : 1;
                        goto label_64;
                      }
                      finally
                      {
                        if (enumerator2 != null)
                        {
                          int num6 = 1;
                          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0)
                            num6 = 1;
                          while (true)
                          {
                            switch (num6)
                            {
                              case 1:
                                enumerator2.Dispose();
                                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
                                continue;
                              default:
                                goto label_74;
                            }
                          }
                        }
label_74:;
                      }
                    case 11:
label_76:
                      obj2 = (object) objectList;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 1 : 1;
                      continue;
                    case 12:
                      entityManager = ModelHelper.GetEntityManager(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(tablePartMetadata.Uid));
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 14 : 12;
                      continue;
                    case 13:
                      if (current1.Settings is EntitySettings)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 29 : 15;
                        continue;
                      }
                      goto label_33;
                    case 14:
                      dictionary2 = new Dictionary<object, object>();
                      num3 = 6;
                      continue;
                    case 16:
                      enumerator2 = source.OfType<IEntity>().GetEnumerator();
                      num4 = 9;
                      break;
                    case 17:
                      tablePartMetadata = current1 as ITablePartMetadata;
                      num3 = 20;
                      continue;
                    case 18:
                      goto label_27;
                    case 20:
                      if (tablePartMetadata == null)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 0 : 0;
                        continue;
                      }
                      goto case 12;
                    case 21:
                      try
                      {
label_41:
                        if (enumerator2.MoveNext())
                          goto label_43;
                        else
                          goto label_42;
label_39:
                        IEntity current3;
                        int num7;
                        while (true)
                        {
                          switch (num7)
                          {
                            case 1:
                              goto label_75;
                            case 2:
                              dictionary2[current3.GetId()] = entityManager.GetCurrentState((object) current3);
                              num7 = 3;
                              continue;
                            case 3:
                              goto label_41;
                            default:
                              goto label_43;
                          }
                        }
label_42:
                        num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 1;
                        goto label_39;
label_43:
                        current3 = enumerator2.Current;
                        num7 = 2;
                        goto label_39;
                      }
                      finally
                      {
                        if (enumerator2 != null)
                        {
                          int num8 = 0;
                          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
                            num8 = 1;
                          while (true)
                          {
                            switch (num8)
                            {
                              case 1:
                                enumerator2.Dispose();
                                num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
                                continue;
                              default:
                                goto label_49;
                            }
                          }
                        }
label_49:;
                      }
                    case 24:
                      if (persistentCollection.WasInitialized)
                      {
                        num3 = 2;
                        continue;
                      }
                      goto case 7;
                    case 25:
                    case 28:
                      if (source == null)
                      {
                        num3 = 23;
                        continue;
                      }
                      goto case 17;
                    case 26:
                      propertyValue = obj.GetPropertyValue(current1.PropertyUid);
                      num3 = 27;
                      continue;
                    case 27:
                      persistentCollection = propertyValue as IPersistentCollection;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 2 : 5;
                      continue;
                    case 29:
                      if (((EntitySettings) current1.Settings).RelationType == RelationType.OneToOne)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 3 : 3;
                        continue;
                      }
                      goto case 26;
                    case 31:
label_75:
                      obj2 = (object) dictionary2;
                      num3 = 19;
                      continue;
                    default:
                      objectList = new List<object>();
                      num4 = 16;
                      break;
                  }
                  num3 = num4;
                }
label_27:
                current1 = enumerator1.Current;
                num3 = 4;
                goto label_24;
label_34:
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 8 : 6;
                goto label_24;
              }
              finally
              {
                if (enumerator1 != null)
                {
                  int num9 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0)
                    num9 = 0;
                  while (true)
                  {
                    switch (num9)
                    {
                      case 1:
                        goto label_84;
                      default:
                        enumerator1.Dispose();
                        num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 1 : 1;
                        continue;
                    }
                  }
                }
label_84:;
              }
            case 13:
              propertyName = entityPersister.PropertyNames[index];
              num2 = 2;
              continue;
            case 14:
              state = entityPersister.GetPropertyValues((object) obj);
              num2 = 20;
              continue;
            case 15:
            case 22:
              if (index >= entityPersister.PropertyNames.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 4 : 2;
                continue;
              }
              goto case 13;
            case 16:
            case 19:
              goto label_2;
            case 17:
              ++index;
              num2 = 22;
              continue;
            case 18:
label_8:
              entityState = (object) dictionary1;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 14 : 16;
              continue;
            case 20:
              dictionary1 = new Dictionary<string, object>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 5 : 0;
              continue;
            case 21:
              dictionary1[propertyName] = obj1;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 17 : 1;
              continue;
            default:
              propertyMetadatas = entityMetadata.GetPropertiesAndTableParts();
              break;
          }
          enumerator1 = propertyMetadatas.GetEnumerator();
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 1 : 12;
        }
      }
      finally
      {
        this.RunWithSoftDeletableService.Turned = turned;
        int num10 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
          num10 = 0;
        switch (num10)
        {
          default:
        }
      }
    }

    /// <summary>Вернуть результаты выборки по критерию</summary>
    /// <param name="criteria">Критерий</param>
    /// <returns>Результаты выборки</returns>
    protected virtual ICollection<T> Find(ICriteria criteria)
    {
      Contract.ArgumentNotNull((object) criteria, z2jc63fLkugS1X8Q9N.tE1kD1vbB(572119659 - -337058038 ^ 909363335));
      return (ICollection<T>) criteria.List<T>();
    }

    /// <summary>Установить критерии сортировки</summary>
    /// <param name="criteria">Критерий</param>
    /// <param name="fetchOptions">Опции сортировки</param>
    /// <param name="entityType">Тип сущности</param>
    protected virtual void SetupSortOptions(
      ICriteria criteria,
      FetchOptions fetchOptions,
      Type entityType)
    {
      int num1 = 13;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          ICustomSortable customSortable;
          string[] array;
          PropertyMetadata propertyMetadata1;
          PropertyMetadata propertyMetadata2;
          EntityMetadata metadata;
          FetchOptions fetchOptions1;
          EntityManager<T, IdT> entityManager;
          ICriteria criteria1;
          Type entityType1;
          List<KeyValuePair<PropertyMetadata, ClassMetadata>> childMetadataList;
          switch (num2)
          {
            case 1:
            case 18:
              array = ((IEnumerable<string>) fetchOptions1.SortExpression.Split(z2jc63fLkugS1X8Q9N.tE1kD1vbB(572119659 - -337058038 ^ 909156753).ToCharArray(), StringSplitOptions.RemoveEmptyEntries)).Distinct<string>().ToArray<string>();
              num2 = 19;
              continue;
            case 2:
              entityManager = this;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 26 : 13;
              continue;
            case 3:
              Contract.ArgumentNotNull((object) entityType1, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1204263869 ^ -1341583247 ^ 137471910));
              num2 = 29;
              continue;
            case 4:
              if (metadata.IsGroupPropertyUid != Guid.Empty)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 10;
                continue;
              }
              goto case 8;
            case 5:
              fetchOptions1.SortExpression = customSortable.BuildSortExpression((ClassMetadata) metadata, fetchOptions1.SortExpression);
              num2 = 18;
              continue;
            case 6:
              if (metadata == null)
              {
                num2 = 24;
                continue;
              }
              goto case 15;
            case 8:
            case 24:
              propertyMetadata2 = (PropertyMetadata) null;
              break;
            case 9:
              if (propertyMetadata1 != null)
                goto case 30;
              else
                goto label_28;
            case 10:
              propertyMetadata2 = metadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => p.Uid == metadata.IsGroupPropertyUid));
              break;
            case 11:
            case 16:
              if (fetchOptions1 != (FetchOptions) null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 23 : 23;
                continue;
              }
              goto label_32;
            case 12:
              fetchOptions1 = fetchOptions;
              num2 = 2;
              continue;
            case 13:
              num2 = 12;
              continue;
            case 14:
              childMetadataList = MetadataLoader.GetChildProperties((ClassMetadata) metadata);
              num2 = 6;
              continue;
            case 15:
              if (metadata.Hierarchical)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 25 : 13;
                continue;
              }
              goto case 8;
            case 17:
              if (fetchOptions1.DisableDefaultGroupSorting)
                goto case 11;
              else
                goto label_21;
            case 19:
              IEnumerable<Order> source = ((IEnumerable<string>) array).Select<string, Order>((Func<string, Order>) (sortItem =>
              {
                int num6 = 14;
                IProjection projection1;
                while (true)
                {
                  int num7 = num6;
                  PropertyMetadata propertyMetadata3;
                  EntityMetadata entityMetadata;
                  string[] siElements;
                  while (true)
                  {
                    string entityName;
                    string realProperty;
                    EntityMetadata realMetadata;
                    EntityPropertyMetadata realPropertyMetadata;
                    NHProvider databaseProvider;
                    ICriteria criteria2;
                    string str1;
                    JoinType joinType;
                    PropertyMetadata propertyMetadata4;
                    IProjection projection2;
                    string expressionFromString;
                    int startIndex;
                    string[] destinationArray;
                    string str2;
                    IProjection projection3;
                    IProjection projection4;
                    PropertyMetadata propertyMetadata5;
                    string si;
                    switch (num7)
                    {
                      case 1:
                        if (projection1 != null)
                        {
                          num7 = 18;
                          continue;
                        }
                        goto case 43;
                      case 2:
                        si = expressionFromString.Substring(startIndex);
                        num7 = 33;
                        continue;
                      case 3:
                        if (expressionFromString.Count<char>() > startIndex)
                        {
                          num7 = 25;
                          continue;
                        }
                        goto case 33;
                      case 4:
                        if (metadata == null)
                        {
                          num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 30 : 62;
                          continue;
                        }
                        goto case 56;
                      case 5:
                      case 18:
                      case 24:
                      case 27:
                      case 37:
                      case 50:
                        if (projection1 == null)
                        {
                          num7 = 54;
                          continue;
                        }
                        if (fetchOptions1.SortDirection == ListSortDirection.Ascending)
                        {
                          num7 = 12;
                          continue;
                        }
                        goto label_30;
                      case 6:
                        projection3 = projection2;
                        goto label_103;
                      case 7:
                      case 52:
                        if (string.IsNullOrEmpty(entityName))
                        {
                          num7 = 44;
                          continue;
                        }
                        goto case 46;
                      case 8:
                        projection1 = (IProjection) Projections.Property(si);
                        num7 = 5;
                        continue;
                      case 9:
                        if (projection1 == null)
                        {
                          num7 = 32;
                          continue;
                        }
                        goto case 5;
                      case 10:
                        expressionFromString = CustomPropertyProjection.GetExpressionFromString(sortItem, out entityName);
                        num7 = 35;
                        continue;
                      case 11:
                        str2 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1350312861 << 3 ^ 2082166840);
                        num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 14 : 42;
                        continue;
                      case 12:
                        goto label_31;
                      case 13:
                        databaseProvider = entityManager.MainDatabaseProvider as NHProvider;
                        num7 = 68;
                        continue;
                      case 14:
                        num7 = 13;
                        continue;
                      case 15:
                      case 44:
                        projection4 = (IProjection) null;
                        break;
                      case 16:
                        projection2 = (IProjection) NHQueryExtensions.PropertyProjection(entityType1, entityName, si, true, out realProperty, out realMetadata, out realPropertyMetadata);
                        num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 18 : 20;
                        continue;
                      case 17:
                        entityMetadata = MetadataLoader.LoadMetadata(propertyMetadata4.SubTypeUid) as EntityMetadata;
                        num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 44 : 66;
                        continue;
                      case 19:
                        propertyMetadata4 = metadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p =>
                        {
                          int num8 = 1;
                          while (true)
                          {
                            switch (num8)
                            {
                              case 1:
                                if (p.Name == null)
                                {
                                  num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
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
                          return p.Name.Equals(siElements[0]);
label_5:
                          return false;
                        }));
                        num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 67 : 39;
                        continue;
                      case 20:
                        projection4 = projection2;
                        break;
                      case 21:
                        projection1 = (IProjection) Projections.Property(si);
                        num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 9 : 37;
                        continue;
                      case 22:
                        goto label_62;
                      case 25:
                        if (!expressionFromString.StartsWith(str2))
                        {
                          num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 30 : 51;
                          continue;
                        }
                        goto case 34;
                      case 26:
                        if (propertyMetadata3 == null)
                          goto default;
                        else
                          goto label_35;
                      case 28:
                        if (propertyMetadata3 != null)
                        {
                          num7 = 69;
                          continue;
                        }
                        goto case 7;
                      case 29:
                        projection1 = (IProjection) Projections.Property(string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112704942), destinationArray));
                        num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 24 : 0;
                        continue;
                      case 30:
                        projection1 = (IProjection) Projections.Property(si);
                        num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 49 : 50;
                        continue;
                      case 31:
                        criteria2 = (ICriteria) null;
                        num7 = 48;
                        continue;
                      case 32:
                        if (childMetadataList.Any<KeyValuePair<PropertyMetadata, ClassMetadata>>((Func<KeyValuePair<PropertyMetadata, ClassMetadata>, bool>) (p => p.Key.Name.Equals(si, StringComparison.OrdinalIgnoreCase))))
                        {
                          num7 = 21;
                          continue;
                        }
                        goto case 5;
                      case 33:
                      case 51:
                        if (si != null)
                        {
                          num7 = 49;
                          continue;
                        }
                        goto case 53;
                      case 34:
                        joinType = JoinType.InnerJoin;
                        num7 = 2;
                        continue;
                      case 35:
                        joinType = JoinType.LeftOuterJoin;
                        num7 = 60;
                        continue;
                      case 36:
                        destinationArray = new string[siElements.Length - 1];
                        num7 = 61;
                        continue;
                      case 38:
                        if (databaseProvider == null)
                        {
                          num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 23 : 7;
                          continue;
                        }
                        goto case 26;
                      case 39:
                      case 41:
                        if (databaseProvider == null)
                        {
                          num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 33 : 52;
                          continue;
                        }
                        goto case 28;
                      case 40:
                        if (criteria2 == null)
                        {
                          num7 = 57;
                          continue;
                        }
                        goto case 70;
                      case 42:
                        startIndex = 11;
                        num7 = 3;
                        continue;
                      case 43:
                        if (!childMetadataList.Any<KeyValuePair<PropertyMetadata, ClassMetadata>>((Func<KeyValuePair<PropertyMetadata, ClassMetadata>, bool>) (p => p.Key.Name.Equals(si, StringComparison.OrdinalIgnoreCase))))
                        {
                          num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 27 : 10;
                          continue;
                        }
                        goto case 8;
                      case 45:
                        siElements = si.Split(new char[1]
                        {
                          '.'
                        }, StringSplitOptions.RemoveEmptyEntries);
                        num7 = 19;
                        continue;
                      case 46:
                        if (NHQueryExtensions.PropertyProjection(entityType1, entityName, si, true, out realProperty, out realMetadata, out realPropertyMetadata) != null)
                        {
                          num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 16 : 16;
                          continue;
                        }
                        goto case 15;
                      case 47:
                        str1 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1204263869 ^ -1341583247 ^ 137678600) + siElements[0];
                        num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 39 : 37;
                        continue;
                      case 48:
                        try
                        {
                          criteria2 = criteria1.GetCriteriaByPath(siElements[0]);
                          int num9 = 0;
                          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
                            num9 = 0;
                          switch (num9)
                          {
                            default:
                              goto label_71;
                          }
                        }
                        catch (Exception ex)
                        {
                          int num10 = 0;
                          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
                            num10 = 0;
                          switch (num10)
                          {
                            default:
                              goto label_71;
                          }
                        }
                      case 49:
                        if (!si.Contains(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1253244298 - 1829393894 ^ -576144032)))
                        {
                          num7 = 53;
                          continue;
                        }
                        goto case 4;
                      case 53:
                      case 59:
                      case 62:
                        if (!(si == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675538719)))
                        {
                          num7 = 63;
                          continue;
                        }
                        goto case 30;
                      case 54:
                        goto label_92;
                      case 55:
                        goto label_30;
                      case 56:
                        num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 45 : 4;
                        continue;
                      case 57:
                        criteria1.CreateAlias(siElements[0], z2jc63fLkugS1X8Q9N.tE1kD1vbB(901793403 ^ 902167873) + siElements[0], joinType);
                        num7 = 47;
                        continue;
                      case 58:
                        projection3 = databaseProvider.GenerateOrderByProjection(metadata, propertyMetadata3, entityName, si);
                        goto label_103;
                      case 60:
                        si = expressionFromString;
                        num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 7 : 11;
                        continue;
                      case 61:
                        Array.Copy((Array) siElements, 1, (Array) destinationArray, 0, destinationArray.Length);
                        num7 = 29;
                        continue;
                      case 63:
                      case 64:
                        if (metadata == null)
                        {
                          num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 75 : 13;
                          continue;
                        }
                        propertyMetadata5 = metadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p =>
                        {
                          int num11 = 1;
                          while (true)
                          {
                            switch (num11)
                            {
                              case 1:
                                if (p.Name != null)
                                {
                                  num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
                                  continue;
                                }
                                goto label_5;
                              default:
                                goto label_4;
                            }
                          }
label_4:
                          return p.Name.Equals(si, StringComparison.CurrentCultureIgnoreCase);
label_5:
                          return false;
                        }));
                        goto label_101;
                      case 65:
                        projection3 = (IProjection) null;
                        goto label_103;
                      case 66:
                        if (entityMetadata == null)
                        {
                          num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 19 : 22;
                          continue;
                        }
                        goto label_96;
                      case 67:
                        if (propertyMetadata4 != null)
                        {
                          num7 = 73;
                          continue;
                        }
                        goto case 36;
                      case 68:
                        projection1 = (IProjection) null;
                        num7 = 71;
                        continue;
                      case 69:
                        projection4 = databaseProvider.PrepareOrderByProjection((IProjection) Projections.Property(str1 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837669185) + siElements[1]), propertyMetadata3?.TypeUid);
                        break;
                      case 70:
                        str1 = criteria2.Alias;
                        num7 = 41;
                        continue;
                      case 71:
                        propertyMetadata3 = (PropertyMetadata) null;
                        num7 = 10;
                        continue;
                      case 72:
label_71:
                        str1 = (string) null;
                        num7 = 40;
                        continue;
                      case 73:
                        if (propertyMetadata4.TypeUid == EntityDescriptor.UID)
                        {
                          num7 = 17;
                          continue;
                        }
                        goto case 36;
                      case 74:
                        if (NHQueryExtensions.PropertyProjection(entityType1, entityName, si, true, out realProperty, out realMetadata, out realPropertyMetadata) == null)
                        {
                          num7 = 65;
                          continue;
                        }
                        projection2 = (IProjection) NHQueryExtensions.PropertyProjection(entityType1, entityName, si, true, out realProperty, out realMetadata, out realPropertyMetadata);
                        num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 6;
                        continue;
                      case 75:
                        propertyMetadata5 = (PropertyMetadata) null;
                        goto label_101;
                      default:
                        if (!string.IsNullOrEmpty(entityName))
                        {
                          num7 = 74;
                          continue;
                        }
                        goto case 65;
                    }
                    projection1 = projection4;
                    num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 1;
                    continue;
label_101:
                    propertyMetadata3 = propertyMetadata5;
                    num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 37 : 38;
                    continue;
label_103:
                    projection1 = projection3;
                    num7 = 9;
                  }
label_35:
                  num6 = 58;
                  continue;
label_62:
                  PropertyMetadata propertyMetadata6 = (PropertyMetadata) null;
                  goto label_97;
label_96:
                  propertyMetadata6 = entityMetadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p =>
                  {
                    int num12 = 1;
                    while (true)
                    {
                      switch (num12)
                      {
                        case 1:
                          if (p.Name != null)
                          {
                            num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 0;
                            continue;
                          }
                          goto label_3;
                        default:
                          goto label_2;
                      }
                    }
label_2:
                    return p.Name.Equals(siElements[1]);
label_3:
                    return false;
                  }));
label_97:
                  propertyMetadata3 = propertyMetadata6;
                  num6 = 31;
                }
label_30:
                return Order.Desc(projection1);
label_31:
                return Order.Asc(projection1);
label_92:
                return (Order) null;
              }));
              // ISSUE: reference to a compiler-generated field
              Func<Order, bool> func = EntityManager<T, IdT>.\u003C\u003Ec.\u003C\u003E9__129_3;
              Func<Order, bool> predicate;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                EntityManager<T, IdT>.\u003C\u003Ec.\u003C\u003E9__129_3 = predicate = (Func<Order, bool>) (o => o != null);
              }
              else
                goto label_46;
label_45:
              criteria1 = source.Where<Order>(predicate).Aggregate<Order, ICriteria>(criteria1, (Func<ICriteria, Order, ICriteria>) ((current, order) => current.AddOrder(order)));
              num2 = 27;
              continue;
label_46:
              predicate = func;
              goto label_45;
            case 20:
              if (fetchOptions1.SortExpression != propertyMetadata1.Name)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 17 : 6;
                continue;
              }
              goto case 11;
            case 21:
              customSortable = ComponentManager.Current.GetExtensionPoints<ICustomSortable>().FirstOrDefault<ICustomSortable>((Func<ICustomSortable, bool>) (s => s.CheckMetadata((ClassMetadata) metadata, fetchOptions1.SortExpression)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 22 : 22;
              continue;
            case 22:
              if (customSortable == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 1 : 1;
                continue;
              }
              goto case 5;
            case 23:
              if (!string.IsNullOrEmpty(fetchOptions1.SortExpression))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 17 : 21;
                continue;
              }
              goto label_39;
            case 25:
              if (metadata.HierarchyType == HierarchyType.GroupAndElements)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 4 : 2;
                continue;
              }
              goto case 8;
            case 26:
              criteria1 = criteria;
              num2 = 28;
              continue;
            case 27:
              goto label_43;
            case 28:
              entityType1 = entityType;
              num2 = 3;
              continue;
            case 29:
              metadata = !(entityType1 == this.ImplementationType) ? MetadataLoader.LoadMetadata(entityType1) as EntityMetadata : this.ImplementationTypeMetadata;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 14;
              continue;
            case 30:
              if (fetchOptions1 == (FetchOptions) null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
                continue;
              }
              goto case 20;
            default:
              criteria1.AddOrder(Order.Desc(propertyMetadata1.Name));
              num2 = 16;
              continue;
          }
          propertyMetadata1 = propertyMetadata2;
          num2 = 9;
        }
label_21:
        num1 = 7;
        continue;
label_28:
        num1 = 11;
      }
label_43:
      return;
label_39:
      return;
label_32:;
    }

    /// <summary>
    /// Применить параметры выборки к указанному типу сущности
    /// </summary>
    /// <param name="criteria">Критерий</param>
    /// <param name="fetchOptions">Параметры выборки</param>
    /// <param name="entityType">Тип сущности</param>
    protected virtual void SetupFetchOptions(
      ICriteria criteria,
      FetchOptions fetchOptions,
      Type entityType)
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        EntityMetadata metadata;
        ProjectionList projectionList;
        while (true)
        {
          List<string> stringList1;
          List<string> stringList2;
          List<string>.Enumerator enumerator;
          SelectMode selectMode;
          int num3;
          List<string> stringList3;
          Type type;
          switch (num2)
          {
            case 1:
              try
              {
label_23:
                if (enumerator.MoveNext())
                  goto label_17;
                else
                  goto label_24;
label_12:
                string[] names;
                string propertyName;
                string current;
                string alias;
                CustomPropertyProjection customProj;
                EntityMetadata realMetadata;
                int num4;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      this.AddFetchColumnIfNeeded(metadata, (IEnumerable<string>) stringList2, stringList1, current);
                      num4 = 4;
                      continue;
                    case 2:
                      goto label_3;
                    case 3:
                      goto label_17;
                    case 5:
                      alias = (string) null;
                      num4 = 9;
                      continue;
                    case 6:
                      if (names.Length == 3)
                      {
                        num4 = 11;
                        continue;
                      }
                      goto case 1;
                    case 8:
                      EntityMetadata entityMetadata = realMetadata;
                      this.AddFetchColumnIfNeeded(entityMetadata == null ? metadata : entityMetadata, (IEnumerable<string>) stringList2, stringList1, propertyName);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
                      continue;
                    case 9:
                      propertyName = "";
                      num4 = 10;
                      continue;
                    case 10:
                      this.GetRealProjection(names, entityType, out customProj, out alias, out realMetadata, out EntityPropertyMetadata _, out propertyName);
                      num4 = 12;
                      continue;
                    case 11:
                      customProj = (CustomPropertyProjection) null;
                      num4 = 5;
                      continue;
                    case 12:
                      if (customProj == null)
                      {
                        num4 = 7;
                        continue;
                      }
                      goto case 8;
                    case 13:
                      names = current.Split(new char[1]
                      {
                        ':'
                      }, StringSplitOptions.RemoveEmptyEntries);
                      num4 = 6;
                      continue;
                    default:
                      goto label_23;
                  }
                }
label_17:
                current = enumerator.Current;
                num4 = 13;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
                {
                  num4 = 1;
                  goto label_12;
                }
                else
                  goto label_12;
label_24:
                num4 = 2;
                goto label_12;
              }
              finally
              {
                enumerator.Dispose();
                int num5 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
                  num5 = 0;
                switch (num5)
                {
                  default:
                }
              }
            case 2:
            case 9:
              if (fetchOptions.SelectColumns.FirstOrDefault<string>((Func<string, bool>) (c => c.Equals(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1290212282 ^ -644262414 ^ 1786903510), StringComparison.OrdinalIgnoreCase))) != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 3 : 5;
                continue;
              }
              goto case 40;
            case 3:
              if (fetchOptions.MaxResults <= 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 24 : 42;
                continue;
              }
              goto case 37;
            case 4:
              criteria = criteria.SetFirstResult(fetchOptions.FirstResult);
              num2 = 3;
              continue;
            case 5:
            case 19:
              goto label_42;
            case 6:
label_98:
              List<string> selectColumns = fetchOptions.SelectColumns;
              // ISSUE: reference to a compiler-generated field
              Func<string, bool> func = EntityManager<T, IdT>.\u003C\u003Ec.\u003C\u003E9__130_0;
              Func<string, bool> predicate;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                EntityManager<T, IdT>.\u003C\u003Ec.\u003C\u003E9__130_0 = predicate = (Func<string, bool>) (c => c.Equals(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 1867346093), StringComparison.OrdinalIgnoreCase));
              }
              else
                goto label_107;
label_101:
              if (selectColumns.FirstOrDefault<string>(predicate) != null)
              {
                num2 = 9;
                continue;
              }
              goto default;
label_107:
              predicate = func;
              goto label_101;
            case 7:
              projectionList.Add((IProjection) Projections.Property(this.GetTypeUidPropertyName(entityType)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-649342099 - -1150814748 ^ 501456875));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 13 : 19;
              continue;
            case 8:
              criteria.FetchModeForProjections(true);
              num2 = 22;
              continue;
            case 10:
              stringList3 = fetchOptions.FetchRelations;
              if (stringList3 == null)
              {
                num2 = 30;
                continue;
              }
              goto label_95;
            case 11:
              criteria.SetResultTransformer((IResultTransformer) new EleWise.ELMA.Runtime.NH.AliasToBeanResultTransformer(entityType));
              num2 = 36;
              continue;
            case 12:
              this.SetupSortOptions(criteria, fetchOptions, entityType);
              num2 = 31;
              continue;
            case 13:
              goto label_99;
            case 14:
              if (entityType == (Type) null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 21 : 28;
                continue;
              }
              goto case 34;
            case 15:
              FetchOptionsBuilder.ResolveFetchColumns(criteria, (IEnumerable<string>) stringList2.ToList<string>(), SelectMode.Fetch);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 33 : 10;
              continue;
            case 16:
            case 20:
              enumerator = fetchOptions.SelectColumns.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 1 : 1;
              continue;
            case 17:
              if (fetchOptions.UsePartialFetching)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 25 : 9;
                continue;
              }
              goto case 24;
            case 18:
              projectionList = Projections.ProjectionList();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 8 : 1;
              continue;
            case 21:
              goto label_55;
            case 22:
              enumerator = fetchOptions.SelectColumns.GetEnumerator();
              num2 = 32;
              continue;
            case 23:
            case 42:
              type = entityType;
              if ((object) type == null)
              {
                num2 = 26;
                continue;
              }
              break;
            case 24:
              num3 = 1;
              goto label_106;
            case 25:
              num3 = 6;
              goto label_106;
            case 26:
              type = this.ImplementationType;
              break;
            case 27:
              FetchOptionsBuilder.ResolveFetchColumns(criteria, (IEnumerable<string>) stringList1.ToList<string>(), selectMode, true);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 15 : 8;
              continue;
            case 28:
              goto label_96;
            case 29:
              if (fetchOptions.SelectColumns.Count <= 0)
                goto case 35;
              else
                goto label_6;
            case 30:
              stringList3 = new List<string>();
              goto label_95;
            case 31:
              stringList1 = new List<string>();
              num2 = 10;
              continue;
            case 32:
              try
              {
label_64:
                if (enumerator.MoveNext())
                  goto label_75;
                else
                  goto label_65;
label_61:
                string current;
                int num6;
                while (true)
                {
                  string[] names;
                  CustomPropertyProjection customProj;
                  string alias;
                  EntityMetadata realMetadata;
                  string propertyName1;
                  string propertyName2;
                  string str;
                  switch (num6)
                  {
                    case 1:
                    case 10:
                    case 11:
                      goto label_64;
                    case 2:
                      this.AddFetchColumnIfNeeded(realMetadata ?? metadata, (IEnumerable<string>) stringList2, stringList1, propertyName1);
                      num6 = 10;
                      continue;
                    case 3:
                      this.GetRealProjection(names, entityType, out customProj, out alias, out realMetadata, out EntityPropertyMetadata _, out propertyName1);
                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 4 : 7;
                      continue;
                    case 4:
                      projectionList.Add((IProjection) customProj, alias);
                      num6 = 2;
                      continue;
                    case 5:
                      customProj = (CustomPropertyProjection) null;
                      num6 = 16;
                      continue;
                    case 6:
                      projectionList.Add((IProjection) Projections.Property(propertyName2), current);
                      num6 = 14;
                      continue;
                    case 7:
                      if (customProj == null)
                      {
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 1 : 1;
                        continue;
                      }
                      goto case 4;
                    case 8:
                      if (current == z2jc63fLkugS1X8Q9N.tE1kD1vbB(1012087039 ^ 1012103837))
                      {
                        num6 = 13;
                        continue;
                      }
                      goto case 9;
                    case 9:
                      str = current;
                      break;
                    case 12:
                      goto label_75;
                    case 13:
                      str = this.GetTypeUidPropertyName(entityType);
                      break;
                    case 14:
                      this.AddFetchColumnIfNeeded(metadata, (IEnumerable<string>) stringList2, stringList1, current);
                      num6 = 11;
                      continue;
                    case 15:
                      names = current.Split(new char[1]
                      {
                        ':'
                      }, StringSplitOptions.RemoveEmptyEntries);
                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 0;
                      continue;
                    case 16:
                      alias = (string) null;
                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 2 : 18;
                      continue;
                    case 17:
                      goto label_98;
                    case 18:
                      propertyName1 = "";
                      num6 = 3;
                      continue;
                    default:
                      if (names.Length == 3)
                      {
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 4 : 5;
                        continue;
                      }
                      goto case 8;
                  }
                  propertyName2 = str;
                  num6 = 6;
                }
label_65:
                num6 = 17;
                goto label_61;
label_75:
                current = enumerator.Current;
                num6 = 15;
                goto label_61;
              }
              finally
              {
                enumerator.Dispose();
                int num7 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
                  num7 = 0;
                switch (num7)
                {
                  default:
                }
              }
            case 33:
              goto label_91;
            case 34:
              if (!(entityType == this.ImplementationType))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 21 : 5;
                continue;
              }
              goto label_96;
            case 35:
            case 36:
label_3:
              if (!FetchOptionsBuilder.IsCanOptimaze(criteria, (IEnumerable<string>) stringList1.Union<string>((IEnumerable<string>) stringList2).ToList<string>(), metadata))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 4 : 13;
                continue;
              }
              goto case 38;
            case 37:
              criteria = criteria.SetMaxResults(fetchOptions.MaxResults);
              num2 = 23;
              continue;
            case 38:
              if (!fetchOptions.UseProjections)
                goto case 24;
              else
                goto label_41;
            case 39:
              if (!fetchOptions.UseProjections)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 15 : 16;
                continue;
              }
              goto case 18;
            case 40:
              if (metadata.AllowCreateHeirs)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 1 : 7;
                continue;
              }
              goto label_42;
            case 41:
              if (fetchOptions.SelectColumns != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 23 : 29;
                continue;
              }
              goto case 35;
            default:
              projectionList.Add((IProjection) Projections.Property(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1178210108 ^ 1178242658)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(236071375 ^ 236103825));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 2 : 2;
              continue;
          }
          entityType = type;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 12 : 5;
          continue;
label_95:
          stringList2 = stringList3;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 14 : 7;
          continue;
label_106:
          selectMode = (SelectMode) num3;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 27 : 17;
        }
label_6:
        num1 = 39;
        continue;
label_41:
        num1 = 17;
        continue;
label_42:
        criteria.AddProjection((IProjection) projectionList);
        num1 = 11;
        continue;
label_55:
        EntityMetadata entityMetadata1 = MetadataLoader.LoadMetadata(entityType) as EntityMetadata;
        goto label_97;
label_96:
        entityMetadata1 = this.ImplementationTypeMetadata;
label_97:
        metadata = entityMetadata1;
        num1 = 41;
      }
label_99:
      return;
label_91:;
    }

    protected EntityMetadata ImplementationTypeMetadata => (EntityMetadata) MetadataLoader.LoadMetadata(this.ImplementationType, loadImplementation: false);

    private void GetRealProjection(
      string[] names,
      Type entityType,
      out CustomPropertyProjection customProj,
      out string alias,
      out EntityMetadata realMetadata,
      out EntityPropertyMetadata realPropertyMetadata,
      out string propertyName)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.GetRealProjection(names[2], names[0], entityType, out customProj, out alias, out realMetadata, out realPropertyMetadata, out propertyName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    private void GetRealProjection(
      string columnName,
      string entityName,
      Type entityType,
      out CustomPropertyProjection customProj,
      out string alias,
      out EntityMetadata realMetadata,
      out EntityPropertyMetadata realPropertyMetadata,
      out string propertyName)
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        string realProperty;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (customProj != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 8 : 1;
                continue;
              }
              goto label_3;
            case 2:
              goto label_9;
            case 3:
              alias = CustomPropertyProjection.GetStringFromExpression(columnName, entityName);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 1 : 7;
              continue;
            case 4:
              goto label_5;
            case 5:
              if (!columnName.Equals(realProperty, StringComparison.OrdinalIgnoreCase))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 0 : 0;
                continue;
              }
              goto label_15;
            case 6:
              goto label_16;
            case 7:
              customProj = NHQueryExtensions.PropertyProjection(entityType, entityName, columnName, false, out realProperty, out realMetadata, out realPropertyMetadata);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 1;
              continue;
            case 8:
              if (string.IsNullOrEmpty(realProperty))
              {
                num2 = 6;
                continue;
              }
              goto case 5;
            default:
              alias = CustomPropertyProjection.GetStringFromExpression(realProperty, entityName);
              num2 = 2;
              continue;
          }
        }
label_5:
        propertyName = columnName;
        num1 = 3;
      }
label_9:
      return;
label_16:
      return;
label_3:
      return;
label_15:;
    }

    /// <summary>
    /// Добавляем колонку в Fetch.Join, если она ссылочного типа
    /// </summary>
    /// <param name="metadata"></param>
    /// <param name="globalFetchColumns"></param>
    /// <param name="fetchColumns"></param>
    /// <param name="col"></param>
    private void AddFetchColumnIfNeeded(
      EntityMetadata metadata,
      IEnumerable<string> globalFetchColumns,
      List<string> fetchColumns,
      string col)
    {
      string name = col;
      if (name.Contains(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1819636893 << 3 ^ 1672199724)))
      {
        name = ((IEnumerable<string>) name.Split(new string[1]
        {
          z2jc63fLkugS1X8Q9N.tE1kD1vbB(1654249598 >> 2 ^ 413560027)
        }, StringSplitOptions.RemoveEmptyEntries)).LastOrDefault<string>();
        if (string.IsNullOrEmpty(name))
          return;
      }
      if (!FetchOptionsBuilder.IsRefTypeColumn(metadata, name) || !globalFetchColumns.All<string>((Func<string, bool>) (c => c != col)))
        return;
      fetchColumns.Add(col);
    }

    /// <summary>Применить фильтр к критерию выбора</summary>
    /// <param name="criteria">Критерий выбора</param>
    /// <param name="filter">Фильтр</param>
    [Auditable]
    public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
    {
      int num1 = 30;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          FilterForAttribute attribute;
          PropertyMetadata propertyMetadata1;
          PropertyMetadata propertyMetadata2;
          bool flag;
          Type fetchType;
          PropertyMetadata propertyMetadata3;
          PropertyMetadata propertyMetadata4;
          EntityMetadata metadata;
          EntityMetadata metadataGr;
          switch (num2)
          {
            case 1:
              if (!(metadataGr.IsGroupPropertyUid != Guid.Empty))
              {
                num2 = 23;
                continue;
              }
              propertyMetadata4 = metadataGr.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => p.Uid == metadataGr.IsGroupPropertyUid));
              goto label_68;
            case 2:
            case 10:
              fetchType = this.GetFetchType(filter);
              num2 = 28;
              continue;
            case 3:
            case 6:
            case 42:
              if (!filter.ShowOnlyGroups)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 12 : 15;
                continue;
              }
              goto case 32;
            case 4:
              if (!attribute.EntityType.IsAssignableFrom(this.ImplementationType))
              {
                num2 = 46;
                continue;
              }
              goto case 37;
            case 5:
              criteria.Add(filter.HierarchyParent != null ? (ICriterion) Restrictions.Eq(propertyMetadata1.Name, filter.HierarchyParent) : (ICriterion) Restrictions.IsNull(propertyMetadata1.Name));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 3 : 2;
              continue;
            case 7:
              propertyMetadata3 = (PropertyMetadata) null;
              break;
            case 8:
              if (propertyMetadata2 == null)
              {
                num2 = 35;
                continue;
              }
              goto case 41;
            case 9:
              attribute = AttributeHelper<FilterForAttribute>.GetAttribute(filter.GetType(), true);
              num2 = 26;
              continue;
            case 11:
              if (!string.IsNullOrWhiteSpace(filter.Query))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 27 : 7;
                continue;
              }
              goto label_55;
            case 12:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 16;
              continue;
            case 13:
              goto label_11;
            case 14:
              if (propertyMetadata1 == null)
              {
                num2 = 42;
                continue;
              }
              goto case 5;
            case 15:
            case 21:
            case 35:
              if (string.IsNullOrEmpty(filter.SearchString))
              {
                num2 = 31;
                continue;
              }
              goto case 24;
            case 16:
              metadata = !(fetchType == this.ImplementationType) ? MetadataLoader.LoadMetadata(fetchType) as EntityMetadata : this.ImplementationTypeMetadata;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 32 : 39;
              continue;
            case 17:
              criteria.Add((ICriterion) Restrictions.IdEq(filter.Id));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 2 : 2;
              continue;
            case 18:
              if (!(metadata.ParentPropertyUid != Guid.Empty))
              {
                num2 = 7;
                continue;
              }
              propertyMetadata3 = metadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => p.Uid == metadata.ParentPropertyUid));
              break;
            case 19:
              if (metadataGr != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 33 : 0;
                continue;
              }
              goto case 23;
            case 20:
            case 22:
            case 34:
            case 46:
              if (!flag)
              {
                num2 = 11;
                continue;
              }
              goto label_41;
            case 23:
              propertyMetadata4 = (PropertyMetadata) null;
              goto label_68;
            case 24:
              this.SetupFastSearchFilter(criteria, filter);
              num2 = 43;
              continue;
            case 25:
              if (!filter.DisableAutoFilter)
                goto case 9;
              else
                goto label_59;
            case 26:
              if (attribute == null)
              {
                num2 = 20;
                continue;
              }
              goto case 4;
            case 27:
              if (this.ImplementationTypeMetadata != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 40 : 36;
                continue;
              }
              goto label_44;
            case 28:
              if (!filter.FilterByHierarchyParent)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 6 : 3;
                continue;
              }
              goto case 12;
            case 29:
              if (filter != null)
              {
                if (filter.Id == null)
                {
                  num2 = 10;
                  continue;
                }
                goto case 17;
              }
              else
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 36 : 11;
                continue;
              }
            case 30:
              Contract.ArgumentNotNull((object) criteria, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1255365154 ^ 596875508 ^ -1766062388));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 29 : 7;
              continue;
            case 31:
            case 43:
              flag = false;
              num2 = 25;
              continue;
            case 32:
              num2 = 38;
              continue;
            case 33:
              if (metadataGr.Hierarchical)
              {
                num2 = 44;
                continue;
              }
              goto case 23;
            case 36:
              goto label_62;
            case 37:
              this.SetupAutoFilter(criteria, filter);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 45 : 9;
              continue;
            case 38:
              metadataGr = fetchType == this.ImplementationType ? this.ImplementationTypeMetadata : MetadataLoader.LoadMetadata(fetchType) as EntityMetadata;
              num2 = 19;
              continue;
            case 39:
              if (metadata != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
                continue;
              }
              goto case 7;
            case 40:
              this.SetupFilterQuery(criteria, filter, this.ImplementationTypeMetadata);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 13 : 0;
              continue;
            case 41:
              criteria.Add((ICriterion) Restrictions.Eq(propertyMetadata2.Name, (object) true));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 16 : 21;
              continue;
            case 44:
              if (metadataGr.HierarchyType == HierarchyType.GroupAndElements)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 1 : 1;
                continue;
              }
              goto case 23;
            case 45:
              flag = true;
              num2 = 34;
              continue;
            default:
              if (metadata.Hierarchical)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 18 : 17;
                continue;
              }
              goto case 7;
          }
          propertyMetadata1 = propertyMetadata3;
          num2 = 14;
          continue;
label_68:
          propertyMetadata2 = propertyMetadata4;
          num2 = 8;
        }
label_59:
        num1 = 22;
      }
label_11:
      return;
label_62:
      return;
label_55:
      return;
label_44:
      return;
label_41:;
    }

    /// <summary>
    /// Применить условие выборки на языке EQL в критерий отбора
    /// </summary>
    /// <param name="criteria">Критерий выбора</param>
    /// <param name="query">Условие выборки на языке EQL</param>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Use SetupFilterQuery(ICriteria, IEntityFilter, EntityMetadata, alias) instead", true)]
    protected virtual void SetupFilterQuery(ICriteria criteria, string query)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_4;
          case 2:
            goto label_2;
          case 3:
            if (this.ImplementationTypeMetadata == null)
            {
              num = 2;
              continue;
            }
            break;
        }
        ICriteria criteria1 = criteria;
        Filter filter = new Filter();
        filter.Query = query;
        EntityMetadata implementationTypeMetadata = this.ImplementationTypeMetadata;
        this.SetupFilterQuery(criteria1, (IEntityFilter) filter, implementationTypeMetadata);
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 1 : 1;
      }
label_4:
      return;
label_2:;
    }

    /// <summary>
    /// Тип для поиска полей в быстром поиске (учитываются все дочерние классы)
    /// </summary>
    /// <param name="filter"></param>
    /// <returns></returns>
    [Auditable]
    protected virtual Type GetTypeForFastSearch(IEntityFilter filter) => this.ImplementationType;

    /// <summary>Свойства для быстрого поиска</summary>
    /// <param name="metadata"></param>
    /// <returns></returns>
    [Auditable]
    protected virtual List<EntityPropertyMetadata> GetPropertiesForFastSearch(
      EntityMetadata metadata,
      IEntityFilter filter)
    {
      return MetadataLoader.GetChildProperties((ClassMetadata) metadata).Select<KeyValuePair<PropertyMetadata, ClassMetadata>, PropertyMetadata>((Func<KeyValuePair<PropertyMetadata, ClassMetadata>, PropertyMetadata>) (p => p.Key)).OfType<EntityPropertyMetadata>().Where<EntityPropertyMetadata>((Func<EntityPropertyMetadata, bool>) (p =>
      {
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_6;
            case 2:
              goto label_8;
            case 3:
              if (!p.InFastSearch)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 2 : 2;
                continue;
              }
              break;
          }
          if (!(p.TypeUid == StringDescriptor.UID))
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 1 : 1;
          else
            goto label_7;
        }
label_6:
        return p.TypeUid == TextDescriptor.UID;
label_7:
        return true;
label_8:
        return false;
      })).ToList<EntityPropertyMetadata>();
    }

    /// <summary>Применить строку быстрого поиска</summary>
    /// <param name="criteria">Критерий выбора</param>
    /// <param name="filter">Фильтр</param>
    [Auditable]
    protected virtual void SetupFastSearchFilter(ICriteria criteria, IEntityFilter filter)
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        Disjunction disjunction;
        while (true)
        {
          switch (num2)
          {
            case 1:
              disjunction = Restrictions.Disjunction();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_5;
            case 3:
              goto label_3;
            default:
              this.SetupFastSearchFilter(disjunction, filter, criteria);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 2 : 0;
              continue;
          }
        }
label_5:
        criteria.Add((ICriterion) disjunction);
        num1 = 3;
      }
label_3:;
    }

    [Auditable]
    protected virtual void SetupFastSearchFilter(
      Disjunction disjunction,
      IEntityFilter filter,
      ICriteria criteria)
    {
      int num1 = 17;
      while (true)
      {
        int num2 = num1;
        string[] strArray1;
        string[] strArray2;
        EntityMetadata metadata;
        List<KeyValuePair<PropertyMetadata, ClassMetadata>> childProperties;
        Conjunction conjunction;
        AbstractCriterion abstractCriterion;
        List<EntityPropertyMetadata>.Enumerator enumerator;
        string str;
        List<EntityPropertyMetadata> propertiesForFastSearch;
        int index;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_53;
            case 1:
            case 13:
              str = strArray2[index];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 4 : 5;
              continue;
            case 2:
              goto label_14;
            case 3:
            case 10:
              ++index;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 14 : 8;
              continue;
            case 4:
              conjunction.Add((ICriterion) abstractCriterion);
              num2 = 10;
              continue;
            case 5:
              abstractCriterion = (AbstractCriterion) null;
              num2 = 21;
              continue;
            case 6:
              goto label_4;
            case 7:
              if (conjunction != null)
                goto case 4;
              else
                goto label_10;
            case 8:
            case 14:
              if (index < strArray2.Length)
              {
                num2 = 13;
                continue;
              }
              goto label_52;
            case 9:
              try
              {
label_40:
                if (enumerator.MoveNext())
                  goto label_25;
                else
                  goto label_41;
label_20:
                EntityPropertyMetadata current;
                int num3;
                while (true)
                {
                  int num4;
                  EntityMetadata realMetadata;
                  CustomPropertyProjection customProj;
                  KeyValuePair<PropertyMetadata, ClassMetadata> keyValuePair;
                  Type typeByUid;
                  IEnumerable<KeyValuePair<PropertyMetadata, ClassMetadata>> source;
                  EntityPropertyMetadata prop;
                  switch (num3)
                  {
                    case 1:
                      source = childProperties.Where<KeyValuePair<PropertyMetadata, ClassMetadata>>((Func<KeyValuePair<PropertyMetadata, ClassMetadata>, bool>) (p => p.Key.Uid == prop.Uid));
                      num4 = 8;
                      break;
                    case 2:
                    case 4:
                    case 7:
                    case 9:
                    case 16:
                      goto label_40;
                    case 3:
                      if (!(metadata.Uid == realMetadata.Uid))
                      {
                        num4 = 22;
                        break;
                      }
                      goto case 17;
                    case 5:
                      goto label_11;
                    case 6:
                    case 19:
                      abstractCriterion = ElmaRestrictions.InsensitiveLike((IProjection) customProj, str, MatchMode.Anywhere);
                      num4 = 4;
                      break;
                    case 8:
                      if (source.Any<KeyValuePair<PropertyMetadata, ClassMetadata>>())
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 14 : 20;
                        continue;
                      }
                      goto label_40;
                    case 10:
                      this.GetRealProjection(keyValuePair.Key.Name, keyValuePair.Value.FullTypeName, typeByUid, out customProj, out string _, out realMetadata, out EntityPropertyMetadata _, out string _);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 12 : 5;
                      continue;
                    case 11:
                      abstractCriterion |= ElmaRestrictions.InsensitiveLike(this.AliasProperty(prop.Name), str, MatchMode.Anywhere);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 16 : 16;
                      continue;
                    case 12:
                      if (customProj == null)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 8 : 23;
                        continue;
                      }
                      goto case 3;
                    case 13:
                      if (childProperties.Any<KeyValuePair<PropertyMetadata, ClassMetadata>>((Func<KeyValuePair<PropertyMetadata, ClassMetadata>, bool>) (p => p.Key.Name == prop.Name && p.Key.TypeUid != StringDescriptor.UID && p.Key.TypeUid != TextDescriptor.UID)))
                      {
                        num3 = 9;
                        continue;
                      }
                      goto case 1;
                    case 14:
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 3 : 25;
                      continue;
                    case 15:
                      goto label_25;
                    case 17:
                    case 23:
                      if (abstractCriterion != null)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 11;
                        continue;
                      }
                      goto case 18;
                    case 18:
                      abstractCriterion = ElmaRestrictions.InsensitiveLike(this.AliasProperty(prop.Name), str, MatchMode.Anywhere);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 2 : 2;
                      continue;
                    case 20:
                      keyValuePair = source.First<KeyValuePair<PropertyMetadata, ClassMetadata>>();
                      num4 = 21;
                      break;
                    case 21:
                      typeByUid = this.MetadataRuntimeService.GetTypeByUid(keyValuePair.Value.Uid);
                      num3 = 10;
                      continue;
                    case 22:
                    case 24:
                      if (abstractCriterion == null)
                      {
                        num3 = 6;
                        continue;
                      }
                      goto default;
                    case 25:
                      prop = current;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 8 : 13;
                      continue;
                    default:
                      abstractCriterion |= ElmaRestrictions.InsensitiveLike((IProjection) customProj, str, MatchMode.Anywhere);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 7 : 5;
                      continue;
                  }
                  num3 = num4;
                }
label_25:
                current = enumerator.Current;
                num3 = 14;
                goto label_20;
label_41:
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 5 : 0;
                goto label_20;
              }
              finally
              {
                enumerator.Dispose();
                int num5 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
                  num5 = 0;
                switch (num5)
                {
                  default:
                }
              }
            case 11:
              if (strArray1.Length != 0)
              {
                strArray2 = strArray1;
                num2 = 18;
                continue;
              }
              num2 = 22;
              continue;
            case 12:
              strArray1 = filter.SearchString.Split(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740352778).ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 11 : 3;
              continue;
            case 15:
              if (metadata != null)
              {
                childProperties = MetadataLoader.GetChildProperties((ClassMetadata) metadata);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 16 : 20;
                continue;
              }
              num2 = 6;
              continue;
            case 16:
              disjunction.Add((ICriterion) conjunction);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 2 : 1;
              continue;
            case 17:
              conjunction = Restrictions.Conjunction();
              num2 = 16;
              continue;
            case 18:
              index = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 8 : 1;
              continue;
            case 19:
label_11:
              if (abstractCriterion != null)
              {
                num2 = 7;
                continue;
              }
              goto case 3;
            case 20:
              propertiesForFastSearch = this.GetPropertiesForFastSearch(metadata, filter);
              num2 = 12;
              continue;
            case 21:
              enumerator = propertiesForFastSearch.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 9 : 7;
              continue;
            case 22:
              goto label_3;
            default:
              goto label_50;
          }
        }
label_10:
        num1 = 3;
        continue;
label_14:
        metadata = MetadataLoader.LoadMetadata(this.GetTypeForFastSearch(filter)) as EntityMetadata;
        num1 = 15;
      }
label_53:
      return;
label_4:
      return;
label_3:
      return;
label_50:
      return;
label_52:;
    }

    /// <summary>
    /// Применить поля автофильтра в критерий отбора для текущей сущности (по имени)
    /// </summary>
    /// <param name="criteria">Критерий выбора</param>
    /// <param name="filter">Фильтр</param>
    protected virtual void SetupAutoFilter(ICriteria criteria, IEntityFilter filter)
    {
      int num = 2;
      EntityMetadata implementationTypeMetadata;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            if (implementationTypeMetadata == null)
            {
              num = 3;
              continue;
            }
            this.SetupAutoFilter(criteria, filter, implementationTypeMetadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
            continue;
          case 2:
            implementationTypeMetadata = this.ImplementationTypeMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_6;
          default:
            goto label_8;
        }
      }
label_2:
      return;
label_6:
      return;
label_8:;
    }

    /// <summary>
    /// Применить поля автофильтра в критерий отбора (по имени)
    /// </summary>
    /// <param name="criteria">Критерий выбора</param>
    /// <param name="filter">Фильтр</param>
    /// <param name="metadata">Метаданны объекта, к которму применяется фильтр</param>
    /// <param name="alias"></param>
    protected virtual void SetupAutoFilter(
      ICriteria criteria,
      IEntityFilter filter,
      EntityMetadata metadata,
      string alias = null)
    {
      int num1 = 7;
      while (true)
      {
        int num2 = num1;
        IEnumerator<EntityPropertyMetadata> enumerator;
        while (true)
        {
          switch (num2)
          {
            case 1:
              try
              {
label_23:
                if (enumerator.MoveNext())
                  goto label_19;
                else
                  goto label_24;
label_8:
                EntityPropertyMetadata current;
                PropertyInfo reflectionProperty;
                IFilterableType typeDescriptor1;
                ITypeDescriptor typeDescriptor2;
                object obj;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 4:
                      if (!reflectionProperty.IsDefined(typeof (PropertyAttribute), true))
                      {
                        num3 = 17;
                        continue;
                      }
                      goto label_23;
                    case 6:
                      if (!current.Filterable)
                      {
                        num3 = 2;
                        continue;
                      }
                      goto case 14;
                    case 7:
                      goto label_19;
                    case 8:
                      goto label_38;
                    case 9:
                      typeDescriptor1.ApplyFilterValue(criteria, metadata, current, obj, !string.IsNullOrEmpty(alias) ? alias : (!(criteria is DetachedCriteriaAdapter) ? this.DefaultCriteriaAlias : criteria.Alias));
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 5 : 4;
                      continue;
                    case 10:
                      if (!(reflectionProperty == (PropertyInfo) null))
                      {
                        num3 = 4;
                        continue;
                      }
                      goto label_23;
                    case 11:
                      if (typeDescriptor2 == null)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 3 : 2;
                        continue;
                      }
                      goto case 16;
                    case 12:
                      obj = reflectionProperty.GetValue((object) filter, (object[]) null);
                      num3 = 9;
                      continue;
                    case 13:
                      if (typeDescriptor1 == null)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 1 : 1;
                        continue;
                      }
                      goto case 12;
                    case 14:
                      reflectionProperty = filter.GetType().GetReflectionProperty(current.Name);
                      num3 = 10;
                      continue;
                    case 15:
                      typeDescriptor1 = (IFilterableType) this.MetadataRuntimeService.GetTypeDescriptor(typeDescriptor2.GetFilterType((PropertyMetadata) current, (IMetadata) metadata), current.SubTypeUid);
                      num3 = 13;
                      continue;
                    case 16:
                      if (typeDescriptor2.GetFilterType((PropertyMetadata) current, (IMetadata) metadata) == Guid.Empty)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
                        continue;
                      }
                      goto case 15;
                    case 17:
                      typeDescriptor2 = this.MetadataRuntimeService.GetTypeDescriptor(current.TypeUid, current.SubTypeUid);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 11 : 4;
                      continue;
                    default:
                      goto label_23;
                  }
                }
label_19:
                current = enumerator.Current;
                num3 = 6;
                goto label_8;
label_24:
                num3 = 8;
                goto label_8;
              }
              finally
              {
                if (enumerator != null)
                {
                  int num4 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
                    num4 = 0;
                  while (true)
                  {
                    switch (num4)
                    {
                      case 1:
                        goto label_36;
                      default:
                        enumerator.Dispose();
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 1 : 0;
                        continue;
                    }
                  }
                }
label_36:;
              }
            case 2:
              goto label_37;
            case 3:
label_38:
              if (!string.IsNullOrWhiteSpace(filter.Query))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 4;
                continue;
              }
              goto label_29;
            case 4:
              goto label_40;
            case 5:
              Contract.ServiceNotNull((object) this.MetadataRuntimeService, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477343280));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
              continue;
            case 6:
              Contract.ArgumentNotNull((object) filter, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1242972401 >> 4 ^ 77750261));
              num2 = 2;
              continue;
            case 7:
              Contract.ArgumentNotNull((object) criteria, z2jc63fLkugS1X8Q9N.tE1kD1vbB(874012245 ^ 874210739));
              num2 = 6;
              continue;
            case 8:
              goto label_34;
            default:
              enumerator = metadata.Properties.OfType<EntityPropertyMetadata>().GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 1 : 0;
              continue;
          }
        }
label_37:
        Contract.ArgumentNotNull((object) metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1319452732 ^ 1319438594));
        num1 = 5;
        continue;
label_40:
        this.SetupFilterQuery(criteria, filter, metadata, string.IsNullOrEmpty(alias) ? (criteria is DetachedCriteriaAdapter ? criteria.Alias : this.DefaultCriteriaAlias) : alias);
        num1 = 8;
      }
label_34:
      return;
label_29:;
    }

    /// <summary>
    /// Применить условие выборки на языке EQL в критерий отбора
    /// </summary>
    /// <param name="criteria">Критерий выбора</param>
    /// <param name="query">Условие выборки на языке EQL</param>
    /// <param name="metadata">Метаданны объекта, к которму применяется фильтр</param>
    /// <param name="alias">alias</param>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Use SetupFilterQuery(ICriteria, IEntityFilter, EntityMetadata, alias) instead", true)]
    protected virtual void SetupFilterQuery(
      ICriteria criteria,
      string query,
      EntityMetadata metadata,
      string alias)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ICriteria criteria1 = criteria;
            Filter filter = new Filter();
            filter.Query = query;
            EntityMetadata metadata1 = metadata;
            string alias1 = alias;
            this.SetupFilterQuery(criteria1, (IEntityFilter) filter, metadata1, (Func<EntityPropertyMetadata, Func<EntityMetadata, string, ICriterion>, Func<string>, ICriterion>) null, alias1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>
    /// Применить условие выборки на языке EQL в критерий отбора
    /// </summary>
    /// <param name="criteria">Критерий выбора</param>
    /// <param name="query">Условие выборки на языке EQL</param>
    /// <param name="metadata">Метаданны объекта, к которму применяется фильтр</param>
    /// <param name="propertyCriterionFunc">Функция получения <see cref="T:NHibernate.Criterion.ICriterion" /> для определенного свойства.<br />
    /// На входе:<br />
    /// propMetadta: Метаданные свойства.<br />
    /// criterionFunc: Функция получения фильтрации свойства. На входе: entityMetadata: метаданные сущности, по которой создается фильтр; alias: alias для сущности в запросе.<br />
    /// newAliasFunc: фукнция получения нового alias для <see cref="T:NHibernate.ICriteria" />.<br />
    /// На выходе: Если свойство специально обрабатываться не должно, вернуть null, иначе вернуть <see cref="T:NHibernate.Criterion.ICriterion" /></param>
    /// <param name="alias">alias</param>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Use SetupFilterQuery(ICriteria, IEntityFilter, EntityMetadata, Func, alias) instead", true)]
    protected virtual void SetupFilterQuery(
      ICriteria criteria,
      string query,
      EntityMetadata metadata,
      Func<EntityPropertyMetadata, Func<EntityMetadata, string, ICriterion>, Func<string>, ICriterion> propertyCriterionFunc,
      string alias)
    {
      ICriteria criteria1 = criteria;
      Filter filter = new Filter();
      filter.Query = query;
      EntityMetadata metadata1 = metadata;
      Func<EntityPropertyMetadata, Func<EntityMetadata, string, ICriterion>, Func<string>, ICriterion> propertyCriterionFunc1 = propertyCriterionFunc;
      string alias1 = alias;
      this.SetupFilterQuery(criteria1, (IEntityFilter) filter, metadata1, propertyCriterionFunc1, alias1);
    }

    /// <summary>
    /// Применить условие выборки на языке EQL в критерий отбора
    /// </summary>
    /// <param name="criteria">Критерий выбора</param>
    /// <param name="query">Условие выборки на языке EQL</param>
    /// <param name="metadata">Метаданны объекта, к которму применяется фильтр</param>
    /// <param name="propertyCriterionFunc">Функция получения <see cref="T:NHibernate.Criterion.ICriterion" /> для определенного свойства.<br />
    /// На входе:<br />
    /// propMetadta: Метаданные свойства.<br />
    /// criterionFunc: Функция получения фильтрации свойства. На входе: entityMetadata: метаданные сущности, по которой создается фильтр; alias: alias для сущности в запросе.<br />
    /// newAliasFunc: фукнция получения нового alias для <see cref="T:NHibernate.ICriteria" />.<br />
    /// На выходе: Если свойство специально обрабатываться не должно, вернуть null, иначе вернуть <see cref="T:NHibernate.Criterion.ICriterion" /></param>
    /// <param name="alias">alias</param>
    /// <param name="filter">Фильтр сущности</param>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Use SetupFilterQuery(ICriteria, IEntityFilter, EntityMetadata, Func, alias) instead", true)]
    protected virtual void SetupFilterQuery(
      ICriteria criteria,
      string query,
      EntityMetadata metadata,
      Func<EntityPropertyMetadata, Func<EntityMetadata, string, ICriterion>, Func<string>, ICriterion> propertyCriterionFunc,
      IEntityFilter filter,
      string alias)
    {
      this.SetupFilterQuery(criteria, filter, metadata, propertyCriterionFunc, alias);
    }

    /// <summary>
    /// Применить условие выборки на языке EQL в критерий отбора
    /// </summary>
    /// <param name="criteria">Критерий выбора</param>
    /// <param name="filter">Фильтр сущности</param>
    /// <param name="metadata">Метаданны объекта, к которму применяется фильтр</param>
    /// <param name="alias">alias</param>
    protected void SetupFilterQuery(
      ICriteria criteria,
      IEntityFilter filter,
      EntityMetadata metadata,
      string alias = null)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.SetupFilterQuery(criteria, filter, metadata, (Func<EntityPropertyMetadata, Func<EntityMetadata, string, ICriterion>, Func<string>, ICriterion>) null, alias);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>
    /// Применить условие выборки на языке EQL в критерий отбора
    /// </summary>
    /// <param name="criteria">Критерий выбора</param>
    /// <param name="filter">Фильтр сущности</param>
    /// <param name="metadata">Метаданны объекта, к которму применяется фильтр</param>
    /// <param name="propertyCriterionFunc">Функция получения <see cref="T:NHibernate.Criterion.ICriterion" /> для определенного свойства.<br />
    /// На входе:<br />
    /// propMetadta: Метаданные свойства.<br />
    /// criterionFunc: Функция получения фильтрации свойства. На входе: entityMetadata: метаданные сущности, по которой создается фильтр; alias: alias для сущности в запросе.<br />
    /// newAliasFunc: фукнция получения нового alias для <see cref="T:NHibernate.ICriteria" />.<br />
    /// На выходе: Если свойство специально обрабатываться не должно, вернуть null, иначе вернуть <see cref="T:NHibernate.Criterion.ICriterion" /></param>
    /// <param name="alias">alias</param>
    protected virtual void SetupFilterQuery(
      ICriteria criteria,
      IEntityFilter filter,
      EntityMetadata metadata,
      Func<EntityPropertyMetadata, Func<EntityMetadata, string, ICriterion>, Func<string>, ICriterion> propertyCriterionFunc,
      string alias = null)
    {
      try
      {
        this.Logger.Debug((object) (z2jc63fLkugS1X8Q9N.tE1kD1vbB(333888594 ^ 1075625116 ^ 1408842996) + filter.Query));
        criteria.AddEQLQuery(filter.Query, metadata, filter.QueryParameters, alias, propertyCriterionFunc);
      }
      catch (Exception ex)
      {
        this.Logger.Error((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(92412609 - 1050237057 ^ -957612524), ex);
        throw;
      }
    }

    /// <summary>
    /// Найти сущности в соответствии фильтром, параметрами выборки и кэшированием результатов
    /// </summary>
    /// <param name="filter">Фильтр</param>
    /// <param name="fetchOptions">Параметры выборки</param>
    /// <param name="cacheble">Кэшировать ли результаты выборки</param>
    /// <returns>Список найденных сущностей</returns>
    [NotNull]
    protected virtual ICollection<T> Find(
      IEntityFilter filter,
      FetchOptions fetchOptions,
      bool cacheble)
    {
      ICollection<T> byIndex = this.FindByIndex(filter, fetchOptions);
      if (byIndex != null)
        return byIndex;
      ICriteria criteria = this.CreateCriteria(fetchOptions, this.GetFetchType(filter), filter: filter);
      if (cacheble)
        criteria = criteria.SetCacheable(true).SetCacheRegion(this.ImplementationType.FullName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(~210725948 ^ -210522183));
      this.SetupFilter(criteria, filter);
      if (fetchOptions != (FetchOptions) null && !string.IsNullOrEmpty(fetchOptions.QueryKey))
      {
        foreach (IFindCriteriaExtender criteriaExtender in this.FindCriteriaExtenders)
        {
          if (criteriaExtender.QueryKey == fetchOptions.QueryKey)
            criteriaExtender.Extend(filter, criteria, fetchOptions);
        }
      }
      return this.Find(criteria);
    }

    /// <summary>
    /// Найти сущности в соответствии фильтром, параметрами выборки и кэшированием результатов
    /// </summary>
    /// <param name="filter">Фильтр</param>
    /// <param name="fetchOptions">Параметры выборки</param>
    /// <param name="cacheble">Кэшировать ли результаты выборки</param>
    /// <returns>Список найденных сущностей</returns>
    [NotNull]
    protected ICollection<IdT> FindIds(
      IEntityFilter filter,
      FetchOptions fetchOptions,
      bool cacheble)
    {
      ICriteria criteria = this.CreateCriteria(fetchOptions, this.GetFetchType(filter), filter: filter);
      if (cacheble)
        criteria = criteria.SetCacheable(true);
      this.SetupFilter(criteria, filter);
      criteria.SetProjection((IProjection) Projections.Id());
      return (ICollection<IdT>) criteria.List<IdT>();
    }

    /// <summary>
    /// Тип реализации сущности. Если T - интерфейс, от вернется класс, реализующий его. Если T - класс, то вернется он же.
    /// </summary>
    protected Type ImplementationType
    {
      get
      {
        int num = 2;
        Type implementationType1;
        Type implementationType2;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.implementationType = implementationType1 = InterfaceActivator.TypeOf<T>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
              continue;
            case 2:
              implementationType2 = this.implementationType;
              if ((object) implementationType2 == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 1;
                continue;
              }
              goto label_2;
            default:
              goto label_6;
          }
        }
label_2:
        return implementationType2;
label_6:
        return implementationType1;
      }
    }

    /// <summary>Идентификатор типа реализации сущности.</summary>
    protected Guid ImplementationTypeUid
    {
      get
      {
        int num = 1;
        Guid implementationTypeUid;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (!(this.implementationTypeUid == Guid.Empty))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 0 : 0;
                continue;
              }
              this.implementationTypeUid = implementationTypeUid = InterfaceActivator.UID<T>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 1 : 2;
              continue;
            case 2:
              goto label_6;
            default:
              goto label_4;
          }
        }
label_4:
        return this.implementationTypeUid;
label_6:
        return implementationTypeUid;
      }
    }

    /// <summary>Алиас для критерия по умолчанию</summary>
    protected virtual string DefaultCriteriaAlias => (string) null;

    /// <summary>Сформировать всевдоним для свойства</summary>
    /// <param name="property">Имя свойства</param>
    /// <returns>Псевдоним</returns>
    protected virtual string AliasProperty(string property)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!string.IsNullOrEmpty(this.DefaultCriteriaAlias))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
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
      return property;
label_5:
      return string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917998801 >> 2 ^ 479516598), (object) this.DefaultCriteriaAlias, (object) property);
    }

    /// <summary>Сформировать всевдоним для свойства</summary>
    /// <param name="property"></param>
    /// <returns></returns>
    public virtual string GetAliasedPropertyString(string property) => this.AliasProperty(property);

    /// <summary>Создать критерий выборки NHibernate</summary>
    /// <param name="fetchOptions">Параметры выборки</param>
    /// <param name="type">Тип, для которого производится выборка</param>
    /// <param name="alias">Псевдоним</param>
    /// <param name="filter">Фильтр</param>
    /// <returns>Критерий</returns>
    [Auditable]
    protected internal virtual ICriteria CreateCriteria(
      FetchOptions fetchOptions,
      Type type,
      string alias = null,
      IEntityFilter filter = null)
    {
      int num1 = 1;
      IEnumerator<IEntityManagerBehavior> enumerator;
      ICriteria criteria1;
      while (true)
      {
        Type type1;
        Type type2;
        ICriteria criteria2;
        switch (num1)
        {
          case 1:
            Type type3 = type;
            if ((object) type3 == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
              continue;
            }
            type2 = type3;
            break;
          case 2:
          case 4:
            enumerator = this.Behaviors.GetEnumerator();
            num1 = 8;
            continue;
          case 3:
            if (!(fetchOptions != (FetchOptions) null))
            {
              num1 = 4;
              continue;
            }
            goto case 11;
          case 5:
            criteria2 = this.Session.CreateCriteria(type1);
            goto label_31;
          case 6:
            if (string.IsNullOrEmpty(alias))
            {
              if (!string.IsNullOrEmpty(this.DefaultCriteriaAlias))
              {
                num1 = 7;
                continue;
              }
              goto case 5;
            }
            else
            {
              num1 = 10;
              continue;
            }
          case 7:
            criteria2 = this.Session.CreateCriteria(type1, this.DefaultCriteriaAlias);
            goto label_31;
          case 8:
            goto label_11;
          case 9:
            EntityManager<T, IdT>.SetDisctinctRoot(criteria1);
            num1 = 3;
            continue;
          case 10:
            criteria2 = this.Session.CreateCriteria(type1, alias);
            goto label_31;
          case 11:
            this.SetupFetchOptions(criteria1, fetchOptions, type1);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 1 : 2;
            continue;
          case 12:
            goto label_27;
          default:
            type2 = this.ImplementationType;
            break;
        }
        type1 = type2;
        num1 = 6;
        continue;
label_31:
        criteria1 = criteria2;
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 3 : 9;
      }
label_11:
      try
      {
label_13:
        if (enumerator.MoveNext())
          goto label_15;
        else
          goto label_14;
label_12:
        int num2;
        switch (num2)
        {
          case 1:
            goto label_15;
          case 2:
            goto label_13;
          default:
            goto label_27;
        }
label_14:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
        goto label_12;
label_15:
        enumerator.Current.OnCreateCriteria(criteria1, filter);
        num2 = 2;
        goto label_12;
      }
      finally
      {
        int num3;
        if (enumerator == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 0;
        else
          goto label_19;
label_18:
        switch (num3)
        {
          case 1:
            break;
          default:
        }
label_19:
        enumerator.Dispose();
        num3 = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
        {
          num3 = 0;
          goto label_18;
        }
        else
          goto label_18;
      }
label_27:
      return criteria1;
    }

    /// <summary>Создать detached-критерию</summary>
    /// <param name="fetchOptions">Параметры выборки</param>
    /// <param name="type">Тип, для которого производится выборка</param>
    /// <param name="alias">Псевдоним</param>
    /// <param name="filter"></param>
    /// <returns>Критерий</returns>
    public override DetachedCriteria CreateDetachedCriteria(
      FetchOptions fetchOptions,
      Type type,
      string alias = null,
      IEntityFilter filter = null)
    {
      int num1 = 5;
      DetachedCriteria detachedCriteria1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          DetachedCriteria detachedCriteria2;
          switch (num2)
          {
            case 1:
              detachedCriteria2 = DetachedCriteria.For(type, alias);
              break;
            case 2:
              goto label_3;
            case 3:
              goto label_10;
            case 4:
              if (!string.IsNullOrEmpty(this.DefaultCriteriaAlias))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
                continue;
              }
              goto case 6;
            case 5:
              if (string.IsNullOrEmpty(alias))
              {
                num2 = 4;
                continue;
              }
              goto case 1;
            case 6:
              detachedCriteria2 = DetachedCriteria.For(type);
              break;
            default:
              detachedCriteria2 = DetachedCriteria.For(type, this.DefaultCriteriaAlias);
              break;
          }
          detachedCriteria1 = detachedCriteria2;
          num2 = 3;
        }
label_10:
        this.FilterDetachedCriteria(detachedCriteria1, fetchOptions, type, filter);
        num1 = 2;
      }
label_3:
      return detachedCriteria1;
    }

    /// <summary>Заполнить фильтрацию в detached-критерии</summary>
    /// <param name="detachedCriteria">detached-критерия</param>
    /// <param name="fetchOptions">Параметры выборки</param>
    /// <param name="type">Тип, для которого производится выборка</param>
    /// <param name="filter"></param>
    public override void FilterDetachedCriteria(
      DetachedCriteria detachedCriteria,
      FetchOptions fetchOptions,
      Type type,
      IEntityFilter filter = null)
    {
      int num1 = 6;
      while (true)
      {
        int num2 = num1;
        IEnumerator<IEntityManagerBehavior> enumerator;
        ICriteria criteria;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_15;
            case 1:
              try
              {
label_8:
                if (enumerator.MoveNext())
                  goto label_6;
                else
                  goto label_9;
label_4:
                int num3;
                switch (num3)
                {
                  case 1:
                    break;
                  case 2:
                    goto label_22;
                  default:
                    goto label_8;
                }
label_6:
                enumerator.Current.OnCreateCriteria(criteria, (IEntityFilter) null);
                num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
                {
                  num3 = 0;
                  goto label_4;
                }
                else
                  goto label_4;
label_9:
                num3 = 2;
                goto label_4;
              }
              finally
              {
                if (enumerator != null)
                {
                  int num4 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
                    num4 = 0;
                  while (true)
                  {
                    switch (num4)
                    {
                      case 1:
                        goto label_17;
                      default:
                        enumerator.Dispose();
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 1 : 1;
                        continue;
                    }
                  }
                }
label_17:;
              }
            case 2:
              enumerator = this.Behaviors.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 1 : 1;
              continue;
            case 3:
              goto label_20;
            case 4:
              this.SetupFilter(criteria, filter);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 0;
              continue;
            case 5:
              EntityManager<T, IdT>.SetDisctinctRoot(criteria);
              num2 = 8;
              continue;
            case 6:
              criteria = (ICriteria) new DetachedCriteriaAdapter(detachedCriteria, this.Session, type);
              num2 = 5;
              continue;
            case 7:
label_22:
              if (filter != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 4 : 1;
                continue;
              }
              goto label_10;
            case 8:
              if (fetchOptions != (FetchOptions) null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 2 : 3;
                continue;
              }
              goto case 2;
            default:
              goto label_5;
          }
        }
label_20:
        this.SetupFetchOptions(criteria, fetchOptions, type);
        num1 = 2;
      }
label_15:
      return;
label_5:
      return;
label_10:;
    }

    /// <summary>
    /// Создать критерий выборки NHibernate для типа сущности менеджера
    /// </summary>
    /// <returns>Критерий</returns>
    protected internal ICriteria CreateCriteria(IEntityFilter filter = null) => this.CreateCriteria((FetchOptions) null, this.GetFetchType((IEntityFilter) null), filter: filter);

    protected long ReturnCount(ICriteria criteria)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (criteria == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 1;
              continue;
            }
            criteria.SetProjection((IProjection) Projections.Count((IProjection) Projections.Id()));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return Convert.ToInt64(criteria.UniqueResult());
label_5:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-680446928 - -370807692 ^ -309822374));
    }

    /// <summary>Вернуть наличие удовлетворяющих критерию записей</summary>
    /// <param name="criteria">Критерий</param>
    /// <returns></returns>
    protected bool ReturnExists(ICriteria criteria)
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (criteria == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
                continue;
              }
              criteria.SetMaxResults(1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 2 : 2;
              continue;
            case 2:
              goto label_6;
            case 3:
              goto label_3;
            default:
              goto label_7;
          }
        }
label_6:
        criteria.SetProjection((IProjection) Projections.Id());
        num1 = 3;
      }
label_3:
      return criteria.UniqueResult() != null;
label_7:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 1418237292));
    }

    protected IList<PT> ReturnProjection<PT>(ICriteria criteria, string propertyName) => criteria != null ? criteria.SetProjection(Projections.Distinct((IProjection) Projections.Property(propertyName))).List<PT>() : throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(222162814 ^ 222221464));

    protected ProjectionList GetProjectionProperties<TProjection>()
    {
      PropertyInfo[] reflectionProperties = typeof (TProjection).GetReflectionProperties();
      ProjectionList projectionProperties = Projections.ProjectionList();
      foreach (PropertyInfo propertyInfo in reflectionProperties)
        projectionProperties.Add((IProjection) Projections.Property(propertyInfo.Name), propertyInfo.Name);
      return projectionProperties;
    }

    /// <summary>
    /// Загрузить по уникальному идентификатору. Если не найдена - возвращается null
    /// </summary>
    /// <param name="uid">Уникальный идентификатор сущности</param>
    /// <returns>Сущность или null</returns>
    protected virtual T LoadByUid(Guid uid) => this.LoadByUid(uid, (string[]) null);

    /// <summary>
    /// Загрузить по уникальному идентификатору. Если не найдена - возвращается null
    /// </summary>
    /// <param name="uid">Уникальный идентификатор сущности</param>
    /// <param name="fetchColumns">Добираемые колонки</param>
    /// <returns>Сущность или null</returns>
    internal T LoadByUid(Guid uid, string[] fetchColumns)
    {
      if (!this.hasUidProperty.HasValue)
        this.InitUidPropertyMetadata();
      if (!this.hasUidProperty.HasValue || !this.hasUidProperty.Value || this.uidPropertyMetadata == null)
        throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-688192331 - 435440695 ^ -1123711766), (object) this.ImplementationType.FullName));
      T obj1 = this.TryLoadByCache(uid);
      if ((object) obj1 != null && !obj1.Equals((object) default (T)))
        return obj1;
      ICriteria criteria = this.CreateCriteria().Add((ICriterion) Restrictions.Eq(this.uidPropertyMetadata.Name, (object) uid)).SetCacheable(this.CacheEnabled);
      if (fetchColumns != null)
        FetchOptionsBuilder.ResolveFetchColumns(criteria, (IEnumerable<string>) fetchColumns, SelectMode.Fetch);
      else
        criteria.SetMaxResults(1);
      T obj2 = criteria.UniqueResult<T>() ?? this.GetContextObject(uid);
      if ((object) obj2 != null)
      {
        NHibernateUtil.Initialize((object) obj2);
        try
        {
          foreach (IEntityManagerBehavior behavior in this.Behaviors)
            behavior.OnLoad((object) obj2);
          if (EntityManager<T, IdT>.CanCache(obj2))
            EntityManager<T, IdT>.MemoryCache.Set(EntityManager<T, IdT>.GetCacheKeyByUid(uid), (object) obj2.Id, this.GetCacheItemPolicy(), (string) null);
        }
        catch (ObjectIsDeletedException ex)
        {
          obj2 = (T) null;
        }
      }
      return obj2;
    }

    private T TryLoadByCache(Guid uid)
    {
      T obj1 = default (T);
      object obj2 = EntityManager<T, IdT>.MemoryCache.Get(EntityManager<T, IdT>.GetCacheKeyByUid(uid), (string) null);
      if (obj2 != null && obj2 is IdT id)
        obj1 = this.LoadOrNull(id);
      return obj1;
    }

    private static string GetCacheKeyByUid(Guid uid) => uid.ToString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-649342099 - -1150814748 ^ 501460359));

    /// <summary>
    /// Получить проекцию NHibernate для свойства сущности по выражению
    /// </summary>
    /// <typeparam name="TValue">Тип свойства</typeparam>
    /// <param name="expression">Выражение</param>
    /// <returns>Проекция</returns>
    protected PropertyProjection ProjectionFor<TValue>(Expression<Func<T, TValue>> expression)
    {
      if (expression == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87336589));
      if (!(expression.Body is MemberExpression body))
        throw new ArgumentException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1149433385 + 173655049 ^ 1323211130));
      return Projections.Property(body.Member.Name);
    }

    protected virtual bool CreateOnLoad(IdT id)
    {
      if (!this.IsTablePart)
        return false;
      long? nullable = (object) id as long?;
      long num = 0;
      return nullable.GetValueOrDefault() < num & nullable.HasValue;
    }

    /// <summary>Менеджер для блока</summary>
    protected bool IsTablePart
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this.isTablePart.HasValue)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
                continue;
              }
              goto case 3;
            case 3:
              this.isTablePart = new bool?(InterfaceActivator.LoadMetadata<T>() is ITablePartMetadata);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 2 : 2;
              continue;
            default:
              goto label_3;
          }
        }
label_3:
        return this.isTablePart.Value;
      }
    }

    /// <summary>
    /// Получить из фильтра имя свойства TypeUid для использования в критериях
    /// </summary>
    /// <param name="filter">Фильтр</param>
    /// <returns>Имя для свойства TypeUid</returns>
    protected string GetTypeUidPropertyName(IEntityFilter filter)
    {
      int num = 1;
      Type fetchType;
      while (true)
      {
        switch (num)
        {
          case 1:
            fetchType = this.GetFetchType(filter);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return this.GetTypeUidPropertyName(fetchType);
    }

    /// <summary>
    /// Получить из типа сущности имя свойства TypeUid для использования в критериях
    /// </summary>
    /// <param name="entityType">Тип сущности</param>
    /// <returns>Имя для свойства TypeUid</returns>
    protected string GetTypeUidPropertyName(Type entityType)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (entityType != (Type) null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 1 : 1;
              continue;
            }
            goto label_2;
          default:
            goto label_2;
        }
      }
label_2:
      return this.EntityTypeUidPropertyName;
label_3:
      return NHibernateHelper.GetCriteriaTypeUidPropertyName(entityType);
    }

    /// <summary>
    /// Имя свойства TypeUid у сущности, которой управляет менеджер. Для использования в критерии!
    /// </summary>
    protected string EntityTypeUidPropertyName
    {
      get
      {
        int num = 1;
        string typeUidPropertyName1;
        string typeUidPropertyName2;
        while (true)
        {
          switch (num)
          {
            case 1:
              typeUidPropertyName2 = this.entityTypeUidPropertyName;
              if (typeUidPropertyName2 == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_6;
            default:
              this.entityTypeUidPropertyName = typeUidPropertyName1 = NHibernateHelper.GetCriteriaTypeUidPropertyName(this.ImplementationType);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 2 : 2;
              continue;
          }
        }
label_2:
        return typeUidPropertyName2;
label_6:
        return typeUidPropertyName1;
      }
    }

    internal T GetContextObject(IdT id)
    {
      string name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(589593376 ^ -1977315327 ^ -1459366359) + typeof (T).AssemblyQualifiedName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1994213607 >> 4 ^ 124707748) + (object) id;
      T obj;
      return this.ContextService == null || !this.ContextService.TryGetValue<T>(name, out obj) ? (T) null : obj;
    }

    internal T GetContextObject(Guid uid)
    {
      string name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(1113862659 ^ 1114050315) + typeof (T).AssemblyQualifiedName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-53329496 >> 4 ^ -3270342) + (object) uid;
      T obj;
      return this.ContextService == null || !this.ContextService.TryGetValue<T>(name, out obj) ? (T) null : obj;
    }

    /// <summary>
    /// Получить количество всех объектов по фильтру из индекса
    /// </summary>
    private long? CountByIndex(IEntityFilter filter)
    {
      try
      {
        if (filter != null)
        {
          IModuleFullTextSearchExtension extensionByFilter = this.FullTextSearchCardService.GetExtensionByFilter(filter);
          if (extensionByFilter != null)
          {
            if (!this.IndexQueueManager.ContainIndexingVisualData())
            {
              Type cardTypeByFilter = this.FullTextSearchCardService.GetCardTypeByFilter(filter);
              if (cardTypeByFilter != (Type) null)
              {
                if (this.FullTextSearchService.IndexingIsWorking())
                {
                  if (!this.IndexQueueManager.HasIndexAllReIndexByTypeQueue())
                  {
                    Type typeForFastSearch = this.GetTypeForFastSearch(filter);
                    EntityMetadata entityMetadata = (EntityMetadata) MetadataLoader.LoadMetadata(typeForFastSearch);
                    if (!(typeForFastSearch == (Type) null))
                    {
                      if (entityMetadata == null)
                        goto label_14;
                    }
                    FullTextSearchResultModel resultModelByFilter = extensionByFilter.CreateResultModelByFilter(filter);
                    if (resultModelByFilter != null)
                    {
                      if (UniversalFilterSaver.Pack(filter) is SerializableFilter filterFields)
                      {
                        FullTextSearchResultModel searchResultModel = this.FullTextSearchService.Count(cardTypeByFilter, resultModelByFilter, filter, filterFields);
                        if (searchResultModel != null)
                          return new long?((long) searchResultModel.CountAllResult);
                      }
                    }
                  }
                }
              }
            }
          }
        }
      }
      catch (FullTextFilterException ex)
      {
        EntityManager<T, IdT>.IndexLog.Warn((object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1021410165 ^ 1021462107), (object) ex.Message), (Exception) ex);
      }
      catch (Exception ex)
      {
        EntityManager<T, IdT>.IndexLog.Error((object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1853042848), (object) ex.Message), ex);
      }
label_14:
      return new long?();
    }

    /// <summary>
    /// Найти сущности в соответствии фильтром, параметрами выборки в индексе
    /// </summary>
    private ICollection<T> FindByIndex(IEntityFilter filter, FetchOptions fetchOptions)
    {
      try
      {
        if (filter != null)
        {
          if (fetchOptions != (FetchOptions) null)
          {
            IModuleFullTextSearchExtension extensionByFilter = this.FullTextSearchCardService.GetExtensionByFilter(filter);
            if (extensionByFilter != null)
            {
              if (!this.IndexQueueManager.ContainIndexingVisualData())
              {
                Type cardTypeByFilter = this.FullTextSearchCardService.GetCardTypeByFilter(filter);
                if (cardTypeByFilter != (Type) null)
                {
                  if (this.FullTextSearchService.IndexingIsWorking())
                  {
                    if (!this.IndexQueueManager.HasIndexAllReIndexByTypeQueue())
                    {
                      bool flag1 = fetchOptions.UseProjections && fetchOptions.SelectColumns != null;
                      bool flag2 = !fetchOptions.UseProjections;
                      if (flag1 | flag2)
                      {
                        Type typeForFastSearch = this.GetTypeForFastSearch(filter);
                        EntityMetadata entityMetadata = (EntityMetadata) MetadataLoader.LoadMetadata(typeForFastSearch);
                        if (!(typeForFastSearch == (Type) null))
                        {
                          if (entityMetadata == null)
                            goto label_35;
                        }
                        FullTextSearchResultModel resultModelByFilter = extensionByFilter.CreateResultModelByFilter(filter);
                        if (resultModelByFilter != null)
                        {
                          if (UniversalFilterSaver.Pack(filter) is SerializableFilter filterFields)
                          {
                            List<Guid> selectedColumns = (List<Guid>) null;
                            if (flag1)
                            {
                              foreach (string selectColumn in fetchOptions.SelectColumns)
                              {
                                char[] chArray = new char[1]
                                {
                                  ':'
                                };
                                string[] strArray = selectColumn.Split(chArray);
                                if (((IEnumerable<string>) strArray).Count<string>() == 3)
                                {
                                  EntityPropertyMetadata realPropertyMetadata;
                                  this.GetRealProjection(strArray, typeForFastSearch, out CustomPropertyProjection _, out string _, out EntityMetadata _, out realPropertyMetadata, out string _);
                                  if (realPropertyMetadata != null)
                                  {
                                    if (selectedColumns == null)
                                      selectedColumns = new List<Guid>();
                                    selectedColumns.Add(realPropertyMetadata.Uid);
                                  }
                                }
                              }
                            }
                            if (flag2)
                              selectedColumns = new List<Guid>();
                            if (selectedColumns != null)
                            {
                              FullTextSearchResultModel resultModel = this.FullTextSearchService.Find(cardTypeByFilter, resultModelByFilter, filter, filterFields, selectedColumns, fetchOptions.FirstResult, fetchOptions.MaxResults, fetchOptions.SortExpression, fetchOptions.SortDirection);
                              if (resultModel != null)
                              {
                                if (flag1)
                                {
                                  List<IEntity> source = this.FullTextSearchCardService.ReconstructEntities(cardTypeByFilter, resultModel);
                                  if (source != null)
                                    return (ICollection<T>) new System.Collections.ObjectModel.Collection<T>((IList<T>) source.Cast<T>().ToList<T>());
                                }
                                if (flag2)
                                {
                                  List<long> idArray = this.FullTextSearchCardService.GetIdArray(resultModel.Items);
                                  if (idArray != null)
                                    return this.FindByIdArray(idArray.Cast<IdT>().ToArray<IdT>());
                                }
                                EntityManager<T, IdT>.IndexLog.Error((object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(516838154 ^ 516779692), (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1859085245)), flag1 ? (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099549939) : (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1872275253 >> 6 ^ -29187241)));
                              }
                            }
                          }
                        }
                      }
                    }
                  }
                }
              }
            }
          }
        }
      }
      catch (FullTextFilterException ex)
      {
        EntityManager<T, IdT>.IndexLog.Warn((object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867878200), (object) ex.Message), (Exception) ex);
      }
      catch (Exception ex)
      {
        EntityManager<T, IdT>.IndexLog.Error((object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-122002947 ^ 122069178), (object) ex.Message), ex);
      }
label_35:
      return (ICollection<T>) null;
    }

    private void InitUidPropertyMetadata()
    {
      int num1 = 5;
      while (true)
      {
        int num2 = num1;
        PropertyMetadata uidProperty;
        ClassMetadata classMetadata;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_9;
            case 1:
              goto label_5;
            case 2:
              this.hasUidProperty = new bool?(uidProperty != null && uidProperty.TypeUid == GuidDescriptor.UID);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 1 : 1;
              continue;
            case 3:
              goto label_7;
            case 4:
              if (!this.hasUidProperty.HasValue)
              {
                classMetadata = MetadataLoader.LoadMetadata(this.ImplementationType) as ClassMetadata;
                num2 = 6;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 0 : 0;
              continue;
            case 5:
              if (this.uidPropertyMetadata == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 2 : 4;
                continue;
              }
              goto label_20;
            case 6:
              if (classMetadata == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 8 : 10;
                continue;
              }
              goto case 8;
            case 7:
              this.uidPropertyMetadata = uidProperty;
              num2 = 9;
              continue;
            case 8:
              uidProperty = classMetadata.GetUidProperty();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 1 : 2;
              continue;
            case 9:
              goto label_12;
            case 10:
              this.hasUidProperty = new bool?(false);
              num2 = 3;
              continue;
            default:
              goto label_21;
          }
        }
label_5:
        if (this.hasUidProperty.Value)
          num1 = 7;
        else
          goto label_3;
      }
label_9:
      return;
label_7:
      return;
label_12:
      return;
label_21:
      return;
label_3:
      return;
label_20:;
    }

    /// <summary>Добавить в кэш</summary>
    /// <param name="obj">Сущность</param>
    internal void AddContextObject(T obj)
    {
      if (this.ContextService == null)
        return;
      if (!obj.GetId().Equals((object) default (IdT)))
        this.ContextService.Set(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -811973306) + typeof (T).AssemblyQualifiedName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138213038) + (object) obj.Id, (object) obj);
      Guid? uid = this.InternalGetUid(obj);
      if (!uid.HasValue || !(uid.Value != Guid.Empty))
        return;
      this.ContextService.Set(z2jc63fLkugS1X8Q9N.tE1kD1vbB(813604817 ^ 813540057) + typeof (T).AssemblyQualifiedName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1251470110 >> 2 ^ 312920039) + (object) uid.Value, (object) obj);
    }

    /// <summary>Удалить из кэша</summary>
    /// <param name="obj">Сущность</param>
    internal void RemoveFromContextObject(T obj)
    {
      if (this.ContextService == null)
        return;
      if (!obj.GetId().Equals((object) default (IdT)))
        this.ContextService.Remove(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1514961705 ^ 1515144737) + typeof (T).AssemblyQualifiedName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(516838154 ^ 516776992) + (object) obj.Id);
      Guid? uid = this.InternalGetUid(obj);
      if (!uid.HasValue || !(uid.Value != Guid.Empty))
        return;
      this.ContextService.Remove(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-397266137 ^ 397341136) + typeof (T).AssemblyQualifiedName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(95909607 + 343705423 ^ 439403286) + (object) uid.Value);
    }

    private void InternalSetUid(Guid uid, T res)
    {
      this.InitUidPropertyMetadata();
      PropertyInfo reflectionProperty = res.GetType().GetReflectionProperty(this.uidPropertyMetadata.Name);
      if (!(reflectionProperty != (PropertyInfo) null))
        return;
      reflectionProperty.SetValue((object) res, (object) uid, (object[]) null);
    }

    private Guid? InternalGetUid(T res)
    {
      this.InitUidPropertyMetadata();
      return this.uidPropertyMetadata == null ? new Guid?() : (Guid?) res.GetType().GetReflectionProperty(this.uidPropertyMetadata.Name).GetValue((object) res, (object[]) null);
    }

    /// <summary>Тип сущноти для выборки</summary>
    /// <param name="filter"></param>
    /// <returns></returns>
    protected Type GetFetchType(IEntityFilter filter)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (filter != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            goto label_2;
          default:
            if (filter.Subtype == (Type) null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 2 : 0;
              continue;
            }
            goto label_3;
        }
      }
label_2:
      return this.ImplementationType;
label_3:
      return InterfaceActivator.TypeOf(filter.Subtype);
    }

    protected static void SetDisctinctRoot(ICriteria criteria)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (criteria != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            goto label_6;
          case 3:
            goto label_4;
          default:
            criteria.SetResultTransformer(CriteriaSpecification.DistinctRootEntity);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 2 : 2;
            continue;
        }
      }
label_6:
      return;
label_4:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1242972401 >> 4 ^ 77750249));
    }

    /// <summary>Удаляется ли объект при текущем изменении</summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    private bool objectDeletion(T obj)
    {
      NHibernate.Engine.EntityEntry entry = this.Session.GetSessionImplementation().PersistenceContext.GetEntry((object) obj);
      if (entry == null)
        return false;
      object[] loadedState = entry.LoadedState;
      int index1 = EleWise.ELMA.Extensions.EnumerableExtensions.IndexOf(entry.Persister.PropertyNames, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -811913052));
      int index2 = EleWise.ELMA.Extensions.EnumerableExtensions.IndexOf(entry.Persister.PropertyNames, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 1360411877));
      if (index1 < 0 && index2 < 0)
        return false;
      bool flag1 = (bool) loadedState[index1];
      bool flag2 = (bool) loadedState[index2];
      if (!(obj is ISoftDeletable softDeletable))
        return false;
      return flag1 != softDeletable.IsDeleted || flag2 != softDeletable.HardDelete;
    }

    /// <summary>
    /// Изменяются ли ИСКЛЮЧИТЕЛЬНО ПРИВИЛЕГИИ у текущего объекта
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    private bool ChangeAccess(T obj)
    {
      Guid[] dirtyProperties = this.GetDirtyPropertyUids(obj);
      if (dirtyProperties.Length != 1)
        return false;
      string key = this.GetType().ToString() + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1290212282 ^ -644262414 ^ 1786939044) + (object) dirtyProperties[0];
      bool result;
      if (this.MemoryCacheService.TryGetValue<bool>(key, out result))
        return result;
      Type objType = obj.GetType();
      ClassMetadata classMetadata1 = (ClassMetadata) MetadataLoader.LoadMetadata(objType);
      if (classMetadata1 == null)
        return false;
      PropertyMetadata propertyMetadata = classMetadata1.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => p.Uid == dirtyProperties[0]));
      if (propertyMetadata == null)
        return false;
      EntitySettings setting = propertyMetadata.Settings as EntitySettings;
      if (setting == null || setting.RelationType != RelationType.OneToMany)
        return false;
      ClassMetadata classMetadata2 = (ClassMetadata) MetadataLoader.LoadMetadata(propertyMetadata.SubTypeUid);
      Type permissionType = this.MetadataRuntimeService.GetTypeByUid(classMetadata2.Uid);
      PropertyMetadata keyProperty = classMetadata2.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (x => x.Uid == setting.KeyColumnUid));
      bool flag = ComponentManager.Current.GetExtensionPoints<IInstanceSettingsPermission>(false).Any<IInstanceSettingsPermission>((Func<IInstanceSettingsPermission, bool>) (x =>
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (x.TargetPropetyName == keyProperty.Name)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            case 2:
              if (objType.IsInheritOrSame(x.EntityType))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 1 : 0;
                continue;
              }
              goto label_5;
            default:
              goto label_4;
          }
        }
label_4:
        return permissionType.IsInheritOrSame(x.PermissionHolderType);
label_5:
        return false;
      }));
      this.MemoryCacheService.Insert<bool>(key, flag);
      return flag;
    }

    /// <summary>
    /// Получить количество вложенных элементов иерархического объекта
    /// </summary>
    /// <param name="obj">Сущность</param>
    /// <param name="entitymetadata">Метаданные сущности</param>
    /// <returns>Количество вложенных элементов иерархического объекта с учётом мягких удалений</returns>
    private long GetSubElementCountOfHierarchicalEntity(T obj, EntityMetadata entitymetadata)
    {
      Contract.ArgumentNotNull((object) obj, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1350312861 << 3 ^ 2082357392));
      Contract.ArgumentNotNull((object) entitymetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1574260816 ^ 1574428574));
      ISoftDeletable softDeletable = (object) obj as ISoftDeletable;
      string tableName = entitymetadata.TableName;
      return Convert.ToInt64(this.Session.CreateSQLQuery(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1033719030 - 2012070891 ^ -978536871), (object) this.Transformation.Dialect.QuoteIfNeeded(tableName), (object) this.Transformation.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1178210108 ^ 1178246922)), softDeletable != null ? (object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837874721), (object) this.Transformation.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87483235))) : (object) string.Empty)).SetParameter<IdT>(0, obj.Id).CleanUpCache(false).UniqueResult());
    }

    /// <summary>Получить настройки работы с MemoryCache для сущности</summary>
    /// <returns>Настройки работы с MemoryCache</returns>
    protected virtual CacheItemPolicy GetCacheItemPolicy() => EntityManager<T, IdT>.DefaultCacheItemPolicy;

    private static void SetDefaultCacheItemPolicy()
    {
      int num = 2;
      int result;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            if (result <= 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 0 : 4;
              continue;
            }
            goto case 3;
          case 2:
            if (int.TryParse(EleWise.ELMA.SR.GetSetting(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-306453669 ^ 306651928), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1253244298 - 1829393894 ^ -576145368)), out result))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 1 : 1;
              continue;
            }
            goto case 4;
          case 3:
            EntityManager<T, IdT>.DefaultCacheItemPolicy = new CacheItemPolicy()
            {
              SlidingExpiration = TimeSpan.FromMinutes((double) result)
            };
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
            continue;
          case 4:
            result = 10;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 3;
            continue;
          default:
            goto label_9;
        }
      }
label_2:
      return;
label_9:;
    }

    internal static bool FjYnSBhvu35tuEgdiJyX() => EntityManager<T, IdT>.uNnDhfhvZuDlpgSRtlRK == null;

    internal static object CeDyDPhvIpkGfB8Fe9y3() => EntityManager<T, IdT>.uNnDhfhvZuDlpgSRtlRK;
  }
}
