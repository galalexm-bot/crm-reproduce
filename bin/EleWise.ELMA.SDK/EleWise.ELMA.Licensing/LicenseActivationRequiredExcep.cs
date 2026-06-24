using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Modules;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Licensing;

[Serializable]
public class LicenseActivationRequiredException : LicenseException
{
	private static LicenseActivationRequiredException aaBib0AxIr4PLIavdSR;

	public string[] ModuleNames
	{
		[CompilerGenerated]
		get
		{
			return _003CModuleNames_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CModuleNames_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public LicenseActivationRequiredException()
	{
		//Discarded unreachable code: IL_002f, IL_0034
		rHKlOEAyXahlQT2cQrG();
		this._002Ector(Guid.Empty);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public LicenseActivationRequiredException(Guid moduleUid)
	{
		//Discarded unreachable code: IL_0030, IL_0035
		rHKlOEAyXahlQT2cQrG();
		base._002Ector((string)yxvS2BAM8CiJsC6682G(moduleUid));
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

	public LicenseActivationRequiredException(string[] moduleNames)
	{
		//Discarded unreachable code: IL_0030, IL_0035
		rHKlOEAyXahlQT2cQrG();
		base._002Ector((string)YKcI0RAJGB6fgVUeWp8(moduleNames));
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
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
				ModuleNames = moduleNames;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	protected LicenseActivationRequiredException(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		rHKlOEAyXahlQT2cQrG();
		base._002Ector(info, context);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
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
		//Discarded unreachable code: IL_0045, IL_00ac
		int num = 1;
		int num2 = num;
		string result = default(string);
		IApplicationUnit applicationUnit = default(IApplicationUnit);
		while (true)
		{
			switch (num2)
			{
			case 5:
				if (ComponentManager.Initialized)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 2;
			case 2:
			case 3:
			case 8:
				return result;
			case 1:
				result = (string)tBFCExAdx2wMwc7JFNY(j9VovEA9rdxd1p2o9Ln(0xD3DEF7E ^ 0xD3D7804));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (!(moduleUid != Guid.Empty))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 5;
			case 6:
				result = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998577448), oow2CwAg13IvF6mIMDW(applicationUnit));
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
				{
					num2 = 1;
				}
				break;
			case 7:
				if (applicationUnit == null)
				{
					num2 = 3;
					break;
				}
				goto case 6;
			case 4:
				applicationUnit = (IApplicationUnit)qiXrmYArCDD4Mb6WsWF(k8H02IAl9j6IvipeYp5(ComponentManager.Current), moduleUid);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
				{
					num2 = 7;
				}
				break;
			}
		}
	}

	private static string GenerateMessage(object moduleNames)
	{
		return SR.T((string)j9VovEA9rdxd1p2o9Ln(-1459557599 ^ -1459588275), string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-138018305 ^ -138015235), ((IEnumerable<string>)moduleNames).Select((string n) => (string)_003C_003Ec.NFPxfBfgV3fwbBkVX7Y7(_003C_003Ec.HdBVL6fgIRtUV8Yp4FsZ(0x66F566B6 ^ 0x66F4FB5A), n))));
	}

	internal static void rHKlOEAyXahlQT2cQrG()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool eX8TiQA0aorsPR5L6Lr()
	{
		return aaBib0AxIr4PLIavdSR == null;
	}

	internal static LicenseActivationRequiredException rsnFuKAm6oB03Dx6xsD()
	{
		return aaBib0AxIr4PLIavdSR;
	}

	internal static object yxvS2BAM8CiJsC6682G(Guid moduleUid)
	{
		return GenerateMessage(moduleUid);
	}

	internal static object YKcI0RAJGB6fgVUeWp8(object P_0)
	{
		return GenerateMessage(P_0);
	}

	internal static object j9VovEA9rdxd1p2o9Ln(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object tBFCExAdx2wMwc7JFNY(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object k8H02IAl9j6IvipeYp5(object P_0)
	{
		return ((ComponentManager)P_0).ModuleManager;
	}

	internal static object qiXrmYArCDD4Mb6WsWF(object P_0, Guid uid)
	{
		return ((IModuleManager)P_0).FindUnitByUid(uid);
	}

	internal static object oow2CwAg13IvF6mIMDW(object P_0)
	{
		return ((IApplicationUnit)P_0).Title;
	}
}
