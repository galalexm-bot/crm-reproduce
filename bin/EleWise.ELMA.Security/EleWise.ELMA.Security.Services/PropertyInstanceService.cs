using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Services;

[Service(Scope = ServiceScope.Application, Type = ComponentType.Server)]
internal class PropertyInstanceService : IPropertyInstanceService
{
	private static PropertyInstanceService oUmM13PJh0N8F3ope6O;

	public IEnumerable<IPropertyPermissionAdapter> Adapters { get; set; }

	public IEnumerable<IAbstractPropertyProfile> GetPropertyProfiles(IPropertyOwnerProfile owner)
	{
		return GetAdapterByOwner(owner).GetPropertyProfiles(owner);
	}

	public IPropertyMetadata GetPropertyMetadata(IAbstractPropertyProfile profile)
	{
		int num = 4;
		int num2 = num;
		_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = default(_003C_003Ec__DisplayClass5_0);
		ClassMetadata classMetadata = default(ClassMetadata);
		while (true)
		{
			switch (num2)
			{
			case 4:
				_003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d2fa92555e394879ba912e266541f735 != 0)
				{
					num2 = 1;
				}
				continue;
			case 3:
				_003C_003Ec__DisplayClass5_.profile = profile;
				num2 = 2;
				continue;
			case 1:
				return null;
			case 2:
				classMetadata = GetClassMetadata(_003C_003Ec__DisplayClass5_.profile);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39a415f51fd045a981443759203cc0ad == 0)
				{
					num2 = 0;
				}
				continue;
			}
			if (classMetadata == null)
			{
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a33ec05b36714591b0adf150b655c9a8 != 0)
				{
					num2 = 1;
				}
				continue;
			}
			return classMetadata.Properties.FirstOrDefault(_003C_003Ec__DisplayClass5_._003CGetPropertyMetadata_003Eb__0);
		}
	}

	public IEntityMetadata GetMetadata(IAbstractPropertyProfile profile)
	{
		return GetClassMetadata(profile) as IEntityMetadata;
	}

	public IEnumerable<IPropertyMetadata> GetPropertyMetadataList(IPropertyOwnerProfile owner)
	{
		return GetAdapterByOwner(owner).GetPropertyMetadataList(owner);
	}

	public IAbstractPropertyProfile CreateProfile(IPropertyOwnerProfile owner, Guid propertyUid)
	{
		return (IAbstractPropertyProfile)HF9RaFPh1AVXlcN3Z4r(GetAdapterByOwner(owner), owner, propertyUid);
	}

	public void SaveProfiles(IPropertyOwnerProfile owner, IEnumerable<IAbstractPropertyProfile> profiles)
	{
		GetAdapterByOwner(owner).SaveProfiles(owner, profiles);
	}

	public bool IsTitleProperty(IAbstractPropertyProfile profile)
	{
		//Discarded unreachable code: IL_007c, IL_008b, IL_009b
		int num = 2;
		int num2 = num;
		Guid guid = default(Guid);
		ClassMetadata classMetadata = default(ClassMetadata);
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (!guid.Equals(wT1LUfPq6W6wkNmpDNA(profile)))
				{
					num2 = 4;
					continue;
				}
				goto case 5;
			case 2:
				classMetadata = GetClassMetadata(profile);
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_308690af1b2f43b9a97bf91d774a6420 == 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
				if (classMetadata == null)
				{
					num2 = 6;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c78060c4cac8419092e4610bf7a03750 == 0)
					{
						num2 = 3;
					}
					continue;
				}
				break;
			case 5:
				return true;
			case 4:
			case 6:
				return false;
			}
			guid = xXtYIXPOsBRCbEeMEjC(classMetadata);
			num2 = 3;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b700f854946b45dfa4de8ce28732acad == 0)
			{
				num2 = 0;
			}
		}
	}

	public Guid GetTitlePropertyGuid(IPropertyOwnerProfile owner)
	{
		int num = 1;
		int num2 = num;
		ClassMetadata classMetadata = default(ClassMetadata);
		while (true)
		{
			switch (num2)
			{
			case 1:
				classMetadata = GetClassMetadata(owner);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d4e4542f38914a2ba9396d8df0939ca9 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return Guid.Empty;
			}
			if (classMetadata == null)
			{
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0b98d9f52b424149868b80d852714a70 != 0)
				{
					num2 = 2;
				}
				continue;
			}
			return xXtYIXPOsBRCbEeMEjC(classMetadata);
		}
	}

	public Guid GetHidePermissionId(IPropertyOwnerProfile owner)
	{
		return psaH3xPcTE5Bx9ASxJw(GetAdapterByOwner(owner));
	}

	public Guid GetViewPermissionId(IPropertyOwnerProfile owner)
	{
		return khxoxCPGUA07ZCy7k4e(GetAdapterByOwner(owner));
	}

	public Guid GetEditPermissionId(IPropertyOwnerProfile owner)
	{
		return VHwJ66PFfrbN5TOOlYI(GetAdapterByOwner(owner));
	}

	public ClassMetadata GetClassMetadata(IAbstractPropertyProfile profile)
	{
		//Discarded unreachable code: IL_007e, IL_008d, IL_00b3
		int num = 3;
		int num2 = num;
		IPropertyPermissionAdapter adapterByProfile = default(IPropertyPermissionAdapter);
		IMetadata metadata = default(IMetadata);
		object obj;
		while (true)
		{
			switch (num2)
			{
			case 3:
				adapterByProfile = GetAdapterByProfile(profile);
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4b1278f673174e87a9fb6665eab69fc6 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				if (adapterByProfile is IClassMetadataPropertyPermissionAdapter)
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2f11eccd7e8f4339a0b03ad9fe1eb947 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto default;
			default:
				metadata = (IMetadata)KLuxUdP0QDSOuYTcLsS(adapterByProfile, profile);
				num2 = 4;
				continue;
			case 4:
				obj = metadata;
				break;
			case 1:
				obj = prdcrWPElKBA6V4939R((IClassMetadataPropertyPermissionAdapter)adapterByProfile, profile);
				break;
			}
			break;
		}
		return obj as ClassMetadata;
	}

	public ClassMetadata GetClassMetadata(IPropertyOwnerProfile owner)
	{
		//Discarded unreachable code: IL_0033
		int num = 2;
		int num2 = num;
		object obj;
		IMetadata metadata = default(IMetadata);
		IPropertyPermissionAdapter adapterByOwner = default(IPropertyPermissionAdapter);
		while (true)
		{
			switch (num2)
			{
			default:
				obj = metadata;
				break;
			case 1:
				if (!(adapterByOwner is IClassMetadataPropertyPermissionAdapter))
				{
					num2 = 3;
					continue;
				}
				obj = sbdusAPDkrdTkEEaRVt((IClassMetadataPropertyPermissionAdapter)adapterByOwner, owner);
				break;
			case 2:
				adapterByOwner = GetAdapterByOwner(owner);
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8523ddc2b5094f2f87aec3d74da64bd2 != 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				metadata = adapterByOwner.GetMetadata(owner);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5adff34accb14bd183b62ef1a2f5f964 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			break;
		}
		return obj as ClassMetadata;
	}

	private IPropertyPermissionAdapter GetAdapterByOwner(IPropertyOwnerProfile owner)
	{
		int num = 3;
		_003C_003Ec__DisplayClass17_0 _003C_003Ec__DisplayClass17_ = default(_003C_003Ec__DisplayClass17_0);
		IPropertyPermissionAdapter propertyPermissionAdapter = default(IPropertyPermissionAdapter);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					_003C_003Ec__DisplayClass17_ = new _003C_003Ec__DisplayClass17_0();
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4ca2baab70e44d2ca8271afba4c9a72d == 0)
					{
						num2 = 2;
					}
					continue;
				case 6:
					Contract.ServiceNotNull(Adapters, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x78610A3D ^ 0x78616AF3));
					num2 = 5;
					continue;
				case 5:
					propertyPermissionAdapter = Adapters.FirstOrDefault(_003C_003Ec__DisplayClass17_._003CGetAdapterByOwner_003Eb__0);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c537c1b3b4be444086af51f6e9112d23 != 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					if (propertyPermissionAdapter == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b1df165db1394c8cbd9914e637f5e083 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					return propertyPermissionAdapter;
				default:
					throw new InvalidOperationException(SR.T((string)TStqYcPMu9djEnYe3Ba(-1278809262 ^ -1278833744), _003C_003Ec__DisplayClass17_.owner.GetType()));
				case 4:
					break;
				case 2:
					_003C_003Ec__DisplayClass17_.owner = owner;
					num2 = 4;
					continue;
				}
				break;
			}
			a0ENRHPs1uplBQDgWWb(_003C_003Ec__DisplayClass17_.owner, TStqYcPMu9djEnYe3Ba(-1378061210 ^ -1378085722));
			num = 6;
		}
	}

	private IPropertyPermissionAdapter GetAdapterByProfile(IAbstractPropertyProfile profile)
	{
		//Discarded unreachable code: IL_00cd
		int num = 1;
		_003C_003Ec__DisplayClass18_0 _003C_003Ec__DisplayClass18_ = default(_003C_003Ec__DisplayClass18_0);
		IPropertyPermissionAdapter propertyPermissionAdapter = default(IPropertyPermissionAdapter);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					QMidIxPYXIPsd52fPdh(Adapters, TStqYcPMu9djEnYe3Ba(0x3E79A885 ^ 0x3E79C84B));
					num2 = 6;
					break;
				default:
					_003C_003Ec__DisplayClass18_.profile = profile;
					num2 = 4;
					break;
				case 6:
					propertyPermissionAdapter = Adapters.FirstOrDefault(_003C_003Ec__DisplayClass18_._003CGetAdapterByProfile_003Eb__0);
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_443cb30a1c3f4e72a61ec4f52377fcc7 == 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					_003C_003Ec__DisplayClass18_ = new _003C_003Ec__DisplayClass18_0();
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_03ad39fc745d49e3be14e8e100fb0203 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					if (propertyPermissionAdapter != null)
					{
						goto end_IL_0012;
					}
					goto case 5;
				case 4:
					a0ENRHPs1uplBQDgWWb(_003C_003Ec__DisplayClass18_.profile, TStqYcPMu9djEnYe3Ba(-1278809262 ^ -1278834166));
					num2 = 3;
					break;
				case 5:
					throw new InvalidOperationException((string)XUOXA9PIVFauI7KT84S(TStqYcPMu9djEnYe3Ba(0xA5DAE86 ^ 0xA5DCFEC), new object[1] { _003C_003Ec__DisplayClass18_.profile.GetType() }));
				case 7:
					return propertyPermissionAdapter;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 7;
		}
	}

	public PropertyInstanceService()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		EBedqEP4x1tQo97h8R7();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_75955a8c33b24cdca4663f20d9ee3c3b == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool tjDHK9PK5il1GVfu2aG()
	{
		return oUmM13PJh0N8F3ope6O == null;
	}

	internal static PropertyInstanceService PtoqAJPtfiVVIwNQpux()
	{
		return oUmM13PJh0N8F3ope6O;
	}

	internal static object HF9RaFPh1AVXlcN3Z4r(object P_0, object P_1, Guid propertyUid)
	{
		return ((IPropertyPermissionAdapter)P_0).CreateProfile((IPropertyOwnerProfile)P_1, propertyUid);
	}

	internal static Guid xXtYIXPOsBRCbEeMEjC(object P_0)
	{
		return ((ClassMetadata)P_0).TitlePropertyUid;
	}

	internal static Guid wT1LUfPq6W6wkNmpDNA(object P_0)
	{
		return ((IAbstractPropertyProfile)P_0).PropertyGuid;
	}

	internal static Guid psaH3xPcTE5Bx9ASxJw(object P_0)
	{
		return ((IPropertyPermissionAdapter)P_0).GetHidePermissionId();
	}

	internal static Guid khxoxCPGUA07ZCy7k4e(object P_0)
	{
		return ((IPropertyPermissionAdapter)P_0).GetViewPermissionId();
	}

	internal static Guid VHwJ66PFfrbN5TOOlYI(object P_0)
	{
		return ((IPropertyPermissionAdapter)P_0).GetEditPermissionId();
	}

	internal static object KLuxUdP0QDSOuYTcLsS(object P_0, object P_1)
	{
		return ((IPropertyPermissionAdapter)P_0).GetMetadata((IAbstractPropertyProfile)P_1);
	}

	internal static object prdcrWPElKBA6V4939R(object P_0, object P_1)
	{
		return ((IClassMetadataPropertyPermissionAdapter)P_0).GetBaseMetadata((IAbstractPropertyProfile)P_1);
	}

	internal static object sbdusAPDkrdTkEEaRVt(object P_0, object P_1)
	{
		return ((IClassMetadataPropertyPermissionAdapter)P_0).GetBaseMetadata((IPropertyOwnerProfile)P_1);
	}

	internal static object TStqYcPMu9djEnYe3Ba(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void a0ENRHPs1uplBQDgWWb(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void QMidIxPYXIPsd52fPdh(object P_0, object P_1)
	{
		Contract.ServiceNotNull(P_0, (string)P_1);
	}

	internal static object XUOXA9PIVFauI7KT84S(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static void EBedqEP4x1tQo97h8R7()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
