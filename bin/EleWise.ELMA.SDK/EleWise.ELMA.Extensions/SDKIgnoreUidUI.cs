using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Extensions;

[Component]
public class SDKIgnoreUidUI : IIgnoreUidUI
{
	private static SDKIgnoreUidUI OrHKXZG4UxtDFj1MOLwx;

	public virtual bool NeedIgnoreUid(EntityMetadata md)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (M01WZvG4zYSmpi7meD6w(md) == GZApuQG6BR1rkg63YQVP(h71wAHG6F4MbiHj97gGI(-309639236 ^ -309377106)))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
					{
						num2 = 0;
					}
					break;
				}
				return false;
			default:
				return true;
			}
		}
	}

	public SDKIgnoreUidUI()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Guid M01WZvG4zYSmpi7meD6w(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object h71wAHG6F4MbiHj97gGI(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Guid GZApuQG6BR1rkg63YQVP(object P_0)
	{
		return Guid.Parse((string)P_0);
	}

	internal static bool wXxZorG4sCkF7X1r7CUs()
	{
		return OrHKXZG4UxtDFj1MOLwx == null;
	}

	internal static SDKIgnoreUidUI m8qnShG4ck18RNoHEmBW()
	{
		return OrHKXZG4UxtDFj1MOLwx;
	}
}
