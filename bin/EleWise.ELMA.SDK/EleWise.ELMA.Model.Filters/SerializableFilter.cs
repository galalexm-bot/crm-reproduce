using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Filters;

[Component]
[XmlRoot("Filter")]
public class SerializableFilter : IXsiRoot
{
	private static SerializableFilter Bs99NZWY4P0EbtjhR3Yr;

	[XmlElement("FilterType")]
	public string FilterType
	{
		[CompilerGenerated]
		get
		{
			return _003CFilterType_003Ek__BackingField;
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
					_003CFilterType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
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

	[XmlElement("ResolverType")]
	public string ResolverType
	{
		[CompilerGenerated]
		get
		{
			return _003CResolverType_003Ek__BackingField;
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
					_003CResolverType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlArray]
	public List<FilterProperty> Properties { get; set; }

	public SerializableFilter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		qGXCsnWYA6Usai2fMOaw();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
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
			Properties = new List<FilterProperty>();
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
			{
				num = 0;
			}
		}
	}

	internal static bool aIfjXcWY6e64twQ9DPhA()
	{
		return Bs99NZWY4P0EbtjhR3Yr == null;
	}

	internal static SerializableFilter HaAjMIWYHZwm0vrlqene()
	{
		return Bs99NZWY4P0EbtjhR3Yr;
	}

	internal static void qGXCsnWYA6Usai2fMOaw()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
