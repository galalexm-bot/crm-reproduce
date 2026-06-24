// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.ExtensionPoints.EntityExecuteMetadataExtension`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Components;
using EleWise.ELMA.Deploy.Import.Helpers;
using EleWise.ELMA.FeatureFlags.Services;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Helpers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints
{
  /// <summary>
  /// Базовая реализация точки расширения для обработки EntityMetadata при импорте конфигурации
  /// </summary>
  public abstract class EntityExecuteMetadataExtension<T> : 
    EntityMetadataImportExtension<T, TablePartMetadata, EntityMetadata>
    where T : EntityMetadata
  {
    private static readonly ILogger ImportLog;
    private readonly DataClassMetadataImportExtension dataClassMetadataImportExtension;
    private readonly IEntityMetadataDependencyService entityMetadataDependencyService;
    private readonly MetadataItemManager metadataItemManager;
    private readonly IFeatureFlagService featureFlagService;
    internal static object zP62mlElabJ14TiWKq2S;

    /// <summary>Конструктор</summary>
    public EntityExecuteMetadataExtension()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.dataClassMetadataImportExtension = Locator.GetServiceNotNull<DataClassMetadataImportExtension>();
            num = 2;
            continue;
          case 2:
            this.entityMetadataDependencyService = Locator.GetServiceNotNull<IEntityMetadataDependencyService>();
            num = 3;
            continue;
          case 3:
            this.metadataItemManager = Locator.GetServiceNotNull<MetadataItemManager>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 0 : 0;
            continue;
          case 4:
            goto label_3;
          default:
            this.featureFlagService = Locator.GetServiceNotNull<IFeatureFlagService>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 4 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    protected override IReadMetadataResult ReadMetadata(
      T metadata,
      ReadMetadataParameters parameters,
      bool isTestRead)
    {
      IReadMetadataResult readMetadataResult = base.ReadMetadata(metadata, parameters, isTestRead);
      if (metadata.IsUnique)
      {
        parameters.MetadataNotIsUnique.Remove(metadata.Uid);
        parameters.MetadataNotIsUnique.Remove(metadata.ImplementationUid);
        return readMetadataResult;
      }
      parameters.MetadataNotIsUnique.Add(metadata.Uid);
      parameters.MetadataNotIsUnique.Add(metadata.ImplementationUid);
      return readMetadataResult;
    }

    /// <inheritdoc />
    protected override void SaveMetadata(T mdMerged, ReadMetadataParameters parameters)
    {
      base.SaveMetadata(mdMerged, parameters);
      try
      {
        IMetadataItem metadataItem = this.metadataItemManager.LoadOrNull(mdMerged.Uid);
        this.entityMetadataDependencyService.CollectDependencies((EntityMetadata) mdMerged, metadataItem);
        metadataItem.Save();
      }
      catch (Exception ex)
      {
        parameters.Messages?.Add(new DeployLogMessage(DeployLogMessageType.Warn, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(647913418 ^ 647675308), (object) mdMerged.DisplayName, (object) mdMerged.Name, (object) mdMerged.Uid)));
        EntityExecuteMetadataExtension<T>.ImportLog.Error((object) ex.Message);
      }
    }

    /// <inheritdoc />
    protected override T GetDraft(T mdImported, ReadMetadataParameters parameters)
    {
      T draft = base.GetDraft(mdImported, parameters);
      if ((object) draft == null && mdImported.Type == EntityMetadataType.InterfaceExtension)
      {
        draft = this.MetadataEditorService.GetMetadataList().OfType<T>().FirstOrDefault<T>((Func<T, bool>) (md => md.Name == mdImported.Name && md.TypeUid == mdImported.TypeUid && md.BaseClassUid == mdImported.BaseClassUid && md.Type == mdImported.Type && this.MetadataEditorService.IsConfig(md.Uid)));
        if ((object) draft != null)
        {
          parameters.MergeReplace.SetUidReplaceMD(mdImported.Uid, draft.Uid);
          parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.InfoMetadata, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867502261), (object) mdImported.Uid, (object) mdImported.DisplayName, (object) draft.Uid, (object) draft.DisplayName, (object) mdImported.Name, (object) draft.Name)));
        }
      }
      return draft;
    }

    /// <inheritdoc />
    protected override void MergeMetadata(
      T mdImported,
      T mdMerged,
      bool isTestRead,
      ReadMetadataParameters parameters)
    {
      base.MergeMetadata(mdImported, mdMerged, isTestRead, parameters);
      this.MergeHierarchyProperties((EntityMetadata) mdImported, (EntityMetadata) mdMerged, isTestRead, parameters);
      if (isTestRead)
        return;
      if (mdImported.ViewModelMetadata != null)
      {
        if (mdMerged.ViewModelMetadata != null)
        {
          this.dataClassMetadataImportExtension.MergeMetadata(mdImported.ViewModelMetadata, mdMerged.ViewModelMetadata, parameters, isTestRead);
        }
        else
        {
          this.dataClassMetadataImportExtension.CheckNewMetadata(mdImported.ViewModelMetadata, parameters, isTestRead);
          mdMerged.ViewModelMetadata = mdImported.ViewModelMetadata;
        }
      }
      if (mdImported.CacheEntity)
        mdMerged.CacheEntity = true;
      if (mdImported.Filterable)
        mdMerged.Filterable = true;
      if (mdImported.FilterImplementedInterfaces != null)
      {
        if (mdMerged.FilterImplementedInterfaces == null)
          mdMerged.FilterImplementedInterfaces = mdImported.FilterImplementedInterfaces;
        else
          mdMerged.FilterImplementedInterfaces = mdMerged.FilterImplementedInterfaces.Union<string>((IEnumerable<string>) mdImported.FilterImplementedInterfaces).Distinct<string>().ToList<string>();
      }
      if (mdImported.IsSoftDeletable)
        mdMerged.IsSoftDeletable = true;
      if (mdImported.IsUnique)
        mdMerged.IsUnique = true;
      if (mdImported.SaveHistory)
        mdMerged.SaveHistory = true;
      mdMerged.ShowInCatalogList = mdImported.ShowInCatalogList;
      mdMerged.InstancePermissionsSupport = mdImported.InstancePermissionsSupport;
      mdMerged.PermissionsMetadataName = mdImported.PermissionsMetadataName;
      mdMerged.PermissionsPropertyName = mdImported.PermissionsPropertyName;
      this.MergeMetadataActions((EntityMetadata) mdImported, (EntityMetadata) mdMerged);
      this.MergeMetadataFilter((EntityMetadata) mdImported, (EntityMetadata) mdMerged);
    }

    /// <inheritdoc />
    protected override bool CheckMetadata(
      T mdImported,
      T mdDraft,
      ReadMetadataParameters parameters)
    {
      if (mdImported.ViewModelMetadata != null && !this.SecondRuntimeEnabled)
      {
        parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1654249598 >> 2 ^ 413307421), (object) mdImported.DisplayName, (object) mdImported.Uid)));
        return false;
      }
      if (mdImported.Forms.Any<FormViewItem>((Func<FormViewItem, bool>) (a => a.RuntimeVersion == RuntimeVersion.Version2)) && !this.SecondRuntimeEnabled)
      {
        parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(95909607 + 343705423 ^ 439818804), (object) mdImported.DisplayName, (object) mdImported.Uid)));
        return false;
      }
      bool flag = base.CheckMetadata(mdImported, mdDraft, parameters);
      if (mdImported.Uid == mdDraft.Uid && (mdDraft.TableName ?? "") != (mdImported.TableName ?? ""))
      {
        parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~210725948 ^ -210471177), (object) mdImported.DisplayName, (object) mdImported.Uid, (object) mdDraft.DisplayName, (object) mdImported.TableName, (object) mdDraft.TableName, (object) mdDraft.Uid)));
        flag = false;
      }
      return flag;
    }

    /// <inheritdoc />
    protected override bool TestMetadata(
      T mdImported,
      ReadMetadataParameters parameters,
      bool isTestRead)
    {
      if (mdImported.ViewModelMetadata != null && !this.SecondRuntimeEnabled)
      {
        parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -35772975), (object) mdImported.DisplayName, (object) mdImported.Uid)));
        return false;
      }
      if (mdImported.Forms.Any<FormViewItem>((Func<FormViewItem, bool>) (a => a.RuntimeVersion == RuntimeVersion.Version2)) && !this.SecondRuntimeEnabled)
      {
        parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-244066886 - -48452443 ^ -195834601), (object) mdImported.DisplayName, (object) mdImported.Uid)));
        return false;
      }
      bool flag = base.TestMetadata(mdImported, parameters, isTestRead);
      if (mdImported.ViewModelMetadata != null)
        EntityMetadataPublicationHandler.UpdateIncludeList((EntityMetadata) mdImported);
      string messageAdditionalInfo = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099465763), (object) mdImported.DisplayName, (object) mdImported.Uid);
      TestImportMessages message = MetadataImportHelper.ValidateEntityTableName((EntityMetadata) mdImported, mdImported.TableName, messageAdditionalInfo);
      if (message != null)
      {
        parameters.TestMessagesAdd(message);
        if (message.Type == TestImportMessagesType.Error)
          flag = false;
      }
      if (isTestRead && !this.ValidateForm((EntityMetadata) mdImported, parameters))
        flag = false;
      return flag;
    }

    /// <inheritdoc />
    protected override bool CheckNewProperty(
      PropertyMetadata propertyImported,
      EntityMetadata md,
      ReadMetadataParameters parameters)
    {
      return base.CheckNewProperty(propertyImported, md, parameters) & this.CheckRelationTableName(propertyImported, md, parameters);
    }

    /// <inheritdoc />
    protected override bool CheckNewTablePart(
      TablePartMetadata tablepartImported,
      EntityMetadata md,
      ReadMetadataParameters parameters)
    {
      return base.CheckNewTablePart(tablepartImported, md, parameters) & this.CheckTablePartTableName(tablepartImported, md, parameters);
    }

    private void MergeHierarchyProperties(
      EntityMetadata mdImported,
      EntityMetadata mdMerged,
      bool isTestRead,
      ReadMetadataParameters parameters)
    {
      int num1 = 29;
      while (true)
      {
        int num2 = num1;
        PropertyMetadata propertyMetadata1;
        PropertyMetadata propertyMetadata2;
        PropertyMetadata propertyMetadata3;
        PropertyMetadata propertyMetadata4;
        PropertyMetadata propertyMetadata5;
        PropertyMetadata propertyMetadata6;
        EntityMetadata mdImported1;
        EntityMetadata mdMerged1;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 3:
            case 14:
            case 18:
            case 32:
            case 34:
            case 35:
            case 61:
            case 63:
            case 74:
            case 79:
            case 93:
            case 96:
            case 98:
            case 102:
              if (!isTestRead)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 1 : 4;
                continue;
              }
              goto label_118;
            case 2:
              parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.InfoMetadata, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420542902), (object) mdMerged1.DisplayName, (object) mdMerged1.Name, (object) mdMerged1.Uid, (object) propertyMetadata5.DisplayName, (object) propertyMetadata5.Name, (object) propertyMetadata5.Uid, (object) propertyMetadata2.DisplayName, (object) propertyMetadata2.Name, (object) propertyMetadata2.Uid)));
              num2 = 74;
              continue;
            case 4:
              mdMerged1.Hierarchical = mdImported1.Hierarchical;
              num2 = 92;
              continue;
            case 5:
              if (mdMerged1.HierarchyType != HierarchyType.GroupAndElements)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 39 : 80;
                continue;
              }
              goto case 100;
            case 6:
              goto label_69;
            case 7:
              propertyMetadata6 = (PropertyMetadata) null;
              num2 = 70;
              continue;
            case 8:
              if (mdImported1.Hierarchical)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
                continue;
              }
              goto case 1;
            case 9:
            case 97:
              if (propertyMetadata2 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 10 : 5;
                continue;
              }
              goto case 89;
            case 10:
            case 23:
              if (propertyMetadata6 == null)
              {
                num2 = 35;
                continue;
              }
              goto case 101;
            case 11:
            case 41:
            case 52:
              if (!mdMerged1.Hierarchical)
              {
                num2 = 21;
                continue;
              }
              goto case 54;
            case 12:
              parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(322893104 - -1992822529 ^ -1979456715), (object) mdImported1.DisplayName, (object) mdImported1.Name, (object) mdImported1.Uid, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~210725948 ^ -210762763), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317621824))));
              num2 = 39;
              continue;
            case 13:
              if (propertyMetadata4 == null)
              {
                num2 = 105;
                continue;
              }
              goto case 66;
            case 15:
              mdMerged1.ParentPropertyUid = propertyMetadata1.Uid;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 95 : 12;
              continue;
            case 16:
            case 86:
              if (propertyMetadata6 == null)
              {
                num2 = 102;
                continue;
              }
              goto case 30;
            case 17:
              if (mdImported1.Hierarchical)
              {
                num2 = 26;
                continue;
              }
              goto case 49;
            case 19:
              if (isTestRead)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 1 : 0;
                continue;
              }
              goto case 27;
            case 20:
              propertyMetadata2 = mdMerged1.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p =>
              {
                int num3 = 1;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      if (!p.IsSystem)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
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
                return p.Uid == mdMerged1.IsGroupPropertyUid;
label_3:
                return false;
              }));
              num2 = 69;
              continue;
            case 21:
            case 43:
            case 45:
              if (!mdMerged1.Hierarchical)
              {
                num2 = 8;
                continue;
              }
              goto case 1;
            case 22:
            case 84:
              propertyMetadata2 = (PropertyMetadata) null;
              num2 = 7;
              continue;
            case 24:
              parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138642522), (object) mdMerged1.DisplayName, (object) mdMerged1.Name, (object) mdMerged1.Uid, (object) propertyMetadata3.DisplayName, (object) propertyMetadata3.Name, (object) propertyMetadata3.Uid)));
              num2 = 32;
              continue;
            case 25:
              propertyMetadata5 = mdMerged1.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p =>
              {
                int num4 = 2;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      goto label_5;
                    case 2:
                      if (!p.IsSystem)
                      {
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 1 : 1;
                        continue;
                      }
                      goto label_4;
                    default:
                      goto label_4;
                  }
                }
