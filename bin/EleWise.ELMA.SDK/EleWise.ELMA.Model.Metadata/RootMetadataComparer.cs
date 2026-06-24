using System;
using System.Collections.Generic;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata;

public class RootMetadataComparer : IEqualityComparer<IRootMetadata>
{
	internal static RootMetadataComparer IlfDG8b3vEkLUv46K0nm;

	public static IEqualityComparer<IRootMetadata> Instance { get; }

	private RootMetadataComparer()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		mhL8JWb3u6q6PMf4K1AB();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	bool IEqualityComparer<IRootMetadata>.Equals(IRootMetadata x, IRootMetadata y)
	{
		return QsP8RYb3VY2Q2qCVPdgT(FxyeCIb3IDorp9KXsANd(x), y.Uid);
	}

	int IEqualityComparer<IRootMetadata>.GetHashCode(IRootMetadata obj)
	{
		int num = 1;
		int num2 = num;
		Guid guid = default(Guid);
		while (true)
		{
			switch (num2)
			{
			case 1:
				guid = FxyeCIb3IDorp9KXsANd(obj);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return guid.GetHashCode();
			}
		}
	}

	static RootMetadataComparer()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				mhL8JWb3u6q6PMf4K1AB();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				Instance = new RootMetadataComparer();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void mhL8JWb3u6q6PMf4K1AB()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool DkGndfb38UyA9KW0dSTN()
	{
		return IlfDG8b3vEkLUv46K0nm == null;
	}

	internal static RootMetadataComparer EmlokGb3ZNFNHCbg7bOk()
	{
		return IlfDG8b3vEkLUv46K0nm;
	}

	internal static Guid FxyeCIb3IDorp9KXsANd(object P_0)
	{
		return ((IMetadata)P_0).Uid;
	}

	internal static bool QsP8RYb3VY2Q2qCVPdgT(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}
}
