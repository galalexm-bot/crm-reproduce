using System;
using System.Runtime.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Modules;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Licensing;

[Serializable]
public class LicenseWorkplaceExceededException : LicenseException
{
	private static LicenseWorkplaceExceededException g5JxJC786AfGAVkse68;

	public LicenseWorkplaceExceededException()
	{
		//Discarded unreachable code: IL_002f, IL_0034
		Pksm1i7I7BuH3Nxya8T();
		this._002Ector(Guid.Empty);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public LicenseWorkplaceExceededException(Guid moduleUid)
	{
		//Discarded unreachable code: IL_0030, IL_0035
		Pksm1i7I7BuH3Nxya8T();
		base._002Ector((string)X8YIVZ7Vncgj3yfwpMG(moduleUid));
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

	protected LicenseWorkplaceExceededException(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		Pksm1i7I7BuH3Nxya8T();
		base._002Ector(info, context);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	private static string GenerateMessage(Guid moduleUid)
	{
		//Discarded unreachable code: IL_00ea, IL_00f9, IL_0109, IL_0118
		int num = 8;
		int num2 = num;
		string result = default(string);
		IApplicationUnit applicationUnit = default(IApplicationUnit);
		while (true)
		{
			switch (num2)
			{
			case 2:
			case 3:
			case 6:
				return result;
			case 8:
				result = (string)Ickosf7iDPSg7FxIakS(U46hsn7SLdvR230Imex(0x5F3078B6 ^ 0x5F30E16E));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
				{
					num2 = 7;
				}
				break;
			default:
				applicationUnit = ((IModuleManager)tD21Pr7KLC0va6KLR7u(ComponentManager.Current)).FindUnitByUid(moduleUid);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				result = SR.T((string)U46hsn7SLdvR230Imex(0x42643203 ^ 0x4264A83B), applicationUnit.Title);
				num2 = 3;
				break;
			case 5:
				if (!WGYHcJ7qUJbRy0T2XdA())
				{
					num2 = 2;
					break;
				}
				goto default;
			case 7:
				if (e3C4mp7RWwEAnFndhNc(moduleUid, Guid.Empty))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 2;
			case 1:
				if (applicationUnit == null)
				{
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
					{
						num2 = 6;
					}
					break;
				}
				goto case 4;
			}
		}
	}

	internal static void Pksm1i7I7BuH3Nxya8T()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool B9PHx17ZDPyTcFBvRGd()
	{
		return g5JxJC786AfGAVkse68 == null;
	}

	internal static LicenseWorkplaceExceededException SaiFRt7utl5ESUS1beC()
	{
		return g5JxJC786AfGAVkse68;
	}

	internal static object X8YIVZ7Vncgj3yfwpMG(Guid moduleUid)
	{
		return GenerateMessage(moduleUid);
	}

	internal static object U46hsn7SLdvR230Imex(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object Ickosf7iDPSg7FxIakS(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool e3C4mp7RWwEAnFndhNc(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static bool WGYHcJ7qUJbRy0T2XdA()
	{
		return ComponentManager.Initialized;
	}

	internal static object tD21Pr7KLC0va6KLR7u(object P_0)
	{
		return ((ComponentManager)P_0).ModuleManager;
	}
}
