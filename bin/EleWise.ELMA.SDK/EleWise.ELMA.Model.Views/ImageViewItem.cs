using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Globalization;
using EleWise.ELMA.Model.Transformations;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views;

[Serializable]
public class ImageViewItem : ViewItem
{
	private static ImageViewItem HGDoc0oK1YGZbTODuOAp;

	public string Source
	{
		[CompilerGenerated]
		get
		{
			return _003CSource_003Ek__BackingField;
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
					_003CSource_003Ek__BackingField = value;
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

	[DefaultValue(ViewItemImageSize.Content)]
	public ViewItemImageSize Size
	{
		[CompilerGenerated]
		get
		{
			return _003CSize_003Ek__BackingField;
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
					_003CSize_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
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

	[DefaultValue(ViewItemImageShape.Default)]
	public ViewItemImageShape Shape
	{
		[CompilerGenerated]
		get
		{
			return _003CShape_003Ek__BackingField;
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
					_003CShape_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
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

	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	[DefaultValue(null)]
	[EleWise.ELMA.Globalization.Localizable]
	public string Tooltip
	{
		[CompilerGenerated]
		get
		{
			return _003CTooltip_003Ek__BackingField;
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
					_003CTooltip_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
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

	public ImageViewItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		PsA1DtoKpL9SOuT8Vern();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
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
				Size = ViewItemImageSize.Content;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return false;
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		//Discarded unreachable code: IL_0057, IL_0066
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return parentViewItem.IsChildValid(this);
			case 1:
				return true;
			case 2:
				if (parentViewItem == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			}
		}
	}

	internal static void PsA1DtoKpL9SOuT8Vern()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool mC4kiFoKNmsNSsHv1HPv()
	{
		return HGDoc0oK1YGZbTODuOAp == null;
	}

	internal static ImageViewItem xJ6uo8oK334l8jnIP4vh()
	{
		return HGDoc0oK1YGZbTODuOAp;
	}
}
