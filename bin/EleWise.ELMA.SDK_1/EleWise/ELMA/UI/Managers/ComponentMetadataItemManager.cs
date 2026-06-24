// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Managers.ComponentMetadataItemManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Actions;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Events;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Scripts.Manager;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Scripts;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Actors;
using EleWise.ELMA.UI.Events;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using EleWise.ELMA.UI.Scripts;
using j3AmrhgkCleVTGdEwA;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using NHibernate.Transform;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.UI.Managers
{
  /// <summary>Менеджер метаданных компонента</summary>
  internal class ComponentMetadataItemManager : 
    EntityManager<ComponentMetadataItem, long>,
    IComponentMetadataItemManager,
    IEntityManager<ComponentMetadataItem, long>,
    IEntityManager<ComponentMetadataItem>,
    IEntityManager
  {
    private readonly ScriptModuleManager scriptModuleManager;
    private readonly IComponentMetadataItemHeaderManager headerManager;
    private readonly IDependencyService dependencyService;
    private readonly ISearchMetadataService searchMetadataService;
    private readonly IScriptService scriptService;
    private readonly IActorModelRuntime actorModelRuntime;
    private readonly IEventHandlerSubscribeService eventHandlerSubscribeService;
    private readonly FetchOptions fetchOptions;
    private static readonly Dictionary<Guid, ComponentMetadataItem> SystemComponents;
    private readonly ConcurrentDictionary<string, ComponentMetadataItem> componentCache;
    private IEnumerable<IEntityFilterProvider> entityFilterProviders;
    internal static ComponentMetadataItemManager bVmjL4BQP30Gi5fmJCL2;

    private IEnumerable<IEntityFilterProvider> EntityFilterProviders => this.entityFilterProviders ?? (this.entityFilterProviders = Locator.GetServiceNotNull<IEnumerable<IEntityFilterProvider>>());

    /// <summary>Ctor</summary>
    /// <param name="scriptModuleManager">Менеджер сценариев объектов</param>
    /// <param name="headerManager">Менеджер заголовков метаданных компонента</param>
    /// <param name="dependencyService">Сервис по работе с зависимостями</param>
    /// <param name="searchMetadataService">Сервис поиска метаданных</param>
    /// <param name="scriptService">Сервис скриптов</param>
    /// <param name="actorModelRuntime">Среда исполнения акторов</param>
    /// <param name="eventHandlerSubscribeService">Сервис для ручной подписки на события</param>
    public ComponentMetadataItemManager(
      ScriptModuleManager scriptModuleManager,
      IComponentMetadataItemHeaderManager headerManager,
      IDependencyService dependencyService,
      ISearchMetadataService searchMetadataService,
      IScriptService scriptService,
      IActorModelRuntime actorModelRuntime,
      IEventHandlerSubscribeService eventHandlerSubscribeService)
    {
      ComponentMetadataItemManager.RZpyeGBQ3SIGWyTcgeQj();
      this.fetchOptions = new FetchOptions(0, 0, ListSortDirection.Descending, (string) ComponentMetadataItemManager.p1eQFWBQp3nubCPsNAyi(-244066886 - -48452443 ^ -195568663));
      this.componentCache = new ConcurrentDictionary<string, ComponentMetadataItem>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.searchMetadataService = searchMetadataService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 5;
            continue;
          case 2:
            this.eventHandlerSubscribeService = eventHandlerSubscribeService;
            num = 6;
            continue;
          case 3:
            this.actorModelRuntime = actorModelRuntime;
            num = 2;
            continue;
          case 4:
            this.scriptModuleManager = scriptModuleManager;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 5 : 7;
            continue;
          case 5:
            this.scriptService = scriptService;
            num = 3;
            continue;
          case 6:
            goto label_2;
          case 7:
            this.headerManager = headerManager;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
            continue;
          default:
            this.dependencyService = dependencyService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 1 : 1;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Экземпляр менеджера</summary>
    public static ComponentMetadataItemManager Instance => Locator.GetServiceNotNull<ComponentMetadataItemManager>();

    /// <inheritdoc />
    public override ComponentMetadataItem Load(Guid uid)
    {
      int num = 1;
      ComponentMetadataItem componentMetadataItem;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (ComponentMetadataItemManager.SystemComponents.TryGetValue(uid, out componentMetadataItem))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 0;
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
      return base.Load(uid);
label_5:
      return componentMetadataItem;
    }

    /// <inheritdoc />
    public override ComponentMetadataItem LoadOrNull(Guid uid)
    {
      int num = 2;
      ComponentMetadataItem componentMetadataItem;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (ComponentMetadataItemManager.SystemComponents.TryGetValue(uid, out componentMetadataItem))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 1 : 1;
              continue;
            }
            goto label_2;
          default:
            goto label_2;
        }
      }
label_2:
      return base.LoadOrNull(uid);
label_3:
      return componentMetadataItem;
    }

    /// <inheritdoc />
    public ComponentMetadataItem Create(
      Guid typeUid,
      Guid moduleUid,
      Guid groupUid,
      string displayName)
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_9;
          case 2:
            goto label_6;
          case 3:
            if (!ComponentMetadataItemManager.Eqx94eBQapfobBrKCMjv(typeUid, PortletComponentMetadata.TypeUid))
            {
              if (!ComponentMetadataItemManager.Eqx94eBQapfobBrKCMjv(typeUid, ComponentMetadata.TypeUid))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 1 : 5;
                continue;
              }
              goto label_4;
            }
            else
            {
              num = 2;
              continue;
            }
          case 4:
            if (!ComponentMetadataItemManager.Eqx94eBQapfobBrKCMjv(typeUid, PageComponentMetadata.TypeUid))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 3;
              continue;
            }
            goto label_9;
          case 5:
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return this.CreateComponent(moduleUid, groupUid, displayName);
label_5:
      return (ComponentMetadataItem) null;
label_6:
      return this.CreatePortlet(moduleUid, groupUid, displayName);
