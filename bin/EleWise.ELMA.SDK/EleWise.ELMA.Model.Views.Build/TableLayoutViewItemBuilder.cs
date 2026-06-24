using System;
using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views.Builders;

public class TableLayoutViewItemBuilder<TM> : ViewItemBuilder<TM, TableLayoutViewItem, TableLayoutViewItemBuilder<TM>> where TM : IEntity
{
	private static object jEFfNVoa7hhiEJXu8YfQ;

	public TableLayoutViewItemBuilder()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal TableLayoutViewItemBuilder(ViewItemBuilder parentViewItemBuilder)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(parentViewItemBuilder);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public TableLayoutViewItemBuilder<TM> Columns(Action<TableColumnsBuilder> builder = null)
	{
		builder?.Invoke(new TableColumnsBuilder(base.ViewItem));
		return this;
	}

	public TableLayoutViewItemBuilder<TM> Row(Action<TableRowViewItemBuilder<TM>> builder = null)
	{
		builder?.Invoke(new TableRowViewItemBuilder<TM>(this));
		return this;
	}

	internal static bool UWJNThoaxDt6765gCFjm()
	{
		return jEFfNVoa7hhiEJXu8YfQ == null;
	}

	internal static object qrnOn1oa0CQv569KtHbt()
	{
		return jEFfNVoa7hhiEJXu8YfQ;
	}
}
