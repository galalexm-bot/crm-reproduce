using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Cache.Attributes;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Security.ExtensionPoints;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security;

[Service(Scope = ServiceScope.Shell, Type = ComponentType.Server, EnableInterceptors = true)]
public class PermissionManagmentService : IPermissionManagmentService, IModuleContainerEvents
{
	private IEnumerable<IPermissionManagmentServiceExtension> permissionManagmentServiceExtensions;

	private IEnumerable<IPermissionProvider> _permissionProviders;

	private IEnumerable<IModuleAccessPermissionProvider> _moduleAccessPermissionProviders;

	private bool permissionsCheckd;

	private static PermissionManagmentService gP2sqRlpuhAd8AGtY4J;

	public PermissionManagmentService(IEnumerable<IPermissionProvider> permissionProviders, IEnumerable<IModuleAccessPermissionProvider> moduleAccessPermissionProviders, IEnumerable<IPermissionManagmentServiceExtension> permissionManagmentServiceExtensions)
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		_permissionProviders = permissionProviders;
		_moduleAccessPermissionProviders = moduleAccessPermissionProviders;
		this.permissionManagmentServiceExtensions = permissionManagmentServiceExtensions;
	}

	public void Activated()
	{
		CheckPermissions();
	}

	public void Terminating()
	{
	}

	[ContextCache]
	public virtual IEnumerable<Permission> GetPermissions()
	{
		CheckPermissions();
		return _permissionProviders.SelectMany((IPermissionProvider pp) => pp.GetPermissions());
	}

	[ContextCache]
	public virtual Permission GetPermission(Guid permissionId)
	{
		int num = 1;
		int num2 = num;
		Permission value = default(Permission);
		while (true)
		{
			switch (num2)
			{
			default:
				return value;
			case 1:
				GetPermissionsById().TryGetValue(permissionId, out value);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a16ce287ba7944e2afcf4e52864ec01d == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public Permission GetPermissionForBase(Permission permission, Type entityType)
	{
		//Discarded unreachable code: IL_016c, IL_017b, IL_01ef
		int num = 11;
		_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = default(_003C_003Ec__DisplayClass6_0);
		_003C_003Ec__DisplayClass6_1 _003C_003Ec__DisplayClass6_2 = default(_003C_003Ec__DisplayClass6_1);
		Permission permission2 = default(Permission);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 10:
					_003C_003Ec__DisplayClass6_.permission = permission;
					num2 = 5;
					continue;
				case 5:
					_003C_003Ec__DisplayClass6_.entityType = entityType;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5c5fc9a9dec4418fa9513347a116bf27 != 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					goto end_IL_0012;
				case 8:
					_003C_003Ec__DisplayClass6_2.metadata = iteaFplnubwM01Kf1xr(_003C_003Ec__DisplayClass6_2.CS_0024_003C_003E8__locals1.entityType, true, true) as ClassMetadata;
					num2 = 9;
					continue;
				case 2:
				case 7:
				case 12:
					return permission2;
				case 14:
					if (!maWFkLlXitOUGTDo9vm(permission2, null))
					{
						num2 = 7;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7fbc19cae8c8414894251bb8ae24a12e == 0)
						{
							num2 = 12;
						}
						continue;
					}
					goto case 3;
				case 3:
					if (_003C_003Ec__DisplayClass6_.entityType != null)
					{
						num2 = 4;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8ec57fd3f43f4cf7983bc996ab09feb4 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 2;
				case 6:
					_003C_003Ec__DisplayClass6_2.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass6_;
					num2 = 8;
					continue;
				default:
					permission2 = GetPermissions().FirstOrDefault(_003C_003Ec__DisplayClass6_._003CGetPermissionForBase_003Eb__0);
					num2 = 6;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39d15279765e4050b24c0f7d69df46db == 0)
					{
						num2 = 14;
					}
					continue;
				case 9:
					if (_003C_003Ec__DisplayClass6_2.metadata == null)
					{
						num2 = 2;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_daaf990ff0c644fb99cfba0a043a9b93 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				case 1:
					_003C_003Ec__DisplayClass6_.entityType = b4nmJFlWb18YHKcpgYZ(_003C_003Ec__DisplayClass6_.entityType);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8b4bc2d0df7346ebba20e6c22632a575 == 0)
					{
						num2 = 0;
					}
					continue;
				case 11:
					_003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
					num2 = 10;
					continue;
				case 13:
					break;
				}
				permission2 = (from p in permissionManagmentServiceExtensions.Select(_003C_003Ec__DisplayClass6_2._003CGetPermissionForBase_003Eb__1)
					where _003C_003Ec.V1UDrip7xM8m2ebknic8(p, null)
					select p).FirstOrDefault();
				num2 = 4;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_86eb143f59c14824a2785845ea23f248 == 0)
				{
					num2 = 7;
				}
				continue;
				end_IL_0012:
				break;
			}
			_003C_003Ec__DisplayClass6_2 = new _003C_003Ec__DisplayClass6_1();
			num = 6;
		}
	}

	[ContextCache]
	public virtual Permission GetModuleAccessPermission(string moduleUid)
	{
		int num = 1;
		int num2 = num;
		Permission value = default(Permission);
		while (true)
		{
			switch (num2)
			{
			default:
				return value;
			case 1:
				GetModuleAccessPermissionsById().TryGetValue(moduleUid, out value);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7fbc19cae8c8414894251bb8ae24a12e == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[ContextCache]
	protected virtual Dictionary<Guid, Permission> GetPermissionsById()
	{
		return GetPermissions().ToDictionary((Permission p) => _003C_003Ec.exsNu3p7BSqUuK6Uma0a(p));
	}

	[ContextCache]
	protected virtual Dictionary<string, Permission> GetModuleAccessPermissionsById()
	{
		return _moduleAccessPermissionProviders.SelectMany((IModuleAccessPermissionProvider pp) => pp.GetModuleAccessPermissions()).ToDictionary((KeyValuePair<string, Permission> p) => p.Key, (KeyValuePair<string, Permission> p) => p.Value);
	}

	private void CheckPermissions()
	{
		//Discarded unreachable code: IL_00d6
		int num = 2;
		string text = default(string);
		_003C_003Ec__DisplayClass13_0 _003C_003Ec__DisplayClass13_ = default(_003C_003Ec__DisplayClass13_0);
		_003C_003Ef__AnonymousType3<Permission, IPermissionProvider>[] array = default(_003C_003Ef__AnonymousType3<Permission, IPermissionProvider>[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					return;
				case 9:
					text = (string)rHdxZiliaR4tWYFsbuQ(sX2sr3l7hXNj1UcGApK(0x7CAA49C6 ^ 0x7CAA6506));
					num = 8;
					break;
				case 1:
					if (!permissionsCheckd)
					{
						permissionsCheckd = true;
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b6bf1b70a8924e789fc4be8e9aadc953 == 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 2;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_01fd90314ba945f0a4ee79d2372961e2 != 0)
						{
							num2 = 5;
						}
					}
					continue;
				case 2:
					_003C_003Ec__DisplayClass13_ = new _003C_003Ec__DisplayClass13_0();
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_06e91bc1320c425bb120c2fac8d1e3be != 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					return;
				case 7:
					return;
				case 6:
					Oflti2llLjoA0ZmxnhK(Logger.Log, text);
					num = 7;
					break;
				case 4:
					if (array.Length == 0)
					{
						num2 = 3;
						continue;
					}
					goto case 9;
				default:
				{
					var source = _permissionProviders.SelectMany(delegate(IPermissionProvider i)
					{
						_003C_003Ec__DisplayClass13_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass13_1();
						CS_0024_003C_003E8__locals0.i = i;
						return from p in CS_0024_003C_003E8__locals0.i.GetPermissions()
							select new
							{
								permission = p,
								provider = CS_0024_003C_003E8__locals0.i
							};
					}).ToList();
					var array2 = (from v in source
						group v by v.permission.Id into g
						where g.Count() > 1
						select g).ToArray();
					if (array2.Length != 0)
					{
						throw new InvalidOperationException((string)rHdxZiliaR4tWYFsbuQ(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-726732645 ^ -726737711)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1A9A1A63 ^ 0x1A9A3F6F) + string.Join((string)sX2sr3l7hXNj1UcGApK(0x4B68CDFB ^ 0x4B68E8F7), array2.Select(g => SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-724676315 ^ -724600031) + g.Key.ToString() + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1757426405 ^ -1757485301) + string.Join(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1788380826 ^ -1788382984), g.Select(v => string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1A9A1A63 ^ 0x1A9B3075), v.provider, v.permission.Name))) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x78610A3D ^ 0x78618D47))));
					}
					_003C_003Ec__DisplayClass13_.securityService = Locator.GetServiceNotNull<ISecurityService>();
					array = source.Where(_003C_003Ec__DisplayClass13_._003CCheckPermissions_003Eb__3).ToArray();
					num2 = 4;
					continue;
				}
				case 8:
					text = (string)PvliCtl6xuG7CCqYHAG(text, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4D765E72 ^ 0x4D767B7E), string.Join((string)sX2sr3l7hXNj1UcGApK(-1757426405 ^ -1757419497), array.Select(v => string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7DABA580 ^ 0x7DAA8F96), v.provider, v.permission.Name))));
					num2 = 6;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1c9893e65c104705bb8b228f8a38d9cd == 0)
					{
						num2 = 5;
					}
					continue;
				}
				break;
			}
		}
	}

	internal static bool v04lyql58dt5YMZK2SW()
	{
		return gP2sqRlpuhAd8AGtY4J == null;
	}

	internal static PermissionManagmentService Nldh2ZlAsnbJtgcsrSb()
	{
		return gP2sqRlpuhAd8AGtY4J;
	}

	internal static Type b4nmJFlWb18YHKcpgYZ(Type P_0)
	{
		return InterfaceActivator.TypeOf(P_0);
	}

	internal static bool maWFkLlXitOUGTDo9vm(object P_0, object P_1)
	{
		return (Permission)P_0 == (Permission)P_1;
	}

	internal static object iteaFplnubwM01Kf1xr(Type P_0, bool P_1, bool P_2)
	{
		return MetadataLoader.LoadMetadata(P_0, P_1, P_2);
	}

	internal static object rHdxZiliaR4tWYFsbuQ(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object sX2sr3l7hXNj1UcGApK(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object PvliCtl6xuG7CCqYHAG(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static void Oflti2llLjoA0ZmxnhK(object P_0, object P_1)
	{
		((ILogger)P_0).Error(P_1);
	}
}