label_9:
      return this.CreatePage(moduleUid, groupUid, displayName);
    }

    /// <summary>Создание компонента в модуле</summary>
    /// <param name="metadata">Метаданные компонента</param>
    /// <param name="groupUid">Уникальный идентификатор группы</param>
    /// <param name="displayName">Отображаемое имя</param>
    /// <returns>Элемент метаданных компонента</returns>
    [Transaction]
    public virtual ComponentMetadataItem Create(
      ComponentMetadata metadata,
      Guid groupUid,
      string displayName)
    {
      int num = 12;
      ComponentMetadataItem componentMetadataItem;
      string assemblyName;
      while (true)
      {
        switch (num)
        {
          case 1:
            ComponentMetadataItemManager.pBMHXqBQxm85fXuC1Jfc((object) componentMetadataItem, (object) this.CreateScriptModule(ComponentClientScriptModuleType.TypeUid, metadata, assemblyName));
            num = 4;
            continue;
          case 2:
            this.Save(componentMetadataItem);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 0;
            continue;
          case 3:
            assemblyName = ComponentMetadataHelper.ClientAssemblyName(metadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 1 : 1;
            continue;
          case 4:
            metadata.ScriptUid = new Guid?(ComponentMetadataItemManager.uNbcViBQmqexv2WGRfgK(ComponentMetadataItemManager.IbYRvaBQ0U45VEjSmBLN((object) componentMetadataItem)));
            num = 8;
            continue;
          case 5:
            ComponentMetadataItemManager.XvnshbBQHTG3BKhkjfyw(ComponentMetadataItemManager.VtBN2rBQ4iiKJQ8RlloM((object) componentMetadataItem), (object) ((AbstractNHEntityManager<MetadataItemGroupUI, long>) ComponentMetadataItemManager.IMgWBgBQ6pRFeS1jNYRd()).LoadOrNull(groupUid));
            num = 7;
            continue;
          case 6:
            metadata.Name = displayName.ToTranslitIdent();
            num = 10;
            continue;
          case 7:
            ComponentMetadataItemManager.kItsR1BQ7o9fkG1ifvJT((object) componentMetadataItem, (object) this.CreateScriptModule(ComponentScriptModuleType.TypeUid, metadata, (string) ComponentMetadataItemManager.M0pBpEBQAGHcjWUoQWGj((object) metadata)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 2 : 3;
            continue;
          case 8:
            metadata.ClientScriptUid = new Guid?(ComponentMetadataItemManager.uNbcViBQmqexv2WGRfgK((object) componentMetadataItem.ClientScriptModule));
            num = 2;
            continue;
          case 9:
            ComponentMetadataItemManager.g5BEDNBQwvBastcmvaDk((object) metadata, (object) displayName);
            num = 6;
            continue;
          case 10:
            componentMetadataItem = this.CreateItem(metadata);
            num = 5;
            continue;
          case 11:
            ComponentMetadataItemManager.wnrpEfBQtTn6tQKYAxjO((object) metadata);
            num = 9;
            continue;
          case 12:
            ComponentMetadataItemManager.IOJhWpBQDOSIS5lUTHSU((object) metadata, ComponentMetadataItemManager.p1eQFWBQp3nubCPsNAyi(92412609 - 1050237057 ^ -957838466));
            num = 11;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return componentMetadataItem;
    }

    /// <inheritdoc />
    [Transaction]
    public virtual ComponentMetadataItem Copy(Guid headerUid)
    {
      int num1 = 19;
      ComponentMetadata componentMetadata1;
      ComponentMetadata metadata;
      ComponentMetadataItem draft;
      ComponentMetadataItem current;
      string assemblyName1;
      int num2;
      string name;
      string assemblyName2;
      ComponentMetadataItemHeader metadataItemHeader;
      while (true)
      {
        switch (num1)
        {
          case 1:
            base.Save(current);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 21 : 14;
            continue;
          case 2:
            assemblyName2 = (string) ComponentMetadataItemManager.M0pBpEBQAGHcjWUoQWGj((object) metadata);
            num1 = 7;
            continue;
          case 3:
            assemblyName1 = ComponentMetadataHelper.ClientAssemblyName(metadata);
            num1 = 11;
            continue;
          case 4:
            ComponentMetadataItemManager.XvnshbBQHTG3BKhkjfyw((object) current.Header, ComponentMetadataItemManager.iDnnkuBQrEFk0lyx9loB((object) metadataItemHeader));
            num1 = 2;
            continue;
          case 5:
            componentMetadata1 = (ComponentMetadata) ComponentMetadataItemManager.XMuSrwBQy5wfVHbOLc7y((object) draft);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 8 : 3;
            continue;
          case 6:
            draft = metadataItemHeader.Draft;
            num1 = 5;
            continue;
          case 7:
            ComponentMetadataItemManager.kItsR1BQ7o9fkG1ifvJT((object) current, (object) this.CreateScriptModule(ComponentScriptModuleType.TypeUid, (string) ComponentMetadataItemManager.YStk1QBQgZg6TIPsc448((object) metadata), assemblyName2, (ScriptModule) ComponentMetadataItemManager.IbYRvaBQ0U45VEjSmBLN((object) draft)));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 17 : 1;
            continue;
          case 8:
            metadata = ClassSerializationHelper.CloneObjectByXml<ComponentMetadata>(componentMetadata1);
            num1 = 12;
            continue;
          case 9:
            ComponentMetadataItemManager.g5BEDNBQwvBastcmvaDk((object) metadata, ComponentMetadataItemManager.lKmpFJBQlV1EHesxGkNV(ComponentMetadataItemManager.p1eQFWBQp3nubCPsNAyi(372753449 ^ 372717363), (object) metadata.DisplayName, (object) num2));
            num1 = 10;
            continue;
          case 10:
            current = this.CreateItem(metadata);
            num1 = 4;
            continue;
          case 11:
            ComponentMetadataItemManager.pBMHXqBQxm85fXuC1Jfc((object) current, (object) this.CreateScriptModule(ComponentClientScriptModuleType.TypeUid, (string) ComponentMetadataItemManager.YStk1QBQgZg6TIPsc448((object) metadata), assemblyName1, draft.ClientScriptModule));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 22 : 22;
            continue;
          case 12:
            name = metadata.Name;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 0 : 0;
            continue;
          case 13:
            ComponentMetadata componentMetadata2 = metadata;
            object obj1 = ComponentMetadataItemManager.mMduoxBQLtliXUYCW7u0((object) current);
            Guid? nullable1 = obj1 != null ? new Guid?(ComponentMetadataItemManager.uNbcViBQmqexv2WGRfgK(obj1)) : new Guid?();
            componentMetadata2.TestScriptUid = nullable1;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 14 : 3;
            continue;
          case 14:
            this.Rename(current, name);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 1 : 0;
            continue;
          case 15:
            ComponentMetadataItemManager.sZd8aVBQYegI5tqZ2924((object) current, (object) this.CreateScriptModule(ComponentViewScriptModuleType.TypeUid, (string) ComponentMetadataItemManager.YStk1QBQgZg6TIPsc448((object) metadata), assemblyName1, (ScriptModule) ComponentMetadataItemManager.DVvZu8BQjP53pVIoyZtR((object) draft)));
            num1 = 20;
            continue;
          case 16:
            ComponentMetadataItemManager.J1UK0ABQdJust4Z7Vecy((object) metadata, (object) string.Format((string) ComponentMetadataItemManager.p1eQFWBQp3nubCPsNAyi(-630932142 - 1120244082 ^ -1751131910), (object) metadata.Name, (object) num2));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 1 : 9;
            continue;
          case 17:
            ComponentMetadata componentMetadata3 = metadata;
            object obj2 = ComponentMetadataItemManager.IbYRvaBQ0U45VEjSmBLN((object) current);
            Guid? nullable2 = obj2 == null ? new Guid?() : new Guid?(ComponentMetadataItemManager.uNbcViBQmqexv2WGRfgK(obj2));
            componentMetadata3.ScriptUid = nullable2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 3 : 3;
            continue;
          case 18:
            metadataItemHeader = this.headerManager.Load(headerUid);
            num1 = 6;
            continue;
          case 19:
            num2 = new Random().Next(0, 10000);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 18 : 3;
            continue;
          case 20:
            ComponentMetadata componentMetadata4 = metadata;
            object obj3 = ComponentMetadataItemManager.DVvZu8BQjP53pVIoyZtR((object) current);
            Guid? nullable3 = obj3 == null ? new Guid?() : new Guid?(ComponentMetadataItemManager.uNbcViBQmqexv2WGRfgK(obj3));
            componentMetadata4.ViewScriptUid = nullable3;
            num1 = 24;
            continue;
          case 21:
            goto label_6;
          case 22:
            ComponentMetadata componentMetadata5 = metadata;
            object obj4 = ComponentMetadataItemManager.v5UAQ0BQ5OMsrpaiukp4((object) current);
            Guid? nullable4 = obj4 != null ? new Guid?(ComponentMetadataItemManager.uNbcViBQmqexv2WGRfgK(obj4)) : new Guid?();
            componentMetadata5.ClientScriptUid = nullable4;
            num1 = 15;
            continue;
          case 23:
            ComponentMetadataItemManager.WwqFsyBQ9QQJtuov6jos((object) metadata, ComponentMetadataItemManager.fFbiVjBQJnd1tBnhXuHX((object) componentMetadata1));
            num1 = 16;
            continue;
          case 24:
            current.TestScriptModule = this.CreateScriptModule(TestScriptModuleType.TypeUid, metadata.Name, assemblyName1, draft.TestScriptModule);
            num1 = 13;
            continue;
          default:
            ComponentMetadataItemManager.TvOIPWBQMX8pBNuR23RS((object) metadata);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 9 : 23;
            continue;
        }
      }
label_6:
      return current;
    }

    /// <summary>Можно ли отметить версию как не рабочую</summary>
    /// <param name="obj"></param>
    [ActionCheck("ab615fac-fc87-4672-b68e-173bf0b24c60")]
    public virtual ActionCheckResult CanMarkAsNotWorking(ComponentMetadataItem obj)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (obj == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 0;
              continue;
            }
            if (obj.IsWork)
            {
              num = 3;
              continue;
            }
            goto label_7;
          case 2:
            goto label_7;
          case 3:
            goto label_8;
          default:
            goto label_4;
        }
      }
label_4:
      return ActionCheckResult.False((string) ComponentMetadataItemManager.r2oKIBBQUNcalQ6uItoW(ComponentMetadataItemManager.p1eQFWBQp3nubCPsNAyi(-1380439818 << 3 ^ 1841411204)));
label_7:
      return ComponentMetadataItemManager.yM4EiBBQskcALLCMg2l1((object) EleWise.ELMA.SR.T((string) ComponentMetadataItemManager.p1eQFWBQp3nubCPsNAyi(1642859704 ^ 1642921962)));
label_8:
      return ComponentMetadataItemManager.APUdbwBQcnKvr2ekVmtV();
    }

    /// <inheritdoc />
    [ActionMethod("ab615fac-fc87-4672-b68e-173bf0b24c60")]
    [Transaction]
    public virtual void MarkAsNotWorking(ComponentMetadataItem obj)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            obj.IsWork = false;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            base.Save(obj);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    /// <inheritdoc />
    public void Rename(ComponentMetadataItem current, string oldName)
    {
      int num1 = 6;
      while (true)
      {
        int num2 = num1;
        string name;
        string assemblyName;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_4;
            case 2:
              this.UpdateScriptModule((ScriptModule) ComponentMetadataItemManager.IbYRvaBQ0U45VEjSmBLN((object) current), oldName, name, (string) ComponentMetadataItemManager.M0pBpEBQAGHcjWUoQWGj((object) metadata));
              num2 = 7;
              continue;
            case 3:
              goto label_3;
            case 4:
              this.UpdateScriptModule(current.ClientScriptModule, oldName, name, assemblyName);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
              continue;
            case 5:
              if (!(ComponentMetadataItemManager.XMuSrwBQy5wfVHbOLc7y((object) current) is ComponentMetadata metadata))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 1;
                continue;
              }
              name = metadata.Name;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 1 : 2;
              continue;
            case 6:
              goto label_11;
            case 7:
              assemblyName = ComponentMetadataHelper.ClientAssemblyName(metadata);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 7 : 8;
              continue;
            case 8:
              this.UpdateScriptModule((ScriptModule) ComponentMetadataItemManager.mMduoxBQLtliXUYCW7u0((object) current), oldName, name, assemblyName);
              num2 = 4;
              continue;
            default:
              this.UpdateScriptModule(current.ViewScriptModule, oldName, name, assemblyName);
              num2 = 3;
              continue;
          }
        }
label_11:
        ComponentMetadataItemManager.IOJhWpBQDOSIS5lUTHSU((object) current, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1654249598 >> 2 ^ 413566367));
        num1 = 5;
      }
label_4:
      return;
label_3:;
    }

    /// <inheritdoc />
    public override void Save(ComponentMetadataItem obj)
    {
      int num1 = 2;
      ComponentMetadata metadata;
      string errorMessage;
      while (true)
      {
        int num2 = num1;
        Guid? nullable;
        List<IMetadata> list1;
        MetadataServiceContext metadataServiceContext;
        IUser user;
        while (true)
        {
          switch (num2)
          {
            case 1:
              metadata = obj.Metadata as ComponentMetadata;
              num2 = 16;
              continue;
            case 2:
              Contract.ArgumentNotNull((object) obj, (string) ComponentMetadataItemManager.p1eQFWBQp3nubCPsNAyi(-1939377524 ^ -1939353340));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 1 : 1;
              continue;
            case 3:
              nullable = metadata.ViewScriptUid;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 2 : 17;
              continue;
            case 4:
              metadata.ViewScriptUid = new Guid?(((ScriptModule) ComponentMetadataItemManager.DVvZu8BQjP53pVIoyZtR((object) obj)).Uid);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 7 : 7;
              continue;
            case 5:
              obj.CreationAuthorId = (long?) (user != null ? ComponentMetadataItemManager.AOxJvMBChdGS62gOpntK((object) user) : (object) null);
              num2 = 26;
              continue;
            case 6:
              if (ComponentMetadataItemManager.mMduoxBQLtliXUYCW7u0((object) obj) == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
                continue;
              }
              goto case 21;
            case 7:
              base.Save(obj);
              num2 = 18;
              continue;
            case 8:
              metadata.TestScriptUid = new Guid?(ComponentMetadataItemManager.uNbcViBQmqexv2WGRfgK(ComponentMetadataItemManager.mMduoxBQLtliXUYCW7u0((object) obj)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 23 : 15;
              continue;
            case 9:
              obj.ClientScriptModule.ScriptMethods = ComponentMetadataItemManager.ParseMethods((string) ComponentMetadataItemManager.fadx3GBCfXp7vAFTdGCN(ComponentMetadataItemManager.v5UAQ0BQ5OMsrpaiukp4((object) obj)), metadata.Name);
              num2 = 6;
              continue;
            case 10:
              List<DataClassMetadata> list2 = this.searchMetadataService.GetDraftDataClasses().ToList<DataClassMetadata>();
              list1 = metadata.GetMetadataToRegister().ToList<IMetadata>();
              List<IMetadata> second = list1;
              metadataServiceContext = MetadataServiceContext.Extend(((IEnumerable<IMetadata>) list2).Concat<IMetadata>((IEnumerable<IMetadata>) second).Concat<IMetadata>((IEnumerable<IMetadata>) this.searchMetadataService.GetDraftFunctions()).Concat<IMetadata>((IEnumerable<IMetadata>) this.searchMetadataService.GetDraftComponents()));
              num2 = 27;
              continue;
            case 11:
              ComponentMetadataItemManager.sZd8aVBQYegI5tqZ2924((object) obj, (object) this.CreateScriptModule(ComponentViewScriptModuleType.TypeUid, metadata, (string) ComponentMetadataItemManager.mpRFprBCQQt3kJrY4VgV(ComponentMetadataItemManager.v5UAQ0BQ5OMsrpaiukp4((object) obj))));
              num2 = 4;
              continue;
            case 12:
              goto label_15;
            case 13:
              if (!nullable.HasValue)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 21 : 3;
                continue;
              }
              goto case 20;
            case 14:
              goto label_45;
            case 15:
              if (ComponentMetadataItemManager.v5UAQ0BQ5OMsrpaiukp4((object) obj) != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 9 : 5;
                continue;
              }
              goto case 6;
            case 16:
              if (metadata != null)
              {
                if (ComponentMetadataItemManager.VtBN2rBQ4iiKJQ8RlloM((object) obj) == null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 28 : 25;
                  continue;
                }
                if (this.headerManager.ValidateName(((ComponentMetadataItemHeader) ComponentMetadataItemManager.VtBN2rBQ4iiKJQ8RlloM((object) obj)).Uid, (string) ComponentMetadataItemManager.YStk1QBQgZg6TIPsc448((object) metadata), out errorMessage))
                {
                  if (this.headerManager.ValidateDisplayName(ComponentMetadataItemManager.d8AHZHBCFPl7Eg1y1LXP(ComponentMetadataItemManager.VtBN2rBQ4iiKJQ8RlloM((object) obj)), (string) ComponentMetadataItemManager.suAVK0BQz9Xm24vYTLc7((object) metadata), out errorMessage))
                  {
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 25 : 8;
                    continue;
                  }
                  goto label_45;
                }
                else
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 12 : 7;
                  continue;
                }
              }
              else
              {
                num2 = 24;
                continue;
              }
            case 17:
              if (nullable.HasValue)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 11 : 11;
                continue;
              }
              goto case 7;
            case 18:
              goto label_38;
            case 19:
label_6:
              user = (IUser) ComponentMetadataItemManager.IS0GuvBCbsK2sFxBrWXl(ComponentMetadataItemManager.zXF2lRBCoIZyU1oFEb9w((object) this));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 5 : 3;
              continue;
            case 20:
              ComponentMetadataItemManager.euIuCxBCCWHsdCYppDDE((object) obj, (object) this.CreateScriptModule(TestScriptModuleType.TypeUid, metadata, (string) ComponentMetadataItemManager.mpRFprBCQQt3kJrY4VgV((object) obj.ClientScriptModule)));
              num2 = 8;
              continue;
            case 21:
            case 23:
              if (obj.ViewScriptModule == null)
              {
                num2 = 3;
                continue;
              }
              goto case 7;
            case 22:
              ((ScriptModule) ComponentMetadataItemManager.IbYRvaBQ0U45VEjSmBLN((object) obj)).ScriptMethods = ComponentMetadataItemManager.ParseMethods((string) ComponentMetadataItemManager.fadx3GBCfXp7vAFTdGCN(ComponentMetadataItemManager.IbYRvaBQ0U45VEjSmBLN((object) obj)), (string) ComponentMetadataItemManager.YStk1QBQgZg6TIPsc448((object) metadata));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 15 : 15;
              continue;
            case 24:
              goto label_35;
            case 25:
              if (ComponentMetadataItemManager.H3gqofBCBVWjFGYKJ5nv((object) obj.Header) == obj)
              {
                num2 = 10;
                continue;
              }
              goto case 19;
            case 26:
              goto label_10;
            case 27:
              try
              {
                // ISSUE: reference to a compiler-generated method
                this.dependencyService.FillDependencies(metadata, list1.Select<IMetadata, Guid>((Func<IMetadata, Guid>) (m => ComponentMetadataItemManager.\u003C\u003Ec.wLB0PtQhESw2OsR4YBvp((object) m))));
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
                  num3 = 0;
                switch (num3)
                {
                  default:
                    goto label_6;
                }
              }
              finally
              {
                if (metadataServiceContext != null)
                {
                  int num4 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0)
                    num4 = 1;
                  while (true)
                  {
                    switch (num4)
                    {
                      case 1:
                        ComponentMetadataItemManager.FlghJNBCWrDK8ykLCkPx((object) metadataServiceContext);
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_34;
                    }
                  }
                }
label_34:;
              }
            case 28:
              goto label_48;
            case 29:
              if (ComponentMetadataItemManager.IbYRvaBQ0U45VEjSmBLN((object) obj) != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 22 : 13;
                continue;
              }
              goto case 15;
            default:
              nullable = metadata.TestScriptUid;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 10 : 13;
              continue;
          }
        }
