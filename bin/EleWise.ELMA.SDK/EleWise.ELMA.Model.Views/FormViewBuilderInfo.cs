using System.Collections.Generic;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views;

public sealed class FormViewBuilderInfo
{
	internal static FormViewBuilderInfo n4XafHoiYRwsbXIh1xwL;

	public List<PropertyViewInfo> Properties { get; }

	public List<NotificationInfo> Notifications { get; }

	public bool ClosePopup
	{
		[CompilerGenerated]
		get
		{
			return _003CClosePopup_003Ek__BackingField;
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
					_003CClosePopup_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public FormViewBuilderInfo()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Nc0uBBoistT1vOcKgrRi();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
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
			case 2:
				Notifications = new List<NotificationInfo>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
				{
					num = 0;
				}
				break;
			case 1:
				Properties = new List<PropertyViewInfo>();
				num = 2;
				break;
			}
		}
	}

	internal static void Nc0uBBoistT1vOcKgrRi()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool ce6NqwoiLtJQDWaIXuIi()
	{
		return n4XafHoiYRwsbXIh1xwL == null;
	}

	internal static FormViewBuilderInfo Mr958PoiUMTHueN5jQqm()
	{
		return n4XafHoiYRwsbXIh1xwL;
	}
}
