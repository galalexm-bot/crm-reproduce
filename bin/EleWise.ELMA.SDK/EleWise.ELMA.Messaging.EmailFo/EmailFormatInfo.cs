using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Messaging.EmailFormat;

[Serializable]
[XmlRoot]
public class EmailFormatInfo
{
	internal static EmailFormatInfo BHFjHbhymESJtGnmWraE;

	[XmlElement("Name")]
	public string Name
	{
		[CompilerGenerated]
		get
		{
			return _003CName_003Ek__BackingField;
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
					_003CName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
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

	[XmlElement("SubjectPrefix")]
	public string SubjectPrefix
	{
		[CompilerGenerated]
		get
		{
			return _003CSubjectPrefix_003Ek__BackingField;
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
					_003CSubjectPrefix_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public EmailFormatInfo()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		dnawsFhyJmP4BGiaSMGq();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool Hu5Mqehyydq9cRiUZs6Q()
	{
		return BHFjHbhymESJtGnmWraE == null;
	}

	internal static EmailFormatInfo Xe1MC6hyMp2YZNxMHx5M()
	{
		return BHFjHbhymESJtGnmWraE;
	}

	internal static void dnawsFhyJmP4BGiaSMGq()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
