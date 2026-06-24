using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Transformations;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views;

[Serializable]
public class PopoverViewItem : RootViewItem
{
	private static PopoverViewItem tIFb81oKQrh8TyZ5VniT;

	[DefaultValue(ViewItemComponentSize.Full)]
	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	public virtual ViewItemComponentSize Size
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
				case 0:
					return;
				case 1:
					_003CSize_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public PopoverViewItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SjvXBeoK8YMSFc5aFGj6();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				Ky5hLNoKZf4cKMi9huKc(this, ViewItemComponentSize.Full);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return true;
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
			case 2:
				if (parentViewItem == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				return FeLdE4oKuxIGAiWCLqat(parentViewItem, this);
			case 1:
				return true;
			}
		}
	}

	internal static void SjvXBeoK8YMSFc5aFGj6()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static void Ky5hLNoKZf4cKMi9huKc(object P_0, ViewItemComponentSize value)
	{
		((PopoverViewItem)P_0).Size = value;
	}

	internal static bool pt6yIsoKCuy7SSg7hT0S()
	{
		return tIFb81oKQrh8TyZ5VniT == null;
	}

	internal static PopoverViewItem m6ey4LoKvYmb9410dyS9()
	{
		return tIFb81oKQrh8TyZ5VniT;
	}

	internal static bool FeLdE4oKuxIGAiWCLqat(object P_0, object P_1)
	{
		return ((ViewItem)P_0).IsChildValid((ViewItem)P_1);
	}
}