label_10:
        ComponentMetadataItemManager.JBIBWFBCEsDpUIT68mYb((object) obj, ComponentMetadataItemManager.nh1jBKBCGHLqUF4n7RmJ());
        num1 = 29;
      }
label_38:
      return;
label_15:
      throw new InvalidOperationException(errorMessage);
label_35:
      throw new Exception(EleWise.ELMA.SR.T((string) ComponentMetadataItemManager.p1eQFWBQp3nubCPsNAyi(1149433385 + 173655049 ^ 1323059616), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787439949)));
label_45:
      throw new InvalidOperationException(errorMessage);
label_48:
      throw new Exception(EleWise.ELMA.SR.T((string) ComponentMetadataItemManager.p1eQFWBQp3nubCPsNAyi(1505778440 - 1981636111 ^ -475918587), ComponentMetadataItemManager.suAVK0BQz9Xm24vYTLc7((object) metadata), (object) metadata.Name));
    }

    /// <inheritdoc />
    public UIMetadataPublishResult Publish(Guid headerId, string comment, bool forEmulation)
    {
      int num = 1;
      TaskAwaiter<UIMetadataPublishResult> awaiter;
      while (true)
      {
        switch (num)
        {
          case 1:
            awaiter = this.PublishAsync(headerId, comment, forEmulation).GetAwaiter();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return awaiter.GetResult();
    }

    /// <inheritdoc />
    public IEnumerable<ComponentMetadataItemWrapper> GetCandidates(Guid headerUid) => (IEnumerable<ComponentMetadataItemWrapper>) this.CreateCriteria(this.fetchOptions, this.ImplementationType).CreateAlias(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1581325282 << 3 ^ -234329694), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1819636893 << 3 ^ 1672153212), JoinType.LeftOuterJoin).Add((ICriterion) Restrictions.Eq(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-342626196 - 1290888215 ^ -1633519255), (object) headerUid)).Add((ICriterion) Restrictions.Eq(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606616504), (object) true)).Add((ICriterion) Restrictions.IsNotNull(z2jc63fLkugS1X8Q9N.tE1kD1vbB(589593376 ^ -1977315327 ^ -1459611171))).Add((ICriterion) Restrictions.IsNotNull(z2jc63fLkugS1X8Q9N.tE1kD1vbB(372753449 ^ 372715853))).SetProjection((IProjection) Projections.ProjectionList().Add((IProjection) Projections.Property(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886586701)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138904958)).Add((IProjection) Projections.Property(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1334971491)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1033719030 - 2012070891 ^ -978327911)).Add((IProjection) Projections.Property(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-342626196 - 1290888215 ^ -1633519311)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(44884861 ^ 44832281))).SetResultTransformer((IResultTransformer) new EleWise.ELMA.Runtime.NH.AliasToBeanResultTransformer(typeof (ComponentMetadataItemWrapper))).List<ComponentMetadataItemWrapper>();

    /// <inheritdoc />
    public IEnumerable<ComponentMetadataItemWrapper> GetLastPublished() => (IEnumerable<ComponentMetadataItemWrapper>) this.CreateCriteria(this.fetchOptions, this.ImplementationType, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-441065788 ^ -2092910478 ^ 1727370022)).CreateAlias(z2jc63fLkugS1X8Q9N.tE1kD1vbB(333888594 ^ 1075625116 ^ 1408939644), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740296352), JoinType.InnerJoin, (ICriterion) Restrictions.EqProperty(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-630932142 - 1120244082 ^ -1751130506), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1251470110 >> 2 ^ 312807269))).Add((ICriterion) Restrictions.Eq(z2jc63fLkugS1X8Q9N.tE1kD1vbB(333888594 ^ 1075625116 ^ 1408955802), (object) true)).Add((ICriterion) Restrictions.IsNotNull(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~541731958 ^ -541777547))).Add((ICriterion) Restrictions.IsNotNull(z2jc63fLkugS1X8Q9N.tE1kD1vbB(372753449 ^ 372715853))).SetProjection((IProjection) Projections.ProjectionList().Add((IProjection) Projections.Property(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106465672)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(712480695 ^ 712467149)).Add((IProjection) Projections.Property(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051276242 - 990076387 ^ 61192829)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487392780)).Add((IProjection) Projections.Property(z2jc63fLkugS1X8Q9N.tE1kD1vbB(901793403 ^ 901821215)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-122002947 ^ 121989990))).SetResultTransformer((IResultTransformer) new EleWise.ELMA.Runtime.NH.AliasToBeanResultTransformer(typeof (ComponentMetadataItemWrapper))).List<ComponentMetadataItemWrapper>();

    /// <summary>Распарсить все методы в коде</summary>
    /// <param name="sourceCode">Исходный код</param>
    /// <param name="metadataName">Имя метаданных</param>
    public static List<ScriptMethodDeclaration> ParseMethods(string sourceCode, string metadataName)
    {
      List<ScriptMethodDeclaration> methods = new List<ScriptMethodDeclaration>();
      if (string.IsNullOrWhiteSpace(sourceCode))
        return methods;
      SyntaxTree syntaxTree = SyntaxFactory.ParseSyntaxTree(sourceCode, (ParseOptions) null, "", Encoding.UTF8, (ImmutableDictionary<string, ReportDiagnostic>) null, new CancellationToken());
      ClassDeclarationSyntax declarationSyntax1 = syntaxTree != null ? syntaxTree.GetRoot().DescendantNodes().OfType<ClassDeclarationSyntax>().FirstOrDefault<ClassDeclarationSyntax>((Func<ClassDeclarationSyntax, bool>) (q =>
      {
        int num = 1;
        SyntaxToken syntaxToken;
        while (true)
        {
          switch (num)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              syntaxToken = ComponentMetadataItemManager.\u003C\u003Ec.r9BXkOQhfkgMx0ajW2bB((object) q);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 0 : 0;
              continue;
            default:
              goto label_3;
          }
        }
label_3:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        return ComponentMetadataItemManager.\u003C\u003Ec.pFTUdWQhCBxRMscSqrDL((object) syntaxToken.ToString(), ComponentMetadataItemManager.\u003C\u003Ec.zjMNuKQhQClj55IiiCAe(901793403 ^ 901863321));
      })) : (ClassDeclarationSyntax) null;
      if (declarationSyntax1 == null)
        return methods;
      foreach (MemberDeclarationSyntax member in declarationSyntax1.Members)
      {
        if (member is MethodDeclarationSyntax declarationSyntax2 && declarationSyntax2.Modifiers.Any(SyntaxKind.PublicKeyword))
        {
          string text1 = declarationSyntax2.Identifier.Text;
          List<string> values1 = new List<string>();
          foreach (SyntaxTrivia syntaxTrivia in declarationSyntax2.GetLeadingTrivia())
          {
            string fullString = syntaxTrivia.ToFullString();
            if (!(fullString == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2092274397 << 4 ^ 883339534)) && !string.IsNullOrWhiteSpace(fullString))
              values1.Add(fullString);
          }
          string str1 = string.Join("", (IEnumerable<string>) values1).Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1598106783 - -968262081 ^ -629825304), "");
          ScriptMethodDeclaration methodDeclaration = new ScriptMethodDeclaration()
          {
            Name = text1,
            ReturnType = declarationSyntax2.ReturnType.ToString(),
            Description = string.Join("", new string[1]
            {
              str1
            })
          };
          string str2 = string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-710283084 ^ -537863435 ^ 173614659), declarationSyntax2.ParameterList.Parameters.Select<ParameterSyntax, string>((Func<ParameterSyntax, string>) (param =>
          {
            int num = 2;
            string type;
            string text2;
            SyntaxToken syntaxToken;
            while (true)
            {
              switch (num)
              {
                case 1:
                  text2 = syntaxToken.Text;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 0;
                  continue;
                case 2:
                  // ISSUE: reference to a compiler-generated method
                  syntaxToken = ComponentMetadataItemManager.\u003C\u003Ec__DisplayClass30_0.vB4PguQhVgNsHhPWZcl0((object) param);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 1 : 1;
                  continue;
                case 3:
                  methodDeclaration.Parameters.Add(new ScriptMethodParameter(text2, type));
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 4 : 3;
                  continue;
                case 4:
                  goto label_3;
                default:
                  // ISSUE: reference to a compiler-generated method
                  type = ComponentMetadataItemManager.\u003C\u003Ec__DisplayClass30_0.qi9eJ2QhSttbLEnv3krP((object) param).ToString();
                  num = 3;
                  continue;
              }
            }
label_3:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            return (string) ComponentMetadataItemManager.\u003C\u003Ec__DisplayClass30_0.HvU22uQhiLvuQAmvRRQ3((object) type) + (string) ComponentMetadataItemManager.\u003C\u003Ec__DisplayClass30_0.wp3bEcQhRNEM57avFxGK(1917998801 >> 2 ^ 479517846) + text2;
          })));
          string nameSpace = syntaxTree.GetRoot().DescendantNodes().OfType<NamespaceDeclarationSyntax>().First<NamespaceDeclarationSyntax>().Name.ToString();
          List<string> values2 = new List<string>();
          foreach (ScriptMethodParameter parameter in methodDeclaration.Parameters)
            values2.Add(ComponentMetadataItemManager.ConvertType((object) parameter.Type, (object) nameSpace, (object) metadataName));
          methodDeclaration.Signature = text1 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(2008901894 << 3 ^ -1108650106) + string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1598106783 - -968262081 ^ -629843680), (IEnumerable<string>) values2) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398655776);
          methodDeclaration.DisplayInfo = text1 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70002501) + str2 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-542721635 ^ -542726623);
          methods.Add(methodDeclaration);
        }
      }
      return methods;
    }

    /// <summary>Добавить системный компонент</summary>
    /// <param name="item">Системный компонент</param>
    internal void AddSystemComponent(ComponentMetadataItem item)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ComponentMetadataItemManager.SystemComponents.Add(item.Uid, item);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Получить метаданные и скрипты компонентов</summary>
    /// <param name="itemUids">Идентификаторы компонентов</param>
    /// <param name="debug">Режим отображения</param>
    /// <returns>Список метаданных и скриптов</returns>
    public List<RuntimeComponentModel> LoadRuntimeMetadata(IEnumerable<Guid> itemUids, bool debug)
    {
      List<RuntimeComponentModel> runtimeComponentModelList = new List<RuntimeComponentModel>();
      Guid[] array = itemUids.ToArray<Guid>();
      if (array.Length == 0)
        return runtimeComponentModelList;
      IList<ComponentMetadataItem> collection = (IList<ComponentMetadataItem>) new List<ComponentMetadataItem>();
      List<Guid> notLoadedItemUids = new List<Guid>();
      foreach (Guid itemUid in itemUids)
        notLoadedItemUids.Add(itemUid);
      if (notLoadedItemUids.Count > 0)
      {
        IEnumerable<ComponentMetadataItem> loadedComponents = (IEnumerable<ComponentMetadataItem>) null;
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
                loadedComponents = (IEnumerable<ComponentMetadataItem>) this.CreateCriteriaForArraySearch<Guid>((IEnumerable<Guid>) notLoadedItemUids, z2jc63fLkugS1X8Q9N.tE1kD1vbB(322893104 - -1992822529 ^ -1979225181), (IEntityFilter) null, (FetchOptions) null).List<ComponentMetadataItem>();
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }));
        collection.AddRange<ComponentMetadataItem>(loadedComponents);
      }
      if (collection.Count == 0)
      {
        foreach (Guid guid in array)
        {
          Guid itemUid = guid;
          ComponentMetadataItem systemComponent = (ComponentMetadataItem) null;
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
                  systemComponent = this.LoadOrNull(itemUid);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
                  continue;
                default:
                  goto label_4;
              }
            }
