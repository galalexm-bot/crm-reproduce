using System.Runtime.CompilerServices;
using AutoMapper;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Security.DTO.Models;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.DTO.Managers;

public class UserDTOManager : DTOManager, IUserDTOManager, IConfigurationService, IUserInfoDTOService
{
	private static UserDTOManager zGW92XuzRKFWKfH2NlP;

	public UserManager Manager
	{
		[CompilerGenerated]
		get
		{
			return _003CManager_003Ek__BackingField;
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
					_003CManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2be4970ad4d405ab7ed74c6b68c9f7d == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual UserDTO LoadOrNull(long id)
	{
		int num = 1;
		int num2 = num;
		EleWise.ELMA.Security.Models.IUser user = default(EleWise.ELMA.Security.Models.IUser);
		while (true)
		{
			switch (num2)
			{
			case 1:
				user = Manager.LoadOrNull(id);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae9e5ed1f04543cd9a3ea633dd768889 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return null;
			}
			if (user != null)
			{
				return Mapper.Map<EleWise.ELMA.Security.Models.IUser, UserDTO>(user, new UserDTO());
			}
			num2 = 2;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7eacf98b652644699fca43e43408d382 == 0)
			{
				num2 = 1;
			}
		}
	}

	public virtual string GetFullName(long id)
	{
		//Discarded unreachable code: IL_007a, IL_0089
		int num = 3;
		int num2 = num;
		EleWise.ELMA.Security.Models.IUser user = default(EleWise.ELMA.Security.Models.IUser);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (user != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1c9893e65c104705bb8b228f8a38d9cd == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			case 3:
				user = Manager.LoadOrNull(id);
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f6614d006512404f8cab65f09d3e1c89 == 0)
				{
					num2 = 2;
				}
				break;
			default:
				return null;
			case 1:
				return (string)dt3SKMm5cLyH1NDhpOl(user);
			}
		}
	}

	public UserDTOManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SPfn6KmA82bmyDXV3Bp();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6f96338790994363b52cd5c55eb1342f != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool qDM4kemkMiHQ9HUCFeM()
	{
		return zGW92XuzRKFWKfH2NlP == null;
	}

	internal static UserDTOManager InkFdympx7rKHrROZfy()
	{
		return zGW92XuzRKFWKfH2NlP;
	}

	internal static object dt3SKMm5cLyH1NDhpOl(object P_0)
	{
		return ((EleWise.ELMA.Security.Models.IUser)P_0).FullName;
	}

	internal static void SPfn6KmA82bmyDXV3Bp()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
