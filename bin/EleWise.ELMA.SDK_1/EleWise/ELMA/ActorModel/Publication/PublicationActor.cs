// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ActorModel.Publication.PublicationActor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Starting;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Db;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.ExtensionPoints;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Cache;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Helpers;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.ActorModel.Publication
{
  /// <summary>Эктор публикации</summary>
  internal sealed class PublicationActor : Actor, IPublicationActor, IActorWithGuidKey, IActor
  {
    private readonly IUnitOfWorkManagerAsync unitOfWorkManager;
    private readonly ILazy<ISecurityService> securityService;
    private readonly ILazy<ISessionProvider> sessionProvider;
    private readonly ILazy<ITransformationProvider> transformationProvider;
    private readonly ILazy<MetadataItemHeaderManager> metadataItemHeaderManager;
    private readonly ILazy<MetadataItemManager> metadataItemManager;
    private readonly IActorModelRuntime actorModelRuntime;
    private readonly IRuntimeApplication runtimeApplication;
    private readonly IDynamicPublicationService dynamicPublicationService;
    private readonly ILazy<IMetadataRuntimeService> metadataRuntimeService;
    private readonly IAfterDeltaPublishEventHandler afterDeltaPublishEventHandler;
    private readonly IEventHandlerSubscribeService eventHandlerSubscribeService;
    private readonly IServerPlacementPublishService serverPlacementPublishService;
    private readonly IEnumerable<IPublicationHandler> publicationHandlers;
    private readonly ISearchMetadataService searchMetadataService;
    private readonly ILazy<IModelAssemblyBuilderHandler> modelAssemblyBuilderHandler;
    private readonly IEntityMetadataDependencyService entityMetadataDependencyService;
    private readonly IWorkWithFormDependeciesService workWithFormDependenciesService;
    private readonly ILogger publishLogger;
    private readonly HashSet<Guid> completeTokens;
    private IDisposable publishFinishedEventHandler;
    private IDisposable serverStatusEventHandler;
    private EleWise.ELMA.Model.Metadata.AbstractMetadata[] publishedMetadata;
    private Version publishedVersion;
    private HashSet<Guid> waitUids;
    private HashSet<Guid> waitRuntimeUpdateUids;
    private TaskCompletionSource<bool> waitNodesPublicationComplete;
    private TaskCompletionSource<bool> waitNodesRuntimeUpdateComplete;
    private Guid? publicationToken;
    private IDictionary<string, long> assemblyModelsMetadataIds;
    private static PublicationActor sjpvosfpA66fOdgSrIkN;

    /// <summary>ctor</summary>
    /// <param name="unitOfWorkManager">Фабрика единиц работы</param>
    /// <param name="securityService">Сервис проверки привилегий пользователя</param>
    /// <param name="sessionProvider">Провайдер сессий NHibernate</param>
    /// <param name="transformationProvider">провайдер преобразования БД</param>
    /// <param name="metadataItemHeaderManager">Менеджер заголовков элемента метаданных</param>
    /// <param name="metadataItemManager">Менеджер элементов метаданных</param>
    /// <param name="actorModelRuntime">Среда исполнения акторов</param>
    /// <param name="runtimeApplication">Среда исполнения приложения</param>
    /// <param name="dynamicPublicationService">Сервис динамической публикации</param>
    /// <param name="metadataRuntimeService">Служба управления метаданными в режиме Runtime</param>
    /// <param name="afterDeltaPublishEventHandler">Обработчик события публикации для обновления базы данных</param>
    /// <param name="eventHandlerSubscribeService">Сервис для ручной подписки на события</param>
    /// <param name="serverPlacementPublishService">Сервис публикации действия на всех серверах кластера ELMA</param>
    /// <param name="publicationHandlers">Обработчики публикации метаданных</param>
    /// <param name="searchMetadataService">Сервис поиска метаданных</param>
    /// <param name="modelAssemblyBuilderHandler">Точка расширения, реагирующая на построение динамических сборок</param>
    /// <param name="entityMetadataDependencyService">Сервис сбора зависимостей для сущностей</param>
    /// <param name="workWithFormDependenciesService">Сервис для ограничения работы с зависимостями форм</param>
    public PublicationActor(
      IUnitOfWorkManagerAsync unitOfWorkManager,
      ILazy<ISecurityService> securityService,
      ILazy<ISessionProvider> sessionProvider,
      ILazy<ITransformationProvider> transformationProvider,
      ILazy<MetadataItemHeaderManager> metadataItemHeaderManager,
      ILazy<MetadataItemManager> metadataItemManager,
      IActorModelRuntime actorModelRuntime,
      IRuntimeApplication runtimeApplication,
      IDynamicPublicationService dynamicPublicationService,
      ILazy<IMetadataRuntimeService> metadataRuntimeService,
      IAfterDeltaPublishEventHandler afterDeltaPublishEventHandler,
      IEventHandlerSubscribeService eventHandlerSubscribeService,
      IServerPlacementPublishService serverPlacementPublishService,
      IEnumerable<IPublicationHandler> publicationHandlers,
      ISearchMetadataService searchMetadataService,
      ILazy<IModelAssemblyBuilderHandler> modelAssemblyBuilderHandler,
      IEntityMetadataDependencyService entityMetadataDependencyService,
      IWorkWithFormDependeciesService workWithFormDependenciesService)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.completeTokens = new HashSet<Guid>();
      this.LifeTime = TimeSpan.FromDays(365.0);
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.unitOfWorkManager = unitOfWorkManager;
      this.securityService = securityService;
      this.sessionProvider = sessionProvider;
      this.transformationProvider = transformationProvider;
      this.metadataItemHeaderManager = metadataItemHeaderManager;
      this.metadataItemManager = metadataItemManager;
      this.actorModelRuntime = actorModelRuntime;
      this.runtimeApplication = runtimeApplication;
      this.dynamicPublicationService = dynamicPublicationService;
      this.metadataRuntimeService = metadataRuntimeService;
      this.afterDeltaPublishEventHandler = afterDeltaPublishEventHandler;
      this.eventHandlerSubscribeService = eventHandlerSubscribeService;
      this.serverPlacementPublishService = serverPlacementPublishService;
      this.publicationHandlers = publicationHandlers;
      this.searchMetadataService = searchMetadataService;
      this.modelAssemblyBuilderHandler = modelAssemblyBuilderHandler;
      this.entityMetadataDependencyService = entityMetadataDependencyService;
      this.workWithFormDependenciesService = workWithFormDependenciesService;
      this.publishLogger = EleWise.ELMA.Logging.Logger.GetLogger(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1334934577));
    }

    /// <inheritdoc />
    public override TimeSpan LifeTime { get; }

    /// <inheritdoc />
    public override Task OnActivateAsync()
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            this.publishFinishedEventHandler = this.eventHandlerSubscribeService.Subscribe((IEventHandler) new PublicationActor.PublishFinishedEventHandler(new Action<MetadataPublishedEventArgs>(this.PublishFinished)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
            continue;
          case 3:
            if (PublicationActor.nZOJpmfpylYSIoU5LJpP((object) this.dynamicPublicationService))
            {
              num = 2;
              continue;
            }
            break;
          case 4:
            PublicationActor.Ic8mZYfpm7pLAh7eYV5s((object) this.publishLogger, PublicationActor.BaDoFSfp0Y3o0kH3tZnG(1461625753 ^ 1461450499));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 1 : 3;
            continue;
        }
        this.serverStatusEventHandler = (IDisposable) PublicationActor.vTLMjVfpMNNPmgYFlnNU((object) this.eventHandlerSubscribeService, (object) new PublicationActor.ServerStatusEventHandler(new System.Func<Guid, Task>(this.Complete)));
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 1 : 1;
      }
label_5:
      return (Task) PublicationActor.CNhprlfpJR56VHcSvmc5();
    }

    /// <inheritdoc />
    public override Task OnDeactivateAsync()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            IDisposable finishedEventHandler = this.publishFinishedEventHandler;
            if (finishedEventHandler == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
              continue;
            }
            finishedEventHandler.Dispose();
            num = 3;
            continue;
          case 2:
            PublicationActor.Ic8mZYfpm7pLAh7eYV5s((object) this.publishLogger, PublicationActor.BaDoFSfp0Y3o0kH3tZnG(2008901894 << 3 ^ -1108704432));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 1 : 1;
            continue;
          case 4:
            goto label_5;
          default:
            PublicationActor.NbhRh4fp9pcZgJLHtPab((object) this.serverStatusEventHandler);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 3 : 4;
            continue;
        }
      }
label_5:
      return (Task) PublicationActor.CNhprlfpJR56VHcSvmc5();
    }

    /// <inheritdoc />
    public override Task ReceiveReminder(string reminderName)
    {
      int num = 5;
      AsyncTaskMethodBuilder tBuilder;
      // ISSUE: variable of a compiler-generated type
      PublicationActor.\u003CReceiveReminder\u003Ed__36 stateMachine;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E1__state = -1;
            num = 6;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003Et__builder = PublicationActor.psnbbpfpdMlTuWb2vEQN();
            num = 2;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated field
            stateMachine.reminderName = reminderName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 3 : 3;
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E4__this = this;
            num = 4;
            continue;
          case 6:
            // ISSUE: reference to a compiler-generated field
            tBuilder = stateMachine.\u003C\u003Et__builder;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
            continue;
          default:
            tBuilder.Start<PublicationActor.\u003CReceiveReminder\u003Ed__36>(ref stateMachine);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 1;
            continue;
        }
      }
