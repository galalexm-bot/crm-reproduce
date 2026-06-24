// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Export.Components.MetadataConfigurationExportExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Deploy.Export.ExtensionPoints;
using EleWise.ELMA.Deploy.Export.Helpers;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Deploy.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Scripts.Manager;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Deploy.Export.Components
{
  /// <summary>Интерфейс экспорта метаданных</summary>
  public abstract class MetadataConfigurationExportExtension : IConfigExportExtension
  {
    /// <summary>Ключ записи MetadataItemGroup</summary>
    internal const string MetadataItemGroupKey = "MetadataItemGroup_";
    /// <summary>Ключ записи MetadataItemGroupUI</summary>
    internal const string MetadataItemGroupUIKey = "MetadataItemGroupUI_";
    internal static MetadataConfigurationExportExtension SgUWYPEsZ0vnOmiHJ8ex;

    /// <summary>Менеджер заголовков метаданных</summary>
    public MetadataItemHeaderManager MetadataItemHeaderManager
    {
      get => this.\u003CMetadataItemHeaderManager\u003Ek__BackingField;
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
              this.\u003CMetadataItemHeaderManager\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
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

    /// <summary>Менеджер скриптов</summary>
    public ScriptModuleManager ScriptModuleManager
    {
      get => this.\u003CScriptModuleManager\u003Ek__BackingField;
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
              this.\u003CScriptModuleManager\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
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

    /// <summary>&gt;Менеджер внешних сборок</summary>
    public ExternalAssemblyManager ExternalAssemblyManager
    {
      get => this.\u003CExternalAssemblyManager\u003Ek__BackingField;
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
              this.\u003CExternalAssemblyManager\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
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
    public abstract Dictionary<Guid, object> GetNewSettingObj();

    /// <inheritdoc />
    public abstract void AddExportObjects(ExportExtensionParams parameters);

    /// <summary>Создание макета метаданных</summary>
    /// <param name="metadata">Метаданные</param>
    /// <param name="serviceData">Словарь вспомогательных значений</param>
    /// <returns>Пакет метаданных</returns>
    protected virtual PacketMetadata CreatePacketMetadata(
      IMetadata metadata,
      Dictionary<string, object> serviceData)
    {
      if (metadata == null || !(metadata is ClassMetadata metaData) || !(metadata is IGroupedMetadata metadata1))
        return (PacketMetadata) null;
      PacketMetadata packetMetadata = new PacketMetadata((IMetadata) metaData);
      if (metadata.IsConfig())
      {
        IMetadataItemHeader header = this.MetadataItemHeaderManager.LoadOrNull(metadata.Uid);
        if (header != null && header.Published != null)
        {
          if (header.Group != null)
          {
            foreach (IEntity key in this.AddInfoMetadataGroup(header.Group, serviceData))
            {
              if (!packetMetadata.SubEntitiesBefore.ContainsKey(key))
                packetMetadata.SubEntitiesBefore.Add(key, new Guid?());
            }
          }
          this.AddInfoForUserMetadata(packetMetadata, metadata, serviceData);
          packetMetadata.SubUserMetadataInfo[metadata.Uid] = new SubUserMetadataInfo(metadata1);
          AddExportObjectsHelper.AddScriptModules(ref packetMetadata, ref serviceData, metadata1, header, this.ScriptModuleManager, this.ExternalAssemblyManager);
        }
      }
      else
      {
        packetMetadata.SubSystemMetadata.Add(metadata1);
        IEnumerable<EntityMetadata> entityMetadatas = MetadataServiceContext.Service.GetMetadataList().OfType<EntityMetadata>().Where<EntityMetadata>((Func<EntityMetadata, bool>) (m =>
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                // ISSUE: reference to a compiler-generated method
                if (MetadataConfigurationExportExtension.\u003C\u003Ec__DisplayClass16_0.Tkf0808mPt22XMpeTUqI((object) m) == EntityMetadataType.InterfaceExtension)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
                  continue;
                }
                goto label_3;
              default:
                goto label_2;
            }
          }
label_2:
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          return MetadataConfigurationExportExtension.\u003C\u003Ec__DisplayClass16_0.drwkLd8m3TCGBnLZjBJo(MetadataConfigurationExportExtension.\u003C\u003Ec__DisplayClass16_0.o8i7bO8m1h6WkgZMGwKF((object) m), MetadataConfigurationExportExtension.\u003C\u003Ec__DisplayClass16_0.N8Om8u8mNRaAQidL4XAn((object) metadata));
label_3:
          return false;
        }));
        if (entityMetadatas != null)
        {
          foreach (EntityMetadata metadata2 in entityMetadatas)
          {
            if (metadata2 != null)
            {
              if (metadata2.IsConfig())
              {
                IMetadataItemHeader header = this.MetadataItemHeaderManager.LoadOrNull(metadata2.Uid);
                if (header != null && header.Published != null)
                {
                  packetMetadata.SubUserMetadataInfo[metadata2.Uid] = new SubUserMetadataInfo((IGroupedMetadata) metadata2);
                  AddExportObjectsHelper.AddScriptModules(ref packetMetadata, ref serviceData, (IGroupedMetadata) metadata2, header, ScriptModuleManager.Instance, ExternalAssemblyManager.Instance);
                  this.AddInfoForSystemMetadata(packetMetadata, metadata, serviceData);
                }
              }
              else
                packetMetadata.SubSystemMetadata.Add((IGroupedMetadata) metadata2);
            }
          }
        }
      }
      IEntityMetadata entityMetadata = metadata as IEntityMetadata;
      ExportFormDependencyHelper.AddFormDependenciesInfo(metadata.Uid, entityMetadata == null ? string.Empty : entityMetadata.DisplayName, serviceData);
      return packetMetadata;
    }

    /// <summary>
    /// Добавление данных в пакет с пользовательскими метаданными
    /// </summary>
    /// <param name="packetMetadata">Пакет метаданных</param>
    /// <param name="metadata">Метаданные</param>
    /// <param name="serviceData">Словарь вспомогательных значений</param>
    protected virtual void AddInfoForUserMetadata(
      PacketMetadata packetMetadata,
      IMetadata metadata,
      Dictionary<string, object> serviceData)
    {
    }

    /// <summary>Добавление данных в пакет с системными метаданными</summary>
    /// <param name="packetMetadata">Пакет метаданных</param>
    /// <param name="metadata">Метаданные</param>
    /// <param name="serviceData">Словарь вспомогательных значений</param>
    protected virtual void AddInfoForSystemMetadata(
      PacketMetadata packetMetadata,
      IMetadata metadata,
      Dictionary<string, object> serviceData)
    {
    }

    /// <summary>Добавление групп метаданных</summary>
    /// <param name="group">Группа элементов метаданных</param>
    /// <param name="serviceData">Словарь вспомогательных значений</param>
    protected List<IEntity> AddInfoMetadataGroup(
      IMetadataItemGroup group,
      Dictionary<string, object> serviceData)
    {
      List<IEntity> entityList = new List<IEntity>();
      if (group != null)
      {
        string key1 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1255365154 ^ 596875508 ^ -1766092742) + (object) group.Id;
        if (!group.IsSystem)
        {
          if (!serviceData.ContainsKey(key1) && !entityList.Contains((IEntity) group))
          {
            entityList.Add((IEntity) group);
            serviceData.Add(key1, (object) group.Uid);
          }
        }
        else if (!serviceData.ContainsKey(key1))
        {
          serviceData.Add(key1, (object) group.Namespace);
          string key2 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1445902765 ^ -1980277732 ^ 539146079) + (object) group.Uid;
          serviceData.Add(key2, (object) group.Namespace);
        }
        if (group.Parent != null && group != group.Parent)
        {
          foreach (IEntity entity in this.AddInfoMetadataGroup(group.Parent, serviceData))
          {
            if (!entityList.Contains(entity))
              entityList.Add(entity);
          }
        }
      }
      return entityList;
    }

    /// <summary>Добавление групп метаданных</summary>
    /// <param name="group">Группа элементов метаданных</param>
    /// <param name="serviceData">Словарь вспомогательных значений</param>
    protected List<IEntity> AddInfoMetadataGroup(
      MetadataItemGroupUI group,
      Dictionary<string, object> serviceData)
    {
      List<IEntity> entityList = new List<IEntity>();
      if (group != null)
      {
        string key = z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917256330 ^ 1917046302) + (object) group.Id;
        if (!serviceData.ContainsKey(key) && !entityList.Contains((IEntity) group))
        {
          entityList.Add((IEntity) group);
          serviceData.Add(key, (object) group.Uid);
        }
        if (group.Parent != null && group != group.Parent)
        {
          foreach (IEntity entity in this.AddInfoMetadataGroup(group.Parent, serviceData))
          {
            if (!entityList.Contains(entity))
              entityList.Add(entity);
          }
        }
      }
      return entityList;
    }

    protected MetadataConfigurationExportExtension()
    {
      MetadataConfigurationExportExtension.WgQLAuEsVjQZ1AVraUUo();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool sZuSnMEsuTUW8rDNUFV1() => MetadataConfigurationExportExtension.SgUWYPEsZ0vnOmiHJ8ex == null;

    internal static MetadataConfigurationExportExtension fdm47TEsIKWMILSugU9N() => MetadataConfigurationExportExtension.SgUWYPEsZ0vnOmiHJ8ex;

    internal static void WgQLAuEsVjQZ1AVraUUo() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
