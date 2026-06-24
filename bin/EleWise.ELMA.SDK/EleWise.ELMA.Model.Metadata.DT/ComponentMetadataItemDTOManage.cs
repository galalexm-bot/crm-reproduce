using System;
using System.Runtime.CompilerServices;
using AutoMapper;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata.DTO.Models;
using EleWise.ELMA.Security;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata.DTO.Managers;

internal class ComponentMetadataItemDTOManager : DTOManager, IComponentMetadataItemDTOManager, IConfigurationService
{
	private static ComponentMetadataItemDTOManager TYRDHkbgOoM2vn5qvVZI;

	public IComponentMetadataItemManager ComponentMetadataItemManager
	{
		[CompilerGenerated]
		get
		{
			return _003CComponentMetadataItemManager_003Ek__BackingField;
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
					_003CComponentMetadataItemManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ISecurityService SecurityService
	{
		[CompilerGenerated]
		get
		{
			return _003CSecurityService_003Ek__BackingField;
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
					_003CSecurityService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual ComponentMetadataItemDTO Load(long id)
	{
		return Mapper.Map<ComponentMetadataItem, ComponentMetadataItemDTO>(ComponentMetadataItemManager.Load(id), new ComponentMetadataItemDTO());
	}

	public virtual ComponentMetadataItemDTO LoadOrNull(long id)
	{
		return Mapper.Map<ComponentMetadataItem, ComponentMetadataItemDTO>(ComponentMetadataItemManager.LoadOrNull(id), new ComponentMetadataItemDTO());
	}

	public virtual ComponentMetadataItemDTO LoadOrNull(Guid uid)
	{
		int num = 4;
		int num2 = num;
		_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = default(_003C_003Ec__DisplayClass10_0);
		while (true)
		{
			switch (num2)
			{
			case 1:
				GU9COUbgPoC3mvZDP3YX(SecurityService, new Action(_003C_003Ec__DisplayClass10_._003CLoadOrNull_003Eb__0));
				num2 = 2;
				break;
			case 2:
				return _003C_003Ec__DisplayClass10_.result;
			case 4:
				_003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
				num2 = 3;
				break;
			case 3:
				_003C_003Ec__DisplayClass10_._003C_003E4__this = this;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
				{
					num2 = 5;
				}
				break;
			case 5:
				_003C_003Ec__DisplayClass10_.uid = uid;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
				{
					num2 = 0;
				}
				break;
			default:
				_003C_003Ec__DisplayClass10_.result = null;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public ComponentMetadataItemDTOManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		nxNfnQbg1BRURSIHx8Gs();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool DgFGORbg21pgFSeKvwVn()
	{
		return TYRDHkbgOoM2vn5qvVZI == null;
	}

	internal static ComponentMetadataItemDTOManager HcoXtqbge6JuxvJxX3Ut()
	{
		return TYRDHkbgOoM2vn5qvVZI;
	}

	internal static void GU9COUbgPoC3mvZDP3YX(object P_0, object P_1)
	{
		((ISecurityService)P_0).RunWithElevatedPrivilegies((Action)P_1);
	}

	internal static void nxNfnQbg1BRURSIHx8Gs()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
