using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Globalization;

public class LocalizedString : Dictionary<int, string>
{
	internal static LocalizedString rSBrONGfaxCMINxS3dgp;

	[XmlElement("Default")]
	public string Default
	{
		[CompilerGenerated]
		get
		{
			return _003CDefault_003Ek__BackingField;
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
					_003CDefault_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public LocalizedString()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
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

	internal static bool NdmRYlGfDCpaYoRVGsLS()
	{
		return rSBrONGfaxCMINxS3dgp == null;
	}

	internal static LocalizedString xiepRRGftCbvq1cJ0nY0()
	{
		return rSBrONGfaxCMINxS3dgp;
	}
}
