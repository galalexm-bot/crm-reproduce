using System;
using System.Collections.Generic;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Deploy.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy;

public class PacketMetadata
{
	public IMetadata MetaData;

	public List<IGroupedMetadata> SubSystemMetadata;

	public Dictionary<IEntity, Guid?> SubEntitiesBefore;

	public Dictionary<IEntity, Guid?> SubEntitiesAfter;

	public ExportRuleList ExportRules;

	internal static PacketMetadata c6lqeuEpfbZaPQmLJZw1;

	public IDictionary<Guid, SubUserMetadataInfo> SubUserMetadataInfo { get; }

	public PacketMetadata(IMetadata metaData)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		O8lsHIEpvQff7poB1NqJ();
		SubUserMetadataInfo = new Dictionary<Guid, SubUserMetadataInfo>();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 3:
				return;
			case 2:
				MetaData = metaData;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num = 1;
				}
				break;
			default:
				SubEntitiesAfter = new Dictionary<IEntity, Guid?>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
				{
					num = 3;
				}
				break;
			case 1:
				SubSystemMetadata = new List<IGroupedMetadata>();
				num = 4;
				break;
			case 4:
				SubEntitiesBefore = new Dictionary<IEntity, Guid?>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static void O8lsHIEpvQff7poB1NqJ()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool XHBIGrEpQ0NlB0FMkjnY()
	{
		return c6lqeuEpfbZaPQmLJZw1 == null;
	}

	internal static PacketMetadata RILxQsEpCh1CY0Qj7oB5()
	{
		return c6lqeuEpfbZaPQmLJZw1;
	}
}
