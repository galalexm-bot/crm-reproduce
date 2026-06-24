// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.Actors.FunctionMetadataPublishingActor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace EleWise.ELMA.Model.Metadata.Actors
{
  /// <summary>Актор публикации функций</summary>
  internal sealed class FunctionMetadataPublishingActor : 
    Actor,
    IFunctionMetadataPublishingActor,
    IActorWithGuidKey,
    IActor
  {
    private readonly IFunctionMetadataItemHeaderManager functionMetadataItemHeaderManager;
    private readonly ISearchMetadataService searchMetadataService;
    private readonly IDependencyService dependencyService;
    private readonly IFunctionAssemblyBuilderService functionAssemblyBuilderService;
    private readonly IUnitOfWorkManager unitOfWorkManager;
    private readonly ILockManager lockManager;
    private readonly IAuthenticationService authenticationService;
    private readonly IFunctionMetadataItemManager functionMetadataItemManager;
    private readonly ISessionProvider sessionProvider;
    private readonly IServerPlacementPublishService serverPlacementPublishService;
    private readonly ISearchFormServiceInternal searchFormService;
    private readonly ILogger logger;
    private bool publicationStarted;
    private static FunctionMetadataPublishingActor bDQEaybYOa5wILbYkESP;

    /// <summary>Ctor</summary>
    /// <param name="loggerFactory">Фабрика логгеров</param>
    /// <param name="functionMetadataItemHeaderManager">Менеджер заголовков метаданных функций</param>
    /// <param name="searchMetadataService">Сервис поиска метаданных</param>
    /// <param name="dependencyService">Сервис по работе с зависимостями</param>
    /// <param name="functionAssemblyBuilderService">Сервис компиляции глобальных функций</param>
    /// <param name="unitOfWorkManager">Фабрика единиц работы</param>
    /// <param name="lockManager">Менеджер блокировок</param>
    /// <param name="authenticationService">Служба аутентификации системы</param>
    /// <param name="functionMetadataItemManager">Менеджер метаданных функций</param>
    /// <param name="sessionProvider">Провайдер сессий NHibernate</param>
    /// <param name="serverPlacementPublishService">Сервис публикации действия на всех серверах кластера ELMA</param>
    /// <param name="searchFormService">Сервис поиска форм</param>
    public FunctionMetadataPublishingActor(
      EleWise.ELMA.Logging.ILoggerFactory loggerFactory,
      IFunctionMetadataItemHeaderManager functionMetadataItemHeaderManager,
      ISearchMetadataService searchMetadataService,
      IDependencyService dependencyService,
      IFunctionAssemblyBuilderService functionAssemblyBuilderService,
      IUnitOfWorkManager unitOfWorkManager,
      ILockManager lockManager,
      IAuthenticationService authenticationService,
      IFunctionMetadataItemManager functionMetadataItemManager,
      ISessionProvider sessionProvider,
      IServerPlacementPublishService serverPlacementPublishService,
      ISearchFormServiceInternal searchFormService)
    {
      FunctionMetadataPublishingActor.VUg6XAbYPVfMlwcgcKQH();
      this.LifeTime = FunctionMetadataPublishingActor.LTpgaebY1H0YybQA7PWa(1.0);
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 7;
      while (true)
      {
        int num2;
        switch (num1)
        {
          case 1:
            this.lockManager = lockManager;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
            continue;
          case 2:
            this.functionAssemblyBuilderService = functionAssemblyBuilderService;
            num2 = 8;
            break;
          case 3:
            this.searchFormService = searchFormService;
            num1 = 11;
            continue;
          case 4:
            this.dependencyService = dependencyService;
            num1 = 2;
            continue;
          case 5:
            this.searchMetadataService = searchMetadataService;
            num2 = 4;
            break;
          case 6:
            this.serverPlacementPublishService = serverPlacementPublishService;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 3 : 3;
            continue;
          case 7:
            this.functionMetadataItemHeaderManager = functionMetadataItemHeaderManager;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 5;
            continue;
          case 8:
            this.unitOfWorkManager = unitOfWorkManager;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 1 : 1;
            continue;
          case 9:
            this.functionMetadataItemManager = functionMetadataItemManager;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 12 : 9;
            continue;
          case 10:
            goto label_3;
          case 11:
            // ISSUE: type reference
            this.logger = (ILogger) FunctionMetadataPublishingActor.MKqm8PbY3t9L9dj6p2Dm((object) loggerFactory, FunctionMetadataPublishingActor.g5ymyhbYNKQosjA6WlXa(__typeref (FunctionMetadataPublishingActor)));
            num1 = 10;
            continue;
          case 12:
            this.sessionProvider = sessionProvider;
            num1 = 6;
            continue;
          default:
            this.authenticationService = authenticationService;
            num1 = 9;
            continue;
        }
        num1 = num2;
      }
label_3:;
    }

    /// <inheritdoc />
    public override TimeSpan LifeTime { get; }

    /// <inheritdoc />
    public override Task ReceiveReminder(string reminderName)
    {
      int num1 = 5;
      // ISSUE: variable of a compiler-generated type
      FunctionMetadataPublishingActor.\u003CReceiveReminder\u003Ed__20 stateMachine;
      while (true)
      {
        int num2 = num1;
        AsyncTaskMethodBuilder tBuilder;
        while (true)
        {
          switch (num2)
          {
            case 1:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003Et__builder = AsyncTaskMethodBuilder.Create();
              num2 = 6;
              continue;
            case 2:
              // ISSUE: reference to a compiler-generated field
              tBuilder = stateMachine.\u003C\u003Et__builder;
              num2 = 3;
              continue;
            case 3:
              tBuilder.Start<FunctionMetadataPublishingActor.\u003CReceiveReminder\u003Ed__20>(ref stateMachine);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 0;
              continue;
            case 4:
              // ISSUE: reference to a compiler-generated field
              stateMachine.reminderName = reminderName;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 1 : 1;
              continue;
            case 5:
              goto label_6;
            case 6:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003E1__state = -1;
              num2 = 2;
              continue;
            default:
              goto label_7;
          }
        }
label_6:
        // ISSUE: reference to a compiler-generated field
        stateMachine.\u003C\u003E4__this = this;
        num1 = 4;
      }
label_7:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    /// <inheritdoc />
    public Task Publish(string comment)
    {
      int num1 = 3;
      // ISSUE: variable of a compiler-generated type
      FunctionMetadataPublishingActor.\u003CPublish\u003Ed__21 stateMachine;
      while (true)
      {
        int num2 = num1;
        AsyncTaskMethodBuilder tBuilder;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_8;
            case 2:
              // ISSUE: reference to a compiler-generated field
              stateMachine.comment = comment;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 5 : 1;
              continue;
            case 3:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003E4__this = this;
              num2 = 2;
              continue;
            case 4:
              // ISSUE: reference to a compiler-generated field
              tBuilder = stateMachine.\u003C\u003Et__builder;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 2 : 6;
              continue;
            case 5:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003Et__builder = FunctionMetadataPublishingActor.cX2Ek0bYpajA2ZsHkJ4W();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
              continue;
            case 6:
              tBuilder.Start<FunctionMetadataPublishingActor.\u003CPublish\u003Ed__21>(ref stateMachine);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 1 : 1;
              continue;
            default:
              goto label_6;
          }
        }
label_6:
        // ISSUE: reference to a compiler-generated field
        stateMachine.\u003C\u003E1__state = -1;
        num1 = 4;
      }
label_8:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    /// <inheritdoc />
    public Task PublishComplete()
    {
      int num = 4;
      // ISSUE: variable of a compiler-generated type
      FunctionMetadataPublishingActor.\u003CPublishComplete\u003Ed__22 stateMachine;
      AsyncTaskMethodBuilder tBuilder;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_4;
          case 2:
            tBuilder.Start<FunctionMetadataPublishingActor.\u003CPublishComplete\u003Ed__22>(ref stateMachine);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 1 : 0;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003Et__builder = AsyncTaskMethodBuilder.Create();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E4__this = this;
            num = 3;
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated field
            tBuilder = stateMachine.\u003C\u003Et__builder;
            num = 2;
            continue;
          default:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E1__state = -1;
            num = 5;
            continue;
        }
      }
label_4:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    /// <summary>Опубликовать функцию</summary>
    /// <param name="functionMetadataItemHeaderUid">Уникальный идентификатор заголовка функции</param>
    /// <param name="comment">Комментарий при публикации</param>
    private Task PublishInternal(Guid functionMetadataItemHeaderUid, string comment)
    {
      int num1 = 2;
      // ISSUE: variable of a compiler-generated type
      FunctionMetadataPublishingActor.\u003CPublishInternal\u003Ed__23 stateMachine;
      while (true)
      {
        int num2 = num1;
        AsyncTaskMethodBuilder tBuilder;
        while (true)
        {
          switch (num2)
          {
            case 1:
              // ISSUE: reference to a compiler-generated field
              stateMachine.functionMetadataItemHeaderUid = functionMetadataItemHeaderUid;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
              continue;
            case 2:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003E4__this = this;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 1 : 0;
              continue;
            case 3:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003Et__builder = AsyncTaskMethodBuilder.Create();
              num2 = 4;
              continue;
            case 4:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003E1__state = -1;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 1 : 7;
              continue;
            case 5:
              goto label_4;
            case 6:
              goto label_6;
            case 7:
              // ISSUE: reference to a compiler-generated field
              tBuilder = stateMachine.\u003C\u003Et__builder;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 5 : 0;
              continue;
            default:
              // ISSUE: reference to a compiler-generated field
              stateMachine.comment = comment;
              num2 = 3;
              continue;
          }
        }
label_4:
        tBuilder.Start<FunctionMetadataPublishingActor.\u003CPublishInternal\u003Ed__23>(ref stateMachine);
        num1 = 6;
      }
label_6:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    /// <summary>Создать элемент публикации</summary>
    /// <param name="session">Сессия NHibernate</param>
    /// <param name="header">Заголовок метаданных функции</param>
    /// <param name="comment">Комментарий</param>
    private void CreatePublishingItem(
      ISession session,
      FunctionMetadataItemHeader header,
      string comment)
    {
      int num1 = 2;
      IDisposable disposable;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_38;
          case 1:
            disposable = (IDisposable) FunctionMetadataPublishingActor.K07OEFbYt47oNhQhEtL8((object) this.lockManager, FunctionMetadataPublishingActor.d9aM7vbYDy3kHaumAVfY((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461825605 - 1531863589 ^ -70234952), (object) header.Id));
            num1 = 3;
            continue;
          case 2:
            Contract.ArgumentNotNull((object) header, (string) FunctionMetadataPublishingActor.KyUngFbYaEiAmLft9pqu(-97972138 ^ -97927998));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_3;
          default:
            goto label_35;
        }
      }
label_38:
      return;
label_35:
      return;
label_3:
      try
      {
        IUser user = (IUser) FunctionMetadataPublishingActor.qIIxuxbYwi4kB79NusDL((object) this.authenticationService);
        int num2 = 25;
        while (true)
        {
          int num3;
          FunctionMetadataItem functionMetadataItem1;
          FunctionMetadataItem functionMetadataItem2;
          FunctionMetadata metadata;
          string asmName;
          Version version;
          string str;
          switch (num2)
          {
            case 1:
              functionMetadataItem2 = (FunctionMetadataItem) FunctionMetadataPublishingActor.MsogWvbYApTTYSpQRy4r((object) header);
              num2 = 10;
              continue;
            case 2:
            case 18:
              FunctionMetadataPublishingActor.jeNB8hbY9Eou761ptZBo((object) functionMetadataItem1, FunctionMetadataPublishingActor.IS9brobYdPORfBG7ZcOq((object) functionMetadataItem2));
              num2 = 19;
              continue;
            case 3:
              FunctionMetadataPublishingActor.jeNB8hbY9Eou761ptZBo((object) functionMetadataItem2, (object) str);
              num3 = 2;
              break;
            case 4:
              str = new Version(version.Major, FunctionMetadataPublishingActor.c3wZDYbYlo0S81h0bZBj((object) version), FunctionMetadataPublishingActor.T5s5M4bYrNkKyDd5wANG((object) version), version.Revision + 1).ToString();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 2 : 3;
              continue;
            case 5:
              FunctionMetadataPublishingActor.HgpJi4bYLC6XlwCbZvjg((object) header, false);
              num3 = 6;
              break;
            case 6:
              FunctionMetadataPublishingActor.wm1Pw0bYUcJqjjUOqQk6((object) header);
              num2 = 17;
              continue;
            case 7:
              FunctionMetadataPublishingActor.jeNB8hbY9Eou761ptZBo((object) functionMetadataItem2, FunctionMetadataPublishingActor.KyUngFbYaEiAmLft9pqu(-342626196 - 1290888215 ^ -1633524091));
              num2 = 18;
              continue;
            case 8:
              FunctionMetadataPublishingActor.wo1QLNbYmiqGKpLown8w((object) header, FunctionMetadataPublishingActor.oQuR0rbY0GG59mu4YbDL((object) metadata));
              num2 = 13;
              continue;
            case 9:
              FunctionMetadataPublishingActor.UTsUkBbY5K6vNBxQey9J((object) functionMetadataItem1, (object) asmName);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 26 : 25;
              continue;
            case 10:
              metadata = (FunctionMetadata) functionMetadataItem2.Metadata;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 11 : 3;
              continue;
            case 11:
              FunctionMetadataPublishingActor.sLZDWubYx1uEKRRMYnD6((object) header, FunctionMetadataPublishingActor.ztjhEObY7fNKjNT0KVeI((object) metadata));
              num3 = 8;
              break;
            case 12:
              functionMetadataItem1.VersionNumber = new long?(FunctionMetadataPublishingActor.CiPIOpbYHL9AmPLBWcto((object) this.functionMetadataItemHeaderManager, header.Id));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 1;
              continue;
            case 13:
              header.Description = (string) FunctionMetadataPublishingActor.yphgPsbYyAIRYEdEstYT((object) metadata);
              num2 = 16;
              continue;
            case 14:
              functionMetadataItem1.Header = header;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 0;
              continue;
            case 15:
            case 21:
              version = new Version((string) FunctionMetadataPublishingActor.IS9brobYdPORfBG7ZcOq((object) functionMetadataItem2));
              num2 = 4;
              continue;
            case 16:
              FunctionMetadataPublishingActor.CndWc9bYMldAhD5ONJje((object) functionMetadataItem1, (object) metadata);
              num2 = 22;
              continue;
            case 17:
              goto label_31;
            case 19:
              asmName = (string) FunctionMetadataPublishingActor.rAKwobbYgAD8sMijZ8v3((object) metadata);
              num2 = 9;
              continue;
            case 20:
              session.Save((object) functionMetadataItem1);
              num3 = 23;
              break;
            case 22:
              if (!FunctionMetadataPublishingActor.w7d2OnbYJtC4hw53UK5R((object) functionMetadataItem2.AssemblyVersion))
              {
                num2 = 15;
                continue;
              }
              goto case 7;
            case 23:
              FunctionMetadataPublishingActor.Omm139bYYLEih0DlpsiH((object) header, (object) functionMetadataItem1);
              num2 = 5;
              continue;
            case 24:
              functionMetadataItem1.CreationAuthorId = (long?) (user != null ? FunctionMetadataPublishingActor.YNajM4bY44ieP4ZZhnsS((object) user) : (object) null);
              num2 = 14;
              continue;
            case 25:
              functionMetadataItem1 = this.functionMetadataItemManager.Create();
              num2 = 24;
              continue;
            case 26:
              FunctionMetadataPublishingActor.v0qcUZbYjQv0V6knRuKx((object) functionMetadataItem1, (object) ProcessScriptModule(functionMetadataItem2.ScriptModule, asmName));
              num3 = 20;
              break;
            default:
              FunctionMetadataPublishingActor.I4hytWbY6dOnT7LFmRdV((object) functionMetadataItem1, (object) comment);
              num2 = 12;
              continue;
          }
          num2 = num3;
        }
label_31:;
      }
      finally
      {
        int num4;
        if (disposable == null)
          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 0;
        else
          goto label_36;
label_34:
        switch (num4)
        {
          case 2:
            break;
          default:
        }
label_36:
        disposable.Dispose();
        num4 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
        {
          num4 = 0;
          goto label_34;
        }
        else
          goto label_34;
      }

      static ScriptModule ProcessScriptModule(ScriptModule scriptModule, string asmName)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (scriptModule != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_2;
            default:
              goto label_3;
          }
        }
