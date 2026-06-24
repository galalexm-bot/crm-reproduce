// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.Actors.DataClassMetadataPublishingActorBase
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.UI.Models;
using EleWise.ELMA.UI.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace EleWise.ELMA.Model.Metadata.Actors
{
  /// <summary>Базовый актор публикации датаклассов</summary>
  internal abstract class DataClassMetadataPublishingActorBase : Actor
  {
    private readonly ICheckDataClassService checkDataClassService;
    private readonly ISearchMetadataService searchMetadataService;
    private readonly IDataClassAssemblyBuilderService dataClassAssemblyBuilderService;
    private readonly IDataClassMetadataItemManager dataClassMetadataItemManager;
    private readonly IDataClassMetadataItemHeaderManager dataClassMetadataItemHeaderManager;
    private readonly IDataClassTypeReferenceManager dataClassTypeReferenceManager;
    private readonly ISessionProvider sessionProvider;
    private readonly IUnitOfWorkManager unitOfWorkManager;
    private readonly IServerPlacementPublishService serverPlacementPublishService;
    private readonly ISearchFormServiceInternal searchFormService;
    private readonly ILogger logger;
    /// <summary>Название ремайндера</summary>
    protected const string ReminderName = "DataClassMetadataPublishingActorBase";
    /// <summary>Токен публикации</summary>
    protected Guid? PublicationToken;
    private static DataClassMetadataPublishingActorBase OhlOYMbjwws8JCgvr5Zt;

    /// <summary>Ctor</summary>
    /// <param name="logger">Логгер</param>
    /// <param name="dataClassMetadataItemHeaderManager">Менеджер заголовков метаданных датаклассов</param>
    /// <param name="checkDataClassService">Сервис проверки метаданных датакласса</param>
    /// <param name="searchMetadataService">Сервис поиска метаданных</param>
    /// <param name="dataClassAssemblyBuilderService">Сервис по публикации глобальных DataClass</param>
    /// <param name="dataClassMetadataItemManager">Менеджер метаданных датаклассов</param>
    /// <param name="dataClassTypeReferenceManager">Интерфейса менеджера ссылки типа DTO</param>
    /// <param name="sessionProvider">Провайдер сессий NHibernate</param>
    /// <param name="unitOfWorkManager">Фабрика единиц работ</param>
    /// <param name="serverPlacementPublishService">Сервис публикации действия на всех серверах кластера ELMA</param>
    /// <param name="searchFormService">Сервис поиска форм</param>
    protected DataClassMetadataPublishingActorBase(
      ILogger logger,
      IDataClassMetadataItemHeaderManager dataClassMetadataItemHeaderManager,
      ICheckDataClassService checkDataClassService,
      ISearchMetadataService searchMetadataService,
      IDataClassAssemblyBuilderService dataClassAssemblyBuilderService,
      IDataClassMetadataItemManager dataClassMetadataItemManager,
      IDataClassTypeReferenceManager dataClassTypeReferenceManager,
      ISessionProvider sessionProvider,
      IUnitOfWorkManager unitOfWorkManager,
      IServerPlacementPublishService serverPlacementPublishService,
      ISearchFormServiceInternal searchFormService)
    {
      DataClassMetadataPublishingActorBase.lZBNBObjHIMMkkfXMVVc();
      this.LifeTime = DataClassMetadataPublishingActorBase.npIkRkbjAPoGWXpQXJo4(1.0);
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 9;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.dataClassTypeReferenceManager = dataClassTypeReferenceManager;
            num = 5;
            continue;
          case 2:
            this.searchFormService = searchFormService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 0 : 0;
            continue;
          case 3:
            goto label_2;
          case 4:
            this.dataClassMetadataItemManager = dataClassMetadataItemManager;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 1 : 0;
            continue;
          case 5:
            this.sessionProvider = sessionProvider;
            num = 6;
            continue;
          case 6:
            this.unitOfWorkManager = unitOfWorkManager;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 7 : 3;
            continue;
          case 7:
            this.serverPlacementPublishService = serverPlacementPublishService;
            num = 2;
            continue;
          case 8:
            this.checkDataClassService = checkDataClassService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 11 : 11;
            continue;
          case 9:
            this.logger = logger;
            num = 8;
            continue;
          case 10:
            this.dataClassAssemblyBuilderService = dataClassAssemblyBuilderService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 4 : 0;
            continue;
          case 11:
            this.searchMetadataService = searchMetadataService;
            num = 10;
            continue;
          default:
            this.dataClassMetadataItemHeaderManager = dataClassMetadataItemHeaderManager;
            num = 3;
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
      int num1 = 1;
      // ISSUE: variable of a compiler-generated type
      DataClassMetadataPublishingActorBase.\u003CReceiveReminder\u003Ed__17 stateMachine;
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
              stateMachine.\u003C\u003E4__this = this;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_4;
            case 3:
              // ISSUE: reference to a compiler-generated field
              tBuilder = stateMachine.\u003C\u003Et__builder;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 2 : 1;
              continue;
            case 4:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003Et__builder = DataClassMetadataPublishingActorBase.yBF6Ufbj75wWu8BwclmC();
              num2 = 6;
              continue;
            case 5:
              goto label_7;
            case 6:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003E1__state = -1;
              num2 = 3;
              continue;
            default:
              // ISSUE: reference to a compiler-generated field
              stateMachine.reminderName = reminderName;
              num2 = 4;
              continue;
          }
        }
label_4:
        tBuilder.Start<DataClassMetadataPublishingActorBase.\u003CReceiveReminder\u003Ed__17>(ref stateMachine);
        num1 = 5;
      }