label_5:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    /// <inheritdoc />
    public async Task<Guid> Start(string comment, string tag, params long[] headerIds)
    {
      int num1 = 2;
      while (true)
      {
        int num2;
        Guid result;
        PublicationActor publicationActor1;
        switch (num1)
        {
          case 1:
            publicationActor1 = this;
            num1 = 5;
            continue;
          case 2:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 1 : 1;
            continue;
          case 3:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(result);
            num1 = 4;
            continue;
          case 4:
            goto label_65;
          case 5:
            try
            {
              int num3;
              if (num2 != 0)
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 9 : 14;
              else
                goto label_50;
label_8:
              TaskAwaiter taskAwaiter1;
              TaskAwaiter awaiter1;
              PublicationActor publicationActor;
              string comment1;
              string tag1;
              long[] headerIds1;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                  case 19:
                    awaiter1.GetResult();
                    num3 = 3;
                    continue;
                  case 2:
                    publicationActor = this;
                    num3 = 5;
                    continue;
                  case 3:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    PublicationActor.\u003CStart\u003Ed__37.n1j29JZhZQi5MkgeX3DB((object) publicationActor1.publishLogger, PublicationActor.\u003CStart\u003Ed__37.qC3PxvZh8UT4MAFVK4TU(PublicationActor.\u003CStart\u003Ed__37.AxbLnRZhfwBDab6hs3qJ(~210725948 ^ -210334197), (object) publicationActor1.publicationToken));
                    num3 = 9;
                    continue;
                  case 4:
                    if (publicationActor1.publicationToken.HasValue)
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 1 : 24;
                      continue;
                    }
                    goto label_50;
                  case 5:
                    comment1 = comment;
                    num3 = 23;
                    continue;
                  case 6:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 1;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 11 : 4;
                    continue;
                  case 7:
                    awaiter1 = taskAwaiter1;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 18 : 1;
                    continue;
                  case 8:
                    goto label_58;
                  case 9:
                    publicationActor1.RunExternalTask((Func<Task>) (() => publicationActor.StartInternal(comment1, tag1, headerIds1)));
                    num3 = 16;
                    continue;
                  case 10:
                    try
                    {
                      int num4;
                      if (num2 != 0)
                        num4 = 6;
                      else
                        goto label_29;
label_26:
                      int num5 = num4;
label_27:
                      TaskAwaiter<IReadOnlyDictionary<Guid, DbConnectionStatus>> taskAwaiter2;
                      TaskAwaiter<IReadOnlyDictionary<Guid, DbConnectionStatus>> awaiter2;
                      while (true)
                      {
                        switch (num5)
                        {
                          case 1:
                            taskAwaiter2 = new TaskAwaiter<IReadOnlyDictionary<Guid, DbConnectionStatus>>();
                            num5 = 4;
                            continue;
                          case 2:
                            taskAwaiter2 = awaiter2;
                            num5 = 8;
                            continue;
                          case 3:
                            goto label_29;
                          case 4:
                            // ISSUE: explicit reference operation
                            // ISSUE: reference to a compiler-generated field
                            (^this).\u003C\u003E1__state = num2 = -1;
                            num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 10 : 6;
                            continue;
                          case 5:
                            goto label_62;
                          case 6:
                            awaiter2 = publicationActor1.serverPlacementPublishService.For<EleWise.ELMA.ActorModel.Starting.IServerInstanceActor>().Publish<DbConnectionStatus>((System.Func<EleWise.ELMA.ActorModel.Starting.IServerInstanceActor, Task<DbConnectionStatus>>) (a => a.GetStatus())).GetAwaiter();
                            num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
                            continue;
                          case 7:
                            goto label_40;
                          case 8:
                            // ISSUE: explicit reference operation
                            // ISSUE: reference to a compiler-generated field
                            (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IReadOnlyDictionary<Guid, DbConnectionStatus>>, PublicationActor.\u003CStart\u003Ed__37>(ref awaiter2, this);
                            num5 = 5;
                            continue;
                          case 9:
                            // ISSUE: explicit reference operation
                            // ISSUE: reference to a compiler-generated field
                            (^this).\u003C\u003E1__state = num2 = 0;
                            num5 = 2;
                            continue;
                          case 10:
                            if (awaiter2.GetResult().Values.Contains<DbConnectionStatus>(DbConnectionStatus.Starting))
                            {
                              num5 = 7;
                              continue;
                            }
                            goto label_45;
                          default:
                            if (awaiter2.IsCompleted)
                              goto case 10;
                            else
                              goto label_38;
                        }
                      }
label_62:
                      return;
label_38:
                      num4 = 9;
                      goto label_26;
label_40:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      throw new InvalidOperationException((string) PublicationActor.\u003CStart\u003Ed__37.v90WMKZhQPQL4X5TCtSe(PublicationActor.\u003CStart\u003Ed__37.AxbLnRZhfwBDab6hs3qJ(132912447 ^ 132778487)));
label_29:
                      awaiter2 = taskAwaiter2;
                      num5 = 1;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
                      {
                        num5 = 1;
                        goto label_27;
                      }
                      else
                        goto label_27;
                    }
                    catch (Exception ex)
                    {
                      int num6 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
                        num6 = 0;
                      switch (num6)
                      {
                        default:
                          // ISSUE: reference to a compiler-generated method
                          throw new InvalidOperationException((string) PublicationActor.\u003CStart\u003Ed__37.v90WMKZhQPQL4X5TCtSe((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(87862435 ^ 87732637)), ex);
                      }
                    }
                  case 11:
                    taskAwaiter1 = awaiter1;
                    num3 = 12;
                    continue;
                  case 12:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, PublicationActor.\u003CStart\u003Ed__37>(ref awaiter1, this);
                    num3 = 8;
                    continue;
                  case 13:
                    goto label_5;
                  case 14:
                    if (num2 != 1)
                    {
                      num3 = 17;
                      continue;
                    }
                    goto case 7;
                  case 15:
                    headerIds1 = headerIds;
                    num3 = 4;
                    continue;
                  case 16:
                    result = publicationActor1.publicationToken.Value;
                    num3 = 13;
                    continue;
                  case 17:
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 2 : 2;
                    continue;
                  case 18:
                    taskAwaiter1 = new TaskAwaiter();
                    num3 = 20;
                    continue;
                  case 20:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 1 : 1;
                    continue;
                  case 21:
                    publicationActor1.assemblyModelsMetadataIds = (IDictionary<string, long>) new Dictionary<string, long>();
                    num3 = 22;
                    continue;
                  case 22:
                    // ISSUE: reference to a compiler-generated method
                    awaiter1 = PublicationActor.\u003CStart\u003Ed__37.CLwEKoZhvucyoM8WKEZ2((object) publicationActor1.RegisterOrUpdateReminder(publicationActor1.publicationToken.ToString(), TimeSpan.FromMinutes(1.0), TimeSpan.FromMinutes(1.0)));
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
                    continue;
                  case 23:
                    tag1 = tag;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 15 : 1;
                    continue;
                  case 24:
                    goto label_49;
                  case 25:
label_45:
                    // ISSUE: reference to a compiler-generated method
                    publicationActor1.publicationToken = new Guid?(PublicationActor.\u003CStart\u003Ed__37.QEnWeXZhCpZGbg4SMH6M());
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 3 : 21;
                    continue;
                  default:
                    if (awaiter1.IsCompleted)
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 13 : 19;
                      continue;
                    }
                    goto case 6;
                }
              }
label_58:
              return;
label_49:
              // ISSUE: reference to a compiler-generated method
              throw new InvalidOperationException(EleWise.ELMA.SR.T((string) PublicationActor.\u003CStart\u003Ed__37.AxbLnRZhfwBDab6hs3qJ(2008901894 << 3 ^ -1108519844)));
label_50:
              num3 = 10;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
              {
                num3 = 2;
                goto label_8;
              }
              else
                goto label_8;
            }
            catch (Exception ex)
            {
              int num7 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
                num7 = 0;
              while (true)
              {
                switch (num7)
                {
                  case 1:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 2 : 0;
                    continue;
                  case 2:
                    goto label_57;
                  default:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 1 : 1;
                    continue;
                }
              }
label_57:
              return;
            }
        }
label_5:
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        (^this).\u003C\u003E1__state = -2;
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 0 : 3;
      }
label_65:;
    }

    private Task StartInternal(string comment, string tag, long[] headerIds)
    {
      int num1 = 2;
      // ISSUE: variable of a compiler-generated type
      PublicationActor.\u003CStartInternal\u003Ed__38 stateMachine;
      while (true)
      {
        int num2 = num1;
        AsyncTaskMethodBuilder tBuilder;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_6;
            case 2:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003E4__this = this;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 1;
              continue;
            case 3:
              goto label_11;
            case 4:
              tBuilder.Start<PublicationActor.\u003CStartInternal\u003Ed__38>(ref stateMachine);
              num2 = 3;
              continue;
            case 5:
              // ISSUE: reference to a compiler-generated field
              stateMachine.tag = tag;
              num2 = 7;
              continue;
            case 6:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003Et__builder = PublicationActor.psnbbpfpdMlTuWb2vEQN();
              num2 = 8;
              continue;
            case 7:
              // ISSUE: reference to a compiler-generated field
              stateMachine.headerIds = headerIds;
              num2 = 6;
              continue;
            case 8:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003E1__state = -1;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
              continue;
            default:
              // ISSUE: reference to a compiler-generated field
              tBuilder = stateMachine.\u003C\u003Et__builder;
              num2 = 4;
              continue;
          }
        }
label_6:
        // ISSUE: reference to a compiler-generated field
        stateMachine.comment = comment;
        num1 = 5;
      }
label_11:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    /// <inheritdoc />
    public Task<bool> PublicationStarted()
    {
      if (this.publicationToken.HasValue)
        return Task.FromResult<bool>(true);
      this.DeactivateOnIdle();
      return Task.FromResult<bool>(false);
    }

    /// <inheritdoc />
    public Task Wait(Guid uid)
    {
      int num1 = 5;
      bool lockTaken;
      HashSet<Guid> guidSet;
      while (true)
      {
        switch (num1)
        {
          case 1:
            lockTaken = false;
            num1 = 9;
            continue;
          case 2:
            guidSet = this.waitRuntimeUpdateUids;
            num1 = 8;
            continue;
          case 3:
label_19:
            if (this.waitRuntimeUpdateUids == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
              continue;
            }
            goto case 2;
          case 4:
            guidSet = this.waitUids;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 1 : 0;
            continue;
          case 5:
            if (this.waitUids != null)
            {
              num1 = 4;
              continue;
            }
            goto case 3;
          case 6:
            goto label_21;
          case 8:
            lockTaken = false;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 6 : 4;
            continue;
          case 9:
            try
            {
              Monitor.Enter((object) guidSet, ref lockTaken);
              int num2 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
                num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    this.waitUids.Add(uid);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_19;
                }
              }
            }
            finally
            {
              if (lockTaken)
              {
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
                  num3 = 0;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_13;
                    default:
                      PublicationActor.ebFpZNfplMPVeUHOmAfQ((object) guidSet);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 1;
                      continue;
                  }
                }
              }
label_13:;
            }
          default:
            goto label_15;
        }
      }
label_15:
      return (Task) PublicationActor.CNhprlfpJR56VHcSvmc5();
label_21:
      try
      {
        Monitor.Enter((object) guidSet, ref lockTaken);
        int num4 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0)
          num4 = 1;
        while (true)
        {
          switch (num4)
          {
            case 1:
              this.waitRuntimeUpdateUids.Add(uid);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 0 : 0;
              continue;
            default:
              goto label_15;
          }
        }
      }
      finally
      {
        int num5;
        if (!lockTaken)
          num5 = 2;
        else
          goto label_28;
label_27:
        switch (num5)
        {
          case 1:
            break;
          default:
        }
label_28:
        Monitor.Exit((object) guidSet);
        num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
        {
          num5 = 0;
          goto label_27;
        }
        else
          goto label_27;
      }
    }

    /// <inheritdoc />
    public Task Complete(Guid сonnectionUid)
    {
      int num = 3;
      // ISSUE: variable of a compiler-generated type
      PublicationActor.\u003CComplete\u003Ed__41 stateMachine;
      AsyncTaskMethodBuilder tBuilder;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: reference to a compiler-generated field
            tBuilder = stateMachine.\u003C\u003Et__builder;
            num = 4;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            stateMachine.сonnectionUid = сonnectionUid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 4 : 6;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E4__this = this;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 2 : 0;
            continue;
          case 4:
            tBuilder.Start<PublicationActor.\u003CComplete\u003Ed__41>(ref stateMachine);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 5 : 1;
            continue;
          case 5:
            goto label_4;
          case 6:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003Et__builder = PublicationActor.psnbbpfpdMlTuWb2vEQN();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
            continue;
          default:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E1__state = -1;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 1 : 1;
            continue;
        }
      }
