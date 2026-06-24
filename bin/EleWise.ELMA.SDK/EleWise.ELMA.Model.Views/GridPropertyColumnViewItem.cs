using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Views;

[Serializable]
[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources_GridPropertyColumnViewItem), "DisplayName")]
public class GridPropertyColumnViewItem : PropertyViewItem, IGridColumnViewItem
{
	internal static Guid ContentSlotUid;

	internal static GridPropertyColumnViewItem IbEJgqoXB4cHwXoc1G5F;

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
				case 1:
					_003CWidthType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
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

	[DefaultValue(null)]
	public int? Width { get; set; }

	public GridPropertyColumnViewItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		burBRyoXblpZFCcW3nZs();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
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
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
			{
				num = 1;
			}
		}
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		//Discarded unreachable code: IL_0056, IL_0065
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (!(parentViewItem is GridViewItem))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
					{
						num2 = 2;
					}
					break;
				}
				goto default;
			case 2:
				return parentViewItem is TableViewItem;
			default:
				return true;
			case 1:
				if (parentViewItem == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		//Discarded unreachable code: IL_0052, IL_0061
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (childViewItem is PropertyCaptionViewItem)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				return childViewItem is DynamicSlotViewItem;
			case 1:
				return true;
			}
		}
	}

	static GridPropertyColumnViewItem()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				burBRyoXblpZFCcW3nZs();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
				{
					num2 = 0;
				}
				break;
			default:
				ContentSlotUid = new Guid((string)j68MmDoXh1QLYDL45I60(-643786247 ^ -643644709));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static void burBRyoXblpZFCcW3nZs()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool pfJoVSoXWALvyo8GEpIF()
	{
		return IbEJgqoXB4cHwXoc1G5F == null;
	}

	internal static GridPropertyColumnViewItem iYgmRpoXoSUtmbx69Jef()
	{
		return IbEJgqoXB4cHwXoc1G5F;
	}

	internal static object j68MmDoXh1QLYDL45I60(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