label_7:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    /// <summary>Опубликовать датакласс</summary>
    /// <param name="comment">Комментарий</param>
    /// <param name="dataClassMetadataItemHeadersUid">Уникальные идентификаторы заголовков метаданных датакласса</param>
    protected Task PublishInternal(string comment, Guid[] dataClassMetadataItemHeadersUid)
    {
      int num = 1;
      // ISSUE: variable of a compiler-generated type
      DataClassMetadataPublishingActorBase.\u003CPublishInternal\u003Ed__18 stateMachine;
      AsyncTaskMethodBuilder tBuilder;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E4__this = this;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            stateMachine.dataClassMetadataItemHeadersUid = dataClassMetadataItemHeadersUid;
            num = 7;
            continue;
          case 3:
            tBuilder.Start<DataClassMetadataPublishingActorBase.\u003CPublishInternal\u003Ed__18>(ref stateMachine);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 5 : 0;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated field
            tBuilder = stateMachine.\u003C\u003Et__builder;
            num = 3;
            continue;
          case 5:
            goto label_5;
          case 6:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E1__state = -1;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 4 : 3;
            continue;
          case 7:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003Et__builder = DataClassMetadataPublishingActorBase.yBF6Ufbj75wWu8BwclmC();
            num = 6;
            continue;
          default:
            // ISSUE: reference to a compiler-generated field
            stateMachine.comment = comment;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 2 : 0;
            continue;
        }
      }
label_5:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    /// <summary>Опубликовать датакласс</summary>
    /// <param name="comment">Комментарий</param>
    /// <param name="dataClassMetadataItemHeadersUid">Уникальные идентификаторы заголовков метаданных датакласса</param>
    /// <param name="dataClassMetadataItemHeaderManager">Менеджер заголовков метаданных датаклассов</param>
    /// <param name="checkDataClassService">Сервис проверки метаданных датакласса</param>
    /// <param name="searchMetadataService">Сервис поиска метаданных</param>
    /// <param name="dataClassAssemblyBuilderService">Сервис по публикации глобальных DataClass</param>
    /// <param name="dataClassMetadataItemManager">Менеджер метаданных датаклассов</param>
    /// <param name="dataClassTypeReferenceManager">Интерфейса менеджера ссылки типа DTO</param>
    /// <param name="sessionProvider">Провайдер сессий NHibernate</param>
    /// <param name="unitOfWorkManager">Фабрика единиц работ</param>
    internal static UIMetadataPublishResult PublishInternal(
      string comment,
      Guid[] dataClassMetadataItemHeadersUid,
      IUnitOfWorkManager unitOfWorkManager,
      IDataClassMetadataItemHeaderManager dataClassMetadataItemHeaderManager,
      IDataClassMetadataItemManager dataClassMetadataItemManager,
      IDataClassTypeReferenceManager dataClassTypeReferenceManager,
      IDataClassAssemblyBuilderService dataClassAssemblyBuilderService,
      ICheckDataClassService checkDataClassService,
      ISearchMetadataService searchMetadataService,
      ISessionProvider sessionProvider)
    {
      int num1 = 5;
      // ISSUE: variable of a compiler-generated type
      DataClassMetadataPublishingActorBase.\u003C\u003Ec__DisplayClass19_0 cDisplayClass190;
      IUnitOfWork unitOfWork;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_6;
          case 2:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass190.dataClassMetadataItemManager = dataClassMetadataItemManager;
            num1 = 3;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass190.dataClassTypeReferenceManager = dataClassTypeReferenceManager;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 6 : 4;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass190.dataClassMetadataItemHeaderManager = dataClassMetadataItemHeaderManager;
            num1 = 2;
            continue;
          case 5:
            // ISSUE: object of a compiler-generated type is created
            cDisplayClass190 = new DataClassMetadataPublishingActorBase.\u003C\u003Ec__DisplayClass19_0();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 2 : 4;
            continue;
          case 6:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass190.comment = comment;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 7 : 3;
            continue;
          case 7:
            unitOfWork = unitOfWorkManager.Create("", true, IsolationLevel.ReadCommitted);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 0 : 0;
            continue;
          default:
            goto label_8;
        }
      }
