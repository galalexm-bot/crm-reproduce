using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Actors;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Deploy.Import;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy.Services;

[Service]
internal sealed class ExportImportService : IExportImportService
{
	private readonly IActorModelRuntime actorModelRuntime;

	internal static ExportImportService dqjUIVE6LhrRXqTyGKT2;

	public ExportImportService(IActorModelRuntime actorModelRuntime)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		keNkCiE6cXTx0onBEAFI();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			this.actorModelRuntime = actorModelRuntime;
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
			{
				num = 1;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CTest_003Ed__2))]
	public Task<Guid> Test(IConfigImportSettings settings, string activateKey = null, bool storeSettings = false)
	{
		_003CTest_003Ed__2 stateMachine = default(_003CTest_003Ed__2);
		stateMachine._003C_003E4__this = this;
		stateMachine.settings = settings;
		stateMachine.activateKey = activateKey;
		stateMachine.storeSettings = storeSettings;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<Guid>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<Guid> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CTestModules_003Ed__3))]
	public Task<Guid> TestModules(Guid testUid, IEnumerable<IConfigImportSettings> settings, string activateKey = null, bool storeSettings = false)
	{
		_003CTestModules_003Ed__3 stateMachine = default(_003CTestModules_003Ed__3);
		stateMachine._003C_003E4__this = this;
		stateMachine.testUid = testUid;
		stateMachine.settings = settings;
		stateMachine.activateKey = activateKey;
		stateMachine.storeSettings = storeSettings;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<Guid>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<Guid> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	public Task<Guid> Import(IImportSettings settings)
	{
		return GetImportStartActor().Import(settings);
	}

	[AsyncStateMachine(typeof(_003CExport_003Ed__5))]
	public Task<Guid> Export(ConfigExportSettings settings)
	{
		_003CExport_003Ed__5 stateMachine = default(_003CExport_003Ed__5);
		stateMachine._003C_003E4__this = this;
		stateMachine.settings = settings;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<Guid>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<Guid> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CExport_003Ed__6))]
	public Task<Guid> Export(ConfigExportSettings settings, byte[] certificate, string password)
	{
		_003CExport_003Ed__6 stateMachine = default(_003CExport_003Ed__6);
		stateMachine._003C_003E4__this = this;
		stateMachine.settings = settings;
		stateMachine.certificate = certificate;
		stateMachine.password = password;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<Guid>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<Guid> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	public Task<IEnumerable<DeploySystemMessage>> GetTestSystemMessages(Guid testUid, int offset, int count = 0)
	{
		return GetTestActor().GetSystemMessages(testUid, offset, count);
	}

	public Task<IEnumerable<DeploySystemMessage>> GetImportSystemMessages(Guid importUid, int offset, int count = 0)
	{
		return GetImportExecutorActor(importUid).GetSystemMessages(offset, count);
	}

	public Task<IEnumerable<TestImportMessages>> GetTestLog(Guid testId, int offset, int count = 0)
	{
		return GetTestActor().GetLog(testId, offset, count);
	}

	public Task<IEnumerable<DeployLogMessage>> GetImportLog(Guid importUid, int offset, int count = 0)
	{
		return GetImportExecutorActor(importUid).GetLog(offset, count);
	}

	public Task<IEnumerable<DeployLogMessage>> GetExportLog(Guid exportUid, int offset, int count = 0)
	{
		return GetExportActor(exportUid).GetLog(offset, count);
	}

	public Task<Guid> GetCurrentImportId()
	{
		return GetImportStartActor().GetCurrentImportId();
	}

	public Task<Guid> ContinuedImport(IEnumerable<IConfigImportSettings> settings)
	{
		return GetImportStartActor().ContinuedImport(settings);
	}

	[AsyncStateMachine(typeof(_003CContinuedImport_003Ed__14))]
	public Task<Guid> ContinuedImport(IEnumerable<Guid> testUids)
	{
		_003CContinuedImport_003Ed__14 stateMachine = default(_003CContinuedImport_003Ed__14);
		stateMachine._003C_003E4__this = this;
		stateMachine.testUids = testUids;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<Guid>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<Guid> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CGetImportManifests_003Ed__15))]
	public Task<IEnumerable<BPMAppFakeManifest>> GetImportManifests(Guid importUid)
	{
		_003CGetImportManifests_003Ed__15 stateMachine = default(_003CGetImportManifests_003Ed__15);
		stateMachine._003C_003E4__this = this;
		stateMachine.importUid = importUid;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<IEnumerable<BPMAppFakeManifest>>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<IEnumerable<BPMAppFakeManifest>> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CGetTestManifests_003Ed__16))]
	public Task<IEnumerable<BPMAppFakeManifest>> GetTestManifests(IEnumerable<Guid> testUids)
	{
		_003CGetTestManifests_003Ed__16 stateMachine = default(_003CGetTestManifests_003Ed__16);
		stateMachine._003C_003E4__this = this;
		stateMachine.testUids = testUids;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<IEnumerable<BPMAppFakeManifest>>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<IEnumerable<BPMAppFakeManifest>> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CImportNeedRestart_003Ed__17))]
	public Task<bool> ImportNeedRestart(Guid importUid)
	{
		_003CImportNeedRestart_003Ed__17 stateMachine = default(_003CImportNeedRestart_003Ed__17);
		stateMachine._003C_003E4__this = this;
		stateMachine.importUid = importUid;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<bool>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<bool> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	public void ClearTestData(Guid testUid)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				l2QYpgE6zS3AVbR1oAN3(GetTestActor(), testUid);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CGetImportSettings_003Ed__19))]
	public Task<IEnumerable<IImportSettings>> GetImportSettings(Guid testUid)
	{
		_003CGetImportSettings_003Ed__19 stateMachine = default(_003CGetImportSettings_003Ed__19);
		stateMachine._003C_003E4__this = this;
		stateMachine.testUid = testUid;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<IEnumerable<IImportSettings>>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<IEnumerable<IImportSettings>> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	public Task<string> GetTestedAppId(Guid testUid)
	{
		return GetTestActor().GetAppId(testUid);
	}

	public Task ContinueImport()
	{
		return GetImportStartActor().ContinueImport();
	}

	private IConfigurationTestStartActor GetTestActor()
	{
		return actorModelRuntime.GetActor<IConfigurationTestStartActor>(ConfigurationTestStartActor.ActorId);
	}

	private IImportStartActor GetImportStartActor()
	{
		return actorModelRuntime.GetActor<IImportStartActor>(ImportStartActor.ActorId);
	}

	private IImportExecutorActor GetImportExecutorActor(Guid importUid)
	{
		return actorModelRuntime.GetActor<IImportExecutorActor>(importUid);
	}

	private IExportActor GetExportActor(Guid exportUid)
	{
		return actorModelRuntime.GetActor<IExportActor>(exportUid);
	}

	public Task<IContinuedImportState> GetImportState(Guid importUid)
	{
		return GetImportExecutorActor(importUid).GetImportState();
	}

	public Task<IReadOnlyCollection<Guid>> GetTestedModules()
	{
		return GetTestActor().GetTestedModules();
	}

	internal static void keNkCiE6cXTx0onBEAFI()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool kEF0J7E6U4CH2Hpm6rXc()
	{
		return dqjUIVE6LhrRXqTyGKT2 == null;
	}

	internal static ExportImportService DcoXXBE6sj84mEAdA2qf()
	{
		return dqjUIVE6LhrRXqTyGKT2;
	}

	internal static object l2QYpgE6zS3AVbR1oAN3(object P_0, Guid testUid)
	{
		return ((IConfigurationTestStartActor)P_0).Clear(testUid);
	}
}