label_4:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    /// <inheritdoc />
    public Task RuntimeUpdated(Guid connectionUid)
    {
      int num = 5;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.waitRuntimeUpdateUids = (HashSet<Guid>) null;
            num = 6;
            continue;
          case 3:
            if (PublicationActor.I9mtQufprG1ZIiEFGDjx((object) this.waitRuntimeUpdateUids) == 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 1 : 1;
              continue;
            }
            goto label_6;
          case 4:
            this.waitRuntimeUpdateUids.Remove(connectionUid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 3 : 3;
            continue;
          case 5:
            if (this.waitRuntimeUpdateUids != null)
            {
              num = 4;
              continue;
            }
            goto label_6;
          case 6:
            TaskCompletionSource<bool> runtimeUpdateComplete = this.waitNodesRuntimeUpdateComplete;
            if (runtimeUpdateComplete == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 0;
              continue;
            }
            runtimeUpdateComplete.TrySetResult(true);
            num = 2;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      return (Task) PublicationActor.CNhprlfpJR56VHcSvmc5();
    }

    /// <inheritdoc />
    public Task Error(Exception exception)
    {
      int num = 4;
      // ISSUE: variable of a compiler-generated type
      PublicationActor.\u003CError\u003Ed__43 stateMachine;
      AsyncTaskMethodBuilder tBuilder;
      while (true)
      {
        switch (num)
        {
          case 1:
            tBuilder.Start<PublicationActor.\u003CError\u003Ed__43>(ref stateMachine);
            num = 5;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E1__state = -1;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 0;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            stateMachine.exception = exception;
            num = 6;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E4__this = this;
            num = 3;
            continue;
          case 5:
            goto label_4;
          case 6:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003Et__builder = AsyncTaskMethodBuilder.Create();
            num = 2;
            continue;
          default:
            // ISSUE: reference to a compiler-generated field
            tBuilder = stateMachine.\u003C\u003Et__builder;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 1 : 0;
            continue;
        }
      }
label_4:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    /// <summary>Сессия NHibernate</summary>
    [NotNull]
    private ISession Session => this.sessionProvider.Value.GetSession(string.Empty);

    /// <summary>Опубликовать текущую модель метаданных конфигурации</summary>
    /// <param name="publishData">Информация о списках публикуемых метаданных</param>
    /// <returns>Результат публикации и метаданные, требующие перезапуска</returns>
    private MetadataAssemblyPublishResult Publish(PublishData publishData)
    {
      int num1 = 24;
      MetadataAssemblyPublishResult assemblyPublishResult;
      while (true)
      {
        int num2 = num1;
        ICollection<IRootMetadata> source;
        AssemblyModelsMetadata assemblyModelsMetadata1;
        IList<ScriptModule> allScriptModules;
        PublishData publishData1;
        PublicationActor publicationActor;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 8:
            case 12:
              goto label_20;
            case 2:
              PublicationActor.oXM82FfaCjwug51Njp6Z((object) this.Session, (object) assemblyModelsMetadata1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 1 : 0;
              continue;
            case 3:
            case 4:
            case 5:
              if (source == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 6 : 7;
                continue;
              }
              goto case 13;
            case 6:
              publicationActor = this;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 10 : 5;
              continue;
            case 9:
              assemblyModelsMetadata1.SetMetadata(source.Cast<EleWise.ELMA.Model.Metadata.AbstractMetadata>().ToArray<EleWise.ELMA.Model.Metadata.AbstractMetadata>());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 2;
              continue;
            case 10:
              allScriptModules = ((ICriteria) PublicationActor.BWUctNfpUUKqdQryZKgd((object) this.Session.CreateCriteria<ScriptModule>(), PublicationActor.LisvgmfpLq15lOyOspvO(PublicationActor.BaDoFSfp0Y3o0kH3tZnG(1033719030 - 2012070891 ^ -978384811), PublicationActor.FabUvKfpYg1HkGAAmjoU(PublicationActor.jwoNeGfp5hxmvpXWdOrm(PublicationActor.T1BBLIfpgXNoReaASXEi(InterfaceActivator.TypeOf<IMetadataItemHeader>()), PublicationActor.BaDoFSfp0Y3o0kH3tZnG(-1872275253 >> 6 ^ -29105159), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420568172)), PublicationActor.iN5TgdfpjiDJqHotjxFy((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -881949270)))))).List<ScriptModule>();
              num2 = 19;
              continue;
            case 11:
              if (assemblyModelsMetadata1 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 16 : 14;
                continue;
              }
              goto case 17;
            case 13:
              if (PublicationActor.SpvmekfaQnJVlSiTbEj7((object) source) > 0)
              {
                num2 = 9;
                continue;
              }
              goto default;
            case 14:
              source = (ICollection<IRootMetadata>) publishData1.RestartNeededMetadata.Values;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 5 : 1;
              continue;
            case 15:
              source = (ICollection<IRootMetadata>) null;
              num2 = 11;
              continue;
            case 16:
            case 20:
              if (PublicationActor.gVm3UAfaGxV9ObDjq591((object) publishData1.RestartNeededMetadata) <= 0)
              {
                num2 = 4;
                continue;
              }
              goto case 18;
            case 17:
              HashSet<IRootMetadata> hashSet = ((IEnumerable) PublicationActor.maOl3efahXEcsF5riZAa((object) assemblyModelsMetadata1)).Cast<IRootMetadata>().ToHashSet<IRootMetadata>(RootMetadataComparer.Instance);
              hashSet.UnionWith((IEnumerable<IRootMetadata>) publishData1.RestartNeededMetadata.Values);
              hashSet.ExceptWith((IEnumerable<IRootMetadata>) publishData1.SoftPublishedMetadata.Values);
              hashSet.ExceptWith((IEnumerable<IRootMetadata>) publishData1.DeltaPublishedMetadata.Values);
              source = (ICollection<IRootMetadata>) hashSet;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 3 : 3;
              continue;
            case 18:
              AssemblyModelsMetadata assemblyModelsMetadata2 = new AssemblyModelsMetadata();
              PublicationActor.DcFPHEfaEXoe1oSG4xMI((object) assemblyModelsMetadata2, PublicationActor.BaDoFSfp0Y3o0kH3tZnG(-345420348 ^ -345421920));
              PublicationActor.uDKBdufafsG201uFbbgq((object) assemblyModelsMetadata2, AssemblyModelsMetadataStatus.Prepared);
              assemblyModelsMetadata1 = assemblyModelsMetadata2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 1 : 14;
              continue;
            case 19:
              // ISSUE: reference to a compiler-generated method
              assemblyPublishResult = ConfigurationModelAssemblyBuilder.Publish(publishData1.MetadataItems.Where<IMetadataItem>((System.Func<IMetadataItem, bool>) (mi => !publishData1.RestartNeededMetadata.ContainsKey(PublicationActor.\u003C\u003Ec__DisplayClass46_0.sUo5FDZGKoAnHMF5povd((object) (EleWise.ELMA.Model.Metadata.AbstractMetadata) mi.Metadata)))), (Func<string, AssemblyModelsMetadataStatus, AssemblyModelsMetadata>) ((assemblyName, status) =>
              {
                int num3 = 3;
                object[] objArray;
                // ISSUE: variable of a compiler-generated type
                PublicationActor.\u003C\u003Ec__DisplayClass46_1 cDisplayClass461;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_5;
                    case 2:
                      // ISSUE: reference to a compiler-generated field
                      cDisplayClass461.assemblyName = assemblyName;
                      num3 = 6;
                      continue;
                    case 3:
                      // ISSUE: object of a compiler-generated type is created
                      cDisplayClass461 = new PublicationActor.\u003C\u003Ec__DisplayClass46_1();
                      num3 = 2;
                      continue;
                    case 4:
                      if (objArray != null)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 0;
                        continue;
                      }
                      goto label_5;
                    case 5:
                      IQueryOver<AssemblyModelsMetadata, AssemblyModelsMetadata> queryOver1 = publicationActor.Session.QueryOver<AssemblyModelsMetadata>();
                      // ISSUE: type reference
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      ParameterExpression parameterExpression1 = (ParameterExpression) PublicationActor.\u003C\u003Ec__DisplayClass46_0.ARTROAZGkbnXRtROwrJi(PublicationActor.\u003C\u003Ec__DisplayClass46_0.VbJRylZGXLiSj3DvRvE6(__typeref (AssemblyModelsMetadata)), PublicationActor.\u003C\u003Ec__DisplayClass46_0.EfEG2AZGT1mNgrPGWPlo(-53329496 >> 4 ^ -3149936));
                      // ISSUE: method reference
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: type reference
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: field reference
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: method reference
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: type reference
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: field reference
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: type reference
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      Expression<System.Func<AssemblyModelsMetadata, bool>> expression = System.Linq.Expressions.Expression.Lambda<System.Func<AssemblyModelsMetadata, bool>>((System.Linq.Expressions.Expression) PublicationActor.\u003C\u003Ec__DisplayClass46_0.U0W2HmZGN5fFcET5He7t(PublicationActor.\u003C\u003Ec__DisplayClass46_0.koKHeZZGeOSEj0YwIeDp(PublicationActor.\u003C\u003Ec__DisplayClass46_0.xI0AwdZGORIkLUYFHugV((object) parameterExpression1, (object) (MethodInfo) PublicationActor.\u003C\u003Ec__DisplayClass46_0.LbOvhvZGnnDHXgOyajEY(__methodref (AssemblyModelsMetadata.get_Name))), PublicationActor.\u003C\u003Ec__DisplayClass46_0.UBvy1xZG2mBPPNJuvKQc((object) System.Linq.Expressions.Expression.Constant((object) cDisplayClass461, PublicationActor.\u003C\u003Ec__DisplayClass46_0.VbJRylZGXLiSj3DvRvE6(__typeref (PublicationActor.\u003C\u003Ec__DisplayClass46_1))), (object) FieldInfo.GetFieldFromHandle(__fieldref (PublicationActor.\u003C\u003Ec__DisplayClass46_1.assemblyName)))), PublicationActor.\u003C\u003Ec__DisplayClass46_0.koKHeZZGeOSEj0YwIeDp(PublicationActor.\u003C\u003Ec__DisplayClass46_0.ybOxu0ZGP7oUlbDKKCQC(PublicationActor.\u003C\u003Ec__DisplayClass46_0.xI0AwdZGORIkLUYFHugV((object) parameterExpression1, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (AssemblyModelsMetadata.get_Status))), PublicationActor.\u003C\u003Ec__DisplayClass46_0.VbJRylZGXLiSj3DvRvE6(__typeref (int))), PublicationActor.\u003C\u003Ec__DisplayClass46_0.ybOxu0ZGP7oUlbDKKCQC(PublicationActor.\u003C\u003Ec__DisplayClass46_0.UBvy1xZG2mBPPNJuvKQc((object) System.Linq.Expressions.Expression.Constant((object) cDisplayClass461, typeof (PublicationActor.\u003C\u003Ec__DisplayClass46_1)), PublicationActor.\u003C\u003Ec__DisplayClass46_0.WQOYimZG1jnK3x3R0e4Y(__fieldref (PublicationActor.\u003C\u003Ec__DisplayClass46_1.status))), PublicationActor.\u003C\u003Ec__DisplayClass46_0.VbJRylZGXLiSj3DvRvE6(__typeref (int))))), parameterExpression1);
                      IQueryOver<AssemblyModelsMetadata, AssemblyModelsMetadata> queryOver2 = queryOver1.Where(expression);
                      Expression<System.Func<AssemblyModelsMetadata, object>>[] expressionArray = new Expression<System.Func<AssemblyModelsMetadata, object>>[3];
                      // ISSUE: type reference
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      ParameterExpression parameterExpression2 = (ParameterExpression) PublicationActor.\u003C\u003Ec__DisplayClass46_0.ARTROAZGkbnXRtROwrJi(PublicationActor.\u003C\u003Ec__DisplayClass46_0.VbJRylZGXLiSj3DvRvE6(__typeref (AssemblyModelsMetadata)), PublicationActor.\u003C\u003Ec__DisplayClass46_0.EfEG2AZGT1mNgrPGWPlo(-1638402543 ^ -1638580837));
                      // ISSUE: method reference
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      expressionArray[0] = System.Linq.Expressions.Expression.Lambda<System.Func<AssemblyModelsMetadata, object>>((System.Linq.Expressions.Expression) PublicationActor.\u003C\u003Ec__DisplayClass46_0.ybOxu0ZGP7oUlbDKKCQC(PublicationActor.\u003C\u003Ec__DisplayClass46_0.xI0AwdZGORIkLUYFHugV((object) parameterExpression2, (object) (MethodInfo) PublicationActor.\u003C\u003Ec__DisplayClass46_0.LbOvhvZGnnDHXgOyajEY(__methodref (AssemblyModelsMetadata.get_Id))), typeof (object)), parameterExpression2);
                      // ISSUE: type reference
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      ParameterExpression parameterExpression3 = (ParameterExpression) PublicationActor.\u003C\u003Ec__DisplayClass46_0.ARTROAZGkbnXRtROwrJi(PublicationActor.\u003C\u003Ec__DisplayClass46_0.VbJRylZGXLiSj3DvRvE6(__typeref (AssemblyModelsMetadata)), PublicationActor.\u003C\u003Ec__DisplayClass46_0.EfEG2AZGT1mNgrPGWPlo(-1710575414 ^ -1710720192));
                      // ISSUE: method reference
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      expressionArray[1] = System.Linq.Expressions.Expression.Lambda<System.Func<AssemblyModelsMetadata, object>>((System.Linq.Expressions.Expression) PublicationActor.\u003C\u003Ec__DisplayClass46_0.xI0AwdZGORIkLUYFHugV((object) parameterExpression3, (object) (MethodInfo) PublicationActor.\u003C\u003Ec__DisplayClass46_0.LbOvhvZGnnDHXgOyajEY(__methodref (AssemblyModelsMetadata.get_Name))), parameterExpression3);
                      // ISSUE: type reference
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      ParameterExpression parameterExpression4 = (ParameterExpression) PublicationActor.\u003C\u003Ec__DisplayClass46_0.ARTROAZGkbnXRtROwrJi(PublicationActor.\u003C\u003Ec__DisplayClass46_0.VbJRylZGXLiSj3DvRvE6(__typeref (AssemblyModelsMetadata)), PublicationActor.\u003C\u003Ec__DisplayClass46_0.EfEG2AZGT1mNgrPGWPlo(1113862659 ^ 1114044809));
                      // ISSUE: method reference
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: type reference
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      expressionArray[2] = System.Linq.Expressions.Expression.Lambda<System.Func<AssemblyModelsMetadata, object>>((System.Linq.Expressions.Expression) PublicationActor.\u003C\u003Ec__DisplayClass46_0.ybOxu0ZGP7oUlbDKKCQC(PublicationActor.\u003C\u003Ec__DisplayClass46_0.xI0AwdZGORIkLUYFHugV((object) parameterExpression4, (object) (MethodInfo) PublicationActor.\u003C\u003Ec__DisplayClass46_0.LbOvhvZGnnDHXgOyajEY(__methodref (AssemblyModelsMetadata.get_Status))), PublicationActor.\u003C\u003Ec__DisplayClass46_0.VbJRylZGXLiSj3DvRvE6(__typeref (object))), parameterExpression4);
                      objArray = queryOver2.Select(expressionArray).Take(1).SingleOrDefault<object[]>();
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 4 : 1;
                      continue;
                    case 6:
                      // ISSUE: reference to a compiler-generated field
                      cDisplayClass461.status = status;
                      num3 = 5;
                      continue;
                    default:
                      goto label_6;
                  }
                }
label_5:
                return (AssemblyModelsMetadata) null;
label_6:
                AssemblyModelsMetadata assemblyModelsMetadata3 = new AssemblyModelsMetadata();
                // ISSUE: reference to a compiler-generated method
                PublicationActor.\u003C\u003Ec__DisplayClass46_0.H9XTmXZG3ruvIxQxHTqQ((object) assemblyModelsMetadata3, (long) objArray[0]);
                // ISSUE: reference to a compiler-generated method
                PublicationActor.\u003C\u003Ec__DisplayClass46_0.JR9oErZGpQZSqggdbii4((object) assemblyModelsMetadata3, (object) (string) objArray[1]);
                assemblyModelsMetadata3.Status = (AssemblyModelsMetadataStatus) objArray[2];
                return assemblyModelsMetadata3;
              }), (Action<AssemblyModelsMetadata>) (assembly =>
              {
                int num4 = 3;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      goto label_2;
                    case 2:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      publicationActor.assemblyModelsMetadataIds[(string) PublicationActor.\u003C\u003Ec__DisplayClass46_0.kKsfZ3ZGtke7Rp2g7nvl((object) assembly)] = (long) PublicationActor.\u003C\u003Ec__DisplayClass46_0.OF1dINZGw59fsWh49bnK((object) publicationActor.Session, (object) assembly);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 1 : 1;
                      continue;
                    case 3:
                      // ISSUE: reference to a compiler-generated method
                      if (PublicationActor.\u003C\u003Ec__DisplayClass46_0.hqV5Q7ZGa1cCC8ikCFsj((object) assembly) == 0L)
                      {
                        num4 = 2;
                        continue;
                      }
                      goto case 4;
                    case 4:
                      // ISSUE: reference to a compiler-generated method
                      PublicationActor.\u003C\u003Ec__DisplayClass46_0.vgEWdlZGDbfNeErS10mT((object) publicationActor.Session, (object) assembly);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
                      continue;
                    case 5:
                      goto label_8;
                    default:
                      // ISSUE: reference to a compiler-generated method
                      publicationActor.assemblyModelsMetadataIds[assembly.Name] = PublicationActor.\u003C\u003Ec__DisplayClass46_0.hqV5Q7ZGa1cCC8ikCFsj((object) assembly);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 2 : 5;
                      continue;
                  }
                }
label_2:
                return;
label_8:;
              }), this.metadataRuntimeService.Value, this.modelAssemblyBuilderHandler.Value, this.publishedMetadata.OfType<EleWise.ELMA.Model.Metadata.AbstractMetadata>(), allScriptModules, false, !PublicationActor.JBybaTfpsjpmgMWHCVOe((object) publishData1), true, PublicationActor.nZOJpmfpylYSIoU5LJpP((object) this.dynamicPublicationService));
              num2 = 21;
              continue;
            case 21:
              if (this.dynamicPublicationService.Enable)
              {
                num2 = 25;
                continue;
              }
              goto label_20;
            case 22:
              PublicationActor.bHdOpJfavdcOkdeZTSxl((object) this.Session, (object) assemblyModelsMetadata1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 12 : 6;
              continue;
            case 23:
              publishData1 = publishData;
              num2 = 6;
              continue;
            case 24:
              num2 = 23;
              continue;
            case 25:
              IQueryOver<AssemblyModelsMetadata, AssemblyModelsMetadata> queryOver = this.Session.QueryOver<AssemblyModelsMetadata>();
              // ISSUE: type reference
              ParameterExpression parameterExpression = (ParameterExpression) PublicationActor.Pv0bQOfpzl4niI4MiJNP(PublicationActor.MRbA6EfpcFOKsJVdGjQm(__typeref (AssemblyModelsMetadata)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1994213607 >> 4 ^ 124722948));
              // ISSUE: method reference
              // ISSUE: type reference
              // ISSUE: method reference
              // ISSUE: type reference
              // ISSUE: type reference
              Expression<System.Func<AssemblyModelsMetadata, bool>> expression1 = System.Linq.Expressions.Expression.Lambda<System.Func<AssemblyModelsMetadata, bool>>((System.Linq.Expressions.Expression) PublicationActor.Tqmexlfab8g14GIlrp8e(PublicationActor.QcZEC1faBJW0El6bmCZf((object) System.Linq.Expressions.Expression.Property((System.Linq.Expressions.Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (AssemblyModelsMetadata.get_Name))), PublicationActor.vGqWd4faFfls9kCe1Im9(PublicationActor.BaDoFSfp0Y3o0kH3tZnG(647913418 ^ 647910830), PublicationActor.MRbA6EfpcFOKsJVdGjQm(__typeref (string)))), PublicationActor.QcZEC1faBJW0El6bmCZf((object) System.Linq.Expressions.Expression.Convert((System.Linq.Expressions.Expression) PublicationActor.qmpQGGfaotI2jqJplgTn((object) parameterExpression, (object) (MethodInfo) PublicationActor.jJ5K2XfaWLEAyb916ZKG(__methodref (AssemblyModelsMetadata.get_Status))), PublicationActor.MRbA6EfpcFOKsJVdGjQm(__typeref (int))), PublicationActor.vGqWd4faFfls9kCe1Im9((object) 2, PublicationActor.MRbA6EfpcFOKsJVdGjQm(__typeref (int))))), parameterExpression);
              assemblyModelsMetadata1 = queryOver.Where(expression1).Take(1).SingleOrDefault();
              num2 = 15;
              continue;
            default:
              if (assemblyModelsMetadata1 != null)
                goto case 22;
              else
                goto label_12;
          }
        }
