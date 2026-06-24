// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.Managers.DataClassMetadataItemManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Events.Publication;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata.Actors;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace EleWise.ELMA.Model.Metadata.Managers
{
  /// <summary>Менеджер метаданных датаклассов</summary>
  internal class DataClassMetadataItemManager : 
    EntityManager<DataClassMetadataItem, long>,
    IDataClassMetadataItemManager,
    IEntityManager<DataClassMetadataItem, long>,
    IEntityManager<DataClassMetadataItem>,
    IEntityManager
  {
    private readonly DataClassMetadataItemHeaderManager headerManager;
    private readonly IDataClassTypeReferenceManager dataClassTypeReferenceManager;
    private readonly IActorModelRuntime actorModelRuntime;
    private readonly IEventHandlerSubscribeService eventHandlerSubscribeService;
    private readonly ConcurrentDictionary<string, DataClassMetadataItem> dataclassCache;
    private static DataClassMetadataItemManager bGGiXIbU5yJmvhKyAABp;

    /// <summary>Экземпляр менеджера</summary>
    public static DataClassMetadataItemManager Instance => Locator.GetServiceNotNull<DataClassMetadataItemManager>();

    /// <summary>Ctor</summary>
    /// <param name="headerManager">Менеджер заголовков метаданных DataClass</param>
    /// <param name="dataClassTypeReferenceManager">Менеджер ссылки типа DTO</param>
    /// <param name="actorModelRuntime">Среда исполнения акторов</param>
    /// <param name="eventHandlerSubscribeService">Сервис для ручной подписки на события</param>
    public DataClassMetadataItemManager(
      DataClassMetadataItemHeaderManager headerManager,
      IDataClassTypeReferenceManager dataClassTypeReferenceManager,
      IActorModelRuntime actorModelRuntime,
      IEventHandlerSubscribeService eventHandlerSubscribeService)
    {
      DataClassMetadataItemManager.uffWeLbULeaPpmoUYZvX();
      this.dataclassCache = new ConcurrentDictionary<string, DataClassMetadataItem>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0)
        num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            DataClassMetadataItemManager.CYZSX7bUsweE30ODsshX(DataClassMetadataItemManager.EOi6XibUUr95HR6CuyvZ(), (object) new ResolveEventHandler(this.CurrentDomainOnAssemblyResolve));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 1 : 1;
            continue;
          case 3:
            this.actorModelRuntime = actorModelRuntime;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
            continue;
          case 4:
            this.headerManager = headerManager;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 2 : 5;
            continue;
          case 5:
            this.dataClassTypeReferenceManager = dataClassTypeReferenceManager;
            num = 3;
            continue;
          default:
            this.eventHandlerSubscribeService = eventHandlerSubscribeService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 2 : 2;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    [Transaction]
    public virtual DataClassMetadataItem Create(Guid moduleUid, Guid groupUid, string displayName)
    {
      int num = 1;
      DataClassMetadata metadata;
      while (true)
      {
        switch (num)
        {
          case 1:
            metadata = new DataClassMetadata(moduleUid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            DataClassMetadataItemManager.A00PHgbUz2YpG3hi1mcq((object) metadata, (object) displayName.ToTranslitIdent());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 2 : 2;
            continue;
          case 4:
            metadata.DisplayName = displayName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 3;
            continue;
          default:
            DataClassMetadataItemManager.fGNEKmbUctl6iu5M3I2j((object) metadata);
            num = 4;
            continue;
        }
      }
label_2:
      return this.Create(metadata, groupUid);
    }

    /// <inheritdoc />
    [Transaction]
    public virtual DataClassMetadataItem Copy(Guid headerUid)
    {
      int num1 = 1;
      int num2;
      DataClassMetadata metadata1;
      MetadataItemGroupUI metadataItemGroupUi;
      while (true)
      {
        switch (num1)
        {
          case 1:
            num2 = DataClassMetadataItemManager.b1HrOAbsFVdq0xYenMuL((object) new Random(), 0, 10000);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          default:
            DataClassMetadataItemHeader metadataItemHeader = this.headerManager.Load(headerUid);
            DataClassMetadata metadata2 = (DataClassMetadata) ((DataClassMetadataItem) DataClassMetadataItemManager.KLTb29bsB0CnWx3HfCGc((object) metadataItemHeader)).Metadata;
            metadata1 = ClassSerializationHelper.CloneObjectByXml<DataClassMetadata>(metadata2);
            metadata1.InitNew();
            DataClassMetadataItemManager.DP0bkmbso13E4GiS9y7D((object) metadata1, DataClassMetadataItemManager.Eswrt5bsWZj8aenQM4Hy((object) metadata2));
            metadata1.Name = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886585195), (object) metadata1.Name, (object) num2);
            DataClassMetadataItemManager.vtv0M5bsEGnYkcLWKTRy((object) metadata1, DataClassMetadataItemManager.Yr70iMbsGUqVl82uOm9I(DataClassMetadataItemManager.S3jgkybsbH45HEbjvM1Z(-812025778 ^ -812020908), DataClassMetadataItemManager.HyFLqUbshOPJQyZ8fp9D((object) metadata1), (object) num2));
            metadataItemGroupUi = (MetadataItemGroupUI) DataClassMetadataItemManager.qVXBJtbsf0x6AqI2PfM1((object) metadataItemHeader);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 1 : 2;
            continue;
        }
      }
label_4:
      return this.Create(metadata1, metadataItemGroupUi == null ? Guid.Empty : DataClassMetadataItemManager.RsbgejbsQMgjvkNHlHYa((object) metadataItemGroupUi));
    }

    /// <inheritdoc />
    public override void Save(DataClassMetadataItem obj)
    {
      int num1 = 3;
      DataClassMetadata dataClassMetadata;
      string errorMessage;
      while (true)
      {
        int num2 = num1;
        IUser user;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_15;
            case 2:
              dataClassMetadata = DataClassMetadataItemManager.iHn9mGbsvrhfWip3fX9t((object) obj) as DataClassMetadata;
              num2 = 6;
              continue;
            case 3:
              DataClassMetadataItemManager.rZSNnmbsCloZrW7l4HnH((object) obj, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(694673736 ^ -23604109 ^ -672098637));
              num2 = 2;
              continue;
            case 4:
              obj.CreationAuthorId = (long?) (user == null ? (object) null : user.GetId());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
              continue;
            case 5:
              goto label_12;
            case 6:
              if (dataClassMetadata != null)
              {
                if (obj.Header != null)
                {
                  num2 = 11;
                  continue;
                }
                goto label_9;
              }
              else
                goto label_6;
            case 7:
              base.Save(obj);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 9;
              continue;
            case 8:
              goto label_18;
            case 9:
              goto label_22;
            case 10:
              goto label_9;
            case 11:
              if (!this.headerManager.ValidateName(DataClassMetadataItemManager.i7TrAFbsuqBl1wtMhlQf(DataClassMetadataItemManager.FYBFZCbsZSSxFr0rO8jq((object) obj)), (string) DataClassMetadataItemManager.oOTibmbs8qfP89Zr5JAf((object) dataClassMetadata), out errorMessage))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 8 : 5;
                continue;
              }
              if (this.headerManager.ValidateDisplayName(DataClassMetadataItemManager.i7TrAFbsuqBl1wtMhlQf(DataClassMetadataItemManager.FYBFZCbsZSSxFr0rO8jq((object) obj)), (string) DataClassMetadataItemManager.HyFLqUbshOPJQyZ8fp9D((object) dataClassMetadata), out errorMessage))
              {
                user = (IUser) DataClassMetadataItemManager.S9gQTlbsVxPgyMlR3dER(DataClassMetadataItemManager.o6dCpcbsIcxknqsB3iCb((object) this));
                num2 = 4;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 1;
              continue;
            case 12:
              DataClassMetadataItemManager.j8GY7PbsRXg9iny7MCQs(DataClassMetadataItemManager.FYBFZCbsZSSxFr0rO8jq((object) obj), true);
              num2 = 7;
              continue;
            default:
              DataClassMetadataItemManager.gs3ecubsiGE7Lk6nL6Yk((object) obj, DataClassMetadataItemManager.KL2RjObsSvdSwUPoxP8Z());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 9 : 12;
              continue;
          }
        }
label_6:
        num1 = 5;
      }
