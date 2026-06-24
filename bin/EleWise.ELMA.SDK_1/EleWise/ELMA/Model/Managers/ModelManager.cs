// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Managers.ModelManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using AutoMapper;
using EleWise.ELMA.Events;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.DTO.Models;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Scripts.DTO.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.ScriptDesigner.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Managers
{
  /// <summary>Менеджер управления моделями приложения</summary>
  public class ModelManager : DTOManager, IModelManager, IConfigurationService
  {
    /// <summary>
    /// Имя сборки с динамическими (автогенерируемыми) моделями
    /// </summary>
    public const string DYNAMIC_MODEL_ASSEMBLY_NAME = "EleWise.ELMA.DynamicModel";
    /// <summary>Имя сборки с моделями конфигурации</summary>
    public const string CONFIGURAION_MODEL_ASSEMBLY_NAME = "EleWise.ELMA.ConfigurationModel";
    /// <summary>Имя сборки со сценариями для моделей конфигурации</summary>
    public const string CONFIGURAION_MODEL_SCRIPTS_ASSEMBLY_NAME = "EleWise.ELMA.ConfigurationModel.Scripts";
    /// <summary>Пространство имён контекста процесса</summary>
    public const string ProcessContextNamespace = "EleWise.ELMA.Model.Entities.ProcessContext";
    /// <summary>Префикс в имени процесса</summary>
    public const string ProcessPrefix = "P_";
    /// <summary>
    /// Уникальный идентификатор главного модуля сценариев для моделей конфигурации
    /// </summary>
    [Obsolete("Not used", true)]
    public static readonly Guid CONFIGURAION_MODEL_SCRIPTMODULE_UID;
    /// <summary>Имя сборки с реализациями хабов для SignalR</summary>
    public const string HubsAssemblyName = "EleWise.ELMA.SignalRHubs";
    internal static ModelManager xZq88GhCn4CfqIEblLvL;

    /// <summary>Менеджер элементов метаданных</summary>
    public MetadataItemManager MetadataItemManager => Locator.GetServiceNotNull<MetadataItemManager>();

    /// <summary>Менеджер заголовков элементов метаданных</summary>
    public IEntityManager<IMetadataItemHeader, long> MetadataItemHeaderManager => Locator.GetServiceNotNull<IEntityManager<IMetadataItemHeader, long>>();

    /// <summary>Сервис редактирования метаданных</summary>
    private IMetadataEditorService MetadataEditorService => Locator.GetServiceNotNull<IMetadataEditorService>();

    /// <summary>Сервис для ручной подписки на события</summary>
    private IEventHandlerSubscribeService EventHandlerSubscribeService => Locator.GetServiceNotNull<IEventHandlerSubscribeService>();

    /// <summary>Получить метаданные моделей сборки с указанным именем</summary>
    /// <param name="assemblyName">Имя сборки</param>
    /// <returns>Метаданные сборки</returns>
    public virtual AssemblyModelsMetadata GetAssemblyModelsMetadata(string assemblyName)
    {
      int num = 1;
      string assemblyName1;
      while (true)
      {
        switch (num)
        {
          case 1:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            assemblyName1 = assemblyName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 2 : 2;
            continue;
        }
      }
label_2:
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return Locator.GetServiceNotNull<IMetadataRuntimeService>().GetAssemblyModelsMetadataList().FirstOrDefault<AssemblyModelsMetadata>((Func<AssemblyModelsMetadata, bool>) (a => ModelManager.\u003C\u003Ec__DisplayClass15_0.dDMQMjCjHAOQmsMXgOv8(ModelManager.\u003C\u003Ec__DisplayClass15_0.GnfldACj6eNvrAeDIZ6e((object) a), (object) assemblyName1)));
    }

    /// <summary>Получить список метаданных моделей сборкок</summary>
    /// <returns>Список метаданных моделей сборок</returns>
    public virtual IEnumerable<AssemblyModelsMetadata> GetAssemblyModelsMetadataList() => Locator.GetServiceNotNull<IMetadataRuntimeService>().GetAssemblyModelsMetadataList();

    /// <summary>
    /// Получить список метаданных моделей сборкок в сжатом виде для дизайнера
    /// </summary>
    /// <returns>Список метаданных моделей сборок</returns>
    public virtual byte[] GetAssemblyModelsMetadataCompressed()
    {
      int num1 = 2;
      IEnumerable<AssemblyModelsMetadata> modelsMetadataList;
      List<AssemblyModelsMetadata> assemblyModelsMetadataList;
      IEnumerator<AssemblyModelsMetadata> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (modelsMetadataList == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 0 : 0;
              continue;
            }
            assemblyModelsMetadataList = new List<AssemblyModelsMetadata>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 5;
            continue;
          case 2:
            modelsMetadataList = this.GetAssemblyModelsMetadataList();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_8;
          case 4:
            goto label_7;
          case 5:
            enumerator = modelsMetadataList.GetEnumerator();
            num1 = 3;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return (byte[]) null;
label_7:
      return ((byte[]) ModelManager.OMlEC3hCHUGxqWnYNHuk((object) assemblyModelsMetadataList)).Zip();
label_8:
      try
      {
label_17:
        if (enumerator.MoveNext())
          goto label_10;
        else
          goto label_18;
label_9:
        AssemblyModelsMetadata current;
        AssemblyModelsMetadata assemblyModelsMetadata1;
        AbstractMetadata[] array;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 2:
              assemblyModelsMetadataList.Add(assemblyModelsMetadata1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 1 : 13;
              continue;
            case 3:
              if (ModelManager.bR6QxghCDX73BS9aKDet(ModelManager.z29Q7OhCPMhcTkZc2Z5x((object) current), ModelManager.nlotoFhCag9uM4ypVHdM(-70007027 ^ -70054517)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 5 : 8;
                continue;
              }
              goto default;
            case 4:
              AssemblyModelsMetadata assemblyModelsMetadata2 = new AssemblyModelsMetadata();
              ModelManager.rIX5UghC1gMurgMR7LBR((object) assemblyModelsMetadata2, ModelManager.z29Q7OhCPMhcTkZc2Z5x((object) current));
              ModelManager.gWL4RXhC3LRUflZDuYo2((object) assemblyModelsMetadata2, ModelManager.YDTDOPhCNKkyOb6oqrYF((object) current));
              assemblyModelsMetadata1 = assemblyModelsMetadata2;
              num2 = 5;
              continue;
            case 5:
              ModelManager.Dj0QiWhCpUgyONZZhWjx((object) assemblyModelsMetadata1, (object) array);
              num2 = 14;
              continue;
            case 6:
            case 7:
            case 8:
              ModelManager.LpfIumhCwYgld9NaN8mQ((object) assemblyModelsMetadata1, ModelManager.loksNZhCtw23224L4VxD((object) current));
              num2 = 12;
              continue;
            case 9:
              goto label_7;
            case 10:
              // ISSUE: reference to a compiler-generated method
              array = ((IEnumerable<AbstractMetadata>) ModelManager.WXIgKthCeVI1GKl0qQMc((object) current)).Select<AbstractMetadata, AbstractMetadata>((Func<AbstractMetadata, AbstractMetadata>) (m => (AbstractMetadata) MetadataLoader.LoadMetadata(ModelManager.\u003C\u003Ec.gjunNUCjmiolF3QWAjoU((object) m), false, false))).ToArray<AbstractMetadata>();
              num2 = 4;
              continue;
            case 11:
              goto label_10;
            case 12:
              ModelManager.BiMUHZhC6q21fxMhLES2((object) assemblyModelsMetadata1, ModelManager.n9IFSBhC4iP1nGSDChy6((object) current));
              num2 = 2;
              continue;
            case 13:
              goto label_17;
            case 14:
              if ((string) ModelManager.z29Q7OhCPMhcTkZc2Z5x((object) current) == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70005399))
              {
                num2 = 7;
                continue;
              }
              goto case 3;
            default:
              if (!ModelManager.bR6QxghCDX73BS9aKDet(ModelManager.z29Q7OhCPMhcTkZc2Z5x((object) current), ModelManager.nlotoFhCag9uM4ypVHdM(2008901894 << 3 ^ -1108655586)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 1 : 1;
                continue;
              }
              goto case 6;
          }
        }
label_10:
        current = enumerator.Current;
        num2 = 10;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
        {
          num2 = 3;
          goto label_9;
        }
        else
          goto label_9;
label_18:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 9 : 1;
        goto label_9;
      }
      finally
      {
        int num3;
        if (enumerator == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
        else
          goto label_29;
label_28:
        switch (num3)
        {
          case 2:
            break;
          default:
        }
label_29:
        enumerator.Dispose();
        num3 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
        {
          num3 = 1;
          goto label_28;
        }
        else
          goto label_28;
      }
    }

    /// <summary>
    /// Инициализировано ли дерево ELMA API. Если нет - возвращается False, и на сервере асинхронно начинается инициализация
    /// </summary>
    /// <returns></returns>
    public virtual bool IsElmaApiTreeInitialized() => ModelManager.lk8RakhCATWuJt7rs9hF((object) Locator.GetServiceNotNull<ElmaApiInitializerService>());

    /// <summary>Получить метаданные дерева ELMA API</summary>
    /// <returns></returns>
    public virtual byte[] GetElmaApiTree() => (byte[]) ModelManager.EWgveOhC7oOLGBJV61oW((object) Locator.GetServiceNotNull<ElmaApiInitializerService>());

    /// <summary>Получить список элементов метаданных</summary>
    /// <returns>Список элементов метаданных</returns>
    public virtual IEnumerable<MetadataItemDTO> GetMetadataItems() => (IEnumerable<MetadataItemDTO>) this.MetadataItemManager.FindDraftItems().Select<IMetadataItem, MetadataItemDTO>((Func<IMetadataItem, MetadataItemDTO>) (i => Mapper.Map<IMetadataItem, MetadataItemDTO>(i))).ToList<MetadataItemDTO>();

    /// <summary>Сохранить элементы метаданных</summary>
    /// <param name="metadataItems">Элементы метаданных</param>
    public virtual List<MetadataItemDTO> SaveMetadataItems(List<MetadataItemDTO> metadataItems)
    {
      if (metadataItems == null)
        return (List<MetadataItemDTO>) null;
      List<IMetadataItem> list = metadataItems.Select<MetadataItemDTO, IMetadataItem>((Func<MetadataItemDTO, IMetadataItem>) (dto => Mapper.Map<MetadataItemDTO, IMetadataItem>(dto))).ToList<IMetadataItem>();
      ModelManager.MetadataItemSaveEventHandler observer = new ModelManager.MetadataItemSaveEventHandler((IEnumerable<IMetadataItem>) list);
      using (this.EventHandlerSubscribeService.Subscribe((IEventHandler) observer))
        this.MetadataEditorService.SaveMetadata(list.Select<IMetadataItem, IMetadata>((Func<IMetadataItem, IMetadata>) (item => item.Metadata as IMetadata)));
      return observer.SavedItems.Select<IMetadataItem, MetadataItemDTO>((Func<IMetadataItem, MetadataItemDTO>) (i => Mapper.Map<IMetadataItem, MetadataItemDTO>(i))).ToList<MetadataItemDTO>();
    }

    /// <summary>Удалить объект метаданных</summary>
    /// <param name="metadataItemId">Идентификатор объекта метаданных</param>
    public virtual void DeleteMetadataItem(long metadataItemId)
    {
      int num = 2;
      IMetadataItem metadataItem;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (((IMetadataItemHeader) ModelManager.sHmXiihCxXUsj0ObESH7((object) metadataItem)).Published == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 2 : 3;
              continue;
            }
            goto label_4;
          case 2:
            metadataItem = this.MetadataItemManager.Load(metadataItemId);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 1;
            continue;
          case 3:
            ModelManager.NfXhG3hCmYycmFKinkcm((object) metadataItem);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 4 : 2;
            continue;
          case 4:
            goto label_7;
          default:
            goto label_4;
        }
      }
label_7:
      return;
label_4:
      throw new InvalidOperationException(EleWise.ELMA.SR.T((string) ModelManager.nlotoFhCag9uM4ypVHdM(--1867379187 ^ 1867433525), ModelManager.WtpvB1hC0jWG3hCfHZaf(ModelManager.sHmXiihCxXUsj0ObESH7((object) metadataItem))));
    }

    /// <summary>
    /// Загрузить элемент метаданных по идентификатору заголовка
    /// </summary>
    /// <param name="headerId">Элемент метаданных</param>
    public virtual MetadataItemDTO LoadMetadataItemByHeaderId(long headerId)
    {
      int num = 4;
      IMetadataItemHeader metadataItemHeader;
      IMetadataItem current;
      // ISSUE: variable of a compiler-generated type
      ModelManager.\u003C\u003Ec__DisplayClass23_0 cDisplayClass230;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            if (metadataItemHeader != null)
            {
              current = metadataItemHeader.Current;
              num = 6;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 1;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass230.headerId = headerId;
            num = 5;
            continue;
          case 4:
            // ISSUE: object of a compiler-generated type is created
            cDisplayClass230 = new ModelManager.\u003C\u003Ec__DisplayClass23_0();
            num = 3;
            continue;
          case 5:
            IEntityManager<IMetadataItemHeader, long> itemHeaderManager = this.MetadataItemHeaderManager;
            // ISSUE: type reference
            ParameterExpression parameterExpression = (ParameterExpression) ModelManager.Xjo0WJhCMsuApRQC8OGb(ModelManager.TPWnr7hCyEotu89XiG6O(__typeref (IMetadataItemHeader)), ModelManager.nlotoFhCag9uM4ypVHdM(1178210108 ^ 1178248072));
            // ISSUE: method reference
            // ISSUE: type reference
            // ISSUE: type reference
            // ISSUE: field reference
            Expression<Func<IMetadataItemHeader, bool>> condition = Expression.Lambda<Func<IMetadataItemHeader, bool>>((Expression) ModelManager.IEIMaPhCrupPXoKFxhw4(ModelManager.egkcKAhC9DjCp7d87txW((object) parameterExpression, (object) (MethodInfo) ModelManager.SyS0ZXhCJrlR7dCpBaN0(__methodref (IEntity<long>.get_Id), __typeref (IEntity<long>))), ModelManager.sAZ2rihClTYfTNFa7Pis((object) Expression.Constant((object) cDisplayClass230, ModelManager.TPWnr7hCyEotu89XiG6O(__typeref (ModelManager.\u003C\u003Ec__DisplayClass23_0))), ModelManager.OgNgWLhCdgUR07CrJTIX(__fieldref (ModelManager.\u003C\u003Ec__DisplayClass23_0.headerId)))), parameterExpression);
            metadataItemHeader = itemHeaderManager.Find(condition).FirstOrDefault<IMetadataItemHeader>();
            num = 2;
            continue;
          case 6:
            if (current == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          default:
            goto label_5;
        }
      }
label_2:
      return (MetadataItemDTO) null;
label_5:
      return (MetadataItemDTO) null;
label_6:
      return Mapper.Map<IMetadataItem, MetadataItemDTO>(current);
    }

    /// <summary>
    /// Получить опубликованные DTO для элемента метаданных по Uid
    /// </summary>
    /// <param name="uid">Уникальный идентификатор объекта метаданных</param>
    /// <returns>Опубликованные метаданные</returns>
    public virtual MetadataItemDTO GetPublishedMetadataByUid(Guid uid)
    {
      int num1 = 6;
      IMetadataItem published;
      while (true)
      {
        int num2 = num1;
        IMetadataItem metadataItem;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (published == null)
              {
                num2 = 2;
                continue;
              }
              goto label_6;
            case 2:
              goto label_5;
            case 3:
              published = metadataItem.Header.Published;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 1;
              continue;
            case 4:
              goto label_12;
            case 5:
              if (metadataItem != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
                continue;
              }
              goto label_12;
            case 6:
              goto label_7;
            default:
              if (metadataItem.Header != null)
              {
                num2 = 3;
                continue;
              }
              goto label_12;
          }
        }
label_7:
        metadataItem = this.MetadataItemManager.LoadOrNull(uid);
        num1 = 5;
      }
