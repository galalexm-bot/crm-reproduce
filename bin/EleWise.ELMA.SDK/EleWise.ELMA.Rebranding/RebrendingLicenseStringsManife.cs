using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Rebranding;

[XmlRoot("strings")]
public class RebrendingLicenseStringsManifest
{
	private static RebrendingLicenseStringsManifest JQXLcyPqGZsuH48rdoV;

	[XmlElement("Locale")]
	[DataMember]
	public string Locale
	{
		[CompilerGenerated]
		get
		{
			return _003CLocale_003Ek__BackingField;
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
					_003CLocale_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlElement("FileName")]
	[DataMember]
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public RebrendingLicenseStringsManifest()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		ESpEgpPTqToYvSkMUQX();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool lwgcOHPKJIRFoBASlhc()
	{
		return JQXLcyPqGZsuH48rdoV == null;
	}

	internal static RebrendingLicenseStringsManifest zGcZiYPXKZucVVMtM3T()
	{
		return JQXLcyPqGZsuH48rdoV;
	}

	internal static void ESpEgpPTqToYvSkMUQX()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
