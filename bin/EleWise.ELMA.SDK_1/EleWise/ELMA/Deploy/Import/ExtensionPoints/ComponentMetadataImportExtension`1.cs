// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.ExtensionPoints.ComponentMetadataImportExtension`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.FeatureFlags.Services;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints
{
  /// <summary>
  /// Абстрактная точка расширения для обработки компонентов при импорте конфигурации
  /// </summary>
  internal abstract class ComponentMetadataImportExtension<T> : NamedMetadataImportExtension<T> where T : ComponentMetadata
  {
    private static readonly ILogger ImportLog;
    private readonly IComponentMetadataItemManager componentMetadataItemManager;
    private readonly IComponentMetadataItemHeaderManager componentMetadataItemHeaderManager;
    private readonly IMetadataItemGroupUIManager metadataItemGroupUIManager;
    private readonly DataClassMetadataImportExtension dataClassMetadataImportExtension;
    private readonly IActorContextService actorContextService;
    private readonly IFeatureFlagService featureFlagService;
    private static object wUGbMBEdBynYJvQIJnNF;

    /// <summary>Ctor</summary>
    /// <param name="componentMetadataItemManager">Интерфейс менеджера метаданных компонента</param>
    /// <param name="componentMetadataItemHeaderManager">Интерфейс менеджера заголовков метаданных компонента</param>
    /// <param name="metadataItemGroupUIManager">Менеджер метаданных групп КИ</param>
    /// <param name="dataClassMetadataImportExtension">Точка расширения для обработки датаклассов при импорте конфигурации</param>
    /// <param name="actorContextService">Сервис контекста исполнения в акторе</param>
    /// <param name="featureFlagService">Сервис флагов функций</param>
    public ComponentMetadataImportExtension(
      IComponentMetadataItemManager componentMetadataItemManager,
      IComponentMetadataItemHeaderManager componentMetadataItemHeaderManager,
      IMetadataItemGroupUIManager metadataItemGroupUIManager,
      DataClassMetadataImportExtension dataClassMetadataImportExtension,
      IActorContextService actorContextService,
      IFeatureFlagService featureFlagService)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
        num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.dataClassMetadataImportExtension = dataClassMetadataImportExtension;
            num = 3;
            continue;
          case 3:
            this.actorContextService = actorContextService;
            num = 5;
            continue;
          case 4:
            this.componentMetadataItemManager = componentMetadataItemManager;
            num = 6;
            continue;
          case 5:
            this.featureFlagService = featureFlagService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 1;
            continue;
          case 6:
            this.componentMetadataItemHeaderManager = componentMetadataItemHeaderManager;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
            continue;
          default:
            this.metadataItemGroupUIManager = metadataItemGroupUIManager;
            num = 2;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    protected override bool TestMetadata(
      T mdMerged,
      ReadMetadataParameters parameters,
      bool isTestRead)
    {
      if (this.SecondRuntimeEnabled)
        return base.TestMetadata(mdMerged, parameters, isTestRead);
      parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1253244298 - 1829393894 ^ -576189956), (object) mdMerged.DisplayName)));
      return false;
    }

    /// <inheritdoc />
    protected override bool CheckMetadata(
      T mdImported,
      T mdDraft,
      ReadMetadataParameters parameters)
    {
      if (this.SecondRuntimeEnabled)
        return base.CheckMetadata(mdImported, mdDraft, parameters);
      parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487344066), (object) mdImported.DisplayName)));
      return false;
    }

    /// <inheritdoc />
    protected override void CheckNewMetadata(
      T mdImported,
      bool isTestRead,
      ReadMetadataParameters parameters)
    {
      base.CheckNewMetadata(mdImported, isTestRead, parameters);
      foreach (DataClassMetadata dataClass in mdImported.DataClasses)
        this.dataClassMetadataImportExtension.CheckNewMetadata(dataClass, parameters, isTestRead);
    }

    /// <inheritdoc />
    protected override void MergeMetadata(
      T mdImported,
      T mdDraft,
      bool isTestRead,
      ReadMetadataParameters parameters)
    {
      base.MergeMetadata(mdImported, mdDraft, isTestRead, parameters);
      List<DataClassMetadata> list = mdDraft.DataClasses.ToList<DataClassMetadata>();
      foreach (DataClassMetadata dataClass in mdImported.DataClasses)
      {
        DataClassMetadata dataClassImported = dataClass;
        DataClassMetadata mdDraft1;
        try
        {
          mdDraft1 = list.SingleOrDefault<DataClassMetadata>((Func<DataClassMetadata, bool>) (p => p.Uid == dataClassImported.Uid));
        }
        catch (InvalidOperationException ex)
        {
          parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1654249598 >> 2 ^ 413318393), (object) mdDraft.Name, (object) dataClassImported.Uid)));
          continue;
        }
        if (mdDraft1 != null && dataClassImported.Name != mdDraft1.Name)
          parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.InfoMetadata, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -69792627), (object) mdDraft.Name, (object) dataClassImported.Uid, (object) mdDraft1.Uid, (object) mdDraft.DisplayName, (object) dataClassImported.DisplayName, (object) mdDraft1.DisplayName, (object) dataClassImported.Name, (object) mdDraft1.Name)));
        if (mdDraft1 == null)
        {
          try
          {
            mdDraft1 = list.SingleOrDefault<DataClassMetadata>((Func<DataClassMetadata, bool>) (dc => dc.Name == dataClassImported.Name));
          }
          catch (InvalidOperationException ex)
          {
            continue;
          }
          if (mdDraft1 != null)
            parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.InfoMetadata, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -69792627), (object) mdDraft.Name, (object) dataClassImported.Uid, (object) mdDraft1.Uid, (object) mdDraft.DisplayName, (object) dataClassImported.DisplayName, (object) mdDraft1.DisplayName, (object) dataClassImported.Name, (object) mdDraft1.Name)));
        }
        if (mdDraft1 != null)
        {
          this.dataClassMetadataImportExtension.MergeMetadata(dataClassImported, mdDraft1, parameters, isTestRead);
          parameters.MergeReplace.SetUidReplaceMD(dataClassImported.Uid, mdDraft1.Uid);
          dataClassImported.Uid = mdDraft1.Uid;
          list.Remove(mdDraft1);
          list.Add(dataClassImported);
        }
        else
        {
          this.dataClassMetadataImportExtension.CheckNewMetadata(dataClassImported, parameters, isTestRead);
          list.Add(dataClassImported);
        }
      }
      mdDraft.DataClasses = list;
      if (isTestRead)
        return;
      mdDraft.Content = mdImported.Content;
      foreach (Implementation implementation1 in mdImported.Implementations)
      {
        Implementation implementation = implementation1;
        Implementation implementation2 = mdDraft.Implementations.FirstOrDefault<Implementation>((Func<Implementation, bool>) (i =>
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                if (i.PointId == implementation.PointId)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 0 : 0;
                  continue;
                }
                goto label_5;
              default:
                goto label_4;
            }
          }
