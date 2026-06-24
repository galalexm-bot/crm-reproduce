using System;
using System.Reflection;
using EleWise.ELMA.Licensing;
using EleWise.ELMA.Modules.Attributes;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Modules.Impl;

internal class LicensedModuleAssembly : ModuleAssembly, ILicensedModuleAssembly, IModuleAssembly, IApplicationUnit, ILicensedUnit, IActivationTokenContainer
{
	private ILicensedUnit licenseUnit;

	internal static LicensedModuleAssembly SfrxEwNieoAagOPrA1I;

	public ILicensedUnit LicenseUnit => licenseUnit;

	public Guid RegistrationKeyMethodUid => bPFDj5NnqjC9bcqlevt(licenseUnit);

	public LicensedModuleAssembly(Assembly assembly, AssemblyLicenseUnitAttribute licenseUnitAttr)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		jJLKojNKvW6cVBU0sGW();
		base._002Ector(assembly);
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			case 1:
				if (licenseUnitAttr == null)
				{
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
					{
						num = 0;
					}
				}
				else
				{
					licenseUnit = (ILicensedUnit)oTS4DcNkLObKmAhmxvY(iEB4HfNTSjrobeOtE8g(licenseUnitAttr));
					num = 2;
				}
				break;
			default:
				throw new ArgumentNullException((string)UWka00NXrnq1qKUSVtd(--1360331293 ^ 0x511570FF));
			}
		}
	}

	public string GetRegistrationKey()
	{
		return (string)n1NXtLNOGZ2GxZ8NIgw(licenseUnit);
	}

	public void ApplyActivationKey(string key)
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
				xB2QBoN2LGP5ELVGxR3(licenseUnit, key);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void CompleteLicensingInitialize()
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
				GwwdTXNelL73nacEybe(licenseUnit);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public ILicenseInfo GetLicenseInfo()
	{
		return (ILicenseInfo)rKVV27NPkEnWbn03HC4(licenseUnit);
	}

	public void UpdateLicenseInfo()
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
				licenseUnit.UpdateLicenseInfo();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public byte[] GetActivationToken()
	{
		return (byte[])CuOQhRN1ZIuAN1sDj0m(licenseUnit);
	}

	ActivationToken IActivationTokenContainer.GetActivationToken()
	{
		int num = 1;
		int num2 = num;
		IActivationTokenContainer activationTokenContainer = default(IActivationTokenContainer);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return null;
			case 1:
				activationTokenContainer = licenseUnit as IActivationTokenContainer;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
				{
					num2 = 0;
				}
				continue;
			}
			if (activationTokenContainer == null)
			{
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
				{
					num2 = 2;
				}
				continue;
			}
			return (ActivationToken)hsyj70NNcjXFHJIOBVe(activationTokenContainer);
		}
	}

	internal static void jJLKojNKvW6cVBU0sGW()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object UWka00NXrnq1qKUSVtd(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Type iEB4HfNTSjrobeOtE8g(object P_0)
	{
		return ((AssemblyLicenseUnitAttribute)P_0).LicenseUnitType;
	}

	internal static object oTS4DcNkLObKmAhmxvY(Type P_0)
	{
		return Activator.CreateInstance(P_0);
	}

	internal static bool Lmnn9cNROVFewgt2U95()
	{
		return SfrxEwNieoAagOPrA1I == null;
	}

	internal static LicensedModuleAssembly rY2R0cNqOwFfkn4usZh()
	{
		return SfrxEwNieoAagOPrA1I;
	}

	internal static Guid bPFDj5NnqjC9bcqlevt(object P_0)
	{
		return ((ILicensedUnit)P_0).RegistrationKeyMethodUid;
	}

	internal static object n1NXtLNOGZ2GxZ8NIgw(object P_0)
	{
		return ((ILicensedUnit)P_0).GetRegistrationKey();
	}

	internal static void xB2QBoN2LGP5ELVGxR3(object P_0, object P_1)
	{
		((ILicensedUnit)P_0).ApplyActivationKey((string)P_1);
	}

	internal static void GwwdTXNelL73nacEybe(object P_0)
	{
		((ILicensedUnit)P_0).CompleteLicensingInitialize();
	}

	internal static object rKVV27NPkEnWbn03HC4(object P_0)
	{
		return ((ILicensedUnit)P_0).GetLicenseInfo();
	}

	internal static object CuOQhRN1ZIuAN1sDj0m(object P_0)
	{
		return ((ILicensedUnit)P_0).GetActivationToken();
	}

	internal static object hsyj70NNcjXFHJIOBVe(object P_0)
	{
		return ((IActivationTokenContainer)P_0).GetActivationToken();
	}
}
