// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.Managers.ModuleMetadataItemManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using NHibernate.Transform;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace EleWise.ELMA.Model.Metadata.Managers
{
  /// <summary>Менеджер метаданных модулей</summary>
  internal class ModuleMetadataItemManager : 
    EntityManager<ModuleMetadataItem, long>,
    IModuleMetadataItemManager,
    IEntityManager<ModuleMetadataItem, long>,
    IEntityManager<ModuleMetadataItem>,
    IEntityManager
  {
    /// <summary>Prefix сборки для модулей</summary>
    internal const string AssemblyPrefix = "__ModuleAssembly__";
    private readonly ConcurrentDictionary<string, ModuleMetadataItem> moduleCache;
    private IEnumerable<IEntityFilterProvider> entityFilterProviders;
    internal static ModuleMetadataItemManager th1ewLbz6nJVn7IEhUH3;

    private IEnumerable<IEntityFilterProvider> EntityFilterProviders => this.entityFilterProviders ?? (this.entityFilterProviders = Locator.GetServiceNotNull<IEnumerable<IEntityFilterProvider>>());

    /// <summary>Экземпляр менеджера</summary>
    public static ModuleMetadataItemManager Instance => Locator.GetServiceNotNull<ModuleMetadataItemManager>();

    /// <summary>Ctor</summary>
    public ModuleMetadataItemManager()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.moduleCache = new ConcurrentDictionary<string, ModuleMetadataItem>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            ModuleMetadataItemManager.G9y9UJbzxxNcqtymHd7b(ModuleMetadataItemManager.Eb2aIdbz7Van90fwoKB9(), (object) new ResolveEventHandler(this.CurrentDomainOnAssemblyResolve));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <inheritdoc />
    public UIMetadataPublishResult Publish(Guid headerUid, string comment) => throw new NotImplementedException();

    /// <inheritdoc />
    public ModuleMetadataItem Create(string name, string displayName, string description)
    {
      int num = 4;
      ModuleInfoMetadata moduleInfoMetadata;
      while (true)
      {
        switch (num)
        {
          case 1:
            moduleInfoMetadata.Name = name;
            num = 2;
            continue;
          case 2:
            ModuleMetadataItemManager.Rqok6xbzmkuJUgNLeQku((object) moduleInfoMetadata, (object) displayName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
            continue;
          case 3:
            ModuleMetadataItemManager.O5hSTPbz0RnovppIDSS0((object) moduleInfoMetadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 1 : 0;
            continue;
          case 4:
            moduleInfoMetadata = new ModuleInfoMetadata();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 3 : 0;
            continue;
          case 5:
            goto label_3;
          default:
            ModuleMetadataItemManager.Js7w3sbzyAQuEyX1AuWa((object) moduleInfoMetadata, (object) description);
            num = 5;
            continue;
        }
      }
label_3:
      ModuleMetadataItem moduleMetadataItem = this.Create();
      ModuleMetadataItemManager.jAGsNlbzMltFjkarSWB8((object) moduleMetadataItem, (object) moduleInfoMetadata);
      ModuleMetadataItemManager.voZrQEbz9uRUmY4mEwSf((object) moduleMetadataItem, ModuleMetadataItemManager.QhsIUgbzJ6LIyfPJNew4((object) moduleInfoMetadata));
      ModuleMetadataItemManager.sKyYmybzdhR57YrjJmJr((object) moduleMetadataItem);
      return moduleMetadataItem;
    }

    /// <summary>Получить метаданные и скрипты модулей</summary>
    /// <param name="itemUids">Идентификаторы модулей</param>
    /// <param name="debug">Режим отображения</param>
    /// <returns>Список метаданных и скриптов</returns>
    public List<RuntimeModuleModel> LoadRuntimeMetadata(IEnumerable<Guid> itemUids, bool debug)
    {
      List<RuntimeModuleModel> runtimeModuleModelList = new List<RuntimeModuleModel>();
      if (itemUids.ToArray<Guid>().Length == 0)
        return runtimeModuleModelList;
      IList<ModuleMetadataItem> collection = (IList<ModuleMetadataItem>) new List<ModuleMetadataItem>();
      List<Guid> notLoadedItemUids = new List<Guid>();
      foreach (Guid itemUid in itemUids)
      {
        ModuleMetadataItem moduleMetadataItem;
        if (this.moduleCache.TryGetValue(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1052221104 - 768835541 ^ 283467327), (object) itemUid, (object) EleWise.ELMA.SR.CurrentLCID), out moduleMetadataItem))
          collection.Add(moduleMetadataItem);
        else
          notLoadedItemUids.Add(itemUid);
      }
      if (notLoadedItemUids.Count > 0)
      {
        IEnumerable<ModuleMetadataItem> loadedModules = (IEnumerable<ModuleMetadataItem>) null;
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
                loadedModules = (IEnumerable<ModuleMetadataItem>) this.CreateCriteriaForArraySearch<Guid>((IEnumerable<Guid>) notLoadedItemUids, (string) ModuleMetadataItemManager.\u003C\u003Ec__DisplayClass10_1.MaWMMeCJp0tUTguQOYIl(1917256330 ^ 1917283608), (IEntityFilter) null, (FetchOptions) null).List<ModuleMetadataItem>();
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }));
        foreach (ModuleMetadataItem moduleMetadataItem in loadedModules)
          this.moduleCache.TryAdd(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70088727), (object) moduleMetadataItem.Uid, (object) EleWise.ELMA.SR.CurrentLCID), moduleMetadataItem);
        collection.AddRange<ModuleMetadataItem>(loadedModules);
      }
      if (collection.Count == 0)
        return runtimeModuleModelList;
      foreach (ModuleMetadataItem cloneObject in (IEnumerable<ModuleMetadataItem>) collection)
      {
        ModuleMetadataItem moduleMetadataItem1 = cloneObject;
        string resource = Encoding.UTF8.GetString((debug ? cloneObject.ClientDebugRaw : cloneObject.ClientAssemblyRaw) ?? Array.Empty<byte>());
        ModuleInfoMetadata metadata = (ModuleInfoMetadata) moduleMetadataItem1.Metadata;
        long? id1 = moduleMetadataItem1.Header.Published?.Id;
        long id2 = moduleMetadataItem1.Id;
        if (id1.GetValueOrDefault() == id2 & id1.HasValue)
        {
          foreach (ComponentMetadata component in metadata.Components)
          {
            foreach (PropertyViewItem allProperty in component.Content.View.GetAllProperties())
              this.FillFilterProvider(allProperty, (Type) null, (IEntity) moduleMetadataItem1, (ClassMetadata) component.Content.Context);
          }
        }
        if (EleWise.ELMA.SR.GetCurrentCulture().Name != EleWise.ELMA.SR.KeyCultureInfo.Name)
        {
          resource = EleWise.ELMA.SR.TranslateStringResource(resource);
          moduleMetadataItem1 = CloneHelperBuilder.Create<ModuleMetadataItem>(cloneObject).Restrictions((Action<RestrictionsBuilder<ModuleMetadataItem>>) (a => a.Rule().ForPropertyName((Expression<Func<ModuleMetadataItem, object>>) (moduleMetadataItem => moduleMetadataItem.Header)).ByRef())).Clone();
          moduleMetadataItem1.Uid = cloneObject.Uid;
          foreach (ComponentMetadata component in metadata.Components)
            component.Content.View.ApplyLocalization();
        }
        runtimeModuleModelList.Add(new RuntimeModuleModel()
        {
          MetadataItem = moduleMetadataItem1,
          Script = new ClientScriptModel()
          {
            AssemblyName = ModuleMetadataItemManager.ClientAssemblyName(metadata),
            SourceCode = resource
          }
        });
      }
      return runtimeModuleModelList;
    }

    /// <inheritdoc />
    public override void Save(ModuleMetadataItem obj)
    {
      int num1 = 7;
      while (true)
      {
        int num2 = num1;
        ModuleInfoMetadata moduleInfoMetadata;
        IUser user;
        while (true)
        {
          switch (num2)
          {
            case 1:
              base.Save(obj);
              num2 = 9;
              continue;
            case 2:
              if (!ModuleMetadataItemManager.YyWFfEbz5lEEclaRNNYn((object) obj))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 1 : 1;
                continue;
              }
              user = (IUser) ModuleMetadataItemManager.STC2YKbzjoTqpTrUilgc((object) this.AuthenticationService);
              num2 = 14;
              continue;
            case 3:
              ModuleMetadataItemManager.FaS10GbzzXpDKLYAlUBu((object) obj.Header, (object) obj);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 17 : 15;
              continue;
            case 4:
              ModuleMetadataItemManager.n3fyrDbzLFVg8NhCfvDX((object) obj, (object) InterfaceActivator.Create<ModuleMetadataItemHeader>());
              num2 = 5;
              continue;
            case 5:
              ModuleMetadataItemManager.NvF8oebzc1B2i7LcZMvx(ModuleMetadataItemManager.V5RJkZbzUJJDyB8wfuaF((object) obj), ModuleMetadataItemManager.UcuscFbzsAPsYwp7BxPD((object) obj));
              num2 = 12;
              continue;
            case 6:
              ModuleMetadataItemManager.HkPO2VbzgtXEUyW0oD2P(ModuleMetadataItemManager.IRlokkbzr7hAX5SAefqd((object) obj) != null, ModuleMetadataItemManager.FQYAlkbzlFWi9cTXkavo(-488881205 ^ -488850937));
              num2 = 11;
              continue;
            case 7:
              goto label_11;
            case 8:
              base.Save(obj);
              num2 = 16;
              continue;
            case 9:
              goto label_17;
            case 10:
              ModuleMetadataItemManager.S1LkK0hFBCT3P9FiLe2m(ModuleMetadataItemManager.V5RJkZbzUJJDyB8wfuaF((object) obj), ModuleMetadataItemManager.H3R8g7hFFDt14Zx9gXar((object) moduleInfoMetadata));
              num2 = 15;
              continue;
            case 11:
              ModuleMetadataItemManager.HkPO2VbzgtXEUyW0oD2P(obj.Metadata is ModuleInfoMetadata, ModuleMetadataItemManager.FQYAlkbzlFWi9cTXkavo(979449278 ^ 979511786));
              num2 = 2;
              continue;
            case 12:
              obj.Header.CreationAuthorId = (long?) (user != null ? ModuleMetadataItemManager.QA06IAbzYSnlPvass4Tr((object) user) : (object) null);
              num2 = 3;
              continue;
            case 13:
              ((ModuleMetadataItemHeader) ModuleMetadataItemManager.V5RJkZbzUJJDyB8wfuaF((object) obj)).Uid = ModuleMetadataItemManager.QhsIUgbzJ6LIyfPJNew4((object) moduleInfoMetadata);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 10 : 0;
              continue;
            case 14:
              obj.CreationAuthorId = (long?) (user == null ? (object) null : ModuleMetadataItemManager.QA06IAbzYSnlPvass4Tr((object) user));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 0;
              continue;
            case 15:
              ModuleMetadataItemManager.xjLPaBhFob9aY6MPwtyX(ModuleMetadataItemManager.V5RJkZbzUJJDyB8wfuaF((object) obj), ModuleMetadataItemManager.xoRIuUhFWJCC875rEdiZ((object) moduleInfoMetadata));
              num2 = 8;
              continue;
            case 16:
              goto label_22;
            case 17:
              moduleInfoMetadata = (ModuleInfoMetadata) ModuleMetadataItemManager.IRlokkbzr7hAX5SAefqd((object) obj);
              num2 = 13;
              continue;
            default:
              if (obj.Header != null)
                goto case 17;
              else
                goto label_8;
          }
        }
label_8:
        num1 = 4;
        continue;
label_11:
        Contract.ArgumentNotNull((object) obj, (string) ModuleMetadataItemManager.FQYAlkbzlFWi9cTXkavo(1232639661 >> 3 ^ 154120541));
        num1 = 6;
      }