label_5:
      return (MetadataItemDTO) null;
label_6:
      return Mapper.Map<IMetadataItem, MetadataItemDTO>(published);
label_12:
      return (MetadataItemDTO) null;
    }

    /// <summary>Опубликовать указанные элементы метаданных</summary>
    /// <param name="comment">Комментарий к публикации</param>
    /// <param name="headerIds">Идентификаторы заголовков метаданных</param>
    /// <returns>Метаданные сборки конфигурации</returns>
    public virtual MetadataPublishResult Publish(string comment, params long[] headerIds) => this.MetadataItemManager.Publish(comment, headerIds);

    /// <summary>Запущен ли объект метаданных</summary>
    /// <param name="metadataUid">Уникальный идентификатор метаданных</param>
    /// <returns>True, если запущен</returns>
    public virtual bool IsMetadataStarted(Guid metadataUid)
    {
      int num1 = 2;
      Guid metadataUid1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            metadataUid1 = metadataUid;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
            continue;
          case 2:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 1 : 1;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return Locator.GetServiceNotNull<IMetadataRuntimeService>().GetMetadataList().Any<IMetadata>((Func<IMetadata, bool>) (m =>
      {
        int num2 = 1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              if (!ModelManager.\u003C\u003Ec__DisplayClass26_0.wDjPgpCjY9wiORphEcAP(ModelManager.\u003C\u003Ec__DisplayClass26_0.espYBcCjj18BKmohLoj7((object) m), metadataUid1))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
                continue;
              }
              goto label_4;
            case 2:
              goto label_2;
            default:
              if (m is EntityMetadata)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 1 : 2;
                continue;
              }
              goto label_3;
          }
        }