label_2:
            return;
label_4:;
          }));
          if (systemComponent != null)
          {
            ScriptModule clientScriptModule = systemComponent.ClientScriptModule;
            string str = EleWise.ELMA.SR.TranslateStringResource(Encoding.UTF8.GetString(clientScriptModule.AssemblyRaw ?? Array.Empty<byte>()));
            runtimeComponentModelList.Add(new RuntimeComponentModel()
            {
              MetadataItem = systemComponent,
              Script = new ClientScriptModel()
              {
                AssemblyName = clientScriptModule.AssemblyName,
                SourceCode = str
              }
            });
          }
        }
        return runtimeComponentModelList;
      }
      foreach (ComponentMetadataItem cloneObject in (IEnumerable<ComponentMetadataItem>) collection)
      {
        ComponentMetadataItem componentMetadataItem1 = cloneObject;
        ComponentMetadata metadata = (ComponentMetadata) componentMetadataItem1.Metadata;
        long? id1 = componentMetadataItem1.Header.Published?.Id;
        long id2 = componentMetadataItem1.Id;
        if (!(id1.GetValueOrDefault() == id2 & id1.HasValue))
        {
          id1 = componentMetadataItem1.Header.Emulation?.Id;
          long id3 = componentMetadataItem1.Id;
          if (!(id1.GetValueOrDefault() == id3 & id1.HasValue))
            goto label_29;
        }
        foreach (PropertyViewItem allProperty in metadata.Content.View.GetAllProperties())
          this.FillFilterProvider(allProperty, (Type) null, (IEntity) componentMetadataItem1, (ClassMetadata) metadata.Content.Context);
label_29:
        ScriptModule clientScriptModule = cloneObject.ClientScriptModule;
        string resource = Encoding.UTF8.GetString((debug ? clientScriptModule.DebugRaw : clientScriptModule.AssemblyRaw) ?? Array.Empty<byte>());
        if (EleWise.ELMA.SR.GetCurrentCulture().Name != EleWise.ELMA.SR.KeyCultureInfo.Name)
        {
          resource = EleWise.ELMA.SR.TranslateStringResource(resource);
          componentMetadataItem1 = CloneHelperBuilder.Create<ComponentMetadataItem>(cloneObject).Restrictions((Action<RestrictionsBuilder<ComponentMetadataItem>>) (a => a.Rule().ForPropertyName((Expression<Func<ComponentMetadataItem, object>>) (componentMetadataItem => componentMetadataItem.Header)).ByRef())).Restrictions((Action<RestrictionsBuilder<ComponentMetadataItem>>) (a => a.Rule().ForPropertyName((Expression<Func<ComponentMetadataItem, object>>) (componentMetadataItem => componentMetadataItem.ScriptModule)).ByRef())).Restrictions((Action<RestrictionsBuilder<ComponentMetadataItem>>) (a => a.Rule().ForPropertyName((Expression<Func<ComponentMetadataItem, object>>) (componentMetadataItem => componentMetadataItem.ClientScriptModule)).ByRef())).Clone();
          componentMetadataItem1.Uid = cloneObject.Uid;
          ((ComponentMetadata) componentMetadataItem1.Metadata).Content.View.ApplyLocalization();
        }
        runtimeComponentModelList.Add(new RuntimeComponentModel()
        {
          MetadataItem = componentMetadataItem1,
          Script = new ClientScriptModel()
          {
            AssemblyName = clientScriptModule.AssemblyName,
            SourceCode = resource
          }
        });
      }
      return runtimeComponentModelList;
    }

    /// <summary>
    /// Получить список оберток компонентов с клиентскими скрипт модулями
    /// </summary>
    /// <returns>Список оберток компонентов с клиентскими скрипт модулями</returns>
    internal IEnumerable<ItemWithScriptModuleWrapper> GetItemsWithClientScriptModules() => (IEnumerable<ItemWithScriptModuleWrapper>) this.CreateCriteria().CreateAlias(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~289714581 ^ -289670952), z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-122002947 ^ 121975446), JoinType.LeftOuterJoin).CreateAlias(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 1418419036), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1350312861 << 3 ^ 2082346726), JoinType.LeftOuterJoin).Add((ICriterion) Restrictions.NotEqProperty(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106465846), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1304605005 ^ 1304571923))).Add((ICriterion) Restrictions.Eq(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345392146), (object) false)).Add((ICriterion) Restrictions.Eq(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099732199), (object) false)).Add((ICriterion) Restrictions.IsNotNull(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217469201))).Add((ICriterion) Restrictions.IsNotNull(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858906167))).SetProjection((IProjection) Projections.ProjectionList().Add((IProjection) Projections.Property(z2jc63fLkugS1X8Q9N.tE1kD1vbB(222162814 ^ 222134508)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1033719030 - 2012070891 ^ -978327911)).Add((IProjection) Projections.Property(z2jc63fLkugS1X8Q9N.tE1kD1vbB(333888594 ^ 1075625116 ^ 1408955672)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(95909607 + 343705423 ^ 439552166))).SetResultTransformer((IResultTransformer) new EleWise.ELMA.Runtime.NH.AliasToBeanResultTransformer(typeof (ItemWithScriptModuleWrapper))).List<ItemWithScriptModuleWrapper>();

    private ComponentMetadataItem CreateComponent(
      Guid moduleUid,
      Guid groupUid,
      string displayName)
    {
      int num = 1;
      ComponentMetadata componentMetadata;
      while (true)
      {
        switch (num)
        {
          case 1:
            componentMetadata = new ComponentMetadata(moduleUid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return (ComponentMetadataItem) ComponentMetadataItemManager.aGRif2BCv8j9Fr4innI3((object) this, (object) componentMetadata, groupUid, (object) displayName);
    }

    private ComponentMetadataItem CreatePage(Guid moduleUid, Guid groupUid, string displayName)
    {
      int num = 1;
      PageComponentMetadata componentMetadata;
      while (true)
      {
        switch (num)
        {
          case 1:
            componentMetadata = new PageComponentMetadata(moduleUid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return (ComponentMetadataItem) ComponentMetadataItemManager.aGRif2BCv8j9Fr4innI3((object) this, (object) componentMetadata, groupUid, (object) displayName);
    }

    private ComponentMetadataItem CreatePortlet(Guid moduleUid, Guid groupUid, string displayName)
    {
      int num = 1;
      PortletComponentMetadata metadata;
      while (true)
      {
        switch (num)
        {
          case 1:
            metadata = new PortletComponentMetadata(moduleUid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return this.Create((ComponentMetadata) metadata, groupUid, displayName);
    }

    private ComponentMetadataItem CreateItem(ComponentMetadata metadata)
    {
      int num1 = 4;
      ComponentMetadataItem componentMetadataItem;
      while (true)
      {
        int num2 = num1;
        ComponentMetadataItemHeader metadataItemHeader;
        IUser user;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_15;
            case 2:
              goto label_18;
            case 3:
              ComponentMetadataItemManager.APhxmnBC80ordJpdwHCl((object) componentMetadataItem, (object) metadata);
              num2 = 16;
              continue;
            case 4:
              componentMetadataItem = this.Create();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 3 : 0;
              continue;
            case 5:
              ComponentMetadataItemManager.Hk3Pb7BCVAV3STNYVfFv((object) metadataItemHeader, ComponentMetadataItemManager.suAVK0BQz9Xm24vYTLc7((object) metadata));
              num2 = 9;
              continue;
            case 6:
              metadataItemHeader.CreationDate = ComponentMetadataItemManager.op8kR1BCRdbI28SB8IvU((object) componentMetadataItem);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 13 : 1;
              continue;
            case 7:
              goto label_5;
            case 8:
              goto label_7;
            case 9:
              metadataItemHeader.Description = (string) ComponentMetadataItemManager.VLQMBOBCSy2I0wga3ICU((object) metadata);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 5 : 15;
              continue;
            case 10:
              metadataItemHeader = this.headerManager.Create();
              num2 = 11;
              continue;
            case 11:
              ComponentMetadataItemManager.GURoKoBCuk6wyY4cGjlf((object) metadataItemHeader, ComponentMetadataItemManager.Qta7asBCZCEDJSBxonwD((object) metadata));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 1 : 1;
              continue;
            case 12:
              ComponentMetadataItemManager.TgS3knBCXFR94Ook0xAS((object) metadataItemHeader, ComponentMetadataItemManager.NkR9WMBCKNMZktyO5WWf((object) metadata));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 14 : 3;
              continue;
            case 13:
              ComponentMetadataItemManager.Kvi5xgBCqofeORBuXPAY((object) metadataItemHeader, (object) componentMetadataItem);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 3 : 12;
              continue;
            case 14:
              ComponentMetadataItemManager.o2eSCZBCTDXHE60HueUc((object) componentMetadataItem, (object) metadataItemHeader);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 7 : 6;
              continue;
            case 15:
              ComponentMetadataItemManager.raEnifBCib5sjoK3bsmb((object) metadataItemHeader, metadata.ModuleUid);
              num2 = 2;
              continue;
            case 16:
              user = (IUser) ComponentMetadataItemManager.IS0GuvBCbsK2sFxBrWXl(ComponentMetadataItemManager.zXF2lRBCoIZyU1oFEb9w((object) this));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
              continue;
            default:
              goto label_19;
          }
        }
label_7:
        componentMetadataItem.CreationDate = ComponentMetadataItemManager.nh1jBKBCGHLqUF4n7RmJ();
        num1 = 10;
        continue;
label_15:
        ComponentMetadataItemManager.jbsx2QBCIiDUSYeDyL5v((object) metadataItemHeader, ComponentMetadataItemManager.YStk1QBQgZg6TIPsc448((object) metadata));
        num1 = 5;
        continue;
label_18:
        metadataItemHeader.CreationAuthorId = componentMetadataItem.CreationAuthorId;
        num1 = 6;
        continue;
label_19:
        componentMetadataItem.CreationAuthorId = (long?) user?.GetId();
        num1 = 8;
      }
label_5:
      return componentMetadataItem;
    }

    private ScriptModule CreateScriptModule(
      Guid moduleTypeUid,
      ComponentMetadata metadata,
      string assemblyName)
    {
      int num = 3;
      string sourceCode;
      while (true)
      {
        string str1;
        string str2;
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            str2 = (string) null;
            break;
          case 3:
            IScriptModuleType scriptModuleType = this.scriptModuleManager.GetScriptModuleType(moduleTypeUid);
            if (scriptModuleType == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 2 : 1;
              continue;
            }
            str2 = scriptModuleType.GenerateSourceCode((object) metadata);
            break;
          default:
            str1 = string.Empty;
            goto label_10;
        }
        if (str2 == null)
        {
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
          continue;
        }
        str1 = str2;
label_10:
        sourceCode = str1;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 1;
      }
label_2:
      return this.CreateScriptModule(moduleTypeUid, (string) ComponentMetadataItemManager.YStk1QBQgZg6TIPsc448((object) metadata), assemblyName, sourceCode);
    }

    private ScriptModule CreateScriptModule(
      Guid moduleTypeUid,
      string name,
      string assemblyName,
      ScriptModule oldScriptModule)
    {
      int num1 = 2;
      ScriptModule scriptModule;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_4;
            case 2:
              if (oldScriptModule != null)
              {
                scriptModule = this.CreateScriptModule(moduleTypeUid, name, assemblyName, (string) ComponentMetadataItemManager.fadx3GBCfXp7vAFTdGCN((object) oldScriptModule));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 2 : 3;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 1 : 1;
              continue;
            case 3:
              goto label_7;
            case 4:
              scriptModule.ScriptMethods.AddRange((IEnumerable<ScriptMethodDeclaration>) oldScriptModule.ScriptMethods);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
              continue;
            default:
              goto label_6;
          }
        }
label_7:
        if (oldScriptModule.ScriptMethods.Count > 0)
          num1 = 4;
        else
          goto label_6;
      }
label_4:
      return (ScriptModule) null;
label_6:
      return scriptModule;
    }

    private ScriptModule CreateScriptModule(
      Guid moduleTypeUid,
      string name,
      string assemblyName,
      string sourceCode)
    {
      ScriptModule scriptModule = this.scriptModuleManager.Create();
      ComponentMetadataItemManager.e24Pk9BCk4TJKOgGUhet((object) scriptModule, (object) name);
      ComponentMetadataItemManager.YxGhC9BCnWpcpgM2T0b3((object) scriptModule, (object) name);
      ComponentMetadataItemManager.znONuNBCO7isWkYOKQAb((object) scriptModule, (object) assemblyName);
      ComponentMetadataItemManager.wrZcTkBC2SlMpCkukmhi((object) scriptModule, moduleTypeUid);
      ComponentMetadataItemManager.GMoFx4BCeD0GDyCEtvMh((object) scriptModule, (object) sourceCode);
      ComponentMetadataItemManager.TnKhA0BCPLxjGtCXqrVE((object) scriptModule, (object) string.Empty);
      ComponentMetadataItemManager.QNIMFGBC1K0Tp3sMNInH((object) scriptModule, moduleTypeUid == ComponentScriptModuleType.TypeUid ? ComponentMetadataItemManager.p1eQFWBQp3nubCPsNAyi(~541731958 ^ -541769833) : (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-542721635 ^ -542748879));
      return scriptModule;
    }

    private static string ConvertParameter(object paramType)
    {
      int num = 8;
      string str1;
      string str2;
      string str3;
      List<string> list;
      while (true)
      {
        switch (num)
        {
          case 1:
            str1 = ((IEnumerable<string>) str1.Split('.')).Last<string>();
            num = 2;
            continue;
          case 2:
            object source1 = ComponentMetadataItemManager.ksD7jWBCp8r5fuBqNysR(ComponentMetadataItemManager.CcMvRcBC3KHcOHF26eN9((object) str2, ComponentMetadataItemManager.p1eQFWBQp3nubCPsNAyi(-1872275253 >> 6 ^ -29240669), (object) ""), (object) new string[1]
            {
              (string) ComponentMetadataItemManager.p1eQFWBQp3nubCPsNAyi(1470998129 - 231418599 ^ 1239578504)
            }, StringSplitOptions.None);
            // ISSUE: reference to a compiler-generated field
            Func<string, string> func = ComponentMetadataItemManager.\u003C\u003Ec.\u003C\u003E9__41_0;
            Func<string, string> selector;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              ComponentMetadataItemManager.\u003C\u003Ec.\u003C\u003E9__41_0 = selector = (Func<string, string>) (param => ((IEnumerable<string>) ComponentMetadataItemManager.\u003C\u003Ec.vR2FjjQhvekrdAOTflq5((object) param, (object) new char[1]
              {
                '.'
              })).Last<string>());
            }
            else
              goto label_13;
label_12:
            list = ((IEnumerable<string>) source1).Select<string, string>(selector).ToList<string>();
            num = 9;
            continue;
label_13:
            selector = func;
            goto label_12;
          case 3:
          case 4:
            goto label_4;
          case 6:
            str3 = (string) ComponentMetadataItemManager.ASlj9iBCa2nLDsN2pdoN((object) str1, ComponentMetadataItemManager.p1eQFWBQp3nubCPsNAyi(~210725948 ^ -210707451), (object) str2, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-542721635 ^ -542706083));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 1 : 4;
            continue;
          case 7:
            if (!(str1 != str2))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
              continue;
            }
            goto case 1;
          case 8:
            object source2 = ComponentMetadataItemManager.T889fsBCNqPXytji7JU3(paramType, (object) new char[1]
            {
              '<'
            });
            str1 = ((IEnumerable<string>) source2).First<string>();
            str2 = ((IEnumerable<string>) source2).Last<string>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 7 : 6;
            continue;
          case 9:
            str2 = string.Join((string) ComponentMetadataItemManager.p1eQFWBQp3nubCPsNAyi(-1939377524 ^ -1939374450), (IEnumerable<string>) list);
            num = 6;
            continue;
          default:
            str3 = ((IEnumerable<string>) str1.Split('.')).Last<string>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 3 : 3;
            continue;
        }
      }
label_4:
      return str3;
    }

    private static string ConvertType(object type, object nameSpace, object metadataName)
    {
      int num1 = 6;
      string str1;
      while (true)
      {
        int num2 = num1;
        List<string> list;
        List<string>.Enumerator enumerator;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (ComponentMetadataItemManager.A4481xBCDXthGmCfuxLd(nameSpace, ComponentMetadataItemManager.p1eQFWBQp3nubCPsNAyi(-342626196 - 1290888215 ^ -1633518935)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
                continue;
              }
              goto case 4;
            case 2:
              try
              {
label_16:
                if (enumerator.MoveNext())
                  goto label_19;
                else
                  goto label_17;
label_11:
                string current;
                int num3;
                while (true)
                {
                  string str2;
                  switch (num3)
                  {
                    case 1:
                      goto label_19;
                    case 2:
                    case 3:
                      str1 = (string) ComponentMetadataItemManager.CcMvRcBC3KHcOHF26eN9((object) str1, (object) current, ComponentMetadataItemManager.Wiw0o3BCHR7kbspqWTJa((object) new string[5]
                      {
                        (string) ComponentMetadataItemManager.p1eQFWBQp3nubCPsNAyi(-1204263869 ^ -1341583247 ^ 137462480),
                        (string) nameSpace,
                        z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921196793),
                        str2,
                        (string) ComponentMetadataItemManager.p1eQFWBQp3nubCPsNAyi(-2138160520 ^ -2138131312)
                      }));
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 7 : 7;
                      continue;
                    case 4:
                      goto label_25;
                    case 5:
                      if (!ComponentMetadataItemManager.EFxr7MBC4er12ltS5Z8R((object) current, ComponentMetadataItemManager.p1eQFWBQp3nubCPsNAyi(-488881205 ^ -488896561)))
                      {
                        num3 = 3;
                        continue;
                      }
                      break;
                    case 6:
                      str2 = current;
                      num3 = 5;
                      continue;
                    case 7:
                      goto label_16;
                  }
                  str2 = (string) ComponentMetadataItemManager.dYAHpyBC6FYecChjI66W(metadataName, ComponentMetadataItemManager.p1eQFWBQp3nubCPsNAyi(1242972401 >> 4 ^ 77671377), (object) current);
                  num3 = 2;
                }
label_17:
                num3 = 4;
                goto label_11;
label_19:
                current = enumerator.Current;
                num3 = 6;
                goto label_11;
              }
              finally
              {
                enumerator.Dispose();
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                }
              }
            case 3:
            case 11:
              goto label_6;
            case 4:
              if (!str1.Contains((string) ComponentMetadataItemManager.p1eQFWBQp3nubCPsNAyi(-342626196 - 1290888215 ^ -1633500269)))
              {
                num2 = 11;
                continue;
              }
              goto case 8;
            case 5:
              if (ComponentMetadataItemManager.A4481xBCDXthGmCfuxLd((object) str1, ComponentMetadataItemManager.p1eQFWBQp3nubCPsNAyi(1819636893 << 3 ^ 1672211246)))
              {
                num2 = 9;
                continue;
              }
              goto label_6;
            case 6:
              goto label_29;
            case 7:
              goto label_9;
            case 8:
              str1 = (string) ComponentMetadataItemManager.CcMvRcBC3KHcOHF26eN9(ComponentMetadataItemManager.CcMvRcBC3KHcOHF26eN9((object) str1, ComponentMetadataItemManager.p1eQFWBQp3nubCPsNAyi(-1120607109 - 305487170 ^ -1426077441), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-306453669 ^ 306506740)), ComponentMetadataItemManager.p1eQFWBQp3nubCPsNAyi(1514961705 ^ 1514943721), ComponentMetadataItemManager.p1eQFWBQp3nubCPsNAyi(572119659 - -337058038 ^ 909116477));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 3 : 3;
              continue;
            case 9:
              list = ((IEnumerable<string>) ComponentMetadataItemManager.ksD7jWBCp8r5fuBqNysR(ComponentMetadataItemManager.CcMvRcBC3KHcOHF26eN9(ComponentMetadataItemManager.Fu9mkQBCww0hm02gkFqu((object) str1, ComponentMetadataItemManager.GX6YqvBCtnEGuR8h0GtD((object) str1, '<') + 1), ComponentMetadataItemManager.p1eQFWBQp3nubCPsNAyi(-105199646 ^ -105215966), (object) ""), (object) new string[1]
              {
                (string) ComponentMetadataItemManager.p1eQFWBQp3nubCPsNAyi(1021410165 ^ 1021409143)
              }, StringSplitOptions.None)).ToList<string>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 7 : 1;
              continue;
            case 10:
label_25:
              str1 = (string) ComponentMetadataItemManager.CcMvRcBC3KHcOHF26eN9(ComponentMetadataItemManager.CcMvRcBC3KHcOHF26eN9((object) str1, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(323422137 << 2 ^ 1293701410), ComponentMetadataItemManager.QcvD7KBC74OTqSu61cGl(ComponentMetadataItemManager.p1eQFWBQp3nubCPsNAyi(654297945 ^ 654261687), (object) ComponentMetadataItemManager.c6DObPBCAuWF9rQH0YXh((object) list))), ComponentMetadataItemManager.p1eQFWBQp3nubCPsNAyi(1470440286 ^ 1470459038), ComponentMetadataItemManager.p1eQFWBQp3nubCPsNAyi(1012087039 ^ 1012125207));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 1 : 1;
              continue;
            default:
              str1 = (string) ComponentMetadataItemManager.ncKfqQBCx2WMM7NcAgBh(ComponentMetadataItemManager.p1eQFWBQp3nubCPsNAyi(-345420348 ^ -345392422), (object) str1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 4 : 4;
              continue;
          }
        }
label_9:
        enumerator = list.GetEnumerator();
        num1 = 2;
        continue;
label_29:
        str1 = (string) type;
        num1 = 5;
      }
