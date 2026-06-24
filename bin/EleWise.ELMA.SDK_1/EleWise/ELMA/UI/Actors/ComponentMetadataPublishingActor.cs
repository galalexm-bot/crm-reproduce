// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Actors.ComponentMetadataPublishingActor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using EleWise.ELMA.UI.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace EleWise.ELMA.UI.Actors
{
  /// <summary>Актор публикации компонента</summary>
  internal sealed class ComponentMetadataPublishingActor : 
    Actor,
    IComponentMetadataPublishingActor,
    IActorWithGuidKey,
    IActor
  {
    private readonly IComponentMetadataItemHeaderManager componentMetadataItemHeaderManager;
    private readonly ISearchMetadataService searchMetadataService;
    private readonly ICheckComponentService checkComponentService;
    private readonly IDependencyService dependencyService;
    private readonly IComponentAssemblyBuilderService componentAssemblyBuilderService;
    private readonly IDataClassTypeReferenceManager dataClassTypeReferenceManager;
    private readonly ILockManager lockManager;
    private readonly IAuthenticationService authenticationService;
    private readonly IComponentMetadataItemManager componentMetadataItemManager;
    private readonly ISessionProvider sessionProvider;
    private readonly IUnitOfWorkManager unitOfWorkManager;
    private readonly IServerPlacementPublishService serverPlacementPublishService;
    private readonly ISearchFormServiceInternal searchFormService;
    private readonly ILogger logger;
    private bool publicationStarted;
    internal static ComponentMetadataPublishingActor Ue9jOFBVLs3sVl5LlFJ1;

    /// <summary>Ctor</summary>
    /// <param name="loggerFactory">Фабрика логгеров</param>
    /// <param name="componentMetadataItemHeaderManager">Менеджер заголовков метаданных компонента</param>
    /// <param name="searchMetadataService">Сервис поиска метаданных</param>
    /// <param name="checkComponentService">Сервис проверки компонента при публикации</param>
    /// <param name="dependencyService">Сервис для работы с зависимостями</param>
    /// <param name="componentAssemblyBuilderService">Сервис компиляции компонента</param>
    /// <param name="dataClassTypeReferenceManager">Менеджер ссылки типа DTO</param>
    /// <param name="lockManager">Менеджер блокировок</param>
    /// <param name="authenticationService">Служба аутентификации системы</param>
    /// <param name="componentMetadataItemManager">Менеджер метаданных компонента</param>
    /// <param name="sessionProvider">Провайдер сессий NHibernate</param>
    /// <param name="unitOfWorkManager">Фабрика единиц работы</param>
    /// <param name="serverPlacementPublishService">Сервис публикации действия на всех серверах кластера ELMA</param>
    /// <param name="searchFormService">Сервис поиска форм</param>
    public ComponentMetadataPublishingActor(
      EleWise.ELMA.Logging.ILoggerFactory loggerFactory,
      IComponentMetadataItemHeaderManager componentMetadataItemHeaderManager,
      ISearchMetadataService searchMetadataService,
      ICheckComponentService checkComponentService,
      IDependencyService dependencyService,
      IComponentAssemblyBuilderService componentAssemblyBuilderService,
      IDataClassTypeReferenceManager dataClassTypeReferenceManager,
      ILockManager lockManager,
      IAuthenticationService authenticationService,
      IComponentMetadataItemManager componentMetadataItemManager,
      ISessionProvider sessionProvider,
      IUnitOfWorkManager unitOfWorkManager,
      IServerPlacementPublishService serverPlacementPublishService,
      ISearchFormServiceInternal searchFormService)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.LifeTime = TimeSpan.FromHours(1.0);
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 12;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.searchMetadataService = searchMetadataService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 8 : 8;
            continue;
          case 2:
            this.authenticationService = authenticationService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
            continue;
          case 3:
            this.serverPlacementPublishService = serverPlacementPublishService;
            num = 14;
            continue;
          case 4:
            goto label_2;
          case 5:
            this.componentAssemblyBuilderService = componentAssemblyBuilderService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 5 : 11;
            continue;
          case 6:
            this.sessionProvider = sessionProvider;
            num = 9;
            continue;
          case 7:
            this.lockManager = lockManager;
            num = 2;
            continue;
          case 8:
            this.checkComponentService = checkComponentService;
            num = 10;
            continue;
          case 9:
            this.unitOfWorkManager = unitOfWorkManager;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 1 : 3;
            continue;
          case 10:
            this.dependencyService = dependencyService;
            num = 5;
            continue;
          case 11:
            this.dataClassTypeReferenceManager = dataClassTypeReferenceManager;
            num = 7;
            continue;
          case 12:
            this.componentMetadataItemHeaderManager = componentMetadataItemHeaderManager;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 1 : 0;
            continue;
          case 13:
            this.logger = (ILogger) ComponentMetadataPublishingActor.EZ8ZgIBVc995tXuZcBcy((object) loggerFactory, typeof (ComponentMetadataPublishingActor));
            num = 4;
            continue;
          case 14:
            this.searchFormService = searchFormService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 13 : 12;
            continue;
          default:
            this.componentMetadataItemManager = componentMetadataItemManager;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 4 : 6;
            continue;
        }
      }
