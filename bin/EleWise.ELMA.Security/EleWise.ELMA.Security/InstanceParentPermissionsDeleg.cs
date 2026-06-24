using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Cache;
using EleWise.ELMA.Cache.Attributes;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security;

[Component]
internal class InstanceParentPermissionsDelegate : IPermissionsDelegate
{
	private readonly IMemoryCacheService memoryCacheService;

	private readonly Dictionary<Type, Permission[]> permissonsCache;

	private static InstanceParentPermissionsDelegate E1RtRu5Yjvk1I16gbA0;

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
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d689f5970f6345a7af332e1f7092123f == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public InstanceParentPermissionsDelegate(IMemoryCacheService memoryCacheService, IEnumerable<IPermissionProvider> permissionProviders)
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		this.memoryCacheService = memoryCacheService;
		permissonsCache = (from p in permissionProviders.SelectMany((IPermissionProvider p) => p.GetPermissions())
			where p.ParentResolve != null
			group p by p.EntityType).ToDictionary((IGrouping<Type, Permission> g) => g.Key, (IGrouping<Type, Permission> g) => g.ToArray());
	}

	[ContextCache]
	protected virtual Permission GetPermissions(Type type, Guid permissionId)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_ = default(_003C_003Ec__DisplayClass7_0);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3c78e0d08cb4410a900ca26e4b83108c != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				_003C_003Ec__DisplayClass7_.permissionId = permissionId;
				num2 = 3;
				break;
			case 2:
				_003C_003Ec__DisplayClass7_._003C_003E4__this = this;
				num2 = 4;
				break;
			default:
				_003C_003Ec__DisplayClass7_.type = type;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_61a610c13d6d47c8947a4d2d4016147a == 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				return memoryCacheService.GetOrAdd((string)TdZtG15VmPda5Q4y7UX(0x397B0322 ^ 0x397B171C) + _003C_003Ec__DisplayClass7_.type.FullName, _003C_003Ec__DisplayClass7_._003CGetPermissions_003Eb__0);
			}
		}
	}

	[ContextCache]
	public virtual bool CanCheckPermissions(Type type, Permission permission)
	{
		//Discarded unreachable code: IL_00ea, IL_00f9
		int num = 5;
		int num2 = num;
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = default(_003C_003Ec__DisplayClass8_0);
		while (true)
		{
			switch (num2)
			{
			case 4:
				_003C_003Ec__DisplayClass8_._003C_003E4__this = this;
				num2 = 7;
				break;
			case 2:
				return memoryCacheService.GetOrAdd((string)jr8vNj5Tg7057fNXHDP(new object[4]
				{
					TdZtG15VmPda5Q4y7UX(-2104667969 ^ -2104671103),
					_003C_003Ec__DisplayClass8_.permission.Id,
					TdZtG15VmPda5Q4y7UX(0x6AA79E0 ^ 0x6AA6DD8),
					_003C_003Ec__DisplayClass8_.type.FullName
				}), _003C_003Ec__DisplayClass8_._003CCanCheckPermissions_003Eb__0);
			case 6:
				return false;
			case 3:
				_003C_003Ec__DisplayClass8_.permission = permission;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b700f854946b45dfa4de8ce28732acad == 0)
				{
					num2 = 0;
				}
				break;
			case 7:
				_003C_003Ec__DisplayClass8_.type = type;
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a53a06d0e4134332947f6164df41fb0f != 0)
				{
					num2 = 1;
				}
				break;
			default:
				if (!p6hnYa5QpAAdlsWVVWu(_003C_003Ec__DisplayClass8_.type, null))
				{
					num2 = 6;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fb7ef78ec97a4842bca66699308784ed == 0)
					{
						num2 = 6;
					}
					break;
				}
				goto case 1;
			case 1:
				if (oM5rrP5dTrnCXbbUXD7(_003C_003Ec__DisplayClass8_.permission, null))
				{
					num2 = 2;
					break;
				}
				goto case 6;
			case 5:
				_003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4aad3b757e09491eb106d72b1e7740cc != 0)
				{
					num2 = 4;
				}
				break;
			}
		}
	}

	public bool HasPermission(IUser user, Permission permission, object target, bool skipAdmin = false)
	{
		//Discarded unreachable code: IL_0095, IL_00a4, IL_00e7, IL_00f6
		int num = 1;
		int num2 = num;
		object obj = default(object);
		_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = default(_003C_003Ec__DisplayClass9_0);
		while (true)
		{
			switch (num2)
			{
			case 5:
				return ((IEnumerable)obj).Cast<object>().Any(_003C_003Ec__DisplayClass9_._003CHasPermission_003Eb__1);
			case 7:
			case 10:
				return false;
			case 12:
				_003C_003Ec__DisplayClass9_.user = user;
				num2 = 9;
				break;
			case 1:
				_003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a5d922da527e46afbe4b139adb51cde5 == 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				if (obj is IEnumerable)
				{
					num2 = 8;
					break;
				}
				goto case 11;
			case 11:
				return prl8cd5yZUY83HcFwXg(SecurityService, _003C_003Ec__DisplayClass9_.user, miWCa053CwQU2Yf70cU(_003C_003Ec__DisplayClass9_.checkPermission), obj, false);
			case 8:
				if (KGSYQU5bbYS2cV2ZCep(_003C_003Ec__DisplayClass9_.checkPermission))
				{
					return ((IEnumerable)obj).Cast<object>().All(_003C_003Ec__DisplayClass9_._003CHasPermission_003Eb__0);
				}
				num2 = 5;
				break;
			case 4:
				if (!oM5rrP5dTrnCXbbUXD7(_003C_003Ec__DisplayClass9_.checkPermission, null))
				{
					num2 = 7;
					break;
				}
				goto case 2;
			case 3:
				if ((obj = _003C_003Ec__DisplayClass9_.checkPermission.ParentResolve(target)) != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4ca2baab70e44d2ca8271afba4c9a72d == 0)
					{
						num2 = 6;
					}
					break;
				}
				goto case 7;
			case 2:
				if (!((Permission)miWCa053CwQU2Yf70cU(_003C_003Ec__DisplayClass9_.checkPermission) != null))
				{
					num2 = 10;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_147eeadb328044dda63bf8b1037653db != 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 3;
			default:
				_003C_003Ec__DisplayClass9_._003C_003E4__this = this;
				num2 = 12;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1bc92e0376794fc182b6e366eee82dbd == 0)
				{
					num2 = 11;
				}
				break;
			case 9:
				_003C_003Ec__DisplayClass9_.checkPermission = (Permission)xIlprW5r3moIkFludhI(this, (target as Type) ?? YNBaAx5g5PF1fWTAWGU(target), fZdZCe58UCI5rwm5SSh(permission));
				num2 = 4;
				break;
			}
		}
	}

	internal static bool imieDj5IB1Yv9jbFO7e()
	{
		return E1RtRu5Yjvk1I16gbA0 == null;
	}

	internal static InstanceParentPermissionsDelegate gABxtw54X0SqYEQ894U()
	{
		return E1RtRu5Yjvk1I16gbA0;
	}

	internal static object TdZtG15VmPda5Q4y7UX(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool p6hnYa5QpAAdlsWVVWu(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static bool oM5rrP5dTrnCXbbUXD7(object P_0, object P_1)
	{
		return (Permission)P_0 != (Permission)P_1;
	}

	internal static object jr8vNj5Tg7057fNXHDP(object P_0)
	{
		return string.Concat((object[])P_0);
	}

	internal static Type YNBaAx5g5PF1fWTAWGU(object P_0)
	{
		return EntityHelper.GetType(P_0);
	}

	internal static Guid fZdZCe58UCI5rwm5SSh(object P_0)
	{
		return ((Permission)P_0).Id;
	}

	internal static object xIlprW5r3moIkFludhI(object P_0, Type type, Guid permissionId)
	{
		return ((InstanceParentPermissionsDelegate)P_0).GetPermissions(type, permissionId);
	}

	internal static object miWCa053CwQU2Yf70cU(object P_0)
	{
		return ((Permission)P_0).ParentPermission;
	}

	internal static bool prl8cd5yZUY83HcFwXg(object P_0, object P_1, object P_2, object P_3, bool P_4)
	{
		return ((ISecurityService)P_0).HasPermission((IUser)P_1, (Permission)P_2, P_3, P_4);
	}

	internal static bool KGSYQU5bbYS2cV2ZCep(object P_0)
	{
		return ((Permission)P_0).ParentAllTargets;
	}
}
