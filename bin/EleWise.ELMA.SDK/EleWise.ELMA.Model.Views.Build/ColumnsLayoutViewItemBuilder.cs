using System;
using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views.Builders;

public class ColumnsLayoutViewItemBuilder<TM> : ViewItemBuilder<TM, ColumnsLayoutViewItem, ColumnsLayoutViewItemBuilder<TM>> where TM : IEntity
{
	internal static object Wnmg5joa28Jp3OuoLDl0;

	public ColumnsLayoutViewItemBuilder()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal ColumnsLayoutViewItemBuilder(ViewItemBuilder parentViewItemBuilder)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(parentViewItemBuilder);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public ColumnsLayoutViewItemBuilder<TM> Column(Action<ColumnViewItemBuilder<TM>> builder = null)
	{
		ColumnViewItemBuilder<TM> obj = new ColumnViewItemBuilder<TM>(this);
		builder?.Invoke(obj);
		return this;
	}

	public ColumnsLayoutViewItemBuilder<TM> DefaultContainer(bool defaultContainer = true, int startColumnIndex = 0)
	{
		DefaultContainerViewItem defaultContainerViewItem = base.ViewItem.FormViewItem.FindItem<DefaultContainerViewItem>(DefaultContainerViewItem.ItemUid) ?? new DefaultContainerViewItem();
		defaultContainerViewItem.StartColumnIndex = startColumnIndex;
		if (defaultContainer)
		{
			Add(defaultContainerViewItem);
		}
		else
		{
			base.ViewItem.FormViewItem.Items.Add(defaultContainerViewItem);
		}
		return this;
	}

	internal static bool HMVAhJoaeCXwQ8P1gUQQ()
	{
		return Wnmg5joa28Jp3OuoLDl0 == null;
	}

	internal static object TayXTFoaP6IRYMhXli8k()
	{
		return Wnmg5joa28Jp3OuoLDl0;
	}
}
