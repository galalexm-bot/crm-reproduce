using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Components;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Models;

public class ComplexExecutorInfo
{
	private IUser _user;

	private IUserGroup _group;

	internal static ComplexExecutorInfo XQ1aAAtPOCCamreyjnR;

	public string PrefixedValue
	{
		[CompilerGenerated]
		get
		{
			return _003CPrefixedValue_003Ek__BackingField;
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
					_003CPrefixedValue_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fa1b4c3a88294db7b3c25698c3f06dd7 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IUser User
	{
		get
		{
			//Discarded unreachable code: IL_00a9, IL_00b8
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (_user != null)
					{
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a7933e38c68f4f69b40e459b15579199 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 4;
				case 4:
					if (!XYv46CttW9rtHTwDG9N(PrefixedValue))
					{
						num2 = 3;
						continue;
					}
					break;
				case 3:
					_user = BaseEntityUserTypeSelector.LoadEntity(PrefixedValue, InterfaceActivator.TypeOf<IUser>()) as IUser;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_364662b38d3b4bdb9f3f1f11b8889cdc == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			return _user;
		}
	}

	public IUserGroup UserGroup
	{
		get
		{
			//Discarded unreachable code: IL_00b0, IL_00bf
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					_group = BaseEntityUserTypeSelector.LoadEntity(PrefixedValue, InterfaceActivator.TypeOf<IUserGroup>()) as IUserGroup;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b54421a4e10b4c2fa10cef566e462fbd == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					if (_group != null)
					{
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6c7be8ec8b6749dcb0601e062f5515fa == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 1;
				case 1:
					if (!XYv46CttW9rtHTwDG9N(PrefixedValue))
					{
						num2 = 4;
						continue;
					}
					break;
				}
				break;
			}
			return _group;
		}
	}

	public ComplexExecutorInfo()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a9bad31b2eb24bb9b571e9b822d133bf != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public ComplexExecutorInfo(IUser user)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		OLIS6KtUNXEKfXARQCS();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6e35a1cd804541a884550671c71dbb1c != 0)
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
				PrefixedValue = (string)IXiPgEtJe6HA9cmVdjn(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x9D1442B ^ 0x9D13923), BaseEntityUserTypeSelector.GetFullPrefix((string)lFnvskto9CSaXLyrS5u(0x78610A3D ^ 0x786105E1)), user.Id);
				num = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e0cdbab05b2b455cab94ec0ba1efc443 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public ComplexExecutorInfo(IUserGroup group)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		OLIS6KtUNXEKfXARQCS();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fc5e0189a7f447a7b93cd505b96d5f05 != 0)
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
			PrefixedValue = (string)IXiPgEtJe6HA9cmVdjn(lFnvskto9CSaXLyrS5u(-566078848 ^ -566087800), RQLUJHtKnsUxSbMUAjO(lFnvskto9CSaXLyrS5u(-731479136 ^ -731447624)), group.Id);
			num = 1;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3e35bb8d9f5b4a1d9826edea4d9dca96 != 0)
			{
				num = 1;
			}
		}
	}

	internal static bool gQQWZttvpx53GmejWX2()
	{
		return XQ1aAAtPOCCamreyjnR == null;
	}

	internal static ComplexExecutorInfo H4qavZtC9PrnVostNVO()
	{
		return XQ1aAAtPOCCamreyjnR;
	}

	internal static void OLIS6KtUNXEKfXARQCS()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static object lFnvskto9CSaXLyrS5u(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object IXiPgEtJe6HA9cmVdjn(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object RQLUJHtKnsUxSbMUAjO(object P_0)
	{
		return BaseEntityUserTypeSelector.GetFullPrefix((string)P_0);
	}

	internal static bool XYv46CttW9rtHTwDG9N(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}
}
