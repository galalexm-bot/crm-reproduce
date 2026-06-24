using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Attributes;

public class BaseClassAttribute : Attribute
{
	private Guid baseClassUid;

	private static BaseClassAttribute sAZVDEouzKKyml85YO3x;

	public Guid BaseClassUid
	{
		get
		{
			return baseClassUid;
		}
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
					baseClassUid = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
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

	public BaseClassAttribute()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		wMYqnmoIW3x0wAFY87ny();
		baseClassUid = Guid.Empty;
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public BaseClassAttribute(string baseClassUid)
	{
		//Discarded unreachable code: IL_003a, IL_003f
		wMYqnmoIW3x0wAFY87ny();
		this.baseClassUid = Guid.Empty;
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
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
			this.baseClassUid = new Guid(baseClassUid);
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
			{
				num = 1;
			}
		}
	}

	internal static bool L86tbAoIFPnmLyGAXJ17()
	{
		return sAZVDEouzKKyml85YO3x == null;
	}

	internal static BaseClassAttribute QKei2ioIBFA3dd8NtmXW()
	{
		return sAZVDEouzKKyml85YO3x;
	}

	internal static void wMYqnmoIW3x0wAFY87ny()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
