using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views;

[Serializable]
public sealed class FullscreenViewItem : RootViewItem
{
	private static FullscreenViewItem QUDUX3oS4A5B2WnVRaCn;

	[DefaultValue(false)]
	private bool Fullscreen
	{
		[CompilerGenerated]
		get
		{
			return _003CFullscreen_003Ek__BackingField;
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
					_003CFullscreen_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(false)]
	public bool DestroyOnClose
	{
		[CompilerGenerated]
		get
		{
			return _003CDestroyOnClose_003Ek__BackingField;
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
					_003CDestroyOnClose_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return true;
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		return hmPfGLoSAv4uoSimaMYl(parentViewItem, this);
	}

	public FullscreenViewItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		UbaTRGoS7N7Ju6hZG2KO();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool Vq633EoS6Gv71a8YXhHe()
	{
		return QUDUX3oS4A5B2WnVRaCn == null;
	}

	internal static FullscreenViewItem rcIIyFoSHy9sgA1I2bdf()
	{
		return QUDUX3oS4A5B2WnVRaCn;
	}

	internal static bool hmPfGLoSAv4uoSimaMYl(object P_0, object P_1)
	{
		return ((ViewItem)P_0).IsChildValid((ViewItem)P_1);
	}

	internal static void UbaTRGoS7N7Ju6hZG2KO()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
