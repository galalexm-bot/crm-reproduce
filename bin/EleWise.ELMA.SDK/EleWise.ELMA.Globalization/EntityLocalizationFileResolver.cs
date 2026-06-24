using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Globalization;

[Component]
public class EntityLocalizationFileResolver : BaseLocalizationFileResolver
{
	public static string File;

	internal static EntityLocalizationFileResolver gDxZnoGoj3uNRYGf3M1m;

	public override string FileName => File;

	public override IEnumerable<PoLineDescriptor> CollectResources(LocalizationLoadSettings settings)
	{
		List<PoLineDescriptor> list = new List<PoLineDescriptor>();
		if (settings.CustomSettings[EntityLocalizationLoadCustomSettings.ExtensionUid] is EntityGlobalizationSettings entityGlobalizationSettings && entityGlobalizationSettings.EntityUids != null)
		{
			Guid[] entityUids = entityGlobalizationSettings.EntityUids;
			foreach (Guid uid in entityUids)
			{
				EntityMetadata entityMetadata = LoadOrNullMetadata(uid);
				if (entityMetadata != null)
				{
					GetFromMetadata(entityMetadata, list);
				}
			}
			entityUids = entityGlobalizationSettings.EnumUids;
			foreach (Guid uid2 in entityUids)
			{
				EnumMetadata enumMetadata = LoadOrNullEnumMetadata(uid2);
				if (enumMetadata != null)
				{
					GetFromEnum(enumMetadata, list);
				}
			}
		}
		return list;
	}

	public EntityLocalizationFileResolver()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		fiIjyOGoUDekZTSwkh0c();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static EntityLocalizationFileResolver()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				SingletonReader.JJCZtPuTvSt();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				File = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7247028A ^ 0x7244B8FA);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void fiIjyOGoUDekZTSwkh0c()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool AJ43I1GoYe552Hsa02UP()
	{
		return gDxZnoGoj3uNRYGf3M1m == null;
	}

	internal static EntityLocalizationFileResolver ArGybdGoLNyCBysRSmnR()
	{
		return gDxZnoGoj3uNRYGf3M1m;
	}
}
