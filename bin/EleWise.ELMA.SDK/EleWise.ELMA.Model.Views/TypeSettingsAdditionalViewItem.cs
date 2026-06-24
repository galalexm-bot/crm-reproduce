using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views;

[Serializable]
public sealed class TypeSettingsAdditionalViewItem : ViewItem
{
	private static TypeSettingsAdditionalViewItem lt90DkoTQeyx4NyRQub8;

	[DefaultValue(false)]
	public bool Disabled
	{
		[CompilerGenerated]
		get
		{
			return _003CDisabled_003Ek__BackingField;
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
					_003CDisabled_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
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

	[DefaultValue(false)]
	public bool Published
	{
		[CompilerGenerated]
		get
		{
			return _003CPublished_003Ek__BackingField;
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
					_003CPublished_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
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

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return false;
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		return true;
	}

	public TypeSettingsAdditionalViewItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		okdvIMoT8YlZWJ9xqWeQ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool chLN95oTCZsXAN5DoVKe()
	{
		return lt90DkoTQeyx4NyRQub8 == null;
	}

	internal static TypeSettingsAdditionalViewItem CXBu3noTvQRVpVk4aYkl()
	{
		return lt90DkoTQeyx4NyRQub8;
	}

	internal static void okdvIMoT8YlZWJ9xqWeQ()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
