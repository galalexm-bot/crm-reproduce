using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views;

[Serializable]
[DisplayName(typeof(__Resources_TableLayoutViewItem), "DisplayName")]
public class TableLayoutViewItem : RootViewItem, ILayoutViewItem
{
	private readonly List<TableColumnSettings> columnsSettings;

	private static TableLayoutViewItem jFeAVWoeJVcO3L0mXZp1;

	public List<TableColumnSettings> ColumnsSettings => columnsSettings;

	public TableLayoutViewItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		xiMcxroelVFELhFMB9wV();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
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
			columnsSettings = new List<TableColumnSettings>();
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
			{
				num = 1;
			}
		}
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (parentViewItem != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return true;
			default:
				return ODk8R1oerqfQdnR6B1fR(parentViewItem, this);
			}
		}
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return childViewItem is TableRowViewItem;
	}

	internal static void xiMcxroelVFELhFMB9wV()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool w8PQYToe9XkJ4pUq4Egr()
	{
		return jFeAVWoeJVcO3L0mXZp1 == null;
	}

	internal static TableLayoutViewItem XAbxfWoedVJflCGFVq9E()
	{
		return jFeAVWoeJVcO3L0mXZp1;
	}

	internal static bool ODk8R1oerqfQdnR6B1fR(object P_0, object P_1)
	{
		return ((ViewItem)P_0).IsChildValid((ViewItem)P_1);
	}
}
