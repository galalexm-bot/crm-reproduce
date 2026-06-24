using System;
using System.Linq;
using System.Runtime.CompilerServices;
using AutoMapper;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Scripts.DTO.Models;
using EleWise.ELMA.Model.Scripts.Manager;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Scripts.DTO.Manager;

public class ExternalAssemblyDtoManager : DTOManager, IExternalAssemblyDtoManager, IConfigurationService
{
	internal static ExternalAssemblyDtoManager iDH2mObKPM3uBuvQrfRy;

	public ExternalAssemblyManager ExternalAssemblyManager
	{
		[CompilerGenerated]
		get
		{
			return _003CExternalAssemblyManager_003Ek__BackingField;
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
					_003CExternalAssemblyManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual ExternalAssemblyDto LoadOrNull(Guid uid)
	{
		return Mapper.Map<IExternalAssembly, ExternalAssemblyDto>(ExternalAssemblyManager.LoadOrNull(uid), new ExternalAssemblyDto());
	}

	public virtual ExternalAssemblyDto Load(string hashCode)
	{
		int num = 1;
		int num2 = num;
		IExternalAssemblyFilter externalAssemblyFilter = default(IExternalAssemblyFilter);
		while (true)
		{
			switch (num2)
			{
			case 1:
				externalAssemblyFilter = InterfaceActivator.Create<IExternalAssemblyFilter>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return Mapper.Map<IExternalAssembly, ExternalAssemblyDto>(ExternalAssemblyManager.Find(externalAssemblyFilter, null).FirstOrDefault(), new ExternalAssemblyDto());
			default:
				HrRYV6bK36Ttwum2AuiF(externalAssemblyFilter, hashCode);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public virtual string GetHashCode(Guid uid)
	{
		//Discarded unreachable code: IL_0042, IL_0051
		int num = 2;
		int num2 = num;
		ExternalAssemblyDto externalAssemblyDto = default(ExternalAssemblyDto);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (externalAssemblyDto == null)
				{
					num2 = 3;
					break;
				}
				goto default;
			case 2:
				externalAssemblyDto = (ExternalAssemblyDto)tW8JhpbKpUC8nq1VKU4K(this, uid);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				return (string)ad3RbfbKaO9oCJgXMDXy(externalAssemblyDto);
			case 3:
				return null;
			}
		}
	}

	public virtual Guid? Exist(string hashCode)
	{
		return Load(hashCode)?.Uid;
	}

	public virtual void Save(ExternalAssemblyDto externalAssembly)
	{
		int num = 1;
		int num2 = num;
		IExternalAssembly obj = default(IExternalAssembly);
		while (true)
		{
			switch (num2)
			{
			case 1:
				obj = Mapper.Map<ExternalAssemblyDto, IExternalAssembly>(externalAssembly);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				ExternalAssemblyManager.Save(obj);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public ExternalAssemblyDtoManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		jHHwEabKDZNMAKOY2Tkm();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool o6MF6DbK1Ckg2QiNlxyV()
	{
		return iDH2mObKPM3uBuvQrfRy == null;
	}

	internal static ExternalAssemblyDtoManager HVxlnPbKNWTMPIHuJsxc()
	{
		return iDH2mObKPM3uBuvQrfRy;
	}

	internal static void HrRYV6bK36Ttwum2AuiF(object P_0, object P_1)
	{
		((IExternalAssemblyFilter)P_0).HashCode = (string)P_1;
	}

	internal static object tW8JhpbKpUC8nq1VKU4K(object P_0, Guid uid)
	{
		return ((ExternalAssemblyDtoManager)P_0).LoadOrNull(uid);
	}

	internal static object ad3RbfbKaO9oCJgXMDXy(object P_0)
	{
		return ((ExternalAssemblyDto)P_0).HashCode;
	}

	internal static void jHHwEabKDZNMAKOY2Tkm()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
