// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Export.ObjectsExportExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export.Components;
using EleWise.ELMA.Deploy.ExtensionPoints;
using EleWise.ELMA.Deploy.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Deploy.Export
{
  /// <summary>Расширение экспорта конфигурации для объектов</summary>
  [Component(Order = 200)]
  public class ObjectsExportExtension : MetadataConfigurationExportExtension
  {
    private static ObjectsExportExtension g0jEvFEYewncKNPImbud;

    /// <inheritdoc />
    public override Dictionary<Guid, object> GetNewSettingObj() => new Dictionary<Guid, object>()
    {
      {
        ObjectsExportConsts.ExportExtensionUid,
        (object) new ObjectsExportSetting()
      }
    };

    /// <inheritdoc />
    public override void AddExportObjects(ExportExtensionParams parameters)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.AddExportObjectsCustom(parameters.Parameters, parameters.Objects, parameters.ServiceData, parameters.PacketMetadatas, parameters.PacketEntities, parameters.Importants);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    private void AddExportObjectsCustom(
      Dictionary<Guid, object> parameters,
      Dictionary<IGroupedMetadata, bool> objects,
      Dictionary<string, object> serviceData,
      List<PacketMetadata> packetMetadatas,
      List<PacketEntity> packetEntities,
      ISet<Guid> importants)
    {
      if (!(parameters[ObjectsExportConsts.ExportExtensionUid] is ObjectsExportSetting parameter))
        return;
      List<Guid> dataClasses1 = parameter.DataClasses;
      if ((dataClasses1 != null ? (dataClasses1.Any<Guid>() ? 1 : 0) : 0) != 0)
      {
        List<Guid> dataClasses2 = parameter.DataClasses;
        DataClassMetadataItemHeaderManager instance = DataClassMetadataItemHeaderManager.Instance;
        foreach (Guid uid in dataClasses2)
        {
          DataClassMetadataItemHeader metadataItemHeader = instance.LoadOrNull(uid);
          if (metadataItemHeader?.Published != null)
          {
            DataClassMetadata dataClassMetadata = ClassSerializationHelper.CloneObjectByXml<DataClassMetadata>((DataClassMetadata) metadataItemHeader.Published.Metadata);
            PacketMetadata packetMetadata = new PacketMetadata((IMetadata) dataClassMetadata);
            if (metadataItemHeader.Group != null)
            {
              serviceData.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(2045296739 + 1688595713 ^ -561356304) + (object) metadataItemHeader.Uid, (object) metadataItemHeader.Group.Uid);
              foreach (IEntity key in this.AddInfoMetadataGroup(metadataItemHeader.Group, serviceData))
              {
                if (!packetMetadata.SubEntitiesBefore.ContainsKey(key))
                  packetMetadata.SubEntitiesBefore.Add(key, new Guid?());
              }
            }
            importants.Add(ObjectsExportExtension.ImportantData.Uid);
            packetMetadata.SubUserMetadataInfo[dataClassMetadata.Uid] = new SubUserMetadataInfo((IGroupedMetadata) dataClassMetadata);
            packetMetadatas.Add(packetMetadata);
          }
        }
      }
      bool exportCatalogs = parameter.ExportCatalogs;
      SerializableDictionary<Guid, bool> catalogs = parameter.Catalogs;
      List<Guid> sysCatalogs = parameter.SysCatalogs;
      bool exportEnums = parameter.ExportEnums;
      List<Guid> enums = parameter.Enums;
      if (!(exportCatalogs | exportEnums))
        return;
      List<Guid> guidList = new List<Guid>();
      if (sysCatalogs != null & exportCatalogs)
        guidList.AddRange((IEnumerable<Guid>) sysCatalogs);
      if (catalogs != null & exportCatalogs)
      {
        foreach (KeyValuePair<Guid, bool> keyValuePair in (Dictionary<Guid, bool>) catalogs)
        {
          if (!guidList.Contains(keyValuePair.Key))
            guidList.Add(keyValuePair.Key);
        }
      }
      if (enums != null & exportEnums)
      {
        foreach (Guid guid in enums)
        {
          if (!guidList.Contains(guid))
            guidList.Add(guid);
        }
      }
      IMetadataRuntimeService serviceNotNull = Locator.GetServiceNotNull<IMetadataRuntimeService>();
      foreach (Guid guid in guidList)
      {
        IMetadata metadata = serviceNotNull.GetMetadata(guid, false);
        IGroupedMetadata key1 = metadata as IGroupedMetadata;
        ClassMetadata classMetadata = metadata as ClassMetadata;
        if (metadata == null || key1 == null || classMetadata == null)
        {
          if (metadata is EnumMetadata)
          {
            EnumMetadata enumMetadata = metadata as EnumMetadata;
            if (enumMetadata.Type == EnumMetadataType.Enum && !metadata.IsSystem())
            {
              PacketMetadata packetMetadata = new PacketMetadata((IMetadata) enumMetadata);
              packetMetadata.SubUserMetadataInfo.Add(enumMetadata.Uid, new SubUserMetadataInfo((IGroupedMetadata) enumMetadata));
              IMetadataItemHeader metadataItemHeader = this.MetadataItemHeaderManager.LoadOrNull(key1.Uid);
              if (metadataItemHeader != null && metadataItemHeader.Published != null && metadataItemHeader.Group != null)
              {
                foreach (IEntity key2 in this.AddInfoMetadataGroup(metadataItemHeader.Group, serviceData))
                {
                  if (!packetMetadata.SubEntitiesBefore.ContainsKey(key2))
                    packetMetadata.SubEntitiesBefore.Add(key2, new Guid?());
                }
              }
              packetMetadatas.Add(packetMetadata);
            }
          }
        }
        else
        {
          if (catalogs != null && catalogs.ContainsKey(guid))
          {
            if (catalogs[guid])
              objects.Add(key1, true);
          }
          else
            objects.Add(key1, true);
          PacketMetadata packetMetadata = this.CreatePacketMetadata(metadata, serviceData);
          packetMetadatas.Add(packetMetadata);
        }
      }
    }

    public ObjectsExportExtension()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool x4ZapxEYPgbPHUmJ7RdZ() => ObjectsExportExtension.g0jEvFEYewncKNPImbud == null;

    internal static ObjectsExportExtension sHPo46EY1wiBXAwB2hLS() => ObjectsExportExtension.g0jEvFEYewncKNPImbud;

    [Component]
    private sealed class ImportantData : IImportantData
    {
      internal static object k7cHli80b3nvoqqWxKTq;

      public static Guid Uid { get; }

      Guid IImportantData.Uid => ObjectsExportExtension.ImportantData.rNF3MZ80EGZxZG2i3wsP();

      public IEnumerable<Version> Versions { get; }

      public string Module => (string) null;

      public ImportantData()
      {
        ObjectsExportExtension.ImportantData.DMkbH380fh3iZbkQoLu1();
        this.Versions = (IEnumerable<Version>) new Version[1]
        {
          new Version(4, 1, 0)
        };
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      static ImportantData()
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              ObjectsExportExtension.ImportantData.Uid = new Guid((string) ObjectsExportExtension.ImportantData.A0vYh180QVKyct9El8tZ(95909607 + 343705423 ^ 439744398));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 0;
              continue;
            case 2:
              ObjectsExportExtension.ImportantData.DMkbH380fh3iZbkQoLu1();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 1 : 1;
              continue;
            default:
              goto label_5;
          }
        }
label_2:
        return;
label_5:;
      }

      internal static Guid rNF3MZ80EGZxZG2i3wsP() => ObjectsExportExtension.ImportantData.Uid;

      internal static void DMkbH380fh3iZbkQoLu1() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool yMBW2g80hcXv8E5JucbP() => ObjectsExportExtension.ImportantData.k7cHli80b3nvoqqWxKTq == null;

      internal static ObjectsExportExtension.ImportantData B6B1aH80GeuOq7faJCcI() => (ObjectsExportExtension.ImportantData) ObjectsExportExtension.ImportantData.k7cHli80b3nvoqqWxKTq;

      internal static object A0vYh180QVKyct9El8tZ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
    }
  }
}