label_6:
      return str1;
    }

    private void UpdateScriptModule(
      ScriptModule scriptModule,
      string oldName,
      string newName,
      string assemblyName)
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
              if (scriptModule != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            case 2:
              ComponentMetadataItemManager.znONuNBCO7isWkYOKQAb((object) scriptModule, (object) assemblyName);
              num2 = 3;
              continue;
            case 3:
              goto label_5;
            case 4:
              goto label_4;
            case 5:
              ComponentMetadataItemManager.YxGhC9BCnWpcpgM2T0b3((object) scriptModule, (object) newName);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 2;
              continue;
            case 6:
              ComponentMetadataItemManager.e24Pk9BCk4TJKOgGUhet((object) scriptModule, (object) newName);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 5;
              continue;
            default:
              goto label_6;
          }
        }
label_6:
        ComponentMetadataItemManager.GMoFx4BCeD0GDyCEtvMh((object) scriptModule, ComponentMetadataItemManager.KIQXKOBC0AhPW0H3UL8C((object) this.scriptService, ComponentMetadataItemManager.fadx3GBCfXp7vAFTdGCN((object) scriptModule), (object) oldName, (object) newName));
        num1 = 6;
      }
label_5:
      return;
label_4:
      return;
label_3:;
    }

    /// <summary>Публиковать компонент</summary>
    /// <param name="headerId">Идентификатор заголовка компонента</param>
    /// <param name="comment">Комментарий</param>
    /// <param name="forEmulation"><c>true</c> если публикация происходит для эмуляции</param>
    /// <returns>Результат публикации</returns>
    private async Task<UIMetadataPublishResult> PublishAsync(
      Guid headerId,
      string comment,
      bool forEmulation)
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        int num3;
        UIMetadataPublishResult result;
        while (true)
        {
          switch (num2)
          {
            case 1:
              // ISSUE: explicit reference operation
              // ISSUE: reference to a compiler-generated field
              num3 = (^this).\u003C\u003E1__state;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_71;
            case 3:
              goto label_3;
            case 4:
              goto label_6;
            case 5:
              // ISSUE: explicit reference operation
              // ISSUE: reference to a compiler-generated field
              (^this).\u003C\u003Et__builder.SetResult(result);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 2 : 1;
              continue;
            default:
              num2 = 4;
              continue;
          }
        }
