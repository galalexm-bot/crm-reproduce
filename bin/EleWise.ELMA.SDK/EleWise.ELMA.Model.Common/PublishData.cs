using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Common;

public class PublishData
{
	internal static PublishData WypBKEhqiNJ06nPZj8eO;

	public Dictionary<Guid, IRootMetadata> RestartNeededMetadata { get; }

	public Dictionary<Guid, IRootMetadata> DeltaPublishedMetadata { get; }

	public Dictionary<Guid, IRootMetadata> SoftPublishedMetadata { get; }

	internal List<IMetadataItem> MetadataItems { get; }

	internal bool Any()
	{
		//Discarded unreachable code: IL_0065, IL_0074, IL_0084, IL_0093
		int num = 4;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (eU9pOBhqKECwDJQTcv0I(DeltaPublishedMetadata) > 0)
					{
						goto end_IL_0012;
					}
					goto case 1;
				case 1:
					return eU9pOBhqKECwDJQTcv0I(RestartNeededMetadata) > 0;
				case 2:
				case 3:
					return true;
				case 4:
					if (eU9pOBhqKECwDJQTcv0I(SoftPublishedMetadata) > 0)
					{
						break;
					}
					goto default;
				}
				num2 = 3;
				continue;
				end_IL_0012:
				break;
			}
			num = 2;
		}
	}

	internal bool OnlySoftPublished()
	{
		//Discarded unreachable code: IL_0057, IL_0066
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (eU9pOBhqKECwDJQTcv0I(DeltaPublishedMetadata) != 0)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			default:
				return RestartNeededMetadata.Count == 0;
			case 1:
				return false;
			}
		}
	}

	public PublishData()
	{
		//Discarded unreachable code: IL_006a, IL_006f
		qfUXVShqXjCcwNtHmhV3();
		RestartNeededMetadata = new Dictionary<Guid, IRootMetadata>();
		DeltaPublishedMetadata = new Dictionary<Guid, IRootMetadata>();
		SoftPublishedMetadata = new Dictionary<Guid, IRootMetadata>();
		MetadataItems = new List<IMetadataItem>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static int eU9pOBhqKECwDJQTcv0I(object P_0)
	{
		return ((Dictionary<Guid, IRootMetadata>)P_0).Count;
	}

	internal static bool N4EAN0hqRs4ma5Cy403X()
	{
		return WypBKEhqiNJ06nPZj8eO == null;
	}

	internal static PublishData JcE9JohqqVqSUW6vnGrF()
	{
		return WypBKEhqiNJ06nPZj8eO;
	}

	internal static void qfUXVShqXjCcwNtHmhV3()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