label_12:
        num1 = 8;
      }
label_20:
      return assemblyPublishResult;
    }

    private static List<ValidationError> ValidateMetadataItem(
      object item,
      IEnumerable<IMetadata> extendMetadata)
    {
      List<ValidationError> validationErrorList = new List<ValidationError>();
      if ((((IMetadataItem) item).Metadata is EntityMetadata metadata ? metadata.ViewModelMetadata : (DataClassMetadata) null) == null)
        return validationErrorList;
      using (MetadataServiceContext.Extend(extendMetadata))
      {
        foreach (FormViewItem form in metadata.Forms)
          validationErrorList.AddRange(CheckComponentHelper.CheckComponentViewItems(form, metadata.ViewModelMetadata.Uid, metadata));
      }
      return validationErrorList;
    }

    /// <summary>
    /// Проверка связей дельта-публикуемых метаданных с метаданными, требующих перезагрузки
    /// </summary>
    /// <param name="publishData">Информация о списках публикуемых метаданных</param>
    internal static void ValidateMetadataReferences(PublishData publishData)
    {
      int num1 = 12;
      ValidationError[] validationErrors;
      IEnumerable<EntityMetadata> source1;
      while (true)
      {
        int num2 = num1;
        List<EntityMetadata> list;
        Dictionary<Guid, IRootMetadata>.Enumerator enumerator1;
        List<ValidationError> validationErrorList;
        IEnumerator<EntityMetadata> enumerator2;
        Dictionary<Guid, IRootMetadata> dictionary;
        Dictionary<Guid, IRootMetadata> tempMetadataList1;
        Dictionary<Guid, IRootMetadata> publishExtensionsMetadataList1;
        PublishData publishData1;
        Dictionary<Guid, IRootMetadata> tempMetadataList2;
        Dictionary<Guid, IRootMetadata> publishExtensionsMetadataList2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              tempMetadataList2 = new Dictionary<Guid, IRootMetadata>((IDictionary<Guid, IRootMetadata>) dictionary);
              num2 = 26;
              continue;
            case 2:
              try
              {
label_109:
                if (enumerator1.MoveNext())
                  goto label_114;
                else
                  goto label_110;
label_105:
                KeyValuePair<Guid, IRootMetadata> current;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      if (!(current.Value is EntityMetadata entityMetadata))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 5 : 5;
                        continue;
                      }
                      goto case 6;
                    case 2:
                      publishExtensionsMetadataList2[PublicationActor.atZvhUfauvh9Gx7MeNyc((object) entityMetadata)] = current.Value;
                      num3 = 3;
                      continue;
                    case 3:
                    case 5:
                      IEnumerable<TablePartMetadata> tablePartMetadata = PublicationActor.GetRecursiveTablePartMetadata((object) current.Value);
                      Action<TablePartMetadata> action;
                      Action<TablePartMetadata> action2 = action;
                      Action<TablePartMetadata> action3 = action2 == null ? (action = (Action<TablePartMetadata>) (tablePart =>
                      {
                        int num4 = 1;
                        while (true)
                        {
                          switch (num4)
                          {
                            case 0:
                              goto label_2;
                            case 1:
                              tempMetadataList2[tablePart.Uid] = (IRootMetadata) tablePart;
                              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 0 : 0;
                              continue;
                            default:
                              goto label_4;
                          }
                        }
label_2:
                        return;
label_4:;
                      })) : action2;
                      tablePartMetadata.ForEach<TablePartMetadata>(action3);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
                      continue;
                    case 4:
                      goto label_76;
                    case 6:
                      if (PublicationActor.JxMDCnfaZexqZ3ZpjMAJ((object) entityMetadata) == EntityMetadataType.InterfaceExtension)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 2 : 2;
                        continue;
                      }
                      goto case 3;
                    case 7:
                      tempMetadataList2[current.Key] = current.Value;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 1 : 1;
                      continue;
                    case 8:
                      goto label_114;
                    default:
                      goto label_109;
                  }
                }
label_110:
                num3 = 4;
                goto label_105;
label_114:
                current = enumerator1.Current;
                num3 = 6;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
                {
                  num3 = 7;
                  goto label_105;
                }
                else
                  goto label_105;
              }
              finally
              {
                enumerator1.Dispose();
                int num5 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
                  num5 = 0;
                switch (num5)
                {
                  default:
                }
              }
            case 3:
              enumerator1 = publishData1.SoftPublishedMetadata.GetEnumerator();
              num2 = 9;
              continue;
            case 4:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 7 : 3;
              continue;
            case 5:
              if (source1.Any<EntityMetadata>())
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 4 : 28;
                continue;
              }
              goto label_133;
            case 6:
label_121:
              list = publishData1.DeltaPublishedMetadata.Values.OfType<EntityMetadata>().Where<EntityMetadata>((System.Func<EntityMetadata, bool>) (m => PublicationActor.ValidateMetadataReferences((object) m, (IDictionary<Guid, IRootMetadata>) tempMetadataList2, (IDictionary<Guid, IRootMetadata>) publishExtensionsMetadataList2).Any<ValidationError>())).ToList<EntityMetadata>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 12 : 21;
              continue;
            case 7:
              tempMetadataList1 = new Dictionary<Guid, IRootMetadata>((IDictionary<Guid, IRootMetadata>) dictionary);
              num2 = 15;
              continue;
            case 8:
