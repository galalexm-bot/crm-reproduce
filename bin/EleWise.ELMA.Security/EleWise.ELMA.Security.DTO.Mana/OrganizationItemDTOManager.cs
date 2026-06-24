using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AutoMapper;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Security.DTO.Models;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.DTO.Managers;

public class OrganizationItemDTOManager : DTOManager, IOrganizationItemDTOManager, IConfigurationService
{
	internal static OrganizationItemDTOManager GxiNTsuS6Arxe7V9aXF;

	public OrganizationItemManager Manager
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
				case 1:
					_003CManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2df53c26a6094060a56f82d6cf94e7da == 0)
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

	public virtual OrganizationItemDTO LoadRoot()
	{
		return (OrganizationItemDTO)ObP35Mu1gOsSQvbd2gk(Manager);
	}

	public virtual OrganizationItemDTO LoadOrNull(Guid uid)
	{
		int num = 2;
		int num2 = num;
		IOrganizationItem organizationItem = default(IOrganizationItem);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (organizationItem == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_98c0ec8bd6124c50b29441c60f6a53bf != 0)
					{
						num2 = 0;
					}
					break;
				}
				return Mapper.Map<IOrganizationItem, OrganizationItemDTO>(organizationItem, new OrganizationItemDTO());
			default:
				return null;
			case 2:
				organizationItem = Manager.LoadOrNull(uid);
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e19c59c87b9f40ffa6cb17beeb01edcf == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual OrganizationItemDTO LoadOrNull(long id)
	{
		int num = 1;
		int num2 = num;
		IOrganizationItem organizationItem = default(IOrganizationItem);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return null;
			case 1:
				organizationItem = Manager.LoadOrNull(id);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8176869ecaf44a0b8819db51e9ec5eb4 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			if (organizationItem != null)
			{
				return Mapper.Map<IOrganizationItem, OrganizationItemDTO>(organizationItem, new OrganizationItemDTO());
			}
			num2 = 2;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6949750552fc4dcdbaec6842e5667482 == 0)
			{
				num2 = 0;
			}
		}
	}

	public virtual List<UserDTO> UsersToOrganizationItem(long id)
	{
		IOrganizationItem organizationItem = Manager.LoadOrNull(id);
		EleWise.ELMA.Security.Models.IUser user = organizationItem.User;
		if (user != null)
		{
			return new List<UserDTO> { Mapper.Map<EleWise.ELMA.Security.Models.IUser, UserDTO>(user, new UserDTO()) };
		}
		ISet<EleWise.ELMA.Security.Models.IUser> users = organizationItem.Users;
		if (users != null && ((ICollection<EleWise.ELMA.Security.Models.IUser>)users).Count > 0)
		{
			List<UserDTO> list = new List<UserDTO>();
			{
				foreach (EleWise.ELMA.Security.Models.IUser item in (IEnumerable<EleWise.ELMA.Security.Models.IUser>)users)
				{
					list.Add(Mapper.Map<EleWise.ELMA.Security.Models.IUser, UserDTO>(item, new UserDTO()));
				}
				return list;
			}
		}
		return null;
	}

	public OrganizationItemDTOManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2c264a158ded4d26bea0177e79c88bc4 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool orLxpuu9BBqHhL9v9CR()
	{
		return GxiNTsuS6Arxe7V9aXF == null;
	}

	internal static OrganizationItemDTOManager OnD9L1ufft2uwwD2CNO()
	{
		return GxiNTsuS6Arxe7V9aXF;
	}

	internal static object ObP35Mu1gOsSQvbd2gk(object P_0)
	{
		return ((OrganizationItemManager)P_0).LoadRoot();
	}
}
