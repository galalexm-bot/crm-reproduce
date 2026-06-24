using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Attributes;

public class DefaultValueUidAttribute : Attribute
{
	private Guid uid;

	private static DefaultValueUidAttribute MfBTfNovkAKNi450A2Nm;

	public Guid Uid
	{
		get
		{
			return uid;
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
					uid = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
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

	public DefaultValueUidAttribute(string uid)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		bH6Mf7ov2bgaR1F8tLBN();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				this.uid = new Guid(uid);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static void bH6Mf7ov2bgaR1F8tLBN()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool FReuoqovn3osk9GkBJAA()
	{
		return MfBTfNovkAKNi450A2Nm == null;
	}

	internal static DefaultValueUidAttribute g4Sb3govOrM4bwKdLkcO()
	{
		return MfBTfNovkAKNi450A2Nm;
	}
}