label_124:
              if (PublicationActor.Qci5cSfaIvImRXfnasdn((object) validationErrorList) <= 0)
              {
                source1 = publishData1.DeltaPublishedMetadata.Values.OfType<EntityMetadata>().Where<EntityMetadata>((System.Func<EntityMetadata, bool>) (m => PublicationActor.ValidateMetadataReferences((object) m, (IDictionary<Guid, IRootMetadata>) tempMetadataList1, (IDictionary<Guid, IRootMetadata>) publishExtensionsMetadataList1).Any<ValidationError>()));
                num2 = 5;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 20 : 4;
              continue;
            case 9:
              try
              {
label_9:
                if (enumerator1.MoveNext())
                  goto label_16;
                else
                  goto label_10;
label_8:
                KeyValuePair<Guid, IRootMetadata> current;
                int num6;
                while (true)
                {
                  switch (num6)
                  {
                    case 1:
                    case 2:
                      PublicationActor.GetRecursiveTablePartMetadata((object) current.Value).ForEach<TablePartMetadata>((Action<TablePartMetadata>) (tablePart =>
                      {
                        int num7 = 1;
                        while (true)
                        {
                          switch (num7)
                          {
                            case 0:
                              goto label_2;
                            case 1:
                              tempMetadataList1[tablePart.Uid] = (IRootMetadata) tablePart;
                              num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
                              continue;
                            default:
                              goto label_4;
                          }
                        }
label_2:
                        return;
label_4:;
                      }));
                      num6 = 5;
                      continue;
                    case 3:
                      if (!(current.Value is EntityMetadata entityMetadata))
                      {
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 1 : 2;
                        continue;
                      }
                      goto case 6;
                    case 4:
                      publishExtensionsMetadataList1[PublicationActor.atZvhUfauvh9Gx7MeNyc((object) entityMetadata)] = current.Value;
                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 1 : 1;
                      continue;
                    case 5:
                      goto label_9;
                    case 6:
                      if (PublicationActor.JxMDCnfaZexqZ3ZpjMAJ((object) entityMetadata) == EntityMetadataType.InterfaceExtension)
                      {
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 4;
                        continue;
                      }
                      goto case 1;
                    case 7:
                      tempMetadataList1[current.Key] = current.Value;
                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 3 : 3;
                      continue;
                    case 8:
                      goto label_56;
                    default:
                      goto label_16;
                  }
                }
label_10:
                num6 = 8;
                goto label_8;
label_16:
                current = enumerator1.Current;
                num6 = 7;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
                {
                  num6 = 7;
                  goto label_8;
                }
                else
                  goto label_8;
              }
              finally
              {
                enumerator1.Dispose();
                int num8 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
                  num8 = 0;
                switch (num8)
                {
                  default:
                }
              }
            case 10:
label_97:
              enumerator1 = publishData1.RestartNeededMetadata.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 19 : 25;
              continue;
            case 11:
              publishData1 = publishData;
              num2 = 22;
              continue;
            case 12:
              num2 = 11;
              continue;
            case 13:
label_76:
              enumerator1 = publishData1.DeltaPublishedMetadata.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
              continue;
            case 14:
              try
              {
label_27:
                if (enumerator2.MoveNext())
                  goto label_29;
                else
                  goto label_28;
label_25:
                EntityMetadata current;
                int num9;
                while (true)
                {
                  switch (num9)
                  {
                    case 1:
                      goto label_124;
                    case 2:
                      validationErrorList.AddRange(PublicationActor.ValidateMetadataReferences((object) current, (IDictionary<Guid, IRootMetadata>) tempMetadataList1, (IDictionary<Guid, IRootMetadata>) publishExtensionsMetadataList1));
                      num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
                      continue;
                    case 3:
                      goto label_29;
                    default:
                      goto label_27;
                  }
                }
label_28:
                num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 1 : 0;
                goto label_25;
label_29:
                current = enumerator2.Current;
                num9 = 2;
                goto label_25;
              }
              finally
              {
                if (enumerator2 != null)
                {
                  int num10 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
                    num10 = 1;
                  while (true)
                  {
                    switch (num10)
                    {
                      case 1:
                        PublicationActor.NbhRh4fp9pcZgJLHtPab((object) enumerator2);
                        num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_35;
                    }
                  }
                }
label_35:;
              }
            case 15:
              publishExtensionsMetadataList1 = new Dictionary<Guid, IRootMetadata>();
              num2 = 3;
              continue;
            case 16:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 1 : 0;
              continue;
            case 17:
label_56:
              enumerator1 = publishData1.DeltaPublishedMetadata.GetEnumerator();
              num2 = 23;
              continue;
            case 18:
              if (publishData1.RestartNeededMetadata.Count > 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 4 : 0;
                continue;
              }
              goto label_135;
            case 19:
              goto label_100;
            case 20:
              validationErrors = (ValidationError[]) PublicationActor.sUTohXfaVZMup1qONDks((object) validationErrorList);
              num2 = 19;
              continue;
            case 21:
              goto label_132;
            case 22:
              IEnumerable<IRootMetadata> source2 = ((IMetadataService) PublicationActor.S0v839fa8E74PcnDqO2c()).GetMetadataList().OfType<IRootMetadata>();
              // ISSUE: reference to a compiler-generated field
              System.Func<IRootMetadata, Guid> func = PublicationActor.\u003C\u003Ec.\u003C\u003E9__48_0;
              System.Func<IRootMetadata, Guid> keySelector;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                PublicationActor.\u003C\u003Ec.\u003C\u003E9__48_0 = keySelector = (System.Func<IRootMetadata, Guid>) (m => PublicationActor.\u003C\u003Ec.vtjCHZZbzL3q8S9hb7I3((object) m));
              }
              else
                goto label_138;
label_131:
              dictionary = source2.ToDictionary<IRootMetadata, Guid>(keySelector);
              num2 = 16;
              continue;
label_138:
              keySelector = func;
              goto label_131;
            case 23:
              try
              {
label_61:
                if (enumerator1.MoveNext())
                  goto label_65;
                else
                  goto label_62;
label_59:
                KeyValuePair<Guid, IRootMetadata> current;
                int num11;
                while (true)
                {
                  switch (num11)
                  {
                    case 1:
                      IEnumerable<TablePartMetadata> tablePartMetadata = PublicationActor.GetRecursiveTablePartMetadata((object) current.Value);
                      Action<TablePartMetadata> action;
                      Action<TablePartMetadata> action4 = action;
                      Action<TablePartMetadata> action5 = action4 == null ? (action = (Action<TablePartMetadata>) (tablePart =>
                      {
                        int num12 = 1;
                        while (true)
                        {
                          switch (num12)
                          {
                            case 0:
                              goto label_2;
                            case 1:
                              // ISSUE: reference to a compiler-generated method
                              tempMetadataList1[PublicationActor.\u003C\u003Ec__DisplayClass48_2.IgjMjtZGYfT1gic2PDem((object) tablePart)] = (IRootMetadata) tablePart;
                              num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
                              continue;
                            default:
                              goto label_4;
                          }
                        }
label_2:
                        return;
label_4:;
                      })) : action4;
                      tablePartMetadata.ForEach<TablePartMetadata>(action5);
                      num11 = 2;
                      continue;
                    case 2:
                      goto label_61;
                    case 3:
                      tempMetadataList1[current.Key] = current.Value;
                      num11 = 5;
                      continue;
                    case 4:
                      publishExtensionsMetadataList1[PublicationActor.atZvhUfauvh9Gx7MeNyc((object) entityMetadata)] = current.Value;
                      num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 1;
                      continue;
                    case 5:
                      if (current.Value is EntityMetadata entityMetadata)
                      {
                        num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
                        continue;
                      }
                      goto case 1;
                    case 6:
                      goto label_97;
                    case 7:
                      goto label_65;
                    default:
                      if (PublicationActor.JxMDCnfaZexqZ3ZpjMAJ((object) entityMetadata) == EntityMetadataType.InterfaceExtension)
                      {
                        num11 = 4;
                        continue;
                      }
                      goto case 1;
                  }
                }
label_62:
                num11 = 6;
                goto label_59;
label_65:
                current = enumerator1.Current;
                num11 = 3;
                goto label_59;
              }
              finally
              {
                enumerator1.Dispose();
                int num13 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
                  num13 = 0;
                switch (num13)
                {
                  default:
                }
              }
            case 24:
label_126:
              validationErrorList = new List<ValidationError>();
              num2 = 27;
              continue;
            case 25:
              try
              {
label_44:
                if (enumerator1.MoveNext())
                  goto label_40;
                else
                  goto label_45;
label_38:
                int num14;
                int num15 = num14;
label_39:
                KeyValuePair<Guid, IRootMetadata> current;
                while (true)
                {
                  switch (num15)
                  {
                    case 1:
                    case 3:
                      PublicationActor.GetRecursiveTablePartMetadata((object) current.Value).ForEach<TablePartMetadata>((Action<TablePartMetadata>) (tablePart =>
                      {
                        int num16 = 1;
                        while (true)
                        {
                          switch (num16)
                          {
                            case 0:
                              goto label_2;
                            case 1:
                              // ISSUE: reference to a compiler-generated method
                              tempMetadataList1[PublicationActor.\u003C\u003Ec__DisplayClass48_2.IgjMjtZGYfT1gic2PDem((object) tablePart)] = (IRootMetadata) tablePart;
                              num16 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
                              continue;
                            default:
                              goto label_4;
                          }
                        }
label_2:
                        return;
label_4:;
                      }));
                      num15 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 5;
                      continue;
                    case 2:
                      goto label_40;
                    case 4:
                      if (PublicationActor.JxMDCnfaZexqZ3ZpjMAJ((object) entityMetadata) == EntityMetadataType.InterfaceExtension)
                      {
                        num15 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
                        continue;
                      }
                      goto case 1;
                    case 5:
                      goto label_44;
                    case 6:
                      goto label_126;
                    case 7:
                      goto label_46;
                    case 8:
                      if (!(current.Value is EntityMetadata entityMetadata))
                      {
                        num15 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 1 : 1;
                        continue;
                      }
                      goto case 4;
                    default:
                      publishExtensionsMetadataList1[entityMetadata.BaseClassUid] = current.Value;
                      num15 = 3;
                      continue;
                  }
                }
label_46:
                tempMetadataList1[current.Key] = current.Value;
                num14 = 8;
                goto label_38;
label_40:
                current = enumerator1.Current;
                num15 = 7;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
                {
                  num15 = 1;
                  goto label_39;
                }
                else
                  goto label_39;
label_45:
                num14 = 6;
                goto label_38;
              }
              finally
              {
                enumerator1.Dispose();
                int num17 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
                  num17 = 0;
                switch (num17)
                {
                  default:
                }
              }
            case 26:
              publishExtensionsMetadataList2 = new Dictionary<Guid, IRootMetadata>();
              num2 = 29;
              continue;
            case 27:
              enumerator2 = publishData1.RestartNeededMetadata.Values.OfType<EntityMetadata>().GetEnumerator();
              num2 = 14;
              continue;
            case 28:
              goto label_134;
            case 29:
              enumerator1 = publishData1.SoftPublishedMetadata.GetEnumerator();
              num2 = 2;
              continue;
            case 30:
              if (list.Count <= 0)
              {
                num2 = 18;
                continue;
              }
              goto case 16;
            default:
              try
              {
label_82:
                if (enumerator1.MoveNext())
                  goto label_89;
                else
                  goto label_83;
label_80:
                KeyValuePair<Guid, IRootMetadata> current;
                int num18;
                while (true)
                {
                  int num19;
                  switch (num18)
                  {
                    case 1:
                      tempMetadataList2[current.Key] = current.Value;
                      num18 = 3;
                      continue;
                    case 2:
                      goto label_121;
                    case 3:
                      if (current.Value is EntityMetadata entityMetadata)
                      {
                        num18 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
                        continue;
                      }
                      goto case 6;
                    case 4:
                      publishExtensionsMetadataList2[PublicationActor.atZvhUfauvh9Gx7MeNyc((object) entityMetadata)] = current.Value;
                      num18 = 6;
                      continue;
                    case 5:
                      goto label_82;
                    case 6:
                      IEnumerable<TablePartMetadata> tablePartMetadata = PublicationActor.GetRecursiveTablePartMetadata((object) current.Value);
                      Action<TablePartMetadata> action;
                      Action<TablePartMetadata> action6 = action;
                      Action<TablePartMetadata> action7 = action6 == null ? (action = (Action<TablePartMetadata>) (tablePart =>
                      {
                        int num20 = 1;
                        while (true)
                        {
                          switch (num20)
                          {
                            case 0:
                              goto label_2;
                            case 1:
                              // ISSUE: reference to a compiler-generated method
                              tempMetadataList2[PublicationActor.\u003C\u003Ec__DisplayClass48_1.aXue5aZGlqqYwnDF9tsB((object) tablePart)] = (IRootMetadata) tablePart;
                              num20 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
                              continue;
                            default:
                              goto label_4;
                          }
                        }
label_2:
                        return;
label_4:;
                      })) : action6;
                      tablePartMetadata.ForEach<TablePartMetadata>(action7);
                      num19 = 5;
                      break;
                    case 7:
                      goto label_89;
                    default:
                      if (PublicationActor.JxMDCnfaZexqZ3ZpjMAJ((object) entityMetadata) == EntityMetadataType.InterfaceExtension)
                      {
                        num19 = 4;
                        break;
                      }
                      goto case 6;
                  }
                  num18 = num19;
                }
label_83:
                num18 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 2 : 2;
                goto label_80;
label_89:
                current = enumerator1.Current;
                num18 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
                {
                  num18 = 1;
                  goto label_80;
                }
                else
                  goto label_80;
              }
              finally
              {
                enumerator1.Dispose();
                int num21 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
                  num21 = 0;
                switch (num21)
                {
                  default:
                }
              }
          }
        }
