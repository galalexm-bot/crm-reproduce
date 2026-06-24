using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security;

[Serializable]
public sealed class UserNameAlreadyExistsException : Exception
{
	private static UserNameAlreadyExistsException fx67v9NOZbOiWI4LvNt;

	public string UserName
	{
		[CompilerGenerated]
		get
		{
			return _003CUserName_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CUserName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1bc92e0376794fc182b6e366eee82dbd == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public List<IUser> Users { get; private set; }

	public UserNameAlreadyExistsException(string login)
	{
		//Discarded unreachable code: IL_0049, IL_004e
		b3so2dNGmAxP6CA2aK1();
		base._002Ector((string)CwXLSwN0Z0cvguE5JN8(QgYbfBNFHYAX3SSyBCN(-2037738356 ^ -2037733318), new object[1] { login }));
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dffee0180fb244db9738339fa28792b4 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				Users = new List<IUser>();
				num = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c537c1b3b4be444086af51f6e9112d23 == 0)
				{
					num = 0;
				}
				break;
			case 2:
				return;
			case 1:
				UserName = login;
				num = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_98c0ec8bd6124c50b29441c60f6a53bf == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public UserNameAlreadyExistsException(IUser entity, List<IUser> users)
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-185816410 ^ -185821680), entity.UserName));
		UserName = entity.UserName;
		Users = users;
	}

	internal static bool oE0iw2NqOf4k5RTvUOK()
	{
		return fx67v9NOZbOiWI4LvNt == null;
	}

	internal static UserNameAlreadyExistsException Tk0DCZNcJ36RXQNgQ0x()
	{
		return fx67v9NOZbOiWI4LvNt;
	}

	internal static void b3so2dNGmAxP6CA2aK1()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static object QgYbfBNFHYAX3SSyBCN(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object CwXLSwN0Z0cvguE5JN8(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}
}
