using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.Managers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Services;

[Service]
internal sealed class MetadataCacheService : IMetadataCacheService
{
	private readonly Guid runtimeCacheGuid;

	internal static MetadataCacheService TRfsMdBDKtxVhBIaxspv;

	public string GetRuntimeHash()
	{
		int num = 2;
		int num2 = num;
		IBLOBDataManager iBLOBDataManager = default(IBLOBDataManager);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (iBLOBDataManager == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return iBLOBDataManager.GetBLOB<string>(runtimeCacheGuid, (string)XxFTSEBDnVXdkrr6yuL2(--1418440330 ^ 0x548AEBD8));
			default:
				return null;
			case 2:
				iBLOBDataManager = (IBLOBDataManager)OhpPW4BDkKAYavpl2JqS();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public void SetRuntimeHash(string value)
	{
		//Discarded unreachable code: IL_007f
		int num = 4;
		int num2 = num;
		IBLOBDataManager iBLOBDataManager = default(IBLOBDataManager);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 4:
				iBLOBDataManager = (IBLOBDataManager)OhpPW4BDkKAYavpl2JqS();
				num2 = 3;
				break;
			case 2:
				return;
			case 1:
				iBLOBDataManager.SetBLOB(runtimeCacheGuid, (string)XxFTSEBDnVXdkrr6yuL2(-643786247 ^ -643703637), value);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				if (iBLOBDataManager == null)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public MetadataCacheService()
	{
		//Discarded unreachable code: IL_0050, IL_0055
		tjPxdIBDOuyh18HruD1g();
		runtimeCacheGuid = new Guid((string)XxFTSEBDnVXdkrr6yuL2(-1751176224 ^ -1751224690));
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object OhpPW4BDkKAYavpl2JqS()
	{
		return DataAccessManager.BLOBManager;
	}

	internal static object XxFTSEBDnVXdkrr6yuL2(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool Gum108BDXpZXFHTMuVbe()
	{
		return TRfsMdBDKtxVhBIaxspv == null;
	}

	internal static MetadataCacheService XZhcuIBDTBDWL0m8q1Y7()
	{
		return TRfsMdBDKtxVhBIaxspv;
	}

	internal static void tjPxdIBDOuyh18HruD1g()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
