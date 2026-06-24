using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.Deploy.Import;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy.Actors;

internal sealed class ConfigurationTestStartActor : Actor, IConfigurationTestStartActor, IActorWithGuidKey, IActor
{
	internal static readonly Guid ActorId;

	private readonly IActorModelRuntime actorModelRuntime;

	private readonly ConcurrentDictionary<Guid, IReadOnlyCollection<Guid>> testedModules;

	private static ConfigurationTestStartActor G11vP2EcA53lAQ5MZc8o;

	public ConfigurationTestStartActor(IActorModelRuntime actorModelRuntime)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			case 2:
				this.actorModelRuntime = actorModelRuntime;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
				{
					num = 0;
				}
				break;
			default:
				testedModules = new ConcurrentDictionary<Guid, IReadOnlyCollection<Guid>>();
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public Task<IEnumerable<DeploySystemMessage>> GetSystemMessages(Guid testUid, int offset, int count)
	{
		return GetTestActor(testUid).GetSystemMessages(offset, count);
	}

	public Task<IEnumerable<TestImportMessages>> GetLog(Guid testUid, int offset, int count)
	{
		return GetTestActor(testUid).GetLog(offset, count);
	}

	public Task Clear(Guid testUid)
	{
		return (Task)SgTZoAEc00J6TB7OeUvd(GetTestActor(testUid));
	}

	public Task<IConfigImportSettings[]> GetTestedSettings(Guid testUid)
	{
		testedModules.TryRemove(testUid, out var _);
		return GetTestActor(testUid).GetTestedSettings();
	}

	public Task<string> GetAppId(Guid testUid)
	{
		return GetTestActor(testUid).GetAppId();
	}

	public Task Test(Guid testUid, IConfigImportSettings settings, string activateKey, bool storeSettings)
	{
		return (Task)Hlq36cEcmcIL38k4YbWP(GetTestActor(testUid), settings, activateKey, storeSettings);
	}

	public Task TestModules(Guid testUid, IEnumerable<IConfigImportSettings> settings, string activateKey, bool storeSettings)
	{
		List<Guid> value = (from setting in settings
			where _003C_003Ec.fYmKOP8ydAvrdl9Saumj(setting) != null
			select _003C_003Ec.BYQaIg8ylfgrJtCElvuD(setting.Manifest)).ToList();
		testedModules[testUid] = value;
		return GetTestActor(testUid).TestModules(settings, activateKey, storeSettings);
	}

	public Task<IConfigImportSettings[]> GetTestedSettingsWithCheck(Guid testUid)
	{
		return GetTestActor(testUid).GetTestedSettingsWithCheck();
	}

	public Task<BPMAppFakeManifest[]> GetFakeManifest(Guid testUid)
	{
		return GetTestActor(testUid).GetFakeManifest();
	}

	private IConfigurationTestActor GetTestActor(Guid testUid)
	{
		return actorModelRuntime.GetActor<IConfigurationTestActor>(testUid);
	}

	public Task<IReadOnlyCollection<Guid>> GetTestedModules()
	{
		return Task.FromResult((IReadOnlyCollection<Guid>)testedModules.Values.SelectMany((IReadOnlyCollection<Guid> values) => values).ToList());
	}

	static ConfigurationTestStartActor()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				EeGq2LEcyiVtK6pnPc4U();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				ActorId = Guid.Empty;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static bool RK4JHXEc7ZTtbMkRx8Y1()
	{
		return G11vP2EcA53lAQ5MZc8o == null;
	}

	internal static ConfigurationTestStartActor UsJdoHEcxx3M7DYbYOcb()
	{
		return G11vP2EcA53lAQ5MZc8o;
	}

	internal static object SgTZoAEc00J6TB7OeUvd(object P_0)
	{
		return ((IConfigurationTestActor)P_0).Clear();
	}

	internal static object Hlq36cEcmcIL38k4YbWP(object P_0, object P_1, object P_2, bool storeSettings)
	{
		return ((IConfigurationTestActor)P_0).Test((IConfigImportSettings)P_1, (string)P_2, storeSettings);
	}

	internal static void EeGq2LEcyiVtK6pnPc4U()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