label_3:
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        (^this).\u003C\u003E1__state = -2;
        num1 = 5;
        continue;
label_6:
        try
        {
          IComponentMetadataPublishingActor actor;
          int num4;
          switch (num3)
          {
            case 0:
            case 1:
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
              break;
            default:
label_9:
              actor = this.actorModelRuntime.GetActor<IComponentMetadataPublishingActor>(headerId);
              num4 = 4;
              break;
          }
          ComponentMetadataItemManager.ComponentMetadataPublishingEventHandler handler;
          IDisposable disposable;
          while (true)
          {
            switch (num4)
            {
              case 1:
                disposable = this.eventHandlerSubscribeService.Subscribe((IEventHandler) handler);
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 2 : 1;
                continue;
              case 3:
                goto label_9;
              case 4:
                handler = new ComponentMetadataItemManager.ComponentMetadataPublishingEventHandler(actor, headerId);
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 1;
                continue;
              case 5:
                goto label_13;
              default:
                num4 = 5;
                continue;
            }
          }
label_13:
          try
          {
            int num5 = 1;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
              num5 = 0;
            while (true)
            {
              switch (num5)
              {
                case 1:
                  num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 0 : 0;
                  continue;
                default:
                  goto label_17;
              }
            }
label_17:
            try
            {
              int num6;
              if (num3 == 0)
                num6 = 7;
              else
                goto label_36;
label_20:
              TaskAwaiter taskAwaiter1;
              TaskAwaiter<UIMetadataPublishResult> taskAwaiter2;
              TaskAwaiter<UIMetadataPublishResult> awaiter1;
              TaskAwaiter awaiter2;
              while (true)
              {
                switch (num6)
                {
                  case 0:
                    goto label_68;
                  case 1:
                  case 20:
                    result = awaiter1.GetResult();
                    num6 = 15;
                    continue;
                  case 2:
                  case 22:
                    awaiter2.GetResult();
                    num6 = 10;
                    continue;
                  case 3:
                    goto label_27;
                  case 4:
                    taskAwaiter1 = new TaskAwaiter();
                    num6 = 12;
                    continue;
                  case 5:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num3 = 0;
                    num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 5 : 11;
                    continue;
                  case 6:
                    taskAwaiter2 = awaiter1;
                    num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 18 : 19;
                    continue;
                  case 7:
                  case 18:
                    awaiter2 = taskAwaiter1;
                    num6 = 4;
                    continue;
                  case 8:
                    if (awaiter1.IsCompleted)
                    {
                      num6 = 20;
                      continue;
                    }
                    goto case 17;
                  case 9:
                    if (awaiter2.IsCompleted)
                    {
                      num6 = 22;
                      continue;
                    }
                    goto case 5;
                  case 10:
                    awaiter1 = handler.Wait.GetAwaiter();
                    num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 6 : 8;
                    continue;
                  case 11:
                    taskAwaiter1 = awaiter2;
                    num6 = 23;
                    continue;
                  case 12:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num3 = -1;
                    num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 2 : 1;
                    continue;
                  case 13:
                    taskAwaiter2 = new TaskAwaiter<UIMetadataPublishResult>();
                    num6 = 24;
                    continue;
                  case 14:
                    goto label_36;
                  case 15:
                    goto label_3;
                  case 16:
                    // ISSUE: reference to a compiler-generated method
                    awaiter2 = ((Task) ComponentMetadataItemManager.\u003CPublishAsync\u003Ed__44.rwp9qBQhwHYtAe1YyTpA((object) actor, (object) comment, forEmulation)).GetAwaiter();
                    num6 = 9;
                    continue;
                  case 17:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num3 = 1;
                    num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 6 : 2;
                    continue;
                  case 19:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<UIMetadataPublishResult>, ComponentMetadataItemManager.\u003CPublishAsync\u003Ed__44>(ref awaiter1, this);
                    num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 0;
                    continue;
                  case 21:
                    goto label_63;
                  case 23:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, ComponentMetadataItemManager.\u003CPublishAsync\u003Ed__44>(ref awaiter2, this);
                    num6 = 21;
                    continue;
                  case 24:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num3 = -1;
                    num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 1;
                    continue;
                  default:
                    goto label_59;
                }
              }
label_68:
              return;
label_63:
              return;
label_59:
              return;
label_27:
              awaiter1 = taskAwaiter2;
              num6 = 13;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
              {
                num6 = 9;
                goto label_20;
              }
              else
                goto label_20;
label_36:
              if (num3 != 1)
              {
                num6 = 16;
                goto label_20;
              }
              else
                goto label_27;
            }
            catch (NoServerCompatibleWithActorException ex)
            {
              int num7 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
                num7 = 0;
              switch (num7)
              {
                default:
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  throw new NoServerCompatibleWithActorException((string) ComponentMetadataItemManager.\u003CPublishAsync\u003Ed__44.VpBi0LQh6VXW5o6jN1gl(ComponentMetadataItemManager.\u003CPublishAsync\u003Ed__44.a9KQ3ZQh4Iw8X85kiJk4(236071375 ^ 236406219)), (Exception) ex);
              }
            }
            finally
            {
              int num8;
              if (num3 >= 0)
                num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 2 : 0;
              else
                goto label_51;
label_50:
              switch (num8)
              {
                case 1:
                case 2:
              }
label_51:
              this.componentCache.Clear();
              num8 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
              {
                num8 = 1;
                goto label_50;
              }
              else
                goto label_50;
            }
          }
          finally
          {
            if (num3 < 0)
            {
              int num9 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0)
                num9 = 0;
              while (true)
              {
                switch (num9)
                {
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    ComponentMetadataItemManager.\u003CPublishAsync\u003Ed__44.lBKHEYQhHX3UNsvkTJGx((object) disposable);
                    num9 = 3;
                    continue;
                  case 2:
                  case 3:
                    goto label_64;
                  default:
                    if (disposable == null)
                    {
                      num9 = 2;
                      continue;
                    }
                    goto case 1;
                }
              }
            }
label_64:;
          }
        }
        catch (Exception ex)
        {
          int num10 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
            num10 = 0;
          while (true)
          {
            switch (num10)
            {
              case 1:
                // ISSUE: explicit reference operation
                // ISSUE: reference to a compiler-generated field
                (^this).\u003C\u003Et__builder.SetException(ex);
                num10 = 2;
                continue;
              case 2:
                goto label_53;
              default:
                // ISSUE: explicit reference operation
                // ISSUE: reference to a compiler-generated field
                (^this).\u003C\u003E1__state = -2;
                num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 1;
                continue;
            }
          }
label_53:
          return;
        }
      }