label_2:
        return (ScriptModule) null;
label_3:
        ScriptModule scriptModule1 = CloneHelperBuilder.Create<ScriptModule>(scriptModule).Clone();
        FunctionMetadataPublishingActor.deMQErbYcxFMsZaqs0MP((object) scriptModule1, FunctionMetadataPublishingActor.HkYtD7bYsWnCHuZINQ44());
        scriptModule1.Id = 0L;
        FunctionMetadataPublishingActor.met2M5bYzwHJapILaqUI((object) scriptModule1, (object) asmName);
        return scriptModule1;
      }
    }

    internal static void VUg6XAbYPVfMlwcgcKQH() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static TimeSpan LTpgaebY1H0YybQA7PWa([In] double obj0) => TimeSpan.FromHours(obj0);

    internal static Type g5ymyhbYNKQosjA6WlXa([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object MKqm8PbY3t9L9dj6p2Dm([In] object obj0, Type type) => (object) ((EleWise.ELMA.Logging.ILoggerFactory) obj0).CreateLogger(type);

    internal static bool he0KOPbY2I3b9WkKqWhG() => FunctionMetadataPublishingActor.bDQEaybYOa5wILbYkESP == null;

    internal static FunctionMetadataPublishingActor q77dKNbYeR16mRorKTVK() => FunctionMetadataPublishingActor.bDQEaybYOa5wILbYkESP;

    internal static AsyncTaskMethodBuilder cX2Ek0bYpajA2ZsHkJ4W() => AsyncTaskMethodBuilder.Create();

    internal static object KyUngFbYaEiAmLft9pqu(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object d9aM7vbYDy3kHaumAVfY([In] object obj0, [In] object obj1) => (object) (obj0.ToString() + obj1);

    internal static object K07OEFbYt47oNhQhEtL8([In] object obj0, [In] object obj1) => (object) ((ILockManager) obj0).Lock((string) obj1);

    internal static object qIIxuxbYwi4kB79NusDL([In] object obj0) => (object) ((IAuthenticationService) obj0).GetCurrentUser();

    internal static object YNajM4bY44ieP4ZZhnsS([In] object obj0) => ((IIdentified) obj0).GetId();

    internal static void I4hytWbY6dOnT7LFmRdV([In] object obj0, [In] object obj1) => ((FunctionMetadataItem) obj0).Comment = (string) obj1;

    internal static long CiPIOpbYHL9AmPLBWcto([In] object obj0, long headerId) => ((IFunctionMetadataItemHeaderManager) obj0).GetPublishingVersionNumber(headerId);

    internal static object MsogWvbYApTTYSpQRy4r([In] object obj0) => (object) ((FunctionMetadataItemHeader) obj0).Draft;

    internal static object ztjhEObY7fNKjNT0KVeI([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static void sLZDWubYx1uEKRRMYnD6([In] object obj0, [In] object obj1) => ((FunctionMetadataItemHeader) obj0).Name = (string) obj1;

    internal static object oQuR0rbY0GG59mu4YbDL([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;

    internal static void wo1QLNbYmiqGKpLown8w([In] object obj0, [In] object obj1) => ((FunctionMetadataItemHeader) obj0).DisplayName = (string) obj1;

    internal static object yphgPsbYyAIRYEdEstYT([In] object obj0) => (object) ((NamedMetadata) obj0).Description;

    internal static void CndWc9bYMldAhD5ONJje([In] object obj0, [In] object obj1) => ((FunctionMetadataItem) obj0).Metadata = obj1;

    internal static bool w7d2OnbYJtC4hw53UK5R([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static void jeNB8hbY9Eou761ptZBo([In] object obj0, [In] object obj1) => ((FunctionMetadataItem) obj0).AssemblyVersion = (string) obj1;

    internal static object IS9brobYdPORfBG7ZcOq([In] object obj0) => (object) ((FunctionMetadataItem) obj0).AssemblyVersion;

    internal static int c3wZDYbYlo0S81h0bZBj([In] object obj0) => ((Version) obj0).Minor;

    internal static int T5s5M4bYrNkKyDd5wANG([In] object obj0) => ((Version) obj0).Build;

    internal static object rAKwobbYgAD8sMijZ8v3([In] object obj0) => (object) FunctionMetadataHelper.ServerAssemblyName((FunctionMetadata) obj0);

    internal static void UTsUkBbY5K6vNBxQey9J([In] object obj0, [In] object obj1) => ((FunctionMetadataItem) obj0).AssemblyName = (string) obj1;

    internal static void v0qcUZbYjQv0V6knRuKx([In] object obj0, [In] object obj1) => ((FunctionMetadataItem) obj0).ScriptModule = (ScriptModule) obj1;

    internal static void Omm139bYYLEih0DlpsiH([In] object obj0, [In] object obj1) => ((FunctionMetadataItemHeader) obj0).Published = (FunctionMetadataItem) obj1;

    internal static void HgpJi4bYLC6XlwCbZvjg([In] object obj0, bool value) => ((FunctionMetadataItemHeader) obj0).IsDirtyItem = value;

    internal static void wm1Pw0bYUcJqjjUOqQk6([In] object obj0) => ((Entity<long>) obj0).Save();

    internal static Guid HkYtD7bYsWnCHuZINQ44() => Guid.NewGuid();

    internal static void deMQErbYcxFMsZaqs0MP([In] object obj0, Guid value) => ((ScriptModule) obj0).Uid = value;

    internal static void met2M5bYzwHJapILaqUI([In] object obj0, [In] object obj1) => ((ScriptModule) obj0).AssemblyName = (string) obj1;
  }
}