label_2:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        return ModelManager.\u003C\u003Ec__DisplayClass26_0.wDjPgpCjY9wiORphEcAP(ModelManager.\u003C\u003Ec__DisplayClass26_0.Y9gsnrCjLwLitgvbZ6SU((object) (EntityMetadata) m), metadataUid1);
label_3:
        return false;
label_4:
        return true;
      }));
    }

    /// <summary>Возвращает UID-ы запущенных метаданных</summary>
    /// <returns></returns>
    public virtual List<Guid> GetMetadataStarted() => Locator.GetServiceNotNull<IMetadataRuntimeService>().GetMetadataList().Select<IMetadata, Guid>((Func<IMetadata, Guid>) (k => ModelManager.\u003C\u003Ec.BwN5LpCjyLAgi529vkdn((object) k))).ToList<Guid>();

    /// <summary>
    /// Опубликовано ли свойство с идентификатором <paramref name="propertyUid" /> в сущности с идентификатором <paramref name="metadataUid" />
    /// </summary>
    /// <param name="metadataUid">Уникальный идентификатор метаданных сущности</param>
    /// <param name="propertyUid">Уникальный идентификатор свойства</param>
    /// <returns></returns>
    public virtual bool IsPublishedProperty(Guid metadataUid, Guid propertyUid)
    {
      int num1 = 2;
      EntityMetadata metadata;
      while (true)
      {
        int num2 = num1;
        Guid metadataUid1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_9;
            case 2:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 1 : 1;
              continue;
            case 3:
              goto label_3;
            case 4:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              metadata = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetMetadataList().OfType<EntityMetadata>().FirstOrDefault<EntityMetadata>((Func<EntityMetadata, bool>) (m => ModelManager.\u003C\u003Ec__DisplayClass28_0.Jn5aGkCYFtHL7vSlfggt(ModelManager.\u003C\u003Ec__DisplayClass28_0.I72s5mCjz1gMVB8WZaQJ((object) m), metadataUid1)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 5 : 5;
              continue;
            case 5:
              if (metadata != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            default:
              goto label_4;
          }
        }
label_9:
        metadataUid1 = metadataUid;
        num1 = 4;
      }
label_3:
      return false;
label_4:
      return this.FindProperty(metadata, propertyUid);
    }

    /// <summary>Является ли имя зарезервированным словом СУБД</summary>
    /// <param name="name">Имя</param>
    /// <returns>True, если является</returns>
    public virtual bool IsDbReservedWord(string name) => ModelManager.pb0MU5hC54D1edAWUiNB(ModelManager.AwPF8ZhCgDmvgX6ArS7j((object) Locator.GetServiceNotNull<ITransformationProvider>()), (object) name);

    /// <summary>
    /// Получить список идентификаторов объектов метаданных, для которых требуется перезапуск сервера
    /// </summary>
    /// <returns></returns>
    public virtual List<Guid> GetRestartRequiredMetadataUids() => this.MetadataItemManager.GetRestartRequiredMetadataUids();

    /// <summary>Получить главный модуль сценариев модели</summary>
    /// <returns></returns>
    [Obsolete("Not used", true)]
    public virtual ScriptModuleDTO GetModelScriptModule() => (ScriptModuleDTO) null;

    /// <summary>Сохранить главный модуль сценариев модели</summary>
    /// <param name="scriptModuleDto">Модуль сценариев</param>
    [Obsolete("Not used", true)]
    public virtual void SaveModelScriptModule(ScriptModuleDTO scriptModuleDto)
    {
    }

    [Obsolete("Not used", true)]
    public static ScriptModuleDTO CreateModelScriptModule()
    {
      ScriptModuleDTO modelScriptModule = new ScriptModuleDTO();
      ModelManager.i2KhuyhCjpkCuhNNpnYo((object) modelScriptModule, ModelManager.CONFIGURAION_MODEL_SCRIPTMODULE_UID);
      modelScriptModule.AssemblyName = (string) ModelManager.nlotoFhCag9uM4ypVHdM(-1290212282 ^ -644262414 ^ 1786868530);
      ModelManager.PLyw3GhCYRpHZ8JJugq7((object) modelScriptModule, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -36041899));
      return modelScriptModule;
    }

    /// <summary>
    /// Добавить в главный модуль сценариев модули указанные ссылки на сборки
    /// </summary>
    /// <param name="references"></param>
    [Obsolete("Not used", true)]
    public virtual void AddModelScriptModuleReferences(IEnumerable<string> references)
    {
    }

    /// <summary>Получить информацию о сущности</summary>
    /// <param name="typeUid">Уникальный идентификатор типа сущности</param>
    /// <param name="id">Идентификатор сущности</param>
    /// <returns>Информация о сущности</returns>
    public virtual EntityInfo GetEntityInfo(Guid typeUid, string id)
    {
      int num1 = 7;
      EntityInfo entityInfo1;
      while (true)
      {
        int num2 = num1;
        Guid propertyValue;
        PropertyMetadata propertyMetadata;
        ClassMetadata metadata;
        Type type;
        string id1;
        IEntity entity;
        IEntityManager manager;
        while (true)
        {
          switch (num2)
          {
            case 1:
              metadata = (ClassMetadata) MetadataLoader.LoadMetadata(type);
              num2 = 12;
              continue;
            case 2:
            case 14:
              propertyMetadata = (PropertyMetadata) ModelManager.JnEId5hCcNWNkWXpsE14((object) metadata);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
              continue;
            case 3:
            case 16:
              goto label_8;
            case 4:
              ModelManager.ey4v3RhCLpn12cMI9m2O((object) Locator.GetServiceNotNull<ISecurityService>(), (object) (System.Action) (() =>
              {
                int num3 = 1;
                object obj;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      obj = ModelManager.\u003C\u003Ec__DisplayClass35_0.cFgRltCYbR9j3ylZRwbR(type, (object) id1);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 0;
                      continue;
                    case 2:
                      // ISSUE: reference to a compiler-generated method
                      entity = (IEntity) ModelManager.\u003C\u003Ec__DisplayClass35_0.CPGM3GCYh2DB6b8EwO0G((object) manager, obj);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 2 : 3;
                      continue;
                    case 3:
                      goto label_2;
                    default:
                      if (obj != null)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 2 : 2;
                        continue;
                      }
                      goto label_7;
                  }
                }
label_2:
                return;
label_7:;
              }));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 14 : 18;
              continue;
            case 5:
              manager = ModelHelper.GetEntityManager(type);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 11 : 8;
              continue;
            case 6:
              id1 = id;
              num2 = 10;
              continue;
            case 7:
              num2 = 6;
              continue;
            case 8:
              if (propertyValue != Guid.Empty)
              {
                num2 = 13;
                continue;
              }
              goto label_8;
            case 9:
              propertyValue = entity.GetPropertyValue<Guid>(ModelManager.bEJc6JhCzgGUrK89Qhuc((object) propertyMetadata));
              num2 = 8;
              continue;
            case 10:
              type = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(typeUid);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 2 : 5;
              continue;
            case 11:
              entity = (IEntity) null;
              num2 = 4;
              continue;
            case 12:
              if (!this.HasTitleProperty(metadata))
              {
                num2 = 14;
                continue;
              }
              goto case 17;
            case 13:
              goto label_9;
            case 15:
              goto label_4;
            case 17:
              entityInfo1.Title = entity.ToString();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 2 : 1;
              continue;
            case 18:
              if (entity != null)
              {
                EntityInfo entityInfo2 = new EntityInfo();
                ModelManager.bwwodGhCUllyfKRV4cgh((object) entityInfo2, (object) id1);
                ModelManager.Rehj13hCsSZqtLu3tlg7((object) entityInfo2, typeUid);
                entityInfo1 = entityInfo2;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 1 : 1;
                continue;
              }
              num2 = 15;
              continue;
            default:
              if (propertyMetadata == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 16 : 4;
                continue;
              }
              goto case 9;
          }
        }
