using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Models;

internal class PropertyAccessCacheItem
{
	internal static PropertyAccessCacheItem xLfMRnKTR96FBMV1OWV;

	public Type ModelType
	{
		[CompilerGenerated]
		get
		{
			return _003CModelType_003Ek__BackingField;
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
					_003CModelType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_73b92e1f752f422d899693d4318e4486 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Guid PropertyGuid
	{
		[CompilerGenerated]
		get
		{
			return _003CPropertyGuid_003Ek__BackingField;
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
					_003CPropertyGuid_003Ek__BackingField = value;
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

	public PropertyPermissionType PermissionType
	{
		[CompilerGenerated]
		get
		{
			return _003CPermissionType_003Ek__BackingField;
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
					_003CPermissionType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_147eeadb328044dda63bf8b1037653db == 0)
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

	public long? UserId { get; set; }

	public long? GroupId { get; set; }

	public long? OrganizationItemPositionId { get; set; }

	public long? OrganizationItemId { get; set; }

	public Guid? AssignedPropertyUid { get; set; }

	public Guid? AssignedPropertyEntityUid { get; set; }

	public PropertyAccessCacheItem(IAbstractPropertyAccess access)
	{
		//Discarded unreachable code: IL_001a
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		int num = 4;
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			case 7:
				PermissionType = h2y92iKyGKDlkMcUvEL(access);
				num = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1c9893e65c104705bb8b228f8a38d9cd != 0)
				{
					num = 5;
				}
				break;
			case 8:
				AssignedPropertyUid = access.AssignedPropertyUid;
				num = 6;
				break;
			case 4:
				jPPUYyK3lebcy11F2YH(access, acExPRKrypSbRQO1Y4Y(-1365352774 ^ -1365367326));
				num = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_11e42501f5004eefaeaccdfe8bd3b619 == 0)
				{
					num = 0;
				}
				break;
			default:
				PropertyGuid = access.GetPropertyGuid();
				num = 7;
				break;
			case 6:
				AssignedPropertyEntityUid = access.AssignedPropertyEntityUid;
				num = 2;
				break;
			case 5:
				UserId = ((access.User != null) ? new long?(access.User.Id) : null);
				num = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3fde536d235f4cd390062db7c7cf1219 == 0)
				{
					num = 1;
				}
				break;
			case 1:
				GroupId = ((HReSwrKbA6mSiWLWIX4(access) != null) ? new long?(access.Group.Id) : null);
				num = 3;
				break;
			case 3:
				OrganizationItemPositionId = ((IKFnEoKSP2XQr4eLTQs(access) != null) ? new long?(((IEntity<long>)IKFnEoKSP2XQr4eLTQs(access)).Id) : null);
				num = 9;
				break;
			case 9:
			{
				OrganizationItemId = ((XsfKKkK9LkgDUMTKqlw(access) != null) ? new long?(access.OrganizationItem.Id) : null);
				int num2 = 8;
				num = num2;
				break;
			}
			}
		}
	}

	internal static object acExPRKrypSbRQO1Y4Y(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void jPPUYyK3lebcy11F2YH(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static PropertyPermissionType h2y92iKyGKDlkMcUvEL(object P_0)
	{
		return ((IAbstractPropertyAccess)P_0).GetPermissionType();
	}

	internal static object HReSwrKbA6mSiWLWIX4(object P_0)
	{
		return ((IAbstractPropertyAccess)P_0).Group;
	}

	internal static object IKFnEoKSP2XQr4eLTQs(object P_0)
	{
		return ((IAbstractPropertyAccess)P_0).OrganizationItemPosition;
	}

	internal static object XsfKKkK9LkgDUMTKqlw(object P_0)
	{
		return ((IAbstractPropertyAccess)P_0).OrganizationItem;
	}

	internal static bool nnxaD5KgD9rVDissH8r()
	{
		return xLfMRnKTR96FBMV1OWV == null;
	}

	internal static PropertyAccessCacheItem VqwHG7K8mBpqjVE4cwJ()
	{
		return xLfMRnKTR96FBMV1OWV;
	}
}
