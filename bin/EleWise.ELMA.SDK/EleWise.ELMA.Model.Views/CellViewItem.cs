using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views;

[Serializable]
public class CellViewItem : RootViewItem, ILayoutViewItem, IContainerViewItem
{
	private static CellViewItem rJIicroTYZ5qKJiORto9;

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		return parentViewItem.IsChildValid(this);
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return true;
	}

	public CellViewItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		zMLpT9oTsADxMXEgBj2K();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool fMwmkfoTL4jpVPO28aFP()
	{
		return rJIicroTYZ5qKJiORto9 == null;
	}

	internal static CellViewItem ubjZEPoTU7gT0KYiB6Wb()
	{
		return rJIicroTYZ5qKJiORto9;
	}

	internal static void zMLpT9oTsADxMXEgBj2K()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