label_4:
                return p.Uid == mdMerged1.ParentPropertyUid;
label_5:
                return false;
              }));
              num2 = 84;
              continue;
            case 26:
              if (propertyMetadata1 == null)
              {
                num2 = 90;
                continue;
              }
              goto case 64;
            case 27:
              mdMerged1.Properties.Add(propertyMetadata4);
              num2 = 88;
              continue;
            case 28:
              mdImported1 = mdImported;
              num2 = 67;
              continue;
            case 29:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 28 : 20;
              continue;
            case 30:
              parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1113862659 ^ 1113637149), (object) mdMerged1.DisplayName, (object) mdMerged1.Name, (object) mdMerged1.Uid, (object) propertyMetadata6.DisplayName, (object) propertyMetadata6.Name, (object) propertyMetadata6.Uid)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 72 : 79;
              continue;
            case 31:
              if (propertyMetadata6 == null)
              {
                num2 = 51;
                continue;
              }
              goto case 56;
            case 33:
              if (propertyMetadata6 != null)
              {
                num2 = 9;
                continue;
              }
              goto case 19;
            case 36:
              goto label_125;
            case 37:
            case 47:
              if (propertyMetadata5 != null)
              {
                num2 = 75;
                continue;
              }
              goto case 103;
            case 38:
              mdMerged1.Properties.Add(propertyMetadata1);
              num2 = 15;
              continue;
            case 39:
              goto label_3;
            case 40:
              parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.InfoMetadata, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87049327), (object) mdMerged1.DisplayName, (object) mdMerged1.Name, (object) mdMerged1.Uid, (object) propertyMetadata2.DisplayName, (object) propertyMetadata2.Name, (object) propertyMetadata2.Uid)));
              num2 = 63;
              continue;
            case 42:
              if (mdImported1.HierarchyType == HierarchyType.GroupAndElements)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 28 : 53;
                continue;
              }
              goto case 1;
            case 44:
              List<PropertyMetadata> properties = mdMerged1.Properties;
              // ISSUE: reference to a compiler-generated field
              Func<PropertyMetadata, bool> func = EntityExecuteMetadataExtension<T>.\u003C\u003Ec.\u003C\u003E9__14_5;
              Func<PropertyMetadata, bool> predicate;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                EntityExecuteMetadataExtension<T>.\u003C\u003Ec.\u003C\u003E9__14_5 = predicate = (Func<PropertyMetadata, bool>) (p => p.Name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420920266));
              }
              else
                goto label_128;