label_22:
      return;
label_9:
      throw new Exception(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470998129 - 231418599 ^ 1239582838), DataClassMetadataItemManager.HyFLqUbshOPJQyZ8fp9D((object) dataClassMetadata), DataClassMetadataItemManager.oOTibmbs8qfP89Zr5JAf((object) dataClassMetadata)));
label_12:
      throw new Exception(EleWise.ELMA.SR.T((string) DataClassMetadataItemManager.S3jgkybsbH45HEbjvM1Z(516838154 ^ 516858008), DataClassMetadataItemManager.S3jgkybsbH45HEbjvM1Z(-643786247 ^ -643588465)));
label_15:
      throw new InvalidOperationException(errorMessage);
label_18:
      throw new InvalidOperationException(errorMessage);
    }

    /// <inheritdoc />
    public UIMetadataPublishResult Publish(string comment, Guid[] headerIds)
    {
      int num = 1;
      TaskAwaiter<UIMetadataPublishResult> awaiter;
      while (true)
      {
        switch (num)
        {
          case 1:
            awaiter = this.PublishAsync(comment, headerIds).GetAwaiter();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return awaiter.GetResult();
    }

    /// <inheritdoc />
    public UIMetadataPublishResult Publish(string comment, Guid headerId)
    {
      int num = 1;
      TaskAwaiter<UIMetadataPublishResult> awaiter;
      while (true)
      {
        switch (num)
        {
          case 1:
            awaiter = this.PublishAsync(comment, headerId).GetAwaiter();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return awaiter.GetResult();
    }

    /// <inheritdoc />
    public IEnumerable<DataClassMetadataItem> GetLastPublished() => (IEnumerable<DataClassMetadataItem>) this.CreateCriteria(FetchOptions.All, this.ImplementationType, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1290212282 ^ -644262414 ^ 1786858532)).CreateAlias(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921224335), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1149433385 + 173655049 ^ 1323046534), JoinType.InnerJoin, (ICriterion) Restrictions.EqProperty(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998568788), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-630932142 - 1120244082 ^ -1751130558))).Add((ICriterion) Restrictions.IsNotNull(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867153771))).List<DataClassMetadataItem>();

    /// <summary>Имя серверной сборки</summary>
    /// <param name="metadata">Метаданные</param>
    /// <returns>Имя серверной сборки</returns>
    internal static string ServerAssemblyName(DataClassMetadata metadata) => (string) DataClassMetadataItemManager.S3jgkybsbH45HEbjvM1Z(-951514650 ^ -951447942) + metadata.FullTypeName;

    /// <summary>Получить метаданные структур обмена данными</summary>
    /// <param name="itemUids">Идентификаторы структур обмена данными</param>
    /// <returns>Список метаданных</returns>
    public List<RuntimeDataClassModel> LoadRuntimeMetadata(IEnumerable<Guid> itemUids)
    {
      List<RuntimeDataClassModel> runtimeDataClassModelList = new List<RuntimeDataClassModel>();
      IList<DataClassMetadataItem> collection = (IList<DataClassMetadataItem>) new List<DataClassMetadataItem>();
      List<Guid> notLoadedItemUids = new List<Guid>();
      foreach (Guid itemUid in itemUids)
        notLoadedItemUids.Add(itemUid);
      if (notLoadedItemUids.Count > 0)
      {
        IEnumerable<DataClassMetadataItem> loadedDataClasses = (IEnumerable<DataClassMetadataItem>) null;
        EleWise.ELMA.SR.LocalizableString.RunWithSRLocalizer((System.Action) (() =>
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                // ISSUE: reference to a compiler-generated method
                loadedDataClasses = (IEnumerable<DataClassMetadataItem>) this.CreateCriteriaForArraySearch<Guid>((IEnumerable<Guid>) notLoadedItemUids, (string) DataClassMetadataItemManager.\u003C\u003Ec__DisplayClass17_1.ED8aOLCMTwIc7dHosJgj(1505778440 - 1981636111 ^ -475884693), (IEntityFilter) null, (FetchOptions) null).List<DataClassMetadataItem>();
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }));
        collection.AddRange<DataClassMetadataItem>(loadedDataClasses);
      }
      foreach (DataClassMetadataItem classMetadataItem in (IEnumerable<DataClassMetadataItem>) collection)
      {
        if (classMetadataItem != null)
          runtimeDataClassModelList.Add(new RuntimeDataClassModel()
          {
            MetadataItem = classMetadataItem
          });
      }
      return runtimeDataClassModelList;
    }

    /// <summary>Опубликовать дата-классы</summary>
    /// <param name="comment">Комментарий при публикации</param>
    /// <param name="headerIds">Уникальные идентификаторы заголовков</param>
    /// <returns>Результат публикации</returns>
    private async Task<UIMetadataPublishResult> PublishAsync(string comment, Guid[] headerIds)
    {
      int num1 = 3;
      UIMetadataPublishResult result1;
      int num2;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_69;
          case 1:
label_3:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003E1__state = -2;
            num1 = 5;
            continue;
          case 2:
            num1 = 4;
            continue;
          case 3:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = 2;
            continue;
          case 4:
            try
            {
              int num3 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
                num3 = 0;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_9;
                }
              }
