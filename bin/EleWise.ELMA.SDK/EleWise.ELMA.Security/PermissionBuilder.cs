using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security;

public class PermissionBuilder
{
	private readonly Permission permission;

	private static PermissionBuilder HNtjJqBYOpv1NPOMhcDo;

	internal PermissionBuilder(Guid id, Func<string> name, string description, string category)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		permission = new Permission(id, name, description, category);
	}

	public static implicit operator Permission(PermissionBuilder builder)
	{
		return (Permission)vAVw7QBYPoIWvR5RFp0v(builder);
	}

	public Permission Build()
	{
		return permission;
	}

	public PermissionBuilder Dependencies(params Permission[] dependencies)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return this;
			case 1:
				C5CGCMBY1UW7VhJGf5Uh(permission, dependencies ?? new Permission[0]);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public PermissionBuilder ModuleUid(string moduleUid)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				UxiWb5BYN8qn0gRSNy8m(permission, moduleUid);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return this;
			}
		}
	}

	public PermissionBuilder GlobalPermission()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return this;
			case 1:
				permission.PermissionType = PermissionType.Global;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public PermissionBuilder EntityType(Type entityType)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				F14iVMBY3OcmQM7PYGJ1(permission, entityType);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return this;
			}
		}
	}

	public PermissionBuilder EntityType<T>()
	{
		return EntityType(InterfaceActivator.TypeOf<T>());
	}

	public PermissionBuilder Base(Permission @base)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return this;
			case 1:
				sUHyGQBYpAAlLw5stoYP(permission, @base);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public PermissionBuilder EntityTypePermission(Type entityType)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				Bx33ZuBYaIegtNpn7HeP(permission, PermissionType.EntityType);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return EntityType(entityType);
			}
		}
	}

	public PermissionBuilder EntityTypePermission<T>()
	{
		return EntityTypePermission(InterfaceActivator.TypeOf<T>());
	}

	public PermissionBuilder EntityTypePermission(Type entityType, Permission @base)
	{
		return (PermissionBuilder)QoACWZBYDS1OuSZ5CJXr(EntityTypePermission(entityType), @base);
	}

	public PermissionBuilder EntityTypePermission<T>(Permission @base)
	{
		return EntityTypePermission(InterfaceActivator.TypeOf<T>(), @base);
	}

	public PermissionBuilder InstancePermission(Type entityType)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return EntityType(entityType);
			case 1:
				permission.PermissionType = PermissionType.Instance;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public PermissionBuilder InstancePermission<T>()
	{
		return InstancePermission(InterfaceActivator.TypeOf<T>());
	}

	public PermissionBuilder InstancePermission(Type entityType, Permission @base)
	{
		return (PermissionBuilder)QoACWZBYDS1OuSZ5CJXr(InstancePermission(entityType), @base);
	}

	public PermissionBuilder InstancePermission<T>(Permission @base)
	{
		return InstancePermission(InterfaceActivator.TypeOf<T>(), @base);
	}

	public PermissionBuilder InstanceSettingsPermission(Type entityType)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				permission.IsInstanceSettingsPermission = true;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return InstancePermission(entityType);
			}
		}
	}

	public PermissionBuilder InstanceSettingsPermission<T>()
	{
		return InstanceSettingsPermission(InterfaceActivator.TypeOf<T>());
	}

	public PermissionBuilder InstanceSettingsPermission(Type entityType, Permission @base)
	{
		return InstanceSettingsPermission(entityType).Base(@base);
	}

	public PermissionBuilder InstanceSettingsPermission<T>(Permission @base)
	{
		return InstanceSettingsPermission(InterfaceActivator.TypeOf<T>(), @base);
	}

	public PermissionBuilder ShowInGlobalSettings(bool showInGlobalSettings = true)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return this;
			case 1:
				R6B6VKBYt6FIDSBScjJ8(permission, showInGlobalSettings);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public PermissionBuilder ReadOnly(bool readOnly = true)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return this;
			case 1:
				MgeAqkBYwN5YkVpMgr36(permission, readOnly);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public PermissionBuilder AdminPermissions(params Permission[] adminPermissions)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return this;
			case 1:
				permission.AdminPermissions = adminPermissions ?? new Permission[0];
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public PermissionBuilder CheckModuleAccess(bool checkAccess)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return this;
			case 1:
				CsjhSlBY4Z6BqCaiuk77(permission, checkAccess);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public PermissionBuilder InstanceParentPermission<T>(Func<T, object> parentResolve, Permission parentPermission)
	{
		_003C_003Ec__DisplayClass26_0<T> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass26_0<T>();
		CS_0024_003C_003E8__locals0.parentResolve = parentResolve;
		permission.ParentPermission = parentPermission;
		permission.ParentResolve = delegate(object target)
		{
			//Discarded unreachable code: IL_002d, IL_003c
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return null;
				default:
					return CS_0024_003C_003E8__locals0.parentResolve((T)target);
				case 1:
					if (target is T)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				}
			}
		};
		return InstancePermission<T>();
	}

	public PermissionBuilder InstanceParentPermissionAll<T>(Func<T, IEnumerable<object>> parentResolve, Permission parentPermission)
	{
		permission.ParentAllTargets = true;
		return InstanceParentPermission(parentResolve, parentPermission);
	}

	public PermissionBuilder InstanceParentPermissionAny<T>(Func<T, IEnumerable<object>> parentResolve, Permission parentPermission)
	{
		permission.ParentAllTargets = false;
		return InstanceParentPermission(parentResolve, parentPermission);
	}

	public PermissionBuilder InstanceParentPermission<T>(Func<T, object> parentResolve, Permission parentPermission, Permission @base)
	{
		return InstanceParentPermission(parentResolve, parentPermission).Base(@base);
	}

	public PermissionBuilder InstanceParentPermissionAll<T>(Func<T, IEnumerable<object>> parentResolve, Permission parentPermission, Permission @base)
	{
		return InstanceParentPermissionAll(parentResolve, parentPermission).Base(@base);
	}

	public PermissionBuilder InstanceParentPermissionAny<T>(Func<T, IEnumerable<object>> parentResolve, Permission parentPermission, Permission @base)
	{
		return InstanceParentPermissionAny(parentResolve, parentPermission).Base(@base);
	}

	public PermissionBuilder ProfilePermission<T>(Permission profileForPermission)
	{
		permission.ProfileForPermission = profileForPermission;
		return InstancePermission<T>();
	}

	public PermissionBuilder ProfilePermission<T>(Permission profileForPermission, Permission @base)
	{
		return ProfilePermission<T>(profileForPermission).Base(@base);
	}

	public PermissionBuilder ProfileInstanceSettingsPermission<T>(Permission profileForPermission)
	{
		permission.ProfileForPermission = profileForPermission;
		return InstanceSettingsPermission<T>();
	}

	public PermissionBuilder ProfileInstanceSettingsPermission<T>(Permission profileForPermission, Permission @base)
	{
		return ProfileInstanceSettingsPermission<T>(profileForPermission).Base(@base);
	}

	internal static object vAVw7QBYPoIWvR5RFp0v(object P_0)
	{
		return ((PermissionBuilder)P_0).Build();
	}

	internal static void C5CGCMBY1UW7VhJGf5Uh(object P_0, object P_1)
	{
		((Permission)P_0).Dependencies = (Permission[])P_1;
	}

	internal static bool J7b51xBY2aZBmWZR6aIM()
	{
		return HNtjJqBYOpv1NPOMhcDo == null;
	}

	internal static PermissionBuilder VqbR0wBYeYy5h1ne2mXX()
	{
		return HNtjJqBYOpv1NPOMhcDo;
	}

	internal static void UxiWb5BYN8qn0gRSNy8m(object P_0, object P_1)
	{
		((Permission)P_0).ModuleUid = (string)P_1;
	}

	internal static void F14iVMBY3OcmQM7PYGJ1(object P_0, Type value)
	{
		((Permission)P_0).EntityType = value;
	}

	internal static void sUHyGQBYpAAlLw5stoYP(object P_0, object P_1)
	{
		((Permission)P_0).Base = (Permission)P_1;
	}

	internal static void Bx33ZuBYaIegtNpn7HeP(object P_0, PermissionType value)
	{
		((Permission)P_0).PermissionType = value;
	}

	internal static object QoACWZBYDS1OuSZ5CJXr(object P_0, object P_1)
	{
		return ((PermissionBuilder)P_0).Base((Permission)P_1);
	}

	internal static void R6B6VKBYt6FIDSBScjJ8(object P_0, bool value)
	{
		((Permission)P_0).ShowInGlobalSettings = value;
	}

	internal static void MgeAqkBYwN5YkVpMgr36(object P_0, bool value)
	{
		((Permission)P_0).ReadOnly = value;
	}

	internal static void CsjhSlBY4Z6BqCaiuk77(object P_0, bool value)
	{
		((Permission)P_0).CheckModuleAccess = value;
	}
}