label_6:
      UIMetadataPublishResult metadataPublishResult1;
      return metadataPublishResult1;
label_8:
      try
      {
        HashSet<Guid> guidSet = new HashSet<Guid>();
        int num2 = 31;
        Guid uid;
        while (true)
        {
          int num3;
          UIMetadataPublishResult metadataPublishResult2;
          // ISSUE: variable of a compiler-generated type
          DataClassMetadataPublishingActorBase.\u003C\u003Ec__DisplayClass19_1 cDisplayClass191;
          DataClassMetadataItemHeader metadataItemHeader;
          ValidationResult validationResult;
          Guid[] guidArray;
          int index1;
          DataClassMetadataItem classMetadataItem1;
          DataClassBuildAssemblyModel buildAssemblyModel;
          MetadataServiceContext metadataServiceContext;
          DataClassMetadataItem[] array;
          Dictionary<Guid, DataClassMetadataItem>.KeyCollection.Enumerator enumerator;
          int index2;
          DataClassMetadataItem[] classMetadataItemArray;
          Dictionary<Guid, DataClassMetadataItem> cache;
          DataClassMetadataItem classMetadataItem2;
          switch (num2)
          {
            case 1:
              index1 = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 23 : 4;
              continue;
            case 2:
              metadataPublishResult2.Errors.AddRange((IEnumerable<ValidationError>) DataClassMetadataPublishingActorBase.veOQUIbj9bA2AL5e1UK3((object) validationResult));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 14;
              continue;
            case 3:
label_61:
              // ISSUE: reference to a compiler-generated field
              DataClassMetadataPublishingActorBase.mqw4IXbjrvyytn2N0yoP((object) cDisplayClass191.session);
              num3 = 32;
              break;
            case 4:
              DataClassMetadataPublishingActorBase.xNfGFFbj5QFQUB8frtLs((object) unitOfWork);
              num2 = 20;
              continue;
            case 5:
              if (!DataClassMetadataPublishingActorBase.yRgIWAbjJAj2RxFWNfG3((object) validationResult))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 2 : 1;
                continue;
              }
              goto case 27;
            case 6:
              if (guidSet.Contains(uid))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 11 : 19;
                continue;
              }
              goto case 39;
            case 7:
            case 11:
              if (index2 >= classMetadataItemArray.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 0;
                continue;
              }
              goto case 16;
            case 8:
              classMetadataItem1 = (DataClassMetadataItem) DataClassMetadataPublishingActorBase.tHd7t2bjxiyV6kp2sSb3((object) metadataItemHeader);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 36 : 36;
              continue;
            case 9:
              if (metadataItemHeader != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 4 : 8;
                continue;
              }
              goto label_20;
            case 10:
              goto label_20;
            case 12:
              uid = guidArray[index1];
              num2 = 26;
              continue;
            case 13:
              try
              {
label_40:
                if (enumerator.MoveNext())
                  goto label_38;
                else
                  goto label_41;
label_35:
                Guid current;
                int num4;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      guidSet.Add(current);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 2 : 2;
                      continue;
                    case 2:
                      goto label_40;
                    case 3:
                      goto label_70;
                    default:
                      goto label_38;
                  }
                }
label_38:
                current = enumerator.Current;
                num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
                {
                  num4 = 1;
                  goto label_35;
                }
                else
                  goto label_35;
label_41:
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 3 : 1;
                goto label_35;
              }
              finally
              {
                enumerator.Dispose();
                int num5 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
                  num5 = 0;
                switch (num5)
                {
                  default:
                }
              }
            case 14:
              metadataPublishResult1 = metadataPublishResult2;
              num2 = 18;
              continue;
            case 15:
              validationResult = (ValidationResult) DataClassMetadataPublishingActorBase.SE4jbEbjMXfNZKfdYvxW((object) checkDataClassService, (object) (DataClassMetadata) DataClassMetadataPublishingActorBase.W6LLkLbjypk39JY6VCiG((object) classMetadataItem2));
              num3 = 5;
              break;
            case 16:
              classMetadataItem2 = classMetadataItemArray[index2];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 14 : 15;
              continue;
            case 17:
