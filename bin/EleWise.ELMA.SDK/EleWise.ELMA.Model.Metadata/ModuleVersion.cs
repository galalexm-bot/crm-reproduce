using System;
using System.Runtime.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Metadata;

[Serializable]
[DataContract]
internal sealed class ModuleVersion
{
	internal static ModuleVersion la9Dr5bNdkeJ1EJRLAVT;

	public ModuleVersionHeader Header { get; }

	public ModuleInfoMetadata Metadata { get; }

	internal ModuleVersion(ModuleInfoMetadata metadata, ModuleVersionHeader header)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				Header = header;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
				{
					num = 2;
				}
				break;
			case 2:
				return;
			case 1:
				Metadata = metadata;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static ModuleVersion FromItem(ModuleMetadataItem item)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return new ModuleVersion((ModuleInfoMetadata)mYYXbnbNj9MjQ2ehXF4l(item), (ModuleVersionHeader)fv3rHlbNYcex9xW1CuXG(item));
			case 1:
				tBPLL5bN54DkNJ1BQQxb(item, MEQXI6bNgq0PoPxO01cm(-561074844 ^ -561117926));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool jOdMPsbNl9nMFci8BnUW()
	{
		return la9Dr5bNdkeJ1EJRLAVT == null;
	}

	internal static ModuleVersion J2544TbNrP62Nb2sWFGx()
	{
		return la9Dr5bNdkeJ1EJRLAVT;
	}

	internal static object MEQXI6bNgq0PoPxO01cm(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void tBPLL5bN54DkNJ1BQQxb(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object mYYXbnbNj9MjQ2ehXF4l(object P_0)
	{
		return ((ModuleMetadataItem)P_0).Metadata;
	}

	internal static object fv3rHlbNYcex9xW1CuXG(object P_0)
	{
		return ModuleVersionHeader.FromItem((ModuleMetadataItem)P_0);
	}
}
