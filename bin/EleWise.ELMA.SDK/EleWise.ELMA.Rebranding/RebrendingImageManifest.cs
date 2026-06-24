using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Rebranding;

[XmlRoot("images")]
public class RebrendingImageManifest
{
	private static RebrendingImageManifest Pb1lfpPSty8gqeEwj9H;

	[DataMember]
	[XmlElement("FullName")]
	public string FullName
	{
		[CompilerGenerated]
		get
		{
			return _003CFullName_003Ek__BackingField;
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
					_003CFullName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
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

	[DataMember]
	[XmlElement("FileName")]
	public string FileName
	{
		[CompilerGenerated]
		get
		{
			return _003CFileName_003Ek__BackingField;
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
					_003CFileName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public RebrendingImageManifest()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool un2TEKPi9Bn8yM0vNU2()
	{
		return Pb1lfpPSty8gqeEwj9H == null;
	}

	internal static RebrendingImageManifest quEB3HPRYfe0heNo9ns()
	{
		return Pb1lfpPSty8gqeEwj9H;
	}
}
