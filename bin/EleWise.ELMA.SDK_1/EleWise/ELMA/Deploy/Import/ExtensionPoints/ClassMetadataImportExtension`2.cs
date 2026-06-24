// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.ExtensionPoints.ClassMetadataImportExtension`2
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Deploy.Import.Helpers;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints
{
  /// <summary>
  /// Точка расширения для обработки ClassMetadata при импорте конфигурации
  /// </summary>
  /// <typeparam name="T">Тип метаданных, является наследником <typeparamref name="TBase" /></typeparam>
  /// <typeparam name="TBase">Тип базовых метданных для получения свойств</typeparam>
  public abstract class ClassMetadataImportExtension<T, TBase> : NamedMetadataImportExtension<T>
    where T : TBase
    where TBase : ClassMetadata
  {
    private static object hdKKaJElQ42erooRNAK9;

    /// <summary>
    /// Уникальный идентификатор для типов наследников IEntityMetadata
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public IEnumerable<IInheriteEntityMetadataGuid> InheriteEntityMetadataGuids { private get; set; }

    /// <summary>
    /// Точки расширения обработки свойств метаданных при импорте
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public IEnumerable<IExecuteMetadataPropertyExtension> PropertyMetadataImports { private get; set; }

    /// <inheritdoc />
    protected override bool TestMetadata(
      T mdMerged,
      ReadMetadataParameters parameters,
      bool isTestRead)
    {
      bool flag = base.TestMetadata(mdMerged, parameters, isTestRead);
      if (mdMerged.BaseClassUid != Guid.Empty && this.MetadataService.GetMetadataList().All<IMetadata>((Func<IMetadata, bool>) (md => md.Uid != mdMerged.BaseClassUid)))
      {
        parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099476725), (object) mdMerged.Uid, (object) mdMerged.Name, (object) mdMerged.DisplayName, (object) mdMerged.BaseClassUid)));
        flag = false;
      }
      if (flag)
        this.CheckMetadataProperties((TBase) mdMerged, isTestRead, parameters);
      return flag;
    }

    /// <summary>Мерж метаданных</summary>
    /// <param name="mdImported">Метаданные</param>
    /// <param name="mdDraft">Черновик</param>
    /// <param name="isTestRead">Тестовое чтение</param>
    /// <param name="parameters">Параметры импорта</param>
    protected override void MergeMetadata(
      T mdImported,
      T mdDraft,
      bool isTestRead,
      ReadMetadataParameters parameters)
    {
      base.MergeMetadata(mdImported, mdDraft, isTestRead, parameters);
      this.MergeMetadataProperties((TBase) mdImported, (TBase) mdDraft, parameters);
      if (isTestRead)
        return;
      if (mdImported.AllowCreateHeirs)
        mdDraft.AllowCreateHeirs = true;
      if (mdImported.ImplementedInterfaces != null)
      {
        if (mdDraft.ImplementedInterfaces == null)
          mdDraft.ImplementedInterfaces = mdImported.ImplementedInterfaces;
        else
          mdDraft.ImplementedInterfaces = mdDraft.ImplementedInterfaces.Union<string>((IEnumerable<string>) mdImported.ImplementedInterfaces).Distinct<string>().ToList<string>();
      }
      mdDraft.ShowInDesigner = mdImported.ShowInDesigner;
      mdDraft.ShowInTypeTree = mdImported.ShowInTypeTree;
      if (mdImported.TitlePropertyUid != Guid.Empty)
        mdDraft.TitlePropertyUid = mdImported.TitlePropertyUid;
      if (!string.IsNullOrEmpty(mdImported.XmlComments))
        mdDraft.XmlComments = mdImported.XmlComments;
      this.MergeMetadataForms((ClassMetadata) mdImported, (ClassMetadata) mdDraft, parameters);
      if (!string.IsNullOrEmpty(mdImported.ScriptModuleTypeName))
        mdDraft.ScriptModuleTypeName = mdImported.ScriptModuleTypeName;
      mdDraft.OnViewLoadScriptName = mdImported.OnViewLoadScriptName;
    }

    /// <summary>Мерж свойств метаданных</summary>
    /// <param name="mdImported">Метаданные</param>
    /// <param name="mdDraft">Черновик</param>
    /// <param name="parameters">Параметры импорта</param>
    protected virtual void MergeMetadataProperties(
      TBase mdImported,
      TBase mdDraft,
      ReadMetadataParameters parameters)
    {
      List<PropertyMetadata> list = mdDraft.Properties.ToList<PropertyMetadata>();
      foreach (PropertyMetadata propertyMetadata in list.Where<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => p.IsSystem)))
      {
        PropertyMetadata propertyImported = propertyMetadata;
        if (propertyImported.TypeUid == EntityDescriptor.UID || this.InheriteEntityMetadataGuids.Any<IInheriteEntityMetadataGuid>((Func<IInheriteEntityMetadataGuid, bool>) (e => propertyImported.TypeUid == e.Uid)))
          propertyImported.SubTypeUid = parameters.MergeReplace.GetUidReplaceMD(propertyImported.SubTypeUid);
      }
      foreach (PropertyMetadata propertyMetadata in mdImported.Properties.Where<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => !p.IsSystem)))
      {
        PropertyMetadata propertyImported = propertyMetadata;
        PropertyMetadata propertyBase;
        try
        {
          propertyBase = list.SingleOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => p.Uid == propertyImported.Uid));
        }
        catch (InvalidOperationException ex)
        {
          parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051802738 - -1831968059 ^ -1410987795), (object) mdDraft.Name, (object) propertyImported.Uid)));
          continue;
        }
        if (propertyBase != null && propertyImported.Name != propertyBase.Name)
          parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.InfoMetadata, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1380439818 << 3 ^ 1841665548), (object) mdDraft.Name, (object) propertyImported.Uid, (object) propertyBase.Uid, (object) mdDraft.DisplayName, (object) propertyImported.DisplayName, (object) propertyBase.DisplayName, (object) propertyImported.Name, (object) propertyBase.Name)));
        if (propertyBase == null)
        {
          try
          {
            propertyBase = list.SingleOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p =>
            {
              int num = 4;
              while (true)
              {
                switch (num)
                {
                  case 1:
                    goto label_5;
                  case 2:
                    goto label_4;
                  case 3:
                    if (!(p.Name == propertyImported.Name))
                    {
                      num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 1 : 1;
                      continue;
                    }
                    break;
                  case 4:
                    if (!p.IsSystem)
                    {
                      num = 3;
                      continue;
                    }
                    goto label_5;
                }
                if (p.TypeUid == propertyImported.TypeUid)
                  num = 2;
                else
                  goto label_5;
              }
label_4:
              return p.SubTypeUid == propertyImported.SubTypeUid;
label_5:
              return false;
            }));
          }
          catch (InvalidOperationException ex)
          {
            continue;
          }
          if (propertyBase != null)
            parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.InfoMetadata, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951199654), (object) mdDraft.Name, (object) propertyImported.Uid, (object) propertyBase.Uid, (object) mdDraft.DisplayName, (object) propertyImported.DisplayName, (object) propertyBase.DisplayName, (object) propertyImported.Name, (object) propertyBase.Name)));
        }
        if (propertyBase != null)
        {
          if (this.MergePropertySettings(propertyImported, propertyBase, mdDraft, parameters))
          {
            this.PropertyMetadataImports.ForEach<IExecuteMetadataPropertyExtension>((Action<IExecuteMetadataPropertyExtension>) (component =>
            {
              int num = 1;
              while (true)
              {
                switch (num)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    component.MetadataPropertyProcessing((IPropertyMetadata) propertyImported, (IPropertyMetadata) propertyBase, (ClassMetadata) mdImported, parameters);
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            parameters.MergeReplace.SetUidReplaceProperty(mdImported.Uid, propertyImported.Uid, propertyBase.Uid);
            parameters.MergeReplace.SetNameReplaceProperty(mdImported.Uid, propertyImported.Name, propertyBase.Name);
            propertyImported.Uid = propertyBase.Uid;
            list.Remove(propertyBase);
            list.Add(propertyImported);
          }
        }
        else
        {
          this.PropertyMetadataImports.ForEach<IExecuteMetadataPropertyExtension>((Action<IExecuteMetadataPropertyExtension>) (component =>
          {
            int num = 1;
            while (true)
            {
              switch (num)
              {
                case 0:
                  goto label_2;
                case 1:
                  component.MetadataPropertyProcessing((IPropertyMetadata) propertyImported, (IPropertyMetadata) null, (ClassMetadata) mdImported, parameters);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
                  continue;
                default:
                  goto label_4;
              }
            }
label_2:
            return;
label_4:;
          }));
          if (this.CheckNewProperty(propertyImported, mdDraft, parameters))
          {
            if (propertyImported.TypeUid == EntityDescriptor.UID || this.InheriteEntityMetadataGuids.Any<IInheriteEntityMetadataGuid>((Func<IInheriteEntityMetadataGuid, bool>) (e => propertyImported.TypeUid == e.Uid)))
              propertyImported.SubTypeUid = parameters.MergeReplace.GetUidReplaceMD(propertyImported.SubTypeUid);
            list.Add(propertyImported);
          }
        }
      }
      mdDraft.Properties = list;
    }

    /// <summary>Мерж настроек свойства</summary>
    /// <param name="propertyImported">Метаданные импортируемого свойства</param>
    /// <param name="propertyBase">Метаданные базового свойства</param>
    /// <param name="mdDraft">Черновик</param>
    /// <param name="parameters">Параметры импорта</param>
    protected virtual bool MergePropertySettings(
      PropertyMetadata propertyImported,
      PropertyMetadata propertyBase,
      TBase mdDraft,
      ReadMetadataParameters parameters)
    {
      if (!(propertyBase.TypeUid == propertyImported.TypeUid) || !(propertyBase.SubTypeUid == propertyImported.SubTypeUid))
      {
        parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088087690), (object) mdDraft.DisplayName, (object) propertyImported.Uid, (object) propertyBase.Uid, (object) mdDraft.Name, (object) propertyImported.DisplayName, (object) propertyBase.DisplayName)));
        return false;
      }
      EntitySettings settings1 = propertyImported.Settings as EntitySettings;
      EntitySettings settings2 = propertyBase.Settings as EntitySettings;
      if ((propertyBase.TypeUid == EntityDescriptor.UID || this.InheriteEntityMetadataGuids.Any<IInheriteEntityMetadataGuid>((Func<IInheriteEntityMetadataGuid, bool>) (e => propertyBase.TypeUid == e.Uid))) && (settings2 != null && settings1 != null && settings2.RelationType != settings1.RelationType || settings2 == null && settings1 != null || settings1 == null && settings2 != null))
      {
        parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1304605005 ^ 1304847075), (object) mdDraft.DisplayName, (object) propertyImported.Uid, (object) propertyBase.Uid, (object) mdDraft.Name, (object) propertyImported.DisplayName, (object) propertyBase.DisplayName)));
        return false;
      }
      if (propertyImported.Settings is PropertySettings settings3)
      {
        Guid uidReplaceProperty = parameters.MergeReplace.GetUidReplaceProperty(propertyImported.SubTypeUid, settings3.EntityTypeUid);
        ClassMetadata classMetadata;
        try
        {
          classMetadata = MetadataServiceContext.Service.GetMetadata(uidReplaceProperty) as ClassMetadata;
        }
        catch (TypeNotFoundException ex)
        {
          classMetadata = (ClassMetadata) null;
          parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1819636893 << 3 ^ 1672441902), (object) mdDraft.DisplayName, (object) propertyImported.Uid, (object) propertyBase.Uid, (object) mdDraft.Name, (object) propertyImported.DisplayName, (object) propertyBase.DisplayName, (object) uidReplaceProperty)));
        }
        Guid propertyUid = parameters.MergeReplace.GetUidReplaceProperty(propertyImported.SubTypeUid, settings3.PropertyUid);
        int num = classMetadata != null ? (classMetadata.Properties.All<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => p.Uid != propertyUid)) ? 1 : 0) : 1;
      }
      if ((propertyImported.TypeUid == EntityDescriptor.UID || this.InheriteEntityMetadataGuids.Any<IInheriteEntityMetadataGuid>((Func<IInheriteEntityMetadataGuid, bool>) (e => propertyImported.TypeUid == e.Uid))) && settings1 != null && settings2 != null && settings1.RelationType == RelationType.OneToMany)
        settings1.KeyColumnUid = parameters.MergeReplace.GetUidReplaceProperty(mdDraft.Uid, settings2.KeyColumnUid);
      if (propertyImported.TypeUid == EntityDescriptor.UID && settings1 != null && settings2 != null && settings1.HierarchyParentUid != Guid.Empty)
        settings1.HierarchyParentUid = parameters.MergeReplace.GetUidReplaceProperty(mdDraft.Uid, settings2.HierarchyParentUid);
      if ((propertyImported.TypeUid == EntityDescriptor.UID || this.InheriteEntityMetadataGuids.Any<IInheriteEntityMetadataGuid>((Func<IInheriteEntityMetadataGuid, bool>) (e => propertyImported.TypeUid == e.Uid))) && settings1 != null && settings2 != null && settings1.RelationType == RelationType.ManyToMany)
        settings1.RelationTableName = settings2.RelationTableName;
      return true;
    }

    /// <summary>Проверка свойства</summary>
    /// <param name="mdImported">Метаданные</param>
    /// <param name="isTestRead">Тестовое чтение</param>
    /// <param name="parameters">Параметры импорта</param>
    protected virtual void CheckMetadataProperties(
      TBase mdImported,
      bool isTestRead,
      ReadMetadataParameters parameters)
    {
      if ((object) mdImported == null)
        return;
      foreach (PropertyMetadata propertyMetadata in mdImported.Properties.ToArray())
      {
        PropertyMetadata propertyImported = propertyMetadata;
        int num1 = this.CheckNewProperty(propertyImported, mdImported, parameters) ? 1 : 0;
        if (num1 == 0 && !isTestRead)
          mdImported.Properties.Remove(propertyImported);
        if (num1 != 0 && !isTestRead && propertyImported != null && (propertyImported.TypeUid == EntityDescriptor.UID || this.InheriteEntityMetadataGuids.Any<IInheriteEntityMetadataGuid>((Func<IInheriteEntityMetadataGuid, bool>) (e => propertyImported.TypeUid == e.Uid))))
          propertyImported.SubTypeUid = parameters.MergeReplace.GetUidReplaceMD(propertyImported.SubTypeUid);
        this.PropertyMetadataImports.ForEach<IExecuteMetadataPropertyExtension>((Action<IExecuteMetadataPropertyExtension>) (component =>
        {
          int num2 = 1;
          while (true)
          {
            switch (num2)
            {
              case 0:
                goto label_2;
              case 1:
                component.MetadataPropertyProcessing((IPropertyMetadata) propertyImported, (IPropertyMetadata) null, (ClassMetadata) mdImported, parameters);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }));
      }
    }

    /// <summary>Проверка метаданных</summary>
    /// <param name="mdImported">Метаданные</param>
    /// <param name="mdDraft">Черновик</param>
    /// <param name="parameters">Параметры импорта</param>
    protected override bool CheckMetadata(
      T mdImported,
      T mdDraft,
      ReadMetadataParameters parameters)
    {
      bool flag = base.CheckMetadata(mdImported, mdDraft, parameters);
      if (mdDraft.Namespace != mdImported.Namespace)
      {
        parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-342626196 - 1290888215 ^ -1633265191), (object) mdImported.DisplayName, (object) mdImported.Uid, (object) mdDraft.DisplayName, (object) mdImported.Namespace, (object) mdDraft.Namespace, (object) mdDraft.Uid)));
        flag = false;
      }
      if (mdDraft.BaseClassUid != mdImported.BaseClassUid)
      {
        parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1839087379 - 334718690 ^ 2120912125), (object) mdImported.DisplayName, (object) mdImported.Uid, (object) mdDraft.DisplayName, (object) mdDraft.Uid)));
        flag = false;
      }
      return flag;
    }

    /// <summary>Проверка на возможность добавления нового свойства</summary>
    /// <param name="propertyImported">Метаданные свойства</param>
    /// <param name="md">Метаданные</param>
    /// <param name="parameters">Параметры импорта</param>
    protected virtual bool CheckNewProperty(
      PropertyMetadata propertyImported,
      TBase md,
      ReadMetadataParameters parameters)
    {
      string message = "";
      bool flag = true;
      if (!MetadataImportHelper.CheckPropertyDisplayName(((IEnumerable<IMetadata>) this.GetProperties(md)).ToList<IMetadata>(), (IMetadata) propertyImported, propertyImported.DisplayName, out message))
      {
        parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(825385222 ^ 825669954), (object) propertyImported.Uid, (object) md.DisplayName, (object) message, (object) propertyImported.DisplayName, (object) propertyImported.Name, (object) md.Name, (object) md.Uid)));
        flag = false;
      }
      if (!MetadataImportHelper.CheckPropertyName(((IEnumerable<IMetadata>) this.GetProperties(md)).ToList<IMetadata>(), (IMetadata) propertyImported, md.Name, propertyImported.Name, out message))
      {
        parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -811753462), (object) propertyImported.Uid, (object) md.DisplayName, (object) message, (object) propertyImported.DisplayName, (object) propertyImported.Name, (object) md.Name, (object) md.Uid)));
        flag = false;
      }
      EntitySettings settings1 = propertyImported.Settings as EntitySettings;
      if (!((object) md is DataClassMetadata) && (settings1 == null || settings1.RelationType != RelationType.OneToMany) && (settings1 == null || settings1.RelationType != RelationType.ManyToMany) && (settings1 == null || settings1.RelationType != RelationType.ManyToManyInverse) && propertyImported.Settings is SimpleTypeSettings && !MetadataImportHelper.CheckPropertyFieldName(((IEnumerable<IMetadata>) this.GetProperties(md)).ToList<IMetadata>(), (IMetadata) propertyImported, (propertyImported.Settings as SimpleTypeSettings).FieldName, out message))
      {
        parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(654297945 ^ 653988637), (object) propertyImported.Uid, (object) md.DisplayName, (object) message, (object) propertyImported.DisplayName, (object) propertyImported.Name, (object) md.Name, (object) md.Uid)));
        flag = false;
      }
      if (propertyImported.Settings is PropertySettings settings2)
      {
        ClassMetadata classMetadata;
        try
        {
          classMetadata = MetadataServiceContext.Service.GetMetadata(parameters.MergeReplace.GetUidReplaceMD(settings2.EntityTypeUid)) as ClassMetadata;
        }
        catch (TypeNotFoundException ex)
        {
          classMetadata = (ClassMetadata) null;
          parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(712480695 ^ 712200179), (object) propertyImported.Uid, (object) md.DisplayName, (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(333888594 ^ 1075625116 ^ 1409210846)), (object) propertyImported.DisplayName, (object) propertyImported.Name, (object) md.Name, (object) md.Uid)));
        }
        Guid uidReplaceMd = parameters.MergeReplace.GetUidReplaceMD(settings2.EntityTypeUid);
        Guid propertyUid = parameters.MergeReplace.GetUidReplaceProperty(uidReplaceMd, settings2.PropertyUid);
        int num = classMetadata != null ? (classMetadata.Properties.All<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => p.Uid != propertyUid)) ? 1 : 0) : 1;
      }
      if ((propertyImported.TypeUid == EntityDescriptor.UID || this.InheriteEntityMetadataGuids.Any<IInheriteEntityMetadataGuid>((Func<IInheriteEntityMetadataGuid, bool>) (e => propertyImported.TypeUid == e.Uid))) && settings1 != null && settings1.RelationType == RelationType.OneToMany)
      {
        ClassMetadata classMetadata;
        try
        {
          classMetadata = MetadataServiceContext.Service.GetMetadata(parameters.MergeReplace.GetUidReplaceMD(propertyImported.SubTypeUid)) as ClassMetadata;
        }
        catch (TypeNotFoundException ex)
        {
          classMetadata = (ClassMetadata) null;
        }
        Guid keyUid = parameters.MergeReplace.GetUidReplaceProperty(propertyImported.SubTypeUid, settings1.KeyColumnUid);
        if (classMetadata == null || !classMetadata.Properties.Any<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => p.Uid == keyUid)))
          parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106208384), (object) propertyImported.Uid, (object) md.DisplayName, (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461625753 ^ 1461353199)), (object) propertyImported.DisplayName, (object) propertyImported.Name, (object) md.Name, (object) md.Uid)));
      }
      IMetadataService service = MetadataServiceContext.Service;
      switch (service.GetTypeDescriptor(propertyImported.TypeUid, propertyImported.SubTypeUid))
      {
        case null:
          parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(2008901894 << 3 ^ -1108373388), (object) propertyImported.Uid, (object) md.DisplayName, (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~1767720452 ^ -1767481329)), (object) propertyImported.DisplayName, (object) propertyImported.Name, (object) md.Name, (object) md.Uid)));
          flag = false;
          break;
        case EntityDescriptor _:
        case EnumDescriptor _:
          if (service.GetMetadataList().All<IMetadata>((Func<IMetadata, bool>) (m => m.Uid != propertyImported.SubTypeUid)) && (!((object) md is TablePartMetadata) || !propertyImported.IsSystem))
          {
            parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~210725948 ^ -210482297), (object) propertyImported.Uid, (object) md.DisplayName, (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -35775505), (object) propertyImported.SubTypeUid), (object) propertyImported.DisplayName, (object) propertyImported.Name, (object) md.Name, (object) md.Uid)));
            flag = false;
            break;
          }
          break;
      }
      return flag;
    }

    /// <summary>Получение свойств</summary>
    /// <param name="md">Метаданные</param>
    protected virtual IEnumerable<IPropertyMetadata> GetProperties(TBase md) => (IEnumerable<IPropertyMetadata>) md.Properties;

    private void MergeMetadataForms(
      ClassMetadata mdImported,
      ClassMetadata mdDraft,
      ReadMetadataParameters parameters)
    {
      int num1 = 12;
      while (true)
      {
        int num2 = num1;
        List<KeyValuePair<Guid, Guid>> replaceList;
        ClassMetadata mdDraft1;
        Action<IEnumerable<ViewItem>> replacePropertyUids;
        while (true)
        {
          switch (num2)
          {
            case 1:
              replaceList.AddRange(parameters.MergeReplace.GetAllUidReplaceProperty());
              num2 = 4;
              continue;
            case 2:
              mdImported.FormTransformations.Each<FormViewItemTransformation>((Action<FormViewItemTransformation>) (it =>
              {
                int num4 = 4;
                FormViewItemTransformation it1;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      goto label_2;
                    case 2:
                      mdDraft1.FormTransformations.RemoveAll((Predicate<FormViewItemTransformation>) (t =>
                      {
                        int num5 = 1;
                        while (true)
                        {
                          switch (num5)
                          {
                            case 1:
                              if (!(it1.Uid == t.Uid))
                              {
                                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
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
                        return it1.NewFormUid == t.NewFormUid;
label_5:
                        return false;
                      }));
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 5 : 4;
                      continue;
                    case 3:
                      it1 = it;
                      num4 = 2;
                      continue;
                    case 4:
                      num4 = 3;
                      continue;
                    case 5:
                      mdDraft1.FormTransformations.Add(it1);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
                      continue;
                    default:
                      replacePropertyUids(it1.Items.OfType<ViewItemTransformationAdd>().Select<ViewItemTransformationAdd, ViewItem>((Func<ViewItemTransformationAdd, ViewItem>) (ta => ta.Item)));
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 1 : 1;
                      continue;
                  }
                }
label_2:;
              }));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 1 : 8;
              continue;
            case 3:
              replacePropertyUids = (Action<IEnumerable<ViewItem>>) (items => items.OfType<PropertyViewItem>().Each<PropertyViewItem>((Action<PropertyViewItem>) (p =>
              {
                int num6 = 2;
                List<KeyValuePair<Guid, Guid>>.Enumerator enumerator;
                while (true)
                {
                  switch (num6)
                  {
                    case 0:
                      goto label_15;
                    case 1:
                      goto label_2;
                    case 2:
                      enumerator = replaceList.GetEnumerator();
                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 1;
                      continue;
                    default:
                      goto label_11;
                  }
                }
label_15:
                return;
label_11:
                return;
label_2:
                try
                {
label_9:
                  if (enumerator.MoveNext())
                    goto label_8;
                  else
                    goto label_10;
label_3:
                  KeyValuePair<Guid, Guid> current;
                  int num7;
                  while (true)
                  {
                    switch (num7)
                    {
                      case 1:
                        goto label_4;
                      case 2:
                        goto label_8;
                      case 3:
                        if (current.Key != p.PropertyUid)
                        {
                          num7 = 5;
                          continue;
                        }
                        goto case 4;
                      case 4:
                        p.PropertyUid = current.Value;
                        num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_9;
                    }
                  }
label_4:
                  return;
label_8:
                  current = enumerator.Current;
                  num7 = 3;
                  goto label_3;
label_10:
                  num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 1;
                  goto label_3;
                }
                finally
                {
                  enumerator.Dispose();
                  int num8 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
                    num8 = 0;
                  switch (num8)
                  {
                    default:
                  }
                }
              })));
              num2 = 9;
              continue;
            case 4:
              replaceList = replaceList.Where<KeyValuePair<Guid, Guid>>((Func<KeyValuePair<Guid, Guid>, bool>) (r => r.Key != r.Value)).ToList<KeyValuePair<Guid, Guid>>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 3 : 0;
              continue;
            case 5:
              mdDraft1.TableViews = mdImported.TableViews;
              num2 = 6;
              continue;
            case 6:
              replaceList = new List<KeyValuePair<Guid, Guid>>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 4 : 13;
              continue;
            case 7:
              mdDraft1.InheritForms = mdImported.InheritForms;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 5 : 5;
              continue;
            case 8:
              goto label_3;
            case 9:
              mdImported.Forms.Each<FormViewItem>((Action<FormViewItem>) (@if =>
              {
                int num9 = 4;
                FormViewItem if1;
                while (true)
                {
                  switch (num9)
                  {
                    case 1:
                      mdDraft1.Forms.Add(if1);
                      num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 2 : 5;
                      continue;
                    case 2:
                      goto label_2;
                    case 3:
                      if1 = @if;
                      num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
                      continue;
                    case 4:
                      num9 = 3;
                      continue;
                    case 5:
                      replacePropertyUids(if1.GetAllItems(false));
                      num9 = 2;
                      continue;
                    default:
                      mdDraft1.Forms.RemoveAll((Predicate<FormViewItem>) (f => if1.Uid == f.Uid));
                      num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 1;
                      continue;
                  }
                }
label_2:;
              }));
              num2 = 2;
              continue;
            case 10:
              mdDraft1.FormsScheme = mdImported.FormsScheme;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 0 : 0;
              continue;
            case 11:
              goto label_14;
            case 12:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 11 : 11;
              continue;
            case 13:
              replaceList.AddRange(parameters.MergeReplace.GetAllUidReplaceMd());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 1 : 0;
              continue;
            default:
              mdDraft1.DefaultForms = mdImported.DefaultForms;
              num2 = 7;
              continue;
          }
        }
label_14:
        mdDraft1 = mdDraft;
        num1 = 10;
      }
label_3:;
    }

    protected ClassMetadataImportExtension()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool VGnM6EElCn0Jtm0fdDRp() => ClassMetadataImportExtension<T, TBase>.hdKKaJElQ42erooRNAK9 == null;

    internal static object EHjXOVElv6mFs6L7qKjA() => ClassMetadataImportExtension<T, TBase>.hdKKaJElQ42erooRNAK9;
  }
}