label_127:
              propertyMetadata6 = properties.FirstOrDefault<PropertyMetadata>(predicate);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 46 : 9;
              continue;
label_128:
              predicate = func;
              goto label_127;
            case 46:
            case 69:
              if (!mdMerged1.Hierarchical)
              {
                num2 = 41;
                continue;
              }
              goto case 71;
            case 48:
              propertyMetadata3 = mdMerged1.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => p.Name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106488846)));
              num2 = 22;
              continue;
            case 49:
            case 87:
              propertyMetadata5 = (PropertyMetadata) null;
              num2 = 60;
              continue;
            case 50:
              if (propertyMetadata2 != null)
                goto case 94;
              else
                goto label_57;
            case 51:
              if (isTestRead)
                goto case 1;
              else
                goto label_23;
            case 53:
              if (propertyMetadata2 == null)
              {
                num2 = 33;
                continue;
              }
              goto case 9;
            case 54:
              if (!mdImported1.Hierarchical)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 45 : 24;
                continue;
              }
              goto case 5;
            case 55:
              propertyMetadata1 = mdImported1.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p =>
              {
                int num5 = 1;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      if (p.IsSystem)
                      {
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 0 : 0;
                        continue;
                      }
                      goto label_3;
                    default:
                      goto label_2;
                  }
                }
