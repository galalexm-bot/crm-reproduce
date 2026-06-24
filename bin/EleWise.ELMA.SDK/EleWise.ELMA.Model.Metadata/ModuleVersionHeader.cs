using System;
using System.Runtime.Serialization;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Signatures;
using EleWise.ELMA.Modules;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Metadata;

[Serializable]
[DataContract]
internal sealed class ModuleVersionHeader
{
	internal static readonly Version DefaultVersion;

	internal static ModuleVersionHeader scxqKkbNLupnKYtO5hhn;

	public ModuleSignature Signature { get; }

	public Guid VersionUid { get; }

	public Guid HeaderUid { get; }

	public Version Version { get; }

	public ModuleStatus Status { get; }

	public ModuleDisabledReason DisabledReason { get; }

	internal ModuleVersionHeader(ModuleSignature signature, Guid headerUid, ModuleStatus status, ModuleDisabledReason disabledReason = ModuleDisabledReason.Unknown)
	{
		//Discarded unreachable code: IL_003f, IL_0044
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(signature, DefaultVersionUid(headerUid, DefaultVersion), headerUid, DefaultVersion, status, disabledReason);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal ModuleVersionHeader(ModuleSignature signature, Guid versionUid, Guid headerUid, Version version, ModuleStatus status, ModuleDisabledReason disabledReason = ModuleDisabledReason.Unknown)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		btRqPXbNctL1UevJuRMO();
		base._002Ector();
		int num = 8;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 9:
				DisabledReason = disabledReason;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
				{
					num = 0;
				}
				break;
			case 6:
				Version = version;
				num = 5;
				break;
			case 5:
				Status = status;
				num = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
				{
					num = 9;
				}
				break;
			case 4:
				Signature = signature;
				num = 3;
				break;
			case 8:
				TtkktMb3FF1n1NiAinXH(signature, lOvR82bNzXPo87OjJAfa(--1418440330 ^ 0x5489498A));
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
				{
					num = 7;
				}
				break;
			case 2:
				TtkktMb3FF1n1NiAinXH(version, lOvR82bNzXPo87OjJAfa(-672123589 ^ -672089777));
				num = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
				{
					num = 3;
				}
				break;
			case 3:
				HeaderUid = headerUid;
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
				{
					num = 6;
				}
				break;
			case 1:
				return;
			case 7:
				ctVk6xb3oomoBPPgJ8E8(bVXYx0b3BnSCims3b55P(headerUid, Guid.Empty), fNCZH3b3WX7X7Xl3kZXW(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-889460160 ^ -889647786)));
				num = 2;
				break;
			default:
				VersionUid = ((versionUid != Guid.Empty) ? versionUid : DefaultVersionUid(headerUid, version));
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static ModuleVersionHeader FromItem(ModuleMetadataItem item)
	{
		int num = 2;
		int num2 = num;
		object obj;
		while (true)
		{
			switch (num2)
			{
			case 1:
				obj = horud0b3bg6P1N2YKrjU(item) as ModuleSignature;
				if (obj == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 2:
				TtkktMb3FF1n1NiAinXH(item, lOvR82bNzXPo87OjJAfa(-1217523399 ^ -1217480377));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
				{
					num2 = 0;
				}
				continue;
			default:
				obj = ((ModuleInfoMetadata)pFOYv0b3h4MaA4c6jg94(item)).GetSignature();
				break;
			}
			break;
		}
		Version result;
		return new ModuleVersionHeader(version: Version.TryParse(item.Version, out result) ? result : DefaultVersion, status: (xuSdq0b3G7epbIkBsQcv(item) != null || item.AssemblyRaw != null) ? ModuleStatus.Enabled : ModuleStatus.Disabled, signature: (ModuleSignature)obj, versionUid: XCxYEAb3Eb9fOc4Q4FV5(item), headerUid: EK4mDsb3f0uAo93fXINp(item.Header));
	}

	internal static Guid DefaultVersionUid(Guid headerUid, Version version)
	{
		return A3on0Eb3C6xDph5qw6qQ(cRy9IUb3Q5YXTawYpDbv(headerUid.ToString(), version));
	}

	static ModuleVersionHeader()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				DefaultVersion = new Version((string)lOvR82bNzXPo87OjJAfa(-1837662597 ^ -1837656917));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			case 1:
				btRqPXbNctL1UevJuRMO();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool do7WN8bNUvwkQv5wYN2U()
	{
		return scxqKkbNLupnKYtO5hhn == null;
	}

	internal static ModuleVersionHeader jOel4TbNsKhWbjKBTeXB()
	{
		return scxqKkbNLupnKYtO5hhn;
	}

	internal static void btRqPXbNctL1UevJuRMO()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object lOvR82bNzXPo87OjJAfa(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void TtkktMb3FF1n1NiAinXH(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static bool bVXYx0b3BnSCims3b55P(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object fNCZH3b3WX7X7Xl3kZXW(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void ctVk6xb3oomoBPPgJ8E8(bool condition, object P_1)
	{
		Contract.CheckArgument(condition, (string)P_1);
	}

	internal static object horud0b3bg6P1N2YKrjU(object P_0)
	{
		return ((ModuleMetadataItem)P_0).Signature;
	}

	internal static object pFOYv0b3h4MaA4c6jg94(object P_0)
	{
		return ((ModuleMetadataItem)P_0).Metadata;
	}

	internal static object xuSdq0b3G7epbIkBsQcv(object P_0)
	{
		return ((ModuleMetadataItem)P_0).ClientAssemblyRaw;
	}

	internal static Guid XCxYEAb3Eb9fOc4Q4FV5(object P_0)
	{
		return ((ModuleMetadataItem)P_0).Uid;
	}

	internal static Guid EK4mDsb3f0uAo93fXINp(object P_0)
	{
		return ((ModuleMetadataItemHeader)P_0).Uid;
	}

	internal static object cRy9IUb3Q5YXTawYpDbv(object P_0, object P_1)
	{
		return string.Concat(P_0, P_1);
	}

	internal static Guid A3on0Eb3C6xDph5qw6qQ(object P_0)
	{
		return ((string)P_0).GetDeterministicGuid();
	}
}