label_9:
              try
              {
                int num4;
                if (num2 != 0)
                  num4 = 11;
                else
                  goto label_13;
label_12:
                IDataClassesMetadataPublishingActor publishingActor;
                TaskAwaiter<Guid> taskAwaiter1;
                IDisposable disposable;
                TaskAwaiter<Guid> awaiter1;
                Guid result2;
                DataClassMetadataItemManager.DataClassMetadataPublishingEventHandler publishingEventHandler;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      taskAwaiter1 = new TaskAwaiter<Guid>();
                      num4 = 10;
                      continue;
                    case 2:
                      goto label_61;
                    case 3:
                      taskAwaiter1 = awaiter1;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 8 : 3;
                      continue;
                    case 4:
                      num4 = 13;
                      continue;
                    case 5:
                      result2 = awaiter1.GetResult();
                      num4 = 15;
                      continue;
                    case 6:
                      goto label_13;
                    case 7:
                      // ISSUE: reference to a compiler-generated method
                      disposable = (IDisposable) DataClassMetadataItemManager.\u003CPublishAsync\u003Ed__18.LJqsExCM2kDa07SsXqC0((object) this.eventHandlerSubscribeService, (object) publishingEventHandler);
                      num4 = 4;
                      continue;
                    case 8:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Guid>, DataClassMetadataItemManager.\u003CPublishAsync\u003Ed__18>(ref awaiter1, this);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 2 : 1;
                      continue;
                    case 9:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num2 = 0;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 3 : 3;
                      continue;
                    case 10:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num2 = -1;
                      num4 = 5;
                      continue;
                    case 11:
                      if (num2 != 1)
                      {
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 1 : 12;
                        continue;
                      }
                      goto case 4;
                    case 12:
                      publishingActor = this.actorModelRuntime.GetActor<IDataClassesMetadataPublishingActor>(Guid.Empty);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
                      continue;
                    case 13:
                      goto label_30;
                    case 14:
                      if (!awaiter1.IsCompleted)
                      {
                        num4 = 9;
                        continue;
                      }
                      goto case 5;
                    case 15:
                      publishingEventHandler = new DataClassMetadataItemManager.DataClassMetadataPublishingEventHandler(publishingActor, result2);
                      num4 = 7;
                      continue;
                    default:
                      awaiter1 = publishingActor.Publish(headerIds, comment).GetAwaiter();
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 10 : 14;
                      continue;
                  }
                }
label_61:
                return;
label_30:
                try
                {
                  int num5;
                  if (num2 != 1)
                    num5 = 9;
                  else
                    goto label_40;
label_32:
                  TaskAwaiter<UIMetadataPublishResult> taskAwaiter2;
                  TaskAwaiter<UIMetadataPublishResult> awaiter2;
                  while (true)
                  {
                    switch (num5)
                    {
                      case 1:
                        goto label_55;
                      case 2:
                        goto label_40;
                      case 3:
                        result1 = awaiter2.GetResult();
                        num5 = 5;
                        continue;
                      case 4:
                        // ISSUE: explicit reference operation
                        // ISSUE: reference to a compiler-generated field
                        (^this).\u003C\u003E1__state = num2 = 1;
                        num5 = 8;
                        continue;
                      case 5:
                        goto label_3;
                      case 6:
                        taskAwaiter2 = new TaskAwaiter<UIMetadataPublishResult>();
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
                        continue;
                      case 7:
                        // ISSUE: explicit reference operation
                        // ISSUE: reference to a compiler-generated field
                        (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<UIMetadataPublishResult>, DataClassMetadataItemManager.\u003CPublishAsync\u003Ed__18>(ref awaiter2, this);
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 1 : 1;
                        continue;
                      case 8:
                        taskAwaiter2 = awaiter2;
                        num5 = 7;
                        continue;
                      case 9:
                        awaiter2 = publishingEventHandler.Wait.GetAwaiter();
                        num5 = 10;
                        continue;
                      case 10:
                        if (!awaiter2.IsCompleted)
                        {
                          num5 = 4;
                          continue;
                        }
                        goto case 3;
                      default:
                        // ISSUE: explicit reference operation
                        // ISSUE: reference to a compiler-generated field
                        (^this).\u003C\u003E1__state = num2 = -1;
                        num5 = 3;
                        continue;
                    }
                  }
label_55:
                  return;
label_40:
                  awaiter2 = taskAwaiter2;
                  num5 = 6;
                  goto label_32;
                }
                finally
                {
                  if (num2 < 0)
                  {
                    int num6 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
                      num6 = 2;
                    while (true)
                    {
                      switch (num6)
                      {
                        case 1:
                          // ISSUE: reference to a compiler-generated method
                          DataClassMetadataItemManager.\u003CPublishAsync\u003Ed__18.lAVAbUCMe5LLTOeIIQqc((object) disposable);
                          num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
                          continue;
                        case 2:
                          if (disposable != null)
                          {
                            num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 1;
                            continue;
                          }
                          goto label_51;
                        default:
                          goto label_51;
                      }
                    }
                  }
label_51:;
                }
label_13:
                awaiter1 = taskAwaiter1;
                num4 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0)
                {
                  num4 = 1;
                  goto label_12;
                }
                else
                  goto label_12;
              }
              catch (NoServerCompatibleWithActorException ex)
              {
                int num7 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
                  num7 = 0;
                switch (num7)
                {
                  default:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    throw new NoServerCompatibleWithActorException((string) DataClassMetadataItemManager.\u003CPublishAsync\u003Ed__18.juE605CM1q1KUK5cDvAh(DataClassMetadataItemManager.\u003CPublishAsync\u003Ed__18.fvGa5WCMPHgbZW8VRQiI(-1638402543 ^ -1638753771)), (Exception) ex);
                }
              }
              finally
              {
                if (num2 < 0)
                {
                  int num8 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
                    num8 = 1;
                  while (true)
                  {
                    switch (num8)
                    {
                      case 1:
                        // ISSUE: reference to a compiler-generated method
                        DataClassMetadataItemManager.\u003CPublishAsync\u003Ed__18.JoADpKCMNUjruqq43xjQ((object) this.dataclassCache);
                        num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_63;
                    }
                  }
                }
label_63:;
              }
            }
            catch (Exception ex)
            {
              int num9 = 2;
              while (true)
              {
                switch (num9)
                {
                  case 1:
                    goto label_47;
                  case 2:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 0 : 0;
                    continue;
                  default:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 1 : 1;
                    continue;
                }
              }
label_47:
              return;
            }
          case 5:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(result1);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
            continue;
          default:
            goto label_66;
        }
      }