label_4:
          return i.TypeUid == implementation.TypeUid;
label_5:
          return false;
        }));
        if (implementation2 == null)
          mdDraft.Implementations.Add(implementation);
        else
          implementation2.InputPropertyUid = implementation.InputPropertyUid;
      }
      foreach (ImplementationForm implementationForm1 in mdImported.ImplementationForms)
      {
        ImplementationForm implementationForm = implementationForm1;
        if (mdDraft.ImplementationForms.All<ImplementationForm>((Func<ImplementationForm, bool>) (f =>
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                if (!(f.MetadataUid != implementationForm.MetadataUid))
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
                  continue;
                }
                goto label_5;
              case 2:
                goto label_4;
              default:
                if (!(f.ModuleUid != implementationForm.ModuleUid))
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 2;
                  continue;
                }
                goto label_5;
            }
          }
label_4:
          return f.ViewType != implementationForm.ViewType;
label_5:
          return true;
        })))
          mdDraft.ImplementationForms.Add(implementationForm);
      }
      mdDraft.UserDefinedListInfos = mdImported.UserDefinedListInfos;
    }

    /// <inheritdoc />
    protected override void SaveMetadata(T mdMerged, ReadMetadataParameters parameters)
    {
      ComponentMetadataItem draft = this.componentMetadataItemHeaderManager.LoadOrNull(mdMerged.Uid)?.Draft;
      if (draft == null)
      {
        draft = this.componentMetadataItemManager.Create(mdMerged.GetMetadataTypeUid(), mdMerged.ModuleUid, Guid.Empty, mdMerged.DisplayName);
        draft.Header.Name = mdMerged.Name;
        draft.Header.Description = mdMerged.Description;
        draft.Header.Uid = mdMerged.Uid;
        draft.ScriptModule.Delete();
        draft.ScriptModule = (ScriptModule) null;
        draft.ClientScriptModule.Delete();
        draft.ClientScriptModule = (ScriptModule) null;
      }
      draft.Metadata = (object) mdMerged;
      this.SetScriptModule<ComponentMetadataItem>(draft, (Expression<Func<ComponentMetadataItem, ScriptModule>>) (componentMetadataItem => componentMetadataItem.ScriptModule), parameters);
      this.SetScriptModule<ComponentMetadataItem>(draft, (Expression<Func<ComponentMetadataItem, ScriptModule>>) (componentMetadataItem => componentMetadataItem.ClientScriptModule), parameters);
      string key = z2jc63fLkugS1X8Q9N.tE1kD1vbB(~538519529 ^ -538831742) + (object) mdMerged.Uid;
      string input;
      Guid result;
      if (parameters.ServiceData.TryGetValue(key, out input) && Guid.TryParse(input, out result))
      {
        MetadataItemGroupUI metadataItemGroupUi = this.metadataItemGroupUIManager.LoadOrNull(result);
        if (metadataItemGroupUi != null)
          draft.Header.Group = metadataItemGroupUi;
      }
      Type type = ComponentMetadataImportExtension<T>.ImportLog.IsInfoEnabled() ? mdMerged.GetType() : (Type) null;
      ComponentMetadataImportExtension<T>.ImportLog.InfoFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-630932142 - 1120244082 ^ -1751390432), (object) type.Name, (object) draft.Uid);
      draft.Save();
      ComponentMetadataImportExtension<T>.ImportLog.InfoFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477388592), (object) type.Name, (object) draft.Uid);
      parameters.Messages.Add(new DeployLogMessage(DeployLogMessageType.Info, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(2045296739 + 1688595713 ^ -561355588), (object) mdMerged.Uid, (object) mdMerged.DisplayName, (object) mdMerged.Name), false));
      ComponentMetadataImportExtension<T>.GetImportHeaders(this.actorContextService).Add(draft.Header.Uid);
      EntityMetadataDependencyService.GetPromisedMetadataDependencies(this.actorContextService).Add((IMetadata) mdMerged);
    }

    /// <summary>Получить заголовки импортируемых компонентов</summary>
    /// <param name="actorContextService">Сервис контекста исполнения в акторе</param>
    /// <returns>Заголовки импортируемых компонентов</returns>
    protected static ICollection<Guid> GetImportHeaders(IActorContextService actorContextService)
    {
      object importHeaders;
      if (!actorContextService.TryGet(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345145196), out importHeaders))
        actorContextService.Set(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -868038372), (object) (List<Guid>) (importHeaders = (object) new List<Guid>()));
      return (ICollection<Guid>) importHeaders;
    }

    /// <summary>Включен ли второй рантайм</summary>
    private bool SecondRuntimeEnabled => this.featureFlagService.Enabled(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~210725948 ^ -210747959), false);

    static ComponentMetadataImportExtension()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            ComponentMetadataImportExtension<T>.ImportLog = EleWise.ELMA.Logging.Logger.GetLogger(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470998129 - 231418599 ^ 1239873620));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 2 : 0;
            continue;
        }
      }
label_2:;
    }

    internal static bool bvIObLEdWK5Sb6x7jHTk() => ComponentMetadataImportExtension<T>.wUGbMBEdBynYJvQIJnNF == null;

    internal static object T14qUcEdoZYkZgssOjXL() => ComponentMetadataImportExtension<T>.wUGbMBEdBynYJvQIJnNF;
  }
}