label_71:;
    }

    private void FillFilterProvider(
      PropertyViewItem propertyViewItem,
      Type containerType,
      IEntity entity,
      ClassMetadata contextMetadata)
    {
      int num1 = 4;
      IEnumerator<PropertyViewItem> enumerator1;
      while (true)
      {
        int num2 = num1;
        IEnumerator<IEntityFilterProvider> enumerator2;
        Type entityType;
        PropertyMetadata propertyMetadata;
        ViewAttributes viewAttributes;
        while (true)
        {
          switch (num2)
          {
            case 1:
label_44:
              enumerator1 = propertyViewItem.Items.OfType<PropertyViewItem>().GetEnumerator();
              num2 = 7;
              continue;
            case 2:
              if (ComponentMetadataItemManager.LkSZQtBCyq3H7sE9g6R9(entityType, (Type) null))
              {
                num2 = 8;
                continue;
              }
              goto case 1;
            case 3:
              if (propertyMetadata != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 2 : 1;
                continue;
              }
              goto case 1;
            case 4:
              goto label_25;
            case 5:
              goto label_41;
            case 6:
              enumerator2 = this.entityFilterProviders.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
              continue;
            case 7:
              goto label_29;
            case 8:
              viewAttributes = (ViewAttributes) ComponentMetadataItemManager.DbW3sgBCMqWLYotJtJKl((object) propertyViewItem);
              num2 = 6;
              continue;
            default:
              try
              {
label_7:
                if (ComponentMetadataItemManager.cNGsrMBCgu2jSn3TeFOm((object) enumerator2))
                  goto label_6;
                else
                  goto label_8;
label_5:
                IEntityFilterProvider current;
                int num3;
                while (true)
                {
                  string str;
                  object obj;
                  switch (num3)
                  {
                    case 1:
                    case 5:
                      goto label_44;
                    case 2:
                      obj = ComponentMetadataItemManager.jL2fH6BCJpxfwYNMgcOl((object) current, entityType, (object) propertyMetadata, (object) viewAttributes);
                      break;
                    case 3:
                      if (str != null)
                      {
                        num3 = 7;
                        continue;
                      }
                      goto label_7;
                    case 4:
                      ComponentMetadataItemManager.C3O8HTBCrnnamx5JcMGO((object) viewAttributes, (object) str);
                      num3 = 5;
                      continue;
                    case 6:
                      if (!(current is IEntityInstanceFilterProvider instanceFilterProvider))
                      {
                        num3 = 2;
                        continue;
                      }
                      obj = ComponentMetadataItemManager.nvZPlcBC9QZwYN5Taakx((object) instanceFilterProvider, (object) entity, entityType, (object) propertyMetadata, (object) viewAttributes);
                      break;
                    case 7:
                      ComponentMetadataItemManager.GkOCpuBCl0TiZdHsTt5N((object) viewAttributes, ComponentMetadataItemManager.f04e0yBCdY41miBwZbhO((object) current));
                      num3 = 4;
                      continue;
                    case 8:
                      goto label_6;
                    default:
                      goto label_7;
                  }
                  str = (string) obj;
                  num3 = 3;
                }
label_6:
                current = enumerator2.Current;
                num3 = 6;
                goto label_5;
label_8:
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 1;
                goto label_5;
              }
              finally
              {
                int num4;
                if (enumerator2 == null)
                  num4 = 2;
                else
                  goto label_21;
label_20:
                switch (num4)
                {
                  case 1:
                  case 2:
                }
label_21:
                ComponentMetadataItemManager.FlghJNBCWrDK8ykLCkPx((object) enumerator2);
                num4 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
                {
                  num4 = 0;
                  goto label_20;
                }
                else
                  goto label_20;
              }
          }
        }
label_25:
        (propertyMetadata, entityType) = this.FindProperty(containerType, contextMetadata, ComponentMetadataItemManager.h5HobCBCm0JMY1TD3hgo((object) propertyViewItem), (IEnumerable<Guid>) propertyViewItem.PropertyParents);
        num1 = 3;
      }
label_41:
      return;
label_29:
      try
      {
label_31:
        if (ComponentMetadataItemManager.cNGsrMBCgu2jSn3TeFOm((object) enumerator1))
          goto label_33;
        else
          goto label_32;
label_30:
        PropertyViewItem current;
        int num5;
        while (true)
        {
          switch (num5)
          {
            case 1:
              goto label_36;
            case 2:
              this.FillFilterProvider(current, containerType, entity, contextMetadata);
              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 0 : 0;
              continue;
            case 3:
              goto label_33;
            default:
              goto label_31;
          }
        }
label_36:
        return;
label_32:
        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 1 : 0;
        goto label_30;
label_33:
        current = enumerator1.Current;
        num5 = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0)
        {
          num5 = 2;
          goto label_30;
        }
        else
          goto label_30;
      }
      finally
      {
        if (enumerator1 != null)
        {
          int num6 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
            num6 = 0;
          while (true)
          {
            switch (num6)
            {
              case 1:
                goto label_43;
              default:
                ComponentMetadataItemManager.FlghJNBCWrDK8ykLCkPx((object) enumerator1);
                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 1;
                continue;
            }
          }
        }
label_43:;
      }
    }

    private (PropertyMetadata, Type) FindProperty(
      Type containerType,
      ClassMetadata entityMetadata,
      Guid propertyUid,
      IEnumerable<Guid> propertyParents)
    {
      // ISSUE: reference to a compiler-generated method
      PropertyMetadata propertyMetadata = entityMetadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => ComponentMetadataItemManager.\u003C\u003Ec__DisplayClass46_0.TbaYc3QhmKWE9YJxx5GW((object) p) == propertyUid));
      return propertyMetadata != null ? (propertyMetadata, containerType) : ((PropertyMetadata) null, (Type) null);
    }

    static ComponentMetadataItemManager()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            ComponentMetadataItemManager.RZpyeGBQ3SIGWyTcgeQj();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            ComponentMetadataItemManager.SystemComponents = new Dictionary<Guid, ComponentMetadataItem>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static void RZpyeGBQ3SIGWyTcgeQj() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object p1eQFWBQp3nubCPsNAyi(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool XtrT19BQ1UR5NusDuwjZ() => ComponentMetadataItemManager.bVmjL4BQP30Gi5fmJCL2 == null;

    internal static ComponentMetadataItemManager Tse3mABQN7o6BcwiMqea() => ComponentMetadataItemManager.bVmjL4BQP30Gi5fmJCL2;

    internal static bool Eqx94eBQapfobBrKCMjv([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static void IOJhWpBQDOSIS5lUTHSU([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static void wnrpEfBQtTn6tQKYAxjO([In] object obj0) => ((AbstractMetadata) obj0).InitNew();

    internal static void g5BEDNBQwvBastcmvaDk([In] object obj0, [In] object obj1) => ((NamedMetadata) obj0).DisplayName = (string) obj1;

    internal static object VtBN2rBQ4iiKJQ8RlloM([In] object obj0) => (object) ((ComponentMetadataItem) obj0).Header;

    internal static object IMgWBgBQ6pRFeS1jNYRd() => (object) MetadataItemGroupUIManager.Instance;

    internal static void XvnshbBQHTG3BKhkjfyw([In] object obj0, [In] object obj1) => ((ComponentMetadataItemHeader) obj0).Group = (MetadataItemGroupUI) obj1;

    internal static object M0pBpEBQAGHcjWUoQWGj([In] object obj0) => (object) ComponentMetadataHelper.ServerAssemblyName((ComponentMetadata) obj0);

    internal static void kItsR1BQ7o9fkG1ifvJT([In] object obj0, [In] object obj1) => ((ComponentMetadataItem) obj0).ScriptModule = (ScriptModule) obj1;

    internal static void pBMHXqBQxm85fXuC1Jfc([In] object obj0, [In] object obj1) => ((ComponentMetadataItem) obj0).ClientScriptModule = (ScriptModule) obj1;

    internal static object IbYRvaBQ0U45VEjSmBLN([In] object obj0) => (object) ((ComponentMetadataItem) obj0).ScriptModule;

    internal static Guid uNbcViBQmqexv2WGRfgK([In] object obj0) => ((ScriptModule) obj0).Uid;

    internal static object XMuSrwBQy5wfVHbOLc7y([In] object obj0) => ((ComponentMetadataItem) obj0).Metadata;

    internal static void TvOIPWBQMX8pBNuR23RS([In] object obj0) => ((ComponentMetadata) obj0).GenerateNewUids();

    internal static object fFbiVjBQJnd1tBnhXuHX([In] object obj0) => (object) ((ComponentMetadata) obj0).Namespace;

    internal static void WwqFsyBQ9QQJtuov6jos([In] object obj0, [In] object obj1) => ((ComponentMetadata) obj0).Namespace = (string) obj1;

    internal static void J1UK0ABQdJust4Z7Vecy([In] object obj0, [In] object obj1) => ((NamedMetadata) obj0).Name = (string) obj1;

    internal static object lKmpFJBQlV1EHesxGkNV([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static object iDnnkuBQrEFk0lyx9loB([In] object obj0) => (object) ((ComponentMetadataItemHeader) obj0).Group;

    internal static object YStk1QBQgZg6TIPsc448([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object v5UAQ0BQ5OMsrpaiukp4([In] object obj0) => (object) ((ComponentMetadataItem) obj0).ClientScriptModule;

    internal static object DVvZu8BQjP53pVIoyZtR([In] object obj0) => (object) ((ComponentMetadataItem) obj0).ViewScriptModule;

    internal static void sZd8aVBQYegI5tqZ2924([In] object obj0, [In] object obj1) => ((ComponentMetadataItem) obj0).ViewScriptModule = (ScriptModule) obj1;

    internal static object mMduoxBQLtliXUYCW7u0([In] object obj0) => (object) ((ComponentMetadataItem) obj0).TestScriptModule;

    internal static object r2oKIBBQUNcalQ6uItoW([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static ActionCheckResult yM4EiBBQskcALLCMg2l1([In] object obj0) => ActionCheckResult.False((string) obj0);

    internal static ActionCheckResult APUdbwBQcnKvr2ekVmtV() => ActionCheckResult.True;

    internal static object suAVK0BQz9Xm24vYTLc7([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;

    internal static Guid d8AHZHBCFPl7Eg1y1LXP([In] object obj0) => ((ComponentMetadataItemHeader) obj0).Uid;

    internal static object H3gqofBCBVWjFGYKJ5nv([In] object obj0) => (object) ((ComponentMetadataItemHeader) obj0).Draft;

    internal static void FlghJNBCWrDK8ykLCkPx([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object zXF2lRBCoIZyU1oFEb9w([In] object obj0) => (object) ((EntityManager<ComponentMetadataItem, long>) obj0).AuthenticationService;

    internal static object IS0GuvBCbsK2sFxBrWXl([In] object obj0) => (object) ((IAuthenticationService) obj0).GetCurrentUser();

    internal static object AOxJvMBChdGS62gOpntK([In] object obj0) => ((IIdentified) obj0).GetId();

    internal static DateTime nh1jBKBCGHLqUF4n7RmJ() => DateTime.Now;

    internal static void JBIBWFBCEsDpUIT68mYb([In] object obj0, DateTime value) => ((ComponentMetadataItem) obj0).CreationDate = value;

    internal static object fadx3GBCfXp7vAFTdGCN([In] object obj0) => (object) ((ScriptModule) obj0).SourceCode;

    internal static object mpRFprBCQQt3kJrY4VgV([In] object obj0) => (object) ((ScriptModule) obj0).AssemblyName;

    internal static void euIuCxBCCWHsdCYppDDE([In] object obj0, [In] object obj1) => ((ComponentMetadataItem) obj0).TestScriptModule = (ScriptModule) obj1;

    internal static object aGRif2BCv8j9Fr4innI3(
      [In] object obj0,
      [In] object obj1,
      Guid groupUid,
      [In] object obj3)
    {
      return (object) ((ComponentMetadataItemManager) obj0).Create((ComponentMetadata) obj1, groupUid, (string) obj3);
    }

    internal static void APhxmnBC80ordJpdwHCl([In] object obj0, [In] object obj1) => ((ComponentMetadataItem) obj0).Metadata = obj1;

    internal static Guid Qta7asBCZCEDJSBxonwD([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static void GURoKoBCuk6wyY4cGjlf([In] object obj0, Guid value) => ((ComponentMetadataItemHeader) obj0).Uid = value;

    internal static void jbsx2QBCIiDUSYeDyL5v([In] object obj0, [In] object obj1) => ((ComponentMetadataItemHeader) obj0).Name = (string) obj1;

    internal static void Hk3Pb7BCVAV3STNYVfFv([In] object obj0, [In] object obj1) => ((ComponentMetadataItemHeader) obj0).DisplayName = (string) obj1;

    internal static object VLQMBOBCSy2I0wga3ICU([In] object obj0) => (object) ((NamedMetadata) obj0).Description;

    internal static void raEnifBCib5sjoK3bsmb([In] object obj0, Guid value) => ((ComponentMetadataItemHeader) obj0).ModuleUid = value;

    internal static DateTime op8kR1BCRdbI28SB8IvU([In] object obj0) => ((ComponentMetadataItem) obj0).CreationDate;

    internal static void Kvi5xgBCqofeORBuXPAY([In] object obj0, [In] object obj1) => ((ComponentMetadataItemHeader) obj0).Draft = (ComponentMetadataItem) obj1;

    internal static Guid NkR9WMBCKNMZktyO5WWf([In] object obj0) => ((ComponentMetadata) obj0).GetMetadataTypeUid();

    internal static void TgS3knBCXFR94Ook0xAS([In] object obj0, Guid value) => ((ComponentMetadataItemHeader) obj0).MetadataTypeUid = value;

    internal static void o2eSCZBCTDXHE60HueUc([In] object obj0, [In] object obj1) => ((ComponentMetadataItem) obj0).Header = (ComponentMetadataItemHeader) obj1;

    internal static void e24Pk9BCk4TJKOgGUhet([In] object obj0, [In] object obj1) => ((ScriptModule) obj0).ClassName = (string) obj1;

    internal static void YxGhC9BCnWpcpgM2T0b3([In] object obj0, [In] object obj1) => ((ScriptModule) obj0).ModuleName = (string) obj1;

    internal static void znONuNBCO7isWkYOKQAb([In] object obj0, [In] object obj1) => ((ScriptModule) obj0).AssemblyName = (string) obj1;

    internal static void wrZcTkBC2SlMpCkukmhi([In] object obj0, Guid value) => ((ScriptModule) obj0).ModuleTypeUid = value;

    internal static void GMoFx4BCeD0GDyCEtvMh([In] object obj0, [In] object obj1) => ((ScriptModule) obj0).SourceCode = (string) obj1;

    internal static void TnKhA0BCPLxjGtCXqrVE([In] object obj0, [In] object obj1) => ((ScriptModule) obj0).References = (string) obj1;

    internal static void QNIMFGBC1K0Tp3sMNInH([In] object obj0, [In] object obj1) => ((ScriptModule) obj0).Namespace = (string) obj1;

    internal static object T889fsBCNqPXytji7JU3([In] object obj0, [In] object obj1) => (object) ((string) obj0).Split((char[]) obj1);

    internal static object CcMvRcBC3KHcOHF26eN9([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0).Replace((string) obj1, (string) obj2);

    internal static object ksD7jWBCp8r5fuBqNysR([In] object obj0, [In] object obj1, [In] StringSplitOptions obj2) => (object) ((string) obj0).Split((string[]) obj1, obj2);

    internal static object ASlj9iBCa2nLDsN2pdoN(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) ((string) obj0 + (string) obj1 + (string) obj2 + (string) obj3);
    }

    internal static bool A4481xBCDXthGmCfuxLd([In] object obj0, [In] object obj1) => ((string) obj0).Contains((string) obj1);

    internal static int GX6YqvBCtnEGuR8h0GtD([In] object obj0, [In] char obj1) => ((string) obj0).IndexOf(obj1);

    internal static object Fu9mkQBCww0hm02gkFqu([In] object obj0, [In] int obj1) => (object) ((string) obj0).Substring(obj1);

    internal static bool EFxr7MBC4er12ltS5Z8R([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static object dYAHpyBC6FYecChjI66W([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static object Wiw0o3BCHR7kbspqWTJa([In] object obj0) => (object) string.Concat((string[]) obj0);

    internal static int c6DObPBCAuWF9rQH0YXh([In] object obj0) => ((List<string>) obj0).Count;

    internal static object QcvD7KBC74OTqSu61cGl([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static object ncKfqQBCx2WMM7NcAgBh([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object KIQXKOBC0AhPW0H3UL8C(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) ((IScriptService) obj0).ChangeSourceClassName((string) obj1, (string) obj2, (string) obj3);
    }

    internal static Guid h5HobCBCm0JMY1TD3hgo([In] object obj0) => ((PropertyViewItem) obj0).PropertyUid;

    internal static bool LkSZQtBCyq3H7sE9g6R9([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static object DbW3sgBCMqWLYotJtJKl([In] object obj0) => (object) ((PropertyViewItem) obj0).Attributes;

    internal static object jL2fH6BCJpxfwYNMgcOl(
      [In] object obj0,
      Type entityType,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) ((IEntityFilterProvider) obj0).GetFilterProviderData(entityType, (PropertyMetadata) obj2, (ViewAttributes) obj3);
    }

    internal static object nvZPlcBC9QZwYN5Taakx(
      [In] object obj0,
      [In] object obj1,
      Type entityType,
      [In] object obj3,
      [In] object obj4)
    {
      return (object) ((IEntityInstanceFilterProvider) obj0).GetFilterProviderData((IEntity) obj1, entityType, (PropertyMetadata) obj3, (ViewAttributes) obj4);
    }

    internal static Guid f04e0yBCdY41miBwZbhO([In] object obj0) => ((IEntityFilterProvider) obj0).ProviderUid;

    internal static void GkOCpuBCl0TiZdHsTt5N([In] object obj0, Guid value) => ((ViewAttributes) obj0).EntityFilterProvider = value;

    internal static void C3O8HTBCrnnamx5JcMGO([In] object obj0, [In] object obj1) => ((ViewAttributes) obj0).EntityFilterData = (string) obj1;

    internal static bool cNGsrMBCgu2jSn3TeFOm([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    /// <summary>Событие публикации компонента</summary>
    private sealed class ComponentMetadataPublishingEventHandler : 
      IComponentMetadataPublishingEventHandler,
      IEventHandler
    {
      private readonly object componentMetadataPublishingActor;
      private readonly Guid componentHeaderUid;
      private readonly TaskCompletionSource<UIMetadataPublishResult> taskCompletionSource;
      private static object yCvYUmQbUimS9MVLbjdM;

      /// <summary>Ctor</summary>
      /// <param name="componentMetadataPublishingActor">Актор публикации</param>
      /// <param name="componentHeaderUid">Уникальный идентификатор заголовка компонента</param>
      public ComponentMetadataPublishingEventHandler(
        IComponentMetadataPublishingActor componentMetadataPublishingActor,
        Guid componentHeaderUid)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        this.taskCompletionSource = new TaskCompletionSource<UIMetadataPublishResult>(TaskCreationOptions.RunContinuationsAsynchronously);
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
          num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_3;
            case 1:
              this.componentMetadataPublishingActor = (object) componentMetadataPublishingActor;
              num = 2;
              continue;
            case 2:
              this.componentHeaderUid = componentHeaderUid;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
              continue;
            default:
              goto label_6;
          }
        }
label_3:
        return;
label_6:;
      }

      /// <inheritdoc />
      public Task PublicationSuccess(Guid componentMetadataUid, UIMetadataPublishResult result)
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.taskCompletionSource.TrySetResult(result);
              num = 3;
              continue;
            case 2:
              if (!ComponentMetadataItemManager.ComponentMetadataPublishingEventHandler.fByy4fQbzKVqYxtOjGSA(componentMetadataUid, this.componentHeaderUid))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 1 : 0;
                continue;
              }
              goto label_2;
            case 3:
              goto label_4;
            default:
              goto label_2;
          }
        }
label_2:
        return (Task) ComponentMetadataItemManager.ComponentMetadataPublishingEventHandler.mvgdd1QhFBUU4TV0xHi4();
label_4:
        return ((IComponentMetadataPublishingActor) this.componentMetadataPublishingActor).PublishComplete();
      }

      /// <inheritdoc />
      public Task PublicationError(Guid componentMetadataUid, Exception exception)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (!ComponentMetadataItemManager.ComponentMetadataPublishingEventHandler.fByy4fQbzKVqYxtOjGSA(componentMetadataUid, this.componentHeaderUid))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            case 2:
              goto label_5;
            case 3:
              goto label_2;
            default:
              ComponentMetadataItemManager.ComponentMetadataPublishingEventHandler.fs4K8fQhBc1ZpcsNDnLf((object) this.taskCompletionSource, (object) exception);
              num = 3;
              continue;
          }
        }
label_2:
        return (Task) ComponentMetadataItemManager.ComponentMetadataPublishingEventHandler.In1wUtQhWbvVZnalkcAS(this.componentMetadataPublishingActor);
label_5:
        return (Task) ComponentMetadataItemManager.ComponentMetadataPublishingEventHandler.mvgdd1QhFBUU4TV0xHi4();
      }

      /// <summary>Задача окончания публикации</summary>
      public Task<UIMetadataPublishResult> Wait => this.taskCompletionSource.Task;

      internal static bool DFp3tsQbseKcA0NkVS3d() => ComponentMetadataItemManager.ComponentMetadataPublishingEventHandler.yCvYUmQbUimS9MVLbjdM == null;

      internal static ComponentMetadataItemManager.ComponentMetadataPublishingEventHandler l91hvhQbc5OjhVZjxWxe() => (ComponentMetadataItemManager.ComponentMetadataPublishingEventHandler) ComponentMetadataItemManager.ComponentMetadataPublishingEventHandler.yCvYUmQbUimS9MVLbjdM;

      internal static bool fByy4fQbzKVqYxtOjGSA([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

      internal static object mvgdd1QhFBUU4TV0xHi4() => (object) Task.CompletedTask;

      internal static bool fs4K8fQhBc1ZpcsNDnLf([In] object obj0, [In] object obj1) => ((TaskCompletionSource<UIMetadataPublishResult>) obj0).TrySetException((Exception) obj1);

      internal static object In1wUtQhWbvVZnalkcAS([In] object obj0) => (object) ((IComponentMetadataPublishingActor) obj0).PublishComplete();
    }
  }
}
