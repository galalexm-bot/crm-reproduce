// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Export.FunctionExportExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export.Components;
using EleWise.ELMA.Deploy.Export.Helpers;
using EleWise.ELMA.Deploy.ExtensionPoints;
using EleWise.ELMA.Deploy.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Deploy.Export
{
  /// <summary>Расширение экспорта конфигурации для функций</summary>
  [Component(Order = 500)]
  internal class FunctionExportExtension : MetadataConfigurationExportExtension
  {
    private static FunctionExportExtension I4lakgE5ot66f8j0NSK9;

    /// <inheritdoc />
    public override Dictionary<Guid, object> GetNewSettingObj() => new Dictionary<Guid, object>()
    {
      {
        FunctionExportConsts.ExportExtensionUid,
        (object) new FunctionExportSetting()
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
            this.AddExportObjectsCustom(parameters.Parameters, parameters.PacketMetadatas, parameters.ServiceData, parameters.Importants);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
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
      List<PacketMetadata> packetMetadatas,
      Dictionary<string, object> serviceData,
      ISet<Guid> importants)
    {
      if (!(parameters[FunctionExportConsts.ExportExtensionUid] is FunctionExportSetting parameter) || parameter.FunctionsIds.Count == 0)
        return;
      List<Guid> functionsIds = parameter.FunctionsIds;
      FunctionMetadataItemHeaderManager instance = FunctionMetadataItemHeaderManager.Instance;
      foreach (Guid uid in functionsIds)
      {
        FunctionMetadataItemHeader metadataItemHeader = instance.LoadOrNull(uid);
        if (metadataItemHeader != null)
        {
          FunctionMetadata metaData = ClassSerializationHelper.CloneObjectByXml<FunctionMetadata>((FunctionMetadata) metadataItemHeader.Published.Metadata);
          metaData.Uid = metadataItemHeader.Uid;
          PacketMetadata packetMetadata = new PacketMetadata((IMetadata) metaData);
          if (metadataItemHeader.Group != null)
          {
            serviceData.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1819636893 << 3 ^ 1672439932) + (object) metadataItemHeader.Uid, (object) metadataItemHeader.Group.Uid);
            foreach (IEntity key in this.AddInfoMetadataGroup(metadataItemHeader.Group, serviceData))
            {
              if (!packetMetadata.SubEntitiesBefore.ContainsKey(key))
                packetMetadata.SubEntitiesBefore.Add(key, new Guid?());
            }
          }
          importants.Add(FunctionExportExtension.ImportantData.Uid);
          packetMetadata.SubUserMetadataInfo[metaData.Uid] = new SubUserMetadataInfo((IMetadata) metaData);
          AddExportObjectsHelper.AddScriptModule(packetMetadata, serviceData, (IMetadata) metaData, metadataItemHeader.Published.ScriptModule, metadataItemHeader.Draft.ScriptModule, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1304605005 ^ 1304578013), this.ScriptModuleManager, this.ExternalAssemblyManager);
          packetMetadatas.Add(packetMetadata);
        }
      }
    }

    public FunctionExportExtension()
    {
      FunctionExportExtension.mhPJbpE5GIF6PHaeYsiG();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool NDrsB1E5b3S915CE1yKX() => FunctionExportExtension.I4lakgE5ot66f8j0NSK9 == null;

    internal static FunctionExportExtension KxQLRdE5hGfRG5ao0ugY() => FunctionExportExtension.I4lakgE5ot66f8j0NSK9;

    internal static void mhPJbpE5GIF6PHaeYsiG() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    [Component]
    private sealed class ImportantData : IImportantData
    {
      private static object uShAJ78xvJINOBSRuwiI;

      public static Guid Uid { get; }

      Guid IImportantData.Uid => FunctionExportExtension.ImportantData.tx1Dk78xuprjA2VNY3VK();

      public IEnumerable<Version> Versions { get; }

      public string Module => (string) null;

      public ImportantData()
      {
        FunctionExportExtension.ImportantData.Pe4N0o8xI0wdFj5yeQmE();
        this.Versions = (IEnumerable<Version>) new Version[1]
        {
          new Version(4, 1, 0)
        };
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      static ImportantData()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              FunctionExportExtension.ImportantData.Pe4N0o8xI0wdFj5yeQmE();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_2;
            default:
              FunctionExportExtension.ImportantData.Uid = new Guid((string) FunctionExportExtension.ImportantData.fjvu5u8xVrJgaKiBAedw(-441065788 ^ -2092910478 ^ 1727229884));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 2 : 2;
              continue;
          }
        }
label_2:;
      }

      internal static Guid tx1Dk78xuprjA2VNY3VK() => FunctionExportExtension.ImportantData.Uid;

      internal static void Pe4N0o8xI0wdFj5yeQmE() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool Vq5GK88x81MG2R4YbcUA() => FunctionExportExtension.ImportantData.uShAJ78xvJINOBSRuwiI == null;

      internal static FunctionExportExtension.ImportantData dfSovY8xZ0MZo1tt02bd() => (FunctionExportExtension.ImportantData) FunctionExportExtension.ImportantData.uShAJ78xvJINOBSRuwiI;

      internal static object fjvu5u8xVrJgaKiBAedw(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
    }
  }
}