label_17:
      return;
label_22:;
    }

    /// <summary>Получить все последние опубликованные версии модулей</summary>
    /// <param name="notLoaded">Список идентификаторов заголовков модулей, которые не нужно загружать</param>
    /// <returns>Список последних версий</returns>
    public IEnumerable<ModuleMetadataItem> GetLastPublished(IEnumerable<Guid> notLoaded) => (IEnumerable<ModuleMetadataItem>) this.CreateCriteria(FetchOptions.All, this.ImplementationType, z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 1867318371)).CreateAlias(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1642859704 ^ 1642904074), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2108006230), JoinType.InnerJoin, (ICriterion) Restrictions.EqProperty(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-680446928 - -370807692 ^ -309611990), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-630932142 - 1120244082 ^ -1751130558))).Add((ICriterion) Restrictions.Not((ICriterion) Restrictions.In(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1251470110 >> 2 ^ 312807291), (ICollection) notLoaded.ToArray<Guid>()))).Add((ICriterion) Restrictions.IsNotNull(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978441230))).Add((ICriterion) Restrictions.IsNotNull(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 1333774198))).Add((ICriterion) Restrictions.IsNotNull(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -36028249))).List<ModuleMetadataItem>();

    /// <summary>
    /// Получить заголовки всех последних опубликованных версии модулей
    /// </summary>
    /// <param name="notLoaded">Список идентификаторов заголовков модулей, которые не нужно загружать</param>
    /// <returns>Список заголовков последних версий</returns>
    public IEnumerable<ModuleMetadataItemWrapper> GetLastPublishedHeaders(
      IEnumerable<Guid> notLoaded)
    {
      return (IEnumerable<ModuleMetadataItemWrapper>) this.CreateCriteria(FetchOptions.All, this.ImplementationType, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470440286 ^ 1470486222)).CreateAlias(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822928726), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837641009), JoinType.InnerJoin, (ICriterion) Restrictions.EqProperty(z2jc63fLkugS1X8Q9N.tE1kD1vbB(2045296739 + 1688595713 ^ -561096462), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1253244298 - 1829393894 ^ -576171514))).Add((ICriterion) Restrictions.Not((ICriterion) Restrictions.In(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-138018305 ^ -137956285), (ICollection) notLoaded.ToArray<Guid>()))).Add((ICriterion) Restrictions.IsNotNull(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-441065788 ^ -2092910478 ^ 1727322038))).Add((ICriterion) Restrictions.IsNotNull(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1581325282 << 3 ^ -234345868))).Add((ICriterion) Restrictions.IsNotNull(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-53329496 >> 4 ^ -3299986))).SetProjection((IProjection) Projections.ProjectionList().Add((IProjection) Projections.Property(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70045007)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(372753449 ^ 372715859)).Add((IProjection) Projections.Property(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-649342099 - -1150814748 ^ 501461531)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1142330761 ^ 1541959139 ^ 536778744)).Add((IProjection) Projections.Property(z2jc63fLkugS1X8Q9N.tE1kD1vbB(322893104 - -1992822529 ^ -1979190955)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(647913418 ^ 647932590))).SetResultTransformer((IResultTransformer) new EleWise.ELMA.Runtime.NH.AliasToBeanResultTransformer(typeof (ModuleMetadataItemWrapper))).List<ModuleMetadataItemWrapper>();
    }

    /// <summary>Имя клиентской сборки</summary>
    /// <param name="metadata">Метаданные</param>
    /// <returns>Имя клиентской сборки</returns>
    internal static string ClientAssemblyName(ModuleInfoMetadata metadata) => (string) ModuleMetadataItemManager.cT841whFbe751E2uPBeH((object) ((string) ModuleMetadataItemManager.FQYAlkbzlFWi9cTXkavo(-1886646897 ^ -1886592705) + (string) ModuleMetadataItemManager.H3R8g7hFFDt14Zx9gXar((object) metadata)), '.', '_');

    /// <summary>Имя серверной сборки</summary>
    /// <param name="metadata">Метаданные</param>
    /// <returns>Имя серверной сборки</returns>
    internal static string ServerAssemblyName(ModuleInfoMetadata metadata) => (string) ModuleMetadataItemManager.sdPcyQhFhsV8fT3lOn9y(ModuleMetadataItemManager.FQYAlkbzlFWi9cTXkavo(-1088304168 ^ -1088346264), ModuleMetadataItemManager.H3R8g7hFFDt14Zx9gXar((object) metadata));

    /// <summary>Идентификатор версии модуля</summary>
    /// <param name="metadata">Метаданные модуля</param>
    /// <param name="version">Версия модуля</param>
    /// <returns>Уникальный идентификатор версии</returns>
    internal static Guid VersionUid(ModuleInfoMetadata metadata, string version) => ModuleMetadataItemManager.dJuLsNhFEa3mboGPDEcY(ModuleMetadataItemManager.FksQXOhFG5lQJni74lXB(ModuleMetadataItemManager.FQYAlkbzlFWi9cTXkavo(1505778440 - 1981636111 ^ -475930523), (object) ModuleMetadataItemManager.QhsIUgbzJ6LIyfPJNew4((object) metadata), ModuleMetadataItemManager.H3R8g7hFFDt14Zx9gXar((object) metadata), (object) version));

    private Assembly CurrentDomainOnAssemblyResolve(object sender, ResolveEventArgs args)
    {
      int num = 2;
      AssemblyName assemblyName;
      ModuleMetadataItem moduleMetadataItem;
      Assembly assembly;
      while (true)
      {
        switch (num)
        {
          case 1:
            assemblyName = new AssemblyName((string) ModuleMetadataItemManager.Ics6j9hFfSkFje2wQuya((object) args));
            num = 3;
            continue;
          case 2:
            if (((string) ModuleMetadataItemManager.Ics6j9hFfSkFje2wQuya((object) args)).StartsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1994213607 >> 4 ^ 124598334)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 1 : 1;
              continue;
            }
            goto label_9;
          case 3:
            moduleMetadataItem = ((ICriteria) ModuleMetadataItemManager.DgEfXYhFvZ11JmFoJDXT(ModuleMetadataItemManager.DgEfXYhFvZ11JmFoJDXT((object) this.CreateCriteria(), ModuleMetadataItemManager.g0V8vPhFC3Zgl0p2neld(ModuleMetadataItemManager.FQYAlkbzlFWi9cTXkavo(1597012150 ^ 1597098214), ModuleMetadataItemManager.z8AYYUhFQ4wP0oMSrGCb((object) assemblyName))), (object) Restrictions.Eq((string) ModuleMetadataItemManager.FQYAlkbzlFWi9cTXkavo(-740338220 ^ -740305760), (object) ModuleMetadataItemManager.QWulBxhF8FiGb4Jj4QMa((object) assemblyName).ToString()))).UniqueResult<ModuleMetadataItem>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 7 : 8;
            continue;
          case 4:
            assembly = (Assembly) ModuleMetadataItemManager.QLb46FhFSfe72dsBNNtK(ModuleMetadataItemManager.TcUnOXhFIWwoBjOcJjNA((object) moduleMetadataItem), ModuleMetadataItemManager.zdIpE4hFVTHM2ccetdxf((object) moduleMetadataItem));
            num = 5;
            continue;
          case 6:
            if (moduleMetadataItem == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 0 : 0;
              continue;
            }
            goto case 4;
          case 7:
            if (ModuleMetadataItemManager.eXwD0yhFu15Wb9Ghq5fV((object) assembly, (object) null))
            {
              num = 6;
              continue;
            }
            goto label_8;
          case 8:
            assembly = (Assembly) ModuleMetadataItemManager.NjQDeDhFZrFPWaCjxoiW((object) ScriptExecutionHandlerHelper.CreateFullAssemblyName(assemblyName.Name, ModuleMetadataItemManager.QWulBxhF8FiGb4Jj4QMa((object) assemblyName).ToString(), (string) ModuleMetadataItemManager.FQYAlkbzlFWi9cTXkavo(-710283084 ^ -537863435 ^ 173666215), (string) ModuleMetadataItemManager.FQYAlkbzlFWi9cTXkavo(-1317790512 ^ -1317794762)), true);
            num = 7;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      return assembly;
label_9:
      return (Assembly) null;
    }

    private void FillFilterProvider(
      PropertyViewItem propertyViewItem,
      Type containerType,
      IEntity entity,
      ClassMetadata contextMetadata)
    {
      int num1 = 1;
      PropertyMetadata propertyMetadata;
      ViewAttributes attributes;
      IEnumerator<IEntityFilterProvider> enumerator;
      while (true)
      {
        int num2 = num1;
        PropertyViewItem propertyViewItem1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 0;
              continue;
            case 2:
              if (propertyMetadata == null)
              {
                num2 = 4;
                continue;
              }
              attributes = propertyViewItem1.Attributes;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 4 : 5;
              continue;
            case 3:
              goto label_26;
            case 4:
              goto label_31;
            case 5:
              goto label_29;
            case 6:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              propertyMetadata = contextMetadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => ModuleMetadataItemManager.\u003C\u003Ec__DisplayClass18_0.OW3J2RCJ7nl3b8vYSF4E((object) p) == ModuleMetadataItemManager.\u003C\u003Ec__DisplayClass18_0.CPPGxmCJxuTkQppPlQNL((object) propertyViewItem1)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 1 : 2;
              continue;
            case 7:
              goto label_5;
            default:
              propertyViewItem1 = propertyViewItem;
              num2 = 6;
              continue;
          }
        }
label_29:
        enumerator = this.EntityFilterProviders.GetEnumerator();
        num1 = 7;
      }
