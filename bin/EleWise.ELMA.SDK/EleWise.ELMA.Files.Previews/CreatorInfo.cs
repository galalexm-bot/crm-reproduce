using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Files.Previews;

[Serializable]
[XmlRoot]
public class CreatorInfo
{
	internal static CreatorInfo uKGDIrGNZaBO7qDjymLb;

	[XmlElement("Uid")]
	public Guid Uid
	{
		[CompilerGenerated]
		get
		{
			return _003CUid_003Ek__BackingField;
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
					_003CUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
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

	[XmlElement("Disable")]
	public bool Disable
	{
		[CompilerGenerated]
		get
		{
			return _003CDisable_003Ek__BackingField;
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
				case 0:
					return;
				case 1:
					_003CDisable_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public CreatorInfo()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		HFwMkEGNVle9BWaLDgQ6();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool XCEsKgGNuLjGg4F7pU9D()
	{
		return uKGDIrGNZaBO7qDjymLb == null;
	}

	internal static CreatorInfo VJapruGNI190xMbDbyQx()
	{
		return uKGDIrGNZaBO7qDjymLb;
	}

	internal static void HFwMkEGNVle9BWaLDgQ6()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
