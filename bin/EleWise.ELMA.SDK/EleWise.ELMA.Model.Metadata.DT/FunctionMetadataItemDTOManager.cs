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

internal class FunctionMetadataItemDTOManager : DTOManager, IFunctionMetadataItemDTOManager, IConfigurationService
{
	private static FunctionMetadataItemDTOManager Xsl6UfbgNCvpoH19YEsJ;

	public IFunctionMetadataItemManager FunctionMetadataItemManager
	{
		[CompilerGenerated]
		get
		{
			return _003CFunctionMetadataItemManager_003Ek__BackingField;
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
					_003CFunctionMetadataItemManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual FunctionMetadataItemDTO Load(long id)
	{
		return Mapper.Map<FunctionMetadataItem, FunctionMetadataItemDTO>(FunctionMetadataItemManager.Load(id), new FunctionMetadataItemDTO());
	}

	public virtual FunctionMetadataItemDTO LoadOrNull(long id)
	{
		return Mapper.Map<FunctionMetadataItem, FunctionMetadataItemDTO>(FunctionMetadataItemManager.LoadOrNull(id), new FunctionMetadataItemDTO());
	}

	public virtual FunctionMetadataItemDTO LoadOrNull(Guid uid)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = default(_003C_003Ec__DisplayClass10_0);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				_003C_003Ec__DisplayClass10_._003C_003E4__this = this;
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				_003C_003Ec__DisplayClass10_.uid = uid;
				num2 = 3;
				break;
			case 2:
				return _003C_003Ec__DisplayClass10_.result;
			case 4:
				Dk45L3bgaWRybDh6IdSO(SecurityService, new Action(_003C_003Ec__DisplayClass10_._003CLoadOrNull_003Eb__0));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				_003C_003Ec__DisplayClass10_.result = null;
				num2 = 4;
				break;
			}
		}
	}

	public FunctionMetadataItemDTOManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		s6yvQbbgDEToAgb7mbBg();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool nOw3Pabg3U3hpD3pT089()
	{
		return Xsl6UfbgNCvpoH19YEsJ == null;
	}

	internal static FunctionMetadataItemDTOManager v3xuSLbgpBRqqd8itLp1()
	{
		return Xsl6UfbgNCvpoH19YEsJ;
	}

	internal static void Dk45L3bgaWRybDh6IdSO(object P_0, object P_1)
	{
		((ISecurityService)P_0).RunWithElevatedPrivilegies((Action)P_1);
	}

	internal static void s6yvQbbgDEToAgb7mbBg()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
