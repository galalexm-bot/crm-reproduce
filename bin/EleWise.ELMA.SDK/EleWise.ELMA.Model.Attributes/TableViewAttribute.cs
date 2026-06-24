using System;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true)]
public class TableViewAttribute : Attribute
{
	private readonly string serializedView;

	private TableView view;

	internal static TableViewAttribute iXl9imoZtTMerPJKwTfy;

	public TableView View
	{
		get
		{
			int num = 2;
			int num2 = num;
			TableView tableView = default(TableView);
			TableView tableView2;
			while (true)
			{
				switch (num2)
				{
				case 1:
					tableView = (view = ClassSerializationHelper.DeserializeObjectByXml<TableView>(serializedView));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					tableView2 = view;
					if (tableView2 != null)
					{
						break;
					}
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 1;
					}
					continue;
				default:
					tableView2 = tableView;
					break;
				}
				break;
			}
			return tableView2;
		}
	}

	public TableViewAttribute(string serializedView)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		nhQJAmoZ6L5swld2o1Gd();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				this.serializedView = serializedView;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void nhQJAmoZ6L5swld2o1Gd()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool sgJoEkoZwmshu9XMHNyp()
	{
		return iXl9imoZtTMerPJKwTfy == null;
	}

	internal static TableViewAttribute PpegmQoZ46pR0ble2Hgx()
	{
		return iXl9imoZtTMerPJKwTfy;
	}
}
