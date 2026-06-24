using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using AutoMapper;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.DTO.Models;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.DTO.Managers;

public class UserGroupDTOManager : DTOManager, IUserGroupDTOManager, IConfigurationService
{
	internal static UserGroupDTOManager dtLicFmNS7Av1LsB2tU;

	public UserGroupManager Manager
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
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a53a06d0e4134332947f6164df41fb0f == 0)
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

	public virtual UserGroupDTO Save(UserGroupDTO group)
	{
		//Discarded unreachable code: IL_0079, IL_0088
		int num = 6;
		IUserGroup userGroup = default(IUserGroup);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					if (userGroup != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b496c4412b534db6beb066c8296e663d != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 2:
					return group;
				case 7:
					break;
				case 6:
					userGroup = Manager.LoadOrNull(group.Id);
					num2 = 5;
					continue;
				default:
					Mapper.Map<UserGroupDTO, IUserGroup>(group, userGroup);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c78060c4cac8419092e4610bf7a03750 != 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					Manager.Save(userGroup);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_77bfde1a0739446782f0bda00c988550 == 0)
					{
						num2 = 3;
					}
					continue;
				case 3:
					group.Id = userGroup.Id;
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0dd863774da04dfd9f21706b4b60a6b9 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			}
			userGroup = InterfaceActivator.Create<IUserGroup>();
			num = 4;
		}
	}

	public virtual UserGroupDTO Load(long id)
	{
		return Mapper.Map<IUserGroup, UserGroupDTO>(Manager.Load(id), new UserGroupDTO());
	}

	public virtual UserGroupDTO LoadOrNull(long id)
	{
		//Discarded unreachable code: IL_007d, IL_008c
		int num = 3;
		IUserGroup userGroup = default(IUserGroup);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					return null;
				default:
					return Mapper.Map<IUserGroup, UserGroupDTO>(userGroup, new UserGroupDTO());
				case 2:
					if (userGroup != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_488725796a2e487f95c022f5056d8a88 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 1;
				case 3:
					break;
				}
				break;
			}
			userGroup = Manager.LoadOrNull(id);
			num = 2;
		}
	}

	public virtual UserGroupDTO Load(Guid uid)
	{
		return Mapper.Map<IUserGroup, UserGroupDTO>(Manager.Load(uid), new UserGroupDTO());
	}

	public virtual UserGroupDTO LoadOrNull(Guid uid)
	{
		//Discarded unreachable code: IL_0040
		int num = 1;
		int num2 = num;
		IUserGroup userGroup = default(IUserGroup);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return null;
			case 2:
				return Mapper.Map<IUserGroup, UserGroupDTO>(userGroup, new UserGroupDTO());
			case 1:
				userGroup = Manager.LoadOrNull(uid);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_66aae9daa3f84bb5931ed90b4759f85c != 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (userGroup != null)
				{
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c537c1b3b4be444086af51f6e9112d23 != 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	public virtual ICollection<UserGroupDTO> FindAll()
	{
		return (from entity in Manager.FindAll()
			select Mapper.Map<IUserGroup, UserGroupDTO>(entity, new UserGroupDTO())).ToList();
	}

	public virtual void Delete(long id)
	{
		int num = 1;
		int num2 = num;
		IUserGroup userGroup = default(IUserGroup);
		while (true)
		{
			switch (num2)
			{
			case 1:
				userGroup = Manager.LoadOrNull(id);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0b98d9f52b424149868b80d852714a70 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				Manager.Delete(userGroup);
				num2 = 3;
				continue;
			case 3:
				return;
			}
			if (userGroup != null)
			{
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_75955a8c33b24cdca4663f20d9ee3c3b == 0)
				{
					num2 = 2;
				}
				continue;
			}
			return;
		}
	}

	public UserGroupDTOManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		CBuBqfmBrdxW1NuReaC();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dffee0180fb244db9738339fa28792b4 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool iTMqKgmZ2nXqYciGsRQ()
	{
		return dtLicFmNS7Av1LsB2tU == null;
	}

	internal static UserGroupDTOManager R0ZkytmxVa7g6tanTt4()
	{
		return dtLicFmNS7Av1LsB2tU;
	}

	internal static void CBuBqfmBrdxW1NuReaC()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