label_70:
              // ISSUE: reference to a compiler-generated method
              array = cache.Values.Select<DataClassMetadataItem, DataClassMetadataItem>(new System.Func<DataClassMetadataItem, DataClassMetadataItem>(cDisplayClass191.\u003CPublishInternal\u003Eb__0)).ToArray<DataClassMetadataItem>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 25 : 1;
              continue;
            case 18:
            case 28:
              goto label_6;
            case 19:
            case 24:
              ++index1;
              num2 = 34;
              continue;
            case 20:
              metadataPublishResult1 = metadataPublishResult2;
              num3 = 28;
              break;
            case 21:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass191.CS\u0024\u003C\u003E8__locals1 = cDisplayClass190;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 3 : 6;
              continue;
            case 22:
              cache = new Dictionary<Guid, DataClassMetadataItem>();
              num2 = 30;
              continue;
            case 23:
            case 34:
              if (index1 >= guidArray.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 4 : 2;
                continue;
              }
              goto case 12;
            case 25:
              classMetadataItemArray = array;
              num2 = 37;
              continue;
            case 26:
              // ISSUE: object of a compiler-generated type is created
              cDisplayClass191 = new DataClassMetadataPublishingActorBase.\u003C\u003Ec__DisplayClass19_1();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 21;
              continue;
            case 27:
              ++index2;
              num2 = 11;
              continue;
            case 29:
              goto label_67;
            case 30:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              DataClassMetadataPublishingActorBase.GetNotPublishedItems((object) cDisplayClass191.CS\u0024\u003C\u003E8__locals1.dataClassMetadataItemHeaderManager, (object) classMetadataItem1, cache, uid);
              num2 = 38;
              continue;
            case 31:
              metadataPublishResult2 = new UIMetadataPublishResult();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 24 : 35;
              continue;
            case 32:
              metadataPublishResult2.ItemUid = DataClassMetadataPublishingActorBase.XdqQH7bjgSQXB7B787l6((object) array[0]);
              num2 = 24;
              continue;
            case 33:
              try
              {
                DataClassMetadataPublishingActorBase.SQw3GZbjd5dxLVPvrtOj((object) dataClassAssemblyBuilderService, (object) buildAssemblyModel);
                int num6 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
                  num6 = 0;
                switch (num6)
                {
                  default:
                    goto label_61;
                }
              }
              finally
              {
                int num7;
                if (metadataServiceContext == null)
                  num7 = 2;
                else
                  goto label_28;
label_27:
                switch (num7)
                {
                  case 1:
                    break;
                  default:
                }
label_28:
                DataClassMetadataPublishingActorBase.LFw4lWbjl4EKejsab8Et((object) metadataServiceContext);
                num7 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
                {
                  num7 = 0;
                  goto label_27;
                }
                else
                  goto label_27;
              }
            case 35:
              guidArray = dataClassMetadataItemHeadersUid;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 1 : 1;
              continue;
            case 36:
              if (classMetadataItem1 == null)
              {
                num2 = 29;
                continue;
              }
              // ISSUE: reference to a compiler-generated field
              cDisplayClass191.session = (ISession) DataClassMetadataPublishingActorBase.v3m4Plbjmv80ANHr1Cyx((object) sessionProvider, (object) "");
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 15 : 22;
              continue;
            case 37:
              index2 = 0;
              num3 = 7;
              break;
            case 38:
              enumerator = cache.Keys.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 4 : 13;
              continue;
            case 39:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              metadataItemHeader = cDisplayClass191.CS\u0024\u003C\u003E8__locals1.dataClassMetadataItemHeaderManager.LoadOrNull(uid);
              num2 = 9;
              continue;
            default:
              List<DataClassMetadata> list1 = searchMetadataService.GetPublishedDataClasses().ToList<DataClassMetadata>();
              List<DataClassAssemblyInfo> list2 = searchMetadataService.GetPublishedDataClassAssemblies().ToList<DataClassAssemblyInfo>();
              DataClassMetadataItem[] items = array;
              List<DataClassAssemblyInfo> source1 = list2;
              // ISSUE: reference to a compiler-generated field
              System.Func<DataClassAssemblyInfo, byte[]> func1 = DataClassMetadataPublishingActorBase.\u003C\u003Ec.\u003C\u003E9__19_1;
              System.Func<DataClassAssemblyInfo, byte[]> selector1;
              if (func1 == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                DataClassMetadataPublishingActorBase.\u003C\u003Ec.\u003C\u003E9__19_1 = selector1 = (System.Func<DataClassAssemblyInfo, byte[]>) (a => (byte[]) DataClassMetadataPublishingActorBase.\u003C\u003Ec.rlTYOdCmD9uym6SZDJk6((object) a));
              }
              else
                goto label_36;
