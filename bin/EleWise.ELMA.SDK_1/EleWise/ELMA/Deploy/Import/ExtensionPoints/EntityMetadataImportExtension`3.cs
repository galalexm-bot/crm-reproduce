// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.ExtensionPoints.EntityMetadataImportExtension`3
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using AutoMapper;
using EleWise.ELMA.Deploy.Import.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.DTO.Models;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Scripts.DTO.Models;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints
{
  /// <summary>
  /// Точка расширения для обработки IEntityMetadata при импорте конфигурации
  /// </summary>
  /// <typeparam name="TMetadata">Тип метаданных</typeparam>
  /// <typeparam name="TTablePart">Тип метаданных блока</typeparam>
  /// <typeparam name="TCommonBase">Базовый тип для <typeparamref name="TMetadata" /> и <typeparamref name="TTablePart" /></typeparam>
  public abstract class EntityMetadataImportExtension<TMetadata, TTablePart, TCommonBase> : 
    ClassMetadataImportExtension<TMetadata, TCommonBase>
    where TMetadata : TCommonBase
    where TTablePart : TCommonBase, ITablePartMetadata
    where TCommonBase : ITablePartContainer, ClassMetadata, IEntityMetadata
  {
    private static readonly ILogger ImportLog;
    internal static object OS2vx4ElwXwD6KVMM2wO;

    /// <summary>Менеджер элементов метаданных</summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public MetadataItemManager MetadataItemManager
    {
      private get => this.\u003CMetadataItemManager\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CMetadataItemManager\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Сервис для ограничения работы с зависимостями форм</summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public IWorkWithFormDependeciesService WorkWithFormDependeciesService
    {
      private get => this.\u003CWorkWithFormDependeciesService\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CWorkWithFormDependeciesService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>
    /// Менеджер управления моделями приложения через дизайнер ELMA
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ModelManager ModelManager
    {
      private get => this.\u003CModelManager\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CModelManager\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Менеджер группы элементов метаданных</summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public MetadataItemGroupManager MetadataItemGroupManager
    {
      private get => this.\u003CMetadataItemGroupManager\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CMetadataItemGroupManager\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <inheritdoc />
    protected override IReadMetadataResult ReadMetadata(
      TMetadata mdImported,
      ReadMetadataParameters parameters,
      bool isTestRead)
    {
      if (!(parameters.ImportSettings is IConfigImportSettings))
        throw new Exception(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669212571 ^ 1668993529)));
      return base.ReadMetadata(mdImported, parameters, isTestRead);
    }

    /// <inheritdoc />
    protected override void SaveMetadata(TMetadata mdMerged, ReadMetadataParameters parameters)
    {
      MetadataItemDTO mdItemBaseDTO = (MetadataItemDTO) null;
      IMetadataItem source = this.MetadataItemManager.LoadOrNull(mdMerged.Uid);
      MetadataItemDTO metadataItemDto1;
      if (source == null)
        metadataItemDto1 = new MetadataItemDTO()
        {
          Uid = mdMerged.Uid
        };
      else
        metadataItemDto1 = Mapper.Map<IMetadataItem, MetadataItemDTO>(source);
      mdItemBaseDTO = metadataItemDto1;
      mdItemBaseDTO.Metadata = (IMetadata) mdMerged;
      this.SetScriptModule<MetadataItemDTO>(mdItemBaseDTO, (Expression<Func<MetadataItemDTO, ScriptModuleDTO>>) (metadataItemDto => metadataItemDto.ScriptModule), parameters);
      this.SetScriptModule<MetadataItemDTO>(mdItemBaseDTO, (Expression<Func<MetadataItemDTO, ScriptModuleDTO>>) (metadataItemDto => metadataItemDto.ClientScriptModule), parameters);
      string key = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218190658) + (object) mdMerged.GroupId;
      string tmp;
      if (parameters.ServiceData.TryGetValue(key, out tmp))
      {
        long num = 0;
        Guid result;
        if (Guid.TryParse(tmp, out result))
        {
          IMetadataItemGroup metadataItemGroup = this.MetadataItemGroupManager.LoadOrNull(result);
          if (metadataItemGroup != null)
            num = metadataItemGroup.Id;
        }
        else
        {
          IMetadataItemGroup metadataItemGroup1 = this.MetadataItemGroupManager.Find((Expression<Func<IMetadataItemGroup, bool>>) (metadataItemGroup => metadataItemGroup.Namespace == tmp), FetchOptions.First).FirstOrDefault<IMetadataItemGroup>();
          if (metadataItemGroup1 != null)
            num = metadataItemGroup1.Id;
        }
        if (num == 0L)
        {
          IMetadataItemGroup metadataItemGroup2 = this.MetadataItemGroupManager.Find((Expression<Func<IMetadataItemGroup, bool>>) (metadataItemGroup => metadataItemGroup.Namespace == z2jc63fLkugS1X8Q9N.tE1kD1vbB(87862435 ^ 87581955)), FetchOptions.First).FirstOrDefault<IMetadataItemGroup>();
          if (metadataItemGroup2 != null)
            num = metadataItemGroup2.Id;
        }
        mdItemBaseDTO.HeaderGroupId = num;
        mdMerged.GroupId = num;
      }
      Type mdTypeImported = EntityMetadataImportExtension<TMetadata, TTablePart, TCommonBase>.ImportLog.IsInfoEnabled() ? mdMerged.GetType() : (Type) null;
      this.WorkWithFormDependeciesService.Run((System.Action) (() =>
      {
        int num = 4;
        List<MetadataItemDTO> metadataItemDtoList;
        while (true)
        {
          switch (num)
          {
            case 1:
              parameters.Headers.Add(metadataItemDtoList[0].HeaderId);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 2 : 2;
              continue;
            case 2:
              goto label_2;
            case 3:
              metadataItemDtoList = this.ModelManager.SaveMetadataItems(new List<MetadataItemDTO>()
              {
                mdItemBaseDTO
              });
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 0 : 0;
              continue;
            case 4:
              EntityMetadataImportExtension<TMetadata, TTablePart, TCommonBase>.ImportLog.InfoFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(813604817 ^ 813323025), (object) mdTypeImported.Name, (object) mdItemBaseDTO.Uid);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 3 : 3;
              continue;
            case 5:
              parameters.Messages.Add(new DeployLogMessage(DeployLogMessageType.Info, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(381945751 ^ 1158627804 ^ 1406111635), (object) mdMerged.Uid, (object) mdMerged.DisplayName, (object) mdMerged.Name), false));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 1;
              continue;
            default:
              EntityMetadataImportExtension<TMetadata, TTablePart, TCommonBase>.ImportLog.InfoFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420529620), (object) mdTypeImported.Name, (object) mdItemBaseDTO.Uid);
              num = 5;
              continue;
          }
        }
label_2:;
      }));
    }

    /// <inheritdoc />
    protected override void MergeMetadataProperties(
      TCommonBase mdImported,
      TCommonBase mdDraft,
      ReadMetadataParameters parameters)
    {
      base.MergeMetadataProperties(mdImported, mdDraft, parameters);
      List<ITablePartMetadata> list = mdDraft.TableParts.ToList<ITablePartMetadata>();
      foreach (TTablePart tablePart in mdImported.TableParts.Cast<TTablePart>())
      {
        TTablePart tablepartImported = tablePart;
        TTablePart mdDraft1;
        try
        {
          mdDraft1 = (TTablePart) list.SingleOrDefault<ITablePartMetadata>((Func<ITablePartMetadata, bool>) (b => b.Uid == tablepartImported.Uid));
        }
        catch (InvalidOperationException ex)
        {
          continue;
        }
        if ((object) mdDraft1 != null && (((NamedMetadata) tablepartImported).Name != ((NamedMetadata) mdDraft1).Name || tablepartImported.TablePartPropertyName != mdDraft1.TablePartPropertyName))
          parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.InfoMetadata, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(272623989 ^ 272306601), (object) mdDraft.Name, (object) tablepartImported.Uid, (object) mdDraft1.Uid, (object) mdDraft.DisplayName, (object) tablepartImported.DisplayName, (object) mdDraft1.DisplayName, (object) tablepartImported.TablePartPropertyName, (object) mdDraft1.TablePartPropertyName)));
        if ((object) mdDraft1 == null)
        {
          try
          {
            mdDraft1 = (TTablePart) list.SingleOrDefault<ITablePartMetadata>((Func<ITablePartMetadata, bool>) (b =>
            {
              int num = 1;
              while (true)
              {
                switch (num)
                {
                  case 1:
                    if (b.Name == ((NamedMetadata) tablepartImported).Name)
                    {
                      num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 0;
                      continue;
                    }
                    goto label_3;
                  default:
                    goto label_2;
                }
              }
label_2:
              return b.TablePartPropertyName == tablepartImported.TablePartPropertyName;
label_3:
              return false;
            }));
          }
          catch (InvalidOperationException ex)
          {
            continue;
          }
          if ((object) mdDraft1 != null)
            parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.InfoMetadata, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(132912447 ^ 132705763), (object) mdDraft.Name, (object) tablepartImported.Uid, (object) mdDraft1.Uid, (object) mdDraft.DisplayName, (object) tablepartImported.DisplayName, (object) mdDraft1.DisplayName, (object) tablepartImported.TablePartPropertyName, (object) mdDraft1.TablePartPropertyName)));
        }
        if ((object) mdDraft1 != null)
        {
          this.MergeMetadataProperties((TCommonBase) tablepartImported, (TCommonBase) mdDraft1, parameters);
          parameters.MergeReplace.SetUidReplaceMD(tablepartImported.Uid, mdDraft1.Uid);
          parameters.MergeReplace.SetUidReplaceProperty(mdImported.Uid, tablepartImported.TablePartPropertyUid, mdDraft1.TablePartPropertyUid);
          parameters.MergeReplace.SetNameReplaceProperty(mdImported.Uid, ((NamedMetadata) tablepartImported).Name, ((NamedMetadata) mdDraft1).Name);
          mdDraft1.DisplayName = tablepartImported.DisplayName;
          ((NamedMetadata) mdDraft1).Name = ((NamedMetadata) tablepartImported).Name;
          mdDraft1.TablePartPropertyName = tablepartImported.TablePartPropertyName;
          ((ClassMetadata) mdDraft1).Properties = ((ClassMetadata) mdDraft1).Properties;
          ITablePartContainer tablePartContainer1 = (ITablePartContainer) mdDraft1;
          ITablePartContainer tablePartContainer2 = (ITablePartContainer) tablepartImported;
          if (tablePartContainer1 != null && tablePartContainer2 != null)
            tablePartContainer1.TableParts = tablePartContainer2.TableParts;
          mdDraft1.Description = tablepartImported.Description;
          ClassMetadata classMetadata1 = (ClassMetadata) mdDraft1;
          ClassMetadata classMetadata2 = (ClassMetadata) tablepartImported;
          if (classMetadata1 != null && classMetadata2 != null)
            classMetadata1.ScriptModuleTypeName = classMetadata2.ScriptModuleTypeName;
        }
        else if (this.CheckNewTablePart(tablepartImported, mdDraft, parameters))
        {
          this.CheckMetadataProperties((TCommonBase) tablepartImported, false, parameters);
          list.Add((ITablePartMetadata) tablepartImported);
        }
      }
      mdDraft.TableParts = (ICollection<ITablePartMetadata>) list;
    }

    /// <inheritdoc />
    protected override void CheckMetadataProperties(
      TCommonBase mdImported,
      bool isTestRead,
      ReadMetadataParameters parameters)
    {
      base.CheckMetadataProperties(mdImported, isTestRead, parameters);
      foreach (TTablePart tablePart in mdImported.TableParts.Cast<TTablePart>().ToArray<TTablePart>())
      {
        if (this.CheckNewTablePart(tablePart, mdImported, parameters))
          this.CheckMetadataProperties((TCommonBase) tablePart, isTestRead, parameters);
        else if (!isTestRead)
          mdImported.TableParts.Remove((ITablePartMetadata) tablePart);
      }
    }

    /// <inheritdoc />
    protected override bool CheckNewProperty(
      PropertyMetadata propertyImported,
      TCommonBase md,
      ReadMetadataParameters parameters)
    {
      bool flag = base.CheckNewProperty(propertyImported, md, parameters);
      if (propertyImported.Name.Equals(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867793646), StringComparison.CurrentCultureIgnoreCase))
      {
        parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -69787831), (object) propertyImported.Uid, (object) md.DisplayName, (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1178210108 ^ 1178514818), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867832790)), (object) propertyImported.DisplayName, (object) propertyImported.Name, (object) md.Name, (object) md.Uid)));
        flag = false;
      }
      return flag;
    }

    /// <summary>Проверка на возможность добавления нового блока</summary>
    /// <param name="tablepartImported">Метаданные блока</param>
    /// <param name="md">Родительские для блока метаданные</param>
    /// <param name="parameters">Параметры</param>
    protected virtual bool CheckNewTablePart(
      TTablePart tablepartImported,
      TCommonBase md,
      ReadMetadataParameters parameters)
    {
      string message1 = "";
      bool flag = false;
      if (!MetadataImportHelper.CheckPropertyDisplayName(((IEnumerable<IMetadata>) this.GetProperties(md)).ToList<IMetadata>(), (IMetadata) tablepartImported, tablepartImported.DisplayName, out message1))
      {
        parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951193510), (object) tablepartImported.Uid, (object) md.DisplayName, (object) message1, (object) tablepartImported.DisplayName, (object) ((NamedMetadata) tablepartImported).Name, (object) md.Name, (object) md.Uid)));
        flag = true;
      }
      if (!MetadataImportHelper.CheckPropertyName(((IEnumerable<IMetadata>) this.GetProperties(md)).ToList<IMetadata>(), (IMetadata) tablepartImported, md.Name, tablepartImported.TablePartPropertyName, out message1))
      {
        parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~1767720452 ^ -1767489465), (object) tablepartImported.Uid, (object) md.DisplayName, (object) message1, (object) tablepartImported.DisplayName, (object) ((NamedMetadata) tablepartImported).Name, (object) md.Name, (object) md.Uid)));
        flag = true;
      }
      if (((NamedMetadata) tablepartImported).Name.Equals(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 1360364355), StringComparison.CurrentCultureIgnoreCase))
      {
        parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917256330 ^ 1917057846), (object) tablepartImported.Uid, (object) md.DisplayName, (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(654297945 ^ 654012903), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398522054)), (object) tablepartImported.DisplayName, (object) ((NamedMetadata) tablepartImported).Name, (object) md.Name, (object) md.Uid)));
        flag = true;
      }
      if (md.TableParts.Any<ITablePartMetadata>((Func<ITablePartMetadata, bool>) (p =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (!(p.Uid != tablepartImported.Uid))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 0 : 0;
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
        return p.Name.Equals(((NamedMetadata) tablepartImported).Name, StringComparison.CurrentCultureIgnoreCase);
label_5:
        return false;
      })))
      {
        parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669212571 ^ 1668993063), (object) tablepartImported.Uid, (object) md.DisplayName, (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461825605 - 1531863589 ^ -69749596)), (object) tablepartImported.DisplayName, (object) ((NamedMetadata) tablepartImported).Name, (object) md.Name, (object) md.Uid)));
        flag = true;
      }
      TestImportMessages message2 = MetadataImportHelper.ValidateObjectTablePartName((ICodeItemMetadata) md, ((NamedMetadata) tablepartImported).Name, tablepartImported.Uid);
      if (message2 != null)
      {
        parameters.TestMessagesAdd(message2);
        flag = true;
      }
      return !flag;
    }

    /// <inheritdoc />
    protected override IEnumerable<IPropertyMetadata> GetProperties(TCommonBase md) => ((IEnumerable<IPropertyMetadata>) md.Properties).Concat<IPropertyMetadata>((IEnumerable<IPropertyMetadata>) md.TableParts);

    protected EntityMetadataImportExtension()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static EntityMetadataImportExtension()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            EntityMetadataImportExtension<TMetadata, TTablePart, TCommonBase>.ImportLog = Logger.GetLogger(z2jc63fLkugS1X8Q9N.tE1kD1vbB(979449278 ^ 979744352));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 2 : 1;
            continue;
        }
      }
label_2:;
    }

    internal static bool doTHW9El46GqGORSPubx() => EntityMetadataImportExtension<TMetadata, TTablePart, TCommonBase>.OS2vx4ElwXwD6KVMM2wO == null;

    internal static object P9j36wEl6k6KbrQHDY2i() => EntityMetadataImportExtension<TMetadata, TTablePart, TCommonBase>.OS2vx4ElwXwD6KVMM2wO;
  }
}
