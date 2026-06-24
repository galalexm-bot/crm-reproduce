using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.DTO;
using EleWise.ELMA.Security.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.DTO.Models;

[Serializable]
public class OrganizationItemDTO : EntityDTO<long, IOrganizationItem>, IIdentity, IGenericIdentity<Guid>
{
	public const string UID_S = "e502f586-afd4-4f55-bedb-f71028ffd302";

	public const string IMPL_UID_S = "dfb7b232-140c-4aba-bff2-c5ccee293088";

	private static OrganizationItemDTO qIJyqmujoR64tGFqXCH;

	public static Guid MetadataUid => new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-724676315 ^ -724690387));

	public static Guid ImplMetadataUid => new Guid((string)JgtxL4uRqCL8mNeQYJa(0xA5DAE86 ^ 0xA5DE5D2));

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return _003CName_003Ek__BackingField;
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
					_003CName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e4840b3cf8a94577862fdc527af9db29 == 0)
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

	public long ParentItemId
	{
		[CompilerGenerated]
		get
		{
			return _003CParentItemId_003Ek__BackingField;
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
					_003CParentItemId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_86eb143f59c14824a2785845ea23f248 == 0)
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

	public OrganizationItemType ItemType
	{
		[CompilerGenerated]
		get
		{
			return _003CItemType_003Ek__BackingField;
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
					_003CItemType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0f3686d2211943308639c187009d1b4a == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public List<OrganizationItemDTO> Items { get; set; }

	public Guid Uid
	{
		[CompilerGenerated]
		get
		{
			return _003CUid_003Ek__BackingField;
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
					_003CUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3c78e0d08cb4410a900ca26e4b83108c != 0)
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

	Guid IGenericIdentity<Guid>.Id => Uid;

	public OrganizationItemDTO()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_651070b1c9bd4381bbb7379d68d6508e != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				Items = new List<OrganizationItemDTO>();
				num = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2c264a158ded4d26bea0177e79c88bc4 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static bool ys6KQSuHRLEaymcbMY1()
	{
		return qIJyqmujoR64tGFqXCH == null;
	}

	internal static OrganizationItemDTO mXZtYyuaLioSECB2GCn()
	{
		return qIJyqmujoR64tGFqXCH;
	}

	internal static object JgtxL4uRqCL8mNeQYJa(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
