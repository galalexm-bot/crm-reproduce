using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Deploy.Services;
using EleWise.ELMA.Deploy.Utils;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata.Services;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Actors;

internal sealed class ConfigurationTestActor : Actor, IConfigurationTestActor, IActorWithGuidKey, IActor
{
	[Serializable]
	private class TestData
	{
		internal static object w1xo1a8yrnH6UKok1cM5;

		public IConfigImportSettings[] ImportSettings { get; }

		public long Timestamp { get; }

		public Version ConfigurationVersion { get; }

		public TestData(IConfigImportSettings[] importSettings, long timestamp, Version configVersion)
		{
			//Discarded unreachable code: IL_001a, IL_001f
			KFSq7X8yj4Uu5RxKAhqc();
			base._002Ector();
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 3:
					return;
				case 2:
					ImportSettings = importSettings;
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num = 1;
					}
					break;
				default:
					ConfigurationVersion = configVersion;
					num = 3;
					break;
				case 1:
					Timestamp = timestamp;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num = 0;
					}
					break;
				}
			}
		}

		internal static void KFSq7X8yj4Uu5RxKAhqc()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool Glx4iR8ygCIAuNoadGGc()
		{
			return w1xo1a8yrnH6UKok1cM5 == null;
		}

		internal static TestData KDSxjt8y5PfGyv4cDVTQ()
		{
			return (TestData)w1xo1a8yrnH6UKok1cM5;
		}
	}

	private bool isStarted;

	private CancellationTokenSource cts;

	private Task externalTask;

	private IConfigImportSettings[] testedSettings;

	private IConfigImportSettings currentSettings;

	private IConfigurationTesterInternal configurationTesterInternal;

	private long timestamp;

	private Version configurationVersion;

	private readonly IBLOBStore blobStore;

	private readonly ITimestampService timestampService;

	private readonly IConfigurationImportInternalFactory configurationImportInternalFactory;

	private readonly IModuleMetadataLoader moduleMetadataLoader;

	private readonly IModuleMetadataExtractorService moduleMetadataExtractorService;

	private bool storeSettingsInBlobStore;

	private List<TestImportMessages> testMessages;

	private List<DeploySystemMessage> systemMessages;

	internal static readonly string TestDataKey;

	private static ConfigurationTestActor ujSKONEz8dOWEte8dVDI;

	public ConfigurationTestActor(IBLOBStore blobStore, ITimestampService timestampService, IConfigurationImportInternalFactory configurationImportInternalFactory, IModuleMetadataLoader moduleMetadataLoader, IModuleMetadataExtractorService moduleMetadataExtractorService)
	{
		//Discarded unreachable code: IL_002a
		ReKIbWEzIQDmr1rgoVc8();
		base._002Ector();
		int num = 3;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
		{
			num = 3;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				this.timestampService = timestampService;
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
				{
					num = 4;
				}
				break;
			case 4:
				this.configurationImportInternalFactory = configurationImportInternalFactory;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
				{
					num = 0;
				}
				break;
			case 3:
				this.blobStore = blobStore;
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
				{
					num = 1;
				}
				break;
			case 5:
				this.moduleMetadataExtractorService = moduleMetadataExtractorService;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
				{
					num = 1;
				}
				break;
			case 1:
				return;
			default:
			{
				this.moduleMetadataLoader = moduleMetadataLoader;
				int num2 = 5;
				num = num2;
				break;
			}
			}
		}
	}

	public override Task OnActivateAsync()
	{
		//Discarded unreachable code: IL_0077, IL_011a, IL_0131, IL_0140
		int num = 3;
		int num2 = num;
		byte[] array = default(byte[]);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return (Task)Y9742lEzXZ07leyC1bwB();
			case 3:
				array = (byte[])PYulLNEzSa0h6T6tymeC(blobStore, sNwM7JEzVuwANmN2QH6x(TestDataKey, GetPrimaryKey<Guid>()));
				num2 = 2;
				break;
			default:
				try
				{
					TestData testData = (TestData)wPUrlyEziroy3e6wyiBy(array);
					int num3 = 3;
					while (true)
					{
						switch (num3)
						{
						case 1:
							timestamp = IhyMbHEzqgF8KqujqBrH(testData);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
							{
								num3 = 0;
							}
							continue;
						default:
							configurationVersion = (Version)me3E41EzKb6opWdCTBOu(testData);
							num3 = 2;
							continue;
						case 3:
							testedSettings = (IConfigImportSettings[])ObBJXBEzRoX9Zd3p6Wsn(testData);
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
							{
								num3 = 1;
							}
							continue;
						case 2:
							break;
						}
						break;
					}
				}
				catch
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto case 1;
			case 2:
				if (array != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			}
		}
	}

	[AsyncStateMachine(typeof(_003COnDeactivateAsync_003Ed__19))]
	public override Task OnDeactivateAsync()
	{
		int num = 4;
		int num2 = num;
		_003COnDeactivateAsync_003Ed__19 stateMachine = default(_003COnDeactivateAsync_003Ed__19);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			switch (num2)
			{
			default:
				return stateMachine._003C_003Et__builder.Task;
			case 5:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				stateMachine._003C_003E4__this = this;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				stateMachine._003C_003E1__state = -1;
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				_003C_003Et__builder.Start(ref stateMachine);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public Task<IEnumerable<TestImportMessages>> GetLog(int offset, int count)
	{
		if (testMessages == null)
		{
			return Task.FromResult(Enumerable.Empty<TestImportMessages>());
		}
		return Task.FromResult(DeployUtils.SafeSkip(testMessages, offset, count));
	}

	public Task<IEnumerable<DeploySystemMessage>> GetSystemMessages(int offset, int count)
	{
		if (systemMessages == null)
		{
			return Task.FromResult(Enumerable.Empty<DeploySystemMessage>());
		}
		return Task.FromResult(DeployUtils.SafeSkip(systemMessages, offset, count));
	}

	public Task Test(IConfigImportSettings settings, string activateKey, bool storeSettings)
	{
		//Discarded unreachable code: IL_018d
		int num = 10;
		_003C_003Ec__DisplayClass22_0 _003C_003Ec__DisplayClass22_ = default(_003C_003Ec__DisplayClass22_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 10:
					_003C_003Ec__DisplayClass22_ = new _003C_003Ec__DisplayClass22_0();
					num = 9;
					break;
				case 2:
					testMessages = new List<TestImportMessages>();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num2 = 3;
					}
					continue;
				case 7:
					return (Task)Y9742lEzXZ07leyC1bwB();
				case 11:
					cts = new CancellationTokenSource();
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num2 = 4;
					}
					continue;
				case 8:
					return Task.CompletedTask;
				default:
					isStarted = true;
					num = 11;
					break;
				case 3:
					systemMessages = new List<DeploySystemMessage>();
					num2 = 6;
					continue;
				case 12:
					_003C_003Ec__DisplayClass22_.activateKey = activateKey;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					storeSettingsInBlobStore = storeSettings;
					num2 = 2;
					continue;
				case 5:
					_003C_003Ec__DisplayClass22_.settings = settings;
					num2 = 12;
					continue;
				case 9:
					_003C_003Ec__DisplayClass22_._003C_003E4__this = this;
					num2 = 5;
					continue;
				case 6:
					externalTask = RunExternalTask(_003C_003Ec__DisplayClass22_._003CTest_003Eb__0);
					num = 7;
					break;
				case 1:
					if (!isStarted)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 8;
				}
				break;
			}
		}
	}

	private Task TestSingle(IConfigImportSettings settings, string activateKey)
	{
		//Discarded unreachable code: IL_009c, IL_00fe, IL_0137
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					configurationVersion = ConfigurationModelAssemblyBuilder.NextVersion;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
					{
						num2 = 2;
					}
					continue;
				case 2:
					break;
				case 4:
					return Task.CompletedTask;
				case 3:
					try
					{
						TestSettingsSync(settings, activateKey);
						int num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
						{
							num3 = 1;
						}
						while (true)
						{
							switch (num3)
							{
							case 1:
								testMessages.Add(new TestImportMessages(TestImportMessagesType.Finish));
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
								{
									num3 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
					catch
					{
						int num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								testedSettings = null;
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
								{
									num4 = 0;
								}
								break;
							default:
								throw;
							}
						}
					}
					goto case 4;
				case 1:
					timestamp = nYaGyjEzT2o1Cv7wI4oq(timestampService);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			testedSettings = new IConfigImportSettings[1] { settings };
			num = 3;
		}
	}

	private void TestSettingsSync(IConfigImportSettings settings, string activateKey)
	{
		int num = 6;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				configurationTesterInternal.BeforeAddTestMessage -= OnAddTestMessage;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
				{
					num2 = 1;
				}
				break;
			default:
				configurationTesterInternal.BeforeAddTestMessage += OnAddTestMessage;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num2 = 2;
				}
				break;
			case 5:
				configurationTesterInternal = (IConfigurationTesterInternal)A3O2j1EzkJCG2qrtdtAu(configurationImportInternalFactory, settings);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			case 4:
				configurationTesterInternal.RunTest(new RunTestParameters(activateKey, cts.Token));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				currentSettings = settings;
				num2 = 5;
				break;
			case 3:
				systemMessages.AddRange(configurationTesterInternal.GetTestSystemMessages());
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public Task TestModules(IEnumerable<IConfigImportSettings> settings, string activateKey, bool storeSettings)
	{
		_003C_003Ec__DisplayClass25_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass25_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.settings = settings;
		CS_0024_003C_003E8__locals0.activateKey = activateKey;
		if (isStarted)
		{
			return Task.CompletedTask;
		}
		isStarted = true;
		cts = new CancellationTokenSource();
		storeSettingsInBlobStore = storeSettings;
		testMessages = new List<TestImportMessages>();
		systemMessages = new List<DeploySystemMessage>();
		externalTask = RunExternalTask(() => CS_0024_003C_003E8__locals0._003C_003E4__this.TestModulesInternal(CS_0024_003C_003E8__locals0.settings, CS_0024_003C_003E8__locals0.activateKey));
		return Task.CompletedTask;
	}

	private Task TestModulesInternal(IEnumerable<IConfigImportSettings> configImportSettings, string activateKey)
	{
		timestamp = timestampService.GetTimestamp();
		configurationVersion = ConfigurationModelAssemblyBuilder.NextVersion;
		try
		{
			ModuleTester moduleTester = new ModuleTester(moduleMetadataExtractorService, moduleMetadataLoader, TestSettingsSync);
			moduleTester.MessageAdded += OnAddTestMessage;
			IReadOnlyCollection<IConfigImportSettings> source = moduleTester.TestModules(configImportSettings, activateKey);
			moduleTester.MessageAdded -= OnAddTestMessage;
			testedSettings = source.ToArray();
		}
		catch (Exception ex)
		{
			testMessages.Add(new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x20261A4F ^ 0x20231623), ex.ToString())));
		}
		testMessages.Add(new TestImportMessages(TestImportMessagesType.Finish));
		return Task.CompletedTask;
	}

	public Task<IConfigImportSettings[]> GetTestedSettingsWithCheck()
	{
		if (testedSettings == null)
		{
			return Task.FromException<IConfigImportSettings[]>(new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x463A0F3C ^ 0x463F03EA))));
		}
		byte[] array = blobStore.LoadOrNull(ImportExecutorActor.TimestampKey);
		if (array != null)
		{
			long num = BitConverter.ToInt64(array, 0);
			if (timestamp < num)
			{
				ClearTestData();
				return Task.FromException<IConfigImportSettings[]>(new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x269E5FCA ^ 0x269B52F0))));
			}
		}
		if (ConfigurationModelAssemblyBuilder.NextVersion.CompareTo(configurationVersion) != 0)
		{
			ClearTestData();
			return Task.FromException<IConfigImportSettings[]>(new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107653852))));
		}
		return Task.FromResult(testedSettings);
	}

	public Task<BPMAppFakeManifest[]> GetFakeManifest()
	{
		if (testedSettings == null)
		{
			return Task.FromResult(Array.Empty<BPMAppFakeManifest>());
		}
		return Task.FromResult(testedSettings.Select((IConfigImportSettings s) => s.FakeManifest).ToArray());
	}

	public Task Clear()
	{
		//Discarded unreachable code: IL_0045, IL_007c, IL_008f, IL_009e
		switch (1)
		{
		case 1:
			try
			{
				ClearTestData();
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}
			finally
			{
				DeactivateOnIdle();
				int num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				case 0:
					break;
				}
			}
			break;
		}
		return (Task)Y9742lEzXZ07leyC1bwB();
	}

	public Task<IConfigImportSettings[]> GetTestedSettings()
	{
		if (testedSettings == null)
		{
			return Task.FromResult(Array.Empty<IConfigImportSettings>());
		}
		return Task.FromResult(testedSettings);
	}

	public Task<string> GetAppId()
	{
		return Task.FromResult(configurationTesterInternal?.AppId);
	}

	private void ClearTestData()
	{
		//Discarded unreachable code: IL_005a
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				if (testedSettings == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 0:
				return;
			case 3:
				Md53k6Ezn5yx7jy9AymB(blobStore, sNwM7JEzVuwANmN2QH6x(TestDataKey, GetPrimaryKey<Guid>()));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				testedSettings = null;
				num2 = 4;
				break;
			case 4:
				return;
			}
		}
	}

	private void OnAddTestMessage(TestImportMessages testMessage)
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
			{
				IConfigImportSettings configImportSettings = currentSettings;
				if (configImportSettings == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num2 = 0;
					}
					break;
				}
				configImportSettings.TestResult.Add(testMessage);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
				{
					num2 = 0;
				}
				break;
			}
			case 3:
				if (ueCTpyEzOCQdmD8kETbR(testMessage) != TestImportMessagesType.Finish)
				{
					num2 = 2;
					break;
				}
				goto case 1;
			case 4:
				return;
			case 2:
				testMessages.Add(testMessage);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	static ConfigurationTestActor()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				SingletonReader.JJCZtPuTvSt();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				TestDataKey = (string)SkW0GoEz2wiae9oA7cyA(0x7EC153F ^ 0x7E918E7);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void ReKIbWEzIQDmr1rgoVc8()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool oqQwEGEzZtcuvq2gCT52()
	{
		return ujSKONEz8dOWEte8dVDI == null;
	}

	internal static ConfigurationTestActor WDlGCnEzufHSgVmZcBc1()
	{
		return ujSKONEz8dOWEte8dVDI;
	}

	internal static object sNwM7JEzVuwANmN2QH6x(object P_0, object P_1)
	{
		return string.Concat(P_0, P_1);
	}

	internal static object PYulLNEzSa0h6T6tymeC(object P_0, object P_1)
	{
		return ((IBLOBStore)P_0).LoadOrNull((string)P_1);
	}

	internal static object wPUrlyEziroy3e6wyiBy(object P_0)
	{
		return ClassSerializationHelper.DeserializeObject((byte[])P_0);
	}

	internal static object ObBJXBEzRoX9Zd3p6Wsn(object P_0)
	{
		return ((TestData)P_0).ImportSettings;
	}

	internal static long IhyMbHEzqgF8KqujqBrH(object P_0)
	{
		return ((TestData)P_0).Timestamp;
	}

	internal static object me3E41EzKb6opWdCTBOu(object P_0)
	{
		return ((TestData)P_0).ConfigurationVersion;
	}

	internal static object Y9742lEzXZ07leyC1bwB()
	{
		return Task.CompletedTask;
	}

	internal static long nYaGyjEzT2o1Cv7wI4oq(object P_0)
	{
		return ((ITimestampService)P_0).GetTimestamp();
	}

	internal static object A3O2j1EzkJCG2qrtdtAu(object P_0, object P_1)
	{
		return ((IConfigurationImportInternalFactory)P_0).CreateTester((IImportSettings)P_1);
	}

	internal static void Md53k6Ezn5yx7jy9AymB(object P_0, object P_1)
	{
		((IBLOBStore)P_0).Remove((string)P_1);
	}

	internal static TestImportMessagesType ueCTpyEzOCQdmD8kETbR(object P_0)
	{
		return ((TestImportMessages)P_0).Type;
	}

	internal static object SkW0GoEz2wiae9oA7cyA(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
