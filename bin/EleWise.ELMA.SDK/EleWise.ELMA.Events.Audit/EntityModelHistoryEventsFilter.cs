using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Events.Audit;

public abstract class EntityModelHistoryEventsFilterBase : IEntityModelHistoryEventsFilter
{
	private EntityMetadata[] entityMetadatas;

	internal static EntityModelHistoryEventsFilterBase YkEMdFGLNfa5ewuTtO8w;

	protected abstract Type[] ExcludeTypes { get; }

	protected virtual EntityMetadata[] MetadataList
	{
		get
		{
			int num = 2;
			int num2 = num;
			EntityMetadata[] array2;
			EntityMetadata[] array = default(EntityMetadata[]);
			while (true)
			{
				switch (num2)
				{
				case 2:
					array2 = entityMetadatas;
					if (array2 != null)
					{
						break;
					}
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					array = (entityMetadatas = (from t in ((IEnumerable<Type>)f5q0dkGLa5TRtv49goQF(this)).SelectMany((Type t) => ComponentManager.Current.GetExtensionPointTypes<IEntity>().Where(t.IsAssignableFrom))
						select MetadataLoader.LoadMetadata(t)).OfType<EntityMetadata>().ToArray());
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					array2 = array;
					break;
				}
				break;
			}
			return array2;
		}
	}

	bool IEntityModelHistoryEventsFilter.IsSupported(IEntity entity, Guid actionUid)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = default(_003C_003Ec__DisplayClass5_0);
		while (true)
		{
			switch (num2)
			{
			default:
				_003C_003Ec__DisplayClass5_.entity = entity;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return !ExcludeTypes.Any(_003C_003Ec__DisplayClass5_._003CEleWise_002EELMA_002EEvents_002EAudit_002EIEntityModelHistoryEventsFilter_002EIsSupported_003Eb__0);
			}
		}
	}

	bool IEntityModelHistoryEventsFilter.IsSupported(Guid typeUid, long entityId, Guid entityUid, Guid actionUid)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = default(_003C_003Ec__DisplayClass6_0);
		while (true)
		{
			switch (num2)
			{
			default:
				_003C_003Ec__DisplayClass6_.typeUid = typeUid;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				return ((IEnumerable<EntityMetadata>)QyxnUTGLD8YiiTHhBAov(this)).All(_003C_003Ec__DisplayClass6_._003CEleWise_002EELMA_002EEvents_002EAudit_002EIEntityModelHistoryEventsFilter_002EIsSupported_003Eb__0);
			case 1:
				_003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected EntityModelHistoryEventsFilterBase()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object f5q0dkGLa5TRtv49goQF(object P_0)
	{
		return ((EntityModelHistoryEventsFilterBase)P_0).ExcludeTypes;
	}

	internal static bool iTojfwGL3JkoO0qC1Ghl()
	{
		return YkEMdFGLNfa5ewuTtO8w == null;
	}

	internal static EntityModelHistoryEventsFilterBase l65LXFGLptoGSwDVGvPA()
	{
		return YkEMdFGLNfa5ewuTtO8w;
	}

	internal static object QyxnUTGLD8YiiTHhBAov(object P_0)
	{
		return ((EntityModelHistoryEventsFilterBase)P_0).MetadataList;
	}
}
