using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Services;
using EleWise.ELMA.Files;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata.Services;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Runtime.NH;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Import.Modules;

[Service]
internal sealed class ModuleFileDeployService : IModuleFileDeployService, IModuleFileDeployServiceExtended
{
	private static readonly ILogger deployLog;

	private readonly IConfigurationUnpackService configurationUnpackService;

	private readonly IExportImportService exportImportService;

	private readonly IModuleManager moduleManager;

	private readonly IModuleMetadataLoader moduleMetadataLoader;

	internal static ModuleFileDeployService lE90MqEMtBeUECcTVxdS;

	public ModuleFileDeployService(IConfigurationUnpackService configurationUnpackService, IExportImportService exportImportService, IModuleManager moduleManager, IModuleMetadataLoader moduleMetadataLoader)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 4:
				this.moduleMetadataLoader = moduleMetadataLoader;
				num = 2;
				break;
			default:
				this.moduleManager = moduleManager;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
				{
					num = 4;
				}
				break;
			case 3:
				this.configurationUnpackService = configurationUnpackService;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
				{
					num = 1;
				}
				break;
			case 1:
				this.exportImportService = exportImportService;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
				{
					num = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	public bool IsModule(IReadOnlyCollection<IConfigImportSettings> importSettings)
	{
		ILogger logger = deployLog;
		try
		{
			ValidateImportSettings(importSettings, logger);
		}
		catch (ModuleValidationException)
		{
			return false;
		}
		catch (Exception exception)
		{
			logger.Error(exception, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1335287069)));
			throw;
		}
		return true;
	}

	public bool HasModules(IReadOnlyCollection<IConfigImportSettings> importSettings)
	{
		ILogger logger = deployLog;
		bool result = false;
		try
		{
			foreach (IConfigImportSettings importSetting in importSettings)
			{
				ElmaStoreComponentManifest manifest = importSetting.Manifest;
				if (manifest != null && manifest.ProductType == ManifestComponentType.Module && importSetting.Manifest?.ModuleUid != Guid.Empty)
				{
					ValidateImportSettings((IReadOnlyCollection<IConfigImportSettings>)(object)new IConfigImportSettings[1] { importSetting }, logger);
					result = true;
				}
			}
			return result;
		}
		catch (ModuleValidationException)
		{
			return false;
		}
		catch (Exception exception)
		{
			logger.Error(exception, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420525622)));
			throw;
		}
	}

	[AsyncStateMachine(typeof(_003CDeploy_003Ed__8))]
	public Task Deploy(BinaryFile container, ILogger logger)
	{
		int num = 3;
		int num2 = num;
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		_003CDeploy_003Ed__8 stateMachine = default(_003CDeploy_003Ed__8);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Et__builder.Start(ref stateMachine);
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
				{
					num2 = 2;
				}
				break;
			default:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				stateMachine._003C_003E1__state = -1;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				stateMachine._003C_003Et__builder = mrNkDgEM6ilh66ryuDST();
				num2 = 5;
				break;
			case 6:
				stateMachine.logger = logger;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
				{
					num2 = 4;
				}
				break;
			case 2:
				stateMachine.container = container;
				num2 = 6;
				break;
			case 3:
				stateMachine._003C_003E4__this = this;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
				{
					num2 = 2;
				}
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			}
		}
	}

	public Task<IEnumerable<Guid>> Test(IReadOnlyCollection<IConfigImportSettings> importSettings)
	{
		Contract.ArgumentNotNull(importSettings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3CE17B75 ^ 0x3CE5C44B));
		return DoTest(importSettings, deployLog);
	}

	[AsyncStateMachine(typeof(_003CImport_003Ed__10))]
	public Task Import(IReadOnlyCollection<IConfigImportSettings> importSettings)
	{
		_003CImport_003Ed__10 stateMachine = default(_003CImport_003Ed__10);
		stateMachine._003C_003E4__this = this;
		stateMachine.importSettings = importSettings;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CDoDeploy_003Ed__11))]
	private Task DoDeploy(IReadOnlyCollection<IConfigImportSettings> importSettings, ILogger logger)
	{
		_003CDoDeploy_003Ed__11 stateMachine = default(_003CDoDeploy_003Ed__11);
		stateMachine._003C_003E4__this = this;
		stateMachine.importSettings = importSettings;
		stateMachine.logger = logger;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	private Task<IEnumerable<Guid>> DoTest(IReadOnlyCollection<IConfigImportSettings> importSettings, ILogger logger)
	{
		_003C_003Ec__DisplayClass12_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass12_0();
		CS_0024_003C_003E8__locals0.importSettings = importSettings;
		CS_0024_003C_003E8__locals0.importer = new Importer(exportImportService, moduleManager, moduleMetadataLoader, logger);
		CS_0024_003C_003E8__locals0.testUid = Guid.NewGuid();
		Task.Run(delegate
		{
			using (CallContextSessionOwner.Create())
			{
				return CS_0024_003C_003E8__locals0.importer.TestImport(CS_0024_003C_003E8__locals0.testUid, CS_0024_003C_003E8__locals0.importSettings, clearAfterTest: false);
			}
		});
		return Task.FromResult((IEnumerable<Guid>)new Guid[1] { CS_0024_003C_003E8__locals0.testUid });
	}

	[AsyncStateMachine(typeof(_003CDoImport_003Ed__13))]
	private Task DoImport(IReadOnlyCollection<IConfigImportSettings> importSettings, ILogger logger)
	{
		_003CDoImport_003Ed__13 stateMachine = default(_003CDoImport_003Ed__13);
		stateMachine._003C_003E4__this = this;
		stateMachine.importSettings = importSettings;
		stateMachine.logger = logger;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	private void ValidateImportSettings(IReadOnlyCollection<IConfigImportSettings> configImportSettings, ILogger logger)
	{
		logger.Info(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1765851862 ^ -1766096268)));
		new Validator(logger).Validate(configImportSettings);
		logger.Info(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CACA3 ^ 0x5381347)));
	}

	static ModuleFileDeployService()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				deployLog = Logger.GetLogger((string)iNCdsREMA1QHmeKxBn0V(0x3630F361 ^ 0x36347E87));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			case 1:
				zcQ9NBEMHKPAPOyxhDv9();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool XYTob4EMwsA86neccIJq()
	{
		return lE90MqEMtBeUECcTVxdS == null;
	}

	internal static ModuleFileDeployService UG3PPLEM4oCXMSMpWgXl()
	{
		return lE90MqEMtBeUECcTVxdS;
	}

	internal static AsyncTaskMethodBuilder mrNkDgEM6ilh66ryuDST()
	{
		return AsyncTaskMethodBuilder.Create();
	}

	internal static void zcQ9NBEMHKPAPOyxhDv9()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object iNCdsREMA1QHmeKxBn0V(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
