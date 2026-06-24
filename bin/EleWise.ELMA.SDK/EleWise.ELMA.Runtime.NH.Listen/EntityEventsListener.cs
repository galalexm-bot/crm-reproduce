using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Event;

namespace EleWise.ELMA.Runtime.NH.Listeners;

[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public class EntityEventsListener : IEntityEventsListener
{
	private static EntityEventsListener djPf4YWAMRFJII1xYRuS;

	public ISessionProvider SessionProvider
	{
		[CompilerGenerated]
		get
		{
			return _003CSessionProvider_003Ek__BackingField;
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
					_003CSessionProvider_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
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

	public virtual bool OnPreInsert(PreInsertEvent @event)
	{
		return false;
	}

	public virtual void OnPostInsert(PostInsertEvent @event)
	{
	}

	public virtual bool OnPreUpdate(PreUpdateEvent @event)
	{
		return false;
	}

	public virtual void OnPostUpdate(PostUpdateEvent @event)
	{
	}

	public virtual bool OnPreDelete(PreDeleteEvent @event)
	{
		return false;
	}

	public virtual void OnPostDelete(PostDeleteEvent @event)
	{
	}

	public virtual void OnPostRemoveCollection(PostCollectionRemoveEvent @event)
	{
	}

	public virtual void OnPostRecreateCollection(PostCollectionRecreateEvent @event)
	{
	}

	public virtual void OnPostUpdateCollection(PostCollectionUpdateEvent @event)
	{
	}

	public virtual void OnPreRemoveCollection(PreCollectionRemoveEvent @event)
	{
	}

	public virtual void OnPreRecreateCollection(PreCollectionRecreateEvent @event)
	{
	}

	public virtual void OnPreUpdateCollection(PreCollectionUpdateEvent @event)
	{
	}

	public virtual void OnPreLoad(PreLoadEvent @event)
	{
	}

	protected void RunInChildSession(AbstractEvent @event, Action<ISession> action)
	{
		IEventSource session = @event.get_Session();
		try
		{
			ISession session2 = ((ISession)session).GetSession((EntityMode)0);
			SessionProvider.SetCurrentSession(session2, string.Empty);
			action(session2);
		}
		finally
		{
			SessionProvider.SetCurrentSession((ISession)(object)session, string.Empty);
		}
	}

	public virtual void OnFlush(FlushEvent @event)
	{
	}

	public EntityEventsListener()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		XGmEV0WAdO0M89mKyc5P();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool YNkPR1WAJ3qP2nw5bKFx()
	{
		return djPf4YWAMRFJII1xYRuS == null;
	}

	internal static EntityEventsListener Wv6a0XWA9wWYflssWXo5()
	{
		return djPf4YWAMRFJII1xYRuS;
	}

	internal static void XGmEV0WAdO0M89mKyc5P()
	{
		SingletonReader.PushGlobal();
	}
}
