using System;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Views.Toolbar;

[Serializable]
public class ToolbarItemListAddingException : Exception
{
	internal static ToolbarItemListAddingException qCCHTxotO3vcwhWflRNF;

	public Guid ParentUid
	{
		[CompilerGenerated]
		get
		{
			return _003CParentUid_003Ek__BackingField;
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
					_003CParentUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Guid ItemUid
	{
		[CompilerGenerated]
		get
		{
			return _003CItemUid_003Ek__BackingField;
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
					_003CItemUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public override string Message => (string)Or1MvYot10tXN0SpFh3P(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A81B9B4 ^ 0x6A83D4D0), ItemUid, ParentUid);

	public ToolbarItemListAddingException(ToolbarItem parent, ToolbarItem item)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			case 2:
				ParentUid = parent.Uid;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
				{
					num = 0;
				}
				break;
			default:
				ItemUid = HuARXJotPMPlAxWVyfV5(item);
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static bool Blq656ot254DRY8U7aNO()
	{
		return qCCHTxotO3vcwhWflRNF == null;
	}

	internal static ToolbarItemListAddingException VZjmwuoteOVbfFERuG3j()
	{
		return qCCHTxotO3vcwhWflRNF;
	}

	internal static Guid HuARXJotPMPlAxWVyfV5(object P_0)
	{
		return ((ToolbarItem)P_0).Uid;
	}

	internal static object Or1MvYot10tXN0SpFh3P(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}
}
