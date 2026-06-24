using System;
using System.Linq.Expressions;
using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views.Builders;

public class ColumnViewItemBuilder<TM> : RootViewItemBuilder<TM, ColumnViewItem, ColumnViewItemBuilder<TM>> where TM : IEntity
{
	private static object DSS6SBoa1wDaCHSPXFR7;

	public ColumnViewItemBuilder()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal ColumnViewItemBuilder(ViewItemBuilder parentViewItemBuilder)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(parentViewItemBuilder);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public ColumnViewItemBuilder<TM> Property(Expression<Func<TM, object>> property, Action<PropertyViewItemBuilder<TM>> builder = null)
	{
		PropertyViewItemBuilder<TM> obj = new PropertyViewItemBuilder<TM>(property, this);
		builder?.Invoke(obj);
		return this;
	}

	public ColumnViewItemBuilder<TM> Property<TM2>(Expression<Func<TM2, object>> property, Action<PropertyViewItemBuilder<TM2>> builder = null) where TM2 : TM
	{
		PropertyViewItemBuilder<TM2> obj = new PropertyViewItemBuilder<TM2>(property, this);
		builder?.Invoke(obj);
		return this;
	}

	public ColumnViewItemBuilder<TM> DefaultContainer(bool defaultContainer = true)
	{
		DefaultContainerViewItem item = base.ViewItem.FormViewItem.FindItem<DefaultContainerViewItem>(DefaultContainerViewItem.ItemUid) ?? new DefaultContainerViewItem();
		if (defaultContainer)
		{
			Add(item);
		}
		else
		{
			base.ViewItem.FormViewItem.Items.Add(item);
		}
		return this;
	}

	internal static bool sw75mLoaNf38KjVVV4hy()
	{
		return DSS6SBoa1wDaCHSPXFR7 == null;
	}

	internal static object rZUOsYoa36ad499Swusf()
	{
		return DSS6SBoa1wDaCHSPXFR7;
	}
}
