using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.Cryptography;

public class EcdhKey : IEcdhKey
{
	private static EcdhKey M5u99lBLbcJ38ERquDAN;

	public byte[] PublicKey
	{
		[CompilerGenerated]
		get
		{
			return _003CPublicKey_003Ek__BackingField;
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
				case 1:
					_003CPublicKey_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
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

	public byte[] SharedSecret
	{
		[CompilerGenerated]
		get
		{
			return _003CSharedSecret_003Ek__BackingField;
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
				case 1:
					_003CSharedSecret_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
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

	public EcdhKey(byte[] publicKey, byte[] sharedSecret)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		suBojEBLEl5p7qpfMo9H();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				SharedSecret = sharedSecret;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			case 2:
				PublicKey = publicKey;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static void suBojEBLEl5p7qpfMo9H()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool GE65DWBLh90N9lyVmGYj()
	{
		return M5u99lBLbcJ38ERquDAN == null;
	}

	internal static EcdhKey cuKYPNBLGX8dqDkqukRj()
	{
		return M5u99lBLbcJ38ERquDAN;
	}
}
