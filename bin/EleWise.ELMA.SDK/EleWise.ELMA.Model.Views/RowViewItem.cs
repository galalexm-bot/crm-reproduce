using System;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Views.Toolbox;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views;

[Serializable]
[DisplayName(typeof(__Resources_RowViewItem), "DisplayName")]
public class RowViewItem : RootViewItem, ILayoutViewItem, IContainerViewItem
{
	[Component(Order = 150)]
	private class ToolboxItem : CommonViewItemToolboxItem<RowViewItem>
	{
		private static object BvbWmKCE4Qh3OCwbwAGB;

		public ToolboxItem()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool FjiqHZCE6yXoJOMMChZy()
		{
			return BvbWmKCE4Qh3OCwbwAGB == null;
		}

		internal static ToolboxItem doYpNbCEHZpIfZvPRXwv()
		{
			return (ToolboxItem)BvbWmKCE4Qh3OCwbwAGB;
		}
	}

	private static RowViewItem o2oHXvokfPgey0m7ue7s;

	[XmlIgnore]
	public CellViewItem LeftCell => base.Items[0] as CellViewItem;

	[XmlIgnore]
	public CellViewItem RightCell => base.Items[1] as CellViewItem;

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		return parentViewItem.IsChildValid(this);
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return childViewItem is CellViewItem;
	}

	public RowViewItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		olec9yokvQDWYxE63e55();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool LAEgihokQKKpbeAtmVtV()
	{
		return o2oHXvokfPgey0m7ue7s == null;
	}

	internal static RowViewItem fNahh3okC7Qa7XIFB7vk()
	{
		return o2oHXvokfPgey0m7ue7s;
	}

	internal static void olec9yokvQDWYxE63e55()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
