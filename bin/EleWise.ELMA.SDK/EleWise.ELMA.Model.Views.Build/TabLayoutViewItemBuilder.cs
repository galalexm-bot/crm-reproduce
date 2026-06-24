using System;
using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views.Builders;

public class TabLayoutViewItemBuilder<TM> : ViewItemBuilder<TM, TabLayoutViewItem, TabLayoutViewItemBuilder<TM>> where TM : IEntity
{
	internal static object p32i2woapiqvrIFoEwL6;

	public TabLayoutViewItemBuilder()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
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

	internal TabLayoutViewItemBuilder(ViewItemBuilder parentViewItemBuilder)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(parentViewItemBuilder);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public TabLayoutViewItemBuilder<TM> Tab(Action<TabViewItemBuilder<TM>> builder = null)
	{
		builder?.Invoke(new TabViewItemBuilder<TM>(this));
		return this;
	}

	public TabLayoutViewItemBuilder<TM> UseTabProvider(bool useTabProvider = true, bool useOriginalModel = true)
	{
		base.ViewItem.UseTabProvider = useTabProvider;
		base.ViewItem.TabProviderUseOriginalModel = useOriginalModel;
		return this;
	}

	internal static bool uGwZ3soaa9HaZuHgoCmN()
	{
		return p32i2woapiqvrIFoEwL6 == null;
	}

	internal static object W0GjYFoaDdxFxe81OcWb()
	{
		return p32i2woapiqvrIFoEwL6;
	}
}