label_75:
              IEnumerable<byte[]> assemblies = source1.Select<DataClassAssemblyInfo, byte[]>(selector1);
              List<DataClassAssemblyInfo> source2 = list2;
              // ISSUE: reference to a compiler-generated field
              System.Func<DataClassAssemblyInfo, byte[]> func2 = DataClassMetadataPublishingActorBase.\u003C\u003Ec.\u003C\u003E9__19_2;
              System.Func<DataClassAssemblyInfo, byte[]> selector2;
              if (func2 == null)
              {
                // ISSUE: reference to a compiler-generated field
                DataClassMetadataPublishingActorBase.\u003C\u003Ec.\u003C\u003E9__19_2 = selector2 = (System.Func<DataClassAssemblyInfo, byte[]>) (a => a.ClientAssemblyRaw);
              }
              else
                goto label_42;
label_77:
              IEnumerable<byte[]> clientAssemblies = source2.Select<DataClassAssemblyInfo, byte[]>(selector2);
              buildAssemblyModel = new DataClassBuildAssemblyModel(items, assemblies, clientAssemblies);
              metadataServiceContext = MetadataServiceContext.Extend((IEnumerable<IMetadata>) list1);
              num2 = 33;
              continue;
label_42:
              selector2 = func2;
              goto label_77;
label_36:
              selector1 = func1;
              goto label_75;
          }
          num2 = num3;
        }
label_20:
        throw new Exception(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1204263869 ^ -1341583247 ^ 137524442), (object) uid));
label_67:
        throw new Exception(EleWise.ELMA.SR.T((string) DataClassMetadataPublishingActorBase.zSJX6Zbj007hv8Q9SGFa(-218496594 ^ -218562536), (object) uid));
      }
      catch (Exception ex)
      {
        int num8 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0)
          num8 = 0;
        while (true)
        {
          switch (num8)
          {
            case 1:
              DataClassMetadataPublishingActorBase.oDnHnqbjj1lNtxqgdpVM((object) unitOfWork);
              num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
              continue;
            default:
              goto label_82;
          }
        }
label_82:
        throw;
      }
      finally
      {
        if (unitOfWork != null)
        {
          int num9 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
            num9 = 1;
          while (true)
          {
            switch (num9)
            {
              case 1:
                DataClassMetadataPublishingActorBase.LFw4lWbjl4EKejsab8Et((object) unitOfWork);
                num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 0 : 0;
                continue;
              default:
                goto label_88;
            }
          }
        }
label_88:;
      }
    }

    /// <summary>Завершить публиацию</summary>
    /// <returns></returns>
    protected Task Complete()
    {
      int num1 = 2;
      // ISSUE: variable of a compiler-generated type
      DataClassMetadataPublishingActorBase.\u003CComplete\u003Ed__20 stateMachine;
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
              stateMachine.\u003C\u003Et__builder = DataClassMetadataPublishingActorBase.yBF6Ufbj75wWu8BwclmC();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 3 : 0;
              continue;
            case 2:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003E4__this = this;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 1;
              continue;
            case 3:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003E1__state = -1;
              num2 = 4;
              continue;
            case 4:
              goto label_3;
            case 5:
              tBuilder.Start<DataClassMetadataPublishingActorBase.\u003CComplete\u003Ed__20>(ref stateMachine);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 0;
              continue;
            default:
              goto label_5;
          }
        }
label_3:
        // ISSUE: reference to a compiler-generated field
        tBuilder = stateMachine.\u003C\u003Et__builder;
        num1 = 5;
      }
