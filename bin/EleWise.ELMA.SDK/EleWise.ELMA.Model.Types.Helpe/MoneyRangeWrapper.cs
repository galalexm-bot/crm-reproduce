using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Ranges;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component]
[XmlRoot("MoneyRangeValue")]
public class MoneyRangeWrapper : IXsiType
{
	private static MoneyRangeWrapper FCvOBnbfhSK3gKboTNNo;

	[XmlElement("From")]
	public MoneyWrapper From
	{
		[CompilerGenerated]
		get
		{
			return _003CFrom_003Ek__BackingField;
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
					_003CFrom_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlElement("To")]
	public MoneyWrapper To
	{
		[CompilerGenerated]
		get
		{
			return _003CTo_003Ek__BackingField;
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
					_003CTo_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public MoneyRangeWrapper()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		sYQgMubffI4TapHirvin();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public MoneyRangeWrapper(MoneyRange source)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				From = new MoneyWrapper(source.From);
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
				{
					num = 0;
				}
				break;
			case 2:
				To = new MoneyWrapper(source.To);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
				{
					num = 1;
				}
				break;
			case 1:
				return;
			}
		}
	}

	internal static void sYQgMubffI4TapHirvin()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool Ablxq6bfGSDAo6Wan4Yq()
	{
		return FCvOBnbfhSK3gKboTNNo == null;
	}

	internal static MoneyRangeWrapper y2mZjNbfEAKcJny50oAP()
	{
		return FCvOBnbfhSK3gKboTNNo;
	}
}
