using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.Deploy.Export;

[Serializable]
public class SecurityExportSetting
{
	private static SecurityExportSetting CyV3GG3O7i6LqQG7vjU;

	public bool ExportOrgModel
	{
		[CompilerGenerated]
		get
		{
			return _003CExportOrgModel_003Ek__BackingField;
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
					_003CExportOrgModel_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e4840b3cf8a94577862fdc527af9db29 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool ExportUserGroups
	{
		[CompilerGenerated]
		get
		{
			return _003CExportUserGroups_003Ek__BackingField;
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
					_003CExportUserGroups_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8176869ecaf44a0b8819db51e9ec5eb4 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Obsolete("Используй UserGroupsUids")]
	public List<long> UserGroupsIds { get; set; }

	public List<Guid> UserGroupsUids { get; set; }

	public SecurityExportSetting()
	{
		//Discarded unreachable code: IL_001a, IL_001f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 3:
				ExportOrgModel = false;
				num = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_308690af1b2f43b9a97bf91d774a6420 == 0)
				{
					num = 1;
				}
				break;
			case 4:
				UserGroupsUids = new List<Guid>();
				num = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6b49024d17a94a69b2948ac938d43b7c == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			case 2:
				ExportUserGroups = true;
				num = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6370a8f224e7416eb3575ae34b77f5e3 == 0)
				{
					num = 1;
				}
				break;
			case 1:
				UserGroupsIds = new List<long>();
				num = 4;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c08b0b4e9ab14bedb2a2c7a0048ab814 != 0)
				{
					num = 4;
				}
				break;
			}
		}
	}

	internal static bool ka5rx83qoISkPbMNZ1A()
	{
		return CyV3GG3O7i6LqQG7vjU == null;
	}

	internal static SecurityExportSetting vEymLo3caZNJEgvc4jM()
	{
		return CyV3GG3O7i6LqQG7vjU;
	}
}