label_5:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    private static void GetNotPublishedItems(
      object dataClassMetadataItemHeaderManager,
      object item,
      Dictionary<Guid, DataClassMetadataItem> cache,
      params Guid[] publishingItems)
    {
      if (cache.ContainsKey(((DataClassMetadataItem) item).Header.Uid))
        return;
      cache[((DataClassMetadataItem) item).Header.Uid] = (DataClassMetadataItem) item;
      foreach (PropertyMetadata property in ((ClassMetadata) ((DataClassMetadataItem) item).Metadata).Properties)
      {
        if (!(property.TypeUid != DataClassDescriptor.UID))
        {
          DataClassMetadataItemHeader header = ((IEntityManager<DataClassMetadataItemHeader>) dataClassMetadataItemHeaderManager).LoadOrNull(property.SubTypeUid);
          // ISSUE: reference to a compiler-generated method
          if (header != null && (header.Published == null || Array.Exists<Guid>(publishingItems, (Predicate<Guid>) (uid => uid == DataClassMetadataPublishingActorBase.\u003C\u003Ec__DisplayClass21_0.bxcCjVCmMIvFK2e5aFK6((object) header)))))
            DataClassMetadataPublishingActorBase.GetNotPublishedItems(dataClassMetadataItemHeaderManager, (object) header.Draft, cache, publishingItems);
        }
      }
    }

    private static void CreatePublishingItem(
      object dataClassMetadataItemHeaderManager,
      object dataClassMetadataItemManager,
      object dataClassTypeReferenceManager,
      object session,
      object item,
      object comment)
    {
      int num1 = 10;
      while (true)
      {
        int num2 = num1;
        string str;
        DataClassMetadataItem classMetadataItem;
        DataClassMetadata dataClassMetadata;
        Version version;
        DataClassTypeReference classTypeReference1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              DataClassMetadataPublishingActorBase.IwuDsdbYEKM1qrotiXrZ(item, (object) str);
              num2 = 23;
              continue;
            case 2:
              if (!DataClassMetadataPublishingActorBase.tIA5DKbYGwLBUyKe0o81(DataClassMetadataPublishingActorBase.vbjGbGbYhx1A9jEtb75P(item)))
              {
                num2 = 21;
                continue;
              }
              goto case 13;
            case 3:
            case 16:
              goto label_24;
            case 4:
              DataClassMetadataPublishingActorBase.yoDeVLbYZ2xTeHX0Uc1Y(DataClassMetadataPublishingActorBase.DOq3SEbYB9pduxUtBMLq(item), DataClassMetadataPublishingActorBase.cdvX9AbY8uAl0gJifHx0((object) dataClassMetadata));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 6 : 1;
              continue;
            case 5:
              goto label_27;
            case 6:
              ((DataClassMetadataItemHeader) DataClassMetadataPublishingActorBase.DOq3SEbYB9pduxUtBMLq(item)).DisplayName = dataClassMetadata.DisplayName;
              num2 = 28;
              continue;
            case 7:
              DataClassMetadataPublishingActorBase.pvuuXPbYWSw2o9dvvJqR((object) classMetadataItem, DataClassMetadataPublishingActorBase.DOq3SEbYB9pduxUtBMLq(item));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 23 : 26;
              continue;
            case 8:
              DataClassTypeReference classTypeReference2 = new DataClassTypeReference();
              DataClassMetadataPublishingActorBase.gjr2vDbjLcBWmlDDtmp5((object) classTypeReference2, DataClassMetadataPublishingActorBase.nSQb4ZbjYe0sUVDKYagO((object) dataClassMetadata));
              classTypeReference2.ItemUid = DataClassMetadataPublishingActorBase.XdqQH7bjgSQXB7B787l6((object) classMetadataItem);
              classTypeReference1 = classTypeReference2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 24;
              continue;
            case 9:
              classMetadataItem = ((IEntityManager<DataClassMetadataItem>) dataClassMetadataItemManager).Create();
              num2 = 8;
              continue;
            case 10:
              dataClassMetadata = (DataClassMetadata) DataClassMetadataPublishingActorBase.W6LLkLbjypk39JY6VCiG(item);
              num2 = 9;
              continue;
            case 11:
              classMetadataItem.VersionNumber = new long?(DataClassMetadataPublishingActorBase.RFZmGwbYbgbmoZJUKmF9(dataClassMetadataItemHeaderManager, ((Entity<long>) DataClassMetadataPublishingActorBase.DOq3SEbYB9pduxUtBMLq(item)).Id));
              num2 = 2;
              continue;
            case 12:
              DataClassMetadataPublishingActorBase.PyQpdObYVqRtBYoWhqIf((object) classMetadataItem, DataClassMetadataPublishingActorBase.T8S830bYIfMkFVuERcFA((object) ((DataClassMetadataItemHeader) DataClassMetadataPublishingActorBase.DOq3SEbYB9pduxUtBMLq(item)).Published));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 15 : 25;
              continue;
            case 13:
              DataClassMetadataPublishingActorBase.IwuDsdbYEKM1qrotiXrZ(item, DataClassMetadataPublishingActorBase.zSJX6Zbj007hv8Q9SGFa(1581325282 << 3 ^ -234342976));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 17 : 2;
              continue;
            case 14:
              goto label_16;
            case 15:
              classMetadataItem.AssemblyName = (string) DataClassMetadataPublishingActorBase.P3owOjbYCWZrgJjoKlfv((object) dataClassMetadata);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 0;
              continue;
            case 17:
            case 23:
              goto label_11;
            case 18:
              DataClassMetadataPublishingActorBase.T0JUkfbYqS0PIFGmiVua(DataClassMetadataPublishingActorBase.DOq3SEbYB9pduxUtBMLq(item));
              num2 = 5;
              continue;
            case 19:
              DataClassMetadataPublishingActorBase.GxpYWlbYFCb817bxylAT((object) classMetadataItem, DataClassMetadataPublishingActorBase.iaOftJbjzmC96j7ZKr3Y());
              num2 = 14;
              continue;
            case 20:
              goto label_20;
            case 21:
            case 22:
              version = new Version((string) DataClassMetadataPublishingActorBase.vbjGbGbYhx1A9jEtb75P(item));
              num2 = 27;
              continue;
            case 24:
              DataClassMetadataPublishingActorBase.OodtUSbjsNytOHOkLwvv((object) dataClassMetadata, (object) DataClassMetadataPublishingActorBase.cuZLoAbjU3BCFNZ7kjPh(dataClassTypeReferenceManager, (object) classTypeReference1).ToString());
              num2 = 20;
              continue;
            case 25:
              goto label_9;
            case 26:
              DataClassMetadataPublishingActorBase.h6txqZbYoJWDIC7iqYXK((object) classMetadataItem, comment);
              num2 = 11;
              continue;
            case 27:
              str = new Version(version.Major, DataClassMetadataPublishingActorBase.sTqNH1bYfo68yWtBf7jS((object) version), DataClassMetadataPublishingActorBase.DF5bkYbYQYVnk1pnU4SZ((object) version), version.Revision + 1).ToString();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 1 : 1;
              continue;
            case 28:
              if (DataClassMetadataPublishingActorBase.v6LniGbYuMKP4NpV4jaV(DataClassMetadataPublishingActorBase.DOq3SEbYB9pduxUtBMLq(item)) == null)
              {
                num2 = 16;
                continue;
              }
              goto case 12;
            default:
              DataClassMetadataPublishingActorBase.RoI7CxbYvkBNAWiokqeq(session, (object) classMetadataItem);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 4 : 1;
              continue;
          }
        }