label_2:;
    }

    /// <inheritdoc />
    public override TimeSpan LifeTime { get; }

    /// <inheritdoc />
    public override Task ReceiveReminder(string reminderName)
    {
      int num = 1;
      // ISSUE: variable of a compiler-generated type
      ComponentMetadataPublishingActor.\u003CReceiveReminder\u003Ed__22 stateMachine;
      AsyncTaskMethodBuilder tBuilder;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E4__this = this;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 0 : 0;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E1__state = -1;
            num = 3;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            tBuilder = stateMachine.\u003C\u003Et__builder;
            num = 6;
            continue;
          case 4:
            goto label_5;
          case 5:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003Et__builder = ComponentMetadataPublishingActor.giN4TaBVzkNmLvQ0ORPp();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 1 : 2;
            continue;
          case 6:
            tBuilder.Start<ComponentMetadataPublishingActor.\u003CReceiveReminder\u003Ed__22>(ref stateMachine);
            num = 4;
            continue;
          default:
            // ISSUE: reference to a compiler-generated field
            stateMachine.reminderName = reminderName;
            num = 5;
            continue;
        }
      }
label_5:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    /// <inheritdoc />
    public Task Publish(string comment, bool forEmulation)
    {
      int num = 7;
      // ISSUE: variable of a compiler-generated type
      ComponentMetadataPublishingActor.\u003CPublish\u003Ed__23 stateMachine;
      AsyncTaskMethodBuilder tBuilder;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003Et__builder = ComponentMetadataPublishingActor.giN4TaBVzkNmLvQ0ORPp();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 0 : 0;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            stateMachine.forEmulation = forEmulation;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_6;
          case 4:
            // ISSUE: reference to a compiler-generated field
            tBuilder = stateMachine.\u003C\u003Et__builder;
            num = 5;
            continue;
          case 5:
            tBuilder.Start<ComponentMetadataPublishingActor.\u003CPublish\u003Ed__23>(ref stateMachine);
            num = 3;
            continue;
          case 6:
            // ISSUE: reference to a compiler-generated field
            stateMachine.comment = comment;
            num = 2;
            continue;
          case 7:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E4__this = this;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 3 : 6;
            continue;
          default:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E1__state = -1;
            num = 4;
            continue;
        }
      }
label_6:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    /// <inheritdoc />
    public Task PublishComplete()
    {
      int num = 1;
      // ISSUE: variable of a compiler-generated type
      ComponentMetadataPublishingActor.\u003CPublishComplete\u003Ed__24 stateMachine;
      AsyncTaskMethodBuilder tBuilder;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E4__this = this;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
            continue;
          case 2:
            tBuilder.Start<ComponentMetadataPublishingActor.\u003CPublishComplete\u003Ed__24>(ref stateMachine);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 4;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            tBuilder = stateMachine.\u003C\u003Et__builder;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 2 : 0;
            continue;
          case 4:
            goto label_7;
          case 5:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E1__state = -1;
            num = 3;
            continue;
          default:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003Et__builder = AsyncTaskMethodBuilder.Create();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 5 : 3;
            continue;
        }
      }
