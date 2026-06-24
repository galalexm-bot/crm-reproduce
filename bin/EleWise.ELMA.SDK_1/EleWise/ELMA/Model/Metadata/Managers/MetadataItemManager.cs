// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.Managers.MetadataItemManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Publication;
using EleWise.ELMA.Cache;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Events;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using NHibernate.Transform;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Model.Metadata.Managers
{
  /// <summary>Менеджер элементов метаданных</summary>
  public class MetadataItemManager : EntityManager<IMetadataItem, long>
  {
    private static IEntityMetadataDependencyService entityMetadataDependencyService;
    private List<Guid> restartNeededMetadataUids;
    private IDictionary<Guid, IRootMetadata> softPublishedMetadata;
    private IDynamicPublicationService dynamicPublicationService;
    private static ILogger publishLogger;
    internal static MetadataItemManager WpUPgPhFjOWJxVPVc3V3;

    /// <summary>Среда исполнения приложения</summary>
    public IRuntimeApplication RuntimeApplication
    {
      get => this.\u003CRuntimeApplication\u003Ek__BackingField;
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
              this.\u003CRuntimeApplication\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 0;
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

    /// <summary>Обработчик события сохранения метаданных</summary>
    public IMetadataSaveFinishedEventHandler MetadataSaveFinishedEventHandler
    {
      get => this.\u003CMetadataSaveFinishedEventHandler\u003Ek__BackingField;
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
              this.\u003CMetadataSaveFinishedEventHandler\u003Ek__BackingField = value;
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

    /// <summary>Обработчик события сохранения элемента метаданных</summary>
    public IMetadataItemSaveEventHandler MetadataItemSaveEventHandler
    {
      get => this.\u003CMetadataItemSaveEventHandler\u003Ek__BackingField;
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
              this.\u003CMetadataItemSaveEventHandler\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
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

    /// <summary>Обработчик события публикации метаданных</summary>
    public IMetadataPublishFinishedEventHandler MetadataPublishFinishedEventHandler
    {
      get => this.\u003CMetadataPublishFinishedEventHandler\u003Ek__BackingField;
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
              this.\u003CMetadataPublishFinishedEventHandler\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
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

    /// <summary>Точки расширения для работы с зависимостями форм</summary>
    public IEnumerable<IFormDependencyExtension> FormDependencyExtensions { get; set; }

    /// <summary>Сервис для ограничения работы с зависимостями форм</summary>
    public IWorkWithFormDependeciesService WorkWithFormDependeciesService
    {
      get => this.\u003CWorkWithFormDependeciesService\u003Ek__BackingField;
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
              this.\u003CWorkWithFormDependeciesService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
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

    /// <summary>Интерфейс для получения Акторов</summary>
    public IActorModelRuntime ActorModelRuntime
    {
      get => this.\u003CActorModelRuntime\u003Ek__BackingField;
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
              this.\u003CActorModelRuntime\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 0 : 0;
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

    /// <summary>Сервис для ручной подписки на события</summary>
    public IEventHandlerSubscribeService EventHandlerSubscribeService
    {
      get => this.\u003CEventHandlerSubscribeService\u003Ek__BackingField;
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
              this.\u003CEventHandlerSubscribeService\u003Ek__BackingField = value;
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
    }

    /// <summary>Кэш исходных кодов, сгенерированных для метаданных</summary>
    public ILazy<IMetadataSourceCodeCache> MetadataSourceCodeCache { get; set; }

    private static IEntityMetadataDependencyService EntityMetadataDependencyService
    {
      get
      {
        int num = 1;
        IEntityMetadataDependencyService dependencyService;
        while (true)
        {
          switch (num)
          {
            case 1:
              dependencyService = MetadataItemManager.entityMetadataDependencyService;
              if (dependencyService == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_5;
          }
        }
label_2:
        return dependencyService;
label_5:
        return MetadataItemManager.entityMetadataDependencyService = Locator.GetServiceNotNull<IEntityMetadataDependencyService>();
      }
    }

    /// <summary>Экземпляр менеджера</summary>
    public static MetadataItemManager Instance => Locator.GetServiceNotNull<MetadataItemManager>();

    /// <summary>Найти все черновики</summary>
    /// <returns>Список черновиков</returns>
    public virtual IEnumerable<IMetadataItem> FindDraftItems() => (IEnumerable<IMetadataItem>) this.Session.CreateCriteria(InterfaceActivator.TypeOf<IMetadataItemHeader>()).SetProjection((IProjection) Projections.Property(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -811965290))).List<IMetadataItem>();

    /// <summary>Сохранить элементы метаданных</summary>
    /// <param name="metadataItems">Элементы метаданных</param>
    [Transaction]
    public virtual void Save(IEnumerable<IMetadataItem> metadataItems)
    {
      foreach (IMetadataItem metadataItem in metadataItems)
        this.Save(metadataItem);
      this.MetadataSaveFinishedEventHandler.SaveExecuted(new MetadataSavedEventArgs()
      {
        SavedMetadata = (IList<IRootMetadata>) metadataItems.Select<IMetadataItem, object>((Func<IMetadataItem, object>) (i => i.Metadata)).OfType<IRootMetadata>().ToList<IRootMetadata>()
      });
    }

    /// <summary>Опубликовать указанный список элементов метаданных</summary>
    /// <param name="comment">Комментарий к публикации</param>
    /// <param name="headerIds">Идентификаторы заголовков метаданных</param>
    /// <returns>Метаданные сборки конфигурации</returns>
    public MetadataPublishResult Publish(string comment, params long[] headerIds) => this.Publish(comment, (string) null, headerIds);

    /// <summary>Опубликовать указанный список элементов метаданных</summary>
    /// <param name="comment">Комментарий к публикации</param>
    /// <param name="tag">Метка</param>
    /// <param name="headerIds">Идентификаторы заголовков метаданных</param>
    /// <returns>Метаданные сборки конфигурации</returns>
    public virtual MetadataPublishResult Publish(
      string comment,
      string tag,
      params long[] headerIds)
    {
      int num = 1;
      TaskAwaiter<MetadataPublishResult> awaiter;
      while (true)
      {
        switch (num)
        {
          case 1:
            awaiter = this.PublishAsync(comment, tag, headerIds).GetAwaiter();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return awaiter.GetResult();
    }

    /// <summary>Опубликовать указанный список элементов метаданных</summary>
    /// <param name="comment">Комментарий к публикации</param>
    /// <param name="headerIds">Идентификаторы заголовков метаданных</param>
    /// <returns>Метаданные сборки конфигурации</returns>
    public Task<MetadataPublishResult> PublishAsync(string comment, params long[] headerIds) => this.PublishAsync(comment, (string) null, headerIds);

    /// <summary>Опубликовать указанный список элементов метаданных</summary>
    /// <param name="comment">Комментарий к публикации</param>
    /// <param name="tag">Метка</param>
    /// <param name="headerIds">Идентификаторы заголовков метаданных</param>
    /// <returns>Метаданные сборки конфигурации</returns>
    public virtual async Task<MetadataPublishResult> PublishAsync(
      string comment,
      string tag,
      params long[] headerIds)
    {
      int num1 = 5;
      while (true)
      {
        int num2 = num1;
        int num3;
        MetadataPublishResult result1;
        while (true)
        {
          switch (num2)
          {
            case 1:
label_97:
              // ISSUE: explicit reference operation
              // ISSUE: reference to a compiler-generated field
              (^this).\u003C\u003E1__state = -2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_93;
            case 3:
              try
              {
                int num4;
                switch (num3)
                {
                  case 0:
                  case 1:
label_7:
                    num4 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
                    {
                      num4 = 0;
                      break;
                    }
                    break;
                  default:
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 1 : 1;
                    break;
                }
                MetadataItemManager.PublishResultResolver publishResultResolver;
                IDisposable disposable1;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      publishResultResolver = new MetadataItemManager.PublishResultResolver();
                      num4 = 3;
                      continue;
                    case 2:
                      goto label_7;
                    case 3:
                      disposable1 = this.EventHandlerSubscribeService.Subscribe((IEventHandler) publishResultResolver);
                      num4 = 2;
                      continue;
                    default:
                      goto label_10;
                  }
                }
label_10:
                try
                {
                  MetadataItemManager.PublicationEventHandler publicationEventHandler1;
                  int num5;
                  switch (num3)
                  {
                    case 0:
                    case 1:
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 2 : 3;
                      break;
                    default:
label_14:
                      publicationEventHandler1 = new MetadataItemManager.PublicationEventHandler();
                      num5 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
                      {
                        num5 = 0;
                        break;
                      }
                      break;
                  }
                  IDisposable disposable2;
                  while (true)
                  {
                    switch (num5)
                    {
                      case 1:
                        goto label_14;
                      case 2:
                        goto label_18;
                      case 3:
                      case 4:
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 2 : 2;
                        continue;
                      default:
                        // ISSUE: reference to a compiler-generated method
                        disposable2 = (IDisposable) MetadataItemManager.\u003CPublishAsync\u003Ed__46.EC9uidC9i3qrb7I1ivwu((object) this.EventHandlerSubscribeService, (object) publicationEventHandler1);
                        num5 = 4;
                        continue;
                    }
                  }
label_18:
                  try
                  {
                    int num6;
                    switch (num3)
                    {
                      case 0:
                      case 1:
label_67:
                        num6 = 5;
                        break;
                      default:
                        num6 = 3;
                        break;
                    }
                    while (true)
                    {
                      switch (num6)
                      {
                        case 1:
                          goto label_97;
                        case 2:
label_66:
                          // ISSUE: reference to a compiler-generated method
                          MetadataItemManager.publishLogger.Debug(MetadataItemManager.\u003CPublishAsync\u003Ed__46.f9BngdC9R56rqVihTlJZ(-97972138 ^ -97737108));
                          num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
                          continue;
                        case 3:
                          // ISSUE: reference to a compiler-generated method
                          // ISSUE: reference to a compiler-generated method
                          MetadataItemManager.\u003CPublishAsync\u003Ed__46.syN9DlC9qDEsjfweZMAa((object) MetadataItemManager.publishLogger, MetadataItemManager.\u003CPublishAsync\u003Ed__46.f9BngdC9R56rqVihTlJZ(-70007027 ^ -69832423));
                          num6 = 4;
                          continue;
                        case 4:
                          goto label_67;
                        case 5:
                          try
                          {
                            int num7;
                            if (num3 != 0)
                              num7 = 15;
                            else
                              goto label_38;
label_23:
                            MetadataItemManager.PublicationEventHandler publicationEventHandler2;
                            TaskAwaiter<Guid> taskAwaiter1;
                            TaskAwaiter taskAwaiter2;
                            TaskAwaiter awaiter1;
                            TaskAwaiter<Guid> awaiter2;
                            Guid result2;
                            while (true)
                            {
                              switch (num7)
                              {
                                case 1:
                                  if (!awaiter1.IsCompleted)
                                  {
                                    num7 = 9;
                                    continue;
                                  }
                                  goto case 19;
                                case 2:
                                  IPublicationActor actor = this.ActorModelRuntime.GetActor<IPublicationActor>(Guid.Empty);
                                  publicationEventHandler2 = publicationEventHandler1;
                                  string comment1 = comment;
                                  string tag1 = tag;
                                  long[] numArray = headerIds;
                                  awaiter2 = actor.Start(comment1, tag1, numArray).GetAwaiter();
                                  num7 = 23;
                                  continue;
                                case 3:
                                  awaiter1 = taskAwaiter2;
                                  num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 4 : 5;
                                  continue;
                                case 4:
                                  goto label_90;
                                case 5:
                                  taskAwaiter2 = new TaskAwaiter();
                                  num7 = 11;
                                  continue;
                                case 6:
                                  // ISSUE: reference to a compiler-generated method
                                  MetadataItemManager.\u003CPublishAsync\u003Ed__46.gOnyNlC9KFhS6dKG6Ikt((object) publicationEventHandler2, result2);
                                  num7 = 12;
                                  continue;
                                case 7:
                                  goto label_38;
                                case 8:
                                  result2 = awaiter2.GetResult();
                                  num7 = 6;
                                  continue;
                                case 9:
                                  // ISSUE: explicit reference operation
                                  // ISSUE: reference to a compiler-generated field
                                  (^this).\u003C\u003E1__state = num3 = 1;
                                  num7 = 14;
                                  continue;
                                case 10:
                                  goto label_66;
                                case 11:
                                  // ISSUE: explicit reference operation
                                  // ISSUE: reference to a compiler-generated field
                                  (^this).\u003C\u003E1__state = num3 = -1;
                                  num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 19 : 19;
                                  continue;
                                case 12:
                                  publicationEventHandler2 = (MetadataItemManager.PublicationEventHandler) null;
                                  num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 16 : 20;
                                  continue;
                                case 13:
                                  // ISSUE: explicit reference operation
                                  // ISSUE: reference to a compiler-generated field
                                  (^this).\u003C\u003E1__state = num3 = -1;
                                  num7 = 8;
                                  continue;
                                case 14:
                                  taskAwaiter2 = awaiter1;
                                  num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 12 : 17;
                                  continue;
                                case 15:
                                  if (num3 != 1)
                                  {
                                    num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 0 : 2;
                                    continue;
                                  }
                                  goto case 3;
                                case 16:
                                  taskAwaiter1 = awaiter2;
                                  num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
                                  continue;
                                case 17:
                                  // ISSUE: explicit reference operation
                                  // ISSUE: reference to a compiler-generated field
                                  (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, MetadataItemManager.\u003CPublishAsync\u003Ed__46>(ref awaiter1, this);
                                  num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 4 : 4;
                                  continue;
                                case 18:
                                  // ISSUE: explicit reference operation
                                  // ISSUE: reference to a compiler-generated field
                                  (^this).\u003C\u003E1__state = num3 = 0;
                                  num7 = 16;
                                  continue;
                                case 19:
                                  awaiter1.GetResult();
                                  num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 10 : 2;
                                  continue;
                                case 20:
                                  // ISSUE: reference to a compiler-generated method
                                  awaiter1 = MetadataItemManager.\u003CPublishAsync\u003Ed__46.jB3i0SC9XCwGfFt0OpvN((object) publicationEventHandler1.WaitPublication);
                                  num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 1 : 1;
                                  continue;
                                case 21:
                                  taskAwaiter1 = new TaskAwaiter<Guid>();
                                  num7 = 13;
                                  continue;
                                case 22:
                                  goto label_82;
                                case 23:
                                  if (!awaiter2.IsCompleted)
                                  {
                                    num7 = 18;
                                    continue;
                                  }
                                  goto case 8;
                                default:
                                  // ISSUE: explicit reference operation
                                  // ISSUE: reference to a compiler-generated field
                                  (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Guid>, MetadataItemManager.\u003CPublishAsync\u003Ed__46>(ref awaiter2, this);
                                  num7 = 22;
                                  continue;
                              }
                            }
label_90:
                            return;
label_82:
                            return;
label_38:
                            awaiter2 = taskAwaiter1;
                            num7 = 21;
                            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
                            {
                              num7 = 6;
                              goto label_23;
                            }
                            else
                              goto label_23;
                          }
                          catch (NoServerCompatibleWithActorException ex)
                          {
                            int num8 = 0;
                            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
                              num8 = 1;
                            while (true)
                            {
                              switch (num8)
                              {
                                case 1:
                                  // ISSUE: reference to a compiler-generated method
                                  // ISSUE: reference to a compiler-generated method
                                  MetadataItemManager.\u003CPublishAsync\u003Ed__46.mQI0yRC9T52CRCZTy3gJ((object) MetadataItemManager.publishLogger, MetadataItemManager.\u003CPublishAsync\u003Ed__46.f9BngdC9R56rqVihTlJZ(-1334993905 ^ -1335234149), (object) ex);
                                  num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
                                  continue;
                                default:
                                  goto label_53;
                              }
                            }
label_53:
                            // ISSUE: reference to a compiler-generated method
                            // ISSUE: reference to a compiler-generated method
                            throw new NoServerCompatibleWithActorException((string) MetadataItemManager.\u003CPublishAsync\u003Ed__46.w6GhHWC9kYNccdipSxyO(MetadataItemManager.\u003CPublishAsync\u003Ed__46.f9BngdC9R56rqVihTlJZ(1113862659 ^ 1113677319)), (Exception) ex);
                          }
                          catch (Exception ex)
                          {
                            int num9 = 6;
                            while (true)
                            {
                              switch (num9)
                              {
                                case 1:
                                  if (ex is MetadataPublishingException)
                                  {
                                    num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 4 : 3;
                                    continue;
                                  }
                                  goto case 5;
                                case 2:
                                  if (!(ex is MetadataValidationException))
                                  {
                                    num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
                                    continue;
                                  }
                                  goto label_63;
                                case 3:
                                case 4:
                                  goto label_63;
                                case 5:
                                  if (!(ex is InvalidOperationException))
                                  {
                                    num9 = 2;
                                    continue;
                                  }
                                  goto label_63;
                                case 6:
                                  // ISSUE: reference to a compiler-generated method
                                  // ISSUE: reference to a compiler-generated method
                                  MetadataItemManager.\u003CPublishAsync\u003Ed__46.mQI0yRC9T52CRCZTy3gJ((object) MetadataItemManager.publishLogger, MetadataItemManager.\u003CPublishAsync\u003Ed__46.f9BngdC9R56rqVihTlJZ(323422137 << 2 ^ 1293448048), (object) ex);
                                  num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 1 : 1;
                                  continue;
                                default:
                                  goto label_64;
                              }
                            }
label_63:
                            throw;
label_64:
                            throw new Exception(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 1867032187)), ex);
                          }
                        default:
                          // ISSUE: reference to a compiler-generated method
                          result1 = (MetadataPublishResult) MetadataItemManager.\u003CPublishAsync\u003Ed__46.Ve8O3WC9nElCdUJaKXLF((object) publishResultResolver);
                          num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 1 : 1;
                          continue;
                      }
                    }
                  }
                  finally
                  {
                    if (num3 < 0)
                    {
                      int num10 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
                        num10 = 0;
                      while (true)
                      {
                        switch (num10)
                        {
                          case 1:
                            // ISSUE: reference to a compiler-generated method
                            MetadataItemManager.\u003CPublishAsync\u003Ed__46.Ii6UfHC9OVO8BLU4xdmw((object) disposable2);
                            num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 2;
                            continue;
                          case 2:
                            goto label_78;
                          default:
                            if (disposable2 != null)
                            {
                              num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 1 : 0;
                              continue;
                            }
                            goto label_78;
                        }
                      }
                    }
label_78:;
                  }
                }
                finally
                {
                  if (num3 < 0)
                  {
                    int num11 = 2;
                    while (true)
                    {
                      switch (num11)
                      {
                        case 1:
                          goto label_86;
                        case 2:
                          if (disposable1 != null)
                          {
                            num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
                            continue;
                          }
                          goto label_86;
                        default:
                          // ISSUE: reference to a compiler-generated method
                          MetadataItemManager.\u003CPublishAsync\u003Ed__46.Ii6UfHC9OVO8BLU4xdmw((object) disposable1);
                          num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 1 : 1;
                          continue;
                      }
                    }
                  }
label_86:;
                }
              }
              catch (Exception ex)
              {
                int num12 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
                  num12 = 1;
                while (true)
                {
                  switch (num12)
                  {
                    case 0:
                      goto label_74;
                    case 1:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = -2;
                      num12 = 2;
                      continue;
                    case 2:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003Et__builder.SetException(ex);
                      num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_69;
                  }
                }
label_74:
                return;
label_69:
                return;
              }
            case 4:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 3 : 2;
              continue;
            case 5:
              // ISSUE: explicit reference operation
              // ISSUE: reference to a compiler-generated field
              num3 = (^this).\u003C\u003E1__state;
              num2 = 4;
              continue;
            default:
              goto label_96;
          }
        }
label_96:
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        (^this).\u003C\u003Et__builder.SetResult(result1);
        num1 = 2;
      }
label_93:;
    }

    /// <summary>Получить объект метаданных после мягкой публикации</summary>
    /// <param name="metadataUid">Уникальный идентификатор метаданных</param>
    /// <returns>Объект метаданных</returns>
    public IRootMetadata GetSoftPublishedMetadata(Guid metadataUid)
    {
      int num = 1;
      IRootMetadata publishedMetadata;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.softPublishedMetadata.TryGetValue(metadataUid, out publishedMetadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return publishedMetadata;
    }

    /// <summary>
    /// Получить список идентификаторов объектов метаданных, для которых требуется перезапуск сервера
    /// </summary>
    /// <returns></returns>
    public List<Guid> GetRestartRequiredMetadataUids()
    {
      if (this.restartNeededMetadataUids == null)
      {
        if (this.DynamicPublicationService.Enable)
        {
          IQueryOver<AssemblyModelsMetadata, AssemblyModelsMetadata> queryOver = this.Session.QueryOver<AssemblyModelsMetadata>().Where((Expression<Func<AssemblyModelsMetadata, bool>>) (assemblyModelsMetadata => assemblyModelsMetadata.Name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099749581) && (int) assemblyModelsMetadata.Status == 2));
          Expression<Func<AssemblyModelsMetadata, object>>[] expressionArray = new Expression<Func<AssemblyModelsMetadata, object>>[1]
          {
            (Expression<Func<AssemblyModelsMetadata, object>>) (assemblyModelsMetadata => assemblyModelsMetadata.MetadataStream)
          };
          using (MemoryStream memoryStream = queryOver.Select(expressionArray).SingleOrDefault<MemoryStream>())
          {
            if (memoryStream != null)
            {
              MetadataItemManager.publishLogger.Debug((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-688192331 - 435440695 ^ -1123703440));
              // ISSUE: reference to a compiler-generated method
              this.restartNeededMetadataUids = ((IEnumerable<AbstractMetadata>) new AssemblyModelsMetadata()
              {
                MetadataStream = memoryStream
              }.RestoreMetadata()).Select<AbstractMetadata, Guid>((Func<AbstractMetadata, Guid>) (md => MetadataItemManager.\u003C\u003Ec.JxfJGBC9ZIytorMBdH4y((object) md))).ToList<Guid>();
            }
            else
            {
              MetadataItemManager.publishLogger.Debug((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 1867443337));
              this.restartNeededMetadataUids = new List<Guid>();
            }
          }
        }
        else if (this.RuntimeApplication.IsFirstServerInCluster)
        {
          this.restartNeededMetadataUids = new List<Guid>();
        }
        else
        {
          (List<Guid> RestartRequired, ICollection<IRootMetadata> SoftPublished) result = this.ActorModelRuntime.GetActor<MetadataItemManager.IRestartRequiredMetadataUidsActor>(Guid.Empty).GetMetadata().GetAwaiter().GetResult();
          this.restartNeededMetadataUids = result.RestartRequired;
          result.SoftPublished.ForEach<IRootMetadata>((Action<IRootMetadata>) (m =>
          {
            int num = 1;
            while (true)
            {
              switch (num)
              {
                case 0:
                  goto label_2;
                case 1:
                  this.softPublishedMetadata[MetadataItemManager.L1dCnJhBkrsMdSMAxBxC((object) m)] = m;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 0;
                  continue;
                default:
                  goto label_4;
              }
            }
label_2:
            return;
label_4:;
          }));
        }
      }
      MetadataItemManager.publishLogger.Debug((object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420943150), (object) this.restartNeededMetadataUids.Count, (object) this.GetHashCode()));
      return this.restartNeededMetadataUids;
    }

    /// <summary>Получить главный модуль сценариев модели</summary>
    /// <returns></returns>
    [Obsolete("Not used", true)]
    public virtual ScriptModule GetModelScriptModule() => (ScriptModule) null;

    public override ExportRuleList ExportRules()
    {
      int num = 1;
      Type type;
      while (true)
      {
        switch (num)
        {
          case 1:
            type = InterfaceActivator.TypeOf<IMetadataItem>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      ExportRuleList exportRuleList = new ExportRuleList();
      ExportRule exportRule1 = new ExportRule();
      MetadataItemManager.gqCCy0hFUypETGZ5UV4a((object) exportRule1, type);
      MetadataItemManager.Mtnj97hFc04GtC4HA4Y0((object) exportRule1, MetadataItemManager.awSkQ8hFsFY6iYnV4Dt8(-1350312861 << 3 ^ 2082340230));
      MetadataItemManager.qk7FXihFzv81eWnjFTpt((object) exportRule1, ExportRuleType.Export);
      exportRuleList.Add(exportRule1);
      ExportRule exportRule2 = new ExportRule();
      MetadataItemManager.gqCCy0hFUypETGZ5UV4a((object) exportRule2, type);
      MetadataItemManager.Mtnj97hFc04GtC4HA4Y0((object) exportRule2, MetadataItemManager.awSkQ8hFsFY6iYnV4Dt8(236071375 ^ 235986733));
      exportRule2.ExportRuleType = ExportRuleType.Export;
      exportRuleList.Add(exportRule2);
      ExportRule exportRule3 = new ExportRule();
      exportRule3.ParentType = type;
      MetadataItemManager.Mtnj97hFc04GtC4HA4Y0((object) exportRule3, MetadataItemManager.awSkQ8hFsFY6iYnV4Dt8(-1317790512 ^ -1317713538));
      MetadataItemManager.qk7FXihFzv81eWnjFTpt((object) exportRule3, ExportRuleType.Export);
      exportRuleList.Add(exportRule3);
      ExportRule exportRule4 = new ExportRule();
      MetadataItemManager.gqCCy0hFUypETGZ5UV4a((object) exportRule4, type);
      exportRule4.PropertyName = (string) MetadataItemManager.awSkQ8hFsFY6iYnV4Dt8(-1822890472 ^ -1822928726);
      MetadataItemManager.qk7FXihFzv81eWnjFTpt((object) exportRule4, ExportRuleType.Export);
      exportRuleList.Add(exportRule4);
      ExportRule exportRule5 = new ExportRule();
      MetadataItemManager.gqCCy0hFUypETGZ5UV4a((object) exportRule5, type);
      MetadataItemManager.Mtnj97hFc04GtC4HA4Y0((object) exportRule5, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921224447));
      MetadataItemManager.qk7FXihFzv81eWnjFTpt((object) exportRule5, ExportRuleType.Export);
      exportRuleList.Add(exportRule5);
      ExportRule exportRule6 = new ExportRule();
      exportRule6.ParentType = type;
      MetadataItemManager.Mtnj97hFc04GtC4HA4Y0((object) exportRule6, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218433730));
      MetadataItemManager.qk7FXihFzv81eWnjFTpt((object) exportRule6, ExportRuleType.Export);
      exportRuleList.Add(exportRule6);
      ExportRule exportRule7 = new ExportRule();
      MetadataItemManager.gqCCy0hFUypETGZ5UV4a((object) exportRule7, type);
      MetadataItemManager.Mtnj97hFc04GtC4HA4Y0((object) exportRule7, MetadataItemManager.awSkQ8hFsFY6iYnV4Dt8(-53329496 >> 4 ^ -3323000));
      MetadataItemManager.qk7FXihFzv81eWnjFTpt((object) exportRule7, ExportRuleType.Export);
      exportRuleList.Add(exportRule7);
      return exportRuleList;
    }

    [PublicApiMember]
    public override void Save(IMetadataItem obj)
    {
      int num1 = 15;
      while (true)
      {
        int num2 = num1;
        NamedMetadata namedMetadata;
        EntityMetadata entityMetadata;
        IFormDependencyExtension dependencyExtension;
        IUser currentUser;
        IGroupedMetadata groupedMetadata;
        while (true)
        {
          switch (num2)
          {
            case 1:
              namedMetadata = MetadataItemManager.AuGuZxhBbW9PR9VmD94b((object) obj) as NamedMetadata;
              num2 = 23;
              continue;
            case 2:
              MetadataItemManager.axmHajhBfRJ2y0CHvXJc(MetadataItemManager.jOZ9blhBhB1FZq0OooPS((object) obj), MetadataItemManager.kFh1vZhBEkPvg2ho8m3L((object) obj));
              num2 = 13;
              continue;
            case 3:
              goto label_6;
            case 4:
              if (MetadataItemManager.jOZ9blhBhB1FZq0OooPS((object) obj) == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 1 : 3;
                continue;
              }
              goto case 32;
            case 5:
              MetadataItemManager.DGMB20hBQeeWpxHCM7Iq((object) obj.Header, (object) obj);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 32 : 32;
              continue;
            case 6:
              base.Save(obj);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
              continue;
            case 7:
              goto label_48;
            case 8:
              IEnumerable<IFormDependencyExtension> dependencyExtensions = this.FormDependencyExtensions;
              // ISSUE: reference to a compiler-generated field
              Func<IFormDependencyExtension, bool> func = MetadataItemManager.\u003C\u003Ec.\u003C\u003E9__51_0;
              Func<IFormDependencyExtension, bool> predicate;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                MetadataItemManager.\u003C\u003Ec.\u003C\u003E9__51_0 = predicate = (Func<IFormDependencyExtension, bool>) (q => q is EntityFormDependencyExtension);
              }
              else
                goto label_51;
label_50:
              dependencyExtension = dependencyExtensions.FirstOrDefault<IFormDependencyExtension>(predicate);
              num2 = 16;
              continue;
label_51:
              predicate = func;
              goto label_50;
            case 9:
              obj.CreationAuthorId = currentUser != null ? (long?) MetadataItemManager.tirC6VhBoOsvlHq3a58B((object) currentUser) : new long?();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 1 : 0;
              continue;
            case 10:
              MetadataItemManager.gHu650hBSMFiBdU2IPsk((object) this.MetadataItemSaveEventHandler, (object) obj);
              num2 = 6;
              continue;
            case 11:
              MetadataItemManager.fhPkjNhBuD4bZ4oJScQi(MetadataItemManager.jOZ9blhBhB1FZq0OooPS((object) obj), true);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 34 : 20;
              continue;
            case 12:
              entityMetadata = MetadataItemManager.AuGuZxhBbW9PR9VmD94b((object) obj) as EntityMetadata;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 8 : 31;
              continue;
            case 13:
              ((IMetadataItemHeader) MetadataItemManager.jOZ9blhBhB1FZq0OooPS((object) obj)).CreationAuthorId = currentUser != null ? (long?) MetadataItemManager.tirC6VhBoOsvlHq3a58B((object) currentUser) : new long?();
              num2 = 5;
              continue;
            case 14:
              goto label_9;
            case 15:
              MetadataItemManager.cIlKsyhBFSMdBVSCjGS0((object) obj, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-244066886 - -48452443 ^ -195589475));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 14 : 11;
              continue;
            case 16:
              if (dependencyExtension != null)
              {
                num2 = 25;
                continue;
              }
              goto label_45;
            case 17:
              ((IMetadataItemHeader) MetadataItemManager.jOZ9blhBhB1FZq0OooPS((object) obj)).Name = (string) MetadataItemManager.dCqANEhB8ZbPO9DAja84((object) namedMetadata);
              num2 = 29;
              continue;
            case 18:
            case 27:
              if (!this.WorkWithFormDependeciesService.IsActive())
              {
                num2 = 12;
                continue;
              }
              goto label_46;
            case 19:
              this.MetadataSourceCodeCache.Value.InvalidateCache(MetadataItemManager.FCNqSYhBR6PuxYSk5Gle(MetadataItemManager.jOZ9blhBhB1FZq0OooPS((object) obj)));
              num2 = 18;
              continue;
            case 20:
              goto label_31;
            case 21:
              currentUser = this.AuthenticationService.GetCurrentUser();
              num2 = 9;
              continue;
            case 22:
              MetadataItemManager.KU478NhBXnmuf2ZCq2ND(MetadataItemManager.eAHtLohBKiXlqTCVvIji(), (object) entityMetadata, (object) obj);
              num2 = 20;
              continue;
            case 23:
              groupedMetadata = MetadataItemManager.AuGuZxhBbW9PR9VmD94b((object) obj) as IGroupedMetadata;
              num2 = 4;
              continue;
            case 24:
              goto label_33;
            case 25:
              MetadataItemManager.xhBIPshBqUNQdSWexwKB((object) dependencyExtension, (object) entityMetadata);
              num2 = 33;
              continue;
            case 26:
              MetadataItemManager.Wvq0oShBvn62d3OFZiFT(MetadataItemManager.jOZ9blhBhB1FZq0OooPS((object) obj), MetadataItemManager.c0ftXqhBCNaQbBSYXF1I((object) namedMetadata));
              num2 = 17;
              continue;
            case 28:
              goto label_7;
            case 29:
              ((IMetadataItemHeader) MetadataItemManager.jOZ9blhBhB1FZq0OooPS((object) obj)).DisplayName = (string) MetadataItemManager.fi1L2xhBZ5QHJR4jX2ty((object) namedMetadata);
              num2 = 11;
              continue;
            case 30:
              if (!MetadataItemManager.TADi1uhBicrEqkIpPVxG((object) this.MetadataSourceCodeCache.Value))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 27 : 18;
                continue;
              }
              goto case 19;
            case 31:
              if (entityMetadata != null)
              {
                num2 = 8;
                continue;
              }
              goto label_17;
            case 32:
              if (namedMetadata != null)
              {
                num2 = 26;
                continue;
              }
              goto case 11;
            case 33:
              goto label_11;
            case 34:
              MetadataItemManager.cb773ohBVcCNou2bHNr5(MetadataItemManager.jOZ9blhBhB1FZq0OooPS((object) obj), groupedMetadata == null || groupedMetadata.GroupId <= 0L ? (object) (IMetadataItemGroup) null : (object) EntityManager<IMetadataItemGroup>.Instance.LoadOrNull((object) MetadataItemManager.uddN3uhBIrhJbnXI989m((object) groupedMetadata)));
              num2 = 10;
              continue;
            default:
              if (MetadataItemManager.AuGuZxhBbW9PR9VmD94b((object) obj) is ICodeItemMetadata)
              {
                num2 = 30;
                continue;
              }
              goto case 18;
          }
        }
label_6:
        MetadataItemManager.BrHLjnhBGG3LHwylJxrg((object) obj, (object) InterfaceActivator.Create<IMetadataItemHeader>());
        num1 = 2;
        continue;
label_9:
        MetadataItemManager.WlBAL2hBWQiE0bJPKVsT((object) obj, MetadataItemManager.hiTi1VhBBI29vCcMKQ13());
        num1 = 21;
        continue;
label_11:
        if (obj.Header.Current == obj)
          num1 = 22;
        else
          goto label_19;
      }
label_48:
      return;
label_31:
      return;
label_33:
      return;
label_7:
      return;
label_19:
      return;
label_45:
      return;
label_46:
      return;
label_17:;
    }

    private IDynamicPublicationService DynamicPublicationService
    {
      get
      {
        int num = 2;
        IDynamicPublicationService service;
        IDynamicPublicationService publicationService;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.dynamicPublicationService = service = Locator.GetService<IDynamicPublicationService>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
              continue;
            case 2:
              publicationService = this.dynamicPublicationService;
              if (publicationService == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 1 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_6;
          }
        }
label_2:
        return publicationService;
label_6:
        return service;
      }
    }

    /// <summary>
    /// Получить список оберток объектов с клиентскими скрипт модулями
    /// </summary>
    /// <returns>Список оберток объектов с клиентскими скрипт модулями</returns>
    internal IEnumerable<MetadataItemWithScriptModuleWrapper> GetItemsWithClientScriptModules() => (IEnumerable<MetadataItemWithScriptModuleWrapper>) this.Session.CreateCriteria(InterfaceActivator.TypeOf<IMetadataItemHeader>()).CreateAlias(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1204263869 ^ -1341583247 ^ 137562792), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1925118608 << 2 ^ -889503170), JoinType.LeftOuterJoin).Add((ICriterion) Restrictions.IsNotNull(z2jc63fLkugS1X8Q9N.tE1kD1vbB(979449278 ^ 979512078))).SetProjection((IProjection) Projections.ProjectionList().Add((IProjection) Projections.Property(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1875996083)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917256330 ^ 1917283608)).Add((IProjection) Projections.Property(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1253244298 - 1829393894 ^ -575948524)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488852133)).Add((IProjection) Projections.Property(z2jc63fLkugS1X8Q9N.tE1kD1vbB(825385222 ^ 825327600)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(813604817 ^ 813574419))).SetResultTransformer((IResultTransformer) new EleWise.ELMA.Runtime.NH.AliasToBeanResultTransformer(typeof (MetadataItemWithScriptModuleWrapper))).List<MetadataItemWithScriptModuleWrapper>();

    /// <summary>Получить список объектов на 2-м рантайме</summary>
    /// <returns>Список объектов</returns>
    internal IEnumerable<IMetadataItem> GetItemsWithRuntimeV2() => (IEnumerable<IMetadataItem>) this.CreateCriteria(FetchOptions.All, this.ImplementationType, z2jc63fLkugS1X8Q9N.tE1kD1vbB(322893104 - -1992822529 ^ -1979208625)).CreateAlias(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470440286 ^ 1470469612), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1335021413), JoinType.InnerJoin, (ICriterion) Restrictions.EqProperty(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-680446928 - -370807692 ^ -309831512), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1819636893 << 3 ^ 1672002510))).Add((ICriterion) Restrictions.IsNotNull(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461625753 ^ 1461605967))).List<IMetadataItem>();

    /// <summary>Метод обработки дельта-публикации на узле</summary>
    /// <param name="result">Результат публикации метаданных для сборок</param>
    /// <param name="softPublished">Уникальные идентификаторы метаданных мягкой публикации</param>
    /// <param name="deltaPublished">Уникальные идентификаторы метаданных дельта-публикации</param>
    /// <param name="restartNeeded">Метаданных требующих перезапуск</param>
    /// <param name="waitPublicationTask">Задача ожидания завершения публикации</param>
    internal Task PublicationStarted(
      MetadataAssemblyPublishResult result,
      Guid[] softPublished,
      Guid[] deltaPublished,
      IRootMetadata[] restartNeeded,
      Task waitPublicationTask)
    {
      int num = 6;
      // ISSUE: variable of a compiler-generated type
      MetadataItemManager.\u003CPublicationStarted\u003Ed__60 stateMachine;
      AsyncTaskMethodBuilder tBuilder;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: reference to a compiler-generated field
            stateMachine.softPublished = softPublished;
            num = 7;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E1__state = -1;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 1 : 3;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            tBuilder = stateMachine.\u003C\u003Et__builder;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 5 : 8;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated field
            stateMachine.restartNeeded = restartNeeded;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 8 : 10;
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated field
            stateMachine.result = result;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 1 : 1;
            continue;
          case 6:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E4__this = this;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 5 : 5;
            continue;
          case 7:
            // ISSUE: reference to a compiler-generated field
            stateMachine.deltaPublished = deltaPublished;
            num = 4;
            continue;
          case 8:
            tBuilder.Start<MetadataItemManager.\u003CPublicationStarted\u003Ed__60>(ref stateMachine);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 0;
            continue;
          case 9:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003Et__builder = MetadataItemManager.qC2b7OhBTGS3gl2HkGXN();
            num = 2;
            continue;
          case 10:
            // ISSUE: reference to a compiler-generated field
            stateMachine.waitPublicationTask = waitPublicationTask;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 6 : 9;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    private void AddCompositeToSoftPublished(ICompositeMetadata compositeMetadata, bool add)
    {
      int num1 = 4;
      IEnumerator<IMetadata> enumerator;
      while (true)
      {
        IEnumerable<IMetadata> metadatas1;
        IEnumerable<IMetadata> metadatas2;
        switch (num1)
        {
          case 0:
            goto label_33;
          case 1:
            goto label_26;
          case 2:
            if (metadatas1 == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 1 : 0;
              continue;
            }
            enumerator = metadatas1.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 5;
            continue;
          case 3:
            metadatas2 = (IEnumerable<IMetadata>) null;
            break;
          case 4:
            if (compositeMetadata == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 1 : 3;
              continue;
            }
            metadatas2 = compositeMetadata.GetCompositeParts();
            break;
          case 5:
            goto label_2;
          default:
            goto label_25;
        }
        metadatas1 = metadatas2;
        num1 = 2;
      }
label_33:
      return;
label_26:
      return;
label_25:
      return;
label_2:
      try
      {
label_18:
        if (MetadataItemManager.kaWC1ChB2EBtc5YfAyKZ((object) enumerator))
          goto label_6;
        else
          goto label_19;
label_4:
        IMetadata current;
        int num2;
        while (true)
        {
          int num3;
          switch (num2)
          {
            case 1:
            case 13:
            case 15:
              if (!(current is ICompositeMetadata compositeMetadata1))
              {
                num2 = 2;
                continue;
              }
              goto case 14;
            case 2:
            case 3:
              goto label_18;
            case 5:
              goto label_6;
            case 6:
              if (!MetadataItemManager.publishLogger.IsTraceEnabled())
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 0;
                continue;
              }
              goto case 10;
            case 7:
            case 9:
              this.softPublishedMetadata.Remove(MetadataItemManager.L1dCnJhBkrsMdSMAxBxC((object) current));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 1 : 0;
              continue;
            case 8:
              if (!add)
              {
                num2 = 7;
                continue;
              }
              goto case 12;
            case 10:
              MetadataItemManager.zsLDp7hBOUr8XYTwiEvs((object) MetadataItemManager.publishLogger, MetadataItemManager.gZZrw7hBnYmWqAg5I46J(MetadataItemManager.awSkQ8hFsFY6iYnV4Dt8(-787452571 ^ -787254737), (object) new object[4]
              {
                (object) compositeMetadata.Uid,
                (object) compositeMetadata,
                (object) MetadataItemManager.L1dCnJhBkrsMdSMAxBxC((object) current),
                (object) current
              }));
              num2 = 4;
              continue;
            case 11:
              goto label_21;
            case 12:
              this.softPublishedMetadata[MetadataItemManager.L1dCnJhBkrsMdSMAxBxC((object) current)] = rootMetadata;
              num3 = 15;
              break;
            case 14:
              this.AddCompositeToSoftPublished(compositeMetadata1, add);
              num2 = 3;
              continue;
            default:
              if (!(current is IRootMetadata rootMetadata))
              {
                num3 = 13;
                break;
              }
              goto case 8;
          }
          num2 = num3;
        }
label_21:
        return;
label_6:
        current = enumerator.Current;
        num2 = 6;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
        {
          num2 = 6;
          goto label_4;
        }
        else
          goto label_4;
label_19:
        num2 = 11;
        goto label_4;
      }
      finally
      {
        int num4;
        if (enumerator == null)
          num4 = 2;
        else
          goto label_27;
label_24:
        switch (num4)
        {
          case 1:
            break;
          default:
        }
label_27:
        MetadataItemManager.nRMCyhhBekcCu6eeOrfb((object) enumerator);
        num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
        {
          num4 = 0;
          goto label_24;
        }
        else
          goto label_24;
      }
    }

    public MetadataItemManager()
    {
      MetadataItemManager.y8d9D0hBPFIUeGBBaaK3();
      this.softPublishedMetadata = PublishCacheContext.CreateCache<Guid, IRootMetadata>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static MetadataItemManager()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            MetadataItemManager.y8d9D0hBPFIUeGBBaaK3();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            MetadataItemManager.publishLogger = (ILogger) MetadataItemManager.HVA3ojhB1Ssosc6Xo7px(MetadataItemManager.awSkQ8hFsFY6iYnV4Dt8(-882126494 ^ -882323806));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static bool Q3NCIVhFYbnV3JZ3loBf() => MetadataItemManager.WpUPgPhFjOWJxVPVc3V3 == null;

    internal static MetadataItemManager SNEaMkhFLNoJQWMRk5u2() => MetadataItemManager.WpUPgPhFjOWJxVPVc3V3;

    internal static void gqCCy0hFUypETGZ5UV4a([In] object obj0, Type value) => ((ExportRule) obj0).ParentType = value;

    internal static object awSkQ8hFsFY6iYnV4Dt8(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void Mtnj97hFc04GtC4HA4Y0([In] object obj0, [In] object obj1) => ((ExportRule) obj0).PropertyName = (string) obj1;

    internal static void qk7FXihFzv81eWnjFTpt([In] object obj0, ExportRuleType value) => ((ExportRule) obj0).ExportRuleType = value;

    internal static void cIlKsyhBFSMdBVSCjGS0([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static DateTime hiTi1VhBBI29vCcMKQ13() => DateTime.Now;

    internal static void WlBAL2hBWQiE0bJPKVsT([In] object obj0, DateTime value) => ((IMetadataItem) obj0).CreationDate = value;

    internal static object tirC6VhBoOsvlHq3a58B([In] object obj0) => ((IIdentified) obj0).GetId();

    internal static object AuGuZxhBbW9PR9VmD94b([In] object obj0) => ((IMetadataItem) obj0).Metadata;

    internal static object jOZ9blhBhB1FZq0OooPS([In] object obj0) => (object) ((IMetadataItem) obj0).Header;

    internal static void BrHLjnhBGG3LHwylJxrg([In] object obj0, [In] object obj1) => ((IMetadataItem) obj0).Header = (IMetadataItemHeader) obj1;

    internal static DateTime kFh1vZhBEkPvg2ho8m3L([In] object obj0) => ((IMetadataItem) obj0).CreationDate;

    internal static void axmHajhBfRJ2y0CHvXJc([In] object obj0, DateTime value) => ((IMetadataItemHeader) obj0).CreationDate = value;

    internal static void DGMB20hBQeeWpxHCM7Iq([In] object obj0, [In] object obj1) => ((IMetadataItemHeader) obj0).Current = (IMetadataItem) obj1;

    internal static Guid c0ftXqhBCNaQbBSYXF1I([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static void Wvq0oShBvn62d3OFZiFT([In] object obj0, Guid value) => ((IMetadataItemHeader) obj0).Uid = value;

    internal static object dCqANEhB8ZbPO9DAja84([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object fi1L2xhBZ5QHJR4jX2ty([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;

    internal static void fhPkjNhBuD4bZ4oJScQi([In] object obj0, bool value) => ((IMetadataItemHeader) obj0).IsDirtyItem = value;

    internal static long uddN3uhBIrhJbnXI989m([In] object obj0) => ((IGroupedMetadata) obj0).GroupId;

    internal static void cb773ohBVcCNou2bHNr5([In] object obj0, [In] object obj1) => ((IMetadataItemHeader) obj0).Group = (IMetadataItemGroup) obj1;

    internal static void gHu650hBSMFiBdU2IPsk([In] object obj0, [In] object obj1) => ((IMetadataItemSaveEventHandler) obj0).BeforeSave((IMetadataItem) obj1);

    internal static bool TADi1uhBicrEqkIpPVxG([In] object obj0) => ((IMetadataSourceCodeCache) obj0).IsGlobalCacheExists();

    internal static Guid FCNqSYhBR6PuxYSk5Gle([In] object obj0) => ((IMetadataItemHeader) obj0).Uid;

    internal static void xhBIPshBqUNQdSWexwKB([In] object obj0, [In] object obj1) => ((IFormDependencyExtension) obj0).GenerateNewDependencies((IMetadata) obj1);

    internal static object eAHtLohBKiXlqTCVvIji() => (object) MetadataItemManager.EntityMetadataDependencyService;

    internal static void KU478NhBXnmuf2ZCq2ND([In] object obj0, [In] object obj1, [In] object obj2) => ((IEntityMetadataDependencyService) obj0).CollectDependencies((EntityMetadata) obj1, (IMetadataItem) obj2);

    internal static AsyncTaskMethodBuilder qC2b7OhBTGS3gl2HkGXN() => AsyncTaskMethodBuilder.Create();

    internal static Guid L1dCnJhBkrsMdSMAxBxC([In] object obj0) => ((IMetadata) obj0).Uid;

    internal static object gZZrw7hBnYmWqAg5I46J([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, (object[]) obj1);

    internal static void zsLDp7hBOUr8XYTwiEvs([In] object obj0, [In] object obj1) => ((ILogger) obj0).Trace(obj1);

    internal static bool kaWC1ChB2EBtc5YfAyKZ([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void nRMCyhhBekcCu6eeOrfb([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void y8d9D0hBPFIUeGBBaaK3() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object HVA3ojhB1Ssosc6Xo7px([In] object obj0) => (object) EleWise.ELMA.Logging.Logger.GetLogger((string) obj0);

    /// <summary>
    /// Обработчик события публикации метаданных для получения результата, который нужно вернуть из метода публикации
    /// </summary>
    private class PublishResultResolver : IMetadataPublishFinishedEventHandler, IEventHandler
    {
      private static object zxeHJ6CJrY6G0j5fjZbE;

      public MetadataPublishResult PublishResult
      {
        get => this.\u003CPublishResult\u003Ek__BackingField;
        private set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this.\u003CPublishResult\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
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

      public void PublishExecuted(MetadataPublishedEventArgs e)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.PublishResult = e.PublishResult;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      public PublishResultResolver()
      {
        MetadataItemManager.PublishResultResolver.vh2eRDCJjjPkpEekYNtC();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool gBfbFiCJgDy32PIrDWvg() => MetadataItemManager.PublishResultResolver.zxeHJ6CJrY6G0j5fjZbE == null;

      internal static MetadataItemManager.PublishResultResolver fc67HtCJ5McUFvLwZ46S() => (MetadataItemManager.PublishResultResolver) MetadataItemManager.PublishResultResolver.zxeHJ6CJrY6G0j5fjZbE;

      internal static void vh2eRDCJjjPkpEekYNtC() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }

    /// <summary>Обработчик события публикации</summary>
    private class PublicationEventHandler : IPublicationEventHandler, IEventHandler
    {
      private readonly TaskCompletionSource<bool> waitPublication;
      private readonly Dictionary<Guid, Exception> completeTokens;
      private Guid token;
      internal static object UxWDRGCJYOleAcTV51El;

      public void InitToken(Guid token)
      {
        int num1 = 1;
        Dictionary<Guid, Exception> completeTokens;
        bool lockTaken;
        while (true)
        {
          switch (num1)
          {
            case 1:
              this.token = token;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
              continue;
            case 2:
              lockTaken = false;
              num1 = 5;
              continue;
            case 3:
              completeTokens = this.completeTokens;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 2 : 2;
              continue;
            case 4:
              goto label_18;
            case 5:
              goto label_3;
            case 6:
              goto label_7;
            default:
              if (!MetadataItemManager.PublicationEventHandler.DoX8K2CJsf7tQbw86jcg(token, Guid.Empty))
              {
                num1 = 4;
                continue;
              }
              goto case 3;
          }
        }
label_18:
        return;
label_7:
        return;
label_3:
        try
        {
          Monitor.Enter((object) completeTokens, ref lockTaken);
          int num2 = 3;
          Exception exception;
          while (true)
          {
            switch (num2)
            {
              case 0:
                goto label_16;
              case 1:
                goto label_13;
              case 2:
                this.Error(token, exception);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 1;
                continue;
              case 3:
                if (!this.completeTokens.TryGetValue(token, out exception))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
                  continue;
                }
                goto case 2;
              default:
                goto label_9;
            }
          }
label_16:
          return;
label_13:
          return;
label_9:;
        }
        finally
        {
          int num3;
          if (!lockTaken)
            num3 = 2;
          else
            goto label_14;
label_12:
          switch (num3)
          {
            case 1:
              break;
            default:
          }
label_14:
          MetadataItemManager.PublicationEventHandler.Y0cpv1CJciJvKd1WNEsL((object) completeTokens);
          num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0)
          {
            num3 = 0;
            goto label_12;
          }
          else
            goto label_12;
        }
      }

      public void Complete(Guid publicationToken)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.Error(publicationToken, (Exception) null);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      public void Error(Guid publicationToken, Exception exception)
      {
        int num1 = 14;
        while (true)
        {
          int num2 = num1;
          bool lockTaken;
          Dictionary<Guid, Exception> completeTokens;
          while (true)
          {
            switch (num2)
            {
              case 1:
label_18:
                if (MetadataItemManager.PublicationEventHandler.IZVI60CJzLKchtKbDsk4(publicationToken, this.token))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
                  continue;
                }
                goto label_32;
              case 2:
                if (exception is MetadataPublishingException)
                {
                  num2 = 12;
                  continue;
                }
                goto case 5;
              case 3:
                goto label_33;
              case 4:
                goto label_4;
              case 5:
                if (!(exception is InvalidOperationException))
                {
                  num2 = 9;
                  continue;
                }
                goto case 8;
              case 6:
                this.waitPublication.SetResult(true);
                num2 = 4;
                continue;
              case 7:
                try
                {
                  Monitor.Enter((object) completeTokens, ref lockTaken);
                  int num3 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
                    num3 = 1;
                  while (true)
                  {
                    switch (num3)
                    {
                      case 0:
                        goto label_28;
                      case 1:
                        if (MetadataItemManager.PublicationEventHandler.IZVI60CJzLKchtKbDsk4(this.token, Guid.Empty))
                        {
                          num3 = 3;
                          continue;
                        }
                        goto label_18;
                      case 2:
                        goto label_18;
                      case 3:
                        this.completeTokens[publicationToken] = exception;
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_24;
                    }
                  }
label_28:
                  return;
label_24:
                  return;
                }
                finally
                {
                  int num4;
                  if (!lockTaken)
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 0;
                  else
                    goto label_34;
label_31:
                  switch (num4)
                  {
                    case 2:
                      break;
                    default:
                  }
label_34:
                  MetadataItemManager.PublicationEventHandler.Y0cpv1CJciJvKd1WNEsL((object) completeTokens);
                  num4 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0)
                  {
                    num4 = 1;
                    goto label_31;
                  }
                  else
                    goto label_31;
                }
              case 8:
              case 12:
                this.waitPublication.SetException(exception);
                num2 = 3;
                continue;
              case 9:
                if (!(exception is MetadataValidationException))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 8 : 10;
                  continue;
                }
                goto case 8;
              case 10:
                exception = (Exception) new InvalidOperationException((string) MetadataItemManager.PublicationEventHandler.MdNvwiC9FNArSYPd9arR((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1251470110 >> 2 ^ 312495903)), exception);
                num2 = 8;
                continue;
              case 11:
                lockTaken = false;
                num2 = 7;
                continue;
              case 13:
                completeTokens = this.completeTokens;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 11 : 5;
                continue;
              case 14:
                if (this.token == Guid.Empty)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 13 : 2;
                  continue;
                }
                goto case 1;
              default:
                if (exception != null)
                  goto case 2;
                else
                  goto label_14;
            }
          }
label_14:
          num1 = 6;
        }
label_33:
        return;
label_4:
        return;
label_32:;
      }

      public Task WaitPublication => (Task) this.waitPublication.Task;

      public PublicationEventHandler()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        this.waitPublication = new TaskCompletionSource<bool>(TaskCreationOptions.RunContinuationsAsynchronously);
        this.completeTokens = new Dictionary<Guid, Exception>();
        this.token = Guid.Empty;
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool DoX8K2CJsf7tQbw86jcg([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

      internal static void Y0cpv1CJciJvKd1WNEsL([In] object obj0) => Monitor.Exit(obj0);

      internal static bool CmrjmpCJLca8Jv5sagTH() => MetadataItemManager.PublicationEventHandler.UxWDRGCJYOleAcTV51El == null;

      internal static MetadataItemManager.PublicationEventHandler tJcRZ5CJUVrG4I17Lqrr() => (MetadataItemManager.PublicationEventHandler) MetadataItemManager.PublicationEventHandler.UxWDRGCJYOleAcTV51El;

      internal static bool IZVI60CJzLKchtKbDsk4([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

      internal static object MdNvwiC9FNArSYPd9arR([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);
    }

    /// <summary>
    /// Актор для получения списка метаданных, требующих перезапуска на ферме при запреденной динамической публикации
    /// </summary>
    internal interface IRestartRequiredMetadataUidsActor : IActorWithGuidKey, IActor
    {
      /// <summary>
      /// Получить список идентификаторов объектов метаданных, для которых требуется перезапуск сервера, и метаданные мягкой публикации
      /// </summary>
      /// <returns></returns>
      Task<(List<Guid> RestartRequired, ICollection<IRootMetadata> SoftPublished)> GetMetadata();
    }

    /// <inheritdoc />
    internal class RestartRequiredMetadataUidsActor : 
      Actor,
      MetadataItemManager.IRestartRequiredMetadataUidsActor,
      IActorWithGuidKey,
      IActor
    {
      private readonly MetadataItemManager metadataItemManager;
      internal static MetadataItemManager.RestartRequiredMetadataUidsActor dYPJXLC9bD439FJ8pkry;

      /// <summary>ctor</summary>
      /// <param name="metadataItemManager">Менеджер элементов метаданных</param>
      public RestartRequiredMetadataUidsActor(MetadataItemManager metadataItemManager)
      {
        MetadataItemManager.RestartRequiredMetadataUidsActor.SgsLkFC9EkL0FsOfdC44();
        this.LifeTime = MetadataItemManager.RestartRequiredMetadataUidsActor.sPweRtC9fOSSRP3uA3VI(1.0);
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            default:
              this.metadataItemManager = metadataItemManager;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 1 : 0;
              continue;
          }
        }
label_3:;
      }

      /// <inheritdoc />
      public override TimeSpan LifeTime { get; }

      /// <inheritdoc />
      public Task<(List<Guid>, ICollection<IRootMetadata>)> GetMetadata() => Task.FromResult<(List<Guid>, ICollection<IRootMetadata>)>((this.metadataItemManager.restartNeededMetadataUids ?? new List<Guid>(), this.metadataItemManager.softPublishedMetadata.Values));

      internal static void SgsLkFC9EkL0FsOfdC44() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static TimeSpan sPweRtC9fOSSRP3uA3VI([In] double obj0) => TimeSpan.FromMinutes(obj0);

      internal static bool dcH42rC9hXvGjPNJqmjx() => MetadataItemManager.RestartRequiredMetadataUidsActor.dYPJXLC9bD439FJ8pkry == null;

      internal static MetadataItemManager.RestartRequiredMetadataUidsActor lxUdWQC9GA6Qf28ekqPu() => MetadataItemManager.RestartRequiredMetadataUidsActor.dYPJXLC9bD439FJ8pkry;
    }
  }
}
