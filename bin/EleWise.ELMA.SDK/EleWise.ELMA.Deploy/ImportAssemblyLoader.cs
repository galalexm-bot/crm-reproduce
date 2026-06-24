using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Web.Hosting;
using Autofac;
using Autofac.Builder;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Licensing;
using EleWise.ELMA.Licensing.Storages;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.NH.SessionProviders;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Impl;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy;

public class ImportAssemblyLoader : MarshalByRefObject
{
	private static ComponentManager _componentManager;

	private static readonly Type SessionsContainerProviderType;

	private static ImportAssemblyLoader hki17qEekThcyOlyxI05;

	public Assembly Load(string path)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				ValidatePath(path);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return Assembly.Load(path);
			}
		}
	}

	public Assembly LoadFrom(string path)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				ValidatePath(path);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return (Assembly)wZrsGgEe2JZol5yUn5GX(path);
			}
		}
	}

	private void ValidatePath(string path)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				throw new ArgumentException(string.Format((string)rmKqtJEee9YNKct5o424(-542721635 ^ -542972139), path));
			case 1:
				throw new ArgumentNullException((string)rmKqtJEee9YNKct5o424(-889460160 ^ -889211844));
			case 2:
				if (path != null)
				{
					if (n7WGaAEePPHM5weEdvFE(path))
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
					{
						num2 = 1;
					}
				}
				break;
			}
		}
	}

	public void InitComponentManager(string configurationFileName)
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		int num = 4;
		ContainerBuilder val = default(ContainerBuilder);
		string[] array = default(string[]);
		ComponentManager componentManager = default(ComponentManager);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 10:
					SetContextVarsImplIfEmpty();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num2 = 2;
					}
					continue;
				case 5:
					kEIZ5HEe3dfK83mLYeRr(cEr7dEEeNudwCdaBeUGB(_componentManager), rmKqtJEee9YNKct5o424(-951514650 ^ -951493308));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					val = new ContainerBuilder();
					num2 = 3;
					continue;
				case 2:
					A46tVSEe4h9FSs4R33A1(_componentManager, new RuntimeApplication(configurationFileName, SessionsContainerProviderType, array, new WebStartControl(), new Dictionary<string, object> { 
					{
						z2jc63fLkugS1X8Q9N.tE1kD1vbB(-138018305 ^ -137916069),
						true
					} }));
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
					{
						num2 = 7;
					}
					continue;
				case 3:
					componentManager = new ComponentManager(ComponentType.Server | ComponentType.WebServer | ComponentType.Web, new WebStartControl(), val);
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
					{
						num2 = 7;
					}
					continue;
				default:
					qX9lDBEew3eBWulo3ypO(new AutofacLocatorImpl((IContainer)wgZVGfEetY5TInNmbYQH(val, (ContainerBuildOptions)0)));
					num = 10;
					break;
				case 6:
					iy0bXREeDOCpgE3vByF7(_componentManager, array);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
					{
						num2 = 0;
					}
					continue;
				case 8:
					_componentManager = componentManager;
					num2 = 5;
					continue;
				case 11:
					_componentManager.InitLicensing(array, ((AppDomain)fxBidcEep8ZSgjajRTFw()).BaseDirectory);
					num = 9;
					break;
				case 7:
					componentManager.ActivationKeyStorages = new FileSystemActivationKeyStorage[1]
					{
						new FileSystemActivationKeyStorage((string)ppgxG1Ee1tpUFJZp2XM9(rmKqtJEee9YNKct5o424(-882126494 ^ -881881124)))
					};
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num2 = 8;
					}
					continue;
				case 9:
					return;
				case 1:
					array = new string[1] { (string)(((AppDomain)fxBidcEep8ZSgjajRTFw()).RelativeSearchPath ?? pZp07ZEead0GJKH2OGf9(fxBidcEep8ZSgjajRTFw())) };
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num2 = 6;
					}
					continue;
				}
				break;
			}
		}
	}

	private void SetContextVarsImplIfEmpty()
	{
		//Discarded unreachable code: IL_0055, IL_0064
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				ContextVars.SetImpl(new SimpleBoundVariableService());
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			case 3:
				if (ajVuvHEe6TRku9Zw4cXw())
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto default;
			case 1:
				return;
			}
		}
	}

	public bool CheckModuleLicense(string id, out ModuleDTO dto)
	{
		//Discarded unreachable code: IL_0065, IL_0074
		int num = 12;
		ILicensedUnit licensedUnit = default(ILicensedUnit);
		ILicenseInfo licenseInfo = default(ILicenseInfo);
		IApplicationUnit applicationUnit = default(IApplicationUnit);
		AssemblyInfoMetadata assemblyInfoMetadata = default(AssemblyInfoMetadata);
		IModule module = default(IModule);
		Assembly assembly = default(Assembly);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					return true;
				case 5:
					dto = null;
					num2 = 13;
					continue;
				case 14:
					if (licensedUnit != null)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 2;
				case 8:
					licenseInfo = (ILicenseInfo)UKndtREeytNLPkrwZBuk(licensedUnit);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					return pI1qGEEeMaMi6XTiKofP(licenseInfo) == LicenseStatus.NeedRestart;
				case 10:
					licensedUnit = applicationUnit as ILicensedUnit;
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
					{
						num2 = 10;
					}
					continue;
				case 13:
					applicationUnit = _componentManager.ModuleManager.FindUnitByUid(ewoCm4Ee7aDo4DRGXcS8(assemblyInfoMetadata));
					num2 = 15;
					continue;
				default:
					if (licenseInfo != null)
					{
						if (pI1qGEEeMaMi6XTiKofP(licenseInfo) != 0)
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
							{
								num2 = 1;
							}
							continue;
						}
						return true;
					}
					num = 6;
					break;
				case 4:
					if (licensedUnit == null)
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 3;
				case 7:
					licensedUnit = module as ILicensedUnit;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num2 = 4;
					}
					continue;
				case 16:
					return true;
				case 15:
					if (applicationUnit != null)
					{
						module = (IModule)gKhpA9EexwxsNNkwmkLC(_componentManager.ModuleManager, id);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
						{
							num2 = 7;
						}
					}
					else
					{
						num2 = 16;
					}
					continue;
				case 12:
					assembly = (Assembly)ElMkBiEeH9jym0krU9Ko(id);
					num = 11;
					break;
				case 9:
					POGQrfEeAQVcuVPsfMr0(assemblyInfoMetadata, assembly);
					num2 = 5;
					continue;
				case 11:
					assemblyInfoMetadata = new AssemblyInfoMetadata();
					num2 = 9;
					continue;
				case 2:
					return true;
				case 3:
					dto = (ModuleDTO)((module != null) ? KhaQBGEemonLDqcMFQX7(module) : wMVvfDEe0m1h4Xc1M7h8(applicationUnit));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
					{
						num2 = 8;
					}
					continue;
				}
				break;
			}
		}
	}

	public Guid ActivateNewModules(List<ModuleDTO> modules, string key)
	{
		Guid result = _componentManager.LicenseManager.AddActivationKey(key);
		foreach (ModuleDTO module in modules)
		{
			Assembly asm = Assembly.Load(module.Id);
			AssemblyInfoMetadata assemblyInfoMetadata = new AssemblyInfoMetadata();
			assemblyInfoMetadata.LoadFromAssembly(asm);
			if (_componentManager.ModuleManager.FindUnitByUid(assemblyInfoMetadata.Uid) is ILicensedModuleAssembly licensedModuleAssembly)
			{
				licensedModuleAssembly.UpdateLicenseInfo();
			}
		}
		return result;
	}

	public ImportAssemblyLoader()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		pEDNRHEeJYBD5cOEjwga();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static ImportAssemblyLoader()
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
				pEDNRHEeJYBD5cOEjwga();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				SessionsContainerProviderType = xdt9xoEe9nVOuUwm2v0t(typeof(WebSessionProvider).TypeHandle);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool xgF44rEenTspacyMC5wD()
	{
		return hki17qEekThcyOlyxI05 == null;
	}

	internal static ImportAssemblyLoader qhMZ56EeOj1GAwunfQqD()
	{
		return hki17qEekThcyOlyxI05;
	}

	internal static object wZrsGgEe2JZol5yUn5GX(object P_0)
	{
		return Assembly.LoadFrom((string)P_0);
	}

	internal static object rmKqtJEee9YNKct5o424(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool n7WGaAEePPHM5weEdvFE(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static object ppgxG1Ee1tpUFJZp2XM9(object P_0)
	{
		return HostingEnvironment.MapPath((string)P_0);
	}

	internal static object cEr7dEEeNudwCdaBeUGB(object P_0)
	{
		return ((ComponentManager)P_0).PackageService;
	}

	internal static void kEIZ5HEe3dfK83mLYeRr(object P_0, object P_1)
	{
		((PackageService)P_0).ComponentName = (string)P_1;
	}

	internal static object fxBidcEep8ZSgjajRTFw()
	{
		return AppDomain.CurrentDomain;
	}

	internal static object pZp07ZEead0GJKH2OGf9(object P_0)
	{
		return ((AppDomain)P_0).BaseDirectory;
	}

	internal static void iy0bXREeDOCpgE3vByF7(object P_0, object P_1)
	{
		((ComponentManager)P_0).LoadAssemblies((string[])P_1);
	}

	internal static object wgZVGfEetY5TInNmbYQH(object P_0, ContainerBuildOptions P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((ContainerBuilder)P_0).Build(P_1);
	}

	internal static void qX9lDBEew3eBWulo3ypO(object P_0)
	{
		Locator.SetImpl((ILocatorImpl)P_0);
	}

	internal static object A46tVSEe4h9FSs4R33A1(object P_0, object P_1)
	{
		return ((ComponentManager)P_0).RegisterComponent(P_1);
	}

	internal static bool ajVuvHEe6TRku9Zw4cXw()
	{
		return ContextVars.HasImpl;
	}

	internal static object ElMkBiEeH9jym0krU9Ko(object P_0)
	{
		return Assembly.Load((string)P_0);
	}

	internal static void POGQrfEeAQVcuVPsfMr0(object P_0, object P_1)
	{
		((AssemblyInfoMetadata)P_0).LoadFromAssembly((Assembly)P_1);
	}

	internal static Guid ewoCm4Ee7aDo4DRGXcS8(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object gKhpA9EexwxsNNkwmkLC(object P_0, object P_1)
	{
		return ((IModuleManager)P_0).FindModuleById((string)P_1);
	}

	internal static object wMVvfDEe0m1h4Xc1M7h8(object P_0)
	{
		return ModuleDTO.CreateFrom((IApplicationUnit)P_0);
	}

	internal static object KhaQBGEemonLDqcMFQX7(object P_0)
	{
		return ModuleDTO.CreateFrom((IModule)P_0);
	}

	internal static object UKndtREeytNLPkrwZBuk(object P_0)
	{
		return ((ILicensedUnit)P_0).GetLicenseInfo();
	}

	internal static LicenseStatus pI1qGEEeMaMi6XTiKofP(object P_0)
	{
		return ((ILicenseInfo)P_0).Status;
	}

	internal static void pEDNRHEeJYBD5cOEjwga()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static Type xdt9xoEe9nVOuUwm2v0t(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