label_132:
        List<EntityMetadata> entityMetadataList = list;
        Action<EntityMetadata> action1;
        Action<EntityMetadata> action8 = action1;
        Action<EntityMetadata> action9 = action8 == null ? (action1 = (Action<EntityMetadata>) (m =>
        {
          int num22 = 2;
          while (true)
          {
            switch (num22)
            {
              case 0:
                goto label_2;
              case 1:
                publishData1.RestartNeededMetadata.Add(m.Uid, (IRootMetadata) m);
                num22 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 0 : 0;
                continue;
              case 2:
                // ISSUE: reference to a compiler-generated method
                publishData1.DeltaPublishedMetadata.Remove(PublicationActor.\u003C\u003Ec__DisplayClass48_0.ujfo6qZGyqMCA3uWY1CP((object) m));
                num22 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 1 : 1;
                continue;
              default:
                goto label_5;
            }
          }
label_2:
          return;
label_5:;
        })) : action8;
        entityMetadataList.ForEach(action9);
        num1 = 30;
      }
label_135:
      return;
label_100:
      throw new MetadataValidationException(ValidationErrorHelper.GetMessage(validationErrors), validationErrors);
label_133:
      return;
label_134:
      object t = PublicationActor.BaDoFSfp0Y3o0kH3tZnG(-2099751081 ^ -2099444817);
      object[] objArray = new object[1];
      object separator = PublicationActor.BaDoFSfp0Y3o0kH3tZnG(516838154 ^ 516823592);
      IEnumerable<EntityMetadata> source3 = source1;
      // ISSUE: reference to a compiler-generated field
      System.Func<EntityMetadata, string> func1 = PublicationActor.\u003C\u003Ec.\u003C\u003E9__48_9;
      System.Func<EntityMetadata, string> selector;
      if (func1 == null)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        PublicationActor.\u003C\u003Ec.\u003C\u003E9__48_9 = selector = (System.Func<EntityMetadata, string>) (md => string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87480509), PublicationActor.\u003C\u003Ec.DDJ3kLZhWySKomM4jMnT((object) md), PublicationActor.\u003C\u003Ec.lFdYGLZhoHvvp9vDrtQr((object) md)));
      }
      else
        goto label_139;
label_137:
      IEnumerable<string> values = source3.Select<EntityMetadata, string>(selector);
      objArray[0] = (object) string.Join((string) separator, values);
      throw new Exception(EleWise.ELMA.SR.T((string) t, objArray));
label_139:
      selector = func1;
      goto label_137;
    }

    private static IEnumerable<TablePartMetadata> GetRecursiveTablePartMetadata(object metadata)
    {
      if (!(metadata is EntityMetadata entityMetadata))
        return Enumerable.Empty<TablePartMetadata>();
      List<TablePartMetadata> tablePartMetadata = new List<TablePartMetadata>();
      tablePartMetadata.AddRange((IEnumerable<TablePartMetadata>) entityMetadata.TableParts);
      tablePartMetadata.AddRange(entityMetadata.TableParts.SelectMany<TablePartMetadata, TablePartMetadata>((System.Func<TablePartMetadata, IEnumerable<TablePartMetadata>>) (tablePart => PublicationActor.GetRecursiveTablePartMetadata((object) tablePart))));
      return (IEnumerable<TablePartMetadata>) tablePartMetadata;
    }

    private static IEnumerable<ValidationError> ValidateMetadataReferences(
      object metadata,
      IDictionary<Guid, IRootMetadata> metadataList,
      IDictionary<Guid, IRootMetadata> publishExtensionsMetadataList)
    {
      List<ValidationError> validationErrorList = new List<ValidationError>();
      foreach (PropertyMetadata property in ((ClassMetadata) metadata).Properties)
      {
        EntitySettings settings;
        if ((settings = property.Settings as EntitySettings) != null)
        {
          IRootMetadata rootMetadata1;
          if (!metadataList.TryGetValue(property.SubTypeUid, out rootMetadata1))
            validationErrorList.Add(new ValidationError()
            {
              OwnerUid = ((EleWise.ELMA.Model.Metadata.AbstractMetadata) metadata).Uid,
              ElementUid = property.SubTypeUid,
              ElementTypeUid = ValidationElementType.Property,
              Message = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1242972401 >> 4 ^ 77869377), (object) property.Name)
            });
          IRootMetadata rootMetadata2;
          IRootMetadata rootMetadata3;
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          if ((settings.RelationType == RelationType.ManyToManyInverse || settings.RelationType == RelationType.OneToMany) && rootMetadata1 is EntityMetadata entityMetadata && entityMetadata.Properties.All<PropertyMetadata>((System.Func<PropertyMetadata, bool>) (p => PublicationActor.\u003C\u003Ec__DisplayClass50_0.NXClnCZEBPs6mNmusDmB(PublicationActor.\u003C\u003Ec__DisplayClass50_0.TTIXwZZGzGLRtPEbhZcq((object) p), PublicationActor.\u003C\u003Ec__DisplayClass50_0.lp0uyRZEFC8lKi1nLXM3((object) settings)))) && (!publishExtensionsMetadataList.TryGetValue(property.SubTypeUid, out rootMetadata2) || ((ClassMetadata) rootMetadata2).Properties.All<PropertyMetadata>((System.Func<PropertyMetadata, bool>) (p => p.Uid != PublicationActor.\u003C\u003Ec__DisplayClass50_0.lp0uyRZEFC8lKi1nLXM3((object) settings)))) && (!metadataList.TryGetValue(entityMetadata.ImplementationUid, out rootMetadata3) || ((ClassMetadata) rootMetadata3).Properties.All<PropertyMetadata>((System.Func<PropertyMetadata, bool>) (p => PublicationActor.\u003C\u003Ec__DisplayClass50_0.NXClnCZEBPs6mNmusDmB(PublicationActor.\u003C\u003Ec__DisplayClass50_0.TTIXwZZGzGLRtPEbhZcq((object) p), settings.KeyColumnUid)))))
            validationErrorList.Add(new ValidationError()
            {
              OwnerUid = ((EleWise.ELMA.Model.Metadata.AbstractMetadata) metadata).Uid,
              ElementUid = property.SubTypeUid,
              ElementTypeUid = ValidationElementType.Property,
              Message = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1505778440 - 1981636111 ^ -475551417))
            });
        }
      }
      foreach (TablePartMetadata tablePart in ((EntityMetadata) metadata).TableParts)
        validationErrorList.AddRange(PublicationActor.ValidateMetadataReferences((object) tablePart, metadataList, publishExtensionsMetadataList));
      return (IEnumerable<ValidationError>) validationErrorList;
    }

    private void CreatePublishingItem(
      IMetadataItem item,
      string tag,
      string comment,
      PublishData publishData,
      IDictionary<Guid, IRootMetadata> metadataRuntime,
      List<IMetadata> metadataToExtend)
    {
      IRootMetadata rootMetadata1 = ClassSerializationHelper.CloneObjectByXml<object>(item.Metadata) as IRootMetadata;
      using (new MetadataServiceContext((IMetadataService) new ExtendedMetadataService(MetadataServiceContext.Service, (IEnumerable<IMetadata>) metadataToExtend)))
      {
        foreach (IPublicationHandler publicationHandler in this.publicationHandlers)
          publicationHandler.UpdateMetadata((IMetadata) rootMetadata1);
      }
      IDeltaRootMetadata deltaRootMetadata = rootMetadata1 as IDeltaRootMetadata;
      IRootMetadata rootMetadata2;
      metadataRuntime.TryGetValue(item.Header.Uid, out rootMetadata2);
      if (rootMetadata1 != null)
      {
        if (rootMetadata2 == null)
        {
          if (!this.dynamicPublicationService.Enable || MetadataServiceContext.MetadataRuntimeService.ConfigurationScriptsRecompileRequired)
            publishData.DeltaPublishedMetadata[rootMetadata1.Uid] = rootMetadata1;
          else if (deltaRootMetadata != null)
          {
            if (MetadataSoftPublishHelper.GetPublicationTypeOnCreate((IMetadata) rootMetadata1) != PublicationType.Restart)
              publishData.DeltaPublishedMetadata[rootMetadata1.Uid] = rootMetadata1;
            else
              publishData.RestartNeededMetadata[rootMetadata1.Uid] = rootMetadata1;
          }
          else
            publishData.RestartNeededMetadata[rootMetadata1.Uid] = rootMetadata1;
        }
        else
        {
          IDeltaRootMetadata oldMetadata = rootMetadata2 as IDeltaRootMetadata;
          if (deltaRootMetadata == null || oldMetadata == null)
          {
            if (!rootMetadata2.IsRestartNeeded(rootMetadata1))
              publishData.SoftPublishedMetadata[rootMetadata1.Uid] = rootMetadata1;
            else if (!this.dynamicPublicationService.Enable || MetadataServiceContext.MetadataRuntimeService.ConfigurationScriptsRecompileRequired)
              publishData.DeltaPublishedMetadata[rootMetadata1.Uid] = rootMetadata1;
            else
              publishData.RestartNeededMetadata[rootMetadata1.Uid] = rootMetadata1;
          }
          else
          {
            switch (MetadataSoftPublishHelper.GetPublicationTypeOnChange((IMetadata) oldMetadata, (IMetadata) rootMetadata1))
            {
              case PublicationType.Soft:
                publishData.SoftPublishedMetadata[rootMetadata1.Uid] = rootMetadata1;
                break;
              case PublicationType.Delta:
                publishData.DeltaPublishedMetadata[rootMetadata1.Uid] = rootMetadata1;
                break;
              case PublicationType.Restart:
                if (this.dynamicPublicationService.Enable && !MetadataServiceContext.MetadataRuntimeService.ConfigurationScriptsRecompileRequired)
                {
                  publishData.RestartNeededMetadata[rootMetadata1.Uid] = rootMetadata1;
                  break;
                }
                goto case PublicationType.Delta;
            }
          }
        }
      }
      IMetadataItem destination = this.metadataItemManager.Value.Create();
      destination.Uid = Guid.NewGuid();
      destination.Metadata = (object) rootMetadata1;
      destination.CreationDate = item.CreationDate;
      destination.CreationAuthorId = item.CreationAuthorId;
      destination.Header = item.Header;
      destination.Comment = comment;
      destination.Header.Tag = tag;
      using (MetadataServiceContext.Extend((IEnumerable<IMetadata>) metadataToExtend))
      {
        foreach (IPublicationHandler publicationHandler in this.publicationHandlers)
          publicationHandler.UpdateMetadataItem(item, destination);
        if (this.workWithFormDependenciesService.IsActive())
        {
          if (rootMetadata1 is EntityMetadata metadata)
            this.entityMetadataDependencyService.CollectDependencies(metadata, item.Header.Current);
        }
      }
      this.Session.Save((object) destination);
      item.Header.Published = destination;
      item.Header.IsDirtyItem = false;
      item.Header.Save();
      publishData.MetadataItems.Add(destination);
    }

    /// <summary>Обработчик события дельта-публикации на текущем узле</summary>
    /// <param name="eventArgs">Параметры события публикации</param>
    private void PublishFinished(MetadataPublishedEventArgs eventArgs)
    {
      int num1 = 1;
      IUnitOfWork unitOfWork;
      PublicationActor publicationActor;
      MetadataPublishedEventArgs eventArgs1;
      Dictionary<Guid, EntityMetadata> metadataRuntime;
      while (true)
      {
        switch (num1)
        {
          case 1:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 0;
            continue;
          case 2:
            if (PublicationActor.SpvmekfaQnJVlSiTbEj7((object) eventArgs1.DeltaPublishedMetadata) > 0)
            {
              num1 = 8;
              continue;
            }
            goto case 5;
          case 3:
            PublicationActor.yvZ0ExfaiRSUYuXeF0pR((object) new DbDeltaModelUpdater(eventArgs1.DeltaPublishedMetadata.OfType<EntityMetadata>().Select<EntityMetadata, ModifedEntityPair>((System.Func<EntityMetadata, ModifedEntityPair>) (m =>
            {
              int num2 = 1;
              EntityMetadata entityMetadata;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    if (!metadataRuntime.TryGetValue(PublicationActor.\u003C\u003Ec__DisplayClass52_1.fD0mDFZER3JvQYfJHcbr((object) m), out entityMetadata))
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 0;
                      continue;
                    }
                    goto label_5;
                  default:
                    goto label_4;
                }
              }
label_4:
              EntityMetadata oldMetadata = (EntityMetadata) null;
              goto label_6;
label_5:
              oldMetadata = entityMetadata;
label_6:
              EntityMetadata newMetadata = m;
              return new ModifedEntityPair(oldMetadata, newMetadata);
            }))), (object) this.Session);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 2 : 5;
            continue;
          case 4:
            goto label_6;
          case 5:
            unitOfWork = this.unitOfWorkManager.Create("", true, IsolationLevel.ReadCommitted);
            num1 = 4;
            continue;
          case 6:
            PublicationActor.Ic8mZYfpm7pLAh7eYV5s((object) this.publishLogger, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(322893104 - -1992822529 ^ -1979559297));
            num1 = 7;
            continue;
          case 7:
            IEnumerable<EntityMetadata> source = this.publishedMetadata.OfType<EntityMetadata>();
            // ISSUE: reference to a compiler-generated field
            System.Func<EntityMetadata, Guid> func = PublicationActor.\u003C\u003Ec.\u003C\u003E9__52_0;
            System.Func<EntityMetadata, Guid> keySelector;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              PublicationActor.\u003C\u003Ec.\u003C\u003E9__52_0 = keySelector = (System.Func<EntityMetadata, Guid>) (m => PublicationActor.\u003C\u003Ec.BGfD41ZhbvVaciNNAWFh((object) m));
            }
            else
              goto label_45;
