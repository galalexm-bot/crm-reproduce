// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Export.ExportExtensionParams
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Deploy.Services;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Deploy.Export
{
  public class ExportExtensionParams
  {
    private static ExportExtensionParams pwows4EjbYoRSQVprYAH;

    public ExportExtensionParams(
      Dictionary<Guid, object> parameters,
      Dictionary<IGroupedMetadata, bool> objects,
      ISet<Guid> importants,
      Dictionary<string, object> serviceData,
      List<PacketEntity> packetEntities,
      List<PacketMetadata> packetMetadatas,
      List<PackageDescription> packageDescriptions,
      List<EleWise.ELMA.Deploy.FormExportData> formExportData,
      List<Action<IExportImportFileService, string>> writeComponentFileActions,
      List<DeployLogMessage> messages,
      ElmaStoreComponentManifest manifest)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Parameters = parameters;
      this.Objects = objects;
      this.Importants = importants;
      this.ServiceData = serviceData;
      this.PacketEntities = packetEntities;
      this.PacketMetadatas = packetMetadatas;
      this.PackageDescriptions = packageDescriptions;
      this.FormExportData = formExportData;
      this.WriteComponentFileActions = writeComponentFileActions;
      this.Messages = messages;
      this.Manifest = manifest;
    }

    public Dictionary<Guid, object> Parameters { get; private set; }

    public Dictionary<IGroupedMetadata, bool> Objects { get; private set; }

    /// <summary>Уникальные идентификаторы важных данных для импорта</summary>
    public ISet<Guid> Importants { get; }

    public Dictionary<string, object> ServiceData { get; private set; }

    public List<PacketEntity> PacketEntities { get; private set; }

    public List<PacketMetadata> PacketMetadatas { get; private set; }

    public List<PackageDescription> PackageDescriptions { get; private set; }

    public List<EleWise.ELMA.Deploy.FormExportData> FormExportData { get; private set; }

    public List<Action<IExportImportFileService, string>> WriteComponentFileActions { get; private set; }

    public List<DeployLogMessage> Messages { get; private set; }

    public ElmaStoreComponentManifest Manifest
    {
      get => this.\u003CManifest\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CManifest\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 0;
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

    internal static bool jLfIbdEjhluJpcmCp9J6() => ExportExtensionParams.pwows4EjbYoRSQVprYAH == null;

    internal static ExportExtensionParams PvaC9pEjGisSohBhRgdA() => ExportExtensionParams.pwows4EjbYoRSQVprYAH;
  }
}