label_69:
      return;
label_66:;
    }

    /// <summary>Опубликовать дата-класс</summary>
    /// <param name="comment">Комментарий при публикации</param>
    /// <param name="headerId">Уникальный идентификатор заголовка</param>
    /// <returns>Результат публикации</returns>
    private async Task<UIMetadataPublishResult> PublishAsync(string comment, Guid headerId)
    {
      int num1 = 1;
      int num2;
      UIMetadataPublishResult result;
      while (true)
      {
        switch (num1)
        {
          case 1:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
            continue;
          case 2:
label_69:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003E1__state = -2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 3 : 1;
            continue;
          case 3:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(result);
            num1 = 4;
            continue;
          case 4:
            goto label_66;
          case 5:
            try
            {
              IDataClassMetadataPublishingActor actor;
              int num3;
              switch (num2)
              {
                case 0:
                case 1:
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 2 : 4;
                  break;
                default:
label_8:
                  actor = this.actorModelRuntime.GetActor<IDataClassMetadataPublishingActor>(headerId);
                  num3 = 5;
                  break;
              }
              DataClassMetadataItemManager.DataClassMetadataPublishingEventHandler handler;
              IDisposable disposable;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    disposable = this.eventHandlerSubscribeService.Subscribe((IEventHandler) handler);
                    num3 = 2;
                    continue;
                  case 2:
                  case 4:
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
                    continue;
                  case 3:
                    goto label_8;
                  case 5:
                    handler = new DataClassMetadataItemManager.DataClassMetadataPublishingEventHandler(actor, headerId);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 1 : 1;
                    continue;
                  default:
                    goto label_9;
                }
              }
label_9:
              try
              {
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
                  num4 = 0;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      goto label_14;
                    default:
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 1;
                      continue;
                  }
                }
label_14:
                try
                {
                  int num5;
                  if (num2 != 0)
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 9 : 6;
                  else
                    goto label_32;
label_16:
                  TaskAwaiter taskAwaiter1;
                  TaskAwaiter<UIMetadataPublishResult> taskAwaiter2;
                  TaskAwaiter awaiter1;
                  TaskAwaiter<UIMetadataPublishResult> awaiter2;
                  while (true)
                  {
                    switch (num5)
                    {
                      case 1:
                        awaiter2 = taskAwaiter2;
                        num5 = 19;
                        continue;
                      case 2:
                        goto label_63;
                      case 3:
                        taskAwaiter2 = awaiter2;
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 6 : 6;
                        continue;
                      case 4:
                        goto label_32;
                      case 5:
                        // ISSUE: reference to a compiler-generated method
                        awaiter1 = ((Task) DataClassMetadataItemManager.\u003CPublishAsync\u003Ed__19.bh9c73CMDjlEaduXyeLo((object) actor, (object) comment)).GetAwaiter();
                        num5 = 16;
                        continue;
                      case 6:
                        // ISSUE: explicit reference operation
                        // ISSUE: reference to a compiler-generated field
                        (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<UIMetadataPublishResult>, DataClassMetadataItemManager.\u003CPublishAsync\u003Ed__19>(ref awaiter2, this);
                        num5 = 2;
                        continue;
                      case 7:
                        if (awaiter2.IsCompleted)
                        {
                          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 15 : 21;
                          continue;
                        }
                        goto case 15;
                      case 8:
                        goto label_69;
                      case 9:
                        if (num2 != 1)
                        {
                          num5 = 5;
                          continue;
                        }
                        goto case 1;
                      case 10:
                        awaiter1.GetResult();
                        num5 = 13;
                        continue;
                      case 11:
                      case 21:
                        result = awaiter2.GetResult();
                        num5 = 8;
                        continue;
                      case 12:
                        // ISSUE: explicit reference operation
                        // ISSUE: reference to a compiler-generated field
                        (^this).\u003C\u003E1__state = num2 = -1;
                        num5 = 10;
                        continue;
                      case 13:
                        awaiter2 = handler.Wait.GetAwaiter();
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 7 : 1;
                        continue;
                      case 14:
                        goto label_58;
                      case 15:
                        // ISSUE: explicit reference operation
                        // ISSUE: reference to a compiler-generated field
                        (^this).\u003C\u003E1__state = num2 = 1;
                        num5 = 3;
                        continue;
                      case 16:
                        if (!awaiter1.IsCompleted)
                        {
                          num5 = 22;
                          continue;
                        }
                        goto case 10;
                      case 17:
                        // ISSUE: explicit reference operation
                        // ISSUE: reference to a compiler-generated field
                        (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, DataClassMetadataItemManager.\u003CPublishAsync\u003Ed__19>(ref awaiter1, this);
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 14 : 13;
                        continue;
                      case 18:
                        // ISSUE: explicit reference operation
                        // ISSUE: reference to a compiler-generated field
                        (^this).\u003C\u003E1__state = num2 = -1;
                        num5 = 11;
                        continue;
                      case 19:
                        taskAwaiter2 = new TaskAwaiter<UIMetadataPublishResult>();
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 4 : 18;
                        continue;
                      case 20:
                        taskAwaiter1 = new TaskAwaiter();
                        num5 = 12;
                        continue;
                      case 22:
                        // ISSUE: explicit reference operation
                        // ISSUE: reference to a compiler-generated field
                        (^this).\u003C\u003E1__state = num2 = 0;
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 0 : 0;
                        continue;
                      default:
                        taskAwaiter1 = awaiter1;
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 17 : 17;
                        continue;
                    }
                  }
label_63:
                  return;
label_58:
                  return;
label_32:
                  awaiter1 = taskAwaiter1;
                  num5 = 8;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
                  {
                    num5 = 20;
                    goto label_16;
                  }
                  else
                    goto label_16;
                }
                catch (NoServerCompatibleWithActorException ex)
                {
                  int num6 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
                    num6 = 0;
                  switch (num6)
                  {
                    default:
                      // ISSUE: reference to a compiler-generated method
                      throw new NoServerCompatibleWithActorException(EleWise.ELMA.SR.T((string) DataClassMetadataItemManager.\u003CPublishAsync\u003Ed__19.BhFaKyCMtsla1nAC70es(1232639661 >> 3 ^ 153779921)), (Exception) ex);
                  }
                }
                finally
                {
                  int num7;
                  if (num2 >= 0)
                    num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 1 : 1;
                  else
                    goto label_47;
label_46:
                  switch (num7)
                  {
                    case 2:
                      break;
                    default:
                  }
label_47:
                  // ISSUE: reference to a compiler-generated method
                  DataClassMetadataItemManager.\u003CPublishAsync\u003Ed__19.g14HAGCMwDLP6gwmhjat((object) this.dataclassCache);
                  num7 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0)
                  {
                    num7 = 0;
                    goto label_46;
                  }
                  else
                    goto label_46;
                }
              }
              finally
              {
                if (num2 < 0)
                {
                  int num8 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
                    num8 = 0;
                  while (true)
                  {
                    switch (num8)
                    {
                      case 1:
                        if (disposable == null)
                        {
                          num8 = 3;
                          continue;
                        }
                        goto case 2;
                      case 2:
                        disposable.Dispose();
                        num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_59;
                    }
                  }
                }
label_59:;
              }
            }
            catch (Exception ex)
            {
              int num9 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
                num9 = 0;
              while (true)
              {
                switch (num9)
                {
                  case 1:
                    goto label_54;
                  case 2:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 1 : 1;
                    continue;
                  default:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num9 = 2;
                    continue;
                }
              }
label_54:
              return;
            }
          default:
            num1 = 5;
            continue;
        }
      }
