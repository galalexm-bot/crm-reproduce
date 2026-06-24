using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views.Builders;

public class TableColumnsBuilder
{
	private readonly TableLayoutViewItem tableViewItem;

	internal static TableColumnsBuilder kChVqMoamHetUAqB90qH;

	internal TableColumnsBuilder(TableLayoutViewItem tableViewItem)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			this.tableViewItem = tableViewItem;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
			{
				num = 0;
			}
		}
	}

	public TableColumnsBuilder Column(Action<TableColumnBuilder> builder = null)
	{
		TableColumnSettings tableColumnSettings = new TableColumnSettings();
		tableViewItem.ColumnsSettings.Add(tableColumnSettings);
		builder?.Invoke(new TableColumnBuilder(tableColumnSettings));
		return this;
	}

	internal static bool GNmohDoayGMpEN3jwZrp()
	{
		return kChVqMoamHetUAqB90qH == null;
	}

	internal static TableColumnsBuilder BGqkOGoaMjsj39MWknMr()
	{
		return kChVqMoamHetUAqB90qH;
	}
}
