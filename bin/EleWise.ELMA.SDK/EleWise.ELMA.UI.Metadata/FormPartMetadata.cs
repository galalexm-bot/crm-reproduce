using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.UI.Metadata;

public class FormPartMetadata : AbstractMetadata
{
	private static FormPartMetadata KcumHuBE3862DQ6Z4kJl;

	public FormContextMetadata Context
	{
		[CompilerGenerated]
		get
		{
			return _003CContext_003Ek__BackingField;
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
					_003CContext_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
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

	public FormViewItem View
	{
		[CompilerGenerated]
		get
		{
			return _003CView_003Ek__BackingField;
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
					_003CView_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
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

	public override void InitNew()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				View = new FormViewItem();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
				{
					num2 = 3;
				}
				break;
			case 1:
				Context = new FormContextMetadata();
				num2 = 4;
				break;
			case 5:
				return;
			case 2:
				base.InitNew();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				IKXmDHBEDUfVt9t4V6q4(View, null);
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
				{
					num2 = 2;
				}
				break;
			case 4:
				Context.InitNew();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual void GenerateNewUids()
	{
		//Discarded unreachable code: IL_004a
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				if (Context == null)
				{
					num2 = 4;
					break;
				}
				goto case 3;
			case 4:
				return;
			case 3:
				r9vdN1BEwilnsM0NPbLc(Context);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				W0GyG2BEtAEP2MdIpOqt(this, Guid.NewGuid());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public FormPartMetadata()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Sr8WMEBE4pZX8k5wW7JV();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool lH9TFlBEpkZOa5sG6Syk()
	{
		return KcumHuBE3862DQ6Z4kJl == null;
	}

	internal static FormPartMetadata fipUJnBEal2w0H6c2MwQ()
	{
		return KcumHuBE3862DQ6Z4kJl;
	}

	internal static void IKXmDHBEDUfVt9t4V6q4(object P_0, object P_1)
	{
		((ViewItem)P_0).InitNew((ViewItem)P_1);
	}

	internal static void W0GyG2BEtAEP2MdIpOqt(object P_0, Guid value)
	{
		((AbstractMetadata)P_0).Uid = value;
	}

	internal static void r9vdN1BEwilnsM0NPbLc(object P_0)
	{
		((FormContextMetadata)P_0).GenerateNewUids();
	}

	internal static void Sr8WMEBE4pZX8k5wW7JV()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
