using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Web.UI.WebControls;
using System.Xml.Serialization;
using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views;

[Serializable]
[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources_TableRowViewItem), "DisplayName")]
public class TableRowViewItem : RootViewItem, ILayoutItemViewItem
{
	internal static TableRowViewItem uVKC51oesnNcGlw1ZNg5;

	[XmlIgnore]
	public Unit Height
	{
		[CompilerGenerated]
		get
		{
			return _003CHeight_003Ek__BackingField;
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
					_003CHeight_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue("")]
	[XmlElement("Height")]
	public string HeightString
	{
		get
		{
			int num = 1;
			int num2 = num;
			Unit height = default(Unit);
			while (true)
			{
				switch (num2)
				{
				default:
					return height.ToString();
				case 1:
					height = Height;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
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
				case 1:
					Height = new Unit(value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (parentViewItem == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				return parentViewItem is TableLayoutViewItem;
			case 1:
				return true;
			}
		}
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return childViewItem is TableCellViewItem;
	}

	public TableRowViewItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		XyxNjmoPFdU1PeLn0M1d();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool H1hqBpoec0KYiW1kOyUC()
	{
		return uVKC51oesnNcGlw1ZNg5 == null;
	}

	internal static TableRowViewItem FmIBrroezvClWR7y6Rpn()
	{
		return uVKC51oesnNcGlw1ZNg5;
	}

	internal static void XyxNjmoPFdU1PeLn0M1d()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
