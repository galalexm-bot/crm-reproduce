using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Filters;

[XmlInclude(typeof(ListInfo))]
[XmlInclude(typeof(QueryParametersListInfo))]
[XmlRoot("FilterProperty")]
public class FilterProperty
{
	internal static FilterProperty kCC9OUWY7FwTONv0a9JU;

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
				case 0:
					return;
				case 1:
					_003CUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlElement("Value")]
	public object Value
	{
		[CompilerGenerated]
		get
		{
			return _003CValue_003Ek__BackingField;
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
					_003CValue_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public FilterProperty()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		k0OHsCWYm9qfuDcA3MEO();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool Bg1CcHWYxsg6GuvKHwkx()
	{
		return kCC9OUWY7FwTONv0a9JU == null;
	}

	internal static FilterProperty sv4OTeWY0NAct0GZrNpp()
	{
		return kCC9OUWY7FwTONv0a9JU;
	}

	internal static void k0OHsCWYm9qfuDcA3MEO()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
