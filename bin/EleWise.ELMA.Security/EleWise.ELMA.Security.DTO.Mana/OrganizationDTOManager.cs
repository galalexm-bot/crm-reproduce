using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AutoMapper;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Security.DTO.Models;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.DTO.Managers;

public class OrganizationDTOManager : DTOManager, IOrganizationDTOManager, IConfigurationService
{
	private static OrganizationDTOManager mhGo3OmWjxb4jRgwgqn;

	public OrganizationModelManager Manager
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
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a5d922da527e46afbe4b139adb51cde5 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual int CurrentVersion => Manager.CurrentVersion;

	public virtual OrganizationModelDTO LoadOrNull()
	{
		return Mapper.Map<IOrganizationModel, OrganizationModelDTO>((IOrganizationModel)Ekcmcumixt4B1PX8vN0(Manager), new OrganizationModelDTO());
	}

	public virtual OrganizationModelDTO LoadOrNull(int id)
	{
		return Mapper.Map<IOrganizationModel, OrganizationModelDTO>(Manager.Load(id), new OrganizationModelDTO());
	}

	public virtual OrganizationModelDTO LoadPublishedOrNull()
	{
		return Mapper.Map<IOrganizationModel, OrganizationModelDTO>((IOrganizationModel)f4P2slm7XOWv8VmXKrT(Manager), new OrganizationModelDTO());
	}

	public virtual void Save(OrganizationModelDTO organizationModel)
	{
		int num = 5;
		int num2 = num;
		IOrganizationModel organizationModel2 = default(IOrganizationModel);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				Mapper.Map<OrganizationModelDTO, IOrganizationModel>(organizationModel, organizationModel2);
				num2 = 3;
				break;
			case 5:
				organizationModel2 = (IOrganizationModel)Ekcmcumixt4B1PX8vN0(Manager);
				num2 = 4;
				break;
			case 2:
				organizationModel.Id = organizationModel2.Id;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_651070b1c9bd4381bbb7379d68d6508e == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				if (organizationModel2.Id > 0)
				{
					num2 = 2;
					break;
				}
				goto case 1;
			case 0:
				return;
			case 3:
				Manager.Save(organizationModel2);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c537c1b3b4be444086af51f6e9112d23 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual int Publish(OrganizationModelDTO organizationModel, out OrganizationModelPublishWarning warning)
	{
		int num = 3;
		int num2 = num;
		IOrganizationModel organizationModel2 = default(IOrganizationModel);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (organizationModel2.Id > 0)
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_562220c988b04dea969b2dc6cde52015 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 5;
			default:
				return Manager.Publish(organizationModel2, out warning);
			case 5:
				Mapper.Map<OrganizationModelDTO, IOrganizationModel>(organizationModel, organizationModel2);
				num2 = 4;
				break;
			case 3:
				organizationModel2 = (IOrganizationModel)Ekcmcumixt4B1PX8vN0(Manager);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_edc68bc1c90e495e835b4f28be0d6753 != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				organizationModel.Id = organizationModel2.Id;
				num2 = 5;
				break;
			case 4:
				warning = null;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b081c717aa3147caa220888eaef123d9 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual int Publish(OrganizationModelDTO organizationModel)
	{
		int num = 3;
		int num2 = num;
		IOrganizationModel organizationModel2 = default(IOrganizationModel);
		while (true)
		{
			switch (num2)
			{
			case 4:
				organizationModel.Id = organizationModel2.Id;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fc5e0189a7f447a7b93cd505b96d5f05 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				if (organizationModel2.Id > 0)
				{
					num2 = 4;
					break;
				}
				goto default;
			case 1:
				return Manager.Publish(organizationModel2);
			default:
				Mapper.Map<OrganizationModelDTO, IOrganizationModel>(organizationModel, organizationModel2);
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d2fa92555e394879ba912e266541f735 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				organizationModel2 = Manager.Load();
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_9a38cebc63824d86b02d76fd37722379 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public virtual int Validate(OrganizationModelDTO organizationModel)
	{
		int num = 1;
		int num2 = num;
		IOrganizationModel organizationModel2 = default(IOrganizationModel);
		while (true)
		{
			switch (num2)
			{
			case 3:
				Mapper.Map<OrganizationModelDTO, IOrganizationModel>(organizationModel, organizationModel2);
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_147eeadb328044dda63bf8b1037653db == 0)
				{
					num2 = 2;
				}
				break;
			default:
				if (organizationModel2.Id > 0)
				{
					num2 = 4;
					break;
				}
				goto case 3;
			case 1:
				organizationModel2 = (IOrganizationModel)Ekcmcumixt4B1PX8vN0(Manager);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6f96338790994363b52cd5c55eb1342f == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				organizationModel.Id = organizationModel2.Id;
				num2 = 3;
				break;
			case 2:
				return prZ7DZm6q6ark5VILO8(Manager, organizationModel2);
			}
		}
	}

	public virtual int Validate(OrganizationModelDTO organizationModel, out OrganizationModelPublishWarning warning)
	{
		//Discarded unreachable code: IL_008e, IL_009d
		int num = 3;
		IOrganizationModel organizationModel2 = default(IOrganizationModel);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
				case 5:
					Mapper.Map<OrganizationModelDTO, IOrganizationModel>(organizationModel, organizationModel2);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0ab7ce9a6369414380df24a533da8346 == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					organizationModel.Id = organizationModel2.Id;
					num2 = 5;
					continue;
				case 2:
					if (organizationModel2.Id <= 0)
					{
						num2 = 4;
						continue;
					}
					goto case 1;
				case 3:
					break;
				default:
					warning = null;
					num2 = 6;
					continue;
				case 6:
					return Manager.Validate(organizationModel2, out warning);
				}
				break;
			}
			organizationModel2 = (IOrganizationModel)Ekcmcumixt4B1PX8vN0(Manager);
			num = 2;
		}
	}

	public virtual ICollection<OrganizationVersionDTO> FindAllVersions()
	{
		return Manager.FindAllVersions();
	}

	public OrganizationDTOManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SRIVyFmljjas6R6qJMb();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_11e42501f5004eefaeaccdfe8bd3b619 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool uvfg9mmXR5D5hskrOq6()
	{
		return mhGo3OmWjxb4jRgwgqn == null;
	}

	internal static OrganizationDTOManager DGmoOXmnv0yLCdhRo68()
	{
		return mhGo3OmWjxb4jRgwgqn;
	}

	internal static object Ekcmcumixt4B1PX8vN0(object P_0)
	{
		return ((OrganizationModelManager)P_0).Load();
	}

	internal static object f4P2slm7XOWv8VmXKrT(object P_0)
	{
		return ((OrganizationModelManager)P_0).LoadPublishedOrNull();
	}

	internal static int prZ7DZm6q6ark5VILO8(object P_0, object P_1)
	{
		return ((OrganizationModelManager)P_0).Validate((IOrganizationModel)P_1);
	}

	internal static void SRIVyFmljjas6R6qJMb()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