label_2:
                return p.Uid == mdImported1.ParentPropertyUid;
label_3:
                return false;
              }));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 59 : 15;
              continue;
            case 56:
            case 99:
              if (propertyMetadata2 == null)
              {
                num2 = 86;
                continue;
              }
              goto case 91;
            case 57:
              parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.InfoMetadata, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051802738 - -1831968059 ^ -1410976867), (object) mdMerged1.DisplayName, (object) mdMerged1.Name, (object) mdMerged1.Uid, (object) propertyMetadata5.DisplayName, (object) propertyMetadata5.Name, (object) propertyMetadata5.Uid)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 93 : 50;
              continue;
            case 58:
              if (propertyMetadata3 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 43 : 47;
                continue;
              }
              goto case 75;
            case 59:
              propertyMetadata4 = mdImported1.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p =>
              {
                int num6 = 1;
                while (true)
                {
                  switch (num6)
                  {
                    case 1:
                      if (p.IsSystem)
                      {
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
                        continue;
                      }
                      goto label_5;
                    default:
                      goto label_4;
                  }
                }
label_4:
                return p.Uid == mdImported1.IsGroupPropertyUid;
label_5:
                return false;
              }));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 79 : 82;
              continue;
            case 60:
              propertyMetadata3 = (PropertyMetadata) null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 68 : 46;
              continue;
            case 62:
              mdMerged1.HierarchyType = mdImported1.HierarchyType;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 84 : 85;
              continue;
            case 64:
              if (propertyMetadata1 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 53 : 66;
                continue;
              }
              goto case 104;
            case 65:
              parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146270597), (object) mdImported1.DisplayName, (object) mdImported1.Name, (object) mdImported1.Uid, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1120607109 - 305487170 ^ -1426122993))));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 6 : 3;
              continue;
            case 66:
              if (propertyMetadata1 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 49 : 5;
                continue;
              }
              goto case 65;
            case 67:
              mdMerged1 = mdMerged;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 15 : 55;
              continue;
            case 68:
              if (mdMerged1.ParentPropertyUid != Guid.Empty)
              {
                num2 = 25;
                continue;
              }
              goto case 48;
            case 70:
              if (mdMerged1.IsGroupPropertyUid != Guid.Empty)
              {
                num2 = 20;
                continue;
              }
              goto case 44;
            case 71:
              if (!mdImported1.Hierarchical)
                goto case 50;
              else
                goto label_116;
            case 72:
              mdMerged1.Properties.Add(propertyMetadata4);
              num2 = 78;
              continue;
            case 73:
              if (propertyMetadata4 != null)
              {
                num2 = 64;
                continue;
              }
              goto case 12;
            case 75:
              if (propertyMetadata5 == null)
              {
                num2 = 76;
                continue;
              }
              goto case 95;
            case 76:
              if (!isTestRead)
              {
                num2 = 38;
                continue;
              }
              goto case 95;
            case 77:
              if (propertyMetadata2 != null)
              {
                num2 = 99;
                continue;
              }
              goto case 31;
            case 78:
              mdMerged1.IsGroupPropertyUid = propertyMetadata4.Uid;
              num2 = 3;
              continue;
            case 80:
            case 83:
              if (mdMerged1.HierarchyType == HierarchyType.Elements)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 23 : 42;
                continue;
              }
              goto case 1;
            case 81:
              parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.InfoMetadata, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1149433385 + 173655049 ^ 1322800766), (object) mdMerged1.DisplayName, (object) mdMerged1.Name, (object) mdMerged1.Uid, (object) propertyMetadata2.DisplayName, (object) propertyMetadata2.Name, (object) propertyMetadata2.Uid)));
              num2 = 96;
              continue;
            case 82:
              if (isTestRead)
                goto case 17;
              else
                goto label_78;
            case 85:
              goto label_49;
            case 88:
              mdMerged1.IsGroupPropertyUid = propertyMetadata4.Uid;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 98 : 77;
              continue;
            case 89:
              parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.InfoMetadata, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1255365154 ^ 596875508 ^ -1766076300), (object) mdMerged1.DisplayName, (object) mdMerged1.Name, (object) mdMerged1.Uid, (object) propertyMetadata2.DisplayName, (object) propertyMetadata2.Name, (object) propertyMetadata2.Uid)));
              num2 = 18;
              continue;
            case 90:
              if (mdImported1.HierarchyType == HierarchyType.GroupAndElements)
              {
                num2 = 73;
                continue;
              }
              goto case 64;
            case 91:
              if (propertyMetadata5 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 26 : 40;
                continue;
              }
              goto case 2;
            case 92:
              if (mdImported1.Hierarchical)
              {
                num2 = 62;
                continue;
              }
              goto label_111;
            case 94:
              parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.InfoMetadata, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487099058), (object) mdMerged1.DisplayName, (object) mdMerged1.Name, (object) mdMerged1.Uid, (object) propertyMetadata5.DisplayName, (object) propertyMetadata5.Name, (object) propertyMetadata5.Uid, (object) propertyMetadata2.DisplayName, (object) propertyMetadata2.Name, (object) propertyMetadata2.Uid)));
              num2 = 61;
              continue;
            case 95:
              if (mdImported1.HierarchyType != HierarchyType.GroupAndElements)
              {
                num2 = 34;
                continue;
              }
              goto case 77;
            case 100:
              if (mdImported1.HierarchyType == HierarchyType.Elements)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 81 : 30;
                continue;
              }
              goto case 80;
            case 101:
              parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16469971), (object) mdMerged1.DisplayName, (object) mdMerged1.Name, (object) mdMerged1.Uid, (object) propertyMetadata6.DisplayName, (object) propertyMetadata6.Name, (object) propertyMetadata6.Uid)));
              num2 = 14;
              continue;
            case 103:
              if (propertyMetadata3 != null)
              {
                num2 = 24;
                continue;
              }
              goto case 1;
            case 104:
              if (mdImported1.HierarchyType == HierarchyType.GroupAndElements)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 13 : 5;
                continue;
              }
              goto case 66;
            case 105:
              parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710335748), (object) mdImported1.DisplayName, (object) mdImported1.Name, (object) mdImported1.Uid, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(572119659 - -337058038 ^ 909262961))));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 36 : 35;
              continue;
            default:
              if (propertyMetadata5 != null)
              {
                num2 = 37;
                continue;
              }
              goto case 58;
          }
        }
