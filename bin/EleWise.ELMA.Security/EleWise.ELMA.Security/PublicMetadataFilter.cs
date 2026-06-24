using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models.API;
using EleWise.ELMA.Services.Public;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security;

[Component]
internal class PublicMetadataFilter : IPublicMetadataFilter
{
	private static readonly Guid PublicApplication;

	private static readonly Guid PublicApplicationToken;

	private static readonly Guid PublicClientSession;

	private static readonly Guid PublicClientCacheToken;

	internal static PublicMetadataFilter WWrmm7WAAnPwQuk7UNi;

	public Func<IMetadata, bool> Filter => FilterMetadata;

	static PublicMetadataFilter()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 1:
				PublicApplication = InterfaceActivator.UID<IPublicApplication>();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_31b4b139e534452696f4bfdfc16f1b03 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				PublicClientSession = InterfaceActivator.UID<IPublicClientSession>();
				num2 = 5;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6b49024d17a94a69b2948ac938d43b7c != 0)
				{
					num2 = 3;
				}
				break;
			case 5:
				PublicClientCacheToken = InterfaceActivator.UID<IPublicClientCacheToken>();
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b6bf1b70a8924e789fc4be8e9aadc953 == 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				ECZecRWnyRapxiXy9xH();
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a1a646659a464f3fa5c9aedc64725d72 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				PublicApplicationToken = InterfaceActivator.UID<IPublicApplicationToken>();
				num2 = 4;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6370a8f224e7416eb3575ae34b77f5e3 != 0)
				{
					num2 = 4;
				}
				break;
			}
		}
	}

	private static bool FilterMetadata(object md)
	{
		//Discarded unreachable code: IL_0041, IL_00a1, IL_00b0
		int num = 3;
		int num2 = num;
		EntityMetadata entityMetadata = default(EntityMetadata);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (entityMetadata != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4162f809c129429a9879671f23845052 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return true;
			case 1:
				if (!w2UHdPW73edf782qdEA(KHn3opWixEOj303tgs5(entityMetadata), PublicApplication))
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3c78e0d08cb4410a900ca26e4b83108c != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 7;
			case 6:
				return KHn3opWixEOj303tgs5(entityMetadata) != PublicClientCacheToken;
			default:
				return false;
			case 7:
				if (!w2UHdPW73edf782qdEA(KHn3opWixEOj303tgs5(entityMetadata), PublicApplicationToken))
				{
					num2 = 5;
					break;
				}
				goto case 4;
			case 4:
				if (w2UHdPW73edf782qdEA(entityMetadata.Uid, PublicClientSession))
				{
					num2 = 6;
					break;
				}
				goto default;
			case 3:
				entityMetadata = md as EntityMetadata;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d4e4542f38914a2ba9396d8df0939ca9 != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public PublicMetadataFilter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b128c216f9744fbcbc93a88cbe7b4554 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void ECZecRWnyRapxiXy9xH()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static bool cJK4EOWWZkW5ZLaONrE()
	{
		return WWrmm7WAAnPwQuk7UNi == null;
	}

	internal static PublicMetadataFilter nfCwA2WXGv2ePoQGQyW()
	{
		return WWrmm7WAAnPwQuk7UNi;
	}

	internal static Guid KHn3opWixEOj303tgs5(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static bool w2UHdPW73edf782qdEA(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}
}
