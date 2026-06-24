using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Files;
using EleWise.ELMA.Security.Extensions;
using EleWise.ELMA.Security.Models.Crypto;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Components;

public abstract class CryptoProviderBase : ICryptoProviderBase2, ICryptoProviderBase
{
	private static CryptoProviderBase S1GJIefoOw1B4opQwud;

	public abstract Guid ProviderUid { get; }

	public virtual string DisplayName
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return (string)HbyijUfhoQj3rhZLdDd(Impl);
				case 1:
					lZK9psftvungl3DCfVR(Impl, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1788380826 ^ -1788449940));
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f791092a54884ca2ab7376df2d89215c == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual CryptoProviderSettingsBase Settings
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return (CryptoProviderSettingsBase)bqn7SKfqbwjPGHbyBwG(Impl);
				case 1:
					Contract.ArgumentNotNull(Impl, (string)cD83QVfOuMy4TyQn5EY(0x4E6718AE ^ 0x4E660AA4));
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6e35a1cd804541a884550671c71dbb1c != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	protected ICryptoProviderBase Impl
	{
		[CompilerGenerated]
		get
		{
			return _003CImpl_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CImpl_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_56bc39e908f44451b3cdd0d68828e324 != 0)
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

	public virtual IVerifyResult Verify(byte[] originalData, byte[] signedData, bool verifySignatureOnly)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				lZK9psftvungl3DCfVR(Impl, cD83QVfOuMy4TyQn5EY(0x6AA79E0 ^ 0x6AB6BEA));
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a1d876260ca946cdbdcbec4b9517d613 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return (IVerifyResult)dXtPevfcNZIjI1DeNkj(Impl, originalData, signedData, verifySignatureOnly);
			}
		}
	}

	public virtual string GetFileHash(BinaryFile file)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return Impl.GetFileHash(file);
			case 1:
				lZK9psftvungl3DCfVR(Impl, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1518425080 ^ -1518354942));
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5ae6a44bd52345c5bcadd62b7063c7d9 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual string GetFileHash(BinaryFile file, string algorithm)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (Impl == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fe0eedb8ce484402a5c9a74346556b9f == 0)
					{
						num2 = 0;
					}
					break;
				}
				return (string)I1yE4PfGi7hGY9wUrRS(Impl, file, algorithm);
			default:
				return GetFileHash(file);
			}
		}
	}

	protected CryptoProviderBase()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		taeIQTfFtpArJksAoYi();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b700f854946b45dfa4de8ce28732acad == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void lZK9psftvungl3DCfVR(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object HbyijUfhoQj3rhZLdDd(object P_0)
	{
		return ((ICryptoProviderBase)P_0).DisplayName;
	}

	internal static bool FQEMdffJYRRhZDkmA9s()
	{
		return S1GJIefoOw1B4opQwud == null;
	}

	internal static CryptoProviderBase zC81uYfKlw17tr3f5vc()
	{
		return S1GJIefoOw1B4opQwud;
	}

	internal static object cD83QVfOuMy4TyQn5EY(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object bqn7SKfqbwjPGHbyBwG(object P_0)
	{
		return ((ICryptoProviderBase)P_0).Settings;
	}

	internal static object dXtPevfcNZIjI1DeNkj(object P_0, object P_1, object P_2, bool verifySignatureOnly)
	{
		return ((ICryptoProviderBase)P_0).Verify((byte[])P_1, (byte[])P_2, verifySignatureOnly);
	}

	internal static object I1yE4PfGi7hGY9wUrRS(object P_0, object P_1, object P_2)
	{
		return ((ICryptoProviderBase)P_0).GetFileHash((BinaryFile)P_1, (string)P_2);
	}

	internal static void taeIQTfFtpArJksAoYi()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