label_9:
        ModelManager.qg3TKLhvFFW9e5TCDGIs((object) entityInfo1, propertyValue);
        num1 = 3;
      }
label_4:
      return (EntityInfo) null;
label_8:
      return entityInfo1;
    }

    private bool FindProperty(EntityMetadata metadata, Guid propertyUid)
    {
      int num1 = 3;
      List<TablePartMetadata>.Enumerator enumerator;
      Guid propertyUid1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_22;
          case 2:
            propertyUid1 = propertyUid;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 5 : 2;
            continue;
          case 3:
            num1 = 2;
            continue;
          case 4:
            enumerator = metadata.TableParts.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            if (!metadata.Properties.Any<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => ModelManager.\u003C\u003Ec__DisplayClass36_0.nEfNbUCYvOo3U8WN9rEV(ModelManager.\u003C\u003Ec__DisplayClass36_0.ifueFDCYCqL4oPeHSIZq((object) p), propertyUid1))))
            {
              num1 = 4;
              continue;
            }
            goto label_22;
          case 6:
            goto label_24;
          default:
            goto label_3;
        }
      }
label_3:
      bool property;
      try
      {
label_9:
        if (enumerator.MoveNext())
          goto label_11;
        else
          goto label_10;
label_5:
        TablePartMetadata current;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_9;
            case 2:
              goto label_24;
            case 3:
              property = true;
              num2 = 4;
              continue;
            case 4:
            case 8:
              goto label_25;
            case 5:
              if (this.FindProperty((EntityMetadata) current, propertyUid1))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
                continue;
              }
              goto label_9;
            case 6:
              if (ModelManager.wh4veChvWPH0743NQHqP(ModelManager.DsQPF8hvBOM2nhdLZYe6((object) current), propertyUid1))
              {
                num2 = 3;
                continue;
              }
              goto case 5;
            case 7:
              goto label_11;
            default:
              property = true;
              num2 = 8;
              continue;
          }
        }