label_23:
        num1 = 72;
        continue;
label_57:
        num1 = 57;
        continue;
label_78:
        num1 = 87;
        continue;
label_116:
        num1 = 11;
      }
label_69:
      return;
label_125:
      return;
label_3:
      return;
label_49:
      return;
label_118:
      return;
label_111:;
    }

    private bool ValidateForm(EntityMetadata entityMetadata, ReadMetadataParameters parameters)
    {
      int num1 = 5;
      List<FormViewItem>.Enumerator enumerator1;
      bool flag;
      while (true)
      {
        DataClassMetadata dataClassMetadata;
        switch (num1)
        {
          case 1:
            dataClassMetadata = entityMetadata.ViewModelMetadata;
            break;
          case 2:
label_41:
            enumerator1 = entityMetadata.Forms.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 0 : 0;
            continue;
          case 3:
            dataClassMetadata = (DataClassMetadata) null;
            break;
          case 4:
            if (entityMetadata != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 1 : 1;
              continue;
            }
            goto case 3;
          case 5:
            flag = true;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 3 : 4;
            continue;
          case 6:
          case 7:
            goto label_40;
          default:
            goto label_2;
        }
        if (dataClassMetadata == null)
          num1 = 7;
        else
          goto label_41;
      }
label_2:
      try
      {
label_5:
        if (enumerator1.MoveNext())
          goto label_7;
        else
          goto label_6;
label_4:
        FormViewItem current1;
        int num2;
        switch (num2)
        {
          case 1:
            goto label_7;
          case 2:
            goto label_5;
          case 3:
            try
            {
              IEnumerator<ValidationError> enumerator2 = CheckComponentHelper.CheckComponentViewItems(current1, entityMetadata.ViewModelMetadata.Uid, entityMetadata).GetEnumerator();
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
                num3 = 0;
              switch (num3)
              {
                case 1:
                  goto label_5;
                default:
                  try
                  {
label_18:
                    if (enumerator2.MoveNext())
                      goto label_15;
                    else
                      goto label_19;
label_14:
                    ValidationError current2;
                    int num4;
                    while (true)
                    {
                      switch (num4)
                      {
                        case 1:
                          parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, current2.Message));
                          num4 = 4;
                          continue;
                        case 2:
                          goto label_5;
                        case 3:
                          goto label_15;
                        case 4:
                          flag = false;
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
                          continue;
                        default:
                          goto label_18;
                      }
                    }
label_15:
                    current2 = enumerator2.Current;
                    num4 = 1;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
                    {
                      num4 = 1;
                      goto label_14;
                    }
                    else
                      goto label_14;
label_19:
                    num4 = 2;
                    goto label_14;
                  }
                  finally
                  {
                    int num5;
                    if (enumerator2 == null)
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 2;
                    else
                      goto label_24;
label_23:
                    switch (num5)
                    {
                      case 1:
                      case 2:
                    }
label_24:
                    enumerator2.Dispose();
                    num5 = 1;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
                    {
                      num5 = 0;
                      goto label_23;
                    }
                    else
                      goto label_23;
                  }
              }
            }
            catch (Exception ex)
            {
              int num6 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
                num6 = 1;
              while (true)
              {
                switch (num6)
                {
                  case 1:
                    parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, ex.Message));
                    num6 = 2;
                    continue;
                  case 2:
                    flag = false;
                    num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_5;
                }
              }
            }
          default:
            goto label_40;
        }
