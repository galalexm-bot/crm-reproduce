using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views;

[Serializable]
public class TypeSettingsViewItem : ViewItem
{
	internal static TypeSettingsViewItem LsweOPoTSPWK6tRJUHte;

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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
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
				case 0:
					return;
				case 1:
					_003CPublished_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
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
		return false;
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		return true;
	}

	public TypeSettingsViewItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		MU6SxCoTqhea4s0lL4cc();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool WdVcxqoTiPFlN3Ijlbdd()
	{
		return LsweOPoTSPWK6tRJUHte == null;
	}

	internal static TypeSettingsViewItem PRp0JOoTRbVI5xyCJuRx()
	{
		return LsweOPoTSPWK6tRJUHte;
	}

	internal static void MU6SxCoTqhea4s0lL4cc()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
