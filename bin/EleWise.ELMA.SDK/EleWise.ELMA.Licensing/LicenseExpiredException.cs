using System;
using System.Runtime.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Modules;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Licensing;

[Serializable]
public class LicenseExpiredException : LicenseException
{
	internal static LicenseExpiredException lDVP5mAc8YA58ONkIFe;

	public LicenseExpiredException()
	{
		//Discarded unreachable code: IL_002f, IL_0034
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(Guid.Empty);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public LicenseExpiredException(Guid moduleUid)
	{
		//Discarded unreachable code: IL_0030, IL_0035
		wuMGvb7ByWby3Imk5T5();
		base._002Ector((string)QgpgcP7WLdTlEk5fpqV(moduleUid));
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected LicenseExpiredException(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		wuMGvb7ByWby3Imk5T5();
		base._002Ector(info, context);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
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
		//Discarded unreachable code: IL_0044, IL_0053
		int num = 3;
		string result = default(string);
		IApplicationUnit applicationUnit = default(IApplicationUnit);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
				case 6:
					return result;
				case 1:
					if (ComponentManager.Initialized)
					{
						num2 = 5;
						continue;
					}
					goto case 4;
				case 7:
					result = SR.T((string)OyTx397oXiSmnMTucwl(-1921202237 ^ -1921229127), faw5C57fbLGqGISaMCN(applicationUnit));
					num2 = 6;
					continue;
				case 2:
					if (!RoJybI7hBN0buyR0PGk(moduleUid, Guid.Empty))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 1;
				case 5:
					applicationUnit = (IApplicationUnit)oBUd6n7E5W70NIVZe5Q(KoZoDB7Gc4m7j4pHmqw(ComponentManager.Current), moduleUid);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					if (applicationUnit != null)
					{
						num2 = 7;
						continue;
					}
					goto case 4;
				case 3:
					break;
				}
				break;
			}
			result = (string)C72phL7bEBdrqM1AFB2(OyTx397oXiSmnMTucwl(-2138160520 ^ -2138121402));
			num = 2;
		}
	}

	internal static bool VAEruAAzjxDGsmV64GQ()
	{
		return lDVP5mAc8YA58ONkIFe == null;
	}

	internal static LicenseExpiredException LgkD9Z7FUv2E71t9Hw6()
	{
		return lDVP5mAc8YA58ONkIFe;
	}

	internal static void wuMGvb7ByWby3Imk5T5()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object QgpgcP7WLdTlEk5fpqV(Guid moduleUid)
	{
		return GenerateMessage(moduleUid);
	}

	internal static object OyTx397oXiSmnMTucwl(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object C72phL7bEBdrqM1AFB2(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool RoJybI7hBN0buyR0PGk(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object KoZoDB7Gc4m7j4pHmqw(object P_0)
	{
		return ((ComponentManager)P_0).ModuleManager;
	}

	internal static object oBUd6n7E5W70NIVZe5Q(object P_0, Guid uid)
	{
		return ((IModuleManager)P_0).FindUnitByUid(uid);
	}

	internal static object faw5C57fbLGqGISaMCN(object P_0)
	{
		return ((IApplicationUnit)P_0).Title;
	}
}
