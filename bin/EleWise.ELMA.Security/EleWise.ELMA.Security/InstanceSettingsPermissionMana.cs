using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Type;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security;

[Component]
public class InstanceSettingsPermissionManagerBehavior : EntityManagerBehavior
{
	private readonly Func<IEnumerable<IInstanceSettingsPermission>> instanceSettingsPermissions;

	private readonly ISecurityService securityService;

	protected readonly IAuthenticationService AuthenticationService;

	protected readonly IPermissionManagmentService PermissionManagmentService;

	internal static InstanceSettingsPermissionManagerBehavior RrT3VC7MRJM4g9yXNhb;

	public RunWithElevatedPrivilegiesService RunWithElevatedPrivilegiesService
	{
		[CompilerGenerated]
		get
		{
			return _003CRunWithElevatedPrivilegiesService_003Ek__BackingField;
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
					_003CRunWithElevatedPrivilegiesService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6ebd2dabc54f4311bbbe57be8fcccc48 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ITransformationProvider TransformationProvider
	{
		[CompilerGenerated]
		get
		{
			return _003CTransformationProvider_003Ek__BackingField;
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
					_003CTransformationProvider_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7eacf98b652644699fca43e43408d382 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public InstanceSettingsPermissionManagerBehavior(Func<IEnumerable<IInstanceSettingsPermission>> instanceSettingsPermissions, IAuthenticationService authenticationService, IPermissionManagmentService permissionManagmentService, ISecurityService securityService)
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		this.instanceSettingsPermissions = instanceSettingsPermissions;
		AuthenticationService = authenticationService;
		PermissionManagmentService = permissionManagmentService;
		this.securityService = securityService;
	}

	private bool HasAdminPermission(IInstanceSettingsPermission instanceSettingsPermission, IUser user)
	{
		//Discarded unreachable code: IL_006c, IL_007b
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (user == null)
				{
					num2 = 3;
					continue;
				}
				goto default;
			case 2:
				if (NK7qyl74C15pqZR7qEN(n5oDHn7IT0299fthJva(instanceSettingsPermission), null))
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5adff34accb14bd183b62ef1a2f5f964 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			default:
				return VgV0rT7VS5DmhkZe0uB(securityService, user, instanceSettingsPermission.AdminPermission);
			case 3:
				break;
			}
			break;
		}
		return false;
	}

	private IInstanceSettingsPermission GetInstanceSettingsPermission(ICriteria criteria)
	{
		//Discarded unreachable code: IL_0087, IL_00b9, IL_00f1, IL_0100
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass14_0 _003C_003Ec__DisplayClass14_ = default(_003C_003Ec__DisplayClass14_0);
		IInstanceSettingsPermission result = default(IInstanceSettingsPermission);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass14_ = new _003C_003Ec__DisplayClass14_0();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_562220c988b04dea969b2dc6cde52015 == 0)
				{
					num2 = 0;
				}
				continue;
			default:
				_003C_003Ec__DisplayClass14_.criteriaRootType = null;
				num2 = 3;
				continue;
			case 3:
				try
				{
					_003C_003Ec__DisplayClass14_.criteriaRootType = J9g3Hy7QSB5RMxg8JUJ(criteria);
					int num3 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6ebd2dabc54f4311bbbe57be8fcccc48 == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
				catch (HibernateException)
				{
					int num4 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d689f5970f6345a7af332e1f7092123f == 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							return result;
						}
						result = null;
						num4 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c78060c4cac8419092e4610bf7a03750 == 0)
						{
							num4 = 1;
						}
					}
				}
				break;
			case 2:
				break;
			}
			break;
		}
		return instanceSettingsPermissions().FirstOrDefault(_003C_003Ec__DisplayClass14_._003CGetInstanceSettingsPermission_003Eb__0);
	}

	public override void OnCreateCriteria(ICriteria criteria, IEntityFilter filter)
	{
		//Discarded unreachable code: IL_01f5, IL_0238, IL_0260, IL_026f, IL_0295, IL_0403, IL_044a, IL_0459, IL_0469, IL_049c, IL_05a6, IL_063c, IL_0646, IL_0655, IL_06cd, IL_06dc, IL_06eb, IL_07a0
		int num = 3;
		Permission permission = default(Permission);
		_003C_003Ec__DisplayClass15_0 _003C_003Ec__DisplayClass15_ = default(_003C_003Ec__DisplayClass15_0);
		Guid? permissionId = default(Guid?);
		IUser user = default(IUser);
		EntityMetadata entityMetadata = default(EntityMetadata);
		bool flag = default(bool);
		string text = default(string);
		PropertyMetadata propertyMetadata2 = default(PropertyMetadata);
		string name = default(string);
		string tableName = default(string);
		EleWise.ELMA.Security.Models.IUser user2 = default(EleWise.ELMA.Security.Models.IUser);
		Guid guid = default(Guid);
		Type entityType = default(Type);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				int num3;
				switch (num2)
				{
				case 24:
					permission = CommonPermissions.View;
					num2 = 20;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0ab7ce9a6369414380df24a533da8346 == 0)
					{
						num2 = 4;
					}
					continue;
				case 15:
					return;
				case 22:
					return;
				case 12:
					if (filter == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8ec57fd3f43f4cf7983bc996ab09feb4 == 0)
						{
							num2 = 10;
						}
						continue;
					}
					obj = aqPrNv7gr8FSWfQf7ai(filter);
					goto IL_07b0;
				case 50:
					throw new InvalidOperationException((string)k2DuDJ71lsdi1wvroBO(AbOJce7TapmG3eQdi2r(0xFD0849E ^ 0xFD0AD6C), new object[1] { sM3ub26ph8sE6I4ACyN(_003C_003Ec__DisplayClass15_.childPS) }));
				case 39:
					permissionId = filter.PermissionId;
					num = 25;
					break;
				default:
					if (!_003C_003Ec__DisplayClass15_.instanceSettingsPermission.PermissionHolderType.IsInheritOrSame<ISecuritySetIdHolder>())
					{
						return;
					}
					num = 12;
					break;
				case 48:
					permissionId = filter.PermissionId;
					num2 = 4;
					continue;
				case 7:
				case 36:
					if (user != null)
					{
						num2 = 33;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39d15279765e4050b24c0f7d69df46db == 0)
						{
							num2 = 53;
						}
						continue;
					}
					return;
				case 37:
					entityMetadata = (EntityMetadata)ipENrN79RZ3Pn6tW6Fy(XIJe2J7SRBMyayOQDXT(_003C_003Ec__DisplayClass15_.instanceSettingsPermission), true, true);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_75955a8c33b24cdca4663f20d9ee3c3b == 0)
					{
						num2 = 9;
					}
					continue;
				case 23:
					return;
				case 49:
					if (_003C_003Ec__DisplayClass15_.instanceSettingsPermission == null)
					{
						num2 = 22;
						continue;
					}
					goto default;
				case 16:
					return;
				case 2:
					if (filter != null)
					{
						num2 = 23;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0b98d9f52b424149868b80d852714a70 == 0)
						{
							num2 = 52;
						}
						continue;
					}
					goto IL_05cb;
				case 21:
					return;
				case 33:
					flag = HasAdminPermission(_003C_003Ec__DisplayClass15_.instanceSettingsPermission, user);
					num2 = 6;
					continue;
				case 6:
					if (filter == null && flag)
					{
						num = 16;
						break;
					}
					goto case 31;
				case 43:
					throw new InvalidOperationException((string)k2DuDJ71lsdi1wvroBO(AbOJce7TapmG3eQdi2r(0xBBC1CCD ^ 0xBBC353F), new object[1] { gEZnh87f4u0biWgaA4n(_003C_003Ec__DisplayClass15_.instanceSettingsPermission) }));
				case 13:
					text = (string)KTfl7e6kDlDp09jRE6t((SimpleTypeSettings)x9RQ9G7zykn134xSPV8(propertyMetadata2));
					num = 29;
					break;
				case 1:
					name = (string)AbOJce7TapmG3eQdi2r(0xA5DAE86 ^ 0xA5DBE96);
					num2 = 44;
					continue;
				case 52:
					if (JM1bId7dCfShB9sr01h(filter))
					{
						num2 = 14;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f6614d006512404f8cab65f09d3e1c89 == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto IL_05cb;
				case 40:
					return;
				case 46:
					if (!RunWithElevatedPrivilegiesService.Turned)
					{
						_003C_003Ec__DisplayClass15_.instanceSettingsPermission = GetInstanceSettingsPermission(criteria);
						num2 = 49;
						continue;
					}
					num2 = 21;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0f87584a8fee4f91864943acbd35d6d6 == 0)
					{
						num2 = 18;
					}
					continue;
				case 9:
					propertyMetadata2 = entityMetadata.Properties.FirstOrDefault(_003C_003Ec__DisplayClass15_._003COnCreateCriteria_003Eb__0);
					num2 = 11;
					continue;
				case 34:
					num3 = ((!CPlsoS7rwemVMlc9SIs(filter)) ? 1 : 0);
					goto IL_07dd;
				case 31:
					if (filter != null)
					{
						num2 = 30;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae9e5ed1f04543cd9a3ea633dd768889 != 0)
						{
							num2 = 34;
						}
						continue;
					}
					num3 = 0;
					goto IL_07dd;
				case 44:
					_003C_003Ec__DisplayClass15_.childPS = _003C_003Ec__DisplayClass15_.instanceSettingsPermission as IInstanceSettingsPermissionChild;
					num2 = 17;
					continue;
				case 19:
					return;
				case 29:
					tableName = entityMetadata.TableName;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_07d1789322864bd7a6f8c5e113ce5c9a != 0)
					{
						num2 = 1;
					}
					continue;
				case 32:
				case 45:
					pR78Nx6i16JEyRXHUyt(criteria, rTPiL96nNQg7x0TE5jM(RyBAI16X72q7eZf9jSb(AbOJce7TapmG3eQdi2r(-905821499 ^ -905811823), UTBaDP65k6ug4k6Pe5I(TransformationProvider, tableName, AbOJce7TapmG3eQdi2r(0x4E6718AE ^ 0x4E673302)), ((Dialect)hSp8Lm6AObk4OYIIchM(TransformationProvider)).QuoteIfNeeded(name), VllQDK6WqnNDSYSlo3u(hSp8Lm6AObk4OYIIchM(TransformationProvider), text)), new object[2] { user2.Id, guid }, new IType[2]
					{
						(IType)NHibernateUtil.Int64,
						(IType)NHibernateUtil.Guid
					}));
					num2 = 19;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39d15279765e4050b24c0f7d69df46db != 0)
					{
						num2 = 10;
					}
					continue;
				case 8:
				case 26:
				case 41:
					if (s5yJLh73hQ8AJTpN4PA(_003C_003Ec__DisplayClass15_.instanceSettingsPermission))
					{
						entityType = mJqHrF7yIiTKArsyUQI(_003C_003Ec__DisplayClass15_.instanceSettingsPermission);
						num2 = 38;
					}
					else
					{
						num2 = 23;
					}
					continue;
				case 20:
				case 30:
					guid = WMha8k7bU7MdUp2e37g(permission);
					num2 = 3;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_05864899c47d415d8fae32c68fb25d39 == 0)
					{
						num2 = 7;
					}
					continue;
				case 42:
					guid = _003C_003Ec__DisplayClass15_.childPS.GetParentPermissionId(guid);
					num2 = 45;
					continue;
				case 14:
					return;
				case 25:
					if (!permissionId.HasValue)
					{
						num = 41;
						break;
					}
					goto case 48;
				case 51:
					if (!(permission == null))
					{
						num2 = 30;
						continue;
					}
					goto case 24;
				case 3:
					_003C_003Ec__DisplayClass15_ = new _003C_003Ec__DisplayClass15_0();
					num = 2;
					break;
				case 10:
					obj = null;
					goto IL_07b0;
				case 11:
					if (propertyMetadata2 != null)
					{
						num2 = 13;
						continue;
					}
					goto case 43;
				case 38:
					permission = PermissionManagmentService.GetPermissionForBase(CommonPermissions.View, entityType);
					num2 = 51;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2203cd019614c439eaf162fdd0eb05d == 0)
					{
						num2 = 25;
					}
					continue;
				case 27:
					return;
				case 53:
					user2 = (EleWise.ELMA.Security.Models.IUser)user;
					num = 37;
					break;
				case 35:
					return;
				case 5:
					if (filter == null)
					{
						num2 = 26;
						continue;
					}
					goto case 39;
				case 17:
					if (_003C_003Ec__DisplayClass15_.childPS == null)
					{
						num2 = 22;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2df53c26a6094060a56f82d6cf94e7da == 0)
						{
							num2 = 32;
						}
						continue;
					}
					goto case 28;
				case 4:
					guid = permissionId.Value;
					num2 = 36;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6b49024d17a94a69b2948ac938d43b7c != 0)
					{
						num2 = 13;
					}
					continue;
				case 18:
					if (propertyMetadata != null)
					{
						name = ((SimpleTypeSettings)x9RQ9G7zykn134xSPV8(propertyMetadata)).FieldName;
						num2 = 42;
						continue;
					}
					num2 = 24;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39a415f51fd045a981443759203cc0ad == 0)
					{
						num2 = 50;
					}
					continue;
				case 28:
					propertyMetadata = ((EntityMetadata)ipENrN79RZ3Pn6tW6Fy(_003C_003Ec__DisplayClass15_.childPS.EntityType, true, true)).Properties.FirstOrDefault(_003C_003Ec__DisplayClass15_._003COnCreateCriteria_003Eb__1);
					num2 = 18;
					continue;
				case 47:
					{
						obj = Y82VHF78b1Q55HJEcNk(AuthenticationService);
						goto IL_07d0;
					}
					IL_07d0:
					user = (IUser)obj;
					num2 = 33;
					continue;
					IL_07b0:
					if (obj == null)
					{
						num = 47;
						break;
					}
					goto IL_07d0;
					IL_07dd:
					if (((uint)num3 & (flag ? 1u : 0u)) != 0)
					{
						return;
					}
					num2 = 5;
					continue;
					IL_05cb:
					if (SR.GetSetting((string)AbOJce7TapmG3eQdi2r(0x43ED0455 ^ 0x43ED1239), defaultValue: false))
					{
						return;
					}
					num2 = 46;
					continue;
				}
				break;
			}
		}
	}

	internal static bool DYCP5i7sqM3Ue5ZRga1()
	{
		return RrT3VC7MRJM4g9yXNhb == null;
	}

	internal static InstanceSettingsPermissionManagerBehavior kx089o7Y325LkkhcXBw()
	{
		return RrT3VC7MRJM4g9yXNhb;
	}

	internal static object n5oDHn7IT0299fthJva(object P_0)
	{
		return ((IInstanceSettingsPermission)P_0).AdminPermission;
	}

	internal static bool NK7qyl74C15pqZR7qEN(object P_0, object P_1)
	{
		return (Permission)P_0 != (Permission)P_1;
	}

	internal static bool VgV0rT7VS5DmhkZe0uB(object P_0, object P_1, object P_2)
	{
		return ((ISecurityService)P_0).HasPermission((IUser)P_1, (Permission)P_2);
	}

	internal static Type J9g3Hy7QSB5RMxg8JUJ(object P_0)
	{
		return ((ICriteria)P_0).GetRootEntityTypeIfAvailable();
	}

	internal static bool JM1bId7dCfShB9sr01h(object P_0)
	{
		return ((IEntityFilter)P_0).DisableSecurity;
	}

	internal static object AbOJce7TapmG3eQdi2r(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object aqPrNv7gr8FSWfQf7ai(object P_0)
	{
		return ((IEntityFilter)P_0).PermissionUser;
	}

	internal static object Y82VHF78b1Q55HJEcNk(object P_0)
	{
		return ((IAuthenticationService)P_0).GetCurrentUser();
	}

	internal static bool CPlsoS7rwemVMlc9SIs(object P_0)
	{
		return ((IEntityFilter)P_0).SkipAdminPermission;
	}

	internal static bool s5yJLh73hQ8AJTpN4PA(object P_0)
	{
		return ((IInstanceSettingsPermission)P_0).Filtering;
	}

	internal static Type mJqHrF7yIiTKArsyUQI(object P_0)
	{
		return ((IInstanceSettingsPermission)P_0).EntityType;
	}

	internal static Guid WMha8k7bU7MdUp2e37g(object P_0)
	{
		return ((Permission)P_0).Id;
	}

	internal static Type XIJe2J7SRBMyayOQDXT(object P_0)
	{
		return ((IInstanceSettingsPermission)P_0).PermissionHolderType;
	}

	internal static object ipENrN79RZ3Pn6tW6Fy(Type P_0, bool P_1, bool P_2)
	{
		return MetadataLoader.LoadMetadata(P_0, P_1, P_2);
	}

	internal static object gEZnh87f4u0biWgaA4n(object P_0)
	{
		return ((IInstanceSettingsPermission)P_0).TargetPropetyName;
	}

	internal static object k2DuDJ71lsdi1wvroBO(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static object x9RQ9G7zykn134xSPV8(object P_0)
	{
		return ((PropertyMetadata)P_0).Settings;
	}

	internal static object KTfl7e6kDlDp09jRE6t(object P_0)
	{
		return ((SimpleTypeSettings)P_0).FieldName;
	}

	internal static object sM3ub26ph8sE6I4ACyN(object P_0)
	{
		return ((IInstanceSettingsPermissionChild)P_0).ParentPropertyName;
	}

	internal static object UTBaDP65k6ug4k6Pe5I(object P_0, object P_1, object P_2)
	{
		return ((ITransformationProvider)P_0).NoLockTableExpression((string)P_1, (string)P_2);
	}

	internal static object hSp8Lm6AObk4OYIIchM(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object VllQDK6WqnNDSYSlo3u(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object RyBAI16X72q7eZf9jSb(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static object rTPiL96nNQg7x0TE5jM(object P_0, object P_1, object P_2)
	{
		return Expression.Sql((string)P_0, (object[])P_1, (IType[])P_2);
	}

	internal static object pR78Nx6i16JEyRXHUyt(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}
}
