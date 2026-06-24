using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Deploy.Services;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Metadata.Services;
using EleWise.ELMA.UIBuilder.Model;

namespace EleWise.ELMA.UIBuilder.Services;

[Service]
internal sealed class InstallationChecker : IInstallationChecker
{
	private const int TestPercent = 2;

	private readonly Guid DesignerBaseModuleUid = new Guid("ca89e936-cd0b-4dd2-b7bc-1b697365c60d");

	private readonly IModuleMetadataLoader moduleMetadataLoader;

	private readonly IExportImportService exportImportService;

	public InstallationChecker(IExportImportService exportImportService, IModuleMetadataLoader moduleMetadataLoader)
	{
		this.exportImportService = exportImportService;
		this.moduleMetadataLoader = moduleMetadataLoader;
	}

	public async Task<InstallationState> GetDesignerInstallationState()
	{
		Guid guid = await exportImportService.GetCurrentImportId();
		if (guid == Guid.Empty)
		{
			return InstallationState.NotStarted();
		}
		IContinuedImportState continuedImportState = await exportImportService.GetImportState(guid);
		if (continuedImportState == null || continuedImportState.InitialSettingsCount == 0 || continuedImportState.SettingsList.Count == 0)
		{
			return InstallationState.NotStarted();
		}
		ISet<Guid> designerModules = ModuleMetadataItemHeaderManager.DesignerModules;
		int num = continuedImportState.SettingsList.Count((IConfigImportSettings m) => m.Manifest != null && designerModules.Contains(m.Manifest.ModuleUid));
		if (num == 0)
		{
			return InstallationState.NotStarted();
		}
		return InstallationState.Running((continuedImportState.InitialSettingsCount - num) * 98 / continuedImportState.InitialSettingsCount + 2);
	}

	public async Task<InstallationState> GetDesignerTestState()
	{
		if (moduleMetadataLoader.GetModuleVersionHeaders(DesignerBaseModuleUid).Count != 0)
		{
			return InstallationState.NotStarted();
		}
		IReadOnlyCollection<Guid> source = await exportImportService.GetTestedModules();
		ISet<Guid> designerModules = ModuleMetadataItemHeaderManager.DesignerModules;
		if (source.Any((Guid moduleUid) => designerModules.Contains(moduleUid)))
		{
			return InstallationState.Testing(2);
		}
		return InstallationState.NotStarted();
	}
}