label_6:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 0;
        goto label_4;
label_7:
        current1 = enumerator1.Current;
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
        {
          num2 = 3;
          goto label_4;
        }
        else
          goto label_4;
      }
      finally
      {
        enumerator1.Dispose();
        int num7 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
          num7 = 0;
        switch (num7)
        {
          default:
        }
      }
label_40:
      return flag;
    }

    private void MergeMetadataActions(EntityMetadata mdImported, EntityMetadata mdMerged)
    {
      int num1 = 2;
      EntityActionsMetadata actions1;
      EntityActionsMetadata actions2;
      List<EnumValueMetadata>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (actions1 != null)
            {
              num1 = 11;
              continue;
            }
            goto label_26;
          case 2:
            actions1 = mdImported.Actions;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_38;
          case 4:
            if (actions2.Values.Count != 0)
            {
              num1 = 7;
              continue;
            }
            goto case 10;
          case 5:
            goto label_13;
          case 6:
            if (actions2 != null)
            {
              num1 = 4;
              continue;
            }
            goto case 10;
          case 7:
            enumerator = actions1.Values.GetEnumerator();
            num1 = 8;
            continue;
          case 8:
            goto label_15;
          case 9:
            goto label_2;
          case 10:
            mdMerged.Actions = actions1;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 5 : 1;
            continue;
          case 11:
            if (actions1.Values.Count != 0)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
              continue;
            }
            goto label_32;
          default:
            actions2 = mdMerged.Actions;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 6 : 2;
            continue;
        }
      }
label_38:
      return;
label_13:
      return;
label_2:
      return;
label_32:
      return;
label_26:
      return;
