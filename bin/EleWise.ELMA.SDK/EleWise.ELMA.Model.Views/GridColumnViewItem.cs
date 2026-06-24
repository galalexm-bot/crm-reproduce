using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views;

[Serializable]
[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources_GridColumnViewItem), "DisplayName")]
public class GridColumnViewItem : RootViewItem, IContainerViewItem, IGridColumnViewItem
{
	private static GridColumnViewItem Fa7IgSoKgCn5dyT2CYC5;

	[DefaultValue(WidthType.Pixel)]
	public WidthType WidthType
	{
		[CompilerGenerated]
		get
		{
			return _003CWidthType_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CWidthType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(null)]
	public int? Width { get; set; }

	public GridColumnViewItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Dy48ZWoKYbQnofZNnFaA();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
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
			WidthType = WidthType.Pixel;
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
			{
				num = 1;
			}
		}
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		//Discarded unreachable code: IL_0035, IL_0044, IL_0060
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return parentViewItem is TableViewItem;
			case 1:
			case 3:
				return true;
			case 2:
				if (parentViewItem is GridViewItem)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			case 4:
				if (parentViewItem == null)
				{
					num2 = 3;
					break;
				}
				goto case 2;
			}
		}
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return true;
	}

	internal static void Dy48ZWoKYbQnofZNnFaA()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool TARcNeoK56Xy81aLUgxp()
	{
		return Fa7IgSoKgCn5dyT2CYC5 == null;
	}

	internal static GridColumnViewItem RjeACZoKjqWYSkOWrOrx()
	{
		return Fa7IgSoKgCn5dyT2CYC5;
	}
}