label_26:
      return;
label_31:
      return;
label_5:
      try
      {
label_9:
        if (ModuleMetadataItemManager.R5hRKShFq2GJxHXNnTt8((object) enumerator))
          goto label_18;
        else
          goto label_10;
label_6:
        IEntityFilterProvider current;
        int num3;
        while (true)
        {
          IEntityInstanceFilterProvider instanceFilterProvider;
          string str;
          object obj;
          switch (num3)
          {
            case 1:
              attributes.EntityFilterProvider = current.ProviderUid;
              num3 = 8;
              continue;
            case 2:
              if (str != null)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 1 : 1;
                continue;
              }
              goto label_9;
            case 3:
              if (instanceFilterProvider == null)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 4 : 5;
                continue;
              }
              obj = ModuleMetadataItemManager.YPw3l3hFi7P7HSNpPqi5((object) instanceFilterProvider, (object) entity, containerType, (object) propertyMetadata, (object) attributes);
              break;
            case 4:
              goto label_21;
            case 5:
              obj = (object) current.GetFilterProviderData(containerType, propertyMetadata, attributes);
              break;
            case 6:
              instanceFilterProvider = current as IEntityInstanceFilterProvider;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 3 : 0;
              continue;
            case 7:
              goto label_9;
            case 8:
              ModuleMetadataItemManager.hQboEahFRHf5RHBHVNJ0((object) attributes, (object) str);
              num3 = 4;
              continue;
            case 9:
              goto label_12;
            default:
              goto label_18;
          }
          str = (string) obj;
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 2 : 1;
        }
