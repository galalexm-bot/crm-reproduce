using System.Collections.Generic;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Types;
using EleWise.ELMA.DataClasses;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Model.Types.Settings;

public static class DropDownListSettingsHelper
{
	public static System.Collections.Generic.IEnumerable<DropDownItem> Items(this DropDownListSettings settings)
	{
		DropDownItemList dropDownItemList = new DropDownItemList();
		string itemsString = settings.get_ItemsString();
		if (string.IsNullOrWhiteSpace(itemsString))
		{
			return dropDownItemList;
		}
		if (settings.get_ShowTree())
		{
			dropDownItemList.ParseTree(itemsString);
		}
		else
		{
			dropDownItemList.Parse(itemsString);
		}
		return dropDownItemList;
	}

	public static System.Collections.Generic.IEnumerable<DropDownItem> ClientItems(DataClass settings)
	{
		return ((DropDownListSettings)(object)((settings is DropDownListSettings) ? settings : null)).Items();
	}
}