label_44:
            metadataRuntime = source.ToDictionary<EntityMetadata, Guid>(keySelector);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 3 : 1;
            continue;
label_45:
            keySelector = func;
            goto label_44;
          case 8:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 6 : 4;
            continue;
          case 9:
            goto label_42;
          case 10:
            if (PublicationActor.AfHtJSfaSh4pvQjCC9ej((object) eventArgs1.PublishResult) != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 2 : 2;
              continue;
            }
            goto case 5;
          case 11:
            eventArgs1 = eventArgs;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 10 : 3;
            continue;
          default:
            publicationActor = this;
            num1 = 11;
            continue;
        }
      }
label_42:
      return;
label_6:
      try
      {
        PublicationActor.Ic8mZYfpm7pLAh7eYV5s((object) this.publishLogger, PublicationActor.BaDoFSfp0Y3o0kH3tZnG(~210725948 ^ -210385475));
        int num3 = 10;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0)
          num3 = 11;
        while (true)
        {
          switch (num3)
          {
            case 1:
              if (((MetadataAssemblyPublishResult) PublicationActor.pKIe6wfaqLO74Kawet8G((object) eventArgs1)).DynamicAssembly == null)
              {
                num3 = 5;
                continue;
              }
              goto default;
            case 2:
              // ISSUE: reference to a compiler-generated method
              this.metadataRuntimeService.Value.GetAssemblyModelsMetadataList().Where<AssemblyModelsMetadata>((System.Func<AssemblyModelsMetadata, bool>) (m => publicationActor.assemblyModelsMetadataIds.ContainsKey((string) PublicationActor.\u003C\u003Ec__DisplayClass52_0.c2S3hXZEEPxgtx9JdwYC((object) m)))).ForEach<AssemblyModelsMetadata>((Action<AssemblyModelsMetadata>) (m =>
              {
                int num4 = 6;
                while (true)
                {
                  int num5 = num4;
                  string[] columns;
                  object[] values;
                  string str;
                  while (true)
                  {
                    switch (num5)
                    {
                      case 1:
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
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        values = new object[4]
                        {
                          (object) new SqlExpressionParameter((string) PublicationActor.\u003C\u003Ec__DisplayClass52_0.R8g9xKZEvimENE2vKXFM((object) new string[5]
                          {
                            (string) PublicationActor.\u003C\u003Ec__DisplayClass52_0.vt5JsaZEfKf6b4AJdCxC(1470440286 ^ 1470300772),
                            (string) PublicationActor.\u003C\u003Ec__DisplayClass52_0.y9jYwfZECXN7yEyjm1TL(PublicationActor.\u003C\u003Ec__DisplayClass52_0.pn65ETZEQWAH79DwaO88((object) publicationActor.transformationProvider.Value), PublicationActor.\u003C\u003Ec__DisplayClass52_0.vt5JsaZEfKf6b4AJdCxC(-2138958856 ^ -2138856712)),
                            (string) PublicationActor.\u003C\u003Ec__DisplayClass52_0.vt5JsaZEfKf6b4AJdCxC(1113862659 ^ 1113881377),
                            str,
                            z2jc63fLkugS1X8Q9N.tE1kD1vbB(381945751 ^ 1158627804 ^ 1405835767)
                          })),
                          (object) new SqlExpressionParameter((string) PublicationActor.\u003C\u003Ec__DisplayClass52_0.R8g9xKZEvimENE2vKXFM((object) new string[5]
                          {
                            z2jc63fLkugS1X8Q9N.tE1kD1vbB(87862435 ^ 87723417),
                            (string) PublicationActor.\u003C\u003Ec__DisplayClass52_0.y9jYwfZECXN7yEyjm1TL(PublicationActor.\u003C\u003Ec__DisplayClass52_0.pn65ETZEQWAH79DwaO88((object) publicationActor.transformationProvider.Value), PublicationActor.\u003C\u003Ec__DisplayClass52_0.vt5JsaZEfKf6b4AJdCxC(1178210108 ^ 1178320402)),
                            (string) PublicationActor.\u003C\u003Ec__DisplayClass52_0.vt5JsaZEfKf6b4AJdCxC(-16752921 ^ -16771131),
                            str,
                            z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106521480)
                          })),
                          (object) new SqlExpressionParameter((string) PublicationActor.\u003C\u003Ec__DisplayClass52_0.R8g9xKZEvimENE2vKXFM((object) new string[5]
                          {
                            z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1839087379 - 334718690 ^ 2120776497),
                            (string) PublicationActor.\u003C\u003Ec__DisplayClass52_0.y9jYwfZECXN7yEyjm1TL(PublicationActor.\u003C\u003Ec__DisplayClass52_0.pn65ETZEQWAH79DwaO88((object) publicationActor.transformationProvider.Value), PublicationActor.\u003C\u003Ec__DisplayClass52_0.vt5JsaZEfKf6b4AJdCxC(1242972401 >> 4 ^ 77649173)),
                            (string) PublicationActor.\u003C\u003Ec__DisplayClass52_0.vt5JsaZEfKf6b4AJdCxC(-1146510045 ^ -1146491903),
                            str,
                            (string) PublicationActor.\u003C\u003Ec__DisplayClass52_0.vt5JsaZEfKf6b4AJdCxC(874012245 ^ 874004969)
                          })),
                          (object) new ParameterValue(DbType.Binary, PublicationActor.\u003C\u003Ec__DisplayClass52_0.XgMD5aZE8ZlUaVXSZYLA((object) m))
                        };
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
                        continue;
                      case 2:
                        values = new object[2]
                        {
                          (object) (int) m.Status,
                          (object) new ParameterValue(DbType.Binary, (object) m.MetadataStream)
                        };
                        num5 = 7;
                        continue;
                      case 3:
                        goto label_6;
                      case 4:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        str = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1445902765 ^ -1980277732 ^ 538983241), PublicationActor.\u003C\u003Ec__DisplayClass52_0.y9jYwfZECXN7yEyjm1TL(PublicationActor.\u003C\u003Ec__DisplayClass52_0.pn65ETZEQWAH79DwaO88((object) publicationActor.transformationProvider.Value), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(381945751 ^ 1158627804 ^ 1405810321)), (object) publicationActor.transformationProvider.Value.Dialect.QuoteIfNeeded((string) PublicationActor.\u003C\u003Ec__DisplayClass52_0.vt5JsaZEfKf6b4AJdCxC(-1638402543 ^ -1638434993)), (object) publicationActor.assemblyModelsMetadataIds[(string) PublicationActor.\u003C\u003Ec__DisplayClass52_0.c2S3hXZEEPxgtx9JdwYC((object) m)]);
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 1 : 1;
                        continue;
                      case 5:
                        // ISSUE: reference to a compiler-generated method
                        PublicationActor.\u003C\u003Ec__DisplayClass52_0.KMjK66ZEuLRMTvUnUhgU((object) m, publicationActor.assemblyModelsMetadataIds[m.Name]);
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 10 : 5;
                        continue;
                      case 6:
                        if (m.Id <= 0L)
                        {
                          num5 = 5;
                          continue;
                        }
                        goto case 8;
                      case 7:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        publicationActor.transformationProvider.Value.Update((string) PublicationActor.\u003C\u003Ec__DisplayClass52_0.vt5JsaZEfKf6b4AJdCxC(-1998538950 ^ -1998518304), columns, values, (string) PublicationActor.\u003C\u003Ec__DisplayClass52_0.WUgK6BZEImSKsoKTX5U9((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(654297945 ^ 653912599), PublicationActor.\u003C\u003Ec__DisplayClass52_0.y9jYwfZECXN7yEyjm1TL(PublicationActor.\u003C\u003Ec__DisplayClass52_0.pn65ETZEQWAH79DwaO88((object) publicationActor.transformationProvider.Value), PublicationActor.\u003C\u003Ec__DisplayClass52_0.vt5JsaZEfKf6b4AJdCxC(1642859704 ^ 1642892774)), (object) PublicationActor.\u003C\u003Ec__DisplayClass52_0.DnYO5oZEZGQhFsk3JeiX((object) m)));
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 9 : 6;
                        continue;
                      case 8:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        columns = new string[4]
                        {
                          z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867715764),
                          (string) PublicationActor.\u003C\u003Ec__DisplayClass52_0.vt5JsaZEfKf6b4AJdCxC(-1088304168 ^ -1088390410),
                          z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398634938),
                          (string) PublicationActor.\u003C\u003Ec__DisplayClass52_0.vt5JsaZEfKf6b4AJdCxC(~538519529 ^ -538546476)
                        };
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 1 : 4;
                        continue;
                      case 9:
                        goto label_3;
                      case 10:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        columns = new string[2]
                        {
                          (string) PublicationActor.\u003C\u003Ec__DisplayClass52_0.vt5JsaZEfKf6b4AJdCxC(-345420348 ^ -345387966),
                          (string) PublicationActor.\u003C\u003Ec__DisplayClass52_0.vt5JsaZEfKf6b4AJdCxC(--1867379187 ^ 1867335473)
                        };
                        num5 = 2;
                        continue;
                      default:
                        goto label_10;
                    }
                  }
label_10:
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  publicationActor.transformationProvider.Value.Update(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2092274397 << 4 ^ 883385066), columns, values, string.Format((string) PublicationActor.\u003C\u003Ec__DisplayClass52_0.vt5JsaZEfKf6b4AJdCxC(-867826612 ^ -868211454), PublicationActor.\u003C\u003Ec__DisplayClass52_0.y9jYwfZECXN7yEyjm1TL(PublicationActor.\u003C\u003Ec__DisplayClass52_0.pn65ETZEQWAH79DwaO88((object) publicationActor.transformationProvider.Value), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420776328)), (object) PublicationActor.\u003C\u003Ec__DisplayClass52_0.DnYO5oZEZGQhFsk3JeiX((object) m)));
                  num4 = 3;
                }
label_6:
                return;
