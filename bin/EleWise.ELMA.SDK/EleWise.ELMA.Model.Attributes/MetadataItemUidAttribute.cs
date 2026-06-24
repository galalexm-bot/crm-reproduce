using System;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Attributes;

[AttributeUsage(AttributeTargets.Assembly)]
public class MetadataItemUidAttribute : Attribute
{
	private static MetadataItemUidAttribute bu6aNoofTwBtMn95UAw4;

	public Guid ItemUid { get; }

	public MetadataItemUidAttribute(string itemUid)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		oTl2eVofOanHaNPkEvcw();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
		{
			num = 0;
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
				Contract.NotNullOrEmpty(itemUid, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29254301 ^ -29112895));
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
				{
					num = 1;
				}
				break;
			case 2:
				ItemUid = new Guid(itemUid);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public MetadataItemUidAttribute(Guid itemUid)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		oTl2eVofOanHaNPkEvcw();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				ItemUid = itemUid;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void oTl2eVofOanHaNPkEvcw()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool El9k2rofk5BeKqvQIjVS()
	{
		return bu6aNoofTwBtMn95UAw4 == null;
	}

	internal static MetadataItemUidAttribute r70xRIofnFC974vDmoA0()
	{
		return bu6aNoofTwBtMn95UAw4;
	}
}
