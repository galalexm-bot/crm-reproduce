using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.DTO;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata.DTO.Models;

[Serializable]
public sealed class ComponentContentMetadataDTO : EntityDTO<long>
{
	private static ComponentContentMetadataDTO VCn7d1brpX4lodlkySM6;

	public ComponentContextMetadata Context
	{
		[CompilerGenerated]
		get
		{
			return _003CContext_003Ek__BackingField;
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
					_003CContext_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
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

	public ComponentContentMetadataDTO()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		EIIDxibrt2NChdFMpMId();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool AuEG4Ebra4aaeoYJNhiZ()
	{
		return VCn7d1brpX4lodlkySM6 == null;
	}

	internal static ComponentContentMetadataDTO AF9kFcbrDXfWMWT6nDRj()
	{
		return VCn7d1brpX4lodlkySM6;
	}

	internal static void EIIDxibrt2NChdFMpMId()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
