using System.Web.UI.WebControls;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views.Builders;

public class TableColumnBuilder
{
	private readonly TableColumnSettings columnSettings;

	internal static TableColumnBuilder vtcIWmoaJt4FLDR61Emd;

	internal TableColumnBuilder(TableColumnSettings columnSettings)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		VSEb8ooal1MOZePUZwSY();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
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
			this.columnSettings = columnSettings;
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
			{
				num = 1;
			}
		}
	}

	public TableColumnBuilder Width(string width)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return this;
			case 1:
				columnSettings.Width = new Unit(width);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public TableColumnBuilder Width(Unit width)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return this;
			case 1:
				RVNmKioarkcUKTm013l2(columnSettings, width);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void VSEb8ooal1MOZePUZwSY()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool QpjfZCoa9iDZkewVx2WS()
	{
		return vtcIWmoaJt4FLDR61Emd == null;
	}

	internal static TableColumnBuilder l0iuLRoadc8Lnp4pTsmt()
	{
		return vtcIWmoaJt4FLDR61Emd;
	}

	internal static void RVNmKioarkcUKTm013l2(object P_0, Unit value)
	{
		((TableColumnSettings)P_0).Width = value;
	}
}
