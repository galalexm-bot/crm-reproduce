using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Globalization;
using EleWise.ELMA.Model.Transformations;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views;

[Serializable]
public class CardViewItem : RootViewItem, IContainerViewItem
{
	private ViewItemComponentSize size;

	internal static CardViewItem O3trYBoqk5nmq9bMyspj;

	[DefaultValue(false)]
	[Obsolete("Use Size instead", false)]
	[XmlForceElement]
	public bool IsFullWidth
	{
		[CompilerGenerated]
		get
		{
			return _003CIsFullWidth_003Ek__BackingField;
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
					_003CIsFullWidth_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(ViewItemComponentSize.Small)]
	public ViewItemComponentSize Size
	{
		get
		{
			//Discarded unreachable code: IL_0036, IL_0045
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return ViewItemComponentSize.Full;
				case 1:
					return size;
				case 2:
					if (!IsFullWidth)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
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
				case 0:
					return;
				case 1:
					size = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(CardPaddingType.Small)]
	public CardPaddingType Padding
	{
		[CompilerGenerated]
		get
		{
			return _003CPadding_003Ek__BackingField;
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
					_003CPadding_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
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

	[DefaultValue(CardShadow.Volume)]
	public CardShadow ShadowType
	{
		[CompilerGenerated]
		get
		{
			return _003CShadowType_003Ek__BackingField;
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
					_003CShadowType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
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

	[DefaultValue("")]
	[EleWise.ELMA.Globalization.Localizable]
	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	public string LabelText
	{
		[CompilerGenerated]
		get
		{
			return _003CLabelText_003Ek__BackingField;
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
					_003CLabelText_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
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

	[DefaultValue(CardLabelColor.Gray)]
	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	public CardLabelColor LabelColor
	{
		[CompilerGenerated]
		get
		{
			return _003CLabelColor_003Ek__BackingField;
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
					_003CLabelColor_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		return kOeFJKoq28HW2XQoaeYm(parentViewItem, this);
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return true;
	}

	public CardViewItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Ie6SuLoqeSCSXhrCho0w();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool dS2cG6oqnqk9Dw2o03kv()
	{
		return O3trYBoqk5nmq9bMyspj == null;
	}

	internal static CardViewItem oU2xl0oqOsSAq2Dj0auG()
	{
		return O3trYBoqk5nmq9bMyspj;
	}

	internal static bool kOeFJKoq28HW2XQoaeYm(object P_0, object P_1)
	{
		return ((ViewItem)P_0).IsChildValid((ViewItem)P_1);
	}

	internal static void Ie6SuLoqeSCSXhrCho0w()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
