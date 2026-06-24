using System;
using System.Web.UI.WebControls;
using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views.Builders;

public class TableRowViewItemBuilder<TM> : ViewItemBuilder<TM, TableRowViewItem, TableRowViewItemBuilder<TM>> where TM : IEntity
{
	internal static object JMYbepoagXTrVQdF8kFj;

	public TableRowViewItemBuilder()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal TableRowViewItemBuilder(ViewItemBuilder parentViewItemBuilder)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(parentViewItemBuilder);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public TableRowViewItemBuilder<TM> Height(string height)
	{
		base.ViewItem.Height = new Unit(height);
		return this;
	}

	public TableRowViewItemBuilder<TM> Height(Unit height)
	{
		base.ViewItem.Height = height;
		return this;
	}

	public TableRowViewItemBuilder<TM> Cell(Action<TableCellViewItemBuilder<TM>> builder = null)
	{
		TableCellViewItemBuilder<TM> obj = new TableCellViewItemBuilder<TM>(this);
		builder?.Invoke(obj);
		return this;
	}

	internal static bool bN36eBoa5g4hG1bwmKvY()
	{
		return JMYbepoagXTrVQdF8kFj == null;
	}

	internal static object diUJ0YoajyoiScvTs5nu()
	{
		return JMYbepoagXTrVQdF8kFj;
	}
}
