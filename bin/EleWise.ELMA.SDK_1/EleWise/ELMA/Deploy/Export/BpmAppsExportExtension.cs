// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Export.BpmAppsExportExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.BPMApps.DTO.Managers;
using EleWise.ELMA.BPMApps.DTO.Models;
using EleWise.ELMA.BPMApps.Services;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export.ExtensionPoints;
using EleWise.ELMA.Deploy.Services;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EleWise.ELMA.Deploy.Export
{
  /// <summary>Расширение экспорта конфигурации для объектов</summary>
  [Component(Order = 200)]
  public class BpmAppsExportExtension : IConfigExportExtension
  {
    private static BpmAppsExportExtension tXOOCWEj7Fl38PN7x8uT;

    public Dictionary<Guid, object> GetNewSettingObj() => new Dictionary<Guid, object>()
    {
      {
        BpmAppsExportConsts.ExportBpmAppsUid,
        (object) new BpmAppsExportSetting()
      }
    };

    /// <summary>Добавление экспортируемых объектов</summary>
    /// <param name="parameters"></param>
    public void AddExportObjects(ExportExtensionParams parameters)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.AddExportObjectsCustom(parameters.Parameters, parameters.Objects, parameters.ServiceData);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 0;
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
      Dictionary<string, object> serviceData)
    {
      if (!(parameters[BpmAppsExportConsts.ExportBpmAppsUid] is BpmAppsExportSetting parameter) || !parameter.Components.Any<KeyValuePair<string, BPMAppDTO>>())
        return;
      IExportImportFileService ieFileService = Locator.GetServiceNotNull<IExportImportFileService>();
      string fromPath = ieFileService.GetFilesFolderPath();
      string toPath = Path.Combine(fromPath, parameter.TempId, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1178210108 ^ 1178529876));
      if (!Directory.Exists(toPath))
        Directory.CreateDirectory(toPath);
      parameter.Components.ForEach<KeyValuePair<string, BPMAppDTO>>((Action<KeyValuePair<string, BPMAppDTO>>) (cP =>
      {
        ConfigExportSettings settings = new ConfigExportSettings();
        ConfigExportSettings configExportSettings = settings;
        ElmaStoreComponentManifest componentManifest = cP.Value.ComponentManifest;
        if (componentManifest == null)
          componentManifest = new ElmaStoreComponentManifest()
          {
            ProductType = ManifestComponentType.ProcessPackage
          };
        configExportSettings.Manifest = componentManifest;
        if (cP.Value.AppManifest != null)
        {
          foreach (IBPMAppItemsConverter extensionPoint in ComponentManager.Current.GetExtensionPoints<IBPMAppItemsConverter>())
            extensionPoint.ToExportSettings(cP.Value.AppManifest, settings);
          object obj = (object) null;
          if (cP.Value.Id > 0L && settings.CustomSettings.TryGetValue(FilesExportConsts.ExportExtensionUid, out obj) && obj is FilesExportSetting filesExportSetting2)
          {
            byte[] helpFileContent;
            byte[] additionalFilesContent;
            Locator.GetServiceNotNull<IBPMAppDTOManager>().LoadFiles(cP.Value.Id, out helpFileContent, out additionalFilesContent);
            filesExportSetting2.HelpFileContent = helpFileContent;
            filesExportSetting2.AdditionalFilesContent = additionalFilesContent;
          }
        }
        if (cP.Value.IconData != null)
        {
          settings.Icon = cP.Value.IconData;
          settings.IconFileName = cP.Value.IconFileName;
        }
        // ISSUE: reference to a compiler-generated method
        ElmaStoreComponentManifest platform = Locator.GetServiceNotNull<IModuleDTOManager>().GetInstalledComponentManifests().FirstOrDefault<ElmaStoreComponentManifest>((Func<ElmaStoreComponentManifest, bool>) (m => BpmAppsExportExtension.\u003C\u003Ec.Q6PmHn8xrgwKTkkopVy0((object) m) == ManifestComponentType.Platform));
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        if (platform != null && !settings.Manifest.Dependencies.Any<ElmaStoreComponentDependency>((Func<ElmaStoreComponentDependency, bool>) (d => BpmAppsExportExtension.\u003C\u003Ec__DisplayClass2_1.diquJx8xM39Mi9QY6MqN(BpmAppsExportExtension.\u003C\u003Ec__DisplayClass2_1.RtNFRP8xmecvtdrDWPqH((object) d), BpmAppsExportExtension.\u003C\u003Ec__DisplayClass2_1.tyd00i8xyEkTToKbRDGo((object) platform)))))
          settings.Manifest.Dependencies.Add(new ElmaStoreComponentDependency()
          {
            Id = platform.Id,
            ManifestVersion = ManifestValidationHelper.GetFromVersion(platform.SemanticVersion)
          });
        new ConfigExport(settings).RunExport((IRunExportParameters) new RunExportParameters(Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser().GetId() as long?));
        File.Move(Path.Combine(fromPath, settings.FileName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138161350)), Path.Combine(toPath, settings.FileName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(372753449 ^ 372750699)));
        ieFileService.DeleteFiles(settings.FileName);
      }));
    }

    public BpmAppsExportExtension()
    {
      BpmAppsExportExtension.QDuRGNEjmbeMZIqlWScN();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool FnEexbEjxZ3XkthmUHhB() => BpmAppsExportExtension.tXOOCWEj7Fl38PN7x8uT == null;

    internal static BpmAppsExportExtension iwxXNkEj0SOastwok2Hk() => BpmAppsExportExtension.tXOOCWEj7Fl38PN7x8uT;

    internal static void QDuRGNEjmbeMZIqlWScN() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