label_15:
      try
      {
label_18:
        if (enumerator.MoveNext())
          goto label_29;
        else
          goto label_19;
label_16:
        EnumValueMetadata enumValueMetadata;
        int index;
        int num2;
        EnumValueMetadata importedAction;
        while (true)
        {
          switch (num2)
          {
            case 1:
              index = actions2.Values.IndexOf(enumValueMetadata);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 10 : 8;
              continue;
            case 2:
            case 5:
              if (enumValueMetadata != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 1 : 1;
                continue;
              }
              goto case 3;
            case 3:
              actions2.Values.Add(importedAction);
              num2 = 12;
              continue;
            case 4:
              importedAction = enumerator.Current;
              num2 = 6;
              continue;
            case 6:
              enumValueMetadata = actions2.Values.FirstOrDefault<EnumValueMetadata>((Func<EnumValueMetadata, bool>) (v => v.Uid == importedAction.Uid));
              num2 = 9;
              continue;
            case 7:
            case 12:
              goto label_18;
            case 8:
              goto label_36;
            case 9:
              if (enumValueMetadata != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 2 : 0;
                continue;
              }
              goto case 13;
            case 10:
              actions2.Values.Insert(index, importedAction);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 0 : 0;
              continue;
            case 11:
              goto label_29;
            case 13:
              enumValueMetadata = actions2.Values.FirstOrDefault<EnumValueMetadata>((Func<EnumValueMetadata, bool>) (v => v.Name == importedAction.Name));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 5 : 0;
              continue;
            default:
              actions2.Values.Remove(enumValueMetadata);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 6 : 7;
              continue;
          }
        }
label_36:
        return;
label_19:
        num2 = 8;
        goto label_16;
label_29:
        num2 = 4;
        goto label_16;
      }
      finally
      {
        enumerator.Dispose();
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
    }

    private void MergeMetadataFilter(EntityMetadata mdImported, EntityMetadata mdMerged)
    {
      int num1 = 18;
      while (true)
      {
        EntityFilterMetadata filter1;
        int index1;
        EntityFilterMetadata filter2;
        List<PropertyMetadata> list;
        List<PropertyMetadata>.Enumerator enumerator;
        switch (num1)
        {
          case 1:
            goto label_46;
          case 2:
            if (filter2.Properties.Count != 0)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 9 : 1;
              continue;
            }
            goto label_35;
          case 3:
            if (filter1.Properties.Count != 0)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 19 : 5;
              continue;
            }
            goto case 4;
          case 4:
            mdMerged.Filter = filter2;
            num1 = 14;
            continue;
          case 5:
            try
            {
label_22:
              if (enumerator.MoveNext())
                goto label_28;
              else
                goto label_23;
label_19:
              PropertyMetadata propertyMetadata;
              int index2;
              int num2;
              PropertyMetadata importedProp;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_28;
                  case 2:
                    index2 = list.IndexOf(propertyMetadata);
                    num2 = 8;
                    continue;
                  case 3:
                  case 7:
                    if (propertyMetadata != null)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 2 : 0;
                      continue;
                    }
                    goto case 5;
                  case 4:
                  case 10:
                    goto label_22;
                  case 5:
                    list.Add(importedProp);
                    num2 = 4;
                    continue;
                  case 6:
                    importedProp = enumerator.Current;
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
                    continue;
                  case 8:
                    list.Insert(index2, importedProp);
                    num2 = 11;
                    continue;
                  case 9:
                    propertyMetadata = list.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (v => v.Name == importedProp.Name));
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 3 : 2;
                    continue;
                  case 11:
                    list.Remove(propertyMetadata);
                    num2 = 10;
                    continue;
                  case 12:
                    if (propertyMetadata != null)
                    {
                      num2 = 7;
                      continue;
                    }
                    goto case 9;
                  case 13:
                    goto label_4;
                  default:
                    propertyMetadata = list.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (v => v.Uid == importedProp.Uid));
                    num2 = 12;
                    continue;
                }
              }
label_23:
              num2 = 13;
              goto label_19;
label_28:
              num2 = 6;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
              {
                num2 = 3;
                goto label_19;
              }
              else
                goto label_19;
            }
            finally
            {
              enumerator.Dispose();
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0)
                num3 = 0;
              switch (num3)
              {
                default:
              }
            }
          case 6:
          case 13:
            list[index1].Order = index1;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 11 : 11;
            continue;
          case 7:
          case 10:
            if (index1 < list.Count)
            {
              num1 = 6;
              continue;
            }
            goto case 15;
          case 8:
            enumerator = filter2.Properties.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 5 : 2;
            continue;
          case 9:
            filter1 = mdMerged.Filter;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 12 : 4;
            continue;
          case 11:
            ++index1;
            num1 = 7;
            continue;
          case 12:
            if (filter1 != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 3 : 3;
              continue;
            }
            goto case 4;
          case 14:
            goto label_17;
          case 15:
            filter1.Properties = list;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 16 : 9;
            continue;
          case 16:
            goto label_12;
          case 17:
            if (filter2 != null)
            {
              num1 = 2;
              continue;
            }
            goto label_39;
          case 18:
            filter2 = mdImported.Filter;
            num1 = 17;
            continue;
          case 19:
            List<PropertyMetadata> properties = filter1.Properties;
            // ISSUE: reference to a compiler-generated field
            Func<PropertyMetadata, int> func = EntityExecuteMetadataExtension<T>.\u003C\u003Ec.\u003C\u003E9__17_0;
            Func<PropertyMetadata, int> keySelector;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              EntityExecuteMetadataExtension<T>.\u003C\u003Ec.\u003C\u003E9__17_0 = keySelector = (Func<PropertyMetadata, int>) (p => p.Order);
            }
            else
              goto label_49;
label_48:
            list = properties.OrderBy<PropertyMetadata, int>(keySelector).ToList<PropertyMetadata>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 8 : 4;
            continue;
label_49:
            keySelector = func;
            goto label_48;
        }
label_4:
        index1 = 0;
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 10 : 3;
      }
label_46:
      return;
label_17:
      return;
label_12:
      return;
label_39:
      return;
