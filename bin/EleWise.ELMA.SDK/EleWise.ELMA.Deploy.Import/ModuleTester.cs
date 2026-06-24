using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Deploy.Import.Modules;
using EleWise.ELMA.Deploy.Services;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Services;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Import;

internal sealed class ModuleTester
{
	private readonly IModuleMetadataExtractorService metadataExtractorService;

	private readonly IModuleMetadataLoader moduleMetadataLoader;

	private readonly Action<IConfigImportSettings, string> testAction;

	private static ModuleTester SHCxDeExDHA1IetFlNLB;

	public event Action<TestImportMessages> MessageAdded;

	public ModuleTester(IModuleMetadataExtractorService metadataExtractorService, IModuleMetadataLoader moduleMetadataLoader, Action<IConfigImportSettings, string> testAction)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		this.metadataExtractorService = metadataExtractorService;
		this.moduleMetadataLoader = moduleMetadataLoader;
		this.testAction = testAction;
	}

	internal IReadOnlyCollection<IConfigImportSettings> TestModules(IEnumerable<IConfigImportSettings> configImportSettings, string activateKey)
	{
		List<IConfigImportSettings> list = new List<IConfigImportSettings>();
		List<ModuleVersion> list2 = new List<ModuleVersion>();
		foreach (IConfigImportSettings configImportSetting in configImportSettings)
		{
			_003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass7_0();
			ElmaStoreComponentManifest manifest = configImportSetting.Manifest;
			if (!Version.TryParse(manifest.Version, out CS_0024_003C_003E8__locals0.moduleNewVersion))
			{
				this.MessageAdded?.Invoke(new TestImportMessages(TestImportMessagesType.InfoCommon, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x35C0467B ^ 0x35C4DB85), manifest.Title, manifest.Version)));
				continue;
			}
			this.MessageAdded?.Invoke(new TestImportMessages(TestImportMessagesType.InfoCommon, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939608558), manifest.Title, manifest.Version)));
			if (manifest != null && manifest.ModuleUid != Guid.Empty && moduleMetadataLoader.GetModuleVersionHeaders(manifest.ModuleUid).Any((ModuleVersionHeader header) => _003C_003Ec__DisplayClass7_0.xcnIHl8D8jAtHABNqmp1(_003C_003Ec__DisplayClass7_0.koDJLy8DvavGn8sV6LZN(header), CS_0024_003C_003E8__locals0.moduleNewVersion)))
			{
				this.MessageAdded?.Invoke(new TestImportMessages(TestImportMessagesType.InfoCommon, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-195614443 ^ -195840003), manifest.Title)));
			}
			else
			{
				if (new Guid[25]
				{
					new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099553573)),
					new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5A4C7B29 ^ 0x5A4F77DD)),
					new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112767530)),
					new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 0x51160FC5)),
					new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 0x4F7C3EBA)),
					new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487188458)),
					new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1859079575)),
					new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112774034)),
					new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-643786247 ^ -643592875)),
					new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1767720453 ^ -1767789377)),
					new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-309639236 ^ -309832740)),
					new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886447649)),
					new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x49E27B8A ^ 0x49E1704E)),
					new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C9495B4 ^ 0x1C9799A4)),
					new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1876000525)),
					new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7C1EE318 ^ 0x7C1DEDA4)),
					new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-541731959 ^ -541664127)),
					new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1870892489 ^ -1870693021)),
					new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70203219)),
					new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-561074844 ^ -561143160)),
					new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A5D5EF ^ 0x3A6C5D7)),
					new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CB464B ^ 0x53C85757)),
					new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DD55050 ^ 0x5DD641E4)),
					new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4785BC0D ^ 0x4786AD65)),
					new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3B36AB09 ^ 0x3B35BED5))
				}.Contains(manifest.ModuleUid))
				{
					continue;
				}
				if (manifest != null && manifest.ModuleUid != Guid.Empty)
				{
					TestModuleImportSettings testModuleImportSettings = new TestModuleImportSettings(configImportSetting, list2);
					testAction(testModuleImportSettings, activateKey);
					if (testModuleImportSettings.HasErrors)
					{
						throw ModuleDeployException.TestError(manifest.Id, manifest.Title, string.Empty);
					}
					if (testModuleImportSettings.ModuleMetadata != null)
					{
						list.Add(new ModuleImportSettings(testModuleImportSettings));
						list2.Add(ModuleVersion(testModuleImportSettings));
						if (testModuleImportSettings.Incompatible)
						{
							this.MessageAdded?.Invoke(new TestImportMessages(TestImportMessagesType.Warning, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -104966048), manifest.Title)));
						}
					}
				}
				else
				{
					testAction(configImportSetting, activateKey);
					list.Add(configImportSetting);
					list2.AddRange(metadataExtractorService.ExtractModules(configImportSetting));
				}
			}
		}
		return list;
	}

	private static ModuleVersion ModuleVersion(object settings)
	{
		//Discarded unreachable code: IL_0098, IL_00ac
		int num = 2;
		int num2 = num;
		ModuleInfoMetadata moduleMetadata = default(ModuleInfoMetadata);
		Version result = default(Version);
		Guid versionUid = default(Guid);
		Version version = default(Version);
		while (true)
		{
			Version version2;
			switch (num2)
			{
			case 2:
			{
				object obj = Uqv4mJEx4Bi5yWTcsqTs(settings);
				moduleMetadata = ((TestModuleImportSettings)settings).ModuleMetadata;
				if (Version.TryParse((string)Kiv28oEx6D4boVJ39bKG(obj), out result))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 3;
			}
			case 4:
				versionUid = ToDESAExHZOuQJrtQLsg(moduleMetadata.Uid, version);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				version2 = ModuleVersionHeader.DefaultVersion;
				goto IL_00b3;
			case 1:
				version2 = result;
				goto IL_00b3;
			default:
				{
					return new ModuleVersion(moduleMetadata, new ModuleVersionHeader(moduleMetadata.GetSignature(), versionUid, qYyN9lExA7EHQ7T6GqvV(moduleMetadata), version, (!iali47Ex7seibiPFdvXn(settings)) ? ModuleStatus.Enabled : ModuleStatus.Disabled, iali47Ex7seibiPFdvXn(settings) ? ModuleDisabledReason.Dependency : ModuleDisabledReason.Unknown));
				}
				IL_00b3:
				version = version2;
				num2 = 4;
				break;
			}
		}
	}

	internal static object Uqv4mJEx4Bi5yWTcsqTs(object P_0)
	{
		return ((TestModuleImportSettings)P_0).Manifest;
	}

	internal static object Kiv28oEx6D4boVJ39bKG(object P_0)
	{
		return ((ElmaStoreComponentManifest)P_0).Version;
	}

	internal static Guid ToDESAExHZOuQJrtQLsg(Guid headerUid, object P_1)
	{
		return ModuleVersionHeader.DefaultVersionUid(headerUid, (Version)P_1);
	}

	internal static Guid qYyN9lExA7EHQ7T6GqvV(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static bool iali47Ex7seibiPFdvXn(object P_0)
	{
		return ((TestModuleImportSettings)P_0).Incompatible;
	}

	internal static bool hSJyToExt4Zc5FFBONRU()
	{
		return SHCxDeExDHA1IetFlNLB == null;
	}

	internal static ModuleTester r2aMmgExw1RjPlPUPdER()
	{
		return SHCxDeExDHA1IetFlNLB;
	}
}
