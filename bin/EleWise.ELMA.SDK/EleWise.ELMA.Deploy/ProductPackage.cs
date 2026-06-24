using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy;

[XmlRoot]
public class ProductPackage
{
	private static ProductPackage cNDTLiEP8n6js3lSw8MZ;

	[XmlElement]
	public string HashId
	{
		[CompilerGenerated]
		get
		{
			return _003CHashId_003Ek__BackingField;
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
					_003CHashId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlArray]
	public List<ProductInfo> Products { get; set; }

	public ProductPackage()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		uegc1UEPIkUuruPc1Ur6();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool v26ObjEPZ6VU7CuXF9ZE()
	{
		return cNDTLiEP8n6js3lSw8MZ == null;
	}

	internal static ProductPackage VfcGDYEPumolkwOmKMHn()
	{
		return cNDTLiEP8n6js3lSw8MZ;
	}

	internal static void uegc1UEPIkUuruPc1Ur6()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
