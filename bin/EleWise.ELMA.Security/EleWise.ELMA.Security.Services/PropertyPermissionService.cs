using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Services;

[Service(Scope = ServiceScope.Application, Type = ComponentType.Server)]
internal class PropertyPermissionService : IPropertyPermissionService, IInitHandler
{
	private class PropertyProfileCacheEntry
	{
		private static object QksSXMpm7CXnM2Qa7Zf2;

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
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_308690af1b2f43b9a97bf91d774a6420 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public List<PropertyAccessCacheItem> Accesses { get; set; }

		public Func<object, long, PropertyPermissionType> FuncForUser { get; set; }

		public Func<object, List<long>, PropertyPermissionType> FuncForOrgItem { get; set; }

		public Func<object, List<long>, PropertyPermissionType> FuncForGroup { get; set; }

		public PropertyProfileCacheEntry()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			bsV5o2pmNti0Bp7pCo8D();
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

		internal static bool LYuqMypm6nMZoefHeGbC()
		{
			return QksSXMpm7CXnM2Qa7Zf2 == null;
		}

		internal static PropertyProfileCacheEntry bXD4OopmlZIreDR0f0qX()
		{
			return (PropertyProfileCacheEntry)QksSXMpm7CXnM2Qa7Zf2;
		}

		internal static void bsV5o2pmNti0Bp7pCo8D()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		}
	}

	private class TypeCacheEntry
	{
		private static object E69niNpmZJR2QRqvEHL8;

		public IDictionary<Guid, PropertyProfileCacheEntry> Properties { get; private set; }

		public TypeCacheEntry()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			al3SkkpmuG0at4YAGijS();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6370a8f224e7416eb3575ae34b77f5e3 == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					return;
				}
				Properties = new Dictionary<Guid, PropertyProfileCacheEntry>();
				num = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_11e42501f5004eefaeaccdfe8bd3b619 != 0)
				{
					num = 1;
				}
			}
		}

		internal static void al3SkkpmuG0at4YAGijS()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		}

		internal static bool ETxOGfpmx1E1TgSRYSYf()
		{
			return E69niNpmZJR2QRqvEHL8 == null;
		}

		internal static TypeCacheEntry quVDZkpmBeEpPMjIB1sH()
		{
			return (TypeCacheEntry)E69niNpmZJR2QRqvEHL8;
		}
	}

	private class GetPermissionResult
	{
		internal static object gvaFdjpmmk2yOlGIIYoH;

		public Dictionary<Guid, PropertyPermissionType> GlobalPermissions { get; set; }

		public Dictionary<Guid, PropertyPermissionType> DependedPermissionsOut { get; set; }

		public GetPermissionResult()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dee60bd1c491407eb16511279f664d42 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool UX1cK3pmeAoRC8E85u0Z()
		{
			return gvaFdjpmmk2yOlGIIYoH == null;
		}

		internal static GetPermissionResult jDsPyKpmL5Cxo271ScX5()
		{
			return (GetPermissionResult)gvaFdjpmmk2yOlGIIYoH;
		}
	}

	private class UserRolesResult
	{
		internal static object YOXc9OpmjqtcdmQEemZr;

		public List<long> GroupIds { get; set; }

		public List<long> OrgItemIds { get; set; }

		public UserRolesResult()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			mod0WopmR7O1BkBhxf3U();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_94a7beb9ab90455caa18ecaa3b17b19c == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static void mod0WopmR7O1BkBhxf3U()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		}

		internal static bool xjM2YgpmH2osCd9yBV9Z()
		{
			return YOXc9OpmjqtcdmQEemZr == null;
		}

		internal static UserRolesResult urWcrHpmaenJJN9aHtFt()
		{
			return (UserRolesResult)YOXc9OpmjqtcdmQEemZr;
		}
	}

	private IContextBoundVariableService contextCacheService;

	private IUnionComplexCacheService unionComplexCacheService;

	private ISecurityService securityService;

	private IAuthenticationService authenticationService;

	private static PropertyPermissionService jPhZeIP3h3iEpsINLP2;

	public IEnumerable<IPropertyPermissionAdapter> Adapters { get; set; }

	public IUnionComplexCacheService UnionComplexCacheService
	{
		get
		{
			int num = 2;
			int num2 = num;
			IUnionComplexCacheService unionComplexCacheService = default(IUnionComplexCacheService);
			IUnionComplexCacheService obj;
			while (true)
			{
				switch (num2)
				{
				case 1:
					unionComplexCacheService = (this.unionComplexCacheService = Locator.GetService<IUnionComplexCacheService>());
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1bc92e0376794fc182b6e366eee82dbd == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					obj = this.unionComplexCacheService;
					if (obj == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_98c0ec8bd6124c50b29441c60f6a53bf == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					obj = unionComplexCacheService;
					break;
				}
				break;
			}
			return obj;
		}
	}

	public IContextBoundVariableService ContextCacheService
	{
		get
		{
			int num = 2;
			int num2 = num;
			IContextBoundVariableService contextBoundVariableService = default(IContextBoundVariableService);
			IContextBoundVariableService contextBoundVariableService2;
			while (true)
			{
				switch (num2)
				{
				case 1:
					contextBoundVariableService = (contextCacheService = Locator.GetService<IContextBoundVariableService>());
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b081c717aa3147caa220888eaef123d9 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					contextBoundVariableService2 = contextCacheService;
					if (contextBoundVariableService2 != null)
					{
						break;
					}
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_98c0ec8bd6124c50b29441c60f6a53bf != 0)
					{
						num2 = 1;
					}
					continue;
				default:
					contextBoundVariableService2 = contextBoundVariableService;
					break;
				}
				break;
			}
			return contextBoundVariableService2;
		}
	}

	public ISecurityService SecurityService
	{
		get
		{
			int num = 2;
			int num2 = num;
			ISecurityService securityService = default(ISecurityService);
			ISecurityService obj;
			while (true)
			{
				switch (num2)
				{
				case 1:
					securityService = (this.securityService = Locator.GetServiceNotNull<ISecurityService>());
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0dd863774da04dfd9f21706b4b60a6b9 != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					obj = this.securityService;
					if (obj != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e19c59c87b9f40ffa6cb17beeb01edcf != 0)
					{
						num2 = 1;
					}
					continue;
				default:
					obj = securityService;
					break;
				}
				break;
			}
			return obj;
		}
	}

	public IAuthenticationService AuthenticationService
	{
		get
		{
			int num = 1;
			int num2 = num;
			IAuthenticationService authenticationService = default(IAuthenticationService);
			IAuthenticationService obj;
			while (true)
			{
				switch (num2)
				{
				default:
					authenticationService = (this.authenticationService = Locator.GetServiceNotNull<IAuthenticationService>());
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_288a03909ebe4f56a0d34bfce957098b == 0)
					{
						num2 = 2;
					}
					continue;
				case 1:
					obj = this.authenticationService;
					if (obj != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1c9893e65c104705bb8b228f8a38d9cd != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					obj = authenticationService;
					break;
				}
				break;
			}
			return obj;
		}
	}

	void IInitHandler.Init()
	{
	}

	void IInitHandler.InitComplete()
	{
		//Discarded unreachable code: IL_0056, IL_0065, IL_00fc, IL_011b, IL_012a, IL_0157, IL_0166
		int num = 2;
		int num2 = num;
		IEnumerator<IPropertyPermissionAdapter> enumerator = default(IEnumerator<IPropertyPermissionAdapter>);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				enumerator = Adapters.GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6370a8f224e7416eb3575ae34b77f5e3 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 1:
				try
				{
					while (true)
					{
						int num3;
						if (!hv4uD7PSpj8JFWGHOmU(enumerator))
						{
							num3 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5c5fc9a9dec4418fa9513347a116bf27 == 0)
							{
								num3 = 0;
							}
							goto IL_0074;
						}
						goto IL_00b0;
						IL_00b0:
						enumerator.Current.PermissionsChanged += adapter_PermissionsChanged;
						int num4 = 2;
						num3 = num4;
						goto IL_0074;
						IL_0074:
						switch (num3)
						{
						default:
							return;
						case 0:
							return;
						case 2:
							break;
						case 1:
							goto IL_00b0;
						}
					}
				}
				finally
				{
					int num5;
					if (enumerator == null)
					{
						num5 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_86eb143f59c14824a2785845ea23f248 == 0)
						{
							num5 = 1;
						}
						goto IL_0100;
					}
					goto IL_0135;
					IL_0135:
					Te6s42P99BpxNPL4KFh(enumerator);
					num5 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_da1dffb5695d4a95af335a696463801b != 0)
					{
						num5 = 2;
					}
					goto IL_0100;
					IL_0100:
					switch (num5)
					{
					case 1:
						goto end_IL_00db;
					case 2:
						goto end_IL_00db;
					}
					goto IL_0135;
					end_IL_00db:;
				}
			}
		}
	}

	PropertyPermissionType IPropertyPermissionService.CheckPropertyPermissionByGlobalOnly(Type modelType, Guid propertyGuid, IUser user)
	{
		return CheckPropertyPermissionByGlobalOnly(modelType, includeChilds: true, propertyGuid, user);
	}

	PropertyPermissionType IPropertyPermissionService.CheckPropertyPermissionByRoleOnly(object dataItem, Guid propertyGuid, IUser user)
	{
		return CheckPropertyPermissionByRoleOnly(dataItem, propertyGuid, user);
	}

	PropertyPermissionType IPropertyPermissionService.CheckPropertyPermission(object dataItem, Guid propertyGuid, IUser user)
	{
		return CheckPropertyPermission(dataItem, propertyGuid, user);
	}

	bool IPropertyPermissionService.HasPermissionsByRole(Type modelType, Guid propertyGuid, IUser user)
	{
		return HasPermissionsByRole(modelType, propertyGuid, user);
	}

	public PropertyPermissionType CheckPropertyPermission(object dataItem, Guid propertyGuid, IUser user = null)
	{
		//Discarded unreachable code: IL_00ab
		int num = 6;
		PropertyPermissionType propertyPermissionType2 = default(PropertyPermissionType);
		PropertyPermissionType propertyPermissionType = default(PropertyPermissionType);
		while (true)
		{
			int num2 = num;
			PropertyPermissionType num3;
			while (true)
			{
				switch (num2)
				{
				case 5:
					return PropertyPermissionType.None;
				case 3:
					return propertyPermissionType2;
				case 1:
					if (propertyPermissionType2 < PropertyPermissionType.Edit)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c3d852ec782a44099f926fd43a0da6df == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 3;
				case 6:
					if (dataItem != null)
					{
						propertyPermissionType2 = CheckPropertyPermissionByRoleOnly(dataItem, propertyGuid, user);
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b081c717aa3147caa220888eaef123d9 == 0)
						{
							num2 = 1;
						}
					}
					else
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b6bf1b70a8924e789fc4be8e9aadc953 == 0)
						{
							num2 = 5;
						}
					}
					break;
				case 2:
					num3 = propertyPermissionType2;
					goto end_IL_0012;
				case 4:
					if (propertyPermissionType <= propertyPermissionType2)
					{
						num2 = 2;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7fbc19cae8c8414894251bb8ae24a12e != 0)
						{
							num2 = 1;
						}
						break;
					}
					num3 = propertyPermissionType;
					goto end_IL_0012;
				default:
					propertyPermissionType = CheckPropertyPermissionByGlobalOnly(dataItem.GetType(), includeChilds: false, propertyGuid, user);
					num2 = 4;
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			propertyPermissionType2 = num3;
			num = 3;
		}
	}

	public PropertyPermissionType CheckPropertyPermissionByGlobalOnly(Type modelType, bool includeChilds, Guid propertyGuid, IUser user = null)
	{
		//Discarded unreachable code: IL_0059, IL_0068, IL_00a9, IL_00b8
		int num = 5;
		int num2 = num;
		PropertyPermissionType? globalPermission = default(PropertyPermissionType?);
		while (true)
		{
			switch (num2)
			{
			default:
				return PropertyPermissionType.None;
			case 2:
				return globalPermission.Value;
			case 5:
				if (!(modelType == null))
				{
					num2 = 4;
					break;
				}
				goto case 1;
			case 1:
				return PropertyPermissionType.None;
			case 4:
			{
				GetPermissions(modelType, includeChilds, propertyGuid, out globalPermission, out var _, user);
				num2 = 3;
				break;
			}
			case 3:
				if (globalPermission.HasValue)
				{
					num2 = 2;
					break;
				}
				goto default;
			}
		}
	}

	public PropertyPermissionType CheckPropertyPermissionByRoleOnly(object dataItem, Guid propertyGuid, IUser user = null)
	{
		//Discarded unreachable code: IL_0112, IL_014f, IL_01d1, IL_01db, IL_0215, IL_023d, IL_024c, IL_02fe, IL_030d, IL_031f
		int num = 11;
		PropertyProfileCacheEntry propertyCacheEntry = default(PropertyProfileCacheEntry);
		long num5 = default(long);
		List<long> groupIds = default(List<long>);
		List<long> orgItemIds = default(List<long>);
		PropertyPermissionType propertyPermissionType2 = default(PropertyPermissionType);
		PropertyPermissionType propertyPermissionType = default(PropertyPermissionType);
		PropertyPermissionType propertyPermissionType3 = default(PropertyPermissionType);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				long num6;
				PropertyPermissionType num3;
				PropertyPermissionType num4;
				switch (num2)
				{
				case 21:
					if (propertyCacheEntry.FuncForUser != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a7933e38c68f4f69b40e459b15579199 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 4;
				case 2:
					if (propertyCacheEntry.FuncForOrgItem != null)
					{
						num2 = 16;
						continue;
					}
					goto case 18;
				case 20:
					if (propertyCacheEntry.FuncForUser == null)
					{
						num2 = 29;
						continue;
					}
					goto case 14;
				case 6:
				{
					UserRolesResult userRoles = GetUserRoles(num5);
					groupIds = userRoles.GroupIds;
					orgItemIds = userRoles.OrgItemIds;
					num = 21;
					break;
				}
				case 3:
					num6 = -1L;
					goto IL_0371;
				case 14:
				case 27:
					if (user != null)
					{
						num2 = 19;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_01fd90314ba945f0a4ee79d2372961e2 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 1;
				case 12:
					return PropertyPermissionType.None;
				case 10:
					propertyPermissionType2 = PropertyPermissionType.None;
					num = 7;
					break;
				case 18:
				case 22:
					if (propertyPermissionType2 < PropertyPermissionType.Edit)
					{
						num2 = 25;
						continue;
					}
					goto case 15;
				case 24:
					if (propertyPermissionType > propertyPermissionType2)
					{
						num2 = 9;
						continue;
					}
					goto case 5;
				case 19:
				case 28:
					if (user == null)
					{
						num2 = 3;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5c3c41b36b4846e0b1701d4e56408883 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					num6 = (long)user.GetId();
					goto IL_0371;
				case 8:
					propertyPermissionType = propertyCacheEntry.FuncForGroup(dataItem, groupIds);
					num2 = 24;
					continue;
				case 26:
					if (propertyCacheEntry != null)
					{
						num2 = 20;
						continue;
					}
					goto case 15;
				case 5:
					num3 = propertyPermissionType2;
					goto IL_039d;
				case 16:
					propertyPermissionType3 = propertyCacheEntry.FuncForOrgItem(dataItem, orgItemIds);
					num2 = 17;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_06e91bc1320c425bb120c2fac8d1e3be != 0)
					{
						num2 = 7;
					}
					continue;
				case 7:
					propertyCacheEntry = GetPropertyCacheEntry(dataItem.GetType(), propertyGuid);
					num2 = 26;
					continue;
				case 11:
					if (dataItem != null)
					{
						num2 = 3;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c3d852ec782a44099f926fd43a0da6df == 0)
						{
							num2 = 10;
						}
						continue;
					}
					goto case 12;
				case 17:
					if (propertyPermissionType3 <= propertyPermissionType2)
					{
						num = 13;
						break;
					}
					num4 = propertyPermissionType3;
					goto IL_037f;
				default:
					propertyPermissionType2 = propertyCacheEntry.FuncForUser(dataItem, num5);
					num2 = 3;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dffee0180fb244db9738339fa28792b4 == 0)
					{
						num2 = 4;
					}
					continue;
				case 29:
					if (propertyCacheEntry.FuncForGroup != null)
					{
						num = 27;
						break;
					}
					goto case 23;
				case 23:
					if (propertyCacheEntry.FuncForOrgItem != null)
					{
						num2 = 8;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5028d2018b41471c962aaca947e33b9d == 0)
						{
							num2 = 14;
						}
						continue;
					}
					goto case 15;
				case 13:
					num4 = propertyPermissionType2;
					goto IL_037f;
				case 15:
					return propertyPermissionType2;
				case 25:
					if (propertyCacheEntry.FuncForGroup != null)
					{
						num2 = 8;
						continue;
					}
					goto case 15;
				case 4:
					if (propertyPermissionType2 >= PropertyPermissionType.Edit)
					{
						num2 = 18;
						continue;
					}
					goto case 2;
				case 1:
					user = (IUser)YPSA1jPfrlOG2rT0Crh(AuthenticationService);
					num2 = 28;
					continue;
				case 9:
					{
						num3 = propertyPermissionType;
						goto IL_039d;
					}
					IL_039d:
					propertyPermissionType2 = num3;
					num2 = 15;
					continue;
					IL_0371:
					num5 = num6;
					num2 = 6;
					continue;
					IL_037f:
					propertyPermissionType2 = num4;
					num2 = 20;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0dd863774da04dfd9f21706b4b60a6b9 != 0)
					{
						num2 = 22;
					}
					continue;
				}
				break;
			}
		}
	}

	public bool HasPermissionsByRole(Type modelType, Guid propertyGuid, IUser user = null)
	{
		//Discarded unreachable code: IL_0092
		int num = 1;
		int num2 = num;
		PropertyPermissionType? dependedPermission = default(PropertyPermissionType?);
		while (true)
		{
			switch (num2)
			{
			case 1:
			{
				if (m8soseP119PVYJO5k15(modelType, null))
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_73b92e1f752f422d899693d4318e4486 == 0)
					{
						num2 = 0;
					}
					break;
				}
				GetPermissions(modelType, includeChilds: true, propertyGuid, out var _, out dependedPermission, user);
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_66aae9daa3f84bb5931ed90b4759f85c == 0)
				{
					num2 = 1;
				}
				break;
			}
			default:
				return false;
			case 4:
				return dependedPermission.Value > PropertyPermissionType.Hide;
			case 3:
				return false;
			case 2:
				if (!dependedPermission.HasValue)
				{
					num2 = 3;
					break;
				}
				goto case 4;
			}
		}
	}

	public bool HasPermissions(Type modelType)
	{
		return GetAccesses(modelType, includeChilds: true) != null;
	}

	private void adapter_PermissionsChanged(object sender, PropertyPermissionsChangedEventArgs e)
	{
		int num = 3;
		int num2 = num;
		string text = default(string);
		Type type = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			case 2:
				text = (string)kSBvopvpta24VIUsyvT(CEFQJUvkrey8ect4HPa(0xC66FB14 ^ 0xC669AFA), type.AssemblyQualifiedName);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b081c717aa3147caa220888eaef123d9 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				type = aRU90ZPzBjPH7HB6RjH(e.ModelType);
				num2 = 2;
				break;
			default:
				uXDpBSv53IMOwGJTnwa(UnionComplexCacheService, text);
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5adff34accb14bd183b62ef1a2f5f964 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private UserRolesResult GetUserRoles(long userId)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass34_0 _003C_003Ec__DisplayClass34_ = default(_003C_003Ec__DisplayClass34_0);
		string name = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				_003C_003Ec__DisplayClass34_.userId = userId;
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_651070b1c9bd4381bbb7379d68d6508e == 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				return ContextCacheService.GetOrAdd(name, _003C_003Ec__DisplayClass34_._003CGetUserRoles_003Eb__0);
			case 2:
				name = (string)pMXEdbvAGXhQqfc8cy8(CEFQJUvkrey8ect4HPa(0x190F47B7 ^ 0x190F25FB), _003C_003Ec__DisplayClass34_.userId);
				num2 = 3;
				break;
			case 1:
				_003C_003Ec__DisplayClass34_ = new _003C_003Ec__DisplayClass34_0();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3c78e0d08cb4410a900ca26e4b83108c == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void GetPermissions(Type modelType, bool includeChilds, Guid propertyGuid, out PropertyPermissionType? globalPermission, out PropertyPermissionType? dependedPermission, IUser user = null)
	{
		//Discarded unreachable code: IL_00ab, IL_00ba, IL_01a9, IL_01b8
		int num = 10;
		PropertyPermissionType value4 = default(PropertyPermissionType);
		Dictionary<Guid, PropertyPermissionType> globalPermissionsOut = default(Dictionary<Guid, PropertyPermissionType>);
		PropertyPermissionType value2 = default(PropertyPermissionType);
		PropertyPermissionType value3 = default(PropertyPermissionType);
		Dictionary<Guid, PropertyPermissionType> dependedPermissionsOut = default(Dictionary<Guid, PropertyPermissionType>);
		PropertyPermissionType value = default(PropertyPermissionType);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					dependedPermission = value4;
					num2 = 7;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_61a610c13d6d47c8947a4d2d4016147a != 0)
					{
						num2 = 3;
					}
					continue;
				case 10:
					globalPermission = null;
					num2 = 7;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae5d5c9fcc284404ba2e43f0c4ab8892 != 0)
					{
						num2 = 9;
					}
					continue;
				case 14:
					if (!globalPermissionsOut.TryGetValue(Guid.Empty, out value2))
					{
						num2 = 8;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0dd863774da04dfd9f21706b4b60a6b9 == 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto case 11;
				case 3:
				case 8:
					if (!globalPermissionsOut.TryGetValue(propertyGuid, out value3))
					{
						num2 = 13;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d689f5970f6345a7af332e1f7092123f != 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto default;
				case 7:
					if (dependedPermissionsOut.TryGetValue(propertyGuid, out value))
					{
						num = 6;
						break;
					}
					return;
				case 11:
					globalPermission = value2;
					num2 = 3;
					continue;
				case 9:
					dependedPermission = null;
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0f3686d2211943308639c187009d1b4a != 0)
					{
						num2 = 1;
					}
					continue;
				case 15:
					if (globalPermissionsOut != null)
					{
						num2 = 14;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_11e42501f5004eefaeaccdfe8bd3b619 == 0)
						{
							num2 = 12;
						}
						continue;
					}
					goto case 4;
				case 4:
				case 13:
					if (dependedPermissionsOut != null)
					{
						num2 = 12;
						continue;
					}
					return;
				case 5:
					return;
				case 1:
					GetPermissions(modelType, includeChilds, out globalPermissionsOut, out dependedPermissionsOut, user);
					num = 15;
					break;
				case 12:
					if (dependedPermissionsOut.TryGetValue(Guid.Empty, out value4))
					{
						num2 = 2;
						continue;
					}
					goto case 7;
				default:
					globalPermission = ((!globalPermission.HasValue) ? new PropertyPermissionType?(value3) : ((globalPermission > value3) ? globalPermission : new PropertyPermissionType?(value3)));
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f0c2bdf066b1416088266cd84d9c3be2 != 0)
					{
						num2 = 4;
					}
					continue;
				case 6:
					dependedPermission = ((!dependedPermission.HasValue) ? new PropertyPermissionType?(value) : ((dependedPermission > value) ? dependedPermission : new PropertyPermissionType?(value)));
					num2 = 5;
					continue;
				}
				break;
			}
		}
	}

	private void GetPermissions(Type modelType, bool includeChilds, out Dictionary<Guid, PropertyPermissionType> globalPermissionsOut, out Dictionary<Guid, PropertyPermissionType> dependedPermissionsOut, IUser user = null)
	{
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass36_0 _003C_003Ec__DisplayClass36_ = default(_003C_003Ec__DisplayClass36_0);
		GetPermissionResult orAdd = default(GetPermissionResult);
		string name = default(string);
		while (true)
		{
			switch (num2)
			{
			case 7:
				return;
			case 5:
				_003C_003Ec__DisplayClass36_.accesses = GetAccesses(modelType, includeChilds);
				num2 = 14;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_364662b38d3b4bdb9f3f1f11b8889cdc != 0)
				{
					num2 = 9;
				}
				continue;
			case 2:
				_003C_003Ec__DisplayClass36_._003C_003E4__this = this;
				num2 = 9;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_488725796a2e487f95c022f5056d8a88 != 0)
				{
					num2 = 2;
				}
				continue;
			default:
				dependedPermissionsOut = orAdd.DependedPermissionsOut;
				num2 = 10;
				continue;
			case 13:
				name = (string)BP68rgvXElyDXaIF6ny(new object[6]
				{
					SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-816887841 ^ -816896703),
					modelType.AssemblyQualifiedName,
					CEFQJUvkrey8ect4HPa(0x50A2A0A3 ^ 0x50A2C3A3),
					includeChilds.ToString(),
					CEFQJUvkrey8ect4HPa(0x417D81DE ^ 0x417DE2D6),
					_003C_003Ec__DisplayClass36_.userId
				});
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2203cd019614c439eaf162fdd0eb05d == 0)
				{
					num2 = 0;
				}
				continue;
			case 14:
				if (_003C_003Ec__DisplayClass36_.accesses != null)
				{
					if (user == null)
					{
						num2 = 6;
						continue;
					}
					break;
				}
				num2 = 8;
				continue;
			case 3:
				_003C_003Ec__DisplayClass36_ = new _003C_003Ec__DisplayClass36_0();
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dee60bd1c491407eb16511279f664d42 == 0)
				{
					num2 = 0;
				}
				continue;
			case 11:
				globalPermissionsOut = orAdd.GlobalPermissions;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_06e91bc1320c425bb120c2fac8d1e3be == 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
				orAdd = ContextCacheService.GetOrAdd(name, _003C_003Ec__DisplayClass36_._003CGetPermissions_003Eb__0);
				num2 = 11;
				continue;
			case 8:
				globalPermissionsOut = null;
				num2 = 4;
				continue;
			case 6:
				user = (IUser)YPSA1jPfrlOG2rT0Crh(AuthenticationService);
				num2 = 12;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a1a646659a464f3fa5c9aedc64725d72 == 0)
				{
					num2 = 12;
				}
				continue;
			case 4:
				dependedPermissionsOut = null;
				num2 = 7;
				continue;
			case 9:
				modelType = InterfaceActivator.TypeOf(modelType);
				num2 = 5;
				continue;
			case 10:
				return;
			case 12:
				break;
			}
			_003C_003Ec__DisplayClass36_.userId = ((user != null) ? ((long)CTVcxVvWToDmqbtQhZb(user)) : (-1));
			num2 = 13;
		}
	}

	private void GetPermissionsNonCached(IEnumerable<PropertyAccessCacheItem> accesses, out Dictionary<Guid, PropertyPermissionType> globalPermissionsOut, out Dictionary<Guid, PropertyPermissionType> dependedPermissionsOut, long userId)
	{
		_003C_003Ec__DisplayClass37_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass37_0();
		CS_0024_003C_003E8__locals0.userId = userId;
		if (accesses == null || !accesses.Any())
		{
			globalPermissionsOut = null;
			dependedPermissionsOut = null;
			return;
		}
		CS_0024_003C_003E8__locals0.globalPermissions = new Dictionary<Guid, PropertyPermissionType>();
		CS_0024_003C_003E8__locals0.dependedPermissions = new Dictionary<Guid, PropertyPermissionType>();
		UserRolesResult userRoles = GetUserRoles(CS_0024_003C_003E8__locals0.userId);
		CS_0024_003C_003E8__locals0.groupsId = userRoles.GroupIds;
		CS_0024_003C_003E8__locals0.orgItemsId = userRoles.OrgItemIds;
		Action<PropertyAccessCacheItem> action = delegate(PropertyAccessCacheItem c)
		{
			//Discarded unreachable code: IL_003d, IL_00ae
			int num15 = 2;
			int num16 = num15;
			while (true)
			{
				switch (num16)
				{
				default:
					return;
				case 5:
					return;
				case 6:
					CS_0024_003C_003E8__locals0.globalPermissions[_003C_003Ec__DisplayClass37_0.b3PlpHpmcpbPfj9mtuW1(c)] = _003C_003Ec__DisplayClass37_0.VIXmdfpmGie0d9eBvr22(c);
					num16 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0b98d9f52b424149868b80d852714a70 != 0)
					{
						num16 = 0;
					}
					continue;
				case 0:
					return;
				case 2:
					if (CS_0024_003C_003E8__locals0.globalPermissions.ContainsKey(c.PropertyGuid))
					{
						num16 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b128c216f9744fbcbc93a88cbe7b4554 != 0)
						{
							num16 = 0;
						}
						continue;
					}
					break;
				case 4:
					return;
				case 1:
					if (_003C_003Ec__DisplayClass37_0.VIXmdfpmGie0d9eBvr22(c) <= CS_0024_003C_003E8__locals0.globalPermissions[c.PropertyGuid])
					{
						num16 = 5;
						continue;
					}
					goto case 6;
				case 3:
					break;
				}
				CS_0024_003C_003E8__locals0.globalPermissions.Add(_003C_003Ec__DisplayClass37_0.b3PlpHpmcpbPfj9mtuW1(c), _003C_003Ec__DisplayClass37_0.VIXmdfpmGie0d9eBvr22(c));
				num16 = 4;
			}
		};
		CS_0024_003C_003E8__locals0.allUserObj = UserGroupManager.Instance.Load(SecurityConstants.AllUsersGroupUid);
		accesses.Where(delegate(PropertyAccessCacheItem c)
		{
			//Discarded unreachable code: IL_006f, IL_007e, IL_013d, IL_014c, IL_015b
			int num13 = 10;
			int num14 = num13;
			long? groupId2 = default(long?);
			long id = default(long);
			Guid? assignedPropertyUid6 = default(Guid?);
			while (true)
			{
				switch (num14)
				{
				case 2:
					if (groupId2 != id)
					{
						num14 = 7;
						break;
					}
					goto case 3;
				case 4:
					return _003C_003Ec__DisplayClass37_0.VIXmdfpmGie0d9eBvr22(c) == PropertyPermissionType.Hide;
				case 5:
				case 6:
				case 7:
					return false;
				case 3:
					assignedPropertyUid6 = c.AssignedPropertyUid;
					num14 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6370a8f224e7416eb3575ae34b77f5e3 == 0)
					{
						num14 = 1;
					}
					break;
				case 8:
					id = CS_0024_003C_003E8__locals0.allUserObj.Id;
					num14 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_61a610c13d6d47c8947a4d2d4016147a == 0)
					{
						num14 = 2;
					}
					break;
				case 10:
					groupId2 = c.GroupId;
					num14 = 9;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_562220c988b04dea969b2dc6cde52015 == 0)
					{
						num14 = 9;
					}
					break;
				default:
					groupId2 = c.GroupId;
					num14 = 8;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2203cd019614c439eaf162fdd0eb05d == 0)
					{
						num14 = 6;
					}
					break;
				case 1:
					if (assignedPropertyUid6.HasValue)
					{
						num14 = 6;
						break;
					}
					goto case 4;
				case 9:
					if (!groupId2.HasValue)
					{
						num14 = 5;
						break;
					}
					goto default;
				}
			}
		}).ForEach(action);
		accesses.Where(delegate(PropertyAccessCacheItem c)
		{
			//Discarded unreachable code: IL_0088
			int num11 = 2;
			int num12 = num11;
			long? groupId = default(long?);
			Guid? assignedPropertyUid5 = default(Guid?);
			while (true)
			{
				switch (num12)
				{
				case 5:
				{
					List<long> groupsId = CS_0024_003C_003E8__locals0.groupsId;
					groupId = c.GroupId;
					if (!groupsId.Contains(groupId.Value))
					{
						num12 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_364662b38d3b4bdb9f3f1f11b8889cdc != 0)
						{
							num12 = 0;
						}
						break;
					}
					goto case 3;
				}
				case 1:
					if (groupId.HasValue)
					{
						num12 = 5;
						break;
					}
					goto default;
				case 4:
					return !assignedPropertyUid5.HasValue;
				default:
					return false;
				case 3:
					assignedPropertyUid5 = c.AssignedPropertyUid;
					num12 = 3;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1e79fb186de547eaaa37d66745fc7b90 != 0)
					{
						num12 = 4;
					}
					break;
				case 2:
					groupId = c.GroupId;
					num12 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4aad3b757e09491eb106d72b1e7740cc == 0)
					{
						num12 = 1;
					}
					break;
				}
			}
		}).ForEach(action);
		accesses.Where(delegate(PropertyAccessCacheItem c)
		{
			int num9 = 2;
			int num10 = num9;
			Guid? assignedPropertyUid4 = default(Guid?);
			long? organizationItemId = default(long?);
			while (true)
			{
				switch (num10)
				{
				case 4:
					assignedPropertyUid4 = c.AssignedPropertyUid;
					num10 = 3;
					break;
				default:
				{
					List<long> orgItemsId2 = CS_0024_003C_003E8__locals0.orgItemsId;
					organizationItemId = c.OrganizationItemId;
					if (orgItemsId2.Contains(organizationItemId.Value))
					{
						num10 = 4;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f6614d006512404f8cab65f09d3e1c89 == 0)
						{
							num10 = 2;
						}
						break;
					}
					goto IL_0086;
				}
				case 3:
					return !assignedPropertyUid4.HasValue;
				case 2:
					organizationItemId = c.OrganizationItemId;
					num10 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_73b92e1f752f422d899693d4318e4486 == 0)
					{
						num10 = 1;
					}
					break;
				case 1:
					{
						if (organizationItemId.HasValue)
						{
							num10 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6e35a1cd804541a884550671c71dbb1c == 0)
							{
								num10 = 0;
							}
							break;
						}
						goto IL_0086;
					}
					IL_0086:
					return false;
				}
			}
		}).ForEach(action);
		accesses.Where(delegate(PropertyAccessCacheItem c)
		{
			//Discarded unreachable code: IL_003d, IL_004c, IL_009d, IL_00ac
			int num7 = 2;
			int num8 = num7;
			Guid? assignedPropertyUid3 = default(Guid?);
			long? organizationItemPositionId = default(long?);
			while (true)
			{
				switch (num8)
				{
				case 6:
					return !assignedPropertyUid3.HasValue;
				case 3:
				case 5:
					return false;
				default:
					assignedPropertyUid3 = c.AssignedPropertyUid;
					num8 = 6;
					break;
				case 2:
					organizationItemPositionId = c.OrganizationItemPositionId;
					num8 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2c264a158ded4d26bea0177e79c88bc4 != 0)
					{
						num8 = 1;
					}
					break;
				case 4:
				{
					List<long> orgItemsId = CS_0024_003C_003E8__locals0.orgItemsId;
					organizationItemPositionId = c.OrganizationItemPositionId;
					if (!orgItemsId.Contains(organizationItemPositionId.Value))
					{
						num8 = 3;
						break;
					}
					goto default;
				}
				case 1:
					if (!organizationItemPositionId.HasValue)
					{
						num8 = 5;
						break;
					}
					goto case 4;
				}
			}
		}).ForEach(action);
		accesses.Where(delegate(PropertyAccessCacheItem c)
		{
			//Discarded unreachable code: IL_003d, IL_004c
			int num5 = 1;
			int num6 = num5;
			long? userId2 = default(long?);
			Guid? assignedPropertyUid2 = default(Guid?);
			while (true)
			{
				switch (num6)
				{
				default:
					if (!userId2.HasValue)
					{
						num6 = 6;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_daaf990ff0c644fb99cfba0a043a9b93 == 0)
						{
							num6 = 1;
						}
						break;
					}
					goto case 2;
				case 4:
					if (userId2.Value == CS_0024_003C_003E8__locals0.userId)
					{
						num6 = 5;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_df5466d729844e8ea757565832a01037 == 0)
						{
							num6 = 0;
						}
						break;
					}
					goto case 6;
				case 2:
					userId2 = c.UserId;
					num6 = 4;
					break;
				case 5:
					assignedPropertyUid2 = c.AssignedPropertyUid;
					num6 = 3;
					break;
				case 3:
					return !assignedPropertyUid2.HasValue;
				case 6:
					return false;
				case 1:
					userId2 = c.UserId;
					num6 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8ec57fd3f43f4cf7983bc996ab09feb4 != 0)
					{
						num6 = 0;
					}
					break;
				}
			}
		}).ForEach(action);
		accesses.Where(delegate(PropertyAccessCacheItem c)
		{
			int num3 = 1;
			int num4 = num3;
			Guid? assignedPropertyUid = default(Guid?);
			while (true)
			{
				switch (num4)
				{
				case 1:
					assignedPropertyUid = c.AssignedPropertyUid;
					num4 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_443cb30a1c3f4e72a61ec4f52377fcc7 == 0)
					{
						num4 = 0;
					}
					break;
				default:
					return assignedPropertyUid.HasValue;
				}
			}
		}).ForEach(delegate(PropertyAccessCacheItem c)
		{
			int num = 2;
			int num2 = num;
			PropertyPermissionType propertyPermissionType = default(PropertyPermissionType);
			PropertyPermissionType permissionType = default(PropertyPermissionType);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 5:
					propertyPermissionType = CS_0024_003C_003E8__locals0.dependedPermissions[c.PropertyGuid];
					num2 = 3;
					break;
				case 1:
					if (CS_0024_003C_003E8__locals0.dependedPermissions.ContainsKey(_003C_003Ec__DisplayClass37_0.b3PlpHpmcpbPfj9mtuW1(c)))
					{
						num2 = 2;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8176869ecaf44a0b8819db51e9ec5eb4 != 0)
						{
							num2 = 5;
						}
					}
					else
					{
						CS_0024_003C_003E8__locals0.dependedPermissions[c.PropertyGuid] = permissionType;
						num2 = 4;
					}
					break;
				case 0:
					return;
				case 4:
					return;
				case 2:
					permissionType = c.PermissionType;
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5c3c41b36b4846e0b1701d4e56408883 != 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					CS_0024_003C_003E8__locals0.dependedPermissions[_003C_003Ec__DisplayClass37_0.b3PlpHpmcpbPfj9mtuW1(c)] = ((propertyPermissionType > permissionType) ? propertyPermissionType : permissionType);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4b1278f673174e87a9fb6665eab69fc6 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		});
		globalPermissionsOut = CS_0024_003C_003E8__locals0.globalPermissions;
		dependedPermissionsOut = CS_0024_003C_003E8__locals0.dependedPermissions;
	}

	private TypeCacheEntry GetCacheEntry(Type modelType)
	{
		int num = 2;
		_003C_003Ec__DisplayClass38_0 _003C_003Ec__DisplayClass38_ = default(_003C_003Ec__DisplayClass38_0);
		string key = default(string);
		string timestampKey = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					_003C_003Ec__DisplayClass38_.modelType = modelType;
					num2 = 5;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_01fd90314ba945f0a4ee79d2372961e2 != 0)
					{
						num2 = 6;
					}
					continue;
				case 4:
					return UnionComplexCacheService.GetOrAdd(key, timestampKey, _003C_003Ec__DisplayClass38_._003CGetCacheEntry_003Eb__0);
				case 2:
					_003C_003Ec__DisplayClass38_ = new _003C_003Ec__DisplayClass38_0();
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0b98d9f52b424149868b80d852714a70 == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					_003C_003Ec__DisplayClass38_._003C_003E4__this = this;
					num2 = 5;
					continue;
				case 6:
					_003C_003Ec__DisplayClass38_.modelType = aRU90ZPzBjPH7HB6RjH(_003C_003Ec__DisplayClass38_.modelType);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f6614d006512404f8cab65f09d3e1c89 != 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					timestampKey = (string)kSBvopvpta24VIUsyvT(CEFQJUvkrey8ect4HPa(-816887841 ^ -816896463), _003C_003Ec__DisplayClass38_.modelType.AssemblyQualifiedName);
					num2 = 4;
					continue;
				}
				break;
			}
			key = (string)CEFQJUvkrey8ect4HPa(-1889123947 ^ -1889131877) + _003C_003Ec__DisplayClass38_.modelType.AssemblyQualifiedName;
			num = 3;
		}
	}

	private IEnumerable<PropertyAccessCacheItem> GetAccesses(Type modelType, bool includeChilds, IEnumerable<Guid> uids)
	{
		_003C_003Ec__DisplayClass39_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass39_0();
		CS_0024_003C_003E8__locals0.uids = uids;
		IEnumerable<PropertyAccessCacheItem> accesses = GetAccesses(modelType, includeChilds);
		if (CS_0024_003C_003E8__locals0.uids == null)
		{
			return accesses;
		}
		return accesses?.Where((PropertyAccessCacheItem a) => CS_0024_003C_003E8__locals0.uids.Contains(a.PropertyGuid)).ToArray();
	}

	private IEnumerable<PropertyAccessCacheItem> GetAccesses(Type modelType, bool includeChilds)
	{
		_003C_003Ec__DisplayClass40_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass40_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.modelType = modelType;
		CS_0024_003C_003E8__locals0.includeChilds = includeChilds;
		if (CS_0024_003C_003E8__locals0.modelType == null)
		{
			return null;
		}
		CS_0024_003C_003E8__locals0.modelType = InterfaceActivator.TypeOf(CS_0024_003C_003E8__locals0.modelType);
		string name = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4B68CDFB ^ 0x4B68AEA1) + CS_0024_003C_003E8__locals0.includeChilds + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2121ECF9 ^ 0x21218FF1) + CS_0024_003C_003E8__locals0.modelType.AssemblyQualifiedName;
		return ContextCacheService.GetOrAdd(name, () => CS_0024_003C_003E8__locals0._003C_003E4__this.GetAccessesNonCached(CS_0024_003C_003E8__locals0.modelType, CS_0024_003C_003E8__locals0.includeChilds));
	}

	private IEnumerable<PropertyAccessCacheItem> GetAccessesNonCached(Type modelType, bool includeChilds)
	{
		_003C_003Ec__DisplayClass41_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass41_0();
		CS_0024_003C_003E8__locals0.result = null;
		Action<TypeCacheEntry, bool> action = delegate(TypeCacheEntry entry, bool before)
		{
			int num = 6;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					return;
				case 7:
					CS_0024_003C_003E8__locals0.result = new List<PropertyAccessCacheItem>();
					num2 = 4;
					break;
				case 5:
					if (_003C_003Ec__DisplayClass41_0.LhAHyypmfXCAtAl2270S(entry.Properties) <= 0)
					{
						return;
					}
					num2 = 3;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0ab7ce9a6369414380df24a533da8346 != 0)
					{
						num2 = 3;
					}
					break;
				case 4:
					if (before)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2f11eccd7e8f4339a0b03ad9fe1eb947 == 0)
						{
							num2 = 0;
						}
					}
					else
					{
						CS_0024_003C_003E8__locals0.result.AddRange(entry.Properties.Values.SelectMany((PropertyProfileCacheEntry p) => p.Accesses));
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0f87584a8fee4f91864943acbd35d6d6 != 0)
						{
							num2 = 1;
						}
					}
					break;
				case 6:
					if (entry == null)
					{
						return;
					}
					num2 = 5;
					break;
				case 3:
					if (CS_0024_003C_003E8__locals0.result == null)
					{
						num2 = 7;
						break;
					}
					goto case 4;
				default:
					CS_0024_003C_003E8__locals0.result.InsertRange(0, entry.Properties.Values.SelectMany((PropertyProfileCacheEntry p) => p.Accesses));
					num2 = 2;
					break;
				case 2:
					return;
				}
			}
		};
		modelType = InterfaceActivator.TypeOf(modelType);
		Type type = modelType;
		while (type != null)
		{
			action(GetCacheEntry(type), arg2: true);
			type = type.BaseType;
		}
		if (includeChilds)
		{
			IEnumerable<Type> enumerable = GetAdapterByModelType(modelType)?.GetChildTypes(modelType);
			if (enumerable != null)
			{
				foreach (Type item in enumerable)
				{
					action(GetCacheEntry(item), arg2: false);
				}
			}
		}
		return CS_0024_003C_003E8__locals0.result;
	}

	private IDictionary<Guid, PropertyProfileCacheEntry> GetPropertyCacheEntries(Type modelType)
	{
		Dictionary<Guid, PropertyProfileCacheEntry> dictionary = new Dictionary<Guid, PropertyProfileCacheEntry>();
		modelType = InterfaceActivator.TypeOf(modelType);
		Type type = modelType;
		while (type != null)
		{
			TypeCacheEntry cacheEntry = GetCacheEntry(type);
			if (cacheEntry != null)
			{
				foreach (KeyValuePair<Guid, PropertyProfileCacheEntry> property in cacheEntry.Properties)
				{
					dictionary[property.Key] = property.Value;
				}
			}
			type = type.BaseType;
		}
		return dictionary;
	}

	private PropertyProfileCacheEntry GetPropertyCacheEntry(Type modelType, Guid propertyGuid)
	{
		//Discarded unreachable code: IL_009f
		int num = 4;
		int num2 = num;
		TypeCacheEntry cacheEntry = default(TypeCacheEntry);
		Type type = default(Type);
		PropertyProfileCacheEntry value = default(PropertyProfileCacheEntry);
		while (true)
		{
			switch (num2)
			{
			case 4:
				modelType = aRU90ZPzBjPH7HB6RjH(modelType);
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_97ec140e839b4bd5a711912170945a29 == 0)
				{
					num2 = 3;
				}
				break;
			case 6:
				if (cacheEntry != null)
				{
					num2 = 8;
					break;
				}
				goto IL_00d0;
			default:
				if (!qXcuy9vnPyThtxlwaaU(type, null))
				{
					num2 = 7;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4aad3b757e09491eb106d72b1e7740cc == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 2;
			case 2:
				cacheEntry = GetCacheEntry(type);
				num2 = 6;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a5d922da527e46afbe4b139adb51cde5 == 0)
				{
					num2 = 6;
				}
				break;
			case 5:
				return value;
			case 3:
				type = modelType;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2c264a158ded4d26bea0177e79c88bc4 == 0)
				{
					num2 = 0;
				}
				break;
			case 8:
				if (cacheEntry.Properties.TryGetValue(propertyGuid, out value))
				{
					num2 = 3;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0f87584a8fee4f91864943acbd35d6d6 != 0)
					{
						num2 = 5;
					}
					break;
				}
				goto IL_00d0;
			case 7:
				{
					return null;
				}
				IL_00d0:
				type = type.BaseType;
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a33ec05b36714591b0adf150b655c9a8 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private TypeCacheEntry GenerateTypeCacheEntry(Type modelType)
	{
		//Discarded unreachable code: IL_00b1, IL_012a, IL_0139, IL_0177, IL_028d, IL_02c5, IL_0348, IL_0352, IL_0487, IL_06cc, IL_06eb, IL_06fa, IL_0727, IL_0736
		int num = 13;
		_003C_003Ec__DisplayClass44_0 _003C_003Ec__DisplayClass44_ = default(_003C_003Ec__DisplayClass44_0);
		TypeCacheEntry typeCacheEntry = default(TypeCacheEntry);
		IEnumerator<IAbstractPropertyAccess> enumerator2 = default(IEnumerator<IAbstractPropertyAccess>);
		PropertyAccessCacheItem propertyAccessCacheItem = default(PropertyAccessCacheItem);
		PropertyProfileCacheEntry value = default(PropertyProfileCacheEntry);
		IEnumerable<IAbstractPropertyAccess> accesses = default(IEnumerable<IAbstractPropertyAccess>);
		IEnumerator<PropertyProfileCacheEntry> enumerator = default(IEnumerator<PropertyProfileCacheEntry>);
		_003C_003Ec__DisplayClass44_1 _003C_003Ec__DisplayClass44_2 = default(_003C_003Ec__DisplayClass44_1);
		PropertyProfileCacheEntry current = default(PropertyProfileCacheEntry);
		Expression<Func<object, List<long>, PropertyPermissionType>> expression = default(Expression<Func<object, List<long>, PropertyPermissionType>>);
		Expression<Func<object, long, PropertyPermissionType>> expression2 = default(Expression<Func<object, long, PropertyPermissionType>>);
		Expression<Func<object, List<long>, PropertyPermissionType>> expression3 = default(Expression<Func<object, List<long>, PropertyPermissionType>>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					_003C_003Ec__DisplayClass44_.orgItemsIdExpression = (ParameterExpression)zdPHtTvl4PqL7xGClBB(yx4Lpgv6RVQkkkVMP9g(typeof(List<long>).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x417D81DE ^ 0x417DE212));
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5ae6a44bd52345c5bcadd62b7063c7d9 == 0)
					{
						num2 = 0;
					}
					continue;
				case 19:
					typeCacheEntry = new TypeCacheEntry();
					num2 = 18;
					continue;
				case 6:
					_003C_003Ec__DisplayClass44_.groupsIdExpression = (ParameterExpression)zdPHtTvl4PqL7xGClBB(yx4Lpgv6RVQkkkVMP9g(typeof(List<long>).TypeHandle), CEFQJUvkrey8ect4HPa(0x1C48C9C4 ^ 0x1C48AA7C));
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a9bad31b2eb24bb9b571e9b822d133bf != 0)
					{
						num2 = 2;
					}
					continue;
				case 4:
					_003C_003Ec__DisplayClass44_._003C_003E4__this = this;
					num2 = 5;
					continue;
				case 14:
					try
					{
						while (true)
						{
							int num3;
							if (!hv4uD7PSpj8JFWGHOmU(enumerator2))
							{
								num3 = 1;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae5d5c9fcc284404ba2e43f0c4ab8892 == 0)
								{
									num3 = 1;
								}
								goto IL_0148;
							}
							goto IL_024f;
							IL_024f:
							propertyAccessCacheItem = new PropertyAccessCacheItem(enumerator2.Current);
							num3 = 4;
							goto IL_0148;
							IL_0148:
							while (true)
							{
								switch (num3)
								{
								default:
									value.Accesses.Add(propertyAccessCacheItem);
									num3 = 5;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2203cd019614c439eaf162fdd0eb05d == 0)
									{
										num3 = 3;
									}
									continue;
								case 3:
								{
									PropertyProfileCacheEntry propertyProfileCacheEntry = new PropertyProfileCacheEntry();
									zCwVH6v7sbliV8oN2IX(propertyProfileCacheEntry, mchtn7viKvO1aj1PSfp(propertyAccessCacheItem));
									propertyProfileCacheEntry.Accesses = new List<PropertyAccessCacheItem>();
									value = propertyProfileCacheEntry;
									num3 = 2;
									continue;
								}
								case 4:
									if (typeCacheEntry.Properties.TryGetValue(propertyAccessCacheItem.PropertyGuid, out value))
									{
										int num4 = 6;
										num3 = num4;
										continue;
									}
									goto case 3;
								case 5:
									break;
								case 2:
									typeCacheEntry.Properties[propertyAccessCacheItem.PropertyGuid] = value;
									num3 = 0;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_77bfde1a0739446782f0bda00c988550 == 0)
									{
										num3 = 0;
									}
									continue;
								case 7:
									goto IL_024f;
								case 1:
									goto end_IL_01fa;
								}
								break;
							}
							continue;
							end_IL_01fa:
							break;
						}
					}
					finally
					{
						if (enumerator2 != null)
						{
							int num5 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5ae6a44bd52345c5bcadd62b7063c7d9 == 0)
							{
								num5 = 0;
							}
							while (true)
							{
								switch (num5)
								{
								default:
									enumerator2.Dispose();
									num5 = 0;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a53a06d0e4134332947f6164df41fb0f == 0)
									{
										num5 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					break;
				case 5:
					_003C_003Ec__DisplayClass44_.modelType = InterfaceActivator.TypeOf(_003C_003Ec__DisplayClass44_.modelType);
					num2 = 19;
					continue;
				case 9:
					_003C_003Ec__DisplayClass44_.userIdExpression = (ParameterExpression)zdPHtTvl4PqL7xGClBB(yx4Lpgv6RVQkkkVMP9g(typeof(long).TypeHandle), CEFQJUvkrey8ect4HPa(-1842376086 ^ -1842351546));
					num2 = 6;
					continue;
				case 17:
					enumerator2 = accesses.GetEnumerator();
					num2 = 14;
					continue;
				case 12:
					_003C_003Ec__DisplayClass44_.modelType = modelType;
					num2 = 4;
					continue;
				case 11:
					try
					{
						while (true)
						{
							int num6;
							if (!hv4uD7PSpj8JFWGHOmU(enumerator))
							{
								num6 = 18;
								goto IL_0356;
							}
							goto IL_05cf;
							IL_0356:
							while (true)
							{
								switch (num6)
								{
								case 13:
									_003C_003Ec__DisplayClass44_2.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass44_;
									num6 = 9;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3c78e0d08cb4410a900ca26e4b83108c == 0)
									{
										num6 = 9;
									}
									continue;
								case 16:
									if (Bcag3NvZB4n17ZmdZGV(_003C_003Ec__DisplayClass44_2.userExpressions) <= 0)
									{
										num6 = 11;
										continue;
									}
									goto case 10;
								case 8:
									_003C_003Ec__DisplayClass44_2.orgItemExpressions = new List<Expression>();
									num6 = 17;
									continue;
								case 7:
									current.FuncForOrgItem = expression.Compile();
									num6 = 1;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bcafdad7ca04437ebcc767622a0f9af3 == 0)
									{
										num6 = 0;
									}
									continue;
								default:
									_003C_003Ec__DisplayClass44_2 = new _003C_003Ec__DisplayClass44_1();
									num6 = 13;
									continue;
								case 6:
								case 11:
									if (Bcag3NvZB4n17ZmdZGV(_003C_003Ec__DisplayClass44_2.orgItemExpressions) > 0)
									{
										num6 = 5;
										continue;
									}
									goto case 1;
								case 1:
									if (Bcag3NvZB4n17ZmdZGV(_003C_003Ec__DisplayClass44_2.groupExpressions) > 0)
									{
										num6 = 3;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fa1b4c3a88294db7b3c25698c3f06dd7 != 0)
										{
											num6 = 4;
										}
										continue;
									}
									break;
								case 9:
									_003C_003Ec__DisplayClass44_2.userExpressions = new List<Expression>();
									num6 = 8;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0dd863774da04dfd9f21706b4b60a6b9 == 0)
									{
										num6 = 4;
									}
									continue;
								case 10:
									expression2 = Expression.Lambda<Func<object, long, PropertyPermissionType>>(FuncCommon(_003C_003Ec__DisplayClass44_2.userExpressions, _003C_003Ec__DisplayClass44_2.CS_0024_003C_003E8__locals1.localVarResult), new ParameterExpression[2]
									{
										_003C_003Ec__DisplayClass44_2.CS_0024_003C_003E8__locals1.modelExpression,
										_003C_003Ec__DisplayClass44_2.CS_0024_003C_003E8__locals1.userIdExpression
									});
									num6 = 15;
									continue;
								case 3:
									break;
								case 4:
									expression3 = Expression.Lambda<Func<object, List<long>, PropertyPermissionType>>(FuncCommon(_003C_003Ec__DisplayClass44_2.groupExpressions, _003C_003Ec__DisplayClass44_2.CS_0024_003C_003E8__locals1.localVarResult), new ParameterExpression[2]
									{
										_003C_003Ec__DisplayClass44_2.CS_0024_003C_003E8__locals1.modelExpression,
										_003C_003Ec__DisplayClass44_2.CS_0024_003C_003E8__locals1.groupsIdExpression
									});
									num6 = 14;
									continue;
								case 14:
									current.FuncForGroup = expression3.Compile();
									num6 = 3;
									continue;
								case 5:
									expression = Expression.Lambda<Func<object, List<long>, PropertyPermissionType>>(FuncCommon(_003C_003Ec__DisplayClass44_2.orgItemExpressions, _003C_003Ec__DisplayClass44_2.CS_0024_003C_003E8__locals1.localVarResult), new ParameterExpression[2]
									{
										_003C_003Ec__DisplayClass44_2.CS_0024_003C_003E8__locals1.modelExpression,
										_003C_003Ec__DisplayClass44_2.CS_0024_003C_003E8__locals1.orgItemsIdExpression
									});
									num6 = 7;
									continue;
								case 2:
									goto IL_05cf;
								case 17:
									_003C_003Ec__DisplayClass44_2.groupExpressions = new List<Expression>();
									num6 = 12;
									continue;
								case 15:
									current.FuncForUser = expression2.Compile();
									num6 = 6;
									continue;
								case 12:
									(from p in current.Accesses.Where(delegate(PropertyAccessCacheItem p)
										{
											int num8 = 1;
											int num9 = num8;
											Guid? assignedPropertyUid = default(Guid?);
											while (true)
											{
												switch (num9)
												{
												case 1:
													assignedPropertyUid = p.AssignedPropertyUid;
													num9 = 0;
													if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39a415f51fd045a981443759203cc0ad == 0)
													{
														num9 = 0;
													}
													break;
												default:
													return assignedPropertyUid.HasValue;
												}
											}
										})
										orderby _003C_003Ec.LfjDlBpmM4ms4mTtABdX(p) descending
										select p).ForEach(_003C_003Ec__DisplayClass44_2._003CGenerateTypeCacheEntry_003Eb__2);
									num6 = 15;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8dab57df677749fba2d5364cf752799f != 0)
									{
										num6 = 16;
									}
									continue;
								case 18:
									return typeCacheEntry;
								}
								break;
							}
							continue;
							IL_05cf:
							current = enumerator.Current;
							num6 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_06e91bc1320c425bb120c2fac8d1e3be == 0)
							{
								num6 = 0;
							}
							goto IL_0356;
						}
					}
					finally
					{
						int num7;
						if (enumerator == null)
						{
							num7 = 1;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f5cf5deab67c429f89caddff1f348afc == 0)
							{
								num7 = 2;
							}
							goto IL_06d0;
						}
						goto IL_0705;
						IL_0705:
						enumerator.Dispose();
						num7 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0ab7ce9a6369414380df24a533da8346 != 0)
						{
							num7 = 0;
						}
						goto IL_06d0;
						IL_06d0:
						switch (num7)
						{
						default:
							goto end_IL_06ab;
						case 2:
							goto end_IL_06ab;
						case 1:
							break;
						case 0:
							goto end_IL_06ab;
						}
						goto IL_0705;
						end_IL_06ab:;
					}
				case 15:
					return typeCacheEntry;
				case 3:
					return typeCacheEntry;
				case 8:
					if (_003C_003Ec__DisplayClass44_.adapter != null)
					{
						accesses = _003C_003Ec__DisplayClass44_.adapter.GetAccesses(_003C_003Ec__DisplayClass44_.modelType);
						num2 = 7;
					}
					else
					{
						num2 = 15;
					}
					continue;
				case 7:
					if (accesses == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8523ddc2b5094f2f87aec3d74da64bd2 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 17;
				default:
					_003C_003Ec__DisplayClass44_.localVarResult = (ParameterExpression)iyISZevNpJYLlyY4qhI(yx4Lpgv6RVQkkkVMP9g(typeof(PropertyPermissionType).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2119527672 ^ -2119503636));
					num2 = 10;
					continue;
				case 13:
					_003C_003Ec__DisplayClass44_ = new _003C_003Ec__DisplayClass44_0();
					num2 = 12;
					continue;
				case 10:
					enumerator = typeCacheEntry.Properties.Values.GetEnumerator();
					num2 = 5;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a9bad31b2eb24bb9b571e9b822d133bf == 0)
					{
						num2 = 11;
					}
					continue;
				case 1:
				case 16:
					break;
				case 18:
					goto end_IL_0012;
				}
				_003C_003Ec__DisplayClass44_.modelExpression = (ParameterExpression)zdPHtTvl4PqL7xGClBB(yx4Lpgv6RVQkkkVMP9g(typeof(object).TypeHandle), CEFQJUvkrey8ect4HPa(-236222459 ^ -236196945));
				num2 = 8;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b081c717aa3147caa220888eaef123d9 == 0)
				{
					num2 = 9;
				}
				continue;
				end_IL_0012:
				break;
			}
			_003C_003Ec__DisplayClass44_.adapter = GetAdapterByModelType(_003C_003Ec__DisplayClass44_.modelType);
			num = 8;
		}
	}

	private BlockExpression FuncCommon(List<Expression> exps, ParameterExpression localVarResult)
	{
		BinaryExpression item = Expression.Assign(localVarResult, Expression.Constant(PropertyPermissionType.None));
		exps.Insert(0, item);
		exps.Add(localVarResult);
		return Expression.Block(new ParameterExpression[1] { localVarResult }, exps);
	}

	private BlockExpression GenerateFunc(string name, PropertyPermissionType permission, Type type, ParameterExpression modelExpression, ParameterExpression userIdExpression, ParameterExpression localVarResult)
	{
		int num = 3;
		int num2 = num;
		ParameterExpression parameterExpression2 = default(ParameterExpression);
		BinaryExpression binaryExpression6 = default(BinaryExpression);
		BinaryExpression binaryExpression4 = default(BinaryExpression);
		BinaryExpression binaryExpression5 = default(BinaryExpression);
		ParameterExpression parameterExpression = default(ParameterExpression);
		ConstantExpression constantExpression = default(ConstantExpression);
		BinaryExpression binaryExpression3 = default(BinaryExpression);
		BinaryExpression binaryExpression2 = default(BinaryExpression);
		BinaryExpression binaryExpression = default(BinaryExpression);
		ConstantExpression constantExpression2 = default(ConstantExpression);
		while (true)
		{
			switch (num2)
			{
			case 5:
				parameterExpression2 = (ParameterExpression)iyISZevNpJYLlyY4qhI(typeof(long), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xAEB118D ^ 0xAEB7583));
				num2 = 7;
				break;
			case 7:
				binaryExpression6 = Expression.Assign(localVarResult, Expression.Constant(permission));
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c08b0b4e9ab14bedb2a2c7a0048ab814 == 0)
				{
					num2 = 0;
				}
				break;
			case 9:
				binaryExpression4 = Expression.Equal(userIdExpression, parameterExpression2);
				num2 = 8;
				break;
			default:
				binaryExpression5 = Expression.Assign(parameterExpression, (Expression)jeVTfCvBHciWfu4N6Ai(modelExpression, type));
				num2 = 10;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0ab7ce9a6369414380df24a533da8346 == 0)
				{
					num2 = 5;
				}
				break;
			case 3:
				constantExpression = (ConstantExpression)bpCwLTvxiQyiKmKYVZD(permission);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5c5fc9a9dec4418fa9513347a116bf27 != 0)
				{
					num2 = 2;
				}
				break;
			case 6:
				return Expression.Block(new ParameterExpression[2] { parameterExpression, parameterExpression2 }, binaryExpression5, (Expression)tqeYwWvaykdqOIqnCVu(binaryExpression3, N8AC7ZvRYvrkqOrJQPG(binaryExpression2, tqeYwWvaykdqOIqnCVu(grseTcvHayYFcLyGIAa(binaryExpression4, binaryExpression), binaryExpression6))));
			case 10:
				binaryExpression3 = (BinaryExpression)jRZsnIvmtNOWRlMpUqN(aAKAFmvuOhxWt2wPg4I(parameterExpression, name), constantExpression2);
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_df5466d729844e8ea757565832a01037 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				binaryExpression2 = (BinaryExpression)cf9wh3vLKSoWL57E41X(parameterExpression2, jeVTfCvBHciWfu4N6Ai(I98MgKveEB8W9iWVhLt(aAKAFmvuOhxWt2wPg4I(parameterExpression, name), yx4Lpgv6RVQkkkVMP9g(typeof(IIdentified).TypeHandle).GetMethod(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-784481839 ^ -784488967), new Type[0])), typeof(long)));
				num2 = 9;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7fbc19cae8c8414894251bb8ae24a12e == 0)
				{
					num2 = 9;
				}
				break;
			case 2:
				constantExpression2 = (ConstantExpression)bpCwLTvxiQyiKmKYVZD(null);
				num2 = 4;
				break;
			case 8:
				binaryExpression = (BinaryExpression)N54qPwvjDLLKqa4ptxo(jeVTfCvBHciWfu4N6Ai(constantExpression, yx4Lpgv6RVQkkkVMP9g(typeof(int).TypeHandle)), Expression.Convert(localVarResult, yx4Lpgv6RVQkkkVMP9g(typeof(int).TypeHandle)));
				num2 = 6;
				break;
			case 4:
				parameterExpression = (ParameterExpression)iyISZevNpJYLlyY4qhI(type, CEFQJUvkrey8ect4HPa(0xCDF201B ^ 0xCDF43EF));
				num2 = 5;
				break;
			}
		}
	}

	private BlockExpression GenerateFuncForList(string name, PropertyPermissionType permission, Type type, ParameterExpression modelExpression, ParameterExpression itemsIdExpression, ParameterExpression localVarResult)
	{
		int num = 6;
		ConstantExpression constantExpression2 = default(ConstantExpression);
		ParameterExpression parameterExpression = default(ParameterExpression);
		MethodCallExpression methodCallExpression = default(MethodCallExpression);
		ParameterExpression parameterExpression2 = default(ParameterExpression);
		BinaryExpression binaryExpression2 = default(BinaryExpression);
		ConstantExpression constantExpression = default(ConstantExpression);
		BinaryExpression binaryExpression3 = default(BinaryExpression);
		BinaryExpression binaryExpression5 = default(BinaryExpression);
		BinaryExpression binaryExpression = default(BinaryExpression);
		BinaryExpression binaryExpression4 = default(BinaryExpression);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					constantExpression2 = (ConstantExpression)bpCwLTvxiQyiKmKYVZD(permission);
					num2 = 5;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_86eb143f59c14824a2785845ea23f248 != 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					parameterExpression = (ParameterExpression)iyISZevNpJYLlyY4qhI(type, CEFQJUvkrey8ect4HPa(0x3B1D6430 ^ 0x3B1D07C4));
					num2 = 8;
					continue;
				case 2:
					methodCallExpression = (MethodCallExpression)XHT2X8vwZPsSdFCLy2G(itemsIdExpression, yx4Lpgv6RVQkkkVMP9g(typeof(List<long>).TypeHandle).GetMethod((string)CEFQJUvkrey8ect4HPa(-95913524 ^ -95937122), new Type[1] { yx4Lpgv6RVQkkkVMP9g(typeof(long).TypeHandle) }), new Expression[1] { parameterExpression2 });
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3e35bb8d9f5b4a1d9826edea4d9dca96 == 0)
					{
						num2 = 0;
					}
					continue;
				case 9:
					binaryExpression2 = (BinaryExpression)jRZsnIvmtNOWRlMpUqN(aAKAFmvuOhxWt2wPg4I(parameterExpression, name), constantExpression);
					num2 = 3;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7fbc19cae8c8414894251bb8ae24a12e == 0)
					{
						num2 = 7;
					}
					continue;
				default:
					binaryExpression3 = (BinaryExpression)cf9wh3vLKSoWL57E41X(parameterExpression2, jeVTfCvBHciWfu4N6Ai(I98MgKveEB8W9iWVhLt(aAKAFmvuOhxWt2wPg4I(parameterExpression, name), yx4Lpgv6RVQkkkVMP9g(typeof(IIdentified).TypeHandle).GetMethod(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xFD0849E ^ 0xFD0E0B6), new Type[0])), yx4Lpgv6RVQkkkVMP9g(typeof(long).TypeHandle)));
					num2 = 4;
					continue;
				case 7:
					binaryExpression5 = (BinaryExpression)cf9wh3vLKSoWL57E41X(localVarResult, bpCwLTvxiQyiKmKYVZD(permission));
					num2 = 8;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6c7be8ec8b6749dcb0601e062f5515fa == 0)
					{
						num2 = 10;
					}
					continue;
				case 8:
					parameterExpression2 = (ParameterExpression)iyISZevNpJYLlyY4qhI(yx4Lpgv6RVQkkkVMP9g(typeof(long).TypeHandle), CEFQJUvkrey8ect4HPa(-1757426405 ^ -1757435603));
					num2 = 9;
					continue;
				case 1:
					return Expression.Block(new ParameterExpression[2] { parameterExpression, parameterExpression2 }, binaryExpression, (Expression)tqeYwWvaykdqOIqnCVu(binaryExpression2, N8AC7ZvRYvrkqOrJQPG(binaryExpression3, tqeYwWvaykdqOIqnCVu(grseTcvHayYFcLyGIAa(methodCallExpression, binaryExpression4), binaryExpression5))));
				case 5:
					constantExpression = (ConstantExpression)bpCwLTvxiQyiKmKYVZD(null);
					num2 = 3;
					continue;
				case 10:
					binaryExpression = (BinaryExpression)cf9wh3vLKSoWL57E41X(parameterExpression, jeVTfCvBHciWfu4N6Ai(modelExpression, type));
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5adff34accb14bd183b62ef1a2f5f964 != 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					break;
				}
				break;
			}
			binaryExpression4 = Expression.GreaterThan((Expression)jeVTfCvBHciWfu4N6Ai(constantExpression2, yx4Lpgv6RVQkkkVMP9g(typeof(int).TypeHandle)), (Expression)jeVTfCvBHciWfu4N6Ai(localVarResult, typeof(int)));
			num = 2;
		}
	}

	private IPropertyPermissionAdapter GetAdapterByModelType(Type modelType)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass48_0 _003C_003Ec__DisplayClass48_ = default(_003C_003Ec__DisplayClass48_0);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass48_ = new _003C_003Ec__DisplayClass48_0();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_01fd90314ba945f0a4ee79d2372961e2 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				_003C_003Ec__DisplayClass48_.modelType = modelType;
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5ae6a44bd52345c5bcadd62b7063c7d9 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return Adapters.FirstOrDefault(_003C_003Ec__DisplayClass48_._003CGetAdapterByModelType_003Eb__0);
			}
		}
	}

	public PropertyPermissionService()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		a5cm3yv2TkfN7eG6mZM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3a30dc594d64d20b0419bc3debf22fd != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool BmDR4uPy5WnRYfff9PR()
	{
		return jPhZeIP3h3iEpsINLP2 == null;
	}

	internal static PropertyPermissionService cVhrcPPbFVWUTuWJTIM()
	{
		return jPhZeIP3h3iEpsINLP2;
	}

	internal static bool hv4uD7PSpj8JFWGHOmU(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void Te6s42P99BpxNPL4KFh(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object YPSA1jPfrlOG2rT0Crh(object P_0)
	{
		return ((IAuthenticationService)P_0).GetCurrentUser();
	}

	internal static bool m8soseP119PVYJO5k15(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static Type aRU90ZPzBjPH7HB6RjH(Type P_0)
	{
		return InterfaceActivator.TypeOf(P_0);
	}

	internal static object CEFQJUvkrey8ect4HPa(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object kSBvopvpta24VIUsyvT(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static void uXDpBSv53IMOwGJTnwa(object P_0, object P_1)
	{
		((IUnionComplexCacheService)P_0).RefreshTimestamp((string)P_1);
	}

	internal static object pMXEdbvAGXhQqfc8cy8(object P_0, object P_1)
	{
		return string.Concat(P_0, P_1);
	}

	internal static object CTVcxVvWToDmqbtQhZb(object P_0)
	{
		return ((IIdentified)P_0).GetId();
	}

	internal static object BP68rgvXElyDXaIF6ny(object P_0)
	{
		return string.Concat((object[])P_0);
	}

	internal static bool qXcuy9vnPyThtxlwaaU(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static Guid mchtn7viKvO1aj1PSfp(object P_0)
	{
		return ((PropertyAccessCacheItem)P_0).PropertyGuid;
	}

	internal static void zCwVH6v7sbliV8oN2IX(object P_0, Guid value)
	{
		((PropertyProfileCacheEntry)P_0).PropertyGuid = value;
	}

	internal static Type yx4Lpgv6RVQkkkVMP9g(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object zdPHtTvl4PqL7xGClBB(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object iyISZevNpJYLlyY4qhI(Type P_0, object P_1)
	{
		return Expression.Variable(P_0, (string)P_1);
	}

	internal static int Bcag3NvZB4n17ZmdZGV(object P_0)
	{
		return ((List<Expression>)P_0).Count;
	}

	internal static object bpCwLTvxiQyiKmKYVZD(object P_0)
	{
		return Expression.Constant(P_0);
	}

	internal static object jeVTfCvBHciWfu4N6Ai(object P_0, Type P_1)
	{
		return Expression.Convert((Expression)P_0, P_1);
	}

	internal static object aAKAFmvuOhxWt2wPg4I(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (string)P_1);
	}

	internal static object jRZsnIvmtNOWRlMpUqN(object P_0, object P_1)
	{
		return Expression.NotEqual((Expression)P_0, (Expression)P_1);
	}

	internal static object I98MgKveEB8W9iWVhLt(object P_0, object P_1)
	{
		return Expression.Call((Expression)P_0, (MethodInfo)P_1);
	}

	internal static object cf9wh3vLKSoWL57E41X(object P_0, object P_1)
	{
		return Expression.Assign((Expression)P_0, (Expression)P_1);
	}

	internal static object N54qPwvjDLLKqa4ptxo(object P_0, object P_1)
	{
		return Expression.GreaterThan((Expression)P_0, (Expression)P_1);
	}

	internal static object grseTcvHayYFcLyGIAa(object P_0, object P_1)
	{
		return Expression.And((Expression)P_0, (Expression)P_1);
	}

	internal static object tqeYwWvaykdqOIqnCVu(object P_0, object P_1)
	{
		return Expression.IfThen((Expression)P_0, (Expression)P_1);
	}

	internal static object N8AC7ZvRYvrkqOrJQPG(object P_0, object P_1)
	{
		return Expression.Block((Expression)P_0, (Expression)P_1);
	}

	internal static object XHT2X8vwZPsSdFCLy2G(object P_0, object P_1, object P_2)
	{
		return Expression.Call((Expression)P_0, (MethodInfo)P_1, (Expression[])P_2);
	}

	internal static void a5cm3yv2TkfN7eG6mZM()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