label_35:;
    }

    private bool CheckRelationTableName(
      PropertyMetadata propertyImported,
      EntityMetadata md,
      ReadMetadataParameters parameters)
    {
      int num1 = 15;
      bool flag;
      while (true)
      {
        int num2 = num1;
        string messageAdditionalInfo;
        TestImportMessages message;
        string str;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 33:
              if (!(settings.ChildColumnName == settings.ParentColumnName))
              {
                num2 = 30;
                continue;
              }
              goto case 4;
            case 2:
              if (message == null)
              {
                num2 = 25;
                continue;
              }
              goto case 7;
            case 3:
              parameters.TestMessagesAdd(message);
              num2 = 10;
              continue;
            case 4:
              parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(322893104 - -1992822529 ^ -1979452523))));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 27 : 9;
              continue;
            case 5:
              flag = true;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 4 : 33;
              continue;
            case 6:
              flag = true;
              num2 = 22;
              continue;
            case 7:
              parameters.TestMessagesAdd(message);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 21 : 13;
              continue;
            case 8:
              message = MetadataImportHelper.ValidateTableName(propertyImported.Uid, settings.RelationTableName, messageAdditionalInfo: messageAdditionalInfo);
              num2 = 2;
              continue;
            case 9:
              str = MetadataImportHelper.NewRelationTableName(settings.RelationTableName, propertyImported.Uid, settings);
              num2 = 11;
              continue;
            case 10:
              if (message.Type != TestImportMessagesType.Error)
                goto case 1;
              else
                goto label_15;
            case 11:
              if (string.IsNullOrWhiteSpace(str))
              {
                num2 = 12;
                continue;
              }
              goto case 34;
            case 12:
              parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -489114077), (object) propertyImported.Uid, (object) md.DisplayName, (object) str, (object) propertyImported.DisplayName, (object) propertyImported.Name, (object) md.Name, (object) md.Uid)));
              num2 = 19;
              continue;
            case 13:
              messageAdditionalInfo = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(825385222 ^ 825660498), (object) propertyImported.Uid, (object) md.DisplayName, (object) propertyImported.DisplayName, (object) propertyImported.Name, (object) md.Name, (object) md.Uid);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 2 : 8;
              continue;
            case 14:
              if (propertyImported.Settings is EntitySettings settings)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 31;
                continue;
              }
              goto label_3;
            case 15:
              flag = false;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 14 : 14;
              continue;
            case 16:
            case 30:
              goto label_3;
            case 17:
            case 25:
            case 29:
              goto label_20;
            case 18:
              if (message == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 1 : 1;
                continue;
              }
              goto case 3;
            case 19:
              flag = true;
              num2 = 17;
              continue;
            case 21:
              if (message.Type == TestImportMessagesType.Error)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 4 : 6;
                continue;
              }
              goto case 22;
            case 22:
              if (message.Type == TestImportMessagesType.InfoMetadata)
              {
                num2 = 9;
                continue;
              }
              goto label_20;
            case 23:
              settings.RelationTableName = str;
              num2 = 29;
              continue;
            case 24:
              if (message.Type == TestImportMessagesType.Error)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 32 : 31;
                continue;
              }
              goto label_26;
            case 26:
              parameters.TestMessagesAdd(message);
              num2 = 24;
              continue;
            case 27:
              flag = true;
              num2 = 16;
              continue;
            case 28:
              if (message == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 0 : 0;
                continue;
              }
              goto case 26;
            case 31:
              if (settings.RelationType == RelationType.ManyToMany)
              {
                num2 = 13;
                continue;
              }
              goto label_3;
            case 32:
              flag = true;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 20 : 17;
              continue;
            case 34:
              parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.InfoMetadata, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(825385222 ^ 825661386), (object) propertyImported.Uid, (object) md.DisplayName, (object) str, (object) propertyImported.DisplayName, (object) propertyImported.Name, (object) md.Name, (object) md.Uid)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 20 : 23;
              continue;
            default:
              goto label_26;
          }
        }
label_15:
        num1 = 5;
        continue;
label_20:
        message = MetadataImportHelper.ValidateFieldName(settings.ChildColumnName);
        num1 = 28;
        continue;
label_26:
        message = MetadataImportHelper.ValidateFieldName(settings.ParentColumnName);
        num1 = 18;
      }
label_3:
      return !flag;
    }

    private bool CheckTablePartTableName(
      TablePartMetadata tablepartImported,
      EntityMetadata md,
      ReadMetadataParameters parameters)
    {
      int num = 3;
      string messageAdditionalInfo;
      TestImportMessages message;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (message.Type == TestImportMessagesType.Error)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          case 2:
            message = MetadataImportHelper.ValidateTableName(tablepartImported.Uid, tablepartImported.TableName, tablepartImported.Uid, messageAdditionalInfo);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 5 : 5;
            continue;
          case 3:
            messageAdditionalInfo = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099470203), (object) tablepartImported.Uid, (object) md.DisplayName, (object) tablepartImported.DisplayName, (object) tablepartImported.Name, (object) md.Name, (object) md.Uid);
            num = 2;
            continue;
          case 4:
            parameters.TestMessagesAdd(message);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 1 : 1;
            continue;
          case 5:
            if (message != null)
            {
              num = 4;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return false;
label_3:
      return true;
    }

    /// <summary>Включен ли второй рантайм</summary>
    private bool SecondRuntimeEnabled => this.featureFlagService.Enabled(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1033719030 - 2012070891 ^ -978376959), false);

    static EntityExecuteMetadataExtension()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            EntityExecuteMetadataExtension<T>.ImportLog = Logger.GetLogger(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -35765747));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 2 : 1;
            continue;
        }
      }
label_2:;
    }

    internal static bool AZm93pElD1Wmt492ckAt() => EntityExecuteMetadataExtension<T>.zP62mlElabJ14TiWKq2S == null;

    internal static object KDdwucEltLiVLSwJsBIx() => EntityExecuteMetadataExtension<T>.zP62mlElabJ14TiWKq2S;
  }
}