label_7:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    /// <summary>Опубликовать компонент</summary>
    /// <param name="componentMetadataItemHeaderUid">Уникальный идентификатор заголовка метаданных компонента</param>
    /// <param name="comment">Комментарий при публикации</param>
    /// <param name="forEmulation"><c>true</c> если публикация для эмуляции</param>
    private Task PublishInternal(
      Guid componentMetadataItemHeaderUid,
      string comment,
      bool forEmulation)
    {
      int num = 3;
      // ISSUE: variable of a compiler-generated type
      ComponentMetadataPublishingActor.\u003CPublishInternal\u003Ed__25 stateMachine;
      AsyncTaskMethodBuilder tBuilder;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_6;
          case 2:
            // ISSUE: reference to a compiler-generated field
            stateMachine.componentMetadataItemHeaderUid = componentMetadataItemHeaderUid;
            num = 4;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E4__this = this;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 2 : 1;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated field
            stateMachine.comment = comment;
            num = 8;
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E1__state = -1;
            num = 7;
            continue;
          case 6:
            tBuilder.Start<ComponentMetadataPublishingActor.\u003CPublishInternal\u003Ed__25>(ref stateMachine);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 1;
            continue;
          case 7:
            // ISSUE: reference to a compiler-generated field
            tBuilder = stateMachine.\u003C\u003Et__builder;
            num = 6;
            continue;
          case 8:
            // ISSUE: reference to a compiler-generated field
            stateMachine.forEmulation = forEmulation;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 0;
            continue;
          default:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003Et__builder = ComponentMetadataPublishingActor.giN4TaBVzkNmLvQ0ORPp();
            num = 5;
            continue;
        }
      }
label_6:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    /// <summary>Создать элемент публикации</summary>
    /// <param name="session">Сессия NHibernate</param>
    /// <param name="header">Уникальный индентификатор заголовка метаданных компонента</param>
    /// <param name="comment">Комментарий</param>
    /// <param name="forEmulation"><c>true</c> если публикация происходит для эмуляции</param>
    private void CreatePublishingItem(
      ISession session,
      ComponentMetadataItemHeader header,
      string comment,
      bool forEmulation)
    {
      int num1 = 2;
      IDisposable disposable;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_64;
          case 1:
            disposable = this.lockManager.Lock((string) ComponentMetadataPublishingActor.wtLTlHBSW9cT9fJFqrdn(ComponentMetadataPublishingActor.UJcyeqBSFd6XSVGf8W3g(381945751 ^ 1158627804 ^ 1405771771), (object) header.Id));
            num1 = 3;
            continue;
          case 2:
            ComponentMetadataPublishingActor.PaPqHYBSByZKbqvFWaE9((object) header, ComponentMetadataPublishingActor.UJcyeqBSFd6XSVGf8W3g(1461625753 ^ 1461587725));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 1;
            continue;
          case 3:
            goto label_3;
          default:
            goto label_61;
        }
      }
label_64:
      return;
label_61:
      return;