label_66:;
    }

    private Assembly CurrentDomainOnAssemblyResolve(object sender, ResolveEventArgs args)
    {
      int num = 2;
      DataClassMetadataItem classMetadataItem;
      Assembly assembly;
      AssemblyName assemblyName;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_9;
          case 2:
            if (!DataClassMetadataItemManager.FyoAWtbsKXvq7SvWix95(DataClassMetadataItemManager.t0x0MibsquCqSDAvH9Vs((object) args), DataClassMetadataItemManager.S3jgkybsbH45HEbjvM1Z(864270449 << 6 ^ -521331748)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 1 : 0;
              continue;
            }
            goto case 3;
          case 3:
            assemblyName = new AssemblyName((string) DataClassMetadataItemManager.t0x0MibsquCqSDAvH9Vs((object) args));
            num = 4;
            continue;
          case 4:
            classMetadataItem = ((ICriteria) DataClassMetadataItemManager.GP6LdObseGZlltNDQIIx((object) ((ICriteria) DataClassMetadataItemManager.b22xVEbsnhK44TqNTv1n(DataClassMetadataItemManager.pUON0xbsXDIu2uqyE0Ni((object) this, (object) null), DataClassMetadataItemManager.tfHPjnbskldwdaQnZMq4(DataClassMetadataItemManager.S3jgkybsbH45HEbjvM1Z(1149433385 + 173655049 ^ 1323108962), DataClassMetadataItemManager.EieHUCbsTGYYrIkhxu4U((object) assemblyName)))).Add((ICriterion) DataClassMetadataItemManager.tfHPjnbskldwdaQnZMq4(DataClassMetadataItemManager.S3jgkybsbH45HEbjvM1Z(1232639661 >> 3 ^ 153883935), (object) DataClassMetadataItemManager.L74UWrbsOfYNqGMry40t((object) assemblyName).ToString())), DataClassMetadataItemManager.Bqy1dybs23ekkVWRSIum(DataClassMetadataItemManager.S3jgkybsbH45HEbjvM1Z(-1120607109 - 305487170 ^ -1426140521)))).SetMaxResults(1).UniqueResult<DataClassMetadataItem>();
            num = 7;
            continue;
          case 5:
            if (DataClassMetadataItemManager.PC7aUZbs1iKR3aViLr2O((object) assembly, (object) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
              continue;
            }
            goto label_8;
          case 6:
          case 9:
            goto label_8;
          case 7:
            assembly = (Assembly) DataClassMetadataItemManager.Xst44gbsPMMIE61HoAPb((object) ScriptExecutionHandlerHelper.CreateFullAssemblyName((string) DataClassMetadataItemManager.EieHUCbsTGYYrIkhxu4U((object) assemblyName), DataClassMetadataItemManager.L74UWrbsOfYNqGMry40t((object) assemblyName).ToString(), (string) DataClassMetadataItemManager.S3jgkybsbH45HEbjvM1Z(272623989 ^ 272575635), (string) DataClassMetadataItemManager.S3jgkybsbH45HEbjvM1Z(1669371371 ^ 1669367053)), true);
            num = 5;
            continue;
          case 8:
            assembly = (Assembly) DataClassMetadataItemManager.NJymv5bs3blqO2l4Mpe2((object) classMetadataItem.AssemblyRaw, DataClassMetadataItemManager.tCEJ2AbsNjqAid7MdyIO((object) classMetadataItem));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 4 : 6;
            continue;
          default:
            if (classMetadataItem == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 9 : 7;
              continue;
            }
            goto case 8;
        }
      }
label_8:
      return assembly;
label_9:
      return (Assembly) null;
    }

    private DataClassMetadataItem Create(DataClassMetadata metadata, Guid groupUid)
    {
      int num1 = 4;
      DataClassMetadataItem classMetadataItem;
      while (true)
      {
        int num2 = num1;
        DataClassMetadataItemHeader metadataItemHeader;
        IUser user;
        DataClassTypeReference classTypeReference1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_20;
            case 2:
              goto label_4;
            case 3:
              DataClassMetadataItemManager.W7vy29bspT435NmX39Ua((object) classMetadataItem, (object) metadata);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 5 : 5;
              continue;
            case 4:
              classMetadataItem = this.Create();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 3 : 0;
              continue;
            case 5:
              DataClassTypeReference classTypeReference2 = new DataClassTypeReference();
              classTypeReference2.MetadataUid = DataClassMetadataItemManager.lFii2ObsaMVZhZlFT3yb((object) metadata);
              DataClassMetadataItemManager.IAOBy9bstTEGGl0LlPW8((object) classTypeReference2, DataClassMetadataItemManager.edCElAbsDNT8YkC7guMN((object) classMetadataItem));
              classTypeReference1 = classTypeReference2;
              num2 = 9;
              continue;
            case 6:
              user = (IUser) DataClassMetadataItemManager.S9gQTlbsVxPgyMlR3dER((object) this.AuthenticationService);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 18 : 2;
              continue;
            case 7:
              base.Save(classMetadataItem);
              num2 = 14;
              continue;
            case 8:
              DataClassMetadataItemManager.pyg3ZVbs0CU04clKgHmn((object) metadataItemHeader, DataClassMetadataItemManager.cHFHK1bsxWIiXbmkD1EJ((object) classMetadataItem));
              num2 = 10;
              continue;
            case 9:
              DataClassMetadataItemManager.ISnksAbs44ASRyCShdrh((object) metadata, (object) DataClassMetadataItemManager.XSj4wcbswBaJVXkUTXep((object) this.dataClassTypeReferenceManager, (object) classTypeReference1).ToString());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 6 : 1;
              continue;
            case 10:
              metadataItemHeader.Draft = classMetadataItem;
              num2 = 17;
              continue;
            case 11:
              metadataItemHeader = this.headerManager.Create();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 0 : 0;
              continue;
            case 12:
              DataClassMetadataItemManager.LeYekZbsMlNUJ6qfue4U((object) classMetadataItem, (object) metadataItemHeader);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 7 : 3;
              continue;
            case 13:
              DataClassMetadataItemManager.ncZCBfbs7v8MbKEOuPF0((object) metadataItemHeader, metadata.ModuleUid);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 1 : 1;
              continue;
            case 14:
              goto label_10;
            case 15:
              DataClassMetadataItemManager.gs3ecubsiGE7Lk6nL6Yk((object) classMetadataItem, DataClassMetadataItemManager.KL2RjObsSvdSwUPoxP8Z());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 9 : 11;
              continue;
            case 16:
              DataClassMetadataItemManager.PaksrubsADDq9848ErOx((object) metadataItemHeader, (object) metadata.DisplayName);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 7 : 13;
              continue;
            case 17:
              DataClassMetadataItemManager.Igpoq8bsyA5iWxKetfBX((object) metadataItemHeader, (object) ((AbstractNHEntityManager<MetadataItemGroupUI, long>) DataClassMetadataItemManager.YHSlvkbsmvYcxpZRgknV()).LoadOrNull(groupUid));
              num2 = 12;
              continue;
            case 18:
              classMetadataItem.CreationAuthorId = (long?) (user == null ? (object) null : user.GetId());
              num2 = 15;
              continue;
            default:
              DataClassMetadataItemManager.PatmOLbs6x6pSAEXAxg0((object) metadataItemHeader, metadata.Uid);
              num2 = 2;
              continue;
          }
        }
