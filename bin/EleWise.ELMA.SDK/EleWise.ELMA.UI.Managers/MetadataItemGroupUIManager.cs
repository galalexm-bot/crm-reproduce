using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Managers;

internal class MetadataItemGroupUIManager : EntityManager<MetadataItemGroupUI, long>, IMetadataItemGroupUIManager, IEntityManager<MetadataItemGroupUI, long>, IEntityManager<MetadataItemGroupUI>, IEntityManager
{
	private static MetadataItemGroupUIManager HkN5ZbBf4VMQ8JotsZO4;

	public new static MetadataItemGroupUIManager Instance => Locator.GetServiceNotNull<MetadataItemGroupUIManager>();

	[Transaction]
	public virtual MetadataItemGroupUI Create(Guid typeUid, Guid moduleUid, Guid groupUid, string displayName, string name)
	{
		int num = 10;
		MetadataItemGroupUI metadataItemGroupUI = default(MetadataItemGroupUI);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					BfnBedBfxmJWxoFh5fGc(name, jtxpfLBfAK08TYkHcmso(-1876063057 ^ -1876066119));
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num2 = 0;
					}
					continue;
				case 9:
					BfnBedBfxmJWxoFh5fGc(displayName, jtxpfLBfAK08TYkHcmso(-541731959 ^ -541776967));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num2 = 6;
					}
					continue;
				case 2:
					SAy9fyBfyMgICUAiDpcQ(metadataItemGroupUI, LoadOrNull(groupUid));
					num = 8;
					break;
				case 5:
					metadataItemGroupUI = Create();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					YjJDNTBfmQ9TtRQgLQG5(metadataItemGroupUI, displayName);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 2;
					}
					continue;
				case 4:
					Save(metadataItemGroupUI);
					num = 3;
					break;
				case 8:
					hkmsyOBfMqyqIEKnUp7r(metadataItemGroupUI, moduleUid);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					return metadataItemGroupUI;
				default:
					qjNgPwBf0nsCke9sU5bx(metadataItemGroupUI, name);
					num2 = 7;
					continue;
				case 10:
					iqrjWHBf7M62UF3bTuOa(typeUid != Guid.Empty, jtxpfLBfAK08TYkHcmso(-606654180 ^ -606609692));
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 6;
					}
					continue;
				case 1:
					CKCVSZBfJCbOL1k1HBfR(metadataItemGroupUI, typeUid);
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}

	[Transaction]
	public virtual MetadataItemGroupUI Edit(Guid uid, Guid typeUid, Guid moduleUid, Guid groupUid, string displayName, string name)
	{
		int num = 6;
		int num2 = num;
		MetadataItemGroupUI metadataItemGroupUI = default(MetadataItemGroupUI);
		while (true)
		{
			switch (num2)
			{
			case 6:
				metadataItemGroupUI = LoadOrNull(uid);
				num2 = 5;
				break;
			case 7:
				YjJDNTBfmQ9TtRQgLQG5(metadataItemGroupUI, displayName);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				D2ydIXBf97UfytWwQGa1(metadataItemGroupUI, jtxpfLBfAK08TYkHcmso(-1939377524 ^ -1939373370));
				num2 = 3;
				break;
			case 1:
				SAy9fyBfyMgICUAiDpcQ(metadataItemGroupUI, LoadOrNull(groupUid));
				num2 = 4;
				break;
			default:
				Save(metadataItemGroupUI);
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 4;
				}
				break;
			case 2:
				metadataItemGroupUI.Name = name;
				num2 = 7;
				break;
			case 8:
				return metadataItemGroupUI;
			case 3:
				metadataItemGroupUI.ModuleUid = moduleUid;
				num2 = 2;
				break;
			case 4:
				CKCVSZBfJCbOL1k1HBfR(metadataItemGroupUI, typeUid);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public MetadataItemGroupUIManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		VgpdYxBfds18tj4GDknm();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object jtxpfLBfAK08TYkHcmso(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void iqrjWHBf7M62UF3bTuOa(bool condition, object P_1)
	{
		Contract.CheckArgument(condition, (string)P_1);
	}

	internal static void BfnBedBfxmJWxoFh5fGc(object P_0, object P_1)
	{
		Contract.ArgumentNotNullOrEmpty((string)P_0, (string)P_1);
	}

	internal static void qjNgPwBf0nsCke9sU5bx(object P_0, object P_1)
	{
		((MetadataItemGroupUI)P_0).Name = (string)P_1;
	}

	internal static void YjJDNTBfmQ9TtRQgLQG5(object P_0, object P_1)
	{
		((MetadataItemGroupUI)P_0).DisplayName = (string)P_1;
	}

	internal static void SAy9fyBfyMgICUAiDpcQ(object P_0, object P_1)
	{
		((MetadataItemGroupUI)P_0).Parent = (MetadataItemGroupUI)P_1;
	}

	internal static void hkmsyOBfMqyqIEKnUp7r(object P_0, Guid value)
	{
		((MetadataItemGroupUI)P_0).ModuleUid = value;
	}

	internal static void CKCVSZBfJCbOL1k1HBfR(object P_0, Guid value)
	{
		((MetadataItemGroupUI)P_0).MetadataTypeUid = value;
	}

	internal static bool UUH1QtBf6Kj9j02OT5BO()
	{
		return HkN5ZbBf4VMQ8JotsZO4 == null;
	}

	internal static MetadataItemGroupUIManager pUtNj7BfH9PKZ4i01KK2()
	{
		return HkN5ZbBf4VMQ8JotsZO4;
	}

	internal static void D2ydIXBf97UfytWwQGa1(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void VgpdYxBfds18tj4GDknm()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
