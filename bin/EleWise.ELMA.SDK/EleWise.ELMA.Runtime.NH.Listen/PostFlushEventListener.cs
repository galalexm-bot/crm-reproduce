using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Event;

namespace EleWise.ELMA.Runtime.NH.Listeners;

[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public class PostFlushEventListener : IPostFlushEventListener
{
	private static PostFlushEventListener vG4hukW7vQyTicfVbarN;

	public virtual void OnPostInsert(PostInsertEvent @event)
	{
	}

	public virtual void OnPostUpdate(PostUpdateEvent @event)
	{
	}

	public virtual void OnPostDelete(PostDeleteEvent @event)
	{
	}

	public virtual void OnPostUpdateCollection(PostCollectionUpdateEvent @event)
	{
	}

	public PostFlushEventListener()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		m4e37gW7uVFXpK7Ryu29();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void m4e37gW7uVFXpK7Ryu29()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool g1XB5OW78OqEoSiCCi3P()
	{
		return vG4hukW7vQyTicfVbarN == null;
	}

	internal static PostFlushEventListener gZRQOoW7Z3HUGsIemOxN()
	{
		return vG4hukW7vQyTicfVbarN;
	}
}