label_4:
        DataClassMetadataItemManager.jr7qk7bsHxshuXL0CWdf((object) metadataItemHeader, (object) metadata.Name);
        num1 = 16;
        continue;
label_20:
        metadataItemHeader.CreationAuthorId = classMetadataItem.CreationAuthorId;
        num1 = 8;
      }
label_10:
      return classMetadataItem;
    }

    internal static void uffWeLbULeaPpmoUYZvX() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object EOi6XibUUr95HR6CuyvZ() => (object) AppDomain.CurrentDomain;

    internal static void CYZSX7bUsweE30ODsshX([In] object obj0, [In] object obj1) => ((AppDomain) obj0).AssemblyResolve += (ResolveEventHandler) obj1;

    internal static bool uqdafvbUjuHo5hwc3UEc() => DataClassMetadataItemManager.bGGiXIbU5yJmvhKyAABp == null;

    internal static DataClassMetadataItemManager Hftg6mbUYfWSFJLe6WNT() => DataClassMetadataItemManager.bGGiXIbU5yJmvhKyAABp;

    internal static void fGNEKmbUctl6iu5M3I2j([In] object obj0) => ((AbstractMetadata) obj0).InitNew();

    internal static void A00PHgbUz2YpG3hi1mcq([In] object obj0, [In] object obj1) => ((NamedMetadata) obj0).Name = (string) obj1;

    internal static int b1HrOAbsFVdq0xYenMuL([In] object obj0, [In] int obj1, [In] int obj2) => ((Random) obj0).Next(obj1, obj2);

    internal static object KLTb29bsB0CnWx3HfCGc([In] object obj0) => (object) ((DataClassMetadataItemHeader) obj0).Draft;

    internal static object Eswrt5bsWZj8aenQM4Hy([In] object obj0) => (object) ((ClassMetadata) obj0).Namespace;

    internal static void DP0bkmbso13E4GiS9y7D([In] object obj0, [In] object obj1) => ((ClassMetadata) obj0).Namespace = (string) obj1;

    internal static object S3jgkybsbH45HEbjvM1Z(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object HyFLqUbshOPJQyZ8fp9D([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;

    internal static object Yr70iMbsGUqVl82uOm9I([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static void vtv0M5bsEGnYkcLWKTRy([In] object obj0, [In] object obj1) => ((NamedMetadata) obj0).DisplayName = (string) obj1;

    internal static object qVXBJtbsf0x6AqI2PfM1([In] object obj0) => (object) ((DataClassMetadataItemHeader) obj0).Group;

    internal static Guid RsbgejbsQMgjvkNHlHYa([In] object obj0) => ((MetadataItemGroupUI) obj0).Uid;

    internal static void rZSNnmbsCloZrW7l4HnH([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object iHn9mGbsvrhfWip3fX9t([In] object obj0) => ((DataClassMetadataItem) obj0).Metadata;

    internal static object oOTibmbs8qfP89Zr5JAf([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object FYBFZCbsZSSxFr0rO8jq([In] object obj0) => (object) ((DataClassMetadataItem) obj0).Header;

    internal static Guid i7TrAFbsuqBl1wtMhlQf([In] object obj0) => ((DataClassMetadataItemHeader) obj0).Uid;

    internal static object o6dCpcbsIcxknqsB3iCb([In] object obj0) => (object) ((EntityManager<DataClassMetadataItem, long>) obj0).AuthenticationService;

    internal static object S9gQTlbsVxPgyMlR3dER([In] object obj0) => (object) ((IAuthenticationService) obj0).GetCurrentUser();

    internal static DateTime KL2RjObsSvdSwUPoxP8Z() => DateTime.Now;

    internal static void gs3ecubsiGE7Lk6nL6Yk([In] object obj0, DateTime value) => ((DataClassMetadataItem) obj0).CreationDate = value;

    internal static void j8GY7PbsRXg9iny7MCQs([In] object obj0, bool value) => ((DataClassMetadataItemHeader) obj0).IsDirtyItem = value;

    internal static object t0x0MibsquCqSDAvH9Vs([In] object obj0) => (object) ((ResolveEventArgs) obj0).Name;

    internal static bool FyoAWtbsKXvq7SvWix95([In] object obj0, [In] object obj1) => ((string) obj0).StartsWith((string) obj1);

    internal static object pUON0xbsXDIu2uqyE0Ni([In] object obj0, [In] object obj1) => (object) ((EntityManager<DataClassMetadataItem, long>) obj0).CreateCriteria((IEntityFilter) obj1);

    internal static object EieHUCbsTGYYrIkhxu4U([In] object obj0) => (object) ((AssemblyName) obj0).Name;

    internal static object tfHPjnbskldwdaQnZMq4([In] object obj0, [In] object obj1) => (object) Restrictions.Eq((string) obj0, obj1);

    internal static object b22xVEbsnhK44TqNTv1n([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).Add((ICriterion) obj1);

    internal static object L74UWrbsOfYNqGMry40t([In] object obj0) => (object) ((AssemblyName) obj0).Version;

    internal static object Bqy1dybs23ekkVWRSIum([In] object obj0) => (object) Order.Desc((string) obj0);

    internal static object GP6LdObseGZlltNDQIIx([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).AddOrder((Order) obj1);

    internal static object Xst44gbsPMMIE61HoAPb([In] object obj0, bool isFullName) => (object) ComponentManager.FindLoadedAssembly((string) obj0, isFullName);

    internal static bool PC7aUZbs1iKR3aViLr2O([In] object obj0, [In] object obj1) => (Assembly) obj0 == (Assembly) obj1;

    internal static object tCEJ2AbsNjqAid7MdyIO([In] object obj0) => (object) ((DataClassMetadataItem) obj0).DebugRaw;

    internal static object NJymv5bs3blqO2l4Mpe2([In] object obj0, [In] object obj1) => (object) ComponentManager.LoadAssembly((byte[]) obj0, (byte[]) obj1);

    internal static void W7vy29bspT435NmX39Ua([In] object obj0, [In] object obj1) => ((DataClassMetadataItem) obj0).Metadata = obj1;

    internal static Guid lFii2ObsaMVZhZlFT3yb([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static Guid edCElAbsDNT8YkC7guMN([In] object obj0) => ((DataClassMetadataItem) obj0).Uid;

    internal static void IAOBy9bstTEGGl0LlPW8([In] object obj0, Guid value) => ((DataClassTypeReference) obj0).ItemUid = value;

    internal static long XSj4wcbswBaJVXkUTXep([In] object obj0, [In] object obj1) => ((IDataClassTypeReferenceManager) obj0).Save((DataClassTypeReference) obj1);

    internal static void ISnksAbs44ASRyCShdrh([In] object obj0, [In] object obj1) => ((DataClassMetadata) obj0).TypeRef = (string) obj1;

    internal static void PatmOLbs6x6pSAEXAxg0([In] object obj0, Guid value) => ((DataClassMetadataItemHeader) obj0).Uid = value;

    internal static void jr7qk7bsHxshuXL0CWdf([In] object obj0, [In] object obj1) => ((DataClassMetadataItemHeader) obj0).Name = (string) obj1;

    internal static void PaksrubsADDq9848ErOx([In] object obj0, [In] object obj1) => ((DataClassMetadataItemHeader) obj0).DisplayName = (string) obj1;

    internal static void ncZCBfbs7v8MbKEOuPF0([In] object obj0, Guid value) => ((DataClassMetadataItemHeader) obj0).ModuleUid = value;

    internal static DateTime cHFHK1bsxWIiXbmkD1EJ([In] object obj0) => ((DataClassMetadataItem) obj0).CreationDate;

    internal static void pyg3ZVbs0CU04clKgHmn([In] object obj0, DateTime value) => ((DataClassMetadataItemHeader) obj0).CreationDate = value;

    internal static object YHSlvkbsmvYcxpZRgknV() => (object) MetadataItemGroupUIManager.Instance;

    internal static void Igpoq8bsyA5iWxKetfBX([In] object obj0, [In] object obj1) => ((DataClassMetadataItemHeader) obj0).Group = (MetadataItemGroupUI) obj1;

    internal static void LeYekZbsMlNUJ6qfue4U([In] object obj0, [In] object obj1) => ((DataClassMetadataItem) obj0).Header = (DataClassMetadataItemHeader) obj1;

    /// <summary>Событие публикации DataClass-а</summary>
    private sealed class DataClassMetadataPublishingEventHandler : 
      IDataClassMetadataPublishingEventHandler,
      IEventHandler
    {
      private readonly object dataClassActor;
      private readonly object dataClassesActor;
      private readonly Guid token;
      private readonly TaskCompletionSource<UIMetadataPublishResult> taskCompletionSource;
      internal static object SqiEBqCMfmFOpP5IigtW;

      /// <summary>Ctor</summary>
      /// <param name="dataClassesActor">Актор публикации</param>
      /// <param name="token">Токен публикации</param>
      public DataClassMetadataPublishingEventHandler(
        IDataClassesMetadataPublishingActor dataClassesActor,
        Guid token)
      {
        DataClassMetadataItemManager.DataClassMetadataPublishingEventHandler.BC2gVjCMvOg60h1QaNGI();
        this.taskCompletionSource = new TaskCompletionSource<UIMetadataPublishResult>(TaskCreationOptions.RunContinuationsAsynchronously);
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.token = token;
              num = 2;
              continue;
            case 2:
              goto label_3;
            default:
              this.dataClassesActor = (object) dataClassesActor;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 1 : 1;
              continue;
          }
        }
label_3:;
      }

      /// <summary>Ctor</summary>
      /// <param name="dataClassActor">Актор публиакции</param>
      /// <param name="token">Токен публикации</param>
      public DataClassMetadataPublishingEventHandler(
        IDataClassMetadataPublishingActor dataClassActor,
        Guid token)
      {
        DataClassMetadataItemManager.DataClassMetadataPublishingEventHandler.BC2gVjCMvOg60h1QaNGI();
        this.taskCompletionSource = new TaskCompletionSource<UIMetadataPublishResult>(TaskCreationOptions.RunContinuationsAsynchronously);
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.token = token;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
              continue;
            case 2:
              this.dataClassActor = (object) dataClassActor;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 1 : 0;
              continue;
            default:
              goto label_5;
          }
        }
label_2:
        return;
label_5:;
      }

      /// <inheritdoc />
      public Task Complete(Guid publicationToken, UIMetadataPublishResult result)
      {
        int num = 3;
        Task task;
        object dataClassActor;
        while (true)
        {
          switch (num)
          {
            case 1:
              dataClassActor = this.dataClassActor;
              if (dataClassActor == null)
              {
                num = 4;
                continue;
              }
              goto label_16;
            case 2:
              this.taskCompletionSource.TrySetResult(result);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
              continue;
            case 3:
              if (!(this.token != publicationToken))
              {
                num = 2;
                continue;
              }
              goto label_6;
            case 4:
              goto label_15;
            case 5:
              task = (Task) null;
              break;
            case 6:
              goto label_6;
            default:
              object dataClassesActor = this.dataClassesActor;
              if (dataClassesActor == null)
              {
                num = 5;
                continue;
              }
              task = ((IDataClassesMetadataPublishingActor) dataClassesActor).PublishComplete();
              break;
          }
          if (task == null)
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 1 : 1;
          else
            goto label_9;
        }
label_6:
        return (Task) DataClassMetadataItemManager.DataClassMetadataPublishingEventHandler.BbXeXXCM8Z3slftmRyiq();
label_9:
        return task;
label_15:
        return (Task) null;
label_16:
        return (Task) DataClassMetadataItemManager.DataClassMetadataPublishingEventHandler.x9ywCgCMZPdVkKIa0y0O(dataClassActor);
      }

      /// <inheritdoc />
      public Task Error(Guid publicationToken, Exception exception)
      {
        int num1 = 4;
        object dataClassActor;
        Task task;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 1:
                task = (Task) null;
                break;
              case 2:
                goto label_16;
              case 3:
                goto label_5;
              case 4:
                if (DataClassMetadataItemManager.DataClassMetadataPublishingEventHandler.rtT5TKCMuBsFcVwi8RWw(this.token, publicationToken))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 3 : 3;
                  continue;
                }
                DataClassMetadataItemManager.DataClassMetadataPublishingEventHandler.D28seWCMIr5HlCx0s1Dv((object) this.taskCompletionSource, (object) exception);
                num2 = 5;
                continue;
              case 5:
                object dataClassesActor = this.dataClassesActor;
                if (dataClassesActor == null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 1 : 1;
                  continue;
                }
                task = ((IDataClassesMetadataPublishingActor) dataClassesActor).PublishComplete();
                break;
              default:
                goto label_13;
            }
            if (task == null)
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 0;
            else
              goto label_14;
          }
label_13:
          dataClassActor = this.dataClassActor;
          if (dataClassActor == null)
            num1 = 2;
          else
            goto label_17;
        }
label_5:
        return (Task) DataClassMetadataItemManager.DataClassMetadataPublishingEventHandler.BbXeXXCM8Z3slftmRyiq();
label_14:
        return task;
label_16:
        return (Task) null;
label_17:
        return (Task) DataClassMetadataItemManager.DataClassMetadataPublishingEventHandler.x9ywCgCMZPdVkKIa0y0O(dataClassActor);
      }

      /// <summary>Задача ожидания окончания публикации</summary>
      public Task<UIMetadataPublishResult> Wait => this.taskCompletionSource.Task;

      internal static void BC2gVjCMvOg60h1QaNGI() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool kJgfLnCMQBvLfCKbbTrk() => DataClassMetadataItemManager.DataClassMetadataPublishingEventHandler.SqiEBqCMfmFOpP5IigtW == null;

      internal static DataClassMetadataItemManager.DataClassMetadataPublishingEventHandler VMdWRvCMCsONEakiAsUR() => (DataClassMetadataItemManager.DataClassMetadataPublishingEventHandler) DataClassMetadataItemManager.DataClassMetadataPublishingEventHandler.SqiEBqCMfmFOpP5IigtW;

      internal static object BbXeXXCM8Z3slftmRyiq() => (object) Task.CompletedTask;

      internal static object x9ywCgCMZPdVkKIa0y0O([In] object obj0) => (object) ((IDataClassMetadataPublishingActor) obj0).PublishComplete();

      internal static bool rtT5TKCMuBsFcVwi8RWw([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

      internal static bool D28seWCMIr5HlCx0s1Dv([In] object obj0, [In] object obj1) => ((TaskCompletionSource<UIMetadataPublishResult>) obj0).TrySetException((Exception) obj1);
    }
  }
}
