using System;
using EleWise.ELMA.Modules;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Exceptions;

[Serializable]
internal class ModuleNotFoundException : Exception
{
	private static ModuleNotFoundException rW9KVNGgOwiyH4A9KKAJ;

	public ModuleDisabledReason DisabledReason { get; }

	public string AdditionalInformation { get; }

	public ModuleNotFoundException(Guid moduleUid)
	{
		//Discarded unreachable code: IL_0030, IL_0035
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(moduleUid, string.Empty);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public ModuleNotFoundException(Guid moduleUid, ModuleDisabledReason disabledReason)
	{
		//Discarded unreachable code: IL_0046, IL_004b
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(moduleUid, SR.T((string)i4ViPuGgPlA6DMk8QvQB(0x6DC147B0 ^ 0x6DC5529A)));
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			DisabledReason = disabledReason;
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
			{
				num = 1;
			}
		}
	}

	public ModuleNotFoundException(Guid moduleUid, string additionalInfo)
	{
		//Discarded unreachable code: IL_0054, IL_0059
		MCWmlTGg16PfjXoMxYcp();
		base._002Ector(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7C1EE318 ^ 0x7C1AF640), moduleUid));
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			AdditionalInformation = additionalInfo;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
			{
				num = 1;
			}
		}
	}

	public override string ToString()
	{
		//Discarded unreachable code: IL_0084, IL_0093
		int num = 1;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
				text = (string)jW6IqNGg3fMtqg5hCDoR(text, i4ViPuGgPlA6DMk8QvQB(0x48A7E34A ^ 0x48A7AA68), AdditionalInformation);
				num2 = 6;
				break;
			case 6:
				return (string)jW6IqNGg3fMtqg5hCDoR(text, i4ViPuGgPlA6DMk8QvQB(0x53CACA3 ^ 0x53CE581), NbPfQvGgp3MZY67TUWID(this));
			case 3:
				text += SR.T((string)i4ViPuGgPlA6DMk8QvQB(-210725949 ^ -210467251), DisabledReason);
				num2 = 4;
				break;
			case 1:
				text = string.Empty;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
			case 5:
				if (!CwIvP0GgNlrdqEUBNIek(AdditionalInformation))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 6;
			default:
				if (DisabledReason == ModuleDisabledReason.Unknown)
				{
					num2 = 5;
					break;
				}
				goto case 3;
			}
		}
	}

	internal static bool qa0yeKGg2LmiIP0iRIe8()
	{
		return rW9KVNGgOwiyH4A9KKAJ == null;
	}

	internal static ModuleNotFoundException GfwgwkGgeIIV0w9Tgb5t()
	{
		return rW9KVNGgOwiyH4A9KKAJ;
	}

	internal static object i4ViPuGgPlA6DMk8QvQB(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void MCWmlTGg16PfjXoMxYcp()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool CwIvP0GgNlrdqEUBNIek(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object jW6IqNGg3fMtqg5hCDoR(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object NbPfQvGgp3MZY67TUWID(object P_0)
	{
		return ((Exception)P_0).ToString();
	}
}