label_9:
        DataClassMetadataPublishingActorBase.EncuBUbYik99PluFb36b((object) classMetadataItem, DataClassMetadataPublishingActorBase.HSKI99bYSYemKkTXJUnM(DataClassMetadataPublishingActorBase.v6LniGbYuMKP4NpV4jaV(DataClassMetadataPublishingActorBase.DOq3SEbYB9pduxUtBMLq(item))));
        num1 = 3;
        continue;
label_11:
        DataClassMetadataPublishingActorBase.IwuDsdbYEKM1qrotiXrZ((object) classMetadataItem, DataClassMetadataPublishingActorBase.vbjGbGbYhx1A9jEtb75P(item));
        num1 = 15;
        continue;
label_16:
        classMetadataItem.CreationAuthorId = ((DataClassMetadataItem) item).CreationAuthorId;
        num1 = 7;
        continue;
label_20:
        DataClassMetadataPublishingActorBase.JT8E8wbjccNP39KFNj8V((object) classMetadataItem, (object) dataClassMetadata);
        num1 = 19;
        continue;
label_24:
        DataClassMetadataPublishingActorBase.GWi4vfbYRYu5MIGn8GZX(DataClassMetadataPublishingActorBase.DOq3SEbYB9pduxUtBMLq(item), (object) classMetadataItem);
        num1 = 18;
      }
