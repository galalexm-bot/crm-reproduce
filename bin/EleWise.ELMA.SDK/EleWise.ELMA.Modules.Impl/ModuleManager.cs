using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Licensing;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Modules.Attributes;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Remoting;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using NuGet;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Modules.Impl;

internal class ModuleManager : IModuleManager
{
	private static class DbModuleStatuses
	{
		public static class Fields
		{
			public const string ModuleUid = "ModuleUid";

			public const string ModuleStatus = "ModuleStatus";
		}
	}

	private static class DbStoreComponentConfigurationInfo
	{
		public static class Fields
		{
			public const string Id = "Id";

			public const string Title = "Title";

			public const string Version = "Version";

			public const string Status = "Status";

			public const string DeployVersion = "DeployVersion";

			public const string DeployStatus = "DeployStatus";

			public const string Manifest = "Manifest";

			public const string Signatures = "Signatures";
		}
	}

	internal class StoreComponentConfigurationInfo
	{
		private IModuleManager _owner;

		internal static StoreComponentConfigurationInfo zSTCKxfMLw4ViXSiigTu;

		public string Id
		{
			[CompilerGenerated]
			get
			{
				return _003CId_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
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
						_003CId_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public string Title
		{
			[CompilerGenerated]
			get
			{
				return _003CTitle_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
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
						_003CTitle_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public string Version
		{
			[CompilerGenerated]
			get
			{
				return _003CVersion_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
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
						_003CVersion_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public StoreComponentStatus Status
		{
			[CompilerGenerated]
			get
			{
				return _003CStatus_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
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
						_003CStatus_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public string DeployVersion
		{
			[CompilerGenerated]
			get
			{
				return _003CDeployVersion_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
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
						_003CDeployVersion_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public SemanticVersion SemanticDeployVersion
		{
			get
			{
				//Discarded unreachable code: IL_004c, IL_007e, IL_00b6, IL_00c5
				//IL_002b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0032: Expected O, but got Unknown
				SemanticVersion val = default(SemanticVersion);
				switch (1)
				{
				case 1:
					try
					{
						val = new SemanticVersion(DeployVersion);
						int num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
						{
							num = 0;
						}
						return (SemanticVersion)(num switch
						{
							0 => val, 
							_ => val, 
						});
					}
					catch (Exception)
					{
						int num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
						{
							num2 = 0;
						}
						while (true)
						{
							switch (num2)
							{
							case 1:
								return val;
							}
							val = null;
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
							{
								num2 = 1;
							}
						}
					}
				default:
					return val;
				}
			}
			set
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
						DeployVersion = ((object)value).ToString();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public AutoDeployComponentStatus DeployStatus
		{
			[CompilerGenerated]
			get
			{
				return _003CDeployStatus_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
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
						_003CDeployStatus_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public ElmaStoreComponentManifest Manifest
		{
			[CompilerGenerated]
			get
			{
				return _003CManifest_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
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
						_003CManifest_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public IEnumerable<StoreComponentSignatureInfo> Signatures { get; set; }

		public ILicensedUnit LicensedUnit
		{
			[CompilerGenerated]
			get
			{
				return _003CLicensedUnit_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
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
						_003CLicensedUnit_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public StoreComponentConfigurationInfo(IModuleManager owner)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			HrJqJffMcUInH8nFPFyt();
			base._002Ector();
			int num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 1:
					_owner = owner;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		public StoreComponentConfigurationInfo(IModuleManager owner, ElmaStoreComponentManifest manifest, IEnumerable<StoreComponentSignatureInfo> signatures, StoreComponentStatus status)
		{
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			_owner = owner;
			if (manifest == null)
			{
				throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7247028A ^ 0x72477C8C));
			}
			Id = manifest.Id;
			Title = manifest.Title;
			Version = manifest.Version;
			Manifest = manifest;
			Signatures = signatures;
			InitLicensedUnit();
		}

		public void InitLicensedUnit()
		{
			//Discarded unreachable code: IL_0096, IL_00a5, IL_00d1, IL_00e0, IL_00eb, IL_0195, IL_01a8, IL_01b7, IL_01c7
			int num = 5;
			List<string>.Enumerator enumerator = default(List<string>.Enumerator);
			string current = default(string);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						fI9djgfJGY3VQ4on4rEs(LicensedUnit);
						num2 = 10;
						continue;
					case 6:
						return;
					case 8:
						return;
					case 10:
						return;
					case 3:
						if (!Signatures.Any())
						{
							goto end_IL_0012;
						}
						goto case 9;
					case 7:
						if (Signatures == null)
						{
							return;
						}
						num2 = 3;
						continue;
					case 4:
						if (NpG3FHfMzlDbEcy8Fa3c(Manifest) != ElmaStoreComponentActivationType.Paid)
						{
							return;
						}
						num2 = 7;
						continue;
					case 1:
						try
						{
							while (true)
							{
								int num3;
								if (!enumerator.MoveNext())
								{
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
									{
										num3 = 1;
									}
									goto IL_00ef;
								}
								goto IL_0146;
								IL_0146:
								current = enumerator.Current;
								num3 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
								{
									num3 = 0;
								}
								goto IL_00ef;
								IL_00ef:
								while (true)
								{
									switch (num3)
									{
									case 2:
										X0L9tnfJhWKUo6qsGdwO(LicensedUnit, current);
										num3 = 3;
										continue;
									case 3:
										break;
									default:
										goto IL_0146;
									case 1:
										goto end_IL_0120;
									}
									break;
								}
								continue;
								end_IL_0120:
								break;
							}
						}
						finally
						{
							((IDisposable)enumerator).Dispose();
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
							{
								num4 = 0;
							}
							switch (num4)
							{
							case 0:
								break;
							}
						}
						goto default;
					case 5:
						if (Manifest == null)
						{
							return;
						}
						num2 = 4;
						continue;
					case 9:
						if (!qQ0kR6fJFud9pskTNtQd())
						{
							num2 = 8;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
							{
								num2 = 6;
							}
							continue;
						}
						break;
					case 2:
						break;
					}
					List<string> list = (from p in ((ComponentManager)Xo0xyEfJBqYqton5XF9a()).LicenseManager.GetActivationKeys()
						select p.Value).ToList();
					LicensedUnit = new RSALicensedUnit(NeKl84fJWAHMY8Gtr8kE(Manifest), (string)eq2VdafJofGYGpx0xeWF(Manifest), (string)gO6qPXfJbwZlmhhGLJQV(Manifest), Signatures.Select((StoreComponentSignatureInfo s) => s.ComponentCertificate).ToArray(), _owner.GetMainLicensedUnitExpiration);
					enumerator = list.GetEnumerator();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num2 = 1;
					}
					continue;
					end_IL_0012:
					break;
				}
				num = 6;
			}
		}

		public override string ToString()
		{
			return Id + (string)SZXWgqfJEpSQniLSmSgm(0x4EA5403C ^ 0x4EA5091E) + Version;
		}

		internal static void HrJqJffMcUInH8nFPFyt()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool sfPHY9fMUEKVJRlftmdK()
		{
			return zSTCKxfMLw4ViXSiigTu == null;
		}

		internal static StoreComponentConfigurationInfo Qu71AQfMsaB8GvG6gL3V()
		{
			return zSTCKxfMLw4ViXSiigTu;
		}

		internal static ElmaStoreComponentActivationType NpG3FHfMzlDbEcy8Fa3c(object P_0)
		{
			return ((ElmaStoreComponentManifest)P_0).ActivationType;
		}

		internal static bool qQ0kR6fJFud9pskTNtQd()
		{
			return ComponentManager.Initialized;
		}

		internal static object Xo0xyEfJBqYqton5XF9a()
		{
			return ComponentManager.Current;
		}

		internal static Guid NeKl84fJWAHMY8Gtr8kE(object P_0)
		{
			return ((ElmaStoreComponentManifest)P_0).GetUid();
		}

		internal static object eq2VdafJofGYGpx0xeWF(object P_0)
		{
			return ((ElmaStoreComponentManifest)P_0).Id;
		}

		internal static object gO6qPXfJbwZlmhhGLJQV(object P_0)
		{
			return ((ElmaStoreComponentManifest)P_0).Version;
		}

		internal static void X0L9tnfJhWKUo6qsGdwO(object P_0, object P_1)
		{
			((ILicensedUnit)P_0).ApplyActivationKey((string)P_1);
		}

		internal static void fI9djgfJGY3VQ4on4rEs(object P_0)
		{
			((ILicensedUnit)P_0).CompleteLicensingInitialize();
		}

		internal static object SZXWgqfJEpSQniLSmSgm(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}
	}

	private readonly ITransformationProvider transformationProvider;

	private readonly PackageService packageService;

	private Application mainApplication;

	private ConcurrentDictionary<string, IApplicationUnit> unitsById;

	private ConcurrentDictionary<string, IModule> modulesById;

	private ConcurrentDictionary<Guid, IApplicationUnit> unitsByUid;

	private ConcurrentDictionary<Guid, IModule> modulesByUid;

	private ConcurrentDictionary<Assembly, ModuleAssembly> assemblies;

	private ConcurrentDictionary<Assembly, Tuple<bool, ModuleDisabledReason>> assemblyAvailability;

	private Dictionary<Guid, ModuleStatus> serverModuleStatuses;

	private List<string> requiredModuleNames;

	private Dictionary<Guid, ModuleStatus> savedModulesStatuses;

	private List<StoreComponentConfigurationInfo> installedStoreComponentInfos;

	private IEnumerable<string> activatedModules;

	private List<IStoreComponentInfo> infoToUpdateInDB;

	private static readonly ILogger log;

	private readonly DbPreUpdater dbPreUpdater;

	private static ModuleManager bstp4K34ECorWvCd3sT;

	public IApplication MainApplication => mainApplication;

	public ILicensedUnit MainLicensedUnit
	{
		get
		{
			int num = 1;
			int num2 = num;
			object obj;
			while (true)
			{
				switch (num2)
				{
				case 1:
					obj = BVcm5i3AuIFiiyn3CWX(mainApplication);
					if (obj == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					obj = mainApplication;
					break;
				}
				break;
			}
			return (ILicensedUnit)obj;
		}
	}

	internal ModuleManager(IEnumerable<Assembly> assemblies, PackageService packageService, RemoteServiceProvider remoteServiceProvider, IRuntimeApplication runtimeApplication)
	{
		SingletonReader.JJCZtPuTvSt();
		unitsById = new ConcurrentDictionary<string, IApplicationUnit>();
		modulesById = new ConcurrentDictionary<string, IModule>();
		unitsByUid = new ConcurrentDictionary<Guid, IApplicationUnit>();
		modulesByUid = new ConcurrentDictionary<Guid, IModule>();
		this.assemblies = new ConcurrentDictionary<Assembly, ModuleAssembly>();
		assemblyAvailability = new ConcurrentDictionary<Assembly, Tuple<bool, ModuleDisabledReason>>();
		requiredModuleNames = new List<string>();
		savedModulesStatuses = new Dictionary<Guid, ModuleStatus>();
		installedStoreComponentInfos = new List<StoreComponentConfigurationInfo>();
		infoToUpdateInDB = new List<IStoreComponentInfo>();
		base._002Ector();
		_003C_003Ec__DisplayClass0_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass0_0();
		if (assemblies == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107983460));
		}
		if (packageService == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088307646));
		}
		this.packageService = packageService;
		if (remoteServiceProvider != null)
		{
			ServerInfoManager serviceWithoutProxy = remoteServiceProvider.GetServiceWithoutProxy<ServerInfoManager>();
			if (serviceWithoutProxy != null)
			{
				ModuleStatusInfo[] moduleStatuses = serviceWithoutProxy.GetModuleStatuses();
				serverModuleStatuses = new Dictionary<Guid, ModuleStatus>();
				ModuleStatusInfo[] array = moduleStatuses;
				foreach (ModuleStatusInfo moduleStatusInfo in array)
				{
					serverModuleStatuses[moduleStatusInfo.Uid] = moduleStatusInfo.Status;
				}
			}
		}
		if (runtimeApplication != null)
		{
			dbPreUpdater = runtimeApplication.DbPreUpdater;
			requiredModuleNames.AddRange(dbPreUpdater.GetAssemblyModelNames().Where(delegate(string n)
			{
				//Discarded unreachable code: IL_0050, IL_005f
				int num3 = 1;
				int num4 = num3;
				while (true)
				{
					switch (num4)
					{
					case 2:
						return !_003C_003Ec.XgqvosfJIrWclnXP30C2(n, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-561074844 ^ -561076406), StringComparison.CurrentCultureIgnoreCase);
					default:
						return false;
					case 1:
						if (_003C_003Ec.XgqvosfJIrWclnXP30C2(n, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7459E02 ^ 0x7459466), StringComparison.CurrentCultureIgnoreCase))
						{
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
							{
								num4 = 0;
							}
							break;
						}
						goto case 2;
					}
				}
			}));
			transformationProvider = runtimeApplication.TransformationProvider;
			LoadSavedModuleStatuses();
			LoadStoreComponentConfigurationInfos();
			activatedModules = dbPreUpdater.GetActivatedModules();
		}
		string text = AppDomain.CurrentDomain.BaseDirectory;
		if (string.IsNullOrEmpty(text) && AppDomain.CurrentDomain.SetupInformation.ConfigurationFile != null)
		{
			text = Path.GetDirectoryName(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
		}
		Dictionary<Guid, Module> dictionary = new Dictionary<Guid, Module>();
		List<ModuleAssembly> list = new List<ModuleAssembly>();
		foreach (Assembly assembly in assemblies)
		{
			Logger.Log.InfoFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-289714582 ^ -289719344), assembly.FullName, assembly.CodeBase);
			AssemblyLicenseUnitAttribute assemblyLicenseUnitAttribute;
			try
			{
				assemblyLicenseUnitAttribute = assembly.GetCustomAttributes(typeof(AssemblyLicenseUnitAttribute), inherit: false).Cast<AssemblyLicenseUnitAttribute>().Where(delegate(AssemblyLicenseUnitAttribute a)
				{
					//Discarded unreachable code: IL_003d, IL_004c
					int num = 2;
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						default:
							return _003C_003Ec.uYglVbfJViIFyaDw3iYZ(_003C_003Ec.Eb5w7GfJSlwI2HCQ3kHU()) == (ComponentType)0;
						case 1:
							return true;
						case 2:
							if ((a.ComponentType & _003C_003Ec.uYglVbfJViIFyaDw3iYZ(ComponentManager.Current)) != 0)
							{
								num2 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
								{
									num2 = 0;
								}
								break;
							}
							goto default;
						}
					}
				})
					.FirstOrDefault();
			}
			catch (Exception innerException)
			{
				throw new InvalidOperationException(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x10E41EDB ^ 0x10E46B15), assembly.FullName), innerException);
			}
			ModuleAssembly moduleAssembly = ((assemblyLicenseUnitAttribute != null) ? new LicensedModuleAssembly(assembly, assemblyLicenseUnitAttribute) : new ModuleAssembly(assembly));
			list.Add(moduleAssembly);
			RegisterUnit(moduleAssembly);
			if (AttributeHelper<ModuleAttribute>.GetAttribute(assembly) != null)
			{
				ModuleInfoMetadata moduleInfoMetadata = new ModuleInfoMetadata();
				moduleInfoMetadata.LoadFromAssembly(assembly);
				Module module = new Module(moduleInfoMetadata, moduleAssembly);
				dictionary[module.Uid] = module;
				RegisterUnit(module);
			}
			this.assemblies[assembly] = moduleAssembly;
		}
		CS_0024_003C_003E8__locals0.processedModuleAssemblies = new List<ModuleAssembly>();
		foreach (ModuleAssembly item in list)
		{
			if (dictionary.TryGetValue(item.ModuleUid, out var value))
			{
				value.AddAssembly(item);
				item.Owner = value;
				CS_0024_003C_003E8__locals0.processedModuleAssemblies.Add(item);
			}
		}
		list.RemoveAll((ModuleAssembly a) => CS_0024_003C_003E8__locals0.processedModuleAssemblies.Contains(a));
		string text2 = ((!string.IsNullOrEmpty(text)) ? Path.Combine(text, z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 0x548BD8A8)) : null);
		ApplicationDescriptor applicationDescriptor = null;
		if (text2 != null && File.Exists(text2))
		{
			try
			{
				applicationDescriptor = ClassSerializationHelper.DeserializeObjectByXml<ApplicationDescriptor>(File.ReadAllBytes(text2));
			}
			catch (Exception exception)
			{
				Logger.Log.Error(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A5D5EF ^ 0x3A5A3AB) + text2, exception);
			}
		}
		if (applicationDescriptor == null)
		{
			applicationDescriptor = new ApplicationDescriptor
			{
				Uid = Guid.NewGuid(),
				Id = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-889460160 ^ -889479966),
				Title = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1411196499 ^ -1411207407))
			};
		}
		CS_0024_003C_003E8__locals0.processedModules = new List<Module>();
		Module module2 = ((applicationDescriptor.MainModule != null) ? FindModule(dictionary.Values, applicationDescriptor.MainModule) : null);
		if (module2 != null)
		{
			CS_0024_003C_003E8__locals0.processedModules.Add(module2);
		}
		object obj;
		if (applicationDescriptor.MainLicensedUnit == null)
		{
			obj = null;
		}
		else
		{
			ILicensedUnit licensedUnit = FindModule(dictionary.Values, applicationDescriptor.MainLicensedUnit);
			obj = licensedUnit;
		}
		ILicensedUnit mainLicensedUnit = (ILicensedUnit)obj;
		mainApplication = new Application(applicationDescriptor, module2, mainLicensedUnit);
		RegisterUnit(mainApplication);
		if (applicationDescriptor.Modules != null)
		{
			foreach (ApplicationDescriptor.ModuleReference module4 in applicationDescriptor.Modules)
			{
				Module module3 = FindModule(dictionary.Values, module4);
				if (module3 != null && !CS_0024_003C_003E8__locals0.processedModules.Contains(module3))
				{
					module3.Owner = mainApplication;
					mainApplication.AddSystemModule(module3);
					CS_0024_003C_003E8__locals0.processedModules.Add(module3);
				}
			}
		}
		foreach (Module item2 in dictionary.Values.Where((Module m1) => !CS_0024_003C_003E8__locals0.processedModules.Contains(m1)))
		{
			mainApplication.AddExtensionModule(item2);
			CS_0024_003C_003E8__locals0.processedModules.Add(item2);
		}
	}

	public DateTime? GetMainLicensedUnitExpiration()
	{
		if (MainApplication is ILicensedUnit licensedUnit)
		{
			if (!(licensedUnit.GetLicenseInfo() is ITrialLicenseInfo trialLicenseInfo))
			{
				return null;
			}
			return trialLicenseInfo.TrialExpiration;
		}
		return null;
	}

	public IApplicationUnit FindUnitById(string id)
	{
		int num = 1;
		int num2 = num;
		IApplicationUnit value = default(IApplicationUnit);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (unitsById.TryGetValue(id, out value))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return null;
			default:
				return value;
			}
		}
	}

	public IApplicationUnit FindUnitByUid(Guid uid)
	{
		//Discarded unreachable code: IL_005f, IL_006e
		int num = 1;
		int num2 = num;
		IApplicationUnit value = default(IApplicationUnit);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!unitsByUid.TryGetValue(uid, out value))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return value;
			default:
				return null;
			}
		}
	}

	public IModule FindModuleById(string id)
	{
		int num = 1;
		int num2 = num;
		IModule value = default(IModule);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (modulesById.TryGetValue(id, out value))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num2 = 0;
					}
					break;
				}
				return null;
			default:
				return value;
			}
		}
	}

	public bool IsAssemblyAvailable(Assembly assembly)
	{
		ModuleDisabledReason disabledReason;
		return IsAssemblyAvailable(assembly, out disabledReason);
	}

	public bool IsAssemblyAvailable(Assembly assembly, out ModuleDisabledReason disabledReason)
	{
		int num = 1;
		int num2 = num;
		Stack<Assembly> checkStack = default(Stack<Assembly>);
		while (true)
		{
			switch (num2)
			{
			case 1:
				checkStack = new Stack<Assembly>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return IsAssemblyAvailable(assembly, checkStack, out disabledReason);
			}
		}
	}

	private bool IsAssemblyAvailable(Assembly assembly, Stack<Assembly> checkStack, out ModuleDisabledReason disabledReason)
	{
		disabledReason = ModuleDisabledReason.Unknown;
		if (assembly == null)
		{
			return false;
		}
		if (checkStack == null)
		{
			checkStack = new Stack<Assembly>();
		}
		if (checkStack.Contains(assembly))
		{
			return true;
		}
		if (assemblyAvailability.TryGetValue(assembly, out var value))
		{
			disabledReason = value.Item2;
			return value.Item1;
		}
		lock (assemblyAvailability)
		{
			if (assemblyAvailability.TryGetValue(assembly, out value))
			{
				disabledReason = value.Item2;
				return value.Item1;
			}
			if (!assemblies.TryGetValue(assembly, out var value2))
			{
				assemblyAvailability[assembly] = new Tuple<bool, ModuleDisabledReason>(item1: true, ModuleDisabledReason.Unknown);
				return true;
			}
			for (IApplicationUnit owner = value2.Owner; owner != null; owner = owner.Owner)
			{
				if (owner is IModule module && module.Status != ModuleStatus.Enabled)
				{
					disabledReason = module.DisabledReason;
					assemblyAvailability[assembly] = new Tuple<bool, ModuleDisabledReason>(item1: false, disabledReason);
					log.WarnFormat(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5A4C7B29 ^ 0x5A4C0DFD)), value2.Assembly.FullName, module.Title, disabledReason.ToString());
					return false;
				}
			}
			checkStack.Push(assembly);
			AssemblyName[] referencedAssemblies = assembly.GetReferencedAssemblies();
			for (int i = 0; i < referencedAssemblies.Length; i++)
			{
				_003C_003Ec__DisplayClass11_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass11_0();
				CS_0024_003C_003E8__locals0.refAsmName = referencedAssemblies[i];
				if (!(CS_0024_003C_003E8__locals0.refAsmName.FullName == assembly.FullName))
				{
					Assembly assembly2 = AppDomain.CurrentDomain.GetAssemblies().FirstOrDefault((Assembly a) => _003C_003Ec__DisplayClass11_0.nk2Wy1fJ756mOX87aa8x(ComponentManager.GetAssemblyShortName(a), _003C_003Ec__DisplayClass11_0.gEANmjfJAkSfRZI0keI6(CS_0024_003C_003E8__locals0.refAsmName)));
					if (assembly2 != null && !IsAssemblyAvailable(assembly2, checkStack, out disabledReason))
					{
						disabledReason = ModuleDisabledReason.Dependency;
						assemblyAvailability[assembly] = new Tuple<bool, ModuleDisabledReason>(item1: false, ModuleDisabledReason.Dependency);
						log.WarnFormat(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398682574)), assembly.FullName, assembly2.FullName);
						checkStack.Pop();
						return false;
					}
				}
			}
			assemblyAvailability[assembly] = new Tuple<bool, ModuleDisabledReason>(item1: true, ModuleDisabledReason.Unknown);
			checkStack.Pop();
			return true;
		}
	}

	public IModule FindModuleByAssembly(Assembly assembly)
	{
		//Discarded unreachable code: IL_0114, IL_0123
		int num = 2;
		int num2 = num;
		IApplicationUnit applicationUnit = default(IApplicationUnit);
		IModule module = default(IModule);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return null;
			case 8:
				return null;
			default:
				if (applicationUnit != null)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 8;
			case 2:
			{
				if (assemblies.TryGetValue(assembly, out var value))
				{
					applicationUnit = value.Owner;
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
					{
						num2 = 1;
					}
				}
				else
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num2 = 1;
					}
				}
				break;
			}
			case 3:
			case 4:
				module = applicationUnit as IModule;
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
				{
					num2 = 5;
				}
				break;
			case 5:
				if (module != null)
				{
					num2 = 7;
					break;
				}
				applicationUnit = (IApplicationUnit)y9Rw7s37vtuqDCQyife(applicationUnit);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 0;
				}
				break;
			case 7:
				return module;
			}
		}
	}

	public void SaveStartedModuleInfos()
	{
		//Discarded unreachable code: IL_0056, IL_0065, IL_0070, IL_0116, IL_0129, IL_0138
		int num = 2;
		int num2 = num;
		List<IStoreComponentInfo>.Enumerator enumerator = default(List<IStoreComponentInfo>.Enumerator);
		IStoreComponentInfo current = default(IStoreComponentInfo);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				enumerator = infoToUpdateInDB.GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 1:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
							{
								num3 = 0;
							}
							goto IL_0074;
						}
						goto IL_00d7;
						IL_00d7:
						current = enumerator.Current;
						num3 = 2;
						goto IL_0074;
						IL_0074:
						while (true)
						{
							switch (num3)
							{
							case 1:
								return;
							case 3:
								break;
							case 2:
								SaveStoreComponentInfo(current, StoreComponentStatus.Active);
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
								{
									num3 = 3;
								}
								continue;
							default:
								goto IL_00d7;
							}
							break;
						}
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
			}
		}
	}

	internal void UpdateModuleStatuses()
	{
		//Discarded unreachable code: IL_0089, IL_00b1, IL_00d0, IL_00df, IL_010c, IL_011b
		int num = 1;
		int num2 = num;
		IStartInformation startInformation = default(IStartInformation);
		while (true)
		{
			switch (num2)
			{
			case 1:
				startInformation = (IStartInformation)xd3TkY30TRJgcA0Gcwk(90.0, viBoOG3xGktHcXIjbKZ(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -882137454)));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return;
			}
			try
			{
				ExecuteUpdateModuleStatuses();
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
				{
					num3 = 0;
				}
				switch (num3)
				{
				case 0:
					break;
				}
				return;
			}
			finally
			{
				int num4;
				if (startInformation == null)
				{
					num4 = 2;
					goto IL_00b5;
				}
				goto IL_00ea;
				IL_00b5:
				switch (num4)
				{
				case 2:
					goto end_IL_00a0;
				case 1:
					goto end_IL_00a0;
				}
				goto IL_00ea;
				IL_00ea:
				iuHeM53mWnmLRYCDxGL(startInformation);
				num4 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
				{
					num4 = 1;
				}
				goto IL_00b5;
				end_IL_00a0:;
			}
		}
	}

	internal void ExecuteUpdateModuleStatuses()
	{
		//Discarded unreachable code: IL_013f, IL_0177, IL_01a7, IL_01b6, IL_01c2, IL_032b, IL_0363, IL_0382, IL_0391, IL_03be, IL_0423, IL_0466, IL_0475, IL_04f7, IL_0578, IL_0587, IL_0600, IL_0638, IL_0670, IL_0705, IL_0773, IL_0781, IL_07e0, IL_0837, IL_0891, IL_08a0, IL_0933, IL_096b, IL_09d5, IL_0a0d, IL_0a4d, IL_0a5c, IL_0a68, IL_0aa8, IL_0ad0, IL_0b10, IL_0b1f, IL_0b2b, IL_0b6e, IL_0bd0, IL_0c08
		int num = 40;
		IElmaComponent elmaComponent = default(IElmaComponent);
		List<StoreComponentConfigurationInfo> list2 = default(List<StoreComponentConfigurationInfo>);
		IEnumerable<IStoreComponentInfo> storeComponentsInfo = default(IEnumerable<IStoreComponentInfo>);
		IStartInformation startInformation = default(IStartInformation);
		List<IStoreComponentInfo> list = default(List<IStoreComponentInfo>);
		string repositoryPath = default(string);
		IEnumerator<string> enumerator = default(IEnumerator<string>);
		_003C_003Ec__DisplayClass15_0 _003C_003Ec__DisplayClass15_ = default(_003C_003Ec__DisplayClass15_0);
		List<StoreComponentConfigurationInfo> list4 = default(List<StoreComponentConfigurationInfo>);
		List<IStoreComponentInfo> list3 = default(List<IStoreComponentInfo>);
		IStoreComponentInfo storeComponentInfo = default(IStoreComponentInfo);
		string current = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 14:
					if (elmaComponent != null)
					{
						num2 = 16;
						continue;
					}
					return;
				case 3:
					installedStoreComponentInfos.AddRange(list2);
					num = 13;
					break;
				case 7:
					try
					{
						UpdateModuleStatusesByComponents(storeComponentsInfo);
						int num7 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
						{
							num7 = 0;
						}
						switch (num7)
						{
						case 0:
							break;
						}
					}
					finally
					{
						int num8;
						if (startInformation == null)
						{
							num8 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
							{
								num8 = 0;
							}
							goto IL_017b;
						}
						goto IL_0191;
						IL_0191:
						iuHeM53mWnmLRYCDxGL(startInformation);
						num8 = 2;
						goto IL_017b;
						IL_017b:
						switch (num8)
						{
						default:
							goto end_IL_0156;
						case 1:
							break;
						case 0:
							goto end_IL_0156;
						case 2:
							goto end_IL_0156;
						}
						goto IL_0191;
						end_IL_0156:;
					}
					goto case 42;
				case 34:
					startInformation = (IStartInformation)xd3TkY30TRJgcA0Gcwk(95.0, viBoOG3xGktHcXIjbKZ(yONloC3ygB4MNggpRib(-1978478350 ^ -1978488352)));
					num2 = 29;
					continue;
				case 36:
				case 48:
					SaveStoreComponentConfigurationInfos(list2);
					num2 = 44;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 17;
					}
					continue;
				case 6:
					startInformation = (IStartInformation)xd3TkY30TRJgcA0Gcwk(50.0, viBoOG3xGktHcXIjbKZ(yONloC3ygB4MNggpRib(-97972138 ^ -97949470)));
					num2 = 45;
					continue;
				case 47:
					throw new InvalidOperationException((string)T6y7cn3dwy25eMCwujO(yONloC3ygB4MNggpRib(-576149596 ^ -576135886)));
				case 52:
				{
					IEnumerable<string> deprecatedComponentFiles = GetDeprecatedComponentFiles(list, repositoryPath);
					log.DebugFormat((string)yONloC3ygB4MNggpRib(-1886646897 ^ -1886619919));
					enumerator = deprecatedComponentFiles.GetEnumerator();
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
					{
						num2 = 9;
					}
					continue;
				}
				case 24:
					if (transformationProvider != null)
					{
						num2 = 14;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
						{
							num2 = 4;
						}
						continue;
					}
					return;
				case 39:
					try
					{
						UpdateModuleStatusesByActivation();
						int num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
						{
							num5 = 0;
						}
						switch (num5)
						{
						case 0:
							break;
						}
					}
					finally
					{
						int num6;
						if (startInformation == null)
						{
							num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
							{
								num6 = 0;
							}
							goto IL_0367;
						}
						goto IL_039c;
						IL_039c:
						iuHeM53mWnmLRYCDxGL(startInformation);
						num6 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
						{
							num6 = 2;
						}
						goto IL_0367;
						IL_0367:
						switch (num6)
						{
						default:
							goto end_IL_0342;
						case 0:
							goto end_IL_0342;
						case 1:
							break;
						case 2:
							goto end_IL_0342;
						}
						goto IL_039c;
						end_IL_0342:;
					}
					goto case 21;
				case 21:
					startInformation = (IStartInformation)xd3TkY30TRJgcA0Gcwk(4.0, SR.M((string)yONloC3ygB4MNggpRib(0x4A1640F ^ 0x4A11C73)));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
					{
						num2 = 0;
					}
					continue;
				case 11:
					_003C_003Ec__DisplayClass15_ = new _003C_003Ec__DisplayClass15_0();
					num2 = 25;
					continue;
				case 4:
					list4 = list3.Select(delegate(IStoreComponentInfo i)
					{
						int num19 = 1;
						int num20 = num19;
						ManifestStoreComponentInfo manifestStoreComponentInfo = default(ManifestStoreComponentInfo);
						while (true)
						{
							switch (num20)
							{
							case 1:
								manifestStoreComponentInfo = i as ManifestStoreComponentInfo;
								num20 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
								{
									num20 = 0;
								}
								break;
							default:
							{
								StoreComponentConfigurationInfo storeComponentConfigurationInfo = new StoreComponentConfigurationInfo(this);
								rkFdxe3LbLmFXWqaDBK(storeComponentConfigurationInfo, jJPY6WprI100In2IOGe(i));
								xhl4Ab3sIas6KSoKJAA(storeComponentConfigurationInfo, ByS20C3UIDGVZNSBNUu(i));
								storeComponentConfigurationInfo.Version = (((SemanticVersion)gwsKGy3cAuMQuMLtXfm(i) != (SemanticVersion)null) ? gwsKGy3cAuMQuMLtXfm(i).ToString() : null);
								storeComponentConfigurationInfo.Manifest = manifestStoreComponentInfo?.InstalledManifest;
								return storeComponentConfigurationInfo;
							}
							}
						}
					}).ToList();
					num2 = 37;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num2 = 49;
					}
					continue;
				case 16:
					if (!VYyCqi3JOYKnxSFMxKe(elmaComponent))
					{
						num2 = 26;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 11;
				case 8:
					if (YXwOUB39tk7WWU7qYpd(installedStoreComponentInfos) > 0)
					{
						num2 = 10;
						continue;
					}
					goto case 42;
				case 50:
					throw new InvalidOperationException((string)T6y7cn3dwy25eMCwujO(yONloC3ygB4MNggpRib(-606654180 ^ -606648128)));
				case 37:
					if (storeComponentInfo.IsInstalled)
					{
						throw new InvalidOperationException((string)T6y7cn3dwy25eMCwujO(yONloC3ygB4MNggpRib(0x12441CA4 ^ 0x1244664A)));
					}
					num2 = 5;
					continue;
				case 15:
					if (list.Count > 0)
					{
						num2 = 28;
						continue;
					}
					goto case 19;
				case 28:
					repositoryPath = (string)e5GOnH3gL6FkjYerpVx(elmaComponent);
					num2 = 52;
					continue;
				case 27:
					CheckComponentsStatusForConfiguration(elmaComponent, installedStoreComponentInfos, storeComponentsInfo);
					num2 = 33;
					continue;
				case 44:
					installedStoreComponentInfos.Clear();
					num2 = 3;
					continue;
				case 31:
					if (!log.IsDebugEnabled())
					{
						num2 = 48;
						continue;
					}
					goto case 30;
				case 26:
					return;
				case 10:
					startInformation = (IStartInformation)xd3TkY30TRJgcA0Gcwk(95.0, viBoOG3xGktHcXIjbKZ(yONloC3ygB4MNggpRib(0x3A5D5EF ^ 0x3A5AC97)));
					num2 = 20;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 20;
					}
					continue;
				case 29:
					try
					{
						storeComponentsInfo = packageService.GetStoreComponentsInfo(forRuntime: false);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						case 0:
							break;
						}
					}
					finally
					{
						if (startInformation != null)
						{
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									iuHeM53mWnmLRYCDxGL(startInformation);
									num4 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
									{
										num4 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					goto case 8;
				case 22:
					if (packageService.Initialized)
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
						{
							num2 = 43;
						}
						continue;
					}
					goto case 17;
				case 32:
					installedStoreComponentInfos.AddRange(list4);
					num2 = 38;
					continue;
				case 40:
					startInformation = (IStartInformation)xd3TkY30TRJgcA0Gcwk(4.0, SR.M((string)yONloC3ygB4MNggpRib(--1867379187 ^ 0x6F4D89B7)));
					num2 = 39;
					continue;
				case 42:
					UpdateModuleStatusesByDependencies();
					num = 23;
					break;
				case 17:
					obj = null;
					goto IL_0c76;
				case 49:
					SaveStoreComponentConfigurationInfos(list4);
					num2 = 35;
					continue;
				case 51:
					if (storeComponentInfo != null)
					{
						num2 = 37;
						continue;
					}
					goto case 50;
				case 38:
					return;
				case 9:
					try
					{
						while (true)
						{
							int num15;
							if (!enumerator.MoveNext())
							{
								num15 = 4;
								goto IL_0785;
							}
							goto IL_08ea;
							IL_0785:
							while (true)
							{
								switch (num15)
								{
								case 1:
									break;
								case 3:
									try
									{
										if (!File.Exists(current))
										{
											break;
										}
										int num16 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
										{
											num16 = 1;
										}
										while (true)
										{
											switch (num16)
											{
											case 1:
												kRCEf935Iwk42OJbs5K(current);
												num16 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
												{
													num16 = 0;
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
										int num17 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
										{
											num17 = 0;
										}
										while (true)
										{
											switch (num17)
											{
											default:
												log.ErrorFormat((string)yONloC3ygB4MNggpRib(0x4DC2B14D ^ 0x4DC2CD45), current);
												num17 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
												{
													num17 = 1;
												}
												continue;
											case 1:
												break;
											}
											break;
										}
									}
									break;
								default:
									log.DebugFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x42643203 ^ 0x426449FB), current);
									num15 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
									{
										num15 = 1;
									}
									continue;
								case 2:
									goto IL_08ea;
								case 4:
									goto end_IL_07a3;
								}
								break;
							}
							continue;
							IL_08ea:
							current = enumerator.Current;
							num15 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
							{
								num15 = 0;
							}
							goto IL_0785;
							continue;
							end_IL_07a3:
							break;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num18 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
							{
								num18 = 0;
							}
							while (true)
							{
								switch (num18)
								{
								case 1:
									iuHeM53mWnmLRYCDxGL(enumerator);
									num18 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
									{
										num18 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
					}
					goto case 19;
				case 18:
					startInformation = (IStartInformation)xd3TkY30TRJgcA0Gcwk(40.0, viBoOG3xGktHcXIjbKZ(yONloC3ygB4MNggpRib(0x1637C429 ^ 0x1637BC55)));
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
					{
						num2 = 4;
					}
					continue;
				case 45:
					try
					{
						UpdateModuleStatusesByPackages();
						int num13 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
						{
							num13 = 0;
						}
						switch (num13)
						{
						case 0:
							break;
						}
					}
					finally
					{
						int num14;
						if (startInformation == null)
						{
							num14 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
							{
								num14 = 2;
							}
							goto IL_0a11;
						}
						goto IL_0a27;
						IL_0a27:
						iuHeM53mWnmLRYCDxGL(startInformation);
						num14 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
						{
							num14 = 1;
						}
						goto IL_0a11;
						IL_0a11:
						switch (num14)
						{
						case 2:
							goto end_IL_09ec;
						case 1:
							goto end_IL_09ec;
						}
						goto IL_0a27;
						end_IL_09ec:;
					}
					goto case 34;
				case 35:
					installedStoreComponentInfos.Clear();
					num2 = 32;
					continue;
				default:
					try
					{
						UpdateModuleStatusesByDependencies();
						int num11 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
						{
							num11 = 0;
						}
						switch (num11)
						{
						case 0:
							break;
						}
					}
					finally
					{
						int num12;
						if (startInformation == null)
						{
							num12 = 2;
							goto IL_0ad4;
						}
						goto IL_0aea;
						IL_0ad4:
						switch (num12)
						{
						default:
							goto end_IL_0abf;
						case 1:
							break;
						case 2:
							goto end_IL_0abf;
						case 0:
							goto end_IL_0abf;
						}
						goto IL_0aea;
						IL_0aea:
						startInformation.Dispose();
						num12 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
						{
							num12 = 0;
						}
						goto IL_0ad4;
						end_IL_0abf:;
					}
					goto case 22;
				case 20:
					try
					{
						IEnumerable<StoreComponentConfigurationInfo> enumerable = installedStoreComponentInfos.Where(_003C_003Ec__DisplayClass15_._003CExecuteUpdateModuleStatuses_003Eb__3);
						int num9 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
						{
							num9 = 0;
						}
						while (true)
						{
							switch (num9)
							{
							case 1:
								CheckRequiredComponentsForConfiguration(elmaComponent, enumerable, storeComponentsInfo);
								num9 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
								{
									num9 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
					finally
					{
						if (startInformation != null)
						{
							int num10 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
							{
								num10 = 0;
							}
							while (true)
							{
								switch (num10)
								{
								default:
									iuHeM53mWnmLRYCDxGL(startInformation);
									num10 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
									{
										num10 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					goto case 18;
				case 2:
					UpdateConfigurationPackagesFolder(elmaComponent, list3);
					num2 = 46;
					continue;
				case 23:
					if (installedStoreComponentInfos.Count > 0)
					{
						num2 = 27;
						continue;
					}
					goto case 33;
				case 13:
					return;
				case 12:
					if (YXwOUB39tk7WWU7qYpd(installedStoreComponentInfos) != 0)
					{
						log.DebugFormat((string)yONloC3ygB4MNggpRib(0x53FA00CE ^ 0x53FA7B8E));
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
						{
							num2 = 1;
						}
					}
					else
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
						{
							num2 = 0;
						}
					}
					continue;
				case 43:
					obj = Au5noq3MyumEpUNuXEA(packageService);
					goto IL_0c76;
				case 25:
					_003C_003Ec__DisplayClass15_.deprecatedPackageIds = (from dep in elmaComponent.GetInstalledPackagesInfo().SelectMany((PackageInfo info) => ((IXPackageMetadata)info.Package).get_UninstallDependencies().EmptyIfNull())
						select (string)_003C_003Ec.Fig36bfJi50dOVhomum0(dep)).ToHashSet();
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 5;
					}
					continue;
				case 33:
					list3 = storeComponentsInfo.Where((IStoreComponentInfo i) => _003C_003Ec.URXMpIfJRPH0iktvlWwC(i) == ModuleStatus.Enabled).ToList();
					num = 12;
					break;
				case 1:
					if (list3.Any((IStoreComponentInfo i) => _003C_003Ec.d09vfMfJKiQfaES3vGCF(_003C_003Ec.NGbW0efJqZ7ntbFRVRQP(i), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317763220))))
					{
						UpdateConfigurationPackagesFolder(elmaComponent, list3);
						num2 = 4;
						continue;
					}
					num2 = 41;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
					{
						num2 = 11;
					}
					continue;
				case 41:
					storeComponentInfo = storeComponentsInfo.FirstOrDefault((IStoreComponentInfo i) => _003C_003Ec.d09vfMfJKiQfaES3vGCF(_003C_003Ec.NGbW0efJqZ7ntbFRVRQP(i), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1DE3DD89 ^ 0x1DE34635)));
					num2 = 51;
					continue;
				case 5:
					fb0eAe3rAXkRVCqXPRS(Logger.Log, JY5ViB3lQGjSNqgjRWT(yONloC3ygB4MNggpRib(-1751176224 ^ -1751166516), string.Join((string)yONloC3ygB4MNggpRib(-281842504 ^ -281845574), from p in storeComponentInfo.AllPackages
						where !_003C_003Ec.KZvqR2fJXUweBmIWbmRZ(p)
						select p.Id)));
					num2 = 47;
					continue;
				case 46:
					list = storeComponentsInfo.Where(delegate(IStoreComponentInfo i)
					{
						int num23 = 1;
						int num24 = num23;
						while (true)
						{
							switch (num24)
							{
							case 1:
								if (_003C_003Ec.URXMpIfJRPH0iktvlWwC(i) != ModuleStatus.Disabled)
								{
									return false;
								}
								num24 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
								{
									num24 = 0;
								}
								break;
							default:
								return i.DisabledReason == ModuleDisabledReason.Deprecated;
							}
						}
					}).ToList();
					num2 = 15;
					continue;
				case 19:
					list2 = storeComponentsInfo.Where((IStoreComponentInfo i) => _003C_003Ec.URXMpIfJRPH0iktvlWwC(i) == ModuleStatus.Enabled).Select(delegate(IStoreComponentInfo i)
					{
						int num21 = 1;
						int num22 = num21;
						StoreComponentConfigurationInfo storeComponentConfigurationInfo2;
						_003C_003Ec__DisplayClass15_1 _003C_003Ec__DisplayClass15_2 = default(_003C_003Ec__DisplayClass15_1);
						while (true)
						{
							switch (num22)
							{
							case 3:
								storeComponentConfigurationInfo2 = installedStoreComponentInfos.FirstOrDefault(_003C_003Ec__DisplayClass15_2._003CExecuteUpdateModuleStatuses_003Eb__13);
								if (storeComponentConfigurationInfo2 == null)
								{
									num22 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
									{
										num22 = 0;
									}
									continue;
								}
								break;
							case 1:
								_003C_003Ec__DisplayClass15_2 = new _003C_003Ec__DisplayClass15_1();
								num22 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
								{
									num22 = 0;
								}
								continue;
							default:
								_003C_003Ec__DisplayClass15_2.i = i;
								num22 = 3;
								continue;
							case 2:
								storeComponentConfigurationInfo2 = new StoreComponentConfigurationInfo(this);
								rkFdxe3LbLmFXWqaDBK(storeComponentConfigurationInfo2, jJPY6WprI100In2IOGe(_003C_003Ec__DisplayClass15_2.i));
								storeComponentConfigurationInfo2.Title = _003C_003Ec__DisplayClass15_2.i.Title;
								storeComponentConfigurationInfo2.Version = (((SemanticVersion)gwsKGy3cAuMQuMLtXfm(_003C_003Ec__DisplayClass15_2.i) != (SemanticVersion)null) ? gwsKGy3cAuMQuMLtXfm(_003C_003Ec__DisplayClass15_2.i).ToString() : null);
								m9pQrSpWnf13sPhlEc4(storeComponentConfigurationInfo2, (_003C_003Ec__DisplayClass15_2.i is ManifestStoreComponentInfo manifestStoreComponentInfo2) ? fKTUiapgJybd8MyoSSb(manifestStoreComponentInfo2) : null);
								break;
							}
							break;
						}
						return storeComponentConfigurationInfo2;
					}).ToList();
					num2 = 31;
					continue;
				case 30:
					{
						log.DebugFormat((string)yONloC3ygB4MNggpRib(0xA592A41 ^ 0xA5956D3), string.Concat(list2.Select((StoreComponentConfigurationInfo item) => string.Format((string)_003C_003Ec.TLpCyMfJTMJ1YITq5kHL(-1837662597 ^ -1838016085), _003C_003Ec.RSOXQIfJkYMvmq3G3hAo(), _003C_003Ec.Njc2tyfJnhg3mBiiug8t(item), _003C_003Ec.jjVRuofJOFf7VHC3Xb9x(item)))));
						num2 = 36;
						continue;
					}
					IL_0c76:
					elmaComponent = (IElmaComponent)obj;
					num2 = 24;
					continue;
				}
				break;
			}
		}
	}

	private static void UpdateConfigurationPackagesFolder(object packagingComponent, List<IStoreComponentInfo> enabledComponentInfos)
	{
		string configurationPackagesDirectory = ((IElmaComponent)packagingComponent).GetConfigurationPackagesDirectory();
		if (string.IsNullOrEmpty(configurationPackagesDirectory))
		{
			return;
		}
		if (!Directory.Exists(configurationPackagesDirectory))
		{
			Directory.CreateDirectory(configurationPackagesDirectory);
		}
		foreach (ManifestStoreComponentInfo item in enabledComponentInfos.OfType<ManifestStoreComponentInfo>())
		{
			log.InfoFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7C1EE318 ^ 0x7C1E9FCE), item.Id, item.InstalledVersion, item.LastVersion);
			if (item.InstalledFile == null || item.InstalledManifest.ProductType == ManifestComponentType.Platform)
			{
				continue;
			}
			string path = item.InstalledManifest.Id + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7C1EE318 ^ 0x7C1EF9DC) + item.InstalledManifest.Version + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477163368);
			string text = Path.Combine(configurationPackagesDirectory, path);
			if (!File.Exists(text))
			{
				log.InfoFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x68BBB53E ^ 0x68BBC86C), text);
				using (StartInformation.Operation(StartInformation.Current.Percent, SR.M(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1A33FE36 ^ 0x1A3383A4), item.InstalledManifest.Id)))
				{
					item.InstalledFile.SaveTo(text);
				}
			}
		}
	}

	public IEnumerable<string> GetMissedRequiredModules()
	{
		List<string> list = new List<string>();
		using List<string>.Enumerator enumerator = requiredModuleNames.GetEnumerator();
		while (enumerator.MoveNext())
		{
			_003C_003Ec__DisplayClass17_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass17_0();
			CS_0024_003C_003E8__locals0.moduleName = enumerator.Current;
			if (unitsByUid.Values.OfType<IModuleAssembly>().FirstOrDefault((IModuleAssembly m) => _003C_003Ec__DisplayClass17_0.p8R23ifJYaE7atLyTERw(_003C_003Ec__DisplayClass17_0.QbKnbbfJjf1EChl1NmkE(m), CS_0024_003C_003E8__locals0.moduleName, StringComparison.CurrentCultureIgnoreCase)) == null)
			{
				list.Add(CS_0024_003C_003E8__locals0.moduleName);
			}
		}
		return list;
	}

	public IEnumerable<string> GetDisableRequiredModules()
	{
		List<string> list = new List<string>();
		using List<string>.Enumerator enumerator = requiredModuleNames.GetEnumerator();
		while (enumerator.MoveNext())
		{
			_003C_003Ec__DisplayClass18_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass18_0();
			CS_0024_003C_003E8__locals0.moduleName = enumerator.Current;
			IModuleAssembly moduleAssembly = unitsByUid.Values.OfType<IModuleAssembly>().FirstOrDefault((IModuleAssembly m) => _003C_003Ec__DisplayClass18_0.pO1pJlfJzF6CwGRaJZDt(m.Id, CS_0024_003C_003E8__locals0.moduleName, StringComparison.CurrentCultureIgnoreCase));
			if (moduleAssembly == null)
			{
				continue;
			}
			for (IApplicationUnit owner = moduleAssembly.Owner; owner != null; owner = owner.Owner)
			{
				if (owner is ILicensedUnit licensedUnit)
				{
					ILicenseInfo licenseInfo = licensedUnit.GetLicenseInfo();
					if (licenseInfo != null && licenseInfo.Status != 0)
					{
						if (!list.Contains(owner.Title))
						{
							list.Add(owner.Title);
						}
						break;
					}
				}
			}
		}
		return list;
	}

	public void SaveModuleStatus(Guid uid, ModuleStatus status)
	{
		//Discarded unreachable code: IL_005c, IL_006b
		int num = 1;
		int num2 = num;
		IModule value = default(IModule);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				DLkNZ13jvE6BDLmf2Cg((ModuleBase)value, ModuleStatus.RestartRequired);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
				{
					num2 = 4;
				}
				break;
			case 0:
				return;
			case 4:
				SaveModuleStatusToDb(uid, status);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
				{
					num2 = 3;
				}
				break;
			case 3:
				return;
			case 1:
				if (!modulesByUid.TryGetValue(uid, out value))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	public void SaveStoreComponent(ElmaStoreComponentManifest manifest, IEnumerable<StoreComponentSignatureInfo> signatures, string fileName, StoreComponentStatus status, string unpackedPackagesFolder = null)
	{
		if (manifest == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675485767));
		}
		if (string.IsNullOrEmpty(fileName))
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487389060));
		}
		packageService.SaveStoreComponentFileToConfiguration(manifest, fileName, unpackedPackagesFolder);
		SaveStoreComponentInfo(manifest, signatures, status);
	}

	public void SaveStoreComponentInfo(IStoreComponentInfo info, StoreComponentStatus status)
	{
		//Discarded unreachable code: IL_00bf, IL_0135, IL_0144, IL_017a, IL_0328, IL_0365, IL_0374, IL_037f, IL_040c, IL_0444, IL_0470
		int num = 5;
		_003C_003Ec__DisplayClass21_0 _003C_003Ec__DisplayClass21_ = default(_003C_003Ec__DisplayClass21_0);
		ManifestStoreComponentInfo manifestStoreComponentInfo = default(ManifestStoreComponentInfo);
		StoreComponentConfigurationInfo storeComponentConfigurationInfo2 = default(StoreComponentConfigurationInfo);
		StoreComponentConfigurationInfo storeComponentConfigurationInfo = default(StoreComponentConfigurationInfo);
		IEnumerator<Module> enumerator = default(IEnumerator<Module>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 4:
					_003C_003Ec__DisplayClass21_.info = info;
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
					{
						num2 = 6;
					}
					continue;
				case 16:
					return;
				case 3:
					manifestStoreComponentInfo = _003C_003Ec__DisplayClass21_.info as ManifestStoreComponentInfo;
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num2 = 18;
					}
					continue;
				default:
					if (storeComponentConfigurationInfo2 != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto case 25;
				case 21:
					storeComponentConfigurationInfo.Signatures = ((ElmaStoreComponentFile)KwFBXKpbx8pGbmVOeUF(manifestStoreComponentInfo)).GetSignatures();
					num2 = 6;
					continue;
				case 30:
					if (nWhm5b3YKIDl314M13q(storeComponentConfigurationInfo2) != 0)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 1;
				case 25:
					SaveStoreComponentConfigurationInfo(storeComponentConfigurationInfo);
					num2 = 19;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num2 = 16;
					}
					continue;
				case 1:
					if (status == StoreComponentStatus.Allowed)
					{
						num2 = 16;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto case 3;
				case 13:
					if (storeComponentConfigurationInfo2 != null)
					{
						num2 = 30;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
						{
							num2 = 28;
						}
						continue;
					}
					goto case 3;
				case 20:
				case 29:
					if (ngtxIXpQl2A3PXVLYB6(_003C_003Ec__DisplayClass21_.info) == ModuleStatus.Disabled)
					{
						num2 = 27;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
						{
							num2 = 1;
						}
						continue;
					}
					return;
				case 17:
					iwYfvvpfg3gZfFMs6td(storeComponentConfigurationInfo, axXbShpExox4KD0IfdS(storeComponentConfigurationInfo2));
					num2 = 25;
					continue;
				case 26:
					throw new ArgumentNullException((string)yONloC3ygB4MNggpRib(-957824448 ^ -957827322));
				case 8:
					installedStoreComponentInfos.Remove(storeComponentConfigurationInfo2);
					num2 = 12;
					continue;
				case 14:
					return;
				case 12:
					installedStoreComponentInfos.Add(storeComponentConfigurationInfo);
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num2 = 20;
					}
					continue;
				case 15:
					if (_003C_003Ec__DisplayClass21_.info != null)
					{
						storeComponentConfigurationInfo2 = installedStoreComponentInfos.FirstOrDefault(_003C_003Ec__DisplayClass21_._003CSaveStoreComponentInfo_003Eb__0);
						num2 = 13;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
						{
							num2 = 13;
						}
					}
					else
					{
						num2 = 26;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
						{
							num2 = 21;
						}
					}
					continue;
				case 19:
					if (status != 0)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
						{
							num2 = 29;
						}
						continue;
					}
					goto case 23;
				case 23:
					if (storeComponentConfigurationInfo2 != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
						{
							num2 = 8;
						}
						continue;
					}
					goto case 12;
				case 27:
					if (zck0uqpCnRQt4SNTHOI(_003C_003Ec__DisplayClass21_.info) != ModuleDisabledReason.DisabledManually)
					{
						return;
					}
					num2 = 28;
					continue;
				case 5:
					_003C_003Ec__DisplayClass21_ = new _003C_003Ec__DisplayClass21_0();
					num2 = 4;
					continue;
				case 11:
					try
					{
						while (true)
						{
							int num3;
							if (!yiHGD7pvyVKFJQpxj3Y(enumerator))
							{
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
								{
									num3 = 1;
								}
								goto IL_0383;
							}
							goto IL_0399;
							IL_0399:
							DLkNZ13jvE6BDLmf2Cg(enumerator.Current, ModuleStatus.RestartRequired);
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
							{
								num3 = 2;
							}
							goto IL_0383;
							IL_0383:
							switch (num3)
							{
							case 1:
								return;
							case 2:
								continue;
							}
							goto IL_0399;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									iuHeM53mWnmLRYCDxGL(enumerator);
									num4 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
									{
										num4 = 0;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
				case 9:
					break;
				case 10:
					obj = null;
					goto IL_05c4;
				case 2:
					if (manifestStoreComponentInfo != null)
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto case 10;
				case 6:
					storeComponentConfigurationInfo.InitLicensedUnit();
					num2 = 24;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num2 = 5;
					}
					continue;
				case 18:
				{
					StoreComponentConfigurationInfo storeComponentConfigurationInfo3 = new StoreComponentConfigurationInfo(this);
					rkFdxe3LbLmFXWqaDBK(storeComponentConfigurationInfo3, _003C_003Ec__DisplayClass21_.info.Id);
					xhl4Ab3sIas6KSoKJAA(storeComponentConfigurationInfo3, ByS20C3UIDGVZNSBNUu(_003C_003Ec__DisplayClass21_.info));
					RYyZt8pFHQCPdFvpZGX(storeComponentConfigurationInfo3, AwOZwt3zbx1CXTaF9kw(gwsKGy3cAuMQuMLtXfm(_003C_003Ec__DisplayClass21_.info), null) ? gwsKGy3cAuMQuMLtXfm(_003C_003Ec__DisplayClass21_.info).ToString() : ((_003C_003Ec__DisplayClass21_.info.LastVersion != (SemanticVersion)null) ? ((object)_003C_003Ec__DisplayClass21_.info.LastVersion).ToString() : ""));
					storeComponentConfigurationInfo3.Status = status;
					m9pQrSpWnf13sPhlEc4(storeComponentConfigurationInfo3, (manifestStoreComponentInfo != null) ? (manifestStoreComponentInfo.InstalledManifest ?? SFeA9OpB0kWZ4CZ69VS(manifestStoreComponentInfo)) : null);
					storeComponentConfigurationInfo = storeComponentConfigurationInfo3;
					num2 = 2;
					continue;
				}
				case 7:
					obj = Mxao2GpoH3j3rHjDeqf(manifestStoreComponentInfo);
					if (obj != null)
					{
						goto IL_05c4;
					}
					num2 = 22;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
					{
						num2 = 8;
					}
					continue;
				case 22:
					obj = KwFBXKpbx8pGbmVOeUF(manifestStoreComponentInfo);
					goto IL_05c4;
				case 28:
					{
						enumerator = _003C_003Ec__DisplayClass21_.info.AllModules.OfType<Module>().Where(delegate(Module m)
						{
							int num5 = 1;
							int num6 = num5;
							while (true)
							{
								switch (num6)
								{
								case 1:
									if (_003C_003Ec.AIhApHfJ2Z5c69RkKvy6(m) != ModuleStatus.Disabled)
									{
										return false;
									}
									num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
									{
										num6 = 0;
									}
									break;
								default:
									return _003C_003Ec.zWrf2UfJeMyqKSp8LIQs(m) == ModuleDisabledReason.DisabledManually;
								}
							}
						}).GetEnumerator();
						num2 = 11;
						continue;
					}
					IL_05c4:
					if (obj == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 21;
				}
				break;
			}
			oVRZM8pGulEWGGvneFD(storeComponentConfigurationInfo, Wsce5IphTR50SQ5rsEu(storeComponentConfigurationInfo2));
			num = 17;
		}
	}

	public void UpdateAutoDeployComponentInfo(StoreComponentConfigurationInfo info, AutoDeployComponentStatus status)
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
				UpdateAutoDeployComponentInfo(info, (AutoDeployComponentStatus?)status, (SemanticVersion)null);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void UpdateAutoDeployComponentInfo(StoreComponentConfigurationInfo info, SemanticVersion version)
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
				UpdateAutoDeployComponentInfo(info, null, version);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void UpdateAutoDeployComponentInfo(StoreComponentConfigurationInfo info, AutoDeployComponentStatus status, SemanticVersion version)
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
				UpdateAutoDeployComponentInfo(info, (AutoDeployComponentStatus?)status, version);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void UpdateAutoDeployComponentInfo(StoreComponentConfigurationInfo info, AutoDeployComponentStatus? status, SemanticVersion version)
	{
		_003C_003Ec__DisplayClass25_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass25_0();
		CS_0024_003C_003E8__locals0.info = info;
		if (CS_0024_003C_003E8__locals0.info == null)
		{
			return;
		}
		StoreComponentConfigurationInfo storeComponentConfigurationInfo = installedStoreComponentInfos.FirstOrDefault((StoreComponentConfigurationInfo i) => _003C_003Ec__DisplayClass25_0.mbthBUf9Cgq64HBDiy6S(i.Id, _003C_003Ec__DisplayClass25_0.xPphUof9QtI0jbpoAOIj(CS_0024_003C_003E8__locals0.info), StringComparison.CurrentCultureIgnoreCase));
		if (storeComponentConfigurationInfo != null)
		{
			if (status.HasValue)
			{
				storeComponentConfigurationInfo.DeployStatus = status.Value;
			}
			if (version != (SemanticVersion)null)
			{
				storeComponentConfigurationInfo.SemanticDeployVersion = version;
			}
			CS_0024_003C_003E8__locals0.info = storeComponentConfigurationInfo;
			SaveStoreComponentConfigurationInfo(storeComponentConfigurationInfo);
			return;
		}
		if (status.HasValue)
		{
			CS_0024_003C_003E8__locals0.info.DeployStatus = status.Value;
		}
		if (version != (SemanticVersion)null)
		{
			CS_0024_003C_003E8__locals0.info.SemanticDeployVersion = version;
		}
		SaveStoreComponentConfigurationInfo(CS_0024_003C_003E8__locals0.info);
		if (!installedStoreComponentInfos.Contains(CS_0024_003C_003E8__locals0.info))
		{
			installedStoreComponentInfos.Add(CS_0024_003C_003E8__locals0.info);
		}
	}

	public IEnumerable<ElmaStoreComponentManifest> GetInstalledComponentManifests()
	{
		return (from i in installedStoreComponentInfos
			where _003C_003Ec.hcY4I0fJPAHCTCUp9cyJ(i) != null
			select (ElmaStoreComponentManifest)_003C_003Ec.hcY4I0fJPAHCTCUp9cyJ(i)).ToList();
	}

	internal IEnumerable<StoreComponentConfigurationInfo> GetInstalledComponentInfos()
	{
		return installedStoreComponentInfos.ToArray();
	}

	public virtual IEnumerable<PackageManifest> GetComponentPackages(string componentId)
	{
		_003C_003Ec__DisplayClass28_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass28_0();
		CS_0024_003C_003E8__locals0.componentId = componentId;
		ElmaStoreComponentManifest elmaStoreComponentManifest = GetInstalledComponentManifests().FirstOrDefault((ElmaStoreComponentManifest c) => _003C_003Ec__DisplayClass28_0.JM28Lqf9VGOAKAmrwhAQ(_003C_003Ec__DisplayClass28_0.m29dXIf9IcTXAcIUYnCb(c), CS_0024_003C_003E8__locals0.componentId));
		if (elmaStoreComponentManifest == null)
		{
			return null;
		}
		List<PackageManifest> list = new List<PackageManifest>();
		GetPackagesFromComponent(elmaStoreComponentManifest, list);
		return list;
	}

	protected virtual void GetPackagesFromComponent(ElmaStoreComponentManifest component, List<PackageManifest> packages)
	{
		using (List<PackageManifest>.Enumerator enumerator = component.Packages.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass29_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass29_0();
				CS_0024_003C_003E8__locals0.package = enumerator.Current;
				if (packages.All((PackageManifest p) => _003C_003Ec__DisplayClass29_0.HERY69f9XLrlIVPAwlCU(_003C_003Ec__DisplayClass29_0.BJMkvGf9KFxt1kF8aL7u(p), _003C_003Ec__DisplayClass29_0.BJMkvGf9KFxt1kF8aL7u(CS_0024_003C_003E8__locals0.package))))
				{
					packages.Add(CS_0024_003C_003E8__locals0.package);
				}
			}
		}
		if (component.Dependencies == null || component.Dependencies.Count <= 0)
		{
			return;
		}
		List<ElmaStoreComponentManifest> source = GetInstalledComponentManifests().ToList();
		using List<ElmaStoreComponentDependency>.Enumerator enumerator2 = component.Dependencies.GetEnumerator();
		while (enumerator2.MoveNext())
		{
			_003C_003Ec__DisplayClass29_1 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass29_1();
			CS_0024_003C_003E8__locals1.dependency = enumerator2.Current;
			ElmaStoreComponentManifest elmaStoreComponentManifest = source.FirstOrDefault((ElmaStoreComponentManifest c) => _003C_003Ec__DisplayClass29_1.SeDxhWf9PeMaJUf1ll4i(_003C_003Ec__DisplayClass29_1.sH27QWf92je8O1VvDL1o(c), _003C_003Ec__DisplayClass29_1.Q0BCUtf9e0DMPQvxopyN(CS_0024_003C_003E8__locals1.dependency)));
			if (elmaStoreComponentManifest != null)
			{
				GetPackagesFromComponent(elmaStoreComponentManifest, packages);
			}
		}
	}

	private static Module FindModule(IEnumerable<Module> modules, object moduleRef)
	{
		_003C_003Ec__DisplayClass47_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass47_0();
		CS_0024_003C_003E8__locals0.moduleRef = (ApplicationDescriptor.ModuleReference)moduleRef;
		if (CS_0024_003C_003E8__locals0.moduleRef == null)
		{
			return null;
		}
		if (CS_0024_003C_003E8__locals0.moduleRef.Uid != Guid.Empty)
		{
			return modules.FirstOrDefault((Module m) => _003C_003Ec__DisplayClass47_0.mZtENvf9tUXP7vHksZtO(_003C_003Ec__DisplayClass47_0.RTZvmqf9aQnVQCfq4Yce(m), _003C_003Ec__DisplayClass47_0.CyFnFbf9DKFa6oGEhPul(CS_0024_003C_003E8__locals0.moduleRef)));
		}
		if (!string.IsNullOrEmpty(CS_0024_003C_003E8__locals0.moduleRef.Id))
		{
			return modules.FirstOrDefault((Module m) => _003C_003Ec__DisplayClass47_0.RKgNjbf94B2mMXpP1ACE(m.Id, _003C_003Ec__DisplayClass47_0.zbPMOLf9waIJjXu2b9j3(CS_0024_003C_003E8__locals0.moduleRef)));
		}
		return null;
	}

	private void RegisterUnit(IApplicationUnit unit)
	{
		int num = 6;
		int num2 = num;
		IModule module = default(IModule);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				module = unit as IModule;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 6:
				unitsById[(string)thF2eJp85704Nk54WwF(unit)] = unit;
				num2 = 5;
				break;
			case 1:
				modulesByUid[HbHbtIpZSxNStZA7kQ9(module)] = module;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				if (module == null)
				{
					return;
				}
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				unitsByUid[HbHbtIpZSxNStZA7kQ9(unit)] = unit;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				modulesById[(string)thF2eJp85704Nk54WwF(module)] = module;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private void SaveStoreComponentInfo(ElmaStoreComponentManifest manifest, IEnumerable<StoreComponentSignatureInfo> signatures, StoreComponentStatus status)
	{
		_003C_003Ec__DisplayClass49_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass49_0();
		CS_0024_003C_003E8__locals0.manifest = manifest;
		if (CS_0024_003C_003E8__locals0.manifest == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 0x6F4D8FF5));
		}
		StoreComponentConfigurationInfo storeComponentConfigurationInfo = installedStoreComponentInfos.FirstOrDefault((StoreComponentConfigurationInfo i) => _003C_003Ec__DisplayClass49_0.sXThbTf90QVPsJ9hJcKF(i.Id, _003C_003Ec__DisplayClass49_0.UJGOexf9xdjGgMbMDviQ(CS_0024_003C_003E8__locals0.manifest), StringComparison.CurrentCultureIgnoreCase));
		if (storeComponentConfigurationInfo != null && storeComponentConfigurationInfo.Status == StoreComponentStatus.Active && status == StoreComponentStatus.Allowed)
		{
			return;
		}
		StoreComponentConfigurationInfo storeComponentConfigurationInfo2 = new StoreComponentConfigurationInfo(this, CS_0024_003C_003E8__locals0.manifest, signatures, status);
		if (storeComponentConfigurationInfo != null)
		{
			storeComponentConfigurationInfo2.DeployStatus = storeComponentConfigurationInfo.DeployStatus;
			storeComponentConfigurationInfo2.DeployVersion = storeComponentConfigurationInfo.DeployVersion;
		}
		SaveStoreComponentConfigurationInfo(storeComponentConfigurationInfo2);
		if (status == StoreComponentStatus.Active)
		{
			if (storeComponentConfigurationInfo != null)
			{
				installedStoreComponentInfos.Remove(storeComponentConfigurationInfo);
			}
			installedStoreComponentInfos.Add(storeComponentConfigurationInfo2);
		}
	}

	private void UpdateModuleStatusesByDependencies()
	{
		//Discarded unreachable code: IL_0032, IL_0041, IL_004c, IL_008a, IL_0099, IL_00a4, IL_013a, IL_01ca, IL_01e9, IL_0215, IL_0224, IL_0280, IL_02b8, IL_02c7
		int num = 1;
		int num2 = num;
		IEnumerator<ModuleBase> enumerator = default(IEnumerator<ModuleBase>);
		IEnumerator<IModuleAssembly> enumerator2 = default(IEnumerator<IModuleAssembly>);
		ModuleBase current = default(ModuleBase);
		ModuleDisabledReason disabledReason = default(ModuleDisabledReason);
		IModuleAssembly current2 = default(IModuleAssembly);
		while (true)
		{
			switch (num2)
			{
			case 3:
				try
				{
					while (true)
					{
						int num3;
						if (!yiHGD7pvyVKFJQpxj3Y(enumerator))
						{
							num3 = 3;
							goto IL_0050;
						}
						goto IL_022f;
						IL_0050:
						while (true)
						{
							switch (num3)
							{
							case 1:
								break;
							case 4:
								try
								{
									while (true)
									{
										IL_0167:
										int num4;
										if (!yiHGD7pvyVKFJQpxj3Y(enumerator2))
										{
											num4 = 6;
											goto IL_00a8;
										}
										goto IL_0144;
										IL_00a8:
										while (true)
										{
											switch (num4)
											{
											case 1:
												jpkPjwpSod5pILbep3X(current, disabledReason);
												num4 = 2;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
												{
													num4 = 2;
												}
												continue;
											case 7:
												DLkNZ13jvE6BDLmf2Cg(current, ModuleStatus.Disabled);
												num4 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
												{
													num4 = 1;
												}
												continue;
											default:
												if (!IsAssemblyAvailable((Assembly)fMZA9kpI308HGCkyBLl(current2), out disabledReason))
												{
													num4 = 5;
													continue;
												}
												goto IL_0167;
											case 2:
												break;
											case 3:
												goto IL_0144;
											case 4:
												goto IL_0167;
											case 5:
												if (P7RptNpVLamYrCNwPMO(current) != ModuleStatus.Disabled)
												{
													num4 = 7;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
													{
														num4 = 5;
													}
													continue;
												}
												goto IL_0167;
											case 6:
												break;
											}
											break;
										}
										break;
										IL_0144:
										current2 = enumerator2.Current;
										num4 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
										{
											num4 = 0;
										}
										goto IL_00a8;
									}
								}
								finally
								{
									int num5;
									if (enumerator2 == null)
									{
										num5 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
										{
											num5 = 0;
										}
										goto IL_01ce;
									}
									goto IL_01f3;
									IL_01f3:
									enumerator2.Dispose();
									num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
									{
										num5 = 0;
									}
									goto IL_01ce;
									IL_01ce:
									switch (num5)
									{
									default:
										goto end_IL_01a9;
									case 1:
										goto end_IL_01a9;
									case 2:
										break;
									case 0:
										goto end_IL_01a9;
									}
									goto IL_01f3;
									end_IL_01a9:;
								}
								break;
							default:
								goto IL_022f;
							case 2:
								enumerator2 = current.Assemblies.GetEnumerator();
								num3 = 4;
								continue;
							case 3:
								return;
							}
							break;
						}
						continue;
						IL_022f:
						current = enumerator.Current;
						num3 = 2;
						goto IL_0050;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
						{
							num6 = 1;
						}
						while (true)
						{
							switch (num6)
							{
							case 1:
								iuHeM53mWnmLRYCDxGL(enumerator);
								num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
								{
									num6 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
			default:
				enumerator = unitsByUid.Values.OfType<ModuleBase>().GetEnumerator();
				num2 = 3;
				break;
			case 2:
				return;
			case 1:
				soLcsrpuMFAfRcbevLd(assemblyAvailability);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void UpdateModuleStatusesByActivation()
	{
		//Discarded unreachable code: IL_005f, IL_0212, IL_0221, IL_0231, IL_0240, IL_02ab, IL_02ba, IL_02ca, IL_02ee, IL_0354, IL_0363, IL_03fa, IL_041c, IL_042b, IL_0497, IL_04a6, IL_055f, IL_0738, IL_0778, IL_0787, IL_0796
		int num = 2;
		int num2 = num;
		IEnumerator<ModuleBase> enumerator = default(IEnumerator<ModuleBase>);
		ModuleBase current = default(ModuleBase);
		IApplicationUnit applicationUnit = default(IApplicationUnit);
		ILicensedUnit licensedUnit = default(ILicensedUnit);
		ILicenseInfo licenseInfo = default(ILicenseInfo);
		ModuleStatus value2 = default(ModuleStatus);
		ModuleStatus value = default(ModuleStatus);
		IApplicationUnit applicationUnit2 = default(IApplicationUnit);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				enumerator = unitsByUid.Values.OfType<ModuleBase>().GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				try
				{
					while (true)
					{
						IL_0448:
						int num3;
						if (!yiHGD7pvyVKFJQpxj3Y(enumerator))
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
							{
								num3 = 1;
							}
							goto IL_006d;
						}
						goto IL_036e;
						IL_036e:
						current = enumerator.Current;
						num3 = 24;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
						{
							num3 = 6;
						}
						goto IL_006d;
						IL_006d:
						while (true)
						{
							int num4;
							switch (num3)
							{
							case 45:
								jpkPjwpSod5pILbep3X(current, ModuleDisabledReason.ActivationInDb);
								num3 = 26;
								continue;
							case 28:
								if (activatedModules == null)
								{
									num3 = 10;
									continue;
								}
								goto case 30;
							case 23:
							case 47:
								DLkNZ13jvE6BDLmf2Cg(current, ModuleStatus.Disabled);
								num3 = 11;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
								{
									num3 = 12;
								}
								continue;
							case 25:
								if (applicationUnit == null)
								{
									num3 = 38;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
									{
										num3 = 22;
									}
									continue;
								}
								goto case 19;
							case 20:
								log.WarnFormat((string)T6y7cn3dwy25eMCwujO(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29254301 ^ -29236261)), kxZ0xApqQOoXhVW4IDJ(current));
								num3 = 42;
								continue;
							case 2:
								applicationUnit = licensedUnit as IApplicationUnit;
								num3 = 25;
								continue;
							case 48:
								current.DisabledReason = ModuleDisabledReason.Activation;
								num3 = 20;
								continue;
							case 21:
								DLkNZ13jvE6BDLmf2Cg(current, ModuleStatus.Disabled);
								num3 = 48;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
								{
									num3 = 40;
								}
								continue;
							case 17:
								if (current.Status != ModuleStatus.Disabled)
								{
									num3 = 2;
									continue;
								}
								goto case 9;
							case 6:
								DLkNZ13jvE6BDLmf2Cg(current, ModuleStatus.Disabled);
								num3 = 7;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
								{
									num3 = 45;
								}
								continue;
							case 15:
								if (serverModuleStatuses == null)
								{
									num3 = 39;
									continue;
								}
								goto case 5;
							case 13:
								if (licenseInfo != null)
								{
									num3 = 28;
									continue;
								}
								goto case 9;
							case 46:
								DLkNZ13jvE6BDLmf2Cg(current, value2);
								num3 = 11;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
								{
									num3 = 9;
								}
								continue;
							case 41:
								if (!serverModuleStatuses.TryGetValue(jGUClkpi8cj3WWqyZtt(current), out value))
								{
									num3 = 23;
									continue;
								}
								goto case 14;
							case 31:
								break;
							case 8:
							case 34:
								if (applicationUnit2 == null)
								{
									num3 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
									{
										num3 = 44;
									}
									continue;
								}
								goto case 22;
							case 7:
							case 39:
							case 49:
								applicationUnit2 = current;
								num4 = 8;
								goto IL_0069;
							case 19:
								if (!activatedModules.Contains(applicationUnit.Id))
								{
									num3 = 6;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
									{
										num3 = 6;
									}
									continue;
								}
								goto case 9;
							case 22:
								licensedUnit = applicationUnit2 as ILicensedUnit;
								num3 = 33;
								continue;
							case 14:
								if (value != ModuleStatus.Enabled)
								{
									num3 = 47;
									continue;
								}
								goto case 7;
							case 40:
							case 42:
							case 43:
							case 44:
								goto IL_0448;
							case 11:
								if (value2 == ModuleStatus.Disabled)
								{
									num3 = 3;
									continue;
								}
								goto case 15;
							case 16:
								DLkNZ13jvE6BDLmf2Cg(current, ModuleStatus.Enabled);
								num3 = 36;
								continue;
							case 9:
							case 10:
							case 29:
							case 38:
								applicationUnit2 = (IApplicationUnit)y9Rw7s37vtuqDCQyife(applicationUnit2);
								num3 = 32;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
								{
									num3 = 34;
								}
								continue;
							default:
								if (licenseInfo != null)
								{
									num3 = 35;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
									{
										num3 = 0;
									}
									continue;
								}
								goto case 13;
							case 27:
								if (!(licensedUnit is IApplication))
								{
									num3 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
									{
										num3 = 17;
									}
									continue;
								}
								goto case 9;
							case 37:
								if (current.Status != ModuleStatus.Disabled)
								{
									num3 = 21;
									continue;
								}
								goto case 13;
							case 12:
								current.DisabledReason = ModuleDisabledReason.DisabledOnServer;
								num3 = 18;
								continue;
							case 24:
								if (P7RptNpVLamYrCNwPMO(current) == ModuleStatus.Unknown)
								{
									num3 = 16;
									continue;
								}
								goto case 36;
							case 33:
								if (licensedUnit != null)
								{
									num3 = 17;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
									{
										num3 = 32;
									}
									continue;
								}
								goto case 9;
							case 4:
								log.WarnFormat((string)T6y7cn3dwy25eMCwujO(yONloC3ygB4MNggpRib(-1146510045 ^ -1146496243)), current.Title);
								num3 = 15;
								continue;
							case 5:
								if (!NpOjjbpRMXMKaqldEiq(current))
								{
									num3 = 49;
									continue;
								}
								goto case 41;
							case 30:
								if (!activatedModules.Any())
								{
									num4 = 9;
									goto IL_0069;
								}
								goto case 27;
							case 18:
								log.WarnFormat((string)T6y7cn3dwy25eMCwujO(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x18A6761F ^ 0x18A60871)), kxZ0xApqQOoXhVW4IDJ(current));
								num3 = 40;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
								{
									num3 = 16;
								}
								continue;
							case 32:
								licenseInfo = licensedUnit.GetLicenseInfo();
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
								{
									num3 = 0;
								}
								continue;
							case 26:
								log.WarnFormat(SR.T((string)yONloC3ygB4MNggpRib(-281842504 ^ -281865652)), kxZ0xApqQOoXhVW4IDJ(current));
								num3 = 43;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
								{
									num3 = 32;
								}
								continue;
							case 3:
								jpkPjwpSod5pILbep3X(current, ModuleDisabledReason.DisabledManually);
								num3 = 4;
								continue;
							case 35:
								if (MPovyqpKKJPra3Yif3v(licenseInfo) != 0)
								{
									num4 = 37;
									goto IL_0069;
								}
								goto case 13;
							case 36:
								if (savedModulesStatuses.TryGetValue(jGUClkpi8cj3WWqyZtt(current), out value2))
								{
									num3 = 46;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
									{
										num3 = 17;
									}
									continue;
								}
								goto case 15;
							case 1:
								return;
								IL_0069:
								num3 = num4;
								continue;
							}
							break;
						}
						goto IL_036e;
					}
				}
				finally
				{
					int num5;
					if (enumerator == null)
					{
						num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
						{
							num5 = 0;
						}
						goto IL_073c;
					}
					goto IL_0752;
					IL_0752:
					iuHeM53mWnmLRYCDxGL(enumerator);
					num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
					{
						num5 = 1;
					}
					goto IL_073c;
					IL_073c:
					switch (num5)
					{
					default:
						goto end_IL_0717;
					case 2:
						break;
					case 0:
						goto end_IL_0717;
					case 1:
						goto end_IL_0717;
					}
					goto IL_0752;
					end_IL_0717:;
				}
			case 0:
				return;
			}
		}
	}

	private void UpdateModuleStatusesByPackages()
	{
		//Discarded unreachable code: IL_006e, IL_0124, IL_0133, IL_028b, IL_02c3, IL_02d2
		int num = 2;
		int num2 = num;
		IEnumerator<PackageDescription> enumerator = default(IEnumerator<PackageDescription>);
		_003C_003Ec__DisplayClass52_0 _003C_003Ec__DisplayClass52_ = default(_003C_003Ec__DisplayClass52_0);
		IModule module = default(IModule);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				enumerator = packageService.Find(new PackageFilter
				{
					Level = PackageLevel.All,
					Status = PackageStatus.Any
				}).GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				try
				{
					while (true)
					{
						IL_01eb:
						int num3;
						if (!yiHGD7pvyVKFJQpxj3Y(enumerator))
						{
							num3 = 12;
							goto IL_007c;
						}
						goto IL_0165;
						IL_007c:
						while (true)
						{
							switch (num3)
							{
							case 12:
								return;
							case 7:
								_003C_003Ec__DisplayClass52_.package = enumerator.Current;
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
								{
									num3 = 3;
								}
								continue;
							case 9:
								if (module is ModuleBase)
								{
									num3 = 5;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
									{
										num3 = 5;
									}
									continue;
								}
								goto IL_01eb;
							case 2:
								if (jpLZJVpTslFh7r0gZHr(module) != ModuleStatus.Disabled)
								{
									num3 = 9;
									continue;
								}
								goto IL_01eb;
							case 5:
								DLkNZ13jvE6BDLmf2Cg((ModuleBase)module, ModuleStatus.Disabled);
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
								{
									num3 = 6;
								}
								continue;
							case 8:
								break;
							case 3:
								if (cIjf0TpXumxu1T6m4kp(_003C_003Ec__DisplayClass52_.package))
								{
									num3 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
									{
										num3 = 11;
									}
									continue;
								}
								goto default;
							default:
								module = modulesById.Values.FirstOrDefault(_003C_003Ec__DisplayClass52_._003CUpdateModuleStatusesByPackages_003Eb__0);
								num3 = 10;
								continue;
							case 10:
								if (module != null)
								{
									num3 = 2;
									continue;
								}
								goto IL_01eb;
							case 1:
							case 11:
								goto IL_01eb;
							case 4:
								log.WarnFormat(SR.T((string)yONloC3ygB4MNggpRib(-2112703338 ^ -2112697348)), module.Title);
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
								{
									num3 = 0;
								}
								continue;
							case 6:
							{
								jpkPjwpSod5pILbep3X((ModuleBase)module, ModuleDisabledReason.PackageNotInstalled);
								int num4 = 4;
								num3 = num4;
								continue;
							}
							}
							break;
						}
						goto IL_0165;
						IL_0165:
						_003C_003Ec__DisplayClass52_ = new _003C_003Ec__DisplayClass52_0();
						num3 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
						{
							num3 = 2;
						}
						goto IL_007c;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
						{
							num5 = 0;
						}
						while (true)
						{
							switch (num5)
							{
							default:
								iuHeM53mWnmLRYCDxGL(enumerator);
								num5 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
								{
									num5 = 0;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
			}
		}
	}

	private void UpdateModuleStatusesByComponents(IEnumerable<IStoreComponentInfo> serverStoreComponentInfos)
	{
		Dictionary<IModule, ModuleStatus> dictionary = new Dictionary<IModule, ModuleStatus>();
		using (IEnumerator<IStoreComponentInfo> enumerator = serverStoreComponentInfos.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass53_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass53_0();
				CS_0024_003C_003E8__locals0.serverComponent = enumerator.Current;
				StoreComponentConfigurationInfo storeComponentConfigurationInfo = installedStoreComponentInfos.FirstOrDefault((StoreComponentConfigurationInfo i) => ((string)_003C_003Ec__DisplayClass53_0.sxEVyxf95KeopuqZYNFZ(i)).Equals((string)_003C_003Ec__DisplayClass53_0.XVpqOvf9jhyMvq4fCYcy(CS_0024_003C_003E8__locals0.serverComponent), StringComparison.CurrentCultureIgnoreCase));
				foreach (IModule allModule in CS_0024_003C_003E8__locals0.serverComponent.AllModules)
				{
					if (storeComponentConfigurationInfo != null)
					{
						dictionary[allModule] = ModuleStatus.Enabled;
					}
					else if (!dictionary.ContainsKey(allModule))
					{
						dictionary[allModule] = ModuleStatus.Disabled;
					}
				}
			}
		}
		foreach (KeyValuePair<IModule, ModuleStatus> item in dictionary)
		{
			if (item.Key is ModuleBase moduleBase)
			{
				if (item.Value == ModuleStatus.Disabled && moduleBase.Status != ModuleStatus.Disabled)
				{
					moduleBase.Status = ModuleStatus.Disabled;
					moduleBase.DisabledReason = ModuleDisabledReason.NotUsedInDb;
					log.WarnFormat(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7459E02 ^ 0x745E1B2)), moduleBase.Title);
				}
				else if (item.Value == ModuleStatus.Enabled && moduleBase.Status == ModuleStatus.Disabled && moduleBase.DisabledReason == ModuleDisabledReason.DisabledManually)
				{
					moduleBase.Status = ModuleStatus.Enabled;
					moduleBase.DisabledReason = ModuleDisabledReason.Unknown;
				}
			}
		}
	}

	private void CheckRequiredComponentsForConfiguration(IElmaComponent packagingComponent, IEnumerable<StoreComponentConfigurationInfo> installedStoreComponentInfos, IEnumerable<IStoreComponentInfo> serverStoreComponentInfos)
	{
		_003C_003Ec__DisplayClass54_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass54_0();
		CS_0024_003C_003E8__locals0.packagingComponent = packagingComponent;
		infoToUpdateInDB.Clear();
		List<IStoreComponentInfo> list = new List<IStoreComponentInfo>();
		List<StoreComponentConfigurationInfo> list2 = new List<StoreComponentConfigurationInfo>();
		using (IEnumerator<StoreComponentConfigurationInfo> enumerator = installedStoreComponentInfos.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass54_1 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass54_1();
				CS_0024_003C_003E8__locals1.installedInfo = enumerator.Current;
				if (CS_0024_003C_003E8__locals1.installedInfo.Manifest != null && CS_0024_003C_003E8__locals1.installedInfo.Manifest.Packages.Where(delegate(PackageManifest p)
				{
					int num = 1;
					int num2 = num;
					ElmaPackageMetadata elmaPackageMetadata = default(ElmaPackageMetadata);
					while (true)
					{
						switch (num2)
						{
						default:
							return _003C_003Ec__DisplayClass54_0.Y5SQknf9cO02DSxj0ute(CS_0024_003C_003E8__locals0.packagingComponent, elmaPackageMetadata);
						case 1:
							elmaPackageMetadata = new ElmaPackageMetadata((string)_003C_003Ec__DisplayClass54_0.U6M7snf9scm7loXGKAAD(p));
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}).ToList().Count == 0)
				{
					continue;
				}
				IStoreComponentInfo storeComponentInfo = serverStoreComponentInfos.FirstOrDefault((IStoreComponentInfo i) => _003C_003Ec__DisplayClass54_1.f9BmZSfdooG11lumiVuo(i.Id, CS_0024_003C_003E8__locals1.installedInfo.Id, StringComparison.CurrentCultureIgnoreCase));
				SemanticVersion val = null;
				if (string.IsNullOrEmpty(CS_0024_003C_003E8__locals1.installedInfo.Version) || !SemanticVersion.TryParse(CS_0024_003C_003E8__locals1.installedInfo.Version, ref val))
				{
					val = null;
				}
				if (storeComponentInfo != null && storeComponentInfo.IsInstalled)
				{
					if (storeComponentInfo.InstalledVersion != (SemanticVersion)null && val != (SemanticVersion)null)
					{
						if (storeComponentInfo.InstalledVersion > val)
						{
							infoToUpdateInDB.Add(storeComponentInfo);
						}
						else if (storeComponentInfo.InstalledVersion < val)
						{
							if (!storeComponentInfo.IsLatestVersionInstalled && storeComponentInfo.LastVersion != (SemanticVersion)null && storeComponentInfo.LastVersion >= val)
							{
								list.Add(storeComponentInfo);
							}
							else if (CS_0024_003C_003E8__locals1.installedInfo.Status == StoreComponentStatus.Active)
							{
								list2.Add(CS_0024_003C_003E8__locals1.installedInfo);
							}
						}
						else if (CS_0024_003C_003E8__locals1.installedInfo.Status == StoreComponentStatus.Allowed)
						{
							infoToUpdateInDB.Add(storeComponentInfo);
						}
					}
					else if (CS_0024_003C_003E8__locals1.installedInfo.Status == StoreComponentStatus.Allowed)
					{
						infoToUpdateInDB.Add(storeComponentInfo);
					}
				}
				else if (storeComponentInfo != null && storeComponentInfo.LastVersion != (SemanticVersion)null)
				{
					list.Add(storeComponentInfo);
				}
				else if (CS_0024_003C_003E8__locals1.installedInfo.Status == StoreComponentStatus.Active)
				{
					list2.Add(CS_0024_003C_003E8__locals1.installedInfo);
				}
			}
		}
		if (list2.Count > 0)
		{
			dbPreUpdater?.EndUpdating();
			throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921234985), string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-195614443 ^ -195615465), list2.Select((StoreComponentConfigurationInfo c) => (string)_003C_003Ec.oXFNTwfJ3Ore1AlF2SrF(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-210725949 ^ -210373581), SR.T((string)_003C_003Ec.SvnTZyfJ1Fka1fP3nGEF(c)), _003C_003Ec.u7yadlfJNMwAAo373us6(_003C_003Ec.Njc2tyfJnhg3mBiiug8t(c), _003C_003Ec.TLpCyMfJTMJ1YITq5kHL(-2106517564 ^ -2106499354), c.Version))))));
		}
		if (list.Count > 0)
		{
			dbPreUpdater?.EndUpdating();
			throw new RequiredInstallStoreComponentsException(list);
		}
	}

	private void CheckComponentsStatusForConfiguration(IElmaComponent packagingComponent, IEnumerable<StoreComponentConfigurationInfo> installedStoreComponentInfos, IEnumerable<IStoreComponentInfo> serverStoreComponentInfos)
	{
		_003C_003Ec__DisplayClass55_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass55_0();
		CS_0024_003C_003E8__locals0.packagingComponent = packagingComponent;
		List<StoreComponentConfigurationInfo> list = new List<StoreComponentConfigurationInfo>();
		List<string> activationKeys = (from p in ComponentManager.Current.LicenseManager.GetActivationKeys()
			select p.Value).ToList();
		using (IEnumerator<StoreComponentConfigurationInfo> enumerator = installedStoreComponentInfos.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass55_1 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass55_1();
				CS_0024_003C_003E8__locals1.installedInfo = enumerator.Current;
				bool flag = false;
				bool flag2 = false;
				if (CS_0024_003C_003E8__locals1.installedInfo.Manifest != null)
				{
					if (CS_0024_003C_003E8__locals1.installedInfo.Manifest.ActivationType == ElmaStoreComponentActivationType.Paid)
					{
						flag2 = true;
						if (CS_0024_003C_003E8__locals1.installedInfo.Signatures != null && CS_0024_003C_003E8__locals1.installedInfo.Signatures.Any())
						{
							ComponentLicenseInfo licenseInfo = ElmaStoreComponentsBuilder.GetLicenseInfo(CS_0024_003C_003E8__locals1.installedInfo.Manifest, CS_0024_003C_003E8__locals1.installedInfo.Signatures, activationKeys, GetMainLicensedUnitExpiration);
							if (licenseInfo != null)
							{
								flag = true;
								if (licenseInfo.Status != 0)
								{
									list.Add(CS_0024_003C_003E8__locals1.installedInfo);
								}
							}
						}
					}
					if (CS_0024_003C_003E8__locals1.installedInfo.Manifest.Packages.Where(delegate(PackageManifest p)
					{
						int num3 = 1;
						int num4 = num3;
						ElmaPackageMetadata metadata = default(ElmaPackageMetadata);
						while (true)
						{
							switch (num4)
							{
							case 1:
								metadata = new ElmaPackageMetadata((string)_003C_003Ec__DisplayClass55_0.gvI5RUfdfFNtFKiYPZCy(p));
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
								{
									num4 = 0;
								}
								break;
							default:
								return CS_0024_003C_003E8__locals0.packagingComponent.IsCompatible(metadata);
							}
						}
					}).ToList().Count == 0)
					{
						continue;
					}
				}
				IStoreComponentInfo storeComponentInfo = serverStoreComponentInfos.FirstOrDefault((IStoreComponentInfo i) => _003C_003Ec__DisplayClass55_1.IWtY2JfdZJSWJ7XjIhmp(i.Id, CS_0024_003C_003E8__locals1.installedInfo.Id, StringComparison.CurrentCultureIgnoreCase));
				if (storeComponentInfo != null && storeComponentInfo.IsInstalled)
				{
					ILicensedUnit licensedUnit = storeComponentInfo.LicensedUnit;
					if (licensedUnit != null)
					{
						ILicenseInfo licenseInfo2 = licensedUnit.GetLicenseInfo();
						if (licenseInfo2 != null)
						{
							flag = true;
							if (licenseInfo2.Status != 0)
							{
								list.Add(CS_0024_003C_003E8__locals1.installedInfo);
							}
						}
					}
				}
				if (!flag2)
				{
				}
			}
		}
		if (list.Count <= 0)
		{
			return;
		}
		throw new LicenseActivationRequiredException(list.Select(delegate(StoreComponentConfigurationInfo c)
		{
			//Discarded unreachable code: IL_002d, IL_003c
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (!_003C_003Ec.C3F1a2fJpIvAFNX9XZfb(_003C_003Ec.SvnTZyfJ1Fka1fP3nGEF(c)))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto default;
				default:
					return (string)_003C_003Ec.Njc2tyfJnhg3mBiiug8t(c);
				case 1:
					return c.Title;
				}
			}
		}).ToArray());
	}

	private static IEnumerable<string> GetDeprecatedComponentFiles(IEnumerable<IStoreComponentInfo> storeComponentInfos, object repositoryPath)
	{
		_003C_003Ec__DisplayClass56_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass56_0();
		CS_0024_003C_003E8__locals0.repositoryPath = (string)repositoryPath;
		return storeComponentInfos.Where(delegate(IStoreComponentInfo info)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return _003C_003Ec.R1TkvCfJaLivejQetpkk(info) == ModuleDisabledReason.Deprecated;
				case 1:
					if (_003C_003Ec.URXMpIfJRPH0iktvlWwC(info) != ModuleStatus.Disabled)
					{
						return false;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}).SelectMany((IStoreComponentInfo info) => GetComponentFiles(info, CS_0024_003C_003E8__locals0.repositoryPath)).Distinct();
	}

	private static IEnumerable<string> GetComponentFiles(object info, object repositoryPath)
	{
		_003C_003Ec__DisplayClass57_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass57_0();
		CS_0024_003C_003E8__locals0.repositoryPath = (string)repositoryPath;
		CS_0024_003C_003E8__locals0.manifestComponent = info as ManifestStoreComponentInfo;
		if (CS_0024_003C_003E8__locals0.manifestComponent != null)
		{
			return CS_0024_003C_003E8__locals0.manifestComponent.AllPackages.Select((PackageDescription p) => (string)_003C_003Ec.I0abZpfJt95P3rZtdAX9(_003C_003Ec.TLpCyMfJTMJ1YITq5kHL(-1939377524 ^ -1939727738), _003C_003Ec.awqQuJfJDqE6CksVNroY(p))).Union(ElmaStoreComponentFile.SupportedComponentMask.Select((string mask) => (string)_003C_003Ec__DisplayClass57_0.l6PMoOfdkRFQTJ2m8NAJ(_003C_003Ec__DisplayClass57_0.I3TaNDfdTSheOJ4aQUJK(_003C_003Ec__DisplayClass57_0.j76tAXfdXiPbI4oPpFiR(CS_0024_003C_003E8__locals0.manifestComponent), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921196793), mask), Array.Empty<object>()))).Union(ElmaStoreComponentFile.SupportedManifestMask.Select((string mask) => (string)_003C_003Ec__DisplayClass57_0.l6PMoOfdkRFQTJ2m8NAJ(_003C_003Ec__DisplayClass57_0.I3TaNDfdTSheOJ4aQUJK(CS_0024_003C_003E8__locals0.manifestComponent.Id, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1979251663 ^ -1979244811), mask), Array.Empty<object>())))
				.Union(new string[2]
				{
					string.Format(CS_0024_003C_003E8__locals0.manifestComponent.Id + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x20261A4F ^ 0x20269AFB)),
					string.Format(CS_0024_003C_003E8__locals0.manifestComponent.Id + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710608382))
				})
				.SelectMany((string pattern) => Directory.EnumerateFiles(CS_0024_003C_003E8__locals0.repositoryPath, pattern, SearchOption.TopDirectoryOnly));
		}
		return Enumerable.Empty<string>();
	}

	internal static void CreateDbStructures(ITransformationProvider transform, int version)
	{
		//Discarded unreachable code: IL_008b
		int num = 9;
		int num2 = num;
		Table table3 = default(Table);
		Table table = default(Table);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 6:
				transform.AddTable(table3);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num2 = 2;
				}
				continue;
			case 9:
				if (version == 0)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
					{
						num2 = 8;
					}
					continue;
				}
				return;
			case 5:
				return;
			case 8:
				if (!POMfEGpkRyXSF6PrYrk(transform, yONloC3ygB4MNggpRib(0x4D1C1EE4 ^ 0x4D1C9E08)))
				{
					num2 = 3;
					continue;
				}
				goto case 7;
			case 3:
			{
				Table table2 = new Table();
				OEfs2Tpn5J5PrhNJqYi(table2, yONloC3ygB4MNggpRib(-867826612 ^ -867793760));
				table2.Columns = new List<Column>
				{
					new Column((string)yONloC3ygB4MNggpRib(-29254301 ^ -29287313), DbType.Guid),
					new Column(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x49E27B8A ^ 0x49E2FAA8), DbType.Int32)
				};
				table = table2;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
				{
					num2 = 1;
				}
				continue;
			}
			case 1:
				BNyjwspOPY0cjvbRZim(transform, table);
				num2 = 7;
				continue;
			case 4:
			{
				Index index = new Index();
				J2KZrAp2HuEihN1WQrK(index, yONloC3ygB4MNggpRib(-218496594 ^ -218464112));
				aJASigpe8g59sQ3a9wu(index, yONloC3ygB4MNggpRib(-1921202237 ^ -1921235393));
				index.Columns.Add((string)yONloC3ygB4MNggpRib(0x4DC2B14D ^ 0x4DC23013));
				transform.AddUniqueIndex(index);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			case 7:
				if (POMfEGpkRyXSF6PrYrk(transform, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CB464B ^ 0x53CBC775)))
				{
					num2 = 5;
					continue;
				}
				break;
			case 2:
				break;
			case 0:
				return;
			}
			Table table4 = new Table();
			OEfs2Tpn5J5PrhNJqYi(table4, yONloC3ygB4MNggpRib(0xE1229CF ^ 0xE12A8F1));
			table4.Columns = new List<Column>
			{
				new Column((string)yONloC3ygB4MNggpRib(-629844702 ^ -629812100), new ColumnType(DbType.String, 255)),
				new Column(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 0x4F7FB374), new ColumnType(DbType.String, int.MaxValue)),
				new Column((string)yONloC3ygB4MNggpRib(-210725949 ^ -210758985), new ColumnType(DbType.String, 255)),
				new Column(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x10E41EDB ^ 0x10E49F5D), DbType.Int32),
				new Column((string)yONloC3ygB4MNggpRib(0x1637C429 ^ 0x163745BF), new ColumnType(DbType.String, 255)),
				new Column((string)yONloC3ygB4MNggpRib(0x103FE975 ^ 0x103F68C1), DbType.Int32),
				new Column((string)yONloC3ygB4MNggpRib(-561074844 ^ -561107788), new ColumnType(DbType.String, int.MaxValue)),
				new Column((string)yONloC3ygB4MNggpRib(-1852837372 ^ -1852869664), DbType.Binary)
			};
			table3 = table4;
			num2 = 6;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
			{
				num2 = 4;
			}
		}
	}

	private void LoadSavedModuleStatuses()
	{
		//Discarded unreachable code: IL_005a, IL_0069, IL_00ce, IL_00d8, IL_01e6, IL_021e, IL_022d
		int num = 1;
		int num2 = num;
		IDataReader dataReader = default(IDataReader);
		Guid key = default(Guid);
		ModuleStatus value = default(ModuleStatus);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (transformationProvider != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			case 2:
				return;
			default:
				dataReader = transformationProvider.ExecuteQuery((string)mvJMT9pN9DhRaWVIlCD(yONloC3ygB4MNggpRib(0x42643203 ^ 0x4264B025), nikZbnp18ka5K8Sp8EL(PQlFZ9pP2CyFgoPbJoo(transformationProvider), yONloC3ygB4MNggpRib(0x34A6D230 ^ 0x34A652DC))));
				num2 = 4;
				break;
			case 4:
				try
				{
					while (true)
					{
						IL_0143:
						int num3;
						if (!dataReader.Read())
						{
							num3 = 4;
							goto IL_00dc;
						}
						goto IL_00fa;
						IL_00dc:
						while (true)
						{
							switch (num3)
							{
							case 3:
								break;
							case 2:
								goto IL_0143;
							default:
								savedModulesStatuses[key] = value;
								num3 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
								{
									num3 = 2;
								}
								continue;
							case 1:
								value = (ModuleStatus)W6smCNpa8rqMQZCNgsT(dataReader[(string)yONloC3ygB4MNggpRib(0x7C1EE318 ^ 0x7C1E623A)]);
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
								{
									num3 = 0;
								}
								continue;
							case 4:
								return;
							}
							break;
						}
						goto IL_00fa;
						IL_00fa:
						key = qNjHT7pp57kACrTj8IH(PQlFZ9pP2CyFgoPbJoo(transformationProvider), xBLEm0p31qkQ5IvcsFm(dataReader, yONloC3ygB4MNggpRib(-1123633026 ^ -1123665550)));
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
						{
							num3 = 1;
						}
						goto IL_00dc;
					}
				}
				finally
				{
					if (dataReader != null)
					{
						int num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								iuHeM53mWnmLRYCDxGL(dataReader);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
								{
									num4 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
			case 3:
				return;
			}
		}
	}

	private void SaveModuleStatusToDb(Guid uid, ModuleStatus status)
	{
		int num = 4;
		int num2 = num;
		string sql = default(string);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 2:
				transformationProvider.ExecuteNonQuery(sql, new Dictionary<string, object> { 
				{
					z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638435699),
					uid
				} });
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				return;
			case 5:
				transformationProvider.ExecuteNonQuery(sql, new Dictionary<string, object> { 
				{
					(string)yONloC3ygB4MNggpRib(0x4D1C1EE4 ^ 0x4D1C9C78),
					uid
				} });
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				sql = (string)vZJeQCpw0JvvMLPgcOC(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218463460), new object[5]
				{
					((Dialect)PQlFZ9pP2CyFgoPbJoo(transformationProvider)).QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-475857671 ^ -475890667)),
					nikZbnp18ka5K8Sp8EL(PQlFZ9pP2CyFgoPbJoo(transformationProvider), yONloC3ygB4MNggpRib(-210725949 ^ -210758961)),
					nikZbnp18ka5K8Sp8EL(transformationProvider.Dialect, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1ECE530A ^ 0x1ECED228)),
					TheDa1pD5QxNyWuVDpV(transformationProvider),
					(int)status
				});
				num2 = 2;
				break;
			case 4:
				if (transformationProvider != null)
				{
					sql = (string)mXTG76ptt81V82tSAi6(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-521266112 ^ -521232884), nikZbnp18ka5K8Sp8EL(PQlFZ9pP2CyFgoPbJoo(transformationProvider), yONloC3ygB4MNggpRib(-882126494 ^ -882159218)), nikZbnp18ka5K8Sp8EL(PQlFZ9pP2CyFgoPbJoo(transformationProvider), yONloC3ygB4MNggpRib(0x76DD48E ^ 0x76D5582)), TheDa1pD5QxNyWuVDpV(transformationProvider));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
					{
						num2 = 5;
					}
				}
				else
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
					{
						num2 = 3;
					}
				}
				break;
			}
		}
	}

	private void LoadStoreComponentConfigurationInfos()
	{
		//Discarded unreachable code: IL_0092, IL_00a1, IL_00ac, IL_013c, IL_01a9, IL_0203, IL_026a, IL_02df, IL_0373, IL_0382, IL_0418, IL_0422, IL_06d1, IL_0711, IL_071c, IL_072b
		int num = 1;
		int num2 = num;
		IDataReader dataReader = default(IDataReader);
		StoreComponentConfigurationInfo storeComponentConfigurationInfo = default(StoreComponentConfigurationInfo);
		string text = default(string);
		byte[] array = default(byte[]);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				dataReader = transformationProvider.ExecuteQuery((string)mvJMT9pN9DhRaWVIlCD(yONloC3ygB4MNggpRib(-951514650 ^ -951481408), nikZbnp18ka5K8Sp8EL(transformationProvider.Dialect, yONloC3ygB4MNggpRib(-475857671 ^ -475890233))));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				while (true)
				{
					IL_0358:
					int num3;
					if (!AtLuOPp0HkjuWfuFT95(dataReader))
					{
						num3 = 24;
						goto IL_00b0;
					}
					goto IL_02e4;
					IL_00b0:
					while (true)
					{
						object obj;
						object obj2;
						switch (num3)
						{
						case 24:
							return;
						case 1:
							m9pQrSpWnf13sPhlEc4(storeComponentConfigurationInfo, ClassSerializationHelper.DeserializeObjectByXml<ElmaStoreComponentManifest>(text, useComponentManager: false));
							num3 = 10;
							continue;
						case 13:
							if (qrMmTWp641xiDg5vrSs(dyLHTMp4DVSetq5MxCD(storeComponentConfigurationInfo), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x307E9FD1 ^ 0x307E1CF1)))
							{
								num3 = 15;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
								{
									num3 = 15;
								}
								continue;
							}
							goto case 3;
						case 6:
							try
							{
								IEnumerable<StoreComponentSignatureInfo> signatures = StoreComponentSignatureInfo.Decompress(array);
								int num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
								{
									num4 = 0;
								}
								while (true)
								{
									switch (num4)
									{
									case 1:
										storeComponentConfigurationInfo.Signatures = signatures;
										num4 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
										{
											num4 = 0;
										}
										continue;
									case 0:
										break;
									}
									break;
								}
							}
							catch (Exception innerException)
							{
								int num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
								{
									num5 = 0;
								}
								switch (num5)
								{
								default:
									throw new InvalidOperationException(SR.T((string)yONloC3ygB4MNggpRib(0x34A6D230 ^ 0x34A65198), (!YiDquWp7wpcjTjcP7sO(Ts3wDkpA8qCNAnReBfp(storeComponentConfigurationInfo))) ? Ts3wDkpA8qCNAnReBfp(storeComponentConfigurationInfo) : storeComponentConfigurationInfo.Id), innerException);
								}
							}
							goto case 19;
						case 4:
							if (xBLEm0p31qkQ5IvcsFm(dataReader, yONloC3ygB4MNggpRib(-2099751081 ^ -2099718477)) is DBNull)
							{
								num3 = 12;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
								{
									num3 = 12;
								}
								continue;
							}
							obj = (byte[])xBLEm0p31qkQ5IvcsFm(dataReader, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3CE17B75 ^ 0x3CE1FA91));
							goto IL_068f;
						case 2:
							if (!string.IsNullOrEmpty(text))
							{
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
								{
									num3 = 1;
								}
								continue;
							}
							goto case 10;
						case 12:
							obj = null;
							goto IL_068f;
						case 5:
							break;
						case 3:
							if (qrMmTWp641xiDg5vrSs(dyLHTMp4DVSetq5MxCD(storeComponentConfigurationInfo), yONloC3ygB4MNggpRib(0x12A5FAC7 ^ 0x12A57997)))
							{
								num3 = 14;
								continue;
							}
							goto case 18;
						case 10:
							if (array == null)
							{
								num3 = 19;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
								{
									num3 = 9;
								}
								continue;
							}
							goto default;
						case 11:
						case 14:
						case 15:
							goto IL_0358;
						case 19:
						case 23:
							JQbk1ypxL15KXUMbbPV(storeComponentConfigurationInfo);
							num3 = 6;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
							{
								num3 = 8;
							}
							continue;
						case 9:
							if (xBLEm0p31qkQ5IvcsFm(dataReader, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217490711)) is DBNull)
							{
								num3 = 10;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
								{
									num3 = 22;
								}
								continue;
							}
							obj2 = (string)dataReader[(string)yONloC3ygB4MNggpRib(-1998538950 ^ -1998571798)];
							goto IL_0667;
						default:
							if (array.Length != 0)
							{
								num3 = 6;
								continue;
							}
							goto case 19;
						case 8:
							installedStoreComponentInfos.Add(storeComponentConfigurationInfo);
							num3 = 11;
							continue;
						case 22:
							obj2 = null;
							goto IL_0667;
						case 20:
							rkFdxe3LbLmFXWqaDBK(storeComponentConfigurationInfo, (string)xBLEm0p31qkQ5IvcsFm(dataReader, yONloC3ygB4MNggpRib(-309639236 ^ -309606686)));
							num3 = 13;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
							{
								num3 = 4;
							}
							continue;
						case 18:
							xhl4Ab3sIas6KSoKJAA(storeComponentConfigurationInfo, (!(xBLEm0p31qkQ5IvcsFm(dataReader, yONloC3ygB4MNggpRib(0x34A6D230 ^ 0x34A65356)) is DBNull)) ? ((string)xBLEm0p31qkQ5IvcsFm(dataReader, yONloC3ygB4MNggpRib(-289714582 ^ -289681652))) : null);
							num3 = 21;
							continue;
						case 21:
							storeComponentConfigurationInfo.Version = ((!(xBLEm0p31qkQ5IvcsFm(dataReader, yONloC3ygB4MNggpRib(-195614443 ^ -195581855)) is DBNull)) ? ((string)xBLEm0p31qkQ5IvcsFm(dataReader, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867231519))) : null);
							num3 = 17;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
							{
								num3 = 0;
							}
							continue;
						case 17:
							OetiW4pHr23Uq4O0arV(storeComponentConfigurationInfo, (!(dataReader[(string)yONloC3ygB4MNggpRib(-2112703338 ^ -2112735984)] is DBNull)) ? ((StoreComponentStatus)W6smCNpa8rqMQZCNgsT(xBLEm0p31qkQ5IvcsFm(dataReader, yONloC3ygB4MNggpRib(-1979251663 ^ -1979218505)))) : StoreComponentStatus.Active);
							num3 = 7;
							continue;
						case 7:
							storeComponentConfigurationInfo.DeployVersion = ((!(xBLEm0p31qkQ5IvcsFm(dataReader, yONloC3ygB4MNggpRib(0x35C0467B ^ 0x35C0C7ED)) is DBNull)) ? ((string)dataReader[(string)yONloC3ygB4MNggpRib(0x7C1EE318 ^ 0x7C1E628E)]) : null);
							num3 = 16;
							continue;
						case 16:
							{
								oVRZM8pGulEWGGvneFD(storeComponentConfigurationInfo, (!(xBLEm0p31qkQ5IvcsFm(dataReader, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x638095EB ^ 0x6380145F)) is DBNull)) ? ((AutoDeployComponentStatus)Convert.ToInt32(xBLEm0p31qkQ5IvcsFm(dataReader, yONloC3ygB4MNggpRib(-1867198571 ^ -1867231711)))) : AutoDeployComponentStatus.None);
								num3 = 9;
								continue;
							}
							IL_0667:
							text = (string)obj2;
							num3 = 4;
							continue;
							IL_068f:
							array = (byte[])obj;
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
							{
								num3 = 0;
							}
							continue;
						}
						break;
					}
					goto IL_02e4;
					IL_02e4:
					storeComponentConfigurationInfo = new StoreComponentConfigurationInfo(this);
					num3 = 20;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num3 = 3;
					}
					goto IL_00b0;
				}
			}
			finally
			{
				int num6;
				if (dataReader == null)
				{
					num6 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
					{
						num6 = 1;
					}
					goto IL_06d5;
				}
				goto IL_06eb;
				IL_06eb:
				iuHeM53mWnmLRYCDxGL(dataReader);
				num6 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
				{
					num6 = 0;
				}
				goto IL_06d5;
				IL_06d5:
				switch (num6)
				{
				default:
					goto end_IL_06b0;
				case 2:
					break;
				case 1:
					goto end_IL_06b0;
				case 0:
					goto end_IL_06b0;
				}
				goto IL_06eb;
				end_IL_06b0:;
			}
		}
	}

	private void SaveStoreComponentConfigurationInfos(IEnumerable<StoreComponentConfigurationInfo> infos)
	{
		transformationProvider.BeginTransaction();
		try
		{
			transformationProvider.ExecuteNonQuery(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97938360), transformationProvider.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146543075))));
			foreach (StoreComponentConfigurationInfo info in infos)
			{
				InsertStoreComponentConfigurationInfo(info);
			}
			transformationProvider.CommitTransaction();
		}
		catch
		{
			transformationProvider.RollbackTransaction();
			throw;
		}
	}

	private void SaveStoreComponentConfigurationInfo(StoreComponentConfigurationInfo info)
	{
		//Discarded unreachable code: IL_00e5, IL_0165, IL_01a2
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 2:
				try
				{
					transformationProvider.ExecuteNonQuery((string)mXTG76ptt81V82tSAi6(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x92F12D5 ^ 0x92F9695), nikZbnp18ka5K8Sp8EL(PQlFZ9pP2CyFgoPbJoo(transformationProvider), yONloC3ygB4MNggpRib(-1411196499 ^ -1411229549)), nikZbnp18ka5K8Sp8EL(PQlFZ9pP2CyFgoPbJoo(transformationProvider), yONloC3ygB4MNggpRib(0x57A5235E ^ 0x57A5A200)), TheDa1pD5QxNyWuVDpV(transformationProvider)), new Dictionary<string, object> { 
					{
						(string)yONloC3ygB4MNggpRib(-2106517564 ^ -2106485944),
						info.Id
					} });
					int num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						default:
							return;
						case 0:
							return;
						case 2:
							nKidfWpm0w5fIS182iy(transformationProvider);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
							{
								num3 = 0;
							}
							break;
						case 1:
							InsertStoreComponentConfigurationInfo(info);
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
							{
								num3 = 2;
							}
							break;
						}
					}
				}
				catch
				{
					int num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
					{
						num4 = 1;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							qvH0ghpyNoKNIMPf7FJ(transformationProvider);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
							{
								num4 = 0;
							}
							break;
						default:
							throw;
						}
					}
				}
			case 4:
				return;
			case 1:
				if (info == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
					{
						num2 = 0;
					}
				}
				else if (transformationProvider != null)
				{
					transformationProvider.BeginTransaction();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
					{
						num2 = 1;
					}
				}
				else
				{
					num2 = 4;
				}
				break;
			default:
				throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3CE17B75 ^ 0x3CE10E33));
			}
		}
	}

	private void InsertStoreComponentConfigurationInfo(StoreComponentConfigurationInfo info)
	{
		//Discarded unreachable code: IL_005a, IL_006a, IL_0074, IL_01d8
		int num = 3;
		string text = default(string);
		byte[] value = default(byte[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj2;
				object obj;
				switch (num2)
				{
				default:
					return;
				case 3:
					if (hJKXPmpMrT1dNVVdIBo(info) == null)
					{
						num2 = 2;
						continue;
					}
					obj2 = ClassSerializationHelper.SerializeObjectByXml(info.Manifest, useComponentManager: false);
					goto IL_0207;
				case 4:
				case 7:
					obj = null;
					break;
				case 0:
					return;
				case 1:
					if (info.Signatures == null)
					{
						num2 = 7;
						continue;
					}
					goto case 8;
				case 5:
					VL40blp9ywHdKskC2h9(transformationProvider, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1108654032 ^ -1108621042), new string[8]
					{
						(string)yONloC3ygB4MNggpRib(-1876063057 ^ -1876095503),
						z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867231501),
						z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A6135BE ^ 0x3A61B4CA),
						(string)yONloC3ygB4MNggpRib(0x3A5D5EF ^ 0x3A55469),
						(string)yONloC3ygB4MNggpRib(0x66F566B6 ^ 0x66F5E720),
						(string)yONloC3ygB4MNggpRib(--1418440330 ^ 0x548B2F3E),
						(string)yONloC3ygB4MNggpRib(-538519530 ^ -538551866),
						(string)yONloC3ygB4MNggpRib(0x3CE17B75 ^ 0x3CE1FA91)
					}, new object[8]
					{
						dyLHTMp4DVSetq5MxCD(info),
						Ts3wDkpA8qCNAnReBfp(info),
						Co6sAIpJxoUy6YirMj7(info),
						(int)nWhm5b3YKIDl314M13q(info),
						info.DeployVersion,
						(int)Wsce5IphTR50SQ5rsEu(info),
						text,
						new ParameterValue(DbType.Binary, value)
					});
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					obj2 = null;
					goto IL_0207;
				case 8:
					if (info.Signatures.Any())
					{
						goto end_IL_0012;
					}
					goto case 4;
				case 6:
					{
						obj = StoreComponentSignatureInfo.Compress(info.Signatures);
						break;
					}
					IL_0207:
					text = (string)obj2;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				value = (byte[])obj;
				num2 = 5;
				continue;
				end_IL_0012:
				break;
			}
			num = 6;
		}
	}

	static ModuleManager()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				oSb9g2pdI90cCdc8cXO();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				log = (ILogger)K6pmOGplRI6sDxk56H2(yONloC3ygB4MNggpRib(-1123633026 ^ -1123664672));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object BVcm5i3AuIFiiyn3CWX(object P_0)
	{
		return ((Application)P_0).MainLicensedUnit;
	}

	internal static bool PNTXtK36LfU89Nj5O58()
	{
		return bstp4K34ECorWvCd3sT == null;
	}

	internal static ModuleManager r0JUUP3HM5LHPXgfZbm()
	{
		return bstp4K34ECorWvCd3sT;
	}

	internal static object y9Rw7s37vtuqDCQyife(object P_0)
	{
		return ((IApplicationUnit)P_0).Owner;
	}

	internal static object viBoOG3xGktHcXIjbKZ(object P_0)
	{
		return SR.M((string)P_0);
	}

	internal static object xd3TkY30TRJgcA0Gcwk(double completePercent, object P_1)
	{
		return StartInformation.Operation(completePercent, (string)P_1);
	}

	internal static void iuHeM53mWnmLRYCDxGL(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object yONloC3ygB4MNggpRib(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object Au5noq3MyumEpUNuXEA(object P_0)
	{
		return ((PackageService)P_0).GetComponent();
	}

	internal static bool VYyCqi3JOYKnxSFMxKe(object P_0)
	{
		return ((IElmaComponent)P_0).IsInstalled();
	}

	internal static int YXwOUB39tk7WWU7qYpd(object P_0)
	{
		return ((List<StoreComponentConfigurationInfo>)P_0).Count;
	}

	internal static object T6y7cn3dwy25eMCwujO(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object JY5ViB3lQGjSNqgjRWT(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static void fb0eAe3rAXkRVCqXPRS(object P_0, object P_1)
	{
		((ILogger)P_0).Error(P_1);
	}

	internal static object e5GOnH3gL6FkjYerpVx(object P_0)
	{
		return ((IElmaComponent)P_0).GetConfigurationPackagesDirectory();
	}

	internal static void kRCEf935Iwk42OJbs5K(object P_0)
	{
		File.Delete((string)P_0);
	}

	internal static void DLkNZ13jvE6BDLmf2Cg(object P_0, ModuleStatus value)
	{
		((ModuleBase)P_0).Status = value;
	}

	internal static StoreComponentStatus nWhm5b3YKIDl314M13q(object P_0)
	{
		return ((StoreComponentConfigurationInfo)P_0).Status;
	}

	internal static void rkFdxe3LbLmFXWqaDBK(object P_0, object P_1)
	{
		((StoreComponentConfigurationInfo)P_0).Id = (string)P_1;
	}

	internal static object ByS20C3UIDGVZNSBNUu(object P_0)
	{
		return ((IStoreComponentInfo)P_0).Title;
	}

	internal static void xhl4Ab3sIas6KSoKJAA(object P_0, object P_1)
	{
		((StoreComponentConfigurationInfo)P_0).Title = (string)P_1;
	}

	internal static object gwsKGy3cAuMQuMLtXfm(object P_0)
	{
		return ((IStoreComponentInfo)P_0).InstalledVersion;
	}

	internal static bool AwOZwt3zbx1CXTaF9kw(object P_0, object P_1)
	{
		return (SemanticVersion)P_0 != (SemanticVersion)P_1;
	}

	internal static void RYyZt8pFHQCPdFvpZGX(object P_0, object P_1)
	{
		((StoreComponentConfigurationInfo)P_0).Version = (string)P_1;
	}

	internal static object SFeA9OpB0kWZ4CZ69VS(object P_0)
	{
		return ((ManifestStoreComponentInfo)P_0).LastManifest;
	}

	internal static void m9pQrSpWnf13sPhlEc4(object P_0, object P_1)
	{
		((StoreComponentConfigurationInfo)P_0).Manifest = (ElmaStoreComponentManifest)P_1;
	}

	internal static object Mxao2GpoH3j3rHjDeqf(object P_0)
	{
		return ((ManifestStoreComponentInfo)P_0).InstalledFile;
	}

	internal static object KwFBXKpbx8pGbmVOeUF(object P_0)
	{
		return ((ManifestStoreComponentInfo)P_0).LastFile;
	}

	internal static AutoDeployComponentStatus Wsce5IphTR50SQ5rsEu(object P_0)
	{
		return ((StoreComponentConfigurationInfo)P_0).DeployStatus;
	}

	internal static void oVRZM8pGulEWGGvneFD(object P_0, AutoDeployComponentStatus value)
	{
		((StoreComponentConfigurationInfo)P_0).DeployStatus = value;
	}

	internal static object axXbShpExox4KD0IfdS(object P_0)
	{
		return ((StoreComponentConfigurationInfo)P_0).DeployVersion;
	}

	internal static void iwYfvvpfg3gZfFMs6td(object P_0, object P_1)
	{
		((StoreComponentConfigurationInfo)P_0).DeployVersion = (string)P_1;
	}

	internal static ModuleStatus ngtxIXpQl2A3PXVLYB6(object P_0)
	{
		return ((IStoreComponentInfo)P_0).Status;
	}

	internal static ModuleDisabledReason zck0uqpCnRQt4SNTHOI(object P_0)
	{
		return ((IStoreComponentInfo)P_0).DisabledReason;
	}

	internal static bool yiHGD7pvyVKFJQpxj3Y(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static object thF2eJp85704Nk54WwF(object P_0)
	{
		return ((IApplicationUnit)P_0).Id;
	}

	internal static Guid HbHbtIpZSxNStZA7kQ9(object P_0)
	{
		return ((IApplicationUnit)P_0).Uid;
	}

	internal static void soLcsrpuMFAfRcbevLd(object P_0)
	{
		((ConcurrentDictionary<Assembly, Tuple<bool, ModuleDisabledReason>>)P_0).Clear();
	}

	internal static object fMZA9kpI308HGCkyBLl(object P_0)
	{
		return ((IModuleAssembly)P_0).Assembly;
	}

	internal static ModuleStatus P7RptNpVLamYrCNwPMO(object P_0)
	{
		return ((ModuleBase)P_0).Status;
	}

	internal static void jpkPjwpSod5pILbep3X(object P_0, ModuleDisabledReason value)
	{
		((ModuleBase)P_0).DisabledReason = value;
	}

	internal static Guid jGUClkpi8cj3WWqyZtt(object P_0)
	{
		return ((ApplicationUnit)P_0).Uid;
	}

	internal static bool NpOjjbpRMXMKaqldEiq(object P_0)
	{
		return ((ModuleBase)P_0).ServerModuleRequired;
	}

	internal static object kxZ0xApqQOoXhVW4IDJ(object P_0)
	{
		return ((ApplicationUnit)P_0).Title;
	}

	internal static LicenseStatus MPovyqpKKJPra3Yif3v(object P_0)
	{
		return ((ILicenseInfo)P_0).Status;
	}

	internal static bool cIjf0TpXumxu1T6m4kp(object P_0)
	{
		return ((PackageDescription)P_0).IsInstalled;
	}

	internal static ModuleStatus jpLZJVpTslFh7r0gZHr(object P_0)
	{
		return ((IModule)P_0).Status;
	}

	internal static bool POMfEGpkRyXSF6PrYrk(object P_0, object P_1)
	{
		return ((ITransformationProvider)P_0).TableExists((string)P_1);
	}

	internal static void OEfs2Tpn5J5PrhNJqYi(object P_0, object P_1)
	{
		((Table)P_0).Name = (string)P_1;
	}

	internal static void BNyjwspOPY0cjvbRZim(object P_0, object P_1)
	{
		((ITransformationProvider)P_0).AddTable((Table)P_1);
	}

	internal static void J2KZrAp2HuEihN1WQrK(object P_0, object P_1)
	{
		((Index)P_0).TableName = (string)P_1;
	}

	internal static void aJASigpe8g59sQ3a9wu(object P_0, object P_1)
	{
		((Index)P_0).Name = (string)P_1;
	}

	internal static object PQlFZ9pP2CyFgoPbJoo(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object nikZbnp18ka5K8Sp8EL(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object mvJMT9pN9DhRaWVIlCD(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object xBLEm0p31qkQ5IvcsFm(object P_0, object P_1)
	{
		return ((IDataRecord)P_0)[(string)P_1];
	}

	internal static Guid qNjHT7pp57kACrTj8IH(object P_0, object P_1)
	{
		return ((Dialect)P_0).GetGuid(P_1);
	}

	internal static int W6smCNpa8rqMQZCNgsT(object P_0)
	{
		return Convert.ToInt32(P_0);
	}

	internal static object TheDa1pD5QxNyWuVDpV(object P_0)
	{
		return ((ITransformationProvider)P_0).ParameterSeparator;
	}

	internal static object mXTG76ptt81V82tSAi6(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static object vZJeQCpw0JvvMLPgcOC(object P_0, object P_1)
	{
		return string.Format((string)P_0, (object[])P_1);
	}

	internal static object dyLHTMp4DVSetq5MxCD(object P_0)
	{
		return ((StoreComponentConfigurationInfo)P_0).Id;
	}

	internal static bool qrMmTWp641xiDg5vrSs(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static void OetiW4pHr23Uq4O0arV(object P_0, StoreComponentStatus value)
	{
		((StoreComponentConfigurationInfo)P_0).Status = value;
	}

	internal static object Ts3wDkpA8qCNAnReBfp(object P_0)
	{
		return ((StoreComponentConfigurationInfo)P_0).Title;
	}

	internal static bool YiDquWp7wpcjTjcP7sO(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static void JQbk1ypxL15KXUMbbPV(object P_0)
	{
		((StoreComponentConfigurationInfo)P_0).InitLicensedUnit();
	}

	internal static bool AtLuOPp0HkjuWfuFT95(object P_0)
	{
		return ((IDataReader)P_0).Read();
	}

	internal static void nKidfWpm0w5fIS182iy(object P_0)
	{
		((ITransformationProviderBase)P_0).CommitTransaction();
	}

	internal static void qvH0ghpyNoKNIMPf7FJ(object P_0)
	{
		((ITransformationProvider)P_0).RollbackTransaction();
	}

	internal static object hJKXPmpMrT1dNVVdIBo(object P_0)
	{
		return ((StoreComponentConfigurationInfo)P_0).Manifest;
	}

	internal static object Co6sAIpJxoUy6YirMj7(object P_0)
	{
		return ((StoreComponentConfigurationInfo)P_0).Version;
	}

	internal static int VL40blp9ywHdKskC2h9(object P_0, object P_1, object P_2, object P_3)
	{
		return ((ITransformationProvider)P_0).Insert((string)P_1, (string[])P_2, (object[])P_3);
	}

	internal static void oSb9g2pdI90cCdc8cXO()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object K6pmOGplRI6sDxk56H2(object P_0)
	{
		return Logger.GetLogger((string)P_0);
	}

	internal static object jJPY6WprI100In2IOGe(object P_0)
	{
		return ((IStoreComponentInfo)P_0).Id;
	}

	internal static object fKTUiapgJybd8MyoSSb(object P_0)
	{
		return ((ManifestStoreComponentInfo)P_0).InstalledManifest;
	}
}