label_3:
      try
      {
        ComponentMetadataItem componentMetadataItem1 = (ComponentMetadataItem) ComponentMetadataPublishingActor.rVoqKRBSoTwqWrJJjf9D((object) header);
        int num2 = 33;
        while (true)
        {
          int num3;
          ComponentMetadataItem componentMetadataItem2;
          string asmName;
          Version version1;
          string str1;
          string version2;
          ComponentMetadata metadata;
          string str2;
          IUser user;
          ComponentMetadataItem componentMetadataItem3;
          switch (num2)
          {
            case 1:
              str2 = ComponentMetadataHelper.ServerAssemblyName(metadata);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 18 : 27;
              continue;
            case 2:
              goto label_57;
            case 3:
              componentMetadataItem3 = this.componentMetadataItemManager.Create();
              goto label_55;
            case 4:
            case 43:
              componentMetadataItem2 = this.componentMetadataItemManager.Create();
              num2 = 44;
              continue;
            case 5:
              ComponentMetadataPublishingActor.JjZN5JBSupMGDHYKyML0((object) componentMetadataItem2, (object) str2);
              num2 = 26;
              continue;
            case 6:
            case 26:
              ComponentMetadataPublishingActor.typutFBSXH4FXkPf2pT3((object) componentMetadataItem2, ComponentMetadataPublishingActor.Y7795cBSK21gjN8ip1F3(ComponentMetadataPublishingActor.KF6RE5BSqIqMl6RJvUCj((object) componentMetadataItem1), (object) str2));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 19 : 8;
              continue;
            case 7:
              ComponentMetadataItem emulation = header.Emulation;
              if (emulation == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 3 : 0;
                continue;
              }
              componentMetadataItem3 = emulation;
              goto label_55;
            case 8:
              str2 = ComponentMetadataHelperInternal.ServerEmulationAssemblyName(metadata);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 49 : 34;
              continue;
            case 9:
              ComponentMetadataPublishingActor.RGROjwBS1MSyOOFFEb6W((object) header, (object) componentMetadataItem2);
              num2 = 16;
              continue;
            case 10:
              if (!forEmulation)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 43 : 30;
                continue;
              }
              goto case 7;
            case 11:
            case 39:
              if (string.IsNullOrEmpty((string) ComponentMetadataPublishingActor.qya1FwBSI5HOTw9sCQaa((object) componentMetadataItem1)))
              {
                num2 = 32;
                continue;
              }
              goto case 46;
            case 12:
              ComponentMetadataPublishingActor.hqfvOlBSGjH87egGDPAy((object) metadata);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 16 : 37;
              continue;
            case 13:
              if (!forEmulation)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 3 : 29;
                continue;
              }
              goto case 23;
            case 14:
              ComponentMetadataPublishingActor.zuwW7oBSpNqYssBMnlq6((object) header, ComponentMetadataPublishingActor.Jxt35JBS3Lr3koL10iIx((object) metadata));
              num2 = 31;
              continue;
            case 15:
              ComponentMetadataPublishingActor.hmIyeYBSZNGiTk2moeUt((object) componentMetadataItem1, (object) str1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 17 : 35;
              continue;
            case 16:
              ComponentMetadataPublishingActor.zTFcpWBSN7trJBQTBo1I((object) header, false);
              num2 = 14;
              continue;
            case 17:
            case 41:
              ComponentMetadataPublishingActor.wFC31QBS4XClygkhDP6n((object) header);
              num2 = 2;
              continue;
            case 18:
            case 29:
              ComponentMetadataPublishingActor.YIss3WBSOesrml21H2VM((object) session, (object) componentMetadataItem2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 25 : 7;
              continue;
            case 19:
              asmName = ComponentMetadataHelper.ClientAssemblyName(metadata, version2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 33 : 51;
              continue;
            case 20:
              ComponentMetadataPublishingActor.q4TR3mBSTv6HsfPt31Wl((object) componentMetadataItem2, ComponentMetadataPublishingActor.Y7795cBSK21gjN8ip1F3((object) componentMetadataItem1.ViewScriptModule, (object) asmName));
              num2 = 13;
              continue;
            case 21:
              version2 = str1;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 3 : 15;
              continue;
            case 22:
              str1 = new Version(ComponentMetadataPublishingActor.FvLfPLBSV5IeSvK6WYtd((object) version1), ComponentMetadataPublishingActor.Vd0FqeBSSES8LjDom2Za((object) version1), ComponentMetadataPublishingActor.osk0uJBSiKNT2bBVSQBC((object) version1), ComponentMetadataPublishingActor.Da4EtYBSR3ITDY5a3Q56((object) version1) + 1).ToString();
              num2 = 21;
              continue;
            case 23:
              ComponentMetadataPublishingActor.nKCanpBSnHfyJeSopg4Y((object) componentMetadataItem2, ComponentMetadataPublishingActor.Y7795cBSK21gjN8ip1F3(ComponentMetadataPublishingActor.Voa41yBSkTB4jOqyfxkS((object) componentMetadataItem1), (object) asmName));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 4 : 18;
              continue;
            case 24:
              ComponentMetadataPublishingActor.MuVfhVBSwdjgENYLaYBs((object) header, ComponentMetadataPublishingActor.d3WLi4BSteHUbvsgfjbf((object) metadata));
              num2 = 41;
              continue;
            case 25:
              if (forEmulation)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 4 : 38;
                continue;
              }
              goto case 40;
            case 27:
              componentMetadataItem2.AssemblyName = str2;
              num2 = 6;
              continue;
            case 28:
              ComponentMetadataPublishingActor.cVikVrBSe1ijU5Dwg5XL((object) header, (object) componentMetadataItem2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 17 : 6;
              continue;
            case 30:
              metadata = (ComponentMetadata) ClassSerializationHelper.CloneObjectByXml<object>(ComponentMetadataPublishingActor.i0vhLxBShWukpBm8vG61((object) componentMetadataItem1));
              num2 = 12;
              continue;
            case 31:
              ComponentMetadataPublishingActor.kv0Xj7BSDDA60dRSGEId((object) header, ComponentMetadataPublishingActor.gaQuorBSaKwQuv13Evj5((object) metadata));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 24 : 21;
              continue;
            case 32:
              ComponentMetadataPublishingActor.hmIyeYBSZNGiTk2moeUt((object) componentMetadataItem1, (object) version2);
              num3 = 36;
              break;
            case 33:
              user = (IUser) ComponentMetadataPublishingActor.xqIerWBSbRSlnt5Rvp4U((object) this.authenticationService);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 30 : 27;
              continue;
            case 34:
              if (!forEmulation)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 27 : 39;
                continue;
              }
              goto case 8;
            case 35:
            case 36:
              componentMetadataItem2.AssemblyVersion = version2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 1;
              continue;
            case 37:
              ComponentMetadataPublishingActor.Ywr9EOBSEM3UxcEkBmnM((object) metadata);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 6 : 10;
              continue;
            case 38:
              ComponentMetadataPublishingActor.YyqqkwBS2KuYosyRLjCO((object) componentMetadataItem2, true);
              num3 = 28;
              break;
            case 40:
              componentMetadataItem2.VersionNumber = new long?(ComponentMetadataPublishingActor.JSZchkBSPdiY5Ni1NymO((object) this.componentMetadataItemHeaderManager, header.Id));
              num2 = 9;
              continue;
            case 42:
              ComponentMetadataPublishingActor.YP4HK7BSCbCAfgxFC1CJ((object) componentMetadataItem2, ComponentMetadataPublishingActor.lMrdkGBSQXR95wVpG8bI());
              num2 = 47;
              continue;
            case 44:
            case 48:
              ComponentMetadataPublishingActor.fTtMAmBSfBNPZPWToEky((object) componentMetadataItem2, (object) metadata);
              num2 = 42;
              continue;
            case 45:
              version2 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(333888594 ^ 1075625116 ^ 1408952862);
              num2 = 34;
              continue;
            case 46:
              version1 = new Version((string) ComponentMetadataPublishingActor.qya1FwBSI5HOTw9sCQaa((object) componentMetadataItem1));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 13 : 22;
              continue;
            case 47:
              componentMetadataItem2.CreationAuthorId = (long?) (user == null ? (object) null : ComponentMetadataPublishingActor.JMQLdcBSvh50ejK73X5x((object) user));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
              continue;
            case 49:
              ComponentMetadataPublishingActor.hmIyeYBSZNGiTk2moeUt((object) componentMetadataItem2, (object) version2);
              num3 = 5;
              break;
            case 50:
              ComponentMetadataPublishingActor.Xf3AhoBS85GsRBiQeWyR((object) componentMetadataItem2, (object) comment);
              num2 = 45;
              continue;
            case 51:
              componentMetadataItem2.ClientScriptModule = ProcessScriptModule(componentMetadataItem1.ClientScriptModule, asmName);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 20 : 6;
              continue;
            default:
              componentMetadataItem2.Header = header;
              num2 = 50;
              continue;
          }
          num2 = num3;
          continue;
label_55:
          componentMetadataItem2 = componentMetadataItem3;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 48 : 34;
        }
label_57:;
      }
      finally
      {
        int num4;
        if (disposable == null)
          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 2 : 1;
        else
          goto label_62;
label_60:
        switch (num4)
        {
          case 1:
          case 2:
        }
label_62:
        ComponentMetadataPublishingActor.OMElSLBS6UWTbC1dC4hg((object) disposable);
        num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
        {
          num4 = 1;
          goto label_60;
        }
        else
          goto label_60;
      }

      static ScriptModule ProcessScriptModule(ScriptModule scriptModule, string asmName)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (scriptModule == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            default:
              goto label_2;
          }
        }