label_10:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 2 : 0;
        goto label_5;
label_11:
        current = enumerator.Current;
        num2 = 6;
        goto label_5;
      }
      finally
      {
        enumerator.Dispose();
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
label_25:
      return property;
label_22:
      return true;
label_24:
      return false;
    }

    private bool HasTitleProperty(ClassMetadata metadata)
    {
      int num = 1;
      ClassMetadata metadata1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!ModelManager.jgPZGUhvomZPPs6HIocN(metadata.TitlePropertyUid, Guid.Empty))
            {
              if (!ModelManager.jgPZGUhvomZPPs6HIocN(ModelManager.d1vP9shvbxN5pYewdnaZ((object) metadata), Guid.Empty))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 2 : 1;
                continue;
              }
              goto case 4;
            }
            else
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 0 : 0;
              continue;
            }
          case 2:
            goto label_7;
          case 3:
            goto label_6;
          case 4:
            metadata1 = (ClassMetadata) Locator.GetServiceNotNull<IMetadataRuntimeService>().GetMetadata(metadata.BaseClassUid);
            num = 3;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return true;
label_6:
      return this.HasTitleProperty(metadata1);
label_7:
      return false;
    }

    public ModelManager()
    {
      ModelManager.JKJJGyhvhDrOHKtRUHR7();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static ModelManager()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ModelManager.CONFIGURAION_MODEL_SCRIPTMODULE_UID = new Guid((string) ModelManager.nlotoFhCag9uM4ypVHdM(381945751 ^ 1158627804 ^ 1405648395));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 0 : 0;
            continue;
          case 2:
            ModelManager.JKJJGyhvhDrOHKtRUHR7();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool Fxg5XBhCOhsVMGTDiPgt() => ModelManager.xZq88GhCn4CfqIEblLvL == null;

    internal static ModelManager Tmd1hShC2sa6bkKYRhlh() => ModelManager.xZq88GhCn4CfqIEblLvL;

    internal static object WXIgKthCeVI1GKl0qQMc([In] object obj0) => (object) ((AssemblyModelsMetadata) obj0).RestoreMetadata();

    internal static object z29Q7OhCPMhcTkZc2Z5x([In] object obj0) => (object) ((AssemblyModelsMetadata) obj0).Name;

    internal static void rIX5UghC1gMurgMR7LBR([In] object obj0, [In] object obj1) => ((AssemblyModelsMetadata) obj0).Name = (string) obj1;

    internal static AssemblyModelsMetadataStatus YDTDOPhCNKkyOb6oqrYF([In] object obj0) => ((AssemblyModelsMetadata) obj0).Status;

    internal static void gWL4RXhC3LRUflZDuYo2([In] object obj0, AssemblyModelsMetadataStatus value) => ((AssemblyModelsMetadata) obj0).Status = value;

    internal static void Dj0QiWhCpUgyONZZhWjx([In] object obj0, [In] object obj1) => ((AssemblyModelsMetadata) obj0).SetMetadata((AbstractMetadata[]) obj1);

    internal static object nlotoFhCag9uM4ypVHdM(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool bR6QxghCDX73BS9aKDet([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static object loksNZhCtw23224L4VxD([In] object obj0) => (object) ((AssemblyModelsMetadata) obj0).AssemblyRawStream;

    internal static void LpfIumhCwYgld9NaN8mQ([In] object obj0, [In] object obj1) => ((AssemblyModelsMetadata) obj0).AssemblyRawStream = (MemoryStream) obj1;

    internal static object n9IFSBhC4iP1nGSDChy6([In] object obj0) => (object) ((AssemblyModelsMetadata) obj0).DocumentationRawStream;

    internal static void BiMUHZhC6q21fxMhLES2([In] object obj0, [In] object obj1) => ((AssemblyModelsMetadata) obj0).DocumentationRawStream = (MemoryStream) obj1;

    internal static object OMlEC3hCHUGxqWnYNHuk([In] object obj0) => (object) ClassSerializationHelper.SerializeObject(obj0);

    internal static bool lk8RakhCATWuJt7rs9hF([In] object obj0) => ((ElmaApiInitializerService) obj0).IsApiTreeInitialized();

    internal static object EWgveOhC7oOLGBJV61oW([In] object obj0) => (object) ((ElmaApiInitializerService) obj0).GetZippedApiTree();

    internal static object sHmXiihCxXUsj0ObESH7([In] object obj0) => (object) ((IMetadataItem) obj0).Header;

    internal static object WtpvB1hC0jWG3hCfHZaf([In] object obj0) => (object) ((IMetadataItemHeader) obj0).DisplayName;

    internal static void NfXhG3hCmYycmFKinkcm([In] object obj0) => ((IEntity) obj0).Delete();

    internal static Type TPWnr7hCyEotu89XiG6O([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object Xjo0WJhCMsuApRQC8OGb([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static object SyS0ZXhCJrlR7dCpBaN0([In] RuntimeMethodHandle obj0, [In] RuntimeTypeHandle obj1) => (object) MethodBase.GetMethodFromHandle(obj0, obj1);

    internal static object egkcKAhC9DjCp7d87txW([In] object obj0, [In] object obj1) => (object) Expression.Property((Expression) obj0, (MethodInfo) obj1);

    internal static object OgNgWLhCdgUR07CrJTIX([In] RuntimeFieldHandle obj0) => (object) FieldInfo.GetFieldFromHandle(obj0);

    internal static object sAZ2rihClTYfTNFa7Pis([In] object obj0, [In] object obj1) => (object) Expression.Field((Expression) obj0, (FieldInfo) obj1);

    internal static object IEIMaPhCrupPXoKFxhw4([In] object obj0, [In] object obj1) => (object) Expression.Equal((Expression) obj0, (Expression) obj1);

    internal static object AwPF8ZhCgDmvgX6ArS7j([In] object obj0) => (object) ((ITransformationProvider) obj0).Dialect;

    internal static bool pb0MU5hC54D1edAWUiNB([In] object obj0, [In] object obj1) => ((Dialect) obj0).IsReservedWord((string) obj1);

    internal static void i2KhuyhCjpkCuhNNpnYo([In] object obj0, Guid value) => ((ScriptModuleDTO) obj0).Uid = value;

    internal static void PLyw3GhCYRpHZ8JJugq7([In] object obj0, [In] object obj1) => ((ScriptModuleDTO) obj0).ModuleName = (string) obj1;

    internal static void ey4v3RhCLpn12cMI9m2O([In] object obj0, [In] object obj1) => ((ISecurityService) obj0).RunWithElevatedPrivilegies((System.Action) obj1);

    internal static void bwwodGhCUllyfKRV4cgh([In] object obj0, [In] object obj1) => ((EntityInfo) obj0).Id = (string) obj1;

    internal static void Rehj13hCsSZqtLu3tlg7([In] object obj0, Guid value) => ((EntityInfo) obj0).TypeUid = value;

    internal static object JnEId5hCcNWNkWXpsE14([In] object obj0) => (object) ((ClassMetadata) obj0).GetUidProperty();

    internal static Guid bEJc6JhCzgGUrK89Qhuc([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static void qg3TKLhvFFW9e5TCDGIs([In] object obj0, Guid value) => ((EntityInfo) obj0).Uid = value;

    internal static Guid DsQPF8hvBOM2nhdLZYe6([In] object obj0) => ((TablePartMetadata) obj0).TablePartPropertyUid;

    internal static bool wh4veChvWPH0743NQHqP([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static bool jgPZGUhvomZPPs6HIocN([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static Guid d1vP9shvbxN5pYewdnaZ([In] object obj0) => ((ClassMetadata) obj0).BaseClassUid;

    internal static void JKJJGyhvhDrOHKtRUHR7() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    private class MetadataItemSaveEventHandler : IMetadataItemSaveEventHandler, IEventHandler
    {
      private readonly IDictionary<Guid, IMetadataItem> metadataItems;
      internal static object WAE340CjOMwSCJlpr9Da;

      public MetadataItemSaveEventHandler(IEnumerable<IMetadataItem> metadataItems)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        this.SavedItems = new List<IMetadataItem>();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        // ISSUE: reference to a compiler-generated method
        this.metadataItems = (IDictionary<Guid, IMetadataItem>) metadataItems.ToDictionary<IMetadataItem, Guid>((Func<IMetadataItem, Guid>) (i => ModelManager.MetadataItemSaveEventHandler.\u003C\u003Ec.BkZfZZZSXpCZxGTn0ghv((object) i)));
      }

      public void BeforeSave(IMetadataItem metadataItem)
      {
        int num = 3;
        IMetadataItem metadataItem1;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.SavedItems.Add(metadataItem);
              num = 4;
              continue;
            case 2:
              ModelManager.MetadataItemSaveEventHandler.mgJ2CUCjNgyx17qdkBxZ((object) metadataItem, ModelManager.MetadataItemSaveEventHandler.OoGfZpCj1T3h5YHDw8Js((object) metadataItem1));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 0;
              continue;
            case 3:
              if (this.metadataItems.TryGetValue(ModelManager.MetadataItemSaveEventHandler.oSaKpNCjPk1WEehlcq2l((object) metadataItem), out metadataItem1))
              {
                num = 2;
                continue;
              }
              goto label_10;
            case 4:
              goto label_2;
            case 5:
              ModelManager.MetadataItemSaveEventHandler.wvlm1bCjp23fx6kP6d6o((object) metadataItem, (object) metadataItem1.ClientScriptModule);
              num = 6;
              continue;
            case 6:
              ModelManager.MetadataItemSaveEventHandler.cbfeP1CjDDNSv6vSoIPX((object) metadataItem, ModelManager.MetadataItemSaveEventHandler.ql1A9eCjakoHNDAr27kM((object) metadataItem1));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 1 : 1;
              continue;
            default:
              ModelManager.MetadataItemSaveEventHandler.Lp2VgDCj3o0U6vwJARcd((object) metadataItem, (object) metadataItem1.ScriptModule);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 4 : 5;
              continue;
          }
        }
label_2:
        return;
label_10:;
      }

      public List<IMetadataItem> SavedItems { get; }

      internal static Guid oSaKpNCjPk1WEehlcq2l([In] object obj0) => ((IMetadataItem) obj0).Uid;

      internal static object OoGfZpCj1T3h5YHDw8Js([In] object obj0) => (object) ((IMetadataItem) obj0).Comment;

      internal static void mgJ2CUCjNgyx17qdkBxZ([In] object obj0, [In] object obj1) => ((IMetadataItem) obj0).Comment = (string) obj1;

      internal static void Lp2VgDCj3o0U6vwJARcd([In] object obj0, [In] object obj1) => ((IMetadataItem) obj0).ScriptModule = (ScriptModule) obj1;

      internal static void wvlm1bCjp23fx6kP6d6o([In] object obj0, [In] object obj1) => ((IMetadataItem) obj0).ClientScriptModule = (ScriptModule) obj1;

      internal static object ql1A9eCjakoHNDAr27kM([In] object obj0) => ((IMetadataItem) obj0).Dependencies;

      internal static void cbfeP1CjDDNSv6vSoIPX([In] object obj0, [In] object obj1) => ((IMetadataItem) obj0).Dependencies = obj1;

      internal static bool z2UURgCj2K0IS0TEJ0mv() => ModelManager.MetadataItemSaveEventHandler.WAE340CjOMwSCJlpr9Da == null;

      internal static ModelManager.MetadataItemSaveEventHandler LumU07CjecpjOMQBjPwl() => (ModelManager.MetadataItemSaveEventHandler) ModelManager.MetadataItemSaveEventHandler.WAE340CjOMwSCJlpr9Da;
    }
  }
}
