using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.FullTextSearch.Services;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.FullTextSearch.ExtensionPoints;

[Component(Type = ComponentType.Server)]
internal sealed class FullTextSearchAfterDeltaPublishEventHandler : IAfterDeltaPublishEventHandler, IEventHandler
{
	private readonly IFullTextTypeMappingService mappingService;

	internal static FullTextSearchAfterDeltaPublishEventHandler E8D9LEGqQxhtOegxeL3X;

	public FullTextSearchAfterDeltaPublishEventHandler(IFullTextTypeMappingService mappingService)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		tAoTDGGq8td3ff3y25pK();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			this.mappingService = mappingService;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
			{
				num = 0;
			}
		}
	}

	public void Processing(MetadataPublishedEventArgs e)
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
				mappingService.CreateMapping();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void tAoTDGGq8td3ff3y25pK()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool IZUILiGqCxxAy8bRt824()
	{
		return E8D9LEGqQxhtOegxeL3X == null;
	}

	internal static FullTextSearchAfterDeltaPublishEventHandler VDNvfkGqv2YPkl2MEfeB()
	{
		return E8D9LEGqQxhtOegxeL3X;
	}
}
