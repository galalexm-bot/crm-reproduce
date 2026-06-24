using System;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Modules.Attributes;

[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public class AssemblyLicenseUnitAttribute : Attribute
{
	private ComponentType componentType;

	private Type licenseUnitType;

	internal static AssemblyLicenseUnitAttribute jZxMFfaFgPmZuEtNGGU;

	public ComponentType ComponentType => componentType;

	public Type LicenseUnitType => licenseUnitType;

	public AssemblyLicenseUnitAttribute(ComponentType componentType, Type licenseUnitType)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		X84CXyaouqgQHxpT8IV();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				this.componentType = componentType;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
				{
					num = 2;
				}
				break;
			case 2:
				this.licenseUnitType = licenseUnitType;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static void X84CXyaouqgQHxpT8IV()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool j8hdN4aBpAIbb5XZtjO()
	{
		return jZxMFfaFgPmZuEtNGGU == null;
	}

	internal static AssemblyLicenseUnitAttribute iKyCOBaWUSfmyBKU8nZ()
	{
		return jZxMFfaFgPmZuEtNGGU;
	}
}
