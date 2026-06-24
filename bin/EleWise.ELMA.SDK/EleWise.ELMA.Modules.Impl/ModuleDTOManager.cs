using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Modules.Impl;

public class ModuleDTOManager : DTOManager, IModuleDTOManager, IConfigurationService
{
	internal static ModuleDTOManager AeC5Wu1HuelR5AkqCZE;

	public virtual IEnumerable<ElmaStoreComponentManifest> GetInstalledComponentManifests()
	{
		return Locator.GetServiceNotNull<ModuleManager>().GetInstalledComponentManifests();
	}

	public virtual ElmaStoreComponentManifest GetManifest(string id, out bool installed)
	{
		int num = 6;
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = default(_003C_003Ec__DisplayClass1_0);
		ManifestStoreComponentInfo manifestStoreComponentInfo = default(ManifestStoreComponentInfo);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 6:
					_003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
					num2 = 5;
					continue;
				case 4:
					installed = false;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
					manifestStoreComponentInfo = Locator.GetServiceNotNull<PackageService>().GetStoreComponentsInfo(forRuntime: true).OfType<ManifestStoreComponentInfo>()
						.FirstOrDefault(_003C_003Ec__DisplayClass1_._003CGetManifest_003Eb__0);
					num2 = 3;
					continue;
				case 5:
					_003C_003Ec__DisplayClass1_.id = id;
					num2 = 4;
					continue;
				case 7:
					installed = manifestStoreComponentInfo.IsInstalled;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
					if (manifestStoreComponentInfo == null)
					{
						return null;
					}
					goto end_IL_0012;
				case 1:
					obj = vW8eIv1xxPF3HGtLTrW(manifestStoreComponentInfo);
					if (obj != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					obj = yPK2Ct10h0yNndkV14w(manifestStoreComponentInfo);
					break;
				}
				return (ElmaStoreComponentManifest)obj;
				continue;
				end_IL_0012:
				break;
			}
			num = 7;
		}
	}

	public virtual IEnumerable<PackageManifest> GetComponentPackages(string componentId)
	{
		return Locator.GetServiceNotNull<ModuleManager>().GetComponentPackages(componentId);
	}

	public ModuleDTOManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		HQNSsS1mTTsiB4xJZPo();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object vW8eIv1xxPF3HGtLTrW(object P_0)
	{
		return ((ManifestStoreComponentInfo)P_0).InstalledManifest;
	}

	internal static object yPK2Ct10h0yNndkV14w(object P_0)
	{
		return ((ManifestStoreComponentInfo)P_0).LastManifest;
	}

	internal static bool pUkviv1AUTA82fRBNE6()
	{
		return AeC5Wu1HuelR5AkqCZE == null;
	}

	internal static ModuleDTOManager r0tByk17gMlFG1K20p0()
	{
		return AeC5Wu1HuelR5AkqCZE;
	}

	internal static void HQNSsS1mTTsiB4xJZPo()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