label_2:
        return (ScriptModule) null;
label_3:
        ScriptModule scriptModule1 = CloneHelperBuilder.Create<ScriptModule>(scriptModule).Clone();
        ComponentMetadataPublishingActor.yWHkRuBSAfEHOpJVAuHs((object) scriptModule1, ComponentMetadataPublishingActor.bh4vScBSHvygwwTWVE5Z());
        scriptModule1.Id = 0L;
        scriptModule1.AssemblyName = asmName;
        return scriptModule1;
      }
    }

    internal static object EZ8ZgIBVc995tXuZcBcy([In] object obj0, Type type) => (object) ((EleWise.ELMA.Logging.ILoggerFactory) obj0).CreateLogger(type);

    internal static bool KXCrCYBVUu6ZQrjOfj8c() => ComponentMetadataPublishingActor.Ue9jOFBVLs3sVl5LlFJ1 == null;

    internal static ComponentMetadataPublishingActor O7fycTBVs8RayBitNGHw() => ComponentMetadataPublishingActor.Ue9jOFBVLs3sVl5LlFJ1;

    internal static AsyncTaskMethodBuilder giN4TaBVzkNmLvQ0ORPp() => AsyncTaskMethodBuilder.Create();

    internal static object UJcyeqBSFd6XSVGf8W3g(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void PaPqHYBSByZKbqvFWaE9([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object wtLTlHBSW9cT9fJFqrdn([In] object obj0, [In] object obj1) => (object) (obj0.ToString() + obj1);

    internal static object rVoqKRBSoTwqWrJJjf9D([In] object obj0) => (object) ((ComponentMetadataItemHeader) obj0).Draft;

    internal static object xqIerWBSbRSlnt5Rvp4U([In] object obj0) => (object) ((IAuthenticationService) obj0).GetCurrentUser();

    internal static object i0vhLxBShWukpBm8vG61([In] object obj0) => ((ComponentMetadataItem) obj0).Metadata;

    internal static void hqfvOlBSGjH87egGDPAy([In] object obj0) => ((ComponentMetadata) obj0).GenerateNewUids();

    internal static void Ywr9EOBSEM3UxcEkBmnM([In] object obj0) => ComponentMetadataItemHeaderManager.UpdateCalculateScriptDynamicProperties((ComponentMetadata) obj0);

    internal static void fTtMAmBSfBNPZPWToEky([In] object obj0, [In] object obj1) => ((ComponentMetadataItem) obj0).Metadata = obj1;

    internal static DateTime lMrdkGBSQXR95wVpG8bI() => DateTime.Now;

    internal static void YP4HK7BSCbCAfgxFC1CJ([In] object obj0, DateTime value) => ((ComponentMetadataItem) obj0).CreationDate = value;

    internal static object JMQLdcBSvh50ejK73X5x([In] object obj0) => ((IIdentified) obj0).GetId();

    internal static void Xf3AhoBS85GsRBiQeWyR([In] object obj0, [In] object obj1) => ((ComponentMetadataItem) obj0).Comment = (string) obj1;

    internal static void hmIyeYBSZNGiTk2moeUt([In] object obj0, [In] object obj1) => ((ComponentMetadataItem) obj0).AssemblyVersion = (string) obj1;

    internal static void JjZN5JBSupMGDHYKyML0([In] object obj0, [In] object obj1) => ((ComponentMetadataItem) obj0).AssemblyName = (string) obj1;

    internal static object qya1FwBSI5HOTw9sCQaa([In] object obj0) => (object) ((ComponentMetadataItem) obj0).AssemblyVersion;

    internal static int FvLfPLBSV5IeSvK6WYtd([In] object obj0) => ((Version) obj0).Major;

    internal static int Vd0FqeBSSES8LjDom2Za([In] object obj0) => ((Version) obj0).Minor;

    internal static int osk0uJBSiKNT2bBVSQBC([In] object obj0) => ((Version) obj0).Build;

    internal static int Da4EtYBSR3ITDY5a3Q56([In] object obj0) => ((Version) obj0).Revision;

    internal static object KF6RE5BSqIqMl6RJvUCj([In] object obj0) => (object) ((ComponentMetadataItem) obj0).ScriptModule;

    internal static object Y7795cBSK21gjN8ip1F3([In] object obj0, [In] object obj1)
    {
      return (object) ProcessScriptModule((ScriptModule) obj0, (string) obj1);

      static ScriptModule ProcessScriptModule(ScriptModule scriptModule, string asmName)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (scriptModule == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            default:
              goto label_2;
          }
        }
label_2:
        return (ScriptModule) null;
label_3:
        ScriptModule scriptModule1 = CloneHelperBuilder.Create<ScriptModule>(scriptModule).Clone();
        ComponentMetadataPublishingActor.yWHkRuBSAfEHOpJVAuHs((object) scriptModule1, ComponentMetadataPublishingActor.bh4vScBSHvygwwTWVE5Z());
        scriptModule1.Id = 0L;
        scriptModule1.AssemblyName = asmName;
        return scriptModule1;
      }
    }

    internal static void typutFBSXH4FXkPf2pT3([In] object obj0, [In] object obj1) => ((ComponentMetadataItem) obj0).ScriptModule = (ScriptModule) obj1;

    internal static void q4TR3mBSTv6HsfPt31Wl([In] object obj0, [In] object obj1) => ((ComponentMetadataItem) obj0).ViewScriptModule = (ScriptModule) obj1;

    internal static object Voa41yBSkTB4jOqyfxkS([In] object obj0) => (object) ((ComponentMetadataItem) obj0).TestScriptModule;

    internal static void nKCanpBSnHfyJeSopg4Y([In] object obj0, [In] object obj1) => ((ComponentMetadataItem) obj0).TestScriptModule = (ScriptModule) obj1;

    internal static object YIss3WBSOesrml21H2VM([In] object obj0, [In] object obj1) => ((ISession) obj0).Save(obj1);

    internal static void YyqqkwBS2KuYosyRLjCO([In] object obj0, bool value) => ((ComponentMetadataItem) obj0).IsEmulation = value;

    internal static void cVikVrBSe1ijU5Dwg5XL([In] object obj0, [In] object obj1) => ((ComponentMetadataItemHeader) obj0).Emulation = (ComponentMetadataItem) obj1;

    internal static long JSZchkBSPdiY5Ni1NymO([In] object obj0, long headerId) => ((IComponentMetadataItemHeaderManager) obj0).GetPublishingVersionNumber(headerId);

    internal static void RGROjwBS1MSyOOFFEb6W([In] object obj0, [In] object obj1) => ((ComponentMetadataItemHeader) obj0).Published = (ComponentMetadataItem) obj1;

    internal static void zTFcpWBSN7trJBQTBo1I([In] object obj0, bool value) => ((ComponentMetadataItemHeader) obj0).IsDirtyItem = value;

    internal static object Jxt35JBS3Lr3koL10iIx([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static void zuwW7oBSpNqYssBMnlq6([In] object obj0, [In] object obj1) => ((ComponentMetadataItemHeader) obj0).Name = (string) obj1;

    internal static object gaQuorBSaKwQuv13Evj5([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;

    internal static void kv0Xj7BSDDA60dRSGEId([In] object obj0, [In] object obj1) => ((ComponentMetadataItemHeader) obj0).DisplayName = (string) obj1;

    internal static object d3WLi4BSteHUbvsgfjbf([In] object obj0) => (object) ((NamedMetadata) obj0).Description;

    internal static void MuVfhVBSwdjgENYLaYBs([In] object obj0, [In] object obj1) => ((ComponentMetadataItemHeader) obj0).Description = (string) obj1;

    internal static void wFC31QBS4XClygkhDP6n([In] object obj0) => ((Entity<long>) obj0).Save();

    internal static void OMElSLBS6UWTbC1dC4hg([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static Guid bh4vScBSHvygwwTWVE5Z() => Guid.NewGuid();

    internal static void yWHkRuBSAfEHOpJVAuHs([In] object obj0, Guid value) => ((ScriptModule) obj0).Uid = value;
  }
}
