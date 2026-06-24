using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component]
[XmlRoot("MoneyValue")]
public class MoneyWrapper : IXsiType
{
	internal static MoneyWrapper sELTMObfahF1FNR660E0;

	[XmlElement("Value")]
	public double ValueDoub
	{
		[CompilerGenerated]
		get
		{
			return _003CValueDoub_003Ek__BackingField;
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
					_003CValueDoub_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlElement("HasValue")]
	public bool HasValue
	{
		[CompilerGenerated]
		get
		{
			return _003CHasValue_003Ek__BackingField;
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
					_003CHasValue_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
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

	[XmlIgnore]
	public Money Value
	{
		get
		{
			int num = 3;
			int num2 = num;
			Money result = default(Money);
			while (true)
			{
				switch (num2)
				{
				case 1:
					return result;
				default:
					result.HasValue = HasValue;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					result.Value = ValueDoub;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					result = default(Money);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
					{
						num2 = 2;
					}
					break;
				}
			}
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					ValueDoub = value.Value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return;
				default:
					HasValue = value.HasValue;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 2;
					}
					break;
				}
			}
		}
	}

	public MoneyWrapper()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		zrOXCKbfwNKaUyNv1l0k();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public MoneyWrapper(Money money)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 2;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
		{
			num = 2;
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
				HasValue = money.HasValue;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
				{
					num = 0;
				}
				break;
			case 2:
				Value = dgA3jkbf4JU2spFQ1JN8(money.Value);
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static void zrOXCKbfwNKaUyNv1l0k()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool JoVLHLbfDa0uI9m6NdT3()
	{
		return sELTMObfahF1FNR660E0 == null;
	}

	internal static MoneyWrapper v3J0T5bft4Wq7U3Yaaf8()
	{
		return sELTMObfahF1FNR660E0;
	}

	internal static Money dgA3jkbf4JU2spFQ1JN8(double d)
	{
		return d;
	}
}