label_3:;
              }));
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 1;
              continue;
            case 3:
              goto label_32;
            case 4:
            case 5:
              PublicationActor.KkbQcSfaeh2C3eDN9uIE((object) unitOfWork);
              num3 = 6;
              continue;
            case 6:
              PublicationActor.Ic8mZYfpm7pLAh7eYV5s((object) this.publishLogger, PublicationActor.BaDoFSfp0Y3o0kH3tZnG(-1886646897 ^ -1886823745));
              num3 = 3;
              continue;
            case 7:
              PublicationActor.Iv0dHafaO1ppTaT7aflo(PublicationActor.svdZDIfaXm0vt2uIf7ca((object) this.runtimeApplication.ApplicationStartCache, PublicationActor.uMDa0nfaKvKQ2Fph7GXo(PublicationActor.BaDoFSfp0Y3o0kH3tZnG(-477139494 ^ -477141058), false)), PublicationActor.ysDFoDfanGY1rNvCJDyu(PublicationActor.K0FHKffakPkTcDf86alK(PublicationActor.jIVWHkfaTr9OQRYYISrd(PublicationActor.pKIe6wfaqLO74Kawet8G((object) eventArgs1)))));
              num3 = 8;
              continue;
            case 8:
              PublicationActor.Iv0dHafaO1ppTaT7aflo(PublicationActor.svdZDIfaXm0vt2uIf7ca((object) this.runtimeApplication.ApplicationStartCache, PublicationActor.uMDa0nfaKvKQ2Fph7GXo((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426456882 ^ 2009939514 ^ -583742758), false)), PublicationActor.ysDFoDfanGY1rNvCJDyu(PublicationActor.K0FHKffakPkTcDf86alK((object) ((MetadataAssemblyPublishResult) PublicationActor.pKIe6wfaqLO74Kawet8G((object) eventArgs1)).DynamicAssembly)));
              num3 = 12;
              continue;
            case 9:
              this.publishLogger.Debug(PublicationActor.BaDoFSfp0Y3o0kH3tZnG(-630932142 - 1120244082 ^ -1751483046));
              num3 = 2;
              continue;
            case 10:
              PublicationActor.Ic8mZYfpm7pLAh7eYV5s((object) this.publishLogger, PublicationActor.BaDoFSfp0Y3o0kH3tZnG(1149433385 + 173655049 ^ 1322904778));
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 7 : 0;
              continue;
            case 11:
              PublicationActor.b2x7NsfaRZReskSvmQ9I((object) this.securityService.Value, (object) (System.Action) (() =>
              {
                int num6 = 1;
                while (true)
                {
                  switch (num6)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      PublicationActor.\u003C\u003Ec__DisplayClass52_0.yJi3ugZEGi4Hd4GrNkWr((object) publicationActor.afterDeltaPublishEventHandler, (object) eventArgs1);
                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_4;
                  }
                }
label_2:
                return;
label_4:;
              }));
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 5 : 9;
              continue;
            case 12:
              PublicationActor.kS2Yt2fa2KrqD8JAylHI((object) this.runtimeApplication.ApplicationStartCache);
              num3 = 4;
              continue;
            default:
              if (PublicationActor.SpvmekfaQnJVlSiTbEj7((object) eventArgs1.DeltaPublishedMetadata) > 0)
              {
                num3 = 10;
                continue;
              }
              goto case 4;
          }
        }
label_32:;
      }
      catch (Exception ex)
      {
        int num7 = 2;
        while (true)
        {
          switch (num7)
          {
            case 1:
              PublicationActor.IPV0Zqfa1KFBwPZVfIdG((object) unitOfWork);
              num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 0 : 0;
              continue;
            case 2:
              this.publishLogger.Error(PublicationActor.BCeKD3faPDSFy7tBmR23((object) ex), ex);
              num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 1 : 1;
              continue;
            default:
              goto label_26;
          }
        }
label_26:
        throw;
      }
      finally
      {
        int num8;
        if (unitOfWork == null)
          num8 = 2;
        else
          goto label_30;
label_29:
        switch (num8)
        {
          case 1:
            break;
          default:
        }
label_30:
        PublicationActor.NbhRh4fp9pcZgJLHtPab((object) unitOfWork);
        num8 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
        {
          num8 = 0;
          goto label_29;
        }
        else
          goto label_29;
      }
    }

    internal static object BaDoFSfp0Y3o0kH3tZnG(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void Ic8mZYfpm7pLAh7eYV5s([In] object obj0, [In] object obj1) => ((ILogger) obj0).Debug(obj1);

    internal static bool nZOJpmfpylYSIoU5LJpP([In] object obj0) => ((IDynamicPublicationService) obj0).Enable;

    internal static object vTLMjVfpMNNPmgYFlnNU([In] object obj0, [In] object obj1) => (object) ((IEventHandlerSubscribeService) obj0).Subscribe((IEventHandler) obj1);

    internal static object CNhprlfpJR56VHcSvmc5() => (object) Task.CompletedTask;

    internal static bool GQim44fp7wury7w85TU6() => PublicationActor.sjpvosfpA66fOdgSrIkN == null;

    internal static PublicationActor J6OiRofpxWZZe6GZakpv() => PublicationActor.sjpvosfpA66fOdgSrIkN;

    internal static void NbhRh4fp9pcZgJLHtPab([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static AsyncTaskMethodBuilder psnbbpfpdMlTuWb2vEQN() => AsyncTaskMethodBuilder.Create();

    internal static void ebFpZNfplMPVeUHOmAfQ([In] object obj0) => Monitor.Exit(obj0);

    internal static int I9mtQufprG1ZIiEFGDjx([In] object obj0) => ((HashSet<Guid>) obj0).Count;

    internal static object T1BBLIfpgXNoReaASXEi([In] Type obj0) => (object) DetachedCriteria.For(obj0);

    internal static object jwoNeGfp5hxmvpXWdOrm([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((DetachedCriteria) obj0).CreateAlias((string) obj1, (string) obj2);

    internal static object iN5TgdfpjiDJqHotjxFy([In] object obj0) => (object) Projections.Property((string) obj0);

    internal static object FabUvKfpYg1HkGAAmjoU([In] object obj0, [In] object obj1) => (object) ((DetachedCriteria) obj0).SetProjection((IProjection) obj1);

    internal static object LisvgmfpLq15lOyOspvO([In] object obj0, [In] object obj1) => (object) Subqueries.PropertyIn((string) obj0, (DetachedCriteria) obj1);

    internal static object BWUctNfpUUKqdQryZKgd([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).Add((ICriterion) obj1);

    internal static bool JBybaTfpsjpmgMWHCVOe([In] object obj0) => ((PublishData) obj0).OnlySoftPublished();

    internal static Type MRbA6EfpcFOKsJVdGjQm([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object Pv0bQOfpzl4niI4MiJNP([In] Type obj0, [In] object obj1) => (object) System.Linq.Expressions.Expression.Parameter(obj0, (string) obj1);

    internal static object vGqWd4faFfls9kCe1Im9([In] object obj0, [In] Type obj1) => (object) System.Linq.Expressions.Expression.Constant(obj0, obj1);

    internal static object QcZEC1faBJW0El6bmCZf([In] object obj0, [In] object obj1) => (object) System.Linq.Expressions.Expression.Equal((System.Linq.Expressions.Expression) obj0, (System.Linq.Expressions.Expression) obj1);

    internal static object jJ5K2XfaWLEAyb916ZKG([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static object qmpQGGfaotI2jqJplgTn([In] object obj0, [In] object obj1) => (object) System.Linq.Expressions.Expression.Property((System.Linq.Expressions.Expression) obj0, (MethodInfo) obj1);

    internal static object Tqmexlfab8g14GIlrp8e([In] object obj0, [In] object obj1) => (object) System.Linq.Expressions.Expression.AndAlso((System.Linq.Expressions.Expression) obj0, (System.Linq.Expressions.Expression) obj1);

    internal static object maOl3efahXEcsF5riZAa([In] object obj0) => (object) ((AssemblyModelsMetadata) obj0).RestoreMetadata();

    internal static int gVm3UAfaGxV9ObDjq591([In] object obj0) => ((Dictionary<Guid, IRootMetadata>) obj0).Count;

    internal static void DcFPHEfaEXoe1oSG4xMI([In] object obj0, [In] object obj1) => ((AssemblyModelsMetadata) obj0).Name = (string) obj1;

    internal static void uDKBdufafsG201uFbbgq([In] object obj0, AssemblyModelsMetadataStatus value) => ((AssemblyModelsMetadata) obj0).Status = value;

    internal static int SpvmekfaQnJVlSiTbEj7([In] object obj0) => ((ICollection<IRootMetadata>) obj0).Count;

    internal static object oXM82FfaCjwug51Njp6Z([In] object obj0, [In] object obj1) => ((ISession) obj0).Save(obj1);

    internal static void bHdOpJfavdcOkdeZTSxl([In] object obj0, [In] object obj1) => ((ISession) obj0).Delete(obj1);

    internal static object S0v839fa8E74PcnDqO2c() => (object) MetadataServiceContext.MetadataRuntimeService;

    internal static EntityMetadataType JxMDCnfaZexqZ3ZpjMAJ([In] object obj0) => ((EntityMetadata) obj0).Type;

    internal static Guid atZvhUfauvh9Gx7MeNyc([In] object obj0) => ((ClassMetadata) obj0).BaseClassUid;

    internal static int Qci5cSfaIvImRXfnasdn([In] object obj0) => ((List<ValidationError>) obj0).Count;

    internal static object sUTohXfaVZMup1qONDks([In] object obj0) => (object) ((List<ValidationError>) obj0).ToArray();

    internal static object AfHtJSfaSh4pvQjCC9ej([In] object obj0) => (object) ((MetadataAssemblyPublishResult) obj0).DynamicAssembly;

    internal static void yvZ0ExfaiRSUYuXeF0pR([In] object obj0, [In] object obj1) => ((DbDeltaModelUpdater) obj0).Update((ISession) obj1);

    internal static void b2x7NsfaRZReskSvmQ9I([In] object obj0, [In] object obj1) => ((ISecurityService) obj0).RunBySystemUser((System.Action) obj1);

    internal static object pKIe6wfaqLO74Kawet8G([In] object obj0) => (object) ((MetadataPublishedEventArgs) obj0).PublishResult;

    internal static object uMDa0nfaKvKQ2Fph7GXo([In] object obj0, bool isFullName) => (object) ComponentManager.FindLoadedAssembly((string) obj0, isFullName);

    internal static object svdZDIfaXm0vt2uIf7ca([In] object obj0, [In] object obj1) => (object) ((ApplicationStartCache) obj0).GetAssemblyInfo((Assembly) obj1);

    internal static object jIVWHkfaTr9OQRYYISrd([In] object obj0) => (object) ((MetadataAssemblyPublishResult) obj0).ConfigurationAssembly;

    internal static object K0FHKffakPkTcDf86alK([In] object obj0) => (object) ((AssemblyModelsMetadata) obj0).AssemblyRawStream;

    internal static object ysDFoDfanGY1rNvCJDyu([In] object obj0) => (object) AssemblyInfoCache.EvaluateHashCode((Stream) obj0);

    internal static void Iv0dHafaO1ppTaT7aflo([In] object obj0, [In] object obj1) => ((AssemblyInfoCache) obj0).HashCode = (string) obj1;

    internal static void kS2Yt2fa2KrqD8JAylHI([In] object obj0) => ((ApplicationStartCache) obj0).Save();

    internal static void KkbQcSfaeh2C3eDN9uIE([In] object obj0) => ((IUnitOfWork) obj0).Commit();

    internal static object BCeKD3faPDSFy7tBmR23([In] object obj0) => (object) ((Exception) obj0).Message;

    internal static void IPV0Zqfa1KFBwPZVfIdG([In] object obj0) => ((IUnitOfWork) obj0).Rollback();

    internal static object xVOjKRfaNGdOn3yD63Y7([In] object obj0, Guid publicationToken) => (object) ((IServerInstanceActor) obj0).PublicationComplete(publicationToken);

    internal static object rpG2hHfa33LIjFe2h3y2([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    /// <inheritdoc />
    private class PublishFinishedEventHandler : IMetadataPublishFinishedEventHandler, IEventHandler
    {
      private readonly Action<MetadataPublishedEventArgs> action;
      internal static object BgHY04Zb1iuM4GfTUdCL;

      /// <summary>ctor</summary>
      /// <param name="action">Обработчик события</param>
      public PublishFinishedEventHandler(Action<MetadataPublishedEventArgs> action)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        this.action = action;
      }

      /// <inheritdoc />
      public void PublishExecuted(MetadataPublishedEventArgs eventArgs)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.action(eventArgs);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      internal static bool GpafM7ZbNMOQCcwojeL7() => PublicationActor.PublishFinishedEventHandler.BgHY04Zb1iuM4GfTUdCL == null;

      internal static PublicationActor.PublishFinishedEventHandler t76Yg2Zb30wxL4WqdJqc() => (PublicationActor.PublishFinishedEventHandler) PublicationActor.PublishFinishedEventHandler.BgHY04Zb1iuM4GfTUdCL;
    }

    /// <inheritdoc />
    private class ServerStatusEventHandler : IServerStatusEventHandler, IEventHandler
    {
      private readonly System.Func<Guid, Task> complete;
      internal static object qNHd6VZbpkqyT8Lpxxdt;

      public ServerStatusEventHandler(System.Func<Guid, Task> complete)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        this.complete = complete;
      }

      public void ServerStarted(Guid serverUid, Version serverVersion)
      {
      }

      public void ServerStarting(Guid serverUid)
      {
      }

      public void ServerStoped(Guid serverUid)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              Task task = this.complete(serverUid);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      internal static bool IKSaaNZbayBtja304Jv5() => PublicationActor.ServerStatusEventHandler.qNHd6VZbpkqyT8Lpxxdt == null;

      internal static PublicationActor.ServerStatusEventHandler K9aT72ZbDLWc3GeCL6w7() => (PublicationActor.ServerStatusEventHandler) PublicationActor.ServerStatusEventHandler.qNHd6VZbpkqyT8Lpxxdt;
    }
  }
}
