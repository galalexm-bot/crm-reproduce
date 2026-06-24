using System;
using System.Runtime.CompilerServices;
using AutoMapper;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata.DTO.Models;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Security;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata.DTO.Managers;

internal class DataClassMetadataItemDTOManager : DTOManager, IDataClassMetadataItemDTOManager, IConfigurationService
{
	internal static DataClassMetadataItemDTOManager G5Ek3FbgKWlPS6uLyq6S;

	public IDataClassMetadataItemManager DataClassMetadataItemManager
	{
		[CompilerGenerated]
		get
		{
			return _003CDataClassMetadataItemManager_003Ek__BackingField;
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
					_003CDataClassMetadataItemManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
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
				case 1:
					_003CSecurityService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
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

	public virtual DataClassMetadataItemDTO Load(long id)
	{
		return Mapper.Map<DataClassMetadataItem, DataClassMetadataItemDTO>(DataClassMetadataItemManager.Load(id), new DataClassMetadataItemDTO());
	}

	public virtual DataClassMetadataItemDTO LoadOrNull(long id)
	{
		return Mapper.Map<DataClassMetadataItem, DataClassMetadataItemDTO>(DataClassMetadataItemManager.LoadOrNull(id), new DataClassMetadataItemDTO());
	}

	public virtual DataClassMetadataItemDTO LoadOrNull(Guid uid)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = default(_003C_003Ec__DisplayClass10_0);
		while (true)
		{
			switch (num2)
			{
			case 2:
				_003C_003Ec__DisplayClass10_.result = null;
				num2 = 5;
				break;
			case 4:
				return _003C_003Ec__DisplayClass10_.result;
			case 5:
				DjVycNbgk7On5DOaxm1Q(SecurityService, new Action(_003C_003Ec__DisplayClass10_._003CLoadOrNull_003Eb__0));
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				_003C_003Ec__DisplayClass10_._003C_003E4__this = this;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
				{
					num2 = 3;
				}
				break;
			case 3:
				_003C_003Ec__DisplayClass10_.uid = uid;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public DataClassMetadataItemDTOManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		sDaS4FbgnuC1gYrlZ1Y9();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool ICoHQfbgXjQaIhauSAjq()
	{
		return G5Ek3FbgKWlPS6uLyq6S == null;
	}

	internal static DataClassMetadataItemDTOManager ejigTabgTlHtru3jsAPi()
	{
		return G5Ek3FbgKWlPS6uLyq6S;
	}

	internal static void DjVycNbgk7On5DOaxm1Q(object P_0, object P_1)
	{
		((ISecurityService)P_0).RunWithElevatedPrivilegies((Action)P_1);
	}

	internal static void sDaS4FbgnuC1gYrlZ1Y9()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
