using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using AutoMapper;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata.DTO.Models;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata.DTO.Managers;

internal class FunctionMetadataItemHeaderDTOManager : DTOManager, IFunctionMetadataItemHeaderDTOManager, IConfigurationService
{
	private static FunctionMetadataItemHeaderDTOManager ztNt2rb5BZsnc9Uy1H9W;

	public IFunctionMetadataItemHeaderManager FunctionMetadataItemHeaderManager
	{
		[CompilerGenerated]
		get
		{
			return _003CFunctionMetadataItemHeaderManager_003Ek__BackingField;
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
					_003CFunctionMetadataItemHeaderManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
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
				case 0:
					return;
				case 1:
					_003CSecurityService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual FunctionMetadataItemHeaderDTO Load(long id)
	{
		return Mapper.Map<FunctionMetadataItemHeader, FunctionMetadataItemHeaderDTO>(FunctionMetadataItemHeaderManager.Load(id), new FunctionMetadataItemHeaderDTO());
	}

	public virtual FunctionMetadataItemHeaderDTO LoadOrNull(long id)
	{
		return Mapper.Map<FunctionMetadataItemHeader, FunctionMetadataItemHeaderDTO>(FunctionMetadataItemHeaderManager.LoadOrNull(id), new FunctionMetadataItemHeaderDTO());
	}

	public virtual FunctionMetadataItemHeaderDTO LoadOrNull(Guid uid)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = default(_003C_003Ec__DisplayClass10_0);
		while (true)
		{
			switch (num2)
			{
			default:
				_003C_003Ec__DisplayClass10_.uid = uid;
				num2 = 3;
				break;
			case 2:
				_003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				Locator.GetService<ISecurityService>();
				num2 = 6;
				break;
			case 1:
				_003C_003Ec__DisplayClass10_._003C_003E4__this = this;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				return _003C_003Ec__DisplayClass10_.result;
			case 6:
				bKi9wRb5b2pHBYSpCQvR(SecurityService, new Action(_003C_003Ec__DisplayClass10_._003CLoadOrNull_003Eb__0));
				num2 = 5;
				break;
			case 3:
				_003C_003Ec__DisplayClass10_.result = null;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public virtual IEnumerable<FunctionMetadataItemHeaderDTO> FindAll()
	{
		_003C_003Ec__DisplayClass11_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass11_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.result = new List<FunctionMetadataItemHeaderDTO>();
		SecurityService.RunWithElevatedPrivilegies(delegate
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
					CS_0024_003C_003E8__locals0.result.AddRange((from h in CS_0024_003C_003E8__locals0._003C_003E4__this.FunctionMetadataItemHeaderManager.FindAll()
						select Mapper.Map<FunctionMetadataItemHeader, FunctionMetadataItemHeaderDTO>(h, new FunctionMetadataItemHeaderDTO())).ToList());
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		});
		return CS_0024_003C_003E8__locals0.result;
	}

	public FunctionMetadataItemHeaderDTOManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		DfiPM7b5hgU00E2dLPlH();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool RQZ9fGb5W1S2xZZEWlGq()
	{
		return ztNt2rb5BZsnc9Uy1H9W == null;
	}

	internal static FunctionMetadataItemHeaderDTOManager WTJc6ub5oLXJV47eYEN8()
	{
		return ztNt2rb5BZsnc9Uy1H9W;
	}

	internal static void bKi9wRb5b2pHBYSpCQvR(object P_0, object P_1)
	{
		((ISecurityService)P_0).RunWithElevatedPrivilegies((Action)P_1);
	}

	internal static void DfiPM7b5hgU00E2dLPlH()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
