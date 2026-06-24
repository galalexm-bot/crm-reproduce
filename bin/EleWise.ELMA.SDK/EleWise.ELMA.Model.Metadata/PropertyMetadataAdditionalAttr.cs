using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata;

[Serializable]
public class PropertyMetadataAdditionalAttribute
{
	private static PropertyMetadataAdditionalAttribute ryUlTabwE40SwQhfbSjT;

	[XmlAttribute]
	public string AddtibuteName
	{
		[CompilerGenerated]
		get
		{
			return _003CAddtibuteName_003Ek__BackingField;
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
					_003CAddtibuteName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlElement("Parameter")]
	public Parameter[] Parameters
	{
		[CompilerGenerated]
		get
		{
			return _003CParameters_003Ek__BackingField;
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
					_003CParameters_003Ek__BackingField = value;
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

	public PropertyMetadataAdditionalAttribute()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		VFDZokbwC4GHBspyTF9m();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool ejwnwFbwfQgnV3s2Youy()
	{
		return ryUlTabwE40SwQhfbSjT == null;
	}

	internal static PropertyMetadataAdditionalAttribute zNENsXbwQgKeJeoHJNdN()
	{
		return ryUlTabwE40SwQhfbSjT;
	}

	internal static void VFDZokbwC4GHBspyTF9m()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
