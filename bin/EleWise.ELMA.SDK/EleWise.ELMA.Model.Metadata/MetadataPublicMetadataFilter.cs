using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Public;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata;

[Component]
internal class MetadataPublicMetadataFilter : IPublicMetadataFilter
{
	private static MetadataPublicMetadataFilter Sy620EbwS4XLcoDa4ZDw;

	public Func<IMetadata, bool> Filter => FilterMetadata;

	private static bool FilterMetadata(object md)
	{
		int num = 4;
		int num2 = num;
		Type typeByUid = default(Type);
		EntityMetadata entityMetadata = default(EntityMetadata);
		while (true)
		{
			switch (num2)
			{
			default:
				typeByUid = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(entityMetadata.Uid);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				if (typeByUid != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto IL_00bb;
			case 3:
				if (entityMetadata != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto IL_00bb;
			case 1:
				return !nM2H6gbwqhNx3EWpaG12(typeof(IMetadata).TypeHandle).IsAssignableFrom(typeByUid);
			case 4:
				{
					entityMetadata = md as EntityMetadata;
					num2 = 3;
					break;
				}
				IL_00bb:
				return true;
			}
		}
	}

	public MetadataPublicMetadataFilter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type nM2H6gbwqhNx3EWpaG12(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool pjBdgVbwiIKYQUc8AGwu()
	{
		return Sy620EbwS4XLcoDa4ZDw == null;
	}

	internal static MetadataPublicMetadataFilter RLDS51bwRpdynHo1PAhK()
	{
		return Sy620EbwS4XLcoDa4ZDw;
	}
}
