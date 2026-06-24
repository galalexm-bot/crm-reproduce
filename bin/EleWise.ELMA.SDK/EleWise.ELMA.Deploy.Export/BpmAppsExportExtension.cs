using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EleWise.ELMA.BPMApps.DTO.Managers;
using EleWise.ELMA.BPMApps.DTO.Models;
using EleWise.ELMA.BPMApps.Services;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export.ExtensionPoints;
using EleWise.ELMA.Deploy.Services;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Export;

[Component(Order = 200)]
public class BpmAppsExportExtension : IConfigExportExtension
{
	private static BpmAppsExportExtension tXOOCWEj7Fl38PN7x8uT;

	public Dictionary<Guid, object> GetNewSettingObj()
	{
		return new Dictionary<Guid, object> { 
		{
			BpmAppsExportConsts.ExportBpmAppsUid,
			new BpmAppsExportSetting()
		} };
	}

	public void AddExportObjects(ExportExtensionParams parameters)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				AddExportObjectsCustom(parameters.Parameters, parameters.Objects, parameters.ServiceData);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private void AddExportObjectsCustom(Dictionary<Guid, object> parameters, Dictionary<IGroupedMetadata, bool> objects, Dictionary<string, object> serviceData)
	{
		if (!(parameters[BpmAppsExportConsts.ExportBpmAppsUid] is BpmAppsExportSetting bpmAppsExportSetting) || !bpmAppsExportSetting.Components.Any())
		{
			return;
		}
		_003C_003Ec__DisplayClass2_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass2_0();
		CS_0024_003C_003E8__locals0.ieFileService = Locator.GetServiceNotNull<IExportImportFileService>();
		CS_0024_003C_003E8__locals0.fromPath = CS_0024_003C_003E8__locals0.ieFileService.GetFilesFolderPath();
		CS_0024_003C_003E8__locals0.toPath = Path.Combine(CS_0024_003C_003E8__locals0.fromPath, bpmAppsExportSetting.TempId, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x463A0F3C ^ 0x463EF054));
		if (!Directory.Exists(CS_0024_003C_003E8__locals0.toPath))
		{
			Directory.CreateDirectory(CS_0024_003C_003E8__locals0.toPath);
		}
		bpmAppsExportSetting.Components.ForEach(delegate(KeyValuePair<string, BPMAppDTO> cP)
		{
			CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass2_1();
			ConfigExportSettings configExportSettings = new ConfigExportSettings
			{
				Manifest = (cP.Value.ComponentManifest ?? new ElmaStoreComponentManifest
				{
					ProductType = ManifestComponentType.ProcessPackage
				})
			};
			if (cP.Value.AppManifest != null)
			{
				foreach (IBPMAppItemsConverter extensionPoint in ComponentManager.Current.GetExtensionPoints<IBPMAppItemsConverter>())
				{
					extensionPoint.ToExportSettings(cP.Value.AppManifest, configExportSettings);
				}
				object value = null;
				if (cP.Value.Id > 0 && configExportSettings.CustomSettings.TryGetValue(FilesExportConsts.ExportExtensionUid, out value) && value is FilesExportSetting filesExportSetting)
				{
					Locator.GetServiceNotNull<IBPMAppDTOManager>().LoadFiles(cP.Value.Id, out var helpFileContent, out var additionalFilesContent);
					filesExportSetting.HelpFileContent = helpFileContent;
					filesExportSetting.AdditionalFilesContent = additionalFilesContent;
				}
			}
			if (cP.Value.IconData != null)
			{
				configExportSettings.Icon = cP.Value.IconData;
				configExportSettings.IconFileName = cP.Value.IconFileName;
			}
			CS_0024_003C_003E8__locals0.platform = Locator.GetServiceNotNull<IModuleDTOManager>().GetInstalledComponentManifests().FirstOrDefault((ElmaStoreComponentManifest m) => _003C_003Ec.Q6PmHn8xrgwKTkkopVy0(m) == ManifestComponentType.Platform);
			if (CS_0024_003C_003E8__locals0.platform != null && !configExportSettings.Manifest.Dependencies.Any((ElmaStoreComponentDependency d) => _003C_003Ec__DisplayClass2_1.diquJx8xM39Mi9QY6MqN(_003C_003Ec__DisplayClass2_1.RtNFRP8xmecvtdrDWPqH(d), _003C_003Ec__DisplayClass2_1.tyd00i8xyEkTToKbRDGo(CS_0024_003C_003E8__locals0.platform))))
			{
				configExportSettings.Manifest.Dependencies.Add(new ElmaStoreComponentDependency
				{
					Id = CS_0024_003C_003E8__locals0.platform.Id,
					ManifestVersion = ManifestValidationHelper.GetFromVersion(CS_0024_003C_003E8__locals0.platform.SemanticVersion)
				});
			}
			new ConfigExport(configExportSettings).RunExport(new RunExportParameters(Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser().GetId() as long?));
			File.Move(Path.Combine(CS_0024_003C_003E8__locals0.fromPath, configExportSettings.FileName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138161350)), Path.Combine(CS_0024_003C_003E8__locals0.toPath, configExportSettings.FileName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1637C429 ^ 0x1637B96B)));
			CS_0024_003C_003E8__locals0.ieFileService.DeleteFiles(configExportSettings.FileName);
		});
	}

	public BpmAppsExportExtension()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		QDuRGNEjmbeMZIqlWScN();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool FnEexbEjxZ3XkthmUHhB()
	{
		return tXOOCWEj7Fl38PN7x8uT == null;
	}

	internal static BpmAppsExportExtension iwxXNkEj0SOastwok2Hk()
	{
		return tXOOCWEj7Fl38PN7x8uT;
	}

	internal static void QDuRGNEjmbeMZIqlWScN()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