label_27:;
    }

    internal static void lZBNBObjHIMMkkfXMVVc() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static TimeSpan npIkRkbjAPoGWXpQXJo4([In] double obj0) => TimeSpan.FromHours(obj0);

    internal static bool WEiO8Ibj4cunJ7JftFkn() => DataClassMetadataPublishingActorBase.OhlOYMbjwws8JCgvr5Zt == null;

    internal static DataClassMetadataPublishingActorBase eNOGM2bj6dmQMhei8up4() => DataClassMetadataPublishingActorBase.OhlOYMbjwws8JCgvr5Zt;

    internal static AsyncTaskMethodBuilder yBF6Ufbj75wWu8BwclmC() => AsyncTaskMethodBuilder.Create();

    internal static object tHd7t2bjxiyV6kp2sSb3([In] object obj0) => (object) ((DataClassMetadataItemHeader) obj0).Draft;

    internal static object zSJX6Zbj007hv8Q9SGFa(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object v3m4Plbjmv80ANHr1Cyx([In] object obj0, [In] object obj1) => (object) ((ISessionProvider) obj0).GetSession((string) obj1);

    internal static object W6LLkLbjypk39JY6VCiG([In] object obj0) => ((DataClassMetadataItem) obj0).Metadata;

    internal static object SE4jbEbjMXfNZKfdYvxW([In] object obj0, [In] object obj1) => (object) ((ICheckDataClassService) obj0).Validate((DataClassMetadata) obj1);

    internal static bool yRgIWAbjJAj2RxFWNfG3([In] object obj0) => ((ValidationResult) obj0).IsValid;

    internal static object veOQUIbj9bA2AL5e1UK3([In] object obj0) => (object) ((ValidationResult) obj0).Errors;

    internal static void SQw3GZbjd5dxLVPvrtOj([In] object obj0, [In] object obj1) => ((IDataClassAssemblyBuilderService) obj0).Build((DataClassBuildAssemblyModel) obj1);

    internal static void LFw4lWbjl4EKejsab8Et([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void mqw4IXbjrvyytn2N0yoP([In] object obj0) => ((ISession) obj0).Flush();

    internal static Guid XdqQH7bjgSQXB7B787l6([In] object obj0) => ((DataClassMetadataItem) obj0).Uid;

    internal static void xNfGFFbj5QFQUB8frtLs([In] object obj0) => ((IUnitOfWork) obj0).Commit();

    internal static void oDnHnqbjj1lNtxqgdpVM([In] object obj0) => ((IUnitOfWork) obj0).Rollback();

    internal static Guid nSQb4ZbjYe0sUVDKYagO([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static void gjr2vDbjLcBWmlDDtmp5([In] object obj0, Guid value) => ((DataClassTypeReference) obj0).MetadataUid = value;

    internal static long cuZLoAbjU3BCFNZ7kjPh([In] object obj0, [In] object obj1) => ((IDataClassTypeReferenceManager) obj0).Save((DataClassTypeReference) obj1);

    internal static void OodtUSbjsNytOHOkLwvv([In] object obj0, [In] object obj1) => ((DataClassMetadata) obj0).TypeRef = (string) obj1;

    internal static void JT8E8wbjccNP39KFNj8V([In] object obj0, [In] object obj1) => ((DataClassMetadataItem) obj0).Metadata = obj1;

    internal static DateTime iaOftJbjzmC96j7ZKr3Y() => DateTime.Now;

    internal static void GxpYWlbYFCb817bxylAT([In] object obj0, DateTime value) => ((DataClassMetadataItem) obj0).CreationDate = value;

    internal static object DOq3SEbYB9pduxUtBMLq([In] object obj0) => (object) ((DataClassMetadataItem) obj0).Header;

    internal static void pvuuXPbYWSw2o9dvvJqR([In] object obj0, [In] object obj1) => ((DataClassMetadataItem) obj0).Header = (DataClassMetadataItemHeader) obj1;

    internal static void h6txqZbYoJWDIC7iqYXK([In] object obj0, [In] object obj1) => ((DataClassMetadataItem) obj0).Comment = (string) obj1;

    internal static long RFZmGwbYbgbmoZJUKmF9([In] object obj0, long headerId) => ((IDataClassMetadataItemHeaderManager) obj0).GetNewPublishingVersionNumber(headerId);

    internal static object vbjGbGbYhx1A9jEtb75P([In] object obj0) => (object) ((DataClassMetadataItem) obj0).AssemblyVersion;

    internal static bool tIA5DKbYGwLBUyKe0o81([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static void IwuDsdbYEKM1qrotiXrZ([In] object obj0, [In] object obj1) => ((DataClassMetadataItem) obj0).AssemblyVersion = (string) obj1;

    internal static int sTqNH1bYfo68yWtBf7jS([In] object obj0) => ((Version) obj0).Minor;

    internal static int DF5bkYbYQYVnk1pnU4SZ([In] object obj0) => ((Version) obj0).Build;

    internal static object P3owOjbYCWZrgJjoKlfv([In] object obj0) => (object) DataClassMetadataItemManager.ServerAssemblyName((DataClassMetadata) obj0);

    internal static object RoI7CxbYvkBNAWiokqeq([In] object obj0, [In] object obj1) => ((ISession) obj0).Save(obj1);

    internal static object cdvX9AbY8uAl0gJifHx0([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static void yoDeVLbYZ2xTeHX0Uc1Y([In] object obj0, [In] object obj1) => ((DataClassMetadataItemHeader) obj0).Name = (string) obj1;

    internal static object v6LniGbYuMKP4NpV4jaV([In] object obj0) => (object) ((DataClassMetadataItemHeader) obj0).Published;

    internal static object T8S830bYIfMkFVuERcFA([In] object obj0) => (object) ((DataClassMetadataItem) obj0).AssemblyRaw;

    internal static void PyQpdObYVqRtBYoWhqIf([In] object obj0, [In] object obj1) => ((DataClassMetadataItem) obj0).AssemblyRaw = (byte[]) obj1;

    internal static object HSKI99bYSYemKkTXJUnM([In] object obj0) => (object) ((DataClassMetadataItem) obj0).ClientAssemblyRaw;

    internal static void EncuBUbYik99PluFb36b([In] object obj0, [In] object obj1) => ((DataClassMetadataItem) obj0).ClientAssemblyRaw = (byte[]) obj1;

    internal static void GWi4vfbYRYu5MIGn8GZX([In] object obj0, [In] object obj1) => ((DataClassMetadataItemHeader) obj0).Published = (DataClassMetadataItem) obj1;

    internal static void T0JUkfbYqS0PIFGmiVua([In] object obj0) => ((Entity<long>) obj0).Save();
  }
}