label_21:
        return;
label_12:
        return;
label_10:
        num3 = 9;
        goto label_6;
label_18:
        current = enumerator.Current;
        num3 = 6;
        goto label_6;
      }
      finally
      {
        if (enumerator != null)
        {
          int num4 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
            num4 = 1;
          while (true)
          {
            switch (num4)
            {
              case 1:
                ModuleMetadataItemManager.Ko67KDhFKwxRchufaCbi((object) enumerator);
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 0 : 0;
                continue;
              default:
                goto label_28;
            }
          }
        }
label_28:;
      }
    }

    internal static object Eb2aIdbz7Van90fwoKB9() => (object) AppDomain.CurrentDomain;

    internal static void G9y9UJbzxxNcqtymHd7b([In] object obj0, [In] object obj1) => ((AppDomain) obj0).AssemblyResolve += (ResolveEventHandler) obj1;

    internal static bool YWji0qbzHgHkrdU6gVGP() => ModuleMetadataItemManager.th1ewLbz6nJVn7IEhUH3 == null;

    internal static ModuleMetadataItemManager bH1wYabzAucifpgJhYwJ() => ModuleMetadataItemManager.th1ewLbz6nJVn7IEhUH3;

    internal static void O5hSTPbz0RnovppIDSS0([In] object obj0) => ((AbstractMetadata) obj0).InitNew();

    internal static void Rqok6xbzmkuJUgNLeQku([In] object obj0, [In] object obj1) => ((NamedMetadata) obj0).DisplayName = (string) obj1;

    internal static void Js7w3sbzyAQuEyX1AuWa([In] object obj0, [In] object obj1) => ((NamedMetadata) obj0).Description = (string) obj1;

    internal static void jAGsNlbzMltFjkarSWB8([In] object obj0, [In] object obj1) => ((ModuleMetadataItem) obj0).Metadata = obj1;

    internal static Guid QhsIUgbzJ6LIyfPJNew4([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static void voZrQEbz9uRUmY4mEwSf([In] object obj0, Guid value) => ((ModuleMetadataItem) obj0).Uid = value;

    internal static void sKyYmybzdhR57YrjJmJr([In] object obj0) => ((Entity<long>) obj0).Save();

    internal static object FQYAlkbzlFWi9cTXkavo(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object IRlokkbzr7hAX5SAefqd([In] object obj0) => ((ModuleMetadataItem) obj0).Metadata;

    internal static void HkPO2VbzgtXEUyW0oD2P(bool condition, [In] object obj1) => Contract.CheckArgument(condition, (string) obj1);

    internal static bool YyWFfEbz5lEEclaRNNYn([In] object obj0) => ((Entity<long>) obj0).IsNew();

    internal static object STC2YKbzjoTqpTrUilgc([In] object obj0) => (object) ((IAuthenticationService) obj0).GetCurrentUser();

    internal static object QA06IAbzYSnlPvass4Tr([In] object obj0) => ((IIdentified) obj0).GetId();

    internal static void n3fyrDbzLFVg8NhCfvDX([In] object obj0, [In] object obj1) => ((ModuleMetadataItem) obj0).Header = (ModuleMetadataItemHeader) obj1;

    internal static object V5RJkZbzUJJDyB8wfuaF([In] object obj0) => (object) ((ModuleMetadataItem) obj0).Header;

    internal static DateTime UcuscFbzsAPsYwp7BxPD([In] object obj0) => ((ModuleMetadataItem) obj0).CreationDate;

    internal static void NvF8oebzc1B2i7LcZMvx([In] object obj0, DateTime value) => ((ModuleMetadataItemHeader) obj0).CreationDate = value;

    internal static void FaS10GbzzXpDKLYAlUBu([In] object obj0, [In] object obj1) => ((ModuleMetadataItemHeader) obj0).Draft = (ModuleMetadataItem) obj1;

    internal static object H3R8g7hFFDt14Zx9gXar([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static void S1LkK0hFBCT3P9FiLe2m([In] object obj0, [In] object obj1) => ((ModuleMetadataItemHeader) obj0).Name = (string) obj1;

    internal static object xoRIuUhFWJCC875rEdiZ([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;

    internal static void xjLPaBhFob9aY6MPwtyX([In] object obj0, [In] object obj1) => ((ModuleMetadataItemHeader) obj0).DisplayName = (string) obj1;

    internal static object cT841whFbe751E2uPBeH([In] object obj0, [In] char obj1, [In] char obj2) => (object) ((string) obj0).Replace(obj1, obj2);

    internal static object sdPcyQhFhsV8fT3lOn9y([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object FksQXOhFG5lQJni74lXB(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) string.Format((string) obj0, obj1, obj2, obj3);
    }

    internal static Guid dJuLsNhFEa3mboGPDEcY([In] object obj0) => ((string) obj0).GetDeterministicGuid();

    internal static object Ics6j9hFfSkFje2wQuya([In] object obj0) => (object) ((ResolveEventArgs) obj0).Name;

    internal static object z8AYYUhFQ4wP0oMSrGCb([In] object obj0) => (object) ((AssemblyName) obj0).Name;

    internal static object g0V8vPhFC3Zgl0p2neld([In] object obj0, [In] object obj1) => (object) Restrictions.Eq((string) obj0, obj1);

    internal static object DgEfXYhFvZ11JmFoJDXT([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).Add((ICriterion) obj1);

    internal static object QWulBxhF8FiGb4Jj4QMa([In] object obj0) => (object) ((AssemblyName) obj0).Version;

    internal static object NjQDeDhFZrFPWaCjxoiW([In] object obj0, bool isFullName) => (object) ComponentManager.FindLoadedAssembly((string) obj0, isFullName);

    internal static bool eXwD0yhFu15Wb9Ghq5fV([In] object obj0, [In] object obj1) => (Assembly) obj0 == (Assembly) obj1;

    internal static object TcUnOXhFIWwoBjOcJjNA([In] object obj0) => (object) ((ModuleMetadataItem) obj0).AssemblyRaw;

    internal static object zdIpE4hFVTHM2ccetdxf([In] object obj0) => (object) ((ModuleMetadataItem) obj0).DebugRaw;

    internal static object QLb46FhFSfe72dsBNNtK([In] object obj0, [In] object obj1) => (object) ComponentManager.LoadAssembly((byte[]) obj0, (byte[]) obj1);

    internal static object YPw3l3hFi7P7HSNpPqi5(
      [In] object obj0,
      [In] object obj1,
      Type entityType,
      [In] object obj3,
      [In] object obj4)
    {
      return (object) ((IEntityInstanceFilterProvider) obj0).GetFilterProviderData((IEntity) obj1, entityType, (PropertyMetadata) obj3, (ViewAttributes) obj4);
    }

    internal static void hQboEahFRHf5RHBHVNJ0([In] object obj0, [In] object obj1) => ((ViewAttributes) obj0).EntityFilterData = (string) obj1;

    internal static bool R5hRKShFq2GJxHXNnTt8([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void Ko67KDhFKwxRchufaCbi([In] object obj0) => ((IDisposable) obj0).Dispose();
  }
}
