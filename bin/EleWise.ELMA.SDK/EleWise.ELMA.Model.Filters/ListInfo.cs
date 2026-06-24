using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Filters;

[XmlRoot("EntityListInfo")]
public class ListInfo
{
	internal static ListInfo dADZy4WYynrlqBf6gNsO;

	[XmlArray]
	public List<object> Objects { get; set; }

	[XmlElement("ListClass")]
	public string ListClass
	{
		[CompilerGenerated]
		get
		{
			return _003CListClass_003Ek__BackingField;
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
					_003CListClass_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
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

	public ListInfo()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
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
			Objects = new List<object>();
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
			{
				num = 1;
			}
		}
	}

	internal static bool YC9nMeWYMNkhgXxtfFXa()
	{
		return dADZy4WYynrlqBf6gNsO == null;
	}

	internal static ListInfo IMYWIbWYJh5ujVar3BcL()
	{
		return dADZy4WYynrlqBf6gNsO;
	}
}
