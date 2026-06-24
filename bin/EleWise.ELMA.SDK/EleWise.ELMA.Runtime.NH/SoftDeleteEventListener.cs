using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Engine;
using NHibernate.Event;
using NHibernate.Event.Default;
using NHibernate.Persister.Entity;

namespace EleWise.ELMA.Runtime.NH;

[Serializable]
public class SoftDeleteEventListener : DefaultDeleteEventListener
{
	private static SoftDeleteEventListener cweFJvWHhdMH1pv9eLZn;

	protected override void DeleteEntity(IEventSource session, object entity, EntityEntry entityEntry, bool isCascadeDeleteEnabled, IEntityPersister persister, ISet<object> transientEntities)
	{
		if (entity is ISoftDeletable && !((ISoftDeletable)entity).HardDelete)
		{
			ISoftDeletable obj = (ISoftDeletable)entity;
			((DefaultDeleteEventListener)this).CascadeBeforeDelete(session, persister, entity, entityEntry, transientEntities);
			obj.IsDeleted = true;
			((DefaultDeleteEventListener)this).CascadeAfterDelete(session, persister, entity, transientEntities);
			if (!(entity is IEntity<long>))
			{
				return;
			}
			_003C_003Ec__DisplayClass0_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass0_0();
			IEnumerable<ILastObjectProvider> extensionPoints = ComponentManager.Current.GetExtensionPoints<ILastObjectProvider>();
			CS_0024_003C_003E8__locals0.metadata = MetadataLoader.LoadMetadata(entity.GetType()) as ClassMetadata;
			if (CS_0024_003C_003E8__locals0.metadata == null)
			{
				return;
			}
			extensionPoints.FirstOrDefault(delegate(ILastObjectProvider t)
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
						if (_003C_003Ec__DisplayClass0_0.dJ6qBmQlcTQZMSvXiHmF(_003C_003Ec__DisplayClass0_0.cmXiAQQlsegeAGSiKFu6(t), CS_0024_003C_003E8__locals0.metadata.Uid))
						{
							return true;
						}
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
						{
							num2 = 0;
						}
						break;
					default:
						return MetadataLoader.IsBaseClass(_003C_003Ec__DisplayClass0_0.cmXiAQQlsegeAGSiKFu6(t), CS_0024_003C_003E8__locals0.metadata);
					}
				}
			})?.RemoveInfo((IEntity<long>)entity);
		}
		else if (!(MetadataLoader.LoadMetadata(entity.GetType()) is TablePartMetadata) || !(entity.CastAsRealType() is ITablePartItem tablePartItem) || !(tablePartItem.Parent.CastAsRealType() is ISoftDeletable softDeletable) || softDeletable.HardDelete)
		{
			((DefaultDeleteEventListener)this).DeleteEntity(session, entity, entityEntry, isCascadeDeleteEnabled, persister, transientEntities);
		}
	}

	public SoftDeleteEventListener()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		mFLB2tWHfBGPhU91DHBY();
		((DefaultDeleteEventListener)this)._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void mFLB2tWHfBGPhU91DHBY()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool HUljmJWHGQGu0Ic5D58C()
	{
		return cweFJvWHhdMH1pv9eLZn == null;
	}

	internal static SoftDeleteEventListener c70wbDWHEoiKMT52EnoQ()
	{
		return cweFJvWHhdMH1pv9eLZn;
	}
}
