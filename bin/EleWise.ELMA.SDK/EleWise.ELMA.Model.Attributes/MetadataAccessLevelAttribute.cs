using System;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Attributes;

[Obsolete("Уровень доступа к метаданным больше не используется")]
[AttributeUsage(AttributeTargets.All)]
public class MetadataAccessLevelAttribute : Attribute
{
	private MetadataAccessLevel level;

	internal static MetadataAccessLevelAttribute wYxO99ouOio5mJv1Ncxs;

	public MetadataAccessLevel Level => level;

	public MetadataAccessLevelAttribute(MetadataAccessLevel level)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		HwohIxouPobJ08P3aAYj();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				this.level = level;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void HwohIxouPobJ08P3aAYj()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool V0kwBdou2tn783croWcl()
	{
		return wYxO99ouOio5mJv1Ncxs == null;
	}

	internal static MetadataAccessLevelAttribute Y7MB60oue0BJfaFRxx1Y()
	{
		return wYxO99ouOio5mJv1Ncxs;
	}
}
