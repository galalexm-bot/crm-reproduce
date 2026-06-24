using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.ExtensionPoints;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Components.Feed;

[Component]
internal class FeedWorkflowMessageBookmarkUpdateProvider : FeedMessageUpdateProviderBase<IWorkflowMessageBookmark>
{
	private static FeedWorkflowMessageBookmarkUpdateProvider orDxHCdbDZuEh3vDpHp;

	protected override IEntity GetParentEntity(IWorkflowMessageBookmark tEntity, FeedModel model)
	{
		return (IEntity)pIX0XudpjZhHTTKL9cf(YwvSnJdA716cRaLWrDC(tEntity));
	}

	public FeedWorkflowMessageBookmarkUpdateProvider()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7f79a06dec5f490c93fd11725200b9b3 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object YwvSnJdA716cRaLWrDC(object P_0)
	{
		return ((IWorkflowMessageBookmark)P_0).Bookmark;
	}

	internal static object pIX0XudpjZhHTTKL9cf(object P_0)
	{
		return ((IWorkflowBookmark)P_0).Instance;
	}

	internal static bool M0f3TidUjOn7cygqFKF()
	{
		return orDxHCdbDZuEh3vDpHp == null;
	}

	internal static FeedWorkflowMessageBookmarkUpdateProvider Rgt4ItdmjX0rw7nN5Ea()
	{
		return orDxHCdbDZuEh3vDpHp;
	}
}
